public class CriticalSection
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public CriticalSection()
    {
        idThread_ = null;
        countLock_ = 0;
        global::InitializeCriticalSection(cs_);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Dispose()
    {
        global::DeleteCriticalSection(cs_);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Enter()
    {
        if (global::GetCurrentThreadId() == idThread_)
        { // �J�����g�X���b�h
            countLock_++;
            return;
        }
    
        global::EnterCriticalSection(cs_);
        countLock_ = 1;
        idThread_ = global::GetCurrentThreadId();
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Leave()
    {
        if (global::GetCurrentThreadId() == idThread_)
        {
            countLock_--;
            if (countLock_ != 0)
            {
                return;
            }
            if (countLock_ < 0)
            {
                throw new System.Exception("CriticalSection�FLock���Ă��܂���");
            }
        }
        else
        {
            throw new System.Exception("CriticalSection�FLock���Ă��Ȃ��̂�Unlock���悤�Ƃ��܂���");
        }
        idThread_ = null;
        global::LeaveCriticalSection(cs_);
    }
}