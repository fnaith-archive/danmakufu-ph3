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

/**********************************************************
//StgUserExtendScene
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgUserExtendSceneScriptManager;
public class StgUserExtendScene : System.IDisposable
{
        protected StgSystemController systemController_;
        protected ref_count_ptr<StgUserExtendSceneScriptManager> scriptManager_ = new ref_count_ptr<StgUserExtendSceneScriptManager>();

        protected void _InitializeTransitionTexture()
        {
            // ��ʃL���v�`��
            StgStageController stageController = systemController_.GetStageController();
            if (stageController != null)
            {
                stageController.RenderToTransitionTexture();
            }

        }

        protected void _InitializeScript(string path, int type)
        {
            if (scriptManager_ == null)
            {
                return;
            }
            _int64 idScript = scriptManager_.LoadScript(path, type);
            scriptManager_.StartScript(idScript);
        }

        protected void _CallScriptMainLoop()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            scriptManager_.Work();
        }

        protected void _CallScriptFinalize()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            scriptManager_.CallScriptFinalizeAll();
        }

        protected void _AddRelativeManager()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            ref_count_ptr<ScriptManager> scriptManager = new ref_count_ptr<ScriptManager>(scriptManager_);

            StgStageController stageController = systemController_.GetStageController();
            if (stageController != null)
            {
                ref_count_ptr<ScriptManager> stageScriptManager = stageController.GetScriptManagerR();
                if (stageScriptManager != null)
                {
                    ScriptManager.AddRelativeScriptManagerMutual(scriptManager, stageScriptManager);
                }
            }

            StgPackageController packageController = systemController_.GetPackageController();
            if (packageController != null)
            {
                ref_count_ptr<ScriptManager> packageScriptManager = packageController.GetScriptManager();
                if (packageScriptManager != null)
                {
                    ScriptManager.AddRelativeScriptManagerMutual(scriptManager, packageScriptManager);
                }
            }
        }


        /**********************************************************
        //StgUserExtendScene
        **********************************************************/
        public StgUserExtendScene(StgSystemController controller)
        {
            systemController_ = controller;
        }

        public virtual void Dispose()
        {
        }

        public ref_count_ptr<StgUserExtendSceneScriptManager> GetScriptManager()
        {
            return new ref_count_ptr<StgUserExtendSceneScriptManager>(scriptManager_);
        }

        public virtual void Work()
        {
        }

        public virtual void Render()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            scriptManager_.Render();
        }

        public virtual void Start()
        {
        }

        public virtual void Finish()
        {
        }

}

/**********************************************************
//StgUserExtendSceneScriptManager
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgUserExtendSceneScript;
public class StgUserExtendSceneScriptManager : StgControlScriptManager
{
        protected StgSystemController systemController_;
        protected ref_count_ptr<DxScriptObjectManager> objectManager_ = new ref_count_ptr<DxScriptObjectManager>();


        /**********************************************************
        //StgUserExtendSceneScriptManager
        **********************************************************/
        public StgUserExtendSceneScriptManager(StgSystemController controller)
        {
            systemController_ = controller;
            objectManager_ = new DxScriptObjectManager();
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override void Work()
        {
            if (!IsError())
            {
                StgControlScriptManager.Work();
                objectManager_.WorkObject();
            }
            else
            {
                systemController_.GetSystemInformation().SetError(error_);
            }

        }

        public override void Render()
        {
            objectManager_.RenderObject();
        }

        public override ref_count_ptr<ManagedScript> Create(int type)
        {
            ref_count_ptr<ManagedScript> res = new ref_count_ptr<ManagedScript>();
            switch (type)
            {
                case StgUserExtendSceneScript.AnonymousEnum.TYPE_PAUSE_SCENE:
                    res = new StgPauseSceneScript(systemController_);
                    break;
                case StgUserExtendSceneScript.AnonymousEnum.TYPE_END_SCENE:
                    res = new StgEndSceneScript(systemController_);
                    break;
                case StgUserExtendSceneScript.AnonymousEnum.TYPE_REPLAY_SCENE:
                    res = new StgReplaySaveScript(systemController_);
                    break;
            }

            if (res != null)
            {
                res.SetObjectManager(objectManager_);
                res.SetScriptManager(this);
            }

            return new ref_count_ptr<ManagedScript>(res);
        }

        public void CallScriptFinalizeAll()
        {
            LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<ManagedScript> script = itr.Current;
                if (script.IsEventExists("Finalize"))
                {
                    script.Run("Finalize");
                }
            }
        }

        public gstd.value GetResultValue()
        {
            gstd.value res = new gstd.value();
            LinkedList<ref_count_ptr<ManagedScript>>.Enumerator itr = listScriptRun_.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<ManagedScript> script = itr.Current;
                gstd.value v = script.GetResultValue();
                if (v.has_data())
                {
                    res.CopyFrom(v);
                    break;
                }
            }
            return new gstd.value(res);
        }

        public bool IsRealValue(gstd.value val)
        {
            if (listScriptRun_.Count == 0)
            {
                return false;
            }
            ref_count_ptr<ManagedScript> script = *listScriptRun_.GetEnumerator();

            bool res = script.IsRealValue(val);
            return res;
        }
}

