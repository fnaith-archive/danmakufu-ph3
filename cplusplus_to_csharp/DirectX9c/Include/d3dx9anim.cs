/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx9anim.h
//  Content:    D3DX mesh types and functions
// 
/// ///////////////////////////////////////////////////////////////////////////


// {698CFB3F-9289-4d95-9A57-33A94B5A65F9}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXAnimationSet, 0x698cfb3f, 0x9289, 0x4d95, 0x9a, 0x57, 0x33, 0xa9, 0x4b, 0x5a, 0x65, 0xf9);

// {FA4E8E3A-9786-407d-8B4C-5995893764AF}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXKeyframedAnimationSet, 0xfa4e8e3a, 0x9786, 0x407d, 0x8b, 0x4c, 0x59, 0x95, 0x89, 0x37, 0x64, 0xaf);

// {6CC2480D-3808-4739-9F88-DE49FACD8D4C}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXCompressedAnimationSet, 0x6cc2480d, 0x3808, 0x4739, 0x9f, 0x88, 0xde, 0x49, 0xfa, 0xcd, 0x8d, 0x4c);

// {AC8948EC-F86D-43e2-96DE-31FC35F96D9E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXAnimationController, 0xac8948ec, 0xf86d, 0x43e2, 0x96, 0xde, 0x31, 0xfc, 0x35, 0xf9, 0x6d, 0x9e);


// ----------------------------------------------------------------------------
// D3DXMESHDATATYPE:
// -----------------
// This enum defines the type of mesh data present in a MeshData structure.
// ----------------------------------------------------------------------------
public enum _D3DXMESHDATATYPE
{
    D3DXMESHTYPE_MESH = 0x001, // Normal ID3DXMesh data
    D3DXMESHTYPE_PMESH = 0x002, // Progressive Mesh - ID3DXPMesh
    D3DXMESHTYPE_PATCHMESH = 0x003, // Patch Mesh - ID3DXPatchMesh

    D3DXMESHTYPE_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// ----------------------------------------------------------------------------
// D3DXMESHDATA:
// -------------
// This struct encapsulates a the mesh data that can be present in a mesh 
// container.  The supported mesh types are pMesh, pPMesh, pPatchMesh.
// The valid way to access this is determined by the Type enum.
// ----------------------------------------------------------------------------
public class _D3DXMESHDATA
{
    public D3DXMESHDATATYPE Type = new D3DXMESHDATATYPE();

    // current mesh data interface
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        LPD3DXMESH pMesh;
//        LPD3DXPMESH pPMesh;
//        LPD3DXPATCHMESH pPatchMesh;
//    };
}

// ----------------------------------------------------------------------------
// D3DXMESHCONTAINER:
// ------------------
// This struct encapsulates a mesh object in a transformation frame
// hierarchy. The app can derive from this structure to add other app specific
// data to this.
// ----------------------------------------------------------------------------
public class _D3DXMESHCONTAINER
{
    public string Name;

    public _D3DXMESHDATA MeshData = new _D3DXMESHDATA();

    public LPD3DXMATERIAL pMaterials = new LPD3DXMATERIAL();
    public LPD3DXEFFECTINSTANCE pEffects = new LPD3DXEFFECTINSTANCE();
    public uint NumMaterials;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint *pAdjacency;
    public uint pAdjacency;

    public LPD3DXSKININFO pSkinInfo = new LPD3DXSKININFO();

    public _D3DXMESHCONTAINER pNextMeshContainer;
}

// ----------------------------------------------------------------------------
// D3DXFRAME:
// ----------
// This struct is the encapsulates a transform frame in a transformation frame
// hierarchy. The app can derive from this structure to add other app specific
// data to this
// ----------------------------------------------------------------------------
public class _D3DXFRAME
{
    public string Name;
    public D3DXMATRIX TransformationMatrix = new D3DXMATRIX();

    public _D3DXMESHCONTAINER pMeshContainer;

    public _D3DXFRAME pFrameSibling;
    public _D3DXFRAME pFrameFirstChild;
}


// ----------------------------------------------------------------------------
// D3DXCALLBACK_SEARCH_FLAGS:
// --------------------------
// Flags that can be passed into ID3DXAnimationSet::GetCallback. 
// ----------------------------------------------------------------------------
public enum _D3DXCALLBACK_SEARCH_FLAGS
{
    D3DXCALLBACK_SEARCH_EXCLUDING_INITIAL_POSITION = 0x01, // exclude callbacks at the initial position from the search
    D3DXCALLBACK_SEARCH_BEHIND_INITIAL_POSITION = 0x02, // reverse the callback search direction

    D3DXCALLBACK_SEARCH_FORCE_DWORD = 0x7fffffff
}


// ----------------------------------------------------------------------------
// D3DXPLAYBACK_TYPE:
// ------------------
// This enum defines the type of animation set loop modes.
// ----------------------------------------------------------------------------
public enum _D3DXPLAYBACK_TYPE
{
    D3DXPLAY_LOOP = 0,
    D3DXPLAY_ONCE = 1,
    D3DXPLAY_PINGPONG = 2,

