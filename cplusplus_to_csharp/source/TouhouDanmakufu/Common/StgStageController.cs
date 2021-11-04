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
// class StgStageInformation;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgStageStartData;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class PseudoSlowInformation;
/**********************************************************
//StgStageController
**********************************************************/
public class StgStageController : System.IDisposable
{
        private StgSystemController systemController_;
        private ref_count_ptr<StgSystemInformation> infoSystem_ = new ref_count_ptr<StgSystemInformation>();
        private ref_count_ptr<StgStageInformation> infoStage_ = new ref_count_ptr<StgStageInformation>();
        private ref_count_ptr<PseudoSlowInformation> infoSlow_ = new ref_count_ptr<PseudoSlowInformation>();

        private ref_count_ptr<StgPauseScene> pauseManager_ = new ref_count_ptr<StgPauseScene>();
        private ref_count_ptr<KeyReplayManager> keyReplayManager_ = new ref_count_ptr<KeyReplayManager>();
        private ref_count_ptr<StgStageScriptObjectManager> objectManagerMain_ = new ref_count_ptr<StgStageScriptObjectManager>();
        private ref_count_ptr<StgStageScriptManager> scriptManager_ = new ref_count_ptr<StgStageScriptManager>();
        private ref_count_ptr<StgEnemyManager> enemyManager_ = new ref_count_ptr<StgEnemyManager>();
        private ref_count_ptr<StgShotManager> shotManager_ = new ref_count_ptr<StgShotManager>();
        private ref_count_ptr<StgItemManager> itemManager_ = new ref_count_ptr<StgItemManager>();
        private ref_count_ptr<StgIntersectionManager> intersectionManager_ = new ref_count_ptr<StgIntersectionManager>();

        private void _SetupReplayTargetCommonDataArea(_int64 idScript)
        {
            ref_count_ptr<StgStageScript> script = new ref_count_ptr<StgStageScript>(scriptManager_.GetScript(idScript));
            if (script == null)
            {
                return;
            }

            gstd.value res = script.RequestEvent(StgStageScript.EV_REQUEST_REPLAY_TARGET_COMMON_AREA);
            if (!res.has_data())
            {
                return;
            }
            type_data.type_kind kindRes = res.get_type().get_kind();
            if (kindRes != type_data.tk_array)
            {
                return;
            }

            ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage_.GetReplayData();
            SortedSet<string> listArea = new SortedSet<string>();
            int arrayLength = (int)res.length_as_array();
            for (int iArray = 0 ; iArray < arrayLength ; iArray++)
            {
                value arrayValue = res.index_as_array((uint)iArray);
                string area = to_mbcs(arrayValue.as_string());
                listArea.Add(area);
            }

            gstd.ref_count_ptr<ScriptCommonDataManager> scriptCommonDataManager = systemController_.GetCommonDataManager();
            if (!infoStage_.IsReplay())
            {
                SortedSet<string>.Enumerator itrArea = listArea.GetEnumerator();
                while (itrArea.MoveNext())
                {
                    string area = itrArea.Current;
                    ref_count_ptr<ScriptCommonData> commonData = scriptCommonDataManager.GetData(area);
                    replayStageData.SetCommonData(area, commonData);
                }
            }
            else
            {
                SortedSet<string>.Enumerator itrArea = listArea.GetEnumerator();
                while (itrArea.MoveNext())
                {
                    string area = itrArea.Current;
                    ref_count_ptr<ScriptCommonData> commonData = replayStageData.GetCommonData(area);
                    scriptCommonDataManager.SetData(area, commonData);
                }
            }
        }


        /**********************************************************
        //StgStageController
        **********************************************************/
        public StgStageController(StgSystemController systemController)
        {
            systemController_ = systemController;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoSystem_ = systemController_->GetSystemInformation();
            infoSystem_.CopyFrom(systemController_.GetSystemInformation());
        }

        public virtual void Dispose()
        {
            intersectionManager_ = null;
            itemManager_ = null;
            shotManager_ = null;
            enemyManager_ = null;
            objectManagerMain_ = null;
            scriptManager_ = null;
        }

