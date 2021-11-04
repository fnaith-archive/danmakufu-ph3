/*==========================================================================;
 *
 *  Copyright (C) Microsoft Corporation.  All Rights Reserved.
 *
 *  File:	dvp.h
 *  Content:	DirectDrawVideoPort include file
 *
 ***************************************************************************/


/*
 * GUIDS used by DirectDrawVideoPort objects
 */
#if _WIN32 && (! _NO_COM || DEFINE_GUID )
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDDVideoPortContainer, 0x6C142760,0xA733,0x11CE,0xA5,0x21,0x00,0x20,0xAF,0x0B,0xE5,0x60);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawVideoPort, 0xB36D93E0,0x2B43,0x11CF,0xA2,0xDE,0x00,0xAA,0x00,0xB9,0x33,0x56);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectDrawVideoPortNotify, 0xA655FB94,0x0589,0x4E57,0xB3,0x33,0x56,0x7A,0x89,0x46,0x8C,0x88);



// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_E_HREFH_VREFH, 0x54F39980,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_E_HREFH_VREFL, 0x92783220,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_E_HREFL_VREFH, 0xA07A02E0,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_E_HREFL_VREFL, 0xE09C77E0,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_CCIR656, 0xFCA326A0,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_BROOKTREE, 0x1352A560,0xDA61,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DDVPTYPE_PHILIPS, 0x332CF160,0xDA61,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8);
#endif

#if ! GUID_DEFS_ONLY

#if _WIN32 && ! _NO_COM
#define COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IUnknown void
#define IUnknown
#endif

/*
 * These definitions are required to allow polymorphic structure members (i.e. those
 * that are referred to both as DWORDs and as pointers) to resolve into a type
 * of correct size to hold the largest of those two types (i.e. pointer) on 64 bit
 * systems. For 32 bit environments, ULONG_PTR resolves to a DWORD.
 */
#if ! MAXULONG_PTR
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ULONG_PTR DWORD
#define ULONG_PTR
#endif //MAXULONG_PTR

#if __cplusplus
#endif

/*============================================================================
 *
 * DirectDraw Structures
 *
 * Various structures used to invoke DirectDraw.
 *
 *==========================================================================*/

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDraw;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDrawSurface;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDrawPalette;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectDrawClipper;





/*
 * API's
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(FAR PASCAL * LPDDENUMVIDEOCALLBACK)(struct _DDVIDEOPORTCAPS FAR *, object*);
public delegate int LPDDENUMVIDEOCALLBACK(_DDVIDEOPORTCAPS UnnamedParameter, object UnnamedParameter2);

/*
 * DDVIDEOPORTCONNECT
 */
public class _DDVIDEOPORTCONNECT
{
    public uint dwSize; // size of the DDVIDEOPORTCONNECT structure
    public uint dwPortWidth; // Width of the video port
    public GUID guidTypeID = new GUID(); // Description of video port connection
    public uint dwFlags; // Connection flags
    public uint dwReserved1; // Reserved, set to zero.
}


/*
 * DDVIDEOPORTCAPS
 */
