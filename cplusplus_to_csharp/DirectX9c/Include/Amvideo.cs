// ------------------------------------------------------------------------------
// File: AMVideo.h
// 
// Desc: Video related definitions and interfaces for ActiveMovie.
// 
// Copyright (c) 1992 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------



#if __cplusplus
#endif // __cplusplus



// Used for true colour images that also have a palette

public class tag_TRUECOLORINFO
{
    public uint[] dwBitMasks = new uint[DefineConstants.iMASK_COLORS];
    public RGBQUAD[] bmiColors = Arrays.InitializeWithDefaultInstances<RGBQUAD>(DefineConstants.iPALETTE_COLORS);
}


// The BITMAPINFOHEADER contains all the details about the video stream such
// as the actual image dimensions and their pixel depth. A source filter may
// also request that the sink take only a section of the video by providing a
// clipping rectangle in rcSource. In the worst case where the sink filter
// forgets to check this on connection it will simply render the whole thing
// which isn't a disaster. Ideally a sink filter will check the rcSource and
// if it doesn't support image extraction and the rectangle is not empty then
// it will reject the connection. A filter should use SetRectEmpty to reset a
// rectangle to all zeroes (and IsRectEmpty to later check the rectangle).
// The rcTarget specifies the destination rectangle for the video, for most
// source filters they will set this to all zeroes, a downstream filter may
// request that the video be placed in a particular area of the buffers it
// supplies in which case it will call QueryAccept with a non empty target

public class tagVIDEOINFOHEADER
{

    public RECT rcSource = new RECT(); // The bit we really want to use
    public RECT rcTarget = new RECT(); // Where the video should go
    public uint dwBitRate; // Approximate bit data rate
    public uint dwBitErrorRate; // Bit error rate for this stream
    public REFERENCE_TIME AvgTimePerFrame = new REFERENCE_TIME(); // Average time per frame (100ns units)

    public BITMAPINFOHEADER bmiHeader = new BITMAPINFOHEADER();

}

// make sure the pbmi is initialized before using these macros
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define TRUECOLOR(pbmi) ((TRUECOLORINFO *)(((LPBYTE)&((pbmi)->bmiHeader)) + (pbmi)->bmiHeader.biSize))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define COLORS(pbmi) ((RGBQUAD *)(((LPBYTE)&((pbmi)->bmiHeader)) + (pbmi)->bmiHeader.biSize))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define BITMASKS(pbmi) ((DWORD *)(((LPBYTE)&((pbmi)->bmiHeader)) + (pbmi)->bmiHeader.biSize))

// All the image based filters use this to communicate their media types. It's
// centred principally around the BITMAPINFO. This structure always contains a
// BITMAPINFOHEADER followed by a number of other fields depending on what the
// BITMAPINFOHEADER contains. If it contains details of a palettised format it
// will be followed by one or more RGBQUADs defining the palette. If it holds
// details of a true colour format then it may be followed by a set of three
// DWORD bit masks that specify where the RGB data can be found in the image
// (For more information regarding BITMAPINFOs see the Win32 documentation)

// The rcSource and rcTarget fields are not for use by filters supplying the
// data. The destination (target) rectangle should be set to all zeroes. The
// source may also be zero filled or set with the dimensions of the video. So
// if the video is 352x288 pixels then set it to (0,0,352,288). These fields
// are mainly used by downstream filters that want to ask the source filter
// to place the image in a different position in an output buffer. So when
// using for example the primary surface the video renderer may ask a filter
// to place the video images in a destination position of (100,100,452,388)
// on the display since that's where the window is positioned on the display

// !!! WARNING !!!
// DO NOT use this structure unless you are sure that the BITMAPINFOHEADER
// has a normal biSize == sizeof(BITMAPINFOHEADER) !
// !!! WARNING !!!

public class tagVIDEOINFO
{

    public RECT rcSource = new RECT(); // The bit we really want to use
    public RECT rcTarget = new RECT(); // Where the video should go
    public uint dwBitRate; // Approximate bit data rate
    public uint dwBitErrorRate; // Bit error rate for this stream
    public REFERENCE_TIME AvgTimePerFrame = new REFERENCE_TIME(); // Average time per frame (100ns units)

    public BITMAPINFOHEADER bmiHeader = new BITMAPINFOHEADER();

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        RGBQUAD bmiColors[DefineConstants.iPALETTE_COLORS]; // Colour palette
//        uint dwBitMasks[DefineConstants.iMASK_COLORS]; // True colour masks
//        tag_TRUECOLORINFO TrueColorInfo; // Both of the above
//    };

}

// These macros define some standard bitmap format sizes

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_EGA_PALETTE (iEGA_COLORS * sizeof(RGBQUAD))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_PALETTE (iPALETTE_COLORS * sizeof(RGBQUAD))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_MASKS (iMASK_COLORS * sizeof(DWORD))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_PREHEADER (FIELD_OFFSET(VIDEOINFOHEADER,bmiHeader))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_VIDEOHEADER (sizeof(BITMAPINFOHEADER) + SIZE_PREHEADER)
// !!! for abnormal biSizes
// #define SIZE_VIDEOHEADER(pbmi) ((pbmi)->bmiHeader.biSize + SIZE_PREHEADER)

