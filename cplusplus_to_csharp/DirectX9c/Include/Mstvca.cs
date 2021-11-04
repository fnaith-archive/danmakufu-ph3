using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for mstvca.idl:
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
























































#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class CAManager CAManager;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct CAManager CAManager;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class CAManagerProxy CAManagerProxy;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct CAManagerProxy CAManagerProxy;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class CADenials CADenials;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct CADenials CADenials;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class CAOffer CAOffer;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct CAOffer CAOffer;
#endif // __cplusplus






#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class CAResDenialTree CAResDenialTree;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct CAResDenialTree CAResDenialTree;
#endif // __cplusplus






#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class CADefaultDlg CADefaultDlg;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct CADefaultDlg CADefaultDlg;
#endif // __cplusplus



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

#if __cplusplus
#endif

/* interface __MIDL_itf_mstvca_0000 */
/* [local] */ 















public enum __MIDL___MIDL_itf_mstvca_0000_0001
{
        Unselected = 0,
    Selected = 1
}

public enum __MIDL___MIDL_itf_mstvca_0000_0002
{
        Denied = 0,
    Transient = 1,
    DescriptionShort = 10,
    DescriptionLong = 11,
    DescriptionHTML = 12,
    DescriptionXML = 13
}

public enum __MIDL___MIDL_itf_mstvca_0000_0003
{
        Short = 0,
    Long = 1,
    URL = 2,
    HTML = 3,
    XML = 4,
    kDescEnd = 5
}

public enum __MIDL___MIDL_itf_mstvca_0000_0004
{
        Request = 1,
    ComponentX = 2,
    Offers = 4,
    PaidTolls = 8,
    Policies = 16,
    Standard = 15,
    All = 31
}

