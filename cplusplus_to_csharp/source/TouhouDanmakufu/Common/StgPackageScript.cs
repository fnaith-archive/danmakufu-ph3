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
//StgPackageScriptManager
**********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgPackageScript;
public class StgPackageScriptManager : StgControlScriptManager
{
        protected StgSystemController systemController_;
        protected ref_count_ptr<DxScriptObjectManager> objectManager_ = new ref_count_ptr<DxScriptObjectManager>();


        /**********************************************************
        //StgPackageScriptManager
        **********************************************************/
        public StgPackageScriptManager(StgSystemController controller)
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
                case StgPackageScript.AnonymousEnum.TYPE_PACKAGE_MAIN:
                    res = new StgPackageScript(systemController_.GetPackageController());
                    break;
            }

            if (res != null)
            {
                res.SetObjectManager(objectManager_);
                res.SetScriptManager(this);
            }

            return new ref_count_ptr<ManagedScript>(res);
        }

        public ref_count_ptr<DxScriptObjectManager> GetObjectManager()
        {
            return new ref_count_ptr<DxScriptObjectManager>(objectManager_);
        }
}

/**********************************************************
//StgPackageScript
**********************************************************/
public class StgPackageScript : StgControlScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TYPE_PACKAGE_MAIN,

            STAGE_STATE_FINISHED
        }

        private StgPackageController packageController_;
        private void _CheckNextStageExists()
        {
            ref_count_ptr<StgPackageInformation> infoPackage = packageController_.GetPackageInformation();
            ref_count_ptr<StgStageStartData> nextStageData = infoPackage.GetNextStageData();
            if (nextStageData == null)
            {
                RaiseError("not initialized stage data");
            }
        }

        public StgPackageScript(StgPackageController packageController) : base(packageController.GetSystemController())
        {
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgPackageFunction, sizeof(stgPackageFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgPackageFunction, GlobalMembers.stgPackageFunction.Length);

            typeScript_ = (int)AnonymousEnum.TYPE_PACKAGE_MAIN;
            packageController_ = packageController;
        }


        // �p�b�P�[�W���ʊ֐��F�p�b�P�[�W����

        // �p�b�P�[�W���ʊ֐��F�p�b�P�[�W����
        public static gstd.value Func_ClosePackage(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            infoPackage.SetEnd();

            return new value();
        }

        // �p�b�P�[�W���ʊ֐��F�X�e�[�W����

        // �p�b�P�[�W���ʊ֐��F�X�e�[�W����
        public static gstd.value Func_InitializeStageScene(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;

            StgSystemController systemController = packageController.GetSystemController();
            ref_count_ptr<StgSystemInformation> infoSystem = systemController.GetSystemInformation();
            infoSystem.SetActiveReplayInformation(null);

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            infoPackage.InitializeStageData();

            return new value();
        }

        public static gstd.value Func_FinalizeStageScene(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            StgSystemController systemController = packageController.GetSystemController();
            ref_count_ptr<StgSystemInformation> infoSystem = systemController.GetSystemInformation();

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            if (infoPackage.GetNextStageData() != null && infoPackage.GetNextStageData().GetPrevStageInformation() == null)
            {
                script.RaiseError("not finished stage");
            }

            List<ref_count_ptr<StgStageStartData>> listStage = infoPackage.GetStageDataList();
            if (listStage.Count > 0)
            {
                ref_count_ptr<StgStageStartData> stageData = listStage[listStage.Count - 1];
                ref_count_ptr<StgStageInformation> infoStage = stageData.GetStageInformation();
                bool bReplay = infoStage.IsReplay();
                if (bReplay)
                {
                    return new value();
                }
            }

            ref_count_ptr<ReplayInformation> infoReplay = systemController.CreateReplayInformation();
            infoSystem.SetActiveReplayInformation(infoReplay);

            return new value();
        }

        public static gstd.value Func_StartStageScene(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            script._CheckNextStageExists();

            StgSystemController systemController = packageController.GetSystemController();
            ref_count_ptr<StgSystemInformation> infoSystem = systemController.GetSystemInformation();
            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            ref_count_ptr<StgStageStartData> nextStageData = infoPackage.GetNextStageData();
            ref_count_ptr<StgStageInformation> infoStage = nextStageData.GetStageInformation();

            int stageIndex = infoStage.GetStageIndex();
            ref_count_ptr<ReplayInformation> infoReplay = infoPackage.GetReplayInformation();
            string replayPlayerID;
            string replayPlayerScriptFileName;
            if (infoReplay != null)
            {
                ref_count_ptr<ReplayInformation.StageData> replayStageData = infoReplay.GetStageData(stageIndex);
                if (replayStageData == null)
                {
                    script.RaiseError("invalid replay stage index");
                }
                nextStageData.SetStageReplayData(replayStageData);

                // ���@�X�N���v�g
                replayPlayerID = replayStageData.GetPlayerScriptID();
                replayPlayerScriptFileName = replayStageData.GetPlayerScriptFileName();
            }
            else
            {
                ref_count_ptr<ScriptInformation> infoPlayer = infoStage.GetPlayerScriptInformation();
                if (infoPlayer != null)
                {
                    replayPlayerID = infoPlayer.GetID();
                    replayPlayerScriptFileName = PathProperty.GetFileName(infoPlayer.GetScriptPath());
                }
            }

            // ���@�����
            infoStage.SetPlayerScriptInformation(null);
            ref_count_ptr<ScriptInformation> infoMain = infoSystem.GetMainScriptInformation();
            List<ref_count_ptr<ScriptInformation>> listPlayer = new List<new ref_count_ptr<ScriptInformation>>();
            List<string> listPlayerPath = infoMain.GetPlayerList();
            if (listPlayerPath.Count == 0)
            {
                string dir = EPathProperty.GetPlayerScriptRootDirectory();
                listPlayer = new List<ref_count_ptr<ScriptInformation>>(ScriptInformation.FindPlayerScriptInformationList(dir));
            }
            else
            {
                listPlayer = infoMain.CreatePlayerScriptInformationList();
            }

            for (int iPlayer = 0 ; iPlayer < listPlayer.Count ; iPlayer++)
            {
                ref_count_ptr<ScriptInformation> tInfo = listPlayer[iPlayer];
                if (tInfo.GetID() != replayPlayerID)
                {
                    continue;
                }
                string tPlayerScriptFileName = PathProperty.GetFileName(tInfo.GetScriptPath());
                if (tPlayerScriptFileName != replayPlayerScriptFileName)
                {
                    continue;
                }

                infoStage.SetPlayerScriptInformation(tInfo);
                break;
            }

            if (infoStage.GetPlayerScriptInformation() == null)
            {
                script.RaiseError("player not found");
            }

            // packageController->RenderToTransitionTexture();

            systemController.StartStgScene(new ref_count_ptr<StgStageStartData>(nextStageData));

            return new value();
        }

        public static gstd.value Func_SetStageIndex(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            script._CheckNextStageExists();

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            ref_count_ptr<StgStageStartData> nextStageData = infoPackage.GetNextStageData();
            ref_count_ptr<StgStageInformation> infoStage = nextStageData.GetStageInformation();

            int stageIndex = (int)argv[0].as_real();
            List<ref_count_ptr<StgStageStartData>> listStage = infoPackage.GetStageDataList();
            for (int iStage = 0 ; iStage < listStage.Count ;iStage++)
            {
                ref_count_ptr<StgStageStartData> stageData = listStage[iStage];
                if (stageIndex == stageData.GetStageInformation().GetStageIndex())
                {
                    script.RaiseError("stage index already used");
                }
            }


            infoStage.SetStageIndex(stageIndex);

            return new value();
        }

        public static gstd.value Func_SetStageMainScript(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            script._CheckNextStageExists();

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            ref_count_ptr<StgStageStartData> nextStageData = infoPackage.GetNextStageData();
            ref_count_ptr<StgStageInformation> infoStage = nextStageData.GetStageInformation();

            string path = argv[0].as_string();
            ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
            if (reader == null || !reader.Open())
            {
                string error = ErrorUtility.GetFileNotFoundErrorMessage(path);
                script.RaiseError(error);
            }

            string source = "";
            int size = reader.GetFileSize();
            source.resize(size);
            reader.Read(source[0], size);

            ref_count_ptr<ScriptInformation> infoScript = ScriptInformation.CreateScriptInformation(path, "", source, false);
            if (infoScript == null)
            {
                script.RaiseError(ErrorUtility.GetFileNotFoundErrorMessage(path));
            }

            infoStage.SetMainScriptInformation(infoScript);

            return new value();
        }

        public static gstd.value Func_SetStagePlayerScript(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            script._CheckNextStageExists();

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            ref_count_ptr<StgStageStartData> nextStageData = infoPackage.GetNextStageData();
            ref_count_ptr<StgStageInformation> infoStage = nextStageData.GetStageInformation();

            string path = argv[0].as_string();
            ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
            if (reader == null || !reader.Open())
            {
                string error = ErrorUtility.GetFileNotFoundErrorMessage(path);
                script.RaiseError(error);
            }

            string source = "";
            int size = reader.GetFileSize();
            source.resize(size);
            reader.Read(source[0], size);

            ref_count_ptr<ScriptInformation> infoScript = ScriptInformation.CreateScriptInformation(path, "", source);
            infoStage.SetPlayerScriptInformation(infoScript);

            return new value(machine.get_engine().get_boolean_type(), true);
        }

        public static gstd.value Func_SetStageReplayFile(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            script._CheckNextStageExists();

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();

            string pathReplay = argv[0].as_string();
            ref_count_ptr<ReplayInformation> infoRepray = ReplayInformation.CreateFromFile(pathReplay);
            if (infoRepray == null)
            {
                string path = ErrorUtility.GetFileNotFoundErrorMessage(pathReplay);
                script.RaiseError(path);
            }
            infoPackage.SetReplayInformation(infoRepray);
            return new value();
        }

        public static gstd.value Func_GetStageSceneState(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            StgSystemController systemController = packageController.GetSystemController();
            ref_count_ptr<StgSystemInformation> infoSystem = systemController.GetSystemInformation();

            int res = -1;
            int scene = infoSystem.GetScene();
            if (scene == StgSystemInformation.SCENE_PACKAGE_CONTROL)
            {
                res = (int)AnonymousEnum.STAGE_STATE_FINISHED;
            }

            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetStageSceneResult(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            script._CheckNextStageExists();

            int res = StgStageInformation.RESULT_UNKNOWN;
            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            List<ref_count_ptr<StgStageStartData>> listStage = infoPackage.GetStageDataList();
            if (listStage.Count > 0)
            {
                ref_count_ptr<StgStageStartData> stageData = listStage[listStage.Count - 1];
                ref_count_ptr<StgStageInformation> infoStage = stageData.GetStageInformation();
                res = infoStage.GetResult();
            }

            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_PauseStageScene(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            StgSystemController systemController = packageController.GetSystemController();
            StgStageController stageController = systemController.GetStageController();
            if (stageController == null)
            {
                return new gstd.value();
            }

            bool bPause = argv[0].as_boolean();

            StgStageScriptManager stageScriptManager = stageController.GetScriptManagerP();
            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();
            if (bPause && !infoStage.IsPause())
            {
                stageScriptManager.RequestEventAll(StgStageScript.EV_PAUSE_ENTER);
            }
            else if (!bPause && infoStage.IsPause())
            {
                stageScriptManager.RequestEventAll(StgStageScript.EV_PAUSE_LEAVE);
            }

            infoStage.SetPause(bPause);

            return new gstd.value();
        }

        public static gstd.value Func_TerminateStageScene(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgPackageScript script = (StgPackageScript)machine.data;
            StgPackageController packageController = script.packageController_;
            StgSystemController systemController = packageController.GetSystemController();
            StgStageController stageController = systemController.GetStageController();
            if (stageController == null)
            {
                return new gstd.value();
            }

            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();
            infoStage.SetResult(StgStageInformation.RESULT_BREAK_OFF);
            infoStage.SetEnd();
            return new gstd.value();
        }


}