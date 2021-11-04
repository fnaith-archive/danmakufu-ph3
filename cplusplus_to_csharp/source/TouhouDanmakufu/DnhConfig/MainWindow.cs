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
// class DevicePanel;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class KeyPanel;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// class OptionPanel;
/**********************************************************
//MainWindow
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class MainWindow : WindowBase, gstd.Singleton<MainWindow>
{
        protected ref_count_ptr<WTabControll> wndTab_ = new ref_count_ptr<WTabControll>();
        protected ref_count_ptr<DevicePanel> panelDevice_ = new ref_count_ptr<DevicePanel>();
        protected ref_count_ptr<KeyPanel> panelKey_ = new ref_count_ptr<KeyPanel>();
        protected ref_count_ptr<OptionPanel> panelOption_ = new ref_count_ptr<OptionPanel>();

        protected void _RunExecutor()
        {
            PROCESS_INFORMATION infoProcess = new PROCESS_INFORMATION();
            ZeroMemory(infoProcess, sizeof(PROCESS_INFORMATION));

            STARTUPINFO si = new STARTUPINFO();
            ZeroMemory(si, sizeof(STARTUPINFO));
            si.cb = sizeof(STARTUPINFO);

            string command = "th_dnh.exe";
            bool res = global::CreateProcess(null, (string)command, null, null, true, 0, null, null, si, infoProcess);
            if (res == false)
            {
                string log = StringUtility.Format("���s���s\r\n%s", ErrorUtility.GetLastErrorMessage().c_str());
                Logger.WriteTop(log);
                return;
            }

            global::CloseHandle(infoProcess.hProcess);
            global::CloseHandle(infoProcess.hThread);
        }

        protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_CLOSE:
                {
                    global::DestroyWindow(hWnd);
                    break;
                }
                case WM_DESTROY:
                {
                    global::PostQuitMessage(0);
                    break;
                }
                case WM_COMMAND:
                {
                    switch (wParam & 0xffff)
                    {
                        case ID_MENUITEM_MAIN_EXIT:
                        case IDCANCEL:
                            global::DestroyWindow(hWnd_);
                            break;

                        case IDOK:
                            Save();
                            global::DestroyWindow(hWnd_);
                            break;

                        case ID_BUTTON_EXECUTE:
                        {
                            Save();
                            _RunExecutor();
                            global::DestroyWindow(hWnd_);
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

            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //MainWindow
        **********************************************************/
        public MainWindow()
        {

        }

        public new void Dispose()
        {

            base.Dispose();
        }

        public bool Initialize()
        {
            hWnd_ = global::CreateDialog((IntPtr)GetWindowLong(null,GWL_HINSTANCE), MAKEINTRESOURCE(IDD_DIALOG_MAIN), null,(DLGPROC)_StaticWindowProcedure);

        // 	::SetClassLong(hWnd_, GCL_HICON,
        // 		( LONG )(HICON)LoadImage(Application::GetApplicationHandle(), MAKEINTRESOURCE(IDI_ICON), IMAGE_ICON, 32, 32, 0));

            Attach(hWnd_);
            global::ShowWindow(hWnd_, SW_HIDE);

            // �^�u
            IntPtr hTab = GetDlgItem(hWnd_, IDC_TAB_MAIN);
            wndTab_ = new WTabControll();
            wndTab_.Attach(hTab);

            // DevicePanel
            panelDevice_ = new DevicePanel();
            panelDevice_.Initialize(hTab);
            wndTab_.AddTab("Device", panelDevice_);

            // KeyPanel
            panelKey_ = new KeyPanel();
            panelKey_.Initialize(hTab);
            wndTab_.AddTab("Key", panelKey_);

            // OptionPanel
            panelOption_ = new OptionPanel();
            panelOption_.Initialize(hTab);
            wndTab_.AddTab("Option", panelOption_);

            // ����������
            ReadConfiguration();
            MoveWindowCenter();
            wndTab_.ShowPage();

            wndTab_.LocateParts();
            global::ShowWindow(hWnd_, SW_SHOW);

            MainWindow.GetInstance().Load();

            return true;
        }

        public bool StartUp()
        {
            panelKey_.StartUp();
            return true;
        }

        public void ClearData()
        {

        }

        public bool Load()
        {
            RecordBuffer record = new RecordBuffer();
            string path;
        /*
        	bool res = record.ReadFromFile(path);
        	if(!res)
        	{
        		//::MessageBox(hWnd_, "�ǂݍ��ݎ��s", "�ݒ��J��", MB_OK);
        		return false;
        	}
        */

            return true;
        }

        public bool Save()
        {
            WriteConfiguration();
            DnhConfiguration config = DnhConfiguration.GetInstance();
            config.SaveConfigFile();

            return true;
        }

        public void UpdateKeyAssign()
        {
            if (!panelKey_.IsWindowVisible())
            {
                return;
            }
            panelKey_.UpdateKeyAssign();

        }

        public void ReadConfiguration()
        {
            panelDevice_.ReadConfiguration();
            panelKey_.ReadConfiguration();
            panelOption_.ReadConfiguration();
        }

        public void WriteConfiguration()
        {
            panelDevice_.WriteConfiguration();
            panelKey_.WriteConfiguration();
            panelOption_.WriteConfiguration();
        }
}

