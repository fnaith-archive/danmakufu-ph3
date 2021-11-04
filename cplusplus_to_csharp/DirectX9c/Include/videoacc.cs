// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for videoacc.idl:
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

#if __cplusplus
#endif

#else // C style interface

    public class IAMVideoAcceleratorNotifyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVideoAcceleratorNotify * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVideoAcceleratorNotify This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVideoAcceleratorNotify * This);
        public delegate uint AddRefDelegate(@interface IAMVideoAcceleratorNotify This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVideoAcceleratorNotify * This);
        public delegate uint ReleaseDelegate(@interface IAMVideoAcceleratorNotify This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetUncompSurfacesInfo)(interface IAMVideoAcceleratorNotify * This, const GUID *pGuid, LPAMVAUncompBufferInfo pUncompBufferInfo);
        public delegate int GetUncompSurfacesInfoDelegate(@interface IAMVideoAcceleratorNotify This, GUID pGuid, LPAMVAUncompBufferInfo pUncompBufferInfo);
        public GetUncompSurfacesInfoDelegate GetUncompSurfacesInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetUncompSurfacesInfo)(interface IAMVideoAcceleratorNotify * This, uint dwActualUncompSurfacesAllocated);
        public delegate int SetUncompSurfacesInfoDelegate(@interface IAMVideoAcceleratorNotify This, uint dwActualUncompSurfacesAllocated);
        public SetUncompSurfacesInfoDelegate SetUncompSurfacesInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCreateVideoAcceleratorData)(interface IAMVideoAcceleratorNotify * This, const GUID *pGuid, uint * pdwSizeMiscData, object**ppMiscData);
        public delegate int GetCreateVideoAcceleratorDataDelegate(@interface IAMVideoAcceleratorNotify This, GUID pGuid, ref uint pdwSizeMiscData, object ppMiscData[] UnnamedParameter);
        public GetCreateVideoAcceleratorDataDelegate GetCreateVideoAcceleratorData;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMVideoAcceleratorVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVideoAccelerator * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVideoAccelerator This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVideoAccelerator * This);
        public delegate uint AddRefDelegate(@interface IAMVideoAccelerator This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVideoAccelerator * This);
        public delegate uint ReleaseDelegate(@interface IAMVideoAccelerator This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoAcceleratorGUIDs)(interface IAMVideoAccelerator * This, uint * pdwNumGuidsSupported, LPGUID pGuidsSupported);
        public delegate int GetVideoAcceleratorGUIDsDelegate(@interface IAMVideoAccelerator This, ref uint pdwNumGuidsSupported, LPGUID pGuidsSupported);
        public GetVideoAcceleratorGUIDsDelegate GetVideoAcceleratorGUIDs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetUncompFormatsSupported)(interface IAMVideoAccelerator * This, const GUID *pGuid, uint * pdwNumFormatsSupported, LPDDPIXELFORMAT pFormatsSupported);
        public delegate int GetUncompFormatsSupportedDelegate(@interface IAMVideoAccelerator This, GUID pGuid, ref uint pdwNumFormatsSupported, LPDDPIXELFORMAT pFormatsSupported);
        public GetUncompFormatsSupportedDelegate GetUncompFormatsSupported;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInternalMemInfo)(interface IAMVideoAccelerator * This, const GUID *pGuid, const AMVAUncompDataInfo *pamvaUncompDataInfo, LPAMVAInternalMemInfo pamvaInternalMemInfo);
        public delegate int GetInternalMemInfoDelegate(@interface IAMVideoAccelerator This, GUID pGuid, AMVAUncompDataInfo pamvaUncompDataInfo, LPAMVAInternalMemInfo pamvaInternalMemInfo);
        public GetInternalMemInfoDelegate GetInternalMemInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCompBufferInfo)(interface IAMVideoAccelerator * This, const GUID *pGuid, const AMVAUncompDataInfo *pamvaUncompDataInfo, uint * pdwNumTypesCompBuffers, LPAMVACompBufferInfo pamvaCompBufferInfo);
        public delegate int GetCompBufferInfoDelegate(@interface IAMVideoAccelerator This, GUID pGuid, AMVAUncompDataInfo pamvaUncompDataInfo, ref uint pdwNumTypesCompBuffers, LPAMVACompBufferInfo pamvaCompBufferInfo);
        public GetCompBufferInfoDelegate GetCompBufferInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInternalCompBufferInfo)(interface IAMVideoAccelerator * This, uint * pdwNumTypesCompBuffers, LPAMVACompBufferInfo pamvaCompBufferInfo);
        public delegate int GetInternalCompBufferInfoDelegate(@interface IAMVideoAccelerator This, ref uint pdwNumTypesCompBuffers, LPAMVACompBufferInfo pamvaCompBufferInfo);
        public GetInternalCompBufferInfoDelegate GetInternalCompBufferInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *BeginFrame)(interface IAMVideoAccelerator * This, const AMVABeginFrameInfo *amvaBeginFrameInfo);
        public delegate int BeginFrameDelegate(@interface IAMVideoAccelerator This, AMVABeginFrameInfo amvaBeginFrameInfo);
        public BeginFrameDelegate BeginFrame;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndFrame)(interface IAMVideoAccelerator * This, const AMVAEndFrameInfo *pEndFrameInfo);
        public delegate int EndFrameDelegate(@interface IAMVideoAccelerator This, AMVAEndFrameInfo pEndFrameInfo);
        public EndFrameDelegate EndFrame;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBuffer)(interface IAMVideoAccelerator * This, uint dwTypeIndex, uint dwBufferIndex, bool bReadOnly, object**ppBuffer, int *lpStride);
        public delegate int GetBufferDelegate(@interface IAMVideoAccelerator This, uint dwTypeIndex, uint dwBufferIndex, bool bReadOnly, object ppBuffer[] UnnamedParameter, ref int lpStride);
        public GetBufferDelegate GetBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReleaseBuffer)(interface IAMVideoAccelerator * This, uint dwTypeIndex, uint dwBufferIndex);
        public delegate int ReleaseBufferDelegate(@interface IAMVideoAccelerator This, uint dwTypeIndex, uint dwBufferIndex);
        public ReleaseBufferDelegate ReleaseBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Execute)(interface IAMVideoAccelerator * This, uint dwFunction, object* lpPrivateInputData, uint cbPrivateInputData, object* lpPrivateOutputDat, uint cbPrivateOutputData, uint dwNumBuffers, const AMVABUFFERINFO *pamvaBufferInfo);
        public delegate int ExecuteDelegate(@interface IAMVideoAccelerator This, uint dwFunction, object lpPrivateInputData, uint cbPrivateInputData, object lpPrivateOutputDat, uint cbPrivateOutputData, uint dwNumBuffers, AMVABUFFERINFO pamvaBufferInfo);
        public ExecuteDelegate Execute;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryRenderStatus)(interface IAMVideoAccelerator * This, uint dwTypeIndex, uint dwBufferIndex, uint dwFlags);
        public delegate int QueryRenderStatusDelegate(@interface IAMVideoAccelerator This, uint dwTypeIndex, uint dwBufferIndex, uint dwFlags);
        public QueryRenderStatusDelegate QueryRenderStatus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DisplayFrame)(interface IAMVideoAccelerator * This, uint dwFlipToIndex, IMediaSample *pMediaSample);
        public delegate int DisplayFrameDelegate(@interface IAMVideoAccelerator This, uint dwFlipToIndex, IMediaSample pMediaSample);
        public DisplayFrameDelegate DisplayFrame;

//        END_INTERFACE
    }