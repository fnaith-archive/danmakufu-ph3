using System;

/**********************************************************
//EApplication
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EApplication : Singleton<EApplication>, Application, System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Singleton<EApplication>;

        /**********************************************************
        //EApplication
        **********************************************************/
        private EApplication()
        {

        }

        protected bool _Initialize()
        {
            ELogger logger = ELogger.GetInstance();
            Logger.WriteTop("�A�v?�P�[�V???����");

            EFileManager fileManager = EFileManager.CreateInstance();
            fileManager.Initialize();

            EFpsController fpsController = EFpsController.CreateInstance();

            string appName = "?���e?? ph3 ";
            appName += GlobalMembers.DNH_VERSION;

            DnhConfiguration config = DnhConfiguration.CreateInstance();
            string configWindowTitle = config.GetWindowTitle();
            if (configWindowTitle.Length > 0)
            {
                appName = configWindowTitle;
            }

            // �}�E�X�\��
            if (!config.IsMouseVisible())
            {
                WindowUtility.SetMouseVisible(false);
            }

            // DirectX?����
            EDirectGraphics graphics = EDirectGraphics.CreateInstance();
            graphics.Initialize();
            IntPtr hWndMain = graphics.GetWindowHandle();
            WindowLogger.InsertOpenCommandInSystemMenu(hWndMain);
            global::SetWindowText(hWndMain, appName);
            global::SetClassLong(hWndMain, GCL_HICON, (int)LoadIcon(GetApplicationHandle(), MAKEINTRESOURCE(IDI_ICON)));

            ErrorDialog.SetParentWindowHandle(hWndMain);

            ETextureManager textureManager = ETextureManager.CreateInstance();
            textureManager.Initialize();

            EShaderManager shaderManager = EShaderManager.CreateInstance();
            shaderManager.Initialize();

            EMeshManager meshManager = EMeshManager.CreateInstance();
            meshManager.Initialize();

            EDxTextRenderer textRenderer = EDxTextRenderer.CreateInstance();
            textRenderer.Initialize();

            EDirectSoundManager soundManager = EDirectSoundManager.CreateInstance();
            soundManager.Initialize(hWndMain);

            EDirectInput input = EDirectInput.CreateInstance();
            input.Initialize(hWndMain);

            ETaskManager taskManager = ETaskManager.CreateInstance();
            taskManager.Initialize();

            gstd.ref_count_ptr<gstd.TaskInfoPanel> panelTask = new gstd.TaskInfoPanel();
            bool bAddTaskPanel = logger.AddPanel(panelTask, "Task");
            if (bAddTaskPanel)
            {
                taskManager.SetInfoPanel(panelTask);
            }

            gstd.ref_count_ptr<directx.TextureInfoPanel> panelTexture = new directx.TextureInfoPanel();
            bool bTexturePanel = logger.AddPanel(panelTexture, "Texture");
            if (bTexturePanel)
            {
                textureManager.SetInfoPanel(panelTexture);
            }

            gstd.ref_count_ptr<directx.DxMeshInfoPanel> panelMesh = new directx.DxMeshInfoPanel();
            bool bMeshPanel = logger.AddPanel(panelMesh, "Mesh");
            if (bMeshPanel)
            {
                meshManager.SetInfoPanel(panelMesh);
            }

            gstd.ref_count_ptr<directx.SoundInfoPanel> panelSound = new directx.SoundInfoPanel();
            bool bSoundPanel = logger.AddPanel(panelSound, "Sound");
            if (bSoundPanel)
            {
                soundManager.SetInfoPanel(panelSound);
            }

            gstd.ref_count_ptr<gstd.ScriptCommonDataInfoPanel> panelCommonData = logger.GetScriptCommonDataInfoPanel();
            logger.AddPanel(panelCommonData, "Common Data");

            gstd.ref_count_ptr<ScriptInfoPanel> panelScript = new ScriptInfoPanel();
            logger.AddPanel(panelScript, "Script");

            if (config.IsLogWindow())
            {
                logger.LoadState();
                logger.SetWindowVisible(true);
            }

            SystemController systemController = SystemController.CreateInstance();
            systemController.Reset();

            Logger.WriteTop("�A�v?�P�[�V???��������");

            return true;
        }

        protected bool _Loop()
        {
            ELogger logger = ELogger.GetInstance();
            ETaskManager taskManager = ETaskManager.GetInstance();
            EFpsController fpsController = EFpsController.GetInstance();
            EDirectGraphics graphics = EDirectGraphics.GetInstance();

            IntPtr hWndFocused = global::GetForegroundWindow();
            IntPtr hWndGraphics = graphics.GetWindowHandle();
            IntPtr hWndLogger = ELogger.GetInstance().GetWindowHandle();
            if (hWndFocused != hWndGraphics && hWndFocused != hWndLogger)
            {
                // ��A�N�e�B�u?�͓��삵�Ȃ�
                global::Sleep(10);
                return true;
            }

            EDirectInput input = EDirectInput.GetInstance();
            input.Update();
            if (input.GetKeyState(DIK_LCONTROL) == KEY_HOLD && input.GetKeyState(DIK_LSHIFT) == KEY_HOLD && input.GetKeyState(DIK_R) == KEY_PUSH)
            {
                // ?�Z�b�g
                SystemController systemController = SystemController.CreateInstance();
                systemController.Reset();
            }

            taskManager.CallWorkFunction();

            if (!fpsController.IsSkip())
            {
                graphics.BeginScene();
                taskManager.CallRenderFunction();
                graphics.EndScene();
            }

            fpsController.Wait();

            // ?�O�֘A
            SYSTEMTIME time = new SYSTEMTIME();
            GetLocalTime(time);
            string fps = StringUtility.Format("Work�F%.2ffps�ADraw�F%.2ffps", fpsController.GetCurrentWorkFps(), fpsController.GetCurrentRenderFps());
            logger.SetInfo(0, "fps", fps);

            int widthConfig = graphics.GetConfigData().GetScreenWidth();
            int heightConfig = graphics.GetConfigData().GetScreenHeight();
            int widthScreen = widthConfig * graphics.GetScreenWidthRatio();
            int heightScreen = heightConfig * graphics.GetScreenHeightRatio();

            string screen = StringUtility.Format("width�F%d/%d�Aheight�F%d/%d", widthScreen, widthConfig, heightScreen, heightConfig);
            logger.SetInfo(1, "screen", screen);

            logger.SetInfo(2, "font cache", StringUtility.Format("%d", EDxTextRenderer.GetInstance().GetCacheCount()));

            // ?������
            int fastModeKey = fpsController.GetFastModeKey();
            if (input.GetKeyState(fastModeKey) == KEY_HOLD)
            {
                if (!fpsController.IsFastMode())
                {
                    fpsController.SetFastMode(true);
                }
            }
            else if (input.GetKeyState(fastModeKey) == KEY_PULL || input.GetKeyState(fastModeKey) == KEY_FREE)
            {
                if (fpsController.IsFastMode())
                {
                    fpsController.SetFastMode(false);
                }
            }
            return true;
        }

        protected bool _Finalize()
        {
            Logger.WriteTop("�A�v?�P�[�V??�I��??�J�n");
            SystemController.DeleteInstance();
            ETaskManager.DeleteInstance();
            EFileManager.GetInstance().EndLoadThread();
            EDirectInput.DeleteInstance();
            EDirectSoundManager.DeleteInstance();
            EDxTextRenderer.DeleteInstance();
            EMeshManager.DeleteInstance();
            EShaderManager.DeleteInstance();
            ETextureManager.DeleteInstance();
            EDirectGraphics.DeleteInstance();
            EFpsController.DeleteInstance();
            EFileManager.DeleteInstance();

            ELogger logger = ELogger.GetInstance();
            logger.SaveState();

            Logger.WriteTop("�A�v?�P�[�V??�I��??����");
            return true;
        }

        public void Dispose()
        {

        }
}

/**********************************************************
//EDirectGraphics
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EDirectGraphics : Singleton<EDirectGraphics>, DirectGraphicsPrimaryWindow, System.IDisposable
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Singleton<EDirectGraphics>;

        /**********************************************************
        //EDirectGraphics
        **********************************************************/
        private EDirectGraphics()
        {

        }

        protected virtual int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_SYSCOMMAND:
                {
                    int nId = wParam & 0xffff;
                    if (nId == WindowLogger.MENU_ID_OPEN)
                    {
                        ELogger.GetInstance().ShowLogWindow();
                    }
                    break;
                }
            }
            return DirectGraphicsPrimaryWindow._WindowProcedure(hWnd, uMsg, wParam, lParam);
        }

        public void Dispose()
        {
        }

        public virtual bool Initialize()
        {
            DnhConfiguration dnhConfig = DnhConfiguration.GetInstance();
            int screenWidth = dnhConfig.GetScreenWidth();
            int screenHeight = dnhConfig.GetScreenHeight();
            int screenMode = dnhConfig.GetScreenMode();
            int windowSize = dnhConfig.GetWindowSize();

            bool bUserSize = screenWidth != 640 || screenHeight != 480;
            if (!bUserSize)
            {
                if (windowSize == DnhConfiguration.WINDOW_SIZE_640x480 && screenWidth > 640)
                {
                    windowSize = DnhConfiguration.WINDOW_SIZE_800x600;
                }
                if (windowSize == DnhConfiguration.WINDOW_SIZE_800x600 && screenWidth > 800)
                {
                    windowSize = DnhConfiguration.WINDOW_SIZE_960x720;
                }
                if (windowSize == DnhConfiguration.WINDOW_SIZE_960x720 && screenWidth > 960)
                {
                    windowSize = DnhConfiguration.WINDOW_SIZE_1280x960;
                }
                if (windowSize == DnhConfiguration.WINDOW_SIZE_1280x960 && screenWidth > 1280)
                {
                    windowSize = DnhConfiguration.WINDOW_SIZE_1600x1200;
                }
                if (windowSize == DnhConfiguration.WINDOW_SIZE_1600x1200 && screenWidth > 1600)
                {
                    windowSize = DnhConfiguration.WINDOW_SIZE_1920x1200;
                }
            }


            bool bShowWindow = screenMode == DirectGraphics.SCREENMODE_FULLSCREEN || windowSize == DnhConfiguration.WINDOW_SIZE_640x480;

            DirectGraphicsConfig dxConfig = new DirectGraphicsConfig();
            dxConfig.SetScreenWidth(screenWidth);
            dxConfig.SetScreenHeight(screenHeight);
            dxConfig.SetShowWindow(bShowWindow);
            bool res = DirectGraphicsPrimaryWindow.Initialize(dxConfig);

            int wWidth = global::GetSystemMetrics(SM_CXFULLSCREEN);
            int wHeight = global::GetSystemMetrics(SM_CYFULLSCREEN);
            bool bFullScreenEnable = screenWidth <= wWidth && screenHeight <= wHeight;

            // �R?�t�B�O���f
            if (screenMode == DirectGraphics.SCREENMODE_FULLSCREEN && bFullScreenEnable)
            {
                ChangeScreenMode();
            }
            else
            {
                if (windowSize != DnhConfiguration.WINDOW_SIZE_640x480 || bUserSize)
                {
                    int width = screenWidth;
                    int height = screenHeight;
                    if (!bUserSize)
                    {
                        switch (windowSize)
                        {
                        case DnhConfiguration.WINDOW_SIZE_800x600:
                            width = 800;
                            height = 600;
                            break;
                        case DnhConfiguration.WINDOW_SIZE_960x720:
                            width = 960;
                            height = 720;
                            break;
                        case DnhConfiguration.WINDOW_SIZE_1280x960:
                            width = 1280;
                            height = 960;
                            break;
                        case DnhConfiguration.WINDOW_SIZE_1600x1200:
                            width = 1600;
                            height = 1200;
                            break;
                        case DnhConfiguration.WINDOW_SIZE_1920x1200:
                            width = 1920;
                            height = 1200;
                            break;
                        }
                    }

                    double ratioWH = (double)screenWidth / (double)screenHeight;
                    if (width > wWidth)
                    {
                        width = wWidth;
                    }
                    height = (int)(double)width / ratioWH;

                    double ratioHW = (double)screenHeight / (double)screenWidth;
                    if (height > wHeight)
                    {
                        height = wHeight;
                    }
                    width = (int)(double)height / ratioHW;

                    int tw = global::GetSystemMetrics(SM_CXEDGE) + GetSystemMetrics(SM_CXBORDER) + GetSystemMetrics(SM_CXDLGFRAME);
                    int th = global::GetSystemMetrics(SM_CYEDGE) + GetSystemMetrics(SM_CYBORDER) + GetSystemMetrics(SM_CYDLGFRAME) + GetSystemMetrics(SM_CYCAPTION);
                    width += tw;
                    height += th;

                    SetBounds(0, 0, width, height);
                    MoveWindowCenter();
                }
            }
            SetWindowVisible(true);

            return res;
        }

        public void SetRenderStateFor2D(int blend)
        {
            DirectGraphics graphics = DirectGraphics.GetBase();
            graphics.SetBlendMode(blend);
            graphics.SetZBufferEnable(false);
            graphics.SetZWriteEnalbe(false);
        }
}