/**********************************************************
//DevicePanel
**********************************************************/
public class DevicePanel : WPanel
{
        protected WComboBox comboWindowSize_ = new WComboBox();
        protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            return WPanel._WindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //DevicePanel
        **********************************************************/
        public DevicePanel()
        {
        }

        public new void Dispose()
        {

            base.Dispose();
        }

        public bool Initialize(IntPtr hParent)
        {
            hWnd_ = global::CreateDialog((IntPtr)GetWindowLong(null,GWL_HINSTANCE), MAKEINTRESOURCE(IDD_PANEL_DEVICE), hParent,(DLGPROC)_StaticWindowProcedure);
            Attach(hWnd_);

            comboWindowSize_.Attach(global::GetDlgItem(hWnd_, IDC_COMBO_WINDOWSIZE));
            comboWindowSize_.AddString("640x480");
            comboWindowSize_.AddString("800x600");
            comboWindowSize_.AddString("960x720");
            comboWindowSize_.AddString("1280x960");
            SetWindowPos(comboWindowSize_.GetWindowHandle(), null, 0, 0, comboWindowSize_.GetClientWidth(), 200, SWP_NOMOVE);

            return true;
        }

        public void ReadConfiguration()
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            int screenMode = config.GetScreenMode();
            switch (screenMode)
            {
            case DirectGraphics.SCREENMODE_FULLSCREEN:
                SendDlgItemMessage(hWnd_, IDC_RADIO_FULLSCREEN,BM_SETCHECK, 1, 0);
                break;
            default:
                SendDlgItemMessage(hWnd_, IDC_RADIO_WINDOW,BM_SETCHECK, 1, 0);
                break;
            }

            int windowSize = config.GetWindowSize();
            comboWindowSize_.SetSelectedIndex(windowSize);

            int fpsType = config.GetFpsType();
            switch (fpsType)
            {
            case DnhConfiguration.FPS_NORMAL:
                SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_1,BM_SETCHECK, 1, 0);
                break;
            case DnhConfiguration.FPS_1_2:
                SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_2,BM_SETCHECK, 1, 0);
                break;
            case DnhConfiguration.FPS_1_3:
                SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_3,BM_SETCHECK, 1, 0);
                break;
            case DnhConfiguration.FPS_AUTO:
                SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_AUTO,BM_SETCHECK, 1, 0);
                break;
            }

        }

        public void WriteConfiguration()
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            int screenMode = DirectGraphics.SCREENMODE_WINDOW;
            if (SendDlgItemMessage(hWnd_, IDC_RADIO_FULLSCREEN, BM_GETCHECK, 0, 0))
            {
                screenMode = DirectGraphics.SCREENMODE_FULLSCREEN;
            }
            config.SetScreenMode(screenMode);

            int windowSize = comboWindowSize_.GetSelectedIndex();
            config.SetWindowSize(windowSize);

            int fpsType = DnhConfiguration.FPS_NORMAL;
            if (SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_1, BM_GETCHECK, 0, 0))
            {
                fpsType = DnhConfiguration.FPS_NORMAL;
            }
            else if (SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_2, BM_GETCHECK, 0, 0))
            {
                fpsType = DnhConfiguration.FPS_1_2;
            }
            else if (SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_3, BM_GETCHECK, 0, 0))
            {
                fpsType = DnhConfiguration.FPS_1_3;
            }
            else if (SendDlgItemMessage(hWnd_, IDC_RADIO_FPS_AUTO, BM_GETCHECK, 0, 0))
            {
                fpsType = DnhConfiguration.FPS_AUTO;
            }
            config.SetFpsType(fpsType);
        }
}

