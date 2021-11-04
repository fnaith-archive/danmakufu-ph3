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

/**********************************************************
//ScriptSelectDialog
**********************************************************/
public class ScriptSelectDialog : ModalDialog
{
        protected const string KEY_ALL = "All";
        protected const string KEY_SINGLE = "Single";
        protected const string KEY_PLURAL = "Plural";
        protected const string KEY_STAGE = "Stage";
        protected const string KEY_PACKAGE = "Package";
        protected const string KEY_PLAYER = "Player";

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        protected enum AnonymousEnum
        {
            LIST_TYPE,
            LIST_NAME,
            LIST_PATH,
            LIST_ARCHIVE,
            LIST_TEXT
        }

        protected WListView listView_ = new WListView();
        protected WButton buttonOk_ = new WButton();
        protected WButton buttonCancel_ = new WButton();
        protected WComboBox combo_ = new WComboBox();

        protected List<ref_count_ptr<ScriptInformation>> listInfo_ = new List<ref_count_ptr<ScriptInformation>>();
        protected ref_count_ptr<ScriptInformation> infoSelected_ = new ref_count_ptr<ScriptInformation>();

        protected virtual bool _IsValidScript(ref_count_ptr<ScriptInformation> info)
        {
            return null;
        }
        protected void _SearchScript(string dir)
        {
            WIN32_FIND_DATA data = new WIN32_FIND_DATA();
            IntPtr hFind;
            string findDir = dir + "*.*";
            hFind = FindFirstFile(findDir, data);
            do
            {
                string name = data.cFileName;
                if ((data.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) != 0 && (name != ".." && name != "."))
                {
                    // �f�B���N�g��
                    string tDir = dir + name;
                    tDir += "/";

                    _SearchScript(tDir);
                    continue;
                }
                if (wcscmp(data.cFileName, "..") == 0 || wcscmp(data.cFileName, ".") == 0)
                {
                    continue;
                }

                // �t�@�C��
                string path = dir + name;

                List<ref_count_ptr<ScriptInformation>> listInfo = ScriptInformation.CreateScriptInformationList(path, true);
                for (int iInfo = 0 ; iInfo < listInfo.Count ; iInfo++)
                {
                    ref_count_ptr<ScriptInformation> info = listInfo[iInfo];
                    if (!_IsValidScript(new ref_count_ptr<ScriptInformation>(info)))
                    {
                        continue;
                    }

                    listInfo_.Add(info);
                }

            }while (FindNextFile(hFind, data));
            FindClose(hFind);
        }

        protected virtual void _Filter()
        {
        }
        protected override int _WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
        {
            switch (uMsg)
            {
                case WM_DESTROY:
                {
                    _FinishMessageLoop();
                    break;
                }
                case WM_CLOSE:
                    SetWindowVisible(false);
                    _FinishMessageLoop();
                    break;
                case WM_COMMAND:
                {
                    switch (wParam & 0xffff)
                    {
                        case IDCANCEL: // ����{�^��
                            SetWindowVisible(false);
                            _FinishMessageLoop();
                            break;

                        case IDOK:
                        {
                            int index = listView_.GetSelectedRow();
                            if (index != -1)
                            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoSelected_ = listInfo_[index];
                                infoSelected_.CopyFrom(listInfo_[index]);
                            }
                            else
                            {
                                infoSelected_ = null;
                            }
                            SetWindowVisible(false);
                            _FinishMessageLoop();
                            break;
                        }

                        case IDC_BUTTON_RELOAD_SCRIPT:
                            _Filter();
                            break;
                    }
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

                    int topList = wy + 110;
                    int heightList = wHeight - topList - 40;
                    listView_.SetBounds(wx + 10, topList, wWidth - 20, heightList);

                    combo_.SetBounds(wx + 64, wy + 60, 200, 100);

                    int topButton = topList + heightList + 10;
                    int widthButton = buttonOk_.GetClientWidth();
                    int heightButton = buttonOk_.GetClientHeight();
                    buttonCancel_.SetBounds(wWidth - widthButton * 1 - 8, topButton, widthButton, heightButton);
                    buttonOk_.SetBounds(wWidth - widthButton * 2 - 16, topButton, widthButton, heightButton);

                    break;
                }
                case WM_NOTIFY:
                {
                    LPNMHDR lpnmhdr = (LPNMHDR)lParam;
                    if (lpnmhdr.hwndFrom == listView_.GetWindowHandle())
                    {
                        switch (lpnmhdr.code)
                        {
                            case NM_DBLCLK:
                            {
                            // case NM_CLICK:
                                int index = listView_.GetSelectedRow();
                                if (index != -1)
                                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: infoSelected_ = listInfo_[index];
                                    infoSelected_.CopyFrom(listInfo_[index]);
                                }
                                else
                                {
                                    infoSelected_ = null;
                                }
                                SetWindowVisible(false);
                                _FinishMessageLoop();
                                break;
                            }
                        }
                    }
                    break;
                }
            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //ScriptSelectDialog
        **********************************************************/
        public virtual void Initialize()
        {
            hParent_ = MainWindow.GetInstance().GetWindowHandle();
            Create(hParent_, MAKEINTRESOURCE(IDD_DIALOG_SELECT_SCRIPT));
            SetWindowVisible(false);

            // ListView
            IntPtr hList = GetDlgItem(hWnd_, IDC_LIST_SELECT_SCRIPT);
            listView_.Attach(hList);
            uint dwStyle = ListView_GetExtendedListViewStyle(hList);
            dwStyle |= LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES;
            ListView_SetExtendedListViewStyle(hList, dwStyle);

            listView_.AddColumn(48, (int)AnonymousEnum.LIST_TYPE, "Type");
            listView_.AddColumn(200, (int)AnonymousEnum.LIST_NAME, "Name");
            listView_.AddColumn(64, (int)AnonymousEnum.LIST_ARCHIVE, "Archive");
            listView_.AddColumn(64, (int)AnonymousEnum.LIST_PATH, "Path");
            listView_.AddColumn(300, (int)AnonymousEnum.LIST_TEXT, "Text");

            // �{�^��
            buttonOk_.Attach(GetDlgItem(hWnd_, IDOK));
            buttonCancel_.Attach(GetDlgItem(hWnd_, IDCANCEL));
        }

