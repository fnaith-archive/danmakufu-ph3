#if ! NO_DEFAULT_BDATUNINGMODEL_NAMESPACE
using BDATuningModel;

// ------------------------------------------------------------------------------
// File: Tune.h
// 
// Desc: Additional infrastructure to extend the tuner.idl.  Works nicely
//       from C++.
// 
// Copyright (c) 1999 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------




#define __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__
#define CDEF_CLASS_DEFAULT
#define CDEF_BYPASS_CLASS_MANAGER
#define CDEF_MERIT_ABOVE_DO_NOT_USE
#define CDEF_DEVMON_CMGR_DEVICE
#define CDEF_DEVMON_DMO
#define CDEF_DEVMON_PNP_DEVICE
#define CDEF_DEVMON_FILTER
#define CDEF_DEVMON_SELECTIVE_MASK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ICreateDevEnum_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ICreateDevEnum_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_Release(This) (This)->lpVtbl -> Release(This)
#define ICreateDevEnum_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_CreateClassEnumerator(This,clsidDeviceClass,ppEnumMoniker,dwFlags) (This)->lpVtbl -> CreateClassEnumerator(This,clsidDeviceClass,ppEnumMoniker,dwFlags)
#define ICreateDevEnum_CreateClassEnumerator
#define CHARS_IN_GUID
#define MAX_PIN_NAME
#define MAX_FILTER_NAME
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IPin_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IPin_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_Release(This) (This)->lpVtbl -> Release(This)
#define IPin_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_Connect(This,pReceivePin,pmt) (This)->lpVtbl -> Connect(This,pReceivePin,pmt)
#define IPin_Connect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_ReceiveConnection(This,pConnector,pmt) (This)->lpVtbl -> ReceiveConnection(This,pConnector,pmt)
#define IPin_ReceiveConnection
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_Disconnect(This) (This)->lpVtbl -> Disconnect(This)
#define IPin_Disconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_ConnectedTo(This,pPin) (This)->lpVtbl -> ConnectedTo(This,pPin)
#define IPin_ConnectedTo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_ConnectionMediaType(This,pmt) (This)->lpVtbl -> ConnectionMediaType(This,pmt)
#define IPin_ConnectionMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryPinInfo(This,pInfo) (This)->lpVtbl -> QueryPinInfo(This,pInfo)
#define IPin_QueryPinInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryDirection(This,pPinDir) (This)->lpVtbl -> QueryDirection(This,pPinDir)
#define IPin_QueryDirection
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryId(This,Id) (This)->lpVtbl -> QueryId(This,Id)
#define IPin_QueryId
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryAccept(This,pmt) (This)->lpVtbl -> QueryAccept(This,pmt)
#define IPin_QueryAccept
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_EnumMediaTypes(This,ppEnum) (This)->lpVtbl -> EnumMediaTypes(This,ppEnum)
#define IPin_EnumMediaTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryInternalConnections(This,apPin,nPin) (This)->lpVtbl -> QueryInternalConnections(This,apPin,nPin)
#define IPin_QueryInternalConnections
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_EndOfStream(This) (This)->lpVtbl -> EndOfStream(This)
#define IPin_EndOfStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_BeginFlush(This) (This)->lpVtbl -> BeginFlush(This)
#define IPin_BeginFlush
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_EndFlush(This) (This)->lpVtbl -> EndFlush(This)
#define IPin_EndFlush
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_NewSegment(This,tStart,tStop,dRate) (This)->lpVtbl -> NewSegment(This,tStart,tStop,dRate)
#define IPin_NewSegment
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumPins_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumPins_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumPins_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Next(This,cPins,ppPins,pcFetched) (This)->lpVtbl -> Next(This,cPins,ppPins,pcFetched)
#define IEnumPins_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Skip(This,cPins) (This)->lpVtbl -> Skip(This,cPins)
#define IEnumPins_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumPins_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumPins_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumMediaTypes_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumMediaTypes_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumMediaTypes_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Next(This,cMediaTypes,ppMediaTypes,pcFetched) (This)->lpVtbl -> Next(This,cMediaTypes,ppMediaTypes,pcFetched)
#define IEnumMediaTypes_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Skip(This,cMediaTypes) (This)->lpVtbl -> Skip(This,cMediaTypes)
#define IEnumMediaTypes_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumMediaTypes_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumMediaTypes_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFilterGraph_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFilterGraph_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_Release(This) (This)->lpVtbl -> Release(This)
#define IFilterGraph_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_AddFilter(This,pFilter,pName) (This)->lpVtbl -> AddFilter(This,pFilter,pName)
#define IFilterGraph_AddFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_RemoveFilter(This,pFilter) (This)->lpVtbl -> RemoveFilter(This,pFilter)
#define IFilterGraph_RemoveFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_EnumFilters(This,ppEnum) (This)->lpVtbl -> EnumFilters(This,ppEnum)
#define IFilterGraph_EnumFilters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_FindFilterByName(This,pName,ppFilter) (This)->lpVtbl -> FindFilterByName(This,pName,ppFilter)
#define IFilterGraph_FindFilterByName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_ConnectDirect(This,ppinOut,ppinIn,pmt) (This)->lpVtbl -> ConnectDirect(This,ppinOut,ppinIn,pmt)
#define IFilterGraph_ConnectDirect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_Reconnect(This,ppin) (This)->lpVtbl -> Reconnect(This,ppin)
#define IFilterGraph_Reconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_Disconnect(This,ppin) (This)->lpVtbl -> Disconnect(This,ppin)
#define IFilterGraph_Disconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_SetDefaultSyncSource(This) (This)->lpVtbl -> SetDefaultSyncSource(This)
#define IFilterGraph_SetDefaultSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumFilters_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumFilters_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumFilters_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Next(This,cFilters,ppFilter,pcFetched) (This)->lpVtbl -> Next(This,cFilters,ppFilter,pcFetched)
#define IEnumFilters_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Skip(This,cFilters) (This)->lpVtbl -> Skip(This,cFilters)
#define IEnumFilters_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumFilters_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumFilters_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMediaFilter_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMediaFilter_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Release(This) (This)->lpVtbl -> Release(This)
#define IMediaFilter_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_GetClassID(This,pClassID) (This)->lpVtbl -> GetClassID(This,pClassID)
#define IMediaFilter_GetClassID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Stop(This) (This)->lpVtbl -> Stop(This)
#define IMediaFilter_Stop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Pause(This) (This)->lpVtbl -> Pause(This)
#define IMediaFilter_Pause
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Run(This,tStart) (This)->lpVtbl -> Run(This,tStart)
#define IMediaFilter_Run
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_GetState(This,dwMilliSecsTimeout,State) (This)->lpVtbl -> GetState(This,dwMilliSecsTimeout,State)
#define IMediaFilter_GetState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_SetSyncSource(This,pClock) (This)->lpVtbl -> SetSyncSource(This,pClock)
#define IMediaFilter_SetSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_GetSyncSource(This,pClock) (This)->lpVtbl -> GetSyncSource(This,pClock)
#define IMediaFilter_GetSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IBaseFilter_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IBaseFilter_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Release(This) (This)->lpVtbl -> Release(This)
#define IBaseFilter_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_GetClassID(This,pClassID) (This)->lpVtbl -> GetClassID(This,pClassID)
#define IBaseFilter_GetClassID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Stop(This) (This)->lpVtbl -> Stop(This)
#define IBaseFilter_Stop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Pause(This) (This)->lpVtbl -> Pause(This)
#define IBaseFilter_Pause
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Run(This,tStart) (This)->lpVtbl -> Run(This,tStart)
#define IBaseFilter_Run
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_GetState(This,dwMilliSecsTimeout,State) (This)->lpVtbl -> GetState(This,dwMilliSecsTimeout,State)
#define IBaseFilter_GetState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_SetSyncSource(This,pClock) (This)->lpVtbl -> SetSyncSource(This,pClock)
#define IBaseFilter_SetSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_GetSyncSource(This,pClock) (This)->lpVtbl -> GetSyncSource(This,pClock)
#define IBaseFilter_GetSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_EnumPins(This,ppEnum) (This)->lpVtbl -> EnumPins(This,ppEnum)
#define IBaseFilter_EnumPins
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_FindPin(This,Id,ppPin) (This)->lpVtbl -> FindPin(This,Id,ppPin)
#define IBaseFilter_FindPin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_QueryFilterInfo(This,pInfo) (This)->lpVtbl -> QueryFilterInfo(This,pInfo)
#define IBaseFilter_QueryFilterInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_JoinFilterGraph(This,pGraph,pName) (This)->lpVtbl -> JoinFilterGraph(This,pGraph,pName)
#define IBaseFilter_JoinFilterGraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_QueryVendorInfo(This,pVendorInfo) (This)->lpVtbl -> QueryVendorInfo(This,pVendorInfo)
#define IBaseFilter_QueryVendorInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IReferenceClock_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IReferenceClock_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_Release(This) (This)->lpVtbl -> Release(This)
#define IReferenceClock_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_GetTime(This,pTime) (This)->lpVtbl -> GetTime(This,pTime)
#define IReferenceClock_GetTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie) (This)->lpVtbl -> AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie)
#define IReferenceClock_AdviseTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie) (This)->lpVtbl -> AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie)
#define IReferenceClock_AdvisePeriodic
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_Unadvise(This,dwAdviseCookie) (This)->lpVtbl -> Unadvise(This,dwAdviseCookie)
#define IReferenceClock_Unadvise
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IReferenceClock2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IReferenceClock2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_Release(This) (This)->lpVtbl -> Release(This)
#define IReferenceClock2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_GetTime(This,pTime) (This)->lpVtbl -> GetTime(This,pTime)
#define IReferenceClock2_GetTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie) (This)->lpVtbl -> AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie)
#define IReferenceClock2_AdviseTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie) (This)->lpVtbl -> AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie)
#define IReferenceClock2_AdvisePeriodic
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_Unadvise(This,dwAdviseCookie) (This)->lpVtbl -> Unadvise(This,dwAdviseCookie)
#define IReferenceClock2_Unadvise
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMediaSample_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMediaSample_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_Release(This) (This)->lpVtbl -> Release(This)
#define IMediaSample_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetPointer(This,ppBuffer) (This)->lpVtbl -> GetPointer(This,ppBuffer)
#define IMediaSample_GetPointer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetSize(This) (This)->lpVtbl -> GetSize(This)
#define IMediaSample_GetSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetTime(This,pTimeStart,pTimeEnd)
#define IMediaSample_GetTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetTime(This,pTimeStart,pTimeEnd)
#define IMediaSample_SetTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_IsSyncPoint(This) (This)->lpVtbl -> IsSyncPoint(This)
#define IMediaSample_IsSyncPoint
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetSyncPoint(This,bIsSyncPoint) (This)->lpVtbl -> SetSyncPoint(This,bIsSyncPoint)
#define IMediaSample_SetSyncPoint
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_IsPreroll(This) (This)->lpVtbl -> IsPreroll(This)
#define IMediaSample_IsPreroll
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetPreroll(This,bIsPreroll) (This)->lpVtbl -> SetPreroll(This,bIsPreroll)
#define IMediaSample_SetPreroll
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetActualDataLength(This) (This)->lpVtbl -> GetActualDataLength(This)
#define IMediaSample_GetActualDataLength
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetActualDataLength(This,__MIDL_0010) (This)->lpVtbl -> SetActualDataLength(This,__MIDL_0010)
#define IMediaSample_SetActualDataLength
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetMediaType(This,ppMediaType) (This)->lpVtbl -> GetMediaType(This,ppMediaType)
#define IMediaSample_GetMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetMediaType(This,pMediaType) (This)->lpVtbl -> SetMediaType(This,pMediaType)
#define IMediaSample_SetMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_IsDiscontinuity(This) (This)->lpVtbl -> IsDiscontinuity(This)
#define IMediaSample_IsDiscontinuity
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetDiscontinuity(This,bDiscontinuity) (This)->lpVtbl -> SetDiscontinuity(This,bDiscontinuity)
#define IMediaSample_SetDiscontinuity
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetMediaTime(This,pTimeStart,pTimeEnd)
#define IMediaSample_GetMediaTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetMediaTime(This,pTimeStart,pTimeEnd)
#define IMediaSample_SetMediaTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMediaSample2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMediaSample2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_Release(This) (This)->lpVtbl -> Release(This)
#define IMediaSample2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetPointer(This,ppBuffer) (This)->lpVtbl -> GetPointer(This,ppBuffer)
#define IMediaSample2_GetPointer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetSize(This) (This)->lpVtbl -> GetSize(This)
#define IMediaSample2_GetSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetTime(This,pTimeStart,pTimeEnd)
#define IMediaSample2_GetTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetTime(This,pTimeStart,pTimeEnd)
#define IMediaSample2_SetTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_IsSyncPoint(This) (This)->lpVtbl -> IsSyncPoint(This)
#define IMediaSample2_IsSyncPoint
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetSyncPoint(This,bIsSyncPoint) (This)->lpVtbl -> SetSyncPoint(This,bIsSyncPoint)
#define IMediaSample2_SetSyncPoint
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_IsPreroll(This) (This)->lpVtbl -> IsPreroll(This)
#define IMediaSample2_IsPreroll
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetPreroll(This,bIsPreroll) (This)->lpVtbl -> SetPreroll(This,bIsPreroll)
#define IMediaSample2_SetPreroll
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetActualDataLength(This) (This)->lpVtbl -> GetActualDataLength(This)
#define IMediaSample2_GetActualDataLength
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetActualDataLength(This,__MIDL_0010) (This)->lpVtbl -> SetActualDataLength(This,__MIDL_0010)
#define IMediaSample2_SetActualDataLength
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetMediaType(This,ppMediaType) (This)->lpVtbl -> GetMediaType(This,ppMediaType)
#define IMediaSample2_GetMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetMediaType(This,pMediaType) (This)->lpVtbl -> SetMediaType(This,pMediaType)
#define IMediaSample2_SetMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_IsDiscontinuity(This) (This)->lpVtbl -> IsDiscontinuity(This)
#define IMediaSample2_IsDiscontinuity
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetDiscontinuity(This,bDiscontinuity) (This)->lpVtbl -> SetDiscontinuity(This,bDiscontinuity)
#define IMediaSample2_SetDiscontinuity
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetMediaTime(This,pTimeStart,pTimeEnd)
#define IMediaSample2_GetMediaTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetMediaTime(This,pTimeStart,pTimeEnd)
#define IMediaSample2_SetMediaTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetProperties(This,cbProperties,pbProperties) (This)->lpVtbl -> GetProperties(This,cbProperties,pbProperties)
#define IMediaSample2_GetProperties
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetProperties(This,cbProperties,pbProperties) (This)->lpVtbl -> SetProperties(This,cbProperties,pbProperties)
#define IMediaSample2_SetProperties
#define AM_GBF_PREVFRAMESKIPPED
#define AM_GBF_NOTASYNCPOINT
#define AM_GBF_NOWAIT
#define AM_GBF_NODDSURFACELOCK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMemAllocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMemAllocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_Release(This) (This)->lpVtbl -> Release(This)
#define IMemAllocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_SetProperties(This,pRequest,pActual) (This)->lpVtbl -> SetProperties(This,pRequest,pActual)
#define IMemAllocator_SetProperties
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_GetProperties(This,pProps) (This)->lpVtbl -> GetProperties(This,pProps)
#define IMemAllocator_GetProperties
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_Commit(This) (This)->lpVtbl -> Commit(This)
#define IMemAllocator_Commit
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_Decommit(This) (This)->lpVtbl -> Decommit(This)
#define IMemAllocator_Decommit
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags) (This)->lpVtbl -> GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags)
#define IMemAllocator_GetBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_ReleaseBuffer(This,pBuffer) (This)->lpVtbl -> ReleaseBuffer(This,pBuffer)
#define IMemAllocator_ReleaseBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMemAllocatorCallbackTemp_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMemAllocatorCallbackTemp_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_Release(This) (This)->lpVtbl -> Release(This)
#define IMemAllocatorCallbackTemp_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_SetProperties(This,pRequest,pActual) (This)->lpVtbl -> SetProperties(This,pRequest,pActual)
#define IMemAllocatorCallbackTemp_SetProperties
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_GetProperties(This,pProps) (This)->lpVtbl -> GetProperties(This,pProps)
#define IMemAllocatorCallbackTemp_GetProperties
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_Commit(This) (This)->lpVtbl -> Commit(This)
#define IMemAllocatorCallbackTemp_Commit
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_Decommit(This) (This)->lpVtbl -> Decommit(This)
#define IMemAllocatorCallbackTemp_Decommit
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags) (This)->lpVtbl -> GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags)
#define IMemAllocatorCallbackTemp_GetBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_ReleaseBuffer(This,pBuffer) (This)->lpVtbl -> ReleaseBuffer(This,pBuffer)
#define IMemAllocatorCallbackTemp_ReleaseBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_SetNotify(This,pNotify) (This)->lpVtbl -> SetNotify(This,pNotify)
#define IMemAllocatorCallbackTemp_SetNotify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_GetFreeCount(This,plBuffersFree) (This)->lpVtbl -> GetFreeCount(This,plBuffersFree)
#define IMemAllocatorCallbackTemp_GetFreeCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMemAllocatorNotifyCallbackTemp_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMemAllocatorNotifyCallbackTemp_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_Release(This) (This)->lpVtbl -> Release(This)
#define IMemAllocatorNotifyCallbackTemp_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_NotifyRelease(This) (This)->lpVtbl -> NotifyRelease(This)
#define IMemAllocatorNotifyCallbackTemp_NotifyRelease
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMemInputPin_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMemInputPin_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_Release(This) (This)->lpVtbl -> Release(This)
#define IMemInputPin_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_GetAllocator(This,ppAllocator) (This)->lpVtbl -> GetAllocator(This,ppAllocator)
#define IMemInputPin_GetAllocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_NotifyAllocator(This,pAllocator,bReadOnly) (This)->lpVtbl -> NotifyAllocator(This,pAllocator,bReadOnly)
#define IMemInputPin_NotifyAllocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_GetAllocatorRequirements(This,pProps) (This)->lpVtbl -> GetAllocatorRequirements(This,pProps)
#define IMemInputPin_GetAllocatorRequirements
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_Receive(This,pSample) (This)->lpVtbl -> Receive(This,pSample)
#define IMemInputPin_Receive
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_ReceiveMultiple(This,pSamples,nSamples,nSamplesProcessed) (This)->lpVtbl -> ReceiveMultiple(This,pSamples,nSamples,nSamplesProcessed)
#define IMemInputPin_ReceiveMultiple
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_ReceiveCanBlock(This) (This)->lpVtbl -> ReceiveCanBlock(This)
#define IMemInputPin_ReceiveCanBlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMovieSetup_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMovieSetup_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_Release(This) (This)->lpVtbl -> Release(This)
#define IAMovieSetup_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_Register(This) (This)->lpVtbl -> Register(This)
#define IAMovieSetup_Register
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_Unregister(This) (This)->lpVtbl -> Unregister(This)
#define IAMovieSetup_Unregister
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMediaSeeking_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMediaSeeking_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_Release(This) (This)->lpVtbl -> Release(This)
#define IMediaSeeking_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetCapabilities(This,pCapabilities) (This)->lpVtbl -> GetCapabilities(This,pCapabilities)
#define IMediaSeeking_GetCapabilities
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_CheckCapabilities(This,pCapabilities) (This)->lpVtbl -> CheckCapabilities(This,pCapabilities)
#define IMediaSeeking_CheckCapabilities
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_IsFormatSupported(This,pFormat) (This)->lpVtbl -> IsFormatSupported(This,pFormat)
#define IMediaSeeking_IsFormatSupported
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_QueryPreferredFormat(This,pFormat) (This)->lpVtbl -> QueryPreferredFormat(This,pFormat)
#define IMediaSeeking_QueryPreferredFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetTimeFormat(This,pFormat) (This)->lpVtbl -> GetTimeFormat(This,pFormat)
#define IMediaSeeking_GetTimeFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_IsUsingTimeFormat(This,pFormat) (This)->lpVtbl -> IsUsingTimeFormat(This,pFormat)
#define IMediaSeeking_IsUsingTimeFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_SetTimeFormat(This,pFormat) (This)->lpVtbl -> SetTimeFormat(This,pFormat)
#define IMediaSeeking_SetTimeFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetDuration(This,pDuration) (This)->lpVtbl -> GetDuration(This,pDuration)
#define IMediaSeeking_GetDuration
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetStopPosition(This,pStop) (This)->lpVtbl -> GetStopPosition(This,pStop)
#define IMediaSeeking_GetStopPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetCurrentPosition(This,pCurrent) (This)->lpVtbl -> GetCurrentPosition(This,pCurrent)
#define IMediaSeeking_GetCurrentPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_ConvertTimeFormat(This,pTarget,pTargetFormat,Source,pSourceFormat) (This)->lpVtbl -> ConvertTimeFormat(This,pTarget,pTargetFormat,Source,pSourceFormat)
#define IMediaSeeking_ConvertTimeFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_SetPositions(This,pCurrent,dwCurrentFlags,pStop,dwStopFlags) (This)->lpVtbl -> SetPositions(This,pCurrent,dwCurrentFlags,pStop,dwStopFlags)
#define IMediaSeeking_SetPositions
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetPositions(This,pCurrent,pStop) (This)->lpVtbl -> GetPositions(This,pCurrent,pStop)
#define IMediaSeeking_GetPositions
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetAvailable(This,pEarliest,pLatest) (This)->lpVtbl -> GetAvailable(This,pEarliest,pLatest)
#define IMediaSeeking_GetAvailable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_SetRate(This,dRate) (This)->lpVtbl -> SetRate(This,dRate)
#define IMediaSeeking_SetRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetRate(This,pdRate) (This)->lpVtbl -> GetRate(This,pdRate)
#define IMediaSeeking_GetRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetPreroll(This,pllPreroll) (This)->lpVtbl -> GetPreroll(This,pllPreroll)
#define IMediaSeeking_GetPreroll
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumRegFilters_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumRegFilters_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumRegFilters_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Next(This,cFilters,apRegFilter,pcFetched) (This)->lpVtbl -> Next(This,cFilters,apRegFilter,pcFetched)
#define IEnumRegFilters_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Skip(This,cFilters) (This)->lpVtbl -> Skip(This,cFilters)
#define IEnumRegFilters_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumRegFilters_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumRegFilters_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFilterMapper_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFilterMapper_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_Release(This) (This)->lpVtbl -> Release(This)
#define IFilterMapper_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterFilter(This,clsid,Name,dwMerit) (This)->lpVtbl -> RegisterFilter(This,clsid,Name,dwMerit)
#define IFilterMapper_RegisterFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterFilterInstance(This,clsid,Name,MRId) (This)->lpVtbl -> RegisterFilterInstance(This,clsid,Name,MRId)
#define IFilterMapper_RegisterFilterInstance
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterPin(This,Filter,Name,bRendered,bOutput,bZero,bMany,ConnectsToFilter,ConnectsToPin) (This)->lpVtbl -> RegisterPin(This,Filter,Name,bRendered,bOutput,bZero,bMany,ConnectsToFilter,ConnectsToPin)
#define IFilterMapper_RegisterPin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterPinType(This,clsFilter,strName,clsMajorType,clsSubType) (This)->lpVtbl -> RegisterPinType(This,clsFilter,strName,clsMajorType,clsSubType)
#define IFilterMapper_RegisterPinType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_UnregisterFilter(This,Filter) (This)->lpVtbl -> UnregisterFilter(This,Filter)
#define IFilterMapper_UnregisterFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_UnregisterFilterInstance(This,MRId) (This)->lpVtbl -> UnregisterFilterInstance(This,MRId)
#define IFilterMapper_UnregisterFilterInstance
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_UnregisterPin(This,Filter,Name) (This)->lpVtbl -> UnregisterPin(This,Filter,Name)
#define IFilterMapper_UnregisterPin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_EnumMatchingFilters(This,ppEnum,dwMerit,bInputNeeded,clsInMaj,clsInSub,bRender,bOututNeeded,clsOutMaj,clsOutSub) (This)->lpVtbl -> EnumMatchingFilters(This,ppEnum,dwMerit,bInputNeeded,clsInMaj,clsInSub,bRender,bOututNeeded,clsOutMaj,clsOutSub)
#define IFilterMapper_EnumMatchingFilters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFilterMapper2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFilterMapper2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_Release(This) (This)->lpVtbl -> Release(This)
#define IFilterMapper2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_CreateCategory(This,clsidCategory,dwCategoryMerit,Description) (This)->lpVtbl -> CreateCategory(This,clsidCategory,dwCategoryMerit,Description)
#define IFilterMapper2_CreateCategory
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_UnregisterFilter(This,pclsidCategory,szInstance,Filter) (This)->lpVtbl -> UnregisterFilter(This,pclsidCategory,szInstance,Filter)
#define IFilterMapper2_UnregisterFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2) (This)->lpVtbl -> RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2)
#define IFilterMapper2_RegisterFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut) (This)->lpVtbl -> EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut)
#define IFilterMapper2_EnumMatchingFilters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFilterMapper3_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFilterMapper3_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_Release(This) (This)->lpVtbl -> Release(This)
#define IFilterMapper3_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_CreateCategory(This,clsidCategory,dwCategoryMerit,Description) (This)->lpVtbl -> CreateCategory(This,clsidCategory,dwCategoryMerit,Description)
#define IFilterMapper3_CreateCategory
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_UnregisterFilter(This,pclsidCategory,szInstance,Filter) (This)->lpVtbl -> UnregisterFilter(This,pclsidCategory,szInstance,Filter)
#define IFilterMapper3_UnregisterFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2) (This)->lpVtbl -> RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2)
#define IFilterMapper3_RegisterFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut) (This)->lpVtbl -> EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut)
#define IFilterMapper3_EnumMatchingFilters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_GetICreateDevEnum(This,ppEnum) (This)->lpVtbl -> GetICreateDevEnum(This,ppEnum)
#define IFilterMapper3_GetICreateDevEnum
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IQualityControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IQualityControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_Release(This) (This)->lpVtbl -> Release(This)
#define IQualityControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_Notify(This,pSelf,q) (This)->lpVtbl -> Notify(This,pSelf,q)
#define IQualityControl_Notify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_SetSink(This,piqc) (This)->lpVtbl -> SetSink(This,piqc)
#define IQualityControl_SetSink
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ADVISE_ALL ( ADVISE_CLIPPING | ADVISE_PALETTE | ADVISE_COLORKEY | ADVISE_POSITION )
#define ADVISE_ALL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ADVISE_ALL2 ( ADVISE_ALL | ADVISE_DISPLAY_CHANGE )
#define ADVISE_ALL2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IOverlayNotify_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IOverlayNotify_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_Release(This) (This)->lpVtbl -> Release(This)
#define IOverlayNotify_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnPaletteChange(This,dwColors,pPalette) (This)->lpVtbl -> OnPaletteChange(This,dwColors,pPalette)
#define IOverlayNotify_OnPaletteChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnClipChange(This,pSourceRect,pDestinationRect,pRgnData) (This)->lpVtbl -> OnClipChange(This,pSourceRect,pDestinationRect,pRgnData)
#define IOverlayNotify_OnClipChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnColorKeyChange(This,pColorKey) (This)->lpVtbl -> OnColorKeyChange(This,pColorKey)
#define IOverlayNotify_OnColorKeyChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnPositionChange(This,pSourceRect,pDestinationRect) (This)->lpVtbl -> OnPositionChange(This,pSourceRect,pDestinationRect)
#define IOverlayNotify_OnPositionChange
#define HMONITOR_DECLARED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IOverlayNotify2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IOverlayNotify2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_Release(This) (This)->lpVtbl -> Release(This)
#define IOverlayNotify2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnPaletteChange(This,dwColors,pPalette) (This)->lpVtbl -> OnPaletteChange(This,dwColors,pPalette)
#define IOverlayNotify2_OnPaletteChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnClipChange(This,pSourceRect,pDestinationRect,pRgnData) (This)->lpVtbl -> OnClipChange(This,pSourceRect,pDestinationRect,pRgnData)
#define IOverlayNotify2_OnClipChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnColorKeyChange(This,pColorKey) (This)->lpVtbl -> OnColorKeyChange(This,pColorKey)
#define IOverlayNotify2_OnColorKeyChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnPositionChange(This,pSourceRect,pDestinationRect) (This)->lpVtbl -> OnPositionChange(This,pSourceRect,pDestinationRect)
#define IOverlayNotify2_OnPositionChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnDisplayChange(This,hMonitor) (This)->lpVtbl -> OnDisplayChange(This,hMonitor)
#define IOverlayNotify2_OnDisplayChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IOverlay_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IOverlay_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_Release(This) (This)->lpVtbl -> Release(This)
#define IOverlay_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetPalette(This,pdwColors,ppPalette) (This)->lpVtbl -> GetPalette(This,pdwColors,ppPalette)
#define IOverlay_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_SetPalette(This,dwColors,pPalette) (This)->lpVtbl -> SetPalette(This,dwColors,pPalette)
#define IOverlay_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetDefaultColorKey(This,pColorKey) (This)->lpVtbl -> GetDefaultColorKey(This,pColorKey)
#define IOverlay_GetDefaultColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetColorKey(This,pColorKey) (This)->lpVtbl -> GetColorKey(This,pColorKey)
#define IOverlay_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_SetColorKey(This,pColorKey) (This)->lpVtbl -> SetColorKey(This,pColorKey)
#define IOverlay_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetWindowHandle(This,pHwnd) (This)->lpVtbl -> GetWindowHandle(This,pHwnd)
#define IOverlay_GetWindowHandle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetClipList(This,pSourceRect,pDestinationRect,ppRgnData) (This)->lpVtbl -> GetClipList(This,pSourceRect,pDestinationRect,ppRgnData)
#define IOverlay_GetClipList
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetVideoPosition(This,pSourceRect,pDestinationRect) (This)->lpVtbl -> GetVideoPosition(This,pSourceRect,pDestinationRect)
#define IOverlay_GetVideoPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_Advise(This,pOverlayNotify,dwInterests) (This)->lpVtbl -> Advise(This,pOverlayNotify,dwInterests)
#define IOverlay_Advise
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_Unadvise(This) (This)->lpVtbl -> Unadvise(This)
#define IOverlay_Unadvise
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMediaEventSink_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMediaEventSink_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_Release(This) (This)->lpVtbl -> Release(This)
#define IMediaEventSink_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_Notify(This,EventCode,EventParam1,EventParam2) (This)->lpVtbl -> Notify(This,EventCode,EventParam1,EventParam2)
#define IMediaEventSink_Notify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFileSourceFilter_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFileSourceFilter_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_Release(This) (This)->lpVtbl -> Release(This)
#define IFileSourceFilter_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_Load(This,pszFileName,pmt) (This)->lpVtbl -> Load(This,pszFileName,pmt)
#define IFileSourceFilter_Load
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_GetCurFile(This,ppszFileName,pmt) (This)->lpVtbl -> GetCurFile(This,ppszFileName,pmt)
#define IFileSourceFilter_GetCurFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFileSinkFilter_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFileSinkFilter_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_Release(This) (This)->lpVtbl -> Release(This)
#define IFileSinkFilter_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_SetFileName(This,pszFileName,pmt) (This)->lpVtbl -> SetFileName(This,pszFileName,pmt)
#define IFileSinkFilter_SetFileName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_GetCurFile(This,ppszFileName,pmt) (This)->lpVtbl -> GetCurFile(This,ppszFileName,pmt)
#define IFileSinkFilter_GetCurFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFileSinkFilter2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFileSinkFilter2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_Release(This) (This)->lpVtbl -> Release(This)
#define IFileSinkFilter2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_SetFileName(This,pszFileName,pmt) (This)->lpVtbl -> SetFileName(This,pszFileName,pmt)
#define IFileSinkFilter2_SetFileName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_GetCurFile(This,ppszFileName,pmt) (This)->lpVtbl -> GetCurFile(This,ppszFileName,pmt)
#define IFileSinkFilter2_GetCurFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_SetMode(This,dwFlags) (This)->lpVtbl -> SetMode(This,dwFlags)
#define IFileSinkFilter2_SetMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_GetMode(This,pdwFlags) (This)->lpVtbl -> GetMode(This,pdwFlags)
#define IFileSinkFilter2_GetMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IGraphBuilder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IGraphBuilder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Release(This) (This)->lpVtbl -> Release(This)
#define IGraphBuilder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_AddFilter(This,pFilter,pName) (This)->lpVtbl -> AddFilter(This,pFilter,pName)
#define IGraphBuilder_AddFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_RemoveFilter(This,pFilter) (This)->lpVtbl -> RemoveFilter(This,pFilter)
#define IGraphBuilder_RemoveFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_EnumFilters(This,ppEnum) (This)->lpVtbl -> EnumFilters(This,ppEnum)
#define IGraphBuilder_EnumFilters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_FindFilterByName(This,pName,ppFilter) (This)->lpVtbl -> FindFilterByName(This,pName,ppFilter)
#define IGraphBuilder_FindFilterByName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_ConnectDirect(This,ppinOut,ppinIn,pmt) (This)->lpVtbl -> ConnectDirect(This,ppinOut,ppinIn,pmt)
#define IGraphBuilder_ConnectDirect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Reconnect(This,ppin) (This)->lpVtbl -> Reconnect(This,ppin)
#define IGraphBuilder_Reconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Disconnect(This,ppin) (This)->lpVtbl -> Disconnect(This,ppin)
#define IGraphBuilder_Disconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_SetDefaultSyncSource(This) (This)->lpVtbl -> SetDefaultSyncSource(This)
#define IGraphBuilder_SetDefaultSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Connect(This,ppinOut,ppinIn) (This)->lpVtbl -> Connect(This,ppinOut,ppinIn)
#define IGraphBuilder_Connect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Render(This,ppinOut) (This)->lpVtbl -> Render(This,ppinOut)
#define IGraphBuilder_Render
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_RenderFile(This,lpcwstrFile,lpcwstrPlayList) (This)->lpVtbl -> RenderFile(This,lpcwstrFile,lpcwstrPlayList)
#define IGraphBuilder_RenderFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter) (This)->lpVtbl -> AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter)
#define IGraphBuilder_AddSourceFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_SetLogFile(This,hFile) (This)->lpVtbl -> SetLogFile(This,hFile)
#define IGraphBuilder_SetLogFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Abort(This) (This)->lpVtbl -> Abort(This)
#define IGraphBuilder_Abort
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_ShouldOperationContinue(This) (This)->lpVtbl -> ShouldOperationContinue(This)
#define IGraphBuilder_ShouldOperationContinue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ICaptureGraphBuilder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ICaptureGraphBuilder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_Release(This) (This)->lpVtbl -> Release(This)
#define ICaptureGraphBuilder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_SetFiltergraph(This,pfg) (This)->lpVtbl -> SetFiltergraph(This,pfg)
#define ICaptureGraphBuilder_SetFiltergraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_GetFiltergraph(This,ppfg) (This)->lpVtbl -> GetFiltergraph(This,ppfg)
#define ICaptureGraphBuilder_GetFiltergraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_SetOutputFileName(This,pType,lpstrFile,ppf,ppSink) (This)->lpVtbl -> SetOutputFileName(This,pType,lpstrFile,ppf,ppSink)
#define ICaptureGraphBuilder_SetOutputFileName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_FindInterface(This,pCategory,pf,riid,ppint) (This)->lpVtbl -> FindInterface(This,pCategory,pf,riid,ppint)
#define ICaptureGraphBuilder_FindInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_RenderStream(This,pCategory,pSource,pfCompressor,pfRenderer) (This)->lpVtbl -> RenderStream(This,pCategory,pSource,pfCompressor,pfRenderer)
#define ICaptureGraphBuilder_RenderStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_ControlStream(This,pCategory,pFilter,pstart,pstop,wStartCookie,wStopCookie) (This)->lpVtbl -> ControlStream(This,pCategory,pFilter,pstart,pstop,wStartCookie,wStopCookie)
#define ICaptureGraphBuilder_ControlStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_AllocCapFile(This,lpstr,dwlSize) (This)->lpVtbl -> AllocCapFile(This,lpstr,dwlSize)
#define ICaptureGraphBuilder_AllocCapFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback) (This)->lpVtbl -> CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback)
#define ICaptureGraphBuilder_CopyCaptureFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMCopyCaptureFileProgress_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMCopyCaptureFileProgress_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_Release(This) (This)->lpVtbl -> Release(This)
#define IAMCopyCaptureFileProgress_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_Progress(This,iProgress) (This)->lpVtbl -> Progress(This,iProgress)
#define IAMCopyCaptureFileProgress_Progress
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ICaptureGraphBuilder2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ICaptureGraphBuilder2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_Release(This) (This)->lpVtbl -> Release(This)
#define ICaptureGraphBuilder2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_SetFiltergraph(This,pfg) (This)->lpVtbl -> SetFiltergraph(This,pfg)
#define ICaptureGraphBuilder2_SetFiltergraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_GetFiltergraph(This,ppfg) (This)->lpVtbl -> GetFiltergraph(This,ppfg)
#define ICaptureGraphBuilder2_GetFiltergraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_SetOutputFileName(This,pType,lpstrFile,ppf,ppSink) (This)->lpVtbl -> SetOutputFileName(This,pType,lpstrFile,ppf,ppSink)
#define ICaptureGraphBuilder2_SetOutputFileName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_FindInterface(This,pCategory,pType,pf,riid,ppint) (This)->lpVtbl -> FindInterface(This,pCategory,pType,pf,riid,ppint)
#define ICaptureGraphBuilder2_FindInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_RenderStream(This,pCategory,pType,pSource,pfCompressor,pfRenderer) (This)->lpVtbl -> RenderStream(This,pCategory,pType,pSource,pfCompressor,pfRenderer)
#define ICaptureGraphBuilder2_RenderStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_ControlStream(This,pCategory,pType,pFilter,pstart,pstop,wStartCookie,wStopCookie) (This)->lpVtbl -> ControlStream(This,pCategory,pType,pFilter,pstart,pstop,wStartCookie,wStopCookie)
#define ICaptureGraphBuilder2_ControlStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_AllocCapFile(This,lpstr,dwlSize) (This)->lpVtbl -> AllocCapFile(This,lpstr,dwlSize)
#define ICaptureGraphBuilder2_AllocCapFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback) (This)->lpVtbl -> CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback)
#define ICaptureGraphBuilder2_CopyCaptureFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_FindPin(This,pSource,pindir,pCategory,pType,fUnconnected,num,ppPin) (This)->lpVtbl -> FindPin(This,pSource,pindir,pCategory,pType,fUnconnected,num,ppPin)
#define ICaptureGraphBuilder2_FindPin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFilterGraph2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFilterGraph2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Release(This) (This)->lpVtbl -> Release(This)
#define IFilterGraph2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddFilter(This,pFilter,pName) (This)->lpVtbl -> AddFilter(This,pFilter,pName)
#define IFilterGraph2_AddFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_RemoveFilter(This,pFilter) (This)->lpVtbl -> RemoveFilter(This,pFilter)
#define IFilterGraph2_RemoveFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_EnumFilters(This,ppEnum) (This)->lpVtbl -> EnumFilters(This,ppEnum)
#define IFilterGraph2_EnumFilters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_FindFilterByName(This,pName,ppFilter) (This)->lpVtbl -> FindFilterByName(This,pName,ppFilter)
#define IFilterGraph2_FindFilterByName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_ConnectDirect(This,ppinOut,ppinIn,pmt) (This)->lpVtbl -> ConnectDirect(This,ppinOut,ppinIn,pmt)
#define IFilterGraph2_ConnectDirect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Reconnect(This,ppin) (This)->lpVtbl -> Reconnect(This,ppin)
#define IFilterGraph2_Reconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Disconnect(This,ppin) (This)->lpVtbl -> Disconnect(This,ppin)
#define IFilterGraph2_Disconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_SetDefaultSyncSource(This) (This)->lpVtbl -> SetDefaultSyncSource(This)
#define IFilterGraph2_SetDefaultSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Connect(This,ppinOut,ppinIn) (This)->lpVtbl -> Connect(This,ppinOut,ppinIn)
#define IFilterGraph2_Connect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Render(This,ppinOut) (This)->lpVtbl -> Render(This,ppinOut)
#define IFilterGraph2_Render
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_RenderFile(This,lpcwstrFile,lpcwstrPlayList) (This)->lpVtbl -> RenderFile(This,lpcwstrFile,lpcwstrPlayList)
#define IFilterGraph2_RenderFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter) (This)->lpVtbl -> AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter)
#define IFilterGraph2_AddSourceFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_SetLogFile(This,hFile) (This)->lpVtbl -> SetLogFile(This,hFile)
#define IFilterGraph2_SetLogFile
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Abort(This) (This)->lpVtbl -> Abort(This)
#define IFilterGraph2_Abort
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_ShouldOperationContinue(This) (This)->lpVtbl -> ShouldOperationContinue(This)
#define IFilterGraph2_ShouldOperationContinue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddSourceFilterForMoniker(This,pMoniker,pCtx,lpcwstrFilterName,ppFilter) (This)->lpVtbl -> AddSourceFilterForMoniker(This,pMoniker,pCtx,lpcwstrFilterName,ppFilter)
#define IFilterGraph2_AddSourceFilterForMoniker
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_ReconnectEx(This,ppin,pmt) (This)->lpVtbl -> ReconnectEx(This,ppin,pmt)
#define IFilterGraph2_ReconnectEx
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_RenderEx(This,pPinOut,dwFlags,pvContext) (This)->lpVtbl -> RenderEx(This,pPinOut,dwFlags,pvContext)
#define IFilterGraph2_RenderEx
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IStreamBuilder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IStreamBuilder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_Release(This) (This)->lpVtbl -> Release(This)
#define IStreamBuilder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_Render(This,ppinOut,pGraph) (This)->lpVtbl -> Render(This,ppinOut,pGraph)
#define IStreamBuilder_Render
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_Backout(This,ppinOut,pGraph) (This)->lpVtbl -> Backout(This,ppinOut,pGraph)
#define IStreamBuilder_Backout
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAsyncReader_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAsyncReader_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_Release(This) (This)->lpVtbl -> Release(This)
#define IAsyncReader_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_RequestAllocator(This,pPreferred,pProps,ppActual) (This)->lpVtbl -> RequestAllocator(This,pPreferred,pProps,ppActual)
#define IAsyncReader_RequestAllocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_Request(This,pSample,dwUser) (This)->lpVtbl -> Request(This,pSample,dwUser)
#define IAsyncReader_Request
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_WaitForNext(This,dwTimeout,ppSample,pdwUser) (This)->lpVtbl -> WaitForNext(This,dwTimeout,ppSample,pdwUser)
#define IAsyncReader_WaitForNext
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_SyncReadAligned(This,pSample) (This)->lpVtbl -> SyncReadAligned(This,pSample)
#define IAsyncReader_SyncReadAligned
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_SyncRead(This,llPosition,lLength,pBuffer) (This)->lpVtbl -> SyncRead(This,llPosition,lLength,pBuffer)
#define IAsyncReader_SyncRead
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_Length(This,pTotal,pAvailable) (This)->lpVtbl -> Length(This,pTotal,pAvailable)
#define IAsyncReader_Length
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_BeginFlush(This) (This)->lpVtbl -> BeginFlush(This)
#define IAsyncReader_BeginFlush
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_EndFlush(This) (This)->lpVtbl -> EndFlush(This)
#define IAsyncReader_EndFlush
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IGraphVersion_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IGraphVersion_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_Release(This) (This)->lpVtbl -> Release(This)
#define IGraphVersion_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_QueryVersion(This,pVersion) (This)->lpVtbl -> QueryVersion(This,pVersion)
#define IGraphVersion_QueryVersion
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IResourceConsumer_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IResourceConsumer_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_Release(This) (This)->lpVtbl -> Release(This)
#define IResourceConsumer_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_AcquireResource(This,idResource) (This)->lpVtbl -> AcquireResource(This,idResource)
#define IResourceConsumer_AcquireResource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_ReleaseResource(This,idResource) (This)->lpVtbl -> ReleaseResource(This,idResource)
#define IResourceConsumer_ReleaseResource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IResourceManager_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IResourceManager_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_Release(This) (This)->lpVtbl -> Release(This)
#define IResourceManager_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_Register(This,pName,cResource,plToken) (This)->lpVtbl -> Register(This,pName,cResource,plToken)
#define IResourceManager_Register
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_RegisterGroup(This,pName,cResource,palTokens,plToken) (This)->lpVtbl -> RegisterGroup(This,pName,cResource,palTokens,plToken)
#define IResourceManager_RegisterGroup
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_RequestResource(This,idResource,pFocusObject,pConsumer) (This)->lpVtbl -> RequestResource(This,idResource,pFocusObject,pConsumer)
#define IResourceManager_RequestResource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_NotifyAcquire(This,idResource,pConsumer,hr) (This)->lpVtbl -> NotifyAcquire(This,idResource,pConsumer,hr)
#define IResourceManager_NotifyAcquire
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_NotifyRelease(This,idResource,pConsumer,bStillWant) (This)->lpVtbl -> NotifyRelease(This,idResource,pConsumer,bStillWant)
#define IResourceManager_NotifyRelease
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_CancelRequest(This,idResource,pConsumer) (This)->lpVtbl -> CancelRequest(This,idResource,pConsumer)
#define IResourceManager_CancelRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_SetFocus(This,pFocusObject) (This)->lpVtbl -> SetFocus(This,pFocusObject)
#define IResourceManager_SetFocus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_ReleaseFocus(This,pFocusObject) (This)->lpVtbl -> ReleaseFocus(This,pFocusObject)
#define IResourceManager_ReleaseFocus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDistributorNotify_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDistributorNotify_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Release(This) (This)->lpVtbl -> Release(This)
#define IDistributorNotify_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Stop(This) (This)->lpVtbl -> Stop(This)
#define IDistributorNotify_Stop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Pause(This) (This)->lpVtbl -> Pause(This)
#define IDistributorNotify_Pause
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Run(This,tStart) (This)->lpVtbl -> Run(This,tStart)
#define IDistributorNotify_Run
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_SetSyncSource(This,pClock) (This)->lpVtbl -> SetSyncSource(This,pClock)
#define IDistributorNotify_SetSyncSource
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_NotifyGraphChange(This) (This)->lpVtbl -> NotifyGraphChange(This)
#define IDistributorNotify_NotifyGraphChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMStreamControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMStreamControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_Release(This) (This)->lpVtbl -> Release(This)
#define IAMStreamControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_StartAt(This,ptStart,dwCookie) (This)->lpVtbl -> StartAt(This,ptStart,dwCookie)
#define IAMStreamControl_StartAt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_StopAt(This,ptStop,bSendExtra,dwCookie) (This)->lpVtbl -> StopAt(This,ptStop,bSendExtra,dwCookie)
#define IAMStreamControl_StopAt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_GetInfo(This,pInfo) (This)->lpVtbl -> GetInfo(This,pInfo)
#define IAMStreamControl_GetInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ISeekingPassThru_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ISeekingPassThru_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_Release(This) (This)->lpVtbl -> Release(This)
#define ISeekingPassThru_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_Init(This,bSupportRendering,pPin) (This)->lpVtbl -> Init(This,bSupportRendering,pPin)
#define ISeekingPassThru_Init
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMStreamConfig_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMStreamConfig_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_Release(This) (This)->lpVtbl -> Release(This)
#define IAMStreamConfig_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_SetFormat(This,pmt) (This)->lpVtbl -> SetFormat(This,pmt)
#define IAMStreamConfig_SetFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_GetFormat(This,ppmt) (This)->lpVtbl -> GetFormat(This,ppmt)
#define IAMStreamConfig_GetFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_GetNumberOfCapabilities(This,piCount,piSize) (This)->lpVtbl -> GetNumberOfCapabilities(This,piCount,piSize)
#define IAMStreamConfig_GetNumberOfCapabilities
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_GetStreamCaps(This,iIndex,ppmt,pSCC) (This)->lpVtbl -> GetStreamCaps(This,iIndex,ppmt,pSCC)
#define IAMStreamConfig_GetStreamCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IConfigInterleaving_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IConfigInterleaving_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_Release(This) (This)->lpVtbl -> Release(This)
#define IConfigInterleaving_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_put_Mode(This,mode) (This)->lpVtbl -> put_Mode(This,mode)
#define IConfigInterleaving_put_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_get_Mode(This,pMode) (This)->lpVtbl -> get_Mode(This,pMode)
#define IConfigInterleaving_get_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_put_Interleaving(This,prtInterleave,prtPreroll) (This)->lpVtbl -> put_Interleaving(This,prtInterleave,prtPreroll)
#define IConfigInterleaving_put_Interleaving
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_get_Interleaving(This,prtInterleave,prtPreroll) (This)->lpVtbl -> get_Interleaving(This,prtInterleave,prtPreroll)
#define IConfigInterleaving_get_Interleaving
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IConfigAviMux_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IConfigAviMux_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_Release(This) (This)->lpVtbl -> Release(This)
#define IConfigAviMux_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_SetMasterStream(This,iStream) (This)->lpVtbl -> SetMasterStream(This,iStream)
#define IConfigAviMux_SetMasterStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_GetMasterStream(This,pStream) (This)->lpVtbl -> GetMasterStream(This,pStream)
#define IConfigAviMux_GetMasterStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_SetOutputCompatibilityIndex(This,fOldIndex) (This)->lpVtbl -> SetOutputCompatibilityIndex(This,fOldIndex)
#define IConfigAviMux_SetOutputCompatibilityIndex
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_GetOutputCompatibilityIndex(This,pfOldIndex) (This)->lpVtbl -> GetOutputCompatibilityIndex(This,pfOldIndex)
#define IConfigAviMux_GetOutputCompatibilityIndex
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMVideoCompression_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMVideoCompression_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_Release(This) (This)->lpVtbl -> Release(This)
#define IAMVideoCompression_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_KeyFrameRate(This,KeyFrameRate) (This)->lpVtbl -> put_KeyFrameRate(This,KeyFrameRate)
#define IAMVideoCompression_put_KeyFrameRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_KeyFrameRate(This,pKeyFrameRate) (This)->lpVtbl -> get_KeyFrameRate(This,pKeyFrameRate)
#define IAMVideoCompression_get_KeyFrameRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_PFramesPerKeyFrame(This,PFramesPerKeyFrame) (This)->lpVtbl -> put_PFramesPerKeyFrame(This,PFramesPerKeyFrame)
#define IAMVideoCompression_put_PFramesPerKeyFrame
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_PFramesPerKeyFrame(This,pPFramesPerKeyFrame) (This)->lpVtbl -> get_PFramesPerKeyFrame(This,pPFramesPerKeyFrame)
#define IAMVideoCompression_get_PFramesPerKeyFrame
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_Quality(This,Quality) (This)->lpVtbl -> put_Quality(This,Quality)
#define IAMVideoCompression_put_Quality
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_Quality(This,pQuality) (This)->lpVtbl -> get_Quality(This,pQuality)
#define IAMVideoCompression_get_Quality
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_WindowSize(This,WindowSize) (This)->lpVtbl -> put_WindowSize(This,WindowSize)
#define IAMVideoCompression_put_WindowSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_WindowSize(This,pWindowSize) (This)->lpVtbl -> get_WindowSize(This,pWindowSize)
#define IAMVideoCompression_get_WindowSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_GetInfo(This,pszVersion,pcbVersion,pszDescription,pcbDescription,pDefaultKeyFrameRate,pDefaultPFramesPerKey,pDefaultQuality,pCapabilities) (This)->lpVtbl -> GetInfo(This,pszVersion,pcbVersion,pszDescription,pcbDescription,pDefaultKeyFrameRate,pDefaultPFramesPerKey,pDefaultQuality,pCapabilities)
#define IAMVideoCompression_GetInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_OverrideKeyFrame(This,FrameNumber) (This)->lpVtbl -> OverrideKeyFrame(This,FrameNumber)
#define IAMVideoCompression_OverrideKeyFrame
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_OverrideFrameSize(This,FrameNumber,Size) (This)->lpVtbl -> OverrideFrameSize(This,FrameNumber,Size)
#define IAMVideoCompression_OverrideFrameSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMVfwCaptureDialogs_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMVfwCaptureDialogs_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_Release(This) (This)->lpVtbl -> Release(This)
#define IAMVfwCaptureDialogs_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_HasDialog(This,iDialog) (This)->lpVtbl -> HasDialog(This,iDialog)
#define IAMVfwCaptureDialogs_HasDialog
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_ShowDialog(This,iDialog,hwnd) (This)->lpVtbl -> ShowDialog(This,iDialog,hwnd)
#define IAMVfwCaptureDialogs_ShowDialog
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_SendDriverMessage(This,iDialog,uMsg,dw1,dw2) (This)->lpVtbl -> SendDriverMessage(This,iDialog,uMsg,dw1,dw2)
#define IAMVfwCaptureDialogs_SendDriverMessage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMVfwCompressDialogs_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMVfwCompressDialogs_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_Release(This) (This)->lpVtbl -> Release(This)
#define IAMVfwCompressDialogs_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_ShowDialog(This,iDialog,hwnd) (This)->lpVtbl -> ShowDialog(This,iDialog,hwnd)
#define IAMVfwCompressDialogs_ShowDialog
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_GetState(This,pState,pcbState) (This)->lpVtbl -> GetState(This,pState,pcbState)
#define IAMVfwCompressDialogs_GetState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_SetState(This,pState,cbState) (This)->lpVtbl -> SetState(This,pState,cbState)
#define IAMVfwCompressDialogs_SetState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_SendDriverMessage(This,uMsg,dw1,dw2) (This)->lpVtbl -> SendDriverMessage(This,uMsg,dw1,dw2)
#define IAMVfwCompressDialogs_SendDriverMessage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMDroppedFrames_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMDroppedFrames_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_Release(This) (This)->lpVtbl -> Release(This)
#define IAMDroppedFrames_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetNumDropped(This,plDropped) (This)->lpVtbl -> GetNumDropped(This,plDropped)
#define IAMDroppedFrames_GetNumDropped
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetNumNotDropped(This,plNotDropped) (This)->lpVtbl -> GetNumNotDropped(This,plNotDropped)
#define IAMDroppedFrames_GetNumNotDropped
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetDroppedInfo(This,lSize,plArray,plNumCopied) (This)->lpVtbl -> GetDroppedInfo(This,lSize,plArray,plNumCopied)
#define IAMDroppedFrames_GetDroppedInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetAverageFrameSize(This,plAverageSize) (This)->lpVtbl -> GetAverageFrameSize(This,plAverageSize)
#define IAMDroppedFrames_GetAverageFrameSize
#define AMF_AUTOMATICGAIN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMAudioInputMixer_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMAudioInputMixer_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_Release(This) (This)->lpVtbl -> Release(This)
#define IAMAudioInputMixer_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Enable(This,fEnable) (This)->lpVtbl -> put_Enable(This,fEnable)
#define IAMAudioInputMixer_put_Enable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Enable(This,pfEnable) (This)->lpVtbl -> get_Enable(This,pfEnable)
#define IAMAudioInputMixer_get_Enable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Mono(This,fMono) (This)->lpVtbl -> put_Mono(This,fMono)
#define IAMAudioInputMixer_put_Mono
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Mono(This,pfMono) (This)->lpVtbl -> get_Mono(This,pfMono)
#define IAMAudioInputMixer_get_Mono
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_MixLevel(This,Level) (This)->lpVtbl -> put_MixLevel(This,Level)
#define IAMAudioInputMixer_put_MixLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_MixLevel(This,pLevel) (This)->lpVtbl -> get_MixLevel(This,pLevel)
#define IAMAudioInputMixer_get_MixLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Pan(This,Pan) (This)->lpVtbl -> put_Pan(This,Pan)
#define IAMAudioInputMixer_put_Pan
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Pan(This,pPan) (This)->lpVtbl -> get_Pan(This,pPan)
#define IAMAudioInputMixer_get_Pan
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Loudness(This,fLoudness) (This)->lpVtbl -> put_Loudness(This,fLoudness)
#define IAMAudioInputMixer_put_Loudness
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Loudness(This,pfLoudness) (This)->lpVtbl -> get_Loudness(This,pfLoudness)
#define IAMAudioInputMixer_get_Loudness
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Treble(This,Treble) (This)->lpVtbl -> put_Treble(This,Treble)
#define IAMAudioInputMixer_put_Treble
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Treble(This,pTreble) (This)->lpVtbl -> get_Treble(This,pTreble)
#define IAMAudioInputMixer_get_Treble
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_TrebleRange(This,pRange) (This)->lpVtbl -> get_TrebleRange(This,pRange)
#define IAMAudioInputMixer_get_TrebleRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Bass(This,Bass) (This)->lpVtbl -> put_Bass(This,Bass)
#define IAMAudioInputMixer_put_Bass
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Bass(This,pBass) (This)->lpVtbl -> get_Bass(This,pBass)
#define IAMAudioInputMixer_get_Bass
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_BassRange(This,pRange) (This)->lpVtbl -> get_BassRange(This,pRange)
#define IAMAudioInputMixer_get_BassRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMBufferNegotiation_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMBufferNegotiation_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_Release(This) (This)->lpVtbl -> Release(This)
#define IAMBufferNegotiation_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_SuggestAllocatorProperties(This,pprop) (This)->lpVtbl -> SuggestAllocatorProperties(This,pprop)
#define IAMBufferNegotiation_SuggestAllocatorProperties
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_GetAllocatorProperties(This,pprop) (This)->lpVtbl -> GetAllocatorProperties(This,pprop)
#define IAMBufferNegotiation_GetAllocatorProperties
#define AnalogVideo_NTSC_Mask
#define AnalogVideo_PAL_Mask
#define AnalogVideo_SECAM_Mask
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMAnalogVideoDecoder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMAnalogVideoDecoder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_Release(This) (This)->lpVtbl -> Release(This)
#define IAMAnalogVideoDecoder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_AvailableTVFormats(This,lAnalogVideoStandard) (This)->lpVtbl -> get_AvailableTVFormats(This,lAnalogVideoStandard)
#define IAMAnalogVideoDecoder_get_AvailableTVFormats
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_put_TVFormat(This,lAnalogVideoStandard) (This)->lpVtbl -> put_TVFormat(This,lAnalogVideoStandard)
#define IAMAnalogVideoDecoder_put_TVFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_TVFormat(This,plAnalogVideoStandard) (This)->lpVtbl -> get_TVFormat(This,plAnalogVideoStandard)
#define IAMAnalogVideoDecoder_get_TVFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_HorizontalLocked(This,plLocked) (This)->lpVtbl -> get_HorizontalLocked(This,plLocked)
#define IAMAnalogVideoDecoder_get_HorizontalLocked
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_put_VCRHorizontalLocking(This,lVCRHorizontalLocking) (This)->lpVtbl -> put_VCRHorizontalLocking(This,lVCRHorizontalLocking)
#define IAMAnalogVideoDecoder_put_VCRHorizontalLocking
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_VCRHorizontalLocking(This,plVCRHorizontalLocking) (This)->lpVtbl -> get_VCRHorizontalLocking(This,plVCRHorizontalLocking)
#define IAMAnalogVideoDecoder_get_VCRHorizontalLocking
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_NumberOfLines(This,plNumberOfLines) (This)->lpVtbl -> get_NumberOfLines(This,plNumberOfLines)
#define IAMAnalogVideoDecoder_get_NumberOfLines
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_put_OutputEnable(This,lOutputEnable) (This)->lpVtbl -> put_OutputEnable(This,lOutputEnable)
#define IAMAnalogVideoDecoder_put_OutputEnable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_OutputEnable(This,plOutputEnable) (This)->lpVtbl -> get_OutputEnable(This,plOutputEnable)
#define IAMAnalogVideoDecoder_get_OutputEnable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMVideoProcAmp_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMVideoProcAmp_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_Release(This) (This)->lpVtbl -> Release(This)
#define IAMVideoProcAmp_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags) (This)->lpVtbl -> GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags)
#define IAMVideoProcAmp_GetRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_Set(This,Property,lValue,Flags) (This)->lpVtbl -> Set(This,Property,lValue,Flags)
#define IAMVideoProcAmp_Set
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_Get(This,Property,lValue,Flags) (This)->lpVtbl -> Get(This,Property,lValue,Flags)
#define IAMVideoProcAmp_Get
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMCameraControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMCameraControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_Release(This) (This)->lpVtbl -> Release(This)
#define IAMCameraControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags) (This)->lpVtbl -> GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags)
#define IAMCameraControl_GetRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_Set(This,Property,lValue,Flags) (This)->lpVtbl -> Set(This,Property,lValue,Flags)
#define IAMCameraControl_Set
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_Get(This,Property,lValue,Flags) (This)->lpVtbl -> Get(This,Property,lValue,Flags)
#define IAMCameraControl_Get
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMVideoControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMVideoControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_Release(This) (This)->lpVtbl -> Release(This)
#define IAMVideoControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetCaps(This,pPin,pCapsFlags) (This)->lpVtbl -> GetCaps(This,pPin,pCapsFlags)
#define IAMVideoControl_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_SetMode(This,pPin,Mode) (This)->lpVtbl -> SetMode(This,pPin,Mode)
#define IAMVideoControl_SetMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetMode(This,pPin,Mode) (This)->lpVtbl -> GetMode(This,pPin,Mode)
#define IAMVideoControl_GetMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetCurrentActualFrameRate(This,pPin,ActualFrameRate) (This)->lpVtbl -> GetCurrentActualFrameRate(This,pPin,ActualFrameRate)
#define IAMVideoControl_GetCurrentActualFrameRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetMaxAvailableFrameRate(This,pPin,iIndex,Dimensions,MaxAvailableFrameRate) (This)->lpVtbl -> GetMaxAvailableFrameRate(This,pPin,iIndex,Dimensions,MaxAvailableFrameRate)
#define IAMVideoControl_GetMaxAvailableFrameRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetFrameRateList(This,pPin,iIndex,Dimensions,ListSize,FrameRates) (This)->lpVtbl -> GetFrameRateList(This,pPin,iIndex,Dimensions,ListSize,FrameRates)
#define IAMVideoControl_GetFrameRateList
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMCrossbar_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMCrossbar_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_Release(This) (This)->lpVtbl -> Release(This)
#define IAMCrossbar_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_get_PinCounts(This,OutputPinCount,InputPinCount) (This)->lpVtbl -> get_PinCounts(This,OutputPinCount,InputPinCount)
#define IAMCrossbar_get_PinCounts
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_CanRoute(This,OutputPinIndex,InputPinIndex) (This)->lpVtbl -> CanRoute(This,OutputPinIndex,InputPinIndex)
#define IAMCrossbar_CanRoute
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_Route(This,OutputPinIndex,InputPinIndex) (This)->lpVtbl -> Route(This,OutputPinIndex,InputPinIndex)
#define IAMCrossbar_Route
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_get_IsRoutedTo(This,OutputPinIndex,InputPinIndex) (This)->lpVtbl -> get_IsRoutedTo(This,OutputPinIndex,InputPinIndex)
#define IAMCrossbar_get_IsRoutedTo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_get_CrossbarPinInfo(This,IsInputPin,PinIndex,PinIndexRelated,PhysicalType) (This)->lpVtbl -> get_CrossbarPinInfo(This,IsInputPin,PinIndex,PinIndexRelated,PhysicalType)
#define IAMCrossbar_get_CrossbarPinInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTuner_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTuner_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTuner_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel) (This)->lpVtbl -> put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel)
#define IAMTuner_put_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel) (This)->lpVtbl -> get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel)
#define IAMTuner_get_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_ChannelMinMax(This,lChannelMin,lChannelMax) (This)->lpVtbl -> ChannelMinMax(This,lChannelMin,lChannelMax)
#define IAMTuner_ChannelMinMax
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_CountryCode(This,lCountryCode) (This)->lpVtbl -> put_CountryCode(This,lCountryCode)
#define IAMTuner_put_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_CountryCode(This,plCountryCode) (This)->lpVtbl -> get_CountryCode(This,plCountryCode)
#define IAMTuner_get_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_TuningSpace(This,lTuningSpace) (This)->lpVtbl -> put_TuningSpace(This,lTuningSpace)
#define IAMTuner_put_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_TuningSpace(This,plTuningSpace) (This)->lpVtbl -> get_TuningSpace(This,plTuningSpace)
#define IAMTuner_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_Logon(This,hCurrentUser) (This)->lpVtbl -> Logon(This,hCurrentUser)
#define IAMTuner_Logon
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_Logout(This) (This)->lpVtbl -> Logout(This)
#define IAMTuner_Logout
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_SignalPresent(This,plSignalStrength) (This)->lpVtbl -> SignalPresent(This,plSignalStrength)
#define IAMTuner_SignalPresent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_Mode(This,lMode) (This)->lpVtbl -> put_Mode(This,lMode)
#define IAMTuner_put_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_Mode(This,plMode) (This)->lpVtbl -> get_Mode(This,plMode)
#define IAMTuner_get_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_GetAvailableModes(This,plModes) (This)->lpVtbl -> GetAvailableModes(This,plModes)
#define IAMTuner_GetAvailableModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
#define IAMTuner_RegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
#define IAMTuner_UnRegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTunerNotification_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTunerNotification_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTunerNotification_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_OnEvent(This,Event) (This)->lpVtbl -> OnEvent(This,Event)
#define IAMTunerNotification_OnEvent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTVTuner_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTVTuner_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTVTuner_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel) (This)->lpVtbl -> put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel)
#define IAMTVTuner_put_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel) (This)->lpVtbl -> get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel)
#define IAMTVTuner_get_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_ChannelMinMax(This,lChannelMin,lChannelMax) (This)->lpVtbl -> ChannelMinMax(This,lChannelMin,lChannelMax)
#define IAMTVTuner_ChannelMinMax
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_CountryCode(This,lCountryCode) (This)->lpVtbl -> put_CountryCode(This,lCountryCode)
#define IAMTVTuner_put_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_CountryCode(This,plCountryCode) (This)->lpVtbl -> get_CountryCode(This,plCountryCode)
#define IAMTVTuner_get_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_TuningSpace(This,lTuningSpace) (This)->lpVtbl -> put_TuningSpace(This,lTuningSpace)
#define IAMTVTuner_put_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_TuningSpace(This,plTuningSpace) (This)->lpVtbl -> get_TuningSpace(This,plTuningSpace)
#define IAMTVTuner_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_Logon(This,hCurrentUser) (This)->lpVtbl -> Logon(This,hCurrentUser)
#define IAMTVTuner_Logon
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_Logout(This) (This)->lpVtbl -> Logout(This)
#define IAMTVTuner_Logout
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_SignalPresent(This,plSignalStrength) (This)->lpVtbl -> SignalPresent(This,plSignalStrength)
#define IAMTVTuner_SignalPresent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_Mode(This,lMode) (This)->lpVtbl -> put_Mode(This,lMode)
#define IAMTVTuner_put_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_Mode(This,plMode) (This)->lpVtbl -> get_Mode(This,plMode)
#define IAMTVTuner_get_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_GetAvailableModes(This,plModes) (This)->lpVtbl -> GetAvailableModes(This,plModes)
#define IAMTVTuner_GetAvailableModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
#define IAMTVTuner_RegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
#define IAMTVTuner_UnRegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_AvailableTVFormats(This,lAnalogVideoStandard) (This)->lpVtbl -> get_AvailableTVFormats(This,lAnalogVideoStandard)
#define IAMTVTuner_get_AvailableTVFormats
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_TVFormat(This,plAnalogVideoStandard) (This)->lpVtbl -> get_TVFormat(This,plAnalogVideoStandard)
#define IAMTVTuner_get_TVFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_AutoTune(This,lChannel,plFoundSignal) (This)->lpVtbl -> AutoTune(This,lChannel,plFoundSignal)
#define IAMTVTuner_AutoTune
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_StoreAutoTune(This) (This)->lpVtbl -> StoreAutoTune(This)
#define IAMTVTuner_StoreAutoTune
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_NumInputConnections(This,plNumInputConnections) (This)->lpVtbl -> get_NumInputConnections(This,plNumInputConnections)
#define IAMTVTuner_get_NumInputConnections
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_InputType(This,lIndex,InputType) (This)->lpVtbl -> put_InputType(This,lIndex,InputType)
#define IAMTVTuner_put_InputType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_InputType(This,lIndex,pInputType) (This)->lpVtbl -> get_InputType(This,lIndex,pInputType)
#define IAMTVTuner_get_InputType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_ConnectInput(This,lIndex) (This)->lpVtbl -> put_ConnectInput(This,lIndex)
#define IAMTVTuner_put_ConnectInput
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_ConnectInput(This,plIndex) (This)->lpVtbl -> get_ConnectInput(This,plIndex)
#define IAMTVTuner_get_ConnectInput
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_VideoFrequency(This,lFreq) (This)->lpVtbl -> get_VideoFrequency(This,lFreq)
#define IAMTVTuner_get_VideoFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_AudioFrequency(This,lFreq) (This)->lpVtbl -> get_AudioFrequency(This,lFreq)
#define IAMTVTuner_get_AudioFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IBPCSatelliteTuner_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IBPCSatelliteTuner_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_Release(This) (This)->lpVtbl -> Release(This)
#define IBPCSatelliteTuner_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel) (This)->lpVtbl -> put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel)
#define IBPCSatelliteTuner_put_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel) (This)->lpVtbl -> get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel)
#define IBPCSatelliteTuner_get_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_ChannelMinMax(This,lChannelMin,lChannelMax) (This)->lpVtbl -> ChannelMinMax(This,lChannelMin,lChannelMax)
#define IBPCSatelliteTuner_ChannelMinMax
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_CountryCode(This,lCountryCode) (This)->lpVtbl -> put_CountryCode(This,lCountryCode)
#define IBPCSatelliteTuner_put_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_CountryCode(This,plCountryCode) (This)->lpVtbl -> get_CountryCode(This,plCountryCode)
#define IBPCSatelliteTuner_get_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_TuningSpace(This,lTuningSpace) (This)->lpVtbl -> put_TuningSpace(This,lTuningSpace)
#define IBPCSatelliteTuner_put_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_TuningSpace(This,plTuningSpace) (This)->lpVtbl -> get_TuningSpace(This,plTuningSpace)
#define IBPCSatelliteTuner_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_Logon(This,hCurrentUser) (This)->lpVtbl -> Logon(This,hCurrentUser)
#define IBPCSatelliteTuner_Logon
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_Logout(This) (This)->lpVtbl -> Logout(This)
#define IBPCSatelliteTuner_Logout
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_SignalPresent(This,plSignalStrength) (This)->lpVtbl -> SignalPresent(This,plSignalStrength)
#define IBPCSatelliteTuner_SignalPresent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_Mode(This,lMode) (This)->lpVtbl -> put_Mode(This,lMode)
#define IBPCSatelliteTuner_put_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_Mode(This,plMode) (This)->lpVtbl -> get_Mode(This,plMode)
#define IBPCSatelliteTuner_get_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_GetAvailableModes(This,plModes) (This)->lpVtbl -> GetAvailableModes(This,plModes)
#define IBPCSatelliteTuner_GetAvailableModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
#define IBPCSatelliteTuner_RegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
#define IBPCSatelliteTuner_UnRegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_DefaultSubChannelTypes(This,plDefaultVideoType,plDefaultAudioType) (This)->lpVtbl -> get_DefaultSubChannelTypes(This,plDefaultVideoType,plDefaultAudioType)
#define IBPCSatelliteTuner_get_DefaultSubChannelTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_DefaultSubChannelTypes(This,lDefaultVideoType,lDefaultAudioType) (This)->lpVtbl -> put_DefaultSubChannelTypes(This,lDefaultVideoType,lDefaultAudioType)
#define IBPCSatelliteTuner_put_DefaultSubChannelTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_IsTapingPermitted(This) (This)->lpVtbl -> IsTapingPermitted(This)
#define IBPCSatelliteTuner_IsTapingPermitted
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTVAudio_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTVAudio_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTVAudio_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_GetHardwareSupportedTVAudioModes(This,plModes) (This)->lpVtbl -> GetHardwareSupportedTVAudioModes(This,plModes)
#define IAMTVAudio_GetHardwareSupportedTVAudioModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_GetAvailableTVAudioModes(This,plModes) (This)->lpVtbl -> GetAvailableTVAudioModes(This,plModes)
#define IAMTVAudio_GetAvailableTVAudioModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_get_TVAudioMode(This,plMode) (This)->lpVtbl -> get_TVAudioMode(This,plMode)
#define IAMTVAudio_get_TVAudioMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_put_TVAudioMode(This,lMode) (This)->lpVtbl -> put_TVAudioMode(This,lMode)
#define IAMTVAudio_put_TVAudioMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
#define IAMTVAudio_RegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
#define IAMTVAudio_UnRegisterNotificationCallBack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTVAudioNotification_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTVAudioNotification_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTVAudioNotification_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_OnEvent(This,Event) (This)->lpVtbl -> OnEvent(This,Event)
#define IAMTVAudioNotification_OnEvent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMAnalogVideoEncoder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMAnalogVideoEncoder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_Release(This) (This)->lpVtbl -> Release(This)
#define IAMAnalogVideoEncoder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_AvailableTVFormats(This,lAnalogVideoStandard) (This)->lpVtbl -> get_AvailableTVFormats(This,lAnalogVideoStandard)
#define IAMAnalogVideoEncoder_get_AvailableTVFormats
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_put_TVFormat(This,lAnalogVideoStandard) (This)->lpVtbl -> put_TVFormat(This,lAnalogVideoStandard)
#define IAMAnalogVideoEncoder_put_TVFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_TVFormat(This,plAnalogVideoStandard) (This)->lpVtbl -> get_TVFormat(This,plAnalogVideoStandard)
#define IAMAnalogVideoEncoder_get_TVFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_put_CopyProtection(This,lVideoCopyProtection) (This)->lpVtbl -> put_CopyProtection(This,lVideoCopyProtection)
#define IAMAnalogVideoEncoder_put_CopyProtection
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_CopyProtection(This,lVideoCopyProtection) (This)->lpVtbl -> get_CopyProtection(This,lVideoCopyProtection)
#define IAMAnalogVideoEncoder_get_CopyProtection
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_put_CCEnable(This,lCCEnable) (This)->lpVtbl -> put_CCEnable(This,lCCEnable)
#define IAMAnalogVideoEncoder_put_CCEnable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_CCEnable(This,lCCEnable) (This)->lpVtbl -> get_CCEnable(This,lCCEnable)
#define IAMAnalogVideoEncoder_get_CCEnable
#define KSPROPERTY_SUPPORT_GET
#define KSPROPERTY_SUPPORT_SET
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IKsPropertySet_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IKsPropertySet_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_Release(This) (This)->lpVtbl -> Release(This)
#define IKsPropertySet_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_Set(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData) (This)->lpVtbl -> Set(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData)
#define IKsPropertySet_Set
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_Get(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData,pcbReturned) (This)->lpVtbl -> Get(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData,pcbReturned)
#define IKsPropertySet_Get
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_QuerySupported(This,guidPropSet,dwPropID,pTypeSupport) (This)->lpVtbl -> QuerySupported(This,guidPropSet,dwPropID,pTypeSupport)
#define IKsPropertySet_QuerySupported
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMediaPropertyBag_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMediaPropertyBag_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_Release(This) (This)->lpVtbl -> Release(This)
#define IMediaPropertyBag_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_Read(This,pszPropName,pVar,pErrorLog) (This)->lpVtbl -> Read(This,pszPropName,pVar,pErrorLog)
#define IMediaPropertyBag_Read
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_Write(This,pszPropName,pVar) (This)->lpVtbl -> Write(This,pszPropName,pVar)
#define IMediaPropertyBag_Write
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_EnumProperty(This,iProperty,pvarPropertyName,pvarPropertyValue) (This)->lpVtbl -> EnumProperty(This,iProperty,pvarPropertyName,pvarPropertyValue)
#define IMediaPropertyBag_EnumProperty
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IPersistMediaPropertyBag_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IPersistMediaPropertyBag_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_Release(This) (This)->lpVtbl -> Release(This)
#define IPersistMediaPropertyBag_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_GetClassID(This,pClassID) (This)->lpVtbl -> GetClassID(This,pClassID)
#define IPersistMediaPropertyBag_GetClassID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_InitNew(This) (This)->lpVtbl -> InitNew(This)
#define IPersistMediaPropertyBag_InitNew
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_Load(This,pPropBag,pErrorLog) (This)->lpVtbl -> Load(This,pPropBag,pErrorLog)
#define IPersistMediaPropertyBag_Load
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_Save(This,pPropBag,fClearDirty,fSaveAllProperties) (This)->lpVtbl -> Save(This,pPropBag,fClearDirty,fSaveAllProperties)
#define IPersistMediaPropertyBag_Save
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMPhysicalPinInfo_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMPhysicalPinInfo_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_Release(This) (This)->lpVtbl -> Release(This)
#define IAMPhysicalPinInfo_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_GetPhysicalType(This,pType,ppszType) (This)->lpVtbl -> GetPhysicalType(This,pType,ppszType)
#define IAMPhysicalPinInfo_GetPhysicalType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMExtDevice_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMExtDevice_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_Release(This) (This)->lpVtbl -> Release(This)
#define IAMExtDevice_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_GetCapability(This,Capability,pValue,pdblValue) (This)->lpVtbl -> GetCapability(This,Capability,pValue,pdblValue)
#define IAMExtDevice_GetCapability
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_ExternalDeviceID(This,ppszData) (This)->lpVtbl -> get_ExternalDeviceID(This,ppszData)
#define IAMExtDevice_get_ExternalDeviceID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_ExternalDeviceVersion(This,ppszData) (This)->lpVtbl -> get_ExternalDeviceVersion(This,ppszData)
#define IAMExtDevice_get_ExternalDeviceVersion
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_put_DevicePower(This,PowerMode) (This)->lpVtbl -> put_DevicePower(This,PowerMode)
#define IAMExtDevice_put_DevicePower
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_DevicePower(This,pPowerMode) (This)->lpVtbl -> get_DevicePower(This,pPowerMode)
#define IAMExtDevice_get_DevicePower
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_Calibrate(This,hEvent,Mode,pStatus) (This)->lpVtbl -> Calibrate(This,hEvent,Mode,pStatus)
#define IAMExtDevice_Calibrate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_put_DevicePort(This,DevicePort) (This)->lpVtbl -> put_DevicePort(This,DevicePort)
#define IAMExtDevice_put_DevicePort
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_DevicePort(This,pDevicePort) (This)->lpVtbl -> get_DevicePort(This,pDevicePort)
#define IAMExtDevice_get_DevicePort
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMExtTransport_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMExtTransport_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_Release(This) (This)->lpVtbl -> Release(This)
#define IAMExtTransport_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetCapability(This,Capability,pValue,pdblValue) (This)->lpVtbl -> GetCapability(This,Capability,pValue,pdblValue)
#define IAMExtTransport_GetCapability
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_MediaState(This,State) (This)->lpVtbl -> put_MediaState(This,State)
#define IAMExtTransport_put_MediaState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_MediaState(This,pState) (This)->lpVtbl -> get_MediaState(This,pState)
#define IAMExtTransport_get_MediaState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_LocalControl(This,State) (This)->lpVtbl -> put_LocalControl(This,State)
#define IAMExtTransport_put_LocalControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_LocalControl(This,pState) (This)->lpVtbl -> get_LocalControl(This,pState)
#define IAMExtTransport_get_LocalControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetStatus(This,StatusItem,pValue) (This)->lpVtbl -> GetStatus(This,StatusItem,pValue)
#define IAMExtTransport_GetStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetTransportBasicParameters(This,Param,pValue,ppszData) (This)->lpVtbl -> GetTransportBasicParameters(This,Param,pValue,ppszData)
#define IAMExtTransport_GetTransportBasicParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetTransportBasicParameters(This,Param,Value,pszData) (This)->lpVtbl -> SetTransportBasicParameters(This,Param,Value,pszData)
#define IAMExtTransport_SetTransportBasicParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetTransportVideoParameters(This,Param,pValue) (This)->lpVtbl -> GetTransportVideoParameters(This,Param,pValue)
#define IAMExtTransport_GetTransportVideoParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetTransportVideoParameters(This,Param,Value) (This)->lpVtbl -> SetTransportVideoParameters(This,Param,Value)
#define IAMExtTransport_SetTransportVideoParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetTransportAudioParameters(This,Param,pValue) (This)->lpVtbl -> GetTransportAudioParameters(This,Param,pValue)
#define IAMExtTransport_GetTransportAudioParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetTransportAudioParameters(This,Param,Value) (This)->lpVtbl -> SetTransportAudioParameters(This,Param,Value)
#define IAMExtTransport_SetTransportAudioParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_Mode(This,Mode) (This)->lpVtbl -> put_Mode(This,Mode)
#define IAMExtTransport_put_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_Mode(This,pMode) (This)->lpVtbl -> get_Mode(This,pMode)
#define IAMExtTransport_get_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_Rate(This,dblRate) (This)->lpVtbl -> put_Rate(This,dblRate)
#define IAMExtTransport_put_Rate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_Rate(This,pdblRate) (This)->lpVtbl -> get_Rate(This,pdblRate)
#define IAMExtTransport_get_Rate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetChase(This,pEnabled,pOffset,phEvent) (This)->lpVtbl -> GetChase(This,pEnabled,pOffset,phEvent)
#define IAMExtTransport_GetChase
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetChase(This,Enable,Offset,hEvent) (This)->lpVtbl -> SetChase(This,Enable,Offset,hEvent)
#define IAMExtTransport_SetChase
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetBump(This,pSpeed,pDuration) (This)->lpVtbl -> GetBump(This,pSpeed,pDuration)
#define IAMExtTransport_GetBump
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetBump(This,Speed,Duration) (This)->lpVtbl -> SetBump(This,Speed,Duration)
#define IAMExtTransport_SetBump
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_AntiClogControl(This,pEnabled) (This)->lpVtbl -> get_AntiClogControl(This,pEnabled)
#define IAMExtTransport_get_AntiClogControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_AntiClogControl(This,Enable) (This)->lpVtbl -> put_AntiClogControl(This,Enable)
#define IAMExtTransport_put_AntiClogControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetEditPropertySet(This,EditID,pState) (This)->lpVtbl -> GetEditPropertySet(This,EditID,pState)
#define IAMExtTransport_GetEditPropertySet
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetEditPropertySet(This,pEditID,State) (This)->lpVtbl -> SetEditPropertySet(This,pEditID,State)
#define IAMExtTransport_SetEditPropertySet
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetEditProperty(This,EditID,Param,pValue) (This)->lpVtbl -> GetEditProperty(This,EditID,Param,pValue)
#define IAMExtTransport_GetEditProperty
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetEditProperty(This,EditID,Param,Value) (This)->lpVtbl -> SetEditProperty(This,EditID,Param,Value)
#define IAMExtTransport_SetEditProperty
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_EditStart(This,pValue) (This)->lpVtbl -> get_EditStart(This,pValue)
#define IAMExtTransport_get_EditStart
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_EditStart(This,Value) (This)->lpVtbl -> put_EditStart(This,Value)
#define IAMExtTransport_put_EditStart
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTimecodeReader_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTimecodeReader_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTimecodeReader_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_GetTCRMode(This,Param,pValue) (This)->lpVtbl -> GetTCRMode(This,Param,pValue)
#define IAMTimecodeReader_GetTCRMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_SetTCRMode(This,Param,Value) (This)->lpVtbl -> SetTCRMode(This,Param,Value)
#define IAMTimecodeReader_SetTCRMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_put_VITCLine(This,Line) (This)->lpVtbl -> put_VITCLine(This,Line)
#define IAMTimecodeReader_put_VITCLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_get_VITCLine(This,pLine) (This)->lpVtbl -> get_VITCLine(This,pLine)
#define IAMTimecodeReader_get_VITCLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_GetTimecode(This,pTimecodeSample) (This)->lpVtbl -> GetTimecode(This,pTimecodeSample)
#define IAMTimecodeReader_GetTimecode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTimecodeGenerator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTimecodeGenerator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTimecodeGenerator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_GetTCGMode(This,Param,pValue) (This)->lpVtbl -> GetTCGMode(This,Param,pValue)
#define IAMTimecodeGenerator_GetTCGMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_SetTCGMode(This,Param,Value) (This)->lpVtbl -> SetTCGMode(This,Param,Value)
#define IAMTimecodeGenerator_SetTCGMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_put_VITCLine(This,Line) (This)->lpVtbl -> put_VITCLine(This,Line)
#define IAMTimecodeGenerator_put_VITCLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_get_VITCLine(This,pLine) (This)->lpVtbl -> get_VITCLine(This,pLine)
#define IAMTimecodeGenerator_get_VITCLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_SetTimecode(This,pTimecodeSample) (This)->lpVtbl -> SetTimecode(This,pTimecodeSample)
#define IAMTimecodeGenerator_SetTimecode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_GetTimecode(This,pTimecodeSample) (This)->lpVtbl -> GetTimecode(This,pTimecodeSample)
#define IAMTimecodeGenerator_GetTimecode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMTimecodeDisplay_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMTimecodeDisplay_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_Release(This) (This)->lpVtbl -> Release(This)
#define IAMTimecodeDisplay_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_GetTCDisplayEnable(This,pState) (This)->lpVtbl -> GetTCDisplayEnable(This,pState)
#define IAMTimecodeDisplay_GetTCDisplayEnable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_SetTCDisplayEnable(This,State) (This)->lpVtbl -> SetTCDisplayEnable(This,State)
#define IAMTimecodeDisplay_SetTCDisplayEnable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_GetTCDisplay(This,Param,pValue) (This)->lpVtbl -> GetTCDisplay(This,Param,pValue)
#define IAMTimecodeDisplay_GetTCDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_SetTCDisplay(This,Param,Value) (This)->lpVtbl -> SetTCDisplay(This,Param,Value)
#define IAMTimecodeDisplay_SetTCDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMDevMemoryAllocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMDevMemoryAllocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_Release(This) (This)->lpVtbl -> Release(This)
#define IAMDevMemoryAllocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_GetInfo(This,pdwcbTotalFree,pdwcbLargestFree,pdwcbTotalMemory,pdwcbMinimumChunk) (This)->lpVtbl -> GetInfo(This,pdwcbTotalFree,pdwcbLargestFree,pdwcbTotalMemory,pdwcbMinimumChunk)
#define IAMDevMemoryAllocator_GetInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_CheckMemory(This,pBuffer) (This)->lpVtbl -> CheckMemory(This,pBuffer)
#define IAMDevMemoryAllocator_CheckMemory
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_Alloc(This,ppBuffer,pdwcbBuffer) (This)->lpVtbl -> Alloc(This,ppBuffer,pdwcbBuffer)
#define IAMDevMemoryAllocator_Alloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_Free(This,pBuffer) (This)->lpVtbl -> Free(This,pBuffer)
#define IAMDevMemoryAllocator_Free
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_GetDevMemoryObject(This,ppUnkInnner,pUnkOuter) (This)->lpVtbl -> GetDevMemoryObject(This,ppUnkInnner,pUnkOuter)
#define IAMDevMemoryAllocator_GetDevMemoryObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMDevMemoryControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMDevMemoryControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_Release(This) (This)->lpVtbl -> Release(This)
#define IAMDevMemoryControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_QueryWriteSync(This) (This)->lpVtbl -> QueryWriteSync(This)
#define IAMDevMemoryControl_QueryWriteSync
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_WriteSync(This) (This)->lpVtbl -> WriteSync(This)
#define IAMDevMemoryControl_WriteSync
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_GetDevId(This,pdwDevId) (This)->lpVtbl -> GetDevId(This,pdwDevId)
#define IAMDevMemoryControl_GetDevId
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMStreamSelect_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMStreamSelect_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Release(This) (This)->lpVtbl -> Release(This)
#define IAMStreamSelect_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Count(This,pcStreams) (This)->lpVtbl -> Count(This,pcStreams)
#define IAMStreamSelect_Count
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Info(This,lIndex,ppmt,pdwFlags,plcid,pdwGroup,ppszName,ppObject,ppUnk) (This)->lpVtbl -> Info(This,lIndex,ppmt,pdwFlags,plcid,pdwGroup,ppszName,ppObject,ppUnk)
#define IAMStreamSelect_Info
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Enable(This,lIndex,dwFlags) (This)->lpVtbl -> Enable(This,lIndex,dwFlags)
#define IAMStreamSelect_Enable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMResourceControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMResourceControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_Release(This) (This)->lpVtbl -> Release(This)
#define IAMResourceControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_Reserve(This,dwFlags,pvReserved) (This)->lpVtbl -> Reserve(This,dwFlags,pvReserved)
#define IAMResourceControl_Reserve
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMClockAdjust_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMClockAdjust_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_Release(This) (This)->lpVtbl -> Release(This)
#define IAMClockAdjust_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_SetClockDelta(This,rtDelta) (This)->lpVtbl -> SetClockDelta(This,rtDelta)
#define IAMClockAdjust_SetClockDelta
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMFilterMiscFlags_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMFilterMiscFlags_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_Release(This) (This)->lpVtbl -> Release(This)
#define IAMFilterMiscFlags_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_GetMiscFlags(This) (This)->lpVtbl -> GetMiscFlags(This)
#define IAMFilterMiscFlags_GetMiscFlags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDrawVideoImage_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDrawVideoImage_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_Release(This) (This)->lpVtbl -> Release(This)
#define IDrawVideoImage_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_DrawVideoImageBegin(This) (This)->lpVtbl -> DrawVideoImageBegin(This)
#define IDrawVideoImage_DrawVideoImageBegin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_DrawVideoImageEnd(This) (This)->lpVtbl -> DrawVideoImageEnd(This)
#define IDrawVideoImage_DrawVideoImageEnd
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_DrawVideoImageDraw(This,hdc,lprcSrc,lprcDst) (This)->lpVtbl -> DrawVideoImageDraw(This,hdc,lprcSrc,lprcDst)
#define IDrawVideoImage_DrawVideoImageDraw
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDecimateVideoImage_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDecimateVideoImage_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_Release(This) (This)->lpVtbl -> Release(This)
#define IDecimateVideoImage_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_SetDecimationImageSize(This,lWidth,lHeight) (This)->lpVtbl -> SetDecimationImageSize(This,lWidth,lHeight)
#define IDecimateVideoImage_SetDecimationImageSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_ResetDecimationImageSize(This) (This)->lpVtbl -> ResetDecimationImageSize(This)
#define IDecimateVideoImage_ResetDecimationImageSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMVideoDecimationProperties_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMVideoDecimationProperties_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_Release(This) (This)->lpVtbl -> Release(This)
#define IAMVideoDecimationProperties_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_QueryDecimationUsage(This,lpUsage) (This)->lpVtbl -> QueryDecimationUsage(This,lpUsage)
#define IAMVideoDecimationProperties_QueryDecimationUsage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_SetDecimationUsage(This,Usage) (This)->lpVtbl -> SetDecimationUsage(This,Usage)
#define IAMVideoDecimationProperties_SetDecimationUsage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVideoFrameStep_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVideoFrameStep_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_Release(This) (This)->lpVtbl -> Release(This)
#define IVideoFrameStep_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_Step(This,dwFrames,pStepObject) (This)->lpVtbl -> Step(This,dwFrames,pStepObject)
#define IVideoFrameStep_Step
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_CanStep(This,bMultiple,pStepObject) (This)->lpVtbl -> CanStep(This,bMultiple,pStepObject)
#define IVideoFrameStep_CanStep
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_CancelStep(This) (This)->lpVtbl -> CancelStep(This)
#define IVideoFrameStep_CancelStep
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMLatency_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMLatency_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_Release(This) (This)->lpVtbl -> Release(This)
#define IAMLatency_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_GetLatency(This,prtLatency) (This)->lpVtbl -> GetLatency(This,prtLatency)
#define IAMLatency_GetLatency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMPushSource_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMPushSource_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_Release(This) (This)->lpVtbl -> Release(This)
#define IAMPushSource_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetLatency(This,prtLatency) (This)->lpVtbl -> GetLatency(This,prtLatency)
#define IAMPushSource_GetLatency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetPushSourceFlags(This,pFlags) (This)->lpVtbl -> GetPushSourceFlags(This,pFlags)
#define IAMPushSource_GetPushSourceFlags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_SetPushSourceFlags(This,Flags) (This)->lpVtbl -> SetPushSourceFlags(This,Flags)
#define IAMPushSource_SetPushSourceFlags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_SetStreamOffset(This,rtOffset) (This)->lpVtbl -> SetStreamOffset(This,rtOffset)
#define IAMPushSource_SetStreamOffset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetStreamOffset(This,prtOffset) (This)->lpVtbl -> GetStreamOffset(This,prtOffset)
#define IAMPushSource_GetStreamOffset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetMaxStreamOffset(This,prtMaxOffset) (This)->lpVtbl -> GetMaxStreamOffset(This,prtMaxOffset)
#define IAMPushSource_GetMaxStreamOffset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_SetMaxStreamOffset(This,rtMaxOffset) (This)->lpVtbl -> SetMaxStreamOffset(This,rtMaxOffset)
#define IAMPushSource_SetMaxStreamOffset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMDeviceRemoval_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMDeviceRemoval_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_Release(This) (This)->lpVtbl -> Release(This)
#define IAMDeviceRemoval_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_DeviceInfo(This,pclsidInterfaceClass,pwszSymbolicLink) (This)->lpVtbl -> DeviceInfo(This,pclsidInterfaceClass,pwszSymbolicLink)
#define IAMDeviceRemoval_DeviceInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_Reassociate(This) (This)->lpVtbl -> Reassociate(This)
#define IAMDeviceRemoval_Reassociate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_Disassociate(This) (This)->lpVtbl -> Disassociate(This)
#define IAMDeviceRemoval_Disassociate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVEnc_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVEnc_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_Release(This) (This)->lpVtbl -> Release(This)
#define IDVEnc_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_get_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo) (This)->lpVtbl -> get_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo)
#define IDVEnc_get_IFormatResolution
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_put_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo) (This)->lpVtbl -> put_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo)
#define IDVEnc_put_IFormatResolution
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IIPDVDec_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IIPDVDec_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_Release(This) (This)->lpVtbl -> Release(This)
#define IIPDVDec_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_get_IPDisplay(This,displayPix) (This)->lpVtbl -> get_IPDisplay(This,displayPix)
#define IIPDVDec_get_IPDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_put_IPDisplay(This,displayPix) (This)->lpVtbl -> put_IPDisplay(This,displayPix)
#define IIPDVDec_put_IPDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVRGB219_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVRGB219_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_Release(This) (This)->lpVtbl -> Release(This)
#define IDVRGB219_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_SetRGB219(This,bState) (This)->lpVtbl -> SetRGB219(This,bState)
#define IDVRGB219_SetRGB219
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVSplitter_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVSplitter_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_Release(This) (This)->lpVtbl -> Release(This)
#define IDVSplitter_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_DiscardAlternateVideoFrames(This,nDiscard) (This)->lpVtbl -> DiscardAlternateVideoFrames(This,nDiscard)
#define IDVSplitter_DiscardAlternateVideoFrames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMAudioRendererStats_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMAudioRendererStats_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_Release(This) (This)->lpVtbl -> Release(This)
#define IAMAudioRendererStats_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_GetStatParam(This,dwParam,pdwParam1,pdwParam2) (This)->lpVtbl -> GetStatParam(This,dwParam,pdwParam1,pdwParam2)
#define IAMAudioRendererStats_GetStatParam
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMGraphStreams_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMGraphStreams_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_Release(This) (This)->lpVtbl -> Release(This)
#define IAMGraphStreams_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_FindUpstreamInterface(This,pPin,riid,ppvInterface,dwFlags) (This)->lpVtbl -> FindUpstreamInterface(This,pPin,riid,ppvInterface,dwFlags)
#define IAMGraphStreams_FindUpstreamInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_SyncUsingStreamOffset(This,bUseStreamOffset) (This)->lpVtbl -> SyncUsingStreamOffset(This,bUseStreamOffset)
#define IAMGraphStreams_SyncUsingStreamOffset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_SetMaxGraphLatency(This,rtMaxGraphLatency) (This)->lpVtbl -> SetMaxGraphLatency(This,rtMaxGraphLatency)
#define IAMGraphStreams_SetMaxGraphLatency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMOverlayFX_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMOverlayFX_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_Release(This) (This)->lpVtbl -> Release(This)
#define IAMOverlayFX_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_QueryOverlayFXCaps(This,lpdwOverlayFXCaps) (This)->lpVtbl -> QueryOverlayFXCaps(This,lpdwOverlayFXCaps)
#define IAMOverlayFX_QueryOverlayFXCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_SetOverlayFX(This,dwOverlayFX) (This)->lpVtbl -> SetOverlayFX(This,dwOverlayFX)
#define IAMOverlayFX_SetOverlayFX
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_GetOverlayFX(This,lpdwOverlayFX) (This)->lpVtbl -> GetOverlayFX(This,lpdwOverlayFX)
#define IAMOverlayFX_GetOverlayFX
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMOpenProgress_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMOpenProgress_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_Release(This) (This)->lpVtbl -> Release(This)
#define IAMOpenProgress_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_QueryProgress(This,pllTotal,pllCurrent) (This)->lpVtbl -> QueryProgress(This,pllTotal,pllCurrent)
#define IAMOpenProgress_QueryProgress
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_AbortOperation(This) (This)->lpVtbl -> AbortOperation(This)
#define IAMOpenProgress_AbortOperation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMpeg2Demultiplexer_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMpeg2Demultiplexer_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_Release(This) (This)->lpVtbl -> Release(This)
#define IMpeg2Demultiplexer_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_CreateOutputPin(This,pMediaType,pszPinName,ppIPin) (This)->lpVtbl -> CreateOutputPin(This,pMediaType,pszPinName,ppIPin)
#define IMpeg2Demultiplexer_CreateOutputPin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_SetOutputPinMediaType(This,pszPinName,pMediaType) (This)->lpVtbl -> SetOutputPinMediaType(This,pszPinName,pMediaType)
#define IMpeg2Demultiplexer_SetOutputPinMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_DeleteOutputPin(This,pszPinName) (This)->lpVtbl -> DeleteOutputPin(This,pszPinName)
#define IMpeg2Demultiplexer_DeleteOutputPin
#define MPEG2_PROGRAM_STREAM_MAP
#define MPEG2_PROGRAM_ELEMENTARY_STREAM
#define MPEG2_PROGRAM_DIRECTORY_PES_PACKET
#define MPEG2_PROGRAM_PACK_HEADER
#define MPEG2_PROGRAM_PES_STREAM
#define MPEG2_PROGRAM_SYSTEM_HEADER
#define SUBSTREAM_FILTER_VAL_NONE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumStreamIdMap_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumStreamIdMap_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumStreamIdMap_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Next(This,cRequest,pStreamIdMap,pcReceived) (This)->lpVtbl -> Next(This,cRequest,pStreamIdMap,pcReceived)
#define IEnumStreamIdMap_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Skip(This,cRecords) (This)->lpVtbl -> Skip(This,cRecords)
#define IEnumStreamIdMap_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumStreamIdMap_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Clone(This,ppIEnumStreamIdMap) (This)->lpVtbl -> Clone(This,ppIEnumStreamIdMap)
#define IEnumStreamIdMap_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMPEG2StreamIdMap_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMPEG2StreamIdMap_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_Release(This) (This)->lpVtbl -> Release(This)
#define IMPEG2StreamIdMap_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_MapStreamId(This,ulStreamId,MediaSampleContent,ulSubstreamFilterValue,iDataOffset) (This)->lpVtbl -> MapStreamId(This,ulStreamId,MediaSampleContent,ulSubstreamFilterValue,iDataOffset)
#define IMPEG2StreamIdMap_MapStreamId
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_UnmapStreamId(This,culStreamId,pulStreamId) (This)->lpVtbl -> UnmapStreamId(This,culStreamId,pulStreamId)
#define IMPEG2StreamIdMap_UnmapStreamId
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_EnumStreamIdMap(This,ppIEnumStreamIdMap) (This)->lpVtbl -> EnumStreamIdMap(This,ppIEnumStreamIdMap)
#define IMPEG2StreamIdMap_EnumStreamIdMap
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IRegisterServiceProvider_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IRegisterServiceProvider_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_Release(This) (This)->lpVtbl -> Release(This)
#define IRegisterServiceProvider_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_RegisterService(This,guidService,pUnkObject) (This)->lpVtbl -> RegisterService(This,guidService,pUnkObject)
#define IRegisterServiceProvider_RegisterService
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMClockSlave_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMClockSlave_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_Release(This) (This)->lpVtbl -> Release(This)
#define IAMClockSlave_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_SetErrorTolerance(This,dwTolerance) (This)->lpVtbl -> SetErrorTolerance(This,dwTolerance)
#define IAMClockSlave_SetErrorTolerance
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_GetErrorTolerance(This,pdwTolerance) (This)->lpVtbl -> GetErrorTolerance(This,pdwTolerance)
#define IAMClockSlave_GetErrorTolerance
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMGraphBuilderCallback_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMGraphBuilderCallback_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_Release(This) (This)->lpVtbl -> Release(This)
#define IAMGraphBuilderCallback_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_SelectedFilter(This,pMon) (This)->lpVtbl -> SelectedFilter(This,pMon)
#define IAMGraphBuilderCallback_SelectedFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_CreatedFilter(This,pFil) (This)->lpVtbl -> CreatedFilter(This,pFil)
#define IAMGraphBuilderCallback_CreatedFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ICodecAPI_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ICodecAPI_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_Release(This) (This)->lpVtbl -> Release(This)
#define ICodecAPI_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_IsSupported(This,Api) (This)->lpVtbl -> IsSupported(This,Api)
#define ICodecAPI_IsSupported
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_IsModifiable(This,Api) (This)->lpVtbl -> IsModifiable(This,Api)
#define ICodecAPI_IsModifiable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta) (This)->lpVtbl -> GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta)
#define ICodecAPI_GetParameterRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetParameterValues(This,Api,Values,ValuesCount) (This)->lpVtbl -> GetParameterValues(This,Api,Values,ValuesCount)
#define ICodecAPI_GetParameterValues
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetDefaultValue(This,Api,Value) (This)->lpVtbl -> GetDefaultValue(This,Api,Value)
#define ICodecAPI_GetDefaultValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetValue(This,Api,Value) (This)->lpVtbl -> GetValue(This,Api,Value)
#define ICodecAPI_GetValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetValue(This,Api,Value) (This)->lpVtbl -> SetValue(This,Api,Value)
#define ICodecAPI_SetValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_RegisterForEvent(This,Api,userData) (This)->lpVtbl -> RegisterForEvent(This,Api,userData)
#define ICodecAPI_RegisterForEvent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_UnregisterForEvent(This,Api) (This)->lpVtbl -> UnregisterForEvent(This,Api)
#define ICodecAPI_UnregisterForEvent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllDefaults(This) (This)->lpVtbl -> SetAllDefaults(This)
#define ICodecAPI_SetAllDefaults
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetValueWithNotify(This,Api,Value,ChangedParam,ChangedParamCount) (This)->lpVtbl -> SetValueWithNotify(This,Api,Value,ChangedParam,ChangedParamCount)
#define ICodecAPI_SetValueWithNotify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllDefaultsWithNotify(This,ChangedParam,ChangedParamCount) (This)->lpVtbl -> SetAllDefaultsWithNotify(This,ChangedParam,ChangedParamCount)
#define ICodecAPI_SetAllDefaultsWithNotify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetAllSettings(This,__MIDL_0016) (This)->lpVtbl -> GetAllSettings(This,__MIDL_0016)
#define ICodecAPI_GetAllSettings
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllSettings(This,__MIDL_0017) (This)->lpVtbl -> SetAllSettings(This,__MIDL_0017)
#define ICodecAPI_SetAllSettings
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllSettingsWithNotify(This,__MIDL_0018,ChangedParam,ChangedParamCount) (This)->lpVtbl -> SetAllSettingsWithNotify(This,__MIDL_0018,ChangedParam,ChangedParamCount)
#define ICodecAPI_SetAllSettingsWithNotify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IGetCapabilitiesKey_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IGetCapabilitiesKey_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_Release(This) (This)->lpVtbl -> Release(This)
#define IGetCapabilitiesKey_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_GetCapabilitiesKey(This,pHKey) (This)->lpVtbl -> GetCapabilitiesKey(This,pHKey)
#define IGetCapabilitiesKey_GetCapabilitiesKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEncoderAPI_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEncoderAPI_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_Release(This) (This)->lpVtbl -> Release(This)
#define IEncoderAPI_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_IsSupported(This,Api) (This)->lpVtbl -> IsSupported(This,Api)
#define IEncoderAPI_IsSupported
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_IsAvailable(This,Api) (This)->lpVtbl -> IsAvailable(This,Api)
#define IEncoderAPI_IsAvailable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta) (This)->lpVtbl -> GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta)
#define IEncoderAPI_GetParameterRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetParameterValues(This,Api,Values,ValuesCount) (This)->lpVtbl -> GetParameterValues(This,Api,Values,ValuesCount)
#define IEncoderAPI_GetParameterValues
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetDefaultValue(This,Api,Value) (This)->lpVtbl -> GetDefaultValue(This,Api,Value)
#define IEncoderAPI_GetDefaultValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetValue(This,Api,Value) (This)->lpVtbl -> GetValue(This,Api,Value)
#define IEncoderAPI_GetValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_SetValue(This,Api,Value) (This)->lpVtbl -> SetValue(This,Api,Value)
#define IEncoderAPI_SetValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVideoEncoder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVideoEncoder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_Release(This) (This)->lpVtbl -> Release(This)
#define IVideoEncoder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_IsSupported(This,Api) (This)->lpVtbl -> IsSupported(This,Api)
#define IVideoEncoder_IsSupported
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_IsAvailable(This,Api) (This)->lpVtbl -> IsAvailable(This,Api)
#define IVideoEncoder_IsAvailable
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta) (This)->lpVtbl -> GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta)
#define IVideoEncoder_GetParameterRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetParameterValues(This,Api,Values,ValuesCount) (This)->lpVtbl -> GetParameterValues(This,Api,Values,ValuesCount)
#define IVideoEncoder_GetParameterValues
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetDefaultValue(This,Api,Value) (This)->lpVtbl -> GetDefaultValue(This,Api,Value)
#define IVideoEncoder_GetDefaultValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetValue(This,Api,Value) (This)->lpVtbl -> GetValue(This,Api,Value)
#define IVideoEncoder_GetValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_SetValue(This,Api,Value) (This)->lpVtbl -> SetValue(This,Api,Value)
#define IVideoEncoder_SetValue
#define AM_GETDECODERCAP_QUERY_VMR_SUPPORT
#define VMR_NOTSUPPORTED
#define VMR_SUPPORTED
#define AM_QUERY_DECODER_VMR_SUPPORT
#define AM_QUERY_DECODER_DXVA_1_SUPPORT
#define AM_QUERY_DECODER_DVD_SUPPORT
#define AM_QUERY_DECODER_ATSC_SD_SUPPORT
#define AM_QUERY_DECODER_ATSC_HD_SUPPORT
#define AM_GETDECODERCAP_QUERY_VMR9_SUPPORT
#define DECODER_CAP_NOTSUPPORTED
#define DECODER_CAP_SUPPORTED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAMDecoderCaps_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAMDecoderCaps_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_Release(This) (This)->lpVtbl -> Release(This)
#define IAMDecoderCaps_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_GetDecoderCaps(This,dwCapIndex,lpdwCap) (This)->lpVtbl -> GetDecoderCaps(This,dwCapIndex,lpdwCap)
#define IAMDecoderCaps_GetDecoderCaps
#define ENABLE_NAMELESS_UNION_PRAGMA
#define DIRECTDRAW_VERSION
#define COM_NO_WINDOWS_H
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IUnknown void
#define IUnknown
        #define CO_E_NOTINITIALIZED
