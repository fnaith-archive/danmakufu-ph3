#define DIRECTDRAW_VERSION

using System;

/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       ddraw.h
 *  Content:    DirectDraw include file
 *
 ***************************************************************************/


// Disable the nameless union warning when building internally
#if DIRECTX_REDIST
#define ENABLE_NAMELESS_UNION_PRAGMA
#endif

#if ENABLE_NAMELESS_UNION_PRAGMA
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201)
#endif

/*
 * If you wish an application built against the newest version of DirectDraw
 * to run against an older DirectDraw run time then define DIRECTDRAW_VERSION
 * to be the earlies version of DirectDraw you wish to run against. For,
 * example if you wish an application to run against a DX 3 runtime define
 * DIRECTDRAW_VERSION to be 0x0300.
 */

#if _WIN32 && ! _NO_COM
#define COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IUnknown void
#define IUnknown
#if ! NT_BUILD_ENVIRONMENT && !WINNT
        #define CO_E_NOTINITIALIZED
#endif
#endif

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )

#if __cplusplus
#endif

// 
// For compilers that don't support nameless unions, do a
// 
// #define NONAMELESSUNION
// 
// before #include <ddraw.h>
// 
#if ! DUMMYUNIONNAMEN
#if __cplusplus || !NONAMELESSUNION
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n)
#define DUMMYUNIONNAMEN
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n) u##n
#define DUMMYUNIONNAMEN
#endif
#endif

#if ! MAKEFOURCC
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
    #define MAKEFOURCC
#endif //defined(MAKEFOURCC)

/*
 * FOURCC codes for DX compressed-texture pixel formats
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT1 (MAKEFOURCC('D','X','T','1'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT2 (MAKEFOURCC('D','X','T','2'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT3 (MAKEFOURCC('D','X','T','3'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT4 (MAKEFOURCC('D','X','T','4'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT5 (MAKEFOURCC('D','X','T','5'))

/*
 * GUIDS used by DirectDraw objects
 */
#if _WIN32 && ! _NO_COM

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectDraw, 0xD7B70EE0,0x4340,0x11CF,0xB0,0x63,0x00,0x20,0xAF,0xC2,0xCD,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectDraw7, 0x3c305196,0x50db,0x11d3,0x9c,0xfe,0x00,0xc0,0x4f,0xd9,0x30,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectDrawClipper, 0x593817A0,0x7DB3,0x11CF,0xA2,0xDE,0x00,0xAA,0x00,0xb9,0x33,0x56);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDraw, 0x6C14DB80,0xA733,0x11CE,0xA5,0x21,0x00,0x20,0xAF,0x0B,0xE5,0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDraw2, 0xB3A6F3E0,0x2B43,0x11CF,0xA2,0xDE,0x00,0xAA,0x00,0xB9,0x33,0x56);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDraw4, 0x9c59509a,0x39bd,0x11d1,0x8c,0x4a,0x00,0xc0,0x4f,0xd9,0x30,0xc5);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDraw7, 0x15e65ec0,0x3b9c,0x11d2,0xb9,0x2f,0x00,0x60,0x97,0x97,0xea,0x5b);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface, 0x6C14DB81,0xA733,0x11CE,0xA5,0x21,0x00,0x20,0xAF,0x0B,0xE5,0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface2, 0x57805885,0x6eec,0x11cf,0x94,0x41,0xa8,0x23,0x03,0xc1,0x0e,0x27);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface3, 0xDA044E00,0x69B2,0x11D0,0xA1,0xD5,0x00,0xAA,0x00,0xB8,0xDF,0xBB);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface4, 0x0B2B8630,0xAD35,0x11D0,0x8E,0xA6,0x00,0x60,0x97,0x97,0xEA,0x5B);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface7, 0x06675a80,0x3b9b,0x11d2,0xb9,0x2f,0x00,0x60,0x97,0x97,0xea,0x5b);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawPalette, 0x6C14DB84,0xA733,0x11CE,0xA5,0x21,0x00,0x20,0xAF,0x0B,0xE5,0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawClipper, 0x6C14DB85,0xA733,0x11CE,0xA5,0x21,0x00,0x20,0xAF,0x0B,0xE5,0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawColorControl, 0x4B9F0EE0,0x0D7E,0x11D0,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawGammaControl, 0x69C11C3E,0xB46B,0x11D1,0xAD,0x7A,0x00,0xC0,0x4F,0xC2,0x9B,0x4E);

#endif

/*============================================================================
 *
 * DirectDraw Structures
 *
 * Various structures used to invoke DirectDraw.
 *
 *==========================================================================*/

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDraw;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDrawSurface;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDrawPalette;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDrawClipper;



/*
 * API's
 */
#if ( WIN32 || _WIN32 ) && ! _NO_COM
// #if defined( _WIN32 ) && !defined( _NO_ENUM )
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDDENUMCALLBACKA)(GUID FAR *, char*, char*, object*);
    public delegate bool LPDDENUMCALLBACKA(GUID UnnamedParameter, ref string UnnamedParameter2, ref string UnnamedParameter3, object UnnamedParameter4);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDDENUMCALLBACKW)(GUID FAR *, char*, char*, object*);
    public delegate bool LPDDENUMCALLBACKW(GUID UnnamedParameter, ref string UnnamedParameter2, ref string UnnamedParameter3, object UnnamedParameter4);
// #endif

/*
 * Generic pixel format with 8-bit RGB and alpha components
 */
public class _DDARGB
{
    public byte blue;
    public byte green;
    public byte red;
    public byte alpha;
}


/*
 * This version of the structure remains for backwards source compatibility.
 * The DDARGB structure is the one that should be used for all DirectDraw APIs.
 */
public class _DDRGBA
{
    public byte red;
    public byte green;
    public byte blue;
    public byte alpha;
}



/*
 * DDCOLORKEY
 */
public class _DDCOLORKEY
{
    public uint dwColorSpaceLowValue; // low boundary of color space that is to
                                        // be treated as Color Key, inclusive
    public uint dwColorSpaceHighValue; // high boundary of color space that is
                                        // to be treated as Color Key, inclusive
}


/*
 * DDBLTFX
 * Used to pass override information to the DIRECTDRAWSURFACE callback Blt.
 */
public class _DDBLTFX
{
    public uint dwSize; // size of structure
    public uint dwDDFX; // FX operations
    public uint dwROP; // Win32 raster operations
    public uint dwDDROP; // Raster operations new for DirectDraw
    public uint dwRotationAngle; // Rotation angle for blt
    public uint dwZBufferOpCode; // ZBuffer compares
    public uint dwZBufferLow; // Low limit of Z buffer
    public uint dwZBufferHigh; // High limit of Z buffer
    public uint dwZBufferBaseDest; // Destination base value
    public uint dwZDestConstBitDepth; // Bit depth used to specify Z constant for destination
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwZDestConst; // Constant to use as Z buffer for dest
//        struct IDirectDrawSurface FAR * lpDDSZBufferDest; // Surface to use as Z buffer for dest
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
    public uint dwZSrcConstBitDepth; // Bit depth used to specify Z constant for source
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwZSrcConst; // Constant to use as Z buffer for src
//        struct IDirectDrawSurface FAR * lpDDSZBufferSrc; // Surface to use as Z buffer for src
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(2);
    public uint dwAlphaEdgeBlendBitDepth; // Bit depth used to specify constant for alpha edge blend
    public uint dwAlphaEdgeBlend; // Alpha for edge blending
    public uint dwReserved;
    public uint dwAlphaDestConstBitDepth; // Bit depth used to specify alpha constant for destination
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwAlphaDestConst; // Constant to use as Alpha Channel
//        struct IDirectDrawSurface FAR * lpDDSAlphaDest; // Surface to use as Alpha Channel
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(3);
    public uint dwAlphaSrcConstBitDepth; // Bit depth used to specify alpha constant for source
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwAlphaSrcConst; // Constant to use as Alpha Channel
//        struct IDirectDrawSurface FAR * lpDDSAlphaSrc; // Surface to use as Alpha Channel
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(4);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwFillColor; // color in RGB or Palettized
//        uint dwFillDepth; // depth value for z-buffer
//        uint dwFillPixel; // pixel value for RGBA or RGBZ
//        struct IDirectDrawSurface FAR * lpDDSPattern; // Surface to use as pattern
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(5);
    public _DDCOLORKEY ddckDestColorkey = new _DDCOLORKEY(); // DestColorkey override
    public _DDCOLORKEY ddckSrcColorkey = new _DDCOLORKEY(); // SrcColorkey override
}




/*
 * DDSCAPS
 */
public class _DDSCAPS
{
    public uint dwCaps; // capabilities of surface wanted
}



/*
 * DDOSCAPS
 */
public class _DDOSCAPS
{
    public uint dwCaps; // capabilities of surface wanted
}


/*
 * This structure is used internally by DirectDraw.
 */
public class _DDSCAPSEX
{
    public uint dwCaps2;
    public uint dwCaps3;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwCaps4;
//        uint dwVolumeDepth;
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
}

/*
 * DDSCAPS2
 */
public class _DDSCAPS2
{
    public uint dwCaps; // capabilities of surface wanted
    public uint dwCaps2;
    public uint dwCaps3;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwCaps4;
//        uint dwVolumeDepth;
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
}


/*
 * DDCAPS
 */
#define DD_ROP_SPACE
/*
 * NOTE: Our choosen structure number scheme is to append a single digit to
 * the end of the structure giving the version that structure is associated
 * with.
 */

/*
 * This structure represents the DDCAPS structure released in DirectDraw 1.0.  It is used internally
 * by DirectDraw to interpret caps passed into ddraw by drivers written prior to the release of DirectDraw 2.0.
 * New applications should use the DDCAPS structure defined below.
 */
public class _DDCAPS_DX1
{
    public uint dwSize; // size of the DDDRIVERCAPS structure
    public uint dwCaps; // driver specific capabilities
    public uint dwCaps2; // more driver specific capabilites
    public uint dwCKeyCaps; // color key capabilities of the surface
    public uint dwFXCaps; // driver specific stretching and effects capabilites
    public uint dwFXAlphaCaps; // alpha driver specific capabilities
    public uint dwPalCaps; // palette capabilities
    public uint dwSVCaps; // stereo vision capabilities
    public uint dwAlphaBltConstBitDepths; // DDBD_2,4,8
    public uint dwAlphaBltPixelBitDepths; // DDBD_1,2,4,8
    public uint dwAlphaBltSurfaceBitDepths; // DDBD_1,2,4,8
    public uint dwAlphaOverlayConstBitDepths; // DDBD_2,4,8
    public uint dwAlphaOverlayPixelBitDepths; // DDBD_1,2,4,8
    public uint dwAlphaOverlaySurfaceBitDepths; // DDBD_1,2,4,8
    public uint dwZBufferBitDepths; // DDBD_8,16,24,32
    public uint dwVidMemTotal; // total amount of video memory
    public uint dwVidMemFree; // amount of free video memory
    public uint dwMaxVisibleOverlays; // maximum number of visible overlays
    public uint dwCurrVisibleOverlays; // current number of visible overlays
    public uint dwNumFourCCCodes; // number of four cc codes
    public uint dwAlignBoundarySrc; // source rectangle alignment
    public uint dwAlignSizeSrc; // source rectangle byte size
    public uint dwAlignBoundaryDest; // dest rectangle alignment
    public uint dwAlignSizeDest; // dest rectangle byte size
    public uint dwAlignStrideAlign; // stride alignment
    public uint[] dwRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported
    public _DDSCAPS ddsCaps = new _DDSCAPS(); // DDSCAPS structure has all the general capabilities
    public uint dwMinOverlayStretch; // minimum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMaxOverlayStretch; // maximum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMinLiveVideoStretch; // OBSOLETE! This field remains for compatability reasons only
    public uint dwMaxLiveVideoStretch; // OBSOLETE! This field remains for compatability reasons only
    public uint dwMinHwCodecStretch; // OBSOLETE! This field remains for compatability reasons only
    public uint dwMaxHwCodecStretch; // OBSOLETE! This field remains for compatability reasons only
    public uint dwReserved1; // reserved
    public uint dwReserved2; // reserved
    public uint dwReserved3; // reserved
}


/*
 * This structure is the DDCAPS structure as it was in version 2 and 3 of Direct X.
 * It is present for back compatability.
 */
public class _DDCAPS_DX3
{
    public uint dwSize; // size of the DDDRIVERCAPS structure
    public uint dwCaps; // driver specific capabilities
    public uint dwCaps2; // more driver specific capabilites
    public uint dwCKeyCaps; // color key capabilities of the surface
    public uint dwFXCaps; // driver specific stretching and effects capabilites
    public uint dwFXAlphaCaps; // alpha driver specific capabilities
    public uint dwPalCaps; // palette capabilities
    public uint dwSVCaps; // stereo vision capabilities
    public uint dwAlphaBltConstBitDepths; // DDBD_2,4,8
    public uint dwAlphaBltPixelBitDepths; // DDBD_1,2,4,8
    public uint dwAlphaBltSurfaceBitDepths; // DDBD_1,2,4,8
    public uint dwAlphaOverlayConstBitDepths; // DDBD_2,4,8
    public uint dwAlphaOverlayPixelBitDepths; // DDBD_1,2,4,8
    public uint dwAlphaOverlaySurfaceBitDepths; // DDBD_1,2,4,8
    public uint dwZBufferBitDepths; // DDBD_8,16,24,32
    public uint dwVidMemTotal; // total amount of video memory
    public uint dwVidMemFree; // amount of free video memory
    public uint dwMaxVisibleOverlays; // maximum number of visible overlays
    public uint dwCurrVisibleOverlays; // current number of visible overlays
    public uint dwNumFourCCCodes; // number of four cc codes
    public uint dwAlignBoundarySrc; // source rectangle alignment
    public uint dwAlignSizeSrc; // source rectangle byte size
    public uint dwAlignBoundaryDest; // dest rectangle alignment
    public uint dwAlignSizeDest; // dest rectangle byte size
    public uint dwAlignStrideAlign; // stride alignment
    public uint[] dwRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported
    public _DDSCAPS ddsCaps = new _DDSCAPS(); // DDSCAPS structure has all the general capabilities
    public uint dwMinOverlayStretch; // minimum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMaxOverlayStretch; // maximum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMinLiveVideoStretch; // minimum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMaxLiveVideoStretch; // maximum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMinHwCodecStretch; // minimum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwMaxHwCodecStretch; // maximum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
    public uint dwReserved1; // reserved
    public uint dwReserved2; // reserved
    public uint dwReserved3; // reserved
    public uint dwSVBCaps; // driver specific capabilities for System->Vmem blts
    public uint dwSVBCKeyCaps; // driver color key capabilities for System->Vmem blts
    public uint dwSVBFXCaps; // driver FX capabilities for System->Vmem blts
    public uint[] dwSVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->Vmem blts
    public uint dwVSBCaps; // driver specific capabilities for Vmem->System blts
    public uint dwVSBCKeyCaps; // driver color key capabilities for Vmem->System blts
    public uint dwVSBFXCaps; // driver FX capabilities for Vmem->System blts
    public uint[] dwVSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for Vmem->System blts
    public uint dwSSBCaps; // driver specific capabilities for System->System blts
    public uint dwSSBCKeyCaps; // driver color key capabilities for System->System blts
    public uint dwSSBFXCaps; // driver FX capabilities for System->System blts
    public uint[] dwSSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->System blts
    public uint dwReserved4; // reserved
    public uint dwReserved5; // reserved
    public uint dwReserved6; // reserved
}

/*
 * This structure is the DDCAPS structure as it was in version 5 of Direct X.
 * It is present for back compatability.
 */
public class _DDCAPS_DX5
{
/*  0*/
public uint dwSize; // size of the DDDRIVERCAPS structure
/*  4*/
public uint dwCaps; // driver specific capabilities
/*  8*/
public uint dwCaps2; // more driver specific capabilites
/*  c*/
public uint dwCKeyCaps; // color key capabilities of the surface
/* 10*/
public uint dwFXCaps; // driver specific stretching and effects capabilites
/* 14*/
public uint dwFXAlphaCaps; // alpha driver specific capabilities
/* 18*/
public uint dwPalCaps; // palette capabilities
/* 1c*/
public uint dwSVCaps; // stereo vision capabilities
/* 20*/
public uint dwAlphaBltConstBitDepths; // DDBD_2,4,8
/* 24*/
public uint dwAlphaBltPixelBitDepths; // DDBD_1,2,4,8
/* 28*/
public uint dwAlphaBltSurfaceBitDepths; // DDBD_1,2,4,8
/* 2c*/
public uint dwAlphaOverlayConstBitDepths; // DDBD_2,4,8
/* 30*/
public uint dwAlphaOverlayPixelBitDepths; // DDBD_1,2,4,8
/* 34*/
public uint dwAlphaOverlaySurfaceBitDepths; // DDBD_1,2,4,8
/* 38*/
public uint dwZBufferBitDepths; // DDBD_8,16,24,32
/* 3c*/
public uint dwVidMemTotal; // total amount of video memory
/* 40*/
public uint dwVidMemFree; // amount of free video memory
/* 44*/
public uint dwMaxVisibleOverlays; // maximum number of visible overlays
/* 48*/
public uint dwCurrVisibleOverlays; // current number of visible overlays
/* 4c*/
public uint dwNumFourCCCodes; // number of four cc codes
/* 50*/
public uint dwAlignBoundarySrc; // source rectangle alignment
/* 54*/
public uint dwAlignSizeSrc; // source rectangle byte size
/* 58*/
public uint dwAlignBoundaryDest; // dest rectangle alignment
/* 5c*/
public uint dwAlignSizeDest; // dest rectangle byte size
/* 60*/
public uint dwAlignStrideAlign; // stride alignment
/* 64*/
public uint[] dwRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported
/* 84*/
public _DDSCAPS ddsCaps = new _DDSCAPS(); // DDSCAPS structure has all the general capabilities
/* 88*/
public uint dwMinOverlayStretch; // minimum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 8c*/
public uint dwMaxOverlayStretch; // maximum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 90*/
public uint dwMinLiveVideoStretch; // minimum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 94*/
public uint dwMaxLiveVideoStretch; // maximum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 98*/
public uint dwMinHwCodecStretch; // minimum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 9c*/
public uint dwMaxHwCodecStretch; // maximum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* a0*/
public uint dwReserved1; // reserved
/* a4*/
public uint dwReserved2; // reserved
/* a8*/
public uint dwReserved3; // reserved
/* ac*/
public uint dwSVBCaps; // driver specific capabilities for System->Vmem blts
/* b0*/
public uint dwSVBCKeyCaps; // driver color key capabilities for System->Vmem blts
/* b4*/
public uint dwSVBFXCaps; // driver FX capabilities for System->Vmem blts
/* b8*/
public uint[] dwSVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->Vmem blts
/* d8*/
public uint dwVSBCaps; // driver specific capabilities for Vmem->System blts
/* dc*/
public uint dwVSBCKeyCaps; // driver color key capabilities for Vmem->System blts
/* e0*/
public uint dwVSBFXCaps; // driver FX capabilities for Vmem->System blts
/* e4*/
public uint[] dwVSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for Vmem->System blts
/*104*/
public uint dwSSBCaps; // driver specific capabilities for System->System blts
/*108*/
public uint dwSSBCKeyCaps; // driver color key capabilities for System->System blts
/*10c*/
public uint dwSSBFXCaps; // driver FX capabilities for System->System blts
/*110*/
public uint[] dwSSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->System blts
// Members added for DX5:
/*130*/
public uint dwMaxVideoPorts; // maximum number of usable video ports
/*134*/
public uint dwCurrVideoPorts; // current number of video ports used
/*138*/
public uint dwSVBCaps2; // more driver specific capabilities for System->Vmem blts
/*13c*/
public uint dwNLVBCaps; // driver specific capabilities for non-local->local vidmem blts
/*140*/
public uint dwNLVBCaps2; // more driver specific capabilities non-local->local vidmem blts
/*144*/
public uint dwNLVBCKeyCaps; // driver color key capabilities for non-local->local vidmem blts
/*148*/
public uint dwNLVBFXCaps; // driver FX capabilities for non-local->local blts
/*14c*/
public uint[] dwNLVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for non-local->local blts
}

