using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class StgControllerForViewer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class GraphicsWindow;
/**********************************************************
//MainWindow
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class MainWindow : WindowBase, gstd.Singleton<MainWindow>, System.IDisposable
{
        protected ref_count_ptr<WTabControll> wndTab_ = new ref_count_ptr<WTabControll>();
        protected ref_count_ptr<WStatusBar> wndStatus_ = new ref_count_ptr<WStatusBar>();
        protected ref_count_ptr<GraphicsWindow> wndGraphics_ = new ref_count_ptr<GraphicsWindow>();
        protected ref_count_ptr<ScenePanel> panelScene_ = new ref_count_ptr<ScenePanel>();
        protected ref_count_ptr<DebugWindow> wndDebug_ = new ref_count_ptr<DebugWindow>();

        protected ref_count_ptr<StgControllerForViewer> controller_ = new ref_count_ptr<StgControllerForViewer>();

        protected virtual int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_CLOSE:
                {
                    string pathLastData = PathProperty.GetModuleDirectory() + PathProperty.GetModuleName() + ".dat";
                    MainWindow.GetInstance().Save(pathLastData);
                    global::DestroyWindow(hWnd);
                    break;
                }
                case WM_DESTROY:
                {
                    global::PostQuitMessage(0);
                    break;
                }
                case WM_SIZE:
                {
                    RECT rect = new RECT();
                    global::GetClientRect(hWnd_, rect);
                    int wx = rect.left;
                    int wy = rect.top;
                    int wWidth = rect.right - rect.left;
                    int wHeight = rect.bottom - rect.top;

                    wndStatus_.SetBounds(wParam, lParam);
                    wndTab_.SetBounds(wx + 8, wy + 4, wWidth - 16, wHeight - 32);
                    global::InvalidateRect(wndTab_.GetWindowHandle(), null, true);
                    break;
                }
                case WM_COMMAND:
                {
                    switch (wParam & 0xffff)
                    {
                        case ID_MENUITEM_MAIN_EXIT:
                            DestroyWindow(hWnd_);
                            break;

                        case ID_MENUITEM_MAIN_LOGWINDOW:
                        {
                            bool bVisible = !ELogger.GetInstance().IsWindowVisible();
                            ELogger.GetInstance().SetWindowVisible(bVisible);
                            break;
                        }

                        case ID_MENUITEM_MAIN_DEBUGWINDOW:
                        {
                            bool bVisible = !wndDebug_.IsWindowVisible();
                            wndDebug_.SetWindowVisible(bVisible);
                            break;
                        }

                        case ID_MENUITEM_MAIN_FIXEDAREA:
                        {
                            // �\����Œ�
                            panelScene_.SetFixedArea(!panelScene_.IsFixedArea());
                            panelScene_.LocateParts();
                            break;
                        }
                    }
                    break;
                }

                case WM_SYSCOMMAND:
                {
                    int nId = wParam & 0xffff;
                    if (nId == WindowLogger.MENU_ID_OPEN)
                    {
                        ELogger.GetInstance().ShowLogWindow();
                    }
                    break;
                }

                case WM_NOTIFY:
                {
                    switch (((NMHDR)lParam).code)
                    {
                        case TCN_SELCHANGE:
                            wndTab_.ShowPage();
                            break;
                    }
                    break;
                }
                case WM_INITMENUPOPUP:
                {
                    // HMENU hMenu = (HMENU) wParam;         // �T�u���j���[�̃n���h��
                    // int pos =  LOWORD(lParam);        // �T�u���j���[���ڂ̈ʒu
                    IntPtr hMenuMain = GetMenu(hWnd_);

                    uint valueLog = ELogger.GetInstance().IsWindowVisible() ? MFS_CHECKED : MFS_UNCHECKED;
                    CheckMenuItem(hMenuMain, ID_MENUITEM_MAIN_LOGWINDOW, valueLog | MF_BYCOMMAND);

                    uint valueDebug = wndDebug_.IsWindowVisible() ? MFS_CHECKED : MFS_UNCHECKED;
                    CheckMenuItem(hMenuMain, ID_MENUITEM_MAIN_DEBUGWINDOW, valueDebug | MF_BYCOMMAND);

                    uint valueFixed = panelScene_.IsFixedArea() ? MFS_CHECKED : MFS_UNCHECKED;
                    CheckMenuItem(hMenuMain, ID_MENUITEM_MAIN_FIXEDAREA, valueFixed | MF_BYCOMMAND);
                    return false;
                }
            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //MainWindow
        **********************************************************/
        public MainWindow()
        {

        }

        public void Dispose()
        {
            wndGraphics_ = null;
        }

        public bool Initialize()
        {
            IntPtr hInst = global::GetModuleHandle(null);
            string nameClass = "DnhViewerMainWindow";
            WNDCLASSEX wcex = new WNDCLASSEX();
            ZeroMemory(wcex, sizeof(WNDCLASSEX));
            wcex.cbSize = sizeof(WNDCLASSEX);
            wcex.style = CS_HREDRAW | CS_VREDRAW;
            wcex.lpfnWndProc = (WNDPROC)WindowBase._StaticWindowProcedure;
            wcex.hInstance = hInst;
            wcex.hIcon = null;
            wcex.hCursor = LoadCursor(null, IDC_ARROW);
            wcex.hbrBackground = (IntPtr)(COLOR_WINDOW);
            wcex.lpszMenuName = MAKEINTRESOURCE(IDR_MENU_MAIN);
            wcex.lpszClassName = nameClass;
            wcex.hIconSm = null;
            global::RegisterClassEx(wcex);

            string appName = "DnhViewer ph3 ";
            appName += GlobalMembers.DNH_VERSION;
               hWnd_ = global::CreateWindow(wcex.lpszClassName, appName, WS_OVERLAPPEDWINDOW, 0,0,800,600,null,null,hInst,null);
            global::ShowWindow(hWnd_, SW_HIDE);
            global::UpdateWindow(hWnd_);
            this.Attach(hWnd_);

            // �^�u
            wndTab_ = new WTabControll();
            wndTab_.Create(hWnd_);
            IntPtr hTab = wndTab_.GetWindowHandle();

            // �X�e�[�^�X�o�[
            wndStatus_ = new WStatusBar();
            wndStatus_.Create(hWnd_);
            List<int> sizeStatus = new List<int>();
            sizeStatus.Add(180);
            sizeStatus.Add(sizeStatus[0] + 560);
            wndStatus_.SetPartsSize(sizeStatus);

            // GraphicsWindow
            wndGraphics_ = new GraphicsWindow();
            wndGraphics_.Initialize();

            // EventScene
            panelScene_ = new ScenePanel();
            panelScene_.Initialize(hTab);
            wndTab_.AddTab("Scene", panelScene_);

            // ����������
            MoveWindowCenter();

            wndTab_.ShowPage();

            global::ShowWindow(hWnd_, SW_SHOW);

            string pathLastData = PathProperty.GetModuleDirectory() + PathProperty.GetModuleName() + ".dat";
            MainWindow.GetInstance().Load(pathLastData);

            // �f�o�b�O�E�B���h�E
            wndDebug_ = new DebugWindow();
            wndDebug_.Initialize();
            wndDebug_.ShowModeless();

            return true;
        }

        public GraphicsWindow GetGraphicsWindow()
        {
            return wndGraphics_.GetPointer();
        }
        public ScenePanel GetScenePanel()
        {
            return panelScene_.GetPointer();
        }
        public DebugWindow GetDebugWindow()
        {
            return wndDebug_.GetPointer();
        }

        public ref_count_ptr<StgControllerForViewer> GetStgController()
        {
            return new ref_count_ptr<StgControllerForViewer>(controller_);
        }
        public void SetStgController(ref_count_ptr<StgControllerForViewer> controller)
        {
            if (controller_ == controller)
            {
                return;
            }
            if (controller == null)
            {
                panelScene_.SetStgState(false);
            }
            else
            {
                panelScene_.SetStgState(true);
            }

            ETaskManager task = ETaskManager.GetInstance();
            if (controller_ != null)
            {
                EFpsController fpsController = EFpsController.GetInstance();
                fpsController.SetFastModeKey(DIK_LCONTROL);

                task.RemoveTask(controller_.GetPointer());
                controller_ = null;
                Logger.WriteTop("STG�V�[���I��");
            }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: controller_ = controller;
            controller_.CopyFrom(controller);
            if (controller_ != null)
            {
                Logger.WriteTop("STG�V�[���J�n");
                try
                {
                    DirectGraphics graphics = DirectGraphics.GetBase();
                    graphics.GetCamera2D().Reset();

        // 			controller_->Initialize();
                    task.AddTask(controller_);
                    task.AddWorkFunction(TTaskFunction<StgControllerForViewer>.Create(controller_, StgControllerForViewer.Work), StgSystemController.TASK_PRI_WORK);
                    task.AddRenderFunction(TTaskFunction<StgControllerForViewer>.Create(controller_, StgControllerForViewer.Render), StgSystemController.TASK_PRI_RENDER);
                }
                catch (gstd.wexception e)
                {
                    Logger.WriteTop(e.what());
                    ErrorDialog.ShowErrorDialog(e.what());
                }

            }
        }

        public void ClearData()
        {

        }

        public bool Load(string path)
        {
            RecordBuffer record = new RecordBuffer();
            bool res = record.ReadFromFile(path);
            if (!res)
            {
                // ::MessageBox(hWnd_, "�ǂݍ��ݎ��s", "�ݒ��J��", MB_OK);
                return false;
            }

            RecordBuffer recScene = new RecordBuffer();
            record.GetRecordAsRecordBuffer("Scene", recScene);
            panelScene_.Read(recScene);

            return true;
        }

        public bool Save(string path)
        {
            RecordBuffer recScene = new RecordBuffer();
            panelScene_.Write(recScene);

            RecordBuffer record = new RecordBuffer();
            record.SetRecordAsRecordBuffer("Scene", recScene);
            record.WriteToFile(path);

            return true;
        }
}


