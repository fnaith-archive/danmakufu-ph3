using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)



namespace gstd
{

    /**********************************************************
    //FileLogger
    **********************************************************/
    public class FileLogger : Logger
    {
            protected bool bEnable_;
            protected string path_ = "";
            protected string path2_ = "";
            protected int sizeMax_;
            protected override void _Write(SYSTEMTIME time, string str)
            {
                if (!bEnable_)
                {
                    return;
                }

                {
                    Lock @lock = new Lock(lock_);
                    string strTime = StringUtility.Format("%.4d/%.2d/%.2d %.2d:%.2d:%.2d.%.3d ",time.wYear, time.wMonth, time.wDay, time.wHour, time.wMinute, time.wSecond, time.wMilliseconds);

                    File file = new File(path_);
                    if (!file.Open(File.WRITE))
                    {
                        return;
                    }

                    string @out = strTime;
                    @out += str;
                    @out += "\r\n";

                    int pos = file.GetSize();
                    file.Seek(pos);
                    file.Write(@out[0], (uint)StringUtility.GetByteSize(@out));

                    bool bOverSize = file.GetSize() > sizeMax_;
                    file.Close();

                    if (bOverSize)
                    {
                        global::MoveFileEx(path_, path2_, MOVEFILE_REPLACE_EXISTING | MOVEFILE_WRITE_THROUGH);
                        File file1 = new File(path_);
                        _CreateFile(file1);
                    }
                }
            }

            protected void _CreateFile(File file)
            {
                file.Create();

                // BOM�iByte Order Mark�j
                file.WriteCharacter((byte)0xFF);
                file.WriteCharacter((byte)0xFE);
            }


            /**********************************************************
            //FileLogger
            **********************************************************/
            public FileLogger()
            {
                sizeMax_ = 10 * 1024 * 1024; // 10MB
            }

            public new void Dispose()
            {

                base.Dispose();
            }

            public void Clear()
            {
                if (!bEnable_)
                {
                    return;
                }

                File file1 = new File(path_);
                file1.Delete();
                File file2 = new File(path2_);
                file2.Delete();

                _CreateFile(file1);
            }

            public bool Initialize(bool bEnable = true)
            {
                return this.Initialize("", bEnable);
            }

            public bool Initialize(string path, bool bEnable = true)
            {
                bEnable_ = bEnable;
                if (path.Length == 0)
                {
                    path = PathProperty.GetModuleDirectory() + PathProperty.GetModuleName() + ".log";
                }
                return this.SetPath(path);
            }

            public bool SetPath(string path)
            {
                if (!bEnable_)
                {
                    return false;
                }

                path_ = path;
                File file = new File(path);
                if (file.IsExists() == false)
                {
                    file.CreateDirectory();
                    _CreateFile(file);
                }

                path2_ = path_ + "_";
                return true;
            }

            public void SetMaxFileSize(int size)
            {
                sizeMax_ = size;
            }
    }

