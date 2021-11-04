public partial class D3DXCOLOR
{
// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public static D3DXINLINE implicit operator uint()
    {
        uint dwR = r >= 1.0f ? 0xff : (uint)(r <= 0.0f ? 0x00 : (uint)(r * 255.0f + 0.5f));
        uint dwG = g >= 1.0f ? 0xff : (uint)(g <= 0.0f ? 0x00 : (uint)(g * 255.0f + 0.5f));
        uint dwB = b >= 1.0f ? 0xff : (uint)(b <= 0.0f ? 0x00 : (uint)(b * 255.0f + 0.5f));
        uint dwA = a >= 1.0f ? 0xff : (uint)(a <= 0.0f ? 0x00 : (uint)(a * 255.0f + 0.5f));
    
        return (dwA << 24) | (dwR << 16) | (dwG << 8) | dwB;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(uint dw)
    {
        CONST float f = 1.0f / 255.0f;
        r = f * (float)(byte)(dw >> 16);
        g = f * (float)(byte)(dw >> 8);
        b = f * (float)(byte)(dw >> 0);
        a = f * (float)(byte)(dw >> 24);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(CONST float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        r = pf[0];
        g = pf[1];
        b = pf[2];
        a = pf[3];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(CONST D3DXFLOAT16 pf)
    {
    #if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
    #endif
    
        D3DXFloat16To32Array(r, pf, 4);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(CONST D3DCOLORVALUE c)
    {
        r = c.r;
        g = c.g;
        b = c.b;
        a = c.a;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(float fr, float fg, float fb, float fa)
    {
        r = fr;
        g = fg;
        b = fb;
        a = fa;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public static D3DXINLINE implicit operator uint()
    {
        uint dwR = r >= 1.0f ? 0xff : (uint)(r <= 0.0f ? 0x00 : (uint)(r * 255.0f + 0.5f));
        uint dwG = g >= 1.0f ? 0xff : (uint)(g <= 0.0f ? 0x00 : (uint)(g * 255.0f + 0.5f));
        uint dwB = b >= 1.0f ? 0xff : (uint)(b <= 0.0f ? 0x00 : (uint)(b * 255.0f + 0.5f));
        uint dwA = a >= 1.0f ? 0xff : (uint)(a <= 0.0f ? 0x00 : (uint)(a * 255.0f + 0.5f));
    
        return (dwA << 24) | (dwR << 16) | (dwG << 8) | dwB;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(uint dw)
    {
        float f = 1.0f / 255.0f;
        r = f * (float)(byte)(dw >> 16);
        g = f * (float)(byte)(dw >> 8);
        b = f * (float)(byte)(dw >> 0);
        a = f * (float)(byte)(dw >> 24);
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(float[] pf)
    {
    #if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
    #endif
    
        r = pf[0];
        g = pf[1];
        b = pf[2];
        a = pf[3];
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(D3DCOLORVALUE c)
    {
        r = c.r;
        g = c.g;
        b = c.b;
        a = c.a;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public D3DXINLINE D3DXCOLOR(float fr, float fg, float fb, float fa)
    {
        r = fr;
        g = fg;
        b = fb;
        a = fa;
    }

// C++ TO C# CONVERTER WARNING: The original C++ declaration of the following method implementation was not found:
    public static D3DXINLINE implicit operator uint()
    {
        uint dwR = r >= 1.0f ? 0xff : (uint)(r <= 0.0f ? 0x00 : (uint)(r * 255.0f + 0.5f));
        uint dwG = g >= 1.0f ? 0xff : (uint)(g <= 0.0f ? 0x00 : (uint)(g * 255.0f + 0.5f));
        uint dwB = b >= 1.0f ? 0xff : (uint)(b <= 0.0f ? 0x00 : (uint)(b * 255.0f + 0.5f));
        uint dwA = a >= 1.0f ? 0xff : (uint)(a <= 0.0f ? 0x00 : (uint)(a * 255.0f + 0.5f));
    
        return (dwA << 24) | (dwR << 16) | (dwG << 8) | dwB;
    }
}