/**********************************************************
//GraphicsWindow
**********************************************************/
public class GraphicsWindow : WindowBase, System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TYPE_WINDOW_PANEL,
            TYPE_WINDOW_OVERLAPPED
        }
        protected virtual int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_CLOSE:
                {
                    global::ShowWindow(hWnd_, SW_HIDE);
                    break;
                }
            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //GraphicsWindow
        **********************************************************/
        public GraphicsWindow()
        {
        }

        public void Dispose()
        {
        }

        public bool Initialize()
        {
            IntPtr hParent = MainWindow.GetInstance().GetWindowHandle();
            IntPtr hInst = global::GetModuleHandle(null);
            string nameClass = "DnhViewerGraphicsWindow";
            WNDCLASSEX wcex = new WNDCLASSEX();
            ZeroMemory(wcex, sizeof(WNDCLASSEX));
            wcex.cbSize = sizeof(WNDCLASSEX);
            wcex.style = CS_HREDRAW | CS_VREDRAW;
            wcex.lpfnWndProc = (WNDPROC)WindowBase._StaticWindowProcedure;
            wcex.hInstance = hInst;
            wcex.hIcon = null;
            wcex.hCursor = LoadCursor(null, IDC_ARROW);
            wcex.hbrBackground = (IntPtr)(COLOR_WINDOW + 2);
            wcex.lpszMenuName = null;
            wcex.lpszClassName = nameClass;
            wcex.hIconSm = null;
            global::RegisterClassEx(wcex);

               hWnd_ = global::CreateWindow(wcex.lpszClassName, "", WS_OVERLAPPEDWINDOW - WS_SIZEBOX, 0,0,800,600,hParent,null,hInst,null);
            global::ShowWindow(hWnd_, SW_SHOW);
            global::UpdateWindow(hWnd_);
            this.Attach(hWnd_);

        // Window���ʂ̒����Ɉړ�
            MoveWindowCenter();

            global::ShowWindow(hWnd_, SW_HIDE);

            return true;
        }

        public void SetWindowType(int type, IntPtr hParent)
        {
            if (type == (int)AnonymousEnum.TYPE_WINDOW_PANEL)
            {
                RemoveWindowStyle(WS_OVERLAPPEDWINDOW);
                SetWindowStyle(WS_CHILD);
                SetWindowLong(hWnd_, GWL_EXSTYLE, WS_EX_STATICEDGE);
                SetParentWindow(hParent);
                SetWindowVisible(true);
            }
            else if (AnonymousEnum.TYPE_WINDOW_OVERLAPPED)
            {
                RemoveWindowStyle(WS_CHILD);
                SetWindowStyle(WS_OVERLAPPEDWINDOW);
                SetWindowLong(hWnd_, GWL_EXSTYLE, 0);
                SetParentWindow(hParent);
                SetWindowVisible(false);
            }
        }
}

/**********************************************************
//StgControllerForViewer
**********************************************************/
public class StgControllerForViewer : StgSystemController
{

        /**********************************************************
        //StgControllerForViewer
        **********************************************************/
        public override void DoEnd()
        {
            MainWindow.GetInstance().SetStgController(null);
        }

        public override void DoRetry()
        {
            ScenePanel panel = MainWindow.GetInstance().GetScenePanel();
        // 	panel->EndStg();
            panel.StartStg();
        }

        public static ref_count_ptr<StgControllerForViewer> Create()
        {
            ref_count_ptr<StgControllerForViewer> res = new StgControllerForViewer();

            return new ref_count_ptr<StgControllerForViewer>(res);
        }
}
