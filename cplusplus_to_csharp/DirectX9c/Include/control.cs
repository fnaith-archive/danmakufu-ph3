using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for control.odl:
    Oicf, W0, Zp8, env=Win32 (32b run)
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



// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER && (_MSC_VER >= 1020)
#endif

/* Forward Declarations */ 
























#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class FilgraphManager FilgraphManager;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct FilgraphManager FilgraphManager;
#endif // __cplusplus













#if __cplusplus
#endif

#else // C style interface

    public class IAMCollectionVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMCollection * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMCollection This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMCollection * This);
        public delegate uint AddRefDelegate(@interface IAMCollection This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMCollection * This);
        public delegate uint ReleaseDelegate(@interface IAMCollection This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IAMCollection * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IAMCollection This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IAMCollection * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IAMCollection This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IAMCollection * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IAMCollection This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IAMCollection * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IAMCollection This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IAMCollection * This, int *plCount);
        public delegate int get_CountDelegate(@interface IAMCollection This, ref int plCount);
        public get_CountDelegate get_Count;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Item)(interface IAMCollection * This, int lItem, IUnknown **ppUnk);
        public delegate int ItemDelegate(@interface IAMCollection This, int lItem, IUnknown[] ppUnk);
        public ItemDelegate Item;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get__NewEnum)(interface IAMCollection * This, IUnknown **ppUnk);
        public delegate int get__NewEnumDelegate(@interface IAMCollection This, IUnknown[] ppUnk);
        public get__NewEnumDelegate get__NewEnum;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaControlVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaControl * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaControl This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaControl * This);
        public delegate uint AddRefDelegate(@interface IMediaControl This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaControl * This);
        public delegate uint ReleaseDelegate(@interface IMediaControl This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMediaControl * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMediaControl This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMediaControl * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMediaControl This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMediaControl * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMediaControl This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMediaControl * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMediaControl This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Run)(interface IMediaControl * This);
        public delegate int RunDelegate(@interface IMediaControl This);
        public RunDelegate Run;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Pause)(interface IMediaControl * This);
        public delegate int PauseDelegate(@interface IMediaControl This);
        public PauseDelegate Pause;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface IMediaControl * This);
        public delegate int StopDelegate(@interface IMediaControl This);
        public StopDelegate Stop;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetState)(interface IMediaControl * This, int msTimeout, int *pfs);
        public delegate int GetStateDelegate(@interface IMediaControl This, int msTimeout, ref int pfs);
        public GetStateDelegate GetState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RenderFile)(interface IMediaControl * This, char* strFilename);
        public delegate int RenderFileDelegate(@interface IMediaControl This, ref string strFilename);
        public RenderFileDelegate RenderFile;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddSourceFilter)(interface IMediaControl * This, char* strFilename, IDispatch **ppUnk);
        public delegate int AddSourceFilterDelegate(@interface IMediaControl This, ref string strFilename, IDispatch[] ppUnk);
        public AddSourceFilterDelegate AddSourceFilter;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FilterCollection)(interface IMediaControl * This, IDispatch **ppUnk);
        public delegate int get_FilterCollectionDelegate(@interface IMediaControl This, IDispatch[] ppUnk);
        public get_FilterCollectionDelegate get_FilterCollection;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_RegFilterCollection)(interface IMediaControl * This, IDispatch **ppUnk);
        public delegate int get_RegFilterCollectionDelegate(@interface IMediaControl This, IDispatch[] ppUnk);
        public get_RegFilterCollectionDelegate get_RegFilterCollection;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StopWhenReady)(interface IMediaControl * This);
        public delegate int StopWhenReadyDelegate(@interface IMediaControl This);
        public StopWhenReadyDelegate StopWhenReady;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaEventVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaEvent * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaEvent This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaEvent * This);
        public delegate uint AddRefDelegate(@interface IMediaEvent This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaEvent * This);
        public delegate uint ReleaseDelegate(@interface IMediaEvent This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMediaEvent * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMediaEvent This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMediaEvent * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMediaEvent This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMediaEvent * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMediaEvent This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMediaEvent * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMediaEvent This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEventHandle)(interface IMediaEvent * This, System.IntPtr *hEvent);
        public delegate int GetEventHandleDelegate(@interface IMediaEvent This, IntPtr hEvent);
        public GetEventHandleDelegate GetEventHandle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEvent)(interface IMediaEvent * This, int *lEventCode, System.IntPtr *lParam1, System.IntPtr *lParam2, int msTimeout);
        public delegate int GetEventDelegate(@interface IMediaEvent This, ref int lEventCode, IntPtr lParam1, IntPtr lParam2, int msTimeout);
        public GetEventDelegate GetEvent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WaitForCompletion)(interface IMediaEvent * This, int msTimeout, int *pEvCode);
        public delegate int WaitForCompletionDelegate(@interface IMediaEvent This, int msTimeout, ref int pEvCode);
        public WaitForCompletionDelegate WaitForCompletion;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CancelDefaultHandling)(interface IMediaEvent * This, int lEvCode);
        public delegate int CancelDefaultHandlingDelegate(@interface IMediaEvent This, int lEvCode);
        public CancelDefaultHandlingDelegate CancelDefaultHandling;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RestoreDefaultHandling)(interface IMediaEvent * This, int lEvCode);
        public delegate int RestoreDefaultHandlingDelegate(@interface IMediaEvent This, int lEvCode);
        public RestoreDefaultHandlingDelegate RestoreDefaultHandling;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FreeEventParams)(interface IMediaEvent * This, int lEvCode, System.IntPtr lParam1, System.IntPtr lParam2);
        public delegate int FreeEventParamsDelegate(@interface IMediaEvent This, int lEvCode, IntPtr lParam1, IntPtr lParam2);
        public FreeEventParamsDelegate FreeEventParams;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaEventExVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaEventEx * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaEventEx This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaEventEx * This);
        public delegate uint AddRefDelegate(@interface IMediaEventEx This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaEventEx * This);
        public delegate uint ReleaseDelegate(@interface IMediaEventEx This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMediaEventEx * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMediaEventEx This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMediaEventEx * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMediaEventEx This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMediaEventEx * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMediaEventEx This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMediaEventEx * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMediaEventEx This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEventHandle)(interface IMediaEventEx * This, System.IntPtr *hEvent);
        public delegate int GetEventHandleDelegate(@interface IMediaEventEx This, IntPtr hEvent);
        public GetEventHandleDelegate GetEventHandle;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetEvent)(interface IMediaEventEx * This, int *lEventCode, System.IntPtr *lParam1, System.IntPtr *lParam2, int msTimeout);
        public delegate int GetEventDelegate(@interface IMediaEventEx This, ref int lEventCode, IntPtr lParam1, IntPtr lParam2, int msTimeout);
        public GetEventDelegate GetEvent;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *WaitForCompletion)(interface IMediaEventEx * This, int msTimeout, int *pEvCode);
        public delegate int WaitForCompletionDelegate(@interface IMediaEventEx This, int msTimeout, ref int pEvCode);
        public WaitForCompletionDelegate WaitForCompletion;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CancelDefaultHandling)(interface IMediaEventEx * This, int lEvCode);
        public delegate int CancelDefaultHandlingDelegate(@interface IMediaEventEx This, int lEvCode);
        public CancelDefaultHandlingDelegate CancelDefaultHandling;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RestoreDefaultHandling)(interface IMediaEventEx * This, int lEvCode);
        public delegate int RestoreDefaultHandlingDelegate(@interface IMediaEventEx This, int lEvCode);
        public RestoreDefaultHandlingDelegate RestoreDefaultHandling;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FreeEventParams)(interface IMediaEventEx * This, int lEvCode, System.IntPtr lParam1, System.IntPtr lParam2);
        public delegate int FreeEventParamsDelegate(@interface IMediaEventEx This, int lEvCode, IntPtr lParam1, IntPtr lParam2);
        public FreeEventParamsDelegate FreeEventParams;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetNotifyWindow)(interface IMediaEventEx * This, System.IntPtr hwnd, int lMsg, System.IntPtr lInstanceData);
        public delegate int SetNotifyWindowDelegate(@interface IMediaEventEx This, IntPtr hwnd, int lMsg, IntPtr lInstanceData);
        public SetNotifyWindowDelegate SetNotifyWindow;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetNotifyFlags)(interface IMediaEventEx * This, int lNoNotifyFlags);
        public delegate int SetNotifyFlagsDelegate(@interface IMediaEventEx This, int lNoNotifyFlags);
        public SetNotifyFlagsDelegate SetNotifyFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNotifyFlags)(interface IMediaEventEx * This, int *lplNoNotifyFlags);
        public delegate int GetNotifyFlagsDelegate(@interface IMediaEventEx This, ref int lplNoNotifyFlags);
        public GetNotifyFlagsDelegate GetNotifyFlags;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaPositionVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaPosition * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaPosition This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaPosition * This);
        public delegate uint AddRefDelegate(@interface IMediaPosition This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaPosition * This);
        public delegate uint ReleaseDelegate(@interface IMediaPosition This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMediaPosition * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMediaPosition This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMediaPosition * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMediaPosition This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMediaPosition * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMediaPosition This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMediaPosition * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMediaPosition This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Duration)(interface IMediaPosition * This, double *plength);
        public delegate int get_DurationDelegate(@interface IMediaPosition This, ref double plength);
        public get_DurationDelegate get_Duration;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_CurrentPosition)(interface IMediaPosition * This, double llTime);
        public delegate int put_CurrentPositionDelegate(@interface IMediaPosition This, double llTime);
        public put_CurrentPositionDelegate put_CurrentPosition;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_CurrentPosition)(interface IMediaPosition * This, double *pllTime);
        public delegate int get_CurrentPositionDelegate(@interface IMediaPosition This, ref double pllTime);
        public get_CurrentPositionDelegate get_CurrentPosition;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_StopTime)(interface IMediaPosition * This, double *pllTime);
        public delegate int get_StopTimeDelegate(@interface IMediaPosition This, ref double pllTime);
        public get_StopTimeDelegate get_StopTime;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_StopTime)(interface IMediaPosition * This, double llTime);
        public delegate int put_StopTimeDelegate(@interface IMediaPosition This, double llTime);
        public put_StopTimeDelegate put_StopTime;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PrerollTime)(interface IMediaPosition * This, double *pllTime);
        public delegate int get_PrerollTimeDelegate(@interface IMediaPosition This, ref double pllTime);
        public get_PrerollTimeDelegate get_PrerollTime;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_PrerollTime)(interface IMediaPosition * This, double llTime);
        public delegate int put_PrerollTimeDelegate(@interface IMediaPosition This, double llTime);
        public put_PrerollTimeDelegate put_PrerollTime;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Rate)(interface IMediaPosition * This, double dRate);
        public delegate int put_RateDelegate(@interface IMediaPosition This, double dRate);
        public put_RateDelegate put_Rate;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Rate)(interface IMediaPosition * This, double *pdRate);
        public delegate int get_RateDelegate(@interface IMediaPosition This, ref double pdRate);
        public get_RateDelegate get_Rate;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CanSeekForward)(interface IMediaPosition * This, int *pCanSeekForward);
        public delegate int CanSeekForwardDelegate(@interface IMediaPosition This, ref int pCanSeekForward);
        public CanSeekForwardDelegate CanSeekForward;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CanSeekBackward)(interface IMediaPosition * This, int *pCanSeekBackward);
        public delegate int CanSeekBackwardDelegate(@interface IMediaPosition This, ref int pCanSeekBackward);
        public CanSeekBackwardDelegate CanSeekBackward;

