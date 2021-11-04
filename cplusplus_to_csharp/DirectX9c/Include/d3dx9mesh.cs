/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx9mesh.h
//  Content:    D3DX mesh types and functions
// 
/// ///////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3dx9.h"


// {7ED943DD-52E8-40b5-A8D8-76685C406330}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXBaseMesh, 0x7ed943dd, 0x52e8, 0x40b5, 0xa8, 0xd8, 0x76, 0x68, 0x5c, 0x40, 0x63, 0x30);

// {4020E5C2-1403-4929-883F-E2E849FAC195}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXMesh, 0x4020e5c2, 0x1403, 0x4929, 0x88, 0x3f, 0xe2, 0xe8, 0x49, 0xfa, 0xc1, 0x95);

// {8875769A-D579-4088-AAEB-534D1AD84E96}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXPMesh, 0x8875769a, 0xd579, 0x4088, 0xaa, 0xeb, 0x53, 0x4d, 0x1a, 0xd8, 0x4e, 0x96);

// {667EA4C7-F1CD-4386-B523-7C0290B83CC5}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXSPMesh, 0x667ea4c7, 0xf1cd, 0x4386, 0xb5, 0x23, 0x7c, 0x2, 0x90, 0xb8, 0x3c, 0xc5);

// {11EAA540-F9A6-4d49-AE6A-E19221F70CC4}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXSkinInfo, 0x11eaa540, 0xf9a6, 0x4d49, 0xae, 0x6a, 0xe1, 0x92, 0x21, 0xf7, 0xc, 0xc4);

// {3CE6CC22-DBF2-44f4-894D-F9C34A337139}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXPatchMesh, 0x3ce6cc22, 0xdbf2, 0x44f4, 0x89, 0x4d, 0xf9, 0xc3, 0x4a, 0x33, 0x71, 0x39);

// patch mesh can be quads or tris
public enum _D3DXPATCHMESHTYPE
{
    D3DXPATCHMESH_RECT = 0x001,
    D3DXPATCHMESH_TRI = 0x002,
    D3DXPATCHMESH_NPATCH = 0x003,

    D3DXPATCHMESH_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// Mesh options - lower 3 bytes only, upper byte used by _D3DXMESHOPT option flags
public enum _D3DXMESH
{
    D3DXMESH_32BIT = 0x001, // If set, then use 32 bit indices, if not set use 16 bit indices.
    D3DXMESH_DONOTCLIP = 0x002, // Use D3DUSAGE_DONOTCLIP for VB & IB.
    D3DXMESH_POINTS = 0x004, // Use D3DUSAGE_POINTS for VB & IB.
    D3DXMESH_RTPATCHES = 0x008, // Use D3DUSAGE_RTPATCHES for VB & IB.
    D3DXMESH_NPATCHES = 0x4000, // Use D3DUSAGE_NPATCHES for VB & IB.
    D3DXMESH_VB_SYSTEMMEM = 0x010, // Use D3DPOOL_SYSTEMMEM for VB. Overrides D3DXMESH_MANAGEDVERTEXBUFFER
    D3DXMESH_VB_MANAGED = 0x020, // Use D3DPOOL_MANAGED for VB.
    D3DXMESH_VB_WRITEONLY = 0x040, // Use D3DUSAGE_WRITEONLY for VB.
    D3DXMESH_VB_DYNAMIC = 0x080, // Use D3DUSAGE_DYNAMIC for VB.
    D3DXMESH_VB_SOFTWAREPROCESSING = 0x8000, // Use D3DUSAGE_SOFTWAREPROCESSING for VB.
    D3DXMESH_IB_SYSTEMMEM = 0x100, // Use D3DPOOL_SYSTEMMEM for IB. Overrides D3DXMESH_MANAGEDINDEXBUFFER
    D3DXMESH_IB_MANAGED = 0x200, // Use D3DPOOL_MANAGED for IB.
    D3DXMESH_IB_WRITEONLY = 0x400, // Use D3DUSAGE_WRITEONLY for IB.
    D3DXMESH_IB_DYNAMIC = 0x800, // Use D3DUSAGE_DYNAMIC for IB.
    D3DXMESH_IB_SOFTWAREPROCESSING = 0x10000, // Use D3DUSAGE_SOFTWAREPROCESSING for IB.

