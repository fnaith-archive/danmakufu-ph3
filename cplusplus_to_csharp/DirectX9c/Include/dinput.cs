#define DIRECTINPUT_VERSION

using System;

/****************************************************************************
 *
 *  Copyright (C) 1996-2000 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dinput.h
 *  Content:    DirectInput include file
 *
 ****************************************************************************/


#if ! DIJ_RINGZERO

#if _WIN32
#define COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>
#endif

#endif // DIJ_RINGZERO

#if __cplusplus
#endif





/*
 *  To build applications for older versions of DirectInput
 *
 *  #define DIRECTINPUT_VERSION [ 0x0300 | 0x0500 | 0x0700 ]
 *
 *  before #include <dinput.h>.  By default, #include <dinput.h>
 *  will produce a DirectX 8-compatible header file.
 *
 */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIRECTINPUT_VERSION DIRECTINPUT_HEADER_VERSION
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma message(__FILE__ ": DIRECTINPUT_VERSION undefined. Defaulting to version 0x0800")

#if ! DIJ_RINGZERO

/****************************************************************************
 *
 *      Class IDs
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectInput, 0x25E609E0,0xB259,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectInputDevice, 0x25E609E1,0xB259,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectInput8, 0x25E609E4,0xB259,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectInputDevice8,0x25E609E5,0xB259,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

/****************************************************************************
 *
 *      Interfaces
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputA, 0x89521360,0xAA8A,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputW, 0x89521361,0xAA8A,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInput2A, 0x5944E662,0xAA8A,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInput2W, 0x5944E663,0xAA8A,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInput7A, 0x9A4CB684,0x236D,0x11D3,0x8E,0x9D,0x00,0xC0,0x4F,0x68,0x44,0xAE);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInput7W, 0x9A4CB685,0x236D,0x11D3,0x8E,0x9D,0x00,0xC0,0x4F,0x68,0x44,0xAE);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInput8A, 0xBF798030,0x483A,0x4DA2,0xAA,0x99,0x5D,0x64,0xED,0x36,0x97,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInput8W, 0xBF798031,0x483A,0x4DA2,0xAA,0x99,0x5D,0x64,0xED,0x36,0x97,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDeviceA, 0x5944E680,0xC92E,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDeviceW, 0x5944E681,0xC92E,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDevice2A,0x5944E682,0xC92E,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDevice2W,0x5944E683,0xC92E,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDevice7A,0x57D7C6BC,0x2356,0x11D3,0x8E,0x9D,0x00,0xC0,0x4F,0x68,0x44,0xAE);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDevice7W,0x57D7C6BD,0x2356,0x11D3,0x8E,0x9D,0x00,0xC0,0x4F,0x68,0x44,0xAE);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDevice8A,0x54D41080,0xDC15,0x4833,0xA4,0x1B,0x74,0x8F,0x73,0xA3,0x81,0x79);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputDevice8W,0x54D41081,0xDC15,0x4833,0xA4,0x1B,0x74,0x8F,0x73,0xA3,0x81,0x79);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectInputEffect, 0xE7E1F7C0,0x88D2,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);

/****************************************************************************
 *
 *      Predefined object types
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_XAxis, 0xA36D02E0,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_YAxis, 0xA36D02E1,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_ZAxis, 0xA36D02E2,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_RxAxis, 0xA36D02F4,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_RyAxis, 0xA36D02F5,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_RzAxis, 0xA36D02E3,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Slider, 0xA36D02E4,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Button, 0xA36D02F0,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Key, 0x55728220,0xD33C,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_POV, 0xA36D02F2,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Unknown, 0xA36D02F3,0xC9F3,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

/****************************************************************************
 *
 *      Predefined product GUIDs
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SysMouse, 0x6F1D2B60,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SysKeyboard,0x6F1D2B61,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Joystick,0x6F1D2B70,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SysMouseEm, 0x6F1D2B80,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SysMouseEm2,0x6F1D2B81,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SysKeyboardEm, 0x6F1D2B82,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SysKeyboardEm2,0x6F1D2B83,0xD5A0,0x11CF,0xBF,0xC7,0x44,0x45,0x53,0x54,0x00,0x00);

/****************************************************************************
 *
 *      Predefined force feedback effects
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_ConstantForce, 0x13541C20,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_RampForce, 0x13541C21,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Square, 0x13541C22,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Sine, 0x13541C23,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Triangle, 0x13541C24,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SawtoothUp, 0x13541C25,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SawtoothDown, 0x13541C26,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Spring, 0x13541C27,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Damper, 0x13541C28,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Inertia, 0x13541C29,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Friction, 0x13541C2A,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_CustomForce, 0x13541C2B,0x8E33,0x11D0,0x9A,0xD0,0x00,0xA0,0xC9,0xA0,0x6E,0x35);

#endif // DIJ_RINGZERO

/****************************************************************************
 *
 *      Interfaces and Structures...
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)

/****************************************************************************
 *
 *      IDirectInputEffect
 *
 ****************************************************************************/


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIEFT_GETTYPE(n) LOBYTE(n)


public class DICONSTANTFORCE
{
    public int lMagnitude;
}

public class DIRAMPFORCE
{
    public int lStart;
    public int lEnd;
}

public class DIPERIODIC
{
    public uint dwMagnitude;
    public int lOffset;
    public uint dwPhase;
    public uint dwPeriod;
}

public class DICONDITION
{
    public int lOffset;
    public int lPositiveCoefficient;
    public int lNegativeCoefficient;
    public uint dwPositiveSaturation;
    public uint dwNegativeSaturation;
    public int lDeadBand;
}

public class DICUSTOMFORCE
{
    public uint cChannels;
    public uint dwSamplePeriod;
    public uint cSamples;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int * rglForceData;
    public int rglForceData;
}


