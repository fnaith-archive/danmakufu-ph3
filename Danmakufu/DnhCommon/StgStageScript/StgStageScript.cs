namespace Common.StgStageScript
{
    class StgStageScript : StgControlScript.StgControlScript
    {
        public StgStageScript()//StgStageController stageController) TODO
        {
            //stageController_ = stageController; TODO

            //typeScript_ = (int)AnonymousEnum.TYPE_STAGE; TODO
            _AddFunction(StgFunction.stgFunction);

            //ref_count_ptr<StgStageInformation> info = stageController_.GetStageInformation();
            //mt_ = info.GetMersenneTwister(); TODO

            //scriptManager_ = stageController_.GetScriptManagerP(); TODO
            //StgStageScriptManager scriptManager = (StgStageScriptManager)scriptManager_; TODO
            //SetObjectManager(scriptManager.GetObjectManager()); TODO
        }
        // TODO
    }
}
