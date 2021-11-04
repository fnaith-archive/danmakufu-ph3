﻿// ------------------------------------------------------------------------------
// File: uuids.h
// 
// Desc: Contains the GUIDs for the MediaType type, subtype fields and format
//       types for standard media types, and also class ids for well-known
//       components.
// 
// Copyright (c) 1992 - 2002, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------


// 
//  We want to use this list for generating strings for debugging too
//  so we redefine OUR_GUID_ENTRY depending on what we want to do
// 
//  It is imperative that all entries in this file are declared using
//  OUR_GUID_ENTRY as that macro might have been defined in advance of
//  including this file.  See wxdebug.cpp in sdk\classes\base.
// 

#if ! OUR_GUID_ENTRY
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define OUR_GUID_ENTRY(name, l, w1, w2, b1, b2, b3, b4, b5, b6, b7, b8) DEFINE_GUID(name, l, w1, w2, b1, b2, b3, b4, b5, b6, b7, b8);
    #define OUR_GUID_ENTRY
#endif


// -- to allow consistent labeling of Media types and subtypes --

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIATYPE_NULL GUID_NULL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIASUBTYPE_NULL GUID_NULL

// -- Use this subtype if you don't have a use for a subtype for your type
// e436eb8e-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_None
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_None, 0xe436eb8e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);


// -- major types ---


// 73646976-0000-0010-8000-00AA00389B71  'vids' == MEDIATYPE_Video
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Video, 0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 73647561-0000-0010-8000-00AA00389B71  'auds' == MEDIATYPE_Audio
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Audio, 0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 73747874-0000-0010-8000-00AA00389B71  'txts' == MEDIATYPE_Text
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Text, 0x73747874, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 7364696D-0000-0010-8000-00AA00389B71  'mids' == MEDIATYPE_Midi
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Midi, 0x7364696D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// e436eb83-524f-11ce-9f53-0020af0ba770            MEDIATYPE_Stream
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Stream, 0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// 73(s)76(v)61(a)69(i)-0000-0010-8000-00AA00389B71  'iavs' == MEDIATYPE_Interleaved
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Interleaved, 0x73766169, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 656c6966-0000-0010-8000-00AA00389B71  'file' == MEDIATYPE_File
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_File, 0x656c6966, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 73636d64-0000-0010-8000-00AA00389B71  'scmd' == MEDIATYPE_ScriptCommand
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_ScriptCommand, 0x73636d64, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 670AEA80-3A82-11d0-B79B-00AA003767A7            MEDIATYPE_AUXLine21Data
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_AUXLine21Data, 0x670aea80, 0x3a82, 0x11d0, 0xb7, 0x9b, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

// F72A76E1-EB0A-11D0-ACE4-0000C0CC16BA            MEDIATYPE_VBI
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_VBI, 0xf72a76e1, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// 0482DEE3-7817-11cf-8a03-00aa006ecb65            MEDIATYPE_Timecode
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_Timecode, 0x482dee3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 74726c6d-0000-0010-8000-00AA00389B71  'lmrt' == MEDIATYPE_LMRT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_LMRT, 0x74726c6d, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 74726c6d-0000-0010-8000-00AA00389B71  'urls' == MEDIATYPE_URL_STREAM
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_URL_STREAM, 0x736c7275, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// -- sub types ---

// 4C504C43-0000-0010-8000-00AA00389B71  'CLPL' == MEDIASUBTYPE_CLPL
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_CLPL, 0x4C504C43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 56595559-0000-0010-8000-00AA00389B71  'YUYV' == MEDIASUBTYPE_YUYV
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_YUYV, 0x56595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 56555949-0000-0010-8000-00AA00389B71  'IYUV' == MEDIASUBTYPE_IYUV
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IYUV, 0x56555949, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 39555659-0000-0010-8000-00AA00389B71  'YVU9' == MEDIASUBTYPE_YVU9
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_YVU9, 0x39555659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 31313459-0000-0010-8000-00AA00389B71  'Y411' == MEDIASUBTYPE_Y411
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Y411, 0x31313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 50313459-0000-0010-8000-00AA00389B71  'Y41P' == MEDIASUBTYPE_Y41P
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Y41P, 0x50313459, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 32595559-0000-0010-8000-00AA00389B71  'YUY2' == MEDIASUBTYPE_YUY2
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_YUY2, 0x32595559, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 55595659-0000-0010-8000-00AA00389B71  'YVYU' == MEDIASUBTYPE_YVYU
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_YVYU, 0x55595659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 59565955-0000-0010-8000-00AA00389B71  'UYVY' ==  MEDIASUBTYPE_UYVY
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_UYVY, 0x59565955, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 31313259-0000-0010-8000-00AA00389B71  'Y211' ==  MEDIASUBTYPE_Y211
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Y211, 0x31313259, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 524a4c43-0000-0010-8000-00AA00389B71  'CLJR' ==  MEDIASUBTYPE_CLJR
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_CLJR, 0x524a4c43, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 39304649-0000-0010-8000-00AA00389B71  'IF09' ==  MEDIASUBTYPE_IF09
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IF09, 0x39304649, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 414c5043-0000-0010-8000-00AA00389B71  'CPLA' ==  MEDIASUBTYPE_CPLA
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_CPLA, 0x414c5043, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 47504A4D-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_MJPG
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MJPG, 0x47504A4D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 4A4D5654-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_TVMJ
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_TVMJ, 0x4A4D5654, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 454B4157-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_WAKE
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_WAKE, 0x454B4157, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 43434643-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_CFCC
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_CFCC, 0x43434643, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 47504A49-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_IJPG
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IJPG, 0x47504A49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 6D756C50-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_Plum
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Plum, 0x6D756C50, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// FAST DV-Master
// 53435644-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_DVCS
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_DVCS, 0x53435644, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// FAST DV-Master
// 44535644-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_DVSD
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_DVSD, 0x44535644, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// MIROVideo DV
// 4656444D-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_MDVF
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MDVF, 0x4656444D, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// e436eb78-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB1
// e436eb78-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB1, 0xe436eb78, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb79-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB4, 0xe436eb79, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb7a-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB8
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB8, 0xe436eb7a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb7b-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB565
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB565, 0xe436eb7b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb7c-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB555
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB555, 0xe436eb7c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb7d-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB24
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB24, 0xe436eb7d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb7e-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_RGB32
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB32, 0xe436eb7e, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);


// 
// RGB surfaces that contain per pixel alpha values.
// 

// 297C55AF-E209-4cb3-B757-C76D6B9C88A8            MEDIASUBTYPE_ARGB1555
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB1555, 0x297c55af, 0xe209, 0x4cb3, 0xb7, 0x57, 0xc7, 0x6d, 0x6b, 0x9c, 0x88, 0xa8);

// 6E6415E6-5C24-425f-93CD-80102B3D1CCA            MEDIASUBTYPE_ARGB4444
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB4444, 0x6e6415e6, 0x5c24, 0x425f, 0x93, 0xcd, 0x80, 0x10, 0x2b, 0x3d, 0x1c, 0xca);

// 773c9ac0-3274-11d0-B724-00aa006c1A01            MEDIASUBTYPE_ARGB32
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB32, 0x773c9ac0, 0x3274, 0x11d0, 0xb7, 0x24, 0x0, 0xaa, 0x0, 0x6c, 0x1a, 0x1);


// 2f8bb76d-b644-4550-acf3-d30caa65d5c5            MEDIASUBTYPE_A2R10G10B10
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_A2R10G10B10, 0x2f8bb76d, 0xb644, 0x4550, 0xac, 0xf3, 0xd3, 0x0c, 0xaa, 0x65, 0xd5, 0xc5);

// 576f7893-bdf6-48c4-875f-ae7b81834567            MEDIASUBTYPE_A2B10G10R10
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_A2B10G10R10, 0x576f7893, 0xbdf6, 0x48c4, 0x87, 0x5f, 0xae, 0x7b, 0x81, 0x83, 0x45, 0x67);


