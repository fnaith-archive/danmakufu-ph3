public class D3DXVECTOR2_16F
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR2_16F(CONST float pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat32To16Array(x, pf, 2);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR2_16F(CONST D3DXFLOAT16[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        (uint) & x = (uint) pf[0];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXVECTOR2_16F(CONST D3DXFLOAT16 fx, CONST D3DXFLOAT16 fy)
    {
        x = fx;
        y = fy;
    }
}