// DIBSIZE calculates the number of bytes required by an image

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define WIDTHBYTES(bits) ((DWORD)(((bits)+31) & (~31)) / 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIBWIDTHBYTES(bi) (DWORD)WIDTHBYTES((DWORD)(bi).biWidth * (DWORD)(bi).biBitCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _DIBSIZE(bi) (DIBWIDTHBYTES(bi) * (DWORD)(bi).biHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIBSIZE(bi) ((bi).biHeight < 0 ? (-1)*(_DIBSIZE(bi)) : _DIBSIZE(bi))

// This compares the bit masks between two VIDEOINFOHEADERs

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define BIT_MASKS_MATCH(pbmi1,pbmi2) (((pbmi1)->dwBitMasks[iRED] == (pbmi2)->dwBitMasks[iRED]) && ((pbmi1)->dwBitMasks[iGREEN] == (pbmi2)->dwBitMasks[iGREEN]) && ((pbmi1)->dwBitMasks[iBLUE] == (pbmi2)->dwBitMasks[iBLUE]))

// These zero fill different parts of the VIDEOINFOHEADER structure

// Only use these macros for pbmi's with a normal BITMAPINFOHEADER biSize
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RESET_MASKS(pbmi) (ZeroMemory((PVOID)(pbmi)->dwBitFields,SIZE_MASKS))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RESET_HEADER(pbmi) (ZeroMemory((PVOID)(pbmi),SIZE_VIDEOHEADER))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RESET_PALETTE(pbmi) (ZeroMemory((PVOID)(pbmi)->bmiColors,SIZE_PALETTE));

#if false
/// / !!! This is the right way to do it, but may break existing code
// #define RESET_MASKS(pbmi) (ZeroMemory((PVOID)(((LPBYTE)(pbmi)->bmiHeader) + 			(pbmi)->bmiHeader.biSize,SIZE_MASKS)))
// ignore
// #define RESET_HEADER(pbmi) (ZeroMemory((PVOID)(pbmi), SIZE_PREHEADER +	    			sizeof(BITMAPINFOHEADER)))
// ignore
// #define RESET_PALETTE(pbmi) (ZeroMemory((PVOID)(((LPBYTE)(pbmi)->bmiHeader) + 			(pbmi)->bmiHeader.biSize,SIZE_PALETTE))
// ignore
#endif

// Other (hopefully) useful bits and bobs

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PALETTISED(pbmi) ((pbmi)->bmiHeader.biBitCount <= iPALETTE)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PALETTE_ENTRIES(pbmi) ((DWORD) 1 << (pbmi)->bmiHeader.biBitCount)

// Returns the address of the BITMAPINFOHEADER from the VIDEOINFOHEADER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define HEADER(pVideoInfo) (&(((VIDEOINFOHEADER *) (pVideoInfo))->bmiHeader))


// MPEG variant - includes a DWORD length followed by the
// video sequence header after the video header.
// 
// The sequence header includes the sequence header start code and the
// quantization matrices associated with the first sequence header in the
// stream so is a maximum of 140 bytes long.

public class tagMPEG1VIDEOINFO
{

    public tagVIDEOINFOHEADER hdr = new tagVIDEOINFOHEADER(); // Compatible with VIDEOINFO
    public uint dwStartTimeCode; // 25-bit Group of pictures time code
                                            // at start of data
    public uint cbSequenceHeader; // Length in bytes of bSequenceHeader
    public byte[] bSequenceHeader = new byte[1]; // Sequence header including
                                            // quantization matrices if any
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define SIZE_MPEG1VIDEOINFO(pv) (FIELD_OFFSET(MPEG1VIDEOINFO, bSequenceHeader[0]) + (pv)->cbSequenceHeader)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MPEG1_SEQUENCE_INFO(pv) ((const BYTE *)(pv)->bSequenceHeader)


// Analog video variant - Use this when the format is FORMAT_AnalogVideo
// 
// rcSource defines the portion of the active video signal to use
// rcTarget defines the destination rectangle
//    both of the above are relative to the dwActiveWidth and dwActiveHeight fields
// dwActiveWidth is currently set to 720 for all formats (but could change for HDTV)
// dwActiveHeight is 483 for NTSC and 575 for PAL/SECAM  (but could change for HDTV)

public class tagAnalogVideoInfo
{
    public RECT rcSource = new RECT(); // Width max is 720, height varies w/ TransmissionStd
    public RECT rcTarget = new RECT(); // Where the video should go
    public uint dwActiveWidth; // Always 720 (CCIR-601 active samples per line)
    public uint dwActiveHeight; // 483 for NTSC, 575 for PAL/SECAM
    public REFERENCE_TIME AvgTimePerFrame = new REFERENCE_TIME(); // Normal ActiveMovie units (100 nS)
}

// 
// AM_KSPROPSETID_FrameStep property set definitions
// 
public enum AM_PROPERTY_FRAMESTEP
{
        //  Step
    AM_PROPERTY_FRAMESTEP_STEP = 0x01,
    AM_PROPERTY_FRAMESTEP_CANCEL = 0x02,

        //  S_OK for these 2 means we can - S_FALSE if we can't
        AM_PROPERTY_FRAMESTEP_CANSTEP = 0x03,
        AM_PROPERTY_FRAMESTEP_CANSTEPMULTIPLE = 0x04
}

public class _AM_FRAMESTEP_STEP
{
    //  1 means step 1 frame forward
    //  0 is invalid
    //  n (n > 1) means skip n - 1 frames and show the nth
    public uint dwFramesToStep;
}

#if __cplusplus
#endif // __cplusplus

