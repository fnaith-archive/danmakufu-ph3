using System;
using Gstd.Application;

namespace DnhViewer.MainWindow
{
    public class WinMain
    {
        public static int wWinMain(/*HINSTANCE hInstance,
                                HINSTANCE hPrevInstance,
                                LPWSTR lpCmdLine,
                                int nCmdShow*/)
        {
            /*gstd::DebugUtility::DumpMemoryLeaksOnExit();

            try
            {
                DnhConfiguration* config = DnhConfiguration::CreateInstance();
                ELogger* logger = ELogger::CreateInstance();
                logger->Initialize(config->IsLogFile(), config->IsLogWindow());
                EPathProperty::CreateInstance();
                MainWindow* wndMain = MainWindow::CreateInstance();
                wndMain->Initialize();

                EApplication* app = EApplication::CreateInstance();
                app->Initialize();
                app->Run();
            }
            catch(std::exception& e)
            {
                std::wstring log = StringUtility::ConvertMultiToWide(e.what());
                Logger::WriteTop(log);
            }
            catch(gstd::wexception& e)
            {
                Logger::WriteTop(e.what());
            }
        //	catch(...)
        //	{
        //		Logger::WriteTop("�s���ȃG���[");
        //	}

            EApplication::DeleteInstance();
            MainWindow::DeleteInstance();
            EPathProperty::DeleteInstance();
            ELogger::DeleteInstance();
            DnhConfiguration::DeleteInstance();*/

            return 0;
        }
    }
}
