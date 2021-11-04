// ------------------------------------------------------------------------------
// File: AMVA.h
// 
// Desc: DirectShowMotionComp include file.
// 
// Copyright (c) 1997-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif



//  Flags for QueryRenderStatus
                                                     // set this bit to 0
                                                     // if query for update

public class _tag_AMVAUncompBufferInfo
{
     public uint dwMinNumSurfaces; // IN   min number of surfaces to be allocated
     public uint dwMaxNumSurfaces; // IN   max number of surfaces to be allocated
     public DDPIXELFORMAT ddUncompPixelFormat = new DDPIXELFORMAT(); // IN   pixel format of surfaces to be allocated
}

public class _tag_AMVAUncompDataInfo
{
    public uint dwUncompWidth; // [in]     width of uncompressed data
    public uint dwUncompHeight; // [in]     height of uncompressed data
    public DDPIXELFORMAT ddUncompPixelFormat = new DDPIXELFORMAT(); // [in]     pixel-format of uncompressed data
}

public class _tag_AMVAInternalMemInfo
{
    public uint dwScratchMemAlloc; // [out]    amount of scratch memory will the hal allocate for its private use
}


public class _tag_AMVACompBufferInfo
{
    public uint dwNumCompBuffers; // [out]    number of buffers reqd for compressed data
    public uint dwWidthToCreate; // [out]    Width of surface to create
    public uint dwHeightToCreate; // [out]    Height of surface to create
    public uint dwBytesToAllocate; // [out]    Total number of bytes used by each surface
    public DDSCAPS2 ddCompCaps = new DDSCAPS2(); // [out]    caps to create surfaces to store compressed data
    public DDPIXELFORMAT ddPixelFormat = new DDPIXELFORMAT(); // [out]    fourcc to create surfaces to store compressed data
}


// Note that you are NOT allowed to store any pointer in pMiscData
public class _tag_AMVABeginFrameInfo
{
    public uint dwDestSurfaceIndex; // IN  destination buffer in which to decoding this frame
    public object pInputData; // IN  pointer to misc data
    public uint dwSizeInputData; // IN  size of other misc data to begin frame
    public object pOutputData; // OUT pointer to data which the VGA is going to fill
    public uint dwSizeOutputData; // IN  size of data which the VGA is going to fill
}

// Note that you are NOT allowed to store any pointer in pMiscData
public class _tag_AMVAEndFrameInfo
{
    public uint dwSizeMiscData; // [in]     size of other misc data to begin frame
    public object pMiscData; // [in]     pointer to misc data
}

public class _tag_AMVABUFFERINFO
{
    public uint dwTypeIndex; // [in]    Type of buffer
    public uint dwBufferIndex; // [in]    Buffer index
    public uint dwDataOffset; // [in]    offset of relevant data from the beginning of buffer
    public uint dwDataSize; // [in]    size of relevant data
}

#if __cplusplus
#endif

