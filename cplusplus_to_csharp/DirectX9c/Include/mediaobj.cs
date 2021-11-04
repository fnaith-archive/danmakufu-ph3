// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for mediaobj.idl:
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

#if __cplusplus
#endif

/* interface __MIDL_itf_mediaobj_0000 */
/* [local] */ 

#if __strmif_h__
#else
public class _DMOMediaType
{
    public GUID majortype = new GUID();
    public GUID subtype = new GUID();
    public bool bFixedSizeSamples;
    public bool bTemporalCompression;
    public uint lSampleSize;
    public GUID formattype = new GUID();
    public IUnknown pUnk;
    public uint cbFormat;
    /* [size_is] */
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pbFormat;
    public byte pbFormat;
}


#endif

public enum _DMO_INPUT_DATA_BUFFER_FLAGS
{
        DMO_INPUT_DATA_BUFFERF_SYNCPOINT = 0x1,
    DMO_INPUT_DATA_BUFFERF_TIME = 0x2,
    DMO_INPUT_DATA_BUFFERF_TIMELENGTH = 0x4
}

public enum _DMO_OUTPUT_DATA_BUFFER_FLAGS
{
        DMO_OUTPUT_DATA_BUFFERF_SYNCPOINT = 0x1,
    DMO_OUTPUT_DATA_BUFFERF_TIME = 0x2,
    DMO_OUTPUT_DATA_BUFFERF_TIMELENGTH = 0x4,
    DMO_OUTPUT_DATA_BUFFERF_INCOMPLETE = 0x1000000
}

public enum _DMO_INPUT_STATUS_FLAGS
{
        DMO_INPUT_STATUSF_ACCEPT_DATA = 0x1
}

public enum _DMO_INPUT_STREAM_INFO_FLAGS
{
        DMO_INPUT_STREAMF_WHOLE_SAMPLES = 0x1,
    DMO_INPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 0x2,
    DMO_INPUT_STREAMF_FIXED_SAMPLE_SIZE = 0x4,
    DMO_INPUT_STREAMF_HOLDS_BUFFERS = 0x8
}

public enum _DMO_OUTPUT_STREAM_INFO_FLAGS
{
        DMO_OUTPUT_STREAMF_WHOLE_SAMPLES = 0x1,
    DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 0x2,
    DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE = 0x4,
    DMO_OUTPUT_STREAMF_DISCARDABLE = 0x8,
    DMO_OUTPUT_STREAMF_OPTIONAL = 0x10
}

public enum _DMO_SET_TYPE_FLAGS
{
        DMO_SET_TYPEF_TEST_ONLY = 0x1,
    DMO_SET_TYPEF_CLEAR = 0x2
}

public enum _DMO_PROCESS_OUTPUT_FLAGS
{
        DMO_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER = 0x1
}

#else // C style interface

    public class IMediaBufferVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaBuffer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaBuffer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaBuffer * This);
        public delegate uint AddRefDelegate(@interface IMediaBuffer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaBuffer * This);
        public delegate uint ReleaseDelegate(@interface IMediaBuffer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetLength)(interface IMediaBuffer * This, uint cbLength);
        public delegate int SetLengthDelegate(@interface IMediaBuffer This, uint cbLength);
        public SetLengthDelegate SetLength;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMaxLength)(interface IMediaBuffer * This, uint *pcbMaxLength);
        public delegate int GetMaxLengthDelegate(@interface IMediaBuffer This, ref uint pcbMaxLength);
        public GetMaxLengthDelegate GetMaxLength;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBufferAndLength)(interface IMediaBuffer * This, byte **ppBuffer, uint *pcbLength);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetBufferAndLengthDelegate(@interface IMediaBuffer This, byte[] ppBuffer, ref uint pcbLength);
        public GetBufferAndLengthDelegate GetBufferAndLength;

//        END_INTERFACE
    }





/* interface __MIDL_itf_mediaobj_0090 */
/* [local] */ 

public class _DMO_OUTPUT_DATA_BUFFER
{
    public @interface IMediaBuffer * pBuffer = new @interface();
    public uint dwStatus;
    public long rtTimestamp;
    public long rtTimelength;
}

