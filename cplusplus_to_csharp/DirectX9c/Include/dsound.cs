#define DIRECTSOUND_VERSION

using System;

/*==========================================================================;
 *
 *  Copyright (c) Microsoft Corporation.  All rights reserved.
 *
 *  File:       dsound.h
 *  Content:    DirectSound include file
 *
 **************************************************************************/

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>


#if __cplusplus
#endif // __cplusplus


/* Type definitions shared with Direct3D */

#if ! DX_SHARED_DEFINES


#if ! D3DCOLOR_DEFINED
#define D3DCOLOR_DEFINED
#endif

#if ! LPD3DCOLOR_DEFINED
#define LPD3DCOLOR_DEFINED
#endif

#if ! D3DVECTOR_DEFINED
public class _D3DVECTOR
{
    public float x;
    public float y;
    public float z;
}
#define D3DVECTOR_DEFINED
#endif

#if ! LPD3DVECTOR_DEFINED
#define LPD3DVECTOR_DEFINED
#endif

#define DX_SHARED_DEFINES
#endif // DX_SHARED_DEFINES

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DSHRESULT(code) MAKE_HRESULT(1, _FACDS, code)

// DirectSound Component GUID {47D4D946-62E8-11CF-93BC-444553540000}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectSound, 0x47d4d946, 0x62e8, 0x11cf, 0x93, 0xbc, 0x44, 0x45, 0x53, 0x54, 0x0, 0x0);

// DirectSound 8.0 Component GUID {3901CC3F-84B5-4FA4-BA35-AA8172B8A09B}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectSound8, 0x3901cc3f, 0x84b5, 0x4fa4, 0xba, 0x35, 0xaa, 0x81, 0x72, 0xb8, 0xa0, 0x9b);

// DirectSound Capture Component GUID {B0210780-89CD-11D0-AF08-00A0C925CD16}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectSoundCapture, 0xb0210780, 0x89cd, 0x11d0, 0xaf, 0x8, 0x0, 0xa0, 0xc9, 0x25, 0xcd, 0x16);

// DirectSound 8.0 Capture Component GUID {E4BCAC13-7F99-4908-9A8E-74E3BF24B6E1}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectSoundCapture8, 0xe4bcac13, 0x7f99, 0x4908, 0x9a, 0x8e, 0x74, 0xe3, 0xbf, 0x24, 0xb6, 0xe1);

// DirectSound Full Duplex Component GUID {FEA4300C-7959-4147-B26A-2377B9E7A91D}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectSoundFullDuplex, 0xfea4300c, 0x7959, 0x4147, 0xb2, 0x6a, 0x23, 0x77, 0xb9, 0xe7, 0xa9, 0x1d);


// DirectSound default playback device GUID {DEF00000-9C6D-47ED-AAF1-4DDA8F2B5C03}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DSDEVID_DefaultPlayback, 0xdef00000, 0x9c6d, 0x47ed, 0xaa, 0xf1, 0x4d, 0xda, 0x8f, 0x2b, 0x5c, 0x03);

// DirectSound default capture device GUID {DEF00001-9C6D-47ED-AAF1-4DDA8F2B5C03}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DSDEVID_DefaultCapture, 0xdef00001, 0x9c6d, 0x47ed, 0xaa, 0xf1, 0x4d, 0xda, 0x8f, 0x2b, 0x5c, 0x03);

// DirectSound default device for voice playback {DEF00002-9C6D-47ED-AAF1-4DDA8F2B5C03}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DSDEVID_DefaultVoicePlayback, 0xdef00002, 0x9c6d, 0x47ed, 0xaa, 0xf1, 0x4d, 0xda, 0x8f, 0x2b, 0x5c, 0x03);

// DirectSound default device for voice capture {DEF00003-9C6D-47ED-AAF1-4DDA8F2B5C03}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DSDEVID_DefaultVoiceCapture, 0xdef00003, 0x9c6d, 0x47ed, 0xaa, 0xf1, 0x4d, 0xda, 0x8f, 0x2b, 0x5c, 0x03);