// 56555941-0000-0010-8000-00AA00389B71  'AYUV' == MEDIASUBTYPE_AYUV
// 
// See the DX-VA header and documentation for a description of this format.
// 
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AYUV, 0x56555941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 34344941-0000-0010-8000-00AA00389B71  'AI44' == MEDIASUBTYPE_AI44
// 
// See the DX-VA header and documentation for a description of this format.
// 
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AI44, 0x34344941, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 34344149-0000-0010-8000-00AA00389B71  'IA44' == MEDIASUBTYPE_IA44
// 
// See the DX-VA header and documentation for a description of this format.
// 
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IA44, 0x34344149, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);


// 
// DirectX7 D3D Render Target media subtypes.
// 

// 32335237-0000-0010-8000-00AA00389B71  '7R32' == MEDIASUBTYPE_RGB32_D3D_DX7_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB32_D3D_DX7_RT, 0x32335237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 36315237-0000-0010-8000-00AA00389B71  '7R16' == MEDIASUBTYPE_RGB16_D3D_DX7_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB16_D3D_DX7_RT, 0x36315237, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 38384137-0000-0010-8000-00AA00389B71  '7A88' == MEDIASUBTYPE_ARGB32_D3D_DX7_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB32_D3D_DX7_RT, 0x38384137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 34344137-0000-0010-8000-00AA00389B71  '7A44' == MEDIASUBTYPE_ARGB4444_D3D_DX7_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB4444_D3D_DX7_RT, 0x34344137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 35314137-0000-0010-8000-00AA00389B71  '7A15' == MEDIASUBTYPE_ARGB1555_D3D_DX7_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB1555_D3D_DX7_RT, 0x35314137, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);


// 
// DirectX9 D3D Render Target media subtypes.
// 

// 32335239-0000-0010-8000-00AA00389B71  '9R32' == MEDIASUBTYPE_RGB32_D3D_DX9_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB32_D3D_DX9_RT, 0x32335239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 36315239-0000-0010-8000-00AA00389B71  '9R16' == MEDIASUBTYPE_RGB16_D3D_DX9_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RGB16_D3D_DX9_RT, 0x36315239, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 38384139-0000-0010-8000-00AA00389B71  '9A88' == MEDIASUBTYPE_ARGB32_D3D_DX9_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB32_D3D_DX9_RT, 0x38384139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 34344139-0000-0010-8000-00AA00389B71  '9A44' == MEDIASUBTYPE_ARGB4444_D3D_DX9_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB4444_D3D_DX9_RT, 0x34344139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 35314139-0000-0010-8000-00AA00389B71  '9A15' == MEDIASUBTYPE_ARGB1555_D3D_DX9_RT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_ARGB1555_D3D_DX9_RT, 0x35314139, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIASUBTYPE_HASALPHA(mt) ( ((mt).subtype == MEDIASUBTYPE_ARGB4444) || ((mt).subtype == MEDIASUBTYPE_ARGB32) || ((mt).subtype == MEDIASUBTYPE_AYUV) || ((mt).subtype == MEDIASUBTYPE_AI44) || ((mt).subtype == MEDIASUBTYPE_IA44) || ((mt).subtype == MEDIASUBTYPE_ARGB1555) || ((mt).subtype == MEDIASUBTYPE_ARGB32_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB4444_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB1555_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB32_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB4444_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB1555_D3D_DX9_RT) )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIASUBTYPE_HASALPHA7(mt) (((mt).subtype == MEDIASUBTYPE_ARGB32_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB4444_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB1555_D3D_DX7_RT) )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIASUBTYPE_D3D_DX7_RT(mt) (((mt).subtype == MEDIASUBTYPE_ARGB32_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB4444_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB1555_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_RGB32_D3D_DX7_RT) || ((mt).subtype == MEDIASUBTYPE_RGB16_D3D_DX7_RT))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIASUBTYPE_HASALPHA9(mt) (((mt).subtype == MEDIASUBTYPE_ARGB32_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB4444_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB1555_D3D_DX9_RT) )


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MEDIASUBTYPE_D3D_DX9_RT(mt) (((mt).subtype == MEDIASUBTYPE_ARGB32_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB4444_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_ARGB1555_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_RGB32_D3D_DX9_RT) || ((mt).subtype == MEDIASUBTYPE_RGB16_D3D_DX9_RT))


// 
// DX-VA uncompressed surface formats
// 

// 32315659-0000-0010-8000-00AA00389B71  'YV12' ==  MEDIASUBTYPE_YV12
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_YV12, 0x32315659, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 3231564E-0000-0010-8000-00AA00389B71  'NV12' ==  MEDIASUBTYPE_NV12
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_NV12, 0x3231564E, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 31434D49-0000-0010-8000-00AA00389B71  'IMC1' ==  MEDIASUBTYPE_IMC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IMC1, 0x31434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 32434d49-0000-0010-8000-00AA00389B71  'IMC2' ==  MEDIASUBTYPE_IMC2
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IMC2, 0x32434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 33434d49-0000-0010-8000-00AA00389B71  'IMC3' ==  MEDIASUBTYPE_IMC3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IMC3, 0x33434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 34434d49-0000-0010-8000-00AA00389B71  'IMC4' ==  MEDIASUBTYPE_IMC4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IMC4, 0x34434D49, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 30343353-0000-0010-8000-00AA00389B71  'S340' ==  MEDIASUBTYPE_S340
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_S340, 0x30343353, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 32343353-0000-0010-8000-00AA00389B71  'S342' ==  MEDIASUBTYPE_S342
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_S342, 0x32343353, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);


// e436eb7f-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_Overlay
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Overlay, 0xe436eb7f, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb80-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEGPacket
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1Packet, 0xe436eb80, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb81-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEG1Payload
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1Payload, 0xe436eb81, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// 00000050-0000-0010-8000-00AA00389B71         MEDIASUBTYPE_MPEG1AudioPayload
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1AudioPayload, 0x00000050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);

// e436eb82-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEG1SystemStream
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_MPEG1SystemStream, 0xe436eb82, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// the next consecutive number is assigned to MEDIATYPE_Stream and appears higher up
// e436eb84-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEG1System
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1System, 0xe436eb84, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb85-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEG1VideoCD
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1VideoCD, 0xe436eb85, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb86-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEG1Video
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1Video, 0xe436eb86, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb87-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_MPEG1Audio
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_MPEG1Audio, 0xe436eb87, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb88-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_Avi
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Avi, 0xe436eb88, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// {3DB80F90-9412-11d1-ADED-0000F8754B99}          MEDIASUBTYPE_Asf
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Asf, 0x3db80f90, 0x9412, 0x11d1, 0xad, 0xed, 0x0, 0x0, 0xf8, 0x75, 0x4b, 0x99);

// e436eb89-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_QTMovie
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_QTMovie, 0xe436eb89, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// 617a7072-0000-0010-8000-00AA00389B71         MEDIASUBTYPE_Rpza
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_QTRpza, 0x617a7072, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 20636d73-0000-0010-8000-00AA00389B71         MEDIASUBTYPE_Smc
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_QTSmc, 0x20636d73, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 20656c72-0000-0010-8000-00AA00389B71        MEDIASUBTYPE_Rle
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_QTRle, 0x20656c72, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 6765706a-0000-0010-8000-00AA00389B71        MEDIASUBTYPE_Jpeg
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_QTJpeg, 0x6765706a, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// e436eb8a-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_PCMAudio_Obsolete
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_PCMAudio_Obsolete, 0xe436eb8a, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// 00000001-0000-0010-8000-00AA00389B71            MEDIASUBTYPE_PCM
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_PCM, 0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);

