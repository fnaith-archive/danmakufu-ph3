public partial class D3DXVECTOR4
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4(CONST float[] pf)
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
    public D3DXINLINE D3DXVECTOR4(CONST D3DXFLOAT16 pf)
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
    public D3DXINLINE D3DXVECTOR4(CONST D3DVECTOR v, float f)
    {
        x = v.x;
        y = v.y;
        z = v.z;
        w = f;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4(float[] pf)
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
    public D3DXINLINE D3DXVECTOR4(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }
}