public class _DDVIDEOPORTCAPS
{
    public uint dwSize; // size of the DDVIDEOPORTCAPS structure
    public uint dwFlags; // indicates which fields contain data
    public uint dwMaxWidth; // max width of the video port field
    public uint dwMaxVBIWidth; // max width of the VBI data
    public uint dwMaxHeight; // max height of the video port field
    public uint dwVideoPortID; // Video port ID (0 - (dwMaxVideoPorts -1))
    public uint dwCaps; // Video port capabilities
    public uint dwFX; // More video port capabilities
    public uint dwNumAutoFlipSurfaces; // Max number of autoflippable surfaces allowed
    public uint dwAlignVideoPortBoundary; // Byte restriction of placement within the surface
    public uint dwAlignVideoPortPrescaleWidth; // Byte restriction of width after prescaling
    public uint dwAlignVideoPortCropBoundary; // Byte restriction of left cropping
    public uint dwAlignVideoPortCropWidth; // Byte restriction of cropping width
    public uint dwPreshrinkXStep; // Width can be shrunk in steps of 1/x
    public uint dwPreshrinkYStep; // Height can be shrunk in steps of 1/x
    public uint dwNumVBIAutoFlipSurfaces; // Max number of VBI autoflippable surfaces allowed
    public uint dwNumPreferredAutoflip; // Optimal number of autoflippable surfaces for hardware
    public ushort wNumFilterTapsX; // Number of taps the prescaler uses in the X direction (0 - no prescale, 1 - replication, etc.)
    public ushort wNumFilterTapsY; // Number of taps the prescaler uses in the Y direction (0 - no prescale, 1 - replication, etc.)
}

/*
 * The dwMaxWidth and dwMaxVBIWidth members are valid
 */
#define DDVPD_WIDTH

/*
 * The dwMaxHeight member is valid
 */
#define DDVPD_HEIGHT

/*
 * The dwVideoPortID member is valid
 */
#define DDVPD_ID

/*
 * The dwCaps member is valid
 */
#define DDVPD_CAPS

/*
 * The dwFX member is valid
 */
#define DDVPD_FX

/*
 * The dwNumAutoFlipSurfaces member is valid
 */
#define DDVPD_AUTOFLIP

/*
 * All of the alignment members are valid
 */
#define DDVPD_ALIGN

/*
 * The dwNumPreferredAutoflip member is valid
 */
#define DDVPD_PREFERREDAUTOFLIP

/*
 * The wNumFilterTapsX and wNumFilterTapsY fields are valid
 */
#define DDVPD_FILTERQUALITY

/*
 * DDVIDEOPORTDESC
 */
public class _DDVIDEOPORTDESC
{
    public uint dwSize; // size of the DDVIDEOPORTDESC structure
    public uint dwFieldWidth; // width of the video port field
    public uint dwVBIWidth; // width of the VBI data
    public uint dwFieldHeight; // height of the video port field
    public uint dwMicrosecondsPerField; // Microseconds per video field
    public uint dwMaxPixelsPerSecond; // Maximum pixel rate per second
    public uint dwVideoPortID; // Video port ID (0 - (dwMaxVideoPorts -1))
    public uint dwReserved1; // Reserved for future use - set to zero (struct padding)
    public _DDVIDEOPORTCONNECT VideoPortType = new _DDVIDEOPORTCONNECT(); // Description of video port connection
    public uint dwReserved2; // Reserved for future use - set to zero
    public uint dwReserved3; // Reserved for future use - set to zero
}


/*
 * DDVIDEOPORTINFO
 */
public class _DDVIDEOPORTINFO
{
    public uint dwSize; // Size of the structure
    public uint dwOriginX; // Placement of the video data within the surface.
    public uint dwOriginY; // Placement of the video data within the surface.
    public uint dwVPFlags; // Video port options
    public RECT rCrop = new RECT(); // Cropping rectangle (optional).
    public uint dwPrescaleWidth; // Determines pre-scaling/zooming in the X direction (optional).
    public uint dwPrescaleHeight; // Determines pre-scaling/zooming in the Y direction (optional).
    public LPDDPIXELFORMAT lpddpfInputFormat = new LPDDPIXELFORMAT(); // Video format written to the video port
    public LPDDPIXELFORMAT lpddpfVBIInputFormat = new LPDDPIXELFORMAT(); // Input format of the VBI data
    public LPDDPIXELFORMAT lpddpfVBIOutputFormat = new LPDDPIXELFORMAT(); // Output format of the data
    public uint dwVBIHeight; // Specifies the number of lines of data within the vertical blanking interval.
    public uint dwReserved1; // Reserved for future use - set to zero
    public uint dwReserved2; // Reserved for future use - set to zero
}