/**********************************************************
//KeyPanel
**********************************************************/
public class KeyPanel : WPanel
{
    private class KeyListView : WListView
    {

            // KeyPanel::KeyListView
            protected virtual int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_KEYDOWN: // �L�[���͂𖳎�
                        return false;
                }
                return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
            }
    }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        protected enum AnonymousEnum
        {
            COL_ACTION,
            COL_KEY_ASSIGN,
            COL_PAD_ASSIGN
        }

        protected WComboBox comboPadIndex_ = new WComboBox();
        protected ref_count_ptr<KeyListView> viewKey_ = new ref_count_ptr<KeyListView>();
        protected KeyCodeList listKeyCode_ = new KeyCodeList();
        protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            return WPanel._WindowProcedure(hWnd, uMsg, wParam, lParam);
        }

        protected void _UpdateText(int row)
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            ref_count_ptr<VirtualKey> vk = config.GetVirtualKey(row);
            if (vk == null)
            {
                return;
            }

            int keyCode = vk.GetKeyCode();
            string strKey = listKeyCode_.GetCodeText(keyCode);
            viewKey_.SetText(row, AnonymousEnum.COL_KEY_ASSIGN, strKey);

            int padButton = vk.GetPadButton();
            string strPad = StringUtility.Format("PAD %02d", padButton);
            viewKey_.SetText(row, AnonymousEnum.COL_PAD_ASSIGN, strPad);

        }


        /**********************************************************
        //KeyPanel
        **********************************************************/
        public KeyPanel()
        {
        }

        public new void Dispose()
        {

            base.Dispose();
        }

        public bool Initialize(IntPtr hParent)
        {
            hWnd_ = global::CreateDialog((IntPtr)GetWindowLong(null,GWL_HINSTANCE), MAKEINTRESOURCE(IDD_PANEL_KEY), hParent,(DLGPROC)_StaticWindowProcedure);
            Attach(hWnd_);

            comboPadIndex_.Attach(global::GetDlgItem(hWnd_, IDC_COMBO_PADINDEX));

            IntPtr hListKey = global::GetDlgItem(hWnd_, IDC_LIST_KEY);
            uint dwStyle = ListView_GetExtendedListViewStyle(hListKey);
            dwStyle |= LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES;
            ListView_SetExtendedListViewStyle(hListKey, dwStyle);
        // 	HIMAGELIST hImageList = ImageList_Create(32 , 22 , ILC_COLOR4 |ILC_MASK , 2 , 1);
        // 	ListView_SetImageList(hList, hImageList, LVSIL_SMALL) ;

            viewKey_ = new KeyListView();
            viewKey_.Attach(hListKey);
            viewKey_.AddColumn(140, AnonymousEnum.COL_ACTION, "Action(����)");
            viewKey_.AddColumn(100, AnonymousEnum.COL_KEY_ASSIGN, "Keyboard(�L�[�{�[�h)");
            viewKey_.AddColumn(100, AnonymousEnum.COL_PAD_ASSIGN, "Pad(�p�b�h)");

            SortedDictionary<int, string> mapViewText = new SortedDictionary<int, string>();
            mapViewText[EDirectInput.KEY_LEFT] = "Left(��)";
            mapViewText[EDirectInput.KEY_RIGHT] = "Right(�E)";
            mapViewText[EDirectInput.KEY_UP] = "Up(��)";
            mapViewText[EDirectInput.KEY_DOWN] = "Down(��)";
            mapViewText[EDirectInput.KEY_OK] = "Decide(����)";
            mapViewText[EDirectInput.KEY_CANCEL] = "Cancel(�L�����Z��)";
            mapViewText[EDirectInput.KEY_SHOT] = "Shot(�V���b�g)";
            mapViewText[EDirectInput.KEY_BOMB] = "Spell(�X�y��)";
            mapViewText[EDirectInput.KEY_SLOWMOVE] = "Slow-Moving(�ᑬ�ړ�)";
            mapViewText[EDirectInput.KEY_USER1] = "User1(���[�U��`1)";
            mapViewText[EDirectInput.KEY_USER2] = "User2(���[�U��`2)";
            mapViewText[EDirectInput.KEY_PAUSE] = "Pause(�|�[�Y)";
            for (int iView = 0 ; iView < mapViewText.Count ; iView++)
            {
                string text = mapViewText[iView];
                viewKey_.SetText(iView, AnonymousEnum.COL_ACTION, text);
                _UpdateText(iView);
            }

            return true;
        }

        public bool StartUp()
        {
            int padDeviceTextWidth = comboPadIndex_.GetClientWidth();
            EDirectInput input = EDirectInput.GetInstance();
            int padCount = input.GetPadDeviceCount();
            for (int iPad = 0; iPad < padCount ; iPad++)
            {
                DIDEVICEINSTANCE info = input.GetPadDeviceInformation(iPad);
                string strPad = StringUtility.Format("%d : %s [%s]", iPad + 1, info.tszInstanceName, info.tszProductName);
                comboPadIndex_.AddString(strPad);

                int textCount = StringUtility.CountAsciiSizeCharacter(strPad);
                // padDeviceTextWidth = max(padDeviceTextWidth, textCount * 10);
            }
            if (padCount == 0)
            {
                comboPadIndex_.AddString("(none)");
                comboPadIndex_.SetWindowEnable(false);
            }
            SetWindowPos(comboPadIndex_.GetWindowHandle(), null, 0, 0, padDeviceTextWidth, 200, SWP_NOMOVE);

            DnhConfiguration config = DnhConfiguration.GetInstance();
            int padIndex = config.GetPadIndex();
            padIndex = System.Math.Min(padIndex, padCount - 1);
            padIndex = System.Math.Max(padIndex, 0);
            comboPadIndex_.SetSelectedIndex(padIndex);

            return true;
        }

        public void UpdateKeyAssign()
        {
            int row = viewKey_.GetSelectedRow();
            if (row < 0)
            {
                return;
            }

            DnhConfiguration config = DnhConfiguration.GetInstance();
            ref_count_ptr<VirtualKey> vk = config.GetVirtualKey(row);
            EDirectInput input = EDirectInput.GetInstance();

            bool bChange = false;
            int pushKeyCode = -1;
            List<int> listValidCode = listKeyCode_.GetValidCodeList();
            for (int iCode = 0 ; iCode < listValidCode.Count ; iCode++)
            {
                int code = listValidCode[iCode];
                int state = input.GetKeyState(code);
                if (state != KEY_PUSH)
                {
                    continue;
                }

                pushKeyCode = code;
                bChange = true;
                break;
            }
            if (pushKeyCode >= 0)
            {
                vk.SetKeyCode(pushKeyCode);
            }

            int pushPadIndex = comboPadIndex_.GetSelectedIndex();
            int pushPadButton = -1;
            for (int iButton = 0 ; iButton < DirectInput.MAX_PAD_BUTTON ; iButton++)
            {
                int state = input.GetPadState(pushPadIndex, iButton);
                if (state != KEY_PUSH)
                {
                    continue;
                }

                pushPadButton = iButton;
                bChange = true;
                break;
            }
            if (pushPadButton >= 0)
            {
                vk.SetPadIndex(pushPadIndex);
                vk.SetPadButton(pushPadButton);
            }

            if (bChange)
            {
                _UpdateText(row);

                int nextRow = row + 1;
                if (pushKeyCode >= 0 && false)
                {
                    if (pushKeyCode == DIK_UP)
                    {
                        nextRow++;
                    }
                    if (pushKeyCode == DIK_DOWN)
                    {
                        nextRow--;
                    }
                }
                if (nextRow >= viewKey_.GetRowCount())
                {
                    nextRow = 0;
                }
                viewKey_.SetSelectedRow(nextRow);
            }
        }

        public void ReadConfiguration()
        {
        }

        public void WriteConfiguration()
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            int padIndex = comboPadIndex_.GetSelectedIndex();
            config.SetPadIndex(padIndex);
        }
}


