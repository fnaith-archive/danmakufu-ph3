/// ///////////////////////////////////////////////////////////////////////////
// 
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// 
//  File:       d3dx9shader.h
//  Content:    D3DX Shader APIs
// 
/// ///////////////////////////////////////////////////////////////////////////

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "d3dx9.h"



// ---------------------------------------------------------------------------
// D3DXTX_VERSION:
// --------------
// Version token used to create a procedural texture filler in effects
// Used by D3DXFill[]TX functions
// ---------------------------------------------------------------------------
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXTX_VERSION(_Major,_Minor) (('T' << 24) | ('X' << 16) | ((_Major) << 8) | (_Minor))



// ----------------------------------------------------------------------------
// D3DXSHADER flags:
// -----------------
// D3DXSHADER_DEBUG
//   Insert debug file/line/type/symbol information.
// 
// D3DXSHADER_SKIPVALIDATION
//   Do not validate the generated code against known capabilities and
//   constraints.  This option is only recommended when compiling shaders
//   you KNOW will work.  (ie. have compiled before without this option.)
//   Shaders are always validated by D3D before they are set to the device.
// 
// D3DXSHADER_SKIPOPTIMIZATION 
//   Instructs the compiler to skip optimization steps during code generation.
//   Unless you are trying to isolate a problem in your code using this option 
//   is not recommended.
// 
// D3DXSHADER_PACKMATRIX_ROWMAJOR
//   Unless explicitly specified, matrices will be packed in row-major order
//   on input and output from the shader.
// 
// D3DXSHADER_PACKMATRIX_COLUMNMAJOR
//   Unless explicitly specified, matrices will be packed in column-major 
//   order on input and output from the shader.  This is generally more 
//   efficient, since it allows vector-matrix multiplication to be performed
//   using a series of dot-products.
// 
// D3DXSHADER_PARTIALPRECISION
//   Force all computations in resulting shader to occur at partial precision.
//   This may result in faster evaluation of shaders on some hardware.
// 
// D3DXSHADER_FORCE_VS_SOFTWARE_NOOPT
//   Force compiler to compile against the next highest available software
//   target for vertex shaders.  This flag also turns optimizations off, 
//   and debugging on.  
// 
// D3DXSHADER_FORCE_PS_SOFTWARE_NOOPT
//   Force compiler to compile against the next highest available software
//   target for pixel shaders.  This flag also turns optimizations off, 
//   and debugging on.
// 
// D3DXSHADER_NO_PRESHADER
//   Disables Preshaders. Using this flag will cause the compiler to not 
//   pull out static expression for evaluation on the host cpu
// 
// D3DXSHADER_AVOID_FLOW_CONTROL
//   Hint compiler to avoid flow-control constructs where possible.
// 
// D3DXSHADER_PREFER_FLOW_CONTROL
//   Hint compiler to prefer flow-control constructs where possible.
// 
// ----------------------------------------------------------------------------

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_DEBUG (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_SKIPVALIDATION (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_SKIPOPTIMIZATION (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PACKMATRIX_ROWMAJOR (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PACKMATRIX_COLUMNMAJOR (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PARTIALPRECISION (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_FORCE_VS_SOFTWARE_NOOPT (1 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_FORCE_PS_SOFTWARE_NOOPT (1 << 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_NO_PRESHADER (1 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_AVOID_FLOW_CONTROL (1 << 9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define D3DXSHADER_PREFER_FLOW_CONTROL (1 << 10)



// ----------------------------------------------------------------------------
// D3DXHANDLE:
// -----------
// Handle values used to efficiently reference shader and effect parameters.
// Strings can be used as handles.  However, handles are not always strings.
// ----------------------------------------------------------------------------



// ----------------------------------------------------------------------------
// D3DXMACRO:
// ----------
// Preprocessor macro definition.  The application pass in a NULL-terminated
// array of this structure to various D3DX APIs.  This enables the application
// to #define tokens at runtime, before the file is parsed.
// ----------------------------------------------------------------------------

public class _D3DXMACRO
{
    public readonly string Name;
    public readonly string Definition;

}


// ----------------------------------------------------------------------------
// D3DXSEMANTIC:
// ----------------------------------------------------------------------------

public class _D3DXSEMANTIC
{
    public uint Usage;
    public uint UsageIndex;

}



// ----------------------------------------------------------------------------
// D3DXFRAGMENT_DESC:
// ----------------------------------------------------------------------------

public class _D3DXFRAGMENT_DESC
{
    public readonly string Name;
    public uint Target;

}


// ----------------------------------------------------------------------------
// D3DXREGISTER_SET:
// ----------------------------------------------------------------------------

public enum _D3DXREGISTER_SET
{
    D3DXRS_BOOL,
    D3DXRS_INT4,
    D3DXRS_FLOAT4,
    D3DXRS_SAMPLER,

    // force 32-bit size enum
    D3DXRS_FORCE_DWORD = 0x7fffffff

}


// ----------------------------------------------------------------------------
// D3DXPARAMETER_CLASS:
// ----------------------------------------------------------------------------

public enum _D3DXPARAMETER_CLASS
{
    D3DXPC_SCALAR,
    D3DXPC_VECTOR,
    D3DXPC_MATRIX_ROWS,
    D3DXPC_MATRIX_COLUMNS,
    D3DXPC_OBJECT,
    D3DXPC_STRUCT,

    // force 32-bit size enum
    D3DXPC_FORCE_DWORD = 0x7fffffff

}


// ----------------------------------------------------------------------------
// D3DXPARAMETER_TYPE:
// ----------------------------------------------------------------------------

public enum _D3DXPARAMETER_TYPE
{
    D3DXPT_VOID,
    D3DXPT_BOOL,
    D3DXPT_INT,
    D3DXPT_FLOAT,
    D3DXPT_STRING,
    D3DXPT_TEXTURE,
    D3DXPT_TEXTURE1D,
    D3DXPT_TEXTURE2D,
    D3DXPT_TEXTURE3D,
    D3DXPT_TEXTURECUBE,
    D3DXPT_SAMPLER,
    D3DXPT_SAMPLER1D,
    D3DXPT_SAMPLER2D,
    D3DXPT_SAMPLER3D,
    D3DXPT_SAMPLERCUBE,
    D3DXPT_PIXELSHADER,
    D3DXPT_VERTEXSHADER,
    D3DXPT_PIXELFRAGMENT,
    D3DXPT_VERTEXFRAGMENT,

    // force 32-bit size enum
    D3DXPT_FORCE_DWORD = 0x7fffffff

}


// ----------------------------------------------------------------------------
// D3DXCONSTANTTABLE_DESC:
// ----------------------------------------------------------------------------

public class _D3DXCONSTANTTABLE_DESC
{
    public readonly string Creator; // Creator string
    public uint Version; // Shader version
    public uint Constants; // Number of constants

}


// ----------------------------------------------------------------------------
// D3DXCONSTANT_DESC:
// ----------------------------------------------------------------------------

public class _D3DXCONSTANT_DESC
{
    public readonly string Name; // Constant name

    public D3DXREGISTER_SET RegisterSet = new D3DXREGISTER_SET(); // Register set
    public uint RegisterIndex; // Register index
    public uint RegisterCount; // Number of registers occupied

    public D3DXPARAMETER_CLASS Class = new D3DXPARAMETER_CLASS(); // Class
    public D3DXPARAMETER_TYPE Type = new D3DXPARAMETER_TYPE(); // Component type

    public uint Rows; // Number of rows
    public uint Columns; // Number of columns
    public uint Elements; // Number of array elements
    public uint StructMembers; // Number of structure member sub-parameters

    public uint Bytes; // Data size, in bytes
    public LPCVOID DefaultValue = new LPCVOID(); // Pointer to default value

}



// ----------------------------------------------------------------------------
// ID3DXConstantTable:
// ----------------------------------------------------------------------------


// {AB3C758F-093E-4356-B762-4DB18F1B3A01}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_ID3DXConstantTable, 0xab3c758f, 0x93e, 0x4356, 0xb7, 0x62, 0x4d, 0xb1, 0x8f, 0x1b, 0x3a, 0x1);


// ----------------------------------------------------------------------------
// D3DXINCLUDE_TYPE:
// ----------------------------------------------------------------------------

public enum _D3DXINCLUDE_TYPE
{
    D3DXINC_LOCAL,
    D3DXINC_SYSTEM,

    // force 32-bit size enum
    D3DXINC_FORCE_DWORD = 0x7fffffff

}


/// ///////////////////////////////////////////////////////////////////////////
// Shader comment block layouts //////////////////////////////////////////////
/// ///////////////////////////////////////////////////////////////////////////

// ----------------------------------------------------------------------------
// D3DXSHADER_CONSTANTTABLE:
// -------------------------
// Shader constant information; included as an CTAB comment block inside
// shaders.  All offsets are BYTE offsets from start of CONSTANTTABLE struct.
// Entries in the table are sorted by Name in ascending order.
// ----------------------------------------------------------------------------

public class _D3DXSHADER_CONSTANTTABLE
{
    public uint Size; // sizeof(D3DXSHADER_CONSTANTTABLE)
    public uint Creator; // LPCSTR offset
    public uint Version; // shader version
    public uint Constants; // number of constants
    public uint ConstantInfo; // D3DXSHADER_CONSTANTINFO[Constants] offset
    public uint Flags; // flags shader was compiled with
    public uint Target; // LPCSTR offset

}


public class _D3DXSHADER_CONSTANTINFO
{
    public uint Name; // LPCSTR offset
    public ushort RegisterSet; // D3DXREGISTER_SET
    public ushort RegisterIndex; // register number
    public ushort RegisterCount; // number of registers
    public ushort Reserved; // reserved
    public uint TypeInfo; // D3DXSHADER_TYPEINFO offset
    public uint DefaultValue; // offset of default value

}


public class _D3DXSHADER_TYPEINFO
{
    public ushort Class; // D3DXPARAMETER_CLASS
    public ushort Type; // D3DXPARAMETER_TYPE
    public ushort Rows; // number of rows (matrices)
    public ushort Columns; // number of columns (vectors and matrices)
    public ushort Elements; // array dimension
    public ushort StructMembers; // number of struct members
    public uint StructMemberInfo; // D3DXSHADER_STRUCTMEMBERINFO[Members] offset

}


public class _D3DXSHADER_STRUCTMEMBERINFO
{
    public uint Name; // LPCSTR offset
    public uint TypeInfo; // D3DXSHADER_TYPEINFO offset

}




