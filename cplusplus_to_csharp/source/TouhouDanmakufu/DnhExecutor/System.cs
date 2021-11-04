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
// class SystemController;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class SceneManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class TransitionManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class SystemInformation;
/**********************************************************
//SystemController
**********************************************************/
public class SystemController : Singleton<SystemController>
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Singleton<SystemController>;

        /**********************************************************
        //SystemController
        **********************************************************/
        private SystemController()
        {
            sceneManager_ = new SceneManager();
            transitionManager_ = new TransitionManager();
            infoSystem_ = new SystemInformation();

            // �풓�^�X�N�o�^
            ETaskManager taskManager = ETaskManager.GetInstance();
            ref_count_ptr<SystemResidentTask> task = new SystemResidentTask();
            taskManager.AddTask(task);
            taskManager.AddRenderFunction(TTaskFunction<SystemResidentTask>.Create(task, SystemResidentTask.RenderFps), SystemResidentTask.AnonymousEnum2.TASK_PRI_RENDER_FPS);
        }

        private ref_count_ptr<SceneManager> sceneManager_ = new ref_count_ptr<SceneManager>();
        private ref_count_ptr<TransitionManager> transitionManager_ = new ref_count_ptr<TransitionManager>();
        private ref_count_ptr<SystemInformation> infoSystem_ = new ref_count_ptr<SystemInformation>();

        public override void Dispose()
        {
            transitionManager_ = null;
            sceneManager_ = null;
            base.Dispose();
        }

        public void Reset()
        {
            EFileManager fileManager = EFileManager.GetInstance();
            fileManager.ResetArchiveFile();

            DnhConfiguration config = DnhConfiguration.CreateInstance();
            string pathPackageScript = config.GetPackageScriptPath();
            if (pathPackageScript.Length == 0)
            {
                infoSystem_.UpdateFreePlayerScriptInformationList();
                sceneManager_.TransTitleScene();
            }
            else
            {
                ref_count_ptr<ScriptInformation> info = ScriptInformation.CreateScriptInformation(pathPackageScript, false);
                if (info == null)
                {
                    ShowErrorDialog(ErrorUtility.GetFileNotFoundErrorMessage(pathPackageScript));
                }
                sceneManager_.TransPackageScene(info, true);
            }
        }

        public void ClearTaskWithoutSystem()
        {
            SortedSet<System.Type> listInfo = new SortedSet<System.Type>();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
            listInfo.Add(typeid(SystemTransitionEffectTask));
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
            listInfo.Add(typeid(SystemResidentTask));

            ETaskManager taskManager = ETaskManager.GetInstance();
            taskManager.RemoveTaskWithoutTypeInfo(listInfo);
        }

        public SceneManager GetSceneManager()
        {
            return sceneManager_.GetPointer();
        }
        public TransitionManager GetTransitionManager()
        {
            return transitionManager_.GetPointer();
        }
        public SystemInformation GetSystemInformation()
        {
            return infoSystem_.GetPointer();
        }

        public void ShowErrorDialog(string msg)
        {
            IntPtr hParent = EDirectGraphics.GetInstance().GetAttachedWindowHandle();
            ErrorDialog dialog = new ErrorDialog(hParent);
            dialog.ShowModal(msg);
        }
}


/**********************************************************
//SceneManager
**********************************************************/
public class SceneManager : System.IDisposable
{

        /**********************************************************
        //SceneManager
        **********************************************************/
        public SceneManager()
        {
        }

        public virtual void Dispose()
        {
        }

        // �V�[���ύX
        public void TransTitleScene()
        {
            EDirectInput input = EDirectInput.GetInstance();
            input.ClearKeyState();

            TransitionManager transitionManager = SystemController.GetInstance().GetTransitionManager();
            transitionManager.DoFadeOut();
            SystemController.GetInstance().ClearTaskWithoutSystem();

            ETaskManager taskManager = ETaskManager.GetInstance();
            ref_count_ptr<TitleScene> task = new TitleScene();
            taskManager.AddTask(task);
            taskManager.AddWorkFunction(TTaskFunction<TitleScene>.Create(task, TitleScene.Work), TitleScene.TASK_PRI_WORK);
            taskManager.AddRenderFunction(TTaskFunction<TitleScene>.Create(task, TitleScene.Render), TitleScene.TASK_PRI_RENDER);
        }