#else // C style interface

    public class ICAManagerInternalVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAManagerInternal * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAManagerInternal This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAManagerInternal * This);
        public delegate uint AddRefDelegate(@interface ICAManagerInternal This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAManagerInternal * This);
        public delegate uint ReleaseDelegate(@interface ICAManagerInternal This);
        public ReleaseDelegate Release;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Save)(interface ICAManagerInternal * This);
        public delegate int SaveDelegate(@interface ICAManagerInternal This);
        public SaveDelegate Save;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Load)(interface ICAManagerInternal * This);
        public delegate int LoadDelegate(@interface ICAManagerInternal This);
        public LoadDelegate Load;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MarkDirty)(interface ICAManagerInternal * This, bool fDirty);
        public delegate int put_MarkDirtyDelegate(@interface ICAManagerInternal This, bool fDirty);
        public put_MarkDirtyDelegate put_MarkDirty;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MarkDirty)(interface ICAManagerInternal * This, bool *pfDirty);
        public delegate int get_MarkDirtyDelegate(@interface ICAManagerInternal This, ref bool pfDirty);
        public get_MarkDirtyDelegate get_MarkDirty;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuneRequest)(interface ICAManagerInternal * This, interface ITuneRequest *ptunereq);
        public delegate int put_TuneRequestDelegate(@interface ICAManagerInternal This, @interface ITuneRequest ptunereq);
        public put_TuneRequestDelegate put_TuneRequest;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultUI)(interface ICAManagerInternal * This, System.IntPtr *phwnd);
        public delegate int GetDefaultUIDelegate(@interface ICAManagerInternal This, IntPtr phwnd);
        public GetDefaultUIDelegate GetDefaultUI;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultUI)(interface ICAManagerInternal * This, System.IntPtr hwnd);
        public delegate int SetDefaultUIDelegate(@interface ICAManagerInternal This, IntPtr hwnd);
        public SetDefaultUIDelegate SetDefaultUI;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CAManagerMain)(interface ICAManagerInternal * This, interface ICAManager **ppManagerMain);
        public delegate int get_CAManagerMainDelegate(@interface ICAManagerInternal This, @interface ICAManager[] ppManagerMain);
        public get_CAManagerMainDelegate get_CAManagerMain;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BroadcastEventService)(interface ICAManagerInternal * This, interface IBroadcastEvent *pBroadcastEventService);
        public delegate int put_BroadcastEventServiceDelegate(@interface ICAManagerInternal This, @interface IBroadcastEvent pBroadcastEventService);
        public put_BroadcastEventServiceDelegate put_BroadcastEventService;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BroadcastEventService)(interface ICAManagerInternal * This, interface IBroadcastEvent **ppBroadcastEventService);
        public delegate int get_BroadcastEventServiceDelegate(@interface ICAManagerInternal This, @interface IBroadcastEvent[] ppBroadcastEventService);
        public get_BroadcastEventServiceDelegate get_BroadcastEventService;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DisplayDefaultUI)(interface ICAManagerInternal * This, VARIANT_BOOL fDisplay);
        public delegate int DisplayDefaultUIDelegate(@interface ICAManagerInternal This, VARIANT_BOOL fDisplay);
        public DisplayDefaultUIDelegate DisplayDefaultUI;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnableDefaultUIPayTollsButton)(interface ICAManagerInternal * This, VARIANT_BOOL fEnabled);
        public delegate int EnableDefaultUIPayTollsButtonDelegate(@interface ICAManagerInternal This, VARIANT_BOOL fEnabled);
        public EnableDefaultUIPayTollsButtonDelegate EnableDefaultUIPayTollsButton;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UpdateDefaultUIForToll)(interface ICAManagerInternal * This, interface ICAToll *pToll, CATollState enState);
        public delegate int UpdateDefaultUIForTollDelegate(@interface ICAManagerInternal This, @interface ICAToll pToll, CATollState enState);
        public UpdateDefaultUIForTollDelegate UpdateDefaultUIForToll;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuneRequestInt)(interface ICAManagerInternal * This, interface ITuneRequest *ptunereq);
        public delegate int put_TuneRequestIntDelegate(@interface ICAManagerInternal This, @interface ITuneRequest ptunereq);
        public put_TuneRequestIntDelegate put_TuneRequestInt;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddDenialsFor)(interface ICAManagerInternal * This, object* pUnk);
        public delegate int AddDenialsForDelegate(@interface ICAManagerInternal This, object pUnk);
        public AddDenialsForDelegate AddDenialsFor;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveDenialsFor)(interface ICAManagerInternal * This, object* pUnk);
        public delegate int RemoveDenialsForDelegate(@interface ICAManagerInternal This, object pUnk);
        public RemoveDenialsForDelegate RemoveDenialsFor;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestActivated)(interface ICAManagerInternal * This, interface ICARequest *pReq);
        public delegate int NotifyRequestActivatedDelegate(@interface ICAManagerInternal This, @interface ICARequest pReq);
        public NotifyRequestActivatedDelegate NotifyRequestActivated;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDeactivated)(interface ICAManagerInternal * This, interface ICARequest *pReq);
        public delegate int NotifyRequestDeactivatedDelegate(@interface ICAManagerInternal This, @interface ICARequest pReq);
        public NotifyRequestDeactivatedDelegate NotifyRequestDeactivated;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferAdded)(interface ICAManagerInternal * This, interface ICAOffer *pOffer, int cOffers);
        public delegate int NotifyOfferAddedDelegate(@interface ICAManagerInternal This, @interface ICAOffer pOffer, int cOffers);
        public NotifyOfferAddedDelegate NotifyOfferAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferRemoved)(interface ICAManagerInternal * This, interface ICAOffer *pOffer, int cOffers);
        public delegate int NotifyOfferRemovedDelegate(@interface ICAManagerInternal This, @interface ICAOffer pOffer, int cOffers);
        public NotifyOfferRemovedDelegate NotifyOfferRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyPolicyAdded)(interface ICAManagerInternal * This, interface ICAPolicy *pPolicy, int cPolicies);
        public delegate int NotifyPolicyAddedDelegate(@interface ICAManagerInternal This, @interface ICAPolicy pPolicy, int cPolicies);
        public NotifyPolicyAddedDelegate NotifyPolicyAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyPolicyRemoved)(interface ICAManagerInternal * This, interface ICAPolicy *pPolicy, int cPolicies);
        public delegate int NotifyPolicyRemovedDelegate(@interface ICAManagerInternal This, @interface ICAPolicy pPolicy, int cPolicies);
        public NotifyPolicyRemovedDelegate NotifyPolicyRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDenialAdded)(interface ICAManagerInternal * This, interface ICARequest *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyRequestDenialAddedDelegate(@interface ICAManagerInternal This, @interface ICARequest pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyRequestDenialAddedDelegate NotifyRequestDenialAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDenialRemoved)(interface ICAManagerInternal * This, interface ICARequest *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyRequestDenialRemovedDelegate(@interface ICAManagerInternal This, @interface ICARequest pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyRequestDenialRemovedDelegate NotifyRequestDenialRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialTollAdded)(interface ICAManagerInternal * This, interface ICADenial *pDenial, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyDenialTollAddedDelegate(@interface ICAManagerInternal This, @interface ICADenial pDenial, @interface ICAToll pToll, int cTolls);
        public NotifyDenialTollAddedDelegate NotifyDenialTollAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialTollRemoved)(interface ICAManagerInternal * This, interface ICADenial *pDenial, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyDenialTollRemovedDelegate(@interface ICAManagerInternal This, @interface ICADenial pDenial, @interface ICAToll pToll, int cTolls);
        public NotifyDenialTollRemovedDelegate NotifyDenialTollRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollDenialAdded)(interface ICAManagerInternal * This, interface ICAToll *pToll, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyTollDenialAddedDelegate(@interface ICAManagerInternal This, @interface ICAToll pToll, @interface ICADenial pDenial, int cDenials);
        public NotifyTollDenialAddedDelegate NotifyTollDenialAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollDenialRemoved)(interface ICAManagerInternal * This, interface ICAToll *pToll, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyTollDenialRemovedDelegate(@interface ICAManagerInternal This, @interface ICAToll pToll, @interface ICADenial pDenial, int cDenials);
        public NotifyTollDenialRemovedDelegate NotifyTollDenialRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferTollAdded)(interface ICAManagerInternal * This, interface ICAOffer *pOffer, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyOfferTollAddedDelegate(@interface ICAManagerInternal This, @interface ICAOffer pOffer, @interface ICAToll pToll, int cTolls);
        public NotifyOfferTollAddedDelegate NotifyOfferTollAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferTollRemoved)(interface ICAManagerInternal * This, interface ICAOffer *pOffer, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyOfferTollRemovedDelegate(@interface ICAManagerInternal This, @interface ICAOffer pOffer, @interface ICAToll pToll, int cTolls);
        public NotifyOfferTollRemovedDelegate NotifyOfferTollRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollStateChanged)(interface ICAManagerInternal * This, interface ICAToll *pToll, CATollState enStateLast);
        public delegate int NotifyTollStateChangedDelegate(@interface ICAManagerInternal This, @interface ICAToll pToll, CATollState enStateLast);
        public NotifyTollStateChangedDelegate NotifyTollStateChanged;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialStateChanged)(interface ICAManagerInternal * This, interface ICADenial *pDenial, CADenialState enStateLast);
        public delegate int NotifyDenialStateChangedDelegate(@interface ICAManagerInternal This, @interface ICADenial pDenial, CADenialState enStateLast);
        public NotifyDenialStateChangedDelegate NotifyDenialStateChanged;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyComponentDenialAdded)(interface ICAManagerInternal * This, interface ICAComponent *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyComponentDenialAddedDelegate(@interface ICAManagerInternal This, @interface ICAComponent pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyComponentDenialAddedDelegate NotifyComponentDenialAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyComponentDenialRemoved)(interface ICAManagerInternal * This, interface ICAComponent *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyComponentDenialRemovedDelegate(@interface ICAManagerInternal This, @interface ICAComponent pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyComponentDenialRemovedDelegate NotifyComponentDenialRemoved;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAManagerXProxyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAManagerXProxy * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAManagerXProxy This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAManagerXProxy * This);
        public delegate uint AddRefDelegate(@interface ICAManagerXProxy This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAManagerXProxy * This);
        public delegate uint ReleaseDelegate(@interface ICAManagerXProxy This);
        public ReleaseDelegate Release;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PunkCAManagerProxy)(interface ICAManagerXProxy * This, object**ppUnkCAManagerProxy);
        public delegate int get_PunkCAManagerProxyDelegate(@interface ICAManagerXProxy This, object ppUnkCAManagerProxy[] UnnamedParameter);
        public get_PunkCAManagerProxyDelegate get_PunkCAManagerProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestActivated_XProxy)(interface ICAManagerXProxy * This, interface ICARequest *pReq);
        public delegate int NotifyRequestActivated_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICARequest pReq);
        public NotifyRequestActivated_XProxyDelegate NotifyRequestActivated_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDeactivated_XProxy)(interface ICAManagerXProxy * This, interface ICARequest *pReq);
        public delegate int NotifyRequestDeactivated_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICARequest pReq);
        public NotifyRequestDeactivated_XProxyDelegate NotifyRequestDeactivated_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferAdded_XProxy)(interface ICAManagerXProxy * This, interface ICAOffer *pOffer, int cOffers);
        public delegate int NotifyOfferAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAOffer pOffer, int cOffers);
        public NotifyOfferAdded_XProxyDelegate NotifyOfferAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICAOffer *pOffer, int cOffers);
        public delegate int NotifyOfferRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAOffer pOffer, int cOffers);
        public NotifyOfferRemoved_XProxyDelegate NotifyOfferRemoved_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyPolicyAdded_XProxy)(interface ICAManagerXProxy * This, interface ICAPolicy *pPolicy, int cPolicies);
        public delegate int NotifyPolicyAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAPolicy pPolicy, int cPolicies);
        public NotifyPolicyAdded_XProxyDelegate NotifyPolicyAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyPolicyRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICAPolicy *pPolicy, int cPolicies);
        public delegate int NotifyPolicyRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAPolicy pPolicy, int cPolicies);
        public NotifyPolicyRemoved_XProxyDelegate NotifyPolicyRemoved_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDenialAdded_XProxy)(interface ICAManagerXProxy * This, interface ICARequest *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyRequestDenialAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICARequest pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyRequestDenialAdded_XProxyDelegate NotifyRequestDenialAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDenialRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICARequest *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyRequestDenialRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICARequest pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyRequestDenialRemoved_XProxyDelegate NotifyRequestDenialRemoved_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialTollAdded_XProxy)(interface ICAManagerXProxy * This, interface ICADenial *pDenial, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyDenialTollAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICADenial pDenial, @interface ICAToll pToll, int cTolls);
        public NotifyDenialTollAdded_XProxyDelegate NotifyDenialTollAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialTollRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICADenial *pDenial, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyDenialTollRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICADenial pDenial, @interface ICAToll pToll, int cTolls);
        public NotifyDenialTollRemoved_XProxyDelegate NotifyDenialTollRemoved_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollDenialAdded_XProxy)(interface ICAManagerXProxy * This, interface ICAToll *pToll, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyTollDenialAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAToll pToll, @interface ICADenial pDenial, int cDenials);
        public NotifyTollDenialAdded_XProxyDelegate NotifyTollDenialAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollDenialRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICAToll *pToll, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyTollDenialRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAToll pToll, @interface ICADenial pDenial, int cDenials);
        public NotifyTollDenialRemoved_XProxyDelegate NotifyTollDenialRemoved_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferTollAdded_XProxy)(interface ICAManagerXProxy * This, interface ICAOffer *pOffer, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyOfferTollAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAOffer pOffer, @interface ICAToll pToll, int cTolls);
        public NotifyOfferTollAdded_XProxyDelegate NotifyOfferTollAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferTollRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICAOffer *pOffer, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyOfferTollRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAOffer pOffer, @interface ICAToll pToll, int cTolls);
        public NotifyOfferTollRemoved_XProxyDelegate NotifyOfferTollRemoved_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollStateChanged_XProxy)(interface ICAManagerXProxy * This, interface ICAToll *pToll, CATollState enStateLast);
        public delegate int NotifyTollStateChanged_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAToll pToll, CATollState enStateLast);
        public NotifyTollStateChanged_XProxyDelegate NotifyTollStateChanged_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialStateChanged_XProxy)(interface ICAManagerXProxy * This, interface ICADenial *pDenial, CADenialState enStateLast);
        public delegate int NotifyDenialStateChanged_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICADenial pDenial, CADenialState enStateLast);
        public NotifyDenialStateChanged_XProxyDelegate NotifyDenialStateChanged_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyComponentDenialAdded_XProxy)(interface ICAManagerXProxy * This, interface ICAComponent *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyComponentDenialAdded_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAComponent pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyComponentDenialAdded_XProxyDelegate NotifyComponentDenialAdded_XProxy;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyComponentDenialRemoved_XProxy)(interface ICAManagerXProxy * This, interface ICAComponent *pReq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyComponentDenialRemoved_XProxyDelegate(@interface ICAManagerXProxy This, @interface ICAComponent pReq, @interface ICADenial pDenial, int cDenials);
        public NotifyComponentDenialRemoved_XProxyDelegate NotifyComponentDenialRemoved_XProxy;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAPoliciesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAPolicies * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAPolicies This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAPolicies * This);
        public delegate uint AddRefDelegate(@interface ICAPolicies This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAPolicies * This);
        public delegate uint ReleaseDelegate(@interface ICAPolicies This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAPolicies * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAPolicies This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAPolicies * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAPolicies This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAPolicies * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAPolicies This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAPolicies * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAPolicies This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [restricted][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface ICAPolicies * This, object**ppCollection);
        public delegate int get__NewEnumDelegate(@interface ICAPolicies This, object ppCollection[] UnnamedParameter);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface ICAPolicies * This, int *Count);
        public delegate int get_CountDelegate(@interface ICAPolicies This, ref int Count);
        public get_CountDelegate get_Count;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface ICAPolicies * This, VARIANT Index, interface ICAPolicy **ppPolicy);
        public delegate int get_ItemDelegate(@interface ICAPolicies This, VARIANT Index, @interface ICAPolicy[] ppPolicy);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface ICAPolicies * This, interface ICAPolicy *pPolicy);
        public delegate int AddDelegate(@interface ICAPolicies This, @interface ICAPolicy pPolicy);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface ICAPolicies * This, VARIANT Index);
        public delegate int RemoveDelegate(@interface ICAPolicies This, VARIANT Index);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAPoliciesInternalVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAPoliciesInternal * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAPoliciesInternal This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAPoliciesInternal * This);
        public delegate uint AddRefDelegate(@interface ICAPoliciesInternal This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAPoliciesInternal * This);
        public delegate uint ReleaseDelegate(@interface ICAPoliciesInternal This);
        public ReleaseDelegate Release;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetCAManager)(interface ICAPoliciesInternal * This, interface ICAManager *pManager);
        public delegate int SetCAManagerDelegate(@interface ICAPoliciesInternal This, @interface ICAManager pManager);
        public SetCAManagerDelegate SetCAManager;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CheckRequest)(interface ICAPoliciesInternal * This, interface ICARequest *pReq);
        public delegate int CheckRequestDelegate(@interface ICAPoliciesInternal This, @interface ICARequest pReq);
        public CheckRequestDelegate CheckRequest;