public class DIENVELOPE
{
    public uint dwSize; // sizeof(DIENVELOPE)
    public uint dwAttackLevel;
    public uint dwAttackTime; // Microseconds
    public uint dwFadeLevel;
    public uint dwFadeTime; // Microseconds
}


/* This structure is defined for DirectX 5.0 compatibility */
public class DIEFFECT_DX5
{
    public uint dwSize; // sizeof(DIEFFECT_DX5)
    public uint dwFlags; // DIEFF_*
    public uint dwDuration; // Microseconds
    public uint dwSamplePeriod; // Microseconds
    public uint dwGain;
    public uint dwTriggerButton; // or DIEB_NOTRIGGER
    public uint dwTriggerRepeatInterval; // Microseconds
    public uint cAxes; // Number of axes
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint * rgdwAxes;
    public uint rgdwAxes; // Array of axes
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int * rglDirection;
    public int rglDirection; // Array of directions
    public DIENVELOPE lpEnvelope; // Optional
    public uint cbTypeSpecificParams; // Size of params
    public object lpvTypeSpecificParams; // Pointer to params
}

public class DIEFFECT
{
    public uint dwSize; // sizeof(DIEFFECT)
    public uint dwFlags; // DIEFF_*
    public uint dwDuration; // Microseconds
    public uint dwSamplePeriod; // Microseconds
    public uint dwGain;
    public uint dwTriggerButton; // or DIEB_NOTRIGGER
    public uint dwTriggerRepeatInterval; // Microseconds
    public uint cAxes; // Number of axes
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint * rgdwAxes;
    public uint rgdwAxes; // Array of axes
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int * rglDirection;
    public int rglDirection; // Array of directions
    public DIENVELOPE lpEnvelope; // Optional
    public uint cbTypeSpecificParams; // Size of params
    public object lpvTypeSpecificParams; // Pointer to params
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0600)
    public uint dwStartDelay; // Microseconds
#endif // DIRECTINPUT_VERSION >= 0x0600
}


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0700)
#if ! DIJ_RINGZERO
public class DIFILEEFFECT
{
    public uint dwSize;
    public GUID GuidEffect = new GUID();
    public readonly DIEFFECT lpDiEffect;
    public string szFriendlyName = new string(new char[MAX_PATH]);
}
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMEFFECTSINFILECALLBACK)(const DIFILEEFFECT *, object*);
public delegate bool LPDIENUMEFFECTSINFILECALLBACK(DIFILEEFFECT UnnamedParameter, object UnnamedParameter2);
#endif // DIJ_RINGZERO
#endif // DIRECTINPUT_VERSION >= 0x0700


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0600)
#else // DIRECTINPUT_VERSION < 0x0600
#endif // DIRECTINPUT_VERSION < 0x0600



public class DIEFFESCAPE
{
    public uint dwSize;
    public uint dwCommand;
    public object lpvInBuffer;
    public uint cbInBuffer;
    public object lpvOutBuffer;
    public uint cbOutBuffer;
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_DIDEVICE_TYPE(dwDevType) LOBYTE(dwDevType)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GET_DIDEVICE_SUBTYPE(dwDevType) HIBYTE(dwDevType)

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
/* This structure is defined for DirectX 3.0 compatibility */
public class DIDEVCAPS_DX3
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwDevType;
    public uint dwAxes;
    public uint dwButtons;
    public uint dwPOVs;
}
#endif // DIRECTINPUT_VERSION >= 0x0500

public class DIDEVCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwDevType;
    public uint dwAxes;
    public uint dwButtons;
    public uint dwPOVs;
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
    public uint dwFFSamplePeriod;
    public uint dwFFMinTimeResolution;
    public uint dwFirmwareRevision;
    public uint dwHardwareRevision;
    public uint dwFFDriverVersion;
#endif // DIRECTINPUT_VERSION >= 0x0500
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
#endif // DIRECTINPUT_VERSION >= 0x0500
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
#endif // DIRECTINPUT_VERSION >= 0x050a
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
#endif // DIRECTINPUT_VERSION >= 0x0800





// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIDFT_INSTANCEMASK DIDFT_ANYINSTANCE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIDFT_MAKEINSTANCE(n) ((WORD)(n) << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIDFT_GETTYPE(n) LOBYTE(n)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIDFT_GETINSTANCE(n) LOWORD((n) >> 8)
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
#endif // DIRECTINPUT_VERSION >= 0x050a

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIDFT_ENUMCOLLECTION(n) ((WORD)(n) << 8)

#if ! DIJ_RINGZERO

public class _DIOBJECTDATAFORMAT
{
    public readonly GUID pguid;
    public uint dwOfs;
    public uint dwType;
    public uint dwFlags;
}

public class _DIDATAFORMAT
{
    public uint dwSize;
    public uint dwObjSize;
    public uint dwFlags;
    public uint dwDataSize;
    public uint dwNumObjs;
    public _DIOBJECTDATAFORMAT rgodf;
}

#define DIDF_ABSAXIS
#define DIDF_RELAXIS

#if __cplusplus
#endif


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTINPUT_VERSION > 0x0700

public class _DIACTIONA
{
                public UIntPtr uAppData;
                public uint dwSemantic;
    public OPTIONAL uint dwFlags = new OPTIONAL();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    OPTIONAL union
//    {
//                    const char* lptszActionName;
//                    uint uResIdString;
//                };
    public OPTIONAL GUID guidInstance = new OPTIONAL();
    public OPTIONAL uint dwObjID = new OPTIONAL();
    public OPTIONAL uint dwHow = new OPTIONAL();
}
public class _DIACTIONW
{
                public UIntPtr uAppData;
                public uint dwSemantic;
    public OPTIONAL uint dwFlags = new OPTIONAL();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    OPTIONAL union
//    {
//                    const char* lptszActionName;
//                    uint uResIdString;
//                };
    public OPTIONAL GUID guidInstance = new OPTIONAL();
    public OPTIONAL uint dwObjID = new OPTIONAL();
    public OPTIONAL uint dwHow = new OPTIONAL();
}
#if UNICODE
#else
#endif // UNICODE

