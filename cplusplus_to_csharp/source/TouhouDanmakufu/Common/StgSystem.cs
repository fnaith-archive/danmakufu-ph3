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
// class StgSystemInformation;
/**********************************************************
//StgSystemController
**********************************************************/
public abstract class StgSystemController : TaskBase
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TASK_PRI_WORK = 4,
            TASK_PRI_RENDER = 4
        }

        protected ref_count_ptr<StgSystemInformation> infoSystem_ = new ref_count_ptr<StgSystemInformation>();
        protected ref_count_ptr<ScriptEngineCache> scriptEngineCache_ = new ref_count_ptr<ScriptEngineCache>();
        protected gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager_ = new gstd.ref_count_ptr<ScriptCommonDataManager>();

        protected ref_count_ptr<StgEndScene> endScene_ = new ref_count_ptr<StgEndScene>();
        protected ref_count_ptr<StgReplaySaveScene> replaySaveScene_ = new ref_count_ptr<StgReplaySaveScene>();

        protected ref_count_ptr<StgStageController> stageController_ = new ref_count_ptr<StgStageController>();

        protected ref_count_ptr<StgPackageController> packageController_ = new ref_count_ptr<StgPackageController>();
        protected ref_count_ptr<StgControlScriptInformation> infoControlScript_ = new ref_count_ptr<StgControlScriptInformation>();

        protected abstract void DoEnd();
        protected abstract void DoRetry();
        protected void _ControlScene()
        {
            if (infoSystem_.IsPackageMode())
            {
                packageController_.Work();

                ref_count_ptr<StgPackageInformation> infoPackage = packageController_.GetPackageInformation();
                if (infoPackage.IsEnd())
                {
                    infoSystem_.SetStgEnd();
                }
            }

            int scene = infoSystem_.GetScene();
            switch (scene)
            {
            case StgSystemInformation.AnonymousEnum2.SCENE_STG:
            {
                ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
                if (!infoStage.IsEnd())
                {
                    stageController_.Work();
                }

                if (infoStage.IsEnd())
                {
                    // ���X�e�[�W��
                    stageController_.CloseScene();
                    if (infoSystem_.IsPackageMode())
                    {
                        stageController_.RenderToTransitionTexture();
                        if (infoStage.GetResult() == StgStageInformation.RESULT_UNKNOWN)
                        {
                            int sceneResult = StgStageInformation.RESULT_CLEARED;
                            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController_.GetPlayerObject();
                            if (objPlayer != null)
                            {
                                int statePlayer = objPlayer.GetState();
                                if (statePlayer == StgPlayerObject.STATE_END)
                                {
                                    sceneResult = StgStageInformation.RESULT_PLAYER_DOWN;
                                }
                            }
                            infoStage.SetResult(sceneResult);
                        }
                        infoSystem_.SetScene(StgSystemInformation.AnonymousEnum2.SCENE_PACKAGE_CONTROL);

                        ref_count_ptr<StgPackageInformation> infoPackage = packageController_.GetPackageInformation();
                        infoPackage.FinishCurrentStage();
                    }
                    else
                    {
                        TransStgEndScene();
                    }
                }
                break;
            }
            case StgSystemInformation.AnonymousEnum2.SCENE_END:
                endScene_.Work();
                break;
            case StgSystemInformation.AnonymousEnum2.SCENE_REPLAY_SAVE:
                replaySaveScene_.Work();
                break;
            }

            if (infoSystem_.IsPackageMode())
            {
                // �V�[���ω����ɂ͑����Ƀp�b�P�[�W�Ǘ��@�\����s����
                // �p�b�P�[�W�X�N���v�g��ŋN������V�[���J�ڂ̕`��Ȃǂ��ǂ����Ȃ��Ȃ邽��
                if (scene != infoSystem_.GetScene())
                {
                    packageController_.Work();
                }
            }

            ELogger logger = ELogger.GetInstance();
            if (logger.IsWindowVisible())
            {
                // ���O�֘A
                int taskCount = 0;
                int objectCount = 0;
                if (packageController_ != null)
                {
                    ref_count_ptr<StgControlScriptManager> scriptManager = packageController_.GetScriptManager();
                    if (scriptManager != null)
                    {
                        taskCount = scriptManager.GetAllScriptThreadCount();
                    }

                    ref_count_ptr<DxScriptObjectManager> objectManager = packageController_.GetMainObjectManager();
                    if (objectManager != null)
                    {
                        objectCount += objectManager.GetAliveObjectCount();
                    }
                }
                if (stageController_ != null)
                {
                    ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
                    if (!infoStage.IsEnd())
                    {
                        StgControlScriptManager scriptManager = stageController_.GetScriptManagerP();
                        if (scriptManager != null)
                        {
                            taskCount = scriptManager.GetAllScriptThreadCount();
                        }

                        ref_count_ptr<DxScriptObjectManager> objectManager = stageController_.GetMainObjectManager();
                        if (objectManager != null)
                        {
                            objectCount += objectManager.GetAliveObjectCount();
                        }
                    }
                }
                logger.SetInfo(4, "script_task_count", StringUtility.Format("%d", taskCount));
                logger.SetInfo(5, "object_count", StringUtility.Format("%d", objectCount));
            }
        }


        /**********************************************************
        //StgSystemController
        **********************************************************/
        public StgSystemController()
        {
        }

        public new void Dispose()
        {

            base.Dispose();
        }

        public void Initialize(ref_count_ptr<StgSystemInformation> infoSystem)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoSystem_ = infoSystem;
            infoSystem_.CopyFrom(infoSystem);
            commonDataManager_ = new ScriptCommonDataManager();
            scriptEngineCache_ = new ScriptEngineCache();
            infoControlScript_ = new StgControlScriptInformation();
        }

        public void Start(ref_count_ptr<ScriptInformation> infoPlayer, ref_count_ptr<ReplayInformation> infoReplay)
        {
            // DirectX
            DirectGraphics graphics = DirectGraphics.GetBase();
            gstd.ref_count_ptr<DxCamera> camera3D = graphics.GetCamera();
            gstd.ref_count_ptr<DxCamera2D> camera2D = graphics.GetCamera2D();

            camera3D.SetProjectionMatrix(384, 448, 10, 2000);
            camera2D.Reset();

            // �L���b�V����N���A
            scriptEngineCache_.Clear();

            // �L�[�ݒ�
            EDirectInput input = EDirectInput.GetInstance();
            input.ResetVirtualKeyMap();

            ref_count_ptr<ScriptInformation> infoMain = infoSystem_.GetMainScriptInformation();

            // �A�[�J�C�u
            EFileManager fileManager = EFileManager.GetInstance();
            string archiveMain = infoMain.GetArchivePath();
            if (archiveMain.Length > 0)
            {
                fileManager.AddArchiveFile(archiveMain);
            }

            if (infoPlayer != null)
            {
                string archivePlayer = infoPlayer.GetArchivePath();
                if (archivePlayer.Length > 0)
                {
                    fileManager.AddArchiveFile(archivePlayer);
                }
            }

            if (infoSystem_.IsPackageMode())
            {
                infoSystem_.SetScene(StgSystemInformation.AnonymousEnum2.SCENE_PACKAGE_CONTROL);
                packageController_ = new StgPackageController(this);
                packageController_.Initialize();
            }
            else
            {
                ref_count_ptr<ReplayInformation.StageData> replayStageData = null;
                if (infoReplay != null)
                {
                    replayStageData = infoReplay.GetStageData(0);
                }
                ref_count_ptr<StgStageInformation> infoStage = new StgStageInformation();
                infoStage.SetMainScriptInformation(infoMain);
                infoStage.SetPlayerScriptInformation(infoPlayer);
                StartStgScene(new ref_count_ptr<StgStageInformation>(infoStage), new ref_count_ptr<ReplayInformation.StageData>(replayStageData));
            }
        }

        public void Work()
        {
            try
            {
                _ControlScene();

                ELogger logger = ELogger.GetInstance();
                logger.UpdateCommonDataInfoPanel(new gstd.ref_count_ptr<ScriptCommonDataManager>(commonDataManager_));
            }
            catch (gstd.wexception e)
            {
                Logger.WriteTop(e.what());
                infoSystem_.SetError(e.what());
            }

            EDirectInput input = EDirectInput.GetInstance();
            if (infoSystem_.IsRetry())
            {
                infoSystem_.SetError("Retry");

                DirectSoundManager soundManager = DirectSoundManager.GetBase();
                soundManager.Clear();

                ShaderManager shaderManager = ShaderManager.GetBase();
                shaderManager.Clear();

                if (infoSystem_.IsPackageMode())
                {
                    ref_count_ptr<StgStageStartData> oldStageStartData = new ref_count_ptr<StgStageStartData>();
                    ref_count_ptr<StgPackageInformation> infoPackage = packageController_.GetPackageInformation();
                    List<ref_count_ptr<StgStageStartData>> listStageData = infoPackage.GetStageDataList();
                    if (listStageData.Count > 0)
                    {
                        oldStageStartData = *listStageData.GetEnumerator();
                    }
                    else
                    {
                        oldStageStartData = infoPackage.GetNextStageData();
                    }
                    ref_count_ptr<StgStageInformation> oldStageInformation = oldStageStartData.GetStageInformation();

                    ref_count_ptr<StgStageStartData> newStageStartData = new StgStageStartData();
                    ref_count_ptr<StgStageInformation> newStageInformaiton = new StgStageInformation();
                    newStageInformaiton.SetMainScriptInformation(oldStageInformation.GetMainScriptInformation());
                    newStageInformaiton.SetPlayerScriptInformation(oldStageInformation.GetPlayerScriptInformation());
                    newStageInformaiton.SetStageIndex(oldStageInformation.GetStageIndex());
                    newStageStartData.SetStageInformation(newStageInformaiton);
                    infoPackage.SetNextStageData(newStageStartData);
                    infoSystem_.ResetRetry();

                    StartStgScene(new ref_count_ptr<StgStageStartData>(newStageStartData));
                }
                else
                {
                    DoRetry();
                }
                return;
            }

            if (infoSystem_.IsError() || infoSystem_.IsStgEnd())
            {
                EFileManager fileManager = EFileManager.GetInstance();
                fileManager.ResetArchiveFile();

                // �I��
                bool bRetry = false;
                if (infoSystem_.IsError())
                {
                    string error = infoSystem_.GetErrorMessage();
                    if (error.Length > 0)
                    {
                        ErrorDialog.ShowErrorDialog(error);
                    }
                    else
                    {
                        // ���g���C
                        bRetry = true;
                    }
                }

                if (!bRetry)
                {
                    DirectSoundManager soundManager = DirectSoundManager.GetBase();
                    soundManager.Clear();
                }

                ELogger logger = ELogger.GetInstance();
                logger.UpdateCommonDataInfoPanel(null);

                EFpsController fpsController = EFpsController.GetInstance();
                fpsController.SetFastModeKey(DIK_LCONTROL);

                DoEnd();
                return;
            }
        }

        public void Render()
        {
            if (infoSystem_.IsError())
            {
                return;
            }

            try
            {
                int scene = infoSystem_.GetScene();
                switch (scene)
                {
                    case StgSystemInformation.AnonymousEnum2.SCENE_STG:
                    case StgSystemInformation.AnonymousEnum2.SCENE_PACKAGE_CONTROL:
                    {
                        RenderScriptObject();
                        break;
                    }
                    case StgSystemInformation.AnonymousEnum2.SCENE_END:
                    {
                        if (endScene_ != null)
                        {
                            endScene_.Render();
                        }
                        break;
                    }
                    case StgSystemInformation.AnonymousEnum2.SCENE_REPLAY_SAVE:
                    {
                        if (replaySaveScene_ != null)
                        {
                            replaySaveScene_.Render();
                        }
                        break;
                    }
                }
            }
            catch (gstd.wexception e)
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                gstd.ref_count_ptr<DxCamera2D> camera2D = graphics.GetCamera2D();
                camera2D.SetEnable(false);
                camera2D.Reset();
                Logger.WriteTop(e.what());
                infoSystem_.SetError(e.what());
            }
        }

        public void RenderScriptObject()
        {
            int scene = infoSystem_.GetScene();
            bool bPackageMode = infoSystem_.IsPackageMode();
            bool bPause = false;
            if (scene == (int)StgSystemInformation.AnonymousEnum2.SCENE_STG)
            {
                ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
                bPause = infoStage.IsPause();
            }

            if (bPause && !bPackageMode)
            {
                // ��~
                stageController_.GetPauseManager().Render();
            }
            else
            {
                bool bReplay = false;
                int countRender = 0;
                if (scene == (int)StgSystemInformation.AnonymousEnum2.SCENE_STG && stageController_ != null)
                {
                    ref_count_ptr<StgStageScriptObjectManager> objectManagerStage = stageController_.GetMainObjectManager();
                    countRender = System.Math.Max(objectManagerStage.GetRenderBucketCapacity(), countRender);

                    ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
                    bReplay = infoStage.IsReplay();
                }

                if (infoSystem_.IsPackageMode())
                {
                    ref_count_ptr<DxScriptObjectManager> objectManagerPackage = packageController_.GetMainObjectManager();
                    countRender = System.Math.Max(objectManagerPackage.GetRenderBucketCapacity(), countRender);
                }

                int invalidPriMin = infoSystem_.GetInvaridRenderPriorityMin();
                int invalidPriMax = infoSystem_.GetInvaridRenderPriorityMax();
                if (invalidPriMin < 0 && invalidPriMax < 0)
                {
                    RenderScriptObject(0, countRender);
                }
                else
                {
                    RenderScriptObject(0, invalidPriMin - 1);
                    RenderScriptObject(invalidPriMax + 1, countRender);
                }


                if (bReplay)
                {
                    // ���v���C��
        /*
        			ref_count_ptr<StgStageInformation> infoStage = stageController_->GetStageInformation();
        			ref_count_ptr<ReplayInformation::StageData> replayStageData = infoStage->GetReplayData();
        			DirectGraphics* graphics = DirectGraphics::GetBase();
        			graphics->SetBlendMode(DirectGraphics::MODE_BLEND_ALPHA);
        			graphics->SetZBufferEnable(false);
        			graphics->SetZWriteEnalbe(false);
        			graphics->SetFogEnable(false);
        
        			RECT rest = infoStage->GetStgFrameRect();
        			int frame = infoStage->GetCurrentFrame();
        			int fps = replayStageData->GetFramePerSecond(frame);
        			std::string strFps = StringUtility::Format("%02d", fps);
        			DxText dxText;
        			dxText.SetFontColorTop(D3DCOLOR_ARGB(255,128,128,255));
        			dxText.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
        			dxText.SetFontBorderType(directx::DxFont::BORDER_FULL);
        			dxText.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
        			dxText.SetFontBorderWidth(1);
        			dxText.SetFontSize(12);
        			dxText.SetFontBold(true);
        			dxText.SetText(strFps);
        			dxText.SetPosition(rest.right - 18, rest.bottom - 14);
        			dxText.Render();
        */
                }
            }

        }

        public void RenderScriptObject(int priMin, int priMax)
        {
            ref_count_ptr<StgStageScriptObjectManager> objectManagerStage = null;
            ref_count_ptr<DxScriptObjectManager> objectManagerPackage = null;
            List<LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >> pRenderListStage = null;
            List<LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >> pRenderListPackage = null;


            int scene = infoSystem_.GetScene();
            bool bPause = false;
            if (scene == (int)StgSystemInformation.AnonymousEnum2.SCENE_STG)
            {
                ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
                bPause = infoStage.IsPause();
            }

            // �ȉ��̏ꍇ�ɃX�e�[�W�`��L���Ƃ���
            // �E�p�b�P�[�W���[�h�łȂ�(�ꎞ��~��X�e�[�W�������ŏ������邽��)
            // �E�p�b�P�[�W�X�N���v�g�̏ꍇ�́A�ꎞ��~��p�b�P�[�W�X�N���v�g�ŏ������邽��
            // �@�ꎞ��~����STG�V�[���͕`��ΏۊO�Ƃ���
            bool bValidStage = (scene == (int)StgSystemInformation.AnonymousEnum2.SCENE_STG || !infoSystem_.IsPackageMode()) && stageController_ != null && !bPause;
            if (bValidStage)
            {
                objectManagerStage = stageController_.GetMainObjectManager();
                objectManagerStage.PrepareRenderObject();
                pRenderListStage = objectManagerStage.GetRenderObjectListPointer();
            }

            if (infoSystem_.IsPackageMode())
            {
                objectManagerPackage = packageController_.GetMainObjectManager();
                objectManagerPackage.PrepareRenderObject();
                pRenderListPackage = objectManagerPackage.GetRenderObjectListPointer();
            }



            // --------------------------------

            DirectGraphics graphics = DirectGraphics.GetBase();
            gstd.ref_count_ptr<DxCamera> camera3D = graphics.GetCamera();
            gstd.ref_count_ptr<DxCamera2D> camera2D = graphics.GetCamera2D();
            double focusRatioX = camera2D.GetRatioX();
            double focusRatioY = camera2D.GetRatioY();
            double focusAngleZ = camera2D.GetAngleZ();
            D3DXVECTOR2 orgFocusPos = camera2D.GetFocusPosition();
            D3DXVECTOR2 focusPos = new D3DXVECTOR2(orgFocusPos);

            ref_count_ptr<StgStageInformation> stageInfo = null;
            if (bValidStage)
            {
                stageInfo = stageController_.GetStageInformation();
                RECT rcStgFrame = stageInfo.GetStgFrameRect();

                // pause��ɁA�t�H�[�J�X���Z�b�g�l���㏑������Ă��邱�Ƃ�����̂�
                // STG�V�[���p�Ƀ��Z�b�g�l��X�V����
                gstd.ref_count_ptr<D3DXVECTOR2> pos = new D3DXVECTOR2();
                pos.x = (rcStgFrame.right - rcStgFrame.left) / 2;
                pos.y = (rcStgFrame.bottom - rcStgFrame.top) / 2;
                camera2D.SetResetFocus(pos);

                orgFocusPos = camera2D.GetFocusPosition();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: focusPos = orgFocusPos;
                focusPos.CopyFrom(orgFocusPos);
            }
            else
            {
                stageInfo = new StgStageInformation();

                RECT rect = new RECT();
                ZeroMemory(rect, sizeof(RECT));
                rect.right = graphics.GetScreenWidth();
                rect.bottom = graphics.GetScreenHeight();

                stageInfo.SetStgFrameRect(rect);
                if (scene != (int)StgSystemInformation.AnonymousEnum2.SCENE_STG)
                {
                    // STG�V�[���łȂ��Ȃ�J�������W����Z�b�g���Ă���
                    orgFocusPos = camera2D.GetFocusPosition();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: focusPos = orgFocusPos;
                    focusPos.CopyFrom(orgFocusPos);
                }
            }

            RECT rcStgFrame = stageInfo.GetStgFrameRect();
            int stgWidth = rcStgFrame.right - rcStgFrame.left;
            int stgHeight = rcStgFrame.bottom - rcStgFrame.top;
            POINT stgCenter = new POINT(rcStgFrame.left + stgWidth / 2, rcStgFrame.top + stgHeight / 2);
            int priMinStgFrame = stageInfo.GetStgFrameMinPriority();
            int priMaxStgFrame = stageInfo.GetStgFrameMaxPriority();
            int priShot = stageInfo.GetShotObjectPriority();
            int priItem = stageInfo.GetItemObjectPriority();
            int priCamera = stageInfo.GetCameraFocusPermitPriority();
            int invalidPriMin = infoSystem_.GetInvaridRenderPriorityMin();
            int invalidPriMax = infoSystem_.GetInvaridRenderPriorityMax();

            List<bool> listShotValidPriority = new List<bool>();
            List<bool> listItemValidPriority = new List<bool>();
            if (bValidStage)
            {
                listShotValidPriority = stageController_.GetShotManager().GetValidRenderPriorityList();
                listItemValidPriority = stageController_.GetItemManager().GetValidRenderPriorityList();
            }

            focusPos.x -= stgWidth / 2;
            focusPos.y -= stgHeight / 2;

            // �t�H�O�ݒ�
            bool bFogEnable = false;
            D3DCOLOR fogColor = D3DCOLOR_ARGB(255, 255, 255, 255);
            float fogStart = 0F;
            float fogEnd = 0F;
            if (objectManagerStage != null)
            {
                bFogEnable = objectManagerStage.IsFogEneble();
                fogColor = objectManagerStage.GetFogColor();
                fogStart = objectManagerStage.GetFogStart();
                fogEnd = objectManagerStage.GetFogEnd();
            }
            else if (objectManagerPackage != null)
            {
                bFogEnable = objectManagerPackage.IsFogEneble();
                fogColor = objectManagerPackage.GetFogColor();
                fogStart = objectManagerPackage.GetFogStart();
                fogEnd = objectManagerPackage.GetFogEnd();
            }

            graphics.SetVertexFog(bFogEnable, fogColor, fogStart, fogEnd);

            // �`��J�n�O���Z�b�g
            camera2D.SetEnable(false);
            camera2D.Reset();
            graphics.ResetViewPort();

            bool bClearZBufferFor2DCoordinate = false;
            bool bRunMinStgFrame = false;
            bool bRunMaxStgFrame = false;
            for (int iPri = priMin ; iPri <= priMax ; iPri++)
            {
                if (iPri >= priMinStgFrame && !bRunMinStgFrame)
                {
                    // STG�t���[���J�n
                    if (bValidStage && iPri < invalidPriMin)
                    {
                        graphics.ClearRenderTarget(rcStgFrame);
                    }

                    double clipNear = camera3D.GetNearClip();
                    double clipFar = camera3D.GetFarClip();

                    camera2D.SetEnable(true);
                    camera2D.SetRatioX(focusRatioX);
                    camera2D.SetRatioY(focusRatioY);
                    camera2D.SetAngleZ(focusAngleZ);
                    camera2D.SetClip(rcStgFrame);
                    camera2D.SetFocus(stgCenter.x + focusPos.x, stgCenter.y + focusPos.y);
                    camera3D.SetProjectionMatrix(rcStgFrame.right - rcStgFrame.left, rcStgFrame.bottom - rcStgFrame.top, clipNear, clipFar);
                    camera3D.UpdateDeviceProjectionMatrix();

                    graphics.SetViewPort(rcStgFrame.left, rcStgFrame.top, stgWidth, stgHeight);

                    bRunMinStgFrame = true;
                    bClearZBufferFor2DCoordinate = false;
                }

                if (objectManagerStage != null && !bPause)
                {
                    // �V�F�[�_�ݒ�
                    ref_count_ptr<Shader> shader = objectManagerStage.GetShader(iPri);
                    if (shader != null)
                    {
                        shader.Begin();
                    }

                    // �X�e�[�W�`��
                    if (listShotValidPriority[iPri])
                    {
                        // �e�`��
                        stageController_.GetShotManager().Render(iPri);
                    }
                    if (listItemValidPriority[iPri])
                    {
                        // �A�C�e���`��
                        stageController_.GetItemManager().Render(iPri);
                    }

                    if (pRenderListStage != null && iPri < pRenderListStage.Count)
                    {
                        LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >.Enumerator itr;
                        for (itr = pRenderListStage[iPri].GetEnumerator(); itr.MoveNext();)
                        {
                            if (!bClearZBufferFor2DCoordinate)
                            {
                                DxScriptMeshObject objMesh = itr.Current.GetPointer() as DxScriptMeshObject;
                                if (objMesh != null)
                                {
                                    gstd.ref_count_ptr<DxMesh> mesh = objMesh.GetMesh();
                                    if (mesh != null && mesh.IsCoordinate2D())
                                    {
                                        graphics.GetDevice().Clear(0, null, D3DCLEAR_ZBUFFER, D3DCOLOR_XRGB(0,0,0), 1.0,0);
                                        bClearZBufferFor2DCoordinate = true;
                                    }
                                }
                            }
                            itr.Current.Render();
                        }
                        pRenderListStage[iPri].Clear();

                    }

                    if (shader != null)
                    {
                        shader.End();
                    }
                }

                // �p�b�P�[�W
                if (objectManagerPackage != null)
                {
                    // �V�F�[�_�ݒ�
                    ref_count_ptr<Shader> shader = objectManagerPackage.GetShader(iPri);
                    if (shader != null)
                    {
                        shader.Begin();
                    }

                    if (pRenderListPackage != null && iPri < pRenderListPackage.Count)
                    {
                        LinkedList<gstd.ref_count_ptr<DxScriptObjectBase>.unsync >.Enumerator itr;
                        for (itr = pRenderListPackage[iPri].GetEnumerator(); itr.MoveNext();)
                        {
                            if (!bClearZBufferFor2DCoordinate)
                            {
                                DxScriptMeshObject objMesh = itr.Current.GetPointer() as DxScriptMeshObject;
                                if (objMesh != null)
                                {
                                    gstd.ref_count_ptr<DxMesh> mesh = objMesh.GetMesh();
                                    if (mesh != null && mesh.IsCoordinate2D())
                                    {
                                        graphics.GetDevice().Clear(0, null, D3DCLEAR_ZBUFFER, D3DCOLOR_XRGB(0,0,0), 1.0,0);
                                        bClearZBufferFor2DCoordinate = true;
                                    }
                                }
                            }
                            itr.Current.Render();
                        }
                        pRenderListPackage[iPri].Clear();
                    }
                    if (shader != null)
                    {
                        shader.End();
                    }
                }

                if (iPri == priCamera)
                {
                    camera2D.SetFocus(stgCenter.x, stgCenter.y);
                    camera2D.SetRatio(1);
                    camera2D.SetAngleZ(0);
                }
                if (iPri >= priMaxStgFrame && !bRunMaxStgFrame)
                {
                    // STG�t���[���I��
                    camera2D.SetEnable(false);
                    camera2D.Reset();
                    graphics.ResetViewPort();

                    bRunMaxStgFrame = true;
                    bClearZBufferFor2DCoordinate = false;
                }
            }
            camera2D.SetFocus(orgFocusPos);
            camera2D.SetRatioX(focusRatioX);
            camera2D.SetRatioY(focusRatioY);
            camera2D.SetAngleZ(focusAngleZ);

            // --------------------------------
            if (objectManagerStage != null)
            {
                objectManagerStage.ClearRenderObject();
            }
            if (objectManagerPackage != null)
            {
                objectManagerPackage.ClearRenderObject();
            }
        }

        public ref_count_ptr<StgSystemInformation> GetSystemInformation()
        {
            return new ref_count_ptr<StgSystemInformation>(infoSystem_);
        }
        public StgStageController GetStageController()
        {
            return stageController_.GetPointer();
        }
        public StgPackageController GetPackageController()
        {
            return packageController_.GetPointer();
        }
        public ref_count_ptr<StgControlScriptInformation> GetControlScriptInformation()
        {
            return new ref_count_ptr<StgControlScriptInformation>(infoControlScript_);
        }


        public gstd.ref_count_ptr<ScriptEngineCache> GetScriptEngineCache()
        {
            return new ref_count_ptr<ScriptEngineCache>(scriptEngineCache_);
        }
        public gstd.ref_count_ptr<ScriptCommonDataManager> GetCommonDataManager()
        {
            return new gstd.ref_count_ptr<ScriptCommonDataManager>(commonDataManager_);
        }

        public void StartStgScene(ref_count_ptr<StgStageInformation> infoStage, ref_count_ptr<ReplayInformation.StageData> replayStageData)
        {
            ref_count_ptr<StgStageStartData> startData = new StgStageStartData();
            startData.SetStageInformation(infoStage);
            startData.SetStageReplayData(replayStageData);
            StartStgScene(new ref_count_ptr<StgStageStartData>(startData));
        }

        public void StartStgScene(ref_count_ptr<StgStageStartData> startData)
        {
            EDirectInput input = EDirectInput.GetInstance();
            input.ClearKeyState();

            infoSystem_.SetScene(StgSystemInformation.AnonymousEnum2.SCENE_STG);
            stageController_ = new StgStageController(this);

            stageController_.Initialize(startData);
        }

        public void TransStgEndScene()
        {
            bool bReplay = false;
            if (stageController_ != null)
            {
                ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
                bReplay = infoStage.IsReplay();
            }

            if (!bReplay)
            {
                ref_count_ptr<ReplayInformation> infoReplay = CreateReplayInformation();
                infoSystem_.SetActiveReplayInformation(infoReplay);
                endScene_ = new StgEndScene(this);
                endScene_.Start();
                infoSystem_.SetScene(StgSystemInformation.AnonymousEnum2.SCENE_END);
            }
            else
            {
                infoSystem_.SetStgEnd();
            }
        }

        public void TransReplaySaveScene()
        {
            replaySaveScene_ = new StgReplaySaveScene(this);
            replaySaveScene_.Start();
            infoSystem_.SetScene(StgSystemInformation.AnonymousEnum2.SCENE_REPLAY_SAVE);
        }

        public ref_count_ptr<ReplayInformation> CreateReplayInformation()
        {
            ref_count_ptr<ReplayInformation> res = new ReplayInformation();

            // ���C���X�N���v�g�֘A
            ref_count_ptr<StgStageInformation> infoLastStage = stageController_.GetStageInformation();
            ref_count_ptr<ScriptInformation> infoMain = infoSystem_.GetMainScriptInformation();
            string pathMainScript = infoMain.GetScriptPath();
            string nameMainScript = PathProperty.GetFileName(pathMainScript);

            // ���@�֘A
            ref_count_ptr<ScriptInformation> infoPlayer = infoLastStage.GetPlayerScriptInformation();
            string pathPlayerScript = infoPlayer.GetScriptPath();
            string filenamePlayerScript = PathProperty.GetFileName(pathPlayerScript);
            res.SetPlayerScriptFileName(filenamePlayerScript);
            res.SetPlayerScriptID(infoPlayer.GetID());
            res.SetPlayerScriptReplayName(infoPlayer.GetReplayName());

            // �V�X�e���֘A
            _int64 totalScore = infoLastStage.GetScore();
            double fpsAvarage = 0;

            // �X�e�[�W
            if (infoSystem_.IsPackageMode())
            {
                ref_count_ptr<StgPackageInformation> infoPackage = packageController_.GetPackageInformation();
                List<ref_count_ptr<StgStageStartData>> listStageData = infoPackage.GetStageDataList();
                for (int iStage = 0 ; iStage < listStageData.Count ; iStage++)
                {
                    ref_count_ptr<StgStageStartData> stageData = listStageData[iStage];
                    ref_count_ptr<StgStageInformation> infoStage = stageData.GetStageInformation();
                    ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage.GetReplayData();
                    res.SetStageData(infoStage.GetStageIndex(), replayStageData);

                    fpsAvarage += replayStageData.GetFramePerSecondAvarage();
                }
                if (listStageData.Count > 0)
                {
                    fpsAvarage = fpsAvarage / listStageData.Count;
                }
            }
            else
            {
                ref_count_ptr<StgStageController> stageController = new ref_count_ptr<StgStageController>(stageController_);
                ref_count_ptr<ReplayInformation.StageData> replayStageData = infoLastStage.GetReplayData();
                res.SetStageData(0, replayStageData);
                fpsAvarage = replayStageData.GetFramePerSecondAvarage();
            }

            SYSTEMTIME sysTime = new SYSTEMTIME();
            GetLocalTime(sysTime);
            res.SetDate(sysTime);
            res.SetTotalScore(totalScore);
            res.SetAvarageFps(fpsAvarage);

            return new ref_count_ptr<ReplayInformation>(res);
        }

        public void TerminateScriptAll()
        {
            string error = "force terminate";
            if (packageController_ != null)
            {
                ref_count_ptr<ScriptManager> scriptManager = packageController_.GetScriptManager();
                if (scriptManager != null)
                {
                    scriptManager.TerminateScriptAll(error);
                }
            }

            if (stageController_ != null)
            {
                ScriptManager scriptManager = stageController_.GetScriptManagerP();
                if (scriptManager != null)
                {
                    scriptManager.TerminateScriptAll(error);
                }

                ref_count_ptr<StgPauseScene> pauseScene = stageController_.GetPauseManager();
                if (pauseScene != null)
                {
                    ref_count_ptr<ScriptManager> pauseScriptManager = pauseScene.GetScriptManager();
                    if (pauseScriptManager != null)
                    {
                        pauseScriptManager.TerminateScriptAll(error);
                    }
                }
            }

            if (endScene_ != null)
            {
                ref_count_ptr<ScriptManager> scriptManager = endScene_.GetScriptManager();
                if (scriptManager != null)
                {
                    scriptManager.TerminateScriptAll(error);
                }
            }

            if (replaySaveScene_ != null)
            {
                ref_count_ptr<ScriptManager> scriptManager = replaySaveScene_.GetScriptManager();
                if (scriptManager != null)
                {
                    scriptManager.TerminateScriptAll(error);
                }
            }

        }
}