        public virtual void ShowModal(string path)
        {
            for (int iInfo = 0 ; iInfo < listInfo_.Count ; iInfo++)
            {
                ref_count_ptr<ScriptInformation> info = listInfo_[iInfo];
                if (!File.IsEqualsPath(path, info.GetScriptPath()))
                {
                    continue;
                }
                listView_.SetSelectedRow(iInfo);
                break;
            }

            MoveWindowCenter();
            SetWindowVisible(true);
            _RunMessageLoop();
        }

        public ref_count_ptr<ScriptInformation> GetSelectedScript()
        {
            return new ref_count_ptr<ScriptInformation>(infoSelected_);
        }
}

/**********************************************************
//EnemySelectDialog
**********************************************************/
public class EnemySelectDialog : ScriptSelectDialog
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum2
        {
            INDEX_ALL = 0,
            INDEX_SINGLE,
            INDEX_PLURAL,
            INDEX_STAGE,
            INDEX_PACKAGE
        }
        private override void _Filter()
        {
            listView_.Clear();

            int index = combo_.GetSelectedIndex();
            listInfo_.Clear();

            string dir = PathProperty.GetModuleDirectory() + "script/";
            _SearchScript(dir);

// C++ TO C# CONVERTER TODO TASK: The 'Compare' parameter of std::sort produces a boolean value, while the .NET Comparison parameter produces a tri-state result:
// ORIGINAL LINE: std::sort(listInfo_.begin(), listInfo_.end(), ScriptInformation::Sort());
            listInfo_.Sort(new ScriptInformation.Sort());

            List<ref_count_ptr<ScriptInformation>>.Enumerator itr = listInfo_.GetEnumerator();
            for (int iRow = 0; itr.MoveNext(); itr++, iRow++)
            {
                ref_count_ptr<ScriptInformation> info = itr.Current;
                string strType = "";
                switch (info.GetType())
                {
                case ScriptInformation.TYPE_SINGLE:
                    strType = KEY_SINGLE;
                    break;
                case ScriptInformation.TYPE_PLURAL:
                    strType = KEY_PLURAL;
                    break;
                case ScriptInformation.TYPE_STAGE:
                    strType = KEY_STAGE;
                    break;
                case ScriptInformation.TYPE_PACKAGE:
                    strType = KEY_PACKAGE;
                    break;
                }

                string path = info.GetScriptPath();
                path = PathProperty.ReplaceYenToSlash(path);

                string root = PathProperty.GetModuleDirectory();
                root = PathProperty.ReplaceYenToSlash(root);
                path = StringUtility.ReplaceAll(path, root, "");

                string archive = info.GetArchivePath();
                if (archive.Length > 0)
                {
                    archive = PathProperty.ReplaceYenToSlash(archive);
                    archive = StringUtility.ReplaceAll(archive, root, "");
                }

                listView_.SetText(iRow, LIST_TYPE, strType);
                listView_.SetText(iRow, LIST_NAME, PathProperty.GetFileName(path));
                listView_.SetText(iRow, LIST_ARCHIVE, archive);
                listView_.SetText(iRow, LIST_PATH, path);
                listView_.SetText(iRow, LIST_TEXT, info.GetText());
            }

        }

        private override bool _IsValidScript(ref_count_ptr<ScriptInformation> info)
        {
            int type = combo_.GetSelectedIndex();
            int typeScript = info.GetType();
            bool bTarget = false;
            switch (type)
            {
                case AnonymousEnum2.INDEX_SINGLE:
                    bTarget = (typeScript == ScriptInformation.TYPE_SINGLE);
                    break;
                case AnonymousEnum2.INDEX_PLURAL:
                    bTarget = (typeScript == ScriptInformation.TYPE_PLURAL);
                    break;
                case AnonymousEnum2.INDEX_STAGE:
                    bTarget = (typeScript == ScriptInformation.TYPE_STAGE);
                    break;
                case AnonymousEnum2.INDEX_PACKAGE:
                    bTarget = (typeScript == ScriptInformation.TYPE_PACKAGE);
                    break;
                case AnonymousEnum2.INDEX_ALL:
                    bTarget = (typeScript != ScriptInformation.TYPE_PLAYER);
                    break;
            }

            return bTarget;
        }

        /**********************************************************
        //EnemySelectDialog
        **********************************************************/
        public EnemySelectDialog()
        {

        }

        public new void Initialize()
        {
            base.Initialize();

            SetWindowText(GetWindowHandle(), "�G�X�N���v�g�I��");

            // �R���{
            combo_.Attach(GetDlgItem(hWnd_, IDC_COMBO_TYPE_SCRIPT));
            combo_.InsertString((int)AnonymousEnum2.INDEX_ALL, KEY_ALL);
            combo_.InsertString((int)AnonymousEnum2.INDEX_SINGLE, KEY_SINGLE);
            combo_.InsertString((int)AnonymousEnum2.INDEX_PLURAL, KEY_PLURAL);
            combo_.InsertString((int)AnonymousEnum2.INDEX_STAGE, KEY_STAGE);
            combo_.InsertString((int)AnonymousEnum2.INDEX_PACKAGE, KEY_PACKAGE);
            combo_.SetSelectedIndex((int)AnonymousEnum2.INDEX_ALL);

            _Filter();

            SetBounds(0, 0, 640, 480);
        }
}

/**********************************************************
//PlayerSelectDialog
**********************************************************/
public class PlayerSelectDialog : ScriptSelectDialog
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        private enum AnonymousEnum3
        {
            INDEX_PLAYER = 0
        }
        private override void _Filter()
        {
            listView_.Clear();

            int index = combo_.GetSelectedIndex();
            listInfo_.Clear();

            string dir = PathProperty.GetModuleDirectory() + "script/";
            _SearchScript(dir);

// C++ TO C# CONVERTER TODO TASK: The 'Compare' parameter of std::sort produces a boolean value, while the .NET Comparison parameter produces a tri-state result:
// ORIGINAL LINE: std::sort(listInfo_.begin(), listInfo_.end(), ScriptInformation::Sort());
            listInfo_.Sort(new ScriptInformation.Sort());

            List<ref_count_ptr<ScriptInformation>>.Enumerator itr = listInfo_.GetEnumerator();
            for (int iRow = 0; itr.MoveNext(); itr++, iRow++)
            {
                ref_count_ptr<ScriptInformation> info = itr.Current;
                string strType = "";
                switch (info.GetType())
                {
                case ScriptInformation.TYPE_PLAYER:
                    strType = KEY_PLAYER;
                    break;
                }

                string path = info.GetScriptPath();
                path = PathProperty.ReplaceYenToSlash(path);

                string root = PathProperty.GetModuleDirectory();
                root = PathProperty.ReplaceYenToSlash(root);
                path = StringUtility.ReplaceAll(path, root, "");

                string archive = info.GetArchivePath();
                if (archive.Length > 0)
                {
                    archive = PathProperty.ReplaceYenToSlash(archive);
                    archive = StringUtility.ReplaceAll(archive, root, "");
                }

                listView_.SetText(iRow, LIST_TYPE, strType);
                listView_.SetText(iRow, LIST_NAME, PathProperty.GetFileName(path));
                listView_.SetText(iRow, LIST_ARCHIVE, archive);
                listView_.SetText(iRow, LIST_PATH, path);
                listView_.SetText(iRow, LIST_TEXT, info.GetText());
            }

        }

        private override bool _IsValidScript(ref_count_ptr<ScriptInformation> info)
        {
            int type = combo_.GetSelectedIndex();
            int typeScript = info.GetType();
            bool bTarget = false;
            switch (type)
            {
                case AnonymousEnum3.INDEX_PLAYER:
                    bTarget = (typeScript == ScriptInformation.TYPE_PLAYER);
                    break;
            }

            return bTarget;
        }


        /**********************************************************
        //PlayerSelectDialog
        **********************************************************/
        public PlayerSelectDialog()
        {

        }

        public new void Initialize()
        {
            base.Initialize();

            SetWindowText(GetWindowHandle(), "���@�X�N���v�g�I��");

            // �R���{
            combo_.Attach(GetDlgItem(hWnd_, IDC_COMBO_TYPE_SCRIPT));
            combo_.InsertString((int)AnonymousEnum3.INDEX_PLAYER, KEY_PLAYER);
            combo_.SetSelectedIndex((int)AnonymousEnum3.INDEX_PLAYER);
            combo_.SetWindowEnable(false);

            _Filter();

            SetBounds(0, 0, 640, 480);
        }
}


