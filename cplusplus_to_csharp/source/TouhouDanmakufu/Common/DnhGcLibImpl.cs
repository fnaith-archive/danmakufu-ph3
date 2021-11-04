using System;

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
//EPathProperty
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EPathProperty : Singleton<EPathProperty>, PathProperty
{

        /**********************************************************
        //EPathProperty
        **********************************************************/
        public static string GetSystemResourceDirectory()
        {
            string path = GetModuleDirectory() + "resource/";
            return path;
        }

        public static string GetSystemImageDirectory()
        {
            string path = GetSystemResourceDirectory() + "img/";
            return path;
        }

        public static string GetSystemBgmDirectory()
        {
            string path = GetSystemResourceDirectory() + "bgm/";
            return path;
        }

        public static string GetSystemSeDirectory()
        {
            string path = GetSystemResourceDirectory() + "se/";
            return path;
        }

        public static string GetStgScriptRootDirectory()
        {
            string path = GetModuleDirectory() + "script/";
            return path;
        }

        public static string GetStgDefaultScriptDirectory()
        {
            string path = GetStgScriptRootDirectory() + "default_system/";
            return path;
        }

        public static string GetPlayerScriptRootDirectory()
        {
            string path = GetModuleDirectory() + "script/player/";
            return path;
        }

        public static string GetReplaySaveDirectory(string scriptPath)
        {
            string scriptName = PathProperty.GetFileNameWithoutExtension(scriptPath);
            string dir = PathProperty.GetFileDirectory(scriptPath) + "replay/";
            return dir;
        }

        public static string GetCommonDataPath(string scriptPath, string area)
        {
            string dirSave = PathProperty.GetFileDirectory(scriptPath) + "data/";
            string nameMain = PathProperty.GetFileNameWithoutExtension(scriptPath);
            string path = dirSave + nameMain + StringUtility.Format("_common_%s.dat", area);
            return path;
        }

        public static string ExtendRelativeToFull(string dir, string path)
        {
            path = StringUtility.ReplaceAll(path, "\\", "/");
            if (path.Length >= 2)
            {
                if (path[0] == '.' && path[1] == '/')
                {
                    path = path.Substring(2);
                    path = dir + path;
                }
            }

            string drive = PathProperty.GetDriveName(path);
            if (drive.Length == 0)
            {
                path = GetModuleDirectory() + path;
            }

            return path;
        }
}

/**********************************************************
//ELogger
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class ELogger : Singleton<ELogger>, WindowLogger
{
        private gstd.ref_count_ptr<gstd.ScriptCommonDataInfoPanel> panelCommonData_ = new gstd.ref_count_ptr<gstd.ScriptCommonDataInfoPanel>();

        /**********************************************************
        //ELogger
        **********************************************************/
        public ELogger()
        {

        }

        public void Initialize(bool bFile, bool bWindow)
        {
            gstd.ref_count_ptr<gstd.FileLogger> fileLogger = new gstd.FileLogger();
            fileLogger.Initialize(bFile);
            fileLogger.Clear();

            this.AddLogger(new gstd.ref_count_ptr<gstd.FileLogger>(fileLogger));

            Logger.SetTop(this);
            WindowLogger.Initialize(bWindow);

            panelCommonData_ = new gstd.ScriptCommonDataInfoPanel();
        }

        public gstd.ref_count_ptr<gstd.ScriptCommonDataInfoPanel> GetScriptCommonDataInfoPanel()
        {
            return new gstd.ref_count_ptr<gstd.ScriptCommonDataInfoPanel>(panelCommonData_);
        }
        public void UpdateCommonDataInfoPanel(gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager)
        {
            panelCommonData_.Update(commonDataManager);
        }
}


/**********************************************************
//EFpsController
**********************************************************/
public class EFpsController : Singleton<EFpsController>
{
        private int fastModeKey_;
        private ref_count_ptr<FpsController> controller_ = new ref_count_ptr<FpsController>();

