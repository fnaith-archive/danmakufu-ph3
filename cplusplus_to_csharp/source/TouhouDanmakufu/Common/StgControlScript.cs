using System;
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

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgControlScript;
/**********************************************************
//StgControlScriptManager
**********************************************************/
public abstract class StgControlScriptManager : ScriptManager
{


        /**********************************************************
        //StgControlScriptManager
        **********************************************************/
        public StgControlScriptManager()
        {

        }

        public override void Dispose()
        {

            base.Dispose();
        }
}

/**********************************************************
//StgControlScriptInformation
**********************************************************/
public class StgControlScriptInformation : System.IDisposable
{
        private List<ref_count_ptr<ScriptInformation>> listFreePlayer_ = new List<ref_count_ptr<ScriptInformation>>(); // �W�����@
        private ref_count_ptr<ReplayInformationManager> replayManager_ = new ref_count_ptr<ReplayInformationManager>(); // ���v���C���


        /**********************************************************
        //StgControlScriptInformation
        **********************************************************/
        public StgControlScriptInformation()
        {
            replayManager_ = new ReplayInformationManager();
        }

        public virtual void Dispose()
        {
        }

        public void LoadFreePlayerList()
        {
            string dir = EPathProperty.GetPlayerScriptRootDirectory();
            listFreePlayer_ = new List<ref_count_ptr<ScriptInformation>>(ScriptInformation.FindPlayerScriptInformationList(dir));

            // �\�[�g
// C++ TO C# CONVERTER TODO TASK: The 'Compare' parameter of std::sort produces a boolean value, while the .NET Comparison parameter produces a tri-state result:
// ORIGINAL LINE: std::sort(listFreePlayer_.begin(), listFreePlayer_.end(), ScriptInformation::PlayerListSort());
            listFreePlayer_.Sort(new ScriptInformation.PlayerListSort());
        }

        public List<ref_count_ptr<ScriptInformation>> GetFreePlayerList()
        {
            return new List<ref_count_ptr<ScriptInformation>>(listFreePlayer_);
        }

        public void LoadReplayInformation(string pathMainScript)
        {
            replayManager_.UpdateInformationList(pathMainScript);
        }

        public ref_count_ptr<ReplayInformationManager> GetReplayInformationManager()
        {
            return new ref_count_ptr<ReplayInformationManager>(replayManager_);
        }
}