#define _FACDD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )
#define MAKE_DDHRESULT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n)
#define DUMMYUNIONNAMEN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n) u##n
#define DUMMYUNIONNAMEN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
    #define MAKEFOURCC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT1 (MAKEFOURCC('D','X','T','1'))
#define FOURCC_DXT1
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT2 (MAKEFOURCC('D','X','T','2'))
#define FOURCC_DXT2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT3 (MAKEFOURCC('D','X','T','3'))
#define FOURCC_DXT3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT4 (MAKEFOURCC('D','X','T','4'))
#define FOURCC_DXT4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT5 (MAKEFOURCC('D','X','T','5'))
#define FOURCC_DXT5
        #define HMONITOR_DECLARED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerate DirectDrawEnumerateW
        #define DirectDrawEnumerate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerateEx DirectDrawEnumerateExW
        #define DirectDrawEnumerateEx
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerate DirectDrawEnumerateA
        #define DirectDrawEnumerate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerateEx DirectDrawEnumerateExA
        #define DirectDrawEnumerateEx
#define DDENUM_ATTACHEDSECONDARYDEVICES
#define DDENUM_DETACHEDSECONDARYDEVICES
#define DDENUM_NONDISPLAYDEVICES
#define REGSTR_KEY_DDHW_DESCRIPTION
#define REGSTR_KEY_DDHW_DRIVERNAME
#define REGSTR_PATH_DDHW
#define DDCREATE_HARDWAREONLY
#define DDCREATE_EMULATIONONLY
#define DD_ROP_SPACE
#define MAX_DDDEVICEID_STRING
#define DDGDI_GETHOSTIDENTIFIER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_YEAR( dwWHQLLevel ) ( (dwWHQLLevel) / 0x10000 )
#define GET_WHQL_YEAR
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_MONTH( dwWHQLLevel ) ( ( (dwWHQLLevel) / 0x100 ) & 0x00ff )
#define GET_WHQL_MONTH
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_DAY( dwWHQLLevel ) ( (dwWHQLLevel) & 0xff )
#define GET_WHQL_DAY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDraw_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDraw_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDraw_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Compact(p) (p)->lpVtbl->Compact(p)
#define IDirectDraw_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
#define IDirectDraw_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
#define IDirectDraw_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
#define IDirectDraw_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
#define IDirectDraw_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
#define IDirectDraw_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
#define IDirectDraw_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
#define IDirectDraw_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
#define IDirectDraw_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
#define IDirectDraw_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
#define IDirectDraw_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
#define IDirectDraw_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
#define IDirectDraw_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
#define IDirectDraw_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
#define IDirectDraw_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
#define IDirectDraw_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
#define IDirectDraw_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
#define IDirectDraw_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetDisplayMode(p, a, b, c) (p)->lpVtbl->SetDisplayMode(p, a, b, c)
#define IDirectDraw_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
#define IDirectDraw_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDraw_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_AddRef(p) (p)->AddRef()
#define IDirectDraw_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Release(p) (p)->Release()
#define IDirectDraw_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Compact(p) (p)->Compact()
#define IDirectDraw_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
#define IDirectDraw_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
#define IDirectDraw_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
#define IDirectDraw_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
#define IDirectDraw_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
#define IDirectDraw_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
#define IDirectDraw_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_FlipToGDISurface(p) (p)->FlipToGDISurface()
#define IDirectDraw_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetCaps(p, a, b) (p)->GetCaps(a, b)
#define IDirectDraw_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
#define IDirectDraw_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
#define IDirectDraw_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetGDISurface(p, a) (p)->GetGDISurface(a)
#define IDirectDraw_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
#define IDirectDraw_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetScanLine(p, a) (p)->GetScanLine(a)
#define IDirectDraw_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
#define IDirectDraw_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Initialize(p, a) (p)->Initialize(a)
#define IDirectDraw_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
#define IDirectDraw_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
#define IDirectDraw_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetDisplayMode(p, a, b, c) (p)->SetDisplayMode(a, b, c)
#define IDirectDraw_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
#define IDirectDraw_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw2
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDraw2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDraw2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDraw2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Compact(p) (p)->lpVtbl->Compact(p)
#define IDirectDraw2_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
#define IDirectDraw2_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
#define IDirectDraw2_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
#define IDirectDraw2_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
#define IDirectDraw2_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
#define IDirectDraw2_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
#define IDirectDraw2_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
#define IDirectDraw2_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
#define IDirectDraw2_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
#define IDirectDraw2_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
#define IDirectDraw2_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
#define IDirectDraw2_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
#define IDirectDraw2_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
#define IDirectDraw2_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
#define IDirectDraw2_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
#define IDirectDraw2_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
#define IDirectDraw2_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
#define IDirectDraw2_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
#define IDirectDraw2_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
#define IDirectDraw2_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
#define IDirectDraw2_GetAvailableVidMem
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDraw2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_AddRef(p) (p)->AddRef()
#define IDirectDraw2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Release(p) (p)->Release()
#define IDirectDraw2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Compact(p) (p)->Compact()
#define IDirectDraw2_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
#define IDirectDraw2_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
#define IDirectDraw2_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
#define IDirectDraw2_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
#define IDirectDraw2_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
#define IDirectDraw2_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
#define IDirectDraw2_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_FlipToGDISurface(p) (p)->FlipToGDISurface()
#define IDirectDraw2_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetCaps(p, a, b) (p)->GetCaps(a, b)
#define IDirectDraw2_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
#define IDirectDraw2_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
#define IDirectDraw2_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetGDISurface(p, a) (p)->GetGDISurface(a)
#define IDirectDraw2_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
#define IDirectDraw2_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetScanLine(p, a) (p)->GetScanLine(a)
#define IDirectDraw2_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
#define IDirectDraw2_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Initialize(p, a) (p)->Initialize(a)
#define IDirectDraw2_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
#define IDirectDraw2_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
#define IDirectDraw2_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
#define IDirectDraw2_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
#define IDirectDraw2_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
#define IDirectDraw2_GetAvailableVidMem
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw4
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDraw4_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDraw4_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDraw4_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Compact(p) (p)->lpVtbl->Compact(p)
#define IDirectDraw4_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
#define IDirectDraw4_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
#define IDirectDraw4_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
#define IDirectDraw4_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
#define IDirectDraw4_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
#define IDirectDraw4_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
#define IDirectDraw4_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
#define IDirectDraw4_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
#define IDirectDraw4_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
#define IDirectDraw4_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
#define IDirectDraw4_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
#define IDirectDraw4_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
#define IDirectDraw4_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
#define IDirectDraw4_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
#define IDirectDraw4_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
#define IDirectDraw4_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
#define IDirectDraw4_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
#define IDirectDraw4_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
#define IDirectDraw4_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
#define IDirectDraw4_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
#define IDirectDraw4_GetAvailableVidMem
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetSurfaceFromDC(p, a, b) (p)->lpVtbl->GetSurfaceFromDC(p, a, b)
#define IDirectDraw4_GetSurfaceFromDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreAllSurfaces(p) (p)->lpVtbl->RestoreAllSurfaces(p)
#define IDirectDraw4_RestoreAllSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
#define IDirectDraw4_TestCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDeviceIdentifier(p,a,b) (p)->lpVtbl->GetDeviceIdentifier(p,a,b)
#define IDirectDraw4_GetDeviceIdentifier
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDraw4_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_AddRef(p) (p)->AddRef()
#define IDirectDraw4_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Release(p) (p)->Release()
#define IDirectDraw4_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Compact(p) (p)->Compact()
#define IDirectDraw4_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
#define IDirectDraw4_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
#define IDirectDraw4_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
#define IDirectDraw4_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
#define IDirectDraw4_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
#define IDirectDraw4_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
#define IDirectDraw4_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_FlipToGDISurface(p) (p)->FlipToGDISurface()
#define IDirectDraw4_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetCaps(p, a, b) (p)->GetCaps(a, b)
#define IDirectDraw4_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
#define IDirectDraw4_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
#define IDirectDraw4_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetGDISurface(p, a) (p)->GetGDISurface(a)
#define IDirectDraw4_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
#define IDirectDraw4_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetScanLine(p, a) (p)->GetScanLine(a)
#define IDirectDraw4_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
#define IDirectDraw4_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Initialize(p, a) (p)->Initialize(a)
#define IDirectDraw4_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
#define IDirectDraw4_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
#define IDirectDraw4_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
#define IDirectDraw4_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
#define IDirectDraw4_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
#define IDirectDraw4_GetAvailableVidMem
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetSurfaceFromDC(p, a, b) (p)->GetSurfaceFromDC(a, b)
#define IDirectDraw4_GetSurfaceFromDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreAllSurfaces(p) (p)->RestoreAllSurfaces()
#define IDirectDraw4_RestoreAllSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
#define IDirectDraw4_TestCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDeviceIdentifier(p,a,b) (p)->GetDeviceIdentifier(a,b)
#define IDirectDraw4_GetDeviceIdentifier
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw7
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDraw7_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDraw7_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDraw7_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Compact(p) (p)->lpVtbl->Compact(p)
#define IDirectDraw7_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
#define IDirectDraw7_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
#define IDirectDraw7_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
#define IDirectDraw7_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
#define IDirectDraw7_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
#define IDirectDraw7_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
#define IDirectDraw7_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
#define IDirectDraw7_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
#define IDirectDraw7_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
#define IDirectDraw7_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
#define IDirectDraw7_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
#define IDirectDraw7_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
#define IDirectDraw7_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
#define IDirectDraw7_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
#define IDirectDraw7_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
#define IDirectDraw7_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
#define IDirectDraw7_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
#define IDirectDraw7_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
#define IDirectDraw7_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
#define IDirectDraw7_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
#define IDirectDraw7_GetAvailableVidMem
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetSurfaceFromDC(p, a, b) (p)->lpVtbl->GetSurfaceFromDC(p, a, b)
#define IDirectDraw7_GetSurfaceFromDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreAllSurfaces(p) (p)->lpVtbl->RestoreAllSurfaces(p)
#define IDirectDraw7_RestoreAllSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
#define IDirectDraw7_TestCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDeviceIdentifier(p,a,b) (p)->lpVtbl->GetDeviceIdentifier(p,a,b)
#define IDirectDraw7_GetDeviceIdentifier
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_StartModeTest(p,a,b,c) (p)->lpVtbl->StartModeTest(p,a,b,c)
#define IDirectDraw7_StartModeTest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EvaluateMode(p,a,b) (p)->lpVtbl->EvaluateMode(p,a,b)
#define IDirectDraw7_EvaluateMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDraw7_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_AddRef(p) (p)->AddRef()
#define IDirectDraw7_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Release(p) (p)->Release()
#define IDirectDraw7_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Compact(p) (p)->Compact()
#define IDirectDraw7_Compact
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
#define IDirectDraw7_CreateClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
#define IDirectDraw7_CreatePalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
#define IDirectDraw7_CreateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
#define IDirectDraw7_DuplicateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
#define IDirectDraw7_EnumDisplayModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
#define IDirectDraw7_EnumSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_FlipToGDISurface(p) (p)->FlipToGDISurface()
#define IDirectDraw7_FlipToGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetCaps(p, a, b) (p)->GetCaps(a, b)
#define IDirectDraw7_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
#define IDirectDraw7_GetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
#define IDirectDraw7_GetFourCCCodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetGDISurface(p, a) (p)->GetGDISurface(a)
#define IDirectDraw7_GetGDISurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
#define IDirectDraw7_GetMonitorFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetScanLine(p, a) (p)->GetScanLine(a)
#define IDirectDraw7_GetScanLine
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
#define IDirectDraw7_GetVerticalBlankStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Initialize(p, a) (p)->Initialize(a)
#define IDirectDraw7_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
#define IDirectDraw7_RestoreDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
#define IDirectDraw7_SetCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
#define IDirectDraw7_SetDisplayMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
#define IDirectDraw7_WaitForVerticalBlank
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
#define IDirectDraw7_GetAvailableVidMem
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetSurfaceFromDC(p, a, b) (p)->GetSurfaceFromDC(a, b)
#define IDirectDraw7_GetSurfaceFromDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreAllSurfaces(p) (p)->RestoreAllSurfaces()
#define IDirectDraw7_RestoreAllSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
#define IDirectDraw7_TestCooperativeLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDeviceIdentifier(p,a,b) (p)->GetDeviceIdentifier(a,b)
#define IDirectDraw7_GetDeviceIdentifier
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_StartModeTest(p,a,b,c) (p)->lpVtbl->StartModeTest(a,b,c)
#define IDirectDraw7_StartModeTest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EvaluateMode(p,a,b) (p)->lpVtbl->EvaluateMode(a,b)
#define IDirectDraw7_EvaluateMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawPalette
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDrawPalette_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawPalette_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawPalette_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetCaps(p, a) (p)->lpVtbl->GetCaps(p, a)
#define IDirectDrawPalette_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetEntries(p, a, b, c, d) (p)->lpVtbl->GetEntries(p, a, b, c, d)
#define IDirectDrawPalette_GetEntries
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Initialize(p, a, b, c) (p)->lpVtbl->Initialize(p, a, b, c)
#define IDirectDrawPalette_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_SetEntries(p, a, b, c, d) (p)->lpVtbl->SetEntries(p, a, b, c, d)
#define IDirectDrawPalette_SetEntries
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDrawPalette_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_AddRef(p) (p)->AddRef()
#define IDirectDrawPalette_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Release(p) (p)->Release()
#define IDirectDrawPalette_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetCaps(p, a) (p)->GetCaps(a)
#define IDirectDrawPalette_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetEntries(p, a, b, c, d) (p)->GetEntries(a, b, c, d)
#define IDirectDrawPalette_GetEntries
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Initialize(p, a, b, c) (p)->Initialize(a, b, c)
#define IDirectDrawPalette_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_SetEntries(p, a, b, c, d) (p)->SetEntries(a, b, c, d)
#define IDirectDrawPalette_SetEntries
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawClipper
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDrawClipper_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawClipper_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawClipper_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetClipList(p, a, b, c) (p)->lpVtbl->GetClipList(p, a, b, c)
#define IDirectDrawClipper_GetClipList
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetHWnd(p, a) (p)->lpVtbl->GetHWnd(p, a)
#define IDirectDrawClipper_GetHWnd
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Initialize(p, a, b) (p)->lpVtbl->Initialize(p, a, b)
#define IDirectDrawClipper_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_IsClipListChanged(p, a) (p)->lpVtbl->IsClipListChanged(p, a)
#define IDirectDrawClipper_IsClipListChanged
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetClipList(p, a, b) (p)->lpVtbl->SetClipList(p, a, b)
#define IDirectDrawClipper_SetClipList
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetHWnd(p, a, b) (p)->lpVtbl->SetHWnd(p, a, b)
#define IDirectDrawClipper_SetHWnd
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDrawClipper_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_AddRef(p) (p)->AddRef()
#define IDirectDrawClipper_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Release(p) (p)->Release()
#define IDirectDrawClipper_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetClipList(p, a, b, c) (p)->GetClipList(a, b, c)
#define IDirectDrawClipper_GetClipList
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetHWnd(p, a) (p)->GetHWnd(a)
#define IDirectDrawClipper_GetHWnd
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Initialize(p, a, b) (p)->Initialize(a, b)
#define IDirectDrawClipper_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_IsClipListChanged(p, a) (p)->IsClipListChanged(a)
#define IDirectDrawClipper_IsClipListChanged
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetClipList(p, a, b) (p)->SetClipList(a, b)
#define IDirectDrawClipper_SetClipList
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetHWnd(p, a, b) (p)->SetHWnd(a, b)
#define IDirectDrawClipper_SetHWnd
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
#define IDirectDrawSurface_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawSurface_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawSurface_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
#define IDirectDrawSurface_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
#define IDirectDrawSurface_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
#define IDirectDrawSurface_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
#define IDirectDrawSurface_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
#define IDirectDrawSurface_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
#define IDirectDrawSurface_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
#define IDirectDrawSurface_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
#define IDirectDrawSurface_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
#define IDirectDrawSurface_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
#define IDirectDrawSurface_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
#define IDirectDrawSurface_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
#define IDirectDrawSurface_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
#define IDirectDrawSurface_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
#define IDirectDrawSurface_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
#define IDirectDrawSurface_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
#define IDirectDrawSurface_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
#define IDirectDrawSurface_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
#define IDirectDrawSurface_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
#define IDirectDrawSurface_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
#define IDirectDrawSurface_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
#define IDirectDrawSurface_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_IsLost(p) (p)->lpVtbl->IsLost(p)
#define IDirectDrawSurface_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
#define IDirectDrawSurface_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
#define IDirectDrawSurface_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Restore(p) (p)->lpVtbl->Restore(p)
#define IDirectDrawSurface_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
#define IDirectDrawSurface_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
#define IDirectDrawSurface_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
#define IDirectDrawSurface_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
#define IDirectDrawSurface_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
#define IDirectDrawSurface_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
#define IDirectDrawSurface_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
#define IDirectDrawSurface_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
#define IDirectDrawSurface_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
#define IDirectDrawSurface_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddRef(p) (p)->AddRef()
#define IDirectDrawSurface_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Release(p) (p)->Release()
#define IDirectDrawSurface_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
#define IDirectDrawSurface_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
#define IDirectDrawSurface_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
#define IDirectDrawSurface_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
#define IDirectDrawSurface_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
#define IDirectDrawSurface_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
#define IDirectDrawSurface_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
#define IDirectDrawSurface_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
#define IDirectDrawSurface_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Flip(p,a,b) (p)->Flip(a,b)
#define IDirectDrawSurface_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
#define IDirectDrawSurface_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetBltStatus(p,a) (p)->GetBltStatus(a)
#define IDirectDrawSurface_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetCaps(p,b) (p)->GetCaps(b)
#define IDirectDrawSurface_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetClipper(p,a) (p)->GetClipper(a)
#define IDirectDrawSurface_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
#define IDirectDrawSurface_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetDC(p,a) (p)->GetDC(a)
#define IDirectDrawSurface_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
#define IDirectDrawSurface_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
#define IDirectDrawSurface_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPalette(p,a) (p)->GetPalette(a)
#define IDirectDrawSurface_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
#define IDirectDrawSurface_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
#define IDirectDrawSurface_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Initialize(p,a,b) (p)->Initialize(a,b)
#define IDirectDrawSurface_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_IsLost(p) (p)->IsLost()
#define IDirectDrawSurface_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
#define IDirectDrawSurface_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_ReleaseDC(p,a) (p)->ReleaseDC(a)
#define IDirectDrawSurface_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Restore(p) (p)->Restore()
#define IDirectDrawSurface_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetClipper(p,a) (p)->SetClipper(a)
#define IDirectDrawSurface_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
#define IDirectDrawSurface_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
#define IDirectDrawSurface_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetPalette(p,a) (p)->SetPalette(a)
#define IDirectDrawSurface_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Unlock(p,b) (p)->Unlock(b)
#define IDirectDrawSurface_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
#define IDirectDrawSurface_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
#define IDirectDrawSurface_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
#define IDirectDrawSurface_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface2
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
#define IDirectDrawSurface2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawSurface2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawSurface2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
#define IDirectDrawSurface2_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
#define IDirectDrawSurface2_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
#define IDirectDrawSurface2_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
#define IDirectDrawSurface2_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
#define IDirectDrawSurface2_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
#define IDirectDrawSurface2_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
#define IDirectDrawSurface2_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
#define IDirectDrawSurface2_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
#define IDirectDrawSurface2_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
#define IDirectDrawSurface2_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
#define IDirectDrawSurface2_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
#define IDirectDrawSurface2_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
#define IDirectDrawSurface2_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
#define IDirectDrawSurface2_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
#define IDirectDrawSurface2_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
#define IDirectDrawSurface2_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
#define IDirectDrawSurface2_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
#define IDirectDrawSurface2_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
#define IDirectDrawSurface2_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
#define IDirectDrawSurface2_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
#define IDirectDrawSurface2_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_IsLost(p) (p)->lpVtbl->IsLost(p)
#define IDirectDrawSurface2_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
#define IDirectDrawSurface2_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
#define IDirectDrawSurface2_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Restore(p) (p)->lpVtbl->Restore(p)
#define IDirectDrawSurface2_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
#define IDirectDrawSurface2_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
#define IDirectDrawSurface2_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
#define IDirectDrawSurface2_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
#define IDirectDrawSurface2_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
#define IDirectDrawSurface2_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
#define IDirectDrawSurface2_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
#define IDirectDrawSurface2_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
#define IDirectDrawSurface2_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
#define IDirectDrawSurface2_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
#define IDirectDrawSurface2_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
#define IDirectDrawSurface2_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
#define IDirectDrawSurface2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddRef(p) (p)->AddRef()
#define IDirectDrawSurface2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Release(p) (p)->Release()
#define IDirectDrawSurface2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
#define IDirectDrawSurface2_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
#define IDirectDrawSurface2_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
#define IDirectDrawSurface2_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
#define IDirectDrawSurface2_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
#define IDirectDrawSurface2_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
#define IDirectDrawSurface2_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
#define IDirectDrawSurface2_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
#define IDirectDrawSurface2_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Flip(p,a,b) (p)->Flip(a,b)
#define IDirectDrawSurface2_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
#define IDirectDrawSurface2_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetBltStatus(p,a) (p)->GetBltStatus(a)
#define IDirectDrawSurface2_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetCaps(p,b) (p)->GetCaps(b)
#define IDirectDrawSurface2_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetClipper(p,a) (p)->GetClipper(a)
#define IDirectDrawSurface2_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
#define IDirectDrawSurface2_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDC(p,a) (p)->GetDC(a)
#define IDirectDrawSurface2_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
#define IDirectDrawSurface2_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
#define IDirectDrawSurface2_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPalette(p,a) (p)->GetPalette(a)
#define IDirectDrawSurface2_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
#define IDirectDrawSurface2_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
#define IDirectDrawSurface2_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Initialize(p,a,b) (p)->Initialize(a,b)
#define IDirectDrawSurface2_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_IsLost(p) (p)->IsLost()
#define IDirectDrawSurface2_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
#define IDirectDrawSurface2_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_ReleaseDC(p,a) (p)->ReleaseDC(a)
#define IDirectDrawSurface2_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Restore(p) (p)->Restore()
#define IDirectDrawSurface2_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetClipper(p,a) (p)->SetClipper(a)
#define IDirectDrawSurface2_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
#define IDirectDrawSurface2_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
#define IDirectDrawSurface2_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetPalette(p,a) (p)->SetPalette(a)
#define IDirectDrawSurface2_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Unlock(p,b) (p)->Unlock(b)
#define IDirectDrawSurface2_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
#define IDirectDrawSurface2_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
#define IDirectDrawSurface2_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
#define IDirectDrawSurface2_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDDInterface(p,a) (p)->GetDDInterface(a)
#define IDirectDrawSurface2_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageLock(p,a) (p)->PageLock(a)
#define IDirectDrawSurface2_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageUnlock(p,a) (p)->PageUnlock(a)
#define IDirectDrawSurface2_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface3
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
#define IDirectDrawSurface3_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawSurface3_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawSurface3_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
#define IDirectDrawSurface3_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
#define IDirectDrawSurface3_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
#define IDirectDrawSurface3_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
#define IDirectDrawSurface3_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
#define IDirectDrawSurface3_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
#define IDirectDrawSurface3_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
#define IDirectDrawSurface3_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
#define IDirectDrawSurface3_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
#define IDirectDrawSurface3_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
#define IDirectDrawSurface3_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
#define IDirectDrawSurface3_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
#define IDirectDrawSurface3_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
#define IDirectDrawSurface3_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
#define IDirectDrawSurface3_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
#define IDirectDrawSurface3_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
#define IDirectDrawSurface3_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
#define IDirectDrawSurface3_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
#define IDirectDrawSurface3_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
#define IDirectDrawSurface3_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
#define IDirectDrawSurface3_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
#define IDirectDrawSurface3_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_IsLost(p) (p)->lpVtbl->IsLost(p)
#define IDirectDrawSurface3_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
#define IDirectDrawSurface3_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
#define IDirectDrawSurface3_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Restore(p) (p)->lpVtbl->Restore(p)
#define IDirectDrawSurface3_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
#define IDirectDrawSurface3_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
#define IDirectDrawSurface3_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
#define IDirectDrawSurface3_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
#define IDirectDrawSurface3_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
#define IDirectDrawSurface3_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
#define IDirectDrawSurface3_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
#define IDirectDrawSurface3_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
#define IDirectDrawSurface3_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
#define IDirectDrawSurface3_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
#define IDirectDrawSurface3_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
#define IDirectDrawSurface3_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
#define IDirectDrawSurface3_SetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
#define IDirectDrawSurface3_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddRef(p) (p)->AddRef()
#define IDirectDrawSurface3_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Release(p) (p)->Release()
#define IDirectDrawSurface3_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
#define IDirectDrawSurface3_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
#define IDirectDrawSurface3_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
#define IDirectDrawSurface3_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
#define IDirectDrawSurface3_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
#define IDirectDrawSurface3_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
#define IDirectDrawSurface3_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
#define IDirectDrawSurface3_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
#define IDirectDrawSurface3_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Flip(p,a,b) (p)->Flip(a,b)
#define IDirectDrawSurface3_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
#define IDirectDrawSurface3_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetBltStatus(p,a) (p)->GetBltStatus(a)
#define IDirectDrawSurface3_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetCaps(p,b) (p)->GetCaps(b)
#define IDirectDrawSurface3_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetClipper(p,a) (p)->GetClipper(a)
#define IDirectDrawSurface3_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
#define IDirectDrawSurface3_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDC(p,a) (p)->GetDC(a)
#define IDirectDrawSurface3_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
#define IDirectDrawSurface3_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
#define IDirectDrawSurface3_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPalette(p,a) (p)->GetPalette(a)
#define IDirectDrawSurface3_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
#define IDirectDrawSurface3_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
#define IDirectDrawSurface3_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Initialize(p,a,b) (p)->Initialize(a,b)
#define IDirectDrawSurface3_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_IsLost(p) (p)->IsLost()
#define IDirectDrawSurface3_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
#define IDirectDrawSurface3_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_ReleaseDC(p,a) (p)->ReleaseDC(a)
#define IDirectDrawSurface3_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Restore(p) (p)->Restore()
#define IDirectDrawSurface3_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetClipper(p,a) (p)->SetClipper(a)
#define IDirectDrawSurface3_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
#define IDirectDrawSurface3_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
#define IDirectDrawSurface3_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetPalette(p,a) (p)->SetPalette(a)
#define IDirectDrawSurface3_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Unlock(p,b) (p)->Unlock(b)
#define IDirectDrawSurface3_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
#define IDirectDrawSurface3_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
#define IDirectDrawSurface3_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
#define IDirectDrawSurface3_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDDInterface(p,a) (p)->GetDDInterface(a)
#define IDirectDrawSurface3_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageLock(p,a) (p)->PageLock(a)
#define IDirectDrawSurface3_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageUnlock(p,a) (p)->PageUnlock(a)
#define IDirectDrawSurface3_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
#define IDirectDrawSurface3_SetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface4
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
#define IDirectDrawSurface4_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawSurface4_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawSurface4_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
#define IDirectDrawSurface4_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
#define IDirectDrawSurface4_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
#define IDirectDrawSurface4_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
#define IDirectDrawSurface4_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
#define IDirectDrawSurface4_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
#define IDirectDrawSurface4_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
#define IDirectDrawSurface4_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
#define IDirectDrawSurface4_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
#define IDirectDrawSurface4_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
#define IDirectDrawSurface4_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
#define IDirectDrawSurface4_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
#define IDirectDrawSurface4_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
#define IDirectDrawSurface4_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
#define IDirectDrawSurface4_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
#define IDirectDrawSurface4_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
#define IDirectDrawSurface4_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
#define IDirectDrawSurface4_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
#define IDirectDrawSurface4_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
#define IDirectDrawSurface4_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
#define IDirectDrawSurface4_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
#define IDirectDrawSurface4_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_IsLost(p) (p)->lpVtbl->IsLost(p)
#define IDirectDrawSurface4_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
#define IDirectDrawSurface4_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
#define IDirectDrawSurface4_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Restore(p) (p)->lpVtbl->Restore(p)
#define IDirectDrawSurface4_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
#define IDirectDrawSurface4_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
#define IDirectDrawSurface4_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
#define IDirectDrawSurface4_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
#define IDirectDrawSurface4_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
#define IDirectDrawSurface4_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
#define IDirectDrawSurface4_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
#define IDirectDrawSurface4_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
#define IDirectDrawSurface4_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
#define IDirectDrawSurface4_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
#define IDirectDrawSurface4_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
#define IDirectDrawSurface4_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
#define IDirectDrawSurface4_SetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
#define IDirectDrawSurface4_SetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
#define IDirectDrawSurface4_GetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
#define IDirectDrawSurface4_FreePrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetUniquenessValue(p, a) (p)->lpVtbl->GetUniquenessValue(p, a)
#define IDirectDrawSurface4_GetUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ChangeUniquenessValue(p) (p)->lpVtbl->ChangeUniquenessValue(p)
#define IDirectDrawSurface4_ChangeUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
#define IDirectDrawSurface4_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddRef(p) (p)->AddRef()
#define IDirectDrawSurface4_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Release(p) (p)->Release()
#define IDirectDrawSurface4_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
#define IDirectDrawSurface4_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
#define IDirectDrawSurface4_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
#define IDirectDrawSurface4_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
#define IDirectDrawSurface4_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
#define IDirectDrawSurface4_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
#define IDirectDrawSurface4_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
#define IDirectDrawSurface4_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
#define IDirectDrawSurface4_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Flip(p,a,b) (p)->Flip(a,b)
#define IDirectDrawSurface4_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
#define IDirectDrawSurface4_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetBltStatus(p,a) (p)->GetBltStatus(a)
#define IDirectDrawSurface4_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetCaps(p,b) (p)->GetCaps(b)
#define IDirectDrawSurface4_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetClipper(p,a) (p)->GetClipper(a)
#define IDirectDrawSurface4_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
#define IDirectDrawSurface4_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDC(p,a) (p)->GetDC(a)
#define IDirectDrawSurface4_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
#define IDirectDrawSurface4_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
#define IDirectDrawSurface4_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPalette(p,a) (p)->GetPalette(a)
#define IDirectDrawSurface4_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
#define IDirectDrawSurface4_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
#define IDirectDrawSurface4_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Initialize(p,a,b) (p)->Initialize(a,b)
#define IDirectDrawSurface4_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_IsLost(p) (p)->IsLost()
#define IDirectDrawSurface4_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
#define IDirectDrawSurface4_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ReleaseDC(p,a) (p)->ReleaseDC(a)
#define IDirectDrawSurface4_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Restore(p) (p)->Restore()
#define IDirectDrawSurface4_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetClipper(p,a) (p)->SetClipper(a)
#define IDirectDrawSurface4_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
#define IDirectDrawSurface4_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
#define IDirectDrawSurface4_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPalette(p,a) (p)->SetPalette(a)
#define IDirectDrawSurface4_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Unlock(p,b) (p)->Unlock(b)
#define IDirectDrawSurface4_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
#define IDirectDrawSurface4_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
#define IDirectDrawSurface4_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
#define IDirectDrawSurface4_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDDInterface(p,a) (p)->GetDDInterface(a)
#define IDirectDrawSurface4_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageLock(p,a) (p)->PageLock(a)
#define IDirectDrawSurface4_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageUnlock(p,a) (p)->PageUnlock(a)
#define IDirectDrawSurface4_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
#define IDirectDrawSurface4_SetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
#define IDirectDrawSurface4_SetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
#define IDirectDrawSurface4_GetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_FreePrivateData(p,a) (p)->FreePrivateData(a)
#define IDirectDrawSurface4_FreePrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetUniquenessValue(p, a) (p)->GetUniquenessValue(a)
#define IDirectDrawSurface4_GetUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ChangeUniquenessValue(p) (p)->ChangeUniquenessValue()
#define IDirectDrawSurface4_ChangeUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface7
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
#define IDirectDrawSurface7_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawSurface7_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawSurface7_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
#define IDirectDrawSurface7_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
#define IDirectDrawSurface7_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
#define IDirectDrawSurface7_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
#define IDirectDrawSurface7_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
#define IDirectDrawSurface7_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
#define IDirectDrawSurface7_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
#define IDirectDrawSurface7_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
#define IDirectDrawSurface7_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
#define IDirectDrawSurface7_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
#define IDirectDrawSurface7_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
#define IDirectDrawSurface7_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
#define IDirectDrawSurface7_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
#define IDirectDrawSurface7_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
#define IDirectDrawSurface7_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
#define IDirectDrawSurface7_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
#define IDirectDrawSurface7_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
#define IDirectDrawSurface7_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
#define IDirectDrawSurface7_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
#define IDirectDrawSurface7_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
#define IDirectDrawSurface7_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
#define IDirectDrawSurface7_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_IsLost(p) (p)->lpVtbl->IsLost(p)
#define IDirectDrawSurface7_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
#define IDirectDrawSurface7_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
#define IDirectDrawSurface7_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Restore(p) (p)->lpVtbl->Restore(p)
#define IDirectDrawSurface7_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
#define IDirectDrawSurface7_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
#define IDirectDrawSurface7_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
#define IDirectDrawSurface7_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
#define IDirectDrawSurface7_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
#define IDirectDrawSurface7_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
#define IDirectDrawSurface7_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
#define IDirectDrawSurface7_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
#define IDirectDrawSurface7_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
#define IDirectDrawSurface7_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
#define IDirectDrawSurface7_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
#define IDirectDrawSurface7_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
#define IDirectDrawSurface7_SetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
#define IDirectDrawSurface7_SetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
#define IDirectDrawSurface7_GetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
#define IDirectDrawSurface7_FreePrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetUniquenessValue(p, a) (p)->lpVtbl->GetUniquenessValue(p, a)
#define IDirectDrawSurface7_GetUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ChangeUniquenessValue(p) (p)->lpVtbl->ChangeUniquenessValue(p)
#define IDirectDrawSurface7_ChangeUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
#define IDirectDrawSurface7_SetPriority
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPriority(p,a) (p)->lpVtbl->GetPriority(p,a)
#define IDirectDrawSurface7_GetPriority
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
#define IDirectDrawSurface7_SetLOD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetLOD(p,a) (p)->lpVtbl->GetLOD(p,a)
#define IDirectDrawSurface7_GetLOD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
#define IDirectDrawSurface7_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddRef(p) (p)->AddRef()
#define IDirectDrawSurface7_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Release(p) (p)->Release()
#define IDirectDrawSurface7_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
#define IDirectDrawSurface7_AddAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
#define IDirectDrawSurface7_AddOverlayDirtyRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
#define IDirectDrawSurface7_Blt
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
#define IDirectDrawSurface7_BltBatch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
#define IDirectDrawSurface7_BltFast
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
#define IDirectDrawSurface7_DeleteAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
#define IDirectDrawSurface7_EnumAttachedSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
#define IDirectDrawSurface7_EnumOverlayZOrders
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Flip(p,a,b) (p)->Flip(a,b)
#define IDirectDrawSurface7_Flip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
#define IDirectDrawSurface7_GetAttachedSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetBltStatus(p,a) (p)->GetBltStatus(a)
#define IDirectDrawSurface7_GetBltStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetCaps(p,b) (p)->GetCaps(b)
#define IDirectDrawSurface7_GetCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetClipper(p,a) (p)->GetClipper(a)
#define IDirectDrawSurface7_GetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
#define IDirectDrawSurface7_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDC(p,a) (p)->GetDC(a)
#define IDirectDrawSurface7_GetDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
#define IDirectDrawSurface7_GetFlipStatus
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
#define IDirectDrawSurface7_GetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPalette(p,a) (p)->GetPalette(a)
#define IDirectDrawSurface7_GetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
#define IDirectDrawSurface7_GetPixelFormat
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
#define IDirectDrawSurface7_GetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Initialize(p,a,b) (p)->Initialize(a,b)
#define IDirectDrawSurface7_Initialize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_IsLost(p) (p)->IsLost()
#define IDirectDrawSurface7_IsLost
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
#define IDirectDrawSurface7_Lock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ReleaseDC(p,a) (p)->ReleaseDC(a)
#define IDirectDrawSurface7_ReleaseDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Restore(p) (p)->Restore()
#define IDirectDrawSurface7_Restore
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetClipper(p,a) (p)->SetClipper(a)
#define IDirectDrawSurface7_SetClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
#define IDirectDrawSurface7_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
#define IDirectDrawSurface7_SetOverlayPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPalette(p,a) (p)->SetPalette(a)
#define IDirectDrawSurface7_SetPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Unlock(p,b) (p)->Unlock(b)
#define IDirectDrawSurface7_Unlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
#define IDirectDrawSurface7_UpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
#define IDirectDrawSurface7_UpdateOverlayDisplay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
#define IDirectDrawSurface7_UpdateOverlayZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDDInterface(p,a) (p)->GetDDInterface(a)
#define IDirectDrawSurface7_GetDDInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageLock(p,a) (p)->PageLock(a)
#define IDirectDrawSurface7_PageLock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageUnlock(p,a) (p)->PageUnlock(a)
#define IDirectDrawSurface7_PageUnlock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
#define IDirectDrawSurface7_SetSurfaceDesc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
#define IDirectDrawSurface7_SetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
#define IDirectDrawSurface7_GetPrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_FreePrivateData(p,a) (p)->FreePrivateData(a)
#define IDirectDrawSurface7_FreePrivateData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetUniquenessValue(p, a) (p)->GetUniquenessValue(a)
#define IDirectDrawSurface7_GetUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ChangeUniquenessValue(p) (p)->ChangeUniquenessValue()
#define IDirectDrawSurface7_ChangeUniquenessValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPriority(p,a) (p)->SetPriority(a)
#define IDirectDrawSurface7_SetPriority
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPriority(p,a) (p)->GetPriority(a)
#define IDirectDrawSurface7_GetPriority
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetLOD(p,a) (p)->SetLOD(a)
#define IDirectDrawSurface7_SetLOD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetLOD(p,a) (p)->GetLOD(a)
#define IDirectDrawSurface7_GetLOD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawColorControl
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDrawColorControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawColorControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawColorControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_GetColorControls(p, a) (p)->lpVtbl->GetColorControls(p, a)
#define IDirectDrawColorControl_GetColorControls
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_SetColorControls(p, a) (p)->lpVtbl->SetColorControls(p, a)
#define IDirectDrawColorControl_SetColorControls
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDrawColorControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_AddRef(p) (p)->AddRef()
#define IDirectDrawColorControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_Release(p) (p)->Release()
#define IDirectDrawColorControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_GetColorControls(p, a) (p)->GetColorControls(a)
#define IDirectDrawColorControl_GetColorControls
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_SetColorControls(p, a) (p)->SetColorControls(a)
#define IDirectDrawColorControl_SetColorControls
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawGammaControl
#define INTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
#define IDirectDrawGammaControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_AddRef(p) (p)->lpVtbl->AddRef(p)
#define IDirectDrawGammaControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_Release(p) (p)->lpVtbl->Release(p)
#define IDirectDrawGammaControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_GetGammaRamp(p, a, b) (p)->lpVtbl->GetGammaRamp(p, a, b)
#define IDirectDrawGammaControl_GetGammaRamp
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_SetGammaRamp(p, a, b) (p)->lpVtbl->SetGammaRamp(p, a, b)
#define IDirectDrawGammaControl_SetGammaRamp
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
#define IDirectDrawGammaControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_AddRef(p) (p)->AddRef()
#define IDirectDrawGammaControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_Release(p) (p)->Release()
#define IDirectDrawGammaControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_GetGammaRamp(p, a, b) (p)->GetGammaRamp(a, b)
#define IDirectDrawGammaControl_GetGammaRamp
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_SetGammaRamp(p, a, b) (p)->SetGammaRamp(a, b)
#define IDirectDrawGammaControl_SetGammaRamp
#define DDSD_CAPS
#define DDSD_HEIGHT
#define DDSD_WIDTH
#define DDSD_PITCH
#define DDSD_BACKBUFFERCOUNT
#define DDSD_ZBUFFERBITDEPTH
#define DDSD_ALPHABITDEPTH
#define DDSD_LPSURFACE
#define DDSD_PIXELFORMAT
#define DDSD_CKDESTOVERLAY
#define DDSD_CKDESTBLT
#define DDSD_CKSRCOVERLAY
#define DDSD_CKSRCBLT
#define DDSD_MIPMAPCOUNT
#define DDSD_REFRESHRATE
#define DDSD_LINEARSIZE
#define DDSD_TEXTURESTAGE
#define DDSD_FVF
#define DDSD_SRCVBHANDLE
#define DDSD_DEPTH
#define DDSD_ALL
#define DDOSD_GUID
#define DDOSD_COMPRESSION_RATIO
#define DDOSD_SCAPS
#define DDOSD_OSCAPS
#define DDOSD_ALL
#define DDOSDCAPS_OPTCOMPRESSED
#define DDOSDCAPS_OPTREORDERED
#define DDOSDCAPS_MONOLITHICMIPMAP
#define DDOSDCAPS_VALIDSCAPS
#define DDOSDCAPS_VALIDOSCAPS
#define DDCOLOR_BRIGHTNESS
#define DDCOLOR_CONTRAST
#define DDCOLOR_HUE
#define DDCOLOR_SATURATION
#define DDCOLOR_SHARPNESS
#define DDCOLOR_GAMMA
#define DDCOLOR_COLORENABLE
#define DDSCAPS_RESERVED1
#define DDSCAPS_ALPHA
#define DDSCAPS_BACKBUFFER
#define DDSCAPS_COMPLEX
#define DDSCAPS_FLIP
#define DDSCAPS_FRONTBUFFER
#define DDSCAPS_OFFSCREENPLAIN
#define DDSCAPS_OVERLAY
#define DDSCAPS_PALETTE
#define DDSCAPS_PRIMARYSURFACE
#define DDSCAPS_RESERVED3
#define DDSCAPS_PRIMARYSURFACELEFT
#define DDSCAPS_SYSTEMMEMORY
#define DDSCAPS_TEXTURE
#define DDSCAPS_3DDEVICE
#define DDSCAPS_VIDEOMEMORY
#define DDSCAPS_VISIBLE
#define DDSCAPS_WRITEONLY
#define DDSCAPS_ZBUFFER
#define DDSCAPS_OWNDC
#define DDSCAPS_LIVEVIDEO
#define DDSCAPS_HWCODEC
#define DDSCAPS_MODEX
#define DDSCAPS_MIPMAP
#define DDSCAPS_RESERVED2
#define DDSCAPS_ALLOCONLOAD
#define DDSCAPS_VIDEOPORT
#define DDSCAPS_LOCALVIDMEM
#define DDSCAPS_NONLOCALVIDMEM
#define DDSCAPS_STANDARDVGAMODE
#define DDSCAPS_OPTIMIZED
#define DDSCAPS2_RESERVED4
#define DDSCAPS2_HARDWAREDEINTERLACE
#define DDSCAPS2_HINTDYNAMIC
#define DDSCAPS2_HINTSTATIC
#define DDSCAPS2_TEXTUREMANAGE
#define DDSCAPS2_RESERVED1
#define DDSCAPS2_RESERVED2
#define DDSCAPS2_OPAQUE
#define DDSCAPS2_HINTANTIALIASING
#define DDSCAPS2_CUBEMAP
#define DDSCAPS2_CUBEMAP_POSITIVEX
#define DDSCAPS2_CUBEMAP_NEGATIVEX
#define DDSCAPS2_CUBEMAP_POSITIVEY
#define DDSCAPS2_CUBEMAP_NEGATIVEY
#define DDSCAPS2_CUBEMAP_POSITIVEZ
#define DDSCAPS2_CUBEMAP_NEGATIVEZ
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDSCAPS2_CUBEMAP_ALLFACES ( DDSCAPS2_CUBEMAP_POSITIVEX | DDSCAPS2_CUBEMAP_NEGATIVEX | DDSCAPS2_CUBEMAP_POSITIVEY | DDSCAPS2_CUBEMAP_NEGATIVEY | DDSCAPS2_CUBEMAP_POSITIVEZ | DDSCAPS2_CUBEMAP_NEGATIVEZ )
#define DDSCAPS2_CUBEMAP_ALLFACES
#define DDSCAPS2_MIPMAPSUBLEVEL
#define DDSCAPS2_D3DTEXTUREMANAGE
#define DDSCAPS2_DONOTPERSIST
#define DDSCAPS2_STEREOSURFACELEFT
#define DDSCAPS2_VOLUME
#define DDSCAPS2_NOTUSERLOCKABLE
#define DDSCAPS2_POINTS
#define DDSCAPS2_RTPATCHES
#define DDSCAPS2_NPATCHES
#define DDSCAPS2_RESERVED3
#define DDSCAPS2_DISCARDBACKBUFFER
#define DDSCAPS2_ENABLEALPHACHANNEL
#define DDSCAPS2_EXTENDEDFORMATPRIMARY
#define DDSCAPS2_ADDITIONALPRIMARY
#define DDSCAPS3_MULTISAMPLE_MASK
#define DDSCAPS3_MULTISAMPLE_QUALITY_MASK
#define DDSCAPS3_MULTISAMPLE_QUALITY_SHIFT
#define DDSCAPS3_RESERVED1
#define DDSCAPS3_RESERVED2
#define DDSCAPS3_LIGHTWEIGHTMIPMAP
#define DDSCAPS3_AUTOGENMIPMAP
#define DDSCAPS3_DMAP
#define DDCAPS_3D
#define DDCAPS_ALIGNBOUNDARYDEST
#define DDCAPS_ALIGNSIZEDEST
#define DDCAPS_ALIGNBOUNDARYSRC
#define DDCAPS_ALIGNSIZESRC
#define DDCAPS_ALIGNSTRIDE
#define DDCAPS_BLT
#define DDCAPS_BLTQUEUE
#define DDCAPS_BLTFOURCC
#define DDCAPS_BLTSTRETCH
#define DDCAPS_GDI
#define DDCAPS_OVERLAY
#define DDCAPS_OVERLAYCANTCLIP
#define DDCAPS_OVERLAYFOURCC
#define DDCAPS_OVERLAYSTRETCH
#define DDCAPS_PALETTE
#define DDCAPS_PALETTEVSYNC
#define DDCAPS_READSCANLINE
#define DDCAPS_RESERVED1
#define DDCAPS_VBI
#define DDCAPS_ZBLTS
#define DDCAPS_ZOVERLAYS
#define DDCAPS_COLORKEY
#define DDCAPS_ALPHA
#define DDCAPS_COLORKEYHWASSIST
#define DDCAPS_NOHARDWARE
#define DDCAPS_BLTCOLORFILL
#define DDCAPS_BANKSWITCHED
#define DDCAPS_BLTDEPTHFILL
#define DDCAPS_CANCLIP
#define DDCAPS_CANCLIPSTRETCHED
#define DDCAPS_CANBLTSYSMEM
#define DDCAPS2_CERTIFIED
#define DDCAPS2_NO2DDURING3DSCENE
#define DDCAPS2_VIDEOPORT
#define DDCAPS2_AUTOFLIPOVERLAY
#define DDCAPS2_CANBOBINTERLEAVED
#define DDCAPS2_CANBOBNONINTERLEAVED
#define DDCAPS2_COLORCONTROLOVERLAY
#define DDCAPS2_COLORCONTROLPRIMARY
#define DDCAPS2_CANDROPZ16BIT
#define DDCAPS2_NONLOCALVIDMEM
#define DDCAPS2_NONLOCALVIDMEMCAPS
#define DDCAPS2_NOPAGELOCKREQUIRED
#define DDCAPS2_WIDESURFACES
#define DDCAPS2_CANFLIPODDEVEN
#define DDCAPS2_CANBOBHARDWARE
#define DDCAPS2_COPYFOURCC
#define DDCAPS2_PRIMARYGAMMA
#define DDCAPS2_CANRENDERWINDOWED
#define DDCAPS2_CANCALIBRATEGAMMA
#define DDCAPS2_FLIPINTERVAL
#define DDCAPS2_FLIPNOVSYNC
#define DDCAPS2_CANMANAGETEXTURE
#define DDCAPS2_TEXMANINNONLOCALVIDMEM
#define DDCAPS2_STEREO
#define DDCAPS2_SYSTONONLOCAL_AS_SYSTOLOCAL
#define DDCAPS2_RESERVED1
#define DDCAPS2_CANMANAGERESOURCE
#define DDCAPS2_DYNAMICTEXTURES
#define DDCAPS2_CANAUTOGENMIPMAP
#define DDFXALPHACAPS_BLTALPHAEDGEBLEND
#define DDFXALPHACAPS_BLTALPHAPIXELS
#define DDFXALPHACAPS_BLTALPHAPIXELSNEG
#define DDFXALPHACAPS_BLTALPHASURFACES
#define DDFXALPHACAPS_BLTALPHASURFACESNEG
#define DDFXALPHACAPS_OVERLAYALPHAEDGEBLEND
#define DDFXALPHACAPS_OVERLAYALPHAPIXELS
#define DDFXALPHACAPS_OVERLAYALPHAPIXELSNEG
#define DDFXALPHACAPS_OVERLAYALPHASURFACES
#define DDFXALPHACAPS_OVERLAYALPHASURFACESNEG
#define DDFXCAPS_BLTARITHSTRETCHY
#define DDFXCAPS_BLTARITHSTRETCHYN
#define DDFXCAPS_BLTMIRRORLEFTRIGHT
#define DDFXCAPS_BLTMIRRORUPDOWN
#define DDFXCAPS_BLTROTATION
#define DDFXCAPS_BLTROTATION90
#define DDFXCAPS_BLTSHRINKX
#define DDFXCAPS_BLTSHRINKXN
#define DDFXCAPS_BLTSHRINKY
#define DDFXCAPS_BLTSHRINKYN
#define DDFXCAPS_BLTSTRETCHX
#define DDFXCAPS_BLTSTRETCHXN
#define DDFXCAPS_BLTSTRETCHY
#define DDFXCAPS_BLTSTRETCHYN
#define DDFXCAPS_OVERLAYARITHSTRETCHY
#define DDFXCAPS_OVERLAYARITHSTRETCHYN
#define DDFXCAPS_OVERLAYSHRINKX
#define DDFXCAPS_OVERLAYSHRINKXN
#define DDFXCAPS_OVERLAYSHRINKY
#define DDFXCAPS_OVERLAYSHRINKYN
#define DDFXCAPS_OVERLAYSTRETCHX
#define DDFXCAPS_OVERLAYSTRETCHXN
#define DDFXCAPS_OVERLAYSTRETCHY
#define DDFXCAPS_OVERLAYSTRETCHYN
#define DDFXCAPS_OVERLAYMIRRORLEFTRIGHT
#define DDFXCAPS_OVERLAYMIRRORUPDOWN
#define DDFXCAPS_OVERLAYDEINTERLACE
#define DDFXCAPS_BLTALPHA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_BLTFILTER DDFXCAPS_BLTARITHSTRETCHY
#define DDFXCAPS_BLTFILTER
#define DDFXCAPS_OVERLAYALPHA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_OVERLAYFILTER DDFXCAPS_OVERLAYARITHSTRETCHY
#define DDFXCAPS_OVERLAYFILTER
#define DDSVCAPS_RESERVED1
#define DDSVCAPS_RESERVED2
#define DDSVCAPS_RESERVED3
#define DDSVCAPS_RESERVED4
#define DDSVCAPS_STEREOSEQUENTIAL
#define DDPCAPS_4BIT
#define DDPCAPS_8BITENTRIES
#define DDPCAPS_8BIT
#define DDPCAPS_INITIALIZE
#define DDPCAPS_PRIMARYSURFACE
#define DDPCAPS_PRIMARYSURFACELEFT
#define DDPCAPS_ALLOW256
#define DDPCAPS_VSYNC
#define DDPCAPS_1BIT
#define DDPCAPS_2BIT
#define DDPCAPS_ALPHA
#define DDSPD_IUNKNOWNPOINTER
#define DDSPD_VOLATILE
#define DDBD_1
#define DDBD_2
#define DDBD_4
#define DDBD_8
#define DDBD_16
#define DDBD_24
#define DDBD_32
#define DDCKEY_COLORSPACE
#define DDCKEY_DESTBLT
#define DDCKEY_DESTOVERLAY
#define DDCKEY_SRCBLT
#define DDCKEY_SRCOVERLAY
#define DDCKEYCAPS_DESTBLT
#define DDCKEYCAPS_DESTBLTCLRSPACE
#define DDCKEYCAPS_DESTBLTCLRSPACEYUV
#define DDCKEYCAPS_DESTBLTYUV
#define DDCKEYCAPS_DESTOVERLAY
#define DDCKEYCAPS_DESTOVERLAYCLRSPACE
#define DDCKEYCAPS_DESTOVERLAYCLRSPACEYUV
#define DDCKEYCAPS_DESTOVERLAYONEACTIVE
#define DDCKEYCAPS_DESTOVERLAYYUV
#define DDCKEYCAPS_SRCBLT
#define DDCKEYCAPS_SRCBLTCLRSPACE
#define DDCKEYCAPS_SRCBLTCLRSPACEYUV
#define DDCKEYCAPS_SRCBLTYUV
#define DDCKEYCAPS_SRCOVERLAY
#define DDCKEYCAPS_SRCOVERLAYCLRSPACE
#define DDCKEYCAPS_SRCOVERLAYCLRSPACEYUV
#define DDCKEYCAPS_SRCOVERLAYONEACTIVE
#define DDCKEYCAPS_SRCOVERLAYYUV
#define DDCKEYCAPS_NOCOSTOVERLAY
#define DDPF_ALPHAPIXELS
#define DDPF_ALPHA
#define DDPF_FOURCC
#define DDPF_PALETTEINDEXED4
#define DDPF_PALETTEINDEXEDTO8
#define DDPF_PALETTEINDEXED8
#define DDPF_RGB
#define DDPF_COMPRESSED
#define DDPF_RGBTOYUV
#define DDPF_YUV
#define DDPF_ZBUFFER
#define DDPF_PALETTEINDEXED1
#define DDPF_PALETTEINDEXED2
#define DDPF_ZPIXELS
#define DDPF_STENCILBUFFER
#define DDPF_ALPHAPREMULT
#define DDPF_LUMINANCE
#define DDPF_BUMPLUMINANCE
#define DDPF_BUMPDUDV
#define DDENUMSURFACES_ALL
#define DDENUMSURFACES_MATCH
#define DDENUMSURFACES_NOMATCH
#define DDENUMSURFACES_CANBECREATED
#define DDENUMSURFACES_DOESEXIST
#define DDSDM_STANDARDVGAMODE
#define DDEDM_REFRESHRATES
#define DDEDM_STANDARDVGAMODES
#define DDSCL_FULLSCREEN
#define DDSCL_ALLOWREBOOT
#define DDSCL_NOWINDOWCHANGES
#define DDSCL_NORMAL
#define DDSCL_EXCLUSIVE
#define DDSCL_ALLOWMODEX
#define DDSCL_SETFOCUSWINDOW
#define DDSCL_SETDEVICEWINDOW
#define DDSCL_CREATEDEVICEWINDOW
#define DDSCL_MULTITHREADED
#define DDSCL_FPUSETUP
#define DDSCL_FPUPRESERVE
#define DDBLT_ALPHADEST
#define DDBLT_ALPHADESTCONSTOVERRIDE
#define DDBLT_ALPHADESTNEG
#define DDBLT_ALPHADESTSURFACEOVERRIDE
#define DDBLT_ALPHAEDGEBLEND
#define DDBLT_ALPHASRC
#define DDBLT_ALPHASRCCONSTOVERRIDE
#define DDBLT_ALPHASRCNEG
#define DDBLT_ALPHASRCSURFACEOVERRIDE
#define DDBLT_ASYNC
#define DDBLT_COLORFILL
#define DDBLT_DDFX
#define DDBLT_DDROPS
#define DDBLT_KEYDEST
#define DDBLT_KEYDESTOVERRIDE
#define DDBLT_KEYSRC
#define DDBLT_KEYSRCOVERRIDE
#define DDBLT_ROP
#define DDBLT_ROTATIONANGLE
#define DDBLT_ZBUFFER
#define DDBLT_ZBUFFERDESTCONSTOVERRIDE
#define DDBLT_ZBUFFERDESTOVERRIDE
#define DDBLT_ZBUFFERSRCCONSTOVERRIDE
#define DDBLT_ZBUFFERSRCOVERRIDE
#define DDBLT_WAIT
#define DDBLT_DEPTHFILL
#define DDBLT_DONOTWAIT
#define DDBLT_PRESENTATION
#define DDBLT_LAST_PRESENTATION
#define DDBLT_EXTENDED_FLAGS
#define DDBLT_EXTENDED_LINEAR_CONTENT
#define DDBLTFAST_NOCOLORKEY
#define DDBLTFAST_SRCCOLORKEY
#define DDBLTFAST_DESTCOLORKEY
#define DDBLTFAST_WAIT
#define DDBLTFAST_DONOTWAIT
#define DDFLIP_WAIT
#define DDFLIP_EVEN
#define DDFLIP_ODD
#define DDFLIP_NOVSYNC
#define DDFLIP_INTERVAL2
#define DDFLIP_INTERVAL3
#define DDFLIP_INTERVAL4
#define DDFLIP_STEREO
#define DDFLIP_DONOTWAIT
#define DDOVER_ALPHADEST
#define DDOVER_ALPHADESTCONSTOVERRIDE
#define DDOVER_ALPHADESTNEG
#define DDOVER_ALPHADESTSURFACEOVERRIDE
#define DDOVER_ALPHAEDGEBLEND
#define DDOVER_ALPHASRC
#define DDOVER_ALPHASRCCONSTOVERRIDE
#define DDOVER_ALPHASRCNEG
#define DDOVER_ALPHASRCSURFACEOVERRIDE
#define DDOVER_HIDE
#define DDOVER_KEYDEST
#define DDOVER_KEYDESTOVERRIDE
#define DDOVER_KEYSRC
#define DDOVER_KEYSRCOVERRIDE
#define DDOVER_SHOW
#define DDOVER_ADDDIRTYRECT
#define DDOVER_REFRESHDIRTYRECTS
#define DDOVER_REFRESHALL
#define DDOVER_DDFX
#define DDOVER_AUTOFLIP
#define DDOVER_BOB
#define DDOVER_OVERRIDEBOBWEAVE
#define DDOVER_INTERLEAVED
#define DDOVER_BOBHARDWARE
#define DDOVER_ARGBSCALEFACTORS
#define DDOVER_DEGRADEARGBSCALING
#define DDLOCK_SURFACEMEMORYPTR
#define DDLOCK_WAIT
#define DDLOCK_EVENT
#define DDLOCK_READONLY
#define DDLOCK_WRITEONLY
#define DDLOCK_NOSYSLOCK
#define DDLOCK_NOOVERWRITE
#define DDLOCK_DISCARDCONTENTS
#define DDLOCK_OKTOSWAP
#define DDLOCK_DONOTWAIT
#define DDLOCK_HASVOLUMETEXTUREBOXRECT
#define DDLOCK_NODIRTYUPDATE
#define DDBLTFX_ARITHSTRETCHY
#define DDBLTFX_MIRRORLEFTRIGHT
#define DDBLTFX_MIRRORUPDOWN
#define DDBLTFX_NOTEARING
#define DDBLTFX_ROTATE180
#define DDBLTFX_ROTATE270
#define DDBLTFX_ROTATE90
#define DDBLTFX_ZBUFFERRANGE
#define DDBLTFX_ZBUFFERBASEDEST
#define DDOVERFX_ARITHSTRETCHY
#define DDOVERFX_MIRRORLEFTRIGHT
#define DDOVERFX_MIRRORUPDOWN
#define DDOVERFX_DEINTERLACE
#define DDWAITVB_BLOCKBEGIN
#define DDWAITVB_BLOCKBEGINEVENT
#define DDWAITVB_BLOCKEND
#define DDGFS_CANFLIP
#define DDGFS_ISFLIPDONE
#define DDGBS_CANBLT
#define DDGBS_ISBLTDONE
#define DDENUMOVERLAYZ_BACKTOFRONT
#define DDENUMOVERLAYZ_FRONTTOBACK
#define DDOVERZ_SENDTOFRONT
#define DDOVERZ_SENDTOBACK
#define DDOVERZ_MOVEFORWARD
#define DDOVERZ_MOVEBACKWARD
#define DDOVERZ_INSERTINFRONTOF
#define DDOVERZ_INSERTINBACKOF
#define DDSGR_CALIBRATE
#define DDSMT_ISTESTREQUIRED
#define DDEM_MODEPASSED
#define DDEM_MODEFAILED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_OK S_OK
#define DD_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_FALSE S_FALSE
#define DD_FALSE
#define DDENUMRET_CANCEL
#define DDENUMRET_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_ALREADYINITIALIZED MAKE_DDHRESULT( 5 )
#define DDERR_ALREADYINITIALIZED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTATTACHSURFACE MAKE_DDHRESULT( 10 )
#define DDERR_CANNOTATTACHSURFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTDETACHSURFACE MAKE_DDHRESULT( 20 )
#define DDERR_CANNOTDETACHSURFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CURRENTLYNOTAVAIL MAKE_DDHRESULT( 40 )
#define DDERR_CURRENTLYNOTAVAIL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCEPTION MAKE_DDHRESULT( 55 )
#define DDERR_EXCEPTION
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_GENERIC E_FAIL
#define DDERR_GENERIC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HEIGHTALIGN MAKE_DDHRESULT( 90 )
#define DDERR_HEIGHTALIGN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INCOMPATIBLEPRIMARY MAKE_DDHRESULT( 95 )
#define DDERR_INCOMPATIBLEPRIMARY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCAPS MAKE_DDHRESULT( 100 )
#define DDERR_INVALIDCAPS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCLIPLIST MAKE_DDHRESULT( 110 )
#define DDERR_INVALIDCLIPLIST
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDMODE MAKE_DDHRESULT( 120 )
#define DDERR_INVALIDMODE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDOBJECT MAKE_DDHRESULT( 130 )
#define DDERR_INVALIDOBJECT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPARAMS E_INVALIDARG
#define DDERR_INVALIDPARAMS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPIXELFORMAT MAKE_DDHRESULT( 145 )
#define DDERR_INVALIDPIXELFORMAT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDRECT MAKE_DDHRESULT( 150 )
#define DDERR_INVALIDRECT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_LOCKEDSURFACES MAKE_DDHRESULT( 160 )
#define DDERR_LOCKEDSURFACES
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NO3D MAKE_DDHRESULT( 170 )
#define DDERR_NO3D
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOALPHAHW MAKE_DDHRESULT( 180 )
#define DDERR_NOALPHAHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTEREOHARDWARE MAKE_DDHRESULT( 181 )
#define DDERR_NOSTEREOHARDWARE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSURFACELEFT MAKE_DDHRESULT( 182 )
#define DDERR_NOSURFACELEFT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPLIST MAKE_DDHRESULT( 205 )
#define DDERR_NOCLIPLIST
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORCONVHW MAKE_DDHRESULT( 210 )
#define DDERR_NOCOLORCONVHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOOPERATIVELEVELSET MAKE_DDHRESULT( 212 )
#define DDERR_NOCOOPERATIVELEVELSET
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEY MAKE_DDHRESULT( 215 )
#define DDERR_NOCOLORKEY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEYHW MAKE_DDHRESULT( 220 )
#define DDERR_NOCOLORKEYHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWSUPPORT MAKE_DDHRESULT( 222 )
#define DDERR_NODIRECTDRAWSUPPORT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEXCLUSIVEMODE MAKE_DDHRESULT( 225 )
#define DDERR_NOEXCLUSIVEMODE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFLIPHW MAKE_DDHRESULT( 230 )
#define DDERR_NOFLIPHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOGDI MAKE_DDHRESULT( 240 )
#define DDERR_NOGDI
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIRRORHW MAKE_DDHRESULT( 250 )
#define DDERR_NOMIRRORHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFOUND MAKE_DDHRESULT( 255 )
#define DDERR_NOTFOUND
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYHW MAKE_DDHRESULT( 260 )
#define DDERR_NOOVERLAYHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAPPINGRECTS MAKE_DDHRESULT( 270 )
#define DDERR_OVERLAPPINGRECTS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NORASTEROPHW MAKE_DDHRESULT( 280 )
#define DDERR_NORASTEROPHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOROTATIONHW MAKE_DDHRESULT( 290 )
#define DDERR_NOROTATIONHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTRETCHHW MAKE_DDHRESULT( 310 )
#define DDERR_NOSTRETCHHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLOR MAKE_DDHRESULT( 316 )
#define DDERR_NOT4BITCOLOR
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLORINDEX MAKE_DDHRESULT( 317 )
#define DDERR_NOT4BITCOLORINDEX
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT8BITCOLOR MAKE_DDHRESULT( 320 )
#define DDERR_NOT8BITCOLOR
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTEXTUREHW MAKE_DDHRESULT( 330 )
#define DDERR_NOTEXTUREHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOVSYNCHW MAKE_DDHRESULT( 335 )
#define DDERR_NOVSYNCHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZBUFFERHW MAKE_DDHRESULT( 340 )
#define DDERR_NOZBUFFERHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZOVERLAYHW MAKE_DDHRESULT( 350 )
#define DDERR_NOZOVERLAYHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFCAPS MAKE_DDHRESULT( 360 )
#define DDERR_OUTOFCAPS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFMEMORY E_OUTOFMEMORY
#define DDERR_OUTOFMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFVIDEOMEMORY MAKE_DDHRESULT( 380 )
#define DDERR_OUTOFVIDEOMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCANTCLIP MAKE_DDHRESULT( 382 )
#define DDERR_OVERLAYCANTCLIP
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCOLORKEYONLYONEACTIVE MAKE_DDHRESULT( 384 )
#define DDERR_OVERLAYCOLORKEYONLYONEACTIVE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PALETTEBUSY MAKE_DDHRESULT( 387 )
#define DDERR_PALETTEBUSY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_COLORKEYNOTSET MAKE_DDHRESULT( 400 )
#define DDERR_COLORKEYNOTSET
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYATTACHED MAKE_DDHRESULT( 410 )
#define DDERR_SURFACEALREADYATTACHED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYDEPENDENT MAKE_DDHRESULT( 420 )
#define DDERR_SURFACEALREADYDEPENDENT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEBUSY MAKE_DDHRESULT( 430 )
#define DDERR_SURFACEBUSY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTLOCKSURFACE MAKE_DDHRESULT( 435 )
#define DDERR_CANTLOCKSURFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEISOBSCURED MAKE_DDHRESULT( 440 )
#define DDERR_SURFACEISOBSCURED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACELOST MAKE_DDHRESULT( 450 )
#define DDERR_SURFACELOST
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACENOTATTACHED MAKE_DDHRESULT( 460 )
#define DDERR_SURFACENOTATTACHED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGHEIGHT MAKE_DDHRESULT( 470 )
#define DDERR_TOOBIGHEIGHT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGSIZE MAKE_DDHRESULT( 480 )
#define DDERR_TOOBIGSIZE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGWIDTH MAKE_DDHRESULT( 490 )
#define DDERR_TOOBIGWIDTH
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTED E_NOTIMPL
#define DDERR_UNSUPPORTED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDFORMAT MAKE_DDHRESULT( 510 )
#define DDERR_UNSUPPORTEDFORMAT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMASK MAKE_DDHRESULT( 520 )
#define DDERR_UNSUPPORTEDMASK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSTREAM MAKE_DDHRESULT( 521 )
#define DDERR_INVALIDSTREAM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VERTICALBLANKINPROGRESS MAKE_DDHRESULT( 537 )
#define DDERR_VERTICALBLANKINPROGRESS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WASSTILLDRAWING MAKE_DDHRESULT( 540 )
#define DDERR_WASSTILLDRAWING
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DDSCAPSCOMPLEXREQUIRED MAKE_DDHRESULT( 542 )
#define DDERR_DDSCAPSCOMPLEXREQUIRED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_XALIGN MAKE_DDHRESULT( 560 )
#define DDERR_XALIGN
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDDIRECTDRAWGUID MAKE_DDHRESULT( 561 )
#define DDERR_INVALIDDIRECTDRAWGUID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DIRECTDRAWALREADYCREATED MAKE_DDHRESULT( 562 )
#define DDERR_DIRECTDRAWALREADYCREATED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWHW MAKE_DDHRESULT( 563 )
#define DDERR_NODIRECTDRAWHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PRIMARYSURFACEALREADYEXISTS MAKE_DDHRESULT( 564 )
#define DDERR_PRIMARYSURFACEALREADYEXISTS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEMULATION MAKE_DDHRESULT( 565 )
#define DDERR_NOEMULATION
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_REGIONTOOSMALL MAKE_DDHRESULT( 566 )
#define DDERR_REGIONTOOSMALL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CLIPPERISUSINGHWND MAKE_DDHRESULT( 567 )
#define DDERR_CLIPPERISUSINGHWND
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPPERATTACHED MAKE_DDHRESULT( 568 )
#define DDERR_NOCLIPPERATTACHED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOHWND MAKE_DDHRESULT( 569 )
#define DDERR_NOHWND
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDSUBCLASSED MAKE_DDHRESULT( 570 )
#define DDERR_HWNDSUBCLASSED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDALREADYSET MAKE_DDHRESULT( 571 )
#define DDERR_HWNDALREADYSET
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEATTACHED MAKE_DDHRESULT( 572 )
#define DDERR_NOPALETTEATTACHED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEHW MAKE_DDHRESULT( 573 )
#define DDERR_NOPALETTEHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_BLTFASTCANTCLIP MAKE_DDHRESULT( 574 )
#define DDERR_BLTFASTCANTCLIP
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOBLTHW MAKE_DDHRESULT( 575 )
#define DDERR_NOBLTHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODDROPSHW MAKE_DDHRESULT( 576 )
#define DDERR_NODDROPSHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYNOTVISIBLE MAKE_DDHRESULT( 577 )
#define DDERR_OVERLAYNOTVISIBLE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYDEST MAKE_DDHRESULT( 578 )
#define DDERR_NOOVERLAYDEST
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPOSITION MAKE_DDHRESULT( 579 )
#define DDERR_INVALIDPOSITION
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTAOVERLAYSURFACE MAKE_DDHRESULT( 580 )
#define DDERR_NOTAOVERLAYSURFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCLUSIVEMODEALREADYSET MAKE_DDHRESULT( 581 )
#define DDERR_EXCLUSIVEMODEALREADYSET
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFLIPPABLE MAKE_DDHRESULT( 582 )
#define DDERR_NOTFLIPPABLE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTDUPLICATE MAKE_DDHRESULT( 583 )
#define DDERR_CANTDUPLICATE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOCKED MAKE_DDHRESULT( 584 )
#define DDERR_NOTLOCKED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTCREATEDC MAKE_DDHRESULT( 585 )
#define DDERR_CANTCREATEDC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODC MAKE_DDHRESULT( 586 )
#define DDERR_NODC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WRONGMODE MAKE_DDHRESULT( 587 )
#define DDERR_WRONGMODE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_IMPLICITLYCREATED MAKE_DDHRESULT( 588 )
#define DDERR_IMPLICITLYCREATED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPALETTIZED MAKE_DDHRESULT( 589 )
#define DDERR_NOTPALETTIZED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMODE MAKE_DDHRESULT( 590 )
#define DDERR_UNSUPPORTEDMODE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIPMAPHW MAKE_DDHRESULT( 591 )
#define DDERR_NOMIPMAPHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSURFACETYPE MAKE_DDHRESULT( 592 )
#define DDERR_INVALIDSURFACETYPE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOPTIMIZEHW MAKE_DDHRESULT( 600 )
#define DDERR_NOOPTIMIZEHW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOADED MAKE_DDHRESULT( 601 )
#define DDERR_NOTLOADED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFOCUSWINDOW MAKE_DDHRESULT( 602 )
#define DDERR_NOFOCUSWINDOW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTONMIPMAPSUBLEVEL MAKE_DDHRESULT( 603 )
#define DDERR_NOTONMIPMAPSUBLEVEL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DCALREADYCREATED MAKE_DDHRESULT( 620 )
#define DDERR_DCALREADYCREATED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NONONLOCALVIDMEM MAKE_DDHRESULT( 630 )
#define DDERR_NONONLOCALVIDMEM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGELOCK MAKE_DDHRESULT( 640 )
#define DDERR_CANTPAGELOCK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGEUNLOCK MAKE_DDHRESULT( 660 )
#define DDERR_CANTPAGEUNLOCK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPAGELOCKED MAKE_DDHRESULT( 680 )
#define DDERR_NOTPAGELOCKED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_MOREDATA MAKE_DDHRESULT( 690 )
#define DDERR_MOREDATA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXPIRED MAKE_DDHRESULT( 691 )
#define DDERR_EXPIRED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TESTFINISHED MAKE_DDHRESULT( 692 )
#define DDERR_TESTFINISHED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NEWMODE MAKE_DDHRESULT( 693 )
#define DDERR_NEWMODE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_D3DNOTINITIALIZED MAKE_DDHRESULT( 694 )
#define DDERR_D3DNOTINITIALIZED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VIDEONOTACTIVE MAKE_DDHRESULT( 695 )
#define DDERR_VIDEONOTACTIVE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMONITORINFORMATION MAKE_DDHRESULT( 696 )
#define DDERR_NOMONITORINFORMATION
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODRIVERSUPPORT MAKE_DDHRESULT( 697 )
#define DDERR_NODRIVERSUPPORT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DEVICEDOESNTOWNSURFACE MAKE_DDHRESULT( 699 )
#define DDERR_DEVICEDOESNTOWNSURFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTINITIALIZED CO_E_NOTINITIALIZED
#define DDERR_NOTINITIALIZED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TitlePlay(This,ulTitle) (This)->lpVtbl -> TitlePlay(This,ulTitle)
#define IDvdControl_TitlePlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ChapterPlay(This,ulTitle,ulChapter) (This)->lpVtbl -> ChapterPlay(This,ulTitle,ulChapter)
#define IDvdControl_ChapterPlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TimePlay(This,ulTitle,bcdTime) (This)->lpVtbl -> TimePlay(This,ulTitle,bcdTime)
#define IDvdControl_TimePlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_StopForResume(This) (This)->lpVtbl -> StopForResume(This)
#define IDvdControl_StopForResume
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_GoUp(This) (This)->lpVtbl -> GoUp(This)
#define IDvdControl_GoUp
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TimeSearch(This,bcdTime) (This)->lpVtbl -> TimeSearch(This,bcdTime)
#define IDvdControl_TimeSearch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ChapterSearch(This,ulChapter) (This)->lpVtbl -> ChapterSearch(This,ulChapter)
#define IDvdControl_ChapterSearch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_PrevPGSearch(This) (This)->lpVtbl -> PrevPGSearch(This)
#define IDvdControl_PrevPGSearch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TopPGSearch(This) (This)->lpVtbl -> TopPGSearch(This)
#define IDvdControl_TopPGSearch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_NextPGSearch(This) (This)->lpVtbl -> NextPGSearch(This)
#define IDvdControl_NextPGSearch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ForwardScan(This,dwSpeed) (This)->lpVtbl -> ForwardScan(This,dwSpeed)
#define IDvdControl_ForwardScan
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_BackwardScan(This,dwSpeed) (This)->lpVtbl -> BackwardScan(This,dwSpeed)
#define IDvdControl_BackwardScan
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MenuCall(This,MenuID) (This)->lpVtbl -> MenuCall(This,MenuID)
#define IDvdControl_MenuCall
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_Resume(This) (This)->lpVtbl -> Resume(This)
#define IDvdControl_Resume
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_UpperButtonSelect(This) (This)->lpVtbl -> UpperButtonSelect(This)
#define IDvdControl_UpperButtonSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_LowerButtonSelect(This) (This)->lpVtbl -> LowerButtonSelect(This)
#define IDvdControl_LowerButtonSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_LeftButtonSelect(This) (This)->lpVtbl -> LeftButtonSelect(This)
#define IDvdControl_LeftButtonSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_RightButtonSelect(This) (This)->lpVtbl -> RightButtonSelect(This)
#define IDvdControl_RightButtonSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ButtonActivate(This) (This)->lpVtbl -> ButtonActivate(This)
#define IDvdControl_ButtonActivate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ButtonSelectAndActivate(This,ulButton) (This)->lpVtbl -> ButtonSelectAndActivate(This,ulButton)
#define IDvdControl_ButtonSelectAndActivate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_StillOff(This) (This)->lpVtbl -> StillOff(This)
#define IDvdControl_StillOff
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_PauseOn(This) (This)->lpVtbl -> PauseOn(This)
#define IDvdControl_PauseOn
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_PauseOff(This) (This)->lpVtbl -> PauseOff(This)
#define IDvdControl_PauseOff
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MenuLanguageSelect(This,Language) (This)->lpVtbl -> MenuLanguageSelect(This,Language)
#define IDvdControl_MenuLanguageSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_AudioStreamChange(This,ulAudio) (This)->lpVtbl -> AudioStreamChange(This,ulAudio)
#define IDvdControl_AudioStreamChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_SubpictureStreamChange(This,ulSubPicture,bDisplay) (This)->lpVtbl -> SubpictureStreamChange(This,ulSubPicture,bDisplay)
#define IDvdControl_SubpictureStreamChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_AngleChange(This,ulAngle) (This)->lpVtbl -> AngleChange(This,ulAngle)
#define IDvdControl_AngleChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ParentalLevelSelect(This,ulParentalLevel) (This)->lpVtbl -> ParentalLevelSelect(This,ulParentalLevel)
#define IDvdControl_ParentalLevelSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ParentalCountrySelect(This,wCountry) (This)->lpVtbl -> ParentalCountrySelect(This,wCountry)
#define IDvdControl_ParentalCountrySelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_KaraokeAudioPresentationModeChange(This,ulMode) (This)->lpVtbl -> KaraokeAudioPresentationModeChange(This,ulMode)
#define IDvdControl_KaraokeAudioPresentationModeChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_VideoModePreferrence(This,ulPreferredDisplayMode) (This)->lpVtbl -> VideoModePreferrence(This,ulPreferredDisplayMode)
#define IDvdControl_VideoModePreferrence
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_SetRoot(This,pszPath) (This)->lpVtbl -> SetRoot(This,pszPath)
#define IDvdControl_SetRoot
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MouseActivate(This,point) (This)->lpVtbl -> MouseActivate(This,point)
#define IDvdControl_MouseActivate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MouseSelect(This,point) (This)->lpVtbl -> MouseSelect(This,point)
#define IDvdControl_MouseSelect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ChapterPlayAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay) (This)->lpVtbl -> ChapterPlayAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay)
#define IDvdControl_ChapterPlayAutoStop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdInfo_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdInfo_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdInfo_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentDomain(This,pDomain) (This)->lpVtbl -> GetCurrentDomain(This,pDomain)
#define IDvdInfo_GetCurrentDomain
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentLocation(This,pLocation) (This)->lpVtbl -> GetCurrentLocation(This,pLocation)
#define IDvdInfo_GetCurrentLocation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetTotalTitleTime(This,pulTotalTime) (This)->lpVtbl -> GetTotalTitleTime(This,pulTotalTime)
#define IDvdInfo_GetTotalTitleTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton) (This)->lpVtbl -> GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton)
#define IDvdInfo_GetCurrentButton
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle) (This)->lpVtbl -> GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle)
#define IDvdInfo_GetCurrentAngle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream) (This)->lpVtbl -> GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream)
#define IDvdInfo_GetCurrentAudio
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pIsDisabled) (This)->lpVtbl -> GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pIsDisabled)
#define IDvdInfo_GetCurrentSubpicture
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentUOPS(This,pUOP) (This)->lpVtbl -> GetCurrentUOPS(This,pUOP)
#define IDvdInfo_GetCurrentUOPS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetAllSPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllSPRMs(This,pRegisterArray)
#define IDvdInfo_GetAllSPRMs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetAllGPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllGPRMs(This,pRegisterArray)
#define IDvdInfo_GetAllGPRMs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetAudioLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetAudioLanguage(This,ulStream,pLanguage)
#define IDvdInfo_GetAudioLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetSubpictureLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetSubpictureLanguage(This,ulStream,pLanguage)
#define IDvdInfo_GetSubpictureLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetTitleAttributes(This,ulTitle,pATR) (This)->lpVtbl -> GetTitleAttributes(This,ulTitle,pATR)
#define IDvdInfo_GetTitleAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetVMGAttributes(This,pATR) (This)->lpVtbl -> GetVMGAttributes(This,pATR)
#define IDvdInfo_GetVMGAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentVideoAttributes(This,pATR) (This)->lpVtbl -> GetCurrentVideoAttributes(This,pATR)
#define IDvdInfo_GetCurrentVideoAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentAudioAttributes(This,pATR) (This)->lpVtbl -> GetCurrentAudioAttributes(This,pATR)
#define IDvdInfo_GetCurrentAudioAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentSubpictureAttributes(This,pATR) (This)->lpVtbl -> GetCurrentSubpictureAttributes(This,pATR)
#define IDvdInfo_GetCurrentSubpictureAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentVolumeInfo(This,pulNumOfVol,pulThisVolNum,pSide,pulNumOfTitles) (This)->lpVtbl -> GetCurrentVolumeInfo(This,pulNumOfVol,pulThisVolNum,pSide,pulNumOfTitles)
#define IDvdInfo_GetCurrentVolumeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetDVDTextInfo(This,pTextManager,ulBufSize,pulActualSize) (This)->lpVtbl -> GetDVDTextInfo(This,pTextManager,ulBufSize,pulActualSize)
#define IDvdInfo_GetDVDTextInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetPlayerParentalLevel(This,pulParentalLevel,pulCountryCode) (This)->lpVtbl -> GetPlayerParentalLevel(This,pulParentalLevel,pulCountryCode)
#define IDvdInfo_GetPlayerParentalLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetNumberOfChapters(This,ulTitle,pulNumberOfChapters) (This)->lpVtbl -> GetNumberOfChapters(This,ulTitle,pulNumberOfChapters)
#define IDvdInfo_GetNumberOfChapters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetTitleParentalLevels(This,ulTitle,pulParentalLevels) (This)->lpVtbl -> GetTitleParentalLevels(This,ulTitle,pulParentalLevels)
#define IDvdInfo_GetTitleParentalLevels
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetRoot(This,pRoot,ulBufSize,pulActualSize) (This)->lpVtbl -> GetRoot(This,pRoot,ulBufSize,pulActualSize)
#define IDvdInfo_GetRoot
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdCmd_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdCmd_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdCmd_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_WaitForStart(This) (This)->lpVtbl -> WaitForStart(This)
#define IDvdCmd_WaitForStart
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_WaitForEnd(This) (This)->lpVtbl -> WaitForEnd(This)
#define IDvdCmd_WaitForEnd
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdState_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdState_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdState_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_GetDiscID(This,pullUniqueID) (This)->lpVtbl -> GetDiscID(This,pullUniqueID)
#define IDvdState_GetDiscID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_GetParentalLevel(This,pulParentalLevel) (This)->lpVtbl -> GetParentalLevel(This,pulParentalLevel)
#define IDvdState_GetParentalLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdControl2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdControl2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdControl2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayTitle(This,ulTitle,dwFlags,ppCmd) (This)->lpVtbl -> PlayTitle(This,ulTitle,dwFlags,ppCmd)
#define IDvdControl2_PlayTitle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayChapterInTitle(This,ulTitle,ulChapter,dwFlags,ppCmd) (This)->lpVtbl -> PlayChapterInTitle(This,ulTitle,ulChapter,dwFlags,ppCmd)
#define IDvdControl2_PlayChapterInTitle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayAtTimeInTitle(This,ulTitle,pStartTime,dwFlags,ppCmd) (This)->lpVtbl -> PlayAtTimeInTitle(This,ulTitle,pStartTime,dwFlags,ppCmd)
#define IDvdControl2_PlayAtTimeInTitle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Stop(This) (This)->lpVtbl -> Stop(This)
#define IDvdControl2_Stop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ReturnFromSubmenu(This,dwFlags,ppCmd) (This)->lpVtbl -> ReturnFromSubmenu(This,dwFlags,ppCmd)
#define IDvdControl2_ReturnFromSubmenu
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayAtTime(This,pTime,dwFlags,ppCmd) (This)->lpVtbl -> PlayAtTime(This,pTime,dwFlags,ppCmd)
#define IDvdControl2_PlayAtTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayChapter(This,ulChapter,dwFlags,ppCmd) (This)->lpVtbl -> PlayChapter(This,ulChapter,dwFlags,ppCmd)
#define IDvdControl2_PlayChapter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayPrevChapter(This,dwFlags,ppCmd) (This)->lpVtbl -> PlayPrevChapter(This,dwFlags,ppCmd)
#define IDvdControl2_PlayPrevChapter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ReplayChapter(This,dwFlags,ppCmd) (This)->lpVtbl -> ReplayChapter(This,dwFlags,ppCmd)
#define IDvdControl2_ReplayChapter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayNextChapter(This,dwFlags,ppCmd) (This)->lpVtbl -> PlayNextChapter(This,dwFlags,ppCmd)
#define IDvdControl2_PlayNextChapter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayForwards(This,dSpeed,dwFlags,ppCmd) (This)->lpVtbl -> PlayForwards(This,dSpeed,dwFlags,ppCmd)
#define IDvdControl2_PlayForwards
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayBackwards(This,dSpeed,dwFlags,ppCmd) (This)->lpVtbl -> PlayBackwards(This,dSpeed,dwFlags,ppCmd)
#define IDvdControl2_PlayBackwards
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ShowMenu(This,MenuID,dwFlags,ppCmd) (This)->lpVtbl -> ShowMenu(This,MenuID,dwFlags,ppCmd)
#define IDvdControl2_ShowMenu
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Resume(This,dwFlags,ppCmd) (This)->lpVtbl -> Resume(This,dwFlags,ppCmd)
#define IDvdControl2_Resume
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectRelativeButton(This,buttonDir) (This)->lpVtbl -> SelectRelativeButton(This,buttonDir)
#define IDvdControl2_SelectRelativeButton
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ActivateButton(This) (This)->lpVtbl -> ActivateButton(This)
#define IDvdControl2_ActivateButton
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectButton(This,ulButton) (This)->lpVtbl -> SelectButton(This,ulButton)
#define IDvdControl2_SelectButton
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAndActivateButton(This,ulButton) (This)->lpVtbl -> SelectAndActivateButton(This,ulButton)
#define IDvdControl2_SelectAndActivateButton
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_StillOff(This) (This)->lpVtbl -> StillOff(This)
#define IDvdControl2_StillOff
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Pause(This,bState) (This)->lpVtbl -> Pause(This,bState)
#define IDvdControl2_Pause
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAudioStream(This,ulAudio,dwFlags,ppCmd) (This)->lpVtbl -> SelectAudioStream(This,ulAudio,dwFlags,ppCmd)
#define IDvdControl2_SelectAudioStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectSubpictureStream(This,ulSubPicture,dwFlags,ppCmd) (This)->lpVtbl -> SelectSubpictureStream(This,ulSubPicture,dwFlags,ppCmd)
#define IDvdControl2_SelectSubpictureStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetSubpictureState(This,bState,dwFlags,ppCmd) (This)->lpVtbl -> SetSubpictureState(This,bState,dwFlags,ppCmd)
#define IDvdControl2_SetSubpictureState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAngle(This,ulAngle,dwFlags,ppCmd) (This)->lpVtbl -> SelectAngle(This,ulAngle,dwFlags,ppCmd)
#define IDvdControl2_SelectAngle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectParentalLevel(This,ulParentalLevel) (This)->lpVtbl -> SelectParentalLevel(This,ulParentalLevel)
#define IDvdControl2_SelectParentalLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectParentalCountry(This,bCountry) (This)->lpVtbl -> SelectParentalCountry(This,bCountry)
#define IDvdControl2_SelectParentalCountry
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectKaraokeAudioPresentationMode(This,ulMode) (This)->lpVtbl -> SelectKaraokeAudioPresentationMode(This,ulMode)
#define IDvdControl2_SelectKaraokeAudioPresentationMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectVideoModePreference(This,ulPreferredDisplayMode) (This)->lpVtbl -> SelectVideoModePreference(This,ulPreferredDisplayMode)
#define IDvdControl2_SelectVideoModePreference
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetDVDDirectory(This,pszwPath) (This)->lpVtbl -> SetDVDDirectory(This,pszwPath)
#define IDvdControl2_SetDVDDirectory
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ActivateAtPosition(This,point) (This)->lpVtbl -> ActivateAtPosition(This,point)
#define IDvdControl2_ActivateAtPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAtPosition(This,point) (This)->lpVtbl -> SelectAtPosition(This,point)
#define IDvdControl2_SelectAtPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayChaptersAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay,dwFlags,ppCmd) (This)->lpVtbl -> PlayChaptersAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay,dwFlags,ppCmd)
#define IDvdControl2_PlayChaptersAutoStop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_AcceptParentalLevelChange(This,bAccept) (This)->lpVtbl -> AcceptParentalLevelChange(This,bAccept)
#define IDvdControl2_AcceptParentalLevelChange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetOption(This,flag,fState) (This)->lpVtbl -> SetOption(This,flag,fState)
#define IDvdControl2_SetOption
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetState(This,pState,dwFlags,ppCmd) (This)->lpVtbl -> SetState(This,pState,dwFlags,ppCmd)
#define IDvdControl2_SetState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayPeriodInTitleAutoStop(This,ulTitle,pStartTime,pEndTime,dwFlags,ppCmd) (This)->lpVtbl -> PlayPeriodInTitleAutoStop(This,ulTitle,pStartTime,pEndTime,dwFlags,ppCmd)
#define IDvdControl2_PlayPeriodInTitleAutoStop
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetGPRM(This,ulIndex,wValue,dwFlags,ppCmd) (This)->lpVtbl -> SetGPRM(This,ulIndex,wValue,dwFlags,ppCmd)
#define IDvdControl2_SetGPRM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectDefaultMenuLanguage(This,Language) (This)->lpVtbl -> SelectDefaultMenuLanguage(This,Language)
#define IDvdControl2_SelectDefaultMenuLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectDefaultAudioLanguage(This,Language,audioExtension) (This)->lpVtbl -> SelectDefaultAudioLanguage(This,Language,audioExtension)
#define IDvdControl2_SelectDefaultAudioLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectDefaultSubpictureLanguage(This,Language,subpictureExtension) (This)->lpVtbl -> SelectDefaultSubpictureLanguage(This,Language,subpictureExtension)
#define IDvdControl2_SelectDefaultSubpictureLanguage
#define DVD_TITLE_MENU
#define DVD_STREAM_DATA_CURRENT
#define DVD_STREAM_DATA_VMGM
#define DVD_STREAM_DATA_VTSM
#define DVD_DEFAULT_AUDIO_STREAM
#define DVD_AUDIO_CAPS_AC3
#define DVD_AUDIO_CAPS_MPEG2
#define DVD_AUDIO_CAPS_LPCM
#define DVD_AUDIO_CAPS_DTS
#define DVD_AUDIO_CAPS_SDDS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdInfo2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdInfo2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdInfo2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentDomain(This,pDomain) (This)->lpVtbl -> GetCurrentDomain(This,pDomain)
#define IDvdInfo2_GetCurrentDomain
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentLocation(This,pLocation) (This)->lpVtbl -> GetCurrentLocation(This,pLocation)
#define IDvdInfo2_GetCurrentLocation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetTotalTitleTime(This,pTotalTime,ulTimeCodeFlags) (This)->lpVtbl -> GetTotalTitleTime(This,pTotalTime,ulTimeCodeFlags)
#define IDvdInfo2_GetTotalTitleTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton) (This)->lpVtbl -> GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton)
#define IDvdInfo2_GetCurrentButton
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle) (This)->lpVtbl -> GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle)
#define IDvdInfo2_GetCurrentAngle
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream) (This)->lpVtbl -> GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream)
#define IDvdInfo2_GetCurrentAudio
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pbIsDisabled) (This)->lpVtbl -> GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pbIsDisabled)
#define IDvdInfo2_GetCurrentSubpicture
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentUOPS(This,pulUOPs) (This)->lpVtbl -> GetCurrentUOPS(This,pulUOPs)
#define IDvdInfo2_GetCurrentUOPS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAllSPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllSPRMs(This,pRegisterArray)
#define IDvdInfo2_GetAllSPRMs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAllGPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllGPRMs(This,pRegisterArray)
#define IDvdInfo2_GetAllGPRMs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAudioLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetAudioLanguage(This,ulStream,pLanguage)
#define IDvdInfo2_GetAudioLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetSubpictureLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetSubpictureLanguage(This,ulStream,pLanguage)
#define IDvdInfo2_GetSubpictureLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetTitleAttributes(This,ulTitle,pMenu,pTitle) (This)->lpVtbl -> GetTitleAttributes(This,ulTitle,pMenu,pTitle)
#define IDvdInfo2_GetTitleAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetVMGAttributes(This,pATR) (This)->lpVtbl -> GetVMGAttributes(This,pATR)
#define IDvdInfo2_GetVMGAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentVideoAttributes(This,pATR) (This)->lpVtbl -> GetCurrentVideoAttributes(This,pATR)
#define IDvdInfo2_GetCurrentVideoAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAudioAttributes(This,ulStream,pATR) (This)->lpVtbl -> GetAudioAttributes(This,ulStream,pATR)
#define IDvdInfo2_GetAudioAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetKaraokeAttributes(This,ulStream,pAttributes) (This)->lpVtbl -> GetKaraokeAttributes(This,ulStream,pAttributes)
#define IDvdInfo2_GetKaraokeAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetSubpictureAttributes(This,ulStream,pATR) (This)->lpVtbl -> GetSubpictureAttributes(This,ulStream,pATR)
#define IDvdInfo2_GetSubpictureAttributes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDVolumeInfo(This,pulNumOfVolumes,pulVolume,pSide,pulNumOfTitles) (This)->lpVtbl -> GetDVDVolumeInfo(This,pulNumOfVolumes,pulVolume,pSide,pulNumOfTitles)
#define IDvdInfo2_GetDVDVolumeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextNumberOfLanguages(This,pulNumOfLangs) (This)->lpVtbl -> GetDVDTextNumberOfLanguages(This,pulNumOfLangs)
#define IDvdInfo2_GetDVDTextNumberOfLanguages
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextLanguageInfo(This,ulLangIndex,pulNumOfStrings,pLangCode,pbCharacterSet) (This)->lpVtbl -> GetDVDTextLanguageInfo(This,ulLangIndex,pulNumOfStrings,pLangCode,pbCharacterSet)
#define IDvdInfo2_GetDVDTextLanguageInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextStringAsNative(This,ulLangIndex,ulStringIndex,pbBuffer,ulMaxBufferSize,pulActualSize,pType) (This)->lpVtbl -> GetDVDTextStringAsNative(This,ulLangIndex,ulStringIndex,pbBuffer,ulMaxBufferSize,pulActualSize,pType)
#define IDvdInfo2_GetDVDTextStringAsNative
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextStringAsUnicode(This,ulLangIndex,ulStringIndex,pchwBuffer,ulMaxBufferSize,pulActualSize,pType) (This)->lpVtbl -> GetDVDTextStringAsUnicode(This,ulLangIndex,ulStringIndex,pchwBuffer,ulMaxBufferSize,pulActualSize,pType)
#define IDvdInfo2_GetDVDTextStringAsUnicode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetPlayerParentalLevel(This,pulParentalLevel,pbCountryCode) (This)->lpVtbl -> GetPlayerParentalLevel(This,pulParentalLevel,pbCountryCode)
#define IDvdInfo2_GetPlayerParentalLevel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetNumberOfChapters(This,ulTitle,pulNumOfChapters) (This)->lpVtbl -> GetNumberOfChapters(This,ulTitle,pulNumOfChapters)
#define IDvdInfo2_GetNumberOfChapters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetTitleParentalLevels(This,ulTitle,pulParentalLevels) (This)->lpVtbl -> GetTitleParentalLevels(This,ulTitle,pulParentalLevels)
#define IDvdInfo2_GetTitleParentalLevels
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDDirectory(This,pszwPath,ulMaxSize,pulActualSize) (This)->lpVtbl -> GetDVDDirectory(This,pszwPath,ulMaxSize,pulActualSize)
#define IDvdInfo2_GetDVDDirectory
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_IsAudioStreamEnabled(This,ulStreamNum,pbEnabled) (This)->lpVtbl -> IsAudioStreamEnabled(This,ulStreamNum,pbEnabled)
#define IDvdInfo2_IsAudioStreamEnabled
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDiscID(This,pszwPath,pullDiscID) (This)->lpVtbl -> GetDiscID(This,pszwPath,pullDiscID)
#define IDvdInfo2_GetDiscID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetState(This,pStateData) (This)->lpVtbl -> GetState(This,pStateData)
#define IDvdInfo2_GetState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetMenuLanguages(This,pLanguages,ulMaxLanguages,pulActualLanguages) (This)->lpVtbl -> GetMenuLanguages(This,pLanguages,ulMaxLanguages,pulActualLanguages)
#define IDvdInfo2_GetMenuLanguages
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetButtonAtPosition(This,point,pulButtonIndex) (This)->lpVtbl -> GetButtonAtPosition(This,point,pulButtonIndex)
#define IDvdInfo2_GetButtonAtPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCmdFromEvent(This,lParam1,pCmdObj) (This)->lpVtbl -> GetCmdFromEvent(This,lParam1,pCmdObj)
#define IDvdInfo2_GetCmdFromEvent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDefaultMenuLanguage(This,pLanguage) (This)->lpVtbl -> GetDefaultMenuLanguage(This,pLanguage)
#define IDvdInfo2_GetDefaultMenuLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDefaultAudioLanguage(This,pLanguage,pAudioExtension) (This)->lpVtbl -> GetDefaultAudioLanguage(This,pLanguage,pAudioExtension)
#define IDvdInfo2_GetDefaultAudioLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDefaultSubpictureLanguage(This,pLanguage,pSubpictureExtension) (This)->lpVtbl -> GetDefaultSubpictureLanguage(This,pLanguage,pSubpictureExtension)
#define IDvdInfo2_GetDefaultSubpictureLanguage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDecoderCaps(This,pCaps) (This)->lpVtbl -> GetDecoderCaps(This,pCaps)
#define IDvdInfo2_GetDecoderCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetButtonRect(This,ulButton,pRect) (This)->lpVtbl -> GetButtonRect(This,ulButton,pRect)
#define IDvdInfo2_GetButtonRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_IsSubpictureStreamEnabled(This,ulStreamNum,pbEnabled) (This)->lpVtbl -> IsSubpictureStreamEnabled(This,ulStreamNum,pbEnabled)
#define IDvdInfo2_IsSubpictureStreamEnabled
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDvdGraphBuilder_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDvdGraphBuilder_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_Release(This) (This)->lpVtbl -> Release(This)
#define IDvdGraphBuilder_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_GetFiltergraph(This,ppGB) (This)->lpVtbl -> GetFiltergraph(This,ppGB)
#define IDvdGraphBuilder_GetFiltergraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_GetDvdInterface(This,riid,ppvIF) (This)->lpVtbl -> GetDvdInterface(This,riid,ppvIF)
#define IDvdGraphBuilder_GetDvdInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_RenderDvdVideoVolume(This,lpcwszPathName,dwFlags,pStatus) (This)->lpVtbl -> RenderDvdVideoVolume(This,lpcwszPathName,dwFlags,pStatus)
#define IDvdGraphBuilder_RenderDvdVideoVolume
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDDrawExclModeVideo_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDDrawExclModeVideo_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_Release(This) (This)->lpVtbl -> Release(This)
#define IDDrawExclModeVideo_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetDDrawObject(This,pDDrawObject) (This)->lpVtbl -> SetDDrawObject(This,pDDrawObject)
#define IDDrawExclModeVideo_SetDDrawObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_GetDDrawObject(This,ppDDrawObject,pbUsingExternal) (This)->lpVtbl -> GetDDrawObject(This,ppDDrawObject,pbUsingExternal)
#define IDDrawExclModeVideo_GetDDrawObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetDDrawSurface(This,pDDrawSurface) (This)->lpVtbl -> SetDDrawSurface(This,pDDrawSurface)
#define IDDrawExclModeVideo_SetDDrawSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_GetDDrawSurface(This,ppDDrawSurface,pbUsingExternal) (This)->lpVtbl -> GetDDrawSurface(This,ppDDrawSurface,pbUsingExternal)
#define IDDrawExclModeVideo_GetDDrawSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetDrawParameters(This,prcSource,prcTarget) (This)->lpVtbl -> SetDrawParameters(This,prcSource,prcTarget)
#define IDDrawExclModeVideo_SetDrawParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_GetNativeVideoProps(This,pdwVideoWidth,pdwVideoHeight,pdwPictAspectRatioX,pdwPictAspectRatioY) (This)->lpVtbl -> GetNativeVideoProps(This,pdwVideoWidth,pdwVideoHeight,pdwPictAspectRatioX,pdwPictAspectRatioY)
#define IDDrawExclModeVideo_GetNativeVideoProps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetCallbackInterface(This,pCallback,dwFlags) (This)->lpVtbl -> SetCallbackInterface(This,pCallback,dwFlags)
#define IDDrawExclModeVideo_SetCallbackInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDDrawExclModeVideoCallback_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDDrawExclModeVideoCallback_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_Release(This) (This)->lpVtbl -> Release(This)
#define IDDrawExclModeVideoCallback_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_OnUpdateOverlay(This,bBefore,dwFlags,bOldVisible,prcOldSrc,prcOldDest,bNewVisible,prcNewSrc,prcNewDest) (This)->lpVtbl -> OnUpdateOverlay(This,bBefore,dwFlags,bOldVisible,prcOldSrc,prcOldDest,bNewVisible,prcNewSrc,prcNewDest)
#define IDDrawExclModeVideoCallback_OnUpdateOverlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_OnUpdateColorKey(This,pKey,dwColor) (This)->lpVtbl -> OnUpdateColorKey(This,pKey,dwColor)
#define IDDrawExclModeVideoCallback_OnUpdateColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_OnUpdateSize(This,dwWidth,dwHeight,dwARWidth,dwARHeight) (This)->lpVtbl -> OnUpdateSize(This,dwWidth,dwHeight,dwARWidth,dwARHeight)
#define IDDrawExclModeVideoCallback_OnUpdateSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IPinConnection_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IPinConnection_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_Release(This) (This)->lpVtbl -> Release(This)
#define IPinConnection_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_DynamicQueryAccept(This,pmt) (This)->lpVtbl -> DynamicQueryAccept(This,pmt)
#define IPinConnection_DynamicQueryAccept
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_NotifyEndOfStream(This,hNotifyEvent) (This)->lpVtbl -> NotifyEndOfStream(This,hNotifyEvent)
#define IPinConnection_NotifyEndOfStream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_IsEndPin(This) (This)->lpVtbl -> IsEndPin(This)
#define IPinConnection_IsEndPin
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_DynamicDisconnect(This) (This)->lpVtbl -> DynamicDisconnect(This)
#define IPinConnection_DynamicDisconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IPinFlowControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IPinFlowControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_Release(This) (This)->lpVtbl -> Release(This)
#define IPinFlowControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_Block(This,dwBlockFlags,hEvent) (This)->lpVtbl -> Block(This,dwBlockFlags,hEvent)
#define IPinFlowControl_Block
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IGraphConfig_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IGraphConfig_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_Release(This) (This)->lpVtbl -> Release(This)
#define IGraphConfig_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_Reconnect(This,pOutputPin,pInputPin,pmtFirstConnection,pUsingFilter,hAbortEvent,dwFlags) (This)->lpVtbl -> Reconnect(This,pOutputPin,pInputPin,pmtFirstConnection,pUsingFilter,hAbortEvent,dwFlags)
#define IGraphConfig_Reconnect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_Reconfigure(This,pCallback,pvContext,dwFlags,hAbortEvent) (This)->lpVtbl -> Reconfigure(This,pCallback,pvContext,dwFlags,hAbortEvent)
#define IGraphConfig_Reconfigure
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_AddFilterToCache(This,pFilter) (This)->lpVtbl -> AddFilterToCache(This,pFilter)
#define IGraphConfig_AddFilterToCache
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_EnumCacheFilter(This,pEnum) (This)->lpVtbl -> EnumCacheFilter(This,pEnum)
#define IGraphConfig_EnumCacheFilter
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_RemoveFilterFromCache(This,pFilter) (This)->lpVtbl -> RemoveFilterFromCache(This,pFilter)
#define IGraphConfig_RemoveFilterFromCache
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_GetStartTime(This,prtStart) (This)->lpVtbl -> GetStartTime(This,prtStart)
#define IGraphConfig_GetStartTime
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_PushThroughData(This,pOutputPin,pConnection,hEventAbort) (This)->lpVtbl -> PushThroughData(This,pOutputPin,pConnection,hEventAbort)
#define IGraphConfig_PushThroughData
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_SetFilterFlags(This,pFilter,dwFlags) (This)->lpVtbl -> SetFilterFlags(This,pFilter,dwFlags)
#define IGraphConfig_SetFilterFlags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_GetFilterFlags(This,pFilter,pdwFlags) (This)->lpVtbl -> GetFilterFlags(This,pFilter,pdwFlags)
#define IGraphConfig_GetFilterFlags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_RemoveFilterEx(This,pFilter,Flags) (This)->lpVtbl -> RemoveFilterEx(This,pFilter,Flags)
#define IGraphConfig_RemoveFilterEx
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IGraphConfigCallback_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IGraphConfigCallback_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_Release(This) (This)->lpVtbl -> Release(This)
#define IGraphConfigCallback_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_Reconfigure(This,pvContext,dwFlags) (This)->lpVtbl -> Reconfigure(This,pvContext,dwFlags)
#define IGraphConfigCallback_Reconfigure
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IFilterChain_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IFilterChain_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_Release(This) (This)->lpVtbl -> Release(This)
#define IFilterChain_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_StartChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> StartChain(This,pStartFilter,pEndFilter)
#define IFilterChain_StartChain
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_PauseChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> PauseChain(This,pStartFilter,pEndFilter)
#define IFilterChain_PauseChain
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_StopChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> StopChain(This,pStartFilter,pEndFilter)
#define IFilterChain_StopChain
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_RemoveChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> RemoveChain(This,pStartFilter,pEndFilter)
#define IFilterChain_RemoveChain
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRImagePresenter_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRImagePresenter_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRImagePresenter_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_StartPresenting(This,dwUserID) (This)->lpVtbl -> StartPresenting(This,dwUserID)
#define IVMRImagePresenter_StartPresenting
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_StopPresenting(This,dwUserID) (This)->lpVtbl -> StopPresenting(This,dwUserID)
#define IVMRImagePresenter_StopPresenting
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_PresentImage(This,dwUserID,lpPresInfo) (This)->lpVtbl -> PresentImage(This,dwUserID,lpPresInfo)
#define IVMRImagePresenter_PresentImage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRSurfaceAllocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRSurfaceAllocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRSurfaceAllocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_AllocateSurface(This,dwUserID,lpAllocInfo,lpdwActualBuffers,lplpSurface) (This)->lpVtbl -> AllocateSurface(This,dwUserID,lpAllocInfo,lpdwActualBuffers,lplpSurface)
#define IVMRSurfaceAllocator_AllocateSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_FreeSurface(This,dwID) (This)->lpVtbl -> FreeSurface(This,dwID)
#define IVMRSurfaceAllocator_FreeSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_PrepareSurface(This,dwUserID,lpSurface,dwSurfaceFlags) (This)->lpVtbl -> PrepareSurface(This,dwUserID,lpSurface,dwSurfaceFlags)
#define IVMRSurfaceAllocator_PrepareSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_AdviseNotify(This,lpIVMRSurfAllocNotify) (This)->lpVtbl -> AdviseNotify(This,lpIVMRSurfAllocNotify)
#define IVMRSurfaceAllocator_AdviseNotify
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRSurfaceAllocatorNotify_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRSurfaceAllocatorNotify_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRSurfaceAllocatorNotify_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_AdviseSurfaceAllocator(This,dwUserID,lpIVRMSurfaceAllocator) (This)->lpVtbl -> AdviseSurfaceAllocator(This,dwUserID,lpIVRMSurfaceAllocator)
#define IVMRSurfaceAllocatorNotify_AdviseSurfaceAllocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_SetDDrawDevice(This,lpDDrawDevice,hMonitor) (This)->lpVtbl -> SetDDrawDevice(This,lpDDrawDevice,hMonitor)
#define IVMRSurfaceAllocatorNotify_SetDDrawDevice
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_ChangeDDrawDevice(This,lpDDrawDevice,hMonitor) (This)->lpVtbl -> ChangeDDrawDevice(This,lpDDrawDevice,hMonitor)
#define IVMRSurfaceAllocatorNotify_ChangeDDrawDevice
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_RestoreDDrawSurfaces(This) (This)->lpVtbl -> RestoreDDrawSurfaces(This)
#define IVMRSurfaceAllocatorNotify_RestoreDDrawSurfaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_NotifyEvent(This,EventCode,Param1,Param2) (This)->lpVtbl -> NotifyEvent(This,EventCode,Param1,Param2)
#define IVMRSurfaceAllocatorNotify_NotifyEvent
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_SetBorderColor(This,clrBorder) (This)->lpVtbl -> SetBorderColor(This,clrBorder)
#define IVMRSurfaceAllocatorNotify_SetBorderColor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRWindowlessControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRWindowlessControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRWindowlessControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetNativeVideoSize(This,lpWidth,lpHeight,lpARWidth,lpARHeight) (This)->lpVtbl -> GetNativeVideoSize(This,lpWidth,lpHeight,lpARWidth,lpARHeight)
#define IVMRWindowlessControl_GetNativeVideoSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetMinIdealVideoSize(This,lpWidth,lpHeight) (This)->lpVtbl -> GetMinIdealVideoSize(This,lpWidth,lpHeight)
#define IVMRWindowlessControl_GetMinIdealVideoSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetMaxIdealVideoSize(This,lpWidth,lpHeight) (This)->lpVtbl -> GetMaxIdealVideoSize(This,lpWidth,lpHeight)
#define IVMRWindowlessControl_GetMaxIdealVideoSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetVideoPosition(This,lpSRCRect,lpDSTRect) (This)->lpVtbl -> SetVideoPosition(This,lpSRCRect,lpDSTRect)
#define IVMRWindowlessControl_SetVideoPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetVideoPosition(This,lpSRCRect,lpDSTRect) (This)->lpVtbl -> GetVideoPosition(This,lpSRCRect,lpDSTRect)
#define IVMRWindowlessControl_GetVideoPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetAspectRatioMode(This,lpAspectRatioMode) (This)->lpVtbl -> GetAspectRatioMode(This,lpAspectRatioMode)
#define IVMRWindowlessControl_GetAspectRatioMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetAspectRatioMode(This,AspectRatioMode) (This)->lpVtbl -> SetAspectRatioMode(This,AspectRatioMode)
#define IVMRWindowlessControl_SetAspectRatioMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetVideoClippingWindow(This,hwnd) (This)->lpVtbl -> SetVideoClippingWindow(This,hwnd)
#define IVMRWindowlessControl_SetVideoClippingWindow
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_RepaintVideo(This,hwnd,hdc) (This)->lpVtbl -> RepaintVideo(This,hwnd,hdc)
#define IVMRWindowlessControl_RepaintVideo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_DisplayModeChanged(This) (This)->lpVtbl -> DisplayModeChanged(This)
#define IVMRWindowlessControl_DisplayModeChanged
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetCurrentImage(This,lpDib) (This)->lpVtbl -> GetCurrentImage(This,lpDib)
#define IVMRWindowlessControl_GetCurrentImage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetBorderColor(This,Clr) (This)->lpVtbl -> SetBorderColor(This,Clr)
#define IVMRWindowlessControl_SetBorderColor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetBorderColor(This,lpClr) (This)->lpVtbl -> GetBorderColor(This,lpClr)
#define IVMRWindowlessControl_GetBorderColor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetColorKey(This,Clr) (This)->lpVtbl -> SetColorKey(This,Clr)
#define IVMRWindowlessControl_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetColorKey(This,lpClr) (This)->lpVtbl -> GetColorKey(This,lpClr)
#define IVMRWindowlessControl_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRMixerControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRMixerControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRMixerControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetAlpha(This,dwStreamID,Alpha) (This)->lpVtbl -> SetAlpha(This,dwStreamID,Alpha)
#define IVMRMixerControl_SetAlpha
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetAlpha(This,dwStreamID,pAlpha) (This)->lpVtbl -> GetAlpha(This,dwStreamID,pAlpha)
#define IVMRMixerControl_GetAlpha
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetZOrder(This,dwStreamID,dwZ) (This)->lpVtbl -> SetZOrder(This,dwStreamID,dwZ)
#define IVMRMixerControl_SetZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetZOrder(This,dwStreamID,pZ) (This)->lpVtbl -> GetZOrder(This,dwStreamID,pZ)
#define IVMRMixerControl_GetZOrder
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetOutputRect(This,dwStreamID,pRect) (This)->lpVtbl -> SetOutputRect(This,dwStreamID,pRect)
#define IVMRMixerControl_SetOutputRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetOutputRect(This,dwStreamID,pRect) (This)->lpVtbl -> GetOutputRect(This,dwStreamID,pRect)
#define IVMRMixerControl_GetOutputRect
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetBackgroundClr(This,ClrBkg) (This)->lpVtbl -> SetBackgroundClr(This,ClrBkg)
#define IVMRMixerControl_SetBackgroundClr
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetBackgroundClr(This,lpClrBkg) (This)->lpVtbl -> GetBackgroundClr(This,lpClrBkg)
#define IVMRMixerControl_GetBackgroundClr
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetMixingPrefs(This,dwMixerPrefs) (This)->lpVtbl -> SetMixingPrefs(This,dwMixerPrefs)
#define IVMRMixerControl_SetMixingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetMixingPrefs(This,pdwMixerPrefs) (This)->lpVtbl -> GetMixingPrefs(This,pdwMixerPrefs)
#define IVMRMixerControl_GetMixingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRMonitorConfig_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRMonitorConfig_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRMonitorConfig_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_SetMonitor(This,pGUID) (This)->lpVtbl -> SetMonitor(This,pGUID)
#define IVMRMonitorConfig_SetMonitor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_GetMonitor(This,pGUID) (This)->lpVtbl -> GetMonitor(This,pGUID)
#define IVMRMonitorConfig_GetMonitor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_SetDefaultMonitor(This,pGUID) (This)->lpVtbl -> SetDefaultMonitor(This,pGUID)
#define IVMRMonitorConfig_SetDefaultMonitor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_GetDefaultMonitor(This,pGUID) (This)->lpVtbl -> GetDefaultMonitor(This,pGUID)
#define IVMRMonitorConfig_GetDefaultMonitor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_GetAvailableMonitors(This,pInfo,dwMaxInfoArraySize,pdwNumDevices) (This)->lpVtbl -> GetAvailableMonitors(This,pInfo,dwMaxInfoArraySize,pdwNumDevices)
#define IVMRMonitorConfig_GetAvailableMonitors
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRFilterConfig_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRFilterConfig_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRFilterConfig_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetImageCompositor(This,lpVMRImgCompositor) (This)->lpVtbl -> SetImageCompositor(This,lpVMRImgCompositor)
#define IVMRFilterConfig_SetImageCompositor
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetNumberOfStreams(This,dwMaxStreams) (This)->lpVtbl -> SetNumberOfStreams(This,dwMaxStreams)
#define IVMRFilterConfig_SetNumberOfStreams
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_GetNumberOfStreams(This,pdwMaxStreams) (This)->lpVtbl -> GetNumberOfStreams(This,pdwMaxStreams)
#define IVMRFilterConfig_GetNumberOfStreams
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> SetRenderingPrefs(This,dwRenderFlags)
#define IVMRFilterConfig_SetRenderingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_GetRenderingPrefs(This,pdwRenderFlags) (This)->lpVtbl -> GetRenderingPrefs(This,pdwRenderFlags)
#define IVMRFilterConfig_GetRenderingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetRenderingMode(This,Mode) (This)->lpVtbl -> SetRenderingMode(This,Mode)
#define IVMRFilterConfig_SetRenderingMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_GetRenderingMode(This,pMode) (This)->lpVtbl -> GetRenderingMode(This,pMode)
#define IVMRFilterConfig_GetRenderingMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRAspectRatioControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRAspectRatioControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRAspectRatioControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_GetAspectRatioMode(This,lpdwARMode) (This)->lpVtbl -> GetAspectRatioMode(This,lpdwARMode)
#define IVMRAspectRatioControl_GetAspectRatioMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_SetAspectRatioMode(This,dwARMode) (This)->lpVtbl -> SetAspectRatioMode(This,dwARMode)
#define IVMRAspectRatioControl_SetAspectRatioMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRDeinterlaceControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRDeinterlaceControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRDeinterlaceControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetNumberOfDeinterlaceModes(This,lpVideoDescription,lpdwNumDeinterlaceModes,lpDeinterlaceModes) (This)->lpVtbl -> GetNumberOfDeinterlaceModes(This,lpVideoDescription,lpdwNumDeinterlaceModes,lpDeinterlaceModes)
#define IVMRDeinterlaceControl_GetNumberOfDeinterlaceModes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetDeinterlaceModeCaps(This,lpDeinterlaceMode,lpVideoDescription,lpDeinterlaceCaps) (This)->lpVtbl -> GetDeinterlaceModeCaps(This,lpDeinterlaceMode,lpVideoDescription,lpDeinterlaceCaps)
#define IVMRDeinterlaceControl_GetDeinterlaceModeCaps
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode) (This)->lpVtbl -> GetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode)
#define IVMRDeinterlaceControl_GetDeinterlaceMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_SetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode) (This)->lpVtbl -> SetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode)
#define IVMRDeinterlaceControl_SetDeinterlaceMode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetDeinterlacePrefs(This,lpdwDeinterlacePrefs) (This)->lpVtbl -> GetDeinterlacePrefs(This,lpdwDeinterlacePrefs)
#define IVMRDeinterlaceControl_GetDeinterlacePrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_SetDeinterlacePrefs(This,dwDeinterlacePrefs) (This)->lpVtbl -> SetDeinterlacePrefs(This,dwDeinterlacePrefs)
#define IVMRDeinterlaceControl_SetDeinterlacePrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetActualDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode) (This)->lpVtbl -> GetActualDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode)
#define IVMRDeinterlaceControl_GetActualDeinterlaceMode
#define VMRBITMAP_DISABLE
#define VMRBITMAP_HDC
#define VMRBITMAP_ENTIREDDS
#define VMRBITMAP_SRCCOLORKEY
#define VMRBITMAP_SRCRECT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRMixerBitmap_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRMixerBitmap_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRMixerBitmap_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_SetAlphaBitmap(This,pBmpParms) (This)->lpVtbl -> SetAlphaBitmap(This,pBmpParms)
#define IVMRMixerBitmap_SetAlphaBitmap
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_UpdateAlphaBitmapParameters(This,pBmpParms) (This)->lpVtbl -> UpdateAlphaBitmapParameters(This,pBmpParms)
#define IVMRMixerBitmap_UpdateAlphaBitmapParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_GetAlphaBitmapParameters(This,pBmpParms) (This)->lpVtbl -> GetAlphaBitmapParameters(This,pBmpParms)
#define IVMRMixerBitmap_GetAlphaBitmapParameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRImageCompositor_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRImageCompositor_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRImageCompositor_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_InitCompositionTarget(This,pD3DDevice,pddsRenderTarget) (This)->lpVtbl -> InitCompositionTarget(This,pD3DDevice,pddsRenderTarget)
#define IVMRImageCompositor_InitCompositionTarget
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_TermCompositionTarget(This,pD3DDevice,pddsRenderTarget) (This)->lpVtbl -> TermCompositionTarget(This,pD3DDevice,pddsRenderTarget)
#define IVMRImageCompositor_TermCompositionTarget
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_SetStreamMediaType(This,dwStrmID,pmt,fTexture) (This)->lpVtbl -> SetStreamMediaType(This,dwStrmID,pmt,fTexture)
#define IVMRImageCompositor_SetStreamMediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_CompositeImage(This,pD3DDevice,pddsRenderTarget,pmtRenderTarget,rtStart,rtEnd,dwClrBkGnd,pVideoStreamInfo,cStreams) (This)->lpVtbl -> CompositeImage(This,pD3DDevice,pddsRenderTarget,pmtRenderTarget,rtStart,rtEnd,dwClrBkGnd,pVideoStreamInfo,cStreams)
#define IVMRImageCompositor_CompositeImage
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRVideoStreamControl_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRVideoStreamControl_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRVideoStreamControl_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_SetColorKey(This,lpClrKey) (This)->lpVtbl -> SetColorKey(This,lpClrKey)
#define IVMRVideoStreamControl_SetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_GetColorKey(This,lpClrKey) (This)->lpVtbl -> GetColorKey(This,lpClrKey)
#define IVMRVideoStreamControl_GetColorKey
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_SetStreamActiveState(This,fActive) (This)->lpVtbl -> SetStreamActiveState(This,fActive)
#define IVMRVideoStreamControl_SetStreamActiveState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_GetStreamActiveState(This,lpfActive) (This)->lpVtbl -> GetStreamActiveState(This,lpfActive)
#define IVMRVideoStreamControl_GetStreamActiveState
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRSurface_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRSurface_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRSurface_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_IsSurfaceLocked(This) (This)->lpVtbl -> IsSurfaceLocked(This)
#define IVMRSurface_IsSurfaceLocked
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_LockSurface(This,lpSurface) (This)->lpVtbl -> LockSurface(This,lpSurface)
#define IVMRSurface_LockSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_UnlockSurface(This) (This)->lpVtbl -> UnlockSurface(This)
#define IVMRSurface_UnlockSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_GetSurface(This,lplpSurface) (This)->lpVtbl -> GetSurface(This,lplpSurface)
#define IVMRSurface_GetSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRImagePresenterConfig_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRImagePresenterConfig_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRImagePresenterConfig_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_SetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> SetRenderingPrefs(This,dwRenderFlags)
#define IVMRImagePresenterConfig_SetRenderingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_GetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> GetRenderingPrefs(This,dwRenderFlags)
#define IVMRImagePresenterConfig_GetRenderingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVMRImagePresenterExclModeConfig_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVMRImagePresenterExclModeConfig_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_Release(This) (This)->lpVtbl -> Release(This)
#define IVMRImagePresenterExclModeConfig_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_SetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> SetRenderingPrefs(This,dwRenderFlags)
#define IVMRImagePresenterExclModeConfig_SetRenderingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_GetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> GetRenderingPrefs(This,dwRenderFlags)
#define IVMRImagePresenterExclModeConfig_GetRenderingPrefs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_SetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf) (This)->lpVtbl -> SetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf)
#define IVMRImagePresenterExclModeConfig_SetXlcModeDDObjAndPrimarySurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_GetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf) (This)->lpVtbl -> GetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf)
#define IVMRImagePresenterExclModeConfig_GetXlcModeDDObjAndPrimarySurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IVPManager_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IVPManager_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_Release(This) (This)->lpVtbl -> Release(This)
#define IVPManager_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_SetVideoPortIndex(This,dwVideoPortIndex) (This)->lpVtbl -> SetVideoPortIndex(This,dwVideoPortIndex)
#define IVPManager_SetVideoPortIndex
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_GetVideoPortIndex(This,pdwVideoPortIndex) (This)->lpVtbl -> GetVideoPortIndex(This,pdwVideoPortIndex)
#define IVPManager_GetVideoPortIndex
#define _BDATYPES_
#define MIN_DIMENSION
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define V1_ENUM [v1_enum]
#define V1_ENUM
#define V1_ENUM
#define BDA_FREQUENCY_NOT_SET
#define BDA_FREQUENCY_NOT_DEFINED
#define BDA_RANGE_NOT_SET
#define BDA_RANGE_NOT_DEFINED
#define BDA_CHAN_BANDWITH_NOT_SET
#define BDA_CHAN_BANDWITH_NOT_DEFINED
#define BDA_FREQUENCY_MULTIPLIER_NOT_SET
#define BDA_FREQUENCY_MULTIPLIER_NOT_DEFINED
#define __REQUIRED_RPCNDR_H_VERSION__
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ICreatePropBagOnRegKey_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ICreatePropBagOnRegKey_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_Release(This) (This)->lpVtbl -> Release(This)
#define ICreatePropBagOnRegKey_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_Create(This,hkey,subkey,ulOptions,samDesired,iid,ppBag) (This)->lpVtbl -> Create(This,hkey,subkey,ulOptions,samDesired,iid,ppBag)
#define ICreatePropBagOnRegKey_Create
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ITuningSpaces_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ITuningSpaces_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_Release(This) (This)->lpVtbl -> Release(This)
#define ITuningSpaces_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define ITuningSpaces_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define ITuningSpaces_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define ITuningSpaces_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define ITuningSpaces_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
#define ITuningSpaces_get_Count
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get__NewEnum(This,NewEnum) (This)->lpVtbl -> get__NewEnum(This,NewEnum)
#define ITuningSpaces_get__NewEnum
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get_Item(This,varIndex,TuningSpace) (This)->lpVtbl -> get_Item(This,varIndex,TuningSpace)
#define ITuningSpaces_get_Item
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get_EnumTuningSpaces(This,NewEnum) (This)->lpVtbl -> get_EnumTuningSpaces(This,NewEnum)
#define ITuningSpaces_get_EnumTuningSpaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ITuningSpaceContainer_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ITuningSpaceContainer_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Release(This) (This)->lpVtbl -> Release(This)
#define ITuningSpaceContainer_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define ITuningSpaceContainer_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define ITuningSpaceContainer_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define ITuningSpaceContainer_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define ITuningSpaceContainer_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
#define ITuningSpaceContainer_get_Count
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get__NewEnum(This,NewEnum) (This)->lpVtbl -> get__NewEnum(This,NewEnum)
#define ITuningSpaceContainer_get__NewEnum
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_Item(This,varIndex,TuningSpace) (This)->lpVtbl -> get_Item(This,varIndex,TuningSpace)
#define ITuningSpaceContainer_get_Item
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_put_Item(This,varIndex,TuningSpace) (This)->lpVtbl -> put_Item(This,varIndex,TuningSpace)
#define ITuningSpaceContainer_put_Item
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_TuningSpacesForCLSID(This,SpaceCLSID,NewColl) (This)->lpVtbl -> TuningSpacesForCLSID(This,SpaceCLSID,NewColl)
#define ITuningSpaceContainer_TuningSpacesForCLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer__TuningSpacesForCLSID(This,SpaceCLSID,NewColl) (This)->lpVtbl -> _TuningSpacesForCLSID(This,SpaceCLSID,NewColl)
#define ITuningSpaceContainer__TuningSpacesForCLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_TuningSpacesForName(This,Name,NewColl) (This)->lpVtbl -> TuningSpacesForName(This,Name,NewColl)
#define ITuningSpaceContainer_TuningSpacesForName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_FindID(This,TuningSpace,ID) (This)->lpVtbl -> FindID(This,TuningSpace,ID)
#define ITuningSpaceContainer_FindID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Add(This,TuningSpace,NewIndex) (This)->lpVtbl -> Add(This,TuningSpace,NewIndex)
#define ITuningSpaceContainer_Add
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_EnumTuningSpaces(This,ppEnum) (This)->lpVtbl -> get_EnumTuningSpaces(This,ppEnum)
#define ITuningSpaceContainer_get_EnumTuningSpaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Remove(This,Index) (This)->lpVtbl -> Remove(This,Index)
#define ITuningSpaceContainer_Remove
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_MaxCount(This,MaxCount) (This)->lpVtbl -> get_MaxCount(This,MaxCount)
#define ITuningSpaceContainer_get_MaxCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_put_MaxCount(This,MaxCount) (This)->lpVtbl -> put_MaxCount(This,MaxCount)
#define ITuningSpaceContainer_put_MaxCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ITuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ITuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define ITuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define ITuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define ITuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define ITuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define ITuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define ITuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define ITuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define ITuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define ITuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define ITuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define ITuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define ITuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define ITuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define ITuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define ITuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define ITuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define ITuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define ITuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define ITuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define ITuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define ITuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define ITuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define ITuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define ITuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumTuningSpaces_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumTuningSpaces_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumTuningSpaces_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Next(This,celt,rgelt,pceltFetched) (This)->lpVtbl -> Next(This,celt,rgelt,pceltFetched)
#define IEnumTuningSpaces_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Skip(This,celt) (This)->lpVtbl -> Skip(This,celt)
#define IEnumTuningSpaces_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumTuningSpaces_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumTuningSpaces_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBTuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBTuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBTuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBTuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBTuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBTuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBTuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IDVBTuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IDVBTuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IDVBTuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IDVBTuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IDVBTuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IDVBTuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IDVBTuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IDVBTuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IDVBTuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IDVBTuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IDVBTuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IDVBTuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IDVBTuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IDVBTuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IDVBTuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_SystemType(This,SysType) (This)->lpVtbl -> get_SystemType(This,SysType)
#define IDVBTuningSpace_get_SystemType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_SystemType(This,SysType) (This)->lpVtbl -> put_SystemType(This,SysType)
#define IDVBTuningSpace_put_SystemType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBTuningSpace2_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBTuningSpace2_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBTuningSpace2_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBTuningSpace2_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBTuningSpace2_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBTuningSpace2_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBTuningSpace2_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IDVBTuningSpace2_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IDVBTuningSpace2_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IDVBTuningSpace2_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IDVBTuningSpace2_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IDVBTuningSpace2_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace2_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace2_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace2_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IDVBTuningSpace2_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IDVBTuningSpace2_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IDVBTuningSpace2_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IDVBTuningSpace2_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IDVBTuningSpace2_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IDVBTuningSpace2_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IDVBTuningSpace2_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IDVBTuningSpace2_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IDVBTuningSpace2_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IDVBTuningSpace2_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IDVBTuningSpace2_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_SystemType(This,SysType) (This)->lpVtbl -> get_SystemType(This,SysType)
#define IDVBTuningSpace2_get_SystemType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_SystemType(This,SysType) (This)->lpVtbl -> put_SystemType(This,SysType)
#define IDVBTuningSpace2_put_SystemType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_NetworkID(This,NetworkID) (This)->lpVtbl -> get_NetworkID(This,NetworkID)
#define IDVBTuningSpace2_get_NetworkID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_NetworkID(This,NetworkID) (This)->lpVtbl -> put_NetworkID(This,NetworkID)
#define IDVBTuningSpace2_put_NetworkID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBSTuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBSTuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBSTuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBSTuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBSTuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBSTuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBSTuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IDVBSTuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IDVBSTuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IDVBSTuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IDVBSTuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IDVBSTuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IDVBSTuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IDVBSTuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IDVBSTuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IDVBSTuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IDVBSTuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IDVBSTuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IDVBSTuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IDVBSTuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IDVBSTuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IDVBSTuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IDVBSTuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IDVBSTuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IDVBSTuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IDVBSTuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_SystemType(This,SysType) (This)->lpVtbl -> get_SystemType(This,SysType)
#define IDVBSTuningSpace_get_SystemType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_SystemType(This,SysType) (This)->lpVtbl -> put_SystemType(This,SysType)
#define IDVBSTuningSpace_put_SystemType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_NetworkID(This,NetworkID) (This)->lpVtbl -> get_NetworkID(This,NetworkID)
#define IDVBSTuningSpace_get_NetworkID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_NetworkID(This,NetworkID) (This)->lpVtbl -> put_NetworkID(This,NetworkID)
#define IDVBSTuningSpace_put_NetworkID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_LowOscillator(This,LowOscillator) (This)->lpVtbl -> get_LowOscillator(This,LowOscillator)
#define IDVBSTuningSpace_get_LowOscillator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_LowOscillator(This,LowOscillator) (This)->lpVtbl -> put_LowOscillator(This,LowOscillator)
#define IDVBSTuningSpace_put_LowOscillator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_HighOscillator(This,HighOscillator) (This)->lpVtbl -> get_HighOscillator(This,HighOscillator)
#define IDVBSTuningSpace_get_HighOscillator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_HighOscillator(This,HighOscillator) (This)->lpVtbl -> put_HighOscillator(This,HighOscillator)
#define IDVBSTuningSpace_put_HighOscillator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_LNBSwitch(This,LNBSwitch) (This)->lpVtbl -> get_LNBSwitch(This,LNBSwitch)
#define IDVBSTuningSpace_get_LNBSwitch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_LNBSwitch(This,LNBSwitch) (This)->lpVtbl -> put_LNBSwitch(This,LNBSwitch)
#define IDVBSTuningSpace_put_LNBSwitch
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_InputRange(This,InputRange) (This)->lpVtbl -> get_InputRange(This,InputRange)
#define IDVBSTuningSpace_get_InputRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_InputRange(This,InputRange) (This)->lpVtbl -> put_InputRange(This,InputRange)
#define IDVBSTuningSpace_put_InputRange
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_SpectralInversion(This,SpectralInversionVal) (This)->lpVtbl -> get_SpectralInversion(This,SpectralInversionVal)
#define IDVBSTuningSpace_get_SpectralInversion
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_SpectralInversion(This,SpectralInversionVal) (This)->lpVtbl -> put_SpectralInversion(This,SpectralInversionVal)
#define IDVBSTuningSpace_put_SpectralInversion
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAuxInTuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAuxInTuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define IAuxInTuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IAuxInTuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IAuxInTuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IAuxInTuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IAuxInTuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IAuxInTuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IAuxInTuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IAuxInTuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IAuxInTuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IAuxInTuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IAuxInTuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IAuxInTuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IAuxInTuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IAuxInTuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IAuxInTuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IAuxInTuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IAuxInTuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IAuxInTuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IAuxInTuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IAuxInTuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IAuxInTuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IAuxInTuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IAuxInTuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IAuxInTuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAnalogTVTuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAnalogTVTuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define IAnalogTVTuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IAnalogTVTuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IAnalogTVTuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IAnalogTVTuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IAnalogTVTuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IAnalogTVTuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IAnalogTVTuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IAnalogTVTuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IAnalogTVTuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IAnalogTVTuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IAnalogTVTuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IAnalogTVTuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IAnalogTVTuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IAnalogTVTuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IAnalogTVTuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IAnalogTVTuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IAnalogTVTuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IAnalogTVTuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IAnalogTVTuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IAnalogTVTuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IAnalogTVTuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IAnalogTVTuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IAnalogTVTuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IAnalogTVTuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_MinChannel(This,MinChannelVal) (This)->lpVtbl -> get_MinChannel(This,MinChannelVal)
#define IAnalogTVTuningSpace_get_MinChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_MinChannel(This,NewMinChannelVal) (This)->lpVtbl -> put_MinChannel(This,NewMinChannelVal)
#define IAnalogTVTuningSpace_put_MinChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_MaxChannel(This,MaxChannelVal) (This)->lpVtbl -> get_MaxChannel(This,MaxChannelVal)
#define IAnalogTVTuningSpace_get_MaxChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_MaxChannel(This,NewMaxChannelVal) (This)->lpVtbl -> put_MaxChannel(This,NewMaxChannelVal)
#define IAnalogTVTuningSpace_put_MaxChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_InputType(This,InputTypeVal) (This)->lpVtbl -> get_InputType(This,InputTypeVal)
#define IAnalogTVTuningSpace_get_InputType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_InputType(This,NewInputTypeVal) (This)->lpVtbl -> put_InputType(This,NewInputTypeVal)
#define IAnalogTVTuningSpace_put_InputType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_CountryCode(This,CountryCodeVal) (This)->lpVtbl -> get_CountryCode(This,CountryCodeVal)
#define IAnalogTVTuningSpace_get_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_CountryCode(This,NewCountryCodeVal) (This)->lpVtbl -> put_CountryCode(This,NewCountryCodeVal)
#define IAnalogTVTuningSpace_put_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IATSCTuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IATSCTuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define IATSCTuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IATSCTuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IATSCTuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IATSCTuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IATSCTuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IATSCTuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IATSCTuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IATSCTuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IATSCTuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IATSCTuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IATSCTuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IATSCTuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IATSCTuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IATSCTuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IATSCTuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IATSCTuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IATSCTuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IATSCTuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IATSCTuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IATSCTuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IATSCTuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IATSCTuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IATSCTuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IATSCTuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MinChannel(This,MinChannelVal) (This)->lpVtbl -> get_MinChannel(This,MinChannelVal)
#define IATSCTuningSpace_get_MinChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MinChannel(This,NewMinChannelVal) (This)->lpVtbl -> put_MinChannel(This,NewMinChannelVal)
#define IATSCTuningSpace_put_MinChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MaxChannel(This,MaxChannelVal) (This)->lpVtbl -> get_MaxChannel(This,MaxChannelVal)
#define IATSCTuningSpace_get_MaxChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MaxChannel(This,NewMaxChannelVal) (This)->lpVtbl -> put_MaxChannel(This,NewMaxChannelVal)
#define IATSCTuningSpace_put_MaxChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_InputType(This,InputTypeVal) (This)->lpVtbl -> get_InputType(This,InputTypeVal)
#define IATSCTuningSpace_get_InputType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_InputType(This,NewInputTypeVal) (This)->lpVtbl -> put_InputType(This,NewInputTypeVal)
#define IATSCTuningSpace_put_InputType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_CountryCode(This,CountryCodeVal) (This)->lpVtbl -> get_CountryCode(This,CountryCodeVal)
#define IATSCTuningSpace_get_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_CountryCode(This,NewCountryCodeVal) (This)->lpVtbl -> put_CountryCode(This,NewCountryCodeVal)
#define IATSCTuningSpace_put_CountryCode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MinMinorChannel(This,MinMinorChannelVal) (This)->lpVtbl -> get_MinMinorChannel(This,MinMinorChannelVal)
#define IATSCTuningSpace_get_MinMinorChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MinMinorChannel(This,NewMinMinorChannelVal) (This)->lpVtbl -> put_MinMinorChannel(This,NewMinMinorChannelVal)
#define IATSCTuningSpace_put_MinMinorChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MaxMinorChannel(This,MaxMinorChannelVal) (This)->lpVtbl -> get_MaxMinorChannel(This,MaxMinorChannelVal)
#define IATSCTuningSpace_get_MaxMinorChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MaxMinorChannel(This,NewMaxMinorChannelVal) (This)->lpVtbl -> put_MaxMinorChannel(This,NewMaxMinorChannelVal)
#define IATSCTuningSpace_put_MaxMinorChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MinPhysicalChannel(This,MinPhysicalChannelVal) (This)->lpVtbl -> get_MinPhysicalChannel(This,MinPhysicalChannelVal)
#define IATSCTuningSpace_get_MinPhysicalChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MinPhysicalChannel(This,NewMinPhysicalChannelVal) (This)->lpVtbl -> put_MinPhysicalChannel(This,NewMinPhysicalChannelVal)
#define IATSCTuningSpace_put_MinPhysicalChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MaxPhysicalChannel(This,MaxPhysicalChannelVal) (This)->lpVtbl -> get_MaxPhysicalChannel(This,MaxPhysicalChannelVal)
#define IATSCTuningSpace_get_MaxPhysicalChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MaxPhysicalChannel(This,NewMaxPhysicalChannelVal) (This)->lpVtbl -> put_MaxPhysicalChannel(This,NewMaxPhysicalChannelVal)
#define IATSCTuningSpace_put_MaxPhysicalChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IAnalogRadioTuningSpace_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IAnalogRadioTuningSpace_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
#define IAnalogRadioTuningSpace_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IAnalogRadioTuningSpace_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IAnalogRadioTuningSpace_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IAnalogRadioTuningSpace_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IAnalogRadioTuningSpace_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
#define IAnalogRadioTuningSpace_get_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
#define IAnalogRadioTuningSpace_put_UniqueName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
#define IAnalogRadioTuningSpace_get_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
#define IAnalogRadioTuningSpace_put_FriendlyName
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
#define IAnalogRadioTuningSpace_get_CLSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
#define IAnalogRadioTuningSpace_get_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
#define IAnalogRadioTuningSpace_put_NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
#define IAnalogRadioTuningSpace_get__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
#define IAnalogRadioTuningSpace_put__NetworkType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
#define IAnalogRadioTuningSpace_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
#define IAnalogRadioTuningSpace_EnumCategoryGUIDs
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
#define IAnalogRadioTuningSpace_EnumDeviceMonikers
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
#define IAnalogRadioTuningSpace_get_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
#define IAnalogRadioTuningSpace_put_DefaultPreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
#define IAnalogRadioTuningSpace_get_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
#define IAnalogRadioTuningSpace_put_FrequencyMapping
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
#define IAnalogRadioTuningSpace_get_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
#define IAnalogRadioTuningSpace_put_DefaultLocator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
#define IAnalogRadioTuningSpace_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_MinFrequency(This,MinFrequencyVal) (This)->lpVtbl -> get_MinFrequency(This,MinFrequencyVal)
#define IAnalogRadioTuningSpace_get_MinFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_MinFrequency(This,NewMinFrequencyVal) (This)->lpVtbl -> put_MinFrequency(This,NewMinFrequencyVal)
#define IAnalogRadioTuningSpace_put_MinFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_MaxFrequency(This,MaxFrequencyVal) (This)->lpVtbl -> get_MaxFrequency(This,MaxFrequencyVal)
#define IAnalogRadioTuningSpace_get_MaxFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_MaxFrequency(This,NewMaxFrequencyVal) (This)->lpVtbl -> put_MaxFrequency(This,NewMaxFrequencyVal)
#define IAnalogRadioTuningSpace_put_MaxFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_Step(This,StepVal) (This)->lpVtbl -> get_Step(This,StepVal)
#define IAnalogRadioTuningSpace_get_Step
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_Step(This,NewStepVal) (This)->lpVtbl -> put_Step(This,NewStepVal)
#define IAnalogRadioTuningSpace_put_Step
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ITuneRequest_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ITuneRequest_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_Release(This) (This)->lpVtbl -> Release(This)
#define ITuneRequest_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define ITuneRequest_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define ITuneRequest_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define ITuneRequest_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define ITuneRequest_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define ITuneRequest_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
#define ITuneRequest_get_Components
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
#define ITuneRequest_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
#define ITuneRequest_get_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
#define ITuneRequest_put_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IChannelTuneRequest_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IChannelTuneRequest_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_Release(This) (This)->lpVtbl -> Release(This)
#define IChannelTuneRequest_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IChannelTuneRequest_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IChannelTuneRequest_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IChannelTuneRequest_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IChannelTuneRequest_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define IChannelTuneRequest_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
#define IChannelTuneRequest_get_Components
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
#define IChannelTuneRequest_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
#define IChannelTuneRequest_get_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
#define IChannelTuneRequest_put_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_Channel(This,Channel) (This)->lpVtbl -> get_Channel(This,Channel)
#define IChannelTuneRequest_get_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_put_Channel(This,Channel) (This)->lpVtbl -> put_Channel(This,Channel)
#define IChannelTuneRequest_put_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IATSCChannelTuneRequest_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IATSCChannelTuneRequest_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_Release(This) (This)->lpVtbl -> Release(This)
#define IATSCChannelTuneRequest_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IATSCChannelTuneRequest_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IATSCChannelTuneRequest_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IATSCChannelTuneRequest_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IATSCChannelTuneRequest_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define IATSCChannelTuneRequest_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
#define IATSCChannelTuneRequest_get_Components
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
#define IATSCChannelTuneRequest_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
#define IATSCChannelTuneRequest_get_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
#define IATSCChannelTuneRequest_put_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_Channel(This,Channel) (This)->lpVtbl -> get_Channel(This,Channel)
#define IATSCChannelTuneRequest_get_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_put_Channel(This,Channel) (This)->lpVtbl -> put_Channel(This,Channel)
#define IATSCChannelTuneRequest_put_Channel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_MinorChannel(This,MinorChannel) (This)->lpVtbl -> get_MinorChannel(This,MinorChannel)
#define IATSCChannelTuneRequest_get_MinorChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_put_MinorChannel(This,MinorChannel) (This)->lpVtbl -> put_MinorChannel(This,MinorChannel)
#define IATSCChannelTuneRequest_put_MinorChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBTuneRequest_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBTuneRequest_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBTuneRequest_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBTuneRequest_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBTuneRequest_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBTuneRequest_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBTuneRequest_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define IDVBTuneRequest_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
#define IDVBTuneRequest_get_Components
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
#define IDVBTuneRequest_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
#define IDVBTuneRequest_get_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
#define IDVBTuneRequest_put_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_ONID(This,ONID) (This)->lpVtbl -> get_ONID(This,ONID)
#define IDVBTuneRequest_get_ONID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_ONID(This,ONID) (This)->lpVtbl -> put_ONID(This,ONID)
#define IDVBTuneRequest_put_ONID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_TSID(This,TSID) (This)->lpVtbl -> get_TSID(This,TSID)
#define IDVBTuneRequest_get_TSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_TSID(This,TSID) (This)->lpVtbl -> put_TSID(This,TSID)
#define IDVBTuneRequest_put_TSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_SID(This,SID) (This)->lpVtbl -> get_SID(This,SID)
#define IDVBTuneRequest_get_SID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_SID(This,SID) (This)->lpVtbl -> put_SID(This,SID)
#define IDVBTuneRequest_put_SID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMPEG2TuneRequest_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMPEG2TuneRequest_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_Release(This) (This)->lpVtbl -> Release(This)
#define IMPEG2TuneRequest_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IMPEG2TuneRequest_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IMPEG2TuneRequest_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IMPEG2TuneRequest_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IMPEG2TuneRequest_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define IMPEG2TuneRequest_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
#define IMPEG2TuneRequest_get_Components
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
#define IMPEG2TuneRequest_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
#define IMPEG2TuneRequest_get_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
#define IMPEG2TuneRequest_put_Locator
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_TSID(This,TSID) (This)->lpVtbl -> get_TSID(This,TSID)
#define IMPEG2TuneRequest_get_TSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_put_TSID(This,TSID) (This)->lpVtbl -> put_TSID(This,TSID)
#define IMPEG2TuneRequest_put_TSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_ProgNo(This,ProgNo) (This)->lpVtbl -> get_ProgNo(This,ProgNo)
#define IMPEG2TuneRequest_get_ProgNo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_put_ProgNo(This,ProgNo) (This)->lpVtbl -> put_ProgNo(This,ProgNo)
#define IMPEG2TuneRequest_put_ProgNo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMPEG2TuneRequestFactory_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMPEG2TuneRequestFactory_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_Release(This) (This)->lpVtbl -> Release(This)
#define IMPEG2TuneRequestFactory_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IMPEG2TuneRequestFactory_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IMPEG2TuneRequestFactory_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IMPEG2TuneRequestFactory_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IMPEG2TuneRequestFactory_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_CreateTuneRequest(This,TuningSpace,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuningSpace,TuneRequest)
#define IMPEG2TuneRequestFactory_CreateTuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestSupport_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMPEG2TuneRequestSupport_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestSupport_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMPEG2TuneRequestSupport_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestSupport_Release(This) (This)->lpVtbl -> Release(This)
#define IMPEG2TuneRequestSupport_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ITuner_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ITuner_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_Release(This) (This)->lpVtbl -> Release(This)
#define ITuner_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define ITuner_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_put_TuningSpace(This,TuningSpace) (This)->lpVtbl -> put_TuningSpace(This,TuningSpace)
#define ITuner_put_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_EnumTuningSpaces(This,ppEnum) (This)->lpVtbl -> EnumTuningSpaces(This,ppEnum)
#define ITuner_EnumTuningSpaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_TuneRequest(This,TuneRequest) (This)->lpVtbl -> get_TuneRequest(This,TuneRequest)
#define ITuner_get_TuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_put_TuneRequest(This,TuneRequest) (This)->lpVtbl -> put_TuneRequest(This,TuneRequest)
#define ITuner_put_TuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_Validate(This,TuneRequest) (This)->lpVtbl -> Validate(This,TuneRequest)
#define ITuner_Validate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_PreferredComponentTypes(This,ComponentTypes)
#define ITuner_get_PreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_put_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> put_PreferredComponentTypes(This,ComponentTypes)
#define ITuner_put_PreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_SignalStrength(This,Strength) (This)->lpVtbl -> get_SignalStrength(This,Strength)
#define ITuner_get_SignalStrength
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_TriggerSignalEvents(This,Interval) (This)->lpVtbl -> TriggerSignalEvents(This,Interval)
#define ITuner_TriggerSignalEvents
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IScanningTuner_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IScanningTuner_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_Release(This) (This)->lpVtbl -> Release(This)
#define IScanningTuner_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
#define IScanningTuner_get_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_put_TuningSpace(This,TuningSpace) (This)->lpVtbl -> put_TuningSpace(This,TuningSpace)
#define IScanningTuner_put_TuningSpace
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_EnumTuningSpaces(This,ppEnum) (This)->lpVtbl -> EnumTuningSpaces(This,ppEnum)
#define IScanningTuner_EnumTuningSpaces
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_TuneRequest(This,TuneRequest) (This)->lpVtbl -> get_TuneRequest(This,TuneRequest)
#define IScanningTuner_get_TuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_put_TuneRequest(This,TuneRequest) (This)->lpVtbl -> put_TuneRequest(This,TuneRequest)
#define IScanningTuner_put_TuneRequest
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_Validate(This,TuneRequest) (This)->lpVtbl -> Validate(This,TuneRequest)
#define IScanningTuner_Validate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_PreferredComponentTypes(This,ComponentTypes)
#define IScanningTuner_get_PreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_put_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> put_PreferredComponentTypes(This,ComponentTypes)
#define IScanningTuner_put_PreferredComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_SignalStrength(This,Strength) (This)->lpVtbl -> get_SignalStrength(This,Strength)
#define IScanningTuner_get_SignalStrength
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_TriggerSignalEvents(This,Interval) (This)->lpVtbl -> TriggerSignalEvents(This,Interval)
#define IScanningTuner_TriggerSignalEvents
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_SeekUp(This) (This)->lpVtbl -> SeekUp(This)
#define IScanningTuner_SeekUp
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_SeekDown(This) (This)->lpVtbl -> SeekDown(This)
#define IScanningTuner_SeekDown
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_ScanUp(This,MillisecondsPause) (This)->lpVtbl -> ScanUp(This,MillisecondsPause)
#define IScanningTuner_ScanUp
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_ScanDown(This,MillisecondsPause) (This)->lpVtbl -> ScanDown(This,MillisecondsPause)
#define IScanningTuner_ScanDown
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_AutoProgram(This) (This)->lpVtbl -> AutoProgram(This)
#define IScanningTuner_AutoProgram
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IComponentType_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IComponentType_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_Release(This) (This)->lpVtbl -> Release(This)
#define IComponentType_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IComponentType_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IComponentType_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IComponentType_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IComponentType_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
#define IComponentType_get_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
#define IComponentType_put_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
#define IComponentType_get_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
#define IComponentType_put_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
#define IComponentType_get__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
#define IComponentType_put__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
#define IComponentType_get_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
#define IComponentType_put_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
#define IComponentType_get__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
#define IComponentType_put__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
#define IComponentType_get_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
#define IComponentType_put_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
#define IComponentType_get__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
#define IComponentType_put__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
#define IComponentType_get_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
#define IComponentType_put_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
#define IComponentType_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ILanguageComponentType_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ILanguageComponentType_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_Release(This) (This)->lpVtbl -> Release(This)
#define ILanguageComponentType_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define ILanguageComponentType_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define ILanguageComponentType_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define ILanguageComponentType_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define ILanguageComponentType_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
#define ILanguageComponentType_get_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
#define ILanguageComponentType_put_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
#define ILanguageComponentType_get_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
#define ILanguageComponentType_put_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
#define ILanguageComponentType_get__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
#define ILanguageComponentType_put__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
#define ILanguageComponentType_get_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
#define ILanguageComponentType_put_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
#define ILanguageComponentType_get__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
#define ILanguageComponentType_put__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
#define ILanguageComponentType_get_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
#define ILanguageComponentType_put_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
#define ILanguageComponentType_get__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
#define ILanguageComponentType_put__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
#define ILanguageComponentType_get_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
#define ILanguageComponentType_put_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
#define ILanguageComponentType_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_LangID(This,LangID) (This)->lpVtbl -> get_LangID(This,LangID)
#define ILanguageComponentType_get_LangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_LangID(This,LangID) (This)->lpVtbl -> put_LangID(This,LangID)
#define ILanguageComponentType_put_LangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMPEG2ComponentType_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMPEG2ComponentType_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_Release(This) (This)->lpVtbl -> Release(This)
#define IMPEG2ComponentType_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IMPEG2ComponentType_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IMPEG2ComponentType_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IMPEG2ComponentType_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IMPEG2ComponentType_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
#define IMPEG2ComponentType_get_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
#define IMPEG2ComponentType_put_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
#define IMPEG2ComponentType_get_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
#define IMPEG2ComponentType_put_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
#define IMPEG2ComponentType_get__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
#define IMPEG2ComponentType_put__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
#define IMPEG2ComponentType_get_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
#define IMPEG2ComponentType_put_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
#define IMPEG2ComponentType_get__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
#define IMPEG2ComponentType_put__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
#define IMPEG2ComponentType_get_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
#define IMPEG2ComponentType_put_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
#define IMPEG2ComponentType_get__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
#define IMPEG2ComponentType_put__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
#define IMPEG2ComponentType_get_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
#define IMPEG2ComponentType_put_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
#define IMPEG2ComponentType_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_LangID(This,LangID) (This)->lpVtbl -> get_LangID(This,LangID)
#define IMPEG2ComponentType_get_LangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_LangID(This,LangID) (This)->lpVtbl -> put_LangID(This,LangID)
#define IMPEG2ComponentType_put_LangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_StreamType(This,MP2StreamType) (This)->lpVtbl -> get_StreamType(This,MP2StreamType)
#define IMPEG2ComponentType_get_StreamType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_StreamType(This,MP2StreamType) (This)->lpVtbl -> put_StreamType(This,MP2StreamType)
#define IMPEG2ComponentType_put_StreamType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IATSCComponentType_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IATSCComponentType_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_Release(This) (This)->lpVtbl -> Release(This)
#define IATSCComponentType_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IATSCComponentType_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IATSCComponentType_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IATSCComponentType_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IATSCComponentType_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
#define IATSCComponentType_get_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
#define IATSCComponentType_put_Category
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
#define IATSCComponentType_get_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
#define IATSCComponentType_put_MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
#define IATSCComponentType_get__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
#define IATSCComponentType_put__MediaMajorType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
#define IATSCComponentType_get_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
#define IATSCComponentType_put_MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
#define IATSCComponentType_get__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
#define IATSCComponentType_put__MediaSubType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
#define IATSCComponentType_get_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
#define IATSCComponentType_put_MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
#define IATSCComponentType_get__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
#define IATSCComponentType_put__MediaFormatType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
#define IATSCComponentType_get_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
#define IATSCComponentType_put_MediaType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
#define IATSCComponentType_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_LangID(This,LangID) (This)->lpVtbl -> get_LangID(This,LangID)
#define IATSCComponentType_get_LangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_LangID(This,LangID) (This)->lpVtbl -> put_LangID(This,LangID)
#define IATSCComponentType_put_LangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_StreamType(This,MP2StreamType) (This)->lpVtbl -> get_StreamType(This,MP2StreamType)
#define IATSCComponentType_get_StreamType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_StreamType(This,MP2StreamType) (This)->lpVtbl -> put_StreamType(This,MP2StreamType)
#define IATSCComponentType_put_StreamType
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_Flags(This,Flags) (This)->lpVtbl -> get_Flags(This,Flags)
#define IATSCComponentType_get_Flags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_Flags(This,flags) (This)->lpVtbl -> put_Flags(This,flags)
#define IATSCComponentType_put_Flags
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumComponentTypes_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumComponentTypes_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumComponentTypes_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Next(This,celt,rgelt,pceltFetched) (This)->lpVtbl -> Next(This,celt,rgelt,pceltFetched)
#define IEnumComponentTypes_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Skip(This,celt) (This)->lpVtbl -> Skip(This,celt)
#define IEnumComponentTypes_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumComponentTypes_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumComponentTypes_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IComponentTypes_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IComponentTypes_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Release(This) (This)->lpVtbl -> Release(This)
#define IComponentTypes_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IComponentTypes_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IComponentTypes_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IComponentTypes_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IComponentTypes_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
#define IComponentTypes_get_Count
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_get__NewEnum(This,ppNewEnum) (This)->lpVtbl -> get__NewEnum(This,ppNewEnum)
#define IComponentTypes_get__NewEnum
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_EnumComponentTypes(This,ppNewEnum) (This)->lpVtbl -> EnumComponentTypes(This,ppNewEnum)
#define IComponentTypes_EnumComponentTypes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_get_Item(This,Index,ComponentType) (This)->lpVtbl -> get_Item(This,Index,ComponentType)
#define IComponentTypes_get_Item
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_put_Item(This,Index,ComponentType) (This)->lpVtbl -> put_Item(This,Index,ComponentType)
#define IComponentTypes_put_Item
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Add(This,ComponentType,NewIndex) (This)->lpVtbl -> Add(This,ComponentType,NewIndex)
#define IComponentTypes_Add
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Remove(This,Index) (This)->lpVtbl -> Remove(This,Index)
#define IComponentTypes_Remove
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Clone(This,NewList) (This)->lpVtbl -> Clone(This,NewList)
#define IComponentTypes_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IComponent_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IComponent_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_Release(This) (This)->lpVtbl -> Release(This)
#define IComponent_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IComponent_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IComponent_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IComponent_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IComponent_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_Type(This,CT) (This)->lpVtbl -> get_Type(This,CT)
#define IComponent_get_Type
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_Type(This,CT) (This)->lpVtbl -> put_Type(This,CT)
#define IComponent_put_Type
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_DescLangID(This,LangID) (This)->lpVtbl -> get_DescLangID(This,LangID)
#define IComponent_get_DescLangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_DescLangID(This,LangID) (This)->lpVtbl -> put_DescLangID(This,LangID)
#define IComponent_put_DescLangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_Status(This,Status) (This)->lpVtbl -> get_Status(This,Status)
#define IComponent_get_Status
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_Status(This,Status) (This)->lpVtbl -> put_Status(This,Status)
#define IComponent_put_Status
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_Description(This,Description) (This)->lpVtbl -> get_Description(This,Description)
#define IComponent_get_Description
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_Description(This,Description) (This)->lpVtbl -> put_Description(This,Description)
#define IComponent_put_Description
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_Clone(This,NewComponent) (This)->lpVtbl -> Clone(This,NewComponent)
#define IComponent_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IMPEG2Component_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IMPEG2Component_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_Release(This) (This)->lpVtbl -> Release(This)
#define IMPEG2Component_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IMPEG2Component_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IMPEG2Component_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IMPEG2Component_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IMPEG2Component_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_Type(This,CT) (This)->lpVtbl -> get_Type(This,CT)
#define IMPEG2Component_get_Type
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_Type(This,CT) (This)->lpVtbl -> put_Type(This,CT)
#define IMPEG2Component_put_Type
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_DescLangID(This,LangID) (This)->lpVtbl -> get_DescLangID(This,LangID)
#define IMPEG2Component_get_DescLangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_DescLangID(This,LangID) (This)->lpVtbl -> put_DescLangID(This,LangID)
#define IMPEG2Component_put_DescLangID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_Status(This,Status) (This)->lpVtbl -> get_Status(This,Status)
#define IMPEG2Component_get_Status
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_Status(This,Status) (This)->lpVtbl -> put_Status(This,Status)
#define IMPEG2Component_put_Status
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_Description(This,Description) (This)->lpVtbl -> get_Description(This,Description)
#define IMPEG2Component_get_Description
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_Description(This,Description) (This)->lpVtbl -> put_Description(This,Description)
#define IMPEG2Component_put_Description
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_Clone(This,NewComponent) (This)->lpVtbl -> Clone(This,NewComponent)
#define IMPEG2Component_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_PID(This,PID) (This)->lpVtbl -> get_PID(This,PID)
#define IMPEG2Component_get_PID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_PID(This,PID) (This)->lpVtbl -> put_PID(This,PID)
#define IMPEG2Component_put_PID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_PCRPID(This,PCRPID) (This)->lpVtbl -> get_PCRPID(This,PCRPID)
#define IMPEG2Component_get_PCRPID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_PCRPID(This,PCRPID) (This)->lpVtbl -> put_PCRPID(This,PCRPID)
#define IMPEG2Component_put_PCRPID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_ProgramNumber(This,ProgramNumber) (This)->lpVtbl -> get_ProgramNumber(This,ProgramNumber)
#define IMPEG2Component_get_ProgramNumber
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_ProgramNumber(This,ProgramNumber) (This)->lpVtbl -> put_ProgramNumber(This,ProgramNumber)
#define IMPEG2Component_put_ProgramNumber
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IEnumComponents_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IEnumComponents_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Release(This) (This)->lpVtbl -> Release(This)
#define IEnumComponents_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Next(This,celt,rgelt,pceltFetched) (This)->lpVtbl -> Next(This,celt,rgelt,pceltFetched)
#define IEnumComponents_Next
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Skip(This,celt) (This)->lpVtbl -> Skip(This,celt)
#define IEnumComponents_Skip
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Reset(This) (This)->lpVtbl -> Reset(This)
#define IEnumComponents_Reset
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
#define IEnumComponents_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IComponents_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IComponents_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Release(This) (This)->lpVtbl -> Release(This)
#define IComponents_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IComponents_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IComponents_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IComponents_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IComponents_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
#define IComponents_get_Count
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_get__NewEnum(This,ppNewEnum) (This)->lpVtbl -> get__NewEnum(This,ppNewEnum)
#define IComponents_get__NewEnum
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_EnumComponents(This,ppNewEnum) (This)->lpVtbl -> EnumComponents(This,ppNewEnum)
#define IComponents_EnumComponents
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_get_Item(This,Index,ppComponent) (This)->lpVtbl -> get_Item(This,Index,ppComponent)
#define IComponents_get_Item
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Add(This,Component,NewIndex) (This)->lpVtbl -> Add(This,Component,NewIndex)
#define IComponents_Add
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Remove(This,Index) (This)->lpVtbl -> Remove(This,Index)
#define IComponents_Remove
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Clone(This,NewList) (This)->lpVtbl -> Clone(This,NewList)
#define IComponents_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define ILocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define ILocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_Release(This) (This)->lpVtbl -> Release(This)
#define ILocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define ILocator_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define ILocator_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define ILocator_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define ILocator_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
#define ILocator_get_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
#define ILocator_put_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
#define ILocator_get_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
#define ILocator_put_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
#define ILocator_get_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
#define ILocator_put_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
#define ILocator_get_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
#define ILocator_put_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
#define ILocator_get_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
#define ILocator_put_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
#define ILocator_get_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
#define ILocator_put_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
#define ILocator_get_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
#define ILocator_put_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
#define ILocator_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IATSCLocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IATSCLocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_Release(This) (This)->lpVtbl -> Release(This)
#define IATSCLocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IATSCLocator_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IATSCLocator_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IATSCLocator_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IATSCLocator_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
#define IATSCLocator_get_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
#define IATSCLocator_put_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
#define IATSCLocator_get_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
#define IATSCLocator_put_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
#define IATSCLocator_get_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
#define IATSCLocator_put_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
#define IATSCLocator_get_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
#define IATSCLocator_put_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
#define IATSCLocator_get_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
#define IATSCLocator_put_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
#define IATSCLocator_get_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
#define IATSCLocator_put_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
#define IATSCLocator_get_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
#define IATSCLocator_put_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
#define IATSCLocator_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_PhysicalChannel(This,PhysicalChannel) (This)->lpVtbl -> get_PhysicalChannel(This,PhysicalChannel)
#define IATSCLocator_get_PhysicalChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_PhysicalChannel(This,PhysicalChannel) (This)->lpVtbl -> put_PhysicalChannel(This,PhysicalChannel)
#define IATSCLocator_put_PhysicalChannel
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_TSID(This,TSID) (This)->lpVtbl -> get_TSID(This,TSID)
#define IATSCLocator_get_TSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_TSID(This,TSID) (This)->lpVtbl -> put_TSID(This,TSID)
#define IATSCLocator_put_TSID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBTLocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBTLocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBTLocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBTLocator_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBTLocator_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBTLocator_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBTLocator_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
#define IDVBTLocator_get_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
#define IDVBTLocator_put_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
#define IDVBTLocator_get_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
#define IDVBTLocator_put_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
#define IDVBTLocator_get_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
#define IDVBTLocator_put_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
#define IDVBTLocator_get_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
#define IDVBTLocator_put_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
#define IDVBTLocator_get_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
#define IDVBTLocator_put_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
#define IDVBTLocator_get_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
#define IDVBTLocator_put_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
#define IDVBTLocator_get_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
#define IDVBTLocator_put_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
#define IDVBTLocator_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Bandwidth(This,BandWidthVal) (This)->lpVtbl -> get_Bandwidth(This,BandWidthVal)
#define IDVBTLocator_get_Bandwidth
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Bandwidth(This,BandwidthVal) (This)->lpVtbl -> put_Bandwidth(This,BandwidthVal)
#define IDVBTLocator_put_Bandwidth
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_LPInnerFEC(This,FEC) (This)->lpVtbl -> get_LPInnerFEC(This,FEC)
#define IDVBTLocator_get_LPInnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_LPInnerFEC(This,FEC) (This)->lpVtbl -> put_LPInnerFEC(This,FEC)
#define IDVBTLocator_put_LPInnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_LPInnerFECRate(This,FEC) (This)->lpVtbl -> get_LPInnerFECRate(This,FEC)
#define IDVBTLocator_get_LPInnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_LPInnerFECRate(This,FEC) (This)->lpVtbl -> put_LPInnerFECRate(This,FEC)
#define IDVBTLocator_put_LPInnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_HAlpha(This,Alpha) (This)->lpVtbl -> get_HAlpha(This,Alpha)
#define IDVBTLocator_get_HAlpha
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_HAlpha(This,Alpha) (This)->lpVtbl -> put_HAlpha(This,Alpha)
#define IDVBTLocator_put_HAlpha
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Guard(This,GI) (This)->lpVtbl -> get_Guard(This,GI)
#define IDVBTLocator_get_Guard
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Guard(This,GI) (This)->lpVtbl -> put_Guard(This,GI)
#define IDVBTLocator_put_Guard
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Mode(This,mode) (This)->lpVtbl -> get_Mode(This,mode)
#define IDVBTLocator_get_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Mode(This,mode) (This)->lpVtbl -> put_Mode(This,mode)
#define IDVBTLocator_put_Mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_OtherFrequencyInUse(This,OtherFrequencyInUseVal) (This)->lpVtbl -> get_OtherFrequencyInUse(This,OtherFrequencyInUseVal)
#define IDVBTLocator_get_OtherFrequencyInUse
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_OtherFrequencyInUse(This,OtherFrequencyInUseVal) (This)->lpVtbl -> put_OtherFrequencyInUse(This,OtherFrequencyInUseVal)
#define IDVBTLocator_put_OtherFrequencyInUse
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBSLocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBSLocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBSLocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBSLocator_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBSLocator_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBSLocator_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBSLocator_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
#define IDVBSLocator_get_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
#define IDVBSLocator_put_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
#define IDVBSLocator_get_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
#define IDVBSLocator_put_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
#define IDVBSLocator_get_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
#define IDVBSLocator_put_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
#define IDVBSLocator_get_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
#define IDVBSLocator_put_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
#define IDVBSLocator_get_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
#define IDVBSLocator_put_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
#define IDVBSLocator_get_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
#define IDVBSLocator_put_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
#define IDVBSLocator_get_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
#define IDVBSLocator_put_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
#define IDVBSLocator_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_SignalPolarisation(This,PolarisationVal) (This)->lpVtbl -> get_SignalPolarisation(This,PolarisationVal)
#define IDVBSLocator_get_SignalPolarisation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_SignalPolarisation(This,PolarisationVal) (This)->lpVtbl -> put_SignalPolarisation(This,PolarisationVal)
#define IDVBSLocator_put_SignalPolarisation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_WestPosition(This,WestLongitude) (This)->lpVtbl -> get_WestPosition(This,WestLongitude)
#define IDVBSLocator_get_WestPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_WestPosition(This,WestLongitude) (This)->lpVtbl -> put_WestPosition(This,WestLongitude)
#define IDVBSLocator_put_WestPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_OrbitalPosition(This,longitude) (This)->lpVtbl -> get_OrbitalPosition(This,longitude)
#define IDVBSLocator_get_OrbitalPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_OrbitalPosition(This,longitude) (This)->lpVtbl -> put_OrbitalPosition(This,longitude)
#define IDVBSLocator_put_OrbitalPosition
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_Azimuth(This,Azimuth) (This)->lpVtbl -> get_Azimuth(This,Azimuth)
#define IDVBSLocator_get_Azimuth
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_Azimuth(This,Azimuth) (This)->lpVtbl -> put_Azimuth(This,Azimuth)
#define IDVBSLocator_put_Azimuth
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_Elevation(This,Elevation) (This)->lpVtbl -> get_Elevation(This,Elevation)
#define IDVBSLocator_get_Elevation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_Elevation(This,Elevation) (This)->lpVtbl -> put_Elevation(This,Elevation)
#define IDVBSLocator_put_Elevation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IDVBCLocator_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IDVBCLocator_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_Release(This) (This)->lpVtbl -> Release(This)
#define IDVBCLocator_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
#define IDVBCLocator_GetTypeInfoCount
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
#define IDVBCLocator_GetTypeInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
#define IDVBCLocator_GetIDsOfNames
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
#define IDVBCLocator_Invoke
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
#define IDVBCLocator_get_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
#define IDVBCLocator_put_CarrierFrequency
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
#define IDVBCLocator_get_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
#define IDVBCLocator_put_InnerFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
#define IDVBCLocator_get_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
#define IDVBCLocator_put_InnerFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
#define IDVBCLocator_get_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
#define IDVBCLocator_put_OuterFEC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
#define IDVBCLocator_get_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
#define IDVBCLocator_put_OuterFECRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
#define IDVBCLocator_get_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
#define IDVBCLocator_put_Modulation
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
#define IDVBCLocator_get_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
#define IDVBCLocator_put_SymbolRate
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
#define IDVBCLocator_Clone
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
#define IBroadcastEvent_QueryInterface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_AddRef(This) (This)->lpVtbl -> AddRef(This)
#define IBroadcastEvent_AddRef
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_Release(This) (This)->lpVtbl -> Release(This)
#define IBroadcastEvent_Release
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_Fire(This,EventID) (This)->lpVtbl -> Fire(This,EventID)
#define IBroadcastEvent_Fire
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SID_SBroadcastEventService CLSID_BroadcastEventService
#define SID_SBroadcastEventService

