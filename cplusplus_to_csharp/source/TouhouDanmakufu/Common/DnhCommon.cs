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
//ScriptInformation
**********************************************************/
public class ScriptInformation : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            TYPE_UNKNOWN,
            TYPE_PLAYER,
            TYPE_SINGLE,
            TYPE_PLURAL,
            TYPE_STAGE,
            TYPE_PACKAGE,

            MAX_ID = 8
        }
        public const string DEFAULT = "DEFAULT";
        public class Sort
        {
            public static bool functorMethod(ref_count_ptr<ScriptInformation> lf, ref_count_ptr<ScriptInformation> rf)
            {
                ref_count_ptr<ScriptInformation> lsp = new ref_count_ptr<ScriptInformation>(lf);
                ref_count_ptr<ScriptInformation> rsp = new ref_count_ptr<ScriptInformation>(rf);
                ScriptInformation lp = (ScriptInformation)lsp.GetPointer();
                ScriptInformation rp = (ScriptInformation)rsp.GetPointer();
                string lPath = lp.GetScriptPath();
                string rPath = rp.GetScriptPath();
                bool res = CompareString(LOCALE_SYSTEM_DEFAULT, NORM_IGNORECASE, lPath, -1, rPath, -1);
                return res == CSTR_LESS_THAN ? true : false;
            }
        }
        public class PlayerListSort
        {
            public static bool functorMethod(ref_count_ptr<ScriptInformation> lf, ref_count_ptr<ScriptInformation> rf)
            {
                ref_count_ptr<ScriptInformation> lsp = new ref_count_ptr<ScriptInformation>(lf);
                ref_count_ptr<ScriptInformation> rsp = new ref_count_ptr<ScriptInformation>(rf);
                string lPath = lsp.GetScriptPath();
                string rPath = rsp.GetScriptPath();
                bool res = CompareString(LOCALE_SYSTEM_DEFAULT, NORM_IGNORECASE, lPath, -1, rPath, -1);
                return res == CSTR_LESS_THAN ? true : false;
            }
        }
        private int type_;
        private string pathArchive_ = "";
        private string pathScript_ = "";

        private string id_ = "";
        private string title_ = "";
        private string text_ = "";
        private string pathImage_ = "";
        private string pathSystem_ = "";
        private string pathBackground_ = "";
        private string pathBGM_ = "";
        private List<string> listPlayer_ = new List<string>();

        private string replayName_ = "";


        public ScriptInformation()
        {
        }
        public virtual void Dispose()
        {
        }
        public int GetType()
        {
            return type_;
        }
        public void SetType(int type)
        {
            type_ = type;
        }
        public string GetArchivePath()
        {
            return pathArchive_;
        }
        public void SetArchivePath(string path)
        {
            pathArchive_ = path;
        }
        public string GetScriptPath()
        {
            return pathScript_;
        }
        public void SetScriptPath(string path)
        {
            pathScript_ = path;
        }

        public string GetID()
        {
            return id_;
        }
        public void SetID(string id)
        {
            id_ = id;
        }
        public string GetTitle()
        {
            return title_;
        }
        public void SetTitle(string title)
        {
            title_ = title;
        }
        public string GetText()
        {
            return text_;
        }
        public void SetText(string text)
        {
            text_ = text;
        }
        public string GetImagePath()
        {
            return pathImage_;
        }
        public void SetImagePath(string path)
        {
            pathImage_ = path;
        }
        public string GetSystemPath()
        {
            return pathSystem_;
        }
        public void SetSystemPath(string path)
        {
            pathSystem_ = path;
        }
        public string GetBackgroundPath()
        {
            return pathBackground_;
        }
        public void SetBackgroundPath(string path)
        {
            pathBackground_ = path;
        }
        public string GetBgmPath()
        {
            return pathBGM_;
        }
        public void SetBgmPath(string path)
        {
            pathBGM_ = path;
        }
        public List<string> GetPlayerList()
        {
            return new List<string>(listPlayer_);
        }
        public void SetPlayerList(List<string> list)
        {
            listPlayer_ = new List<string>(list);
        }

        public string GetReplayName()
        {
            return replayName_;
        }
        public void SetReplayName(string name)
        {
            replayName_ = name;
        }

        public List<ref_count_ptr<ScriptInformation>> CreatePlayerScriptInformationList()
        {
            List<ref_count_ptr<ScriptInformation>> res = new List<new ref_count_ptr<ScriptInformation>>();
            List<string> listPlayerPath = GetPlayerList();
            string dirInfo = PathProperty.GetFileDirectory(GetScriptPath());
            for (int iPath = 0 ; iPath < listPlayerPath.Count ; iPath++)
            {
                string pathPlayer = listPlayerPath[iPath];
                string path = EPathProperty.ExtendRelativeToFull(dirInfo, pathPlayer);

                ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(path);
                if (reader == null || !reader.Open())
                {
                    Logger.WriteTop(ErrorUtility.GetFileNotFoundErrorMessage(path));
                    continue;
                }

                string source = "";
                int size = reader.GetFileSize();
                source.resize(size);
                reader.Read(source[0], size);

                ref_count_ptr<ScriptInformation> info = ScriptInformation.CreateScriptInformation(path, "", source);
                if (info != null && info.GetType() == ScriptInformation.AnonymousEnum.TYPE_PLAYER)
                {
                    res.Add(info);
                }
            }
            return new List<ref_count_ptr<ScriptInformation>>(res);
        }


        /**********************************************************
        //ScriptInformation
        **********************************************************/

        public static ref_count_ptr<ScriptInformation> CreateScriptInformation(string pathScript, bool bNeedHeader = true)
        {
            ref_count_ptr<FileReader> reader = FileManager.GetBase().GetFileReader(pathScript);
            if (reader == null || !reader.Open())
            {
                Logger.WriteTop(ErrorUtility.GetFileNotFoundErrorMessage(pathScript));
                return null;
            }

            string source = "";
            int size = reader.GetFileSize();
            source.resize(size);
            reader.Read(source[0], size);

            ref_count_ptr<ScriptInformation> res = CreateScriptInformation(pathScript, "", source, bNeedHeader);
            return new ref_count_ptr<ScriptInformation>(res);
        }

        public static ref_count_ptr<ScriptInformation> CreateScriptInformation(string pathScript, string pathArchive, string source, bool bNeedHeader = true)
        {
            ref_count_ptr<ScriptInformation> res = null;

            Scanner scanner = new Scanner(source);
            int encoding = scanner.GetEncoding();
            try
            {
                bool bScript = false;
                int type = (int)AnonymousEnum.TYPE_SINGLE;
                if (!bNeedHeader)
                {
                    type = (int)AnonymousEnum.TYPE_UNKNOWN;
                    bScript = true;
                }
                string idScript = "";
                string title = "";
                string text = "";
                string pathImage = "";
                string pathSystem = DEFAULT;
                string pathBackground = DEFAULT;
                string pathBGM = DEFAULT;
                List<string> listPlayer = new List<string>();
                string replayName = "";

                while (scanner.HasNext())
                {
                    Token tok = scanner.Next();
                    if (tok.GetType() == Token.TK_EOF) // Eof�̎��ʎq��������t�@�C���̒����I��
                    {
                        break;
                    }
                    else if (tok.GetType() == Token.TK_SHARP)
                    {
                        tok = scanner.Next();
                        string element = tok.GetElement();
                        bool bShiftJisDanmakufu = false;
                        if (encoding == Encoding.SHIFT_JIS)
                        {
                            int start = tok.GetStartPointer();
                            int end = tok.GetEndPointer();
                            bShiftJisDanmakufu = scanner.CompareMemory(start, end, "�����e����");
                        }

                        if (element == "�����e����" || element == "TouhouDanmakufu" || bShiftJisDanmakufu)
                        {
                            bScript = true;
                            if (scanner.Next().GetType() != Token.TK_OPENB)
                            {
                                continue;
                            }
                            tok = scanner.Next();
                            string strType = tok.GetElement();
                            if (scanner.Next().GetType() != Token.TK_CLOSEB)
                            {
                                throw new gstd.wexception();
                            }

                            if (strType == "Single")
                            {
                                type = (int)AnonymousEnum.TYPE_SINGLE;
                            }
                            else if (strType == "Plural")
                            {
                                type = (int)AnonymousEnum.TYPE_PLURAL;
                            }
                            else if (strType == "Stage")
                            {
                                type = (int)AnonymousEnum.TYPE_STAGE;
                            }
                            else if (strType == "Package")
                            {
                                type = (int)AnonymousEnum.TYPE_PACKAGE;
                            }
                            else if (strType == "Player")
                            {
                                type = (int)AnonymousEnum.TYPE_PLAYER;
                            }
                            else if (!bNeedHeader)
                            {
                                throw new gstd.wexception();
                            }
                        }
                        else if (element == "ID")
                        {
                            idScript = _GetString(scanner);
                        }
                        else if (element == "Title")
                        {
                            title = _GetString(scanner);
                        }
                        else if (element == "Text")
                        {
                            text = _GetString(scanner);
                        }
                        else if (element == "Image")
                        {
                            pathImage = _GetString(scanner);
                        }
                        else if (element == "System")
                        {
                            pathSystem = _GetString(scanner);
                        }
                        else if (element == "Background")
                        {
                            pathBackground = _GetString(scanner);
                        }
                        else if (element == "BGM")
                        {
                            pathBGM = _GetString(scanner);
                        }
                        else if (element == "Player")
                        {
                            listPlayer = new List<string>(_GetStringList(scanner));
                        }
                        else if (element == "ReplayName")
                        {
                            replayName = _GetString(scanner);
                        }
                    }
                }

                if (bScript)
                {
                    // ID���Ȃ������ꍇ�͂��傤���Ȃ��̂Ńt�@�C�����ɂ���B
                    if (idScript.Length == 0)
                    {
                        idScript = PathProperty.GetFileNameWithoutExtension(pathScript);
                    }

                    if (replayName.Length == 0)
                    {
                        replayName = idScript;
                        if (replayName.Length > 8)
                        {
                            replayName = replayName.Substring(0, 8);
                        }
                    }

                    if (pathImage.Length > 2)
                    {
                        if (pathImage[0] == '.' && (pathImage[1] == '/' || pathImage[1] == '\\'))
                        {
                            pathImage = pathImage.Substring(2);
                            pathImage = PathProperty.GetFileDirectory(pathScript) + pathImage;
                        }
                    }

                    res = new ScriptInformation();
                    res.SetScriptPath(pathScript);
                    res.SetArchivePath(pathArchive);
                    res.SetType(type);

                    res.SetID(idScript);
                    res.SetTitle(title);
                    res.SetText(text);
                    res.SetImagePath(pathImage);
                    res.SetSystemPath(pathSystem);
                    res.SetBackgroundPath(pathBackground);
                    res.SetBgmPath(pathBGM);
                    res.SetPlayerList(listPlayer);
                    res.SetReplayName(replayName);
                }
            }
            catch
            {
                res = null;
            }

            return new ref_count_ptr<ScriptInformation>(res);
        }

        public static List<ref_count_ptr<ScriptInformation>> CreateScriptInformationList(string path, bool bNeedHeader = true)
        {
            List<ref_count_ptr<ScriptInformation>> res = new List<new ref_count_ptr<ScriptInformation>>();
            File file = new File(path);
            if (!file.Open())
            {
                return new List<ref_count_ptr<ScriptInformation>>(res);
            }
            if (file.GetSize() < GlobalMembers.HEADER_ARCHIVEFILE.size())
            {
                return new List<ref_count_ptr<ScriptInformation>>(res);
            }

            string header;
            header.resize(GlobalMembers.HEADER_ARCHIVEFILE.size());
            file.Read(header[0], header.Length);
            if (header == GlobalMembers.HEADER_ARCHIVEFILE)
            {
                file.Close();

                ArchiveFile archive = new ArchiveFile(path);
                if (!archive.Open())
                {
                    return new List<ref_count_ptr<ScriptInformation>>(res);
                }

                std::multimap<string, ref_count_ptr<ArchiveFileEntry>> mapEntry = archive.GetEntryMap();
                std::multimap<string, ref_count_ptr<ArchiveFileEntry>>.iterator itr = mapEntry.begin();
                for (; itr != mapEntry.end() ; itr++)
                {
                    // ���炩�Ɋ֌W�Ȃ������Ȋg���q�͏��O
                    ref_count_ptr<ArchiveFileEntry> entry = itr.second;
                    string dir = PathProperty.GetFileDirectory(path);
                    string tPath = dir + entry.GetDirectory() + entry.GetName();

                    string ext = PathProperty.GetFileExtension(tPath);
                    if (ScriptInformation.IsExcludeExtention(ext))
                    {
                        continue;
                    }

                    ref_count_ptr<gstd.ByteBuffer> buffer = ArchiveFile.CreateEntryBuffer(entry);
                    string source = "";
                    int size = buffer.GetSize();
                    source.resize(size);
                    buffer.Read(source[0], size);

                    ref_count_ptr<ScriptInformation> info = CreateScriptInformation(tPath, path, source, bNeedHeader);
                    if (info != null)
                    {
                        res.Add(info);
                    }
                }
            }
            else
            {

                // ���炩�Ɋ֌W�Ȃ������Ȋg���q�͏��O
                string ext = PathProperty.GetFileExtension(path);
                if (ScriptInformation.IsExcludeExtention(ext))
                {
                    return new List<ref_count_ptr<ScriptInformation>>(res);
                }

                file.SetFilePointerBegin();
                string source = "";
                int size = file.GetSize();
                source.resize(size);
                file.Read(source[0], size);

                ref_count_ptr<ScriptInformation> info = CreateScriptInformation(path, "", source, bNeedHeader);
                if (info != null)
                {
                    res.Add(info);
                }
            }

            return new List<ref_count_ptr<ScriptInformation>>(res);
        }

        public static List<ref_count_ptr<ScriptInformation>> FindPlayerScriptInformationList(string dir)
        {
            List<ref_count_ptr<ScriptInformation>> res = new List<new ref_count_ptr<ScriptInformation>>();
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
                    tDir += "\\";

                    List<ref_count_ptr<ScriptInformation>> list = FindPlayerScriptInformationList(tDir);
                    foreach (ref_count_ptr<ScriptInformation> itr in list)
                    {
                        res.push_backitr;
                    }
                    continue;
                }
                if (wcscmp(data.cFileName, "..") == 0 || wcscmp(data.cFileName, ".") == 0)
                {
                    continue;
                }

                // �t�@�C��
                string path = dir + name;

                // �X�N���v�g���
                List<ref_count_ptr<ScriptInformation>> listInfo = CreateScriptInformationList(path, true);
                for (int iInfo = 0 ; iInfo < listInfo.Count ; iInfo++)
                {
                    ref_count_ptr<ScriptInformation> info = listInfo[iInfo];
                    if (info != null && info.GetType() == ScriptInformation.AnonymousEnum.TYPE_PLAYER)
                    {
                        res.Add(info);
                    }
                }

            }while (FindNextFile(hFind, data));
            FindClose(hFind);

            return new List<ref_count_ptr<ScriptInformation>>(res);
        }

        public static bool IsExcludeExtention(string ext)
        {
            bool res = false;
            if (ext == ".dat" || ext == ".mid" || ext == ".wav" || ext == ".mp3" || ext == ".ogg" || ext == ".bmp" || ext == ".png" || ext == "jpg" || ext == ".mqo" || ext == ".elem")
            {
                res = true;
            }
            return res;
        }

        private static string _GetString(Scanner scanner)
        {
            string res = DEFAULT;
            scanner.CheckType(scanner.Next(), Token.TK_OPENB);
            Token tok = scanner.Next();
            if (tok.GetType() == Token.TK_STRING)
            {
                res = tok.GetString();
            }
            scanner.CheckType(scanner.Next(), Token.TK_CLOSEB);
            return res;
        }

        private static List<string> _GetStringList(Scanner scanner)
        {
            List<string> res = new List<string>();
            scanner.CheckType(scanner.Next(), Token.TK_OPENB);
            while (true)
            {
                Token tok = scanner.Next();
                int type = tok.GetType();
                if (type == Token.TK_CLOSEB)
                {
                    break;
                }
                else if (type == Token.TK_STRING)
                {
                    string wstr = tok.GetString();
                    res.Add(wstr);
                }
            }
            return new List<string>(res);
        }
}




