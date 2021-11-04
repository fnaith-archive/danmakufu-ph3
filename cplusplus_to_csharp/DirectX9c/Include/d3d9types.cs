using System;

/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       d3d9types.h
 *  Content:    Direct3D capabilities include file
 *
 ***************************************************************************/



// include this file content only if compiling for DX9 interfaces
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0900)


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1200
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(push)
#endif
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201) // anonymous unions warning
#if _X86_ || _IA64
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

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_XYUV(y,u,v) D3DCOLOR_ARGB(0xff,y,u,v)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCOLOR_AYUV(a,y,u,v) D3DCOLOR_ARGB(a,y,u,v)

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

public class _D3DVIEWPORT9
{
    public uint X;
    public uint Y; // Viewport Top left
    public uint Width;
    public uint Height; // Viewport Dimensions
    public float MinZ; // Min/max of clip Volume
    public float MaxZ;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVIEWPORT9 D3DVIEWPORT9;

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
// members of the D3DCLIPSTATUS9
// 


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DCS_ALL (D3DCS_LEFT | D3DCS_RIGHT | D3DCS_TOP | D3DCS_BOTTOM | D3DCS_FRONT | D3DCS_BACK | D3DCS_PLANE0 | D3DCS_PLANE1 | D3DCS_PLANE2 | D3DCS_PLANE3 | D3DCS_PLANE4 | D3DCS_PLANE5)

public class _D3DCLIPSTATUS9
{
    public uint ClipUnion;
    public uint ClipIntersection;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DCLIPSTATUS9 D3DCLIPSTATUS9;

public class _D3DMATERIAL9
{
    public _D3DCOLORVALUE Diffuse = new _D3DCOLORVALUE(); // Diffuse color RGBA
    public _D3DCOLORVALUE Ambient = new _D3DCOLORVALUE(); // Ambient color RGB
    public _D3DCOLORVALUE Specular = new _D3DCOLORVALUE(); // Specular 'shininess'
    public _D3DCOLORVALUE Emissive = new _D3DCOLORVALUE(); // Emissive color RGB
    public float Power; // Sharpness if specular highlight
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DMATERIAL9 D3DMATERIAL9;

public enum _D3DLIGHTTYPE
{
    D3DLIGHT_POINT = 1,
    D3DLIGHT_SPOT = 2,
    D3DLIGHT_DIRECTIONAL = 3,
    D3DLIGHT_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

public class _D3DLIGHT9
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
// typedef _D3DLIGHT9 D3DLIGHT9;

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
    D3DBLEND_BLENDFACTOR = 14, // Only supported if D3DPBLENDCAPS_BLENDFACTOR is on
    D3DBLEND_INVBLENDFACTOR = 15, // Only supported if D3DPBLENDCAPS_BLENDFACTOR is on
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
    D3DRS_FOGCOLOR = 34, // D3DCOLOR
    D3DRS_FOGTABLEMODE = 35, // D3DFOGMODE
    D3DRS_FOGSTART = 36, // Fog start (for both vertex and pixel fog)
    D3DRS_FOGEND = 37, // Fog end
    D3DRS_FOGDENSITY = 38, // Fog density
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
    D3DRS_DEBUGMONITORTOKEN = 165, // DEBUG ONLY - token to debug monitor
    D3DRS_POINTSIZE_MAX = 166, // float point size max threshold
    D3DRS_INDEXEDVERTEXBLENDENABLE = 167,
    D3DRS_COLORWRITEENABLE = 168, // per-channel write enable
    D3DRS_TWEENFACTOR = 170, // float tween factor
    D3DRS_BLENDOP = 171, // D3DBLENDOP setting
    D3DRS_POSITIONDEGREE = 172, // NPatch position interpolation degree. D3DDEGREE_LINEAR or D3DDEGREE_CUBIC (default)
    D3DRS_NORMALDEGREE = 173, // NPatch normal interpolation degree. D3DDEGREE_LINEAR (default) or D3DDEGREE_QUADRATIC
    D3DRS_SCISSORTESTENABLE = 174,
    D3DRS_SLOPESCALEDEPTHBIAS = 175,
    D3DRS_ANTIALIASEDLINEENABLE = 176,
    D3DRS_MINTESSELLATIONLEVEL = 178,
    D3DRS_MAXTESSELLATIONLEVEL = 179,
    D3DRS_ADAPTIVETESS_X = 180,
    D3DRS_ADAPTIVETESS_Y = 181,
    D3DRS_ADAPTIVETESS_Z = 182,
    D3DRS_ADAPTIVETESS_W = 183,
    D3DRS_ENABLEADAPTIVETESSELLATION = 184,
    D3DRS_TWOSIDEDSTENCILMODE = 185, // BOOL enable/disable 2 sided stenciling
    D3DRS_CCW_STENCILFAIL = 186, // D3DSTENCILOP to do if ccw stencil test fails
    D3DRS_CCW_STENCILZFAIL = 187, // D3DSTENCILOP to do if ccw stencil test passes and Z test fails
    D3DRS_CCW_STENCILPASS = 188, // D3DSTENCILOP to do if both ccw stencil and Z tests pass
    D3DRS_CCW_STENCILFUNC = 189, // D3DCMPFUNC fn.  ccw Stencil Test passes if ((ref & mask) stencilfn (stencil & mask)) is true
    D3DRS_COLORWRITEENABLE1 = 190, // Additional ColorWriteEnables for the devices that support D3DPMISCCAPS_INDEPENDENTWRITEMASKS
    D3DRS_COLORWRITEENABLE2 = 191, // Additional ColorWriteEnables for the devices that support D3DPMISCCAPS_INDEPENDENTWRITEMASKS
    D3DRS_COLORWRITEENABLE3 = 192, // Additional ColorWriteEnables for the devices that support D3DPMISCCAPS_INDEPENDENTWRITEMASKS
    D3DRS_BLENDFACTOR = 193, // D3DCOLOR used for a constant blend factor during alpha blending for devices that support D3DPBLENDCAPS_BLENDFACTOR
    D3DRS_SRGBWRITEENABLE = 194, // Enable rendertarget writes to be DE-linearized to SRGB (for formats that expose D3DUSAGE_QUERY_SRGBWRITE)
    D3DRS_DEPTHBIAS = 195,
    D3DRS_WRAP8 = 198, // Additional wrap states for vs_3_0+ attributes with D3DDECLUSAGE_TEXCOORD
    D3DRS_WRAP9 = 199,
    D3DRS_WRAP10 = 200,
    D3DRS_WRAP11 = 201,
    D3DRS_WRAP12 = 202,
    D3DRS_WRAP13 = 203,
    D3DRS_WRAP14 = 204,
    D3DRS_WRAP15 = 205,
    D3DRS_SEPARATEALPHABLENDENABLE = 206, // TRUE to enable a separate blending function for the alpha channel
    D3DRS_SRCBLENDALPHA = 207, // SRC blend factor for the alpha channel when D3DRS_SEPARATEDESTALPHAENABLE is TRUE
    D3DRS_DESTBLENDALPHA = 208, // DST blend factor for the alpha channel when D3DRS_SEPARATEDESTALPHAENABLE is TRUE
    D3DRS_BLENDOPALPHA = 209, // Blending operation for the alpha channel when D3DRS_SEPARATEDESTALPHAENABLE is TRUE


