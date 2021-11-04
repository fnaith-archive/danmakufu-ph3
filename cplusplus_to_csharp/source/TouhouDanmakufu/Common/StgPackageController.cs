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
// class StgPackageInformation;
/**********************************************************
//StgPackageController
**********************************************************/
public class StgPackageController : System.IDisposable
{
        private StgSystemController systemController_;
        private ref_count_ptr<StgPackageInformation> infoPackage_ = new ref_count_ptr<StgPackageInformation>();
        private ref_count_ptr<StgPackageScriptManager> scriptManager_ = new ref_count_ptr<StgPackageScriptManager>();


        /**********************************************************
        //StgPackageController
        **********************************************************/
        public StgPackageController(StgSystemController systemController)
        {
            systemController_ = systemController;

        }

        public virtual void Dispose()
        {
        }

        public void Initialize()
        {
            infoPackage_ = new StgPackageInformation();
            scriptManager_ = new StgPackageScriptManager(systemController_);

            ref_count_ptr<StgSystemInformation> infoSystem = systemController_.GetSystemInformation();
            ref_count_ptr<ScriptInformation> infoScript = infoSystem.GetMainScriptInformation();
            infoPackage_.SetMainScriptInformation(infoScript);

            // ���C���X�N���v�g
            string pathMainScript = infoScript.GetScriptPath();
            ELogger.WriteTop(StringUtility.Format("�p�b�P�[�W�X�N���v�g[%s]", pathMainScript));
            _int64 idScript = scriptManager_.LoadScript(pathMainScript, StgPackageScript.TYPE_PACKAGE_MAIN);
            scriptManager_.StartScript(idScript);

            infoPackage_.SetPackageStartTime(timeGetTime());
        }

        public void Work()
        {
            scriptManager_.Work();
            // �X�N���v�g������ꂽ�ꍇ�͍ēx���s(�`��̌p���ڂ�ڗ����Ȃ�����)
            if (scriptManager_.IsHasCloseScliptWork())
            {
                scriptManager_.Work();
            }
        }

        public void Render()
        {
            // scriptManager_->Render();
        }

        public void RenderToTransitionTexture()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            TextureManager textureManager = ETextureManager.GetInstance();
            ref_count_ptr<Texture> texture = textureManager.GetTexture(TextureManager.TARGET_TRANSITION);

            graphics.SetRenderTarget(texture);
            graphics.BeginScene(true);

            scriptManager_.Render();

            graphics.EndScene();
            graphics.SetRenderTarget(null);
        }

        public StgSystemController GetSystemController()
        {
            return systemController_;
        }
        public ref_count_ptr<StgPackageInformation> GetPackageInformation()
        {
            return new ref_count_ptr<StgPackageInformation>(infoPackage_);
        }

        public ref_count_ptr<StgPackageScriptManager> GetScriptManager()
        {
            return new ref_count_ptr<StgPackageScriptManager>(scriptManager_);
        }
        public ref_count_ptr<DxScriptObjectManager> GetMainObjectManager()
        {
            return scriptManager_.GetObjectManager();
        }
}

/**********************************************************
//StgPackageInformation
**********************************************************/
public class StgPackageInformation : System.IDisposable
{
        private bool bEndPackage_;
        private ref_count_ptr<StgStageStartData> nextStageStartData_ = new ref_count_ptr<StgStageStartData>();
        private ref_count_ptr<ReplayInformation> infoReplay_ = new ref_count_ptr<ReplayInformation>();
        private List<ref_count_ptr<StgStageStartData>> listStageData_ = new List<ref_count_ptr<StgStageStartData>>();
        private ref_count_ptr<ScriptInformation> infoMainScript_ = new ref_count_ptr<ScriptInformation>();
        private int timeStart_;


        /**********************************************************
        //StgPackageInformation
        **********************************************************/
        public StgPackageInformation()
        {
            bEndPackage_ = false;
            timeStart_ = 0;
        }

        public virtual void Dispose()
        {
        }

        public bool IsEnd()
        {
            return bEndPackage_;
        }
        public void SetEnd()
        {
            bEndPackage_ = true;
        }

        public void InitializeStageData()
        {
            infoReplay_ = null;
            listStageData_.Clear();

            nextStageStartData_ = new StgStageStartData();
            ref_count_ptr<StgStageInformation> infoStage = new StgStageInformation();
            nextStageStartData_.SetStageInformation(infoStage);
        }

        public void FinishCurrentStage()
        {
            ref_count_ptr<StgStageStartData> currentStageStartData = new ref_count_ptr<StgStageStartData>(nextStageStartData_);
            ref_count_ptr<StgStageInformation> currentStageInfo = currentStageStartData.GetStageInformation();
            listStageData_.Add(currentStageStartData);

            nextStageStartData_ = new StgStageStartData();
            ref_count_ptr<StgStageInformation> nextStageInfo = new StgStageInformation();
            nextStageStartData_.SetStageInformation(nextStageInfo);

            nextStageStartData_.SetPrevStageInformation(currentStageInfo);

            ref_count_ptr<StgPlayerInformation> infoPlayer = currentStageInfo.GetPlayerObjectInformation();
            nextStageStartData_.SetPrevPlayerInformation(infoPlayer);

        }

        public ref_count_ptr<StgStageStartData> GetNextStageData()
        {
            return new ref_count_ptr<StgStageStartData>(nextStageStartData_);
        }
        public void SetNextStageData(ref_count_ptr<StgStageStartData> data)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: nextStageStartData_ = data;
            nextStageStartData_.CopyFrom(data);
        }
        public List<ref_count_ptr<StgStageStartData>> GetStageDataList()
        {
            return new List<ref_count_ptr<StgStageStartData>>(listStageData_);
        }

        public ref_count_ptr<ReplayInformation> GetReplayInformation()
        {
            return new ref_count_ptr<ReplayInformation>(infoReplay_);
        }
        public void SetReplayInformation(ref_count_ptr<ReplayInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoReplay_ = info;
            infoReplay_.CopyFrom(info);
        }

        public ref_count_ptr<ScriptInformation> GetMainScriptInformation()
        {
            return new ref_count_ptr<ScriptInformation>(infoMainScript_);
        }
        public void SetMainScriptInformation(ref_count_ptr<ScriptInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoMainScript_ = info;
            infoMainScript_.CopyFrom(info);
        }

        public int GetPackageStartTime()
        {
            return timeStart_;
        }
        public void SetPackageStartTime(int time)
        {
            timeStart_ = time;
        }
}