namespace BDATuningModel
{


// tuning space container
public class TNTuningSpaceContainer : PQTuningSpaceContainer
{
     private TNTuningSpaceContainer()
     {
     }
     private TNTuningSpaceContainer(PQTuningSpaceContainer a) : base(a)
     {
     }
     private TNTuningSpaceContainer(@interface ITuningSpace p) : base(p)
     {
     }
     private TNTuningSpaceContainer(object p) : base(p)
     {
     }
     private TNTuningSpaceContainer(TNTuningSpaceContainer a) : base(a)
     {
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuningSpaceContainer& operator =(TNTuningSpaceContainer& rhs)
     private TNTuningSpaceContainer CopyFrom(TNTuningSpaceContainer rhs)
     {
        base = rhs;
        return this;
     }

}

// tuning spaces
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNINGSPACETYPE, class TUNEREQUESTTYPE>
// C++ TO C# CONVERTER TODO TASK: Classes cannot inherit from generic type parameters in C#:
public class TNTuningSpaceHelper <TUNINGSPACETYPE, TUNEREQUESTTYPE> : TUNINGSPACETYPE
{
    public TNTuningSpaceHelper()
    {
    }
    public TNTuningSpaceHelper(TUNINGSPACETYPE a) : base(a)
    {
    }
    public TNTuningSpaceHelper(@interface ITuningSpace p) : base(p)
    {
    }
    public TNTuningSpaceHelper(object p) : base(p)
    {
    }
    public TNTuningSpaceHelper(TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> a) : base(a)
    {
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& rhs)
    public TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TUNINGSPACETYPE& rhs)
    public TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TUNINGSPACETYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(object* rhs)
    public TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(interface ITuningSpace *rhs)
    public TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(@interface ITuningSpace rhs)
    {
        base = rhs;
        return this;
    }
    public static bool operator == (TNTuningSpaceHelper ImpliedObject, TUNINGSPACETYPE rhs)
    {
        CComBSTR rhsname = new CComBSTR();
        int hr = rhs.get_UniqueName(rhsname);
        if (FAILED(hr))
        {
            return false;
        }
        CComBSTR name = new CComBSTR();
        hr = ImpliedObject.get_UniqueName(name);
        if (FAILED(hr))
        {
            return false;
        }
        return name == rhsname;
    }
    public static bool operator != (TNTuningSpaceHelper ImpliedObject, TUNINGSPACETYPE rhs)
    {
        return !ImpliedObject.operator == (rhs);
    }
    public PQTuneRequest CreateTuneRequest()
    {
        PQTuneRequest p = new PQTuneRequest();
        int hr = this.CreateTuneRequest(p);
        if (FAILED(hr))
        {
            return PQTuneRequest();
        }
        return new PQTuneRequest(p);
    }