#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIACTION' was defined in multiple preprocessor conditionals and cannot be replaced in-line:


#define DIA_FORCEFEEDBACK
#define DIA_APPMAPPED
#define DIA_APPNOMAP
#define DIA_NORANGE
#define DIA_APPFIXED

#define DIAH_UNMAPPED
#define DIAH_USERCONFIG
#define DIAH_APPREQUESTED
#define DIAH_HWAPP
#define DIAH_HWDEFAULT
#define DIAH_DEFAULT
#define DIAH_ERROR

public class _DIACTIONFORMATA
{
                public uint dwSize;
                public uint dwActionSize;
                public uint dwDataSize;
                public uint dwNumActions;
                public _DIACTIONA rgoAction;
                public GUID guidActionMap = new GUID();
                public uint dwGenre;
                public uint dwBufferSize;
    public OPTIONAL int lAxisMin = new OPTIONAL();
    public OPTIONAL int lAxisMax = new OPTIONAL();
    public OPTIONAL IntPtr hInstString = new OPTIONAL();
                public FILETIME ftTimeStamp = new FILETIME();
                public uint dwCRC;
                public string tszActionMap = new string(new char[MAX_PATH]);
}
public class _DIACTIONFORMATW
{
                public uint dwSize;
                public uint dwActionSize;
                public uint dwDataSize;
                public uint dwNumActions;
                public _DIACTIONW rgoAction;
                public GUID guidActionMap = new GUID();
                public uint dwGenre;
                public uint dwBufferSize;
    public OPTIONAL int lAxisMin = new OPTIONAL();
    public OPTIONAL int lAxisMax = new OPTIONAL();
    public OPTIONAL IntPtr hInstString = new OPTIONAL();
                public FILETIME ftTimeStamp = new FILETIME();
                public uint dwCRC;
                public string tszActionMap = new string(new char[MAX_PATH]);
}
#if UNICODE
#else
#endif // UNICODE
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIACTIONFORMAT' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

#define DIAFTS_NEWDEVICELOW
#define DIAFTS_NEWDEVICEHIGH
#define DIAFTS_UNUSEDDEVICELOW
#define DIAFTS_UNUSEDDEVICEHIGH

#define DIDBAM_DEFAULT
#define DIDBAM_PRESERVE
#define DIDBAM_INITIALIZE
#define DIDBAM_HWDEFAULTS

#define DIDSAM_DEFAULT
#define DIDSAM_NOUSER
#define DIDSAM_FORCESAVE

#define DICD_DEFAULT
#define DICD_EDIT

/*
 * The following definition is normally defined in d3dtypes.h
 */
#if ! D3DCOLOR_DEFINED
#define D3DCOLOR_DEFINED
#endif

public class _DICOLORSET
{
    public uint dwSize;
    public uint cTextFore;
    public uint cTextHighlight;
    public uint cCalloutLine;
    public uint cCalloutHighlight;
    public uint cBorder;
    public uint cControlFill;
    public uint cHighlightFill;
    public uint cAreaFill;
}


public class _DICONFIGUREDEVICESPARAMSA
{
     public uint dwSize;
     public uint dwcUsers;
     public string lptszUserNames;
     public uint dwcFormats;
     public _DIACTIONFORMATA lprgFormats;
     public IntPtr hwnd;
     public _DICOLORSET dics = new _DICOLORSET();
     public IUnknown lpUnkDDSTarget;
}
public class _DICONFIGUREDEVICESPARAMSW
{
     public uint dwSize;
     public uint dwcUsers;
     public string lptszUserNames;
     public uint dwcFormats;
     public _DIACTIONFORMATW lprgFormats;
     public IntPtr hwnd;
     public _DICOLORSET dics = new _DICOLORSET();
     public IUnknown lpUnkDDSTarget;
}
#if UNICODE
#else
#endif // UNICODE
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DICONFIGUREDEVICESPARAMS' was defined in multiple preprocessor conditionals and cannot be replaced in-line:


#define DIDIFT_CONFIGURATION
#define DIDIFT_OVERLAY

#define DIDAL_CENTERED
#define DIDAL_LEFTALIGNED
#define DIDAL_RIGHTALIGNED
#define DIDAL_MIDDLE
#define DIDAL_TOPALIGNED
#define DIDAL_BOTTOMALIGNED

public class _DIDEVICEIMAGEINFOA
{
    public string tszImagePath = new string(new char[MAX_PATH]);
    public uint dwFlags;
    // These are valid if DIDIFT_OVERLAY is present in dwFlags.
    public uint dwViewID;
    public RECT rcOverlay = new RECT();
    public uint dwObjID;
    public uint dwcValidPts;
    public POINT[] rgptCalloutLine = Arrays.InitializeWithDefaultInstances<POINT>(5);
    public RECT rcCalloutRect = new RECT();
    public uint dwTextAlign;
}
public class _DIDEVICEIMAGEINFOW
{
    public string tszImagePath = new string(new char[MAX_PATH]);
    public uint dwFlags;
    // These are valid if DIDIFT_OVERLAY is present in dwFlags.
    public uint dwViewID;
    public RECT rcOverlay = new RECT();
    public uint dwObjID;
    public uint dwcValidPts;
    public POINT[] rgptCalloutLine = Arrays.InitializeWithDefaultInstances<POINT>(5);
    public RECT rcCalloutRect = new RECT();
    public uint dwTextAlign;
}
#if UNICODE
#else
#endif // UNICODE
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIDEVICEIMAGEINFO' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