        public void TransScriptSelectScene(int type)
        {
            EDirectInput input = EDirectInput.GetInstance();
            input.ClearKeyState();

            TransitionManager transitionManager = SystemController.GetInstance().GetTransitionManager();
            transitionManager.DoFadeOut();
            SystemController.GetInstance().ClearTaskWithoutSystem();

            ETaskManager taskManager = ETaskManager.GetInstance();
            ref_count_ptr<ScriptSelectScene> task = new ScriptSelectScene();
            taskManager.AddTask(task);
            taskManager.AddWorkFunction(TTaskFunction<ScriptSelectScene>.Create(task, ScriptSelectScene.Work), ScriptSelectScene.TASK_PRI_WORK);
            taskManager.AddRenderFunction(TTaskFunction<ScriptSelectScene>.Create(task, ScriptSelectScene.Render), ScriptSelectScene.TASK_PRI_RENDER);

            ref_count_ptr<ScriptSelectModel> model = null;
            if (type == ScriptSelectScene.TYPE_SINGLE || type == ScriptSelectScene.TYPE_PLURAL || type == ScriptSelectScene.TYPE_STAGE || type == ScriptSelectScene.TYPE_PACKAGE || type == ScriptSelectScene.TYPE_DIR || type == ScriptSelectScene.TYPE_ALL)
            {
                string dir = EPathProperty.GetStgScriptRootDirectory();
                SystemInformation systemInfo = SystemController.GetInstance().GetSystemInformation();
                if (type == ScriptSelectScene.TYPE_DIR)
                {
                    dir = systemInfo.GetLastScriptSearchDirectory();
                }
                ScriptSelectFileModel fileModel = new ScriptSelectFileModel(type, dir);
                string pathWait = systemInfo.GetLastSelectedScriptPath();
                fileModel.SetWaitPath(pathWait);
                model = fileModel;
            }
            task.SetModel(model);
        }

        public void TransScriptSelectScene_All()
        {
            TransScriptSelectScene(ScriptSelectScene.TYPE_ALL);
        }

        public void TransScriptSelectScene_Single()
        {
            TransScriptSelectScene(ScriptSelectScene.TYPE_SINGLE);
        }

        public void TransScriptSelectScene_Plural()
        {
            TransScriptSelectScene(ScriptSelectScene.TYPE_PLURAL);
        }

        public void TransScriptSelectScene_Stage()
        {
            TransScriptSelectScene(ScriptSelectScene.TYPE_STAGE);
        }

        public void TransScriptSelectScene_Package()
        {
            TransScriptSelectScene(ScriptSelectScene.TYPE_PACKAGE);
        }

        public void TransScriptSelectScene_Directory()
        {
            TransScriptSelectScene(ScriptSelectScene.TYPE_DIR);
        }

        public void TransScriptSelectScene_Last()
        {
            int type = SystemController.GetInstance().GetSystemInformation().GetLastSelectScriptSceneType();
            TransScriptSelectScene(type);
        }

        public void TransStgScene(ref_count_ptr<ScriptInformation> infoMain, ref_count_ptr<ScriptInformation> infoPlayer, ref_count_ptr<ReplayInformation> infoReplay)
        {
            EDirectInput input = EDirectInput.GetInstance();
            input.ClearKeyState();

            try
            {
                // STG�V�[��������
                ref_count_ptr<StgSystemInformation> infoStgSystem = new StgSystemInformation();
                infoStgSystem.SetMainScriptInformation(infoMain);
                ref_count_ptr<StgSystemController> task = new EStgSystemController();

                // STG�^�X�N������
                ETaskManager taskManager = ETaskManager.GetInstance();
                task.Initialize(infoStgSystem);
                task.Start(infoPlayer, infoReplay);

                // �^�X�N�N���A
                TransitionManager transitionManager = SystemController.GetInstance().GetTransitionManager();
                transitionManager.DoFadeOut();
                SystemController.GetInstance().ClearTaskWithoutSystem();

                // STG�^�X�N�o�^
                taskManager.AddTask(task);
                taskManager.AddWorkFunction(TTaskFunction<StgSystemController>.Create(task, StgSystemController.Work), StgSystemController.TASK_PRI_WORK);
                taskManager.AddRenderFunction(TTaskFunction<StgSystemController>.Create(task, StgSystemController.Render), StgSystemController.TASK_PRI_RENDER);
            }
            catch (gstd.wexception e)
            {
                Logger.WriteTop(e.what());

                SystemController system = SystemController.GetInstance();
                system.ShowErrorDialog(e.what());
                system.GetSceneManager().TransScriptSelectScene_Last();
            }
        }