public class _DDCAPS_DX6
{
/*  0*/
public uint dwSize; // size of the DDDRIVERCAPS structure
/*  4*/
public uint dwCaps; // driver specific capabilities
/*  8*/
public uint dwCaps2; // more driver specific capabilites
/*  c*/
public uint dwCKeyCaps; // color key capabilities of the surface
/* 10*/
public uint dwFXCaps; // driver specific stretching and effects capabilites
/* 14*/
public uint dwFXAlphaCaps; // alpha caps
/* 18*/
public uint dwPalCaps; // palette capabilities
/* 1c*/
public uint dwSVCaps; // stereo vision capabilities
/* 20*/
public uint dwAlphaBltConstBitDepths; // DDBD_2,4,8
/* 24*/
public uint dwAlphaBltPixelBitDepths; // DDBD_1,2,4,8
/* 28*/
public uint dwAlphaBltSurfaceBitDepths; // DDBD_1,2,4,8
/* 2c*/
public uint dwAlphaOverlayConstBitDepths; // DDBD_2,4,8
/* 30*/
public uint dwAlphaOverlayPixelBitDepths; // DDBD_1,2,4,8
/* 34*/
public uint dwAlphaOverlaySurfaceBitDepths; // DDBD_1,2,4,8
/* 38*/
public uint dwZBufferBitDepths; // DDBD_8,16,24,32
/* 3c*/
public uint dwVidMemTotal; // total amount of video memory
/* 40*/
public uint dwVidMemFree; // amount of free video memory
/* 44*/
public uint dwMaxVisibleOverlays; // maximum number of visible overlays
/* 48*/
public uint dwCurrVisibleOverlays; // current number of visible overlays
/* 4c*/
public uint dwNumFourCCCodes; // number of four cc codes
/* 50*/
public uint dwAlignBoundarySrc; // source rectangle alignment
/* 54*/
public uint dwAlignSizeSrc; // source rectangle byte size
/* 58*/
public uint dwAlignBoundaryDest; // dest rectangle alignment
/* 5c*/
public uint dwAlignSizeDest; // dest rectangle byte size
/* 60*/
public uint dwAlignStrideAlign; // stride alignment
/* 64*/
public uint[] dwRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported
/* 84*/
public _DDSCAPS ddsOldCaps = new _DDSCAPS(); // Was DDSCAPS  ddsCaps. ddsCaps is of type DDSCAPS2 for DX6
/* 88*/
public uint dwMinOverlayStretch; // minimum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 8c*/
public uint dwMaxOverlayStretch; // maximum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 90*/
public uint dwMinLiveVideoStretch; // minimum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 94*/
public uint dwMaxLiveVideoStretch; // maximum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 98*/
public uint dwMinHwCodecStretch; // minimum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 9c*/
public uint dwMaxHwCodecStretch; // maximum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* a0*/
public uint dwReserved1; // reserved
/* a4*/
public uint dwReserved2; // reserved
/* a8*/
public uint dwReserved3; // reserved
/* ac*/
public uint dwSVBCaps; // driver specific capabilities for System->Vmem blts
/* b0*/
public uint dwSVBCKeyCaps; // driver color key capabilities for System->Vmem blts
/* b4*/
public uint dwSVBFXCaps; // driver FX capabilities for System->Vmem blts
/* b8*/
public uint[] dwSVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->Vmem blts
/* d8*/
public uint dwVSBCaps; // driver specific capabilities for Vmem->System blts
/* dc*/
public uint dwVSBCKeyCaps; // driver color key capabilities for Vmem->System blts
/* e0*/
public uint dwVSBFXCaps; // driver FX capabilities for Vmem->System blts
/* e4*/
public uint[] dwVSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for Vmem->System blts
/*104*/
public uint dwSSBCaps; // driver specific capabilities for System->System blts
/*108*/
public uint dwSSBCKeyCaps; // driver color key capabilities for System->System blts
/*10c*/
public uint dwSSBFXCaps; // driver FX capabilities for System->System blts
/*110*/
public uint[] dwSSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->System blts
/*130*/
public uint dwMaxVideoPorts; // maximum number of usable video ports
/*134*/
public uint dwCurrVideoPorts; // current number of video ports used
/*138*/
public uint dwSVBCaps2; // more driver specific capabilities for System->Vmem blts
/*13c*/
public uint dwNLVBCaps; // driver specific capabilities for non-local->local vidmem blts
/*140*/
public uint dwNLVBCaps2; // more driver specific capabilities non-local->local vidmem blts
/*144*/
public uint dwNLVBCKeyCaps; // driver color key capabilities for non-local->local vidmem blts
/*148*/
public uint dwNLVBFXCaps; // driver FX capabilities for non-local->local blts
/*14c*/
public uint[] dwNLVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for non-local->local blts
// Members added for DX6 release
/*16c*/
public _DDSCAPS2 ddsCaps = new _DDSCAPS2(); // Surface Caps
}

public class _DDCAPS_DX7
{
/*  0*/
public uint dwSize; // size of the DDDRIVERCAPS structure
/*  4*/
public uint dwCaps; // driver specific capabilities
/*  8*/
public uint dwCaps2; // more driver specific capabilites
/*  c*/
public uint dwCKeyCaps; // color key capabilities of the surface
/* 10*/
public uint dwFXCaps; // driver specific stretching and effects capabilites
/* 14*/
public uint dwFXAlphaCaps; // alpha driver specific capabilities
/* 18*/
public uint dwPalCaps; // palette capabilities
/* 1c*/
public uint dwSVCaps; // stereo vision capabilities
/* 20*/
public uint dwAlphaBltConstBitDepths; // DDBD_2,4,8
/* 24*/
public uint dwAlphaBltPixelBitDepths; // DDBD_1,2,4,8
/* 28*/
public uint dwAlphaBltSurfaceBitDepths; // DDBD_1,2,4,8
/* 2c*/
public uint dwAlphaOverlayConstBitDepths; // DDBD_2,4,8
/* 30*/
public uint dwAlphaOverlayPixelBitDepths; // DDBD_1,2,4,8
/* 34*/
public uint dwAlphaOverlaySurfaceBitDepths; // DDBD_1,2,4,8
/* 38*/
public uint dwZBufferBitDepths; // DDBD_8,16,24,32
/* 3c*/
public uint dwVidMemTotal; // total amount of video memory
/* 40*/
public uint dwVidMemFree; // amount of free video memory
/* 44*/
public uint dwMaxVisibleOverlays; // maximum number of visible overlays
/* 48*/
public uint dwCurrVisibleOverlays; // current number of visible overlays
/* 4c*/
public uint dwNumFourCCCodes; // number of four cc codes
/* 50*/
public uint dwAlignBoundarySrc; // source rectangle alignment
/* 54*/
public uint dwAlignSizeSrc; // source rectangle byte size
/* 58*/
public uint dwAlignBoundaryDest; // dest rectangle alignment
/* 5c*/
public uint dwAlignSizeDest; // dest rectangle byte size
/* 60*/
public uint dwAlignStrideAlign; // stride alignment
/* 64*/
public uint[] dwRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported
/* 84*/
public _DDSCAPS ddsOldCaps = new _DDSCAPS(); // Was DDSCAPS  ddsCaps. ddsCaps is of type DDSCAPS2 for DX6
/* 88*/
public uint dwMinOverlayStretch; // minimum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 8c*/
public uint dwMaxOverlayStretch; // maximum overlay stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 90*/
public uint dwMinLiveVideoStretch; // minimum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 94*/
public uint dwMaxLiveVideoStretch; // maximum live video stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 98*/
public uint dwMinHwCodecStretch; // minimum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* 9c*/
public uint dwMaxHwCodecStretch; // maximum hardware codec stretch factor multiplied by 1000, eg 1000 == 1.0, 1300 == 1.3
/* a0*/
public uint dwReserved1; // reserved
/* a4*/
public uint dwReserved2; // reserved
/* a8*/
public uint dwReserved3; // reserved
/* ac*/
public uint dwSVBCaps; // driver specific capabilities for System->Vmem blts
/* b0*/
public uint dwSVBCKeyCaps; // driver color key capabilities for System->Vmem blts
/* b4*/
public uint dwSVBFXCaps; // driver FX capabilities for System->Vmem blts
/* b8*/
public uint[] dwSVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->Vmem blts
/* d8*/
public uint dwVSBCaps; // driver specific capabilities for Vmem->System blts
/* dc*/
public uint dwVSBCKeyCaps; // driver color key capabilities for Vmem->System blts
/* e0*/
public uint dwVSBFXCaps; // driver FX capabilities for Vmem->System blts
/* e4*/
public uint[] dwVSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for Vmem->System blts
/*104*/
public uint dwSSBCaps; // driver specific capabilities for System->System blts
/*108*/
public uint dwSSBCKeyCaps; // driver color key capabilities for System->System blts
/*10c*/
public uint dwSSBFXCaps; // driver FX capabilities for System->System blts
/*110*/
public uint[] dwSSBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for System->System blts
/*130*/
public uint dwMaxVideoPorts; // maximum number of usable video ports
/*134*/
public uint dwCurrVideoPorts; // current number of video ports used
/*138*/
public uint dwSVBCaps2; // more driver specific capabilities for System->Vmem blts
/*13c*/
public uint dwNLVBCaps; // driver specific capabilities for non-local->local vidmem blts
/*140*/
public uint dwNLVBCaps2; // more driver specific capabilities non-local->local vidmem blts
/*144*/
public uint dwNLVBCKeyCaps; // driver color key capabilities for non-local->local vidmem blts
/*148*/
public uint dwNLVBFXCaps; // driver FX capabilities for non-local->local blts
/*14c*/
public uint[] dwNLVBRops = new uint[DefineConstants.DD_ROP_SPACE]; // ROPS supported for non-local->local blts
// Members added for DX6 release
/*16c*/
public _DDSCAPS2 ddsCaps = new _DDSCAPS2(); // Surface Caps
}


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTDRAW_VERSION <= 0x300
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#elif DIRECTDRAW_VERSION <= 0x500
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#elif DIRECTDRAW_VERSION <= 0x600
#else
#endif

// C++ TO C# CONVERTER TODO TASK: The typedef 'DDCAPS' was defined in multiple preprocessor conditionals and cannot be replaced in-line:



/*
 * DDPIXELFORMAT
 */
public class _DDPIXELFORMAT
{
    public uint dwSize; // size of structure
    public uint dwFlags; // pixel format flags
    public uint dwFourCC; // (FOURCC code)
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwRGBBitCount; // how many bits per pixel
//        uint dwYUVBitCount; // how many bits per pixel
//        uint dwZBufferBitDepth; // how many total bits/pixel in z buffer (including any stencil bits)
//        uint dwAlphaBitDepth; // how many bits for alpha channels
//        uint dwLuminanceBitCount; // how many bits per pixel
//        uint dwBumpBitCount; // how many bits per "buxel", total
//        uint dwPrivateFormatBitCount; // Bits per pixel of private driver formats. Only valid in texture
//                                        // format list and if DDPF_D3DFORMAT is set
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwRBitMask; // mask for red bit
//        uint dwYBitMask; // mask for Y bits
//        uint dwStencilBitDepth; // how many stencil bits (note: dwZBufferBitDepth-dwStencilBitDepth is total Z-only bits)
//        uint dwLuminanceBitMask; // mask for luminance bits
//        uint dwBumpDuBitMask; // mask for bump map U delta bits
//        uint dwOperations; // DDPF_D3DFORMAT Operations
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(2);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwGBitMask; // mask for green bits
//        uint dwUBitMask; // mask for U bits
//        uint dwZBitMask; // mask for Z bits
//        uint dwBumpDvBitMask; // mask for bump map V delta bits
//        struct
//        {
//            ushort wFlipMSTypes; // Multisample methods supported via flip for this D3DFORMAT
//            ushort wBltMSTypes; // Multisample methods supported via blt for this D3DFORMAT
//        }
//        MultiSampleCaps;
// 
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(3);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwBBitMask; // mask for blue bits
//        uint dwVBitMask; // mask for V bits
//        uint dwStencilBitMask; // mask for stencil bits
//        uint dwBumpLuminanceBitMask; // mask for luminance in bump map
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(4);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwRGBAlphaBitMask; // mask for alpha channel
//        uint dwYUVAlphaBitMask; // mask for alpha channel
//        uint dwLuminanceAlphaBitMask; // mask for alpha channel
//        uint dwRGBZBitMask; // mask for Z channel
//        uint dwYUVZBitMask; // mask for Z channel
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(5);
}


/*
 * DDOVERLAYFX
 */
public class _DDOVERLAYFX
{
    public uint dwSize; // size of structure
    public uint dwAlphaEdgeBlendBitDepth; // Bit depth used to specify constant for alpha edge blend
    public uint dwAlphaEdgeBlend; // Constant to use as alpha for edge blend
    public uint dwReserved;
    public uint dwAlphaDestConstBitDepth; // Bit depth used to specify alpha constant for destination
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwAlphaDestConst; // Constant to use as alpha channel for dest
//        struct IDirectDrawSurface FAR * lpDDSAlphaDest; // Surface to use as alpha channel for dest
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
    public uint dwAlphaSrcConstBitDepth; // Bit depth used to specify alpha constant for source
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwAlphaSrcConst; // Constant to use as alpha channel for src
//        struct IDirectDrawSurface FAR * lpDDSAlphaSrc; // Surface to use as alpha channel for src
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(2);
    public _DDCOLORKEY dckDestColorkey = new _DDCOLORKEY(); // DestColorkey override
    public _DDCOLORKEY dckSrcColorkey = new _DDCOLORKEY(); // DestColorkey override
    public uint dwDDFX; // Overlay FX
    public uint dwFlags; // flags
}



/*
 * DDBLTBATCH: BltBatch entry structure
 */
public class _DDBLTBATCH
{
    public LPRECT lprDest = new LPRECT();
    public IDirectDrawSurface lpDDSSrc;
    public LPRECT lprSrc = new LPRECT();
    public uint dwFlags;
    public _DDBLTFX FAR * lpDDBltFx = new _DDBLTFX();
}



/*
 * DDGAMMARAMP
 */
public class _DDGAMMARAMP
{
    public ushort[] red = new ushort[256];
    public ushort[] green = new ushort[256];
    public ushort[] blue = new ushort[256];
}

/*
 *  This is the structure within which DirectDraw returns data about the current graphics driver and chipset
 */

#define MAX_DDDEVICEID_STRING

public class tagDDDEVICEIDENTIFIER
{
    /*
     * These elements are for presentation to the user only. They should not be used to identify particular
     * drivers, since this is unreliable and many different strings may be associated with the same
     * device, and the same driver from different vendors.
     */
    public string szDriver = new string(new char[DefineConstants.MAX_DDDEVICEID_STRING]);
    public string szDescription = new string(new char[DefineConstants.MAX_DDDEVICEID_STRING]);

    /*
     * This element is the version of the DirectDraw/3D driver. It is legal to do <, > comparisons
     * on the whole 64 bits. Caution should be exercised if you use this element to identify problematic
     * drivers. It is recommended that guidDeviceIdentifier is used for this purpose.
     *
     * This version has the form:
     *  wProduct = HIWORD(liDriverVersion.HighPart)
     *  wVersion = LOWORD(liDriverVersion.HighPart)
     *  wSubVersion = HIWORD(liDriverVersion.LowPart)
     *  wBuild = LOWORD(liDriverVersion.LowPart)
     */
#if _WIN32
    public LARGE_INTEGER liDriverVersion = new LARGE_INTEGER(); // Defined for applications and other 32 bit components
#else
    public uint dwDriverVersionLowPart; // Defined for 16 bit driver components
    public uint dwDriverVersionHighPart;
#endif


    /*
     * These elements can be used to identify particular chipsets. Use with extreme caution.
     *   dwVendorId     Identifies the manufacturer. May be zero if unknown.
     *   dwDeviceId     Identifies the type of chipset. May be zero if unknown.
     *   dwSubSysId     Identifies the subsystem, typically this means the particular board. May be zero if unknown.
     *   dwRevision     Identifies the revision level of the chipset. May be zero if unknown.
     */
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;