public class _DIDEVICEIMAGEINFOHEADERA
{
    public uint dwSize;
    public uint dwSizeImageInfo;
    public uint dwcViews;
    public uint dwcButtons;
    public uint dwcAxes;
    public uint dwcPOVs;
    public uint dwBufferSize;
    public uint dwBufferUsed;
    public _DIDEVICEIMAGEINFOA lprgImageInfoArray;
}
public class _DIDEVICEIMAGEINFOHEADERW
{
    public uint dwSize;
    public uint dwSizeImageInfo;
    public uint dwcViews;
    public uint dwcButtons;
    public uint dwcAxes;
    public uint dwcPOVs;
    public uint dwBufferSize;
    public uint dwBufferUsed;
    public _DIDEVICEIMAGEINFOW lprgImageInfoArray;
}
#if UNICODE
#else
#endif // UNICODE
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIDEVICEIMAGEINFOHEADER' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

#endif // DIRECTINPUT_VERSION > 0x0700

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
/* These structures are defined for DirectX 3.0 compatibility */

public class DIDEVICEOBJECTINSTANCE_DX3A
{
    public uint dwSize;
    public GUID guidType = new GUID();
    public uint dwOfs;
    public uint dwType;
    public uint dwFlags;
    public string tszName = new string(new char[MAX_PATH]);
}
public class DIDEVICEOBJECTINSTANCE_DX3W
{
    public uint dwSize;
    public GUID guidType = new GUID();
    public uint dwOfs;
    public uint dwType;
    public uint dwFlags;
    public string tszName = new string(new char[MAX_PATH]);
}
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIDEVICEOBJECTINSTANCE_DX3' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
#endif // DIRECTINPUT_VERSION >= 0x0500

public class DIDEVICEOBJECTINSTANCEA
{
    public uint dwSize;
    public GUID guidType = new GUID();
    public uint dwOfs;
    public uint dwType;
    public uint dwFlags;
    public string tszName = new string(new char[MAX_PATH]);
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
    public uint dwFFMaxForce;
    public uint dwFFForceResolution;
    public ushort wCollectionNumber;
    public ushort wDesignatorIndex;
    public ushort wUsagePage;
    public ushort wUsage;
    public uint dwDimension;
    public ushort wExponent;
    public ushort wReportId;
#endif // DIRECTINPUT_VERSION >= 0x0500
}
public class DIDEVICEOBJECTINSTANCEW
{
    public uint dwSize;
    public GUID guidType = new GUID();
    public uint dwOfs;
    public uint dwType;
    public uint dwFlags;
    public string tszName = new string(new char[MAX_PATH]);
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
    public uint dwFFMaxForce;
    public uint dwFFForceResolution;
    public ushort wCollectionNumber;
    public ushort wDesignatorIndex;
    public ushort wUsagePage;
    public ushort wUsage;
    public uint dwDimension;
    public ushort wExponent;
    public ushort wReportId;
#endif // DIRECTINPUT_VERSION >= 0x0500
}
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIDEVICEOBJECTINSTANCE' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMDEVICEOBJECTSCALLBACKA)(const DIDEVICEOBJECTINSTANCEA *, object*);
public delegate bool LPDIENUMDEVICEOBJECTSCALLBACKA(DIDEVICEOBJECTINSTANCEA UnnamedParameter, object UnnamedParameter2);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMDEVICEOBJECTSCALLBACKW)(const DIDEVICEOBJECTINSTANCEW *, object*);
public delegate bool LPDIENUMDEVICEOBJECTSCALLBACKW(DIDEVICEOBJECTINSTANCEW UnnamedParameter, object UnnamedParameter2);
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMDEVICEOBJECTSCALLBACK LPDIENUMDEVICEOBJECTSCALLBACKW
#define LPDIENUMDEVICEOBJECTSCALLBACK
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMDEVICEOBJECTSCALLBACK LPDIENUMDEVICEOBJECTSCALLBACKA
#define LPDIENUMDEVICEOBJECTSCALLBACK
#endif // !UNICODE

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
#endif // DIRECTINPUT_VERSION >= 0x0500
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
#endif // DIRECTINPUT_VERSION >= 0x050a

public class DIPROPHEADER
{
    public uint dwSize;
    public uint dwHeaderSize;
    public uint dwObj;
    public uint dwHow;
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
#endif // DIRECTINPUT_VERSION >= 0x050a

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMAKEUSAGEDWORD(UsagePage, Usage) (DWORD)MAKELONG(Usage, UsagePage)
#endif // DIRECTINPUT_VERSION >= 0x050a

public class DIPROPDWORD
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public uint dwData;
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
public class DIPROPPOINTER
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public UIntPtr uData;
}
#endif // DIRECTINPUT_VERSION >= 0x0800

public class DIPROPRANGE
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public int lMin;
    public int lMax;
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROPRANGE_NOMIN ((LONG)0x80000000)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROPRANGE_NOMAX ((LONG)0x7FFFFFFF)

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
public class DIPROPCAL
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public int lMin;
    public int lCenter;
    public int lMax;
}

public class DIPROPCALPOV
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public int[] lMin = new int[5];
    public int[] lMax = new int[5];
}

public class DIPROPGUIDANDPATH
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public GUID guidClass = new GUID();
    public string wszPath = new string(new char[MAX_PATH]);
}

public class DIPROPSTRING
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public string wsz = new string(new char[MAX_PATH]);
}

#endif // DIRECTINPUT_VERSION >= 0x050a

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)

public class _CPOINT
{
    public int lP; // raw value
    public uint dwLog; // logical_value / max_logical_value * 10000
}

public class DIPROPCPOINTS
{
    public DIPROPHEADER diph = new DIPROPHEADER();
    public uint dwCPointsNum;
    public _CPOINT[] cp = Arrays.InitializeWithDefaultInstances<_CPOINT>(DefineConstants.MAXCPOINTSNUM);
}
#endif // DIRECTINPUT_VERSION >= 0x0800


