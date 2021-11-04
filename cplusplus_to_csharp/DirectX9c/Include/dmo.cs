// ------------------------------------------------------------------------------
// File: DMO.h
// 
// Desc: Headers needed by almost all DMOs.
// 
// Copyright (c) 1999 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------





// When using ATL we get collisions on Lock, so in this case rename
// IMediaObject::Lock to IMediaObject::DMOLock

#if FIX_LOCK_NAME
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define Lock DMOLock
#define Lock
#endif
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
#if FIX_LOCK_NAME
#undef Lock
#endif

