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
//EStgSystemController
**********************************************************/
public class EStgSystemController : StgSystemController
{

        /**********************************************************
        //EStgSystemController
        **********************************************************/
        protected override void DoEnd()
        {
            SystemController.GetInstance().GetSceneManager().TransScriptSelectScene_Last();
        }

        protected override void DoRetry()
        {
            SceneManager sceneManager = SystemController.GetInstance().GetSceneManager();
            ref_count_ptr<StgStageInformation> infoStage = stageController_.GetStageInformation();
            sceneManager.TransStgScene(infoStage.GetMainScriptInformation(), infoStage.GetPlayerScriptInformation(), null);
        }
}


/**********************************************************
//PStgSystemController
**********************************************************/
public class PStgSystemController : StgSystemController
{

        /**********************************************************
        //PStgSystemController
        **********************************************************/
        protected override void DoEnd()
        {
            EDirectGraphics graphics = EDirectGraphics.CreateInstance();
            graphics.SetWindowVisible(false);
            EApplication.GetInstance().End();
        }

        protected override void DoRetry()
        {
            SystemController.GetInstance().Reset();
        }
}