#if __cplusplus
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEDIPROP(prop) (*(const GUID *)(prop))
#define MAKEDIPROP
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEDIPROP(prop) ((REFGUID)(prop))
#define MAKEDIPROP
#endif

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_BUFFERSIZE MAKEDIPROP(1)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_AXISMODE MAKEDIPROP(2)


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_GRANULARITY MAKEDIPROP(3)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_RANGE MAKEDIPROP(4)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_DEADZONE MAKEDIPROP(5)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_SATURATION MAKEDIPROP(6)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_FFGAIN MAKEDIPROP(7)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_FFLOAD MAKEDIPROP(8)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_AUTOCENTER MAKEDIPROP(9)


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_CALIBRATIONMODE MAKEDIPROP(10)


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_CALIBRATION MAKEDIPROP(11)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_GUIDANDPATH MAKEDIPROP(12)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_INSTANCENAME MAKEDIPROP(13)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_PRODUCTNAME MAKEDIPROP(14)
#endif // DIRECTINPUT_VERSION >= 0x050a

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x05b2)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_JOYSTICKID MAKEDIPROP(15)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_GETPORTDISPLAYNAME MAKEDIPROP(16)

#endif // DIRECTINPUT_VERSION >= 0x05b2

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0700)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_PHYSICALRANGE MAKEDIPROP(18)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_LOGICALRANGE MAKEDIPROP(19)
#endif // DIRECTINPUT_VERSION >= 0x0700

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_KEYNAME MAKEDIPROP(20)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_CPOINTS MAKEDIPROP(21)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_APPDATA MAKEDIPROP(22)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_SCANCODE MAKEDIPROP(23)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_VIDPID MAKEDIPROP(24)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_USERNAME MAKEDIPROP(25)

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIPROP_TYPENAME MAKEDIPROP(26)
#endif // DIRECTINPUT_VERSION >= 0x0800


public class DIDEVICEOBJECTDATA_DX3
{
    public uint dwOfs;
    public uint dwData;
    public uint dwTimeStamp;
    public uint dwSequence;
}

public class DIDEVICEOBJECTDATA
{
    public uint dwOfs;
    public uint dwData;
    public uint dwTimeStamp;
    public uint dwSequence;
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
    public UIntPtr uAppData;
#endif // DIRECTINPUT_VERSION >= 0x0800
}


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DISEQUENCE_COMPARE(dwSequence1, cmp, dwSequence2) ((int)((dwSequence1) - (dwSequence2)) cmp 0)

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
/* These structures are defined for DirectX 3.0 compatibility */

public class DIDEVICEINSTANCE_DX3A
{
    public uint dwSize;
    public GUID guidInstance = new GUID();
    public GUID guidProduct = new GUID();
    public uint dwDevType;
    public string tszInstanceName = new string(new char[MAX_PATH]);
    public string tszProductName = new string(new char[MAX_PATH]);
}
public class DIDEVICEINSTANCE_DX3W
{
    public uint dwSize;
    public GUID guidInstance = new GUID();
    public GUID guidProduct = new GUID();
    public uint dwDevType;
    public string tszInstanceName = new string(new char[MAX_PATH]);
    public string tszProductName = new string(new char[MAX_PATH]);
}
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIDEVICEINSTANCE_DX3' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
#endif // DIRECTINPUT_VERSION >= 0x0500

public class DIDEVICEINSTANCEA
{
    public uint dwSize;
    public GUID guidInstance = new GUID();
    public GUID guidProduct = new GUID();
    public uint dwDevType;
    public string tszInstanceName = new string(new char[MAX_PATH]);
    public string tszProductName = new string(new char[MAX_PATH]);
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
    public GUID guidFFDriver = new GUID();
    public ushort wUsagePage;
    public ushort wUsage;
#endif // DIRECTINPUT_VERSION >= 0x0500
}
public class DIDEVICEINSTANCEW
{
    public uint dwSize;
    public GUID guidInstance = new GUID();
    public GUID guidProduct = new GUID();
    public uint dwDevType;
    public string tszInstanceName = new string(new char[MAX_PATH]);
    public string tszProductName = new string(new char[MAX_PATH]);
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
    public GUID guidFFDriver = new GUID();
    public ushort wUsagePage;
    public ushort wUsage;
#endif // DIRECTINPUT_VERSION >= 0x0500
}
#if UNICODE
#else
#endif // UNICODE

#if UNICODE
#else
#endif // UNICODE


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)



#if ! DIJ_RINGZERO

public class DIEFFECTINFOA
{
    public uint dwSize;
    public GUID guid = new GUID();
    public uint dwEffType;
    public uint dwStaticParams;
    public uint dwDynamicParams;
    public string tszName = new string(new char[MAX_PATH]);
}
public class DIEFFECTINFOW
{
    public uint dwSize;
    public GUID guid = new GUID();
    public uint dwEffType;
    public uint dwStaticParams;
    public uint dwDynamicParams;
    public string tszName = new string(new char[MAX_PATH]);
}
#if UNICODE
#else
#endif // UNICODE
// C++ TO C# CONVERTER TODO TASK: The typedef 'DIEFFECTINFO' was defined in multiple preprocessor conditionals and cannot be replaced in-line:

#define DISDD_CONTINUE

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMEFFECTSCALLBACKA)(const DIEFFECTINFOA *, object*);
public delegate bool LPDIENUMEFFECTSCALLBACKA(DIEFFECTINFOA UnnamedParameter, object UnnamedParameter2);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMEFFECTSCALLBACKW)(const DIEFFECTINFOW *, object*);
public delegate bool LPDIENUMEFFECTSCALLBACKW(DIEFFECTINFOW UnnamedParameter, object UnnamedParameter2);
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMEFFECTSCALLBACK LPDIENUMEFFECTSCALLBACKW
#define LPDIENUMEFFECTSCALLBACK
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMEFFECTSCALLBACK LPDIENUMEFFECTSCALLBACKA
#define LPDIENUMEFFECTSCALLBACK
#endif // !UNICODE
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMCREATEDEFFECTOBJECTSCALLBACK)(struct IDirectInputEffect *, object*);
public delegate bool LPDIENUMCREATEDEFFECTOBJECTSCALLBACK(IDirectInputEffect UnnamedParameter, object UnnamedParameter2);