/**********************************************************
//StgSystemInformation
**********************************************************/
public class StgSystemInformation : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            SCENE_NULL,
            SCENE_PACKAGE_CONTROL,
            SCENE_STG,
            SCENE_REPLAY_SAVE,
            SCENE_END
        }

        private int scene_;
        private bool bEndStg_;
        private bool bRetry_;

        private string pathPauseScript_ = "";
        private string pathEndSceneScript_ = "";
        private string pathReplaySaveSceneScript_ = "";

        private LinkedList<string> listError_ = new LinkedList<string>();
        private ref_count_ptr<ScriptInformation> infoMain_ = new ref_count_ptr<ScriptInformation>();
        private ref_count_ptr<ReplayInformation> infoReplayActive_ = new ref_count_ptr<ReplayInformation>(); // �A�N�e�B�u���v���C���

        private int invalidPriMin_;
        private int invalidPriMax_;
        private SortedSet<int> listReplayTargetKey_ = new SortedSet<int>();


        /**********************************************************
        //StgSystemInformation
        **********************************************************/
        public StgSystemInformation()
        {
            scene_ = (int)AnonymousEnum2.SCENE_NULL;
            bEndStg_ = false;
            bRetry_ = false;

            invalidPriMin_ = -1;
            invalidPriMax_ = -1;

            pathPauseScript_ = EPathProperty.GetStgDefaultScriptDirectory() + "Default_Pause.txt";
            pathEndSceneScript_ = EPathProperty.GetStgDefaultScriptDirectory() + "Default_EndScene.txt";
            pathReplaySaveSceneScript_ = EPathProperty.GetStgDefaultScriptDirectory() + "Default_ReplaySaveScene.txt";
        }

        public virtual void Dispose()
        {
        }

        public bool IsPackageMode()
        {
            bool res = infoMain_.GetType() == ScriptInformation.TYPE_PACKAGE;
            return res;
        }

        public void ResetRetry()
        {
            bEndStg_ = false;
            bRetry_ = false;
            listError_.Clear();
        }

        public int GetScene()
        {
            return scene_;
        }
        public void SetScene(int scene)
        {
            scene_ = scene;
        }
        public bool IsStgEnd()
        {
            return bEndStg_;
        }
        public void SetStgEnd()
        {
            bEndStg_ = true;
        }
        public bool IsRetry()
        {
            return bRetry_;
        }
        public void SetRetry()
        {
            bRetry_ = true;
        }
        public bool IsError()
        {
            return listError_.Count > 0;
        }
        public void SetError(string error)
        {
            listError_.AddLast(error);
        }
        public string GetErrorMessage()
        {
            string res = "";
            LinkedList<string>.Enumerator itr = listError_.GetEnumerator();
            while (itr.MoveNext())
            {
                string str = itr.Current;
                if (str == "Retry")
                {
                    continue;
                }
                res += str + "\r\n" + "\r\n";
            }
            return res;
        }

        public string GetPauseScriptPath()
        {
            return pathPauseScript_;
        }
        public void SetPauseScriptPath(string path)
        {
            pathPauseScript_ = path;
        }
        public string GetEndSceneScriptPath()
        {
            return pathEndSceneScript_;
        }
        public void SetEndSceneScriptPath(string path)
        {
            pathEndSceneScript_ = path;
        }
        public string GetReplaySaveSceneScriptPath()
        {
            return pathReplaySaveSceneScript_;
        }
        public void SetReplaySaveSceneScriptPath(string path)
        {
            pathReplaySaveSceneScript_ = path;
        }

        public ref_count_ptr<ScriptInformation> GetMainScriptInformation()
        {
            return new ref_count_ptr<ScriptInformation>(infoMain_);
        }
        public void SetMainScriptInformation(ref_count_ptr<ScriptInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoMain_ = info;
            infoMain_.CopyFrom(info);
        }

        public ref_count_ptr<ReplayInformation> GetActiveReplayInformation()
        {
            return new ref_count_ptr<ReplayInformation>(infoReplayActive_);
        }
        public void SetActiveReplayInformation(ref_count_ptr<ReplayInformation> info)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoReplayActive_ = info;
            infoReplayActive_.CopyFrom(info);
        }

        public void SetInvaridRenderPriority(int priMin, int priMax)
        {
            invalidPriMin_ = priMin;
            invalidPriMax_ = priMax;
        }

        public int GetInvaridRenderPriorityMin()
        {
            return invalidPriMin_;
        }
        public int GetInvaridRenderPriorityMax()
        {
            return invalidPriMax_;
        }

        public void AddReplayTargetKey(int id)
        {
            listReplayTargetKey_.Add(id);
        }
        public SortedSet<int> GetReplayTargetKeyList()
        {
            return new SortedSet<int>(listReplayTargetKey_);
        }

}
