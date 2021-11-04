using System;

namespace gstd
{
    // ================================================================
    // Thread
    public abstract class Thread : System.IDisposable
    {
            public enum Status
            {
                RUN, // �ғ���
                STOP, // ��~��
                REQUEST_STOP // ��~�v����
            }
// C++ TO C# CONVERTER NOTE: __stdcall is not available in C#:
// ORIGINAL LINE: static uint __stdcall _StaticRun(object* data);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            static uint _StaticRun(object data);
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile System.IntPtr hThread_;
            protected IntPtr hThread_;
            protected uint idThread_;
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile Status status_;
            protected Status status_;
            protected abstract void _Run();

//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            Thread();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            public void Dispose();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            virtual void Start();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            virtual void Stop();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            bool IsStop();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            uint Join(int mills = INFINITE);

            public Status GetStatus()
            {
                return status_;
            }
    }

    // ================================================================
    // CriticalSection
    public class CriticalSection : System.IDisposable
    {
            private CRITICAL_SECTION cs_ = new CRITICAL_SECTION();
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile uint idThread_;
            private uint idThread_;
// C++ TO C# CONVERTER TODO TASK: 'volatile' has a different meaning in C#:
// ORIGINAL LINE: volatile int countLock_;
            private int countLock_;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            CriticalSection();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            public void Dispose();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            void Enter();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            void Leave();
    }

    // ================================================================
    // Lock
    public class Lock : System.IDisposable
    {
            protected CriticalSection cs_;
            public Lock(CriticalSection cs)
            {
                cs_ = cs;
                cs_.Enter();
            }
            public virtual void Dispose()
            {
                cs_.Leave();
            }
    }

    // ================================================================
    // ThreadSignal
    public class ThreadSignal : System.IDisposable
    {
            private IntPtr hEvent_;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            ThreadSignal(bool bManualReset = false);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            public void Dispose();
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            uint Wait(int mills = INFINITE);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//            void SetSignal(bool bOn = true);
    }
}