// e436eb8b-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_WAVE
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_WAVE, 0xe436eb8b, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb8c-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_AU
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AU, 0xe436eb8c, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436eb8d-524f-11ce-9f53-0020af0ba770            MEDIASUBTYPE_AIFF
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AIFF, 0xe436eb8d, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// 64(d)73(s)76(v)64(d)-0000-0010-8000-00AA00389B71  'dvsd' == MEDIASUBTYPE_dvsd
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_dvsd, 0x64737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 64(d)68(h)76(v)64(d)-0000-0010-8000-00AA00389B71  'dvhd' == MEDIASUBTYPE_dvhd
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_dvhd, 0x64687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 6c(l)73(s)76(v)64(d)-0000-0010-8000-00AA00389B71  'dvsl' == MEDIASUBTYPE_dvsl
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_dvsl, 0x6c737664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 35(5)32(2)76(v)64(d)-0000-0010-8000-00AA00389B71� 'dv25' ==� MEDIASUBTYPE_dv25
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_dv25, 0x35327664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 30(0)35(5)76(v)64(d)-0000-0010-8000-00AA00389B71� 'dv50' ==� MEDIASUBTYPE_dv50
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_dv50, 0x30357664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 31(1)68(h)76(v)64(d)-0000-0010-8000-00AA00389B71� 'dvh1' ==� MEDIASUBTYPE_dvh1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_dvh1, 0x31687664, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// 6E8D4A22-310C-11d0-B79A-00AA003767A7         MEDIASUBTYPE_Line21_BytePair
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Line21_BytePair, 0x6e8d4a22, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

// 6E8D4A23-310C-11d0-B79A-00AA003767A7         MEDIASUBTYPE_Line21_GOPPacket
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Line21_GOPPacket, 0x6e8d4a23, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

// 6E8D4A24-310C-11d0-B79A-00AA003767A7         MEDIASUBTYPE_Line21_VBIRawData
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_Line21_VBIRawData, 0x6e8d4a24, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

// F72A76E3-EB0A-11D0-ACE4-0000C0CC16BA         MEDIASUBTYPE_TELETEXT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_TELETEXT, 0xf72a76e3, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// 2791D576-8E7A-466F-9E90-5D3F3083738B        MEDIASUBTYPE_WSS
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_WSS, 0x2791D576, 0x8E7A, 0x466F, 0x9E, 0x90, 0x5D, 0x3F, 0x30, 0x83, 0x73, 0x8B);

// A1B3F620-9792-4d8d-81A4-86AF25772090        MEDIASUBTYPE_VPS
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_VPS, 0xa1b3f620, 0x9792, 0x4d8d, 0x81, 0xa4, 0x86, 0xaf, 0x25, 0x77, 0x20, 0x90);

// derived from WAVE_FORMAT_DRM
// 00000009-0000-0010-8000-00aa00389b71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_DRM_Audio, 0x00000009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// derived from WAVE_FORMAT_IEEE_FLOAT
// 00000003-0000-0010-8000-00aa00389b71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_IEEE_FLOAT, 0x00000003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// derived from WAVE_FORMAT_DOLBY_AC3_SPDIF
// 00000092-0000-0010-8000-00aa00389b71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_DOLBY_AC3_SPDIF, 0x00000092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// derived from WAVE_FORMAT_RAW_SPORT
// 00000240-0000-0010-8000-00aa00389b71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_RAW_SPORT, 0x00000240, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

// derived from wave format tag 0x241, call it SPDIF_TAG_241h for now
// 00000241-0000-0010-8000-00aa00389b71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_SPDIF_TAG_241h, 0x00000241, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);



// DirectShow DSS definitions

// A0AF4F81-E163-11d0-BAD9-00609744111A
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_DssVideo, 0xa0af4f81, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// A0AF4F82-E163-11d0-BAD9-00609744111A
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_DssAudio, 0xa0af4f82, 0xe163, 0x11d0, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// 5A9B6A40-1A22-11D1-BAD9-00609744111A
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_VPVideo, 0x5a9b6a40, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// 5A9B6A41-1A22-11D1-BAD9-00609744111A
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_VPVBI, 0x5a9b6a41, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// BF87B6E0-8C27-11d0-B3F0-00AA003761C5     Capture graph building
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CaptureGraphBuilder, 0xBF87B6E0, 0x8C27, 0x11d0, 0xB3, 0xF0, 0x0, 0xAA, 0x00, 0x37, 0x61, 0xC5);

// BF87B6E1-8C27-11d0-B3F0-00AA003761C5     New Capture graph building
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CaptureGraphBuilder2, 0xBF87B6E1, 0x8C27, 0x11d0, 0xB3, 0xF0, 0x0, 0xAA, 0x00, 0x37, 0x61, 0xC5);

// e436ebb0-524f-11ce-9f53-0020af0ba770            Prototype filtergraph
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ProtoFilterGraph, 0xe436ebb0, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436ebb1-524f-11ce-9f53-0020af0ba770            Reference clock
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_SystemClock, 0xe436ebb1, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436ebb2-524f-11ce-9f53-0020af0ba770           Filter Mapper
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FilterMapper, 0xe436ebb2, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436ebb3-524f-11ce-9f53-0020af0ba770           Filter Graph
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FilterGraph, 0xe436ebb3, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e436ebb8-524f-11ce-9f53-0020af0ba770           Filter Graph no thread
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FilterGraphNoThread, 0xe436ebb8, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// e4bbd160-4269-11ce-838d-00aa0055595a           MPEG System stream
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MPEG1Doc, 0xe4bbd160, 0x4269, 0x11ce, 0x83, 0x8d, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a);

// 701722e0-8ae3-11ce-a85c-00aa002feab5           MPEG file reader
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FileSource, 0x701722e0, 0x8ae3, 0x11ce, 0xa8, 0x5c, 0x00, 0xaa, 0x00, 0x2f, 0xea, 0xb5);

// 26C25940-4CA9-11ce-A828-00AA002FEAB5           Takes MPEG1 packets as input
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MPEG1PacketPlayer, 0x26c25940, 0x4ca9, 0x11ce, 0xa8, 0x28, 0x0, 0xaa, 0x0, 0x2f, 0xea, 0xb5);

// 336475d0-942a-11ce-a870-00aa002feab5           MPEG splitter
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MPEG1Splitter, 0x336475d0, 0x942a, 0x11ce, 0xa8, 0x70, 0x00, 0xaa, 0x00, 0x2f, 0xea, 0xb5);

// feb50740-7bef-11ce-9bd9-0000e202599c           MPEG video decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CMpegVideoCodec, 0xfeb50740, 0x7bef, 0x11ce, 0x9b, 0xd9, 0x0, 0x0, 0xe2, 0x2, 0x59, 0x9c);

// 4a2286e0-7bef-11ce-9bd9-0000e202599c           MPEG audio decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CMpegAudioCodec, 0x4a2286e0, 0x7bef, 0x11ce, 0x9b, 0xd9, 0x0, 0x0, 0xe2, 0x2, 0x59, 0x9c);

// e30629d3-27e5-11ce-875d-00608cb78066           Text renderer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TextRender, 0xe30629d3, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66);



// {F8388A40-D5BB-11d0-BE5A-0080C706568E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_InfTee, 0xf8388a40, 0xd5bb, 0x11d0, 0xbe, 0x5a, 0x0, 0x80, 0xc7, 0x6, 0x56, 0x8e);

// 1b544c20-fd0b-11ce-8c63-00aa0044b51e           Avi Stream Splitter
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AviSplitter, 0x1b544c20, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e);

// 1b544c21-fd0b-11ce-8c63-00aa0044b51e           Avi File Reader
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AviReader, 0x1b544c21, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e);

// 1b544c22-fd0b-11ce-8c63-00aa0044b51e           Vfw 2.0 Capture Driver
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VfwCapture, 0x1b544c22, 0xfd0b, 0x11ce, 0x8c, 0x63, 0x0, 0xaa, 0x00, 0x44, 0xb5, 0x1e);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CaptureProperties, 0x1B544c22, 0xFD0B, 0x11ce, 0x8C, 0x63, 0x00, 0xAA, 0x00, 0x44, 0xB5, 0x1F);

