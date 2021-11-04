using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ScriptFileLineMap;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ScriptCommonDataManager;
    /**********************************************************
    //ScriptException
    **********************************************************/
    public class ScriptException : gstd.wexception
    {
            public ScriptException() : base("")
            {
            }
            public ScriptException(string str) : base(str)
            {
            }
    }

    /**********************************************************
    //ScriptEngineData
    **********************************************************/
    public class ScriptEngineData : System.IDisposable
    {
            protected string path_ = "";
            protected int encoding_;
            protected List<char> source_ = new List<char>();
            protected gstd.ref_count_ptr<script_engine> engine_ = new gstd.ref_count_ptr<script_engine>();
            protected gstd.ref_count_ptr<ScriptFileLineMap> mapLine_ = new gstd.ref_count_ptr<ScriptFileLineMap>();

            /**********************************************************
            //ScriptEngineData
            **********************************************************/
            public ScriptEngineData()
            {
                encoding_ = Encoding.UNKNOWN;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mapLine_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptFileLineMap();
            }

            public virtual void Dispose()
            {
            }

            public void SetPath(string path)
            {
                path_ = path;
            }
            public string GetPath()
            {
                return path_;
            }
            public void SetSource(List<char> source)
            {
                encoding_ = Encoding.SHIFT_JIS;
                if (Encoding.IsUtf16Le(source[0], source.Count))
                {
                    encoding_ = Encoding.UTF16LE;
                }
                source_ = new List<char>(source);
            }

            public List<char> GetSource()
            {
                return new List<char>(source_);
            }
            public int GetEncoding()
            {
                return encoding_;
            }
            public void SetEngine(gstd.ref_count_ptr<script_engine> engine)
            {
                engine_.CopyFrom(engine);
            }
            public gstd.ref_count_ptr<script_engine> GetEngine()
            {
                return new gstd.ref_count_ptr<script_engine>(engine_);
            }
            public gstd.ref_count_ptr<ScriptFileLineMap> GetScriptFileLineMap()
            {
                return new gstd.ref_count_ptr<ScriptFileLineMap>(mapLine_);
            }
            public void SetScriptFileLineMap(gstd.ref_count_ptr<ScriptFileLineMap> mapLine)
            {
                mapLine_.CopyFrom(mapLine);
            }
    }

    /**********************************************************
    //ScriptEngineCache
    **********************************************************/
    public class ScriptEngineCache : System.IDisposable
    {
            protected SortedDictionary<string, ref_count_ptr<ScriptEngineData>> cache_ = new SortedDictionary<string, ref_count_ptr<ScriptEngineData>>();

            /**********************************************************
            //ScriptEngineCache
            **********************************************************/
            public ScriptEngineCache()
            {

            }

            public virtual void Dispose()
            {
            }

            public void Clear()
            {
                cache_.Clear();
            }

            public void AddCache(string name, ref_count_ptr<ScriptEngineData> data)
            {
                cache_[name].CopyFrom(data);
            }

            public ref_count_ptr<ScriptEngineData> GetCache(string name)
            {
                if (!IsExists(name))
                {
                    return null;
                }
                return new ref_count_ptr<ScriptEngineData>(cache_[name]);
            }

            public bool IsExists(string name)
            {
                return cache_.ContainsKey(name);
            }
    }

    /**********************************************************
    //ScriptBase
    **********************************************************/
    public class ScriptClientBase : System.IDisposable
    {
            private static script_type_manager typeManagerDefault_ = new script_type_manager();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                ID_SCRIPT_FREE = -1
            }
            public static script_type_manager GetDefaultScriptTypeManager()
            {
                return new gstd.script_type_manager(typeManagerDefault_);
            }

            protected bool bError_;
            protected gstd.ref_count_ptr<ScriptEngineCache> cache_ = new gstd.ref_count_ptr<ScriptEngineCache>();
            protected gstd.ref_count_ptr<ScriptEngineData> engine_ = new gstd.ref_count_ptr<ScriptEngineData>();
            protected script_machine machine_;

            protected List<function> func_ = new List<function>();
            protected ref_count_ptr<MersenneTwister> mt_ = new ref_count_ptr<MersenneTwister>();
            protected gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager_ = new gstd.ref_count_ptr<ScriptCommonDataManager>();
            protected int mainThreadID_;
            protected _int64 idScript_ = new _int64();

            protected gstd.CriticalSection criticalSection_ = new gstd.CriticalSection();

            protected List<gstd.value> listValueArg_ = new List<gstd.value>();
            protected gstd.value valueRes_ = new gstd.value();

            protected void _AddFunction(string name, callback f, uint arguments)
            {
                function tFunc = new function();
                tFunc.name = name;
                tFunc.func = f;
                tFunc.arguments = arguments;
                func_.Add(tFunc);
            }

            protected void _AddFunction(function f, int count)
            {
                int funcPos = func_.Count;
                func_.Resize(funcPos + count);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(func_[funcPos], f, sizeof(function) * count);
            }

            protected void _RaiseErrorFromEngine()
            {
                int line = engine_.GetEngine().get_error_line();
                _RaiseError(line, engine_.GetEngine().get_error_message());
            }

            protected void _RaiseErrorFromMachine()
            {
                int line = machine_.get_error_line();
                _RaiseError(line, machine_.get_error_message());
            }

            protected void _RaiseError(int line, string message)
            {
                bError_ = true;
                string errorPos = _GetErrorLineSource(line);

                gstd.ref_count_ptr<ScriptFileLineMap> mapLine = engine_.GetScriptFileLineMap();
                ScriptFileLineMap.Entry entry = mapLine.GetEntry(line);
                int lineOriginal = entry.lineEndOriginal_ - (entry.lineEnd_ - line);

                string fileName = PathProperty.GetFileName(entry.path_);

                string str = StringUtility.Format("%s\r\n%s \r\n%s line(�s)=%d\r\n\r\n��\r\n%s\r\n�`�`�`", message, entry.path_, fileName, lineOriginal, errorPos);
                throw new ScriptException(str);
            }

            protected string _GetErrorLineSource(int line)
            {
                if (line == 0)
                {
                    return "";
                }
                int encoding = engine_.GetEncoding();
                List<char> source = engine_.GetSource();
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
                char * pbuf = (string) source[0];
                string sbuf = pbuf;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* ebuf = sbuf + source.size();
                char ebuf = sbuf.Substring(source.Count);

                int tLine = 1;
                int rLine = line;
                while (pbuf < ebuf)
                {
                    if (tLine == rLine)
                    {
                        break;
                    }

                    if (encoding == Encoding.UTF16LE)
                    {
                        char ch = (char) * pbuf;
                        if (ch == '\n')
                        {
                            tLine++;
                        }
                        pbuf += 2;

                    }
                    else
                    {
                        if (IsDBCSLeadByte(*pbuf))
                        {
                            pbuf += 2;
                        }
                        else
                        {
                            if (*pbuf == '\n')
                            {
                                tLine++;
                            }
                            pbuf++;
                        }
                    }

                }

                const int countMax = 256;
                int count = 0;
                sbuf = pbuf;
                while (pbuf < ebuf && count < countMax)
                {
                    pbuf++;
                    count++;
                }

                int size = System.Math.Max(count - 1, 0);
                string res;
                if (encoding == Encoding.UTF16LE)
                {
                    string wbufS = (string)sbuf;
                    string wbufE = wbufS.Substring(size);
                    res = new string(wbufS, wbufE);
                }
                else
                {
                    string sStr = new string(sbuf, sbuf.Substring(size));
                    res = StringUtility.ConvertMultiToWide(sStr);
                }

                return res;
            }