    public PQLocator Locator()
    {
        _ASSERT(this);
        PQLocator ts = new PQLocator();
        int hr = this.get_DefaultLocator(ts);
        if (FAILED(hr))
        {
            return PQLocator();
        }
        return new PQLocator(ts);
    }

    public int Locator(PQLocator l)
    {
        _ASSERT(this);
        return (this).put_Locator(l);
    }

    public void Clone()
    {
        PQTuningSpace t = new PQTuningSpace();
        int hr = this.Clone(t);
        if (FAILED(hr) || t == null)
        {
            Release(); // clone failed, clear ourselves
            return;
        }
        base = t;
    }

}


// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNINGSPACETYPE, class TUNEREQUESTTYPE>
public class TNAnalogRadioTuningSpaceHelper <TUNINGSPACETYPE, TUNEREQUESTTYPE> : TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>
{
     public TNAnalogRadioTuningSpaceHelper()
     {
     }
     public TNAnalogRadioTuningSpaceHelper(TUNINGSPACETYPE a)
     {
         this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
     }
     public TNAnalogRadioTuningSpaceHelper(object p)
     {
         this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = p;
     }
     public TNAnalogRadioTuningSpaceHelper(TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> a)
     {
         this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& rhs)
     public TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TS, class TR>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNTuningSpaceHelper<TS, TR>& rhs)
     public new TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom<TS, TR>(TNTuningSpaceHelper<TS, TR> rhs)
     {
        base = TUNINGSPACETYPE(rhs);
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TUNINGSPACETYPE& rhs)
     public new TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TUNINGSPACETYPE rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(object* rhs)
     public new TNAnalogRadioTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(object rhs)
     {
        base = rhs;
        return this;
     }
    public int MaxFrequency()
    {
        _ASSERT(this);
        int freq;
        int hr = this.get_MaxFrequency(freq);
        if (FAILED(hr))
        {
            freq = GlobalMembers.DEFAULT_MAX_FREQUENCY;
        }
        return freq;
    }
    public int MaxFrequency(int freq)
    {
        _ASSERT(this);
        return (this).put_MaxFrequency(freq);
    }
    public int MinFrequency()
    {
        _ASSERT(this);
        int freq;
        int hr = this.get_MinFrequency(freq);
        if (FAILED(hr))
        {
            freq = GlobalMembers.DEFAULT_MIN_FREQUENCY;
        }
        return freq;
    }
    public int MinFrequency(int freq)
    {
        _ASSERT(this);
        return (this).put_MinFrequency(freq);
    }
}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNINGSPACETYPE, class TUNEREQUESTTYPE>
public class TNAnalogTVTuningSpaceHelper <TUNINGSPACETYPE, TUNEREQUESTTYPE> : TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>
{
    public TNAnalogTVTuningSpaceHelper()
    {
    }
    public TNAnalogTVTuningSpaceHelper(TUNINGSPACETYPE a)
    {
        this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
    }
    public TNAnalogTVTuningSpaceHelper(object p)
    {
        this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = p;
    }
    public TNAnalogTVTuningSpaceHelper(TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> a)
    {
        this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& rhs)
    public TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TS, class TR>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNTuningSpaceHelper<TS, TR>& rhs)
    public new TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom<TS, TR>(TNTuningSpaceHelper<TS, TR> rhs)
    {
        base = TUNINGSPACETYPE(rhs);
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TUNINGSPACETYPE& rhs)
    public new TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TUNINGSPACETYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(object* rhs)
    public new TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }
    public TunerInputType InputType()
    {
        _ASSERT(this);
        TunerInputType ti = new TunerInputType();
        int hr = this.get_InputType(ti);
        if (FAILED(hr))
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: ti = DEFAULT_ANALOG_TUNER_INPUT_TYPE;
            ti.CopyFrom(GlobalMembers.DEFAULT_ANALOG_TUNER_INPUT_TYPE);
        }
        return new TunerInputType(ti);
    }
    public int InputType(TunerInputType ti)
    {
        _ASSERT(this);
        return (this).put_InputType(ti);
    }
    public int CountryCode()
    {
        _ASSERT(this);
        int cc;
        int hr = this.get_CountryCode(cc);
        if (FAILED(hr))
        {
            cc = GlobalMembers.DEFAULT_ANALOG_TUNER_INPUT_TYPE;
        }
        return cc;
    }
    public int CountryCode(int cc)
    {
        _ASSERT(this);
        return (this).put_CountryCode(cc);
    }
    public int MinChannel()
    {
        _ASSERT(this);
        int chan;
        int hr = this.get_MinChannel(chan);
        if (FAILED(hr))
        {
            chan = GlobalMembers.DEFAULT_MIN_CHANNEL;
        }
        return chan;
    }
    public int MinChannel(int chan)
    {
        _ASSERT(this);
        return (this).put_MinChannel(chan);
    }
    public int MaxChannel()
    {
        _ASSERT(this);
        int chan;
        int hr = this.get_MaxChannel(chan);
        if (FAILED(hr))
        {
            chan = GlobalMembers.DEFAULT_MAX_CHANNEL;
        }
        return chan;
    }
    public int MaxChannel(int chan)
    {
        _ASSERT(this);
        return (this).put_MaxChannel(chan);
    }
}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNINGSPACETYPE, class TUNEREQUESTTYPE>
public class TNAuxInTuningSpaceHelper <TUNINGSPACETYPE, TUNEREQUESTTYPE> : TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>
{
    public TNAuxInTuningSpaceHelper()
    {
    }
    public TNAuxInTuningSpaceHelper(TUNINGSPACETYPE a)
    {
        this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
    }
    public TNAuxInTuningSpaceHelper(object p)
    {
        this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = p;
    }
    public TNAuxInTuningSpaceHelper(TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> a)
    {
        this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& rhs)
    public TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TS, class TR>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNTuningSpaceHelper<TS, TR>& rhs)
    public new TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom<TS, TR>(TNTuningSpaceHelper<TS, TR> rhs)
    {
        base = TUNINGSPACETYPE(rhs);
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TUNINGSPACETYPE& rhs)
    public new TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TUNINGSPACETYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(object* rhs)
    public new TNAuxInTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }
}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNINGSPACETYPE, class TUNEREQUESTTYPE>
public class TNATSCTuningSpaceHelper <TUNINGSPACETYPE, TUNEREQUESTTYPE> : TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>
{
    public TNATSCTuningSpaceHelper()
    {
    }
    public TNATSCTuningSpaceHelper(TUNINGSPACETYPE a)
    {
        this.TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
    }
    public TNATSCTuningSpaceHelper(object p)
    {
        this.TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = p;
    }
    public TNATSCTuningSpaceHelper(TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> a)
    {
        this.TNAnalogTVTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
    }

// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& rhs)
    public TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TS, class TR>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNTuningSpaceHelper<TS, TR>& rhs)
    public new TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom<TS, TR>(TNTuningSpaceHelper<TS, TR> rhs)
    {
        base = TUNINGSPACETYPE(rhs);
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TUNINGSPACETYPE& rhs)
    public new TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TUNINGSPACETYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(object* rhs)
    public new TNATSCTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }
    public int MinMinorChannel()
    {
        _ASSERT(this);
        int chan;
        int hr = this.get_MinMinorChannel(chan);
        if (FAILED(hr))
        {
            chan = GlobalMembers.DEFAULT_MIN_CHANNEL;
        }
        return chan;
    }
    public int MinMinorChannel(int chan)
    {
        _ASSERT(this);
        return (this).put_MinMinorChannel(chan);
    }

    public int MaxMinorChannel()
    {
        _ASSERT(this);
        int chan;
        int hr = this.get_MaxMinorChannel(chan);
        if (FAILED(hr))
        {
            chan = GlobalMembers.DEFAULT_MAX_CHANNEL;
        }
        return chan;
    }
    public int MaxMinorChannel(int chan)
    {
        _ASSERT(this);
        return (this).put_MaxMinorChannel(chan);
    }
    public int MinPhysicalChannel()
    {
        _ASSERT(this);
        int chan;
        int hr = this.get_MinPhysicalChannel(chan);
        if (FAILED(hr))
        {
            chan = GlobalMembers.DEFAULT_MIN_CHANNEL;
        }
        return chan;
    }
    public int MinPhysicalChannel(int chan)
    {
        _ASSERT(this);
        return (this).put_MinPhysicalChannel(chan);
    }

    public int MaxPhysicalChannel()
    {
        _ASSERT(this);
        int chan;
        int hr = this.get_MaxPhysicalChannel(chan);
        if (FAILED(hr))
        {
            chan = GlobalMembers.DEFAULT_MAX_CHANNEL;
        }
        return chan;
    }

    public int MaxPhysicalChannel(int chan)
    {
        _ASSERT(this);
        return (this).put_MaxPhysicalChannel(chan);
    }
}

