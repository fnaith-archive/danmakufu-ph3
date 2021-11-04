// ------------------------------------------------------------------------------
// File: DVDMedia.h
// 
// Desc: Contains typedefs and defines necessary for user mode (ring 3) DVD
//       filters and applications.
// 
//       This should be included in the DirectShow SDK for user mode filters.
//       The types defined here should be kept in synch with ksmedia.h WDM
//       DDK for kernel mode filters.
// 
// Copyright (c) 1997 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif // __cplusplus

// -----------------------------------------------------------------------
// AC-3 definition for the AM_KSPROPSETID_AC3 property set
// -----------------------------------------------------------------------

public enum AM_PROPERTY_AC3
{
    AM_PROPERTY_AC3_ERROR_CONCEALMENT = 1,
    AM_PROPERTY_AC3_ALTERNATE_AUDIO = 2,
    AM_PROPERTY_AC3_DOWNMIX = 3,
    AM_PROPERTY_AC3_BIT_STREAM_MODE = 4,
    AM_PROPERTY_AC3_DIALOGUE_LEVEL = 5,
    AM_PROPERTY_AC3_LANGUAGE_CODE = 6,
    AM_PROPERTY_AC3_ROOM_TYPE = 7
}

public class AM_AC3_ERROR_CONCEALMENT
{
    public bool fRepeatPreviousBlock;
    public bool fErrorInCurrentBlock;
}

public class AM_AC3_ALTERNATE_AUDIO
{
    public bool fStereo;
    public uint DualMode;
}


public class AM_AC3_DOWNMIX
{
    public bool fDownMix;
    public bool fDolbySurround;
}

public class AM_AC3_BIT_STREAM_MODE
{
    public int BitStreamMode;
}


public class AM_AC3_DIALOGUE_LEVEL
{
    public uint DialogueLevel;
}

public class AM_AC3_ROOM_TYPE
{
    public bool fLargeRoom;
}


// -----------------------------------------------------------------------
// subpicture definition for the AM_KSPROPSETID_DvdSubPic property set
// -----------------------------------------------------------------------

public enum AM_PROPERTY_DVDSUBPIC
{
    AM_PROPERTY_DVDSUBPIC_PALETTE = 0,
    AM_PROPERTY_DVDSUBPIC_HLI = 1,
    AM_PROPERTY_DVDSUBPIC_COMPOSIT_ON = 2 // TRUE for subpicture is displayed
}

public class _AM_DVD_YUV
{
    public byte Reserved;
    public byte Y;
    public byte U;
    public byte V;
}

public class _AM_PROPERTY_SPPAL
{
    public _AM_DVD_YUV[] sppal = Arrays.InitializeWithDefaultInstances<_AM_DVD_YUV>(16);
}

public class _AM_COLCON
{
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte emph1col:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte emph2col:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte backcol:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte patcol:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte emph1con:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte emph2con:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte backcon:4;
// C++ TO C# CONVERTER TODO TASK: C# does not allow bit fields:
    public byte patcon:4;

}

public class _AM_PROPERTY_SPHLI
{
    public ushort HLISS;
    public ushort Reserved;
    public uint StartPTM; // start presentation time in x/90000
    public uint EndPTM; // end PTM in x/90000
    public ushort StartX;
    public ushort StartY;
    public ushort StopX;
    public ushort StopY;
    public _AM_COLCON ColCon = new _AM_COLCON(); // color contrast description (4 bytes as given in HLI)
}




// -----------------------------------------------------------------------
// copy protection definitions
// -----------------------------------------------------------------------

// AM_UseNewCSSKey for the dwTypeSpecificFlags in IMediaSample2 to indicate
// the exact point in a stream after which to start applying a new CSS key.
// This is typically sent on an empty media sample just before attempting
// to renegotiate a CSS key.

// 
// AM_KSPROPSETID_CopyProt property set definitions
// 
public enum AM_PROPERTY_DVDCOPYPROT
{
    AM_PROPERTY_DVDCOPY_CHLG_KEY = 0x01,
    AM_PROPERTY_DVDCOPY_DVD_KEY1 = 0x02,
    AM_PROPERTY_DVDCOPY_DEC_KEY2 = 0x03,
    AM_PROPERTY_DVDCOPY_TITLE_KEY = 0x04,
    AM_PROPERTY_COPY_MACROVISION = 0x05,
    AM_PROPERTY_DVDCOPY_REGION = 0x06,
    AM_PROPERTY_DVDCOPY_SET_COPY_STATE = 0x07,
    AM_PROPERTY_DVDCOPY_DISC_KEY = 0x80
}

public class _AM_DVDCOPY_CHLGKEY
{
    public byte[] ChlgKey = new byte[10];
    public byte[] Reserved = new byte[2];
}

