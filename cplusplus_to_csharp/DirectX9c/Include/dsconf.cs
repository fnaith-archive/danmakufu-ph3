/*==========================================================================;
 *
 *  Copyright (c) Microsoft Corporation.  All rights reserved.
 *
 *  File:       dsconf.h
 *  Content:    DirectSound configuration interface include file
 *
 **************************************************************************/


#if ! __DSOUND_INCLUDED__
#error dsound.h not included
#endif // __DSOUND_INCLUDED__

#if __cplusplus
#endif // __cplusplus


// DirectSound Private Component GUID {11AB3EC0-25EC-11d1-A4D8-00C04FC28ACA}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectSoundPrivate, 0x11ab3ec0, 0x25ec, 0x11d1, 0xa4, 0xd8, 0x0, 0xc0, 0x4f, 0xc2, 0x8a, 0xca);


// 
// DirectSound Device Properties {84624F82-25EC-11d1-A4D8-00C04FC28ACA}
// 

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DSPROPSETID_DirectSoundDevice, 0x84624f82, 0x25ec, 0x11d1, 0xa4, 0xd8, 0x0, 0xc0, 0x4f, 0xc2, 0x8a, 0xca);

public enum DSPROPERTY_DIRECTSOUNDDEVICE
{
    DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A = 1,
    DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1 = 2,
    DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_1 = 3,
    DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_W = 4,
    DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A = 5,
    DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W = 6,
    DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_A = 7,
    DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_W = 8
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0700
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_W
#define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W
#define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_W
#define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE
#else // UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A
#define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A
#define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_A
#define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE
#endif // UNICODE
#else // DIRECTSOUND_VERSION >= 0x0700
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A
#define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1
#define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_1
#define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE
#endif // DIRECTSOUND_VERSION >= 0x0700

public enum DIRECTSOUNDDEVICE_TYPE
{
    DIRECTSOUNDDEVICE_TYPE_EMULATED,
    DIRECTSOUNDDEVICE_TYPE_VXD,
    DIRECTSOUNDDEVICE_TYPE_WDM
}

public enum DIRECTSOUNDDEVICE_DATAFLOW
{
    DIRECTSOUNDDEVICE_DATAFLOW_RENDER,
    DIRECTSOUNDDEVICE_DATAFLOW_CAPTURE
}


public class _DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A_DATA
{
    public string DeviceName; // waveIn/waveOut device name
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow; // Data flow (i.e. waveIn or waveOut)
    public GUID DeviceId = new GUID(); // DirectSound device id
}

public class _DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_W_DATA
{
    public string DeviceName; // waveIn/waveOut device name
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow; // Data flow (i.e. waveIn or waveOut)
    public GUID DeviceId = new GUID(); // DirectSound device id
}

#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_W_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_W_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA
#else // UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_A_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_WAVEDEVICEMAPPING_DATA
#endif // UNICODE

public class _DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA
{
    public GUID DeviceId = new GUID(); // DirectSound device id
    public string DescriptionA = new string(new char[0x100]); // Device description (ANSI)
    public string DescriptionW = new string(new char[0x100]); // Device description (Unicode)
    public string ModuleA = new string(new char[MAX_PATH]); // Device driver module (ANSI)
    public string ModuleW = new string(new char[MAX_PATH]); // Device driver module (Unicode)
    public DIRECTSOUNDDEVICE_TYPE Type; // Device type
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow; // Device dataflow
    public uint WaveDeviceId; // Wave device id
    public uint Devnode; // Devnode (or DevInst)
}

public class _DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A_DATA
{
    public DIRECTSOUNDDEVICE_TYPE Type; // Device type
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow; // Device dataflow
    public GUID DeviceId = new GUID(); // DirectSound device id
    public string Description; // Device description
    public string Module; // Device driver module
    public string Interface; // Device interface
    public uint WaveDeviceId; // Wave device id
}

public class _DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W_DATA
{
    public DIRECTSOUNDDEVICE_TYPE Type; // Device type
    public DIRECTSOUNDDEVICE_DATAFLOW DataFlow; // Device dataflow
    public GUID DeviceId = new GUID(); // DirectSound device id
    public string Description; // Device description
    public string Module; // Device driver module
    public string Interface; // Device interface
    public uint WaveDeviceId; // Wave device id
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0700
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA
#else // UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA
#endif // UNICODE
#else // DIRECTSOUND_VERSION >= 0x0700
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_DATA
#endif // DIRECTSOUND_VERSION >= 0x0700

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(CALLBACK *LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1)(_DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA *, object*);
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1(_DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_1_DATA UnnamedParameter, object UnnamedParameter2);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(CALLBACK *LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKA)(_DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A_DATA *, object*);
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKA(_DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_A_DATA UnnamedParameter, object UnnamedParameter2);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(CALLBACK *LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKW)(_DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W_DATA *, object*);
public delegate bool LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKW(_DSPROPERTY_DIRECTSOUNDDEVICE_DESCRIPTION_W_DATA UnnamedParameter, object UnnamedParameter2);

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0700
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKW
#define LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK
#else // UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKA
#define LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK
#endif // UNICODE
#else // DIRECTSOUND_VERSION >= 0x0700
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1
#define LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK
#endif // DIRECTSOUND_VERSION >= 0x0700

public class _DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_1_DATA
{
    public LPFNDIRECTSOUNDDEVICEENUMERATECALLBACK1 Callback; // Callback function pointer
    public object Context; // Callback function context argument
}

public class _DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_A_DATA
{
    public LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKA Callback; // Callback function pointer
    public object Context; // Callback function context argument
}

public class _DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_W_DATA
{
    public LPFNDIRECTSOUNDDEVICEENUMERATECALLBACKW Callback; // Callback function pointer
    public object Context; // Callback function context argument
}

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0700
#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_W_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_W_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA
#else // UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_A_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_A_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA
#endif // UNICODE
#else // DIRECTSOUND_VERSION >= 0x0700
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_1_DATA
#define DSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_1_DATA
#define PDSPROPERTY_DIRECTSOUNDDEVICE_ENUMERATE_DATA
#endif // DIRECTSOUND_VERSION >= 0x0700


#if __cplusplus
#endif // __cplusplus