    D3DXMESH_VB_SHARE = 0x1000, // Valid for Clone* calls only, forces cloned mesh/pmesh to share vertex buffer

    D3DXMESH_USEHWONLY = 0x2000, // Valid for ID3DXSkinInfo::ConvertToBlendedMesh

    // Helper options
    D3DXMESH_SYSTEMMEM = 0x110, // D3DXMESH_VB_SYSTEMMEM | D3DXMESH_IB_SYSTEMMEM
    D3DXMESH_MANAGED = 0x220, // D3DXMESH_VB_MANAGED | D3DXMESH_IB_MANAGED
    D3DXMESH_WRITEONLY = 0x440, // D3DXMESH_VB_WRITEONLY | D3DXMESH_IB_WRITEONLY
    D3DXMESH_DYNAMIC = 0x880, // D3DXMESH_VB_DYNAMIC | D3DXMESH_IB_DYNAMIC
    D3DXMESH_SOFTWAREPROCESSING = 0x18000 // D3DXMESH_VB_SOFTWAREPROCESSING | D3DXMESH_IB_SOFTWAREPROCESSING

}

// patch mesh options
public enum _D3DXPATCHMESH
{
    D3DXPATCHMESH_DEFAULT = 0x0
}
// option field values for specifying min value in D3DXGeneratePMesh and D3DXSimplifyMesh
public enum _D3DXMESHSIMP
{
    D3DXMESHSIMP_VERTEX = 0x1,
    D3DXMESHSIMP_FACE = 0x2

}

public enum _D3DXCLEANTYPE
{
    D3DXCLEAN_BACKFACING = 0x00000001,
    D3DXCLEAN_BOWTIES = 0x00000002,

    // Helper options
    D3DXCLEAN_SKINNING = D3DXCLEAN_BACKFACING, // Bowtie cleaning modifies geometry and breaks skinning
    D3DXCLEAN_OPTIMIZATION = D3DXCLEAN_BACKFACING,
    D3DXCLEAN_SIMPLIFICATION = D3DXCLEAN_BACKFACING | D3DXCLEAN_BOWTIES
}

public enum _MAX_FVF_DECL_SIZE
{
    MAX_FVF_DECL_SIZE = MAXD3DDECLLENGTH + 1 // +1 for END
}


public class _D3DXATTRIBUTERANGE
{
    public uint AttribId;
    public uint FaceStart;
    public uint FaceCount;
    public uint VertexStart;
    public uint VertexCount;
}


public class _D3DXMATERIAL
{
    public D3DMATERIAL9 MatD3D = new D3DMATERIAL9();
    public string pTextureFilename;
}

public enum _D3DXEFFECTDEFAULTTYPE
{
    D3DXEDT_STRING = 0x1, // pValue points to a null terminated ASCII string
    D3DXEDT_FLOATS = 0x2, // pValue points to an array of floats - number of floats is NumBytes / sizeof(float)
    D3DXEDT_DWORD = 0x3, // pValue points to a DWORD

    D3DXEDT_FORCEDWORD = 0x7fffffff
}

public class _D3DXEFFECTDEFAULT
{
    public string pParamName;
    public D3DXEFFECTDEFAULTTYPE Type = new D3DXEFFECTDEFAULTTYPE(); // type of the data pointed to by pValue
    public uint NumBytes; // size in bytes of the data pointed to by pValue
    public object pValue; // data for the default of the effect
}

public class _D3DXEFFECTINSTANCE
{
    public string pEffectFilename;
    public uint NumDefaults;
    public _D3DXEFFECTDEFAULT pDefaults;
}

public class _D3DXATTRIBUTEWEIGHTS
{
    public float Position;
    public float Boundary;
    public float Normal;
    public float Diffuse;
    public float Specular;
    public float[] Texcoord = new float[8];
    public float Tangent;
    public float Binormal;
}

public enum _D3DXWELDEPSILONSFLAGS
{
    D3DXWELDEPSILONS_WELDALL = 0x1, // weld all vertices marked by adjacency as being overlapping

