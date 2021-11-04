public partial class D3DXQUATERNION
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXQUATERNION(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        x = pf[0];
        y = pf[1];
        z = pf[2];
        w = pf[3];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXQUATERNION(CONST D3DXFLOAT16 pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat16To32Array(x, pf, 4);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXQUATERNION(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXQUATERNION(float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        x = pf[0];
        y = pf[1];
        z = pf[2];
        w = pf[3];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXQUATERNION(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }
}