        public void Initialize(ref_count_ptr<StgStageStartData> startData)
        {
            // FPU������
            Math.InitializeFPU();

            // �L�[������
            EDirectInput input = EDirectInput.GetInstance();
            input.ClearKeyState();

            // 3D�J����
            DirectGraphics graphics = DirectGraphics.GetBase();
            ref_count_ptr<DxCamera> camera3D = graphics.GetCamera();
            camera3D.Reset();
            camera3D.SetProjectionMatrix(384, 448, 10, 2000);

            // 2D�J����
            gstd.ref_count_ptr<DxCamera2D> camera2D = graphics.GetCamera2D();
            camera2D.Reset();

            ref_count_ptr<StgStageInformation> infoStage = startData.GetStageInformation();
            ref_count_ptr<ReplayInformation.StageData> replayStageData = startData.GetStageReplayData();
            ref_count_ptr<StgStageInformation> prevStageData = startData.GetPrevStageInformation();
            ref_count_ptr<StgPlayerInformation> prevPlayerInfo = startData.GetPrevPlayerInformation();

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoStage_ = infoStage;
            infoStage_.CopyFrom(infoStage);
            infoStage_.SetReplay(replayStageData != null);

            // ���v���C�L�[�ݒ�
            int replayState = infoStage_.IsReplay() ? KeyReplayManager.STATE_REPLAY : KeyReplayManager.STATE_RECORD;
            keyReplayManager_ = new KeyReplayManager(EDirectInput.GetInstance());
            keyReplayManager_.SetManageState(replayState);
            keyReplayManager_.AddTarget(EDirectInput.KEY_LEFT);
            keyReplayManager_.AddTarget(EDirectInput.KEY_RIGHT);
            keyReplayManager_.AddTarget(EDirectInput.KEY_UP);
            keyReplayManager_.AddTarget(EDirectInput.KEY_DOWN);
            keyReplayManager_.AddTarget(EDirectInput.KEY_SHOT);
            keyReplayManager_.AddTarget(EDirectInput.KEY_BOMB);
            keyReplayManager_.AddTarget(EDirectInput.KEY_SLOWMOVE);
            keyReplayManager_.AddTarget(EDirectInput.KEY_USER1);
            keyReplayManager_.AddTarget(EDirectInput.KEY_USER2);
            keyReplayManager_.AddTarget(EDirectInput.KEY_OK);
            keyReplayManager_.AddTarget(EDirectInput.KEY_CANCEL);
            SortedSet<int> listReplayTargetKey = infoSystem_.GetReplayTargetKeyList();
            SortedSet<int>.Enumerator itrKey = listReplayTargetKey.GetEnumerator();
            while (itrKey.MoveNext())
            {
                int id = itrKey.Current;
                keyReplayManager_.AddTarget(id);
            }

            if (replayStageData == null)
            {
                replayStageData = new ReplayInformation.StageData();
            }
            infoStage_.SetReplayData(replayStageData);

            // �X�e�[�W�v�f
            infoSlow_ = new PseudoSlowInformation();
            ref_count_weak_ptr<PseudoSlowInformation> wPtr = infoSlow_;
            EFpsController.GetInstance().AddFpsControlObject(new ref_count_weak_ptr<PseudoSlowInformation>(wPtr));

            // �O�X�e�[�W��񔽉f
            if (prevStageData != null)
            {
                infoStage_.SetScore(prevStageData.GetScore());
                infoStage_.SetGraze(prevStageData.GetGraze());
                infoStage_.SetPoint(prevStageData.GetPoint());
            }


            // ���v���C�֘A(�X�N���v�g�������O)
            if (!infoStage_.IsReplay())
            {
                // ����
                int randSeed = infoStage_.GetMersenneTwister().GetSeed();
                replayStageData.SetRandSeed(randSeed);

                // �X�e�[�W���
                ref_count_ptr<ScriptInformation> infoParent = systemController_.GetSystemInformation().GetMainScriptInformation();
                ref_count_ptr<ScriptInformation> infoMain = infoStage_.GetMainScriptInformation();
                string pathParentScript = infoParent.GetScriptPath();
                string pathMainScript = infoMain.GetScriptPath();
                string filenameMainScript = PathProperty.GetFileName(pathMainScript);
                string pathMainScriptRelative = PathProperty.GetRelativeDirectory(pathParentScript, pathMainScript);

                replayStageData.SetMainScriptID(infoMain.GetID());
                replayStageData.SetMainScriptName(filenameMainScript);
                replayStageData.SetMainScriptRelativePath(pathMainScriptRelative);
                replayStageData.SetStartScore(infoStage_.GetScore());
                replayStageData.SetGraze(infoStage_.GetGraze());
                replayStageData.SetPoint(infoStage_.GetPoint());
            }
            else
            {
                // ����
                int randSeed = replayStageData.GetRandSeed();
                infoStage_.GetMersenneTwister().Initialize(randSeed);

                // ���v���C�L�[
                keyReplayManager_.ReadRecord(*replayStageData.GetReplayKeyRecord());

                // �X�e�[�W���
                infoStage_.SetScore(replayStageData.GetStartScore());
                infoStage_.SetGraze(replayStageData.GetGraze());
                infoStage_.SetPoint(replayStageData.GetPoint());

                // ���@�ݒ�
                prevPlayerInfo = new StgPlayerInformation();
                prevPlayerInfo.SetLife(replayStageData.GetPlayerLife());
                prevPlayerInfo.SetSpell(replayStageData.GetPlayerBombCount());
                prevPlayerInfo.SetPower(replayStageData.GetPlayerPower());
                prevPlayerInfo.SetRebirthFrame(replayStageData.GetPlayerRebirthFrame());
            }

            objectManagerMain_ = new StgStageScriptObjectManager(this);
            scriptManager_ = new StgStageScriptManager(this);
            enemyManager_ = new StgEnemyManager(this);
            shotManager_ = new StgShotManager(this);
            itemManager_ = new StgItemManager(this);
            intersectionManager_ = new StgIntersectionManager();
            pauseManager_ = new StgPauseScene(systemController_);

            // �p�b�P�[�W�X�N���v�g�̏ꍇ�́A�X�e�[�W�X�N���v�g�Ɗ֘A�t����
            StgPackageController packageController = systemController_.GetPackageController();
            if (packageController != null)
            {
                ref_count_ptr<ScriptManager> packageScriptManager = packageController.GetScriptManager();
                ref_count_ptr<ScriptManager> stageScriptManager = new ref_count_ptr<ScriptManager>(scriptManager_);
                ScriptManager.AddRelativeScriptManagerMutual(packageScriptManager, stageScriptManager);
            }

            gstd.ref_count_ptr<StgStageScriptObjectManager> objectManager = scriptManager_.GetObjectManager();

            // ���C���X�N���v�g���
            ref_count_ptr<ScriptInformation> infoMain = infoStage_.GetMainScriptInformation();
            string dirInfo = PathProperty.GetFileDirectory(infoMain.GetScriptPath());

            ELogger.WriteTop(StringUtility.Format("���C���X�N���v�g[%s]", infoMain.GetScriptPath().c_str()));

            // �V�X�e���X�N���v�g
            string pathSystemScript = infoMain.GetSystemPath();
            if (pathSystemScript == ScriptInformation.DEFAULT)
            {
                pathSystemScript = EPathProperty.GetStgDefaultScriptDirectory() + "Default_System.txt";
            }
            if (pathSystemScript.Length > 0)
            {
                pathSystemScript = EPathProperty.ExtendRelativeToFull(dirInfo, pathSystemScript);
                ELogger.WriteTop(StringUtility.Format("�V�X�e���X�N���v�g[%s]", pathSystemScript));
                _int64 idScript = scriptManager_.LoadScript(pathSystemScript, StgStageScript.TYPE_SYSTEM);
                scriptManager_.StartScript(idScript);
            }

            // ���@�X�N���v�g
            ref_count_ptr<StgPlayerObject>.unsync objPlayer = null;
            ref_count_ptr<ScriptInformation> infoPlayer = infoStage_.GetPlayerScriptInformation();
            string pathPlayerScript = infoPlayer.GetScriptPath();

            if (pathPlayerScript.Length > 0)
            {
                ELogger.WriteTop(StringUtility.Format("���@�X�N���v�g[%s]", pathPlayerScript));
                int idPlayer = objectManager.CreatePlayerObject();
                objPlayer = ref_count_ptr<StgPlayerObject>.unsync.DownCast(GetMainRenderObject(idPlayer));

                _int64 idScript = scriptManager_.LoadScript(pathPlayerScript, StgStageScript.TYPE_PLAYER);
                _SetupReplayTargetCommonDataArea(new _int64(idScript));

                ref_count_ptr<StgStagePlayerScript> script = new ref_count_ptr<StgStagePlayerScript>(scriptManager_.GetScript(idScript));
                objPlayer.SetScript(script.GetPointer());
                scriptManager_.SetPlayerScriptID(idScript);
                scriptManager_.StartScript(idScript);

                // �O�X�e�[�W��񔽉f
                if (prevPlayerInfo != null)
                {
                    objPlayer.SetPlayerInforamtion(prevPlayerInfo);
                }
            }
            if (objPlayer != null)
            {
                infoStage_.SetPlayerObjectInformation(objPlayer.GetPlayerInformation());
            }

            // ���C���X�N���v�g
            if (infoMain.GetType() == ScriptInformation.TYPE_SINGLE)
            {
                string pathMainScript = EPathProperty.GetSystemResourceDirectory() + "script/System_SingleStage.txt";
                _int64 idScript = scriptManager_.LoadScript(pathMainScript, StgStageScript.TYPE_STAGE);
                scriptManager_.StartScript(idScript);
            }
            else if (infoMain.GetType() == ScriptInformation.TYPE_PLURAL)
            {
                string pathMainScript = EPathProperty.GetSystemResourceDirectory() + "script/System_PluralStage.txt";
                _int64 idScript = scriptManager_.LoadScript(pathMainScript, StgStageScript.TYPE_STAGE);
                scriptManager_.StartScript(idScript);
            }
            else
            {
                string pathMainScript = infoMain.GetScriptPath();
                if (pathMainScript.Length > 0)
                {
                    _int64 idScript = scriptManager_.LoadScript(pathMainScript, StgStageScript.TYPE_STAGE);
                    _SetupReplayTargetCommonDataArea(new _int64(idScript));
                    scriptManager_.StartScript(idScript);
                }
            }

            // �w�i�X�N���v�g
            string pathBack = infoMain.GetBackgroundPath();
            if (pathBack == ScriptInformation.DEFAULT)
            {
                pathBack = "";
            }
            if (pathBack.Length > 0)
            {
                pathBack = EPathProperty.ExtendRelativeToFull(dirInfo, pathBack);
                ELogger.WriteTop(StringUtility.Format("�w�i�X�N���v�g[%s]", pathBack));
                _int64 idScript = scriptManager_.LoadScript(pathBack, StgStageScript.TYPE_STAGE);
                scriptManager_.StartScript(idScript);
            }

            // �����Đ�
            string pathBGM = infoMain.GetBgmPath();
            if (pathBGM == ScriptInformation.DEFAULT)
            {
                pathBGM = "";
            }
            if (pathBGM.Length > 0)
            {
                pathBGM = EPathProperty.ExtendRelativeToFull(dirInfo, pathBGM);
                ELogger.WriteTop(StringUtility.Format("BGM[%s]", pathBGM));
                ref_count_ptr<SoundPlayer> player = DirectSoundManager.GetBase().GetPlayer(pathBGM);
                if (player != null)
                {
                    player.SetSoundDivision(SoundDivision.DIVISION_BGM);
                    SoundPlayer.PlayStyle style = new SoundPlayer.PlayStyle();
                    style.SetLoopEnable(true);
                    player.Play(style);
                }
            }

            // ���v���C�֘A(�X�N���v�g��������)
            if (!infoStage_.IsReplay())
            {
                // ���@���
                ref_count_ptr<StgPlayerObject>.unsync objPlayer = GetPlayerObject();
                if (objPlayer != null)
                {
                    replayStageData.SetPlayerLife(objPlayer.GetLife());
                    replayStageData.SetPlayerBombCount(objPlayer.GetSpell());
                    replayStageData.SetPlayerPower(objPlayer.GetPower());
                    replayStageData.SetPlayerRebirthFrame(objPlayer.GetRebirthFrame());
                }
                string pathPlayerScript = infoPlayer.GetScriptPath();
                string filenamePlayerScript = PathProperty.GetFileName(pathPlayerScript);
                replayStageData.SetPlayerScriptFileName(filenamePlayerScript);
                replayStageData.SetPlayerScriptID(infoPlayer.GetID());
                replayStageData.SetPlayerScriptReplayName(infoPlayer.GetReplayName());
            }

            infoStage_.SetStageStartTime(timeGetTime());


        }

