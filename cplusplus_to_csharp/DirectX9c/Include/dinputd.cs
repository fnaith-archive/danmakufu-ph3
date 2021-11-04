/****************************************************************************
 *
 *  Copyright (C) 1995-2000 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dinputd.h
 *  Content:    DirectInput include file for device driver implementors
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma message(__FILE__ ": DIRECTINPUT_VERSION undefined. Defaulting to version 0x0800")

#if __cplusplus
#endif

/****************************************************************************
 *
 *      Interfaces
 *
 ****************************************************************************/

#if ! DIJ_RINGZERO

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputEffectDriver, 0x02538130,0x898F,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputJoyConfig, 0x1DE12AB1,0xC9F5,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputPIDDriver, 0xEEC6993A,0xB3FD,0x11D2,0xA9,0x16,0x00,0xC0,0x4F,0xB9,0x86,0x38);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputJoyConfig8, 0xeb0d7dfa,0x1990,0x4f27,0xb4,0xd6,0xed,0xf2,0xee,0xc4,0xa4,0x4c);

#endif // DIJ_RINGZERO


/****************************************************************************
 *
 *      IDirectInputEffectDriver
 *
 ****************************************************************************/

public class DIOBJECTATTRIBUTES
{
    public uint dwFlags;
    public ushort wUsagePage;
    public ushort wUsage;
}

public class DIFFOBJECTATTRIBUTES
{
    public uint dwFFMaxForce;
    public uint dwFFForceResolution;
}

public class DIOBJECTCALIBRATION
{
    public int lMin;
    public int lCenter;
    public int lMax;
}

public class DIPOVCALIBRATION
{
    public int[] lMin = new int[5];
    public int[] lMax = new int[5];
}

public class DIEFFECTATTRIBUTES
{
    public uint dwEffectId;
    public uint dwEffType;
    public uint dwStaticParams;
    public uint dwDynamicParams;
    public uint dwCoords;
}

public class DIFFDEVICEATTRIBUTES
{
    public uint dwFlags;
    public uint dwFFSamplePeriod;
    public uint dwFFMinTimeResolution;
}

public class DIDRIVERVERSIONS
{
    public uint dwSize;
    public uint dwFirmwareRevision;
    public uint dwHardwareRevision;
    public uint dwFFDriverVersion;
}