//        END_INTERFACE
    }

#else // C style interface

    public class IBasicAudioVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IBasicAudio * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IBasicAudio This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IBasicAudio * This);
        public delegate uint AddRefDelegate(@interface IBasicAudio This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IBasicAudio * This);
        public delegate uint ReleaseDelegate(@interface IBasicAudio This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IBasicAudio * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IBasicAudio This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IBasicAudio * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IBasicAudio This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IBasicAudio * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IBasicAudio This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IBasicAudio * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IBasicAudio This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Volume)(interface IBasicAudio * This, int lVolume);
        public delegate int put_VolumeDelegate(@interface IBasicAudio This, int lVolume);
        public put_VolumeDelegate put_Volume;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Volume)(interface IBasicAudio * This, int *plVolume);
        public delegate int get_VolumeDelegate(@interface IBasicAudio This, ref int plVolume);
        public get_VolumeDelegate get_Volume;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Balance)(interface IBasicAudio * This, int lBalance);
        public delegate int put_BalanceDelegate(@interface IBasicAudio This, int lBalance);
        public put_BalanceDelegate put_Balance;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Balance)(interface IBasicAudio * This, int *plBalance);
        public delegate int get_BalanceDelegate(@interface IBasicAudio This, ref int plBalance);
        public get_BalanceDelegate get_Balance;

//        END_INTERFACE
    }