        public void CloseScene()
        {
            ref_count_weak_ptr<PseudoSlowInformation> wPtr = infoSlow_;
            EFpsController.GetInstance().RemoveFpsControlObject(new ref_count_weak_ptr<PseudoSlowInformation>(wPtr));

            // ���v���C
            if (!infoStage_.IsReplay())
            {
                // �L�[
                ref_count_ptr<RecordBuffer> recKey = new RecordBuffer();
                keyReplayManager_.WriteRecord(*recKey.GetPointer());

                ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage_.GetReplayData();
                replayStageData.SetReplayKeyRecord(recKey);

                // �ŏI�t���[��
                int stageFrame = infoStage_.GetCurrentFrame();
                replayStageData.SetEndFrame(stageFrame);

                replayStageData.SetLastScore(infoStage_.GetScore());
            }
        }

        public void Work()
        {
            EDirectInput input = EDirectInput.GetInstance();
            ref_count_ptr<StgSystemInformation> infoSystem = systemController_.GetSystemInformation();
            bool bPackageMode = infoSystem.IsPackageMode();

            bool bPermitRetryKey = !input.IsTargetKeyCode(DIK_BACK);
            if (!bPackageMode && bPermitRetryKey && input.GetKeyState(DIK_BACK) == KEY_PUSH)
            {
                // ���g���C
                if (!infoStage_.IsReplay())
                {
                    ref_count_ptr<StgSystemInformation> infoSystem = systemController_.GetSystemInformation();
                    infoSystem.SetRetry();
                    return;
                }
            }

            bool bCurrentPause = infoStage_.IsPause();
            if (bPackageMode && bCurrentPause)
            {
                // �p�b�P�[�W���[�h�Œ�~���̏ꍇ�́A�p�b�P�[�W�X�N���v�g�ŏ�������
                return;
            }

            bool bPauseKey = (input.GetVirtualKeyState(EDirectInput.KEY_PAUSE) == KEY_PUSH);
            if (bPauseKey && !bPackageMode)
            {
                // ��~�L�[����
                if (!bCurrentPause)
                {
                    pauseManager_.Start();
                }
                else
                {
                    pauseManager_.Finish();
                }
            }
            else
            {
                if (!bCurrentPause)
                {
                    // ���v���C�L�[�X�V
                    keyReplayManager_.Update();

                    // �X�N���v�g�����ŁA���@�A�G�A�e�̓��삪�s����B
                    scriptManager_.Work(StgStageScript.TYPE_SYSTEM);
                    scriptManager_.Work(StgStageScript.TYPE_STAGE);
                    scriptManager_.Work(StgStageScript.TYPE_SHOT);
                    scriptManager_.Work(StgStageScript.TYPE_ITEM);

                    ref_count_ptr<StgPlayerObject>.unsync objPlayer = GetPlayerObject();
                    if (objPlayer != null)
                    {
                        objPlayer.Move(); // ���@������Ɉړ�
                    }
                    scriptManager_.Work(StgStageScript.TYPE_PLAYER);

                    // �I�u�W�F�N�g���쏈��
                    if (infoStage_.IsEnd())
                    {
                        return;
                    }
                    objectManagerMain_.WorkObject();

                    enemyManager_.Work();
                    shotManager_.Work();
                    itemManager_.Work();

                    // �����蔻�菈��
                    enemyManager_.RegistIntersectionTarget();
                    shotManager_.RegistIntersectionTarget();
                    intersectionManager_.Work();

                    if (!infoStage_.IsReplay())
                    {
                        // ���v���C�p���X�V
                        int stageFrame = infoStage_.GetCurrentFrame();
                        if (stageFrame % 60 == 0)
                        {
                            ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage_.GetReplayData();
                            float framePerSecond = EFpsController.GetInstance().GetCurrentFps();
                            replayStageData.AddFramePerSecond(framePerSecond);
                        }
                    }

                    infoStage_.AdvanceFrame();

                }
                else
                {
                    // ��~��
                    pauseManager_.Work();
                }
            }

            ELogger logger = ELogger.GetInstance();
            if (logger.IsWindowVisible())
            {
                // ���O�֘A
                logger.SetInfo(6, "stg shot_count", StringUtility.Format("%d", shotManager_.GetShotCountAll()));
                logger.SetInfo(7, "stg enemy_count", StringUtility.Format("%d", enemyManager_.GetEnemyCount()));
                logger.SetInfo(8, "stg item_count", StringUtility.Format("%d", itemManager_.GetItemCount()));
            }
        }