/*
 * DDVIDEOPORTBANDWIDTH
 */
public class _DDVIDEOPORTBANDWIDTH
{
    public uint dwSize; // Size of the structure
    public uint dwCaps;
    public uint dwOverlay; // Zoom factor at which overlay is supported
    public uint dwColorkey; // Zoom factor at which overlay w/ colorkey is supported
    public uint dwYInterpolate; // Zoom factor at which overlay w/ Y interpolation is supported
    public uint dwYInterpAndColorkey; // Zoom factor at which ovelray w/ Y interpolation and colorkeying is supported
    public uint dwReserved1; // Reserved for future use - set to zero
    public uint dwReserved2; // Reserved for future use - set to zero
}


/*
 * DDVIDEOPORTSTATUS
 */
public class _DDVIDEOPORTSTATUS
{
    public uint dwSize; // Size of the structure
    public bool bInUse; // TRUE if video port is currently being used
    public uint dwFlags; // Currently not used
    public uint dwReserved1; // Reserved for future use
    public _DDVIDEOPORTCONNECT VideoPortType = new _DDVIDEOPORTCONNECT(); // Information about the connection
    public uint dwReserved2; // Reserved for future use
    public uint dwReserved3; // Reserved for future use
}

/*
 * DDVIDEOPORTNOTIFY
 */
public class _DDVIDEOPORTNOTIFY
{
    public LARGE_INTEGER ApproximateTimeStamp = new LARGE_INTEGER(); // Timestamp in the event notification
    public int lField; // 0 if even, 1 if odd, -1 if unknown
    public uint dwSurfaceIndex; // Index in the surface chain of the surface that received the sample
    public int lDone; // Call InterlockedIncrement on this when done with sample
}


/*============================================================================
 *
 * Video Port Flags
 *
 * All flags are bit flags.
 *
 *==========================================================================*/

/****************************************************************************
 *
 * VIDEOPORT DDVIDEOPORTCONNECT FLAGS
 *
 ****************************************************************************/

/*
 * When this is set by the driver and passed to the client, this
 * indicates that the video port is capable of double clocking the data.
 * When this is set by the client, this indicates that the video port
 * should enable double clocking.  This flag is only valid with external
 * syncs.
 */
#define DDVPCONNECT_DOUBLECLOCK

/*
 * When this is set by the driver and passed to the client, this
 * indicates that the video port is capable of using an external VACT
 * signal. When this is set by the client, this indicates that the
 * video port should use the external VACT signal.
 */
#define DDVPCONNECT_VACT

/*
 * When this is set by the driver and passed to the client, this
 * indicates that the video port is capable of treating even fields
 * like odd fields and visa versa.  When this is set by the client,
 * this indicates that the video port should treat even fields like odd
 * fields.
 */
#define DDVPCONNECT_INVERTPOLARITY

/*
 * Indicates that any data written to the video port during the VREF
 * period will not be written into the frame buffer. This flag is read only.
 */
#define DDVPCONNECT_DISCARDSVREFDATA

/*
 * When this is set be the driver and passed to the client, this
 * indicates that the device will write half lines into the frame buffer
 * if half lines are provided by the decoder.  If this is set by the client,
 * this indicates that the decoder will be supplying half lines.
 */
#define DDVPCONNECT_HALFLINE

/*
 * Indicates that the signal is interlaced. This flag is only
 * set by the client.
 */
#define DDVPCONNECT_INTERLACED

/*
 * Indicates that video port is shareable and that this video port
 * will use the even fields.  This flag is only set by the client.
 */
#define DDVPCONNECT_SHAREEVEN

/*
 * Indicates that video port is shareable and that this video port
 * will use the odd fields.  This flag is only set by the client.
 */
#define DDVPCONNECT_SHAREODD

/****************************************************************************
 *
 * VIDEOPORT DDVIDEOPORTDESC CAPS
 *
 ****************************************************************************/