    /*
     * This element can be used to check changes in driver/chipset. This GUID is a unique identifier for the
     * driver/chipset pair. Use this element if you wish to track changes to the driver/chipset in order to
     * reprofile the graphics subsystem.
     * This element can also be used to identify particular problematic drivers.
     */
    public GUID guidDeviceIdentifier = new GUID();
}

public class tagDDDEVICEIDENTIFIER2
{
    /*
     * These elements are for presentation to the user only. They should not be used to identify particular
     * drivers, since this is unreliable and many different strings may be associated with the same
     * device, and the same driver from different vendors.
     */
    public string szDriver = new string(new char[DefineConstants.MAX_DDDEVICEID_STRING]);
    public string szDescription = new string(new char[DefineConstants.MAX_DDDEVICEID_STRING]);

    /*
     * This element is the version of the DirectDraw/3D driver. It is legal to do <, > comparisons
     * on the whole 64 bits. Caution should be exercised if you use this element to identify problematic
     * drivers. It is recommended that guidDeviceIdentifier is used for this purpose.
     *
     * This version has the form:
     *  wProduct = HIWORD(liDriverVersion.HighPart)
     *  wVersion = LOWORD(liDriverVersion.HighPart)
     *  wSubVersion = HIWORD(liDriverVersion.LowPart)
     *  wBuild = LOWORD(liDriverVersion.LowPart)
     */
#if _WIN32
    public LARGE_INTEGER liDriverVersion = new LARGE_INTEGER(); // Defined for applications and other 32 bit components
#else
    public uint dwDriverVersionLowPart; // Defined for 16 bit driver components
    public uint dwDriverVersionHighPart;
#endif


    /*
     * These elements can be used to identify particular chipsets. Use with extreme caution.
     *   dwVendorId     Identifies the manufacturer. May be zero if unknown.
     *   dwDeviceId     Identifies the type of chipset. May be zero if unknown.
     *   dwSubSysId     Identifies the subsystem, typically this means the particular board. May be zero if unknown.
     *   dwRevision     Identifies the revision level of the chipset. May be zero if unknown.
     */
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;

    /*
     * This element can be used to check changes in driver/chipset. This GUID is a unique identifier for the
     * driver/chipset pair. Use this element if you wish to track changes to the driver/chipset in order to
     * reprofile the graphics subsystem.
     * This element can also be used to identify particular problematic drivers.
     */
    public GUID guidDeviceIdentifier = new GUID();

    /*
     * This element is used to determine the Windows Hardware Quality Lab (WHQL)
     * certification level for this driver/device pair.
     */
    public uint dwWHQLLevel;

}

/*
 * Flags for the IDirectDraw4::GetDeviceIdentifier method
 */

/*
 * This flag causes GetDeviceIdentifier to return information about the host (typically 2D) adapter in a system equipped
 * with a stacked secondary 3D adapter. Such an adapter appears to the application as if it were part of the
 * host adapter, but is typically physcially located on a separate card. The stacked secondary's information is
 * returned when GetDeviceIdentifier's dwFlags field is zero, since this most accurately reflects the qualities
 * of the DirectDraw object involved.
 */
#define DDGDI_GETHOSTIDENTIFIER

/*
 * Macros for interpretting DDEVICEIDENTIFIER2.dwWHQLLevel
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_YEAR( dwWHQLLevel ) ( (dwWHQLLevel) / 0x10000 )
#define GET_WHQL_YEAR
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_MONTH( dwWHQLLevel ) ( ( (dwWHQLLevel) / 0x100 ) & 0x00ff )
#define GET_WHQL_MONTH
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_DAY( dwWHQLLevel ) ( (dwWHQLLevel) & 0xff )
#define GET_WHQL_DAY


/*
 * callbacks
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef uint(FAR PASCAL *LPCLIPPERCALLBACK)(struct IDirectDrawClipper FAR * lpDDClipper, System.IntPtr hWnd, uint code, object* lpContext);
public delegate uint LPCLIPPERCALLBACK(IDirectDrawClipper lpDDClipper, IntPtr hWnd, uint code, object lpContext);
#if STREAMING
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef uint(FAR PASCAL *LPSURFACESTREAMINGCALLBACK)(uint);
public delegate uint LPSURFACESTREAMINGCALLBACK(uint UnnamedParameter);
#endif


/*
 * DDSURFACEDESC
 */
public class _DDSURFACEDESC
{
    public uint dwSize; // size of the DDSURFACEDESC structure
    public uint dwFlags; // determines what fields are valid
    public uint dwHeight; // height of surface to be created
    public uint dwWidth; // width of input surface
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        int lPitch; // distance to start of next line (return value only)
//        uint dwLinearSize; // Formless late-allocated optimized surface size
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
    public uint dwBackBufferCount; // number of back buffers requested
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwMipMapCount; // number of mip-map levels requested
//        uint dwZBufferBitDepth; // depth of Z buffer requested
//        uint dwRefreshRate; // refresh rate (used when display mode is described)
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(2);
    public uint dwAlphaBitDepth; // depth of alpha buffer requested
    public uint dwReserved; // reserved
    public object lpSurface; // pointer to the associated surface memory
    public _DDCOLORKEY ddckCKDestOverlay = new _DDCOLORKEY(); // color key for destination overlay use
    public _DDCOLORKEY ddckCKDestBlt = new _DDCOLORKEY(); // color key for destination blt use
    public _DDCOLORKEY ddckCKSrcOverlay = new _DDCOLORKEY(); // color key for source overlay use
    public _DDCOLORKEY ddckCKSrcBlt = new _DDCOLORKEY(); // color key for source blt use
    public _DDPIXELFORMAT ddpfPixelFormat = new _DDPIXELFORMAT(); // pixel format description of the surface
    public _DDSCAPS ddsCaps = new _DDSCAPS(); // direct draw surface capabilities
}

/*
 * DDSURFACEDESC2
 */
public class _DDSURFACEDESC2
{
    public uint dwSize; // size of the DDSURFACEDESC structure
    public uint dwFlags; // determines what fields are valid
    public uint dwHeight; // height of surface to be created
    public uint dwWidth; // width of input surface
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        int lPitch; // distance to start of next line (return value only)
//        uint dwLinearSize; // Formless late-allocated optimized surface size
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(1);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwBackBufferCount; // number of back buffers requested
//        uint dwDepth; // the depth if this is a volume texture
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(5);
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwMipMapCount; // number of mip-map levels requestde
//                                                // dwZBufferBitDepth removed, use ddpfPixelFormat one instead
//        uint dwRefreshRate; // refresh rate (used when display mode is described)
//        uint dwSrcVBHandle; // The source used in VB::Optimize
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(2);
    public uint dwAlphaBitDepth; // depth of alpha buffer requested
    public uint dwReserved; // reserved
    public object lpSurface; // pointer to the associated surface memory
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        _DDCOLORKEY ddckCKDestOverlay; // color key for destination overlay use
//        uint dwEmptyFaceColor; // Physical color for empty cubemap faces
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(3);
    public _DDCOLORKEY ddckCKDestBlt = new _DDCOLORKEY(); // color key for destination blt use
    public _DDCOLORKEY ddckCKSrcOverlay = new _DDCOLORKEY(); // color key for source overlay use
    public _DDCOLORKEY ddckCKSrcBlt = new _DDCOLORKEY(); // color key for source blt use
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        _DDPIXELFORMAT ddpfPixelFormat; // pixel format description of the surface
//        uint dwFVF; // vertex format description of vertex buffers
/// /C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
//    }
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DUMMYUNIONNAMEN' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
    DUMMYUNIONNAMEN(4);
    public _DDSCAPS2 ddsCaps = new _DDSCAPS2(); // direct draw surface capabilities
    public uint dwTextureStage; // stage in multitexture cascade
}

/*
 * ddsCaps field is valid.
 */
#define DDSD_CAPS

/*
 * dwHeight field is valid.
 */
#define DDSD_HEIGHT

/*
 * dwWidth field is valid.
 */
#define DDSD_WIDTH

/*
 * lPitch is valid.
 */
#define DDSD_PITCH

/*
 * dwBackBufferCount is valid.
 */
#define DDSD_BACKBUFFERCOUNT

/*
 * dwZBufferBitDepth is valid.  (shouldnt be used in DDSURFACEDESC2)
 */
#define DDSD_ZBUFFERBITDEPTH

/*
 * dwAlphaBitDepth is valid.
 */
#define DDSD_ALPHABITDEPTH


/*
 * lpSurface is valid.
 */
#define DDSD_LPSURFACE

/*
 * ddpfPixelFormat is valid.
 */
#define DDSD_PIXELFORMAT

/*
 * ddckCKDestOverlay is valid.
 */
#define DDSD_CKDESTOVERLAY

/*
 * ddckCKDestBlt is valid.
 */
#define DDSD_CKDESTBLT

/*
 * ddckCKSrcOverlay is valid.
 */
#define DDSD_CKSRCOVERLAY

/*
 * ddckCKSrcBlt is valid.
 */
#define DDSD_CKSRCBLT

/*
 * dwMipMapCount is valid.
 */
#define DDSD_MIPMAPCOUNT

 /*
  * dwRefreshRate is valid
  */
#define DDSD_REFRESHRATE

/*
 * dwLinearSize is valid
 */
#define DDSD_LINEARSIZE

/*
 * dwTextureStage is valid
 */
#define DDSD_TEXTURESTAGE
/*
 * dwFVF is valid
 */
#define DDSD_FVF
/*
 * dwSrcVBHandle is valid
 */
#define DDSD_SRCVBHANDLE

/*
 * dwDepth is valid
 */
#define DDSD_DEPTH

/*
 * All input fields are valid.
 */
#define DDSD_ALL

/*
 * DDOPTSURFACEDESC
 */
public class _DDOPTSURFACEDESC
{
    public uint dwSize; // size of the DDOPTSURFACEDESC structure
    public uint dwFlags; // determines what fields are valid
    public _DDSCAPS2 ddSCaps = new _DDSCAPS2(); // Common caps like: Memory type
    public _DDOSCAPS ddOSCaps = new _DDOSCAPS(); // Common caps like: Memory type
    public GUID guid = new GUID(); // Compression technique GUID
    public uint dwCompressionRatio; // Compression ratio
}

/*
 * guid field is valid.
 */
#define DDOSD_GUID

/*
 * dwCompressionRatio field is valid.
 */
#define DDOSD_COMPRESSION_RATIO

/*
 * ddSCaps field is valid.
 */
#define DDOSD_SCAPS

/*
 * ddOSCaps field is valid.
 */
#define DDOSD_OSCAPS

/*
 * All input fields are valid.
 */
#define DDOSD_ALL

/*
 * The surface's optimized pixelformat is compressed
 */
#define DDOSDCAPS_OPTCOMPRESSED

/*
 * The surface's optimized pixelformat is reordered
 */
#define DDOSDCAPS_OPTREORDERED

/*
 * The opt surface is a monolithic mipmap
 */
#define DDOSDCAPS_MONOLITHICMIPMAP

/*
 * The valid Surf caps:
 * #define DDSCAPS_SYSTEMMEMORY                 0x00000800l
 * #define DDSCAPS_VIDEOMEMORY          0x00004000l
 * #define DDSCAPS_LOCALVIDMEM          0x10000000l
 * #define DDSCAPS_NONLOCALVIDMEM       0x20000000l
 */
#define DDOSDCAPS_VALIDSCAPS

/*
 * The valid OptSurf caps
 */
#define DDOSDCAPS_VALIDOSCAPS


/*
 * DDCOLORCONTROL
 */
public class _DDCOLORCONTROL
{
    public uint dwSize;
    public uint dwFlags;
    public int lBrightness;
    public int lContrast;
    public int lHue;
    public int lSaturation;
    public int lSharpness;
    public int lGamma;
    public int lColorEnable;
    public uint dwReserved1;
}


/*
 * lBrightness field is valid.
 */
#define DDCOLOR_BRIGHTNESS

/*
 * lContrast field is valid.
 */
#define DDCOLOR_CONTRAST

/*
 * lHue field is valid.
 */
#define DDCOLOR_HUE

/*
 * lSaturation field is valid.
 */
#define DDCOLOR_SATURATION

/*
 * lSharpness field is valid.
 */
#define DDCOLOR_SHARPNESS

/*
 * lGamma field is valid.
 */
#define DDCOLOR_GAMMA

/*
 * lColorEnable field is valid.
 */
#define DDCOLOR_COLORENABLE



/*============================================================================
 *
 * Direct Draw Capability Flags
 *
 * These flags are used to describe the capabilities of a given Surface.
 * All flags are bit flags.
 *
 *==========================================================================*/

/****************************************************************************
 *
 * DIRECTDRAWSURFACE CAPABILITY FLAGS
 *
 ****************************************************************************/

/*
 * This bit is reserved. It should not be specified.
 */
#define DDSCAPS_RESERVED1

/*
 * Indicates that this surface contains alpha-only information.
 * (To determine if a surface is RGBA/YUVA, the pixel format must be
 * interrogated.)
 */
#define DDSCAPS_ALPHA

/*
 * Indicates that this surface is a backbuffer.  It is generally
 * set by CreateSurface when the DDSCAPS_FLIP capability bit is set.
 * It indicates that this surface is THE back buffer of a surface
 * flipping structure.  DirectDraw supports N surfaces in a
 * surface flipping structure.  Only the surface that immediately
 * precedeces the DDSCAPS_FRONTBUFFER has this capability bit set.
 * The other surfaces are identified as back buffers by the presence
 * of the DDSCAPS_FLIP capability, their attachment order, and the
 * absence of the DDSCAPS_FRONTBUFFER and DDSCAPS_BACKBUFFER
 * capabilities.  The bit is sent to CreateSurface when a standalone
 * back buffer is being created.  This surface could be attached to
 * a front buffer and/or back buffers to form a flipping surface
 * structure after the CreateSurface call.  See AddAttachments for
 * a detailed description of the behaviors in this case.
 */
#define DDSCAPS_BACKBUFFER

/*
 * Indicates a complex surface structure is being described.  A
 * complex surface structure results in the creation of more than
 * one surface.  The additional surfaces are attached to the root
 * surface.  The complex structure can only be destroyed by
 * destroying the root.
 */
#define DDSCAPS_COMPLEX

/*
 * Indicates that this surface is a part of a surface flipping structure.
 * When it is passed to CreateSurface the DDSCAPS_FRONTBUFFER and
 * DDSCAP_BACKBUFFER bits are not set.  They are set by CreateSurface
 * on the resulting creations.  The dwBackBufferCount field in the
 * DDSURFACEDESC structure must be set to at least 1 in order for
 * the CreateSurface call to succeed.  The DDSCAPS_COMPLEX capability
 * must always be set with creating multiple surfaces through CreateSurface.
 */
#define DDSCAPS_FLIP

/*
 * Indicates that this surface is THE front buffer of a surface flipping
 * structure.  It is generally set by CreateSurface when the DDSCAPS_FLIP
 * capability bit is set.
 * If this capability is sent to CreateSurface then a standalonw front buffer
 * is created.  This surface will not have the DDSCAPS_FLIP capability.
 * It can be attached to other back buffers to form a flipping structure.
 * See AddAttachments for a detailed description of the behaviors in this
 * case.
 */
#define DDSCAPS_FRONTBUFFER

/*
 * Indicates that this surface is any offscreen surface that is not an overlay,
 * texture, zbuffer, front buffer, back buffer, or alpha surface.  It is used
 * to identify plain vanilla surfaces.
 */
#define DDSCAPS_OFFSCREENPLAIN

/*
 * Indicates that this surface is an overlay.  It may or may not be directly visible
 * depending on whether or not it is currently being overlayed onto the primary
 * surface.  DDSCAPS_VISIBLE can be used to determine whether or not it is being
 * overlayed at the moment.
 */
#define DDSCAPS_OVERLAY

/*
 * Indicates that unique DirectDrawPalette objects can be created and
 * attached to this surface.
 */
#define DDSCAPS_PALETTE

/*
 * Indicates that this surface is the primary surface.  The primary
 * surface represents what the user is seeing at the moment.
 */
#define DDSCAPS_PRIMARYSURFACE


/*
 * This flag used to be DDSCAPS_PRIMARYSURFACELEFT, which is now
 * obsolete.
 */
#define DDSCAPS_RESERVED3
#define DDSCAPS_PRIMARYSURFACELEFT

/*
 * Indicates that this surface memory was allocated in system memory
 */
#define DDSCAPS_SYSTEMMEMORY

/*
 * Indicates that this surface can be used as a 3D texture.  It does not
 * indicate whether or not the surface is being used for that purpose.
 */
#define DDSCAPS_TEXTURE

/*
 * Indicates that a surface may be a destination for 3D rendering.  This
 * bit must be set in order to query for a Direct3D Device Interface
 * from this surface.
 */
#define DDSCAPS_3DDEVICE

/*
 * Indicates that this surface exists in video memory.
 */
#define DDSCAPS_VIDEOMEMORY

/*
 * Indicates that changes made to this surface are immediately visible.
 * It is always set for the primary surface and is set for overlays while
 * they are being overlayed and texture maps while they are being textured.
 */
#define DDSCAPS_VISIBLE

/*
 * Indicates that only writes are permitted to the surface.  Read accesses
 * from the surface may or may not generate a protection fault, but the
 * results of a read from this surface will not be meaningful.  READ ONLY.
 */
#define DDSCAPS_WRITEONLY

/*
 * Indicates that this surface is a z buffer. A z buffer does not contain
 * displayable information.  Instead it contains bit depth information that is
 * used to determine which pixels are visible and which are obscured.
 */
#define DDSCAPS_ZBUFFER

/*
 * Indicates surface will have a DC associated long term
 */
#define DDSCAPS_OWNDC

/*
 * Indicates surface should be able to receive live video
 */
#define DDSCAPS_LIVEVIDEO

/*
 * Indicates surface should be able to have a stream decompressed
 * to it by the hardware.
 */
#define DDSCAPS_HWCODEC

/*
 * Surface is a ModeX surface.
 *
 */
#define DDSCAPS_MODEX