/**********************************************************
//ErrorDialog
**********************************************************/
public class ErrorDialog : ModalDialog
{
        protected static IntPtr hWndParentStatic_ = null;

        protected WEditBox edit_ = new WEditBox();
        protected WButton button_ = new WButton();

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
                    DestroyWindow(hWnd_);
                    break;
                case WM_KEYDOWN:
                    if (wParam == VK_RETURN)
                    {
                        DestroyWindow(hWnd_);
                    }
                    break;
                case WM_COMMAND:
                {
                    int param = wParam & 0xffff;
                    if (param == button_.GetWindowId())
                    {
                        DestroyWindow(hWnd_);
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

                    RECT rcButton = button_.GetClientRect();
                    int widthButton = rcButton.right - rcButton.left;
                    int heightButton = rcButton.bottom - rcButton.top;
                    button_.SetBounds(wWidth / 2 - widthButton / 2, wHeight - heightButton - 8, widthButton, heightButton);

                    edit_.SetBounds(wx + 8, wy + 8, wWidth - 16, wHeight - heightButton - 24);

                    break;
                }

            }
            return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);
        }


        /**********************************************************
        //ErrorDialog
        **********************************************************/
        public ErrorDialog(IntPtr hParent)
        {
            hParent_ = hParent;
        }

        public bool ShowModal(string msg)
        {
            IntPtr hInst = global::GetModuleHandle(null);
            string wName = "ErrorWindow";

            WNDCLASSEX wcex = new WNDCLASSEX();
            ZeroMemory(wcex, sizeof(WNDCLASSEX));
            wcex.cbSize = sizeof(WNDCLASSEX);
            wcex.lpfnWndProc = (WNDPROC)WindowBase._StaticWindowProcedure;
            wcex.hInstance = hInst;
            wcex.hIcon = null;
            wcex.hCursor = LoadCursor(null, IDC_ARROW);
            wcex.hbrBackground = (IntPtr)(COLOR_WINDOW);
            wcex.lpszMenuName = null;
            wcex.lpszClassName = wName;
            wcex.hIconSm = null;
            RegisterClassEx(wcex);

               hWnd_ = global::CreateWindow(wcex.lpszClassName, wName, WS_OVERLAPPEDWINDOW, 0,0,480,320,hParent_,(IntPtr)null,hInst,null);
            global::ShowWindow(hWnd_, SW_HIDE);
            this.Attach(hWnd_);


            gstd.WEditBox.Style styleEdit = new gstd.WEditBox.Style();
            styleEdit.SetStyle(WS_CHILD | WS_VISIBLE | ES_MULTILINE | ES_READONLY | ES_AUTOHSCROLL | ES_AUTOVSCROLL | WS_HSCROLL | WS_VSCROLL);
            styleEdit.SetStyleEx(WS_EX_CLIENTEDGE);
            edit_.Create(hWnd_, styleEdit);
            edit_.SetText(msg);

            button_.Create(hWnd_);
            button_.SetText("OK");
            button_.SetBounds(0, 0, 88, 20);

            MoveWindowCenter();
            SetWindowVisible(true);
            _RunMessageLoop();
            return true;
        }

        public static void SetParentWindowHandle(IntPtr hWndParent)
        {
            hWndParentStatic_ = hWndParent;
        }
        public static void ShowErrorDialog(string msg)
        {
            ErrorDialog dialog = new ErrorDialog(hWndParentStatic_);
            dialog.ShowModal(msg);
        }
}