    D3DXWELDEPSILONS_WELDPARTIALMATCHES = 0x2, // if a given vertex component is within epsilon, modify partial matched
                                                    // vertices so that both components identical AND if all components "equal"
                                                    // remove one of the vertices
    D3DXWELDEPSILONS_DONOTREMOVEVERTICES = 0x4, // instructs weld to only allow modifications to vertices and not removal
                                                    // ONLY valid if D3DXWELDEPSILONS_WELDPARTIALMATCHES is set
                                                    // useful to modify vertices to be equal, but not allow vertices to be removed

    D3DXWELDEPSILONS_DONOTSPLIT = 0x8 // instructs weld to specify the D3DXMESHOPT_DONOTSPLIT flag when doing an Optimize(ATTR_SORT)
                                                    // if this flag is not set, all vertices that are in separate attribute groups
                                                    // will remain split and not welded.  Setting this flag can slow down software vertex processing

}

public class _D3DXWELDEPSILONS
{
    public float Position; // NOTE: This does NOT replace the epsilon in GenerateAdjacency
                                            // in general, it should be the same value or greater than the one passed to GeneratedAdjacency
    public float BlendWeights;
    public float Normal;
    public float PSize;
    public float Specular;
    public float Diffuse;
    public float[] Texcoord = new float[8];
    public float Tangent;
    public float Binormal;
    public float TessFactor;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define UNUSED16 (0xffff)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define UNUSED32 (0xffffffff)

// ID3DXMesh::Optimize options - upper byte only, lower 3 bytes used from _D3DXMESH option flags
public enum _D3DXMESHOPT
{
    D3DXMESHOPT_COMPACT = 0x01000000,
    D3DXMESHOPT_ATTRSORT = 0x02000000,
    D3DXMESHOPT_VERTEXCACHE = 0x04000000,
    D3DXMESHOPT_STRIPREORDER = 0x08000000,
    D3DXMESHOPT_IGNOREVERTS = 0x10000000, // optimize faces only, don't touch vertices
    D3DXMESHOPT_DONOTSPLIT = 0x20000000, // do not split vertices shared between attribute groups when attribute sorting
    D3DXMESHOPT_DEVICEINDEPENDENT = 0x00400000 // Only affects VCache.  uses a static known good cache size for all cards

    // D3DXMESHOPT_SHAREVB has been removed, please use D3DXMESH_VB_SHARE instead

}

// Subset of the mesh that has the same attribute and bone combination.
// This subset can be rendered in a single draw call
public class _D3DXBONECOMBINATION
{
    public uint AttribId;
    public uint FaceStart;
    public uint FaceCount;
    public uint VertexStart;
    public uint VertexCount;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint* BoneId;
    public uint BoneId;
}

// The following types of patch combinations are supported:
// Patch type   Basis       Degree
// Rect         Bezier      2,3,5
// Rect         B-Spline    2,3,5
// Rect         Catmull-Rom 3
// Tri          Bezier      2,3,5
// N-Patch      N/A         3

public class _D3DXPATCHINFO
{
    public D3DXPATCHMESHTYPE PatchType = new D3DXPATCHMESHTYPE();
    public D3DDEGREETYPE Degree = new D3DDEGREETYPE();
    public D3DBASISTYPE Basis = new D3DBASISTYPE();
}

public class _D3DXINTERSECTINFO
{
    public uint FaceIndex; // index of face intersected
    public float U; // Barycentric Hit Coordinates
    public float V; // Barycentric Hit Coordinates
    public float Dist; // Ray-Intersection Parameter Distance
}


// ===========================================================================
// 
//  Data structures for Spherical Harmonic Precomputation
// 
// 
// ============================================================================

public enum _D3DXSHCOMPRESSQUALITYTYPE
{
    D3DXSHCQUAL_FASTLOWQUALITY = 1,
    D3DXSHCQUAL_SLOWHIGHQUALITY = 2,
    D3DXSHCQUAL_FORCE_DWORD = 0x7fffffff
}

public enum _D3DXSHGPUSIMOPT
{
    D3DXSHGPUSIMOPT_SHADOWRES256 = 1,
    D3DXSHGPUSIMOPT_SHADOWRES512 = 0,
    D3DXSHGPUSIMOPT_SHADOWRES1024 = 2,
    D3DXSHGPUSIMOPT_SHADOWRES2048 = 3,

