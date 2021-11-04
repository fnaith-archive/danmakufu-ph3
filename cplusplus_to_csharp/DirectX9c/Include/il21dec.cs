// ------------------------------------------------------------------------------
// File: IL21Dec.h
// 
// Desc: Line 21 Decoder related definitions and interfaces for ActiveMovie.
// 
// Copyright (c) 1992-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------




// 
//  Some enum data types used as line 21 decoder params by the interface
// 
public enum _AM_LINE21_CCLEVEL
{ // should we use TC1, TC2 in stead?
    AM_L21_CCLEVEL_TC2 = 0
}

public enum _AM_LINE21_CCSERVICE
{
    AM_L21_CCSERVICE_None = 0,
    AM_L21_CCSERVICE_Caption1,
    AM_L21_CCSERVICE_Caption2,
    AM_L21_CCSERVICE_Text1,
    AM_L21_CCSERVICE_Text2,
    AM_L21_CCSERVICE_XDS,
    AM_L21_CCSERVICE_DefChannel = 10,
    AM_L21_CCSERVICE_Invalid
}

public enum _AM_LINE21_CCSTATE
{
    AM_L21_CCSTATE_Off = 0,
    AM_L21_CCSTATE_On
}

public enum _AM_LINE21_CCSTYLE
{
    AM_L21_CCSTYLE_None = 0,
    AM_L21_CCSTYLE_PopOn,
    AM_L21_CCSTYLE_PaintOn,
    AM_L21_CCSTYLE_RollUp
}

public enum _AM_LINE21_DRAWBGMODE
{
    AM_L21_DRAWBGMODE_Opaque,
    AM_L21_DRAWBGMODE_Transparent
}


#if __cplusplus
#endif // __cplusplus