// 
// Forward declarations for interfaces.
// 'struct' not 'class' per the way DECLARE_INTERFACE_ is defined
// 

#if __cplusplus
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSound;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundBuffer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSound3DListener;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSound3DBuffer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundCapture;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundCaptureBuffer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundNotify;
#endif // __cplusplus


// 
// DirectSound 8.0 interfaces.
// 

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800

#if __cplusplus
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSound8;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundBuffer8;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundCaptureBuffer8;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXGargle;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXChorus;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXFlanger;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXEcho;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXDistortion;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXCompressor;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXParamEq;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXWavesReverb;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFXI3DL2Reverb;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundCaptureFXAec;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundCaptureFXNoiseSuppress;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
// struct IDirectSoundFullDuplex;
#endif // __cplusplus

// IDirectSound8, IDirectSoundBuffer8 and IDirectSoundCaptureBuffer8 are the
// only DirectSound 7.0 interfaces with changed functionality in version 8.0.
// The other level 8 interfaces as equivalent to their level 7 counterparts:

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundCapture8 IDirectSoundCapture
#define IDirectSoundCapture8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSound3DListener8 IDirectSound3DListener
#define IDirectSound3DListener8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSound3DBuffer8 IDirectSound3DBuffer
#define IDirectSound3DBuffer8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundNotify8 IDirectSoundNotify
#define IDirectSoundNotify8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXGargle8 IDirectSoundFXGargle
#define IDirectSoundFXGargle8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXChorus8 IDirectSoundFXChorus
#define IDirectSoundFXChorus8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXFlanger8 IDirectSoundFXFlanger
#define IDirectSoundFXFlanger8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXEcho8 IDirectSoundFXEcho
#define IDirectSoundFXEcho8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXDistortion8 IDirectSoundFXDistortion
#define IDirectSoundFXDistortion8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXCompressor8 IDirectSoundFXCompressor
#define IDirectSoundFXCompressor8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXParamEq8 IDirectSoundFXParamEq
#define IDirectSoundFXParamEq8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXWavesReverb8 IDirectSoundFXWavesReverb
#define IDirectSoundFXWavesReverb8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFXI3DL2Reverb8 IDirectSoundFXI3DL2Reverb
#define IDirectSoundFXI3DL2Reverb8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundCaptureFXAec8 IDirectSoundCaptureFXAec
#define IDirectSoundCaptureFXAec8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundCaptureFXNoiseSuppress8 IDirectSoundCaptureFXNoiseSuppress
#define IDirectSoundCaptureFXNoiseSuppress8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IDirectSoundFullDuplex8 IDirectSoundFullDuplex
#define IDirectSoundFullDuplex8

#endif // DIRECTSOUND_VERSION >= 0x0800



// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800



#endif // DIRECTSOUND_VERSION >= 0x0800