/*
 * Indicates surface is one level of a mip-map. This surface will
 * be attached to other DDSCAPS_MIPMAP surfaces to form the mip-map.
 * This can be done explicitly, by creating a number of surfaces and
 * attaching them with AddAttachedSurface or by implicitly by CreateSurface.
 * If this bit is set then DDSCAPS_TEXTURE must also be set.
 */
#define DDSCAPS_MIPMAP

/*
 * This bit is reserved. It should not be specified.
 */
#define DDSCAPS_RESERVED2


/*
 * Indicates that memory for the surface is not allocated until the surface
 * is loaded (via the Direct3D texture Load() function).
 */
#define DDSCAPS_ALLOCONLOAD

/*
 * Indicates that the surface will recieve data from a video port.
 */
#define DDSCAPS_VIDEOPORT

/*
 * Indicates that a video memory surface is resident in true, local video
 * memory rather than non-local video memory. If this flag is specified then
 * so must DDSCAPS_VIDEOMEMORY. This flag is mutually exclusive with
 * DDSCAPS_NONLOCALVIDMEM.
 */
#define DDSCAPS_LOCALVIDMEM

/*
 * Indicates that a video memory surface is resident in non-local video
 * memory rather than true, local video memory. If this flag is specified
 * then so must DDSCAPS_VIDEOMEMORY. This flag is mutually exclusive with
 * DDSCAPS_LOCALVIDMEM.
 */
#define DDSCAPS_NONLOCALVIDMEM

/*
 * Indicates that this surface is a standard VGA mode surface, and not a
 * ModeX surface. (This flag will never be set in combination with the
 * DDSCAPS_MODEX flag).
 */
#define DDSCAPS_STANDARDVGAMODE

/*
 * Indicates that this surface will be an optimized surface. This flag is
 * currently only valid in conjunction with the DDSCAPS_TEXTURE flag. The surface
 * will be created without any underlying video memory until loaded.
 */
#define DDSCAPS_OPTIMIZED



/*
 * This bit is reserved
 */
#define DDSCAPS2_RESERVED4
#define DDSCAPS2_HARDWAREDEINTERLACE

/*
 * Indicates to the driver that this surface will be locked very frequently
 * (for procedural textures, dynamic lightmaps, etc). Surfaces with this cap
 * set must also have DDSCAPS_TEXTURE. This cap cannot be used with
 * DDSCAPS2_HINTSTATIC and DDSCAPS2_OPAQUE.
 */
#define DDSCAPS2_HINTDYNAMIC

/*
 * Indicates to the driver that this surface can be re-ordered/retiled on
 * load. This operation will not change the size of the texture. It is
 * relatively fast and symmetrical, since the application may lock these
 * bits (although it will take a performance hit when doing so). Surfaces
 * with this cap set must also have DDSCAPS_TEXTURE. This cap cannot be
 * used with DDSCAPS2_HINTDYNAMIC and DDSCAPS2_OPAQUE.
 */
#define DDSCAPS2_HINTSTATIC

/*
 * Indicates that the client would like this texture surface to be managed by the
 * DirectDraw/Direct3D runtime. Surfaces with this cap set must also have
 * DDSCAPS_TEXTURE set.
 */
#define DDSCAPS2_TEXTUREMANAGE

/*
 * These bits are reserved for internal use */
#define DDSCAPS2_RESERVED1
#define DDSCAPS2_RESERVED2

/*
 * Indicates to the driver that this surface will never be locked again.
 * The driver is free to optimize this surface via retiling and actual compression.
 * All calls to Lock() or Blts from this surface will fail. Surfaces with this
 * cap set must also have DDSCAPS_TEXTURE. This cap cannot be used with
 * DDSCAPS2_HINTDYNAMIC and DDSCAPS2_HINTSTATIC.
 */
#define DDSCAPS2_OPAQUE

/*
 * Applications should set this bit at CreateSurface time to indicate that they
 * intend to use antialiasing. Only valid if DDSCAPS_3DDEVICE is also set.
 */
#define DDSCAPS2_HINTANTIALIASING


/*
 * This flag is used at CreateSurface time to indicate that this set of
 * surfaces is a cubic environment map
 */
#define DDSCAPS2_CUBEMAP

/*
 * These flags preform two functions:
 * - At CreateSurface time, they define which of the six cube faces are
 *   required by the application.
 * - After creation, each face in the cubemap will have exactly one of these
 *   bits set.
 */
#define DDSCAPS2_CUBEMAP_POSITIVEX
#define DDSCAPS2_CUBEMAP_NEGATIVEX
#define DDSCAPS2_CUBEMAP_POSITIVEY
#define DDSCAPS2_CUBEMAP_NEGATIVEY
#define DDSCAPS2_CUBEMAP_POSITIVEZ
#define DDSCAPS2_CUBEMAP_NEGATIVEZ

/*
 * This macro may be used to specify all faces of a cube map at CreateSurface time
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDSCAPS2_CUBEMAP_ALLFACES ( DDSCAPS2_CUBEMAP_POSITIVEX | DDSCAPS2_CUBEMAP_NEGATIVEX | DDSCAPS2_CUBEMAP_POSITIVEY | DDSCAPS2_CUBEMAP_NEGATIVEY | DDSCAPS2_CUBEMAP_POSITIVEZ | DDSCAPS2_CUBEMAP_NEGATIVEZ )
#define DDSCAPS2_CUBEMAP_ALLFACES


/*
 * This flag is an additional flag which is present on mipmap sublevels from DX7 onwards
 * It enables easier use of GetAttachedSurface rather than EnumAttachedSurfaces for surface
 * constructs such as Cube Maps, wherein there are more than one mipmap surface attached
 * to the root surface.
 * This caps bit is ignored by CreateSurface
 */
#define DDSCAPS2_MIPMAPSUBLEVEL

/* This flag indicates that the texture should be managed by D3D only */
#define DDSCAPS2_D3DTEXTUREMANAGE

/* This flag indicates that the managed surface can be safely lost */
#define DDSCAPS2_DONOTPERSIST

/* indicates that this surface is part of a stereo flipping chain */
#define DDSCAPS2_STEREOSURFACELEFT


/*
 * Indicates that the surface is a volume.
 * Can be combined with DDSCAPS_MIPMAP to indicate a multi-level volume
 */
#define DDSCAPS2_VOLUME

/*
 * Indicates that the surface may be locked multiple times by the application.
 * This cap cannot be used with DDSCAPS2_OPAQUE.
 */
#define DDSCAPS2_NOTUSERLOCKABLE

/*
 * Indicates that the vertex buffer data can be used to render points and
 * point sprites.
 */
#define DDSCAPS2_POINTS

/*
 * Indicates that the vertex buffer data can be used to render rt pactches.
 */
#define DDSCAPS2_RTPATCHES

/*
 * Indicates that the vertex buffer data can be used to render n patches.
 */
#define DDSCAPS2_NPATCHES

/*
 * This bit is reserved for internal use 
 */
#define DDSCAPS2_RESERVED3


/*
 * Indicates that the contents of the backbuffer do not have to be preserved
 * the contents of the backbuffer after they are presented.
 */
#define DDSCAPS2_DISCARDBACKBUFFER

/*
 * Indicates that all surfaces in this creation chain should be given an alpha channel.
 * This flag will be set on primary surface chains that may have no explicit pixel format
 * (and thus take on the format of the current display mode).
 * The driver should infer that all these surfaces have a format having an alpha channel.
 * (e.g. assume D3DFMT_A8R8G8B8 if the display mode is x888.)
 */
#define DDSCAPS2_ENABLEALPHACHANNEL

/*
 * Indicates that all surfaces in this creation chain is extended primary surface format.
 * This flag will be set on extended primary surface chains that always have explicit pixel
 * format and the pixel format is typically GDI (Graphics Device Interface) couldn't handle,
 * thus only used with fullscreen application. (e.g. D3DFMT_A2R10G10B10 format)
 */
#define DDSCAPS2_EXTENDEDFORMATPRIMARY

/*
 * Indicates that all surfaces in this creation chain is additional primary surface.
 * This flag will be set on primary surface chains which must present on the adapter
 * id provided on dwCaps4. Typically this will be used to create secondary primary surface
 * on DualView display adapter.
 */
#define DDSCAPS2_ADDITIONALPRIMARY

/*
 * This is a mask that indicates the set of bits that may be set
 * at createsurface time to indicate number of samples per pixel
 * when multisampling
 */
#define DDSCAPS3_MULTISAMPLE_MASK

/*
 * This is a mask that indicates the set of bits that may be set
 * at createsurface time to indicate the quality level of rendering
 * for the current number of samples per pixel
 */
#define DDSCAPS3_MULTISAMPLE_QUALITY_MASK
#define DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT

/*
 * This bit is reserved for internal use 
 */
#define DDSCAPS3_RESERVED1

/*
 * This bit is reserved for internal use 
 */
#define DDSCAPS3_RESERVED2

/*
 * This indicates whether this surface has light-weight miplevels
 */
#define DDSCAPS3_LIGHTWEIGHTMIPMAP

/*
 * This indicates that the mipsublevels for this surface are auto-generated
 */
#define DDSCAPS3_AUTOGENMIPMAP

/*
 * This indicates that the mipsublevels for this surface are auto-generated
 */
#define DDSCAPS3_DMAP


 /****************************************************************************
 *
 * DIRECTDRAW DRIVER CAPABILITY FLAGS
 *
 ****************************************************************************/

/*
 * Display hardware has 3D acceleration.
 */
#define DDCAPS_3D

/*
 * Indicates that DirectDraw will support only dest rectangles that are aligned
 * on DIRECTDRAWCAPS.dwAlignBoundaryDest boundaries of the surface, respectively.
 * READ ONLY.
 */
#define DDCAPS_ALIGNBOUNDARYDEST

/*
 * Indicates that DirectDraw will support only source rectangles  whose sizes in
 * BYTEs are DIRECTDRAWCAPS.dwAlignSizeDest multiples, respectively.  READ ONLY.
 */
#define DDCAPS_ALIGNSIZEDEST
/*
 * Indicates that DirectDraw will support only source rectangles that are aligned
 * on DIRECTDRAWCAPS.dwAlignBoundarySrc boundaries of the surface, respectively.
 * READ ONLY.
 */
#define DDCAPS_ALIGNBOUNDARYSRC

/*
 * Indicates that DirectDraw will support only source rectangles  whose sizes in
 * BYTEs are DIRECTDRAWCAPS.dwAlignSizeSrc multiples, respectively.  READ ONLY.
 */
#define DDCAPS_ALIGNSIZESRC

/*
 * Indicates that DirectDraw will create video memory surfaces that have a stride
 * alignment equal to DIRECTDRAWCAPS.dwAlignStride.  READ ONLY.
 */
#define DDCAPS_ALIGNSTRIDE

/*
 * Display hardware is capable of blt operations.
 */
#define DDCAPS_BLT

/*
 * Display hardware is capable of asynchronous blt operations.
 */
#define DDCAPS_BLTQUEUE

/*
 * Display hardware is capable of color space conversions during the blt operation.
 */
#define DDCAPS_BLTFOURCC

/*
 * Display hardware is capable of stretching during blt operations.
 */
#define DDCAPS_BLTSTRETCH

/*
 * Display hardware is shared with GDI.
 */
#define DDCAPS_GDI

/*
 * Display hardware can overlay.
 */
#define DDCAPS_OVERLAY

/*
 * Set if display hardware supports overlays but can not clip them.
 */
#define DDCAPS_OVERLAYCANTCLIP

/*
 * Indicates that overlay hardware is capable of color space conversions during
 * the overlay operation.
 */
#define DDCAPS_OVERLAYFOURCC

/*
 * Indicates that stretching can be done by the overlay hardware.
 */
#define DDCAPS_OVERLAYSTRETCH

/*
 * Indicates that unique DirectDrawPalettes can be created for DirectDrawSurfaces
 * other than the primary surface.
 */
#define DDCAPS_PALETTE

/*
 * Indicates that palette changes can be syncd with the veritcal refresh.
 */
#define DDCAPS_PALETTEVSYNC

/*
 * Display hardware can return the current scan line.
 */
#define DDCAPS_READSCANLINE


/*
 * This flag used to bo DDCAPS_STEREOVIEW, which is now obsolete
 */
#define DDCAPS_RESERVED1

/*
 * Display hardware is capable of generating a vertical blank interrupt.
 */
#define DDCAPS_VBI

/*
 * Supports the use of z buffers with blt operations.
 */
#define DDCAPS_ZBLTS

/*
 * Supports Z Ordering of overlays.
 */
#define DDCAPS_ZOVERLAYS

/*
 * Supports color key
 */
#define DDCAPS_COLORKEY

/*
 * Supports alpha surfaces
 */
#define DDCAPS_ALPHA

/*
 * colorkey is hardware assisted(DDCAPS_COLORKEY will also be set)
 */
#define DDCAPS_COLORKEYHWASSIST

/*
 * no hardware support at all
 */
#define DDCAPS_NOHARDWARE

/*
 * Display hardware is capable of color fill with bltter
 */
#define DDCAPS_BLTCOLORFILL

/*
 * Display hardware is bank switched, and potentially very slow at
 * random access to VRAM.
 */
#define DDCAPS_BANKSWITCHED

/*
 * Display hardware is capable of depth filling Z-buffers with bltter
 */
#define DDCAPS_BLTDEPTHFILL

/*
 * Display hardware is capable of clipping while bltting.
 */
#define DDCAPS_CANCLIP

/*
 * Display hardware is capable of clipping while stretch bltting.
 */
#define DDCAPS_CANCLIPSTRETCHED

/*
 * Display hardware is capable of bltting to or from system memory
 */
#define DDCAPS_CANBLTSYSMEM


 /****************************************************************************
 *
 * MORE DIRECTDRAW DRIVER CAPABILITY FLAGS (dwCaps2)
 *
 ****************************************************************************/

/*
 * Display hardware is certified
 */
#define DDCAPS2_CERTIFIED

/*
 * Driver cannot interleave 2D operations (lock and blt) to surfaces with
 * Direct3D rendering operations between calls to BeginScene() and EndScene()
 */
#define DDCAPS2_NO2DDURING3DSCENE

/*
 * Display hardware contains a video port
 */
#define DDCAPS2_VIDEOPORT

/*
 * The overlay can be automatically flipped according to the video port
 * VSYNCs, providing automatic doubled buffered display of video port
 * data using an overlay
 */
#define DDCAPS2_AUTOFLIPOVERLAY

/*
 * Overlay can display each field of interlaced data individually while
 * it is interleaved in memory without causing jittery artifacts.
 */
#define DDCAPS2_CANBOBINTERLEAVED

/*
 * Overlay can display each field of interlaced data individually while
 * it is not interleaved in memory without causing jittery artifacts.
 */
#define DDCAPS2_CANBOBNONINTERLEAVED

/*
 * The overlay surface contains color controls (brightness, sharpness, etc.)
 */
#define DDCAPS2_COLORCONTROLOVERLAY

/*
 * The primary surface contains color controls (gamma, etc.)
 */
#define DDCAPS2_COLORCONTROLPRIMARY

/*
 * RGBZ -> RGB supported for 16:16 RGB:Z
 */
#define DDCAPS2_CANDROPZ16BIT

/*
 * Driver supports non-local video memory.
 */
#define DDCAPS2_NONLOCALVIDMEM

/*
 * Dirver supports non-local video memory but has different capabilities for
 * non-local video memory surfaces. If this bit is set then so must
 * DDCAPS2_NONLOCALVIDMEM.
 */
#define DDCAPS2_NONLOCALVIDMEMCAPS

/*
 * Driver neither requires nor prefers surfaces to be pagelocked when performing
 * blts involving system memory surfaces
 */
#define DDCAPS2_NOPAGELOCKREQUIRED

/*
 * Driver can create surfaces which are wider than the primary surface
 */
#define DDCAPS2_WIDESURFACES

/*
 * Driver supports bob without using a video port by handling the
 * DDFLIP_ODD and DDFLIP_EVEN flags specified in Flip.
 */
#define DDCAPS2_CANFLIPODDEVEN

/*
 * Driver supports bob using hardware
 */
#define DDCAPS2_CANBOBHARDWARE

/*
 * Driver supports bltting any FOURCC surface to another surface of the same FOURCC
 */
#define DDCAPS2_COPYFOURCC


/*
 * Driver supports loadable gamma ramps for the primary surface
 */
#define DDCAPS2_PRIMARYGAMMA

/*
 * Driver can render in windowed mode.
 */
#define DDCAPS2_CANRENDERWINDOWED

/*
 * A calibrator is available to adjust the gamma ramp according to the
 * physical display properties so that the result will be identical on
 * all calibrated systems.
 */
#define DDCAPS2_CANCALIBRATEGAMMA

/*
 * Indicates that the driver will respond to DDFLIP_INTERVALn flags
 */
#define DDCAPS2_FLIPINTERVAL

/*
 * Indicates that the driver will respond to DDFLIP_NOVSYNC
 */
#define DDCAPS2_FLIPNOVSYNC

/*
 * Driver supports management of video memory, if this flag is ON,
 * driver manages the texture if requested with DDSCAPS2_TEXTUREMANAGE on
 * DirectX manages the texture if this flag is OFF and surface has DDSCAPS2_TEXTUREMANAGE on
 */
#define DDCAPS2_CANMANAGETEXTURE

/*
 * The Direct3D texture manager uses this cap to decide whether to put managed
 * surfaces in non-local video memory. If the cap is set, the texture manager will
 * put managed surfaces in non-local vidmem. Drivers that cannot texture from
 * local vidmem SHOULD NOT set this cap.
 */
#define DDCAPS2_TEXMANINNONLOCALVIDMEM

/*
 * Indicates that the driver supports DX7 type of stereo in at least one mode (which may
 * not necessarily be the current mode). Applications should use IDirectDraw7 (or higher)
 * ::EnumDisplayModes and check the DDSURFACEDESC.ddsCaps.dwCaps2 field for the presence of
 * DDSCAPS2_STEREOSURFACELEFT to check if a particular mode supports stereo. The application
 * can also use IDirectDraw7(or higher)::GetDisplayMode to check the current mode.
 */
#define DDCAPS2_STEREO

