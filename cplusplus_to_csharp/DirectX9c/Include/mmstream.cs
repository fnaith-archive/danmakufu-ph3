using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for mmstream.idl:
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



public enum __MIDL___MIDL_itf_mmstream_0000_0001
{
        STREAMTYPE_READ = 0,
    STREAMTYPE_WRITE = 1,
    STREAMTYPE_TRANSFORM = 2
}

public enum __MIDL___MIDL_itf_mmstream_0000_0002
{
        STREAMSTATE_STOP = 0,
    STREAMSTATE_RUN = 1
}

public enum __MIDL___MIDL_itf_mmstream_0000_0003
{
        COMPSTAT_NOUPDATEOK = 0x1,
    COMPSTAT_WAIT = 0x2,
    COMPSTAT_ABORT = 0x4
}


public enum __MIDL___MIDL_itf_mmstream_0000_0004
{
        MMSSF_HASCLOCK = 0x1,
    MMSSF_SUPPORTSEEK = 0x2,
    MMSSF_ASYNCHRONOUS = 0x4
}

public enum __MIDL___MIDL_itf_mmstream_0000_0005
{
        SSUPDATE_ASYNC = 0x1,
    SSUPDATE_CONTINUOUS = 0x2
}

#else // C style interface

    public class IMultiMediaStreamVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMultiMediaStream * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMultiMediaStream This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMultiMediaStream * This);
        public delegate uint AddRefDelegate(@interface IMultiMediaStream This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMultiMediaStream * This);
        public delegate uint ReleaseDelegate(@interface IMultiMediaStream This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInformation)(interface IMultiMediaStream * This, uint *pdwFlags, STREAM_TYPE *pStreamType);
        public delegate int GetInformationDelegate(@interface IMultiMediaStream This, ref uint pdwFlags, STREAM_TYPE pStreamType);
        public GetInformationDelegate GetInformation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaStream)(interface IMultiMediaStream * This, REFGUID idPurpose, interface IMediaStream **ppMediaStream);
        public delegate int GetMediaStreamDelegate(@interface IMultiMediaStream This, REFGUID idPurpose, @interface IMediaStream[] ppMediaStream);
        public GetMediaStreamDelegate GetMediaStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumMediaStreams)(interface IMultiMediaStream * This, int Index, interface IMediaStream **ppMediaStream);
        public delegate int EnumMediaStreamsDelegate(@interface IMultiMediaStream This, int Index, @interface IMediaStream[] ppMediaStream);
        public EnumMediaStreamsDelegate EnumMediaStreams;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetState)(interface IMultiMediaStream * This, STREAM_STATE *pCurrentState);
        public delegate int GetStateDelegate(@interface IMultiMediaStream This, STREAM_STATE pCurrentState);
        public GetStateDelegate GetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetState)(interface IMultiMediaStream * This, STREAM_STATE NewState);
        public delegate int SetStateDelegate(@interface IMultiMediaStream This, STREAM_STATE NewState);
        public SetStateDelegate SetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTime)(interface IMultiMediaStream * This, long *pCurrentTime);
        public delegate int GetTimeDelegate(@interface IMultiMediaStream This, ref long pCurrentTime);
        public GetTimeDelegate GetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDuration)(interface IMultiMediaStream * This, long *pDuration);
        public delegate int GetDurationDelegate(@interface IMultiMediaStream This, ref long pDuration);
        public GetDurationDelegate GetDuration;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Seek)(interface IMultiMediaStream * This, long SeekTime);
        public delegate int SeekDelegate(@interface IMultiMediaStream This, long SeekTime);
        public SeekDelegate Seek;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEndOfStreamEventHandle)(interface IMultiMediaStream * This, System.IntPtr *phEOS);
        public delegate int GetEndOfStreamEventHandleDelegate(@interface IMultiMediaStream This, IntPtr phEOS);
        public GetEndOfStreamEventHandleDelegate GetEndOfStreamEventHandle;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaStreamVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaStream * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaStream This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaStream * This);
        public delegate uint AddRefDelegate(@interface IMediaStream This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaStream * This);
        public delegate uint ReleaseDelegate(@interface IMediaStream This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMultiMediaStream)(interface IMediaStream * This, interface IMultiMediaStream **ppMultiMediaStream);
        public delegate int GetMultiMediaStreamDelegate(@interface IMediaStream This, @interface IMultiMediaStream[] ppMultiMediaStream);
        public GetMultiMediaStreamDelegate GetMultiMediaStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInformation)(interface IMediaStream * This, GUID *pPurposeId, STREAM_TYPE *pType);
        public delegate int GetInformationDelegate(@interface IMediaStream This, GUID pPurposeId, STREAM_TYPE pType);
        public GetInformationDelegate GetInformation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSameFormat)(interface IMediaStream * This, interface IMediaStream *pStreamThatHasDesiredFormat, uint dwFlags);
        public delegate int SetSameFormatDelegate(@interface IMediaStream This, @interface IMediaStream pStreamThatHasDesiredFormat, uint dwFlags);
        public SetSameFormatDelegate SetSameFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocateSample)(interface IMediaStream * This, uint dwFlags, interface IStreamSample **ppSample);
        public delegate int AllocateSampleDelegate(@interface IMediaStream This, uint dwFlags, @interface IStreamSample[] ppSample);
        public AllocateSampleDelegate AllocateSample;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateSharedSample)(interface IMediaStream * This, interface IStreamSample *pExistingSample, uint dwFlags, interface IStreamSample **ppNewSample);
        public delegate int CreateSharedSampleDelegate(@interface IMediaStream This, @interface IStreamSample pExistingSample, uint dwFlags, @interface IStreamSample[] ppNewSample);
        public CreateSharedSampleDelegate CreateSharedSample;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SendEndOfStream)(interface IMediaStream * This, uint dwFlags);
        public delegate int SendEndOfStreamDelegate(@interface IMediaStream This, uint dwFlags);
        public SendEndOfStreamDelegate SendEndOfStream;