    D3DXSHGPUSIMOPT_HIGHQUALITY = 4,

    D3DXSHGPUSIMOPT_FORCE_DWORD = 0x7fffffff
}

// for all properties that are colors the luminance is computed
// if the simulator is run with a single channel using the following
// formula:  R * 0.2125 + G * 0.7154 + B * 0.0721

public class _D3DXSHMATERIAL
{
    public D3DCOLORVALUE Diffuse = new D3DCOLORVALUE(); // Diffuse albedo of the surface.  (Ignored if object is a Mirror)
    public bool bMirror; // Must be set to FALSE.  bMirror == TRUE not currently supported
    public bool bSubSurf; // true if the object does subsurface scattering - can't do this and be a mirror

    // subsurface scattering parameters 
    public float RelativeIndexOfRefraction;
    public D3DCOLORVALUE Absorption = new D3DCOLORVALUE();
    public D3DCOLORVALUE ReducedScattering = new D3DCOLORVALUE();

}

// allocated in D3DXSHPRTCompSplitMeshSC
// vertices are duplicated into multiple super clusters but
// only have a valid status in one super cluster (fill in the rest)

public class _D3DXSHPRTSPLITMESHVERTDATA
{
    public uint uVertRemap; // vertex in original mesh this corresponds to
    public uint uSubCluster; // cluster index relative to super cluster
    public byte ucVertStatus; // 1 if vertex has valid data, 0 if it is "fill"
}

// used in D3DXSHPRTCompSplitMeshSC
// information for each super cluster that maps into face/vert arrays

public class _D3DXSHPRTSPLITMESHCLUSTERDATA
{
    public uint uVertStart; // initial index into remapped vertex array
    public uint uVertLength; // number of vertices in this super cluster

    public uint uFaceStart; // initial index into face array
    public uint uFaceLength; // number of faces in this super cluster