#else // C style interface

    public class IVideoWindowVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVideoWindow * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVideoWindow This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVideoWindow * This);
        public delegate uint AddRefDelegate(@interface IVideoWindow This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVideoWindow * This);
        public delegate uint ReleaseDelegate(@interface IVideoWindow This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IVideoWindow * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IVideoWindow This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IVideoWindow * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IVideoWindow This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IVideoWindow * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IVideoWindow This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IVideoWindow * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IVideoWindow This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Caption)(interface IVideoWindow * This, char* strCaption);
        public delegate int put_CaptionDelegate(@interface IVideoWindow This, ref string strCaption);
        public put_CaptionDelegate put_Caption;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Caption)(interface IVideoWindow * This, char**strCaption);
        public delegate int get_CaptionDelegate(@interface IVideoWindow This, char * strCaption[] UnnamedParameter);
        public get_CaptionDelegate get_Caption;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_WindowStyle)(interface IVideoWindow * This, int WindowStyle);
        public delegate int put_WindowStyleDelegate(@interface IVideoWindow This, int WindowStyle);
        public put_WindowStyleDelegate put_WindowStyle;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_WindowStyle)(interface IVideoWindow * This, int *WindowStyle);
        public delegate int get_WindowStyleDelegate(@interface IVideoWindow This, ref int WindowStyle);
        public get_WindowStyleDelegate get_WindowStyle;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_WindowStyleEx)(interface IVideoWindow * This, int WindowStyleEx);
        public delegate int put_WindowStyleExDelegate(@interface IVideoWindow This, int WindowStyleEx);
        public put_WindowStyleExDelegate put_WindowStyleEx;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_WindowStyleEx)(interface IVideoWindow * This, int *WindowStyleEx);
        public delegate int get_WindowStyleExDelegate(@interface IVideoWindow This, ref int WindowStyleEx);
        public get_WindowStyleExDelegate get_WindowStyleEx;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_AutoShow)(interface IVideoWindow * This, int AutoShow);
        public delegate int put_AutoShowDelegate(@interface IVideoWindow This, int AutoShow);
        public put_AutoShowDelegate put_AutoShow;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AutoShow)(interface IVideoWindow * This, int *AutoShow);
        public delegate int get_AutoShowDelegate(@interface IVideoWindow This, ref int AutoShow);
        public get_AutoShowDelegate get_AutoShow;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_WindowState)(interface IVideoWindow * This, int WindowState);
        public delegate int put_WindowStateDelegate(@interface IVideoWindow This, int WindowState);
        public put_WindowStateDelegate put_WindowState;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_WindowState)(interface IVideoWindow * This, int *WindowState);
        public delegate int get_WindowStateDelegate(@interface IVideoWindow This, ref int WindowState);
        public get_WindowStateDelegate get_WindowState;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BackgroundPalette)(interface IVideoWindow * This, int BackgroundPalette);
        public delegate int put_BackgroundPaletteDelegate(@interface IVideoWindow This, int BackgroundPalette);
        public put_BackgroundPaletteDelegate put_BackgroundPalette;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BackgroundPalette)(interface IVideoWindow * This, int *pBackgroundPalette);
        public delegate int get_BackgroundPaletteDelegate(@interface IVideoWindow This, ref int pBackgroundPalette);
        public get_BackgroundPaletteDelegate get_BackgroundPalette;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Visible)(interface IVideoWindow * This, int Visible);
        public delegate int put_VisibleDelegate(@interface IVideoWindow This, int Visible);
        public put_VisibleDelegate put_Visible;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Visible)(interface IVideoWindow * This, int *pVisible);
        public delegate int get_VisibleDelegate(@interface IVideoWindow This, ref int pVisible);
        public get_VisibleDelegate get_Visible;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Left)(interface IVideoWindow * This, int Left);
        public delegate int put_LeftDelegate(@interface IVideoWindow This, int Left);
        public put_LeftDelegate put_Left;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Left)(interface IVideoWindow * This, int *pLeft);
        public delegate int get_LeftDelegate(@interface IVideoWindow This, ref int pLeft);
        public get_LeftDelegate get_Left;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Width)(interface IVideoWindow * This, int Width);
        public delegate int put_WidthDelegate(@interface IVideoWindow This, int Width);
        public put_WidthDelegate put_Width;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Width)(interface IVideoWindow * This, int *pWidth);
        public delegate int get_WidthDelegate(@interface IVideoWindow This, ref int pWidth);
        public get_WidthDelegate get_Width;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Top)(interface IVideoWindow * This, int Top);
        public delegate int put_TopDelegate(@interface IVideoWindow This, int Top);
        public put_TopDelegate put_Top;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Top)(interface IVideoWindow * This, int *pTop);
        public delegate int get_TopDelegate(@interface IVideoWindow This, ref int pTop);
        public get_TopDelegate get_Top;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Height)(interface IVideoWindow * This, int Height);
        public delegate int put_HeightDelegate(@interface IVideoWindow This, int Height);
        public put_HeightDelegate put_Height;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Height)(interface IVideoWindow * This, int *pHeight);
        public delegate int get_HeightDelegate(@interface IVideoWindow This, ref int pHeight);
        public get_HeightDelegate get_Height;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Owner)(interface IVideoWindow * This, System.IntPtr Owner);
        public delegate int put_OwnerDelegate(@interface IVideoWindow This, IntPtr Owner);
        public put_OwnerDelegate put_Owner;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Owner)(interface IVideoWindow * This, System.IntPtr *Owner);
        public delegate int get_OwnerDelegate(@interface IVideoWindow This, IntPtr Owner);
        public get_OwnerDelegate get_Owner;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_MessageDrain)(interface IVideoWindow * This, System.IntPtr Drain);
        public delegate int put_MessageDrainDelegate(@interface IVideoWindow This, IntPtr Drain);
        public put_MessageDrainDelegate put_MessageDrain;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MessageDrain)(interface IVideoWindow * This, System.IntPtr *Drain);
        public delegate int get_MessageDrainDelegate(@interface IVideoWindow This, IntPtr Drain);
        public get_MessageDrainDelegate get_MessageDrain;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BorderColor)(interface IVideoWindow * This, int *Color);
        public delegate int get_BorderColorDelegate(@interface IVideoWindow This, ref int Color);
        public get_BorderColorDelegate get_BorderColor;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_BorderColor)(interface IVideoWindow * This, int Color);
        public delegate int put_BorderColorDelegate(@interface IVideoWindow This, int Color);
        public put_BorderColorDelegate put_BorderColor;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FullScreenMode)(interface IVideoWindow * This, int *FullScreenMode);
        public delegate int get_FullScreenModeDelegate(@interface IVideoWindow This, ref int FullScreenMode);
        public get_FullScreenModeDelegate get_FullScreenMode;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_FullScreenMode)(interface IVideoWindow * This, int FullScreenMode);
        public delegate int put_FullScreenModeDelegate(@interface IVideoWindow This, int FullScreenMode);
        public put_FullScreenModeDelegate put_FullScreenMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetWindowForeground)(interface IVideoWindow * This, int Focus);
        public delegate int SetWindowForegroundDelegate(@interface IVideoWindow This, int Focus);
        public SetWindowForegroundDelegate SetWindowForeground;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyOwnerMessage)(interface IVideoWindow * This, System.IntPtr hwnd, int uMsg, System.IntPtr wParam, System.IntPtr lParam);
        public delegate int NotifyOwnerMessageDelegate(@interface IVideoWindow This, IntPtr hwnd, int uMsg, IntPtr wParam, IntPtr lParam);
        public NotifyOwnerMessageDelegate NotifyOwnerMessage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetWindowPosition)(interface IVideoWindow * This, int Left, int Top, int Width, int Height);
        public delegate int SetWindowPositionDelegate(@interface IVideoWindow This, int Left, int Top, int Width, int Height);
        public SetWindowPositionDelegate SetWindowPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetWindowPosition)(interface IVideoWindow * This, int *pLeft, int *pTop, int *pWidth, int *pHeight);
        public delegate int GetWindowPositionDelegate(@interface IVideoWindow This, ref int pLeft, ref int pTop, ref int pWidth, ref int pHeight);
        public GetWindowPositionDelegate GetWindowPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMinIdealImageSize)(interface IVideoWindow * This, int *pWidth, int *pHeight);
        public delegate int GetMinIdealImageSizeDelegate(@interface IVideoWindow This, ref int pWidth, ref int pHeight);
        public GetMinIdealImageSizeDelegate GetMinIdealImageSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMaxIdealImageSize)(interface IVideoWindow * This, int *pWidth, int *pHeight);
        public delegate int GetMaxIdealImageSizeDelegate(@interface IVideoWindow This, ref int pWidth, ref int pHeight);
        public GetMaxIdealImageSizeDelegate GetMaxIdealImageSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRestorePosition)(interface IVideoWindow * This, int *pLeft, int *pTop, int *pWidth, int *pHeight);
        public delegate int GetRestorePositionDelegate(@interface IVideoWindow This, ref int pLeft, ref int pTop, ref int pWidth, ref int pHeight);
        public GetRestorePositionDelegate GetRestorePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *HideCursor)(interface IVideoWindow * This, int HideCursor);
        public delegate int HideCursorDelegate(@interface IVideoWindow This, int HideCursor);
        public HideCursorDelegate HideCursor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsCursorHidden)(interface IVideoWindow * This, int *CursorHidden);
        public delegate int IsCursorHiddenDelegate(@interface IVideoWindow This, ref int CursorHidden);
        public IsCursorHiddenDelegate IsCursorHidden;

