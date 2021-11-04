public class _D3DMATRIX
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public static D3DXINLINE object operator new(size_t s)
    {
    // C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
        byte * p = global::new byte[s + 16];
        if (p != 0)
        {
            byte offset = (byte)(16 - ((UIntPtr)p & 15));
            p += offset;
            p[-1] = offset;
        }
        return p;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public static D3DXINLINE void operator delete(object p)
    {
        if (p)
        {
    // C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
            byte * pb = (byte)p;
            pb -= pb[-1];
            global::delete[] pb;
        }
    }
}