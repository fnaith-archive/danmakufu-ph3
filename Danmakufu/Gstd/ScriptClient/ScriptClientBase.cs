using System;
using System.Collections.Generic;
using Gstd.GstdUtility;
using Gstd.Script;
using Gstd.File;
using Gstd.MersenneTwister;

namespace Gstd
{
    namespace ScriptClient
    {
        sealed class ScriptClientBase : System.IDisposable
        {
            public const int ID_SCRIPT_FREE = -1;
            public static ScriptTypeManager GetDefaultScriptTypeManager()
            {
                return typeManagerDefault;
            }
            private static ScriptTypeManager typeManagerDefault = new ScriptTypeManager();

            private bool bError;
            private ScriptEngineCache cache;
            private ScriptEngineData engine;
            private ScriptMachine machine;

            private List<Function> func = new List<Function>();
            public MersenneTwister.MersenneTwister mt; // TODO private
            private ScriptCommonDataManager commonDataManager;
            private int mainThreadID;
            private long idScript;

            /*private gstd::CriticalSection criticalSection_;*/

            public List<Value> listValueArg; // TODO private
            public Value valueRes; // TODO private
            
            public ScriptClientBase()
            {
                bError = false;
                cache = new ScriptEngineCache();
                engine = new ScriptEngineData();
                machine = null;
                mainThreadID = -1;
                idScript = ID_SCRIPT_FREE;
                listValueArg = new List<Value>();
                valueRes = new Value();

                commonDataManager = new ScriptCommonDataManager();
                mt = new MersenneTwister.MersenneTwister();
                mt.Initialize((uint)System.Environment.TickCount);
                func = new List<Function>();
                _AddFunction(BuildInFunction.commonFunction);
            }
            public void Dispose()
            {
                if (machine != null)
                {
                    machine.Dispose();
                }
                machine = null;
                engine = null;
            }
            public void SetScriptEngineCache(ScriptEngineCache cache)
            {
                this.cache = cache;
            }
            public ScriptEngineData GetEngine()
            {
                return engine;
            }
            public bool SetSourceFromFile(string path)
            {
                path = PathProperty.GetUnique(path);
                if (cache != null && cache.IsExists(path))
                {
                    engine = cache.GetCache(path);
                    return true;
                }

                engine.SetPath(path);
                FileManager fileManager = new FileManager(); // TODO remove
                fileManager.Initialize(); // TODO remove
                FileReader reader = FileManager.GetBase().GetFileReader(path);
                
                if (reader == null)
                {
                    throw new Exception(/*ErrorUtility.GetFileNotFoundErrorMessage*/(path));
                }
                if (!reader.Open())
                {
                    throw new Exception(/*ErrorUtility.GetFileNotFoundErrorMessage*/(path));
                }

                int size = reader.GetFileSize();
                char[] source = new char[size];
                reader.Read(source, size);
                this.SetSource(new string(source));
                return true;
            }
            public void SetSource(string source)
            {
                engine.SetSource(source);
                ScriptFileLineMap mapLine = engine.GetScriptFileLineMap();
                mapLine.AddEntry(engine.GetPath(), 1, StringUtility.CountCharacter(source, '\n') + 1);
            }
            public string GetPath()
            {
                return engine.GetPath();
            }
            public void SetPath(string path)
            {
                engine.SetPath(path);
            }
            public void Compile()
            {
                if (engine.GetEngine() == null)
                {
                    string source = _Include(engine.GetSource());
                    engine.SetSource(source);

                    _CreateEngine();
                    if (engine.GetEngine().Error)
                    {			
                        bError = true;
                        _RaiseErrorFromEngine();
                    }
                    if (cache != null && engine.GetPath().Length != 0)
                    {
                        cache.AddCache(engine.GetPath(), engine);
                    }
                }

                if (machine != null)
                {
                    machine = null;
                }
                machine = new ScriptMachine(engine.GetEngine());
                if (machine.Error)
                {	
                    bError = true;
                    _RaiseErrorFromMachine();
                }
                machine.data = this;
            }
            public bool Run()
            {
                if (bError)
                {
                    return false;
                }
                machine.Run();
                if (machine.Error)
                {	
                    bError = true;
                    _RaiseErrorFromMachine();
                }
                return true;
            }
            public bool Run(string target)
            {
                if (bError)
                {
                    return false;
                }
                if (!machine.HasEvent(target))
                {
                    string error = "@ not found[" + target + "]";
                    _RaiseError(0, error);
                }

                Run();
                machine.Call(target);
                if (machine.Error)
                {	
                    bError = true;
                    _RaiseErrorFromMachine();
                }
                return true;
            }
            public bool IsEventExists(string name)
            {
                if (bError)
                {
                    return false;
                }
                return machine.HasEvent(name);
            }
            public void RaiseError(string error)
            {
                _RaiseError(machine.ErrorLine, error);
            }
            public void Terminate(string error)
            {
                machine.Terminate(error);
            }
            public long GetScriptID()
            {
                return idScript;
            }
            public int GetThreadCount()
            {
                if (machine == null)
                {
                    return 0;
                }
                int res = machine.GetThreadCount();
                return res;
            }
            public void AddArgumentValue(Value v)
            {
                listValueArg.Add(v);
            }
            public void SetArgumentValue(Value v, int index = 0)
            {
                while (listValueArg.Count < index + 1) {
                    listValueArg.Add(new Value());
                }
                listValueArg[index] = v;
            }
            public Value GetResultValue()
            {
                return valueRes;
            }
            public Value CreateRealValue(double r)
            {
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                return new Value(typeManager.RealType, r);
            }
            public Value CreateBooleanValue(bool b)
            {
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                return new Value(typeManager.BooleanType, b);
            }
            public Value CreateStringValue(string s)
            {
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                return new Value(typeManager.StringType, s);
            }
            public Value CreateRealArrayValue(List<double> list)
            {
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                Value res = new Value(typeManager.StringType, "");
                foreach (double d in list)
                {
                    Value data = CreateRealValue(d);
                    res.Append(typeManager.GetArrayType(typeManager.RealType), data);
                }
                return res;
            }
            public Value CreateStringArrayValue(List<string> list)
            {
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                Value res = new Value(typeManager.StringType, "");
                foreach (string s in list)
                {
                    Value data = CreateStringValue(s);
                    res.Append(typeManager.GetArrayType(typeManager.StringType), data);
                }
                return res;
            }
            public Value CreateValueArrayValue(List<Value> list)
            {
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                Value res = new Value(typeManager.StringType, "");
                foreach (Value data in list)
                {
                    res.Append(typeManager.GetArrayType(typeManager.RealType), data);
                }
                return res;
            }
            public bool IsRealValue(Value v)
            {
                if (bError)
                {
                    return false;
                }
                if (!v.HasData())
                {
                    return false;
                }
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                return v.GetDataType() == typeManager.RealType;
            }
            public bool IsBooleanValue(Value v)
            {
                if (bError)
                {
                    return false;
                }
                if (!v.HasData())
                {
                    return false;
                }
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                return v.GetDataType() == typeManager.BooleanType;
            }
            public bool IsStringValue(Value v)
            {
                if (bError)
                {
                    return false;
                }
                if (!v.HasData())
                {
                    return false;
                }
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
                return v.GetDataType() == typeManager.StringType;
            }
            public bool IsRealArrayValue(Value v)
            {
                if (bError)
                {
                    return false;
                }
                if (!v.HasData())
                {
                    return false;
                }
                ScriptTypeManager typeManager = GetEngine().GetEngine().TypeManager;
	            return v.GetDataType() == typeManager.GetArrayType(typeManager.RealType);
            }
            /*public void CheckRunInMainThread() TODO remove
            {
                if (mainThreadID < 0)
                {
                    return;
                }
                if (mainThreadID != GetCurrentThreadId())
                {
                    string error = "This function can call in main thread only.\r\n";
                    machine.RaiseError(error);
                }
            }*/
            public ScriptCommonDataManager GetCommonDataManager()
            {
                return commonDataManager;
            }

