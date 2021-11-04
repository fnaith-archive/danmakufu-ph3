using System;

/*==========================================================================;
 *
 *  Copyright (C) 1999 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dpvoice.h
 *  Content:    DirectPlayVoice include file
 ***************************************************************************/


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h> // for DECLARE_INTERFACE and HRESULT
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <mmsystem.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <mmreg.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <msacm.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "dsound.h"

#if __cplusplus
#endif


/****************************************************************************
 *
 * DirectPlayVoice CLSIDs
 *
 ****************************************************************************/


// {B9F3EB85-B781-4ac1-8D90-93A05EE37D7D}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlayVoiceClient, 0xb9f3eb85, 0xb781, 0x4ac1, 0x8d, 0x90, 0x93, 0xa0, 0x5e, 0xe3, 0x7d, 0x7d);

// {D3F5B8E6-9B78-4a4c-94EA-CA2397B663D3}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlayVoiceServer, 0xd3f5b8e6, 0x9b78, 0x4a4c, 0x94, 0xea, 0xca, 0x23, 0x97, 0xb6, 0x63, 0xd3);

// {0F0F094B-B01C-4091-A14D-DD0CD807711A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlayVoiceTest, 0xf0f094b, 0xb01c, 0x4091, 0xa1, 0x4d, 0xdd, 0xc, 0xd8, 0x7, 0x71, 0x1a);

/****************************************************************************
 *
 * DirectPlayVoice Interface IIDs
 *
 ****************************************************************************/


// {1DFDC8EA-BCF7-41d6-B295-AB64B3B23306}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayVoiceClient, 0x1dfdc8ea, 0xbcf7, 0x41d6, 0xb2, 0x95, 0xab, 0x64, 0xb3, 0xb2, 0x33, 0x6);

// {FAA1C173-0468-43b6-8A2A-EA8A4F2076C9}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayVoiceServer, 0xfaa1c173, 0x468, 0x43b6, 0x8a, 0x2a, 0xea, 0x8a, 0x4f, 0x20, 0x76, 0xc9);

// {D26AF734-208B-41da-8224-E0CE79810BE1}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayVoiceTest, 0xd26af734, 0x208b, 0x41da, 0x82, 0x24, 0xe0, 0xce, 0x79, 0x81, 0xb, 0xe1);

/****************************************************************************
 *
 * DirectPlayVoice Compression Type GUIDs
 *
 ****************************************************************************/

// MS-ADPCM 32.8 kbit/s
// 
// {699B52C1-A885-46a8-A308-97172419ADC7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_ADPCM, 0x699b52c1, 0xa885, 0x46a8, 0xa3, 0x8, 0x97, 0x17, 0x24, 0x19, 0xad, 0xc7);

// Microsoft GSM 6.10 13 kbit/s
// 
// {24768C60-5A0D-11d3-9BE4-525400D985E7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_GSM, 0x24768c60, 0x5a0d, 0x11d3, 0x9b, 0xe4, 0x52, 0x54, 0x0, 0xd9, 0x85, 0xe7);

// MS-PCM 64 kbit/s
// 
// {8DE12FD4-7CB3-48ce-A7E8-9C47A22E8AC5}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_NONE, 0x8de12fd4, 0x7cb3, 0x48ce, 0xa7, 0xe8, 0x9c, 0x47, 0xa2, 0x2e, 0x8a, 0xc5);

// Voxware SC03 3.2kbit/s
// 
// {7D82A29B-2242-4f82-8F39-5D1153DF3E41}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_SC03, 0x7d82a29b, 0x2242, 0x4f82, 0x8f, 0x39, 0x5d, 0x11, 0x53, 0xdf, 0x3e, 0x41);

// Voxware SC06 6.4kbit/s
// 
// {53DEF900-7168-4633-B47F-D143916A13C7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_SC06, 0x53def900, 0x7168, 0x4633, 0xb4, 0x7f, 0xd1, 0x43, 0x91, 0x6a, 0x13, 0xc7);

// TrueSpeech(TM) 8.6 kbit/s
// 
// {D7954361-5A0B-11d3-9BE4-525400D985E7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_TRUESPEECH, 0xd7954361, 0x5a0b, 0x11d3, 0x9b, 0xe4, 0x52, 0x54, 0x0, 0xd9, 0x85, 0xe7);