/*
 * This caps bit is intended for internal DirectDraw use.
 * -It is only valid if DDCAPS2_NONLOCALVIDMEMCAPS is set.
 * -If this bit is set, then DDCAPS_CANBLTSYSMEM MUST be set by the driver (and
 *  all the assoicated system memory blt caps must be correct).
 * -It implies that the system->video blt caps in DDCAPS also apply to system to
 *  nonlocal blts. I.e. the dwSVBCaps, dwSVBCKeyCaps, dwSVBFXCaps and dwSVBRops
 *  members of DDCAPS (DDCORECAPS) are filled in correctly.
 * -Any blt from system to nonlocal memory that matches these caps bits will
 *  be passed to the driver.
 *
 * NOTE: This is intended to enable the driver itself to do efficient reordering
 * of textures. This is NOT meant to imply that hardware can write into AGP memory.
 * This operation is not currently supported.
 */
#define DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL

/*
 * was DDCAPS2_PUREHAL
 */
#define DDCAPS2_RESERVED1

/*
 * Driver supports management of video memory, if this flag is ON,
 * driver manages the resource if requested with DDSCAPS2_TEXTUREMANAGE on
 * DirectX manages the resource if this flag is OFF and surface has DDSCAPS2_TEXTUREMANAGE on
 */
#define DDCAPS2_CANMANAGERESOURCE

/*
 * Driver supports dynamic textures. This will allow the application to set
 * D3DUSAGE_DYNAMIC (DDSCAPS2_HINTDYNAMIC for drivers) at texture create time.
 * Video memory dynamic textures WILL be lockable by applications. It is
 * expected that these locks will be very efficient (which implies that the
 * driver should always maintain a linear copy, a pointer to which can be
 * quickly handed out to the application).
 */
#define DDCAPS2_DYNAMICTEXTURES

/*
 * Driver supports auto-generation of mipmaps.
 */
#define DDCAPS2_CANAUTOGENMIPMAP


/****************************************************************************
 *
 * DIRECTDRAW FX ALPHA CAPABILITY FLAGS
 *
 ****************************************************************************/

/*
 * Supports alpha blending around the edge of a source color keyed surface.
 * For Blt.
 */
#define DDFXALPHACAPS_BLTALPHAEDGEBLEND

/*
 * Supports alpha information in the pixel format.  The bit depth of alpha
 * information in the pixel format can be 1,2,4, or 8.  The alpha value becomes
 * more opaque as the alpha value increases.  (0 is transparent.)
 * For Blt.
 */
#define DDFXALPHACAPS_BLTALPHAPIXELS

/*
 * Supports alpha information in the pixel format.  The bit depth of alpha
 * information in the pixel format can be 1,2,4, or 8.  The alpha value
 * becomes more transparent as the alpha value increases.  (0 is opaque.)
 * This flag can only be set if DDCAPS_ALPHA is set.
 * For Blt.
 */
#define DDFXALPHACAPS_BLTALPHAPIXELSNEG

/*
 * Supports alpha only surfaces.  The bit depth of an alpha only surface can be
 * 1,2,4, or 8.  The alpha value becomes more opaque as the alpha value increases.
 * (0 is transparent.)
 * For Blt.
 */
#define DDFXALPHACAPS_BLTALPHASURFACES

/*
 * The depth of the alpha channel data can range can be 1,2,4, or 8.
 * The NEG suffix indicates that this alpha channel becomes more transparent
 * as the alpha value increases. (0 is opaque.)  This flag can only be set if
 * DDCAPS_ALPHA is set.
 * For Blt.
 */
#define DDFXALPHACAPS_BLTALPHASURFACESNEG

/*
 * Supports alpha blending around the edge of a source color keyed surface.
 * For Overlays.
 */
#define DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND

/*
 * Supports alpha information in the pixel format.  The bit depth of alpha
 * information in the pixel format can be 1,2,4, or 8.  The alpha value becomes
 * more opaque as the alpha value increases.  (0 is transparent.)
 * For Overlays.
 */
#define DDFXALPHACAPS_OVERLAYALPHAPIXELS

/*
 * Supports alpha information in the pixel format.  The bit depth of alpha
 * information in the pixel format can be 1,2,4, or 8.  The alpha value
 * becomes more transparent as the alpha value increases.  (0 is opaque.)
 * This flag can only be set if DDCAPS_ALPHA is set.
 * For Overlays.
 */
#define DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG

/*
 * Supports alpha only surfaces.  The bit depth of an alpha only surface can be
 * 1,2,4, or 8.  The alpha value becomes more opaque as the alpha value increases.
 * (0 is transparent.)
 * For Overlays.
 */
#define DDFXALPHACAPS_OVERLAYALPHASURFACES

/*
 * The depth of the alpha channel data can range can be 1,2,4, or 8.
 * The NEG suffix indicates that this alpha channel becomes more transparent
 * as the alpha value increases. (0 is opaque.)  This flag can only be set if
 * DDCAPS_ALPHA is set.
 * For Overlays.
 */
#define DDFXALPHACAPS_OVERLAYALPHASURFACESNEG

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTDRAW_VERSION < 0x0600
#endif //DIRECTDRAW_VERSION


/****************************************************************************
 *
 * DIRECTDRAW FX CAPABILITY FLAGS
 *
 ****************************************************************************/

/*
 * Uses arithmetic operations to stretch and shrink surfaces during blt
 * rather than pixel doubling techniques.  Along the Y axis.
 */
#define DDFXCAPS_BLTARITHSTRETCHY

/*
 * Uses arithmetic operations to stretch during blt
 * rather than pixel doubling techniques.  Along the Y axis. Only
 * works for x1, x2, etc.
 */
#define DDFXCAPS_BLTARITHSTRETCHYN

/*
 * Supports mirroring left to right in blt.
 */
#define DDFXCAPS_BLTMIRRORLEFTRIGHT

/*
 * Supports mirroring top to bottom in blt.
 */
#define DDFXCAPS_BLTMIRRORUPDOWN

/*
 * Supports arbitrary rotation for blts.
 */
#define DDFXCAPS_BLTROTATION

/*
 * Supports 90 degree rotations for blts.
 */
#define DDFXCAPS_BLTROTATION90

/*
 * DirectDraw supports arbitrary shrinking of a surface along the
 * x axis (horizontal direction) for blts.
 */
#define DDFXCAPS_BLTSHRINKX

/*
 * DirectDraw supports integer shrinking (1x,2x,) of a surface
 * along the x axis (horizontal direction) for blts.
 */
#define DDFXCAPS_BLTSHRINKXN

/*
 * DirectDraw supports arbitrary shrinking of a surface along the
 * y axis (horizontal direction) for blts.
 */
#define DDFXCAPS_BLTSHRINKY

/*
 * DirectDraw supports integer shrinking (1x,2x,) of a surface
 * along the y axis (vertical direction) for blts.
 */
#define DDFXCAPS_BLTSHRINKYN

/*
 * DirectDraw supports arbitrary stretching of a surface along the
 * x axis (horizontal direction) for blts.
 */
#define DDFXCAPS_BLTSTRETCHX

/*
 * DirectDraw supports integer stretching (1x,2x,) of a surface
 * along the x axis (horizontal direction) for blts.
 */
#define DDFXCAPS_BLTSTRETCHXN

/*
 * DirectDraw supports arbitrary stretching of a surface along the
 * y axis (horizontal direction) for blts.
 */
#define DDFXCAPS_BLTSTRETCHY

/*
 * DirectDraw supports integer stretching (1x,2x,) of a surface
 * along the y axis (vertical direction) for blts.
 */
#define DDFXCAPS_BLTSTRETCHYN

/*
 * Uses arithmetic operations to stretch and shrink surfaces during
 * overlay rather than pixel doubling techniques.  Along the Y axis
 * for overlays.
 */
#define DDFXCAPS_OVERLAYARITHSTRETCHY

/*
 * Uses arithmetic operations to stretch surfaces during
 * overlay rather than pixel doubling techniques.  Along the Y axis
 * for overlays. Only works for x1, x2, etc.
 */
#define DDFXCAPS_OVERLAYARITHSTRETCHYN

/*
 * DirectDraw supports arbitrary shrinking of a surface along the
 * x axis (horizontal direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSHRINKX

/*
 * DirectDraw supports integer shrinking (1x,2x,) of a surface
 * along the x axis (horizontal direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSHRINKXN

/*
 * DirectDraw supports arbitrary shrinking of a surface along the
 * y axis (horizontal direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSHRINKY

/*
 * DirectDraw supports integer shrinking (1x,2x,) of a surface
 * along the y axis (vertical direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSHRINKYN

/*
 * DirectDraw supports arbitrary stretching of a surface along the
 * x axis (horizontal direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSTRETCHX

/*
 * DirectDraw supports integer stretching (1x,2x,) of a surface
 * along the x axis (horizontal direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSTRETCHXN

/*
 * DirectDraw supports arbitrary stretching of a surface along the
 * y axis (horizontal direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSTRETCHY

/*
 * DirectDraw supports integer stretching (1x,2x,) of a surface
 * along the y axis (vertical direction) for overlays.
 */
#define DDFXCAPS_OVERLAYSTRETCHYN

/*
 * DirectDraw supports mirroring of overlays across the vertical axis
 */
#define DDFXCAPS_OVERLAYMIRRORLEFTRIGHT

/*
 * DirectDraw supports mirroring of overlays across the horizontal axis
 */
#define DDFXCAPS_OVERLAYMIRRORUPDOWN

/*
 * DirectDraw supports deinterlacing of overlay surfaces
 */
#define DDFXCAPS_OVERLAYDEINTERLACE

/*
 * Driver can do alpha blending for blits.
 */
#define DDFXCAPS_BLTALPHA


/*
 * Driver can do surface-reconstruction filtering for warped blits.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_BLTFILTER DDFXCAPS_BLTARITHSTRETCHY
#define DDFXCAPS_BLTFILTER

/*
 * Driver can do alpha blending for overlays.
 */
#define DDFXCAPS_OVERLAYALPHA


/*
 * Driver can do surface-reconstruction filtering for warped overlays.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_OVERLAYFILTER DDFXCAPS_OVERLAYARITHSTRETCHY
#define DDFXCAPS_OVERLAYFILTER

/****************************************************************************
 *
 * DIRECTDRAW STEREO VIEW CAPABILITIES
 *
 ****************************************************************************/

/*
 * This flag used to be DDSVCAPS_ENIGMA, which is now obsolete
 */

#define DDSVCAPS_RESERVED1

/*
 * This flag used to be DDSVCAPS_FLICKER, which is now obsolete
 */
#define DDSVCAPS_RESERVED2

/*
 * This flag used to be DDSVCAPS_REDBLUE, which is now obsolete
 */
#define DDSVCAPS_RESERVED3

/*
 * This flag used to be DDSVCAPS_SPLIT, which is now obsolete
 */
#define DDSVCAPS_RESERVED4

/*
 * The stereo view is accomplished with switching technology
 */

#define DDSVCAPS_STEREOSEQUENTIAL



/****************************************************************************
 *
 * DIRECTDRAWPALETTE CAPABILITIES
 *
 ****************************************************************************/

/*
 * Index is 4 bits.  There are sixteen color entries in the palette table.
 */
#define DDPCAPS_4BIT

/*
 * Index is onto a 8 bit color index.  This field is only valid with the
 * DDPCAPS_1BIT, DDPCAPS_2BIT or DDPCAPS_4BIT capability and the target
 * surface is in 8bpp. Each color entry is one byte long and is an index
 * into destination surface's 8bpp palette.
 */
#define DDPCAPS_8BITENTRIES

/*
 * Index is 8 bits.  There are 256 color entries in the palette table.
 */
#define DDPCAPS_8BIT

/*
 * Indicates that this DIRECTDRAWPALETTE should use the palette color array
 * passed into the lpDDColorArray parameter to initialize the DIRECTDRAWPALETTE
 * object.
 * This flag is obsolete. DirectDraw always initializes the color array from
 * the lpDDColorArray parameter. The definition remains for source-level
 * compatibility.
 */
#define DDPCAPS_INITIALIZE

/*
 * This palette is the one attached to the primary surface.  Changing this
 * table has immediate effect on the display unless DDPSETPAL_VSYNC is specified
 * and supported.
 */
#define DDPCAPS_PRIMARYSURFACE

/*
 * This palette is the one attached to the primary surface left.  Changing
 * this table has immediate effect on the display for the left eye unless
 * DDPSETPAL_VSYNC is specified and supported.
 */
#define DDPCAPS_PRIMARYSURFACELEFT

/*
 * This palette can have all 256 entries defined
 */
#define DDPCAPS_ALLOW256

/*
 * This palette can have modifications to it synced with the monitors
 * refresh rate.
 */
#define DDPCAPS_VSYNC

/*
 * Index is 1 bit.  There are two color entries in the palette table.
 */
#define DDPCAPS_1BIT

/*
 * Index is 2 bit.  There are four color entries in the palette table.
 */
#define DDPCAPS_2BIT

/*
 * The peFlags member of PALETTEENTRY denotes an 8 bit alpha value
 */
#define DDPCAPS_ALPHA


/****************************************************************************
 *
 * DIRECTDRAWPALETTE SETENTRY CONSTANTS
 *
 ****************************************************************************/


/****************************************************************************
 *
 * DIRECTDRAWPALETTE GETENTRY CONSTANTS
 *
 ****************************************************************************/

/* 0 is the only legal value */

/****************************************************************************
 *
 * DIRECTDRAWSURFACE SETPRIVATEDATA CONSTANTS
 *
 ****************************************************************************/

/*
 * The passed pointer is an IUnknown ptr. The cbData argument to SetPrivateData
 * must be set to sizeof(IUnknown*). DirectDraw will call AddRef through this
 * pointer and Release when the private data is destroyed. This includes when
 * the surface or palette is destroyed before such priovate data is destroyed.
 */
#define DDSPD_IUNKNOWNPOINTER

/*
 * Private data is only valid for the current state of the object,
 * as determined by the uniqueness value.
 */
#define DDSPD_VOLATILE


/****************************************************************************
 *
 * DIRECTDRAWSURFACE SETPALETTE CONSTANTS
 *
 ****************************************************************************/


/****************************************************************************
 *
 * DIRECTDRAW BITDEPTH CONSTANTS
 *
 * NOTE:  These are only used to indicate supported bit depths.   These
 * are flags only, they are not to be used as an actual bit depth.   The
 * absolute numbers 1, 2, 4, 8, 16, 24 and 32 are used to indicate actual
 * bit depths in a surface or for changing the display mode.
 *
 ****************************************************************************/

/*
 * 1 bit per pixel.
 */
#define DDBD_1

/*
 * 2 bits per pixel.
 */
#define DDBD_2

/*
 * 4 bits per pixel.
 */
#define DDBD_4

/*
 * 8 bits per pixel.
 */
#define DDBD_8

/*
 * 16 bits per pixel.
 */
#define DDBD_16

/*
 * 24 bits per pixel.
 */
#define DDBD_24

/*
 * 32 bits per pixel.
 */
#define DDBD_32

/****************************************************************************
 *
 * DIRECTDRAWSURFACE SET/GET COLOR KEY FLAGS
 *
 ****************************************************************************/

/*
 * Set if the structure contains a color space.  Not set if the structure
 * contains a single color key.
 */
#define DDCKEY_COLORSPACE

/*
 * Set if the structure specifies a color key or color space which is to be
 * used as a destination color key for blt operations.
 */
#define DDCKEY_DESTBLT

/*
 * Set if the structure specifies a color key or color space which is to be
 * used as a destination color key for overlay operations.
 */
#define DDCKEY_DESTOVERLAY

/*
 * Set if the structure specifies a color key or color space which is to be
 * used as a source color key for blt operations.
 */
#define DDCKEY_SRCBLT

/*
 * Set if the structure specifies a color key or color space which is to be
 * used as a source color key for overlay operations.
 */
#define DDCKEY_SRCOVERLAY


/****************************************************************************
 *
 * DIRECTDRAW COLOR KEY CAPABILITY FLAGS
 *
 ****************************************************************************/

/*
 * Supports transparent blting using a color key to identify the replaceable
 * bits of the destination surface for RGB colors.
 */
#define DDCKEYCAPS_DESTBLT

/*
 * Supports transparent blting using a color space to identify the replaceable
 * bits of the destination surface for RGB colors.
 */
#define DDCKEYCAPS_DESTBLTCLRSPACE

/*
 * Supports transparent blting using a color space to identify the replaceable
 * bits of the destination surface for YUV colors.
 */
#define DDCKEYCAPS_DESTBLTCLRSPACEYUV

/*
 * Supports transparent blting using a color key to identify the replaceable
 * bits of the destination surface for YUV colors.
 */
#define DDCKEYCAPS_DESTBLTYUV

/*
 * Supports overlaying using colorkeying of the replaceable bits of the surface
 * being overlayed for RGB colors.
 */
#define DDCKEYCAPS_DESTOVERLAY

/*
 * Supports a color space as the color key for the destination for RGB colors.
 */
#define DDCKEYCAPS_DESTOVERLAYCLRSPACE

/*
 * Supports a color space as the color key for the destination for YUV colors.
 */
#define DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV

/*
 * Supports only one active destination color key value for visible overlay
 * surfaces.
 */
#define DDCKEYCAPS_DESTOVERLAYONEACTIVE

/*
 * Supports overlaying using colorkeying of the replaceable bits of the
 * surface being overlayed for YUV colors.
 */
#define DDCKEYCAPS_DESTOVERLAYYUV

/*
 * Supports transparent blting using the color key for the source with
 * this surface for RGB colors.
 */
#define DDCKEYCAPS_SRCBLT

/*
 * Supports transparent blting using a color space for the source with
 * this surface for RGB colors.
 */
#define DDCKEYCAPS_SRCBLTCLRSPACE

/*
 * Supports transparent blting using a color space for the source with
 * this surface for YUV colors.
 */
#define DDCKEYCAPS_SRCBLTCLRSPACEYUV

/*
 * Supports transparent blting using the color key for the source with
 * this surface for YUV colors.
 */
#define DDCKEYCAPS_SRCBLTYUV

/*
 * Supports overlays using the color key for the source with this
 * overlay surface for RGB colors.
 */
#define DDCKEYCAPS_SRCOVERLAY

/*
 * Supports overlays using a color space as the source color key for
 * the overlay surface for RGB colors.
 */
