using System;

/*++

Copyright (c) Microsoft Corporation. All rights reserved.

Module Name:

    ks.h

Abstract:

    Windows Driver Model/Connection and Streaming Architecture (WDM-CSA)
    core definitions.

--*/


#if __TCS__
#define _KS_NO_ANONYMOUS_STRUCTURES_
#endif

#if !_NTRTL_
    #if ! DEFINE_GUIDEX
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_GUIDEX(name) EXTERN_C const CDECL GUID name
        #define DEFINE_GUIDEX
    #endif // !defined(DEFINE_GUIDEX)

    #if ! STATICGUIDOF
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATICGUIDOF(guid) STATIC_##guid
        #define STATICGUIDOF
    #endif // !defined(STATICGUIDOF)
#endif // !defined(_NTRTL_)

#if ! SIZEOF_ARRAY
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZEOF_ARRAY(ar) (sizeof(ar)/sizeof((ar)[0]))
    #define SIZEOF_ARRAY
#endif // !defined(SIZEOF_ARRAY)

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if __cplusplus && _MSC_VER >= 1100
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_GUIDSTRUCT(g, n) struct __declspec(uuid(g)) n
#define DEFINE_GUIDSTRUCT
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_GUIDNAMED(n) __uuidof(struct n)
#define DEFINE_GUIDNAMED
#else // !defined(__cplusplus)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_GUIDSTRUCT(g, n) DEFINE_GUIDEX(n)
#define DEFINE_GUIDSTRUCT
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_GUIDNAMED(n) n
#define DEFINE_GUIDNAMED
#endif // !defined(__cplusplus)

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_GUID_NULL 0x00000000L, 0x0000, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000000-0000-0000-0000-000000000000", GUID_NULL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GUID_NULL DEFINE_GUIDNAMED(GUID_NULL)

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_PROPERTY CTL_CODE(FILE_DEVICE_KS, 0x000, METHOD_NEITHER, FILE_ANY_ACCESS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_ENABLE_EVENT CTL_CODE(FILE_DEVICE_KS, 0x001, METHOD_NEITHER, FILE_ANY_ACCESS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_DISABLE_EVENT CTL_CODE(FILE_DEVICE_KS, 0x002, METHOD_NEITHER, FILE_ANY_ACCESS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_METHOD CTL_CODE(FILE_DEVICE_KS, 0x003, METHOD_NEITHER, FILE_ANY_ACCESS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_WRITE_STREAM CTL_CODE(FILE_DEVICE_KS, 0x004, METHOD_NEITHER, FILE_WRITE_ACCESS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_READ_STREAM CTL_CODE(FILE_DEVICE_KS, 0x005, METHOD_NEITHER, FILE_READ_ACCESS)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_RESET_STATE CTL_CODE(FILE_DEVICE_KS, 0x006, METHOD_NEITHER, FILE_ANY_ACCESS)

// ===========================================================================

public enum KSRESET
{
    KSRESET_BEGIN,
    KSRESET_END
}

public enum KSSTATE
{
    KSSTATE_STOP,
    KSSTATE_ACQUIRE,
    KSSTATE_PAUSE,
    KSSTATE_RUN
}


public class KSPRIORITY
{
    public uint PriorityClass;
    public uint PrioritySubClass;
}

public partial class KSIDENTIFIER
{
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
// #if _KS_NO_ANONYMOUS_STRUCTURES_
//        struct _IDENTIFIER
//        {
// #else
//        struct
//        {
// #endif
//            GUID Set;
//            uint Id;
//            uint Flags;
//        };
//        long Alignment;
//    };
}

public class KSP_NODE
{
    public KSIDENTIFIER Property = new KSIDENTIFIER();
    public uint NodeId;
    public uint Reserved;
}

public class KSM_NODE
{
    public KSIDENTIFIER Method = new KSIDENTIFIER();
    public uint NodeId;
    public uint Reserved;
}

public class KSE_NODE
{
    public KSIDENTIFIER Event = new KSIDENTIFIER();
    public uint NodeId;
    public uint Reserved;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPTYPESETID_General 0x97E99BA0L, 0xBDEA, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("97E99BA0-BDEA-11CF-A5D6-28DB04C10000", KSPROPTYPESETID_General);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPTYPESETID_General DEFINE_GUIDNAMED(KSPROPTYPESETID_General)

#if _NTDDK_ && !__wtypes_h__
public enum VARENUM
{
    VT_EMPTY = 0,
    VT_NULL = 1,
    VT_I2 = 2,
    VT_I4 = 3,
    VT_R4 = 4,
    VT_R8 = 5,
    VT_CY = 6,
    VT_DATE = 7,
    VT_BSTR = 8,
    VT_DISPATCH = 9,
    VT_ERROR = 10,
    VT_BOOL = 11,
    VT_VARIANT = 12,
    VT_UNKNOWN = 13,
    VT_DECIMAL = 14,
    VT_I1 = 16,
    VT_UI1 = 17,
    VT_UI2 = 18,
    VT_UI4 = 19,
    VT_I8 = 20,
    VT_UI8 = 21,
    VT_INT = 22,
    VT_UINT = 23,
    VT_VOID = 24,
    VT_HRESULT = 25,
    VT_PTR = 26,
    VT_SAFEARRAY = 27,
    VT_CARRAY = 28,
    VT_USERDEFINED = 29,
    VT_LPSTR = 30,
    VT_LPWSTR = 31,
    VT_FILETIME = 64,
    VT_BLOB = 65,
    VT_STREAM = 66,
    VT_STORAGE = 67,
    VT_STREAMED_OBJECT = 68,
    VT_STORED_OBJECT = 69,
    VT_BLOB_OBJECT = 70,
    VT_CF = 71,
    VT_CLSID = 72,
    VT_VECTOR = 0x1000,
    VT_ARRAY = 0x2000,
    VT_BYREF = 0x4000,
    VT_RESERVED = 0x8000,
    VT_ILLEGAL = 0xffff,
    VT_ILLEGALMASKED = 0xfff,
    VT_TYPEMASK = 0xfff
}
#endif // _NTDDK_ && !__wtypes_h__

public class KSMULTIPLE_ITEM
{
    public uint Size;
    public uint Count;
}

public class KSPROPERTY_DESCRIPTION
{
    public uint AccessFlags;
    public uint DescriptionSize;
    public KSIDENTIFIER PropTypeSet = new KSIDENTIFIER();
    public uint MembersListCount;
    public uint Reserved;
}

public class KSPROPERTY_MEMBERSHEADER
{
    public uint MembersFlags;
    public uint MembersSize;
    public uint MembersCount;
    public uint Flags;
}

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union KSPROPERTY_BOUNDS_LONG
// {
// #if _KS_NO_ANONYMOUS_STRUCTURES_
//    struct _SIGNED
//    {
// #else
//    struct
//    {
// #endif
//        int SignedMinimum;
//        int SignedMaximum;
//    };
// #if _KS_NO_ANONYMOUS_STRUCTURES_
//    struct _UNSIGNED
//    {
// #else
//    struct
//    {
// #endif
//        uint UnsignedMinimum;
//        uint UnsignedMaximum;
//    };
// };

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union KSPROPERTY_BOUNDS_LONGLONG
// {
// #if _KS_NO_ANONYMOUS_STRUCTURES_
//    struct _SIGNED64
//    {
// #else
//    struct
//    {
// #endif
//        long SignedMinimum;
//        long SignedMaximum;
//    };
// #if _KS_NO_ANONYMOUS_STRUCTURES_
//    struct _UNSIGNED64
//    {
// #else
//    struct
//    {
// #endif
// #if _NTDDK_
//        ulong UnsignedMinimum;
//        ulong UnsignedMaximum;
// #else // !_NTDDK_
//        ulong UnsignedMinimum;
//        ulong UnsignedMaximum;
// #endif // !_NTDDK_
//    };
// };

public class KSPROPERTY_STEPPING_LONG
{
    public uint SteppingDelta;
    public uint Reserved;
    public KSPROPERTY_BOUNDS_LONG Bounds = new KSPROPERTY_BOUNDS_LONG();
}

public class KSPROPERTY_STEPPING_LONGLONG
{
#if _NTDDK_
    public ulong SteppingDelta;
#else // !_NTDDK_
    public ulong SteppingDelta;
#endif // !_NTDDK_
    public KSPROPERTY_BOUNDS_LONGLONG Bounds = new KSPROPERTY_BOUNDS_LONGLONG();
}

// ===========================================================================

#if _NTDDK_
// 
// Structure forward declarations.
// 
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSDEVICE_DESCRIPTOR KSDEVICE_DESCRIPTOR, *PKSDEVICE_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSDEVICE_DESCRIPTOR *PKSDEVICE_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSDEVICE_DISPATCH KSDEVICE_DISPATCH, *PKSDEVICE_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSDEVICE_DISPATCH *PKSDEVICE_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSDEVICE KSDEVICE, *PKSDEVICE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSDEVICE *PKSDEVICE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTERFACTORY KSFILTERFACTORY, *PKSFILTERFACTORY;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTERFACTORY *PKSFILTERFACTORY;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTER_DESCRIPTOR KSFILTER_DESCRIPTOR, *PKSFILTER_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTER_DESCRIPTOR *PKSFILTER_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTER_DISPATCH KSFILTER_DISPATCH, *PKSFILTER_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTER_DISPATCH *PKSFILTER_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTER KSFILTER, *PKSFILTER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSFILTER *PKSFILTER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPIN_DESCRIPTOR_EX KSPIN_DESCRIPTOR_EX, *PKSPIN_DESCRIPTOR_EX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPIN_DESCRIPTOR_EX *PKSPIN_DESCRIPTOR_EX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPIN_DISPATCH KSPIN_DISPATCH, *PKSPIN_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPIN_DISPATCH *PKSPIN_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSCLOCK_DISPATCH KSCLOCK_DISPATCH, *PKSCLOCK_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSCLOCK_DISPATCH *PKSCLOCK_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSALLOCATOR_DISPATCH KSALLOCATOR_DISPATCH, *PKSALLOCATOR_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSALLOCATOR_DISPATCH *PKSALLOCATOR_DISPATCH;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPIN KSPIN, *PKSPIN;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPIN *PKSPIN;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSNODE_DESCRIPTOR KSNODE_DESCRIPTOR, *PKSNODE_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSNODE_DESCRIPTOR *PKSNODE_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSSTREAM_POINTER_OFFSET KSSTREAM_POINTER_OFFSET, *PKSSTREAM_POINTER_OFFSET;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSSTREAM_POINTER_OFFSET *PKSSTREAM_POINTER_OFFSET;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSSTREAM_POINTER KSSTREAM_POINTER, *PKSSTREAM_POINTER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSSTREAM_POINTER *PKSSTREAM_POINTER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSMAPPING KSMAPPING, *PKSMAPPING;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSMAPPING *PKSMAPPING;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPROCESSPIN KSPROCESSPIN, *PKSPROCESSPIN;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPROCESSPIN *PKSPROCESSPIN;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPROCESSPIN_INDEXENTRY KSPROCESSPIN_INDEXENTRY, *PKSPROCESSPIN_INDEXENTRY;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSPROCESSPIN_INDEXENTRY *PKSPROCESSPIN_INDEXENTRY;
#endif // _NTDDK_


public class KSEVENTDATA
{
    public uint NotificationType;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        struct
//        {
//            System.IntPtr Event;
//            System.IntPtr Reserved[2];
//        }
//        EventHandle;
//        struct
//        {
//            System.IntPtr Semaphore;
//            uint Reserved;
//            int Adjustment;
//        }
//        SemaphoreHandle;
// #if _NTDDK_
//        struct
//        {
//            object* Event;
//            KPRIORITY Increment;
//            System.IntPtr Reserved;
//        }
//        EventObject;
//        struct
//        {
//            object* Semaphore;
//            KPRIORITY Increment;
//            int Adjustment;
//        }
//        SemaphoreObject;
//        struct
//        {
//            PKDPC Dpc;
//            uint ReferenceCount;
//            System.IntPtr Reserved;
//        }
//        Dpc;
//        struct
//        {
//            PWORK_QUEUE_ITEM WorkQueueItem;
//            WORK_QUEUE_TYPE WorkQueueType;
//            System.IntPtr Reserved;
//        }
//        WorkItem;
//        struct
//        {
//            PWORK_QUEUE_ITEM WorkQueueItem;
//            object* KsWorkerObject;
//            System.IntPtr Reserved;
//        }
//        KsWorkItem;
/// / @@BEGIN_DDKSPLIT
//        struct
//        {
//            struct _KSFILTER * Filter;
//            System.IntPtr Reserved[2];
//        }
//        KsFilterProcessing;
//        struct
//        {
//            struct _KSPIN * Pin;
//            System.IntPtr Reserved[2];
//        }
//        KsPinProcessing;
/// / @@END_DDKSPLIT
// #endif // defined(_NTDDK_)
//        struct
//        {
//            object* Unused;
//            System.IntPtr Alignment[2];
//        }
//        Alignment;
//    };
}

public class KSQUERYBUFFER
{
    public KSIDENTIFIER Event = new KSIDENTIFIER();
    public KSEVENTDATA EventData;
    public object[] Reserved;
}

public class KSRELATIVEEVENT
{
    public uint Size;
    public uint Flags;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        System.IntPtr ObjectHandle;
//        object* ObjectPointer;
//    };
    public object[] Reserved;
    public KSIDENTIFIER Event = new KSIDENTIFIER();
    public KSEVENTDATA EventData = new KSEVENTDATA();
}

// ===========================================================================

public class KSEVENT_TIME_MARK
{
    public KSEVENTDATA EventData = new KSEVENTDATA();
    public long MarkTime;
}

public class KSEVENT_TIME_INTERVAL
{
    public KSEVENTDATA EventData = new KSEVENTDATA();
    public long TimeBase;
    public long Interval;
}

public class KSINTERVAL
{
    public long TimeBase;
    public long Interval;
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_General 0x1464EDA5L, 0x6A8F, 0x11D1, 0x9A, 0xA7, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1464EDA5-6A8F-11D1-9AA7-00A0C9223196", KSPROPSETID_General);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_General DEFINE_GUIDNAMED(KSPROPSETID_General)

public enum KSPROPERTY_GENERAL
{
    KSPROPERTY_GENERAL_COMPONENTID
}

public class KSCOMPONENTID
{
    public GUID Manufacturer = new GUID();
    public GUID Product = new GUID();
    public GUID Component = new GUID();
    public GUID Name = new GUID();
    public uint Version;
    public uint Revision;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_GENERAL_COMPONENTID(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_GENERAL_COMPONENTID, (Handler), sizeof(KSPROPERTY), sizeof(KSCOMPONENTID), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMETHODSETID_StreamIo 0x65D003CAL, 0x1523, 0x11D2, 0xB2, 0x7A, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("65D003CA-1523-11D2-B27A-00A0C9223196", KSMETHODSETID_StreamIo);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHODSETID_StreamIo DEFINE_GUIDNAMED(KSMETHODSETID_StreamIo)

public enum KSMETHOD_STREAMIO
{
    KSMETHOD_STREAMIO_READ,
    KSMETHOD_STREAMIO_WRITE
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_ITEM_STREAMIO_READ(Handler) DEFINE_KSMETHOD_ITEM( KSMETHOD_STREAMIO_READ, KSMETHOD_TYPE_WRITE, (Handler), sizeof(KSMETHOD), 0, NULL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_ITEM_STREAMIO_WRITE(Handler) DEFINE_KSMETHOD_ITEM( KSMETHOD_STREAMIO_WRITE, KSMETHOD_TYPE_READ, (Handler), sizeof(KSMETHOD), 0, NULL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_MediaSeeking 0xEE904F0CL, 0xD09B, 0x11D0, 0xAB, 0xE9, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("EE904F0C-D09B-11D0-ABE9-00A0C9223196", KSPROPSETID_MediaSeeking);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_MediaSeeking DEFINE_GUIDNAMED(KSPROPSETID_MediaSeeking)

public enum KSPROPERTY_MEDIASEEKING
{
    KSPROPERTY_MEDIASEEKING_CAPABILITIES,
    KSPROPERTY_MEDIASEEKING_FORMATS,
    KSPROPERTY_MEDIASEEKING_TIMEFORMAT,
    KSPROPERTY_MEDIASEEKING_POSITION,
    KSPROPERTY_MEDIASEEKING_STOPPOSITION,
    KSPROPERTY_MEDIASEEKING_POSITIONS,
    KSPROPERTY_MEDIASEEKING_DURATION,
    KSPROPERTY_MEDIASEEKING_AVAILABLE,
    KSPROPERTY_MEDIASEEKING_PREROLL,
    KSPROPERTY_MEDIASEEKING_CONVERTTIMEFORMAT
}

public enum KS_SEEKING_FLAGS
{
    KS_SEEKING_NoPositioning,
    KS_SEEKING_AbsolutePositioning,
    KS_SEEKING_RelativePositioning,
    KS_SEEKING_IncrementalPositioning,
    KS_SEEKING_PositioningBitsMask = 0x3,
    KS_SEEKING_SeekToKeyFrame,
    KS_SEEKING_ReturnTime = 0x8
}

public enum KS_SEEKING_CAPABILITIES
{
    KS_SEEKING_CanSeekAbsolute = 0x1,
    KS_SEEKING_CanSeekForwards = 0x2,
    KS_SEEKING_CanSeekBackwards = 0x4,
    KS_SEEKING_CanGetCurrentPos = 0x8,
    KS_SEEKING_CanGetStopPos = 0x10,
    KS_SEEKING_CanGetDuration = 0x20,
    KS_SEEKING_CanPlayBackwards = 0x40
}

public class KSPROPERTY_POSITIONS
{
    public long Current;
    public long Stop;
    public KS_SEEKING_FLAGS CurrentFlags;
    public KS_SEEKING_FLAGS StopFlags;
}

public class KSPROPERTY_MEDIAAVAILABLE
{
    public long Earliest;
    public long Latest;
}

public class KSP_TIMEFORMAT
{
    public KSIDENTIFIER Property = new KSIDENTIFIER();
    public GUID SourceFormat = new GUID();
    public GUID TargetFormat = new GUID();
    public long Time;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_CAPABILITIES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_CAPABILITIES, (Handler), sizeof(KSPROPERTY), sizeof(KS_SEEKING_CAPABILITIES), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_FORMATS(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_FORMATS, (Handler), sizeof(KSPROPERTY), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_TIMEFORMAT(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_TIMEFORMAT, (GetHandler), sizeof(KSPROPERTY), sizeof(GUID), (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_POSITION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_POSITION, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_STOPPOSITION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_STOPPOSITION, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_POSITIONS(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_POSITIONS, NULL, sizeof(KSPROPERTY), sizeof(KSPROPERTY_POSITIONS), (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_DURATION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_DURATION, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_AVAILABLE(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_AVAILABLE, (Handler), sizeof(KSPROPERTY), sizeof(KSPROPERTY_MEDIAAVAILABLE), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_PREROLL(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_PREROLL, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_MEDIASEEKING_CONVERTTIMEFORMAT(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_MEDIASEEKING_CONVERTTIMEFORMAT, (Handler), sizeof(KSP_TIMEFORMAT), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Topology 0x720D4AC0L, 0x7533, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("720D4AC0-7533-11D0-A5D6-28DB04C10000", KSPROPSETID_Topology);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Topology DEFINE_GUIDNAMED(KSPROPSETID_Topology)

public enum KSPROPERTY_TOPOLOGY
{
    KSPROPERTY_TOPOLOGY_CATEGORIES,
    KSPROPERTY_TOPOLOGY_NODES,
    KSPROPERTY_TOPOLOGY_CONNECTIONS,
    KSPROPERTY_TOPOLOGY_NAME
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_TOPOLOGY_CATEGORIES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_TOPOLOGY_CATEGORIES, (Handler), sizeof(KSPROPERTY), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_TOPOLOGY_NODES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_TOPOLOGY_NODES, (Handler), sizeof(KSPROPERTY), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_TOPOLOGY_CONNECTIONS(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_TOPOLOGY_CONNECTIONS, (Handler), sizeof(KSPROPERTY), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_TOPOLOGY_NAME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_TOPOLOGY_NAME, (Handler), sizeof(KSP_NODE), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_TOPOLOGYSET(TopologySet, Handler)DEFINE_KSPROPERTY_TABLE(TopologySet) { DEFINE_KSPROPERTY_ITEM_TOPOLOGY_CATEGORIES(Handler), DEFINE_KSPROPERTY_ITEM_TOPOLOGY_NODES(Handler), DEFINE_KSPROPERTY_ITEM_TOPOLOGY_CONNECTIONS(Handler), DEFINE_KSPROPERTY_ITEM_TOPOLOGY_NAME(Handler)}

// =============================================================================

// 
// properties used by graph manager to talk to particular filters
// 
#if _NTDDK_

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_GM 0xAF627536L, 0xE719, 0x11D2, 0x8A, 0x1D, 0x00, 0x60, 0x97, 0xD2, 0xDF, 0x5D
#define STATIC_KSPROPSETID_GM
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("AF627536-E719-11D2-8A1D-006097D2DF5D", KSPROPSETID_GM);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_GM DEFINE_GUIDNAMED(KSPROPSETID_GM)
#define KSPROPSETID_GM

public delegate void PFNKSGRAPHMANAGER_NOTIFY(IN PFILE_OBJECT GraphManager, IN uint EventId, IN object Filter, IN object Pin, IN object Frame, IN uint Duration);

public class KSGRAPHMANAGER_FUNCTIONTABLE
{
    public PFNKSGRAPHMANAGER_NOTIFY NotifyEvent;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSGRAPHMANAGER_FUNCTIONTABLE PKSGRAPHMANAGER_FUNCTIONTABLE;

public class _KSPROPERTY_GRAPHMANAGER_INTERFACE
{
    public PFILE_OBJECT GraphManager = new PFILE_OBJECT();
    public KSGRAPHMANAGER_FUNCTIONTABLE FunctionTable = new KSGRAPHMANAGER_FUNCTIONTABLE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _KSPROPERTY_GRAPHMANAGER_INTERFACE KSPROPERTY_GRAPHMANAGER_INTERFACE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _KSPROPERTY_GRAPHMANAGER_INTERFACE *PKSPROPERTY_GRAPHMANAGER_INTERFACE;


// 
// Commands
// 
public enum KSPROPERTY_GM
{
    KSPROPERTY_GM_GRAPHMANAGER,
    KSPROPERTY_GM_TIMESTAMP_CLOCK,
    KSPROPERTY_GM_RATEMATCH,
    KSPROPERTY_GM_RENDER_CLOCK
}

#endif

// ===========================================================================


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_BRIDGE 0x085AFF00L, 0x62CE, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("085AFF00-62CE-11CF-A5D6-28DB04C10000", KSCATEGORY_BRIDGE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_BRIDGE DEFINE_GUIDNAMED(KSCATEGORY_BRIDGE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_CAPTURE 0x65E8773DL, 0x8F56, 0x11D0, 0xA3, 0xB9, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("65E8773D-8F56-11D0-A3B9-00A0C9223196", KSCATEGORY_CAPTURE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_CAPTURE DEFINE_GUIDNAMED(KSCATEGORY_CAPTURE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_RENDER 0x65E8773EL, 0x8F56, 0x11D0, 0xA3, 0xB9, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("65E8773E-8F56-11D0-A3B9-00A0C9223196", KSCATEGORY_RENDER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_RENDER DEFINE_GUIDNAMED(KSCATEGORY_RENDER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_MIXER 0xAD809C00L, 0x7B88, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("AD809C00-7B88-11D0-A5D6-28DB04C10000", KSCATEGORY_MIXER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_MIXER DEFINE_GUIDNAMED(KSCATEGORY_MIXER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_SPLITTER 0x0A4252A0L, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0A4252A0-7E70-11D0-A5D6-28DB04C10000", KSCATEGORY_SPLITTER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_SPLITTER DEFINE_GUIDNAMED(KSCATEGORY_SPLITTER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_DATACOMPRESSOR 0x1E84C900L, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1E84C900-7E70-11D0-A5D6-28DB04C10000", KSCATEGORY_DATACOMPRESSOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_DATACOMPRESSOR DEFINE_GUIDNAMED(KSCATEGORY_DATACOMPRESSOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_DATADECOMPRESSOR 0x2721AE20L, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2721AE20-7E70-11D0-A5D6-28DB04C10000", KSCATEGORY_DATADECOMPRESSOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_DATADECOMPRESSOR DEFINE_GUIDNAMED(KSCATEGORY_DATADECOMPRESSOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_DATATRANSFORM 0x2EB07EA0L, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2EB07EA0-7E70-11D0-A5D6-28DB04C10000", KSCATEGORY_DATATRANSFORM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_DATATRANSFORM DEFINE_GUIDNAMED(KSCATEGORY_DATATRANSFORM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_COMMUNICATIONSTRANSFORM 0xCF1DDA2CL, 0x9743, 0x11D0, 0xA3, 0xEE, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("CF1DDA2C-9743-11D0-A3EE-00A0C9223196", KSCATEGORY_COMMUNICATIONSTRANSFORM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_COMMUNICATIONSTRANSFORM DEFINE_GUIDNAMED(KSCATEGORY_COMMUNICATIONSTRANSFORM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_INTERFACETRANSFORM 0xCF1DDA2DL, 0x9743, 0x11D0, 0xA3, 0xEE, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("CF1DDA2D-9743-11D0-A3EE-00A0C9223196", KSCATEGORY_INTERFACETRANSFORM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_INTERFACETRANSFORM DEFINE_GUIDNAMED(KSCATEGORY_INTERFACETRANSFORM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_MEDIUMTRANSFORM 0xCF1DDA2EL, 0x9743, 0x11D0, 0xA3, 0xEE, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("CF1DDA2E-9743-11D0-A3EE-00A0C9223196", KSCATEGORY_MEDIUMTRANSFORM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_MEDIUMTRANSFORM DEFINE_GUIDNAMED(KSCATEGORY_MEDIUMTRANSFORM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_FILESYSTEM 0x760FED5EL, 0x9357, 0x11D0, 0xA3, 0xCC, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("760FED5E-9357-11D0-A3CC-00A0C9223196", KSCATEGORY_FILESYSTEM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_FILESYSTEM DEFINE_GUIDNAMED(KSCATEGORY_FILESYSTEM)

// KSNAME_Clock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_CLOCK 0x53172480L, 0x4791, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("53172480-4791-11D0-A5D6-28DB04C10000", KSCATEGORY_CLOCK);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_CLOCK DEFINE_GUIDNAMED(KSCATEGORY_CLOCK)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_PROXY 0x97EBAACAL, 0x95BD, 0x11D0, 0xA3, 0xEA, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("97EBAACA-95BD-11D0-A3EA-00A0C9223196", KSCATEGORY_PROXY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_PROXY DEFINE_GUIDNAMED(KSCATEGORY_PROXY)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_QUALITY 0x97EBAACBL, 0x95BD, 0x11D0, 0xA3, 0xEA, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("97EBAACB-95BD-11D0-A3EA-00A0C9223196", KSCATEGORY_QUALITY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_QUALITY DEFINE_GUIDNAMED(KSCATEGORY_QUALITY)

public class KSTOPOLOGY_CONNECTION
{
    public uint FromNode;
    public uint FromNodePin;
    public uint ToNode;
    public uint ToNodePin;
}

public class KSTOPOLOGY
{
    public uint CategoriesCount;
    public readonly GUID Categories;
    public uint TopologyNodesCount;
    public readonly GUID TopologyNodes;
    public uint TopologyConnectionsCount;
    public readonly KSTOPOLOGY_CONNECTION TopologyConnections;
    public readonly GUID TopologyNodesNames;
    public uint Reserved;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSFILTER_NODE ((ULONG)-1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSALL_NODES ((ULONG)-1)

public class KSNODE_CREATE
{
    public uint CreateFlags;
    public uint Node;
}

// ===========================================================================

// TIME_FORMAT_NONE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSTIME_FORMAT_NONE STATIC_GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSTIME_FORMAT_NONE GUID_NULL

// TIME_FORMAT_FRAME
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSTIME_FORMAT_FRAME 0x7b785570L, 0x8c82, 0x11cf, 0xbc, 0x0c, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7b785570-8c82-11cf-bc0c-00aa00ac74f6", KSTIME_FORMAT_FRAME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSTIME_FORMAT_FRAME DEFINE_GUIDNAMED(KSTIME_FORMAT_FRAME)

// TIME_FORMAT_BYTE             
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSTIME_FORMAT_BYTE 0x7b785571L, 0x8c82, 0x11cf, 0xbc, 0x0c, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7b785571-8c82-11cf-bc0c-00aa00ac74f6", KSTIME_FORMAT_BYTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSTIME_FORMAT_BYTE DEFINE_GUIDNAMED(KSTIME_FORMAT_BYTE)

// TIME_FORMAT_SAMPLE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSTIME_FORMAT_SAMPLE 0x7b785572L, 0x8c82, 0x11cf, 0xbc, 0x0c, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7b785572-8c82-11cf-bc0c-00aa00ac74f6", KSTIME_FORMAT_SAMPLE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSTIME_FORMAT_SAMPLE DEFINE_GUIDNAMED(KSTIME_FORMAT_SAMPLE)

// TIME_FORMAT_FIELD
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSTIME_FORMAT_FIELD 0x7b785573L, 0x8c82, 0x11cf, 0xbc, 0x0c, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7b785573-8c82-11cf-bc0c-00aa00ac74f6", KSTIME_FORMAT_FIELD);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSTIME_FORMAT_FIELD DEFINE_GUIDNAMED(KSTIME_FORMAT_FIELD)

// TIME_FORMAT_MEDIA_TIME
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSTIME_FORMAT_MEDIA_TIME 0x7b785574L, 0x8c82, 0x11cf, 0xbc, 0x0c, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7b785574-8c82-11cf-bc0c-00aa00ac74f6", KSTIME_FORMAT_MEDIA_TIME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSTIME_FORMAT_MEDIA_TIME DEFINE_GUIDNAMED(KSTIME_FORMAT_MEDIA_TIME)

// ===========================================================================


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSINTERFACESETID_Standard 0x1A8766A0L, 0x62CE, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1A8766A0-62CE-11CF-A5D6-28DB04C10000", KSINTERFACESETID_Standard);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSINTERFACESETID_Standard DEFINE_GUIDNAMED(KSINTERFACESETID_Standard)

public enum KSINTERFACE_STANDARD
{
    KSINTERFACE_STANDARD_STREAMING,
    KSINTERFACE_STANDARD_LOOPED_STREAMING,
    KSINTERFACE_STANDARD_CONTROL
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSINTERFACESETID_FileIo 0x8C6F932CL, 0xE771, 0x11D0, 0xB8, 0xFF, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("8C6F932C-E771-11D0-B8FF-00A0C9223196", KSINTERFACESETID_FileIo);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSINTERFACESETID_FileIo DEFINE_GUIDNAMED(KSINTERFACESETID_FileIo)

public enum KSINTERFACE_FILEIO
{
    KSINTERFACE_FILEIO_STREAMING
}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Pin DEFINE_GUIDNAMED(KSPROPSETID_Pin)

public enum KSPROPERTY_PIN
{
    KSPROPERTY_PIN_CINSTANCES,
    KSPROPERTY_PIN_CTYPES,
    KSPROPERTY_PIN_DATAFLOW,
    KSPROPERTY_PIN_DATARANGES,
    KSPROPERTY_PIN_DATAINTERSECTION,
    KSPROPERTY_PIN_INTERFACES,
    KSPROPERTY_PIN_MEDIUMS,
    KSPROPERTY_PIN_COMMUNICATION,
    KSPROPERTY_PIN_GLOBALCINSTANCES,
    KSPROPERTY_PIN_NECESSARYINSTANCES,
    KSPROPERTY_PIN_PHYSICALCONNECTION,
    KSPROPERTY_PIN_CATEGORY,
    KSPROPERTY_PIN_NAME,
    KSPROPERTY_PIN_CONSTRAINEDDATARANGES,
    KSPROPERTY_PIN_PROPOSEDATAFORMAT
}

public class KSP_PIN
{
    public KSIDENTIFIER Property = new KSIDENTIFIER();
    public uint PinId;
    public uint Reserved;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSINSTANCE_INDETERMINATE ((ULONG)-1)

public class KSPIN_CINSTANCES
{
    public uint PossibleCount;
    public uint CurrentCount;
}

public enum KSPIN_DATAFLOW
{
    KSPIN_DATAFLOW_IN = 1,
    KSPIN_DATAFLOW_OUT
}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATARANGE_REQUIRED_ATTRIBUTES (1 << KSDATARANGE_BIT_REQUIRED_ATTRIBUTES)

#if ! _MSC_VER
public class KSDATAFORMAT
{
    public uint FormatSize;
    public uint Flags;
    public uint SampleSize;
    public uint Reserved;
    public GUID MajorFormat = new GUID();
    public GUID SubFormat = new GUID();
    public GUID Specifier = new GUID();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDATAFORMAT *PKSDATAFORMAT;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDATAFORMAT KSDATARANGE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDATAFORMAT *PKSDATARANGE;
#else
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union KSDATAFORMAT
// {
//    struct
//    {
//        uint FormatSize;
//        uint Flags;
//        uint SampleSize;
//        uint Reserved;
//        GUID MajorFormat;
//        GUID SubFormat;
//        GUID Specifier;
//    };
//    long Alignment;
// };
#endif

public class KSATTRIBUTE
{
    public uint Size;
    public uint Flags;
    public GUID Attribute = new GUID();
}

#if _NTDDK_
public class KSATTRIBUTE_LIST
{
    public uint Count;
    public KSATTRIBUTE[] Attributes;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSATTRIBUTE_LIST *PKSATTRIBUTE_LIST;
#endif // _NTDDK_

public enum KSPIN_COMMUNICATION
{
    KSPIN_COMMUNICATION_NONE,
    KSPIN_COMMUNICATION_SINK,
    KSPIN_COMMUNICATION_SOURCE,
    KSPIN_COMMUNICATION_BOTH,
    KSPIN_COMMUNICATION_BRIDGE
}


public class KSPIN_CONNECT
{
    public KSIDENTIFIER Interface = new KSIDENTIFIER();
    public KSIDENTIFIER Medium = new KSIDENTIFIER();
    public uint PinId;
    public IntPtr PinToHandle;
    public KSPRIORITY Priority = new KSPRIORITY();
}

public class KSPIN_PHYSICALCONNECTION
{
    public uint Size;
    public uint Pin;
    public string SymbolicLinkName = new string(new char[1]);
}

#if _NTDDK_
public delegate NTSTATUS PFNKSINTERSECTHANDLER(IN PIRP Irp, IN KSP_PIN Pin, IN KSDATAFORMAT DataRange, OUT object * Data OPTIONAL);
public delegate NTSTATUS PFNKSINTERSECTHANDLEREX(IN object Context, IN PIRP Irp, IN KSP_PIN Pin, IN KSDATAFORMAT DataRange, IN KSDATAFORMAT MatchingDataRange, IN uint DataBufferSize, OUT object * Data OPTIONAL, OUT uint DataSize);
#endif // _NTDDK_

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_INTERFACE_TABLE(tablename) const KSPIN_INTERFACE tablename[] =

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_INTERFACE_ITEM(guid, interface) { STATICGUIDOF(guid), (interface), 0 }

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_MEDIUM_TABLE( tablename ) const KSPIN_MEDIUM tablename[] =

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_MEDIUM_ITEM(guid, medium) DEFINE_KSPIN_INTERFACE_ITEM(guid, medium)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_CINSTANCES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_CINSTANCES, (Handler), sizeof(KSP_PIN), sizeof(KSPIN_CINSTANCES), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_CTYPES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_CTYPES, (Handler), sizeof(KSPROPERTY), sizeof(ULONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_DATAFLOW(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_DATAFLOW, (Handler), sizeof(KSP_PIN), sizeof(KSPIN_DATAFLOW), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_DATARANGES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_DATARANGES, (Handler), sizeof(KSP_PIN), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_DATAINTERSECTION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_DATAINTERSECTION, (Handler), sizeof(KSP_PIN) + sizeof(KSMULTIPLE_ITEM), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_INTERFACES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_INTERFACES, (Handler), sizeof(KSP_PIN), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_MEDIUMS(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_MEDIUMS, (Handler), sizeof(KSP_PIN), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_COMMUNICATION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_COMMUNICATION, (Handler), sizeof(KSP_PIN), sizeof(KSPIN_COMMUNICATION), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_GLOBALCINSTANCES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_GLOBALCINSTANCES, (Handler), sizeof(KSP_PIN), sizeof(KSPIN_CINSTANCES), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_NECESSARYINSTANCES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_NECESSARYINSTANCES, (Handler), sizeof(KSP_PIN), sizeof(ULONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_PHYSICALCONNECTION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_PHYSICALCONNECTION, (Handler), sizeof(KSP_PIN), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_CATEGORY(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_CATEGORY, (Handler), sizeof(KSP_PIN), sizeof(GUID), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_NAME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_NAME, (Handler), sizeof(KSP_PIN), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_CONSTRAINEDDATARANGES(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_CONSTRAINEDDATARANGES, (Handler), sizeof(KSP_PIN), 0, NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_PIN_PROPOSEDATAFORMAT(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_PIN_PROPOSEDATAFORMAT, NULL, sizeof(KSP_PIN), sizeof(KSDATAFORMAT), (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_PINSET(PinSet, PropGeneral, PropInstances, PropIntersection)DEFINE_KSPROPERTY_TABLE(PinSet) { DEFINE_KSPROPERTY_ITEM_PIN_CINSTANCES(PropInstances), DEFINE_KSPROPERTY_ITEM_PIN_CTYPES(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_DATAFLOW(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_DATARANGES(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_DATAINTERSECTION(PropIntersection), DEFINE_KSPROPERTY_ITEM_PIN_INTERFACES(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_MEDIUMS(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_COMMUNICATION(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_CATEGORY(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_NAME(PropGeneral)}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_PINSETCONSTRAINED(PinSet, PropGeneral, PropInstances, PropIntersection)DEFINE_KSPROPERTY_TABLE(PinSet) { DEFINE_KSPROPERTY_ITEM_PIN_CINSTANCES(PropInstances), DEFINE_KSPROPERTY_ITEM_PIN_CTYPES(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_DATAFLOW(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_DATARANGES(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_DATAINTERSECTION(PropIntersection), DEFINE_KSPROPERTY_ITEM_PIN_INTERFACES(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_MEDIUMS(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_COMMUNICATION(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_CATEGORY(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_NAME(PropGeneral), DEFINE_KSPROPERTY_ITEM_PIN_CONSTRAINEDDATARANGES(PropGeneral)}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNAME_Filter 0x9b365890L, 0x165f, 0x11d0, 0xa1, 0x95, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9b365890-165f-11d0-a195-0020afd156e4", KSNAME_Filter);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNAME_Filter DEFINE_GUIDNAMED(KSNAME_Filter)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSSTRING_Filter L"{9B365890-165F-11D0-A195-0020AFD156E4}"

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNAME_Pin 0x146F1A80L, 0x4791, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("146F1A80-4791-11D0-A5D6-28DB04C10000", KSNAME_Pin);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNAME_Pin DEFINE_GUIDNAMED(KSNAME_Pin)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSSTRING_Pin L"{146F1A80-4791-11D0-A5D6-28DB04C10000}"

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNAME_Clock 0x53172480L, 0x4791, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("53172480-4791-11D0-A5D6-28DB04C10000", KSNAME_Clock);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNAME_Clock DEFINE_GUIDNAMED(KSNAME_Clock)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSSTRING_Clock L"{53172480-4791-11D0-A5D6-28DB04C10000}"

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNAME_Allocator 0x642F5D00L, 0x4791, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("642F5D00-4791-11D0-A5D6-28DB04C10000", KSNAME_Allocator);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNAME_Allocator DEFINE_GUIDNAMED(KSNAME_Allocator)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSSTRING_Allocator L"{642F5D00-4791-11D0-A5D6-28DB04C10000}"

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSSTRING_AllocatorEx L"{091BB63B-603F-11D1-B067-00A0C9062802}"

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNAME_TopologyNode 0x0621061AL, 0xEE75, 0x11D0, 0xB9, 0x15, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0621061A-EE75-11D0-B915-00A0C9223196", KSNAME_TopologyNode);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNAME_TopologyNode DEFINE_GUIDNAMED(KSNAME_TopologyNode)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSSTRING_TopologyNode L"{0621061A-EE75-11D0-B915-00A0C9223196}"

#if _NTDDK_

public class KSPIN_DESCRIPTOR
{
    public uint InterfacesCount;
    public readonly KSIDENTIFIER Interfaces;
    public uint MediumsCount;
    public readonly KSIDENTIFIER Mediums;
    public uint DataRangesCount;
    public readonly KSDATAFORMAT[] DataRanges;
    public KSPIN_DATAFLOW DataFlow;
    public KSPIN_COMMUNICATION Communication;
    public readonly GUID Category;
    public readonly GUID Name;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        long Reserved;
//        struct
//        {
//            uint ConstrainedDataRangesCount;
//            KSDATAFORMAT ** ConstrainedDataRanges;
//        };
//    };
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSPIN_DESCRIPTOR *PKSPIN_DESCRIPTOR;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef const KSPIN_DESCRIPTOR *PCKSPIN_DESCRIPTOR;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_DESCRIPTOR_TABLE(tablename) const KSPIN_DESCRIPTOR tablename[] =
#define DEFINE_KSPIN_DESCRIPTOR_TABLE

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_DESCRIPTOR_ITEM( InterfacesCount, Interfaces, MediumsCount, Mediums, DataRangesCount, DataRanges, DataFlow, Communication){ InterfacesCount, Interfaces, MediumsCount, Mediums, DataRangesCount, DataRanges, DataFlow, Communication, NULL, NULL, 0}
#define DEFINE_KSPIN_DESCRIPTOR_ITEM
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_DESCRIPTOR_ITEMEX( InterfacesCount, Interfaces, MediumsCount, Mediums, DataRangesCount, DataRanges, DataFlow, Communication, Category, Name){ InterfacesCount, Interfaces, MediumsCount, Mediums, DataRangesCount, DataRanges, DataFlow, Communication, Category, Name, 0}
#define DEFINE_KSPIN_DESCRIPTOR_ITEMEX

#endif // defined(_NTDDK_)

// ===========================================================================

// MEDIATYPE_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_WILDCARD STATIC_GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_WILDCARD GUID_NULL

// MEDIASUBTYPE_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_WILDCARD STATIC_GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_WILDCARD GUID_NULL

// MEDIATYPE_Stream
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_STREAM 0xE436EB83L, 0x524F, 0x11CE, 0x9F, 0x53, 0x00, 0x20, 0xAF, 0x0B, 0xA7, 0x70
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E436EB83-524F-11CE-9F53-0020AF0BA770", KSDATAFORMAT_TYPE_STREAM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_STREAM DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_STREAM)

// MEDIASUBTYPE_None
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_NONE 0xE436EB8EL, 0x524F, 0x11CE, 0x9F, 0x53, 0x00, 0x20, 0xAF, 0x0B, 0xA7, 0x70
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E436EB8E-524F-11CE-9F53-0020AF0BA770", KSDATAFORMAT_SUBTYPE_NONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_NONE DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_NONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_WILDCARD STATIC_GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_WILDCARD GUID_NULL

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_FILENAME 0xAA797B40L, 0xE974, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("AA797B40-E974-11CF-A5D6-28DB04C10000", KSDATAFORMAT_SPECIFIER_FILENAME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_FILENAME DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_FILENAME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_FILEHANDLE 0x65E8773CL, 0x8F56, 0x11D0, 0xA3, 0xB9, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("65E8773C-8F56-11D0-A3B9-00A0C9223196", KSDATAFORMAT_SPECIFIER_FILEHANDLE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_FILEHANDLE DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_FILEHANDLE)

// FORMAT_None
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_NONE 0x0F6417D6L, 0xC318, 0x11D0, 0xA4, 0x3F, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0F6417D6-C318-11D0-A43F-00A0C9223196", KSDATAFORMAT_SPECIFIER_NONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_NONE DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_NONE)

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Quality 0xD16AD380L, 0xAC1A, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("D16AD380-AC1A-11CF-A5D6-28DB04C10000", KSPROPSETID_Quality);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Quality DEFINE_GUIDNAMED(KSPROPSETID_Quality)

public enum KSPROPERTY_QUALITY
{
    KSPROPERTY_QUALITY_REPORT,
    KSPROPERTY_QUALITY_ERROR
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_QUALITY_REPORT(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_QUALITY_REPORT, (GetHandler), sizeof(KSPROPERTY), sizeof(KSQUALITY), (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_QUALITY_ERROR(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_QUALITY_ERROR, (GetHandler), sizeof(KSPROPERTY), sizeof(KSERROR), (SetHandler), NULL, 0, NULL, NULL, 0)

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Connection 0x1D58C920L, 0xAC9B, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1D58C920-AC9B-11CF-A5D6-28DB04C10000", KSPROPSETID_Connection);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Connection DEFINE_GUIDNAMED(KSPROPSETID_Connection)

public enum KSPROPERTY_CONNECTION
{
    KSPROPERTY_CONNECTION_STATE,
    KSPROPERTY_CONNECTION_PRIORITY,
    KSPROPERTY_CONNECTION_DATAFORMAT,
    KSPROPERTY_CONNECTION_ALLOCATORFRAMING,
    KSPROPERTY_CONNECTION_PROPOSEDATAFORMAT,
    KSPROPERTY_CONNECTION_ACQUIREORDERING,
    KSPROPERTY_CONNECTION_ALLOCATORFRAMING_EX,
    KSPROPERTY_CONNECTION_STARTAT
}


// 
// old Framing structure
// 
public class KSALLOCATOR_FRAMING
{
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint OptionsFlags; // allocator options (create)
//        uint RequirementsFlags; // allocation requirements (query)
//    };
#if _NTDDK_
    public POOL_TYPE PoolType = new POOL_TYPE();
#else // !_NTDDK_
    public uint PoolType;
#endif // !_NTDDK_
    public uint Frames; // total number of allowable outstanding frames
    public uint FrameSize; // total size of frame
    public uint FileAlignment;
    public uint Reserved;
}

#if _NTDDK_
public delegate object PFNKSDEFAULTALLOCATE(IN object Context);

public delegate void PFNKSDEFAULTFREE(IN object Context, IN object Buffer);

public delegate NTSTATUS PFNKSINITIALIZEALLOCATOR(IN object InitialContext, IN KSALLOCATOR_FRAMING AllocatorFraming, OUT object[] Context);

public delegate void PFNKSDELETEALLOCATOR(IN object Context);
#endif // !_NTDDK_

// 
// new Framing structure, eventually will replace KSALLOCATOR_FRAMING.
// 
public class KS_FRAMING_RANGE
{
    public uint MinFrameSize;
    public uint MaxFrameSize;
    public uint Stepping;
}


public class KS_FRAMING_RANGE_WEIGHTED
{
    public KS_FRAMING_RANGE Range = new KS_FRAMING_RANGE();
    public uint InPlaceWeight;
    public uint NotInPlaceWeight;
}


public class KS_COMPRESSION
{
    public uint RatioNumerator; // compression/expansion ratio
    public uint RatioDenominator;
    public uint RatioConstantMargin;
}


// 
// Memory Types and Buses are repeated in each entry.
// Easiest to use but takes a little more memory than the varsize layout Pin\Memories\Buses\Ranges.
// 
public class KS_FRAMING_ITEM
{
    public GUID MemoryType = new GUID();
    public GUID BusType = new GUID();
    public uint MemoryFlags;
    public uint BusFlags;
    public uint Flags;
    public uint Frames; // total number of allowable outstanding frames
    public uint FileAlignment;
    public uint MemoryTypeWeight; // this memory type Weight pin-wide
    public KS_FRAMING_RANGE PhysicalRange = new KS_FRAMING_RANGE();
    public KS_FRAMING_RANGE_WEIGHTED FramingRange = new KS_FRAMING_RANGE_WEIGHTED();
}


public class KSALLOCATOR_FRAMING_EX
{
    public uint CountItems; // count of FramingItem-s below.
    public uint PinFlags;
    public KS_COMPRESSION OutputCompression = new KS_COMPRESSION();
    public uint PinWeight; // this pin framing's Weight graph-wide
    public KS_FRAMING_ITEM[] FramingItem = Arrays.InitializeWithDefaultInstances<KS_FRAMING_ITEM>(1);
}



// 
// define memory type GUIDs
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_WILDCARD GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_WILDCARD STATIC_GUID_NULL

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_DONT_CARE GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_DONT_CARE STATIC_GUID_NULL

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_TYPE_DONT_CARE GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KS_TYPE_DONT_CARE STATIC_GUID_NULL

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_SYSTEM 0x091bb638L, 0x603f, 0x11d1, 0xb0, 0x67, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("091bb638-603f-11d1-b067-00a0c9062802", KSMEMORY_TYPE_SYSTEM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_SYSTEM DEFINE_GUIDNAMED(KSMEMORY_TYPE_SYSTEM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_USER 0x8cb0fc28L, 0x7893, 0x11d1, 0xb0, 0x69, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("8cb0fc28-7893-11d1-b069-00a0c9062802", KSMEMORY_TYPE_USER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_USER DEFINE_GUIDNAMED(KSMEMORY_TYPE_USER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_KERNEL_PAGED 0xd833f8f8L, 0x7894, 0x11d1, 0xb0, 0x69, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("d833f8f8-7894-11d1-b069-00a0c9062802", KSMEMORY_TYPE_KERNEL_PAGED);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_KERNEL_PAGED DEFINE_GUIDNAMED(KSMEMORY_TYPE_KERNEL_PAGED)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_KERNEL_NONPAGED 0x4a6d5fc4L, 0x7895, 0x11d1, 0xb0, 0x69, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("4a6d5fc4-7895-11d1-b069-00a0c9062802", KSMEMORY_TYPE_KERNEL_NONPAGED);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_KERNEL_NONPAGED DEFINE_GUIDNAMED(KSMEMORY_TYPE_KERNEL_NONPAGED)

// old KS clients did not specify the device memory type
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEMORY_TYPE_DEVICE_UNKNOWN 0x091bb639L, 0x603f, 0x11d1, 0xb0, 0x67, 0x00, 0xa0, 0xc9, 0x06, 0x28, 0x02
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("091bb639-603f-11d1-b067-00a0c9062802", KSMEMORY_TYPE_DEVICE_UNKNOWN);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEMORY_TYPE_DEVICE_UNKNOWN DEFINE_GUIDNAMED(KSMEMORY_TYPE_DEVICE_UNKNOWN)

// 
// Helper framing macros.
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLARE_SIMPLE_FRAMING_EX(FramingExName, MemoryType, Flags, Frames, Alignment, MinFrameSize, MaxFrameSize) const KSALLOCATOR_FRAMING_EX FramingExName = { 1, 0, { 1, 1, 0 }, 0, { { MemoryType, STATIC_KS_TYPE_DONT_CARE, 0, 0, Flags, Frames, Alignment, 0, { 0, (ULONG)-1, 1 }, { { MinFrameSize, MaxFrameSize, 1 }, 0, 0 } } } }

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SetDefaultKsCompression(KsCompressionPointer) { KsCompressionPointer->RatioNumerator = 1; KsCompressionPointer->RatioDenominator = 1; KsCompressionPointer->RatioConstantMargin = 0;}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SetDontCareKsFramingRange(KsFramingRangePointer) { KsFramingRangePointer->MinFrameSize = 0; KsFramingRangePointer->MaxFrameSize = (ULONG) -1; KsFramingRangePointer->Stepping = 1;}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SetKsFramingRange(KsFramingRangePointer, P_MinFrameSize, P_MaxFrameSize) { KsFramingRangePointer->MinFrameSize = P_MinFrameSize; KsFramingRangePointer->MaxFrameSize = P_MaxFrameSize; KsFramingRangePointer->Stepping = 1;}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SetKsFramingRangeWeighted(KsFramingRangeWeightedPointer, P_MinFrameSize, P_MaxFrameSize) { KS_FRAMING_RANGE *KsFramingRange = &KsFramingRangeWeightedPointer->Range; SetKsFramingRange(KsFramingRange, P_MinFrameSize, P_MaxFrameSize); KsFramingRangeWeightedPointer->InPlaceWeight = 0; KsFramingRangeWeightedPointer->NotInPlaceWeight = 0;}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INITIALIZE_SIMPLE_FRAMING_EX(FramingExPointer, P_MemoryType, P_Flags, P_Frames, P_Alignment, P_MinFrameSize, P_MaxFrameSize) { KS_COMPRESSION *KsCompression = &FramingExPointer->OutputCompression; KS_FRAMING_RANGE *KsFramingRange = &FramingExPointer->FramingItem[0].PhysicalRange; KS_FRAMING_RANGE_WEIGHTED *KsFramingRangeWeighted = &FramingExPointer->FramingItem[0].FramingRange; FramingExPointer->CountItems = 1; FramingExPointer->PinFlags = 0; SetDefaultKsCompression(KsCompression); FramingExPointer->PinWeight = 0; FramingExPointer->FramingItem[0].MemoryType = P_MemoryType; FramingExPointer->FramingItem[0].BusType = KS_TYPE_DONT_CARE; FramingExPointer->FramingItem[0].MemoryFlags = 0; FramingExPointer->FramingItem[0].BusFlags = 0; FramingExPointer->FramingItem[0].Flags = P_Flags; FramingExPointer->FramingItem[0].Frames = P_Frames; FramingExPointer->FramingItem[0].FileAlignment = P_Alignment; FramingExPointer->FramingItem[0].MemoryTypeWeight = 0; SetDontCareKsFramingRange(KsFramingRange); SetKsFramingRangeWeighted(KsFramingRangeWeighted, P_MinFrameSize, P_MaxFrameSize);}



// KSEVENTSETID_StreamAllocator: {75D95571-073C-11d0-A161-0020AFD156E4}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_StreamAllocator 0x75d95571L, 0x073c, 0x11d0, 0xa1, 0x61, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("75d95571-073c-11d0-a161-0020afd156e4", KSEVENTSETID_StreamAllocator);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_StreamAllocator DEFINE_GUIDNAMED(KSEVENTSETID_StreamAllocator)

public enum KSEVENT_STREAMALLOCATOR
{
    KSEVENT_STREAMALLOCATOR_INTERNAL_FREEFRAME,
    KSEVENT_STREAMALLOCATOR_FREEFRAME
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMETHODSETID_StreamAllocator 0xcf6e4341L, 0xec87, 0x11cf, 0xa1, 0x30, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("cf6e4341-ec87-11cf-a130-0020afd156e4", KSMETHODSETID_StreamAllocator);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHODSETID_StreamAllocator DEFINE_GUIDNAMED(KSMETHODSETID_StreamAllocator)

public enum KSMETHOD_STREAMALLOCATOR
{
    KSMETHOD_STREAMALLOCATOR_ALLOC,
    KSMETHOD_STREAMALLOCATOR_FREE
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_ITEM_STREAMALLOCATOR_ALLOC(Handler) DEFINE_KSMETHOD_ITEM( KSMETHOD_STREAMALLOCATOR_ALLOC, KSMETHOD_TYPE_WRITE, (Handler), sizeof(KSMETHOD), sizeof(PVOID), NULL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_ITEM_STREAMALLOCATOR_FREE(Handler) DEFINE_KSMETHOD_ITEM( KSMETHOD_STREAMALLOCATOR_FREE, KSMETHOD_TYPE_READ, (Handler), sizeof(KSMETHOD), sizeof(PVOID), NULL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_ALLOCATORSET(AllocatorSet, MethodAlloc, MethodFree)DEFINE_KSMETHOD_TABLE(AllocatorSet) { DEFINE_KSMETHOD_ITEM_STREAMALLOCATOR_ALLOC(MethodAlloc), DEFINE_KSMETHOD_ITEM_STREAMALLOCATOR_FREE(MethodFree)}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_StreamAllocator 0xcf6e4342L, 0xec87, 0x11cf, 0xa1, 0x30, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("cf6e4342-ec87-11cf-a130-0020afd156e4", KSPROPSETID_StreamAllocator);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_StreamAllocator DEFINE_GUIDNAMED(KSPROPSETID_StreamAllocator)

#if _NTDDK_
public enum KSPROPERTY_STREAMALLOCATOR
{
    KSPROPERTY_STREAMALLOCATOR_FUNCTIONTABLE,
    KSPROPERTY_STREAMALLOCATOR_STATUS
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAMALLOCATOR_FUNCTIONTABLE(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAMALLOCATOR_FUNCTIONTABLE, (Handler), sizeof(KSPROPERTY), sizeof(KSSTREAMALLOCATOR_FUNCTIONTABLE), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_STREAMALLOCATOR_FUNCTIONTABLE

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAMALLOCATOR_STATUS(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAMALLOCATOR_STATUS, (Handler), sizeof(KSPROPERTY), sizeof(KSSTREAMALLOCATOR_STATUS), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_STREAMALLOCATOR_STATUS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ALLOCATORSET(AllocatorSet, PropFunctionTable, PropStatus)DEFINE_KSPROPERTY_TABLE(AllocatorSet) { DEFINE_KSPROPERTY_ITEM_STREAMALLOCATOR_STATUS(PropStatus), DEFINE_KSPROPERTY_ITEM_STREAMALLOCATOR_FUNCTIONTABLE(PropFunctionTable)}
#define DEFINE_KSPROPERTY_ALLOCATORSET

public delegate NTSTATUS PFNALLOCATOR_ALLOCATEFRAME(IN PFILE_OBJECT FileObject, object Frame[] UnnamedParameter);

public delegate void PFNALLOCATOR_FREEFRAME(IN PFILE_OBJECT FileObject, IN object Frame);

public class KSSTREAMALLOCATOR_FUNCTIONTABLE
{
    public PFNALLOCATOR_ALLOCATEFRAME AllocateFrame;
    public PFNALLOCATOR_FREEFRAME FreeFrame;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSSTREAMALLOCATOR_FUNCTIONTABLE *PKSSTREAMALLOCATOR_FUNCTIONTABLE;
#endif // defined(_NTDDK_)

public class KSSTREAMALLOCATOR_STATUS
{
    public KSALLOCATOR_FRAMING Framing = new KSALLOCATOR_FRAMING();
    public uint AllocatedFrames;
    public uint Reserved;
}

public class KSSTREAMALLOCATOR_STATUS_EX
{
    public KSALLOCATOR_FRAMING_EX Framing = new KSALLOCATOR_FRAMING_EX();
    public uint AllocatedFrames;
    public uint Reserved;
}

public class KSTIME
{
    public long Time;
    public uint Numerator;
    public uint Denominator;
}

public class KSSTREAM_HEADER
{
    public uint Size;
    public uint TypeSpecificFlags;
    public KSTIME PresentationTime = new KSTIME();
    public long Duration;
    public uint FrameExtent;
    public uint DataUsed;
    public object Data;
    public uint OptionsFlags;
#if _WIN64
    public uint Reserved;
#endif
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_StreamInterface 0x1fdd8ee1L, 0x9cd3, 0x11d0, 0x82, 0xaa, 0x00, 0x00, 0xf8, 0x22, 0xfe, 0x8a
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1fdd8ee1-9cd3-11d0-82aa-0000f822fe8a", KSPROPSETID_StreamInterface);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_StreamInterface DEFINE_GUIDNAMED(KSPROPSETID_StreamInterface)

public enum KSPROPERTY_STREAMINTERFACE
{
    KSPROPERTY_STREAMINTERFACE_HEADERSIZE
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAMINTERFACE_HEADERSIZE( GetHandler ) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAMINTERFACE_HEADERSIZE, (GetHandler), sizeof(KSPROPERTY), sizeof(ULONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_STREAMINTERFACESET(StreamInterfaceSet, HeaderSizeHandler)DEFINE_KSPROPERTY_TABLE(StreamInterfaceSet) { DEFINE_KSPROPERTY_ITEM_STREAMINTERFACE_HEADERSIZE( HeaderSizeHandler )}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Stream 0x65aaba60L, 0x98ae, 0x11cf, 0xa1, 0x0d, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("65aaba60-98ae-11cf-a10d-0020afd156e4", KSPROPSETID_Stream);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Stream DEFINE_GUIDNAMED(KSPROPSETID_Stream)

public enum KSPROPERTY_STREAM
{
    KSPROPERTY_STREAM_ALLOCATOR,
    KSPROPERTY_STREAM_QUALITY,
    KSPROPERTY_STREAM_DEGRADATION,
    KSPROPERTY_STREAM_MASTERCLOCK,
    KSPROPERTY_STREAM_TIMEFORMAT,
    KSPROPERTY_STREAM_PRESENTATIONTIME,
    KSPROPERTY_STREAM_PRESENTATIONEXTENT,
    KSPROPERTY_STREAM_FRAMETIME,
    KSPROPERTY_STREAM_RATECAPABILITY,
    KSPROPERTY_STREAM_RATE,
    KSPROPERTY_STREAM_PIPE_ID
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_ALLOCATOR(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_ALLOCATOR, (GetHandler), sizeof(KSPROPERTY), sizeof(HANDLE), (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_QUALITY(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_QUALITY, (Handler), sizeof(KSPROPERTY), sizeof(KSQUALITY_MANAGER), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_DEGRADATION(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_DEGRADATION, (GetHandler), sizeof(KSPROPERTY), 0, (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_MASTERCLOCK(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_MASTERCLOCK, (GetHandler), sizeof(KSPROPERTY), sizeof(HANDLE), (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_TIMEFORMAT(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_TIMEFORMAT, (Handler), sizeof(KSPROPERTY), sizeof(GUID), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_PRESENTATIONTIME(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_PRESENTATIONTIME, (GetHandler), sizeof(KSPROPERTY), sizeof(KSTIME), (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_PRESENTATIONEXTENT(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_PRESENTATIONEXTENT, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_FRAMETIME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_FRAMETIME, (Handler), sizeof(KSPROPERTY), sizeof(KSFRAMETIME), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_RATECAPABILITY(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_RATECAPABILITY, (Handler), sizeof(KSRATE_CAPABILITY), sizeof(KSRATE), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_RATE(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_RATE, (GetHandler), sizeof(KSPROPERTY), sizeof(KSRATE), (SetHandler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_STREAM_PIPE_ID(GetHandler, SetHandler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_STREAM_PIPE_ID, (GetHandler), sizeof(KSPROPERTY), sizeof(HANDLE), (SetHandler), NULL, 0, NULL, NULL, 0)

public class KSQUALITY_MANAGER
{
    public IntPtr QualityManager;
    public object Context;
}

public class KSFRAMETIME
{
    public long Duration;
    public uint FrameFlags;
    public uint Reserved;
}

public class KSRATE
{
    public long PresentationStart;
    public long Duration;
    public KSIDENTIFIER Interface = new KSIDENTIFIER();
    public int Rate;
    public uint Flags;
}

public class KSRATE_CAPABILITY
{
    public KSIDENTIFIER Property = new KSIDENTIFIER();
    public KSRATE Rate = new KSRATE();
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Clock 0xDF12A4C0L, 0xAC17, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DF12A4C0-AC17-11CF-A5D6-28DB04C10000", KSPROPSETID_Clock);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCONVERT_PERFORMANCE_TIME(Frequency, PerformanceTime) ((((ULONGLONG)(ULONG)(PerformanceTime).HighPart * NANOSECONDS / (Frequency)) << 32) + ((((((ULONGLONG)(ULONG)(PerformanceTime).HighPart * NANOSECONDS) % (Frequency)) << 32) + ((ULONGLONG)(PerformanceTime).LowPart * NANOSECONDS)) / (Frequency)))

public class KSCLOCK_CREATE
{
    public uint CreateFlags;
}

public class KSCORRELATED_TIME
{
    public long Time;
    public long SystemTime;
}

public class KSRESOLUTION
{
    public long Granularity;
    public long Error;
}

public enum KSPROPERTY_CLOCK
{
    KSPROPERTY_CLOCK_TIME,
    KSPROPERTY_CLOCK_PHYSICALTIME,
    KSPROPERTY_CLOCK_CORRELATEDTIME,
    KSPROPERTY_CLOCK_CORRELATEDPHYSICALTIME,
    KSPROPERTY_CLOCK_RESOLUTION,
    KSPROPERTY_CLOCK_STATE,
#if _NTDDK_
    KSPROPERTY_CLOCK_FUNCTIONTABLE
#endif // defined(_NTDDK_)
}

#if _NTDDK_

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef long(FASTCALL *PFNKSCLOCK_GETTIME)(IN PFILE_OBJECT FileObject);
public delegate long PFNKSCLOCK_GETTIME(IN PFILE_OBJECT FileObject);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef long(FASTCALL *PFNKSCLOCK_CORRELATEDTIME)(IN PFILE_OBJECT FileObject, OUT long * SystemTime);
public delegate long PFNKSCLOCK_CORRELATEDTIME(IN PFILE_OBJECT FileObject, OUT long SystemTime);

public class KSCLOCK_FUNCTIONTABLE
{
    public PFNKSCLOCK_GETTIME GetTime;
    public PFNKSCLOCK_GETTIME GetPhysicalTime;
    public PFNKSCLOCK_CORRELATEDTIME GetCorrelatedTime;
    public PFNKSCLOCK_CORRELATEDTIME GetCorrelatedPhysicalTime;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSCLOCK_FUNCTIONTABLE *PKSCLOCK_FUNCTIONTABLE;

public delegate bool PFNKSSETTIMER(IN object Context, IN PKTIMER Timer, IN LARGE_INTEGER DueTime, IN PKDPC Dpc);

public delegate bool PFNKSCANCELTIMER(IN object Context, IN PKTIMER Timer);

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef long(FASTCALL *PFNKSCORRELATEDTIME)(IN object* Context, OUT long * SystemTime);
public delegate long PFNKSCORRELATEDTIME(IN object Context, OUT long SystemTime);

// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef object* PKSDEFAULTCLOCK;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_TIME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_TIME, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_TIME

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_PHYSICALTIME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_PHYSICALTIME, (Handler), sizeof(KSPROPERTY), sizeof(LONGLONG), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_PHYSICALTIME

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_CORRELATEDTIME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_CORRELATEDTIME, (Handler), sizeof(KSPROPERTY), sizeof(KSCORRELATED_TIME), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_CORRELATEDTIME

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_CORRELATEDPHYSICALTIME(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_CORRELATEDPHYSICALTIME, (Handler), sizeof(KSPROPERTY), sizeof(KSCORRELATED_TIME), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_CORRELATEDPHYSICALTIME

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_RESOLUTION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_RESOLUTION, (Handler), sizeof(KSPROPERTY), sizeof(KSRESOLUTION), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_RESOLUTION

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_STATE(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_STATE, (Handler), sizeof(KSPROPERTY), sizeof(KSSTATE), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_STATE

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_CLOCK_FUNCTIONTABLE(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_CLOCK_FUNCTIONTABLE, (Handler), sizeof(KSPROPERTY), sizeof(KSCLOCK_FUNCTIONTABLE), NULL, NULL, 0, NULL, NULL, 0)
#define DEFINE_KSPROPERTY_ITEM_CLOCK_FUNCTIONTABLE

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_CLOCKSET(ClockSet, PropTime, PropPhysicalTime, PropCorrelatedTime, PropCorrelatedPhysicalTime, PropResolution, PropState, PropFunctionTable)DEFINE_KSPROPERTY_TABLE(ClockSet) { DEFINE_KSPROPERTY_ITEM_CLOCK_TIME(PropTime), DEFINE_KSPROPERTY_ITEM_CLOCK_PHYSICALTIME(PropPhysicalTime), DEFINE_KSPROPERTY_ITEM_CLOCK_CORRELATEDTIME(PropCorrelatedTime), DEFINE_KSPROPERTY_ITEM_CLOCK_CORRELATEDPHYSICALTIME(PropCorrelatedPhysicalTime), DEFINE_KSPROPERTY_ITEM_CLOCK_RESOLUTION(PropResolution), DEFINE_KSPROPERTY_ITEM_CLOCK_STATE(PropState), DEFINE_KSPROPERTY_ITEM_CLOCK_FUNCTIONTABLE(PropFunctionTable),}
#define DEFINE_KSPROPERTY_CLOCKSET

#endif // defined(_NTDDK_)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_Clock 0x364D8E20L, 0x62C7, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("364D8E20-62C7-11CF-A5D6-28DB04C10000", KSEVENTSETID_Clock);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_Clock DEFINE_GUIDNAMED(KSEVENTSETID_Clock)

public enum KSEVENT_CLOCK_POSITION
{
    KSEVENT_CLOCK_INTERVAL_MARK,
    KSEVENT_CLOCK_POSITION_MARK
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_Connection 0x7f4bcbe0L, 0x9ea5, 0x11cf, 0xa5, 0xd6, 0x28, 0xdb, 0x04, 0xc1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7f4bcbe0-9ea5-11cf-a5d6-28db04c10000", KSEVENTSETID_Connection);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_Connection DEFINE_GUIDNAMED(KSEVENTSETID_Connection)

public enum KSEVENT_CONNECTION
{
    KSEVENT_CONNECTION_POSITIONUPDATE,
    KSEVENT_CONNECTION_DATADISCONTINUITY,
    KSEVENT_CONNECTION_TIMEDISCONTINUITY,
    KSEVENT_CONNECTION_PRIORITY,
    KSEVENT_CONNECTION_ENDOFSTREAM
}

public class KSQUALITY
{
    public object Context;
    public uint Proportion;
    public long DeltaTime;
}

public class KSERROR
{
    public object Context;
    public uint Status;
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDEGRADESETID_Standard 0x9F564180L, 0x704C, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9F564180-704C-11D0-A5D6-28DB04C10000", KSDEGRADESETID_Standard);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDEGRADESETID_Standard DEFINE_GUIDNAMED(KSDEGRADESETID_Standard)

public enum KSDEGRADE_STANDARD
{
    KSDEGRADE_STANDARD_SAMPLE,
    KSDEGRADE_STANDARD_QUALITY,
    KSDEGRADE_STANDARD_COMPUTATION,
    KSDEGRADE_STANDARD_SKIP
}

public class KSPROPERTY_MEMBERSLIST
{
    public KSPROPERTY_MEMBERSHEADER MembersHeader = new KSPROPERTY_MEMBERSHEADER();
    public readonly object Members;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSPROPERTY_MEMBERSLIST *PKSPROPERTY_MEMBERSLIST;

public class KSPROPERTY_VALUES
{
    public KSIDENTIFIER PropTypeSet = new KSIDENTIFIER();
    public uint MembersListCount;
    public readonly KSPROPERTY_MEMBERSLIST MembersList;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSPROPERTY_VALUES *PKSPROPERTY_VALUES;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_TABLE(tablename) const KSPROPERTY_ITEM tablename[] =

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM(PropertyId, GetHandler, MinProperty, MinData, SetHandler, Values, RelationsCount, Relations, SupportHandler, SerializedSize){ PropertyId, (PFNKSHANDLER)GetHandler, MinProperty, MinData, (PFNKSHANDLER)SetHandler, (PKSPROPERTY_VALUES)Values, RelationsCount, (PKSPROPERTY)Relations, (PFNKSHANDLER)SupportHandler, (ULONG)SerializedSize}

public class KSPROPERTY_ITEM
{
    public uint PropertyId;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PFNKSHANDLER GetPropertyHandler;
//        bool GetSupported;
//    };
    public uint MinProperty;
    public uint MinData;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PFNKSHANDLER SetPropertyHandler;
//        bool SetSupported;
//    };
    public readonly KSPROPERTY_VALUES Values;
    public uint RelationsCount;
    public readonly KSIDENTIFIER Relations;
    public PFNKSHANDLER SupportHandler;
    public uint SerializedSize;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSPROPERTY_ITEM *PKSPROPERTY_ITEM;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFASTPROPERTY_ITEM(PropertyId, GetHandler, SetHandler){ PropertyId, (PFNKSFASTHANDLER)GetHandler, (PFNKSFASTHANDLER)SetHandler, 0}

public class KSFASTPROPERTY_ITEM
{
    public uint PropertyId;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PFNKSFASTHANDLER GetPropertyHandler;
//        bool GetSupported;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PFNKSFASTHANDLER SetPropertyHandler;
//        bool SetSupported;
//    };
    public uint Reserved;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSFASTPROPERTY_ITEM *PKSFASTPROPERTY_ITEM;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_SET(Set, PropertiesCount, PropertyItem, FastIoCount, FastIoTable){ Set, PropertiesCount, PropertyItem, FastIoCount, FastIoTable}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_SET_TABLE(tablename) const KSPROPERTY_SET tablename[] =

public class KSPROPERTY_SET
{
    public readonly GUID Set;
    public uint PropertiesCount;
    public readonly KSPROPERTY_ITEM PropertyItem;
    public uint FastIoCount;
    public readonly KSFASTPROPERTY_ITEM FastIoTable;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSPROPERTY_SET *PKSPROPERTY_SET;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_TABLE(tablename) const KSMETHOD_ITEM tablename[] =

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_ITEM(MethodId, Flags, MethodHandler, MinMethod, MinData, SupportHandler){ MethodId, (PFNKSHANDLER)MethodHandler, MinMethod, MinData, SupportHandler, Flags}

public class KSMETHOD_ITEM
{
    public uint MethodId;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PFNKSHANDLER MethodHandler;
//        bool MethodSupported;
//    };
    public uint MinMethod;
    public uint MinData;
    public PFNKSHANDLER SupportHandler;
    public uint Flags;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSMETHOD_ITEM *PKSMETHOD_ITEM;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFASTMETHOD_ITEM(MethodId, MethodHandler){ MethodId, (PFNKSFASTHANDLER)MethodHandler}

public class KSFASTMETHOD_ITEM
{
    public uint MethodId;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PFNKSFASTHANDLER MethodHandler;
//        bool MethodSupported;
//    };
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSFASTMETHOD_ITEM *PKSFASTMETHOD_ITEM;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_SET(Set, MethodsCount, MethodItem, FastIoCount, FastIoTable){ Set, MethodsCount, MethodItem, FastIoCount, FastIoTable}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSMETHOD_SET_TABLE(tablename) const KSMETHOD_SET tablename[] =

public class KSMETHOD_SET
{
    public readonly GUID Set;
    public uint MethodsCount;
    public readonly KSMETHOD_ITEM MethodItem;
    public uint FastIoCount;
    public readonly KSFASTMETHOD_ITEM FastIoTable;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSMETHOD_SET *PKSMETHOD_SET;

// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSEVENT_ENTRY KSEVENT_ENTRY, *PKSEVENT_ENTRY;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSEVENT_ENTRY *PKSEVENT_ENTRY;

public delegate NTSTATUS PFNKSADDEVENT(IN PIRP Irp, IN KSEVENTDATA EventData, IN _KSEVENT_ENTRY EventEntry);

public delegate void PFNKSREMOVEEVENT(IN PFILE_OBJECT FileObject, IN _KSEVENT_ENTRY EventEntry);

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSEVENT_TABLE(tablename) const KSEVENT_ITEM tablename[] =

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSEVENT_ITEM(EventId, DataInput, ExtraEntryData, AddHandler, RemoveHandler, SupportHandler){ EventId, DataInput, ExtraEntryData, AddHandler, RemoveHandler, SupportHandler}

public class KSEVENT_ITEM
{
    public uint EventId;
    public uint DataInput;
    public uint ExtraEntryData;
    public PFNKSADDEVENT AddHandler;
    public PFNKSREMOVEEVENT RemoveHandler;
    public PFNKSHANDLER SupportHandler;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSEVENT_ITEM *PKSEVENT_ITEM;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSEVENT_SET(Set, EventsCount, EventItem){ Set, EventsCount, EventItem}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSEVENT_SET_TABLE(tablename) const KSEVENT_SET tablename[] =

public class KSEVENT_SET
{
    public readonly GUID Set;
    public uint EventsCount;
    public readonly KSEVENT_ITEM EventItem;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSEVENT_SET *PKSEVENT_SET;

public class KSDPC_ITEM
{
    public KDPC Dpc = new KDPC();
    public uint ReferenceCount;
    public KSPIN_LOCK AccessLock = new KSPIN_LOCK();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDPC_ITEM *PKSDPC_ITEM;

public class KSBUFFER_ITEM
{
    public KSDPC_ITEM DpcItem = new KSDPC_ITEM();
    public LIST_ENTRY BufferList = new LIST_ENTRY();
}

public class _KSEVENT_ENTRY
{
    public LIST_ENTRY ListEntry = new LIST_ENTRY();
    public object Object;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        PKSDPC_ITEM DpcItem;
//        PKSBUFFER_ITEM BufferItem;
//    };
    public PKSEVENTDATA EventData = new PKSEVENTDATA();
    public uint NotificationType;
    public readonly KSEVENT_SET EventSet;
    public readonly KSEVENT_ITEM EventItem;
    public PFILE_OBJECT FileObject = new PFILE_OBJECT();
    public uint SemaphoreAdjustment;
    public uint Reserved;
    public uint Flags;
}

public enum KSEVENTS_LOCKTYPE
{
    KSEVENTS_NONE,
    KSEVENTS_SPINLOCK,
    KSEVENTS_MUTEX,
    KSEVENTS_FMUTEX,
    KSEVENTS_FMUTEXUNSAFE,
    KSEVENTS_INTERRUPT,
    KSEVENTS_ERESOURCE
}

public class KSOBJECT_CREATE_ITEM
{
    public PDRIVER_DISPATCH Create = new PDRIVER_DISPATCH();
    public object Context;
    public UNICODE_STRING ObjectClass = new UNICODE_STRING();
    public PSECURITY_DESCRIPTOR SecurityDescriptor = new PSECURITY_DESCRIPTOR();
    public uint Flags;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSOBJECT_CREATE_ITEM *PKSOBJECT_CREATE_ITEM;

public delegate void PFNKSITEMFREECALLBACK(IN KSOBJECT_CREATE_ITEM CreateItem);

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSCREATE_DISPATCH_TABLE( tablename ) KSOBJECT_CREATE_ITEM tablename[] =

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSCREATE_ITEM(DispatchCreate, TypeName, Context){ (DispatchCreate), (PVOID)(Context), { sizeof(TypeName) - sizeof(UNICODE_NULL), sizeof(TypeName), (PWCHAR)(TypeName) }, NULL, 0}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSCREATE_ITEMEX(DispatchCreate, TypeName, Context, Flags){ (DispatchCreate), (PVOID)(Context), { sizeof(TypeName) - sizeof(UNICODE_NULL), sizeof(TypeName), (PWCHAR)(TypeName) }, NULL, (Flags)}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSCREATE_ITEMNULL( DispatchCreate, Context ){ DispatchCreate, Context, { 0, 0, NULL, }, NULL, 0}

public class KSOBJECT_CREATE
{
    public uint CreateItemsCount;
    public KSOBJECT_CREATE_ITEM CreateItemsList;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSOBJECT_CREATE *PKSOBJECT_CREATE;

public class KSDISPATCH_TABLE
{
    public PDRIVER_DISPATCH DeviceIoControl = new PDRIVER_DISPATCH();
    public PDRIVER_DISPATCH Read = new PDRIVER_DISPATCH();
    public PDRIVER_DISPATCH Write = new PDRIVER_DISPATCH();
    public PDRIVER_DISPATCH Flush = new PDRIVER_DISPATCH();
    public PDRIVER_DISPATCH Close = new PDRIVER_DISPATCH();
    public PDRIVER_DISPATCH QuerySecurity = new PDRIVER_DISPATCH();
    public PDRIVER_DISPATCH SetSecurity = new PDRIVER_DISPATCH();
    public PFAST_IO_DEVICE_CONTROL FastDeviceIoControl = new PFAST_IO_DEVICE_CONTROL();
    public PFAST_IO_READ FastRead = new PFAST_IO_READ();
    public PFAST_IO_WRITE FastWrite = new PFAST_IO_WRITE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDISPATCH_TABLE *PKSDISPATCH_TABLE;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSDISPATCH_TABLE( tablename, DeviceIoControl, Read, Write, Flush, Close, QuerySecurity, SetSecurity, FastDeviceIoControl, FastRead, FastWrite ) const KSDISPATCH_TABLE tablename = { DeviceIoControl, Read, Write, Flush, Close, QuerySecurity, SetSecurity, FastDeviceIoControl, FastRead, FastWrite, }

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCREATE_ITEM_IRP_STORAGE(Irp) (*(PKSOBJECT_CREATE_ITEM*)&(Irp)->Tail.Overlay.DriverContext[0])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENT_SET_IRP_STORAGE(Irp) (*(const KSEVENT_SET**)&(Irp)->Tail.Overlay.DriverContext[0])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENT_ITEM_IRP_STORAGE(Irp) (*(const KSEVENT_ITEM**)&(Irp)->Tail.Overlay.DriverContext[3])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENT_ENTRY_IRP_STORAGE(Irp) (*(PKSEVENT_ENTRY*)&(Irp)->Tail.Overlay.DriverContext[0])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHOD_SET_IRP_STORAGE(Irp) (*(const KSMETHOD_SET**)&(Irp)->Tail.Overlay.DriverContext[0])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHOD_ITEM_IRP_STORAGE(Irp) (*(const KSMETHOD_ITEM**)&(Irp)->Tail.Overlay.DriverContext[3])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHOD_TYPE_IRP_STORAGE(Irp) (*(ULONG_PTR*)(&(Irp)->Tail.Overlay.DriverContext[2]))
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSQUEUE_SPINLOCK_IRP_STORAGE(Irp) (*(PKSPIN_LOCK*)&(Irp)->Tail.Overlay.DriverContext[1])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPERTY_SET_IRP_STORAGE(Irp) (*(const KSPROPERTY_SET**)&(Irp)->Tail.Overlay.DriverContext[0])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPERTY_ITEM_IRP_STORAGE(Irp) (*(const KSPROPERTY_ITEM**)&(Irp)->Tail.Overlay.DriverContext[3])
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPERTY_ATTRIBUTES_IRP_STORAGE(Irp) (*(PKSATTRIBUTE_LIST*)&(Irp)->Tail.Overlay.DriverContext[2])

// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef object* KSDEVICE_HEADER, KSOBJECT_HEADER;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef object* KSOBJECT_HEADER;

public enum KSCOMPLETION_INVOCATION
{
    KsInvokeOnSuccess = 1,
    KsInvokeOnError = 2,
    KsInvokeOnCancel = 4
}

public enum KSLIST_ENTRY_LOCATION
{
    KsListEntryTail,
    KsListEntryHead
}

public enum KSIRP_REMOVAL_OPERATION
{
    KsAcquireOnly,
    KsAcquireAndRemove,
    KsAcquireOnlySingleItem,
    KsAcquireAndRemoveOnlySingleItem
}

public enum KSSTACK_USE
{
    KsStackCopyToNewLocation,
    KsStackReuseCurrentLocation,
    KsStackUseNewLocation
}

public enum KSTARGET_STATE
{
    KSTARGET_STATE_DISABLED,
    KSTARGET_STATE_ENABLED
}

public delegate NTSTATUS PFNKSIRPLISTCALLBACK(IN PIRP Irp, IN object Context);

public delegate void PFNREFERENCEDEVICEOBJECT(IN object Context);

public delegate void PFNDEREFERENCEDEVICEOBJECT(IN object Context);

public delegate NTSTATUS PFNQUERYREFERENCESTRING(IN object Context, IN OUT string String);

public class BUS_INTERFACE_REFERENCE
{
    // 
    // Standard interface header
    // 

    public INTERFACE Interface = new INTERFACE();

    // 
    // Standard bus interfaces
    // 

    public PFNREFERENCEDEVICEOBJECT ReferenceDeviceObject;
    public PFNDEREFERENCEDEVICEOBJECT DereferenceDeviceObject;
    public PFNQUERYREFERENCESTRING QueryReferenceString;

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef BUS_INTERFACE_REFERENCE *PBUS_INTERFACE_REFERENCE;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_REFERENCE_BUS_INTERFACE STATIC_KSMEDIUMSETID_Standard
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define REFERENCE_BUS_INTERFACE KSMEDIUMSETID_Standard

public delegate NTSTATUS PFNQUERYMEDIUMSLIST(IN object Context, OUT uint MediumsCount, OUT KSIDENTIFIER[] MediumList);

public class BUS_INTERFACE_MEDIUMS
{
    // 
    // Standard interface header
    // 

    public INTERFACE Interface = new INTERFACE();

    // 
    // Interface definition
    // 

    public PFNQUERYMEDIUMSLIST QueryMediumsList;

}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef BUS_INTERFACE_MEDIUMS *PBUS_INTERFACE_MEDIUMS;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_GUID_BUS_INTERFACE_MEDIUMS 0x4EC35C3EL, 0x201B, 0x11D2, 0x87, 0x45, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DEFINE_GUIDSTRUCT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("4EC35C3E-201B-11D2-8745-00A0C9223196", GUID_BUS_INTERFACE_MEDIUMS);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GUID_BUS_INTERFACE_MEDIUMS DEFINE_GUIDNAMED(GUID_BUS_INTERFACE_MEDIUMS)

#endif // defined(_NTDDK_)

#if ! PACK_PRAGMAS_NOT_SUPPORTED
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack1.h>
#endif

public class KSPROPERTY_SERIALHDR
{
    public GUID PropertySet = new GUID();
    public uint Count;
}

#if ! PACK_PRAGMAS_NOT_SUPPORTED
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>
#endif

public class KSPROPERTY_SERIAL
{
    public KSIDENTIFIER PropTypeSet = new KSIDENTIFIER();
    public uint Id;
    public uint PropertyLength;
}

#if _NTDDK_

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IOCTL_KS_HANDSHAKE CTL_CODE(FILE_DEVICE_KS, 0x007, METHOD_NEITHER, FILE_ANY_ACCESS)
#define IOCTL_KS_HANDSHAKE

public class KSHANDSHAKE
{
    public GUID ProtocolId = new GUID();
    public object Argument1;
    public object Argument2;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSHANDSHAKE *PKSHANDSHAKE;

// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSGATE KSGATE, *PKSGATE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct _KSGATE *PKSGATE;

public class _KSGATE
{
    public int Count;
    public PKSGATE NextGate = new PKSGATE();
}

// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct KSAUTOMATION_TABLE_ KSAUTOMATION_TABLE, *PKSAUTOMATION_TABLE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef struct KSAUTOMATION_TABLE_ *PKSAUTOMATION_TABLE;
public class KSAUTOMATION_TABLE_
{
    public uint PropertySetsCount;
    public uint PropertyItemSize;
    public readonly KSPROPERTY_SET PropertySets;
    public uint MethodSetsCount;
    public uint MethodItemSize;
    public readonly KSMETHOD_SET MethodSets;
    public uint EventSetsCount;
    public uint EventItemSize;
    public readonly KSEVENT_SET EventSets;
#if !_WIN64
    public object[] Alignment;
#endif // !defined(_WIN64)
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_TABLE(table) const KSAUTOMATION_TABLE table =
#define DEFINE_KSAUTOMATION_TABLE

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_PROPERTIES(table) SIZEOF_ARRAY(table), sizeof(KSPROPERTY_ITEM), table
#define DEFINE_KSAUTOMATION_PROPERTIES

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_METHODS(table) SIZEOF_ARRAY(table), sizeof(KSMETHOD_ITEM), table
#define DEFINE_KSAUTOMATION_METHODS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_EVENTS(table) SIZEOF_ARRAY(table), sizeof(KSEVENT_ITEM), table
#define DEFINE_KSAUTOMATION_EVENTS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_PROPERTIES_NULL 0, sizeof(KSPROPERTY_ITEM), NULL
#define DEFINE_KSAUTOMATION_PROPERTIES_NULL

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_METHODS_NULL 0, sizeof(KSMETHOD_ITEM), NULL
#define DEFINE_KSAUTOMATION_METHODS_NULL

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSAUTOMATION_EVENTS_NULL 0, sizeof(KSEVENT_ITEM), NULL
#define DEFINE_KSAUTOMATION_EVENTS_NULL

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MIN_DEV_VER_FOR_QI (0x100)
#define MIN_DEV_VER_FOR_QI

public class _KSDEVICE_DISPATCH
{
    public PFNKSDEVICECREATE Add;
    public PFNKSDEVICEPNPSTART Start;
    public PFNKSDEVICE PostStart;
    public PFNKSDEVICEIRP QueryStop;
    public PFNKSDEVICEIRPVOID CancelStop;
    public PFNKSDEVICEIRPVOID Stop;
    public PFNKSDEVICEIRP QueryRemove;
    public PFNKSDEVICEIRPVOID CancelRemove;
    public PFNKSDEVICEIRPVOID Remove;
    public PFNKSDEVICEQUERYCAPABILITIES QueryCapabilities;
    public PFNKSDEVICEIRPVOID SurpriseRemoval;
    public PFNKSDEVICEQUERYPOWER QueryPower;
    public PFNKSDEVICESETPOWER SetPower;
    public PFNKSDEVICEIRP QueryInterface; // added in version 0x100
}

public class _KSFILTER_DISPATCH
{
    public PFNKSFILTERIRP Create;
    public PFNKSFILTERIRP Close;
    public PFNKSFILTERPROCESS Process;
    public PFNKSFILTERVOID Reset;
}

public class _KSPIN_DISPATCH
{
    public PFNKSPINIRP Create;
    public PFNKSPINIRP Close;
    public PFNKSPIN Process;
    public PFNKSPINVOID Reset;
    public PFNKSPINSETDATAFORMAT SetDataFormat;
    public PFNKSPINSETDEVICESTATE SetDeviceState;
    public PFNKSPIN Connect;
    public PFNKSPINVOID Disconnect;
    public readonly KSCLOCK_DISPATCH Clock;
    public readonly KSALLOCATOR_DISPATCH Allocator;
}

public class _KSCLOCK_DISPATCH
{
    public PFNKSPINSETTIMER SetTimer;
    public PFNKSPINCANCELTIMER CancelTimer;
    public PFNKSPINCORRELATEDTIME CorrelatedTime;
    public PFNKSPINRESOLUTION Resolution;
}

public class _KSALLOCATOR_DISPATCH
{
    public PFNKSPININITIALIZEALLOCATOR InitializeAllocator;
    public PFNKSDELETEALLOCATOR DeleteAllocator;
    public PFNKSDEFAULTALLOCATE Allocate;
    public PFNKSDEFAULTFREE Free;
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDEVICE_DESCRIPTOR_VERSION (0x100)
#define KSDEVICE_DESCRIPTOR_VERSION

public class _KSDEVICE_DESCRIPTOR
{
    public readonly KSDEVICE_DISPATCH Dispatch;
    public uint FilterDescriptorsCount;
    public readonly KSFILTER_DESCRIPTOR[] FilterDescriptors;
    public uint Version; // this is 0 for pre-version 100 driver
    // #if !defined(_WIN64)
    // PVOID Alignment;
    // #endif //!defined(_WIN64)
}

public class _KSFILTER_DESCRIPTOR
{
    public readonly KSFILTER_DISPATCH Dispatch;
    public readonly KSAUTOMATION_TABLE AutomationTable;
    public uint Version;
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSFILTER_DESCRIPTOR_VERSION ((ULONG)-1)
#define KSFILTER_DESCRIPTOR_VERSION
    public uint Flags;
    public const int KSFILTER_FLAG_DISPATCH_LEVEL_PROCESSING = 0x00000001;
    public const int KSFILTER_FLAG_CRITICAL_PROCESSING = 0x00000002;
    public const int KSFILTER_FLAG_HYPERCRITICAL_PROCESSING = 0x00000004;
    public const int KSFILTER_FLAG_RECEIVE_ZERO_LENGTH_SAMPLES = 0x00000008;
    public const uint KSFILTER_FLAG_DENY_USERMODE_ACCESS = 0x80000000;
    public readonly GUID ReferenceGuid;
    public uint PinDescriptorsCount;
    public uint PinDescriptorSize;
    public readonly KSPIN_DESCRIPTOR_EX PinDescriptors;
    public uint CategoriesCount;
    public readonly GUID Categories;
    public uint NodeDescriptorsCount;
    public uint NodeDescriptorSize;
    public readonly KSNODE_DESCRIPTOR NodeDescriptors;
    public uint ConnectionsCount;
    public readonly KSTOPOLOGY_CONNECTION Connections;
    public readonly KSCOMPONENTID ComponentId;
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_DESCRIPTOR(descriptor) const KSFILTER_DESCRIPTOR descriptor =
#define DEFINE_KSFILTER_DESCRIPTOR

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_PIN_DESCRIPTORS(table) SIZEOF_ARRAY(table), sizeof(table[0]), table
#define DEFINE_KSFILTER_PIN_DESCRIPTORS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_CATEGORIES(table) SIZEOF_ARRAY(table), table
#define DEFINE_KSFILTER_CATEGORIES

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_CATEGORY(category) 1, &(category)
#define DEFINE_KSFILTER_CATEGORY

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_CATEGORIES_NULL 0, NULL
#define DEFINE_KSFILTER_CATEGORIES_NULL

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_NODE_DESCRIPTORS(table) SIZEOF_ARRAY(table), sizeof(table[0]), table
#define DEFINE_KSFILTER_NODE_DESCRIPTORS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_NODE_DESCRIPTORS_NULL 0, sizeof(KSNODE_DESCRIPTOR), NULL
#define DEFINE_KSFILTER_NODE_DESCRIPTORS_NULL

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_CONNECTIONS(table) SIZEOF_ARRAY(table), table
#define DEFINE_KSFILTER_CONNECTIONS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_DEFAULT_CONNECTIONS 0, NULL
#define DEFINE_KSFILTER_DEFAULT_CONNECTIONS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSFILTER_DESCRIPTOR_TABLE(table) const KSFILTER_DESCRIPTOR*const table[] =
#define DEFINE_KSFILTER_DESCRIPTOR_TABLE

public class _KSPIN_DESCRIPTOR_EX
{
    public readonly KSPIN_DISPATCH Dispatch;
    public readonly KSAUTOMATION_TABLE AutomationTable;
    public KSPIN_DESCRIPTOR PinDescriptor = new KSPIN_DESCRIPTOR();
    public uint Flags;
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPIN_FLAG_DISPATCH_LEVEL_PROCESSING KSFILTER_FLAG_DISPATCH_LEVEL_PROCESSING
#define KSPIN_FLAG_DISPATCH_LEVEL_PROCESSING
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPIN_FLAG_CRITICAL_PROCESSING KSFILTER_FLAG_CRITICAL_PROCESSING
#define KSPIN_FLAG_CRITICAL_PROCESSING
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPIN_FLAG_HYPERCRITICAL_PROCESSING KSFILTER_FLAG_HYPERCRITICAL_PROCESSING
#define KSPIN_FLAG_HYPERCRITICAL_PROCESSING
    public const int KSPIN_FLAG_ASYNCHRONOUS_PROCESSING = 0x00000008;
    public const int KSPIN_FLAG_DO_NOT_INITIATE_PROCESSING = 0x00000010;
    public const int KSPIN_FLAG_INITIATE_PROCESSING_ON_EVERY_ARRIVAL = 0x00000020;
    public const int KSPIN_FLAG_FRAMES_NOT_REQUIRED_FOR_PROCESSING = 0x00000040;
    public const int KSPIN_FLAG_ENFORCE_FIFO = 0x00000080;

    public const int KSPIN_FLAG_GENERATE_MAPPINGS = 0x00000100;
    public const int KSPIN_FLAG_DISTINCT_TRAILING_EDGE = 0x00000200;

    public const int KSPIN_FLAG_PROCESS_IN_RUN_STATE_ONLY = 0x00010000;
    public const int KSPIN_FLAG_SPLITTER = 0x00020000;
    public const int KSPIN_FLAG_USE_STANDARD_TRANSPORT = 0x00040000;
    public const int KSPIN_FLAG_DO_NOT_USE_STANDARD_TRANSPORT = 0x00080000;
    public const int KSPIN_FLAG_FIXED_FORMAT = 0x00100000;
    public const int KSPIN_FLAG_GENERATE_EOS_EVENTS = 0x00200000;
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPIN_FLAG_RENDERER (KSPIN_FLAG_PROCESS_IN_RUN_STATE_ONLY|KSPIN_FLAG_GENERATE_EOS_EVENTS)
#define KSPIN_FLAG_RENDERER
    public const int KSPIN_FLAG_IMPLEMENT_CLOCK = 0x00400000;
    public const int KSPIN_FLAG_SOME_FRAMES_REQUIRED_FOR_PROCESSING = 0x00800000;
    public const int KSPIN_FLAG_PROCESS_IF_ANY_IN_RUN_STATE = 0x01000000;
    public const uint KSPIN_FLAG_DENY_USERMODE_ACCESS = 0x80000000;
    public uint InstancesPossible;
    public uint InstancesNecessary;
    public readonly KSALLOCATOR_FRAMING_EX AllocatorFraming;
    public PFNKSINTERSECTHANDLEREX IntersectHandler;
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_DEFAULT_INTERFACES 0, NULL
#define DEFINE_KSPIN_DEFAULT_INTERFACES

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPIN_DEFAULT_MEDIUMS 0, NULL
#define DEFINE_KSPIN_DEFAULT_MEDIUMS

public class _KSNODE_DESCRIPTOR
{
    public readonly KSAUTOMATION_TABLE AutomationTable;
    public readonly GUID Type;
    public readonly GUID Name;
#if !_WIN64
    public object[] Alignment;
#endif // !defined(_WIN64)
}

#if !_WIN64
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_NODE_DESCRIPTOR(automation,type,name) { (automation), (type), (name), NULL }
#define DEFINE_NODE_DESCRIPTOR
#else // !defined(_WIN64)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_NODE_DESCRIPTOR(automation,type,name) { (automation), (type), (name) }
#define DEFINE_NODE_DESCRIPTOR
#endif // !defined(_WIN64)

public class _KSDEVICE
{
    public readonly KSDEVICE_DESCRIPTOR Descriptor;
    public KSOBJECT_BAG Bag = new KSOBJECT_BAG();
    public object Context;
    public PDEVICE_OBJECT FunctionalDeviceObject = new PDEVICE_OBJECT();
    public PDEVICE_OBJECT PhysicalDeviceObject = new PDEVICE_OBJECT();
    public PDEVICE_OBJECT NextDeviceObject = new PDEVICE_OBJECT();
    public bool Started;
    public SYSTEM_POWER_STATE SystemPowerState = new SYSTEM_POWER_STATE();
    public DEVICE_POWER_STATE DevicePowerState = new DEVICE_POWER_STATE();
}

public class _KSFILTERFACTORY
{
    public readonly KSFILTER_DESCRIPTOR FilterDescriptor;
    public KSOBJECT_BAG Bag = new KSOBJECT_BAG();
    public object Context;
}

public class _KSFILTER
{
    public readonly KSFILTER_DESCRIPTOR Descriptor;
    public KSOBJECT_BAG Bag = new KSOBJECT_BAG();
    public object Context;
}

public class _KSPIN
{
    public readonly KSPIN_DESCRIPTOR_EX Descriptor;
    public KSOBJECT_BAG Bag = new KSOBJECT_BAG();
    public object Context;
    public uint Id;
    public KSPIN_COMMUNICATION Communication;
    public bool ConnectionIsExternal;
    public KSPIN_INTERFACE ConnectionInterface = new KSPIN_INTERFACE();
    public KSPIN_MEDIUM ConnectionMedium = new KSPIN_MEDIUM();
    public KSPRIORITY ConnectionPriority = new KSPRIORITY();
    public PKSDATAFORMAT ConnectionFormat = new PKSDATAFORMAT();
    public KSMULTIPLE_ITEM AttributeList;
    public uint StreamHeaderSize;
    public KSPIN_DATAFLOW DataFlow;
    public KSSTATE DeviceState;
    public KSRESET ResetState;
    public KSSTATE ClientState;
}

public class _KSMAPPING
{
    public PHYSICAL_ADDRESS PhysicalAddress = new PHYSICAL_ADDRESS();
    public uint ByteCount;
    public uint Alignment;
}

public class _KSSTREAM_POINTER_OFFSET
{
#if _NTDDK_
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        byte * Data;
//        PKSMAPPING Mappings;
//    };
#else // !defined(_NTDDK_)
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * Data;
    public byte Data;
#endif // !defined(_NTDDK_)
#if !_WIN64
    public object[] Alignment;
#endif // !defined(_WIN64)
    public uint Count;
    public uint Remaining;
}

public class _KSSTREAM_POINTER
{
    public object Context;
    public PKSPIN Pin = new PKSPIN();
    public PKSSTREAM_HEADER StreamHeader = new PKSSTREAM_HEADER();
    public PKSSTREAM_POINTER_OFFSET Offset = new PKSSTREAM_POINTER_OFFSET();
    public KSSTREAM_POINTER_OFFSET OffsetIn = new KSSTREAM_POINTER_OFFSET();
    public KSSTREAM_POINTER_OFFSET OffsetOut = new KSSTREAM_POINTER_OFFSET();
}

public class _KSPROCESSPIN
{
    public PKSPIN Pin = new PKSPIN();
    public PKSSTREAM_POINTER StreamPointer = new PKSSTREAM_POINTER();
    public PKSPROCESSPIN InPlaceCounterpart = new PKSPROCESSPIN();
    public PKSPROCESSPIN DelegateBranch = new PKSPROCESSPIN();
    public PKSPROCESSPIN CopySource = new PKSPROCESSPIN();
    public object Data;
    public uint BytesAvailable;
    public uint BytesUsed;
    public uint Flags;
    public bool Terminate;
}

public class _KSPROCESSPIN_INDEXENTRY
{
    public PKSPROCESSPIN Pins;
    public uint Count;
}

public enum KSOBJECTTYPE
{
    KsObjectTypeDevice,
    KsObjectTypeFilterFactory,
    KsObjectTypeFilter,
    KsObjectTypePin
}

public delegate void PFNKSFREE(IN object Data);

public delegate void PFNKSPINFRAMERETURN(IN _KSPIN Pin, IN object * Data OPTIONAL, IN uint Size OPTIONAL, IN PMDL Mdl OPTIONAL, IN object * Context OPTIONAL, IN NTSTATUS Status);

public delegate void PFNKSPINIRPCOMPLETION(IN _KSPIN Pin, IN PIRP Irp);

#if _UNKNOWN_H_ || __IUnknown_INTERFACE_DEFINED__

// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef @interface IKsControl* PIKSCONTROL;

#if !DEFINE_ABSTRACT_UNKNOWN

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_ABSTRACT_UNKNOWN() STDMETHOD_(NTSTATUS, QueryInterface)(THIS_ REFIID InterfaceId, PVOID* Interface ) PURE; STDMETHOD_(ULONG,AddRef)(THIS) PURE; STDMETHOD_(ULONG,Release)(THIS) PURE;
#define DEFINE_ABSTRACT_UNKNOWN

#endif //!defined(DEFINE_ABSTRACT_UNKNOWN)

public enum KSSTREAM_POINTER_STATE
{
    KSSTREAM_POINTER_STATE_UNLOCKED = 0,
    KSSTREAM_POINTER_STATE_LOCKED
}