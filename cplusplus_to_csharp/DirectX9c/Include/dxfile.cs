using System;

/***************************************************************************
 *
 *  Copyright (C) 1998-1999 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dxfile.h
 *
 *  Content:    DirectX File public header file
 *
 ***************************************************************************/


#if __cplusplus
#endif





public class _DXFILELOADRESOURCE
{
    public IntPtr hModule;
    public readonly string lpName;
    public readonly string lpType;
}

public class _DXFILELOADMEMORY
{
    public object lpMemory;
    public uint dSize;
}

/*
 * DirectX File object types.
 */

#if ! WIN_TYPES
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define WIN_TYPES(itype, ptype) typedef interface itype *LP##ptype, **LPLP##ptype
#define WIN_TYPES
#endif