#define DDCKEYCAPS_SRCOVERLAYCLRSPACE

/*
 * Supports overlays using a color space as the source color key for
 * the overlay surface for YUV colors.
 */
#define DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV

/*
 * Supports only one active source color key value for visible
 * overlay surfaces.
 */
#define DDCKEYCAPS_SRCOVERLAYONEACTIVE

/*
 * Supports overlays using the color key for the source with this
 * overlay surface for YUV colors.
 */
#define DDCKEYCAPS_SRCOVERLAYYUV

/*
 * there are no bandwidth trade-offs for using colorkey with an overlay
 */
#define DDCKEYCAPS_NOCOSTOVERLAY


/****************************************************************************
 *
 * DIRECTDRAW PIXELFORMAT FLAGS
 *
 ****************************************************************************/

/*
 * The surface has alpha channel information in the pixel format.
 */
#define DDPF_ALPHAPIXELS

/*
 * The pixel format contains alpha only information
 */
#define DDPF_ALPHA

/*
 * The FourCC code is valid.
 */
#define DDPF_FOURCC

/*
 * The surface is 4-bit color indexed.
 */
#define DDPF_PALETTEINDEXED4

/*
 * The surface is indexed into a palette which stores indices
 * into the destination surface's 8-bit palette.
 */
#define DDPF_PALETTEINDEXEDTO8

/*
 * The surface is 8-bit color indexed.
 */
#define DDPF_PALETTEINDEXED8

/*
 * The RGB data in the pixel format structure is valid.
 */
#define DDPF_RGB

/*
 * The surface will accept pixel data in the format specified
 * and compress it during the write.
 */
#define DDPF_COMPRESSED

/*
 * The surface will accept RGB data and translate it during
 * the write to YUV data.  The format of the data to be written
 * will be contained in the pixel format structure.  The DDPF_RGB
 * flag will be set.
 */
#define DDPF_RGBTOYUV

/*
 * pixel format is YUV - YUV data in pixel format struct is valid
 */
#define DDPF_YUV

/*
 * pixel format is a z buffer only surface
 */
#define DDPF_ZBUFFER

/*
 * The surface is 1-bit color indexed.
 */
#define DDPF_PALETTEINDEXED1

/*
 * The surface is 2-bit color indexed.
 */
#define DDPF_PALETTEINDEXED2

/*
 * The surface contains Z information in the pixels
 */
#define DDPF_ZPIXELS

/*
 * The surface contains stencil information along with Z
 */
#define DDPF_STENCILBUFFER

/*
 * Premultiplied alpha format -- the color components have been
 * premultiplied by the alpha component.
 */
#define DDPF_ALPHAPREMULT


/*
 * Luminance data in the pixel format is valid.
 * Use this flag for luminance-only or luminance+alpha surfaces,
 * the bit depth is then ddpf.dwLuminanceBitCount.
 */
#define DDPF_LUMINANCE

/*
 * Luminance data in the pixel format is valid.
 * Use this flag when hanging luminance off bumpmap surfaces,
 * the bit mask for the luminance portion of the pixel is then
 * ddpf.dwBumpLuminanceBitMask
 */
#define DDPF_BUMPLUMINANCE

/*
 * Bump map dUdV data in the pixel format is valid.
 */
#define DDPF_BUMPDUDV


/*===========================================================================
 *
 *
 * DIRECTDRAW CALLBACK FLAGS
 *
 *
 *==========================================================================*/

/****************************************************************************
 *
 * DIRECTDRAW ENUMSURFACES FLAGS
 *
 ****************************************************************************/

/*
 * Enumerate all of the surfaces that meet the search criterion.
 */
#define DDENUMSURFACES_ALL

/*
 * A search hit is a surface that matches the surface description.
 */
#define DDENUMSURFACES_MATCH

/*
 * A search hit is a surface that does not match the surface description.
 */
#define DDENUMSURFACES_NOMATCH

/*
 * Enumerate the first surface that can be created which meets the search criterion.
 */
#define DDENUMSURFACES_CANBECREATED

/*
 * Enumerate the surfaces that already exist that meet the search criterion.
 */
#define DDENUMSURFACES_DOESEXIST


/****************************************************************************
 *
 * DIRECTDRAW SETDISPLAYMODE FLAGS
 *
 ****************************************************************************/

/*
 * The desired mode is a standard VGA mode
 */
#define DDSDM_STANDARDVGAMODE


/****************************************************************************
 *
 * DIRECTDRAW ENUMDISPLAYMODES FLAGS
 *
 ****************************************************************************/

/*
 * Enumerate Modes with different refresh rates.  EnumDisplayModes guarantees
 * that a particular mode will be enumerated only once.  This flag specifies whether
 * the refresh rate is taken into account when determining if a mode is unique.
 */
#define DDEDM_REFRESHRATES

/*
 * Enumerate VGA modes. Specify this flag if you wish to enumerate supported VGA
 * modes such as mode 0x13 in addition to the usual ModeX modes (which are always
 * enumerated if the application has previously called SetCooperativeLevel with the
 * DDSCL_ALLOWMODEX flag set).
 */
#define DDEDM_STANDARDVGAMODES


/****************************************************************************
 *
 * DIRECTDRAW SETCOOPERATIVELEVEL FLAGS
 *
 ****************************************************************************/

/*
 * Exclusive mode owner will be responsible for the entire primary surface.
 * GDI can be ignored. used with DD
 */
#define DDSCL_FULLSCREEN

/*
 * allow CTRL_ALT_DEL to work while in fullscreen exclusive mode
 */
#define DDSCL_ALLOWREBOOT

/*
 * prevents DDRAW from modifying the application window.
 * prevents DDRAW from minimize/restore the application window on activation.
 */
#define DDSCL_NOWINDOWCHANGES

/*
 * app wants to work as a regular Windows application
 */
#define DDSCL_NORMAL

/*
 * app wants exclusive access
 */
#define DDSCL_EXCLUSIVE


/*
 * app can deal with non-windows display modes
 */
#define DDSCL_ALLOWMODEX

/*
 * this window will receive the focus messages
 */
#define DDSCL_SETFOCUSWINDOW

/*
 * this window is associated with the DDRAW object and will
 * cover the screen in fullscreen mode
 */
#define DDSCL_SETDEVICEWINDOW

/*
 * app wants DDRAW to create a window to be associated with the
 * DDRAW object
 */
#define DDSCL_CREATEDEVICEWINDOW

/*
 * App explicitly asks DDRAW/D3D to be multithread safe. This makes D3D
 * take the global crtisec more frequently.
 */
#define DDSCL_MULTITHREADED

/*
 * App specifies that it would like to keep the FPU set up for optimal Direct3D
 * performance (single precision and exceptions disabled) so Direct3D
 * does not need to explicitly set the FPU each time. This is assumed by
 * default in DirectX 7. See also DDSCL_FPUPRESERVE
 */
#define DDSCL_FPUSETUP

/*
 * App specifies that it needs either double precision FPU or FPU exceptions
 * enabled. This makes Direct3D explicitly set the FPU state eah time it is
 * called. Setting the flag will reduce Direct3D performance. The flag is
 * assumed by default in DirectX 6 and earlier. See also DDSCL_FPUSETUP
 */
#define DDSCL_FPUPRESERVE


/****************************************************************************
 *
 * DIRECTDRAW BLT FLAGS
 *
 ****************************************************************************/

/*
 * Use the alpha information in the pixel format or the alpha channel surface
 * attached to the destination surface as the alpha channel for this blt.
 */
#define DDBLT_ALPHADEST

/*
 * Use the dwConstAlphaDest field in the DDBLTFX structure as the alpha channel
 * for the destination surface for this blt.
 */
#define DDBLT_ALPHADESTCONSTOVERRIDE

/*
 * The NEG suffix indicates that the destination surface becomes more
 * transparent as the alpha value increases. (0 is opaque)
 */
#define DDBLT_ALPHADESTNEG

/*
 * Use the lpDDSAlphaDest field in the DDBLTFX structure as the alpha
 * channel for the destination for this blt.
 */
#define DDBLT_ALPHADESTSURFACEOVERRIDE

/*
 * Use the dwAlphaEdgeBlend field in the DDBLTFX structure as the alpha channel
 * for the edges of the image that border the color key colors.
 */
#define DDBLT_ALPHAEDGEBLEND

/*
 * Use the alpha information in the pixel format or the alpha channel surface
 * attached to the source surface as the alpha channel for this blt.
 */
#define DDBLT_ALPHASRC

/*
 * Use the dwConstAlphaSrc field in the DDBLTFX structure as the alpha channel
 * for the source for this blt.
 */
#define DDBLT_ALPHASRCCONSTOVERRIDE

/*
 * The NEG suffix indicates that the source surface becomes more transparent
 * as the alpha value increases. (0 is opaque)
 */
#define DDBLT_ALPHASRCNEG

/*
 * Use the lpDDSAlphaSrc field in the DDBLTFX structure as the alpha channel
 * for the source for this blt.
 */
#define DDBLT_ALPHASRCSURFACEOVERRIDE

/*
 * Do this blt asynchronously through the FIFO in the order received.  If
 * there is no room in the hardware FIFO fail the call.
 */
#define DDBLT_ASYNC

/*
 * Uses the dwFillColor field in the DDBLTFX structure as the RGB color
 * to fill the destination rectangle on the destination surface with.
 */
#define DDBLT_COLORFILL

/*
 * Uses the dwDDFX field in the DDBLTFX structure to specify the effects
 * to use for the blt.
 */
#define DDBLT_DDFX

/*
 * Uses the dwDDROPS field in the DDBLTFX structure to specify the ROPS
 * that are not part of the Win32 API.
 */
#define DDBLT_DDROPS

/*
 * Use the color key associated with the destination surface.
 */
#define DDBLT_KEYDEST

/*
 * Use the dckDestColorkey field in the DDBLTFX structure as the color key
 * for the destination surface.
 */
#define DDBLT_KEYDESTOVERRIDE

/*
 * Use the color key associated with the source surface.
 */
#define DDBLT_KEYSRC

/*
 * Use the dckSrcColorkey field in the DDBLTFX structure as the color key
 * for the source surface.
 */
#define DDBLT_KEYSRCOVERRIDE

/*
 * Use the dwROP field in the DDBLTFX structure for the raster operation
 * for this blt.  These ROPs are the same as the ones defined in the Win32 API.
 */
#define DDBLT_ROP

/*
 * Use the dwRotationAngle field in the DDBLTFX structure as the angle
 * (specified in 1/100th of a degree) to rotate the surface.
 */
#define DDBLT_ROTATIONANGLE

/*
 * Z-buffered blt using the z-buffers attached to the source and destination
 * surfaces and the dwZBufferOpCode field in the DDBLTFX structure as the
 * z-buffer opcode.
 */
#define DDBLT_ZBUFFER

/*
 * Z-buffered blt using the dwConstDest Zfield and the dwZBufferOpCode field
 * in the DDBLTFX structure as the z-buffer and z-buffer opcode respectively
 * for the destination.
 */
#define DDBLT_ZBUFFERDESTCONSTOVERRIDE

/*
 * Z-buffered blt using the lpDDSDestZBuffer field and the dwZBufferOpCode
 * field in the DDBLTFX structure as the z-buffer and z-buffer opcode
 * respectively for the destination.
 */
#define DDBLT_ZBUFFERDESTOVERRIDE

/*
 * Z-buffered blt using the dwConstSrcZ field and the dwZBufferOpCode field
 * in the DDBLTFX structure as the z-buffer and z-buffer opcode respectively
 * for the source.
 */
#define DDBLT_ZBUFFERSRCCONSTOVERRIDE

/*
 * Z-buffered blt using the lpDDSSrcZBuffer field and the dwZBufferOpCode
 * field in the DDBLTFX structure as the z-buffer and z-buffer opcode
 * respectively for the source.
 */
#define DDBLT_ZBUFFERSRCOVERRIDE

/*
 * wait until the device is ready to handle the blt
 * this will cause blt to not return DDERR_WASSTILLDRAWING
 */
#define DDBLT_WAIT

/*
 * Uses the dwFillDepth field in the DDBLTFX structure as the depth value
 * to fill the destination rectangle on the destination Z-buffer surface
 * with.
 */
#define DDBLT_DEPTHFILL


/*
 * Return immediately (with DDERR_WASSTILLDRAWING) if the device is not
 * ready to schedule the blt at the time Blt() is called.
 */
#define DDBLT_DONOTWAIT

/*
 * These flags indicate a presentation blt (i.e. a blt
 * that moves surface contents from an offscreen back buffer to the primary
 * surface). The driver is not allowed to "queue"  more than three such blts.
 * The "end" of the presentation blt is indicated, since the
 * blt may be clipped, in which case the runtime will call the driver with 
 * several blts. All blts (even if not clipped) are tagged with DDBLT_PRESENTATION
 * and the last (even if not clipped) additionally with DDBLT_LAST_PRESENTATION.
 * Thus the true rule is that the driver must not schedule a DDBLT_PRESENTATION
 * blt if there are 3 or more DDBLT_PRESENTLAST blts in the hardware pipe.
 * If there are such blts in the pipe, the driver should return DDERR_WASSTILLDRAWING
 * until the oldest queued DDBLT_LAST_PRESENTATION blts has been retired (i.e. the
 * pixels have been actually written to the primary surface). Once the oldest blt
 * has been retired, the driver is free to schedule the current blt.
 * The goal is to provide a mechanism whereby the device's hardware queue never
 * gets more than 3 frames ahead of the frames being generated by the application.
 * When excessive queueing occurs, applications become unusable because the application
 * visibly lags user input, and such problems make windowed interactive applications impossible.
 * Some drivers may not have sufficient knowledge of their hardware's FIFO to know
 * when a certain blt has been retired. Such drivers should code cautiously, and 
 * simply not allow any frames to be queued at all. DDBLT_LAST_PRESENTATION should cause
 * such drivers to return DDERR_WASSTILLDRAWING until the accelerator is completely
 * finished- exactly as if the application had called Lock on the source surface
 * before calling Blt. 
 * In other words, the driver is allowed and encouraged to 
 * generate as much latency as it can, but never more than 3 frames worth.
 * Implementation detail: Drivers should count blts against the SOURCE surface, not
 * against the primary surface. This enables multiple parallel windowed application
 * to function more optimally.
 * This flag is passed only to DX8 or higher drivers.
 *
 * APPLICATIONS DO NOT SET THESE FLAGS. THEY ARE SET BY THE DIRECTDRAW RUNTIME.
 * 
 */
#define DDBLT_PRESENTATION
#define DDBLT_LAST_PRESENTATION

/*
 * If DDBLT_EXTENDED_FLAGS is set, then the driver should re-interpret
 * other flags according to the definitions that follow.
 * For example, bit 0 (0x00000001L) means DDBLT_ALPHADEST, unless
 * DDBLT_EXTENDED_FLAGS is also set, in which case bit 0 means
 * DDBLT_EXTENDED_LINEAR_CONTENT.
 * Only DirectX9 and higher drivers will be given extended blt flags.
 * Only flags explicitly mentioned here should be re-interpreted.
 * All other flags retain their original meanings.
 *
 * List of re-interpreted flags:
 *
 * Bit Hex value   New meaning                                  old meaning
 * ---------------------------------------------------------------
 *  2  0x00000004  DDBLT_EXTENDED_LINEAR_CONTENT                DDBLT_ALPHADESTNEG
 *  4  0x00000010  DDBLT_EXTENDED_PRESENTATION_STRETCHFACTOR    DDBLT_ALPHAEDGEBLEND
 *
 *
 * NOTE: APPLICATIONS SHOULD NOT SET THIS FLAG. THIS FLAG IS INTENDED
 * FOR USE BY THE DIRECT3D RUNTIME.
 */
#define DDBLT_EXTENDED_FLAGS

/*
 * EXTENDED FLAG. SEE DEFINITION OF DDBLT_EXTENDED_FLAGS.
 * This flag indidcates that the source surface contains content in a
 * linear color space. The driver may perform gamma correction to the
 * desktop color space (i.e. sRGB, gamma 2.2) as part of this blt.
 * If the device can perform such a conversion as part of the copy,
 * the driver should also set D3DCAPS3_LINEAR_TO_SRGB_PRESENTATION
 *
 * NOTE: APPLICATIONS SHOULD NOT SET THIS FLAG. THIS FLAG IS INTENDED
 * FOR USE BY THE DIRECT3D RUNTIME. Use IDirect3DSwapChain9::Present
 * and specify D3DPRESENT_LINEAR_CONTENT in order to use this functionality.
 */ 
#define DDBLT_EXTENDED_LINEAR_CONTENT


/****************************************************************************
 *
 * BLTFAST FLAGS
 *
 ****************************************************************************/

#define DDBLTFAST_NOCOLORKEY
#define DDBLTFAST_SRCCOLORKEY
#define DDBLTFAST_DESTCOLORKEY
#define DDBLTFAST_WAIT
#define DDBLTFAST_DONOTWAIT

/****************************************************************************
 *
 * FLIP FLAGS
 *
 ****************************************************************************/

#define DDFLIP_WAIT

/*
 * Indicates that the target surface contains the even field of video data.
 * This flag is only valid with an overlay surface.
 */
#define DDFLIP_EVEN

/*
 * Indicates that the target surface contains the odd field of video data.
 * This flag is only valid with an overlay surface.
 */
#define DDFLIP_ODD

/*
 * Causes DirectDraw to perform the physical flip immediately and return
 * to the application. Typically, what was the front buffer but is now the back
 * buffer will still be visible (depending on timing) until the next vertical
 * retrace. Subsequent operations involving the two flipped surfaces will
 * not check to see if the physical flip has finished (i.e. will not return
 * DDERR_WASSTILLDRAWING for that reason (but may for other reasons)).
 * This allows an application to perform Flips at a higher frequency than the
 * monitor refresh rate, but may introduce visible artifacts.
 * Only effective if DDCAPS2_FLIPNOVSYNC is set. If that bit is not set,
 * DDFLIP_NOVSYNC has no effect.
 */
#define DDFLIP_NOVSYNC