//        END_INTERFACE
    }

#else // C style interface

    public class ICATollsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICATolls * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICATolls This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICATolls * This);
        public delegate uint AddRefDelegate(@interface ICATolls This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICATolls * This);
        public delegate uint ReleaseDelegate(@interface ICATolls This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICATolls * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICATolls This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICATolls * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICATolls This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICATolls * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICATolls This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICATolls * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICATolls This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [restricted][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface ICATolls * This, object**ppCollection);
        public delegate int get__NewEnumDelegate(@interface ICATolls This, object ppCollection[] UnnamedParameter);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface ICATolls * This, int *Count);
        public delegate int get_CountDelegate(@interface ICATolls This, ref int Count);
        public get_CountDelegate get_Count;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface ICATolls * This, VARIANT Index, interface ICAToll **ppToll);
        public delegate int get_ItemDelegate(@interface ICATolls This, VARIANT Index, @interface ICAToll[] ppToll);
        public get_ItemDelegate get_Item;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Add)(interface ICATolls * This, interface ICAToll *pToll);
        public delegate int AddDelegate(@interface ICATolls This, @interface ICAToll pToll);
        public AddDelegate Add;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface ICATolls * This, VARIANT Index);
        public delegate int RemoveDelegate(@interface ICATolls This, VARIANT Index);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class ICATollsInternalVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICATollsInternal * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICATollsInternal This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICATollsInternal * This);
        public delegate uint AddRefDelegate(@interface ICATollsInternal This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICATollsInternal * This);
        public delegate uint ReleaseDelegate(@interface ICATollsInternal This);
        public ReleaseDelegate Release;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetCAManager)(interface ICATollsInternal * This, interface ICAManager *pManager);
        public delegate int SetCAManagerDelegate(@interface ICATollsInternal This, @interface ICAManager pManager);
        public SetCAManagerDelegate SetCAManager;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCAManager)(interface ICATollsInternal * This, interface ICAManager **ppManager);
        public delegate int GetCAManagerDelegate(@interface ICATollsInternal This, @interface ICAManager[] ppManager);
        public GetCAManagerDelegate GetCAManager;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMustPersist)(interface ICATollsInternal * This, bool fMustPersist);
        public delegate int SetMustPersistDelegate(@interface ICATollsInternal This, bool fMustPersist);
        public SetMustPersistDelegate SetMustPersist;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Save)(interface ICATollsInternal * This, IStorage *pstore, char* bstrPrefix);
        public delegate int SaveDelegate(@interface ICATollsInternal This, IStorage pstore, ref string bstrPrefix);
        public SaveDelegate Save;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Load)(interface ICATollsInternal * This, IStorage *pstore, char* bstrPrefix);
        public delegate int LoadDelegate(@interface ICATollsInternal This, IStorage pstore, ref string bstrPrefix);
        public LoadDelegate Load;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyStateChanged)(interface ICATollsInternal * This, interface ICAToll *pToll, CATollState enStateFrom);
        public delegate int NotifyStateChangedDelegate(@interface ICATollsInternal This, @interface ICAToll pToll, CATollState enStateFrom);
        public NotifyStateChangedDelegate NotifyStateChanged;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollSelectionChanged)(interface ICATollsInternal * This, interface ICAToll *pToll, bool fSelected);
        public delegate int NotifyTollSelectionChangedDelegate(@interface ICATollsInternal This, @interface ICAToll pToll, bool fSelected);
        public NotifyTollSelectionChangedDelegate NotifyTollSelectionChanged;

//        END_INTERFACE
    }

#else // C style interface

    public class ICADenialsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICADenials * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICADenials This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICADenials * This);
        public delegate uint AddRefDelegate(@interface ICADenials This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICADenials * This);
        public delegate uint ReleaseDelegate(@interface ICADenials This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICADenials * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICADenials This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICADenials * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICADenials This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICADenials * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICADenials This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICADenials * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICADenials This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [restricted][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface ICADenials * This, object**ppCollection);
        public delegate int get__NewEnumDelegate(@interface ICADenials This, object ppCollection[] UnnamedParameter);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface ICADenials * This, int *Count);
        public delegate int get_CountDelegate(@interface ICADenials This, ref int Count);
        public get_CountDelegate get_Count;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface ICADenials * This, VARIANT Index, interface ICADenial **ppDenial);
        public delegate int get_ItemDelegate(@interface ICADenials This, VARIANT Index, @interface ICADenial[] ppDenial);
        public get_ItemDelegate get_Item;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AddNew)(interface ICADenials * This, interface ICAPolicy *ppolicy, char* bstrShortDesc, object* pUnkDeniedObject, int enDenialState, interface ICADenial **ppDenial);
        public delegate int get_AddNewDelegate(@interface ICADenials This, @interface ICAPolicy ppolicy, ref string bstrShortDesc, object pUnkDeniedObject, int enDenialState, @interface ICADenial[] ppDenial);
        public get_AddNewDelegate get_AddNew;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface ICADenials * This, VARIANT Index);
        public delegate int RemoveDelegate(@interface ICADenials This, VARIANT Index);
        public RemoveDelegate Remove;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountDenied)(interface ICADenials * This, int *Count);
        public delegate int get_CountDeniedDelegate(@interface ICADenials This, ref int Count);
        public get_CountDeniedDelegate get_CountDenied;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountSelected)(interface ICADenials * This, int *Count);
        public delegate int get_CountSelectedDelegate(@interface ICADenials This, ref int Count);
        public get_CountSelectedDelegate get_CountSelected;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PaySelectedTolls)(interface ICADenials * This);
        public delegate int PaySelectedTollsDelegate(@interface ICADenials This);
        public PaySelectedTollsDelegate PaySelectedTolls;

//        END_INTERFACE
    }