// e436ebb4-524f-11ce-9f53-0020af0ba770            Control Distributor
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FGControl, 0xe436ebb4, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// 44584800-F8EE-11ce-B2D4-00DD01101B85           .MOV reader (old)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MOVReader, 0x44584800, 0xf8ee, 0x11ce, 0xb2, 0xd4, 0x00, 0xdd, 0x1, 0x10, 0x1b, 0x85);

// D51BD5A0-7548-11cf-A520-0080C77EF58A           QT Splitter
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_QuickTimeParser, 0xd51bd5a0, 0x7548, 0x11cf, 0xa5, 0x20, 0x0, 0x80, 0xc7, 0x7e, 0xf5, 0x8a);

// FDFE9681-74A3-11d0-AFA7-00AA00B67A42           QT Decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_QTDec, 0xfdfe9681, 0x74a3, 0x11d0, 0xaf, 0xa7, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// D3588AB0-0781-11ce-B03A-0020AF0BA770           AVIFile-based reader
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AVIDoc, 0xd3588ab0, 0x0781, 0x11ce, 0xb0, 0x3a, 0x00, 0x20, 0xaf, 0xb, 0xa7, 0x70);

// 70e102b0-5556-11ce-97c0-00aa0055595a           Video renderer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoRenderer, 0x70e102b0, 0x5556, 0x11ce, 0x97, 0xc0, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 1643e180-90f5-11ce-97d5-00aa0055595a           Colour space convertor
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_Colour, 0x1643e180, 0x90f5, 0x11ce, 0x97, 0xd5, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 1da08500-9edc-11cf-bc10-00aa00ac74f6           VGA 16 color ditherer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_Dither, 0x1da08500, 0x9edc, 0x11cf, 0xbc, 0x10, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6);

// 07167665-5011-11cf-BF33-00AA0055595A           Modex video renderer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ModexRenderer, 0x7167665, 0x5011, 0x11cf, 0xbf, 0x33, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a);

// e30629d1-27e5-11ce-875d-00608cb78066           Waveout audio renderer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioRender, 0xe30629d1, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66);

// 05589faf-c356-11ce-bf01-00aa0055595a           Audio Renderer Property Page
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioProperties, 0x05589faf, 0xc356, 0x11ce, 0xbf, 0x01, 0x0, 0xaa, 0x0, 0x55, 0x59, 0x5a);

// 79376820-07D0-11cf-A24D-0020AFD79767           DSound audio renderer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DSoundRender, 0x79376820, 0x07D0, 0x11CF, 0xA2, 0x4D, 0x0, 0x20, 0xAF, 0xD7, 0x97, 0x67);

// e30629d2-27e5-11ce-875d-00608cb78066           Wavein audio recorder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioRecord, 0xe30629d2, 0x27e5, 0x11ce, 0x87, 0x5d, 0x0, 0x60, 0x8c, 0xb7, 0x80, 0x66);

// {2CA8CA52-3C3F-11d2-B73D-00C04FB6BD3D}         IAMAudioInputMixer property page
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioInputMixerProperties, 0x2ca8ca52, 0x3c3f, 0x11d2, 0xb7, 0x3d, 0x0, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d);

// {CF49D4E0-1115-11ce-B03A-0020AF0BA770}         AVI Decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AVIDec, 0xcf49d4e0, 0x1115, 0x11ce, 0xb0, 0x3a, 0x0, 0x20, 0xaf, 0xb, 0xa7, 0x70);

// {A888DF60-1E90-11cf-AC98-00AA004C0FA9}         AVI ICDraw* wrapper
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AVIDraw, 0xa888df60, 0x1e90, 0x11cf, 0xac, 0x98, 0x0, 0xaa, 0x0, 0x4c, 0xf, 0xa9);

// 6a08cf80-0e18-11cf-a24d-0020afd79767       ACM Wrapper
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ACMWrapper, 0x6a08cf80, 0x0e18, 0x11cf, 0xa2, 0x4d, 0x0, 0x20, 0xaf, 0xd7, 0x97, 0x67);

// {e436ebb5-524f-11ce-9f53-0020af0ba770}    Async File Reader
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AsyncReader, 0xe436ebb5, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// {e436ebb6-524f-11ce-9f53-0020af0ba770}    Async URL Reader
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_URLReader, 0xe436ebb6, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// {e436ebb7-524f-11ce-9f53-0020af0ba770}    IPersistMoniker PID
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_PersistMonikerPID, 0xe436ebb7, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

// {D76E2820-1563-11cf-AC98-00AA004C0FA9}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AVICo, 0xd76e2820, 0x1563, 0x11cf, 0xac, 0x98, 0x0, 0xaa, 0x0, 0x4c, 0xf, 0xa9);

// {8596E5F0-0DA5-11d0-BD21-00A0C911CE86}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FileWriter, 0x8596e5f0, 0xda5, 0x11d0, 0xbd, 0x21, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// {E2510970-F137-11CE-8B67-00AA00A3F1A6}     AVI mux filter
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AviDest, 0xe2510970, 0xf137, 0x11ce, 0x8b, 0x67, 0x0, 0xaa, 0x0, 0xa3, 0xf1, 0xa6);

// {C647B5C0-157C-11d0-BD23-00A0C911CE86}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AviMuxProptyPage, 0xc647b5c0, 0x157c, 0x11d0, 0xbd, 0x23, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// {0A9AE910-85C0-11d0-BD42-00A0C911CE86}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AviMuxProptyPage1, 0xa9ae910, 0x85c0, 0x11d0, 0xbd, 0x42, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// {07b65360-c445-11ce-afde-00aa006c14f4}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AVIMIDIRender, 0x07b65360, 0xc445, 0x11ce, 0xaf, 0xde, 0x00, 0xaa, 0x00, 0x6c, 0x14, 0xf4);

// {187463A0-5BB7-11d3-ACBE-0080C75E246E}    WMSDK-based ASF reader
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_WMAsfReader, 0x187463a0, 0x5bb7, 0x11d3, 0xac, 0xbe, 0x0, 0x80, 0xc7, 0x5e, 0x24, 0x6e);

// {7c23220e-55bb-11d3-8b16-00c04fb6bd3d}    WMSDK-based ASF writer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_WMAsfWriter, 0x7c23220e, 0x55bb, 0x11d3, 0x8b, 0x16, 0x0, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d);

//  {afb6c280-2c41-11d3-8a60-0000f81e0e4a}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MPEG2Demultiplexer, 0xafb6c280, 0x2c41, 0x11d3, 0x8a, 0x60, 0x00, 0x00, 0xf8, 0x1e, 0x0e, 0x4a);

// {3ae86b20-7be8-11d1-abe6-00a0c905f375}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MMSPLITTER, 0x3ae86b20, 0x7be8, 0x11d1, 0xab, 0xe6, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75);

// {2DB47AE5-CF39-43c2-B4D6-0CD8D90946F4}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_StreamBufferSink, 0x2db47ae5, 0xcf39, 0x43c2, 0xb4, 0xd6, 0xc, 0xd8, 0xd9, 0x9, 0x46, 0xf4);

// {C9F5FE02-F851-4eb5-99EE-AD602AF1E619}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_StreamBufferSource, 0xc9f5fe02, 0xf851, 0x4eb5, 0x99, 0xee, 0xad, 0x60, 0x2a, 0xf1, 0xe6, 0x19);

// {FA8A68B2-C864-4ba2-AD53-D3876A87494B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_StreamBufferConfig, 0xfa8a68b2, 0xc864, 0x4ba2, 0xad, 0x53, 0xd3, 0x87, 0x6a, 0x87, 0x49, 0x4b);

// {6CFAD761-735D-4aa5-8AFC-AF91A7D61EBA}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_Mpeg2VideoStreamAnalyzer, 0x6cfad761, 0x735d, 0x4aa5, 0x8a, 0xfc, 0xaf, 0x91, 0xa7, 0xd6, 0x1e, 0xba);

// {CCAA63AC-1057-4778-AE92-1206AB9ACEE6}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_StreamBufferRecordingAttributes, 0xccaa63ac, 0x1057, 0x4778, 0xae, 0x92, 0x12, 0x6, 0xab, 0x9a, 0xce, 0xe6);