/**********************************************************
//DnhConfiguration
**********************************************************/
public class DnhConfiguration : Singleton<DnhConfiguration>
{
        private const int VERSION = 1;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum2
        {
            WINDOW_SIZE_640x480 = 0,
            WINDOW_SIZE_800x600,
            WINDOW_SIZE_960x720,
            WINDOW_SIZE_1280x960,
            WINDOW_SIZE_1600x1200,
            WINDOW_SIZE_1920x1200,

            FPS_NORMAL = 0,
            FPS_1_2, // 1/2
            FPS_1_3, // 1/3
            FPS_AUTO
        }

        private int modeScreen_; // DirectGraphics::SCREENMODE_FULLSCREEN,SCREENMODE_WINDOW
        private int sizeWindow_;
        private int fpsType_;

        private int padIndex_;
        private SortedDictionary<int, ref_count_ptr<VirtualKey>> mapKey_ = new SortedDictionary<int, ref_count_ptr<VirtualKey>>();

        private bool bLogWindow_;
        private bool bLogFile_;
        private bool bMouseVisible_;

        private string pathPackageScript_ = "";
        private string windowTitle_ = "";
        private int screenWidth_;
        private int screenHeight_;

        private bool _LoadDefintionFile()
        {
            string path = PathProperty.GetModuleDirectory() + "th_dnh.def";
            PropertyFile prop = new PropertyFile();
            if (!prop.Load(path))
            {
                return false;
            }

            pathPackageScript_ = prop.GetString("package.script.main", "");
            if (pathPackageScript_.Length > 0)
            {
                pathPackageScript_ = PathProperty.GetModuleDirectory() + pathPackageScript_;
            }

            windowTitle_ = prop.GetString("window.title", "");

            screenWidth_ = prop.GetInteger("screen.width", 640);
            screenWidth_ = System.Math.Max(screenWidth_, 640);
            screenWidth_ = System.Math.Min(screenWidth_, 1920);

            screenHeight_ = prop.GetInteger("screen.height", 480);
            screenHeight_ = System.Math.Max(screenHeight_, 480);
            screenHeight_ = System.Math.Min(screenHeight_, 1200);

            return true;
        }