// 
// IID definitions for the unchanged DirectSound 8.0 interfaces
// 

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundCapture8 IID_IDirectSoundCapture
#define IID_IDirectSoundCapture8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSound3DListener8 IID_IDirectSound3DListener
#define IID_IDirectSound3DListener8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSound3DBuffer8 IID_IDirectSound3DBuffer
#define IID_IDirectSound3DBuffer8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundNotify8 IID_IDirectSoundNotify
#define IID_IDirectSoundNotify8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXGargle8 IID_IDirectSoundFXGargle
#define IID_IDirectSoundFXGargle8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXChorus8 IID_IDirectSoundFXChorus
#define IID_IDirectSoundFXChorus8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXFlanger8 IID_IDirectSoundFXFlanger
#define IID_IDirectSoundFXFlanger8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXEcho8 IID_IDirectSoundFXEcho
#define IID_IDirectSoundFXEcho8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXDistortion8 IID_IDirectSoundFXDistortion
#define IID_IDirectSoundFXDistortion8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXCompressor8 IID_IDirectSoundFXCompressor
#define IID_IDirectSoundFXCompressor8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXParamEq8 IID_IDirectSoundFXParamEq
#define IID_IDirectSoundFXParamEq8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXWavesReverb8 IID_IDirectSoundFXWavesReverb
#define IID_IDirectSoundFXWavesReverb8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFXI3DL2Reverb8 IID_IDirectSoundFXI3DL2Reverb
#define IID_IDirectSoundFXI3DL2Reverb8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundCaptureFXAec8 IID_IDirectSoundCaptureFXAec
#define IID_IDirectSoundCaptureFXAec8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundCaptureFXNoiseSuppress8 IID_IDirectSoundCaptureFXNoiseSuppress
#define IID_IDirectSoundCaptureFXNoiseSuppress8
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectSoundFullDuplex8 IID_IDirectSoundFullDuplex
#define IID_IDirectSoundFullDuplex8

#endif // DIRECTSOUND_VERSION >= 0x0800

// 
// Compatibility typedefs
// 




// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800
#endif // DIRECTSOUND_VERSION >= 0x0800

// 
// Structures
// 

public class _DSCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwMinSecondarySampleRate;
    public uint dwMaxSecondarySampleRate;
    public uint dwPrimaryBuffers;
    public uint dwMaxHwMixingAllBuffers;
    public uint dwMaxHwMixingStaticBuffers;
    public uint dwMaxHwMixingStreamingBuffers;
    public uint dwFreeHwMixingAllBuffers;
    public uint dwFreeHwMixingStaticBuffers;
    public uint dwFreeHwMixingStreamingBuffers;
    public uint dwMaxHw3DAllBuffers;
    public uint dwMaxHw3DStaticBuffers;
    public uint dwMaxHw3DStreamingBuffers;
    public uint dwFreeHw3DAllBuffers;
    public uint dwFreeHw3DStaticBuffers;
    public uint dwFreeHw3DStreamingBuffers;
    public uint dwTotalHwMemBytes;
    public uint dwFreeHwMemBytes;
    public uint dwMaxContigFreeHwMemBytes;
    public uint dwUnlockTransferRateHwBuffers;
    public uint dwPlayCpuOverheadSwBuffers;
    public uint dwReserved1;
    public uint dwReserved2;
}


public class _DSBCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwUnlockTransferRate;
    public uint dwPlayCpuOverhead;
}


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800

    public class _DSEFFECTDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public GUID guidDSFXClass = new GUID();
        public IntPtr dwReserved1;
        public IntPtr dwReserved2;
    }

    #define DSFX_LOCHARDWARE
    #define DSFX_LOCSOFTWARE

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
    public enum AnonymousEnum
    {
        DSFXR_PRESENT, // 0
        DSFXR_LOCHARDWARE, // 1
        DSFXR_LOCSOFTWARE, // 2
        DSFXR_UNALLOCATED, // 3
        DSFXR_FAILED, // 4
        DSFXR_UNKNOWN, // 5
        DSFXR_SENDLOOP // 6
    }

    public class _DSCEFFECTDESC
    {
        public uint dwSize;
        public uint dwFlags;
        public GUID guidDSCFXClass = new GUID();
        public GUID guidDSCFXInstance = new GUID();
        public uint dwReserved1;
        public uint dwReserved2;
    }

    #define DSCFX_LOCHARDWARE
    #define DSCFX_LOCSOFTWARE

    #define DSCFXR_LOCHARDWARE
    #define DSCFXR_LOCSOFTWARE

#endif // DIRECTSOUND_VERSION >= 0x0800

public class _DSBUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public LPWAVEFORMATEX lpwfxFormat = new LPWAVEFORMATEX();
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0700
    public GUID guid3DAlgorithm = new GUID();
#endif
}


