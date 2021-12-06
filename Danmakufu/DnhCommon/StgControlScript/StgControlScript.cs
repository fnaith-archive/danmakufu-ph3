namespace Common.StgControlScript
{
    class StgControlScript : DnhScript.DnhScript
    {
        public StgControlScript()//StgSystemController systemController) TODO
        {
            //systemController_ = systemController; TODO
            //scriptManager_ = null; TODO
            _AddFunction(StgControlFunction.stgControlFunction);

            //bLoad_ = false; TODO
            //bEndScript_ = false; TODO
            //bAutoDeleteObject_ = false; TODO

            //SetScriptEngineCache(systemController.GetScriptEngineCache());
            //commonDataManager_.CopyFrom(systemController.GetCommonDataManager());
        }
        // TODO
    }
}
