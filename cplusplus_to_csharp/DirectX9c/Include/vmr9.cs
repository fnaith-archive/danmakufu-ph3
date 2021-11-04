using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for vmr9.idl:
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













public enum __MIDL___MIDL_itf_vmr9_0000_0002
{
        VMR9Sample_SyncPoint = 0x1,
    VMR9Sample_Preroll = 0x2,
    VMR9Sample_Discontinuity = 0x4,
    VMR9Sample_TimeValid = 0x8
}

public class _VMR9PresentationInfo
{
    public uint dwFlags;
    public IDirect3DSurface9 lpSurf;
    public REFERENCE_TIME rtStart = new REFERENCE_TIME();
    public REFERENCE_TIME rtEnd = new REFERENCE_TIME();
    public SIZE szAspectRatio = new SIZE();
    public RECT rcSrc = new RECT();
    public RECT rcDst = new RECT();
    public uint dwReserved1;
    public uint dwReserved2;
}

#else // C style interface

    public class IVMRImagePresenter9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImagePresenter9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImagePresenter9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImagePresenter9 * This);
        public delegate uint AddRefDelegate(@interface IVMRImagePresenter9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImagePresenter9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRImagePresenter9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StartPresenting)(interface IVMRImagePresenter9 * This, System.IntPtr dwUserID);
        public delegate int StartPresentingDelegate(@interface IVMRImagePresenter9 This, IntPtr dwUserID);
        public StartPresentingDelegate StartPresenting;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *StopPresenting)(interface IVMRImagePresenter9 * This, System.IntPtr dwUserID);
        public delegate int StopPresentingDelegate(@interface IVMRImagePresenter9 This, IntPtr dwUserID);
        public StopPresentingDelegate StopPresenting;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PresentImage)(interface IVMRImagePresenter9 * This, System.IntPtr dwUserID, _VMR9PresentationInfo *lpPresInfo);
        public delegate int PresentImageDelegate(@interface IVMRImagePresenter9 This, IntPtr dwUserID, _VMR9PresentationInfo lpPresInfo);
        public PresentImageDelegate PresentImage;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0009 */
/* [local] */ 

public enum __MIDL___MIDL_itf_vmr9_0009_0001
{
        VMR9AllocFlag_3DRenderTarget = 0x1,
    VMR9AllocFlag_DXVATarget = 0x2,
    VMR9AllocFlag_TextureSurface = 0x4,
    VMR9AllocFlag_OffscreenSurface = 0x8,
    VMR9AllocFlag_UsageReserved = 0xf0,
    VMR9AllocFlag_UsageMask = 0xff
}

public class _VMR9AllocationInfo
{
    public uint dwFlags;
    public uint dwWidth;
    public uint dwHeight;
    public D3DFORMAT Format = new D3DFORMAT();
    public D3DPOOL Pool = new D3DPOOL();
    public uint MinBuffers;
    public SIZE szAspectRatio = new SIZE();
    public SIZE szNativeSize = new SIZE();
}