// Older version of this structure:

public class _DSBUFFERDESC1
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public LPWAVEFORMATEX lpwfxFormat = new LPWAVEFORMATEX();
}


public class _DS3DBUFFER
{
    public uint dwSize;
    public _D3DVECTOR vPosition = new _D3DVECTOR();
    public _D3DVECTOR vVelocity = new _D3DVECTOR();
    public uint dwInsideConeAngle;
    public uint dwOutsideConeAngle;
    public _D3DVECTOR vConeOrientation = new _D3DVECTOR();
    public int lConeOutsideVolume;
    public float flMinDistance;
    public float flMaxDistance;
    public uint dwMode;
}


public class _DS3DLISTENER
{
    public uint dwSize;
    public _D3DVECTOR vPosition = new _D3DVECTOR();
    public _D3DVECTOR vVelocity = new _D3DVECTOR();
    public _D3DVECTOR vOrientFront = new _D3DVECTOR();
    public _D3DVECTOR vOrientTop = new _D3DVECTOR();
    public float flDistanceFactor;
    public float flRolloffFactor;
    public float flDopplerFactor;
}


public class _DSCCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwFormats;
    public uint dwChannels;
}


public class _DSCBUFFERDESC1
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public LPWAVEFORMATEX lpwfxFormat = new LPWAVEFORMATEX();
}

public class _DSCBUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
    public LPWAVEFORMATEX lpwfxFormat = new LPWAVEFORMATEX();
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800
    public uint dwFXCount;
    public _DSCEFFECTDESC lpDSCFXDesc;
#endif
}


public class _DSCBCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public uint dwBufferBytes;
    public uint dwReserved;
}


public class _DSBPOSITIONNOTIFY
{
    public uint dwOffset;
    public IntPtr hEventNotify;
}


// 
// DirectSound API
// 

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(CALLBACK *LPDSENUMCALLBACKA)(LPGUID, const char*, const char*, object*);
public delegate bool LPDSENUMCALLBACKA(LPGUID UnnamedParameter, string UnnamedParameter2, string UnnamedParameter3, object UnnamedParameter4);
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(CALLBACK *LPDSENUMCALLBACKW)(LPGUID, const char*, const char*, object*);
public delegate bool LPDSENUMCALLBACKW(LPGUID UnnamedParameter, string UnnamedParameter2, string UnnamedParameter3, object UnnamedParameter4);

public class _DSFXGargle
{
    public uint dwRateHz; // Rate of modulation in hz
    public uint dwWaveShape; // DSFXGARGLE_WAVE_xxx
}

public class _DSFXChorus
{
    public float fWetDryMix;
    public float fDepth;
    public float fFeedback;
    public float fFrequency;
    public int lWaveform; // LFO shape; DSFXCHORUS_WAVE_xxx
    public float fDelay;
    public int lPhase;
}

public class _DSFXFlanger
{
    public float fWetDryMix;
    public float fDepth;
    public float fFeedback;
    public float fFrequency;
    public int lWaveform;
    public float fDelay;
    public int lPhase;
}

public class _DSFXEcho
{
    public float fWetDryMix;
    public float fFeedback;
    public float fLeftDelay;
    public float fRightDelay;
    public int lPanDelay;
}

public class _DSFXDistortion
{
    public float fGain;
    public float fEdge;
    public float fPostEQCenterFrequency;
    public float fPostEQBandwidth;
    public float fPreLowpassCutoff;
}

public class _DSFXCompressor
{
    public float fGain;
    public float fAttack;
    public float fRelease;
    public float fThreshold;
    public float fRatio;
    public float fPredelay;
}

public class _DSFXParamEq
{
    public float fCenter;
    public float fBandwidth;
    public float fGain;
}