// C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
            private int _Include_countTest = 0;
// C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
            private string _Include_tPath = "";

            protected virtual List<char> _Include(ref List<char> source)
            {
                // TODO �Ƃ肠��������
                string pathSource = engine_.GetPath();
                List<char> res = source;
                FileManager fileManager = FileManager.GetBase();
                SortedSet<string> setReadPath = new SortedSet<string>();

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                gstd.ref_count_ptr<ScriptFileLineMap> mapLine = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptFileLineMap();
                engine_.SetScriptFileLineMap(mapLine);

                mapLine.AddEntry(pathSource, 1, StringUtility.CountCharacter(source, '\n') + 1);

                int encoding = Encoding.SHIFT_JIS;
                bool bEnd = false;
                while (true)
                {
                    if (bEnd)
                    {
                        break;
                    }
                    Scanner scanner = new Scanner(res);
                    encoding = scanner.GetEncoding();
                    int resSize = res.Count;

                    bEnd = true;
                    while (scanner.HasNext())
                    {
                        Token tok = scanner.Next();
                        if (tok.GetType() == Token.TK_EOF) // Eof�̎��ʎq��������t�@�C���̒����I��
                        {
                            break;
                        }
                        else if (tok.GetType() == Token.TK_SHARP)
                        {
                            int posInclude = scanner.GetCurrentPointer() - 1;
                            if (encoding == Encoding.UTF16LE)
                            {
                                posInclude--;
                            }

                            tok = scanner.Next();
                            if (tok.GetElement() != "include")
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
                                if (scanner.Next().GetType() != Token.TK_NEWLINE)
                                {
                                    int line = scanner.GetCurrentLine();
                                    source = res;
                                    engine_.SetSource(source);

                                    string error;
                                    error += "New line is not found after #include.\r\n";
                                    error += "(#include��ɉ��s������܂���)";
                                    _RaiseError(line, error);
                                }
                                scanner.SetCurrentPointer(posBeforeNewLine);
                            }
                            else
                            {
                                // bNeedNewLine = true;
                            }
                            int posAfterInclude = scanner.GetCurrentPointer();
                            scanner.SetCurrentPointer(posCurrent);

                            // "../"����n�܂��Ă�����A�O��"./"�����B
                            if (wPath.IndexOf("../") == 0 || wPath.IndexOf("..\\") == 0)
                            {
                                wPath = "./" + wPath;
                            }

                            if (wPath.IndexOf(".\\") != -1 || wPath.IndexOf("./") != -1)
                            { // ".\"�W�J
                                int line = scanner.GetCurrentLine();
                                string linePath = mapLine.GetPath(line);
                                string tDir = PathProperty.GetFileDirectory(linePath);
                                // std::string tDir = PathProperty::GetFileDirectory(pathSource);
                                wPath = tDir.Substring(PathProperty.GetModuleDirectory().Length) + wPath.Substring(2);
                            }
                            wPath = PathProperty.GetModuleDirectory() + wPath;
                            wPath = PathProperty.GetUnique(wPath);

                            bool bReadPath = setReadPath.find(wPath) != setReadPath.end();
                            if (bReadPath)
                            { // ���łɓǂݍ��܂�Ă���
                                List<char> newSource = new List<char>();
                                int size1 = posInclude;
                                int size2 = res.Count - posAfterInclude;
                                newSource.Resize(size1 + size2);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(newSource[0], res[0], size1);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(newSource[size1], res[posAfterInclude], size2);

                                res = new List<char>(newSource);
                                break;
                            }

                            List<char> placement = new List<char>();
                            ref_count_ptr<FileReader> reader = new ref_count_ptr<FileReader>();
                            reader.CopyFrom(fileManager.GetFileReader(wPath));
                            if (reader == null || !reader.Open())
                            {
                                int line = scanner.GetCurrentLine();
                                source = res;
                                engine_.SetSource(source);

                                string error;
                                error += StringUtility.Format("#Include file is not found[%s].\r\n", wPath);
                                error += StringUtility.Format("(#include�Œu������t�@�C��[%s]��������܂���)", wPath);
                                _RaiseError(line, error);
                            }

                            // �t�@�C����ǂݍ��ݍŌ�ɉ��s��t��
                            int targetBomSize = 0;
                            int targetEncoding = Encoding.SHIFT_JIS;
                            if (reader.GetFileSize() >= 2)
                            {
                                string data = new string(new char[2]);
                                reader.Read(data[0], 2);
                                if (Encoding.IsUtf16Le(data[0], 2))
                                {
                                    targetEncoding = Encoding.UTF16LE;
                                    targetBomSize = Encoding.GetBomSize(data[0], 2);
                                }
                                // �t�@�C���|�C���^��ŏ��ɖ߂�
                                reader.SetFilePointerBegin();
                            }

                            if (targetEncoding == Encoding.UTF16LE)
                            {
                                // �ǂݍ��ݑΏۂ�UTF16LE
                                int newLineSize = bNeedNewLine ? 4 : 0;
                                reader.Seek(targetBomSize);
                                placement.Resize(reader.GetFileSize() - targetBomSize + newLineSize); // -BOM�ǂݍ��ݕ�+�Ō�̉��s
                                int readSize = reader.GetFileSize() - targetBomSize;
                                reader.Read(placement[0], readSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(placement[readSize], "\r\n", newLineSize);

                                // �����悪ShiftJIS�̏ꍇ�A�������UTF16LE�ɕϊ�����B
                                if (encoding == Encoding.SHIFT_JIS)
                                {
                                    encoding = Encoding.UTF16LE;
                                    int resSize = res.Count;
                                    string sRes = new string(res[0], res[resSize]);
                                    string wRes = StringUtility.ConvertMultiToWide(sRes);

                                    int dataSize = wRes.Length * sizeof(char);
                                    res.Resize(dataSize + 2);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                    memcpy(res[0], Encoding.BOM_UTF16LE, 2);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                    memcpy(res[2], wRes[0], dataSize);

                                    // �ēxscan���Ȃ���
                                    break;
                                }
                            }
                            else
                            {
                                // �ǂݍ��ݑΏۂ�ShiftJis
                                int newLineSize = bNeedNewLine ? 2 : 0;
                                placement.Resize(reader.GetFileSize() + newLineSize);
                                reader.Read(placement[0], reader.GetFileSize());
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(placement[reader.GetFileSize()], "\r\n", newLineSize);

                                // �����悪UTF16LE�̏ꍇ�A�ǂݍ��񂾃f�[�^��UTF16LE�ɕϊ�����B
                                if (encoding == Encoding.UTF16LE)
                                {
                                    int placementSize = placement.Count;
                                    string sPlacement = new string(placement[0], placement[placementSize]);
                                    string wPlacement = StringUtility.ConvertMultiToWide(sPlacement);

                                    int dataSize = wPlacement.Length * sizeof(char);
                                    placement.Resize(dataSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                    memcpy(placement[0], wPlacement[0], dataSize);
                                }

                            }
                            mapLine.AddEntry(wPath, scanner.GetCurrentLine(), StringUtility.CountCharacter(placement, '\n') + 1);

                            { // �u��
                                List<char> newSource = new List<char>();
                                int size1 = posInclude;
                                int size2 = res.Count - posAfterInclude;
                                int sizeP = placement.Count;
                                newSource.Resize(size1 + sizeP + size2);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(newSource[0], res[0], size1);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(newSource[size1], placement[0], sizeP);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                                memcpy(newSource[size1 + sizeP], res[posAfterInclude], size2);

                                res = new List<char>(newSource);
                            }
                            setReadPath.Add(wPath);

                            if (false)
                            {
// C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
//                                static int countTest = 0;
// C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
//                                static string tPath = "";
                                if (_Include_tPath != pathSource)
                                {
                                    _Include_countTest = 0;
                                    _Include_tPath = pathSource;
                                }
                                string pathTest = PathProperty.GetModuleDirectory() + StringUtility.Format("temp\\script_%s%03d.txt", PathProperty.GetFileName(pathSource), _Include_countTest);
                                File file = new File(pathTest);
                                file.CreateDirectory();
                                file.Create();
                                file.Write(res[0], (uint)res.Count);

                                string strNewLine = "\r\n";
                                string strNewLineW = "\r\n";
                                if (encoding == Encoding.UTF16LE)
                                {
                                    file.Write(strNewLineW[0], strNewLine.Length * sizeof(char));
                                    file.Write(strNewLineW[0], strNewLine.Length * sizeof(char));
                                }
                                else
                                {
                                    file.Write(strNewLine[0], (uint)strNewLine.Length);
                                    file.Write(strNewLine[0], (uint)strNewLine.Length);
                                }

                                LinkedList<ScriptFileLineMap.Entry> listEntry = mapLine.GetEntryList();
                                LinkedList<ScriptFileLineMap.Entry>.Enumerator itr = listEntry.GetEnumerator();
                                while (itr.MoveNext())
                                {
                                    if (encoding == Encoding.UTF16LE)
                                    {
                                        ScriptFileLineMap.Entry entry = itr.Current;
                                        string strPath = entry.path_ + "\r\n";
                                        string strLineStart = StringUtility.Format("  lineStart   :%4d\r\n", entry.lineStart_);
                                        string strLineEnd = StringUtility.Format("  lineEnd     :%4d\r\n", entry.lineEnd_);
                                        string strLineStartOrg = StringUtility.Format("  lineStartOrg:%4d\r\n", entry.lineStartOriginal_);
                                        string strLineEndOrg = StringUtility.Format("  lineEndOrg  :%4d\r\n", entry.lineEndOriginal_);

                                        file.Write(strPath[0], strPath.Length * sizeof(char));
                                        file.Write(strLineStart[0], strLineStart.Length * sizeof(char));
                                        file.Write(strLineEnd[0], strLineEnd.Length * sizeof(char));
                                        file.Write(strLineStartOrg[0], strLineStartOrg.Length * sizeof(char));
                                        file.Write(strLineEndOrg[0], strLineEndOrg.Length * sizeof(char));
                                        file.Write(strNewLineW[0], strNewLineW.Length * sizeof(char));
                                    }
                                    else
                                    {
                                        ScriptFileLineMap.Entry entry = itr.Current;
                                        string strPath = StringUtility.ConvertWideToMulti(entry.path_) + "\r\n";
                                        string strLineStart = StringUtility.Format("  lineStart   :%4d\r\n", entry.lineStart_);
                                        string strLineEnd = StringUtility.Format("  lineEnd     :%4d\r\n", entry.lineEnd_);
                                        string strLineStartOrg = StringUtility.Format("  lineStartOrg:%4d\r\n", entry.lineStartOriginal_);
                                        string strLineEndOrg = StringUtility.Format("  lineEndOrg  :%4d\r\n", entry.lineEndOriginal_);

                                        file.Write(strPath[0], (uint)strPath.Length);
                                        file.Write(strLineStart[0], (uint)strLineStart.Length);
                                        file.Write(strLineEnd[0], (uint)strLineEnd.Length);
                                        file.Write(strLineStartOrg[0], (uint)strLineStartOrg.Length);
                                        file.Write(strLineEndOrg[0], (uint)strLineEndOrg.Length);
                                        file.Write(strNewLine[0], (uint)strNewLine.Length);
                                    }

                                }

                                _Include_countTest++;
                            }

                            break;
                        }
                    }
                }

                res.Add(0);
                if (encoding == Encoding.UTF16LE)
                {
                    res.Add(0);
                }

                return new List<char>(res);
            }

            protected virtual bool _CreateEngine()
            {
                if (machine_ != null)
                {
                    if (machine_ != null)
                    {
                        machine_.Dispose();
                    }
                }
                machine_ = null;

                List<char> source = engine_.GetSource();

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<script_engine> engine = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new script_engine(typeManagerDefault_, source, func_.Count, func_[0]);
                engine_.SetEngine(engine);
                return true;
            }

            protected string _ExtendPath(string path)
            {
                int line = machine_.get_current_line();
                string pathScript = GetEngine().GetScriptFileLineMap().GetPath(line);

                path = StringUtility.ReplaceAll(path, "\\", "/");
                path = StringUtility.ReplaceAll(path, "./", pathScript);

                return path;
            }

            public ScriptClientBase()
            {
                bError_ = false;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                engine_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptEngineData();
                machine_ = null;
                mainThreadID_ = -1;
                idScript_ = AnonymousEnum.ID_SCRIPT_FREE;
                valueRes_ = new value();

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                commonDataManager_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonDataManager();
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mt_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new MersenneTwister();
                mt_.Initialize(timeGetTime());
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(commonFunction, sizeof(commonFunction)/sizeof(function));
                _AddFunction(GlobalMembers.commonFunction, GlobalMembers.commonFunction.Length);
            }

            public virtual void Dispose()
            {
                if (machine_ != null)
                {
                    if (machine_ != null)
                    {
                        machine_.Dispose();
                    }
                }
                machine_ = null;
                engine_ = null;
            }

            public void SetScriptEngineCache(gstd.ref_count_ptr<ScriptEngineCache> cache)
            {
                cache_.CopyFrom(cache);
            }
            public gstd.ref_count_ptr<ScriptEngineData> GetEngine()
            {
                return new gstd.ref_count_ptr<ScriptEngineData>(engine_);
            }
            public virtual bool SetSourceFromFile(string path)
            {
                path = PathProperty.GetUnique(path);
                if (cache_ != null && cache_.IsExists(path))
                {
                    engine_ = cache_.GetCache(path);
                    return true;
                }

                engine_.SetPath(path);
                ref_count_ptr<FileReader> reader = new ref_count_ptr<FileReader>();
                reader.CopyFrom(FileManager.GetBase().GetFileReader(path));
                if (reader == null)
                {
                    throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path));
                }
                if (!reader.Open())
                {
                    throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path));
                }

                int size = reader.GetFileSize();
                List<char> source = new List<char>();
                source.Resize(size);
                reader.Read(source[0], size);
                this.SetSource(source);
                return true;
            }

            public virtual void SetSource(List<char> source)
            {
                engine_.SetSource(source);
                gstd.ref_count_ptr<ScriptFileLineMap> mapLine = engine_.GetScriptFileLineMap();
                mapLine.AddEntry(engine_.GetPath(), 1, StringUtility.CountCharacter(source, '\n') + 1);
            }

            public virtual void SetSource(string source)
            {
                List<char> vect = new List<char>();
                vect.Resize(source.Length);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vect[0], source[0], source.Length);
                this.SetSource(vect);
            }

            public string GetPath()
            {
                return engine_.GetPath();
            }
            public void SetPath(string path)
            {
                engine_.SetPath(path);
            }

            public virtual void Compile()
            {
                if (engine_.GetEngine() == null)
                {
                    List<char> source = _Include(ref engine_.GetSource());
                    engine_.SetSource(source);

                    _CreateEngine();
                    if (engine_.GetEngine().get_error())
                    {
                        bError_ = true;
                        _RaiseErrorFromEngine();
                    }
                    if (cache_ != null && engine_.GetPath().size() != 0)
                    {
                        cache_.AddCache(engine_.GetPath(), engine_);
                    }

                }

                if (machine_ != null)
                {
                    if (machine_ != null)
                    {
                        machine_.Dispose();
                    }
                }
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                machine_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new script_machine(engine_.GetEngine().GetPointer());
                if (machine_.get_error())
                {
                    bError_ = true;
                    _RaiseErrorFromMachine();
                }
                machine_.data = this;
            }

            public virtual bool Run()
            {
                if (bError_)
                {
                    return false;
                }
                machine_.run();
                if (machine_.get_error())
                {
                    bError_ = true;
                    _RaiseErrorFromMachine();
                }
                return true;
            }

            public virtual bool Run(string target)
            {
                if (bError_)
                {
                    return false;
                }
                if (!machine_.has_event(target))
                {
                    string error;
                    error += StringUtility.FormatToWide("@ not found[%s]", target);
                    error += StringUtility.FormatToWide("(�C�x���g�����݂��܂���[%s])", target);
                    _RaiseError(0, error);
                }

                Run();
                machine_.call(target);
                if (machine_.get_error())
                {
                    bError_ = true;
                    _RaiseErrorFromMachine();
                }
                return true;
            }

            public bool IsEventExists(string name)
            {
                if (bError_)
                {
                    return false;
                }
                return machine_.has_event(name);
            }

            public void RaiseError(string error)
            {
                _RaiseError(machine_.get_error_line(), error);
            }
            public void Terminate(string error)
            {
                machine_.terminate(error);
            }
            public _int64 GetScriptID()
            {
                return new _int64(idScript_);
            }
            public int GetThreadCount()
            {
                if (machine_ == null)
                {
                    return 0;
                }
                int res = machine_.get_thread_count();
                return res;
            }

            public void AddArgumentValue(value v)
            {
                listValueArg_.Add(v);
            }
            public void SetArgumentValue(value v, int index = 0)
            {
                if (listValueArg_.Count <= index)
                {
                    listValueArg_.Resize(index + 1);
                }
                listValueArg_[index].CopyFrom(v);
            }

            public value GetResultValue()
            {
                return new gstd.value(valueRes_);
            }

            public value CreateRealValue(double r)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_real_type(), (double)r);
                return new gstd.value(res);
            }

            public value CreateBooleanValue(bool b)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_boolean_type(), b);
                return new gstd.value(res);
            }

            public value CreateStringValue(string s)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                string wstr = to_wide(s);
                value res = new value(typeManager.get_string_type(), wstr);
                return new gstd.value(res);
            }

            public value CreateStringValue(string s)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_string_type(), s);
                return new gstd.value(res);
            }

            public value CreateRealArrayValue(List<double> list)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_string_type(), new string());
                for (int iData = 0 ; iData < list.Count ; iData++)
                {
                    value data = CreateRealValue(new List<double>(list[iData]));
                    res.append(typeManager.get_array_type(typeManager.get_real_type()), data);
                }

                return new gstd.value(res);
            }

            public value CreateStringArrayValue(List<string> list)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_string_type(), new string());
                for (int iData = 0 ; iData < list.Count ; iData++)
                {
                    value data = CreateStringValue(new List<string>(list[iData]));
                    res.append(typeManager.get_array_type(typeManager.get_string_type()), data);
                }

                return new gstd.value(res);
            }

            public value CreateStringArrayValue(List<string> list)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_string_type(), new string());
                for (int iData = 0 ; iData < list.Count ; iData++)
                {
                    value data = CreateStringValue(new List<string>(list[iData]));
                    res.append(typeManager.get_array_type(typeManager.get_string_type()), data);
                }

                return new gstd.value(res);
            }

            public value CreateValueArrayValue(List<value> list)
            {
                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                value res = new value(typeManager.get_string_type(), new string());
                for (int iData = 0 ; iData < list.Count ; iData++)
                {
                    value data = list[iData];
                    res.append(typeManager.get_array_type(typeManager.get_real_type()), data);
                }
                return new gstd.value(res);
            }

            public bool IsRealValue(value v)
            {
                if (bError_)
                {
                    return false;
                }
                if (!v.has_data())
                {
                    return false;
                }

                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                return v.get_type() == typeManager.get_real_type();
            }

            public bool IsBooleanValue(value v)
            {
                if (bError_)
                {
                    return false;
                }
                if (!v.has_data())
                {
                    return false;
                }

                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                return v.get_type() == typeManager.get_boolean_type();
            }

            public bool IsStringValue(value v)
            {
                if (bError_)
                {
                    return false;
                }
                if (!v.has_data())
                {
                    return false;
                }

                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                return v.get_type() == typeManager.get_string_type();
            }

            public bool IsRealArrayValue(value v)
            {
                if (bError_)
                {
                    return false;
                }
                if (!v.has_data())
                {
                    return false;
                }

                script_type_manager typeManager = GetEngine().GetEngine().GetPointer().get_type_manager();
                return v.get_type() == typeManager.get_array_type(typeManager.get_real_type());
            }

            public void CheckRunInMainThread()
            {
                if (mainThreadID_ < 0)
                {
                    return;
                }
                if (mainThreadID_ != GetCurrentThreadId())
                {
                    string error;
                    error += "This function can call in main thread only.\r\n";
                    error += "(���C���X���b�h�ȊO�ł͎��s�ł��܂���B)";
                    machine_.raise_error(error);
                }
            }

            public ScriptCommonDataManager GetCommonDataManager()
            {
                return commonDataManager_.GetPointer();
            }

            // ���ʊ֐��F�X�N���v�g��������

            // ���ʊ֐��F�X�N���v�g��������
            public static value Func_GetScriptArgument(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                int index = (int)argv[0].as_real();
                if (index < 0 || index >= script.listValueArg_.Count)
                {
                    string error;
                    error += "Invalid script argument index.\r\n";
                    error += "(�X�N���v�g�����̃C���f�b�N�X���s���ł��B)";
                    throw new gstd.wexception(error);
                }
                return new gstd.value(script.listValueArg_[index]);
            }

            public static value Func_GetScriptArgumentCount(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                int res = script.listValueArg_.Count;
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static value Func_SetScriptResult(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                script.valueRes_.CopyFrom(argv[0]);
                return new value();
            }

            // ���ʊ֐��F���w�n

            // �g�ݍ��݊֐��F���w�n
            public static value Func_Min(script_machine machine, int argc, value[] argv)
            {
                double v1 = argv[0].as_real();
                double v2 = argv[1].as_real();
                double res = v1 <= v2 ? v1 : v2;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_Max(script_machine machine, int argc, value[] argv)
            {
                double v1 = argv[0].as_real();
                double v2 = argv[1].as_real();
                double res = v1 >= v2 ? v1 : v2;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_Log(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Log(argv[0].as_real()));
            }

            public static value Func_Log10(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Log10(argv[0].as_real()));
            }

            public static value Func_Cos(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Cos(Math.DegreeToRadian(argv[0].as_real())));
            }

            public static value Func_Sin(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Sin(Math.DegreeToRadian(argv[0].as_real())));
            }

            public static value Func_Tan(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Tan(Math.DegreeToRadian(argv[0].as_real())));
            }

            public static value Func_Acos(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Acos(argv[0].as_real())));
            }

            public static value Func_Asin(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Asin(argv[0].as_real())));
            }

            public static value Func_Atan(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Atan(argv[0].as_real())));
            }

            public static value Func_Atan2(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Atan2(argv[0].as_real(),argv[1].as_real())));
            }

            public static value Func_Rand(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                script.CheckRunInMainThread();

                double min = argv[0].as_real();
                double max = argv[1].as_real();
                double res = script.mt_.GetReal(min, max);
                return new value(machine.get_engine().get_real_type(), res);
            }

            // ���ʊ֐��F�����񑀍�

            // �g�ݍ��݊֐��F�����񑀍�
            public static value Func_ToString(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_string_type(), argv[0].as_string());
            }

            public static value Func_IntToString(script_machine machine, int argc, value[] argv)
            {
                string res = StringUtility.Format("%d", (int)argv[0].as_real());
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_ItoA(script_machine machine, int argc, value[] argv)
            {
                string res = StringUtility.Format("%d", (int)argv[0].as_real());
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_RtoA(script_machine machine, int argc, value[] argv)
            {
                string res = StringUtility.Format("%f", argv[0].as_real());
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_RtoS(script_machine machine, int argc, value[] argv)
            {
                string res = "";
                string fmtV = to_mbcs(argv[0].as_string());
                double num = argv[1].as_real();

                try
                {
                    bool bF = false;
                    int countIS = 0;
                    int countI0 = 0;
                    int countF = 0;

                    for (int iCh = 0 ; iCh < fmtV.Length ; iCh++)
                    {
                        char ch = fmtV[iCh];
                        if (IsDBCSLeadByte(ch))
                        {
                            throw false;
                        }

                        if (ch == '#')
                        {
                            countIS++;
                        }
                        else if (ch == '.' && bF)
                        {
                            throw false;
                        }
                        else if (ch == '.')
                        {
                            bF = true;
                        }
                        else if (ch == '0')
                        {
                            if (bF)
                            {
                                countF++;
                            }
                            else
                            {
                                countI0++;
                            }
                        }
                    }

                    string fmt = "";
                    if (countI0 > 0 && countF >= 0)
                    {
                        fmt += "%0";
                        fmt += StringUtility.Format("%d", countI0);
                        fmt += ".";
                        fmt += StringUtility.Format("%d", countF);
                        fmt += "f";
                    }
                    else if (countIS > 0 && countF >= 0)
                    {
                        fmt += "%";
                        fmt += StringUtility.Format("%d", countIS);
                        fmt += ".";
                        fmt += StringUtility.Format("%d", countF);
                        fmt += "f";
                    }

                    if (fmt.Length > 0)
                    {
                        res = StringUtility.Format(ref (string)fmt, num);
                    }
                }
                catch
                {
                    res = "error format";
                }

                return new value(machine.get_engine().get_string_type(), to_wide(res));
            }

            public static value Func_VtoS(script_machine machine, int argc, value[] argv)
            {
                string res = "";
                string fmtV = to_mbcs(argv[0].as_string());

                try
                {
                    int countIS = 0;
                    int countI0 = 0;
                    int countF = 0;

                    int advance = 0; // 0:-, 1:0, 2:num, 3:[d,s,f], 4:., 5:num
                    for (int iCh = 0 ; iCh < fmtV.Length ; iCh++)
                    {
                        char ch = fmtV[iCh];
                        if (IsDBCSLeadByte(ch))
                        {
                            throw false;
                        }
                        if (advance == 0 && ch == '-')
                        {
                            advance = 1;
                        }
                        else if ((advance == 0 || advance == 1 || advance == 2) && (ch >= '0' && ch <= '9'))
                        {
                            advance = 2;
                        }
                        else if (advance == 2 && (ch == 'd' || ch == 's' || ch == 'f'))
                        {
                            advance = 4;
                        }
                        else if (advance == 2 && ('.'))
                        {
                            advance = 5;
                        }
                        else if (advance == 4 && ('.'))
                        {
                            advance = 5;
                        }
                        else if (advance == 5 && (ch >= '0' && ch <= '9'))
                        {
                            advance = 5;
                        }
                        else if (advance == 5 && (ch == 'd' || ch == 's' || ch == 'f'))
                        {
                            advance = 6;
                        }
                        else
                        {
                            throw false;
                        }
                    }

                    fmtV = "%" + fmtV;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* fmt = (char*)fmtV.c_str();
                    char fmt = (string)fmtV;
                    if (strstr(fmt, "d") != null)
                    {
                        res = StringUtility.Format(ref fmt, (int)argv[1].as_real());
                    }
                    else if (strstr(fmt, "f") != null)
                    {
                        res = StringUtility.Format(ref fmt, argv[1].as_real());
                    }
                    else if (strstr(fmt, "s") != null)
                    {
                        res = StringUtility.Format(ref fmt, to_mbcs(argv[1].as_string()).c_str());
                    }
                }
                catch
                {
                    res = "error format";
                }

                return new value(machine.get_engine().get_string_type(), to_wide(res));
            }

            public static value Func_AtoI(script_machine machine, int argc, value[] argv)
            {
                string str = argv[0].as_string();
                int num = StringUtility.ToInteger(str);
                return new value(machine.get_engine().get_real_type(), (double)num);
            }

            public static value Func_AtoR(script_machine machine, int argc, value[] argv)
            {
                string str = argv[0].as_string();
                double num = StringUtility.ToDouble(str);
                return new value(machine.get_engine().get_real_type(), (double)num);
            }

            public static value Func_TrimString(script_machine machine, int argc, value[] argv)
            {
                string str = argv[0].as_string();
                string res = StringUtility.Trim(str);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_SplitString(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string str = argv[0].as_string();
                string delim = argv[1].as_string();
                List<string> list = StringUtility.Split(str, delim);

                gstd.value res = script.CreateStringArrayValue(list);
                return new gstd.value(res);
            }

            // ���ʊ֐��F�p�X�֘A

            // ���ʊ֐��F�p�X�֘A
            public static value Func_GetModuleDirectory(script_machine machine, int argc, value argv)
            {
                string res = PathProperty.GetModuleDirectory();
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetMainScriptDirectory(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = script.GetEngine().GetPath();
                string res = PathProperty.GetFileDirectory(path);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetCurrentScriptDirectory(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                int line = machine.get_current_line();
                string path = script.GetEngine().GetScriptFileLineMap().GetPath(line);
                string res = PathProperty.GetFileDirectory(path);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetFileDirectory(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = argv[0].as_string();
                // path = StringUtility::ReplaceAll(path, "/", "\\");
                string res = PathProperty.GetFileDirectory(path);

                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetFilePathList(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = argv[0].as_string();
                string dir = PathProperty.GetFileDirectory(path);
                List<string> listDir = File.GetFilePathList(dir);
                gstd.value res = script.CreateStringArrayValue(listDir);
                return new gstd.value(res);
            }

            public static value Func_GetDirectoryList(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = argv[0].as_string();
                string dir = PathProperty.GetFileDirectory(path);
                List<string> listDir = File.GetDirectoryPathList(dir);
                gstd.value res = script.CreateStringArrayValue(listDir);
                return new gstd.value(res);
            }

            // ���ʊ֐��F�����֘A

            // ���ʊ֐��F�����֘A
            public static value Func_GetCurrentDateTimeS(script_machine machine, int argc, value argv)
            {
                SYSTEMTIME date = new SYSTEMTIME();
                GetLocalTime(date);

                string strDateTime = StringUtility.Format("%04d%02d%02d%02d%02d%02d", date.wYear, date.wMonth, date.wDay, date.wHour, date.wMinute, date.wSecond);
                string res = strDateTime;
                return new value(machine.get_engine().get_string_type(), res);
            }

            // ���ʊ֐��F�f�o�b�O�֘A

            // ���ʊ֐��F�f�o�b�O�֘A
            public static value Func_WriteLog(script_machine machine, int argc, value[] argv)
            {
                string msg = argv[0].as_string();
                Logger.WriteTop(msg);
                return new value();
            }

            public static value Func_RaiseError(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string msg = argv[0].as_string();
                script.RaiseError(msg);

                return new value();
            }

            // ���ʊ֐��F���ʃf�[�^

            // ���ʊ֐��F���ʃf�[�^
            public static value Func_SetDefaultCommonDataArea(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string name = to_mbcs(argv[0].as_string());
                commonDataManager.SetDefaultAreaName(name);

                return new value();
            }

            public static value Func_SetCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                string key = to_mbcs(argv[0].as_string());
                value val = argv[1];
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.SetValue(key, val);
                return new value();
            }

            public static value Func_GetCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                string key = to_mbcs(argv[0].as_string());
                value dv = argv[1];
                if (!commonDataManager.IsExists(area))
                {
                    return new gstd.value(dv);
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                if (!data.IsExists(key))
                {
                    return new gstd.value(dv);
                }
                return data.GetValue(key);
            }

            public static value Func_ClearCommonData(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.Clear();
                return new value();
            }

            public static value Func_DeleteCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                string key = to_mbcs(argv[0].as_string());
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.DeleteValue(key);
                return new value();
            }

            public static value Func_SetAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                string key = to_mbcs(argv[1].as_string());
                value val = argv[2];

                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.SetValue(key, val);

                return new value();
            }

            public static value Func_GetAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                string key = to_mbcs(argv[1].as_string());
                value dv = argv[2];
                if (!commonDataManager.IsExists(area))
                {
                    return new gstd.value(dv);
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                if (!data.IsExists(key))
                {
                    return new gstd.value(dv);
                }
                return data.GetValue(key);
            }

            public static value Func_ClearAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.Clear();
                return new value();
            }

            public static value Func_DeleteAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                string key = to_mbcs(argv[1].as_string());
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.DeleteValue(key);
                return new value();
            }

            public static value Func_CreateCommonDataArea(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                commonDataManager.CreateArea(area);

                return new value();
            }

            public static value Func_CopyCommonDataArea(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string areaDest = to_mbcs(argv[0].as_string());
                string areaSrc = to_mbcs(argv[1].as_string());
                if (commonDataManager.IsExists(areaSrc))
                {
                    commonDataManager.CopyArea(areaDest, areaSrc);
                }

                return new value();
            }

            public static value Func_IsCommonDataAreaExists(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                bool res = commonDataManager.IsExists(area);
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_GetCommonDataAreaKeyList(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                List<string> listKey = commonDataManager.GetKeyList();
                gstd.value res = script.CreateStringArrayValue(listKey);
                return new gstd.value(res);
            }

            public static value Func_GetCommonDataValueKeyList(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                List<string> listKey = new List<string>();
                string area = to_mbcs(argv[0].as_string());
                if (commonDataManager.IsExists(area))
                {
                    gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                    listKey = data.GetKeyList();
                }
                gstd.value res = script.CreateStringArrayValue(listKey);
                return new gstd.value(res);
            }

    }

    /**********************************************************
    //ScriptFileLineMap
    **********************************************************/
    public class ScriptFileLineMap : System.IDisposable
    {
            public class Entry
            {
                public int lineStart_;
                public int lineEnd_;
                public int lineStartOriginal_;
                public int lineEndOriginal_;
                public string path_ = "";
            }
            protected LinkedList<Entry> listEntry_ = new LinkedList<Entry>();

            /**********************************************************
            //ScriptFileLineMap
            **********************************************************/
            public ScriptFileLineMap()
            {

            }

            public virtual void Dispose()
            {

            }

            public void AddEntry(string path, int lineAdd, int lineCount)
            {
                Entry entryNew = new Entry();
                entryNew.path_ = path;
                entryNew.lineStartOriginal_ = 1;
                entryNew.lineEndOriginal_ = lineCount;
                entryNew.lineStart_ = lineAdd;
                entryNew.lineEnd_ = entryNew.lineStart_ + lineCount - 1;
                if (listEntry_.Count == 0)
                {
                    listEntry_.AddLast(entryNew);
                    return;
                }

                Entry pEntryDivide = null;
                LinkedList<Entry>.Enumerator itrInsert;
                for (itrInsert = listEntry_.GetEnumerator(); itrInsert.MoveNext();)
                {
                    pEntryDivide = (Entry)itrInsert.Current;
                    if (lineAdd >= pEntryDivide.lineStart_ && lineAdd <= pEntryDivide.lineEnd_)
                    {
                        break;
                    }
                }

// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to references to variables:
// ORIGINAL LINE: Entry& entryDivide = *pEntryDivide;
                Entry entryDivide = pEntryDivide;
                if (entryDivide.lineStart_ == lineAdd)
                {
                    entryDivide.lineStartOriginal_++;
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'insert' method in C#:
                    listEntry_.insert(itrInsert, entryNew);
                }
                else if (entryDivide.lineEnd_ == lineAdd)
                {
                    entryDivide.lineEnd_--;
                    entryDivide.lineEndOriginal_--;

// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'insert' method in C#:
                    listEntry_.insert(itrInsert, entryNew);
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    itrInsert++;
                }
                else
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: Entry entryNew2 = entryDivide;
                    Entry entryNew2 = new Entry(entryDivide);
                    entryDivide.lineEnd_ = lineAdd - 1;
                    entryDivide.lineEndOriginal_ = lineAdd - entryDivide.lineStart_;

                    entryNew2.lineStartOriginal_ = entryDivide.lineEndOriginal_ + 2;
                    entryNew2.lineStart_ = entryNew.lineEnd_ + 1;
                    entryNew2.lineEnd_ += lineCount - 1;

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    if (itrInsert != listEntry_.end())
                    {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                        itrInsert++;
                    }
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'insert' method in C#:
                    listEntry_.insert(itrInsert, entryNew);
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'insert' method in C#:
                    listEntry_.insert(itrInsert, entryNew2);
                }

                while (itrInsert.MoveNext())
                {
                    Entry entry = itrInsert.Current;
                    entry.lineStart_ += lineCount - 1;
                    entry.lineEnd_ += lineCount - 1;
                }
            }

            public ScriptFileLineMap.Entry GetEntry(int line)
            {
                Entry res = new Entry();
                LinkedList<Entry>.Enumerator itrInsert;
                for (itrInsert = listEntry_.GetEnumerator(); itrInsert.MoveNext();)
                {
                    res = itrInsert.Current;
                    if (line >= res.lineStart_ && line <= res.lineEnd_)
                    {
                        break;
                    }
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.ScriptFileLineMap.Entry(res);
            }

            public string GetPath(int line)
            {
                Entry entry = GetEntry(line);
                return entry.path_;
            }

            public LinkedList<Entry> GetEntryList()
            {
                return new LinkedList<Entry>(listEntry_);
            }
    }

    /**********************************************************
    //ScriptCommonDataManager
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ScriptCommonData;
    public class ScriptCommonDataManager : System.IDisposable
    {
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected string nameAreaDefailt_ = "";
            protected SortedDictionary<string, gstd.ref_count_ptr<ScriptCommonData>> mapData_ = new SortedDictionary<string, gstd.ref_count_ptr<ScriptCommonData>>();

            /**********************************************************
            //ScriptCommonDataManager
            **********************************************************/
            public ScriptCommonDataManager()
            {
                nameAreaDefailt_ = "";
                CreateArea("");
            }

            public virtual void Dispose()
            {
            }

            public void Clear()
            {
                mapData_.Clear();
            }

            public string GetDefaultAreaName()
            {
                return nameAreaDefailt_;
            }
            public void SetDefaultAreaName(string name)
            {
                nameAreaDefailt_ = name;
            }
            public bool IsExists(string name)
            {
                return mapData_.ContainsKey(name);
            }

            public void CreateArea(string name)
            {
                if (IsExists(name))
                {
                    return;
                }
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mapData_[name] = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonData();
            }

            public void CopyArea(string nameDest, string nameSrc)
            {
                gstd.ref_count_ptr<ScriptCommonData> dataSrc = mapData_[nameSrc];
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                gstd.ref_count_ptr<ScriptCommonData> dataDest = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonData();
                dataDest.Copy(dataSrc);
                mapData_[nameDest].CopyFrom(dataDest);
            }

            public gstd.ref_count_ptr<ScriptCommonData> GetData(string name)
            {
                if (!IsExists(name))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<ScriptCommonData>(mapData_[name]);
            }

            public void SetData(string name, gstd.ref_count_ptr<ScriptCommonData> commonData)
            {
                mapData_[name].CopyFrom(commonData);
            }

            public List<string> GetKeyList()
            {
                List<string> res = new List<string>();
                SortedDictionary<string, gstd.ref_count_ptr<ScriptCommonData>>.Enumerator itrValue;
                for (itrValue = mapData_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string key = itrValue.Current.Key;
                    res.Add(key);
                }
                return new List<string>(res);
            }

            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }
    }

    /**********************************************************
    //ScriptCommonData
    **********************************************************/
    public class ScriptCommonData : System.IDisposable
    {
            protected SortedDictionary<string, gstd.value> mapValue_ = new SortedDictionary<string, gstd.value>();

            protected gstd.value _ReadRecord(gstd.ByteBuffer buffer)
            {
                script_type_manager scriptTypeManager = ScriptClientBase.GetDefaultScriptTypeManager();
                gstd.value res = new gstd.value();
                type_data.type_kind kind = (type_data.type_kind)buffer.ReadInteger();

                if (kind == type_data.tk_real)
                {
                    double data = buffer.ReadDouble();
                    res = new gstd.value(scriptTypeManager.get_real_type(), data);
                }
                else if (kind == type_data.tk_char)
                {
                    char data;
                    buffer.Read(data, sizeof(char));
                    res = new gstd.value(scriptTypeManager.get_char_type(), data);
                }
                else if (kind == type_data.tk_boolean)
                {
                    bool data = buffer.ReadBoolean();
                    res = new gstd.value(scriptTypeManager.get_boolean_type(), data);
                }
                else if (kind == type_data.tk_array)
                {
                    int arrayLength = buffer.ReadInteger();
                    value v = new value();
                    for (int iArray = 0 ; iArray < arrayLength ; iArray++)
                    {
                        value arrayValue = _ReadRecord(buffer);
                        v.append(scriptTypeManager.get_array_type(arrayValue.get_type()), arrayValue);
                    }
                    res.CopyFrom(v);
                }

                return new gstd.value(res);
            }

            protected void _WriteRecord(gstd.ByteBuffer buffer, gstd.value comValue)
            {
                type_data.type_kind kind = comValue.get_type().get_kind();
                buffer.WriteInteger((int)kind);
                if (kind == type_data.tk_real)
                {
                    buffer.WriteDouble(comValue.as_real());
                }
                else if (kind == type_data.tk_char)
                {
                    char wch = comValue.as_char();
                    buffer.Write(wch, sizeof(char));
                }
                else if (kind == type_data.tk_boolean)
                {
                    buffer.WriteBoolean(comValue.as_boolean());
                }
                else if (kind == type_data.tk_array)
                {
                    int arrayLength = (int)comValue.length_as_array();
                    buffer.WriteInteger(arrayLength);

                    for (int iArray = 0 ; iArray < arrayLength ; iArray++)
                    {
                        value arrayValue = comValue.index_as_array((uint)iArray);
                        _WriteRecord(buffer, arrayValue);
                    }
                }
            }

            /**********************************************************
            //ScriptCommonData
            **********************************************************/
            public ScriptCommonData()
            {
            }

            public virtual void Dispose()
            {
            }

            public void Clear()
            {
                mapValue_.Clear();
            }

            public bool IsExists(string name)
            {
                return mapValue_.ContainsKey(name);
            }

            public gstd.value GetValue(string name)
            {
                if (!IsExists(name))
                {
                    return new value();
                }
                return new gstd.value(mapValue_[name]);
            }

            public void SetValue(string name, gstd.value v)
            {
                mapValue_[name].CopyFrom(v);
            }

            public void DeleteValue(string name)
            {
                mapValue_.Remove(name);
            }

            public void Copy(gstd.ref_count_ptr<ScriptCommonData> dataSrc)
            {
                mapValue_.Clear();
                List<string> listSrcKey = dataSrc.GetKeyList();
                for (int iKey = 0 ; iKey < listSrcKey.Count ; iKey++)
                {
                    string key = listSrcKey[iKey];
                    gstd.value vSrc = dataSrc.GetValue(key);
                    gstd.value vDest = vSrc;
                    vDest.unique();
                    mapValue_[key].CopyFrom(vDest);
                }
            }

            public List<string> GetKeyList()
            {
                List<string> res = new List<string>();
                SortedDictionary<string, gstd.value>.Enumerator itrValue;
                for (itrValue = mapValue_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string key = itrValue.Current.Key;
                    res.Add(key);
                }
                return new List<string>(res);
            }

            public void ReadRecord(gstd.RecordBuffer record)
            {
                mapValue_.Clear();

                List<string> listKey = record.GetKeyList();
                for (int iKey = 0 ; iKey < listKey.Count ; iKey++)
                {
                    string key = listKey[iKey];
                    string keyValSize = StringUtility.Format("%s_size", key);
                    if (!record.IsExists(keyValSize))
                    {
                        continue; // �T�C�Y���g���L�[�o�^����Ă���
                    }
                    int valSize = record.GetRecordAsInteger(keyValSize);

                    gstd.ByteBuffer buffer = new gstd.ByteBuffer();
                    buffer.SetSize(valSize);
                    record.GetRecord(key, buffer.GetPointer(), valSize);
                    gstd.value comVal = _ReadRecord(buffer);
                    mapValue_[key].CopyFrom(comVal);
                }
            }

            public void WriteRecord(gstd.RecordBuffer record)
            {
                SortedDictionary<string, gstd.value>.Enumerator itrValue;
                for (itrValue = mapValue_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string key = itrValue.Current.Key;
                    gstd.value comVal = itrValue.Current.Value;

                    gstd.ByteBuffer buffer = new gstd.ByteBuffer();
                    _WriteRecord(buffer, comVal);
                    string keyValSize = StringUtility.Format("%s_size", key);
                    int valSize = buffer.GetSize();
                    record.SetRecordAsInteger(keyValSize, valSize);
                    record.SetRecord(key, buffer.GetPointer(), valSize);
                }
            }
    }

    /**********************************************************
    //ScriptCommonDataInfoPanel
    **********************************************************/
    public class ScriptCommonDataInfoPanel : WindowLogger.Panel
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum2
            {
                COL_AREA = 0,
                COL_KEY = 0,
                COL_VALUE
            }

            protected gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager_ = new gstd.ref_count_ptr<ScriptCommonDataManager>();
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();

            protected WSplitter wndSplitter_ = new WSplitter();
            protected WListView wndListViewArea_ = new WListView();
            protected WListView wndListViewValue_ = new WListView();
            protected int timeLastUpdate_;
            protected int timeUpdateInterval_;

            protected virtual bool _AddedLogger(IntPtr hTab)
            {
                Create(hTab);

                gstd.WListView.Style styleListViewArea = new gstd.WListView.Style();
                styleListViewArea.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOCOLUMNHEADER);
                styleListViewArea.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListViewArea.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListViewArea_.Create(hWnd_, styleListViewArea);
                wndListViewArea_.AddColumn(256, 0, "area");

                gstd.WListView.Style styleListViewValue = new gstd.WListView.Style();
                styleListViewValue.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOSORTHEADER);
                styleListViewValue.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListViewValue.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListViewValue_.Create(hWnd_, styleListViewValue);
                wndListViewValue_.AddColumn(96, (int)AnonymousEnum2.COL_KEY, "Key");
                wndListViewValue_.AddColumn(256, (int)AnonymousEnum2.COL_VALUE, "Value");

                wndSplitter_.Create(hWnd_, WSplitter.TYPE_HORIZONTAL);
                wndSplitter_.SetRatioY(0.25f);

                return true;
            }

            protected void _UpdateListViewKey(WListView listView, List<string> listKey)
            {
                SortedSet<string> listManageData = new SortedSet<string>();
                SortedSet<string> listAdd = new SortedSet<string>();

                int iKey = 0;
                for (iKey = 0 ; iKey < listKey.Count ; iKey++)
                {
                    string area = listKey[iKey];
                    listManageData.Add(area);
                    listAdd.Add(area);
                }

                int countView = listView.GetRowCount();
                int iRow = 0;
                for (iRow = 0 ; iRow < countView ; iRow++)
                {
                    string wArea = listView.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                    string area = StringUtility.ConvertWideToMulti(wArea);
                    listAdd.erase(area);
                }

                // �폜
                for (iRow = 0; iRow < listView.GetRowCount();)
                {
                    string wKey = listView.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                    string key = StringUtility.ConvertWideToMulti(wKey);
                    if (listManageData.find(key) != listManageData.end())
                    {
                        iRow++;
                    }
                    else
                    {
                        listView.DeleteRow(iRow);
                    }
                }

                // �ǉ�
                iRow = 0;
                countView = listView.GetRowCount();
                SortedSet<string>.Enumerator itr = listAdd.GetEnumerator();
                while (itr.MoveNext())
                {
                    string str1 = itr.Current;
                    for (;iRow < listView.GetRowCount() ; iRow++)
                    {
                        string wstr2 = listView.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                        string str2 = StringUtility.ConvertWideToMulti(wstr2);
                        int index = strcmp(str1, str2);
                        if (index < 0)
                        {
                            string wstr1 = StringUtility.ConvertMultiToWide(str1);
                            listView.SetText(iRow, (int)AnonymousEnum2.COL_KEY, wstr1);
                            break;
                        }
                    }
                    if (iRow >= listView.GetRowCount())
                    {
                        break;
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: itr = listAdd.erase(itr);
                    itr.CopyFrom(listAdd.erase(itr));
                }

                itr = listAdd.GetEnumerator();
                while (itr.MoveNext())
                {
                    string str1 = itr.Current;
                    string wstr1 = StringUtility.ConvertMultiToWide(str1);
                    listView.SetText(listView.GetRowCount(), (int)AnonymousEnum2.COL_KEY, wstr1);
                }
            }

            protected void _UpdateAreaView()
            {
                List<string> listKey = commonDataManager_.GetKeyList();
                _UpdateListViewKey(wndListViewArea_, new List<string>(listKey));
            }

            protected void _UpdateValueView()
            {
                int indexArea = wndListViewArea_.GetSelectedRow();
                if (indexArea < 0)
                {
                    if (wndListViewValue_.GetRowCount() > 0)
                    {
                        wndListViewValue_.Clear();
                    }
                    return;
                }

                string wArea = wndListViewArea_.GetText(indexArea, (int)AnonymousEnum2.COL_AREA);
                string area = StringUtility.ConvertWideToMulti(wArea);
                gstd.ref_count_ptr<ScriptCommonData> commonData = commonDataManager_.GetData(area);
                List<string> listKey = commonData.GetKeyList();
                _UpdateListViewKey(wndListViewValue_, new List<string>(listKey));

                int countView = wndListViewValue_.GetRowCount();
                for (int iRow = 0 ; iRow < countView ; iRow++)
                {
                    string wKey = wndListViewValue_.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                    string key = StringUtility.ConvertWideToMulti(wKey);
                    gstd.value val = commonData.GetValue(key);
                    wndListViewValue_.SetText(iRow, (int)AnonymousEnum2.COL_VALUE, val.as_string());
                }
            }


            /**********************************************************
            //ScriptCommonDataPanel
            **********************************************************/
            public ScriptCommonDataInfoPanel()
            {
                timeLastUpdate_ = 0;
                timeUpdateInterval_ = 500;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                commonDataManager_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonDataManager();
            }

            public void SetUpdateInterval(int time)
            {
                timeUpdateInterval_ = time;
            }
            public virtual void LocateParts()
            {
                int wx = GetClientX();
                int wy = GetClientY();
                int wWidth = GetClientWidth();
                int wHeight = GetClientHeight();

                int ySplitter = (int)((float)wHeight * wndSplitter_.GetRatioY());
                int heightSplitter = 6;

                wndSplitter_.SetBounds(wx, ySplitter, wWidth, heightSplitter);
                wndListViewArea_.SetBounds(wx, wy, wWidth, ySplitter);
                wndListViewValue_.SetBounds(wx, ySplitter + heightSplitter, wWidth, wHeight - ySplitter - heightSplitter);
            }

            public virtual void Update(gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager)
            {
                if (!IsWindowVisible())
                {
                    return;
                }
                {
                    Lock @lock = new Lock(lock_);
                    commonDataManager_.Clear();

                    if (commonDataManager != null)
                    {
                        List<string> listKey = commonDataManager.GetKeyList();
                        for (int iKey = 0 ; iKey < listKey.Count ; iKey++)
                        {
                            string area = listKey[iKey];
                            gstd.ref_count_ptr<ScriptCommonData> dataSrc = commonDataManager.GetData(area);
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                            gstd.ref_count_ptr<ScriptCommonData> dataDest = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonData();
                            dataDest.Copy(dataSrc);
                            commonDataManager_.SetData(area, dataDest);
                        }
                    }

                    _UpdateAreaView();
                    _UpdateValueView();
                }
            }
    }

}