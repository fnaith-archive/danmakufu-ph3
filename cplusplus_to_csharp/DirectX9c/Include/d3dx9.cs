/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx9.h
//  Content:    D3DX utility library
// 
/// ///////////////////////////////////////////////////////////////////////////

#if __D3DX_INTERNAL__
#error Incorrect D3DX header used
#endif



// Defines

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_DEFAULT ((UINT) -1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_DEFAULT_NONPOW2 ((UINT) -2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_DEFAULT_FLOAT FLT_MAX
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FROM_FILE ((UINT) -3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DFMT_FROM_FILE ((D3DFORMAT) -3)

#if ! D3DXINLINE
#if _MSC_VER
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
  #if (_MSC_VER >= 1200)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXINLINE __forceinline
  #define D3DXINLINE
  #else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXINLINE __inline
  #define D3DXINLINE
  #endif
#else
  #if __cplusplus
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXINLINE inline
  #define D3DXINLINE
  #else
  #define D3DXINLINE
  #endif
#endif
#endif



// Includes
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3d9.h"
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PI ((FLOAT) 3.141592654f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_1BYPI ((FLOAT) 0.318309886f)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToRadian( degree ) ((degree) * (D3DX_PI / 180.0f))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXToDegree( radian ) ((radian) * (180.0f / D3DX_PI))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_16F_EPSILON 4.8875809e-4f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_16F_MIN 6.1035156e-5f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_ALIGN16 __declspec(align(16))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXMatrixStack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_DONOTSAVESTATE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_DONOTMODIFY_RENDERSTATE (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_OBJECTSPACE (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_BILLBOARD (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_ALPHABLEND (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_SORT_TEXTURE (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_SORT_DEPTH_FRONTTOBACK (1 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSPRITE_SORT_DEPTH_BACKTOFRONT (1 << 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSprite
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFont
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GetTextMetrics GetTextMetricsW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GetTextMetrics GetTextMetricsA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DrawText DrawTextW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DrawText DrawTextA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateFont D3DXCreateFontW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateFont D3DXCreateFontA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateFontIndirect D3DXCreateFontIndirectW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateFontIndirect D3DXCreateFontIndirectA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXRenderToSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXRenderToEnvMap
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLSPEC_UUID( x ) __declspec( uuid( x ) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLSPEC_UUID( x )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFileSaveObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFileSaveData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFileEnumObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFileData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADOBJECT MAKE_HRESULT( 1, _FACD3DXF, 900 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADVALUE MAKE_HRESULT( 1, _FACD3DXF, 901 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADTYPE MAKE_HRESULT( 1, _FACD3DXF, 902 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_NOTFOUND MAKE_HRESULT( 1, _FACD3DXF, 903 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_NOTDONEYET MAKE_HRESULT( 1, _FACD3DXF, 904 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_FILENOTFOUND MAKE_HRESULT( 1, _FACD3DXF, 905 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_RESOURCENOTFOUND MAKE_HRESULT( 1, _FACD3DXF, 906 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADRESOURCE MAKE_HRESULT( 1, _FACD3DXF, 907 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADFILETYPE MAKE_HRESULT( 1, _FACD3DXF, 908 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADFILEVERSION MAKE_HRESULT( 1, _FACD3DXF, 909 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADFILEFLOATSIZE MAKE_HRESULT( 1, _FACD3DXF, 910 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADFILE MAKE_HRESULT( 1, _FACD3DXF, 911 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_PARSEERROR MAKE_HRESULT( 1, _FACD3DXF, 912 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADARRAYSIZE MAKE_HRESULT( 1, _FACD3DXF, 913 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADDATAREFERENCE MAKE_HRESULT( 1, _FACD3DXF, 914 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_NOMOREOBJECTS MAKE_HRESULT( 1, _FACD3DXF, 915 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_NOMOREDATA MAKE_HRESULT( 1, _FACD3DXF, 916 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFERR_BADCACHEFILE MAKE_HRESULT( 1, _FACD3DXF, 917 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define WIN_TYPES(itype, ptype) typedef interface itype *LP##ptype, **LPLP##ptype
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXBaseMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXPMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSPMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define UNUSED16 (0xffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define UNUSED32 (0xffffffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXPatchMesh
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSkinInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadMeshFromX D3DXLoadMeshFromXW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadMeshFromX D3DXLoadMeshFromXA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveMeshToX D3DXSaveMeshToXW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveMeshToX D3DXSaveMeshToXA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXPRTBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXPRTCompBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXTextureGutterHelper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXPRTEngine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadPRTBufferFromFile D3DXLoadPRTBufferFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadPRTBufferFromFile D3DXLoadPRTBufferFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSavePRTBufferToFile D3DXSavePRTBufferToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSavePRTBufferToFile D3DXSavePRTBufferToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadPRTCompBufferFromFile D3DXLoadPRTCompBufferFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadPRTCompBufferFromFile D3DXLoadPRTCompBufferFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSavePRTCompBufferToFile D3DXSavePRTCompBufferToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSavePRTCompBufferToFile D3DXSavePRTCompBufferToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define XSKINEXP_TEMPLATES "xof 0303txt 0032        template XSkinMeshHeader         {             <3CF169CE-FF7C-44ab-93C0-F78F62D172E2>             WORD nMaxSkinWeightsPerVertex;             WORD nMaxSkinWeightsPerFace;             WORD nBones;         }         template VertexDuplicationIndices         {             <B8D65549-D7C9-4995-89CF-53A9A8B031E3>             DWORD nIndices;             DWORD nOriginalVertices;             array DWORD indices[nIndices];         }         template FaceAdjacency         {             <A64C844A-E282-4756-8B80-250CDE04398C>             DWORD nIndices;             array DWORD indices[nIndices];         }         template SkinWeights         {             <6F0D123B-BAD2-4167-A0D0-80224F25FABB>             STRING transformNodeName;             DWORD nWeights;             array DWORD vertexIndices[nWeights];             array float weights[nWeights];             Matrix4x4 matrixOffset;         }         template Patch         {             <A3EB5D44-FC22-429D-9AFB-3221CB9719A6>             DWORD nControlIndices;             array DWORD controlIndices[nControlIndices];         }         template PatchMesh         {             <D02C95CC-EDBA-4305-9B5D-1820D7704BBF>             DWORD nVertices;             array Vector vertices[nVertices];             DWORD nPatches;             array Patch patches[nPatches];             [ ... ]         }         template PatchMesh9         {             <B9EC94E1-B9A6-4251-BA18-94893F02C0EA>             DWORD Type;             DWORD Degree;             DWORD Basis;             DWORD nVertices;             array Vector vertices[nVertices];             DWORD nPatches;             array Patch patches[nPatches];             [ ... ]         } " "template EffectFloats         {             <F1CFE2B3-0DE3-4e28-AFA1-155A750A282D>             DWORD nFloats;             array float Floats[nFloats];         }         template EffectString         {             <D55B097E-BDB6-4c52-B03D-6051C89D0E42>             STRING Value;         }         template EffectDWord         {             <622C0ED0-956E-4da9-908A-2AF94F3CE716>             DWORD Value;         } " "template EffectParamFloats         {             <3014B9A0-62F5-478c-9B86-E4AC9F4E418B>             STRING ParamName;             DWORD nFloats;             array float Floats[nFloats];         } " "template EffectParamString         {             <1DBC4C88-94C1-46ee-9076-2C28818C9481>             STRING ParamName;             STRING Value;         }         template EffectParamDWord         {             <E13963BC-AE51-4c5d-B00F-CFA3A9D97CE5>             STRING ParamName;             DWORD Value;         }         template EffectInstance         {             <E331F7E4-0559-4cc2-8E99-1CEC1657928F>             STRING EffectFilename;             [ ... ]         } " "template AnimTicksPerSecond         {             <9E415A43-7BA6-4a73-8743-B73D47E88476>             DWORD AnimTicksPerSecond;         }         template CompressedAnimationSet         {             <7F9B00B3-F125-4890-876E-1C42BF697C4D>             DWORD CompressedBlockSize;             FLOAT TicksPerSec;             DWORD PlaybackType;             DWORD BufferLength;             array DWORD CompressedData[BufferLength];         } "
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXTX_VERSION(_Major,_Minor) (('T' << 24) | ('X' << 16) | ((_Major) << 8) | (_Minor))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_DEBUG (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_SKIPVALIDATION (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_SKIPOPTIMIZATION (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PACKMATRIX_ROWMAJOR (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PACKMATRIX_COLUMNMAJOR (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PARTIALPRECISION (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_FORCE_VS_SOFTWARE_NOOPT (1 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_FORCE_PS_SOFTWARE_NOOPT (1 << 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_NO_PRESHADER (1 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_AVOID_FLOW_CONTROL (1 << 9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PREFER_FLOW_CONTROL (1 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXConstantTable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXTextureShader
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXFragmentLinker
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXInclude
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromFile D3DXAssembleShaderFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromFile D3DXAssembleShaderFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromResource D3DXAssembleShaderFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXAssembleShaderFromResource D3DXAssembleShaderFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCompileShaderFromFile D3DXCompileShaderFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCompileShaderFromFile D3DXCompileShaderFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCompileShaderFromResource D3DXCompileShaderFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCompileShaderFromResource D3DXCompileShaderFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGatherFragmentsFromFile D3DXGatherFragmentsFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGatherFragmentsFromFile D3DXGatherFragmentsFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGatherFragmentsFromResource D3DXGatherFragmentsFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGatherFragmentsFromResource D3DXGatherFragmentsFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESTATE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESHADERSTATE (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFX_DONOTSAVESAMPLERSTATE (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PARAMETER_SHARED (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PARAMETER_LITERAL (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_PARAMETER_ANNOTATION (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXEffectPool
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXBaseEffect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXEffectStateManager
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXEffect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXEffectCompiler
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromFile D3DXCreateEffectFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromFile D3DXCreateEffectFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromResource D3DXCreateEffectFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectFromResource D3DXCreateEffectFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectCompilerFromFile D3DXCreateEffectCompilerFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectCompilerFromFile D3DXCreateEffectCompilerFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectCompilerFromResource D3DXCreateEffectCompilerFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateEffectCompilerFromResource D3DXCreateEffectCompilerFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_NONE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_POINT (2 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_LINEAR (3 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_TRIANGLE (4 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_BOX (5 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR_U (1 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR_V (2 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR_W (4 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_MIRROR (7 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_DITHER (1 << 19)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_DITHER_DIFFUSION (2 << 19)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_SRGB_IN (1 << 21)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_SRGB_OUT (2 << 21)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_FILTER_SRGB (3 << 21)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_MIRROR_U (1 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_MIRROR_V (2 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_MIRROR (3 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_INVERTSIGN (8 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_NORMALMAP_COMPUTE_OCCLUSION (16 << 16)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_RED (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_BLUE (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_GREEN (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_ALPHA (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DX_CHANNEL_LUMINANCE (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromFile D3DXGetImageInfoFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromFile D3DXGetImageInfoFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromResource D3DXGetImageInfoFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXGetImageInfoFromResource D3DXGetImageInfoFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromFile D3DXLoadSurfaceFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromFile D3DXLoadSurfaceFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromResource D3DXLoadSurfaceFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadSurfaceFromResource D3DXLoadSurfaceFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveSurfaceToFile D3DXSaveSurfaceToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveSurfaceToFile D3DXSaveSurfaceToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromFile D3DXLoadVolumeFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromFile D3DXLoadVolumeFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromResource D3DXLoadVolumeFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadVolumeFromResource D3DXLoadVolumeFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveVolumeToFile D3DXSaveVolumeToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveVolumeToFile D3DXSaveVolumeToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFile D3DXCreateTextureFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFile D3DXCreateTextureFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFile D3DXCreateCubeTextureFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFile D3DXCreateCubeTextureFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFile D3DXCreateVolumeTextureFromFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFile D3DXCreateVolumeTextureFromFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResource D3DXCreateTextureFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResource D3DXCreateTextureFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResource D3DXCreateCubeTextureFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResource D3DXCreateCubeTextureFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResource D3DXCreateVolumeTextureFromResourceW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResource D3DXCreateVolumeTextureFromResourceA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFileEx D3DXCreateTextureFromFileExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromFileEx D3DXCreateTextureFromFileExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFileEx D3DXCreateCubeTextureFromFileExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromFileEx D3DXCreateCubeTextureFromFileExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFileEx D3DXCreateVolumeTextureFromFileExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromFileEx D3DXCreateVolumeTextureFromFileExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResourceEx D3DXCreateTextureFromResourceExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateTextureFromResourceEx D3DXCreateTextureFromResourceExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResourceEx D3DXCreateCubeTextureFromResourceExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateCubeTextureFromResourceEx D3DXCreateCubeTextureFromResourceExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResourceEx D3DXCreateVolumeTextureFromResourceExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateVolumeTextureFromResourceEx D3DXCreateVolumeTextureFromResourceExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveTextureToFile D3DXSaveTextureToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveTextureToFile D3DXSaveTextureToFileA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFilterCubeTexture D3DXFilterTexture
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXFilterVolumeTexture D3DXFilterTexture
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateText D3DXCreateTextW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXCreateText D3DXCreateTextA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXAllocateHierarchy
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXLoadUserData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXSaveUserData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXAnimationSet
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXKeyframedAnimationSet
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXCompressedAnimationSet
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXAnimationCallbackHandler
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE ID3DXAnimationController
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadMeshHierarchyFromX D3DXLoadMeshHierarchyFromXW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXLoadMeshHierarchyFromX D3DXLoadMeshHierarchyFromXA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveMeshHierarchyToFile D3DXSaveMeshHierarchyToFileW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSaveMeshHierarchyToFile D3DXSaveMeshHierarchyToFileA


// Errors
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )

public enum _D3DXERR
{
    D3DXERR_CANNOTMODIFYINDEXBUFFER = MAKE_HRESULT(1, DefineConstants._FACDD, 2900),
    D3DXERR_INVALIDMESH = MAKE_HRESULT(1, DefineConstants._FACDD, 2901),
    D3DXERR_CANNOTATTRSORT = MAKE_HRESULT(1, DefineConstants._FACDD, 2902),
    D3DXERR_SKINNINGNOTSUPPORTED = MAKE_HRESULT(1, DefineConstants._FACDD, 2903),
    D3DXERR_TOOMANYINFLUENCES = MAKE_HRESULT(1, DefineConstants._FACDD, 2904),
    D3DXERR_INVALIDDATA = MAKE_HRESULT(1, DefineConstants._FACDD, 2905),
    D3DXERR_LOADEDMESHASNODATA = MAKE_HRESULT(1, DefineConstants._FACDD, 2906),
    D3DXERR_DUPLICATENAMEDFRAGMENT = MAKE_HRESULT(1, DefineConstants._FACDD, 2907),
    D3DXERR_CANNOTREMOVELASTITEM = MAKE_HRESULT(1, DefineConstants._FACDD, 2908)
}