        /**********************************************************
        //EFpsController
        **********************************************************/
        public EFpsController()
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            int fpsType = config.GetFpsType();
            if (fpsType == DnhConfiguration.FPS_NORMAL || fpsType == DnhConfiguration.FPS_1_2 || fpsType == DnhConfiguration.FPS_1_3)
            {
                StaticFpsController controller = new StaticFpsController();
                if (fpsType == DnhConfiguration.FPS_1_2)
                {
                    controller.SetSkipRate(1);
                }
                else if (fpsType == DnhConfiguration.FPS_1_3)
                {
                    controller.SetSkipRate(2);
                }
                controller_ = controller;
            }
            else
            {
                AutoSkipFpsController controller = new AutoSkipFpsController();
                controller_ = controller;
            }

            SetFps(GlobalMembers.STANDARD_FPS);
            fastModeKey_ = DIK_LCONTROL;
        }

        public void SetFps(int fps)
        {
            controller_.SetFps(fps);
        }
        public int GetFps()
        {
            return controller_.GetFps();
        }
        public void SetTimerEnable(bool b)
        {
            controller_.SetTimerEnable(b);
        }

        public void Wait()
        {
            controller_.Wait();
        }
        public bool IsSkip()
        {
            return controller_.IsSkip();
        }
        public void SetCriticalFrame()
        {
            controller_.SetCriticalFrame();
        }
        public float GetCurrentFps()
        {
            return controller_.GetCurrentFps();
        }
        public float GetCurrentWorkFps()
        {
            return controller_.GetCurrentWorkFps();
        }
        public float GetCurrentRenderFps()
        {
            return controller_.GetCurrentRenderFps();
        }
        public bool IsFastMode()
        {
            return controller_.IsFastMode();
        }
        public void SetFastMode(bool b)
        {
            controller_.SetFastMode(b);
        }

        public void AddFpsControlObject(ref_count_weak_ptr<FpsControlObject> obj)
        {
            controller_.AddFpsControlObject(obj);
        }
        public void RemoveFpsControlObject(ref_count_weak_ptr<FpsControlObject> obj)
        {
            controller_.RemoveFpsControlObject(obj);
        }

        public int GetFastModeKey()
        {
            return fastModeKey_;
        }
        public void SetFastModeKey(int key)
        {
            fastModeKey_ = key;
        }
}

/**********************************************************
//EFileManager
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EFileManager : Singleton<EFileManager>, FileManager
{

        /**********************************************************
        //EFileManager
        **********************************************************/
        public void ResetArchiveFile()
        {
            mapArchiveFile_.Clear();
        }
}

/**********************************************************
//ETaskManager
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class ETaskManager : Singleton<ETaskManager>, WorkRenderTaskManager
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    private enum AnonymousEnum
    {
        TASK_WORK_PRI_MAX = 10,
        TASK_RENDER_PRI_MAX = 10
    }

        /**********************************************************
        //ETaskManager
        **********************************************************/
        public bool Initialize()
        {
            InitializeFunctionDivision(AnonymousEnum.TASK_WORK_PRI_MAX, AnonymousEnum.TASK_RENDER_PRI_MAX);
            return true;
        }
}


/**********************************************************
//ETextureManager
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class ETextureManager : Singleton<ETextureManager>, TextureManager
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum2
        {
            MAX_RESERVED_RENDERTARGET = 3
        }

        /**********************************************************
        //ETextureManager
        **********************************************************/
        public override bool Initialize()
        {
            bool res = TextureManager.Initialize();

            for (int iRender = 0 ; iRender < (int)AnonymousEnum2.MAX_RESERVED_RENDERTARGET ; iRender++)
            {
                string name = GetReservedRenderTargetName(iRender);
                ref_count_ptr<Texture> texture = new Texture();
                res &= texture.CreateRenderTarget(name);
                Add(name, texture);
            }

            if (!res)
            {
                throw new gstd.wexception("ETextureManager���������s");
            }
            return res;
        }

        public string GetReservedRenderTargetName(int index)
        {
            string res = "__RESERVED_RENDER_TARGET__";
            res += StringUtility.Format("%d", index);
            return res;
        }
}