        public void TransStgScene(ref_count_ptr<ScriptInformation> infoMain, ref_count_ptr<ReplayInformation> infoReplay)
        {
            try
            {
                string replayPlayerID = infoReplay.GetPlayerScriptID();
                string replayPlayerScriptFileName = infoReplay.GetPlayerScriptFileName();

                // ���@�����
                ref_count_ptr<ScriptInformation> infoPlayer = new ref_count_ptr<ScriptInformation>();
                List<ref_count_ptr<ScriptInformation>> listPlayer = new List<new ref_count_ptr<ScriptInformation>>();
                List<string> listPlayerPath = infoMain.GetPlayerList();
                if (listPlayerPath.Count == 0)
                {
                    listPlayer = new List<ref_count_ptr<ScriptInformation>>(SystemController.GetInstance().GetSystemInformation().GetFreePlayerScriptInformationList());
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

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoPlayer = tInfo;
                    infoPlayer.CopyFrom(tInfo);
                    break;
                }

                if (infoPlayer == null)
                {
                    string log = StringUtility.Format("���@�X�N���v�g��������܂���:[%s]", replayPlayerScriptFileName);
                    throw new gstd.wexception(log);
                }

                TransStgScene(new ref_count_ptr<ScriptInformation>(infoMain), new ref_count_ptr<ScriptInformation>(infoPlayer), new ref_count_ptr<ReplayInformation>(infoReplay));
            }
            catch (gstd.wexception e)
            {
                Logger.WriteTop(e.what());

                SystemController system = SystemController.GetInstance();
                system.ShowErrorDialog(e.what());
                system.GetSceneManager().TransScriptSelectScene_Last();
            }

        }

        public void TransPackageScene(ref_count_ptr<ScriptInformation> infoMain, bool bOnlyPackage = false)
        {
            EDirectInput input = EDirectInput.GetInstance();
            input.ClearKeyState();

            try
            {
                // STG�V�[��������
                ref_count_ptr<StgSystemInformation> infoStgSystem = new StgSystemInformation();
                infoStgSystem.SetMainScriptInformation(infoMain);
                ref_count_ptr<StgSystemController> task = null;
                if (!bOnlyPackage)
                {
                    task = new EStgSystemController();
                }
                else
                {
                    task = new PStgSystemController();
                }

                // STG�^�X�N������
                ETaskManager taskManager = ETaskManager.GetInstance();
                task.Initialize(infoStgSystem);
                task.Start(null, null);

                // �^�X�N�N���A
                TransitionManager transitionManager = SystemController.GetInstance().GetTransitionManager();
                transitionManager.DoFadeOut();
                SystemController.GetInstance().ClearTaskWithoutSystem();

                // STG�^�X�N�o�^
                taskManager.AddTask(task);
                taskManager.AddWorkFunction(TTaskFunction<StgSystemController>.Create(task, StgSystemController.Work), StgSystemController.TASK_PRI_WORK);
                taskManager.AddRenderFunction(TTaskFunction<StgSystemController>.Create(task, StgSystemController.Render), StgSystemController.TASK_PRI_RENDER);
            }
            catch (gstd.wexception e)
            {
                Logger.WriteTop(e.what());

                SystemController system = SystemController.GetInstance();
                system.ShowErrorDialog(e.what());
                if (!bOnlyPackage)
                {
                    system.GetSceneManager().TransScriptSelectScene_Last();
                }
                else
                {
                    EApplication.GetInstance().End();
                }

            }
        }
}

