using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for austream.idl:
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
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_ERROR_CODE(x) MAKE_HRESULT(1, FACILITY_ITF, (x) + 0x400)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_SUCCESS_CODE(x) MAKE_HRESULT(0, FACILITY_ITF, x)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_S_PENDING MS_SUCCESS_CODE(1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_S_NOUPDATE MS_SUCCESS_CODE(2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_S_ENDOFSTREAM MS_SUCCESS_CODE(3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_SAMPLEALLOC MS_ERROR_CODE(1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_PURPOSEID MS_ERROR_CODE(2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_NOSTREAM MS_ERROR_CODE(3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_NOSEEKING MS_ERROR_CODE(4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_INCOMPATIBLE MS_ERROR_CODE(5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_BUSY MS_ERROR_CODE(6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_NOTINIT MS_ERROR_CODE(7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_SOURCEALREADYDEFINED MS_ERROR_CODE(8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_INVALIDSTREAMTYPE MS_ERROR_CODE(9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MS_E_NOTRUNNING MS_ERROR_CODE(10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_GetInformation(This,pdwFlags,pStreamType) (This)->lpVtbl -> GetInformation(This,pdwFlags,pStreamType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_GetMediaStream(This,idPurpose,ppMediaStream) (This)->lpVtbl -> GetMediaStream(This,idPurpose,ppMediaStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_EnumMediaStreams(This,Index,ppMediaStream) (This)->lpVtbl -> EnumMediaStreams(This,Index,ppMediaStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_GetState(This,pCurrentState) (This)->lpVtbl -> GetState(This,pCurrentState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_SetState(This,NewState) (This)->lpVtbl -> SetState(This,NewState)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_GetTime(This,pCurrentTime) (This)->lpVtbl -> GetTime(This,pCurrentTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_GetDuration(This,pDuration) (This)->lpVtbl -> GetDuration(This,pDuration)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_Seek(This,SeekTime) (This)->lpVtbl -> Seek(This,SeekTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMultiMediaStream_GetEndOfStreamEventHandle(This,phEOS) (This)->lpVtbl -> GetEndOfStreamEventHandle(This,phEOS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_GetMultiMediaStream(This,ppMultiMediaStream) (This)->lpVtbl -> GetMultiMediaStream(This,ppMultiMediaStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_GetInformation(This,pPurposeId,pType) (This)->lpVtbl -> GetInformation(This,pPurposeId,pType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_SetSameFormat(This,pStreamThatHasDesiredFormat,dwFlags) (This)->lpVtbl -> SetSameFormat(This,pStreamThatHasDesiredFormat,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_AllocateSample(This,dwFlags,ppSample) (This)->lpVtbl -> AllocateSample(This,dwFlags,ppSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_CreateSharedSample(This,pExistingSample,dwFlags,ppNewSample) (This)->lpVtbl -> CreateSharedSample(This,pExistingSample,dwFlags,ppNewSample)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IMediaStream_SendEndOfStream(This,dwFlags) (This)->lpVtbl -> SendEndOfStream(This,dwFlags)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_QueryInterface(This,riid,ppvObject) (This)->lpVtbl -> QueryInterface(This,riid,ppvObject)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_AddRef(This) (This)->lpVtbl -> AddRef(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_Release(This) (This)->lpVtbl -> Release(This)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_GetMediaStream(This,ppMediaStream) (This)->lpVtbl -> GetMediaStream(This,ppMediaStream)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_GetSampleTimes(This,pStartTime,pEndTime,pCurrentTime) (This)->lpVtbl -> GetSampleTimes(This,pStartTime,pEndTime,pCurrentTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_SetSampleTimes(This,pStartTime,pEndTime) (This)->lpVtbl -> SetSampleTimes(This,pStartTime,pEndTime)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_Update(This,dwFlags,hEvent,pfnAPC,dwAPCData) (This)->lpVtbl -> Update(This,dwFlags,hEvent,pfnAPC,dwAPCData)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IStreamSample_CompletionStatus(This,dwFlags,dwMilliseconds) (This)->lpVtbl -> CompletionStatus(This,dwFlags,dwMilliseconds)

#if __cplusplus
#endif

#else // C style interface

    public class IAudioMediaStreamVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAudioMediaStream * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAudioMediaStream This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAudioMediaStream * This);
        public delegate uint AddRefDelegate(@interface IAudioMediaStream This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAudioMediaStream * This);
        public delegate uint ReleaseDelegate(@interface IAudioMediaStream This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMultiMediaStream)(interface IAudioMediaStream * This, interface IMultiMediaStream **ppMultiMediaStream);
        public delegate int GetMultiMediaStreamDelegate(@interface IAudioMediaStream This, @interface IMultiMediaStream[] ppMultiMediaStream);
        public GetMultiMediaStreamDelegate GetMultiMediaStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInformation)(interface IAudioMediaStream * This, MSPID *pPurposeId, STREAM_TYPE *pType);
        public delegate int GetInformationDelegate(@interface IAudioMediaStream This, MSPID pPurposeId, STREAM_TYPE pType);
        public GetInformationDelegate GetInformation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSameFormat)(interface IAudioMediaStream * This, interface IMediaStream *pStreamThatHasDesiredFormat, uint dwFlags);
        public delegate int SetSameFormatDelegate(@interface IAudioMediaStream This, @interface IMediaStream pStreamThatHasDesiredFormat, uint dwFlags);
        public SetSameFormatDelegate SetSameFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocateSample)(interface IAudioMediaStream * This, uint dwFlags, interface IStreamSample **ppSample);
        public delegate int AllocateSampleDelegate(@interface IAudioMediaStream This, uint dwFlags, @interface IStreamSample[] ppSample);
        public AllocateSampleDelegate AllocateSample;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateSharedSample)(interface IAudioMediaStream * This, interface IStreamSample *pExistingSample, uint dwFlags, interface IStreamSample **ppNewSample);
        public delegate int CreateSharedSampleDelegate(@interface IAudioMediaStream This, @interface IStreamSample pExistingSample, uint dwFlags, @interface IStreamSample[] ppNewSample);
        public CreateSharedSampleDelegate CreateSharedSample;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SendEndOfStream)(interface IAudioMediaStream * This, uint dwFlags);
        public delegate int SendEndOfStreamDelegate(@interface IAudioMediaStream This, uint dwFlags);
        public SendEndOfStreamDelegate SendEndOfStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFormat)(interface IAudioMediaStream * This, WAVEFORMATEX *pWaveFormatCurrent);
        public delegate int GetFormatDelegate(@interface IAudioMediaStream This, WAVEFORMATEX pWaveFormatCurrent);
        public GetFormatDelegate GetFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFormat)(interface IAudioMediaStream * This, const WAVEFORMATEX *lpWaveFormat);
        public delegate int SetFormatDelegate(@interface IAudioMediaStream This, WAVEFORMATEX lpWaveFormat);
        public SetFormatDelegate SetFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateSample)(interface IAudioMediaStream * This, interface IAudioData *pAudioData, uint dwFlags, interface IAudioStreamSample **ppSample);
        public delegate int CreateSampleDelegate(@interface IAudioMediaStream This, @interface IAudioData pAudioData, uint dwFlags, @interface IAudioStreamSample[] ppSample);
        public CreateSampleDelegate CreateSample;

//        END_INTERFACE
    }

#else // C style interface

    public class IAudioStreamSampleVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAudioStreamSample * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAudioStreamSample This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAudioStreamSample * This);
        public delegate uint AddRefDelegate(@interface IAudioStreamSample This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAudioStreamSample * This);
        public delegate uint ReleaseDelegate(@interface IAudioStreamSample This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaStream)(interface IAudioStreamSample * This, interface IMediaStream **ppMediaStream);
        public delegate int GetMediaStreamDelegate(@interface IAudioStreamSample This, @interface IMediaStream[] ppMediaStream);
        public GetMediaStreamDelegate GetMediaStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSampleTimes)(interface IAudioStreamSample * This, STREAM_TIME *pStartTime, STREAM_TIME *pEndTime, STREAM_TIME *pCurrentTime);
        public delegate int GetSampleTimesDelegate(@interface IAudioStreamSample This, STREAM_TIME pStartTime, STREAM_TIME pEndTime, STREAM_TIME pCurrentTime);
        public GetSampleTimesDelegate GetSampleTimes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSampleTimes)(interface IAudioStreamSample * This, const STREAM_TIME *pStartTime, const STREAM_TIME *pEndTime);
        public delegate int SetSampleTimesDelegate(@interface IAudioStreamSample This, STREAM_TIME pStartTime, STREAM_TIME pEndTime);
        public SetSampleTimesDelegate SetSampleTimes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Update)(interface IAudioStreamSample * This, uint dwFlags, System.IntPtr hEvent, PAPCFUNC pfnAPC, System.IntPtr dwAPCData);
        public delegate int UpdateDelegate(@interface IAudioStreamSample This, uint dwFlags, IntPtr hEvent, PAPCFUNC pfnAPC, IntPtr dwAPCData);
        public UpdateDelegate Update;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CompletionStatus)(interface IAudioStreamSample * This, uint dwFlags, uint dwMilliseconds);
        public delegate int CompletionStatusDelegate(@interface IAudioStreamSample This, uint dwFlags, uint dwMilliseconds);
        public CompletionStatusDelegate CompletionStatus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAudioData)(interface IAudioStreamSample * This, interface IAudioData **ppAudio);
        public delegate int GetAudioDataDelegate(@interface IAudioStreamSample This, @interface IAudioData[] ppAudio);
        public GetAudioDataDelegate GetAudioData;

//        END_INTERFACE
    }

#else // C style interface

    public class IMemoryDataVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMemoryData * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMemoryData This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMemoryData * This);
        public delegate uint AddRefDelegate(@interface IMemoryData This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMemoryData * This);
        public delegate uint ReleaseDelegate(@interface IMemoryData This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBuffer)(interface IMemoryData * This, uint cbSize, byte *pbData, uint dwFlags);
        public delegate int SetBufferDelegate(@interface IMemoryData This, uint cbSize, ref byte pbData, uint dwFlags);
        public SetBufferDelegate SetBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInfo)(interface IMemoryData * This, uint *pdwLength, byte **ppbData, uint *pcbActualData);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetInfoDelegate(@interface IMemoryData This, ref uint pdwLength, byte[] ppbData, ref uint pcbActualData);
        public GetInfoDelegate GetInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetActual)(interface IMemoryData * This, uint cbDataValid);
        public delegate int SetActualDelegate(@interface IMemoryData This, uint cbDataValid);
        public SetActualDelegate SetActual;

//        END_INTERFACE
    }

#else // C style interface

    public class IAudioDataVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAudioData * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAudioData This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAudioData * This);
        public delegate uint AddRefDelegate(@interface IAudioData This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAudioData * This);
        public delegate uint ReleaseDelegate(@interface IAudioData This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBuffer)(interface IAudioData * This, uint cbSize, byte *pbData, uint dwFlags);
        public delegate int SetBufferDelegate(@interface IAudioData This, uint cbSize, ref byte pbData, uint dwFlags);
        public SetBufferDelegate SetBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInfo)(interface IAudioData * This, uint *pdwLength, byte **ppbData, uint *pcbActualData);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetInfoDelegate(@interface IAudioData This, ref uint pdwLength, byte[] ppbData, ref uint pcbActualData);
        public GetInfoDelegate GetInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetActual)(interface IAudioData * This, uint cbDataValid);
        public delegate int SetActualDelegate(@interface IAudioData This, uint cbDataValid);
        public SetActualDelegate SetActual;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFormat)(interface IAudioData * This, WAVEFORMATEX *pWaveFormatCurrent);
        public delegate int GetFormatDelegate(@interface IAudioData This, WAVEFORMATEX pWaveFormatCurrent);
        public GetFormatDelegate GetFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFormat)(interface IAudioData * This, const WAVEFORMATEX *lpWaveFormat);
        public delegate int SetFormatDelegate(@interface IAudioData This, WAVEFORMATEX lpWaveFormat);
        public SetFormatDelegate SetFormat;

//        END_INTERFACE
    }