#else // C style interface

    public class IMediaObjectVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaObject * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaObject This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaObject * This);
        public delegate uint AddRefDelegate(@interface IMediaObject This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaObject * This);
        public delegate uint ReleaseDelegate(@interface IMediaObject This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStreamCount)(interface IMediaObject * This, uint *pcInputStreams, uint *pcOutputStreams);
        public delegate int GetStreamCountDelegate(@interface IMediaObject This, ref uint pcInputStreams, ref uint pcOutputStreams);
        public GetStreamCountDelegate GetStreamCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInputStreamInfo)(interface IMediaObject * This, uint dwInputStreamIndex, uint *pdwFlags);
        public delegate int GetInputStreamInfoDelegate(@interface IMediaObject This, uint dwInputStreamIndex, ref uint pdwFlags);
        public GetInputStreamInfoDelegate GetInputStreamInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputStreamInfo)(interface IMediaObject * This, uint dwOutputStreamIndex, uint *pdwFlags);
        public delegate int GetOutputStreamInfoDelegate(@interface IMediaObject This, uint dwOutputStreamIndex, ref uint pdwFlags);
        public GetOutputStreamInfoDelegate GetOutputStreamInfo;

// C++ TO C# CONVERTER TODO TASK: The typedef 'DMO_MEDIA_TYPE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInputType)(interface IMediaObject * This, uint dwInputStreamIndex, uint dwTypeIndex, DMO_MEDIA_TYPE *pmt);
        public delegate int GetInputTypeDelegate(@interface IMediaObject This, uint dwInputStreamIndex, uint dwTypeIndex, DMO_MEDIA_TYPE pmt);
        public GetInputTypeDelegate GetInputType;

// C++ TO C# CONVERTER TODO TASK: The typedef 'DMO_MEDIA_TYPE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputType)(interface IMediaObject * This, uint dwOutputStreamIndex, uint dwTypeIndex, DMO_MEDIA_TYPE *pmt);
        public delegate int GetOutputTypeDelegate(@interface IMediaObject This, uint dwOutputStreamIndex, uint dwTypeIndex, DMO_MEDIA_TYPE pmt);
        public GetOutputTypeDelegate GetOutputType;

// C++ TO C# CONVERTER TODO TASK: The typedef 'DMO_MEDIA_TYPE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetInputType)(interface IMediaObject * This, uint dwInputStreamIndex, const DMO_MEDIA_TYPE *pmt, uint dwFlags);
        public delegate int SetInputTypeDelegate(@interface IMediaObject This, uint dwInputStreamIndex, DMO_MEDIA_TYPE pmt, uint dwFlags);
        public SetInputTypeDelegate SetInputType;

// C++ TO C# CONVERTER TODO TASK: The typedef 'DMO_MEDIA_TYPE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputType)(interface IMediaObject * This, uint dwOutputStreamIndex, const DMO_MEDIA_TYPE *pmt, uint dwFlags);
        public delegate int SetOutputTypeDelegate(@interface IMediaObject This, uint dwOutputStreamIndex, DMO_MEDIA_TYPE pmt, uint dwFlags);
        public SetOutputTypeDelegate SetOutputType;

// C++ TO C# CONVERTER TODO TASK: The typedef 'DMO_MEDIA_TYPE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInputCurrentType)(interface IMediaObject * This, uint dwInputStreamIndex, DMO_MEDIA_TYPE *pmt);
        public delegate int GetInputCurrentTypeDelegate(@interface IMediaObject This, uint dwInputStreamIndex, DMO_MEDIA_TYPE pmt);
        public GetInputCurrentTypeDelegate GetInputCurrentType;