// {D682C4BA-A90A-42fe-B9E1-03109849C423}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_StreamBufferComposeRecording, 0xd682c4ba, 0xa90a, 0x42fe, 0xb9, 0xe1, 0x3, 0x10, 0x98, 0x49, 0xc4, 0x23);

// {B1B77C00-C3E4-11cf-AF79-00AA00B67A42}               DV video decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVVideoCodec, 0xb1b77c00, 0xc3e4, 0x11cf, 0xaf, 0x79, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// {13AA3650-BB6F-11d0-AFB9-00AA00B67A42}               DV video encoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVVideoEnc, 0x13aa3650, 0xbb6f, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// {4EB31670-9FC6-11cf-AF6E-00AA00B67A42}               DV splitter
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVSplitter, 0x4eb31670, 0x9fc6, 0x11cf, 0xaf, 0x6e, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// {129D7E40-C10D-11d0-AFB9-00AA00B67A42}               DV muxer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVMux, 0x129d7e40, 0xc10d, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// {060AF76C-68DD-11d0-8FC1-00C04FD9189D}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_SeekingPassThru, 0x60af76c, 0x68dd, 0x11d0, 0x8f, 0xc1, 0x0, 0xc0, 0x4f, 0xd9, 0x18, 0x9d);

// 6E8D4A20-310C-11d0-B79A-00AA003767A7                 Line21 (CC) Decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_Line21Decoder, 0x6e8d4a20, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

// E4206432-01A1-4BEE-B3E1-3702C8EDC574                 Line21 (CC) Decoder v2
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_Line21Decoder2, 0xe4206432, 0x01a1, 0x4bee, 0xb3, 0xe1, 0x37, 0x02, 0xc8, 0xed, 0xc5, 0x74);

// {CD8743A1-3736-11d0-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_OverlayMixer, 0xcd8743a1, 0x3736, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {814B9800-1C88-11d1-BAD9-00609744111A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VBISurfaces, 0x814b9800, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// {70BC06E0-5666-11d3-A184-00105AEF9F33}               WST Teletext Decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_WSTDecoder, 0x70bc06e0, 0x5666, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33);

// {301056D0-6DFF-11d2-9EEB-006008039E37}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MjpegDec, 0x301056d0, 0x6dff, 0x11d2, 0x9e, 0xeb, 0x0, 0x60, 0x8, 0x3, 0x9e, 0x37);

// {B80AB0A0-7416-11d2-9EEB-006008039E37}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MJPGEnc, 0xb80ab0a0, 0x7416, 0x11d2, 0x9e, 0xeb, 0x0, 0x60, 0x8, 0x3, 0x9e, 0x37);



// pnp objects and categories
// 62BE5D10-60EB-11d0-BD3B-00A0C911CE86                 ICreateDevEnum
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_SystemDeviceEnum, 0x62BE5D10, 0x60EB, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86);

// 4315D437-5B8C-11d0-BD3B-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CDeviceMoniker, 0x4315D437, 0x5B8C, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86);

// 860BB310-5D01-11d0-BD3B-00A0C911CE86                 Video capture category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoInputDeviceCategory, 0x860BB310, 0x5D01, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CVidCapClassManager, 0x860BB310, 0x5D01, 0x11d0, 0xBD, 0x3B, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86);

// 083863F1-70DE-11d0-BD40-00A0C911CE86                 Filter category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_LegacyAmFilterCategory, 0x083863F1, 0x70DE, 0x11d0, 0xBD, 0x40, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CQzFilterClassManager, 0x083863F1, 0x70DE, 0x11d0, 0xBD, 0x40, 0x00, 0xA0, 0xC9, 0x11, 0xCE, 0x86);

// 33D9A760-90C8-11d0-BD43-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoCompressorCategory, 0x33d9a760, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CIcmCoClassManager, 0x33d9a760, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// 33D9A761-90C8-11d0-BD43-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioCompressorCategory, 0x33d9a761, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CAcmCoClassManager, 0x33d9a761, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// 33D9A762-90C8-11d0-BD43-00A0C911CE86                 Audio source cateogry
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioInputDeviceCategory, 0x33d9a762, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CWaveinClassManager, 0x33d9a762, 0x90c8, 0x11d0, 0xbd, 0x43, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// E0F158E1-CB04-11d0-BD4E-00A0C911CE86                 Audio renderer category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioRendererCategory, 0xe0f158e1, 0xcb04, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CWaveOutClassManager, 0xe0f158e1, 0xcb04, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// 4EFE2452-168A-11d1-BC76-00C04FB9453B                 Midi renderer category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MidiRendererCategory, 0x4EfE2452, 0x168A, 0x11d1, 0xBC, 0x76, 0x0, 0xc0, 0x4F, 0xB9, 0x45, 0x3B);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CMidiOutClassManager, 0x4EfE2452, 0x168A, 0x11d1, 0xBC, 0x76, 0x0, 0xc0, 0x4F, 0xB9, 0x45, 0x3B);

// CC7BFB41-F175-11d1-A392-00E0291F3959     External Renderers Category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TransmitCategory, 0xcc7bfb41, 0xf175, 0x11d1, 0xa3, 0x92, 0x0, 0xe0, 0x29, 0x1f, 0x39, 0x59);

// CC7BFB46-F175-11d1-A392-00E0291F3959     Device Control Filters
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DeviceControlCategory, 0xcc7bfb46, 0xf175, 0x11d1, 0xa3, 0x92, 0x0, 0xe0, 0x29, 0x1f, 0x39, 0x59);

// DA4E3DA0-D07D-11d0-BD50-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ActiveMovieCategories, 0xda4e3da0, 0xd07d, 0x11d0, 0xbd, 0x50, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// 2721AE20-7E70-11D0-A5D6-28DB04C10000
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVDHWDecodersCategory, 0x2721AE20, 0x7E70, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00);

// 7D22E920-5CA9-4787-8C2B-A6779BD11781     Encoder API encoder category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MediaEncoderCategory, 0x7D22E920, 0x5CA9, 0x4787, 0x8C, 0x2B, 0xA6, 0x77, 0x9B, 0xD1, 0x17, 0x81);

// 236C9559-ADCE-4736-BF72-BAB34E392196     Encoder API multiplexer category
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MediaMultiplexerCategory, 0x236C9559, 0xADCE, 0x4736, 0xBF, 0x72, 0xBA, 0xB3, 0x4E, 0x39, 0x21, 0x96);

// CDA42200-BD88-11d0-BD4E-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_FilterMapper2, 0xcda42200, 0xbd88, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);


// 1e651cc0-b199-11d0-8212-00c04fc32c45
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MemoryAllocator, 0x1e651cc0, 0xb199, 0x11d0, 0x82, 0x12, 0x00, 0xc0, 0x4f, 0xc3, 0x2c, 0x45);

// CDBD8D00-C193-11d0-BD4E-00A0C911CE86
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_MediaPropertyBag, 0xcdbd8d00, 0xc193, 0x11d0, 0xbd, 0x4e, 0x0, 0xa0, 0xc9, 0x11, 0xce, 0x86);

// FCC152B7-F372-11d0-8E00-00C04FD7C08B
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DvdGraphBuilder, 0xFCC152B7, 0xF372, 0x11d0, 0x8E, 0x00, 0x00, 0xC0, 0x4F, 0xD7, 0xC0, 0x8B);

// 9B8C4620-2C1A-11d0-8493-00A02438AD48
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVDNavigator, 0x9b8c4620, 0x2c1a, 0x11d0, 0x84, 0x93, 0x0, 0xa0, 0x24, 0x38, 0xad, 0x48);

// f963c5cf-a659-4a93-9638-caf3cd277d13
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVDState, 0xf963c5cf, 0xa659, 0x4a93, 0x96, 0x38, 0xca, 0xf3, 0xcd, 0x27, 0x7d, 0x13);

