using System;

/*++

Copyright (c) Microsoft Corporation. All rights reserved.

Module Name:

    ksproxy.h

Abstract:

    Interface definitions for WDM-CSA proxy filters.

--*/


#if __cplusplus
#endif

#if _KSDDK_
#define KSDDKAPI
#else // !_KSDDK_
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDDKAPI DECLSPEC_IMPORT
#define KSDDKAPI
#endif // _KSDDK_

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsObject 0x423c13a2L, 0x2070, 0x11d0, 0x9e, 0xf7, 0x00, 0xaa, 0x00, 0xa2, 0x16, 0xa1

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsPinEx 0x7bb38260L, 0xd19c, 0x11d2, 0xb3, 0x8a, 0x00, 0xa0, 0xc9, 0x5e, 0xc2, 0x2e

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsPin 0xb61178d1L, 0xa2d9, 0x11cf, 0x9e, 0x53, 0x00, 0xaa, 0x00, 0xa2, 0x16, 0xa1

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsPinPipe 0xe539cd90L, 0xa8b4, 0x11d1, 0x81, 0x89, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsDataTypeHandler 0x5ffbaa02L, 0x49a3, 0x11d0, 0x9f, 0x36, 0x00, 0xaa, 0x00, 0xa2, 0x16, 0xa1

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsDataTypeCompletion 0x827D1A0EL, 0x0F73, 0x11D2, 0xB2, 0x7A, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsInterfaceHandler 0xD3ABC7E0L, 0x9A61, 0x11D0, 0xA4, 0x0D, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsClockPropertySet 0x5C5CBD84L, 0xE755, 0x11D0, 0xAC, 0x18, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsAllocator 0x8da64899L, 0xc0d9, 0x11d0, 0x84, 0x13, 0x00, 0x00, 0xf8, 0x22, 0xfe, 0x8a

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsAllocatorEx 0x091bb63aL, 0x603f, 0x11d1, 0xb0, 0x67, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsPropertySet 0x31EFAC30L, 0x515C, 0x11d0, 0xA9, 0xAA, 0x00, 0xAA, 0x00, 0x61, 0xBE, 0x93

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsTopology 0x28F54683L, 0x06FD, 0x11D2, 0xB2, 0x7A, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsControl 0x28F54685L, 0x06FD, 0x11D2, 0xB2, 0x7A, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsAggregateControl 0x7F40EAC0L, 0x3947, 0x11D2, 0x87, 0x4E, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CLSID_Proxy 0x17CCA71BL, 0xECD7, 0x11D0, 0xB9, 0x08, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

#if _KS_

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if !__cplusplus || _MSC_VER < 1100
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsObject);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsPin);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsPinEx);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsPinPipe);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsDataTypeHandler);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsDataTypeCompletion);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsInterfaceHandler);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsClockPropertySet);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsAllocator);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDEX(IID_IKsAllocatorEx);

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IKsQualityForwarder KSCATEGORY_QUALITY
#define IID_IKsQualityForwarder
#endif // !defined(__cplusplus) || _MSC_VER < 1100

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsQualityForwarder STATIC_KSCATEGORY_QUALITY
#define STATIC_IID_IKsQualityForwarder

public enum KSALLOCATORMODE
{
    KsAllocatorMode_User,
    KsAllocatorMode_Kernel
}


public enum FRAMING_PROP
{
    FramingProp_Uninitialized,
    FramingProp_None,
    FramingProp_Old,
    FramingProp_Ex
}



public enum FRAMING_CACHE_OPS
{
    Framing_Cache_Update, // request to bypass cache when read/write
    Framing_Cache_ReadLast,
    Framing_Cache_ReadOrig,
    Framing_Cache_Write
}


public class OPTIMAL_WEIGHT_TOTALS
{
    public long MinTotalNominator;
    public long MaxTotalNominator;
    public long TotalDenominator;
}

// forward declaration


// 
// allocators strategy is defined by graph manager
// 
#define AllocatorStrategy_DontCare

// 
// what to optimize
// 
#define AllocatorStrategy_MinimizeNumberOfFrames
#define AllocatorStrategy_MinimizeFrameSize
#define AllocatorStrategy_MinimizeNumberOfAllocators
#define AllocatorStrategy_MaximizeSpeed

// 
// factors (flags) defining the Pipes properties
// 
#define PipeFactor_None
#define PipeFactor_UserModeUpstream
#define PipeFactor_UserModeDownstream
#define PipeFactor_MemoryTypes
#define PipeFactor_Flags
#define PipeFactor_PhysicalRanges
#define PipeFactor_OptimalRanges
#define PipeFactor_FixedCompression
#define PipeFactor_UnknownCompression