public class _AM_DVDCOPY_BUSKEY
{
    public byte[] BusKey = new byte[5];
    public byte[] Reserved = new byte[1];
}

public class _AM_DVDCOPY_DISCKEY
{
    public byte[] DiscKey = new byte[2048];
}

public class AM_DVDCOPY_TITLEKEY
{
    public uint KeyFlags;
    public uint[] Reserved1 = new uint[2];
    public byte[] TitleKey = new byte[6];
    public byte[] Reserved2 = new byte[2];
}

public class _AM_COPY_MACROVISION
{
    public uint MACROVISIONLevel;
}

public class AM_DVDCOPY_SET_COPY_STATE
{
    public uint DVDCopyState;
}

public enum AM_DVDCOPYSTATE
{
    AM_DVDCOPYSTATE_INITIALIZE = 0,
    AM_DVDCOPYSTATE_INITIALIZE_TITLE = 1, // indicates we are starting a title
                                        // key copy protection sequence
    AM_DVDCOPYSTATE_AUTHENTICATION_NOT_REQUIRED = 2,
    AM_DVDCOPYSTATE_AUTHENTICATION_REQUIRED = 3,
    AM_DVDCOPYSTATE_DONE = 4
}

public enum AM_COPY_MACROVISION_LEVEL
{
    AM_MACROVISION_DISABLED = 0,
    AM_MACROVISION_LEVEL1 = 1,
    AM_MACROVISION_LEVEL2 = 2,
    AM_MACROVISION_LEVEL3 = 3
}


// CSS region stucture
public class _DVD_REGION
{
    public byte CopySystem;
    public byte RegionData;
    public byte SystemRegion;
    public byte Reserved;
}

// 
// CGMS Copy Protection Flags
// 






// -----------------------------------------------------------------------
// video format blocks
// -----------------------------------------------------------------------

public enum AM_MPEG2Level
{
    AM_MPEG2Level_Low = 1,
    AM_MPEG2Level_Main = 2,
    AM_MPEG2Level_High1440 = 3,
    AM_MPEG2Level_High = 4
}

public enum AM_MPEG2Profile
{
    AM_MPEG2Profile_Simple = 1,
    AM_MPEG2Profile_Main = 2,
    AM_MPEG2Profile_SNRScalable = 3,
    AM_MPEG2Profile_SpatiallyScalable = 4,
    AM_MPEG2Profile_High = 5
}



                        //  based on pan-scan vectors in picture_display_extension
                        //  and change the picture aspect ratio accordingly.
                        //  pin for DVD style closed caption data found in GOP layer of field 1
                        //  pin for DVD style closed caption data found in GOP layer of field 2
                        //  and bottom of the video.
                        //  indicates that "camera mode" was used.
                        //  be letterboxed.  Streams sent to VGA should be letterboxed only by renderers.

                        //  be in widescreen format (4x3 content should be centered on a 16x9 output).
                        //  Streams sent to VGA should be widescreened only by renderers.

// PRESENT in dwReserved1 field in VIDEOINFOHEADER2
                                                // If rejected, then you cannot use the AMCONTROL flags (send 0 for dwReserved1)

public class tagVIDEOINFOHEADER2
{
    public RECT rcSource = new RECT();
    public RECT rcTarget = new RECT();
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public REFERENCE_TIME AvgTimePerFrame = new REFERENCE_TIME();
    public uint dwInterlaceFlags; // use AMINTERLACE_* defines. Reject connection if undefined bits are not 0
    public uint dwCopyProtectFlags; // use AMCOPYPROTECT_* defines. Reject connection if undefined bits are not 0
    public uint dwPictAspectRatioX; // X dimension of picture aspect ratio, e.g. 16 for 16x9 display
    public uint dwPictAspectRatioY; // Y dimension of picture aspect ratio, e.g.  9 for 16x9 display
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint dwControlFlags; // use AMCONTROL_* defines, use this from now on
//        uint dwReserved1; // for backward compatiblity (was "must be 0";  connection rejected otherwise)
//    };
    public uint dwReserved2; // must be 0; reject connection otherwise
    public BITMAPINFOHEADER bmiHeader = new BITMAPINFOHEADER();
}

