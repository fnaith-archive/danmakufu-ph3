// ------------------------------------------------------------------------------
// File: DMOReg.h
// 
// Desc: 
// 
// Copyright (c) 1999 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaBuffer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaBuffer_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaBuffer_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaBuffer_SetLength(This,cbLength) (This)->lpVtbl -> SetLength(This,cbLength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaBuffer_GetMaxLength(This,pcbMaxLength) (This)->lpVtbl -> GetMaxLength(This,pcbMaxLength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaBuffer_GetBufferAndLength(This,ppBuffer,pcbLength) (This)->lpVtbl -> GetBufferAndLength(This,ppBuffer,pcbLength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetStreamCount(This,pcInputStreams,pcOutputStreams) (This)->lpVtbl -> GetStreamCount(This,pcInputStreams,pcOutputStreams)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetInputStreamInfo(This,dwInputStreamIndex,pdwFlags) (This)->lpVtbl -> GetInputStreamInfo(This,dwInputStreamIndex,pdwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetOutputStreamInfo(This,dwOutputStreamIndex,pdwFlags) (This)->lpVtbl -> GetOutputStreamInfo(This,dwOutputStreamIndex,pdwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetInputType(This,dwInputStreamIndex,dwTypeIndex,pmt) (This)->lpVtbl -> GetInputType(This,dwInputStreamIndex,dwTypeIndex,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetOutputType(This,dwOutputStreamIndex,dwTypeIndex,pmt) (This)->lpVtbl -> GetOutputType(This,dwOutputStreamIndex,dwTypeIndex,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_SetInputType(This,dwInputStreamIndex,pmt,dwFlags) (This)->lpVtbl -> SetInputType(This,dwInputStreamIndex,pmt,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_SetOutputType(This,dwOutputStreamIndex,pmt,dwFlags) (This)->lpVtbl -> SetOutputType(This,dwOutputStreamIndex,pmt,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetInputCurrentType(This,dwInputStreamIndex,pmt) (This)->lpVtbl -> GetInputCurrentType(This,dwInputStreamIndex,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetOutputCurrentType(This,dwOutputStreamIndex,pmt) (This)->lpVtbl -> GetOutputCurrentType(This,dwOutputStreamIndex,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetInputSizeInfo(This,dwInputStreamIndex,pcbSize,pcbMaxLookahead,pcbAlignment) (This)->lpVtbl -> GetInputSizeInfo(This,dwInputStreamIndex,pcbSize,pcbMaxLookahead,pcbAlignment)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetOutputSizeInfo(This,dwOutputStreamIndex,pcbSize,pcbAlignment) (This)->lpVtbl -> GetOutputSizeInfo(This,dwOutputStreamIndex,pcbSize,pcbAlignment)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetInputMaxLatency(This,dwInputStreamIndex,prtMaxLatency) (This)->lpVtbl -> GetInputMaxLatency(This,dwInputStreamIndex,prtMaxLatency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_SetInputMaxLatency(This,dwInputStreamIndex,rtMaxLatency) (This)->lpVtbl -> SetInputMaxLatency(This,dwInputStreamIndex,rtMaxLatency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_Flush(This) (This)->lpVtbl -> Flush(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_Discontinuity(This,dwInputStreamIndex) (This)->lpVtbl -> Discontinuity(This,dwInputStreamIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_AllocateStreamingResources(This) (This)->lpVtbl -> AllocateStreamingResources(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_FreeStreamingResources(This) (This)->lpVtbl -> FreeStreamingResources(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_GetInputStatus(This,dwInputStreamIndex,dwFlags) (This)->lpVtbl -> GetInputStatus(This,dwInputStreamIndex,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_ProcessInput(This,dwInputStreamIndex,pBuffer,dwFlags,rtTimestamp,rtTimelength) (This)->lpVtbl -> ProcessInput(This,dwInputStreamIndex,pBuffer,dwFlags,rtTimestamp,rtTimelength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_ProcessOutput(This,dwFlags,cOutputBufferCount,pOutputBuffers,pdwStatus) (This)->lpVtbl -> ProcessOutput(This,dwFlags,cOutputBufferCount,pOutputBuffers,pdwStatus)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObject_Lock(This,bLock) (This)->lpVtbl -> Lock(This,bLock)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_Next(This,cItemsToFetch,pCLSID,Names,pcItemsFetched) (This)->lpVtbl -> Next(This,cItemsToFetch,pCLSID,Names,pcItemsFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_Skip(This,cItemsToSkip) (This)->lpVtbl -> Skip(This,cItemsToSkip)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumDMO_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObjectInPlace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObjectInPlace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObjectInPlace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObjectInPlace_Process(This,ulSize,pData,refTimeStart,dwFlags) (This)->lpVtbl -> Process(This,ulSize,pData,refTimeStart,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObjectInPlace_Clone(This,ppMediaObject) (This)->lpVtbl -> Clone(This,ppMediaObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaObjectInPlace_GetLatency(This,pLatencyTime) (This)->lpVtbl -> GetLatency(This,pLatencyTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOQualityControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOQualityControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOQualityControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOQualityControl_SetNow(This,rtNow) (This)->lpVtbl -> SetNow(This,rtNow)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOQualityControl_SetStatus(This,dwFlags) (This)->lpVtbl -> SetStatus(This,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOQualityControl_GetStatus(This,pdwFlags) (This)->lpVtbl -> GetStatus(This,pdwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_QueryOperationModePreferences(This,ulOutputStreamIndex,pdwRequestedCapabilities) (This)->lpVtbl -> QueryOperationModePreferences(This,ulOutputStreamIndex,pdwRequestedCapabilities)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_SetOperationMode(This,ulOutputStreamIndex,dwEnabledFeatures) (This)->lpVtbl -> SetOperationMode(This,ulOutputStreamIndex,dwEnabledFeatures)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_GetCurrentOperationMode(This,ulOutputStreamIndex,pdwEnabledFeatures) (This)->lpVtbl -> GetCurrentOperationMode(This,ulOutputStreamIndex,pdwEnabledFeatures)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDMOVideoOutputOptimizations_GetCurrentSampleRequirements(This,ulOutputStreamIndex,pdwRequestedFeatures) (This)->lpVtbl -> GetCurrentSampleRequirements(This,ulOutputStreamIndex,pdwRequestedFeatures)