        public void Render()
        {
            bool bPause = infoStage_.IsPause();
            if (!bPause)
            {
                objectManagerMain_.RenderObject();

                if (infoStage_.IsReplay())
                {
                    // ���v���C��
                }
            }
            else
            {
                // ��~
                pauseManager_.Render();
            }
        }

        public void RenderToTransitionTexture()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            TextureManager textureManager = ETextureManager.GetInstance();
            ref_count_ptr<Texture> texture = textureManager.GetTexture(TextureManager.TARGET_TRANSITION);

            ref_count_ptr<StgStageScriptObjectManager> objectManager = GetMainObjectManager();
            graphics.SetRenderTarget(texture);
            graphics.BeginScene(true);

            // objectManager->RenderObject();
            systemController_.RenderScriptObject();

            graphics.EndScene();
            graphics.SetRenderTarget(null);
        }

        public ref_count_ptr<StgStageScriptObjectManager> GetMainObjectManager()
        {
            return new ref_count_ptr<StgStageScriptObjectManager>(objectManagerMain_);
        }
        public StgStageScriptManager GetScriptManagerP()
        {
            return scriptManager_.GetPointer();
        }
        public ref_count_ptr<StgStageScriptManager> GetScriptManagerR()
        {
            return new ref_count_ptr<StgStageScriptManager>(scriptManager_);
        }
        public StgEnemyManager GetEnemyManager()
        {
            return enemyManager_.GetPointer();
        }
        public StgShotManager GetShotManager()
        {
            return shotManager_.GetPointer();
        }
        public StgItemManager GetItemManager()
        {
            return itemManager_.GetPointer();
        }
        public StgIntersectionManager GetIntersectionManager()
        {
            return intersectionManager_.GetPointer();
        }
        public ref_count_ptr<StgPauseScene> GetPauseManager()
        {
            return new ref_count_ptr<StgPauseScene>(pauseManager_);
        }

        public ref_count_ptr<DxScriptObjectBase>.unsync GetMainRenderObject(int idObject)
        {
            return objectManagerMain_.GetObject(idObject);
        }

        public ref_count_ptr<StgPlayerObject>.unsync GetPlayerObject()
        {
            int idPlayer = objectManagerMain_.GetPlayerObjectID();
            if (idPlayer == DxScript.ID_INVALID)
            {
                return null;
            }
            return ref_count_ptr<StgPlayerObject>.unsync.DownCast(GetMainRenderObject(idPlayer));
        }

        public StgSystemController GetSystemController()
        {
            return systemController_;
        }
        public ref_count_ptr<StgSystemInformation> GetSystemInformation()
        {
            return new ref_count_ptr<StgSystemInformation>(infoSystem_);
        }
        public ref_count_ptr<StgStageInformation> GetStageInformation()
        {
            return new ref_count_ptr<StgStageInformation>(infoStage_);
        }
        public ref_count_ptr<KeyReplayManager> GetKeyReplayManager()
        {
            return new ref_count_ptr<KeyReplayManager>(keyReplayManager_);
        }

        public ref_count_ptr<PseudoSlowInformation> GetSlowInformation()
        {
            return new ref_count_ptr<PseudoSlowInformation>(infoSlow_);
        }
}