public class tagMPEG2VIDEOINFO
{
    public tagVIDEOINFOHEADER2 hdr = new tagVIDEOINFOHEADER2();
    public uint dwStartTimeCode; //  ?? not used for DVD ??
    public uint cbSequenceHeader; // is 0 for DVD (no sequence header)
    public uint dwProfile; // use enum MPEG2Profile
    public uint dwLevel; // use enum MPEG2Level
    public uint dwFlags; // use AMMPEG2_* defines.  Reject connection if undefined bits are not 0
    public uint[] dwSequenceHeader = new uint[1]; // DWORD instead of Byte for alignment purposes
                                                //   For MPEG-2, if a sequence_header is included, the sequence_extension
                                                //   should also be included
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_MPEG2VIDEOINFO(pv) (FIELD_OFFSET(MPEG2VIDEOINFO, dwSequenceHeader[0]) + (pv)->cbSequenceHeader)

// do not use
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MPEG1_SEQUENCE_INFO(pv) ((const BYTE *)(pv)->bSequenceHeader)

// use this macro instead, the previous only works for MPEG1VIDEOINFO structures
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MPEG2_SEQUENCE_INFO(pv) ((const BYTE *)(pv)->dwSequenceHeader)


// ===================================================================================
// flags for dwTypeSpecificFlags in AM_SAMPLE2_PROPERTIES which define type specific
// data in IMediaSample2
// ===================================================================================

                                                // this bit is irrelavant for 1FieldPerSample mode
                                                // both fields first. This bit is irrelavant for 1FieldPerSample mode

// -----------------------------------------------------------------------
// AM_KSPROPSETID_DvdKaraoke property set definitions
// -----------------------------------------------------------------------

public class tagAM_DvdKaraokeData
{
    public uint dwDownmix; // bitwise OR of AM_DvdKaraoke_Downmix flags
    public uint dwSpeakerAssignment; // AM_DvdKaraoke_SpeakerAssignment
}

public enum AM_PROPERTY_DVDKARAOKE
{
    AM_PROPERTY_DVDKARAOKE_ENABLE = 0, // BOOL
    AM_PROPERTY_DVDKARAOKE_DATA = 1
}

// -----------------------------------------------------------------------
// AM_KSPROPSETID_TSRateChange property set definitions for time stamp
// rate changes.
// -----------------------------------------------------------------------

public enum AM_PROPERTY_TS_RATE_CHANGE
{
    AM_RATE_SimpleRateChange = 1, // rw, use AM_SimpleRateChange
    AM_RATE_ExactRateChange = 2, // rw, use AM_ExactRateChange
    AM_RATE_MaxFullDataRate = 3, // r,  use AM_MaxFullDataRate
    AM_RATE_Step = 4, // w,  use AM_Step
    AM_RATE_UseRateVersion = 5, //  w, use WORD
    AM_RATE_QueryFullFrameRate = 6, //  r, use AM_QueryRate
    AM_RATE_QueryLastRateSegPTS = 7, //  r, use REFERENCE_TIME
    AM_RATE_CorrectTS = 8 // w,  use LONG
}

// -------------------------------------------------------------------
// AM_KSPROPSETID_DVD_RateChange property set definitions for new DVD
// rate change scheme.
// -------------------------------------------------------------------

public enum AM_PROPERTY_DVD_RATE_CHANGE
{
    AM_RATE_ChangeRate = 1, // w,  use AM_DVD_ChangeRate
    AM_RATE_FullDataRateMax = 2, // r,  use AM_MaxFullDataRate
    AM_RATE_ReverseDecode = 3, // r,  use LONG
    AM_RATE_DecoderPosition = 4, // r,  use AM_DVD_DecoderPosition
    AM_RATE_DecoderVersion = 5 // r,  use LONG
}

public class AM_SimpleRateChange
{
    // this is the simplest mechanism to set a time stamp rate change on
    // a filter (simplest for the person setting the rate change, harder
    // for the filter doing the rate change).
    public REFERENCE_TIME StartTime = new REFERENCE_TIME(); // stream time at which to start this rate
    public int Rate; // new rate * 10000 (decimal)
}

public class AM_QueryRate
{
    public int lMaxForwardFullFrame; //  rate * 10000
    public int lMaxReverseFullFrame; //  rate * 10000
}

public class AM_ExactRateChange
{
    public REFERENCE_TIME OutputZeroTime = new REFERENCE_TIME(); // input TS that maps to zero output TS
    public int Rate; // new rate * 10000 (decimal)
}



// New rate change property set, structs. enums etc.
public class AM_DVD_ChangeRate
{
    public REFERENCE_TIME StartInTime = new REFERENCE_TIME(); // stream time (input) at which to start decoding at this rate
    public REFERENCE_TIME StartOutTime = new REFERENCE_TIME(); // reference time (output) at which to start showing at this rate
    public int Rate; // new rate * 10000 (decimal)
}


public enum DVD_PLAY_DIRECTION
{
    DVD_DIR_FORWARD = 0,
    DVD_DIR_BACKWARD = 1
}

#if __cplusplus
#endif // __cplusplus