// Voxware VR12 1.4kbit/s
// 
// {FE44A9FE-8ED4-48bf-9D66-1B1ADFF9FF6D}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPVCTGUID_VR12, 0xfe44a9fe, 0x8ed4, 0x48bf, 0x9d, 0x66, 0x1b, 0x1a, 0xdf, 0xf9, 0xff, 0x6d);

// Define the default compression type
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPVCTGUID_DEFAULT DPVCTGUID_SC03

/****************************************************************************
 *
 * DirectPlayVoice Interface Pointer definitions
 *
 ****************************************************************************/


/****************************************************************************
 *
 * DirectPlayVoice Callback Functions
 *
 ****************************************************************************/
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(FAR PASCAL *PDVMESSAGEHANDLER)(object* pvUserContext, uint dwMessageType, object* lpMessage);
public delegate int PDVMESSAGEHANDLER(object pvUserContext, uint dwMessageType, object lpMessage);


/****************************************************************************
 *
 * DirectPlayVoice Datatypes (Non-Structure / Non-Message)
 *
 ****************************************************************************/


/****************************************************************************
 *
 * DirectPlayVoice Message Types
 *
 ****************************************************************************/


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_MINBASE (DVMSGID_CREATEVOICEPLAYER)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_CREATEVOICEPLAYER (DVMSGID_BASE+0x0001)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_DELETEVOICEPLAYER (DVMSGID_BASE+0x0002)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_SESSIONLOST (DVMSGID_BASE+0x0003)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_PLAYERVOICESTART (DVMSGID_BASE+0x0004)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_PLAYERVOICESTOP (DVMSGID_BASE+0x0005)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_RECORDSTART (DVMSGID_BASE+0x0006)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_RECORDSTOP (DVMSGID_BASE+0x0007)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_CONNECTRESULT (DVMSGID_BASE+0x0008)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_DISCONNECTRESULT (DVMSGID_BASE+0x0009)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_INPUTLEVEL (DVMSGID_BASE+0x000A)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_OUTPUTLEVEL (DVMSGID_BASE+0x000B)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_HOSTMIGRATED (DVMSGID_BASE+0x000C)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_SETTARGETS (DVMSGID_BASE+0x000D)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_PLAYEROUTPUTLEVEL (DVMSGID_BASE+0x000E)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_LOSTFOCUS (DVMSGID_BASE+0x0010)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_GAINFOCUS (DVMSGID_BASE+0x0011)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_LOCALHOSTSETUP (DVMSGID_BASE+0x0012)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVMSGID_MAXBASE (DVMSGID_LOCALHOSTSETUP)

/****************************************************************************
 *
 * DirectPlayVoice Constants
 *
 ****************************************************************************/

// 
// Buffer Aggresiveness Value Ranges
// 

// 
// Buffer Quality Value Ranges
// 


// 
// Used to identify the session host in client/server
// 

// 
// Used to target all players
// 

// 
// Used to identify the main buffer
// 

// 
// Input level range
// 



// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DVPLAYBACKVOLUME_DEFAULT DSBVOLUME_MAX



// 
// Use the default value
// 

// 
// Threshold Ranges
// 

// 
// Threshold field is not used 
// 

// 
// Session Types
// 

/****************************************************************************
 *
 * DirectPlayVoice Flags
 *
 ****************************************************************************/


// 
// Enable automatic adjustment of the recording volume
// 

// 
// Enable automatic voice activation
// 

// 
// Enable echo suppression
// 

// 
// Voice Activation manual mode
// 

// 
// Only playback voices that have buffers created for them
// 

// 
// Mute the playback
// 

// 
// Mute the recording 
// 

// 
// Complete the operation before returning
// 

// 
// Just check to see if wizard has been run, and if so what it's results were
// 

// 
// Shutdown the voice session without migrating the host
// 

// 
// Allow the back button to be enabled in the wizard
// 

// 
// Disable host migration in the voice session
// 

// 
// Server controlled targetting
// 

// 
// Use DirectSound Normal Mode instead of priority 
// 

// 
// Automatically select the microphone
// 

// 
// Run in half duplex mode
// 

