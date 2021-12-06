using System;
using Gstd.Application;

namespace DnhViewer.GcLibImpl
{
    public class EApplication : /*Singleton<EApplication>, */Application, System.IDisposable
    {
        private EApplication()
        {
        }
        protected bool _Initialize()
        {/*
            ELogger logger = ELogger.GetInstance();
            Logger.WriteTop("�A�v���P�[�V����������");

            EFileManager fileManager = EFileManager.CreateInstance();
            fileManager.Initialize();

            EFpsController fpsController = EFpsController.CreateInstance();

            EDirectGraphics graphics = EDirectGraphics.CreateInstance();
            graphics.Initialize();
            IntPtr hWndMain = MainWindow.GetInstance().GetWindowHandle();
            WindowLogger.InsertOpenCommandInSystemMenu(hWndMain);
        // 	::SetWindowText(hWndMain, "DnhViewer");
        // 	::SetClassLong(hWndMain, GCL_HICON, (LONG)LoadIcon(GetApplicationHandle(), MAKEINTRESOURCE(IDI_ICON)));

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

            DnhConfiguration config = DnhConfiguration.CreateInstance();
            if (config.IsLogWindow())
            {
                logger.LoadState();
                logger.SetWindowVisible(true);
            }

        // 	SystemController* systemController = SystemController::CreateInstance();
        // 	systemController->Reset();

            // �풓�^�X�N�o�^
            ref_count_ptr<SystemResidentTask> taskResident = new SystemResidentTask();
            taskManager.AddTask(taskResident);
            taskManager.AddRenderFunction(TTaskFunction<SystemResidentTask>.Create(taskResident, SystemResidentTask.RenderFps), SystemResidentTask.TASK_PRI_RENDER_FPS);

            // �f�o�b�O�^�X�N�o�^
            ref_count_ptr<DebugTask> taskDebug = new DebugTask();
            taskManager.AddTask(taskDebug);
            taskManager.AddWorkFunction(TTaskFunction<DebugTask>.Create(taskDebug, DebugTask.Work), DebugTask.TASK_PRI_WORK);

            MainWindow wndMain = MainWindow.GetInstance();
            global::SetForegroundWindow(wndMain.GetWindowHandle());

            Logger.WriteTop("�A�v���P�[�V��������������");
*/
            return true;
        }
        protected bool _Loop()
        {
            /*ELogger logger = ELogger.GetInstance();
            ETaskManager taskManager = ETaskManager.GetInstance();
            EFpsController fpsController = EFpsController.GetInstance();
            EDirectGraphics graphics = EDirectGraphics.GetInstance();

            MainWindow mainWindow = MainWindow.GetInstance();
            IntPtr hWndFocused = global::GetForegroundWindow();
            IntPtr hWndGraphics = mainWindow.GetWindowHandle();
            IntPtr hWndLogger = ELogger.GetInstance().GetWindowHandle();
            IntPtr hWndDebug = mainWindow.GetDebugWindow().GetWindowHandle();*/
            /*if (hWndFocused != hWndGraphics && hWndFocused != hWndLogger && hWndFocused != hWndDebug)
            {
                // ��A�N�e�B�u���͓��삵�Ȃ�
                global::Sleep(10);
                return true;
            }*/

            /*EDirectInput input = EDirectInput.GetInstance();
            input.Update();
            if (input.GetKeyState(DIK_R) == KEY_PUSH)
            {
                // ���Z�b�g
        // 		SystemController* systemController = SystemController::CreateInstance();
        // 		systemController->Reset();
            }*/

            /*taskManager.CallWorkFunction();

            if (!fpsController.IsSkip())
            {
                graphics.BeginScene();
                taskManager.CallRenderFunction();
                graphics.EndScene();
            }

            fpsController.Wait();*/

            // ���O�֘A
            /*SYSTEMTIME time = new SYSTEMTIME();
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
*/
            // ��������
            /*int fastModeKey = fpsController.GetFastModeKey();
            if (input.GetKeyState(fastModeKey) == KEY_HOLD)
            {
                if (!fpsController.IsFastMode())
                {
                    fpsController.SetFastMode(true);
                }
            }
            else if (input.GetKeyState(fastModeKey) == KEY_PULL)
            {
                if (fpsController.IsFastMode())
                {
                    fpsController.SetFastMode(false);
                }
            }*/
            return true;
        }
        protected bool _Finalize()
        {
            /*Logger.WriteTop("�A�v���P�[�V�����I�������J�n");
            MainWindow.GetInstance().SetStgController(null);
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
            logger.SetWindowVisible(true);*/

            //Logger.WriteTop("�A�v���P�[�V�����I����������");
            return true;
        }
        public void Dispose()
        {
        }
    }
}
