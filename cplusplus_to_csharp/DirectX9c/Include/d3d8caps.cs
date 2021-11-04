/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       d3d8caps.h
 *  Content:    Direct3D capabilities include file
 *
 ***************************************************************************/



// include this file content only if compiling for DX8 interfaces
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0800)

#if _X86_ || _IA64_
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(4)
#endif

public class _D3DCAPS8
{
    /* Device Info */
    public D3DDEVTYPE DeviceType = new D3DDEVTYPE();
    public uint AdapterOrdinal;

    /* Caps from DX7 Draw */
    public uint Caps;
    public uint Caps2;
    public uint Caps3;
    public uint PresentationIntervals;

    /* Cursor Caps */
    public uint CursorCaps;

    /* 3D Device Caps */
    public uint DevCaps;

    public uint PrimitiveMiscCaps;
    public uint RasterCaps;
    public uint ZCmpCaps;
    public uint SrcBlendCaps;
    public uint DestBlendCaps;
    public uint AlphaCmpCaps;
    public uint ShadeCaps;
    public uint TextureCaps;
    public uint TextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DTexture8's
    public uint CubeTextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DCubeTexture8's
    public uint VolumeTextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DVolumeTexture8's
    public uint TextureAddressCaps; // D3DPTADDRESSCAPS for IDirect3DTexture8's
    public uint VolumeTextureAddressCaps; // D3DPTADDRESSCAPS for IDirect3DVolumeTexture8's

    public uint LineCaps; // D3DLINECAPS

    public uint MaxTextureWidth;
    public uint MaxTextureHeight;
    public uint MaxVolumeExtent;

    public uint MaxTextureRepeat;
    public uint MaxTextureAspectRatio;
    public uint MaxAnisotropy;
    public float MaxVertexW;

    public float GuardBandLeft;
    public float GuardBandTop;
    public float GuardBandRight;
    public float GuardBandBottom;

    public float ExtentsAdjust;
    public uint StencilCaps;

    public uint FVFCaps;
    public uint TextureOpCaps;
    public uint MaxTextureBlendStages;
    public uint MaxSimultaneousTextures;

    public uint VertexProcessingCaps;
    public uint MaxActiveLights;
    public uint MaxUserClipPlanes;
    public uint MaxVertexBlendMatrices;
    public uint MaxVertexBlendMatrixIndex;

    public float MaxPointSize;

    public uint MaxPrimitiveCount; // max number of primitives per DrawPrimitive call
    public uint MaxVertexIndex;
    public uint MaxStreams;
    public uint MaxStreamStride; // max stride for SetStreamSource

    public uint VertexShaderVersion;
    public uint MaxVertexShaderConst; // number of vertex shader constant registers

    public uint PixelShaderVersion;
    public float MaxPixelShaderValue; // max value of pixel shader arithmetic component

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DCAPS8 D3DCAPS8;

// 
// BIT DEFINES FOR D3DCAPS8 DWORD MEMBERS
// 

// 
// Caps
// 

// 
// Caps2
// 

// 
// Caps3
// 

// Indicates that the device can respect the ALPHABLENDENABLE render state
// when fullscreen while using the FLIP or DISCARD swap effect.
// COPY and COPYVSYNC swap effects work whether or not this flag is set.

// 
// PresentationIntervals
// 

// 
// CursorCaps
// 
// Driver supports HW color cursor in at least hi-res modes(height >=400)
// Driver supports HW cursor also in low-res modes(height < 400)

// 
// DevCaps
// 

// 
// PrimitiveMiscCaps
// 

// 
// LineCaps
// 

// 
// RasterCaps
// 

// 
// ZCmpCaps, AlphaCmpCaps
// 

// 
// SourceBlendCaps, DestBlendCaps
// 

// 
// ShadeCaps
// 

// 
// TextureCaps
// 
// Device can use non-POW2 textures if:
//  1) D3DTEXTURE_ADDRESS is set to CLAMP for this texture's stage
//  2) D3DRS_WRAP(N) is zero for this texture's coordinates
//  3) mip mapping is not enabled (use magnification filter only)

// 
// TextureFilterCaps
// 

// 
// TextureAddressCaps
// 

// 
// StencilCaps
// 

// 
// TextureOpCaps
// 

// 
// FVFCaps
// 

// 
// VertexProcessingCaps
// 

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack()

#endif // (DIRECT3D_VERSION >= 0x0800)