// 
// No volume controls are available for the recording device
// 

// 
// Disable capture sharing
// 

// 
// Set system conversion quality to high
// 

// 
// Enable strict focus mode
// 

// 
// Player is in half duplex mode
// 

// 
// Specifies that player is the local player
// 

/****************************************************************************
 *
 * DirectPlayVoice Structures (Non-Message)
 *
 ****************************************************************************/


// 
// DirectPlayVoice Caps
// (GetCaps / SetCaps)
// 
public class DVCAPS
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Caps flags
}

// 
// DirectPlayVoice Client Configuration
// (Connect / GetClientConfig)
// 
public class DVCLIENTCONFIG
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags for client config (DVCLIENTCONFIG_...)
    public int lRecordVolume; // Recording volume
    public int lPlaybackVolume; // Playback volume
    public uint dwThreshold; // Voice Activation Threshold
    public uint dwBufferQuality; // Buffer quality
    public uint dwBufferAggressiveness; // Buffer aggressiveness
    public uint dwNotifyPeriod; // Period of notification messages (ms)
}

// 
// DirectPlayVoice Compression Type Information
// (GetCompressionTypes)
// 
public class DVCOMPRESSIONINFO
{
    public uint dwSize; // Size of this structure
    public GUID guidType = new GUID(); // GUID that identifies this compression type
    public string lpszName; // String name of this compression type
    public string lpszDescription; // Description for this compression type
    public uint dwFlags; // Flags for this compression type
    public uint dwMaxBitsPerSecond; // Maximum # of bit/s this compression type uses
}

// 
// DirectPlayVoice Session Description
// (Host / GetSessionDesc)
// 
public class DVSESSIONDESC
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Session flags (DVSESSION_...)
    public uint dwSessionType; // Session type (DVSESSIONTYPE_...)
    public GUID guidCT = new GUID(); // Compression Type to use
    public uint dwBufferQuality; // Buffer quality
    public uint dwBufferAggressiveness; // Buffer aggresiveness
}

// 
// DirectPlayVoice Client Sound Device Configuration
// (Connect / GetSoundDeviceConfig)
// 
public class DVSOUNDDEVICECONFIG
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags for sound config (DVSOUNDCONFIG_...)
    public GUID guidPlaybackDevice = new GUID(); // GUID of the playback device to use
    public LPDIRECTSOUND lpdsPlaybackDevice = new LPDIRECTSOUND(); // DirectSound Object to use (optional)
    public GUID guidCaptureDevice = new GUID(); // GUID of the capture device to use
    public LPDIRECTSOUNDCAPTURE lpdsCaptureDevice = new LPDIRECTSOUNDCAPTURE(); // DirectSoundCapture Object to use (optional)
    public IntPtr hwndAppWindow; // HWND of your application's top-level window
    public LPDIRECTSOUNDBUFFER lpdsMainBuffer = new LPDIRECTSOUNDBUFFER(); // DirectSoundBuffer to use for playback (optional)
    public uint dwMainBufferFlags; // Flags to pass to Play() on the main buffer
    public uint dwMainBufferPriority; // Priority to set when calling Play() on the main buffer
}

/****************************************************************************
 *
 * DirectPlayVoice message handler call back structures
 *
 ****************************************************************************/

// 
// Result of the Connect() call.  (If it wasn't called Async)
// (DVMSGID_CONNECTRESULT)
// 
public class DVMSG_CONNECTRESULT
{
    public uint dwSize; // Size of this structure
    public int hrResult; // Result of the Connect() call
}

// 
// A new player has entered the voice session
// (DVMSGID_CREATEVOICEPLAYER)
// 
public class DVMSG_CREATEVOICEPLAYER
{
    public uint dwSize; // Size of this structure
    public uint dvidPlayer; // DVID of the player who joined
    public uint dwFlags; // Player flags (DVPLAYERCAPS_...)
    public object pvPlayerContext; // Context value for this player (user set)
}

// 
// A player has left the voice session
// (DVMSGID_DELETEVOICEPLAYER)
// 
public class DVMSG_DELETEVOICEPLAYER
{
    public uint dwSize; // Size of this structure
    public uint dvidPlayer; // DVID of the player who left
    public object pvPlayerContext; // Context value for the player
}

