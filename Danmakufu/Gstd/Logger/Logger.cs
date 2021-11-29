using System;
using System.Collections.Generic;

namespace Gstd.Logger
{
    public abstract class Logger : System.IDisposable
    {
        protected static Logger top = null;
        //protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
        protected List<Logger> listLogger = new List<Logger>(); // �q�̃��K
        protected virtual void _WriteChild(DateTime time, string str)
        {
            _Write(time, str);
            foreach (Logger logger in listLogger)
            {
                logger._Write(time, str);
            }
        }
        protected abstract void _Write(DateTime time, string str);
        public Logger()
        {
        }
        public virtual void Dispose()
        {
            listLogger.Clear();
            if (top == this)
            {
                top = null;
            }
        }
        public virtual bool Initialize()
        {
            return true;
        }
        public void AddLogger(Logger logger)
        {
            listLogger.Add(logger);
        }
        public virtual void Write(string str)
        {
            DateTime systemTime = DateTime.Now;
            this._WriteChild(systemTime, str);
        }
        public static void SetTop(Logger logger)
        {
            top = logger;
        }
        public static void WriteTop(string str)
        {
            if (top != null)
            {
                top.Write(str);
            }
        } // �g�b�v�̃��K�ɏo�͂��܂�
    }
}