            private void _AddFunction(string name, Callback f, int arguments)
            {
                Function tFunc = new Function(name, f, arguments);
                func.Add(tFunc);
            }
            private void _AddFunction(Function[] functions)
            {
                foreach (Function f in functions)
                {
                    func.Add(f);
                }
            }
            private void _RaiseErrorFromEngine()
            {
                int line = engine.GetEngine().ErrorLine;
                _RaiseError(line, engine.GetEngine().ErrorMessage);
            }
            private void _RaiseErrorFromMachine()
            {
                int line = machine.ErrorLine;
                _RaiseError(line, machine.ErrorMessage);
            }
            private void _RaiseError(int line, string message)
            {
                bError = true;
                string errorPos = _GetErrorLineSource(line);

                ScriptFileLineMap mapLine = engine.GetScriptFileLineMap();
                Entry entry = mapLine.GetEntry(line);
                int lineOriginal = entry.LineEndOriginal - (entry.LineEnd - line);

                string fileName = PathProperty.GetFileName(entry.Path);
                //Console.WriteLine(">>> {0} {1} {2}",  entry.LineEndOriginal ,entry.LineEnd, line);

                string str = String.Format("{0}\r\n{1}\r\n{2} line(s)={3}\r\n\r\n{4}\r\n", message, entry.Path, fileName, lineOriginal, errorPos);
                throw new ScriptException(str);
            }
            private string _GetErrorLineSource(int line)
            {
                if (line == 0)
                {
                    return "";
                }
                --line;
                string source = engine.GetSource();
                string[] strs = source.Split('\n');
                if (strs.Length <= line)
                {
                    return "";
                }
                return strs[line];
            }
            private string _Include(string source)
            {
                //TODO �Ƃ肠��������
                string pathSource = engine.GetPath();
                string res = source;
                FileManager fileManager = FileManager.GetBase();
                HashSet<string> setReadPath = new HashSet<string>();
                
                ScriptFileLineMap mapLine = new ScriptFileLineMap();
                engine.SetScriptFileLineMap(mapLine);

                mapLine.AddEntry(pathSource,
                    1, 
                    StringUtility.CountCharacter(source, '\n') + 1);

                bool bEnd = false;
                while (true)
                {
                    if (bEnd)
                    {
                        break;
                    }
                    GstdUtility.Scanner scanner = new GstdUtility.Scanner(res.ToCharArray());
                    int resSize = res.Length;
                
                    bEnd = true;
                    while (scanner.HasNext())
                    {
                        Token tok = scanner.Next();
                        if (tok.GetTokenType() == TokenType.TK_EOF)//Eof�̎��ʎq��������t�@�C���̒����I��
                        {
                            break;
                        }
                        else if (tok.GetTokenType() == TokenType.TK_SHARP)
                        {
                            int posInclude = scanner.GetCurrentPointer() - 1;

                            tok = scanner.Next();
                            if (tok.GetElement() != "include" )
                            {
                                continue;
                            }

                            bEnd = false;
                            int posCurrent = scanner.GetCurrentPointer();
                            string wPath = scanner.Next().GetString();
                            bool bNeedNewLine = false;
                            if (scanner.HasNext())
                            {
                                int posBeforeNewLine = scanner.GetCurrentPointer();
                                if (scanner.Next().GetTokenType() != TokenType.TK_NEWLINE)
                                {
                                    int line = scanner.GetCurrentLine();
                                    source = res;
                                    engine.SetSource(source);

                                    string error = "New line is not found after #include.\r\n";
                                    _RaiseError(line, error);
                                }
                                scanner.SetCurrentPointer(posBeforeNewLine);
                            }
                            else
                            {
                                //bNeedNewLine = true;
                            }
                            int posAfterInclude = scanner.GetCurrentPointer();
                            scanner.SetCurrentPointer(posCurrent);

                            // "../"����n�܂��Ă�����A�O��"./"������B
                            if (wPath.IndexOf("../") == 0 || wPath.IndexOf("..\\") == 0)
                            {
                                wPath = "./" + wPath;
                            }

                            if (wPath.IndexOf(".\\") != -1 || wPath.IndexOf("./") != -1)
                            {	//".\"�W�J
                                int line = scanner.GetCurrentLine();
                                string linePath = mapLine.GetPath(line);
                                string tDir = PathProperty.GetFileDirectory(linePath);
                                //std::string tDir = PathProperty::GetFileDirectory(pathSource);
                                wPath = tDir.Substring(PathProperty.GetModuleDirectory().Length) + wPath.Substring(2);
                            }
                            wPath = PathProperty.GetModuleDirectory() + wPath;
                            wPath = PathProperty.GetUnique(wPath);

                            bool bReadPath = setReadPath.Contains(wPath);
                            if (bReadPath)
                            {//���łɓǂݍ��܂�Ă���
                                int size1 = posInclude;
                                int size2 = res.Length - posAfterInclude;
                                //Console.WriteLine(String.Format("{0} {1} {2}\n{3}", size1, res.Length, posAfterInclude, res));
                                string newSource = res.Substring(0, size1) + res.Substring(size1 + posAfterInclude, size1 + size2);
                                
                                res = newSource;
                                break;
                            }

                            char[] placement = null;
                            FileReader reader;
                            reader = fileManager.GetFileReader(wPath);
                            if (reader == null || !reader.Open())
                            {
                                int line = scanner.GetCurrentLine();
                                source = res;
                                engine.SetSource(source);

                                string error = "#Include file is not found[%s].\r\n";
                                //error += StringUtility::Format(L"#Include file is not found[%s].\r\n", wPath.c_str());
                                //error += StringUtility::Format(L"(#include�Œu������t�@�C��[%s]��������܂���)", wPath.c_str());
                                _RaiseError(line, error);
                            }

                            //�t�@�C����ǂݍ��ݍŌ�ɉ��s��t��
                            int targetBomSize = 0;
                            if (reader.GetFileSize() >= 2)
                            {
                                //�t�@�C���|�C���^���ŏ��ɖ߂�
                                reader.SetFilePointerBegin();
                            }

                            //�ǂݍ��ݑΏۂ�ShiftJis
                            int newLineSize = 2;
                            int fileSize = reader.GetFileSize();
                            placement = new char[fileSize + newLineSize];
                            reader.Read(placement, fileSize);
                            placement[fileSize + 0] = '\r';
                            placement[fileSize + 1] = '\n';

                            mapLine.AddEntry(wPath,
                                scanner.GetCurrentLine(), 
                                StringUtility.CountCharacter(placement, '\n') + 1);

                            {//�u��
                                char[] newSource;
                                int size1 = posInclude;
                                int size2 = res.Length - posAfterInclude;
                                int sizeP = placement.Length;
                                newSource = new char[size1 + sizeP + size2];
                                char[] resArr = res.ToCharArray();
                                Array.Copy(resArr, 0, newSource, 0, size1);
                                Array.Copy(placement, 0, newSource, size1, sizeP);
                                Array.Copy(resArr, posAfterInclude, newSource, size1 + sizeP, size2);

                                res = new string(newSource);
                            }
                            setReadPath.Add(wPath);

                            /*if(false)
                            {
                                static int countTest = 0;
                                static std::wstring tPath = L"";
                                if(tPath != pathSource)
                                {
                                    countTest = 0;
                                    tPath = pathSource;
                                }
                                std::wstring pathTest = PathProperty::GetModuleDirectory() + StringUtility::Format(L"temp\\script_%s%03d.txt", PathProperty::GetFileName(pathSource).c_str(), countTest);
                                File file(pathTest);
                                file.CreateDirectory();
                                file.Create();
                                file.Write(&res[0], res.size());

                                std::string strNewLine = "\r\n";
                                std::wstring strNewLineW = L"\r\n";
                                if(encoding == Encoding::UTF16LE)
                                {
                                    file.Write(&strNewLineW[0] , strNewLine.size() * sizeof(wchar_t));
                                    file.Write(&strNewLineW[0] , strNewLine.size() * sizeof(wchar_t));
                                }
                                else
                                {
                                    file.Write(&strNewLine[0] , strNewLine.size());
                                    file.Write(&strNewLine[0] , strNewLine.size());
                                }

                                std::list<ScriptFileLineMap::Entry> listEntry = mapLine->GetEntryList();
                                std::list<ScriptFileLineMap::Entry>::iterator itr = listEntry.begin();
                                for(; itr != listEntry.end() ; itr++)
                                {
                                    if(encoding == Encoding::UTF16LE)
                                    {
                                        ScriptFileLineMap::Entry entry = (*itr);
                                        std::wstring strPath = entry.path_ + L"\r\n";
                                        std::wstring strLineStart = StringUtility::Format(   L"  lineStart   :%4d\r\n", entry.lineStart_);
                                        std::wstring strLineEnd = StringUtility::Format(     L"  lineEnd     :%4d\r\n", entry.lineEnd_);
                                        std::wstring strLineStartOrg = StringUtility::Format(L"  lineStartOrg:%4d\r\n", entry.lineStartOriginal_);
                                        std::wstring strLineEndOrg = StringUtility::Format(  L"  lineEndOrg  :%4d\r\n", entry.lineEndOriginal_);
                                    
                                        file.Write(&strPath[0] , strPath.size() * sizeof(wchar_t));
                                        file.Write(&strLineStart[0] , strLineStart.size() * sizeof(wchar_t));
                                        file.Write(&strLineEnd[0] , strLineEnd.size() * sizeof(wchar_t));
                                        file.Write(&strLineStartOrg[0] , strLineStartOrg.size() * sizeof(wchar_t));
                                        file.Write(&strLineEndOrg[0] , strLineEndOrg.size() * sizeof(wchar_t));
                                        file.Write(&strNewLineW[0] , strNewLineW.size() * sizeof(wchar_t));
                                    }
                                    else
                                    {
                                        ScriptFileLineMap::Entry entry = (*itr);
                                        std::string strPath = StringUtility::ConvertWideToMulti(entry.path_) + "\r\n";
                                        std::string strLineStart = StringUtility::Format(   "  lineStart   :%4d\r\n", entry.lineStart_);
                                        std::string strLineEnd = StringUtility::Format(     "  lineEnd     :%4d\r\n", entry.lineEnd_);
                                        std::string strLineStartOrg = StringUtility::Format("  lineStartOrg:%4d\r\n", entry.lineStartOriginal_);
                                        std::string strLineEndOrg = StringUtility::Format(  "  lineEndOrg  :%4d\r\n", entry.lineEndOriginal_);
                                    
                                        file.Write(&strPath[0] , strPath.size());
                                        file.Write(&strLineStart[0] , strLineStart.size());
                                        file.Write(&strLineEnd[0] , strLineEnd.size());
                                        file.Write(&strLineStartOrg[0] , strLineStartOrg.size());
                                        file.Write(&strLineEndOrg[0] , strLineEndOrg.size());
                                        file.Write(&strNewLine[0] , strNewLine.size());
                                    }

                                }

                                countTest++;
                            }*/

                            break;
                        }
                    }
                }

                res += '\0';

                return res;
            }
            private bool _CreateEngine()
            {
                machine = null;

                string source = engine.GetSource();

                ScriptEngine scriptEngine = new ScriptEngine(typeManagerDefault, source, func.ToArray());
                engine.SetEngine(scriptEngine);
                return true;
            }
            //private string _ExtendPath(string path); TODO remove
        }
    }
}
