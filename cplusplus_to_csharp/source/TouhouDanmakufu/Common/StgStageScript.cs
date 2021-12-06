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
// class StgStageScriptObjectManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgStageScript;


/**********************************************************
//StgStageScriptManager
**********************************************************/
public class StgStageScriptManager : StgControlScriptManager
{
        protected StgStageController stageController_;
        protected ref_count_ptr<StgStageScriptObjectManager> objManager_ = new ref_count_ptr<StgStageScriptObjectManager>();

        protected _int64 idPlayerScript_ = new _int64();
        protected _int64 idItemScript_ = new _int64();
        protected _int64 idShotScript_ = new _int64();


        /**********************************************************
        //StgStageScriptManager
        **********************************************************/
        public StgStageScriptManager(StgStageController stageController)
        {
            stageController_ = stageController;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: objManager_ = stageController_->GetMainObjectManager();
            objManager_.CopyFrom(stageController_.GetMainObjectManager());
            idPlayerScript_ = ID_INVALID;
            idItemScript_ = ID_INVALID;
            idShotScript_ = ID_INVALID;
        }

        public override void Dispose()
        {

            base.Dispose();
        }

        public override void SetError(string error)
        {
            base.SetError(error);
            stageController_.GetSystemInformation().SetError(error);
        }

        public override bool IsError()
        {
            bool res = error_ != "" || stageController_.GetSystemInformation().IsError();
            return res;
        }

        public gstd.ref_count_ptr<StgStageScriptObjectManager> GetObjectManager()
        {
            return new ref_count_ptr<StgStageScriptObjectManager>(objManager_);
        }
        public override ref_count_ptr<ManagedScript> Create(int type)
        {
            ref_count_ptr<ManagedScript> res = null;
            switch (type)
            {
                case StgStageScript.AnonymousEnum.TYPE_STAGE:
                    res = new StgStageScript(stageController_);
                    break;
                case StgStageScript.AnonymousEnum.TYPE_SYSTEM:
                    res = new StgStageSystemScript(stageController_);
                    break;
                case StgStageScript.AnonymousEnum.TYPE_ITEM:
                    res = new StgStageItemScript(stageController_);
                    break;
                case StgStageScript.AnonymousEnum.TYPE_SHOT:
                    res = new StgStageShotScript(stageController_);
                    break;
                case StgStageScript.AnonymousEnum.TYPE_PLAYER:
                    res = new StgStagePlayerScript(stageController_);
                    break;

            }

            if (res != null)
            {
                res.SetScriptManager(stageController_.GetScriptManagerP());
            }

            return new ref_count_ptr<ManagedScript>(res);
        }

        public _int64 GetPlayerScriptID()
        {
            return new _int64(idPlayerScript_);
        }
        public void SetPlayerScriptID(_int64 id)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: idPlayerScript_ = id;
            idPlayerScript_.CopyFrom(id);
        }
        public _int64 GetItemScriptID()
        {
            return new _int64(idItemScript_);
        }
        public void SetItemScriptID(_int64 id)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: idItemScript_ = id;
            idItemScript_.CopyFrom(id);
        }
        public ref_count_ptr<ManagedScript> GetItemScript()
        {
            ref_count_ptr<ManagedScript> res = null;
            if (idItemScript_ != StgControlScriptManager.ID_INVALID)
            {
                res = GetScript(idItemScript_);
            }
            return new ref_count_ptr<ManagedScript>(res);
        }

        public _int64 GetShotScriptID()
        {
            return new _int64(idShotScript_);
        }
        public void SetShotScriptID(_int64 id)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: idShotScript_ = id;
            idShotScript_.CopyFrom(id);
        }
        public ref_count_ptr<ManagedScript> GetShotScript()
        {
            ref_count_ptr<ManagedScript> res = null;
            if (idShotScript_ != StgControlScriptManager.ID_INVALID)
            {
                res = GetScript(idShotScript_);
            }
            return new ref_count_ptr<ManagedScript>(res);
        }
}

/**********************************************************
//StgStageScriptObjectManager
**********************************************************/
public class StgStageScriptObjectManager : DxScriptObjectManager
{
        private StgStageController stageController_;

        private int idObjPleyer_;


        /**********************************************************
        //StgStageScriptObjectManager
        **********************************************************/
        public StgStageScriptObjectManager(StgStageController stageController)
        {
            stageController_ = stageController;
            SetMaxObject(256 * 256);

            idObjPleyer_ = DxScript.ID_INVALID;
        }

        public new void Dispose()
        {
            if (idObjPleyer_ != DxScript.ID_INVALID)
            {
                ref_count_ptr<StgPlayerObject>.unsync obj = new ref_count_ptr<StgPlayerObject>.unsync(GetObject(idObjPleyer_));
                if (obj != null)
                {
                    obj.Clear();
                }
            }
            base.Dispose();
        }

        public override void RenderObject()
        {
        /*
        	if(invalidPriMin_ < 0 && invalidPriMax_ < 0)
        	{
        		RenderObject(0, objRender_.size());
        	}
        	else
        	{
        		RenderObject(0, invalidPriMin_);
        		RenderObject(invalidPriMax_ + 1, objRender_.size());
        	}
        */
        }

        public virtual void RenderObject(int priMin, int priMax)
        {
        /*
        	std::list<gstd::ref_count_ptr<DxScriptObjectBase>::unsync >::iterator itr;
        	for(itr = listActiveObject_.begin() ; itr != listActiveObject_.end() ; itr++)
        	{
        		gstd::ref_count_ptr<DxScriptObjectBase>::unsync obj = (*itr);
        		if(obj == NULL || obj->IsDeleted())continue;
        		if(!obj->IsVisible())continue;
        		AddRenderObject(obj);
        	}
        
        	DirectGraphics* graphics = DirectGraphics::GetBase();
        	gstd::ref_count_ptr<DxCamera> camera3D = graphics->GetCamera();
        	gstd::ref_count_ptr<DxCamera2D> camera2D = graphics->GetCamera2D();
        
        	ref_count_ptr<StgStageInformation> stageInfo = stageController_->GetStageInformation();
        	RECT rcStgFrame = stageInfo->GetStgFrameRect();
        	int stgWidth = rcStgFrame.right - rcStgFrame.left;
        	int stgHeight = rcStgFrame.bottom - rcStgFrame.top;
        	POINT stgCenter = {rcStgFrame.left + stgWidth / 2, rcStgFrame.top + stgHeight / 2};
        	int priMinStgFrame = stageInfo->GetStgFrameMinPriority();
        	int priMaxStgFrame = stageInfo->GetStgFrameMaxPriority();
        	int priShot = stageInfo->GetShotObjectPriority();
        	int priItem = stageInfo->GetItemObjectPriority();
        	int priCamera = stageInfo->GetCameraFocusPermitPriority();
        
        	double focusRatio = camera2D->GetRatio();
        	D3DXVECTOR2 orgFocusPos = camera2D->GetFocusPosition();
        	D3DXVECTOR2 focusPos = orgFocusPos;
        	focusPos.x -= stgWidth / 2;
        	focusPos.y -= stgHeight / 2;
        
        	//�t�H�O�ݒ�
        	graphics->SetVertexFog(bFogEnable_, fogColor_, fogStart_, fogEnd_);
        
        	//�`��J�n�O���Z�b�g
        	camera2D->SetEnable(false);
        	camera2D->Reset();
        	graphics->ResetViewPort();
        
        	bool bClearZBufferFor2DCoordinate = false;
        	bool bRunMinStgFrame = false;
        	bool bRunMaxStgFrame = false;
        	for(int iPri = priMin ; iPri <= priMax ; iPri++)
        	{
        		if(iPri >= objRender_.size())break;
        
        		if(iPri >= priMinStgFrame && !bRunMinStgFrame)
        		{
        			//STG�t���[���J�n
        			graphics->ClearRenderTarget(rcStgFrame);
        			camera2D->SetEnable(true);
        			camera2D->SetRatio(focusRatio);
        			camera2D->SetClip(rcStgFrame);
        			camera2D->SetFocus(stgCenter.x + focusPos.x, stgCenter.y + focusPos.y);
        			camera3D->SetProjectionMatrix(rcStgFrame.right - rcStgFrame.left, rcStgFrame.bottom - rcStgFrame.top, 10, 2000);
        			camera3D->UpdateDeviceProjectionMatrix();
        
        			graphics->SetViewPort(rcStgFrame.left, rcStgFrame.top, stgWidth, stgHeight);
        
        			bRunMinStgFrame = true;
        			bClearZBufferFor2DCoordinate = false;
        		}
        		if(iPri == priShot)
        		{
        			//�e�`��
        			stageController_->GetShotManager()->Render();
        		}
        		if(iPri == priItem)
        		{
        			//�A�C�e���`��
        			stageController_->GetItemManager()->Render();
        		}
        
        		std::list<gstd::ref_count_ptr<DxScriptObjectBase>::unsync >::iterator itr;
        		for(itr = objRender_[iPri].begin() ; itr != objRender_[iPri].end() ; itr++)
        		{
        			if(!bClearZBufferFor2DCoordinate)
        			{
        				DxScriptMeshObject* objMesh = dynamic_cast<DxScriptMeshObject*>((*itr).GetPointer());
        				if(objMesh != NULL)
        				{
        					gstd::ref_count_ptr<DxMesh>& mesh = objMesh->GetMesh();
        					if(mesh != NULL && mesh->IsCoordinate2D())
        					{
        						graphics->GetDevice()->Clear(0, NULL, D3DCLEAR_ZBUFFER, D3DCOLOR_XRGB(0,0,0), 1.0,0);
        						bClearZBufferFor2DCoordinate = true;
        					}
        				}
        			}
        			(*itr)->Render();
        		}
        		objRender_[iPri].clear();
        
        		if(iPri == priCamera)
        		{
        			camera2D->SetFocus(stgCenter.x, stgCenter.y);
        			camera2D->SetRatio(1);
        		}
        		if(iPri >= priMaxStgFrame && !bRunMaxStgFrame)
        		{
        			//STG�t���[���I��
        			camera2D->SetEnable(false);
        			camera2D->Reset();
        			graphics->ResetViewPort();
        
        			bRunMaxStgFrame = true;
        			bClearZBufferFor2DCoordinate = false;
        		}
        	}
        	camera2D->SetFocus(orgFocusPos);
        	camera2D->SetRatio(focusRatio);
        */
        }

        public int GetPlayerObjectID()
        {
            return idObjPleyer_;
        }
        public int CreatePlayerObject()
        {
            // ���@�I�u�W�F�N�g����
            ref_count_ptr<StgPlayerObject>.unsync objPlayer = new StgPlayerObject(stageController_);
            idObjPleyer_ = AddObject(objPlayer);
            return idObjPleyer_;
        }


}


