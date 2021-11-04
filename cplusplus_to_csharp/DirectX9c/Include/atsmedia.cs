// ------------------------------------------------------------------------------
// File: ATSMedia.h
// 
// Desc: Broadcast Driver Architecture Media Definitions for ATSC
// 
// Copyright (c) 1996-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------


#if !_KSMEDIA_
#error KSMEDIA.H must be included before BDAMEDIA.H
#endif // !defined(_KSMEDIA_)

#if !_BDAMEDIA_
#error BDAMEDIA.H must be included before ATSCMEDIA.H
#endif // !defined(_KSMEDIA_)



// ===========================================================================
// 
//  ATSC Network Type
// 
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_BDANETWORKTYPE_ATSC 0x71985f51, 0x1ca1, 0x11d3, 0x9c, 0xc8, 0x0, 0xc0, 0x4f, 0x79, 0x71, 0xe0
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("71985F51-1CA1-11d3-9CC8-00C04F7971E0", BDANETWORKTYPE_ATSC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define BDANETWORKTYPE_ATSC DEFINE_GUIDNAMED(BDANETWORKTYPE_ATSC)