/****************************************************************************
 *
 *      Mouse
 *
 ****************************************************************************/

#if ! DIJ_RINGZERO

public class _DIMOUSESTATE
{
    public int lX;
    public int lY;
    public int lZ;
    public byte[] rgbButtons = new byte[4];
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTINPUT_VERSION >= 0x0700
public class _DIMOUSESTATE2
{
    public int lX;
    public int lY;
    public int lZ;
    public byte[] rgbButtons = new byte[8];
}
#endif


// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_X FIELD_OFFSET(DIMOUSESTATE, lX)
#define DIMOFS_X
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_Y FIELD_OFFSET(DIMOUSESTATE, lY)
#define DIMOFS_Y
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_Z FIELD_OFFSET(DIMOUSESTATE, lZ)
#define DIMOFS_Z
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON0 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 0)
#define DIMOFS_BUTTON0
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON1 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 1)
#define DIMOFS_BUTTON1
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON2 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 2)
#define DIMOFS_BUTTON2
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON3 (FIELD_OFFSET(DIMOUSESTATE, rgbButtons) + 3)
#define DIMOFS_BUTTON3
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if (DIRECTINPUT_VERSION >= 0x0700)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON4 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 4)
#define DIMOFS_BUTTON4
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON5 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 5)
#define DIMOFS_BUTTON5
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON6 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 6)
#define DIMOFS_BUTTON6
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIMOFS_BUTTON7 (FIELD_OFFSET(DIMOUSESTATE2, rgbButtons) + 7)
#define DIMOFS_BUTTON7
#endif
#endif // DIJ_RINGZERO

/****************************************************************************
 *
 *      Keyboard
 *
 ****************************************************************************/

#if ! DIJ_RINGZERO

/****************************************************************************
 *
 *      DirectInput keyboard scan codes
 *
 ****************************************************************************/
#define DIK_ESCAPE
#define DIK_1
#define DIK_2
#define DIK_3
#define DIK_4
#define DIK_5
#define DIK_6
#define DIK_7
#define DIK_8
#define DIK_9
#define DIK_0
#define DIK_MINUS
#define DIK_EQUALS
#define DIK_BACK
#define DIK_TAB
#define DIK_Q
#define DIK_W
#define DIK_E
#define DIK_R
#define DIK_T
#define DIK_Y
#define DIK_U
#define DIK_I
#define DIK_O
#define DIK_P
#define DIK_LBRACKET
#define DIK_RBRACKET
#define DIK_RETURN
#define DIK_LCONTROL
#define DIK_A
#define DIK_S
#define DIK_D
#define DIK_F
#define DIK_G
#define DIK_H
#define DIK_J
#define DIK_K
#define DIK_L
#define DIK_SEMICOLON
#define DIK_APOSTROPHE
#define DIK_GRAVE
#define DIK_LSHIFT
#define DIK_BACKSLASH
#define DIK_Z
#define DIK_X
#define DIK_C
#define DIK_V
#define DIK_B
#define DIK_N
#define DIK_M
#define DIK_COMMA
#define DIK_PERIOD
#define DIK_SLASH
#define DIK_RSHIFT
#define DIK_MULTIPLY
#define DIK_LMENU
#define DIK_SPACE
#define DIK_CAPITAL
#define DIK_F1
#define DIK_F2
#define DIK_F3
#define DIK_F4
#define DIK_F5
#define DIK_F6
#define DIK_F7
#define DIK_F8
#define DIK_F9
#define DIK_F10
#define DIK_NUMLOCK
#define DIK_SCROLL
#define DIK_NUMPAD7
#define DIK_NUMPAD8
#define DIK_NUMPAD9
#define DIK_SUBTRACT
#define DIK_NUMPAD4
#define DIK_NUMPAD5
#define DIK_NUMPAD6
#define DIK_ADD
#define DIK_NUMPAD1
#define DIK_NUMPAD2
#define DIK_NUMPAD3
#define DIK_NUMPAD0
#define DIK_DECIMAL
#define DIK_OEM_102
#define DIK_F11
#define DIK_F12
#define DIK_F13
#define DIK_F14
#define DIK_F15
#define DIK_KANA
#define DIK_ABNT_C1
#define DIK_CONVERT
#define DIK_NOCONVERT
#define DIK_YEN
#define DIK_ABNT_C2
#define DIK_NUMPADEQUALS
#define DIK_PREVTRACK
#define DIK_AT
#define DIK_COLON
#define DIK_UNDERLINE
#define DIK_KANJI
#define DIK_STOP
#define DIK_AX
#define DIK_UNLABELED
#define DIK_NEXTTRACK
#define DIK_NUMPADENTER
#define DIK_RCONTROL
#define DIK_MUTE
#define DIK_CALCULATOR
#define DIK_PLAYPAUSE
#define DIK_MEDIASTOP
#define DIK_VOLUMEDOWN
#define DIK_VOLUMEUP
#define DIK_WEBHOME
#define DIK_NUMPADCOMMA
#define DIK_DIVIDE
#define DIK_SYSRQ
#define DIK_RMENU
#define DIK_PAUSE
#define DIK_HOME
#define DIK_UP
#define DIK_PRIOR
#define DIK_LEFT
#define DIK_RIGHT
#define DIK_END
#define DIK_DOWN
#define DIK_NEXT
#define DIK_INSERT
#define DIK_DELETE
#define DIK_LWIN
#define DIK_RWIN
#define DIK_APPS
#define DIK_POWER
#define DIK_SLEEP
#define DIK_WAKE
#define DIK_WEBSEARCH
#define DIK_WEBFAVORITES
#define DIK_WEBREFRESH
#define DIK_WEBSTOP
#define DIK_WEBFORWARD
#define DIK_WEBBACK
#define DIK_MYCOMPUTER
#define DIK_MAIL
#define DIK_MEDIASELECT