// CC58E280-8AA1-11d1-B3F1-00AA003761C5
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_SmartTee, 0xcc58e280, 0x8aa1, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5);

// -- format types ---

// 0F6417D6-C318-11D0-A43F-00A0C9223196        FORMAT_None
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_None, 0x0F6417D6, 0xc318, 0x11d0, 0xa4, 0x3f, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96);

// 05589f80-c356-11ce-bf01-00aa0055595a        FORMAT_VideoInfo
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_VideoInfo, 0x05589f80, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// F72A76A0-EB0A-11d0-ACE4-0000C0CC16BA        FORMAT_VideoInfo2
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_VideoInfo2, 0xf72a76A0, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// 05589f81-c356-11ce-bf01-00aa0055595a        FORMAT_WaveFormatEx
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_WaveFormatEx, 0x05589f81, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 05589f82-c356-11ce-bf01-00aa0055595a        FORMAT_MPEGVideo
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_MPEGVideo, 0x05589f82, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 05589f83-c356-11ce-bf01-00aa0055595a        FORMAT_MPEGStreams
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_MPEGStreams, 0x05589f83, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 05589f84-c356-11ce-bf01-00aa0055595a        FORMAT_DvInfo, DVINFO
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_DvInfo, 0x05589f84, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);


// -- Video related GUIDs ---


// 944d4c00-dd52-11ce-bf0e-00aa0055595a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectDrawProperties, 0x944d4c00, 0xdd52, 0x11ce, 0xbf, 0x0e, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 59ce6880-acf8-11cf-b56e-0080c7c4b68a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_PerformanceProperties, 0x59ce6880, 0xacf8, 0x11cf, 0xb5, 0x6e, 0x00, 0x80, 0xc7, 0xc4, 0xb6, 0x8a);

// 418afb70-f8b8-11ce-aac6-0020af0b99a3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_QualityProperties, 0x418afb70, 0xf8b8, 0x11ce, 0xaa, 0xc6, 0x00, 0x20, 0xaf, 0x0b, 0x99, 0xa3);

// 61ded640-e912-11ce-a099-00aa00479a58
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IBaseVideoMixer, 0x61ded640, 0xe912, 0x11ce, 0xa0, 0x99, 0x00, 0xaa, 0x00, 0x47, 0x9a, 0x58);

// 36d39eb0-dd75-11ce-bf0e-00aa0055595a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawVideo, 0x36d39eb0, 0xdd75, 0x11ce, 0xbf, 0x0e, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// bd0ecb0-f8e2-11ce-aac6-0020af0b99a3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IQualProp, 0x1bd0ecb0, 0xf8e2, 0x11ce, 0xaa, 0xc6, 0x00, 0x20, 0xaf, 0x0b, 0x99, 0xa3);

// {CE292861-FC88-11d0-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VPObject, 0xce292861, 0xfc88, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {CE292862-FC88-11d0-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPObject, 0xce292862, 0xfc88, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {25DF12C1-3DE0-11d1-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPControl, 0x25df12c1, 0x3de0, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {814B9801-1C88-11d1-BAD9-00609744111A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VPVBIObject, 0x814b9801, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// {814B9802-1C88-11d1-BAD9-00609744111A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPVBIObject, 0x814b9802, 0x1c88, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// {BC29A660-30E3-11d0-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPConfig, 0xbc29a660, 0x30e3, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {C76794A1-D6C5-11d0-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPNotify, 0xc76794a1, 0xd6c5, 0x11d0, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {EBF47183-8764-11d1-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPNotify2, 0xebf47183, 0x8764, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);


// {EC529B00-1A1F-11D1-BAD9-00609744111A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPVBIConfig, 0xec529b00, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// {EC529B01-1A1F-11D1-BAD9-00609744111A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IVPVBINotify, 0xec529b01, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a);

// {593CDDE1-0759-11d1-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IMixerPinConfig, 0x593cdde1, 0x759, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);

// {EBF47182-8764-11d1-9E69-00C04FD7C15B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IMixerPinConfig2, 0xebf47182, 0x8764, 0x11d1, 0x9e, 0x69, 0x0, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b);


// This is a real pain in the neck. The OLE GUIDs are separated out into a
// different file from the main header files. The header files can then be
// included multiple times and are protected with the following statements,
// 
//      #ifndef __SOMETHING_DEFINED__
//      #define __SOMETHING_DEFINED__
//          all the header contents
//      #endif // __SOMETHING_DEFINED__
// 
// When the actual GUIDs are to be defined (using initguid) the GUID header
// file can then be included to really define them just once. Unfortunately
// DirectDraw has the GUIDs defined in the main header file. So if the base
// classes bring in ddraw.h to get at the DirectDraw structures and so on
// nobody would then be able to really include ddraw.h to allocate the GUID
// memory structures because of the aforementioned header file protection
// Therefore the DirectDraw GUIDs are defined and allocated for real here

#if ! __DDRAW_INCLUDED__
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectDraw, 0xD7B70EE0, 0x4340, 0x11CF, 0xB0, 0x63, 0x00, 0x20, 0xAF, 0xC2, 0xCD, 0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectDrawClipper, 0x593817A0, 0x7DB3, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xb9, 0x33, 0x56);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDraw, 0x6C14DB80, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDraw2, 0xB3A6F3E0, 0x2B43, 0x11CF, 0xA2, 0xDE, 0x00, 0xAA, 0x00, 0xB9, 0x33, 0x56);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface, 0x6C14DB81, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface2, 0x57805885, 0x6eec, 0x11cf, 0x94, 0x41, 0xa8, 0x23, 0x03, 0xc1, 0x0e, 0x27);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface3, 0xDA044E00, 0x69B2, 0x11D0, 0xA1, 0xD5, 0x00, 0xAA, 0x00, 0xB8, 0xDF, 0xBB);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface4, 0x0B2B8630, 0xAD35, 0x11D0, 0x8E, 0xA6, 0x00, 0x60, 0x97, 0x97, 0xEA, 0x5B);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurface7, 0x06675a80, 0x3b9b, 0x11d2, 0xb9, 0x2f, 0x00, 0x60, 0x97, 0x97, 0xea, 0x5b);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawPalette, 0x6C14DB84, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawClipper, 0x6C14DB85, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawColorControl, 0x4B9F0EE0, 0x0D7E, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8);
#endif

#if ! __DVP_INCLUDED__
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDDVideoPortContainer, 0x6C142760, 0xA733, 0x11CE, 0xA5, 0x21, 0x00, 0x20, 0xAF, 0x0B, 0xE5, 0x60);
#endif

#if ! __DDKM_INCLUDED__
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawKernel, 0x8D56C120, 0x6A08, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawSurfaceKernel, 0x60755DA0, 0x6A40, 0x11D0, 0x9B, 0x06, 0x00, 0xA0, 0xC9, 0x03, 0xA3, 0xB8);
#endif

// 0618aa30-6bc4-11cf-bf36-00aa0055595a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ModexProperties, 0x0618aa30, 0x6bc4, 0x11cf, 0xbf, 0x36, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// dd1d7110-7836-11cf-bf47-00aa0055595a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IFullScreenVideo, 0xdd1d7110, 0x7836, 0x11cf, 0xbf, 0x47, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a);

// 53479470-f1dd-11cf-bc42-00aa00ac74f6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IFullScreenVideoEx, 0x53479470, 0xf1dd, 0x11cf, 0xbc, 0x42, 0x00, 0xaa, 0x00, 0xac, 0x74, 0xf6);

// {101193C0-0BFE-11d0-AF91-00AA00B67A42}           DV decoder property
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVDecPropertiesPage, 0x101193c0, 0xbfe, 0x11d0, 0xaf, 0x91, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// {4150F050-BB6F-11d0-AFB9-00AA00B67A42}           DV encoder property
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVEncPropertiesPage, 0x4150f050, 0xbb6f, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);

