/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  File:       d3dx9effect.h
//  Content:    D3DX effect types and Shaders
// 
/// ///////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3dx9.h"



// ----------------------------------------------------------------------------
// D3DXFX_DONOTSAVESTATE
//   This flag is used as a parameter to ID3DXEffect::Begin().  When this flag
//   is specified, device state is not saved or restored in Begin/End.
// D3DXFX_DONOTSAVESHADERSTATE
//   This flag is used as a parameter to ID3DXEffect::Begin().  When this flag
//   is specified, shader device state is not saved or restored in Begin/End.
//   This includes pixel/vertex shaders and shader constants
// D3DXFX_DONOTSAVESAMPLERSTATE
//   This flag is used as a parameter to ID3DXEffect::Begin(). When this flag
//   is specified, sampler device state is not saved or restored in Begin/End.
// ----------------------------------------------------------------------------

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESTATE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESHADERSTATE (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESAMPLERSTATE (1 << 2)


// ----------------------------------------------------------------------------
// D3DX_PARAMETER_SHARED
//   Indicates that the value of a parameter will be shared with all effects
//   which share the same namespace.  Changing the value in one effect will
//   change it in all.
// 
// D3DX_PARAMETER_LITERAL
//   Indicates that the value of this parameter can be treated as literal.
//   Literal parameters can be marked when the effect is compiled, and their
//   cannot be changed after the effect is compiled.  Shared parameters cannot
//   be literal.
// ----------------------------------------------------------------------------

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PARAMETER_SHARED (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PARAMETER_LITERAL (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PARAMETER_ANNOTATION (1 << 2)


// ----------------------------------------------------------------------------
// D3DXEFFECT_DESC:
// ----------------------------------------------------------------------------

public partial class _D3DXEFFECT_DESC
{
    public readonly string Creator; // Creator string
    public uint Parameters; // Number of parameters
    public uint Techniques; // Number of techniques
    public uint Functions; // Number of function entrypoints

}


// ----------------------------------------------------------------------------
// D3DXPARAMETER_DESC:
// ----------------------------------------------------------------------------

public partial class _D3DXPARAMETER_DESC
{
    public readonly string Name; // Parameter name
    public readonly string Semantic; // Parameter semantic
    public D3DXPARAMETER_CLASS Class = new D3DXPARAMETER_CLASS(); // Class
    public D3DXPARAMETER_TYPE Type = new D3DXPARAMETER_TYPE(); // Component type
    public uint Rows; // Number of rows
    public uint Columns; // Number of columns
    public uint Elements; // Number of array elements
    public uint Annotations; // Number of annotations
    public uint StructMembers; // Number of structure member sub-parameters
    public uint Flags; // D3DX_PARAMETER_* flags
    public uint Bytes; // Parameter size, in bytes

}


// ----------------------------------------------------------------------------
// D3DXTECHNIQUE_DESC:
// ----------------------------------------------------------------------------

public partial class _D3DXTECHNIQUE_DESC
{
    public readonly string Name; // Technique name
    public uint Passes; // Number of passes
    public uint Annotations; // Number of annotations

}


// ----------------------------------------------------------------------------
// D3DXPASS_DESC:
// ----------------------------------------------------------------------------

public partial class _D3DXPASS_DESC
{
    public readonly string Name; // Pass name
    public uint Annotations; // Number of annotations

    public CONST uint * pVertexShaderFunction = new CONST(); // Vertex shader function
    public CONST uint * pPixelShaderFunction = new CONST(); // Pixel shader function

}


// ----------------------------------------------------------------------------
// D3DXFUNCTION_DESC:
// ----------------------------------------------------------------------------

public class _D3DXFUNCTION_DESC
{
    public readonly string Name; // Function name
    public uint Annotations; // Number of annotations

}



/// ///////////////////////////////////////////////////////////////////////////
// ID3DXEffectPool ///////////////////////////////////////////////////////////
/// ///////////////////////////////////////////////////////////////////////////


// {9537AB04-3250-412e-8213-FCD2F8677933}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXEffectPool, 0x9537ab04, 0x3250, 0x412e, 0x82, 0x13, 0xfc, 0xd2, 0xf8, 0x67, 0x79, 0x33);