/**********************************************************
//StgStageInformation
**********************************************************/
public class StgStageInformation : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            RESULT_UNKNOWN,
            RESULT_BREAK_OFF,
            RESULT_PLAYER_DOWN,
            RESULT_CLEARED
        }

        private bool bEndStg_;
        private bool bPause_;
        private bool bReplay_; // ���v���C
        private int frame_;
        private int stageIndex_;

        private ref_count_ptr<ScriptInformation> infoMainScript_ = new ref_count_ptr<ScriptInformation>();
        private ref_count_ptr<ScriptInformation> infoPlayerScript_ = new ref_count_ptr<ScriptInformation>();
        private ref_count_ptr<StgPlayerInformation> infoPlayerObject_ = new ref_count_ptr<StgPlayerInformation>();
        private ref_count_ptr<ReplayInformation.StageData> replayStageData_ = new ref_count_ptr<ReplayInformation.StageData>();

        // STG�ݒ�
        private RECT rcStgFrame_ = new RECT();
        private int priMinStgFrame_;
        private int priMaxStgFrame_;
        private int priShotObject_;
        private int priItemObject_;
        private int priCameraFocusPermit_;
        private RECT rcShotAutoDeleteClip_ = new RECT();

        // STG���
        private ref_count_ptr<MersenneTwister> rand_ = new ref_count_ptr<MersenneTwister>();
        private _int64 score_ = new _int64();
        private _int64 graze_ = new _int64();
        private _int64 point_ = new _int64();
        private int result_;
        private int timeStart_;


        /**********************************************************
        //StgStageInformation
        **********************************************************/
        public StgStageInformation()
        {
            bEndStg_ = false;
            bPause_ = false;
            bReplay_ = false;
            frame_ = 0;
            stageIndex_ = 0;

            SetRect(rcStgFrame_, 32, 16, 32 + 384, 16 + 448);
            SetStgFrameRect(new RECT(rcStgFrame_));
            priMinStgFrame_ = 20;
            priMaxStgFrame_ = 80;
            priShotObject_ = 50;
            priItemObject_ = 60;
            priCameraFocusPermit_ = 69;
            SetRect(rcShotAutoDeleteClip_, -64, -64, 64, 64);

            rand_ = new MersenneTwister();
            rand_.Initialize(timeGetTime());
            score_ = 0;
            graze_ = 0;
            point_ = 0;
            result_ = (int)AnonymousEnum.RESULT_UNKNOWN;

            timeStart_ = 0;
        }

        public virtual void Dispose()
        {
        }

        public bool IsEnd()
        {
            return bEndStg_;
        }
        public void SetEnd()
        {
            bEndStg_ = true;
        }
        public bool IsPause()
        {
            return bPause_;
        }
        public void SetPause(bool bPause)
        {
            bPause_ = bPause;
        }
        public bool IsReplay()
        {
            return bReplay_;
        }
        public void SetReplay(bool bReplay)
        {
            bReplay_ = bReplay;
        }
        public int GetCurrentFrame()
        {
            return frame_;
        }
        public void AdvanceFrame()
        {
            frame_++;
        }
        public int GetStageIndex()
        {
            return stageIndex_;
        }
        public void SetStageIndex(int index)
        {
            stageIndex_ = index;
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
        public ref_count_ptr<ScriptInformation> GetPlayerScriptInformation()
        {
            return new ref_count_ptr<ScriptInformation>(infoPlayerScript_);
        }
        public void SetPlayerScriptInformation(ref_count_ptr<ScriptInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoPlayerScript_ = info;
            infoPlayerScript_.CopyFrom(info);
        }
        public ref_count_ptr<StgPlayerInformation> GetPlayerObjectInformation()
        {
            return new ref_count_ptr<StgPlayerInformation>(infoPlayerObject_);
        }
        public void SetPlayerObjectInformation(ref_count_ptr<StgPlayerInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoPlayerObject_ = info;
            infoPlayerObject_.CopyFrom(info);
        }
        public ref_count_ptr<ReplayInformation.StageData> GetReplayData()
        {
            return new ref_count_ptr<ReplayInformation.StageData>(replayStageData_);
        }
        public void SetReplayData(ref_count_ptr<ReplayInformation.StageData> data)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: replayStageData_ = data;
            replayStageData_.CopyFrom(data);
        }

        public RECT GetStgFrameRect()
        {
            return new RECT(rcStgFrame_);
        }
        public void SetStgFrameRect(RECT rect, bool bUpdateFocusResetValue = true)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcStgFrame_ = rect;
            rcStgFrame_.CopyFrom(rect);
            gstd.ref_count_ptr<D3DXVECTOR2> pos = new D3DXVECTOR2();
            pos.x = (rect.right - rect.left) / 2;
            pos.y = (rect.bottom - rect.top) / 2;

            if (bUpdateFocusResetValue)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                gstd.ref_count_ptr<DxCamera2D> camera2D = graphics.GetCamera2D();
                camera2D.SetResetFocus(pos);
                camera2D.Reset();
            }
        }

        public int GetStgFrameMinPriority()
        {
            return priMinStgFrame_;
        }
        public void SetStgFrameMinPriority(int pri)
        {
            priMinStgFrame_ = pri;
        }
        public int GetStgFrameMaxPriority()
        {
            return priMaxStgFrame_;
        }
        public void SetStgFrameMaxPriority(int pri)
        {
            priMaxStgFrame_ = pri;
        }
        public int GetShotObjectPriority()
        {
            return priShotObject_;
        }
        public void SetShotObjectPriority(int pri)
        {
            priShotObject_ = pri;
        }
        public int GetItemObjectPriority()
        {
            return priItemObject_;
        }
        public void SetItemObjectPriority(int pri)
        {
            priItemObject_ = pri;
        }
        public int GetCameraFocusPermitPriority()
        {
            return priCameraFocusPermit_;
        }
        public void SetCameraFocusPermitPriority(int pri)
        {
            priCameraFocusPermit_ = pri;
        }
        public RECT GetShotAutoDeleteClip()
        {
            return new RECT(rcShotAutoDeleteClip_);
        }
        public void SetShotAutoDeleteClip(RECT rect)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: rcShotAutoDeleteClip_ = rect;
            rcShotAutoDeleteClip_.CopyFrom(rect);
        }

        public ref_count_ptr<MersenneTwister> GetMersenneTwister()
        {
            return new ref_count_ptr<MersenneTwister>(rand_);
        }
        public void SetMersenneTwisterSeed(int seed)
        {
            rand_.Initialize(seed);
        }
        public _int64 GetScore()
        {
            return new _int64(score_);
        }
        public void SetScore(_int64 score)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: score_ = score;
            score_.CopyFrom(score);
        }
        public void AddScore(_int64 inc)
        {
            score_ += inc;
        }
        public _int64 GetGraze()
        {
            return new _int64(graze_);
        }
        public void SetGraze(_int64 graze)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: graze_ = graze;
            graze_.CopyFrom(graze);
        }
        public void AddGraze(_int64 inc)
        {
            graze_ += inc;
        }
        public _int64 GetPoint()
        {
            return new _int64(point_);
        }
        public void SetPoint(_int64 point)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: point_ = point;
            point_.CopyFrom(point);
        }
        public void AddPoint(_int64 inc)
        {
            point_ += inc;
        }

        public int GetResult()
        {
            return result_;
        }
        public void SetResult(int result)
        {
            result_ = result;
        }

        public int GetStageStartTime()
        {
            return timeStart_;
        }
        public void SetStageStartTime(int time)
        {
            timeStart_ = time;
        }
}

