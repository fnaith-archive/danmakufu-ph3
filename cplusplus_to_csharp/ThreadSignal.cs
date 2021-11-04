public class ThreadSignal
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public ThreadSignal(bool bManualReset)
    {
        bool bManual = bManualReset ? true : false;
        hEvent_ = global::CreateEvent(null, bManual, false, null);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void Dispose()
    {
        global::CloseHandle(hEvent_);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public uint Wait(int mills)
    {
        uint res = WAIT_OBJECT_0;
    
        if (hEvent_ != null)
        {
            res = global::WaitForSingleObject(hEvent_, mills);
        }
    
        return res;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public void SetSignal(bool bOn)
    {
        if (bOn)
        {
            global::SetEvent(hEvent_);
        }
        else
        {
            global::ResetEvent(hEvent_);
        }
    }
}