#else // C style interface

    public class IVMRSurfaceAllocator9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRSurfaceAllocator9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRSurfaceAllocator9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRSurfaceAllocator9 * This);
        public delegate uint AddRefDelegate(@interface IVMRSurfaceAllocator9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRSurfaceAllocator9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRSurfaceAllocator9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitializeDevice)(interface IVMRSurfaceAllocator9 * This, System.IntPtr dwUserID, _VMR9AllocationInfo *lpAllocInfo, uint *lpNumBuffers);
        public delegate int InitializeDeviceDelegate(@interface IVMRSurfaceAllocator9 This, IntPtr dwUserID, _VMR9AllocationInfo lpAllocInfo, ref uint lpNumBuffers);
        public InitializeDeviceDelegate InitializeDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TerminateDevice)(interface IVMRSurfaceAllocator9 * This, System.IntPtr dwID);
        public delegate int TerminateDeviceDelegate(@interface IVMRSurfaceAllocator9 This, IntPtr dwID);
        public TerminateDeviceDelegate TerminateDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSurface)(interface IVMRSurfaceAllocator9 * This, System.IntPtr dwUserID, uint SurfaceIndex, uint SurfaceFlags, IDirect3DSurface9 **lplpSurface);
        public delegate int GetSurfaceDelegate(@interface IVMRSurfaceAllocator9 This, IntPtr dwUserID, uint SurfaceIndex, uint SurfaceFlags, IDirect3DSurface9[] lplpSurface);
        public GetSurfaceDelegate GetSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdviseNotify)(interface IVMRSurfaceAllocator9 * This, interface IVMRSurfaceAllocatorNotify9 *lpIVMRSurfAllocNotify);
        public delegate int AdviseNotifyDelegate(@interface IVMRSurfaceAllocator9 This, @interface IVMRSurfaceAllocatorNotify9 lpIVMRSurfAllocNotify);
        public AdviseNotifyDelegate AdviseNotify;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRSurfaceAllocatorNotify9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRSurfaceAllocatorNotify9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRSurfaceAllocatorNotify9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRSurfaceAllocatorNotify9 * This);
        public delegate uint AddRefDelegate(@interface IVMRSurfaceAllocatorNotify9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRSurfaceAllocatorNotify9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRSurfaceAllocatorNotify9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AdviseSurfaceAllocator)(interface IVMRSurfaceAllocatorNotify9 * This, System.IntPtr dwUserID, interface IVMRSurfaceAllocator9 *lpIVRMSurfaceAllocator);
        public delegate int AdviseSurfaceAllocatorDelegate(@interface IVMRSurfaceAllocatorNotify9 This, IntPtr dwUserID, @interface IVMRSurfaceAllocator9 lpIVRMSurfaceAllocator);
        public AdviseSurfaceAllocatorDelegate AdviseSurfaceAllocator;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetD3DDevice)(interface IVMRSurfaceAllocatorNotify9 * This, IDirect3DDevice9 *lpD3DDevice, System.IntPtr hMonitor);
        public delegate int SetD3DDeviceDelegate(@interface IVMRSurfaceAllocatorNotify9 This, IDirect3DDevice9 lpD3DDevice, IntPtr hMonitor);
        public SetD3DDeviceDelegate SetD3DDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ChangeD3DDevice)(interface IVMRSurfaceAllocatorNotify9 * This, IDirect3DDevice9 *lpD3DDevice, System.IntPtr hMonitor);
        public delegate int ChangeD3DDeviceDelegate(@interface IVMRSurfaceAllocatorNotify9 This, IDirect3DDevice9 lpD3DDevice, IntPtr hMonitor);
        public ChangeD3DDeviceDelegate ChangeD3DDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *AllocateSurfaceHelper)(interface IVMRSurfaceAllocatorNotify9 * This, _VMR9AllocationInfo *lpAllocInfo, uint *lpNumBuffers, IDirect3DSurface9 **lplpSurface);
        public delegate int AllocateSurfaceHelperDelegate(@interface IVMRSurfaceAllocatorNotify9 This, _VMR9AllocationInfo lpAllocInfo, ref uint lpNumBuffers, IDirect3DSurface9[] lplpSurface);
        public AllocateSurfaceHelperDelegate AllocateSurfaceHelper;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *NotifyEvent)(interface IVMRSurfaceAllocatorNotify9 * This, int EventCode, System.IntPtr Param1, System.IntPtr Param2);
        public delegate int NotifyEventDelegate(@interface IVMRSurfaceAllocatorNotify9 This, int EventCode, IntPtr Param1, IntPtr Param2);
        public NotifyEventDelegate NotifyEvent;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0011 */
/* [local] */ 

public enum __MIDL___MIDL_itf_vmr9_0011_0001
{
        VMR9ARMode_None = 0,
    VMR9ARMode_LetterBox = VMR9ARMode_None + 1
}

