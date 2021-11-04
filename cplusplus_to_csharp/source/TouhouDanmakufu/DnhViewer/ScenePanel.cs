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
//ScenePanel
**********************************************************/
public class ScenePanel : WPanel
{
    private class ScriptPathPanel : WPanel
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                TYPE_ENEMY,
                TYPE_PLAYER
            }
            protected WLabel labelPath_ = new WLabel();
            protected WEditBox editPath_ = new WEditBox();
            protected WButton buttonPath_ = new WButton();
            protected ref_count_ptr<ScriptSelectDialog> dialogSelect_ = new ref_count_ptr<ScriptSelectDialog>();
            protected ref_count_ptr<ScriptInformation> infoSelected_ = new ref_count_ptr<ScriptInformation>();

            protected int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
            {
                switch (uMsg)
                {
                    case WM_COMMAND:
                    {
                        int id = wParam & 0xffff; // LOWORD(wParam);
                        if (id == buttonPath_.GetWindowId())
                        {
            /*
            				std::string path;
            				path.resize(MAX_PATH*4);
            				OPENFILENAME ofn;
            				ZeroMemory(&ofn,sizeof(OPENFILENAME));
            				ofn.lStructSize=sizeof(OPENFILENAME);
            				ofn.hwndOwner = hWnd_;
            				ofn.nMaxFile = path.size();
            				ofn.lpstrFile = &path[0];
            				ofn.Flags = OFN_EXPLORER | OFN_HIDEREADONLY;
            				ofn.nFilterIndex = 1;
            				ofn.lpstrDefExt = ".txt";
            				ofn.lpstrFilter = "�S�Ẵt�@�C�� (*.*)\0*.*\0";
            				ofn.lpstrTitle = "�X�N���v�g��J��";
            				if(GetOpenFileName(&ofn))
            				{
            					editPath_.SetText(path);
            				}
            */
                            string path = editPath_.GetText();
                            dialogSelect_.ShowModal(path);

                            ref_count_ptr<ScriptInformation> info = dialogSelect_.GetSelectedScript();
                            if (info != null)
                            {
                                infoSelected_ = info;
                                editPath_.SetText(info.GetScriptPath());
                            }
                        }
                        break;
                    }
                    case WM_DROPFILES:
                    {
                        string szFileName = new string(new char[MAX_PATH]);
                        IntPtr hDrop = (IntPtr)wParam;
                        uint uFileNo = DragQueryFile((IntPtr)wParam,0xFFFFFFFF,null,0);

                        for (int iDrop = 0 ; iDrop < (int)uFileNo ; iDrop++)
                        {
                            DragQueryFile(hDrop, iDrop, szFileName, sizeof(char));
                            string path = szFileName;

                            ref_count_ptr<ScriptInformation> info = _CreateScriptInformation(path);
                            if (info != null)
                            {
                                infoSelected_ = info;
                                editPath_.SetText(info.GetScriptPath());
                            }
                            break;
                        }
                        DragFinish(hDrop);

                        break;
                    }
                }
                return WPanel._WindowProcedure(hWnd, uMsg, wParam, lParam);
            }

            protected ref_count_ptr<ScriptInformation> _CreateScriptInformation(string path)
            {
                File file = new File(path);
                if (!file.Open())
                {
                    return null;
                }

                string source = "";
                int size = file.GetSize();
                source.resize(size);
                file.Read(source[0], size);

                ref_count_ptr<ScriptInformation> info = ScriptInformation.CreateScriptInformation(path, "", source);

                return new ref_count_ptr<ScriptInformation>(info);
            }


            // ScriptPathPanel
            public virtual void Dispose()
            {

            }

            public bool Initialize(int type, IntPtr hParent)
            {
                Create(hParent);

                gstd.WEditBox.Style styleEdit = new gstd.WEditBox.Style();
                styleEdit.SetStyle(WS_CHILD | WS_VISIBLE | WS_HSCROLL | ES_AUTOHSCROLL);
                styleEdit.SetStyleEx(WS_EX_CLIENTEDGE);
                WButton.Style stylePath = new WButton.Style();
                stylePath.SetStyle(WS_CHILD | WS_VISIBLE | BS_PUSHLIKE);

                {
                    labelPath_.Create(hWnd_);
                    if (type == TYPE_ENEMY)
                    {
                        labelPath_.SetText("�G�X�N���v�g");
                    }
                    else
                    {
                        labelPath_.SetText("���@�X�N���v�g");
                    }

                    editPath_.Create(hWnd_, styleEdit);


                    buttonPath_.Create(hWnd_, stylePath);
                    buttonPath_.SetText("�I��");
                }

                labelPath_.SetBounds(8, 12, 72, 20);
                editPath_.SetBounds(80, 8, 300, 20);
                buttonPath_.SetBounds(388, 8, 48, 20);

                DragAcceptFiles(hWnd_, true);

                if (type == TYPE_ENEMY)
                {
                    dialogSelect_ = new EnemySelectDialog();
                }
                else
                {
                    dialogSelect_ = new PlayerSelectDialog();
                }

                dialogSelect_.Initialize();

                return true;
            }

            public void SetWindowEnable(bool bEnable)
            {
                editPath_.SetWindowEnable(bEnable);
                buttonPath_.SetWindowEnable(bEnable);
            }

            public string GetPath()
            {
                return editPath_.GetText();
            }
            public void SetPath(string path)
            {
                ref_count_ptr<ScriptInformation> info = _CreateScriptInformation(path);
                if (info == null)
                {
                    return;
                }

                infoSelected_ = info;
                editPath_.SetText(path);
            }

            public ref_count_ptr<ScriptInformation> GetSelectedScriptInformation()
            {
                return infoSelected_;
            }
    }
        private bool bFixedArea_;
        private ref_count_ptr<ScriptPathPanel> panelPathEnemy_ = new ref_count_ptr<ScriptPathPanel>();
        private ref_count_ptr<ScriptPathPanel> panelPathPlayer_ = new ref_count_ptr<ScriptPathPanel>();

        private WButton buttonStart_ = new WButton();
        private WButton buttonPause_ = new WButton();


        /**********************************************************
        //EventScenePanel
        **********************************************************/
        private new int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_COMMAND:
                {
                    int id = wParam & 0xffff; // LOWORD(wParam);
                    if (id == buttonStart_.GetWindowId())
                    {
                        MainWindow wndMain = MainWindow.GetInstance();
                        if (wndMain.GetStgController() == null)
                        {
                            StartStg();
                        }
                        else
                        {
                            DirectSoundManager soundManager = DirectSoundManager.GetBase();
                            soundManager.Clear();
                            EndStg();
                        }

                    }
                    else if (id == buttonPause_.GetWindowId())
                    {
                        bool bCheck = SendMessage(buttonPause_.GetWindowHandle(), BM_GETCHECK, 0, 0) == BST_CHECKED;
                        ETaskManager.GetInstance().SetWorkFunctionEnable(!bCheck);
                        EFpsController.GetInstance().SetCriticalFrame();
                    }

                    break;
                }

            }
            return WPanel._WindowProcedure(hWnd, uMsg, wParam, lParam);
        }

        public override void LocateParts()
        {
            int wx = GetClientX();
            int wy = GetClientY();
            int wWidth = GetClientWidth();
            int wHeight = GetClientHeight();

            panelPathEnemy_.SetBounds(wx + 8, wy + 0, 480, 28);
            panelPathPlayer_.SetBounds(wx + 8, wy + 24, 480, 28);

            buttonStart_.SetBounds(wx + 8, wy + 60, 48, 20);
            buttonPause_.SetBounds(wx + 64, wy + 60, 48, 20);

            int gx = wx;
            int gy = wy + 88;
            int gWidth = 640;
            int gHeight = 480;

            if (!bFixedArea_)
            {
        /*
        		if(gWidth > gHeight*4/3)
        		{//�������L��
        			gWidth = gHeight*4/3;
        			gHeight = gWidth*3/4;
        			gHeight = gHeight > wHeight ? wHeight : gHeight;
        			gWidth = gHeight*4/3;
        		}
        		else
        		{//�c�����L��
        			gHeight = gWidth*3/4;
        			gHeight = gHeight > wHeight ? wHeight : gHeight;
        			gWidth = gHeight*4/3;
        		}
        */
                DnhConfiguration config = DnhConfiguration.CreateInstance();
                int screenWidth = config.GetScreenWidth();
                int screenHeight = config.GetScreenHeight();

                int width = wWidth;
                int height = wHeight - gy;
                double ratioWH = (double)screenWidth / (double)screenHeight;
                double ratioHW = (double)screenHeight / (double)screenWidth;

                if (height > wHeight)
                {
                    height = wHeight;
                }
                width = (int)(double)height / ratioHW;

                if (width > wWidth)
                {
                    width = wWidth;
                }
                height = (int)(double)width / ratioWH;

                if (height > wHeight)
                {
                    height = wHeight;
                }
                width = (int)(double)height / ratioHW;

                gWidth = width;
                gHeight = height;
            }

            GraphicsWindow wndGraphics = MainWindow.GetInstance().GetGraphicsWindow();
            wndGraphics.SetBounds(gx, gy, gWidth, gHeight);
        }

        public bool Initialize(IntPtr hParent)
        {
            Create(hParent);

            bFixedArea_ = false;

            buttonStart_.Create(hWnd_);
            buttonStart_.SetText("�J�n");

            panelPathEnemy_ = new ScriptPathPanel();
            panelPathEnemy_.Initialize(ScriptPathPanel.AnonymousEnum.TYPE_ENEMY, hWnd_);
            panelPathPlayer_ = new ScriptPathPanel();
            panelPathPlayer_.Initialize(ScriptPathPanel.AnonymousEnum.TYPE_PLAYER, hWnd_);

            WButton.Style styleCheck = new WButton.Style();
            styleCheck.SetStyle(WS_CHILD | WS_VISIBLE | BS_PUSHLIKE | BS_AUTOCHECKBOX);
            buttonPause_.Create(hWnd_, styleCheck);
            buttonPause_.SetText("��~");
            buttonPause_.SetWindowEnable(false);

            GraphicsWindow wndGraphics = MainWindow.GetInstance().GetGraphicsWindow();
            wndGraphics.SetWindowType(GraphicsWindow.TYPE_WINDOW_PANEL, hWnd_);

            return true;
        }

        public bool StartStg()
        {
            MainWindow wndMain = MainWindow.GetInstance();
            string pathEnemy = panelPathEnemy_.GetPath();
            string pathPlayer = panelPathPlayer_.GetPath();
            bool res = false;
            try
            {
                ref_count_ptr<ScriptInformation> infoEnemy = panelPathEnemy_.GetSelectedScriptInformation();
                if (infoEnemy == null)
                {
                    throw new gstd.wexception("�G�X�N���v�g���s���ł�");
                }

                ref_count_ptr<StgControllerForViewer> controller = StgControllerForViewer.Create();
                if (infoEnemy.GetType() == ScriptInformation.TYPE_PACKAGE)
                {
                    ref_count_ptr<StgSystemInformation> infoStgSystem = new StgSystemInformation();
                    infoStgSystem.SetMainScriptInformation(infoEnemy);
                    controller.Initialize(infoStgSystem);
                    controller.Start(null, null);
                }
                else
                {
                    ref_count_ptr<ScriptInformation> infoPlayer = panelPathPlayer_.GetSelectedScriptInformation();
                    if (infoPlayer == null)
                    {
                        throw new gstd.wexception("���@�X�N���v�g���s���ł�");
                    }

                    ref_count_ptr<StgSystemInformation> infoStgSystem = new StgSystemInformation();
                    infoStgSystem.SetMainScriptInformation(infoEnemy);
                    controller.Initialize(infoStgSystem);

                    // �X�e�[�W
                    controller.Start(infoPlayer, null);
                }

                wndMain.SetStgController(new ref_count_ptr<StgControllerForViewer>(controller));
            }
            catch (gstd.wexception e)
            {
                ErrorDialog.ShowErrorDialog(e.what());
                Logger.WriteTop(e.what());
            }
            catch
            {
                MessageBox(hWnd_, "�J�n���s", "error", MB_OK);
                Logger.WriteTop("�J�n���s");
            }

            return true;
        }

        public bool EndStg()
        {
            MainWindow wndMain = MainWindow.GetInstance();
            wndMain.SetStgController(null);
            return true;
        }

        public void SetStgState(bool bStart)
        {
            if (bStart)
            {
                buttonStart_.SetText("�I��");
                buttonPause_.SetWindowEnable(true);

                panelPathEnemy_.SetWindowEnable(false);
                panelPathPlayer_.SetWindowEnable(false);
            }
            else
            {
                buttonStart_.SetText("�J�n");
                buttonPause_.SetWindowEnable(false);
                panelPathEnemy_.SetWindowEnable(true);
                panelPathPlayer_.SetWindowEnable(true);
                global::SendMessage(buttonPause_.GetWindowHandle(), BM_SETCHECK, BST_UNCHECKED, 0);
            }
        }

        public bool IsFixedArea()
        {
            return bFixedArea_;
        }
        public void SetFixedArea(bool bFixed)
        {
            bFixedArea_ = bFixed;
        }

        public void ClearData()
        {
            panelPathEnemy_.SetPath("");
            panelPathPlayer_.SetPath("");
        }

        public virtual void Read(RecordBuffer record)
        {
            string pathEnemy = record.GetRecordAsStringW("pathEnemy");
            panelPathEnemy_.SetPath(pathEnemy);
            string pathPlayer = record.GetRecordAsStringW("pathPlayer");
            panelPathPlayer_.SetPath(pathPlayer);
        }

        public virtual void Write(RecordBuffer record)
        {
            record.SetRecordAsStringW("pathEnemy", panelPathEnemy_.GetPath());
            record.SetRecordAsStringW("pathPlayer", panelPathPlayer_.GetPath());
        }
}