/**********************************************************
//StgStageScript
**********************************************************/
public class StgStageScript : StgControlScript
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend StgStageScriptManager;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TYPE_SYSTEM,
            TYPE_STAGE,
            TYPE_PLAYER,
            TYPE_ITEM,

            TYPE_ALL,
            TYPE_SHOT,
            TYPE_CHILD,
            TYPE_IMMEDIATE,
            TYPE_FADE,


            OBJ_PLAYER = 100,
            OBJ_SPELL_MANAGE,
            OBJ_SPELL,
            OBJ_ENEMY,
            OBJ_ENEMY_BOSS,
            OBJ_ENEMY_BOSS_SCENE,
            OBJ_SHOT,
            OBJ_LOOSE_LASER, // �ˏo�^���[�U�[
            OBJ_STRAIGHT_LASER, // �ݒu�^���[�U�[
            OBJ_CURVE_LASER, // �Ȃ��郌�[�U�[
            OBJ_ITEM,

            INFO_LIFE,
            INFO_DAMAGE_RATE_SHOT,
            INFO_DAMAGE_RATE_SPELL,
            INFO_SHOT_HIT_COUNT,

            INFO_TIMER,
            INFO_TIMERF,
            INFO_ORGTIMERF,
            INFO_IS_SPELL,
            INFO_IS_LAST_SPELL,
            INFO_IS_DURABLE_SPELL,
            INFO_SPELL_SCORE,
            INFO_REMAIN_STEP_COUNT,
            INFO_ACTIVE_STEP_LIFE_COUNT,
            INFO_ACTIVE_STEP_TOTAL_MAX_LIFE,
            INFO_ACTIVE_STEP_TOTAL_LIFE,
            INFO_ACTIVE_STEP_LIFE_RATE_LIST,
            INFO_IS_LAST_STEP,
            INFO_PLAYER_SHOOTDOWN_COUNT,
            INFO_PLAYER_SPELL_COUNT,
            INFO_CURRENT_LIFE,
            INFO_CURRENT_LIFE_MAX,

            INFO_ITEM_SCORE,

            INFO_RECT,
            INFO_DELAY_COLOR,
            INFO_BLEND,
            INFO_COLLISION,
            INFO_COLLISION_LIST,

            // �C�x���g
            EV_REQUEST_LIFE = 1, // �G���C�t�v��
            EV_REQUEST_TIMER, // �G�X�y���^�C�}�v��
            EV_REQUEST_IS_SPELL, // �X�y���J�[�h�錾
            EV_REQUEST_IS_LAST_SPELL, // ���X�g�X�y��
            EV_REQUEST_IS_DURABLE_SPELL, // �ϋv�X�y��
            EV_REQUEST_SPELL_SCORE, // �X�y���J�[�h�X�R�A
            EV_REQUEST_REPLAY_TARGET_COMMON_AREA, // ���v���C�Ώ�

            EV_TIMEOUT, // �X�y���^�C���A�E�g
            EV_START_BOSS_SPELL, // �{�X�X�y���J�[�h�J�n
            EV_GAIN_SPELL, // �X�y���J�[�h�擾
            EV_START_BOSS_STEP, // �X�y���J�[�h�J�n
            EV_END_BOSS_STEP, // �X�y���J�[�h�I��

            EV_PLAYER_SHOOTDOWN, // ���@�_�E��
            EV_PLAYER_SPELL, // ���@�X�y��
            EV_PLAYER_REBIRTH, // ���@���A

            EV_PAUSE_ENTER, // ��~�J�n
            EV_PAUSE_LEAVE, // ��~���

            EV_DELETE_SHOT_IMMEDIATE,
            EV_DELETE_SHOT_TO_ITEM,
            EV_DELETE_SHOT_FADE,

            TARGET_ALL,
            TARGET_ENEMY,
            TARGET_PLAYER
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public ref_count_ptr<StgStageScriptObjectManager> GetStgObjectManager()
        {
            StgStageScriptManager scriptManager = (StgStageScriptManager)scriptManager_;
            ref_count_ptr<StgStageScriptObjectManager> objectManager = scriptManager.GetObjectManager();
            return new ref_count_ptr<StgStageScriptObjectManager>(objectManager);
        }

        // STG���ʊ֐��F���ʃf�[�^

        // STG���䋤�ʊ֐��F���ʃf�[�^
        public static gstd.value Func_SaveCommonDataAreaToReplayFile(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();
            ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage.GetReplayData();
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            if (infoStage.IsReplay())
            {
                script.RaiseError("call only in normal play (not replay)");
            }

            string area = to_mbcs(argv[0].as_string());
            ref_count_ptr<ScriptCommonData> commonDataO = commonDataManager.GetData(area);
            if (commonDataO == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            ref_count_ptr<ScriptCommonData> commonDataS = new ScriptCommonData();
            commonDataS.Copy(commonDataO);
            replayStageData.SetCommonData(area, commonDataS);

            return new value(machine.get_engine().get_boolean_type(), true);
        }

        public static gstd.value Func_LoadCommonDataAreaFromReplayFile(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();
            ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage.GetReplayData();
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            if (!infoStage.IsReplay())
            {
                script.RaiseError("call only in replay");
            }

            string area = to_mbcs(argv[0].as_string());
            ref_count_ptr<ScriptCommonData> commonDataS = replayStageData.GetCommonData(area);
            if (commonDataS == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            ref_count_ptr<ScriptCommonData> commonDataO = new ScriptCommonData();
            commonDataO.Copy(commonDataS);
            commonDataManager.SetData(area, commonDataO);

            return new value(machine.get_engine().get_boolean_type(), true);
        }

        // STG���ʊ֐��F�V�X�e���֘A

        // STG���ʊ֐��F�V�X�e���֘A
        public static gstd.value Func_GetMainStgScriptPath(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<ScriptInformation> infoMain = stageController.GetStageInformation().GetMainScriptInformation();

            string path = infoMain.GetScriptPath();
            path = PathProperty.GetUnique(path);

            return new value(machine.get_engine().get_string_type(), path);
        }

        public static gstd.value Func_GetMainStgScriptDirectory(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<ScriptInformation> infoMain = stageController.GetStageInformation().GetMainScriptInformation();

            string path = infoMain.GetScriptPath();
            path = PathProperty.GetUnique(path);

            string dir = PathProperty.GetFileDirectory(path);

            return new value(machine.get_engine().get_string_type(), dir);
        }

        public static gstd.value Func_SetStgFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            RECT rect = new RECT();
            rect.left = (int)argv[0].as_real();
            rect.top = (int)argv[1].as_real();
            rect.right = (int)argv[2].as_real();
            rect.bottom = (int)argv[3].as_real();

            int min = (int)argv[4].as_real();
            int max = (int)argv[5].as_real();

            ref_count_ptr<StgStageInformation> stageInfo = stageController.GetStageInformation();
            stageInfo.SetStgFrameRect(rect);
            stageInfo.SetStgFrameMinPriority(min);
            stageInfo.SetStgFrameMaxPriority(max);

            return new value();
        }

        public static gstd.value Func_SetItemRenderPriorityI(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> info = stageController.GetStageInformation();
            int pri = (int)argv[0].as_real();
            // pri = min(pri, info->GetStgFrameMaxPriority());
            // pri = max(pri, info->GetStgFrameMinPriority());
            info.SetItemObjectPriority(pri);
            return new value();
        }

        public static gstd.value Func_SetShotRenderPriorityI(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> info = stageController.GetStageInformation();
            int pri = (int)argv[0].as_real();
            // pri = min(pri, info->GetStgFrameMaxPriority());
            // pri = max(pri, info->GetStgFrameMinPriority());
            info.SetShotObjectPriority(pri);
            return new value();
        }

        public static gstd.value Func_GetStgFrameRenderPriorityMinI(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            double res = stageController.GetStageInformation().GetStgFrameMinPriority();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetStgFrameRenderPriorityMaxI(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            double res = stageController.GetStageInformation().GetStgFrameMaxPriority();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetItemRenderPriorityI(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            double res = stageController.GetStageInformation().GetItemObjectPriority();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetShotRenderPriorityI(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            double res = stageController.GetStageInformation().GetShotObjectPriority();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetPlayerRenderPriorityI(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            ref_count_ptr<StgStageScriptObjectManager> objectManager = script.GetStgObjectManager();
            int idObjPlayer = objectManager.GetPlayerObjectID();

            double res = 30;
            StgPlayerObject obj = script.GetObjectPointer(idObjPlayer) as StgPlayerObject;
            if (obj != null)
            {
                double pri = obj.GetRenderPriority();
                int vacket = objectManager.GetRenderBucketCapacity();
                res = pri * (vacket - 1);
            }
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetCameraFocusPermitPriorityI(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            double res = stageController.GetStageInformation().GetCameraFocusPermitPriority();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_CloseStgScene(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgSystemController systemController = script.stageController_.GetSystemController();

            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> info = stageController.GetStageInformation();
            info.SetEnd();

            return new value();
        }

        public static gstd.value Func_GetReplayFps(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();

            int fps = 0;
            if (infoStage.IsReplay())
            {
                ref_count_ptr<ReplayInformation.StageData> replayStageData = infoStage.GetReplayData();
                int frame = infoStage.GetCurrentFrame();
                fps = replayStageData.GetFramePerSecond(frame);
            }

            return new value(machine.get_engine().get_real_type(), (double)fps);
        }

        // STG���ʊ֐��F���@

        // STG���ʊ֐��F���@
        public static gstd.value Func_GetPlayerObjectID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            ref_count_ptr<StgStageScriptObjectManager> objectManager = script.GetStgObjectManager();
            double res = objectManager.GetPlayerObjectID();
            return new value(machine.get_engine().get_real_type(), res);
        }

        public static gstd.value Func_GetPlayerScriptID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgStageScriptManager scriptManager = stageController.GetScriptManagerP();

            _int64 res = scriptManager.GetPlayerScriptID();
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_SetPlayerSpeed(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            double speedFast = argv[0].as_real();
            double speedSlow = argv[1].as_real();
            obj.SetFastSpeed(speedFast);
            obj.SetSlowSpeed(speedSlow);
            return new value();
        }

        public static gstd.value Func_SetPlayerClip(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            ref_count_ptr<StgStageScriptObjectManager> objectManager = script.GetStgObjectManager();
            int idObjPlayer = objectManager.GetPlayerObjectID();

            StgPlayerObject obj = script.GetObjectPointer(idObjPlayer) as StgPlayerObject;
            if (obj == null)
            {
                return new value();
            }

            RECT rect = new RECT();
            rect.left = (int)argv[0].as_real();
            rect.top = (int)argv[1].as_real();
            rect.right = (int)argv[2].as_real();
            rect.bottom = (int)argv[3].as_real();
            obj.SetClip(new RECT(rect));

            return new value();
        }

        public static gstd.value Func_SetPlayerLife(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            double life = argv[0].as_real();
            obj.SetLife(life);

            return new value();
        }

        public static gstd.value Func_SetPlayerSpell(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            double spell = argv[0].as_real();
            obj.SetSpell(spell);

            return new value();
        }

        public static gstd.value Func_SetPlayerPower(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            double power = argv[0].as_real();
            obj.SetPower(power);

            return new value();
        }

        public static gstd.value Func_SetPlayerInvincibilityFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            int invi = (int)argv[0].as_real();
            obj.SetInvincibilityFrame(invi);

            return new value();
        }

        public static gstd.value Func_SetPlayerDownStateFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[0].as_real();
            obj.SetDownStateFrame(frame);

            return new value();
        }

        public static gstd.value Func_SetPlayerRebirthFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[0].as_real();
            obj.SetRebirthFrame(frame);
            obj.SetRebirthFrameMax(frame);

            return new value();
        }

        public static gstd.value Func_SetPlayerRebirthLossFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[0].as_real();
            obj.SetRebirthLossFrame(frame);

            return new value();
        }

        public static gstd.value Func_SetPlayerAutoItemCollectLine(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            int posY = (int)argv[0].as_real();
            obj.SetAutoItemCollectY(posY);

            return new value();
        }

        public static gstd.value Func_SetForbidPlayerShot(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            bool bForbid = argv[0].as_boolean();
            obj.SetForbidShot(bForbid);

            return new value();
        }

        public static gstd.value Func_SetForbidPlayerSpell(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            if (obj == null)
            {
                return new value();
            }

            bool bForbid = argv[0].as_boolean();
            obj.SetForbidSpell(bForbid);

            return new value();
        }

        public static gstd.value Func_GetPlayerX(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetX() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerY(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetY() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerState(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetState() : StgPlayerObject.STATE_END;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerSpeed(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();

            List<double> listValue = new List<double>();
            listValue.Add(obj.GetFastSpeed());
            listValue.Add(obj.GetSlowSpeed());

            gstd.value res = script.CreateRealArrayValue(listValue);
            return new gstd.value(res);
        }

        public static gstd.value Func_GetPlayerClip(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();

            RECT clip = obj.GetClip();
            List<double> listValue = new List<double>();
            listValue.Add(clip.left);
            listValue.Add(clip.top);
            listValue.Add(clip.right);
            listValue.Add(clip.bottom);

            gstd.value res = script.CreateRealArrayValue(listValue);
            return new gstd.value(res);
        }

        public static gstd.value Func_GetPlayerLife(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetLife() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerSpell(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetSpell() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerPower(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetPower() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerInvincibilityFrame(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetInvincibilityFrame() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerDownStateFrame(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetDownStateFrame() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetPlayerRebirthFrame(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            double res = obj != null ? obj.GetRebirthFrame() : 0;
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetAngleToPlayer(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
            if (objPlayer == null)
            {
                return new value(machine.get_engine().get_real_type(), (double) - 1);
            }
            double px = objPlayer.GetPositionX();
            double py = objPlayer.GetPositionY();

            int id = (int)argv[0].as_real();
            ref_count_ptr<DxScriptRenderObject>.unsync objMove = new ref_count_ptr<DxScriptRenderObject>.unsync(script.GetObject(id));
            if (objMove == null)
            {
                return new value(machine.get_engine().get_real_type(), (double) - 1);
            }
            double tx = objMove.GetPosition().x;
            double ty = objMove.GetPosition().y;

            double angle = System.Math.Atan2(py - ty, px - tx) * 180 / GlobalMembers.PAI;
            return new value(machine.get_engine().get_real_type(), (double)angle);
        }

        public static gstd.value Func_IsPermitPlayerShot(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            bool res = obj != null ? obj.IsPermitShot() : false;
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_IsPermitPlayerSpell(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            bool res = obj != null ? obj.IsPermitSpell() : false;
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_IsPlayerLastSpellWait(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            bool res = obj != null ? obj.IsWaitLastSpell() : false;
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_IsPlayerSpellActive(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            bool res = false;
            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
            if (objPlayer != null)
            {
                ref_count_ptr<StgPlayerSpellManageObject>.unsync objSpell = objPlayer.GetSpellManageObject();
                res = (objSpell != null && !objSpell.IsDeleted());
            }
            return new value(machine.get_engine().get_boolean_type(), res);
        }


        // STG���ʊ֐��F�G

        // STG���ʊ֐��F�G
        public static gstd.value Func_GetEnemyBossSceneObjectID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgEnemyManager enemyManager = stageController.GetEnemyManager();

            int res = ID_INVALID;
            ref_count_ptr<StgEnemyBossSceneObject>.unsync obj = enemyManager.GetBossSceneObject();
            if (obj != null && !obj.IsDeleted())
            {
                res = obj.GetObjectID();
            }

            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_GetEnemyBossObjectID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgEnemyManager enemyManager = stageController.GetEnemyManager();
            ref_count_ptr<StgEnemyBossSceneObject>.unsync scene = enemyManager.GetBossSceneObject();

            List<double> listLD = new List<double>();
            if (scene != null)
            {
                ref_count_ptr<StgEnemyBossSceneData>.unsync data = scene.GetActiveData();
                if (data != null)
                {
                    List<ref_count_ptr<StgEnemyBossObject>.unsync > listEnemy = data.GetEnemyObjectList();
                    for (int iEnemy = 0 ; iEnemy < listEnemy.Count ; iEnemy++)
                    {
                        ref_count_ptr<StgEnemyBossObject>.unsync obj = listEnemy[iEnemy];
                        if (obj.IsDeleted())
                        {
                            continue;
                        }
                        int id = obj.GetObjectID();
                        listLD.Add(id);
                    }
                }
            }

            return script.CreateRealArrayValue(listLD);
        }

        public static gstd.value Func_GetAllEnemyID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgEnemyManager enemyManager = stageController.GetEnemyManager();

            LinkedList<ref_count_ptr<StgEnemyObject>.unsync > listEnemy = enemyManager.GetEnemyList();

            List<double> listLD = new List<double>();
            LinkedList<ref_count_ptr<StgEnemyObject>.unsync >.Enumerator itr = listEnemy.GetEnumerator();
            while (itr.MoveNext())
            {
                ref_count_ptr<StgEnemyObject>.unsync obj = itr.Current;
                if (obj.IsDeleted())
                {
                    continue;
                }
                int id = obj.GetObjectID();
                listLD.Add(id);
            }

            return script.CreateRealArrayValue(listLD);
        }

        public static gstd.value Func_GetIntersectionRegistedEnemyID(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgIntersectionManager interSectionManager = stageController.GetIntersectionManager();

            List<double> listLD = new List<double>();
            List<StgIntersectionTargetPoint> listPoint = interSectionManager.GetAllEnemyTargetPoint();
            for (int iPoint = 0 ; iPoint < listPoint.Count ; iPoint++)
            {
                StgIntersectionTargetPoint target = listPoint[iPoint];
                int id = target.GetObjectID();
                listLD.Add(id);
            }

            return script.CreateRealArrayValue(listLD);
        }

        public static gstd.value Func_GetAllEnemyIntersectionPosition(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgIntersectionManager interSectionManager = stageController.GetIntersectionManager();

            List<gstd.value> listV = new List<gstd.value>();
            List<StgIntersectionTargetPoint> listPoint = interSectionManager.GetAllEnemyTargetPoint();
            for (int iPoint = 0 ; iPoint < listPoint.Count ; iPoint++)
            {
                StgIntersectionTargetPoint target = listPoint[iPoint];
                POINT pos = target.GetPoint();
                List<double> listLD = new List<double>();
                listLD.Add(pos.x);
                listLD.Add(pos.y);
                gstd.value v = script.CreateRealArrayValue(listLD);
                listV.Add(v);
            }
            return script.CreateValueArrayValue(listV);
        }

        public class SortDistance
        {
            public static List<POINT> Sort(int posX, int posY, List<_int64> listDist, List<POINT> listRes)
            {
                listDist.Sort();
                List<POINT> listResCopy = listRes;
                List<_int64> listDistCopy = listDist;

                for (int iRes = 0 ; iRes < listResCopy.Count; iRes++)
                {
                    POINT pos = listResCopy[iRes];
                    _int64 dist = (pos.x - posX) * (pos.x - posX) + (pos.y - posY) * (pos.y - posY);
                    for (int iDist = 0 ;iDist < listDistCopy.Count ; iDist++)
                    {
                        if (dist == listDistCopy[iDist])
                        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: listRes[iDist] = pos;
                            listRes[iDist].CopyFrom(pos);
                            listDistCopy[iDist] = -1;
                            break;
                        }
                    }
                }

                return listRes;
            }
        }
        public static gstd.value Func_GetEnemyIntersectionPosition(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();


            int posX = (int)argv[0].as_real();
            int posY = (int)argv[1].as_real();
            int countRes = (int)argv[2].as_real();

            List<StgIntersectionTargetPoint> listPoint = intersectionManager.GetAllEnemyTargetPoint();
            List<POINT> listRes = new List<POINT>();
            List<_int64> listDist = new List<_int64>();
            int iPoint = 0;
            for (iPoint = 0; iPoint < listPoint.Count && countRes > 0; iPoint++)
            {
                StgIntersectionTargetPoint target = listPoint[iPoint];
                POINT pos = target.GetPoint();
                if (listRes.Count < countRes)
                {
                    listRes.Add(pos);
                    listDist.Add((pos.x - posX) * (pos.x - posX) + (pos.y - posY) * (pos.y - posY));

                    if (listRes.Count == countRes)
                    {
                        listRes = new SortDistance.Sort(posX, posY, listDist, listRes);
                    }
                }
                else
                {
                    _int64 dist = (pos.x - posX) * (pos.x - posX) + (pos.y - posY) * (pos.y - posY);
                    _int64 target = listDist[listDist.Count - 1];
                    if (dist >= target)
                    {
                        continue;
                    }

                    for (int iDist = 0 ;iDist < listDist.Count ; iDist++)
                    {
                        if (dist < listDist[iDist])
                        {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL vector 'insert' method in C#:
                            listRes.insert(listRes.GetEnumerator() + iDist, pos);
                            listRes.RemoveAt(listRes.Count - 1);
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL vector 'insert' method in C#:
                            listDist.insert(listDist.GetEnumerator() + iDist, dist);
                            listDist.RemoveAt(listDist.Count - 1);
                        }
                    }
                }
            }

            List<gstd.value> listV = new List<gstd.value>();
            listRes = new SortDistance.Sort(posX, posY, listDist, listRes);
            for (iPoint = 0 ; iPoint < listRes.Count ; iPoint++)
            {
                POINT pos = listRes[iPoint];
                List<double> listLD = new List<double>();
                listLD.Add(pos.x);
                listLD.Add(pos.y);
                gstd.value v = script.CreateRealArrayValue(listLD);
                listV.Add(v);
            }
            return script.CreateValueArrayValue(listV);
        }

        public static gstd.value Func_GetEnemyIntersectionPositionByIdA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            // ����1�i�G�I�u�W�F�N�gID�j���@�����A�N�Z�X�
        // 	//�w�肵���G�I�u�W�F�N�gID�������@�V���b�g�ւ̓����蔻��ʒu��S�Ď擾
            // �񎟌��z�񂪕Ԃ�B([<�C���f�b�N�X>][<0:x���W, 1:y���W>])�@�z���0�Ԗڂ��ł�G�{�̂̍��W�ɋ߂�
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyObject obj = script.GetObjectPointer(id) as StgEnemyObject;

            List<gstd.value> listV = new List<gstd.value>();
            if (obj != null)
            {
                SortedDictionary<_int64, POINT> mapPos = new SortedDictionary<_int64, POINT>();
                int enemyX = (int)obj.GetPositionX();
                int enemyY = (int)obj.GetPositionY();
                StgStageController stageController = script.stageController_;
                StgIntersectionManager interSectionManager = stageController.GetIntersectionManager();
                List<StgIntersectionTargetPoint> listPoint = interSectionManager.GetAllEnemyTargetPoint();
                for (int iPoint = 0 ; iPoint < listPoint.Count ; iPoint++)
                {
                    StgIntersectionTargetPoint target = listPoint[iPoint];
                    if (target.GetObjectID() != id)
                    {
                        continue;
                    }

                    POINT pos = target.GetPoint();
                    _int64 dist = (pos.x - enemyX) * (pos.x - enemyX) + (pos.y - enemyY) * (pos.y - enemyY);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mapPos[dist] = pos;
                    mapPos[dist].CopyFrom(pos);
                }

                SortedDictionary<_int64, POINT>.Enumerator itr = mapPos.GetEnumerator();
                while (itr.MoveNext())
                {
                    POINT pos = (itr.Current.Value);
                    List<double> listLD = new List<double>();
                    listLD.Add(pos.x);
                    listLD.Add(pos.y);
                    gstd.value v = script.CreateRealArrayValue(listLD);
                    listV.Add(v);
                }
            }

            return script.CreateValueArrayValue(listV);
        }

        public static gstd.value Func_GetEnemyIntersectionPositionByIdA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            // ����3�i�G�I�u�W�F�N�gID�Ex���W�Ey���W�j���@�����A�N�Z�X�
        // 	//�w�肵���G�I�u�W�F�N�gID�����A���@�V���b�g�ւ̓����蔻��̂����A�w����W�ɍł�߂�1��擾
            // �z�񂪕Ԃ�B([<0:x���W, 1:y���W>])

            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyObject obj = script.GetObjectPointer(id) as StgEnemyObject;

            List<gstd.value> listV = new List<gstd.value>();
            if (obj != null)
            {
                SortedDictionary<_int64, POINT> mapPos = new SortedDictionary<_int64, POINT>();
                int tX = (int)argv[1].as_real();
                int tY = (int)argv[2].as_real();
                StgStageController stageController = script.stageController_;
                StgIntersectionManager interSectionManager = stageController.GetIntersectionManager();
                List<StgIntersectionTargetPoint> listPoint = interSectionManager.GetAllEnemyTargetPoint();
                for (int iPoint = 0 ; iPoint < listPoint.Count ; iPoint++)
                {
                    StgIntersectionTargetPoint target = listPoint[iPoint];
                    if (target.GetObjectID() != id)
                    {
                        continue;
                    }

                    POINT pos = target.GetPoint();
                    _int64 dist = (pos.x - tX) * (pos.x - tX) + (pos.y - tY) * (pos.y - tY);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mapPos[dist] = pos;
                    mapPos[dist].CopyFrom(pos);
                }

                SortedDictionary<_int64, POINT>.Enumerator itr = mapPos.GetEnumerator();
                while (itr.MoveNext())
                {
                    POINT pos = (itr.Current.Value);
                    List<double> listLD = new List<double>();
                    listLD.Add(pos.x);
                    listLD.Add(pos.y);
                    gstd.value v = script.CreateRealArrayValue(listLD);
                    listV.Add(v);
                }
            }

            return script.CreateValueArrayValue(listV);
        }

        public static gstd.value Func_LoadEnemyShotData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgShotManager shotManager = stageController.GetShotManager();

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            bool res = shotManager.LoadEnemyShotData(path);

            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_ReloadEnemyShotData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgShotManager shotManager = stageController.GetShotManager();

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            bool res = shotManager.LoadEnemyShotData(path, true);

            return new value(machine.get_engine().get_boolean_type(), res);
        }


        // STG���ʊ֐��F�e

        // STG���ʊ֐��F�e
        public static gstd.value Func_DeleteShotAll(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int typeDel = (int)argv[0].as_real();
            int typeTo = (int)argv[1].as_real();

            switch (typeDel)
            {
            case AnonymousEnum.TYPE_ALL:
                typeDel = StgShotManager.DEL_TYPE_ALL;
                break;
            case AnonymousEnum.TYPE_SHOT:
                typeDel = StgShotManager.DEL_TYPE_SHOT;
                break;
            case AnonymousEnum.TYPE_CHILD:
                typeDel = StgShotManager.DEL_TYPE_CHILD;
                break;
            }

            switch (typeTo)
            {
            case AnonymousEnum.TYPE_IMMEDIATE:
                typeTo = StgShotManager.TO_TYPE_IMMEDIATE;
                break;
            case AnonymousEnum.TYPE_FADE:
                typeTo = StgShotManager.TO_TYPE_FADE;
                break;
            case AnonymousEnum.TYPE_ITEM:
                typeTo = StgShotManager.TO_TYPE_ITEM;
                break;
            }

            stageController.GetShotManager().DeleteInCircle(typeDel, typeTo, StgShotObject.OWNER_ENEMY, 0, 0, 256 * 256);

            return new value();
        }

        public static gstd.value Func_DeleteShotInCircle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int typeDel = (int)argv[0].as_real();
            int typeTo = (int)argv[1].as_real();
            int posX = (int)argv[2].as_real();
            int posY = (int)argv[3].as_real();
            double radius = argv[4].as_real();

            switch (typeDel)
            {
            case AnonymousEnum.TYPE_ALL:
                typeDel = StgShotManager.DEL_TYPE_ALL;
                break;
            case AnonymousEnum.TYPE_SHOT:
                typeDel = StgShotManager.DEL_TYPE_SHOT;
                break;
            case AnonymousEnum.TYPE_CHILD:
                typeDel = StgShotManager.DEL_TYPE_CHILD;
                break;
            }

            switch (typeTo)
            {
            case AnonymousEnum.TYPE_IMMEDIATE:
                typeTo = StgShotManager.TO_TYPE_IMMEDIATE;
                break;
            case AnonymousEnum.TYPE_FADE:
                typeTo = StgShotManager.TO_TYPE_FADE;
                break;
            case AnonymousEnum.TYPE_ITEM:
                typeTo = StgShotManager.TO_TYPE_ITEM;
                break;
            }

            stageController.GetShotManager().DeleteInCircle(typeDel, typeTo, StgShotObject.OWNER_ENEMY, posX, posY, radius);

            return new value();
        }

        public static gstd.value Func_CreateShotA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speed = argv[2].as_real();
                double angle = argv[3].as_real();
                int idShot = (int)argv[4].as_real();
                int delay = (int)argv[5].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetSpeed(speed);
                obj.SetDirectionAngle(angle);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateShotA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speed = argv[2].as_real();
                double angle = argv[3].as_real();
                double accele = argv[4].as_real();
                double maxSpeed = argv[5].as_real();
                int idShot = (int)argv[6].as_real();
                int delay = (int)argv[7].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetSpeed(speed);
                obj.SetDirectionAngle(angle);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);

                StgMoveObject objMove = (StgMoveObject)obj.GetPointer();
                StgMovePattern_Angle pattern = (StgMovePattern_Angle)objMove.GetPattern().GetPointer();
                pattern.SetAcceleration(accele);
                pattern.SetMaxSpeed(maxSpeed);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateShotOA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int tId = (int)argv[0].as_real();
            DxScriptRenderObject tObj = script.GetObjectPointer(tId) as DxScriptRenderObject;
            if (tObj == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)ID_INVALID);
            }

            double posX = tObj.GetPosition().x;
            double posY = tObj.GetPosition().y;

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double speed = argv[1].as_real();
                double angle = argv[2].as_real();
                int idShot = (int)argv[3].as_real();
                int delay = (int)argv[4].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetSpeed(speed);
                obj.SetDirectionAngle(angle);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateShotB1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speedX = argv[2].as_real();
                double speedY = argv[3].as_real();
                int idShot = (int)argv[4].as_real();
                int delay = (int)argv[5].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);

                ref_count_ptr<StgMovePattern_XY>.unsync pattern = new StgMovePattern_XY(obj.GetPointer());
                pattern.SetSpeedX(speedX);
                pattern.SetSpeedY(speedY);
                obj.SetPattern(pattern);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateShotB2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speedX = argv[2].as_real();
                double speedY = argv[3].as_real();
                double accelX = argv[4].as_real();
                double accelY = argv[5].as_real();
                double maxSpeedX = argv[6].as_real();
                double maxSpeedY = argv[7].as_real();
                int idShot = (int)argv[8].as_real();
                int delay = (int)argv[9].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);

                ref_count_ptr<StgMovePattern_XY>.unsync pattern = new StgMovePattern_XY(obj.GetPointer());
                pattern.SetSpeedX(speedX);
                pattern.SetSpeedY(speedY);
                pattern.SetAccelerationX(accelX);
                pattern.SetAccelerationY(accelY);
                pattern.SetMaxSpeedX(maxSpeedX);
                pattern.SetMaxSpeedY(maxSpeedY);
                obj.SetPattern(pattern);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateShotOB1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int tId = (int)argv[0].as_real();
            DxScriptRenderObject tObj = script.GetObjectPointer(tId) as DxScriptRenderObject;
            if (tObj == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)ID_INVALID);
            }

            double posX = tObj.GetPosition().x;
            double posY = tObj.GetPosition().y;

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double speedX = argv[1].as_real();
                double speedY = argv[2].as_real();
                int idShot = (int)argv[3].as_real();
                int delay = (int)argv[4].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);

                ref_count_ptr<StgMovePattern_XY>.unsync pattern = new StgMovePattern_XY(obj.GetPointer());
                pattern.SetSpeedX(speedX);
                pattern.SetSpeedY(speedY);
                obj.SetPattern(pattern);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateLooseLaserA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgLooseLaserObject>.unsync obj = new StgLooseLaserObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgLooseLaserObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speed = argv[2].as_real();
                double angle = argv[3].as_real();
                int length = (int)argv[4].as_real();
                int width = (int)argv[5].as_real();
                int idShot = (int)argv[6].as_real();
                int delay = (int)argv[7].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetSpeed(speed);
                obj.SetDirectionAngle(angle);
                obj.SetLength(length);
                obj.SetRenderWidth(width);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateStraightLaserA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgStraightLaserObject>.unsync obj = new StgStraightLaserObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgStraightLaserObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double angle = argv[2].as_real();
                int length = (int)argv[3].as_real();
                int width = (int)argv[4].as_real();
                int deleteFrame = (int)argv[5].as_real();
                int idShot = (int)argv[6].as_real();
                int delay = (int)argv[7].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetLaserAngle(angle);
                obj.SetLength(length);
                obj.SetRenderWidth(width);
                obj.SetAutoDeleteFrame(deleteFrame);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateCurveLaserA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgCurveLaserObject>.unsync obj = new StgCurveLaserObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgCurveLaserObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speed = argv[2].as_real();
                double angle = argv[3].as_real();
                int length = (int)argv[4].as_real();
                int width = (int)argv[5].as_real();
                int idShot = (int)argv[6].as_real();
                int delay = (int)argv[7].as_real();
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;

                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetSpeed(speed);
                obj.SetDirectionAngle(angle);
                obj.SetLength(length);
                obj.SetRenderWidth(width);
                obj.SetShotDataID(idShot);
                obj.SetDelay(delay);
                obj.SetOwnerType(typeOwner);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_SetShotIntersectionCircle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int typeTarget = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgIntersectionTarget.TYPE_PLAYER_SHOT : StgIntersectionTarget.TYPE_ENEMY_SHOT;

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px = (int)argv[0].as_real();
            int py = (int)argv[1].as_real();
            int radius = (int)argv[2].as_real();
            DxCircle circle = new DxCircle(px, py, radius);

            // �����蔻��
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(typeTarget);
            target.SetCircle(circle);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target));

            return new value();
        }

        public static gstd.value Func_SetShotIntersectionLine(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int typeTarget = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgIntersectionTarget.TYPE_PLAYER_SHOT : StgIntersectionTarget.TYPE_ENEMY_SHOT;

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px1 = (int)argv[0].as_real();
            int py1 = (int)argv[1].as_real();
            int px2 = (int)argv[2].as_real();
            int py2 = (int)argv[3].as_real();
            int width = (int)argv[4].as_real();
            DxWidthLine line = new DxWidthLine(px1, py1, px2, py2, width);

            // �����蔻��
            ref_count_ptr<StgIntersectionTarget_Line>.unsync target = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_LINE));
            target.SetTargetType(typeTarget);
            target.SetLine(line);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Line>.unsync(target));

            return new value();
        }

        public static gstd.value Func_GetShotIdInCircleA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            StgShotManager shotManager = stageController.GetShotManager();
            int px = (int)argv[0].as_real();
            int py = (int)argv[1].as_real();
            int radius = (int)argv[2].as_real();
            int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_ENEMY : StgShotObject.OWNER_PLAYER;

            List<int> listID = shotManager.GetShotIdInCircle(typeOwner, px, py, radius);
            List<double> listRes = new List<double>();
            for (int iID = 0 ; iID < listID.Count ; iID++)
            {
                listRes.Add(listID[iID]);
            }
            gstd.value res = script.CreateRealArrayValue(listRes);

            return new gstd.value(res);
        }

        public static gstd.value Func_GetShotIdInCircleA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            StgShotManager shotManager = stageController.GetShotManager();
            int px = (int)argv[0].as_real();
            int py = (int)argv[1].as_real();
            int radius = (int)argv[2].as_real();
            int target = (int)argv[3].as_real();

            int typeOwner = StgShotObject.OWNER_NULL;
            switch (target)
            {
            case AnonymousEnum.TARGET_ALL:
                typeOwner = StgShotObject.OWNER_NULL;
                break;
            case AnonymousEnum.TARGET_PLAYER:
                typeOwner = StgShotObject.OWNER_PLAYER;
                break;
            case AnonymousEnum.TARGET_ENEMY:
                typeOwner = StgShotObject.OWNER_ENEMY;
                break;
            }

            List<int> listID = shotManager.GetShotIdInCircle(typeOwner, px, py, radius);
            List<double> listRes = new List<double>();
            for (int iID = 0 ; iID < listID.Count ; iID++)
            {
                listRes.Add(listID[iID]);
            }
            gstd.value res = script.CreateRealArrayValue(listRes);

            return new gstd.value(res);
        }

        public static gstd.value Func_GetShotCount(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgShotManager shotManager = stageController.GetShotManager();

            int target = (int)argv[0].as_real();
            int typeOwner = StgShotObject.OWNER_NULL;
            switch (target)
            {
            case AnonymousEnum.TARGET_ALL:
                typeOwner = StgShotObject.OWNER_NULL;
                break;
            case AnonymousEnum.TARGET_PLAYER:
                typeOwner = StgShotObject.OWNER_PLAYER;
                break;
            case AnonymousEnum.TARGET_ENEMY:
                typeOwner = StgShotObject.OWNER_ENEMY;
                break;
            }

            int res = shotManager.GetShotCount(typeOwner);
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_SetShotAutoDeleteClip(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();

            RECT rect = new RECT();
            rect.left = -(int)argv[0].as_real();
            rect.top = -(int)argv[1].as_real();
            rect.right = (int)argv[2].as_real();
            rect.bottom = (int)argv[3].as_real();
            infoStage.SetShotAutoDeleteClip(rect);

            return new value();
        }

        public static gstd.value Func_GetShotDataInfoA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            ref_count_ptr<StgStageInformation> infoStage = stageController.GetStageInformation();

            int idShot = (int)argv[0].as_real();
            int target = (int)argv[1].as_real();
            int type = (int)argv[2].as_real();

            StgShotManager shotManager = stageController.GetShotManager();
            StgShotDataList dataList = (target == (int)AnonymousEnum.TARGET_PLAYER) ? shotManager.GetPlayerShotDataList() : shotManager.GetEnemyShotDataList();

            ref_count_ptr<StgShotData>.unsync shotData = null;
            if (dataList != null)
            {
                shotData = dataList.GetData(idShot);
            }

            if (shotData == null)
            {
                script.RaiseError(ErrorUtility.GetErrorMessage(ErrorUtility.ERROR_OUTOFRANGE_INDEX));
            }

            gstd.value res = new gstd.value();
            switch (type)
            {
                case AnonymousEnum.INFO_RECT:
                {
                    RECT rect = shotData.GetRect(0);
                    List<double> list = new List<double>();
                    list.Add(rect.left);
                    list.Add(rect.top);
                    list.Add(rect.right);
                    list.Add(rect.bottom);
                    res = script.CreateRealArrayValue(list);
                    break;
                }

                case AnonymousEnum.INFO_DELAY_COLOR:
                {
                    D3DCOLOR color = shotData.GetDelayColor();
                    int colorR = ColorAccess.GetColorR(color);
                    int colorG = ColorAccess.GetColorG(color);
                    int colorB = ColorAccess.GetColorB(color);

                    List<double> list = new List<double>();
                    list.Add(colorR);
                    list.Add(colorG);
                    list.Add(colorB);
                    res = script.CreateRealArrayValue(list);
                    break;
                }

                case AnonymousEnum.INFO_BLEND:
                {
                    int blendType = shotData.GetRenderType();
                    res = new value(machine.get_engine().get_real_type(), (double)blendType);
                    break;
                }

                case AnonymousEnum.INFO_COLLISION:
                {
                    double radius = 0;
                    List<DxCircle> listCircle = shotData.GetIntersectionCircleList();
                    if (listCircle.Count > 0)
                    {
                        DxCircle circle = listCircle[0];
                        radius = circle.GetR();
                    }
                    res = new value(machine.get_engine().get_real_type(), (double)radius);
                    break;
                }

                case AnonymousEnum.INFO_COLLISION_LIST:
                {
                    List<DxCircle> listCircle = shotData.GetIntersectionCircleList();
                    List<gstd.value> listValue = new List<gstd.value>();
                    for (int iCircle = 0 ; iCircle < listCircle.Count ; iCircle++)
                    {
                        DxCircle circle = listCircle[iCircle];
                        List<double> list = new List<double>();
                        list.Add(circle.GetR());
                        list.Add(circle.GetX());
                        list.Add(circle.GetY());
                        gstd.value val = script.CreateRealArrayValue(list);
                        listValue.Add(val);
                    }
                    res = script.CreateValueArrayValue(listValue);
                    break;
                }
            }

            return new gstd.value(res);
        }

        public static gstd.value Func_StartShotScript(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgStageScriptManager scriptManager = stageController.GetScriptManagerP();

            if (scriptManager.GetShotScriptID() != StgControlScriptManager.ID_INVALID)
            {
                script.RaiseError("already started shot script");
            }

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            int type = script.GetScriptType();
            _int64 idScript = scriptManager.LoadScript(path, StgStageScript.AnonymousEnum.TYPE_SHOT);
            scriptManager.StartScript(idScript);
            scriptManager.SetShotScriptID(new _int64(idScript));
            return new value();
        }


        // STG���ʊ֐��F�A�C�e��

        // STG���ʊ֐��F�A�C�e��
        public static gstd.value Func_CreateItemA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            int type = (int)argv[0].as_real();
            ref_count_ptr<StgItemObject>.unsync obj = itemManager.CreateItem(type);
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(obj));
                int posX = (int)argv[1].as_real();
                int posY = (int)argv[2].as_real();
                int score = (int)argv[3].as_real();
                POINT to = new POINT(posX, posY - 128);
                obj.SetPositionX(posX);
                obj.SetPositionY(posY);
                obj.SetScore(score);
                obj.SetToPosition(to);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateItemA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            int type = (int)argv[0].as_real();
            ref_count_ptr<StgItemObject>.unsync obj = itemManager.CreateItem(type);
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(obj));
                int posX = (int)argv[1].as_real();
                int posY = (int)argv[2].as_real();
                int score = (int)argv[5].as_real();
                POINT to = new POINT((int)argv[3].as_real(), (int)argv[4].as_real());
                obj.SetPositionX(posX);
                obj.SetPositionY(posY);
                obj.SetScore(score);
                obj.SetToPosition(to);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateItemU1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            int type = StgItemObject.ITEM_USER;
            ref_count_ptr<StgItemObject_User>.unsync obj = new ref_count_ptr<StgItemObject_User>.unsync(itemManager.CreateItem(type));
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                itemManager.AddItem(new ref_count_ptr<StgItemObject_User>.unsync(obj));
                int itemID = (int)argv[0].as_real();
                int posX = (int)argv[1].as_real();
                int posY = (int)argv[2].as_real();
                int score = (int)argv[3].as_real();
                POINT to = new POINT(posX, posY - 128);

                obj.SetPositionX(posX);
                obj.SetPositionY(posY);
                obj.SetScore(score);
                obj.SetToPosition(to);
                obj.SetImageID(itemID);
                obj.SetMoveType(StgMovePattern_Item.MOVE_TOPOSITION_A);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateItemU2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            int type = StgItemObject.ITEM_USER;
            ref_count_ptr<StgItemObject_User>.unsync obj = new ref_count_ptr<StgItemObject_User>.unsync(itemManager.CreateItem(type));
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                itemManager.AddItem(new ref_count_ptr<StgItemObject_User>.unsync(obj));
                int itemID = (int)argv[0].as_real();
                int posX = (int)argv[1].as_real();
                int posY = (int)argv[2].as_real();
                int score = (int)argv[5].as_real();
                POINT to = new POINT((int)argv[3].as_real(), (int)argv[4].as_real());
                obj.SetPositionX(posX);
                obj.SetPositionY(posY);
                obj.SetScore(score);
                obj.SetToPosition(to);
                obj.SetImageID(itemID);
                obj.SetMoveType(StgMovePattern_Item.MOVE_TOPOSITION_A);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CreateItemScore(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            double score = argv[0].as_real();
            int posX = (int)argv[1].as_real();
            int posY = (int)argv[2].as_real();

            ref_count_ptr<StgItemObject_Score>.unsync obj = new StgItemObject_Score(stageController);
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                itemManager.AddItem(new ref_count_ptr<StgItemObject_Score>.unsync(obj));
                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetScore(score);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CollectAllItems(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();
            itemManager.CollectItemsAll();

            return new value();
        }

        public static gstd.value Func_CollectItemsByType(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            int type = (int)argv[0].as_real();
            itemManager.CollectItemsByType(type);
            return new value();
        }

        public static gstd.value Func_CollectItemsInCircle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            int cx = (int)argv[0].as_real();
            int cy = (int)argv[1].as_real();
            int cr = (int)argv[2].as_real();
            DxCircle circle = new DxCircle(cx, cy, cr);
            itemManager.CollectItemsInCircle(new DxCircle(circle));
            return new value();
        }

        public static gstd.value Func_CancelCollectItems(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            itemManager.CancelCollectItems();
            return new value();
        }

        public static gstd.value Func_StartItemScript(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgStageScriptManager scriptManager = stageController.GetScriptManagerP();

            if (scriptManager.GetItemScriptID() != StgControlScriptManager.ID_INVALID)
            {
                script.RaiseError("already started item script");
            }

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            int type = script.GetScriptType();
            _int64 idScript = scriptManager.LoadScript(path, StgStageScript.AnonymousEnum.TYPE_ITEM);
            scriptManager.StartScript(idScript);
            scriptManager.SetItemScriptID(new _int64(idScript));
            return new value();
        }

        public static gstd.value Func_SetDefaultBonusItemEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            bool bEnable = argv[0].as_boolean();
            itemManager.SetDefaultBonusItemEnable(bEnable);
            return new value();
        }

        public static gstd.value Func_LoadItemData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            bool res = itemManager.LoadItemData(path);
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_ReloadItemData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgItemManager itemManager = stageController.GetItemManager();

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            bool res = itemManager.LoadItemData(path, true);
            return new value(machine.get_engine().get_boolean_type(), res);
        }


        // STG���ʊ֐��F���̑�

        // STG���ʊ֐��F���̑�
        public static gstd.value Func_StartSlow(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int target = (int)argv[0].as_real();
            int fps = (int)argv[1].as_real();

            int slowTarget = PseudoSlowInformation.TARGET_ALL;
            int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? PseudoSlowInformation.OWNER_PLAYER : PseudoSlowInformation.OWNER_ENEMY;

            ref_count_ptr<PseudoSlowInformation> infoSlow = stageController.GetSlowInformation();
            infoSlow.AddSlow(fps, typeOwner, slowTarget);

            return new value();
        }

        public static gstd.value Func_StopSlow(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int target = (int)argv[0].as_real();

            int slowTarget = PseudoSlowInformation.TARGET_ALL;
            int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? PseudoSlowInformation.OWNER_PLAYER : PseudoSlowInformation.OWNER_ENEMY;

            ref_count_ptr<PseudoSlowInformation> infoSlow = stageController.GetSlowInformation();
            infoSlow.RemoveSlow(typeOwner, slowTarget);

            return new value();
        }

        public static gstd.value Func_IsIntersected_Line_Circle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxWidthLine line = new DxWidthLine(argv[0].as_real(), argv[1].as_real(), argv[2].as_real(), argv[3].as_real(), argv[4].as_real());

            DxCircle circle = new DxCircle(argv[5].as_real(), argv[6].as_real(), argv[7].as_real());

            bool res = DxMath.IsIntersected(circle, line);
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_IsIntersected_Obj_Obj(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id1 = (int)argv[0].as_real();
            int id2 = (int)argv[1].as_real();

            StgShotObject obj1 = script.GetObjectPointer(id1) as StgShotObject;
            if (obj1 == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            StgShotObject obj2 = script.GetObjectPointer(id2) as StgShotObject;
            if (obj2 == null)
            {
                return new value(machine.get_engine().get_boolean_type(), false);
            }

            List<ref_count_ptr<StgIntersectionTarget>.unsync > listTaget1 = obj1.GetIntersectionTargetList();
            List<ref_count_ptr<StgIntersectionTarget>.unsync > listTaget2 = obj2.GetIntersectionTargetList();

            bool res = false;
            for (int iTarget1 = 0 ; iTarget1 < listTaget1.Count && !res; iTarget1++)
            {
                for (int iTarget2 = 0 ; iTarget2 < listTaget2.Count && !res ; iTarget2++)
                {
                    ref_count_ptr<StgIntersectionTarget>.unsync target1 = listTaget1[iTarget1];
                    ref_count_ptr<StgIntersectionTarget>.unsync target2 = listTaget2[iTarget2];
                    res = StgIntersectionManager.IsIntersected(target1, target2);
                }
            }
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        // STG���ʊ֐��F�ړ��I�u�W�F�N�g����

        // STD���ʊ֐��F�ړ��I�u�W�F�N�g����
        public static gstd.value Func_ObjMove_SetX(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double pos = argv[1].as_real();
            obj.SetPositionX(pos);

            DxScriptRenderObject objR = script.GetObjectPointer(id) as DxScriptRenderObject;
            if (objR == null)
            {
                return new value();
            }
            objR.SetX(pos);

            return new value();
        }

        public static gstd.value Func_ObjMove_SetY(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double pos = argv[1].as_real();
            obj.SetPositionY(pos);

            DxScriptRenderObject objR = script.GetObjectPointer(id) as DxScriptRenderObject;
            if (objR == null)
            {
                return new value();
            }
            objR.SetY(pos);

            return new value();
        }

        public static gstd.value Func_ObjMove_SetPosition(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double posX = argv[1].as_real();
            double posY = argv[2].as_real();
            obj.SetPositionX(posX);
            obj.SetPositionY(posY);

            DxScriptRenderObject objR = script.GetObjectPointer(id) as DxScriptRenderObject;
            if (objR == null)
            {
                return new value();
            }
            objR.SetX(posX);
            objR.SetY(posY);

            return new value();
        }

        public static gstd.value Func_ObjMove_SetSpeed(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double speed = argv[1].as_real();
            obj.SetSpeed(speed);
            return new value();
        }

        public static gstd.value Func_ObjMove_SetAngle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double angle = argv[1].as_real();
            obj.SetDirectionAngle(angle);
            return new value();
        }

        public static gstd.value Func_ObjMove_SetAcceleration(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }
            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new ref_count_ptr<StgMovePattern_Angle>.unsync(obj.GetPattern());
            if (pattern == null)
            {
                pattern = new StgMovePattern_Angle(obj);
                obj.SetPattern(new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));
            }

            double param = argv[1].as_real();
            pattern.SetAcceleration(param);
            return new value();
        }

        public static gstd.value Func_ObjMove_SetMaxSpeed(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }
            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new ref_count_ptr<StgMovePattern_Angle>.unsync(obj.GetPattern());
            if (pattern == null)
            {
                pattern = new StgMovePattern_Angle(obj);
                obj.SetPattern(new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));
            }

            double param = argv[1].as_real();
            pattern.SetMaxSpeed(param);
            return new value();
        }

        public static gstd.value Func_ObjMove_SetAngularVelocity(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }
            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new ref_count_ptr<StgMovePattern_Angle>.unsync(obj.GetPattern());
            if (pattern == null)
            {
                pattern = new StgMovePattern_Angle(obj);
                obj.SetPattern(new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));
            }

            double param = argv[1].as_real();
            pattern.SetAngularVelocity(param);
            return new value();
        }

        public static gstd.value Func_ObjMove_SetDestAtSpeed(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double tx = argv[1].as_real();
            double ty = argv[2].as_real();
            double speed = argv[3].as_real();

            ref_count_ptr<StgMovePattern_Line>.unsync pattern = new StgMovePattern_Line(obj);
            pattern.SetAtSpeed(tx, ty, speed);
            obj.SetPattern(new ref_count_ptr<StgMovePattern_Line>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_SetDestAtFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double tx = argv[1].as_real();
            double ty = argv[2].as_real();
            int frame = (int)argv[3].as_real();

            ref_count_ptr<StgMovePattern_Line>.unsync pattern = new StgMovePattern_Line(obj);
            pattern.SetAtFrame(tx, ty, frame);
            obj.SetPattern(new ref_count_ptr<StgMovePattern_Line>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_SetDestAtWeight(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            double tx = argv[1].as_real();
            double ty = argv[2].as_real();
            double weight = argv[3].as_real();
            double maxSpeed = argv[4].as_real();

            ref_count_ptr<StgMovePattern_Line>.unsync pattern = new StgMovePattern_Line(obj);
            pattern.SetAtWait(tx, ty, weight, maxSpeed);
            obj.SetPattern(new ref_count_ptr<StgMovePattern_Line>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speed = argv[2].as_real();
            double angle = argv[3].as_real();

            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new StgMovePattern_Angle(obj);
            pattern.SetSpeed(speed);
            pattern.SetDirectionAngle(angle);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speed = argv[2].as_real();
            double angle = argv[3].as_real();
            double accele = argv[4].as_real();
            double angV = argv[5].as_real();
            double maxSpeed = argv[6].as_real();

            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new StgMovePattern_Angle(obj);
            pattern.SetSpeed(speed);
            pattern.SetDirectionAngle(angle);
            pattern.SetAcceleration(accele);
            pattern.SetAngularVelocity(angV);
            pattern.SetMaxSpeed(maxSpeed);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternA3(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speed = argv[2].as_real();
            double angle = argv[3].as_real();
            double accele = argv[4].as_real();
            double angV = argv[5].as_real();
            double maxSpeed = argv[6].as_real();
            int idShot = (int)argv[7].as_real();

            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new StgMovePattern_Angle(obj);
            pattern.SetSpeed(speed);
            pattern.SetDirectionAngle(angle);
            pattern.SetAcceleration(accele);
            pattern.SetAngularVelocity(angV);
            pattern.SetMaxSpeed(maxSpeed);
            pattern.SetShotDataID(idShot);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternA4(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speed = argv[2].as_real();
            double angle = argv[3].as_real();
            double accele = argv[4].as_real();
            double angV = argv[5].as_real();
            double maxSpeed = argv[6].as_real();
            int idRelative = (int)argv[7].as_real();
            int idShot = (int)argv[8].as_real();

            ref_count_ptr<StgMovePattern_Angle>.unsync pattern = new StgMovePattern_Angle(obj);
            pattern.SetSpeed(speed);
            pattern.SetDirectionAngle(angle);
            pattern.SetAcceleration(accele);
            pattern.SetAngularVelocity(angV);
            pattern.SetMaxSpeed(maxSpeed);
            pattern.SetShotDataID(idShot);
            pattern.SetRelativeObjectID(idRelative);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_Angle>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternB1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speedX = argv[2].as_real();
            double speedY = argv[3].as_real();

            ref_count_ptr<StgMovePattern_XY>.unsync pattern = new StgMovePattern_XY(obj);
            pattern.SetSpeedX(speedX);
            pattern.SetSpeedY(speedY);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_XY>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternB2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speedX = argv[2].as_real();
            double speedY = argv[3].as_real();
            double accelX = argv[4].as_real();
            double accelY = argv[5].as_real();
            double maxSpeedX = argv[6].as_real();
            double maxSpeedY = argv[7].as_real();

            ref_count_ptr<StgMovePattern_XY>.unsync pattern = new StgMovePattern_XY(obj);
            pattern.SetSpeedX(speedX);
            pattern.SetSpeedY(speedY);
            pattern.SetAccelerationX(accelX);
            pattern.SetAccelerationY(accelY);
            pattern.SetMaxSpeedX(maxSpeedX);
            pattern.SetMaxSpeedY(maxSpeedY);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_XY>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_AddPatternB3(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            double speedX = argv[2].as_real();
            double speedY = argv[3].as_real();
            double accelX = argv[4].as_real();
            double accelY = argv[5].as_real();
            double maxSpeedX = argv[6].as_real();
            double maxSpeedY = argv[7].as_real();
            int idShot = (int)argv[8].as_real();

            ref_count_ptr<StgMovePattern_XY>.unsync pattern = new StgMovePattern_XY(obj);
            pattern.SetSpeedX(speedX);
            pattern.SetSpeedY(speedY);
            pattern.SetAccelerationX(accelX);
            pattern.SetAccelerationY(accelY);
            pattern.SetMaxSpeedX(maxSpeedX);
            pattern.SetMaxSpeedY(maxSpeedY);
            pattern.SetShotDataID(idShot);
            obj.AddPattern(frame, new ref_count_ptr<StgMovePattern_XY>.unsync(pattern));

            return new value();
        }

        public static gstd.value Func_ObjMove_GetX(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return script.CreateRealValue(0);
            }

            double pos = obj.GetPositionX();
            return new value(machine.get_engine().get_real_type(), (double)pos);
        }

        public static gstd.value Func_ObjMove_GetY(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return script.CreateRealValue(0);
            }

            double pos = obj.GetPositionY();
            return new value(machine.get_engine().get_real_type(), (double)pos);
        }

        public static gstd.value Func_ObjMove_GetSpeed(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0);
            }

            double speed = obj.GetSpeed();
            return new value(machine.get_engine().get_real_type(), (double)speed);
        }

        public static gstd.value Func_ObjMove_GetAngle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgMoveObject obj = script.GetObjectPointer(id) as StgMoveObject;
            if (obj == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0);
            }

            double angle = obj.GetDirectionAngle();
            return new value(machine.get_engine().get_real_type(), (double)angle);
        }

        // STG���ʊ֐��F�G�I�u�W�F�N�g����

        // STG���ʊ֐��F�G�I�u�W�F�N�g����
        public static gstd.value Func_ObjEnemy_Create(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgEnemyManager enemyManager = stageController.GetEnemyManager();

            int type = (int)argv[0].as_real();
            ref_count_ptr<DxScriptObjectBase>.unsync obj = new ref_count_ptr<DxScriptObjectBase>.unsync();
            if (type == (int)AnonymousEnum.OBJ_ENEMY)
            {
                obj = new StgEnemyObject(stageController);
            }
            else if (type == (int)AnonymousEnum.OBJ_ENEMY_BOSS)
            {
                ref_count_ptr<StgEnemyBossSceneObject>.unsync objScene = enemyManager.GetBossSceneObject();
                if (objScene == null)
                {
                    throw new gstd.wexception("EnemyBossScene���쐬����Ă��܂���");
                }

                ref_count_ptr<StgEnemyBossSceneData>.unsync data = objScene.GetActiveData();
                int id = data.GetEnemyBossIdInCreate();
                return new value(machine.get_engine().get_real_type(), (double)id);
            }

            int id = ID_INVALID;
            if (obj != null)
            {
                obj.SetObjectManager(script.objManager_.GetPointer());
                id = script.AddObject(obj, false);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_ObjEnemy_Regist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();

            ref_count_ptr<StgEnemyObject>.unsync objEnemy = new ref_count_ptr<StgEnemyObject>.unsync(stageController.GetMainRenderObject(id));
            if (objEnemy != null)
            {
                StgEnemyManager enemyManager = stageController.GetEnemyManager();
                enemyManager.AddEnemy(new ref_count_ptr<StgEnemyObject>.unsync(objEnemy));
                objEnemy.Activate();

                script.ActivateObject(objEnemy.GetObjectID(), true);
            }

            return new value();
        }

        public static gstd.value Func_ObjEnemy_GetInfo(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            int type = (int)argv[1].as_real();

            StgEnemyObject obj = script.GetObjectPointer(id) as StgEnemyObject;
            if (obj == null)
            {
                switch (type)
                {
                    case AnonymousEnum.INFO_LIFE:
                    case AnonymousEnum.INFO_DAMAGE_RATE_SHOT:
                    case AnonymousEnum.INFO_DAMAGE_RATE_SPELL:
                    case AnonymousEnum.INFO_SHOT_HIT_COUNT:
                        return new value(machine.get_engine().get_real_type(), (double)0);
                }
                return new value();
            }

            switch (type)
            {
                case AnonymousEnum.INFO_LIFE:
                    return new value(machine.get_engine().get_real_type(), (double)obj.GetLife());
                case AnonymousEnum.INFO_DAMAGE_RATE_SHOT:
                    return new value(machine.get_engine().get_real_type(), (double)obj.GetShotDamageRate());
                case AnonymousEnum.INFO_DAMAGE_RATE_SPELL:
                    return new value(machine.get_engine().get_real_type(), (double)obj.GetSpellDamageRate());
                case AnonymousEnum.INFO_SHOT_HIT_COUNT:
                    return new value(machine.get_engine().get_real_type(), (double)obj.GetIntersectedPlayerShotCount());
            }

            return new value();
        }

        public static gstd.value Func_ObjEnemy_SetLife(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyObject obj = script.GetObjectPointer(id) as StgEnemyObject;
            if (obj == null)
            {
                return new value();
            }

            double param = argv[1].as_real();
            obj.SetLife(param);

            return new value();
        }

        public static gstd.value Func_ObjEnemy_AddLife(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyObject obj = script.GetObjectPointer(id) as StgEnemyObject;
            if (obj == null)
            {
                return new value();
            }

            double inc = argv[1].as_real();
            obj.AddLife(inc);

            return new value();
        }

        public static gstd.value Func_ObjEnemy_SetDamageRate(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyObject obj = script.GetObjectPointer(id) as StgEnemyObject;
            if (obj == null)
            {
                return new value();
            }

            double rateShot = argv[1].as_real();
            double rateSpell = argv[2].as_real();
            obj.SetDamageRate(rateShot, rateSpell);

            return new value();
        }

        public static gstd.value Func_ObjEnemy_AddIntersectionCircleA(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgEnemyObject>.unsync obj = new ref_count_ptr<StgEnemyObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            double radius = argv[3].as_real();

            DxCircle circle = new DxCircle(px, py, radius);

            // �����蔻��
            ref_count_weak_ptr<StgEnemyObject>.unsync wObj = obj;
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY);
            target.SetObject(wObj);
            target.SetCircle(circle);
            obj.AddIntersectionRelativeTarget(target);

            return new value();
        }

        public static gstd.value Func_ObjEnemy_SetIntersectionCircleToShot(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgEnemyObject>.unsync obj = new ref_count_ptr<StgEnemyObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            double radius = argv[3].as_real();

            DxCircle circle = new DxCircle(px, py, radius);

            // �����蔻��
            ref_count_weak_ptr<StgEnemyObject>.unsync wObj = obj;
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY);
            target.SetObject(wObj);
            target.SetCircle(circle);
            intersectionManager.AddEnemyTargetToShot(new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target));

            return new value();
        }

        public static gstd.value Func_ObjEnemy_SetIntersectionCircleToPlayer(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgEnemyObject>.unsync obj = new ref_count_ptr<StgEnemyObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            double radius = argv[3].as_real();

            DxCircle circle = new DxCircle(px, py, radius);

            // �����蔻��
            ref_count_weak_ptr<StgEnemyObject>.unsync wObj = obj;
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(StgIntersectionTarget.TYPE_ENEMY);
            target.SetObject(wObj);
            target.SetCircle(circle);
            intersectionManager.AddEnemyTargetToPlayer(new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target));

            return new value();
        }


        // STG���ʊ֐��F�G�{�X�V�[���I�u�W�F�N�g����

        // STG���ʊ֐��F�G�{�X�V�[���I�u�W�F�N�g����
        public static gstd.value Func_ObjEnemyBossScene_Create(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            script.CheckRunInMainThread();
            StgStageController stageController = script.stageController_;
            StgEnemyManager enemyManager = stageController.GetEnemyManager();

            ref_count_ptr<DxScriptObjectBase>.unsync obj = new StgEnemyBossSceneObject(stageController);

            int id = ID_INVALID;
            if (obj != null)
            {
                obj.SetObjectManager(script.objManager_.GetPointer());
                id = script.AddObject(obj, false);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_ObjEnemyBossScene_Regist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();

            StgEnemyManager enemyManager = stageController.GetEnemyManager();

            ref_count_ptr<StgEnemyBossSceneObject>.unsync objScene = new ref_count_ptr<StgEnemyBossSceneObject>.unsync(stageController.GetMainRenderObject(id));
            if (objScene != null)
            {
                enemyManager.SetBossSceneObject(new ref_count_ptr<StgEnemyBossSceneObject>.unsync(objScene));
                objScene.Activate();
                script.ActivateObject(objScene.GetObjectID(), true);
            }

            return new value();
        }

        public static gstd.value Func_ObjEnemyBossScene_Add(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyBossSceneObject obj = script.GetObjectPointer(id) as StgEnemyBossSceneObject;
            if (obj == null)
            {
                return new value();
            }

            int step = (int)argv[1].as_real();
            string path = argv[2].as_string();
            path = PathProperty.GetUnique(path);

            ref_count_ptr<StgEnemyBossSceneData>.unsync data = new StgEnemyBossSceneData();
            data.SetPath(path);
            obj.AddData(step, new ref_count_ptr<StgEnemyBossSceneData>.unsync(data));

            return new value();
        }

        public static gstd.value Func_ObjEnemyBossScene_LoadInThread(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyBossSceneObject obj = script.GetObjectPointer(id) as StgEnemyBossSceneObject;
            if (obj == null)
            {
                return new value();
            }

            obj.LoadAllScriptInThread();
            return new value();
        }

        public static gstd.value Func_ObjEnemyBossScene_GetInfo(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            int type = (int)argv[1].as_real();

            StgEnemyBossSceneObject obj = script.GetObjectPointer(id) as StgEnemyBossSceneObject;
            if (obj == null)
            {
                switch (type)
                {
                    case AnonymousEnum.INFO_IS_SPELL:
                    case AnonymousEnum.INFO_IS_LAST_SPELL:
                    case AnonymousEnum.INFO_IS_DURABLE_SPELL:
                    case AnonymousEnum.INFO_IS_LAST_STEP:
                        return new value(machine.get_engine().get_boolean_type(), false);
                    case AnonymousEnum.INFO_TIMER:
                    case AnonymousEnum.INFO_TIMERF:
                    case AnonymousEnum.INFO_ORGTIMERF:
                    case AnonymousEnum.INFO_SPELL_SCORE:
                    case AnonymousEnum.INFO_REMAIN_STEP_COUNT:
                    case AnonymousEnum.INFO_ACTIVE_STEP_LIFE_COUNT:
                    case AnonymousEnum.INFO_ACTIVE_STEP_TOTAL_MAX_LIFE:
                    case AnonymousEnum.INFO_ACTIVE_STEP_TOTAL_LIFE:
                    case AnonymousEnum.INFO_PLAYER_SHOOTDOWN_COUNT:
                    case AnonymousEnum.INFO_PLAYER_SPELL_COUNT:
                    case AnonymousEnum.INFO_CURRENT_LIFE:
                    case AnonymousEnum.INFO_CURRENT_LIFE_MAX:
                        return new value(machine.get_engine().get_real_type(), (double)0);
                    case AnonymousEnum.INFO_ACTIVE_STEP_LIFE_RATE_LIST:
                        return script.CreateRealArrayValue(new List<double>());

                }
                return new value();
            }

            ref_count_ptr<StgEnemyBossSceneData>.unsync sceneData = obj.GetActiveData();
            switch (type)
            {
                case AnonymousEnum.INFO_IS_SPELL:
                {
                    bool res = false;
                    if (sceneData != null)
                    {
                        res = sceneData.IsSpellCard();
                    }
                        return new value(machine.get_engine().get_boolean_type(), res);
                }
                case AnonymousEnum.INFO_IS_LAST_SPELL:
                {
                    bool res = false;
                    if (sceneData != null)
                    {
                        res = sceneData.IsLastSpell();
                    }
                        return new value(machine.get_engine().get_boolean_type(), res);
                }
                case AnonymousEnum.INFO_IS_DURABLE_SPELL:
                {
                    bool res = false;
                    if (sceneData != null)
                    {
                        res = sceneData.IsDurable();
                    }
                    return new value(machine.get_engine().get_boolean_type(), res);
                }
                case AnonymousEnum.INFO_TIMER:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        int timer = sceneData.GetSpellTimer();
                        if (timer < 0)
                        {
                            res = 99;
                        }
                        else
                        {
                            res = timer / GlobalMembers.STANDARD_FPS;
                        }
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_TIMERF:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        res = sceneData.GetSpellTimer();
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_ORGTIMERF:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        res = sceneData.GetOriginalSpellTimer();
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_SPELL_SCORE:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        res = sceneData.GetCurrentSpellScore();
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_REMAIN_STEP_COUNT:
                    return script.CreateRealValue(obj.GetRemainStepCount());
                case AnonymousEnum.INFO_ACTIVE_STEP_LIFE_COUNT:
                    return script.CreateRealValue(obj.GetActiveStepLifeCount());
                case AnonymousEnum.INFO_ACTIVE_STEP_TOTAL_MAX_LIFE:
                    return script.CreateRealValue(obj.GetActiveStepTotalMaxLife());
                case AnonymousEnum.INFO_ACTIVE_STEP_TOTAL_LIFE:
                    return script.CreateRealValue(obj.GetActiveStepTotalLife());
                case AnonymousEnum.INFO_ACTIVE_STEP_LIFE_RATE_LIST:
                {
                    List<double> listLD = new List<double>();
                    List<double> listD = obj.GetActiveStepLifeRateList();
                    for (int iLife = 0 ; iLife < listD.Count ; iLife++)
                    {
                        listLD.Add(listD[iLife]);
                    }
                    return script.CreateRealArrayValue(listLD);
                }
                case AnonymousEnum.INFO_IS_LAST_STEP:
                {
                    bool res = obj.GetRemainStepCount() == 0;
                    res &= (obj.GetActiveStepTotalLife() == 0);
                    return new value(machine.get_engine().get_boolean_type(), res);
                }
                case AnonymousEnum.INFO_PLAYER_SHOOTDOWN_COUNT:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        res = sceneData.GetPlayerShootDownCount();
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_PLAYER_SPELL_COUNT:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        res = sceneData.GetPlayerSpellCount();
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_CURRENT_LIFE:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        int dataIndex = obj.GetDataIndex();
                        res = obj.GetActiveStepLife(dataIndex);
                    }
                    return script.CreateRealValue(res);
                }
                case AnonymousEnum.INFO_CURRENT_LIFE_MAX:
                {
                    double res = 0;
                    if (sceneData != null)
                    {
                        int dataIndex = obj.GetDataIndex();
                        List<double> listLife = sceneData.GetLifeList();
                        for (int iLife = 0 ; iLife < listLife.Count; iLife++)
                        {
                            res += listLife[iLife];
                        }
                    }
                    return script.CreateRealValue(res);
                }

            }

            return new value();
        }

        public static gstd.value Func_ObjEnemyBossScene_SetSpellTimer(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyBossSceneObject obj = script.GetObjectPointer(id) as StgEnemyBossSceneObject;
            if (obj == null)
            {
                return new value();
            }
            ref_count_ptr<StgEnemyBossSceneData>.unsync sceneData = obj.GetActiveData();
            if (sceneData == null)
            {
                return new value();
            }

            int timer = (int)argv[1].as_real();
            sceneData.SetSpellTimer(timer);
            return new value();
        }

        public static gstd.value Func_ObjEnemyBossScene_StartSpell(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgEnemyBossSceneObject obj = script.GetObjectPointer(id) as StgEnemyBossSceneObject;
            if (obj == null)
            {
                return new value();
            }
            ref_count_ptr<StgEnemyBossSceneData>.unsync sceneData = obj.GetActiveData();
            if (sceneData == null)
            {
                return new value();
            }

            sceneData.SetSpellCard(true);
            ScriptManager scriptManager = script.scriptManager_;
            scriptManager.RequestEventAll(AnonymousEnum.EV_START_BOSS_SPELL);
            return new value();
        }

        // STG���ʊ֐��F�e�I�u�W�F�N�g����

        // STG���ʊ֐��F�e�I�u�W�F�N�g����
        public static gstd.value Func_ObjShot_Create(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            script.CheckRunInMainThread();
            StgStageController stageController = script.stageController_;

            int type = (int)argv[0].as_real();
            ref_count_ptr<StgShotObject>.unsync obj = new ref_count_ptr<StgShotObject>.unsync();
            if (type == (int)AnonymousEnum.OBJ_SHOT)
            {
                obj = new StgNormalShotObject(stageController);
            }
            else if (type == (int)AnonymousEnum.OBJ_LOOSE_LASER)
            {
                obj = new StgLooseLaserObject(stageController);
            }
            else if (type == (int)AnonymousEnum.OBJ_STRAIGHT_LASER)
            {
                obj = new StgStraightLaserObject(stageController);
            }
            else if (type == (int)AnonymousEnum.OBJ_CURVE_LASER)
            {
                obj = new StgCurveLaserObject(stageController);
            }

            int id = ID_INVALID;
            if (obj != null)
            {
                int typeOwner = script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER ? StgShotObject.OWNER_PLAYER : StgShotObject.OWNER_ENEMY;
                obj.SetOwnerType(typeOwner);

                obj.SetObjectManager(script.objManager_.GetPointer());
                id = script.AddObject(obj, false);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_ObjShot_Regist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();

            ref_count_ptr<StgShotObject>.unsync objShot = new ref_count_ptr<StgShotObject>.unsync(stageController.GetMainRenderObject(id));
            if (objShot != null)
            {
                if (script.GetScriptType() == (int)AnonymousEnum.TYPE_PLAYER)
                {
                    ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
                    if (objPlayer != null && !objPlayer.IsPermitShot())
                    {
                        return new value();
                    }
                }

                StgShotManager shotManager = stageController.GetShotManager();
                shotManager.AddShot(new ref_count_ptr<StgShotObject>.unsync(objShot));
                objShot.Activate();

                script.ActivateObject(objShot.GetObjectID(), true);
            }

            return new value();
        }

        public static gstd.value Func_ObjShot_SetAutoDelete(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool bAutoDelete = argv[1].as_boolean();
            obj.SetAutoDelete(bAutoDelete);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetDeleteFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            obj.SetAutoDeleteFrame(frame);

            return new value();
        }

        public static gstd.value Func_ObjShot_FadeDelete(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            obj.SetFadeDelete();

            return new value();
        }

        public static gstd.value Func_ObjShot_SetDelay(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int delay = (int)argv[1].as_real();
            obj.SetDelay(delay);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetSpellResist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool bRegist = argv[1].as_boolean();
            double life = obj.GetLife();
            if (bRegist)
            {
                life = StgShotObject.LIFE_SPELL_REGIST;
            }
            else
            {
                if (life >= StgShotObject.LIFE_SPELL_UNREGIST)
                {
                    life = StgShotObject.LIFE_SPELL_UNREGIST;
                }
            }
            obj.SetLife(life);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetGraphic(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int grf = (int)argv[1].as_real();
            obj.SetShotDataID(grf);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetSourceBlendType(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int typeBlend = (int)argv[1].as_real();
            obj.SetSourceBlendType(typeBlend);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetDamage(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            double damage = argv[1].as_real();
            obj.SetDamage(damage);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetPenetration(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            double life = argv[1].as_real();
            obj.SetLife(life);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetEraseShot(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool bErase = argv[1].as_boolean();
            obj.SetEraseShot(bErase);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetSpellFactor(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool bErase = argv[1].as_boolean();
            obj.SetSpellFactor(bErase);

            return new value();
        }

        public static gstd.value Func_ObjShot_ToItem(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            obj.ConvertToItem();

            return new value();
        }

        public static gstd.value Func_ObjShot_AddShotA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int idShot = (int)argv[1].as_real();
            int frame = (int)argv[2].as_real();
            obj.AddShot(frame, idShot, 0, 0);
            return new value();
        }

        public static gstd.value Func_ObjShot_AddShotA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int idShot = (int)argv[1].as_real();
            int frame = (int)argv[2].as_real();
            double radius = argv[3].as_real();
            double angle = argv[4].as_real();
            obj.AddShot(frame, idShot, (int)radius, (int)angle);
            return new value();
        }

        public static gstd.value Func_ObjShot_SetIntersectionCircleA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            ref_count_ptr<StgShotObject>.unsync obj = new ref_count_ptr<StgShotObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }
            if (obj.GetDelay() > 0)
            {
                return new value();
            }

            obj.SetUserIntersectionMode(true);
            int typeTarget = obj.GetOwnerType() == StgShotObject.OWNER_PLAYER ? StgIntersectionTarget.TYPE_PLAYER_SHOT : StgIntersectionTarget.TYPE_ENEMY_SHOT;

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px = (int)obj.GetPositionX();
            int py = (int)obj.GetPositionY();
            int radius = (int)argv[1].as_real();
            DxCircle circle = new DxCircle(px, py, radius);
            ref_count_weak_ptr<StgShotObject>.unsync wObj = obj;

            // �����蔻��
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(typeTarget);
            target.SetCircle(circle);
            target.SetObject(wObj);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target));

            return new value();
        }

        public static gstd.value Func_ObjShot_SetIntersectionCircleA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            ref_count_ptr<StgShotObject>.unsync obj = new ref_count_ptr<StgShotObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }
            if (obj.GetDelay() > 0)
            {
                return new value();
            }

            obj.SetUserIntersectionMode(true);
            int typeTarget = obj.GetOwnerType() == StgShotObject.OWNER_PLAYER ? StgIntersectionTarget.TYPE_PLAYER_SHOT : StgIntersectionTarget.TYPE_ENEMY_SHOT;

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            int radius = (int)argv[3].as_real();
            DxCircle circle = new DxCircle(px, py, radius);
            ref_count_weak_ptr<StgShotObject>.unsync wObj = obj;

            // �����蔻��
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(typeTarget);
            target.SetCircle(circle);
            target.SetObject(wObj);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target));

            return new value();
        }

        public static gstd.value Func_ObjShot_SetIntersectionLine(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgShotObject>.unsync obj = new ref_count_ptr<StgShotObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }
            if (obj.GetDelay() > 0)
            {
                return new value();
            }

            obj.SetUserIntersectionMode(true);
            int typeTarget = obj.GetOwnerType() == StgShotObject.OWNER_PLAYER ? StgIntersectionTarget.TYPE_PLAYER_SHOT : StgIntersectionTarget.TYPE_ENEMY_SHOT;

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px1 = (int)argv[1].as_real();
            int py1 = (int)argv[2].as_real();
            int px2 = (int)argv[3].as_real();
            int py2 = (int)argv[4].as_real();
            int width = (int)argv[5].as_real();
            DxWidthLine line = new DxWidthLine(px1, py1, px2, py2, width);

            // �����蔻��
            ref_count_weak_ptr<StgShotObject>.unsync wObjShot = obj;
            ref_count_ptr<StgIntersectionTarget_Line>.unsync target = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_LINE));
            target.SetTargetType(typeTarget);
            target.SetObject(wObjShot);
            target.SetLine(line);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Line>.unsync(target));

            return new value();
        }

        public static gstd.value Func_ObjShot_SetIntersectionEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool bEnable = argv[1].as_boolean();
            obj.SetIntersectionEnable(bEnable);

            return new value();
        }

        public static gstd.value Func_ObjShot_SetItemChange(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool bEnable = argv[1].as_boolean();
            obj.SetItemChangeEnable(bEnable);

            return new value();
        }

        public static gstd.value Func_ObjShot_GetDelay(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int res = obj.GetDelay();
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_ObjShot_GetDamage(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int res = (int)obj.GetDamage();
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_ObjShot_GetPenetration(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int res = (int)obj.GetLife();
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_ObjShot_IsSpellResist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            bool res = obj.GetLife() == StgShotObject.LIFE_SPELL_REGIST;
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_ObjShot_GetImageID(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;
            int id = (int)argv[0].as_real();
            StgShotObject obj = script.GetObjectPointer(id) as StgShotObject;
            if (obj == null)
            {
                return new value();
            }

            int res = obj.GetShotDataID();
            return new value(machine.get_engine().get_real_type(), (double)res);
        }

        public static gstd.value Func_ObjLaser_SetLength(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return new value();
            }

            int length = (int)argv[1].as_real();
            obj.SetLength(length);

            return new value();
        }

        public static gstd.value Func_ObjLaser_SetRenderWidth(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return new value();
            }

            int width = (int)argv[1].as_real();
            obj.SetRenderWidth(width);

            return new value();
        }

        public static gstd.value Func_ObjLaser_SetIntersectionWidth(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return new value();
            }

            int width = (int)argv[1].as_real() / 2;
            obj.SetIntersectionWidth(width);

            return new value();
        }

        public static gstd.value Func_ObjLaser_SetInvalidLength(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return new value();
            }

            int start = (int)argv[1].as_real();
            int end = (int)argv[2].as_real();
            obj.SetInvalidLength(start, end);

            return new value();
        }

        public static gstd.value Func_ObjLaser_SetGrazeInvalidFrame(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return new value();
            }

            int frame = (int)argv[1].as_real();
            obj.SetGrazeInvalidFrame(frame);

            return new value();
        }

        public static gstd.value Func_ObjLaser_SetItemDistance(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return new value();
            }

            double dist = argv[1].as_real();
            obj.SetItemDistance(dist);

            return new value();
        }

        public static gstd.value Func_ObjLaser_GetLength(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return script.CreateRealValue(0);
            }

            int length = obj.GetLength();
            return new value(machine.get_engine().get_real_type(), (double)length);
        }

        public static gstd.value Func_ObjLaser_GetRenderWidth(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return script.CreateRealValue(0);
            }

            int width = obj.GetRenderWidth();
            return new value(machine.get_engine().get_real_type(), (double)width);
        }

        public static gstd.value Func_ObjLaser_GetIntersectionWidth(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgLaserObject obj = script.GetObjectPointer(id) as StgLaserObject;
            if (obj == null)
            {
                return script.CreateRealValue(0);
            }

            int width = obj.GetIntersectionWidth();
            return new value(machine.get_engine().get_real_type(), (double)width);
        }

        public static gstd.value Func_ObjStLaser_SetAngle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgStraightLaserObject obj = script.GetObjectPointer(id) as StgStraightLaserObject;
            if (obj == null)
            {
                return new value();
            }

            double angle = argv[1].as_real();
            obj.SetLaserAngle(angle);

            return new value();
        }

        public static gstd.value Func_ObjStLaser_GetAngle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgStraightLaserObject obj = script.GetObjectPointer(id) as StgStraightLaserObject;
            if (obj == null)
            {
                return script.CreateRealValue(0);
            }

            double angle = obj.GetLaserAngle();
            return new value(machine.get_engine().get_real_type(), (double)angle);
        }

        public static gstd.value Func_ObjStLaser_SetSource(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgStraightLaserObject obj = script.GetObjectPointer(id) as StgStraightLaserObject;
            if (obj == null)
            {
                return new value();
            }

            bool bEnable = argv[1].as_boolean();
            obj.SetSourceEnable(bEnable);

            return new value();
        }

        public static gstd.value Func_ObjCrLaser_SetTipDecrement(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgCurveLaserObject obj = script.GetObjectPointer(id) as StgCurveLaserObject;
            if (obj == null)
            {
                return new value();
            }

            double dec = argv[1].as_real();
            dec = System.Math.Min(dec, 1);
            dec = System.Math.Max(dec, 0);
            obj.SetTipDecrement(dec);

            return new value();
        }

        // STG���ʊ֐��F�A�C�e���I�u�W�F�N�g����

        // STG���ʊ֐��F�A�C�e���I�u�W�F�N�g����
        public static gstd.value Func_ObjItem_Create(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            script.CheckRunInMainThread();
            StgStageController stageController = script.stageController_;

            int type = (int)argv[0].as_real();
            ref_count_ptr<StgItemObject>.unsync obj = new ref_count_ptr<StgItemObject>.unsync();
            if (type == StgItemObject.ITEM_USER)
            {
                obj = new StgItemObject_User(stageController);
            }

            int id = ID_INVALID;
            if (obj != null)
            {
                obj.SetObjectManager(script.objManager_.GetPointer());
                id = script.AddObject(obj, false);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_ObjItem_Regist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();

            ref_count_ptr<StgItemObject>.unsync objItem = new ref_count_ptr<StgItemObject>.unsync(stageController.GetMainRenderObject(id));
            if (objItem != null)
            {
                StgItemManager itemManager = stageController.GetItemManager();
                itemManager.AddItem(new ref_count_ptr<StgItemObject>.unsync(objItem));
                objItem.Activate();

                script.ActivateObject(objItem.GetObjectID(), true);
            }

            return new value();
        }

        public static gstd.value Func_ObjItem_SetItemID(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgItemObject_User obj = script.GetObjectPointer(id) as StgItemObject_User;
            if (obj == null)
            {
                return new value();
            }

            int grf = (int)argv[1].as_real();
            obj.SetImageID(grf);

            return new value();
        }

        public static gstd.value Func_ObjItem_SetRenderScoreEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgItemObject obj = script.GetObjectPointer(id) as StgItemObject;
            if (obj == null)
            {
                return new value();
            }

            bool bEnable = (bool)argv[1].as_boolean();
            obj.SetChangeItemScore(bEnable);

            return new value();
        }

        public static gstd.value Func_ObjItem_SetAutoCollectEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgItemObject obj = script.GetObjectPointer(id) as StgItemObject;
            if (obj == null)
            {
                return new value();
            }

            bool bEnable = (bool)argv[1].as_boolean();
            obj.SetPermitMoveToPlayer(bEnable);

            return new value();
        }

        public static gstd.value Func_ObjItem_SetDefinedMovePatternA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageScript script = (StgStageScript)machine.data;
            int id = (int)argv[0].as_real();
            StgItemObject obj = script.GetObjectPointer(id) as StgItemObject;
            if (obj == null)
            {
                return new value();
            }

            int type = (int)argv[1].as_real();
            ref_count_ptr<StgMovePattern_Item>.unsync move = new StgMovePattern_Item(obj);
            move.SetItemMoveType(type);
            obj.SetPattern(new ref_count_ptr<StgMovePattern_Item>.unsync(move));

            return new value();
        }

        public static gstd.value Func_ObjItem_GetInfo(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            int type = (int)argv[1].as_real();

            StgItemObject obj = script.GetObjectPointer(id) as StgItemObject;
            if (obj == null)
            {
                switch (type)
                {
                    case AnonymousEnum.INFO_ITEM_SCORE:
                        return new value(machine.get_engine().get_real_type(), (double)0);
                }
                return new value();
            }

            switch (type)
            {
                case AnonymousEnum.INFO_ITEM_SCORE:
                    return new value(machine.get_engine().get_real_type(), (double)obj.GetScore());
            }

            return new value();
        }

        // STG���ʊ֐��F���@�I�u�W�F�N�g����

        // STG���ʊ֐��F���@�I�u�W�F�N�g����
        public static gstd.value Func_ObjPlayer_AddIntersectionCircleA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerObject>.unsync obj = new ref_count_ptr<StgPlayerObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            double rHit = argv[3].as_real();
            double rGraze = argv[4].as_real();

            DxCircle circle = new DxCircle(px, py, rHit);

            // �����蔻��
            ref_count_weak_ptr<StgPlayerObject>.unsync wObj = obj;
            ref_count_ptr<StgIntersectionTarget_Player>.unsync targetHit = new StgIntersectionTarget_Player(false);
            targetHit.SetObject(wObj);
            targetHit.SetCircle(circle);
            obj.AddIntersectionRelativeTarget(targetHit);

            // Graze����
            circle.SetR(rHit + rGraze);
            ref_count_ptr<StgIntersectionTarget_Player>.unsync targetGraze = new StgIntersectionTarget_Player(true);
            targetGraze.SetObject(wObj);
            targetGraze.SetCircle(circle);
            obj.AddIntersectionRelativeTarget(targetGraze);

            return new value();
        }

        public static gstd.value Func_ObjPlayer_AddIntersectionCircleA2(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerObject>.unsync obj = new ref_count_ptr<StgPlayerObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            double rGraze = argv[3].as_real();

            DxCircle circle = new DxCircle(px, py, 0);

            // Graze����
            ref_count_weak_ptr<StgPlayerObject>.unsync wObj = obj;
            circle.SetR(rGraze);
            ref_count_ptr<StgIntersectionTarget_Player>.unsync targetGraze = new StgIntersectionTarget_Player(true);
            targetGraze.SetObject(wObj);
            targetGraze.SetCircle(circle);
            obj.AddIntersectionRelativeTarget(targetGraze);

            return new value();
        }

        public static gstd.value Func_ObjPlayer_ClearIntersection(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerObject>.unsync obj = new ref_count_ptr<StgPlayerObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }
            obj.ClearIntersectionRelativeTarget();

            return new value();
        }


        // STG���ʊ֐��F�����蔻��I�u�W�F�N�g����

        // STG���ʊ֐��F�����蔻��I�u�W�F�N�g����
        public static gstd.value Func_ObjCol_IsIntersected(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            DxScriptObjectBase objBase = script.GetObjectPointer(id) as DxScriptObjectBase;
            if (objBase == null)
            {
                return new value();
            }

            ref_count_ptr<StgIntersectionObject>.unsync obj = new ref_count_ptr<StgIntersectionObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            bool res = obj.IsIntersected();
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_ObjCol_GetListOfIntersectedEnemyID(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            DxScriptObjectBase objBase = script.GetObjectPointer(id) as DxScriptObjectBase;
            if (objBase == null)
            {
                return new value();
            }

            ref_count_ptr<StgIntersectionObject>.unsync obj = new ref_count_ptr<StgIntersectionObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value();
            }

            List<int> list = obj.GetIntersectedIdList();
            List<double> listLD = new List<double>();
            for (int iList = 0 ; iList < list.Count ; iList++)
            {
                int idObject = list[iList];
                ref_count_ptr<StgEnemyObject>.unsync objEnemy = new ref_count_ptr<StgEnemyObject>.unsync(script.GetObject(idObject));
                if (objEnemy != null)
                {
                    listLD.Add(idObject);
                }
            }

            gstd.value res = script.CreateRealArrayValue(listLD);
            return new gstd.value(res);
        }

        public static gstd.value Func_ObjCol_GetIntersectedCount(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            DxScript script = (DxScript)machine.data;
            int id = (int)argv[0].as_real();
            ref_count_ptr<StgIntersectionObject>.unsync obj = new ref_count_ptr<StgIntersectionObject>.unsync(script.GetObject(id));
            if (obj == null)
            {
                return new value(machine.get_engine().get_real_type(), (double)0);
            }

            List<int> list = obj.GetIntersectedIdList();
            double res = list.Count;
            return new value(machine.get_engine().get_real_type(), res);
        }
}


