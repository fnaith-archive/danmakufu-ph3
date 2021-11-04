// ------------------------------------------------------------------------------
// File: MPConfig.h
// 
// Desc: 
// 
// Copyright (c) 1997-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif

public enum _AM_ASPECT_RATIO_MODE
{
    AM_ARMODE_STRETCHED, // don't do any aspect ratio correction
    AM_ARMODE_LETTER_BOX, // letter box the video, paint background color in the excess region
    AM_ARMODE_CROP, // crop the video to the right aspect ratio
    AM_ARMODE_STRETCHED_AS_PRIMARY // follow whatever the primary stream does (in terms of the mode as well as pict-aspect-ratio values)
}