//        END_INTERFACE
    }

#else // C style interface

    public class IBasicVideoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IBasicVideo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IBasicVideo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IBasicVideo * This);
        public delegate uint AddRefDelegate(@interface IBasicVideo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IBasicVideo * This);
        public delegate uint ReleaseDelegate(@interface IBasicVideo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IBasicVideo * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IBasicVideo This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IBasicVideo * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IBasicVideo This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IBasicVideo * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IBasicVideo This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IBasicVideo * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IBasicVideo This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvgTimePerFrame)(interface IBasicVideo * This, double *pAvgTimePerFrame);
        public delegate int get_AvgTimePerFrameDelegate(@interface IBasicVideo This, ref double pAvgTimePerFrame);
        public get_AvgTimePerFrameDelegate get_AvgTimePerFrame;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BitRate)(interface IBasicVideo * This, int *pBitRate);
        public delegate int get_BitRateDelegate(@interface IBasicVideo This, ref int pBitRate);
        public get_BitRateDelegate get_BitRate;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BitErrorRate)(interface IBasicVideo * This, int *pBitErrorRate);
        public delegate int get_BitErrorRateDelegate(@interface IBasicVideo This, ref int pBitErrorRate);
        public get_BitErrorRateDelegate get_BitErrorRate;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoWidth)(interface IBasicVideo * This, int *pVideoWidth);
        public delegate int get_VideoWidthDelegate(@interface IBasicVideo This, ref int pVideoWidth);
        public get_VideoWidthDelegate get_VideoWidth;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoHeight)(interface IBasicVideo * This, int *pVideoHeight);
        public delegate int get_VideoHeightDelegate(@interface IBasicVideo This, ref int pVideoHeight);
        public get_VideoHeightDelegate get_VideoHeight;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceLeft)(interface IBasicVideo * This, int SourceLeft);
        public delegate int put_SourceLeftDelegate(@interface IBasicVideo This, int SourceLeft);
        public put_SourceLeftDelegate put_SourceLeft;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceLeft)(interface IBasicVideo * This, int *pSourceLeft);
        public delegate int get_SourceLeftDelegate(@interface IBasicVideo This, ref int pSourceLeft);
        public get_SourceLeftDelegate get_SourceLeft;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceWidth)(interface IBasicVideo * This, int SourceWidth);
        public delegate int put_SourceWidthDelegate(@interface IBasicVideo This, int SourceWidth);
        public put_SourceWidthDelegate put_SourceWidth;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceWidth)(interface IBasicVideo * This, int *pSourceWidth);
        public delegate int get_SourceWidthDelegate(@interface IBasicVideo This, ref int pSourceWidth);
        public get_SourceWidthDelegate get_SourceWidth;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceTop)(interface IBasicVideo * This, int SourceTop);
        public delegate int put_SourceTopDelegate(@interface IBasicVideo This, int SourceTop);
        public put_SourceTopDelegate put_SourceTop;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceTop)(interface IBasicVideo * This, int *pSourceTop);
        public delegate int get_SourceTopDelegate(@interface IBasicVideo This, ref int pSourceTop);
        public get_SourceTopDelegate get_SourceTop;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceHeight)(interface IBasicVideo * This, int SourceHeight);
        public delegate int put_SourceHeightDelegate(@interface IBasicVideo This, int SourceHeight);
        public put_SourceHeightDelegate put_SourceHeight;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceHeight)(interface IBasicVideo * This, int *pSourceHeight);
        public delegate int get_SourceHeightDelegate(@interface IBasicVideo This, ref int pSourceHeight);
        public get_SourceHeightDelegate get_SourceHeight;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationLeft)(interface IBasicVideo * This, int DestinationLeft);
        public delegate int put_DestinationLeftDelegate(@interface IBasicVideo This, int DestinationLeft);
        public put_DestinationLeftDelegate put_DestinationLeft;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationLeft)(interface IBasicVideo * This, int *pDestinationLeft);
        public delegate int get_DestinationLeftDelegate(@interface IBasicVideo This, ref int pDestinationLeft);
        public get_DestinationLeftDelegate get_DestinationLeft;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationWidth)(interface IBasicVideo * This, int DestinationWidth);
        public delegate int put_DestinationWidthDelegate(@interface IBasicVideo This, int DestinationWidth);
        public put_DestinationWidthDelegate put_DestinationWidth;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationWidth)(interface IBasicVideo * This, int *pDestinationWidth);
        public delegate int get_DestinationWidthDelegate(@interface IBasicVideo This, ref int pDestinationWidth);
        public get_DestinationWidthDelegate get_DestinationWidth;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationTop)(interface IBasicVideo * This, int DestinationTop);
        public delegate int put_DestinationTopDelegate(@interface IBasicVideo This, int DestinationTop);
        public put_DestinationTopDelegate put_DestinationTop;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationTop)(interface IBasicVideo * This, int *pDestinationTop);
        public delegate int get_DestinationTopDelegate(@interface IBasicVideo This, ref int pDestinationTop);
        public get_DestinationTopDelegate get_DestinationTop;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationHeight)(interface IBasicVideo * This, int DestinationHeight);
        public delegate int put_DestinationHeightDelegate(@interface IBasicVideo This, int DestinationHeight);
        public put_DestinationHeightDelegate put_DestinationHeight;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationHeight)(interface IBasicVideo * This, int *pDestinationHeight);
        public delegate int get_DestinationHeightDelegate(@interface IBasicVideo This, ref int pDestinationHeight);
        public get_DestinationHeightDelegate get_DestinationHeight;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSourcePosition)(interface IBasicVideo * This, int Left, int Top, int Width, int Height);
        public delegate int SetSourcePositionDelegate(@interface IBasicVideo This, int Left, int Top, int Width, int Height);
        public SetSourcePositionDelegate SetSourcePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSourcePosition)(interface IBasicVideo * This, int *pLeft, int *pTop, int *pWidth, int *pHeight);
        public delegate int GetSourcePositionDelegate(@interface IBasicVideo This, ref int pLeft, ref int pTop, ref int pWidth, ref int pHeight);
        public GetSourcePositionDelegate GetSourcePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultSourcePosition)(interface IBasicVideo * This);
        public delegate int SetDefaultSourcePositionDelegate(@interface IBasicVideo This);
        public SetDefaultSourcePositionDelegate SetDefaultSourcePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDestinationPosition)(interface IBasicVideo * This, int Left, int Top, int Width, int Height);
        public delegate int SetDestinationPositionDelegate(@interface IBasicVideo This, int Left, int Top, int Width, int Height);
        public SetDestinationPositionDelegate SetDestinationPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDestinationPosition)(interface IBasicVideo * This, int *pLeft, int *pTop, int *pWidth, int *pHeight);
        public delegate int GetDestinationPositionDelegate(@interface IBasicVideo This, ref int pLeft, ref int pTop, ref int pWidth, ref int pHeight);
        public GetDestinationPositionDelegate GetDestinationPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultDestinationPosition)(interface IBasicVideo * This);
        public delegate int SetDefaultDestinationPositionDelegate(@interface IBasicVideo This);
        public SetDefaultDestinationPositionDelegate SetDefaultDestinationPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoSize)(interface IBasicVideo * This, int *pWidth, int *pHeight);
        public delegate int GetVideoSizeDelegate(@interface IBasicVideo This, ref int pWidth, ref int pHeight);
        public GetVideoSizeDelegate GetVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoPaletteEntries)(interface IBasicVideo * This, int StartIndex, int Entries, int *pRetrieved, int *pPalette);
        public delegate int GetVideoPaletteEntriesDelegate(@interface IBasicVideo This, int StartIndex, int Entries, ref int pRetrieved, ref int pPalette);
        public GetVideoPaletteEntriesDelegate GetVideoPaletteEntries;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentImage)(interface IBasicVideo * This, int *pBufferSize, int *pDIBImage);
        public delegate int GetCurrentImageDelegate(@interface IBasicVideo This, ref int pBufferSize, ref int pDIBImage);
        public GetCurrentImageDelegate GetCurrentImage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsUsingDefaultSource)(interface IBasicVideo * This);
        public delegate int IsUsingDefaultSourceDelegate(@interface IBasicVideo This);
        public IsUsingDefaultSourceDelegate IsUsingDefaultSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsUsingDefaultDestination)(interface IBasicVideo * This);
        public delegate int IsUsingDefaultDestinationDelegate(@interface IBasicVideo This);
        public IsUsingDefaultDestinationDelegate IsUsingDefaultDestination;