/**********************************************************
//StgUserExtendSceneScript
**********************************************************/
public class StgUserExtendSceneScript : StgControlScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TYPE_PAUSE_SCENE,
            TYPE_END_SCENE,
            TYPE_REPLAY_SCENE
        }




        /**********************************************************
        //StgUserExtendSceneScript
        **********************************************************/
        public StgUserExtendSceneScript(StgSystemController systemController) : base(systemController)
        {
            StgStageController stageController = systemController_.GetStageController();

            StgStageScriptManager scriptManager = stageController.GetScriptManagerP();

            mainThreadID_ = scriptManager.GetMainThreadID();
        }

        public override void Dispose()
        {
            base.Dispose();
        }
}

/**********************************************************
//StgPauseScene
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgPauseSceneScript;
public class StgPauseScene : StgUserExtendScene
{



        /**********************************************************
        //StgPauseScene
        **********************************************************/
        public StgPauseScene(StgSystemController controller) : base(controller)
        {
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public override void Work()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            _CallScriptMainLoop();

            ref_count_ptr<StgSystemInformation> infoSystem = systemController_.GetSystemInformation();
            ref_count_ptr<StgStageInformation> infoStage = systemController_.GetStageController().GetStageInformation();
            gstd.value resValue = scriptManager_.GetResultValue();
            if (scriptManager_.IsRealValue(resValue))
            {
                int result = (int)resValue.as_real();
                if (result == StgControlScript.RESULT_CANCEL)
                {
                }
                else if (result == StgControlScript.RESULT_END)
                {
                    if (infoSystem.IsPackageMode())
                    {
                        infoStage.SetResult(StgStageInformation.RESULT_BREAK_OFF);
                        infoStage.SetEnd();
                        // infoSystem->SetScene(StgSystemInformation::SCENE_PACKAGE_CONTROL);
                    }
                    else
                    {
                        infoSystem.SetStgEnd();
                    }
                }
                else if (result == StgControlScript.RESULT_RETRY)
                {
                    if (!infoStage.IsReplay())
                    {
                        infoSystem.SetRetry();
                    }
                }
                EDirectInput.GetInstance().ResetInputState();
                Finish();
            }
        }

        public override void Start()
        {
            // ��~�C�x���g�Ăяo��
            StgStageController stageController = systemController_.GetStageController();
            StgStageScriptManager stageScriptManager = stageController.GetScriptManagerP();
            stageScriptManager.RequestEventAll(StgStageScript.EV_PAUSE_ENTER);

            // ��~����������
            scriptManager_ = null;
            scriptManager_ = new StgUserExtendSceneScriptManager(systemController_);
            _AddRelativeManager();
            ref_count_ptr<StgSystemInformation> sysInfo = systemController_.GetSystemInformation();

            _InitializeTransitionTexture();

            // �X�N���v�g������
            string path = sysInfo.GetPauseScriptPath();
            _InitializeScript(path, (int)StgUserExtendSceneScript.AnonymousEnum.TYPE_PAUSE_SCENE);

            if (stageController != null)
            {
                stageController.GetStageInformation().SetPause(true);
            }
        }

        public override void Finish()
        {
            StgStageController stageController = systemController_.GetStageController();
            if (stageController != null)
            {
                stageController.GetStageInformation().SetPause(false);
            }

            if (scriptManager_ == null)
            {
                return;
            }
            _CallScriptFinalize();
            scriptManager_ = null;

            // ����C�x���g�Ăяo��
            StgStageScriptManager stageScriptManager = stageController.GetScriptManagerP();
            stageScriptManager.RequestEventAll(StgStageScript.EV_PAUSE_LEAVE);
        }
}

public class StgPauseSceneScript : StgUserExtendSceneScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {

        }



        public StgPauseSceneScript(StgSystemController controller) : base(controller)
        {
            typeScript_ = TYPE_PAUSE_SCENE;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgPauseFunction, sizeof(stgPauseFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgPauseFunction, GlobalMembers.stgPauseFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }
}


