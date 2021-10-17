using System.Collections.Generic;
using Gstd.GstdUtility;
using Gstd.Script;

namespace Gstd
{
    namespace ScriptClient
    {
        sealed class ScriptClientBase
        {
            public const int ID_SCRIPT_FREE = -1;
            //public static script_type_manager* GetDefaultScriptTypeManager(){return &typeManagerDefault_;}
            private static ScriptTypeManager typeManagerDefault = new ScriptTypeManager();

            private bool bError;
            //private gstd::ref_count_ptr<ScriptEngineCache> cache_;
            private ScriptEngineData engine;
            private ScriptMachine machine;

            private List<Function> func;
            /*private ref_count_ptr<MersenneTwister> mt_;
            private gstd::ref_count_ptr<ScriptCommonDataManager> commonDataManager_;*/
            private int mainThreadID;
            private long idScript;

            /*private gstd::CriticalSection criticalSection_;*/

            private List<Value> listValueArg;
            private Value valueRes;
            
            public ScriptClientBase()
            {
                bError = false;
                engine = new ScriptEngineData();
                machine = null;
                mainThreadID = -1;
                idScript = ID_SCRIPT_FREE;
                valueRes = new Value();

                //commonDataManager_ = new ScriptCommonDataManager();
                //mt_ = new MersenneTwister();
                //mt_->Initialize(timeGetTime());
                //_AddFunction(commonFunction, sizeof(commonFunction)/sizeof(function));
            }
            /*public virtual ~ScriptClientBase();
            public void SetScriptEngineCache(gstd::ref_count_ptr<ScriptEngineCache> cache){cache_ = cache;}*/
            public ScriptEngineData GetEngine()
            {
                return engine;
            }
            /*public virtual bool SetSourceFromFile(string path);
            public virtual void SetSource(std::vector<char>& source);
            public virtual void SetSource(string source);

            public string GetPath(){return engine_->GetPath();}
            public void SetPath(string path){engine_->SetPath(path);}

            public virtual void Compile();
            public virtual bool Run();
            public virtual bool Run(string target);*/
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
            /*public void CheckRunInMainThread()
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
            /*public ScriptCommonDataManager* GetCommonDataManager(){return commonDataManager_.GetPointer();}*/

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

                string str = //StringUtility::Format(L"%s\r\n%s \r\n%s line(�s)=%d\r\n\r\n��\r\n%s\r\n�`�`�`",
                    message/*.c_str(),
                    entry.path_.c_str(),
                    fileName.c_str(),
                    lineOriginal, 
                    errorPos.c_str())*/;
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
            /*private virtual std::vector<char> _Include(std::vector<char>& source);*/
            private bool _CreateEngine()
            {
                machine = null;

                string source = engine.GetSource();

                ScriptEngine scriptEngine = new ScriptEngine(typeManagerDefault, source, func.ToArray());
                engine.SetEngine(scriptEngine);
                return true;
            }
            /*private string _ExtendPath(string path);*/
        }
    }
}
