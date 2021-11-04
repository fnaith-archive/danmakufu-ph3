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
//DebugWindow
**********************************************************/
public class DebugWindow : WindowBase
{
        protected WButton checkPlayerInvincivility_ = new WButton();

        protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_CLOSE:
                {
                    SetWindowVisible(false);
                    break;
                }
                case WM_COMMAND:
                {
                    switch (wParam & 0xffff)
                    {
                        case IDC_CHECK_PLAYER_INVINCIBILITY:
                            break;
                    }
                    break;
                }

            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //DebugWindow
        **********************************************************/
        public DebugWindow()
        {
        }

        public void Initialize()
        {
            MainWindow mainWindow = MainWindow.GetInstance();
            IntPtr hParent = MainWindow.GetInstance().GetWindowHandle();
            hWnd_ = CreateDialog((IntPtr)GetWindowLong(hParent,GWL_HINSTANCE), MAKEINTRESOURCE(IDD_DIALOG_DEBUG), hParent,(DLGPROC)this._StaticWindowProcedure);
            this.Attach(hWnd_);

            int wx = mainWindow.GetClientX() + mainWindow.GetClientWidth() - GetClientWidth();
            int wy = mainWindow.GetClientY();
            POINT pos = new POINT(wx, wy);
            ClientToScreen(hParent, pos);

            checkPlayerInvincivility_.Attach(GetDlgItem(hWnd_, IDC_CHECK_PLAYER_INVINCIBILITY));

            global::SetWindowPos(hWnd_, HWND_TOP, pos.x, pos.y, 0, 0, SWP_NOSIZE);
        }

        public void ShowModeless()
        {
            SetWindowVisible(true);
        }

        public bool IsPlayerInvincivility()
        {
            bool res = SendMessage(checkPlayerInvincivility_.GetWindowHandle(), BM_GETCHECK, 0, 0) == BST_CHECKED;
            return res;
        }

        public void SetPlayerInvincivility(bool bInvincivility)
        {
            SendMessage(checkPlayerInvincivility_.GetWindowHandle(), BM_SETCHECK, bInvincivility ? BST_CHECKED : BST_UNCHECKED, 0);
        }
}

/**********************************************************
//DebugTask
**********************************************************/
public class DebugTask : TaskBase
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TASK_PRI_WORK = 0
        }

        private bool bPlayerInvincivility_;


        /**********************************************************
        //DebugTask
        **********************************************************/
        public DebugTask()
        {
            bPlayerInvincivility_ = false;
        }

        public new void Dispose()
        {
            base.Dispose();
        }

        public void Work()
        {
            MainWindow mainWindow = MainWindow.GetInstance();
            ref_count_ptr<StgControllerForViewer> controller = mainWindow.GetStgController();
            DebugWindow wndDebug = mainWindow.GetDebugWindow();

            EDirectInput input = EDirectInput.GetInstance();
            if (input.GetKeyState(DIK_I) == KEY_PUSH)
            {
                bool bPlayerInvincivility = wndDebug.IsPlayerInvincivility();
                wndDebug.SetPlayerInvincivility(!bPlayerInvincivility);
            }

            if (controller == null)
            {
                bPlayerInvincivility_ = false;
            }
            else
            {
                int FRAME_PLAYER_INVINCIVILITY = 256 * 256 * 256;
                bool bPlayerInvincivility = wndDebug.IsPlayerInvincivility();
                StgStageController stageController = controller.GetStageController();
                if (stageController != null)
                {
                    ref_count_ptr<StgPlayerObject>.unsync objPlayer = stageController.GetPlayerObject();
                    if (bPlayerInvincivility && objPlayer.GetInvincibilityFrame() < FRAME_PLAYER_INVINCIVILITY)
                    {
                        // ���@���G
                        objPlayer.SetInvincibilityFrame(FRAME_PLAYER_INVINCIVILITY);
                    }
                    else if (bPlayerInvincivility_ && !bPlayerInvincivility)
                    {
                        // ���@���G���
                        objPlayer.SetInvincibilityFrame(0);
                    }
                }

                bPlayerInvincivility_ = bPlayerInvincivility;
            }



        }
}