// 57f2db8b-e6bb-4513-9d43-dcd2a6593125
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_AUDIO_DECODER, 0x57f2db8b,0xe6bb,0x4513,0x9d,0x43,0xdc,0xd2,0xa6,0x59,0x31,0x25);
// 33D9A761-90C8-11d0-BD43-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_AUDIO_ENCODER, 0x33D9A761,0x90C8,0x11d0,0xBD,0x43,0x00,0xA0,0xC9,0x11,0xCE,0x86);
// 4a69b442-28be-4991-969c-b500adf5d8a8
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_VIDEO_DECODER, 0x4a69b442,0x28be,0x4991,0x96,0x9c,0xb5,0x00,0xad,0xf5,0xd8,0xa8);
// 33D9A760-90C8-11d0-BD43-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_VIDEO_ENCODER, 0x33D9A760,0x90C8,0x11d0,0xBD,0x43,0x00,0xA0,0xC9,0x11,0xCE,0x86);
// f3602b3f-0592-48df-a4cd-674721e7ebeb
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_AUDIO_EFFECT, 0xf3602b3f,0x0592,0x48df,0xa4,0xcd,0x67,0x47,0x21,0xe7,0xeb,0xeb);
// d990ee14-776c-4723-be46-3da2f56f10b9
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_VIDEO_EFFECT, 0xd990ee14,0x776c,0x4723,0xbe,0x46,0x3d,0xa2,0xf5,0x6f,0x10,0xb9);
// f665aaba-3e09-4920-aa5f-219811148f09
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_AUDIO_CAPTURE_EFFECT, 0xf665aaba,0x3e09,0x4920,0xaa,0x5f,0x21,0x98,0x11,0x14,0x8f,0x09);

// Acoustic Echo Canceller {BF963D80-C559-11D0-8A2B-00A0C9255AC1}
// Matches KSNODETYPE_ACOUSTIC_ECHO_CANCEL in ksmedia.h
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_ACOUSTIC_ECHO_CANCEL, 0xBF963D80, 0xC559, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1);

// Noise Supression {E07F903F-62FD-4e60-8CDD-DEA7236665B5}
// Matches KSNODETYPE_AUDIO_NOISE_SUPPRESS in post Windows ME DDK's ksmedia.h
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_AUDIO_NOISE_SUPPRESS, 0xe07f903f, 0x62fd, 0x4e60, 0x8c, 0xdd, 0xde, 0xa7, 0x23, 0x66, 0x65, 0xb5);

// Automatic Gain Control {E88C9BA0-C557-11D0-8A2B-00A0C9255AC1}
// Matches KSNODETYPE_AGC in ksmedia.h
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DMOCATEGORY_AGC, 0xE88C9BA0, 0xC557, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1);

public class _DMO_PARTIAL_MEDIATYPE
{
   public GUID type = new GUID();
   public GUID subtype = new GUID();
}

public enum DMO_REGISTER_FLAGS
{
   DMO_REGISTERF_IS_KEYED = 0x00000001
}

public enum DMO_ENUM_FLAGS
{
   DMO_ENUMF_INCLUDE_KEYED = 0x00000001
}