/*
 * Flip can be performed automatically to avoid tearing.
 */
#define DDVPCAPS_AUTOFLIP

/*
 * Supports interlaced video
 */
#define DDVPCAPS_INTERLACED

/*
 * Supports non-interlaced video
 */
#define DDVPCAPS_NONINTERLACED

/*
 * Indicates that the device can return whether the current field
 * of an interlaced signal is even or odd.
 */
#define DDVPCAPS_READBACKFIELD

/*
 * Indicates that the device can return the current line of video
 * being written into the frame buffer.
 */
#define DDVPCAPS_READBACKLINE

/*
 * Allows two gen-locked video streams to share a single video port,
 * where one stream uses the even fields and the other uses the odd
 * fields. Separate parameters (including address, scaling,
 * cropping, etc.) are maintained for both fields.)
 */
#define DDVPCAPS_SHAREABLE

/*
 * Even fields of video can be automatically discarded.
 */
#define DDVPCAPS_SKIPEVENFIELDS

/*
 * Odd fields of video can be automatically discarded.
 */
#define DDVPCAPS_SKIPODDFIELDS

/*
 * Indicates that the device is capable of driving the graphics
 * VSYNC with the video port VSYNC.
 */
#define DDVPCAPS_SYNCMASTER

/*
 * Indicates that data within the vertical blanking interval can
 * be written to a different surface.
 */
#define DDVPCAPS_VBISURFACE

/*
 * Indicates that the video port can perform color operations
 * on the incoming data before it is written to the frame buffer.
 */
#define DDVPCAPS_COLORCONTROL

/*
 * Indicates that the video port can accept VBI data in a different
 * width or format than the regular video data.
 */
#define DDVPCAPS_OVERSAMPLEDVBI

/*
 * Indicates that the video port can write data directly to system memory
 */
#define DDVPCAPS_SYSTEMMEMORY

/*
 * Indicates that the VBI and video portions of the video stream can
 * be controlled by an independent processes.
 */
#define DDVPCAPS_VBIANDVIDEOINDEPENDENT

/*
 * Indicates that the video port contains high quality hardware
 * de-interlacing hardware that should be used instead of the
 * bob/weave algorithms.
 */
#define DDVPCAPS_HARDWAREDEINTERLACE


/****************************************************************************
 *
 * VIDEOPORT DDVIDEOPORTDESC FX
 *
 ****************************************************************************/

/*
 * Limited cropping is available to crop out the vertical interval data.
 */
#define DDVPFX_CROPTOPDATA

/*
 * Incoming data can be cropped in the X direction before it is written
 * to the surface.
 */
#define DDVPFX_CROPX

/*
 * Incoming data can be cropped in the Y direction before it is written
 * to the surface.
 */
#define DDVPFX_CROPY

/*
 * Supports interleaving interlaced fields in memory.
 */
#define DDVPFX_INTERLEAVE

/*
 * Supports mirroring left to right as the video data is written
 * into the frame buffer.
 */
#define DDVPFX_MIRRORLEFTRIGHT

/*
 * Supports mirroring top to bottom as the video data is written
 * into the frame buffer.
 */
#define DDVPFX_MIRRORUPDOWN

/*
 * Data can be arbitrarily shrunk in the X direction before it
 * is written to the surface.
 */
#define DDVPFX_PRESHRINKX

/*
 * Data can be arbitrarily shrunk in the Y direction before it
 * is written to the surface.
 */
#define DDVPFX_PRESHRINKY

/*
 * Data can be binary shrunk (1/2, 1/4, 1/8, etc.) in the X
 * direction before it is written to the surface.
 */
#define DDVPFX_PRESHRINKXB

/*
 * Data can be binary shrunk (1/2, 1/4, 1/8, etc.) in the Y
 * direction before it is written to the surface.
 */
#define DDVPFX_PRESHRINKYB

