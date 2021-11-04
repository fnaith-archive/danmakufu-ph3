public partial class D3DXVECTOR3
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(CONST float[] pf)
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
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(CONST D3DVECTOR v)
    {
        x = v.x;
        y = v.y;
        z = v.z;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(CONST D3DXFLOAT16 pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat16To32Array(x, pf, 3);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(float fx, float fy, float fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(float[] pf)
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
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(D3DVECTOR v)
    {
        x = v.x;
        y = v.y;
        z = v.z;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3(float fx, float fy, float fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }
}