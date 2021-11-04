/******************************************************************
*                                                                 *
*  strsafe.h -- This module defines safer C library string        *
*               routine replacements. These are meant to make C   *
*               a bit more safe in reference to security and      *
*               robustness                                        *
*                                                                 *
*  Copyright (c) Microsoft Corp.  All rights reserved.            *
*                                                                 *
******************************************************************/



#if ! _SIZE_T_DEFINED
#if _WIN64
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef ulong size_t;
#else
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef __w64 uint size_t;
#endif // !_WIN64
#define _SIZE_T_DEFINED
#endif // !_SIZE_T_DEFINED

#if !_WCHAR_T_DEFINED && !_NATIVE_WCHAR_T_DEFINED
#define _WCHAR_T_DEFINED
#endif


#if ! SUCCEEDED
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SUCCEEDED(hr) ((HRESULT)(hr) >= 0)
#define SUCCEEDED
#endif

#if ! FAILED
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FAILED(hr) ((HRESULT)(hr) < 0)
#define FAILED
#endif

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define S_OK ((HRESULT)0x00000000L)

#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _STRSAFE_EXTERN_C extern "C"
#define _STRSAFE_EXTERN_C
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _STRSAFE_EXTERN_C extern
#define _STRSAFE_EXTERN_C
#endif

// If you do not want to use these functions inline (and instead want to link w/ strsafe.lib), then
// #define STRSAFE_LIB before including this header file.
#if STRSAFE_LIB
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFEAPI _STRSAFE_EXTERN_C HRESULT __stdcall
#define STRSAFEAPI
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib, "strsafe.lib")
#elif STRSAFE_LIB_IMPL
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFEAPI _STRSAFE_EXTERN_C HRESULT __stdcall
#define STRSAFEAPI
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFEAPI __inline HRESULT __stdcall
#define STRSAFEAPI
#define STRSAFE_INLINE
#endif

// Some functions always run inline because they use stdin and we want to avoid building multiple
// versions of strsafe lib depending on if you use msvcrt, libcmt, etc.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFE_INLINE_API __inline HRESULT __stdcall

// The user can request no "Cb" or no "Cch" fuctions, but not both!
#if STRSAFE_NO_CB_FUNCTIONS && STRSAFE_NO_CCH_FUNCTIONS
#error cannot specify both STRSAFE_NO_CB_FUNCTIONS and STRSAFE_NO_CCH_FUNCTIONS !!
#endif

// This should only be defined when we are building strsafe.lib
#if STRSAFE_LIB_IMPL
#define STRSAFE_INLINE
#endif


// If both strsafe.h and ntstrsafe.h are included, only use definitions from one.
#if ! _NTSTRSAFE_H_INCLUDED_

#define STRSAFE_MAX_CCH

// Flags for controling the Ex functions
// 
//      STRSAFE_FILL_BYTE(0xFF)     0x000000FF  // bottom byte specifies fill pattern
#define STRSAFE_IGNORE_NULLS
#define STRSAFE_FILL_BEHIND_NULL
#define STRSAFE_FILL_ON_FAILURE
#define STRSAFE_NULL_ON_FAILURE
#define STRSAFE_NO_TRUNCATION

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFE_VALID_FLAGS (0x000000FF | STRSAFE_IGNORE_NULLS | STRSAFE_FILL_BEHIND_NULL | STRSAFE_FILL_ON_FAILURE | STRSAFE_NULL_ON_FAILURE | STRSAFE_NO_TRUNCATION)
#define STRSAFE_VALID_FLAGS

// helper macro to set the fill character and specify buffer filling
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFE_FILL_BYTE(x) ((unsigned long)((x & 0x000000FF) | STRSAFE_FILL_BEHIND_NULL))
#define STRSAFE_FILL_BYTE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFE_FAILURE_BYTE(x) ((unsigned long)((x & 0x000000FF) | STRSAFE_FILL_ON_FAILURE))
#define STRSAFE_FAILURE_BYTE

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STRSAFE_GET_FILL_PATTERN(dwFlags) ((int)(dwFlags & 0x000000FF))
#define STRSAFE_GET_FILL_PATTERN

#endif // _NTSTRSAFE_H_INCLUDED_