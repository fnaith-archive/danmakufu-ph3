// ------------------------------------------------------------------------------
// File: iwstdec.h
// 
// Desc: WST Decoder related definitions and interfaces for ActiveMovie
// 
// Copyright (c) 1999 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------
// 


// 
//  Some data types used as WST decoder parameters by the interface
// 
public class _AM_WST_PAGE
{
    public uint dwPageNr;
    public uint dwSubPageNr;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pucPageData;
    public byte pucPageData;
}

public enum _AM_WST_LEVEL
{
    AM_WST_LEVEL_1_5 = 0
}

public enum _AM_WST_SERVICE
{
    AM_WST_SERVICE_None = 0,
    AM_WST_SERVICE_Text,
    AM_WST_SERVICE_IDS,
    AM_WST_SERVICE_Invalid
}

public enum _AM_WST_STATE
{
    AM_WST_STATE_Off = 0,
    AM_WST_STATE_On
}

public enum _AM_WST_STYLE
{
    AM_WST_STYLE_None = 0,
    AM_WST_STYLE_Invers
}

public enum _AM_WST_DRAWBGMODE
{
    AM_WST_DRAWBGMODE_Opaque,
    AM_WST_DRAWBGMODE_Transparent
}


#if __cplusplus
#endif // __cplusplus