#else // C style interface

    public class IVMRWindowlessControl9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRWindowlessControl9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRWindowlessControl9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRWindowlessControl9 * This);
        public delegate uint AddRefDelegate(@interface IVMRWindowlessControl9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRWindowlessControl9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRWindowlessControl9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNativeVideoSize)(interface IVMRWindowlessControl9 * This, int *lpWidth, int *lpHeight, int *lpARWidth, int *lpARHeight);
        public delegate int GetNativeVideoSizeDelegate(@interface IVMRWindowlessControl9 This, ref int lpWidth, ref int lpHeight, ref int lpARWidth, ref int lpARHeight);
        public GetNativeVideoSizeDelegate GetNativeVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMinIdealVideoSize)(interface IVMRWindowlessControl9 * This, int *lpWidth, int *lpHeight);
        public delegate int GetMinIdealVideoSizeDelegate(@interface IVMRWindowlessControl9 This, ref int lpWidth, ref int lpHeight);
        public GetMinIdealVideoSizeDelegate GetMinIdealVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMaxIdealVideoSize)(interface IVMRWindowlessControl9 * This, int *lpWidth, int *lpHeight);
        public delegate int GetMaxIdealVideoSizeDelegate(@interface IVMRWindowlessControl9 This, ref int lpWidth, ref int lpHeight);
        public GetMaxIdealVideoSizeDelegate GetMaxIdealVideoSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetVideoPosition)(interface IVMRWindowlessControl9 * This, const LPRECT lpSRCRect, const LPRECT lpDSTRect);
        public delegate int SetVideoPositionDelegate(@interface IVMRWindowlessControl9 This, LPRECT lpSRCRect, LPRECT lpDSTRect);
        public SetVideoPositionDelegate SetVideoPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetVideoPosition)(interface IVMRWindowlessControl9 * This, LPRECT lpSRCRect, LPRECT lpDSTRect);
        public delegate int GetVideoPositionDelegate(@interface IVMRWindowlessControl9 This, LPRECT lpSRCRect, LPRECT lpDSTRect);
        public GetVideoPositionDelegate GetVideoPosition;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAspectRatioMode)(interface IVMRWindowlessControl9 * This, uint *lpAspectRatioMode);
        public delegate int GetAspectRatioModeDelegate(@interface IVMRWindowlessControl9 This, ref uint lpAspectRatioMode);
        public GetAspectRatioModeDelegate GetAspectRatioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAspectRatioMode)(interface IVMRWindowlessControl9 * This, uint AspectRatioMode);
        public delegate int SetAspectRatioModeDelegate(@interface IVMRWindowlessControl9 This, uint AspectRatioMode);
        public SetAspectRatioModeDelegate SetAspectRatioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetVideoClippingWindow)(interface IVMRWindowlessControl9 * This, System.IntPtr hwnd);
        public delegate int SetVideoClippingWindowDelegate(@interface IVMRWindowlessControl9 This, IntPtr hwnd);
        public SetVideoClippingWindowDelegate SetVideoClippingWindow;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *RepaintVideo)(interface IVMRWindowlessControl9 * This, System.IntPtr hwnd, System.IntPtr hdc);
        public delegate int RepaintVideoDelegate(@interface IVMRWindowlessControl9 This, IntPtr hwnd, IntPtr hdc);
        public RepaintVideoDelegate RepaintVideo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *DisplayModeChanged)(interface IVMRWindowlessControl9 * This);
        public delegate int DisplayModeChangedDelegate(@interface IVMRWindowlessControl9 This);
        public DisplayModeChangedDelegate DisplayModeChanged;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCurrentImage)(interface IVMRWindowlessControl9 * This, byte **lpDib);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int GetCurrentImageDelegate(@interface IVMRWindowlessControl9 This, byte[] lpDib);
        public GetCurrentImageDelegate GetCurrentImage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBorderColor)(interface IVMRWindowlessControl9 * This, uint Clr);
        public delegate int SetBorderColorDelegate(@interface IVMRWindowlessControl9 This, uint Clr);
        public SetBorderColorDelegate SetBorderColor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBorderColor)(interface IVMRWindowlessControl9 * This, uint *lpClr);
        public delegate int GetBorderColorDelegate(@interface IVMRWindowlessControl9 This, ref uint lpClr);
        public GetBorderColorDelegate GetBorderColor;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0012 */
/* [local] */ 

public enum __MIDL___MIDL_itf_vmr9_0012_0001
{
        MixerPref9_NoDecimation = 0x1,
    MixerPref9_DecimateOutput = 0x2,
    MixerPref9_DecimationReserved = 0xc,
    MixerPref9_DecimateMask = 0xf,
    MixerPref9_BiLinearFiltering = 0x10,
    MixerPref9_PointFiltering = 0x20,
    MixerPref9_AnisotropicFiltering = 0x40,
    MixerPref9_PyramidalQuadFiltering = 0x80,
    MixerPref9_GaussianQuadFiltering = 0x100,
    MixerPref9_FilteringReserved = 0xe00,
    MixerPref9_FilteringMask = 0xff0,
    MixerPref9_RenderTargetRGB = 0x1000,
    MixerPref9_RenderTargetReserved = 0xfe000,
    MixerPref9_RenderTargetMask = 0xff000
}

public class _VMR9NormalizedRect
{
    public float left;
    public float top;
    public float right;
    public float bottom;
}

public enum __MIDL___MIDL_itf_vmr9_0012_0002
{
        ProcAmpControl9_Brightness = 0x1,
    ProcAmpControl9_Contrast = 0x2,
    ProcAmpControl9_Hue = 0x4,
    ProcAmpControl9_Saturation = 0x8,
    ProcAmpControl9_Mask = 0xf
}

public class _VMR9ProcAmpControl
{
    public uint dwSize;
    public uint dwFlags;
    public float Brightness;
    public float Contrast;
    public float Hue;
    public float Saturation;
}

public class _VMR9ProcAmpControlRange
{
    public uint dwSize;
    public VMR9ProcAmpControlFlags dwProperty = new VMR9ProcAmpControlFlags();
    public float MinValue;
    public float MaxValue;
    public float DefaultValue;
    public float StepSize;
}

