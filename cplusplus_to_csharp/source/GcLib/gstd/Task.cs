using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class TaskBase;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class TaskFunction;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class TaskManager;

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    public enum AnonymousEnum
    {
        TASK_FREE_ID = 0xffffffff,
        TASK_GROUP_FREE_ID = 0xffffffff
    }
    /**********************************************************
    //TaskFunction
    **********************************************************/
    public abstract class TaskFunction : IStringInfo
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TaskManager;
            protected ref_count_ptr<TaskBase> task_ = new ref_count_ptr<TaskBase>(); // �^�X�N�ւ̃|�C���^
            protected int id_; // id
            protected bool bEnable_;
            protected int delay_;
            public TaskFunction()
            {
                task_ = null;
                id_ = (int)AnonymousEnum.TASK_FREE_ID;
                bEnable_ = true;
                delay_ = 0;
            }
            public override void Dispose()
            {
                base.Dispose();
            }
            public abstract void Call();

            public ref_count_ptr<TaskBase> GetTask()
            {
                return new ref_count_ptr<TaskBase>(task_);
            }
            public int GetID()
            {
                return id_;
            }
            public bool IsEnable()
            {
                return bEnable_;
            }

            public int GetDelay()
            {
                return delay_;
            }
            public void SetDelay(int delay)
            {
                delay_ = delay;
            }
            public bool IsDelay()
            {
                return delay_ > 0;
            }


            /**********************************************************
            //TaskFunction
            **********************************************************/
            public override string GetInfoAsString()
            {
                return task_.GetInfoAsString();
            }
    }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <class T>
    public class TTaskFunction <T> : TaskFunction
    {
            public delegate void Function();

            protected Function pFunc; // �����o�֐��|�C���^
            public TTaskFunction(ref_count_ptr<T> task, Function func)
            {
                task_.CopyFrom(task);
                pFunc = func;
            }
            public override void Call()
            {
                if (task_ != null)
                {
                    pFunc();
                }
            }

            public static ref_count_ptr<TaskFunction> Create(ref_count_ptr<TaskBase> task, Function func)
            {
                ref_count_ptr<T> dTask = new ref_count_ptr<T>(task);
                return new ref_count_ptr<TaskFunction>(TTaskFunction<T>.Create(new ref_count_ptr<T>(dTask), func));
            }
            public static ref_count_ptr<TaskFunction> Create(ref_count_ptr<T> task, Function func)
            {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                return global::new(_NORMAL_BLOCK, __FILE__, __LINE__) TTaskFunction<T>(task, func);
            }
    }

    /**********************************************************
    //TaskBase
    **********************************************************/
    public class TaskBase : IStringInfo
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TaskManager;
            protected _int64 indexTask_ = new _int64(); // TaskManager�ɂ���Ă������ӂ̃C���f�b�N�X
            protected int idTask_; // ID
            protected int idTaskGroup_; // �O���[�vID


            /**********************************************************
            //TaskBase
            **********************************************************/
            public TaskBase()
            {
                indexTask_ = -1;
                idTask_ = (int)AnonymousEnum.TASK_FREE_ID;
                idTaskGroup_ = (int)AnonymousEnum.TASK_GROUP_FREE_ID;
            }

            public override void Dispose()
            {

                base.Dispose();
            }

            public int GetTaskID()
            {
                return idTask_;
            }
            public _int64 GetTaskIndex()
            {
                return new _int64(indexTask_);
            }
    }

    /**********************************************************
    //TaskManager
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class TaskInfoPanel;
    public class TaskManager : TaskBase
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend TaskInfoPanel;
            protected static gstd.CriticalSection lockStatic_ = new gstd.CriticalSection();
            protected LinkedList<ref_count_ptr<TaskBase>> listTask_ = new LinkedList<ref_count_ptr<TaskBase>>(); // �^�X�N�̌��N���X
            protected SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >> mapFunc_ = new SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>(); // �^�X�N�@�\�̃��X�g(divFunc, priority, func)
            protected _int64 indexTaskManager_ = new _int64(); // ��ӂ̃C���f�b�N�X
            protected ref_count_ptr<TaskInfoPanel> panelInfo_ = new ref_count_ptr<TaskInfoPanel>();

            protected void _ArrangeTask()
            {
                // �^�X�N�폜�̈搮��
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itrTask;
                for (itrTask = listTask_.GetEnumerator(); itrTask.MoveNext();)
                {
                    if (itrTask.Current == null)
                    {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itrTask = listTask_.erase(itrTask);
                    }
                    else
                    {
                    }
                }

                // �֐��폜�̈搮��
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>.Enumerator itrType;
                for (itrType = mapFunc_.GetEnumerator(); itrType.MoveNext();)
                {
                    List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = itrType.Current.Value;
                    List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    for (itrPri = vectPri.GetEnumerator(); itrPri != vectPri.end();itrPri++)
                    {
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to references to variables:
// ORIGINAL LINE: System.Collections.Generic.LinkedList<ref_count_ptr<TaskFunction>> &listFunc = *itrPri;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                        LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri;
                        LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                        for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                        {
                            if (itrFunc.Current == null)
                            {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                                itrFunc = listFunc.erase(itrFunc);
                            }
                            else
                            {
                                int delay = itrFunc.Current.GetDelay();
                                delay = System.Math.Max(0, delay - 1);
                                itrFunc.Current.SetDelay(delay);
                            }
                        }
                    }
                }

                // �^�X�N���p�l���X�V
                if (panelInfo_ != null)
                {
                    panelInfo_.Update(this);
                }
            }

            protected void _CheckInvalidFunctionDivision(int divFunc)
            {
                if (!mapFunc_.ContainsKey(divFunc))
                {
                    throw new gstd.wexception("���݂��Ȃ��@�\�敪");
                }
            }


            /**********************************************************
            //TaskManager
            **********************************************************/
            public TaskManager()
            {
                indexTaskManager_ = 0;
            }

            public override void Dispose()
            {
                this.Clear();
                panelInfo_ = null;
                base.Dispose();
            }

            public void Clear()
            {
                listTask_.Clear();
                mapFunc_.Clear();
            }

            public void ClearTask()
            {
                listTask_.Clear();
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>.Enumerator itrDiv;
                for (itrDiv = mapFunc_.GetEnumerator(); itrDiv.MoveNext();)
                {
                    List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = itrDiv.Current.Value;
                    vectPri.Clear();
                }
            }

            public void AddTask(ref_count_ptr<TaskBase> task)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    ref_count_ptr<TaskBase> tTask = itr.Current;
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current == task)
                    {
                        return;
                    }
                }
            // 	task->mTask_ = this;

                // TODO ID�̊���U��
                task.indexTask_ = indexTaskManager_;
                indexTaskManager_++;
                listTask_.AddLast(task);
            }

            public ref_count_ptr<TaskBase> GetTask(int idTask)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.idTask_ != idTask)
                    {
                        continue;
                    }
                    return new ref_count_ptr<TaskBase>(itr.Current);
                }
                return null;
            }

            public ref_count_ptr<TaskBase> GetTask(System.Type info)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                    System.Type tInfo = typeid(itr.Current.Current.GetPointer());
                    if (info != tInfo)
                    {
                        continue;
                    }
                    return new ref_count_ptr<TaskBase>(itr.Current);
                }
                return null;
            }

            public void RemoveTask(TaskBase task)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.GetPointer() != task)
                    {
                        continue;
                    }
                    if (itr.Current.idTask_ != task.idTask_)
                    {
                        continue;
                    }
                    this.RemoveFunction(task);
                    itr.Current = null;
                    break;
                }
            }

            public void RemoveTask(int idTask)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.idTask_ != idTask)
                    {
                        continue;
                    }
                    this.RemoveFunction(itr.Current.GetPointer());
                    itr.Current = null;
                    break;
                }
            }

            public void RemoveTaskGroup(int idGroup)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
                    if (itr.Current.idTaskGroup_ != idGroup)
                    {
                        continue;
                    }
                    this.RemoveFunction(itr.Current.GetPointer());
                    itr.Current = null;
                }
            }

            public void RemoveTask(System.Type info)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                    System.Type tInfo = typeid(itr.Current.Current.GetPointer());
                    if (info != tInfo)
                    {
                        continue;
                    }
                    this.RemoveFunction(itr.Current.GetPointer());
                    itr.Current = null;
                }
            }

            public void RemoveTaskWithoutTypeInfo(SortedSet<System.Type> listInfo)
            {
                LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr;
                for (itr = listTask_.GetEnumerator(); itr.MoveNext();)
                {
                    if (itr.Current == null)
                    {
                        continue;
                    }
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                    System.Type tInfo = typeid(itr.Current.Current.GetPointer());
                    if (listInfo.find(tInfo) != listInfo.end())
                    {
                        continue;
                    }
                    this.RemoveFunction(itr.Current.GetPointer());
                    itr.Current = null;
                }
            }

            public LinkedList<ref_count_ptr<TaskBase>> GetTaskList()
            {
                return new LinkedList<ref_count_ptr<TaskBase>>(listTask_);
            }

            public void InitializeFunctionDivision(int divFunc, int maxPri)
            {
                if (mapFunc_.ContainsKey(divFunc))
                {
                    throw new gstd.wexception("���łɑ��݂��Ă���@�\�敪����������悤�Ƃ��܂����B");
                }
                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = new List<LinkedList<ref_count_ptr<TaskFunction>> >();
                vectPri.Resize(maxPri);
                mapFunc_[divFunc] = new List<LinkedList<ref_count_ptr<TaskFunction>> >(vectPri);
            }

            public void CallFunction(int divFunc)
            {
                _CheckInvalidFunctionDivision(divFunc);

                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                {
                    LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                    LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                    for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                    {
                        if (itrFunc.Current == null)
                        {
                            continue;
                        }
                        if (itrFunc.Current.bEnable_ == false)
                        {
                            continue;
                        }
                        if (itrFunc.Current.IsDelay())
                        {
                            continue;
                        }
                        itrFunc.Current.Call();
                    }
                }
                _ArrangeTask();
            }

            public void AddFunction(int divFunc, ref_count_ptr<TaskFunction> func, int pri, int idFunc = (int)AnonymousEnum.TASK_FREE_ID)
            {
                if (!mapFunc_.ContainsKey(divFunc))
                {
                    throw new gstd.wexception("���݂��Ȃ��@�\�敪");
                }
                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                func.id_ = idFunc;
                vectPri[pri].AddLast(func);
            }

            public void RemoveFunction(TaskBase task)
            {
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>.Enumerator itrDiv;
                for (itrDiv = mapFunc_.GetEnumerator(); itrDiv.MoveNext();)
                {
                    List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = itrDiv.Current.Value;
                    List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                    for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                    {
                        LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                        LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                        for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                        {
                            if (itrFunc.Current == null)
                            {
                                continue;
                            }
                            if (itrFunc.Current.task_ != task)
                            {
                                continue;
                            }
                            if (itrFunc.Current.task_.idTask_ != task.idTask_)
                            {
                                continue;
                            }
                            itrFunc.Current = null;
                        }
                    }
                }
            }

            public void RemoveFunction(TaskBase task, int divFunc, int idFunc)
            {
                _CheckInvalidFunctionDivision(divFunc);
                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                {
                    LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                    LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                    for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                    {
                        if (itrFunc.Current == null)
                        {
                            continue;
                        }
                        if (itrFunc.Current.id_ != idFunc)
                        {
                            continue;
                        }
                        if (itrFunc.Current.task_.idTask_ != task.idTask_)
                        {
                            continue;
                        }
                        itrFunc.Current = null;
                    }
                }
            }

            public void RemoveFunction(System.Type info)
            {
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>.Enumerator itrDiv;
                for (itrDiv = mapFunc_.GetEnumerator(); itrDiv.MoveNext();)
                {
                    List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = itrDiv.Current.Value;
                    List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                    for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                    {
                        LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                        LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                        for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                        {
                            if (itrFunc.Current == null)
                            {
                                continue;
                            }
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                            System.Type tInfo = typeid(itrFunc.Current.Current.task_);
                            if (info != tInfo)
                            {
                                continue;
                            }
                            itrFunc.Current = null;
                        }
                    }
                }
            }

            public SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >> GetFunctionMap()
            {
                return new SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>(mapFunc_);
            }

            public void SetFunctionEnable(bool bEnable)
            {
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>.Enumerator itrDiv;
                for (itrDiv = mapFunc_.GetEnumerator(); itrDiv.MoveNext();)
                {
                    List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = itrDiv.Current.Value;
                    List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                    for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                    {
                        LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                        LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                        for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                        {
                            if (itrFunc.Current == null)
                            {
                                continue;
                            }
                            itrFunc.Current.bEnable_ = bEnable;
                        }
                    }
                }
            }

            public void SetFunctionEnable(bool bEnable, int divFunc)
            {
                _CheckInvalidFunctionDivision(divFunc);
                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                {
                    LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                    LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                    for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                    {
                        if (itrFunc.Current == null)
                        {
                            continue;
                        }
                        itrFunc.Current.bEnable_ = bEnable;
                    }
                }
            }

            public void SetFunctionEnable(bool bEnable, int idTask, int divFunc)
            {
                ref_count_ptr<TaskBase> task = this.GetTask(idTask);
                if (task == null)
                {
                    return;
                }
                this.SetFunctionEnable(bEnable, task.GetPointer(), divFunc);
            }

            public void SetFunctionEnable(bool bEnable, int idTask, int divFunc, int idFunc)
            {
                ref_count_ptr<TaskBase> task = this.GetTask(idTask);
                if (task == null)
                {
                    return;
                }
                this.SetFunctionEnable(bEnable, task.GetPointer(), divFunc, idFunc);
            }

            public void SetFunctionEnable(bool bEnable, TaskBase task, int divFunc)
            {
                _CheckInvalidFunctionDivision(divFunc);
                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                {
                    LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                    LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                    for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                    {
                        if (itrFunc.Current == null)
                        {
                            continue;
                        }
                        if (itrFunc.Current.task_ != task)
                        {
                            continue;
                        }
                        if (itrFunc.Current.task_.idTask_ != task.idTask_)
                        {
                            continue;
                        }
                        itrFunc.Current.bEnable_ = bEnable;
                    }
                }
            }

            public void SetFunctionEnable(bool bEnable, TaskBase task, int divFunc, int idFunc)
            {
                _CheckInvalidFunctionDivision(divFunc);
                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                {
                    LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                    LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                    for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                    {
                        if (itrFunc.Current == null)
                        {
                            continue;
                        }
                        if (itrFunc.Current.task_ != task)
                        {
                            continue;
                        }
                        if (itrFunc.Current.task_.idTask_ != task.idTask_)
                        {
                            continue;
                        }
                        if (itrFunc.Current.id_ != idFunc)
                        {
                            continue;
                        }
                        itrFunc.Current.bEnable_ = bEnable;
                    }
                }
            }

            public void SetFunctionEnable(bool bEnable, System.Type info, int divFunc)
            {
                _CheckInvalidFunctionDivision(divFunc);

                List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = mapFunc_[divFunc];
                List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
                for (itrPri = vectPri.GetEnumerator(); itrPri.MoveNext();)
                {
                    LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri.Current;
                    LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                    for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                    {
                        if (itrFunc.Current == null)
                        {
                            continue;
                        }
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                        System.Type tInfo = typeid(itrFunc.Current.Current.task_);
                        if (info != tInfo)
                        {
                            continue;
                        }
                        itrFunc.Current.bEnable_ = bEnable;
                    }
                }
            }

            public void SetInfoPanel(ref_count_ptr<TaskInfoPanel> panel)
            {
                panelInfo_.CopyFrom(panel);
            }
            public gstd.CriticalSection GetStaticLock()
            {
                return new gstd.CriticalSection(lockStatic_);
            }
    }

    /**********************************************************
    //TaskInfoPanel
    **********************************************************/
    public class TaskInfoPanel : WindowLogger.Panel
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum2
            {
                ROW_FUNC_ADDRESS = 0,
                ROW_FUNC_CLASS,
                ROW_FUNC_ID,
                ROW_FUNC_DIVISION,
                ROW_FUNC_PRIORITY,
                ROW_FUNC_ENABLE,
                ROW_FUNC_INFO
            }
            protected WSplitter wndSplitter_ = new WSplitter();
            protected WTreeView wndTreeView_ = new WTreeView();
            protected WListView wndListView_ = new WListView();
            protected int timeLastUpdate_;
            protected int timeUpdateInterval_;
            protected int addressLastFindManager_;

            protected virtual bool _AddedLogger(IntPtr hTab)
            {
                Create(hTab);

                gstd.WTreeView.Style styleTreeView = new gstd.WTreeView.Style();
                styleTreeView.SetStyle(WS_CHILD | WS_VISIBLE | TVS_HASLINES | TVS_HASBUTTONS | TVS_LINESATROOT);
                styleTreeView.SetStyleEx(WS_EX_CLIENTEDGE);
                wndTreeView_.Create(hWnd_, styleTreeView);

                WTreeView.ItemStyle treeIteSmtyle = new WTreeView.ItemStyle();
                treeIteSmtyle.SetMask(TVIF_TEXT | TVIF_PARAM);
                wndTreeView_.CreateRootItem(treeIteSmtyle);

                gstd.WListView.Style styleListView = new gstd.WListView.Style();
                styleListView.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOSORTHEADER);
                styleListView.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListView.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListView_.Create(hWnd_, styleListView);
                wndListView_.AddColumn(64, (int)AnonymousEnum2.ROW_FUNC_ADDRESS, "Address");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_FUNC_CLASS, "Class");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_FUNC_ID, "ID");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_FUNC_DIVISION, "Div");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_FUNC_PRIORITY, "Pri");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_FUNC_ENABLE, "Enable");
                wndListView_.AddColumn(256, (int)AnonymousEnum2.ROW_FUNC_INFO, "Info");

                wndSplitter_.Create(hWnd_, WSplitter.TYPE_HORIZONTAL);
                wndSplitter_.SetRatioY(0.25f);

                return true;
            }

            protected void _UpdateTreeView(TaskManager taskManager, ref_count_ptr<WTreeView.Item> item)
            {
                // �o�^
                SortedSet<int> setAddress = new SortedSet<int>();
                {
                    LinkedList<ref_count_ptr<TaskBase>> listTask = taskManager.GetTaskList();
                    LinkedList<ref_count_ptr<TaskBase>>.Enumerator itrTask;
                    for (itrTask = listTask.GetEnumerator(); itrTask.MoveNext();)
                    {
                        if (itrTask.Current == null)
                        {
                            continue;
                        }
                        TaskManager task = itrTask.Current.GetPointer() as TaskManager;
                        if (task == null)
                        {
                            continue;
                        }

                        int address = (int)task;
                        ref_count_ptr<WTreeView.Item> itemChild = null;
                        LinkedList<ref_count_ptr<WTreeView.Item>> listChild = item.GetChildList();
                        LinkedList<ref_count_ptr<WTreeView.Item>>.Enumerator itrChild;
                        for (itrChild = listChild.GetEnumerator(); itrChild.MoveNext();)
                        {
                            ref_count_ptr<WTreeView.Item> iItem = itrChild.Current;
                            IntPtr param = iItem.GetParam();
                            if (param != address)
                            {
                                continue;
                            }
                            itemChild.CopyFrom(iItem);
                        }

                        if (itemChild == null)
                        {
                            WTreeView.ItemStyle treeIteSmtyle = new WTreeView.ItemStyle();
                            treeIteSmtyle.SetMask(TVIF_TEXT | TVIF_PARAM);
                            itemChild = item.CreateChild(treeIteSmtyle);
                        }
                        itemChild.SetText(task.GetInfoAsString());
                        itemChild.SetParam(address);
                        _UpdateTreeView(task, new ref_count_ptr<WTreeView.Item>(itemChild));
                        setAddress.Add(address);
                    }
                }

                {
                // �폜
                    LinkedList<ref_count_ptr<WTreeView.Item>> listChild = item.GetChildList();
                    LinkedList<ref_count_ptr<WTreeView.Item>>.Enumerator itrChild;
                    for (itrChild = listChild.GetEnumerator(); itrChild.MoveNext();)
                    {
                        ref_count_ptr<WTreeView.Item> iItem = itrChild.Current;
                        IntPtr param = iItem.GetParam();
                        if (setAddress.find(param) == setAddress.end())
                        {
                            iItem.Delete();
                        }
                    }
                }
            }

            protected void _UpdateListView(TaskManager taskManager)
            {
                if (addressLastFindManager_ != (int)taskManager)
                {
                    wndListView_.Clear();
                }

                if (taskManager == null)
                {
                    wndListView_.Clear();
                    return;
                }

                SortedSet<string> setKey = new SortedSet<string>();
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >> mapFunc = taskManager.GetFunctionMap();
                SortedDictionary<int, List<LinkedList<ref_count_ptr<TaskFunction>> >>.Enumerator itrType;
                for (itrType = mapFunc.GetEnumerator(); itrType.MoveNext();)
                {
                    int division = itrType.Current.Key;
                    int priority = 0;
                    List<LinkedList<ref_count_ptr<TaskFunction>> > vectPri = itrType.Current.Value;
                    List<LinkedList<ref_count_ptr<TaskFunction>> >.Enumerator itrPri;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    for (itrPri = vectPri.GetEnumerator(); itrPri != vectPri.end();itrPri++)
                    {
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to references to variables:
// ORIGINAL LINE: System.Collections.Generic.LinkedList<ref_count_ptr<TaskFunction>> &listFunc = *itrPri;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                        LinkedList<ref_count_ptr<TaskFunction>> listFunc = itrPri;
                        LinkedList<ref_count_ptr<TaskFunction>>.Enumerator itrFunc;
                        for (itrFunc = listFunc.GetEnumerator(); itrFunc.MoveNext();)
                        {
                            if (itrFunc.Current == null)
                            {
                                continue;
                            }
                            string keyList;

                            TaskFunction func = itrFunc.GetPointer();
                            int address = (int)func;
                            string key = StringUtility.Format("%08x", address);
                            int index = wndListView_.GetIndexInColumn(key, (int)AnonymousEnum2.ROW_FUNC_ADDRESS);
                            if (index == -1)
                            {
                                index = wndListView_.GetRowCount();
                                wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_ADDRESS, key);
                            }

// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                            string className = StringUtility.ConvertMultiToWide((string)typeidfunc.name());
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_CLASS, className);
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_ID, StringUtility.Format("%d", func.GetID()));
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_DIVISION, StringUtility.Format("%d", division));
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_PRIORITY, StringUtility.Format("%d", priority));
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_ENABLE, StringUtility.Format("%d", func.IsEnable()));
                            wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FUNC_INFO, func.GetInfoAsString());

                            setKey.Add(key);
                        }
                        priority++;
                    }
                }

                for (int iRow = 0; iRow < wndListView_.GetRowCount();)
                {
                    string key = wndListView_.GetText(iRow, (int)AnonymousEnum2.ROW_FUNC_ADDRESS);
                    if (setKey.find(key) != setKey.end())
                    {
                        iRow++;
                    }
                    else
                    {
                        wndListView_.DeleteRow(iRow);
                    }
                }

                addressLastFindManager_ = (int)taskManager;
            }


            /**********************************************************
            //TaskInfoPanel
            **********************************************************/
            public TaskInfoPanel()
            {
                addressLastFindManager_ = 0;
                timeLastUpdate_ = 0;
                timeUpdateInterval_ = 500;
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
                wndTreeView_.SetBounds(wx, wy, wWidth, ySplitter);
                wndListView_.SetBounds(wx, ySplitter + heightSplitter, wWidth, wHeight - ySplitter - heightSplitter);
            }

            public virtual void Update(TaskManager taskManager)
            {
                if (!IsWindowVisible())
                {
                    return;
                }
                int time = timeGetTime();
                if (System.Math.Abs(time - timeLastUpdate_) < timeUpdateInterval_)
                {
                    return;
                }
                timeLastUpdate_ = time;

                ref_count_ptr<WTreeView.Item> itemRoot = wndTreeView_.GetRootItem();
                itemRoot.SetText(taskManager.GetInfoAsString());
                itemRoot.SetParam((IntPtr)taskManager);
                _UpdateTreeView(taskManager, new ref_count_ptr<WTreeView.Item>(itemRoot));

                int addressManager = 0;
                ref_count_ptr<WTreeView.Item> itemSelected = wndTreeView_.GetSelectedItem();
                if (itemSelected != null)
                {
                    addressManager = itemSelected.GetParam();
                }
                _UpdateListView((TaskManager)addressManager);
            }
    }

    /**********************************************************
    //WorkRenderTaskManager
    //����A�`��@�\��ێ�����TaskManager
    **********************************************************/
    public class WorkRenderTaskManager : TaskManager
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum3
        {
            DIV_FUNC_WORK, // ����
            DIV_FUNC_RENDER // �`��
        }

            /**********************************************************
            //WorkRenderTaskManager
            **********************************************************/
            public WorkRenderTaskManager()
            {

            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public override void InitializeFunctionDivision(int maxPriWork, int maxPriRender)
            {
                base.InitializeFunctionDivision((int)AnonymousEnum3.DIV_FUNC_WORK, maxPriWork);
                base.InitializeFunctionDivision((int)AnonymousEnum3.DIV_FUNC_RENDER, maxPriRender);
            }

            // ����@�
// 			void CallWorkFunction();
            public void AddWorkFunction(ref_count_ptr<TaskFunction> func, int pri, int idFunc = (int)AnonymousEnum.TASK_FREE_ID)
            {
                func.SetDelay(1);
                AddFunction((int)AnonymousEnum3.DIV_FUNC_WORK, new ref_count_ptr<TaskFunction>(func), pri, idFunc);
            }

            public void RemoveWorkFunction(TaskBase task, int idFunc)
            {
                RemoveFunction(task, (int)AnonymousEnum3.DIV_FUNC_WORK, idFunc);
            }

            public void SetWorkFunctionEnable(bool bEnable)
            {
                SetFunctionEnable(bEnable, (int)AnonymousEnum3.DIV_FUNC_WORK);
            }

            public void SetWorkFunctionEnable(bool bEnable, int idTask)
            {
                SetFunctionEnable(bEnable, idTask, AnonymousEnum3.DIV_FUNC_WORK);
            }

            public void SetWorkFunctionEnable(bool bEnable, int idTask, int idFunc)
            {
                SetFunctionEnable(bEnable, idTask, AnonymousEnum3.DIV_FUNC_WORK, idFunc);
            }

            public void SetWorkFunctionEnable(bool bEnable, TaskBase task)
            {
                SetFunctionEnable(bEnable, task, AnonymousEnum3.DIV_FUNC_WORK);
            }

            public void SetWorkFunctionEnable(bool bEnable, TaskBase task, int idFunc)
            {
                SetFunctionEnable(bEnable, task, AnonymousEnum3.DIV_FUNC_WORK, idFunc);
            }

            public void SetWorkFunctionEnable(bool bEnable, System.Type info)
            {
                SetFunctionEnable(bEnable, info, AnonymousEnum3.DIV_FUNC_WORK);
            }

            // �`��@�
// 			void CallRenderFunction();
            public void AddRenderFunction(ref_count_ptr<TaskFunction> func, int pri, int idFunc = (int)AnonymousEnum.TASK_FREE_ID)
            {
                AddFunction((int)AnonymousEnum3.DIV_FUNC_RENDER, new ref_count_ptr<TaskFunction>(func), pri, idFunc);
            }

            public void RemoveRenderFunction(TaskBase task, int idFunc)
            {
                RemoveFunction(task, (int)AnonymousEnum3.DIV_FUNC_RENDER, idFunc);
            }

            public void SetRenderFunctionEnable(bool bEnable)
            {
                SetFunctionEnable(bEnable, (int)AnonymousEnum3.DIV_FUNC_RENDER);
            }

            public void SetRenderFunctionEnable(bool bEnable, int idTask)
            {
                SetFunctionEnable(bEnable, idTask, AnonymousEnum3.DIV_FUNC_RENDER);
            }

            public void SetRenderFunctionEnable(bool bEnable, int idTask, int idFunc)
            {
                SetFunctionEnable(bEnable, idTask, AnonymousEnum3.DIV_FUNC_RENDER, idFunc);
            }

            public void SetRenderFunctionEnable(bool bEnable, TaskBase task)
            {
                SetFunctionEnable(bEnable, task, AnonymousEnum3.DIV_FUNC_RENDER);
            }

            public void SetRenderFunctionEnable(bool bEnable, TaskBase task, int idFunc)
            {
                SetFunctionEnable(bEnable, task, AnonymousEnum3.DIV_FUNC_RENDER, idFunc);
            }

            public void SetRenderFunctionEnable(bool bEnable, System.Type info)
            {
                SetFunctionEnable(bEnable, info, AnonymousEnum3.DIV_FUNC_RENDER);
            }
    }

}