    public uint uClusterStart; // initial index into cluster array
    public uint uClusterLength; // number of clusters in this super cluster
}

// call back function for simulator
// return S_OK to keep running the simulator - anything else represents
// failure and the simulator will abort.

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(WINAPI *LPD3DXSHPRTSIMCB)(float fPercentDone, object* lpUserContext);
public delegate int LPD3DXSHPRTSIMCB(float fPercentDone, object lpUserContext);

// interfaces for PRT buffers/simulator

// GUIDs
// {F1827E47-00A8-49cd-908C-9D11955F8728}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXPRTBuffer, 0xf1827e47, 0xa8, 0x49cd, 0x90, 0x8c, 0x9d, 0x11, 0x95, 0x5f, 0x87, 0x28);

// {A758D465-FE8D-45ad-9CF0-D01E56266A07}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXPRTCompBuffer, 0xa758d465, 0xfe8d, 0x45ad, 0x9c, 0xf0, 0xd0, 0x1e, 0x56, 0x26, 0x6a, 0x7);

// {06F57E0A-BD95-43f1-A3DA-791CF6CA297B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXTextureGutterHelper, 0x6f57e0a, 0xbd95, 0x43f1, 0xa3, 0xda, 0x79, 0x1c, 0xf6, 0xca, 0x29, 0x7b);

// {C3F4ADBF-E6D2-4b7b-BFE8-9E7208746ADF}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXPRTEngine, 0xc3f4adbf, 0xe6d2, 0x4b7b, 0xbf, 0xe8, 0x9e, 0x72, 0x8, 0x74, 0x6a, 0xdf);

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(push, 1)
public class _XFILECOMPRESSEDANIMATIONSET
{
    public uint CompressedBlockSize;
    public float TicksPerSec;
    public uint PlaybackType;
    public uint BufferLength;
}
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(pop)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define XSKINEXP_TEMPLATES "xof 0303txt 0032        template XSkinMeshHeader         {             <3CF169CE-FF7C-44ab-93C0-F78F62D172E2>             WORD nMaxSkinWeightsPerVertex;             WORD nMaxSkinWeightsPerFace;             WORD nBones;         }         template VertexDuplicationIndices         {             <B8D65549-D7C9-4995-89CF-53A9A8B031E3>             DWORD nIndices;             DWORD nOriginalVertices;             array DWORD indices[nIndices];         }         template FaceAdjacency         {             <A64C844A-E282-4756-8B80-250CDE04398C>             DWORD nIndices;             array DWORD indices[nIndices];         }         template SkinWeights         {             <6F0D123B-BAD2-4167-A0D0-80224F25FABB>             STRING transformNodeName;             DWORD nWeights;             array DWORD vertexIndices[nWeights];             array float weights[nWeights];             Matrix4x4 matrixOffset;         }         template Patch         {             <A3EB5D44-FC22-429D-9AFB-3221CB9719A6>             DWORD nControlIndices;             array DWORD controlIndices[nControlIndices];         }         template PatchMesh         {             <D02C95CC-EDBA-4305-9B5D-1820D7704BBF>             DWORD nVertices;             array Vector vertices[nVertices];             DWORD nPatches;             array Patch patches[nPatches];             [ ... ]         }         template PatchMesh9         {             <B9EC94E1-B9A6-4251-BA18-94893F02C0EA>             DWORD Type;             DWORD Degree;             DWORD Basis;             DWORD nVertices;             array Vector vertices[nVertices];             DWORD nPatches;             array Patch patches[nPatches];             [ ... ]         } " "template EffectFloats         {             <F1CFE2B3-0DE3-4e28-AFA1-155A750A282D>             DWORD nFloats;             array float Floats[nFloats];         }         template EffectString         {             <D55B097E-BDB6-4c52-B03D-6051C89D0E42>             STRING Value;         }         template EffectDWord         {             <622C0ED0-956E-4da9-908A-2AF94F3CE716>             DWORD Value;         } " "template EffectParamFloats         {             <3014B9A0-62F5-478c-9B86-E4AC9F4E418B>             STRING ParamName;             DWORD nFloats;             array float Floats[nFloats];         } " "template EffectParamString         {             <1DBC4C88-94C1-46ee-9076-2C28818C9481>             STRING ParamName;             STRING Value;         }         template EffectParamDWord         {             <E13963BC-AE51-4c5d-B00F-CFA3A9D97CE5>             STRING ParamName;             DWORD Value;         }         template EffectInstance         {             <E331F7E4-0559-4cc2-8E99-1CEC1657928F>             STRING EffectFilename;             [ ... ]         } " "template AnimTicksPerSecond         {             <9E415A43-7BA6-4a73-8743-B73D47E88476>             DWORD AnimTicksPerSecond;         }         template CompressedAnimationSet         {             <7F9B00B3-F125-4890-876E-1C42BF697C4D>             DWORD CompressedBlockSize;             FLOAT TicksPerSec;             DWORD PlaybackType;             DWORD BufferLength;             array DWORD CompressedData[BufferLength];         } "