/*
 * Data can be shrunk in increments of 1/x in the X direction
 * (where X is specified in the DDVIDEOPORTCAPS.dwPreshrinkXStep)
 * before it is written to the surface.
 */
#define DDVPFX_PRESHRINKXS

/*
 * Data can be shrunk in increments of 1/x in the Y direction
 * (where X is specified in the DDVIDEOPORTCAPS.dwPreshrinkYStep)
 * before it is written to the surface.
 */
#define DDVPFX_PRESHRINKYS

/*
 * Data can be arbitrarily stretched in the X direction before
 * it is written to the surface.
 */
#define DDVPFX_PRESTRETCHX

/*
 * Data can be arbitrarily stretched in the Y direction before
 * it is written to the surface.
 */
#define DDVPFX_PRESTRETCHY

/*
 * Data can be integer stretched in the X direction before it is
 * written to the surface.
 */
#define DDVPFX_PRESTRETCHXN

/*
 * Data can be integer stretched in the Y direction before it is
 * written to the surface.
 */
#define DDVPFX_PRESTRETCHYN

/*
 * Indicates that data within the vertical blanking interval can
 * be converted independently of the remaining video data.
 */
#define DDVPFX_VBICONVERT

/*
 * Indicates that scaling can be disabled for data within the
 * vertical blanking interval.
 */
#define DDVPFX_VBINOSCALE

/*
 * Indicates that the video data can ignore the left and right
 * cropping coordinates when cropping oversampled VBI data.
 */
#define DDVPFX_IGNOREVBIXCROP

/*
 * Indicates that interleaving can be disabled for data within the
 * vertical blanking interval.
 */
#define DDVPFX_VBINOINTERLEAVE


/****************************************************************************
 *
 * VIDEOPORT DDVIDEOPORTINFO FLAGS
 *
 ****************************************************************************/

/*
 * Perform automatic flipping.   Auto-flipping is performed between
 * the overlay surface that was attached to the video port using
 * IDirectDrawVideoPort::AttachSurface and the overlay surfaces that
 * are attached to the surface via the IDirectDrawSurface::AttachSurface
 * method.  The flip order is the order in which the overlay surfaces
 * were. attached.
 */
#define DDVP_AUTOFLIP

/*
 * Perform conversion using the ddpfOutputFormat information.
 */
#define DDVP_CONVERT

/*
 * Perform cropping using the specified rectangle.
 */
#define DDVP_CROP

/*
 * Indicates that interlaced fields should be interleaved in memory.
 */
#define DDVP_INTERLEAVE

/*
 * Indicates that the data should be mirrored left to right as it's
 * written into the frame buffer.
 */
#define DDVP_MIRRORLEFTRIGHT

/*
 * Indicates that the data should be mirrored top to bottom as it's
 * written into the frame buffer.
 */
#define DDVP_MIRRORUPDOWN

/*
 * Perform pre-scaling/zooming based on the pre-scale parameters.
 */
#define DDVP_PRESCALE

/*
 * Ignore input of even fields.
 */
#define DDVP_SKIPEVENFIELDS

/*
 * Ignore input of odd fields.
 */
#define DDVP_SKIPODDFIELDS

/*
 * Drive the graphics VSYNCs using the video port VYSNCs.
 */
#define DDVP_SYNCMASTER

/*
 * The ddpfVBIOutputFormatFormat member contains data that should be used
 * to convert the data within the vertical blanking interval.
 */
#define DDVP_VBICONVERT

/*
 * Indicates that data within the vertical blanking interval
 * should not be scaled.
 */
#define DDVP_VBINOSCALE

/*
 * Indicates that these bob/weave decisions should not be
 * overriden by other interfaces.
 */
#define DDVP_OVERRIDEBOBWEAVE

/*
 * Indicates that the video data should ignore the left and right
 * cropping coordinates when cropping the VBI data.
 */
#define DDVP_IGNOREVBIXCROP