#else // C style interface

    public class IVMRMixerControl9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRMixerControl9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRMixerControl9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRMixerControl9 * This);
        public delegate uint AddRefDelegate(@interface IVMRMixerControl9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRMixerControl9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRMixerControl9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAlpha)(interface IVMRMixerControl9 * This, uint dwStreamID, float Alpha);
        public delegate int SetAlphaDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, float Alpha);
        public SetAlphaDelegate SetAlpha;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAlpha)(interface IVMRMixerControl9 * This, uint dwStreamID, float *pAlpha);
        public delegate int GetAlphaDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, ref float pAlpha);
        public GetAlphaDelegate GetAlpha;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetZOrder)(interface IVMRMixerControl9 * This, uint dwStreamID, uint dwZ);
        public delegate int SetZOrderDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, uint dwZ);
        public SetZOrderDelegate SetZOrder;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetZOrder)(interface IVMRMixerControl9 * This, uint dwStreamID, uint *pZ);
        public delegate int GetZOrderDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, ref uint pZ);
        public GetZOrderDelegate GetZOrder;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputRect)(interface IVMRMixerControl9 * This, uint dwStreamID, const _VMR9NormalizedRect *pRect);
        public delegate int SetOutputRectDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, _VMR9NormalizedRect pRect);
        public SetOutputRectDelegate SetOutputRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputRect)(interface IVMRMixerControl9 * This, uint dwStreamID, _VMR9NormalizedRect *pRect);
        public delegate int GetOutputRectDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, _VMR9NormalizedRect pRect);
        public GetOutputRectDelegate GetOutputRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBackgroundClr)(interface IVMRMixerControl9 * This, uint ClrBkg);
        public delegate int SetBackgroundClrDelegate(@interface IVMRMixerControl9 This, uint ClrBkg);
        public SetBackgroundClrDelegate SetBackgroundClr;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBackgroundClr)(interface IVMRMixerControl9 * This, uint *lpClrBkg);
        public delegate int GetBackgroundClrDelegate(@interface IVMRMixerControl9 This, ref uint lpClrBkg);
        public GetBackgroundClrDelegate GetBackgroundClr;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMixingPrefs)(interface IVMRMixerControl9 * This, uint dwMixerPrefs);
        public delegate int SetMixingPrefsDelegate(@interface IVMRMixerControl9 This, uint dwMixerPrefs);
        public SetMixingPrefsDelegate SetMixingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMixingPrefs)(interface IVMRMixerControl9 * This, uint *pdwMixerPrefs);
        public delegate int GetMixingPrefsDelegate(@interface IVMRMixerControl9 This, ref uint pdwMixerPrefs);
        public GetMixingPrefsDelegate GetMixingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetProcAmpControl)(interface IVMRMixerControl9 * This, uint dwStreamID, _VMR9ProcAmpControl *lpClrControl);
        public delegate int SetProcAmpControlDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, _VMR9ProcAmpControl lpClrControl);
        public SetProcAmpControlDelegate SetProcAmpControl;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetProcAmpControl)(interface IVMRMixerControl9 * This, uint dwStreamID, _VMR9ProcAmpControl *lpClrControl);
        public delegate int GetProcAmpControlDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, _VMR9ProcAmpControl lpClrControl);
        public GetProcAmpControlDelegate GetProcAmpControl;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetProcAmpControlRange)(interface IVMRMixerControl9 * This, uint dwStreamID, _VMR9ProcAmpControlRange *lpClrControl);
        public delegate int GetProcAmpControlRangeDelegate(@interface IVMRMixerControl9 This, uint dwStreamID, _VMR9ProcAmpControlRange lpClrControl);
        public GetProcAmpControlRangeDelegate GetProcAmpControlRange;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0013 */
/* [local] */ 

public class _VMR9AlphaBitmap
{
    public uint dwFlags;
    public IntPtr hdc;
    public IDirect3DSurface9 pDDS;
    public RECT rSrc = new RECT();
    public _VMR9NormalizedRect rDest = new _VMR9NormalizedRect();
    public float fAlpha;
    public uint clrSrcKey;
    public uint dwFilterMode;
}

public enum __MIDL___MIDL_itf_vmr9_0013_0001
{
        VMR9AlphaBitmap_Disable = 0x1,
    VMR9AlphaBitmap_hDC = 0x2,
    VMR9AlphaBitmap_EntireDDS = 0x4,
    VMR9AlphaBitmap_SrcColorKey = 0x8,
    VMR9AlphaBitmap_SrcRect = 0x10,
    VMR9AlphaBitmap_FilterMode = 0x20
}

#else // C style interface

    public class IVMRMixerBitmap9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRMixerBitmap9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRMixerBitmap9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRMixerBitmap9 * This);
        public delegate uint AddRefDelegate(@interface IVMRMixerBitmap9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRMixerBitmap9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRMixerBitmap9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAlphaBitmap)(interface IVMRMixerBitmap9 * This, const _VMR9AlphaBitmap *pBmpParms);
        public delegate int SetAlphaBitmapDelegate(@interface IVMRMixerBitmap9 This, _VMR9AlphaBitmap pBmpParms);
        public SetAlphaBitmapDelegate SetAlphaBitmap;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UpdateAlphaBitmapParameters)(interface IVMRMixerBitmap9 * This, const _VMR9AlphaBitmap *pBmpParms);
        public delegate int UpdateAlphaBitmapParametersDelegate(@interface IVMRMixerBitmap9 This, _VMR9AlphaBitmap pBmpParms);
        public UpdateAlphaBitmapParametersDelegate UpdateAlphaBitmapParameters;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAlphaBitmapParameters)(interface IVMRMixerBitmap9 * This, _VMR9AlphaBitmap *pBmpParms);
        public delegate int GetAlphaBitmapParametersDelegate(@interface IVMRMixerBitmap9 This, _VMR9AlphaBitmap pBmpParms);
        public GetAlphaBitmapParametersDelegate GetAlphaBitmapParameters;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRSurface9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRSurface9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRSurface9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRSurface9 * This);
        public delegate uint AddRefDelegate(@interface IVMRSurface9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRSurface9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRSurface9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsSurfaceLocked)(interface IVMRSurface9 * This);
        public delegate int IsSurfaceLockedDelegate(@interface IVMRSurface9 This);
        public IsSurfaceLockedDelegate IsSurfaceLocked;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LockSurface)(interface IVMRSurface9 * This, byte **lpSurface);
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
        public delegate int LockSurfaceDelegate(@interface IVMRSurface9 This, byte[] lpSurface);
        public LockSurfaceDelegate LockSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *UnlockSurface)(interface IVMRSurface9 * This);
        public delegate int UnlockSurfaceDelegate(@interface IVMRSurface9 This);
        public UnlockSurfaceDelegate UnlockSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSurface)(interface IVMRSurface9 * This, IDirect3DSurface9 **lplpSurface);
        public delegate int GetSurfaceDelegate(@interface IVMRSurface9 This, IDirect3DSurface9[] lplpSurface);
        public GetSurfaceDelegate GetSurface;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0015 */
/* [local] */ 

public enum __MIDL___MIDL_itf_vmr9_0015_0001
{
        RenderPrefs9_DoNotRenderBorder = 0x1,
    RenderPrefs9_Mask = 0x1
}

#else // C style interface

    public class IVMRImagePresenterConfig9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImagePresenterConfig9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImagePresenterConfig9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImagePresenterConfig9 * This);
        public delegate uint AddRefDelegate(@interface IVMRImagePresenterConfig9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImagePresenterConfig9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRImagePresenterConfig9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingPrefs)(interface IVMRImagePresenterConfig9 * This, uint dwRenderFlags);
        public delegate int SetRenderingPrefsDelegate(@interface IVMRImagePresenterConfig9 This, uint dwRenderFlags);
        public SetRenderingPrefsDelegate SetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingPrefs)(interface IVMRImagePresenterConfig9 * This, uint *dwRenderFlags);
        public delegate int GetRenderingPrefsDelegate(@interface IVMRImagePresenterConfig9 This, ref uint dwRenderFlags);
        public GetRenderingPrefsDelegate GetRenderingPrefs;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRVideoStreamControl9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRVideoStreamControl9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRVideoStreamControl9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRVideoStreamControl9 * This);
        public delegate uint AddRefDelegate(@interface IVMRVideoStreamControl9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRVideoStreamControl9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRVideoStreamControl9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStreamActiveState)(interface IVMRVideoStreamControl9 * This, bool fActive);
        public delegate int SetStreamActiveStateDelegate(@interface IVMRVideoStreamControl9 This, bool fActive);
        public SetStreamActiveStateDelegate SetStreamActiveState;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStreamActiveState)(interface IVMRVideoStreamControl9 * This, bool *lpfActive);
        public delegate int GetStreamActiveStateDelegate(@interface IVMRVideoStreamControl9 This, ref bool lpfActive);
        public GetStreamActiveStateDelegate GetStreamActiveState;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0017 */
/* [local] */ 

public enum __MIDL___MIDL_itf_vmr9_0017_0001
{
        VMR9Mode_Windowed = 0x1,
    VMR9Mode_Windowless = 0x2,
    VMR9Mode_Renderless = 0x4,
    VMR9Mode_Mask = 0x7
}

#else // C style interface

    public class IVMRFilterConfig9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRFilterConfig9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRFilterConfig9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRFilterConfig9 * This);
        public delegate uint AddRefDelegate(@interface IVMRFilterConfig9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRFilterConfig9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRFilterConfig9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetImageCompositor)(interface IVMRFilterConfig9 * This, interface IVMRImageCompositor9 *lpVMRImgCompositor);
        public delegate int SetImageCompositorDelegate(@interface IVMRFilterConfig9 This, @interface IVMRImageCompositor9 lpVMRImgCompositor);
        public SetImageCompositorDelegate SetImageCompositor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetNumberOfStreams)(interface IVMRFilterConfig9 * This, uint dwMaxStreams);
        public delegate int SetNumberOfStreamsDelegate(@interface IVMRFilterConfig9 This, uint dwMaxStreams);
        public SetNumberOfStreamsDelegate SetNumberOfStreams;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfStreams)(interface IVMRFilterConfig9 * This, uint *pdwMaxStreams);
        public delegate int GetNumberOfStreamsDelegate(@interface IVMRFilterConfig9 This, ref uint pdwMaxStreams);
        public GetNumberOfStreamsDelegate GetNumberOfStreams;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingPrefs)(interface IVMRFilterConfig9 * This, uint dwRenderFlags);
        public delegate int SetRenderingPrefsDelegate(@interface IVMRFilterConfig9 This, uint dwRenderFlags);
        public SetRenderingPrefsDelegate SetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingPrefs)(interface IVMRFilterConfig9 * This, uint *pdwRenderFlags);
        public delegate int GetRenderingPrefsDelegate(@interface IVMRFilterConfig9 This, ref uint pdwRenderFlags);
        public GetRenderingPrefsDelegate GetRenderingPrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetRenderingMode)(interface IVMRFilterConfig9 * This, uint Mode);
        public delegate int SetRenderingModeDelegate(@interface IVMRFilterConfig9 This, uint Mode);
        public SetRenderingModeDelegate SetRenderingMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetRenderingMode)(interface IVMRFilterConfig9 * This, uint *pMode);
        public delegate int GetRenderingModeDelegate(@interface IVMRFilterConfig9 This, ref uint pMode);
        public GetRenderingModeDelegate GetRenderingMode;

//        END_INTERFACE
    }

#else // C style interface

    public class IVMRAspectRatioControl9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRAspectRatioControl9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRAspectRatioControl9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRAspectRatioControl9 * This);
        public delegate uint AddRefDelegate(@interface IVMRAspectRatioControl9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRAspectRatioControl9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRAspectRatioControl9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAspectRatioMode)(interface IVMRAspectRatioControl9 * This, uint * lpdwARMode);
        public delegate int GetAspectRatioModeDelegate(@interface IVMRAspectRatioControl9 This, ref uint lpdwARMode);
        public GetAspectRatioModeDelegate GetAspectRatioMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAspectRatioMode)(interface IVMRAspectRatioControl9 * This, uint dwARMode);
        public delegate int SetAspectRatioModeDelegate(@interface IVMRAspectRatioControl9 This, uint dwARMode);
        public SetAspectRatioModeDelegate SetAspectRatioMode;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0019 */
/* [local] */ 

public class _VMR9MonitorInfo
{
    public uint uDevID;
    public RECT rcMonitor = new RECT();
    public IntPtr hMon;
    public uint dwFlags;
    public string szDevice = new string(new char[32]);
    public string szDescription = new string(new char[512]);
    public LARGE_INTEGER liDriverVersion = new LARGE_INTEGER();
    public uint dwVendorId;
    public uint dwDeviceId;
    public uint dwSubSysId;
    public uint dwRevision;
}

#else // C style interface

    public class IVMRMonitorConfig9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRMonitorConfig9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRMonitorConfig9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRMonitorConfig9 * This);
        public delegate uint AddRefDelegate(@interface IVMRMonitorConfig9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRMonitorConfig9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRMonitorConfig9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMonitor)(interface IVMRMonitorConfig9 * This, uint uDev);
        public delegate int SetMonitorDelegate(@interface IVMRMonitorConfig9 This, uint uDev);
        public SetMonitorDelegate SetMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMonitor)(interface IVMRMonitorConfig9 * This, uint *puDev);
        public delegate int GetMonitorDelegate(@interface IVMRMonitorConfig9 This, ref uint puDev);
        public GetMonitorDelegate GetMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDefaultMonitor)(interface IVMRMonitorConfig9 * This, uint uDev);
        public delegate int SetDefaultMonitorDelegate(@interface IVMRMonitorConfig9 This, uint uDev);
        public SetDefaultMonitorDelegate SetDefaultMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDefaultMonitor)(interface IVMRMonitorConfig9 * This, uint *puDev);
        public delegate int GetDefaultMonitorDelegate(@interface IVMRMonitorConfig9 This, ref uint puDev);
        public GetDefaultMonitorDelegate GetDefaultMonitor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAvailableMonitors)(interface IVMRMonitorConfig9 * This, _VMR9MonitorInfo *pInfo, uint dwMaxInfoArraySize, uint *pdwNumDevices);
        public delegate int GetAvailableMonitorsDelegate(@interface IVMRMonitorConfig9 This, _VMR9MonitorInfo pInfo, uint dwMaxInfoArraySize, ref uint pdwNumDevices);
        public GetAvailableMonitorsDelegate GetAvailableMonitors;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0020 */
/* [local] */ 

public enum __MIDL___MIDL_itf_vmr9_0020_0001
{
        DeinterlacePref9_NextBest = 0x1,
    DeinterlacePref9_BOB = 0x2,
    DeinterlacePref9_Weave = 0x4,
    DeinterlacePref9_Mask = 0x7
}

public enum __MIDL___MIDL_itf_vmr9_0020_0002
{
        DeinterlaceTech9_Unknown = 0,
    DeinterlaceTech9_BOBLineReplicate = 0x1,
    DeinterlaceTech9_BOBVerticalStretch = 0x2,
    DeinterlaceTech9_MedianFiltering = 0x4,
    DeinterlaceTech9_EdgeFiltering = 0x10,
    DeinterlaceTech9_FieldAdaptive = 0x20,
    DeinterlaceTech9_PixelAdaptive = 0x40,
    DeinterlaceTech9_MotionVectorSteered = 0x80
}

public class _VMR9Frequency
{
    public uint dwNumerator;
    public uint dwDenominator;
}

public enum _VMR9_SampleFormat
{
        VMR9_SampleReserved = 1,
    VMR9_SampleProgressiveFrame = 2,
    VMR9_SampleFieldInterleavedEvenFirst = 3,
    VMR9_SampleFieldInterleavedOddFirst = 4,
    VMR9_SampleFieldSingleEven = 5,
    VMR9_SampleFieldSingleOdd = 6
}

public class _VMR9VideoDesc
{
    public uint dwSize;
    public uint dwSampleWidth;
    public uint dwSampleHeight;
    public VMR9_SampleFormat SampleFormat = new VMR9_SampleFormat();
    public uint dwFourCC;
    public _VMR9Frequency InputSampleFreq = new _VMR9Frequency();
    public _VMR9Frequency OutputFrameFreq = new _VMR9Frequency();
}

public class _VMR9DeinterlaceCaps
{
    public uint dwSize;
    public uint dwNumPreviousOutputFrames;
    public uint dwNumForwardRefSamples;
    public uint dwNumBackwardRefSamples;
    public VMR9DeinterlaceTech DeinterlaceTechnology = new VMR9DeinterlaceTech();
}

#else // C style interface

    public class IVMRDeinterlaceControl9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRDeinterlaceControl9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRDeinterlaceControl9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRDeinterlaceControl9 * This);
        public delegate uint AddRefDelegate(@interface IVMRDeinterlaceControl9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRDeinterlaceControl9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRDeinterlaceControl9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetNumberOfDeinterlaceModes)(interface IVMRDeinterlaceControl9 * This, _VMR9VideoDesc *lpVideoDescription, uint * lpdwNumDeinterlaceModes, LPGUID lpDeinterlaceModes);
        public delegate int GetNumberOfDeinterlaceModesDelegate(@interface IVMRDeinterlaceControl9 This, _VMR9VideoDesc lpVideoDescription, ref uint lpdwNumDeinterlaceModes, LPGUID lpDeinterlaceModes);
        public GetNumberOfDeinterlaceModesDelegate GetNumberOfDeinterlaceModes;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDeinterlaceModeCaps)(interface IVMRDeinterlaceControl9 * This, LPGUID lpDeinterlaceMode, _VMR9VideoDesc *lpVideoDescription, _VMR9DeinterlaceCaps *lpDeinterlaceCaps);
        public delegate int GetDeinterlaceModeCapsDelegate(@interface IVMRDeinterlaceControl9 This, LPGUID lpDeinterlaceMode, _VMR9VideoDesc lpVideoDescription, _VMR9DeinterlaceCaps lpDeinterlaceCaps);
        public GetDeinterlaceModeCapsDelegate GetDeinterlaceModeCaps;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDeinterlaceMode)(interface IVMRDeinterlaceControl9 * This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public delegate int GetDeinterlaceModeDelegate(@interface IVMRDeinterlaceControl9 This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public GetDeinterlaceModeDelegate GetDeinterlaceMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDeinterlaceMode)(interface IVMRDeinterlaceControl9 * This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public delegate int SetDeinterlaceModeDelegate(@interface IVMRDeinterlaceControl9 This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public SetDeinterlaceModeDelegate SetDeinterlaceMode;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDeinterlacePrefs)(interface IVMRDeinterlaceControl9 * This, uint * lpdwDeinterlacePrefs);
        public delegate int GetDeinterlacePrefsDelegate(@interface IVMRDeinterlaceControl9 This, ref uint lpdwDeinterlacePrefs);
        public GetDeinterlacePrefsDelegate GetDeinterlacePrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetDeinterlacePrefs)(interface IVMRDeinterlaceControl9 * This, uint dwDeinterlacePrefs);
        public delegate int SetDeinterlacePrefsDelegate(@interface IVMRDeinterlaceControl9 This, uint dwDeinterlacePrefs);
        public SetDeinterlacePrefsDelegate SetDeinterlacePrefs;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetActualDeinterlaceMode)(interface IVMRDeinterlaceControl9 * This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public delegate int GetActualDeinterlaceModeDelegate(@interface IVMRDeinterlaceControl9 This, uint dwStreamID, LPGUID lpDeinterlaceMode);
        public GetActualDeinterlaceModeDelegate GetActualDeinterlaceMode;

//        END_INTERFACE
    }





/* interface __MIDL_itf_vmr9_0021 */
/* [local] */ 

public class _VMR9VideoStreamInfo
{
    public IDirect3DSurface9 pddsVideoSurface;
    public uint dwWidth;
    public uint dwHeight;
    public uint dwStrmID;
    public float fAlpha;
    public _VMR9NormalizedRect rNormal = new _VMR9NormalizedRect();
    public REFERENCE_TIME rtStart = new REFERENCE_TIME();
    public REFERENCE_TIME rtEnd = new REFERENCE_TIME();
    public VMR9_SampleFormat SampleFormat = new VMR9_SampleFormat();
}

#else // C style interface

    public class IVMRImageCompositor9Vtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IVMRImageCompositor9 * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IVMRImageCompositor9 This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IVMRImageCompositor9 * This);
        public delegate uint AddRefDelegate(@interface IVMRImageCompositor9 This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IVMRImageCompositor9 * This);
        public delegate uint ReleaseDelegate(@interface IVMRImageCompositor9 This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitCompositionDevice)(interface IVMRImageCompositor9 * This, IUnknown *pD3DDevice);
        public delegate int InitCompositionDeviceDelegate(@interface IVMRImageCompositor9 This, IUnknown pD3DDevice);
        public InitCompositionDeviceDelegate InitCompositionDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TermCompositionDevice)(interface IVMRImageCompositor9 * This, IUnknown *pD3DDevice);
        public delegate int TermCompositionDeviceDelegate(@interface IVMRImageCompositor9 This, IUnknown pD3DDevice);
        public TermCompositionDeviceDelegate TermCompositionDevice;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStreamMediaType)(interface IVMRImageCompositor9 * This, uint dwStrmID, AM_MEDIA_TYPE *pmt, bool fTexture);
        public delegate int SetStreamMediaTypeDelegate(@interface IVMRImageCompositor9 This, uint dwStrmID, AM_MEDIA_TYPE pmt, bool fTexture);
        public SetStreamMediaTypeDelegate SetStreamMediaType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CompositeImage)(interface IVMRImageCompositor9 * This, IUnknown *pD3DDevice, IDirect3DSurface9 *pddsRenderTarget, AM_MEDIA_TYPE *pmtRenderTarget, REFERENCE_TIME rtStart, REFERENCE_TIME rtEnd, D3DCOLOR dwClrBkGnd, _VMR9VideoStreamInfo *pVideoStreamInfo, uint cStreams);
        public delegate int CompositeImageDelegate(@interface IVMRImageCompositor9 This, IUnknown pD3DDevice, IDirect3DSurface9 pddsRenderTarget, AM_MEDIA_TYPE pmtRenderTarget, REFERENCE_TIME rtStart, REFERENCE_TIME rtEnd, D3DCOLOR dwClrBkGnd, _VMR9VideoStreamInfo pVideoStreamInfo, uint cStreams);
        public CompositeImageDelegate CompositeImage;

//        END_INTERFACE
    }