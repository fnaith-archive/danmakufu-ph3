using gstd;
using directx;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DWORD_PTR DWORD*
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace directx
{
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ManagedScript;
    /**********************************************************
    //ScriptManager
    **********************************************************/
    public abstract class ScriptManager : gstd.FileManager.LoadThreadListener, System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                MAX_CLOSED_SCRIPT_RESULT = 100,
                ID_INVALID = -1
            }

            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected static _int64 idScript_ = 0;
            protected bool bHasCloseScriptWork_;

            protected string error_ = "";
            protected SortedDictionary<_int64, gstd.ref_count_ptr<ManagedScript>> mapScriptLoad_ = new SortedDictionary<_int64, gstd.ref_count_ptr<ManagedScript>>();
            protected LinkedList<gstd.ref_count_ptr<ManagedScript>> listScriptRun_ = new LinkedList<gstd.ref_count_ptr<ManagedScript>>();
            protected SortedDictionary<_int64, gstd.value> mapClosedScriptResult_ = new SortedDictionary<_int64, gstd.value>();
            protected LinkedList<gstd.ref_count_weak_ptr<ScriptManager>> listRelativeManager_ = new LinkedList<gstd.ref_count_weak_ptr<ScriptManager>>();

            protected int mainThreadID_;

            protected _int64 _LoadScript(string path, ref_count_ptr<ManagedScript> script)
            {
                _int64 res = 0;

                res = script.GetScriptID();

                script.SetSourceFromFile(path);
                script.Compile();
                if (script.IsEventExists("Loading"))
                {
                    script.Run("Loading");
                }

                {
                    Lock @lock = new Lock(lock_);
                    script.bLoad_ = true;
                    mapScriptLoad_[res] = script;
                }

                return new _int64(res);
            }


            /**********************************************************
            //ScriptManager
            **********************************************************/
            public ScriptManager()
            {
                mainThreadID_ = GetCurrentThreadId();

                FileManager.GetBase().AddLoadThreadListener(this);
            }

            public virtual void Dispose()
            {
                FileManager.GetBase().RemoveLoadThreadListener(this);
                FileManager.GetBase().WaitForThreadLoadComplete();
            }

            public virtual void Work()
            {
                Work(ManagedScript.TYPE_ALL);
            }

            public virtual void Work(int targetType)
            {
                bHasCloseScriptWork_ = false;
                LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
                while (itr.MoveNext())
                {
                    ref_count_ptr<ManagedScript> script = itr.Current;
                    int type = script.GetScriptType();
                    if (targetType != ManagedScript.TYPE_ALL && targetType != type)
                    {
                        continue;
                    }

                    if (script.IsEndScript())
                    {
                        if (script.IsEventExists("Finalize"))
                        {
                            script.Run("Finalize");
                        }
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itr = listScriptRun_.erase(itr);
                        bHasCloseScriptWork_ |= true;
                    }
                    else
                    {
                        if (script.IsEventExists("MainLoop"))
                        {
                            script.Run("MainLoop");
                        }

                        bHasCloseScriptWork_ |= script.IsEndScript();
                    }

                }

            }

            public virtual void Render()
            {
                // �����ł̓I�u�W�F�N�g�̕`���s��Ȃ��B
            }

            public virtual void SetError(string error)
            {
                error_ = error;
            }
            public virtual bool IsError()
            {
                return error_ != "";
            }

            public int GetMainThreadID()
            {
                return mainThreadID_;
            }
            public _int64 IssueScriptID()
            {
                {
                    gstd.Lock @lock = new gstd.Lock(lock_);
                    idScript_++;
                    return new _int64(idScript_);
                }
            }

            public ref_count_ptr<ManagedScript> GetScript(_int64 id)
            {
                ref_count_ptr<ManagedScript> res = null;
                {
                    Lock @lock = new Lock(lock_);
                    if (mapScriptLoad_.ContainsKey(id))
                    {
                        res = mapScriptLoad_[id];
                    }
                    else
                    {
                        LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
                        while (itr.MoveNext())
                        {
                            if (itr.Current.GetScriptID() == id)
                            {
                                res = itr.Current;
                                break;
                            }
                        }
                    }
                }
                return new ref_count_ptr<ManagedScript>(res);
            }

            public void StartScript(_int64 id)
            {
                ref_count_ptr<ManagedScript> script = null;
                {
                    Lock @lock = new Lock(lock_);
                    if (!mapScriptLoad_.ContainsKey(id))
                    {
                        return;
                    }

                    script = mapScriptLoad_[id];
                }

                if (!script.IsLoad())
                {
                    int count = 0;
                    while (!script.IsLoad())
                    {
                        if (count % 1000 == 999)
                        {
                            Logger.WriteTop(StringUtility.Format("�ǂݍ��݊����ҋ@(ScriptManager)�F%s", script.GetPath().c_str()));
                        }
                        Sleep(1);
                        count++;
                    }
                }

                {
                    Lock @lock = new Lock(lock_);
                    mapScriptLoad_.Remove(id);
                    listScriptRun_.AddLast(script);
                }

                if (script != null && !IsError())
                {
                    if (script.IsEventExists("Initialize"))
                    {
                        script.Run("Initialize");
                    }
                }
            }

            public void CloseScript(_int64 id)
            {
                LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
                while (itr.MoveNext())
                {
                    ref_count_ptr<ManagedScript> script = itr.Current;
                    if (script.GetScriptID() == id)
                    {
                        script.SetEndScript();
                        mapClosedScriptResult_[id] = script.GetResultValue();
                        if (mapClosedScriptResult_.Count > AnonymousEnum.MAX_CLOSED_SCRIPT_RESULT)
                        {
                            _int64 targetID = mapClosedScriptResult_.GetEnumerator().first;
                            mapClosedScriptResult_.Remove(targetID);
                        }

                        if (script.IsAutoDeleteObject())
                        {
                            script.GetObjectManager().DeleteObjectByScriptID(id);
                        }

                        break;
                    }
                }
            }

            public void CloseScriptOnType(int type)
            {
                LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
                while (itr.MoveNext())
                {
                    ref_count_ptr<ManagedScript> script = itr.Current;
                    if (script.GetScriptType() == type)
                    {
                        script.SetEndScript();
                        _int64 id = script.GetScriptID();
                        mapClosedScriptResult_[id] = script.GetResultValue();
                        if (mapClosedScriptResult_.Count > AnonymousEnum.MAX_CLOSED_SCRIPT_RESULT)
                        {
                            _int64 targetID = mapClosedScriptResult_.GetEnumerator().first;
                            mapClosedScriptResult_.Remove(targetID);
                        }

                        if (script.IsAutoDeleteObject())
                        {
                            script.GetObjectManager().DeleteObjectByScriptID(id);
                        }
                    }
                }
            }

            public bool IsCloseScript(_int64 id)
            {
                ref_count_ptr<ManagedScript> script = GetScript(new _int64(id));
                bool res = script == null || script.IsEndScript();
                return res;
            }

            public int IsHasCloseScliptWork()
            {
                return bHasCloseScriptWork_;
            }
            public int GetAllScriptThreadCount()
            {
                int res = 0;
                {
                    Lock @lock = new Lock(lock_);
                    LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
                    while (itr.MoveNext())
                    {
                        res += itr.Current.GetThreadCount();
                    }
                }
                return res;
            }

            public void TerminateScriptAll(string message)
            {
                {
                    Lock @lock = new Lock(lock_);
                    LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
                    while (itr.MoveNext())
                    {
                        itr.Current.Terminate(message);
                    }
                }
            }

            public _int64 LoadScript(string path, ref_count_ptr<ManagedScript> script)
            {
                _int64 res = 0;
                {
                    Lock @lock = new Lock(lock_);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = _LoadScript(path, script);
                    res.CopyFrom(_LoadScript(path, new ref_count_ptr<ManagedScript>(script)));
                    mapScriptLoad_[res] = script;
                }
                return new _int64(res);
            }

            public _int64 LoadScript(string path, int type)
            {
                ref_count_ptr<ManagedScript> script = Create(type);
                _int64 res = LoadScript(path, new ref_count_ptr<ManagedScript>(script));
                return new _int64(res);
            }

            public _int64 LoadScriptInThread(string path, ref_count_ptr<ManagedScript> script)
            {
                _int64 res = 0;
                {
                    Lock @lock = new Lock(lock_);

                    res = script.GetScriptID();
                    mapScriptLoad_[res] = script;

                    ref_count_ptr<FileManager.LoadThreadEvent> @event = new FileManager.LoadThreadEvent(this, path, script);
                    FileManager.GetBase().AddLoadThreadEvent(@event);
                }
                return new _int64(res);
            }

            public _int64 LoadScriptInThread(string path, int type)
            {
                ref_count_ptr<ManagedScript> script = Create(type);
                _int64 res = LoadScriptInThread(path, new ref_count_ptr<ManagedScript>(script));
                return new _int64(res);
            }

            public virtual void CallFromLoadThread(gstd.ref_count_ptr<gstd.FileManager.LoadThreadEvent> @event)
            {
                string path = @event.GetPath();

                ref_count_ptr<ManagedScript> script = new ref_count_ptr<ManagedScript>(@event.GetSource());
                if (script == null || script.IsLoad())
                {
                    return;
                }

                try
                {
                    _LoadScript(path, new ref_count_ptr<ManagedScript>(script));
                }
                catch (gstd.wexception e)
                {
                    Logger.WriteTop(e.what());
                    script.bLoad_ = true;
                    SetError(e.what());
                }
            }

            public abstract gstd.ref_count_ptr<ManagedScript> Create(int type);
            public virtual void RequestEventAll(int type, List<gstd.value> listValue = List<gstd.value>())
            {
                {
                    LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itrScript = listScriptRun_.GetEnumerator();
                    while (itrScript.MoveNext())
                    {
                        ref_count_ptr<ManagedScript> script = itrScript.Current;
                        if (script.IsEndScript())
                        {
                            continue;
                        }

                        script.RequestEvent(type, listValue);
                    }
                }

                if (listRelativeManager_.Count > 0)
                {
                    LinkedList<gstd.ref_count_weak_ptr<ScriptManager>>.Enumerator itrManager = listRelativeManager_.GetEnumerator();
                    while (itrManager.MoveNext())
                    {
                        gstd.ref_count_weak_ptr<ScriptManager> manager = itrManager.Current;
                        if (manager != null)
                        {
                            LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itrScript = manager.listScriptRun_.begin();
                            while (itrScript.MoveNext())
                            {
                                ref_count_ptr<ManagedScript> script = itrScript.Current;
                                if (script.IsEndScript())
                                {
                                    continue;
                                }

                                script.RequestEvent(type, listValue);
                            }
                        }
                        else
                        {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                            itrManager = listRelativeManager_.erase(itrManager);
                        }
                    }
                }
            }

            public gstd.value GetScriptResult(_int64 idScript)
            {
                gstd.value res = new gstd.value();
                ref_count_ptr<ManagedScript> script = GetScript(new _int64(idScript));
                if (script != null)
                {
                    res = script.GetResultValue();
                }
                else
                {
                    if (mapClosedScriptResult_.ContainsKey(idScript))
                    {
                        res = mapClosedScriptResult_[idScript];
                    }
                }

                return new gstd.value(res);
            }

            public void AddRelativeScriptManager(gstd.ref_count_weak_ptr<ScriptManager> manager)
            {
                listRelativeManager_.AddLast(manager);
            }
            public static void AddRelativeScriptManagerMutual(gstd.ref_count_weak_ptr<ScriptManager> manager1, gstd.ref_count_weak_ptr<ScriptManager> manager2)
            {
                manager1.AddRelativeScriptManager(manager2);
                manager2.AddRelativeScriptManager(manager1);
            }
    }


    /**********************************************************
    //ManagedScript
    **********************************************************/
    public class ManagedScriptParameter : System.IDisposable
    {
            public ManagedScriptParameter()
            {
            }
            public virtual void Dispose()
            {
            }
    }
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class ManagedScript : DxScript, gstd.FileManager.LoadObject
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend ScriptManager;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum2
            {
                TYPE_ALL = -1
            }

            protected ScriptManager scriptManager_;

            protected int typeScript_;
            protected gstd.ref_count_ptr<ManagedScriptParameter> scriptParam_ = new gstd.ref_count_ptr<ManagedScriptParameter>();
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile bool bLoad_;
            protected bool bLoad_;
            protected bool bEndScript_;
            protected bool bAutoDeleteObject_;

            protected int typeEvent_;
            protected List<gstd.value> listValueEvent_ = new List<gstd.value>();

            public ManagedScript()
            {
                scriptManager_ = null;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(commonFunction, sizeof(commonFunction) / sizeof(function));
                _AddFunction(GlobalMembers.commonFunction, GlobalMembers.commonFunction.Length);

                bLoad_ = false;
                bEndScript_ = false;
                bAutoDeleteObject_ = false;
            }

            public virtual void SetScriptManager(ScriptManager manager)
            {
                scriptManager_ = manager;
                mainThreadID_ = scriptManager_.GetMainThreadID();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: idScript_ = scriptManager_->IssueScriptID();
                idScript_.CopyFrom(scriptManager_.IssueScriptID());
            }

            public virtual void SetScriptParameter(gstd.ref_count_ptr<ManagedScriptParameter> param)
            {
                scriptParam_.CopyFrom(param);
            }
            public gstd.ref_count_ptr<ManagedScriptParameter> GetScriptParameter()
            {
                return new gstd.ref_count_ptr<ManagedScriptParameter>(scriptParam_);
            }

            public int GetScriptType()
            {
                return typeScript_;
            }
            public bool IsLoad()
            {
                return bLoad_;
            }
            public bool IsEndScript()
            {
                return bEndScript_;
            }
            public void SetEndScript()
            {
                bEndScript_ = true;
            }
            public bool IsAutoDeleteObject()
            {
                return bAutoDeleteObject_;
            }
            public void SetAutoDeleteObject(bool bEneble)
            {
                bAutoDeleteObject_ = bEneble;
            }

            public gstd.value RequestEvent(int type, List<gstd.value> listValue = List<gstd.value>())
            {
                gstd.value res = new gstd.value();
                string @event = "Event";

                if (!IsEventExists(@event))
                {
            // 		std::string log = StringUtility::Format("@Event������܂���B(%s)", GetPath().c_str());
            // 		throw std::exception(log.c_str());
                    return new gstd.value(res);
                }

                // �l��ޔ�(Run���ɏ��������\�������邽��)
                int tEventType = typeEvent_;
                gstd.value tValue = valueRes_;

                typeEvent_ = type;
                listValueEvent_ = new List<gstd.value>(listValue);
                valueRes_ = new gstd.value();

                Run(@event);
                res.CopyFrom(GetResultValue());

                // �l��߂�
                typeEvent_ = tEventType;
                valueRes_.CopyFrom(tValue);

                return new gstd.value(res);
            }


            // ���䋤�ʊ֐��F���ʃf�[�^
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            static gstd::value Func_SaveCommonDataAreaA1(gstd::script_machine machine, int argc, gstd::value argv);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            static gstd::value Func_LoadCommonDataAreaA1(gstd::script_machine machine, int argc, gstd::value argv);

            // ���䋤�ʊ֐��F�X�N���v�g����

            // STG���䋤�ʊ֐��F�X�N���v�g����
            public static gstd.value Func_LoadScript(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                string path = argv[0].as_string();
                int type = script.GetScriptType();
                ref_count_ptr<ManagedScript> target = scriptManager.Create(type);
                target.scriptParam_ = script.scriptParam_;

                _int64 res = scriptManager.LoadScript(path, new ref_count_ptr<ManagedScript>(target));
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_LoadScriptInThread(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                string path = argv[0].as_string();
                int type = script.GetScriptType();
                ref_count_ptr<ManagedScript> target = scriptManager.Create(type);
                target.scriptParam_ = script.scriptParam_;
                _int64 res = scriptManager.LoadScriptInThread(path, new ref_count_ptr<ManagedScript>(target));
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_StartScript(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                _int64 idScript = (_int64)argv[0].as_real();
                scriptManager.StartScript(new _int64(idScript));
                return new value();
            }

            public static gstd.value Func_CloseScript(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                _int64 idScript = (_int64)argv[0].as_real();
                scriptManager.CloseScript(new _int64(idScript));
                return new value();
            }

            public static gstd.value Func_IsCloseScript(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                _int64 idScript = (_int64)argv[0].as_real();
                bool res = scriptManager.IsCloseScript(new _int64(idScript));

                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static gstd.value Func_GetOwnScriptID(gstd.script_machine machine, int argc, gstd.value argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                _int64 res = script.GetScriptID();
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_GetEventType(script_machine machine, int argc, value argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                int res = script.typeEvent_;
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static gstd.value Func_GetEventArgument(script_machine machine, int argc, value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                int index = (int)argv[0].as_real();
                if (index < 0 || index >= script.listValueEvent_.Count)
                {
                    throw new gstd.wexception("�X�N���v�g�����̃C���f�b�N�X���s���ł�");
                }
                return new gstd.value(script.listValueEvent_[index]);
            }

            public static gstd.value Func_SetScriptArgument(script_machine machine, int argc, value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                _int64 idScript = (_int64)argv[0].as_real();
                ref_count_ptr<ManagedScript> target = scriptManager.GetScript(new _int64(idScript));
                if (target == null)
                {
                    return new value();
                }

                int index = (int)argv[1].as_real();
                target.SetArgumentValue(argv[2], index);

                return new value();
            }

            public static gstd.value Func_GetScriptResult(script_machine machine, int argc, value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                ScriptManager scriptManager = script.scriptManager_;

                _int64 idScript = (_int64)argv[0].as_real();
                gstd.value res = scriptManager.GetScriptResult(new _int64(idScript));
                return new gstd.value(res);
            }

            public static gstd.value Func_SetAutoDeleteObject(script_machine machine, int argc, value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;

                bool bAutoDelete = argv[0].as_boolean();
                script.SetAutoDeleteObject(bAutoDelete);
                return new value();
            }

            public static gstd.value Func_NotifyEvent(script_machine machine, int argc, value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                script.CheckRunInMainThread();
                ScriptManager scriptManager = script.scriptManager_;

                _int64 idScript = (_int64)argv[0].as_real();
                ref_count_ptr<ManagedScript> target = scriptManager.GetScript(new _int64(idScript));

                if (target == null)
                {
                    return new value();
                }

                int type = (int)argv[1].as_real();
                List<gstd.value> listArg = new List<gstd.value>();
                listArg.Add(argv[2]);
                gstd.value res = target.RequestEvent(type, listArg);

                return new gstd.value(res);
            }

            public static gstd.value Func_NotifyEventAll(script_machine machine, int argc, value[] argv)
            {
                ManagedScript script = (ManagedScript)machine.data;
                script.CheckRunInMainThread();

                ScriptManager scriptManager = script.scriptManager_;

                int type = (int)argv[0].as_real();
                List<gstd.value> listArg = new List<gstd.value>();
                listArg.Add(argv[1]);
                scriptManager.RequestEventAll(type, listArg);

                return new value();
            }
    }


}