/**********************************************************
//StgControlScript
**********************************************************/
public class StgControlScript : DnhScript
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//    friend StgControlScriptManager;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            // �C�x���g
            EV_USER_COUNT = 100000,
            EV_USER = 1000000,
            EV_USER_SYSTEM = 2000000,
            EV_USER_STAGE = 3000000,
            EV_USER_PLAYER = 4000000,
            EV_USER_PACKAGE = 5000000,

            TYPE_SCRIPT_ALL = -1,
            TYPE_SCRIPT_PLAYER = ScriptInformation.TYPE_PLAYER,
            TYPE_SCRIPT_SINGLE = ScriptInformation.TYPE_SINGLE,
            TYPE_SCRIPT_PLURAL = ScriptInformation.TYPE_PLURAL,
            TYPE_SCRIPT_STAGE = ScriptInformation.TYPE_STAGE,
            TYPE_SCRIPT_PACKAGE = ScriptInformation.TYPE_PACKAGE,

            INFO_SCRIPT_TYPE,
            INFO_SCRIPT_PATH,
            INFO_SCRIPT_ID,
            INFO_SCRIPT_TITLE,
            INFO_SCRIPT_TEXT,
            INFO_SCRIPT_IMAGE,
            INFO_SCRIPT_REPLAY_NAME,

            REPLAY_FILE_PATH,
            REPLAY_DATE_TIME,
            REPLAY_USER_NAME,
            REPLAY_TOTAL_SCORE,
            REPLAY_FPS_AVERAGE,
            REPLAY_PLAYER_NAME,
            REPLAY_STAGE_INDEX_LIST,
            REPLAY_STAGE_START_SCORE_LIST,
            REPLAY_STAGE_LAST_SCORE_LIST,
            REPLAY_COMMENT,

            RESULT_CANCEL,
            RESULT_END,
            RESULT_RETRY,
            RESULT_SAVE_REPLAY
        }
        protected StgSystemController systemController_;

        // �X�N���v�g���̃L���b�V��
        protected SortedDictionary<string, ref_count_ptr<ScriptInformation>> mapScriptInfo_ = new SortedDictionary<string, ref_count_ptr<ScriptInformation>>();

        public StgControlScript(StgSystemController systemController)
        {
            systemController_ = systemController;
            scriptManager_ = null;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgControlFunction, sizeof(stgControlFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgControlFunction, GlobalMembers.stgControlFunction.Length);

            bLoad_ = false;
            bEndScript_ = false;
            bAutoDeleteObject_ = false;

            SetScriptEngineCache(systemController.GetScriptEngineCache());
            commonDataManager_.CopyFrom(systemController.GetCommonDataManager());
        }

        // STG���䋤�ʊ֐��F���ʃf�[�^

        // STG���䋤�ʊ֐��F���ʃf�[�^
        public new static gstd.value Func_SaveCommonDataAreaA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            string area = argv[0].as_string();
            string sArea = to_mbcs(area);
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
            ref_count_ptr<ScriptCommonData> commonData = commonDataManager.GetData(sArea);
            if (commonData == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            string pathMain = infoSystem.GetMainScriptInformation().GetScriptPath();
            string pathSave = EPathProperty.GetCommonDataPath(pathMain, area);
            string dirSave = PathProperty.GetFileDirectory(pathSave);

            File fDir = new File(dirSave);
            fDir.CreateDirectory();

            RecordBuffer record = new RecordBuffer();
            commonData.WriteRecord(record);
            bool res = record.WriteToFile(pathSave);

            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public new static gstd.value Func_LoadCommonDataAreaA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            string area = argv[0].as_string();
            string sArea = to_mbcs(area);
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string pathMain = infoSystem.GetMainScriptInformation().GetScriptPath();
            string pathSave = EPathProperty.GetCommonDataPath(pathMain, area);
            RecordBuffer record = new RecordBuffer();
            bool res = record.ReadFromFile(pathSave);
            if (!res)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            ref_count_ptr<ScriptCommonData> commonData = new ScriptCommonData();
            commonData.ReadRecord(record);
            commonDataManager.SetData(sArea, commonData);

            return new value(machine.get_engine().get_boolean_type(), true);
        }

        public static gstd.value Func_SaveCommonDataAreaA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            string area = to_mbcs(argv[0].as_string());
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
            ref_count_ptr<ScriptCommonData> commonData = commonDataManager.GetData(area);
            if (commonData == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            string pathSave = argv[1].as_string();
            string dirSave = PathProperty.GetFileDirectory(pathSave);

            File fDir = new File(dirSave);
            fDir.CreateDirectory();

            RecordBuffer record = new RecordBuffer();
            commonData.WriteRecord(record);
            bool res = record.WriteToFile(pathSave);

            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_LoadCommonDataAreaA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            string area = to_mbcs(argv[0].as_string());
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string pathSave = argv[1].as_string();
            RecordBuffer record = new RecordBuffer();
            bool res = record.ReadFromFile(pathSave);
            if (!res)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            ref_count_ptr<ScriptCommonData> commonData = new ScriptCommonData();
            commonData.ReadRecord(record);
            commonDataManager.SetData(area, commonData);

            return new value(machine.get_engine().get_boolean_type(), true);
        }

        // STG���䋤�ʊ֐��F�L�[�n

        // STG���䋤�ʊ֐��F�L�[�n
        public static gstd.value Func_AddVirtualKey(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            EDirectInput input = EDirectInput.GetInstance();
            int padIndex = input.GetPadIndex();

            int id = (int)argv[0].as_real();
            int key = (int)argv[1].as_real();
            int padButton = (int)argv[2].as_real();

            ref_count_ptr<VirtualKey> vkey = new VirtualKey(key, padIndex, padButton);
            input.AddKeyMap(id, new ref_count_ptr<VirtualKey>(vkey));

            return new value();
        }

        public static gstd.value Func_AddReplayTargetVirtualKey(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();
            StgStageController stageController = script.systemController_.GetStageController();

            int id = (int)argv[0].as_real();
            infoSystem.AddReplayTargetKey(id);
            if (stageController != null)
            {
                ref_count_ptr<KeyReplayManager> keyReplayManager = stageController.GetKeyReplayManager();
                keyReplayManager.AddTarget(id);
            }

            return new value();
        }

        public static gstd.value Func_SetSkipModeKey(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            int id = (int)argv[0].as_real();
            EFpsController fpsController = EFpsController.GetInstance();
            fpsController.SetFastModeKey(id);

            return new value();
        }

        // STG���䋤�ʊ֐��F�V�X�e���֘A

        // STG���䋤�ʊ֐��F�V�X�e���֘A
        public static gstd.value Func_GetScore(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0.0);
            }

            double res = stageController.GetStageInformation().GetScore();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_AddScore(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value();
            }

            double inc = (_int64)argv[0].as_real();
            stageController.GetStageInformation().AddScore(inc);
            return new value();
        }

        public static gstd.value Func_GetGraze(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0.0);
            }

            double res = stageController.GetStageInformation().GetGraze();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_AddGraze(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value();
            }

            double inc = (_int64)argv[0].as_real();
            stageController.GetStageInformation().AddGraze(inc);
            return new value();
        }

        public static gstd.value Func_GetPoint(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0.0);
            }

            double res = stageController.GetStageInformation().GetPoint();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_AddPoint(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value();
            }

            double inc = (_int64)argv[0].as_real();
            stageController.GetStageInformation().AddPoint(inc);
            return new value();
        }

        public static gstd.value Func_IsReplay(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            bool res = stageController.GetStageInformation().IsReplay();
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_AddArchiveFile(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            FileManager fileManager = FileManager.GetBase();

            string path = argv[0].as_string();
            bool res = fileManager.AddArchiveFile(path);
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_GetCurrentFps(gstd.script_machine machine, int argc, gstd.value argv)
        {
            EFpsController fpsController = EFpsController.GetInstance();
            double res = fpsController.GetCurrentWorkFps();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStageTime(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0);
            }

            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();
            int time = timeGetTime();

            int timeStart = infoStage.GetStageStartTime();
            double res = timeStart > 0 ? time - timeStart : 0;
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStageTimeF(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0);
            }

            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();
            double res = infoStage.GetCurrentFrame();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetPackageTime(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgPackageController packageController = script.systemController_.GetPackageController();
            if (packageController == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0);
            }

            ref_count_ptr<StgPackageInformation> infoPackage = packageController.GetPackageInformation();
            int time = timeGetTime();

            int timeStart = infoPackage.GetPackageStartTime();
            double res = timeStart > 0 ? time - timeStart : 0;
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStgFrameLeft(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();

            double res = 0;
            if (stageController != null)
            {
                RECT rect = stageController.GetStageInformation().GetStgFrameRect();
                res = rect.left;
            }
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStgFrameTop(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();

            double res = 0;
            if (stageController != null)
            {
                RECT rect = stageController.GetStageInformation().GetStgFrameRect();
                res = rect.top;
            }
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStgFrameWidth(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();

            double res = 0;
            if (stageController != null)
            {
                RECT rect = stageController.GetStageInformation().GetStgFrameRect();
                res = res = rect.right - rect.left;
            }
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStgFrameHeight(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();

            double res = 0;
            if (stageController != null)
            {
                RECT rect = stageController.GetStageInformation().GetStgFrameRect();
                res = res = rect.bottom - rect.top;
            }
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetMainPackageScriptPath(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgPackageController packageController = script.systemController_.GetPackageController();

            string path = "";
            if (packageController != null)
            {
                ref_count_ptr<ScriptInformation> infoScript = packageController.GetPackageInformation().GetMainScriptInformation();
                path = infoScript.GetScriptPath();
            }

            string res = path;
            return new value(machine.get_engine().get_string_type(), res);
        }

        public static gstd.value Func_GetScriptPathList(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;

            List<string> listRes = new List<string>();
            string dir = argv[0].as_string();
            dir = PathProperty.GetFileDirectory(dir);

            int typeScript = (int)argv[1].as_real();
            List<string> listFile = File.GetFilePathList(dir);
            for (int iFile = 0 ; iFile < listFile.Count ; iFile++)
            {
                string path = listFile[iFile];

                // ���炩�Ɋ֌W�Ȃ������Ȋg���q�͏��O
                string ext = PathProperty.GetFileExtension(path);
                if (ScriptInformation.IsExcludeExtention(ext))
                {
                    continue;
                }

                path = PathProperty.GetUnique(path);
                ref_count_ptr<ScriptInformation> infoScript = ScriptInformation.CreateScriptInformation(path, true);
                if (infoScript == null)
                {
                    continue;
                }
                if (typeScript != (int)AnonymousEnum.TYPE_SCRIPT_ALL && typeScript != infoScript.GetType())
                {
                    continue;
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: script->mapScriptInfo_[path] = infoScript;
                script.mapScriptInfo_[path].CopyFrom(infoScript);
                listRes.Add(path);
            }

            gstd.value res = script.CreateStringArrayValue(listRes);
            return new gstd.value(res);
        }

        public static gstd.value Func_GetScriptInfoA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;

            string path = argv[0].as_string();
            int type = (int)argv[1].as_real();

            ref_count_ptr<ScriptInformation> infoScript = null;
            if (script.mapScriptInfo_.ContainsKey(path))
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoScript = script->mapScriptInfo_[path];
                infoScript.CopyFrom(script.mapScriptInfo_[path]);
            }
            else
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoScript = ScriptInformation::CreateScriptInformation(path, true);
                infoScript.CopyFrom(ScriptInformation.CreateScriptInformation(path, true));
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: script->mapScriptInfo_[path] = infoScript;
                script.mapScriptInfo_[path].CopyFrom(infoScript);
            }
            if (infoScript == null)
            {
                throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path));
            }

            value res = new value();
            switch (type)
            {
                case AnonymousEnum.INFO_SCRIPT_TYPE:
                    res = script.CreateRealValue(infoScript.GetType());
                    break;
                case AnonymousEnum.INFO_SCRIPT_PATH:
                    res = script.CreateStringValue(infoScript.GetScriptPath());
                    break;
                case AnonymousEnum.INFO_SCRIPT_ID:
                    res = script.CreateStringValue(infoScript.GetID());
                    break;
                case AnonymousEnum.INFO_SCRIPT_TITLE:
                    res = script.CreateStringValue(infoScript.GetTitle());
                    break;
                case AnonymousEnum.INFO_SCRIPT_TEXT:
                    res = script.CreateStringValue(infoScript.GetText());
                    break;
                case AnonymousEnum.INFO_SCRIPT_IMAGE:
                    res = script.CreateStringValue(infoScript.GetImagePath());
                    break;
                case AnonymousEnum.INFO_SCRIPT_REPLAY_NAME:
                    res = script.CreateStringValue(infoScript.GetReplayName());
                    break;
            }

            return new value(res);
        }


        // STG���䋤�ʊ֐��F�`��֘A

        // STG���ʊ֐��F�`��֘A
        public static gstd.value Func_ClearInvalidRenderPriority(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgSystemController systemController = script.systemController_;
            ref_count_ptr<StgSystemInformation> infoSystem = systemController.GetSystemInformation();
            infoSystem.SetInvaridRenderPriority(-1, -1);

            return new value();
        }

        public static gstd.value Func_SetInvalidRenderPriorityA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgSystemController systemController = script.systemController_;
            ref_count_ptr<StgSystemInformation> infoSystem = systemController.GetSystemInformation();

            int priMin = (int)argv[0].as_real();
            int priMax = (int)argv[1].as_real();
            infoSystem.SetInvaridRenderPriority(priMin, priMax);

            return new value();
        }

        public static gstd.value Func_GetReservedRenderTargetName(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;

            int index = (int)argv[0].as_real();
            ETextureManager textureManager = ETextureManager.GetInstance();
            string name = textureManager.GetReservedRenderTargetName(index);

            return new value(machine.get_engine().get_string_type(), name);
        }

        public static gstd.value Func_RenderToTextureA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ETextureManager textureManager = ETextureManager.GetInstance();
            StgSystemController systemController = script.systemController_;

            string name = argv[0].as_string();
            int priMin = (int)argv[1].as_real();
            int priMax = (int)argv[2].as_real();
            bool bClear = argv[3].as_boolean();

            DirectGraphics graphics = DirectGraphics.GetBase();
            ref_count_ptr<Texture> texture = script._GetTexture(name);
            if (texture == null)
            {
                textureManager.GetTexture(name);
            }
            if (texture == null && textureManager.IsDataExists(name))
            {
                texture = new Texture();
                texture.CreateRenderTarget(name);
            }

            graphics.SetRenderTarget(texture);
            graphics.BeginScene(bClear);

            systemController.RenderScriptObject(priMin, priMax);

            graphics.EndScene();
            graphics.SetRenderTarget(null);
        /*
        	{
        		static int count = 0;
        		std::string path = StringUtility::Format("R:/TEMP/temp_%04d.bmp", count);
        		RECT rect = {0, 0, 640, 480};
        		IDirect3DSurface9* pBackSurface = texture->GetD3DSurface();
        		D3DXSaveSurfaceToFile(path.c_str(), D3DXIFF_BMP,
        								pBackSurface, NULL, &rect );
        		count++;
        	}
        */
            return new value();
        }

        public static gstd.value Func_RenderToTextureB1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ETextureManager textureManager = ETextureManager.GetInstance();

            string name = argv[0].as_string();
            int id = (int)argv[1].as_real();
            bool bClear = argv[2].as_boolean();

            DxScriptRenderObject obj = script.GetObjectPointer(id) as DxScriptRenderObject;
            if (obj == null)
            {
                return new value();
            }

            DirectGraphics graphics = DirectGraphics.GetBase();
            ref_count_ptr<Texture> texture = script._GetTexture(name);
            if (texture == null)
            {
                textureManager.GetTexture(name);
            }

            if (texture == null && textureManager.IsDataExists(name))
            {
                texture = new Texture();
                texture.CreateRenderTarget(name);
            }

            graphics.SetRenderTarget(texture);
            graphics.BeginScene(bClear);

            obj.Render();

            graphics.EndScene();
            graphics.SetRenderTarget(null);

            return new value();
        }

        public static gstd.value Func_SaveSnapShotA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ETextureManager textureManager = ETextureManager.GetInstance();
            StgSystemController systemController = script.systemController_;

            string path = argv[0].as_string();
            DirectGraphics graphics = DirectGraphics.GetBase();
            ref_count_ptr<Texture> texture = textureManager.GetTexture(TextureManager.TARGET_TRANSITION);

            graphics.SetRenderTarget(texture);
            graphics.BeginScene(true);
            systemController.RenderScriptObject(0, 100);
            graphics.EndScene();
            graphics.SetRenderTarget(null);

            // �t�H���_����
            string dir = PathProperty.GetFileDirectory(path);
            File fDir = new File(dir);
            fDir.CreateDirectory();

            // �ۑ�
            IDirect3DSurface9 pSurface = texture.GetD3DSurface();
            RECT rect = new RECT(0, 0, graphics.GetScreenWidth(), graphics.GetScreenHeight());
            int hr = D3DXSaveSurfaceToFile(path, D3DXIFF_BMP, pSurface, null, rect);

            return new value();
        }

        public static gstd.value Func_SaveSnapShotA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ETextureManager textureManager = ETextureManager.GetInstance();
            StgSystemController systemController = script.systemController_;

            string path = argv[0].as_string();
            int rcLeft = (int)argv[1].as_real();
            int rcTop = (int)argv[2].as_real();
            int rcRight = (int)argv[3].as_real();
            int rcBottom = (int)argv[4].as_real();

            DirectGraphics graphics = DirectGraphics.GetBase();
            ref_count_ptr<Texture> texture = textureManager.GetTexture(TextureManager.TARGET_TRANSITION);

            graphics.SetRenderTarget(texture);
            graphics.BeginScene(true);
            systemController.RenderScriptObject(0, 100);
            graphics.EndScene();
            graphics.SetRenderTarget(null);

            // �t�H���_����
            string dir = PathProperty.GetFileDirectory(path);
            File fDir = new File(dir);
            fDir.CreateDirectory();

            // �ۑ�
            IDirect3DSurface9 pSurface = texture.GetD3DSurface();
            RECT rect = new RECT(rcLeft, rcTop, rcRight, rcBottom);
            int hr = D3DXSaveSurfaceToFile(path, D3DXIFF_BMP, pSurface, null, rect);
            return new value();
        }

        // STG���䋤�ʊ֐��F���@�֘A

        // STG���䋤�ʊ֐��F���@�֘A
        public static gstd.value Func_GetPlayerID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_string_type(), new string());
            }

            string id = stageController.GetStageInformation().GetPlayerScriptInformation().GetID();
            return new value(machine.get_engine().get_string_type(), id);
        }

        public static gstd.value Func_GetPlayerReplayName(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            StgStageController stageController = script.systemController_.GetStageController();
            if (stageController == null)
            {
                return new value(machine.get_engine().get_string_type(), new string());
            }

            string replayName = stageController.GetStageInformation().GetPlayerScriptInformation().GetReplayName();
            return new value(machine.get_engine().get_string_type(), replayName);
        }

        // STG���䋤�ʊ֐��F���[�U�X�N���v�g

        // STG���䋤�ʊ֐��F���[�U�X�N���v�g
        public static gstd.value Func_SetPauseScriptPath(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> info = script.systemController_.GetSystemInformation();

            string path = argv[0].as_string();
            info.SetPauseScriptPath(path);

            return new value();
        }

        public static gstd.value Func_SetEndSceneScriptPath(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> info = script.systemController_.GetSystemInformation();

            string path = argv[0].as_string();
            info.SetEndSceneScriptPath(path);

            return new value();
        }

        public static gstd.value Func_SetReplaySaveSceneScriptPath(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> info = script.systemController_.GetSystemInformation();

            string path = argv[0].as_string();
            info.SetReplaySaveSceneScriptPath(path);

            return new value();
        }

        // STG���䋤�ʊ֐��F���@�X�N���v�g

        // STG���䋤�ʊ֐��F���@�X�N���v�g
        public static gstd.value Func_GetLoadFreePlayerScriptList(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();

            infoControlScript.LoadFreePlayerList();
            List<ref_count_ptr<ScriptInformation>> listFreePlayer = infoControlScript.GetFreePlayerList();
            int res = listFreePlayer.Count;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetFreePlayerScriptCount(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            List<ref_count_ptr<ScriptInformation>> listFreePlayer = infoControlScript.GetFreePlayerList();

            int res = listFreePlayer.Count;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetFreePlayerScriptInfo(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            List<ref_count_ptr<ScriptInformation>> listFreePlayer = infoControlScript.GetFreePlayerList();

            int index = (int)argv[0].as_real();
            int type = (int)argv[1].as_real();
            if (index < 0 || index >= listFreePlayer.Count)
            {
                script.RaiseError(ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_OUTOFRANGE_INDEX));
            }

            ref_count_ptr<ScriptInformation> infoPlayer = listFreePlayer[index];
            value res = new value();
            switch (type)
            {
                case AnonymousEnum.INFO_SCRIPT_PATH:
                    res = script.CreateStringValue(infoPlayer.GetScriptPath());
                    break;
                case AnonymousEnum.INFO_SCRIPT_ID:
                    res = script.CreateStringValue(infoPlayer.GetID());
                    break;
                case AnonymousEnum.INFO_SCRIPT_TITLE:
                    res = script.CreateStringValue(infoPlayer.GetTitle());
                    break;
                case AnonymousEnum.INFO_SCRIPT_TEXT:
                    res = script.CreateStringValue(infoPlayer.GetText());
                    break;
                case AnonymousEnum.INFO_SCRIPT_IMAGE:
                    res = script.CreateStringValue(infoPlayer.GetImagePath());
                    break;
                case AnonymousEnum.INFO_SCRIPT_REPLAY_NAME:
                    res = script.CreateStringValue(infoPlayer.GetReplayName());
                    break;
            }

            return new value(res);
        }

        // STG���䋤�ʊ֐��F���v���C�֘A

        // STG���䋤�ʊ֐��F���v���C�֘A
        public static gstd.value Func_LoadReplayList(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            string pathMainScript = infoSystem.GetMainScriptInformation().GetScriptPath();
            infoControlScript.LoadReplayInformation(pathMainScript);
            return new gstd.value();
        }

        public static gstd.value Func_GetValidReplayIndices(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();

            List<int> listValidIndices = replayInfoManager.GetIndexList();
            List<double> list = new List<double>();
            for (int iList = 0 ; iList < listValidIndices.Count; iList++)
            {
                list.Add(listValidIndices[iList]);
            }

            gstd.value res = script.CreateRealArrayValue(list);
            return new gstd.value(res);
        }

        public static gstd.value Func_IsValidReplayIndex(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();

            int index = (int)argv[0].as_real();
            bool res = replayInfoManager.GetInformation(index) != null;
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_GetReplayInfo(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            int index = (int)argv[0].as_real();
            int type = (int)argv[1].as_real();

            ref_count_ptr<ReplayInformation> replayInfo = new ref_count_ptr<ReplayInformation>();
            if (index == ReplayInformation.INDEX_ACTIVE)
            {
                replayInfo = infoSystem.GetActiveReplayInformation();
            }
            else
            {
                replayInfo = replayInfoManager.GetInformation(index);
            }

            if (replayInfo == null)
            {
                script.RaiseError(ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_OUTOFRANGE_INDEX));
            }

            value res = new value();
            switch (type)
            {
                case AnonymousEnum.REPLAY_FILE_PATH:
                    res = script.CreateStringValue(replayInfo.GetPath());
                    break;
                case AnonymousEnum.REPLAY_DATE_TIME:
                    res = script.CreateStringValue(replayInfo.GetDateAsString());
                    break;
                case AnonymousEnum.REPLAY_USER_NAME:
                    res = script.CreateStringValue(replayInfo.GetUserName());
                    break;
                case AnonymousEnum.REPLAY_TOTAL_SCORE:
                    res = script.CreateRealValue(replayInfo.GetTotalScore());
                    break;
                case AnonymousEnum.REPLAY_FPS_AVERAGE:
                    res = script.CreateRealValue(replayInfo.GetAvarageFps());
                    break;
                case AnonymousEnum.REPLAY_PLAYER_NAME:
                    res = script.CreateStringValue(replayInfo.GetPlayerScriptReplayName());
                    break;
                case AnonymousEnum.REPLAY_STAGE_INDEX_LIST:
                {
                    List<int> listStageI = replayInfo.GetStageIndexList();
                    List<double> listStageD = new List<double>();
                    for (int iStage = 0 ; iStage < listStageI.Count ; iStage++)
                    {
                        double stage = listStageI[iStage];
                        listStageD.Add(stage);
                    }
                    res = script.CreateRealArrayValue(listStageD);
                    break;
                }
                case AnonymousEnum.REPLAY_STAGE_START_SCORE_LIST:
                {
                    List<int> listStage = replayInfo.GetStageIndexList();
                    List<double> listScoreD = new List<double>();
                    for (int iStage = 0 ; iStage < listStage.Count ; iStage++)
                    {
                        int stage = listStage[iStage];
                        ref_count_ptr<ReplayInformation.StageData> data = replayInfo.GetStageData(stage);

                        double score = data.GetStartScore();
                        listScoreD.Add(score);
                    }
                    res = script.CreateRealArrayValue(listScoreD);
                    break;
                }
                case AnonymousEnum.REPLAY_STAGE_LAST_SCORE_LIST:
                {
                    List<int> listStage = replayInfo.GetStageIndexList();
                    List<double> listScoreD = new List<double>();
                    for (int iStage = 0 ; iStage < listStage.Count ; iStage++)
                    {
                        int stage = listStage[iStage];
                        ref_count_ptr<ReplayInformation.StageData> data = replayInfo.GetStageData(stage);

                        double score = data.GetLastScore();
                        listScoreD.Add(score);
                    }
                    res = script.CreateRealArrayValue(listScoreD);
                    break;
                }
                case AnonymousEnum.REPLAY_COMMENT:
                    res = script.CreateStringValue(replayInfo.GetComment());
                    break;
            }

            return new value(res);
        }

        public static gstd.value Func_SetReplayInfo(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();
            ref_count_ptr<ReplayInformation> replayInfo = infoSystem.GetActiveReplayInformation();
            if (replayInfo == null)
            {
                script.RaiseError("save target replay not found");
            }

            int type = (int)argv[0].as_real();

            switch (type)
            {
                case AnonymousEnum.REPLAY_COMMENT:
                    replayInfo.SetComment(argv[1].as_string());
                    break;
            }
            return new value();
        }

        public static gstd.value Func_GetReplayUserData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            int index = (int)argv[0].as_real();
            string key = to_mbcs(argv[1].as_string());

            ref_count_ptr<ReplayInformation> replayInfo = new ref_count_ptr<ReplayInformation>();
            if (index == ReplayInformation.INDEX_ACTIVE)
            {
                replayInfo = infoSystem.GetActiveReplayInformation();
            }
            else
            {
                replayInfo = replayInfoManager.GetInformation(index);
            }

            if (replayInfo == null)
            {
                script.RaiseError(ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_OUTOFRANGE_INDEX));
            }

            gstd.value res = replayInfo.GetUserData(key);
            return new gstd.value(res);
        }

        public static gstd.value Func_SetReplayUserData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();
            ref_count_ptr<ReplayInformation> replayInfo = infoSystem.GetActiveReplayInformation();
            if (replayInfo == null)
            {
                script.RaiseError("save target replay not found");
            }

            string key = to_mbcs(argv[0].as_string());
            gstd.value val = argv[1];
            replayInfo.SetUserData(key, val);
            return new value();
        }

        public static gstd.value Func_IsReplayUserDataExists(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgControlScriptInformation> infoControlScript = script.systemController_.GetControlScriptInformation();
            ref_count_ptr<ReplayInformationManager> replayInfoManager = infoControlScript.GetReplayInformationManager();
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();

            int index = (int)argv[0].as_real();
            string key = to_mbcs(argv[1].as_string());

            ref_count_ptr<ReplayInformation> replayInfo = new ref_count_ptr<ReplayInformation>();
            if (index == ReplayInformation.INDEX_ACTIVE)
            {
                replayInfo = infoSystem.GetActiveReplayInformation();
            }
            else
            {
                replayInfo = replayInfoManager.GetInformation(index);
            }

            if (replayInfo == null)
            {
                script.RaiseError(ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_OUTOFRANGE_INDEX));
            }

            bool res = replayInfo.IsUserDataExists(key);
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_SaveReplay(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgControlScript script = (StgControlScript)machine.data;
            ref_count_ptr<StgSystemInformation> infoSystem = script.systemController_.GetSystemInformation();
            ref_count_ptr<ScriptInformation> infoMain = script.systemController_.GetSystemInformation().GetMainScriptInformation();

            ref_count_ptr<ReplayInformation> replayInfoActive = infoSystem.GetActiveReplayInformation();
            if (replayInfoActive == null)
            {
                script.RaiseError("replay information not found");
            }

            int index = (int)argv[0].as_real();
            if (index <= 0)
            {
                script.RaiseError("replay index error");
            }

            string userName = argv[1].as_string();
            replayInfoActive.SetUserName(userName);

            replayInfoActive.SaveToFile(infoMain.GetScriptPath(), index);
            bool res = true;
            return new value(machine.get_engine().get_boolean_type(), res);
        }
}