/**********************************************************
//EMeshManager
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EMeshManager : Singleton<EMeshManager>, DxMeshManager
{

}

/**********************************************************
//EMeshManager
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EShaderManager : Singleton<EShaderManager>, ShaderManager
{

}

/**********************************************************
//EDxTextRenderer
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EDxTextRenderer : Singleton<EDxTextRenderer>, DxTextRenderer
{

}

/**********************************************************
//EDirectSoundManager
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EDirectSoundManager : Singleton<EDirectSoundManager>, DirectSoundManager
{

}

/**********************************************************
//EDirectInput
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EDirectInput : Singleton<EDirectInput>, VirtualKeyManager
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum3
        {
            KEY_INVALID = -1,

            KEY_LEFT,
            KEY_RIGHT,
            KEY_UP,
            KEY_DOWN,

            KEY_OK,
            KEY_CANCEL,

            KEY_SHOT,
            KEY_BOMB,
            KEY_SLOWMOVE,
            KEY_USER1,
            KEY_USER2,

            KEY_PAUSE,

            VK_USER_ID_STAGE = 256,
            VK_USER_ID_PLAYER = 512

        }

        public int padIndex_;


        /**********************************************************
        //EDirectInput
        **********************************************************/
        public override bool Initialize(IntPtr hWnd)
        {
            padIndex_ = 0;

            VirtualKeyManager.Initialize(hWnd);

            ResetVirtualKeyMap();

            return true;
        }

        public void ResetVirtualKeyMap()
        {
            ClearKeyMap();

            // �L�[�o�^
            DnhConfiguration config = DnhConfiguration.GetInstance();

            AddKeyMap((int)AnonymousEnum3.KEY_LEFT, config.GetVirtualKey((int)AnonymousEnum3.KEY_LEFT));
            AddKeyMap((int)AnonymousEnum3.KEY_RIGHT, config.GetVirtualKey((int)AnonymousEnum3.KEY_RIGHT));
            AddKeyMap((int)AnonymousEnum3.KEY_UP, config.GetVirtualKey((int)AnonymousEnum3.KEY_UP));
            AddKeyMap((int)AnonymousEnum3.KEY_DOWN, config.GetVirtualKey((int)AnonymousEnum3.KEY_DOWN));

            AddKeyMap((int)AnonymousEnum3.KEY_OK, config.GetVirtualKey((int)AnonymousEnum3.KEY_OK));
            AddKeyMap((int)AnonymousEnum3.KEY_CANCEL, config.GetVirtualKey((int)AnonymousEnum3.KEY_CANCEL));

            AddKeyMap((int)AnonymousEnum3.KEY_SHOT, config.GetVirtualKey((int)AnonymousEnum3.KEY_SHOT));
            AddKeyMap((int)AnonymousEnum3.KEY_BOMB, config.GetVirtualKey((int)AnonymousEnum3.KEY_BOMB));
            AddKeyMap((int)AnonymousEnum3.KEY_SLOWMOVE, config.GetVirtualKey((int)AnonymousEnum3.KEY_SLOWMOVE));
            AddKeyMap((int)AnonymousEnum3.KEY_USER1, config.GetVirtualKey((int)AnonymousEnum3.KEY_USER1));
            AddKeyMap((int)AnonymousEnum3.KEY_USER2, config.GetVirtualKey((int)AnonymousEnum3.KEY_USER2));

            AddKeyMap((int)AnonymousEnum3.KEY_PAUSE, config.GetVirtualKey((int)AnonymousEnum3.KEY_PAUSE));
        }

        public int GetPadIndex()
        {
            return padIndex_;
        }
}
