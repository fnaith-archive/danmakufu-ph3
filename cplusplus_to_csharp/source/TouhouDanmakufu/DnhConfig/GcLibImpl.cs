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
//EApplication
**********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
public class EApplication : Singleton<EApplication>, Application
{
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend Singleton<EApplication>;

        /**********************************************************
        //EApplication
        **********************************************************/
        private EApplication()
        {

        }

        protected new bool _Initialize()
        {
            ELogger logger = ELogger.GetInstance();
            Logger.WriteTop("�A�v?�P�[�V???����");

            EFileManager fileManager = EFileManager.CreateInstance();
            fileManager.Initialize();

            IntPtr hWndMain = MainWindow.GetInstance().GetWindowHandle();
            WindowLogger.InsertOpenCommandInSystemMenu(hWndMain);
        // 	::SetWindowText(hWndMain, "DnhViewer");
        // 	::SetClassLong(hWndMain, GCL_HICON, (LONG)LoadIcon(GetApplicationHandle(), MAKEINTRESOURCE(IDI_ICON)));

            EDirectInput input = EDirectInput.CreateInstance();
            input.Initialize(hWndMain);

            MainWindow wndMain = MainWindow.GetInstance();
            wndMain.StartUp();
            global::SetForegroundWindow(wndMain.GetWindowHandle());

            Logger.WriteTop("�A�v?�P�[�V???��������");

            return true;
        }

        protected new bool _Loop()
        {
            ELogger logger = ELogger.GetInstance();

            MainWindow mainWindow = MainWindow.GetInstance();
            IntPtr hWndFocused = global::GetForegroundWindow();
            IntPtr hWndMain = mainWindow.GetWindowHandle();
            IntPtr hWndLogger = ELogger.GetInstance().GetWindowHandle();
            if (hWndFocused != hWndMain && hWndFocused != hWndLogger)
            {
                // ��A�N�e�B�u?�͓��삵�Ȃ�
                global::Sleep(10);
                return true;
            }

            EDirectInput input = EDirectInput.GetInstance();
            input.Update();
            mainWindow.UpdateKeyAssign();

            global::Sleep(10);

            return true;
        }

        protected new bool _Finalize()
        {
            Logger.WriteTop("�A�v?�P�[�V??�I��??�J�n");
            EFileManager.GetInstance().EndLoadThread();
            EDirectInput.DeleteInstance();
            EFileManager.DeleteInstance();
            Logger.WriteTop("�A�v?�P�[�V??�I��??����");
            return true;
        }

        public new void Dispose()
        {

            base.Dispose();
        }
}


