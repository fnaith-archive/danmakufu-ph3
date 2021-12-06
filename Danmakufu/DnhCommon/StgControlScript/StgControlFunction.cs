/*using System;
using System.Text;
using System.Collections.Generic;
using Gstd.GstdUtility;*/
using Gstd.Script;
//using Gstd.Logger;

namespace Common.StgControlScript
{
    sealed class StgControlFunction
    {
        public static Function[] stgControlFunction = {/*
            //�֐��F
            //STG���䋤�ʊ֐��F���ʃf�[�^
            new Function("SaveCommonDataAreaA1", new Callback(Func_SaveCommonDataAreaA1), 1),
            new Function("LoadCommonDataAreaA1", new Callback(Func_LoadCommonDataAreaA1), 1),
            new Function("SaveCommonDataAreaA2", new Callback(Func_SaveCommonDataAreaA2), 2),
            new Function("LoadCommonDataAreaA2", new Callback(Func_LoadCommonDataAreaA2), 2),

            //STG���䋤�ʊ֐��F�L�[�n
            new Function("AddVirtualKey", new Callback(Func_AddVirtualKey), 3),
            new Function("AddReplayTargetVirtualKey", new Callback(Func_AddReplayTargetVirtualKey), 1),
            new Function("SetSkipModeKey", new Callback(Func_SetSkipModeKey), 1),

            //STG���䋤�ʊ֐��F�V�X�e���֘A
            new Function("GetScore", new Callback(Func_GetScore), 0),
            new Function("AddScore", new Callback(Func_AddScore), 1),
            new Function("GetGraze", new Callback(Func_GetGraze), 0),
            new Function("AddGraze", new Callback(Func_AddGraze), 1),
            new Function("GetPoint", new Callback(Func_GetPoint), 0),
            new Function("AddPoint", new Callback(Func_AddPoint), 1),
            new Function("IsReplay", new Callback(Func_IsReplay), 0),
            new Function("AddArchiveFile", new Callback(Func_AddArchiveFile), 1),
            new Function("GetCurrentFps", new Callback(Func_GetCurrentFps), 0),
            new Function("GetStageTime", new Callback(Func_GetStageTime), 0),
            new Function("GetStageTimeF", new Callback(Func_GetStageTimeF), 0),
            new Function("GetPackageTime", new Callback(Func_GetPackageTime), 0),

            new Function("GetStgFrameLeft", new Callback(Func_GetStgFrameLeft), 0),
            new Function("GetStgFrameTop", new Callback(Func_GetStgFrameTop), 0),
            new Function("GetStgFrameWidth", new Callback(Func_GetStgFrameWidth), 0),
            new Function("GetStgFrameHeight", new Callback(Func_GetStgFrameHeight), 0),

            new Function("GetMainPackageScriptPath", new Callback(Func_GetMainPackageScriptPath), 0),
            new Function("GetScriptPathList", new Callback(Func_GetScriptPathList), 2),
            new Function("GetScriptInfoA1", new Callback(Func_GetScriptInfoA1), 2),

            //STG���ʊ֐��F�`��֘A
            new Function("ClearInvalidRenderPriority", new Callback(Func_ClearInvalidRenderPriority), 0),
            new Function("SetInvalidRenderPriorityA1", new Callback(Func_SetInvalidRenderPriorityA1), 2),
            new Function("GetReservedRenderTargetName", new Callback(Func_GetReservedRenderTargetName), 1),
            new Function("RenderToTextureA1", new Callback(Func_RenderToTextureA1), 4),
            new Function("RenderToTextureB1", new Callback(Func_RenderToTextureB1), 3),
            new Function("SaveSnapShotA1", new Callback(Func_SaveSnapShotA1), 1),
            new Function("SaveSnapShotA2", new Callback(Func_SaveSnapShotA2), 5),

            //STG���䋤�ʊ֐��F���@�֘A
            new Function("GetPlayerID", new Callback(Func_GetPlayerID), 0),
            new Function("GetPlayerReplayName", new Callback(Func_GetPlayerReplayName), 0),

            //STG���䋤�ʊ֐��F���[�U�X�N���v�g
            new Function("SetPauseScriptPath", new Callback(Func_SetPauseScriptPath), 1),
            new Function("SetEndSceneScriptPath", new Callback(Func_SetEndSceneScriptPath), 1),
            new Function("SetReplaySaveSceneScriptPath", new Callback(Func_SetReplaySaveSceneScriptPath), 1),

            //STG���䋤�ʊ֐��F���@�X�N���v�g
            new Function("GetLoadFreePlayerScriptList", new Callback(Func_GetLoadFreePlayerScriptList), 0),
            new Function("GetFreePlayerScriptCount", new Callback(Func_GetFreePlayerScriptCount), 0),
            new Function("GetFreePlayerScriptInfo", new Callback(Func_GetFreePlayerScriptInfo), 2),

            //STG���䋤�ʊ֐��F���v���C�֘A
            new Function("LoadReplayList", new Callback(Func_LoadReplayList), 0),
            new Function("GetValidReplayIndices", new Callback(Func_GetValidReplayIndices), 0),
            new Function("IsValidReplayIndex", new Callback(Func_IsValidReplayIndex), 1),
            new Function("GetReplayInfo", new Callback(Func_GetReplayInfo), 2),
            new Function("SetReplayInfo", new Callback(Func_SetReplayInfo), 2),
            new Function("GetReplayUserData", new Callback(Func_GetReplayUserData), 2),
            new Function("SetReplayUserData", new Callback(Func_SetReplayUserData), 2),
            new Function("IsReplayUserDataExists", new Callback(Func_IsReplayUserDataExists), 2),
            new Function("SaveReplay", new Callback(Func_SaveReplay), 2),

            //�萔�F
            new Function("EV_USER_COUNT"), constant<StgControlScript::EV_USER_COUNT>::func), 0),
            new Function("EV_USER"), constant<StgControlScript::EV_USER>::func), 0),
            new Function("EV_USER_SYSTEM"), constant<StgControlScript::EV_USER_SYSTEM>::func), 0),
            new Function("EV_USER_STAGE"), constant<StgControlScript::EV_USER_STAGE>::func), 0),
            new Function("EV_USER_PLAYER"), constant<StgControlScript::EV_USER_PLAYER>::func), 0),
            new Function("EV_USER_PACKAGE"), constant<StgControlScript::EV_USER_PACKAGE>::func), 0),

            new Function("TYPE_SCRIPT_ALL"), constant<StgControlScript::TYPE_SCRIPT_ALL>::func), 0),
            new Function("TYPE_SCRIPT_PLAYER"), constant<StgControlScript::TYPE_SCRIPT_PLAYER>::func), 0),
            new Function("TYPE_SCRIPT_SINGLE"), constant<StgControlScript::TYPE_SCRIPT_SINGLE>::func), 0),
            new Function("TYPE_SCRIPT_PLURAL"), constant<StgControlScript::TYPE_SCRIPT_PLURAL>::func), 0),
            new Function("TYPE_SCRIPT_STAGE"), constant<StgControlScript::TYPE_SCRIPT_STAGE>::func), 0),
            new Function("TYPE_SCRIPT_PACKAGE"), constant<StgControlScript::TYPE_SCRIPT_PACKAGE>::func), 0),

            new Function("INFO_SCRIPT_TYPE"), constant<StgControlScript::INFO_SCRIPT_TYPE>::func), 0),
            new Function("INFO_SCRIPT_PATH"), constant<StgControlScript::INFO_SCRIPT_PATH>::func), 0),
            new Function("INFO_SCRIPT_ID"), constant<StgControlScript::INFO_SCRIPT_ID>::func), 0),
            new Function("INFO_SCRIPT_TITLE"), constant<StgControlScript::INFO_SCRIPT_TITLE>::func), 0),
            new Function("INFO_SCRIPT_TEXT"), constant<StgControlScript::INFO_SCRIPT_TEXT>::func), 0),
            new Function("INFO_SCRIPT_IMAGE"), constant<StgControlScript::INFO_SCRIPT_IMAGE>::func), 0),
            new Function("INFO_SCRIPT_REPLAY_NAME"), constant<StgControlScript::INFO_SCRIPT_REPLAY_NAME>::func), 0),

            new Function("REPLAY_FILE_PATH"), constant<StgControlScript::REPLAY_FILE_PATH>::func), 0),
            new Function("REPLAY_DATE_TIME"), constant<StgControlScript::REPLAY_DATE_TIME>::func), 0),
            new Function("REPLAY_USER_NAME"), constant<StgControlScript::REPLAY_USER_NAME>::func), 0),
            new Function("REPLAY_TOTAL_SCORE"), constant<StgControlScript::REPLAY_TOTAL_SCORE>::func), 0),
            new Function("REPLAY_FPS_AVERAGE"), constant<StgControlScript::REPLAY_FPS_AVERAGE>::func), 0),
            new Function("REPLAY_PLAYER_NAME"), constant<StgControlScript::REPLAY_PLAYER_NAME>::func), 0),
            new Function("REPLAY_STAGE_INDEX_LIST"), constant<StgControlScript::REPLAY_STAGE_INDEX_LIST>::func), 0),
            new Function("REPLAY_STAGE_START_SCORE_LIST"), constant<StgControlScript::REPLAY_STAGE_START_SCORE_LIST>::func), 0),
            new Function("REPLAY_STAGE_LAST_SCORE_LIST"), constant<StgControlScript::REPLAY_STAGE_LAST_SCORE_LIST>::func), 0),
            new Function("REPLAY_COMMENT"), constant<StgControlScript::REPLAY_COMMENT>::func), 0),

            new Function("REPLAY_INDEX_ACTIVE"), constant<ReplayInformation::INDEX_ACTIVE>::func), 0),
            new Function("REPLAY_INDEX_DIGIT_MIN"), constant<ReplayInformation::INDEX_DIGIT_MIN>::func), 0),
            new Function("REPLAY_INDEX_DIGIT_MAX"), constant<ReplayInformation::INDEX_DIGIT_MAX>::func), 0),
            new Function("REPLAY_INDEX_USER"), constant<ReplayInformation::INDEX_USER>::func), 0),

            new Function("RESULT_CANCEL"), constant<StgControlScript::RESULT_CANCEL>::func), 0),
            new Function("RESULT_END"), constant<StgControlScript::RESULT_END>::func), 0),
            new Function("RESULT_RETRY"), constant<StgControlScript::RESULT_RETRY>::func), 0),
            new Function("RESULT_SAVE_REPLAY"), constant<StgControlScript::RESULT_SAVE_REPLAY>::func), 0),
        */};
    }
}
