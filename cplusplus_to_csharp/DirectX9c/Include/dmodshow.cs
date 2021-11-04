// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for dmodshow.idl:
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
// #include "unknwn.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "objidl.h"
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

#if __cplusplus
#endif

#else // C style interface

    public class IDMOWrapperFilterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDMOWrapperFilter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDMOWrapperFilter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDMOWrapperFilter * This);
        public delegate uint AddRefDelegate(@interface IDMOWrapperFilter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDMOWrapperFilter * This);
        public delegate uint ReleaseDelegate(@interface IDMOWrapperFilter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Init)(interface IDMOWrapperFilter * This, REFCLSID clsidDMO, REFCLSID catDMO);
        public delegate int InitDelegate(@interface IDMOWrapperFilter This, REFCLSID clsidDMO, REFCLSID catDMO);
        public InitDelegate Init;

//        END_INTERFACE
    }