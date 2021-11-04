/*++

Copyright (c) Microsoft Corporation. All rights reserved.

Module Name:

    ksguid.h

Abstract:

    Define guids for non-C++.

--*/

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <guiddef.h>

#if DEFINE_GUIDEX
    #undef DEFINE_GUIDEX
#endif
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_GUIDEX(name) EXTERN_C const CDECL GUID __declspec(selectany) name = { STATICGUIDOF(name) }
//C++ TO C# CONVERTER TODO TASK: A test for this #define occurs before this statement, so this statement cannot be moved to the top of the file:
#define DEFINE_GUIDEX

#if ! STATICGUIDOF
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATICGUIDOF(guid) STATIC_##guid
    #define STATICGUIDOF
#endif // !defined(STATICGUIDOF)

#if ! DEFINE_WAVEFORMATEX_GUID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_WAVEFORMATEX_GUID(x) (USHORT)(x), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
#define DEFINE_WAVEFORMATEX_GUID
#endif
