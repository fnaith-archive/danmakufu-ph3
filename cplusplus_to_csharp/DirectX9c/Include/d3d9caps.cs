/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       d3d9caps.h
 *  Content:    Direct3D capabilities include file
 *
 ***************************************************************************/



// include this file content only if compiling for DX9 interfaces
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECT3D_VERSION >= 0x0900)

#if _X86_ || _IA64
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(4)
#endif

public class _D3DVSHADERCAPS2_0
{
        public uint Caps;
        public int DynamicFlowControlDepth;
        public int NumTemps;
        public int StaticFlowControlDepth;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DVSHADERCAPS2_0 D3DVSHADERCAPS2_0;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DVS20CAPS_PREDICATION (1<<0)


public class _D3DPSHADERCAPS2_0
{
    public uint Caps;
    public int DynamicFlowControlDepth;
    public int NumTemps;
    public int StaticFlowControlDepth;
    public int NumInstructionSlots;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DPSHADERCAPS2_0 D3DPSHADERCAPS2_0;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_ARBITRARYSWIZZLE (1<<0)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_GRADIENTINSTRUCTIONS (1<<1)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_PREDICATION (1<<2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_NODEPENDENTREADLIMIT (1<<3)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DPS20CAPS_NOTEXINSTRUCTIONLIMIT (1<<4)



public class _D3DCAPS9
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
    public uint TextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DTexture9's
    public uint CubeTextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DCubeTexture9's
    public uint VolumeTextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DVolumeTexture9's
    public uint TextureAddressCaps; // D3DPTADDRESSCAPS for IDirect3DTexture9's
    public uint VolumeTextureAddressCaps; // D3DPTADDRESSCAPS for IDirect3DVolumeTexture9's

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
    public float PixelShader1xMaxValue; // max value storable in registers of ps.1.x shaders

    // Here are the DX9 specific ones
    public uint DevCaps2;

    public float MaxNpatchTessellationLevel;
    public uint Reserved5;

    public uint MasterAdapterOrdinal; // ordinal of master adaptor for adapter group
    public uint AdapterOrdinalInGroup; // ordinal inside the adapter group
    public uint NumberOfAdaptersInGroup; // number of adapters in this adapter group (only if master)
    public uint DeclTypes; // Data types, supported in vertex declarations
    public uint NumSimultaneousRTs; // Will be at least 1
    public uint StretchRectFilterCaps; // Filter caps supported by StretchRect
    public _D3DVSHADERCAPS2_0 VS20Caps = new _D3DVSHADERCAPS2_0();
    public _D3DPSHADERCAPS2_0 PS20Caps = new _D3DPSHADERCAPS2_0();
    public uint VertexTextureFilterCaps; // D3DPTFILTERCAPS for IDirect3DTexture9's for texture, used in vertex shaders
    public uint MaxVShaderInstructionsExecuted; // maximum number of vertex shader instructions that can be executed
    public uint MaxPShaderInstructionsExecuted; // maximum number of pixel shader instructions that can be executed
    public uint MaxVertexShader30InstructionSlots;
    public uint MaxPixelShader30InstructionSlots;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _D3DCAPS9 D3DCAPS9;

// 
// BIT DEFINES FOR D3DCAPS9 DWORD MEMBERS
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

// Indicates that the device can perform a gamma correction from 
// a windowed back buffer containing linear content to the sRGB desktop.



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
// TextureFilterCaps, StretchRectFilterCaps
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

// 
// DevCaps2
// 

// 
// DeclTypes
// 


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack()

#endif // (DIRECT3D_VERSION >= 0x0900)