// dvb tuning space
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNINGSPACETYPE, class TUNEREQUESTTYPE>
public class TNDVBTuningSpaceHelper <TUNINGSPACETYPE, TUNEREQUESTTYPE> : TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>
{
     public TNDVBTuningSpaceHelper()
     {
     }
     public TNDVBTuningSpaceHelper(TUNINGSPACETYPE a)
     {
         this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
     }
     public TNDVBTuningSpaceHelper(object p)
     {
         this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = p;
     }
     public TNDVBTuningSpaceHelper(TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> a)
     {
         this.TNTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> = a;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& rhs)
     public TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TS, class TR>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TNTuningSpaceHelper<TS, TR>& rhs)
     public new TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom<TS, TR>(TNTuningSpaceHelper<TS, TR> rhs)
     {
        base = TUNINGSPACETYPE(rhs);
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(TUNINGSPACETYPE& rhs)
     public new TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(TUNINGSPACETYPE rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE>& operator =(object* rhs)
     public new TNDVBTuningSpaceHelper<TUNINGSPACETYPE, TUNEREQUESTTYPE> CopyFrom(object rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: DVBSystemType SystemType() const
    public DVBSystemType SystemType()
    {
        DVBSystemType st;
        int hr = this.get_SystemType(st);
        if (FAILED(hr))
        {
            return DVBSystemType.DVB_Cable;
        }
        return st;
    }
    public int SystemType(DVBSystemType st)
    {
        _ASSERT(this);
        return (this).put_SystemType(st);
    }
}

// locators
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class LOCATORTYPE>
// C++ TO C# CONVERTER TODO TASK: Classes cannot inherit from generic type parameters in C#:
public class TNLocatorHelper <LOCATORTYPE> : LOCATORTYPE
{
     public TNLocatorHelper()
     {
     }
     public TNLocatorHelper(LOCATORTYPE a) : base(a)
     {
     }
     public TNLocatorHelper(object p) : base(p)
     {
     }
     public TNLocatorHelper(TNLocatorHelper<LOCATORTYPE> a) : base(a)
     {
     }
     public TNLocatorHelper(@interface ILocator p) : base(p)
     {
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNLocatorHelper<LOCATORTYPE>& operator =(TNLocatorHelper<LOCATORTYPE>& rhs)
     public TNLocatorHelper<LOCATORTYPE> CopyFrom(TNLocatorHelper<LOCATORTYPE> rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNLocatorHelper<LOCATORTYPE>& operator =(LOCATORTYPE& rhs)
     public TNLocatorHelper<LOCATORTYPE> CopyFrom(LOCATORTYPE rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNLocatorHelper<LOCATORTYPE>& operator =(interface ILocator* rhs)
     public TNLocatorHelper<LOCATORTYPE> CopyFrom(@interface ILocator rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNLocatorHelper<LOCATORTYPE>& operator =(object* rhs)
     public TNLocatorHelper<LOCATORTYPE> CopyFrom(object rhs)
     {
        base = rhs;
        return this;
     }

    public void Clone()
    {
        PQLocator t = new PQLocator();
        int hr = this.Clone(t);
        if (FAILED(hr) || t == null)
        {
            Release(); // clone failed, clear ourselves
            return;
        }
        base = t;
    }

    public int CarrierFrequency()
    {
        _ASSERT(this);
        int f;
        int hr = this.get_CarrierFrequency(f);
        if (FAILED(hr))
        {
            return -1;
        }
        return f;
    }
    public int CarrierFrequency(int f)
    {
        _ASSERT(this);
        return (this).put_CarrierFrequency(f);
    }

    public FECMethod InnerFEC()
    {
        _ASSERT(this);
        FECMethod f;
        int hr = this.get_InnerFEC(f);
        if (FAILED(hr))
        {
            return FECMethod.BDA_FEC_METHOD_NOT_SET;
        }
        return f;
    }
    public int InnerFEC(FECMethod f)
    {
        _ASSERT(this);
        return (this).put_InnerFEC(f);
    }
    public BinaryConvolutionCodeRate InnerFECRate()
    {
        _ASSERT(this);
        BinaryConvolutionCodeRate f;
        int hr = this.get_InnerFECRate(f);
        if (FAILED(hr))
        {
            return BinaryConvolutionCodeRate.BDA_BCC_RATE_NOT_SET;
        }
        return f;
    }
    public int InnerFECRate(BinaryConvolutionCodeRate f)
    {
        _ASSERT(this);
        return (this).put_InnerFECRate(f);
    }
    public FECMethod OuterFEC()
    {
        _ASSERT(this);
        FECMethod f;
        int hr = this.get_OuterFEC(f);
        if (FAILED(hr))
        {
            return FECMethod.BDA_FEC_METHOD_NOT_SET;
        }
        return f;
    }
    public int OuterFEC(FECMethod f)
    {
        _ASSERT(this);
        return (this).put_OuterFEC(f);
    }
    public BinaryConvolutionCodeRate OuterFECRate()
    {
        _ASSERT(this);
        BinaryConvolutionCodeRate f;
        int hr = this.get_OuterFECRate(f);
        if (FAILED(hr))
        {
            return BinaryConvolutionCodeRate.BDA_BCC_RATE_NOT_SET;
        }
        return f;
    }
    public int OuterFECRate(BinaryConvolutionCodeRate f)
    {
        _ASSERT(this);
        return (this).put_OuterFECRate(f);
    }
    public ModulationType Modulation()
    {
        _ASSERT(this);
        ModulationType f;
        int hr = this.get_Modulation(f);
        if (FAILED(hr))
        {
            return ModulationType.BDA_MOD_NOT_SET;
        }
        return f;
    }
    public int Modulation(ModulationType f)
    {
        _ASSERT(this);
        return (this).put_Modulation(f);
    }

    public int SymbolRate()
    {
        _ASSERT(this);
        int f;
        int hr = this.get_SymbolRate(f);
        if (FAILED(hr))
        {
            return -1;
        }
        return f;
    }
    public int SymbolRate(int f)
    {
        _ASSERT(this);
        return (this).put_SymbolRate(f);
    }

}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class LOCATORTYPE>
public class TNATSCLocatorHelper <LOCATORTYPE> : TNLocatorHelper<LOCATORTYPE>
{
    public TNATSCLocatorHelper()
    {
    }
    public TNATSCLocatorHelper(LOCATORTYPE a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNATSCLocatorHelper(object p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNATSCLocatorHelper(TNATSCLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNATSCLocatorHelper(@interface IATSCLocator p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNATSCLocatorHelper(TNLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCLocatorHelper<LOCATORTYPE>& operator =(TNATSCLocatorHelper<LOCATORTYPE>& rhs)
    public TNATSCLocatorHelper<LOCATORTYPE> CopyFrom(TNATSCLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCLocatorHelper<LOCATORTYPE>& operator =(TNLocatorHelper<LOCATORTYPE>& rhs)
    public new TNATSCLocatorHelper<LOCATORTYPE> CopyFrom(TNLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCLocatorHelper<LOCATORTYPE>& operator =(LOCATORTYPE& rhs)
    public new TNATSCLocatorHelper<LOCATORTYPE> CopyFrom(LOCATORTYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCLocatorHelper<LOCATORTYPE>& operator =(interface IATSCLocator* rhs)
    public TNATSCLocatorHelper<LOCATORTYPE> CopyFrom(@interface IATSCLocator rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCLocatorHelper<LOCATORTYPE>& operator =(object* rhs)
    public new TNATSCLocatorHelper<LOCATORTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }

    public int PhysicalChannel()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_PhysicalChannel(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int PhysicalChannel(int pc)
    {
        _ASSERT(this);
        return (this).put_PhysicalChannel(pc);
    }

    public int TSID()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_TSID(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int TSID(int pc)
    {
        _ASSERT(this);
        return (this).put_TSID(pc);
    }

    public int ProgramNumber()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_ProgramNumber(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int ProgramNumber(int pc)
    {
        _ASSERT(this);
        return (this).put_ProgramNumber(pc);
    }
}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class LOCATORTYPE>
public class TNDVBSLocatorHelper <LOCATORTYPE> : TNLocatorHelper<LOCATORTYPE>
{
    public TNDVBSLocatorHelper()
    {
    }
    public TNDVBSLocatorHelper(LOCATORTYPE a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNDVBSLocatorHelper(object p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNDVBSLocatorHelper(TNDVBSLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNDVBSLocatorHelper(@interface IDVBSLocator p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNDVBSLocatorHelper(TNLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBSLocatorHelper<LOCATORTYPE>& operator =(TNDVBSLocatorHelper<LOCATORTYPE>& rhs)
    public TNDVBSLocatorHelper<LOCATORTYPE> CopyFrom(TNDVBSLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBSLocatorHelper<LOCATORTYPE>& operator =(TNLocatorHelper<LOCATORTYPE>& rhs)
    public new TNDVBSLocatorHelper<LOCATORTYPE> CopyFrom(TNLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBSLocatorHelper<LOCATORTYPE>& operator =(LOCATORTYPE& rhs)
    public new TNDVBSLocatorHelper<LOCATORTYPE> CopyFrom(LOCATORTYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBSLocatorHelper<LOCATORTYPE>& operator =(interface IDVBSLocator* rhs)
    public TNDVBSLocatorHelper<LOCATORTYPE> CopyFrom(@interface IDVBSLocator rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBSLocatorHelper<LOCATORTYPE>& operator =(object* rhs)
    public new TNDVBSLocatorHelper<LOCATORTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }

    public Polarisation SignalPolarisation()
    {
        _ASSERT(this);
        Polarisation pc;
        int hr = this.get_SignalPolarisation(pc);
        if (FAILED(hr))
        {
            return (Polarisation) - 1;
        }
        return pc;
    }
    public int SignalPolarisation(Polarisation pc)
    {
        _ASSERT(this);
        return (this).put_SignalPolarisation(pc);
    }

    public VARIANT_BOOL WestPosition()
    {
        _ASSERT(this);
        VARIANT_BOOL pc = new VARIANT_BOOL();
        int hr = this.get_WestPosition(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return new VARIANT_BOOL(pc);
    }
    public int WestPosition(VARIANT_BOOL pc)
    {
        _ASSERT(this);
        return (this).put_WestPosition(pc);
    }

    public int OrbitalPosition()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_OrbitalPosition(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int OrbitalPosition(int pc)
    {
        _ASSERT(this);
        return (this).put_OrbitalPosition(pc);
    }

    public int Azimuth()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_Azimuth(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int Azimuth(int pc)
    {
        _ASSERT(this);
        return (this).put_Azimuth(pc);
    }

    public int Elevation()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_Elevation(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int Elevation(int pc)
    {
        _ASSERT(this);
        return (this).put_Elevation(pc);
    }

}



// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class LOCATORTYPE>
public class TNDVBTLocatorHelper <LOCATORTYPE> : TNLocatorHelper<LOCATORTYPE>
{
    public TNDVBTLocatorHelper()
    {
    }
    public TNDVBTLocatorHelper(LOCATORTYPE a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNDVBTLocatorHelper(object p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNDVBTLocatorHelper(TNDVBTLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNDVBTLocatorHelper(@interface IDVBTLocator p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNDVBTLocatorHelper(TNLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTLocatorHelper<LOCATORTYPE>& operator =(TNDVBTLocatorHelper<LOCATORTYPE>& rhs)
    public TNDVBTLocatorHelper<LOCATORTYPE> CopyFrom(TNDVBTLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTLocatorHelper<LOCATORTYPE>& operator =(TNLocatorHelper<LOCATORTYPE>& rhs)
    public new TNDVBTLocatorHelper<LOCATORTYPE> CopyFrom(TNLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTLocatorHelper<LOCATORTYPE>& operator =(LOCATORTYPE& rhs)
    public new TNDVBTLocatorHelper<LOCATORTYPE> CopyFrom(LOCATORTYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTLocatorHelper<LOCATORTYPE>& operator =(interface IDVBTLocator* rhs)
    public TNDVBTLocatorHelper<LOCATORTYPE> CopyFrom(@interface IDVBTLocator rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTLocatorHelper<LOCATORTYPE>& operator =(object* rhs)
    public new TNDVBTLocatorHelper<LOCATORTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }

    public int BandWidth()
    {
        _ASSERT(this);
        int pc;
        int hr = this.get_BandWidth(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return pc;
    }
    public int BandWidth(int pc)
    {
        _ASSERT(this);
        return (this).put_BandWidth(pc);
    }

    public FECMethod LPInnerFec()
    {
        _ASSERT(this);
        FECMethod pc;
        int hr = this.get_LPInnerFec(pc);
        if (FAILED(hr))
        {
            return (FECMethod) - 1;
        }
        return pc;
    }
    public int LPInnerFec(FECMethod pc)
    {
        _ASSERT(this);
        return (this).put_LPInnerFec(pc);
    }

    public BinaryConvolutionCodeRate LPInnerFecRate()
    {
        _ASSERT(this);
        BinaryConvolutionCodeRate pc;
        int hr = this.get_LPInnerFecRate(pc);
        if (FAILED(hr))
        {
            return (BinaryConvolutionCodeRate) - 1;
        }
        return pc;
    }
    public int LPInnerFecRate(BinaryConvolutionCodeRate pc)
    {
        _ASSERT(this);
        return (this).put_LPInnerFecRate(pc);
    }

    public HierarchyAlpha HAlpha()
    {
        _ASSERT(this);
        HierarchyAlpha pc;
        int hr = this.get_HAlpha(pc);
        if (FAILED(hr))
        {
            return (HierarchyAlpha) - 1;
        }
        return pc;
    }
    public int HAlpha(HierarchyAlpha pc)
    {
        _ASSERT(this);
        return (this).put_HAlpha(pc);
    }

    public GuardInterval Guard()
    {
        _ASSERT(this);
        GuardInterval pc;
        int hr = this.get_Guard(pc);
        if (FAILED(hr))
        {
            return (GuardInterval) - 1;
        }
        return pc;
    }
    public int Guard(GuardInterval pc)
    {
        _ASSERT(this);
        return (this).put_Guard(pc);
    }

    public TransmissionMode Mode()
    {
        _ASSERT(this);
        TransmissionMode pc;
        int hr = this.get_Mode(pc);
        if (FAILED(hr))
        {
            return (TransmissionMode) - 1;
        }
        return pc;
    }
    public int Mode(TransmissionMode pc)
    {
        _ASSERT(this);
        return (this).put_Mode(pc);
    }

    public VARIANT_BOOL OtherFrequencyInUse()
    {
        _ASSERT(this);
        VARIANT_BOOL pc = new VARIANT_BOOL();
        int hr = this.get_OtherFrequencyInUse(pc);
        if (FAILED(hr))
        {
            return -1;
        }
        return new VARIANT_BOOL(pc);
    }
    public int OtherFrequencyInUse(VARIANT_BOOL pc)
    {
        _ASSERT(this);
        return (this).put_OtherFrequencyInUse(pc);
    }
}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class LOCATORTYPE>
public class TNDVBCLocatorHelper <LOCATORTYPE> : TNLocatorHelper<LOCATORTYPE>
{
    public TNDVBCLocatorHelper()
    {
    }
    public TNDVBCLocatorHelper(LOCATORTYPE a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNDVBCLocatorHelper(object p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNDVBCLocatorHelper(TNDVBCLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
    public TNDVBCLocatorHelper(@interface IDVBCLocator p)
    {
        this.TNLocatorHelper<LOCATORTYPE> = p;
    }
    public TNDVBCLocatorHelper(TNLocatorHelper<LOCATORTYPE> a)
    {
        this.TNLocatorHelper<LOCATORTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBCLocatorHelper<LOCATORTYPE>& operator =(TNDVBCLocatorHelper<LOCATORTYPE>& rhs)
    public TNDVBCLocatorHelper<LOCATORTYPE> CopyFrom(TNDVBCLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBCLocatorHelper<LOCATORTYPE>& operator =(TNLocatorHelper<LOCATORTYPE>& rhs)
    public new TNDVBCLocatorHelper<LOCATORTYPE> CopyFrom(TNLocatorHelper<LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBCLocatorHelper<LOCATORTYPE>& operator =(LOCATORTYPE& rhs)
    public new TNDVBCLocatorHelper<LOCATORTYPE> CopyFrom(LOCATORTYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBCLocatorHelper<LOCATORTYPE>& operator =(interface IDVBCLocator* rhs)
    public TNDVBCLocatorHelper<LOCATORTYPE> CopyFrom(@interface IDVBCLocator rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBCLocatorHelper<LOCATORTYPE>& operator =(object* rhs)
    public new TNDVBCLocatorHelper<LOCATORTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }

}

// tune requests
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNEREQUESTTYPE, class LOCATORTYPE>
// C++ TO C# CONVERTER TODO TASK: Classes cannot inherit from generic type parameters in C#:
public class TNTuneRequestHelper <TUNEREQUESTTYPE, LOCATORTYPE> : TUNEREQUESTTYPE
{
     public TNTuneRequestHelper()
     {
     }
     public TNTuneRequestHelper(TUNEREQUESTTYPE a) : base(a)
     {
     }
     public TNTuneRequestHelper(object p) : base(p)
     {
     }
     public TNTuneRequestHelper(TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a) : base(a)
     {
     }
     public TNTuneRequestHelper(@interface ITuneRequest p) : base(p)
     {
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& rhs)
     public TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TUNEREQUESTTYPE& rhs)
     public TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TUNEREQUESTTYPE rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(interface ITuneRequest* rhs)
     public TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(@interface ITuneRequest rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(object* rhs)
     public TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(object rhs)
     {
        base = rhs;
        return this;
     }
    // this function creates a new instance of the base ITuneRequest* and copies
    // all the values of the current ITuneRequest and sets this to the new one
    // this provides the value semantics needed by the network providers
    public void Clone()
    {
        PQTuneRequest t = new PQTuneRequest();
        int hr = this.Clone(t);
        if (FAILED(hr) || t == null)
        {
            Release(); // clone failed, clear ourselves
            return;
        }
        base = t;
    }

    public PQTuningSpace TuningSpace()
    {
        _ASSERT(this);
        PQTuningSpace ts = new PQTuningSpace();
        int hr = this.get_TuningSpace(ts);
        if (FAILED(hr))
        {
            return PQTuningSpace();
        }
        return new PQTuningSpace(ts);
    }

    public LOCATORTYPE Locator()
    {
        _ASSERT(this);
        PQLocator pc = new PQLocator();
        int hr = this.get_Locator(pc);
        if (FAILED(hr))
        {
            return PQLocator().p;
        }
        return pc.p;
    }
    public int Locator(LOCATORTYPE pc)
    {
        _ASSERT(this);
        return (this).put_Locator(pc);
    }
}


// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNEREQUESTTYPE, class LOCATORTYPE>
public class TNChannelTuneRequestHelper <TUNEREQUESTTYPE, LOCATORTYPE> : TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>
{
     public TNChannelTuneRequestHelper()
     {
     }
     public TNChannelTuneRequestHelper(TNTuneRequest a)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
     }
     public TNChannelTuneRequestHelper(@interface IChannelTuneRequest p)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = p;
     }
     public TNChannelTuneRequestHelper(object p)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = p;
     }
     public TNChannelTuneRequestHelper(TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
     }
     public TNChannelTuneRequestHelper(TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& rhs)
     public TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TR, class LOC>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNTuneRequestHelper<TR, LOC>& rhs)
    public new TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom<TR, LOC>(TNTuneRequestHelper<TR, LOC> rhs)
    {
        base = TUNEREQUESTTYPE(rhs);
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TUNEREQUESTTYPE& rhs)
     public new TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TUNEREQUESTTYPE rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(interface IChannelTuneRequest* rhs)
     public TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(@interface IChannelTuneRequest rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(object* rhs)
     public new TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(object rhs)
     {
        base = rhs;
        return this;
     }
    public int Channel()
    {
        _ASSERT(this);
        int c;
        int hr = this.get_Channel(c);
        if (FAILED(hr))
        {
            return -1;
        }
        return c;
    }
    public int Channel(int c)
    {
        _ASSERT(this);
        return (this).put_Channel(c);
    }
}


// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNEREQUESTTYPE, class LOCATORTYPE>
public class TNATSCChannelTuneRequestHelper <TUNEREQUESTTYPE, LOCATORTYPE> : TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>
{
    public TNATSCChannelTuneRequestHelper()
    {
    }
    public TNATSCChannelTuneRequestHelper(TNTuneRequest a)
    {
        this.TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
    }
    public TNATSCChannelTuneRequestHelper(@interface IATSCChannelTuneRequest p)
    {
        this.TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = p;
    }
    public TNATSCChannelTuneRequestHelper(object p)
    {
        this.TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = p;
    }
    public TNATSCChannelTuneRequestHelper(TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a)
    {
        this.TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
    }
    public TNATSCChannelTuneRequestHelper(TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a)
    {
        this.TNChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& rhs)
    public TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TR, class LOC>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNTuneRequestHelper<TR, LOC>& rhs)
    public new TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom<TR, LOC>(TNTuneRequestHelper<TR, LOC> rhs)
    {
        base = TR(rhs);
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TUNEREQUESTTYPE& rhs)
    public new TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TUNEREQUESTTYPE rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(interface IATSCChannelTuneRequest *rhs)
    public TNATSCChannelTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(@interface IATSCChannelTuneRequest rhs)
    {
        base = rhs;
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(object* rhs)
    public new TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(object rhs)
    {
        base = rhs;
        return this;
    }
    public int MinorChannel()
    {
        _ASSERT(this);
        int mc;
        int hr = this.get_MinorChannel(mc);
        if (FAILED(hr))
        {
            return -1;
        }
        return mc;
    }
    public int MinorChannel(int mc)
    {
        _ASSERT(this);
        return (this).put_MinorChannel(mc);
    }
}

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TUNEREQUESTTYPE, class LOCATORTYPE>
public class TNDVBTuneRequestHelper <TUNEREQUESTTYPE, LOCATORTYPE> : TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>
{
     public TNDVBTuneRequestHelper()
     {
     }
     public TNDVBTuneRequestHelper(TNTuneRequest a)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
     }
     public TNDVBTuneRequestHelper(@interface IDVBTuneRequest p)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = p;
     }
     public TNDVBTuneRequestHelper(object p)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = p;
     }
     public TNDVBTuneRequestHelper(TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
     }
     public TNDVBTuneRequestHelper(TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> a)
     {
         this.TNTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> = a;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& rhs)
     public TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class TR, class LOC>
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TNTuneRequestHelper<TR, LOC>& rhs)
    public new TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom<TR, LOC>(TNTuneRequestHelper<TR, LOC> rhs)
    {
        base = TUNEREQUESTTYPE(rhs);
        return this;
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(TUNEREQUESTTYPE& rhs)
     public new TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(TUNEREQUESTTYPE rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(interface IDVBTuneRequest* rhs)
     public TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(@interface IDVBTuneRequest rhs)
     {
        base = rhs;
        return this;
     }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE>& operator =(object* rhs)
     public new TNDVBTuneRequestHelper<TUNEREQUESTTYPE, LOCATORTYPE> CopyFrom(object rhs)
     {
        base = rhs;
        return this;
     }
    public int ONID()
    {
        _ASSERT(this);
        int c;
        int hr = this.get_ONID(c);
        if (FAILED(hr))
        {
            return -1;
        }
        return c;
    }
    public int ONID(int c)
    {
        _ASSERT(this);
        return (this).put_ONID(c);
    }
    public int TSID()
    {
        _ASSERT(this);
        int c;
        int hr = this.get_TSID(c);
        if (FAILED(hr))
        {
            return -1;
        }
        return c;
    }
    public int TSID(int c)
    {
        _ASSERT(this);
        return (this).put_TSID(c);
    }
    public int SID()
    {
        _ASSERT(this);
        int c;
        int hr = this.get_SID(c);
        if (FAILED(hr))
        {
            return -1;
        }
        return c;
    }
    public int SID(int c)
    {
        _ASSERT(this);
        return (this).put_SID(c);
    }
}
} // namespace
#endif

// end of file - tune.h
