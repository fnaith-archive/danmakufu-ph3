public class D3DXFLOAT16
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXFLOAT16(float f)
    {
        D3DXFloat32To16Array(this, f, 1);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXFLOAT16(CONST D3DXFLOAT16 f)
    {
        value = f.value;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public static D3DXINLINE implicit operator float()
    {
        float f;
        D3DXFloat16To32Array(f, this, 1);
        return f;
    }
}