/**********************************************************
//TransitionManager
**********************************************************/
public class TransitionManager : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum
        {
            TASK_PRI = 8
        }
        private void _CreateCurrentSceneTexture()
        {
            DirectGraphics graphics = EDirectGraphics.GetInstance();
            WorkRenderTaskManager taskManager = ETaskManager.GetInstance();
            TextureManager textureManager = ETextureManager.GetInstance();
            ref_count_ptr<Texture> texture = textureManager.GetTexture(TextureManager.TARGET_TRANSITION);

            graphics.SetRenderTarget(texture);
            graphics.ClearRenderTarget();
            graphics.BeginScene();
            taskManager.CallRenderFunction();
            graphics.EndScene();
            graphics.SetRenderTarget(null);
        }

        private void _AddTask(ref_count_ptr<TransitionEffect> effect)
        {
            WorkRenderTaskManager taskManager = ETaskManager.GetInstance();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
            taskManager.RemoveTask(typeid(SystemTransitionEffectTask));

            ref_count_ptr<SystemTransitionEffectTask> task = new SystemTransitionEffectTask();
            task.SetTransition(effect);
            taskManager.AddTask(task);
            taskManager.AddWorkFunction(TTaskFunction<SystemTransitionEffectTask>.Create(task, SystemTransitionEffectTask.Work), AnonymousEnum.TASK_PRI);
            taskManager.AddRenderFunction(TTaskFunction<SystemTransitionEffectTask>.Create(task, SystemTransitionEffectTask.Render), AnonymousEnum.TASK_PRI);
        }


        /**********************************************************
        //TransitionManager
        **********************************************************/
        public TransitionManager()
        {
        }

        public virtual void Dispose()
        {
        }

        public void DoFadeOut()
        {
            TextureManager textureManager = ETextureManager.GetInstance();
            ref_count_ptr<Texture> texture = textureManager.GetTexture(TextureManager.TARGET_TRANSITION);
            _CreateCurrentSceneTexture();

            ref_count_ptr<TransitionEffect_FadeOut> effect = new TransitionEffect_FadeOut();
            effect.Initialize(10, texture);
            _AddTask(new ref_count_ptr<TransitionEffect_FadeOut>(effect));

            EFpsController fpsController = EFpsController.GetInstance();
            fpsController.SetCriticalFrame();
        }
}

public class SystemTransitionEffectTask : TransitionEffectTask
{

        // SystemTransitionEffectTask
        public new void Work()
        {
            TransitionEffectTask.Work();
            if (effect_ != null && effect_.IsEnd())
            {
                WorkRenderTaskManager taskManager = ETaskManager.GetInstance();
                taskManager.RemoveTask(this);
                return;
            }
        }

        public new void Render()
        {
            TransitionEffectTask.Render();
        }
}

/**********************************************************
//SystemInformation
**********************************************************/
public class SystemInformation : System.IDisposable
{
        private int lastTitleSelectedIndex_;
        private string dirLastScriptSearch_ = "";
        private string pathLastSelectedScript_ = "";
        private int lastSelectScriptSceneType_;

        private int lastPlayerSelectIndex_;
        private List<ref_count_ptr<ScriptInformation>> listLastPlayerSelect_ = new List<ref_count_ptr<ScriptInformation>>();


        private List<ref_count_ptr<ScriptInformation>> listFreePlayer_ = new List<ref_count_ptr<ScriptInformation>>();

        private void _SearchFreePlayerScript(string dir)
        {
            listFreePlayer_ = new List<ref_count_ptr<ScriptInformation>>(ScriptInformation.FindPlayerScriptInformationList(dir));
            for (int iPlayer = 0 ; iPlayer < listFreePlayer_.Count ; iPlayer++)
            {
                ref_count_ptr<ScriptInformation> info = listFreePlayer_[iPlayer];
                string path = info.GetScriptPath();
                string log = StringUtility.Format("���@�X�N���v�g�F%s", path);
                ELogger.WriteTop(log);
            }
        }


        /**********************************************************
        //SystemInformation
        **********************************************************/
        public SystemInformation()
        {
            lastTitleSelectedIndex_ = 0;
            dirLastScriptSearch_ = EPathProperty.GetStgScriptRootDirectory();

            lastPlayerSelectIndex_ = 0;
        }

        public virtual void Dispose()
        {

        }