// C++ TO C# CONVERTER TODO TASK: The typedef 'DMO_MEDIA_TYPE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputCurrentType)(interface IMediaObject * This, uint dwOutputStreamIndex, DMO_MEDIA_TYPE *pmt);
        public delegate int GetOutputCurrentTypeDelegate(@interface IMediaObject This, uint dwOutputStreamIndex, DMO_MEDIA_TYPE pmt);
        public GetOutputCurrentTypeDelegate GetOutputCurrentType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInputSizeInfo)(interface IMediaObject * This, uint dwInputStreamIndex, uint *pcbSize, uint *pcbMaxLookahead, uint *pcbAlignment);
        public delegate int GetInputSizeInfoDelegate(@interface IMediaObject This, uint dwInputStreamIndex, ref uint pcbSize, ref uint pcbMaxLookahead, ref uint pcbAlignment);
        public GetInputSizeInfoDelegate GetInputSizeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputSizeInfo)(interface IMediaObject * This, uint dwOutputStreamIndex, uint *pcbSize, uint *pcbAlignment);
        public delegate int GetOutputSizeInfoDelegate(@interface IMediaObject This, uint dwOutputStreamIndex, ref uint pcbSize, ref uint pcbAlignment);
        public GetOutputSizeInfoDelegate GetOutputSizeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInputMaxLatency)(interface IMediaObject * This, uint dwInputStreamIndex, long *prtMaxLatency);
        public delegate int GetInputMaxLatencyDelegate(@interface IMediaObject This, uint dwInputStreamIndex, ref long prtMaxLatency);
        public GetInputMaxLatencyDelegate GetInputMaxLatency;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetInputMaxLatency)(interface IMediaObject * This, uint dwInputStreamIndex, long rtMaxLatency);
        public delegate int SetInputMaxLatencyDelegate(@interface IMediaObject This, uint dwInputStreamIndex, long rtMaxLatency);
        public SetInputMaxLatencyDelegate SetInputMaxLatency;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Flush)(interface IMediaObject * This);
        public delegate int FlushDelegate(@interface IMediaObject This);
        public FlushDelegate Flush;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Discontinuity)(interface IMediaObject * This, uint dwInputStreamIndex);
        public delegate int DiscontinuityDelegate(@interface IMediaObject This, uint dwInputStreamIndex);
        public DiscontinuityDelegate Discontinuity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocateStreamingResources)(interface IMediaObject * This);
        public delegate int AllocateStreamingResourcesDelegate(@interface IMediaObject This);
        public AllocateStreamingResourcesDelegate AllocateStreamingResources;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FreeStreamingResources)(interface IMediaObject * This);
        public delegate int FreeStreamingResourcesDelegate(@interface IMediaObject This);
        public FreeStreamingResourcesDelegate FreeStreamingResources;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInputStatus)(interface IMediaObject * This, uint dwInputStreamIndex, uint *dwFlags);
        public delegate int GetInputStatusDelegate(@interface IMediaObject This, uint dwInputStreamIndex, ref uint dwFlags);
        public GetInputStatusDelegate GetInputStatus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ProcessInput)(interface IMediaObject * This, uint dwInputStreamIndex, interface IMediaBuffer *pBuffer, uint dwFlags, long rtTimestamp, long rtTimelength);
        public delegate int ProcessInputDelegate(@interface IMediaObject This, uint dwInputStreamIndex, @interface IMediaBuffer pBuffer, uint dwFlags, long rtTimestamp, long rtTimelength);
        public ProcessInputDelegate ProcessInput;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ProcessOutput)(interface IMediaObject * This, uint dwFlags, uint cOutputBufferCount, _DMO_OUTPUT_DATA_BUFFER *pOutputBuffers, uint *pdwStatus);
        public delegate int ProcessOutputDelegate(@interface IMediaObject This, uint dwFlags, uint cOutputBufferCount, _DMO_OUTPUT_DATA_BUFFER pOutputBuffers, ref uint pdwStatus);
        public ProcessOutputDelegate ProcessOutput;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Lock)(interface IMediaObject * This, int bLock);
        public delegate int LockDelegate(@interface IMediaObject This, int bLock);
        public LockDelegate Lock;

//        END_INTERFACE
    }

#else // C style interface

    public class IEnumDMOVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumDMO * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumDMO This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumDMO * This);
        public delegate uint AddRefDelegate(@interface IEnumDMO This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumDMO * This);
        public delegate uint ReleaseDelegate(@interface IEnumDMO This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumDMO * This, uint cItemsToFetch, CLSID *pCLSID, char **Names, uint *pcItemsFetched);
        public delegate int NextDelegate(@interface IEnumDMO This, uint cItemsToFetch, CLSID pCLSID, string[] Names, ref uint pcItemsFetched);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumDMO * This, uint cItemsToSkip);
        public delegate int SkipDelegate(@interface IEnumDMO This, uint cItemsToSkip);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumDMO * This);
        public delegate int ResetDelegate(@interface IEnumDMO This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumDMO * This, interface IEnumDMO **ppEnum);
        public delegate int CloneDelegate(@interface IEnumDMO This, @interface IEnumDMO[] ppEnum);
        public CloneDelegate Clone;

//        END_INTERFACE
    }





/* interface __MIDL_itf_mediaobj_0092 */
/* [local] */ 


public enum _DMO_INPLACE_PROCESS_FLAGS
{
        DMO_INPLACE_NORMAL = 0,
    DMO_INPLACE_ZERO = 0x1
}

