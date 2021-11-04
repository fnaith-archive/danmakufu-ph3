using System;

/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       d3d8types.h
 *  Content:    Direct3D capabilities include file
 *
 ***************************************************************************/



// include this file content only if compiling for DX8 interfaces
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0800)


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1200
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(push)
#endif
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201) // anonymous unions warning
#if _X86_ || _IA64_
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(4)
#endif

// D3DCOLOR is equivalent to D3DFMT_A8R8G8B8
#if ! D3DCOLOR_DEFINED
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef uint D3DCOLOR;
#define D3DCOLOR_DEFINED
#endif

// maps unsigned 8 bits/channel to D3DCOLOR
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_ARGB(a,r,g,b) ((D3DCOLOR)((((a)&0xff)<<24)|(((r)&0xff)<<16)|(((g)&0xff)<<8)|((b)&0xff)))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_RGBA(r,g,b,a) D3DCOLOR_ARGB(a,r,g,b)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_XRGB(r,g,b) D3DCOLOR_ARGB(0xff,r,g,b)

// maps floating point channels (0.f to 1.f range) to D3DCOLOR
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_COLORVALUE(r,g,b,a) D3DCOLOR_RGBA((DWORD)((r)*255.f),(DWORD)((g)*255.f),(DWORD)((b)*255.f),(DWORD)((a)*255.f))


