// ------------------------------------------------------------------------------
// File: MPEGType.h
// 
// Desc: MPEG system stream compound type definition
// 
// Copyright (c) 1996-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif // __cplusplus

// 
//  AM_MPEGSYSTEMTYPE defines the format block contents for
//  data of type MEDIATYPE_MPEG1System when the format
//  block GUID is FORMAT_MPEG1System
// 
//  The format block consists of elements of type
//  AM_MPEGSYSTEMTYPE up to the length of the format block
//  Each format block is 8-byte aligned from the start of
//  the format block
// 

public class tagAM_MPEGSTREAMTYPE
{
    public uint dwStreamId; // Stream id of stream to process
    public uint dwReserved; // 8-byte alignment
    public AM_MEDIA_TYPE mt = new AM_MEDIA_TYPE(); // Type for substream - pbFormat is NULL
    public byte[] bFormat = new byte[1]; // Format data
}

public class tagAM_MPEGSYSTEMTYPE
{
    public uint dwBitRate; // Bits per second
    public uint cStreams; // Number of streams
    public tagAM_MPEGSTREAMTYPE[] Streams = Arrays.InitializeWithDefaultInstances<tagAM_MPEGSTREAMTYPE>(1);
}