public class DIDEVICESTATE
{
    public uint dwSize;
    public uint dwState;
    public uint dwLoad;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEV_STS_EFFECT_RUNNING DIEGES_PLAYING

#if ! DIJ_RINGZERO

public class DIHIDFFINITINFO
{
    public uint dwSize;
    public string pwszDeviceInterface;
    public GUID GuidInstance = new GUID();
}


/****************************************************************************
 *
 *      IDirectInputJoyConfig
 *
 ****************************************************************************/

/****************************************************************************
 *
 *      Definitions copied from the DDK
 *
 ****************************************************************************/


/* pre-defined joystick types */
#define JOY_HW_NONE
#define JOY_HW_CUSTOM
#define JOY_HW_2A_2B_GENERIC
#define JOY_HW_2A_4B_GENERIC
#define JOY_HW_2B_GAMEPAD
#define JOY_HW_2B_FLIGHTYOKE
#define JOY_HW_2B_FLIGHTYOKETHROTTLE
#define JOY_HW_3A_2B_GENERIC
#define JOY_HW_3A_4B_GENERIC
#define JOY_HW_4B_GAMEPAD
#define JOY_HW_4B_FLIGHTYOKE
#define JOY_HW_4B_FLIGHTYOKETHROTTLE
#define JOY_HW_TWO_2A_2B_WITH_Y
#define JOY_HW_LASTENTRY


/* calibration flags */
#define JOY_ISCAL_XY
#define JOY_ISCAL_Z
#define JOY_ISCAL_R
#define JOY_ISCAL_U
#define JOY_ISCAL_V
#define JOY_ISCAL_POV

/* point of view constants */
#define JOY_POV_NUMDIRS
#define JOY_POVVAL_FORWARD
#define JOY_POVVAL_BACKWARD
#define JOY_POVVAL_LEFT
#define JOY_POVVAL_RIGHT

/* Specific settings for joystick hardware */
#define JOY_HWS_HASZ
#define JOY_HWS_HASPOV
#define JOY_HWS_POVISBUTTONCOMBOS
#define JOY_HWS_POVISPOLL
#define JOY_HWS_ISYOKE
#define JOY_HWS_ISGAMEPAD
#define JOY_HWS_ISCARCTRL
/* X defaults to J1 X axis */
#define JOY_HWS_XISJ1Y
#define JOY_HWS_XISJ2X
#define JOY_HWS_XISJ2Y
/* Y defaults to J1 Y axis */
#define JOY_HWS_YISJ1X
#define JOY_HWS_YISJ2X
#define JOY_HWS_YISJ2Y
/* Z defaults to J2 Y axis */
#define JOY_HWS_ZISJ1X
#define JOY_HWS_ZISJ1Y
#define JOY_HWS_ZISJ2X
/* POV defaults to J2 Y axis, if it is not button based */
#define JOY_HWS_POVISJ1X
#define JOY_HWS_POVISJ1Y
#define JOY_HWS_POVISJ2X
/* R defaults to J2 X axis */
#define JOY_HWS_HASR
#define JOY_HWS_RISJ1X
#define JOY_HWS_RISJ1Y
#define JOY_HWS_RISJ2Y
/* U & V for future hardware */
#define JOY_HWS_HASU
#define JOY_HWS_HASV

/* Usage settings */
#define JOY_US_HASRUDDER
#define JOY_US_PRESENT
#define JOY_US_ISOEM

/* reserved for future use -> as link to next possible dword */
#define JOY_US_RESERVED


/* Settings for TypeInfo Flags1 */
#define JOYTYPE_ZEROGAMEENUMOEMDATA
#define JOYTYPE_NOAUTODETECTGAMEPORT
#define JOYTYPE_NOHIDDIRECT
#define JOYTYPE_ANALOGCOMPAT
#define JOYTYPE_DEFAULTPROPSHEET

/* Settings for TypeInfo Flags2 */
#define JOYTYPE_DEVICEHIDE
#define JOYTYPE_MOUSEHIDE
#define JOYTYPE_KEYBHIDE
#define JOYTYPE_GAMEHIDE
#define JOYTYPE_HIDEACTIVE
#define JOYTYPE_INFOMASK
#define JOYTYPE_INFODEFAULT
#define JOYTYPE_INFOYYPEDALS
#define JOYTYPE_INFOZYPEDALS
#define JOYTYPE_INFOYRPEDALS
#define JOYTYPE_INFOZRPEDALS
#define JOYTYPE_INFOZISSLIDER
#define JOYTYPE_INFOZISZ
#define JOYTYPE_ENABLEINPUTREPORT

/* struct for storing x,y, z, and rudder values */
public class joypos_tag
{
    public uint dwX;
    public uint dwY;
    public uint dwZ;
    public uint dwR;
    public uint dwU;
    public uint dwV;
}

/* struct for storing ranges */
public class joyrange_tag
{
    public joypos_tag jpMin = new joypos_tag();
    public joypos_tag jpMax = new joypos_tag();
    public joypos_tag jpCenter = new joypos_tag();
}

/*
 *  dwTimeout - value at which to timeout joystick polling
 *  jrvRanges - range of values app wants returned for axes
 *  jpDeadZone - area around center to be considered
 *               as "dead". specified as a percentage
 *               (0-100). Only X & Y handled by system driver
 */
public class joyreguservalues_tag
{
    public uint dwTimeOut;
    public joyrange_tag jrvRanges = new joyrange_tag();
    public joypos_tag jpDeadZone = new joypos_tag();
}

public class joyreghwsettings_tag
{
    public uint dwFlags;
    public uint dwNumButtons;
}

/* range of values returned by the hardware (filled in by calibration) */
/*
 *  jrvHardware - values returned by hardware
 *  dwPOVValues - POV values returned by hardware
 *  dwCalFlags  - what has been calibrated
 */
public class joyreghwvalues_tag
{
    public joyrange_tag jrvHardware = new joyrange_tag();
    public uint[] dwPOVValues = new uint[DefineConstants.JOY_POV_NUMDIRS];
    public uint dwCalFlags;
}

/* hardware configuration */
/*
 *  hws             - hardware settings
 *  dwUsageSettings - usage settings
 *  hwv             - values returned by hardware
 *  dwType          - type of joystick
 *  dwReserved      - reserved for OEM drivers
 */
public class joyreghwconfig_tag
{
    public joyreghwsettings_tag hws = new joyreghwsettings_tag();
    public uint dwUsageSettings;
    public joyreghwvalues_tag hwv = new joyreghwvalues_tag();
    public uint dwType;
    public uint dwReserved;
}

/* joystick calibration info structure */
public class joycalibrate_tag
{
    public uint wXbase;
    public uint wXdelta;
    public uint wYbase;
    public uint wYdelta;
    public uint wZbase;
    public uint wZdelta;
}


#if ! DIJ_RINGZERO

#define MAX_JOYSTRING
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIJOYTYPECALLBACK)(const char*, object*);
public delegate bool LPDIJOYTYPECALLBACK(string UnnamedParameter, object UnnamedParameter2);