/*
 *  Alternate names for keys, to facilitate transition from DOS.
 */
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_BACKSPACE DIK_BACK
#define DIK_BACKSPACE // backspace
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_NUMPADSTAR DIK_MULTIPLY
#define DIK_NUMPADSTAR // * on numeric keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_LALT DIK_LMENU
#define DIK_LALT // left Alt
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_CAPSLOCK DIK_CAPITAL
#define DIK_CAPSLOCK // CapsLock
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_NUMPADMINUS DIK_SUBTRACT
#define DIK_NUMPADMINUS // - on numeric keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_NUMPADPLUS DIK_ADD
#define DIK_NUMPADPLUS // + on numeric keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_NUMPADPERIOD DIK_DECIMAL
#define DIK_NUMPADPERIOD // . on numeric keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_NUMPADSLASH DIK_DIVIDE
#define DIK_NUMPADSLASH // / on numeric keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_RALT DIK_RMENU
#define DIK_RALT // right Alt
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_UPARROW DIK_UP
#define DIK_UPARROW // UpArrow on arrow keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_PGUP DIK_PRIOR
#define DIK_PGUP // PgUp on arrow keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_LEFTARROW DIK_LEFT
#define DIK_LEFTARROW // LeftArrow on arrow keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_RIGHTARROW DIK_RIGHT
#define DIK_RIGHTARROW // RightArrow on arrow keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_DOWNARROW DIK_DOWN
#define DIK_DOWNARROW // DownArrow on arrow keypad
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_PGDN DIK_NEXT
#define DIK_PGDN // PgDn on arrow keypad

/*
 *  Alternate names for keys originally not used on US keyboards.
 */
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIK_CIRCUMFLEX DIK_PREVTRACK
#define DIK_CIRCUMFLEX // Japanese keyboard

#endif // DIJ_RINGZERO

/****************************************************************************
 *
 *      Joystick
 *
 ****************************************************************************/

#if ! DIJ_RINGZERO

public class DIJOYSTATE
{
    public int lX; // x-axis position
    public int lY; // y-axis position
    public int lZ; // z-axis position
    public int lRx; // x-axis rotation
    public int lRy; // y-axis rotation
    public int lRz; // z-axis rotation
    public int[] rglSlider = new int[2]; // extra axes positions
    public uint[] rgdwPOV = new uint[4]; // POV directions
    public byte[] rgbButtons = new byte[32]; // 32 buttons
}

public class DIJOYSTATE2
{
    public int lX; // x-axis position
    public int lY; // y-axis position
    public int lZ; // z-axis position
    public int lRx; // x-axis rotation
    public int lRy; // y-axis rotation
    public int lRz; // z-axis rotation
    public int[] rglSlider = new int[2]; // extra axes positions
    public uint[] rgdwPOV = new uint[4]; // POV directions
    public byte[] rgbButtons = new byte[128]; // 128 buttons
    public int lVX; // x-axis velocity
    public int lVY; // y-axis velocity
    public int lVZ; // z-axis velocity
    public int lVRx; // x-axis angular velocity
    public int lVRy; // y-axis angular velocity
    public int lVRz; // z-axis angular velocity
    public int[] rglVSlider = new int[2]; // extra axes velocities
    public int lAX; // x-axis acceleration
    public int lAY; // y-axis acceleration
    public int lAZ; // z-axis acceleration
    public int lARx; // x-axis angular acceleration
    public int lARy; // y-axis angular acceleration
    public int lARz; // z-axis angular acceleration
    public int[] rglASlider = new int[2]; // extra axes accelerations
    public int lFX; // x-axis force
    public int lFY; // y-axis force
    public int lFZ; // z-axis force
    public int lFRx; // x-axis torque
    public int lFRy; // y-axis torque
    public int lFRz; // z-axis torque
    public int[] rglFSlider = new int[2]; // extra axes forces
}

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_X FIELD_OFFSET(DIJOYSTATE, lX)
#define DIJOFS_X
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_Y FIELD_OFFSET(DIJOYSTATE, lY)
#define DIJOFS_Y
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_Z FIELD_OFFSET(DIJOYSTATE, lZ)
#define DIJOFS_Z
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_RX FIELD_OFFSET(DIJOYSTATE, lRx)
#define DIJOFS_RX
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_RY FIELD_OFFSET(DIJOYSTATE, lRy)
#define DIJOFS_RY
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_RZ FIELD_OFFSET(DIJOYSTATE, lRz)
#define DIJOFS_RZ
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_SLIDER(n) (FIELD_OFFSET(DIJOYSTATE, rglSlider) + (n) * sizeof(LONG))
#define DIJOFS_SLIDER
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_POV(n) (FIELD_OFFSET(DIJOYSTATE, rgdwPOV) + (n) * sizeof(DWORD))
#define DIJOFS_POV
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON(n) (FIELD_OFFSET(DIJOYSTATE, rgbButtons) + (n))
#define DIJOFS_BUTTON
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON0 DIJOFS_BUTTON(0)
#define DIJOFS_BUTTON0
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON1 DIJOFS_BUTTON(1)
#define DIJOFS_BUTTON1
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON2 DIJOFS_BUTTON(2)
#define DIJOFS_BUTTON2
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON3 DIJOFS_BUTTON(3)
#define DIJOFS_BUTTON3
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON4 DIJOFS_BUTTON(4)
#define DIJOFS_BUTTON4
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON5 DIJOFS_BUTTON(5)
#define DIJOFS_BUTTON5
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON6 DIJOFS_BUTTON(6)
#define DIJOFS_BUTTON6
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON7 DIJOFS_BUTTON(7)
#define DIJOFS_BUTTON7
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON8 DIJOFS_BUTTON(8)
#define DIJOFS_BUTTON8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON9 DIJOFS_BUTTON(9)
#define DIJOFS_BUTTON9
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON10 DIJOFS_BUTTON(10)
#define DIJOFS_BUTTON10
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON11 DIJOFS_BUTTON(11)
#define DIJOFS_BUTTON11
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON12 DIJOFS_BUTTON(12)
#define DIJOFS_BUTTON12
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON13 DIJOFS_BUTTON(13)
#define DIJOFS_BUTTON13
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON14 DIJOFS_BUTTON(14)
#define DIJOFS_BUTTON14
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON15 DIJOFS_BUTTON(15)
#define DIJOFS_BUTTON15
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON16 DIJOFS_BUTTON(16)
#define DIJOFS_BUTTON16
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON17 DIJOFS_BUTTON(17)
#define DIJOFS_BUTTON17
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON18 DIJOFS_BUTTON(18)
#define DIJOFS_BUTTON18
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON19 DIJOFS_BUTTON(19)
#define DIJOFS_BUTTON19
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON20 DIJOFS_BUTTON(20)
#define DIJOFS_BUTTON20
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON21 DIJOFS_BUTTON(21)
#define DIJOFS_BUTTON21
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON22 DIJOFS_BUTTON(22)
#define DIJOFS_BUTTON22
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON23 DIJOFS_BUTTON(23)
#define DIJOFS_BUTTON23
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON24 DIJOFS_BUTTON(24)
#define DIJOFS_BUTTON24
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON25 DIJOFS_BUTTON(25)
#define DIJOFS_BUTTON25
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON26 DIJOFS_BUTTON(26)
#define DIJOFS_BUTTON26
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON27 DIJOFS_BUTTON(27)
#define DIJOFS_BUTTON27
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON28 DIJOFS_BUTTON(28)
#define DIJOFS_BUTTON28
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON29 DIJOFS_BUTTON(29)
#define DIJOFS_BUTTON29
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON30 DIJOFS_BUTTON(30)
#define DIJOFS_BUTTON30
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIJOFS_BUTTON31 DIJOFS_BUTTON(31)
#define DIJOFS_BUTTON31