/*
 * Indicates that interleaving can be disabled for data within the
 * vertical blanking interval.
 */
#define DDVP_VBINOINTERLEAVE

/*
 * Indicates that the video port should use the hardware
 * de-interlacing hardware.
 */
#define DDVP_HARDWAREDEINTERLACE

/****************************************************************************
 *
 * DIRIRECTDRAWVIDEOPORT GETINPUTFORMAT/GETOUTPUTFORMAT FLAGS
 *
 ****************************************************************************/

/*
 * Return formats for the video data
 */
#define DDVPFORMAT_VIDEO

/*
 * Return formats for the VBI data
 */
#define DDVPFORMAT_VBI

/****************************************************************************
 *
 * DIRIRECTDRAWVIDEOPORT SETTARGETSURFACE FLAGS
 *
 ****************************************************************************/

/*
 * Surface should receive video data (and VBI data if a surface
 * is not explicitly attached for that purpose)
 */
#define DDVPTARGET_VIDEO

/*
 * Surface should receive VBI data
 */
#define DDVPTARGET_VBI


/****************************************************************************
 *
 * DIRIRECTDRAWVIDEOPORT WAITFORSYNC FLAGS
 *
 ****************************************************************************/

/*
 * Waits until the beginning of the next VSYNC
 */
#define DDVPWAIT_BEGIN

/*
 * Waits until the end of the next/current VSYNC
 */
#define DDVPWAIT_END

/*
 * Waits until the beginning of the specified line
 */
#define DDVPWAIT_LINE

/****************************************************************************
 *
 * DIRECTDRAWVIDEOPORT FLIP FLAGS
 *
 ****************************************************************************/

/*
 * Flips the normal video surface
 */
#define DDVPFLIP_VIDEO

/*
 * Flips the VBI surface
 */
#define DDVPFLIP_VBI

/****************************************************************************
 *
 * DIRIRECTDRAWVIDEOPORT GETVIDEOSIGNALSTATUS VALUES
 *
 ****************************************************************************/

/*
 * No video signal is present at the video port
 */
#define DDVPSQ_NOSIGNAL

/*
 * A valid video signal is present at the video port
 */
#define DDVPSQ_SIGNALOK

/****************************************************************************
 *
 * VIDEOPORTBANDWIDTH Flags
 *
 ****************************************************************************/

/*
 * The specified height/width refer to the size of the video port data
 * written into memory, after prescaling has occured.
 */
#define DDVPB_VIDEOPORT

/*
 * The specified height/width refer to the source size of the overlay.
 */
#define DDVPB_OVERLAY

/*
 * This is a query for the device to return which caps this device requires.
 */
#define DDVPB_TYPE

/****************************************************************************
 *
 * VIDEOPORTBANDWIDTH Caps
 *
 ****************************************************************************/

/*
 * The bandwidth for this device is dependant on the overlay source size.
 */
#define DDVPBCAPS_SOURCE

/*
 * The bandwidth for this device is dependant on the overlay destination
 * size.
 */
#define DDVPBCAPS_DESTINATION

/****************************************************************************
 *
 * DDVIDEOPORTCONTAINER CreateVideoPort flags
 *
 ****************************************************************************/

/*
 * The process only wants to control the VBI portion of the video stream.
 */
#define DDVPCREATE_VBIONLY

/*
 * The process only wants to control the non-VBI (video) portion of
 * the video stream.
 */
#define DDVPCREATE_VIDEOONLY

/****************************************************************************
 *
 * DDVIDEOPORTSTATUS flags
 *
 ****************************************************************************/

/*
 * The video port interface is only controlling the VBI portion of the
 * video stream
 */
#define DDVPSTATUS_VBIONLY

/*
 * The video port interface is only controlling the video portion of the
 * video stream
 */
#define DDVPSTATUS_VIDEOONLY


#if __cplusplus
#endif

#endif // GUID_DEFS_ONLY


