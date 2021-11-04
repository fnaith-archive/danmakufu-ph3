/// ////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx9core.h
//  Content:    D3DX core types and functions
// 
/// ////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3dx9.h"



/// ////////////////////////////////////////////////////////////////////////
// D3DX_SDK_VERSION:
// -----------------
// This identifier is passed to D3DXCheckVersion in order to ensure that an
// application was built against the correct header files and lib files. 
// This number is incremented whenever a header (or other) change would 
// require applications to be rebuilt. If the version doesn't match, 
// D3DXCreateVersion will return FALSE. (The number itself has no meaning.)
/// ////////////////////////////////////////////////////////////////////////


#if __cplusplus
#endif //__cplusplus



/// ///////////////////////////////////////////////////////////////////////////
// ID3DXFont:
// ----------
// Font objects contain the textures and resources needed to render a specific 
// font on a specific device.
// 
// GetGlyphData -
//    Returns glyph cache data, for a given glyph.
// 
// PreloadCharacters/PreloadGlyphs/PreloadText -
//    Preloads glyphs into the glyph cache textures.
// 
// DrawText -
//    Draws formatted text on a D3D device.  Some parameters are 
//    surprisingly similar to those of GDI's DrawText function.  See GDI 
//    documentation for a detailed description of these parameters.
//    If pSprite is NULL, an internal sprite object will be used.
// 
// OnLostDevice, OnResetDevice -
//    Call OnLostDevice() on this object before calling Reset() on the
//    device, so that this object can release any stateblocks and video
//    memory resources.  After Reset(), the call OnResetDevice().
/// ///////////////////////////////////////////////////////////////////////////

public class _D3DXFONT_DESCA
{
    public int Height;
    public uint Width;
    public uint Weight;
    public uint MipLevels;
    public bool Italic;
    public byte CharSet;
    public byte OutputPrecision;
    public byte Quality;
    public byte PitchAndFamily;
    public string FaceName = new string(new char[LF_FACESIZE]);

}

public class _D3DXFONT_DESCW
{
    public int Height;
    public uint Width;
    public uint Weight;
    public uint MipLevels;
    public bool Italic;
    public byte CharSet;
    public byte OutputPrecision;
    public byte Quality;
    public byte PitchAndFamily;
    public string FaceName = new string(new char[LF_FACESIZE]);

}

#if UNICODE
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXFONT_DESCW D3DXFONT_DESC;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef LPD3DXFONT_DESCW LPD3DXFONT_DESC;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef D3DXFONT_DESCA D3DXFONT_DESC;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef LPD3DXFONT_DESCA LPD3DXFONT_DESC;
#endif




// {D79DBB70-5F21-4d36-BBC2-FF525C213CDC}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXFont, 0xd79dbb70, 0x5f21, 0x4d36, 0xbb, 0xc2, 0xff, 0x52, 0x5c, 0x21, 0x3c, 0xdc);



/// ////////////////////////////////////////////////////////////////////////
// ID3DXRenderToSurface:
// ---------------------
// This object abstracts rendering to surfaces.  These surfaces do not 
// necessarily need to be render targets.  If they are not, a compatible
// render target is used, and the result copied into surface at end scene.
// 
// BeginScene, EndScene -
//    Call BeginScene() and EndScene() at the beginning and ending of your
//    scene.  These calls will setup and restore render targets, viewports, 
//    etc.. 
// 
// OnLostDevice, OnResetDevice -
//    Call OnLostDevice() on this object before calling Reset() on the
//    device, so that this object can release any stateblocks and video
//    memory resources.  After Reset(), the call OnResetDevice().
/// ////////////////////////////////////////////////////////////////////////

public partial class _D3DXRTS_DESC
{
    public uint Width;
    public uint Height;
    public D3DFORMAT Format = new D3DFORMAT();
    public bool DepthStencil;
    public D3DFORMAT DepthStencilFormat = new D3DFORMAT();

}




// {6985F346-2C3D-43b3-BE8B-DAAE8A03D894}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXRenderToSurface, 0x6985f346, 0x2c3d, 0x43b3, 0xbe, 0x8b, 0xda, 0xae, 0x8a, 0x3, 0xd8, 0x94);



/// ////////////////////////////////////////////////////////////////////////
// ID3DXRenderToEnvMap:
// --------------------
// This object abstracts rendering to environment maps.  These surfaces 
// do not necessarily need to be render targets.  If they are not, a 
// compatible render target is used, and the result copied into the
// environment map at end scene.
// 
// BeginCube, BeginSphere, BeginHemisphere, BeginParabolic -
//    This function initiates the rendering of the environment map.  As
//    parameters, you pass the textures in which will get filled in with
//    the resulting environment map.
// 
// Face -
//    Call this function to initiate the drawing of each face.  For each 
//    environment map, you will call this six times.. once for each face 
//    in D3DCUBEMAP_FACES.
// 
// End -
//    This will restore all render targets, and if needed compose all the
//    rendered faces into the environment map surfaces.
// 
// OnLostDevice, OnResetDevice -
//    Call OnLostDevice() on this object before calling Reset() on the
//    device, so that this object can release any stateblocks and video
//    memory resources.  After Reset(), the call OnResetDevice().
/// ////////////////////////////////////////////////////////////////////////

public partial class _D3DXRTE_DESC
{
    public uint Size;
    public uint MipLevels;
    public D3DFORMAT Format = new D3DFORMAT();
    public bool DepthStencil;
    public D3DFORMAT DepthStencilFormat = new D3DFORMAT();

}




// {313F1B4B-C7B0-4fa2-9D9D-8D380B64385E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXRenderToEnvMap, 0x313f1b4b, 0xc7b0, 0x4fa2, 0x9d, 0x9d, 0x8d, 0x38, 0xb, 0x64, 0x38, 0x5e);