        public int GetLastTitleSelectedIndex()
        {
            return lastTitleSelectedIndex_;
        }
        public void SetLastTitleSelectedIndex(int index)
        {
            lastTitleSelectedIndex_ = index;
        }
        public string GetLastScriptSearchDirectory()
        {
            return dirLastScriptSearch_;
        }
        public void SetLastScriptSearchDirectory(string dir)
        {
            dirLastScriptSearch_ = dir;
        }
        public string GetLastSelectedScriptPath()
        {
            return pathLastSelectedScript_;
        }
        public void SetLastSelectedScriptPath(string path)
        {
            pathLastSelectedScript_ = path;
        }
        public int GetLastSelectScriptSceneType()
        {
            return lastSelectScriptSceneType_;
        }
        public void SetLastSelectScriptSceneType(int type)
        {
            lastSelectScriptSceneType_ = type;
        }

        public int GetLastSelectedPlayerIndex()
        {
            return lastPlayerSelectIndex_;
        }
        public List<ref_count_ptr<ScriptInformation>> GetLastPlayerSelectedList()
        {
            return new List<ref_count_ptr<ScriptInformation>>(listLastPlayerSelect_);
        }
        public void SetLastSelectedPlayerIndex(int index, List<ref_count_ptr<ScriptInformation>> list)
        {
            lastPlayerSelectIndex_ = index;
            listLastPlayerSelect_ = new List<ref_count_ptr<ScriptInformation>>(list);
        }

        public void UpdateFreePlayerScriptInformationList()
        {
            listFreePlayer_.Clear();
            string dir = EPathProperty.GetPlayerScriptRootDirectory();
            _SearchFreePlayerScript(dir);

            // �\�[�g
// C++ TO C# CONVERTER TODO TASK: The 'Compare' parameter of std::sort produces a boolean value, while the .NET Comparison parameter produces a tri-state result:
// ORIGINAL LINE: std::sort(listFreePlayer_.begin(), listFreePlayer_.end(), ScriptInformation::PlayerListSort());
            listFreePlayer_.Sort(new ScriptInformation.PlayerListSort());
        }

        public List<ref_count_ptr<ScriptInformation>> GetFreePlayerScriptInformationList()
        {
            return new List<ref_count_ptr<ScriptInformation>>(listFreePlayer_);
        }
}


/**********************************************************
//SystemResidentTask
**********************************************************/
public class SystemResidentTask : TaskBase
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            TASK_PRI_RENDER_FPS = 9
        }

        private DxText textFps_ = new DxText();


        /**********************************************************
        //SystemResidentTask
        **********************************************************/
        public SystemResidentTask()
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            int screenWidth = graphics.GetScreenWidth();
            int screenHeight = graphics.GetScreenHeight();

            textFps_.SetFontColorTop(D3DCOLOR_ARGB(255,160,160,255));
            textFps_.SetFontColorBottom(D3DCOLOR_ARGB(255,64,64,255));
            textFps_.SetFontBorderType(directx.DxFont.BORDER_FULL);
            textFps_.SetFontBorderColor(D3DCOLOR_ARGB(255,255,255,255));
            textFps_.SetFontBorderWidth(2);
            textFps_.SetFontSize(14);
            textFps_.SetFontBold(true);
            textFps_.SetMaxWidth(screenWidth - 8);
            textFps_.SetHorizontalAlignment(DxText.ALIGNMENT_RIGHT);
            textFps_.SetPosition(0, screenHeight - 20);
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public void RenderFps()
        {
            WorkRenderTaskManager taskManager = ETaskManager.GetInstance();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
            if (taskManager.GetTask(typeid(EStgSystemController)) != null)
            {
                return;
            }
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
            if (taskManager.GetTask(typeid(PStgSystemController)) != null)
            {
                return;
            }

            DirectGraphics graphics = DirectGraphics.GetBase();
            graphics.SetBlendMode(DirectGraphics.MODE_BLEND_ALPHA);
            graphics.SetZBufferEnable(false);
            graphics.SetZWriteEnalbe(false);
            graphics.SetFogEnable(false);

            EFpsController fpsController = EFpsController.GetInstance();
            float fps = fpsController.GetCurrentWorkFps();
            textFps_.SetText(StringUtility.Format("%.2ffps", fps));
            textFps_.Render();
        }
}