    /**********************************************************
    //WindowLogger
    //���O�E�B���h�E
    //�E�B���h�E�͕ʃX���b�h����ł�
    **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class WindowLogger : Logger, WindowBase
    {
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
            public class WindowThread : gstd.Thread, gstd.InnerClass<WindowLogger>
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend WindowLogger;

                    // WindowLogger::WindowThread
                    protected WindowThread(WindowLogger logger)
                    {
                        _SetOuter(logger);
                    }

                    protected void _Run()
                    {
                        WindowLogger logger = _GetOuter();
                        logger._Run();
                    }
            }
            public class Panel : WPanel
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend WindowLogger;
                    protected abstract bool _AddedLogger(IntPtr hTab);

                    protected virtual void _ReadRecord(RecordBuffer record)
                    {
                    }
                    protected virtual void _WriteRecord(RecordBuffer record)
                    {
                    }
            }
            public class LogPanel : WindowLogger.Panel
            {
                    private WEditBox wndEdit_ = new WEditBox();
                    protected virtual bool _AddedLogger(IntPtr hTab)
                    {
                        Create(hTab);

                        gstd.WEditBox.Style styleEdit = new gstd.WEditBox.Style();
                        styleEdit.SetStyle(WS_CHILD | WS_VISIBLE | ES_MULTILINE | ES_READONLY | ES_AUTOHSCROLL | ES_AUTOVSCROLL | WS_HSCROLL | WS_VSCROLL);
                        styleEdit.SetStyleEx(WS_EX_CLIENTEDGE);
                        wndEdit_.Create(hWnd_, styleEdit);
                        return true;
                    }


                    // WindowLogger::LogPanel
                    public LogPanel()
                    {

                    }

                    public void Dispose()
                    {

                    }

                    public virtual void LocateParts()
                    {
                        int wx = GetClientX();
                        int wy = GetClientY();
                        int wWidth = GetClientWidth();
                        int wHeight = GetClientHeight();
                        wndEdit_.SetBounds(wx, wy, wWidth, wHeight);
                    }

                    public void AddText(string text)
                    {
                        IntPtr hEdit = wndEdit_.GetWindowHandle();
                        int pos = GetWindowTextLength(hEdit);
                        if (pos + wndEdit_.GetTextLength() >= wndEdit_.GetMaxTextLength())
                        {
                            // �ő啶�����𒴂�����50%�폜
                            string text = wndEdit_.GetText();
                            text = text.Remove(0, text.Length / 2);
                            text += "\r\n";
                            wndEdit_.SetText(text);

                            pos = GetWindowTextLength(hEdit);
                        }
                        global::SendMessage(hEdit, EM_SETSEL, pos, pos);
                        global::SendMessage(hEdit, EM_REPLACESEL, 0, (IntPtr)text.c_str());
                    }
            }
            public class InfoPanel : WindowLogger.Panel
            {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
                    private enum AnonymousEnum
                    {
                        ROW_INFO = 0,
                        ROW_DATA
                    }
                    private WListView wndListView_ = new WListView();
                    protected virtual bool _AddedLogger(IntPtr hTab)
                    {
                        Create(hTab);

                        gstd.WListView.Style styleListView = new gstd.WListView.Style();
                        styleListView.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOSORTHEADER);
                        styleListView.SetStyleEx(WS_EX_CLIENTEDGE);
                        styleListView.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                        wndListView_.Create(hWnd_, styleListView);

                        wndListView_.AddColumn(120, ROW_INFO, "Info");
                        wndListView_.AddColumn(400, ROW_DATA, "Data");
                        return true;
                    }

                    // WindowLogger::InfoPanel
                    public InfoPanel()
                    {

                    }

                    public void Dispose()
                    {

                    }

                    public virtual void LocateParts()
                    {
                        int wx = GetClientX();
                        int wy = GetClientY();
                        int wWidth = GetClientWidth();
                        int wHeight = GetClientHeight();
                        wndListView_.SetBounds(wx, wy, wWidth, wHeight);
                    }

                    public void SetInfo(int row, string textInfo, string textData)
                    {
                        wndListView_.SetText(row, ROW_INFO, textInfo);
                        wndListView_.SetText(row, ROW_DATA, textData);
                    }
            }
            public class InfoCollectThread : Thread
            {
                    // CPU���\����
                    protected class CpuInfo
                    {
                        public string venderID = new string(new char[13]);
                        public string name = new string(new char[49]);
                        public string cpuName = "";
                        public double clock;
                        public int type;
                        public int family;
                        public int model;
                        public int stepping;
                        public bool bMMXEnabled;
                        public bool bAMD3DNowEnabled;
                        public bool bSIMDEnabled;
                    }
                    protected ref_count_ptr<WStatusBar> wndStatus_ = new ref_count_ptr<WStatusBar>();
                    protected CpuInfo infoCpu_ = new CpuInfo();
                    protected virtual void _Run()
                    {
                        // TODO �����ȃX�e�[�^�X�o�[�Ƀ��b�Z�[�W��
                        //     ����Ƃ��A�ł܂�\������B
                        infoCpu_ = this._GetCpuInformation();

                        while (this.GetStatus() == RUN)
                        {
                            global::Sleep(500);
                        }
                    /*
                    	PROCESS_MEMORY_COUNTERS memoryCounter;
                    	ZeroMemory(&memoryCounter, sizeof(PROCESS_MEMORY_COUNTERS));
                    	DWORD dwProcessID = GetCurrentProcessId();
                    	HANDLE hProcess = OpenProcess(PROCESS_QUERY_INFORMATION, FALSE ,dwProcessID);
                    	while(this->GetStatus() == RUN)
                    	{
                    		GetProcessMemoryInfo(hProcess, &memoryCounter, sizeof(PROCESS_MEMORY_COUNTERS));
                    		double pageFileUsage = memoryCounter.PagefileUsage / 1024. / 1024.;
                    		std::string strMemory = StringUtility::Format("Memory [ %.2fMB ]", pageFileUsage);
                    		if(this->GetStatus() == RUN)wndStatus_->SetText(STATUS_MEMORY, strMemory);
                    
                    		double cpuPerformance=this->_GetCpuPerformance();
                    		CpuInfo &ci=this->infoCpu_;
                    		std::string strCpu = StringUtility::Format("%s %s [ %4.2fMHz (%3d %%) type:%d family:%d model:%d stepping:%d ]",ci.venderID,ci.cpuName.c_str(),ci.clock/1000/1000,(int)cpuPerformance,ci.type,ci.family,ci.model,ci.stepping);
                    		if(this->GetStatus() == RUN)wndStatus_->SetText(STATUS_CPU, strCpu);
                    
                    		::Sleep(500);
                    	}
                    	CloseHandle(hProcess);
                    */
                    }

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
                    protected enum AnonymousEnum2
                    {
                        WM_ENDLOGGER = WM_APP + 1,
                        WM_ADDPANEL,

                        STATUS_MEMORY = 0,
                        STATUS_CPU = 1,

                        MENU_ID_OPEN = 1
                    }
                    protected class AddPanelEvent
                    {
                        public string name = "";
                        public ref_count_ptr<Panel> panel = new ref_count_ptr<Panel>();
                    }
                    protected WindowLogger.InfoCollectThread.CpuInfo _GetCpuInformation()
                    {
                        int cpuid_supported;
                        string VenderID = new string(new char[13]);
                        string name = new string(new char[17]);
                        int eax1cpuid_supported;
                        int eax_flags;
                        int edx_flags;
                        uint CPUClock;
                        uint start;

                        CpuInfo ci = new CpuInfo();
                        ZeroMemory(ci, sizeof(CpuInfo));

                        try
                        {
                            /*CPUID���߂�T�|�[�g���Ă��邩���ׂ�B
                            �iPentium�ȍ~��CPU�Ȃ�΃T�|�[�g���Ă���炵���c�j
                            �t���O���W�X�^�̂Q�P�r�b�g�ڂ�ς��邱�Ƃ��ł���΃T�|�[�g���Ă���B*/
                            _asm
                            {
                                pushfd;
                                �t���O���W�X� ^ �̓�e��X� ^ �b�N�ɕۑ� pushfd;
                                �t���O���W�X� ^ �̓�e��X� ^ �b�N�ɓ���� pop eax;
                                �X� ^ �b�N�̓�e��eax���W�X� ^ �Ɏ��o�� ^ eax,0x100000h;
                                eax���W�X� ^ ��21�r�b�g�ڂ�r�b�g���]�A�c��͂��̂܂� push eax;
                                eax���W�X� ^ �̓�e��X� ^ �b�N�ɓ���� popfd;
                                �X� ^ �b�N�̓�e��t���O���W�X� ^ �Ɏ��o�� pushfd;
                                �t���O���W�X� ^ �̓�e��X� ^ �b�N�ɓ���� pop ebx;
                                �X� ^ �b�N�̓�e��ebx���W�X� ^ �Ɏ��o�� popfd;
                                �t���O���W�X� ^ �̓�e�𕜌� cmp eax,ebx;
                                ��r je supported;
                                �������Ȃ�΃W�����v mov cpuid_supported,0;
                                �ϐ���� jmp exitasm;
                                ������W�����v supported: mov cpuid_supported,1;
                                �ϐ���� exitasm:
                            };

                            if (cpuid_supported == 0)
                            { // CPUID ���߂�T�|�[�g���ĂȂ�
                                throw new gstd.wexception();
                            }

                            /*eax=0��CPUID��Ăяo���A
                            �E�x���_�[ID�̎擾�i�x���_�[ID��ebx -> edx -> ecx�̏��ɃR�s�[����܂��j
                            �E�x���_�[ID��AuthenticAMD�Ȃ�CPU����擾
                            �Eeax=1�̂Ƃ�CPUID���߂��T�|�[�g����Ă��邩�̒���
                            ����܂��B*/
                            _asm
                            {
                                mov eax = new mov();
                                mov 0 cpuid mov uint PTR [VenderID.Substring(0)];
                                mov ebx = new mov();
                                �e�l��o�b�t��ɃR�s�[mov uint PTR [VenderID.Substring(4)], edx mov uint PTR [VenderID.Substring(8)], ecx mov byte PTR [VenderID.Substring(12)], 0 ; �Ō��NULL������ mov eax1cpuid_supported,eax }; strcpy(ci.venderID,VenderID); if (0 == strcmp(ci.venderID,"AuthenticAMD")) { _asm { mov eax,0x8000002h cpuid mov uint PTR [name.Substring(0)], eax ; �e�l��o�b�t��ɃR�s�[mov uint PTR [name.Substring(4)], ebx mov uint PTR [name.Substring(8)], ecx mov uint PTR [name.Substring(12)], edx mov byte PTR [name.Substring(16)], 0 ; �Ō��NULL������ }; strcpy(ci.name,name); _asm { mov eax,0x8000003h cpuid mov uint PTR [name.Substring(0)], eax ; �e�l��o�b�t��ɃR�s�[mov uint PTR [name.Substring(4)], ebx mov uint PTR [name.Substring(8)], ecx mov uint PTR [name.Substring(12)], edx mov byte PTR [name.Substring(16)], 0 ; �Ō��NULL������ }; strcat(ci.name,name); _asm { mov eax,0x8000004h cpuid mov uint PTR [name.Substring(0)], eax ; �e�l��o�b�t��ɃR�s�[mov uint PTR [name.Substring(4)], ebx mov uint PTR [name.Substring(8)], ecx mov uint PTR [name.Substring(12)], edx mov byte PTR [name.Substring(16)], 0 ; �Ō��NULL������ }; strcat(ci.name,name); } if (1 > eax1cpuid_supported){ throw new gstd.wexception(); } _asm { mov eax,1 cpuid mov eax_flags,eax mov edx_flags,edx }; ci.type = (eax_flags >> 12) & 0xF; ci.family = (eax_flags >> 8) & 0xF; ci.model = (eax_flags >> 4) & 0xF; ci.stepping = eax_flags & 0xF; ci.bMMXEnabled = (edx_flags & 0x00800000) != 0? true: false; ci.bSIMDEnabled = (edx_flags & 0x02000000) != 0? true: false; ci.bAMD3DNowEnabled = (edx_flags & 0x80000000) != 0? true: false; if (edx_flags & 0x00000010) { _asm rdtsc; _asm mov CPUClock, eax; start = timeGetTime(); while (timeGetTime() - start < 1000); _asm rdtsc; _asm sub eax,CPUClock; _asm mov CPUClock, eax; ci.clock = (double)(CPUClock); } else { throw new gstd.wexception(); } ci.cpuName = ci.name; if (strcmp(ci.venderID,"AuthenticAMD") == 0) { } else if (strcmp(ci.venderID,"GenuineIntel") == 0) { } } catch (...) { } return ci; } double WindowLogger.InfoCollectThread._GetCpuPerformance() { HQUERY hQuery; HCOUNTER hCounter; PDH_FMT_COUNTERVALUE FmtValue; PdhOpenQuery(null, 0, hQuery); PdhAddCounter(hQuery, "\\Processor(_Total)\\% Processor Time", 0, hCounter); Sleep(500); PdhCollectQueryData(hQuery); Sleep(500); PdhCollectQueryData(hQuery); PdhGetFormattedCounterValue(hCounter, PDH_FMT_DOUBLE, null, FmtValue); PdhCloseQuery(hQuery); return FmtValue.doubleValue; }

                    double _GetCpuPerformance = 0;
                    InfoCollectThread(ref_count_ptr<WStatusBar> wndStatus);
                    ~new InfoCollectThread();
                            };
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend WindowThread;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend LogPanel;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend InfoPanel;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend InfoCollectThread;
            bool bEnable_;
            ref_count_ptr<WindowThread> threadWindow_ = new ref_count_ptr<WindowThread>();
            ref_count_ptr<WTabControll> wndTab_ = new ref_count_ptr<WTabControll>();
            ref_count_ptr<WStatusBar> wndStatus_ = new ref_count_ptr<WStatusBar>();
            ref_count_ptr<LogPanel> wndLogPanel_ = new ref_count_ptr<LogPanel>();
            ref_count_ptr<InfoPanel> wndInfoPanel_ = new ref_count_ptr<InfoPanel>();
            ref_count_ptr<InfoCollectThread> threadInfoCollect_ = new ref_count_ptr<InfoCollectThread>();
            gstd.CriticalSection lock_ = new gstd.CriticalSection();
            LinkedList<AddPanelEvent> listEventAddPanel_ = new LinkedList<AddPanelEvent>();

            void _Run();
            void _CreateWindow();
            virtual void _Write(SYSTEMTIME & systemTime, string str);
            virtual int _WindowProcedure(IntPtr hWnd,uint uMsg,IntPtr wParam,IntPtr lParam);
            WindowLogger();
            ~new WindowLogger();
            bool Initialize(bool bEnable = true);
            void SaveState();
            void LoadState();
            void SetInfo(int row, string textInfo, string textData);
            bool AddPanel = new bool(ref_count_ptr<Panel> panel, string name);

            void ShowLogWindow();
            static void InsertOpenCommandInSystemMenu(IntPtr hWnd);
                        };



                    }