/**********************************************************
//StgStageStartData
**********************************************************/
public class StgStageStartData : System.IDisposable
{
        private ref_count_ptr<StgStageInformation> infoStage_ = new ref_count_ptr<StgStageInformation>();
        private ref_count_ptr<ReplayInformation.StageData> replayStageData_ = new ref_count_ptr<ReplayInformation.StageData>();
        private ref_count_ptr<StgStageInformation> prevStageInfo_ = new ref_count_ptr<StgStageInformation>();
        private ref_count_ptr<StgPlayerInformation> prevPlayerInfo_ = new ref_count_ptr<StgPlayerInformation>();

        public StgStageStartData()
        {
        }
        public virtual void Dispose()
        {
        }

        public ref_count_ptr<StgStageInformation> GetStageInformation()
        {
            return new ref_count_ptr<StgStageInformation>(infoStage_);
        }
        public void SetStageInformation(ref_count_ptr<StgStageInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoStage_ = info;
            infoStage_.CopyFrom(info);
        }
        public ref_count_ptr<ReplayInformation.StageData> GetStageReplayData()
        {
            return new ref_count_ptr<ReplayInformation.StageData>(replayStageData_);
        }
        public void SetStageReplayData(ref_count_ptr<ReplayInformation.StageData> data)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: replayStageData_ = data;
            replayStageData_.CopyFrom(data);
        }
        public ref_count_ptr<StgStageInformation> GetPrevStageInformation()
        {
            return new ref_count_ptr<StgStageInformation>(prevStageInfo_);
        }
        public void SetPrevStageInformation(ref_count_ptr<StgStageInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: prevStageInfo_ = info;
            prevStageInfo_.CopyFrom(info);
        }
        public ref_count_ptr<StgPlayerInformation> GetPrevPlayerInformation()
        {
            return new ref_count_ptr<StgPlayerInformation>(prevPlayerInfo_);
        }
        public void SetPrevPlayerInformation(ref_count_ptr<StgPlayerInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: prevPlayerInfo_ = info;
            prevPlayerInfo_.CopyFrom(info);
        }

}