public class _DSFXI3DL2Reverb
{
    public int lRoom; // [-10000, 0]      default: -1000 mB
    public int lRoomHF; // [-10000, 0]      default: 0 mB
    public float flRoomRolloffFactor; // [0.0, 10.0]      default: 0.0
    public float flDecayTime; // [0.1, 20.0]      default: 1.49s
    public float flDecayHFRatio; // [0.1, 2.0]       default: 0.83
    public int lReflections; // [-10000, 1000]   default: -2602 mB
    public float flReflectionsDelay; // [0.0, 0.3]       default: 0.007 s
    public int lReverb; // [-10000, 2000]   default: 200 mB
    public float flReverbDelay; // [0.0, 0.1]       default: 0.011 s
    public float flDiffusion; // [0.0, 100.0]     default: 100.0 %
    public float flDensity; // [0.0, 100.0]     default: 100.0 %
    public float flHFReference; // [20.0, 20000.0]  default: 5000.0 Hz
}

public class _DSFXWavesReverb
{
    public float fInGain; // [-96.0,0.0]            default: 0.0 dB
    public float fReverbMix; // [-96.0,0.0]            default: 0.0 db
    public float fReverbTime; // [0.001,3000.0]         default: 1000.0 ms
    public float fHighFreqRTRatio; // [0.001,0.999]          default: 0.001
}

public class _DSCFXAec
{
    public bool fEnable;
    public bool fNoiseFill;
    public uint dwMode;
}

public class _DSCFXNoiseSuppress
{
    public bool fEnable;
}








// 
// Flags for the I3DL2 effects
// 