// {4DB880E0-C10D-11d0-AFB9-00AA00B67A42}           DV Muxer property
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVMuxPropertyPage, 0x4db880e0, 0xc10d, 0x11d0, 0xaf, 0xb9, 0x0, 0xaa, 0x0, 0xb6, 0x7a, 0x42);


// -- Direct Sound Audio related GUID ---

// 546F4260-D53E-11cf-B3F0-00AA003761C5
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IAMDirectSound, 0x546f4260, 0xd53e, 0x11cf, 0xb3, 0xf0, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5);

// -- MPEG audio decoder properties

// {b45dd570-3c77-11d1-abe1-00a0c905f375}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IMpegAudioDecoder, 0xb45dd570, 0x3c77, 0x11d1, 0xab, 0xe1, 0x00, 0xa0, 0xc9, 0x05, 0xf3, 0x75);

// --- Line21 Decoder interface GUID ---

// 6E8D4A21-310C-11d0-B79A-00AA003767A7            IID_IAMLine21Decoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IAMLine21Decoder, 0x6e8d4a21, 0x310c, 0x11d0, 0xb7, 0x9a, 0x0, 0xaa, 0x0, 0x37, 0x67, 0xa7);

// --- WST Decoder interface GUID ---

// C056DE21-75C2-11d3-A184-00105AEF9F33            IID_IAMWstDecoder
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IAMWstDecoder, 0xc056de21, 0x75c2, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33);

// --- WST Decoder Property Page ---

// 04E27F80-91E4-11d3-A184-00105AEF9F33            WST Decoder Property Page
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_WstDecoderPropertyPage, 0x4e27f80, 0x91e4, 0x11d3, 0xa1, 0x84, 0x0, 0x10, 0x5a, 0xef, 0x9f, 0x33);


// -- Analog video related GUIDs ---


// -- format types ---
// 0482DDE0-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(FORMAT_AnalogVideo, 0x482dde0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);


// -- major type, Analog Video

// 0482DDE1-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_AnalogVideo, 0x482dde1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);


// -- Analog Video subtypes, NTSC

// 0482DDE2-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_NTSC_M, 0x482dde2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// -- Analog Video subtypes, PAL

// 0482DDE5-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_B, 0x482dde5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDE6-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_D, 0x482dde6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDE7-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_G, 0x482dde7, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDE8-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_H, 0x482dde8, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDE9-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_I, 0x482dde9, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDEA-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_M, 0x482ddea, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDEB-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_N, 0x482ddeb, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDEC-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_PAL_N_COMBO, 0x482ddec, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// -- Analog Video subtypes, SECAM

// 0482DDF0-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_B, 0x482ddf0, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDF1-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_D, 0x482ddf1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDF2-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_G, 0x482ddf2, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDF3-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_H, 0x482ddf3, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDF4-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_K, 0x482ddf4, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDF5-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_K1, 0x482ddf5, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 0482DDF6-7817-11cf-8A03-00AA006ECB65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIASUBTYPE_AnalogVideo_SECAM_L, 0x482ddf6, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);


// --  External audio related GUIDs ---

// -- major types, Analog Audio

// 0482DEE1-7817-11cf-8a03-00aa006ecb65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MEDIATYPE_AnalogAudio, 0x482dee1, 0x7817, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// 
// DirectShow's include file based on ksmedia.h from WDM DDK
// 


// -- Well known time format GUIDs ---


// 00000000-0000-0000-0000-000000000000
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(TIME_FORMAT_NONE, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0);

// 7b785570-8c82-11cf-bc0c-00aa00ac74f6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(TIME_FORMAT_FRAME, 0x7b785570, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

// 7b785571-8c82-11cf-bc0c-00aa00ac74f6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(TIME_FORMAT_BYTE, 0x7b785571, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

// 7b785572-8c82-11cf-bc0c-00aa00ac74f6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(TIME_FORMAT_SAMPLE, 0x7b785572, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);

// 7b785573-8c82-11cf-bc0c-00aa00ac74f6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(TIME_FORMAT_FIELD, 0x7b785573, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);


// 7b785574-8c82-11cf-bc0c-00aa00ac74f6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(TIME_FORMAT_MEDIA_TIME, 0x7b785574, 0x8c82, 0x11cf, 0xbc, 0xc, 0x0, 0xaa, 0x0, 0xac, 0x74, 0xf6);


// for IKsPropertySet

// 9B00F101-1567-11d1-B3F1-00AA003761C5
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(AMPROPSETID_Pin, 0x9b00f101, 0x1567, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5);

// fb6c4281-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_CAPTURE, 0xfb6c4281, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4282-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_PREVIEW, 0xfb6c4282, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4283-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_ANALOGVIDEOIN, 0xfb6c4283, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4284-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_VBI, 0xfb6c4284, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4285-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_VIDEOPORT, 0xfb6c4285, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4286-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_NABTS, 0xfb6c4286, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4287-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_EDS, 0xfb6c4287, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4288-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_TELETEXT, 0xfb6c4288, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c4289-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_CC, 0xfb6c4289, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c428a-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_STILL, 0xfb6c428a, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c428b-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_TIMECODE, 0xfb6c428b, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);

// fb6c428c-0353-11d1-905f-0000c0cc16ba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(PIN_CATEGORY_VIDEOPORT_VBI, 0xfb6c428c, 0x0353, 0x11d1, 0x90, 0x5f, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba);


// the following special GUIDS are used by ICaptureGraphBuilder::FindInterface

// {AC798BE0-98E3-11d1-B3F1-00AA003761C5}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(LOOK_UPSTREAM_ONLY, 0xac798be0, 0x98e3, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5);

// {AC798BE1-98E3-11d1-B3F1-00AA003761C5}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(LOOK_DOWNSTREAM_ONLY, 0xac798be1, 0x98e3, 0x11d1, 0xb3, 0xf1, 0x0, 0xaa, 0x0, 0x37, 0x61, 0xc5);

// -------------------------------------------------------------------------
// KSProxy GUIDS
// -------------------------------------------------------------------------

// {266EEE41-6C63-11cf-8A03-00AA006ECB65}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TVTunerFilterPropertyPage, 0x266eee41, 0x6c63, 0x11cf, 0x8a, 0x3, 0x0, 0xaa, 0x0, 0x6e, 0xcb, 0x65);

// {71F96461-78F3-11d0-A18C-00A0C9118956}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CrossbarFilterPropertyPage, 0x71f96461, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56);

// {71F96463-78F3-11d0-A18C-00A0C9118956}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TVAudioFilterPropertyPage, 0x71f96463, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56);

// {71F96464-78F3-11d0-A18C-00A0C9118956}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoProcAmpPropertyPage, 0x71f96464, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56);

// {71F96465-78F3-11d0-A18C-00A0C9118956}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_CameraControlPropertyPage, 0x71f96465, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56);

// {71F96466-78F3-11d0-A18C-00A0C9118956}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AnalogVideoDecoderPropertyPage, 0x71f96466, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56);

// {71F96467-78F3-11d0-A18C-00A0C9118956}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoStreamConfigPropertyPage, 0x71f96467, 0x78f3, 0x11d0, 0xa1, 0x8c, 0x0, 0xa0, 0xc9, 0x11, 0x89, 0x56);

// {37E92A92-D9AA-11d2-BF84-8EF2B1555AED} Audio Renderer Advanced Property Page
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AudioRendererAdvancedProperties, 0x37e92a92, 0xd9aa, 0x11d2, 0xbf, 0x84, 0x8e, 0xf2, 0xb1, 0x55, 0x5a, 0xed);


// -------------------------------------------------------------------------
// VMR GUIDS
// -------------------------------------------------------------------------

// {B87BEB7B-8D29-423f-AE4D-6582C10175AC}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoMixingRenderer, 0xB87BEB7B, 0x8D29, 0x423f, 0xAE, 0x4D, 0x65, 0x82, 0xC1, 0x01, 0x75, 0xAC);