/*
 * Flip Interval Flags. These flags indicate how many vertical retraces to wait between
 * each flip. The default is one. DirectDraw will return DDERR_WASSTILLDRAWING for each
 * surface involved in the flip until the specified number of vertical retraces has
 * ocurred. Only effective if DDCAPS2_FLIPINTERVAL is set. If that bit is not set,
 * DDFLIP_INTERVALn has no effect.
 */

/*
 * DirectDraw will flip on every other vertical sync
 */
#define DDFLIP_INTERVAL2


/*
 * DirectDraw will flip on every third vertical sync
 */
#define DDFLIP_INTERVAL3


/*
 * DirectDraw will flip on every fourth vertical sync
 */
#define DDFLIP_INTERVAL4

/*
 * DirectDraw will flip and display a main stereo surface
 */
#define DDFLIP_STEREO

/*
 * On IDirectDrawSurface7 and higher interfaces, the default is DDFLIP_WAIT. If you wish
 * to override the default and use time when the accelerator is busy (as denoted by
 * the DDERR_WASSTILLDRAWING return code) then use DDFLIP_DONOTWAIT.
 */
#define DDFLIP_DONOTWAIT


/****************************************************************************
 *
 * DIRECTDRAW SURFACE OVERLAY FLAGS
 *
 ****************************************************************************/

/*
 * Use the alpha information in the pixel format or the alpha channel surface
 * attached to the destination surface as the alpha channel for the
 * destination overlay.
 */
#define DDOVER_ALPHADEST

/*
 * Use the dwConstAlphaDest field in the DDOVERLAYFX structure as the
 * destination alpha channel for this overlay.
 */
#define DDOVER_ALPHADESTCONSTOVERRIDE

/*
 * The NEG suffix indicates that the destination surface becomes more
 * transparent as the alpha value increases.
 */
#define DDOVER_ALPHADESTNEG

/*
 * Use the lpDDSAlphaDest field in the DDOVERLAYFX structure as the alpha
 * channel destination for this overlay.
 */
#define DDOVER_ALPHADESTSURFACEOVERRIDE

/*
 * Use the dwAlphaEdgeBlend field in the DDOVERLAYFX structure as the alpha
 * channel for the edges of the image that border the color key colors.
 */
#define DDOVER_ALPHAEDGEBLEND

/*
 * Use the alpha information in the pixel format or the alpha channel surface
 * attached to the source surface as the source alpha channel for this overlay.
 */
#define DDOVER_ALPHASRC

/*
 * Use the dwConstAlphaSrc field in the DDOVERLAYFX structure as the source
 * alpha channel for this overlay.
 */
#define DDOVER_ALPHASRCCONSTOVERRIDE

/*
 * The NEG suffix indicates that the source surface becomes more transparent
 * as the alpha value increases.
 */
#define DDOVER_ALPHASRCNEG

/*
 * Use the lpDDSAlphaSrc field in the DDOVERLAYFX structure as the alpha channel
 * source for this overlay.
 */
#define DDOVER_ALPHASRCSURFACEOVERRIDE

/*
 * Turn this overlay off.
 */
#define DDOVER_HIDE

/*
 * Use the color key associated with the destination surface.
 */
#define DDOVER_KEYDEST

/*
 * Use the dckDestColorkey field in the DDOVERLAYFX structure as the color key
 * for the destination surface
 */
#define DDOVER_KEYDESTOVERRIDE

/*
 * Use the color key associated with the source surface.
 */
#define DDOVER_KEYSRC

/*
 * Use the dckSrcColorkey field in the DDOVERLAYFX structure as the color key
 * for the source surface.
 */
#define DDOVER_KEYSRCOVERRIDE

/*
 * Turn this overlay on.
 */
#define DDOVER_SHOW

/*
 * Add a dirty rect to an emulated overlayed surface.
 */
#define DDOVER_ADDDIRTYRECT

/*
 * Redraw all dirty rects on an emulated overlayed surface.
 */
#define DDOVER_REFRESHDIRTYRECTS

/*
 * Redraw the entire surface on an emulated overlayed surface.
 */
#define DDOVER_REFRESHALL


/*
 * Use the overlay FX flags to define special overlay FX
 */
#define DDOVER_DDFX

/*
 * Autoflip the overlay when ever the video port autoflips
 */
#define DDOVER_AUTOFLIP

/*
 * Display each field of video port data individually without
 * causing any jittery artifacts
 */
#define DDOVER_BOB

/*
 * Indicates that bob/weave decisions should not be overridden by other
 * interfaces.
 */
#define DDOVER_OVERRIDEBOBWEAVE

/*
 * Indicates that the surface memory is composed of interleaved fields.
 */
#define DDOVER_INTERLEAVED

/*
 * Indicates that bob will be performed using hardware rather than
 * software or emulated.
 */
#define DDOVER_BOBHARDWARE

/*
 * Indicates that overlay FX structure contains valid ARGB scaling factors.
 */
#define DDOVER_ARGBSCALEFACTORS

/*
 * Indicates that ARGB scaling factors can be degraded to fit driver capabilities.
 */
#define DDOVER_DEGRADEARGBSCALING


/****************************************************************************
 *
 * DIRECTDRAWSURFACE LOCK FLAGS
 *
 ****************************************************************************/

/*
 * The default.  Set to indicate that Lock should return a valid memory pointer
 * to the top of the specified rectangle.  If no rectangle is specified then a
 * pointer to the top of the surface is returned.
 */
#define DDLOCK_SURFACEMEMORYPTR

/*
 * Set to indicate that Lock should wait until it can obtain a valid memory
 * pointer before returning.  If this bit is set, Lock will never return
 * DDERR_WASSTILLDRAWING.
 */
#define DDLOCK_WAIT

/*
 * Set if an event handle is being passed to Lock.  Lock will trigger the event
 * when it can return the surface memory pointer requested.
 */
#define DDLOCK_EVENT

/*
 * Indicates that the surface being locked will only be read from.
 */
#define DDLOCK_READONLY

/*
 * Indicates that the surface being locked will only be written to
 */
#define DDLOCK_WRITEONLY


/*
 * Indicates that a system wide lock should not be taken when this surface
 * is locked. This has several advantages (cursor responsiveness, ability
 * to call more Windows functions, easier debugging) when locking video
 * memory surfaces. However, an application specifying this flag must
 * comply with a number of conditions documented in the help file.
 * Furthermore, this flag cannot be specified when locking the primary.
 */
#define DDLOCK_NOSYSLOCK

/*
 * Used only with Direct3D Vertex Buffer Locks. Indicates that no vertices
 * that were referred to in Draw*PrimtiveVB calls since the start of the
 * frame (or the last lock without this flag) will be modified during the
 * lock. This can be useful when one is only appending data to the vertex
 * buffer
 */
#define DDLOCK_NOOVERWRITE

/*
 * Indicates that no assumptions will be made about the contents of the
 * surface or vertex buffer during this lock.
 * This enables two things:
 * -    Direct3D or the driver may provide an alternative memory
 *      area as the vertex buffer. This is useful when one plans to clear the
 *      contents of the vertex buffer and fill in new data.
 * -    Drivers sometimes store surface data in a re-ordered format.
 *      When the application locks the surface, the driver is forced to un-re-order
 *      the surface data before allowing the application to see the surface contents.
 *      This flag is a hint to the driver that it can skip the un-re-ordering process
 *      since the application plans to overwrite every single pixel in the surface
 *      or locked rectangle (and so erase any un-re-ordered pixels anyway).
 *      Applications should always set this flag when they intend to overwrite the entire
 *      surface or locked rectangle.
 */
#define DDLOCK_DISCARDCONTENTS
 /*
  * DDLOCK_OKTOSWAP is an older, less informative name for DDLOCK_DISCARDCONTENTS
  */
#define DDLOCK_OKTOSWAP

/*
 * On IDirectDrawSurface7 and higher interfaces, the default is DDLOCK_WAIT. If you wish
 * to override the default and use time when the accelerator is busy (as denoted by
 * the DDERR_WASSTILLDRAWING return code) then use DDLOCK_DONOTWAIT.
 */
#define DDLOCK_DONOTWAIT

/*
 * This indicates volume texture lock with front and back specified.
 */
#define DDLOCK_HASVOLUMETEXTUREBOXRECT

/*
 * This indicates that the driver should not update dirty rect information for this lock.
 */
#define DDLOCK_NODIRTYUPDATE


/****************************************************************************
 *
 * DIRECTDRAWSURFACE PAGELOCK FLAGS
 *
 ****************************************************************************/

/*
 * No flags defined at present
 */


/****************************************************************************
 *
 * DIRECTDRAWSURFACE PAGEUNLOCK FLAGS
 *
 ****************************************************************************/

/*
 * No flags defined at present
 */


/****************************************************************************
 *
 * DIRECTDRAWSURFACE BLT FX FLAGS
 *
 ****************************************************************************/

/*
 * If stretching, use arithmetic stretching along the Y axis for this blt.
 */
#define DDBLTFX_ARITHSTRETCHY

/*
 * Do this blt mirroring the surface left to right.  Spin the
 * surface around its y-axis.
 */
#define DDBLTFX_MIRRORLEFTRIGHT

/*
 * Do this blt mirroring the surface up and down.  Spin the surface
 * around its x-axis.
 */
#define DDBLTFX_MIRRORUPDOWN

/*
 * Schedule this blt to avoid tearing.
 */
#define DDBLTFX_NOTEARING

/*
 * Do this blt rotating the surface one hundred and eighty degrees.
 */
#define DDBLTFX_ROTATE180

/*
 * Do this blt rotating the surface two hundred and seventy degrees.
 */
#define DDBLTFX_ROTATE270

/*
 * Do this blt rotating the surface ninety degrees.
 */
#define DDBLTFX_ROTATE90

/*
 * Do this z blt using dwZBufferLow and dwZBufferHigh as  range values
 * specified to limit the bits copied from the source surface.
 */
#define DDBLTFX_ZBUFFERRANGE

/*
 * Do this z blt adding the dwZBufferBaseDest to each of the sources z values
 * before comparing it with the desting z values.
 */
#define DDBLTFX_ZBUFFERBASEDEST

/****************************************************************************
 *
 * DIRECTDRAWSURFACE OVERLAY FX FLAGS
 *
 ****************************************************************************/

/*
 * If stretching, use arithmetic stretching along the Y axis for this overlay.
 */
#define DDOVERFX_ARITHSTRETCHY

/*
 * Mirror the overlay across the vertical axis
 */
#define DDOVERFX_MIRRORLEFTRIGHT

/*
 * Mirror the overlay across the horizontal axis
 */
#define DDOVERFX_MIRRORUPDOWN

/*
 * Deinterlace the overlay, if possible
 */
#define DDOVERFX_DEINTERLACE


/****************************************************************************
 *
 * DIRECTDRAW WAITFORVERTICALBLANK FLAGS
 *
 ****************************************************************************/

/*
 * return when the vertical blank interval begins
 */
#define DDWAITVB_BLOCKBEGIN

/*
 * set up an event to trigger when the vertical blank begins
 */
#define DDWAITVB_BLOCKBEGINEVENT

/*
 * return when the vertical blank interval ends and display begins
 */
#define DDWAITVB_BLOCKEND

/****************************************************************************
 *
 * DIRECTDRAW GETFLIPSTATUS FLAGS
 *
 ****************************************************************************/

/*
 * is it OK to flip now?
 */
#define DDGFS_CANFLIP

/*
 * is the last flip finished?
 */
#define DDGFS_ISFLIPDONE

/****************************************************************************
 *
 * DIRECTDRAW GETBLTSTATUS FLAGS
 *
 ****************************************************************************/

/*
 * is it OK to blt now?
 */
#define DDGBS_CANBLT

/*
 * is the blt to the surface finished?
 */
#define DDGBS_ISBLTDONE


/****************************************************************************
 *
 * DIRECTDRAW ENUMOVERLAYZORDER FLAGS
 *
 ****************************************************************************/

/*
 * Enumerate overlays back to front.
 */
#define DDENUMOVERLAYZ_BACKTOFRONT

/*
 * Enumerate overlays front to back
 */
#define DDENUMOVERLAYZ_FRONTTOBACK

/****************************************************************************
 *
 * DIRECTDRAW UPDATEOVERLAYZORDER FLAGS
 *
 ****************************************************************************/

/*
 * Send overlay to front
 */
#define DDOVERZ_SENDTOFRONT

/*
 * Send overlay to back
 */
#define DDOVERZ_SENDTOBACK

/*
 * Move Overlay forward
 */
#define DDOVERZ_MOVEFORWARD

/*
 * Move Overlay backward
 */
#define DDOVERZ_MOVEBACKWARD

/*
 * Move Overlay in front of relative surface
 */
#define DDOVERZ_INSERTINFRONTOF

/*
 * Move Overlay in back of relative surface
 */
#define DDOVERZ_INSERTINBACKOF


/****************************************************************************
 *
 * DIRECTDRAW SETGAMMARAMP FLAGS
 *
 ****************************************************************************/

/*
 * Request calibrator to adjust the gamma ramp according to the physical
 * properties of the display so that the result should appear identical
 * on all systems.
 */
#define DDSGR_CALIBRATE


/****************************************************************************
 *
 * DIRECTDRAW STARTMODETEST FLAGS
 *
 ****************************************************************************/

/*
 * Indicates that the mode being tested has passed
 */
#define DDSMT_ISTESTREQUIRED


/****************************************************************************
 *
 * DIRECTDRAW EVALUATEMODE FLAGS
 *
 ****************************************************************************/

/*
 * Indicates that the mode being tested has passed
 */
#define DDEM_MODEPASSED

/*
 * Indicates that the mode being tested has failed
 */
#define DDEM_MODEFAILED


/*===========================================================================
 *
 *
 * DIRECTDRAW RETURN CODES
 *
 * The return values from DirectDraw Commands and Surface that return an HRESULT
 * are codes from DirectDraw concerning the results of the action
 * requested by DirectDraw.
 *
 *==========================================================================*/

/*
 * Status is OK
 *
 * Issued by: DirectDraw Commands and all callbacks
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_OK S_OK
#define DD_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_FALSE S_FALSE
#define DD_FALSE

/****************************************************************************
 *
 * DIRECTDRAW ENUMCALLBACK RETURN VALUES
 *
 * EnumCallback returns are used to control the flow of the DIRECTDRAW and
 * DIRECTDRAWSURFACE object enumerations.   They can only be returned by
 * enumeration callback routines.
 *
 ****************************************************************************/

/*
 * stop the enumeration
 */
#define DDENUMRET_CANCEL

/*
 * continue the enumeration
 */
#define DDENUMRET_OK

/****************************************************************************
 *
 * DIRECTDRAW ERRORS
 *
 * Errors are represented by negative values and cannot be combined.
 *
 ****************************************************************************/