//        END_INTERFACE
    }

#else // C style interface

    public class IBasicVideo2Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IBasicVideo2 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IBasicVideo2 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IBasicVideo2 * This);
        public delegate uint AddRefDelegate(@interface IBasicVideo2 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IBasicVideo2 * This);
        public delegate uint ReleaseDelegate(@interface IBasicVideo2 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IBasicVideo2 * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IBasicVideo2 This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IBasicVideo2 * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IBasicVideo2 This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IBasicVideo2 * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IBasicVideo2 This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IBasicVideo2 * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IBasicVideo2 This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_AvgTimePerFrame)(interface IBasicVideo2 * This, double *pAvgTimePerFrame);
        public delegate int get_AvgTimePerFrameDelegate(@interface IBasicVideo2 This, ref double pAvgTimePerFrame);
        public get_AvgTimePerFrameDelegate get_AvgTimePerFrame;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BitRate)(interface IBasicVideo2 * This, int *pBitRate);
        public delegate int get_BitRateDelegate(@interface IBasicVideo2 This, ref int pBitRate);
        public get_BitRateDelegate get_BitRate;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_BitErrorRate)(interface IBasicVideo2 * This, int *pBitErrorRate);
        public delegate int get_BitErrorRateDelegate(@interface IBasicVideo2 This, ref int pBitErrorRate);
        public get_BitErrorRateDelegate get_BitErrorRate;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoWidth)(interface IBasicVideo2 * This, int *pVideoWidth);
        public delegate int get_VideoWidthDelegate(@interface IBasicVideo2 This, ref int pVideoWidth);
        public get_VideoWidthDelegate get_VideoWidth;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VideoHeight)(interface IBasicVideo2 * This, int *pVideoHeight);
        public delegate int get_VideoHeightDelegate(@interface IBasicVideo2 This, ref int pVideoHeight);
        public get_VideoHeightDelegate get_VideoHeight;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceLeft)(interface IBasicVideo2 * This, int SourceLeft);
        public delegate int put_SourceLeftDelegate(@interface IBasicVideo2 This, int SourceLeft);
        public put_SourceLeftDelegate put_SourceLeft;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceLeft)(interface IBasicVideo2 * This, int *pSourceLeft);
        public delegate int get_SourceLeftDelegate(@interface IBasicVideo2 This, ref int pSourceLeft);
        public get_SourceLeftDelegate get_SourceLeft;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceWidth)(interface IBasicVideo2 * This, int SourceWidth);
        public delegate int put_SourceWidthDelegate(@interface IBasicVideo2 This, int SourceWidth);
        public put_SourceWidthDelegate put_SourceWidth;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceWidth)(interface IBasicVideo2 * This, int *pSourceWidth);
        public delegate int get_SourceWidthDelegate(@interface IBasicVideo2 This, ref int pSourceWidth);
        public get_SourceWidthDelegate get_SourceWidth;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceTop)(interface IBasicVideo2 * This, int SourceTop);
        public delegate int put_SourceTopDelegate(@interface IBasicVideo2 This, int SourceTop);
        public put_SourceTopDelegate put_SourceTop;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceTop)(interface IBasicVideo2 * This, int *pSourceTop);
        public delegate int get_SourceTopDelegate(@interface IBasicVideo2 This, ref int pSourceTop);
        public get_SourceTopDelegate get_SourceTop;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_SourceHeight)(interface IBasicVideo2 * This, int SourceHeight);
        public delegate int put_SourceHeightDelegate(@interface IBasicVideo2 This, int SourceHeight);
        public put_SourceHeightDelegate put_SourceHeight;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_SourceHeight)(interface IBasicVideo2 * This, int *pSourceHeight);
        public delegate int get_SourceHeightDelegate(@interface IBasicVideo2 This, ref int pSourceHeight);
        public get_SourceHeightDelegate get_SourceHeight;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationLeft)(interface IBasicVideo2 * This, int DestinationLeft);
        public delegate int put_DestinationLeftDelegate(@interface IBasicVideo2 This, int DestinationLeft);
        public put_DestinationLeftDelegate put_DestinationLeft;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationLeft)(interface IBasicVideo2 * This, int *pDestinationLeft);
        public delegate int get_DestinationLeftDelegate(@interface IBasicVideo2 This, ref int pDestinationLeft);
        public get_DestinationLeftDelegate get_DestinationLeft;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationWidth)(interface IBasicVideo2 * This, int DestinationWidth);
        public delegate int put_DestinationWidthDelegate(@interface IBasicVideo2 This, int DestinationWidth);
        public put_DestinationWidthDelegate put_DestinationWidth;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationWidth)(interface IBasicVideo2 * This, int *pDestinationWidth);
        public delegate int get_DestinationWidthDelegate(@interface IBasicVideo2 This, ref int pDestinationWidth);
        public get_DestinationWidthDelegate get_DestinationWidth;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationTop)(interface IBasicVideo2 * This, int DestinationTop);
        public delegate int put_DestinationTopDelegate(@interface IBasicVideo2 This, int DestinationTop);
        public put_DestinationTopDelegate put_DestinationTop;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationTop)(interface IBasicVideo2 * This, int *pDestinationTop);
        public delegate int get_DestinationTopDelegate(@interface IBasicVideo2 This, ref int pDestinationTop);
        public get_DestinationTopDelegate get_DestinationTop;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_DestinationHeight)(interface IBasicVideo2 * This, int DestinationHeight);
        public delegate int put_DestinationHeightDelegate(@interface IBasicVideo2 This, int DestinationHeight);
        public put_DestinationHeightDelegate put_DestinationHeight;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_DestinationHeight)(interface IBasicVideo2 * This, int *pDestinationHeight);
        public delegate int get_DestinationHeightDelegate(@interface IBasicVideo2 This, ref int pDestinationHeight);
        public get_DestinationHeightDelegate get_DestinationHeight;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetSourcePosition)(interface IBasicVideo2 * This, int Left, int Top, int Width, int Height);
        public delegate int SetSourcePositionDelegate(@interface IBasicVideo2 This, int Left, int Top, int Width, int Height);
        public SetSourcePositionDelegate SetSourcePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSourcePosition)(interface IBasicVideo2 * This, int *pLeft, int *pTop, int *pWidth, int *pHeight);
        public delegate int GetSourcePositionDelegate(@interface IBasicVideo2 This, ref int pLeft, ref int pTop, ref int pWidth, ref int pHeight);
        public GetSourcePositionDelegate GetSourcePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultSourcePosition)(interface IBasicVideo2 * This);
        public delegate int SetDefaultSourcePositionDelegate(@interface IBasicVideo2 This);
        public SetDefaultSourcePositionDelegate SetDefaultSourcePosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDestinationPosition)(interface IBasicVideo2 * This, int Left, int Top, int Width, int Height);
        public delegate int SetDestinationPositionDelegate(@interface IBasicVideo2 This, int Left, int Top, int Width, int Height);
        public SetDestinationPositionDelegate SetDestinationPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDestinationPosition)(interface IBasicVideo2 * This, int *pLeft, int *pTop, int *pWidth, int *pHeight);
        public delegate int GetDestinationPositionDelegate(@interface IBasicVideo2 This, ref int pLeft, ref int pTop, ref int pWidth, ref int pHeight);
        public GetDestinationPositionDelegate GetDestinationPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultDestinationPosition)(interface IBasicVideo2 * This);
        public delegate int SetDefaultDestinationPositionDelegate(@interface IBasicVideo2 This);
        public SetDefaultDestinationPositionDelegate SetDefaultDestinationPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoSize)(interface IBasicVideo2 * This, int *pWidth, int *pHeight);
        public delegate int GetVideoSizeDelegate(@interface IBasicVideo2 This, ref int pWidth, ref int pHeight);
        public GetVideoSizeDelegate GetVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoPaletteEntries)(interface IBasicVideo2 * This, int StartIndex, int Entries, int *pRetrieved, int *pPalette);
        public delegate int GetVideoPaletteEntriesDelegate(@interface IBasicVideo2 This, int StartIndex, int Entries, ref int pRetrieved, ref int pPalette);
        public GetVideoPaletteEntriesDelegate GetVideoPaletteEntries;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentImage)(interface IBasicVideo2 * This, int *pBufferSize, int *pDIBImage);
        public delegate int GetCurrentImageDelegate(@interface IBasicVideo2 This, ref int pBufferSize, ref int pDIBImage);
        public GetCurrentImageDelegate GetCurrentImage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsUsingDefaultSource)(interface IBasicVideo2 * This);
        public delegate int IsUsingDefaultSourceDelegate(@interface IBasicVideo2 This);
        public IsUsingDefaultSourceDelegate IsUsingDefaultSource;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsUsingDefaultDestination)(interface IBasicVideo2 * This);
        public delegate int IsUsingDefaultDestinationDelegate(@interface IBasicVideo2 This);
        public IsUsingDefaultDestinationDelegate IsUsingDefaultDestination;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPreferredAspectRatio)(interface IBasicVideo2 * This, int *plAspectX, int *plAspectY);
        public delegate int GetPreferredAspectRatioDelegate(@interface IBasicVideo2 This, ref int plAspectX, ref int plAspectY);
        public GetPreferredAspectRatioDelegate GetPreferredAspectRatio;

