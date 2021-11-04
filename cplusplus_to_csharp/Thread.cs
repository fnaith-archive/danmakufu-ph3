public class Thread
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public Thread()
    {
        hThread_ = null;
        idThread_ = 0;
        status_ = STOP;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Dispose()
    {
        this.Stop();
        this.Join();
        if (hThread_ != null)
        {
            global::CloseHandle(hThread_);
            hThread_ = null;
            idThread_ = 0;
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public uint _StaticRun(object data)
    {
        try
        {
    // C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'reinterpret_cast' in C#:
            Thread thread = reinterpret_cast<Thread>(data);
            thread.status_ = RUN;
            thread._Run();
            thread.status_ = STOP;
        }
        catch
        {
            // �G���[�͖���
        }
        return 0;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Start()
    {
        if (status_ != STOP)
        {
            this.Stop();
            this.Join();
        }
    
        hThread_ = (IntPtr)_beginthreadex(null, 0, _StaticRun, (object)this, 0, idThread_);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Stop()
    {
        if (status_ == RUN)
        {
            status_ = REQUEST_STOP;
        }
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public bool IsStop()
    {
        return hThread_ == null || status_ == STOP;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public uint Join(int mills)
    {
        uint res = WAIT_OBJECT_0;
    
        if (hThread_ != null)
        {
            res = global::WaitForSingleObject(hThread_, mills);
        }
    
        if (hThread_ != null)
        {
            if (res != WAIT_TIMEOUT)
            {
                global::CloseHandle(hThread_); // �^�C���A�E�g�̏ꍇ�N���[�Y�ł��Ȃ�
            }
            hThread_ = null;
            idThread_ = 0;
            status_ = STOP;
        }
        return res;
    }
}