#define PipeFactor_Buffers
#define PipeFactor_Align

#define PipeFactor_PhysicalEnd
#define PipeFactor_LogicalEnd



public enum PIPE_STATE
{
    PipeState_DontCare,
    PipeState_RangeNotFixed,
    PipeState_RangeFixed,
    PipeState_CompressionUnknown,
    PipeState_Finalized
}


// 
// pipe dimensions relative to BeginPin.
// 

public class _PIPE_DIMENSIONS
{
    public KS_COMPRESSION AllocatorPin = new KS_COMPRESSION();
    public KS_COMPRESSION MaxExpansionPin = new KS_COMPRESSION();
    public KS_COMPRESSION EndPin = new KS_COMPRESSION();
}


public enum PIPE_ALLOCATOR_PLACE
{
    Pipe_Allocator_None,
    Pipe_Allocator_FirstPin,
    Pipe_Allocator_LastPin,
    Pipe_Allocator_MiddlePin
}



public enum KS_LogicalMemoryType
{
    KS_MemoryTypeDontCare = 0,
    KS_MemoryTypeKernelPaged,
    KS_MemoryTypeKernelNonPaged,
    KS_MemoryTypeDeviceHostMapped,
    KS_MemoryTypeDeviceSpecific,
    KS_MemoryTypeUser,
    KS_MemoryTypeAnyHost
}




public class _PIPE_TERMINATION
{
    public uint Flags;
    public uint OutsideFactors;
    public uint Weigth; // outside weight
    public KS_FRAMING_RANGE PhysicalRange = new KS_FRAMING_RANGE();
    public KS_FRAMING_RANGE_WEIGHTED OptimalRange = new KS_FRAMING_RANGE_WEIGHTED();
    public KS_COMPRESSION Compression = new KS_COMPRESSION(); // relative to the connected pin on a neighboring filter.
}


// 
// extended allocator properties 
// 
public class _ALLOCATOR_PROPERTIES_EX
{
    public int cBuffers;
    public int cbBuffer;
    public int cbAlign;
    public int cbPrefix;
// new part
    public GUID MemoryType = new GUID();
    public GUID BusType = new GUID(); // one of the buses this pipe is using
    public PIPE_STATE State;
    public _PIPE_TERMINATION Input = new _PIPE_TERMINATION();
    public _PIPE_TERMINATION Output = new _PIPE_TERMINATION();
    public uint Strategy;
    public uint Flags;
    public uint Weight;
    public KS_LogicalMemoryType LogicalMemoryType;
    public PIPE_ALLOCATOR_PLACE AllocatorPlace;
    public _PIPE_DIMENSIONS Dimensions = new _PIPE_DIMENSIONS();
    public KS_FRAMING_RANGE PhysicalRange = new KS_FRAMING_RANGE(); // on allocator pin
    public IKsAllocatorEx PrevSegment; // doubly-linked list of KS allocators
    public uint CountNextSegments; // possible multiple dependent pipes
    public IKsAllocatorEx[] NextSegments;
    public uint InsideFactors; // existing factors (different from "don't care")
    public uint NumberPins;
}



#if __STREAMS__

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
struct DECLSPEC_UUID("5C5CBD84-E755-11D0-AC18-00A0C9223196") IKsClockPropertySet;

public enum KSPEEKOPERATION
{
    KsPeekOperation_PeekOnly,
    KsPeekOperation_AddRef
}


// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("b61178d1-a2d9-11cf-9e53-00aa00a216a1") struct IKsPin;

public enum KSIOOPERATION
{
    KsIoOperation_Write,
    KsIoOperation_Read
}

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("5ffbaa02-49a3-11d0-9f36-00aa00a216a1") IKsDataTypeHandler;


// 
// This structure definition is the common header required by the proxy to 
// dispatch the stream segment to the interface handler.  Interface handlers 
// will create extended structures to include other information such as 
// media samples, extended header size and so on.
// 

public class _KSSTREAM_SEGMENT
{
    public IKsInterfaceHandler KsInterfaceHandler;
    public IKsDataTypeHandler KsDataTypeHandler;
    public KSIOOPERATION IoOperation;
    public IntPtr CompletionEvent;

}

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("423c13a2-2070-11d0-9ef7-00aa00a216a1") IKsObject;