// {6BC1CFFA-8FC1-4261-AC22-CFB4CC38DB50}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoRendererDefault, 0x6BC1CFFA, 0x8FC1, 0x4261, 0xAC, 0x22, 0xCF, 0xB4, 0xCC, 0x38, 0xDB, 0x50);

// {99d54f63-1a69-41ae-aa4d-c976eb3f0713}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AllocPresenter, 0x99d54f63, 0x1a69, 0x41ae, 0xaa, 0x4d, 0xc9, 0x76, 0xeb, 0x3f, 0x07, 0x13);

// {4444ac9e-242e-471b-a3c7-45dcd46352bc}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_AllocPresenterDDXclMode, 0x4444ac9e, 0x242e, 0x471b, 0xa3, 0xc7, 0x45, 0xdc, 0xd4, 0x63, 0x52, 0xbc);

// {6f26a6cd-967b-47fd-874a-7aed2c9d25a2}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoPortManager, 0x6f26a6cd, 0x967b, 0x47fd, 0x87, 0x4a, 0x7a, 0xed, 0x2c, 0x9d, 0x25, 0xa2);


// -------------------------------------------------------------------------
// VMR GUIDS for DX9
// -------------------------------------------------------------------------

// {51b4abf3-748f-4e3b-a276-c828330e926a}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_VideoMixingRenderer9, 0x51b4abf3, 0x748f, 0x4e3b, 0xa2, 0x76, 0xc8, 0x28, 0x33, 0x0e, 0x92, 0x6a);




// -------------------------------------------------------------------------
// BDA Network Provider GUIDS
// -------------------------------------------------------------------------

// {0DAD2FDD-5FD7-11D3-8F50-00C04F7971E2}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ATSCNetworkProvider, 0x0dad2fdd, 0x5fd7, 0x11d3, 0x8f, 0x50, 0x00, 0xc0, 0x4f, 0x79, 0x71, 0xe2);

// {E3444D16-5AC4-4386-88DF-13FD230E1DDA}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ATSCNetworkPropertyPage, 0xe3444d16, 0x5ac4, 0x4386, 0x88, 0xdf, 0x13, 0xfd, 0x23, 0x0e, 0x1d, 0xda);

// {FA4B375A-45B4-4d45-8440-263957B11623}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVBSNetworkProvider, 0xfa4b375a, 0x45b4, 0x4d45, 0x84, 0x40, 0x26, 0x39, 0x57, 0xb1, 0x16, 0x23);

// {216C62DF-6D7F-4e9a-8571-05F14EDB766A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVBTNetworkProvider, 0x216c62df, 0x6d7f, 0x4e9a, 0x85, 0x71, 0x5, 0xf1, 0x4e, 0xdb, 0x76, 0x6a);

// {DC0C0FE7-0485-4266-B93F-68FBF80ED834}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DVBCNetworkProvider, 0xdc0c0fe7, 0x485, 0x4266, 0xb9, 0x3f, 0x68, 0xfb, 0xf8, 0xe, 0xd8, 0x34);




// -------------------------------------------------------------------------
// TVE Receiver filter guids
// -------------------------------------------------------------------------

// The CLSID used by the TVE Receiver filter
// {05500280-FAA5-4DF9-8246-BFC23AC5CEA8}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DShowTVEFilter, 0x05500280, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8);

// {05500281-FAA5-4DF9-8246-BFC23AC5CEA8}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TVEFilterTuneProperties, 0x05500281, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8);


// {05500282-FAA5-4DF9-8246-BFC23AC5CEA8}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TVEFilterCCProperties, 0x05500282, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8);

// {05500283-FAA5-4DF9-8246-BFC23AC5CEA8}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_TVEFilterStatsProperties, 0x05500283, 0xFAA5, 0x4DF9, 0x82, 0x46, 0xBF, 0xC2, 0x3A, 0xC5, 0xCE, 0xA8);

// -------------------------------------------------------------------------
// Defined ENCAPI parameter GUIDs
// -------------------------------------------------------------------------

// The CLSID for the original IVideoEncoder proxy plug-in
// {B43C4EEC-8C32-4791-9102-508ADA5EE8E7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_IVideoEncoderProxy, 0xb43c4eec, 0x8c32, 0x4791, 0x91, 0x2, 0x50, 0x8a, 0xda, 0x5e, 0xe8, 0xe7);

// The CLSID for the ICodecAPI proxy plug-in
// {7ff0997a-1999-4286-a73c-622b8814e7eb}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_ICodecAPIProxy, 0x7ff0997a, 0x1999, 0x4286, 0xa7, 0x3c, 0x62, 0x2b, 0x88, 0x14, 0xe7, 0xeb);

// The CLSID for the combination ICodecAPI/IVideoEncoder proxy plug-in
// {b05dabd9-56e5-4fdc-afa4-8a47e91f1c9c}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_IVideoEncoderCodecAPIProxy, 0xb05dabd9, 0x56e5, 0x4fdc, 0xaf, 0xa4, 0x8a, 0x47, 0xe9, 0x1f, 0x1c, 0x9c);


// {49CC4C43-CA83-4ad4-A9AF-F3696AF666DF}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(ENCAPIPARAM_BITRATE, 0x49cc4c43, 0xca83, 0x4ad4, 0xa9, 0xaf, 0xf3, 0x69, 0x6a, 0xf6, 0x66, 0xdf);

// {703F16A9-3D48-44a1-B077-018DFF915D19}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(ENCAPIPARAM_PEAK_BITRATE, 0x703f16a9, 0x3d48, 0x44a1, 0xb0, 0x77, 0x1, 0x8d, 0xff, 0x91, 0x5d, 0x19);

// {EE5FB25C-C713-40d1-9D58-C0D7241E250F}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(ENCAPIPARAM_BITRATE_MODE, 0xee5fb25c, 0xc713, 0x40d1, 0x9d, 0x58, 0xc0, 0xd7, 0x24, 0x1e, 0x25, 0xf);

// for kernel control

// {62b12acf-f6b0-47d9-9456-96f22c4e0b9d}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_CHANGELISTS, 0x62b12acf, 0xf6b0, 0x47d9, 0x94, 0x56, 0x96, 0xf2, 0x2c, 0x4e, 0x0b, 0x9d);

// {7112e8e1-3d03-47ef-8e60-03f1cf537301 }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_VIDEO_ENCODER, 0x7112e8e1, 0x3d03, 0x47ef, 0x8e, 0x60, 0x03, 0xf1, 0xcf, 0x53, 0x73, 0x01);

// {b9d19a3e-f897-429c-bc46-8138b7272b2d }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_AUDIO_ENCODER, 0xb9d19a3e, 0xf897, 0x429c, 0xbc, 0x46, 0x81, 0x38, 0xb7, 0x27, 0x2b, 0x2d);

// {6c5e6a7c-acf8-4f55-a999-1a628109051b }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_SETALLDEFAULTS, 0x6c5e6a7c, 0xacf8, 0x4f55, 0xa9, 0x99, 0x1a, 0x62, 0x81, 0x09, 0x05, 0x1b);

// {6a577e92-83e1-4113-adc2-4fcec32f83a1 }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_ALLSETTINGS, 0x6a577e92, 0x83e1, 0x4113, 0xad, 0xc2, 0x4f, 0xce, 0xc3, 0x2f, 0x83, 0xa1);

// {0581af97-7693-4dbd-9dca-3f9ebd6585a1 }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_SUPPORTSEVENTS, 0x0581af97, 0x7693, 0x4dbd, 0x9d, 0xca, 0x3f, 0x9e, 0xbd, 0x65, 0x85, 0xa1);

// {1cb14e83-7d72-4657-83fd-47a2c5b9d13d }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CODECAPI_CURRENTCHANGELIST, 0x1cb14e83, 0x7d72, 0x4657, 0x83, 0xfd, 0x47, 0xa2, 0xc5, 0xb9, 0xd1, 0x3d);


//C++ TO C# CONVERTER TODO TASK: A test for this #define occurs before this statement, so this statement cannot be moved to the top of the file:
#undef OUR_GUID_ENTRY
