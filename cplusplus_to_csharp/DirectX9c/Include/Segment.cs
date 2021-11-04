using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for segment.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
// @@MIDL_FILE_HEADING(  )


/* verify that the <rpcndr.h> version is high enough to compile this file*/

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "rpc.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "rpcndr.h"

#if ! __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif // __RPCNDR_H_VERSION__

#if ! COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ole2.h"
#endif //COM_NO_WINDOWS_H


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER && (_MSC_VER >= 1020)
#endif

/* Forward Declarations */ 



































































































/* header files for imported files */
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "oaidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ocidl.h"
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreateDevEnum_CreateClassEnumerator(This,clsidDeviceClass,ppEnumMoniker,dwFlags) (This)->lpVtbl -> CreateClassEnumerator(This,clsidDeviceClass,ppEnumMoniker,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_Connect(This,pReceivePin,pmt) (This)->lpVtbl -> Connect(This,pReceivePin,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_ReceiveConnection(This,pConnector,pmt) (This)->lpVtbl -> ReceiveConnection(This,pConnector,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_Disconnect(This) (This)->lpVtbl -> Disconnect(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_ConnectedTo(This,pPin) (This)->lpVtbl -> ConnectedTo(This,pPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_ConnectionMediaType(This,pmt) (This)->lpVtbl -> ConnectionMediaType(This,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryPinInfo(This,pInfo) (This)->lpVtbl -> QueryPinInfo(This,pInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryDirection(This,pPinDir) (This)->lpVtbl -> QueryDirection(This,pPinDir)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryId(This,Id) (This)->lpVtbl -> QueryId(This,Id)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryAccept(This,pmt) (This)->lpVtbl -> QueryAccept(This,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_EnumMediaTypes(This,ppEnum) (This)->lpVtbl -> EnumMediaTypes(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_QueryInternalConnections(This,apPin,nPin) (This)->lpVtbl -> QueryInternalConnections(This,apPin,nPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_EndOfStream(This) (This)->lpVtbl -> EndOfStream(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_BeginFlush(This) (This)->lpVtbl -> BeginFlush(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_EndFlush(This) (This)->lpVtbl -> EndFlush(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPin_NewSegment(This,tStart,tStop,dRate) (This)->lpVtbl -> NewSegment(This,tStart,tStop,dRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Next(This,cPins,ppPins,pcFetched) (This)->lpVtbl -> Next(This,cPins,ppPins,pcFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Skip(This,cPins) (This)->lpVtbl -> Skip(This,cPins)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumPins_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Next(This,cMediaTypes,ppMediaTypes,pcFetched) (This)->lpVtbl -> Next(This,cMediaTypes,ppMediaTypes,pcFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Skip(This,cMediaTypes) (This)->lpVtbl -> Skip(This,cMediaTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumMediaTypes_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_AddFilter(This,pFilter,pName) (This)->lpVtbl -> AddFilter(This,pFilter,pName)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_RemoveFilter(This,pFilter) (This)->lpVtbl -> RemoveFilter(This,pFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_EnumFilters(This,ppEnum) (This)->lpVtbl -> EnumFilters(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_FindFilterByName(This,pName,ppFilter) (This)->lpVtbl -> FindFilterByName(This,pName,ppFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_ConnectDirect(This,ppinOut,ppinIn,pmt) (This)->lpVtbl -> ConnectDirect(This,ppinOut,ppinIn,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_Reconnect(This,ppin) (This)->lpVtbl -> Reconnect(This,ppin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_Disconnect(This,ppin) (This)->lpVtbl -> Disconnect(This,ppin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph_SetDefaultSyncSource(This) (This)->lpVtbl -> SetDefaultSyncSource(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Next(This,cFilters,ppFilter,pcFetched) (This)->lpVtbl -> Next(This,cFilters,ppFilter,pcFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Skip(This,cFilters) (This)->lpVtbl -> Skip(This,cFilters)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumFilters_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_GetClassID(This,pClassID) (This)->lpVtbl -> GetClassID(This,pClassID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Stop(This) (This)->lpVtbl -> Stop(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Pause(This) (This)->lpVtbl -> Pause(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_Run(This,tStart) (This)->lpVtbl -> Run(This,tStart)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_GetState(This,dwMilliSecsTimeout,State) (This)->lpVtbl -> GetState(This,dwMilliSecsTimeout,State)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_SetSyncSource(This,pClock) (This)->lpVtbl -> SetSyncSource(This,pClock)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaFilter_GetSyncSource(This,pClock) (This)->lpVtbl -> GetSyncSource(This,pClock)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_GetClassID(This,pClassID) (This)->lpVtbl -> GetClassID(This,pClassID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Stop(This) (This)->lpVtbl -> Stop(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Pause(This) (This)->lpVtbl -> Pause(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_Run(This,tStart) (This)->lpVtbl -> Run(This,tStart)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_GetState(This,dwMilliSecsTimeout,State) (This)->lpVtbl -> GetState(This,dwMilliSecsTimeout,State)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_SetSyncSource(This,pClock) (This)->lpVtbl -> SetSyncSource(This,pClock)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_GetSyncSource(This,pClock) (This)->lpVtbl -> GetSyncSource(This,pClock)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_EnumPins(This,ppEnum) (This)->lpVtbl -> EnumPins(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_FindPin(This,Id,ppPin) (This)->lpVtbl -> FindPin(This,Id,ppPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_QueryFilterInfo(This,pInfo) (This)->lpVtbl -> QueryFilterInfo(This,pInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_JoinFilterGraph(This,pGraph,pName) (This)->lpVtbl -> JoinFilterGraph(This,pGraph,pName)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBaseFilter_QueryVendorInfo(This,pVendorInfo) (This)->lpVtbl -> QueryVendorInfo(This,pVendorInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_GetTime(This,pTime) (This)->lpVtbl -> GetTime(This,pTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie) (This)->lpVtbl -> AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie) (This)->lpVtbl -> AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock_Unadvise(This,dwAdviseCookie) (This)->lpVtbl -> Unadvise(This,dwAdviseCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_GetTime(This,pTime) (This)->lpVtbl -> GetTime(This,pTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie) (This)->lpVtbl -> AdviseTime(This,baseTime,streamTime,hEvent,pdwAdviseCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie) (This)->lpVtbl -> AdvisePeriodic(This,startTime,periodTime,hSemaphore,pdwAdviseCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IReferenceClock2_Unadvise(This,dwAdviseCookie) (This)->lpVtbl -> Unadvise(This,dwAdviseCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetPointer(This,ppBuffer) (This)->lpVtbl -> GetPointer(This,ppBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetSize(This) (This)->lpVtbl -> GetSize(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_IsSyncPoint(This) (This)->lpVtbl -> IsSyncPoint(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetSyncPoint(This,bIsSyncPoint) (This)->lpVtbl -> SetSyncPoint(This,bIsSyncPoint)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_IsPreroll(This) (This)->lpVtbl -> IsPreroll(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetPreroll(This,bIsPreroll) (This)->lpVtbl -> SetPreroll(This,bIsPreroll)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetActualDataLength(This) (This)->lpVtbl -> GetActualDataLength(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetActualDataLength(This,__MIDL_0010) (This)->lpVtbl -> SetActualDataLength(This,__MIDL_0010)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetMediaType(This,ppMediaType) (This)->lpVtbl -> GetMediaType(This,ppMediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetMediaType(This,pMediaType) (This)->lpVtbl -> SetMediaType(This,pMediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_IsDiscontinuity(This) (This)->lpVtbl -> IsDiscontinuity(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetDiscontinuity(This,bDiscontinuity) (This)->lpVtbl -> SetDiscontinuity(This,bDiscontinuity)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_GetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetMediaTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample_SetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetMediaTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetPointer(This,ppBuffer) (This)->lpVtbl -> GetPointer(This,ppBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetSize(This) (This)->lpVtbl -> GetSize(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_IsSyncPoint(This) (This)->lpVtbl -> IsSyncPoint(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetSyncPoint(This,bIsSyncPoint) (This)->lpVtbl -> SetSyncPoint(This,bIsSyncPoint)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_IsPreroll(This) (This)->lpVtbl -> IsPreroll(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetPreroll(This,bIsPreroll) (This)->lpVtbl -> SetPreroll(This,bIsPreroll)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetActualDataLength(This) (This)->lpVtbl -> GetActualDataLength(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetActualDataLength(This,__MIDL_0010) (This)->lpVtbl -> SetActualDataLength(This,__MIDL_0010)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetMediaType(This,ppMediaType) (This)->lpVtbl -> GetMediaType(This,ppMediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetMediaType(This,pMediaType) (This)->lpVtbl -> SetMediaType(This,pMediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_IsDiscontinuity(This) (This)->lpVtbl -> IsDiscontinuity(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetDiscontinuity(This,bDiscontinuity) (This)->lpVtbl -> SetDiscontinuity(This,bDiscontinuity)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> GetMediaTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetMediaTime(This,pTimeStart,pTimeEnd) (This)->lpVtbl -> SetMediaTime(This,pTimeStart,pTimeEnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_GetProperties(This,cbProperties,pbProperties) (This)->lpVtbl -> GetProperties(This,cbProperties,pbProperties)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSample2_SetProperties(This,cbProperties,pbProperties) (This)->lpVtbl -> SetProperties(This,cbProperties,pbProperties)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_SetProperties(This,pRequest,pActual) (This)->lpVtbl -> SetProperties(This,pRequest,pActual)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_GetProperties(This,pProps) (This)->lpVtbl -> GetProperties(This,pProps)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_Commit(This) (This)->lpVtbl -> Commit(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_Decommit(This) (This)->lpVtbl -> Decommit(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags) (This)->lpVtbl -> GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocator_ReleaseBuffer(This,pBuffer) (This)->lpVtbl -> ReleaseBuffer(This,pBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_SetProperties(This,pRequest,pActual) (This)->lpVtbl -> SetProperties(This,pRequest,pActual)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_GetProperties(This,pProps) (This)->lpVtbl -> GetProperties(This,pProps)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_Commit(This) (This)->lpVtbl -> Commit(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_Decommit(This) (This)->lpVtbl -> Decommit(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags) (This)->lpVtbl -> GetBuffer(This,ppBuffer,pStartTime,pEndTime,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_ReleaseBuffer(This,pBuffer) (This)->lpVtbl -> ReleaseBuffer(This,pBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_SetNotify(This,pNotify) (This)->lpVtbl -> SetNotify(This,pNotify)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorCallbackTemp_GetFreeCount(This,plBuffersFree) (This)->lpVtbl -> GetFreeCount(This,plBuffersFree)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemAllocatorNotifyCallbackTemp_NotifyRelease(This) (This)->lpVtbl -> NotifyRelease(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_GetAllocator(This,ppAllocator) (This)->lpVtbl -> GetAllocator(This,ppAllocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_NotifyAllocator(This,pAllocator,bReadOnly) (This)->lpVtbl -> NotifyAllocator(This,pAllocator,bReadOnly)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_GetAllocatorRequirements(This,pProps) (This)->lpVtbl -> GetAllocatorRequirements(This,pProps)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_Receive(This,pSample) (This)->lpVtbl -> Receive(This,pSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_ReceiveMultiple(This,pSamples,nSamples,nSamplesProcessed) (This)->lpVtbl -> ReceiveMultiple(This,pSamples,nSamples,nSamplesProcessed)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMemInputPin_ReceiveCanBlock(This) (This)->lpVtbl -> ReceiveCanBlock(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_Register(This) (This)->lpVtbl -> Register(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMovieSetup_Unregister(This) (This)->lpVtbl -> Unregister(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetCapabilities(This,pCapabilities) (This)->lpVtbl -> GetCapabilities(This,pCapabilities)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_CheckCapabilities(This,pCapabilities) (This)->lpVtbl -> CheckCapabilities(This,pCapabilities)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_IsFormatSupported(This,pFormat) (This)->lpVtbl -> IsFormatSupported(This,pFormat)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_QueryPreferredFormat(This,pFormat) (This)->lpVtbl -> QueryPreferredFormat(This,pFormat)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetTimeFormat(This,pFormat) (This)->lpVtbl -> GetTimeFormat(This,pFormat)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_IsUsingTimeFormat(This,pFormat) (This)->lpVtbl -> IsUsingTimeFormat(This,pFormat)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_SetTimeFormat(This,pFormat) (This)->lpVtbl -> SetTimeFormat(This,pFormat)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetDuration(This,pDuration) (This)->lpVtbl -> GetDuration(This,pDuration)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetStopPosition(This,pStop) (This)->lpVtbl -> GetStopPosition(This,pStop)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetCurrentPosition(This,pCurrent) (This)->lpVtbl -> GetCurrentPosition(This,pCurrent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_ConvertTimeFormat(This,pTarget,pTargetFormat,Source,pSourceFormat) (This)->lpVtbl -> ConvertTimeFormat(This,pTarget,pTargetFormat,Source,pSourceFormat)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_SetPositions(This,pCurrent,dwCurrentFlags,pStop,dwStopFlags) (This)->lpVtbl -> SetPositions(This,pCurrent,dwCurrentFlags,pStop,dwStopFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetPositions(This,pCurrent,pStop) (This)->lpVtbl -> GetPositions(This,pCurrent,pStop)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetAvailable(This,pEarliest,pLatest) (This)->lpVtbl -> GetAvailable(This,pEarliest,pLatest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_SetRate(This,dRate) (This)->lpVtbl -> SetRate(This,dRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetRate(This,pdRate) (This)->lpVtbl -> GetRate(This,pdRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaSeeking_GetPreroll(This,pllPreroll) (This)->lpVtbl -> GetPreroll(This,pllPreroll)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Next(This,cFilters,apRegFilter,pcFetched) (This)->lpVtbl -> Next(This,cFilters,apRegFilter,pcFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Skip(This,cFilters) (This)->lpVtbl -> Skip(This,cFilters)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumRegFilters_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterFilter(This,clsid,Name,dwMerit) (This)->lpVtbl -> RegisterFilter(This,clsid,Name,dwMerit)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterFilterInstance(This,clsid,Name,MRId) (This)->lpVtbl -> RegisterFilterInstance(This,clsid,Name,MRId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterPin(This,Filter,Name,bRendered,bOutput,bZero,bMany,ConnectsToFilter,ConnectsToPin) (This)->lpVtbl -> RegisterPin(This,Filter,Name,bRendered,bOutput,bZero,bMany,ConnectsToFilter,ConnectsToPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_RegisterPinType(This,clsFilter,strName,clsMajorType,clsSubType) (This)->lpVtbl -> RegisterPinType(This,clsFilter,strName,clsMajorType,clsSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_UnregisterFilter(This,Filter) (This)->lpVtbl -> UnregisterFilter(This,Filter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_UnregisterFilterInstance(This,MRId) (This)->lpVtbl -> UnregisterFilterInstance(This,MRId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_UnregisterPin(This,Filter,Name) (This)->lpVtbl -> UnregisterPin(This,Filter,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper_EnumMatchingFilters(This,ppEnum,dwMerit,bInputNeeded,clsInMaj,clsInSub,bRender,bOututNeeded,clsOutMaj,clsOutSub) (This)->lpVtbl -> EnumMatchingFilters(This,ppEnum,dwMerit,bInputNeeded,clsInMaj,clsInSub,bRender,bOututNeeded,clsOutMaj,clsOutSub)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_CreateCategory(This,clsidCategory,dwCategoryMerit,Description) (This)->lpVtbl -> CreateCategory(This,clsidCategory,dwCategoryMerit,Description)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_UnregisterFilter(This,pclsidCategory,szInstance,Filter) (This)->lpVtbl -> UnregisterFilter(This,pclsidCategory,szInstance,Filter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2) (This)->lpVtbl -> RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper2_EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut) (This)->lpVtbl -> EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_CreateCategory(This,clsidCategory,dwCategoryMerit,Description) (This)->lpVtbl -> CreateCategory(This,clsidCategory,dwCategoryMerit,Description)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_UnregisterFilter(This,pclsidCategory,szInstance,Filter) (This)->lpVtbl -> UnregisterFilter(This,pclsidCategory,szInstance,Filter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2) (This)->lpVtbl -> RegisterFilter(This,clsidFilter,Name,ppMoniker,pclsidCategory,szInstance,prf2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut) (This)->lpVtbl -> EnumMatchingFilters(This,ppEnum,dwFlags,bExactMatch,dwMerit,bInputNeeded,cInputTypes,pInputTypes,pMedIn,pPinCategoryIn,bRender,bOutputNeeded,cOutputTypes,pOutputTypes,pMedOut,pPinCategoryOut)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterMapper3_GetICreateDevEnum(This,ppEnum) (This)->lpVtbl -> GetICreateDevEnum(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_Notify(This,pSelf,q) (This)->lpVtbl -> Notify(This,pSelf,q)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IQualityControl_SetSink(This,piqc) (This)->lpVtbl -> SetSink(This,piqc)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ADVISE_ALL ( ADVISE_CLIPPING | ADVISE_PALETTE | ADVISE_COLORKEY | ADVISE_POSITION )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ADVISE_ALL2 ( ADVISE_ALL | ADVISE_DISPLAY_CHANGE )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnPaletteChange(This,dwColors,pPalette) (This)->lpVtbl -> OnPaletteChange(This,dwColors,pPalette)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnClipChange(This,pSourceRect,pDestinationRect,pRgnData) (This)->lpVtbl -> OnClipChange(This,pSourceRect,pDestinationRect,pRgnData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnColorKeyChange(This,pColorKey) (This)->lpVtbl -> OnColorKeyChange(This,pColorKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify_OnPositionChange(This,pSourceRect,pDestinationRect) (This)->lpVtbl -> OnPositionChange(This,pSourceRect,pDestinationRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnPaletteChange(This,dwColors,pPalette) (This)->lpVtbl -> OnPaletteChange(This,dwColors,pPalette)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnClipChange(This,pSourceRect,pDestinationRect,pRgnData) (This)->lpVtbl -> OnClipChange(This,pSourceRect,pDestinationRect,pRgnData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnColorKeyChange(This,pColorKey) (This)->lpVtbl -> OnColorKeyChange(This,pColorKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnPositionChange(This,pSourceRect,pDestinationRect) (This)->lpVtbl -> OnPositionChange(This,pSourceRect,pDestinationRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlayNotify2_OnDisplayChange(This,hMonitor) (This)->lpVtbl -> OnDisplayChange(This,hMonitor)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetPalette(This,pdwColors,ppPalette) (This)->lpVtbl -> GetPalette(This,pdwColors,ppPalette)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_SetPalette(This,dwColors,pPalette) (This)->lpVtbl -> SetPalette(This,dwColors,pPalette)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetDefaultColorKey(This,pColorKey) (This)->lpVtbl -> GetDefaultColorKey(This,pColorKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetColorKey(This,pColorKey) (This)->lpVtbl -> GetColorKey(This,pColorKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_SetColorKey(This,pColorKey) (This)->lpVtbl -> SetColorKey(This,pColorKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetWindowHandle(This,pHwnd) (This)->lpVtbl -> GetWindowHandle(This,pHwnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetClipList(This,pSourceRect,pDestinationRect,ppRgnData) (This)->lpVtbl -> GetClipList(This,pSourceRect,pDestinationRect,ppRgnData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_GetVideoPosition(This,pSourceRect,pDestinationRect) (This)->lpVtbl -> GetVideoPosition(This,pSourceRect,pDestinationRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_Advise(This,pOverlayNotify,dwInterests) (This)->lpVtbl -> Advise(This,pOverlayNotify,dwInterests)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOverlay_Unadvise(This) (This)->lpVtbl -> Unadvise(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaEventSink_Notify(This,EventCode,EventParam1,EventParam2) (This)->lpVtbl -> Notify(This,EventCode,EventParam1,EventParam2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_Load(This,pszFileName,pmt) (This)->lpVtbl -> Load(This,pszFileName,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSourceFilter_GetCurFile(This,ppszFileName,pmt) (This)->lpVtbl -> GetCurFile(This,ppszFileName,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_SetFileName(This,pszFileName,pmt) (This)->lpVtbl -> SetFileName(This,pszFileName,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter_GetCurFile(This,ppszFileName,pmt) (This)->lpVtbl -> GetCurFile(This,ppszFileName,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_SetFileName(This,pszFileName,pmt) (This)->lpVtbl -> SetFileName(This,pszFileName,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_GetCurFile(This,ppszFileName,pmt) (This)->lpVtbl -> GetCurFile(This,ppszFileName,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_SetMode(This,dwFlags) (This)->lpVtbl -> SetMode(This,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFileSinkFilter2_GetMode(This,pdwFlags) (This)->lpVtbl -> GetMode(This,pdwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_AddFilter(This,pFilter,pName) (This)->lpVtbl -> AddFilter(This,pFilter,pName)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_RemoveFilter(This,pFilter) (This)->lpVtbl -> RemoveFilter(This,pFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_EnumFilters(This,ppEnum) (This)->lpVtbl -> EnumFilters(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_FindFilterByName(This,pName,ppFilter) (This)->lpVtbl -> FindFilterByName(This,pName,ppFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_ConnectDirect(This,ppinOut,ppinIn,pmt) (This)->lpVtbl -> ConnectDirect(This,ppinOut,ppinIn,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Reconnect(This,ppin) (This)->lpVtbl -> Reconnect(This,ppin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Disconnect(This,ppin) (This)->lpVtbl -> Disconnect(This,ppin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_SetDefaultSyncSource(This) (This)->lpVtbl -> SetDefaultSyncSource(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Connect(This,ppinOut,ppinIn) (This)->lpVtbl -> Connect(This,ppinOut,ppinIn)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Render(This,ppinOut) (This)->lpVtbl -> Render(This,ppinOut)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_RenderFile(This,lpcwstrFile,lpcwstrPlayList) (This)->lpVtbl -> RenderFile(This,lpcwstrFile,lpcwstrPlayList)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter) (This)->lpVtbl -> AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_SetLogFile(This,hFile) (This)->lpVtbl -> SetLogFile(This,hFile)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_Abort(This) (This)->lpVtbl -> Abort(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphBuilder_ShouldOperationContinue(This) (This)->lpVtbl -> ShouldOperationContinue(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_SetFiltergraph(This,pfg) (This)->lpVtbl -> SetFiltergraph(This,pfg)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_GetFiltergraph(This,ppfg) (This)->lpVtbl -> GetFiltergraph(This,ppfg)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_SetOutputFileName(This,pType,lpstrFile,ppf,ppSink) (This)->lpVtbl -> SetOutputFileName(This,pType,lpstrFile,ppf,ppSink)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_FindInterface(This,pCategory,pf,riid,ppint) (This)->lpVtbl -> FindInterface(This,pCategory,pf,riid,ppint)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_RenderStream(This,pCategory,pSource,pfCompressor,pfRenderer) (This)->lpVtbl -> RenderStream(This,pCategory,pSource,pfCompressor,pfRenderer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_ControlStream(This,pCategory,pFilter,pstart,pstop,wStartCookie,wStopCookie) (This)->lpVtbl -> ControlStream(This,pCategory,pFilter,pstart,pstop,wStartCookie,wStopCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_AllocCapFile(This,lpstr,dwlSize) (This)->lpVtbl -> AllocCapFile(This,lpstr,dwlSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder_CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback) (This)->lpVtbl -> CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCopyCaptureFileProgress_Progress(This,iProgress) (This)->lpVtbl -> Progress(This,iProgress)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_SetFiltergraph(This,pfg) (This)->lpVtbl -> SetFiltergraph(This,pfg)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_GetFiltergraph(This,ppfg) (This)->lpVtbl -> GetFiltergraph(This,ppfg)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_SetOutputFileName(This,pType,lpstrFile,ppf,ppSink) (This)->lpVtbl -> SetOutputFileName(This,pType,lpstrFile,ppf,ppSink)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_FindInterface(This,pCategory,pType,pf,riid,ppint) (This)->lpVtbl -> FindInterface(This,pCategory,pType,pf,riid,ppint)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_RenderStream(This,pCategory,pType,pSource,pfCompressor,pfRenderer) (This)->lpVtbl -> RenderStream(This,pCategory,pType,pSource,pfCompressor,pfRenderer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_ControlStream(This,pCategory,pType,pFilter,pstart,pstop,wStartCookie,wStopCookie) (This)->lpVtbl -> ControlStream(This,pCategory,pType,pFilter,pstart,pstop,wStartCookie,wStopCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_AllocCapFile(This,lpstr,dwlSize) (This)->lpVtbl -> AllocCapFile(This,lpstr,dwlSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback) (This)->lpVtbl -> CopyCaptureFile(This,lpwstrOld,lpwstrNew,fAllowEscAbort,pCallback)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICaptureGraphBuilder2_FindPin(This,pSource,pindir,pCategory,pType,fUnconnected,num,ppPin) (This)->lpVtbl -> FindPin(This,pSource,pindir,pCategory,pType,fUnconnected,num,ppPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddFilter(This,pFilter,pName) (This)->lpVtbl -> AddFilter(This,pFilter,pName)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_RemoveFilter(This,pFilter) (This)->lpVtbl -> RemoveFilter(This,pFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_EnumFilters(This,ppEnum) (This)->lpVtbl -> EnumFilters(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_FindFilterByName(This,pName,ppFilter) (This)->lpVtbl -> FindFilterByName(This,pName,ppFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_ConnectDirect(This,ppinOut,ppinIn,pmt) (This)->lpVtbl -> ConnectDirect(This,ppinOut,ppinIn,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Reconnect(This,ppin) (This)->lpVtbl -> Reconnect(This,ppin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Disconnect(This,ppin) (This)->lpVtbl -> Disconnect(This,ppin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_SetDefaultSyncSource(This) (This)->lpVtbl -> SetDefaultSyncSource(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Connect(This,ppinOut,ppinIn) (This)->lpVtbl -> Connect(This,ppinOut,ppinIn)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Render(This,ppinOut) (This)->lpVtbl -> Render(This,ppinOut)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_RenderFile(This,lpcwstrFile,lpcwstrPlayList) (This)->lpVtbl -> RenderFile(This,lpcwstrFile,lpcwstrPlayList)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter) (This)->lpVtbl -> AddSourceFilter(This,lpcwstrFileName,lpcwstrFilterName,ppFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_SetLogFile(This,hFile) (This)->lpVtbl -> SetLogFile(This,hFile)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_Abort(This) (This)->lpVtbl -> Abort(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_ShouldOperationContinue(This) (This)->lpVtbl -> ShouldOperationContinue(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_AddSourceFilterForMoniker(This,pMoniker,pCtx,lpcwstrFilterName,ppFilter) (This)->lpVtbl -> AddSourceFilterForMoniker(This,pMoniker,pCtx,lpcwstrFilterName,ppFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_ReconnectEx(This,ppin,pmt) (This)->lpVtbl -> ReconnectEx(This,ppin,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterGraph2_RenderEx(This,pPinOut,dwFlags,pvContext) (This)->lpVtbl -> RenderEx(This,pPinOut,dwFlags,pvContext)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_Render(This,ppinOut,pGraph) (This)->lpVtbl -> Render(This,ppinOut,pGraph)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamBuilder_Backout(This,ppinOut,pGraph) (This)->lpVtbl -> Backout(This,ppinOut,pGraph)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_RequestAllocator(This,pPreferred,pProps,ppActual) (This)->lpVtbl -> RequestAllocator(This,pPreferred,pProps,ppActual)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_Request(This,pSample,dwUser) (This)->lpVtbl -> Request(This,pSample,dwUser)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_WaitForNext(This,dwTimeout,ppSample,pdwUser) (This)->lpVtbl -> WaitForNext(This,dwTimeout,ppSample,pdwUser)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_SyncReadAligned(This,pSample) (This)->lpVtbl -> SyncReadAligned(This,pSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_SyncRead(This,llPosition,lLength,pBuffer) (This)->lpVtbl -> SyncRead(This,llPosition,lLength,pBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_Length(This,pTotal,pAvailable) (This)->lpVtbl -> Length(This,pTotal,pAvailable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_BeginFlush(This) (This)->lpVtbl -> BeginFlush(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAsyncReader_EndFlush(This) (This)->lpVtbl -> EndFlush(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphVersion_QueryVersion(This,pVersion) (This)->lpVtbl -> QueryVersion(This,pVersion)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_AcquireResource(This,idResource) (This)->lpVtbl -> AcquireResource(This,idResource)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceConsumer_ReleaseResource(This,idResource) (This)->lpVtbl -> ReleaseResource(This,idResource)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_Register(This,pName,cResource,plToken) (This)->lpVtbl -> Register(This,pName,cResource,plToken)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_RegisterGroup(This,pName,cResource,palTokens,plToken) (This)->lpVtbl -> RegisterGroup(This,pName,cResource,palTokens,plToken)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_RequestResource(This,idResource,pFocusObject,pConsumer) (This)->lpVtbl -> RequestResource(This,idResource,pFocusObject,pConsumer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_NotifyAcquire(This,idResource,pConsumer,hr) (This)->lpVtbl -> NotifyAcquire(This,idResource,pConsumer,hr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_NotifyRelease(This,idResource,pConsumer,bStillWant) (This)->lpVtbl -> NotifyRelease(This,idResource,pConsumer,bStillWant)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_CancelRequest(This,idResource,pConsumer) (This)->lpVtbl -> CancelRequest(This,idResource,pConsumer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_SetFocus(This,pFocusObject) (This)->lpVtbl -> SetFocus(This,pFocusObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IResourceManager_ReleaseFocus(This,pFocusObject) (This)->lpVtbl -> ReleaseFocus(This,pFocusObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Stop(This) (This)->lpVtbl -> Stop(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Pause(This) (This)->lpVtbl -> Pause(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_Run(This,tStart) (This)->lpVtbl -> Run(This,tStart)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_SetSyncSource(This,pClock) (This)->lpVtbl -> SetSyncSource(This,pClock)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDistributorNotify_NotifyGraphChange(This) (This)->lpVtbl -> NotifyGraphChange(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_StartAt(This,ptStart,dwCookie) (This)->lpVtbl -> StartAt(This,ptStart,dwCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_StopAt(This,ptStop,bSendExtra,dwCookie) (This)->lpVtbl -> StopAt(This,ptStop,bSendExtra,dwCookie)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamControl_GetInfo(This,pInfo) (This)->lpVtbl -> GetInfo(This,pInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ISeekingPassThru_Init(This,bSupportRendering,pPin) (This)->lpVtbl -> Init(This,bSupportRendering,pPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_SetFormat(This,pmt) (This)->lpVtbl -> SetFormat(This,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_GetFormat(This,ppmt) (This)->lpVtbl -> GetFormat(This,ppmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_GetNumberOfCapabilities(This,piCount,piSize) (This)->lpVtbl -> GetNumberOfCapabilities(This,piCount,piSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamConfig_GetStreamCaps(This,iIndex,ppmt,pSCC) (This)->lpVtbl -> GetStreamCaps(This,iIndex,ppmt,pSCC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_put_Mode(This,mode) (This)->lpVtbl -> put_Mode(This,mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_get_Mode(This,pMode) (This)->lpVtbl -> get_Mode(This,pMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_put_Interleaving(This,prtInterleave,prtPreroll) (This)->lpVtbl -> put_Interleaving(This,prtInterleave,prtPreroll)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigInterleaving_get_Interleaving(This,prtInterleave,prtPreroll) (This)->lpVtbl -> get_Interleaving(This,prtInterleave,prtPreroll)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_SetMasterStream(This,iStream) (This)->lpVtbl -> SetMasterStream(This,iStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_GetMasterStream(This,pStream) (This)->lpVtbl -> GetMasterStream(This,pStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_SetOutputCompatibilityIndex(This,fOldIndex) (This)->lpVtbl -> SetOutputCompatibilityIndex(This,fOldIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IConfigAviMux_GetOutputCompatibilityIndex(This,pfOldIndex) (This)->lpVtbl -> GetOutputCompatibilityIndex(This,pfOldIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_KeyFrameRate(This,KeyFrameRate) (This)->lpVtbl -> put_KeyFrameRate(This,KeyFrameRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_KeyFrameRate(This,pKeyFrameRate) (This)->lpVtbl -> get_KeyFrameRate(This,pKeyFrameRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_PFramesPerKeyFrame(This,PFramesPerKeyFrame) (This)->lpVtbl -> put_PFramesPerKeyFrame(This,PFramesPerKeyFrame)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_PFramesPerKeyFrame(This,pPFramesPerKeyFrame) (This)->lpVtbl -> get_PFramesPerKeyFrame(This,pPFramesPerKeyFrame)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_Quality(This,Quality) (This)->lpVtbl -> put_Quality(This,Quality)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_Quality(This,pQuality) (This)->lpVtbl -> get_Quality(This,pQuality)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_put_WindowSize(This,WindowSize) (This)->lpVtbl -> put_WindowSize(This,WindowSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_get_WindowSize(This,pWindowSize) (This)->lpVtbl -> get_WindowSize(This,pWindowSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_GetInfo(This,pszVersion,pcbVersion,pszDescription,pcbDescription,pDefaultKeyFrameRate,pDefaultPFramesPerKey,pDefaultQuality,pCapabilities) (This)->lpVtbl -> GetInfo(This,pszVersion,pcbVersion,pszDescription,pcbDescription,pDefaultKeyFrameRate,pDefaultPFramesPerKey,pDefaultQuality,pCapabilities)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_OverrideKeyFrame(This,FrameNumber) (This)->lpVtbl -> OverrideKeyFrame(This,FrameNumber)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoCompression_OverrideFrameSize(This,FrameNumber,Size) (This)->lpVtbl -> OverrideFrameSize(This,FrameNumber,Size)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_HasDialog(This,iDialog) (This)->lpVtbl -> HasDialog(This,iDialog)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_ShowDialog(This,iDialog,hwnd) (This)->lpVtbl -> ShowDialog(This,iDialog,hwnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCaptureDialogs_SendDriverMessage(This,iDialog,uMsg,dw1,dw2) (This)->lpVtbl -> SendDriverMessage(This,iDialog,uMsg,dw1,dw2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_ShowDialog(This,iDialog,hwnd) (This)->lpVtbl -> ShowDialog(This,iDialog,hwnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_GetState(This,pState,pcbState) (This)->lpVtbl -> GetState(This,pState,pcbState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_SetState(This,pState,cbState) (This)->lpVtbl -> SetState(This,pState,cbState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVfwCompressDialogs_SendDriverMessage(This,uMsg,dw1,dw2) (This)->lpVtbl -> SendDriverMessage(This,uMsg,dw1,dw2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetNumDropped(This,plDropped) (This)->lpVtbl -> GetNumDropped(This,plDropped)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetNumNotDropped(This,plNotDropped) (This)->lpVtbl -> GetNumNotDropped(This,plNotDropped)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetDroppedInfo(This,lSize,plArray,plNumCopied) (This)->lpVtbl -> GetDroppedInfo(This,lSize,plArray,plNumCopied)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDroppedFrames_GetAverageFrameSize(This,plAverageSize) (This)->lpVtbl -> GetAverageFrameSize(This,plAverageSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Enable(This,fEnable) (This)->lpVtbl -> put_Enable(This,fEnable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Enable(This,pfEnable) (This)->lpVtbl -> get_Enable(This,pfEnable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Mono(This,fMono) (This)->lpVtbl -> put_Mono(This,fMono)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Mono(This,pfMono) (This)->lpVtbl -> get_Mono(This,pfMono)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_MixLevel(This,Level) (This)->lpVtbl -> put_MixLevel(This,Level)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_MixLevel(This,pLevel) (This)->lpVtbl -> get_MixLevel(This,pLevel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Pan(This,Pan) (This)->lpVtbl -> put_Pan(This,Pan)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Pan(This,pPan) (This)->lpVtbl -> get_Pan(This,pPan)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Loudness(This,fLoudness) (This)->lpVtbl -> put_Loudness(This,fLoudness)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Loudness(This,pfLoudness) (This)->lpVtbl -> get_Loudness(This,pfLoudness)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Treble(This,Treble) (This)->lpVtbl -> put_Treble(This,Treble)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Treble(This,pTreble) (This)->lpVtbl -> get_Treble(This,pTreble)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_TrebleRange(This,pRange) (This)->lpVtbl -> get_TrebleRange(This,pRange)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_put_Bass(This,Bass) (This)->lpVtbl -> put_Bass(This,Bass)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_Bass(This,pBass) (This)->lpVtbl -> get_Bass(This,pBass)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioInputMixer_get_BassRange(This,pRange) (This)->lpVtbl -> get_BassRange(This,pRange)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_SuggestAllocatorProperties(This,pprop) (This)->lpVtbl -> SuggestAllocatorProperties(This,pprop)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMBufferNegotiation_GetAllocatorProperties(This,pprop) (This)->lpVtbl -> GetAllocatorProperties(This,pprop)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_AvailableTVFormats(This,lAnalogVideoStandard) (This)->lpVtbl -> get_AvailableTVFormats(This,lAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_put_TVFormat(This,lAnalogVideoStandard) (This)->lpVtbl -> put_TVFormat(This,lAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_TVFormat(This,plAnalogVideoStandard) (This)->lpVtbl -> get_TVFormat(This,plAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_HorizontalLocked(This,plLocked) (This)->lpVtbl -> get_HorizontalLocked(This,plLocked)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_put_VCRHorizontalLocking(This,lVCRHorizontalLocking) (This)->lpVtbl -> put_VCRHorizontalLocking(This,lVCRHorizontalLocking)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_VCRHorizontalLocking(This,plVCRHorizontalLocking) (This)->lpVtbl -> get_VCRHorizontalLocking(This,plVCRHorizontalLocking)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_NumberOfLines(This,plNumberOfLines) (This)->lpVtbl -> get_NumberOfLines(This,plNumberOfLines)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_put_OutputEnable(This,lOutputEnable) (This)->lpVtbl -> put_OutputEnable(This,lOutputEnable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoDecoder_get_OutputEnable(This,plOutputEnable) (This)->lpVtbl -> get_OutputEnable(This,plOutputEnable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags) (This)->lpVtbl -> GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_Set(This,Property,lValue,Flags) (This)->lpVtbl -> Set(This,Property,lValue,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoProcAmp_Get(This,Property,lValue,Flags) (This)->lpVtbl -> Get(This,Property,lValue,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags) (This)->lpVtbl -> GetRange(This,Property,pMin,pMax,pSteppingDelta,pDefault,pCapsFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_Set(This,Property,lValue,Flags) (This)->lpVtbl -> Set(This,Property,lValue,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCameraControl_Get(This,Property,lValue,Flags) (This)->lpVtbl -> Get(This,Property,lValue,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetCaps(This,pPin,pCapsFlags) (This)->lpVtbl -> GetCaps(This,pPin,pCapsFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_SetMode(This,pPin,Mode) (This)->lpVtbl -> SetMode(This,pPin,Mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetMode(This,pPin,Mode) (This)->lpVtbl -> GetMode(This,pPin,Mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetCurrentActualFrameRate(This,pPin,ActualFrameRate) (This)->lpVtbl -> GetCurrentActualFrameRate(This,pPin,ActualFrameRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetMaxAvailableFrameRate(This,pPin,iIndex,Dimensions,MaxAvailableFrameRate) (This)->lpVtbl -> GetMaxAvailableFrameRate(This,pPin,iIndex,Dimensions,MaxAvailableFrameRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoControl_GetFrameRateList(This,pPin,iIndex,Dimensions,ListSize,FrameRates) (This)->lpVtbl -> GetFrameRateList(This,pPin,iIndex,Dimensions,ListSize,FrameRates)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_get_PinCounts(This,OutputPinCount,InputPinCount) (This)->lpVtbl -> get_PinCounts(This,OutputPinCount,InputPinCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_CanRoute(This,OutputPinIndex,InputPinIndex) (This)->lpVtbl -> CanRoute(This,OutputPinIndex,InputPinIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_Route(This,OutputPinIndex,InputPinIndex) (This)->lpVtbl -> Route(This,OutputPinIndex,InputPinIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_get_IsRoutedTo(This,OutputPinIndex,InputPinIndex) (This)->lpVtbl -> get_IsRoutedTo(This,OutputPinIndex,InputPinIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMCrossbar_get_CrossbarPinInfo(This,IsInputPin,PinIndex,PinIndexRelated,PhysicalType) (This)->lpVtbl -> get_CrossbarPinInfo(This,IsInputPin,PinIndex,PinIndexRelated,PhysicalType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel) (This)->lpVtbl -> put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel) (This)->lpVtbl -> get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_ChannelMinMax(This,lChannelMin,lChannelMax) (This)->lpVtbl -> ChannelMinMax(This,lChannelMin,lChannelMax)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_CountryCode(This,lCountryCode) (This)->lpVtbl -> put_CountryCode(This,lCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_CountryCode(This,plCountryCode) (This)->lpVtbl -> get_CountryCode(This,plCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_TuningSpace(This,lTuningSpace) (This)->lpVtbl -> put_TuningSpace(This,lTuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_TuningSpace(This,plTuningSpace) (This)->lpVtbl -> get_TuningSpace(This,plTuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_Logon(This,hCurrentUser) (This)->lpVtbl -> Logon(This,hCurrentUser)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_Logout(This) (This)->lpVtbl -> Logout(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_SignalPresent(This,plSignalStrength) (This)->lpVtbl -> SignalPresent(This,plSignalStrength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_put_Mode(This,lMode) (This)->lpVtbl -> put_Mode(This,lMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_get_Mode(This,plMode) (This)->lpVtbl -> get_Mode(This,plMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_GetAvailableModes(This,plModes) (This)->lpVtbl -> GetAvailableModes(This,plModes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTuner_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTunerNotification_OnEvent(This,Event) (This)->lpVtbl -> OnEvent(This,Event)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel) (This)->lpVtbl -> put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel) (This)->lpVtbl -> get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_ChannelMinMax(This,lChannelMin,lChannelMax) (This)->lpVtbl -> ChannelMinMax(This,lChannelMin,lChannelMax)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_CountryCode(This,lCountryCode) (This)->lpVtbl -> put_CountryCode(This,lCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_CountryCode(This,plCountryCode) (This)->lpVtbl -> get_CountryCode(This,plCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_TuningSpace(This,lTuningSpace) (This)->lpVtbl -> put_TuningSpace(This,lTuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_TuningSpace(This,plTuningSpace) (This)->lpVtbl -> get_TuningSpace(This,plTuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_Logon(This,hCurrentUser) (This)->lpVtbl -> Logon(This,hCurrentUser)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_Logout(This) (This)->lpVtbl -> Logout(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_SignalPresent(This,plSignalStrength) (This)->lpVtbl -> SignalPresent(This,plSignalStrength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_Mode(This,lMode) (This)->lpVtbl -> put_Mode(This,lMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_Mode(This,plMode) (This)->lpVtbl -> get_Mode(This,plMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_GetAvailableModes(This,plModes) (This)->lpVtbl -> GetAvailableModes(This,plModes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_AvailableTVFormats(This,lAnalogVideoStandard) (This)->lpVtbl -> get_AvailableTVFormats(This,lAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_TVFormat(This,plAnalogVideoStandard) (This)->lpVtbl -> get_TVFormat(This,plAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_AutoTune(This,lChannel,plFoundSignal) (This)->lpVtbl -> AutoTune(This,lChannel,plFoundSignal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_StoreAutoTune(This) (This)->lpVtbl -> StoreAutoTune(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_NumInputConnections(This,plNumInputConnections) (This)->lpVtbl -> get_NumInputConnections(This,plNumInputConnections)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_InputType(This,lIndex,InputType) (This)->lpVtbl -> put_InputType(This,lIndex,InputType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_InputType(This,lIndex,pInputType) (This)->lpVtbl -> get_InputType(This,lIndex,pInputType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_put_ConnectInput(This,lIndex) (This)->lpVtbl -> put_ConnectInput(This,lIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_ConnectInput(This,plIndex) (This)->lpVtbl -> get_ConnectInput(This,plIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_VideoFrequency(This,lFreq) (This)->lpVtbl -> get_VideoFrequency(This,lFreq)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVTuner_get_AudioFrequency(This,lFreq) (This)->lpVtbl -> get_AudioFrequency(This,lFreq)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel) (This)->lpVtbl -> put_Channel(This,lChannel,lVideoSubChannel,lAudioSubChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel) (This)->lpVtbl -> get_Channel(This,plChannel,plVideoSubChannel,plAudioSubChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_ChannelMinMax(This,lChannelMin,lChannelMax) (This)->lpVtbl -> ChannelMinMax(This,lChannelMin,lChannelMax)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_CountryCode(This,lCountryCode) (This)->lpVtbl -> put_CountryCode(This,lCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_CountryCode(This,plCountryCode) (This)->lpVtbl -> get_CountryCode(This,plCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_TuningSpace(This,lTuningSpace) (This)->lpVtbl -> put_TuningSpace(This,lTuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_TuningSpace(This,plTuningSpace) (This)->lpVtbl -> get_TuningSpace(This,plTuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_Logon(This,hCurrentUser) (This)->lpVtbl -> Logon(This,hCurrentUser)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_Logout(This) (This)->lpVtbl -> Logout(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_SignalPresent(This,plSignalStrength) (This)->lpVtbl -> SignalPresent(This,plSignalStrength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_Mode(This,lMode) (This)->lpVtbl -> put_Mode(This,lMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_Mode(This,plMode) (This)->lpVtbl -> get_Mode(This,plMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_GetAvailableModes(This,plModes) (This)->lpVtbl -> GetAvailableModes(This,plModes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_get_DefaultSubChannelTypes(This,plDefaultVideoType,plDefaultAudioType) (This)->lpVtbl -> get_DefaultSubChannelTypes(This,plDefaultVideoType,plDefaultAudioType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_put_DefaultSubChannelTypes(This,lDefaultVideoType,lDefaultAudioType) (This)->lpVtbl -> put_DefaultSubChannelTypes(This,lDefaultVideoType,lDefaultAudioType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBPCSatelliteTuner_IsTapingPermitted(This) (This)->lpVtbl -> IsTapingPermitted(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_GetHardwareSupportedTVAudioModes(This,plModes) (This)->lpVtbl -> GetHardwareSupportedTVAudioModes(This,plModes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_GetAvailableTVAudioModes(This,plModes) (This)->lpVtbl -> GetAvailableTVAudioModes(This,plModes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_get_TVAudioMode(This,plMode) (This)->lpVtbl -> get_TVAudioMode(This,plMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_put_TVAudioMode(This,lMode) (This)->lpVtbl -> put_TVAudioMode(This,lMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_RegisterNotificationCallBack(This,pNotify,lEvents) (This)->lpVtbl -> RegisterNotificationCallBack(This,pNotify,lEvents)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudio_UnRegisterNotificationCallBack(This,pNotify) (This)->lpVtbl -> UnRegisterNotificationCallBack(This,pNotify)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTVAudioNotification_OnEvent(This,Event) (This)->lpVtbl -> OnEvent(This,Event)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_AvailableTVFormats(This,lAnalogVideoStandard) (This)->lpVtbl -> get_AvailableTVFormats(This,lAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_put_TVFormat(This,lAnalogVideoStandard) (This)->lpVtbl -> put_TVFormat(This,lAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_TVFormat(This,plAnalogVideoStandard) (This)->lpVtbl -> get_TVFormat(This,plAnalogVideoStandard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_put_CopyProtection(This,lVideoCopyProtection) (This)->lpVtbl -> put_CopyProtection(This,lVideoCopyProtection)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_CopyProtection(This,lVideoCopyProtection) (This)->lpVtbl -> get_CopyProtection(This,lVideoCopyProtection)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_put_CCEnable(This,lCCEnable) (This)->lpVtbl -> put_CCEnable(This,lCCEnable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAnalogVideoEncoder_get_CCEnable(This,lCCEnable) (This)->lpVtbl -> get_CCEnable(This,lCCEnable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_Set(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData) (This)->lpVtbl -> Set(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_Get(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData,pcbReturned) (This)->lpVtbl -> Get(This,guidPropSet,dwPropID,pInstanceData,cbInstanceData,pPropData,cbPropData,pcbReturned)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IKsPropertySet_QuerySupported(This,guidPropSet,dwPropID,pTypeSupport) (This)->lpVtbl -> QuerySupported(This,guidPropSet,dwPropID,pTypeSupport)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_Read(This,pszPropName,pVar,pErrorLog) (This)->lpVtbl -> Read(This,pszPropName,pVar,pErrorLog)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_Write(This,pszPropName,pVar) (This)->lpVtbl -> Write(This,pszPropName,pVar)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaPropertyBag_EnumProperty(This,iProperty,pvarPropertyName,pvarPropertyValue) (This)->lpVtbl -> EnumProperty(This,iProperty,pvarPropertyName,pvarPropertyValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_GetClassID(This,pClassID) (This)->lpVtbl -> GetClassID(This,pClassID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_InitNew(This) (This)->lpVtbl -> InitNew(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_Load(This,pPropBag,pErrorLog) (This)->lpVtbl -> Load(This,pPropBag,pErrorLog)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPersistMediaPropertyBag_Save(This,pPropBag,fClearDirty,fSaveAllProperties) (This)->lpVtbl -> Save(This,pPropBag,fClearDirty,fSaveAllProperties)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPhysicalPinInfo_GetPhysicalType(This,pType,ppszType) (This)->lpVtbl -> GetPhysicalType(This,pType,ppszType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_GetCapability(This,Capability,pValue,pdblValue) (This)->lpVtbl -> GetCapability(This,Capability,pValue,pdblValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_ExternalDeviceID(This,ppszData) (This)->lpVtbl -> get_ExternalDeviceID(This,ppszData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_ExternalDeviceVersion(This,ppszData) (This)->lpVtbl -> get_ExternalDeviceVersion(This,ppszData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_put_DevicePower(This,PowerMode) (This)->lpVtbl -> put_DevicePower(This,PowerMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_DevicePower(This,pPowerMode) (This)->lpVtbl -> get_DevicePower(This,pPowerMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_Calibrate(This,hEvent,Mode,pStatus) (This)->lpVtbl -> Calibrate(This,hEvent,Mode,pStatus)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_put_DevicePort(This,DevicePort) (This)->lpVtbl -> put_DevicePort(This,DevicePort)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtDevice_get_DevicePort(This,pDevicePort) (This)->lpVtbl -> get_DevicePort(This,pDevicePort)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetCapability(This,Capability,pValue,pdblValue) (This)->lpVtbl -> GetCapability(This,Capability,pValue,pdblValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_MediaState(This,State) (This)->lpVtbl -> put_MediaState(This,State)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_MediaState(This,pState) (This)->lpVtbl -> get_MediaState(This,pState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_LocalControl(This,State) (This)->lpVtbl -> put_LocalControl(This,State)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_LocalControl(This,pState) (This)->lpVtbl -> get_LocalControl(This,pState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetStatus(This,StatusItem,pValue) (This)->lpVtbl -> GetStatus(This,StatusItem,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetTransportBasicParameters(This,Param,pValue,ppszData) (This)->lpVtbl -> GetTransportBasicParameters(This,Param,pValue,ppszData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetTransportBasicParameters(This,Param,Value,pszData) (This)->lpVtbl -> SetTransportBasicParameters(This,Param,Value,pszData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetTransportVideoParameters(This,Param,pValue) (This)->lpVtbl -> GetTransportVideoParameters(This,Param,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetTransportVideoParameters(This,Param,Value) (This)->lpVtbl -> SetTransportVideoParameters(This,Param,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetTransportAudioParameters(This,Param,pValue) (This)->lpVtbl -> GetTransportAudioParameters(This,Param,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetTransportAudioParameters(This,Param,Value) (This)->lpVtbl -> SetTransportAudioParameters(This,Param,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_Mode(This,Mode) (This)->lpVtbl -> put_Mode(This,Mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_Mode(This,pMode) (This)->lpVtbl -> get_Mode(This,pMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_Rate(This,dblRate) (This)->lpVtbl -> put_Rate(This,dblRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_Rate(This,pdblRate) (This)->lpVtbl -> get_Rate(This,pdblRate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetChase(This,pEnabled,pOffset,phEvent) (This)->lpVtbl -> GetChase(This,pEnabled,pOffset,phEvent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetChase(This,Enable,Offset,hEvent) (This)->lpVtbl -> SetChase(This,Enable,Offset,hEvent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetBump(This,pSpeed,pDuration) (This)->lpVtbl -> GetBump(This,pSpeed,pDuration)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetBump(This,Speed,Duration) (This)->lpVtbl -> SetBump(This,Speed,Duration)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_AntiClogControl(This,pEnabled) (This)->lpVtbl -> get_AntiClogControl(This,pEnabled)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_AntiClogControl(This,Enable) (This)->lpVtbl -> put_AntiClogControl(This,Enable)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetEditPropertySet(This,EditID,pState) (This)->lpVtbl -> GetEditPropertySet(This,EditID,pState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetEditPropertySet(This,pEditID,State) (This)->lpVtbl -> SetEditPropertySet(This,pEditID,State)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_GetEditProperty(This,EditID,Param,pValue) (This)->lpVtbl -> GetEditProperty(This,EditID,Param,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_SetEditProperty(This,EditID,Param,Value) (This)->lpVtbl -> SetEditProperty(This,EditID,Param,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_get_EditStart(This,pValue) (This)->lpVtbl -> get_EditStart(This,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMExtTransport_put_EditStart(This,Value) (This)->lpVtbl -> put_EditStart(This,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_GetTCRMode(This,Param,pValue) (This)->lpVtbl -> GetTCRMode(This,Param,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_SetTCRMode(This,Param,Value) (This)->lpVtbl -> SetTCRMode(This,Param,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_put_VITCLine(This,Line) (This)->lpVtbl -> put_VITCLine(This,Line)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_get_VITCLine(This,pLine) (This)->lpVtbl -> get_VITCLine(This,pLine)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeReader_GetTimecode(This,pTimecodeSample) (This)->lpVtbl -> GetTimecode(This,pTimecodeSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_GetTCGMode(This,Param,pValue) (This)->lpVtbl -> GetTCGMode(This,Param,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_SetTCGMode(This,Param,Value) (This)->lpVtbl -> SetTCGMode(This,Param,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_put_VITCLine(This,Line) (This)->lpVtbl -> put_VITCLine(This,Line)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_get_VITCLine(This,pLine) (This)->lpVtbl -> get_VITCLine(This,pLine)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_SetTimecode(This,pTimecodeSample) (This)->lpVtbl -> SetTimecode(This,pTimecodeSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeGenerator_GetTimecode(This,pTimecodeSample) (This)->lpVtbl -> GetTimecode(This,pTimecodeSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_GetTCDisplayEnable(This,pState) (This)->lpVtbl -> GetTCDisplayEnable(This,pState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_SetTCDisplayEnable(This,State) (This)->lpVtbl -> SetTCDisplayEnable(This,State)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_GetTCDisplay(This,Param,pValue) (This)->lpVtbl -> GetTCDisplay(This,Param,pValue)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMTimecodeDisplay_SetTCDisplay(This,Param,Value) (This)->lpVtbl -> SetTCDisplay(This,Param,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_GetInfo(This,pdwcbTotalFree,pdwcbLargestFree,pdwcbTotalMemory,pdwcbMinimumChunk) (This)->lpVtbl -> GetInfo(This,pdwcbTotalFree,pdwcbLargestFree,pdwcbTotalMemory,pdwcbMinimumChunk)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_CheckMemory(This,pBuffer) (This)->lpVtbl -> CheckMemory(This,pBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_Alloc(This,ppBuffer,pdwcbBuffer) (This)->lpVtbl -> Alloc(This,ppBuffer,pdwcbBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_Free(This,pBuffer) (This)->lpVtbl -> Free(This,pBuffer)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryAllocator_GetDevMemoryObject(This,ppUnkInnner,pUnkOuter) (This)->lpVtbl -> GetDevMemoryObject(This,ppUnkInnner,pUnkOuter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_QueryWriteSync(This) (This)->lpVtbl -> QueryWriteSync(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_WriteSync(This) (This)->lpVtbl -> WriteSync(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDevMemoryControl_GetDevId(This,pdwDevId) (This)->lpVtbl -> GetDevId(This,pdwDevId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Count(This,pcStreams) (This)->lpVtbl -> Count(This,pcStreams)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Info(This,lIndex,ppmt,pdwFlags,plcid,pdwGroup,ppszName,ppObject,ppUnk) (This)->lpVtbl -> Info(This,lIndex,ppmt,pdwFlags,plcid,pdwGroup,ppszName,ppObject,ppUnk)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMStreamSelect_Enable(This,lIndex,dwFlags) (This)->lpVtbl -> Enable(This,lIndex,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMResourceControl_Reserve(This,dwFlags,pvReserved) (This)->lpVtbl -> Reserve(This,dwFlags,pvReserved)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockAdjust_SetClockDelta(This,rtDelta) (This)->lpVtbl -> SetClockDelta(This,rtDelta)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMFilterMiscFlags_GetMiscFlags(This) (This)->lpVtbl -> GetMiscFlags(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_DrawVideoImageBegin(This) (This)->lpVtbl -> DrawVideoImageBegin(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_DrawVideoImageEnd(This) (This)->lpVtbl -> DrawVideoImageEnd(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDrawVideoImage_DrawVideoImageDraw(This,hdc,lprcSrc,lprcDst) (This)->lpVtbl -> DrawVideoImageDraw(This,hdc,lprcSrc,lprcDst)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_SetDecimationImageSize(This,lWidth,lHeight) (This)->lpVtbl -> SetDecimationImageSize(This,lWidth,lHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDecimateVideoImage_ResetDecimationImageSize(This) (This)->lpVtbl -> ResetDecimationImageSize(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_QueryDecimationUsage(This,lpUsage) (This)->lpVtbl -> QueryDecimationUsage(This,lpUsage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMVideoDecimationProperties_SetDecimationUsage(This,Usage) (This)->lpVtbl -> SetDecimationUsage(This,Usage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_Step(This,dwFrames,pStepObject) (This)->lpVtbl -> Step(This,dwFrames,pStepObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_CanStep(This,bMultiple,pStepObject) (This)->lpVtbl -> CanStep(This,bMultiple,pStepObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoFrameStep_CancelStep(This) (This)->lpVtbl -> CancelStep(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMLatency_GetLatency(This,prtLatency) (This)->lpVtbl -> GetLatency(This,prtLatency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetLatency(This,prtLatency) (This)->lpVtbl -> GetLatency(This,prtLatency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetPushSourceFlags(This,pFlags) (This)->lpVtbl -> GetPushSourceFlags(This,pFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_SetPushSourceFlags(This,Flags) (This)->lpVtbl -> SetPushSourceFlags(This,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_SetStreamOffset(This,rtOffset) (This)->lpVtbl -> SetStreamOffset(This,rtOffset)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetStreamOffset(This,prtOffset) (This)->lpVtbl -> GetStreamOffset(This,prtOffset)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_GetMaxStreamOffset(This,prtMaxOffset) (This)->lpVtbl -> GetMaxStreamOffset(This,prtMaxOffset)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMPushSource_SetMaxStreamOffset(This,rtMaxOffset) (This)->lpVtbl -> SetMaxStreamOffset(This,rtMaxOffset)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_DeviceInfo(This,pclsidInterfaceClass,pwszSymbolicLink) (This)->lpVtbl -> DeviceInfo(This,pclsidInterfaceClass,pwszSymbolicLink)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_Reassociate(This) (This)->lpVtbl -> Reassociate(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDeviceRemoval_Disassociate(This) (This)->lpVtbl -> Disassociate(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_get_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo) (This)->lpVtbl -> get_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVEnc_put_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo) (This)->lpVtbl -> put_IFormatResolution(This,VideoFormat,DVFormat,Resolution,fDVInfo,sDVInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_get_IPDisplay(This,displayPix) (This)->lpVtbl -> get_IPDisplay(This,displayPix)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IIPDVDec_put_IPDisplay(This,displayPix) (This)->lpVtbl -> put_IPDisplay(This,displayPix)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVRGB219_SetRGB219(This,bState) (This)->lpVtbl -> SetRGB219(This,bState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVSplitter_DiscardAlternateVideoFrames(This,nDiscard) (This)->lpVtbl -> DiscardAlternateVideoFrames(This,nDiscard)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMAudioRendererStats_GetStatParam(This,dwParam,pdwParam1,pdwParam2) (This)->lpVtbl -> GetStatParam(This,dwParam,pdwParam1,pdwParam2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_FindUpstreamInterface(This,pPin,riid,ppvInterface,dwFlags) (This)->lpVtbl -> FindUpstreamInterface(This,pPin,riid,ppvInterface,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_SyncUsingStreamOffset(This,bUseStreamOffset) (This)->lpVtbl -> SyncUsingStreamOffset(This,bUseStreamOffset)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphStreams_SetMaxGraphLatency(This,rtMaxGraphLatency) (This)->lpVtbl -> SetMaxGraphLatency(This,rtMaxGraphLatency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_QueryOverlayFXCaps(This,lpdwOverlayFXCaps) (This)->lpVtbl -> QueryOverlayFXCaps(This,lpdwOverlayFXCaps)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_SetOverlayFX(This,dwOverlayFX) (This)->lpVtbl -> SetOverlayFX(This,dwOverlayFX)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOverlayFX_GetOverlayFX(This,lpdwOverlayFX) (This)->lpVtbl -> GetOverlayFX(This,lpdwOverlayFX)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_QueryProgress(This,pllTotal,pllCurrent) (This)->lpVtbl -> QueryProgress(This,pllTotal,pllCurrent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMOpenProgress_AbortOperation(This) (This)->lpVtbl -> AbortOperation(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_CreateOutputPin(This,pMediaType,pszPinName,ppIPin) (This)->lpVtbl -> CreateOutputPin(This,pMediaType,pszPinName,ppIPin)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_SetOutputPinMediaType(This,pszPinName,pMediaType) (This)->lpVtbl -> SetOutputPinMediaType(This,pszPinName,pMediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMpeg2Demultiplexer_DeleteOutputPin(This,pszPinName) (This)->lpVtbl -> DeleteOutputPin(This,pszPinName)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Next(This,cRequest,pStreamIdMap,pcReceived) (This)->lpVtbl -> Next(This,cRequest,pStreamIdMap,pcReceived)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Skip(This,cRecords) (This)->lpVtbl -> Skip(This,cRecords)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumStreamIdMap_Clone(This,ppIEnumStreamIdMap) (This)->lpVtbl -> Clone(This,ppIEnumStreamIdMap)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_MapStreamId(This,ulStreamId,MediaSampleContent,ulSubstreamFilterValue,iDataOffset) (This)->lpVtbl -> MapStreamId(This,ulStreamId,MediaSampleContent,ulSubstreamFilterValue,iDataOffset)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_UnmapStreamId(This,culStreamId,pulStreamId) (This)->lpVtbl -> UnmapStreamId(This,culStreamId,pulStreamId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2StreamIdMap_EnumStreamIdMap(This,ppIEnumStreamIdMap) (This)->lpVtbl -> EnumStreamIdMap(This,ppIEnumStreamIdMap)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IRegisterServiceProvider_RegisterService(This,guidService,pUnkObject) (This)->lpVtbl -> RegisterService(This,guidService,pUnkObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_SetErrorTolerance(This,dwTolerance) (This)->lpVtbl -> SetErrorTolerance(This,dwTolerance)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMClockSlave_GetErrorTolerance(This,pdwTolerance) (This)->lpVtbl -> GetErrorTolerance(This,pdwTolerance)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_SelectedFilter(This,pMon) (This)->lpVtbl -> SelectedFilter(This,pMon)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMGraphBuilderCallback_CreatedFilter(This,pFil) (This)->lpVtbl -> CreatedFilter(This,pFil)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_IsSupported(This,Api) (This)->lpVtbl -> IsSupported(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_IsModifiable(This,Api) (This)->lpVtbl -> IsModifiable(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta) (This)->lpVtbl -> GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetParameterValues(This,Api,Values,ValuesCount) (This)->lpVtbl -> GetParameterValues(This,Api,Values,ValuesCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetDefaultValue(This,Api,Value) (This)->lpVtbl -> GetDefaultValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetValue(This,Api,Value) (This)->lpVtbl -> GetValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetValue(This,Api,Value) (This)->lpVtbl -> SetValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_RegisterForEvent(This,Api,userData) (This)->lpVtbl -> RegisterForEvent(This,Api,userData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_UnregisterForEvent(This,Api) (This)->lpVtbl -> UnregisterForEvent(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllDefaults(This) (This)->lpVtbl -> SetAllDefaults(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetValueWithNotify(This,Api,Value,ChangedParam,ChangedParamCount) (This)->lpVtbl -> SetValueWithNotify(This,Api,Value,ChangedParam,ChangedParamCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllDefaultsWithNotify(This,ChangedParam,ChangedParamCount) (This)->lpVtbl -> SetAllDefaultsWithNotify(This,ChangedParam,ChangedParamCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_GetAllSettings(This,__MIDL_0016) (This)->lpVtbl -> GetAllSettings(This,__MIDL_0016)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllSettings(This,__MIDL_0017) (This)->lpVtbl -> SetAllSettings(This,__MIDL_0017)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICodecAPI_SetAllSettingsWithNotify(This,__MIDL_0018,ChangedParam,ChangedParamCount) (This)->lpVtbl -> SetAllSettingsWithNotify(This,__MIDL_0018,ChangedParam,ChangedParamCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGetCapabilitiesKey_GetCapabilitiesKey(This,pHKey) (This)->lpVtbl -> GetCapabilitiesKey(This,pHKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_IsSupported(This,Api) (This)->lpVtbl -> IsSupported(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_IsAvailable(This,Api) (This)->lpVtbl -> IsAvailable(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta) (This)->lpVtbl -> GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetParameterValues(This,Api,Values,ValuesCount) (This)->lpVtbl -> GetParameterValues(This,Api,Values,ValuesCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetDefaultValue(This,Api,Value) (This)->lpVtbl -> GetDefaultValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_GetValue(This,Api,Value) (This)->lpVtbl -> GetValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEncoderAPI_SetValue(This,Api,Value) (This)->lpVtbl -> SetValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_IsSupported(This,Api) (This)->lpVtbl -> IsSupported(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_IsAvailable(This,Api) (This)->lpVtbl -> IsAvailable(This,Api)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta) (This)->lpVtbl -> GetParameterRange(This,Api,ValueMin,ValueMax,SteppingDelta)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetParameterValues(This,Api,Values,ValuesCount) (This)->lpVtbl -> GetParameterValues(This,Api,Values,ValuesCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetDefaultValue(This,Api,Value) (This)->lpVtbl -> GetDefaultValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_GetValue(This,Api,Value) (This)->lpVtbl -> GetValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVideoEncoder_SetValue(This,Api,Value) (This)->lpVtbl -> SetValue(This,Api,Value)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAMDecoderCaps_GetDecoderCaps(This,dwCapIndex,lpdwCap) (This)->lpVtbl -> GetDecoderCaps(This,dwCapIndex,lpdwCap)
//C++ TO C# CONVERTER TODO TASK: A test for this #define occurs before this statement, so this statement cannot be moved to the top of the file:
#define COM_NO_WINDOWS_H
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IUnknown void
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DDHRESULT( code ) MAKE_HRESULT( 1, _FACDD, code )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DUMMYUNIONNAMEN(n) u##n
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT1 (MAKEFOURCC('D','X','T','1'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT2 (MAKEFOURCC('D','X','T','2'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT3 (MAKEFOURCC('D','X','T','3'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT4 (MAKEFOURCC('D','X','T','4'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DXT5 (MAKEFOURCC('D','X','T','5'))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerate DirectDrawEnumerateW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerateEx DirectDrawEnumerateExW
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerate DirectDrawEnumerateA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectDrawEnumerateEx DirectDrawEnumerateExA
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_YEAR( dwWHQLLevel ) ( (dwWHQLLevel) / 0x10000 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_MONTH( dwWHQLLevel ) ( ( (dwWHQLLevel) / 0x100 ) & 0x00ff )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_WHQL_DAY( dwWHQLLevel ) ( (dwWHQLLevel) & 0xff )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetDisplayMode(p, a, b, c) (p)->lpVtbl->SetDisplayMode(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_SetDisplayMode(p, a, b, c) (p)->SetDisplayMode(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw2_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetSurfaceFromDC(p, a, b) (p)->lpVtbl->GetSurfaceFromDC(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreAllSurfaces(p) (p)->lpVtbl->RestoreAllSurfaces(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDeviceIdentifier(p,a,b) (p)->lpVtbl->GetDeviceIdentifier(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetSurfaceFromDC(p, a, b) (p)->GetSurfaceFromDC(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_RestoreAllSurfaces(p) (p)->RestoreAllSurfaces()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw4_GetDeviceIdentifier(p,a,b) (p)->GetDeviceIdentifier(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDraw7
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Compact(p) (p)->lpVtbl->Compact(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateClipper(p, a, b, c) (p)->lpVtbl->CreateClipper(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreatePalette(p, a, b, c, d) (p)->lpVtbl->CreatePalette(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateSurface(p, a, b, c) (p)->lpVtbl->CreateSurface(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_DuplicateSurface(p, a, b) (p)->lpVtbl->DuplicateSurface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumDisplayModes(p, a, b, c, d) (p)->lpVtbl->EnumDisplayModes(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumSurfaces(p, a, b, c, d) (p)->lpVtbl->EnumSurfaces(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_FlipToGDISurface(p) (p)->lpVtbl->FlipToGDISurface(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetCaps(p, a, b) (p)->lpVtbl->GetCaps(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDisplayMode(p, a) (p)->lpVtbl->GetDisplayMode(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetFourCCCodes(p, a, b) (p)->lpVtbl->GetFourCCCodes(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetGDISurface(p, a) (p)->lpVtbl->GetGDISurface(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetMonitorFrequency(p, a) (p)->lpVtbl->GetMonitorFrequency(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetScanLine(p, a) (p)->lpVtbl->GetScanLine(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetVerticalBlankStatus(p, a) (p)->lpVtbl->GetVerticalBlankStatus(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Initialize(p, a) (p)->lpVtbl->Initialize(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreDisplayMode(p) (p)->lpVtbl->RestoreDisplayMode(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetCooperativeLevel(p, a, b) (p)->lpVtbl->SetCooperativeLevel(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetDisplayMode(p, a, b, c, d, e) (p)->lpVtbl->SetDisplayMode(p, a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_WaitForVerticalBlank(p, a, b) (p)->lpVtbl->WaitForVerticalBlank(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetAvailableVidMem(p, a, b, c) (p)->lpVtbl->GetAvailableVidMem(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetSurfaceFromDC(p, a, b) (p)->lpVtbl->GetSurfaceFromDC(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreAllSurfaces(p) (p)->lpVtbl->RestoreAllSurfaces(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_TestCooperativeLevel(p) (p)->lpVtbl->TestCooperativeLevel(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDeviceIdentifier(p,a,b) (p)->lpVtbl->GetDeviceIdentifier(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_StartModeTest(p,a,b,c) (p)->lpVtbl->StartModeTest(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EvaluateMode(p,a,b) (p)->lpVtbl->EvaluateMode(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Compact(p) (p)->Compact()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateClipper(p, a, b, c) (p)->CreateClipper(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreatePalette(p, a, b, c, d) (p)->CreatePalette(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_CreateSurface(p, a, b, c) (p)->CreateSurface(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_DuplicateSurface(p, a, b) (p)->DuplicateSurface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumDisplayModes(p, a, b, c, d) (p)->EnumDisplayModes(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EnumSurfaces(p, a, b, c, d) (p)->EnumSurfaces(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_FlipToGDISurface(p) (p)->FlipToGDISurface()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetCaps(p, a, b) (p)->GetCaps(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDisplayMode(p, a) (p)->GetDisplayMode(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetFourCCCodes(p, a, b) (p)->GetFourCCCodes(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetGDISurface(p, a) (p)->GetGDISurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetMonitorFrequency(p, a) (p)->GetMonitorFrequency(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetScanLine(p, a) (p)->GetScanLine(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetVerticalBlankStatus(p, a) (p)->GetVerticalBlankStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_Initialize(p, a) (p)->Initialize(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreDisplayMode(p) (p)->RestoreDisplayMode()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetCooperativeLevel(p, a, b) (p)->SetCooperativeLevel(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_SetDisplayMode(p, a, b, c, d, e) (p)->SetDisplayMode(a, b, c, d, e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_WaitForVerticalBlank(p, a, b) (p)->WaitForVerticalBlank(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetAvailableVidMem(p, a, b, c) (p)->GetAvailableVidMem(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetSurfaceFromDC(p, a, b) (p)->GetSurfaceFromDC(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_RestoreAllSurfaces(p) (p)->RestoreAllSurfaces()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_TestCooperativeLevel(p) (p)->TestCooperativeLevel()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_GetDeviceIdentifier(p,a,b) (p)->GetDeviceIdentifier(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_StartModeTest(p,a,b,c) (p)->lpVtbl->StartModeTest(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDraw7_EvaluateMode(p,a,b) (p)->lpVtbl->EvaluateMode(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawPalette
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetCaps(p, a) (p)->lpVtbl->GetCaps(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetEntries(p, a, b, c, d) (p)->lpVtbl->GetEntries(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Initialize(p, a, b, c) (p)->lpVtbl->Initialize(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_SetEntries(p, a, b, c, d) (p)->lpVtbl->SetEntries(p, a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetCaps(p, a) (p)->GetCaps(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_GetEntries(p, a, b, c, d) (p)->GetEntries(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_Initialize(p, a, b, c) (p)->Initialize(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawPalette_SetEntries(p, a, b, c, d) (p)->SetEntries(a, b, c, d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawClipper
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetClipList(p, a, b, c) (p)->lpVtbl->GetClipList(p, a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetHWnd(p, a) (p)->lpVtbl->GetHWnd(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Initialize(p, a, b) (p)->lpVtbl->Initialize(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_IsClipListChanged(p, a) (p)->lpVtbl->IsClipListChanged(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetClipList(p, a, b) (p)->lpVtbl->SetClipList(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetHWnd(p, a, b) (p)->lpVtbl->SetHWnd(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetClipList(p, a, b, c) (p)->GetClipList(a, b, c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_GetHWnd(p, a) (p)->GetHWnd(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_Initialize(p, a, b) (p)->Initialize(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_IsClipListChanged(p, a) (p)->IsClipListChanged(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetClipList(p, a, b) (p)->SetClipList(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawClipper_SetHWnd(p, a, b) (p)->SetHWnd(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface2_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface3
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface3_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface4
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetUniquenessValue(p, a) (p)->lpVtbl->GetUniquenessValue(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ChangeUniquenessValue(p) (p)->lpVtbl->ChangeUniquenessValue(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_GetUniquenessValue(p, a) (p)->GetUniquenessValue(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface4_ChangeUniquenessValue(p) (p)->ChangeUniquenessValue()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawSurface7
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_QueryInterface(p,a,b) (p)->lpVtbl->QueryInterface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddAttachedSurface(p,a) (p)->lpVtbl->AddAttachedSurface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddOverlayDirtyRect(p,a) (p)->lpVtbl->AddOverlayDirtyRect(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Blt(p,a,b,c,d,e) (p)->lpVtbl->Blt(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltBatch(p,a,b,c) (p)->lpVtbl->BltBatch(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltFast(p,a,b,c,d,e) (p)->lpVtbl->BltFast(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_DeleteAttachedSurface(p,a,b) (p)->lpVtbl->DeleteAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumAttachedSurfaces(p,a,b) (p)->lpVtbl->EnumAttachedSurfaces(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumOverlayZOrders(p,a,b,c) (p)->lpVtbl->EnumOverlayZOrders(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Flip(p,a,b) (p)->lpVtbl->Flip(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetAttachedSurface(p,a,b) (p)->lpVtbl->GetAttachedSurface(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetBltStatus(p,a) (p)->lpVtbl->GetBltStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetCaps(p,b) (p)->lpVtbl->GetCaps(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetClipper(p,a) (p)->lpVtbl->GetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetColorKey(p,a,b) (p)->lpVtbl->GetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDC(p,a) (p)->lpVtbl->GetDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetFlipStatus(p,a) (p)->lpVtbl->GetFlipStatus(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetOverlayPosition(p,a,b) (p)->lpVtbl->GetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPalette(p,a) (p)->lpVtbl->GetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPixelFormat(p,a) (p)->lpVtbl->GetPixelFormat(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetSurfaceDesc(p,a) (p)->lpVtbl->GetSurfaceDesc(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Initialize(p,a,b) (p)->lpVtbl->Initialize(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_IsLost(p) (p)->lpVtbl->IsLost(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Lock(p,a,b,c,d) (p)->lpVtbl->Lock(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ReleaseDC(p,a) (p)->lpVtbl->ReleaseDC(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Restore(p) (p)->lpVtbl->Restore(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetClipper(p,a) (p)->lpVtbl->SetClipper(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetColorKey(p,a,b) (p)->lpVtbl->SetColorKey(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetOverlayPosition(p,a,b) (p)->lpVtbl->SetOverlayPosition(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPalette(p,a) (p)->lpVtbl->SetPalette(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Unlock(p,b) (p)->lpVtbl->Unlock(p,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlay(p,a,b,c,d,e) (p)->lpVtbl->UpdateOverlay(p,a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayDisplay(p,a) (p)->lpVtbl->UpdateOverlayDisplay(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayZOrder(p,a,b) (p)->lpVtbl->UpdateOverlayZOrder(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDDInterface(p,a) (p)->lpVtbl->GetDDInterface(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageLock(p,a) (p)->lpVtbl->PageLock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageUnlock(p,a) (p)->lpVtbl->PageUnlock(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetSurfaceDesc(p,a,b) (p)->lpVtbl->SetSurfaceDesc(p,a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPrivateData(p,a,b,c,d) (p)->lpVtbl->SetPrivateData(p,a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPrivateData(p,a,b,c) (p)->lpVtbl->GetPrivateData(p,a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_FreePrivateData(p,a) (p)->lpVtbl->FreePrivateData(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetUniquenessValue(p, a) (p)->lpVtbl->GetUniquenessValue(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ChangeUniquenessValue(p) (p)->lpVtbl->ChangeUniquenessValue(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPriority(p,a) (p)->lpVtbl->SetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPriority(p,a) (p)->lpVtbl->GetPriority(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetLOD(p,a) (p)->lpVtbl->SetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetLOD(p,a) (p)->lpVtbl->GetLOD(p,a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_QueryInterface(p,a,b) (p)->QueryInterface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddAttachedSurface(p,a) (p)->AddAttachedSurface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_AddOverlayDirtyRect(p,a) (p)->AddOverlayDirtyRect(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Blt(p,a,b,c,d,e) (p)->Blt(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltBatch(p,a,b,c) (p)->BltBatch(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_BltFast(p,a,b,c,d,e) (p)->BltFast(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_DeleteAttachedSurface(p,a,b) (p)->DeleteAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumAttachedSurfaces(p,a,b) (p)->EnumAttachedSurfaces(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_EnumOverlayZOrders(p,a,b,c) (p)->EnumOverlayZOrders(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Flip(p,a,b) (p)->Flip(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetAttachedSurface(p,a,b) (p)->GetAttachedSurface(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetBltStatus(p,a) (p)->GetBltStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetCaps(p,b) (p)->GetCaps(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetClipper(p,a) (p)->GetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetColorKey(p,a,b) (p)->GetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDC(p,a) (p)->GetDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetFlipStatus(p,a) (p)->GetFlipStatus(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetOverlayPosition(p,a,b) (p)->GetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPalette(p,a) (p)->GetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPixelFormat(p,a) (p)->GetPixelFormat(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetSurfaceDesc(p,a) (p)->GetSurfaceDesc(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Initialize(p,a,b) (p)->Initialize(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_IsLost(p) (p)->IsLost()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Lock(p,a,b,c,d) (p)->Lock(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ReleaseDC(p,a) (p)->ReleaseDC(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Restore(p) (p)->Restore()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetClipper(p,a) (p)->SetClipper(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetColorKey(p,a,b) (p)->SetColorKey(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetOverlayPosition(p,a,b) (p)->SetOverlayPosition(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPalette(p,a) (p)->SetPalette(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_Unlock(p,b) (p)->Unlock(b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlay(p,a,b,c,d,e) (p)->UpdateOverlay(a,b,c,d,e)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayDisplay(p,a) (p)->UpdateOverlayDisplay(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_UpdateOverlayZOrder(p,a,b) (p)->UpdateOverlayZOrder(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetDDInterface(p,a) (p)->GetDDInterface(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageLock(p,a) (p)->PageLock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_PageUnlock(p,a) (p)->PageUnlock(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetSurfaceDesc(p,a,b) (p)->SetSurfaceDesc(a,b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPrivateData(p,a,b,c,d) (p)->SetPrivateData(a,b,c,d)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPrivateData(p,a,b,c) (p)->GetPrivateData(a,b,c)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_FreePrivateData(p,a) (p)->FreePrivateData(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetUniquenessValue(p, a) (p)->GetUniquenessValue(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_ChangeUniquenessValue(p) (p)->ChangeUniquenessValue()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetPriority(p,a) (p)->SetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetPriority(p,a) (p)->GetPriority(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_SetLOD(p,a) (p)->SetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawSurface7_GetLOD(p,a) (p)->GetLOD(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawColorControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_GetColorControls(p, a) (p)->lpVtbl->GetColorControls(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_SetColorControls(p, a) (p)->lpVtbl->SetColorControls(p, a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_GetColorControls(p, a) (p)->GetColorControls(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawColorControl_SetColorControls(p, a) (p)->SetColorControls(a)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectDrawGammaControl
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_QueryInterface(p, a, b) (p)->lpVtbl->QueryInterface(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_AddRef(p) (p)->lpVtbl->AddRef(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_Release(p) (p)->lpVtbl->Release(p)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_GetGammaRamp(p, a, b) (p)->lpVtbl->GetGammaRamp(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_SetGammaRamp(p, a, b) (p)->lpVtbl->SetGammaRamp(p, a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_QueryInterface(p, a, b) (p)->QueryInterface(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_AddRef(p) (p)->AddRef()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_Release(p) (p)->Release()
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_GetGammaRamp(p, a, b) (p)->GetGammaRamp(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectDrawGammaControl_SetGammaRamp(p, a, b) (p)->SetGammaRamp(a, b)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDSCAPS2_CUBEMAP_ALLFACES ( DDSCAPS2_CUBEMAP_POSITIVEX | DDSCAPS2_CUBEMAP_NEGATIVEX | DDSCAPS2_CUBEMAP_POSITIVEY | DDSCAPS2_CUBEMAP_NEGATIVEY | DDSCAPS2_CUBEMAP_POSITIVEZ | DDSCAPS2_CUBEMAP_NEGATIVEZ )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_BLTFILTER DDFXCAPS_BLTARITHSTRETCHY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDFXCAPS_OVERLAYFILTER DDFXCAPS_OVERLAYARITHSTRETCHY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_OK S_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DD_FALSE S_FALSE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_ALREADYINITIALIZED MAKE_DDHRESULT( 5 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTATTACHSURFACE MAKE_DDHRESULT( 10 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANNOTDETACHSURFACE MAKE_DDHRESULT( 20 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CURRENTLYNOTAVAIL MAKE_DDHRESULT( 40 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCEPTION MAKE_DDHRESULT( 55 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_GENERIC E_FAIL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HEIGHTALIGN MAKE_DDHRESULT( 90 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INCOMPATIBLEPRIMARY MAKE_DDHRESULT( 95 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCAPS MAKE_DDHRESULT( 100 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDCLIPLIST MAKE_DDHRESULT( 110 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDMODE MAKE_DDHRESULT( 120 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDOBJECT MAKE_DDHRESULT( 130 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPARAMS E_INVALIDARG
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPIXELFORMAT MAKE_DDHRESULT( 145 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDRECT MAKE_DDHRESULT( 150 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_LOCKEDSURFACES MAKE_DDHRESULT( 160 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NO3D MAKE_DDHRESULT( 170 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOALPHAHW MAKE_DDHRESULT( 180 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTEREOHARDWARE MAKE_DDHRESULT( 181 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSURFACELEFT MAKE_DDHRESULT( 182 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPLIST MAKE_DDHRESULT( 205 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORCONVHW MAKE_DDHRESULT( 210 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOOPERATIVELEVELSET MAKE_DDHRESULT( 212 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEY MAKE_DDHRESULT( 215 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCOLORKEYHW MAKE_DDHRESULT( 220 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWSUPPORT MAKE_DDHRESULT( 222 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEXCLUSIVEMODE MAKE_DDHRESULT( 225 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFLIPHW MAKE_DDHRESULT( 230 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOGDI MAKE_DDHRESULT( 240 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIRRORHW MAKE_DDHRESULT( 250 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFOUND MAKE_DDHRESULT( 255 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYHW MAKE_DDHRESULT( 260 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAPPINGRECTS MAKE_DDHRESULT( 270 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NORASTEROPHW MAKE_DDHRESULT( 280 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOROTATIONHW MAKE_DDHRESULT( 290 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOSTRETCHHW MAKE_DDHRESULT( 310 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLOR MAKE_DDHRESULT( 316 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT4BITCOLORINDEX MAKE_DDHRESULT( 317 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOT8BITCOLOR MAKE_DDHRESULT( 320 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTEXTUREHW MAKE_DDHRESULT( 330 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOVSYNCHW MAKE_DDHRESULT( 335 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZBUFFERHW MAKE_DDHRESULT( 340 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOZOVERLAYHW MAKE_DDHRESULT( 350 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFCAPS MAKE_DDHRESULT( 360 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFMEMORY E_OUTOFMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OUTOFVIDEOMEMORY MAKE_DDHRESULT( 380 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCANTCLIP MAKE_DDHRESULT( 382 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYCOLORKEYONLYONEACTIVE MAKE_DDHRESULT( 384 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PALETTEBUSY MAKE_DDHRESULT( 387 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_COLORKEYNOTSET MAKE_DDHRESULT( 400 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYATTACHED MAKE_DDHRESULT( 410 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEALREADYDEPENDENT MAKE_DDHRESULT( 420 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEBUSY MAKE_DDHRESULT( 430 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTLOCKSURFACE MAKE_DDHRESULT( 435 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACEISOBSCURED MAKE_DDHRESULT( 440 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACELOST MAKE_DDHRESULT( 450 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_SURFACENOTATTACHED MAKE_DDHRESULT( 460 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGHEIGHT MAKE_DDHRESULT( 470 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGSIZE MAKE_DDHRESULT( 480 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TOOBIGWIDTH MAKE_DDHRESULT( 490 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTED E_NOTIMPL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDFORMAT MAKE_DDHRESULT( 510 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMASK MAKE_DDHRESULT( 520 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSTREAM MAKE_DDHRESULT( 521 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VERTICALBLANKINPROGRESS MAKE_DDHRESULT( 537 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WASSTILLDRAWING MAKE_DDHRESULT( 540 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DDSCAPSCOMPLEXREQUIRED MAKE_DDHRESULT( 542 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_XALIGN MAKE_DDHRESULT( 560 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDDIRECTDRAWGUID MAKE_DDHRESULT( 561 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DIRECTDRAWALREADYCREATED MAKE_DDHRESULT( 562 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODIRECTDRAWHW MAKE_DDHRESULT( 563 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_PRIMARYSURFACEALREADYEXISTS MAKE_DDHRESULT( 564 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOEMULATION MAKE_DDHRESULT( 565 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_REGIONTOOSMALL MAKE_DDHRESULT( 566 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CLIPPERISUSINGHWND MAKE_DDHRESULT( 567 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOCLIPPERATTACHED MAKE_DDHRESULT( 568 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOHWND MAKE_DDHRESULT( 569 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDSUBCLASSED MAKE_DDHRESULT( 570 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_HWNDALREADYSET MAKE_DDHRESULT( 571 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEATTACHED MAKE_DDHRESULT( 572 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOPALETTEHW MAKE_DDHRESULT( 573 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_BLTFASTCANTCLIP MAKE_DDHRESULT( 574 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOBLTHW MAKE_DDHRESULT( 575 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODDROPSHW MAKE_DDHRESULT( 576 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_OVERLAYNOTVISIBLE MAKE_DDHRESULT( 577 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOVERLAYDEST MAKE_DDHRESULT( 578 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDPOSITION MAKE_DDHRESULT( 579 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTAOVERLAYSURFACE MAKE_DDHRESULT( 580 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXCLUSIVEMODEALREADYSET MAKE_DDHRESULT( 581 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTFLIPPABLE MAKE_DDHRESULT( 582 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTDUPLICATE MAKE_DDHRESULT( 583 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOCKED MAKE_DDHRESULT( 584 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTCREATEDC MAKE_DDHRESULT( 585 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODC MAKE_DDHRESULT( 586 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_WRONGMODE MAKE_DDHRESULT( 587 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_IMPLICITLYCREATED MAKE_DDHRESULT( 588 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPALETTIZED MAKE_DDHRESULT( 589 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_UNSUPPORTEDMODE MAKE_DDHRESULT( 590 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMIPMAPHW MAKE_DDHRESULT( 591 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_INVALIDSURFACETYPE MAKE_DDHRESULT( 592 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOOPTIMIZEHW MAKE_DDHRESULT( 600 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTLOADED MAKE_DDHRESULT( 601 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOFOCUSWINDOW MAKE_DDHRESULT( 602 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTONMIPMAPSUBLEVEL MAKE_DDHRESULT( 603 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DCALREADYCREATED MAKE_DDHRESULT( 620 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NONONLOCALVIDMEM MAKE_DDHRESULT( 630 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGELOCK MAKE_DDHRESULT( 640 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_CANTPAGEUNLOCK MAKE_DDHRESULT( 660 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTPAGELOCKED MAKE_DDHRESULT( 680 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_MOREDATA MAKE_DDHRESULT( 690 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_EXPIRED MAKE_DDHRESULT( 691 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_TESTFINISHED MAKE_DDHRESULT( 692 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NEWMODE MAKE_DDHRESULT( 693 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_D3DNOTINITIALIZED MAKE_DDHRESULT( 694 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_VIDEONOTACTIVE MAKE_DDHRESULT( 695 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOMONITORINFORMATION MAKE_DDHRESULT( 696 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NODRIVERSUPPORT MAKE_DDHRESULT( 697 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_DEVICEDOESNTOWNSURFACE MAKE_DDHRESULT( 699 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDERR_NOTINITIALIZED CO_E_NOTINITIALIZED
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TitlePlay(This,ulTitle) (This)->lpVtbl -> TitlePlay(This,ulTitle)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ChapterPlay(This,ulTitle,ulChapter) (This)->lpVtbl -> ChapterPlay(This,ulTitle,ulChapter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TimePlay(This,ulTitle,bcdTime) (This)->lpVtbl -> TimePlay(This,ulTitle,bcdTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_StopForResume(This) (This)->lpVtbl -> StopForResume(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_GoUp(This) (This)->lpVtbl -> GoUp(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TimeSearch(This,bcdTime) (This)->lpVtbl -> TimeSearch(This,bcdTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ChapterSearch(This,ulChapter) (This)->lpVtbl -> ChapterSearch(This,ulChapter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_PrevPGSearch(This) (This)->lpVtbl -> PrevPGSearch(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_TopPGSearch(This) (This)->lpVtbl -> TopPGSearch(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_NextPGSearch(This) (This)->lpVtbl -> NextPGSearch(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ForwardScan(This,dwSpeed) (This)->lpVtbl -> ForwardScan(This,dwSpeed)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_BackwardScan(This,dwSpeed) (This)->lpVtbl -> BackwardScan(This,dwSpeed)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MenuCall(This,MenuID) (This)->lpVtbl -> MenuCall(This,MenuID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_Resume(This) (This)->lpVtbl -> Resume(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_UpperButtonSelect(This) (This)->lpVtbl -> UpperButtonSelect(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_LowerButtonSelect(This) (This)->lpVtbl -> LowerButtonSelect(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_LeftButtonSelect(This) (This)->lpVtbl -> LeftButtonSelect(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_RightButtonSelect(This) (This)->lpVtbl -> RightButtonSelect(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ButtonActivate(This) (This)->lpVtbl -> ButtonActivate(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ButtonSelectAndActivate(This,ulButton) (This)->lpVtbl -> ButtonSelectAndActivate(This,ulButton)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_StillOff(This) (This)->lpVtbl -> StillOff(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_PauseOn(This) (This)->lpVtbl -> PauseOn(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_PauseOff(This) (This)->lpVtbl -> PauseOff(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MenuLanguageSelect(This,Language) (This)->lpVtbl -> MenuLanguageSelect(This,Language)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_AudioStreamChange(This,ulAudio) (This)->lpVtbl -> AudioStreamChange(This,ulAudio)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_SubpictureStreamChange(This,ulSubPicture,bDisplay) (This)->lpVtbl -> SubpictureStreamChange(This,ulSubPicture,bDisplay)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_AngleChange(This,ulAngle) (This)->lpVtbl -> AngleChange(This,ulAngle)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ParentalLevelSelect(This,ulParentalLevel) (This)->lpVtbl -> ParentalLevelSelect(This,ulParentalLevel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ParentalCountrySelect(This,wCountry) (This)->lpVtbl -> ParentalCountrySelect(This,wCountry)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_KaraokeAudioPresentationModeChange(This,ulMode) (This)->lpVtbl -> KaraokeAudioPresentationModeChange(This,ulMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_VideoModePreferrence(This,ulPreferredDisplayMode) (This)->lpVtbl -> VideoModePreferrence(This,ulPreferredDisplayMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_SetRoot(This,pszPath) (This)->lpVtbl -> SetRoot(This,pszPath)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MouseActivate(This,point) (This)->lpVtbl -> MouseActivate(This,point)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_MouseSelect(This,point) (This)->lpVtbl -> MouseSelect(This,point)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl_ChapterPlayAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay) (This)->lpVtbl -> ChapterPlayAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentDomain(This,pDomain) (This)->lpVtbl -> GetCurrentDomain(This,pDomain)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentLocation(This,pLocation) (This)->lpVtbl -> GetCurrentLocation(This,pLocation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetTotalTitleTime(This,pulTotalTime) (This)->lpVtbl -> GetTotalTitleTime(This,pulTotalTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton) (This)->lpVtbl -> GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle) (This)->lpVtbl -> GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream) (This)->lpVtbl -> GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pIsDisabled) (This)->lpVtbl -> GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pIsDisabled)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentUOPS(This,pUOP) (This)->lpVtbl -> GetCurrentUOPS(This,pUOP)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetAllSPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllSPRMs(This,pRegisterArray)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetAllGPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllGPRMs(This,pRegisterArray)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetAudioLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetAudioLanguage(This,ulStream,pLanguage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetSubpictureLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetSubpictureLanguage(This,ulStream,pLanguage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetTitleAttributes(This,ulTitle,pATR) (This)->lpVtbl -> GetTitleAttributes(This,ulTitle,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetVMGAttributes(This,pATR) (This)->lpVtbl -> GetVMGAttributes(This,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentVideoAttributes(This,pATR) (This)->lpVtbl -> GetCurrentVideoAttributes(This,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentAudioAttributes(This,pATR) (This)->lpVtbl -> GetCurrentAudioAttributes(This,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentSubpictureAttributes(This,pATR) (This)->lpVtbl -> GetCurrentSubpictureAttributes(This,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetCurrentVolumeInfo(This,pulNumOfVol,pulThisVolNum,pSide,pulNumOfTitles) (This)->lpVtbl -> GetCurrentVolumeInfo(This,pulNumOfVol,pulThisVolNum,pSide,pulNumOfTitles)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetDVDTextInfo(This,pTextManager,ulBufSize,pulActualSize) (This)->lpVtbl -> GetDVDTextInfo(This,pTextManager,ulBufSize,pulActualSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetPlayerParentalLevel(This,pulParentalLevel,pulCountryCode) (This)->lpVtbl -> GetPlayerParentalLevel(This,pulParentalLevel,pulCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetNumberOfChapters(This,ulTitle,pulNumberOfChapters) (This)->lpVtbl -> GetNumberOfChapters(This,ulTitle,pulNumberOfChapters)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetTitleParentalLevels(This,ulTitle,pulParentalLevels) (This)->lpVtbl -> GetTitleParentalLevels(This,ulTitle,pulParentalLevels)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo_GetRoot(This,pRoot,ulBufSize,pulActualSize) (This)->lpVtbl -> GetRoot(This,pRoot,ulBufSize,pulActualSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_WaitForStart(This) (This)->lpVtbl -> WaitForStart(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdCmd_WaitForEnd(This) (This)->lpVtbl -> WaitForEnd(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_GetDiscID(This,pullUniqueID) (This)->lpVtbl -> GetDiscID(This,pullUniqueID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdState_GetParentalLevel(This,pulParentalLevel) (This)->lpVtbl -> GetParentalLevel(This,pulParentalLevel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayTitle(This,ulTitle,dwFlags,ppCmd) (This)->lpVtbl -> PlayTitle(This,ulTitle,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayChapterInTitle(This,ulTitle,ulChapter,dwFlags,ppCmd) (This)->lpVtbl -> PlayChapterInTitle(This,ulTitle,ulChapter,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayAtTimeInTitle(This,ulTitle,pStartTime,dwFlags,ppCmd) (This)->lpVtbl -> PlayAtTimeInTitle(This,ulTitle,pStartTime,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Stop(This) (This)->lpVtbl -> Stop(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ReturnFromSubmenu(This,dwFlags,ppCmd) (This)->lpVtbl -> ReturnFromSubmenu(This,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayAtTime(This,pTime,dwFlags,ppCmd) (This)->lpVtbl -> PlayAtTime(This,pTime,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayChapter(This,ulChapter,dwFlags,ppCmd) (This)->lpVtbl -> PlayChapter(This,ulChapter,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayPrevChapter(This,dwFlags,ppCmd) (This)->lpVtbl -> PlayPrevChapter(This,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ReplayChapter(This,dwFlags,ppCmd) (This)->lpVtbl -> ReplayChapter(This,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayNextChapter(This,dwFlags,ppCmd) (This)->lpVtbl -> PlayNextChapter(This,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayForwards(This,dSpeed,dwFlags,ppCmd) (This)->lpVtbl -> PlayForwards(This,dSpeed,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayBackwards(This,dSpeed,dwFlags,ppCmd) (This)->lpVtbl -> PlayBackwards(This,dSpeed,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ShowMenu(This,MenuID,dwFlags,ppCmd) (This)->lpVtbl -> ShowMenu(This,MenuID,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Resume(This,dwFlags,ppCmd) (This)->lpVtbl -> Resume(This,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectRelativeButton(This,buttonDir) (This)->lpVtbl -> SelectRelativeButton(This,buttonDir)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ActivateButton(This) (This)->lpVtbl -> ActivateButton(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectButton(This,ulButton) (This)->lpVtbl -> SelectButton(This,ulButton)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAndActivateButton(This,ulButton) (This)->lpVtbl -> SelectAndActivateButton(This,ulButton)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_StillOff(This) (This)->lpVtbl -> StillOff(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_Pause(This,bState) (This)->lpVtbl -> Pause(This,bState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAudioStream(This,ulAudio,dwFlags,ppCmd) (This)->lpVtbl -> SelectAudioStream(This,ulAudio,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectSubpictureStream(This,ulSubPicture,dwFlags,ppCmd) (This)->lpVtbl -> SelectSubpictureStream(This,ulSubPicture,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetSubpictureState(This,bState,dwFlags,ppCmd) (This)->lpVtbl -> SetSubpictureState(This,bState,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAngle(This,ulAngle,dwFlags,ppCmd) (This)->lpVtbl -> SelectAngle(This,ulAngle,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectParentalLevel(This,ulParentalLevel) (This)->lpVtbl -> SelectParentalLevel(This,ulParentalLevel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectParentalCountry(This,bCountry) (This)->lpVtbl -> SelectParentalCountry(This,bCountry)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectKaraokeAudioPresentationMode(This,ulMode) (This)->lpVtbl -> SelectKaraokeAudioPresentationMode(This,ulMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectVideoModePreference(This,ulPreferredDisplayMode) (This)->lpVtbl -> SelectVideoModePreference(This,ulPreferredDisplayMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetDVDDirectory(This,pszwPath) (This)->lpVtbl -> SetDVDDirectory(This,pszwPath)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_ActivateAtPosition(This,point) (This)->lpVtbl -> ActivateAtPosition(This,point)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectAtPosition(This,point) (This)->lpVtbl -> SelectAtPosition(This,point)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayChaptersAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay,dwFlags,ppCmd) (This)->lpVtbl -> PlayChaptersAutoStop(This,ulTitle,ulChapter,ulChaptersToPlay,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_AcceptParentalLevelChange(This,bAccept) (This)->lpVtbl -> AcceptParentalLevelChange(This,bAccept)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetOption(This,flag,fState) (This)->lpVtbl -> SetOption(This,flag,fState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetState(This,pState,dwFlags,ppCmd) (This)->lpVtbl -> SetState(This,pState,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_PlayPeriodInTitleAutoStop(This,ulTitle,pStartTime,pEndTime,dwFlags,ppCmd) (This)->lpVtbl -> PlayPeriodInTitleAutoStop(This,ulTitle,pStartTime,pEndTime,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SetGPRM(This,ulIndex,wValue,dwFlags,ppCmd) (This)->lpVtbl -> SetGPRM(This,ulIndex,wValue,dwFlags,ppCmd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectDefaultMenuLanguage(This,Language) (This)->lpVtbl -> SelectDefaultMenuLanguage(This,Language)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectDefaultAudioLanguage(This,Language,audioExtension) (This)->lpVtbl -> SelectDefaultAudioLanguage(This,Language,audioExtension)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdControl2_SelectDefaultSubpictureLanguage(This,Language,subpictureExtension) (This)->lpVtbl -> SelectDefaultSubpictureLanguage(This,Language,subpictureExtension)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentDomain(This,pDomain) (This)->lpVtbl -> GetCurrentDomain(This,pDomain)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentLocation(This,pLocation) (This)->lpVtbl -> GetCurrentLocation(This,pLocation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetTotalTitleTime(This,pTotalTime,ulTimeCodeFlags) (This)->lpVtbl -> GetTotalTitleTime(This,pTotalTime,ulTimeCodeFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton) (This)->lpVtbl -> GetCurrentButton(This,pulButtonsAvailable,pulCurrentButton)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle) (This)->lpVtbl -> GetCurrentAngle(This,pulAnglesAvailable,pulCurrentAngle)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream) (This)->lpVtbl -> GetCurrentAudio(This,pulStreamsAvailable,pulCurrentStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pbIsDisabled) (This)->lpVtbl -> GetCurrentSubpicture(This,pulStreamsAvailable,pulCurrentStream,pbIsDisabled)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentUOPS(This,pulUOPs) (This)->lpVtbl -> GetCurrentUOPS(This,pulUOPs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAllSPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllSPRMs(This,pRegisterArray)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAllGPRMs(This,pRegisterArray) (This)->lpVtbl -> GetAllGPRMs(This,pRegisterArray)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAudioLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetAudioLanguage(This,ulStream,pLanguage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetSubpictureLanguage(This,ulStream,pLanguage) (This)->lpVtbl -> GetSubpictureLanguage(This,ulStream,pLanguage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetTitleAttributes(This,ulTitle,pMenu,pTitle) (This)->lpVtbl -> GetTitleAttributes(This,ulTitle,pMenu,pTitle)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetVMGAttributes(This,pATR) (This)->lpVtbl -> GetVMGAttributes(This,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCurrentVideoAttributes(This,pATR) (This)->lpVtbl -> GetCurrentVideoAttributes(This,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetAudioAttributes(This,ulStream,pATR) (This)->lpVtbl -> GetAudioAttributes(This,ulStream,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetKaraokeAttributes(This,ulStream,pAttributes) (This)->lpVtbl -> GetKaraokeAttributes(This,ulStream,pAttributes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetSubpictureAttributes(This,ulStream,pATR) (This)->lpVtbl -> GetSubpictureAttributes(This,ulStream,pATR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDVolumeInfo(This,pulNumOfVolumes,pulVolume,pSide,pulNumOfTitles) (This)->lpVtbl -> GetDVDVolumeInfo(This,pulNumOfVolumes,pulVolume,pSide,pulNumOfTitles)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextNumberOfLanguages(This,pulNumOfLangs) (This)->lpVtbl -> GetDVDTextNumberOfLanguages(This,pulNumOfLangs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextLanguageInfo(This,ulLangIndex,pulNumOfStrings,pLangCode,pbCharacterSet) (This)->lpVtbl -> GetDVDTextLanguageInfo(This,ulLangIndex,pulNumOfStrings,pLangCode,pbCharacterSet)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextStringAsNative(This,ulLangIndex,ulStringIndex,pbBuffer,ulMaxBufferSize,pulActualSize,pType) (This)->lpVtbl -> GetDVDTextStringAsNative(This,ulLangIndex,ulStringIndex,pbBuffer,ulMaxBufferSize,pulActualSize,pType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDTextStringAsUnicode(This,ulLangIndex,ulStringIndex,pchwBuffer,ulMaxBufferSize,pulActualSize,pType) (This)->lpVtbl -> GetDVDTextStringAsUnicode(This,ulLangIndex,ulStringIndex,pchwBuffer,ulMaxBufferSize,pulActualSize,pType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetPlayerParentalLevel(This,pulParentalLevel,pbCountryCode) (This)->lpVtbl -> GetPlayerParentalLevel(This,pulParentalLevel,pbCountryCode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetNumberOfChapters(This,ulTitle,pulNumOfChapters) (This)->lpVtbl -> GetNumberOfChapters(This,ulTitle,pulNumOfChapters)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetTitleParentalLevels(This,ulTitle,pulParentalLevels) (This)->lpVtbl -> GetTitleParentalLevels(This,ulTitle,pulParentalLevels)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDVDDirectory(This,pszwPath,ulMaxSize,pulActualSize) (This)->lpVtbl -> GetDVDDirectory(This,pszwPath,ulMaxSize,pulActualSize)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_IsAudioStreamEnabled(This,ulStreamNum,pbEnabled) (This)->lpVtbl -> IsAudioStreamEnabled(This,ulStreamNum,pbEnabled)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDiscID(This,pszwPath,pullDiscID) (This)->lpVtbl -> GetDiscID(This,pszwPath,pullDiscID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetState(This,pStateData) (This)->lpVtbl -> GetState(This,pStateData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetMenuLanguages(This,pLanguages,ulMaxLanguages,pulActualLanguages) (This)->lpVtbl -> GetMenuLanguages(This,pLanguages,ulMaxLanguages,pulActualLanguages)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetButtonAtPosition(This,point,pulButtonIndex) (This)->lpVtbl -> GetButtonAtPosition(This,point,pulButtonIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetCmdFromEvent(This,lParam1,pCmdObj) (This)->lpVtbl -> GetCmdFromEvent(This,lParam1,pCmdObj)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDefaultMenuLanguage(This,pLanguage) (This)->lpVtbl -> GetDefaultMenuLanguage(This,pLanguage)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDefaultAudioLanguage(This,pLanguage,pAudioExtension) (This)->lpVtbl -> GetDefaultAudioLanguage(This,pLanguage,pAudioExtension)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDefaultSubpictureLanguage(This,pLanguage,pSubpictureExtension) (This)->lpVtbl -> GetDefaultSubpictureLanguage(This,pLanguage,pSubpictureExtension)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetDecoderCaps(This,pCaps) (This)->lpVtbl -> GetDecoderCaps(This,pCaps)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_GetButtonRect(This,ulButton,pRect) (This)->lpVtbl -> GetButtonRect(This,ulButton,pRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdInfo2_IsSubpictureStreamEnabled(This,ulStreamNum,pbEnabled) (This)->lpVtbl -> IsSubpictureStreamEnabled(This,ulStreamNum,pbEnabled)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_GetFiltergraph(This,ppGB) (This)->lpVtbl -> GetFiltergraph(This,ppGB)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_GetDvdInterface(This,riid,ppvIF) (This)->lpVtbl -> GetDvdInterface(This,riid,ppvIF)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDvdGraphBuilder_RenderDvdVideoVolume(This,lpcwszPathName,dwFlags,pStatus) (This)->lpVtbl -> RenderDvdVideoVolume(This,lpcwszPathName,dwFlags,pStatus)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetDDrawObject(This,pDDrawObject) (This)->lpVtbl -> SetDDrawObject(This,pDDrawObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_GetDDrawObject(This,ppDDrawObject,pbUsingExternal) (This)->lpVtbl -> GetDDrawObject(This,ppDDrawObject,pbUsingExternal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetDDrawSurface(This,pDDrawSurface) (This)->lpVtbl -> SetDDrawSurface(This,pDDrawSurface)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_GetDDrawSurface(This,ppDDrawSurface,pbUsingExternal) (This)->lpVtbl -> GetDDrawSurface(This,ppDDrawSurface,pbUsingExternal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetDrawParameters(This,prcSource,prcTarget) (This)->lpVtbl -> SetDrawParameters(This,prcSource,prcTarget)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_GetNativeVideoProps(This,pdwVideoWidth,pdwVideoHeight,pdwPictAspectRatioX,pdwPictAspectRatioY) (This)->lpVtbl -> GetNativeVideoProps(This,pdwVideoWidth,pdwVideoHeight,pdwPictAspectRatioX,pdwPictAspectRatioY)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideo_SetCallbackInterface(This,pCallback,dwFlags) (This)->lpVtbl -> SetCallbackInterface(This,pCallback,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_OnUpdateOverlay(This,bBefore,dwFlags,bOldVisible,prcOldSrc,prcOldDest,bNewVisible,prcNewSrc,prcNewDest) (This)->lpVtbl -> OnUpdateOverlay(This,bBefore,dwFlags,bOldVisible,prcOldSrc,prcOldDest,bNewVisible,prcNewSrc,prcNewDest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_OnUpdateColorKey(This,pKey,dwColor) (This)->lpVtbl -> OnUpdateColorKey(This,pKey,dwColor)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDDrawExclModeVideoCallback_OnUpdateSize(This,dwWidth,dwHeight,dwARWidth,dwARHeight) (This)->lpVtbl -> OnUpdateSize(This,dwWidth,dwHeight,dwARWidth,dwARHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_DynamicQueryAccept(This,pmt) (This)->lpVtbl -> DynamicQueryAccept(This,pmt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_NotifyEndOfStream(This,hNotifyEvent) (This)->lpVtbl -> NotifyEndOfStream(This,hNotifyEvent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_IsEndPin(This) (This)->lpVtbl -> IsEndPin(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinConnection_DynamicDisconnect(This) (This)->lpVtbl -> DynamicDisconnect(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IPinFlowControl_Block(This,dwBlockFlags,hEvent) (This)->lpVtbl -> Block(This,dwBlockFlags,hEvent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_Reconnect(This,pOutputPin,pInputPin,pmtFirstConnection,pUsingFilter,hAbortEvent,dwFlags) (This)->lpVtbl -> Reconnect(This,pOutputPin,pInputPin,pmtFirstConnection,pUsingFilter,hAbortEvent,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_Reconfigure(This,pCallback,pvContext,dwFlags,hAbortEvent) (This)->lpVtbl -> Reconfigure(This,pCallback,pvContext,dwFlags,hAbortEvent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_AddFilterToCache(This,pFilter) (This)->lpVtbl -> AddFilterToCache(This,pFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_EnumCacheFilter(This,pEnum) (This)->lpVtbl -> EnumCacheFilter(This,pEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_RemoveFilterFromCache(This,pFilter) (This)->lpVtbl -> RemoveFilterFromCache(This,pFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_GetStartTime(This,prtStart) (This)->lpVtbl -> GetStartTime(This,prtStart)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_PushThroughData(This,pOutputPin,pConnection,hEventAbort) (This)->lpVtbl -> PushThroughData(This,pOutputPin,pConnection,hEventAbort)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_SetFilterFlags(This,pFilter,dwFlags) (This)->lpVtbl -> SetFilterFlags(This,pFilter,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_GetFilterFlags(This,pFilter,pdwFlags) (This)->lpVtbl -> GetFilterFlags(This,pFilter,pdwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfig_RemoveFilterEx(This,pFilter,Flags) (This)->lpVtbl -> RemoveFilterEx(This,pFilter,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IGraphConfigCallback_Reconfigure(This,pvContext,dwFlags) (This)->lpVtbl -> Reconfigure(This,pvContext,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_StartChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> StartChain(This,pStartFilter,pEndFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_PauseChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> PauseChain(This,pStartFilter,pEndFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_StopChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> StopChain(This,pStartFilter,pEndFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IFilterChain_RemoveChain(This,pStartFilter,pEndFilter) (This)->lpVtbl -> RemoveChain(This,pStartFilter,pEndFilter)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_StartPresenting(This,dwUserID) (This)->lpVtbl -> StartPresenting(This,dwUserID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_StopPresenting(This,dwUserID) (This)->lpVtbl -> StopPresenting(This,dwUserID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenter_PresentImage(This,dwUserID,lpPresInfo) (This)->lpVtbl -> PresentImage(This,dwUserID,lpPresInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_AllocateSurface(This,dwUserID,lpAllocInfo,lpdwActualBuffers,lplpSurface) (This)->lpVtbl -> AllocateSurface(This,dwUserID,lpAllocInfo,lpdwActualBuffers,lplpSurface)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_FreeSurface(This,dwID) (This)->lpVtbl -> FreeSurface(This,dwID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_PrepareSurface(This,dwUserID,lpSurface,dwSurfaceFlags) (This)->lpVtbl -> PrepareSurface(This,dwUserID,lpSurface,dwSurfaceFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocator_AdviseNotify(This,lpIVMRSurfAllocNotify) (This)->lpVtbl -> AdviseNotify(This,lpIVMRSurfAllocNotify)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_AdviseSurfaceAllocator(This,dwUserID,lpIVRMSurfaceAllocator) (This)->lpVtbl -> AdviseSurfaceAllocator(This,dwUserID,lpIVRMSurfaceAllocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_SetDDrawDevice(This,lpDDrawDevice,hMonitor) (This)->lpVtbl -> SetDDrawDevice(This,lpDDrawDevice,hMonitor)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_ChangeDDrawDevice(This,lpDDrawDevice,hMonitor) (This)->lpVtbl -> ChangeDDrawDevice(This,lpDDrawDevice,hMonitor)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_RestoreDDrawSurfaces(This) (This)->lpVtbl -> RestoreDDrawSurfaces(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_NotifyEvent(This,EventCode,Param1,Param2) (This)->lpVtbl -> NotifyEvent(This,EventCode,Param1,Param2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurfaceAllocatorNotify_SetBorderColor(This,clrBorder) (This)->lpVtbl -> SetBorderColor(This,clrBorder)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetNativeVideoSize(This,lpWidth,lpHeight,lpARWidth,lpARHeight) (This)->lpVtbl -> GetNativeVideoSize(This,lpWidth,lpHeight,lpARWidth,lpARHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetMinIdealVideoSize(This,lpWidth,lpHeight) (This)->lpVtbl -> GetMinIdealVideoSize(This,lpWidth,lpHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetMaxIdealVideoSize(This,lpWidth,lpHeight) (This)->lpVtbl -> GetMaxIdealVideoSize(This,lpWidth,lpHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetVideoPosition(This,lpSRCRect,lpDSTRect) (This)->lpVtbl -> SetVideoPosition(This,lpSRCRect,lpDSTRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetVideoPosition(This,lpSRCRect,lpDSTRect) (This)->lpVtbl -> GetVideoPosition(This,lpSRCRect,lpDSTRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetAspectRatioMode(This,lpAspectRatioMode) (This)->lpVtbl -> GetAspectRatioMode(This,lpAspectRatioMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetAspectRatioMode(This,AspectRatioMode) (This)->lpVtbl -> SetAspectRatioMode(This,AspectRatioMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetVideoClippingWindow(This,hwnd) (This)->lpVtbl -> SetVideoClippingWindow(This,hwnd)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_RepaintVideo(This,hwnd,hdc) (This)->lpVtbl -> RepaintVideo(This,hwnd,hdc)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_DisplayModeChanged(This) (This)->lpVtbl -> DisplayModeChanged(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetCurrentImage(This,lpDib) (This)->lpVtbl -> GetCurrentImage(This,lpDib)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetBorderColor(This,Clr) (This)->lpVtbl -> SetBorderColor(This,Clr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetBorderColor(This,lpClr) (This)->lpVtbl -> GetBorderColor(This,lpClr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_SetColorKey(This,Clr) (This)->lpVtbl -> SetColorKey(This,Clr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRWindowlessControl_GetColorKey(This,lpClr) (This)->lpVtbl -> GetColorKey(This,lpClr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetAlpha(This,dwStreamID,Alpha) (This)->lpVtbl -> SetAlpha(This,dwStreamID,Alpha)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetAlpha(This,dwStreamID,pAlpha) (This)->lpVtbl -> GetAlpha(This,dwStreamID,pAlpha)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetZOrder(This,dwStreamID,dwZ) (This)->lpVtbl -> SetZOrder(This,dwStreamID,dwZ)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetZOrder(This,dwStreamID,pZ) (This)->lpVtbl -> GetZOrder(This,dwStreamID,pZ)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetOutputRect(This,dwStreamID,pRect) (This)->lpVtbl -> SetOutputRect(This,dwStreamID,pRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetOutputRect(This,dwStreamID,pRect) (This)->lpVtbl -> GetOutputRect(This,dwStreamID,pRect)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetBackgroundClr(This,ClrBkg) (This)->lpVtbl -> SetBackgroundClr(This,ClrBkg)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetBackgroundClr(This,lpClrBkg) (This)->lpVtbl -> GetBackgroundClr(This,lpClrBkg)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_SetMixingPrefs(This,dwMixerPrefs) (This)->lpVtbl -> SetMixingPrefs(This,dwMixerPrefs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerControl_GetMixingPrefs(This,pdwMixerPrefs) (This)->lpVtbl -> GetMixingPrefs(This,pdwMixerPrefs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_SetMonitor(This,pGUID) (This)->lpVtbl -> SetMonitor(This,pGUID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_GetMonitor(This,pGUID) (This)->lpVtbl -> GetMonitor(This,pGUID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_SetDefaultMonitor(This,pGUID) (This)->lpVtbl -> SetDefaultMonitor(This,pGUID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_GetDefaultMonitor(This,pGUID) (This)->lpVtbl -> GetDefaultMonitor(This,pGUID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMonitorConfig_GetAvailableMonitors(This,pInfo,dwMaxInfoArraySize,pdwNumDevices) (This)->lpVtbl -> GetAvailableMonitors(This,pInfo,dwMaxInfoArraySize,pdwNumDevices)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetImageCompositor(This,lpVMRImgCompositor) (This)->lpVtbl -> SetImageCompositor(This,lpVMRImgCompositor)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetNumberOfStreams(This,dwMaxStreams) (This)->lpVtbl -> SetNumberOfStreams(This,dwMaxStreams)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_GetNumberOfStreams(This,pdwMaxStreams) (This)->lpVtbl -> GetNumberOfStreams(This,pdwMaxStreams)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> SetRenderingPrefs(This,dwRenderFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_GetRenderingPrefs(This,pdwRenderFlags) (This)->lpVtbl -> GetRenderingPrefs(This,pdwRenderFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_SetRenderingMode(This,Mode) (This)->lpVtbl -> SetRenderingMode(This,Mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRFilterConfig_GetRenderingMode(This,pMode) (This)->lpVtbl -> GetRenderingMode(This,pMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_GetAspectRatioMode(This,lpdwARMode) (This)->lpVtbl -> GetAspectRatioMode(This,lpdwARMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRAspectRatioControl_SetAspectRatioMode(This,dwARMode) (This)->lpVtbl -> SetAspectRatioMode(This,dwARMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetNumberOfDeinterlaceModes(This,lpVideoDescription,lpdwNumDeinterlaceModes,lpDeinterlaceModes) (This)->lpVtbl -> GetNumberOfDeinterlaceModes(This,lpVideoDescription,lpdwNumDeinterlaceModes,lpDeinterlaceModes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetDeinterlaceModeCaps(This,lpDeinterlaceMode,lpVideoDescription,lpDeinterlaceCaps) (This)->lpVtbl -> GetDeinterlaceModeCaps(This,lpDeinterlaceMode,lpVideoDescription,lpDeinterlaceCaps)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode) (This)->lpVtbl -> GetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_SetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode) (This)->lpVtbl -> SetDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetDeinterlacePrefs(This,lpdwDeinterlacePrefs) (This)->lpVtbl -> GetDeinterlacePrefs(This,lpdwDeinterlacePrefs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_SetDeinterlacePrefs(This,dwDeinterlacePrefs) (This)->lpVtbl -> SetDeinterlacePrefs(This,dwDeinterlacePrefs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRDeinterlaceControl_GetActualDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode) (This)->lpVtbl -> GetActualDeinterlaceMode(This,dwStreamID,lpDeinterlaceMode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_SetAlphaBitmap(This,pBmpParms) (This)->lpVtbl -> SetAlphaBitmap(This,pBmpParms)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_UpdateAlphaBitmapParameters(This,pBmpParms) (This)->lpVtbl -> UpdateAlphaBitmapParameters(This,pBmpParms)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRMixerBitmap_GetAlphaBitmapParameters(This,pBmpParms) (This)->lpVtbl -> GetAlphaBitmapParameters(This,pBmpParms)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_InitCompositionTarget(This,pD3DDevice,pddsRenderTarget) (This)->lpVtbl -> InitCompositionTarget(This,pD3DDevice,pddsRenderTarget)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_TermCompositionTarget(This,pD3DDevice,pddsRenderTarget) (This)->lpVtbl -> TermCompositionTarget(This,pD3DDevice,pddsRenderTarget)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_SetStreamMediaType(This,dwStrmID,pmt,fTexture) (This)->lpVtbl -> SetStreamMediaType(This,dwStrmID,pmt,fTexture)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImageCompositor_CompositeImage(This,pD3DDevice,pddsRenderTarget,pmtRenderTarget,rtStart,rtEnd,dwClrBkGnd,pVideoStreamInfo,cStreams) (This)->lpVtbl -> CompositeImage(This,pD3DDevice,pddsRenderTarget,pmtRenderTarget,rtStart,rtEnd,dwClrBkGnd,pVideoStreamInfo,cStreams)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_SetColorKey(This,lpClrKey) (This)->lpVtbl -> SetColorKey(This,lpClrKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_GetColorKey(This,lpClrKey) (This)->lpVtbl -> GetColorKey(This,lpClrKey)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_SetStreamActiveState(This,fActive) (This)->lpVtbl -> SetStreamActiveState(This,fActive)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRVideoStreamControl_GetStreamActiveState(This,lpfActive) (This)->lpVtbl -> GetStreamActiveState(This,lpfActive)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_IsSurfaceLocked(This) (This)->lpVtbl -> IsSurfaceLocked(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_LockSurface(This,lpSurface) (This)->lpVtbl -> LockSurface(This,lpSurface)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_UnlockSurface(This) (This)->lpVtbl -> UnlockSurface(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRSurface_GetSurface(This,lplpSurface) (This)->lpVtbl -> GetSurface(This,lplpSurface)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_SetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> SetRenderingPrefs(This,dwRenderFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterConfig_GetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> GetRenderingPrefs(This,dwRenderFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_SetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> SetRenderingPrefs(This,dwRenderFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_GetRenderingPrefs(This,dwRenderFlags) (This)->lpVtbl -> GetRenderingPrefs(This,dwRenderFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_SetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf) (This)->lpVtbl -> SetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVMRImagePresenterExclModeConfig_GetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf) (This)->lpVtbl -> GetXlcModeDDObjAndPrimarySurface(This,lpDDObj,lpPrimarySurf)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_SetVideoPortIndex(This,dwVideoPortIndex) (This)->lpVtbl -> SetVideoPortIndex(This,dwVideoPortIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IVPManager_GetVideoPortIndex(This,pdwVideoPortIndex) (This)->lpVtbl -> GetVideoPortIndex(This,pdwVideoPortIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define V1_ENUM [v1_enum]
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ICreatePropBagOnRegKey_Create(This,hkey,subkey,ulOptions,samDesired,iid,ppBag) (This)->lpVtbl -> Create(This,hkey,subkey,ulOptions,samDesired,iid,ppBag)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get__NewEnum(This,NewEnum) (This)->lpVtbl -> get__NewEnum(This,NewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get_Item(This,varIndex,TuningSpace) (This)->lpVtbl -> get_Item(This,varIndex,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaces_get_EnumTuningSpaces(This,NewEnum) (This)->lpVtbl -> get_EnumTuningSpaces(This,NewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get__NewEnum(This,NewEnum) (This)->lpVtbl -> get__NewEnum(This,NewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_Item(This,varIndex,TuningSpace) (This)->lpVtbl -> get_Item(This,varIndex,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_put_Item(This,varIndex,TuningSpace) (This)->lpVtbl -> put_Item(This,varIndex,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_TuningSpacesForCLSID(This,SpaceCLSID,NewColl) (This)->lpVtbl -> TuningSpacesForCLSID(This,SpaceCLSID,NewColl)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer__TuningSpacesForCLSID(This,SpaceCLSID,NewColl) (This)->lpVtbl -> _TuningSpacesForCLSID(This,SpaceCLSID,NewColl)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_TuningSpacesForName(This,Name,NewColl) (This)->lpVtbl -> TuningSpacesForName(This,Name,NewColl)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_FindID(This,TuningSpace,ID) (This)->lpVtbl -> FindID(This,TuningSpace,ID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Add(This,TuningSpace,NewIndex) (This)->lpVtbl -> Add(This,TuningSpace,NewIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_EnumTuningSpaces(This,ppEnum) (This)->lpVtbl -> get_EnumTuningSpaces(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_Remove(This,Index) (This)->lpVtbl -> Remove(This,Index)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_get_MaxCount(This,MaxCount) (This)->lpVtbl -> get_MaxCount(This,MaxCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpaceContainer_put_MaxCount(This,MaxCount) (This)->lpVtbl -> put_MaxCount(This,MaxCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Next(This,celt,rgelt,pceltFetched) (This)->lpVtbl -> Next(This,celt,rgelt,pceltFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Skip(This,celt) (This)->lpVtbl -> Skip(This,celt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumTuningSpaces_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_get_SystemType(This,SysType) (This)->lpVtbl -> get_SystemType(This,SysType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace_put_SystemType(This,SysType) (This)->lpVtbl -> put_SystemType(This,SysType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_SystemType(This,SysType) (This)->lpVtbl -> get_SystemType(This,SysType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_SystemType(This,SysType) (This)->lpVtbl -> put_SystemType(This,SysType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_get_NetworkID(This,NetworkID) (This)->lpVtbl -> get_NetworkID(This,NetworkID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuningSpace2_put_NetworkID(This,NetworkID) (This)->lpVtbl -> put_NetworkID(This,NetworkID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_SystemType(This,SysType) (This)->lpVtbl -> get_SystemType(This,SysType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_SystemType(This,SysType) (This)->lpVtbl -> put_SystemType(This,SysType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_NetworkID(This,NetworkID) (This)->lpVtbl -> get_NetworkID(This,NetworkID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_NetworkID(This,NetworkID) (This)->lpVtbl -> put_NetworkID(This,NetworkID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_LowOscillator(This,LowOscillator) (This)->lpVtbl -> get_LowOscillator(This,LowOscillator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_LowOscillator(This,LowOscillator) (This)->lpVtbl -> put_LowOscillator(This,LowOscillator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_HighOscillator(This,HighOscillator) (This)->lpVtbl -> get_HighOscillator(This,HighOscillator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_HighOscillator(This,HighOscillator) (This)->lpVtbl -> put_HighOscillator(This,HighOscillator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_LNBSwitch(This,LNBSwitch) (This)->lpVtbl -> get_LNBSwitch(This,LNBSwitch)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_LNBSwitch(This,LNBSwitch) (This)->lpVtbl -> put_LNBSwitch(This,LNBSwitch)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_InputRange(This,InputRange) (This)->lpVtbl -> get_InputRange(This,InputRange)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_InputRange(This,InputRange) (This)->lpVtbl -> put_InputRange(This,InputRange)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_get_SpectralInversion(This,SpectralInversionVal) (This)->lpVtbl -> get_SpectralInversion(This,SpectralInversionVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSTuningSpace_put_SpectralInversion(This,SpectralInversionVal) (This)->lpVtbl -> put_SpectralInversion(This,SpectralInversionVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAuxInTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_MinChannel(This,MinChannelVal) (This)->lpVtbl -> get_MinChannel(This,MinChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_MinChannel(This,NewMinChannelVal) (This)->lpVtbl -> put_MinChannel(This,NewMinChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_MaxChannel(This,MaxChannelVal) (This)->lpVtbl -> get_MaxChannel(This,MaxChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_MaxChannel(This,NewMaxChannelVal) (This)->lpVtbl -> put_MaxChannel(This,NewMaxChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_InputType(This,InputTypeVal) (This)->lpVtbl -> get_InputType(This,InputTypeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_InputType(This,NewInputTypeVal) (This)->lpVtbl -> put_InputType(This,NewInputTypeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_get_CountryCode(This,CountryCodeVal) (This)->lpVtbl -> get_CountryCode(This,CountryCodeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogTVTuningSpace_put_CountryCode(This,NewCountryCodeVal) (This)->lpVtbl -> put_CountryCode(This,NewCountryCodeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MinChannel(This,MinChannelVal) (This)->lpVtbl -> get_MinChannel(This,MinChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MinChannel(This,NewMinChannelVal) (This)->lpVtbl -> put_MinChannel(This,NewMinChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MaxChannel(This,MaxChannelVal) (This)->lpVtbl -> get_MaxChannel(This,MaxChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MaxChannel(This,NewMaxChannelVal) (This)->lpVtbl -> put_MaxChannel(This,NewMaxChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_InputType(This,InputTypeVal) (This)->lpVtbl -> get_InputType(This,InputTypeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_InputType(This,NewInputTypeVal) (This)->lpVtbl -> put_InputType(This,NewInputTypeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_CountryCode(This,CountryCodeVal) (This)->lpVtbl -> get_CountryCode(This,CountryCodeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_CountryCode(This,NewCountryCodeVal) (This)->lpVtbl -> put_CountryCode(This,NewCountryCodeVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MinMinorChannel(This,MinMinorChannelVal) (This)->lpVtbl -> get_MinMinorChannel(This,MinMinorChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MinMinorChannel(This,NewMinMinorChannelVal) (This)->lpVtbl -> put_MinMinorChannel(This,NewMinMinorChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MaxMinorChannel(This,MaxMinorChannelVal) (This)->lpVtbl -> get_MaxMinorChannel(This,MaxMinorChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MaxMinorChannel(This,NewMaxMinorChannelVal) (This)->lpVtbl -> put_MaxMinorChannel(This,NewMaxMinorChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MinPhysicalChannel(This,MinPhysicalChannelVal) (This)->lpVtbl -> get_MinPhysicalChannel(This,MinPhysicalChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MinPhysicalChannel(This,NewMinPhysicalChannelVal) (This)->lpVtbl -> put_MinPhysicalChannel(This,NewMinPhysicalChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_get_MaxPhysicalChannel(This,MaxPhysicalChannelVal) (This)->lpVtbl -> get_MaxPhysicalChannel(This,MaxPhysicalChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCTuningSpace_put_MaxPhysicalChannel(This,NewMaxPhysicalChannelVal) (This)->lpVtbl -> put_MaxPhysicalChannel(This,NewMaxPhysicalChannelVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_UniqueName(This,Name) (This)->lpVtbl -> get_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_UniqueName(This,Name) (This)->lpVtbl -> put_UniqueName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_FriendlyName(This,Name) (This)->lpVtbl -> get_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_FriendlyName(This,Name) (This)->lpVtbl -> put_FriendlyName(This,Name)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_CLSID(This,SpaceCLSID) (This)->lpVtbl -> get_CLSID(This,SpaceCLSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put_NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> get__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put__NetworkType(This,NetworkTypeGuid) (This)->lpVtbl -> put__NetworkType(This,NetworkTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_CreateTuneRequest(This,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_EnumCategoryGUIDs(This,ppEnum) (This)->lpVtbl -> EnumCategoryGUIDs(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_EnumDeviceMonikers(This,ppEnum) (This)->lpVtbl -> EnumDeviceMonikers(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_DefaultPreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_DefaultPreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_DefaultPreferredComponentTypes(This,NewComponentTypes) (This)->lpVtbl -> put_DefaultPreferredComponentTypes(This,NewComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_FrequencyMapping(This,pMapping) (This)->lpVtbl -> get_FrequencyMapping(This,pMapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_FrequencyMapping(This,Mapping) (This)->lpVtbl -> put_FrequencyMapping(This,Mapping)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> get_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_DefaultLocator(This,LocatorVal) (This)->lpVtbl -> put_DefaultLocator(This,LocatorVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_Clone(This,NewTS) (This)->lpVtbl -> Clone(This,NewTS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_MinFrequency(This,MinFrequencyVal) (This)->lpVtbl -> get_MinFrequency(This,MinFrequencyVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_MinFrequency(This,NewMinFrequencyVal) (This)->lpVtbl -> put_MinFrequency(This,NewMinFrequencyVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_MaxFrequency(This,MaxFrequencyVal) (This)->lpVtbl -> get_MaxFrequency(This,MaxFrequencyVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_MaxFrequency(This,NewMaxFrequencyVal) (This)->lpVtbl -> put_MaxFrequency(This,NewMaxFrequencyVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_get_Step(This,StepVal) (This)->lpVtbl -> get_Step(This,StepVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IAnalogRadioTuningSpace_put_Step(This,NewStepVal) (This)->lpVtbl -> put_Step(This,NewStepVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_get_Channel(This,Channel) (This)->lpVtbl -> get_Channel(This,Channel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IChannelTuneRequest_put_Channel(This,Channel) (This)->lpVtbl -> put_Channel(This,Channel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_Channel(This,Channel) (This)->lpVtbl -> get_Channel(This,Channel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_put_Channel(This,Channel) (This)->lpVtbl -> put_Channel(This,Channel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_get_MinorChannel(This,MinorChannel) (This)->lpVtbl -> get_MinorChannel(This,MinorChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCChannelTuneRequest_put_MinorChannel(This,MinorChannel) (This)->lpVtbl -> put_MinorChannel(This,MinorChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_ONID(This,ONID) (This)->lpVtbl -> get_ONID(This,ONID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_ONID(This,ONID) (This)->lpVtbl -> put_ONID(This,ONID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_TSID(This,TSID) (This)->lpVtbl -> get_TSID(This,TSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_TSID(This,TSID) (This)->lpVtbl -> put_TSID(This,TSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_get_SID(This,SID) (This)->lpVtbl -> get_SID(This,SID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTuneRequest_put_SID(This,SID) (This)->lpVtbl -> put_SID(This,SID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_Components(This,Components) (This)->lpVtbl -> get_Components(This,Components)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_Clone(This,NewTuneRequest) (This)->lpVtbl -> Clone(This,NewTuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_Locator(This,Locator) (This)->lpVtbl -> get_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_put_Locator(This,Locator) (This)->lpVtbl -> put_Locator(This,Locator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_TSID(This,TSID) (This)->lpVtbl -> get_TSID(This,TSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_put_TSID(This,TSID) (This)->lpVtbl -> put_TSID(This,TSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_get_ProgNo(This,ProgNo) (This)->lpVtbl -> get_ProgNo(This,ProgNo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequest_put_ProgNo(This,ProgNo) (This)->lpVtbl -> put_ProgNo(This,ProgNo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestFactory_CreateTuneRequest(This,TuningSpace,TuneRequest) (This)->lpVtbl -> CreateTuneRequest(This,TuningSpace,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestSupport_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestSupport_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2TuneRequestSupport_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_put_TuningSpace(This,TuningSpace) (This)->lpVtbl -> put_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_EnumTuningSpaces(This,ppEnum) (This)->lpVtbl -> EnumTuningSpaces(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_TuneRequest(This,TuneRequest) (This)->lpVtbl -> get_TuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_put_TuneRequest(This,TuneRequest) (This)->lpVtbl -> put_TuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_Validate(This,TuneRequest) (This)->lpVtbl -> Validate(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_PreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_put_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> put_PreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_get_SignalStrength(This,Strength) (This)->lpVtbl -> get_SignalStrength(This,Strength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ITuner_TriggerSignalEvents(This,Interval) (This)->lpVtbl -> TriggerSignalEvents(This,Interval)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_TuningSpace(This,TuningSpace) (This)->lpVtbl -> get_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_put_TuningSpace(This,TuningSpace) (This)->lpVtbl -> put_TuningSpace(This,TuningSpace)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_EnumTuningSpaces(This,ppEnum) (This)->lpVtbl -> EnumTuningSpaces(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_TuneRequest(This,TuneRequest) (This)->lpVtbl -> get_TuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_put_TuneRequest(This,TuneRequest) (This)->lpVtbl -> put_TuneRequest(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_Validate(This,TuneRequest) (This)->lpVtbl -> Validate(This,TuneRequest)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> get_PreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_put_PreferredComponentTypes(This,ComponentTypes) (This)->lpVtbl -> put_PreferredComponentTypes(This,ComponentTypes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_get_SignalStrength(This,Strength) (This)->lpVtbl -> get_SignalStrength(This,Strength)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_TriggerSignalEvents(This,Interval) (This)->lpVtbl -> TriggerSignalEvents(This,Interval)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_SeekUp(This) (This)->lpVtbl -> SeekUp(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_SeekDown(This) (This)->lpVtbl -> SeekDown(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_ScanUp(This,MillisecondsPause) (This)->lpVtbl -> ScanUp(This,MillisecondsPause)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_ScanDown(This,MillisecondsPause) (This)->lpVtbl -> ScanDown(This,MillisecondsPause)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IScanningTuner_AutoProgram(This) (This)->lpVtbl -> AutoProgram(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_get_LangID(This,LangID) (This)->lpVtbl -> get_LangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILanguageComponentType_put_LangID(This,LangID) (This)->lpVtbl -> put_LangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_LangID(This,LangID) (This)->lpVtbl -> get_LangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_LangID(This,LangID) (This)->lpVtbl -> put_LangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_get_StreamType(This,MP2StreamType) (This)->lpVtbl -> get_StreamType(This,MP2StreamType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2ComponentType_put_StreamType(This,MP2StreamType) (This)->lpVtbl -> put_StreamType(This,MP2StreamType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_Category(This,Category) (This)->lpVtbl -> get_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_Category(This,Category) (This)->lpVtbl -> put_Category(This,Category)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> get_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaMajorType(This,MediaMajorType) (This)->lpVtbl -> put_MediaMajorType(This,MediaMajorType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> get__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put__MediaMajorType(This,MediaMajorTypeGuid) (This)->lpVtbl -> put__MediaMajorType(This,MediaMajorTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaSubType(This,MediaSubType) (This)->lpVtbl -> get_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaSubType(This,MediaSubType) (This)->lpVtbl -> put_MediaSubType(This,MediaSubType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> get__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put__MediaSubType(This,MediaSubTypeGuid) (This)->lpVtbl -> put__MediaSubType(This,MediaSubTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> get_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaFormatType(This,MediaFormatType) (This)->lpVtbl -> put_MediaFormatType(This,MediaFormatType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> get__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put__MediaFormatType(This,MediaFormatTypeGuid) (This)->lpVtbl -> put__MediaFormatType(This,MediaFormatTypeGuid)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_MediaType(This,MediaType) (This)->lpVtbl -> get_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_MediaType(This,MediaType) (This)->lpVtbl -> put_MediaType(This,MediaType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_Clone(This,NewCT) (This)->lpVtbl -> Clone(This,NewCT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_LangID(This,LangID) (This)->lpVtbl -> get_LangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_LangID(This,LangID) (This)->lpVtbl -> put_LangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_StreamType(This,MP2StreamType) (This)->lpVtbl -> get_StreamType(This,MP2StreamType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_StreamType(This,MP2StreamType) (This)->lpVtbl -> put_StreamType(This,MP2StreamType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_get_Flags(This,Flags) (This)->lpVtbl -> get_Flags(This,Flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCComponentType_put_Flags(This,flags) (This)->lpVtbl -> put_Flags(This,flags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Next(This,celt,rgelt,pceltFetched) (This)->lpVtbl -> Next(This,celt,rgelt,pceltFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Skip(This,celt) (This)->lpVtbl -> Skip(This,celt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponentTypes_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_get__NewEnum(This,ppNewEnum) (This)->lpVtbl -> get__NewEnum(This,ppNewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_EnumComponentTypes(This,ppNewEnum) (This)->lpVtbl -> EnumComponentTypes(This,ppNewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_get_Item(This,Index,ComponentType) (This)->lpVtbl -> get_Item(This,Index,ComponentType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_put_Item(This,Index,ComponentType) (This)->lpVtbl -> put_Item(This,Index,ComponentType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Add(This,ComponentType,NewIndex) (This)->lpVtbl -> Add(This,ComponentType,NewIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Remove(This,Index) (This)->lpVtbl -> Remove(This,Index)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponentTypes_Clone(This,NewList) (This)->lpVtbl -> Clone(This,NewList)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_Type(This,CT) (This)->lpVtbl -> get_Type(This,CT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_Type(This,CT) (This)->lpVtbl -> put_Type(This,CT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_DescLangID(This,LangID) (This)->lpVtbl -> get_DescLangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_DescLangID(This,LangID) (This)->lpVtbl -> put_DescLangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_Status(This,Status) (This)->lpVtbl -> get_Status(This,Status)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_Status(This,Status) (This)->lpVtbl -> put_Status(This,Status)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_get_Description(This,Description) (This)->lpVtbl -> get_Description(This,Description)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_put_Description(This,Description) (This)->lpVtbl -> put_Description(This,Description)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponent_Clone(This,NewComponent) (This)->lpVtbl -> Clone(This,NewComponent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_Type(This,CT) (This)->lpVtbl -> get_Type(This,CT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_Type(This,CT) (This)->lpVtbl -> put_Type(This,CT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_DescLangID(This,LangID) (This)->lpVtbl -> get_DescLangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_DescLangID(This,LangID) (This)->lpVtbl -> put_DescLangID(This,LangID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_Status(This,Status) (This)->lpVtbl -> get_Status(This,Status)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_Status(This,Status) (This)->lpVtbl -> put_Status(This,Status)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_Description(This,Description) (This)->lpVtbl -> get_Description(This,Description)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_Description(This,Description) (This)->lpVtbl -> put_Description(This,Description)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_Clone(This,NewComponent) (This)->lpVtbl -> Clone(This,NewComponent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_PID(This,PID) (This)->lpVtbl -> get_PID(This,PID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_PID(This,PID) (This)->lpVtbl -> put_PID(This,PID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_PCRPID(This,PCRPID) (This)->lpVtbl -> get_PCRPID(This,PCRPID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_PCRPID(This,PCRPID) (This)->lpVtbl -> put_PCRPID(This,PCRPID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_get_ProgramNumber(This,ProgramNumber) (This)->lpVtbl -> get_ProgramNumber(This,ProgramNumber)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMPEG2Component_put_ProgramNumber(This,ProgramNumber) (This)->lpVtbl -> put_ProgramNumber(This,ProgramNumber)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Next(This,celt,rgelt,pceltFetched) (This)->lpVtbl -> Next(This,celt,rgelt,pceltFetched)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Skip(This,celt) (This)->lpVtbl -> Skip(This,celt)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Reset(This) (This)->lpVtbl -> Reset(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEnumComponents_Clone(This,ppEnum) (This)->lpVtbl -> Clone(This,ppEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_get_Count(This,Count) (This)->lpVtbl -> get_Count(This,Count)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_get__NewEnum(This,ppNewEnum) (This)->lpVtbl -> get__NewEnum(This,ppNewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_EnumComponents(This,ppNewEnum) (This)->lpVtbl -> EnumComponents(This,ppNewEnum)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_get_Item(This,Index,ppComponent) (This)->lpVtbl -> get_Item(This,Index,ppComponent)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Add(This,Component,NewIndex) (This)->lpVtbl -> Add(This,Component,NewIndex)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Remove(This,Index) (This)->lpVtbl -> Remove(This,Index)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IComponents_Clone(This,NewList) (This)->lpVtbl -> Clone(This,NewList)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ILocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_PhysicalChannel(This,PhysicalChannel) (This)->lpVtbl -> get_PhysicalChannel(This,PhysicalChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_PhysicalChannel(This,PhysicalChannel) (This)->lpVtbl -> put_PhysicalChannel(This,PhysicalChannel)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_get_TSID(This,TSID) (This)->lpVtbl -> get_TSID(This,TSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IATSCLocator_put_TSID(This,TSID) (This)->lpVtbl -> put_TSID(This,TSID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Bandwidth(This,BandWidthVal) (This)->lpVtbl -> get_Bandwidth(This,BandWidthVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Bandwidth(This,BandwidthVal) (This)->lpVtbl -> put_Bandwidth(This,BandwidthVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_LPInnerFEC(This,FEC) (This)->lpVtbl -> get_LPInnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_LPInnerFEC(This,FEC) (This)->lpVtbl -> put_LPInnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_LPInnerFECRate(This,FEC) (This)->lpVtbl -> get_LPInnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_LPInnerFECRate(This,FEC) (This)->lpVtbl -> put_LPInnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_HAlpha(This,Alpha) (This)->lpVtbl -> get_HAlpha(This,Alpha)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_HAlpha(This,Alpha) (This)->lpVtbl -> put_HAlpha(This,Alpha)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Guard(This,GI) (This)->lpVtbl -> get_Guard(This,GI)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Guard(This,GI) (This)->lpVtbl -> put_Guard(This,GI)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_Mode(This,mode) (This)->lpVtbl -> get_Mode(This,mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_Mode(This,mode) (This)->lpVtbl -> put_Mode(This,mode)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_get_OtherFrequencyInUse(This,OtherFrequencyInUseVal) (This)->lpVtbl -> get_OtherFrequencyInUse(This,OtherFrequencyInUseVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBTLocator_put_OtherFrequencyInUse(This,OtherFrequencyInUseVal) (This)->lpVtbl -> put_OtherFrequencyInUse(This,OtherFrequencyInUseVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_SignalPolarisation(This,PolarisationVal) (This)->lpVtbl -> get_SignalPolarisation(This,PolarisationVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_SignalPolarisation(This,PolarisationVal) (This)->lpVtbl -> put_SignalPolarisation(This,PolarisationVal)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_WestPosition(This,WestLongitude) (This)->lpVtbl -> get_WestPosition(This,WestLongitude)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_WestPosition(This,WestLongitude) (This)->lpVtbl -> put_WestPosition(This,WestLongitude)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_OrbitalPosition(This,longitude) (This)->lpVtbl -> get_OrbitalPosition(This,longitude)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_OrbitalPosition(This,longitude) (This)->lpVtbl -> put_OrbitalPosition(This,longitude)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_Azimuth(This,Azimuth) (This)->lpVtbl -> get_Azimuth(This,Azimuth)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_Azimuth(This,Azimuth) (This)->lpVtbl -> put_Azimuth(This,Azimuth)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_get_Elevation(This,Elevation) (This)->lpVtbl -> get_Elevation(This,Elevation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBSLocator_put_Elevation(This,Elevation) (This)->lpVtbl -> put_Elevation(This,Elevation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_CarrierFrequency(This,Frequency) (This)->lpVtbl -> get_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_CarrierFrequency(This,Frequency) (This)->lpVtbl -> put_CarrierFrequency(This,Frequency)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_InnerFEC(This,FEC) (This)->lpVtbl -> get_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_InnerFEC(This,FEC) (This)->lpVtbl -> put_InnerFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_InnerFECRate(This,FEC) (This)->lpVtbl -> get_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_InnerFECRate(This,FEC) (This)->lpVtbl -> put_InnerFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_OuterFEC(This,FEC) (This)->lpVtbl -> get_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_OuterFEC(This,FEC) (This)->lpVtbl -> put_OuterFEC(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_OuterFECRate(This,FEC) (This)->lpVtbl -> get_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_OuterFECRate(This,FEC) (This)->lpVtbl -> put_OuterFECRate(This,FEC)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_Modulation(This,Modulation) (This)->lpVtbl -> get_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_Modulation(This,Modulation) (This)->lpVtbl -> put_Modulation(This,Modulation)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_get_SymbolRate(This,Rate) (This)->lpVtbl -> get_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_put_SymbolRate(This,Rate) (This)->lpVtbl -> put_SymbolRate(This,Rate)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDVBCLocator_Clone(This,NewLocator) (This)->lpVtbl -> Clone(This,NewLocator)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IBroadcastEvent_Fire(This,EventID) (This)->lpVtbl -> Fire(This,EventID)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SID_SBroadcastEventService CLSID_BroadcastEventService
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_Init(This) (This)->lpVtbl -> Init(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IXDSToRat_ParseXDSBytePair(This,byte1,byte2,pEnSystem,pEnLevel,plBfEnAttributes) (This)->lpVtbl -> ParseXDSBytePair(This,byte1,byte2,pEnSystem,pEnLevel,plBfEnAttributes)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_GetTypeInfoCount(This,pctinfo) (This)->lpVtbl -> GetTypeInfoCount(This,pctinfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_GetTypeInfo(This,iTInfo,lcid,ppTInfo) (This)->lpVtbl -> GetTypeInfo(This,iTInfo,lcid,ppTInfo)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId) (This)->lpVtbl -> GetIDsOfNames(This,riid,rgszNames,cNames,lcid,rgDispId)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr) (This)->lpVtbl -> Invoke(This,dispIdMember,riid,lcid,wFlags,pDispParams,pVarResult,pExcepInfo,puArgErr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_get_BlockedRatingAttributes(This,enSystem,enLevel,plbfAttrs) (This)->lpVtbl -> get_BlockedRatingAttributes(This,enSystem,enLevel,plbfAttrs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_put_BlockedRatingAttributes(This,enSystem,enLevel,lbfAttrs) (This)->lpVtbl -> put_BlockedRatingAttributes(This,enSystem,enLevel,lbfAttrs)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_get_BlockUnRated(This,pfBlockUnRatedShows) (This)->lpVtbl -> get_BlockUnRated(This,pfBlockUnRatedShows)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_put_BlockUnRated(This,fBlockUnRatedShows) (This)->lpVtbl -> put_BlockUnRated(This,fBlockUnRatedShows)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_MostRestrictiveRating(This,enSystem1,enEnLevel1,lbfEnAttr1,enSystem2,enEnLevel2,lbfEnAttr2,penSystem,penEnLevel,plbfEnAttr) (This)->lpVtbl -> MostRestrictiveRating(This,enSystem1,enEnLevel1,lbfEnAttr1,enSystem2,enEnLevel2,lbfEnAttr2,penSystem,penEnLevel,plbfEnAttr)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IEvalRat_TestRating(This,enShowSystem,enShowLevel,lbfEnShowAttributes) (This)->lpVtbl -> TestRating(This,enShowSystem,enShowLevel,lbfEnShowAttributes)

#if __cplusplus
#endif

/* interface __MIDL_itf_segment_0000 */
/* [local] */ 

// +-------------------------------------------------------------------------
// 
//  Microsoft Windows
//  Copyright (C) Microsoft Corporation, 1999-2000.
// 
// --------------------------------------------------------------------------
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <olectl.h>
public enum __MIDL___MIDL_itf_segment_0000_0001
{
        dispidName = 0,
    dispidStatus = dispidName + 1,
    dispidDevImageSourceWidth = dispidStatus + 1,
    dispidDevImageSourceHeight = dispidDevImageSourceWidth + 1,
    dispidDevCountryCode = dispidDevImageSourceHeight + 1,
    dispidDevOverScan = dispidDevCountryCode + 1,
    dispidSegment = dispidDevOverScan + 1,
    dispidDevVolume = dispidSegment + 1,
    dispidDevBalance = dispidDevVolume + 1,
    dispidDevPower = dispidDevBalance + 1,
    dispidTuneChan = dispidDevPower + 1,
    dispidDevVideoSubchannel = dispidTuneChan + 1,
    dispidDevAudioSubchannel = dispidDevVideoSubchannel + 1,
    dispidChannelAvailable = dispidDevAudioSubchannel + 1,
    dispidDevVideoFrequency = dispidChannelAvailable + 1,
    dispidDevAudioFrequency = dispidDevVideoFrequency + 1,
    dispidCount = dispidDevAudioFrequency + 1,
    dispidDevFileName = dispidCount + 1,
    dispidVisible = dispidDevFileName + 1,
    dispidOwner = dispidVisible + 1,
    dispidMessageDrain = dispidOwner + 1,
    dispidViewable = dispidMessageDrain + 1,
    dispidDevView = dispidViewable + 1,
    dispidKSCat = dispidDevView + 1,
    dispidCLSID = dispidKSCat + 1,
    dispid_KSCat = dispidCLSID + 1,
    dispid_CLSID = dispid_KSCat + 1,
    dispidTune = dispid_CLSID + 1,
    dispidTS = dispidTune + 1,
    dispidDevSAP = dispidTS + 1,
    dispidClip = dispidDevSAP + 1,
    dispidRequestedClipRect = dispidClip + 1,
    dispidClippedSourceRect = dispidRequestedClipRect + 1,
    dispidAvailableSourceRect = dispidClippedSourceRect + 1,
    dispidMediaPosition = dispidAvailableSourceRect + 1,
    dispidDevRun = dispidMediaPosition + 1,
    dispidDevPause = dispidDevRun + 1,
    dispidDevStop = dispidDevPause + 1,
    dispidCCEnable = dispidDevStop + 1,
    dispidDevStep = dispidCCEnable + 1,
    dispidDevCanStep = dispidDevStep + 1,
    dispidSourceSize = dispidDevCanStep + 1,
    dispid_playtitle = dispidSourceSize + 1,
    dispid_playchapterintitle = dispid_playtitle + 1,
    dispid_playchapter = dispid_playchapterintitle + 1,
    dispid_playchaptersautostop = dispid_playchapter + 1,
    dispid_playattime = dispid_playchaptersautostop + 1,
    dispid_playattimeintitle = dispid_playattime + 1,
    dispid_playperiodintitleautostop = dispid_playattimeintitle + 1,
    dispid_replaychapter = dispid_playperiodintitleautostop + 1,
    dispid_playprevchapter = dispid_replaychapter + 1,
    dispid_playnextchapter = dispid_playprevchapter + 1,
    dispid_playforwards = dispid_playnextchapter + 1,
    dispid_playbackwards = dispid_playforwards + 1,
    dispid_stilloff = dispid_playbackwards + 1,
    dispid_audiolanguage = dispid_stilloff + 1,
    dispid_showmenu = dispid_audiolanguage + 1,
    dispid_resume = dispid_showmenu + 1,
    dispid_returnfromsubmenu = dispid_resume + 1,
    dispid_buttonsavailable = dispid_returnfromsubmenu + 1,
    dispid_currentbutton = dispid_buttonsavailable + 1,
    dispid_SelectAndActivateButton = dispid_currentbutton + 1,
    dispid_ActivateButton = dispid_SelectAndActivateButton + 1,
    dispid_SelectRightButton = dispid_ActivateButton + 1,
    dispid_SelectLeftButton = dispid_SelectRightButton + 1,
    dispid_SelectLowerButton = dispid_SelectLeftButton + 1,
    dispid_SelectUpperButton = dispid_SelectLowerButton + 1,
    dispid_ActivateAtPosition = dispid_SelectUpperButton + 1,
    dispid_SelectAtPosition = dispid_ActivateAtPosition + 1,
    dispid_ButtonAtPosition = dispid_SelectAtPosition + 1,
    dispid_NumberOfChapters = dispid_ButtonAtPosition + 1,
    dispid_TotalTitleTime = dispid_NumberOfChapters + 1,
    dispid_TitlesAvailable = dispid_TotalTitleTime + 1,
    dispid_VolumesAvailable = dispid_TitlesAvailable + 1,
    dispid_CurrentVolume = dispid_VolumesAvailable + 1,
    dispid_CurrentDiscSide = dispid_CurrentVolume + 1,
    dispid_CurrentDomain = dispid_CurrentDiscSide + 1,
    dispid_CurrentChapter = dispid_CurrentDomain + 1,
    dispid_CurrentTitle = dispid_CurrentChapter + 1,
    dispid_CurrentTime = dispid_CurrentTitle + 1,
    dispid_FramesPerSecond = dispid_CurrentTime + 1,
    dispid_DVDTimeCode2bstr = dispid_FramesPerSecond + 1,
    dispid_DVDDirectory = dispid_DVDTimeCode2bstr + 1,
    dispid_IsSubpictureStreamEnabled = dispid_DVDDirectory + 1,
    dispid_IsAudioStreamEnabled = dispid_IsSubpictureStreamEnabled + 1,
    dispid_CurrentSubpictureStream = dispid_IsAudioStreamEnabled + 1,
    dispid_SubpictureLanguage = dispid_CurrentSubpictureStream + 1,
    dispid_CurrentAudioStream = dispid_SubpictureLanguage + 1,
    dispid_AudioStreamsAvailable = dispid_CurrentAudioStream + 1,
    dispid_AnglesAvailable = dispid_AudioStreamsAvailable + 1,
    dispid_CurrentAngle = dispid_AnglesAvailable + 1,
    dispid_CCActive = dispid_CurrentAngle + 1,
    dispid_CurrentCCService = dispid_CCActive + 1,
    dispid_SubpictureStreamsAvailable = dispid_CurrentCCService + 1,
    dispid_SubpictureOn = dispid_SubpictureStreamsAvailable + 1,
    dispid_DVDUniqueID = dispid_SubpictureOn + 1,
    dispid_EnableResetOnStop = dispid_DVDUniqueID + 1,
    dispid_AcceptParentalLevelChange = dispid_EnableResetOnStop + 1,
    dispid_NotifyParentalLevelChange = dispid_AcceptParentalLevelChange + 1,
    dispid_SelectParentalCountry = dispid_NotifyParentalLevelChange + 1,
    dispid_SelectParentalLevel = dispid_SelectParentalCountry + 1,
    dispid_TitleParentalLevels = dispid_SelectParentalLevel + 1,
    dispid_PlayerParentalCountry = dispid_TitleParentalLevels + 1,
    dispid_PlayerParentalLevel = dispid_PlayerParentalCountry + 1,
    dispid_Eject = dispid_PlayerParentalLevel + 1,
    dispid_UOPValid = dispid_Eject + 1,
    dispid_SPRM = dispid_UOPValid + 1,
    dispid_GPRM = dispid_SPRM + 1,
    dispid_DVDTextStringType = dispid_GPRM + 1,
    dispid_DVDTextString = dispid_DVDTextStringType + 1,
    dispid_DVDTextNumberOfStrings = dispid_DVDTextString + 1,
    dispid_DVDTextNumberOfLanguages = dispid_DVDTextNumberOfStrings + 1,
    dispid_DVDTextLanguageLCID = dispid_DVDTextNumberOfLanguages + 1,
    dispid_RegionChange = dispid_DVDTextLanguageLCID + 1,
    dispid_DVDAdm = dispid_RegionChange + 1,
    dispid_DeleteBookmark = dispid_DVDAdm + 1,
    dispid_RestoreBookmark = dispid_DeleteBookmark + 1,
    dispid_SaveBookmark = dispid_RestoreBookmark + 1,
    dispid_SelectDefaultAudioLanguage = dispid_SaveBookmark + 1,
    dispid_SelectDefaultSubpictureLanguage = dispid_SelectDefaultAudioLanguage + 1,
    dispid_PreferredSubpictureStream = dispid_SelectDefaultSubpictureLanguage + 1,
    dispid_DefaultMenuLanguage = dispid_PreferredSubpictureStream + 1,
    dispid_DefaultSubpictureLanguage = dispid_DefaultMenuLanguage + 1,
    dispid_DefaultAudioLanguage = dispid_DefaultSubpictureLanguage + 1,
    dispid_DefaultSubpictureLanguageExt = dispid_DefaultAudioLanguage + 1,
    dispid_DefaultAudioLanguageExt = dispid_DefaultSubpictureLanguageExt + 1,
    dispid_LanguageFromLCID = dispid_DefaultAudioLanguageExt + 1,
    dispid_KaraokeAudioPresentationMode = dispid_LanguageFromLCID + 1,
    dispid_KaraokeChannelContent = dispid_KaraokeAudioPresentationMode + 1,
    dispid_KaraokeChannelAssignment = dispid_KaraokeChannelContent + 1,
    dispid_RestorePreferredSettings = dispid_KaraokeChannelAssignment + 1,
    dispid_ButtonRect = dispid_RestorePreferredSettings + 1,
    dispid_DVDScreenInMouseCoordinates = dispid_ButtonRect + 1,
    dispid_CustomCompositorClass = dispid_DVDScreenInMouseCoordinates + 1,
    dispidCustomCompositorClass = dispid_CustomCompositorClass + 1,
    dispid_CustomCompositor = dispidCustomCompositorClass + 1,
    dispidMixerBitmap = dispid_CustomCompositor + 1,
    dispid_MixerBitmap = dispidMixerBitmap + 1,
    dispidMixerBitmapOpacity = dispid_MixerBitmap + 1,
    dispidMixerBitmapRect = dispidMixerBitmapOpacity + 1,
    dispidSetupMixerBitmap = dispidMixerBitmapRect + 1,
    dispidUsingOverlay = dispidSetupMixerBitmap + 1,
    dispidDisplayChange = dispidUsingOverlay + 1,
    dispidRePaint = dispidDisplayChange + 1,
    dispid_IsEqualDevice = dispidRePaint + 1,
    dispidrate = dispid_IsEqualDevice + 1,
    dispidposition = dispidrate + 1,
    dispidpositionmode = dispidposition + 1,
    dispidlength = dispidpositionmode + 1,
    dispidChangePassword = dispidlength + 1,
    dispidSaveParentalLevel = dispidChangePassword + 1,
    dispidSaveParentalCountry = dispidSaveParentalLevel + 1,
    dispidConfirmPassword = dispidSaveParentalCountry + 1,
    dispidGetParentalLevel = dispidConfirmPassword + 1,
    dispidGetParentalCountry = dispidGetParentalLevel + 1,
    dispidDefaultAudioLCID = dispidGetParentalCountry + 1,
    dispidDefaultSubpictureLCID = dispidDefaultAudioLCID + 1,
    dispidDefaultMenuLCID = dispidDefaultSubpictureLCID + 1,
    dispidBookmarkOnStop = dispidDefaultMenuLCID + 1,
    dispidMaxVidRect = dispidBookmarkOnStop + 1,
    dispidMinVidRect = dispidMaxVidRect + 1,
    dispidCapture = dispidMinVidRect + 1,
    dispid_DecimateInput = dispidCapture + 1,
    dispidAlloctor = dispid_DecimateInput + 1,
    dispid_Allocator = dispidAlloctor + 1,
    dispidAllocPresentID = dispid_Allocator + 1,
    dispidSetAllocator = dispidAllocPresentID + 1,
    dispid_SetAllocator = dispidSetAllocator + 1,
    dispidStreamBufferSinkName = dispid_SetAllocator + 1,
    dispidStreamBufferSourceName = dispidStreamBufferSinkName + 1,
    dispidStreamBufferContentRecording = dispidStreamBufferSourceName + 1,
    dispidStreamBufferReferenceRecording = dispidStreamBufferContentRecording + 1,
    dispidstarttime = dispidStreamBufferReferenceRecording + 1,
    dispidstoptime = dispidstarttime + 1,
    dispidrecordingstopped = dispidstoptime + 1,
    dispidrecordingstarted = dispidrecordingstopped + 1,
    dispidNameSetLock = dispidrecordingstarted + 1,
    dispidrecordingtype = dispidNameSetLock + 1,
    dispidstart = dispidrecordingtype + 1,
    dispidRecordingAttribute = dispidstart + 1,
    dispid_RecordingAttribute = dispidRecordingAttribute + 1,
    dispidSBEConfigure = dispid_RecordingAttribute + 1,
    dispid_CurrentRatings = dispidSBEConfigure + 1,
    dispid_MaxRatingsLevel = dispid_CurrentRatings + 1,
    dispid_audioencoderint = dispid_MaxRatingsLevel + 1,
    dispid_videoencoderint = dispid_audioencoderint + 1,
    dispidService = dispid_videoencoderint + 1,
    dispid_BlockUnrated = dispidService + 1,
    dispid_UnratedDelay = dispid_BlockUnrated + 1,
    dispid_SuppressEffects = dispid_UnratedDelay + 1,
    dispidsbesource = dispid_SuppressEffects + 1,
    LastReservedDeviceDispid = 0x3fff
}

public enum __MIDL___MIDL_itf_segment_0000_0002
{
        eventidStateChange = 0,
    eventidOnTuneChanged = eventidStateChange + 1,
    eventidEndOfMedia = eventidOnTuneChanged + 1,
    eventidDVDNotify = eventidEndOfMedia + 1,
    eventidPlayForwards = eventidDVDNotify + 1,
    eventidPlayBackwards = eventidPlayForwards + 1,
    eventidShowMenu = eventidPlayBackwards + 1,
    eventidResume = eventidShowMenu + 1,
    eventidSelectOrActivateButton = eventidResume + 1,
    eventidStillOff = eventidSelectOrActivateButton + 1,
    eventidPauseOn = eventidStillOff + 1,
    eventidChangeCurrentAudioStream = eventidPauseOn + 1,
    eventidChangeCurrentSubpictureStream = eventidChangeCurrentAudioStream + 1,
    eventidChangeCurrentAngle = eventidChangeCurrentSubpictureStream + 1,
    eventidPlayAtTimeInTitle = eventidChangeCurrentAngle + 1,
    eventidPlayAtTime = eventidPlayAtTimeInTitle + 1,
    eventidPlayChapterInTitle = eventidPlayAtTime + 1,
    eventidPlayChapter = eventidPlayChapterInTitle + 1,
    eventidReplayChapter = eventidPlayChapter + 1,
    eventidPlayNextChapter = eventidReplayChapter + 1,
    eventidStop = eventidPlayNextChapter + 1,
    eventidReturnFromSubmenu = eventidStop + 1,
    eventidPlayTitle = eventidReturnFromSubmenu + 1,
    eventidPlayPrevChapter = eventidPlayTitle + 1,
    eventidChangeKaraokePresMode = eventidPlayPrevChapter + 1,
    eventidChangeVideoPresMode = eventidChangeKaraokePresMode + 1,
    eventidOverlayUnavailable = eventidChangeVideoPresMode + 1,
    eventidSinkCertificateFailure = eventidOverlayUnavailable + 1,
    eventidSinkCertificateSuccess = eventidSinkCertificateFailure + 1,
    eventidSourceCertificateFailure = eventidSinkCertificateSuccess + 1,
    eventidSourceCertificateSuccess = eventidSourceCertificateFailure + 1,
    eventidRatingsBlocked = eventidSourceCertificateSuccess + 1,
    eventidRatingsUnlocked = eventidRatingsBlocked + 1,
    eventidRatingsChanged = eventidRatingsUnlocked + 1,
    eventidWriteFailure = eventidRatingsChanged + 1,
    eventidTimeHole = eventidWriteFailure + 1,
    eventidStaleDataRead = eventidTimeHole + 1,
    eventidContentBecomingStale = eventidStaleDataRead + 1,
    eventidStaleFileDeleted = eventidContentBecomingStale + 1,
    LastReservedDeviceEvent = 0x3fff
}

public enum __MIDL___MIDL_itf_segment_0000_0003
{
        FrameMode = 0,
    TenthsSecondsMode = FrameMode + 1
}

public enum __MIDL___MIDL_itf_segment_0000_0004
{
        CONTENT = 0,
    REFERENCE = CONTENT + 1
}

public enum __MIDL___MIDL_itf_segment_0000_0005
{
        None = 0,
    Caption1 = None + 1,
    Caption2 = Caption1 + 1,
    Text1 = Caption2 + 1,
    Text2 = Text1 + 1,
    XDS = Text2 + 1
}

#else // C style interface

    public class IMSVidRectVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidRect * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidRect This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidRect * This);
        public delegate uint AddRefDelegate(@interface IMSVidRect This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidRect * This);
        public delegate uint ReleaseDelegate(@interface IMSVidRect This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidRect * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidRect This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidRect * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidRect This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidRect * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidRect This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidRect * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidRect This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Top)(interface IMSVidRect * This, int *TopVal);
        public delegate int get_TopDelegate(@interface IMSVidRect This, ref int TopVal);
        public get_TopDelegate get_Top;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Top)(interface IMSVidRect * This, int TopVal);
        public delegate int put_TopDelegate(@interface IMSVidRect This, int TopVal);
        public put_TopDelegate put_Top;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Left)(interface IMSVidRect * This, int *LeftVal);
        public delegate int get_LeftDelegate(@interface IMSVidRect This, ref int LeftVal);
        public get_LeftDelegate get_Left;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Left)(interface IMSVidRect * This, int LeftVal);
        public delegate int put_LeftDelegate(@interface IMSVidRect This, int LeftVal);
        public put_LeftDelegate put_Left;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Width)(interface IMSVidRect * This, int *WidthVal);
        public delegate int get_WidthDelegate(@interface IMSVidRect This, ref int WidthVal);
        public get_WidthDelegate get_Width;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Width)(interface IMSVidRect * This, int WidthVal);
        public delegate int put_WidthDelegate(@interface IMSVidRect This, int WidthVal);
        public put_WidthDelegate put_Width;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Height)(interface IMSVidRect * This, int *HeightVal);
        public delegate int get_HeightDelegate(@interface IMSVidRect This, ref int HeightVal);
        public get_HeightDelegate get_Height;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Height)(interface IMSVidRect * This, int HeightVal);
        public delegate int put_HeightDelegate(@interface IMSVidRect This, int HeightVal);
        public put_HeightDelegate put_Height;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_HWnd)(interface IMSVidRect * This, System.IntPtr *HWndVal);
        public delegate int get_HWndDelegate(@interface IMSVidRect This, IntPtr HWndVal);
        public get_HWndDelegate get_HWnd;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_HWnd)(interface IMSVidRect * This, System.IntPtr HWndVal);
        public delegate int put_HWndDelegate(@interface IMSVidRect This, IntPtr HWndVal);
        public put_HWndDelegate put_HWnd;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rect)(interface IMSVidRect * This, interface IMSVidRect *RectVal);
        public delegate int put_RectDelegate(@interface IMSVidRect This, @interface IMSVidRect RectVal);
        public put_RectDelegate put_Rect;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidGraphSegmentContainerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidGraphSegmentContainer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidGraphSegmentContainer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidGraphSegmentContainer * This);
        public delegate uint AddRefDelegate(@interface IMSVidGraphSegmentContainer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidGraphSegmentContainer * This);
        public delegate uint ReleaseDelegate(@interface IMSVidGraphSegmentContainer This);
        public ReleaseDelegate Release;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Graph)(interface IMSVidGraphSegmentContainer * This, interface IGraphBuilder **ppGraph);
        public delegate int get_GraphDelegate(@interface IMSVidGraphSegmentContainer This, @interface IGraphBuilder[] ppGraph);
        public get_GraphDelegate get_Graph;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Input)(interface IMSVidGraphSegmentContainer * This, interface IMSVidGraphSegment **pInput);
        public delegate int get_InputDelegate(@interface IMSVidGraphSegmentContainer This, @interface IMSVidGraphSegment[] pInput);
        public get_InputDelegate get_Input;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Outputs)(interface IMSVidGraphSegmentContainer * This, interface IEnumMSVidGraphSegment **pOutputs);
        public delegate int get_OutputsDelegate(@interface IMSVidGraphSegmentContainer This, @interface IEnumMSVidGraphSegment[] pOutputs);
        public get_OutputsDelegate get_Outputs;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoRenderer)(interface IMSVidGraphSegmentContainer * This, interface IMSVidGraphSegment **pVR);
        public delegate int get_VideoRendererDelegate(@interface IMSVidGraphSegmentContainer This, @interface IMSVidGraphSegment[] pVR);
        public get_VideoRendererDelegate get_VideoRenderer;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AudioRenderer)(interface IMSVidGraphSegmentContainer * This, interface IMSVidGraphSegment **pAR);
        public delegate int get_AudioRendererDelegate(@interface IMSVidGraphSegmentContainer This, @interface IMSVidGraphSegment[] pAR);
        public get_AudioRendererDelegate get_AudioRenderer;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Features)(interface IMSVidGraphSegmentContainer * This, interface IEnumMSVidGraphSegment **pOutputs);
        public delegate int get_FeaturesDelegate(@interface IMSVidGraphSegmentContainer This, @interface IEnumMSVidGraphSegment[] pOutputs);
        public get_FeaturesDelegate get_Features;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Composites)(interface IMSVidGraphSegmentContainer * This, interface IEnumMSVidGraphSegment **pComposites);
        public delegate int get_CompositesDelegate(@interface IMSVidGraphSegmentContainer This, @interface IEnumMSVidGraphSegment[] pComposites);
        public get_CompositesDelegate get_Composites;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ParentContainer)(interface IMSVidGraphSegmentContainer * This, object**ppContainer);
        public delegate int get_ParentContainerDelegate(@interface IMSVidGraphSegmentContainer This, object ppContainer[] UnnamedParameter);
        public get_ParentContainerDelegate get_ParentContainer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Decompose)(interface IMSVidGraphSegmentContainer * This, interface IMSVidGraphSegment *pSegment);
        public delegate int DecomposeDelegate(@interface IMSVidGraphSegmentContainer This, @interface IMSVidGraphSegment pSegment);
        public DecomposeDelegate Decompose;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsWindowless)(interface IMSVidGraphSegmentContainer * This);
        public delegate int IsWindowlessDelegate(@interface IMSVidGraphSegmentContainer This);
        public IsWindowlessDelegate IsWindowless;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFocus)(interface IMSVidGraphSegmentContainer * This);
        public delegate int GetFocusDelegate(@interface IMSVidGraphSegmentContainer This);
        public GetFocusDelegate GetFocus;

//        END_INTERFACE
    }





/* interface __MIDL_itf_segment_0464 */
/* [local] */ 

public enum MSVidSegmentType
{
        MSVidSEG_SOURCE = 0,
    MSVidSEG_XFORM = MSVidSEG_SOURCE + 1,
    MSVidSEG_DEST = MSVidSEG_XFORM + 1
}

#else // C style interface

    public class IMSVidGraphSegmentVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidGraphSegment * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidGraphSegment This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidGraphSegment * This);
        public delegate uint AddRefDelegate(@interface IMSVidGraphSegment This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidGraphSegment * This);
        public delegate uint ReleaseDelegate(@interface IMSVidGraphSegment This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClassID)(interface IMSVidGraphSegment * This, CLSID *pClassID);
        public delegate int GetClassIDDelegate(@interface IMSVidGraphSegment This, CLSID pClassID);
        public GetClassIDDelegate GetClassID;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Init)(interface IMSVidGraphSegment * This, object**pInit);
        public delegate int get_InitDelegate(@interface IMSVidGraphSegment This, object pInit[] UnnamedParameter);
        public get_InitDelegate get_Init;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Init)(interface IMSVidGraphSegment * This, object* pInit);
        public delegate int put_InitDelegate(@interface IMSVidGraphSegment This, object pInit);
        public put_InitDelegate put_Init;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumFilters)(interface IMSVidGraphSegment * This, interface IEnumFilters **pNewEnum);
        public delegate int EnumFiltersDelegate(@interface IMSVidGraphSegment This, @interface IEnumFilters[] pNewEnum);
        public EnumFiltersDelegate EnumFilters;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Container)(interface IMSVidGraphSegment * This, interface IMSVidGraphSegmentContainer **ppCtl);
        public delegate int get_ContainerDelegate(@interface IMSVidGraphSegment This, @interface IMSVidGraphSegmentContainer[] ppCtl);
        public get_ContainerDelegate get_Container;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Container)(interface IMSVidGraphSegment * This, interface IMSVidGraphSegmentContainer *pCtl);
        public delegate int put_ContainerDelegate(@interface IMSVidGraphSegment This, @interface IMSVidGraphSegmentContainer pCtl);
        public put_ContainerDelegate put_Container;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Type)(interface IMSVidGraphSegment * This, MSVidSegmentType *pType);
        public delegate int get_TypeDelegate(@interface IMSVidGraphSegment This, MSVidSegmentType pType);
        public get_TypeDelegate get_Type;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidGraphSegment * This, GUID *pGuid);
        public delegate int get_CategoryDelegate(@interface IMSVidGraphSegment This, GUID pGuid);
        public get_CategoryDelegate get_Category;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Build)(interface IMSVidGraphSegment * This);
        public delegate int BuildDelegate(@interface IMSVidGraphSegment This);
        public BuildDelegate Build;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PreRun)(interface IMSVidGraphSegment * This);
        public delegate int PreRunDelegate(@interface IMSVidGraphSegment This);
        public PreRunDelegate PreRun;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PostRun)(interface IMSVidGraphSegment * This);
        public delegate int PostRunDelegate(@interface IMSVidGraphSegment This);
        public PostRunDelegate PostRun;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PreStop)(interface IMSVidGraphSegment * This);
        public delegate int PreStopDelegate(@interface IMSVidGraphSegment This);
        public PreStopDelegate PreStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PostStop)(interface IMSVidGraphSegment * This);
        public delegate int PostStopDelegate(@interface IMSVidGraphSegment This);
        public PostStopDelegate PostStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnEventNotify)(interface IMSVidGraphSegment * This, int lEventCode, System.IntPtr lEventParm1, System.IntPtr lEventParm2);
        public delegate int OnEventNotifyDelegate(@interface IMSVidGraphSegment This, int lEventCode, IntPtr lEventParm1, IntPtr lEventParm2);
        public OnEventNotifyDelegate OnEventNotify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Decompose)(interface IMSVidGraphSegment * This);
        public delegate int DecomposeDelegate(@interface IMSVidGraphSegment This);
        public DecomposeDelegate Decompose;

//        END_INTERFACE
    }





/* interface __MIDL_itf_segment_0465 */
/* [local] */ 


public enum __MIDL___MIDL_itf_segment_0465_0001
{
        MSVIDCTL_LEFT_BUTTON = 0x1,
    MSVIDCTL_RIGHT_BUTTON = 0x2,
    MSVIDCTL_MIDDLE_BUTTON = 0x4,
    MSVIDCTL_X_BUTTON1 = 0x8,
    MSVIDCTL_X_BUTTON2 = 0x10,
    MSVIDCTL_SHIFT = 0x1,
    MSVIDCTL_CTRL = 0x2,
    MSVIDCTL_ALT = 0x4
}

#else // C style interface

    public class IMSVidGraphSegmentUserInputVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidGraphSegmentUserInput * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidGraphSegmentUserInput This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidGraphSegmentUserInput * This);
        public delegate uint AddRefDelegate(@interface IMSVidGraphSegmentUserInput This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidGraphSegmentUserInput * This);
        public delegate uint ReleaseDelegate(@interface IMSVidGraphSegmentUserInput This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Click)(interface IMSVidGraphSegmentUserInput * This);
        public delegate int ClickDelegate(@interface IMSVidGraphSegmentUserInput This);
        public ClickDelegate Click;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DblClick)(interface IMSVidGraphSegmentUserInput * This);
        public delegate int DblClickDelegate(@interface IMSVidGraphSegmentUserInput This);
        public DblClickDelegate DblClick;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *KeyDown)(interface IMSVidGraphSegmentUserInput * This, short *KeyCode, short ShiftState);
        public delegate int KeyDownDelegate(@interface IMSVidGraphSegmentUserInput This, ref short KeyCode, short ShiftState);
        public KeyDownDelegate KeyDown;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *KeyPress)(interface IMSVidGraphSegmentUserInput * This, short *KeyAscii);
        public delegate int KeyPressDelegate(@interface IMSVidGraphSegmentUserInput This, ref short KeyAscii);
        public KeyPressDelegate KeyPress;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *KeyUp)(interface IMSVidGraphSegmentUserInput * This, short *KeyCode, short ShiftState);
        public delegate int KeyUpDelegate(@interface IMSVidGraphSegmentUserInput This, ref short KeyCode, short ShiftState);
        public KeyUpDelegate KeyUp;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MouseDown)(interface IMSVidGraphSegmentUserInput * This, short ButtonState, short ShiftState, OLE_XPOS_PIXELS x, OLE_YPOS_PIXELS y);
        public delegate int MouseDownDelegate(@interface IMSVidGraphSegmentUserInput This, short ButtonState, short ShiftState, OLE_XPOS_PIXELS x, OLE_YPOS_PIXELS y);
        public MouseDownDelegate MouseDown;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MouseMove)(interface IMSVidGraphSegmentUserInput * This, short ButtonState, short ShiftState, OLE_XPOS_PIXELS x, OLE_YPOS_PIXELS y);
        public delegate int MouseMoveDelegate(@interface IMSVidGraphSegmentUserInput This, short ButtonState, short ShiftState, OLE_XPOS_PIXELS x, OLE_YPOS_PIXELS y);
        public MouseMoveDelegate MouseMove;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MouseUp)(interface IMSVidGraphSegmentUserInput * This, short ButtonState, short ShiftState, OLE_XPOS_PIXELS x, OLE_YPOS_PIXELS y);
        public delegate int MouseUpDelegate(@interface IMSVidGraphSegmentUserInput This, short ButtonState, short ShiftState, OLE_XPOS_PIXELS x, OLE_YPOS_PIXELS y);
        public MouseUpDelegate MouseUp;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidCompositionSegmentVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidCompositionSegment * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidCompositionSegment This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidCompositionSegment * This);
        public delegate uint AddRefDelegate(@interface IMSVidCompositionSegment This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidCompositionSegment * This);
        public delegate uint ReleaseDelegate(@interface IMSVidCompositionSegment This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClassID)(interface IMSVidCompositionSegment * This, CLSID *pClassID);
        public delegate int GetClassIDDelegate(@interface IMSVidCompositionSegment This, CLSID pClassID);
        public GetClassIDDelegate GetClassID;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Init)(interface IMSVidCompositionSegment * This, object**pInit);
        public delegate int get_InitDelegate(@interface IMSVidCompositionSegment This, object pInit[] UnnamedParameter);
        public get_InitDelegate get_Init;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Init)(interface IMSVidCompositionSegment * This, object* pInit);
        public delegate int put_InitDelegate(@interface IMSVidCompositionSegment This, object pInit);
        public put_InitDelegate put_Init;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumFilters)(interface IMSVidCompositionSegment * This, interface IEnumFilters **pNewEnum);
        public delegate int EnumFiltersDelegate(@interface IMSVidCompositionSegment This, @interface IEnumFilters[] pNewEnum);
        public EnumFiltersDelegate EnumFilters;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Container)(interface IMSVidCompositionSegment * This, interface IMSVidGraphSegmentContainer **ppCtl);
        public delegate int get_ContainerDelegate(@interface IMSVidCompositionSegment This, @interface IMSVidGraphSegmentContainer[] ppCtl);
        public get_ContainerDelegate get_Container;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Container)(interface IMSVidCompositionSegment * This, interface IMSVidGraphSegmentContainer *pCtl);
        public delegate int put_ContainerDelegate(@interface IMSVidCompositionSegment This, @interface IMSVidGraphSegmentContainer pCtl);
        public put_ContainerDelegate put_Container;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Type)(interface IMSVidCompositionSegment * This, MSVidSegmentType *pType);
        public delegate int get_TypeDelegate(@interface IMSVidCompositionSegment This, MSVidSegmentType pType);
        public get_TypeDelegate get_Type;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidCompositionSegment * This, GUID *pGuid);
        public delegate int get_CategoryDelegate(@interface IMSVidCompositionSegment This, GUID pGuid);
        public get_CategoryDelegate get_Category;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Build)(interface IMSVidCompositionSegment * This);
        public delegate int BuildDelegate(@interface IMSVidCompositionSegment This);
        public BuildDelegate Build;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PreRun)(interface IMSVidCompositionSegment * This);
        public delegate int PreRunDelegate(@interface IMSVidCompositionSegment This);
        public PreRunDelegate PreRun;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PostRun)(interface IMSVidCompositionSegment * This);
        public delegate int PostRunDelegate(@interface IMSVidCompositionSegment This);
        public PostRunDelegate PostRun;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PreStop)(interface IMSVidCompositionSegment * This);
        public delegate int PreStopDelegate(@interface IMSVidCompositionSegment This);
        public PreStopDelegate PreStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PostStop)(interface IMSVidCompositionSegment * This);
        public delegate int PostStopDelegate(@interface IMSVidCompositionSegment This);
        public PostStopDelegate PostStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnEventNotify)(interface IMSVidCompositionSegment * This, int lEventCode, System.IntPtr lEventParm1, System.IntPtr lEventParm2);
        public delegate int OnEventNotifyDelegate(@interface IMSVidCompositionSegment This, int lEventCode, IntPtr lEventParm1, IntPtr lEventParm2);
        public OnEventNotifyDelegate OnEventNotify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Decompose)(interface IMSVidCompositionSegment * This);
        public delegate int DecomposeDelegate(@interface IMSVidCompositionSegment This);
        public DecomposeDelegate Decompose;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Compose)(interface IMSVidCompositionSegment * This, interface IMSVidGraphSegment *upstream, interface IMSVidGraphSegment *downstream);
        public delegate int ComposeDelegate(@interface IMSVidCompositionSegment This, @interface IMSVidGraphSegment upstream, @interface IMSVidGraphSegment downstream);
        public ComposeDelegate Compose;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Up)(interface IMSVidCompositionSegment * This, interface IMSVidGraphSegment **upstream);
        public delegate int get_UpDelegate(@interface IMSVidCompositionSegment This, @interface IMSVidGraphSegment[] upstream);
        public get_UpDelegate get_Up;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Down)(interface IMSVidCompositionSegment * This, interface IMSVidGraphSegment **downstream);
        public delegate int get_DownDelegate(@interface IMSVidCompositionSegment This, @interface IMSVidGraphSegment[] downstream);
        public get_DownDelegate get_Down;

//        END_INTERFACE
    }

#else // C style interface

    public class IEnumMSVidGraphSegmentVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumMSVidGraphSegment * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumMSVidGraphSegment This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumMSVidGraphSegment * This);
        public delegate uint AddRefDelegate(@interface IEnumMSVidGraphSegment This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumMSVidGraphSegment * This);
        public delegate uint ReleaseDelegate(@interface IEnumMSVidGraphSegment This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumMSVidGraphSegment * This, uint celt, interface IMSVidGraphSegment **rgelt, uint *pceltFetched);
        public delegate int NextDelegate(@interface IEnumMSVidGraphSegment This, uint celt, @interface IMSVidGraphSegment[] rgelt, ref uint pceltFetched);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumMSVidGraphSegment * This, uint celt);
        public delegate int SkipDelegate(@interface IEnumMSVidGraphSegment This, uint celt);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumMSVidGraphSegment * This);
        public delegate int ResetDelegate(@interface IEnumMSVidGraphSegment This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumMSVidGraphSegment * This, interface IEnumMSVidGraphSegment **ppenum);
        public delegate int CloneDelegate(@interface IEnumMSVidGraphSegment This, @interface IEnumMSVidGraphSegment[] ppenum);
        public CloneDelegate Clone;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidVRGraphSegmentVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVRGraphSegment * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVRGraphSegment This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVRGraphSegment * This);
        public delegate uint AddRefDelegate(@interface IMSVidVRGraphSegment This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVRGraphSegment * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVRGraphSegment This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClassID)(interface IMSVidVRGraphSegment * This, CLSID *pClassID);
        public delegate int GetClassIDDelegate(@interface IMSVidVRGraphSegment This, CLSID pClassID);
        public GetClassIDDelegate GetClassID;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Init)(interface IMSVidVRGraphSegment * This, object**pInit);
        public delegate int get_InitDelegate(@interface IMSVidVRGraphSegment This, object pInit[] UnnamedParameter);
        public get_InitDelegate get_Init;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Init)(interface IMSVidVRGraphSegment * This, object* pInit);
        public delegate int put_InitDelegate(@interface IMSVidVRGraphSegment This, object pInit);
        public put_InitDelegate put_Init;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumFilters)(interface IMSVidVRGraphSegment * This, interface IEnumFilters **pNewEnum);
        public delegate int EnumFiltersDelegate(@interface IMSVidVRGraphSegment This, @interface IEnumFilters[] pNewEnum);
        public EnumFiltersDelegate EnumFilters;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Container)(interface IMSVidVRGraphSegment * This, interface IMSVidGraphSegmentContainer **ppCtl);
        public delegate int get_ContainerDelegate(@interface IMSVidVRGraphSegment This, @interface IMSVidGraphSegmentContainer[] ppCtl);
        public get_ContainerDelegate get_Container;

        /* [helpstring][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Container)(interface IMSVidVRGraphSegment * This, interface IMSVidGraphSegmentContainer *pCtl);
        public delegate int put_ContainerDelegate(@interface IMSVidVRGraphSegment This, @interface IMSVidGraphSegmentContainer pCtl);
        public put_ContainerDelegate put_Container;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Type)(interface IMSVidVRGraphSegment * This, MSVidSegmentType *pType);
        public delegate int get_TypeDelegate(@interface IMSVidVRGraphSegment This, MSVidSegmentType pType);
        public get_TypeDelegate get_Type;

        /* [helpstring][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidVRGraphSegment * This, GUID *pGuid);
        public delegate int get_CategoryDelegate(@interface IMSVidVRGraphSegment This, GUID pGuid);
        public get_CategoryDelegate get_Category;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Build)(interface IMSVidVRGraphSegment * This);
        public delegate int BuildDelegate(@interface IMSVidVRGraphSegment This);
        public BuildDelegate Build;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PreRun)(interface IMSVidVRGraphSegment * This);
        public delegate int PreRunDelegate(@interface IMSVidVRGraphSegment This);
        public PreRunDelegate PreRun;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PostRun)(interface IMSVidVRGraphSegment * This);
        public delegate int PostRunDelegate(@interface IMSVidVRGraphSegment This);
        public PostRunDelegate PostRun;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PreStop)(interface IMSVidVRGraphSegment * This);
        public delegate int PreStopDelegate(@interface IMSVidVRGraphSegment This);
        public PreStopDelegate PreStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PostStop)(interface IMSVidVRGraphSegment * This);
        public delegate int PostStopDelegate(@interface IMSVidVRGraphSegment This);
        public PostStopDelegate PostStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnEventNotify)(interface IMSVidVRGraphSegment * This, int lEventCode, System.IntPtr lEventParm1, System.IntPtr lEventParm2);
        public delegate int OnEventNotifyDelegate(@interface IMSVidVRGraphSegment This, int lEventCode, IntPtr lEventParm1, IntPtr lEventParm2);
        public OnEventNotifyDelegate OnEventNotify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Decompose)(interface IMSVidVRGraphSegment * This);
        public delegate int DecomposeDelegate(@interface IMSVidVRGraphSegment This);
        public DecomposeDelegate Decompose;

        /* [propput][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__VMRendererMode)(interface IMSVidVRGraphSegment * This, int dwMode);
        public delegate int put__VMRendererModeDelegate(@interface IMSVidVRGraphSegment This, int dwMode);
        public put__VMRendererModeDelegate put__VMRendererMode;

        /* [propput][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Owner)(interface IMSVidVRGraphSegment * This, System.IntPtr Window);
        public delegate int put_OwnerDelegate(@interface IMSVidVRGraphSegment This, IntPtr Window);
        public put_OwnerDelegate put_Owner;

        /* [propget][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Owner)(interface IMSVidVRGraphSegment * This, System.IntPtr *Window);
        public delegate int get_OwnerDelegate(@interface IMSVidVRGraphSegment This, IntPtr Window);
        public get_OwnerDelegate get_Owner;

        /* [propget][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_UseOverlay)(interface IMSVidVRGraphSegment * This, VARIANT_BOOL *UseOverlayVal);
        public delegate int get_UseOverlayDelegate(@interface IMSVidVRGraphSegment This, VARIANT_BOOL UseOverlayVal);
        public get_UseOverlayDelegate get_UseOverlay;

        /* [propput][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_UseOverlay)(interface IMSVidVRGraphSegment * This, VARIANT_BOOL UseOverlayVal);
        public delegate int put_UseOverlayDelegate(@interface IMSVidVRGraphSegment This, VARIANT_BOOL UseOverlayVal);
        public put_UseOverlayDelegate put_UseOverlay;

        /* [propget][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Visible)(interface IMSVidVRGraphSegment * This, VARIANT_BOOL *Visible);
        public delegate int get_VisibleDelegate(@interface IMSVidVRGraphSegment This, VARIANT_BOOL Visible);
        public get_VisibleDelegate get_Visible;

        /* [propput][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Visible)(interface IMSVidVRGraphSegment * This, VARIANT_BOOL Visible);
        public delegate int put_VisibleDelegate(@interface IMSVidVRGraphSegment This, VARIANT_BOOL Visible);
        public put_VisibleDelegate put_Visible;

        /* [restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ColorKey)(interface IMSVidVRGraphSegment * This, OLE_COLOR *ColorKey);
        public delegate int get_ColorKeyDelegate(@interface IMSVidVRGraphSegment This, OLE_COLOR ColorKey);
        public get_ColorKeyDelegate get_ColorKey;

        /* [restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_ColorKey)(interface IMSVidVRGraphSegment * This, OLE_COLOR ColorKey);
        public delegate int put_ColorKeyDelegate(@interface IMSVidVRGraphSegment This, OLE_COLOR ColorKey);
        public put_ColorKeyDelegate put_ColorKey;

        /* [restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Source)(interface IMSVidVRGraphSegment * This, LPRECT r);
        public delegate int get_SourceDelegate(@interface IMSVidVRGraphSegment This, LPRECT r);
        public get_SourceDelegate get_Source;

        /* [restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Source)(interface IMSVidVRGraphSegment * This, RECT r);
        public delegate int put_SourceDelegate(@interface IMSVidVRGraphSegment This, RECT r);
        public put_SourceDelegate put_Source;

        /* [restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Destination)(interface IMSVidVRGraphSegment * This, LPRECT r);
        public delegate int get_DestinationDelegate(@interface IMSVidVRGraphSegment This, LPRECT r);
        public get_DestinationDelegate get_Destination;

        /* [restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Destination)(interface IMSVidVRGraphSegment * This, RECT r);
        public delegate int put_DestinationDelegate(@interface IMSVidVRGraphSegment This, RECT r);
        public put_DestinationDelegate put_Destination;

        /* [restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_NativeSize)(interface IMSVidVRGraphSegment * This, LPSIZE sizeval, LPSIZE aspectratio);
        public delegate int get_NativeSizeDelegate(@interface IMSVidVRGraphSegment This, LPSIZE sizeval, LPSIZE aspectratio);
        public get_NativeSizeDelegate get_NativeSize;

        /* [restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BorderColor)(interface IMSVidVRGraphSegment * This, OLE_COLOR *color);
        public delegate int get_BorderColorDelegate(@interface IMSVidVRGraphSegment This, OLE_COLOR color);
        public get_BorderColorDelegate get_BorderColor;

        /* [restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BorderColor)(interface IMSVidVRGraphSegment * This, OLE_COLOR color);
        public delegate int put_BorderColorDelegate(@interface IMSVidVRGraphSegment This, OLE_COLOR color);
        public put_BorderColorDelegate put_BorderColor;

        /* [restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MaintainAspectRatio)(interface IMSVidVRGraphSegment * This, VARIANT_BOOL *fMaintain);
        public delegate int get_MaintainAspectRatioDelegate(@interface IMSVidVRGraphSegment This, VARIANT_BOOL fMaintain);
        public get_MaintainAspectRatioDelegate get_MaintainAspectRatio;

        /* [restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MaintainAspectRatio)(interface IMSVidVRGraphSegment * This, VARIANT_BOOL fMaintain);
        public delegate int put_MaintainAspectRatioDelegate(@interface IMSVidVRGraphSegment This, VARIANT_BOOL fMaintain);
        public put_MaintainAspectRatioDelegate put_MaintainAspectRatio;

        /* [restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Refresh)(interface IMSVidVRGraphSegment * This);
        public delegate int RefreshDelegate(@interface IMSVidVRGraphSegment This);
        public RefreshDelegate Refresh;

        /* [restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DisplayChange)(interface IMSVidVRGraphSegment * This);
        public delegate int DisplayChangeDelegate(@interface IMSVidVRGraphSegment This);
        public DisplayChangeDelegate DisplayChange;

        /* [restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RePaint)(interface IMSVidVRGraphSegment * This, System.IntPtr hdc);
        public delegate int RePaintDelegate(@interface IMSVidVRGraphSegment This, IntPtr hdc);
        public RePaintDelegate RePaint;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidDeviceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidDevice * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidDevice This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidDevice * This);
        public delegate uint AddRefDelegate(@interface IMSVidDevice This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidDevice * This);
        public delegate uint ReleaseDelegate(@interface IMSVidDevice This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidDevice * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidDevice This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidDevice * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidDevice This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidDevice * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidDevice This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidDevice * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidDevice This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidDevice * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidDevice This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidDevice * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidDevice This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidDevice * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidDevice This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidDevice * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidDevice This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidDevice * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidDevice This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidDevice * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidDevice This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidDevice * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidDevice This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidDevice * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidDevice This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidDevice * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidDevice This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidInputDeviceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidInputDevice * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidInputDevice This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidInputDevice * This);
        public delegate uint AddRefDelegate(@interface IMSVidInputDevice This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidInputDevice * This);
        public delegate uint ReleaseDelegate(@interface IMSVidInputDevice This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidInputDevice * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidInputDevice This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidInputDevice * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidInputDevice This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidInputDevice * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidInputDevice This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidInputDevice * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidInputDevice This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidInputDevice * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidInputDevice This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidInputDevice * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidInputDevice This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidInputDevice * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidInputDevice This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidInputDevice * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidInputDevice This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidInputDevice * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidInputDevice This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidInputDevice * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidInputDevice This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidInputDevice * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidInputDevice This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidInputDevice * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidInputDevice This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidInputDevice * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidInputDevice This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidInputDevice * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidInputDevice This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidInputDevice * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidInputDevice This, VARIANT v);
        public ViewDelegate View;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidDeviceEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidDeviceEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidDeviceEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidDeviceEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidDeviceEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidDeviceEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidDeviceEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidDeviceEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidDeviceEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidDeviceEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidDeviceEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidDeviceEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidDeviceEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidDeviceEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidDeviceEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidDeviceEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidDeviceEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidInputDeviceEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidInputDeviceEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidInputDeviceEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidInputDeviceEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidInputDeviceEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidInputDeviceEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidInputDeviceEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidInputDeviceEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidInputDeviceEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidInputDeviceEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidInputDeviceEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidInputDeviceEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidInputDeviceEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidInputDeviceEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidInputDeviceEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidVideoInputDeviceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVideoInputDevice * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVideoInputDevice This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVideoInputDevice * This);
        public delegate uint AddRefDelegate(@interface IMSVidVideoInputDevice This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVideoInputDevice * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVideoInputDevice This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidVideoInputDevice * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidVideoInputDevice This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidVideoInputDevice * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidVideoInputDevice This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidVideoInputDevice * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidVideoInputDevice This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidVideoInputDevice * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidVideoInputDevice This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidVideoInputDevice * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidVideoInputDevice This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidVideoInputDevice * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidVideoInputDevice This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidVideoInputDevice * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidVideoInputDevice This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidVideoInputDevice * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidVideoInputDevice This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidVideoInputDevice * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidVideoInputDevice This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidVideoInputDevice * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidVideoInputDevice This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidVideoInputDevice * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidVideoInputDevice This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidVideoInputDevice * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidVideoInputDevice This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidVideoInputDevice * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidVideoInputDevice This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidVideoInputDevice * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidVideoInputDevice This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidVideoInputDevice * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidVideoInputDevice This, VARIANT v);
        public ViewDelegate View;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidPlaybackVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidPlayback * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidPlayback This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidPlayback * This);
        public delegate uint AddRefDelegate(@interface IMSVidPlayback This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidPlayback * This);
        public delegate uint ReleaseDelegate(@interface IMSVidPlayback This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidPlayback * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidPlayback This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidPlayback * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidPlayback This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidPlayback * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidPlayback This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidPlayback * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidPlayback This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidPlayback * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidPlayback This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidPlayback * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidPlayback This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidPlayback * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidPlayback This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidPlayback * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidPlayback This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidPlayback * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidPlayback This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidPlayback * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidPlayback This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidPlayback * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidPlayback This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidPlayback * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidPlayback This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidPlayback * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidPlayback This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidPlayback * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidPlayback This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidPlayback * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidPlayback This, VARIANT v);
        public ViewDelegate View;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_EnableResetOnStop)(interface IMSVidPlayback * This, VARIANT_BOOL *pVal);
        public delegate int get_EnableResetOnStopDelegate(@interface IMSVidPlayback This, VARIANT_BOOL pVal);
        public get_EnableResetOnStopDelegate get_EnableResetOnStop;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_EnableResetOnStop)(interface IMSVidPlayback * This, VARIANT_BOOL newVal);
        public delegate int put_EnableResetOnStopDelegate(@interface IMSVidPlayback This, VARIANT_BOOL newVal);
        public put_EnableResetOnStopDelegate put_EnableResetOnStop;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IMSVidPlayback * This);
        public delegate int RunDelegate(@interface IMSVidPlayback This);
        public RunDelegate Run;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IMSVidPlayback * This);
        public delegate int PauseDelegate(@interface IMSVidPlayback This);
        public PauseDelegate Pause;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMSVidPlayback * This);
        public delegate int StopDelegate(@interface IMSVidPlayback This);
        public StopDelegate Stop;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CanStep)(interface IMSVidPlayback * This, VARIANT_BOOL fBackwards, VARIANT_BOOL *pfCan);
        public delegate int get_CanStepDelegate(@interface IMSVidPlayback This, VARIANT_BOOL fBackwards, VARIANT_BOOL pfCan);
        public get_CanStepDelegate get_CanStep;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Step)(interface IMSVidPlayback * This, int lStep);
        public delegate int StepDelegate(@interface IMSVidPlayback This, int lStep);
        public StepDelegate Step;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rate)(interface IMSVidPlayback * This, double plRate);
        public delegate int put_RateDelegate(@interface IMSVidPlayback This, double plRate);
        public put_RateDelegate put_Rate;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Rate)(interface IMSVidPlayback * This, double *plRate);
        public delegate int get_RateDelegate(@interface IMSVidPlayback This, ref double plRate);
        public get_RateDelegate get_Rate;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentPosition)(interface IMSVidPlayback * This, int lPosition);
        public delegate int put_CurrentPositionDelegate(@interface IMSVidPlayback This, int lPosition);
        public put_CurrentPositionDelegate put_CurrentPosition;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentPosition)(interface IMSVidPlayback * This, int *lPosition);
        public delegate int get_CurrentPositionDelegate(@interface IMSVidPlayback This, ref int lPosition);
        public get_CurrentPositionDelegate get_CurrentPosition;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_PositionMode)(interface IMSVidPlayback * This, PositionModeList lPositionMode);
        public delegate int put_PositionModeDelegate(@interface IMSVidPlayback This, PositionModeList lPositionMode);
        public put_PositionModeDelegate put_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PositionMode)(interface IMSVidPlayback * This, PositionModeList *lPositionMode);
        public delegate int get_PositionModeDelegate(@interface IMSVidPlayback This, PositionModeList lPositionMode);
        public get_PositionModeDelegate get_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Length)(interface IMSVidPlayback * This, int *lLength);
        public delegate int get_LengthDelegate(@interface IMSVidPlayback This, ref int lLength);
        public get_LengthDelegate get_Length;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidPlaybackEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidPlaybackEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidPlaybackEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidPlaybackEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidPlaybackEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidPlaybackEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidPlaybackEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidPlaybackEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidPlaybackEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidPlaybackEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidPlaybackEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidPlaybackEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidPlaybackEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidPlaybackEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidPlaybackEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndOfMedia)(interface IMSVidPlaybackEvent * This, interface IMSVidPlayback *lpd);
        public delegate int EndOfMediaDelegate(@interface IMSVidPlaybackEvent This, @interface IMSVidPlayback lpd);
        public EndOfMediaDelegate EndOfMedia;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidTunerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidTuner * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidTuner This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidTuner * This);
        public delegate uint AddRefDelegate(@interface IMSVidTuner This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidTuner * This);
        public delegate uint ReleaseDelegate(@interface IMSVidTuner This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidTuner * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidTuner This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidTuner * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidTuner This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidTuner * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidTuner This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidTuner * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidTuner This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidTuner * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidTuner This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidTuner * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidTuner This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidTuner * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidTuner This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidTuner * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidTuner This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidTuner * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidTuner This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidTuner * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidTuner This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidTuner * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidTuner This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidTuner * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidTuner This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidTuner * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidTuner This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidTuner * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidTuner This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidTuner * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidTuner This, VARIANT v);
        public ViewDelegate View;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Tune)(interface IMSVidTuner * This, interface ITuneRequest **ppTR);
        public delegate int get_TuneDelegate(@interface IMSVidTuner This, @interface ITuneRequest[] ppTR);
        public get_TuneDelegate get_Tune;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Tune)(interface IMSVidTuner * This, interface ITuneRequest *pTR);
        public delegate int put_TuneDelegate(@interface IMSVidTuner This, @interface ITuneRequest pTR);
        public put_TuneDelegate put_Tune;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TuningSpace)(interface IMSVidTuner * This, interface ITuningSpace **plTS);
        public delegate int get_TuningSpaceDelegate(@interface IMSVidTuner This, @interface ITuningSpace[] plTS);
        public get_TuningSpaceDelegate get_TuningSpace;

        /* [id][propput][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuningSpace)(interface IMSVidTuner * This, interface ITuningSpace *plTS);
        public delegate int put_TuningSpaceDelegate(@interface IMSVidTuner This, @interface ITuningSpace plTS);
        public put_TuningSpaceDelegate put_TuningSpace;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidTunerEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidTunerEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidTunerEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidTunerEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidTunerEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidTunerEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidTunerEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidTunerEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidTunerEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidTunerEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidTunerEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidTunerEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidTunerEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidTunerEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidTunerEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TuneChanged)(interface IMSVidTunerEvent * This, interface IMSVidTuner *lpd);
        public delegate int TuneChangedDelegate(@interface IMSVidTunerEvent This, @interface IMSVidTuner lpd);
        public TuneChangedDelegate TuneChanged;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidAnalogTunerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidAnalogTuner * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidAnalogTuner This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidAnalogTuner * This);
        public delegate uint AddRefDelegate(@interface IMSVidAnalogTuner This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidAnalogTuner * This);
        public delegate uint ReleaseDelegate(@interface IMSVidAnalogTuner This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidAnalogTuner * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidAnalogTuner This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidAnalogTuner * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidAnalogTuner This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidAnalogTuner * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidAnalogTuner This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidAnalogTuner * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidAnalogTuner This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidAnalogTuner * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidAnalogTuner This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidAnalogTuner * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidAnalogTuner This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidAnalogTuner * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidAnalogTuner This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidAnalogTuner * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidAnalogTuner This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidAnalogTuner * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidAnalogTuner This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidAnalogTuner * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidAnalogTuner This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidAnalogTuner * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidAnalogTuner This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidAnalogTuner * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidAnalogTuner This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidAnalogTuner * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidAnalogTuner This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidAnalogTuner * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidAnalogTuner This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidAnalogTuner * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidAnalogTuner This, VARIANT v);
        public ViewDelegate View;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Tune)(interface IMSVidAnalogTuner * This, interface ITuneRequest **ppTR);
        public delegate int get_TuneDelegate(@interface IMSVidAnalogTuner This, @interface ITuneRequest[] ppTR);
        public get_TuneDelegate get_Tune;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Tune)(interface IMSVidAnalogTuner * This, interface ITuneRequest *pTR);
        public delegate int put_TuneDelegate(@interface IMSVidAnalogTuner This, @interface ITuneRequest pTR);
        public put_TuneDelegate put_Tune;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TuningSpace)(interface IMSVidAnalogTuner * This, interface ITuningSpace **plTS);
        public delegate int get_TuningSpaceDelegate(@interface IMSVidAnalogTuner This, @interface ITuningSpace[] plTS);
        public get_TuningSpaceDelegate get_TuningSpace;

        /* [id][propput][restricted][hidden] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuningSpace)(interface IMSVidAnalogTuner * This, interface ITuningSpace *plTS);
        public delegate int put_TuningSpaceDelegate(@interface IMSVidAnalogTuner This, @interface ITuningSpace plTS);
        public put_TuningSpaceDelegate put_TuningSpace;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Channel)(interface IMSVidAnalogTuner * This, int *Channel);
        public delegate int get_ChannelDelegate(@interface IMSVidAnalogTuner This, ref int Channel);
        public get_ChannelDelegate get_Channel;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Channel)(interface IMSVidAnalogTuner * This, int Channel);
        public delegate int put_ChannelDelegate(@interface IMSVidAnalogTuner This, int Channel);
        public put_ChannelDelegate put_Channel;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoFrequency)(interface IMSVidAnalogTuner * This, int *lcc);
        public delegate int get_VideoFrequencyDelegate(@interface IMSVidAnalogTuner This, ref int lcc);
        public get_VideoFrequencyDelegate get_VideoFrequency;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AudioFrequency)(interface IMSVidAnalogTuner * This, int *lcc);
        public delegate int get_AudioFrequencyDelegate(@interface IMSVidAnalogTuner This, ref int lcc);
        public get_AudioFrequencyDelegate get_AudioFrequency;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountryCode)(interface IMSVidAnalogTuner * This, int *lcc);
        public delegate int get_CountryCodeDelegate(@interface IMSVidAnalogTuner This, ref int lcc);
        public get_CountryCodeDelegate get_CountryCode;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CountryCode)(interface IMSVidAnalogTuner * This, int lcc);
        public delegate int put_CountryCodeDelegate(@interface IMSVidAnalogTuner This, int lcc);
        public put_CountryCodeDelegate put_CountryCode;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SAP)(interface IMSVidAnalogTuner * This, VARIANT_BOOL *pfSapOn);
        public delegate int get_SAPDelegate(@interface IMSVidAnalogTuner This, VARIANT_BOOL pfSapOn);
        public get_SAPDelegate get_SAP;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SAP)(interface IMSVidAnalogTuner * This, VARIANT_BOOL fSapOn);
        public delegate int put_SAPDelegate(@interface IMSVidAnalogTuner This, VARIANT_BOOL fSapOn);
        public put_SAPDelegate put_SAP;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChannelAvailable)(interface IMSVidAnalogTuner * This, int nChannel, int *SignalStrength, VARIANT_BOOL *fSignalPresent);
        public delegate int ChannelAvailableDelegate(@interface IMSVidAnalogTuner This, int nChannel, ref int SignalStrength, VARIANT_BOOL fSignalPresent);
        public ChannelAvailableDelegate ChannelAvailable;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidAnalogTunerEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidAnalogTunerEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidAnalogTunerEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidAnalogTunerEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidAnalogTunerEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidAnalogTunerEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidAnalogTunerEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidAnalogTunerEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidAnalogTunerEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidAnalogTunerEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidAnalogTunerEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidAnalogTunerEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidAnalogTunerEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidAnalogTunerEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidAnalogTunerEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TuneChanged)(interface IMSVidAnalogTunerEvent * This, interface IMSVidTuner *lpd);
        public delegate int TuneChangedDelegate(@interface IMSVidAnalogTunerEvent This, @interface IMSVidTuner lpd);
        public TuneChangedDelegate TuneChanged;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidFilePlaybackVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidFilePlayback * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidFilePlayback This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidFilePlayback * This);
        public delegate uint AddRefDelegate(@interface IMSVidFilePlayback This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidFilePlayback * This);
        public delegate uint ReleaseDelegate(@interface IMSVidFilePlayback This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidFilePlayback * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidFilePlayback This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidFilePlayback * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidFilePlayback This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidFilePlayback * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidFilePlayback This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidFilePlayback * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidFilePlayback This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidFilePlayback * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidFilePlayback This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidFilePlayback * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidFilePlayback This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidFilePlayback * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidFilePlayback This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidFilePlayback * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidFilePlayback This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidFilePlayback * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidFilePlayback This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidFilePlayback * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidFilePlayback This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidFilePlayback * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidFilePlayback This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidFilePlayback * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidFilePlayback This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidFilePlayback * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidFilePlayback This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidFilePlayback * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidFilePlayback This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidFilePlayback * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidFilePlayback This, VARIANT v);
        public ViewDelegate View;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_EnableResetOnStop)(interface IMSVidFilePlayback * This, VARIANT_BOOL *pVal);
        public delegate int get_EnableResetOnStopDelegate(@interface IMSVidFilePlayback This, VARIANT_BOOL pVal);
        public get_EnableResetOnStopDelegate get_EnableResetOnStop;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_EnableResetOnStop)(interface IMSVidFilePlayback * This, VARIANT_BOOL newVal);
        public delegate int put_EnableResetOnStopDelegate(@interface IMSVidFilePlayback This, VARIANT_BOOL newVal);
        public put_EnableResetOnStopDelegate put_EnableResetOnStop;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IMSVidFilePlayback * This);
        public delegate int RunDelegate(@interface IMSVidFilePlayback This);
        public RunDelegate Run;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IMSVidFilePlayback * This);
        public delegate int PauseDelegate(@interface IMSVidFilePlayback This);
        public PauseDelegate Pause;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMSVidFilePlayback * This);
        public delegate int StopDelegate(@interface IMSVidFilePlayback This);
        public StopDelegate Stop;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CanStep)(interface IMSVidFilePlayback * This, VARIANT_BOOL fBackwards, VARIANT_BOOL *pfCan);
        public delegate int get_CanStepDelegate(@interface IMSVidFilePlayback This, VARIANT_BOOL fBackwards, VARIANT_BOOL pfCan);
        public get_CanStepDelegate get_CanStep;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Step)(interface IMSVidFilePlayback * This, int lStep);
        public delegate int StepDelegate(@interface IMSVidFilePlayback This, int lStep);
        public StepDelegate Step;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rate)(interface IMSVidFilePlayback * This, double plRate);
        public delegate int put_RateDelegate(@interface IMSVidFilePlayback This, double plRate);
        public put_RateDelegate put_Rate;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Rate)(interface IMSVidFilePlayback * This, double *plRate);
        public delegate int get_RateDelegate(@interface IMSVidFilePlayback This, ref double plRate);
        public get_RateDelegate get_Rate;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentPosition)(interface IMSVidFilePlayback * This, int lPosition);
        public delegate int put_CurrentPositionDelegate(@interface IMSVidFilePlayback This, int lPosition);
        public put_CurrentPositionDelegate put_CurrentPosition;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentPosition)(interface IMSVidFilePlayback * This, int *lPosition);
        public delegate int get_CurrentPositionDelegate(@interface IMSVidFilePlayback This, ref int lPosition);
        public get_CurrentPositionDelegate get_CurrentPosition;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_PositionMode)(interface IMSVidFilePlayback * This, PositionModeList lPositionMode);
        public delegate int put_PositionModeDelegate(@interface IMSVidFilePlayback This, PositionModeList lPositionMode);
        public put_PositionModeDelegate put_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PositionMode)(interface IMSVidFilePlayback * This, PositionModeList *lPositionMode);
        public delegate int get_PositionModeDelegate(@interface IMSVidFilePlayback This, PositionModeList lPositionMode);
        public get_PositionModeDelegate get_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Length)(interface IMSVidFilePlayback * This, int *lLength);
        public delegate int get_LengthDelegate(@interface IMSVidFilePlayback This, ref int lLength);
        public get_LengthDelegate get_Length;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FileName)(interface IMSVidFilePlayback * This, char**FileName);
        public delegate int get_FileNameDelegate(@interface IMSVidFilePlayback This, char * FileName[] UnnamedParameter);
        public get_FileNameDelegate get_FileName;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_FileName)(interface IMSVidFilePlayback * This, char* FileName);
        public delegate int put_FileNameDelegate(@interface IMSVidFilePlayback This, ref string FileName);
        public put_FileNameDelegate put_FileName;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidFilePlaybackEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidFilePlaybackEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidFilePlaybackEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidFilePlaybackEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidFilePlaybackEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidFilePlaybackEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidFilePlaybackEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidFilePlaybackEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidFilePlaybackEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidFilePlaybackEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidFilePlaybackEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidFilePlaybackEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidFilePlaybackEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidFilePlaybackEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidFilePlaybackEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndOfMedia)(interface IMSVidFilePlaybackEvent * This, interface IMSVidPlayback *lpd);
        public delegate int EndOfMediaDelegate(@interface IMSVidFilePlaybackEvent This, @interface IMSVidPlayback lpd);
        public EndOfMediaDelegate EndOfMedia;

//        END_INTERFACE
    }






/* interface __MIDL_itf_segment_0482 */
/* [local] */ 

public enum __MIDL___MIDL_itf_segment_0482_0001
{
        dvdMenu_Title = 2,
    dvdMenu_Root = dvdMenu_Title + 1,
    dvdMenu_Subpicture = dvdMenu_Root + 1,
    dvdMenu_Audio = dvdMenu_Subpicture + 1,
    dvdMenu_Angle = dvdMenu_Audio + 1,
    dvdMenu_Chapter = dvdMenu_Angle + 1
}

public enum __MIDL___MIDL_itf_segment_0482_0002
{
        dvdState_Undefined = -2,
    dvdState_Unitialized = dvdState_Undefined + 1,
    dvdState_Stopped = dvdState_Unitialized + 1,
    dvdState_Paused = dvdState_Stopped + 1,
    dvdState_Running = dvdState_Paused + 1
}

public enum __MIDL___MIDL_itf_segment_0482_0003
{
        dvdStruct_Volume = 0x1,
    dvdStruct_Title = 0x2,
    dvdStruct_ParentalID = 0x3,
    dvdStruct_PartOfTitle = 0x4,
    dvdStruct_Cell = 0x5,
    dvdStream_Audio = 0x10,
    dvdStream_Subpicture = 0x11,
    dvdStream_Angle = 0x12,
    dvdChannel_Audio = 0x20,
    dvdGeneral_Name = 0x30,
    dvdGeneral_Comments = 0x31,
    dvdTitle_Series = 0x38,
    dvdTitle_Movie = 0x39,
    dvdTitle_Video = 0x3a,
    dvdTitle_Album = 0x3b,
    dvdTitle_Song = 0x3c,
    dvdTitle_Other = 0x3f,
    dvdTitle_Sub_Series = 0x40,
    dvdTitle_Sub_Movie = 0x41,
    dvdTitle_Sub_Video = 0x42,
    dvdTitle_Sub_Album = 0x43,
    dvdTitle_Sub_Song = 0x44,
    dvdTitle_Sub_Other = 0x47,
    dvdTitle_Orig_Series = 0x48,
    dvdTitle_Orig_Movie = 0x49,
    dvdTitle_Orig_Video = 0x4a,
    dvdTitle_Orig_Album = 0x4b,
    dvdTitle_Orig_Song = 0x4c,
    dvdTitle_Orig_Other = 0x4f,
    dvdOther_Scene = 0x50,
    dvdOther_Cut = 0x51,
    dvdOther_Take = 0x52
}

public enum __MIDL___MIDL_itf_segment_0482_0004
{
        dvdSPExt_NotSpecified = 0,
    dvdSPExt_Caption_Normal = 1,
    dvdSPExt_Caption_Big = 2,
    dvdSPExt_Caption_Children = 3,
    dvdSPExt_CC_Normal = 5,
    dvdSPExt_CC_Big = 6,
    dvdSPExt_CC_Children = 7,
    dvdSPExt_Forced = 9,
    dvdSPExt_DirectorComments_Normal = 13,
    dvdSPExt_DirectorComments_Big = 14,
    dvdSPExt_DirectorComments_Children = 15
}

#else // C style interface

    public class IMSVidWebDVDVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidWebDVD * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidWebDVD This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidWebDVD * This);
        public delegate uint AddRefDelegate(@interface IMSVidWebDVD This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidWebDVD * This);
        public delegate uint ReleaseDelegate(@interface IMSVidWebDVD This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidWebDVD * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidWebDVD This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidWebDVD * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidWebDVD This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidWebDVD * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidWebDVD This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidWebDVD * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidWebDVD This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidWebDVD * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidWebDVD This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidWebDVD * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidWebDVD This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidWebDVD * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidWebDVD * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidWebDVD * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidWebDVD This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidWebDVD * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidWebDVD This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidWebDVD * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidWebDVD This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidWebDVD * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidWebDVD This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidWebDVD * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidWebDVD This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidWebDVD * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidWebDVD This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidWebDVD * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidWebDVD This, VARIANT v);
        public ViewDelegate View;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_EnableResetOnStop)(interface IMSVidWebDVD * This, VARIANT_BOOL *pVal);
        public delegate int get_EnableResetOnStopDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL pVal);
        public get_EnableResetOnStopDelegate get_EnableResetOnStop;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_EnableResetOnStop)(interface IMSVidWebDVD * This, VARIANT_BOOL newVal);
        public delegate int put_EnableResetOnStopDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL newVal);
        public put_EnableResetOnStopDelegate put_EnableResetOnStop;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IMSVidWebDVD * This);
        public delegate int RunDelegate(@interface IMSVidWebDVD This);
        public RunDelegate Run;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IMSVidWebDVD * This);
        public delegate int PauseDelegate(@interface IMSVidWebDVD This);
        public PauseDelegate Pause;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMSVidWebDVD * This);
        public delegate int StopDelegate(@interface IMSVidWebDVD This);
        public StopDelegate Stop;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CanStep)(interface IMSVidWebDVD * This, VARIANT_BOOL fBackwards, VARIANT_BOOL *pfCan);
        public delegate int get_CanStepDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL fBackwards, VARIANT_BOOL pfCan);
        public get_CanStepDelegate get_CanStep;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Step)(interface IMSVidWebDVD * This, int lStep);
        public delegate int StepDelegate(@interface IMSVidWebDVD This, int lStep);
        public StepDelegate Step;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rate)(interface IMSVidWebDVD * This, double plRate);
        public delegate int put_RateDelegate(@interface IMSVidWebDVD This, double plRate);
        public put_RateDelegate put_Rate;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Rate)(interface IMSVidWebDVD * This, double *plRate);
        public delegate int get_RateDelegate(@interface IMSVidWebDVD This, ref double plRate);
        public get_RateDelegate get_Rate;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentPosition)(interface IMSVidWebDVD * This, int lPosition);
        public delegate int put_CurrentPositionDelegate(@interface IMSVidWebDVD This, int lPosition);
        public put_CurrentPositionDelegate put_CurrentPosition;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentPosition)(interface IMSVidWebDVD * This, int *lPosition);
        public delegate int get_CurrentPositionDelegate(@interface IMSVidWebDVD This, ref int lPosition);
        public get_CurrentPositionDelegate get_CurrentPosition;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_PositionMode)(interface IMSVidWebDVD * This, PositionModeList lPositionMode);
        public delegate int put_PositionModeDelegate(@interface IMSVidWebDVD This, PositionModeList lPositionMode);
        public put_PositionModeDelegate put_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PositionMode)(interface IMSVidWebDVD * This, PositionModeList *lPositionMode);
        public delegate int get_PositionModeDelegate(@interface IMSVidWebDVD This, PositionModeList lPositionMode);
        public get_PositionModeDelegate get_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Length)(interface IMSVidWebDVD * This, int *lLength);
        public delegate int get_LengthDelegate(@interface IMSVidWebDVD This, ref int lLength);
        public get_LengthDelegate get_Length;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnDVDEvent)(interface IMSVidWebDVD * This, int lEvent, System.IntPtr lParam1, System.IntPtr lParam2);
        public delegate int OnDVDEventDelegate(@interface IMSVidWebDVD This, int lEvent, IntPtr lParam1, IntPtr lParam2);
        public OnDVDEventDelegate OnDVDEvent;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayTitle)(interface IMSVidWebDVD * This, int lTitle);
        public delegate int PlayTitleDelegate(@interface IMSVidWebDVD This, int lTitle);
        public PlayTitleDelegate PlayTitle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChapterInTitle)(interface IMSVidWebDVD * This, int lTitle, int lChapter);
        public delegate int PlayChapterInTitleDelegate(@interface IMSVidWebDVD This, int lTitle, int lChapter);
        public PlayChapterInTitleDelegate PlayChapterInTitle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChapter)(interface IMSVidWebDVD * This, int lChapter);
        public delegate int PlayChapterDelegate(@interface IMSVidWebDVD This, int lChapter);
        public PlayChapterDelegate PlayChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChaptersAutoStop)(interface IMSVidWebDVD * This, int lTitle, int lstrChapter, int lChapterCount);
        public delegate int PlayChaptersAutoStopDelegate(@interface IMSVidWebDVD This, int lTitle, int lstrChapter, int lChapterCount);
        public PlayChaptersAutoStopDelegate PlayChaptersAutoStop;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayAtTime)(interface IMSVidWebDVD * This, char* strTime);
        public delegate int PlayAtTimeDelegate(@interface IMSVidWebDVD This, ref string strTime);
        public PlayAtTimeDelegate PlayAtTime;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayAtTimeInTitle)(interface IMSVidWebDVD * This, int lTitle, char* strTime);
        public delegate int PlayAtTimeInTitleDelegate(@interface IMSVidWebDVD This, int lTitle, ref string strTime);
        public PlayAtTimeInTitleDelegate PlayAtTimeInTitle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayPeriodInTitleAutoStop)(interface IMSVidWebDVD * This, int lTitle, char* strStartTime, char* strEndTime);
        public delegate int PlayPeriodInTitleAutoStopDelegate(@interface IMSVidWebDVD This, int lTitle, ref string strStartTime, ref string strEndTime);
        public PlayPeriodInTitleAutoStopDelegate PlayPeriodInTitleAutoStop;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReplayChapter)(interface IMSVidWebDVD * This);
        public delegate int ReplayChapterDelegate(@interface IMSVidWebDVD This);
        public ReplayChapterDelegate ReplayChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayPrevChapter)(interface IMSVidWebDVD * This);
        public delegate int PlayPrevChapterDelegate(@interface IMSVidWebDVD This);
        public PlayPrevChapterDelegate PlayPrevChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayNextChapter)(interface IMSVidWebDVD * This);
        public delegate int PlayNextChapterDelegate(@interface IMSVidWebDVD This);
        public PlayNextChapterDelegate PlayNextChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StillOff)(interface IMSVidWebDVD * This);
        public delegate int StillOffDelegate(@interface IMSVidWebDVD This);
        public StillOffDelegate StillOff;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AudioLanguage)(interface IMSVidWebDVD * This, int lStream, VARIANT_BOOL fFormat, char**strAudioLang);
        public delegate int get_AudioLanguageDelegate(@interface IMSVidWebDVD This, int lStream, VARIANT_BOOL fFormat, char * strAudioLang[] UnnamedParameter);
        public get_AudioLanguageDelegate get_AudioLanguage;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShowMenu)(interface IMSVidWebDVD * This, DVDMenuIDConstants MenuID);
        public delegate int ShowMenuDelegate(@interface IMSVidWebDVD This, DVDMenuIDConstants MenuID);
        public ShowMenuDelegate ShowMenu;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Resume)(interface IMSVidWebDVD * This);
        public delegate int ResumeDelegate(@interface IMSVidWebDVD This);
        public ResumeDelegate Resume;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReturnFromSubmenu)(interface IMSVidWebDVD * This);
        public delegate int ReturnFromSubmenuDelegate(@interface IMSVidWebDVD This);
        public ReturnFromSubmenuDelegate ReturnFromSubmenu;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ButtonsAvailable)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_ButtonsAvailableDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_ButtonsAvailableDelegate get_ButtonsAvailable;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentButton)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentButtonDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentButtonDelegate get_CurrentButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectAndActivateButton)(interface IMSVidWebDVD * This, int lButton);
        public delegate int SelectAndActivateButtonDelegate(@interface IMSVidWebDVD This, int lButton);
        public SelectAndActivateButtonDelegate SelectAndActivateButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ActivateButton)(interface IMSVidWebDVD * This);
        public delegate int ActivateButtonDelegate(@interface IMSVidWebDVD This);
        public ActivateButtonDelegate ActivateButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectRightButton)(interface IMSVidWebDVD * This);
        public delegate int SelectRightButtonDelegate(@interface IMSVidWebDVD This);
        public SelectRightButtonDelegate SelectRightButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectLeftButton)(interface IMSVidWebDVD * This);
        public delegate int SelectLeftButtonDelegate(@interface IMSVidWebDVD This);
        public SelectLeftButtonDelegate SelectLeftButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectLowerButton)(interface IMSVidWebDVD * This);
        public delegate int SelectLowerButtonDelegate(@interface IMSVidWebDVD This);
        public SelectLowerButtonDelegate SelectLowerButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectUpperButton)(interface IMSVidWebDVD * This);
        public delegate int SelectUpperButtonDelegate(@interface IMSVidWebDVD This);
        public SelectUpperButtonDelegate SelectUpperButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ActivateAtPosition)(interface IMSVidWebDVD * This, int xPos, int yPos);
        public delegate int ActivateAtPositionDelegate(@interface IMSVidWebDVD This, int xPos, int yPos);
        public ActivateAtPositionDelegate ActivateAtPosition;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectAtPosition)(interface IMSVidWebDVD * This, int xPos, int yPos);
        public delegate int SelectAtPositionDelegate(@interface IMSVidWebDVD This, int xPos, int yPos);
        public SelectAtPositionDelegate SelectAtPosition;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ButtonAtPosition)(interface IMSVidWebDVD * This, int xPos, int yPos, int *plButton);
        public delegate int get_ButtonAtPositionDelegate(@interface IMSVidWebDVD This, int xPos, int yPos, ref int plButton);
        public get_ButtonAtPositionDelegate get_ButtonAtPosition;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_NumberOfChapters)(interface IMSVidWebDVD * This, int lTitle, int *pVal);
        public delegate int get_NumberOfChaptersDelegate(@interface IMSVidWebDVD This, int lTitle, ref int pVal);
        public get_NumberOfChaptersDelegate get_NumberOfChapters;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TotalTitleTime)(interface IMSVidWebDVD * This, char**pVal);
        public delegate int get_TotalTitleTimeDelegate(@interface IMSVidWebDVD This, char * pVal[] UnnamedParameter);
        public get_TotalTitleTimeDelegate get_TotalTitleTime;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TitlesAvailable)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_TitlesAvailableDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_TitlesAvailableDelegate get_TitlesAvailable;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VolumesAvailable)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_VolumesAvailableDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_VolumesAvailableDelegate get_VolumesAvailable;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentVolume)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentVolumeDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentVolumeDelegate get_CurrentVolume;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentDiscSide)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentDiscSideDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentDiscSideDelegate get_CurrentDiscSide;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentDomain)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentDomainDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentDomainDelegate get_CurrentDomain;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentChapter)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentChapterDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentChapterDelegate get_CurrentChapter;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentTitle)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentTitleDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentTitleDelegate get_CurrentTitle;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentTime)(interface IMSVidWebDVD * This, char**pVal);
        public delegate int get_CurrentTimeDelegate(@interface IMSVidWebDVD This, char * pVal[] UnnamedParameter);
        public get_CurrentTimeDelegate get_CurrentTime;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DVDTimeCode2bstr)(interface IMSVidWebDVD * This, int timeCode, char**pTimeStr);
        public delegate int DVDTimeCode2bstrDelegate(@interface IMSVidWebDVD This, int timeCode, char * pTimeStr[] UnnamedParameter);
        public DVDTimeCode2bstrDelegate DVDTimeCode2bstr;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDDirectory)(interface IMSVidWebDVD * This, char**pVal);
        public delegate int get_DVDDirectoryDelegate(@interface IMSVidWebDVD This, char * pVal[] UnnamedParameter);
        public get_DVDDirectoryDelegate get_DVDDirectory;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DVDDirectory)(interface IMSVidWebDVD * This, char* newVal);
        public delegate int put_DVDDirectoryDelegate(@interface IMSVidWebDVD This, ref string newVal);
        public put_DVDDirectoryDelegate put_DVDDirectory;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSubpictureStreamEnabled)(interface IMSVidWebDVD * This, int lstream, VARIANT_BOOL *fEnabled);
        public delegate int IsSubpictureStreamEnabledDelegate(@interface IMSVidWebDVD This, int lstream, VARIANT_BOOL fEnabled);
        public IsSubpictureStreamEnabledDelegate IsSubpictureStreamEnabled;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsAudioStreamEnabled)(interface IMSVidWebDVD * This, int lstream, VARIANT_BOOL *fEnabled);
        public delegate int IsAudioStreamEnabledDelegate(@interface IMSVidWebDVD This, int lstream, VARIANT_BOOL fEnabled);
        public IsAudioStreamEnabledDelegate IsAudioStreamEnabled;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentSubpictureStream)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentSubpictureStreamDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentSubpictureStreamDelegate get_CurrentSubpictureStream;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentSubpictureStream)(interface IMSVidWebDVD * This, int newVal);
        public delegate int put_CurrentSubpictureStreamDelegate(@interface IMSVidWebDVD This, int newVal);
        public put_CurrentSubpictureStreamDelegate put_CurrentSubpictureStream;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SubpictureLanguage)(interface IMSVidWebDVD * This, int lStream, char**strLanguage);
        public delegate int get_SubpictureLanguageDelegate(@interface IMSVidWebDVD This, int lStream, char * strLanguage[] UnnamedParameter);
        public get_SubpictureLanguageDelegate get_SubpictureLanguage;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentAudioStream)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentAudioStreamDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentAudioStreamDelegate get_CurrentAudioStream;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentAudioStream)(interface IMSVidWebDVD * This, int newVal);
        public delegate int put_CurrentAudioStreamDelegate(@interface IMSVidWebDVD This, int newVal);
        public put_CurrentAudioStreamDelegate put_CurrentAudioStream;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AudioStreamsAvailable)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_AudioStreamsAvailableDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_AudioStreamsAvailableDelegate get_AudioStreamsAvailable;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AnglesAvailable)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_AnglesAvailableDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_AnglesAvailableDelegate get_AnglesAvailable;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentAngle)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_CurrentAngleDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_CurrentAngleDelegate get_CurrentAngle;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentAngle)(interface IMSVidWebDVD * This, int newVal);
        public delegate int put_CurrentAngleDelegate(@interface IMSVidWebDVD This, int newVal);
        public put_CurrentAngleDelegate put_CurrentAngle;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SubpictureStreamsAvailable)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_SubpictureStreamsAvailableDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_SubpictureStreamsAvailableDelegate get_SubpictureStreamsAvailable;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SubpictureOn)(interface IMSVidWebDVD * This, VARIANT_BOOL *pVal);
        public delegate int get_SubpictureOnDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL pVal);
        public get_SubpictureOnDelegate get_SubpictureOn;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SubpictureOn)(interface IMSVidWebDVD * This, VARIANT_BOOL newVal);
        public delegate int put_SubpictureOnDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL newVal);
        public put_SubpictureOnDelegate put_SubpictureOn;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDUniqueID)(interface IMSVidWebDVD * This, char**pVal);
        public delegate int get_DVDUniqueIDDelegate(@interface IMSVidWebDVD This, char * pVal[] UnnamedParameter);
        public get_DVDUniqueIDDelegate get_DVDUniqueID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AcceptParentalLevelChange)(interface IMSVidWebDVD * This, VARIANT_BOOL fAccept, char* strUserName, char* strPassword);
        public delegate int AcceptParentalLevelChangeDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL fAccept, ref string strUserName, ref string strPassword);
        public AcceptParentalLevelChangeDelegate AcceptParentalLevelChange;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyParentalLevelChange)(interface IMSVidWebDVD * This, VARIANT_BOOL newVal);
        public delegate int NotifyParentalLevelChangeDelegate(@interface IMSVidWebDVD This, VARIANT_BOOL newVal);
        public NotifyParentalLevelChangeDelegate NotifyParentalLevelChange;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectParentalCountry)(interface IMSVidWebDVD * This, int lCountry, char* strUserName, char* strPassword);
        public delegate int SelectParentalCountryDelegate(@interface IMSVidWebDVD This, int lCountry, ref string strUserName, ref string strPassword);
        public SelectParentalCountryDelegate SelectParentalCountry;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectParentalLevel)(interface IMSVidWebDVD * This, int lParentalLevel, char* strUserName, char* strPassword);
        public delegate int SelectParentalLevelDelegate(@interface IMSVidWebDVD This, int lParentalLevel, ref string strUserName, ref string strPassword);
        public SelectParentalLevelDelegate SelectParentalLevel;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TitleParentalLevels)(interface IMSVidWebDVD * This, int lTitle, int *plParentalLevels);
        public delegate int get_TitleParentalLevelsDelegate(@interface IMSVidWebDVD This, int lTitle, ref int plParentalLevels);
        public get_TitleParentalLevelsDelegate get_TitleParentalLevels;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PlayerParentalCountry)(interface IMSVidWebDVD * This, int *plCountryCode);
        public delegate int get_PlayerParentalCountryDelegate(@interface IMSVidWebDVD This, ref int plCountryCode);
        public get_PlayerParentalCountryDelegate get_PlayerParentalCountry;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PlayerParentalLevel)(interface IMSVidWebDVD * This, int *plParentalLevel);
        public delegate int get_PlayerParentalLevelDelegate(@interface IMSVidWebDVD This, ref int plParentalLevel);
        public get_PlayerParentalLevelDelegate get_PlayerParentalLevel;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Eject)(interface IMSVidWebDVD * This);
        public delegate int EjectDelegate(@interface IMSVidWebDVD This);
        public EjectDelegate Eject;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UOPValid)(interface IMSVidWebDVD * This, int lUOP, VARIANT_BOOL *pfValid);
        public delegate int UOPValidDelegate(@interface IMSVidWebDVD This, int lUOP, VARIANT_BOOL pfValid);
        public UOPValidDelegate UOPValid;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SPRM)(interface IMSVidWebDVD * This, int lIndex, short *psSPRM);
        public delegate int get_SPRMDelegate(@interface IMSVidWebDVD This, int lIndex, ref short psSPRM);
        public get_SPRMDelegate get_SPRM;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_GPRM)(interface IMSVidWebDVD * This, int lIndex, short *psSPRM);
        public delegate int get_GPRMDelegate(@interface IMSVidWebDVD This, int lIndex, ref short psSPRM);
        public get_GPRMDelegate get_GPRM;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_GPRM)(interface IMSVidWebDVD * This, int lIndex, short sValue);
        public delegate int put_GPRMDelegate(@interface IMSVidWebDVD This, int lIndex, short sValue);
        public put_GPRMDelegate put_GPRM;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDTextStringType)(interface IMSVidWebDVD * This, int lLangIndex, int lStringIndex, DVDTextStringType *pType);
        public delegate int get_DVDTextStringTypeDelegate(@interface IMSVidWebDVD This, int lLangIndex, int lStringIndex, DVDTextStringType pType);
        public get_DVDTextStringTypeDelegate get_DVDTextStringType;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDTextString)(interface IMSVidWebDVD * This, int lLangIndex, int lStringIndex, char**pstrText);
        public delegate int get_DVDTextStringDelegate(@interface IMSVidWebDVD This, int lLangIndex, int lStringIndex, char * pstrText[] UnnamedParameter);
        public get_DVDTextStringDelegate get_DVDTextString;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDTextNumberOfStrings)(interface IMSVidWebDVD * This, int lLangIndex, int *plNumOfStrings);
        public delegate int get_DVDTextNumberOfStringsDelegate(@interface IMSVidWebDVD This, int lLangIndex, ref int plNumOfStrings);
        public get_DVDTextNumberOfStringsDelegate get_DVDTextNumberOfStrings;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDTextNumberOfLanguages)(interface IMSVidWebDVD * This, int *plNumOfLangs);
        public delegate int get_DVDTextNumberOfLanguagesDelegate(@interface IMSVidWebDVD This, ref int plNumOfLangs);
        public get_DVDTextNumberOfLanguagesDelegate get_DVDTextNumberOfLanguages;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDTextLanguageLCID)(interface IMSVidWebDVD * This, int lLangIndex, int *lcid);
        public delegate int get_DVDTextLanguageLCIDDelegate(@interface IMSVidWebDVD This, int lLangIndex, ref int lcid);
        public get_DVDTextLanguageLCIDDelegate get_DVDTextLanguageLCID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegionChange)(interface IMSVidWebDVD * This);
        public delegate int RegionChangeDelegate(@interface IMSVidWebDVD This);
        public RegionChangeDelegate RegionChange;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDAdm)(interface IMSVidWebDVD * This, IDispatch **pVal);
        public delegate int get_DVDAdmDelegate(@interface IMSVidWebDVD This, IDispatch[] pVal);
        public get_DVDAdmDelegate get_DVDAdm;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DeleteBookmark)(interface IMSVidWebDVD * This);
        public delegate int DeleteBookmarkDelegate(@interface IMSVidWebDVD This);
        public DeleteBookmarkDelegate DeleteBookmark;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RestoreBookmark)(interface IMSVidWebDVD * This);
        public delegate int RestoreBookmarkDelegate(@interface IMSVidWebDVD This);
        public RestoreBookmarkDelegate RestoreBookmark;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SaveBookmark)(interface IMSVidWebDVD * This);
        public delegate int SaveBookmarkDelegate(@interface IMSVidWebDVD This);
        public SaveBookmarkDelegate SaveBookmark;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectDefaultAudioLanguage)(interface IMSVidWebDVD * This, int lang, int ext);
        public delegate int SelectDefaultAudioLanguageDelegate(@interface IMSVidWebDVD This, int lang, int ext);
        public SelectDefaultAudioLanguageDelegate SelectDefaultAudioLanguage;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectDefaultSubpictureLanguage)(interface IMSVidWebDVD * This, int lang, DVDSPExt ext);
        public delegate int SelectDefaultSubpictureLanguageDelegate(@interface IMSVidWebDVD This, int lang, DVDSPExt ext);
        public SelectDefaultSubpictureLanguageDelegate SelectDefaultSubpictureLanguage;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PreferredSubpictureStream)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_PreferredSubpictureStreamDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_PreferredSubpictureStreamDelegate get_PreferredSubpictureStream;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultMenuLanguage)(interface IMSVidWebDVD * This, int *lang);
        public delegate int get_DefaultMenuLanguageDelegate(@interface IMSVidWebDVD This, ref int lang);
        public get_DefaultMenuLanguageDelegate get_DefaultMenuLanguage;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DefaultMenuLanguage)(interface IMSVidWebDVD * This, int lang);
        public delegate int put_DefaultMenuLanguageDelegate(@interface IMSVidWebDVD This, int lang);
        public put_DefaultMenuLanguageDelegate put_DefaultMenuLanguage;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultSubpictureLanguage)(interface IMSVidWebDVD * This, int *lang);
        public delegate int get_DefaultSubpictureLanguageDelegate(@interface IMSVidWebDVD This, ref int lang);
        public get_DefaultSubpictureLanguageDelegate get_DefaultSubpictureLanguage;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultAudioLanguage)(interface IMSVidWebDVD * This, int *lang);
        public delegate int get_DefaultAudioLanguageDelegate(@interface IMSVidWebDVD This, ref int lang);
        public get_DefaultAudioLanguageDelegate get_DefaultAudioLanguage;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultSubpictureLanguageExt)(interface IMSVidWebDVD * This, DVDSPExt *ext);
        public delegate int get_DefaultSubpictureLanguageExtDelegate(@interface IMSVidWebDVD This, DVDSPExt ext);
        public get_DefaultSubpictureLanguageExtDelegate get_DefaultSubpictureLanguageExt;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultAudioLanguageExt)(interface IMSVidWebDVD * This, int *ext);
        public delegate int get_DefaultAudioLanguageExtDelegate(@interface IMSVidWebDVD This, ref int ext);
        public get_DefaultAudioLanguageExtDelegate get_DefaultAudioLanguageExt;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_LanguageFromLCID)(interface IMSVidWebDVD * This, int lcid, char**lang);
        public delegate int get_LanguageFromLCIDDelegate(@interface IMSVidWebDVD This, int lcid, char * lang[] UnnamedParameter);
        public get_LanguageFromLCIDDelegate get_LanguageFromLCID;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_KaraokeAudioPresentationMode)(interface IMSVidWebDVD * This, int *pVal);
        public delegate int get_KaraokeAudioPresentationModeDelegate(@interface IMSVidWebDVD This, ref int pVal);
        public get_KaraokeAudioPresentationModeDelegate get_KaraokeAudioPresentationMode;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_KaraokeAudioPresentationMode)(interface IMSVidWebDVD * This, int newVal);
        public delegate int put_KaraokeAudioPresentationModeDelegate(@interface IMSVidWebDVD This, int newVal);
        public put_KaraokeAudioPresentationModeDelegate put_KaraokeAudioPresentationMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_KaraokeChannelContent)(interface IMSVidWebDVD * This, int lStream, int lChan, int *lContent);
        public delegate int get_KaraokeChannelContentDelegate(@interface IMSVidWebDVD This, int lStream, int lChan, ref int lContent);
        public get_KaraokeChannelContentDelegate get_KaraokeChannelContent;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_KaraokeChannelAssignment)(interface IMSVidWebDVD * This, int lStream, int *lChannelAssignment);
        public delegate int get_KaraokeChannelAssignmentDelegate(@interface IMSVidWebDVD This, int lStream, ref int lChannelAssignment);
        public get_KaraokeChannelAssignmentDelegate get_KaraokeChannelAssignment;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RestorePreferredSettings)(interface IMSVidWebDVD * This);
        public delegate int RestorePreferredSettingsDelegate(@interface IMSVidWebDVD This);
        public RestorePreferredSettingsDelegate RestorePreferredSettings;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ButtonRect)(interface IMSVidWebDVD * This, int lButton, interface IMSVidRect **pRect);
        public delegate int get_ButtonRectDelegate(@interface IMSVidWebDVD This, int lButton, @interface IMSVidRect[] pRect);
        public get_ButtonRectDelegate get_ButtonRect;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DVDScreenInMouseCoordinates)(interface IMSVidWebDVD * This, interface IMSVidRect **ppRect);
        public delegate int get_DVDScreenInMouseCoordinatesDelegate(@interface IMSVidWebDVD This, @interface IMSVidRect[] ppRect);
        public get_DVDScreenInMouseCoordinatesDelegate get_DVDScreenInMouseCoordinates;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DVDScreenInMouseCoordinates)(interface IMSVidWebDVD * This, interface IMSVidRect *pRect);
        public delegate int put_DVDScreenInMouseCoordinatesDelegate(@interface IMSVidWebDVD This, @interface IMSVidRect pRect);
        public put_DVDScreenInMouseCoordinatesDelegate put_DVDScreenInMouseCoordinates;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidWebDVDEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidWebDVDEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidWebDVDEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidWebDVDEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidWebDVDEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidWebDVDEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidWebDVDEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidWebDVDEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidWebDVDEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidWebDVDEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidWebDVDEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidWebDVDEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidWebDVDEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidWebDVDEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidWebDVDEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndOfMedia)(interface IMSVidWebDVDEvent * This, interface IMSVidPlayback *lpd);
        public delegate int EndOfMediaDelegate(@interface IMSVidWebDVDEvent This, @interface IMSVidPlayback lpd);
        public EndOfMediaDelegate EndOfMedia;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DVDNotify)(interface IMSVidWebDVDEvent * This, int lEventCode, VARIANT lParam1, VARIANT lParam2);
        public delegate int DVDNotifyDelegate(@interface IMSVidWebDVDEvent This, int lEventCode, VARIANT lParam1, VARIANT lParam2);
        public DVDNotifyDelegate DVDNotify;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayForwards)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayForwardsDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayForwardsDelegate PlayForwards;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayBackwards)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayBackwardsDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayBackwardsDelegate PlayBackwards;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShowMenu)(interface IMSVidWebDVDEvent * This, DVDMenuIDConstants __MIDL_0019, VARIANT_BOOL bEnabled);
        public delegate int ShowMenuDelegate(@interface IMSVidWebDVDEvent This, DVDMenuIDConstants __MIDL_0019, VARIANT_BOOL bEnabled);
        public ShowMenuDelegate ShowMenu;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Resume)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ResumeDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ResumeDelegate Resume;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectOrActivateButton)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int SelectOrActivateButtonDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public SelectOrActivateButtonDelegate SelectOrActivateButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StillOff)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int StillOffDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public StillOffDelegate StillOff;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PauseOn)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PauseOnDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PauseOnDelegate PauseOn;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeCurrentAudioStream)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ChangeCurrentAudioStreamDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ChangeCurrentAudioStreamDelegate ChangeCurrentAudioStream;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeCurrentSubpictureStream)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ChangeCurrentSubpictureStreamDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ChangeCurrentSubpictureStreamDelegate ChangeCurrentSubpictureStream;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeCurrentAngle)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ChangeCurrentAngleDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ChangeCurrentAngleDelegate ChangeCurrentAngle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayAtTimeInTitle)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayAtTimeInTitleDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayAtTimeInTitleDelegate PlayAtTimeInTitle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayAtTime)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayAtTimeDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayAtTimeDelegate PlayAtTime;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChapterInTitle)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayChapterInTitleDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayChapterInTitleDelegate PlayChapterInTitle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChapter)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayChapterDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayChapterDelegate PlayChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReplayChapter)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ReplayChapterDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ReplayChapterDelegate ReplayChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayNextChapter)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayNextChapterDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayNextChapterDelegate PlayNextChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int StopDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public StopDelegate Stop;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReturnFromSubmenu)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ReturnFromSubmenuDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ReturnFromSubmenuDelegate ReturnFromSubmenu;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayTitle)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayTitleDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayTitleDelegate PlayTitle;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayPrevChapter)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int PlayPrevChapterDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public PlayPrevChapterDelegate PlayPrevChapter;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeKaraokePresMode)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ChangeKaraokePresModeDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ChangeKaraokePresModeDelegate ChangeKaraokePresMode;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeVideoPresMode)(interface IMSVidWebDVDEvent * This, VARIANT_BOOL bEnabled);
        public delegate int ChangeVideoPresModeDelegate(@interface IMSVidWebDVDEvent This, VARIANT_BOOL bEnabled);
        public ChangeVideoPresModeDelegate ChangeVideoPresMode;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidWebDVDAdmVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidWebDVDAdm * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidWebDVDAdm This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidWebDVDAdm * This);
        public delegate uint AddRefDelegate(@interface IMSVidWebDVDAdm This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidWebDVDAdm * This);
        public delegate uint ReleaseDelegate(@interface IMSVidWebDVDAdm This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidWebDVDAdm * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidWebDVDAdm This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidWebDVDAdm * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidWebDVDAdm This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidWebDVDAdm * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidWebDVDAdm This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidWebDVDAdm * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidWebDVDAdm This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangePassword)(interface IMSVidWebDVDAdm * This, char* strUserName, char* strOld, char* strNew);
        public delegate int ChangePasswordDelegate(@interface IMSVidWebDVDAdm This, ref string strUserName, ref string strOld, ref string strNew);
        public ChangePasswordDelegate ChangePassword;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SaveParentalLevel)(interface IMSVidWebDVDAdm * This, int level, char* strUserName, char* strPassword);
        public delegate int SaveParentalLevelDelegate(@interface IMSVidWebDVDAdm This, int level, ref string strUserName, ref string strPassword);
        public SaveParentalLevelDelegate SaveParentalLevel;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SaveParentalCountry)(interface IMSVidWebDVDAdm * This, int country, char* strUserName, char* strPassword);
        public delegate int SaveParentalCountryDelegate(@interface IMSVidWebDVDAdm This, int country, ref string strUserName, ref string strPassword);
        public SaveParentalCountryDelegate SaveParentalCountry;

        /* [helpstring][restricted][hidden][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConfirmPassword)(interface IMSVidWebDVDAdm * This, char* strUserName, char* strPassword, VARIANT_BOOL *pVal);
        public delegate int ConfirmPasswordDelegate(@interface IMSVidWebDVDAdm This, ref string strUserName, ref string strPassword, VARIANT_BOOL pVal);
        public ConfirmPasswordDelegate ConfirmPassword;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParentalLevel)(interface IMSVidWebDVDAdm * This, int *lLevel);
        public delegate int GetParentalLevelDelegate(@interface IMSVidWebDVDAdm This, ref int lLevel);
        public GetParentalLevelDelegate GetParentalLevel;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParentalCountry)(interface IMSVidWebDVDAdm * This, int *lCountry);
        public delegate int GetParentalCountryDelegate(@interface IMSVidWebDVDAdm This, ref int lCountry);
        public GetParentalCountryDelegate GetParentalCountry;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultAudioLCID)(interface IMSVidWebDVDAdm * This, int *pVal);
        public delegate int get_DefaultAudioLCIDDelegate(@interface IMSVidWebDVDAdm This, ref int pVal);
        public get_DefaultAudioLCIDDelegate get_DefaultAudioLCID;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DefaultAudioLCID)(interface IMSVidWebDVDAdm * This, int newVal);
        public delegate int put_DefaultAudioLCIDDelegate(@interface IMSVidWebDVDAdm This, int newVal);
        public put_DefaultAudioLCIDDelegate put_DefaultAudioLCID;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultSubpictureLCID)(interface IMSVidWebDVDAdm * This, int *pVal);
        public delegate int get_DefaultSubpictureLCIDDelegate(@interface IMSVidWebDVDAdm This, ref int pVal);
        public get_DefaultSubpictureLCIDDelegate get_DefaultSubpictureLCID;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DefaultSubpictureLCID)(interface IMSVidWebDVDAdm * This, int newVal);
        public delegate int put_DefaultSubpictureLCIDDelegate(@interface IMSVidWebDVDAdm This, int newVal);
        public put_DefaultSubpictureLCIDDelegate put_DefaultSubpictureLCID;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultMenuLCID)(interface IMSVidWebDVDAdm * This, int *pVal);
        public delegate int get_DefaultMenuLCIDDelegate(@interface IMSVidWebDVDAdm This, ref int pVal);
        public get_DefaultMenuLCIDDelegate get_DefaultMenuLCID;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DefaultMenuLCID)(interface IMSVidWebDVDAdm * This, int newVal);
        public delegate int put_DefaultMenuLCIDDelegate(@interface IMSVidWebDVDAdm This, int newVal);
        public put_DefaultMenuLCIDDelegate put_DefaultMenuLCID;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BookmarkOnStop)(interface IMSVidWebDVDAdm * This, VARIANT_BOOL *pVal);
        public delegate int get_BookmarkOnStopDelegate(@interface IMSVidWebDVDAdm This, VARIANT_BOOL pVal);
        public get_BookmarkOnStopDelegate get_BookmarkOnStop;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BookmarkOnStop)(interface IMSVidWebDVDAdm * This, VARIANT_BOOL newVal);
        public delegate int put_BookmarkOnStopDelegate(@interface IMSVidWebDVDAdm This, VARIANT_BOOL newVal);
        public put_BookmarkOnStopDelegate put_BookmarkOnStop;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidOutputDeviceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidOutputDevice * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidOutputDevice This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidOutputDevice * This);
        public delegate uint AddRefDelegate(@interface IMSVidOutputDevice This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidOutputDevice * This);
        public delegate uint ReleaseDelegate(@interface IMSVidOutputDevice This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidOutputDevice * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidOutputDevice This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidOutputDevice * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidOutputDevice This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidOutputDevice * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidOutputDevice This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidOutputDevice * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidOutputDevice This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidOutputDevice * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidOutputDevice This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidOutputDevice * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidOutputDevice This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidOutputDevice * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidOutputDevice This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidOutputDevice * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidOutputDevice This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidOutputDevice * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidOutputDevice This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidOutputDevice * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidOutputDevice This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidOutputDevice * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidOutputDevice This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidOutputDevice * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidOutputDevice This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidOutputDevice * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidOutputDevice This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidOutputDeviceEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidOutputDeviceEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidOutputDeviceEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidOutputDeviceEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidOutputDeviceEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidOutputDeviceEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidOutputDeviceEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidOutputDeviceEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidOutputDeviceEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidOutputDeviceEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidOutputDeviceEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidOutputDeviceEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidOutputDeviceEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidOutputDeviceEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidOutputDeviceEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidOutputDeviceEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidOutputDeviceEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidFeatureVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidFeature * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidFeature This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidFeature * This);
        public delegate uint AddRefDelegate(@interface IMSVidFeature This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidFeature * This);
        public delegate uint ReleaseDelegate(@interface IMSVidFeature This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidFeature * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidFeature This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidFeature * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidFeature This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidFeature * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidFeature This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidFeature * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidFeature This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidFeature * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidFeature This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidFeature * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidFeature This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidFeature * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidFeature This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidFeature * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidFeature This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidFeature * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidFeature This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidFeature * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidFeature This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidFeature * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidFeature This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidFeature * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidFeature This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidFeature * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidFeature This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidFeatureEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidFeatureEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidFeatureEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidFeatureEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidFeatureEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidFeatureEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidFeatureEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidFeatureEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidFeatureEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidFeatureEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidFeatureEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidFeatureEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidFeatureEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidFeatureEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidFeatureEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidFeatureEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidFeatureEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidEncoderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidEncoder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidEncoder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidEncoder * This);
        public delegate uint AddRefDelegate(@interface IMSVidEncoder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidEncoder * This);
        public delegate uint ReleaseDelegate(@interface IMSVidEncoder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidEncoder * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidEncoder This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidEncoder * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidEncoder This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidEncoder * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidEncoder This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidEncoder * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidEncoder This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidEncoder * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidEncoder This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidEncoder * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidEncoder This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidEncoder * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidEncoder This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidEncoder * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidEncoder This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidEncoder * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidEncoder This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidEncoder * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidEncoder This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidEncoder * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidEncoder This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidEncoder * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidEncoder This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidEncoder * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidEncoder This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoEncoderInterface)(interface IMSVidEncoder * This, object**ppEncInt);
        public delegate int get_VideoEncoderInterfaceDelegate(@interface IMSVidEncoder This, object ppEncInt[] UnnamedParameter);
        public get_VideoEncoderInterfaceDelegate get_VideoEncoderInterface;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AudioEncoderInterface)(interface IMSVidEncoder * This, object**ppEncInt);
        public delegate int get_AudioEncoderInterfaceDelegate(@interface IMSVidEncoder This, object ppEncInt[] UnnamedParameter);
        public get_AudioEncoderInterfaceDelegate get_AudioEncoderInterface;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidXDSVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidXDS * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidXDS This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidXDS * This);
        public delegate uint AddRefDelegate(@interface IMSVidXDS This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidXDS * This);
        public delegate uint ReleaseDelegate(@interface IMSVidXDS This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidXDS * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidXDS This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidXDS * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidXDS This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidXDS * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidXDS This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidXDS * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidXDS This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidXDS * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidXDS This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidXDS * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidXDS This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidXDS * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidXDS This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidXDS * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidXDS This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidXDS * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidXDS This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidXDS * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidXDS This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidXDS * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidXDS This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidXDS * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidXDS This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidXDS * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidXDS This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidDataServicesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidDataServices * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidDataServices This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidDataServices * This);
        public delegate uint AddRefDelegate(@interface IMSVidDataServices This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidDataServices * This);
        public delegate uint ReleaseDelegate(@interface IMSVidDataServices This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidDataServices * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidDataServices This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidDataServices * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidDataServices This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidDataServices * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidDataServices This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidDataServices * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidDataServices This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidDataServices * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidDataServices This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidDataServices * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidDataServices This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidDataServices * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidDataServices This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidDataServices * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidDataServices This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidDataServices * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidDataServices This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidDataServices * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidDataServices This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidDataServices * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidDataServices This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidDataServices * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidDataServices This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidDataServices * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidDataServices This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidDataServicesEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidDataServicesEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidDataServicesEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidDataServicesEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidDataServicesEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidDataServicesEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidDataServicesEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidDataServicesEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidDataServicesEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidDataServicesEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidDataServicesEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidDataServicesEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidDataServicesEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidDataServicesEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidDataServicesEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidDataServicesEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidDataServicesEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidClosedCaptioningVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidClosedCaptioning * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidClosedCaptioning This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidClosedCaptioning * This);
        public delegate uint AddRefDelegate(@interface IMSVidClosedCaptioning This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidClosedCaptioning * This);
        public delegate uint ReleaseDelegate(@interface IMSVidClosedCaptioning This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidClosedCaptioning * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidClosedCaptioning This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidClosedCaptioning * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidClosedCaptioning This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidClosedCaptioning * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidClosedCaptioning This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidClosedCaptioning * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidClosedCaptioning This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidClosedCaptioning * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidClosedCaptioning This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidClosedCaptioning * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidClosedCaptioning This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidClosedCaptioning * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidClosedCaptioning This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidClosedCaptioning * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidClosedCaptioning This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidClosedCaptioning * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidClosedCaptioning This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidClosedCaptioning * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidClosedCaptioning This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidClosedCaptioning * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidClosedCaptioning This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidClosedCaptioning * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidClosedCaptioning This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidClosedCaptioning * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidClosedCaptioning This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Enable)(interface IMSVidClosedCaptioning * This, VARIANT_BOOL *On);
        public delegate int get_EnableDelegate(@interface IMSVidClosedCaptioning This, VARIANT_BOOL On);
        public get_EnableDelegate get_Enable;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Enable)(interface IMSVidClosedCaptioning * This, VARIANT_BOOL On);
        public delegate int put_EnableDelegate(@interface IMSVidClosedCaptioning This, VARIANT_BOOL On);
        public put_EnableDelegate put_Enable;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidClosedCaptioning2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidClosedCaptioning2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidClosedCaptioning2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidClosedCaptioning2 * This);
        public delegate uint AddRefDelegate(@interface IMSVidClosedCaptioning2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidClosedCaptioning2 * This);
        public delegate uint ReleaseDelegate(@interface IMSVidClosedCaptioning2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidClosedCaptioning2 * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidClosedCaptioning2 This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidClosedCaptioning2 * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidClosedCaptioning2 This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidClosedCaptioning2 * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidClosedCaptioning2 This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidClosedCaptioning2 * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidClosedCaptioning2 This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidClosedCaptioning2 * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidClosedCaptioning2 This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidClosedCaptioning2 * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidClosedCaptioning2 This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidClosedCaptioning2 * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidClosedCaptioning2 This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidClosedCaptioning2 * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidClosedCaptioning2 This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidClosedCaptioning2 * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidClosedCaptioning2 This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidClosedCaptioning2 * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidClosedCaptioning2 This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidClosedCaptioning2 * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidClosedCaptioning2 This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidClosedCaptioning2 * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidClosedCaptioning2 This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidClosedCaptioning2 * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidClosedCaptioning2 This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Enable)(interface IMSVidClosedCaptioning2 * This, VARIANT_BOOL *On);
        public delegate int get_EnableDelegate(@interface IMSVidClosedCaptioning2 This, VARIANT_BOOL On);
        public get_EnableDelegate get_Enable;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Enable)(interface IMSVidClosedCaptioning2 * This, VARIANT_BOOL On);
        public delegate int put_EnableDelegate(@interface IMSVidClosedCaptioning2 This, VARIANT_BOOL On);
        public put_EnableDelegate put_Enable;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Service)(interface IMSVidClosedCaptioning2 * This, MSVidCCService *On);
        public delegate int get_ServiceDelegate(@interface IMSVidClosedCaptioning2 This, MSVidCCService On);
        public get_ServiceDelegate get_Service;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Service)(interface IMSVidClosedCaptioning2 * This, MSVidCCService On);
        public delegate int put_ServiceDelegate(@interface IMSVidClosedCaptioning2 This, MSVidCCService On);
        public put_ServiceDelegate put_Service;

//        END_INTERFACE
    }





/* interface __MIDL_itf_segment_0495 */
/* [local] */ 

public enum __MIDL___MIDL_itf_segment_0495_0001
{
        sslFullSize = 0,
    sslClipByOverScan = sslFullSize + 1,
    sslClipByClipRect = sslClipByOverScan + 1
}

#else // C style interface

    public class IMSVidVideoRendererVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVideoRenderer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVideoRenderer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVideoRenderer * This);
        public delegate uint AddRefDelegate(@interface IMSVidVideoRenderer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVideoRenderer * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVideoRenderer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidVideoRenderer * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidVideoRenderer This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidVideoRenderer * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidVideoRenderer This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidVideoRenderer * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidVideoRenderer This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidVideoRenderer * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidVideoRenderer This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidVideoRenderer * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidVideoRenderer This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidVideoRenderer * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidVideoRenderer This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidVideoRenderer * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidVideoRenderer This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidVideoRenderer * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidVideoRenderer This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidVideoRenderer * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidVideoRenderer This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidVideoRenderer * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidVideoRenderer This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidVideoRenderer * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidVideoRenderer This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidVideoRenderer * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidVideoRenderer This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidVideoRenderer * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CustomCompositorClass)(interface IMSVidVideoRenderer * This, char**CompositorCLSID);
        public delegate int get_CustomCompositorClassDelegate(@interface IMSVidVideoRenderer This, char * CompositorCLSID[] UnnamedParameter);
        public get_CustomCompositorClassDelegate get_CustomCompositorClass;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CustomCompositorClass)(interface IMSVidVideoRenderer * This, char* CompositorCLSID);
        public delegate int put_CustomCompositorClassDelegate(@interface IMSVidVideoRenderer This, ref string CompositorCLSID);
        public put_CustomCompositorClassDelegate put_CustomCompositorClass;

        /* [id][restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__CustomCompositorClass)(interface IMSVidVideoRenderer * This, GUID *CompositorCLSID);
        public delegate int get__CustomCompositorClassDelegate(@interface IMSVidVideoRenderer This, GUID CompositorCLSID);
        public get__CustomCompositorClassDelegate get__CustomCompositorClass;

        /* [id][restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__CustomCompositorClass)(interface IMSVidVideoRenderer * This, REFCLSID CompositorCLSID);
        public delegate int put__CustomCompositorClassDelegate(@interface IMSVidVideoRenderer This, REFCLSID CompositorCLSID);
        public put__CustomCompositorClassDelegate put__CustomCompositorClass;

        /* [id][restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__CustomCompositor)(interface IMSVidVideoRenderer * This, interface IVMRImageCompositor **Compositor);
        public delegate int get__CustomCompositorDelegate(@interface IMSVidVideoRenderer This, @interface IVMRImageCompositor[] Compositor);
        public get__CustomCompositorDelegate get__CustomCompositor;

        /* [id][restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__CustomCompositor)(interface IMSVidVideoRenderer * This, interface IVMRImageCompositor *Compositor);
        public delegate int put__CustomCompositorDelegate(@interface IMSVidVideoRenderer This, @interface IVMRImageCompositor Compositor);
        public put__CustomCompositorDelegate put__CustomCompositor;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixerBitmap)(interface IMSVidVideoRenderer * This, IPictureDisp **MixerPictureDisp);
        public delegate int get_MixerBitmapDelegate(@interface IMSVidVideoRenderer This, IPictureDisp[] MixerPictureDisp);
        public get_MixerBitmapDelegate get_MixerBitmap;

        /* [id][restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__MixerBitmap)(interface IMSVidVideoRenderer * This, interface IVMRMixerBitmap **MixerPicture);
        public delegate int get__MixerBitmapDelegate(@interface IMSVidVideoRenderer This, @interface IVMRMixerBitmap[] MixerPicture);
        public get__MixerBitmapDelegate get__MixerBitmap;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixerBitmap)(interface IMSVidVideoRenderer * This, IPictureDisp *MixerPictureDisp);
        public delegate int put_MixerBitmapDelegate(@interface IMSVidVideoRenderer This, IPictureDisp MixerPictureDisp);
        public put_MixerBitmapDelegate put_MixerBitmap;

        /* [id][restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__MixerBitmap)(interface IMSVidVideoRenderer * This, VMRALPHABITMAP *MixerPicture);
        public delegate int put__MixerBitmapDelegate(@interface IMSVidVideoRenderer This, VMRALPHABITMAP MixerPicture);
        public put__MixerBitmapDelegate put__MixerBitmap;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixerBitmapPositionRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect **rDest);
        public delegate int get_MixerBitmapPositionRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect[] rDest);
        public get_MixerBitmapPositionRectDelegate get_MixerBitmapPositionRect;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixerBitmapPositionRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect *rDest);
        public delegate int put_MixerBitmapPositionRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect rDest);
        public put_MixerBitmapPositionRectDelegate put_MixerBitmapPositionRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixerBitmapOpacity)(interface IMSVidVideoRenderer * This, int *opacity);
        public delegate int get_MixerBitmapOpacityDelegate(@interface IMSVidVideoRenderer This, ref int opacity);
        public get_MixerBitmapOpacityDelegate get_MixerBitmapOpacity;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixerBitmapOpacity)(interface IMSVidVideoRenderer * This, int opacity);
        public delegate int put_MixerBitmapOpacityDelegate(@interface IMSVidVideoRenderer This, int opacity);
        public put_MixerBitmapOpacityDelegate put_MixerBitmapOpacity;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetupMixerBitmap)(interface IMSVidVideoRenderer * This, IPictureDisp *MixerPictureDisp, int Opacity, interface IMSVidRect *rDest);
        public delegate int SetupMixerBitmapDelegate(@interface IMSVidVideoRenderer This, IPictureDisp MixerPictureDisp, int Opacity, @interface IMSVidRect rDest);
        public SetupMixerBitmapDelegate SetupMixerBitmap;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceSize)(interface IMSVidVideoRenderer * This, SourceSizeList *CurrentSize);
        public delegate int get_SourceSizeDelegate(@interface IMSVidVideoRenderer This, SourceSizeList CurrentSize);
        public get_SourceSizeDelegate get_SourceSize;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceSize)(interface IMSVidVideoRenderer * This, SourceSizeList NewSize);
        public delegate int put_SourceSizeDelegate(@interface IMSVidVideoRenderer This, SourceSizeList NewSize);
        public put_SourceSizeDelegate put_SourceSize;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OverScan)(interface IMSVidVideoRenderer * This, int *plPercent);
        public delegate int get_OverScanDelegate(@interface IMSVidVideoRenderer This, ref int plPercent);
        public get_OverScanDelegate get_OverScan;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_OverScan)(interface IMSVidVideoRenderer * This, int lPercent);
        public delegate int put_OverScanDelegate(@interface IMSVidVideoRenderer This, int lPercent);
        public put_OverScanDelegate put_OverScan;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvailableSourceRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect **pRect);
        public delegate int get_AvailableSourceRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect[] pRect);
        public get_AvailableSourceRectDelegate get_AvailableSourceRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MaxVidRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect **ppVidRect);
        public delegate int get_MaxVidRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect[] ppVidRect);
        public get_MaxVidRectDelegate get_MaxVidRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MinVidRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect **ppVidRect);
        public delegate int get_MinVidRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect[] ppVidRect);
        public get_MinVidRectDelegate get_MinVidRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClippedSourceRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect **pRect);
        public delegate int get_ClippedSourceRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect[] pRect);
        public get_ClippedSourceRectDelegate get_ClippedSourceRect;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_ClippedSourceRect)(interface IMSVidVideoRenderer * This, interface IMSVidRect *pRect);
        public delegate int put_ClippedSourceRectDelegate(@interface IMSVidVideoRenderer This, @interface IMSVidRect pRect);
        public put_ClippedSourceRectDelegate put_ClippedSourceRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_UsingOverlay)(interface IMSVidVideoRenderer * This, VARIANT_BOOL *UseOverlayVal);
        public delegate int get_UsingOverlayDelegate(@interface IMSVidVideoRenderer This, VARIANT_BOOL UseOverlayVal);
        public get_UsingOverlayDelegate get_UsingOverlay;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_UsingOverlay)(interface IMSVidVideoRenderer * This, VARIANT_BOOL UseOverlayVal);
        public delegate int put_UsingOverlayDelegate(@interface IMSVidVideoRenderer This, VARIANT_BOOL UseOverlayVal);
        public put_UsingOverlayDelegate put_UsingOverlay;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Capture)(interface IMSVidVideoRenderer * This, IPictureDisp **currentImage);
        public delegate int CaptureDelegate(@interface IMSVidVideoRenderer This, IPictureDisp[] currentImage);
        public CaptureDelegate Capture;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FramesPerSecond)(interface IMSVidVideoRenderer * This, int *pVal);
        public delegate int get_FramesPerSecondDelegate(@interface IMSVidVideoRenderer This, ref int pVal);
        public get_FramesPerSecondDelegate get_FramesPerSecond;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DecimateInput)(interface IMSVidVideoRenderer * This, VARIANT_BOOL *pDeci);
        public delegate int get_DecimateInputDelegate(@interface IMSVidVideoRenderer This, VARIANT_BOOL pDeci);
        public get_DecimateInputDelegate get_DecimateInput;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DecimateInput)(interface IMSVidVideoRenderer * This, VARIANT_BOOL pDeci);
        public delegate int put_DecimateInputDelegate(@interface IMSVidVideoRenderer This, VARIANT_BOOL pDeci);
        public put_DecimateInputDelegate put_DecimateInput;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidVideoRendererEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVideoRendererEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVideoRendererEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVideoRendererEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidVideoRendererEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVideoRendererEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVideoRendererEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidVideoRendererEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidVideoRendererEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidVideoRendererEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidVideoRendererEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidVideoRendererEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidVideoRendererEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidVideoRendererEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidVideoRendererEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidVideoRendererEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidVideoRendererEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OverlayUnavailable)(interface IMSVidVideoRendererEvent * This);
        public delegate int OverlayUnavailableDelegate(@interface IMSVidVideoRendererEvent This);
        public OverlayUnavailableDelegate OverlayUnavailable;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidStreamBufferRecordingControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidStreamBufferRecordingControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidStreamBufferRecordingControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidStreamBufferRecordingControl * This);
        public delegate uint AddRefDelegate(@interface IMSVidStreamBufferRecordingControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidStreamBufferRecordingControl * This);
        public delegate uint ReleaseDelegate(@interface IMSVidStreamBufferRecordingControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidStreamBufferRecordingControl * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidStreamBufferRecordingControl This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidStreamBufferRecordingControl * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidStreamBufferRecordingControl This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidStreamBufferRecordingControl * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidStreamBufferRecordingControl This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidStreamBufferRecordingControl * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidStreamBufferRecordingControl This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_StartTime)(interface IMSVidStreamBufferRecordingControl * This, int *rtStart);
        public delegate int get_StartTimeDelegate(@interface IMSVidStreamBufferRecordingControl This, ref int rtStart);
        public get_StartTimeDelegate get_StartTime;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_StartTime)(interface IMSVidStreamBufferRecordingControl * This, int rtStart);
        public delegate int put_StartTimeDelegate(@interface IMSVidStreamBufferRecordingControl This, int rtStart);
        public put_StartTimeDelegate put_StartTime;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_StopTime)(interface IMSVidStreamBufferRecordingControl * This, int *rtStop);
        public delegate int get_StopTimeDelegate(@interface IMSVidStreamBufferRecordingControl This, ref int rtStop);
        public get_StopTimeDelegate get_StopTime;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_StopTime)(interface IMSVidStreamBufferRecordingControl * This, int rtStop);
        public delegate int put_StopTimeDelegate(@interface IMSVidStreamBufferRecordingControl This, int rtStop);
        public put_StopTimeDelegate put_StopTime;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RecordingStopped)(interface IMSVidStreamBufferRecordingControl * This, VARIANT_BOOL *phResult);
        public delegate int get_RecordingStoppedDelegate(@interface IMSVidStreamBufferRecordingControl This, VARIANT_BOOL phResult);
        public get_RecordingStoppedDelegate get_RecordingStopped;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RecordingStarted)(interface IMSVidStreamBufferRecordingControl * This, VARIANT_BOOL *phResult);
        public delegate int get_RecordingStartedDelegate(@interface IMSVidStreamBufferRecordingControl This, VARIANT_BOOL phResult);
        public get_RecordingStartedDelegate get_RecordingStarted;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RecordingType)(interface IMSVidStreamBufferRecordingControl * This, RecordingType *dwType);
        public delegate int get_RecordingTypeDelegate(@interface IMSVidStreamBufferRecordingControl This, RecordingType dwType);
        public get_RecordingTypeDelegate get_RecordingType;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RecordingAttribute)(interface IMSVidStreamBufferRecordingControl * This, object**pRecordingAttribute);
        public delegate int get_RecordingAttributeDelegate(@interface IMSVidStreamBufferRecordingControl This, object pRecordingAttribute[] UnnamedParameter);
        public get_RecordingAttributeDelegate get_RecordingAttribute;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidStreamBufferSinkVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidStreamBufferSink * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidStreamBufferSink This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidStreamBufferSink * This);
        public delegate uint AddRefDelegate(@interface IMSVidStreamBufferSink This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidStreamBufferSink * This);
        public delegate uint ReleaseDelegate(@interface IMSVidStreamBufferSink This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidStreamBufferSink * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidStreamBufferSink This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidStreamBufferSink * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidStreamBufferSink This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidStreamBufferSink * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidStreamBufferSink This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidStreamBufferSink * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidStreamBufferSink This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidStreamBufferSink * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidStreamBufferSink This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidStreamBufferSink * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidStreamBufferSink This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidStreamBufferSink * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidStreamBufferSink This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidStreamBufferSink * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidStreamBufferSink This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidStreamBufferSink * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidStreamBufferSink This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidStreamBufferSink * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidStreamBufferSink This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidStreamBufferSink * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidStreamBufferSink This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidStreamBufferSink * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidStreamBufferSink This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidStreamBufferSink * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidStreamBufferSink This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ContentRecorder)(interface IMSVidStreamBufferSink * This, char* pszFilename, interface IMSVidStreamBufferRecordingControl **pRecordingIUnknown);
        public delegate int get_ContentRecorderDelegate(@interface IMSVidStreamBufferSink This, ref string pszFilename, @interface IMSVidStreamBufferRecordingControl[] pRecordingIUnknown);
        public get_ContentRecorderDelegate get_ContentRecorder;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ReferenceRecorder)(interface IMSVidStreamBufferSink * This, char* pszFilename, interface IMSVidStreamBufferRecordingControl **pRecordingIUnknown);
        public delegate int get_ReferenceRecorderDelegate(@interface IMSVidStreamBufferSink This, ref string pszFilename, @interface IMSVidStreamBufferRecordingControl[] pRecordingIUnknown);
        public get_ReferenceRecorderDelegate get_ReferenceRecorder;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SinkName)(interface IMSVidStreamBufferSink * This, char**pName);
        public delegate int get_SinkNameDelegate(@interface IMSVidStreamBufferSink This, char * pName[] UnnamedParameter);
        public get_SinkNameDelegate get_SinkName;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SinkName)(interface IMSVidStreamBufferSink * This, char* Name);
        public delegate int put_SinkNameDelegate(@interface IMSVidStreamBufferSink This, ref string Name);
        public put_SinkNameDelegate put_SinkName;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NameSetLock)(interface IMSVidStreamBufferSink * This);
        public delegate int NameSetLockDelegate(@interface IMSVidStreamBufferSink This);
        public NameSetLockDelegate NameSetLock;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SBESink)(interface IMSVidStreamBufferSink * This, object**sbeConfig);
        public delegate int get_SBESinkDelegate(@interface IMSVidStreamBufferSink This, object sbeConfig[] UnnamedParameter);
        public get_SBESinkDelegate get_SBESink;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidStreamBufferSinkEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidStreamBufferSinkEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidStreamBufferSinkEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidStreamBufferSinkEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidStreamBufferSinkEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidStreamBufferSinkEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidStreamBufferSinkEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidStreamBufferSinkEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidStreamBufferSinkEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidStreamBufferSinkEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidStreamBufferSinkEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidStreamBufferSinkEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidStreamBufferSinkEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidStreamBufferSinkEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidStreamBufferSinkEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidStreamBufferSinkEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidStreamBufferSinkEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CertificateFailure)(interface IMSVidStreamBufferSinkEvent * This);
        public delegate int CertificateFailureDelegate(@interface IMSVidStreamBufferSinkEvent This);
        public CertificateFailureDelegate CertificateFailure;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CertificateSuccess)(interface IMSVidStreamBufferSinkEvent * This);
        public delegate int CertificateSuccessDelegate(@interface IMSVidStreamBufferSinkEvent This);
        public CertificateSuccessDelegate CertificateSuccess;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WriteFailure)(interface IMSVidStreamBufferSinkEvent * This);
        public delegate int WriteFailureDelegate(@interface IMSVidStreamBufferSinkEvent This);
        public WriteFailureDelegate WriteFailure;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidStreamBufferSourceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidStreamBufferSource * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidStreamBufferSource This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidStreamBufferSource * This);
        public delegate uint AddRefDelegate(@interface IMSVidStreamBufferSource This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidStreamBufferSource * This);
        public delegate uint ReleaseDelegate(@interface IMSVidStreamBufferSource This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidStreamBufferSource * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidStreamBufferSource This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidStreamBufferSource * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidStreamBufferSource This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidStreamBufferSource * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidStreamBufferSource This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidStreamBufferSource * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidStreamBufferSource This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidStreamBufferSource * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidStreamBufferSource This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidStreamBufferSource * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidStreamBufferSource This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidStreamBufferSource * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidStreamBufferSource This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidStreamBufferSource * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidStreamBufferSource This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidStreamBufferSource * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidStreamBufferSource This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidStreamBufferSource * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidStreamBufferSource This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidStreamBufferSource * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidStreamBufferSource This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidStreamBufferSource * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidStreamBufferSource This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidStreamBufferSource * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidStreamBufferSource This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsViewable)(interface IMSVidStreamBufferSource * This, VARIANT *v, VARIANT_BOOL *pfViewable);
        public delegate int IsViewableDelegate(@interface IMSVidStreamBufferSource This, VARIANT v, VARIANT_BOOL pfViewable);
        public IsViewableDelegate IsViewable;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *View)(interface IMSVidStreamBufferSource * This, VARIANT *v);
        public delegate int ViewDelegate(@interface IMSVidStreamBufferSource This, VARIANT v);
        public ViewDelegate View;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_EnableResetOnStop)(interface IMSVidStreamBufferSource * This, VARIANT_BOOL *pVal);
        public delegate int get_EnableResetOnStopDelegate(@interface IMSVidStreamBufferSource This, VARIANT_BOOL pVal);
        public get_EnableResetOnStopDelegate get_EnableResetOnStop;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_EnableResetOnStop)(interface IMSVidStreamBufferSource * This, VARIANT_BOOL newVal);
        public delegate int put_EnableResetOnStopDelegate(@interface IMSVidStreamBufferSource This, VARIANT_BOOL newVal);
        public put_EnableResetOnStopDelegate put_EnableResetOnStop;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IMSVidStreamBufferSource * This);
        public delegate int RunDelegate(@interface IMSVidStreamBufferSource This);
        public RunDelegate Run;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IMSVidStreamBufferSource * This);
        public delegate int PauseDelegate(@interface IMSVidStreamBufferSource This);
        public PauseDelegate Pause;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMSVidStreamBufferSource * This);
        public delegate int StopDelegate(@interface IMSVidStreamBufferSource This);
        public StopDelegate Stop;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CanStep)(interface IMSVidStreamBufferSource * This, VARIANT_BOOL fBackwards, VARIANT_BOOL *pfCan);
        public delegate int get_CanStepDelegate(@interface IMSVidStreamBufferSource This, VARIANT_BOOL fBackwards, VARIANT_BOOL pfCan);
        public get_CanStepDelegate get_CanStep;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Step)(interface IMSVidStreamBufferSource * This, int lStep);
        public delegate int StepDelegate(@interface IMSVidStreamBufferSource This, int lStep);
        public StepDelegate Step;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rate)(interface IMSVidStreamBufferSource * This, double plRate);
        public delegate int put_RateDelegate(@interface IMSVidStreamBufferSource This, double plRate);
        public put_RateDelegate put_Rate;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Rate)(interface IMSVidStreamBufferSource * This, double *plRate);
        public delegate int get_RateDelegate(@interface IMSVidStreamBufferSource This, ref double plRate);
        public get_RateDelegate get_Rate;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentPosition)(interface IMSVidStreamBufferSource * This, int lPosition);
        public delegate int put_CurrentPositionDelegate(@interface IMSVidStreamBufferSource This, int lPosition);
        public put_CurrentPositionDelegate put_CurrentPosition;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentPosition)(interface IMSVidStreamBufferSource * This, int *lPosition);
        public delegate int get_CurrentPositionDelegate(@interface IMSVidStreamBufferSource This, ref int lPosition);
        public get_CurrentPositionDelegate get_CurrentPosition;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_PositionMode)(interface IMSVidStreamBufferSource * This, PositionModeList lPositionMode);
        public delegate int put_PositionModeDelegate(@interface IMSVidStreamBufferSource This, PositionModeList lPositionMode);
        public put_PositionModeDelegate put_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PositionMode)(interface IMSVidStreamBufferSource * This, PositionModeList *lPositionMode);
        public delegate int get_PositionModeDelegate(@interface IMSVidStreamBufferSource This, PositionModeList lPositionMode);
        public get_PositionModeDelegate get_PositionMode;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Length)(interface IMSVidStreamBufferSource * This, int *lLength);
        public delegate int get_LengthDelegate(@interface IMSVidStreamBufferSource This, ref int lLength);
        public get_LengthDelegate get_Length;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FileName)(interface IMSVidStreamBufferSource * This, char**FileName);
        public delegate int get_FileNameDelegate(@interface IMSVidStreamBufferSource This, char * FileName[] UnnamedParameter);
        public get_FileNameDelegate get_FileName;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_FileName)(interface IMSVidStreamBufferSource * This, char* FileName);
        public delegate int put_FileNameDelegate(@interface IMSVidStreamBufferSource This, ref string FileName);
        public put_FileNameDelegate put_FileName;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Start)(interface IMSVidStreamBufferSource * This, int *lStart);
        public delegate int get_StartDelegate(@interface IMSVidStreamBufferSource This, ref int lStart);
        public get_StartDelegate get_Start;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RecordingAttribute)(interface IMSVidStreamBufferSource * This, object**pRecordingAttribute);
        public delegate int get_RecordingAttributeDelegate(@interface IMSVidStreamBufferSource This, object pRecordingAttribute[] UnnamedParameter);
        public get_RecordingAttributeDelegate get_RecordingAttribute;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CurrentRatings)(interface IMSVidStreamBufferSource * This, EnTvRat_System *pEnSystem, EnTvRat_GenericLevel *pEnRating, int *pBfEnAttr);
        public delegate int CurrentRatingsDelegate(@interface IMSVidStreamBufferSource This, EnTvRat_System pEnSystem, EnTvRat_GenericLevel pEnRating, ref int pBfEnAttr);
        public CurrentRatingsDelegate CurrentRatings;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MaxRatingsLevel)(interface IMSVidStreamBufferSource * This, EnTvRat_System enSystem, EnTvRat_GenericLevel enRating, int lbfEnAttr);
        public delegate int MaxRatingsLevelDelegate(@interface IMSVidStreamBufferSource This, EnTvRat_System enSystem, EnTvRat_GenericLevel enRating, int lbfEnAttr);
        public MaxRatingsLevelDelegate MaxRatingsLevel;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BlockUnrated)(interface IMSVidStreamBufferSource * This, VARIANT_BOOL bBlock);
        public delegate int put_BlockUnratedDelegate(@interface IMSVidStreamBufferSource This, VARIANT_BOOL bBlock);
        public put_BlockUnratedDelegate put_BlockUnrated;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_UnratedDelay)(interface IMSVidStreamBufferSource * This, int dwDelay);
        public delegate int put_UnratedDelayDelegate(@interface IMSVidStreamBufferSource This, int dwDelay);
        public put_UnratedDelayDelegate put_UnratedDelay;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SBESource)(interface IMSVidStreamBufferSource * This, object**sbeFilter);
        public delegate int get_SBESourceDelegate(@interface IMSVidStreamBufferSource This, object sbeFilter[] UnnamedParameter);
        public get_SBESourceDelegate get_SBESource;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidStreamBufferSourceEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidStreamBufferSourceEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidStreamBufferSourceEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidStreamBufferSourceEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidStreamBufferSourceEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidStreamBufferSourceEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidStreamBufferSourceEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidStreamBufferSourceEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidStreamBufferSourceEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidStreamBufferSourceEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidStreamBufferSourceEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndOfMedia)(interface IMSVidStreamBufferSourceEvent * This, interface IMSVidPlayback *lpd);
        public delegate int EndOfMediaDelegate(@interface IMSVidStreamBufferSourceEvent This, @interface IMSVidPlayback lpd);
        public EndOfMediaDelegate EndOfMedia;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CertificateFailure)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int CertificateFailureDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public CertificateFailureDelegate CertificateFailure;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CertificateSuccess)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int CertificateSuccessDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public CertificateSuccessDelegate CertificateSuccess;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RatingsBlocked)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int RatingsBlockedDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public RatingsBlockedDelegate RatingsBlocked;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RatingsUnblocked)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int RatingsUnblockedDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public RatingsUnblockedDelegate RatingsUnblocked;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RatingsChanged)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int RatingsChangedDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public RatingsChangedDelegate RatingsChanged;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TimeHole)(interface IMSVidStreamBufferSourceEvent * This, int StreamOffsetMS, int SizeMS);
        public delegate int TimeHoleDelegate(@interface IMSVidStreamBufferSourceEvent This, int StreamOffsetMS, int SizeMS);
        public TimeHoleDelegate TimeHole;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StaleDataRead)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int StaleDataReadDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public StaleDataReadDelegate StaleDataRead;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ContentBecomingStale)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int ContentBecomingStaleDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public ContentBecomingStaleDelegate ContentBecomingStale;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StaleFileDeleted)(interface IMSVidStreamBufferSourceEvent * This);
        public delegate int StaleFileDeletedDelegate(@interface IMSVidStreamBufferSourceEvent This);
        public StaleFileDeletedDelegate StaleFileDeleted;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidVideoRenderer2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVideoRenderer2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVideoRenderer2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVideoRenderer2 * This);
        public delegate uint AddRefDelegate(@interface IMSVidVideoRenderer2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVideoRenderer2 * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVideoRenderer2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidVideoRenderer2 * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidVideoRenderer2 This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidVideoRenderer2 * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidVideoRenderer2 This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidVideoRenderer2 * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidVideoRenderer2 This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidVideoRenderer2 * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidVideoRenderer2 This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidVideoRenderer2 * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidVideoRenderer2 This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidVideoRenderer2 * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidVideoRenderer2 This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidVideoRenderer2 * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidVideoRenderer2 This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidVideoRenderer2 * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidVideoRenderer2 This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidVideoRenderer2 * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidVideoRenderer2 This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidVideoRenderer2 * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidVideoRenderer2 This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidVideoRenderer2 * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CustomCompositorClass)(interface IMSVidVideoRenderer2 * This, char**CompositorCLSID);
        public delegate int get_CustomCompositorClassDelegate(@interface IMSVidVideoRenderer2 This, char * CompositorCLSID[] UnnamedParameter);
        public get_CustomCompositorClassDelegate get_CustomCompositorClass;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CustomCompositorClass)(interface IMSVidVideoRenderer2 * This, char* CompositorCLSID);
        public delegate int put_CustomCompositorClassDelegate(@interface IMSVidVideoRenderer2 This, ref string CompositorCLSID);
        public put_CustomCompositorClassDelegate put_CustomCompositorClass;

        /* [id][restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__CustomCompositorClass)(interface IMSVidVideoRenderer2 * This, GUID *CompositorCLSID);
        public delegate int get__CustomCompositorClassDelegate(@interface IMSVidVideoRenderer2 This, GUID CompositorCLSID);
        public get__CustomCompositorClassDelegate get__CustomCompositorClass;

        /* [id][restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__CustomCompositorClass)(interface IMSVidVideoRenderer2 * This, REFCLSID CompositorCLSID);
        public delegate int put__CustomCompositorClassDelegate(@interface IMSVidVideoRenderer2 This, REFCLSID CompositorCLSID);
        public put__CustomCompositorClassDelegate put__CustomCompositorClass;

        /* [id][restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__CustomCompositor)(interface IMSVidVideoRenderer2 * This, interface IVMRImageCompositor **Compositor);
        public delegate int get__CustomCompositorDelegate(@interface IMSVidVideoRenderer2 This, @interface IVMRImageCompositor[] Compositor);
        public get__CustomCompositorDelegate get__CustomCompositor;

        /* [id][restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__CustomCompositor)(interface IMSVidVideoRenderer2 * This, interface IVMRImageCompositor *Compositor);
        public delegate int put__CustomCompositorDelegate(@interface IMSVidVideoRenderer2 This, @interface IVMRImageCompositor Compositor);
        public put__CustomCompositorDelegate put__CustomCompositor;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixerBitmap)(interface IMSVidVideoRenderer2 * This, IPictureDisp **MixerPictureDisp);
        public delegate int get_MixerBitmapDelegate(@interface IMSVidVideoRenderer2 This, IPictureDisp[] MixerPictureDisp);
        public get_MixerBitmapDelegate get_MixerBitmap;

        /* [id][restricted][hidden][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__MixerBitmap)(interface IMSVidVideoRenderer2 * This, interface IVMRMixerBitmap **MixerPicture);
        public delegate int get__MixerBitmapDelegate(@interface IMSVidVideoRenderer2 This, @interface IVMRMixerBitmap[] MixerPicture);
        public get__MixerBitmapDelegate get__MixerBitmap;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixerBitmap)(interface IMSVidVideoRenderer2 * This, IPictureDisp *MixerPictureDisp);
        public delegate int put_MixerBitmapDelegate(@interface IMSVidVideoRenderer2 This, IPictureDisp MixerPictureDisp);
        public put_MixerBitmapDelegate put_MixerBitmap;

        /* [id][restricted][hidden][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put__MixerBitmap)(interface IMSVidVideoRenderer2 * This, VMRALPHABITMAP *MixerPicture);
        public delegate int put__MixerBitmapDelegate(@interface IMSVidVideoRenderer2 This, VMRALPHABITMAP MixerPicture);
        public put__MixerBitmapDelegate put__MixerBitmap;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixerBitmapPositionRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect **rDest);
        public delegate int get_MixerBitmapPositionRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect[] rDest);
        public get_MixerBitmapPositionRectDelegate get_MixerBitmapPositionRect;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixerBitmapPositionRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect *rDest);
        public delegate int put_MixerBitmapPositionRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect rDest);
        public put_MixerBitmapPositionRectDelegate put_MixerBitmapPositionRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixerBitmapOpacity)(interface IMSVidVideoRenderer2 * This, int *opacity);
        public delegate int get_MixerBitmapOpacityDelegate(@interface IMSVidVideoRenderer2 This, ref int opacity);
        public get_MixerBitmapOpacityDelegate get_MixerBitmapOpacity;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixerBitmapOpacity)(interface IMSVidVideoRenderer2 * This, int opacity);
        public delegate int put_MixerBitmapOpacityDelegate(@interface IMSVidVideoRenderer2 This, int opacity);
        public put_MixerBitmapOpacityDelegate put_MixerBitmapOpacity;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetupMixerBitmap)(interface IMSVidVideoRenderer2 * This, IPictureDisp *MixerPictureDisp, int Opacity, interface IMSVidRect *rDest);
        public delegate int SetupMixerBitmapDelegate(@interface IMSVidVideoRenderer2 This, IPictureDisp MixerPictureDisp, int Opacity, @interface IMSVidRect rDest);
        public SetupMixerBitmapDelegate SetupMixerBitmap;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceSize)(interface IMSVidVideoRenderer2 * This, SourceSizeList *CurrentSize);
        public delegate int get_SourceSizeDelegate(@interface IMSVidVideoRenderer2 This, SourceSizeList CurrentSize);
        public get_SourceSizeDelegate get_SourceSize;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceSize)(interface IMSVidVideoRenderer2 * This, SourceSizeList NewSize);
        public delegate int put_SourceSizeDelegate(@interface IMSVidVideoRenderer2 This, SourceSizeList NewSize);
        public put_SourceSizeDelegate put_SourceSize;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OverScan)(interface IMSVidVideoRenderer2 * This, int *plPercent);
        public delegate int get_OverScanDelegate(@interface IMSVidVideoRenderer2 This, ref int plPercent);
        public get_OverScanDelegate get_OverScan;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_OverScan)(interface IMSVidVideoRenderer2 * This, int lPercent);
        public delegate int put_OverScanDelegate(@interface IMSVidVideoRenderer2 This, int lPercent);
        public put_OverScanDelegate put_OverScan;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvailableSourceRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect **pRect);
        public delegate int get_AvailableSourceRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect[] pRect);
        public get_AvailableSourceRectDelegate get_AvailableSourceRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MaxVidRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect **ppVidRect);
        public delegate int get_MaxVidRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect[] ppVidRect);
        public get_MaxVidRectDelegate get_MaxVidRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MinVidRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect **ppVidRect);
        public delegate int get_MinVidRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect[] ppVidRect);
        public get_MinVidRectDelegate get_MinVidRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClippedSourceRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect **pRect);
        public delegate int get_ClippedSourceRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect[] pRect);
        public get_ClippedSourceRectDelegate get_ClippedSourceRect;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_ClippedSourceRect)(interface IMSVidVideoRenderer2 * This, interface IMSVidRect *pRect);
        public delegate int put_ClippedSourceRectDelegate(@interface IMSVidVideoRenderer2 This, @interface IMSVidRect pRect);
        public put_ClippedSourceRectDelegate put_ClippedSourceRect;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_UsingOverlay)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL *UseOverlayVal);
        public delegate int get_UsingOverlayDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL UseOverlayVal);
        public get_UsingOverlayDelegate get_UsingOverlay;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_UsingOverlay)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL UseOverlayVal);
        public delegate int put_UsingOverlayDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL UseOverlayVal);
        public put_UsingOverlayDelegate put_UsingOverlay;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Capture)(interface IMSVidVideoRenderer2 * This, IPictureDisp **currentImage);
        public delegate int CaptureDelegate(@interface IMSVidVideoRenderer2 This, IPictureDisp[] currentImage);
        public CaptureDelegate Capture;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FramesPerSecond)(interface IMSVidVideoRenderer2 * This, int *pVal);
        public delegate int get_FramesPerSecondDelegate(@interface IMSVidVideoRenderer2 This, ref int pVal);
        public get_FramesPerSecondDelegate get_FramesPerSecond;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DecimateInput)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL *pDeci);
        public delegate int get_DecimateInputDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL pDeci);
        public get_DecimateInputDelegate get_DecimateInput;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DecimateInput)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL pDeci);
        public delegate int put_DecimateInputDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL pDeci);
        public put_DecimateInputDelegate put_DecimateInput;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Allocator)(interface IMSVidVideoRenderer2 * This, object**AllocPresent);
        public delegate int get_AllocatorDelegate(@interface IMSVidVideoRenderer2 This, object AllocPresent[] UnnamedParameter);
        public get_AllocatorDelegate get_Allocator;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Allocator)(interface IMSVidVideoRenderer2 * This, interface IVMRSurfaceAllocator **AllocPresent);
        public delegate int get__AllocatorDelegate(@interface IMSVidVideoRenderer2 This, @interface IVMRSurfaceAllocator[] AllocPresent);
        public get__AllocatorDelegate get__Allocator;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Allocator_ID)(interface IMSVidVideoRenderer2 * This, int *ID);
        public delegate int get_Allocator_IDDelegate(@interface IMSVidVideoRenderer2 This, ref int ID);
        public get_Allocator_IDDelegate get_Allocator_ID;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAllocator)(interface IMSVidVideoRenderer2 * This, object* AllocPresent, int ID);
        public delegate int SetAllocatorDelegate(@interface IMSVidVideoRenderer2 This, object AllocPresent, int ID);
        public SetAllocatorDelegate SetAllocator;

        /* [restricted][hidden][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *_SetAllocator)(interface IMSVidVideoRenderer2 * This, interface IVMRSurfaceAllocator *AllocPresent, int ID);
        public delegate int _SetAllocatorDelegate(@interface IMSVidVideoRenderer2 This, @interface IVMRSurfaceAllocator AllocPresent, int ID);
        public _SetAllocatorDelegate _SetAllocator;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SuppressEffects)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL bSuppress);
        public delegate int put_SuppressEffectsDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL bSuppress);
        public put_SuppressEffectsDelegate put_SuppressEffects;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SuppressEffects)(interface IMSVidVideoRenderer2 * This, VARIANT_BOOL *bSuppress);
        public delegate int get_SuppressEffectsDelegate(@interface IMSVidVideoRenderer2 This, VARIANT_BOOL bSuppress);
        public get_SuppressEffectsDelegate get_SuppressEffects;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidVideoRendererEvent2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVideoRendererEvent2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVideoRendererEvent2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVideoRendererEvent2 * This);
        public delegate uint AddRefDelegate(@interface IMSVidVideoRendererEvent2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVideoRendererEvent2 * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVideoRendererEvent2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidVideoRendererEvent2 * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidVideoRendererEvent2 This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidVideoRendererEvent2 * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidVideoRendererEvent2 This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidVideoRendererEvent2 * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidVideoRendererEvent2 This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidVideoRendererEvent2 * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidVideoRendererEvent2 This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidVideoRendererEvent2 * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidVideoRendererEvent2 This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OverlayUnavailable)(interface IMSVidVideoRendererEvent2 * This);
        public delegate int OverlayUnavailableDelegate(@interface IMSVidVideoRendererEvent2 This);
        public OverlayUnavailableDelegate OverlayUnavailable;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidAudioRendererVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidAudioRenderer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidAudioRenderer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidAudioRenderer * This);
        public delegate uint AddRefDelegate(@interface IMSVidAudioRenderer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidAudioRenderer * This);
        public delegate uint ReleaseDelegate(@interface IMSVidAudioRenderer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidAudioRenderer * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidAudioRenderer This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidAudioRenderer * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidAudioRenderer This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidAudioRenderer * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidAudioRenderer This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidAudioRenderer * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidAudioRenderer This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IMSVidAudioRenderer * This, char**Name);
        public delegate int get_NameDelegate(@interface IMSVidAudioRenderer This, char * Name[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface IMSVidAudioRenderer * This, int *Status);
        public delegate int get_StatusDelegate(@interface IMSVidAudioRenderer This, ref int Status);
        public get_StatusDelegate get_Status;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Power)(interface IMSVidAudioRenderer * This, VARIANT_BOOL Power);
        public delegate int put_PowerDelegate(@interface IMSVidAudioRenderer This, VARIANT_BOOL Power);
        public put_PowerDelegate put_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Power)(interface IMSVidAudioRenderer * This, VARIANT_BOOL *Power);
        public delegate int get_PowerDelegate(@interface IMSVidAudioRenderer This, VARIANT_BOOL Power);
        public get_PowerDelegate get_Power;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Category)(interface IMSVidAudioRenderer * This, char**Guid);
        public delegate int get_CategoryDelegate(@interface IMSVidAudioRenderer This, char * Guid[] UnnamedParameter);
        public get_CategoryDelegate get_Category;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ClassID)(interface IMSVidAudioRenderer * This, char**Clsid);
        public delegate int get_ClassIDDelegate(@interface IMSVidAudioRenderer This, char * Clsid[] UnnamedParameter);
        public get_ClassIDDelegate get_ClassID;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__Category)(interface IMSVidAudioRenderer * This, GUID *Guid);
        public delegate int get__CategoryDelegate(@interface IMSVidAudioRenderer This, GUID Guid);
        public get__CategoryDelegate get__Category;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__ClassID)(interface IMSVidAudioRenderer * This, GUID *Clsid);
        public delegate int get__ClassIDDelegate(@interface IMSVidAudioRenderer This, GUID Clsid);
        public get__ClassIDDelegate get__ClassID;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEqualDevice)(interface IMSVidAudioRenderer * This, interface IMSVidDevice *Device, VARIANT_BOOL *IsEqual);
        public delegate int IsEqualDeviceDelegate(@interface IMSVidAudioRenderer This, @interface IMSVidDevice Device, VARIANT_BOOL IsEqual);
        public IsEqualDeviceDelegate IsEqualDevice;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Volume)(interface IMSVidAudioRenderer * This, int lVol);
        public delegate int put_VolumeDelegate(@interface IMSVidAudioRenderer This, int lVol);
        public put_VolumeDelegate put_Volume;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Volume)(interface IMSVidAudioRenderer * This, int *lVol);
        public delegate int get_VolumeDelegate(@interface IMSVidAudioRenderer This, ref int lVol);
        public get_VolumeDelegate get_Volume;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Balance)(interface IMSVidAudioRenderer * This, int lBal);
        public delegate int put_BalanceDelegate(@interface IMSVidAudioRenderer This, int lBal);
        public put_BalanceDelegate put_Balance;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Balance)(interface IMSVidAudioRenderer * This, int *lBal);
        public delegate int get_BalanceDelegate(@interface IMSVidAudioRenderer This, ref int lBal);
        public get_BalanceDelegate get_Balance;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidAudioRendererEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidAudioRendererEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidAudioRendererEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidAudioRendererEvent * This);
        public delegate uint AddRefDelegate(@interface IMSVidAudioRendererEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidAudioRendererEvent * This);
        public delegate uint ReleaseDelegate(@interface IMSVidAudioRendererEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidAudioRendererEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidAudioRendererEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidAudioRendererEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidAudioRendererEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidAudioRendererEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidAudioRendererEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidAudioRendererEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidAudioRendererEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StateChange)(interface IMSVidAudioRendererEvent * This, interface IMSVidDevice *lpd, int oldState, int newState);
        public delegate int StateChangeDelegate(@interface IMSVidAudioRendererEvent This, @interface IMSVidDevice lpd, int oldState, int newState);
        public StateChangeDelegate StateChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidInputDevicesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidInputDevices * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidInputDevices This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidInputDevices * This);
        public delegate uint AddRefDelegate(@interface IMSVidInputDevices This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidInputDevices * This);
        public delegate uint ReleaseDelegate(@interface IMSVidInputDevices This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidInputDevices * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidInputDevices This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidInputDevices * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidInputDevices This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidInputDevices * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidInputDevices This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidInputDevices * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidInputDevices This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IMSVidInputDevices * This, int *lCount);
        public delegate int get_CountDelegate(@interface IMSVidInputDevices This, ref int lCount);
        public get_CountDelegate get_Count;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface IMSVidInputDevices * This, IEnumVARIANT **pD);
        public delegate int get__NewEnumDelegate(@interface IMSVidInputDevices This, IEnumVARIANT[] pD);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface IMSVidInputDevices * This, VARIANT v, interface IMSVidInputDevice **pDB);
        public delegate int get_ItemDelegate(@interface IMSVidInputDevices This, VARIANT v, @interface IMSVidInputDevice[] pDB);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface IMSVidInputDevices * This, interface IMSVidInputDevice *pDB);
        public delegate int AddDelegate(@interface IMSVidInputDevices This, @interface IMSVidInputDevice pDB);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface IMSVidInputDevices * This, VARIANT v);
        public delegate int RemoveDelegate(@interface IMSVidInputDevices This, VARIANT v);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidOutputDevicesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidOutputDevices * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidOutputDevices This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidOutputDevices * This);
        public delegate uint AddRefDelegate(@interface IMSVidOutputDevices This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidOutputDevices * This);
        public delegate uint ReleaseDelegate(@interface IMSVidOutputDevices This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidOutputDevices * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidOutputDevices This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidOutputDevices * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidOutputDevices This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidOutputDevices * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidOutputDevices This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidOutputDevices * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidOutputDevices This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IMSVidOutputDevices * This, int *lCount);
        public delegate int get_CountDelegate(@interface IMSVidOutputDevices This, ref int lCount);
        public get_CountDelegate get_Count;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface IMSVidOutputDevices * This, IEnumVARIANT **pD);
        public delegate int get__NewEnumDelegate(@interface IMSVidOutputDevices This, IEnumVARIANT[] pD);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface IMSVidOutputDevices * This, VARIANT v, interface IMSVidOutputDevice **pDB);
        public delegate int get_ItemDelegate(@interface IMSVidOutputDevices This, VARIANT v, @interface IMSVidOutputDevice[] pDB);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface IMSVidOutputDevices * This, interface IMSVidOutputDevice *pDB);
        public delegate int AddDelegate(@interface IMSVidOutputDevices This, @interface IMSVidOutputDevice pDB);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface IMSVidOutputDevices * This, VARIANT v);
        public delegate int RemoveDelegate(@interface IMSVidOutputDevices This, VARIANT v);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidVideoRendererDevicesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidVideoRendererDevices * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidVideoRendererDevices This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidVideoRendererDevices * This);
        public delegate uint AddRefDelegate(@interface IMSVidVideoRendererDevices This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidVideoRendererDevices * This);
        public delegate uint ReleaseDelegate(@interface IMSVidVideoRendererDevices This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidVideoRendererDevices * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidVideoRendererDevices This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidVideoRendererDevices * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidVideoRendererDevices This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidVideoRendererDevices * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidVideoRendererDevices This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidVideoRendererDevices * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidVideoRendererDevices This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IMSVidVideoRendererDevices * This, int *lCount);
        public delegate int get_CountDelegate(@interface IMSVidVideoRendererDevices This, ref int lCount);
        public get_CountDelegate get_Count;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface IMSVidVideoRendererDevices * This, IEnumVARIANT **pD);
        public delegate int get__NewEnumDelegate(@interface IMSVidVideoRendererDevices This, IEnumVARIANT[] pD);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface IMSVidVideoRendererDevices * This, VARIANT v, interface IMSVidVideoRenderer **pDB);
        public delegate int get_ItemDelegate(@interface IMSVidVideoRendererDevices This, VARIANT v, @interface IMSVidVideoRenderer[] pDB);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface IMSVidVideoRendererDevices * This, interface IMSVidVideoRenderer *pDB);
        public delegate int AddDelegate(@interface IMSVidVideoRendererDevices This, @interface IMSVidVideoRenderer pDB);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface IMSVidVideoRendererDevices * This, VARIANT v);
        public delegate int RemoveDelegate(@interface IMSVidVideoRendererDevices This, VARIANT v);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidAudioRendererDevicesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidAudioRendererDevices * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidAudioRendererDevices This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidAudioRendererDevices * This);
        public delegate uint AddRefDelegate(@interface IMSVidAudioRendererDevices This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidAudioRendererDevices * This);
        public delegate uint ReleaseDelegate(@interface IMSVidAudioRendererDevices This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidAudioRendererDevices * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidAudioRendererDevices This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidAudioRendererDevices * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidAudioRendererDevices This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidAudioRendererDevices * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidAudioRendererDevices This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidAudioRendererDevices * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidAudioRendererDevices This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IMSVidAudioRendererDevices * This, int *lCount);
        public delegate int get_CountDelegate(@interface IMSVidAudioRendererDevices This, ref int lCount);
        public get_CountDelegate get_Count;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface IMSVidAudioRendererDevices * This, IEnumVARIANT **pD);
        public delegate int get__NewEnumDelegate(@interface IMSVidAudioRendererDevices This, IEnumVARIANT[] pD);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface IMSVidAudioRendererDevices * This, VARIANT v, interface IMSVidAudioRenderer **pDB);
        public delegate int get_ItemDelegate(@interface IMSVidAudioRendererDevices This, VARIANT v, @interface IMSVidAudioRenderer[] pDB);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface IMSVidAudioRendererDevices * This, interface IMSVidAudioRenderer *pDB);
        public delegate int AddDelegate(@interface IMSVidAudioRendererDevices This, @interface IMSVidAudioRenderer pDB);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface IMSVidAudioRendererDevices * This, VARIANT v);
        public delegate int RemoveDelegate(@interface IMSVidAudioRendererDevices This, VARIANT v);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class IMSVidFeaturesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMSVidFeatures * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMSVidFeatures This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMSVidFeatures * This);
        public delegate uint AddRefDelegate(@interface IMSVidFeatures This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMSVidFeatures * This);
        public delegate uint ReleaseDelegate(@interface IMSVidFeatures This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMSVidFeatures * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMSVidFeatures This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMSVidFeatures * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMSVidFeatures This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMSVidFeatures * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMSVidFeatures This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMSVidFeatures * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMSVidFeatures This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IMSVidFeatures * This, int *lCount);
        public delegate int get_CountDelegate(@interface IMSVidFeatures This, ref int lCount);
        public get_CountDelegate get_Count;

        /* [restricted][hidden][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface IMSVidFeatures * This, IEnumVARIANT **pD);
        public delegate int get__NewEnumDelegate(@interface IMSVidFeatures This, IEnumVARIANT[] pD);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface IMSVidFeatures * This, VARIANT v, interface IMSVidFeature **pDB);
        public delegate int get_ItemDelegate(@interface IMSVidFeatures This, VARIANT v, @interface IMSVidFeature[] pDB);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface IMSVidFeatures * This, interface IMSVidFeature *pDB);
        public delegate int AddDelegate(@interface IMSVidFeatures This, @interface IMSVidFeature pDB);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface IMSVidFeatures * This, VARIANT v);
        public delegate int RemoveDelegate(@interface IMSVidFeatures This, VARIANT v);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }