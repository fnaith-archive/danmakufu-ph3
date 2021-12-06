using System;

namespace Gstd.Application
{
    public class Application : System.IDisposable
    {
        private static Application thisBase = null;
        protected bool bAppRun;
        protected bool bAppActive;
        //protected IntPtr hAppInstance_; TODO
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
        protected Application()
        {
            //global::InitCommonControls();
        }
        public virtual void Dispose()
        {
            thisBase = null;
        }
        public static Application GetBase()
        {
            return thisBase;
        }
        public bool Initialize()
        {
            if (thisBase != null)
            {
                return false;
            }
            thisBase = this;
            //hAppInstance_ = global::GetModuleHandle(null); TODO
            bAppRun = true;
            bAppActive = true;
            return true;
        }
        public virtual bool Run()
        {
            if (bAppRun == false)
            {
                return false;
            }

            try
            {
                bool res = _Initialize();
                if (res == false)
                {
                    throw new Exception("���������ɗ�O���������܂����B");
                }
            }
            catch (System.Exception e)
            {
                string log = /*StringUtility.ConvertMultiToWide*/(e.Message);
                //Logger.WriteTop(log);
                //Logger.WriteTop("���������ɗ�O���������܂����B�����I�����܂��B");
                bAppRun = false;
            }
            /*catch (gstd.wexception e)
            {
                string log = e.what();
                //Logger.WriteTop(log);
                //Logger.WriteTop("���������ɗ�O���������܂����B�����I�����܂��B");
                bAppRun_ = false;
            }*/
            catch
            {
                //Logger.WriteTop("���������ɗ�O���������܂����B�����I�����܂��B");
                bAppRun = false;
            }

            //MSG msg = new MSG();
            while (true)
            {
                if (bAppRun == false)
                {
                    break;
                }
                if (true /* global::PeekMessage(msg, 0, 0, 0, PM_NOREMOVE) TODO*/)
                {
                    /*if (!global::GetMessage(msg, null, 0, 0)) TODO
                    {
                        break;
                    }*/
                    //global::TranslateMessage(msg); TODO
                    //global::DispatchMessage(msg); TODO
                }
                else
                {
                    if (bAppActive == false)
                    {
                        //Sleep(10); TODO
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
                        string log = /*StringUtility.ConvertMultiToWide*/(e.Message);
                        //Logger.WriteTop(log);
                        //Logger.WriteTop("���s���ɗ�O���������܂����B�I�����܂��B");
                        break;
                    }
                    /*catch (gstd.wexception e)
                    {
                        string log = e.what();
                        Logger.WriteTop(log);
                        Logger.WriteTop("���s���ɗ�O���������܂����B�I�����܂��B");
                        break;
                    }*/
        // 			catch(...)
        // 			{
        // 				Logger::WriteTop(L"���s���ɗ�O���������܂����B�I�����܂��B");
        // 				break;
        // 			}
                }
            }

            bAppRun = false;

            try
            {
                bool res = _Finalize();
                if (res == false)
                {
                    throw new Exception("�I�����ɗ�O���������܂����B");
                }
            }
            catch (System.Exception e)
            {
                string log = /*StringUtility.ConvertMultiToWide*/(e.Message);
                //Logger.WriteTop(log);
                //Logger.WriteTop("����ɏI���ł��܂���ł����B");
            }
            /*catch (gstd.wexception e)
            {
                string log = e.what();
                Logger.WriteTop(log);
                Logger.WriteTop("����ɏI���ł��܂���ł����B");
                bAppRun_ = false;
            }*/
            catch
            {
                //Logger.WriteTop("����ɏI���ł��܂���ł����B");
            }
            return true;
        }
        public bool IsActive()
        {
            return bAppActive;
        }
        public void SetActive(bool b)
        {
            bAppActive = b;
        }
        public bool IsRun()
        {
            return bAppRun;
        }
        public void End()
        {
            bAppRun = false;
        }
        /*public static IntPtr GetApplicationHandle() TODO
        {
            return global::GetModuleHandle(null);
        }*/
    }
}
