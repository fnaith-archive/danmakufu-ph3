using gstd;
using System;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
    /**********************************************************
    //Application
    **********************************************************/
    public class Application : System.IDisposable
    {
            private static Application thisBase_ = null;
            protected bool bAppRun_;
            protected bool bAppActive_;
            protected IntPtr hAppInstance_;
            protected virtual bool _Initialize()
            {
                return true;
            }
            protected virtual bool _Loop()
            {
                return true;
            }
            protected virtual bool _Finalize()
            {
                return true;
            }

            /**********************************************************
            //Application
            **********************************************************/
            protected Application()
            {
                global::InitCommonControls();
            }

            public virtual void Dispose()
            {
                thisBase_ = null;
            }

            public static Application GetBase()
            {
                return thisBase_;
            }
            public bool Initialize()
            {
                if (thisBase_ != null)
                {
                    return false;
                }
                thisBase_ = this;
                hAppInstance_ = global::GetModuleHandle(null);
                bAppRun_ = true;
                bAppActive_ = true;
                return true;
            }

            public virtual bool Run()
            {
                if (bAppRun_ == false)
                {
                    return false;
                }

                try
                {
                    bool res = _Initialize();
                    if (res == false)
                    {
                        throw new gstd.wexception("���������ɗ�O���������܂����B");
                    }
                }
                catch (System.Exception e)
                {
                    string log = StringUtility.ConvertMultiToWide(e.Message);
                    Logger.WriteTop(log);
                    Logger.WriteTop("���������ɗ�O���������܂����B�����I�����܂��B");
                    bAppRun_ = false;
                }
                catch (gstd.wexception e)
                {
                    string log = e.what();
                    Logger.WriteTop(log);
                    Logger.WriteTop("���������ɗ�O���������܂����B�����I�����܂��B");
                    bAppRun_ = false;
                }
                catch
                {
                    Logger.WriteTop("���������ɗ�O���������܂����B�����I�����܂��B");
                    bAppRun_ = false;
                }

                MSG msg = new MSG();
                while (true)
                {
                    if (bAppRun_ == false)
                    {
                        break;
                    }
                    if (global::PeekMessage(msg, 0, 0, 0, PM_NOREMOVE))
                    {
                        if (!global::GetMessage(msg, null, 0, 0))
                        {
                            break;
                        }
                        global::TranslateMessage(msg);
                        global::DispatchMessage(msg);
                    }
                    else
                    {
                        if (bAppActive_ == false)
                        {
                            Sleep(10);
                            continue;
                        }
                        try
                        {
                            if (_Loop() == false)
                            {
                                break;
                            }
                        }
                        catch (System.Exception e)
                        {
                            string log = StringUtility.ConvertMultiToWide(e.Message);
                            Logger.WriteTop(log);
                            Logger.WriteTop("���s���ɗ�O���������܂����B�I�����܂��B");
                            break;
                        }
                        catch (gstd.wexception e)
                        {
                            string log = e.what();
                            Logger.WriteTop(log);
                            Logger.WriteTop("���s���ɗ�O���������܂����B�I�����܂��B");
                            break;
                        }
            // 			catch(...)
            // 			{
            // 				Logger::WriteTop(L"���s���ɗ�O���������܂����B�I�����܂��B");
            // 				break;
            // 			}
                    }
                }

                bAppRun_ = false;

                try
                {
                    bool res = _Finalize();
                    if (res == false)
                    {
                        throw new gstd.wexception("�I�����ɗ�O���������܂����B");
                    }
                }
                catch (System.Exception e)
                {
                    string log = StringUtility.ConvertMultiToWide(e.Message);
                    Logger.WriteTop(log);
                    Logger.WriteTop("����ɏI���ł��܂���ł����B");
                }
                catch (gstd.wexception e)
                {
                    string log = e.what();
                    Logger.WriteTop(log);
                    Logger.WriteTop("����ɏI���ł��܂���ł����B");
                    bAppRun_ = false;
                }
                catch
                {
                    Logger.WriteTop("����ɏI���ł��܂���ł����B");
                }
                return true;
            }

            public bool IsActive()
            {
                return this.bAppActive_;
            }
            public void SetActive(bool b)
            {
                this.bAppActive_ = b;
            }
            public bool IsRun()
            {
                return bAppRun_;
            }
            public void End()
            {
                bAppRun_ = false;
            }

            public static IntPtr GetApplicationHandle()
            {
                return global::GetModuleHandle(null);
            }
    }
}