/**********************************************************
//PseudoSlowInformation
**********************************************************/
public class PseudoSlowInformation : gstd.FpsControlObject
{
        public class SlowData
        {
                private int fps_;
                public SlowData()
                {
                    fps_ = GlobalMembers.STANDARD_FPS;
                }
                public virtual void Dispose()
                {
                }
                public int GetFps()
                {
                    return fps_;
                }
                public void SetFps(int fps)
                {
                    fps_ = fps;
                }
        }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            OWNER_PLAYER = 0,
            OWNER_ENEMY,
            TARGET_ALL
        }

        private int current_;
        private SortedDictionary<int, gstd.ref_count_ptr<SlowData>> mapDataPlayer_ = new SortedDictionary<int, gstd.ref_count_ptr<SlowData>>();
        private SortedDictionary<int, gstd.ref_count_ptr<SlowData>> mapDataEnemy_ = new SortedDictionary<int, gstd.ref_count_ptr<SlowData>>();
        private SortedDictionary<int, bool> mapValid_ = new SortedDictionary<int, bool>();

        public PseudoSlowInformation()
        {
            current_ = 0;
        }
        public override void Dispose()
        {
            base.Dispose();
        }

        /**********************************************************
        //PseudoSlowInformation
        **********************************************************/
        public override int GetFps()
        {
            int fps = GlobalMembers.STANDARD_FPS;
            int target = (int)AnonymousEnum2.TARGET_ALL;
            if (mapDataPlayer_.ContainsKey(target))
            {
                ref_count_ptr<SlowData> data = mapDataPlayer_[target];
                fps = System.Math.Min(fps, data.GetFps());
            }
            if (mapDataEnemy_.ContainsKey(target))
            {
                ref_count_ptr<SlowData> data = mapDataEnemy_[target];
                fps = System.Math.Min(fps, data.GetFps());
            }
            return fps;
        }

        public bool IsValidFrame(int target)
        {
            bool res = !mapValid_.ContainsKey(target) || mapValid_[target];
            return res;
        }

        public void Next()
        {
            int fps = GlobalMembers.STANDARD_FPS;
            int target = (int)AnonymousEnum2.TARGET_ALL;
            if (mapDataPlayer_.ContainsKey(target))
            {
                ref_count_ptr<SlowData> data = mapDataPlayer_[target];
                fps = System.Math.Min(fps, data.GetFps());
            }
            if (mapDataEnemy_.ContainsKey(target))
            {
                ref_count_ptr<SlowData> data = mapDataEnemy_[target];
                fps = System.Math.Min(fps, data.GetFps());
            }

            bool bValid = false;
            if (fps == GlobalMembers.STANDARD_FPS)
            {
                bValid = true;
            }
            else
            {
                current_ += fps;
                if (current_ >= GlobalMembers.STANDARD_FPS)
                {
                    current_ %= GlobalMembers.STANDARD_FPS;
                    bValid = true;
                }
            }

            mapValid_[target] = bValid;
        }

        public void AddSlow(int fps, int owner, int target)
        {
            fps = System.Math.Max(1, fps);
            fps = System.Math.Min(GlobalMembers.STANDARD_FPS, fps);
            ref_count_ptr<SlowData> data = new SlowData();
            data.SetFps(fps);
            switch (owner)
            {
                case AnonymousEnum2.OWNER_PLAYER:
                    mapDataPlayer_[target] = data;
                    break;
                case AnonymousEnum2.OWNER_ENEMY:
                    mapDataEnemy_[target] = data;
                    break;
            }
        }

        public void RemoveSlow(int owner, int target)
        {
            switch (owner)
            {
                case AnonymousEnum2.OWNER_PLAYER:
                    mapDataPlayer_.Remove(target);
                    break;
                case AnonymousEnum2.OWNER_ENEMY:
                    mapDataEnemy_.Remove(target);
                    break;
            }
        }
}