#else // C style interface

    public class ICADenialsInternalVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICADenialsInternal * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICADenialsInternal This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICADenialsInternal * This);
        public delegate uint AddRefDelegate(@interface ICADenialsInternal This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICADenialsInternal * This);
        public delegate uint ReleaseDelegate(@interface ICADenialsInternal This);
        public ReleaseDelegate Release;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetCAManager)(interface ICADenialsInternal * This, interface ICAManager *pManager);
        public delegate int SetCAManagerDelegate(@interface ICADenialsInternal This, @interface ICAManager pManager);
        public SetCAManagerDelegate SetCAManager;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialStateChanged)(interface ICADenialsInternal * This, interface ICADenial *pDenial, CADenialState enStateLast);
        public delegate int NotifyDenialStateChangedDelegate(@interface ICADenialsInternal This, @interface ICADenial pDenial, CADenialState enStateLast);
        public NotifyDenialStateChangedDelegate NotifyDenialStateChanged;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAOffersVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAOffers * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAOffers This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAOffers * This);
        public delegate uint AddRefDelegate(@interface ICAOffers This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAOffers * This);
        public delegate uint ReleaseDelegate(@interface ICAOffers This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAOffers * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAOffers This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAOffers * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAOffers This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAOffers * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAOffers This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAOffers * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAOffers This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [restricted][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface ICAOffers * This, object**ppCollection);
        public delegate int get__NewEnumDelegate(@interface ICAOffers This, object ppCollection[] UnnamedParameter);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface ICAOffers * This, int *Count);
        public delegate int get_CountDelegate(@interface ICAOffers This, ref int Count);
        public get_CountDelegate get_Count;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface ICAOffers * This, VARIANT Index, interface ICAOffer **ppOffer);
        public delegate int get_ItemDelegate(@interface ICAOffers This, VARIANT Index, @interface ICAOffer[] ppOffer);
        public get_ItemDelegate get_Item;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AddNew)(interface ICAOffers * This, interface ICAPolicy *pPolicy, char* bstrName, DATE dateStart, DATE dateEnd, interface ICAOffer **ppOffer);
        public delegate int get_AddNewDelegate(@interface ICAOffers This, @interface ICAPolicy pPolicy, ref string bstrName, DATE dateStart, DATE dateEnd, @interface ICAOffer[] ppOffer);
        public get_AddNewDelegate get_AddNew;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Remove)(interface ICAOffers * This, VARIANT Index);
        public delegate int RemoveDelegate(@interface ICAOffers This, VARIANT Index);
        public RemoveDelegate Remove;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAComponentsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAComponents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAComponents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAComponents * This);
        public delegate uint AddRefDelegate(@interface ICAComponents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAComponents * This);
        public delegate uint ReleaseDelegate(@interface ICAComponents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAComponents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAComponents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAComponents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAComponents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAComponents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAComponents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAComponents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAComponents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [restricted][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface ICAComponents * This, object**ppCollection);
        public delegate int get__NewEnumDelegate(@interface ICAComponents This, object ppCollection[] UnnamedParameter);
        public get__NewEnumDelegate get__NewEnum;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface ICAComponents * This, int *Count);
        public delegate int get_CountDelegate(@interface ICAComponents This, ref int Count);
        public get_CountDelegate get_Count;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Item)(interface ICAComponents * This, VARIANT Index, interface ICAComponent **ppComponent);
        public delegate int get_ItemDelegate(@interface ICAComponents This, VARIANT Index, @interface ICAComponent[] ppComponent);
        public get_ItemDelegate get_Item;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAComponentInternalVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAComponentInternal * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAComponentInternal This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAComponentInternal * This);
        public delegate uint AddRefDelegate(@interface ICAComponentInternal This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAComponentInternal * This);
        public delegate uint ReleaseDelegate(@interface ICAComponentInternal This);
        public ReleaseDelegate Release;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveAllDenials)(interface ICAComponentInternal * This);
        public delegate int RemoveAllDenialsDelegate(@interface ICAComponentInternal This);
        public RemoveAllDenialsDelegate RemoveAllDenials;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Description)(interface ICAComponentInternal * This, CADescFormat enFormat, char**pbstrDescription);
        public delegate int get_DescriptionDelegate(@interface ICAComponentInternal This, CADescFormat enFormat, char * pbstrDescription[] UnnamedParameter);
        public get_DescriptionDelegate get_Description;

//        END_INTERFACE
    }