/*
 * This object is already initialized
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_ALREADYINITIALIZED MAKE_DDHRESULT( 5 )
#define DDERR_ALREADYINITIALIZED

/*
 * This surface can not be attached to the requested surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTATTACHSURFACE MAKE_DDHRESULT( 10 )
#define DDERR_CANNOTATTACHSURFACE

/*
 * This surface can not be detached from the requested surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTDETACHSURFACE MAKE_DDHRESULT( 20 )
#define DDERR_CANNOTDETACHSURFACE

/*
 * Support is currently not available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CURRENTLYNOTAVAIL MAKE_DDHRESULT( 40 )
#define DDERR_CURRENTLYNOTAVAIL

/*
 * An exception was encountered while performing the requested operation
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCEPTION MAKE_DDHRESULT( 55 )
#define DDERR_EXCEPTION

/*
 * Generic failure.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_GENERIC E_FAIL
#define DDERR_GENERIC

/*
 * Height of rectangle provided is not a multiple of reqd alignment
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HEIGHTALIGN MAKE_DDHRESULT( 90 )
#define DDERR_HEIGHTALIGN

/*
 * Unable to match primary surface creation request with existing
 * primary surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INCOMPATIBLEPRIMARY MAKE_DDHRESULT( 95 )
#define DDERR_INCOMPATIBLEPRIMARY

/*
 * One or more of the caps bits passed to the callback are incorrect.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCAPS MAKE_DDHRESULT( 100 )
#define DDERR_INVALIDCAPS

/*
 * DirectDraw does not support provided Cliplist.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCLIPLIST MAKE_DDHRESULT( 110 )
#define DDERR_INVALIDCLIPLIST

/*
 * DirectDraw does not support the requested mode
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDMODE MAKE_DDHRESULT( 120 )
#define DDERR_INVALIDMODE

/*
 * DirectDraw received a pointer that was an invalid DIRECTDRAW object.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDOBJECT MAKE_DDHRESULT( 130 )
#define DDERR_INVALIDOBJECT

/*
 * One or more of the parameters passed to the callback function are
 * incorrect.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPARAMS E_INVALIDARG
#define DDERR_INVALIDPARAMS

/*
 * pixel format was invalid as specified
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPIXELFORMAT MAKE_DDHRESULT( 145 )
#define DDERR_INVALIDPIXELFORMAT

/*
 * Rectangle provided was invalid.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDRECT MAKE_DDHRESULT( 150 )
#define DDERR_INVALIDRECT

/*
 * Operation could not be carried out because one or more surfaces are locked
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_LOCKEDSURFACES MAKE_DDHRESULT( 160 )
#define DDERR_LOCKEDSURFACES

/*
 * There is no 3D present.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NO3D MAKE_DDHRESULT( 170 )
#define DDERR_NO3D

/*
 * Operation could not be carried out because there is no alpha accleration
 * hardware present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOALPHAHW MAKE_DDHRESULT( 180 )
#define DDERR_NOALPHAHW

/*
 * Operation could not be carried out because there is no stereo
 * hardware present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTEREOHARDWARE MAKE_DDHRESULT( 181 )
#define DDERR_NOSTEREOHARDWARE

/*
 * Operation could not be carried out because there is no hardware
 * present which supports stereo surfaces
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSURFACELEFT MAKE_DDHRESULT( 182 )
#define DDERR_NOSURFACELEFT



/*
 * no clip list available
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPLIST MAKE_DDHRESULT( 205 )
#define DDERR_NOCLIPLIST

/*
 * Operation could not be carried out because there is no color conversion
 * hardware present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORCONVHW MAKE_DDHRESULT( 210 )
#define DDERR_NOCOLORCONVHW

/*
 * Create function called without DirectDraw object method SetCooperativeLevel
 * being called.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOOPERATIVELEVELSET MAKE_DDHRESULT( 212 )
#define DDERR_NOCOOPERATIVELEVELSET

/*
 * Surface doesn't currently have a color key
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEY MAKE_DDHRESULT( 215 )
#define DDERR_NOCOLORKEY

/*
 * Operation could not be carried out because there is no hardware support
 * of the dest color key.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEYHW MAKE_DDHRESULT( 220 )
#define DDERR_NOCOLORKEYHW

/*
 * No DirectDraw support possible with current display driver
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWSUPPORT MAKE_DDHRESULT( 222 )
#define DDERR_NODIRECTDRAWSUPPORT

/*
 * Operation requires the application to have exclusive mode but the
 * application does not have exclusive mode.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEXCLUSIVEMODE MAKE_DDHRESULT( 225 )
#define DDERR_NOEXCLUSIVEMODE

/*
 * Flipping visible surfaces is not supported.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFLIPHW MAKE_DDHRESULT( 230 )
#define DDERR_NOFLIPHW

/*
 * There is no GDI present.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOGDI MAKE_DDHRESULT( 240 )
#define DDERR_NOGDI

/*
 * Operation could not be carried out because there is no hardware present
 * or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIRRORHW MAKE_DDHRESULT( 250 )
#define DDERR_NOMIRRORHW

/*
 * Requested item was not found
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFOUND MAKE_DDHRESULT( 255 )
#define DDERR_NOTFOUND

/*
 * Operation could not be carried out because there is no overlay hardware
 * present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYHW MAKE_DDHRESULT( 260 )
#define DDERR_NOOVERLAYHW

/*
 * Operation could not be carried out because the source and destination
 * rectangles are on the same surface and overlap each other.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAPPINGRECTS MAKE_DDHRESULT( 270 )
#define DDERR_OVERLAPPINGRECTS

/*
 * Operation could not be carried out because there is no appropriate raster
 * op hardware present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NORASTEROPHW MAKE_DDHRESULT( 280 )
#define DDERR_NORASTEROPHW

/*
 * Operation could not be carried out because there is no rotation hardware
 * present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOROTATIONHW MAKE_DDHRESULT( 290 )
#define DDERR_NOROTATIONHW

/*
 * Operation could not be carried out because there is no hardware support
 * for stretching
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTRETCHHW MAKE_DDHRESULT( 310 )
#define DDERR_NOSTRETCHHW

/*
 * DirectDrawSurface is not in 4 bit color palette and the requested operation
 * requires 4 bit color palette.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLOR MAKE_DDHRESULT( 316 )
#define DDERR_NOT4BITCOLOR

/*
 * DirectDrawSurface is not in 4 bit color index palette and the requested
 * operation requires 4 bit color index palette.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLORINDEX MAKE_DDHRESULT( 317 )
#define DDERR_NOT4BITCOLORINDEX

/*
 * DirectDraw Surface is not in 8 bit color mode and the requested operation
 * requires 8 bit color.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT8BITCOLOR MAKE_DDHRESULT( 320 )
#define DDERR_NOT8BITCOLOR

/*
 * Operation could not be carried out because there is no texture mapping
 * hardware present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTEXTUREHW MAKE_DDHRESULT( 330 )
#define DDERR_NOTEXTUREHW

/*
 * Operation could not be carried out because there is no hardware support
 * for vertical blank synchronized operations.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOVSYNCHW MAKE_DDHRESULT( 335 )
#define DDERR_NOVSYNCHW

/*
 * Operation could not be carried out because there is no hardware support
 * for zbuffer blting.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZBUFFERHW MAKE_DDHRESULT( 340 )
#define DDERR_NOZBUFFERHW

/*
 * Overlay surfaces could not be z layered based on their BltOrder because
 * the hardware does not support z layering of overlays.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZOVERLAYHW MAKE_DDHRESULT( 350 )
#define DDERR_NOZOVERLAYHW

/*
 * The hardware needed for the requested operation has already been
 * allocated.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFCAPS MAKE_DDHRESULT( 360 )
#define DDERR_OUTOFCAPS

/*
 * DirectDraw does not have enough memory to perform the operation.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFMEMORY E_OUTOFMEMORY
#define DDERR_OUTOFMEMORY

/*
 * DirectDraw does not have enough memory to perform the operation.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFVIDEOMEMORY MAKE_DDHRESULT( 380 )
#define DDERR_OUTOFVIDEOMEMORY

/*
 * hardware does not support clipped overlays
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCANTCLIP MAKE_DDHRESULT( 382 )
#define DDERR_OVERLAYCANTCLIP

/*
 * Can only have ony color key active at one time for overlays
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCOLORKEYONLYONEACTIVE MAKE_DDHRESULT( 384 )
#define DDERR_OVERLAYCOLORKEYONLYONEACTIVE

/*
 * Access to this palette is being refused because the palette is already
 * locked by another thread.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PALETTEBUSY MAKE_DDHRESULT( 387 )
#define DDERR_PALETTEBUSY

/*
 * No src color key specified for this operation.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_COLORKEYNOTSET MAKE_DDHRESULT( 400 )
#define DDERR_COLORKEYNOTSET

/*
 * This surface is already attached to the surface it is being attached to.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYATTACHED MAKE_DDHRESULT( 410 )
#define DDERR_SURFACEALREADYATTACHED

/*
 * This surface is already a dependency of the surface it is being made a
 * dependency of.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYDEPENDENT MAKE_DDHRESULT( 420 )
#define DDERR_SURFACEALREADYDEPENDENT

/*
 * Access to this surface is being refused because the surface is already
 * locked by another thread.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEBUSY MAKE_DDHRESULT( 430 )
#define DDERR_SURFACEBUSY

/*
 * Access to this surface is being refused because no driver exists
 * which can supply a pointer to the surface.
 * This is most likely to happen when attempting to lock the primary
 * surface when no DCI provider is present.
 * Will also happen on attempts to lock an optimized surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTLOCKSURFACE MAKE_DDHRESULT( 435 )
#define DDERR_CANTLOCKSURFACE

/*
 * Access to Surface refused because Surface is obscured.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEISOBSCURED MAKE_DDHRESULT( 440 )
#define DDERR_SURFACEISOBSCURED

/*
 * Access to this surface is being refused because the surface is gone.
 * The DIRECTDRAWSURFACE object representing this surface should
 * have Restore called on it.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACELOST MAKE_DDHRESULT( 450 )
#define DDERR_SURFACELOST

/*
 * The requested surface is not attached.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACENOTATTACHED MAKE_DDHRESULT( 460 )
#define DDERR_SURFACENOTATTACHED

/*
 * Height requested by DirectDraw is too large.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGHEIGHT MAKE_DDHRESULT( 470 )
#define DDERR_TOOBIGHEIGHT

/*
 * Size requested by DirectDraw is too large --  The individual height and
 * width are OK.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGSIZE MAKE_DDHRESULT( 480 )
#define DDERR_TOOBIGSIZE

/*
 * Width requested by DirectDraw is too large.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGWIDTH MAKE_DDHRESULT( 490 )
#define DDERR_TOOBIGWIDTH

/*
 * Action not supported.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTED E_NOTIMPL
#define DDERR_UNSUPPORTED

/*
 * Pixel format requested is unsupported by DirectDraw
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDFORMAT MAKE_DDHRESULT( 510 )
#define DDERR_UNSUPPORTEDFORMAT

/*
 * Bitmask in the pixel format requested is unsupported by DirectDraw
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMASK MAKE_DDHRESULT( 520 )
#define DDERR_UNSUPPORTEDMASK

/*
 * The specified stream contains invalid data
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSTREAM MAKE_DDHRESULT( 521 )
#define DDERR_INVALIDSTREAM

/*
 * vertical blank is in progress
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VERTICALBLANKINPROGRESS MAKE_DDHRESULT( 537 )
#define DDERR_VERTICALBLANKINPROGRESS

/*
 * Informs DirectDraw that the previous Blt which is transfering information
 * to or from this Surface is incomplete.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WASSTILLDRAWING MAKE_DDHRESULT( 540 )
#define DDERR_WASSTILLDRAWING


/*
 * The specified surface type requires specification of the COMPLEX flag
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DDSCAPSCOMPLEXREQUIRED MAKE_DDHRESULT( 542 )
#define DDERR_DDSCAPSCOMPLEXREQUIRED


/*
 * Rectangle provided was not horizontally aligned on reqd. boundary
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_XALIGN MAKE_DDHRESULT( 560 )
#define DDERR_XALIGN

/*
 * The GUID passed to DirectDrawCreate is not a valid DirectDraw driver
 * identifier.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDDIRECTDRAWGUID MAKE_DDHRESULT( 561 )
#define DDERR_INVALIDDIRECTDRAWGUID

/*
 * A DirectDraw object representing this driver has already been created
 * for this process.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DIRECTDRAWALREADYCREATED MAKE_DDHRESULT( 562 )
#define DDERR_DIRECTDRAWALREADYCREATED

/*
 * A hardware only DirectDraw object creation was attempted but the driver
 * did not support any hardware.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWHW MAKE_DDHRESULT( 563 )
#define DDERR_NODIRECTDRAWHW

/*
 * this process already has created a primary surface
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PRIMARYSURFACEALREADYEXISTS MAKE_DDHRESULT( 564 )
#define DDERR_PRIMARYSURFACEALREADYEXISTS

/*
 * software emulation not available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEMULATION MAKE_DDHRESULT( 565 )
#define DDERR_NOEMULATION

/*
 * region passed to Clipper::GetClipList is too small.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_REGIONTOOSMALL MAKE_DDHRESULT( 566 )
#define DDERR_REGIONTOOSMALL

/*
 * an attempt was made to set a clip list for a clipper objec that
 * is already monitoring an hwnd.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CLIPPERISUSINGHWND MAKE_DDHRESULT( 567 )
#define DDERR_CLIPPERISUSINGHWND

/*
 * No clipper object attached to surface object
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPPERATTACHED MAKE_DDHRESULT( 568 )
#define DDERR_NOCLIPPERATTACHED

/*
 * Clipper notification requires an HWND or
 * no HWND has previously been set as the CooperativeLevel HWND.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOHWND MAKE_DDHRESULT( 569 )
#define DDERR_NOHWND

/*
 * HWND used by DirectDraw CooperativeLevel has been subclassed,
 * this prevents DirectDraw from restoring state.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDSUBCLASSED MAKE_DDHRESULT( 570 )
#define DDERR_HWNDSUBCLASSED

/*
 * The CooperativeLevel HWND has already been set.
 * It can not be reset while the process has surfaces or palettes created.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDALREADYSET MAKE_DDHRESULT( 571 )
#define DDERR_HWNDALREADYSET

/*
 * No palette object attached to this surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEATTACHED MAKE_DDHRESULT( 572 )
#define DDERR_NOPALETTEATTACHED

/*
 * No hardware support for 16 or 256 color palettes.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEHW MAKE_DDHRESULT( 573 )
#define DDERR_NOPALETTEHW

/*
 * If a clipper object is attached to the source surface passed into a
 * BltFast call.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_BLTFASTCANTCLIP MAKE_DDHRESULT( 574 )
#define DDERR_BLTFASTCANTCLIP

/*
 * No blter.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOBLTHW MAKE_DDHRESULT( 575 )
#define DDERR_NOBLTHW

/*
 * No DirectDraw ROP hardware.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODDROPSHW MAKE_DDHRESULT( 576 )
#define DDERR_NODDROPSHW

/*
 * returned when GetOverlayPosition is called on a hidden overlay
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYNOTVISIBLE MAKE_DDHRESULT( 577 )
#define DDERR_OVERLAYNOTVISIBLE

/*
 * returned when GetOverlayPosition is called on a overlay that UpdateOverlay
 * has never been called on to establish a destionation.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYDEST MAKE_DDHRESULT( 578 )
#define DDERR_NOOVERLAYDEST

/*
 * returned when the position of the overlay on the destionation is no longer
 * legal for that destionation.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPOSITION MAKE_DDHRESULT( 579 )
#define DDERR_INVALIDPOSITION

/*
 * returned when an overlay member is called for a non-overlay surface
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTAOVERLAYSURFACE MAKE_DDHRESULT( 580 )
#define DDERR_NOTAOVERLAYSURFACE

/*
 * An attempt was made to set the cooperative level when it was already
 * set to exclusive.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCLUSIVEMODEALREADYSET MAKE_DDHRESULT( 581 )
#define DDERR_EXCLUSIVEMODEALREADYSET

/*
 * An attempt has been made to flip a surface that is not flippable.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFLIPPABLE MAKE_DDHRESULT( 582 )
#define DDERR_NOTFLIPPABLE

/*
 * Can't duplicate primary & 3D surfaces, or surfaces that are implicitly
 * created.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTDUPLICATE MAKE_DDHRESULT( 583 )
#define DDERR_CANTDUPLICATE

/*
 * Surface was not locked.  An attempt to unlock a surface that was not
 * locked at all, or by this process, has been attempted.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOCKED MAKE_DDHRESULT( 584 )
#define DDERR_NOTLOCKED

/*
 * Windows can not create any more DCs, or a DC was requested for a paltte-indexed
 * surface when the surface had no palette AND the display mode was not palette-indexed
 * (in this case DirectDraw cannot select a proper palette into the DC)
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTCREATEDC MAKE_DDHRESULT( 585 )
#define DDERR_CANTCREATEDC

/*
 * No DC was ever created for this surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODC MAKE_DDHRESULT( 586 )
#define DDERR_NODC

/*
 * This surface can not be restored because it was created in a different
 * mode.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WRONGMODE MAKE_DDHRESULT( 587 )
#define DDERR_WRONGMODE

/*
 * This surface can not be restored because it is an implicitly created
 * surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_IMPLICITLYCREATED MAKE_DDHRESULT( 588 )
#define DDERR_IMPLICITLYCREATED

/*
 * The surface being used is not a palette-based surface
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPALETTIZED MAKE_DDHRESULT( 589 )
#define DDERR_NOTPALETTIZED


/*
 * The display is currently in an unsupported mode
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMODE MAKE_DDHRESULT( 590 )
#define DDERR_UNSUPPORTEDMODE

/*
 * Operation could not be carried out because there is no mip-map
 * texture mapping hardware present or available.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIPMAPHW MAKE_DDHRESULT( 591 )
#define DDERR_NOMIPMAPHW

/*
 * The requested action could not be performed because the surface was of
 * the wrong type.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSURFACETYPE MAKE_DDHRESULT( 592 )
#define DDERR_INVALIDSURFACETYPE


/*
 * Device does not support optimized surfaces, therefore no video memory optimized surfaces
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOPTIMIZEHW MAKE_DDHRESULT( 600 )
#define DDERR_NOOPTIMIZEHW

/*
 * Surface is an optimized surface, but has not yet been allocated any memory
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOADED MAKE_DDHRESULT( 601 )
#define DDERR_NOTLOADED

/*
 * Attempt was made to create or set a device window without first setting
 * the focus window
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFOCUSWINDOW MAKE_DDHRESULT( 602 )
#define DDERR_NOFOCUSWINDOW

/*
 * Attempt was made to set a palette on a mipmap sublevel
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTONMIPMAPSUBLEVEL MAKE_DDHRESULT( 603 )
#define DDERR_NOTONMIPMAPSUBLEVEL

/*
 * A DC has already been returned for this surface. Only one DC can be
 * retrieved per surface.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DCALREADYCREATED MAKE_DDHRESULT( 620 )
#define DDERR_DCALREADYCREATED

/*
 * An attempt was made to allocate non-local video memory from a device
 * that does not support non-local video memory.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NONONLOCALVIDMEM MAKE_DDHRESULT( 630 )
#define DDERR_NONONLOCALVIDMEM

/*
 * The attempt to page lock a surface failed.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGELOCK MAKE_DDHRESULT( 640 )
#define DDERR_CANTPAGELOCK


/*
 * The attempt to page unlock a surface failed.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGEUNLOCK MAKE_DDHRESULT( 660 )
#define DDERR_CANTPAGEUNLOCK

/*
 * An attempt was made to page unlock a surface with no outstanding page locks.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPAGELOCKED MAKE_DDHRESULT( 680 )
#define DDERR_NOTPAGELOCKED

/*
 * There is more data available than the specified buffer size could hold
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_MOREDATA MAKE_DDHRESULT( 690 )
#define DDERR_MOREDATA

/*
 * The data has expired and is therefore no longer valid.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXPIRED MAKE_DDHRESULT( 691 )
#define DDERR_EXPIRED

/*
 * The mode test has finished executing.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TESTFINISHED MAKE_DDHRESULT( 692 )
#define DDERR_TESTFINISHED

/*
 * The mode test has switched to a new mode.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NEWMODE MAKE_DDHRESULT( 693 )
#define DDERR_NEWMODE

/*
 * D3D has not yet been initialized.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_D3DNOTINITIALIZED MAKE_DDHRESULT( 694 )
#define DDERR_D3DNOTINITIALIZED

/*
 * The video port is not active
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VIDEONOTACTIVE MAKE_DDHRESULT( 695 )
#define DDERR_VIDEONOTACTIVE

/*
 * The monitor does not have EDID data.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMONITORINFORMATION MAKE_DDHRESULT( 696 )
#define DDERR_NOMONITORINFORMATION

/*
 * The driver does not enumerate display mode refresh rates.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODRIVERSUPPORT MAKE_DDHRESULT( 697 )
#define DDERR_NODRIVERSUPPORT

/*
 * Surfaces created by one direct draw device cannot be used directly by
 * another direct draw device.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DEVICEDOESNTOWNSURFACE MAKE_DDHRESULT( 699 )
#define DDERR_DEVICEDOESNTOWNSURFACE



/*
 * An attempt was made to invoke an interface member of a DirectDraw object
 * created by CoCreateInstance() before it was initialized.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTINITIALIZED CO_E_NOTINITIALIZED
#define DDERR_NOTINITIALIZED


/* Alpha bit depth constants */


#if __cplusplus
#endif

#if ENABLE_NAMELESS_UNION_PRAGMA
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(default:4201)
#endif