/**********************************************************
//WindowLogger
**********************************************************/
public WindowLogger.WindowLogger()
{

}
public WindowLogger.~WindowLogger()
{
    threadInfoCollect_ = null;
    wndInfoPanel_ = null;
    wndLogPanel_ = null;
    wndStatus_ = null;
    wndTab_ = null;
    if (hWnd_ != null)
    {
        SendMessage(hWnd_, WM_ENDLOGGER, 0, 0);
    }
    if (threadWindow_ != null)
    {
        threadWindow_.Stop();
        threadWindow_.Join(2000); // �O�̂��߂Ƀ^�C���A�E�g�ݒ�
    }
}
public bool WindowLogger.Initialize(bool bEnable)
{
    bEnable_ = bEnable;
    if (!bEnable)
    {
        return true;
    }

// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
    threadWindow_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new WindowThread(this);
    threadWindow_.Start();

    while (GetWindowHandle() == null)
    {
        Sleep(10); // �E�B���h�E���쐬��������܂őҋ@
    }

    // LogPanel
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
    wndLogPanel_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new LogPanel();
    this.AddPanel(wndLogPanel_, "Log");

    // InfoPanel
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
    wndInfoPanel_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new InfoPanel();
    this.AddPanel(wndInfoPanel_, "Info");

    return true;
}
public void WindowLogger.SaveState()
{
    string path = PathProperty.GetModuleDirectory() + "LogWindow.dat";
    RecordBuffer recordMain = new RecordBuffer();
    bool bRecordExists = recordMain.ReadFromFile(path);

    int panelIndex = wndTab_.GetCurrentPage();
    recordMain.SetRecordAsInteger("panelIndex", panelIndex);

    RECT rcWnd = new RECT();
    ZeroMemory(rcWnd, sizeof(RECT));
    if (bRecordExists)
    {
        recordMain.GetRecord("windowRect", rcWnd);
    }
    if (IsWindowVisible())
    {
        GetWindowRect(hWnd_, rcWnd);
    }
    recordMain.SetRecord("windowRect", rcWnd);

    RecordBuffer recordPanel = new RecordBuffer();
    int panelCount = wndTab_.GetPageCount();
    for (int iPanel = 0 ; iPanel < panelCount ; iPanel++)
    {
        ref_count_ptr<WindowLogger.Panel> panel = new ref_count_ptr<WindowLogger.Panel>(wndTab_.GetPanel(iPanel));
        if (panel == null)
        {
            continue;
        }

        panel._WriteRecord(recordPanel);
    }

    recordMain.SetRecordAsRecordBuffer("panel", recordPanel);

    recordMain.WriteToFile(path);
}
public void WindowLogger.LoadState()
{
    string path = PathProperty.GetModuleDirectory() + "LogWindow.dat";
    RecordBuffer recordMain = new RecordBuffer();
    if (!recordMain.ReadFromFile(path))
    {
        return;
    }

    int panelIndex = recordMain.GetRecordAsInteger("panelIndex");
    if (panelIndex >= 0 && panelIndex < wndTab_.GetPageCount())
    {
        wndTab_.SetCurrentPage(panelIndex);
    }

    RECT rcWnd = new RECT();
    recordMain.GetRecord("windowRect", rcWnd);
    if (rcWnd.left >= 0 && rcWnd.right > rcWnd.left && rcWnd.top >= 0 && rcWnd.bottom > rcWnd.top)
    {
        SetBounds(rcWnd.left, rcWnd.top, rcWnd.right - rcWnd.left, rcWnd.bottom - rcWnd.top);
    }

    RecordBuffer recordPanel = new RecordBuffer();
    recordMain.GetRecordAsRecordBuffer("panel", recordPanel);

    int panelCount = wndTab_.GetPageCount();
    for (int iPanel = 0 ; iPanel < panelCount ; iPanel++)
    {
        ref_count_ptr<WindowLogger.Panel> panel = new ref_count_ptr<WindowLogger.Panel>(wndTab_.GetPanel(iPanel));
        if (panel == null)
        {
            continue;
        }

        panel._ReadRecord(recordPanel);
    }
}
public void WindowLogger._CreateWindow()
{
    IntPtr hInst = global::GetModuleHandle(null);
    string wName = "LogWindow";

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

       hWnd_ = global::CreateWindow(wcex.lpszClassName, wName, WS_OVERLAPPEDWINDOW, 0,0,640,480,null,(IntPtr)null,hInst,null);
    global::ShowWindow(hWnd_, SW_HIDE);
    this.Attach(hWnd_);

    // �^�u
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
    wndTab_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new WTabControll();
    wndTab_.Create(hWnd_);
    IntPtr hTab = wndTab_.GetWindowHandle();

    // �X�e�[�^�X�o�[
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
    wndStatus_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new WStatusBar();
    wndStatus_.Create(hWnd_);
    List<int> sizeStatus = new List<int>();
    sizeStatus.Add(180);
    sizeStatus.Add(sizeStatus[0] + 560);
    wndStatus_.SetPartsSize(sizeStatus);

    // ���擾�X���b�h
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
    threadInfoCollect_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new InfoCollectThread(wndStatus_);
    threadInfoCollect_.Start();

    // ����������
    this.SetBounds(32,32,280,480);
    wndTab_.ShowPage();

    global::UpdateWindow(hWnd_);
}
public void WindowLogger._Run()
{
    _CreateWindow();
    MSG msg = new MSG();
    while (GetMessage(msg, null, 0, 0))
    { // ���b�Z�[�W���[�v
        TranslateMessage(msg);
        DispatchMessage(msg);
    }
}
public void WindowLogger._Write(SYSTEMTIME systemTime, string str)
{
    if (hWnd_ == null)
    {
        return;
    }

    string timeStr = new string(new char[256]);
    swprintf(timeStr, "%.4d/%.2d/%.2d %.2d:%.2d:%.2d.%.3d ", systemTime.wYear, systemTime.wMonth, systemTime.wDay, systemTime.wHour, systemTime.wMinute, systemTime.wSecond, systemTime.wMilliseconds);

    string @out = timeStr;
    @out += str;
    @out += "\r\n";
    {
        Lock @lock = new Lock(lock_);
        wndLogPanel_.AddText(@out);
    }
}
public int WindowLogger._WindowProcedure(IntPtr hWnd, uint uMsg, IntPtr wParam, IntPtr lParam)
{
    switch (uMsg)
    {
        case WM_DESTROY:
        {
            global::PostQuitMessage(0);
            return false;
        }
        case WM_CLOSE:
        {
            SaveState();
            global::ShowWindow(hWnd, SW_HIDE);
            return false;
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

            return false;
        }
        case WM_NOTIFY:
        {
            switch (((NMHDR)lParam).code)
            {
                case TCN_SELCHANGE:
                    wndTab_.ShowPage();
                    return false;
            }
            break;
        }
        case WM_ENDLOGGER:
        {
            global::DestroyWindow(hWnd);
            break;
        }
        case WM_ADDPANEL:
        {
            {
                Lock @lock = new Lock(lock_);
                LinkedList<AddPanelEvent>.Enumerator itr;
                for (itr = listEventAddPanel_.begin(); itr.MoveNext();)
                {
                    AddPanelEvent @event = itr.Current;
                    string name = @event.name;
                    ref_count_ptr<Panel> panel = new ref_count_ptr<Panel>(@event.panel);

                    IntPtr hTab = wndTab_.GetWindowHandle();
                    panel._AddedLogger(hTab);
                    wndTab_.AddTab(name, panel);

                    RECT rect = new RECT();
                    global::GetClientRect(hWnd_, rect);
                    int wx = rect.left;
                    int wy = rect.top;
                    int wWidth = rect.right - rect.left;
                    int wHeight = rect.bottom - rect.top;
                    wndTab_.SetBounds(wx + 8, wy + 4, wWidth - 16, wHeight - 32);
                    wndTab_.LocateParts();
                }
                listEventAddPanel_.clear();
            }
            break;
        }
    }
    return _CallPreviousWindowProcedure(hWnd, uMsg, wParam, lParam);

}


