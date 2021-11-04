public class D3DXVECTOR4_16F
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4_16F(CONST float pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat32To16Array(x, pf, 4);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4_16F(CONST D3DXFLOAT16[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        (uint) & x = (uint) pf[0];
        (uint) & z = (uint) pf[2];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4_16F(CONST D3DXVECTOR3_16F v, CONST D3DXFLOAT16 f)
    {
        x = v.x;
        y = v.y;
        z = v.z;
        w = f;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR4_16F(CONST D3DXFLOAT16 fx, CONST D3DXFLOAT16 fy, CONST D3DXFLOAT16 fz, CONST D3DXFLOAT16 fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }
}