// ------------------------------------------------------------------------------
// File: VPType.h
// 
// Desc: This file includes all the data structures defined for the IVPConfig
//       interface.
// 
// Copyright (c) 1997-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif

    // enum to specify the criterion, which the vpmixer is supposed to use
    // in order to select the video format
    public enum _AMVP_SELECT_FORMAT_BY
    {
        AMVP_DO_NOT_CARE,
        AMVP_BEST_BANDWIDTH,
        AMVP_INPUT_SAME_AS_OUTPUT
    }

    // enum to specify the various mode
    public enum _AMVP_MODE
    {
        AMVP_MODE_WEAVE,
        AMVP_MODE_BOBINTERLEAVED,
        AMVP_MODE_BOBNONINTERLEAVED,
        AMVP_MODE_SKIPEVEN,
        AMVP_MODE_SKIPODD
    }

    // struct to specify the width and height. The context could be anything
    // such as scaling cropping etc.
    public class _AMVPSIZE
    {
        public uint dwWidth; // the width
        public uint dwHeight; // the height
    }

    // struct to specify the dimensional characteristics of the input stream
    public class _AMVPDIMINFO
    {
        public uint dwFieldWidth; // Field height of the data
        public uint dwFieldHeight; // Field width of the data
        public uint dwVBIWidth; // Width of the VBI data
        public uint dwVBIHeight; // Height of the VBI data
        public RECT rcValidRegion = new RECT(); // The vaild rectangle, used for cropping
    }

    // struct to specify the various data specific characteristics of the input stream
    public class _AMVPDATAINFO
    {
        public uint dwSize; // Size of the struct
        public uint dwMicrosecondsPerField; // Time taken by each field
        public _AMVPDIMINFO amvpDimInfo = new _AMVPDIMINFO(); // Dimensional Information
        public uint dwPictAspectRatioX; // X dimension of Picture Aspect Ratio
        public uint dwPictAspectRatioY; // Y dimension of Picture Aspect Ratio
        public bool bEnableDoubleClock; // Videoport should enable double clocking
        public bool bEnableVACT; // Videoport should use an external VACT signal
        public bool bDataIsInterlaced; // Indicates that the signal is interlaced
        public int lHalfLinesOdd; // number of halflines in the odd field
        public bool bFieldPolarityInverted; // Device inverts the polarity by default
        public uint dwNumLinesInVREF; // Number of lines of data in VREF
        public int lHalfLinesEven; // number of halflines in the even field
        public uint dwReserved1; // Reserved for future use
    }


#if __cplusplus
#endif

