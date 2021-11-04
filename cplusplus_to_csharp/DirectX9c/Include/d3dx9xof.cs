using System;

/// ////////////////////////////////////////////////////////////////////////
// 
//  Copyright (C) Microsoft Corporation.  All Rights Reserved.
// 
//  File:       d3dx9xof.h
//  Content:    D3DX .X File types and functions
// 
/// ////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3dx9.h"


#if __cplusplus
#endif // defined( __cplusplus )

// ----------------------------------------------------------------------------
// D3DXF_FILEFORMAT
//   This flag is used to specify what file type to use when saving to disk.
//   _BINARY, and _TEXT are mutually exclusive, while
//   _COMPRESSED is an optional setting that works with all file types.
// ----------------------------------------------------------------------------


// ----------------------------------------------------------------------------
// D3DXF_FILESAVEOPTIONS
//   This flag is used to specify where to save the file to. Each flag is
//   mutually exclusive, indicates the data location of the file, and also
//   chooses which additional data will specify the location.
//   _TOFILE is paired with a filename (LPCSTR)
//   _TOWFILE is paired with a filename (LPWSTR)
// ----------------------------------------------------------------------------


// ----------------------------------------------------------------------------
// D3DXF_FILELOADOPTIONS
//   This flag is used to specify where to load the file from. Each flag is
//   mutually exclusive, indicates the data location of the file, and also
//   chooses which additional data will specify the location.
//   _FROMFILE is paired with a filename (LPCSTR)
//   _FROMWFILE is paired with a filename (LPWSTR)
//   _FROMRESOURCE is paired with a (D3DXF_FILELOADRESOUCE*) description.
//   _FROMMEMORY is paired with a (D3DXF_FILELOADMEMORY*) description.
// ----------------------------------------------------------------------------


// ----------------------------------------------------------------------------
// D3DXF_FILELOADRESOURCE:
// ----------------------------------------------------------------------------

public class _D3DXF_FILELOADRESOURCE
{
    public IntPtr hModule; // Desc
    public readonly string lpName; // Desc
    public readonly string lpType; // Desc
}

// ----------------------------------------------------------------------------
// D3DXF_FILELOADMEMORY:
// ----------------------------------------------------------------------------

public class _D3DXF_FILELOADMEMORY
{
    public LPCVOID lpMemory = new LPCVOID(); // Desc
    public IntPtr dSize; // Desc
}

#if _WIN32 && ! _NO_COM

// {cef08cf9-7b4f-4429-9624-2a690a933201}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXFile, 0xcef08cf9, 0x7b4f, 0x4429, 0x96, 0x24, 0x2a, 0x69, 0x0a, 0x93, 0x32, 0x01);

// {cef08cfa-7b4f-4429-9624-2a690a933201}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXFileSaveObject, 0xcef08cfa, 0x7b4f, 0x4429, 0x96, 0x24, 0x2a, 0x69, 0x0a, 0x93, 0x32, 0x01);

// {cef08cfb-7b4f-4429-9624-2a690a933201}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXFileSaveData, 0xcef08cfb, 0x7b4f, 0x4429, 0x96, 0x24, 0x2a, 0x69, 0x0a, 0x93, 0x32, 0x01);

// {cef08cfc-7b4f-4429-9624-2a690a933201}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXFileEnumObject, 0xcef08cfc, 0x7b4f, 0x4429, 0x96, 0x24, 0x2a, 0x69, 0x0a, 0x93, 0x32, 0x01);

// {cef08cfd-7b4f-4429-9624-2a690a933201}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXFileData, 0xcef08cfd, 0x7b4f, 0x4429, 0x96, 0x24, 0x2a, 0x69, 0x0a, 0x93, 0x32, 0x01);

#endif // defined( _WIN32 ) && !defined( _NO_COM )

#if __cplusplus
#if ! DECLSPEC_UUID
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1100
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLSPEC_UUID( x ) __declspec( uuid( x ) )
#define DECLSPEC_UUID
#else // !( _MSC_VER >= 1100 )
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DECLSPEC_UUID( x )
#define DECLSPEC_UUID
#endif // !( _MSC_VER >= 1100 )
#endif // !defined( DECLSPEC_UUID )

// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("cef08cf9-7b4f-4429-9624-2a690a933201") ID3DXFile;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("cef08cfa-7b4f-4429-9624-2a690a933201") ID3DXFileSaveObject;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("cef08cfb-7b4f-4429-9624-2a690a933201") ID3DXFileSaveData;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("cef08cfc-7b4f-4429-9624-2a690a933201") ID3DXFileEnumObject;
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The #define macro 'DECLSPEC_UUID' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
@interface DECLSPEC_UUID("cef08cfd-7b4f-4429-9624-2a690a933201") ID3DXFileData;

#if _COM_SMARTPTR_TYPEDEF
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(ID3DXFile, __uuidof(ID3DXFile));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(ID3DXFileSaveObject, __uuidof(ID3DXFileSaveObject));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(ID3DXFileSaveData, __uuidof(ID3DXFileSaveData));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(ID3DXFileEnumObject, __uuidof(ID3DXFileEnumObject));
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
_COM_SMARTPTR_TYPEDEF(ID3DXFileData, __uuidof(ID3DXFileData));
#endif // defined( _COM_SMARTPTR_TYPEDEF )
#endif // defined( __cplusplus )