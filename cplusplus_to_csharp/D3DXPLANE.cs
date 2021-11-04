public partial class D3DXPLANE
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXPLANE(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        a = pf[0];
        b = pf[1];
        c = pf[2];
        d = pf[3];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXPLANE(CONST D3DXFLOAT16 pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat16To32Array(a, pf, 4);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXPLANE(float fa, float fb, float fc, float fd)
    {
        a = fa;
        b = fb;
        c = fc;
        d = fd;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXPLANE(float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        a = pf[0];
        b = pf[1];
        c = pf[2];
        d = pf[3];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXPLANE(float fa, float fb, float fc, float fd)
    {
        a = fa;
        b = fb;
        c = fc;
        d = fd;
    }
}