/**********************************************************
//ScriptInfoPanel
**********************************************************/
public class ScriptInfoPanel : WindowLogger.Panel
{
        protected WButton buttonTerminateScript_ = new WButton();
        protected virtual bool _AddedLogger(IntPtr hTab)
        {
            Create(hTab);
            buttonTerminateScript_.Create(hWnd_);
            buttonTerminateScript_.SetText("Terminate(�����I��)");

            LocateParts();
            return true;
        }

        protected virtual int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_COMMAND:
                {
                    int id = wParam & 0xffff;
                    if (id == buttonTerminateScript_.GetWindowId())
                    {
                        _TerminateScriptAll();
                        return false;
                    }
                }
                break;
            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }

        protected void _TerminateScriptAll()
        {
            ETaskManager taskManager = ETaskManager.GetInstance();
            LinkedList<ref_count_ptr<TaskBase>> listTask = taskManager.GetTaskList();
            LinkedList<ref_count_ptr<TaskBase>>.Enumerator itr = listTask.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgSystemController> systemController = ref_count_ptr<StgSystemController>.DownCastitr.Current;
                if (systemController != null)
                {
                    systemController.TerminateScriptAll();
                }
            }
        }


        /**********************************************************
        //ScriptInfoPanel
        **********************************************************/
        public ScriptInfoPanel()
        {
        }

        public virtual void LocateParts()
        {
            int wx = GetClientX();
            int wy = GetClientY();
            int wWidth = GetClientWidth();
            int wHeight = GetClientHeight();

            buttonTerminateScript_.SetBounds(wx + 16, wy + 16, 160, 32);
        }
}