//        END_INTERFACE
    }

#else // C style interface

    public class IDeferredCommandVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDeferredCommand * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDeferredCommand This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDeferredCommand * This);
        public delegate uint AddRefDelegate(@interface IDeferredCommand This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDeferredCommand * This);
        public delegate uint ReleaseDelegate(@interface IDeferredCommand This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Cancel)(interface IDeferredCommand * This);
        public delegate int CancelDelegate(@interface IDeferredCommand This);
        public CancelDelegate Cancel;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Confidence)(interface IDeferredCommand * This, int *pConfidence);
        public delegate int ConfidenceDelegate(@interface IDeferredCommand This, ref int pConfidence);
        public ConfidenceDelegate Confidence;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Postpone)(interface IDeferredCommand * This, double newtime);
        public delegate int PostponeDelegate(@interface IDeferredCommand This, double newtime);
        public PostponeDelegate Postpone;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetHResult)(interface IDeferredCommand * This, int *phrResult);
        public delegate int GetHResultDelegate(@interface IDeferredCommand This, ref int phrResult);
        public GetHResultDelegate GetHResult;

//        END_INTERFACE
    }

#else // C style interface

    public class IQueueCommandVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IQueueCommand * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IQueueCommand This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IQueueCommand * This);
        public delegate uint AddRefDelegate(@interface IQueueCommand This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IQueueCommand * This);
        public delegate uint ReleaseDelegate(@interface IQueueCommand This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InvokeAtStreamTime)(interface IQueueCommand * This, interface IDeferredCommand **pCmd, double time, GUID *iid, int dispidMethod, short wFlags, int cArgs, VARIANT *pDispParams, VARIANT *pvarResult, short *puArgErr);
        public delegate int InvokeAtStreamTimeDelegate(@interface IQueueCommand This, @interface IDeferredCommand[] pCmd, double time, GUID iid, int dispidMethod, short wFlags, int cArgs, VARIANT pDispParams, VARIANT pvarResult, ref short puArgErr);
        public InvokeAtStreamTimeDelegate InvokeAtStreamTime;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InvokeAtPresentationTime)(interface IQueueCommand * This, interface IDeferredCommand **pCmd, double time, GUID *iid, int dispidMethod, short wFlags, int cArgs, VARIANT *pDispParams, VARIANT *pvarResult, short *puArgErr);
        public delegate int InvokeAtPresentationTimeDelegate(@interface IQueueCommand This, @interface IDeferredCommand[] pCmd, double time, GUID iid, int dispidMethod, short wFlags, int cArgs, VARIANT pDispParams, VARIANT pvarResult, ref short puArgErr);
        public InvokeAtPresentationTimeDelegate InvokeAtPresentationTime;