#define MAX_JOYSTICKOEMVXDNAME

#define DITC_REGHWSETTINGS
#define DITC_CLSIDCONFIG
#define DITC_DISPLAYNAME
#define DITC_CALLOUT
#define DITC_HARDWAREID
#define DITC_FLAGS1
#define DITC_FLAGS2
#define DITC_MAPFILE



/* This structure is defined for DirectX 5.0 compatibility */

public class DIJOYTYPEINFO_DX5
{
    public uint dwSize;
    public joyreghwsettings_tag hws = new joyreghwsettings_tag();
    public CLSID clsidConfig = new CLSID();
    public string wszDisplayName = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public string wszCallout = new string(new char[DefineConstants.MAX_JOYSTICKOEMVXDNAME]);
}

/* This structure is defined for DirectX 6.1 compatibility */
public class DIJOYTYPEINFO_DX6
{
    public uint dwSize;
    public joyreghwsettings_tag hws = new joyreghwsettings_tag();
    public CLSID clsidConfig = new CLSID();
    public string wszDisplayName = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public string wszCallout = new string(new char[DefineConstants.MAX_JOYSTICKOEMVXDNAME]);
    public string wszHardwareId = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public uint dwFlags1;
}

public class DIJOYTYPEINFO
{
    public uint dwSize;
    public joyreghwsettings_tag hws = new joyreghwsettings_tag();
    public CLSID clsidConfig = new CLSID();
    public string wszDisplayName = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public string wszCallout = new string(new char[DefineConstants.MAX_JOYSTICKOEMVXDNAME]);
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x05b2)
    public string wszHardwareId = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public uint dwFlags1;
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
    public uint dwFlags2;
    public string wszMapFile = new string(new char[DefineConstants.MAX_JOYSTRING]);
#endif // DIRECTINPUT_VERSION >= 0x0800
#endif // DIRECTINPUT_VERSION >= 0x05b2
}

/* This structure is defined for DirectX 5.0 compatibility */

public class DIJOYCONFIG_DX5
{
    public uint dwSize;
    public GUID guidInstance = new GUID();
    public joyreghwconfig_tag hwc = new joyreghwconfig_tag();
    public uint dwGain;
    public string wszType = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public string wszCallout = new string(new char[DefineConstants.MAX_JOYSTRING]);
}

public class DIJOYCONFIG
{
    public uint dwSize;
    public GUID guidInstance = new GUID();
    public joyreghwconfig_tag hwc = new joyreghwconfig_tag();
    public uint dwGain;
    public string wszType = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public string wszCallout = new string(new char[DefineConstants.MAX_JOYSTRING]);
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x05b2)
    public GUID guidGameport = new GUID();
#endif // DIRECTINPUT_VERSION >= 0x05b2
}



public class DIJOYUSERVALUES
{
    public uint dwSize;
    public joyreguservalues_tag ruv = new joyreguservalues_tag();
    public string wszGlobalDriver = new string(new char[DefineConstants.MAX_JOYSTRING]);
    public string wszGameportEmulator = new string(new char[DefineConstants.MAX_JOYSTRING]);
}

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_KeyboardClass, 0x4D36E96B,0xE325,0x11CE,0xBF,0xC1,0x08,0x00,0x2B,0xE1,0x03,0x18);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_MediaClass, 0x4D36E96C,0xE325,0x11CE,0xBF,0xC1,0x08,0x00,0x2B,0xE1,0x03,0x18);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_MouseClass, 0x4D36E96F,0xE325,0x11CE,0xBF,0xC1,0x08,0x00,0x2B,0xE1,0x03,0x18);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_HIDClass, 0x745A17A0,0x74D3,0x11D0,0xB6,0xFE,0x00,0xA0,0xC9,0x0F,0x57,0xDA);