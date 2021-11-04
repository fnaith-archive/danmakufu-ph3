/// //////////////////////////////////////////////////////////////////////////
// 
// Copyright (c) Microsoft Corporation.  All rights reserved.
// 
// Module Name:
// 
//      Mpeg2Bits.h
// 
// Abstract:
// 
//      This file defines the MPEG-2 section header bitfields. These are
//      defined here instead of in mpegstructs.idl because of MIDL
//      compiler conflicts with bitfield definitions.
// 
/// //////////////////////////////////////////////////////////////////////////


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(push)
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(1)


// 
// PID structure
// 

#if __midl

public class PID_BITS_MIDL
{
    public ushort Bits;
}

#else

public class PID_BITS
{
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public ushort Reserved : 3;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public ushort ProgramId : 13;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef PID_BITS *PPID_BITS;

#endif



// 
// Generic MPEG packet header structure
// 

#if __midl

public class MPEG_HEADER_BITS_MIDL
{
    public ushort Bits;
}

#else

public class MPEG_HEADER_BITS
{
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public ushort SectionLength : 12;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public ushort Reserved : 2;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public ushort PrivateIndicator : 1;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public ushort SectionSyntaxIndicator : 1;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef MPEG_HEADER_BITS *PMPEG_HEADER_BITS;

#endif



// 
// Long MPEG packet header structure
// 

#if __midl

public class MPEG_HEADER_VERSION_BITS_MIDL
{
    public byte Bits;
}

#else

public class MPEG_HEADER_VERSION_BITS
{
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte CurrentNextIndicator : 1;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte VersionNumber : 5;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte Reserved : 2;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef MPEG_HEADER_VERSION_BITS *PMPEG_HEADER_VERSION_BITS;

#endif



// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(pop)