    D3DRS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Maximum number of simultaneous render targets D3D supports

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
 * State enumerants for per-stage processing of fixed function pixel processing
 * Two of these affect fixed function vertex processing as well: TEXTURETRANSFORMFLAGS and TEXCOORDINDEX.
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
    D3DTSS_BUMPENVLSCALE = 22, // float scale for bump map luminance
    D3DTSS_BUMPENVLOFFSET = 23, // float offset for bump map luminance
    D3DTSS_TEXTURETRANSFORMFLAGS = 24, // D3DTEXTURETRANSFORMFLAGS controls texture transform
    D3DTSS_COLORARG0 = 26, // D3DTA_* third arg for triadic ops
    D3DTSS_ALPHAARG0 = 27, // D3DTA_* third arg for triadic ops
    D3DTSS_RESULTARG = 28, // D3DTA_* arg for result (CURRENT or TEMP)
    D3DTSS_CONSTANT = 32, // Per-stage constant D3DTA_CONSTANT


    D3DTSS_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

/*
 * State enumerants for per-sampler texture processing.
 */
public enum _D3DSAMPLERSTATETYPE
{
    D3DSAMP_ADDRESSU = 1, // D3DTEXTUREADDRESS for U coordinate
    D3DSAMP_ADDRESSV = 2, // D3DTEXTUREADDRESS for V coordinate
    D3DSAMP_ADDRESSW = 3, // D3DTEXTUREADDRESS for W coordinate
    D3DSAMP_BORDERCOLOR = 4, // D3DCOLOR
    D3DSAMP_MAGFILTER = 5, // D3DTEXTUREFILTER filter to use for magnification
    D3DSAMP_MINFILTER = 6, // D3DTEXTUREFILTER filter to use for minification
    D3DSAMP_MIPFILTER = 7, // D3DTEXTUREFILTER filter to use between mipmaps during minification
    D3DSAMP_MIPMAPLODBIAS = 8, // float Mipmap LOD bias
    D3DSAMP_MAXMIPLEVEL = 9, // DWORD 0..(n-1) LOD index of largest map to use (0 == largest)
    D3DSAMP_MAXANISOTROPY = 10, // DWORD maximum anisotropy
    D3DSAMP_SRGBTEXTURE = 11, /* Default = 0 (which means Gamma 1.0,
                                   no correction required.) else correct for
                                   Gamma = 2.2 */
    D3DSAMP_ELEMENTINDEX = 12, /* When multi-element texture is assigned to sampler, this
                                    indicates which element index to use.  Default = 0.  */
    D3DSAMP_DMAPOFFSET = 13, /* Offset in vertices in the pre-sampled displacement map.
                                    Only valid for D3DDMAPSAMPLER sampler  */
    D3DSAMP_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

/* Special sampler which is used in the tesselator */

// Samplers used in vertex shaders
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER0 (D3DDMAPSAMPLER+1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER1 (D3DDMAPSAMPLER+2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER2 (D3DDMAPSAMPLER+3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVERTEXTEXTURESAMPLER3 (D3DDMAPSAMPLER+4)

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
// Values for D3DSAMP_***FILTER texture stage states
// 
public enum _D3DTEXTUREFILTERTYPE
{
    D3DTEXF_NONE = 0, // filtering disabled (valid for mip filter only)
    D3DTEXF_POINT = 1, // nearest
    D3DTEXF_LINEAR = 2, // linear interpolation
    D3DTEXF_ANISOTROPIC = 3, // anisotropic
    D3DTEXF_PYRAMIDALQUAD = 6, // 4-sample tent
    D3DTEXF_GAUSSIANQUAD = 7, // 4-sample gaussian
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

// Vertex shader declaration

// Vertex element semantics
// 
public enum _D3DDECLUSAGE
{
    D3DDECLUSAGE_POSITION = 0,
    D3DDECLUSAGE_BLENDWEIGHT, // 1
    D3DDECLUSAGE_BLENDINDICES, // 2
    D3DDECLUSAGE_NORMAL, // 3
    D3DDECLUSAGE_PSIZE, // 4
    D3DDECLUSAGE_TEXCOORD, // 5
    D3DDECLUSAGE_TANGENT, // 6
    D3DDECLUSAGE_BINORMAL, // 7
    D3DDECLUSAGE_TESSFACTOR, // 8
    D3DDECLUSAGE_POSITIONT, // 9
    D3DDECLUSAGE_COLOR, // 10
    D3DDECLUSAGE_FOG, // 11
    D3DDECLUSAGE_DEPTH, // 12
    D3DDECLUSAGE_SAMPLE // 13
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAXD3DDECLUSAGE D3DDECLUSAGE_SAMPLE

public enum _D3DDECLMETHOD
{
    D3DDECLMETHOD_DEFAULT = 0,
    D3DDECLMETHOD_PARTIALU,
    D3DDECLMETHOD_PARTIALV,
    D3DDECLMETHOD_CROSSUV, // Normal
    D3DDECLMETHOD_UV,
    D3DDECLMETHOD_LOOKUP, // Lookup a displacement map
    D3DDECLMETHOD_LOOKUPPRESAMPLED // Lookup a pre-sampled displacement map
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAXD3DDECLMETHOD D3DDECLMETHOD_LOOKUPPRESAMPLED

// Declarations for _Type fields
// 
public enum _D3DDECLTYPE
{
    D3DDECLTYPE_FLOAT1 = 0, // 1D float expanded to (value, 0., 0., 1.)
    D3DDECLTYPE_FLOAT2 = 1, // 2D float expanded to (value, value, 0., 1.)
    D3DDECLTYPE_FLOAT3 = 2, // 3D float expanded to (value, value, value, 1.)
    D3DDECLTYPE_FLOAT4 = 3, // 4D float
    D3DDECLTYPE_D3DCOLOR = 4, // 4D packed unsigned bytes mapped to 0. to 1. range
                                 // Input is in D3DCOLOR format (ARGB) expanded to (R, G, B, A)
    D3DDECLTYPE_UBYTE4 = 5, // 4D unsigned byte
    D3DDECLTYPE_SHORT2 = 6, // 2D signed short expanded to (value, value, 0., 1.)
    D3DDECLTYPE_SHORT4 = 7, // 4D signed short

// The following types are valid only with vertex shaders >= 2.0


    D3DDECLTYPE_UBYTE4N = 8, // Each of 4 bytes is normalized by dividing to 255.0
    D3DDECLTYPE_SHORT2N = 9, // 2D signed short normalized (v[0]/32767.0,v[1]/32767.0,0,1)
    D3DDECLTYPE_SHORT4N = 10, // 4D signed short normalized (v[0]/32767.0,v[1]/32767.0,v[2]/32767.0,v[3]/32767.0)
    D3DDECLTYPE_USHORT2N = 11, // 2D unsigned short normalized (v[0]/65535.0,v[1]/65535.0,0,1)
    D3DDECLTYPE_USHORT4N = 12, // 4D unsigned short normalized (v[0]/65535.0,v[1]/65535.0,v[2]/65535.0,v[3]/65535.0)
    D3DDECLTYPE_UDEC3 = 13, // 3D unsigned 10 10 10 format expanded to (value, value, value, 1)
    D3DDECLTYPE_DEC3N = 14, // 3D signed 10 10 10 format normalized and expanded to (v[0]/511.0, v[1]/511.0, v[2]/511.0, 1)
    D3DDECLTYPE_FLOAT16_2 = 15, // Two 16-bit floating point values, expanded to (value, value, 0, 1)
    D3DDECLTYPE_FLOAT16_4 = 16, // Four 16-bit floating point values
    D3DDECLTYPE_UNUSED = 17 // When the type field in a decl is unused.
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAXD3DDECLTYPE D3DDECLTYPE_UNUSED

public class _D3DVERTEXELEMENT9
{
    public ushort Stream; // Stream index
    public ushort Offset; // Offset in the stream in bytes
    public byte Type; // Data type
    public byte Method; // Processing method
    public byte Usage; // Semantics
    public byte UsageIndex; // Semantic index
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVERTEXELEMENT9 D3DVERTEXELEMENT9;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVERTEXELEMENT9 *LPD3DVERTEXELEMENT9;

// This is used to initialize the last vertex element in a vertex declaration
// array
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DDECL_END() {0xFF,0,D3DDECLTYPE_UNUSED,0,0,0}

// Maximum supported number of texture coordinate sets

// ---------------------------------------------------------------------
// Values for IDirect3DDevice9::SetStreamSourceFreq's Setting parameter
// ---------------------------------------------------------------------
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTREAMSOURCE_INDEXEDDATA (1<<30)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSTREAMSOURCE_INSTANCEDATA (2<<30)



// ---------------------------------------------------------------------
// 
// The internal format of Pixel Shader (PS) & Vertex Shader (VS)
// Instruction Tokens is defined in the Direct3D Device Driver Kit
// 
// ---------------------------------------------------------------------

// 
// Instruction Token Bit Definitions
// 


public enum _D3DSHADER_INSTRUCTION_OPCODE_TYPE
{
    D3DSIO_NOP = 0,
    D3DSIO_MOV,
    D3DSIO_ADD,
    D3DSIO_SUB,
    D3DSIO_MAD,
    D3DSIO_MUL,
    D3DSIO_RCP,
    D3DSIO_RSQ,
    D3DSIO_DP3,
    D3DSIO_DP4,
    D3DSIO_MIN,
    D3DSIO_MAX,
    D3DSIO_SLT,
    D3DSIO_SGE,
    D3DSIO_EXP,
    D3DSIO_LOG,
    D3DSIO_LIT,
    D3DSIO_DST,
    D3DSIO_LRP,
    D3DSIO_FRC,
    D3DSIO_M4x4,
    D3DSIO_M4x3,
    D3DSIO_M3x4,
    D3DSIO_M3x3,
    D3DSIO_M3x2,
    D3DSIO_CALL,
    D3DSIO_CALLNZ,
    D3DSIO_LOOP,
    D3DSIO_RET,
    D3DSIO_ENDLOOP,
    D3DSIO_LABEL,
    D3DSIO_DCL,
    D3DSIO_POW,
    D3DSIO_CRS,
    D3DSIO_SGN,
    D3DSIO_ABS,
    D3DSIO_NRM,
    D3DSIO_SINCOS,
    D3DSIO_REP,
    D3DSIO_ENDREP,
    D3DSIO_IF,
    D3DSIO_IFC,
    D3DSIO_ELSE,
    D3DSIO_ENDIF,
    D3DSIO_BREAK,
    D3DSIO_BREAKC,
    D3DSIO_MOVA,
    D3DSIO_DEFB,
    D3DSIO_DEFI,

    D3DSIO_TEXCOORD = 64,
    D3DSIO_TEXKILL,
    D3DSIO_TEX,
    D3DSIO_TEXBEM,
    D3DSIO_TEXBEML,
    D3DSIO_TEXREG2AR,
    D3DSIO_TEXREG2GB,
    D3DSIO_TEXM3x2PAD,
    D3DSIO_TEXM3x2TEX,
    D3DSIO_TEXM3x3PAD,
    D3DSIO_TEXM3x3TEX,
    D3DSIO_RESERVED0,
    D3DSIO_TEXM3x3SPEC,
    D3DSIO_TEXM3x3VSPEC,
    D3DSIO_EXPP,
    D3DSIO_LOGP,
    D3DSIO_CND,
    D3DSIO_DEF,
    D3DSIO_TEXREG2RGB,
    D3DSIO_TEXDP3TEX,
    D3DSIO_TEXM3x2DEPTH,
    D3DSIO_TEXDP3,
    D3DSIO_TEXM3x3,
    D3DSIO_TEXDEPTH,
    D3DSIO_CMP,
    D3DSIO_BEM,
    D3DSIO_DP2ADD,
    D3DSIO_DSX,
    D3DSIO_DSY,
    D3DSIO_TEXLDD,
    D3DSIO_SETP,
    D3DSIO_TEXLDL,
    D3DSIO_BREAKP,

    D3DSIO_PHASE = 0xFFFD,
    D3DSIO_COMMENT = 0xFFFE,
    D3DSIO_END = 0xFFFF,

    D3DSIO_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// ---------------------------------------------------------------------
// Use these constants with D3DSIO_SINCOS macro as SRC2, SRC3
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSINCOSCONST1 -1.5500992e-006f, -2.1701389e-005f, 0.0026041667f, 0.00026041668f
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSINCOSCONST2 -0.020833334f, -0.12500000f, 1.0f, 0.50000000f

// ---------------------------------------------------------------------
// Co-Issue Instruction Modifier - if set then this instruction is to be
// issued in parallel with the previous instruction(s) for which this bit
// is not set.
// 

// ---------------------------------------------------------------------
// Opcode specific controls


// ps_2_0 texld controls
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSI_TEXLD_PROJECT (0x01 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSI_TEXLD_BIAS (0x02 << D3DSP_OPCODESPECIFICCONTROL_SHIFT)

// Comparison for dynamic conditional instruction opcodes (i.e. if, breakc)
public enum _D3DSHADER_COMPARISON
{
                         // < = >
    D3DSPC_RESERVED0 = 0, // 0 0 0
    D3DSPC_GT = 1, // 0 0 1
    D3DSPC_EQ = 2, // 0 1 0
    D3DSPC_GE = 3, // 0 1 1
    D3DSPC_LT = 4, // 1 0 0
    D3DSPC_NE = 5, // 1 0 1
    D3DSPC_LE = 6, // 1 1 0
    D3DSPC_RESERVED1 = 7 // 1 1 1
}

// Comparison is part of instruction opcode token:
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMPARISON_SHIFT D3DSP_OPCODESPECIFICCONTROL_SHIFT
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_COMPARISON_MASK (0x7<<D3DSHADER_COMPARISON_SHIFT)

// ---------------------------------------------------------------------
// Predication flags on instruction token
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_INSTRUCTION_PREDICATED (0x1 << 28)

// ---------------------------------------------------------------------
// DCL Info Token Controls

// For dcl info tokens requiring a semantic (usage + index)


// DCL pixel shader sampler info token.

public enum _D3DSAMPLER_TEXTURE_TYPE
{
    D3DSTT_UNKNOWN = 0 << DefineConstants.D3DSP_TEXTURETYPE_SHIFT, // uninitialized value
    D3DSTT_2D = 2 << DefineConstants.D3DSP_TEXTURETYPE_SHIFT, // dcl_2d s# (for declaring a 2-D texture)
    D3DSTT_CUBE = 3 << DefineConstants.D3DSP_TEXTURETYPE_SHIFT, // dcl_cube s# (for declaring a cube texture)
    D3DSTT_VOLUME = 4 << DefineConstants.D3DSP_TEXTURETYPE_SHIFT, // dcl_volume s# (for declaring a volume texture)
    D3DSTT_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// ---------------------------------------------------------------------
// Parameter Token Bit Definitions
// 

// destination parameter write mask

// destination parameter modifiers

// Bit masks for destination parameter modifiers
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_NONE (0<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_SATURATE (1<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_PARTIALPRECISION (2<<D3DSP_DSTMOD_SHIFT)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSPDM_MSAMPCENTROID (4<<D3DSP_DSTMOD_SHIFT)
                                                                //      When the pixel center is not covered, sample
                                                                //      attribute or compute gradients/LOD
                                                                //      using multisample "centroid" location.
                                                                //      "Centroid" is some location within the covered
                                                                //      region of the pixel.

// destination parameter 

// destination/source parameter register type

public enum _D3DSHADER_PARAM_REGISTER_TYPE
{
    D3DSPR_TEMP = 0, // Temporary Register File
    D3DSPR_INPUT = 1, // Input Register File
    D3DSPR_CONST = 2, // Constant Register File
    D3DSPR_ADDR = 3, // Address Register (VS)
    D3DSPR_TEXTURE = 3, // Texture Register File (PS)
    D3DSPR_RASTOUT = 4, // Rasterizer Register File
    D3DSPR_ATTROUT = 5, // Attribute Output Register File
    D3DSPR_TEXCRDOUT = 6, // Texture Coordinate Output Register File
    D3DSPR_OUTPUT = 6, // Output register file for VS3.0+
    D3DSPR_CONSTINT = 7, // Constant Integer Vector Register File
    D3DSPR_COLOROUT = 8, // Color Output Register File
    D3DSPR_DEPTHOUT = 9, // Depth Output Register File
    D3DSPR_SAMPLER = 10, // Sampler State Register File
    D3DSPR_CONST2 = 11, // Constant Register File  2048 - 4095
    D3DSPR_CONST3 = 12, // Constant Register File  4096 - 6143
    D3DSPR_CONST4 = 13, // Constant Register File  6144 - 8191
    D3DSPR_CONSTBOOL = 14, // Constant Boolean register file
    D3DSPR_LOOP = 15, // Loop counter register file
    D3DSPR_TEMPFLOAT16 = 16, // 16-bit float temp register file
    D3DSPR_MISCTYPE = 17, // Miscellaneous (single) registers.
    D3DSPR_LABEL = 18, // Label
    D3DSPR_PREDICATE = 19, // Predicate register
    D3DSPR_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// The miscellaneous register file (D3DSPR_MISCTYPES)
// contains register types for which there is only ever one
// register (i.e. the register # is not needed).
// Rather than use up additional register types for such
// registers, they are defined
// as particular offsets into the misc. register file:
public enum _D3DSHADER_MISCTYPE_OFFSETS
{
    D3DSMO_POSITION = 0, // Input position x,y,z,rhw (PS)
    D3DSMO_FACE = 1 // Floating point primitive area (PS)
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
    D3DVS_ADDRMODE_RELATIVE = (1 << DefineConstants.D3DVS_ADDRESSMODE_SHIFT),
    D3DVS_ADDRMODE_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DSHADER_ADDRESSMODE_MASK (1 << D3DSHADER_ADDRESSMODE_SHIFT)

public enum _D3DSHADER_ADDRESSMODE_TYPE
{
    D3DSHADER_ADDRMODE_ABSOLUTE = (0 << DefineConstants.D3DSHADER_ADDRESSMODE_SHIFT),
    D3DSHADER_ADDRMODE_RELATIVE = (1 << DefineConstants.D3DSHADER_ADDRESSMODE_SHIFT),
    D3DSHADER_ADDRMODE_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
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
    D3DSPSM_ABS = 11 << DefineConstants.D3DSP_SRCMOD_SHIFT, // abs()
    D3DSPSM_ABSNEG = 12 << DefineConstants.D3DSP_SRCMOD_SHIFT, // -abs()
    D3DSPSM_NOT = 13 << DefineConstants.D3DSP_SRCMOD_SHIFT, // for predicate register: "!p0"
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
   D3DBASIS_CATMULL_ROM = 2, // In D3D8 this used to be D3DBASIS_INTERPOLATE
   D3DBASIS_FORCE_DWORD = 0x7fffffff
}

public enum _D3DDEGREETYPE
{
   D3DDEGREE_LINEAR = 1,
   D3DDEGREE_QUADRATIC = 2,
   D3DDEGREE_CUBIC = 3,
   D3DDEGREE_QUINTIC = 5,
   D3DDEGREE_FORCE_DWORD = 0x7fffffff
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

/* Direct3D9 Device types */
public enum _D3DDEVTYPE
{
    D3DDEVTYPE_HAL = 1,
    D3DDEVTYPE_REF = 2,
    D3DDEVTYPE_SW = 3,

    D3DDEVTYPE_NULLREF = 4,

    D3DDEVTYPE_FORCE_DWORD = 0x7fffffff
}

/* Multi-Sample buffer types */
public enum _D3DMULTISAMPLE_TYPE
{
    D3DMULTISAMPLE_NONE = 0,
    D3DMULTISAMPLE_NONMASKABLE = 1,
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
 *      C = Computed from other channels (typically on certain read operations)
 *
 *      Further, the order of the pieces are from MSB first; hence
 *      D3DFMT_A8L8 indicates that the high byte of this two byte
 *      format is alpha.
 *
 *      D3DFMT_D16_LOCKABLE indicates:
 *           - An integer 16-bit value.
 *           - An app-lockable surface.
 *
 *      D3DFMT_D32F_LOCKABLE indicates:
 *           - An IEEE 754 floating-point value.
 *           - An app-lockable surface.
 *
 *      All Depth/Stencil formats except D3DFMT_D16_LOCKABLE and D3DFMT_D32F_LOCKABLE indicate:
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
    D3DFMT_A8B8G8R8 = 32,
    D3DFMT_X8B8G8R8 = 33,
    D3DFMT_G16R16 = 34,
    D3DFMT_A2R10G10B10 = 35,
    D3DFMT_A16B16G16R16 = 36,

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
    D3DFMT_A2W10V10U10 = 67,

    D3DFMT_UYVY = ((uint)(byte)('U') | ((uint)(byte)('Y') << 8) | ((uint)(byte)('V') << 16) | ((uint)(byte)('Y') << 24)),
    D3DFMT_R8G8_B8G8 = ((uint)(byte)('R') | ((uint)(byte)('G') << 8) | ((uint)(byte)('B') << 16) | ((uint)(byte)('G') << 24)),
    D3DFMT_YUY2 = ((uint)(byte)('Y') | ((uint)(byte)('U') << 8) | ((uint)(byte)('Y') << 16) | ((uint)(byte)('2') << 24)),
    D3DFMT_G8R8_G8B8 = ((uint)(byte)('G') | ((uint)(byte)('R') << 8) | ((uint)(byte)('G') << 16) | ((uint)(byte)('B') << 24)),
    D3DFMT_DXT1 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('1') << 24)),
    D3DFMT_DXT2 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('2') << 24)),
    D3DFMT_DXT3 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('3') << 24)),
    D3DFMT_DXT4 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('4') << 24)),
    D3DFMT_DXT5 = ((uint)(byte)('D') | ((uint)(byte)('X') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('5') << 24)),

    D3DFMT_D16_LOCKABLE = 70,
    D3DFMT_D32 = 71,
    D3DFMT_D15S1 = 73,
    D3DFMT_D24S8 = 75,
    D3DFMT_D24X8 = 77,
    D3DFMT_D24X4S4 = 79,
    D3DFMT_D16 = 80,

    D3DFMT_D32F_LOCKABLE = 82,
    D3DFMT_D24FS8 = 83,


    D3DFMT_L16 = 81,

    D3DFMT_VERTEXDATA = 100,
    D3DFMT_INDEX16 = 101,
    D3DFMT_INDEX32 = 102,

    D3DFMT_Q16W16V16U16 = 110,

    D3DFMT_MULTI2_ARGB8 = ((uint)(byte)('M') | ((uint)(byte)('E') << 8) | ((uint)(byte)('T') << 16) | ((uint)(byte)('1') << 24)),

    // Floating point surface formats

    // s10e5 formats (16-bits per channel)
    D3DFMT_R16F = 111,
    D3DFMT_G16R16F = 112,
    D3DFMT_A16B16G16R16F = 113,

    // IEEE s23e8 formats (32-bits per channel)
    D3DFMT_R32F = 114,
    D3DFMT_G32R32F = 115,
    D3DFMT_A32B32G32R32F = 116,

    D3DFMT_CxV8U8 = 117,


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
    public uint MultiSampleQuality;

    public D3DSWAPEFFECT SwapEffect = new D3DSWAPEFFECT();
    public IntPtr hDeviceWindow;
    public bool Windowed;
    public bool EnableAutoDepthStencil;
    public D3DFORMAT AutoDepthStencilFormat = new D3DFORMAT();
    public uint Flags;

    /* FullScreen_RefreshRateInHz must be zero for Windowed mode */
    public uint FullScreen_RefreshRateInHz;
    public uint PresentationInterval;
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
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DYNAMIC (0x00000200L)

// When passed to CheckDeviceFormat, D3DUSAGE_AUTOGENMIPMAP may return
// D3DOK_NOAUTOGEN if the device doesn't support autogeneration for that format.
// D3DOK_NOAUTOGEN is a success code, not a failure code... the SUCCEEDED and FAILED macros
// will return true and false respectively for this code.
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_AUTOGENMIPMAP (0x00000400L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_DMAP (0x00004000L)

// The following usages are valid only for querying CheckDeviceFormat
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_LEGACYBUMPMAP (0x00008000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_SRGBREAD (0x00010000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_FILTER (0x00020000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_SRGBWRITE (0x00040000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_POSTPIXELSHADER_BLENDING (0x00080000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_VERTEXTEXTURE (0x00100000L)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DUSAGE_QUERY_WRAPANDMIP (0x00200000L)

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

    public D3DMULTISAMPLE_TYPE MultiSampleType = new D3DMULTISAMPLE_TYPE();
    public uint MultiSampleQuality;
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
    public D3DDEGREETYPE Degree = new D3DDEGREETYPE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DRECTPATCH_INFO D3DRECTPATCH_INFO;

public class _D3DTRIPATCH_INFO
{
    public uint StartVertexOffset;
    public uint NumVertices;
    public D3DBASISTYPE Basis = new D3DBASISTYPE();
    public D3DDEGREETYPE Degree = new D3DDEGREETYPE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DTRIPATCH_INFO D3DTRIPATCH_INFO;

/* Adapter Identifier */

public class _D3DADAPTER_IDENTIFIER9
{
    public string Driver = new string(new char[DefineConstants.MAX_DEVICE_IDENTIFIER_STRING]);
    public string Description = new string(new char[DefineConstants.MAX_DEVICE_IDENTIFIER_STRING]);
    public string DeviceName = new string(new char[32]); // Device name for GDI (ex. \\.\DISPLAY1)

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
// typedef _D3DADAPTER_IDENTIFIER9 D3DADAPTER_IDENTIFIER9;


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

// Async feedback

public enum _D3DQUERYTYPE
{
    D3DQUERYTYPE_VCACHE = 4, // D3DISSUE_END
    D3DQUERYTYPE_RESOURCEMANAGER = 5, // D3DISSUE_END
    D3DQUERYTYPE_VERTEXSTATS = 6, // D3DISSUE_END
    D3DQUERYTYPE_EVENT = 8, // D3DISSUE_END
    D3DQUERYTYPE_OCCLUSION = 9, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_TIMESTAMP = 10, // D3DISSUE_END
    D3DQUERYTYPE_TIMESTAMPDISJOINT = 11, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_TIMESTAMPFREQ = 12, // D3DISSUE_END
    D3DQUERYTYPE_PIPELINETIMINGS = 13, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_INTERFACETIMINGS = 14, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_VERTEXTIMINGS = 15, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_PIXELTIMINGS = 16, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_BANDWIDTHTIMINGS = 17, // D3DISSUE_BEGIN, D3DISSUE_END
    D3DQUERYTYPE_CACHEUTILIZATION = 18 // D3DISSUE_BEGIN, D3DISSUE_END
}

// Flags field for Issue
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DISSUE_END (1 << 0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DISSUE_BEGIN (1 << 1)


// Flags field for GetData
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DGETDATA_FLUSH (1 << 0)


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


public class _D3DDEVINFO_VCACHE
{
    public uint Pattern; // bit pattern, return value must be FOUR_CC(�C�, �A�, �C�, �H�)
    public uint OptMethod; // optimization method 0 means longest strips, 1 means vertex cache based
    public uint CacheSize; // cache size to optimize for  (only required if type is 1)
    public uint MagicNumber; // used to determine when to restart strips (only required if type is 1)
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_VCACHE D3DDEVINFO_VCACHE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_VCACHE *LPD3DDEVINFO_VCACHE;

public class _D3DDEVINFO_D3D9PIPELINETIMINGS
{
    public float VertexProcessingTimePercent;
    public float PixelProcessingTimePercent;
    public float OtherGPUProcessingTimePercent;
    public float GPUIdleTimePercent;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3D9PIPELINETIMINGS D3DDEVINFO_D3D9PIPELINETIMINGS;

public class _D3DDEVINFO_D3D9INTERFACETIMINGS
{
    public float WaitingForGPUToUseApplicationResourceTimePercent;
    public float WaitingForGPUToAcceptMoreCommandsTimePercent;
    public float WaitingForGPUToStayWithinLatencyTimePercent;
    public float WaitingForGPUExclusiveResourceTimePercent;
    public float WaitingForGPUOtherTimePercent;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3D9INTERFACETIMINGS D3DDEVINFO_D3D9INTERFACETIMINGS;

public class _D3DDEVINFO_D3D9STAGETIMINGS
{
    public float MemoryProcessingPercent;
    public float ComputationProcessingPercent;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3D9STAGETIMINGS D3DDEVINFO_D3D9STAGETIMINGS;

public class _D3DDEVINFO_D3D9BANDWIDTHTIMINGS
{
    public float MaxBandwidthUtilized;
    public float FrontEndUploadMemoryUtilizedPercent;
    public float VertexRateUtilizedPercent;
    public float TriangleSetupRateUtilizedPercent;
    public float FillRateUtilizedPercent;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3D9BANDWIDTHTIMINGS D3DDEVINFO_D3D9BANDWIDTHTIMINGS;

public class _D3DDEVINFO_D3D9CACHEUTILIZATION
{
    public float TextureCacheHitRate; // Percentage of cache hits
    public float PostTransformVertexCacheHitRate;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DDEVINFO_D3D9CACHEUTILIZATION D3DDEVINFO_D3D9CACHEUTILIZATION;

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

#endif // (DIRECT3D_VERSION >= 0x0900)