// 
// Result of the Disconnect() call.  (If it wasn't called Async)
// (DVMSGID_DISCONNECTRESULT)
// 
public class DVMSG_DISCONNECTRESULT
{
    public uint dwSize; // Size of this structure
    public int hrResult; // Result of the Disconnect() call
}

// 
// The voice session host has migrated.
// (DVMSGID_HOSTMIGRATED) 
// 
public class DVMSG_HOSTMIGRATED
{
    public uint dwSize; // Size of this structure
    public uint dvidNewHostID; // DVID of the player who is now the host
    public IDirectPlayVoiceServer pdvServerInterface;
                                            // Pointer to the new host object (if local player is now host)
}

// 
// The current input level / recording volume on the local machine
// (DVMSGID_INPUTLEVEL)
// 
public class DVMSG_INPUTLEVEL
{
    public uint dwSize; // Size of this structure
    public uint dwPeakLevel; // Current peak level of the audio
    public int lRecordVolume; // Current recording volume
    public object pvLocalPlayerContext; // Context value for the local player
}

// 
// The local client is about to become the new host
// (DVMSGID_LOCALHOSTSETUP)
// 
public class DVMSG_LOCALHOSTSETUP
{
    public uint dwSize; // Size of this structure
    public object pvContext; // Context value to be passed to Initialize() of new host object
    public PDVMESSAGEHANDLER pMessageHandler; // Message handler to be used by new host object
}

// 
// The current output level for the combined output of all incoming streams.
// (DVMSGID_OUTPUTLEVEL)
// 
public class DVMSG_OUTPUTLEVEL
{
    public uint dwSize; // Size of this structure
    public uint dwPeakLevel; // Current peak level of the output
    public int lOutputVolume; // Current playback volume
    public object pvLocalPlayerContext; // Context value for the local player
}

// 
// The current peak level of an individual player's incoming audio stream as it is
// being played back.
// (DVMSGID_PLAYEROUTPUTLEVEL)
// 
public class DVMSG_PLAYEROUTPUTLEVEL
{
    public uint dwSize; // Size of this structure
    public uint dvidSourcePlayerID; // DVID of the player
    public uint dwPeakLevel; // Peak level of the player's stream
    public object pvPlayerContext; // Context value for the player
}

// 
// An audio stream from the specified player has started playing back on the local client.
// (DVMSGID_PLAYERVOICESTART).
// 
public class DVMSG_PLAYERVOICESTART
{
    public uint dwSize; // Size of this structure
    public uint dvidSourcePlayerID; // DVID of the Player
    public object pvPlayerContext; // Context value for this player
}

// 
// The audio stream from the specified player has stopped playing back on the local client.
// (DVMSGID_PLAYERVOICESTOP)
// 
public class DVMSG_PLAYERVOICESTOP
{
    public uint dwSize; // Size of this structure
    public uint dvidSourcePlayerID; // DVID of the player
    public object pvPlayerContext; // Context value for this player
}

// 
// Transmission has started on the local machine
// (DVMSGID_RECORDSTART)
// 
public class DVMSG_RECORDSTART
{
    public uint dwSize; // Size of this structure
    public uint dwPeakLevel; // Peak level that caused transmission to start
    public object pvLocalPlayerContext; // Context value for the local player
}

// 
// Transmission has stopped on the local machine
// (DVMSGID_RECORDSTOP)
// 
public class DVMSG_RECORDSTOP
{
    public uint dwSize; // Size of this structure
    public uint dwPeakLevel; // Peak level that caused transmission to stop
    public object pvLocalPlayerContext; // Context value for the local player
}

// 
// The voice session has been lost
// (DVMSGID_SESSIONLOST)
// 
public class DVMSG_SESSIONLOST
{
    public uint dwSize; // Size of this structure
    public int hrResult; // Reason the session was disconnected
}

// 
// The target list has been updated for the local client
// (DVMSGID_SETTARGETS)
// 
public class DVMSG_SETTARGETS
{
    public uint dwSize; // Size of this structure
    public uint dwNumTargets; // # of targets
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint * pdvidTargets;
    public uint pdvidTargets; // An array of DVIDs specifying the current targets
}