#else // C style interface

    public class IMediaObjectInPlaceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaObjectInPlace * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaObjectInPlace This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaObjectInPlace * This);
        public delegate uint AddRefDelegate(@interface IMediaObjectInPlace This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaObjectInPlace * This);
        public delegate uint ReleaseDelegate(@interface IMediaObjectInPlace This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Process)(interface IMediaObjectInPlace * This, uint ulSize, byte *pData, long refTimeStart, uint dwFlags);
        public delegate int ProcessDelegate(@interface IMediaObjectInPlace This, uint ulSize, ref byte pData, long refTimeStart, uint dwFlags);
        public ProcessDelegate Process;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IMediaObjectInPlace * This, interface IMediaObjectInPlace **ppMediaObject);
        public delegate int CloneDelegate(@interface IMediaObjectInPlace This, @interface IMediaObjectInPlace[] ppMediaObject);
        public CloneDelegate Clone;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetLatency)(interface IMediaObjectInPlace * This, long *pLatencyTime);
        public delegate int GetLatencyDelegate(@interface IMediaObjectInPlace This, ref long pLatencyTime);
        public GetLatencyDelegate GetLatency;

//        END_INTERFACE
    }





/* interface __MIDL_itf_mediaobj_0093 */
/* [local] */ 


public enum _DMO_QUALITY_STATUS_FLAGS
{
        DMO_QUALITY_STATUS_ENABLED = 0x1
}

#else // C style interface

    public class IDMOQualityControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDMOQualityControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDMOQualityControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDMOQualityControl * This);
        public delegate uint AddRefDelegate(@interface IDMOQualityControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDMOQualityControl * This);
        public delegate uint ReleaseDelegate(@interface IDMOQualityControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetNow)(interface IDMOQualityControl * This, long rtNow);
        public delegate int SetNowDelegate(@interface IDMOQualityControl This, long rtNow);
        public SetNowDelegate SetNow;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStatus)(interface IDMOQualityControl * This, uint dwFlags);
        public delegate int SetStatusDelegate(@interface IDMOQualityControl This, uint dwFlags);
        public SetStatusDelegate SetStatus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStatus)(interface IDMOQualityControl * This, uint *pdwFlags);
        public delegate int GetStatusDelegate(@interface IDMOQualityControl This, ref uint pdwFlags);
        public GetStatusDelegate GetStatus;

//        END_INTERFACE
    }





/* interface __MIDL_itf_mediaobj_0094 */
/* [local] */ 


public enum _DMO_VIDEO_OUTPUT_STREAM_FLAGS
{
        DMO_VOSF_NEEDS_PREVIOUS_SAMPLE = 0x1
}

#else // C style interface

    public class IDMOVideoOutputOptimizationsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDMOVideoOutputOptimizations * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDMOVideoOutputOptimizations This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDMOVideoOutputOptimizations * This);
        public delegate uint AddRefDelegate(@interface IDMOVideoOutputOptimizations This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDMOVideoOutputOptimizations * This);
        public delegate uint ReleaseDelegate(@interface IDMOVideoOutputOptimizations This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryOperationModePreferences)(interface IDMOVideoOutputOptimizations * This, uint ulOutputStreamIndex, uint *pdwRequestedCapabilities);
        public delegate int QueryOperationModePreferencesDelegate(@interface IDMOVideoOutputOptimizations This, uint ulOutputStreamIndex, ref uint pdwRequestedCapabilities);
        public QueryOperationModePreferencesDelegate QueryOperationModePreferences;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOperationMode)(interface IDMOVideoOutputOptimizations * This, uint ulOutputStreamIndex, uint dwEnabledFeatures);
        public delegate int SetOperationModeDelegate(@interface IDMOVideoOutputOptimizations This, uint ulOutputStreamIndex, uint dwEnabledFeatures);
        public SetOperationModeDelegate SetOperationMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentOperationMode)(interface IDMOVideoOutputOptimizations * This, uint ulOutputStreamIndex, uint *pdwEnabledFeatures);
        public delegate int GetCurrentOperationModeDelegate(@interface IDMOVideoOutputOptimizations This, uint ulOutputStreamIndex, ref uint pdwEnabledFeatures);
        public GetCurrentOperationModeDelegate GetCurrentOperationMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentSampleRequirements)(interface IDMOVideoOutputOptimizations * This, uint ulOutputStreamIndex, uint *pdwRequestedFeatures);
        public delegate int GetCurrentSampleRequirementsDelegate(@interface IDMOVideoOutputOptimizations This, uint ulOutputStreamIndex, ref uint pdwRequestedFeatures);
        public GetCurrentSampleRequirementsDelegate GetCurrentSampleRequirements;

//        END_INTERFACE
    }