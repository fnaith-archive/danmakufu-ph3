using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for mixerocx.idl:
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

    public class IMixerOCXNotifyVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMixerOCXNotify * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMixerOCXNotify This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMixerOCXNotify * This);
        public delegate uint AddRefDelegate(@interface IMixerOCXNotify This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMixerOCXNotify * This);
        public delegate uint ReleaseDelegate(@interface IMixerOCXNotify This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnInvalidateRect)(interface IMixerOCXNotify * This, LPCRECT lpcRect);
        public delegate int OnInvalidateRectDelegate(@interface IMixerOCXNotify This, LPCRECT lpcRect);
        public OnInvalidateRectDelegate OnInvalidateRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnStatusChange)(interface IMixerOCXNotify * This, uint ulStatusFlags);
        public delegate int OnStatusChangeDelegate(@interface IMixerOCXNotify This, uint ulStatusFlags);
        public OnStatusChangeDelegate OnStatusChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnDataChange)(interface IMixerOCXNotify * This, uint ulDataFlags);
        public delegate int OnDataChangeDelegate(@interface IMixerOCXNotify This, uint ulDataFlags);
        public OnDataChangeDelegate OnDataChange;

//        END_INTERFACE
    }

#else // C style interface

    public class IMixerOCXVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IMixerOCX * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IMixerOCX This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IMixerOCX * This);
        public delegate uint AddRefDelegate(@interface IMixerOCX This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IMixerOCX * This);
        public delegate uint ReleaseDelegate(@interface IMixerOCX This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnDisplayChange)(interface IMixerOCX * This, uint ulBitsPerPixel, uint ulScreenWidth, uint ulScreenHeight);
        public delegate int OnDisplayChangeDelegate(@interface IMixerOCX This, uint ulBitsPerPixel, uint ulScreenWidth, uint ulScreenHeight);
        public OnDisplayChangeDelegate OnDisplayChange;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAspectRatio)(interface IMixerOCX * This, uint * pdwPictAspectRatioX, uint * pdwPictAspectRatioY);
        public delegate int GetAspectRatioDelegate(@interface IMixerOCX This, ref uint pdwPictAspectRatioX, ref uint pdwPictAspectRatioY);
        public GetAspectRatioDelegate GetAspectRatio;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoSize)(interface IMixerOCX * This, uint * pdwVideoWidth, uint * pdwVideoHeight);
        public delegate int GetVideoSizeDelegate(@interface IMixerOCX This, ref uint pdwVideoWidth, ref uint pdwVideoHeight);
        public GetVideoSizeDelegate GetVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStatus)(interface IMixerOCX * This, uint **pdwStatus);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetStatusDelegate(@interface IMixerOCX This, uint[] pdwStatus);
        public GetStatusDelegate GetStatus;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *OnDraw)(interface IMixerOCX * This, System.IntPtr hdcDraw, LPCRECT prcDraw);
        public delegate int OnDrawDelegate(@interface IMixerOCX This, IntPtr hdcDraw, LPCRECT prcDraw);
        public OnDrawDelegate OnDraw;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDrawRegion)(interface IMixerOCX * This, LPPOINT lpptTopLeftSC, LPCRECT prcDrawCC, LPCRECT lprcClip);
        public delegate int SetDrawRegionDelegate(@interface IMixerOCX This, LPPOINT lpptTopLeftSC, LPCRECT prcDrawCC, LPCRECT lprcClip);
        public SetDrawRegionDelegate SetDrawRegion;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Advise)(interface IMixerOCX * This, interface IMixerOCXNotify *pmdns);
        public delegate int AdviseDelegate(@interface IMixerOCX This, @interface IMixerOCXNotify pmdns);
        public AdviseDelegate Advise;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnAdvise)(interface IMixerOCX * This);
        public delegate int UnAdviseDelegate(@interface IMixerOCX This);
        public UnAdviseDelegate UnAdvise;

//        END_INTERFACE
    }