/**********************************************************
//StgSystemScript
**********************************************************/
public class StgStageSystemScript : StgStageScript
{
        public StgStageSystemScript(StgStageController stageController) : base(stageController)
        {
            typeScript_ = TYPE_SYSTEM;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgSystemFunction, sizeof(stgSystemFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgSystemFunction, GlobalMembers.stgSystemFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        // �V�X�e����p�֐��F�V�X�e������

}

/**********************************************************
//StgStageItemScript
**********************************************************/
public class StgStageItemScript : StgStageScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            EV_GET_ITEM = 1100
        }
        public StgStageItemScript(StgStageController stageController) : base(stageController)
        {
            typeScript_ = TYPE_ITEM;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgItemFunction, sizeof(stgItemFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgItemFunction, GlobalMembers.stgItemFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        // �V�X�e����p�֐��F�A�C�e������

}

/**********************************************************
//StgStageShotScript
**********************************************************/
public class StgStageShotScript : StgStageScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {

        }
        public StgStageShotScript(StgStageController stageController) : base(stageController)
        {
            typeScript_ = TYPE_SHOT;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgShotFunction, sizeof(stgShotFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgShotFunction, GlobalMembers.stgShotFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        // �V�X�e����p�֐��F�A�C�e������
        public static gstd.value Func_SetShotDeleteEventEnable(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStageShotScript script = (StgStageShotScript)machine.data;
            int type = (int)argv[0].as_real();
            bool bEnable = argv[1].as_boolean();

            StgStageController stageController = script.stageController_;
            StgShotManager shotManager = stageController.GetShotManager();
            shotManager.SetDeleteEventEnableByType(type, bEnable);

            return new value();
        }

}


/**********************************************************
//StgStagePlayerScript
**********************************************************/
public class StgStagePlayerScript : StgStageScript
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum4
        {
            EV_REQUEST_SPELL = 1000,
            EV_GRAZE,
            EV_HIT
        }
        public StgStagePlayerScript(StgStageController stageController) : base(stageController)
        {
            typeScript_ = TYPE_PLAYER;
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(stgPlayerFunction, sizeof(stgPlayerFunction) / sizeof(function));
            _AddFunction(GlobalMembers.stgPlayerFunction, GlobalMembers.stgPlayerFunction.Length);
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        // ���@��p�֐�

        // ���@��p�֐�
        public static gstd.value Func_CreatePlayerShotA1(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
            if (objPlayer != null && !objPlayer.IsPermitShot())
            {
                return new value();
            }

            ref_count_ptr<StgNormalShotObject>.unsync obj = new StgNormalShotObject(stageController);
            obj.SetObjectManager(script.objManager_.GetPointer());
            int id = script.AddObject(obj);
            if (id != ID_INVALID)
            {
                stageController.GetShotManager().AddShot(new ref_count_ptr<StgNormalShotObject>.unsync(obj));
                double posX = argv[0].as_real();
                double posY = argv[1].as_real();
                double speed = argv[2].as_real();
                double angle = argv[3].as_real();
                double damage = (double)argv[4].as_real();
                double life = (double)argv[5].as_real();
                int idShot = (int)argv[6].as_real();

                obj.SetOwnerType(StgShotObject.OWNER_PLAYER);
                obj.SetX(posX);
                obj.SetY(posY);
                obj.SetSpeed(speed);
                obj.SetDirectionAngle(angle);
                obj.SetLife(life);
                obj.SetDamage(damage);
                obj.SetShotDataID(idShot);
            }

            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_CallSpell(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
            if (objPlayer == null)
            {
                return new value();
            }

            objPlayer.CallSpell();

            return new value();
        }

        public static gstd.value Func_LoadPlayerShotData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgShotManager shotManager = stageController.GetShotManager();

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            bool res = shotManager.LoadPlayerShotData(path);
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_ReloadPlayerShotData(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;
            StgShotManager shotManager = stageController.GetShotManager();

            string path = argv[0].as_string();
            path = PathProperty.GetUnique(path);

            bool res = shotManager.LoadPlayerShotData(path, true);
            return new value(machine.get_engine().get_boolean_type(), res);
        }

        public static gstd.value Func_GetSpellManageObject(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgPlayerObject>.unsync obj = stageController.GetPlayerObject();
            int id = ID_INVALID;
            if (obj != null)
            {
                ref_count_ptr<StgPlayerSpellManageObject>.unsync objManage = obj.GetSpellManageObject();
                if (objManage != null)
                {
                    id = objManage.GetObjectID();
                }
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        // ���@��p�֐��F�X�y���I�u�W�F�N�g����

        // ���@��p�֐��F�X�y���I�u�W�F�N�g����
        public static gstd.value Func_ObjSpell_Create(gstd.script_machine machine, int argc, gstd.value argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            script.CheckRunInMainThread();
            StgStageController stageController = script.stageController_;

            ref_count_ptr<StgPlayerSpellObject>.unsync obj = new StgPlayerSpellObject(stageController);

            int id = ID_INVALID;
            if (obj != null)
            {
                obj.SetObjectManager(script.objManager_.GetPointer());
                id = script.AddObject(obj, false);
            }
            return new value(machine.get_engine().get_real_type(), (double)id);
        }

        public static gstd.value Func_ObjSpell_Regist(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerSpellObject>.unsync objSpell = new ref_count_ptr<StgPlayerSpellObject>.unsync(stageController.GetMainRenderObject(id));
            if (objSpell != null)
            {
                script.ActivateObject(objSpell.GetObjectID(), true);
            }

            return new value();
        }

        public static gstd.value Func_ObjSpell_SetDamage(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerSpellObject>.unsync objSpell = new ref_count_ptr<StgPlayerSpellObject>.unsync(stageController.GetMainRenderObject(id));
            if (objSpell == null)
            {
                return new value();
            }

            double damage = argv[1].as_real();
            objSpell.SetDamage(damage);
            return new value();
        }

        public static gstd.value Func_ObjSpell_SetPenetration(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerSpellObject>.unsync objSpell = new ref_count_ptr<StgPlayerSpellObject>.unsync(stageController.GetMainRenderObject(id));
            if (objSpell == null)
            {
                return new value();
            }

            double life = argv[1].as_real();
            objSpell.SetLife(life);
            return new value();
        }

        public static gstd.value Func_ObjSpell_SetEraseShot(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();
            ref_count_ptr<StgPlayerSpellObject>.unsync objSpell = new ref_count_ptr<StgPlayerSpellObject>.unsync(stageController.GetMainRenderObject(id));
            if (objSpell == null)
            {
                return new value();
            }

            bool bEraseShot = argv[1].as_boolean();
            objSpell.SetEraseShot(bEraseShot);
            return new value();
        }

        public static gstd.value Func_ObjSpell_SetIntersectionCircle(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();

            ref_count_ptr<StgPlayerSpellObject>.unsync objSpell = new ref_count_ptr<StgPlayerSpellObject>.unsync(stageController.GetMainRenderObject(id));
            if (objSpell == null)
            {
                return new value();
            }

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px = (int)argv[1].as_real();
            int py = (int)argv[2].as_real();
            int radius = (int)argv[3].as_real();
            DxCircle circle = new DxCircle(px, py, radius);

            // �����蔻��
            ref_count_weak_ptr<StgPlayerSpellObject>.unsync wObjSpell = objSpell;
            ref_count_ptr<StgIntersectionTarget_Circle>.unsync target = new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_CIRCLE));
            target.SetTargetType(StgIntersectionTarget.TYPE_PLAYER_SPELL);
            target.SetObject(wObjSpell);
            target.SetCircle(circle);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Circle>.unsync(target));

            return new value();
        }

        public static gstd.value Func_ObjSpell_SetIntersectionLine(gstd.script_machine machine, int argc, gstd.value[] argv)
        {
            StgStagePlayerScript script = (StgStagePlayerScript)machine.data;
            StgStageController stageController = script.stageController_;

            int id = (int)argv[0].as_real();

            ref_count_ptr<StgPlayerSpellObject>.unsync objSpell = new ref_count_ptr<StgPlayerSpellObject>.unsync(stageController.GetMainRenderObject(id));
            if (objSpell == null)
            {
                return new value();
            }

            StgIntersectionManager intersectionManager = stageController.GetIntersectionManager();
            int px1 = (int)argv[1].as_real();
            int py1 = (int)argv[2].as_real();
            int px2 = (int)argv[3].as_real();
            int py2 = (int)argv[4].as_real();
            int width = (int)argv[5].as_real();
            DxWidthLine line = new DxWidthLine(px1, py1, px2, py2, width);

            // �����蔻��
            ref_count_weak_ptr<StgPlayerSpellObject>.unsync wObjSpell = objSpell;
            ref_count_ptr<StgIntersectionTarget_Line>.unsync target = new ref_count_ptr<StgIntersectionTarget_Line>.unsync(intersectionManager.GetPoolObject(StgIntersectionTarget.SHAPE_LINE));
            target.SetTargetType(StgIntersectionTarget.TYPE_PLAYER_SPELL);
            target.SetObject(wObjSpell);
            target.SetLine(line);

            intersectionManager.AddTarget(new ref_count_ptr<StgIntersectionTarget_Line>.unsync(target));

            return new value();
        }

}