        /**********************************************************
        //DnhConfiguration
        **********************************************************/
        public DnhConfiguration()
        {
            modeScreen_ = DirectGraphics.SCREENMODE_WINDOW;
            sizeWindow_ = (int)AnonymousEnum2.WINDOW_SIZE_640x480;
            fpsType_ = (int)AnonymousEnum2.FPS_NORMAL;

            // �L�[�o�^
            padIndex_ = 0;
            mapKey_[EDirectInput.KEY_LEFT] = new VirtualKey(DIK_LEFT, 0, 0); // �L�[�{�[�h�u���v�ƃW���C�p�b�h�u���v��o�^
            mapKey_[EDirectInput.KEY_RIGHT] = new VirtualKey(DIK_RIGHT, 0, 1); // �L�[�{�[�h�u���v�ƃW���C�p�b�h�u���v��o�^
            mapKey_[EDirectInput.KEY_UP] = new VirtualKey(DIK_UP, 0, 2); // �L�[�{�[�h�u���v�ƃW���C�p�b�h�u���v��o�^
            mapKey_[EDirectInput.KEY_DOWN] = new VirtualKey(DIK_DOWN, 0, 3); // �L�[�{�[�h�u���v�ƃW���C�p�b�h�u���v��o�^

            mapKey_[EDirectInput.KEY_OK] = new VirtualKey(DIK_Z, 0, 5);
            mapKey_[EDirectInput.KEY_CANCEL] = new VirtualKey(DIK_X, 0, 6);

            mapKey_[EDirectInput.KEY_SHOT] = new VirtualKey(DIK_Z, 0, 5);
            mapKey_[EDirectInput.KEY_BOMB] = new VirtualKey(DIK_X, 0, 6);
            mapKey_[EDirectInput.KEY_SLOWMOVE] = new VirtualKey(DIK_LSHIFT, 0, 7);
            mapKey_[EDirectInput.KEY_USER1] = new VirtualKey(DIK_C, 0, 8);
            mapKey_[EDirectInput.KEY_USER2] = new VirtualKey(DIK_V, 0, 9);

            mapKey_[EDirectInput.KEY_PAUSE] = new VirtualKey(DIK_ESCAPE, 0, 10);

            bLogWindow_ = false;
            bLogFile_ = false;
            bMouseVisible_ = true;

            screenWidth_ = 640;
            screenHeight_ = 480;

            LoadConfigFile();
            _LoadDefintionFile();
        }