#endif // DIJ_RINGZERO

/****************************************************************************
 *
 *  IDirectInput
 *
 ****************************************************************************/

#if ! DIJ_RINGZERO

#define DIENUM_STOP
#define DIENUM_CONTINUE

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMDEVICESCALLBACKA)(const DIDEVICEINSTANCEA *, object*);
public delegate bool LPDIENUMDEVICESCALLBACKA(DIDEVICEINSTANCEA UnnamedParameter, object UnnamedParameter2);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMDEVICESCALLBACKW)(const DIDEVICEINSTANCEW *, object*);
public delegate bool LPDIENUMDEVICESCALLBACKW(DIDEVICEINSTANCEW UnnamedParameter, object UnnamedParameter2);
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMDEVICESCALLBACK LPDIENUMDEVICESCALLBACKW
#define LPDIENUMDEVICESCALLBACK
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMDEVICESCALLBACK LPDIENUMDEVICESCALLBACKA
#define LPDIENUMDEVICESCALLBACK
#endif // !UNICODE
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDICONFIGUREDEVICESCALLBACK)(IUnknown FAR *, object*);
public delegate bool LPDICONFIGUREDEVICESCALLBACK(IUnknown UnnamedParameter, object UnnamedParameter2);

#define DIEDFL_ALLDEVICES
#define DIEDFL_ATTACHEDONLY
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0500)
#define DIEDFL_FORCEFEEDBACK
#endif // DIRECTINPUT_VERSION >= 0x0500
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x050a)
#define DIEDFL_INCLUDEALIASES
#define DIEDFL_INCLUDEPHANTOMS
#endif // DIRECTINPUT_VERSION >= 0x050a
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
#endif // DIRECTINPUT_VERSION >= 0x0800


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMDEVICESBYSEMANTICSCBA)(const DIDEVICEINSTANCEA *, struct IDirectInputDevice8A *, uint, uint, object*);
public delegate bool LPDIENUMDEVICESBYSEMANTICSCBA(DIDEVICEINSTANCEA UnnamedParameter, IDirectInputDevice8A UnnamedParameter2, uint UnnamedParameter3, uint UnnamedParameter4, object UnnamedParameter5);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDIENUMDEVICESBYSEMANTICSCBW)(const DIDEVICEINSTANCEW *, struct IDirectInputDevice8W *, uint, uint, object*);
public delegate bool LPDIENUMDEVICESBYSEMANTICSCBW(DIDEVICEINSTANCEW UnnamedParameter, IDirectInputDevice8W UnnamedParameter2, uint UnnamedParameter3, uint UnnamedParameter4, object UnnamedParameter5);
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMDEVICESBYSEMANTICSCB LPDIENUMDEVICESBYSEMANTICSCBW
#define LPDIENUMDEVICESBYSEMANTICSCB
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPDIENUMDEVICESBYSEMANTICSCB LPDIENUMDEVICESBYSEMANTICSCBA
#define LPDIENUMDEVICESBYSEMANTICSCB
#endif // !UNICODE
#endif // DIRECTINPUT_VERSION >= 0x0800

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
#endif // DIRECTINPUT_VERSION >= 0x0800

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if(DIRECTINPUT_VERSION >= 0x0800)
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DIEDBSFL_FORCEFEEDBACK DIEDFL_FORCEFEEDBACK
#endif // DIRECTINPUT_VERSION >= 0x0800