#else // C style interface

    public class ICADefaultDlgVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICADefaultDlg * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICADefaultDlg This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICADefaultDlg * This);
        public delegate uint AddRefDelegate(@interface ICADefaultDlg This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICADefaultDlg * This);
        public delegate uint ReleaseDelegate(@interface ICADefaultDlg This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICADefaultDlg * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICADefaultDlg This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICADefaultDlg * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICADefaultDlg This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICADefaultDlg * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICADefaultDlg This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICADefaultDlg * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICADefaultDlg This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_AutoSize)(interface ICADefaultDlg * This, VARIANT_BOOL vbool);
        public delegate int put_AutoSizeDelegate(@interface ICADefaultDlg This, VARIANT_BOOL vbool);
        public put_AutoSizeDelegate put_AutoSize;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AutoSize)(interface ICADefaultDlg * This, VARIANT_BOOL *pbool);
        public delegate int get_AutoSizeDelegate(@interface ICADefaultDlg This, VARIANT_BOOL pbool);
        public get_AutoSizeDelegate get_AutoSize;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BackColor)(interface ICADefaultDlg * This, OLE_COLOR clr);
        public delegate int put_BackColorDelegate(@interface ICADefaultDlg This, OLE_COLOR clr);
        public put_BackColorDelegate put_BackColor;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BackColor)(interface ICADefaultDlg * This, OLE_COLOR *pclr);
        public delegate int get_BackColorDelegate(@interface ICADefaultDlg This, OLE_COLOR pclr);
        public get_BackColorDelegate get_BackColor;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BackStyle)(interface ICADefaultDlg * This, int style);
        public delegate int put_BackStyleDelegate(@interface ICADefaultDlg This, int style);
        public put_BackStyleDelegate put_BackStyle;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BackStyle)(interface ICADefaultDlg * This, int *pstyle);
        public delegate int get_BackStyleDelegate(@interface ICADefaultDlg This, ref int pstyle);
        public get_BackStyleDelegate get_BackStyle;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BorderColor)(interface ICADefaultDlg * This, OLE_COLOR clr);
        public delegate int put_BorderColorDelegate(@interface ICADefaultDlg This, OLE_COLOR clr);
        public put_BorderColorDelegate put_BorderColor;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BorderColor)(interface ICADefaultDlg * This, OLE_COLOR *pclr);
        public delegate int get_BorderColorDelegate(@interface ICADefaultDlg This, OLE_COLOR pclr);
        public get_BorderColorDelegate get_BorderColor;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BorderStyle)(interface ICADefaultDlg * This, int style);
        public delegate int put_BorderStyleDelegate(@interface ICADefaultDlg This, int style);
        public put_BorderStyleDelegate put_BorderStyle;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BorderStyle)(interface ICADefaultDlg * This, int *pstyle);
        public delegate int get_BorderStyleDelegate(@interface ICADefaultDlg This, ref int pstyle);
        public get_BorderStyleDelegate get_BorderStyle;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BorderWidth)(interface ICADefaultDlg * This, int width);
        public delegate int put_BorderWidthDelegate(@interface ICADefaultDlg This, int width);
        public put_BorderWidthDelegate put_BorderWidth;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BorderWidth)(interface ICADefaultDlg * This, int *width);
        public delegate int get_BorderWidthDelegate(@interface ICADefaultDlg This, ref int width);
        public get_BorderWidthDelegate get_BorderWidth;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DrawMode)(interface ICADefaultDlg * This, int mode);
        public delegate int put_DrawModeDelegate(@interface ICADefaultDlg This, int mode);
        public put_DrawModeDelegate put_DrawMode;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DrawMode)(interface ICADefaultDlg * This, int *pmode);
        public delegate int get_DrawModeDelegate(@interface ICADefaultDlg This, ref int pmode);
        public get_DrawModeDelegate get_DrawMode;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DrawStyle)(interface ICADefaultDlg * This, int style);
        public delegate int put_DrawStyleDelegate(@interface ICADefaultDlg This, int style);
        public put_DrawStyleDelegate put_DrawStyle;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DrawStyle)(interface ICADefaultDlg * This, int *pstyle);
        public delegate int get_DrawStyleDelegate(@interface ICADefaultDlg This, ref int pstyle);
        public get_DrawStyleDelegate get_DrawStyle;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DrawWidth)(interface ICADefaultDlg * This, int width);
        public delegate int put_DrawWidthDelegate(@interface ICADefaultDlg This, int width);
        public put_DrawWidthDelegate put_DrawWidth;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DrawWidth)(interface ICADefaultDlg * This, int *pwidth);
        public delegate int get_DrawWidthDelegate(@interface ICADefaultDlg This, ref int pwidth);
        public get_DrawWidthDelegate get_DrawWidth;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_FillColor)(interface ICADefaultDlg * This, OLE_COLOR clr);
        public delegate int put_FillColorDelegate(@interface ICADefaultDlg This, OLE_COLOR clr);
        public put_FillColorDelegate put_FillColor;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FillColor)(interface ICADefaultDlg * This, OLE_COLOR *pclr);
        public delegate int get_FillColorDelegate(@interface ICADefaultDlg This, OLE_COLOR pclr);
        public get_FillColorDelegate get_FillColor;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_FillStyle)(interface ICADefaultDlg * This, int style);
        public delegate int put_FillStyleDelegate(@interface ICADefaultDlg This, int style);
        public put_FillStyleDelegate put_FillStyle;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FillStyle)(interface ICADefaultDlg * This, int *pstyle);
        public delegate int get_FillStyleDelegate(@interface ICADefaultDlg This, ref int pstyle);
        public get_FillStyleDelegate get_FillStyle;

        /* [id][propputref] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *putref_Font)(interface ICADefaultDlg * This, IFontDisp *pFont);
        public delegate int putref_FontDelegate(@interface ICADefaultDlg This, IFontDisp pFont);
        public putref_FontDelegate putref_Font;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Font)(interface ICADefaultDlg * This, IFontDisp *pFont);
        public delegate int put_FontDelegate(@interface ICADefaultDlg This, IFontDisp pFont);
        public put_FontDelegate put_Font;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Font)(interface ICADefaultDlg * This, IFontDisp **ppFont);
        public delegate int get_FontDelegate(@interface ICADefaultDlg This, IFontDisp[] ppFont);
        public get_FontDelegate get_Font;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_ForeColor)(interface ICADefaultDlg * This, OLE_COLOR clr);
        public delegate int put_ForeColorDelegate(@interface ICADefaultDlg This, OLE_COLOR clr);
        public put_ForeColorDelegate put_ForeColor;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ForeColor)(interface ICADefaultDlg * This, OLE_COLOR *pclr);
        public delegate int get_ForeColorDelegate(@interface ICADefaultDlg This, OLE_COLOR pclr);
        public get_ForeColorDelegate get_ForeColor;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Enabled)(interface ICADefaultDlg * This, VARIANT_BOOL vbool);
        public delegate int put_EnabledDelegate(@interface ICADefaultDlg This, VARIANT_BOOL vbool);
        public put_EnabledDelegate put_Enabled;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Enabled)(interface ICADefaultDlg * This, VARIANT_BOOL *pbool);
        public delegate int get_EnabledDelegate(@interface ICADefaultDlg This, VARIANT_BOOL pbool);
        public get_EnabledDelegate get_Enabled;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Window)(interface ICADefaultDlg * This, System.IntPtr *phwnd);
        public delegate int get_WindowDelegate(@interface ICADefaultDlg This, IntPtr phwnd);
        public get_WindowDelegate get_Window;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TabStop)(interface ICADefaultDlg * This, VARIANT_BOOL vbool);
        public delegate int put_TabStopDelegate(@interface ICADefaultDlg This, VARIANT_BOOL vbool);
        public put_TabStopDelegate put_TabStop;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TabStop)(interface ICADefaultDlg * This, VARIANT_BOOL *pbool);
        public delegate int get_TabStopDelegate(@interface ICADefaultDlg This, VARIANT_BOOL pbool);
        public get_TabStopDelegate get_TabStop;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Text)(interface ICADefaultDlg * This, char* strText);
        public delegate int put_TextDelegate(@interface ICADefaultDlg This, ref string strText);
        public put_TextDelegate put_Text;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Text)(interface ICADefaultDlg * This, char**pstrText);
        public delegate int get_TextDelegate(@interface ICADefaultDlg This, char * pstrText[] UnnamedParameter);
        public get_TextDelegate get_Text;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Caption)(interface ICADefaultDlg * This, char* strCaption);
        public delegate int put_CaptionDelegate(@interface ICADefaultDlg This, ref string strCaption);
        public put_CaptionDelegate put_Caption;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Caption)(interface ICADefaultDlg * This, char**pstrCaption);
        public delegate int get_CaptionDelegate(@interface ICADefaultDlg This, char * pstrCaption[] UnnamedParameter);
        public get_CaptionDelegate get_Caption;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BorderVisible)(interface ICADefaultDlg * This, VARIANT_BOOL vbool);
        public delegate int put_BorderVisibleDelegate(@interface ICADefaultDlg This, VARIANT_BOOL vbool);
        public put_BorderVisibleDelegate put_BorderVisible;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BorderVisible)(interface ICADefaultDlg * This, VARIANT_BOOL *pbool);
        public delegate int get_BorderVisibleDelegate(@interface ICADefaultDlg This, VARIANT_BOOL pbool);
        public get_BorderVisibleDelegate get_BorderVisible;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Appearance)(interface ICADefaultDlg * This, short appearance);
        public delegate int put_AppearanceDelegate(@interface ICADefaultDlg This, short appearance);
        public put_AppearanceDelegate put_Appearance;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Appearance)(interface ICADefaultDlg * This, short *pappearance);
        public delegate int get_AppearanceDelegate(@interface ICADefaultDlg This, ref short pappearance);
        public get_AppearanceDelegate get_Appearance;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MousePointer)(interface ICADefaultDlg * This, int pointer);
        public delegate int put_MousePointerDelegate(@interface ICADefaultDlg This, int pointer);
        public put_MousePointerDelegate put_MousePointer;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MousePointer)(interface ICADefaultDlg * This, int *ppointer);
        public delegate int get_MousePointerDelegate(@interface ICADefaultDlg This, ref int ppointer);
        public get_MousePointerDelegate get_MousePointer;

        /* [id][propputref] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *putref_MouseIcon)(interface ICADefaultDlg * This, IPictureDisp *pMouseIcon);
        public delegate int putref_MouseIconDelegate(@interface ICADefaultDlg This, IPictureDisp pMouseIcon);
        public putref_MouseIconDelegate putref_MouseIcon;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MouseIcon)(interface ICADefaultDlg * This, IPictureDisp *pMouseIcon);
        public delegate int put_MouseIconDelegate(@interface ICADefaultDlg This, IPictureDisp pMouseIcon);
        public put_MouseIconDelegate put_MouseIcon;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MouseIcon)(interface ICADefaultDlg * This, IPictureDisp **ppMouseIcon);
        public delegate int get_MouseIconDelegate(@interface ICADefaultDlg This, IPictureDisp[] ppMouseIcon);
        public get_MouseIconDelegate get_MouseIcon;

        /* [id][propputref] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *putref_Picture)(interface ICADefaultDlg * This, IPictureDisp *pPicture);
        public delegate int putref_PictureDelegate(@interface ICADefaultDlg This, IPictureDisp pPicture);
        public putref_PictureDelegate putref_Picture;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Picture)(interface ICADefaultDlg * This, IPictureDisp *pPicture);
        public delegate int put_PictureDelegate(@interface ICADefaultDlg This, IPictureDisp pPicture);
        public put_PictureDelegate put_Picture;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Picture)(interface ICADefaultDlg * This, IPictureDisp **ppPicture);
        public delegate int get_PictureDelegate(@interface ICADefaultDlg This, IPictureDisp[] ppPicture);
        public get_PictureDelegate get_Picture;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Valid)(interface ICADefaultDlg * This, VARIANT_BOOL vbool);
        public delegate int put_ValidDelegate(@interface ICADefaultDlg This, VARIANT_BOOL vbool);
        public put_ValidDelegate put_Valid;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Valid)(interface ICADefaultDlg * This, VARIANT_BOOL *pbool);
        public delegate int get_ValidDelegate(@interface ICADefaultDlg This, VARIANT_BOOL pbool);
        public get_ValidDelegate get_Valid;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICAResDenialTreeEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICAResDenialTreeEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICAResDenialTreeEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICAResDenialTreeEvents * This);
        public delegate uint AddRefDelegate(@interface _ICAResDenialTreeEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICAResDenialTreeEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICAResDenialTreeEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICAResDenialTreeEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICAResDenialTreeEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICAResDenialTreeEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICAResDenialTreeEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICAResDenialTreeEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICAResDenialTreeEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICAResDenialTreeEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICAResDenialTreeEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICAManagerEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICAManagerEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICAManagerEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICAManagerEvents * This);
        public delegate uint AddRefDelegate(@interface _ICAManagerEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICAManagerEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICAManagerEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICAManagerEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICAManagerEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICAManagerEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICAManagerEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICAManagerEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICAManagerEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICAManagerEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICAManagerEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICARequestEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICARequestEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICARequestEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICARequestEvents * This);
        public delegate uint AddRefDelegate(@interface _ICARequestEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICARequestEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICARequestEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICARequestEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICARequestEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICARequestEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICARequestEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICARequestEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICARequestEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICARequestEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICARequestEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICAPoliciesEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICAPoliciesEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICAPoliciesEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICAPoliciesEvents * This);
        public delegate uint AddRefDelegate(@interface _ICAPoliciesEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICAPoliciesEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICAPoliciesEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICAPoliciesEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICAPoliciesEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICAPoliciesEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICAPoliciesEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICAPoliciesEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICAPoliciesEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICAPoliciesEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICAPoliciesEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICATollsEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICATollsEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICATollsEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICATollsEvents * This);
        public delegate uint AddRefDelegate(@interface _ICATollsEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICATollsEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICATollsEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICATollsEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICATollsEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICATollsEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICATollsEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICATollsEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICATollsEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICATollsEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICATollsEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICADenialsEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICADenialsEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICADenialsEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICADenialsEvents * This);
        public delegate uint AddRefDelegate(@interface _ICADenialsEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICADenialsEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICADenialsEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICADenialsEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICADenialsEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICADenialsEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICADenialsEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICADenialsEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICADenialsEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICADenialsEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICADenialsEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICAOffersEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICAOffersEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICAOffersEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICAOffersEvents * This);
        public delegate uint AddRefDelegate(@interface _ICAOffersEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICAOffersEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICAOffersEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICAOffersEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICAOffersEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICAOffersEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICAOffersEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICAOffersEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICAOffersEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICAOffersEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICAOffersEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICAComponentsEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICAComponentsEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICAComponentsEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICAComponentsEvents * This);
        public delegate uint AddRefDelegate(@interface _ICAComponentsEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICAComponentsEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICAComponentsEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICAComponentsEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICAComponentsEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICAComponentsEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICAComponentsEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICAComponentsEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICAComponentsEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICAComponentsEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICAComponentsEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAManagerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAManager * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAManager This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAManager * This);
        public delegate uint AddRefDelegate(@interface ICAManager This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAManager * This);
        public delegate uint ReleaseDelegate(@interface ICAManager This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAManager * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAManager This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAManager * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAManager This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAManager * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAManager This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAManager * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAManager This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Policies)(interface ICAManager * This, interface ICAPolicies **ppPolicies);
        public delegate int get_PoliciesDelegate(@interface ICAManager This, @interface ICAPolicies[] ppPolicies);
        public get_PoliciesDelegate get_Policies;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ActiveRequest)(interface ICAManager * This, interface ICARequest **ppRequest);
        public delegate int get_ActiveRequestDelegate(@interface ICAManager This, @interface ICARequest[] ppRequest);
        public get_ActiveRequestDelegate get_ActiveRequest;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Offers)(interface ICAManager * This, interface ICAOffers **ppOffers);
        public delegate int get_OffersDelegate(@interface ICAManager This, @interface ICAOffers[] ppOffers);
        public get_OffersDelegate get_Offers;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PaidTolls)(interface ICAManager * This, interface ICATolls **ppTolls);
        public delegate int get_PaidTollsDelegate(@interface ICAManager This, @interface ICATolls[] ppTolls);
        public get_PaidTollsDelegate get_PaidTolls;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_UseDefaultUI)(interface ICAManager * This, int fUseDefaultUI);
        public delegate int put_UseDefaultUIDelegate(@interface ICAManager This, int fUseDefaultUI);
        public put_UseDefaultUIDelegate put_UseDefaultUI;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_UseDefaultUI)(interface ICAManager * This, int *pfUseDefaultUI);
        public delegate int get_UseDefaultUIDelegate(@interface ICAManager This, ref int pfUseDefaultUI);
        public get_UseDefaultUIDelegate get_UseDefaultUI;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DenialsFor)(interface ICAManager * This, object* pUnk, interface ICADenials **ppDenials);
        public delegate int get_DenialsForDelegate(@interface ICAManager This, object pUnk, @interface ICADenials[] ppDenials);
        public get_DenialsForDelegate get_DenialsFor;

//        END_INTERFACE
    }

#else // C style interface

    public class ICARequestVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICARequest * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICARequest This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICARequest * This);
        public delegate uint AddRefDelegate(@interface ICARequest This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICARequest * This);
        public delegate uint ReleaseDelegate(@interface ICARequest This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICARequest * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICARequest This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICARequest * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICARequest This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICARequest * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICARequest This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICARequest * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICARequest This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RequestedItem)(interface ICARequest * This, object**ppTunereq);
        public delegate int get_RequestedItemDelegate(@interface ICARequest This, object ppTunereq[] UnnamedParameter);
        public get_RequestedItemDelegate get_RequestedItem;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CAManager)(interface ICARequest * This, interface ICAManager **ppManager);
        public delegate int get_CAManagerDelegate(@interface ICARequest This, @interface ICAManager[] ppManager);
        public get_CAManagerDelegate get_CAManager;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ScheduleEntry)(interface ICARequest * This, object**ppUnkScheduleEntry);
        public delegate int get_ScheduleEntryDelegate(@interface ICARequest This, object ppUnkScheduleEntry[] UnnamedParameter);
        public get_ScheduleEntryDelegate get_ScheduleEntry;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Denials)(interface ICARequest * This, interface ICADenials **ppDenials);
        public delegate int get_DenialsDelegate(@interface ICARequest This, @interface ICADenials[] ppDenials);
        public get_DenialsDelegate get_Denials;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Components)(interface ICARequest * This, interface ICAComponents **pComponents);
        public delegate int get_ComponentsDelegate(@interface ICARequest This, @interface ICAComponents[] pComponents);
        public get_ComponentsDelegate get_Components;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Check)(interface ICARequest * This, int *pcDenials);
        public delegate int get_CheckDelegate(@interface ICARequest This, ref int pcDenials);
        public get_CheckDelegate get_Check;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ResolveDenials)(interface ICARequest * This, int *pcDenials);
        public delegate int get_ResolveDenialsDelegate(@interface ICARequest This, ref int pcDenials);
        public get_ResolveDenialsDelegate get_ResolveDenials;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountDeniedComponents)(interface ICARequest * This, int *pcDeniedComponents);
        public delegate int get_CountDeniedComponentsDelegate(@interface ICARequest This, ref int pcDeniedComponents);
        public get_CountDeniedComponentsDelegate get_CountDeniedComponents;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAPolicyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAPolicy * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAPolicy This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAPolicy * This);
        public delegate uint AddRefDelegate(@interface ICAPolicy This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAPolicy * This);
        public delegate uint ReleaseDelegate(@interface ICAPolicy This);
        public ReleaseDelegate Release;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface ICAPolicy * This, char**pbstr);
        public delegate int get_NameDelegate(@interface ICAPolicy This, char * pbstr[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CheckRequest)(interface ICAPolicy * This, interface ICARequest *pReq);
        public delegate int CheckRequestDelegate(@interface ICAPolicy This, @interface ICARequest pReq);
        public CheckRequestDelegate CheckRequest;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CAManager)(interface ICAPolicy * This, interface ICAManager *pManager);
        public delegate int put_CAManagerDelegate(@interface ICAPolicy This, @interface ICAManager pManager);
        public put_CAManagerDelegate put_CAManager;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OkToPersist)(interface ICAPolicy * This, bool *pfOkToPersist);
        public delegate int get_OkToPersistDelegate(@interface ICAPolicy This, ref bool pfOkToPersist);
        public get_OkToPersistDelegate get_OkToPersist;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OkToRemove)(interface ICAPolicy * This, bool *pfOkToRemove);
        public delegate int get_OkToRemoveDelegate(@interface ICAPolicy This, ref bool pfOkToRemove);
        public get_OkToRemoveDelegate get_OkToRemove;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OkToRemoveDenial)(interface ICAPolicy * This, interface ICADenial *pDenial, bool *pfOk);
        public delegate int get_OkToRemoveDenialDelegate(@interface ICAPolicy This, @interface ICADenial pDenial, ref bool pfOk);
        public get_OkToRemoveDenialDelegate get_OkToRemoveDenial;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OkToRemoveOffer)(interface ICAPolicy * This, interface ICAOffer *pOffer, bool *pfOk);
        public delegate int get_OkToRemoveOfferDelegate(@interface ICAPolicy This, @interface ICAOffer pOffer, ref bool pfOk);
        public get_OkToRemoveOfferDelegate get_OkToRemoveOffer;

//        END_INTERFACE
    }

#else // C style interface

    public class ICATollVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAToll * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAToll This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAToll * This);
        public delegate uint AddRefDelegate(@interface ICAToll This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAToll * This);
        public delegate uint ReleaseDelegate(@interface ICAToll This);
        public ReleaseDelegate Release;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CAManager)(interface ICAToll * This, interface ICAManager *pManager);
        public delegate int put_CAManagerDelegate(@interface ICAToll This, @interface ICAManager pManager);
        public put_CAManagerDelegate put_CAManager;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Select)(interface ICAToll * This, bool fSelect);
        public delegate int SelectDelegate(@interface ICAToll This, bool fSelect);
        public SelectDelegate Select;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PayToll)(interface ICAToll * This);
        public delegate int PayTollDelegate(@interface ICAToll This);
        public PayTollDelegate PayToll;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Refundable)(interface ICAToll * This, bool *pfRefundable);
        public delegate int get_RefundableDelegate(@interface ICAToll This, ref bool pfRefundable);
        public get_RefundableDelegate get_Refundable;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RefundToll)(interface ICAToll * This);
        public delegate int RefundTollDelegate(@interface ICAToll This);
        public RefundTollDelegate RefundToll;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TolledObject)(interface ICAToll * This, object**ppUnkTolled);
        public delegate int get_TolledObjectDelegate(@interface ICAToll This, object ppUnkTolled[] UnnamedParameter);
        public get_TolledObjectDelegate get_TolledObject;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Denials)(interface ICAToll * This, interface ICADenials **ppDenials);
        public delegate int get_DenialsDelegate(@interface ICAToll This, @interface ICADenials[] ppDenials);
        public get_DenialsDelegate get_Denials;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Policy)(interface ICAToll * This, interface ICAPolicy **ppPolicy);
        public delegate int get_PolicyDelegate(@interface ICAToll This, @interface ICAPolicy[] ppPolicy);
        public get_PolicyDelegate get_Policy;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Description)(interface ICAToll * This, CADescFormat enFormat, char**pbstr);
        public delegate int get_DescriptionDelegate(@interface ICAToll This, CADescFormat enFormat, char * pbstr[] UnnamedParameter);
        public get_DescriptionDelegate get_Description;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TimePaid)(interface ICAToll * This, DATE *pdtPaid);
        public delegate int get_TimePaidDelegate(@interface ICAToll This, DATE pdtPaid);
        public get_TimePaidDelegate get_TimePaid;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_State)(interface ICAToll * This, CATollState *penState);
        public delegate int get_StateDelegate(@interface ICAToll This, CATollState penState);
        public get_StateDelegate get_State;

//        END_INTERFACE
    }

#else // C style interface

    public class ICADenialVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICADenial * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICADenial This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICADenial * This);
        public delegate uint AddRefDelegate(@interface ICADenial This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICADenial * This);
        public delegate uint ReleaseDelegate(@interface ICADenial This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICADenial * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICADenial This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICADenial * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICADenial This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICADenial * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICADenial This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICADenial * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICADenial This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DeniedObject)(interface ICADenial * This, object**ppUnkDenied);
        public delegate int get_DeniedObjectDelegate(@interface ICADenial This, object ppUnkDenied[] UnnamedParameter);
        public get_DeniedObjectDelegate get_DeniedObject;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Policy)(interface ICADenial * This, interface ICAPolicy **ppPolicy);
        public delegate int get_PolicyDelegate(@interface ICADenial This, @interface ICAPolicy[] ppPolicy);
        public get_PolicyDelegate get_Policy;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Description)(interface ICADenial * This, CADescFormat enFormat, char**pbstr);
        public delegate int get_DescriptionDelegate(@interface ICADenial This, CADescFormat enFormat, char * pbstr[] UnnamedParameter);
        public get_DescriptionDelegate get_Description;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Description)(interface ICADenial * This, CADescFormat enFormat, char* bstr);
        public delegate int put_DescriptionDelegate(@interface ICADenial This, CADescFormat enFormat, ref string bstr);
        public put_DescriptionDelegate put_Description;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_State)(interface ICADenial * This, CADenialState *penState);
        public delegate int get_StateDelegate(@interface ICADenial This, CADenialState penState);
        public get_StateDelegate get_State;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_State)(interface ICADenial * This, CADenialState enState);
        public delegate int put_StateDelegate(@interface ICADenial This, CADenialState enState);
        public put_StateDelegate put_State;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Tolls)(interface ICADenial * This, interface ICATolls **ppTolls);
        public delegate int get_TollsDelegate(@interface ICADenial This, @interface ICATolls[] ppTolls);
        public get_TollsDelegate get_Tolls;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollStateChanged)(interface ICADenial * This, interface ICAToll *pToll, CATollState enStateFrom);
        public delegate int NotifyTollStateChangedDelegate(@interface ICADenial This, @interface ICAToll pToll, CATollState enStateFrom);
        public NotifyTollStateChangedDelegate NotifyTollStateChanged;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAOfferVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAOffer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAOffer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAOffer * This);
        public delegate uint AddRefDelegate(@interface ICAOffer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAOffer * This);
        public delegate uint ReleaseDelegate(@interface ICAOffer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAOffer * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAOffer This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAOffer * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAOffer This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAOffer * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAOffer This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAOffer * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAOffer This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CAManager)(interface ICAOffer * This, interface ICAManager **ppManager);
        public delegate int get_CAManagerDelegate(@interface ICAOffer This, @interface ICAManager[] ppManager);
        public get_CAManagerDelegate get_CAManager;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CAManager)(interface ICAOffer * This, interface ICAManager *pManager);
        public delegate int put_CAManagerDelegate(@interface ICAOffer This, @interface ICAManager pManager);
        public put_CAManagerDelegate put_CAManager;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Policy)(interface ICAOffer * This, interface ICAPolicy **pppolicy);
        public delegate int get_PolicyDelegate(@interface ICAOffer This, @interface ICAPolicy[] pppolicy);
        public get_PolicyDelegate get_Policy;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Description)(interface ICAOffer * This, CADescFormat enFormat, char**pbstr);
        public delegate int get_DescriptionDelegate(@interface ICAOffer This, CADescFormat enFormat, char * pbstr[] UnnamedParameter);
        public get_DescriptionDelegate get_Description;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Description)(interface ICAOffer * This, CADescFormat enFormat, char* bstr);
        public delegate int put_DescriptionDelegate(@interface ICAOffer This, CADescFormat enFormat, ref string bstr);
        public put_DescriptionDelegate put_Description;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_StartTime)(interface ICAOffer * This, DATE *pdtStart);
        public delegate int get_StartTimeDelegate(@interface ICAOffer This, DATE pdtStart);
        public get_StartTimeDelegate get_StartTime;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_EndTime)(interface ICAOffer * This, DATE *pdtEnd);
        public delegate int get_EndTimeDelegate(@interface ICAOffer This, DATE pdtEnd);
        public get_EndTimeDelegate get_EndTime;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Tolls)(interface ICAOffer * This, interface ICATolls **ppTolls);
        public delegate int get_TollsDelegate(@interface ICAOffer This, @interface ICATolls[] ppTolls);
        public get_TollsDelegate get_Tolls;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollStateChanged)(interface ICAOffer * This, interface ICAToll *pToll, CATollState enStateFrom);
        public delegate int NotifyTollStateChangedDelegate(@interface ICAOffer This, @interface ICAToll pToll, CATollState enStateFrom);
        public NotifyTollStateChangedDelegate NotifyTollStateChanged;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAComponentVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAComponent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAComponent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAComponent * This);
        public delegate uint AddRefDelegate(@interface ICAComponent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAComponent * This);
        public delegate uint ReleaseDelegate(@interface ICAComponent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAComponent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAComponent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAComponent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAComponent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAComponent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAComponent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAComponent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAComponent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Component)(interface ICAComponent * This, interface IComponent **ppComponent);
        public delegate int get_ComponentDelegate(@interface ICAComponent This, @interface IComponent[] ppComponent);
        public get_ComponentDelegate get_Component;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Denials)(interface ICAComponent * This, interface ICADenials **ppDenials);
        public delegate int get_DenialsDelegate(@interface ICAComponent This, @interface ICADenials[] ppDenials);
        public get_DenialsDelegate get_Denials;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Request)(interface ICAComponent * This, interface ICARequest **ppComponent);
        public delegate int get_RequestDelegate(@interface ICAComponent This, @interface ICARequest[] ppComponent);
        public get_RequestDelegate get_Request;

//        END_INTERFACE
    }

#else // C style interface

    public class ICAResDenialTreeVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICAResDenialTree * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICAResDenialTree This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICAResDenialTree * This);
        public delegate uint AddRefDelegate(@interface ICAResDenialTree This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICAResDenialTree * This);
        public delegate uint ReleaseDelegate(@interface ICAResDenialTree This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICAResDenialTree * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICAResDenialTree This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICAResDenialTree * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICAResDenialTree This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICAResDenialTree * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICAResDenialTree This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICAResDenialTree * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICAResDenialTree This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CAManager)(interface ICAResDenialTree * This, interface ICAManager **ppCAManager);
        public delegate int get_CAManagerDelegate(@interface ICAResDenialTree This, @interface ICAManager[] ppCAManager);
        public get_CAManagerDelegate get_CAManager;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CAManager)(interface ICAResDenialTree * This, interface ICAManager *pCAManager);
        public delegate int put_CAManagerDelegate(@interface ICAResDenialTree This, @interface ICAManager pCAManager);
        public put_CAManagerDelegate put_CAManager;

        /* [helpstring][id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DisplayFields)(interface ICAResDenialTree * This, int *penFields);
        public delegate int get_DisplayFieldsDelegate(@interface ICAResDenialTree This, ref int penFields);
        public get_DisplayFieldsDelegate get_DisplayFields;

        /* [helpstring][id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DisplayFields)(interface ICAResDenialTree * This, int enFields);
        public delegate int put_DisplayFieldsDelegate(@interface ICAResDenialTree This, int enFields);
        public put_DisplayFieldsDelegate put_DisplayFields;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UpdateView)(interface ICAResDenialTree * This, object* pUnk);
        public delegate int UpdateViewDelegate(@interface ICAResDenialTree This, object pUnk);
        public UpdateViewDelegate UpdateView;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestActivated)(interface ICAResDenialTree * This, interface ICARequest *preq);
        public delegate int NotifyRequestActivatedDelegate(@interface ICAResDenialTree This, @interface ICARequest preq);
        public NotifyRequestActivatedDelegate NotifyRequestActivated;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDeactivated)(interface ICAResDenialTree * This, interface ICARequest *preq);
        public delegate int NotifyRequestDeactivatedDelegate(@interface ICAResDenialTree This, @interface ICARequest preq);
        public NotifyRequestDeactivatedDelegate NotifyRequestDeactivated;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferAdded)(interface ICAResDenialTree * This, interface ICAOffer *pOffer, int cOffers);
        public delegate int NotifyOfferAddedDelegate(@interface ICAResDenialTree This, @interface ICAOffer pOffer, int cOffers);
        public NotifyOfferAddedDelegate NotifyOfferAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferRemoved)(interface ICAResDenialTree * This, interface ICAOffer *pOffer, int cOffers);
        public delegate int NotifyOfferRemovedDelegate(@interface ICAResDenialTree This, @interface ICAOffer pOffer, int cOffers);
        public NotifyOfferRemovedDelegate NotifyOfferRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyPolicyAdded)(interface ICAResDenialTree * This, interface ICAPolicy *pPolicy, int cPolicies);
        public delegate int NotifyPolicyAddedDelegate(@interface ICAResDenialTree This, @interface ICAPolicy pPolicy, int cPolicies);
        public NotifyPolicyAddedDelegate NotifyPolicyAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyPolicyRemoved)(interface ICAResDenialTree * This, interface ICAPolicy *pPolicy, int cPolicies);
        public delegate int NotifyPolicyRemovedDelegate(@interface ICAResDenialTree This, @interface ICAPolicy pPolicy, int cPolicies);
        public NotifyPolicyRemovedDelegate NotifyPolicyRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDenialAdded)(interface ICAResDenialTree * This, interface ICARequest *preq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyRequestDenialAddedDelegate(@interface ICAResDenialTree This, @interface ICARequest preq, @interface ICADenial pDenial, int cDenials);
        public NotifyRequestDenialAddedDelegate NotifyRequestDenialAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRequestDenialRemoved)(interface ICAResDenialTree * This, interface ICARequest *preq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyRequestDenialRemovedDelegate(@interface ICAResDenialTree This, @interface ICARequest preq, @interface ICADenial pDenial, int cDenials);
        public NotifyRequestDenialRemovedDelegate NotifyRequestDenialRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialTollAdded)(interface ICAResDenialTree * This, interface ICADenial *pDenial, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyDenialTollAddedDelegate(@interface ICAResDenialTree This, @interface ICADenial pDenial, @interface ICAToll pToll, int cTolls);
        public NotifyDenialTollAddedDelegate NotifyDenialTollAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialTollRemoved)(interface ICAResDenialTree * This, interface ICADenial *pDenial, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyDenialTollRemovedDelegate(@interface ICAResDenialTree This, @interface ICADenial pDenial, @interface ICAToll pToll, int cTolls);
        public NotifyDenialTollRemovedDelegate NotifyDenialTollRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollDenialAdded)(interface ICAResDenialTree * This, interface ICAToll *pToll, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyTollDenialAddedDelegate(@interface ICAResDenialTree This, @interface ICAToll pToll, @interface ICADenial pDenial, int cDenials);
        public NotifyTollDenialAddedDelegate NotifyTollDenialAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollDenialRemoved)(interface ICAResDenialTree * This, interface ICAToll *pToll, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyTollDenialRemovedDelegate(@interface ICAResDenialTree This, @interface ICAToll pToll, @interface ICADenial pDenial, int cDenials);
        public NotifyTollDenialRemovedDelegate NotifyTollDenialRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferTollAdded)(interface ICAResDenialTree * This, interface ICAOffer *pOffer, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyOfferTollAddedDelegate(@interface ICAResDenialTree This, @interface ICAOffer pOffer, @interface ICAToll pToll, int cTolls);
        public NotifyOfferTollAddedDelegate NotifyOfferTollAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOfferTollRemoved)(interface ICAResDenialTree * This, interface ICAOffer *pOffer, interface ICAToll *pToll, int cTolls);
        public delegate int NotifyOfferTollRemovedDelegate(@interface ICAResDenialTree This, @interface ICAOffer pOffer, @interface ICAToll pToll, int cTolls);
        public NotifyOfferTollRemovedDelegate NotifyOfferTollRemoved;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyTollStateChanged)(interface ICAResDenialTree * This, interface ICAToll *pToll, CATollState enStateLast);
        public delegate int NotifyTollStateChangedDelegate(@interface ICAResDenialTree This, @interface ICAToll pToll, CATollState enStateLast);
        public NotifyTollStateChangedDelegate NotifyTollStateChanged;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyDenialStateChanged)(interface ICAResDenialTree * This, interface ICADenial *pDenial, CADenialState enStateLast);
        public delegate int NotifyDenialStateChangedDelegate(@interface ICAResDenialTree This, @interface ICADenial pDenial, CADenialState enStateLast);
        public NotifyDenialStateChangedDelegate NotifyDenialStateChanged;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyComponentDenialAdded)(interface ICAResDenialTree * This, interface ICAComponent *preq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyComponentDenialAddedDelegate(@interface ICAResDenialTree This, @interface ICAComponent preq, @interface ICADenial pDenial, int cDenials);
        public NotifyComponentDenialAddedDelegate NotifyComponentDenialAdded;

        /* [helpstring][id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyComponentDenialRemoved)(interface ICAResDenialTree * This, interface ICAComponent *preq, interface ICADenial *pDenial, int cDenials);
        public delegate int NotifyComponentDenialRemovedDelegate(@interface ICAResDenialTree This, @interface ICAComponent preq, @interface ICADenial pDenial, int cDenials);
        public NotifyComponentDenialRemovedDelegate NotifyComponentDenialRemoved;

//        END_INTERFACE
    }

#else // C style interface

    public class _ICADefaultDlgEventsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface _ICADefaultDlgEvents * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface _ICADefaultDlgEvents This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface _ICADefaultDlgEvents * This);
        public delegate uint AddRefDelegate(@interface _ICADefaultDlgEvents This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface _ICADefaultDlgEvents * This);
        public delegate uint ReleaseDelegate(@interface _ICADefaultDlgEvents This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface _ICADefaultDlgEvents * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface _ICADefaultDlgEvents This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface _ICADefaultDlgEvents * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface _ICADefaultDlgEvents This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface _ICADefaultDlgEvents * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface _ICADefaultDlgEvents This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface _ICADefaultDlgEvents * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface _ICADefaultDlgEvents This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

//        END_INTERFACE
    }