using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for strmif.idl:
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
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "oaidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ocidl.h"

#if __cplusplus
#endif

#else // C style interface

    public class ICreateDevEnumVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICreateDevEnum * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICreateDevEnum This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICreateDevEnum * This);
        public delegate uint AddRefDelegate(@interface ICreateDevEnum This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICreateDevEnum * This);
        public delegate uint ReleaseDelegate(@interface ICreateDevEnum This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateClassEnumerator)(interface ICreateDevEnum * This, REFCLSID clsidDeviceClass, IEnumMoniker **ppEnumMoniker, uint dwFlags);
        public delegate int CreateClassEnumeratorDelegate(@interface ICreateDevEnum This, REFCLSID clsidDeviceClass, IEnumMoniker[] ppEnumMoniker, uint dwFlags);
        public CreateClassEnumeratorDelegate CreateClassEnumerator;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0113 */
/* [local] */ 

public class _AMMediaType
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

public enum _PinDirection
{
        PINDIR_INPUT = 0,
    PINDIR_OUTPUT = PINDIR_INPUT + 1
}





public class _AllocatorProperties
{
    public int cBuffers;
    public int cbBuffer;
    public int cbAlign;
    public int cbPrefix;
}


/* interface IPin */
/* [unique][uuid][object] */ 

public class _PinInfo
{
    public @interface IBaseFilter * pFilter = new @interface();
    public PIN_DIRECTION dir = new PIN_DIRECTION();
    public string achName = new string(new char[128]);
}

#else // C style interface

    public class IPinVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IPin * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IPin This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IPin * This);
        public delegate uint AddRefDelegate(@interface IPin This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IPin * This);
        public delegate uint ReleaseDelegate(@interface IPin This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Connect)(interface IPin * This, interface IPin *pReceivePin, const _AMMediaType *pmt);
        public delegate int ConnectDelegate(@interface IPin This, @interface IPin pReceivePin, _AMMediaType pmt);
        public ConnectDelegate Connect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReceiveConnection)(interface IPin * This, interface IPin *pConnector, const _AMMediaType *pmt);
        public delegate int ReceiveConnectionDelegate(@interface IPin This, @interface IPin pConnector, _AMMediaType pmt);
        public ReceiveConnectionDelegate ReceiveConnection;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Disconnect)(interface IPin * This);
        public delegate int DisconnectDelegate(@interface IPin This);
        public DisconnectDelegate Disconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectedTo)(interface IPin * This, interface IPin **pPin);
        public delegate int ConnectedToDelegate(@interface IPin This, @interface IPin[] pPin);
        public ConnectedToDelegate ConnectedTo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectionMediaType)(interface IPin * This, _AMMediaType *pmt);
        public delegate int ConnectionMediaTypeDelegate(@interface IPin This, _AMMediaType pmt);
        public ConnectionMediaTypeDelegate ConnectionMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryPinInfo)(interface IPin * This, _PinInfo *pInfo);
        public delegate int QueryPinInfoDelegate(@interface IPin This, _PinInfo pInfo);
        public QueryPinInfoDelegate QueryPinInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryDirection)(interface IPin * This, PIN_DIRECTION *pPinDir);
        public delegate int QueryDirectionDelegate(@interface IPin This, PIN_DIRECTION pPinDir);
        public QueryDirectionDelegate QueryDirection;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryId)(interface IPin * This, char**Id);
        public delegate int QueryIdDelegate(@interface IPin This, char * Id[] UnnamedParameter);
        public QueryIdDelegate QueryId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryAccept)(interface IPin * This, const _AMMediaType *pmt);
        public delegate int QueryAcceptDelegate(@interface IPin This, _AMMediaType pmt);
        public QueryAcceptDelegate QueryAccept;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumMediaTypes)(interface IPin * This, interface IEnumMediaTypes **ppEnum);
        public delegate int EnumMediaTypesDelegate(@interface IPin This, @interface IEnumMediaTypes[] ppEnum);
        public EnumMediaTypesDelegate EnumMediaTypes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryInternalConnections)(interface IPin * This, interface IPin **apPin, uint *nPin);
        public delegate int QueryInternalConnectionsDelegate(@interface IPin This, @interface IPin[] apPin, ref uint nPin);
        public QueryInternalConnectionsDelegate QueryInternalConnections;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndOfStream)(interface IPin * This);
        public delegate int EndOfStreamDelegate(@interface IPin This);
        public EndOfStreamDelegate EndOfStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *BeginFlush)(interface IPin * This);
        public delegate int BeginFlushDelegate(@interface IPin This);
        public BeginFlushDelegate BeginFlush;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndFlush)(interface IPin * This);
        public delegate int EndFlushDelegate(@interface IPin This);
        public EndFlushDelegate EndFlush;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NewSegment)(interface IPin * This, long tStart, long tStop, double dRate);
        public delegate int NewSegmentDelegate(@interface IPin This, long tStart, long tStop, double dRate);
        public NewSegmentDelegate NewSegment;

//        END_INTERFACE
    }

#else // C style interface

    public class IEnumPinsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumPins * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumPins This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumPins * This);
        public delegate uint AddRefDelegate(@interface IEnumPins This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumPins * This);
        public delegate uint ReleaseDelegate(@interface IEnumPins This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumPins * This, uint cPins, interface IPin **ppPins, uint *pcFetched);
        public delegate int NextDelegate(@interface IEnumPins This, uint cPins, @interface IPin[] ppPins, ref uint pcFetched);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumPins * This, uint cPins);
        public delegate int SkipDelegate(@interface IEnumPins This, uint cPins);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumPins * This);
        public delegate int ResetDelegate(@interface IEnumPins This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumPins * This, interface IEnumPins **ppEnum);
        public delegate int CloneDelegate(@interface IEnumPins This, @interface IEnumPins[] ppEnum);
        public CloneDelegate Clone;

//        END_INTERFACE
    }

#else // C style interface

    public class IEnumMediaTypesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumMediaTypes * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumMediaTypes This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumMediaTypes * This);
        public delegate uint AddRefDelegate(@interface IEnumMediaTypes This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumMediaTypes * This);
        public delegate uint ReleaseDelegate(@interface IEnumMediaTypes This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumMediaTypes * This, uint cMediaTypes, _AMMediaType **ppMediaTypes, uint *pcFetched);
        public delegate int NextDelegate(@interface IEnumMediaTypes This, uint cMediaTypes, _AMMediaType[] ppMediaTypes, ref uint pcFetched);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumMediaTypes * This, uint cMediaTypes);
        public delegate int SkipDelegate(@interface IEnumMediaTypes This, uint cMediaTypes);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumMediaTypes * This);
        public delegate int ResetDelegate(@interface IEnumMediaTypes This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumMediaTypes * This, interface IEnumMediaTypes **ppEnum);
        public delegate int CloneDelegate(@interface IEnumMediaTypes This, @interface IEnumMediaTypes[] ppEnum);
        public CloneDelegate Clone;

//        END_INTERFACE
    }

#else // C style interface

    public class IFilterGraphVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterGraph * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterGraph This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterGraph * This);
        public delegate uint AddRefDelegate(@interface IFilterGraph This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterGraph * This);
        public delegate uint ReleaseDelegate(@interface IFilterGraph This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddFilter)(interface IFilterGraph * This, interface IBaseFilter *pFilter, const char* pName);
        public delegate int AddFilterDelegate(@interface IFilterGraph This, @interface IBaseFilter pFilter, string pName);
        public AddFilterDelegate AddFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveFilter)(interface IFilterGraph * This, interface IBaseFilter *pFilter);
        public delegate int RemoveFilterDelegate(@interface IFilterGraph This, @interface IBaseFilter pFilter);
        public RemoveFilterDelegate RemoveFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumFilters)(interface IFilterGraph * This, interface IEnumFilters **ppEnum);
        public delegate int EnumFiltersDelegate(@interface IFilterGraph This, @interface IEnumFilters[] ppEnum);
        public EnumFiltersDelegate EnumFilters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindFilterByName)(interface IFilterGraph * This, const char* pName, interface IBaseFilter **ppFilter);
        public delegate int FindFilterByNameDelegate(@interface IFilterGraph This, string pName, @interface IBaseFilter[] ppFilter);
        public FindFilterByNameDelegate FindFilterByName;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectDirect)(interface IFilterGraph * This, interface IPin *ppinOut, interface IPin *ppinIn, const _AMMediaType *pmt);
        public delegate int ConnectDirectDelegate(@interface IFilterGraph This, @interface IPin ppinOut, @interface IPin ppinIn, _AMMediaType pmt);
        public ConnectDirectDelegate ConnectDirect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reconnect)(interface IFilterGraph * This, interface IPin *ppin);
        public delegate int ReconnectDelegate(@interface IFilterGraph This, @interface IPin ppin);
        public ReconnectDelegate Reconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Disconnect)(interface IFilterGraph * This, interface IPin *ppin);
        public delegate int DisconnectDelegate(@interface IFilterGraph This, @interface IPin ppin);
        public DisconnectDelegate Disconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultSyncSource)(interface IFilterGraph * This);
        public delegate int SetDefaultSyncSourceDelegate(@interface IFilterGraph This);
        public SetDefaultSyncSourceDelegate SetDefaultSyncSource;

//        END_INTERFACE
    }

#else // C style interface

    public class IEnumFiltersVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumFilters * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumFilters This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumFilters * This);
        public delegate uint AddRefDelegate(@interface IEnumFilters This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumFilters * This);
        public delegate uint ReleaseDelegate(@interface IEnumFilters This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumFilters * This, uint cFilters, interface IBaseFilter **ppFilter, uint *pcFetched);
        public delegate int NextDelegate(@interface IEnumFilters This, uint cFilters, @interface IBaseFilter[] ppFilter, ref uint pcFetched);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumFilters * This, uint cFilters);
        public delegate int SkipDelegate(@interface IEnumFilters This, uint cFilters);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumFilters * This);
        public delegate int ResetDelegate(@interface IEnumFilters This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumFilters * This, interface IEnumFilters **ppEnum);
        public delegate int CloneDelegate(@interface IEnumFilters This, @interface IEnumFilters[] ppEnum);
        public CloneDelegate Clone;

//        END_INTERFACE
    }


/* interface IMediaFilter */
/* [unique][uuid][object] */ 

public enum _FilterState
{
        State_Stopped = 0,
    State_Paused = State_Stopped + 1,
    State_Running = State_Paused + 1
}

#else // C style interface

    public class IMediaFilterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaFilter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaFilter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaFilter * This);
        public delegate uint AddRefDelegate(@interface IMediaFilter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaFilter * This);
        public delegate uint ReleaseDelegate(@interface IMediaFilter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClassID)(interface IMediaFilter * This, CLSID *pClassID);
        public delegate int GetClassIDDelegate(@interface IMediaFilter This, CLSID pClassID);
        public GetClassIDDelegate GetClassID;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMediaFilter * This);
        public delegate int StopDelegate(@interface IMediaFilter This);
        public StopDelegate Stop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IMediaFilter * This);
        public delegate int PauseDelegate(@interface IMediaFilter This);
        public PauseDelegate Pause;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IMediaFilter * This, long tStart);
        public delegate int RunDelegate(@interface IMediaFilter This, long tStart);
        public RunDelegate Run;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetState)(interface IMediaFilter * This, uint dwMilliSecsTimeout, FILTER_STATE *State);
        public delegate int GetStateDelegate(@interface IMediaFilter This, uint dwMilliSecsTimeout, FILTER_STATE State);
        public GetStateDelegate GetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSyncSource)(interface IMediaFilter * This, interface IReferenceClock *pClock);
        public delegate int SetSyncSourceDelegate(@interface IMediaFilter This, @interface IReferenceClock pClock);
        public SetSyncSourceDelegate SetSyncSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSyncSource)(interface IMediaFilter * This, interface IReferenceClock **pClock);
        public delegate int GetSyncSourceDelegate(@interface IMediaFilter This, @interface IReferenceClock[] pClock);
        public GetSyncSourceDelegate GetSyncSource;

//        END_INTERFACE
    }


/* interface IBaseFilter */
/* [unique][uuid][object] */ 

public class _FilterInfo
{
    public string achName = new string(new char[128]);
    public @interface IFilterGraph * pGraph = new @interface();
}

#else // C style interface

    public class IBaseFilterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IBaseFilter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IBaseFilter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IBaseFilter * This);
        public delegate uint AddRefDelegate(@interface IBaseFilter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IBaseFilter * This);
        public delegate uint ReleaseDelegate(@interface IBaseFilter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClassID)(interface IBaseFilter * This, CLSID *pClassID);
        public delegate int GetClassIDDelegate(@interface IBaseFilter This, CLSID pClassID);
        public GetClassIDDelegate GetClassID;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IBaseFilter * This);
        public delegate int StopDelegate(@interface IBaseFilter This);
        public StopDelegate Stop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IBaseFilter * This);
        public delegate int PauseDelegate(@interface IBaseFilter This);
        public PauseDelegate Pause;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IBaseFilter * This, long tStart);
        public delegate int RunDelegate(@interface IBaseFilter This, long tStart);
        public RunDelegate Run;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetState)(interface IBaseFilter * This, uint dwMilliSecsTimeout, FILTER_STATE *State);
        public delegate int GetStateDelegate(@interface IBaseFilter This, uint dwMilliSecsTimeout, FILTER_STATE State);
        public GetStateDelegate GetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSyncSource)(interface IBaseFilter * This, interface IReferenceClock *pClock);
        public delegate int SetSyncSourceDelegate(@interface IBaseFilter This, @interface IReferenceClock pClock);
        public SetSyncSourceDelegate SetSyncSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSyncSource)(interface IBaseFilter * This, interface IReferenceClock **pClock);
        public delegate int GetSyncSourceDelegate(@interface IBaseFilter This, @interface IReferenceClock[] pClock);
        public GetSyncSourceDelegate GetSyncSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumPins)(interface IBaseFilter * This, interface IEnumPins **ppEnum);
        public delegate int EnumPinsDelegate(@interface IBaseFilter This, @interface IEnumPins[] ppEnum);
        public EnumPinsDelegate EnumPins;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindPin)(interface IBaseFilter * This, const char* Id, interface IPin **ppPin);
        public delegate int FindPinDelegate(@interface IBaseFilter This, string Id, @interface IPin[] ppPin);
        public FindPinDelegate FindPin;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryFilterInfo)(interface IBaseFilter * This, _FilterInfo *pInfo);
        public delegate int QueryFilterInfoDelegate(@interface IBaseFilter This, _FilterInfo pInfo);
        public QueryFilterInfoDelegate QueryFilterInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *JoinFilterGraph)(interface IBaseFilter * This, interface IFilterGraph *pGraph, const char* pName);
        public delegate int JoinFilterGraphDelegate(@interface IBaseFilter This, @interface IFilterGraph pGraph, string pName);
        public JoinFilterGraphDelegate JoinFilterGraph;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryVendorInfo)(interface IBaseFilter * This, char**pVendorInfo);
        public delegate int QueryVendorInfoDelegate(@interface IBaseFilter This, char * pVendorInfo[] UnnamedParameter);
        public QueryVendorInfoDelegate QueryVendorInfo;

//        END_INTERFACE
    }

#else // C style interface

    public class IReferenceClockVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IReferenceClock * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IReferenceClock This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IReferenceClock * This);
        public delegate uint AddRefDelegate(@interface IReferenceClock This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IReferenceClock * This);
        public delegate uint ReleaseDelegate(@interface IReferenceClock This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTime)(interface IReferenceClock * This, long *pTime);
        public delegate int GetTimeDelegate(@interface IReferenceClock This, ref long pTime);
        public GetTimeDelegate GetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdviseTime)(interface IReferenceClock * This, long baseTime, long streamTime, System.IntPtr hEvent, System.IntPtr *pdwAdviseCookie);
        public delegate int AdviseTimeDelegate(@interface IReferenceClock This, long baseTime, long streamTime, IntPtr hEvent, IntPtr pdwAdviseCookie);
        public AdviseTimeDelegate AdviseTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdvisePeriodic)(interface IReferenceClock * This, long startTime, long periodTime, System.IntPtr hSemaphore, System.IntPtr *pdwAdviseCookie);
        public delegate int AdvisePeriodicDelegate(@interface IReferenceClock This, long startTime, long periodTime, IntPtr hSemaphore, IntPtr pdwAdviseCookie);
        public AdvisePeriodicDelegate AdvisePeriodic;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Unadvise)(interface IReferenceClock * This, System.IntPtr dwAdviseCookie);
        public delegate int UnadviseDelegate(@interface IReferenceClock This, IntPtr dwAdviseCookie);
        public UnadviseDelegate Unadvise;

//        END_INTERFACE
    }

#else // C style interface

    public class IReferenceClock2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IReferenceClock2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IReferenceClock2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IReferenceClock2 * This);
        public delegate uint AddRefDelegate(@interface IReferenceClock2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IReferenceClock2 * This);
        public delegate uint ReleaseDelegate(@interface IReferenceClock2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTime)(interface IReferenceClock2 * This, long *pTime);
        public delegate int GetTimeDelegate(@interface IReferenceClock2 This, ref long pTime);
        public GetTimeDelegate GetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdviseTime)(interface IReferenceClock2 * This, long baseTime, long streamTime, System.IntPtr hEvent, System.IntPtr *pdwAdviseCookie);
        public delegate int AdviseTimeDelegate(@interface IReferenceClock2 This, long baseTime, long streamTime, IntPtr hEvent, IntPtr pdwAdviseCookie);
        public AdviseTimeDelegate AdviseTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdvisePeriodic)(interface IReferenceClock2 * This, long startTime, long periodTime, System.IntPtr hSemaphore, System.IntPtr *pdwAdviseCookie);
        public delegate int AdvisePeriodicDelegate(@interface IReferenceClock2 This, long startTime, long periodTime, IntPtr hSemaphore, IntPtr pdwAdviseCookie);
        public AdvisePeriodicDelegate AdvisePeriodic;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Unadvise)(interface IReferenceClock2 * This, System.IntPtr dwAdviseCookie);
        public delegate int UnadviseDelegate(@interface IReferenceClock2 This, IntPtr dwAdviseCookie);
        public UnadviseDelegate Unadvise;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaSampleVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaSample * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaSample This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaSample * This);
        public delegate uint AddRefDelegate(@interface IMediaSample This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaSample * This);
        public delegate uint ReleaseDelegate(@interface IMediaSample This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPointer)(interface IMediaSample * This, byte **ppBuffer);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetPointerDelegate(@interface IMediaSample This, byte[] ppBuffer);
        public GetPointerDelegate GetPointer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSize)(interface IMediaSample * This);
        public delegate int GetSizeDelegate(@interface IMediaSample This);
        public GetSizeDelegate GetSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTime)(interface IMediaSample * This, long *pTimeStart, long *pTimeEnd);
        public delegate int GetTimeDelegate(@interface IMediaSample This, ref long pTimeStart, ref long pTimeEnd);
        public GetTimeDelegate GetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTime)(interface IMediaSample * This, long *pTimeStart, long *pTimeEnd);
        public delegate int SetTimeDelegate(@interface IMediaSample This, ref long pTimeStart, ref long pTimeEnd);
        public SetTimeDelegate SetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSyncPoint)(interface IMediaSample * This);
        public delegate int IsSyncPointDelegate(@interface IMediaSample This);
        public IsSyncPointDelegate IsSyncPoint;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSyncPoint)(interface IMediaSample * This, bool bIsSyncPoint);
        public delegate int SetSyncPointDelegate(@interface IMediaSample This, bool bIsSyncPoint);
        public SetSyncPointDelegate SetSyncPoint;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsPreroll)(interface IMediaSample * This);
        public delegate int IsPrerollDelegate(@interface IMediaSample This);
        public IsPrerollDelegate IsPreroll;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetPreroll)(interface IMediaSample * This, bool bIsPreroll);
        public delegate int SetPrerollDelegate(@interface IMediaSample This, bool bIsPreroll);
        public SetPrerollDelegate SetPreroll;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetActualDataLength)(interface IMediaSample * This);
        public delegate int GetActualDataLengthDelegate(@interface IMediaSample This);
        public GetActualDataLengthDelegate GetActualDataLength;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetActualDataLength)(interface IMediaSample * This, int __MIDL_0010);
        public delegate int SetActualDataLengthDelegate(@interface IMediaSample This, int __MIDL_0010);
        public SetActualDataLengthDelegate SetActualDataLength;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaType)(interface IMediaSample * This, _AMMediaType **ppMediaType);
        public delegate int GetMediaTypeDelegate(@interface IMediaSample This, _AMMediaType[] ppMediaType);
        public GetMediaTypeDelegate GetMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMediaType)(interface IMediaSample * This, _AMMediaType *pMediaType);
        public delegate int SetMediaTypeDelegate(@interface IMediaSample This, _AMMediaType pMediaType);
        public SetMediaTypeDelegate SetMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsDiscontinuity)(interface IMediaSample * This);
        public delegate int IsDiscontinuityDelegate(@interface IMediaSample This);
        public IsDiscontinuityDelegate IsDiscontinuity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDiscontinuity)(interface IMediaSample * This, bool bDiscontinuity);
        public delegate int SetDiscontinuityDelegate(@interface IMediaSample This, bool bDiscontinuity);
        public SetDiscontinuityDelegate SetDiscontinuity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaTime)(interface IMediaSample * This, long *pTimeStart, long *pTimeEnd);
        public delegate int GetMediaTimeDelegate(@interface IMediaSample This, ref long pTimeStart, ref long pTimeEnd);
        public GetMediaTimeDelegate GetMediaTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMediaTime)(interface IMediaSample * This, long *pTimeStart, long *pTimeEnd);
        public delegate int SetMediaTimeDelegate(@interface IMediaSample This, ref long pTimeStart, ref long pTimeEnd);
        public SetMediaTimeDelegate SetMediaTime;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0123 */
/* [local] */ 



public enum tagAM_SAMPLE_PROPERTY_FLAGS
{
        AM_SAMPLE_SPLICEPOINT = 0x1,
    AM_SAMPLE_PREROLL = 0x2,
    AM_SAMPLE_DATADISCONTINUITY = 0x4,
    AM_SAMPLE_TYPECHANGED = 0x8,
    AM_SAMPLE_TIMEVALID = 0x10,
    AM_SAMPLE_TIMEDISCONTINUITY = 0x40,
    AM_SAMPLE_FLUSH_ON_PAUSE = 0x80,
    AM_SAMPLE_STOPVALID = 0x100,
    AM_SAMPLE_ENDOFSTREAM = 0x200,
    AM_STREAM_MEDIA = 0,
    AM_STREAM_CONTROL = 1
}
public class tagAM_SAMPLE2_PROPERTIES
{
    public uint cbData;
    public uint dwTypeSpecificFlags;
    public uint dwSampleFlags;
    public int lActual;
    public long tStart;
    public long tStop;
    public uint dwStreamId;
    public _AMMediaType pMediaType;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pbBuffer;
    public byte pbBuffer;
    public int cbBuffer;
}

#else // C style interface

    public class IMediaSample2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaSample2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaSample2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaSample2 * This);
        public delegate uint AddRefDelegate(@interface IMediaSample2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaSample2 * This);
        public delegate uint ReleaseDelegate(@interface IMediaSample2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPointer)(interface IMediaSample2 * This, byte **ppBuffer);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetPointerDelegate(@interface IMediaSample2 This, byte[] ppBuffer);
        public GetPointerDelegate GetPointer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSize)(interface IMediaSample2 * This);
        public delegate int GetSizeDelegate(@interface IMediaSample2 This);
        public GetSizeDelegate GetSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTime)(interface IMediaSample2 * This, long *pTimeStart, long *pTimeEnd);
        public delegate int GetTimeDelegate(@interface IMediaSample2 This, ref long pTimeStart, ref long pTimeEnd);
        public GetTimeDelegate GetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTime)(interface IMediaSample2 * This, long *pTimeStart, long *pTimeEnd);
        public delegate int SetTimeDelegate(@interface IMediaSample2 This, ref long pTimeStart, ref long pTimeEnd);
        public SetTimeDelegate SetTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSyncPoint)(interface IMediaSample2 * This);
        public delegate int IsSyncPointDelegate(@interface IMediaSample2 This);
        public IsSyncPointDelegate IsSyncPoint;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSyncPoint)(interface IMediaSample2 * This, bool bIsSyncPoint);
        public delegate int SetSyncPointDelegate(@interface IMediaSample2 This, bool bIsSyncPoint);
        public SetSyncPointDelegate SetSyncPoint;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsPreroll)(interface IMediaSample2 * This);
        public delegate int IsPrerollDelegate(@interface IMediaSample2 This);
        public IsPrerollDelegate IsPreroll;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetPreroll)(interface IMediaSample2 * This, bool bIsPreroll);
        public delegate int SetPrerollDelegate(@interface IMediaSample2 This, bool bIsPreroll);
        public SetPrerollDelegate SetPreroll;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetActualDataLength)(interface IMediaSample2 * This);
        public delegate int GetActualDataLengthDelegate(@interface IMediaSample2 This);
        public GetActualDataLengthDelegate GetActualDataLength;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetActualDataLength)(interface IMediaSample2 * This, int __MIDL_0010);
        public delegate int SetActualDataLengthDelegate(@interface IMediaSample2 This, int __MIDL_0010);
        public SetActualDataLengthDelegate SetActualDataLength;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaType)(interface IMediaSample2 * This, _AMMediaType **ppMediaType);
        public delegate int GetMediaTypeDelegate(@interface IMediaSample2 This, _AMMediaType[] ppMediaType);
        public GetMediaTypeDelegate GetMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMediaType)(interface IMediaSample2 * This, _AMMediaType *pMediaType);
        public delegate int SetMediaTypeDelegate(@interface IMediaSample2 This, _AMMediaType pMediaType);
        public SetMediaTypeDelegate SetMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsDiscontinuity)(interface IMediaSample2 * This);
        public delegate int IsDiscontinuityDelegate(@interface IMediaSample2 This);
        public IsDiscontinuityDelegate IsDiscontinuity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDiscontinuity)(interface IMediaSample2 * This, bool bDiscontinuity);
        public delegate int SetDiscontinuityDelegate(@interface IMediaSample2 This, bool bDiscontinuity);
        public SetDiscontinuityDelegate SetDiscontinuity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMediaTime)(interface IMediaSample2 * This, long *pTimeStart, long *pTimeEnd);
        public delegate int GetMediaTimeDelegate(@interface IMediaSample2 This, ref long pTimeStart, ref long pTimeEnd);
        public GetMediaTimeDelegate GetMediaTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMediaTime)(interface IMediaSample2 * This, long *pTimeStart, long *pTimeEnd);
        public delegate int SetMediaTimeDelegate(@interface IMediaSample2 This, ref long pTimeStart, ref long pTimeEnd);
        public SetMediaTimeDelegate SetMediaTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetProperties)(interface IMediaSample2 * This, uint cbProperties, byte *pbProperties);
        public delegate int GetPropertiesDelegate(@interface IMediaSample2 This, uint cbProperties, ref byte pbProperties);
        public GetPropertiesDelegate GetProperties;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetProperties)(interface IMediaSample2 * This, uint cbProperties, const byte *pbProperties);
        public delegate int SetPropertiesDelegate(@interface IMediaSample2 This, uint cbProperties, byte pbProperties);
        public SetPropertiesDelegate SetProperties;

//        END_INTERFACE
    }

#else // C style interface

    public class IMemAllocatorVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMemAllocator * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMemAllocator This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMemAllocator * This);
        public delegate uint AddRefDelegate(@interface IMemAllocator This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMemAllocator * This);
        public delegate uint ReleaseDelegate(@interface IMemAllocator This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetProperties)(interface IMemAllocator * This, _AllocatorProperties *pRequest, _AllocatorProperties *pActual);
        public delegate int SetPropertiesDelegate(@interface IMemAllocator This, _AllocatorProperties pRequest, _AllocatorProperties pActual);
        public SetPropertiesDelegate SetProperties;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetProperties)(interface IMemAllocator * This, _AllocatorProperties *pProps);
        public delegate int GetPropertiesDelegate(@interface IMemAllocator This, _AllocatorProperties pProps);
        public GetPropertiesDelegate GetProperties;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Commit)(interface IMemAllocator * This);
        public delegate int CommitDelegate(@interface IMemAllocator This);
        public CommitDelegate Commit;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Decommit)(interface IMemAllocator * This);
        public delegate int DecommitDelegate(@interface IMemAllocator This);
        public DecommitDelegate Decommit;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBuffer)(interface IMemAllocator * This, interface IMediaSample **ppBuffer, long *pStartTime, long *pEndTime, uint dwFlags);
        public delegate int GetBufferDelegate(@interface IMemAllocator This, @interface IMediaSample[] ppBuffer, ref long pStartTime, ref long pEndTime, uint dwFlags);
        public GetBufferDelegate GetBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReleaseBuffer)(interface IMemAllocator * This, interface IMediaSample *pBuffer);
        public delegate int ReleaseBufferDelegate(@interface IMemAllocator This, @interface IMediaSample pBuffer);
        public ReleaseBufferDelegate ReleaseBuffer;

//        END_INTERFACE
    }

#else // C style interface

    public class IMemAllocatorCallbackTempVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMemAllocatorCallbackTemp * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMemAllocatorCallbackTemp This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMemAllocatorCallbackTemp * This);
        public delegate uint AddRefDelegate(@interface IMemAllocatorCallbackTemp This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMemAllocatorCallbackTemp * This);
        public delegate uint ReleaseDelegate(@interface IMemAllocatorCallbackTemp This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetProperties)(interface IMemAllocatorCallbackTemp * This, _AllocatorProperties *pRequest, _AllocatorProperties *pActual);
        public delegate int SetPropertiesDelegate(@interface IMemAllocatorCallbackTemp This, _AllocatorProperties pRequest, _AllocatorProperties pActual);
        public SetPropertiesDelegate SetProperties;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetProperties)(interface IMemAllocatorCallbackTemp * This, _AllocatorProperties *pProps);
        public delegate int GetPropertiesDelegate(@interface IMemAllocatorCallbackTemp This, _AllocatorProperties pProps);
        public GetPropertiesDelegate GetProperties;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Commit)(interface IMemAllocatorCallbackTemp * This);
        public delegate int CommitDelegate(@interface IMemAllocatorCallbackTemp This);
        public CommitDelegate Commit;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Decommit)(interface IMemAllocatorCallbackTemp * This);
        public delegate int DecommitDelegate(@interface IMemAllocatorCallbackTemp This);
        public DecommitDelegate Decommit;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBuffer)(interface IMemAllocatorCallbackTemp * This, interface IMediaSample **ppBuffer, long *pStartTime, long *pEndTime, uint dwFlags);
        public delegate int GetBufferDelegate(@interface IMemAllocatorCallbackTemp This, @interface IMediaSample[] ppBuffer, ref long pStartTime, ref long pEndTime, uint dwFlags);
        public GetBufferDelegate GetBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReleaseBuffer)(interface IMemAllocatorCallbackTemp * This, interface IMediaSample *pBuffer);
        public delegate int ReleaseBufferDelegate(@interface IMemAllocatorCallbackTemp This, @interface IMediaSample pBuffer);
        public ReleaseBufferDelegate ReleaseBuffer;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetNotify)(interface IMemAllocatorCallbackTemp * This, interface IMemAllocatorNotifyCallbackTemp *pNotify);
        public delegate int SetNotifyDelegate(@interface IMemAllocatorCallbackTemp This, @interface IMemAllocatorNotifyCallbackTemp pNotify);
        public SetNotifyDelegate SetNotify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFreeCount)(interface IMemAllocatorCallbackTemp * This, int *plBuffersFree);
        public delegate int GetFreeCountDelegate(@interface IMemAllocatorCallbackTemp This, ref int plBuffersFree);
        public GetFreeCountDelegate GetFreeCount;

//        END_INTERFACE
    }

#else // C style interface

    public class IMemAllocatorNotifyCallbackTempVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMemAllocatorNotifyCallbackTemp * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMemAllocatorNotifyCallbackTemp This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMemAllocatorNotifyCallbackTemp * This);
        public delegate uint AddRefDelegate(@interface IMemAllocatorNotifyCallbackTemp This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMemAllocatorNotifyCallbackTemp * This);
        public delegate uint ReleaseDelegate(@interface IMemAllocatorNotifyCallbackTemp This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRelease)(interface IMemAllocatorNotifyCallbackTemp * This);
        public delegate int NotifyReleaseDelegate(@interface IMemAllocatorNotifyCallbackTemp This);
        public NotifyReleaseDelegate NotifyRelease;

//        END_INTERFACE
    }

#else // C style interface

    public class IMemInputPinVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMemInputPin * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMemInputPin This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMemInputPin * This);
        public delegate uint AddRefDelegate(@interface IMemInputPin This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMemInputPin * This);
        public delegate uint ReleaseDelegate(@interface IMemInputPin This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllocator)(interface IMemInputPin * This, interface IMemAllocator **ppAllocator);
        public delegate int GetAllocatorDelegate(@interface IMemInputPin This, @interface IMemAllocator[] ppAllocator);
        public GetAllocatorDelegate GetAllocator;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyAllocator)(interface IMemInputPin * This, interface IMemAllocator *pAllocator, bool bReadOnly);
        public delegate int NotifyAllocatorDelegate(@interface IMemInputPin This, @interface IMemAllocator pAllocator, bool bReadOnly);
        public NotifyAllocatorDelegate NotifyAllocator;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllocatorRequirements)(interface IMemInputPin * This, _AllocatorProperties *pProps);
        public delegate int GetAllocatorRequirementsDelegate(@interface IMemInputPin This, _AllocatorProperties pProps);
        public GetAllocatorRequirementsDelegate GetAllocatorRequirements;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Receive)(interface IMemInputPin * This, interface IMediaSample *pSample);
        public delegate int ReceiveDelegate(@interface IMemInputPin This, @interface IMediaSample pSample);
        public ReceiveDelegate Receive;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReceiveMultiple)(interface IMemInputPin * This, interface IMediaSample **pSamples, int nSamples, int *nSamplesProcessed);
        public delegate int ReceiveMultipleDelegate(@interface IMemInputPin This, @interface IMediaSample[] pSamples, int nSamples, ref int nSamplesProcessed);
        public ReceiveMultipleDelegate ReceiveMultiple;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReceiveCanBlock)(interface IMemInputPin * This);
        public delegate int ReceiveCanBlockDelegate(@interface IMemInputPin This);
        public ReceiveCanBlockDelegate ReceiveCanBlock;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMovieSetupVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMovieSetup * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMovieSetup This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMovieSetup * This);
        public delegate uint AddRefDelegate(@interface IAMovieSetup This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMovieSetup * This);
        public delegate uint ReleaseDelegate(@interface IAMovieSetup This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Register)(interface IAMovieSetup * This);
        public delegate int RegisterDelegate(@interface IAMovieSetup This);
        public RegisterDelegate Register;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Unregister)(interface IAMovieSetup * This);
        public delegate int UnregisterDelegate(@interface IAMovieSetup This);
        public UnregisterDelegate Unregister;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0129 */
/* [local] */ 


public enum AM_SEEKING_SeekingFlags
{
        AM_SEEKING_NoPositioning = 0,
    AM_SEEKING_AbsolutePositioning = 0x1,
    AM_SEEKING_RelativePositioning = 0x2,
    AM_SEEKING_IncrementalPositioning = 0x3,
    AM_SEEKING_PositioningBitsMask = 0x3,
    AM_SEEKING_SeekToKeyFrame = 0x4,
    AM_SEEKING_ReturnTime = 0x8,
    AM_SEEKING_Segment = 0x10,
    AM_SEEKING_NoFlush = 0x20
}

public enum AM_SEEKING_SeekingCapabilities
{
        AM_SEEKING_CanSeekAbsolute = 0x1,
    AM_SEEKING_CanSeekForwards = 0x2,
    AM_SEEKING_CanSeekBackwards = 0x4,
    AM_SEEKING_CanGetCurrentPos = 0x8,
    AM_SEEKING_CanGetStopPos = 0x10,
    AM_SEEKING_CanGetDuration = 0x20,
    AM_SEEKING_CanPlayBackwards = 0x40,
    AM_SEEKING_CanDoSegments = 0x80,
    AM_SEEKING_Source = 0x100
}

#else // C style interface

    public class IMediaSeekingVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaSeeking * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaSeeking This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaSeeking * This);
        public delegate uint AddRefDelegate(@interface IMediaSeeking This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaSeeking * This);
        public delegate uint ReleaseDelegate(@interface IMediaSeeking This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCapabilities)(interface IMediaSeeking * This, uint *pCapabilities);
        public delegate int GetCapabilitiesDelegate(@interface IMediaSeeking This, ref uint pCapabilities);
        public GetCapabilitiesDelegate GetCapabilities;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CheckCapabilities)(interface IMediaSeeking * This, uint *pCapabilities);
        public delegate int CheckCapabilitiesDelegate(@interface IMediaSeeking This, ref uint pCapabilities);
        public CheckCapabilitiesDelegate CheckCapabilities;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsFormatSupported)(interface IMediaSeeking * This, const GUID *pFormat);
        public delegate int IsFormatSupportedDelegate(@interface IMediaSeeking This, GUID pFormat);
        public IsFormatSupportedDelegate IsFormatSupported;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryPreferredFormat)(interface IMediaSeeking * This, GUID *pFormat);
        public delegate int QueryPreferredFormatDelegate(@interface IMediaSeeking This, GUID pFormat);
        public QueryPreferredFormatDelegate QueryPreferredFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTimeFormat)(interface IMediaSeeking * This, GUID *pFormat);
        public delegate int GetTimeFormatDelegate(@interface IMediaSeeking This, GUID pFormat);
        public GetTimeFormatDelegate GetTimeFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsUsingTimeFormat)(interface IMediaSeeking * This, const GUID *pFormat);
        public delegate int IsUsingTimeFormatDelegate(@interface IMediaSeeking This, GUID pFormat);
        public IsUsingTimeFormatDelegate IsUsingTimeFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTimeFormat)(interface IMediaSeeking * This, const GUID *pFormat);
        public delegate int SetTimeFormatDelegate(@interface IMediaSeeking This, GUID pFormat);
        public SetTimeFormatDelegate SetTimeFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDuration)(interface IMediaSeeking * This, long *pDuration);
        public delegate int GetDurationDelegate(@interface IMediaSeeking This, ref long pDuration);
        public GetDurationDelegate GetDuration;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStopPosition)(interface IMediaSeeking * This, long *pStop);
        public delegate int GetStopPositionDelegate(@interface IMediaSeeking This, ref long pStop);
        public GetStopPositionDelegate GetStopPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentPosition)(interface IMediaSeeking * This, long *pCurrent);
        public delegate int GetCurrentPositionDelegate(@interface IMediaSeeking This, ref long pCurrent);
        public GetCurrentPositionDelegate GetCurrentPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConvertTimeFormat)(interface IMediaSeeking * This, long *pTarget, const GUID *pTargetFormat, long Source, const GUID *pSourceFormat);
        public delegate int ConvertTimeFormatDelegate(@interface IMediaSeeking This, ref long pTarget, GUID pTargetFormat, long Source, GUID pSourceFormat);
        public ConvertTimeFormatDelegate ConvertTimeFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetPositions)(interface IMediaSeeking * This, long *pCurrent, uint dwCurrentFlags, long *pStop, uint dwStopFlags);
        public delegate int SetPositionsDelegate(@interface IMediaSeeking This, ref long pCurrent, uint dwCurrentFlags, ref long pStop, uint dwStopFlags);
        public SetPositionsDelegate SetPositions;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPositions)(interface IMediaSeeking * This, long *pCurrent, long *pStop);
        public delegate int GetPositionsDelegate(@interface IMediaSeeking This, ref long pCurrent, ref long pStop);
        public GetPositionsDelegate GetPositions;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailable)(interface IMediaSeeking * This, long *pEarliest, long *pLatest);
        public delegate int GetAvailableDelegate(@interface IMediaSeeking This, ref long pEarliest, ref long pLatest);
        public GetAvailableDelegate GetAvailable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRate)(interface IMediaSeeking * This, double dRate);
        public delegate int SetRateDelegate(@interface IMediaSeeking This, double dRate);
        public SetRateDelegate SetRate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRate)(interface IMediaSeeking * This, double *pdRate);
        public delegate int GetRateDelegate(@interface IMediaSeeking This, ref double pdRate);
        public GetRateDelegate GetRate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPreroll)(interface IMediaSeeking * This, long *pllPreroll);
        public delegate int GetPrerollDelegate(@interface IMediaSeeking This, ref long pllPreroll);
        public GetPrerollDelegate GetPreroll;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0130 */
/* [local] */ 


public enum tagAM_MEDIAEVENT_FLAGS
{
    AM_MEDIAEVENT_NONOTIFY = 0x01
}
























































public class __MIDL___MIDL_itf_strmif_0130_0001
{
    public CLSID Clsid = new CLSID();
    public string Name;
}

#else // C style interface

    public class IEnumRegFiltersVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumRegFilters * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumRegFilters This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumRegFilters * This);
        public delegate uint AddRefDelegate(@interface IEnumRegFilters This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumRegFilters * This);
        public delegate uint ReleaseDelegate(@interface IEnumRegFilters This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumRegFilters * This, uint cFilters, __MIDL___MIDL_itf_strmif_0130_0001 **apRegFilter, uint *pcFetched);
        public delegate int NextDelegate(@interface IEnumRegFilters This, uint cFilters, __MIDL___MIDL_itf_strmif_0130_0001[] apRegFilter, ref uint pcFetched);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumRegFilters * This, uint cFilters);
        public delegate int SkipDelegate(@interface IEnumRegFilters This, uint cFilters);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumRegFilters * This);
        public delegate int ResetDelegate(@interface IEnumRegFilters This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumRegFilters * This, interface IEnumRegFilters **ppEnum);
        public delegate int CloneDelegate(@interface IEnumRegFilters This, @interface IEnumRegFilters[] ppEnum);
        public CloneDelegate Clone;

//        END_INTERFACE
    }


/* interface IFilterMapper */
/* [unique][uuid][object] */ 


public enum __MIDL_IFilterMapper_0001
{
        MERIT_PREFERRED = 0x800000,
    MERIT_NORMAL = 0x600000,
    MERIT_UNLIKELY = 0x400000,
    MERIT_DO_NOT_USE = 0x200000,
    MERIT_SW_COMPRESSOR = 0x100000,
    MERIT_HW_COMPRESSOR = 0x100050
}

#else // C style interface

    public class IFilterMapperVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterMapper * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterMapper This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterMapper * This);
        public delegate uint AddRefDelegate(@interface IFilterMapper This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterMapper * This);
        public delegate uint ReleaseDelegate(@interface IFilterMapper This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterFilter)(interface IFilterMapper * This, CLSID clsid, const char* Name, uint dwMerit);
        public delegate int RegisterFilterDelegate(@interface IFilterMapper This, CLSID clsid, string Name, uint dwMerit);
        public RegisterFilterDelegate RegisterFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterFilterInstance)(interface IFilterMapper * This, CLSID clsid, const char* Name, CLSID *MRId);
        public delegate int RegisterFilterInstanceDelegate(@interface IFilterMapper This, CLSID clsid, string Name, CLSID MRId);
        public RegisterFilterInstanceDelegate RegisterFilterInstance;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterPin)(interface IFilterMapper * This, CLSID Filter, const char* Name, bool bRendered, bool bOutput, bool bZero, bool bMany, CLSID ConnectsToFilter, const char* ConnectsToPin);
        public delegate int RegisterPinDelegate(@interface IFilterMapper This, CLSID Filter, string Name, bool bRendered, bool bOutput, bool bZero, bool bMany, CLSID ConnectsToFilter, string ConnectsToPin);
        public RegisterPinDelegate RegisterPin;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterPinType)(interface IFilterMapper * This, CLSID clsFilter, const char* strName, CLSID clsMajorType, CLSID clsSubType);
        public delegate int RegisterPinTypeDelegate(@interface IFilterMapper This, CLSID clsFilter, string strName, CLSID clsMajorType, CLSID clsSubType);
        public RegisterPinTypeDelegate RegisterPinType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnregisterFilter)(interface IFilterMapper * This, CLSID Filter);
        public delegate int UnregisterFilterDelegate(@interface IFilterMapper This, CLSID Filter);
        public UnregisterFilterDelegate UnregisterFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnregisterFilterInstance)(interface IFilterMapper * This, CLSID MRId);
        public delegate int UnregisterFilterInstanceDelegate(@interface IFilterMapper This, CLSID MRId);
        public UnregisterFilterInstanceDelegate UnregisterFilterInstance;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnregisterPin)(interface IFilterMapper * This, CLSID Filter, const char* Name);
        public delegate int UnregisterPinDelegate(@interface IFilterMapper This, CLSID Filter, string Name);
        public UnregisterPinDelegate UnregisterPin;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumMatchingFilters)(interface IFilterMapper * This, interface IEnumRegFilters **ppEnum, uint dwMerit, bool bInputNeeded, CLSID clsInMaj, CLSID clsInSub, bool bRender, bool bOututNeeded, CLSID clsOutMaj, CLSID clsOutSub);
        public delegate int EnumMatchingFiltersDelegate(@interface IFilterMapper This, @interface IEnumRegFilters[] ppEnum, uint dwMerit, bool bInputNeeded, CLSID clsInMaj, CLSID clsInSub, bool bRender, bool bOututNeeded, CLSID clsOutMaj, CLSID clsOutSub);
        public EnumMatchingFiltersDelegate EnumMatchingFilters;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0134 */
/* [local] */ 

public class __MIDL___MIDL_itf_strmif_0134_0001
{
    public readonly CLSID clsMajorType;
    public readonly CLSID clsMinorType;
}

public class __MIDL___MIDL_itf_strmif_0134_0002
{
    public string strName;
    public bool bRendered;
    public bool bOutput;
    public bool bZero;
    public bool bMany;
    public readonly CLSID clsConnectsToFilter;
    public readonly string strConnectsToPin;
    public uint nMediaTypes;
    public readonly __MIDL___MIDL_itf_strmif_0134_0001 lpMediaType;
}

public class __MIDL___MIDL_itf_strmif_0134_0003
{
    public CLSID clsMedium = new CLSID();
    public uint dw1;
    public uint dw2;
}


public enum __MIDL___MIDL_itf_strmif_0134_0004
{
        REG_PINFLAG_B_ZERO = 0x1,
    REG_PINFLAG_B_RENDERER = 0x2,
    REG_PINFLAG_B_MANY = 0x4,
    REG_PINFLAG_B_OUTPUT = 0x8
}
public class __MIDL___MIDL_itf_strmif_0134_0005
{
    public uint dwFlags;
    public uint cInstances;
    public uint nMediaTypes;
    /* [size_is] */
    public readonly __MIDL___MIDL_itf_strmif_0134_0001 lpMediaType;
    public uint nMediums;
    /* [size_is] */
    public readonly __MIDL___MIDL_itf_strmif_0134_0003 lpMedium;
    public readonly CLSID clsPinCategory;
}

public class __MIDL___MIDL_itf_strmif_0134_0006
{
    public uint dwVersion;
    public uint dwMerit;
    /* [switch_type][switch_is] */
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//        {
//  /* [case()] */
//        struct
//            {
//            uint cPins;
//  /* [size_is] */
//            const __MIDL___MIDL_itf_strmif_0134_0002 *rgPins;
//            }
//            ;
//  /* [case()] */
//        struct
//            {
//            uint cPins2;
//  /* [size_is] */
//            const __MIDL___MIDL_itf_strmif_0134_0005 *rgPins2;
//            }
//            ;
//  /* [default] */
//  /* Empty union arm */ 
//        }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//        ;
}

#else // C style interface

    public class IFilterMapper2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterMapper2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterMapper2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterMapper2 * This);
        public delegate uint AddRefDelegate(@interface IFilterMapper2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterMapper2 * This);
        public delegate uint ReleaseDelegate(@interface IFilterMapper2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateCategory)(interface IFilterMapper2 * This, REFCLSID clsidCategory, uint dwCategoryMerit, const char* Description);
        public delegate int CreateCategoryDelegate(@interface IFilterMapper2 This, REFCLSID clsidCategory, uint dwCategoryMerit, string Description);
        public CreateCategoryDelegate CreateCategory;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnregisterFilter)(interface IFilterMapper2 * This, const CLSID *pclsidCategory, const OLECHAR *szInstance, REFCLSID Filter);
        public delegate int UnregisterFilterDelegate(@interface IFilterMapper2 This, CLSID pclsidCategory, OLECHAR szInstance, REFCLSID Filter);
        public UnregisterFilterDelegate UnregisterFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterFilter)(interface IFilterMapper2 * This, REFCLSID clsidFilter, const char* Name, IMoniker **ppMoniker, const CLSID *pclsidCategory, const OLECHAR *szInstance, const __MIDL___MIDL_itf_strmif_0134_0006 *prf2);
        public delegate int RegisterFilterDelegate(@interface IFilterMapper2 This, REFCLSID clsidFilter, string Name, IMoniker[] ppMoniker, CLSID pclsidCategory, OLECHAR szInstance, __MIDL___MIDL_itf_strmif_0134_0006 prf2);
        public RegisterFilterDelegate RegisterFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumMatchingFilters)(interface IFilterMapper2 * This, IEnumMoniker **ppEnum, uint dwFlags, bool bExactMatch, uint dwMerit, bool bInputNeeded, uint cInputTypes, const GUID *pInputTypes, const __MIDL___MIDL_itf_strmif_0134_0003 *pMedIn, const CLSID *pPinCategoryIn, bool bRender, bool bOutputNeeded, uint cOutputTypes, const GUID *pOutputTypes, const __MIDL___MIDL_itf_strmif_0134_0003 *pMedOut, const CLSID *pPinCategoryOut);
        public delegate int EnumMatchingFiltersDelegate(@interface IFilterMapper2 This, IEnumMoniker[] ppEnum, uint dwFlags, bool bExactMatch, uint dwMerit, bool bInputNeeded, uint cInputTypes, GUID pInputTypes, __MIDL___MIDL_itf_strmif_0134_0003 pMedIn, CLSID pPinCategoryIn, bool bRender, bool bOutputNeeded, uint cOutputTypes, GUID pOutputTypes, __MIDL___MIDL_itf_strmif_0134_0003 pMedOut, CLSID pPinCategoryOut);
        public EnumMatchingFiltersDelegate EnumMatchingFilters;

//        END_INTERFACE
    }

#else // C style interface

    public class IFilterMapper3Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterMapper3 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterMapper3 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterMapper3 * This);
        public delegate uint AddRefDelegate(@interface IFilterMapper3 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterMapper3 * This);
        public delegate uint ReleaseDelegate(@interface IFilterMapper3 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateCategory)(interface IFilterMapper3 * This, REFCLSID clsidCategory, uint dwCategoryMerit, const char* Description);
        public delegate int CreateCategoryDelegate(@interface IFilterMapper3 This, REFCLSID clsidCategory, uint dwCategoryMerit, string Description);
        public CreateCategoryDelegate CreateCategory;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnregisterFilter)(interface IFilterMapper3 * This, const CLSID *pclsidCategory, const OLECHAR *szInstance, REFCLSID Filter);
        public delegate int UnregisterFilterDelegate(@interface IFilterMapper3 This, CLSID pclsidCategory, OLECHAR szInstance, REFCLSID Filter);
        public UnregisterFilterDelegate UnregisterFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterFilter)(interface IFilterMapper3 * This, REFCLSID clsidFilter, const char* Name, IMoniker **ppMoniker, const CLSID *pclsidCategory, const OLECHAR *szInstance, const __MIDL___MIDL_itf_strmif_0134_0006 *prf2);
        public delegate int RegisterFilterDelegate(@interface IFilterMapper3 This, REFCLSID clsidFilter, string Name, IMoniker[] ppMoniker, CLSID pclsidCategory, OLECHAR szInstance, __MIDL___MIDL_itf_strmif_0134_0006 prf2);
        public RegisterFilterDelegate RegisterFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumMatchingFilters)(interface IFilterMapper3 * This, IEnumMoniker **ppEnum, uint dwFlags, bool bExactMatch, uint dwMerit, bool bInputNeeded, uint cInputTypes, const GUID *pInputTypes, const __MIDL___MIDL_itf_strmif_0134_0003 *pMedIn, const CLSID *pPinCategoryIn, bool bRender, bool bOutputNeeded, uint cOutputTypes, const GUID *pOutputTypes, const __MIDL___MIDL_itf_strmif_0134_0003 *pMedOut, const CLSID *pPinCategoryOut);
        public delegate int EnumMatchingFiltersDelegate(@interface IFilterMapper3 This, IEnumMoniker[] ppEnum, uint dwFlags, bool bExactMatch, uint dwMerit, bool bInputNeeded, uint cInputTypes, GUID pInputTypes, __MIDL___MIDL_itf_strmif_0134_0003 pMedIn, CLSID pPinCategoryIn, bool bRender, bool bOutputNeeded, uint cOutputTypes, GUID pOutputTypes, __MIDL___MIDL_itf_strmif_0134_0003 pMedOut, CLSID pPinCategoryOut);
        public EnumMatchingFiltersDelegate EnumMatchingFilters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetICreateDevEnum)(interface IFilterMapper3 * This, interface ICreateDevEnum **ppEnum);
        public delegate int GetICreateDevEnumDelegate(@interface IFilterMapper3 This, @interface ICreateDevEnum[] ppEnum);
        public GetICreateDevEnumDelegate GetICreateDevEnum;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0137 */
/* [local] */ 

public enum tagQualityMessageType
{
        Famine = 0,
    Flood = Famine + 1
}

public class tagQuality
{
    public QualityMessageType Type = new QualityMessageType();
    public int Proportion;
    public long Late;
    public long TimeStamp;
}

#else // C style interface

    public class IQualityControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IQualityControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IQualityControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IQualityControl * This);
        public delegate uint AddRefDelegate(@interface IQualityControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IQualityControl * This);
        public delegate uint ReleaseDelegate(@interface IQualityControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Notify)(interface IQualityControl * This, interface IBaseFilter *pSelf, tagQuality q);
        public delegate int NotifyDelegate(@interface IQualityControl This, @interface IBaseFilter pSelf, tagQuality q);
        public NotifyDelegate Notify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSink)(interface IQualityControl * This, interface IQualityControl *piqc);
        public delegate int SetSinkDelegate(@interface IQualityControl This, @interface IQualityControl piqc);
        public SetSinkDelegate SetSink;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0138 */
/* [local] */ 


public enum __MIDL___MIDL_itf_strmif_0138_0001
{
        CK_NOCOLORKEY = 0,
    CK_INDEX = 0x1,
    CK_RGB = 0x2
}
public class tagCOLORKEY
{
    public uint KeyType;
    public uint PaletteIndex;
    public uint LowColorValue;
    public uint HighColorValue;
}


public enum __MIDL___MIDL_itf_strmif_0138_0002
{
        ADVISE_NONE = 0,
    ADVISE_CLIPPING = 0x1,
    ADVISE_PALETTE = 0x2,
    ADVISE_COLORKEY = 0x4,
    ADVISE_POSITION = 0x8,
    ADVISE_DISPLAY_CHANGE = 0x10
}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ADVISE_ALL ( ADVISE_CLIPPING | ADVISE_PALETTE | ADVISE_COLORKEY | ADVISE_POSITION )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ADVISE_ALL2 ( ADVISE_ALL | ADVISE_DISPLAY_CHANGE )

#if ! _WINGDI_
public class _RGNDATAHEADER
{
    public uint dwSize;
    public uint iType;
    public uint nCount;
    public uint nRgnSize;
    public RECT rcBound = new RECT();
}

public class _RGNDATA
{
    public _RGNDATAHEADER rdh = new _RGNDATAHEADER();
    public string Buffer = new string(new char[1]);
}

#endif

#else // C style interface

    public class IOverlayNotifyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IOverlayNotify * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IOverlayNotify This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IOverlayNotify * This);
        public delegate uint AddRefDelegate(@interface IOverlayNotify This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IOverlayNotify * This);
        public delegate uint ReleaseDelegate(@interface IOverlayNotify This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnPaletteChange)(interface IOverlayNotify * This, uint dwColors, const PALETTEENTRY *pPalette);
        public delegate int OnPaletteChangeDelegate(@interface IOverlayNotify This, uint dwColors, PALETTEENTRY pPalette);
        public OnPaletteChangeDelegate OnPaletteChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnClipChange)(interface IOverlayNotify * This, const RECT *pSourceRect, const RECT *pDestinationRect, const _RGNDATA *pRgnData);
        public delegate int OnClipChangeDelegate(@interface IOverlayNotify This, RECT pSourceRect, RECT pDestinationRect, _RGNDATA pRgnData);
        public OnClipChangeDelegate OnClipChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnColorKeyChange)(interface IOverlayNotify * This, const tagCOLORKEY *pColorKey);
        public delegate int OnColorKeyChangeDelegate(@interface IOverlayNotify This, tagCOLORKEY pColorKey);
        public OnColorKeyChangeDelegate OnColorKeyChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnPositionChange)(interface IOverlayNotify * This, const RECT *pSourceRect, const RECT *pDestinationRect);
        public delegate int OnPositionChangeDelegate(@interface IOverlayNotify This, RECT pSourceRect, RECT pDestinationRect);
        public OnPositionChangeDelegate OnPositionChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IOverlayNotify2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IOverlayNotify2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IOverlayNotify2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IOverlayNotify2 * This);
        public delegate uint AddRefDelegate(@interface IOverlayNotify2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IOverlayNotify2 * This);
        public delegate uint ReleaseDelegate(@interface IOverlayNotify2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnPaletteChange)(interface IOverlayNotify2 * This, uint dwColors, const PALETTEENTRY *pPalette);
        public delegate int OnPaletteChangeDelegate(@interface IOverlayNotify2 This, uint dwColors, PALETTEENTRY pPalette);
        public OnPaletteChangeDelegate OnPaletteChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnClipChange)(interface IOverlayNotify2 * This, const RECT *pSourceRect, const RECT *pDestinationRect, const _RGNDATA *pRgnData);
        public delegate int OnClipChangeDelegate(@interface IOverlayNotify2 This, RECT pSourceRect, RECT pDestinationRect, _RGNDATA pRgnData);
        public OnClipChangeDelegate OnClipChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnColorKeyChange)(interface IOverlayNotify2 * This, const tagCOLORKEY *pColorKey);
        public delegate int OnColorKeyChangeDelegate(@interface IOverlayNotify2 This, tagCOLORKEY pColorKey);
        public OnColorKeyChangeDelegate OnColorKeyChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnPositionChange)(interface IOverlayNotify2 * This, const RECT *pSourceRect, const RECT *pDestinationRect);
        public delegate int OnPositionChangeDelegate(@interface IOverlayNotify2 This, RECT pSourceRect, RECT pDestinationRect);
        public OnPositionChangeDelegate OnPositionChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnDisplayChange)(interface IOverlayNotify2 * This, System.IntPtr hMonitor);
        public delegate int OnDisplayChangeDelegate(@interface IOverlayNotify2 This, IntPtr hMonitor);
        public OnDisplayChangeDelegate OnDisplayChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IOverlayVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IOverlay * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IOverlay This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IOverlay * This);
        public delegate uint AddRefDelegate(@interface IOverlay This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IOverlay * This);
        public delegate uint ReleaseDelegate(@interface IOverlay This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPalette)(interface IOverlay * This, uint *pdwColors, PALETTEENTRY **ppPalette);
        public delegate int GetPaletteDelegate(@interface IOverlay This, ref uint pdwColors, PALETTEENTRY[] ppPalette);
        public GetPaletteDelegate GetPalette;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetPalette)(interface IOverlay * This, uint dwColors, PALETTEENTRY *pPalette);
        public delegate int SetPaletteDelegate(@interface IOverlay This, uint dwColors, PALETTEENTRY pPalette);
        public SetPaletteDelegate SetPalette;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultColorKey)(interface IOverlay * This, tagCOLORKEY *pColorKey);
        public delegate int GetDefaultColorKeyDelegate(@interface IOverlay This, tagCOLORKEY pColorKey);
        public GetDefaultColorKeyDelegate GetDefaultColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetColorKey)(interface IOverlay * This, tagCOLORKEY *pColorKey);
        public delegate int GetColorKeyDelegate(@interface IOverlay This, tagCOLORKEY pColorKey);
        public GetColorKeyDelegate GetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetColorKey)(interface IOverlay * This, tagCOLORKEY *pColorKey);
        public delegate int SetColorKeyDelegate(@interface IOverlay This, tagCOLORKEY pColorKey);
        public SetColorKeyDelegate SetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetWindowHandle)(interface IOverlay * This, System.IntPtr *pHwnd);
        public delegate int GetWindowHandleDelegate(@interface IOverlay This, IntPtr pHwnd);
        public GetWindowHandleDelegate GetWindowHandle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClipList)(interface IOverlay * This, RECT *pSourceRect, RECT *pDestinationRect, _RGNDATA **ppRgnData);
        public delegate int GetClipListDelegate(@interface IOverlay This, RECT pSourceRect, RECT pDestinationRect, _RGNDATA[] ppRgnData);
        public GetClipListDelegate GetClipList;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoPosition)(interface IOverlay * This, RECT *pSourceRect, RECT *pDestinationRect);
        public delegate int GetVideoPositionDelegate(@interface IOverlay This, RECT pSourceRect, RECT pDestinationRect);
        public GetVideoPositionDelegate GetVideoPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Advise)(interface IOverlay * This, interface IOverlayNotify *pOverlayNotify, uint dwInterests);
        public delegate int AdviseDelegate(@interface IOverlay This, @interface IOverlayNotify pOverlayNotify, uint dwInterests);
        public AdviseDelegate Advise;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Unadvise)(interface IOverlay * This);
        public delegate int UnadviseDelegate(@interface IOverlay This);
        public UnadviseDelegate Unadvise;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaEventSinkVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaEventSink * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaEventSink This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaEventSink * This);
        public delegate uint AddRefDelegate(@interface IMediaEventSink This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaEventSink * This);
        public delegate uint ReleaseDelegate(@interface IMediaEventSink This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Notify)(interface IMediaEventSink * This, int EventCode, System.IntPtr EventParam1, System.IntPtr EventParam2);
        public delegate int NotifyDelegate(@interface IMediaEventSink This, int EventCode, IntPtr EventParam1, IntPtr EventParam2);
        public NotifyDelegate Notify;

//        END_INTERFACE
    }

#else // C style interface

    public class IFileSourceFilterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFileSourceFilter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFileSourceFilter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFileSourceFilter * This);
        public delegate uint AddRefDelegate(@interface IFileSourceFilter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFileSourceFilter * This);
        public delegate uint ReleaseDelegate(@interface IFileSourceFilter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Load)(interface IFileSourceFilter * This, LPCOLESTR pszFileName, const _AMMediaType *pmt);
        public delegate int LoadDelegate(@interface IFileSourceFilter This, LPCOLESTR pszFileName, _AMMediaType pmt);
        public LoadDelegate Load;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurFile)(interface IFileSourceFilter * This, LPOLESTR *ppszFileName, _AMMediaType *pmt);
        public delegate int GetCurFileDelegate(@interface IFileSourceFilter This, LPOLESTR ppszFileName, _AMMediaType pmt);
        public GetCurFileDelegate GetCurFile;

//        END_INTERFACE
    }

#else // C style interface

    public class IFileSinkFilterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFileSinkFilter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFileSinkFilter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFileSinkFilter * This);
        public delegate uint AddRefDelegate(@interface IFileSinkFilter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFileSinkFilter * This);
        public delegate uint ReleaseDelegate(@interface IFileSinkFilter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFileName)(interface IFileSinkFilter * This, LPCOLESTR pszFileName, const _AMMediaType *pmt);
        public delegate int SetFileNameDelegate(@interface IFileSinkFilter This, LPCOLESTR pszFileName, _AMMediaType pmt);
        public SetFileNameDelegate SetFileName;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurFile)(interface IFileSinkFilter * This, LPOLESTR *ppszFileName, _AMMediaType *pmt);
        public delegate int GetCurFileDelegate(@interface IFileSinkFilter This, LPOLESTR ppszFileName, _AMMediaType pmt);
        public GetCurFileDelegate GetCurFile;

//        END_INTERFACE
    }

#else // C style interface

    public class IFileSinkFilter2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFileSinkFilter2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFileSinkFilter2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFileSinkFilter2 * This);
        public delegate uint AddRefDelegate(@interface IFileSinkFilter2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFileSinkFilter2 * This);
        public delegate uint ReleaseDelegate(@interface IFileSinkFilter2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFileName)(interface IFileSinkFilter2 * This, LPCOLESTR pszFileName, const _AMMediaType *pmt);
        public delegate int SetFileNameDelegate(@interface IFileSinkFilter2 This, LPCOLESTR pszFileName, _AMMediaType pmt);
        public SetFileNameDelegate SetFileName;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurFile)(interface IFileSinkFilter2 * This, LPOLESTR *ppszFileName, _AMMediaType *pmt);
        public delegate int GetCurFileDelegate(@interface IFileSinkFilter2 This, LPOLESTR ppszFileName, _AMMediaType pmt);
        public GetCurFileDelegate GetCurFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMode)(interface IFileSinkFilter2 * This, uint dwFlags);
        public delegate int SetModeDelegate(@interface IFileSinkFilter2 This, uint dwFlags);
        public SetModeDelegate SetMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMode)(interface IFileSinkFilter2 * This, uint *pdwFlags);
        public delegate int GetModeDelegate(@interface IFileSinkFilter2 This, ref uint pdwFlags);
        public GetModeDelegate GetMode;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0145 */
/* [local] */ 


public enum __MIDL___MIDL_itf_strmif_0145_0001
{
        AM_FILE_OVERWRITE = 0x1
}

#else // C style interface

    public class IGraphBuilderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IGraphBuilder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IGraphBuilder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IGraphBuilder * This);
        public delegate uint AddRefDelegate(@interface IGraphBuilder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IGraphBuilder * This);
        public delegate uint ReleaseDelegate(@interface IGraphBuilder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddFilter)(interface IGraphBuilder * This, interface IBaseFilter *pFilter, const char* pName);
        public delegate int AddFilterDelegate(@interface IGraphBuilder This, @interface IBaseFilter pFilter, string pName);
        public AddFilterDelegate AddFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveFilter)(interface IGraphBuilder * This, interface IBaseFilter *pFilter);
        public delegate int RemoveFilterDelegate(@interface IGraphBuilder This, @interface IBaseFilter pFilter);
        public RemoveFilterDelegate RemoveFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumFilters)(interface IGraphBuilder * This, interface IEnumFilters **ppEnum);
        public delegate int EnumFiltersDelegate(@interface IGraphBuilder This, @interface IEnumFilters[] ppEnum);
        public EnumFiltersDelegate EnumFilters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindFilterByName)(interface IGraphBuilder * This, const char* pName, interface IBaseFilter **ppFilter);
        public delegate int FindFilterByNameDelegate(@interface IGraphBuilder This, string pName, @interface IBaseFilter[] ppFilter);
        public FindFilterByNameDelegate FindFilterByName;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectDirect)(interface IGraphBuilder * This, interface IPin *ppinOut, interface IPin *ppinIn, const _AMMediaType *pmt);
        public delegate int ConnectDirectDelegate(@interface IGraphBuilder This, @interface IPin ppinOut, @interface IPin ppinIn, _AMMediaType pmt);
        public ConnectDirectDelegate ConnectDirect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reconnect)(interface IGraphBuilder * This, interface IPin *ppin);
        public delegate int ReconnectDelegate(@interface IGraphBuilder This, @interface IPin ppin);
        public ReconnectDelegate Reconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Disconnect)(interface IGraphBuilder * This, interface IPin *ppin);
        public delegate int DisconnectDelegate(@interface IGraphBuilder This, @interface IPin ppin);
        public DisconnectDelegate Disconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultSyncSource)(interface IGraphBuilder * This);
        public delegate int SetDefaultSyncSourceDelegate(@interface IGraphBuilder This);
        public SetDefaultSyncSourceDelegate SetDefaultSyncSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Connect)(interface IGraphBuilder * This, interface IPin *ppinOut, interface IPin *ppinIn);
        public delegate int ConnectDelegate(@interface IGraphBuilder This, @interface IPin ppinOut, @interface IPin ppinIn);
        public ConnectDelegate Connect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Render)(interface IGraphBuilder * This, interface IPin *ppinOut);
        public delegate int RenderDelegate(@interface IGraphBuilder This, @interface IPin ppinOut);
        public RenderDelegate Render;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderFile)(interface IGraphBuilder * This, const char* lpcwstrFile, const char* lpcwstrPlayList);
        public delegate int RenderFileDelegate(@interface IGraphBuilder This, string lpcwstrFile, string lpcwstrPlayList);
        public RenderFileDelegate RenderFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddSourceFilter)(interface IGraphBuilder * This, const char* lpcwstrFileName, const char* lpcwstrFilterName, interface IBaseFilter **ppFilter);
        public delegate int AddSourceFilterDelegate(@interface IGraphBuilder This, string lpcwstrFileName, string lpcwstrFilterName, @interface IBaseFilter[] ppFilter);
        public AddSourceFilterDelegate AddSourceFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetLogFile)(interface IGraphBuilder * This, System.IntPtr hFile);
        public delegate int SetLogFileDelegate(@interface IGraphBuilder This, IntPtr hFile);
        public SetLogFileDelegate SetLogFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Abort)(interface IGraphBuilder * This);
        public delegate int AbortDelegate(@interface IGraphBuilder This);
        public AbortDelegate Abort;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShouldOperationContinue)(interface IGraphBuilder * This);
        public delegate int ShouldOperationContinueDelegate(@interface IGraphBuilder This);
        public ShouldOperationContinueDelegate ShouldOperationContinue;

//        END_INTERFACE
    }

#else // C style interface

    public class ICaptureGraphBuilderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICaptureGraphBuilder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICaptureGraphBuilder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICaptureGraphBuilder * This);
        public delegate uint AddRefDelegate(@interface ICaptureGraphBuilder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICaptureGraphBuilder * This);
        public delegate uint ReleaseDelegate(@interface ICaptureGraphBuilder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFiltergraph)(interface ICaptureGraphBuilder * This, interface IGraphBuilder *pfg);
        public delegate int SetFiltergraphDelegate(@interface ICaptureGraphBuilder This, @interface IGraphBuilder pfg);
        public SetFiltergraphDelegate SetFiltergraph;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFiltergraph)(interface ICaptureGraphBuilder * This, interface IGraphBuilder **ppfg);
        public delegate int GetFiltergraphDelegate(@interface ICaptureGraphBuilder This, @interface IGraphBuilder[] ppfg);
        public GetFiltergraphDelegate GetFiltergraph;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputFileName)(interface ICaptureGraphBuilder * This, const GUID *pType, LPCOLESTR lpstrFile, interface IBaseFilter **ppf, interface IFileSinkFilter **ppSink);
        public delegate int SetOutputFileNameDelegate(@interface ICaptureGraphBuilder This, GUID pType, LPCOLESTR lpstrFile, @interface IBaseFilter[] ppf, @interface IFileSinkFilter[] ppSink);
        public SetOutputFileNameDelegate SetOutputFileName;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindInterface)(interface ICaptureGraphBuilder * This, const GUID *pCategory, interface IBaseFilter *pf, REFIID riid, object**ppint);
        public delegate int FindInterfaceDelegate(@interface ICaptureGraphBuilder This, GUID pCategory, @interface IBaseFilter pf, REFIID riid, object ppint[] UnnamedParameter);
        public FindInterfaceDelegate FindInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderStream)(interface ICaptureGraphBuilder * This, const GUID *pCategory, IUnknown *pSource, interface IBaseFilter *pfCompressor, interface IBaseFilter *pfRenderer);
        public delegate int RenderStreamDelegate(@interface ICaptureGraphBuilder This, GUID pCategory, IUnknown pSource, @interface IBaseFilter pfCompressor, @interface IBaseFilter pfRenderer);
        public RenderStreamDelegate RenderStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ControlStream)(interface ICaptureGraphBuilder * This, const GUID *pCategory, interface IBaseFilter *pFilter, long *pstart, long *pstop, ushort wStartCookie, ushort wStopCookie);
        public delegate int ControlStreamDelegate(@interface ICaptureGraphBuilder This, GUID pCategory, @interface IBaseFilter pFilter, ref long pstart, ref long pstop, ushort wStartCookie, ushort wStopCookie);
        public ControlStreamDelegate ControlStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocCapFile)(interface ICaptureGraphBuilder * This, LPCOLESTR lpstr, ulong dwlSize);
        public delegate int AllocCapFileDelegate(@interface ICaptureGraphBuilder This, LPCOLESTR lpstr, ulong dwlSize);
        public AllocCapFileDelegate AllocCapFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CopyCaptureFile)(interface ICaptureGraphBuilder * This, LPOLESTR lpwstrOld, LPOLESTR lpwstrNew, int fAllowEscAbort, interface IAMCopyCaptureFileProgress *pCallback);
        public delegate int CopyCaptureFileDelegate(@interface ICaptureGraphBuilder This, LPOLESTR lpwstrOld, LPOLESTR lpwstrNew, int fAllowEscAbort, @interface IAMCopyCaptureFileProgress pCallback);
        public CopyCaptureFileDelegate CopyCaptureFile;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMCopyCaptureFileProgressVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMCopyCaptureFileProgress * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMCopyCaptureFileProgress This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMCopyCaptureFileProgress * This);
        public delegate uint AddRefDelegate(@interface IAMCopyCaptureFileProgress This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMCopyCaptureFileProgress * This);
        public delegate uint ReleaseDelegate(@interface IAMCopyCaptureFileProgress This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Progress)(interface IAMCopyCaptureFileProgress * This, int iProgress);
        public delegate int ProgressDelegate(@interface IAMCopyCaptureFileProgress This, int iProgress);
        public ProgressDelegate Progress;

//        END_INTERFACE
    }

#else // C style interface

    public class ICaptureGraphBuilder2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICaptureGraphBuilder2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICaptureGraphBuilder2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICaptureGraphBuilder2 * This);
        public delegate uint AddRefDelegate(@interface ICaptureGraphBuilder2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICaptureGraphBuilder2 * This);
        public delegate uint ReleaseDelegate(@interface ICaptureGraphBuilder2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFiltergraph)(interface ICaptureGraphBuilder2 * This, interface IGraphBuilder *pfg);
        public delegate int SetFiltergraphDelegate(@interface ICaptureGraphBuilder2 This, @interface IGraphBuilder pfg);
        public SetFiltergraphDelegate SetFiltergraph;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFiltergraph)(interface ICaptureGraphBuilder2 * This, interface IGraphBuilder **ppfg);
        public delegate int GetFiltergraphDelegate(@interface ICaptureGraphBuilder2 This, @interface IGraphBuilder[] ppfg);
        public GetFiltergraphDelegate GetFiltergraph;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputFileName)(interface ICaptureGraphBuilder2 * This, const GUID *pType, LPCOLESTR lpstrFile, interface IBaseFilter **ppf, interface IFileSinkFilter **ppSink);
        public delegate int SetOutputFileNameDelegate(@interface ICaptureGraphBuilder2 This, GUID pType, LPCOLESTR lpstrFile, @interface IBaseFilter[] ppf, @interface IFileSinkFilter[] ppSink);
        public SetOutputFileNameDelegate SetOutputFileName;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindInterface)(interface ICaptureGraphBuilder2 * This, const GUID *pCategory, const GUID *pType, interface IBaseFilter *pf, REFIID riid, object**ppint);
        public delegate int FindInterfaceDelegate(@interface ICaptureGraphBuilder2 This, GUID pCategory, GUID pType, @interface IBaseFilter pf, REFIID riid, object ppint[] UnnamedParameter);
        public FindInterfaceDelegate FindInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderStream)(interface ICaptureGraphBuilder2 * This, const GUID *pCategory, const GUID *pType, IUnknown *pSource, interface IBaseFilter *pfCompressor, interface IBaseFilter *pfRenderer);
        public delegate int RenderStreamDelegate(@interface ICaptureGraphBuilder2 This, GUID pCategory, GUID pType, IUnknown pSource, @interface IBaseFilter pfCompressor, @interface IBaseFilter pfRenderer);
        public RenderStreamDelegate RenderStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ControlStream)(interface ICaptureGraphBuilder2 * This, const GUID *pCategory, const GUID *pType, interface IBaseFilter *pFilter, long *pstart, long *pstop, ushort wStartCookie, ushort wStopCookie);
        public delegate int ControlStreamDelegate(@interface ICaptureGraphBuilder2 This, GUID pCategory, GUID pType, @interface IBaseFilter pFilter, ref long pstart, ref long pstop, ushort wStartCookie, ushort wStopCookie);
        public ControlStreamDelegate ControlStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocCapFile)(interface ICaptureGraphBuilder2 * This, LPCOLESTR lpstr, ulong dwlSize);
        public delegate int AllocCapFileDelegate(@interface ICaptureGraphBuilder2 This, LPCOLESTR lpstr, ulong dwlSize);
        public AllocCapFileDelegate AllocCapFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CopyCaptureFile)(interface ICaptureGraphBuilder2 * This, LPOLESTR lpwstrOld, LPOLESTR lpwstrNew, int fAllowEscAbort, interface IAMCopyCaptureFileProgress *pCallback);
        public delegate int CopyCaptureFileDelegate(@interface ICaptureGraphBuilder2 This, LPOLESTR lpwstrOld, LPOLESTR lpwstrNew, int fAllowEscAbort, @interface IAMCopyCaptureFileProgress pCallback);
        public CopyCaptureFileDelegate CopyCaptureFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindPin)(interface ICaptureGraphBuilder2 * This, IUnknown *pSource, PIN_DIRECTION pindir, const GUID *pCategory, const GUID *pType, bool fUnconnected, int num, interface IPin **ppPin);
        public delegate int FindPinDelegate(@interface ICaptureGraphBuilder2 This, IUnknown pSource, PIN_DIRECTION pindir, GUID pCategory, GUID pType, bool fUnconnected, int num, @interface IPin[] ppPin);
        public FindPinDelegate FindPin;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0149 */
/* [local] */ 


public enum _AM_RENSDEREXFLAGS
{
        AM_RENDEREX_RENDERTOEXISTINGRENDERERS = 0x1
}

#else // C style interface

    public class IFilterGraph2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterGraph2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterGraph2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterGraph2 * This);
        public delegate uint AddRefDelegate(@interface IFilterGraph2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterGraph2 * This);
        public delegate uint ReleaseDelegate(@interface IFilterGraph2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddFilter)(interface IFilterGraph2 * This, interface IBaseFilter *pFilter, const char* pName);
        public delegate int AddFilterDelegate(@interface IFilterGraph2 This, @interface IBaseFilter pFilter, string pName);
        public AddFilterDelegate AddFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveFilter)(interface IFilterGraph2 * This, interface IBaseFilter *pFilter);
        public delegate int RemoveFilterDelegate(@interface IFilterGraph2 This, @interface IBaseFilter pFilter);
        public RemoveFilterDelegate RemoveFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumFilters)(interface IFilterGraph2 * This, interface IEnumFilters **ppEnum);
        public delegate int EnumFiltersDelegate(@interface IFilterGraph2 This, @interface IEnumFilters[] ppEnum);
        public EnumFiltersDelegate EnumFilters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindFilterByName)(interface IFilterGraph2 * This, const char* pName, interface IBaseFilter **ppFilter);
        public delegate int FindFilterByNameDelegate(@interface IFilterGraph2 This, string pName, @interface IBaseFilter[] ppFilter);
        public FindFilterByNameDelegate FindFilterByName;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectDirect)(interface IFilterGraph2 * This, interface IPin *ppinOut, interface IPin *ppinIn, const _AMMediaType *pmt);
        public delegate int ConnectDirectDelegate(@interface IFilterGraph2 This, @interface IPin ppinOut, @interface IPin ppinIn, _AMMediaType pmt);
        public ConnectDirectDelegate ConnectDirect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reconnect)(interface IFilterGraph2 * This, interface IPin *ppin);
        public delegate int ReconnectDelegate(@interface IFilterGraph2 This, @interface IPin ppin);
        public ReconnectDelegate Reconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Disconnect)(interface IFilterGraph2 * This, interface IPin *ppin);
        public delegate int DisconnectDelegate(@interface IFilterGraph2 This, @interface IPin ppin);
        public DisconnectDelegate Disconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultSyncSource)(interface IFilterGraph2 * This);
        public delegate int SetDefaultSyncSourceDelegate(@interface IFilterGraph2 This);
        public SetDefaultSyncSourceDelegate SetDefaultSyncSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Connect)(interface IFilterGraph2 * This, interface IPin *ppinOut, interface IPin *ppinIn);
        public delegate int ConnectDelegate(@interface IFilterGraph2 This, @interface IPin ppinOut, @interface IPin ppinIn);
        public ConnectDelegate Connect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Render)(interface IFilterGraph2 * This, interface IPin *ppinOut);
        public delegate int RenderDelegate(@interface IFilterGraph2 This, @interface IPin ppinOut);
        public RenderDelegate Render;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderFile)(interface IFilterGraph2 * This, const char* lpcwstrFile, const char* lpcwstrPlayList);
        public delegate int RenderFileDelegate(@interface IFilterGraph2 This, string lpcwstrFile, string lpcwstrPlayList);
        public RenderFileDelegate RenderFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddSourceFilter)(interface IFilterGraph2 * This, const char* lpcwstrFileName, const char* lpcwstrFilterName, interface IBaseFilter **ppFilter);
        public delegate int AddSourceFilterDelegate(@interface IFilterGraph2 This, string lpcwstrFileName, string lpcwstrFilterName, @interface IBaseFilter[] ppFilter);
        public AddSourceFilterDelegate AddSourceFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetLogFile)(interface IFilterGraph2 * This, System.IntPtr hFile);
        public delegate int SetLogFileDelegate(@interface IFilterGraph2 This, IntPtr hFile);
        public SetLogFileDelegate SetLogFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Abort)(interface IFilterGraph2 * This);
        public delegate int AbortDelegate(@interface IFilterGraph2 This);
        public AbortDelegate Abort;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShouldOperationContinue)(interface IFilterGraph2 * This);
        public delegate int ShouldOperationContinueDelegate(@interface IFilterGraph2 This);
        public ShouldOperationContinueDelegate ShouldOperationContinue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddSourceFilterForMoniker)(interface IFilterGraph2 * This, IMoniker *pMoniker, IBindCtx *pCtx, const char* lpcwstrFilterName, interface IBaseFilter **ppFilter);
        public delegate int AddSourceFilterForMonikerDelegate(@interface IFilterGraph2 This, IMoniker pMoniker, IBindCtx pCtx, string lpcwstrFilterName, @interface IBaseFilter[] ppFilter);
        public AddSourceFilterForMonikerDelegate AddSourceFilterForMoniker;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReconnectEx)(interface IFilterGraph2 * This, interface IPin *ppin, const _AMMediaType *pmt);
        public delegate int ReconnectExDelegate(@interface IFilterGraph2 This, @interface IPin ppin, _AMMediaType pmt);
        public ReconnectExDelegate ReconnectEx;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderEx)(interface IFilterGraph2 * This, interface IPin *pPinOut, uint dwFlags, uint *pvContext);
        public delegate int RenderExDelegate(@interface IFilterGraph2 This, @interface IPin pPinOut, uint dwFlags, ref uint pvContext);
        public RenderExDelegate RenderEx;

//        END_INTERFACE
    }

#else // C style interface

    public class IStreamBuilderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IStreamBuilder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IStreamBuilder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IStreamBuilder * This);
        public delegate uint AddRefDelegate(@interface IStreamBuilder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IStreamBuilder * This);
        public delegate uint ReleaseDelegate(@interface IStreamBuilder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Render)(interface IStreamBuilder * This, interface IPin *ppinOut, interface IGraphBuilder *pGraph);
        public delegate int RenderDelegate(@interface IStreamBuilder This, @interface IPin ppinOut, @interface IGraphBuilder pGraph);
        public RenderDelegate Render;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Backout)(interface IStreamBuilder * This, interface IPin *ppinOut, interface IGraphBuilder *pGraph);
        public delegate int BackoutDelegate(@interface IStreamBuilder This, @interface IPin ppinOut, @interface IGraphBuilder pGraph);
        public BackoutDelegate Backout;

//        END_INTERFACE
    }

#else // C style interface

    public class IAsyncReaderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAsyncReader * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAsyncReader This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAsyncReader * This);
        public delegate uint AddRefDelegate(@interface IAsyncReader This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAsyncReader * This);
        public delegate uint ReleaseDelegate(@interface IAsyncReader This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RequestAllocator)(interface IAsyncReader * This, interface IMemAllocator *pPreferred, _AllocatorProperties *pProps, interface IMemAllocator **ppActual);
        public delegate int RequestAllocatorDelegate(@interface IAsyncReader This, @interface IMemAllocator pPreferred, _AllocatorProperties pProps, @interface IMemAllocator[] ppActual);
        public RequestAllocatorDelegate RequestAllocator;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Request)(interface IAsyncReader * This, interface IMediaSample *pSample, System.IntPtr dwUser);
        public delegate int RequestDelegate(@interface IAsyncReader This, @interface IMediaSample pSample, IntPtr dwUser);
        public RequestDelegate Request;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WaitForNext)(interface IAsyncReader * This, uint dwTimeout, interface IMediaSample **ppSample, System.IntPtr *pdwUser);
        public delegate int WaitForNextDelegate(@interface IAsyncReader This, uint dwTimeout, @interface IMediaSample[] ppSample, IntPtr pdwUser);
        public WaitForNextDelegate WaitForNext;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SyncReadAligned)(interface IAsyncReader * This, interface IMediaSample *pSample);
        public delegate int SyncReadAlignedDelegate(@interface IAsyncReader This, @interface IMediaSample pSample);
        public SyncReadAlignedDelegate SyncReadAligned;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SyncRead)(interface IAsyncReader * This, long llPosition, int lLength, byte *pBuffer);
        public delegate int SyncReadDelegate(@interface IAsyncReader This, long llPosition, int lLength, ref byte pBuffer);
        public SyncReadDelegate SyncRead;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Length)(interface IAsyncReader * This, long *pTotal, long *pAvailable);
        public delegate int LengthDelegate(@interface IAsyncReader This, ref long pTotal, ref long pAvailable);
        public LengthDelegate Length;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *BeginFlush)(interface IAsyncReader * This);
        public delegate int BeginFlushDelegate(@interface IAsyncReader This);
        public BeginFlushDelegate BeginFlush;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EndFlush)(interface IAsyncReader * This);
        public delegate int EndFlushDelegate(@interface IAsyncReader This);
        public EndFlushDelegate EndFlush;

//        END_INTERFACE
    }

#else // C style interface

    public class IGraphVersionVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IGraphVersion * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IGraphVersion This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IGraphVersion * This);
        public delegate uint AddRefDelegate(@interface IGraphVersion This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IGraphVersion * This);
        public delegate uint ReleaseDelegate(@interface IGraphVersion This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryVersion)(interface IGraphVersion * This, int *pVersion);
        public delegate int QueryVersionDelegate(@interface IGraphVersion This, ref int pVersion);
        public QueryVersionDelegate QueryVersion;

//        END_INTERFACE
    }

#else // C style interface

    public class IResourceConsumerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IResourceConsumer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IResourceConsumer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IResourceConsumer * This);
        public delegate uint AddRefDelegate(@interface IResourceConsumer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IResourceConsumer * This);
        public delegate uint ReleaseDelegate(@interface IResourceConsumer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AcquireResource)(interface IResourceConsumer * This, int idResource);
        public delegate int AcquireResourceDelegate(@interface IResourceConsumer This, int idResource);
        public AcquireResourceDelegate AcquireResource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReleaseResource)(interface IResourceConsumer * This, int idResource);
        public delegate int ReleaseResourceDelegate(@interface IResourceConsumer This, int idResource);
        public ReleaseResourceDelegate ReleaseResource;

//        END_INTERFACE
    }

#else // C style interface

    public class IResourceManagerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IResourceManager * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IResourceManager This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IResourceManager * This);
        public delegate uint AddRefDelegate(@interface IResourceManager This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IResourceManager * This);
        public delegate uint ReleaseDelegate(@interface IResourceManager This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Register)(interface IResourceManager * This, const char* pName, int cResource, int *plToken);
        public delegate int RegisterDelegate(@interface IResourceManager This, string pName, int cResource, ref int plToken);
        public RegisterDelegate Register;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterGroup)(interface IResourceManager * This, const char* pName, int cResource, int *palTokens, int *plToken);
        public delegate int RegisterGroupDelegate(@interface IResourceManager This, string pName, int cResource, ref int palTokens, ref int plToken);
        public RegisterGroupDelegate RegisterGroup;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RequestResource)(interface IResourceManager * This, int idResource, IUnknown *pFocusObject, interface IResourceConsumer *pConsumer);
        public delegate int RequestResourceDelegate(@interface IResourceManager This, int idResource, IUnknown pFocusObject, @interface IResourceConsumer pConsumer);
        public RequestResourceDelegate RequestResource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyAcquire)(interface IResourceManager * This, int idResource, interface IResourceConsumer *pConsumer, int hr);
        public delegate int NotifyAcquireDelegate(@interface IResourceManager This, int idResource, @interface IResourceConsumer pConsumer, int hr);
        public NotifyAcquireDelegate NotifyAcquire;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyRelease)(interface IResourceManager * This, int idResource, interface IResourceConsumer *pConsumer, bool bStillWant);
        public delegate int NotifyReleaseDelegate(@interface IResourceManager This, int idResource, @interface IResourceConsumer pConsumer, bool bStillWant);
        public NotifyReleaseDelegate NotifyRelease;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CancelRequest)(interface IResourceManager * This, int idResource, interface IResourceConsumer *pConsumer);
        public delegate int CancelRequestDelegate(@interface IResourceManager This, int idResource, @interface IResourceConsumer pConsumer);
        public CancelRequestDelegate CancelRequest;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFocus)(interface IResourceManager * This, IUnknown *pFocusObject);
        public delegate int SetFocusDelegate(@interface IResourceManager This, IUnknown pFocusObject);
        public SetFocusDelegate SetFocus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReleaseFocus)(interface IResourceManager * This, IUnknown *pFocusObject);
        public delegate int ReleaseFocusDelegate(@interface IResourceManager This, IUnknown pFocusObject);
        public ReleaseFocusDelegate ReleaseFocus;

//        END_INTERFACE
    }

#else // C style interface

    public class IDistributorNotifyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDistributorNotify * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDistributorNotify This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDistributorNotify * This);
        public delegate uint AddRefDelegate(@interface IDistributorNotify This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDistributorNotify * This);
        public delegate uint ReleaseDelegate(@interface IDistributorNotify This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IDistributorNotify * This);
        public delegate int StopDelegate(@interface IDistributorNotify This);
        public StopDelegate Stop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IDistributorNotify * This);
        public delegate int PauseDelegate(@interface IDistributorNotify This);
        public PauseDelegate Pause;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IDistributorNotify * This, long tStart);
        public delegate int RunDelegate(@interface IDistributorNotify This, long tStart);
        public RunDelegate Run;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSyncSource)(interface IDistributorNotify * This, interface IReferenceClock *pClock);
        public delegate int SetSyncSourceDelegate(@interface IDistributorNotify This, @interface IReferenceClock pClock);
        public SetSyncSourceDelegate SetSyncSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyGraphChange)(interface IDistributorNotify * This);
        public delegate int NotifyGraphChangeDelegate(@interface IDistributorNotify This);
        public NotifyGraphChangeDelegate NotifyGraphChange;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0156 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0156_0001
{
        AM_STREAM_INFO_START_DEFINED = 0x1,
    AM_STREAM_INFO_STOP_DEFINED = 0x2,
    AM_STREAM_INFO_DISCARDING = 0x4,
    AM_STREAM_INFO_STOP_SEND_EXTRA = 0x10
}

public class __MIDL___MIDL_itf_strmif_0156_0002
{
    public long tStart;
    public long tStop;
    public uint dwStartCookie;
    public uint dwStopCookie;
    public uint dwFlags;
}

#else // C style interface

    public class IAMStreamControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMStreamControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMStreamControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMStreamControl * This);
        public delegate uint AddRefDelegate(@interface IAMStreamControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMStreamControl * This);
        public delegate uint ReleaseDelegate(@interface IAMStreamControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StartAt)(interface IAMStreamControl * This, const long *ptStart, uint dwCookie);
        public delegate int StartAtDelegate(@interface IAMStreamControl This, long ptStart, uint dwCookie);
        public StartAtDelegate StartAt;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StopAt)(interface IAMStreamControl * This, const long *ptStop, bool bSendExtra, uint dwCookie);
        public delegate int StopAtDelegate(@interface IAMStreamControl This, long ptStop, bool bSendExtra, uint dwCookie);
        public StopAtDelegate StopAt;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInfo)(interface IAMStreamControl * This, __MIDL___MIDL_itf_strmif_0156_0002 *pInfo);
        public delegate int GetInfoDelegate(@interface IAMStreamControl This, __MIDL___MIDL_itf_strmif_0156_0002 pInfo);
        public GetInfoDelegate GetInfo;

//        END_INTERFACE
    }

#else // C style interface

    public class ISeekingPassThruVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ISeekingPassThru * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ISeekingPassThru This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ISeekingPassThru * This);
        public delegate uint AddRefDelegate(@interface ISeekingPassThru This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ISeekingPassThru * This);
        public delegate uint ReleaseDelegate(@interface ISeekingPassThru This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Init)(interface ISeekingPassThru * This, bool bSupportRendering, interface IPin *pPin);
        public delegate int InitDelegate(@interface ISeekingPassThru This, bool bSupportRendering, @interface IPin pPin);
        public InitDelegate Init;

//        END_INTERFACE
    }






/* interface IAMStreamConfig */
/* [unique][uuid][object] */ 

public class _VIDEO_STREAM_CONFIG_CAPS
{
    public GUID guid = new GUID();
    public uint VideoStandard;
    public SIZE InputSize = new SIZE();
    public SIZE MinCroppingSize = new SIZE();
    public SIZE MaxCroppingSize = new SIZE();
    public int CropGranularityX;
    public int CropGranularityY;
    public int CropAlignX;
    public int CropAlignY;
    public SIZE MinOutputSize = new SIZE();
    public SIZE MaxOutputSize = new SIZE();
    public int OutputGranularityX;
    public int OutputGranularityY;
    public int StretchTapsX;
    public int StretchTapsY;
    public int ShrinkTapsX;
    public int ShrinkTapsY;
    public long MinFrameInterval;
    public long MaxFrameInterval;
    public int MinBitsPerSecond;
    public int MaxBitsPerSecond;
}

public class _AUDIO_STREAM_CONFIG_CAPS
{
    public GUID guid = new GUID();
    public uint MinimumChannels;
    public uint MaximumChannels;
    public uint ChannelsGranularity;
    public uint MinimumBitsPerSample;
    public uint MaximumBitsPerSample;
    public uint BitsPerSampleGranularity;
    public uint MinimumSampleFrequency;
    public uint MaximumSampleFrequency;
    public uint SampleFrequencyGranularity;
}

#else // C style interface

    public class IAMStreamConfigVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMStreamConfig * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMStreamConfig This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMStreamConfig * This);
        public delegate uint AddRefDelegate(@interface IAMStreamConfig This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMStreamConfig * This);
        public delegate uint ReleaseDelegate(@interface IAMStreamConfig This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFormat)(interface IAMStreamConfig * This, _AMMediaType *pmt);
        public delegate int SetFormatDelegate(@interface IAMStreamConfig This, _AMMediaType pmt);
        public SetFormatDelegate SetFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFormat)(interface IAMStreamConfig * This, _AMMediaType **ppmt);
        public delegate int GetFormatDelegate(@interface IAMStreamConfig This, _AMMediaType[] ppmt);
        public GetFormatDelegate GetFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfCapabilities)(interface IAMStreamConfig * This, int *piCount, int *piSize);
        public delegate int GetNumberOfCapabilitiesDelegate(@interface IAMStreamConfig This, ref int piCount, ref int piSize);
        public GetNumberOfCapabilitiesDelegate GetNumberOfCapabilities;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStreamCaps)(interface IAMStreamConfig * This, int iIndex, _AMMediaType **ppmt, byte *pSCC);
        public delegate int GetStreamCapsDelegate(@interface IAMStreamConfig This, int iIndex, _AMMediaType[] ppmt, ref byte pSCC);
        public GetStreamCapsDelegate GetStreamCaps;

//        END_INTERFACE
    }






/* interface IConfigInterleaving */
/* [unique][uuid][object] */ 

public enum __MIDL_IConfigInterleaving_0001
{
        INTERLEAVE_NONE = 0,
    INTERLEAVE_CAPTURE = INTERLEAVE_NONE + 1,
    INTERLEAVE_FULL = INTERLEAVE_CAPTURE + 1,
    INTERLEAVE_NONE_BUFFERED = INTERLEAVE_FULL + 1
}

#else // C style interface

    public class IConfigInterleavingVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IConfigInterleaving * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IConfigInterleaving This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IConfigInterleaving * This);
        public delegate uint AddRefDelegate(@interface IConfigInterleaving This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IConfigInterleaving * This);
        public delegate uint ReleaseDelegate(@interface IConfigInterleaving This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Mode)(interface IConfigInterleaving * This, InterleavingMode mode);
        public delegate int put_ModeDelegate(@interface IConfigInterleaving This, InterleavingMode mode);
        public put_ModeDelegate put_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Mode)(interface IConfigInterleaving * This, InterleavingMode *pMode);
        public delegate int get_ModeDelegate(@interface IConfigInterleaving This, InterleavingMode pMode);
        public get_ModeDelegate get_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Interleaving)(interface IConfigInterleaving * This, const long *prtInterleave, const long *prtPreroll);
        public delegate int put_InterleavingDelegate(@interface IConfigInterleaving This, long prtInterleave, long prtPreroll);
        public put_InterleavingDelegate put_Interleaving;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Interleaving)(interface IConfigInterleaving * This, long *prtInterleave, long *prtPreroll);
        public delegate int get_InterleavingDelegate(@interface IConfigInterleaving This, ref long prtInterleave, ref long prtPreroll);
        public get_InterleavingDelegate get_Interleaving;

//        END_INTERFACE
    }

#else // C style interface

    public class IConfigAviMuxVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IConfigAviMux * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IConfigAviMux This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IConfigAviMux * This);
        public delegate uint AddRefDelegate(@interface IConfigAviMux This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IConfigAviMux * This);
        public delegate uint ReleaseDelegate(@interface IConfigAviMux This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMasterStream)(interface IConfigAviMux * This, int iStream);
        public delegate int SetMasterStreamDelegate(@interface IConfigAviMux This, int iStream);
        public SetMasterStreamDelegate SetMasterStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMasterStream)(interface IConfigAviMux * This, int *pStream);
        public delegate int GetMasterStreamDelegate(@interface IConfigAviMux This, ref int pStream);
        public GetMasterStreamDelegate GetMasterStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputCompatibilityIndex)(interface IConfigAviMux * This, bool fOldIndex);
        public delegate int SetOutputCompatibilityIndexDelegate(@interface IConfigAviMux This, bool fOldIndex);
        public SetOutputCompatibilityIndexDelegate SetOutputCompatibilityIndex;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputCompatibilityIndex)(interface IConfigAviMux * This, bool *pfOldIndex);
        public delegate int GetOutputCompatibilityIndexDelegate(@interface IConfigAviMux This, ref bool pfOldIndex);
        public GetOutputCompatibilityIndexDelegate GetOutputCompatibilityIndex;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0163 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0163_0001
{
        CompressionCaps_CanQuality = 0x1,
    CompressionCaps_CanCrunch = 0x2,
    CompressionCaps_CanKeyFrame = 0x4,
    CompressionCaps_CanBFrame = 0x8,
    CompressionCaps_CanWindow = 0x10
}

#else // C style interface

    public class IAMVideoCompressionVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVideoCompression * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVideoCompression This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVideoCompression * This);
        public delegate uint AddRefDelegate(@interface IAMVideoCompression This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVideoCompression * This);
        public delegate uint ReleaseDelegate(@interface IAMVideoCompression This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_KeyFrameRate)(interface IAMVideoCompression * This, int KeyFrameRate);
        public delegate int put_KeyFrameRateDelegate(@interface IAMVideoCompression This, int KeyFrameRate);
        public put_KeyFrameRateDelegate put_KeyFrameRate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_KeyFrameRate)(interface IAMVideoCompression * This, int *pKeyFrameRate);
        public delegate int get_KeyFrameRateDelegate(@interface IAMVideoCompression This, ref int pKeyFrameRate);
        public get_KeyFrameRateDelegate get_KeyFrameRate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_PFramesPerKeyFrame)(interface IAMVideoCompression * This, int PFramesPerKeyFrame);
        public delegate int put_PFramesPerKeyFrameDelegate(@interface IAMVideoCompression This, int PFramesPerKeyFrame);
        public put_PFramesPerKeyFrameDelegate put_PFramesPerKeyFrame;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PFramesPerKeyFrame)(interface IAMVideoCompression * This, int *pPFramesPerKeyFrame);
        public delegate int get_PFramesPerKeyFrameDelegate(@interface IAMVideoCompression This, ref int pPFramesPerKeyFrame);
        public get_PFramesPerKeyFrameDelegate get_PFramesPerKeyFrame;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Quality)(interface IAMVideoCompression * This, double tagQuality);
        public delegate int put_QualityDelegate(@interface IAMVideoCompression This, double tagQuality);
        public put_QualityDelegate put_Quality;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Quality)(interface IAMVideoCompression * This, double *pQuality);
        public delegate int get_QualityDelegate(@interface IAMVideoCompression This, ref double pQuality);
        public get_QualityDelegate get_Quality;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_WindowSize)(interface IAMVideoCompression * This, ulong WindowSize);
        public delegate int put_WindowSizeDelegate(@interface IAMVideoCompression This, ulong WindowSize);
        public put_WindowSizeDelegate put_WindowSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_WindowSize)(interface IAMVideoCompression * This, ulong *pWindowSize);
        public delegate int get_WindowSizeDelegate(@interface IAMVideoCompression This, ref ulong pWindowSize);
        public get_WindowSizeDelegate get_WindowSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInfo)(interface IAMVideoCompression * This, char *pszVersion, int *pcbVersion, char* pszDescription, int *pcbDescription, int *pDefaultKeyFrameRate, int *pDefaultPFramesPerKey, double *pDefaultQuality, int *pCapabilities);
        public delegate int GetInfoDelegate(@interface IAMVideoCompression This, ref string pszVersion, ref int pcbVersion, ref string pszDescription, ref int pcbDescription, ref int pDefaultKeyFrameRate, ref int pDefaultPFramesPerKey, ref double pDefaultQuality, ref int pCapabilities);
        public GetInfoDelegate GetInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OverrideKeyFrame)(interface IAMVideoCompression * This, int FrameNumber);
        public delegate int OverrideKeyFrameDelegate(@interface IAMVideoCompression This, int FrameNumber);
        public OverrideKeyFrameDelegate OverrideKeyFrame;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OverrideFrameSize)(interface IAMVideoCompression * This, int FrameNumber, int Size);
        public delegate int OverrideFrameSizeDelegate(@interface IAMVideoCompression This, int FrameNumber, int Size);
        public OverrideFrameSizeDelegate OverrideFrameSize;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0164 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0164_0001
{
        VfwCaptureDialog_Source = 0x1,
    VfwCaptureDialog_Format = 0x2,
    VfwCaptureDialog_Display = 0x4
}

public enum __MIDL___MIDL_itf_strmif_0164_0002
{
        VfwCompressDialog_Config = 0x1,
    VfwCompressDialog_About = 0x2,
    VfwCompressDialog_QueryConfig = 0x4,
    VfwCompressDialog_QueryAbout = 0x8
}

#else // C style interface

    public class IAMVfwCaptureDialogsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVfwCaptureDialogs * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVfwCaptureDialogs This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVfwCaptureDialogs * This);
        public delegate uint AddRefDelegate(@interface IAMVfwCaptureDialogs This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVfwCaptureDialogs * This);
        public delegate uint ReleaseDelegate(@interface IAMVfwCaptureDialogs This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *HasDialog)(interface IAMVfwCaptureDialogs * This, int iDialog);
        public delegate int HasDialogDelegate(@interface IAMVfwCaptureDialogs This, int iDialog);
        public HasDialogDelegate HasDialog;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShowDialog)(interface IAMVfwCaptureDialogs * This, int iDialog, System.IntPtr hwnd);
        public delegate int ShowDialogDelegate(@interface IAMVfwCaptureDialogs This, int iDialog, IntPtr hwnd);
        public ShowDialogDelegate ShowDialog;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SendDriverMessage)(interface IAMVfwCaptureDialogs * This, int iDialog, int uMsg, int dw1, int dw2);
        public delegate int SendDriverMessageDelegate(@interface IAMVfwCaptureDialogs This, int iDialog, int uMsg, int dw1, int dw2);
        public SendDriverMessageDelegate SendDriverMessage;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMVfwCompressDialogsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVfwCompressDialogs * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVfwCompressDialogs This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVfwCompressDialogs * This);
        public delegate uint AddRefDelegate(@interface IAMVfwCompressDialogs This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVfwCompressDialogs * This);
        public delegate uint ReleaseDelegate(@interface IAMVfwCompressDialogs This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShowDialog)(interface IAMVfwCompressDialogs * This, int iDialog, System.IntPtr hwnd);
        public delegate int ShowDialogDelegate(@interface IAMVfwCompressDialogs This, int iDialog, IntPtr hwnd);
        public ShowDialogDelegate ShowDialog;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetState)(interface IAMVfwCompressDialogs * This, object* pState, int *pcbState);
        public delegate int GetStateDelegate(@interface IAMVfwCompressDialogs This, object pState, ref int pcbState);
        public GetStateDelegate GetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetState)(interface IAMVfwCompressDialogs * This, object* pState, int cbState);
        public delegate int SetStateDelegate(@interface IAMVfwCompressDialogs This, object pState, int cbState);
        public SetStateDelegate SetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SendDriverMessage)(interface IAMVfwCompressDialogs * This, int uMsg, int dw1, int dw2);
        public delegate int SendDriverMessageDelegate(@interface IAMVfwCompressDialogs This, int uMsg, int dw1, int dw2);
        public SendDriverMessageDelegate SendDriverMessage;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMDroppedFramesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMDroppedFrames * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMDroppedFrames This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMDroppedFrames * This);
        public delegate uint AddRefDelegate(@interface IAMDroppedFrames This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMDroppedFrames * This);
        public delegate uint ReleaseDelegate(@interface IAMDroppedFrames This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumDropped)(interface IAMDroppedFrames * This, int *plDropped);
        public delegate int GetNumDroppedDelegate(@interface IAMDroppedFrames This, ref int plDropped);
        public GetNumDroppedDelegate GetNumDropped;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumNotDropped)(interface IAMDroppedFrames * This, int *plNotDropped);
        public delegate int GetNumNotDroppedDelegate(@interface IAMDroppedFrames This, ref int plNotDropped);
        public GetNumNotDroppedDelegate GetNumNotDropped;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDroppedInfo)(interface IAMDroppedFrames * This, int lSize, int *plArray, int *plNumCopied);
        public delegate int GetDroppedInfoDelegate(@interface IAMDroppedFrames This, int lSize, ref int plArray, ref int plNumCopied);
        public GetDroppedInfoDelegate GetDroppedInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAverageFrameSize)(interface IAMDroppedFrames * This, int *plAverageSize);
        public delegate int GetAverageFrameSizeDelegate(@interface IAMDroppedFrames This, ref int plAverageSize);
        public GetAverageFrameSizeDelegate GetAverageFrameSize;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMAudioInputMixerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMAudioInputMixer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMAudioInputMixer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMAudioInputMixer * This);
        public delegate uint AddRefDelegate(@interface IAMAudioInputMixer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMAudioInputMixer * This);
        public delegate uint ReleaseDelegate(@interface IAMAudioInputMixer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Enable)(interface IAMAudioInputMixer * This, bool fEnable);
        public delegate int put_EnableDelegate(@interface IAMAudioInputMixer This, bool fEnable);
        public put_EnableDelegate put_Enable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Enable)(interface IAMAudioInputMixer * This, bool *pfEnable);
        public delegate int get_EnableDelegate(@interface IAMAudioInputMixer This, ref bool pfEnable);
        public get_EnableDelegate get_Enable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Mono)(interface IAMAudioInputMixer * This, bool fMono);
        public delegate int put_MonoDelegate(@interface IAMAudioInputMixer This, bool fMono);
        public put_MonoDelegate put_Mono;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Mono)(interface IAMAudioInputMixer * This, bool *pfMono);
        public delegate int get_MonoDelegate(@interface IAMAudioInputMixer This, ref bool pfMono);
        public get_MonoDelegate get_Mono;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MixLevel)(interface IAMAudioInputMixer * This, double Level);
        public delegate int put_MixLevelDelegate(@interface IAMAudioInputMixer This, double Level);
        public put_MixLevelDelegate put_MixLevel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MixLevel)(interface IAMAudioInputMixer * This, double *pLevel);
        public delegate int get_MixLevelDelegate(@interface IAMAudioInputMixer This, ref double pLevel);
        public get_MixLevelDelegate get_MixLevel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Pan)(interface IAMAudioInputMixer * This, double Pan);
        public delegate int put_PanDelegate(@interface IAMAudioInputMixer This, double Pan);
        public put_PanDelegate put_Pan;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Pan)(interface IAMAudioInputMixer * This, double *pPan);
        public delegate int get_PanDelegate(@interface IAMAudioInputMixer This, ref double pPan);
        public get_PanDelegate get_Pan;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Loudness)(interface IAMAudioInputMixer * This, bool fLoudness);
        public delegate int put_LoudnessDelegate(@interface IAMAudioInputMixer This, bool fLoudness);
        public put_LoudnessDelegate put_Loudness;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Loudness)(interface IAMAudioInputMixer * This, bool *pfLoudness);
        public delegate int get_LoudnessDelegate(@interface IAMAudioInputMixer This, ref bool pfLoudness);
        public get_LoudnessDelegate get_Loudness;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Treble)(interface IAMAudioInputMixer * This, double Treble);
        public delegate int put_TrebleDelegate(@interface IAMAudioInputMixer This, double Treble);
        public put_TrebleDelegate put_Treble;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Treble)(interface IAMAudioInputMixer * This, double *pTreble);
        public delegate int get_TrebleDelegate(@interface IAMAudioInputMixer This, ref double pTreble);
        public get_TrebleDelegate get_Treble;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TrebleRange)(interface IAMAudioInputMixer * This, double *pRange);
        public delegate int get_TrebleRangeDelegate(@interface IAMAudioInputMixer This, ref double pRange);
        public get_TrebleRangeDelegate get_TrebleRange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Bass)(interface IAMAudioInputMixer * This, double Bass);
        public delegate int put_BassDelegate(@interface IAMAudioInputMixer This, double Bass);
        public put_BassDelegate put_Bass;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Bass)(interface IAMAudioInputMixer * This, double *pBass);
        public delegate int get_BassDelegate(@interface IAMAudioInputMixer This, ref double pBass);
        public get_BassDelegate get_Bass;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BassRange)(interface IAMAudioInputMixer * This, double *pRange);
        public delegate int get_BassRangeDelegate(@interface IAMAudioInputMixer This, ref double pRange);
        public get_BassRangeDelegate get_BassRange;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMBufferNegotiationVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMBufferNegotiation * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMBufferNegotiation This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMBufferNegotiation * This);
        public delegate uint AddRefDelegate(@interface IAMBufferNegotiation This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMBufferNegotiation * This);
        public delegate uint ReleaseDelegate(@interface IAMBufferNegotiation This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SuggestAllocatorProperties)(interface IAMBufferNegotiation * This, const _AllocatorProperties *pprop);
        public delegate int SuggestAllocatorPropertiesDelegate(@interface IAMBufferNegotiation This, _AllocatorProperties pprop);
        public SuggestAllocatorPropertiesDelegate SuggestAllocatorProperties;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllocatorProperties)(interface IAMBufferNegotiation * This, _AllocatorProperties *pprop);
        public delegate int GetAllocatorPropertiesDelegate(@interface IAMBufferNegotiation This, _AllocatorProperties pprop);
        public GetAllocatorPropertiesDelegate GetAllocatorProperties;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0169 */
/* [local] */ 

public enum tagAnalogVideoStandard
{
        AnalogVideo_None = 0,
    AnalogVideo_NTSC_M = 0x1,
    AnalogVideo_NTSC_M_J = 0x2,
    AnalogVideo_NTSC_433 = 0x4,
    AnalogVideo_PAL_B = 0x10,
    AnalogVideo_PAL_D = 0x20,
    AnalogVideo_PAL_G = 0x40,
    AnalogVideo_PAL_H = 0x80,
    AnalogVideo_PAL_I = 0x100,
    AnalogVideo_PAL_M = 0x200,
    AnalogVideo_PAL_N = 0x400,
    AnalogVideo_PAL_60 = 0x800,
    AnalogVideo_SECAM_B = 0x1000,
    AnalogVideo_SECAM_D = 0x2000,
    AnalogVideo_SECAM_G = 0x4000,
    AnalogVideo_SECAM_H = 0x8000,
    AnalogVideo_SECAM_K = 0x10000,
    AnalogVideo_SECAM_K1 = 0x20000,
    AnalogVideo_SECAM_L = 0x40000,
    AnalogVideo_SECAM_L1 = 0x80000,
    AnalogVideo_PAL_N_COMBO = 0x100000
}

public enum tagTunerInputType
{
        TunerInputCable = 0,
    TunerInputAntenna = TunerInputCable + 1
}

public enum __MIDL___MIDL_itf_strmif_0169_0001
{
        VideoCopyProtectionMacrovisionBasic = 0,
    VideoCopyProtectionMacrovisionCBI = VideoCopyProtectionMacrovisionBasic + 1
}

public enum tagPhysicalConnectorType
{
        PhysConn_Video_Tuner = 1,
    PhysConn_Video_Composite = PhysConn_Video_Tuner + 1,
    PhysConn_Video_SVideo = PhysConn_Video_Composite + 1,
    PhysConn_Video_RGB = PhysConn_Video_SVideo + 1,
    PhysConn_Video_YRYBY = PhysConn_Video_RGB + 1,
    PhysConn_Video_SerialDigital = PhysConn_Video_YRYBY + 1,
    PhysConn_Video_ParallelDigital = PhysConn_Video_SerialDigital + 1,
    PhysConn_Video_SCSI = PhysConn_Video_ParallelDigital + 1,
    PhysConn_Video_AUX = PhysConn_Video_SCSI + 1,
    PhysConn_Video_1394 = PhysConn_Video_AUX + 1,
    PhysConn_Video_USB = PhysConn_Video_1394 + 1,
    PhysConn_Video_VideoDecoder = PhysConn_Video_USB + 1,
    PhysConn_Video_VideoEncoder = PhysConn_Video_VideoDecoder + 1,
    PhysConn_Video_SCART = PhysConn_Video_VideoEncoder + 1,
    PhysConn_Video_Black = PhysConn_Video_SCART + 1,
    PhysConn_Audio_Tuner = 0x1000,
    PhysConn_Audio_Line = PhysConn_Audio_Tuner + 1,
    PhysConn_Audio_Mic = PhysConn_Audio_Line + 1,
    PhysConn_Audio_AESDigital = PhysConn_Audio_Mic + 1,
    PhysConn_Audio_SPDIFDigital = PhysConn_Audio_AESDigital + 1,
    PhysConn_Audio_SCSI = PhysConn_Audio_SPDIFDigital + 1,
    PhysConn_Audio_AUX = PhysConn_Audio_SCSI + 1,
    PhysConn_Audio_1394 = PhysConn_Audio_AUX + 1,
    PhysConn_Audio_USB = PhysConn_Audio_1394 + 1,
    PhysConn_Audio_AudioDecoder = PhysConn_Audio_USB + 1
}

#else // C style interface

    public class IAMAnalogVideoDecoderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMAnalogVideoDecoder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMAnalogVideoDecoder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMAnalogVideoDecoder * This);
        public delegate uint AddRefDelegate(@interface IAMAnalogVideoDecoder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMAnalogVideoDecoder * This);
        public delegate uint ReleaseDelegate(@interface IAMAnalogVideoDecoder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvailableTVFormats)(interface IAMAnalogVideoDecoder * This, int *lAnalogVideoStandard);
        public delegate int get_AvailableTVFormatsDelegate(@interface IAMAnalogVideoDecoder This, ref int lAnalogVideoStandard);
        public get_AvailableTVFormatsDelegate get_AvailableTVFormats;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TVFormat)(interface IAMAnalogVideoDecoder * This, int lAnalogVideoStandard);
        public delegate int put_TVFormatDelegate(@interface IAMAnalogVideoDecoder This, int lAnalogVideoStandard);
        public put_TVFormatDelegate put_TVFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TVFormat)(interface IAMAnalogVideoDecoder * This, int *plAnalogVideoStandard);
        public delegate int get_TVFormatDelegate(@interface IAMAnalogVideoDecoder This, ref int plAnalogVideoStandard);
        public get_TVFormatDelegate get_TVFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_HorizontalLocked)(interface IAMAnalogVideoDecoder * This, int *plLocked);
        public delegate int get_HorizontalLockedDelegate(@interface IAMAnalogVideoDecoder This, ref int plLocked);
        public get_HorizontalLockedDelegate get_HorizontalLocked;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_VCRHorizontalLocking)(interface IAMAnalogVideoDecoder * This, int lVCRHorizontalLocking);
        public delegate int put_VCRHorizontalLockingDelegate(@interface IAMAnalogVideoDecoder This, int lVCRHorizontalLocking);
        public put_VCRHorizontalLockingDelegate put_VCRHorizontalLocking;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VCRHorizontalLocking)(interface IAMAnalogVideoDecoder * This, int *plVCRHorizontalLocking);
        public delegate int get_VCRHorizontalLockingDelegate(@interface IAMAnalogVideoDecoder This, ref int plVCRHorizontalLocking);
        public get_VCRHorizontalLockingDelegate get_VCRHorizontalLocking;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_NumberOfLines)(interface IAMAnalogVideoDecoder * This, int *plNumberOfLines);
        public delegate int get_NumberOfLinesDelegate(@interface IAMAnalogVideoDecoder This, ref int plNumberOfLines);
        public get_NumberOfLinesDelegate get_NumberOfLines;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_OutputEnable)(interface IAMAnalogVideoDecoder * This, int lOutputEnable);
        public delegate int put_OutputEnableDelegate(@interface IAMAnalogVideoDecoder This, int lOutputEnable);
        public put_OutputEnableDelegate put_OutputEnable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_OutputEnable)(interface IAMAnalogVideoDecoder * This, int *plOutputEnable);
        public delegate int get_OutputEnableDelegate(@interface IAMAnalogVideoDecoder This, ref int plOutputEnable);
        public get_OutputEnableDelegate get_OutputEnable;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0170 */
/* [local] */ 

public enum tagVideoProcAmpProperty
{
        VideoProcAmp_Brightness = 0,
    VideoProcAmp_Contrast = VideoProcAmp_Brightness + 1,
    VideoProcAmp_Hue = VideoProcAmp_Contrast + 1,
    VideoProcAmp_Saturation = VideoProcAmp_Hue + 1,
    VideoProcAmp_Sharpness = VideoProcAmp_Saturation + 1,
    VideoProcAmp_Gamma = VideoProcAmp_Sharpness + 1,
    VideoProcAmp_ColorEnable = VideoProcAmp_Gamma + 1,
    VideoProcAmp_WhiteBalance = VideoProcAmp_ColorEnable + 1,
    VideoProcAmp_BacklightCompensation = VideoProcAmp_WhiteBalance + 1,
    VideoProcAmp_Gain = VideoProcAmp_BacklightCompensation + 1
}

public enum tagVideoProcAmpFlags
{
        VideoProcAmp_Flags_Auto = 0x1,
    VideoProcAmp_Flags_Manual = 0x2
}

#else // C style interface

    public class IAMVideoProcAmpVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVideoProcAmp * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVideoProcAmp This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVideoProcAmp * This);
        public delegate uint AddRefDelegate(@interface IAMVideoProcAmp This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVideoProcAmp * This);
        public delegate uint ReleaseDelegate(@interface IAMVideoProcAmp This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRange)(interface IAMVideoProcAmp * This, int Property, int *pMin, int *pMax, int *pSteppingDelta, int *pDefault, int *pCapsFlags);
        public delegate int GetRangeDelegate(@interface IAMVideoProcAmp This, int Property, ref int pMin, ref int pMax, ref int pSteppingDelta, ref int pDefault, ref int pCapsFlags);
        public GetRangeDelegate GetRange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Set)(interface IAMVideoProcAmp * This, int Property, int lValue, int Flags);
        public delegate int SetDelegate(@interface IAMVideoProcAmp This, int Property, int lValue, int Flags);
        public SetDelegate Set;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Get)(interface IAMVideoProcAmp * This, int Property, int *lValue, int *Flags);
        public delegate int GetDelegate(@interface IAMVideoProcAmp This, int Property, ref int lValue, ref int Flags);
        public GetDelegate Get;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0171 */
/* [local] */ 

public enum tagCameraControlProperty
{
        CameraControl_Pan = 0,
    CameraControl_Tilt = CameraControl_Pan + 1,
    CameraControl_Roll = CameraControl_Tilt + 1,
    CameraControl_Zoom = CameraControl_Roll + 1,
    CameraControl_Exposure = CameraControl_Zoom + 1,
    CameraControl_Iris = CameraControl_Exposure + 1,
    CameraControl_Focus = CameraControl_Iris + 1
}

public enum tagCameraControlFlags
{
        CameraControl_Flags_Auto = 0x1,
    CameraControl_Flags_Manual = 0x2
}

#else // C style interface

    public class IAMCameraControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMCameraControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMCameraControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMCameraControl * This);
        public delegate uint AddRefDelegate(@interface IAMCameraControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMCameraControl * This);
        public delegate uint ReleaseDelegate(@interface IAMCameraControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRange)(interface IAMCameraControl * This, int Property, int *pMin, int *pMax, int *pSteppingDelta, int *pDefault, int *pCapsFlags);
        public delegate int GetRangeDelegate(@interface IAMCameraControl This, int Property, ref int pMin, ref int pMax, ref int pSteppingDelta, ref int pDefault, ref int pCapsFlags);
        public GetRangeDelegate GetRange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Set)(interface IAMCameraControl * This, int Property, int lValue, int Flags);
        public delegate int SetDelegate(@interface IAMCameraControl This, int Property, int lValue, int Flags);
        public SetDelegate Set;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Get)(interface IAMCameraControl * This, int Property, int *lValue, int *Flags);
        public delegate int GetDelegate(@interface IAMCameraControl This, int Property, ref int lValue, ref int Flags);
        public GetDelegate Get;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0172 */
/* [local] */ 

public enum tagVideoControlFlags
{
        VideoControlFlag_FlipHorizontal = 0x1,
    VideoControlFlag_FlipVertical = 0x2,
    VideoControlFlag_ExternalTriggerEnable = 0x4,
    VideoControlFlag_Trigger = 0x8
}

#else // C style interface

    public class IAMVideoControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVideoControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVideoControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVideoControl * This);
        public delegate uint AddRefDelegate(@interface IAMVideoControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVideoControl * This);
        public delegate uint ReleaseDelegate(@interface IAMVideoControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCaps)(interface IAMVideoControl * This, interface IPin *pPin, int *pCapsFlags);
        public delegate int GetCapsDelegate(@interface IAMVideoControl This, @interface IPin pPin, ref int pCapsFlags);
        public GetCapsDelegate GetCaps;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMode)(interface IAMVideoControl * This, interface IPin *pPin, int Mode);
        public delegate int SetModeDelegate(@interface IAMVideoControl This, @interface IPin pPin, int Mode);
        public SetModeDelegate SetMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMode)(interface IAMVideoControl * This, interface IPin *pPin, int *Mode);
        public delegate int GetModeDelegate(@interface IAMVideoControl This, @interface IPin pPin, ref int Mode);
        public GetModeDelegate GetMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentActualFrameRate)(interface IAMVideoControl * This, interface IPin *pPin, long *ActualFrameRate);
        public delegate int GetCurrentActualFrameRateDelegate(@interface IAMVideoControl This, @interface IPin pPin, ref long ActualFrameRate);
        public GetCurrentActualFrameRateDelegate GetCurrentActualFrameRate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMaxAvailableFrameRate)(interface IAMVideoControl * This, interface IPin *pPin, int iIndex, SIZE Dimensions, long *MaxAvailableFrameRate);
        public delegate int GetMaxAvailableFrameRateDelegate(@interface IAMVideoControl This, @interface IPin pPin, int iIndex, SIZE Dimensions, ref long MaxAvailableFrameRate);
        public GetMaxAvailableFrameRateDelegate GetMaxAvailableFrameRate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFrameRateList)(interface IAMVideoControl * This, interface IPin *pPin, int iIndex, SIZE Dimensions, int *ListSize, long **FrameRates);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetFrameRateListDelegate(@interface IAMVideoControl This, @interface IPin pPin, int iIndex, SIZE Dimensions, ref int ListSize, long[] FrameRates);
        public GetFrameRateListDelegate GetFrameRateList;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMCrossbarVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMCrossbar * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMCrossbar This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMCrossbar * This);
        public delegate uint AddRefDelegate(@interface IAMCrossbar This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMCrossbar * This);
        public delegate uint ReleaseDelegate(@interface IAMCrossbar This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PinCounts)(interface IAMCrossbar * This, int *OutputPinCount, int *InputPinCount);
        public delegate int get_PinCountsDelegate(@interface IAMCrossbar This, ref int OutputPinCount, ref int InputPinCount);
        public get_PinCountsDelegate get_PinCounts;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CanRoute)(interface IAMCrossbar * This, int OutputPinIndex, int InputPinIndex);
        public delegate int CanRouteDelegate(@interface IAMCrossbar This, int OutputPinIndex, int InputPinIndex);
        public CanRouteDelegate CanRoute;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Route)(interface IAMCrossbar * This, int OutputPinIndex, int InputPinIndex);
        public delegate int RouteDelegate(@interface IAMCrossbar This, int OutputPinIndex, int InputPinIndex);
        public RouteDelegate Route;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_IsRoutedTo)(interface IAMCrossbar * This, int OutputPinIndex, int *InputPinIndex);
        public delegate int get_IsRoutedToDelegate(@interface IAMCrossbar This, int OutputPinIndex, ref int InputPinIndex);
        public get_IsRoutedToDelegate get_IsRoutedTo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CrossbarPinInfo)(interface IAMCrossbar * This, bool IsInputPin, int PinIndex, int *PinIndexRelated, int *PhysicalType);
        public delegate int get_CrossbarPinInfoDelegate(@interface IAMCrossbar This, bool IsInputPin, int PinIndex, ref int PinIndexRelated, ref int PhysicalType);
        public get_CrossbarPinInfoDelegate get_CrossbarPinInfo;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0174 */
/* [local] */ 

public enum tagAMTunerSubChannel
{
        AMTUNER_SUBCHAN_NO_TUNE = -2,
    AMTUNER_SUBCHAN_DEFAULT = -1
}

public enum tagAMTunerSignalStrength
{
        AMTUNER_HASNOSIGNALSTRENGTH = -1,
    AMTUNER_NOSIGNAL = 0,
    AMTUNER_SIGNALPRESENT = 1
}

public enum tagAMTunerModeType
{
        AMTUNER_MODE_DEFAULT = 0,
    AMTUNER_MODE_TV = 0x1,
    AMTUNER_MODE_FM_RADIO = 0x2,
    AMTUNER_MODE_AM_RADIO = 0x4,
    AMTUNER_MODE_DSS = 0x8
}

public enum tagAMTunerEventType
{
        AMTUNER_EVENT_CHANGED = 0x1
}

#else // C style interface

    public class IAMTunerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTuner * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTuner This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTuner * This);
        public delegate uint AddRefDelegate(@interface IAMTuner This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTuner * This);
        public delegate uint ReleaseDelegate(@interface IAMTuner This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Channel)(interface IAMTuner * This, int lChannel, int lVideoSubChannel, int lAudioSubChannel);
        public delegate int put_ChannelDelegate(@interface IAMTuner This, int lChannel, int lVideoSubChannel, int lAudioSubChannel);
        public put_ChannelDelegate put_Channel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Channel)(interface IAMTuner * This, int *plChannel, int *plVideoSubChannel, int *plAudioSubChannel);
        public delegate int get_ChannelDelegate(@interface IAMTuner This, ref int plChannel, ref int plVideoSubChannel, ref int plAudioSubChannel);
        public get_ChannelDelegate get_Channel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChannelMinMax)(interface IAMTuner * This, int *lChannelMin, int *lChannelMax);
        public delegate int ChannelMinMaxDelegate(@interface IAMTuner This, ref int lChannelMin, ref int lChannelMax);
        public ChannelMinMaxDelegate ChannelMinMax;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CountryCode)(interface IAMTuner * This, int lCountryCode);
        public delegate int put_CountryCodeDelegate(@interface IAMTuner This, int lCountryCode);
        public put_CountryCodeDelegate put_CountryCode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountryCode)(interface IAMTuner * This, int *plCountryCode);
        public delegate int get_CountryCodeDelegate(@interface IAMTuner This, ref int plCountryCode);
        public get_CountryCodeDelegate get_CountryCode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuningSpace)(interface IAMTuner * This, int lTuningSpace);
        public delegate int put_TuningSpaceDelegate(@interface IAMTuner This, int lTuningSpace);
        public put_TuningSpaceDelegate put_TuningSpace;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TuningSpace)(interface IAMTuner * This, int *plTuningSpace);
        public delegate int get_TuningSpaceDelegate(@interface IAMTuner This, ref int plTuningSpace);
        public get_TuningSpaceDelegate get_TuningSpace;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Logon)(interface IAMTuner * This, System.IntPtr hCurrentUser);
        public delegate int LogonDelegate(@interface IAMTuner This, IntPtr hCurrentUser);
        public LogonDelegate Logon;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Logout)(interface IAMTuner * This);
        public delegate int LogoutDelegate(@interface IAMTuner This);
        public LogoutDelegate Logout;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SignalPresent)(interface IAMTuner * This, int *plSignalStrength);
        public delegate int SignalPresentDelegate(@interface IAMTuner This, ref int plSignalStrength);
        public SignalPresentDelegate SignalPresent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Mode)(interface IAMTuner * This, AMTunerModeType lMode);
        public delegate int put_ModeDelegate(@interface IAMTuner This, AMTunerModeType lMode);
        public put_ModeDelegate put_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Mode)(interface IAMTuner * This, AMTunerModeType *plMode);
        public delegate int get_ModeDelegate(@interface IAMTuner This, AMTunerModeType plMode);
        public get_ModeDelegate get_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailableModes)(interface IAMTuner * This, int *plModes);
        public delegate int GetAvailableModesDelegate(@interface IAMTuner This, ref int plModes);
        public GetAvailableModesDelegate GetAvailableModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterNotificationCallBack)(interface IAMTuner * This, interface IAMTunerNotification *pNotify, int lEvents);
        public delegate int RegisterNotificationCallBackDelegate(@interface IAMTuner This, @interface IAMTunerNotification pNotify, int lEvents);
        public RegisterNotificationCallBackDelegate RegisterNotificationCallBack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnRegisterNotificationCallBack)(interface IAMTuner * This, interface IAMTunerNotification *pNotify);
        public delegate int UnRegisterNotificationCallBackDelegate(@interface IAMTuner This, @interface IAMTunerNotification pNotify);
        public UnRegisterNotificationCallBackDelegate UnRegisterNotificationCallBack;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMTunerNotificationVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTunerNotification * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTunerNotification This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTunerNotification * This);
        public delegate uint AddRefDelegate(@interface IAMTunerNotification This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTunerNotification * This);
        public delegate uint ReleaseDelegate(@interface IAMTunerNotification This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnEvent)(interface IAMTunerNotification * This, AMTunerEventType Event);
        public delegate int OnEventDelegate(@interface IAMTunerNotification This, AMTunerEventType Event);
        public OnEventDelegate OnEvent;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMTVTunerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTVTuner * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTVTuner This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTVTuner * This);
        public delegate uint AddRefDelegate(@interface IAMTVTuner This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTVTuner * This);
        public delegate uint ReleaseDelegate(@interface IAMTVTuner This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Channel)(interface IAMTVTuner * This, int lChannel, int lVideoSubChannel, int lAudioSubChannel);
        public delegate int put_ChannelDelegate(@interface IAMTVTuner This, int lChannel, int lVideoSubChannel, int lAudioSubChannel);
        public put_ChannelDelegate put_Channel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Channel)(interface IAMTVTuner * This, int *plChannel, int *plVideoSubChannel, int *plAudioSubChannel);
        public delegate int get_ChannelDelegate(@interface IAMTVTuner This, ref int plChannel, ref int plVideoSubChannel, ref int plAudioSubChannel);
        public get_ChannelDelegate get_Channel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChannelMinMax)(interface IAMTVTuner * This, int *lChannelMin, int *lChannelMax);
        public delegate int ChannelMinMaxDelegate(@interface IAMTVTuner This, ref int lChannelMin, ref int lChannelMax);
        public ChannelMinMaxDelegate ChannelMinMax;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CountryCode)(interface IAMTVTuner * This, int lCountryCode);
        public delegate int put_CountryCodeDelegate(@interface IAMTVTuner This, int lCountryCode);
        public put_CountryCodeDelegate put_CountryCode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountryCode)(interface IAMTVTuner * This, int *plCountryCode);
        public delegate int get_CountryCodeDelegate(@interface IAMTVTuner This, ref int plCountryCode);
        public get_CountryCodeDelegate get_CountryCode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuningSpace)(interface IAMTVTuner * This, int lTuningSpace);
        public delegate int put_TuningSpaceDelegate(@interface IAMTVTuner This, int lTuningSpace);
        public put_TuningSpaceDelegate put_TuningSpace;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TuningSpace)(interface IAMTVTuner * This, int *plTuningSpace);
        public delegate int get_TuningSpaceDelegate(@interface IAMTVTuner This, ref int plTuningSpace);
        public get_TuningSpaceDelegate get_TuningSpace;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Logon)(interface IAMTVTuner * This, System.IntPtr hCurrentUser);
        public delegate int LogonDelegate(@interface IAMTVTuner This, IntPtr hCurrentUser);
        public LogonDelegate Logon;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Logout)(interface IAMTVTuner * This);
        public delegate int LogoutDelegate(@interface IAMTVTuner This);
        public LogoutDelegate Logout;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SignalPresent)(interface IAMTVTuner * This, int *plSignalStrength);
        public delegate int SignalPresentDelegate(@interface IAMTVTuner This, ref int plSignalStrength);
        public SignalPresentDelegate SignalPresent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Mode)(interface IAMTVTuner * This, AMTunerModeType lMode);
        public delegate int put_ModeDelegate(@interface IAMTVTuner This, AMTunerModeType lMode);
        public put_ModeDelegate put_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Mode)(interface IAMTVTuner * This, AMTunerModeType *plMode);
        public delegate int get_ModeDelegate(@interface IAMTVTuner This, AMTunerModeType plMode);
        public get_ModeDelegate get_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailableModes)(interface IAMTVTuner * This, int *plModes);
        public delegate int GetAvailableModesDelegate(@interface IAMTVTuner This, ref int plModes);
        public GetAvailableModesDelegate GetAvailableModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterNotificationCallBack)(interface IAMTVTuner * This, interface IAMTunerNotification *pNotify, int lEvents);
        public delegate int RegisterNotificationCallBackDelegate(@interface IAMTVTuner This, @interface IAMTunerNotification pNotify, int lEvents);
        public RegisterNotificationCallBackDelegate RegisterNotificationCallBack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnRegisterNotificationCallBack)(interface IAMTVTuner * This, interface IAMTunerNotification *pNotify);
        public delegate int UnRegisterNotificationCallBackDelegate(@interface IAMTVTuner This, @interface IAMTunerNotification pNotify);
        public UnRegisterNotificationCallBackDelegate UnRegisterNotificationCallBack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvailableTVFormats)(interface IAMTVTuner * This, int *lAnalogVideoStandard);
        public delegate int get_AvailableTVFormatsDelegate(@interface IAMTVTuner This, ref int lAnalogVideoStandard);
        public get_AvailableTVFormatsDelegate get_AvailableTVFormats;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TVFormat)(interface IAMTVTuner * This, int *plAnalogVideoStandard);
        public delegate int get_TVFormatDelegate(@interface IAMTVTuner This, ref int plAnalogVideoStandard);
        public get_TVFormatDelegate get_TVFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AutoTune)(interface IAMTVTuner * This, int lChannel, int *plFoundSignal);
        public delegate int AutoTuneDelegate(@interface IAMTVTuner This, int lChannel, ref int plFoundSignal);
        public AutoTuneDelegate AutoTune;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StoreAutoTune)(interface IAMTVTuner * This);
        public delegate int StoreAutoTuneDelegate(@interface IAMTVTuner This);
        public StoreAutoTuneDelegate StoreAutoTune;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_NumInputConnections)(interface IAMTVTuner * This, int *plNumInputConnections);
        public delegate int get_NumInputConnectionsDelegate(@interface IAMTVTuner This, ref int plNumInputConnections);
        public get_NumInputConnectionsDelegate get_NumInputConnections;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_InputType)(interface IAMTVTuner * This, int lIndex, TunerInputType InputType);
        public delegate int put_InputTypeDelegate(@interface IAMTVTuner This, int lIndex, TunerInputType InputType);
        public put_InputTypeDelegate put_InputType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_InputType)(interface IAMTVTuner * This, int lIndex, TunerInputType *pInputType);
        public delegate int get_InputTypeDelegate(@interface IAMTVTuner This, int lIndex, TunerInputType pInputType);
        public get_InputTypeDelegate get_InputType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_ConnectInput)(interface IAMTVTuner * This, int lIndex);
        public delegate int put_ConnectInputDelegate(@interface IAMTVTuner This, int lIndex);
        public put_ConnectInputDelegate put_ConnectInput;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ConnectInput)(interface IAMTVTuner * This, int *plIndex);
        public delegate int get_ConnectInputDelegate(@interface IAMTVTuner This, ref int plIndex);
        public get_ConnectInputDelegate get_ConnectInput;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoFrequency)(interface IAMTVTuner * This, int *lFreq);
        public delegate int get_VideoFrequencyDelegate(@interface IAMTVTuner This, ref int lFreq);
        public get_VideoFrequencyDelegate get_VideoFrequency;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AudioFrequency)(interface IAMTVTuner * This, int *lFreq);
        public delegate int get_AudioFrequencyDelegate(@interface IAMTVTuner This, ref int lFreq);
        public get_AudioFrequencyDelegate get_AudioFrequency;

//        END_INTERFACE
    }

#else // C style interface

    public class IBPCSatelliteTunerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IBPCSatelliteTuner * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IBPCSatelliteTuner This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IBPCSatelliteTuner * This);
        public delegate uint AddRefDelegate(@interface IBPCSatelliteTuner This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IBPCSatelliteTuner * This);
        public delegate uint ReleaseDelegate(@interface IBPCSatelliteTuner This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Channel)(interface IBPCSatelliteTuner * This, int lChannel, int lVideoSubChannel, int lAudioSubChannel);
        public delegate int put_ChannelDelegate(@interface IBPCSatelliteTuner This, int lChannel, int lVideoSubChannel, int lAudioSubChannel);
        public put_ChannelDelegate put_Channel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Channel)(interface IBPCSatelliteTuner * This, int *plChannel, int *plVideoSubChannel, int *plAudioSubChannel);
        public delegate int get_ChannelDelegate(@interface IBPCSatelliteTuner This, ref int plChannel, ref int plVideoSubChannel, ref int plAudioSubChannel);
        public get_ChannelDelegate get_Channel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChannelMinMax)(interface IBPCSatelliteTuner * This, int *lChannelMin, int *lChannelMax);
        public delegate int ChannelMinMaxDelegate(@interface IBPCSatelliteTuner This, ref int lChannelMin, ref int lChannelMax);
        public ChannelMinMaxDelegate ChannelMinMax;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CountryCode)(interface IBPCSatelliteTuner * This, int lCountryCode);
        public delegate int put_CountryCodeDelegate(@interface IBPCSatelliteTuner This, int lCountryCode);
        public put_CountryCodeDelegate put_CountryCode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CountryCode)(interface IBPCSatelliteTuner * This, int *plCountryCode);
        public delegate int get_CountryCodeDelegate(@interface IBPCSatelliteTuner This, ref int plCountryCode);
        public get_CountryCodeDelegate get_CountryCode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TuningSpace)(interface IBPCSatelliteTuner * This, int lTuningSpace);
        public delegate int put_TuningSpaceDelegate(@interface IBPCSatelliteTuner This, int lTuningSpace);
        public put_TuningSpaceDelegate put_TuningSpace;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TuningSpace)(interface IBPCSatelliteTuner * This, int *plTuningSpace);
        public delegate int get_TuningSpaceDelegate(@interface IBPCSatelliteTuner This, ref int plTuningSpace);
        public get_TuningSpaceDelegate get_TuningSpace;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Logon)(interface IBPCSatelliteTuner * This, System.IntPtr hCurrentUser);
        public delegate int LogonDelegate(@interface IBPCSatelliteTuner This, IntPtr hCurrentUser);
        public LogonDelegate Logon;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Logout)(interface IBPCSatelliteTuner * This);
        public delegate int LogoutDelegate(@interface IBPCSatelliteTuner This);
        public LogoutDelegate Logout;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SignalPresent)(interface IBPCSatelliteTuner * This, int *plSignalStrength);
        public delegate int SignalPresentDelegate(@interface IBPCSatelliteTuner This, ref int plSignalStrength);
        public SignalPresentDelegate SignalPresent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Mode)(interface IBPCSatelliteTuner * This, AMTunerModeType lMode);
        public delegate int put_ModeDelegate(@interface IBPCSatelliteTuner This, AMTunerModeType lMode);
        public put_ModeDelegate put_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Mode)(interface IBPCSatelliteTuner * This, AMTunerModeType *plMode);
        public delegate int get_ModeDelegate(@interface IBPCSatelliteTuner This, AMTunerModeType plMode);
        public get_ModeDelegate get_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailableModes)(interface IBPCSatelliteTuner * This, int *plModes);
        public delegate int GetAvailableModesDelegate(@interface IBPCSatelliteTuner This, ref int plModes);
        public GetAvailableModesDelegate GetAvailableModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterNotificationCallBack)(interface IBPCSatelliteTuner * This, interface IAMTunerNotification *pNotify, int lEvents);
        public delegate int RegisterNotificationCallBackDelegate(@interface IBPCSatelliteTuner This, @interface IAMTunerNotification pNotify, int lEvents);
        public RegisterNotificationCallBackDelegate RegisterNotificationCallBack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnRegisterNotificationCallBack)(interface IBPCSatelliteTuner * This, interface IAMTunerNotification *pNotify);
        public delegate int UnRegisterNotificationCallBackDelegate(@interface IBPCSatelliteTuner This, @interface IAMTunerNotification pNotify);
        public UnRegisterNotificationCallBackDelegate UnRegisterNotificationCallBack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DefaultSubChannelTypes)(interface IBPCSatelliteTuner * This, int *plDefaultVideoType, int *plDefaultAudioType);
        public delegate int get_DefaultSubChannelTypesDelegate(@interface IBPCSatelliteTuner This, ref int plDefaultVideoType, ref int plDefaultAudioType);
        public get_DefaultSubChannelTypesDelegate get_DefaultSubChannelTypes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DefaultSubChannelTypes)(interface IBPCSatelliteTuner * This, int lDefaultVideoType, int lDefaultAudioType);
        public delegate int put_DefaultSubChannelTypesDelegate(@interface IBPCSatelliteTuner This, int lDefaultVideoType, int lDefaultAudioType);
        public put_DefaultSubChannelTypesDelegate put_DefaultSubChannelTypes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsTapingPermitted)(interface IBPCSatelliteTuner * This);
        public delegate int IsTapingPermittedDelegate(@interface IBPCSatelliteTuner This);
        public IsTapingPermittedDelegate IsTapingPermitted;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0178 */
/* [local] */ 

public enum tagTVAudioMode
{
        AMTVAUDIO_MODE_MONO = 0x1,
    AMTVAUDIO_MODE_STEREO = 0x2,
    AMTVAUDIO_MODE_LANG_A = 0x10,
    AMTVAUDIO_MODE_LANG_B = 0x20,
    AMTVAUDIO_MODE_LANG_C = 0x40
}

public enum tagAMTVAudioEventType
{
        AMTVAUDIO_EVENT_CHANGED = 0x1
}

#else // C style interface

    public class IAMTVAudioVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTVAudio * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTVAudio This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTVAudio * This);
        public delegate uint AddRefDelegate(@interface IAMTVAudio This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTVAudio * This);
        public delegate uint ReleaseDelegate(@interface IAMTVAudio This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetHardwareSupportedTVAudioModes)(interface IAMTVAudio * This, int *plModes);
        public delegate int GetHardwareSupportedTVAudioModesDelegate(@interface IAMTVAudio This, ref int plModes);
        public GetHardwareSupportedTVAudioModesDelegate GetHardwareSupportedTVAudioModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailableTVAudioModes)(interface IAMTVAudio * This, int *plModes);
        public delegate int GetAvailableTVAudioModesDelegate(@interface IAMTVAudio This, ref int plModes);
        public GetAvailableTVAudioModesDelegate GetAvailableTVAudioModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TVAudioMode)(interface IAMTVAudio * This, int *plMode);
        public delegate int get_TVAudioModeDelegate(@interface IAMTVAudio This, ref int plMode);
        public get_TVAudioModeDelegate get_TVAudioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TVAudioMode)(interface IAMTVAudio * This, int lMode);
        public delegate int put_TVAudioModeDelegate(@interface IAMTVAudio This, int lMode);
        public put_TVAudioModeDelegate put_TVAudioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterNotificationCallBack)(interface IAMTVAudio * This, interface IAMTunerNotification *pNotify, int lEvents);
        public delegate int RegisterNotificationCallBackDelegate(@interface IAMTVAudio This, @interface IAMTunerNotification pNotify, int lEvents);
        public RegisterNotificationCallBackDelegate RegisterNotificationCallBack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnRegisterNotificationCallBack)(interface IAMTVAudio * This, interface IAMTunerNotification *pNotify);
        public delegate int UnRegisterNotificationCallBackDelegate(@interface IAMTVAudio This, @interface IAMTunerNotification pNotify);
        public UnRegisterNotificationCallBackDelegate UnRegisterNotificationCallBack;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMTVAudioNotificationVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTVAudioNotification * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTVAudioNotification This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTVAudioNotification * This);
        public delegate uint AddRefDelegate(@interface IAMTVAudioNotification This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTVAudioNotification * This);
        public delegate uint ReleaseDelegate(@interface IAMTVAudioNotification This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnEvent)(interface IAMTVAudioNotification * This, AMTVAudioEventType Event);
        public delegate int OnEventDelegate(@interface IAMTVAudioNotification This, AMTVAudioEventType Event);
        public OnEventDelegate OnEvent;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMAnalogVideoEncoderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMAnalogVideoEncoder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMAnalogVideoEncoder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMAnalogVideoEncoder * This);
        public delegate uint AddRefDelegate(@interface IAMAnalogVideoEncoder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMAnalogVideoEncoder * This);
        public delegate uint ReleaseDelegate(@interface IAMAnalogVideoEncoder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvailableTVFormats)(interface IAMAnalogVideoEncoder * This, int *lAnalogVideoStandard);
        public delegate int get_AvailableTVFormatsDelegate(@interface IAMAnalogVideoEncoder This, ref int lAnalogVideoStandard);
        public get_AvailableTVFormatsDelegate get_AvailableTVFormats;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_TVFormat)(interface IAMAnalogVideoEncoder * This, int lAnalogVideoStandard);
        public delegate int put_TVFormatDelegate(@interface IAMAnalogVideoEncoder This, int lAnalogVideoStandard);
        public put_TVFormatDelegate put_TVFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_TVFormat)(interface IAMAnalogVideoEncoder * This, int *plAnalogVideoStandard);
        public delegate int get_TVFormatDelegate(@interface IAMAnalogVideoEncoder This, ref int plAnalogVideoStandard);
        public get_TVFormatDelegate get_TVFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CopyProtection)(interface IAMAnalogVideoEncoder * This, int lVideoCopyProtection);
        public delegate int put_CopyProtectionDelegate(@interface IAMAnalogVideoEncoder This, int lVideoCopyProtection);
        public put_CopyProtectionDelegate put_CopyProtection;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CopyProtection)(interface IAMAnalogVideoEncoder * This, int *lVideoCopyProtection);
        public delegate int get_CopyProtectionDelegate(@interface IAMAnalogVideoEncoder This, ref int lVideoCopyProtection);
        public get_CopyProtectionDelegate get_CopyProtection;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CCEnable)(interface IAMAnalogVideoEncoder * This, int lCCEnable);
        public delegate int put_CCEnableDelegate(@interface IAMAnalogVideoEncoder This, int lCCEnable);
        public put_CCEnableDelegate put_CCEnable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CCEnable)(interface IAMAnalogVideoEncoder * This, int *lCCEnable);
        public delegate int get_CCEnableDelegate(@interface IAMAnalogVideoEncoder This, ref int lCCEnable);
        public get_CCEnableDelegate get_CCEnable;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0181 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0181_0001
{
        AMPROPERTY_PIN_CATEGORY = 0,
    AMPROPERTY_PIN_MEDIUM = AMPROPERTY_PIN_CATEGORY + 1
}

#else // C style interface

    public class IKsPropertySetVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IKsPropertySet * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IKsPropertySet This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IKsPropertySet * This);
        public delegate uint AddRefDelegate(@interface IKsPropertySet This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IKsPropertySet * This);
        public delegate uint ReleaseDelegate(@interface IKsPropertySet This);
        public ReleaseDelegate Release;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Set)(interface IKsPropertySet * This, REFGUID guidPropSet, uint dwPropID, object* pInstanceData, uint cbInstanceData, object* pPropData, uint cbPropData);
        public delegate int SetDelegate(@interface IKsPropertySet This, REFGUID guidPropSet, uint dwPropID, object pInstanceData, uint cbInstanceData, object pPropData, uint cbPropData);
        public SetDelegate Set;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Get)(interface IKsPropertySet * This, REFGUID guidPropSet, uint dwPropID, object* pInstanceData, uint cbInstanceData, object* pPropData, uint cbPropData, uint *pcbReturned);
        public delegate int GetDelegate(@interface IKsPropertySet This, REFGUID guidPropSet, uint dwPropID, object pInstanceData, uint cbInstanceData, object pPropData, uint cbPropData, ref uint pcbReturned);
        public GetDelegate Get;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QuerySupported)(interface IKsPropertySet * This, REFGUID guidPropSet, uint dwPropID, uint *pTypeSupport);
        public delegate int QuerySupportedDelegate(@interface IKsPropertySet This, REFGUID guidPropSet, uint dwPropID, ref uint pTypeSupport);
        public QuerySupportedDelegate QuerySupported;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaPropertyBagVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaPropertyBag * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaPropertyBag This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaPropertyBag * This);
        public delegate uint AddRefDelegate(@interface IMediaPropertyBag This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaPropertyBag * This);
        public delegate uint ReleaseDelegate(@interface IMediaPropertyBag This);
        public ReleaseDelegate Release;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Read)(interface IMediaPropertyBag * This, LPCOLESTR pszPropName, VARIANT *pVar, IErrorLog *pErrorLog);
        public delegate int ReadDelegate(@interface IMediaPropertyBag This, LPCOLESTR pszPropName, VARIANT pVar, IErrorLog pErrorLog);
        public ReadDelegate Read;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Write)(interface IMediaPropertyBag * This, LPCOLESTR pszPropName, VARIANT *pVar);
        public delegate int WriteDelegate(@interface IMediaPropertyBag This, LPCOLESTR pszPropName, VARIANT pVar);
        public WriteDelegate Write;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumProperty)(interface IMediaPropertyBag * This, uint iProperty, VARIANT *pvarPropertyName, VARIANT *pvarPropertyValue);
        public delegate int EnumPropertyDelegate(@interface IMediaPropertyBag This, uint iProperty, VARIANT pvarPropertyName, VARIANT pvarPropertyValue);
        public EnumPropertyDelegate EnumProperty;

//        END_INTERFACE
    }

#else // C style interface

    public class IPersistMediaPropertyBagVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IPersistMediaPropertyBag * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IPersistMediaPropertyBag This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IPersistMediaPropertyBag * This);
        public delegate uint AddRefDelegate(@interface IPersistMediaPropertyBag This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IPersistMediaPropertyBag * This);
        public delegate uint ReleaseDelegate(@interface IPersistMediaPropertyBag This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetClassID)(interface IPersistMediaPropertyBag * This, CLSID *pClassID);
        public delegate int GetClassIDDelegate(@interface IPersistMediaPropertyBag This, CLSID pClassID);
        public GetClassIDDelegate GetClassID;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitNew)(interface IPersistMediaPropertyBag * This);
        public delegate int InitNewDelegate(@interface IPersistMediaPropertyBag This);
        public InitNewDelegate InitNew;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Load)(interface IPersistMediaPropertyBag * This, interface IMediaPropertyBag *pPropBag, IErrorLog *pErrorLog);
        public delegate int LoadDelegate(@interface IPersistMediaPropertyBag This, @interface IMediaPropertyBag pPropBag, IErrorLog pErrorLog);
        public LoadDelegate Load;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Save)(interface IPersistMediaPropertyBag * This, interface IMediaPropertyBag *pPropBag, bool fClearDirty, bool fSaveAllProperties);
        public delegate int SaveDelegate(@interface IPersistMediaPropertyBag This, @interface IMediaPropertyBag pPropBag, bool fClearDirty, bool fSaveAllProperties);
        public SaveDelegate Save;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMPhysicalPinInfoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMPhysicalPinInfo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMPhysicalPinInfo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMPhysicalPinInfo * This);
        public delegate uint AddRefDelegate(@interface IAMPhysicalPinInfo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMPhysicalPinInfo * This);
        public delegate uint ReleaseDelegate(@interface IAMPhysicalPinInfo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPhysicalType)(interface IAMPhysicalPinInfo * This, int *pType, LPOLESTR *ppszType);
        public delegate int GetPhysicalTypeDelegate(@interface IAMPhysicalPinInfo This, ref int pType, LPOLESTR ppszType);
        public GetPhysicalTypeDelegate GetPhysicalType;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMExtDeviceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMExtDevice * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMExtDevice This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMExtDevice * This);
        public delegate uint AddRefDelegate(@interface IAMExtDevice This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMExtDevice * This);
        public delegate uint ReleaseDelegate(@interface IAMExtDevice This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCapability)(interface IAMExtDevice * This, int Capability, int *pValue, double *pdblValue);
        public delegate int GetCapabilityDelegate(@interface IAMExtDevice This, int Capability, ref int pValue, ref double pdblValue);
        public GetCapabilityDelegate GetCapability;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ExternalDeviceID)(interface IAMExtDevice * This, LPOLESTR *ppszData);
        public delegate int get_ExternalDeviceIDDelegate(@interface IAMExtDevice This, LPOLESTR ppszData);
        public get_ExternalDeviceIDDelegate get_ExternalDeviceID;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ExternalDeviceVersion)(interface IAMExtDevice * This, LPOLESTR *ppszData);
        public delegate int get_ExternalDeviceVersionDelegate(@interface IAMExtDevice This, LPOLESTR ppszData);
        public get_ExternalDeviceVersionDelegate get_ExternalDeviceVersion;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DevicePower)(interface IAMExtDevice * This, int PowerMode);
        public delegate int put_DevicePowerDelegate(@interface IAMExtDevice This, int PowerMode);
        public put_DevicePowerDelegate put_DevicePower;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DevicePower)(interface IAMExtDevice * This, int *pPowerMode);
        public delegate int get_DevicePowerDelegate(@interface IAMExtDevice This, ref int pPowerMode);
        public get_DevicePowerDelegate get_DevicePower;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Calibrate)(interface IAMExtDevice * This, System.IntPtr hEvent, int Mode, int *pStatus);
        public delegate int CalibrateDelegate(@interface IAMExtDevice This, IntPtr hEvent, int Mode, ref int pStatus);
        public CalibrateDelegate Calibrate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DevicePort)(interface IAMExtDevice * This, int DevicePort);
        public delegate int put_DevicePortDelegate(@interface IAMExtDevice This, int DevicePort);
        public put_DevicePortDelegate put_DevicePort;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DevicePort)(interface IAMExtDevice * This, int *pDevicePort);
        public delegate int get_DevicePortDelegate(@interface IAMExtDevice This, ref int pDevicePort);
        public get_DevicePortDelegate get_DevicePort;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMExtTransportVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMExtTransport * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMExtTransport This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMExtTransport * This);
        public delegate uint AddRefDelegate(@interface IAMExtTransport This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMExtTransport * This);
        public delegate uint ReleaseDelegate(@interface IAMExtTransport This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCapability)(interface IAMExtTransport * This, int Capability, int *pValue, double *pdblValue);
        public delegate int GetCapabilityDelegate(@interface IAMExtTransport This, int Capability, ref int pValue, ref double pdblValue);
        public GetCapabilityDelegate GetCapability;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MediaState)(interface IAMExtTransport * This, int State);
        public delegate int put_MediaStateDelegate(@interface IAMExtTransport This, int State);
        public put_MediaStateDelegate put_MediaState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MediaState)(interface IAMExtTransport * This, int *pState);
        public delegate int get_MediaStateDelegate(@interface IAMExtTransport This, ref int pState);
        public get_MediaStateDelegate get_MediaState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_LocalControl)(interface IAMExtTransport * This, int State);
        public delegate int put_LocalControlDelegate(@interface IAMExtTransport This, int State);
        public put_LocalControlDelegate put_LocalControl;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_LocalControl)(interface IAMExtTransport * This, int *pState);
        public delegate int get_LocalControlDelegate(@interface IAMExtTransport This, ref int pState);
        public get_LocalControlDelegate get_LocalControl;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStatus)(interface IAMExtTransport * This, int StatusItem, int *pValue);
        public delegate int GetStatusDelegate(@interface IAMExtTransport This, int StatusItem, ref int pValue);
        public GetStatusDelegate GetStatus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTransportBasicParameters)(interface IAMExtTransport * This, int Param, int *pValue, LPOLESTR *ppszData);
        public delegate int GetTransportBasicParametersDelegate(@interface IAMExtTransport This, int Param, ref int pValue, LPOLESTR ppszData);
        public GetTransportBasicParametersDelegate GetTransportBasicParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTransportBasicParameters)(interface IAMExtTransport * This, int Param, int Value, LPCOLESTR pszData);
        public delegate int SetTransportBasicParametersDelegate(@interface IAMExtTransport This, int Param, int Value, LPCOLESTR pszData);
        public SetTransportBasicParametersDelegate SetTransportBasicParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTransportVideoParameters)(interface IAMExtTransport * This, int Param, int *pValue);
        public delegate int GetTransportVideoParametersDelegate(@interface IAMExtTransport This, int Param, ref int pValue);
        public GetTransportVideoParametersDelegate GetTransportVideoParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTransportVideoParameters)(interface IAMExtTransport * This, int Param, int Value);
        public delegate int SetTransportVideoParametersDelegate(@interface IAMExtTransport This, int Param, int Value);
        public SetTransportVideoParametersDelegate SetTransportVideoParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTransportAudioParameters)(interface IAMExtTransport * This, int Param, int *pValue);
        public delegate int GetTransportAudioParametersDelegate(@interface IAMExtTransport This, int Param, ref int pValue);
        public GetTransportAudioParametersDelegate GetTransportAudioParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTransportAudioParameters)(interface IAMExtTransport * This, int Param, int Value);
        public delegate int SetTransportAudioParametersDelegate(@interface IAMExtTransport This, int Param, int Value);
        public SetTransportAudioParametersDelegate SetTransportAudioParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Mode)(interface IAMExtTransport * This, int Mode);
        public delegate int put_ModeDelegate(@interface IAMExtTransport This, int Mode);
        public put_ModeDelegate put_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Mode)(interface IAMExtTransport * This, int *pMode);
        public delegate int get_ModeDelegate(@interface IAMExtTransport This, ref int pMode);
        public get_ModeDelegate get_Mode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rate)(interface IAMExtTransport * This, double dblRate);
        public delegate int put_RateDelegate(@interface IAMExtTransport This, double dblRate);
        public put_RateDelegate put_Rate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Rate)(interface IAMExtTransport * This, double *pdblRate);
        public delegate int get_RateDelegate(@interface IAMExtTransport This, ref double pdblRate);
        public get_RateDelegate get_Rate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetChase)(interface IAMExtTransport * This, int *pEnabled, int *pOffset, System.IntPtr *phEvent);
        public delegate int GetChaseDelegate(@interface IAMExtTransport This, ref int pEnabled, ref int pOffset, IntPtr phEvent);
        public GetChaseDelegate GetChase;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetChase)(interface IAMExtTransport * This, int Enable, int Offset, System.IntPtr hEvent);
        public delegate int SetChaseDelegate(@interface IAMExtTransport This, int Enable, int Offset, IntPtr hEvent);
        public SetChaseDelegate SetChase;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBump)(interface IAMExtTransport * This, int *pSpeed, int *pDuration);
        public delegate int GetBumpDelegate(@interface IAMExtTransport This, ref int pSpeed, ref int pDuration);
        public GetBumpDelegate GetBump;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBump)(interface IAMExtTransport * This, int Speed, int Duration);
        public delegate int SetBumpDelegate(@interface IAMExtTransport This, int Speed, int Duration);
        public SetBumpDelegate SetBump;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AntiClogControl)(interface IAMExtTransport * This, int *pEnabled);
        public delegate int get_AntiClogControlDelegate(@interface IAMExtTransport This, ref int pEnabled);
        public get_AntiClogControlDelegate get_AntiClogControl;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_AntiClogControl)(interface IAMExtTransport * This, int Enable);
        public delegate int put_AntiClogControlDelegate(@interface IAMExtTransport This, int Enable);
        public put_AntiClogControlDelegate put_AntiClogControl;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEditPropertySet)(interface IAMExtTransport * This, int EditID, int *pState);
        public delegate int GetEditPropertySetDelegate(@interface IAMExtTransport This, int EditID, ref int pState);
        public GetEditPropertySetDelegate GetEditPropertySet;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetEditPropertySet)(interface IAMExtTransport * This, int *pEditID, int State);
        public delegate int SetEditPropertySetDelegate(@interface IAMExtTransport This, ref int pEditID, int State);
        public SetEditPropertySetDelegate SetEditPropertySet;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEditProperty)(interface IAMExtTransport * This, int EditID, int Param, int *pValue);
        public delegate int GetEditPropertyDelegate(@interface IAMExtTransport This, int EditID, int Param, ref int pValue);
        public GetEditPropertyDelegate GetEditProperty;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetEditProperty)(interface IAMExtTransport * This, int EditID, int Param, int Value);
        public delegate int SetEditPropertyDelegate(@interface IAMExtTransport This, int EditID, int Param, int Value);
        public SetEditPropertyDelegate SetEditProperty;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_EditStart)(interface IAMExtTransport * This, int *pValue);
        public delegate int get_EditStartDelegate(@interface IAMExtTransport This, ref int pValue);
        public get_EditStartDelegate get_EditStart;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_EditStart)(interface IAMExtTransport * This, int Value);
        public delegate int put_EditStartDelegate(@interface IAMExtTransport This, int Value);
        public put_EditStartDelegate put_EditStart;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0331 */
/* [local] */ 


#if false
//  /* the following is what MIDL knows how to remote */
// typedef struct tagTIMECODE
//    {
//    WORD wFrameRate;
//    WORD wFrameFract;
//    DWORD dwFrames;
//    } 	TIMECODE;
// 
#else // 0
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union _timecode
// {
//   struct
//   {
//     ushort wFrameRate;
//     ushort wFrameFract;
//     uint dwFrames;
//     };
//   ulong qw;
//   };

#endif // 0

public class tagTIMECODE_SAMPLE
{
    public long qwTick;
    public TIMECODE timecode = new TIMECODE();
    public uint dwUser;
    public uint dwFlags;
}

#else // C style interface

    public class IAMTimecodeReaderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTimecodeReader * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTimecodeReader This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTimecodeReader * This);
        public delegate uint AddRefDelegate(@interface IAMTimecodeReader This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTimecodeReader * This);
        public delegate uint ReleaseDelegate(@interface IAMTimecodeReader This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTCRMode)(interface IAMTimecodeReader * This, int Param, int *pValue);
        public delegate int GetTCRModeDelegate(@interface IAMTimecodeReader This, int Param, ref int pValue);
        public GetTCRModeDelegate GetTCRMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTCRMode)(interface IAMTimecodeReader * This, int Param, int Value);
        public delegate int SetTCRModeDelegate(@interface IAMTimecodeReader This, int Param, int Value);
        public SetTCRModeDelegate SetTCRMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_VITCLine)(interface IAMTimecodeReader * This, int Line);
        public delegate int put_VITCLineDelegate(@interface IAMTimecodeReader This, int Line);
        public put_VITCLineDelegate put_VITCLine;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VITCLine)(interface IAMTimecodeReader * This, int *pLine);
        public delegate int get_VITCLineDelegate(@interface IAMTimecodeReader This, ref int pLine);
        public get_VITCLineDelegate get_VITCLine;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTimecode)(interface IAMTimecodeReader * This, tagTIMECODE_SAMPLE * pTimecodeSample);
        public delegate int GetTimecodeDelegate(@interface IAMTimecodeReader This, tagTIMECODE_SAMPLE pTimecodeSample);
        public GetTimecodeDelegate GetTimecode;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMTimecodeGeneratorVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTimecodeGenerator * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTimecodeGenerator This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTimecodeGenerator * This);
        public delegate uint AddRefDelegate(@interface IAMTimecodeGenerator This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTimecodeGenerator * This);
        public delegate uint ReleaseDelegate(@interface IAMTimecodeGenerator This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTCGMode)(interface IAMTimecodeGenerator * This, int Param, int *pValue);
        public delegate int GetTCGModeDelegate(@interface IAMTimecodeGenerator This, int Param, ref int pValue);
        public GetTCGModeDelegate GetTCGMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTCGMode)(interface IAMTimecodeGenerator * This, int Param, int Value);
        public delegate int SetTCGModeDelegate(@interface IAMTimecodeGenerator This, int Param, int Value);
        public SetTCGModeDelegate SetTCGMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_VITCLine)(interface IAMTimecodeGenerator * This, int Line);
        public delegate int put_VITCLineDelegate(@interface IAMTimecodeGenerator This, int Line);
        public put_VITCLineDelegate put_VITCLine;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VITCLine)(interface IAMTimecodeGenerator * This, int *pLine);
        public delegate int get_VITCLineDelegate(@interface IAMTimecodeGenerator This, ref int pLine);
        public get_VITCLineDelegate get_VITCLine;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTimecode)(interface IAMTimecodeGenerator * This, tagTIMECODE_SAMPLE * pTimecodeSample);
        public delegate int SetTimecodeDelegate(@interface IAMTimecodeGenerator This, tagTIMECODE_SAMPLE pTimecodeSample);
        public SetTimecodeDelegate SetTimecode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTimecode)(interface IAMTimecodeGenerator * This, tagTIMECODE_SAMPLE * pTimecodeSample);
        public delegate int GetTimecodeDelegate(@interface IAMTimecodeGenerator This, tagTIMECODE_SAMPLE pTimecodeSample);
        public GetTimecodeDelegate GetTimecode;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMTimecodeDisplayVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMTimecodeDisplay * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMTimecodeDisplay This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMTimecodeDisplay * This);
        public delegate uint AddRefDelegate(@interface IAMTimecodeDisplay This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMTimecodeDisplay * This);
        public delegate uint ReleaseDelegate(@interface IAMTimecodeDisplay This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTCDisplayEnable)(interface IAMTimecodeDisplay * This, int *pState);
        public delegate int GetTCDisplayEnableDelegate(@interface IAMTimecodeDisplay This, ref int pState);
        public GetTCDisplayEnableDelegate GetTCDisplayEnable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTCDisplayEnable)(interface IAMTimecodeDisplay * This, int State);
        public delegate int SetTCDisplayEnableDelegate(@interface IAMTimecodeDisplay This, int State);
        public SetTCDisplayEnableDelegate SetTCDisplayEnable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTCDisplay)(interface IAMTimecodeDisplay * This, int Param, int *pValue);
        public delegate int GetTCDisplayDelegate(@interface IAMTimecodeDisplay This, int Param, ref int pValue);
        public GetTCDisplayDelegate GetTCDisplay;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetTCDisplay)(interface IAMTimecodeDisplay * This, int Param, int Value);
        public delegate int SetTCDisplayDelegate(@interface IAMTimecodeDisplay This, int Param, int Value);
        public SetTCDisplayDelegate SetTCDisplay;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMDevMemoryAllocatorVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMDevMemoryAllocator * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMDevMemoryAllocator This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMDevMemoryAllocator * This);
        public delegate uint AddRefDelegate(@interface IAMDevMemoryAllocator This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMDevMemoryAllocator * This);
        public delegate uint ReleaseDelegate(@interface IAMDevMemoryAllocator This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInfo)(interface IAMDevMemoryAllocator * This, uint *pdwcbTotalFree, uint *pdwcbLargestFree, uint *pdwcbTotalMemory, uint *pdwcbMinimumChunk);
        public delegate int GetInfoDelegate(@interface IAMDevMemoryAllocator This, ref uint pdwcbTotalFree, ref uint pdwcbLargestFree, ref uint pdwcbTotalMemory, ref uint pdwcbMinimumChunk);
        public GetInfoDelegate GetInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CheckMemory)(interface IAMDevMemoryAllocator * This, const byte *pBuffer);
        public delegate int CheckMemoryDelegate(@interface IAMDevMemoryAllocator This, byte pBuffer);
        public CheckMemoryDelegate CheckMemory;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Alloc)(interface IAMDevMemoryAllocator * This, byte **ppBuffer, uint *pdwcbBuffer);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int AllocDelegate(@interface IAMDevMemoryAllocator This, byte[] ppBuffer, ref uint pdwcbBuffer);
        public AllocDelegate Alloc;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Free)(interface IAMDevMemoryAllocator * This, byte *pBuffer);
        public delegate int FreeDelegate(@interface IAMDevMemoryAllocator This, ref byte pBuffer);
        public FreeDelegate Free;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDevMemoryObject)(interface IAMDevMemoryAllocator * This, IUnknown **ppUnkInnner, IUnknown *pUnkOuter);
        public delegate int GetDevMemoryObjectDelegate(@interface IAMDevMemoryAllocator This, IUnknown[] ppUnkInnner, IUnknown pUnkOuter);
        public GetDevMemoryObjectDelegate GetDevMemoryObject;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMDevMemoryControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMDevMemoryControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMDevMemoryControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMDevMemoryControl * This);
        public delegate uint AddRefDelegate(@interface IAMDevMemoryControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMDevMemoryControl * This);
        public delegate uint ReleaseDelegate(@interface IAMDevMemoryControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryWriteSync)(interface IAMDevMemoryControl * This);
        public delegate int QueryWriteSyncDelegate(@interface IAMDevMemoryControl This);
        public QueryWriteSyncDelegate QueryWriteSync;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WriteSync)(interface IAMDevMemoryControl * This);
        public delegate int WriteSyncDelegate(@interface IAMDevMemoryControl This);
        public WriteSyncDelegate WriteSync;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDevId)(interface IAMDevMemoryControl * This, uint *pdwDevId);
        public delegate int GetDevIdDelegate(@interface IAMDevMemoryControl This, ref uint pdwDevId);
        public GetDevIdDelegate GetDevId;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0336 */
/* [local] */ 



public enum _AMSTREAMSELECTINFOFLAGS
{
        AMSTREAMSELECTINFO_ENABLED = 0x1,
    AMSTREAMSELECTINFO_EXCLUSIVE = 0x2
}

public enum _AMSTREAMSELECTENABLEFLAGS
{
        AMSTREAMSELECTENABLE_ENABLE = 0x1,
    AMSTREAMSELECTENABLE_ENABLEALL = 0x2
}

#else // C style interface

    public class IAMStreamSelectVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMStreamSelect * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMStreamSelect This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMStreamSelect * This);
        public delegate uint AddRefDelegate(@interface IAMStreamSelect This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMStreamSelect * This);
        public delegate uint ReleaseDelegate(@interface IAMStreamSelect This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Count)(interface IAMStreamSelect * This, uint *pcStreams);
        public delegate int CountDelegate(@interface IAMStreamSelect This, ref uint pcStreams);
        public CountDelegate Count;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Info)(interface IAMStreamSelect * This, int lIndex, _AMMediaType **ppmt, uint *pdwFlags, uint *plcid, uint *pdwGroup, char **ppszName, IUnknown **ppObject, IUnknown **ppUnk);
        public delegate int InfoDelegate(@interface IAMStreamSelect This, int lIndex, _AMMediaType[] ppmt, ref uint pdwFlags, ref uint plcid, ref uint pdwGroup, string[] ppszName, IUnknown[] ppObject, IUnknown[] ppUnk);
        public InfoDelegate Info;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Enable)(interface IAMStreamSelect * This, int lIndex, uint dwFlags);
        public delegate int EnableDelegate(@interface IAMStreamSelect This, int lIndex, uint dwFlags);
        public EnableDelegate Enable;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0337 */
/* [local] */ 



public enum _AMRESCTL_RESERVEFLAGS
{
        AMRESCTL_RESERVEFLAGS_RESERVE = 0,
    AMRESCTL_RESERVEFLAGS_UNRESERVE = 0x1
}

#else // C style interface

    public class IAMResourceControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMResourceControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMResourceControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMResourceControl * This);
        public delegate uint AddRefDelegate(@interface IAMResourceControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMResourceControl * This);
        public delegate uint ReleaseDelegate(@interface IAMResourceControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reserve)(interface IAMResourceControl * This, uint dwFlags, object* pvReserved);
        public delegate int ReserveDelegate(@interface IAMResourceControl This, uint dwFlags, object pvReserved);
        public ReserveDelegate Reserve;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMClockAdjustVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMClockAdjust * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMClockAdjust This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMClockAdjust * This);
        public delegate uint AddRefDelegate(@interface IAMClockAdjust This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMClockAdjust * This);
        public delegate uint ReleaseDelegate(@interface IAMClockAdjust This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetClockDelta)(interface IAMClockAdjust * This, long rtDelta);
        public delegate int SetClockDeltaDelegate(@interface IAMClockAdjust This, long rtDelta);
        public SetClockDeltaDelegate SetClockDelta;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0339 */
/* [local] */ 


public enum _AM_FILTER_MISC_FLAGS
{
        AM_FILTER_MISC_FLAGS_IS_RENDERER = 0x1,
    AM_FILTER_MISC_FLAGS_IS_SOURCE = 0x2
}

#else // C style interface

    public class IAMFilterMiscFlagsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMFilterMiscFlags * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMFilterMiscFlags This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMFilterMiscFlags * This);
        public delegate uint AddRefDelegate(@interface IAMFilterMiscFlags This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMFilterMiscFlags * This);
        public delegate uint ReleaseDelegate(@interface IAMFilterMiscFlags This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *GetMiscFlags)(interface IAMFilterMiscFlags * This);
        public delegate uint GetMiscFlagsDelegate(@interface IAMFilterMiscFlags This);
        public GetMiscFlagsDelegate GetMiscFlags;

//        END_INTERFACE
    }

#else // C style interface

    public class IDrawVideoImageVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDrawVideoImage * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDrawVideoImage This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDrawVideoImage * This);
        public delegate uint AddRefDelegate(@interface IDrawVideoImage This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDrawVideoImage * This);
        public delegate uint ReleaseDelegate(@interface IDrawVideoImage This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DrawVideoImageBegin)(interface IDrawVideoImage * This);
        public delegate int DrawVideoImageBeginDelegate(@interface IDrawVideoImage This);
        public DrawVideoImageBeginDelegate DrawVideoImageBegin;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DrawVideoImageEnd)(interface IDrawVideoImage * This);
        public delegate int DrawVideoImageEndDelegate(@interface IDrawVideoImage This);
        public DrawVideoImageEndDelegate DrawVideoImageEnd;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DrawVideoImageDraw)(interface IDrawVideoImage * This, System.IntPtr hdc, LPRECT lprcSrc, LPRECT lprcDst);
        public delegate int DrawVideoImageDrawDelegate(@interface IDrawVideoImage This, IntPtr hdc, LPRECT lprcSrc, LPRECT lprcDst);
        public DrawVideoImageDrawDelegate DrawVideoImageDraw;

//        END_INTERFACE
    }

#else // C style interface

    public class IDecimateVideoImageVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDecimateVideoImage * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDecimateVideoImage This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDecimateVideoImage * This);
        public delegate uint AddRefDelegate(@interface IDecimateVideoImage This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDecimateVideoImage * This);
        public delegate uint ReleaseDelegate(@interface IDecimateVideoImage This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDecimationImageSize)(interface IDecimateVideoImage * This, int lWidth, int lHeight);
        public delegate int SetDecimationImageSizeDelegate(@interface IDecimateVideoImage This, int lWidth, int lHeight);
        public SetDecimationImageSizeDelegate SetDecimationImageSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ResetDecimationImageSize)(interface IDecimateVideoImage * This);
        public delegate int ResetDecimationImageSizeDelegate(@interface IDecimateVideoImage This);
        public ResetDecimationImageSizeDelegate ResetDecimationImageSize;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0342 */
/* [local] */ 

public enum _DECIMATION_USAGE
{
        DECIMATION_LEGACY = 0,
    DECIMATION_USE_DECODER_ONLY = DECIMATION_LEGACY + 1,
    DECIMATION_USE_VIDEOPORT_ONLY = DECIMATION_USE_DECODER_ONLY + 1,
    DECIMATION_USE_OVERLAY_ONLY = DECIMATION_USE_VIDEOPORT_ONLY + 1,
    DECIMATION_DEFAULT = DECIMATION_USE_OVERLAY_ONLY + 1
}

#else // C style interface

    public class IAMVideoDecimationPropertiesVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMVideoDecimationProperties * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMVideoDecimationProperties This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMVideoDecimationProperties * This);
        public delegate uint AddRefDelegate(@interface IAMVideoDecimationProperties This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMVideoDecimationProperties * This);
        public delegate uint ReleaseDelegate(@interface IAMVideoDecimationProperties This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryDecimationUsage)(interface IAMVideoDecimationProperties * This, DECIMATION_USAGE *lpUsage);
        public delegate int QueryDecimationUsageDelegate(@interface IAMVideoDecimationProperties This, DECIMATION_USAGE lpUsage);
        public QueryDecimationUsageDelegate QueryDecimationUsage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDecimationUsage)(interface IAMVideoDecimationProperties * This, DECIMATION_USAGE Usage);
        public delegate int SetDecimationUsageDelegate(@interface IAMVideoDecimationProperties This, DECIMATION_USAGE Usage);
        public SetDecimationUsageDelegate SetDecimationUsage;

//        END_INTERFACE
    }

#else // C style interface

    public class IVideoFrameStepVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVideoFrameStep * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVideoFrameStep This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVideoFrameStep * This);
        public delegate uint AddRefDelegate(@interface IVideoFrameStep This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVideoFrameStep * This);
        public delegate uint ReleaseDelegate(@interface IVideoFrameStep This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Step)(interface IVideoFrameStep * This, uint dwFrames, IUnknown *pStepObject);
        public delegate int StepDelegate(@interface IVideoFrameStep This, uint dwFrames, IUnknown pStepObject);
        public StepDelegate Step;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CanStep)(interface IVideoFrameStep * This, int bMultiple, IUnknown *pStepObject);
        public delegate int CanStepDelegate(@interface IVideoFrameStep This, int bMultiple, IUnknown pStepObject);
        public CanStepDelegate CanStep;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CancelStep)(interface IVideoFrameStep * This);
        public delegate int CancelStepDelegate(@interface IVideoFrameStep This);
        public CancelStepDelegate CancelStep;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0344 */
/* [local] */ 


public enum _AM_PUSHSOURCE_FLAGS
{
        AM_PUSHSOURCECAPS_INTERNAL_RM = 0x1,
    AM_PUSHSOURCECAPS_NOT_LIVE = 0x2,
    AM_PUSHSOURCECAPS_PRIVATE_CLOCK = 0x4,
    AM_PUSHSOURCEREQS_USE_STREAM_CLOCK = 0x10000
}

#else // C style interface

    public class IAMLatencyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMLatency * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMLatency This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMLatency * This);
        public delegate uint AddRefDelegate(@interface IAMLatency This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMLatency * This);
        public delegate uint ReleaseDelegate(@interface IAMLatency This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetLatency)(interface IAMLatency * This, long *prtLatency);
        public delegate int GetLatencyDelegate(@interface IAMLatency This, ref long prtLatency);
        public GetLatencyDelegate GetLatency;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMPushSourceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMPushSource * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMPushSource This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMPushSource * This);
        public delegate uint AddRefDelegate(@interface IAMPushSource This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMPushSource * This);
        public delegate uint ReleaseDelegate(@interface IAMPushSource This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetLatency)(interface IAMPushSource * This, long *prtLatency);
        public delegate int GetLatencyDelegate(@interface IAMPushSource This, ref long prtLatency);
        public GetLatencyDelegate GetLatency;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPushSourceFlags)(interface IAMPushSource * This, uint *pFlags);
        public delegate int GetPushSourceFlagsDelegate(@interface IAMPushSource This, ref uint pFlags);
        public GetPushSourceFlagsDelegate GetPushSourceFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetPushSourceFlags)(interface IAMPushSource * This, uint Flags);
        public delegate int SetPushSourceFlagsDelegate(@interface IAMPushSource This, uint Flags);
        public SetPushSourceFlagsDelegate SetPushSourceFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStreamOffset)(interface IAMPushSource * This, long rtOffset);
        public delegate int SetStreamOffsetDelegate(@interface IAMPushSource This, long rtOffset);
        public SetStreamOffsetDelegate SetStreamOffset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStreamOffset)(interface IAMPushSource * This, long *prtOffset);
        public delegate int GetStreamOffsetDelegate(@interface IAMPushSource This, ref long prtOffset);
        public GetStreamOffsetDelegate GetStreamOffset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMaxStreamOffset)(interface IAMPushSource * This, long *prtMaxOffset);
        public delegate int GetMaxStreamOffsetDelegate(@interface IAMPushSource This, ref long prtMaxOffset);
        public GetMaxStreamOffsetDelegate GetMaxStreamOffset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMaxStreamOffset)(interface IAMPushSource * This, long rtMaxOffset);
        public delegate int SetMaxStreamOffsetDelegate(@interface IAMPushSource This, long rtMaxOffset);
        public SetMaxStreamOffsetDelegate SetMaxStreamOffset;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMDeviceRemovalVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMDeviceRemoval * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMDeviceRemoval This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMDeviceRemoval * This);
        public delegate uint AddRefDelegate(@interface IAMDeviceRemoval This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMDeviceRemoval * This);
        public delegate uint ReleaseDelegate(@interface IAMDeviceRemoval This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DeviceInfo)(interface IAMDeviceRemoval * This, CLSID *pclsidInterfaceClass, char **pwszSymbolicLink);
        public delegate int DeviceInfoDelegate(@interface IAMDeviceRemoval This, CLSID pclsidInterfaceClass, string[] pwszSymbolicLink);
        public DeviceInfoDelegate DeviceInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reassociate)(interface IAMDeviceRemoval * This);
        public delegate int ReassociateDelegate(@interface IAMDeviceRemoval This);
        public ReassociateDelegate Reassociate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Disassociate)(interface IAMDeviceRemoval * This);
        public delegate int DisassociateDelegate(@interface IAMDeviceRemoval This);
        public DisassociateDelegate Disassociate;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0346 */
/* [local] */ 

public class __MIDL___MIDL_itf_strmif_0346_0001
{
    public uint dwDVAAuxSrc;
    public uint dwDVAAuxCtl;
    public uint dwDVAAuxSrc1;
    public uint dwDVAAuxCtl1;
    public uint dwDVVAuxSrc;
    public uint dwDVVAuxCtl;
    public uint[] dwDVReserved = new uint[2];
}



public enum _DVENCODERRESOLUTION
{
        DVENCODERRESOLUTION_720x480 = 2012,
    DVENCODERRESOLUTION_360x240 = 2013,
    DVENCODERRESOLUTION_180x120 = 2014,
    DVENCODERRESOLUTION_88x60 = 2015
}

public enum _DVENCODERVIDEOFORMAT
{
        DVENCODERVIDEOFORMAT_NTSC = 2000,
    DVENCODERVIDEOFORMAT_PAL = 2001
}

public enum _DVENCODERFORMAT
{
        DVENCODERFORMAT_DVSD = 2007,
    DVENCODERFORMAT_DVHD = 2008,
    DVENCODERFORMAT_DVSL = 2009
}

#else // C style interface

    public class IDVEncVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDVEnc * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDVEnc This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDVEnc * This);
        public delegate uint AddRefDelegate(@interface IDVEnc This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDVEnc * This);
        public delegate uint ReleaseDelegate(@interface IDVEnc This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_IFormatResolution)(interface IDVEnc * This, int *VideoFormat, int *DVFormat, int *Resolution, byte fDVInfo, __MIDL___MIDL_itf_strmif_0346_0001 *sDVInfo);
        public delegate int get_IFormatResolutionDelegate(@interface IDVEnc This, ref int VideoFormat, ref int DVFormat, ref int Resolution, byte fDVInfo, __MIDL___MIDL_itf_strmif_0346_0001 sDVInfo);
        public get_IFormatResolutionDelegate get_IFormatResolution;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_IFormatResolution)(interface IDVEnc * This, int VideoFormat, int DVFormat, int Resolution, byte fDVInfo, __MIDL___MIDL_itf_strmif_0346_0001 *sDVInfo);
        public delegate int put_IFormatResolutionDelegate(@interface IDVEnc This, int VideoFormat, int DVFormat, int Resolution, byte fDVInfo, __MIDL___MIDL_itf_strmif_0346_0001 sDVInfo);
        public put_IFormatResolutionDelegate put_IFormatResolution;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0347 */
/* [local] */ 


public enum _DVDECODERRESOLUTION
{
        DVDECODERRESOLUTION_720x480 = 1000,
    DVDECODERRESOLUTION_360x240 = 1001,
    DVDECODERRESOLUTION_180x120 = 1002,
    DVDECODERRESOLUTION_88x60 = 1003
}

public enum _DVRESOLUTION
{
        DVRESOLUTION_FULL = 1000,
    DVRESOLUTION_HALF = 1001,
    DVRESOLUTION_QUARTER = 1002,
    DVRESOLUTION_DC = 1003
}

#else // C style interface

    public class IIPDVDecVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IIPDVDec * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IIPDVDec This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IIPDVDec * This);
        public delegate uint AddRefDelegate(@interface IIPDVDec This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IIPDVDec * This);
        public delegate uint ReleaseDelegate(@interface IIPDVDec This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_IPDisplay)(interface IIPDVDec * This, int *displayPix);
        public delegate int get_IPDisplayDelegate(@interface IIPDVDec This, ref int displayPix);
        public get_IPDisplayDelegate get_IPDisplay;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_IPDisplay)(interface IIPDVDec * This, int displayPix);
        public delegate int put_IPDisplayDelegate(@interface IIPDVDec This, int displayPix);
        public put_IPDisplayDelegate put_IPDisplay;

//        END_INTERFACE
    }

#else // C style interface

    public class IDVRGB219Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDVRGB219 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDVRGB219 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDVRGB219 * This);
        public delegate uint AddRefDelegate(@interface IDVRGB219 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDVRGB219 * This);
        public delegate uint ReleaseDelegate(@interface IDVRGB219 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRGB219)(interface IDVRGB219 * This, bool bState);
        public delegate int SetRGB219Delegate(@interface IDVRGB219 This, bool bState);
        public SetRGB219Delegate SetRGB219;

//        END_INTERFACE
    }

#else // C style interface

    public class IDVSplitterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDVSplitter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDVSplitter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDVSplitter * This);
        public delegate uint AddRefDelegate(@interface IDVSplitter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDVSplitter * This);
        public delegate uint ReleaseDelegate(@interface IDVSplitter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DiscardAlternateVideoFrames)(interface IDVSplitter * This, int nDiscard);
        public delegate int DiscardAlternateVideoFramesDelegate(@interface IDVSplitter This, int nDiscard);
        public DiscardAlternateVideoFramesDelegate DiscardAlternateVideoFrames;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0350 */
/* [local] */ 


public enum _AM_AUDIO_RENDERER_STAT_PARAM
{
        AM_AUDREND_STAT_PARAM_BREAK_COUNT = 1,
    AM_AUDREND_STAT_PARAM_SLAVE_MODE = AM_AUDREND_STAT_PARAM_BREAK_COUNT + 1,
    AM_AUDREND_STAT_PARAM_SILENCE_DUR = AM_AUDREND_STAT_PARAM_SLAVE_MODE + 1,
    AM_AUDREND_STAT_PARAM_LAST_BUFFER_DUR = AM_AUDREND_STAT_PARAM_SILENCE_DUR + 1,
    AM_AUDREND_STAT_PARAM_DISCONTINUITIES = AM_AUDREND_STAT_PARAM_LAST_BUFFER_DUR + 1,
    AM_AUDREND_STAT_PARAM_SLAVE_RATE = AM_AUDREND_STAT_PARAM_DISCONTINUITIES + 1,
    AM_AUDREND_STAT_PARAM_SLAVE_DROPWRITE_DUR = AM_AUDREND_STAT_PARAM_SLAVE_RATE + 1,
    AM_AUDREND_STAT_PARAM_SLAVE_HIGHLOWERROR = AM_AUDREND_STAT_PARAM_SLAVE_DROPWRITE_DUR + 1,
    AM_AUDREND_STAT_PARAM_SLAVE_LASTHIGHLOWERROR = AM_AUDREND_STAT_PARAM_SLAVE_HIGHLOWERROR + 1,
    AM_AUDREND_STAT_PARAM_SLAVE_ACCUMERROR = AM_AUDREND_STAT_PARAM_SLAVE_LASTHIGHLOWERROR + 1,
    AM_AUDREND_STAT_PARAM_BUFFERFULLNESS = AM_AUDREND_STAT_PARAM_SLAVE_ACCUMERROR + 1,
    AM_AUDREND_STAT_PARAM_JITTER = AM_AUDREND_STAT_PARAM_BUFFERFULLNESS + 1
}

#else // C style interface

    public class IAMAudioRendererStatsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMAudioRendererStats * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMAudioRendererStats This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMAudioRendererStats * This);
        public delegate uint AddRefDelegate(@interface IAMAudioRendererStats This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMAudioRendererStats * This);
        public delegate uint ReleaseDelegate(@interface IAMAudioRendererStats This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStatParam)(interface IAMAudioRendererStats * This, uint dwParam, uint *pdwParam1, uint *pdwParam2);
        public delegate int GetStatParamDelegate(@interface IAMAudioRendererStats This, uint dwParam, ref uint pdwParam1, ref uint pdwParam2);
        public GetStatParamDelegate GetStatParam;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0352 */
/* [local] */ 


public enum _AM_INTF_SEARCH_FLAGS
{
        AM_INTF_SEARCH_INPUT_PIN = 0x1,
    AM_INTF_SEARCH_OUTPUT_PIN = 0x2,
    AM_INTF_SEARCH_FILTER = 0x4
}

#else // C style interface

    public class IAMGraphStreamsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMGraphStreams * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMGraphStreams This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMGraphStreams * This);
        public delegate uint AddRefDelegate(@interface IAMGraphStreams This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMGraphStreams * This);
        public delegate uint ReleaseDelegate(@interface IAMGraphStreams This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindUpstreamInterface)(interface IAMGraphStreams * This, interface IPin *pPin, REFIID riid, object**ppvInterface, uint dwFlags);
        public delegate int FindUpstreamInterfaceDelegate(@interface IAMGraphStreams This, @interface IPin pPin, REFIID riid, object ppvInterface[] UnnamedParameter, uint dwFlags);
        public FindUpstreamInterfaceDelegate FindUpstreamInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SyncUsingStreamOffset)(interface IAMGraphStreams * This, bool bUseStreamOffset);
        public delegate int SyncUsingStreamOffsetDelegate(@interface IAMGraphStreams This, bool bUseStreamOffset);
        public SyncUsingStreamOffsetDelegate SyncUsingStreamOffset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMaxGraphLatency)(interface IAMGraphStreams * This, long rtMaxGraphLatency);
        public delegate int SetMaxGraphLatencyDelegate(@interface IAMGraphStreams This, long rtMaxGraphLatency);
        public SetMaxGraphLatencyDelegate SetMaxGraphLatency;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0353 */
/* [local] */ 


public enum AMOVERLAYFX
{
        AMOVERFX_NOFX = 0,
    AMOVERFX_MIRRORLEFTRIGHT = 0x2,
    AMOVERFX_MIRRORUPDOWN = 0x4,
    AMOVERFX_DEINTERLACE = 0x8
}

#else // C style interface

    public class IAMOverlayFXVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMOverlayFX * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMOverlayFX This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMOverlayFX * This);
        public delegate uint AddRefDelegate(@interface IAMOverlayFX This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMOverlayFX * This);
        public delegate uint ReleaseDelegate(@interface IAMOverlayFX This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryOverlayFXCaps)(interface IAMOverlayFX * This, uint *lpdwOverlayFXCaps);
        public delegate int QueryOverlayFXCapsDelegate(@interface IAMOverlayFX This, ref uint lpdwOverlayFXCaps);
        public QueryOverlayFXCapsDelegate QueryOverlayFXCaps;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOverlayFX)(interface IAMOverlayFX * This, uint dwOverlayFX);
        public delegate int SetOverlayFXDelegate(@interface IAMOverlayFX This, uint dwOverlayFX);
        public SetOverlayFXDelegate SetOverlayFX;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOverlayFX)(interface IAMOverlayFX * This, uint *lpdwOverlayFX);
        public delegate int GetOverlayFXDelegate(@interface IAMOverlayFX This, ref uint lpdwOverlayFX);
        public GetOverlayFXDelegate GetOverlayFX;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMOpenProgressVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMOpenProgress * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMOpenProgress This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMOpenProgress * This);
        public delegate uint AddRefDelegate(@interface IAMOpenProgress This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMOpenProgress * This);
        public delegate uint ReleaseDelegate(@interface IAMOpenProgress This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryProgress)(interface IAMOpenProgress * This, long *pllTotal, long *pllCurrent);
        public delegate int QueryProgressDelegate(@interface IAMOpenProgress This, ref long pllTotal, ref long pllCurrent);
        public QueryProgressDelegate QueryProgress;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AbortOperation)(interface IAMOpenProgress * This);
        public delegate int AbortOperationDelegate(@interface IAMOpenProgress This);
        public AbortOperationDelegate AbortOperation;

//        END_INTERFACE
    }

#else // C style interface

    public class IMpeg2DemultiplexerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMpeg2Demultiplexer * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMpeg2Demultiplexer This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMpeg2Demultiplexer * This);
        public delegate uint AddRefDelegate(@interface IMpeg2Demultiplexer This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMpeg2Demultiplexer * This);
        public delegate uint ReleaseDelegate(@interface IMpeg2Demultiplexer This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateOutputPin)(interface IMpeg2Demultiplexer * This, _AMMediaType *pMediaType, char* pszPinName, interface IPin **ppIPin);
        public delegate int CreateOutputPinDelegate(@interface IMpeg2Demultiplexer This, _AMMediaType pMediaType, ref string pszPinName, @interface IPin[] ppIPin);
        public CreateOutputPinDelegate CreateOutputPin;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputPinMediaType)(interface IMpeg2Demultiplexer * This, char* pszPinName, _AMMediaType *pMediaType);
        public delegate int SetOutputPinMediaTypeDelegate(@interface IMpeg2Demultiplexer This, ref string pszPinName, _AMMediaType pMediaType);
        public SetOutputPinMediaTypeDelegate SetOutputPinMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DeleteOutputPin)(interface IMpeg2Demultiplexer * This, char* pszPinName);
        public delegate int DeleteOutputPinDelegate(@interface IMpeg2Demultiplexer This, ref string pszPinName);
        public DeleteOutputPinDelegate DeleteOutputPin;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0356 */
/* [local] */ 

public class __MIDL___MIDL_itf_strmif_0356_0001
{
    public uint stream_id;
    public uint dwMediaSampleContent;
    public uint ulSubstreamFilterValue;
    public int iDataOffset;
}

#else // C style interface

    public class IEnumStreamIdMapVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEnumStreamIdMap * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEnumStreamIdMap This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEnumStreamIdMap * This);
        public delegate uint AddRefDelegate(@interface IEnumStreamIdMap This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEnumStreamIdMap * This);
        public delegate uint ReleaseDelegate(@interface IEnumStreamIdMap This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Next)(interface IEnumStreamIdMap * This, uint cRequest, __MIDL___MIDL_itf_strmif_0356_0001 *pStreamIdMap, uint *pcReceived);
        public delegate int NextDelegate(@interface IEnumStreamIdMap This, uint cRequest, __MIDL___MIDL_itf_strmif_0356_0001 pStreamIdMap, ref uint pcReceived);
        public NextDelegate Next;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Skip)(interface IEnumStreamIdMap * This, uint cRecords);
        public delegate int SkipDelegate(@interface IEnumStreamIdMap This, uint cRecords);
        public SkipDelegate Skip;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IEnumStreamIdMap * This);
        public delegate int ResetDelegate(@interface IEnumStreamIdMap This);
        public ResetDelegate Reset;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Clone)(interface IEnumStreamIdMap * This, interface IEnumStreamIdMap **ppIEnumStreamIdMap);
        public delegate int CloneDelegate(@interface IEnumStreamIdMap This, @interface IEnumStreamIdMap[] ppIEnumStreamIdMap);
        public CloneDelegate Clone;

//        END_INTERFACE
    }

#else // C style interface

    public class IMPEG2StreamIdMapVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMPEG2StreamIdMap * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMPEG2StreamIdMap This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMPEG2StreamIdMap * This);
        public delegate uint AddRefDelegate(@interface IMPEG2StreamIdMap This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMPEG2StreamIdMap * This);
        public delegate uint ReleaseDelegate(@interface IMPEG2StreamIdMap This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MapStreamId)(interface IMPEG2StreamIdMap * This, uint ulStreamId, uint MediaSampleContent, uint ulSubstreamFilterValue, int iDataOffset);
        public delegate int MapStreamIdDelegate(@interface IMPEG2StreamIdMap This, uint ulStreamId, uint MediaSampleContent, uint ulSubstreamFilterValue, int iDataOffset);
        public MapStreamIdDelegate MapStreamId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnmapStreamId)(interface IMPEG2StreamIdMap * This, uint culStreamId, uint *pulStreamId);
        public delegate int UnmapStreamIdDelegate(@interface IMPEG2StreamIdMap This, uint culStreamId, ref uint pulStreamId);
        public UnmapStreamIdDelegate UnmapStreamId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumStreamIdMap)(interface IMPEG2StreamIdMap * This, interface IEnumStreamIdMap **ppIEnumStreamIdMap);
        public delegate int EnumStreamIdMapDelegate(@interface IMPEG2StreamIdMap This, @interface IEnumStreamIdMap[] ppIEnumStreamIdMap);
        public EnumStreamIdMapDelegate EnumStreamIdMap;

//        END_INTERFACE
    }

#else // C style interface

    public class IRegisterServiceProviderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IRegisterServiceProvider * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IRegisterServiceProvider This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IRegisterServiceProvider * This);
        public delegate uint AddRefDelegate(@interface IRegisterServiceProvider This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IRegisterServiceProvider * This);
        public delegate uint ReleaseDelegate(@interface IRegisterServiceProvider This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterService)(interface IRegisterServiceProvider * This, REFGUID guidService, IUnknown *pUnkObject);
        public delegate int RegisterServiceDelegate(@interface IRegisterServiceProvider This, REFGUID guidService, IUnknown pUnkObject);
        public RegisterServiceDelegate RegisterService;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMClockSlaveVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMClockSlave * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMClockSlave This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMClockSlave * This);
        public delegate uint AddRefDelegate(@interface IAMClockSlave This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMClockSlave * This);
        public delegate uint ReleaseDelegate(@interface IAMClockSlave This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetErrorTolerance)(interface IAMClockSlave * This, uint dwTolerance);
        public delegate int SetErrorToleranceDelegate(@interface IAMClockSlave This, uint dwTolerance);
        public SetErrorToleranceDelegate SetErrorTolerance;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetErrorTolerance)(interface IAMClockSlave * This, uint *pdwTolerance);
        public delegate int GetErrorToleranceDelegate(@interface IAMClockSlave This, ref uint pdwTolerance);
        public GetErrorToleranceDelegate GetErrorTolerance;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMGraphBuilderCallbackVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMGraphBuilderCallback * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMGraphBuilderCallback This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMGraphBuilderCallback * This);
        public delegate uint AddRefDelegate(@interface IAMGraphBuilderCallback This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMGraphBuilderCallback * This);
        public delegate uint ReleaseDelegate(@interface IAMGraphBuilderCallback This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectedFilter)(interface IAMGraphBuilderCallback * This, IMoniker *pMon);
        public delegate int SelectedFilterDelegate(@interface IAMGraphBuilderCallback This, IMoniker pMon);
        public SelectedFilterDelegate SelectedFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreatedFilter)(interface IAMGraphBuilderCallback * This, interface IBaseFilter *pFil);
        public delegate int CreatedFilterDelegate(@interface IAMGraphBuilderCallback This, @interface IBaseFilter pFil);
        public CreatedFilterDelegate CreatedFilter;

//        END_INTERFACE
    }
public class CodecAPIEventData
{
    public GUID guid = new GUID();
    public uint dataLength;
    public uint[] reserved = new uint[3];
}

#else // C style interface

    public class ICodecAPIVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICodecAPI * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICodecAPI This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICodecAPI * This);
        public delegate uint AddRefDelegate(@interface ICodecAPI This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICodecAPI * This);
        public delegate uint ReleaseDelegate(@interface ICodecAPI This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSupported)(interface ICodecAPI * This, const GUID *Api);
        public delegate int IsSupportedDelegate(@interface ICodecAPI This, GUID Api);
        public IsSupportedDelegate IsSupported;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsModifiable)(interface ICodecAPI * This, const GUID *Api);
        public delegate int IsModifiableDelegate(@interface ICodecAPI This, GUID Api);
        public IsModifiableDelegate IsModifiable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParameterRange)(interface ICodecAPI * This, const GUID *Api, VARIANT *ValueMin, VARIANT *ValueMax, VARIANT *SteppingDelta);
        public delegate int GetParameterRangeDelegate(@interface ICodecAPI This, GUID Api, VARIANT ValueMin, VARIANT ValueMax, VARIANT SteppingDelta);
        public GetParameterRangeDelegate GetParameterRange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParameterValues)(interface ICodecAPI * This, const GUID *Api, VARIANT **Values, uint *ValuesCount);
        public delegate int GetParameterValuesDelegate(@interface ICodecAPI This, GUID Api, VARIANT[] Values, ref uint ValuesCount);
        public GetParameterValuesDelegate GetParameterValues;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultValue)(interface ICodecAPI * This, const GUID *Api, VARIANT *Value);
        public delegate int GetDefaultValueDelegate(@interface ICodecAPI This, GUID Api, VARIANT Value);
        public GetDefaultValueDelegate GetDefaultValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetValue)(interface ICodecAPI * This, const GUID *Api, VARIANT *Value);
        public delegate int GetValueDelegate(@interface ICodecAPI This, GUID Api, VARIANT Value);
        public GetValueDelegate GetValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetValue)(interface ICodecAPI * This, const GUID *Api, VARIANT *Value);
        public delegate int SetValueDelegate(@interface ICodecAPI This, GUID Api, VARIANT Value);
        public SetValueDelegate SetValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RegisterForEvent)(interface ICodecAPI * This, const GUID *Api, System.IntPtr userData);
        public delegate int RegisterForEventDelegate(@interface ICodecAPI This, GUID Api, IntPtr userData);
        public RegisterForEventDelegate RegisterForEvent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnregisterForEvent)(interface ICodecAPI * This, const GUID *Api);
        public delegate int UnregisterForEventDelegate(@interface ICodecAPI This, GUID Api);
        public UnregisterForEventDelegate UnregisterForEvent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAllDefaults)(interface ICodecAPI * This);
        public delegate int SetAllDefaultsDelegate(@interface ICodecAPI This);
        public SetAllDefaultsDelegate SetAllDefaults;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetValueWithNotify)(interface ICodecAPI * This, const GUID *Api, VARIANT *Value, GUID **ChangedParam, uint *ChangedParamCount);
        public delegate int SetValueWithNotifyDelegate(@interface ICodecAPI This, GUID Api, VARIANT Value, GUID[] ChangedParam, ref uint ChangedParamCount);
        public SetValueWithNotifyDelegate SetValueWithNotify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAllDefaultsWithNotify)(interface ICodecAPI * This, GUID **ChangedParam, uint *ChangedParamCount);
        public delegate int SetAllDefaultsWithNotifyDelegate(@interface ICodecAPI This, GUID[] ChangedParam, ref uint ChangedParamCount);
        public SetAllDefaultsWithNotifyDelegate SetAllDefaultsWithNotify;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllSettings)(interface ICodecAPI * This, IStream *__MIDL_0016);
        public delegate int GetAllSettingsDelegate(@interface ICodecAPI This, IStream __MIDL_0016);
        public GetAllSettingsDelegate GetAllSettings;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAllSettings)(interface ICodecAPI * This, IStream *__MIDL_0017);
        public delegate int SetAllSettingsDelegate(@interface ICodecAPI This, IStream __MIDL_0017);
        public SetAllSettingsDelegate SetAllSettings;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAllSettingsWithNotify)(interface ICodecAPI * This, IStream *__MIDL_0018, GUID **ChangedParam, uint *ChangedParamCount);
        public delegate int SetAllSettingsWithNotifyDelegate(@interface ICodecAPI This, IStream __MIDL_0018, GUID[] ChangedParam, ref uint ChangedParamCount);
        public SetAllSettingsWithNotifyDelegate SetAllSettingsWithNotify;

//        END_INTERFACE
    }

#else // C style interface

    public class IGetCapabilitiesKeyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IGetCapabilitiesKey * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IGetCapabilitiesKey This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IGetCapabilitiesKey * This);
        public delegate uint AddRefDelegate(@interface IGetCapabilitiesKey This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IGetCapabilitiesKey * This);
        public delegate uint ReleaseDelegate(@interface IGetCapabilitiesKey This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCapabilitiesKey)(interface IGetCapabilitiesKey * This, System.IntPtr *pHKey);
        public delegate int GetCapabilitiesKeyDelegate(@interface IGetCapabilitiesKey This, IntPtr pHKey);
        public GetCapabilitiesKeyDelegate GetCapabilitiesKey;

//        END_INTERFACE
    }

#else // C style interface

    public class IEncoderAPIVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IEncoderAPI * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IEncoderAPI This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IEncoderAPI * This);
        public delegate uint AddRefDelegate(@interface IEncoderAPI This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IEncoderAPI * This);
        public delegate uint ReleaseDelegate(@interface IEncoderAPI This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSupported)(interface IEncoderAPI * This, const GUID *Api);
        public delegate int IsSupportedDelegate(@interface IEncoderAPI This, GUID Api);
        public IsSupportedDelegate IsSupported;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsAvailable)(interface IEncoderAPI * This, const GUID *Api);
        public delegate int IsAvailableDelegate(@interface IEncoderAPI This, GUID Api);
        public IsAvailableDelegate IsAvailable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParameterRange)(interface IEncoderAPI * This, const GUID *Api, VARIANT *ValueMin, VARIANT *ValueMax, VARIANT *SteppingDelta);
        public delegate int GetParameterRangeDelegate(@interface IEncoderAPI This, GUID Api, VARIANT ValueMin, VARIANT ValueMax, VARIANT SteppingDelta);
        public GetParameterRangeDelegate GetParameterRange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParameterValues)(interface IEncoderAPI * This, const GUID *Api, VARIANT **Values, uint *ValuesCount);
        public delegate int GetParameterValuesDelegate(@interface IEncoderAPI This, GUID Api, VARIANT[] Values, ref uint ValuesCount);
        public GetParameterValuesDelegate GetParameterValues;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultValue)(interface IEncoderAPI * This, const GUID *Api, VARIANT *Value);
        public delegate int GetDefaultValueDelegate(@interface IEncoderAPI This, GUID Api, VARIANT Value);
        public GetDefaultValueDelegate GetDefaultValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetValue)(interface IEncoderAPI * This, const GUID *Api, VARIANT *Value);
        public delegate int GetValueDelegate(@interface IEncoderAPI This, GUID Api, VARIANT Value);
        public GetValueDelegate GetValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetValue)(interface IEncoderAPI * This, const GUID *Api, VARIANT *Value);
        public delegate int SetValueDelegate(@interface IEncoderAPI This, GUID Api, VARIANT Value);
        public SetValueDelegate SetValue;

//        END_INTERFACE
    }

#else // C style interface

    public class IVideoEncoderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVideoEncoder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVideoEncoder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVideoEncoder * This);
        public delegate uint AddRefDelegate(@interface IVideoEncoder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVideoEncoder * This);
        public delegate uint ReleaseDelegate(@interface IVideoEncoder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSupported)(interface IVideoEncoder * This, const GUID *Api);
        public delegate int IsSupportedDelegate(@interface IVideoEncoder This, GUID Api);
        public IsSupportedDelegate IsSupported;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsAvailable)(interface IVideoEncoder * This, const GUID *Api);
        public delegate int IsAvailableDelegate(@interface IVideoEncoder This, GUID Api);
        public IsAvailableDelegate IsAvailable;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParameterRange)(interface IVideoEncoder * This, const GUID *Api, VARIANT *ValueMin, VARIANT *ValueMax, VARIANT *SteppingDelta);
        public delegate int GetParameterRangeDelegate(@interface IVideoEncoder This, GUID Api, VARIANT ValueMin, VARIANT ValueMax, VARIANT SteppingDelta);
        public GetParameterRangeDelegate GetParameterRange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParameterValues)(interface IVideoEncoder * This, const GUID *Api, VARIANT **Values, uint *ValuesCount);
        public delegate int GetParameterValuesDelegate(@interface IVideoEncoder This, GUID Api, VARIANT[] Values, ref uint ValuesCount);
        public GetParameterValuesDelegate GetParameterValues;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultValue)(interface IVideoEncoder * This, const GUID *Api, VARIANT *Value);
        public delegate int GetDefaultValueDelegate(@interface IVideoEncoder This, GUID Api, VARIANT Value);
        public GetDefaultValueDelegate GetDefaultValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetValue)(interface IVideoEncoder * This, const GUID *Api, VARIANT *Value);
        public delegate int GetValueDelegate(@interface IVideoEncoder This, GUID Api, VARIANT Value);
        public GetValueDelegate GetValue;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetValue)(interface IVideoEncoder * This, const GUID *Api, VARIANT *Value);
        public delegate int SetValueDelegate(@interface IVideoEncoder This, GUID Api, VARIANT Value);
        public SetValueDelegate SetValue;

//        END_INTERFACE
    }






/* interface __MIDL_itf_strmif_0365 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0365_0001
{
        ConstantBitRate = 0,
    VariableBitRateAverage = ConstantBitRate + 1,
    VariableBitRatePeak = VariableBitRateAverage + 1
}

#else // C style interface

    public class IAMDecoderCapsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMDecoderCaps * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMDecoderCaps This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMDecoderCaps * This);
        public delegate uint AddRefDelegate(@interface IAMDecoderCaps This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMDecoderCaps * This);
        public delegate uint ReleaseDelegate(@interface IAMDecoderCaps This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDecoderCaps)(interface IAMDecoderCaps * This, uint dwCapIndex, uint *lpdwCap);
        public delegate int GetDecoderCapsDelegate(@interface IAMDecoderCaps This, uint dwCapIndex, ref uint lpdwCap);
        public GetDecoderCapsDelegate GetDecoderCaps;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0366 */
/* [local] */ 

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









public enum tagDVD_DOMAIN
{
        DVD_DOMAIN_FirstPlay = 1,
    DVD_DOMAIN_VideoManagerMenu = DVD_DOMAIN_FirstPlay + 1,
    DVD_DOMAIN_VideoTitleSetMenu = DVD_DOMAIN_VideoManagerMenu + 1,
    DVD_DOMAIN_Title = DVD_DOMAIN_VideoTitleSetMenu + 1,
    DVD_DOMAIN_Stop = DVD_DOMAIN_Title + 1
}

public enum tagDVD_MENU_ID
{
        DVD_MENU_Title = 2,
    DVD_MENU_Root = 3,
    DVD_MENU_Subpicture = 4,
    DVD_MENU_Audio = 5,
    DVD_MENU_Angle = 6,
    DVD_MENU_Chapter = 7
}

public enum tagDVD_DISC_SIDE
{
        DVD_SIDE_A = 1,
    DVD_SIDE_B = 2
}

public enum tagDVD_PREFERRED_DISPLAY_MODE
{
        DISPLAY_CONTENT_DEFAULT = 0,
    DISPLAY_16x9 = 1,
    DISPLAY_4x3_PANSCAN_PREFERRED = 2,
    DISPLAY_4x3_LETTERBOX_PREFERRED = 3
}




public class tagDVD_ATR
{
    public uint ulCAT;
    public byte[] pbATRI = new byte[768];
}




public enum tagDVD_FRAMERATE
{
        DVD_FPS_25 = 1,
    DVD_FPS_30NonDrop = 3
}

public class tagDVD_TIMECODE
{
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Hours1 :4; // Hours
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Hours10 :4; // Tens of Hours

// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Minutes1 :4; // Minutes
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Minutes10:4; // Tens of Minutes

// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Seconds1 :4; // Seconds
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Seconds10:4; // Tens of Seconds

// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Frames1 :4; // Frames
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint Frames10 :2; // Tens of Frames

// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
   public uint FrameRateCode: 2; // use DVD_FRAMERATE to indicate frames/sec and drop/non-drop
}
public enum tagDVD_TIMECODE_FLAGS
{
        DVD_TC_FLAG_25fps = 0x1,
    DVD_TC_FLAG_30fps = 0x2,
    DVD_TC_FLAG_DropFrame = 0x4,
    DVD_TC_FLAG_Interpolated = 0x8
}

public class tagDVD_HMSF_TIMECODE
{
    public byte bHours;
    public byte bMinutes;
    public byte bSeconds;
    public byte bFrames;
}

public class tagDVD_PLAYBACK_LOCATION2
{
    public uint TitleNum;
    public uint ChapterNum;
    public tagDVD_HMSF_TIMECODE TimeCode = new tagDVD_HMSF_TIMECODE();
    public uint TimeCodeFlags;
}

public class tagDVD_PLAYBACK_LOCATION
{
    public uint TitleNum;
    public uint ChapterNum;
    public uint TimeCode;
}


public enum __MIDL___MIDL_itf_strmif_0366_0001
{
        UOP_FLAG_Play_Title_Or_AtTime = 0x1,
    UOP_FLAG_Play_Chapter = 0x2,
    UOP_FLAG_Play_Title = 0x4,
    UOP_FLAG_Stop = 0x8,
    UOP_FLAG_ReturnFromSubMenu = 0x10,
    UOP_FLAG_Play_Chapter_Or_AtTime = 0x20,
    UOP_FLAG_PlayPrev_Or_Replay_Chapter = 0x40,
    UOP_FLAG_PlayNext_Chapter = 0x80,
    UOP_FLAG_Play_Forwards = 0x100,
    UOP_FLAG_Play_Backwards = 0x200,
    UOP_FLAG_ShowMenu_Title = 0x400,
    UOP_FLAG_ShowMenu_Root = 0x800,
    UOP_FLAG_ShowMenu_SubPic = 0x1000,
    UOP_FLAG_ShowMenu_Audio = 0x2000,
    UOP_FLAG_ShowMenu_Angle = 0x4000,
    UOP_FLAG_ShowMenu_Chapter = 0x8000,
    UOP_FLAG_Resume = 0x10000,
    UOP_FLAG_Select_Or_Activate_Button = 0x20000,
    UOP_FLAG_Still_Off = 0x40000,
    UOP_FLAG_Pause_On = 0x80000,
    UOP_FLAG_Select_Audio_Stream = 0x100000,
    UOP_FLAG_Select_SubPic_Stream = 0x200000,
    UOP_FLAG_Select_Angle = 0x400000,
    UOP_FLAG_Select_Karaoke_Audio_Presentation_Mode = 0x800000,
    UOP_FLAG_Select_Video_Mode_Preference = 0x1000000
}

public enum __MIDL___MIDL_itf_strmif_0366_0002
{
        DVD_CMD_FLAG_None = 0,
    DVD_CMD_FLAG_Flush = 0x1,
    DVD_CMD_FLAG_SendEvents = 0x2,
    DVD_CMD_FLAG_Block = 0x4,
    DVD_CMD_FLAG_StartWhenRendered = 0x8,
    DVD_CMD_FLAG_EndAfterRendered = 0x10
}

public enum __MIDL___MIDL_itf_strmif_0366_0003
{
        DVD_ResetOnStop = 1,
    DVD_NotifyParentalLevelChange = 2,
    DVD_HMSF_TimeCodeEvents = 3,
    DVD_AudioDuringFFwdRew = 4
}

public enum __MIDL___MIDL_itf_strmif_0366_0004
{
        DVD_Relative_Upper = 1,
    DVD_Relative_Lower = 2,
    DVD_Relative_Left = 3,
    DVD_Relative_Right = 4
}

public enum tagDVD_PARENTAL_LEVEL
{
        DVD_PARENTAL_LEVEL_8 = 0x8000,
    DVD_PARENTAL_LEVEL_7 = 0x4000,
    DVD_PARENTAL_LEVEL_6 = 0x2000,
    DVD_PARENTAL_LEVEL_5 = 0x1000,
    DVD_PARENTAL_LEVEL_4 = 0x800,
    DVD_PARENTAL_LEVEL_3 = 0x400,
    DVD_PARENTAL_LEVEL_2 = 0x200,
    DVD_PARENTAL_LEVEL_1 = 0x100
}

public enum tagDVD_AUDIO_LANG_EXT
{
        DVD_AUD_EXT_NotSpecified = 0,
    DVD_AUD_EXT_Captions = 1,
    DVD_AUD_EXT_VisuallyImpaired = 2,
    DVD_AUD_EXT_DirectorComments1 = 3,
    DVD_AUD_EXT_DirectorComments2 = 4
}

public enum tagDVD_SUBPICTURE_LANG_EXT
{
        DVD_SP_EXT_NotSpecified = 0,
    DVD_SP_EXT_Caption_Normal = 1,
    DVD_SP_EXT_Caption_Big = 2,
    DVD_SP_EXT_Caption_Children = 3,
    DVD_SP_EXT_CC_Normal = 5,
    DVD_SP_EXT_CC_Big = 6,
    DVD_SP_EXT_CC_Children = 7,
    DVD_SP_EXT_Forced = 9,
    DVD_SP_EXT_DirectorComments_Normal = 13,
    DVD_SP_EXT_DirectorComments_Big = 14,
    DVD_SP_EXT_DirectorComments_Children = 15
}

public enum tagDVD_AUDIO_APPMODE
{
        DVD_AudioMode_None = 0,
    DVD_AudioMode_Karaoke = 1,
    DVD_AudioMode_Surround = 2,
    DVD_AudioMode_Other = 3
}

public enum tagDVD_AUDIO_FORMAT
{
        DVD_AudioFormat_AC3 = 0,
    DVD_AudioFormat_MPEG1 = 1,
    DVD_AudioFormat_MPEG1_DRC = 2,
    DVD_AudioFormat_MPEG2 = 3,
    DVD_AudioFormat_MPEG2_DRC = 4,
    DVD_AudioFormat_LPCM = 5,
    DVD_AudioFormat_DTS = 6,
    DVD_AudioFormat_SDDS = 7,
    DVD_AudioFormat_Other = 8
}

public enum tagDVD_KARAOKE_DOWNMIX
{
        DVD_Mix_0to0 = 0x1,
    DVD_Mix_1to0 = 0x2,
    DVD_Mix_2to0 = 0x4,
    DVD_Mix_3to0 = 0x8,
    DVD_Mix_4to0 = 0x10,
    DVD_Mix_Lto0 = 0x20,
    DVD_Mix_Rto0 = 0x40,
    DVD_Mix_0to1 = 0x100,
    DVD_Mix_1to1 = 0x200,
    DVD_Mix_2to1 = 0x400,
    DVD_Mix_3to1 = 0x800,
    DVD_Mix_4to1 = 0x1000,
    DVD_Mix_Lto1 = 0x2000,
    DVD_Mix_Rto1 = 0x4000
}

public class tagDVD_AudioAttributes
{
    public DVD_AUDIO_APPMODE AppMode = new DVD_AUDIO_APPMODE();
    public byte AppModeData;
    public DVD_AUDIO_FORMAT AudioFormat = new DVD_AUDIO_FORMAT();
    public uint Language;
    public DVD_AUDIO_LANG_EXT LanguageExtension = new DVD_AUDIO_LANG_EXT();
    public bool fHasMultichannelInfo;
    public uint dwFrequency;
    public byte bQuantization;
    public byte bNumberOfChannels;
    public uint[] dwReserved = new uint[2];
}

public class tagDVD_MUA_MixingInfo
{
    public bool fMixTo0;
    public bool fMixTo1;
    public bool fMix0InPhase;
    public bool fMix1InPhase;
    public uint dwSpeakerPosition;
}

public class tagDVD_MUA_Coeff
{
    public double log2_alpha;
    public double log2_beta;
}

public class tagDVD_MultichannelAudioAttributes
{
    public tagDVD_MUA_MixingInfo[] Info = Arrays.InitializeWithDefaultInstances<tagDVD_MUA_MixingInfo>(8);
    public tagDVD_MUA_Coeff[] Coeff = Arrays.InitializeWithDefaultInstances<tagDVD_MUA_Coeff>(8);
}

public enum tagDVD_KARAOKE_CONTENTS
{
        DVD_Karaoke_GuideVocal1 = 0x1,
    DVD_Karaoke_GuideVocal2 = 0x2,
    DVD_Karaoke_GuideMelody1 = 0x4,
    DVD_Karaoke_GuideMelody2 = 0x8,
    DVD_Karaoke_GuideMelodyA = 0x10,
    DVD_Karaoke_GuideMelodyB = 0x20,
    DVD_Karaoke_SoundEffectA = 0x40,
    DVD_Karaoke_SoundEffectB = 0x80
}

public enum tagDVD_KARAOKE_ASSIGNMENT
{
        DVD_Assignment_reserved0 = 0,
    DVD_Assignment_reserved1 = 1,
    DVD_Assignment_LR = 2,
    DVD_Assignment_LRM = 3,
    DVD_Assignment_LR1 = 4,
    DVD_Assignment_LRM1 = 5,
    DVD_Assignment_LR12 = 6,
    DVD_Assignment_LRM12 = 7
}

public class tagDVD_KaraokeAttributes
{
    public byte bVersion;
    public bool fMasterOfCeremoniesInGuideVocal1;
    public bool fDuet;
    public DVD_KARAOKE_ASSIGNMENT ChannelAssignment = new DVD_KARAOKE_ASSIGNMENT();
    public ushort[] wChannelContents = new ushort[8];
}

public enum tagDVD_VIDEO_COMPRESSION
{
        DVD_VideoCompression_Other = 0,
    DVD_VideoCompression_MPEG1 = 1,
    DVD_VideoCompression_MPEG2 = 2
}

public class tagDVD_VideoAttributes
{
    public bool fPanscanPermitted;
    public bool fLetterboxPermitted;
    public uint ulAspectX;
    public uint ulAspectY;
    public uint ulFrameRate;
    public uint ulFrameHeight;
    public DVD_VIDEO_COMPRESSION Compression = new DVD_VIDEO_COMPRESSION();
    public bool fLine21Field1InGOP;
    public bool fLine21Field2InGOP;
    public uint ulSourceResolutionX;
    public uint ulSourceResolutionY;
    public bool fIsSourceLetterboxed;
    public bool fIsFilmMode;
}

public enum tagDVD_SUBPICTURE_TYPE
{
        DVD_SPType_NotSpecified = 0,
    DVD_SPType_Language = 1,
    DVD_SPType_Other = 2
}

public enum tagDVD_SUBPICTURE_CODING
{
        DVD_SPCoding_RunLength = 0,
    DVD_SPCoding_Extended = 1,
    DVD_SPCoding_Other = 2
}

public class tagDVD_SubpictureAttributes
{
    public DVD_SUBPICTURE_TYPE Type = new DVD_SUBPICTURE_TYPE();
    public DVD_SUBPICTURE_CODING CodingMode = new DVD_SUBPICTURE_CODING();
    public uint Language;
    public DVD_SUBPICTURE_LANG_EXT LanguageExtension = new DVD_SUBPICTURE_LANG_EXT();
}

public enum tagDVD_TITLE_APPMODE
{
        DVD_AppMode_Not_Specified = 0,
    DVD_AppMode_Karaoke = 1,
    DVD_AppMode_Other = 3
}

public class tagDVD_TitleMainAttributes
{
    public DVD_TITLE_APPMODE AppMode = new DVD_TITLE_APPMODE();
    public tagDVD_VideoAttributes VideoAttributes = new tagDVD_VideoAttributes();
    public uint ulNumberOfAudioStreams;
    public tagDVD_AudioAttributes[] AudioAttributes = Arrays.InitializeWithDefaultInstances<tagDVD_AudioAttributes>(8);
    public tagDVD_MultichannelAudioAttributes[] MultichannelAudioAttributes = Arrays.InitializeWithDefaultInstances<tagDVD_MultichannelAudioAttributes>(8);
    public uint ulNumberOfSubpictureStreams;
    public tagDVD_SubpictureAttributes[] SubpictureAttributes = Arrays.InitializeWithDefaultInstances<tagDVD_SubpictureAttributes>(32);
}

public class tagDVD_MenuAttributes
{
    public bool[] fCompatibleRegion = new bool[8];
    public tagDVD_VideoAttributes VideoAttributes = new tagDVD_VideoAttributes();
    public bool fAudioPresent;
    public tagDVD_AudioAttributes AudioAttributes = new tagDVD_AudioAttributes();
    public bool fSubpicturePresent;
    public tagDVD_SubpictureAttributes SubpictureAttributes = new tagDVD_SubpictureAttributes();
}

#else // C style interface

    public class IDvdControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdControl * This);
        public delegate uint AddRefDelegate(@interface IDvdControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdControl * This);
        public delegate uint ReleaseDelegate(@interface IDvdControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TitlePlay)(interface IDvdControl * This, uint ulTitle);
        public delegate int TitlePlayDelegate(@interface IDvdControl This, uint ulTitle);
        public TitlePlayDelegate TitlePlay;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChapterPlay)(interface IDvdControl * This, uint ulTitle, uint ulChapter);
        public delegate int ChapterPlayDelegate(@interface IDvdControl This, uint ulTitle, uint ulChapter);
        public ChapterPlayDelegate ChapterPlay;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TimePlay)(interface IDvdControl * This, uint ulTitle, uint bcdTime);
        public delegate int TimePlayDelegate(@interface IDvdControl This, uint ulTitle, uint bcdTime);
        public TimePlayDelegate TimePlay;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StopForResume)(interface IDvdControl * This);
        public delegate int StopForResumeDelegate(@interface IDvdControl This);
        public StopForResumeDelegate StopForResume;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GoUp)(interface IDvdControl * This);
        public delegate int GoUpDelegate(@interface IDvdControl This);
        public GoUpDelegate GoUp;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TimeSearch)(interface IDvdControl * This, uint bcdTime);
        public delegate int TimeSearchDelegate(@interface IDvdControl This, uint bcdTime);
        public TimeSearchDelegate TimeSearch;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChapterSearch)(interface IDvdControl * This, uint ulChapter);
        public delegate int ChapterSearchDelegate(@interface IDvdControl This, uint ulChapter);
        public ChapterSearchDelegate ChapterSearch;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PrevPGSearch)(interface IDvdControl * This);
        public delegate int PrevPGSearchDelegate(@interface IDvdControl This);
        public PrevPGSearchDelegate PrevPGSearch;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TopPGSearch)(interface IDvdControl * This);
        public delegate int TopPGSearchDelegate(@interface IDvdControl This);
        public TopPGSearchDelegate TopPGSearch;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NextPGSearch)(interface IDvdControl * This);
        public delegate int NextPGSearchDelegate(@interface IDvdControl This);
        public NextPGSearchDelegate NextPGSearch;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ForwardScan)(interface IDvdControl * This, double dwSpeed);
        public delegate int ForwardScanDelegate(@interface IDvdControl This, double dwSpeed);
        public ForwardScanDelegate ForwardScan;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *BackwardScan)(interface IDvdControl * This, double dwSpeed);
        public delegate int BackwardScanDelegate(@interface IDvdControl This, double dwSpeed);
        public BackwardScanDelegate BackwardScan;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MenuCall)(interface IDvdControl * This, DVD_MENU_ID MenuID);
        public delegate int MenuCallDelegate(@interface IDvdControl This, DVD_MENU_ID MenuID);
        public MenuCallDelegate MenuCall;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Resume)(interface IDvdControl * This);
        public delegate int ResumeDelegate(@interface IDvdControl This);
        public ResumeDelegate Resume;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UpperButtonSelect)(interface IDvdControl * This);
        public delegate int UpperButtonSelectDelegate(@interface IDvdControl This);
        public UpperButtonSelectDelegate UpperButtonSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LowerButtonSelect)(interface IDvdControl * This);
        public delegate int LowerButtonSelectDelegate(@interface IDvdControl This);
        public LowerButtonSelectDelegate LowerButtonSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LeftButtonSelect)(interface IDvdControl * This);
        public delegate int LeftButtonSelectDelegate(@interface IDvdControl This);
        public LeftButtonSelectDelegate LeftButtonSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RightButtonSelect)(interface IDvdControl * This);
        public delegate int RightButtonSelectDelegate(@interface IDvdControl This);
        public RightButtonSelectDelegate RightButtonSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ButtonActivate)(interface IDvdControl * This);
        public delegate int ButtonActivateDelegate(@interface IDvdControl This);
        public ButtonActivateDelegate ButtonActivate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ButtonSelectAndActivate)(interface IDvdControl * This, uint ulButton);
        public delegate int ButtonSelectAndActivateDelegate(@interface IDvdControl This, uint ulButton);
        public ButtonSelectAndActivateDelegate ButtonSelectAndActivate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StillOff)(interface IDvdControl * This);
        public delegate int StillOffDelegate(@interface IDvdControl This);
        public StillOffDelegate StillOff;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PauseOn)(interface IDvdControl * This);
        public delegate int PauseOnDelegate(@interface IDvdControl This);
        public PauseOnDelegate PauseOn;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PauseOff)(interface IDvdControl * This);
        public delegate int PauseOffDelegate(@interface IDvdControl This);
        public PauseOffDelegate PauseOff;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MenuLanguageSelect)(interface IDvdControl * This, uint Language);
        public delegate int MenuLanguageSelectDelegate(@interface IDvdControl This, uint Language);
        public MenuLanguageSelectDelegate MenuLanguageSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AudioStreamChange)(interface IDvdControl * This, uint ulAudio);
        public delegate int AudioStreamChangeDelegate(@interface IDvdControl This, uint ulAudio);
        public AudioStreamChangeDelegate AudioStreamChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SubpictureStreamChange)(interface IDvdControl * This, uint ulSubPicture, bool bDisplay);
        public delegate int SubpictureStreamChangeDelegate(@interface IDvdControl This, uint ulSubPicture, bool bDisplay);
        public SubpictureStreamChangeDelegate SubpictureStreamChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AngleChange)(interface IDvdControl * This, uint ulAngle);
        public delegate int AngleChangeDelegate(@interface IDvdControl This, uint ulAngle);
        public AngleChangeDelegate AngleChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ParentalLevelSelect)(interface IDvdControl * This, uint ulParentalLevel);
        public delegate int ParentalLevelSelectDelegate(@interface IDvdControl This, uint ulParentalLevel);
        public ParentalLevelSelectDelegate ParentalLevelSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ParentalCountrySelect)(interface IDvdControl * This, ushort wCountry);
        public delegate int ParentalCountrySelectDelegate(@interface IDvdControl This, ushort wCountry);
        public ParentalCountrySelectDelegate ParentalCountrySelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *KaraokeAudioPresentationModeChange)(interface IDvdControl * This, uint ulMode);
        public delegate int KaraokeAudioPresentationModeChangeDelegate(@interface IDvdControl This, uint ulMode);
        public KaraokeAudioPresentationModeChangeDelegate KaraokeAudioPresentationModeChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *VideoModePreferrence)(interface IDvdControl * This, uint ulPreferredDisplayMode);
        public delegate int VideoModePreferrenceDelegate(@interface IDvdControl This, uint ulPreferredDisplayMode);
        public VideoModePreferrenceDelegate VideoModePreferrence;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRoot)(interface IDvdControl * This, const char* pszPath);
        public delegate int SetRootDelegate(@interface IDvdControl This, string pszPath);
        public SetRootDelegate SetRoot;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MouseActivate)(interface IDvdControl * This, POINT point);
        public delegate int MouseActivateDelegate(@interface IDvdControl This, POINT point);
        public MouseActivateDelegate MouseActivate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MouseSelect)(interface IDvdControl * This, POINT point);
        public delegate int MouseSelectDelegate(@interface IDvdControl This, POINT point);
        public MouseSelectDelegate MouseSelect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChapterPlayAutoStop)(interface IDvdControl * This, uint ulTitle, uint ulChapter, uint ulChaptersToPlay);
        public delegate int ChapterPlayAutoStopDelegate(@interface IDvdControl This, uint ulTitle, uint ulChapter, uint ulChaptersToPlay);
        public ChapterPlayAutoStopDelegate ChapterPlayAutoStop;

//        END_INTERFACE
    }

#else // C style interface

    public class IDvdInfoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdInfo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdInfo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdInfo * This);
        public delegate uint AddRefDelegate(@interface IDvdInfo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdInfo * This);
        public delegate uint ReleaseDelegate(@interface IDvdInfo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentDomain)(interface IDvdInfo * This, DVD_DOMAIN *pDomain);
        public delegate int GetCurrentDomainDelegate(@interface IDvdInfo This, DVD_DOMAIN pDomain);
        public GetCurrentDomainDelegate GetCurrentDomain;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentLocation)(interface IDvdInfo * This, tagDVD_PLAYBACK_LOCATION *pLocation);
        public delegate int GetCurrentLocationDelegate(@interface IDvdInfo This, tagDVD_PLAYBACK_LOCATION pLocation);
        public GetCurrentLocationDelegate GetCurrentLocation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTotalTitleTime)(interface IDvdInfo * This, uint *pulTotalTime);
        public delegate int GetTotalTitleTimeDelegate(@interface IDvdInfo This, ref uint pulTotalTime);
        public GetTotalTitleTimeDelegate GetTotalTitleTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentButton)(interface IDvdInfo * This, uint *pulButtonsAvailable, uint *pulCurrentButton);
        public delegate int GetCurrentButtonDelegate(@interface IDvdInfo This, ref uint pulButtonsAvailable, ref uint pulCurrentButton);
        public GetCurrentButtonDelegate GetCurrentButton;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentAngle)(interface IDvdInfo * This, uint *pulAnglesAvailable, uint *pulCurrentAngle);
        public delegate int GetCurrentAngleDelegate(@interface IDvdInfo This, ref uint pulAnglesAvailable, ref uint pulCurrentAngle);
        public GetCurrentAngleDelegate GetCurrentAngle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentAudio)(interface IDvdInfo * This, uint *pulStreamsAvailable, uint *pulCurrentStream);
        public delegate int GetCurrentAudioDelegate(@interface IDvdInfo This, ref uint pulStreamsAvailable, ref uint pulCurrentStream);
        public GetCurrentAudioDelegate GetCurrentAudio;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentSubpicture)(interface IDvdInfo * This, uint *pulStreamsAvailable, uint *pulCurrentStream, bool *pIsDisabled);
        public delegate int GetCurrentSubpictureDelegate(@interface IDvdInfo This, ref uint pulStreamsAvailable, ref uint pulCurrentStream, ref bool pIsDisabled);
        public GetCurrentSubpictureDelegate GetCurrentSubpicture;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentUOPS)(interface IDvdInfo * This, uint *pUOP);
        public delegate int GetCurrentUOPSDelegate(@interface IDvdInfo This, ref uint pUOP);
        public GetCurrentUOPSDelegate GetCurrentUOPS;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllSPRMs)(interface IDvdInfo * This, ushort *pRegisterArray[24]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetAllSPRMsDelegate(@interface IDvdInfo This, ushort[] pRegisterArray);
        public GetAllSPRMsDelegate GetAllSPRMs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllGPRMs)(interface IDvdInfo * This, ushort *pRegisterArray[16]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetAllGPRMsDelegate(@interface IDvdInfo This, ushort[] pRegisterArray);
        public GetAllGPRMsDelegate GetAllGPRMs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAudioLanguage)(interface IDvdInfo * This, uint ulStream, uint *pLanguage);
        public delegate int GetAudioLanguageDelegate(@interface IDvdInfo This, uint ulStream, ref uint pLanguage);
        public GetAudioLanguageDelegate GetAudioLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSubpictureLanguage)(interface IDvdInfo * This, uint ulStream, uint *pLanguage);
        public delegate int GetSubpictureLanguageDelegate(@interface IDvdInfo This, uint ulStream, ref uint pLanguage);
        public GetSubpictureLanguageDelegate GetSubpictureLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTitleAttributes)(interface IDvdInfo * This, uint ulTitle, tagDVD_ATR *pATR);
        public delegate int GetTitleAttributesDelegate(@interface IDvdInfo This, uint ulTitle, tagDVD_ATR[] pATR);
        public GetTitleAttributesDelegate GetTitleAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVMGAttributes)(interface IDvdInfo * This, tagDVD_ATR *pATR);
        public delegate int GetVMGAttributesDelegate(@interface IDvdInfo This, tagDVD_ATR[] pATR);
        public GetVMGAttributesDelegate GetVMGAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentVideoAttributes)(interface IDvdInfo * This, byte *pATR[2]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetCurrentVideoAttributesDelegate(@interface IDvdInfo This, byte[] pATR);
        public GetCurrentVideoAttributesDelegate GetCurrentVideoAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentAudioAttributes)(interface IDvdInfo * This, byte *pATR[8]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetCurrentAudioAttributesDelegate(@interface IDvdInfo This, byte[] pATR);
        public GetCurrentAudioAttributesDelegate GetCurrentAudioAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentSubpictureAttributes)(interface IDvdInfo * This, byte *pATR[6]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetCurrentSubpictureAttributesDelegate(@interface IDvdInfo This, byte[] pATR);
        public GetCurrentSubpictureAttributesDelegate GetCurrentSubpictureAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentVolumeInfo)(interface IDvdInfo * This, uint *pulNumOfVol, uint *pulThisVolNum, DVD_DISC_SIDE *pSide, uint *pulNumOfTitles);
        public delegate int GetCurrentVolumeInfoDelegate(@interface IDvdInfo This, ref uint pulNumOfVol, ref uint pulThisVolNum, DVD_DISC_SIDE pSide, ref uint pulNumOfTitles);
        public GetCurrentVolumeInfoDelegate GetCurrentVolumeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDTextInfo)(interface IDvdInfo * This, byte *pTextManager, uint ulBufSize, uint *pulActualSize);
        public delegate int GetDVDTextInfoDelegate(@interface IDvdInfo This, ref byte pTextManager, uint ulBufSize, ref uint pulActualSize);
        public GetDVDTextInfoDelegate GetDVDTextInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPlayerParentalLevel)(interface IDvdInfo * This, uint *pulParentalLevel, uint *pulCountryCode);
        public delegate int GetPlayerParentalLevelDelegate(@interface IDvdInfo This, ref uint pulParentalLevel, ref uint pulCountryCode);
        public GetPlayerParentalLevelDelegate GetPlayerParentalLevel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfChapters)(interface IDvdInfo * This, uint ulTitle, uint *pulNumberOfChapters);
        public delegate int GetNumberOfChaptersDelegate(@interface IDvdInfo This, uint ulTitle, ref uint pulNumberOfChapters);
        public GetNumberOfChaptersDelegate GetNumberOfChapters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTitleParentalLevels)(interface IDvdInfo * This, uint ulTitle, uint *pulParentalLevels);
        public delegate int GetTitleParentalLevelsDelegate(@interface IDvdInfo This, uint ulTitle, ref uint pulParentalLevels);
        public GetTitleParentalLevelsDelegate GetTitleParentalLevels;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRoot)(interface IDvdInfo * This, char* pRoot, uint ulBufSize, uint *pulActualSize);
        public delegate int GetRootDelegate(@interface IDvdInfo This, ref string pRoot, uint ulBufSize, ref uint pulActualSize);
        public GetRootDelegate GetRoot;

//        END_INTERFACE
    }

#else // C style interface

    public class IDvdCmdVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdCmd * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdCmd This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdCmd * This);
        public delegate uint AddRefDelegate(@interface IDvdCmd This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdCmd * This);
        public delegate uint ReleaseDelegate(@interface IDvdCmd This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WaitForStart)(interface IDvdCmd * This);
        public delegate int WaitForStartDelegate(@interface IDvdCmd This);
        public WaitForStartDelegate WaitForStart;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WaitForEnd)(interface IDvdCmd * This);
        public delegate int WaitForEndDelegate(@interface IDvdCmd This);
        public WaitForEndDelegate WaitForEnd;

//        END_INTERFACE
    }

#else // C style interface

    public class IDvdStateVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdState * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdState This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdState * This);
        public delegate uint AddRefDelegate(@interface IDvdState This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdState * This);
        public delegate uint ReleaseDelegate(@interface IDvdState This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDiscID)(interface IDvdState * This, ulong *pullUniqueID);
        public delegate int GetDiscIDDelegate(@interface IDvdState This, ref ulong pullUniqueID);
        public GetDiscIDDelegate GetDiscID;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetParentalLevel)(interface IDvdState * This, uint *pulParentalLevel);
        public delegate int GetParentalLevelDelegate(@interface IDvdState This, ref uint pulParentalLevel);
        public GetParentalLevelDelegate GetParentalLevel;

//        END_INTERFACE
    }

#else // C style interface

    public class IDvdControl2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdControl2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdControl2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdControl2 * This);
        public delegate uint AddRefDelegate(@interface IDvdControl2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdControl2 * This);
        public delegate uint ReleaseDelegate(@interface IDvdControl2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayTitle)(interface IDvdControl2 * This, uint ulTitle, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayTitleDelegate(@interface IDvdControl2 This, uint ulTitle, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayTitleDelegate PlayTitle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChapterInTitle)(interface IDvdControl2 * This, uint ulTitle, uint ulChapter, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayChapterInTitleDelegate(@interface IDvdControl2 This, uint ulTitle, uint ulChapter, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayChapterInTitleDelegate PlayChapterInTitle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayAtTimeInTitle)(interface IDvdControl2 * This, uint ulTitle, tagDVD_HMSF_TIMECODE *pStartTime, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayAtTimeInTitleDelegate(@interface IDvdControl2 This, uint ulTitle, tagDVD_HMSF_TIMECODE pStartTime, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayAtTimeInTitleDelegate PlayAtTimeInTitle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IDvdControl2 * This);
        public delegate int StopDelegate(@interface IDvdControl2 This);
        public StopDelegate Stop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReturnFromSubmenu)(interface IDvdControl2 * This, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int ReturnFromSubmenuDelegate(@interface IDvdControl2 This, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public ReturnFromSubmenuDelegate ReturnFromSubmenu;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayAtTime)(interface IDvdControl2 * This, tagDVD_HMSF_TIMECODE *pTime, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayAtTimeDelegate(@interface IDvdControl2 This, tagDVD_HMSF_TIMECODE pTime, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayAtTimeDelegate PlayAtTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChapter)(interface IDvdControl2 * This, uint ulChapter, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayChapterDelegate(@interface IDvdControl2 This, uint ulChapter, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayChapterDelegate PlayChapter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayPrevChapter)(interface IDvdControl2 * This, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayPrevChapterDelegate(@interface IDvdControl2 This, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayPrevChapterDelegate PlayPrevChapter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ReplayChapter)(interface IDvdControl2 * This, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int ReplayChapterDelegate(@interface IDvdControl2 This, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public ReplayChapterDelegate ReplayChapter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayNextChapter)(interface IDvdControl2 * This, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayNextChapterDelegate(@interface IDvdControl2 This, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayNextChapterDelegate PlayNextChapter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayForwards)(interface IDvdControl2 * This, double dSpeed, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayForwardsDelegate(@interface IDvdControl2 This, double dSpeed, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayForwardsDelegate PlayForwards;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayBackwards)(interface IDvdControl2 * This, double dSpeed, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayBackwardsDelegate(@interface IDvdControl2 This, double dSpeed, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayBackwardsDelegate PlayBackwards;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ShowMenu)(interface IDvdControl2 * This, DVD_MENU_ID MenuID, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int ShowMenuDelegate(@interface IDvdControl2 This, DVD_MENU_ID MenuID, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public ShowMenuDelegate ShowMenu;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Resume)(interface IDvdControl2 * This, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int ResumeDelegate(@interface IDvdControl2 This, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public ResumeDelegate Resume;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectRelativeButton)(interface IDvdControl2 * This, DVD_RELATIVE_BUTTON buttonDir);
        public delegate int SelectRelativeButtonDelegate(@interface IDvdControl2 This, DVD_RELATIVE_BUTTON buttonDir);
        public SelectRelativeButtonDelegate SelectRelativeButton;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ActivateButton)(interface IDvdControl2 * This);
        public delegate int ActivateButtonDelegate(@interface IDvdControl2 This);
        public ActivateButtonDelegate ActivateButton;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectButton)(interface IDvdControl2 * This, uint ulButton);
        public delegate int SelectButtonDelegate(@interface IDvdControl2 This, uint ulButton);
        public SelectButtonDelegate SelectButton;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectAndActivateButton)(interface IDvdControl2 * This, uint ulButton);
        public delegate int SelectAndActivateButtonDelegate(@interface IDvdControl2 This, uint ulButton);
        public SelectAndActivateButtonDelegate SelectAndActivateButton;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StillOff)(interface IDvdControl2 * This);
        public delegate int StillOffDelegate(@interface IDvdControl2 This);
        public StillOffDelegate StillOff;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IDvdControl2 * This, bool bState);
        public delegate int PauseDelegate(@interface IDvdControl2 This, bool bState);
        public PauseDelegate Pause;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectAudioStream)(interface IDvdControl2 * This, uint ulAudio, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int SelectAudioStreamDelegate(@interface IDvdControl2 This, uint ulAudio, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public SelectAudioStreamDelegate SelectAudioStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectSubpictureStream)(interface IDvdControl2 * This, uint ulSubPicture, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int SelectSubpictureStreamDelegate(@interface IDvdControl2 This, uint ulSubPicture, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public SelectSubpictureStreamDelegate SelectSubpictureStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSubpictureState)(interface IDvdControl2 * This, bool bState, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int SetSubpictureStateDelegate(@interface IDvdControl2 This, bool bState, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public SetSubpictureStateDelegate SetSubpictureState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectAngle)(interface IDvdControl2 * This, uint ulAngle, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int SelectAngleDelegate(@interface IDvdControl2 This, uint ulAngle, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public SelectAngleDelegate SelectAngle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectParentalLevel)(interface IDvdControl2 * This, uint ulParentalLevel);
        public delegate int SelectParentalLevelDelegate(@interface IDvdControl2 This, uint ulParentalLevel);
        public SelectParentalLevelDelegate SelectParentalLevel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectParentalCountry)(interface IDvdControl2 * This, byte bCountry[2]);
        public delegate int SelectParentalCountryDelegate(@interface IDvdControl2 This, byte[] bCountry);
        public SelectParentalCountryDelegate SelectParentalCountry;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectKaraokeAudioPresentationMode)(interface IDvdControl2 * This, uint ulMode);
        public delegate int SelectKaraokeAudioPresentationModeDelegate(@interface IDvdControl2 This, uint ulMode);
        public SelectKaraokeAudioPresentationModeDelegate SelectKaraokeAudioPresentationMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectVideoModePreference)(interface IDvdControl2 * This, uint ulPreferredDisplayMode);
        public delegate int SelectVideoModePreferenceDelegate(@interface IDvdControl2 This, uint ulPreferredDisplayMode);
        public SelectVideoModePreferenceDelegate SelectVideoModePreference;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDVDDirectory)(interface IDvdControl2 * This, const char* pszwPath);
        public delegate int SetDVDDirectoryDelegate(@interface IDvdControl2 This, string pszwPath);
        public SetDVDDirectoryDelegate SetDVDDirectory;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ActivateAtPosition)(interface IDvdControl2 * This, POINT point);
        public delegate int ActivateAtPositionDelegate(@interface IDvdControl2 This, POINT point);
        public ActivateAtPositionDelegate ActivateAtPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectAtPosition)(interface IDvdControl2 * This, POINT point);
        public delegate int SelectAtPositionDelegate(@interface IDvdControl2 This, POINT point);
        public SelectAtPositionDelegate SelectAtPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayChaptersAutoStop)(interface IDvdControl2 * This, uint ulTitle, uint ulChapter, uint ulChaptersToPlay, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayChaptersAutoStopDelegate(@interface IDvdControl2 This, uint ulTitle, uint ulChapter, uint ulChaptersToPlay, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayChaptersAutoStopDelegate PlayChaptersAutoStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AcceptParentalLevelChange)(interface IDvdControl2 * This, bool bAccept);
        public delegate int AcceptParentalLevelChangeDelegate(@interface IDvdControl2 This, bool bAccept);
        public AcceptParentalLevelChangeDelegate AcceptParentalLevelChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOption)(interface IDvdControl2 * This, DVD_OPTION_FLAG flag, bool fState);
        public delegate int SetOptionDelegate(@interface IDvdControl2 This, DVD_OPTION_FLAG flag, bool fState);
        public SetOptionDelegate SetOption;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetState)(interface IDvdControl2 * This, interface IDvdState *pState, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int SetStateDelegate(@interface IDvdControl2 This, @interface IDvdState pState, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public SetStateDelegate SetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PlayPeriodInTitleAutoStop)(interface IDvdControl2 * This, uint ulTitle, tagDVD_HMSF_TIMECODE *pStartTime, tagDVD_HMSF_TIMECODE *pEndTime, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int PlayPeriodInTitleAutoStopDelegate(@interface IDvdControl2 This, uint ulTitle, tagDVD_HMSF_TIMECODE pStartTime, tagDVD_HMSF_TIMECODE pEndTime, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public PlayPeriodInTitleAutoStopDelegate PlayPeriodInTitleAutoStop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetGPRM)(interface IDvdControl2 * This, uint ulIndex, ushort wValue, uint dwFlags, interface IDvdCmd **ppCmd);
        public delegate int SetGPRMDelegate(@interface IDvdControl2 This, uint ulIndex, ushort wValue, uint dwFlags, @interface IDvdCmd[] ppCmd);
        public SetGPRMDelegate SetGPRM;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectDefaultMenuLanguage)(interface IDvdControl2 * This, uint Language);
        public delegate int SelectDefaultMenuLanguageDelegate(@interface IDvdControl2 This, uint Language);
        public SelectDefaultMenuLanguageDelegate SelectDefaultMenuLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectDefaultAudioLanguage)(interface IDvdControl2 * This, uint Language, DVD_AUDIO_LANG_EXT audioExtension);
        public delegate int SelectDefaultAudioLanguageDelegate(@interface IDvdControl2 This, uint Language, DVD_AUDIO_LANG_EXT audioExtension);
        public SelectDefaultAudioLanguageDelegate SelectDefaultAudioLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SelectDefaultSubpictureLanguage)(interface IDvdControl2 * This, uint Language, DVD_SUBPICTURE_LANG_EXT subpictureExtension);
        public delegate int SelectDefaultSubpictureLanguageDelegate(@interface IDvdControl2 This, uint Language, DVD_SUBPICTURE_LANG_EXT subpictureExtension);
        public SelectDefaultSubpictureLanguageDelegate SelectDefaultSubpictureLanguage;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0377 */
/* [local] */ 


public enum DVD_TextStringType
{
        DVD_Struct_Volume = 0x1,
    DVD_Struct_Title = 0x2,
    DVD_Struct_ParentalID = 0x3,
    DVD_Struct_PartOfTitle = 0x4,
    DVD_Struct_Cell = 0x5,
    DVD_Stream_Audio = 0x10,
    DVD_Stream_Subpicture = 0x11,
    DVD_Stream_Angle = 0x12,
    DVD_Channel_Audio = 0x20,
    DVD_General_Name = 0x30,
    DVD_General_Comments = 0x31,
    DVD_Title_Series = 0x38,
    DVD_Title_Movie = 0x39,
    DVD_Title_Video = 0x3a,
    DVD_Title_Album = 0x3b,
    DVD_Title_Song = 0x3c,
    DVD_Title_Other = 0x3f,
    DVD_Title_Sub_Series = 0x40,
    DVD_Title_Sub_Movie = 0x41,
    DVD_Title_Sub_Video = 0x42,
    DVD_Title_Sub_Album = 0x43,
    DVD_Title_Sub_Song = 0x44,
    DVD_Title_Sub_Other = 0x47,
    DVD_Title_Orig_Series = 0x48,
    DVD_Title_Orig_Movie = 0x49,
    DVD_Title_Orig_Video = 0x4a,
    DVD_Title_Orig_Album = 0x4b,
    DVD_Title_Orig_Song = 0x4c,
    DVD_Title_Orig_Other = 0x4f,
    DVD_Other_Scene = 0x50,
    DVD_Other_Cut = 0x51,
    DVD_Other_Take = 0x52
}

public enum DVD_TextCharSet
{
        DVD_CharSet_Unicode = 0,
    DVD_CharSet_ISO646 = 1,
    DVD_CharSet_JIS_Roman_Kanji = 2,
    DVD_CharSet_ISO8859_1 = 3,
    DVD_CharSet_ShiftJIS_Kanji_Roman_Katakana = 4
}
public class tagDVD_DECODER_CAPS
{
    public uint dwSize;
    public uint dwAudioCaps;
    public double dFwdMaxRateVideo;
    public double dFwdMaxRateAudio;
    public double dFwdMaxRateSP;
    public double dBwdMaxRateVideo;
    public double dBwdMaxRateAudio;
    public double dBwdMaxRateSP;
    public uint dwRes1;
    public uint dwRes2;
    public uint dwRes3;
    public uint dwRes4;
}

#else // C style interface

    public class IDvdInfo2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdInfo2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdInfo2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdInfo2 * This);
        public delegate uint AddRefDelegate(@interface IDvdInfo2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdInfo2 * This);
        public delegate uint ReleaseDelegate(@interface IDvdInfo2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentDomain)(interface IDvdInfo2 * This, DVD_DOMAIN *pDomain);
        public delegate int GetCurrentDomainDelegate(@interface IDvdInfo2 This, DVD_DOMAIN pDomain);
        public GetCurrentDomainDelegate GetCurrentDomain;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentLocation)(interface IDvdInfo2 * This, tagDVD_PLAYBACK_LOCATION2 *pLocation);
        public delegate int GetCurrentLocationDelegate(@interface IDvdInfo2 This, tagDVD_PLAYBACK_LOCATION2 pLocation);
        public GetCurrentLocationDelegate GetCurrentLocation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTotalTitleTime)(interface IDvdInfo2 * This, tagDVD_HMSF_TIMECODE *pTotalTime, uint *ulTimeCodeFlags);
        public delegate int GetTotalTitleTimeDelegate(@interface IDvdInfo2 This, tagDVD_HMSF_TIMECODE pTotalTime, ref uint ulTimeCodeFlags);
        public GetTotalTitleTimeDelegate GetTotalTitleTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentButton)(interface IDvdInfo2 * This, uint *pulButtonsAvailable, uint *pulCurrentButton);
        public delegate int GetCurrentButtonDelegate(@interface IDvdInfo2 This, ref uint pulButtonsAvailable, ref uint pulCurrentButton);
        public GetCurrentButtonDelegate GetCurrentButton;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentAngle)(interface IDvdInfo2 * This, uint *pulAnglesAvailable, uint *pulCurrentAngle);
        public delegate int GetCurrentAngleDelegate(@interface IDvdInfo2 This, ref uint pulAnglesAvailable, ref uint pulCurrentAngle);
        public GetCurrentAngleDelegate GetCurrentAngle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentAudio)(interface IDvdInfo2 * This, uint *pulStreamsAvailable, uint *pulCurrentStream);
        public delegate int GetCurrentAudioDelegate(@interface IDvdInfo2 This, ref uint pulStreamsAvailable, ref uint pulCurrentStream);
        public GetCurrentAudioDelegate GetCurrentAudio;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentSubpicture)(interface IDvdInfo2 * This, uint *pulStreamsAvailable, uint *pulCurrentStream, bool *pbIsDisabled);
        public delegate int GetCurrentSubpictureDelegate(@interface IDvdInfo2 This, ref uint pulStreamsAvailable, ref uint pulCurrentStream, ref bool pbIsDisabled);
        public GetCurrentSubpictureDelegate GetCurrentSubpicture;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentUOPS)(interface IDvdInfo2 * This, uint *pulUOPs);
        public delegate int GetCurrentUOPSDelegate(@interface IDvdInfo2 This, ref uint pulUOPs);
        public GetCurrentUOPSDelegate GetCurrentUOPS;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllSPRMs)(interface IDvdInfo2 * This, ushort *pRegisterArray[24]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetAllSPRMsDelegate(@interface IDvdInfo2 This, ushort[] pRegisterArray);
        public GetAllSPRMsDelegate GetAllSPRMs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAllGPRMs)(interface IDvdInfo2 * This, ushort *pRegisterArray[16]);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetAllGPRMsDelegate(@interface IDvdInfo2 This, ushort[] pRegisterArray);
        public GetAllGPRMsDelegate GetAllGPRMs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAudioLanguage)(interface IDvdInfo2 * This, uint ulStream, uint *pLanguage);
        public delegate int GetAudioLanguageDelegate(@interface IDvdInfo2 This, uint ulStream, ref uint pLanguage);
        public GetAudioLanguageDelegate GetAudioLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSubpictureLanguage)(interface IDvdInfo2 * This, uint ulStream, uint *pLanguage);
        public delegate int GetSubpictureLanguageDelegate(@interface IDvdInfo2 This, uint ulStream, ref uint pLanguage);
        public GetSubpictureLanguageDelegate GetSubpictureLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTitleAttributes)(interface IDvdInfo2 * This, uint ulTitle, tagDVD_MenuAttributes *pMenu, tagDVD_TitleMainAttributes *pTitle);
        public delegate int GetTitleAttributesDelegate(@interface IDvdInfo2 This, uint ulTitle, tagDVD_MenuAttributes pMenu, tagDVD_TitleMainAttributes pTitle);
        public GetTitleAttributesDelegate GetTitleAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVMGAttributes)(interface IDvdInfo2 * This, tagDVD_MenuAttributes *pATR);
        public delegate int GetVMGAttributesDelegate(@interface IDvdInfo2 This, tagDVD_MenuAttributes pATR);
        public GetVMGAttributesDelegate GetVMGAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentVideoAttributes)(interface IDvdInfo2 * This, tagDVD_VideoAttributes *pATR);
        public delegate int GetCurrentVideoAttributesDelegate(@interface IDvdInfo2 This, tagDVD_VideoAttributes pATR);
        public GetCurrentVideoAttributesDelegate GetCurrentVideoAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAudioAttributes)(interface IDvdInfo2 * This, uint ulStream, tagDVD_AudioAttributes *pATR);
        public delegate int GetAudioAttributesDelegate(@interface IDvdInfo2 This, uint ulStream, tagDVD_AudioAttributes pATR);
        public GetAudioAttributesDelegate GetAudioAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetKaraokeAttributes)(interface IDvdInfo2 * This, uint ulStream, tagDVD_KaraokeAttributes *pAttributes);
        public delegate int GetKaraokeAttributesDelegate(@interface IDvdInfo2 This, uint ulStream, tagDVD_KaraokeAttributes pAttributes);
        public GetKaraokeAttributesDelegate GetKaraokeAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSubpictureAttributes)(interface IDvdInfo2 * This, uint ulStream, tagDVD_SubpictureAttributes *pATR);
        public delegate int GetSubpictureAttributesDelegate(@interface IDvdInfo2 This, uint ulStream, tagDVD_SubpictureAttributes pATR);
        public GetSubpictureAttributesDelegate GetSubpictureAttributes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDVolumeInfo)(interface IDvdInfo2 * This, uint *pulNumOfVolumes, uint *pulVolume, DVD_DISC_SIDE *pSide, uint *pulNumOfTitles);
        public delegate int GetDVDVolumeInfoDelegate(@interface IDvdInfo2 This, ref uint pulNumOfVolumes, ref uint pulVolume, DVD_DISC_SIDE pSide, ref uint pulNumOfTitles);
        public GetDVDVolumeInfoDelegate GetDVDVolumeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDTextNumberOfLanguages)(interface IDvdInfo2 * This, uint *pulNumOfLangs);
        public delegate int GetDVDTextNumberOfLanguagesDelegate(@interface IDvdInfo2 This, ref uint pulNumOfLangs);
        public GetDVDTextNumberOfLanguagesDelegate GetDVDTextNumberOfLanguages;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDTextLanguageInfo)(interface IDvdInfo2 * This, uint ulLangIndex, uint *pulNumOfStrings, uint *pLangCode, enum DVD_TextCharSet *pbCharacterSet);
        public delegate int GetDVDTextLanguageInfoDelegate(@interface IDvdInfo2 This, uint ulLangIndex, ref uint pulNumOfStrings, ref uint pLangCode, DVD_TextCharSet pbCharacterSet);
        public GetDVDTextLanguageInfoDelegate GetDVDTextLanguageInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDTextStringAsNative)(interface IDvdInfo2 * This, uint ulLangIndex, uint ulStringIndex, byte *pbBuffer, uint ulMaxBufferSize, uint *pulActualSize, enum DVD_TextStringType *pType);
        public delegate int GetDVDTextStringAsNativeDelegate(@interface IDvdInfo2 This, uint ulLangIndex, uint ulStringIndex, ref byte pbBuffer, uint ulMaxBufferSize, ref uint pulActualSize, DVD_TextStringType pType);
        public GetDVDTextStringAsNativeDelegate GetDVDTextStringAsNative;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDTextStringAsUnicode)(interface IDvdInfo2 * This, uint ulLangIndex, uint ulStringIndex, char *pchwBuffer, uint ulMaxBufferSize, uint *pulActualSize, enum DVD_TextStringType *pType);
        public delegate int GetDVDTextStringAsUnicodeDelegate(@interface IDvdInfo2 This, uint ulLangIndex, uint ulStringIndex, ref string pchwBuffer, uint ulMaxBufferSize, ref uint pulActualSize, DVD_TextStringType pType);
        public GetDVDTextStringAsUnicodeDelegate GetDVDTextStringAsUnicode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPlayerParentalLevel)(interface IDvdInfo2 * This, uint *pulParentalLevel, byte pbCountryCode[2]);
        public delegate int GetPlayerParentalLevelDelegate(@interface IDvdInfo2 This, ref uint pulParentalLevel, byte[] pbCountryCode);
        public GetPlayerParentalLevelDelegate GetPlayerParentalLevel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfChapters)(interface IDvdInfo2 * This, uint ulTitle, uint *pulNumOfChapters);
        public delegate int GetNumberOfChaptersDelegate(@interface IDvdInfo2 This, uint ulTitle, ref uint pulNumOfChapters);
        public GetNumberOfChaptersDelegate GetNumberOfChapters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTitleParentalLevels)(interface IDvdInfo2 * This, uint ulTitle, uint *pulParentalLevels);
        public delegate int GetTitleParentalLevelsDelegate(@interface IDvdInfo2 This, uint ulTitle, ref uint pulParentalLevels);
        public GetTitleParentalLevelsDelegate GetTitleParentalLevels;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDVDDirectory)(interface IDvdInfo2 * This, char* pszwPath, uint ulMaxSize, uint *pulActualSize);
        public delegate int GetDVDDirectoryDelegate(@interface IDvdInfo2 This, ref string pszwPath, uint ulMaxSize, ref uint pulActualSize);
        public GetDVDDirectoryDelegate GetDVDDirectory;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsAudioStreamEnabled)(interface IDvdInfo2 * This, uint ulStreamNum, bool *pbEnabled);
        public delegate int IsAudioStreamEnabledDelegate(@interface IDvdInfo2 This, uint ulStreamNum, ref bool pbEnabled);
        public IsAudioStreamEnabledDelegate IsAudioStreamEnabled;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDiscID)(interface IDvdInfo2 * This, const char* pszwPath, ulong *pullDiscID);
        public delegate int GetDiscIDDelegate(@interface IDvdInfo2 This, string pszwPath, ref ulong pullDiscID);
        public GetDiscIDDelegate GetDiscID;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetState)(interface IDvdInfo2 * This, interface IDvdState **pStateData);
        public delegate int GetStateDelegate(@interface IDvdInfo2 This, @interface IDvdState[] pStateData);
        public GetStateDelegate GetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMenuLanguages)(interface IDvdInfo2 * This, uint *pLanguages, uint ulMaxLanguages, uint *pulActualLanguages);
        public delegate int GetMenuLanguagesDelegate(@interface IDvdInfo2 This, ref uint pLanguages, uint ulMaxLanguages, ref uint pulActualLanguages);
        public GetMenuLanguagesDelegate GetMenuLanguages;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetButtonAtPosition)(interface IDvdInfo2 * This, POINT point, uint *pulButtonIndex);
        public delegate int GetButtonAtPositionDelegate(@interface IDvdInfo2 This, POINT point, ref uint pulButtonIndex);
        public GetButtonAtPositionDelegate GetButtonAtPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCmdFromEvent)(interface IDvdInfo2 * This, System.IntPtr lParam1, interface IDvdCmd **pCmdObj);
        public delegate int GetCmdFromEventDelegate(@interface IDvdInfo2 This, IntPtr lParam1, @interface IDvdCmd[] pCmdObj);
        public GetCmdFromEventDelegate GetCmdFromEvent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultMenuLanguage)(interface IDvdInfo2 * This, uint *pLanguage);
        public delegate int GetDefaultMenuLanguageDelegate(@interface IDvdInfo2 This, ref uint pLanguage);
        public GetDefaultMenuLanguageDelegate GetDefaultMenuLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultAudioLanguage)(interface IDvdInfo2 * This, uint *pLanguage, DVD_AUDIO_LANG_EXT *pAudioExtension);
        public delegate int GetDefaultAudioLanguageDelegate(@interface IDvdInfo2 This, ref uint pLanguage, DVD_AUDIO_LANG_EXT pAudioExtension);
        public GetDefaultAudioLanguageDelegate GetDefaultAudioLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultSubpictureLanguage)(interface IDvdInfo2 * This, uint *pLanguage, DVD_SUBPICTURE_LANG_EXT *pSubpictureExtension);
        public delegate int GetDefaultSubpictureLanguageDelegate(@interface IDvdInfo2 This, ref uint pLanguage, DVD_SUBPICTURE_LANG_EXT pSubpictureExtension);
        public GetDefaultSubpictureLanguageDelegate GetDefaultSubpictureLanguage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDecoderCaps)(interface IDvdInfo2 * This, tagDVD_DECODER_CAPS *pCaps);
        public delegate int GetDecoderCapsDelegate(@interface IDvdInfo2 This, tagDVD_DECODER_CAPS pCaps);
        public GetDecoderCapsDelegate GetDecoderCaps;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetButtonRect)(interface IDvdInfo2 * This, uint ulButton, RECT *pRect);
        public delegate int GetButtonRectDelegate(@interface IDvdInfo2 This, uint ulButton, RECT pRect);
        public GetButtonRectDelegate GetButtonRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSubpictureStreamEnabled)(interface IDvdInfo2 * This, uint ulStreamNum, bool *pbEnabled);
        public delegate int IsSubpictureStreamEnabledDelegate(@interface IDvdInfo2 This, uint ulStreamNum, ref bool pbEnabled);
        public IsSubpictureStreamEnabledDelegate IsSubpictureStreamEnabled;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0379 */
/* [local] */ 

public enum _AM_DVD_GRAPH_FLAGS
{
        AM_DVD_HWDEC_PREFER = 0x1,
    AM_DVD_HWDEC_ONLY = 0x2,
    AM_DVD_SWDEC_PREFER = 0x4,
    AM_DVD_SWDEC_ONLY = 0x8,
    AM_DVD_NOVPE = 0x100,
    AM_DVD_VMR9_ONLY = 0x800
}

public enum _AM_DVD_STREAM_FLAGS
{
        AM_DVD_STREAM_VIDEO = 0x1,
    AM_DVD_STREAM_AUDIO = 0x2,
    AM_DVD_STREAM_SUBPIC = 0x4
}

public class __MIDL___MIDL_itf_strmif_0379_0001
{
    public int hrVPEStatus;
    public bool bDvdVolInvalid;
    public bool bDvdVolUnknown;
    public bool bNoLine21In;
    public bool bNoLine21Out;
    public int iNumStreams;
    public int iNumStreamsFailed;
    public uint dwFailedStreamsFlag;
}

#else // C style interface

    public class IDvdGraphBuilderVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDvdGraphBuilder * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDvdGraphBuilder This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDvdGraphBuilder * This);
        public delegate uint AddRefDelegate(@interface IDvdGraphBuilder This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDvdGraphBuilder * This);
        public delegate uint ReleaseDelegate(@interface IDvdGraphBuilder This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFiltergraph)(interface IDvdGraphBuilder * This, interface IGraphBuilder **ppGB);
        public delegate int GetFiltergraphDelegate(@interface IDvdGraphBuilder This, @interface IGraphBuilder[] ppGB);
        public GetFiltergraphDelegate GetFiltergraph;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDvdInterface)(interface IDvdGraphBuilder * This, REFIID riid, object**ppvIF);
        public delegate int GetDvdInterfaceDelegate(@interface IDvdGraphBuilder This, REFIID riid, object ppvIF[] UnnamedParameter);
        public GetDvdInterfaceDelegate GetDvdInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderDvdVideoVolume)(interface IDvdGraphBuilder * This, const char* lpcwszPathName, uint dwFlags, __MIDL___MIDL_itf_strmif_0379_0001 *pStatus);
        public delegate int RenderDvdVideoVolumeDelegate(@interface IDvdGraphBuilder This, string lpcwszPathName, uint dwFlags, __MIDL___MIDL_itf_strmif_0379_0001 pStatus);
        public RenderDvdVideoVolumeDelegate RenderDvdVideoVolume;

//        END_INTERFACE
    }

#else // C style interface

    public class IDDrawExclModeVideoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDDrawExclModeVideo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDDrawExclModeVideo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDDrawExclModeVideo * This);
        public delegate uint AddRefDelegate(@interface IDDrawExclModeVideo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDDrawExclModeVideo * This);
        public delegate uint ReleaseDelegate(@interface IDDrawExclModeVideo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDDrawObject)(interface IDDrawExclModeVideo * This, IDirectDraw *pDDrawObject);
        public delegate int SetDDrawObjectDelegate(@interface IDDrawExclModeVideo This, IDirectDraw pDDrawObject);
        public SetDDrawObjectDelegate SetDDrawObject;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDDrawObject)(interface IDDrawExclModeVideo * This, IDirectDraw **ppDDrawObject, bool *pbUsingExternal);
        public delegate int GetDDrawObjectDelegate(@interface IDDrawExclModeVideo This, IDirectDraw[] ppDDrawObject, ref bool pbUsingExternal);
        public GetDDrawObjectDelegate GetDDrawObject;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDDrawSurface)(interface IDDrawExclModeVideo * This, IDirectDrawSurface *pDDrawSurface);
        public delegate int SetDDrawSurfaceDelegate(@interface IDDrawExclModeVideo This, IDirectDrawSurface pDDrawSurface);
        public SetDDrawSurfaceDelegate SetDDrawSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDDrawSurface)(interface IDDrawExclModeVideo * This, IDirectDrawSurface **ppDDrawSurface, bool *pbUsingExternal);
        public delegate int GetDDrawSurfaceDelegate(@interface IDDrawExclModeVideo This, IDirectDrawSurface[] ppDDrawSurface, ref bool pbUsingExternal);
        public GetDDrawSurfaceDelegate GetDDrawSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDrawParameters)(interface IDDrawExclModeVideo * This, const RECT *prcSource, const RECT *prcTarget);
        public delegate int SetDrawParametersDelegate(@interface IDDrawExclModeVideo This, RECT prcSource, RECT prcTarget);
        public SetDrawParametersDelegate SetDrawParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNativeVideoProps)(interface IDDrawExclModeVideo * This, uint *pdwVideoWidth, uint *pdwVideoHeight, uint *pdwPictAspectRatioX, uint *pdwPictAspectRatioY);
        public delegate int GetNativeVideoPropsDelegate(@interface IDDrawExclModeVideo This, ref uint pdwVideoWidth, ref uint pdwVideoHeight, ref uint pdwPictAspectRatioX, ref uint pdwPictAspectRatioY);
        public GetNativeVideoPropsDelegate GetNativeVideoProps;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetCallbackInterface)(interface IDDrawExclModeVideo * This, interface IDDrawExclModeVideoCallback *pCallback, uint dwFlags);
        public delegate int SetCallbackInterfaceDelegate(@interface IDDrawExclModeVideo This, @interface IDDrawExclModeVideoCallback pCallback, uint dwFlags);
        public SetCallbackInterfaceDelegate SetCallbackInterface;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0381 */
/* [local] */ 


public enum _AM_OVERLAY_NOTIFY_FLAGS
{
        AM_OVERLAY_NOTIFY_VISIBLE_CHANGE = 0x1,
    AM_OVERLAY_NOTIFY_SOURCE_CHANGE = 0x2,
    AM_OVERLAY_NOTIFY_DEST_CHANGE = 0x4
}

#else // C style interface

    public class IDDrawExclModeVideoCallbackVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDDrawExclModeVideoCallback * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDDrawExclModeVideoCallback This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDDrawExclModeVideoCallback * This);
        public delegate uint AddRefDelegate(@interface IDDrawExclModeVideoCallback This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDDrawExclModeVideoCallback * This);
        public delegate uint ReleaseDelegate(@interface IDDrawExclModeVideoCallback This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnUpdateOverlay)(interface IDDrawExclModeVideoCallback * This, bool bBefore, uint dwFlags, bool bOldVisible, const RECT *prcOldSrc, const RECT *prcOldDest, bool bNewVisible, const RECT *prcNewSrc, const RECT *prcNewDest);
        public delegate int OnUpdateOverlayDelegate(@interface IDDrawExclModeVideoCallback This, bool bBefore, uint dwFlags, bool bOldVisible, RECT prcOldSrc, RECT prcOldDest, bool bNewVisible, RECT prcNewSrc, RECT prcNewDest);
        public OnUpdateOverlayDelegate OnUpdateOverlay;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnUpdateColorKey)(interface IDDrawExclModeVideoCallback * This, const tagCOLORKEY *pKey, uint dwColor);
        public delegate int OnUpdateColorKeyDelegate(@interface IDDrawExclModeVideoCallback This, tagCOLORKEY pKey, uint dwColor);
        public OnUpdateColorKeyDelegate OnUpdateColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnUpdateSize)(interface IDDrawExclModeVideoCallback * This, uint dwWidth, uint dwHeight, uint dwARWidth, uint dwARHeight);
        public delegate int OnUpdateSizeDelegate(@interface IDDrawExclModeVideoCallback This, uint dwWidth, uint dwHeight, uint dwARWidth, uint dwARHeight);
        public OnUpdateSizeDelegate OnUpdateSize;

//        END_INTERFACE
    }

#else // C style interface

    public class IPinConnectionVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IPinConnection * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IPinConnection This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IPinConnection * This);
        public delegate uint AddRefDelegate(@interface IPinConnection This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IPinConnection * This);
        public delegate uint ReleaseDelegate(@interface IPinConnection This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DynamicQueryAccept)(interface IPinConnection * This, const _AMMediaType *pmt);
        public delegate int DynamicQueryAcceptDelegate(@interface IPinConnection This, _AMMediaType pmt);
        public DynamicQueryAcceptDelegate DynamicQueryAccept;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyEndOfStream)(interface IPinConnection * This, System.IntPtr hNotifyEvent);
        public delegate int NotifyEndOfStreamDelegate(@interface IPinConnection This, IntPtr hNotifyEvent);
        public NotifyEndOfStreamDelegate NotifyEndOfStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsEndPin)(interface IPinConnection * This);
        public delegate int IsEndPinDelegate(@interface IPinConnection This);
        public IsEndPinDelegate IsEndPin;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DynamicDisconnect)(interface IPinConnection * This);
        public delegate int DynamicDisconnectDelegate(@interface IPinConnection This);
        public DynamicDisconnectDelegate DynamicDisconnect;

//        END_INTERFACE
    }

#else // C style interface

    public class IPinFlowControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IPinFlowControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IPinFlowControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IPinFlowControl * This);
        public delegate uint AddRefDelegate(@interface IPinFlowControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IPinFlowControl * This);
        public delegate uint ReleaseDelegate(@interface IPinFlowControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Block)(interface IPinFlowControl * This, uint dwBlockFlags, System.IntPtr hEvent);
        public delegate int BlockDelegate(@interface IPinFlowControl This, uint dwBlockFlags, IntPtr hEvent);
        public BlockDelegate Block;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0384 */
/* [local] */ 


public enum _AM_PIN_FLOW_CONTROL_BLOCK_FLAGS
{
        AM_PIN_FLOW_CONTROL_BLOCK = 0x1
}
public enum _AM_GRAPH_CONFIG_RECONNECT_FLAGS
{
        AM_GRAPH_CONFIG_RECONNECT_DIRECTCONNECT = 0x1,
    AM_GRAPH_CONFIG_RECONNECT_CACHE_REMOVED_FILTERS = 0x2,
    AM_GRAPH_CONFIG_RECONNECT_USE_ONLY_CACHED_FILTERS = 0x4
}


public enum _REM_FILTER_FLAGS
{
        REMFILTERF_LEAVECONNECTED = 0x1
}
public enum _AM_FILTER_FLAGS
{
        AM_FILTER_FLAGS_REMOVABLE = 0x1
}

#else // C style interface

    public class IGraphConfigVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IGraphConfig * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IGraphConfig This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IGraphConfig * This);
        public delegate uint AddRefDelegate(@interface IGraphConfig This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IGraphConfig * This);
        public delegate uint ReleaseDelegate(@interface IGraphConfig This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reconnect)(interface IGraphConfig * This, interface IPin *pOutputPin, interface IPin *pInputPin, const _AMMediaType *pmtFirstConnection, interface IBaseFilter *pUsingFilter, System.IntPtr hAbortEvent, uint dwFlags);
        public delegate int ReconnectDelegate(@interface IGraphConfig This, @interface IPin pOutputPin, @interface IPin pInputPin, _AMMediaType pmtFirstConnection, @interface IBaseFilter pUsingFilter, IntPtr hAbortEvent, uint dwFlags);
        public ReconnectDelegate Reconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reconfigure)(interface IGraphConfig * This, interface IGraphConfigCallback *pCallback, object* pvContext, uint dwFlags, System.IntPtr hAbortEvent);
        public delegate int ReconfigureDelegate(@interface IGraphConfig This, @interface IGraphConfigCallback pCallback, object pvContext, uint dwFlags, IntPtr hAbortEvent);
        public ReconfigureDelegate Reconfigure;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddFilterToCache)(interface IGraphConfig * This, interface IBaseFilter *pFilter);
        public delegate int AddFilterToCacheDelegate(@interface IGraphConfig This, @interface IBaseFilter pFilter);
        public AddFilterToCacheDelegate AddFilterToCache;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *EnumCacheFilter)(interface IGraphConfig * This, interface IEnumFilters **pEnum);
        public delegate int EnumCacheFilterDelegate(@interface IGraphConfig This, @interface IEnumFilters[] pEnum);
        public EnumCacheFilterDelegate EnumCacheFilter;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveFilterFromCache)(interface IGraphConfig * This, interface IBaseFilter *pFilter);
        public delegate int RemoveFilterFromCacheDelegate(@interface IGraphConfig This, @interface IBaseFilter pFilter);
        public RemoveFilterFromCacheDelegate RemoveFilterFromCache;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStartTime)(interface IGraphConfig * This, long *prtStart);
        public delegate int GetStartTimeDelegate(@interface IGraphConfig This, ref long prtStart);
        public GetStartTimeDelegate GetStartTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PushThroughData)(interface IGraphConfig * This, interface IPin *pOutputPin, interface IPinConnection *pConnection, System.IntPtr hEventAbort);
        public delegate int PushThroughDataDelegate(@interface IGraphConfig This, @interface IPin pOutputPin, @interface IPinConnection pConnection, IntPtr hEventAbort);
        public PushThroughDataDelegate PushThroughData;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFilterFlags)(interface IGraphConfig * This, interface IBaseFilter *pFilter, uint dwFlags);
        public delegate int SetFilterFlagsDelegate(@interface IGraphConfig This, @interface IBaseFilter pFilter, uint dwFlags);
        public SetFilterFlagsDelegate SetFilterFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFilterFlags)(interface IGraphConfig * This, interface IBaseFilter *pFilter, uint *pdwFlags);
        public delegate int GetFilterFlagsDelegate(@interface IGraphConfig This, @interface IBaseFilter pFilter, ref uint pdwFlags);
        public GetFilterFlagsDelegate GetFilterFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveFilterEx)(interface IGraphConfig * This, interface IBaseFilter *pFilter, uint Flags);
        public delegate int RemoveFilterExDelegate(@interface IGraphConfig This, @interface IBaseFilter pFilter, uint Flags);
        public RemoveFilterExDelegate RemoveFilterEx;

//        END_INTERFACE
    }

#else // C style interface

    public class IGraphConfigCallbackVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IGraphConfigCallback * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IGraphConfigCallback This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IGraphConfigCallback * This);
        public delegate uint AddRefDelegate(@interface IGraphConfigCallback This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IGraphConfigCallback * This);
        public delegate uint ReleaseDelegate(@interface IGraphConfigCallback This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reconfigure)(interface IGraphConfigCallback * This, object* pvContext, uint dwFlags);
        public delegate int ReconfigureDelegate(@interface IGraphConfigCallback This, object pvContext, uint dwFlags);
        public ReconfigureDelegate Reconfigure;

//        END_INTERFACE
    }

#else // C style interface

    public class IFilterChainVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterChain * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterChain This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterChain * This);
        public delegate uint AddRefDelegate(@interface IFilterChain This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterChain * This);
        public delegate uint ReleaseDelegate(@interface IFilterChain This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StartChain)(interface IFilterChain * This, interface IBaseFilter *pStartFilter, interface IBaseFilter *pEndFilter);
        public delegate int StartChainDelegate(@interface IFilterChain This, @interface IBaseFilter pStartFilter, @interface IBaseFilter pEndFilter);
        public StartChainDelegate StartChain;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PauseChain)(interface IFilterChain * This, interface IBaseFilter *pStartFilter, interface IBaseFilter *pEndFilter);
        public delegate int PauseChainDelegate(@interface IFilterChain This, @interface IBaseFilter pStartFilter, @interface IBaseFilter pEndFilter);
        public PauseChainDelegate PauseChain;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StopChain)(interface IFilterChain * This, interface IBaseFilter *pStartFilter, interface IBaseFilter *pEndFilter);
        public delegate int StopChainDelegate(@interface IFilterChain This, @interface IBaseFilter pStartFilter, @interface IBaseFilter pEndFilter);
        public StopChainDelegate StopChain;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RemoveChain)(interface IFilterChain * This, interface IBaseFilter *pStartFilter, interface IBaseFilter *pEndFilter);
        public delegate int RemoveChainDelegate(@interface IFilterChain This, @interface IBaseFilter pStartFilter, @interface IBaseFilter pEndFilter);
        public RemoveChainDelegate RemoveChain;

//        END_INTERFACE
    }














public enum __MIDL___MIDL_itf_strmif_0387_0002
{
        VMRSample_SyncPoint = 0x1,
    VMRSample_Preroll = 0x2,
    VMRSample_Discontinuity = 0x4,
    VMRSample_TimeValid = 0x8
}

public class tagVMRPRESENTATIONINFO
{
    public uint dwFlags;
    public LPDIRECTDRAWSURFACE7 lpSurf = new LPDIRECTDRAWSURFACE7();
    public long rtStart;
    public long rtEnd;
    public SIZE szAspectRatio = new SIZE();
    public RECT rcSrc = new RECT();
    public RECT rcDst = new RECT();
    public uint dwTypeSpecificFlags;
    public uint dwInterlaceFlags;
}

#else // C style interface

    public class IVMRImagePresenterVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImagePresenter * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImagePresenter This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImagePresenter * This);
        public delegate uint AddRefDelegate(@interface IVMRImagePresenter This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImagePresenter * This);
        public delegate uint ReleaseDelegate(@interface IVMRImagePresenter This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StartPresenting)(interface IVMRImagePresenter * This, System.IntPtr dwUserID);
        public delegate int StartPresentingDelegate(@interface IVMRImagePresenter This, IntPtr dwUserID);
        public StartPresentingDelegate StartPresenting;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StopPresenting)(interface IVMRImagePresenter * This, System.IntPtr dwUserID);
        public delegate int StopPresentingDelegate(@interface IVMRImagePresenter This, IntPtr dwUserID);
        public StopPresentingDelegate StopPresenting;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PresentImage)(interface IVMRImagePresenter * This, System.IntPtr dwUserID, tagVMRPRESENTATIONINFO *lpPresInfo);
        public delegate int PresentImageDelegate(@interface IVMRImagePresenter This, IntPtr dwUserID, tagVMRPRESENTATIONINFO lpPresInfo);
        public PresentImageDelegate PresentImage;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0388 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0388_0001
{
        AMAP_PIXELFORMAT_VALID = 0x1,
    AMAP_3D_TARGET = 0x2,
    AMAP_ALLOW_SYSMEM = 0x4,
    AMAP_FORCE_SYSMEM = 0x8,
    AMAP_DIRECTED_FLIP = 0x10,
    AMAP_DXVA_TARGET = 0x20
}

public class tagVMRALLOCATIONINFO
{
    public uint dwFlags;
    public LPBITMAPINFOHEADER lpHdr = new LPBITMAPINFOHEADER();
    public LPDDPIXELFORMAT lpPixFmt = new LPDDPIXELFORMAT();
    public SIZE szAspectRatio = new SIZE();
    public uint dwMinBuffers;
    public uint dwMaxBuffers;
    public uint dwInterlaceFlags;
    public SIZE szNativeSize = new SIZE();
}

#else // C style interface

    public class IVMRSurfaceAllocatorVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRSurfaceAllocator * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRSurfaceAllocator This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRSurfaceAllocator * This);
        public delegate uint AddRefDelegate(@interface IVMRSurfaceAllocator This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRSurfaceAllocator * This);
        public delegate uint ReleaseDelegate(@interface IVMRSurfaceAllocator This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocateSurface)(interface IVMRSurfaceAllocator * This, System.IntPtr dwUserID, tagVMRALLOCATIONINFO *lpAllocInfo, uint *lpdwActualBuffers, LPDIRECTDRAWSURFACE7 *lplpSurface);
        public delegate int AllocateSurfaceDelegate(@interface IVMRSurfaceAllocator This, IntPtr dwUserID, tagVMRALLOCATIONINFO lpAllocInfo, ref uint lpdwActualBuffers, LPDIRECTDRAWSURFACE7 lplpSurface);
        public AllocateSurfaceDelegate AllocateSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FreeSurface)(interface IVMRSurfaceAllocator * This, System.IntPtr dwID);
        public delegate int FreeSurfaceDelegate(@interface IVMRSurfaceAllocator This, IntPtr dwID);
        public FreeSurfaceDelegate FreeSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PrepareSurface)(interface IVMRSurfaceAllocator * This, System.IntPtr dwUserID, LPDIRECTDRAWSURFACE7 lpSurface, uint dwSurfaceFlags);
        public delegate int PrepareSurfaceDelegate(@interface IVMRSurfaceAllocator This, IntPtr dwUserID, LPDIRECTDRAWSURFACE7 lpSurface, uint dwSurfaceFlags);
        public PrepareSurfaceDelegate PrepareSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdviseNotify)(interface IVMRSurfaceAllocator * This, interface IVMRSurfaceAllocatorNotify *lpIVMRSurfAllocNotify);
        public delegate int AdviseNotifyDelegate(@interface IVMRSurfaceAllocator This, @interface IVMRSurfaceAllocatorNotify lpIVMRSurfAllocNotify);
        public AdviseNotifyDelegate AdviseNotify;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRSurfaceAllocatorNotifyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRSurfaceAllocatorNotify * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRSurfaceAllocatorNotify This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRSurfaceAllocatorNotify * This);
        public delegate uint AddRefDelegate(@interface IVMRSurfaceAllocatorNotify This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRSurfaceAllocatorNotify * This);
        public delegate uint ReleaseDelegate(@interface IVMRSurfaceAllocatorNotify This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdviseSurfaceAllocator)(interface IVMRSurfaceAllocatorNotify * This, System.IntPtr dwUserID, interface IVMRSurfaceAllocator *lpIVRMSurfaceAllocator);
        public delegate int AdviseSurfaceAllocatorDelegate(@interface IVMRSurfaceAllocatorNotify This, IntPtr dwUserID, @interface IVMRSurfaceAllocator lpIVRMSurfaceAllocator);
        public AdviseSurfaceAllocatorDelegate AdviseSurfaceAllocator;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDDrawDevice)(interface IVMRSurfaceAllocatorNotify * This, LPDIRECTDRAW7 lpDDrawDevice, System.IntPtr hMonitor);
        public delegate int SetDDrawDeviceDelegate(@interface IVMRSurfaceAllocatorNotify This, LPDIRECTDRAW7 lpDDrawDevice, IntPtr hMonitor);
        public SetDDrawDeviceDelegate SetDDrawDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeDDrawDevice)(interface IVMRSurfaceAllocatorNotify * This, LPDIRECTDRAW7 lpDDrawDevice, System.IntPtr hMonitor);
        public delegate int ChangeDDrawDeviceDelegate(@interface IVMRSurfaceAllocatorNotify This, LPDIRECTDRAW7 lpDDrawDevice, IntPtr hMonitor);
        public ChangeDDrawDeviceDelegate ChangeDDrawDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RestoreDDrawSurfaces)(interface IVMRSurfaceAllocatorNotify * This);
        public delegate int RestoreDDrawSurfacesDelegate(@interface IVMRSurfaceAllocatorNotify This);
        public RestoreDDrawSurfacesDelegate RestoreDDrawSurfaces;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyEvent)(interface IVMRSurfaceAllocatorNotify * This, int EventCode, System.IntPtr Param1, System.IntPtr Param2);
        public delegate int NotifyEventDelegate(@interface IVMRSurfaceAllocatorNotify This, int EventCode, IntPtr Param1, IntPtr Param2);
        public NotifyEventDelegate NotifyEvent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBorderColor)(interface IVMRSurfaceAllocatorNotify * This, uint clrBorder);
        public delegate int SetBorderColorDelegate(@interface IVMRSurfaceAllocatorNotify This, uint clrBorder);
        public SetBorderColorDelegate SetBorderColor;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0390 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0390_0001
{
        VMR_ARMODE_NONE = 0,
    VMR_ARMODE_LETTER_BOX = VMR_ARMODE_NONE + 1
}

#else // C style interface

    public class IVMRWindowlessControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRWindowlessControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRWindowlessControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRWindowlessControl * This);
        public delegate uint AddRefDelegate(@interface IVMRWindowlessControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRWindowlessControl * This);
        public delegate uint ReleaseDelegate(@interface IVMRWindowlessControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNativeVideoSize)(interface IVMRWindowlessControl * This, int *lpWidth, int *lpHeight, int *lpARWidth, int *lpARHeight);
        public delegate int GetNativeVideoSizeDelegate(@interface IVMRWindowlessControl This, ref int lpWidth, ref int lpHeight, ref int lpARWidth, ref int lpARHeight);
        public GetNativeVideoSizeDelegate GetNativeVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMinIdealVideoSize)(interface IVMRWindowlessControl * This, int *lpWidth, int *lpHeight);
        public delegate int GetMinIdealVideoSizeDelegate(@interface IVMRWindowlessControl This, ref int lpWidth, ref int lpHeight);
        public GetMinIdealVideoSizeDelegate GetMinIdealVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMaxIdealVideoSize)(interface IVMRWindowlessControl * This, int *lpWidth, int *lpHeight);
        public delegate int GetMaxIdealVideoSizeDelegate(@interface IVMRWindowlessControl This, ref int lpWidth, ref int lpHeight);
        public GetMaxIdealVideoSizeDelegate GetMaxIdealVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetVideoPosition)(interface IVMRWindowlessControl * This, const LPRECT lpSRCRect, const LPRECT lpDSTRect);
        public delegate int SetVideoPositionDelegate(@interface IVMRWindowlessControl This, LPRECT lpSRCRect, LPRECT lpDSTRect);
        public SetVideoPositionDelegate SetVideoPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoPosition)(interface IVMRWindowlessControl * This, LPRECT lpSRCRect, LPRECT lpDSTRect);
        public delegate int GetVideoPositionDelegate(@interface IVMRWindowlessControl This, LPRECT lpSRCRect, LPRECT lpDSTRect);
        public GetVideoPositionDelegate GetVideoPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAspectRatioMode)(interface IVMRWindowlessControl * This, uint *lpAspectRatioMode);
        public delegate int GetAspectRatioModeDelegate(@interface IVMRWindowlessControl This, ref uint lpAspectRatioMode);
        public GetAspectRatioModeDelegate GetAspectRatioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAspectRatioMode)(interface IVMRWindowlessControl * This, uint AspectRatioMode);
        public delegate int SetAspectRatioModeDelegate(@interface IVMRWindowlessControl This, uint AspectRatioMode);
        public SetAspectRatioModeDelegate SetAspectRatioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetVideoClippingWindow)(interface IVMRWindowlessControl * This, System.IntPtr hwnd);
        public delegate int SetVideoClippingWindowDelegate(@interface IVMRWindowlessControl This, IntPtr hwnd);
        public SetVideoClippingWindowDelegate SetVideoClippingWindow;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RepaintVideo)(interface IVMRWindowlessControl * This, System.IntPtr hwnd, System.IntPtr hdc);
        public delegate int RepaintVideoDelegate(@interface IVMRWindowlessControl This, IntPtr hwnd, IntPtr hdc);
        public RepaintVideoDelegate RepaintVideo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DisplayModeChanged)(interface IVMRWindowlessControl * This);
        public delegate int DisplayModeChangedDelegate(@interface IVMRWindowlessControl This);
        public DisplayModeChangedDelegate DisplayModeChanged;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentImage)(interface IVMRWindowlessControl * This, byte **lpDib);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetCurrentImageDelegate(@interface IVMRWindowlessControl This, byte[] lpDib);
        public GetCurrentImageDelegate GetCurrentImage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBorderColor)(interface IVMRWindowlessControl * This, uint Clr);
        public delegate int SetBorderColorDelegate(@interface IVMRWindowlessControl This, uint Clr);
        public SetBorderColorDelegate SetBorderColor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBorderColor)(interface IVMRWindowlessControl * This, uint *lpClr);
        public delegate int GetBorderColorDelegate(@interface IVMRWindowlessControl This, ref uint lpClr);
        public GetBorderColorDelegate GetBorderColor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetColorKey)(interface IVMRWindowlessControl * This, uint Clr);
        public delegate int SetColorKeyDelegate(@interface IVMRWindowlessControl This, uint Clr);
        public SetColorKeyDelegate SetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetColorKey)(interface IVMRWindowlessControl * This, uint *lpClr);
        public delegate int GetColorKeyDelegate(@interface IVMRWindowlessControl This, ref uint lpClr);
        public GetColorKeyDelegate GetColorKey;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0391 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0391_0001
{
        MixerPref_NoDecimation = 0x1,
    MixerPref_DecimateOutput = 0x2,
    MixerPref_DecimateMask = 0xf,
    MixerPref_BiLinearFiltering = 0x10,
    MixerPref_PointFiltering = 0x20,
    MixerPref_FilteringMask = 0xf0,
    MixerPref_RenderTargetRGB = 0x100,
    MixerPref_RenderTargetYUV420 = 0x200,
    MixerPref_RenderTargetYUV422 = 0x400,
    MixerPref_RenderTargetYUV444 = 0x800,
    MixerPref_RenderTargetReserved = 0xf000,
    MixerPref_RenderTargetMask = 0xff00
}

public class _NORMALIZEDRECT
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}

#else // C style interface

    public class IVMRMixerControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRMixerControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRMixerControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRMixerControl * This);
        public delegate uint AddRefDelegate(@interface IVMRMixerControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRMixerControl * This);
        public delegate uint ReleaseDelegate(@interface IVMRMixerControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAlpha)(interface IVMRMixerControl * This, uint dwStreamID, float Alpha);
        public delegate int SetAlphaDelegate(@interface IVMRMixerControl This, uint dwStreamID, float Alpha);
        public SetAlphaDelegate SetAlpha;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAlpha)(interface IVMRMixerControl * This, uint dwStreamID, float *pAlpha);
        public delegate int GetAlphaDelegate(@interface IVMRMixerControl This, uint dwStreamID, ref float pAlpha);
        public GetAlphaDelegate GetAlpha;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetZOrder)(interface IVMRMixerControl * This, uint dwStreamID, uint dwZ);
        public delegate int SetZOrderDelegate(@interface IVMRMixerControl This, uint dwStreamID, uint dwZ);
        public SetZOrderDelegate SetZOrder;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetZOrder)(interface IVMRMixerControl * This, uint dwStreamID, uint *pZ);
        public delegate int GetZOrderDelegate(@interface IVMRMixerControl This, uint dwStreamID, ref uint pZ);
        public GetZOrderDelegate GetZOrder;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputRect)(interface IVMRMixerControl * This, uint dwStreamID, const _NORMALIZEDRECT *pRect);
        public delegate int SetOutputRectDelegate(@interface IVMRMixerControl This, uint dwStreamID, _NORMALIZEDRECT pRect);
        public SetOutputRectDelegate SetOutputRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputRect)(interface IVMRMixerControl * This, uint dwStreamID, _NORMALIZEDRECT *pRect);
        public delegate int GetOutputRectDelegate(@interface IVMRMixerControl This, uint dwStreamID, _NORMALIZEDRECT pRect);
        public GetOutputRectDelegate GetOutputRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBackgroundClr)(interface IVMRMixerControl * This, uint ClrBkg);
        public delegate int SetBackgroundClrDelegate(@interface IVMRMixerControl This, uint ClrBkg);
        public SetBackgroundClrDelegate SetBackgroundClr;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBackgroundClr)(interface IVMRMixerControl * This, uint *lpClrBkg);
        public delegate int GetBackgroundClrDelegate(@interface IVMRMixerControl This, ref uint lpClrBkg);
        public GetBackgroundClrDelegate GetBackgroundClr;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMixingPrefs)(interface IVMRMixerControl * This, uint dwMixerPrefs);
        public delegate int SetMixingPrefsDelegate(@interface IVMRMixerControl This, uint dwMixerPrefs);
        public SetMixingPrefsDelegate SetMixingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMixingPrefs)(interface IVMRMixerControl * This, uint *pdwMixerPrefs);
        public delegate int GetMixingPrefsDelegate(@interface IVMRMixerControl This, ref uint pdwMixerPrefs);
        public GetMixingPrefsDelegate GetMixingPrefs;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0392 */
/* [local] */ 

public class tagVMRGUID
{
    public GUID pGUID;
    public GUID GUID = new GUID();
}

public class tagVMRMONITORINFO
{
    public tagVMRGUID guid = new tagVMRGUID();
    public RECT rcMonitor = new RECT();
    public IntPtr hMon;
    public uint dwFlags;
    public string szDevice = new string(new char[32]);
    public string szDescription = new string(new char[256]);
    public LARGE_INTEGER liDriverVersion = new LARGE_INTEGER();
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
}

#else // C style interface

    public class IVMRMonitorConfigVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRMonitorConfig * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRMonitorConfig This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRMonitorConfig * This);
        public delegate uint AddRefDelegate(@interface IVMRMonitorConfig This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRMonitorConfig * This);
        public delegate uint ReleaseDelegate(@interface IVMRMonitorConfig This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMonitor)(interface IVMRMonitorConfig * This, const tagVMRGUID *pGUID);
        public delegate int SetMonitorDelegate(@interface IVMRMonitorConfig This, tagVMRGUID pGUID);
        public SetMonitorDelegate SetMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMonitor)(interface IVMRMonitorConfig * This, tagVMRGUID *pGUID);
        public delegate int GetMonitorDelegate(@interface IVMRMonitorConfig This, tagVMRGUID pGUID);
        public GetMonitorDelegate GetMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultMonitor)(interface IVMRMonitorConfig * This, const tagVMRGUID *pGUID);
        public delegate int SetDefaultMonitorDelegate(@interface IVMRMonitorConfig This, tagVMRGUID pGUID);
        public SetDefaultMonitorDelegate SetDefaultMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultMonitor)(interface IVMRMonitorConfig * This, tagVMRGUID *pGUID);
        public delegate int GetDefaultMonitorDelegate(@interface IVMRMonitorConfig This, tagVMRGUID pGUID);
        public GetDefaultMonitorDelegate GetDefaultMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailableMonitors)(interface IVMRMonitorConfig * This, tagVMRMONITORINFO *pInfo, uint dwMaxInfoArraySize, uint *pdwNumDevices);
        public delegate int GetAvailableMonitorsDelegate(@interface IVMRMonitorConfig This, tagVMRMONITORINFO pInfo, uint dwMaxInfoArraySize, ref uint pdwNumDevices);
        public GetAvailableMonitorsDelegate GetAvailableMonitors;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0393 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0393_0001
{
        RenderPrefs_RestrictToInitialMonitor = 0,
    RenderPrefs_ForceOffscreen = 0x1,
    RenderPrefs_ForceOverlays = 0x2,
    RenderPrefs_AllowOverlays = 0,
    RenderPrefs_AllowOffscreen = 0,
    RenderPrefs_DoNotRenderColorKeyAndBorder = 0x8,
    RenderPrefs_Reserved = 0x10,
    RenderPrefs_PreferAGPMemWhenMixing = 0x20,
    RenderPrefs_Mask = 0x3f
}

public enum __MIDL___MIDL_itf_strmif_0393_0002
{
        VMRMode_Windowed = 0x1,
    VMRMode_Windowless = 0x2,
    VMRMode_Renderless = 0x4,
    VMRMode_Mask = 0x7
}


public enum __MIDL___MIDL_itf_strmif_0393_0003
{
        MAX_NUMBER_OF_STREAMS = 16
}

#else // C style interface

    public class IVMRFilterConfigVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRFilterConfig * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRFilterConfig This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRFilterConfig * This);
        public delegate uint AddRefDelegate(@interface IVMRFilterConfig This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRFilterConfig * This);
        public delegate uint ReleaseDelegate(@interface IVMRFilterConfig This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetImageCompositor)(interface IVMRFilterConfig * This, interface IVMRImageCompositor *lpVMRImgCompositor);
        public delegate int SetImageCompositorDelegate(@interface IVMRFilterConfig This, @interface IVMRImageCompositor lpVMRImgCompositor);
        public SetImageCompositorDelegate SetImageCompositor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetNumberOfStreams)(interface IVMRFilterConfig * This, uint dwMaxStreams);
        public delegate int SetNumberOfStreamsDelegate(@interface IVMRFilterConfig This, uint dwMaxStreams);
        public SetNumberOfStreamsDelegate SetNumberOfStreams;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfStreams)(interface IVMRFilterConfig * This, uint *pdwMaxStreams);
        public delegate int GetNumberOfStreamsDelegate(@interface IVMRFilterConfig This, ref uint pdwMaxStreams);
        public GetNumberOfStreamsDelegate GetNumberOfStreams;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingPrefs)(interface IVMRFilterConfig * This, uint dwRenderFlags);
        public delegate int SetRenderingPrefsDelegate(@interface IVMRFilterConfig This, uint dwRenderFlags);
        public SetRenderingPrefsDelegate SetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingPrefs)(interface IVMRFilterConfig * This, uint *pdwRenderFlags);
        public delegate int GetRenderingPrefsDelegate(@interface IVMRFilterConfig This, ref uint pdwRenderFlags);
        public GetRenderingPrefsDelegate GetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingMode)(interface IVMRFilterConfig * This, uint Mode);
        public delegate int SetRenderingModeDelegate(@interface IVMRFilterConfig This, uint Mode);
        public SetRenderingModeDelegate SetRenderingMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingMode)(interface IVMRFilterConfig * This, uint *pMode);
        public delegate int GetRenderingModeDelegate(@interface IVMRFilterConfig This, ref uint pMode);
        public GetRenderingModeDelegate GetRenderingMode;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRAspectRatioControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRAspectRatioControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRAspectRatioControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRAspectRatioControl * This);
        public delegate uint AddRefDelegate(@interface IVMRAspectRatioControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRAspectRatioControl * This);
        public delegate uint ReleaseDelegate(@interface IVMRAspectRatioControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAspectRatioMode)(interface IVMRAspectRatioControl * This, uint * lpdwARMode);
        public delegate int GetAspectRatioModeDelegate(@interface IVMRAspectRatioControl This, ref uint lpdwARMode);
        public GetAspectRatioModeDelegate GetAspectRatioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAspectRatioMode)(interface IVMRAspectRatioControl * This, uint dwARMode);
        public delegate int SetAspectRatioModeDelegate(@interface IVMRAspectRatioControl This, uint dwARMode);
        public SetAspectRatioModeDelegate SetAspectRatioMode;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0395 */
/* [local] */ 

public enum __MIDL___MIDL_itf_strmif_0395_0001
{
        DeinterlacePref_NextBest = 0x1,
    DeinterlacePref_BOB = 0x2,
    DeinterlacePref_Weave = 0x4,
    DeinterlacePref_Mask = 0x7
}

public enum __MIDL___MIDL_itf_strmif_0395_0002
{
        DeinterlaceTech_Unknown = 0,
    DeinterlaceTech_BOBLineReplicate = 0x1,
    DeinterlaceTech_BOBVerticalStretch = 0x2,
    DeinterlaceTech_MedianFiltering = 0x4,
    DeinterlaceTech_EdgeFiltering = 0x10,
    DeinterlaceTech_FieldAdaptive = 0x20,
    DeinterlaceTech_PixelAdaptive = 0x40,
    DeinterlaceTech_MotionVectorSteered = 0x80
}

public class _VMRFrequency
{
    public uint dwNumerator;
    public uint dwDenominator;
}

public class _VMRVideoDesc
{
    public uint dwSize;
    public uint dwSampleWidth;
    public uint dwSampleHeight;
    public bool SingleFieldPerSample;
    public uint dwFourCC;
    public _VMRFrequency InputSampleFreq = new _VMRFrequency();
    public _VMRFrequency OutputFrameFreq = new _VMRFrequency();
}

public class _VMRDeinterlaceCaps
{
    public uint dwSize;
    public uint dwNumPreviousOutputFrames;
    public uint dwNumForwardRefSamples;
    public uint dwNumBackwardRefSamples;
    public VMRDeinterlaceTech DeinterlaceTechnology = new VMRDeinterlaceTech();
}

#else // C style interface

    public class IVMRDeinterlaceControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRDeinterlaceControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRDeinterlaceControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRDeinterlaceControl * This);
        public delegate uint AddRefDelegate(@interface IVMRDeinterlaceControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRDeinterlaceControl * This);
        public delegate uint ReleaseDelegate(@interface IVMRDeinterlaceControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfDeinterlaceModes)(interface IVMRDeinterlaceControl * This, _VMRVideoDesc *lpVideoDescription, uint * lpdwNumDeinterlaceModes, LPGUID lpDeinterlaceModes);
        public delegate int GetNumberOfDeinterlaceModesDelegate(@interface IVMRDeinterlaceControl This, _VMRVideoDesc lpVideoDescription, ref uint lpdwNumDeinterlaceModes, LPGUID lpDeinterlaceModes);
        public GetNumberOfDeinterlaceModesDelegate GetNumberOfDeinterlaceModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDeinterlaceModeCaps)(interface IVMRDeinterlaceControl * This, LPGUID lpDeinterlaceMode, _VMRVideoDesc *lpVideoDescription, _VMRDeinterlaceCaps *lpDeinterlaceCaps);
        public delegate int GetDeinterlaceModeCapsDelegate(@interface IVMRDeinterlaceControl This, LPGUID lpDeinterlaceMode, _VMRVideoDesc lpVideoDescription, _VMRDeinterlaceCaps lpDeinterlaceCaps);
        public GetDeinterlaceModeCapsDelegate GetDeinterlaceModeCaps;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDeinterlaceMode)(interface IVMRDeinterlaceControl * This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public delegate int GetDeinterlaceModeDelegate(@interface IVMRDeinterlaceControl This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public GetDeinterlaceModeDelegate GetDeinterlaceMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDeinterlaceMode)(interface IVMRDeinterlaceControl * This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public delegate int SetDeinterlaceModeDelegate(@interface IVMRDeinterlaceControl This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public SetDeinterlaceModeDelegate SetDeinterlaceMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDeinterlacePrefs)(interface IVMRDeinterlaceControl * This, uint * lpdwDeinterlacePrefs);
        public delegate int GetDeinterlacePrefsDelegate(@interface IVMRDeinterlaceControl This, ref uint lpdwDeinterlacePrefs);
        public GetDeinterlacePrefsDelegate GetDeinterlacePrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDeinterlacePrefs)(interface IVMRDeinterlaceControl * This, uint dwDeinterlacePrefs);
        public delegate int SetDeinterlacePrefsDelegate(@interface IVMRDeinterlaceControl This, uint dwDeinterlacePrefs);
        public SetDeinterlacePrefsDelegate SetDeinterlacePrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetActualDeinterlaceMode)(interface IVMRDeinterlaceControl * This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public delegate int GetActualDeinterlaceModeDelegate(@interface IVMRDeinterlaceControl This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public GetActualDeinterlaceModeDelegate GetActualDeinterlaceMode;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0396 */
/* [local] */ 

public class _VMRALPHABITMAP
{
    public uint dwFlags;
    public IntPtr hdc;
    public LPDIRECTDRAWSURFACE7 pDDS = new LPDIRECTDRAWSURFACE7();
    public RECT rSrc = new RECT();
    public _NORMALIZEDRECT rDest = new _NORMALIZEDRECT();
    public float fAlpha;
    public uint clrSrcKey;
}

#else // C style interface

    public class IVMRMixerBitmapVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRMixerBitmap * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRMixerBitmap This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRMixerBitmap * This);
        public delegate uint AddRefDelegate(@interface IVMRMixerBitmap This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRMixerBitmap * This);
        public delegate uint ReleaseDelegate(@interface IVMRMixerBitmap This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAlphaBitmap)(interface IVMRMixerBitmap * This, const _VMRALPHABITMAP *pBmpParms);
        public delegate int SetAlphaBitmapDelegate(@interface IVMRMixerBitmap This, _VMRALPHABITMAP pBmpParms);
        public SetAlphaBitmapDelegate SetAlphaBitmap;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UpdateAlphaBitmapParameters)(interface IVMRMixerBitmap * This, struct _VMRALPHABITMAP * pBmpParms);
        public delegate int UpdateAlphaBitmapParametersDelegate(@interface IVMRMixerBitmap This, _VMRALPHABITMAP pBmpParms);
        public UpdateAlphaBitmapParametersDelegate UpdateAlphaBitmapParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAlphaBitmapParameters)(interface IVMRMixerBitmap * This, struct _VMRALPHABITMAP * pBmpParms);
        public delegate int GetAlphaBitmapParametersDelegate(@interface IVMRMixerBitmap This, _VMRALPHABITMAP pBmpParms);
        public GetAlphaBitmapParametersDelegate GetAlphaBitmapParameters;

//        END_INTERFACE
    }





/* interface __MIDL_itf_strmif_0397 */
/* [local] */ 

public class _VMRVIDEOSTREAMINFO
{
    public LPDIRECTDRAWSURFACE7 pddsVideoSurface = new LPDIRECTDRAWSURFACE7();
    public uint dwWidth;
    public uint dwHeight;
    public uint dwStrmID;
    public float fAlpha;
    public DDCOLORKEY ddClrKey = new DDCOLORKEY();
    public _NORMALIZEDRECT rNormal = new _NORMALIZEDRECT();
}

#else // C style interface

    public class IVMRImageCompositorVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImageCompositor * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImageCompositor This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImageCompositor * This);
        public delegate uint AddRefDelegate(@interface IVMRImageCompositor This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImageCompositor * This);
        public delegate uint ReleaseDelegate(@interface IVMRImageCompositor This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitCompositionTarget)(interface IVMRImageCompositor * This, object* pD3DDevice, LPDIRECTDRAWSURFACE7 pddsRenderTarget);
        public delegate int InitCompositionTargetDelegate(@interface IVMRImageCompositor This, object pD3DDevice, LPDIRECTDRAWSURFACE7 pddsRenderTarget);
        public InitCompositionTargetDelegate InitCompositionTarget;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TermCompositionTarget)(interface IVMRImageCompositor * This, object* pD3DDevice, LPDIRECTDRAWSURFACE7 pddsRenderTarget);
        public delegate int TermCompositionTargetDelegate(@interface IVMRImageCompositor This, object pD3DDevice, LPDIRECTDRAWSURFACE7 pddsRenderTarget);
        public TermCompositionTargetDelegate TermCompositionTarget;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStreamMediaType)(interface IVMRImageCompositor * This, uint dwStrmID, _AMMediaType *pmt, bool fTexture);
        public delegate int SetStreamMediaTypeDelegate(@interface IVMRImageCompositor This, uint dwStrmID, _AMMediaType pmt, bool fTexture);
        public SetStreamMediaTypeDelegate SetStreamMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CompositeImage)(interface IVMRImageCompositor * This, object* pD3DDevice, LPDIRECTDRAWSURFACE7 pddsRenderTarget, _AMMediaType *pmtRenderTarget, long rtStart, long rtEnd, uint dwClrBkGnd, _VMRVIDEOSTREAMINFO *pVideoStreamInfo, uint cStreams);
        public delegate int CompositeImageDelegate(@interface IVMRImageCompositor This, object pD3DDevice, LPDIRECTDRAWSURFACE7 pddsRenderTarget, _AMMediaType pmtRenderTarget, long rtStart, long rtEnd, uint dwClrBkGnd, _VMRVIDEOSTREAMINFO pVideoStreamInfo, uint cStreams);
        public CompositeImageDelegate CompositeImage;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRVideoStreamControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRVideoStreamControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRVideoStreamControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRVideoStreamControl * This);
        public delegate uint AddRefDelegate(@interface IVMRVideoStreamControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRVideoStreamControl * This);
        public delegate uint ReleaseDelegate(@interface IVMRVideoStreamControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetColorKey)(interface IVMRVideoStreamControl * This, LPDDCOLORKEY lpClrKey);
        public delegate int SetColorKeyDelegate(@interface IVMRVideoStreamControl This, LPDDCOLORKEY lpClrKey);
        public SetColorKeyDelegate SetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetColorKey)(interface IVMRVideoStreamControl * This, LPDDCOLORKEY lpClrKey);
        public delegate int GetColorKeyDelegate(@interface IVMRVideoStreamControl This, LPDDCOLORKEY lpClrKey);
        public GetColorKeyDelegate GetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStreamActiveState)(interface IVMRVideoStreamControl * This, bool fActive);
        public delegate int SetStreamActiveStateDelegate(@interface IVMRVideoStreamControl This, bool fActive);
        public SetStreamActiveStateDelegate SetStreamActiveState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStreamActiveState)(interface IVMRVideoStreamControl * This, bool *lpfActive);
        public delegate int GetStreamActiveStateDelegate(@interface IVMRVideoStreamControl This, ref bool lpfActive);
        public GetStreamActiveStateDelegate GetStreamActiveState;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRSurfaceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRSurface * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRSurface This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRSurface * This);
        public delegate uint AddRefDelegate(@interface IVMRSurface This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRSurface * This);
        public delegate uint ReleaseDelegate(@interface IVMRSurface This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSurfaceLocked)(interface IVMRSurface * This);
        public delegate int IsSurfaceLockedDelegate(@interface IVMRSurface This);
        public IsSurfaceLockedDelegate IsSurfaceLocked;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LockSurface)(interface IVMRSurface * This, byte **lpSurface);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int LockSurfaceDelegate(@interface IVMRSurface This, byte[] lpSurface);
        public LockSurfaceDelegate LockSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnlockSurface)(interface IVMRSurface * This);
        public delegate int UnlockSurfaceDelegate(@interface IVMRSurface This);
        public UnlockSurfaceDelegate UnlockSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSurface)(interface IVMRSurface * This, LPDIRECTDRAWSURFACE7 *lplpSurface);
        public delegate int GetSurfaceDelegate(@interface IVMRSurface This, LPDIRECTDRAWSURFACE7 lplpSurface);
        public GetSurfaceDelegate GetSurface;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRImagePresenterConfigVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImagePresenterConfig * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImagePresenterConfig This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImagePresenterConfig * This);
        public delegate uint AddRefDelegate(@interface IVMRImagePresenterConfig This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImagePresenterConfig * This);
        public delegate uint ReleaseDelegate(@interface IVMRImagePresenterConfig This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingPrefs)(interface IVMRImagePresenterConfig * This, uint dwRenderFlags);
        public delegate int SetRenderingPrefsDelegate(@interface IVMRImagePresenterConfig This, uint dwRenderFlags);
        public SetRenderingPrefsDelegate SetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingPrefs)(interface IVMRImagePresenterConfig * This, uint *dwRenderFlags);
        public delegate int GetRenderingPrefsDelegate(@interface IVMRImagePresenterConfig This, ref uint dwRenderFlags);
        public GetRenderingPrefsDelegate GetRenderingPrefs;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRImagePresenterExclModeConfigVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImagePresenterExclModeConfig * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImagePresenterExclModeConfig This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImagePresenterExclModeConfig * This);
        public delegate uint AddRefDelegate(@interface IVMRImagePresenterExclModeConfig This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImagePresenterExclModeConfig * This);
        public delegate uint ReleaseDelegate(@interface IVMRImagePresenterExclModeConfig This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingPrefs)(interface IVMRImagePresenterExclModeConfig * This, uint dwRenderFlags);
        public delegate int SetRenderingPrefsDelegate(@interface IVMRImagePresenterExclModeConfig This, uint dwRenderFlags);
        public SetRenderingPrefsDelegate SetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingPrefs)(interface IVMRImagePresenterExclModeConfig * This, uint *dwRenderFlags);
        public delegate int GetRenderingPrefsDelegate(@interface IVMRImagePresenterExclModeConfig This, ref uint dwRenderFlags);
        public GetRenderingPrefsDelegate GetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetXlcModeDDObjAndPrimarySurface)(interface IVMRImagePresenterExclModeConfig * This, LPDIRECTDRAW7 lpDDObj, LPDIRECTDRAWSURFACE7 lpPrimarySurf);
        public delegate int SetXlcModeDDObjAndPrimarySurfaceDelegate(@interface IVMRImagePresenterExclModeConfig This, LPDIRECTDRAW7 lpDDObj, LPDIRECTDRAWSURFACE7 lpPrimarySurf);
        public SetXlcModeDDObjAndPrimarySurfaceDelegate SetXlcModeDDObjAndPrimarySurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetXlcModeDDObjAndPrimarySurface)(interface IVMRImagePresenterExclModeConfig * This, LPDIRECTDRAW7 *lpDDObj, LPDIRECTDRAWSURFACE7 *lpPrimarySurf);
        public delegate int GetXlcModeDDObjAndPrimarySurfaceDelegate(@interface IVMRImagePresenterExclModeConfig This, LPDIRECTDRAW7 lpDDObj, LPDIRECTDRAWSURFACE7 lpPrimarySurf);
        public GetXlcModeDDObjAndPrimarySurfaceDelegate GetXlcModeDDObjAndPrimarySurface;

//        END_INTERFACE
    }

#else // C style interface

    public class IVPManagerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVPManager * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVPManager This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVPManager * This);
        public delegate uint AddRefDelegate(@interface IVPManager This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVPManager * This);
        public delegate uint ReleaseDelegate(@interface IVPManager This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetVideoPortIndex)(interface IVPManager * This, uint dwVideoPortIndex);
        public delegate int SetVideoPortIndexDelegate(@interface IVPManager This, uint dwVideoPortIndex);
        public SetVideoPortIndexDelegate SetVideoPortIndex;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoPortIndex)(interface IVPManager * This, uint *pdwVideoPortIndex);
        public delegate int GetVideoPortIndexDelegate(@interface IVPManager This, ref uint pdwVideoPortIndex);
        public GetVideoPortIndexDelegate GetVideoPortIndex;

//        END_INTERFACE
    }