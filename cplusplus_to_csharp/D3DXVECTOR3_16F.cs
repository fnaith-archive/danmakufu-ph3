public class D3DXVECTOR3_16F
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3_16F(CONST float pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat32To16Array(x, pf, 3);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3_16F(CONST D3DVECTOR v)
    {
        D3DXFloat32To16Array(x, v.x, 1);
        D3DXFloat32To16Array(y, v.y, 1);
        D3DXFloat32To16Array(z, v.z, 1);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3_16F(CONST D3DXFLOAT16[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        (uint) & x = (uint) pf[0];
        (ushort) & z = (ushort) pf[2];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR3_16F(CONST D3DXFLOAT16 fx, CONST D3DXFLOAT16 fy, CONST D3DXFLOAT16 fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }
}