//        END_INTERFACE
    }

#else // C style interface

    public class IStreamSampleVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IStreamSample * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IStreamSample This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IStreamSample * This);
        public delegate uint AddRefDelegate(@interface IStreamSample This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IStreamSample * This);
        public delegate uint ReleaseDelegate(@interface IStreamSample This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaStream)(interface IStreamSample * This, interface IMediaStream **ppMediaStream);
        public delegate int GetMediaStreamDelegate(@interface IStreamSample This, @interface IMediaStream[] ppMediaStream);
        public GetMediaStreamDelegate GetMediaStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSampleTimes)(interface IStreamSample * This, long *pStartTime, long *pEndTime, long *pCurrentTime);
        public delegate int GetSampleTimesDelegate(@interface IStreamSample This, ref long pStartTime, ref long pEndTime, ref long pCurrentTime);
        public GetSampleTimesDelegate GetSampleTimes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSampleTimes)(interface IStreamSample * This, const long *pStartTime, const long *pEndTime);
        public delegate int SetSampleTimesDelegate(@interface IStreamSample This, long pStartTime, long pEndTime);
        public SetSampleTimesDelegate SetSampleTimes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Update)(interface IStreamSample * This, uint dwFlags, System.IntPtr hEvent, PAPCFUNC pfnAPC, System.IntPtr dwAPCData);
        public delegate int UpdateDelegate(@interface IStreamSample This, uint dwFlags, IntPtr hEvent, PAPCFUNC pfnAPC, IntPtr dwAPCData);
        public UpdateDelegate Update;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CompletionStatus)(interface IStreamSample * This, uint dwFlags, uint dwMilliseconds);
        public delegate int CompletionStatusDelegate(@interface IStreamSample This, uint dwFlags, uint dwMilliseconds);
        public CompletionStatusDelegate CompletionStatus;

//        END_INTERFACE
    }