/**********************************************************
//OptionPanel
**********************************************************/
public class OptionPanel : WPanel
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        protected enum AnonymousEnum2
        {
            ROW_LOG_WINDOW,
            ROW_LOG_FILE,
            ROW_MOUSE_UNVISIBLE
        }
        protected ref_count_ptr<WListView> viewOption_ = new ref_count_ptr<WListView>();

        protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            return WPanel._WindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //OptionPanel
        **********************************************************/
        public OptionPanel()
        {
        }

        public new void Dispose()
        {

            base.Dispose();
        }

        public bool Initialize(IntPtr hParent)
        {
            hWnd_ = global::CreateDialog((IntPtr)GetWindowLong(null,GWL_HINSTANCE), MAKEINTRESOURCE(IDD_PANEL_OPTION), hParent,(DLGPROC)_StaticWindowProcedure);
            Attach(hWnd_);

            IntPtr hListOption = global::GetDlgItem(hWnd_, IDC_LIST_OPTION);
            uint dwStyle = ListView_GetExtendedListViewStyle(hListOption);
            dwStyle |= LVS_EX_FULLROWSELECT | LVS_EX_CHECKBOXES;
            ListView_SetExtendedListViewStyle(hListOption, dwStyle);

            viewOption_ = new WListView();
            viewOption_.Attach(hListOption);
            viewOption_.AddColumn(292, 0, "Option(�I�v�V����)");
            viewOption_.SetText(AnonymousEnum2.ROW_LOG_WINDOW, 0, "Show LogWindow(���O�E�B���h�E��\������)");
            viewOption_.SetText(AnonymousEnum2.ROW_LOG_FILE, 0, "Save LogFile(���O�t�@�C����ۑ�����)");
            viewOption_.SetText(AnonymousEnum2.ROW_MOUSE_UNVISIBLE, 0, "Hide Mouse Cursor(�}�E�X�J�[�\�����\���ɂ���)");

            return true;
        }

        public void ReadConfiguration()
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            IntPtr hListOption = viewOption_.GetWindowHandle();
            if (config.IsLogWindow())
            {
                ListView_SetItemState(hListOption, AnonymousEnum2.ROW_LOG_WINDOW, INDEXTOSTATEIMAGEMASK(2),LVIS_STATEIMAGEMASK);
            }
            if (config.IsLogFile())
            {
                ListView_SetItemState(hListOption, AnonymousEnum2.ROW_LOG_FILE, INDEXTOSTATEIMAGEMASK(2),LVIS_STATEIMAGEMASK);
            }
            if (!config.IsMouseVisible())
            {
                ListView_SetItemState(hListOption, AnonymousEnum2.ROW_MOUSE_UNVISIBLE, INDEXTOSTATEIMAGEMASK(2),LVIS_STATEIMAGEMASK);
            }
        }

        public void WriteConfiguration()
        {
            DnhConfiguration config = DnhConfiguration.GetInstance();
            IntPtr hListOption = viewOption_.GetWindowHandle();
            config.SetLogWindow(ListView_GetCheckState(hListOption, AnonymousEnum2.ROW_LOG_WINDOW) ? true : false);
            config.SetLogFile(ListView_GetCheckState(hListOption, AnonymousEnum2.ROW_LOG_FILE) ? true : false);
            config.SetMouseVisible(ListView_GetCheckState(hListOption, AnonymousEnum2.ROW_MOUSE_UNVISIBLE) ? false : true);
        }
}