        public override void Dispose()
        {
            base.Dispose();
        }

        public bool LoadConfigFile()
        {
            string path = PathProperty.GetModuleDirectory() + "config.dat";
            RecordBuffer record = new RecordBuffer();
            bool res = record.ReadFromFile(path);
            if (!res)
            {
                return false;
            }

            int version = record.GetRecordAsInteger("version");
            if (version != VERSION)
            {
                return false;
            }

            modeScreen_ = record.GetRecordAsInteger("modeScreen");
            sizeWindow_ = record.GetRecordAsInteger("sizeWindow");
            fpsType_ = record.GetRecordAsInteger("fpsType");

            if (record.IsExists("padIndex"))
            {
                padIndex_ = record.GetRecordAsInteger("padIndex");
            }

            ByteBuffer bufKey = new ByteBuffer();
            int bufKeySize = record.GetRecordAsInteger("mapKey_size");
            bufKey.SetSize(bufKeySize);
            record.GetRecord("mapKey", bufKey.GetPointer(), bufKey.GetSize());
            int mapKeyCount = bufKey.ReadInteger();
            if (mapKeyCount == mapKey_.Count)
            {
                for (int iKey = 0 ; iKey < mapKeyCount ; iKey++)
                {
                    int id = bufKey.ReadInteger();
                    int keyCode = bufKey.ReadInteger();
                    int padIndex = bufKey.ReadInteger();
                    int padButton = bufKey.ReadInteger();

                    mapKey_[id] = new VirtualKey(keyCode, padIndex, padButton);
                }
            }

            bLogWindow_ = record.GetRecordAsBoolean("bLogWindow");
            bLogFile_ = record.GetRecordAsBoolean("bLogFile");
            if (record.IsExists("bMouseVisible"))
            {
                bMouseVisible_ = record.GetRecordAsBoolean("bMouseVisible");
            }

            return res;
        }