//        END_INTERFACE
    }

#else // C style interface

    public class IFilterInfoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IFilterInfo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IFilterInfo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IFilterInfo * This);
        public delegate uint AddRefDelegate(@interface IFilterInfo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IFilterInfo * This);
        public delegate uint ReleaseDelegate(@interface IFilterInfo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IFilterInfo * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IFilterInfo This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IFilterInfo * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IFilterInfo This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IFilterInfo * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IFilterInfo This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IFilterInfo * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IFilterInfo This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *FindPin)(interface IFilterInfo * This, char* strPinID, IDispatch **ppUnk);
        public delegate int FindPinDelegate(@interface IFilterInfo This, ref string strPinID, IDispatch[] ppUnk);
        public FindPinDelegate FindPin;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IFilterInfo * This, char**strName);
        public delegate int get_NameDelegate(@interface IFilterInfo This, char * strName[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_VendorInfo)(interface IFilterInfo * This, char**strVendorInfo);
        public delegate int get_VendorInfoDelegate(@interface IFilterInfo This, char * strVendorInfo[] UnnamedParameter);
        public get_VendorInfoDelegate get_VendorInfo;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Filter)(interface IFilterInfo * This, IUnknown **ppUnk);
        public delegate int get_FilterDelegate(@interface IFilterInfo This, IUnknown[] ppUnk);
        public get_FilterDelegate get_Filter;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Pins)(interface IFilterInfo * This, IDispatch **ppUnk);
        public delegate int get_PinsDelegate(@interface IFilterInfo This, IDispatch[] ppUnk);
        public get_PinsDelegate get_Pins;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_IsFileSource)(interface IFilterInfo * This, int *pbIsSource);
        public delegate int get_IsFileSourceDelegate(@interface IFilterInfo This, ref int pbIsSource);
        public get_IsFileSourceDelegate get_IsFileSource;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Filename)(interface IFilterInfo * This, char**pstrFilename);
        public delegate int get_FilenameDelegate(@interface IFilterInfo This, char * pstrFilename[] UnnamedParameter);
        public get_FilenameDelegate get_Filename;

        /* [propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Filename)(interface IFilterInfo * This, char* strFilename);
        public delegate int put_FilenameDelegate(@interface IFilterInfo This, ref string strFilename);
        public put_FilenameDelegate put_Filename;

//        END_INTERFACE
    }

#else // C style interface

    public class IRegFilterInfoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IRegFilterInfo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IRegFilterInfo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IRegFilterInfo * This);
        public delegate uint AddRefDelegate(@interface IRegFilterInfo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IRegFilterInfo * This);
        public delegate uint ReleaseDelegate(@interface IRegFilterInfo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IRegFilterInfo * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IRegFilterInfo This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IRegFilterInfo * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IRegFilterInfo This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IRegFilterInfo * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IRegFilterInfo This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IRegFilterInfo * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IRegFilterInfo This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IRegFilterInfo * This, char**strName);
        public delegate int get_NameDelegate(@interface IRegFilterInfo This, char * strName[] UnnamedParameter);
        public get_NameDelegate get_Name;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Filter)(interface IRegFilterInfo * This, IDispatch **ppUnk);
        public delegate int FilterDelegate(@interface IRegFilterInfo This, IDispatch[] ppUnk);
        public FilterDelegate Filter;

//        END_INTERFACE
    }

#else // C style interface

    public class IMediaTypeInfoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMediaTypeInfo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMediaTypeInfo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMediaTypeInfo * This);
        public delegate uint AddRefDelegate(@interface IMediaTypeInfo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMediaTypeInfo * This);
        public delegate uint ReleaseDelegate(@interface IMediaTypeInfo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IMediaTypeInfo * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IMediaTypeInfo This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IMediaTypeInfo * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IMediaTypeInfo This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IMediaTypeInfo * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IMediaTypeInfo This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IMediaTypeInfo * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IMediaTypeInfo This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Type)(interface IMediaTypeInfo * This, char**strType);
        public delegate int get_TypeDelegate(@interface IMediaTypeInfo This, char * strType[] UnnamedParameter);
        public get_TypeDelegate get_Type;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Subtype)(interface IMediaTypeInfo * This, char**strType);
        public delegate int get_SubtypeDelegate(@interface IMediaTypeInfo This, char * strType[] UnnamedParameter);
        public get_SubtypeDelegate get_Subtype;

//        END_INTERFACE
    }

#else // C style interface

    public class IPinInfoVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IPinInfo * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IPinInfo This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IPinInfo * This);
        public delegate uint AddRefDelegate(@interface IPinInfo This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IPinInfo * This);
        public delegate uint ReleaseDelegate(@interface IPinInfo This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IPinInfo * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IPinInfo This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IPinInfo * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IPinInfo This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IPinInfo * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IPinInfo This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IPinInfo * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IPinInfo This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Pin)(interface IPinInfo * This, IUnknown **ppUnk);
        public delegate int get_PinDelegate(@interface IPinInfo This, IUnknown[] ppUnk);
        public get_PinDelegate get_Pin;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ConnectedTo)(interface IPinInfo * This, IDispatch **ppUnk);
        public delegate int get_ConnectedToDelegate(@interface IPinInfo This, IDispatch[] ppUnk);
        public get_ConnectedToDelegate get_ConnectedTo;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_ConnectionMediaType)(interface IPinInfo * This, IDispatch **ppUnk);
        public delegate int get_ConnectionMediaTypeDelegate(@interface IPinInfo This, IDispatch[] ppUnk);
        public get_ConnectionMediaTypeDelegate get_ConnectionMediaType;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_FilterInfo)(interface IPinInfo * This, IDispatch **ppUnk);
        public delegate int get_FilterInfoDelegate(@interface IPinInfo This, IDispatch[] ppUnk);
        public get_FilterInfoDelegate get_FilterInfo;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Name)(interface IPinInfo * This, char**ppUnk);
        public delegate int get_NameDelegate(@interface IPinInfo This, char * ppUnk[] UnnamedParameter);
        public get_NameDelegate get_Name;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Direction)(interface IPinInfo * This, int *ppDirection);
        public delegate int get_DirectionDelegate(@interface IPinInfo This, ref int ppDirection);
        public get_DirectionDelegate get_Direction;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_PinID)(interface IPinInfo * This, char**strPinID);
        public delegate int get_PinIDDelegate(@interface IPinInfo This, char * strPinID[] UnnamedParameter);
        public get_PinIDDelegate get_PinID;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_MediaTypes)(interface IPinInfo * This, IDispatch **ppUnk);
        public delegate int get_MediaTypesDelegate(@interface IPinInfo This, IDispatch[] ppUnk);
        public get_MediaTypesDelegate get_MediaTypes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Connect)(interface IPinInfo * This, IUnknown *pPin);
        public delegate int ConnectDelegate(@interface IPinInfo This, IUnknown pPin);
        public ConnectDelegate Connect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectDirect)(interface IPinInfo * This, IUnknown *pPin);
        public delegate int ConnectDirectDelegate(@interface IPinInfo This, IUnknown pPin);
        public ConnectDirectDelegate ConnectDirect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ConnectWithType)(interface IPinInfo * This, IUnknown *pPin, IDispatch *pMediaType);
        public delegate int ConnectWithTypeDelegate(@interface IPinInfo This, IUnknown pPin, IDispatch pMediaType);
        public ConnectWithTypeDelegate ConnectWithType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Disconnect)(interface IPinInfo * This);
        public delegate int DisconnectDelegate(@interface IPinInfo This);
        public DisconnectDelegate Disconnect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Render)(interface IPinInfo * This);
        public delegate int RenderDelegate(@interface IPinInfo This);
        public RenderDelegate Render;

//        END_INTERFACE
    }

#else // C style interface

    public class IAMStatsVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IAMStats * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IAMStats This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IAMStats * This);
        public delegate uint AddRefDelegate(@interface IAMStats This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IAMStats * This);
        public delegate uint ReleaseDelegate(@interface IAMStats This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IAMStats * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IAMStats This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IAMStats * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IAMStats This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IAMStats * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IAMStats This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IAMStats * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IAMStats This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Reset)(interface IAMStats * This);
        public delegate int ResetDelegate(@interface IAMStats This);
        public ResetDelegate Reset;

        /* [propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Count)(interface IAMStats * This, int *plCount);
        public delegate int get_CountDelegate(@interface IAMStats This, ref int plCount);
        public get_CountDelegate get_Count;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetValueByIndex)(interface IAMStats * This, int lIndex, char**szName, int *lCount, double *dLast, double *dAverage, double *dStdDev, double *dMin, double *dMax);
        public delegate int GetValueByIndexDelegate(@interface IAMStats This, int lIndex, char * szName[] UnnamedParameter, ref int lCount, ref double dLast, ref double dAverage, ref double dStdDev, ref double dMin, ref double dMax);
        public GetValueByIndexDelegate GetValueByIndex;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetValueByName)(interface IAMStats * This, char* szName, int *lIndex, int *lCount, double *dLast, double *dAverage, double *dStdDev, double *dMin, double *dMax);
        public delegate int GetValueByNameDelegate(@interface IAMStats This, ref string szName, ref int lIndex, ref int lCount, ref double dLast, ref double dAverage, ref double dStdDev, ref double dMin, ref double dMax);
        public GetValueByNameDelegate GetValueByName;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIndex)(interface IAMStats * This, char* szName, int lCreate, int *plIndex);
        public delegate int GetIndexDelegate(@interface IAMStats This, ref string szName, int lCreate, ref int plIndex);
        public GetIndexDelegate GetIndex;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AddValue)(interface IAMStats * This, int lIndex, double dValue);
        public delegate int AddValueDelegate(@interface IAMStats This, int lIndex, double dValue);
        public AddValueDelegate AddValue;

//        END_INTERFACE
    }