// 
// I3DL2 Material Presets
// 

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
public enum AnonymousEnum2
{
    DSFX_I3DL2_MATERIAL_PRESET_SINGLEWINDOW,
    DSFX_I3DL2_MATERIAL_PRESET_DOUBLEWINDOW,
    DSFX_I3DL2_MATERIAL_PRESET_THINDOOR,
    DSFX_I3DL2_MATERIAL_PRESET_THICKDOOR,
    DSFX_I3DL2_MATERIAL_PRESET_WOODWALL,
    DSFX_I3DL2_MATERIAL_PRESET_BRICKWALL,
    DSFX_I3DL2_MATERIAL_PRESET_STONEWALL,
    DSFX_I3DL2_MATERIAL_PRESET_CURTAIN
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_SINGLEWINDOW -2800,0.71f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_DOUBLEWINDOW -5000,0.40f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_THINDOOR -1800,0.66f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_THICKDOOR -4400,0.64f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_WOODWALL -4000,0.50f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_BRICKWALL -5000,0.60f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_STONEWALL -6000,0.68f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_MATERIAL_PRESET_CURTAIN -1200,0.15f

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
public enum AnonymousEnum3
{
    DSFX_I3DL2_ENVIRONMENT_PRESET_DEFAULT,
    DSFX_I3DL2_ENVIRONMENT_PRESET_GENERIC,
    DSFX_I3DL2_ENVIRONMENT_PRESET_PADDEDCELL,
    DSFX_I3DL2_ENVIRONMENT_PRESET_ROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_BATHROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_LIVINGROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_STONEROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_AUDITORIUM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_CONCERTHALL,
    DSFX_I3DL2_ENVIRONMENT_PRESET_CAVE,
    DSFX_I3DL2_ENVIRONMENT_PRESET_ARENA,
    DSFX_I3DL2_ENVIRONMENT_PRESET_HANGAR,
    DSFX_I3DL2_ENVIRONMENT_PRESET_CARPETEDHALLWAY,
    DSFX_I3DL2_ENVIRONMENT_PRESET_HALLWAY,
    DSFX_I3DL2_ENVIRONMENT_PRESET_STONECORRIDOR,
    DSFX_I3DL2_ENVIRONMENT_PRESET_ALLEY,
    DSFX_I3DL2_ENVIRONMENT_PRESET_FOREST,
    DSFX_I3DL2_ENVIRONMENT_PRESET_CITY,
    DSFX_I3DL2_ENVIRONMENT_PRESET_MOUNTAINS,
    DSFX_I3DL2_ENVIRONMENT_PRESET_QUARRY,
    DSFX_I3DL2_ENVIRONMENT_PRESET_PLAIN,
    DSFX_I3DL2_ENVIRONMENT_PRESET_PARKINGLOT,
    DSFX_I3DL2_ENVIRONMENT_PRESET_SEWERPIPE,
    DSFX_I3DL2_ENVIRONMENT_PRESET_UNDERWATER,
    DSFX_I3DL2_ENVIRONMENT_PRESET_SMALLROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_MEDIUMROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_LARGEROOM,
    DSFX_I3DL2_ENVIRONMENT_PRESET_MEDIUMHALL,
    DSFX_I3DL2_ENVIRONMENT_PRESET_LARGEHALL,
    DSFX_I3DL2_ENVIRONMENT_PRESET_PLATE
}

// 
// I3DL2 Reverberation Presets Values
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_DEFAULT -1000, -100, 0.0f, 1.49f, 0.83f, -2602, 0.007f, 200, 0.011f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_GENERIC -1000, -100, 0.0f, 1.49f, 0.83f, -2602, 0.007f, 200, 0.011f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_PADDEDCELL -1000,-6000, 0.0f, 0.17f, 0.10f, -1204, 0.001f, 207, 0.002f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_ROOM -1000, -454, 0.0f, 0.40f, 0.83f, -1646, 0.002f, 53, 0.003f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_BATHROOM -1000,-1200, 0.0f, 1.49f, 0.54f, -370, 0.007f, 1030, 0.011f, 100.0f, 60.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_LIVINGROOM -1000,-6000, 0.0f, 0.50f, 0.10f, -1376, 0.003f, -1104, 0.004f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_STONEROOM -1000, -300, 0.0f, 2.31f, 0.64f, -711, 0.012f, 83, 0.017f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_AUDITORIUM -1000, -476, 0.0f, 4.32f, 0.59f, -789, 0.020f, -289, 0.030f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_CONCERTHALL -1000, -500, 0.0f, 3.92f, 0.70f, -1230, 0.020f, -2, 0.029f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_CAVE -1000, 0, 0.0f, 2.91f, 1.30f, -602, 0.015f, -302, 0.022f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_ARENA -1000, -698, 0.0f, 7.24f, 0.33f, -1166, 0.020f, 16, 0.030f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_HANGAR -1000,-1000, 0.0f,10.05f, 0.23f, -602, 0.020f, 198, 0.030f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_CARPETEDHALLWAY -1000,-4000, 0.0f, 0.30f, 0.10f, -1831, 0.002f, -1630, 0.030f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_HALLWAY -1000, -300, 0.0f, 1.49f, 0.59f, -1219, 0.007f, 441, 0.011f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_STONECORRIDOR -1000, -237, 0.0f, 2.70f, 0.79f, -1214, 0.013f, 395, 0.020f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_ALLEY -1000, -270, 0.0f, 1.49f, 0.86f, -1204, 0.007f, -4, 0.011f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_FOREST -1000,-3300, 0.0f, 1.49f, 0.54f, -2560, 0.162f, -613, 0.088f, 79.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_CITY -1000, -800, 0.0f, 1.49f, 0.67f, -2273, 0.007f, -2217, 0.011f, 50.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_MOUNTAINS -1000,-2500, 0.0f, 1.49f, 0.21f, -2780, 0.300f, -2014, 0.100f, 27.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_QUARRY -1000,-1000, 0.0f, 1.49f, 0.83f,-10000, 0.061f, 500, 0.025f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_PLAIN -1000,-2000, 0.0f, 1.49f, 0.50f, -2466, 0.179f, -2514, 0.100f, 21.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_PARKINGLOT -1000, 0, 0.0f, 1.65f, 1.50f, -1363, 0.008f, -1153, 0.012f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_SEWERPIPE -1000,-1000, 0.0f, 2.81f, 0.14f, 429, 0.014f, 648, 0.021f, 80.0f, 60.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_UNDERWATER -1000,-4000, 0.0f, 1.49f, 0.10f, -449, 0.007f, 1700, 0.011f, 100.0f, 100.0f, 5000.0f

// 
// Examples simulating 'musical' reverb presets
// 
// Name       Decay time   Description
// Small Room    1.1s      A small size room with a length of 5m or so.
// Medium Room   1.3s      A medium size room with a length of 10m or so.
// Large Room    1.5s      A large size room suitable for live performances.
// Medium Hall   1.8s      A medium size concert hall.
// Large Hall    1.8s      A large size concert hall suitable for a full orchestra.
// Plate         1.3s      A plate reverb simulation.
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_SMALLROOM -1000, -600, 0.0f, 1.10f, 0.83f, -400, 0.005f, 500, 0.010f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_MEDIUMROOM -1000, -600, 0.0f, 1.30f, 0.83f, -1000, 0.010f, -200, 0.020f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_LARGEROOM -1000, -600, 0.0f, 1.50f, 0.83f, -1600, 0.020f, -1000, 0.040f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_MEDIUMHALL -1000, -600, 0.0f, 1.80f, 0.70f, -1300, 0.015f, -800, 0.030f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_LARGEHALL -1000, -600, 0.0f, 1.80f, 0.70f, -2000, 0.030f, -1400, 0.060f, 100.0f, 100.0f, 5000.0f
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define I3DL2_ENVIRONMENT_PRESET_PLATE -1000, -200, 0.0f, 1.30f, 0.90f, 0, 0.002f, 0, 0.010f, 100.0f, 75.0f, 5000.0f

// 
// DirectSound3D Algorithms
// 

// Default DirectSound3D algorithm {00000000-0000-0000-0000-000000000000}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DS3DALG_DEFAULT GUID_NULL

// No virtualization (Pan3D) {C241333F-1C1B-11d2-94F5-00C04FC28ACA}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DS3DALG_NO_VIRTUALIZATION, 0xc241333f, 0x1c1b, 0x11d2, 0x94, 0xf5, 0x0, 0xc0, 0x4f, 0xc2, 0x8a, 0xca);

// High-quality HRTF algorithm {C2413340-1C1B-11d2-94F5-00C04FC28ACA}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DS3DALG_HRTF_FULL, 0xc2413340, 0x1c1b, 0x11d2, 0x94, 0xf5, 0x0, 0xc0, 0x4f, 0xc2, 0x8a, 0xca);

// Lower-quality HRTF algorithm {C2413342-1C1B-11d2-94F5-00C04FC28ACA}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DS3DALG_HRTF_LIGHT, 0xc2413342, 0x1c1b, 0x11d2, 0x94, 0xf5, 0x0, 0xc0, 0x4f, 0xc2, 0x8a, 0xca);


// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if DIRECTSOUND_VERSION >= 0x0800

// 
// DirectSound Internal Effect Algorithms
// 


// Gargle {DAFD8210-5711-4B91-9FE3-F75B7AE279BF}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_GARGLE, 0xdafd8210, 0x5711, 0x4b91, 0x9f, 0xe3, 0xf7, 0x5b, 0x7a, 0xe2, 0x79, 0xbf);

// Chorus {EFE6629C-81F7-4281-BD91-C9D604A95AF6}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_CHORUS, 0xefe6629c, 0x81f7, 0x4281, 0xbd, 0x91, 0xc9, 0xd6, 0x04, 0xa9, 0x5a, 0xf6);

// Flanger {EFCA3D92-DFD8-4672-A603-7420894BAD98}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_FLANGER, 0xefca3d92, 0xdfd8, 0x4672, 0xa6, 0x03, 0x74, 0x20, 0x89, 0x4b, 0xad, 0x98);

// Echo/Delay {EF3E932C-D40B-4F51-8CCF-3F98F1B29D5D}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_ECHO, 0xef3e932c, 0xd40b, 0x4f51, 0x8c, 0xcf, 0x3f, 0x98, 0xf1, 0xb2, 0x9d, 0x5d);

// Distortion {EF114C90-CD1D-484E-96E5-09CFAF912A21}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_DISTORTION, 0xef114c90, 0xcd1d, 0x484e, 0x96, 0xe5, 0x09, 0xcf, 0xaf, 0x91, 0x2a, 0x21);

// Compressor/Limiter {EF011F79-4000-406D-87AF-BFFB3FC39D57}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_COMPRESSOR, 0xef011f79, 0x4000, 0x406d, 0x87, 0xaf, 0xbf, 0xfb, 0x3f, 0xc3, 0x9d, 0x57);

// Parametric Equalization {120CED89-3BF4-4173-A132-3CB406CF3231}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_PARAMEQ, 0x120ced89, 0x3bf4, 0x4173, 0xa1, 0x32, 0x3c, 0xb4, 0x06, 0xcf, 0x32, 0x31);

// I3DL2 Environmental Reverberation: Reverb (Listener) Effect {EF985E71-D5C7-42D4-BA4D-2D073E2E96F4}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_STANDARD_I3DL2REVERB, 0xef985e71, 0xd5c7, 0x42d4, 0xba, 0x4d, 0x2d, 0x07, 0x3e, 0x2e, 0x96, 0xf4);

// Waves Reverberation {87FC0268-9A55-4360-95AA-004A1D9DE26C}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSFX_WAVES_REVERB, 0x87fc0268, 0x9a55, 0x4360, 0x95, 0xaa, 0x00, 0x4a, 0x1d, 0x9d, 0xe2, 0x6c);

// 
// DirectSound Capture Effect Algorithms
// 


// Acoustic Echo Canceller {BF963D80-C559-11D0-8A2B-00A0C9255AC1}
// Matches KSNODETYPE_ACOUSTIC_ECHO_CANCEL in ksmedia.h
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSCFX_CLASS_AEC, 0xBF963D80, 0xC559, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1);