#if ! D3DVECTOR_DEFINED
public class _D3DVECTOR
{
    public float x;
    public float y;
    public float z;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVECTOR D3DVECTOR;
#define D3DVECTOR_DEFINED
#endif

#if ! D3DCOLORVALUE_DEFINED
public class _D3DCOLORVALUE
{
    public float r;
    public float g;
    public float b;
    public float a;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DCOLORVALUE D3DCOLORVALUE;
#define D3DCOLORVALUE_DEFINED
#endif

#if ! D3DRECT_DEFINED
public class _D3DRECT
{
    public int x1;
    public int y1;
    public int x2;
    public int y2;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DRECT D3DRECT;
#define D3DRECT_DEFINED
#endif

#if ! D3DMATRIX_DEFINED
public class _D3DMATRIX
{
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        struct
//        {
//            float _11, _12, _13, _14;
//            float _21, _22, _23, _24;
//            float _31, _32, _33, _34;
//            float _41, _42, _43, _44;
// 
//        };
//        float m[4][4];
//    };
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DMATRIX D3DMATRIX;
#define D3DMATRIX_DEFINED
#endif

public class _D3DVIEWPORT8
{
    public uint X;
    public uint Y; // Viewport Top left
    public uint Width;
    public uint Height; // Viewport Dimensions
    public float MinZ; // Min/max of clip Volume
    public float MaxZ;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVIEWPORT8 D3DVIEWPORT8;

/*
 * Values for clip fields.
 */

// Max number of user clipping planes, supported in D3D.

// These bits could be ORed together to use with D3DRS_CLIPPLANEENABLE
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE0 (1 << 0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE1 (1 << 1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE2 (1 << 2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE3 (1 << 3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE4 (1 << 4)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCLIPPLANE5 (1 << 5)

// The following bits are used in the ClipUnion and ClipIntersection
// members of the D3DCLIPSTATUS8
// 


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCS_ALL (D3DCS_LEFT | D3DCS_RIGHT | D3DCS_TOP | D3DCS_BOTTOM | D3DCS_FRONT | D3DCS_BACK | D3DCS_PLANE0 | D3DCS_PLANE1 | D3DCS_PLANE2 | D3DCS_PLANE3 | D3DCS_PLANE4 | D3DCS_PLANE5)

public class _D3DCLIPSTATUS8
{
    public uint ClipUnion;
    public uint ClipIntersection;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DCLIPSTATUS8 D3DCLIPSTATUS8;

public class _D3DMATERIAL8
{
    public _D3DCOLORVALUE Diffuse = new _D3DCOLORVALUE(); // Diffuse color RGBA
    public _D3DCOLORVALUE Ambient = new _D3DCOLORVALUE(); // Ambient color RGB
    public _D3DCOLORVALUE Specular = new _D3DCOLORVALUE(); // Specular 'shininess'
    public _D3DCOLORVALUE Emissive = new _D3DCOLORVALUE(); // Emissive color RGB
    public float Power; // Sharpness if specular highlight
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DMATERIAL8 D3DMATERIAL8;

public enum _D3DLIGHTTYPE
{
    D3DLIGHT_POINT = 1,
    D3DLIGHT_SPOT = 2,
    D3DLIGHT_DIRECTIONAL = 3,
    D3DLIGHT_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public class _D3DLIGHT8
{
    public D3DLIGHTTYPE Type = new D3DLIGHTTYPE(); // Type of light source
    public _D3DCOLORVALUE Diffuse = new _D3DCOLORVALUE(); // Diffuse color of light
    public _D3DCOLORVALUE Specular = new _D3DCOLORVALUE(); // Specular color of light
    public _D3DCOLORVALUE Ambient = new _D3DCOLORVALUE(); // Ambient color of light
    public _D3DVECTOR Position = new _D3DVECTOR(); // Position in world space
    public _D3DVECTOR Direction = new _D3DVECTOR(); // Direction in world space
    public float Range; // Cutoff range
    public float Falloff; // Falloff
    public float Attenuation0; // Constant attenuation
    public float Attenuation1; // Linear attenuation
    public float Attenuation2; // Quadratic attenuation
    public float Theta; // Inner angle of spotlight cone
    public float Phi; // Outer angle of spotlight cone
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DLIGHT8 D3DLIGHT8;

/*
 * Options for clearing
 */

/*
 * The following defines the rendering states
 */

public enum _D3DSHADEMODE
{
    D3DSHADE_FLAT = 1,
    D3DSHADE_GOURAUD = 2,
    D3DSHADE_PHONG = 3,
    D3DSHADE_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DFILLMODE
{
    D3DFILL_POINT = 1,
    D3DFILL_WIREFRAME = 2,
    D3DFILL_SOLID = 3,
    D3DFILL_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public class _D3DLINEPATTERN
{
    public ushort wRepeatFactor;
    public ushort wLinePattern;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DLINEPATTERN D3DLINEPATTERN;

public enum _D3DBLEND
{
    D3DBLEND_ZERO = 1,
    D3DBLEND_ONE = 2,
    D3DBLEND_SRCCOLOR = 3,
    D3DBLEND_INVSRCCOLOR = 4,
    D3DBLEND_SRCALPHA = 5,
    D3DBLEND_INVSRCALPHA = 6,
    D3DBLEND_DESTALPHA = 7,
    D3DBLEND_INVDESTALPHA = 8,
    D3DBLEND_DESTCOLOR = 9,
    D3DBLEND_INVDESTCOLOR = 10,
    D3DBLEND_SRCALPHASAT = 11,
    D3DBLEND_BOTHSRCALPHA = 12,
    D3DBLEND_BOTHINVSRCALPHA = 13,
    D3DBLEND_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DBLENDOP
{
    D3DBLENDOP_ADD = 1,
    D3DBLENDOP_SUBTRACT = 2,
    D3DBLENDOP_REVSUBTRACT = 3,
    D3DBLENDOP_MIN = 4,
    D3DBLENDOP_MAX = 5,
    D3DBLENDOP_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DTEXTUREADDRESS
{
    D3DTADDRESS_WRAP = 1,
    D3DTADDRESS_MIRROR = 2,
    D3DTADDRESS_CLAMP = 3,
    D3DTADDRESS_BORDER = 4,
    D3DTADDRESS_MIRRORONCE = 5,
    D3DTADDRESS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DCULL
{
    D3DCULL_NONE = 1,
    D3DCULL_CW = 2,
    D3DCULL_CCW = 3,
    D3DCULL_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DCMPFUNC
{
    D3DCMP_NEVER = 1,
    D3DCMP_LESS = 2,
    D3DCMP_EQUAL = 3,
    D3DCMP_LESSEQUAL = 4,
    D3DCMP_GREATER = 5,
    D3DCMP_NOTEQUAL = 6,
    D3DCMP_GREATEREQUAL = 7,
    D3DCMP_ALWAYS = 8,
    D3DCMP_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DSTENCILOP
{
    D3DSTENCILOP_KEEP = 1,
    D3DSTENCILOP_ZERO = 2,
    D3DSTENCILOP_REPLACE = 3,
    D3DSTENCILOP_INCRSAT = 4,
    D3DSTENCILOP_DECRSAT = 5,
    D3DSTENCILOP_INVERT = 6,
    D3DSTENCILOP_INCR = 7,
    D3DSTENCILOP_DECR = 8,
    D3DSTENCILOP_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DFOGMODE
{
    D3DFOG_NONE = 0,
    D3DFOG_EXP = 1,
    D3DFOG_EXP2 = 2,
    D3DFOG_LINEAR = 3,
    D3DFOG_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DZBUFFERTYPE
{
    D3DZB_FALSE = 0,
    D3DZB_TRUE = 1, // Z buffering
    D3DZB_USEW = 2, // W buffering
    D3DZB_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Primitives supported by draw-primitive API
public enum _D3DPRIMITIVETYPE
{
    D3DPT_POINTLIST = 1,
    D3DPT_LINELIST = 2,
    D3DPT_LINESTRIP = 3,
    D3DPT_TRIANGLELIST = 4,
    D3DPT_TRIANGLESTRIP = 5,
    D3DPT_TRIANGLEFAN = 6,
    D3DPT_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DTRANSFORMSTATETYPE
{
    D3DTS_VIEW = 2,
    D3DTS_PROJECTION = 3,
    D3DTS_TEXTURE0 = 16,
    D3DTS_TEXTURE1 = 17,
    D3DTS_TEXTURE2 = 18,
    D3DTS_TEXTURE3 = 19,
    D3DTS_TEXTURE4 = 20,
    D3DTS_TEXTURE5 = 21,
    D3DTS_TEXTURE6 = 22,
    D3DTS_TEXTURE7 = 23,
    D3DTS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLDMATRIX(index) (D3DTRANSFORMSTATETYPE)(index + 256)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD D3DTS_WORLDMATRIX(0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD1 D3DTS_WORLDMATRIX(1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD2 D3DTS_WORLDMATRIX(2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DTS_WORLD3 D3DTS_WORLDMATRIX(3)

public enum _D3DRENDERSTATETYPE
{
    D3DRS_ZENABLE = 7, // D3DZBUFFERTYPE (or TRUE/FALSE for legacy)
    D3DRS_FILLMODE = 8, // D3DFILLMODE
    D3DRS_SHADEMODE = 9, // D3DSHADEMODE
    D3DRS_LINEPATTERN = 10, // D3DLINEPATTERN
    D3DRS_ZWRITEENABLE = 14, // TRUE to enable z writes
    D3DRS_ALPHATESTENABLE = 15, // TRUE to enable alpha tests
    D3DRS_LASTPIXEL = 16, // TRUE for last-pixel on lines
    D3DRS_SRCBLEND = 19, // D3DBLEND
    D3DRS_DESTBLEND = 20, // D3DBLEND
    D3DRS_CULLMODE = 22, // D3DCULL
    D3DRS_ZFUNC = 23, // D3DCMPFUNC
    D3DRS_ALPHAREF = 24, // D3DFIXED
    D3DRS_ALPHAFUNC = 25, // D3DCMPFUNC
    D3DRS_DITHERENABLE = 26, // TRUE to enable dithering
    D3DRS_ALPHABLENDENABLE = 27, // TRUE to enable alpha blending
    D3DRS_FOGENABLE = 28, // TRUE to enable fog blending
    D3DRS_SPECULARENABLE = 29, // TRUE to enable specular
    D3DRS_ZVISIBLE = 30, // TRUE to enable z checking
    D3DRS_FOGCOLOR = 34, // D3DCOLOR
    D3DRS_FOGTABLEMODE = 35, // D3DFOGMODE
    D3DRS_FOGSTART = 36, // Fog start (for both vertex and pixel fog)
    D3DRS_FOGEND = 37, // Fog end
    D3DRS_FOGDENSITY = 38, // Fog density
    D3DRS_EDGEANTIALIAS = 40, // TRUE to enable edge antialiasing
    D3DRS_ZBIAS = 47, // LONG Z bias
    D3DRS_RANGEFOGENABLE = 48, // Enables range-based fog
    D3DRS_STENCILENABLE = 52, // BOOL enable/disable stenciling
    D3DRS_STENCILFAIL = 53, // D3DSTENCILOP to do if stencil test fails
    D3DRS_STENCILZFAIL = 54, // D3DSTENCILOP to do if stencil test passes and Z test fails
    D3DRS_STENCILPASS = 55, // D3DSTENCILOP to do if both stencil and Z tests pass
    D3DRS_STENCILFUNC = 56, // D3DCMPFUNC fn.  Stencil Test passes if ((ref & mask) stencilfn (stencil & mask)) is true
    D3DRS_STENCILREF = 57, // Reference value used in stencil test
    D3DRS_STENCILMASK = 58, // Mask value used in stencil test
    D3DRS_STENCILWRITEMASK = 59, // Write mask applied to values written to stencil buffer
    D3DRS_TEXTUREFACTOR = 60, // D3DCOLOR used for multi-texture blend
    D3DRS_WRAP0 = 128, // wrap for 1st texture coord. set
    D3DRS_WRAP1 = 129, // wrap for 2nd texture coord. set
    D3DRS_WRAP2 = 130, // wrap for 3rd texture coord. set
    D3DRS_WRAP3 = 131, // wrap for 4th texture coord. set
    D3DRS_WRAP4 = 132, // wrap for 5th texture coord. set
    D3DRS_WRAP5 = 133, // wrap for 6th texture coord. set
    D3DRS_WRAP6 = 134, // wrap for 7th texture coord. set
    D3DRS_WRAP7 = 135, // wrap for 8th texture coord. set
    D3DRS_CLIPPING = 136,
    D3DRS_LIGHTING = 137,
    D3DRS_AMBIENT = 139,
    D3DRS_FOGVERTEXMODE = 140,
    D3DRS_COLORVERTEX = 141,
    D3DRS_LOCALVIEWER = 142,
    D3DRS_NORMALIZENORMALS = 143,
    D3DRS_DIFFUSEMATERIALSOURCE = 145,
    D3DRS_SPECULARMATERIALSOURCE = 146,
    D3DRS_AMBIENTMATERIALSOURCE = 147,
    D3DRS_EMISSIVEMATERIALSOURCE = 148,
    D3DRS_VERTEXBLEND = 151,
    D3DRS_CLIPPLANEENABLE = 152,
    D3DRS_SOFTWAREVERTEXPROCESSING = 153,
    D3DRS_POINTSIZE = 154, // float point size
    D3DRS_POINTSIZE_MIN = 155, // float point size min threshold
    D3DRS_POINTSPRITEENABLE = 156, // BOOL point texture coord control
    D3DRS_POINTSCALEENABLE = 157, // BOOL point size scale enable
    D3DRS_POINTSCALE_A = 158, // float point attenuation A value
    D3DRS_POINTSCALE_B = 159, // float point attenuation B value
    D3DRS_POINTSCALE_C = 160, // float point attenuation C value
    D3DRS_MULTISAMPLEANTIALIAS = 161, // BOOL - set to do FSAA with multisample buffer
    D3DRS_MULTISAMPLEMASK = 162, // DWORD - per-sample enable/disable
    D3DRS_PATCHEDGESTYLE = 163, // Sets whether patch edges will use float style tessellation
    D3DRS_PATCHSEGMENTS = 164, // Number of segments per edge when drawing patches
    D3DRS_DEBUGMONITORTOKEN = 165, // DEBUG ONLY - token to debug monitor
    D3DRS_POINTSIZE_MAX = 166, // float point size max threshold
    D3DRS_INDEXEDVERTEXBLENDENABLE = 167,
    D3DRS_COLORWRITEENABLE = 168, // per-channel write enable
    D3DRS_TWEENFACTOR = 170, // float tween factor
    D3DRS_BLENDOP = 171, // D3DBLENDOP setting
    D3DRS_POSITIONORDER = 172, // NPatch position interpolation order. D3DORDER_LINEAR or D3DORDER_CUBIC (default)
    D3DRS_NORMALORDER = 173, // NPatch normal interpolation order. D3DORDER_LINEAR (default) or D3DORDER_QUADRATIC

    D3DRS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Values for material source
public enum _D3DMATERIALCOLORSOURCE
{
    D3DMCS_MATERIAL = 0, // Color from material is used
    D3DMCS_COLOR1 = 1, // Diffuse vertex color is used
    D3DMCS_COLOR2 = 2, // Specular vertex color is used
    D3DMCS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Bias to apply to the texture coordinate set to apply a wrap to.

/* Flags to construct the WRAP render states */

/* Flags to construct the WRAP render states for 1D thru 4D texture coordinates */

/* Flags to construct D3DRS_COLORWRITEENABLE */
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_RED (1L<<0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_GREEN (1L<<1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_BLUE (1L<<2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLORWRITEENABLE_ALPHA (1L<<3)

/*
 * State enumerants for per-stage texture processing.
 */
public enum _D3DTEXTURESTAGESTATETYPE
{
    D3DTSS_COLOROP = 1, // D3DTEXTUREOP - per-stage blending controls for color channels
    D3DTSS_COLORARG1 = 2, // D3DTA_* (texture arg)
    D3DTSS_COLORARG2 = 3, // D3DTA_* (texture arg)
    D3DTSS_ALPHAOP = 4, // D3DTEXTUREOP - per-stage blending controls for alpha channel
    D3DTSS_ALPHAARG1 = 5, // D3DTA_* (texture arg)
    D3DTSS_ALPHAARG2 = 6, // D3DTA_* (texture arg)
    D3DTSS_BUMPENVMAT00 = 7, // float (bump mapping matrix)
    D3DTSS_BUMPENVMAT01 = 8, // float (bump mapping matrix)
    D3DTSS_BUMPENVMAT10 = 9, // float (bump mapping matrix)
    D3DTSS_BUMPENVMAT11 = 10, // float (bump mapping matrix)
    D3DTSS_TEXCOORDINDEX = 11, // identifies which set of texture coordinates index this texture
    D3DTSS_ADDRESSU = 13, // D3DTEXTUREADDRESS for U coordinate
    D3DTSS_ADDRESSV = 14, // D3DTEXTUREADDRESS for V coordinate
    D3DTSS_BORDERCOLOR = 15, // D3DCOLOR
    D3DTSS_MAGFILTER = 16, // D3DTEXTUREFILTER filter to use for magnification
    D3DTSS_MINFILTER = 17, // D3DTEXTUREFILTER filter to use for minification
    D3DTSS_MIPFILTER = 18, // D3DTEXTUREFILTER filter to use between mipmaps during minification
    D3DTSS_MIPMAPLODBIAS = 19, // float Mipmap LOD bias
    D3DTSS_MAXMIPLEVEL = 20, // DWORD 0..(n-1) LOD index of largest map to use (0 == largest)
    D3DTSS_MAXANISOTROPY = 21, // DWORD maximum anisotropy
    D3DTSS_BUMPENVLSCALE = 22, // float scale for bump map luminance
    D3DTSS_BUMPENVLOFFSET = 23, // float offset for bump map luminance
    D3DTSS_TEXTURETRANSFORMFLAGS = 24, // D3DTEXTURETRANSFORMFLAGS controls texture transform
    D3DTSS_ADDRESSW = 25, // D3DTEXTUREADDRESS for W coordinate
    D3DTSS_COLORARG0 = 26, // D3DTA_* third arg for triadic ops
    D3DTSS_ALPHAARG0 = 27, // D3DTA_* third arg for triadic ops
    D3DTSS_RESULTARG = 28, // D3DTA_* arg for result (CURRENT or TEMP)
    D3DTSS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Values, used with D3DTSS_TEXCOORDINDEX, to specify that the vertex data(position
// and normal in the camera space) should be taken as texture coordinates
// Low 16 bits are used to specify texture coordinate index, to take the WRAP mode from
// 

/*
 * Enumerations for COLOROP and ALPHAOP texture blending operations set in
 * texture processing stage controls in D3DTSS.
 */
public enum _D3DTEXTUREOP
{
    // Control
    D3DTOP_DISABLE = 1, // disables stage
    D3DTOP_SELECTARG1 = 2, // the default
    D3DTOP_SELECTARG2 = 3,

    // Modulate
    D3DTOP_MODULATE = 4, // multiply args together
    D3DTOP_MODULATE2X = 5, // multiply and  1 bit
    D3DTOP_MODULATE4X = 6, // multiply and  2 bits

    // Add
    D3DTOP_ADD = 7, // add arguments together
    D3DTOP_ADDSIGNED = 8, // add with -0.5 bias
    D3DTOP_ADDSIGNED2X = 9, // as above but left  1 bit
    D3DTOP_SUBTRACT = 10, // Arg1 - Arg2, with no saturation
    D3DTOP_ADDSMOOTH = 11, // add 2 args, subtract product
                                        // Arg1 + Arg2 - Arg1*Arg2
                                        // = Arg1 + (1-Arg1)*Arg2

    // Linear alpha blend: Arg1*(Alpha) + Arg2*(1-Alpha)
    D3DTOP_BLENDDIFFUSEALPHA = 12, // iterated alpha
    D3DTOP_BLENDTEXTUREALPHA = 13, // texture alpha
    D3DTOP_BLENDFACTORALPHA = 14, // alpha from D3DRS_TEXTUREFACTOR

    // Linear alpha blend with pre-multiplied arg1 input: Arg1 + Arg2*(1-Alpha)
    D3DTOP_BLENDTEXTUREALPHAPM = 15, // texture alpha
    D3DTOP_BLENDCURRENTALPHA = 16, // by alpha of current color

    // Specular mapping
    D3DTOP_PREMODULATE = 17, // modulate with next texture before use
    D3DTOP_MODULATEALPHA_ADDCOLOR = 18, // Arg1.RGB + Arg1.A*Arg2.RGB
                                            // COLOROP only
    D3DTOP_MODULATECOLOR_ADDALPHA = 19, // Arg1.RGB*Arg2.RGB + Arg1.A
                                            // COLOROP only
    D3DTOP_MODULATEINVALPHA_ADDCOLOR = 20, // (1-Arg1.A)*Arg2.RGB + Arg1.RGB
                                            // COLOROP only
    D3DTOP_MODULATEINVCOLOR_ADDALPHA = 21, // (1-Arg1.RGB)*Arg2.RGB + Arg1.A
                                            // COLOROP only

    // Bump mapping
    D3DTOP_BUMPENVMAP = 22, // per pixel env map perturbation
    D3DTOP_BUMPENVMAPLUMINANCE = 23, // with luminance channel

    // This can do either diffuse or specular bump mapping with correct input.
    // Performs the function (Arg1.R*Arg2.R + Arg1.G*Arg2.G + Arg1.B*Arg2.B)
    // where each component has been scaled and offset to make it signed.
    // The result is replicated into all four (including alpha) channels.
    // This is a valid COLOROP only.
    D3DTOP_DOTPRODUCT3 = 24,

    // Triadic ops
    D3DTOP_MULTIPLYADD = 25, // Arg0 + Arg1*Arg2
    D3DTOP_LERP = 26, // (Arg0)*Arg1 + (1-Arg0)*Arg2

    D3DTOP_FORCE_DWORD = 0x7fffffff
}

/*
 * Values for COLORARG0,1,2, ALPHAARG0,1,2, and RESULTARG texture blending
 * operations set in texture processing stage controls in D3DRENDERSTATE.
 */

// 
// Values for D3DTSS_***FILTER texture stage states
// 
public enum _D3DTEXTUREFILTERTYPE
{
    D3DTEXF_NONE = 0, // filtering disabled (valid for mip filter only)
    D3DTEXF_POINT = 1, // nearest
    D3DTEXF_LINEAR = 2, // linear interpolation
    D3DTEXF_ANISOTROPIC = 3, // anisotropic
    D3DTEXF_FLATCUBIC = 4, // cubic
    D3DTEXF_GAUSSIANCUBIC = 5, // different cubic kernel
    D3DTEXF_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

/* Bits for Flags in ProcessVertices call */

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPV_DONOTCOPYDATA (1 << 0)

// -------------------------------------------------------------------

// Flexible vertex format bits
// 





// ---------------------------------------------------------------------
// Vertex Shaders
// 

/*

Vertex Shader Declaration

The declaration portion of a vertex shader defines the static external
interface of the shader.  The information in the declaration includes:

- Assignments of vertex shader input registers to data streams.  These
assignments bind a specific vertex register to a single component within a
vertex stream.  A vertex stream element is identified by a byte offset
within the stream and a type.  The type specifies the arithmetic data type
plus the dimensionality (1, 2, 3, or 4 values).  Stream data which is
less than 4 values are always expanded out to 4 values with zero or more
0.F values and one 1.F value.

- Assignment of vertex shader input registers to implicit data from the
primitive tessellator.  This controls the loading of vertex data which is
not loaded from a stream, but rather is generated during primitive
tessellation prior to the vertex shader.

- Loading data into the constant memory at the time a shader is set as the
current shader.  Each token specifies values for one or more contiguous 4
DWORD constant registers.  This allows the shader to update an arbitrary
subset of the constant memory, overwriting the device state (which
contains the current values of the constant memory).  Note that these
values can be subsequently overwritten (between DrawPrimitive calls)
during the time a shader is bound to a device via the
SetVertexShaderConstant method.


Declaration arrays are single-dimensional arrays of DWORDs composed of
multiple tokens each of which is one or more DWORDs.  The single-DWORD
token value 0xFFFFFFFF is a special token used to indicate the end of the
declaration array.  The single DWORD token value 0x00000000 is a NOP token
with is ignored during the declaration parsing.  Note that 0x00000000 is a
valid value for DWORDs following the first DWORD for multiple word tokens.

[31:29] TokenType
    0x0 - NOP (requires all DWORD bits to be zero)
    0x1 - stream selector
    0x2 - stream data definition (map to vertex input memory)
    0x3 - vertex input memory from tessellator
    0x4 - constant memory from shader
    0x5 - extension
    0x6 - reserved
    0x7 - end-of-array (requires all DWORD bits to be 1)

NOP Token (single DWORD token)
    [31:29] 0x0
    [28:00] 0x0

Stream Selector (single DWORD token)
    [31:29] 0x1
    [28]    indicates whether this is a tessellator stream
    [27:04] 0x0
    [03:00] stream selector (0..15)

Stream Data Definition (single DWORD token)
    Vertex Input Register Load
      [31:29] 0x2
      [28]    0x0
      [27:20] 0x0
      [19:16] type (dimensionality and data type)
      [15:04] 0x0
      [03:00] vertex register address (0..15)
    Data Skip (no register load)
      [31:29] 0x2
      [28]    0x1
      [27:20] 0x0
      [19:16] count of DWORDS to skip over (0..15)
      [15:00] 0x0
    Vertex Input Memory from Tessellator Data (single DWORD token)
      [31:29] 0x3
      [28]    indicates whether data is normals or u/v
      [27:24] 0x0
      [23:20] vertex register address (0..15)
      [19:16] type (dimensionality)
      [15:04] 0x0
      [03:00] vertex register address (0..15)

Constant Memory from Shader (multiple DWORD token)
    [31:29] 0x4
    [28:25] count of 4*DWORD constants to load (0..15)
    [24:07] 0x0
    [06:00] constant memory address (0..95)

Extension Token (single or multiple DWORD token)
    [31:29] 0x5
    [28:24] count of additional DWORDs in token (0..31)
    [23:00] extension-specific information

End-of-array token (single DWORD token)
    [31:29] 0x7
    [28:00] 0x1fffffff

The stream selector token must be immediately followed by a contiguous set of stream data definition tokens.  This token sequence fully defines that stream, including the set of elements within the stream, the order in which the elements appear, the type of each element, and the vertex register into which to load an element.
Streams are allowed to include data which is not loaded into a vertex register, thus allowing data which is not used for this shader to exist in the vertex stream.  This skipped data is defined only by a count of DWORDs to skip over, since the type information is irrelevant.
The token sequence:
Stream Select: stream=0
Stream Data Definition (Load): type=FLOAT3; register=3
Stream Data Definition (Load): type=FLOAT3; register=4
Stream Data Definition (Skip): count=2
Stream Data Definition (Load): type=FLOAT2; register=7

defines stream zero to consist of 4 elements, 3 of which are loaded into registers and the fourth skipped over.  Register 3 is loaded with the first three DWORDs in each vertex interpreted as FLOAT data.  Register 4 is loaded with the 4th, 5th, and 6th DWORDs interpreted as FLOAT data.  The next two DWORDs (7th and 8th) are skipped over and not loaded into any vertex input register.   Register 7 is loaded with the 9th and 10th DWORDS interpreted as FLOAT data.
Placing of tokens other than NOPs between the Stream Selector and Stream Data Definition tokens is disallowed.

*/

public enum _D3DVSD_TOKENTYPE
{
    D3DVSD_TOKEN_NOP = 0, // NOP or extension
    D3DVSD_TOKEN_STREAM, // stream selector
    D3DVSD_TOKEN_STREAMDATA, // stream data definition (map to vertex input memory)
    D3DVSD_TOKEN_TESSELLATOR, // vertex input memory from tessellator
    D3DVSD_TOKEN_CONSTMEM, // constant memory from shader
    D3DVSD_TOKEN_EXT, // extension
    D3DVSD_TOKEN_END = 7, // end-of-array (requires all DWORD bits to be 1)
    D3DVSD_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_TOKENTYPEMASK (7 << D3DVSD_TOKENTYPESHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAMNUMBERMASK (0xF << D3DVSD_STREAMNUMBERSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_DATALOADTYPEMASK (0x1 << D3DVSD_DATALOADTYPESHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_DATATYPEMASK (0xF << D3DVSD_DATATYPESHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_SKIPCOUNTMASK (0xF << D3DVSD_SKIPCOUNTSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_VERTEXREGMASK (0x1F << D3DVSD_VERTEXREGSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_VERTEXREGINMASK (0xF << D3DVSD_VERTEXREGINSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONSTCOUNTMASK (0xF << D3DVSD_CONSTCOUNTSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONSTADDRESSMASK (0x7F << D3DVSD_CONSTADDRESSSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONSTRSMASK (0x1FFF << D3DVSD_CONSTRSSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_EXTCOUNTMASK (0x1F << D3DVSD_EXTCOUNTSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_EXTINFOMASK (0xFFFFFF << D3DVSD_EXTINFOSHIFT)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_MAKETOKENTYPE(tokenType) ((tokenType << D3DVSD_TOKENTYPESHIFT) & D3DVSD_TOKENTYPEMASK)

// macros for generation of CreateVertexShader Declaration token array

// Set current stream
// _StreamNumber [0..(MaxStreams-1)] stream to get data from
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAM( _StreamNumber ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAM) | (_StreamNumber))

// Set tessellator stream
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAMTESSMASK (1 << D3DVSD_STREAMTESSSHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_STREAM_TESS( ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAM) | (D3DVSD_STREAMTESSMASK))

// bind single vertex register to vertex element from vertex stream
// 
// _VertexRegister [0..15] address of the vertex register
// _Type [D3DVSDT_*] dimensionality and arithmetic data type

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_REG( _VertexRegister, _Type ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAMDATA) | ((_Type) << D3DVSD_DATATYPESHIFT) | (_VertexRegister))

// Skip _DWORDCount DWORDs in vertex
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_SKIP( _DWORDCount ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_STREAMDATA) | 0x10000000 | ((_DWORDCount) << D3DVSD_SKIPCOUNTSHIFT))

// load data into vertex shader constant memory
// 
// _ConstantAddress [0..95] - address of constant array to begin filling data
// _Count [0..15] - number of constant vectors to load (4 DWORDs each)
// followed by 4*_Count DWORDS of data
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_CONST( _ConstantAddress, _Count ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_CONSTMEM) | ((_Count) << D3DVSD_CONSTCOUNTSHIFT) | (_ConstantAddress))

// enable tessellator generated normals
// 
// _VertexRegisterIn  [0..15] address of vertex register whose input stream
//                            will be used in normal computation
// _VertexRegisterOut [0..15] address of vertex register to output the normal to
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_TESSNORMAL( _VertexRegisterIn, _VertexRegisterOut ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_TESSELLATOR) | ((_VertexRegisterIn) << D3DVSD_VERTEXREGINSHIFT) | ((0x02) << D3DVSD_DATATYPESHIFT) | (_VertexRegisterOut))

// enable tessellator generated surface parameters
// 
// _VertexRegister [0..15] address of vertex register to output parameters
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_TESSUV( _VertexRegister ) (D3DVSD_MAKETOKENTYPE(D3DVSD_TOKEN_TESSELLATOR) | 0x10000000 | ((0x01) << D3DVSD_DATATYPESHIFT) | (_VertexRegister))

// Generates END token
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_END() 0xFFFFFFFF

// Generates NOP token
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVSD_NOP() 0x00000000

// bit declarations for _Type fields
                                    // Input is in D3DCOLOR format (ARGB) expanded to (R, G, B, A)

// assignments of vertex input registers for fixed function vertex shader
// 

// Maximum supported number of texture coordinate sets


// 
// Instruction Token Bit Definitions
// 

public enum _D3DSHADER_INSTRUCTION_OPCODE_TYPE
{
    D3DSIO_NOP = 0, // PS/VS
    D3DSIO_MOV, // PS/VS
    D3DSIO_ADD, // PS/VS
    D3DSIO_SUB, // PS
    D3DSIO_MAD, // PS/VS
    D3DSIO_MUL, // PS/VS
    D3DSIO_RCP, // VS
    D3DSIO_RSQ, // VS
    D3DSIO_DP3, // PS/VS
    D3DSIO_DP4, // PS/VS
    D3DSIO_MIN, // VS
    D3DSIO_MAX, // VS
    D3DSIO_SLT, // VS
    D3DSIO_SGE, // VS
    D3DSIO_EXP, // VS
    D3DSIO_LOG, // VS
    D3DSIO_LIT, // VS
    D3DSIO_DST, // VS
    D3DSIO_LRP, // PS
    D3DSIO_FRC, // VS
    D3DSIO_M4x4, // VS
    D3DSIO_M4x3, // VS
    D3DSIO_M3x4, // VS
    D3DSIO_M3x3, // VS
    D3DSIO_M3x2, // VS

    D3DSIO_TEXCOORD = 64, // PS
    D3DSIO_TEXKILL, // PS
    D3DSIO_TEX, // PS
    D3DSIO_TEXBEM, // PS
    D3DSIO_TEXBEML, // PS
    D3DSIO_TEXREG2AR, // PS
    D3DSIO_TEXREG2GB, // PS
    D3DSIO_TEXM3x2PAD, // PS
    D3DSIO_TEXM3x2TEX, // PS
    D3DSIO_TEXM3x3PAD, // PS
    D3DSIO_TEXM3x3TEX, // PS
    D3DSIO_TEXM3x3DIFF, // PS
    D3DSIO_TEXM3x3SPEC, // PS
    D3DSIO_TEXM3x3VSPEC, // PS
    D3DSIO_EXPP, // VS
    D3DSIO_LOGP, // VS
    D3DSIO_CND, // PS
    D3DSIO_DEF, // PS
    D3DSIO_TEXREG2RGB, // PS
    D3DSIO_TEXDP3TEX, // PS
    D3DSIO_TEXM3x2DEPTH, // PS
    D3DSIO_TEXDP3, // PS
    D3DSIO_TEXM3x3, // PS
    D3DSIO_TEXDEPTH, // PS
    D3DSIO_CMP, // PS
    D3DSIO_BEM, // PS

    D3DSIO_PHASE = 0xFFFD,
    D3DSIO_COMMENT = 0xFFFE,
    D3DSIO_END = 0xFFFF,

    D3DSIO_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// 
// Co-Issue Instruction Modifier - if set then this instruction is to be
// issued in parallel with the previous instruction(s) for which this bit
// is not set.
// 

// 
// Parameter Token Bit Definitions
// 

// destination parameter write mask

// destination parameter modifiers

public enum _D3DSHADER_PARAM_DSTMOD_TYPE
{
    D3DSPDM_NONE = 0 << DefineConstants.D3DSP_DSTMOD_SHIFT, // nop
    D3DSPDM_SATURATE = 1 << DefineConstants.D3DSP_DSTMOD_SHIFT, // clamp to 0. to 1. range
    D3DSPDM_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// destination parameter 

// destination/source parameter register type

public enum _D3DSHADER_PARAM_REGISTER_TYPE
{
    D3DSPR_TEMP = 0 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Temporary Register File
    D3DSPR_INPUT = 1 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Input Register File
    D3DSPR_CONST = 2 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Constant Register File
    D3DSPR_ADDR = 3 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Address Register (VS)
    D3DSPR_TEXTURE = 3 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Texture Register File (PS)
    D3DSPR_RASTOUT = 4 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Rasterizer Register File
    D3DSPR_ATTROUT = 5 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Attribute Output Register File
    D3DSPR_TEXCRDOUT = 6 << DefineConstants.D3DSP_REGTYPE_SHIFT, // Texture Coordinate Output Register File
    D3DSPR_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Register offsets in the Rasterizer Register File
// 
public enum _D3DVS_RASTOUT_OFFSETS
{
    D3DSRO_POSITION = 0,
    D3DSRO_FOG,
    D3DSRO_POINT_SIZE,
    D3DSRO_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Source operand addressing modes

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_ADDRESSMODE_MASK (1 << D3DVS_ADDRESSMODE_SHIFT)

public enum _D3DVS_ADDRESSMODE_TYPE
{
    D3DVS_ADDRMODE_ABSOLUTE = (0 << DefineConstants.D3DVS_ADDRESSMODE_SHIFT),
    D3DVS_ADDRMODE_RELATIVE = (1 << DefineConstants.D3DVS_ADDRESSMODE_SHIFT), // Relative to register A0
    D3DVS_ADDRMODE_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Source operand swizzle definitions
// 

// The following bits define where to take component X from:

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_X (0 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_Y (1 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_Z (2 << D3DVS_SWIZZLE_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_X_W (3 << D3DVS_SWIZZLE_SHIFT)

// The following bits define where to take component Y from:

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_X (0 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_Y (1 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_Z (2 << (D3DVS_SWIZZLE_SHIFT + 2))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Y_W (3 << (D3DVS_SWIZZLE_SHIFT + 2))

// The following bits define where to take component Z from:

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_X (0 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_Y (1 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_Z (2 << (D3DVS_SWIZZLE_SHIFT + 4))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_Z_W (3 << (D3DVS_SWIZZLE_SHIFT + 4))

// The following bits define where to take component W from:

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_X (0 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_Y (1 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_Z (2 << (D3DVS_SWIZZLE_SHIFT + 6))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_W_W (3 << (D3DVS_SWIZZLE_SHIFT + 6))

// Value when there is no swizzle (X is taken from X, Y is taken from Y,
// Z is taken from Z, W is taken from W
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_NOSWIZZLE (D3DVS_X_X | D3DVS_Y_Y | D3DVS_Z_Z | D3DVS_W_W)

// source parameter swizzle

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_NOSWIZZLE ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )

// pixel-shader swizzle ops
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATERED ( (0 << (D3DSP_SWIZZLE_SHIFT + 0)) | (0 << (D3DSP_SWIZZLE_SHIFT + 2)) | (0 << (D3DSP_SWIZZLE_SHIFT + 4)) | (0 << (D3DSP_SWIZZLE_SHIFT + 6)) )

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEGREEN ( (1 << (D3DSP_SWIZZLE_SHIFT + 0)) | (1 << (D3DSP_SWIZZLE_SHIFT + 2)) | (1 << (D3DSP_SWIZZLE_SHIFT + 4)) | (1 << (D3DSP_SWIZZLE_SHIFT + 6)) )

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEBLUE ( (2 << (D3DSP_SWIZZLE_SHIFT + 0)) | (2 << (D3DSP_SWIZZLE_SHIFT + 2)) | (2 << (D3DSP_SWIZZLE_SHIFT + 4)) | (2 << (D3DSP_SWIZZLE_SHIFT + 6)) )

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSP_REPLICATEALPHA ( (3 << (D3DSP_SWIZZLE_SHIFT + 0)) | (3 << (D3DSP_SWIZZLE_SHIFT + 2)) | (3 << (D3DSP_SWIZZLE_SHIFT + 4)) | (3 << (D3DSP_SWIZZLE_SHIFT + 6)) )

// source parameter modifiers

public enum _D3DSHADER_PARAM_SRCMOD_TYPE
{
    D3DSPSM_NONE = 0 << DefineConstants.D3DSP_SRCMOD_SHIFT, // nop
    D3DSPSM_NEG = 1 << DefineConstants.D3DSP_SRCMOD_SHIFT, // negate
    D3DSPSM_BIAS = 2 << DefineConstants.D3DSP_SRCMOD_SHIFT, // bias
    D3DSPSM_BIASNEG = 3 << DefineConstants.D3DSP_SRCMOD_SHIFT, // bias and negate
    D3DSPSM_SIGN = 4 << DefineConstants.D3DSP_SRCMOD_SHIFT, // sign
    D3DSPSM_SIGNNEG = 5 << DefineConstants.D3DSP_SRCMOD_SHIFT, // sign and negate
    D3DSPSM_COMP = 6 << DefineConstants.D3DSP_SRCMOD_SHIFT, // complement
    D3DSPSM_X2 = 7 << DefineConstants.D3DSP_SRCMOD_SHIFT, // *2
    D3DSPSM_X2NEG = 8 << DefineConstants.D3DSP_SRCMOD_SHIFT, // *2 and negate
    D3DSPSM_DZ = 9 << DefineConstants.D3DSP_SRCMOD_SHIFT, // divide through by z component
    D3DSPSM_DW = 10 << DefineConstants.D3DSP_SRCMOD_SHIFT, // divide through by w component
    D3DSPSM_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// pixel shader version token
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS_VERSION(_Major,_Minor) (0xFFFF0000|((_Major)<<8)|(_Minor))

// vertex shader version token
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_VERSION(_Major,_Minor) (0xFFFE0000|((_Major)<<8)|(_Minor))

// extract major/minor from version cap
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_VERSION_MAJOR(_Version) (((_Version)>>8)&0xFF)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_VERSION_MINOR(_Version) (((_Version)>>0)&0xFF)

// destination/source parameter register type
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMMENT(_DWordSize) ((((_DWordSize)<<D3DSI_COMMENTSIZE_SHIFT)&D3DSI_COMMENTSIZE_MASK)|D3DSIO_COMMENT)

// pixel/vertex shader end token
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS_END() 0x0000FFFF
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS_END() 0x0000FFFF

// ---------------------------------------------------------------------

// High order surfaces
// 
public enum _D3DBASISTYPE
{
   D3DBASIS_BEZIER = 0,
   D3DBASIS_BSPLINE = 1,
   D3DBASIS_INTERPOLATE = 2,
   D3DBASIS_FORCE_DWORD = 0x7fffffff
}

public enum _D3DORDERTYPE
{
   D3DORDER_LINEAR = 1,
   D3DORDER_QUADRATIC = 2,
   D3DORDER_CUBIC = 3,
   D3DORDER_QUINTIC = 5,
   D3DORDER_FORCE_DWORD = 0x7fffffff
}

public enum _D3DPATCHEDGESTYLE
{
   D3DPATCHEDGE_DISCRETE = 0,
   D3DPATCHEDGE_CONTINUOUS = 1,
   D3DPATCHEDGE_FORCE_DWORD = 0x7fffffff
}

public enum _D3DSTATEBLOCKTYPE
{
    D3DSBT_ALL = 1, // capture all state
    D3DSBT_PIXELSTATE = 2, // capture pixel state
    D3DSBT_VERTEXSTATE = 3, // capture vertex state
    D3DSBT_FORCE_DWORD = 0x7fffffff
}

// The D3DVERTEXBLENDFLAGS type is used with D3DRS_VERTEXBLEND state.
// 
public enum _D3DVERTEXBLENDFLAGS
{
    D3DVBF_DISABLE = 0, // Disable vertex blending
    D3DVBF_1WEIGHTS = 1, // 2 matrix blending
    D3DVBF_2WEIGHTS = 2, // 3 matrix blending
    D3DVBF_3WEIGHTS = 3, // 4 matrix blending
    D3DVBF_TWEENING = 255, // blending using D3DRS_TWEENFACTOR
    D3DVBF_0WEIGHTS = 256, // one matrix is used with weight 1.0
    D3DVBF_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public enum _D3DTEXTURETRANSFORMFLAGS
{
    D3DTTFF_DISABLE = 0, // texture coordinates are passed directly
    D3DTTFF_COUNT1 = 1, // rasterizer should expect 1-D texture coords
    D3DTTFF_COUNT2 = 2, // rasterizer should expect 2-D texture coords
    D3DTTFF_COUNT3 = 3, // rasterizer should expect 3-D texture coords
    D3DTTFF_COUNT4 = 4, // rasterizer should expect 4-D texture coords
    D3DTTFF_PROJECTED = 256, // texcoords to be divided by COUNTth element
    D3DTTFF_FORCE_DWORD = 0x7fffffff
}

// Macros to set texture coordinate format bits in the FVF id


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE3(CoordIndex) (D3DFVF_TEXTUREFORMAT3 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE2(CoordIndex) (D3DFVF_TEXTUREFORMAT2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE4(CoordIndex) (D3DFVF_TEXTUREFORMAT4 << (CoordIndex*2 + 16))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFVF_TEXCOORDSIZE1(CoordIndex) (D3DFVF_TEXTUREFORMAT1 << (CoordIndex*2 + 16))


// ---------------------------------------------------------------------

/* Direct3D8 Device types */
public enum _D3DDEVTYPE
{
    D3DDEVTYPE_HAL = 1,
    D3DDEVTYPE_REF = 2,
    D3DDEVTYPE_SW = 3,

    D3DDEVTYPE_FORCE_DWORD = 0x7fffffff
}

/* Multi-Sample buffer types */
public enum _D3DMULTISAMPLE_TYPE
{
    D3DMULTISAMPLE_NONE = 0,
    D3DMULTISAMPLE_2_SAMPLES = 2,
    D3DMULTISAMPLE_3_SAMPLES = 3,
    D3DMULTISAMPLE_4_SAMPLES = 4,
    D3DMULTISAMPLE_5_SAMPLES = 5,
    D3DMULTISAMPLE_6_SAMPLES = 6,
    D3DMULTISAMPLE_7_SAMPLES = 7,
    D3DMULTISAMPLE_8_SAMPLES = 8,
    D3DMULTISAMPLE_9_SAMPLES = 9,
    D3DMULTISAMPLE_10_SAMPLES = 10,
    D3DMULTISAMPLE_11_SAMPLES = 11,
    D3DMULTISAMPLE_12_SAMPLES = 12,
    D3DMULTISAMPLE_13_SAMPLES = 13,
    D3DMULTISAMPLE_14_SAMPLES = 14,
    D3DMULTISAMPLE_15_SAMPLES = 15,
    D3DMULTISAMPLE_16_SAMPLES = 16,

    D3DMULTISAMPLE_FORCE_DWORD = 0x7fffffff
}

/* Formats
 * Most of these names have the following convention:
 *      A = Alpha
 *      R = Red
 *      G = Green
 *      B = Blue
 *      X = Unused Bits
 *      P = Palette
 *      L = Luminance
 *      U = dU coordinate for BumpMap
 *      V = dV coordinate for BumpMap
 *      S = Stencil
 *      D = Depth (e.g. Z or W buffer)
 *
 *      Further, the order of the pieces are from MSB first; hence
 *      D3DFMT_A8L8 indicates that the high byte of this two byte
 *      format is alpha.
 *
 *      D16 indicates:
 *           - An integer 16-bit value.
 *           - An app-lockable surface.
 *
 *      All Depth/Stencil formats except D3DFMT_D16_LOCKABLE indicate:
 *          - no particular bit ordering per pixel, and
 *          - are not app lockable, and
 *          - the driver is allowed to consume more than the indicated
 *            number of bits per Depth channel (but not Stencil channel).
 */
#if ! MAKEFOURCC
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
    #define MAKEFOURCC
#endif // defined(MAKEFOURCC)


public enum _D3DFORMAT
{
    D3DFMT_UNKNOWN = 0,

    D3DFMT_R8G8B8 = 20,
    D3DFMT_A8R8G8B8 = 21,
    D3DFMT_X8R8G8B8 = 22,
    D3DFMT_R5G6B5 = 23,
    D3DFMT_X1R5G5B5 = 24,
    D3DFMT_A1R5G5B5 = 25,
    D3DFMT_A4R4G4B4 = 26,
    D3DFMT_R3G3B2 = 27,
    D3DFMT_A8 = 28,
    D3DFMT_A8R3G3B2 = 29,
    D3DFMT_X4R4G4B4 = 30,
    D3DFMT_A2B10G10R10 = 31,
    D3DFMT_G16R16 = 34,

    D3DFMT_A8P8 = 40,
    D3DFMT_P8 = 41,

    D3DFMT_L8 = 50,
    D3DFMT_A8L8 = 51,
    D3DFMT_A4L4 = 52,

    D3DFMT_V8U8 = 60,
    D3DFMT_L6V5U5 = 61,
    D3DFMT_X8L8V8U8 = 62,
    D3DFMT_Q8W8V8U8 = 63,
    D3DFMT_V16U16 = 64,
    D3DFMT_W11V11U10 = 65,
    D3DFMT_A2W10V10U10 = 67,

    D3DFMT_UYVY = ((uint)(byte)('U') | ((uint)(byte)('Y') << 8) | ((uint)(byte)('V') << 16) | ((uint)(byte)('Y') << 24)),
    D3DFMT_YUY2 = ((uint)(byte)('Y') | ((uint)(byte)('U') << 8) | ((uint)(byte)('Y') << 16) | ((uint)(byte)('2') << 24)),
    D3DFMT_DXT1 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('1') << 24)),
    D3DFMT_DXT2 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('2') << 24)),
    D3DFMT_DXT3 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('3') << 24)),
    D3DFMT_DXT4 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('4') << 24)),
    D3DFMT_DXT5 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('5') << 24)),

    D3DFMT_D16_LOCKABLE = 70,
    D3DFMT_D32 = 71,
    D3DFMT_D15S1 = 73,
    D3DFMT_D24S8 = 75,
    D3DFMT_D16 = 80,
    D3DFMT_D24X8 = 77,
    D3DFMT_D24X4S4 = 79,


    D3DFMT_VERTEXDATA = 100,
    D3DFMT_INDEX16 = 101,
    D3DFMT_INDEX32 = 102,

    D3DFMT_FORCE_DWORD = 0x7fffffff
}

/* Display Modes */
public class _D3DDISPLAYMODE
{
    public uint Width;
    public uint Height;
    public uint RefreshRate;
    public D3DFORMAT Format = new D3DFORMAT();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDISPLAYMODE D3DDISPLAYMODE;

/* Creation Parameters */
public class _D3DDEVICE_CREATION_PARAMETERS
{
    public uint AdapterOrdinal;
    public D3DDEVTYPE DeviceType = new D3DDEVTYPE();
    public IntPtr hFocusWindow;
    public uint BehaviorFlags;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVICE_CREATION_PARAMETERS D3DDEVICE_CREATION_PARAMETERS;


/* SwapEffects */
public enum _D3DSWAPEFFECT
{
    D3DSWAPEFFECT_DISCARD = 1,
    D3DSWAPEFFECT_FLIP = 2,
    D3DSWAPEFFECT_COPY = 3,
    D3DSWAPEFFECT_COPY_VSYNC = 4,

    D3DSWAPEFFECT_FORCE_DWORD = 0x7fffffff
}

/* Pool types */
public enum _D3DPOOL
{
    D3DPOOL_DEFAULT = 0,
    D3DPOOL_MANAGED = 1,
    D3DPOOL_SYSTEMMEM = 2,
    D3DPOOL_SCRATCH = 3,

    D3DPOOL_FORCE_DWORD = 0x7fffffff
}


/* RefreshRate pre-defines */


/* Resize Optional Parameters */
public class _D3DPRESENT_PARAMETERS_
{
    public uint BackBufferWidth;
    public uint BackBufferHeight;
    public D3DFORMAT BackBufferFormat = new D3DFORMAT();
    public uint BackBufferCount;

    public D3DMULTISAMPLE_TYPE MultiSampleType = new D3DMULTISAMPLE_TYPE();

    public D3DSWAPEFFECT SwapEffect = new D3DSWAPEFFECT();
    public IntPtr hDeviceWindow;
    public bool Windowed;
    public bool EnableAutoDepthStencil;
    public D3DFORMAT AutoDepthStencilFormat = new D3DFORMAT();
    public uint Flags;

    /* Following elements must be zero for Windowed mode */
    public uint FullScreen_RefreshRateInHz;
    public uint FullScreen_PresentationInterval;

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DPRESENT_PARAMETERS_ D3DPRESENT_PARAMETERS;

// Values for D3DPRESENT_PARAMETERS.Flags



/* Gamma Ramp: Same as DX7 */

public class _D3DGAMMARAMP
{
    public ushort[] red = new ushort[256];
    public ushort[] green = new ushort[256];
    public ushort[] blue = new ushort[256];
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DGAMMARAMP D3DGAMMARAMP;

/* Back buffer types */
public enum _D3DBACKBUFFER_TYPE
{
    D3DBACKBUFFER_TYPE_MONO = 0,
    D3DBACKBUFFER_TYPE_LEFT = 1,
    D3DBACKBUFFER_TYPE_RIGHT = 2,

    D3DBACKBUFFER_TYPE_FORCE_DWORD = 0x7fffffff
}


/* Types */
public enum _D3DRESOURCETYPE
{
    D3DRTYPE_SURFACE = 1,
    D3DRTYPE_VOLUME = 2,
    D3DRTYPE_TEXTURE = 3,
    D3DRTYPE_VOLUMETEXTURE = 4,
    D3DRTYPE_CUBETEXTURE = 5,
    D3DRTYPE_VERTEXBUFFER = 6,
    D3DRTYPE_INDEXBUFFER = 7,


    D3DRTYPE_FORCE_DWORD = 0x7fffffff
}

/* Usages */
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_RENDERTARGET (0x00000001L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DEPTHSTENCIL (0x00000002L)

/* Usages for Vertex/Index buffers */
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_WRITEONLY (0x00000008L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_SOFTWAREPROCESSING (0x00000010L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DONOTCLIP (0x00000020L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_POINTS (0x00000040L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_RTPATCHES (0x00000080L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_NPATCHES (0x00000100L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DYNAMIC (0x00000200L)









/* CubeMap Face identifiers */
public enum _D3DCUBEMAP_FACES
{
    D3DCUBEMAP_FACE_POSITIVE_X = 0,
    D3DCUBEMAP_FACE_NEGATIVE_X = 1,
    D3DCUBEMAP_FACE_POSITIVE_Y = 2,
    D3DCUBEMAP_FACE_NEGATIVE_Y = 3,
    D3DCUBEMAP_FACE_POSITIVE_Z = 4,
    D3DCUBEMAP_FACE_NEGATIVE_Z = 5,

    D3DCUBEMAP_FACE_FORCE_DWORD = 0x7fffffff
}


/* Lock flags */








/* Vertex Buffer Description */
public class _D3DVERTEXBUFFER_DESC
{
    public D3DFORMAT Format = new D3DFORMAT();
    public D3DRESOURCETYPE Type = new D3DRESOURCETYPE();
    public uint Usage;
    public D3DPOOL Pool = new D3DPOOL();
    public uint Size;

    public uint FVF;

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVERTEXBUFFER_DESC D3DVERTEXBUFFER_DESC;

/* Index Buffer Description */
public class _D3DINDEXBUFFER_DESC
{
    public D3DFORMAT Format = new D3DFORMAT();
    public D3DRESOURCETYPE Type = new D3DRESOURCETYPE();
    public uint Usage;
    public D3DPOOL Pool = new D3DPOOL();
    public uint Size;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DINDEXBUFFER_DESC D3DINDEXBUFFER_DESC;


/* Surface Description */
public class _D3DSURFACE_DESC
{
    public D3DFORMAT Format = new D3DFORMAT();
    public D3DRESOURCETYPE Type = new D3DRESOURCETYPE();
    public uint Usage;
    public D3DPOOL Pool = new D3DPOOL();
    public uint Size;

    public D3DMULTISAMPLE_TYPE MultiSampleType = new D3DMULTISAMPLE_TYPE();
    public uint Width;
    public uint Height;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DSURFACE_DESC D3DSURFACE_DESC;

public class _D3DVOLUME_DESC
{
    public D3DFORMAT Format = new D3DFORMAT();
    public D3DRESOURCETYPE Type = new D3DRESOURCETYPE();
    public uint Usage;
    public D3DPOOL Pool = new D3DPOOL();
    public uint Size;

    public uint Width;
    public uint Height;
    public uint Depth;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVOLUME_DESC D3DVOLUME_DESC;

/* Structure for LockRect */
public class _D3DLOCKED_RECT
{
    public int Pitch;
    public object pBits;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DLOCKED_RECT D3DLOCKED_RECT;

/* Structures for LockBox */
public class _D3DBOX
{
    public uint Left;
    public uint Top;
    public uint Right;
    public uint Bottom;
    public uint Front;
    public uint Back;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DBOX D3DBOX;

public class _D3DLOCKED_BOX
{
    public int RowPitch;
    public int SlicePitch;
    public object pBits;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DLOCKED_BOX D3DLOCKED_BOX;

/* Structures for LockRange */
public class _D3DRANGE
{
    public uint Offset;
    public uint Size;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DRANGE D3DRANGE;

/* Structures for high order primitives */
public class _D3DRECTPATCH_INFO
{
    public uint StartVertexOffsetWidth;
    public uint StartVertexOffsetHeight;
    public uint Width;
    public uint Height;
    public uint Stride;
    public D3DBASISTYPE Basis = new D3DBASISTYPE();
    public D3DORDERTYPE Order = new D3DORDERTYPE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DRECTPATCH_INFO D3DRECTPATCH_INFO;

public class _D3DTRIPATCH_INFO
{
    public uint StartVertexOffset;
    public uint NumVertices;
    public D3DBASISTYPE Basis = new D3DBASISTYPE();
    public D3DORDERTYPE Order = new D3DORDERTYPE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DTRIPATCH_INFO D3DTRIPATCH_INFO;

/* Adapter Identifier */

public class _D3DADAPTER_IDENTIFIER8
{
    public string Driver = new string(new char[DefineConstants.MAX_DEVICE_IDENTIFIER_STRING]);
    public string Description = new string(new char[DefineConstants.MAX_DEVICE_IDENTIFIER_STRING]);

#if _WIN32
    public LARGE_INTEGER DriverVersion = new LARGE_INTEGER(); // Defined for 32 bit components
#else
    public uint DriverVersionLowPart; // Defined for 16 bit driver components
    public uint DriverVersionHighPart;
#endif

    public uint VendorId;
    public uint DeviceId;
    public uint SubSysId;
    public uint Revision;

    public GUID DeviceIdentifier = new GUID();

    public uint WHQLLevel;

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DADAPTER_IDENTIFIER8 D3DADAPTER_IDENTIFIER8;


/* Raster Status structure returned by GetRasterStatus */
public class _D3DRASTER_STATUS
{
    public bool InVBlank;
    public uint ScanLine;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DRASTER_STATUS D3DRASTER_STATUS;



/* Debug monitor tokens (DEBUG only)

   Note that if D3DRS_DEBUGMONITORTOKEN is set, the call is treated as
   passing a token to the debug monitor.  For example, if, after passing
   D3DDMT_ENABLE/DISABLE to D3DRS_DEBUGMONITORTOKEN other token values
   are passed in, the enabled/disabled state of the debug
   monitor will still persist.

   The debug monitor defaults to enabled.

   Calling GetRenderState on D3DRS_DEBUGMONITORTOKEN is not of any use.
*/
public enum _D3DDEBUGMONITORTOKENS
{
    D3DDMT_ENABLE = 0, // enable debug monitor
    D3DDMT_DISABLE = 1, // disable debug monitor
    D3DDMT_FORCE_DWORD = 0x7fffffff
}

// GetInfo IDs


public class _D3DRESOURCESTATS
{
// Data collected since last Present()
    public bool bThrashing; // indicates if thrashing
    public uint ApproxBytesDownloaded; // Approximate number of bytes downloaded by resource manager
    public uint NumEvicts; // number of objects evicted
    public uint NumVidCreates; // number of objects created in video memory
    public uint LastPri; // priority of last object evicted
    public uint NumUsed; // number of objects set to the device
    public uint NumUsedInVidMem; // number of objects set to the device, which are already in video memory
// Persistent data
    public uint WorkingSet; // number of objects in video memory
    public uint WorkingSetBytes; // number of bytes in video memory
    public uint TotalManaged; // total number of managed objects
    public uint TotalBytes; // total number of bytes of managed objects
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DRESOURCESTATS D3DRESOURCESTATS;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DRTYPECOUNT (D3DRTYPE_INDEXBUFFER+1)

public class _D3DDEVINFO_RESOURCEMANAGER
{
    _D3DRESOURCESTATS stats[(D3DRTYPE_INDEXBUFFER + 1)];
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_RESOURCEMANAGER D3DDEVINFO_RESOURCEMANAGER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_RESOURCEMANAGER *LPD3DDEVINFO_RESOURCEMANAGER;

public class _D3DDEVINFO_D3DVERTEXSTATS
{
    public uint NumRenderedTriangles; // total number of triangles that are not clipped in this frame
    public uint NumExtraClippingTriangles; // Number of new triangles generated by clipping
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3DVERTEXSTATS D3DDEVINFO_D3DVERTEXSTATS;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3DVERTEXSTATS *LPD3DDEVINFO_D3DVERTEXSTATS;


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack()
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1200
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(pop)
#else
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(default:4201)
#endif

#endif // (DIRECT3D_VERSION >= 0x0800)