        public bool SaveConfigFile()
        {
            string path = PathProperty.GetModuleDirectory() + "config.dat";
            RecordBuffer record = new RecordBuffer();
            record.SetRecordAsInteger("version", VERSION);

            record.SetRecordAsInteger("modeScreen", modeScreen_);
            record.SetRecordAsInteger("sizeWindow", sizeWindow_);
            record.SetRecordAsInteger("fpsType", fpsType_);

            record.SetRecordAsInteger("padIndex", padIndex_);
            ByteBuffer bufKey = new ByteBuffer();
            bufKey.WriteInteger(mapKey_.Count);
            SortedDictionary<int, ref_count_ptr<VirtualKey>>.Enumerator itrKey = mapKey_.GetEnumerator();
            while (itrKey.MoveNext())
            {
                int id = itrKey.Current.Key;
                ref_count_ptr<VirtualKey> vk = itrKey.Current.Value;

                bufKey.WriteInteger(id);
                bufKey.WriteInteger(vk.GetKeyCode());
                bufKey.WriteInteger(padIndex_);
                bufKey.WriteInteger(vk.GetPadButton());
            }
            record.SetRecordAsInteger("mapKey_size", bufKey.GetSize());
            record.SetRecord("mapKey", bufKey.GetPointer(), bufKey.GetSize());

            record.SetRecordAsBoolean("bLogWindow", bLogWindow_);
            record.SetRecordAsBoolean("bLogFile", bLogFile_);
            record.SetRecordAsBoolean("bMouseVisible", bMouseVisible_);

            record.WriteToFile(path);
            return true;
        }