/**********************************************************
//StgEndScene
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgEndScript;
public class StgEndScene : StgUserExtendScene
{



        // �ꎞ��~��p�֐��F�ꎞ��~����


        /**********************************************************
        //StgEndScene
        **********************************************************/
        public StgEndScene(StgSystemController controller) : base(controller)
        {

        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public new void Work()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            _CallScriptMainLoop();

            ref_count_ptr<StgSystemInformation> infoSystem = systemController_.GetSystemInformation();
            gstd.value resValue = scriptManager_.GetResultValue();
            if (scriptManager_.IsRealValue(resValue))
            {
                int result = (int)resValue.as_real();
                if (result == StgControlScript.RESULT_SAVE_REPLAY)
                {
                    // info->SetStgEnd();
                    systemController_.TransReplaySaveScene();
                }
                else if (result == StgControlScript.RESULT_END)
                {
                    infoSystem.SetStgEnd();
                }
                else if (result == StgControlScript.RESULT_RETRY)
                {
                    infoSystem.SetRetry();
                }
                EDirectInput.GetInstance().ResetInputState();
                Finish();
            }

        }

        public new void Start()
        {
            scriptManager_ = null;
            scriptManager_ = new StgUserExtendSceneScriptManager(systemController_);
            _AddRelativeManager();

            ref_count_ptr<StgSystemInformation> info = systemController_.GetSystemInformation();

            _InitializeTransitionTexture();

            // �X�N���v�g������
            string path = info.GetEndSceneScriptPath();
            _InitializeScript(path, (int)StgUserExtendSceneScript.AnonymousEnum.TYPE_END_SCENE);
        }

        public new void Finish()
        {
            ref_count_ptr<StgSystemInformation> info = systemController_.GetSystemInformation();

            if (scriptManager_ == null)
            {
                return;
            }
            _CallScriptFinalize();
            scriptManager_ = null;
        }
}

/**********************************************************
//StgEndSceneScript
**********************************************************/
public class StgEndSceneScript : StgUserExtendSceneScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {

        }


        public StgEndSceneScript(StgSystemController controller) : base(controller)
        {
            typeScript_ = TYPE_END_SCENE;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgEndFunction, sizeof(stgEndFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgEndFunction, GlobalMembers.stgEndFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }
}

/**********************************************************
//StgReplaySaveScene
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgReplaySaveScript;
public class StgReplaySaveScene : StgUserExtendScene
{



        /**********************************************************
        //StgReplaySaveScene
        **********************************************************/
        public StgReplaySaveScene(StgSystemController controller) : base(controller)
        {

        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public new void Work()
        {
            if (scriptManager_ == null)
            {
                return;
            }
            _CallScriptMainLoop();

            ref_count_ptr<StgSystemInformation> infoSystem = systemController_.GetSystemInformation();
            gstd.value resValue = scriptManager_.GetResultValue();
            if (scriptManager_.IsRealValue(resValue))
            {
                int result = (int)resValue.as_real();
                if (result == StgControlScript.RESULT_END)
                {
                    infoSystem.SetStgEnd();
                }
                else if (result == StgControlScript.RESULT_CANCEL)
                {
                    systemController_.TransStgEndScene();
                }

                EDirectInput.GetInstance().ResetInputState();
                Finish();
            }
        }

        public new void Start()
        {
            scriptManager_ = null;
            scriptManager_ = new StgUserExtendSceneScriptManager(systemController_);
            _AddRelativeManager();

            ref_count_ptr<StgSystemInformation> info = systemController_.GetSystemInformation();

            // _InitializeTransitionTexture();

            // �X�N���v�g������
            string path = info.GetReplaySaveSceneScriptPath();
            _InitializeScript(path, (int)StgUserExtendSceneScript.AnonymousEnum.TYPE_REPLAY_SCENE);
        }

        public new void Finish()
        {
            ref_count_ptr<StgSystemInformation> info = systemController_.GetSystemInformation();

            if (scriptManager_ == null)
            {
                return;
            }
            _CallScriptFinalize();
            scriptManager_ = null;
        }
}

/**********************************************************
//StgReplaySaveScript
**********************************************************/
public class StgReplaySaveScript : StgUserExtendSceneScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum4
        {

        }


        public StgReplaySaveScript(StgSystemController controller) : base(controller)
        {
            typeScript_ = TYPE_REPLAY_SCENE;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgReplaySaveFunction, sizeof(stgReplaySaveFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgReplaySaveFunction, GlobalMembers.stgReplaySaveFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

}