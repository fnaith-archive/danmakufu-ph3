public partial class D3DXMATRIX
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(CONST float pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
    // C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, pf, sizeof(D3DXMATRIX));
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(CONST D3DMATRIX mat)
    {
    // C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, mat, sizeof(D3DXMATRIX));
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(CONST D3DXFLOAT16 pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat16To32Array(_11, pf, 16);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(float f11, float f12, float f13, float f14, float f21, float f22, float f23, float f24, float f31, float f32, float f33, float f34, float f41, float f42, float f43, float f44)
    {
        _11 = f11;
        _12 = f12;
        _13 = f13;
        _14 = f14;
        _21 = f21;
        _22 = f22;
        _23 = f23;
        _24 = f24;
        _31 = f31;
        _32 = f32;
        _33 = f33;
        _34 = f34;
        _41 = f41;
        _42 = f42;
        _43 = f43;
        _44 = f44;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(float pf)
    {
    #if D3DX_DEBUG
        if (pf == 0)
        {
            return;
        }
    #endif
    
    // C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(m00, pf, sizeof(D3DXMATRIX));
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(D3DMATRIX mat)
    {
    // C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(m00, mat, sizeof(D3DXMATRIX));
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXMATRIX(float f00, float f01, float f02, float f03, float f10, float f11, float f12, float f13, float f20, float f21, float f22, float f23, float f30, float f31, float f32, float f33)
    {
        m00 = f00;
        m01 = f01;
        m02 = f02;
        m03 = f03;
        m10 = f10;
        m11 = f11;
        m12 = f12;
        m13 = f13;
        m20 = f20;
        m21 = f21;
        m22 = f22;
        m23 = f23;
        m30 = f30;
        m31 = f31;
        m32 = f32;
        m33 = f33;
    }
}