        public int GetScreenMode()
        {
            return modeScreen_;
        }
        public void SetScreenMode(int mode)
        {
            modeScreen_ = mode;
        }
        public int GetWindowSize()
        {
            return sizeWindow_;
        }
        public void SetWindowSize(int size)
        {
            sizeWindow_ = size;
        }
        public int GetFpsType()
        {
            return fpsType_;
        }
        public void SetFpsType(int type)
        {
            fpsType_ = type;
        }

        public int GetPadIndex()
        {
            return padIndex_;
        }
        public void SetPadIndex(int index)
        {
            padIndex_ = index;
        }
        public ref_count_ptr<VirtualKey> GetVirtualKey(int id)
        {
            if (!mapKey_.ContainsKey(id))
            {
                return null;
            }

            ref_count_ptr<VirtualKey> res = mapKey_[id];
            return new ref_count_ptr<VirtualKey>(res);
        }

        public bool IsLogWindow()
        {
            return bLogWindow_;
        }
        public void SetLogWindow(bool b)
        {
            bLogWindow_ = b;
        }
        public bool IsLogFile()
        {
            return bLogFile_;
        }
        public void SetLogFile(bool b)
        {
            bLogFile_ = b;
        }
        public bool IsMouseVisible()
        {
            return bMouseVisible_;
        }
        public void SetMouseVisible(bool b)
        {
            bMouseVisible_ = b;
        }

        public string GetPackageScriptPath()
        {
            return pathPackageScript_;
        }
        public string GetWindowTitle()
        {
            return windowTitle_;
        }
        public int GetScreenWidth()
        {
            return screenWidth_;
        }
        public int GetScreenHeight()
        {
            return screenHeight_;
        }
}
