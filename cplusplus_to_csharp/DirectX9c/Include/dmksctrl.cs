/************************************************************************
*                                                                       *
*   dmksctrl.h -- Definition of IKsControl                              *
*                                                                       *
*   Copyright (c) Microsoft Corporation.  All rights reserved.          *
*                                                                       *
*   This header file contains the definition of IKsControl, which       *
*   duplicates definitions from ks.h and ksproxy.h. Your code should    *
*   include ks.h and ksproxy.h directly if you have them (they are      *
*   provided in the Windows 98 DDK and will be in the Windows NT 5      *
*   SDK).                                                               *
*                                                                       *
************************************************************************/


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1200
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(push)
#endif
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201) // Disable warnings on anonymous unions

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack8.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>

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

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_IID_IKsControl 0x28F54685L, 0x06FD, 0x11D2, 0xB2, 0x7A, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

/* 
 * Warning: This will prevent the rest of ks.h from being pulled in if ks.h is 
 * included after dmksctrl.h. Make sure you do not include both headers in
 * the same source file.
 */

#if (_MSC_EXTENSIONS || __cplusplus) && !CINTERFACE
public partial class KSIDENTIFIER
{
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        struct
//        {
//            GUID Set;
//            uint Id;
//            uint Flags;
//        };
//        long Alignment;
//    };
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSIDENTIFIER *PKSIDENTIFIER;
#else
public partial class KSIDENTIFIER
{
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        struct
//        {
//            GUID Set;
//            uint Id;
//            uint Flags;
//        }
//        Data;
//        long Alignment;
//    };
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSIDENTIFIER *PKSIDENTIFIER;
#endif