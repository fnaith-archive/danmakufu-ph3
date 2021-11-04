using System;

/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx9math.h
//  Content:    D3DX math types and functions
// 
/// ///////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3dx9.h"


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1200
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(push)
#endif
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201) // anonymous unions warning



// ===========================================================================
// 
// General purpose utilities
// 
// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PI ((FLOAT) 3.141592654f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_1BYPI ((FLOAT) 0.318309886f)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToRadian( degree ) ((degree) * (D3DX_PI / 180.0f))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToDegree( radian ) ((radian) * (180.0f / D3DX_PI))



// ===========================================================================
// 
// 16 bit floating point numbers
// 
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_16F_EPSILON 4.8875809e-4f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_16F_MIN 6.1035156e-5f


public class D3DXFLOAT16
{
#if __cplusplus
    public D3DXFLOAT16()
    {
    }

    // --------------------------
    // Float16
    // --------------------------

#if __cplusplus
    public D3DXINLINE D3DXFLOAT16(float f)
    {
        D3DXFloat32To16Array(this, f, 1);
    }

    public D3DXINLINE D3DXFLOAT16(CONST D3DXFLOAT16 f)
    {
        value = f.value;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXFLOAT16 ImpliedObject)
    {
        float f;
        D3DXFloat16To32Array(f, ImpliedObject, 1);
        return f;
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXFLOAT16& f) const
    public static D3DXINLINE bool operator == (D3DXFLOAT16 ImpliedObject, CONST D3DXFLOAT16 f)
    {
        return ImpliedObject.value == f.value;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXFLOAT16& f) const
    public static D3DXINLINE bool operator != (D3DXFLOAT16 ImpliedObject, CONST D3DXFLOAT16 f)
    {
        return ImpliedObject.value != f.value;
    }

#endif //__cplusplus
    protected ushort value;
}



// ===========================================================================
// 
// Vectors
// 
// ===========================================================================


// --------------------------
// 2D Vector
// --------------------------
public partial class D3DXVECTOR2
{
#if __cplusplus
    public D3DXVECTOR2()
    {
    }

    // --------------------------
    // 2D Vector
    // --------------------------