public void WindowLogger.SetInfo(int row, string textInfo, string textData)
{
    if (hWnd_ == null)
    {
        return;
    }
    wndInfoPanel_.SetInfo(row, textInfo, textData);
}

public bool WindowLogger.AddPanel(ref_count_ptr<Panel> panel, string name)
{
    if (hWnd_ == null)
    {
        return false;
    }

    AddPanelEvent @event = new AddPanelEvent();
    @event.name = name;
    @event.panel.CopyFrom(panel);
    {
        Lock @lock = new Lock(lock_);
        listEventAddPanel_.push_back(@event);
    }

    global::SendMessage(hWnd_, WM_ADDPANEL, 0, 0);

    while (panel.GetWindowHandle() == null)
    {
        Sleep(10); // �E�B���h�E���쐬��������܂őҋ@
    }
    return true;
}
public void WindowLogger.ShowLogWindow()
{
    if (!bEnable_)
    {
        return;
    }
    ShowWindow(hWnd_, SW_SHOW);
}
public void WindowLogger.InsertOpenCommandInSystemMenu(IntPtr hWnd)
{
    IntPtr hMenu = GetSystemMenu(hWnd, false);

    MENUITEMINFO mii = new MENUITEMINFO();
    ZeroMemory(mii, sizeof(MENUITEMINFO));
    mii.cbSize = sizeof(MENUITEMINFO);
    InsertMenuItem(hMenu, 0, 1, mii);

    mii.fMask = MIIM_ID | MIIM_TYPE;
    mii.fType = MFT_STRING;
    mii.wID = MENU_ID_OPEN;
    mii.dwTypeData = "���O�E�B���h�E�\��";

    InsertMenuItem(hMenu, 0, 1, mii);
}

// WindowLogger::InfoCollectThread
public WindowLogger.InfoCollectThread.InfoCollectThread(ref_count_ptr<WStatusBar> wndStatus)
{
    wndStatus_ = wndStatus;
}
public WindowLogger.InfoCollectThread.~InfoCollectThread()
{
    this.Stop();
    this.Join();
    wndStatus_ = null;
}