    D3DXPLAY_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}


// ----------------------------------------------------------------------------
// D3DXKEY_VECTOR3:
// ----------------
// This structure describes a vector key for use in keyframe animation.
// It specifies a vector Value at a given Time. This is used for scale and
// translation keys.
// ----------------------------------------------------------------------------
public class _D3DXKEY_VECTOR3
{
    public float Time;
    public D3DXVECTOR3 Value = new D3DXVECTOR3();
}


// ----------------------------------------------------------------------------
// D3DXKEY_QUATERNION:
// -------------------
// This structure describes a quaternion key for use in keyframe animation.
// It specifies a quaternion Value at a given Time. This is used for rotation
// keys.
// ----------------------------------------------------------------------------
public class _D3DXKEY_QUATERNION
{
    public float Time;
    public D3DXQUATERNION Value = new D3DXQUATERNION();
}


// ----------------------------------------------------------------------------
// D3DXKEY_CALLBACK:
// -----------------
// This structure describes an callback key for use in keyframe animation.
// It specifies a pointer to user data at a given Time. 
// ----------------------------------------------------------------------------
public class _D3DXKEY_CALLBACK
{
    public float Time;
    public object pCallbackData;
}


// ----------------------------------------------------------------------------
// D3DXCOMPRESSION_FLAGS:
// ----------------------
// Flags that can be passed into ID3DXKeyframedAnimationSet::Compress. 
// ----------------------------------------------------------------------------
public enum _D3DXCOMPRESSION_FLAGS
{
    D3DXCOMPRESS_DEFAULT = 0x00,

    D3DXCOMPRESS_FORCE_DWORD = 0x7fffffff
}


// ----------------------------------------------------------------------------
// D3DXPRIORITY_TYPE:
// ------------------
// This enum defines the type of priority group that a track can be assigned to.
// ----------------------------------------------------------------------------
public enum _D3DXPRIORITY_TYPE
{
    D3DXPRIORITY_LOW = 0, // This track should be blended with all low priority tracks before mixed with the high priority result
    D3DXPRIORITY_HIGH = 1, // This track should be blended with all high priority tracks before mixed with the low priority result

    D3DXPRIORITY_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// ----------------------------------------------------------------------------
// D3DXTRACK_DESC:
// ---------------
// This structure describes the mixing information of an animation track. 
// The mixing information consists of the current position, speed, and blending 
// weight for the track.  The Flags field also specifies whether the track is 
// low or high priority.  Tracks with the same priority are blended together
// and then the two resulting values are blended using the priority blend factor.
// A track also has an animation set (stored separately) associated with it.  
// ----------------------------------------------------------------------------
public class _D3DXTRACK_DESC
{
    public D3DXPRIORITY_TYPE Priority = new D3DXPRIORITY_TYPE();
    public float Weight;
    public float Speed;
    public double Position;
    public bool Enable;
}

// ----------------------------------------------------------------------------
// D3DXEVENT_TYPE:
// ---------------
// This enum defines the type of events keyable via the animation controller.
// ----------------------------------------------------------------------------
public enum _D3DXEVENT_TYPE
{
    D3DXEVENT_TRACKSPEED = 0,
    D3DXEVENT_TRACKWEIGHT = 1,
    D3DXEVENT_TRACKPOSITION = 2,
    D3DXEVENT_TRACKENABLE = 3,
    D3DXEVENT_PRIORITYBLEND = 4,

    D3DXEVENT_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// ----------------------------------------------------------------------------
// D3DXTRANSITION_TYPE:
// --------------------
// This enum defines the type of transtion performed on a event that 
// transitions from one value to another.
// ----------------------------------------------------------------------------
public enum _D3DXTRANSITION_TYPE
{
    D3DXTRANSITION_LINEAR = 0x000, // Linear transition from one value to the next
    D3DXTRANSITION_EASEINEASEOUT = 0x001, // Ease-In Ease-Out spline transtion from one value to the next

    D3DXTRANSITION_FORCE_DWORD = 0x7fffffff // force 32-bit size enum
}

// ----------------------------------------------------------------------------
// D3DXEVENT_DESC:
// ---------------
// This structure describes a animation controller event.
// It gives the event's type, track (if the event is a track event), global 
// start time, duration, transition method, and target value.
// ----------------------------------------------------------------------------
public class _D3DXEVENT_DESC
{
    public D3DXEVENT_TYPE Type = new D3DXEVENT_TYPE();
    public uint Track;
    public double StartTime;
    public double Duration;
    public D3DXTRANSITION_TYPE Transition = new D3DXTRANSITION_TYPE();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        float Weight;
//        float Speed;
//        double Position;
//        bool Enable;
//    };
}