    public D3DXINLINE D3DXVECTOR2(CONST float[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        x = pf[0];
        y = pf[1];
    }

    public D3DXINLINE D3DXVECTOR2(CONST D3DXFLOAT16 pf)
    {
#if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
#endif

        D3DXFloat16To32Array(x, pf, 2);
    }

    public D3DXINLINE D3DXVECTOR2(float fx, float fy)
    {
        x = fx;
        y = fy;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXVECTOR2 ImpliedObject)
    {
        return (float) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXVECTOR2 ImpliedObject)
    {
        return (CONST float) & ImpliedObject.x;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator += (CONST D3DXVECTOR2 v)
    {
        x += v.x;
        y += v.y;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator -= (CONST D3DXVECTOR2 v)
    {
        x -= v.x;
        y -= v.y;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator *= (float f)
    {
        x *= f;
        y *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR2 operator /= (float f)
    {
        float fInv = 1.0f / f;
        x *= fInv;
        y *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator + () const
    public static D3DXINLINE D3DXVECTOR2 operator + (D3DXVECTOR2 ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator - () const
    public static D3DXINLINE D3DXVECTOR2 operator - (D3DXVECTOR2 ImpliedObject)
    {
        return new D3DXVECTOR2(-ImpliedObject.x, -ImpliedObject.y);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator + (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE D3DXVECTOR2 operator + (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return new D3DXVECTOR2(ImpliedObject.x + v.x, ImpliedObject.y + v.y);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator - (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE D3DXVECTOR2 operator - (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return new D3DXVECTOR2(ImpliedObject.x - v.x, ImpliedObject.y - v.y);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator * (float f) const
    public static D3DXINLINE D3DXVECTOR2 operator * (D3DXVECTOR2 ImpliedObject, float f)
    {
        return new D3DXVECTOR2(ImpliedObject.x * f, ImpliedObject.y * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR2 operator / (float f) const
    public static D3DXINLINE D3DXVECTOR2 operator / (D3DXVECTOR2 ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXVECTOR2(ImpliedObject.x * fInv, ImpliedObject.y * fInv);
    }

    public static D3DXINLINE D3DXVECTOR2 operator * (float f, CONST D3DXVECTOR2 v)
    {
        return new D3DXVECTOR2(f * v.x, f * v.y);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return ImpliedObject.x == v.x && ImpliedObject.y == v.y;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR2& v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR2 ImpliedObject, CONST D3DXVECTOR2 v)
    {
        return ImpliedObject.x != v.x || ImpliedObject.y != v.y;
    }


#endif //__cplusplus
    public float x;
    public float y;
}



// --------------------------
// 2D Vector (16 bit)
// --------------------------

public class D3DXVECTOR2_16F
{
#if __cplusplus
    public D3DXVECTOR2_16F()
    {
    }

    // --------------------------
    // 2D Vector (16 bit)
    // --------------------------

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

    public D3DXINLINE D3DXVECTOR2_16F(CONST D3DXFLOAT16[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        (uint) x = (uint) pf[0];
    }

    public D3DXINLINE D3DXVECTOR2_16F(CONST D3DXFLOAT16 fx, CONST D3DXFLOAT16 fy)
    {
        x = fx;
        y = fy;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator D3DXFLOAT16(D3DXVECTOR2_16F ImpliedObject)
    {
        return (D3DXFLOAT16) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST D3DXFLOAT16* () const
    public static D3DXINLINE implicit operator CONST D3DXFLOAT16(D3DXVECTOR2_16F ImpliedObject)
    {
        return (CONST D3DXFLOAT16) & ImpliedObject.x;
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR2_16F &v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR2_16F ImpliedObject, CONST D3DXVECTOR2_16F v)
    {
        return ((uint) & ImpliedObject.x) == (uint) v.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR2_16F &v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR2_16F ImpliedObject, CONST D3DXVECTOR2_16F v)
    {
        return ((uint) & ImpliedObject.x) != (uint) v.x;
    }

#endif //__cplusplus
    public D3DXFLOAT16 x = new D3DXFLOAT16();
    public D3DXFLOAT16 y = new D3DXFLOAT16();

}



// --------------------------
// 3D Vector
// --------------------------
#if __cplusplus
public partial class D3DXVECTOR3 : D3DVECTOR
{
    public D3DXVECTOR3()
    {
    }

    // --------------------------
    // 3D Vector
    // --------------------------
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

    public D3DXINLINE D3DXVECTOR3(CONST D3DVECTOR v)
    {
        x = v.x;
        y = v.y;
        z = v.z;
    }

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

    public D3DXINLINE D3DXVECTOR3(float fx, float fy, float fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }

    // casting
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator += (CONST D3DXVECTOR3);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator -= (CONST D3DXVECTOR3);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator + (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator + (CONST D3DXVECTOR3);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator - (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator - (CONST D3DXVECTOR3);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXVECTOR3 operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXVECTOR3 operator / (float UnnamedParameter);

    public static D3DXINLINE _D3DVECTOR operator * (float f, CONST D3DXVECTOR3 v)
    {
        return struct _D3DVECTOR(f * v.x, f * v.y, f * v.z);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXVECTOR3);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXVECTOR3&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXVECTOR3);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXVECTOR3 D3DXVECTOR3;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXVECTOR3 *LPD3DXVECTOR3;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DVECTOR D3DXVECTOR3, *LPD3DXVECTOR3;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DVECTOR *LPD3DXVECTOR3;
#endif //!__cplusplus



// --------------------------
// 3D Vector (16 bit)
// --------------------------
public class D3DXVECTOR3_16F
{
#if __cplusplus
    public D3DXVECTOR3_16F()
    {
    }

    // --------------------------
    // 3D Vector (16 bit)
    // --------------------------

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

    public D3DXINLINE D3DXVECTOR3_16F(CONST D3DVECTOR v)
    {
        D3DXFloat32To16Array(x, v.x, 1);
        D3DXFloat32To16Array(y, v.y, 1);
        D3DXFloat32To16Array(z, v.z, 1);
    }

    public D3DXINLINE D3DXVECTOR3_16F(CONST D3DXFLOAT16[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        (uint) x = (uint) pf[0];
        (ushort) z = (ushort) pf[2];
    }

    public D3DXINLINE D3DXVECTOR3_16F(CONST D3DXFLOAT16 fx, CONST D3DXFLOAT16 fy, CONST D3DXFLOAT16 fz)
    {
        x = fx;
        y = fy;
        z = fz;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator D3DXFLOAT16(D3DXVECTOR3_16F ImpliedObject)
    {
        return (D3DXFLOAT16) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST D3DXFLOAT16* () const
    public static D3DXINLINE implicit operator CONST D3DXFLOAT16(D3DXVECTOR3_16F ImpliedObject)
    {
        return (CONST D3DXFLOAT16) & ImpliedObject.x;
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR3_16F &v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR3_16F ImpliedObject, CONST D3DXVECTOR3_16F v)
    {
        return ((uint) & ImpliedObject.x) == (uint) v.x && (ushort) & ImpliedObject.z == (ushort) v.z;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR3_16F &v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR3_16F ImpliedObject, CONST D3DXVECTOR3_16F v)
    {
        return ((uint) & ImpliedObject.x) != (uint) v.x || (ushort) & ImpliedObject.z != (ushort) v.z;
    }

#endif //__cplusplus
    public D3DXFLOAT16 x = new D3DXFLOAT16();
    public D3DXFLOAT16 y = new D3DXFLOAT16();
    public D3DXFLOAT16 z = new D3DXFLOAT16();

}



// --------------------------
// 4D Vector
// --------------------------
public partial class D3DXVECTOR4
{
#if __cplusplus
    public D3DXVECTOR4()
    {
    }

    // --------------------------
    // 4D Vector
    // --------------------------
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

    public D3DXINLINE D3DXVECTOR4(CONST D3DVECTOR v, float f)
    {
        x = v.x;
        y = v.y;
        z = v.z;
        w = f;
    }

    public D3DXINLINE D3DXVECTOR4(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXVECTOR4 ImpliedObject)
    {
        return (float) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXVECTOR4 ImpliedObject)
    {
        return (CONST float) & ImpliedObject.x;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator += (CONST D3DXVECTOR4 v)
    {
        x += v.x;
        y += v.y;
        z += v.z;
        w += v.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator -= (CONST D3DXVECTOR4 v)
    {
        x -= v.x;
        y -= v.y;
        z -= v.z;
        w -= v.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator *= (float f)
    {
        x *= f;
        y *= f;
        z *= f;
        w *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXVECTOR4 operator /= (float f)
    {
        float fInv = 1.0f / f;
        x *= fInv;
        y *= fInv;
        z *= fInv;
        w *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator + () const
    public static D3DXINLINE D3DXVECTOR4 operator + (D3DXVECTOR4 ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator - () const
    public static D3DXINLINE D3DXVECTOR4 operator - (D3DXVECTOR4 ImpliedObject)
    {
        return new D3DXVECTOR4(-ImpliedObject.x, -ImpliedObject.y, -ImpliedObject.z, -ImpliedObject.w);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator + (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE D3DXVECTOR4 operator + (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return new D3DXVECTOR4(ImpliedObject.x + v.x, ImpliedObject.y + v.y, ImpliedObject.z + v.z, ImpliedObject.w + v.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator - (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE D3DXVECTOR4 operator - (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return new D3DXVECTOR4(ImpliedObject.x - v.x, ImpliedObject.y - v.y, ImpliedObject.z - v.z, ImpliedObject.w - v.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator * (float f) const
    public static D3DXINLINE D3DXVECTOR4 operator * (D3DXVECTOR4 ImpliedObject, float f)
    {
        return new D3DXVECTOR4(ImpliedObject.x * f, ImpliedObject.y * f, ImpliedObject.z * f, ImpliedObject.w * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXVECTOR4 operator / (float f) const
    public static D3DXINLINE D3DXVECTOR4 operator / (D3DXVECTOR4 ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXVECTOR4(ImpliedObject.x * fInv, ImpliedObject.y * fInv, ImpliedObject.z * fInv, ImpliedObject.w * fInv);
    }

    public static D3DXINLINE D3DXVECTOR4 operator * (float f, CONST D3DXVECTOR4 v)
    {
        return new D3DXVECTOR4(f * v.x, f * v.y, f * v.z, f * v.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return ImpliedObject.x == v.x && ImpliedObject.y == v.y && ImpliedObject.z == v.z && ImpliedObject.w == v.w;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR4& v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR4 ImpliedObject, CONST D3DXVECTOR4 v)
    {
        return ImpliedObject.x != v.x || ImpliedObject.y != v.y || ImpliedObject.z != v.z || ImpliedObject.w != v.w;
    }

#endif //__cplusplus
    public float x;
    public float y;
    public float z;
    public float w;
}


// --------------------------
// 4D Vector (16 bit)
// --------------------------
public class D3DXVECTOR4_16F
{
#if __cplusplus
    public D3DXVECTOR4_16F()
    {
    }

    // --------------------------
    // 4D Vector (16 bit)
    // --------------------------

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

    public D3DXINLINE D3DXVECTOR4_16F(CONST D3DXFLOAT16[] pf)
    {
#if D3DX_DEBUG
        if (!pf)
        {
            return;
        }
#endif

        (uint) x = (uint) pf[0];
        (uint) z = (uint) pf[2];
    }

    public D3DXINLINE D3DXVECTOR4_16F(CONST D3DXVECTOR3_16F v, CONST D3DXFLOAT16 f)
    {
        x = v.x;
        y = v.y;
        z = v.z;
        w = f;
    }

    public D3DXINLINE D3DXVECTOR4_16F(CONST D3DXFLOAT16 fx, CONST D3DXFLOAT16 fy, CONST D3DXFLOAT16 fz, CONST D3DXFLOAT16 fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator D3DXFLOAT16(D3DXVECTOR4_16F ImpliedObject)
    {
        return (D3DXFLOAT16) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST D3DXFLOAT16* () const
    public static D3DXINLINE implicit operator CONST D3DXFLOAT16(D3DXVECTOR4_16F ImpliedObject)
    {
        return (CONST D3DXFLOAT16) & ImpliedObject.x;
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXVECTOR4_16F &v) const
    public static D3DXINLINE bool operator == (D3DXVECTOR4_16F ImpliedObject, CONST D3DXVECTOR4_16F v)
    {
        return ((uint) & ImpliedObject.x) == (uint) v.x && (uint) & ImpliedObject.z == (uint) v.z;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXVECTOR4_16F &v) const
    public static D3DXINLINE bool operator != (D3DXVECTOR4_16F ImpliedObject, CONST D3DXVECTOR4_16F v)
    {
        return ((uint) & ImpliedObject.x) != (uint) v.x || (uint) & ImpliedObject.z != (uint) v.z;
    }

#endif //__cplusplus
    public D3DXFLOAT16 x = new D3DXFLOAT16();
    public D3DXFLOAT16 y = new D3DXFLOAT16();
    public D3DXFLOAT16 z = new D3DXFLOAT16();
    public D3DXFLOAT16 w = new D3DXFLOAT16();

}



// ===========================================================================
// 
// Matrices
// 
// ===========================================================================
#if __cplusplus
public partial class D3DXMATRIX : D3DMATRIX
{
    public D3DXMATRIX()
    {
    }

    // --------------------------
    // Matrix
    // --------------------------
    public D3DXINLINE D3DXMATRIX(CONST float pf)
    {
#if D3DX_DEBUG
        if (pf == null)
        {
            return;
        }
#endif

// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, pf, sizeof(_D3DMATRIX));
    }

    public D3DXINLINE D3DXMATRIX(CONST D3DMATRIX mat)
    {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
        memcpy(_11, mat, sizeof(_D3DMATRIX));
    }

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


    // access grants
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    float operator ()(uint Row, uint Col);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: float operator ()(uint Row, uint Col) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    float operator ()(uint Row, uint Col);

    // casting operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator float* ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator CONST float* () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    operator CONST float* ();

    // assignment operators
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator *= (CONST D3DXMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator += (CONST D3DXMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator -= (CONST D3DXMATRIX);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator *= (float UnnamedParameter);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator /= (float UnnamedParameter);

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator + () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator + ();
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator - () const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator - ();

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator * (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator * (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator + (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator + (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator - (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator - (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator * (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator * (float UnnamedParameter);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXMATRIX operator / (float) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    D3DXMATRIX operator / (float UnnamedParameter);

    public static D3DXINLINE _D3DMATRIX operator * (float f, CONST _D3DMATRIX mat)
    {
        return struct _D3DMATRIX(f * mat._11, f * mat._12, f * mat._13, f * mat._14, f * mat._21, f * mat._22, f * mat._23, f * mat._24, f * mat._31, f * mat._32, f * mat._33, f * mat._34, f * mat._41, f * mat._42, f * mat._43, f * mat._44);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator == (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator == (CONST D3DXMATRIX);
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: bool operator != (CONST D3DXMATRIX&) const;
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    bool operator != (CONST D3DXMATRIX);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX D3DXMATRIX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX *LPD3DXMATRIX;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DMATRIX D3DXMATRIX, *LPD3DXMATRIX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _D3DMATRIX *LPD3DXMATRIX;
#endif //!__cplusplus


// ---------------------------------------------------------------------------
// Aligned Matrices
// 
// This class helps keep matrices 16-byte aligned as preferred by P4 cpus.
// It aligns matrices on the stack and on the heap or in global scope.
// It does this using __declspec(align(16)) which works on VC7 and on VC 6
// with the processor pack. Unfortunately there is no way to detect the 
// latter so this is turned on only on VC7. On other compilers this is the
// the same as D3DXMATRIX.
// 
// Using this class on a compiler that does not actually do the alignment
// can be dangerous since it will not expose bugs that ignore alignment.
// E.g if an object of this class in inside a struct or class, and some code
// memcopys data in it assuming tight packing. This could break on a compiler
// that eventually start aligning the matrix.
// ---------------------------------------------------------------------------
#if __cplusplus
public partial class _D3DXMATRIXA16 : struct _D3DMATRIX
{
    public _D3DXMATRIXA16()
    {
    }

    // --------------------------
    // Aligned Matrices
    // --------------------------

    public D3DXINLINE _D3DXMATRIXA16(CONST float f)
    {
        this.D3DXMATRIX = f;
    }

    public D3DXINLINE _D3DXMATRIXA16(CONST D3DMATRIX m)
    {
        this.D3DXMATRIX = m;
    }

    public D3DXINLINE _D3DXMATRIXA16(CONST D3DXFLOAT16 f)
    {
        this.D3DXMATRIX = f;
    }

    public D3DXINLINE _D3DXMATRIXA16(float _11, float _12, float _13, float _14, float _21, float _22, float _23, float _24, float _31, float _32, float _33, float _34, float _41, float _42, float _43, float _44)
    {
        this.D3DXMATRIX = new <type missing>(_11, _12, _13, _14, _21, _22, _23, _24, _31, _32, _33, _34, _41, _42, _43, _44);
    }

    // new operators
    public static D3DXINLINE object operator new(size_t s)
    {
    // C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
        byte * p = global::new byte[s + 16];
        if (p != 0)
        {
            byte offset = (byte)(16 - ((UIntPtr)p & 15));
            p += offset;
            p[-1] = offset;
        }
        return p;
    }
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    object operator new[] (size_t UnnamedParameter);

    // delete operators
    public static D3DXINLINE void operator delete(object p)
    {
        if (p)
        {
    // C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
            byte * pb = (byte)p;
            pb -= pb[-1];
            global::delete[] pb;
        }
    }
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    void operator delete[] (object UnnamedParameter); // cast to D3DXMATRIX and delete.

    // assignment operators
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: _D3DXMATRIXA16& operator = (CONST struct _D3DMATRIX&);
//C++ TO C# CONVERTER TODO TASK: The implementation of the following method could not be found:
//    _D3DXMATRIXA16 CopyFrom (CONST _D3DMATRIX);

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DXMATRIXA16 _D3DXMATRIXA16;

#else //!__cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXMATRIX _D3DXMATRIXA16;
#endif //!__cplusplus



// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1300 // VC7
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_ALIGN16 __declspec(align(16))
#define D3DX_ALIGN16
#else
#define D3DX_ALIGN16 // Earlier compiler may not understand this, do nothing.
#endif

// C++ TO C# CONVERTER TODO TASK: The #define macro 'D3DX_ALIGN16' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The #define macro 'D3DX_ALIGN16' was defined in multiple preprocessor conditionals and cannot be replaced in-line:



// ===========================================================================
// 
//    Quaternions
// 
// ===========================================================================
public partial class D3DXQUATERNION
{
#if __cplusplus
    public D3DXQUATERNION()
    {
    }

    // --------------------------
    // Quaternion
    // --------------------------

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

    public D3DXINLINE D3DXQUATERNION(float fx, float fy, float fz, float fw)
    {
        x = fx;
        y = fy;
        z = fz;
        w = fw;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXQUATERNION ImpliedObject)
    {
        return (float) & ImpliedObject.x;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXQUATERNION ImpliedObject)
    {
        return (CONST float) & ImpliedObject.x;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator += (CONST D3DXQUATERNION q)
    {
        x += q.x;
        y += q.y;
        z += q.z;
        w += q.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator -= (CONST D3DXQUATERNION q)
    {
        x -= q.x;
        y -= q.y;
        z -= q.z;
        w -= q.w;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator *= (CONST D3DXQUATERNION q)
    {
        D3DXQuaternionMultiply(this, this, q);
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator *= (float f)
    {
        x *= f;
        y *= f;
        z *= f;
        w *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXQUATERNION operator /= (float f)
    {
        float fInv = 1.0f / f;
        x *= fInv;
        y *= fInv;
        z *= fInv;
        w *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator + () const
    public static D3DXINLINE D3DXQUATERNION operator + (D3DXQUATERNION ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator - () const
    public static D3DXINLINE D3DXQUATERNION operator - (D3DXQUATERNION ImpliedObject)
    {
        return new D3DXQUATERNION(-ImpliedObject.x, -ImpliedObject.y, -ImpliedObject.z, -ImpliedObject.w);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator + (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE D3DXQUATERNION operator + (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return new D3DXQUATERNION(ImpliedObject.x + q.x, ImpliedObject.y + q.y, ImpliedObject.z + q.z, ImpliedObject.w + q.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator - (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE D3DXQUATERNION operator - (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return new D3DXQUATERNION(ImpliedObject.x - q.x, ImpliedObject.y - q.y, ImpliedObject.z - q.z, ImpliedObject.w - q.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator * (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE D3DXQUATERNION operator * (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        D3DXQUATERNION qT = new ImpliedObject.D3DXQUATERNION();
        D3DXQuaternionMultiply(qT, ImpliedObject, q);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return qT;
        return new D3DXQUATERNION(qT);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator * (float f) const
    public static D3DXINLINE D3DXQUATERNION operator * (D3DXQUATERNION ImpliedObject, float f)
    {
        return new D3DXQUATERNION(ImpliedObject.x * f, ImpliedObject.y * f, ImpliedObject.z * f, ImpliedObject.w * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXQUATERNION operator / (float f) const
    public static D3DXINLINE D3DXQUATERNION operator / (D3DXQUATERNION ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXQUATERNION(ImpliedObject.x * fInv, ImpliedObject.y * fInv, ImpliedObject.z * fInv, ImpliedObject.w * fInv);
    }

    public static D3DXINLINE D3DXQUATERNION operator * (float f, CONST D3DXQUATERNION q)
    {
        return new D3DXQUATERNION(f * q.x, f * q.y, f * q.z, f * q.w);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE bool operator == (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return ImpliedObject.x == q.x && ImpliedObject.y == q.y && ImpliedObject.z == q.z && ImpliedObject.w == q.w;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXQUATERNION& q) const
    public static D3DXINLINE bool operator != (D3DXQUATERNION ImpliedObject, CONST D3DXQUATERNION q)
    {
        return ImpliedObject.x != q.x || ImpliedObject.y != q.y || ImpliedObject.z != q.z || ImpliedObject.w != q.w;
    }

#endif //__cplusplus
    public float x;
    public float y;
    public float z;
    public float w;
}


// ===========================================================================
// 
// Planes
// 
// ===========================================================================
public partial class D3DXPLANE
{
#if __cplusplus
    public D3DXPLANE()
    {
    }

    // --------------------------
    // Plane
    // --------------------------

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

    public D3DXINLINE D3DXPLANE(float fa, float fb, float fc, float fd)
    {
        a = fa;
        b = fb;
        c = fc;
        d = fd;
    }

    // casting

    // casting
    public static D3DXINLINE implicit operator float(D3DXPLANE ImpliedObject)
    {
        return (float) & ImpliedObject.a;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST float* () const
    public static D3DXINLINE implicit operator CONST float(D3DXPLANE ImpliedObject)
    {
        return (CONST float) & ImpliedObject.a;
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXPLANE operator *= (float f)
    {
        a *= f;
        b *= f;
        c *= f;
        d *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXPLANE operator /= (float f)
    {
        float fInv = 1.0f / f;
        a *= fInv;
        b *= fInv;
        c *= fInv;
        d *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXPLANE operator + () const
    public static D3DXINLINE D3DXPLANE operator + (D3DXPLANE ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXPLANE operator - () const
    public static D3DXINLINE D3DXPLANE operator - (D3DXPLANE ImpliedObject)
    {
        return new D3DXPLANE(-ImpliedObject.a, -ImpliedObject.b, -ImpliedObject.c, -ImpliedObject.d);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXPLANE operator * (float f) const
    public static D3DXINLINE D3DXPLANE operator * (D3DXPLANE ImpliedObject, float f)
    {
        return new D3DXPLANE(ImpliedObject.a * f, ImpliedObject.b * f, ImpliedObject.c * f, ImpliedObject.d * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXPLANE operator / (float f) const
    public static D3DXINLINE D3DXPLANE operator / (D3DXPLANE ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXPLANE(ImpliedObject.a * fInv, ImpliedObject.b * fInv, ImpliedObject.c * fInv, ImpliedObject.d * fInv);
    }

    public static D3DXINLINE D3DXPLANE operator * (float f, CONST D3DXPLANE p)
    {
        return new D3DXPLANE(f * p.a, f * p.b, f * p.c, f * p.d);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXPLANE& p) const
    public static D3DXINLINE bool operator == (D3DXPLANE ImpliedObject, CONST D3DXPLANE p)
    {
        return ImpliedObject.a == p.a && ImpliedObject.b == p.b && ImpliedObject.c == p.c && ImpliedObject.d == p.d;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXPLANE& p) const
    public static D3DXINLINE bool operator != (D3DXPLANE ImpliedObject, CONST D3DXPLANE p)
    {
        return ImpliedObject.a != p.a || ImpliedObject.b != p.b || ImpliedObject.c != p.c || ImpliedObject.d != p.d;
    }

#endif //__cplusplus
    public float a;
    public float b;
    public float c;
    public float d;
}


// ===========================================================================
// 
// Colors
// 
// ===========================================================================

public partial class D3DXCOLOR
{
#if __cplusplus
    public D3DXCOLOR()
    {
    }

    // --------------------------
    // Color
    // --------------------------

    public D3DXINLINE D3DXCOLOR(uint dw)
    {
        CONST float f = 1.0f / 255.0f;
        r = f * (float)(byte)(dw >> 16);
        g = f * (float)(byte)(dw >> 8);
        b = f * (float)(byte)(dw >> 0);
        a = f * (float)(byte)(dw >> 24);
    }

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

    public D3DXINLINE D3DXCOLOR(CONST D3DCOLORVALUE c)
    {
        r = c.r;
        g = c.g;
        b = c.b;
        a = c.a;
    }

    public D3DXINLINE D3DXCOLOR(float fr, float fg, float fb, float fa)
    {
        r = fr;
        g = fg;
        b = fb;
        a = fa;
    }

    // casting

    // casting
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator uint() const
    public static D3DXINLINE implicit operator uint(D3DXCOLOR ImpliedObject)
    {
        uint dwR = ImpliedObject.r >= 1.0f ? 0xff : (uint)(ImpliedObject.r <= 0.0f ? 0x00 : (uint)(ImpliedObject.r * 255.0f + 0.5f));
        uint dwG = ImpliedObject.g >= 1.0f ? 0xff : (uint)(ImpliedObject.g <= 0.0f ? 0x00 : (uint)(ImpliedObject.g * 255.0f + 0.5f));
        uint dwB = ImpliedObject.b >= 1.0f ? 0xff : (uint)(ImpliedObject.b <= 0.0f ? 0x00 : (uint)(ImpliedObject.b * 255.0f + 0.5f));
        uint dwA = ImpliedObject.a >= 1.0f ? 0xff : (uint)(ImpliedObject.a <= 0.0f ? 0x00 : (uint)(ImpliedObject.a * 255.0f + 0.5f));

        return (dwA << 24) | (dwR << 16) | (dwG << 8) | dwB;
    }

    public static D3DXINLINE D3DXCOLOR.implicit operator float (D3DXCOLOR ImpliedObject)
    {
        return (float) & ImpliedObject.r;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR::operator CONST float * () const
    public static D3DXINLINE D3DXCOLOR.implicit operator CONST float (D3DXCOLOR ImpliedObject)
    {
        return (CONST float) & ImpliedObject.r;
    }

    public static D3DXINLINE D3DXCOLOR.implicit operator D3DCOLORVALUE (D3DXCOLOR ImpliedObject)
    {
        return (D3DCOLORVALUE) & ImpliedObject.r;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR::operator CONST D3DCOLORVALUE * () const
    public static D3DXINLINE D3DXCOLOR.implicit operator CONST D3DCOLORVALUE (D3DXCOLOR ImpliedObject)
    {
        return (CONST D3DCOLORVALUE) & ImpliedObject.r;
    }

    public static D3DXINLINE implicit operator D3DCOLORVALUE & (D3DXCOLOR ImpliedObject)
    {
        return ((D3DCOLORVALUE) & ImpliedObject.r);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE operator CONST D3DCOLORVALUE& () const
    public static D3DXINLINE implicit operator CONST D3DCOLORVALUE & (D3DXCOLOR ImpliedObject)
    {
        return ((CONST D3DCOLORVALUE) & ImpliedObject.r);
    }

    // assignment operators

    // assignment operators
// C++ TO C# CONVERTER TODO TASK: The += operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator += (CONST D3DXCOLOR c)
    {
        r += c.r;
        g += c.g;
        b += c.b;
        a += c.a;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The -= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator -= (CONST D3DXCOLOR c)
    {
        r -= c.r;
        g -= c.g;
        b -= c.b;
        a -= c.a;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The *= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator *= (float f)
    {
        r *= f;
        g *= f;
        b *= f;
        a *= f;
        return this;
    }

// C++ TO C# CONVERTER TODO TASK: The /= operator cannot be overloaded in C#:
    public static D3DXINLINE D3DXCOLOR operator /= (float f)
    {
        float fInv = 1.0f / f;
        r *= fInv;
        g *= fInv;
        b *= fInv;
        a *= fInv;
        return this;
    }

    // unary operators

    // unary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator + () const
    public static D3DXINLINE D3DXCOLOR operator + (D3DXCOLOR ImpliedObject)
    {
        return ImpliedObject;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator - () const
    public static D3DXINLINE D3DXCOLOR operator - (D3DXCOLOR ImpliedObject)
    {
        return new D3DXCOLOR(-ImpliedObject.r, -ImpliedObject.g, -ImpliedObject.b, -ImpliedObject.a);
    }

    // binary operators

    // binary operators
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator + (CONST D3DXCOLOR& c) const
    public static D3DXINLINE D3DXCOLOR operator + (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return new D3DXCOLOR(ImpliedObject.r + c.r, ImpliedObject.g + c.g, ImpliedObject.b + c.b, ImpliedObject.a + c.a);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator - (CONST D3DXCOLOR& c) const
    public static D3DXINLINE D3DXCOLOR operator - (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return new D3DXCOLOR(ImpliedObject.r - c.r, ImpliedObject.g - c.g, ImpliedObject.b - c.b, ImpliedObject.a - c.a);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator * (float f) const
    public static D3DXINLINE D3DXCOLOR operator * (D3DXCOLOR ImpliedObject, float f)
    {
        return new D3DXCOLOR(ImpliedObject.r * f, ImpliedObject.g * f, ImpliedObject.b * f, ImpliedObject.a * f);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE D3DXCOLOR operator / (float f) const
    public static D3DXINLINE D3DXCOLOR operator / (D3DXCOLOR ImpliedObject, float f)
    {
        float fInv = 1.0f / f;
        return new D3DXCOLOR(ImpliedObject.r * fInv, ImpliedObject.g * fInv, ImpliedObject.b * fInv, ImpliedObject.a * fInv);
    }

    public static D3DXINLINE D3DXCOLOR operator * (float f, CONST D3DXCOLOR c)
    {
        return new D3DXCOLOR(f * c.r, f * c.g, f * c.b, f * c.a);
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator == (CONST D3DXCOLOR& c) const
    public static D3DXINLINE bool operator == (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return ImpliedObject.r == c.r && ImpliedObject.g == c.g && ImpliedObject.b == c.b && ImpliedObject.a == c.a;
    }

// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: D3DXINLINE bool operator != (CONST D3DXCOLOR& c) const
    public static D3DXINLINE bool operator != (D3DXCOLOR ImpliedObject, CONST D3DXCOLOR c)
    {
        return ImpliedObject.r != c.r || ImpliedObject.g != c.g || ImpliedObject.b != c.b || ImpliedObject.a != c.a;
    }

#endif //__cplusplus
    public float r;
    public float g;
    public float b;
    public float a;
}



// ===========================================================================
// 
// D3DX math functions:
// 
// NOTE:
//  * All these functions can take the same object as in and out parameters.
// 
//  * Out parameters are typically also returned as return values, so that
//    the output of one function may be used as a parameter to another.
// 
// ===========================================================================

// --------------------------
// Float16
// --------------------------

// non-inline
#if __cplusplus
#endif

// C++ TO C# CONVERTER TODO TASK: The new operator cannot be overloaded in C#:

// C++ TO C# CONVERTER TODO TASK: The delete operator cannot be overloaded in C#: