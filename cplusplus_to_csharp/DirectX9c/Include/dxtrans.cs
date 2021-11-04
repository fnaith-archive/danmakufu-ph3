using System;

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning( disable: 4049 ) // more than 64k source lines

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 6.00.0357 */
/* Compiler settings for dxtrans.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext
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
// typedef class DXTransformFactory DXTransformFactory;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXTransformFactory DXTransformFactory;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class DXTaskManager DXTaskManager;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXTaskManager DXTaskManager;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class DXTScale DXTScale;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXTScale DXTScale;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class DXSurface DXSurface;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXSurface DXSurface;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class DXSurfaceModifier DXSurfaceModifier;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXSurfaceModifier DXSurfaceModifier;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class DXGradient DXGradient;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXGradient DXGradient;
#endif // __cplusplus




#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef class DXTFilter DXTFilter;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct DXTFilter DXTFilter;
#endif // __cplusplus



/* header files for imported files */
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "oaidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "ocidl.h"
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "comcat.h"

#if __cplusplus
#endif

#else // C style interface

    public class IDXBaseObjectVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXBaseObject * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXBaseObject This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXBaseObject * This);
        public delegate uint AddRefDelegate(@interface IDXBaseObject This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXBaseObject * This);
        public delegate uint ReleaseDelegate(@interface IDXBaseObject This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetGenerationId)(interface IDXBaseObject * This, uint *pID);
        public delegate int GetGenerationIdDelegate(@interface IDXBaseObject This, ref uint pID);
        public GetGenerationIdDelegate GetGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IncrementGenerationId)(interface IDXBaseObject * This, bool bRefresh);
        public delegate int IncrementGenerationIdDelegate(@interface IDXBaseObject This, bool bRefresh);
        public IncrementGenerationIdDelegate IncrementGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetObjectSize)(interface IDXBaseObject * This, uint *pcbSize);
        public delegate int GetObjectSizeDelegate(@interface IDXBaseObject This, ref uint pcbSize);
        public GetObjectSizeDelegate GetObjectSize;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0260 */
/* [local] */ 

public enum DXBNDID
{
        DXB_X = 0,
    DXB_Y = 1,
    DXB_Z = 2,
    DXB_T = 3
}

public enum DXBNDTYPE
{
        DXBT_DISCRETE = 0,
    DXBT_DISCRETE64 = DXBT_DISCRETE + 1,
    DXBT_CONTINUOUS = DXBT_DISCRETE64 + 1,
    DXBT_CONTINUOUS64 = DXBT_CONTINUOUS + 1
}

public class DXDBND
{
    public int Min;
    public int Max;
}


public class DXDBND64
{
    public long Min;
    public long Max;
}


public class DXCBND
{
    public float Min;
    public float Max;
}


public class DXCBND64
{
    public double Min;
    public double Max;
}


public class DXBNDS
{
    public DXBNDTYPE eType;
    /* [switch_is] */
    /* [switch_type] */
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union __MIDL___MIDL_itf_dxtrans_0260_0001
//        {
//  /* [case()] */
//        DXDBND D[4];
//  /* [case()] */
//        DXDBND64 LD[4];
//  /* [case()] */
//        DXCBND C[4];
//  /* [case()] */
//        DXCBND64 LC[4];
//        }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//        u;
}





public class DXVEC
{
    public DXBNDTYPE eType;
    /* [switch_is] */
    /* [switch_type] */
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union __MIDL___MIDL_itf_dxtrans_0260_0002
//        {
//  /* [case()] */
//        int D[4];
//  /* [case()] */
//        long LD[4];
//  /* [case()] */
//        float C[4];
//  /* [case()] */
//        double LC[4];
//        }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//        u;
}

#else // C style interface

    public class IDXTransformFactoryVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXTransformFactory * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXTransformFactory This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXTransformFactory * This);
        public delegate uint AddRefDelegate(@interface IDXTransformFactory This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXTransformFactory * This);
        public delegate uint ReleaseDelegate(@interface IDXTransformFactory This);
        public ReleaseDelegate Release;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryService)(interface IDXTransformFactory * This, REFGUID guidService, REFIID riid, object**ppvObject);
        public delegate int QueryServiceDelegate(@interface IDXTransformFactory This, REFGUID guidService, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryServiceDelegate QueryService;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetService)(interface IDXTransformFactory * This, REFGUID guidService, object* pUnkService, bool bWeakReference);
        public delegate int SetServiceDelegate(@interface IDXTransformFactory This, REFGUID guidService, object pUnkService, bool bWeakReference);
        public SetServiceDelegate SetService;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateTransform)(interface IDXTransformFactory * This, object**punkInputs, uint ulNumInputs, object**punkOutputs, uint ulNumOutputs, IPropertyBag *pInitProps, IErrorLog *pErrLog, REFCLSID TransCLSID, REFIID TransIID, object**ppTransform);
        public delegate int CreateTransformDelegate(@interface IDXTransformFactory This, object punkInputs[] UnnamedParameter, uint ulNumInputs, object punkOutputs[] UnnamedParameter2, uint ulNumOutputs, IPropertyBag pInitProps, IErrorLog pErrLog, REFCLSID TransCLSID, REFIID TransIID, object ppTransform[] UnnamedParameter3);
        public CreateTransformDelegate CreateTransform;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitializeTransform)(interface IDXTransformFactory * This, interface IDXTransform *pTransform, object**punkInputs, uint ulNumInputs, object**punkOutputs, uint ulNumOutputs, IPropertyBag *pInitProps, IErrorLog *pErrLog);
        public delegate int InitializeTransformDelegate(@interface IDXTransformFactory This, @interface IDXTransform pTransform, object punkInputs[] UnnamedParameter, uint ulNumInputs, object punkOutputs[] UnnamedParameter2, uint ulNumOutputs, IPropertyBag pInitProps, IErrorLog pErrLog);
        public InitializeTransformDelegate InitializeTransform;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0261 */
/* [local] */ 

public enum DXTMISCFLAGS
{
        DXTMF_BLEND_WITH_OUTPUT = 1 << 0,
    DXTMF_DITHER_OUTPUT = 1 << 1,
    DXTMF_OPTION_MASK = 0xffff,
    DXTMF_VALID_OPTIONS = DXTMF_BLEND_WITH_OUTPUT | DXTMF_DITHER_OUTPUT,
    DXTMF_BLEND_SUPPORTED = 1 << 16,
    DXTMF_DITHER_SUPPORTED = 1 << 17,
    DXTMF_INPLACE_OPERATION = 1 << 24,
    DXTMF_BOUNDS_SUPPORTED = 1 << 25,
    DXTMF_PLACEMENT_SUPPORTED = 1 << 26,
    DXTMF_QUALITY_SUPPORTED = 1 << 27,
    DXTMF_OPAQUE_RESULT = 1 << 28
}

public enum DXINOUTINFOFLAGS
{
        DXINOUTF_OPTIONAL = 1 << 0
}

#else // C style interface

    public class IDXTransformVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXTransform * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXTransform This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXTransform * This);
        public delegate uint AddRefDelegate(@interface IDXTransform This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXTransform * This);
        public delegate uint ReleaseDelegate(@interface IDXTransform This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetGenerationId)(interface IDXTransform * This, uint *pID);
        public delegate int GetGenerationIdDelegate(@interface IDXTransform This, ref uint pID);
        public GetGenerationIdDelegate GetGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IncrementGenerationId)(interface IDXTransform * This, bool bRefresh);
        public delegate int IncrementGenerationIdDelegate(@interface IDXTransform This, bool bRefresh);
        public IncrementGenerationIdDelegate IncrementGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetObjectSize)(interface IDXTransform * This, uint *pcbSize);
        public delegate int GetObjectSizeDelegate(@interface IDXTransform This, ref uint pcbSize);
        public GetObjectSizeDelegate GetObjectSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Setup)(interface IDXTransform * This, object* const *punkInputs, uint ulNumInputs, object* const *punkOutputs, uint ulNumOutputs, uint dwFlags);
        public delegate int SetupDelegate(@interface IDXTransform This, object * punkInputs, uint ulNumInputs, object * punkOutputs, uint ulNumOutputs, uint dwFlags);
        public SetupDelegate Setup;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Execute)(interface IDXTransform * This, const GUID *pRequestID, const DXBNDS *pClipBnds, const DXVEC *pPlacement);
        public delegate int ExecuteDelegate(@interface IDXTransform This, GUID pRequestID, DXBNDS pClipBnds, DXVEC pPlacement);
        public ExecuteDelegate Execute;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MapBoundsIn2Out)(interface IDXTransform * This, const DXBNDS *pInBounds, uint ulNumInBnds, uint ulOutIndex, DXBNDS *pOutBounds);
        public delegate int MapBoundsIn2OutDelegate(@interface IDXTransform This, DXBNDS pInBounds, uint ulNumInBnds, uint ulOutIndex, DXBNDS pOutBounds);
        public MapBoundsIn2OutDelegate MapBoundsIn2Out;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *MapBoundsOut2In)(interface IDXTransform * This, uint ulOutIndex, const DXBNDS *pOutBounds, uint ulInIndex, DXBNDS *pInBounds);
        public delegate int MapBoundsOut2InDelegate(@interface IDXTransform This, uint ulOutIndex, DXBNDS pOutBounds, uint ulInIndex, DXBNDS pInBounds);
        public MapBoundsOut2InDelegate MapBoundsOut2In;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetMiscFlags)(interface IDXTransform * This, uint dwMiscFlags);
        public delegate int SetMiscFlagsDelegate(@interface IDXTransform This, uint dwMiscFlags);
        public SetMiscFlagsDelegate SetMiscFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetMiscFlags)(interface IDXTransform * This, uint *pdwMiscFlags);
        public delegate int GetMiscFlagsDelegate(@interface IDXTransform This, ref uint pdwMiscFlags);
        public GetMiscFlagsDelegate GetMiscFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetInOutInfo)(interface IDXTransform * This, bool bIsOutput, uint ulIndex, uint *pdwFlags, GUID *pIDs, uint *pcIDs, object**ppUnkCurrentObject);
        public delegate int GetInOutInfoDelegate(@interface IDXTransform This, bool bIsOutput, uint ulIndex, ref uint pdwFlags, GUID pIDs, ref uint pcIDs, object ppUnkCurrentObject[] UnnamedParameter);
        public GetInOutInfoDelegate GetInOutInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetQuality)(interface IDXTransform * This, float fQuality);
        public delegate int SetQualityDelegate(@interface IDXTransform This, float fQuality);
        public SetQualityDelegate SetQuality;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetQuality)(interface IDXTransform * This, float *fQuality);
        public delegate int GetQualityDelegate(@interface IDXTransform This, ref float fQuality);
        public GetQualityDelegate GetQuality;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXSurfacePickVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXSurfacePick * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXSurfacePick This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXSurfacePick * This);
        public delegate uint AddRefDelegate(@interface IDXSurfacePick This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXSurfacePick * This);
        public delegate uint ReleaseDelegate(@interface IDXSurfacePick This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *PointPick)(interface IDXSurfacePick * This, const DXVEC *pPoint, uint *pulInputSurfaceIndex, DXVEC *pInputPoint);
        public delegate int PointPickDelegate(@interface IDXSurfacePick This, DXVEC pPoint, ref uint pulInputSurfaceIndex, DXVEC pInputPoint);
        public PointPickDelegate PointPick;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXTBindHostVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXTBindHost * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXTBindHost This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXTBindHost * This);
        public delegate uint AddRefDelegate(@interface IDXTBindHost This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXTBindHost * This);
        public delegate uint ReleaseDelegate(@interface IDXTBindHost This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBindHost)(interface IDXTBindHost * This, IBindHost *pBindHost);
        public delegate int SetBindHostDelegate(@interface IDXTBindHost This, IBindHost pBindHost);
        public SetBindHostDelegate SetBindHost;

//        END_INTERFACE
    }


#if __cplusplus
public partial class DXTMTASKINFO
{
    public DXTASKPROC pfnTaskProc; // Pointer to function to execute
    public object pTaskData; // Pointer to argument data
    public DXAPCPROC pfnCompletionAPC; // Pointer to completion APC proc
    public uint dwCompletionData; // Pointer to APC proc data
    public readonly GUID pRequestID; // Used to identify groups of tasks
}
#else
public partial class DXTMTASKINFO
{
    public object pfnTaskProc;
    public object pTaskData;
    public object pfnCompletionAPC;
    public uint dwCompletionData;
    public readonly GUID pRequestID;
}

#endif

#else // C style interface

    public class IDXTaskManagerVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXTaskManager * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXTaskManager This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXTaskManager * This);
        public delegate uint AddRefDelegate(@interface IDXTaskManager This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXTaskManager * This);
        public delegate uint ReleaseDelegate(@interface IDXTaskManager This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *QueryNumProcessors)(interface IDXTaskManager * This, uint *pulNumProc);
        public delegate int QueryNumProcessorsDelegate(@interface IDXTaskManager This, ref uint pulNumProc);
        public QueryNumProcessorsDelegate QueryNumProcessors;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetThreadPoolSize)(interface IDXTaskManager * This, uint ulNumThreads);
        public delegate int SetThreadPoolSizeDelegate(@interface IDXTaskManager This, uint ulNumThreads);
        public SetThreadPoolSizeDelegate SetThreadPoolSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetThreadPoolSize)(interface IDXTaskManager * This, uint *pulNumThreads);
        public delegate int GetThreadPoolSizeDelegate(@interface IDXTaskManager This, ref uint pulNumThreads);
        public GetThreadPoolSizeDelegate GetThreadPoolSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetConcurrencyLimit)(interface IDXTaskManager * This, uint ulNumThreads);
        public delegate int SetConcurrencyLimitDelegate(@interface IDXTaskManager This, uint ulNumThreads);
        public SetConcurrencyLimitDelegate SetConcurrencyLimit;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetConcurrencyLimit)(interface IDXTaskManager * This, uint *pulNumThreads);
        public delegate int GetConcurrencyLimitDelegate(@interface IDXTaskManager This, ref uint pulNumThreads);
        public GetConcurrencyLimitDelegate GetConcurrencyLimit;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ScheduleTasks)(interface IDXTaskManager * This, DXTMTASKINFO TaskInfo[], System.IntPtr Events[], uint TaskIDs[], uint ulNumTasks, uint ulWaitPeriod);
        public delegate int ScheduleTasksDelegate(@interface IDXTaskManager This, DXTMTASKINFO[] TaskInfo, IntPtr[] Events, uint[] TaskIDs, uint ulNumTasks, uint ulWaitPeriod);
        public ScheduleTasksDelegate ScheduleTasks;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TerminateTasks)(interface IDXTaskManager * This, uint TaskIDs[], uint ulCount, uint ulTimeOut);
        public delegate int TerminateTasksDelegate(@interface IDXTaskManager This, uint[] TaskIDs, uint ulCount, uint ulTimeOut);
        public TerminateTasksDelegate TerminateTasks;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *TerminateRequest)(interface IDXTaskManager * This, REFIID RequestID, uint ulTimeOut);
        public delegate int TerminateRequestDelegate(@interface IDXTaskManager This, REFIID RequestID, uint ulTimeOut);
        public TerminateRequestDelegate TerminateRequest;

//        END_INTERFACE
    }

/// //////////////////////////////////////////////////

public partial class DXBASESAMPLE
{
    public byte Blue;
    public byte Green;
    public byte Red;
    public byte Alpha;
    public DXBASESAMPLE()
    {
    }
    public DXBASESAMPLE(byte alpha, byte red, byte green, byte blue)
    {
        this.Alpha = alpha;
        this.Red = red;
        this.Green = green;
        this.Blue = blue;
    }
    public DXBASESAMPLE(uint val)
    {
        this = ((DXBASESAMPLE) & val);
    }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator uint() const
    public static implicit operator uint(DXBASESAMPLE ImpliedObject)
    {
        return ((uint)ImpliedObject);
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: uint operator =(const uint val)
    public uint CopyFrom(uint val)
    {
        return this = (DXBASESAMPLE)val;
    }
} // DXBASESAMPLE

/// //////////////////////////////////////////////////

public partial class DXSAMPLE : DXBASESAMPLE
{
    public DXSAMPLE()
    {
    }
    public DXSAMPLE(byte alpha, byte red, byte green, byte blue) : base(alpha, red, green, blue)
    {
    }
    public DXSAMPLE(uint val)
    {
        this = ((DXSAMPLE) & val);
    }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator uint() const
    public static new implicit operator uint(DXSAMPLE ImpliedObject)
    {
        return ((uint)ImpliedObject);
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: uint operator =(const uint val)
    public new uint CopyFrom(uint val)
    {
        return this = (DXSAMPLE)val;
    }

    // 
    // The following cast operators are to prevent a direct assignment of a DXSAMPLE to a DXPMSAMPLE
    // 
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: inline operator DXPMSAMPLE() const
    public static implicit operator DXPMSAMPLE(DXSAMPLE ImpliedObject)
    {
        return ((DXPMSAMPLE)ImpliedObject);
    }

} // DXSAMPLE

/// //////////////////////////////////////////////////

public partial class DXPMSAMPLE : DXBASESAMPLE
{
    public DXPMSAMPLE()
    {
    }
    public DXPMSAMPLE(byte alpha, byte red, byte green, byte blue) : base(alpha, red, green, blue)
    {
    }
    public DXPMSAMPLE(uint val)
    {
        this = ((DXPMSAMPLE) & val);
    }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: operator uint() const
    public static new implicit operator uint(DXPMSAMPLE ImpliedObject)
    {
        return ((uint)ImpliedObject);
    }
// C++ TO C# CONVERTER NOTE: This 'CopyFrom' method was converted from the original copy assignment operator:
// ORIGINAL LINE: uint operator =(const uint val)
    public new uint CopyFrom(uint val)
    {
        return this = (DXPMSAMPLE)val;
    }
// C++ TO C# CONVERTER WARNING: 'const' methods are not available in C#:
// ORIGINAL LINE: inline operator DXSAMPLE() const
    public static implicit operator DXSAMPLE(DXPMSAMPLE ImpliedObject)
    {
        return ((DXSAMPLE)ImpliedObject);
    }

} // DXPMSAMPLE
#else // !__cplusplus
public partial class DXBASESAMPLE
{
    public byte Blue;
    public byte Green;
    public byte Red;
    public byte Alpha;
}

public partial class DXSAMPLE
{
    public byte Blue;
    public byte Green;
    public byte Red;
    public byte Alpha;
}

public partial class DXPMSAMPLE
{
    public byte Blue;
    public byte Green;
    public byte Red;
    public byte Alpha;
}

#endif // !__cplusplus
public enum DXRUNTYPE
{
        DXRUNTYPE_CLEAR = 0,
    DXRUNTYPE_OPAQUE = 1,
    DXRUNTYPE_TRANS = 2,
    DXRUNTYPE_UNKNOWN = 3
}


// Ignore the definition used by MIDL for TLB generation
#if false
// typedef struct DXRUNINFO
//    {
//    ULONG Bitfields;
//    } 	DXRUNINFO;
// 
#endif // 0
public class DXRUNINFO
{
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public uint Type : 2; // Type
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public uint Count : 30; // Number of samples in run
}
public enum DXSFCREATE
{
        DXSF_FORMAT_IS_CLSID = 1 << 0,
    DXSF_NO_LAZY_DDRAW_LOCK = 1 << 1
}

public enum DXBLTOPTIONS
{
        DXBOF_DO_OVER = 1 << 0,
    DXBOF_DITHER = 1 << 1
}

#else // C style interface

    public class IDXSurfaceFactoryVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXSurfaceFactory * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXSurfaceFactory This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXSurfaceFactory * This);
        public delegate uint AddRefDelegate(@interface IDXSurfaceFactory This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXSurfaceFactory * This);
        public delegate uint ReleaseDelegate(@interface IDXSurfaceFactory This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateSurface)(interface IDXSurfaceFactory * This, object* pDirectDraw, const DDSURFACEDESC *pDDSurfaceDesc, const GUID *pFormatID, const DXBNDS *pBounds, uint dwFlags, object* punkOuter, REFIID riid, object**ppDXSurface);
        public delegate int CreateSurfaceDelegate(@interface IDXSurfaceFactory This, object pDirectDraw, DDSURFACEDESC pDDSurfaceDesc, GUID pFormatID, DXBNDS pBounds, uint dwFlags, object punkOuter, REFIID riid, object ppDXSurface[] UnnamedParameter);
        public CreateSurfaceDelegate CreateSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateFromDDSurface)(interface IDXSurfaceFactory * This, object* pDDrawSurface, const GUID *pFormatID, uint dwFlags, object* punkOuter, REFIID riid, object**ppDXSurface);
        public delegate int CreateFromDDSurfaceDelegate(@interface IDXSurfaceFactory This, object pDDrawSurface, GUID pFormatID, uint dwFlags, object punkOuter, REFIID riid, object ppDXSurface[] UnnamedParameter);
        public CreateFromDDSurfaceDelegate CreateFromDDSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LoadImage)(interface IDXSurfaceFactory * This, const char* pszFileName, object* pDirectDraw, const DDSURFACEDESC *pDDSurfaceDesc, const GUID *pFormatID, REFIID riid, object**ppDXSurface);
        public delegate int LoadImageDelegate(@interface IDXSurfaceFactory This, string pszFileName, object pDirectDraw, DDSURFACEDESC pDDSurfaceDesc, GUID pFormatID, REFIID riid, object ppDXSurface[] UnnamedParameter);
        public LoadImageDelegate LoadImage;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LoadImageFromStream)(interface IDXSurfaceFactory * This, IStream *pStream, object* pDirectDraw, const DDSURFACEDESC *pDDSurfaceDesc, const GUID *pFormatID, REFIID riid, object**ppDXSurface);
        public delegate int LoadImageFromStreamDelegate(@interface IDXSurfaceFactory This, IStream pStream, object pDirectDraw, DDSURFACEDESC pDDSurfaceDesc, GUID pFormatID, REFIID riid, object ppDXSurface[] UnnamedParameter);
        public LoadImageFromStreamDelegate LoadImageFromStream;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CopySurfaceToNewFormat)(interface IDXSurfaceFactory * This, interface IDXSurface *pSrc, object* pDirectDraw, const DDSURFACEDESC *pDDSurfaceDesc, const GUID *pDestFormatID, interface IDXSurface **ppNewSurface);
        public delegate int CopySurfaceToNewFormatDelegate(@interface IDXSurfaceFactory This, @interface IDXSurface pSrc, object pDirectDraw, DDSURFACEDESC pDDSurfaceDesc, GUID pDestFormatID, @interface IDXSurface[] ppNewSurface);
        public CopySurfaceToNewFormatDelegate CopySurfaceToNewFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *CreateD3DRMTexture)(interface IDXSurfaceFactory * This, interface IDXSurface *pSrc, object* pDirectDraw, object* pD3DRM3, REFIID riid, object**ppTexture3);
        public delegate int CreateD3DRMTextureDelegate(@interface IDXSurfaceFactory This, @interface IDXSurface pSrc, object pDirectDraw, object pD3DRM3, REFIID riid, object ppTexture3[] UnnamedParameter);
        public CreateD3DRMTextureDelegate CreateD3DRMTexture;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *BitBlt)(interface IDXSurfaceFactory * This, interface IDXSurface *pDest, const DXVEC *pPlacement, interface IDXSurface *pSrc, const DXBNDS *pClipBounds, uint dwFlags);
        public delegate int BitBltDelegate(@interface IDXSurfaceFactory This, @interface IDXSurface pDest, DXVEC pPlacement, @interface IDXSurface pSrc, DXBNDS pClipBounds, uint dwFlags);
        public BitBltDelegate BitBlt;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0266 */
/* [local] */ 

public enum DXSURFMODCOMPOP
{
        DXSURFMOD_COMP_OVER = 0,
    DXSURFMOD_COMP_ALPHA_MASK = 1,
    DXSURFMOD_COMP_MAX_VALID = 1
}

#else // C style interface

    public class IDXSurfaceModifierVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXSurfaceModifier * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXSurfaceModifier This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXSurfaceModifier * This);
        public delegate uint AddRefDelegate(@interface IDXSurfaceModifier This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXSurfaceModifier * This);
        public delegate uint ReleaseDelegate(@interface IDXSurfaceModifier This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetFillColor)(interface IDXSurfaceModifier * This, DXSAMPLE Color);
        public delegate int SetFillColorDelegate(@interface IDXSurfaceModifier This, DXSAMPLE Color);
        public SetFillColorDelegate SetFillColor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetFillColor)(interface IDXSurfaceModifier * This, DXSAMPLE *pColor);
        public delegate int GetFillColorDelegate(@interface IDXSurfaceModifier This, DXSAMPLE pColor);
        public GetFillColorDelegate GetFillColor;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBounds)(interface IDXSurfaceModifier * This, const DXBNDS *pBounds);
        public delegate int SetBoundsDelegate(@interface IDXSurfaceModifier This, DXBNDS pBounds);
        public SetBoundsDelegate SetBounds;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetBackground)(interface IDXSurfaceModifier * This, interface IDXSurface *pSurface);
        public delegate int SetBackgroundDelegate(@interface IDXSurfaceModifier This, @interface IDXSurface pSurface);
        public SetBackgroundDelegate SetBackground;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBackground)(interface IDXSurfaceModifier * This, interface IDXSurface **ppSurface);
        public delegate int GetBackgroundDelegate(@interface IDXSurfaceModifier This, @interface IDXSurface[] ppSurface);
        public GetBackgroundDelegate GetBackground;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetCompositeOperation)(interface IDXSurfaceModifier * This, DXSURFMODCOMPOP CompOp);
        public delegate int SetCompositeOperationDelegate(@interface IDXSurfaceModifier This, DXSURFMODCOMPOP CompOp);
        public SetCompositeOperationDelegate SetCompositeOperation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetCompositeOperation)(interface IDXSurfaceModifier * This, DXSURFMODCOMPOP *pCompOp);
        public delegate int GetCompositeOperationDelegate(@interface IDXSurfaceModifier This, DXSURFMODCOMPOP pCompOp);
        public GetCompositeOperationDelegate GetCompositeOperation;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetForeground)(interface IDXSurfaceModifier * This, interface IDXSurface *pSurface, bool bTile, const POINT *pOrigin);
        public delegate int SetForegroundDelegate(@interface IDXSurfaceModifier This, @interface IDXSurface pSurface, bool bTile, POINT pOrigin);
        public SetForegroundDelegate SetForeground;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetForeground)(interface IDXSurfaceModifier * This, interface IDXSurface **ppSurface, bool *pbTile, POINT *pOrigin);
        public delegate int GetForegroundDelegate(@interface IDXSurfaceModifier This, @interface IDXSurface[] ppSurface, ref bool pbTile, POINT pOrigin);
        public GetForegroundDelegate GetForeground;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOpacity)(interface IDXSurfaceModifier * This, float Opacity);
        public delegate int SetOpacityDelegate(@interface IDXSurfaceModifier This, float Opacity);
        public SetOpacityDelegate SetOpacity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOpacity)(interface IDXSurfaceModifier * This, float *pOpacity);
        public delegate int GetOpacityDelegate(@interface IDXSurfaceModifier This, ref float pOpacity);
        public GetOpacityDelegate GetOpacity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetLookup)(interface IDXSurfaceModifier * This, interface IDXLookupTable *pLookupTable);
        public delegate int SetLookupDelegate(@interface IDXSurfaceModifier This, @interface IDXLookupTable pLookupTable);
        public SetLookupDelegate SetLookup;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetLookup)(interface IDXSurfaceModifier * This, interface IDXLookupTable **ppLookupTable);
        public delegate int GetLookupDelegate(@interface IDXSurfaceModifier This, @interface IDXLookupTable[] ppLookupTable);
        public GetLookupDelegate GetLookup;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0267 */
/* [local] */ 

public enum DXSAMPLEFORMATENUM
{
        DXPF_FLAGSMASK = 0xffff0000,
    DXPF_NONPREMULT = 0x10000,
    DXPF_TRANSPARENCY = 0x20000,
    DXPF_TRANSLUCENCY = 0x40000,
    DXPF_2BITERROR = 0x200000,
    DXPF_3BITERROR = 0x300000,
    DXPF_4BITERROR = 0x400000,
    DXPF_5BITERROR = 0x500000,
    DXPF_ERRORMASK = 0x700000,
    DXPF_NONSTANDARD = 0,
    DXPF_PMARGB32 = 1 | DXPF_TRANSPARENCY | DXPF_TRANSLUCENCY,
    DXPF_ARGB32 = 2 | DXPF_NONPREMULT | DXPF_TRANSPARENCY | DXPF_TRANSLUCENCY,
    DXPF_ARGB4444 = 3 | DXPF_NONPREMULT | DXPF_TRANSPARENCY | DXPF_TRANSLUCENCY | DXPF_4BITERROR,
    DXPF_A8 = 4 | DXPF_TRANSPARENCY | DXPF_TRANSLUCENCY,
    DXPF_RGB32 = 5,
    DXPF_RGB24 = 6,
    DXPF_RGB565 = 7 | DXPF_3BITERROR,
    DXPF_RGB555 = 8 | DXPF_3BITERROR,
    DXPF_RGB8 = 9 | DXPF_5BITERROR,
    DXPF_ARGB1555 = 10 | DXPF_TRANSPARENCY | DXPF_3BITERROR,
    DXPF_RGB32_CK = DXPF_RGB32 | DXPF_TRANSPARENCY,
    DXPF_RGB24_CK = DXPF_RGB24 | DXPF_TRANSPARENCY,
    DXPF_RGB555_CK = DXPF_RGB555 | DXPF_TRANSPARENCY,
    DXPF_RGB565_CK = DXPF_RGB565 | DXPF_TRANSPARENCY,
    DXPF_RGB8_CK = DXPF_RGB8 | DXPF_TRANSPARENCY
}

public enum DXLOCKSURF
{
        DXLOCKF_READ = 0,
    DXLOCKF_READWRITE = 1 << 0,
    DXLOCKF_EXISTINGINFOONLY = 1 << 1,
    DXLOCKF_WANTRUNINFO = 1 << 2,
    DXLOCKF_NONPREMULT = 1 << 16,
    DXLOCKF_VALIDFLAGS = DXLOCKF_READWRITE | DXLOCKF_EXISTINGINFOONLY | DXLOCKF_WANTRUNINFO | DXLOCKF_NONPREMULT
}

public enum DXSURFSTATUS
{
        DXSURF_TRANSIENT = 1 << 0,
    DXSURF_READONLY = 1 << 1,
    DXSURF_VALIDFLAGS = DXSURF_TRANSIENT | DXSURF_READONLY
}

#else // C style interface

    public class IDXSurfaceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXSurface * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXSurface This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXSurface * This);
        public delegate uint AddRefDelegate(@interface IDXSurface This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXSurface * This);
        public delegate uint ReleaseDelegate(@interface IDXSurface This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetGenerationId)(interface IDXSurface * This, uint *pID);
        public delegate int GetGenerationIdDelegate(@interface IDXSurface This, ref uint pID);
        public GetGenerationIdDelegate GetGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IncrementGenerationId)(interface IDXSurface * This, bool bRefresh);
        public delegate int IncrementGenerationIdDelegate(@interface IDXSurface This, bool bRefresh);
        public IncrementGenerationIdDelegate IncrementGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetObjectSize)(interface IDXSurface * This, uint *pcbSize);
        public delegate int GetObjectSizeDelegate(@interface IDXSurface This, ref uint pcbSize);
        public GetObjectSizeDelegate GetObjectSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetPixelFormat)(interface IDXSurface * This, GUID *pFormatID, DXSAMPLEFORMATENUM *pSampleFormatEnum);
        public delegate int GetPixelFormatDelegate(@interface IDXSurface This, GUID pFormatID, DXSAMPLEFORMATENUM pSampleFormatEnum);
        public GetPixelFormatDelegate GetPixelFormat;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetBounds)(interface IDXSurface * This, DXBNDS *pBounds);
        public delegate int GetBoundsDelegate(@interface IDXSurface This, DXBNDS pBounds);
        public GetBoundsDelegate GetBounds;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetStatusFlags)(interface IDXSurface * This, uint *pdwStatusFlags);
        public delegate int GetStatusFlagsDelegate(@interface IDXSurface This, ref uint pdwStatusFlags);
        public GetStatusFlagsDelegate GetStatusFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetStatusFlags)(interface IDXSurface * This, uint dwStatusFlags);
        public delegate int SetStatusFlagsDelegate(@interface IDXSurface This, uint dwStatusFlags);
        public SetStatusFlagsDelegate SetStatusFlags;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LockSurface)(interface IDXSurface * This, const DXBNDS *pBounds, uint ulTimeOut, uint dwFlags, REFIID riid, object**ppPointer, uint *pulGenerationId);
        public delegate int LockSurfaceDelegate(@interface IDXSurface This, DXBNDS pBounds, uint ulTimeOut, uint dwFlags, REFIID riid, object ppPointer[] UnnamedParameter, ref uint pulGenerationId);
        public LockSurfaceDelegate LockSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetDirectDrawSurface)(interface IDXSurface * This, REFIID riid, object**ppSurface);
        public delegate int GetDirectDrawSurfaceDelegate(@interface IDXSurface This, REFIID riid, object ppSurface[] UnnamedParameter);
        public GetDirectDrawSurfaceDelegate GetDirectDrawSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetColorKey)(interface IDXSurface * This, DXSAMPLE *pColorKey);
        public delegate int GetColorKeyDelegate(@interface IDXSurface This, DXSAMPLE pColorKey);
        public GetColorKeyDelegate GetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetColorKey)(interface IDXSurface * This, DXSAMPLE ColorKey);
        public delegate int SetColorKeyDelegate(@interface IDXSurface This, DXSAMPLE ColorKey);
        public SetColorKeyDelegate SetColorKey;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *LockSurfaceDC)(interface IDXSurface * This, const DXBNDS *pBounds, uint ulTimeOut, uint dwFlags, interface IDXDCLock **ppDCLock);
        public delegate int LockSurfaceDCDelegate(@interface IDXSurface This, DXBNDS pBounds, uint ulTimeOut, uint dwFlags, @interface IDXDCLock[] ppDCLock);
        public LockSurfaceDCDelegate LockSurfaceDC;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetAppData)(interface IDXSurface * This, System.IntPtr dwAppData);
        public delegate int SetAppDataDelegate(@interface IDXSurface This, IntPtr dwAppData);
        public SetAppDataDelegate SetAppData;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetAppData)(interface IDXSurface * This, System.IntPtr *pdwAppData);
        public delegate int GetAppDataDelegate(@interface IDXSurface This, IntPtr pdwAppData);
        public GetAppDataDelegate GetAppData;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXSurfaceInitVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXSurfaceInit * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXSurfaceInit This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXSurfaceInit * This);
        public delegate uint AddRefDelegate(@interface IDXSurfaceInit This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXSurfaceInit * This);
        public delegate uint ReleaseDelegate(@interface IDXSurfaceInit This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitSurface)(interface IDXSurfaceInit * This, object* pDirectDraw, const DDSURFACEDESC *pDDSurfaceDesc, const GUID *pFormatID, const DXBNDS *pBounds, uint dwFlags);
        public delegate int InitSurfaceDelegate(@interface IDXSurfaceInit This, object pDirectDraw, DDSURFACEDESC pDDSurfaceDesc, GUID pFormatID, DXBNDS pBounds, uint dwFlags);
        public InitSurfaceDelegate InitSurface;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXARGBSurfaceInitVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXARGBSurfaceInit * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXARGBSurfaceInit This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXARGBSurfaceInit * This);
        public delegate uint AddRefDelegate(@interface IDXARGBSurfaceInit This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXARGBSurfaceInit * This);
        public delegate uint ReleaseDelegate(@interface IDXARGBSurfaceInit This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitSurface)(interface IDXARGBSurfaceInit * This, object* pDirectDraw, const DDSURFACEDESC *pDDSurfaceDesc, const GUID *pFormatID, const DXBNDS *pBounds, uint dwFlags);
        public delegate int InitSurfaceDelegate(@interface IDXARGBSurfaceInit This, object pDirectDraw, DDSURFACEDESC pDDSurfaceDesc, GUID pFormatID, DXBNDS pBounds, uint dwFlags);
        public InitSurfaceDelegate InitSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitFromDDSurface)(interface IDXARGBSurfaceInit * This, object* pDDrawSurface, const GUID *pFormatID, uint dwFlags);
        public delegate int InitFromDDSurfaceDelegate(@interface IDXARGBSurfaceInit This, object pDDrawSurface, GUID pFormatID, uint dwFlags);
        public InitFromDDSurfaceDelegate InitFromDDSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *InitFromRawSurface)(interface IDXARGBSurfaceInit * This, interface IDXRawSurface *pRawSurface);
        public delegate int InitFromRawSurfaceDelegate(@interface IDXARGBSurfaceInit This, @interface IDXRawSurface pRawSurface);
        public InitFromRawSurfaceDelegate InitFromRawSurface;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0270 */
/* [local] */ 

public class tagDXNATIVETYPEINFO
{
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pCurrentData;
    public byte pCurrentData;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pFirstByte;
    public byte pFirstByte;
    public int lPitch;
    public uint dwColorKey;
}

public class tagDXPACKEDRECTDESC
{
    public DXBASESAMPLE pSamples;
    public bool bPremult;
    public RECT rect = new RECT();
    public int lRowPadding;
}

public class tagDXOVERSAMPLEDESC
{
    public POINT p = new POINT();
    public DXPMSAMPLE Color = new DXPMSAMPLE();
}

#else // C style interface

    public class IDXARGBReadPtrVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXARGBReadPtr * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXARGBReadPtr This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXARGBReadPtr * This);
        public delegate uint AddRefDelegate(@interface IDXARGBReadPtr This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXARGBReadPtr * This);
        public delegate uint ReleaseDelegate(@interface IDXARGBReadPtr This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSurface)(interface IDXARGBReadPtr * This, REFIID riid, object**ppSurface);
        public delegate int GetSurfaceDelegate(@interface IDXARGBReadPtr This, REFIID riid, object ppSurface[] UnnamedParameter);
        public GetSurfaceDelegate GetSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: DXSAMPLEFORMATENUM(STDMETHODCALLTYPE *GetNativeType)(interface IDXARGBReadPtr * This, tagDXNATIVETYPEINFO *pInfo);
        public delegate DXSAMPLEFORMATENUM GetNativeTypeDelegate(@interface IDXARGBReadPtr This, tagDXNATIVETYPEINFO pInfo);
        public GetNativeTypeDelegate GetNativeType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *Move)(interface IDXARGBReadPtr * This, int cSamples);
        public delegate void MoveDelegate(@interface IDXARGBReadPtr This, int cSamples);
        public MoveDelegate Move;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *MoveToRow)(interface IDXARGBReadPtr * This, uint y);
        public delegate void MoveToRowDelegate(@interface IDXARGBReadPtr This, uint y);
        public MoveToRowDelegate MoveToRow;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *MoveToXY)(interface IDXARGBReadPtr * This, uint x, uint y);
        public delegate void MoveToXYDelegate(@interface IDXARGBReadPtr This, uint x, uint y);
        public MoveToXYDelegate MoveToXY;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *MoveAndGetRunInfo)(interface IDXARGBReadPtr * This, uint Row, const DXRUNINFO **ppInfo);
        public delegate uint MoveAndGetRunInfoDelegate(@interface IDXARGBReadPtr This, uint Row, DXRUNINFO[] ppInfo);
        public MoveAndGetRunInfoDelegate MoveAndGetRunInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: DXSAMPLE *(STDMETHODCALLTYPE *Unpack)(interface IDXARGBReadPtr * This, DXSAMPLE *pSamples, uint cSamples, bool bMove);
        public delegate DXSAMPLE UnpackDelegate(@interface IDXARGBReadPtr This, DXSAMPLE pSamples, uint cSamples, bool bMove);
        public UnpackDelegate Unpack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: DXPMSAMPLE *(STDMETHODCALLTYPE *UnpackPremult)(interface IDXARGBReadPtr * This, DXPMSAMPLE *pSamples, uint cSamples, bool bMove);
        public delegate DXPMSAMPLE UnpackPremultDelegate(@interface IDXARGBReadPtr This, DXPMSAMPLE pSamples, uint cSamples, bool bMove);
        public UnpackPremultDelegate UnpackPremult;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *UnpackRect)(interface IDXARGBReadPtr * This, const tagDXPACKEDRECTDESC *pRectDesc);
        public delegate void UnpackRectDelegate(@interface IDXARGBReadPtr This, tagDXPACKEDRECTDESC pRectDesc);
        public UnpackRectDelegate UnpackRect;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXARGBReadWritePtrVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXARGBReadWritePtr * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXARGBReadWritePtr This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXARGBReadWritePtr * This);
        public delegate uint AddRefDelegate(@interface IDXARGBReadWritePtr This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXARGBReadWritePtr * This);
        public delegate uint ReleaseDelegate(@interface IDXARGBReadWritePtr This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSurface)(interface IDXARGBReadWritePtr * This, REFIID riid, object**ppSurface);
        public delegate int GetSurfaceDelegate(@interface IDXARGBReadWritePtr This, REFIID riid, object ppSurface[] UnnamedParameter);
        public GetSurfaceDelegate GetSurface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: DXSAMPLEFORMATENUM(STDMETHODCALLTYPE *GetNativeType)(interface IDXARGBReadWritePtr * This, tagDXNATIVETYPEINFO *pInfo);
        public delegate DXSAMPLEFORMATENUM GetNativeTypeDelegate(@interface IDXARGBReadWritePtr This, tagDXNATIVETYPEINFO pInfo);
        public GetNativeTypeDelegate GetNativeType;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *Move)(interface IDXARGBReadWritePtr * This, int cSamples);
        public delegate void MoveDelegate(@interface IDXARGBReadWritePtr This, int cSamples);
        public MoveDelegate Move;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *MoveToRow)(interface IDXARGBReadWritePtr * This, uint y);
        public delegate void MoveToRowDelegate(@interface IDXARGBReadWritePtr This, uint y);
        public MoveToRowDelegate MoveToRow;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *MoveToXY)(interface IDXARGBReadWritePtr * This, uint x, uint y);
        public delegate void MoveToXYDelegate(@interface IDXARGBReadWritePtr This, uint x, uint y);
        public MoveToXYDelegate MoveToXY;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *MoveAndGetRunInfo)(interface IDXARGBReadWritePtr * This, uint Row, const DXRUNINFO **ppInfo);
        public delegate uint MoveAndGetRunInfoDelegate(@interface IDXARGBReadWritePtr This, uint Row, DXRUNINFO[] ppInfo);
        public MoveAndGetRunInfoDelegate MoveAndGetRunInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: DXSAMPLE *(STDMETHODCALLTYPE *Unpack)(interface IDXARGBReadWritePtr * This, DXSAMPLE *pSamples, uint cSamples, bool bMove);
        public delegate DXSAMPLE UnpackDelegate(@interface IDXARGBReadWritePtr This, DXSAMPLE pSamples, uint cSamples, bool bMove);
        public UnpackDelegate Unpack;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: DXPMSAMPLE *(STDMETHODCALLTYPE *UnpackPremult)(interface IDXARGBReadWritePtr * This, DXPMSAMPLE *pSamples, uint cSamples, bool bMove);
        public delegate DXPMSAMPLE UnpackPremultDelegate(@interface IDXARGBReadWritePtr This, DXPMSAMPLE pSamples, uint cSamples, bool bMove);
        public UnpackPremultDelegate UnpackPremult;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *UnpackRect)(interface IDXARGBReadWritePtr * This, const tagDXPACKEDRECTDESC *pRectDesc);
        public delegate void UnpackRectDelegate(@interface IDXARGBReadWritePtr This, tagDXPACKEDRECTDESC pRectDesc);
        public UnpackRectDelegate UnpackRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *PackAndMove)(interface IDXARGBReadWritePtr * This, const DXSAMPLE *pSamples, uint cSamples);
        public delegate void PackAndMoveDelegate(@interface IDXARGBReadWritePtr This, DXSAMPLE pSamples, uint cSamples);
        public PackAndMoveDelegate PackAndMove;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *PackPremultAndMove)(interface IDXARGBReadWritePtr * This, const DXPMSAMPLE *pSamples, uint cSamples);
        public delegate void PackPremultAndMoveDelegate(@interface IDXARGBReadWritePtr This, DXPMSAMPLE pSamples, uint cSamples);
        public PackPremultAndMoveDelegate PackPremultAndMove;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *PackRect)(interface IDXARGBReadWritePtr * This, const tagDXPACKEDRECTDESC *pRectDesc);
        public delegate void PackRectDelegate(@interface IDXARGBReadWritePtr This, tagDXPACKEDRECTDESC pRectDesc);
        public PackRectDelegate PackRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *CopyAndMoveBoth)(interface IDXARGBReadWritePtr * This, DXBASESAMPLE *pScratchBuffer, interface IDXARGBReadPtr *pSrc, uint cSamples, bool bIsOpaque);
        public delegate void CopyAndMoveBothDelegate(@interface IDXARGBReadWritePtr This, DXBASESAMPLE pScratchBuffer, @interface IDXARGBReadPtr pSrc, uint cSamples, bool bIsOpaque);
        public CopyAndMoveBothDelegate CopyAndMoveBoth;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *CopyRect)(interface IDXARGBReadWritePtr * This, DXBASESAMPLE *pScratchBuffer, const RECT *pDestRect, interface IDXARGBReadPtr *pSrc, const POINT *pSrcOrigin, bool bIsOpaque);
        public delegate void CopyRectDelegate(@interface IDXARGBReadWritePtr This, DXBASESAMPLE pScratchBuffer, RECT pDestRect, @interface IDXARGBReadPtr pSrc, POINT pSrcOrigin, bool bIsOpaque);
        public CopyRectDelegate CopyRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *FillAndMove)(interface IDXARGBReadWritePtr * This, DXBASESAMPLE *pScratchBuffer, DXPMSAMPLE SampVal, uint cSamples, bool bDoOver);
        public delegate void FillAndMoveDelegate(@interface IDXARGBReadWritePtr This, DXBASESAMPLE pScratchBuffer, DXPMSAMPLE SampVal, uint cSamples, bool bDoOver);
        public FillAndMoveDelegate FillAndMove;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *FillRect)(interface IDXARGBReadWritePtr * This, const RECT *pRect, DXPMSAMPLE SampVal, bool bDoOver);
        public delegate void FillRectDelegate(@interface IDXARGBReadWritePtr This, RECT pRect, DXPMSAMPLE SampVal, bool bDoOver);
        public FillRectDelegate FillRect;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *OverSample)(interface IDXARGBReadWritePtr * This, const tagDXOVERSAMPLEDESC *pOverDesc);
        public delegate void OverSampleDelegate(@interface IDXARGBReadWritePtr This, tagDXOVERSAMPLEDESC pOverDesc);
        public OverSampleDelegate OverSample;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: void(STDMETHODCALLTYPE *OverArrayAndMove)(interface IDXARGBReadWritePtr * This, DXBASESAMPLE *pScratchBuffer, const DXPMSAMPLE *pSrc, uint cSamples);
        public delegate void OverArrayAndMoveDelegate(@interface IDXARGBReadWritePtr This, DXBASESAMPLE pScratchBuffer, DXPMSAMPLE pSrc, uint cSamples);
        public OverArrayAndMoveDelegate OverArrayAndMove;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXDCLockVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXDCLock * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXDCLock This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXDCLock * This);
        public delegate uint AddRefDelegate(@interface IDXDCLock This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXDCLock * This);
        public delegate uint ReleaseDelegate(@interface IDXDCLock This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: System.IntPtr(STDMETHODCALLTYPE *GetDC)(interface IDXDCLock * This);
        public delegate IntPtr GetDCDelegate(@interface IDXDCLock This);
        public GetDCDelegate GetDC;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXTScaleOutputVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXTScaleOutput * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXTScaleOutput This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXTScaleOutput * This);
        public delegate uint AddRefDelegate(@interface IDXTScaleOutput This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXTScaleOutput * This);
        public delegate uint ReleaseDelegate(@interface IDXTScaleOutput This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputSize)(interface IDXTScaleOutput * This, const SIZE OutSize, bool bMaintainAspect);
        public delegate int SetOutputSizeDelegate(@interface IDXTScaleOutput This, SIZE OutSize, bool bMaintainAspect);
        public SetOutputSizeDelegate SetOutputSize;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXGradientVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXGradient * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXGradient This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXGradient * This);
        public delegate uint AddRefDelegate(@interface IDXGradient This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXGradient * This);
        public delegate uint ReleaseDelegate(@interface IDXGradient This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetOutputSize)(interface IDXGradient * This, const SIZE OutSize, bool bMaintainAspect);
        public delegate int SetOutputSizeDelegate(@interface IDXGradient This, SIZE OutSize, bool bMaintainAspect);
        public SetOutputSizeDelegate SetOutputSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetGradient)(interface IDXGradient * This, DXSAMPLE StartColor, DXSAMPLE EndColor, bool bHorizontal);
        public delegate int SetGradientDelegate(@interface IDXGradient This, DXSAMPLE StartColor, DXSAMPLE EndColor, bool bHorizontal);
        public SetGradientDelegate SetGradient;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetOutputSize)(interface IDXGradient * This, SIZE *pOutSize);
        public delegate int GetOutputSizeDelegate(@interface IDXGradient This, SIZE pOutSize);
        public GetOutputSizeDelegate GetOutputSize;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXTScaleVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXTScale * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXTScale This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXTScale * This);
        public delegate uint AddRefDelegate(@interface IDXTScale This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXTScale * This);
        public delegate uint ReleaseDelegate(@interface IDXTScale This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetScales)(interface IDXTScale * This, float Scales[2]);
        public delegate int SetScalesDelegate(@interface IDXTScale This, float[] Scales);
        public SetScalesDelegate SetScales;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetScales)(interface IDXTScale * This, float Scales[2]);
        public delegate int GetScalesDelegate(@interface IDXTScale This, float[] Scales);
        public GetScalesDelegate GetScales;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ScaleFitToSize)(interface IDXTScale * This, DXBNDS *pClipBounds, SIZE FitToSize, bool bMaintainAspect);
        public delegate int ScaleFitToSizeDelegate(@interface IDXTScale This, DXBNDS pClipBounds, SIZE FitToSize, bool bMaintainAspect);
        public ScaleFitToSizeDelegate ScaleFitToSize;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0276 */
/* [local] */ 

public enum DISPIDDXEFFECT
{
        DISPID_DXECAPABILITIES = 10000,
    DISPID_DXEPROGRESS = DISPID_DXECAPABILITIES + 1,
    DISPID_DXESTEP = DISPID_DXEPROGRESS + 1,
    DISPID_DXEDURATION = DISPID_DXESTEP + 1,
    DISPID_DXE_NEXT_ID = DISPID_DXEDURATION + 1
}

public enum DXEFFECTTYPE
{
        DXTET_PERIODIC = 1 << 0,
    DXTET_MORPH = 1 << 1
}

#else // C style interface

    public class IDXEffectVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXEffect * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXEffect This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXEffect * This);
        public delegate uint AddRefDelegate(@interface IDXEffect This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXEffect * This);
        public delegate uint ReleaseDelegate(@interface IDXEffect This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface IDXEffect * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface IDXEffect This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface IDXEffect * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface IDXEffect This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface IDXEffect * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface IDXEffect This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface IDXEffect * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface IDXEffect This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Capabilities)(interface IDXEffect * This, int *pVal);
        public delegate int get_CapabilitiesDelegate(@interface IDXEffect This, ref int pVal);
        public get_CapabilitiesDelegate get_Capabilities;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Progress)(interface IDXEffect * This, float *pVal);
        public delegate int get_ProgressDelegate(@interface IDXEffect This, ref float pVal);
        public get_ProgressDelegate get_Progress;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Progress)(interface IDXEffect * This, float newVal);
        public delegate int put_ProgressDelegate(@interface IDXEffect This, float newVal);
        public put_ProgressDelegate put_Progress;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_StepResolution)(interface IDXEffect * This, float *pVal);
        public delegate int get_StepResolutionDelegate(@interface IDXEffect This, ref float pVal);
        public get_StepResolutionDelegate get_StepResolution;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Duration)(interface IDXEffect * This, float *pVal);
        public delegate int get_DurationDelegate(@interface IDXEffect This, ref float pVal);
        public get_DurationDelegate get_Duration;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Duration)(interface IDXEffect * This, float newVal);
        public delegate int put_DurationDelegate(@interface IDXEffect This, float newVal);
        public put_DurationDelegate put_Duration;

//        END_INTERFACE
    }

#else // C style interface

    public class IDXLookupTableVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXLookupTable * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXLookupTable This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXLookupTable * This);
        public delegate uint AddRefDelegate(@interface IDXLookupTable This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXLookupTable * This);
        public delegate uint ReleaseDelegate(@interface IDXLookupTable This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetGenerationId)(interface IDXLookupTable * This, uint *pID);
        public delegate int GetGenerationIdDelegate(@interface IDXLookupTable This, ref uint pID);
        public GetGenerationIdDelegate GetGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IncrementGenerationId)(interface IDXLookupTable * This, bool bRefresh);
        public delegate int IncrementGenerationIdDelegate(@interface IDXLookupTable This, bool bRefresh);
        public IncrementGenerationIdDelegate IncrementGenerationId;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetObjectSize)(interface IDXLookupTable * This, uint *pcbSize);
        public delegate int GetObjectSizeDelegate(@interface IDXLookupTable This, ref uint pcbSize);
        public GetObjectSizeDelegate GetObjectSize;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTables)(interface IDXLookupTable * This, byte RedLUT[256], byte GreenLUT[256], byte BlueLUT[256], byte AlphaLUT[256]);
        public delegate int GetTablesDelegate(@interface IDXLookupTable This, byte[] RedLUT, byte[] GreenLUT, byte[] BlueLUT, byte[] AlphaLUT);
        public GetTablesDelegate GetTables;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *IsChannelIdentity)(interface IDXLookupTable * This, DXBASESAMPLE *pSampleBools);
        public delegate int IsChannelIdentityDelegate(@interface IDXLookupTable This, DXBASESAMPLE pSampleBools);
        public IsChannelIdentityDelegate IsChannelIdentity;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIndexValues)(interface IDXLookupTable * This, uint Index, DXBASESAMPLE *pSample);
        public delegate int GetIndexValuesDelegate(@interface IDXLookupTable This, uint Index, DXBASESAMPLE pSample);
        public GetIndexValuesDelegate GetIndexValues;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *ApplyTables)(interface IDXLookupTable * This, DXSAMPLE *pSamples, uint cSamples);
        public delegate int ApplyTablesDelegate(@interface IDXLookupTable This, DXSAMPLE pSamples, uint cSamples);
        public ApplyTablesDelegate ApplyTables;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0278 */