// Microsoft AEC {CDEBB919-379A-488a-8765-F53CFD36DE40}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSCFX_MS_AEC, 0xcdebb919, 0x379a, 0x488a, 0x87, 0x65, 0xf5, 0x3c, 0xfd, 0x36, 0xde, 0x40);

// System AEC {1C22C56D-9879-4f5b-A389-27996DDC2810}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSCFX_SYSTEM_AEC, 0x1c22c56d, 0x9879, 0x4f5b, 0xa3, 0x89, 0x27, 0x99, 0x6d, 0xdc, 0x28, 0x10);

// Noise Supression {E07F903F-62FD-4e60-8CDD-DEA7236665B5}
// Matches KSNODETYPE_NOISE_SUPPRESS in post Windows ME DDK's ksmedia.h
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSCFX_CLASS_NS, 0xe07f903f, 0x62fd, 0x4e60, 0x8c, 0xdd, 0xde, 0xa7, 0x23, 0x66, 0x65, 0xb5);

// Microsoft Noise Suppresion {11C5C73B-66E9-4ba1-A0BA-E814C6EED92D}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSCFX_MS_NS, 0x11c5c73b, 0x66e9, 0x4ba1, 0xa0, 0xba, 0xe8, 0x14, 0xc6, 0xee, 0xd9, 0x2d);

// System Noise Suppresion {5AB0882E-7274-4516-877D-4EEE99BA4FD0}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DSCFX_SYSTEM_NS, 0x5ab0882e, 0x7274, 0x4516, 0x87, 0x7d, 0x4e, 0xee, 0x99, 0xba, 0x4f, 0xd0);

#endif // DIRECTSOUND_VERSION >= 0x0800




#if __cplusplus
#endif // __cplusplus