/* [local] */ 

public class DXRAWSURFACEINFO
{
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pFirstByte;
    public byte pFirstByte;
    public int lPitch;
    public uint Width;
    public uint Height;
    public readonly GUID pPixelFormat;
    public IntPtr hdc;
    public uint dwColorKey;
    public DXBASESAMPLE pPalette;
}

#else // C style interface

    public class IDXRawSurfaceVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IDXRawSurface * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IDXRawSurface This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IDXRawSurface * This);
        public delegate uint AddRefDelegate(@interface IDXRawSurface This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IDXRawSurface * This);
        public delegate uint ReleaseDelegate(@interface IDXRawSurface This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetSurfaceInfo)(interface IDXRawSurface * This, DXRAWSURFACEINFO *pSurfaceInfo);
        public delegate int GetSurfaceInfoDelegate(@interface IDXRawSurface This, DXRAWSURFACEINFO pSurfaceInfo);
        public GetSurfaceInfoDelegate GetSurfaceInfo;

//        END_INTERFACE
    }

#else // C style interface

    public class IHTMLDXTransformVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface IHTMLDXTransform * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface IHTMLDXTransform This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface IHTMLDXTransform * This);
        public delegate uint AddRefDelegate(@interface IHTMLDXTransform This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface IHTMLDXTransform * This);
        public delegate uint ReleaseDelegate(@interface IHTMLDXTransform This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *SetHostUrl)(interface IHTMLDXTransform * This, char* bstrHostUrl);
        public delegate int SetHostUrlDelegate(@interface IHTMLDXTransform This, ref string bstrHostUrl);
        public SetHostUrlDelegate SetHostUrl;

//        END_INTERFACE
    }





/* interface __MIDL_itf_dxtrans_0280 */
/* [local] */ 

public enum DXTFILTER_STATUS
{
        DXTFILTER_STATUS_Stopped = 0,
    DXTFILTER_STATUS_Applied = DXTFILTER_STATUS_Stopped + 1,
    DXTFILTER_STATUS_Playing = DXTFILTER_STATUS_Applied + 1,
    DXTFILTER_STATUS_MAX = DXTFILTER_STATUS_Playing + 1
}

public enum DXTFILTER_DISPID
{
        DISPID_DXTFilter_Percent = 1,
    DISPID_DXTFilter_Duration = DISPID_DXTFilter_Percent + 1,
    DISPID_DXTFilter_Enabled = DISPID_DXTFilter_Duration + 1,
    DISPID_DXTFilter_Status = DISPID_DXTFilter_Enabled + 1,
    DISPID_DXTFilter_Apply = DISPID_DXTFilter_Status + 1,
    DISPID_DXTFilter_Play = DISPID_DXTFilter_Apply + 1,
    DISPID_DXTFilter_Stop = DISPID_DXTFilter_Play + 1,
    DISPID_DXTFilter_MAX = DISPID_DXTFilter_Stop + 1
}

#else // C style interface

    public class ICSSFilterDispatchVtbl
    {
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: BEGIN_INTERFACE int(STDMETHODCALLTYPE *QueryInterface)(interface ICSSFilterDispatch * This, REFIID riid, object**ppvObject);
        public delegate BEGIN_INTERFACE int QueryInterfaceDelegate(@interface ICSSFilterDispatch This, REFIID riid, object ppvObject[] UnnamedParameter);
        public QueryInterfaceDelegate QueryInterface;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *AddRef)(interface ICSSFilterDispatch * This);
        public delegate uint AddRefDelegate(@interface ICSSFilterDispatch This);
        public AddRefDelegate AddRef;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: uint(STDMETHODCALLTYPE *Release)(interface ICSSFilterDispatch * This);
        public delegate uint ReleaseDelegate(@interface ICSSFilterDispatch This);
        public ReleaseDelegate Release;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfoCount)(interface ICSSFilterDispatch * This, uint *pctinfo);
        public delegate int GetTypeInfoCountDelegate(@interface ICSSFilterDispatch This, ref uint pctinfo);
        public GetTypeInfoCountDelegate GetTypeInfoCount;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetTypeInfo)(interface ICSSFilterDispatch * This, uint iTInfo, uint lcid, ITypeInfo **ppTInfo);
        public delegate int GetTypeInfoDelegate(@interface ICSSFilterDispatch This, uint iTInfo, uint lcid, ITypeInfo[] ppTInfo);
        public GetTypeInfoDelegate GetTypeInfo;

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *GetIDsOfNames)(interface ICSSFilterDispatch * This, REFIID riid, LPOLESTR *rgszNames, uint cNames, uint lcid, DISPID *rgDispId);
        public delegate int GetIDsOfNamesDelegate(@interface ICSSFilterDispatch This, REFIID riid, LPOLESTR rgszNames, uint cNames, uint lcid, DISPID rgDispId);
        public GetIDsOfNamesDelegate GetIDsOfNames;

        /* [local] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Invoke)(interface ICSSFilterDispatch * This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS *pDispParams, VARIANT *pVarResult, EXCEPINFO *pExcepInfo, uint *puArgErr);
        public delegate int InvokeDelegate(@interface ICSSFilterDispatch This, DISPID dispIdMember, REFIID riid, uint lcid, ushort wFlags, DISPPARAMS pDispParams, VARIANT pVarResult, EXCEPINFO pExcepInfo, ref uint puArgErr);
        public InvokeDelegate Invoke;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Percent)(interface ICSSFilterDispatch * This, float *pVal);
        public delegate int get_PercentDelegate(@interface ICSSFilterDispatch This, ref float pVal);
        public get_PercentDelegate get_Percent;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Percent)(interface ICSSFilterDispatch * This, float newVal);
        public delegate int put_PercentDelegate(@interface ICSSFilterDispatch This, float newVal);
        public put_PercentDelegate put_Percent;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Duration)(interface ICSSFilterDispatch * This, float *pVal);
        public delegate int get_DurationDelegate(@interface ICSSFilterDispatch This, ref float pVal);
        public get_DurationDelegate get_Duration;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Duration)(interface ICSSFilterDispatch * This, float newVal);
        public delegate int put_DurationDelegate(@interface ICSSFilterDispatch This, float newVal);
        public put_DurationDelegate put_Duration;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Enabled)(interface ICSSFilterDispatch * This, VARIANT_BOOL *pfVal);
        public delegate int get_EnabledDelegate(@interface ICSSFilterDispatch This, VARIANT_BOOL pfVal);
        public get_EnabledDelegate get_Enabled;

        /* [id][propput] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *put_Enabled)(interface ICSSFilterDispatch * This, VARIANT_BOOL fVal);
        public delegate int put_EnabledDelegate(@interface ICSSFilterDispatch This, VARIANT_BOOL fVal);
        public put_EnabledDelegate put_Enabled;

        /* [id][propget] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *get_Status)(interface ICSSFilterDispatch * This, DXTFILTER_STATUS *peVal);
        public delegate int get_StatusDelegate(@interface ICSSFilterDispatch This, DXTFILTER_STATUS peVal);
        public get_StatusDelegate get_Status;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Apply)(interface ICSSFilterDispatch * This);
        public delegate int ApplyDelegate(@interface ICSSFilterDispatch This);
        public ApplyDelegate Apply;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Play)(interface ICSSFilterDispatch * This, VARIANT varDuration);
        public delegate int PlayDelegate(@interface ICSSFilterDispatch This, VARIANT varDuration);
        public PlayDelegate Play;

        /* [id] */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: int(STDMETHODCALLTYPE *Stop)(interface ICSSFilterDispatch * This);
        public delegate int StopDelegate(@interface ICSSFilterDispatch This);
        public StopDelegate Stop;

//        END_INTERFACE
    }