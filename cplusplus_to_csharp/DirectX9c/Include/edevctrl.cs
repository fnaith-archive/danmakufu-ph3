/*++

Copyright (C) Microsoft Corporation, 1998 - 1999

Module Name:

    EDevCtrl.h

Abstract:

    This header contain structures and peroperty sets for 
    interfacing to an external device, like a DV.
    The code is modeled after DirectShow's Vcrctrl Sample 
    (VCR Control Filter). It contain IAMExtDevice, 
    IAMExtTransport, and IAMTimecodeReader interfaces, and 
    a new interface IAMAdvancedAVControl() is added
    for additional advanced device controls.

    Note:  (From DShow DDK)
        The VCR control sample filter, Vcrctrl, is a simple 
        implementation of the external device control interfaces 
        that DirectShow provides. Vcrctrl provides basic transport 
        control and SMPTE timecode-reading capabilities for certain 
        Betacam and SVHS videocassette recorders with RS-422 or RS-232 
        serial interfaces (see source code for specific machine types 
        supported).

    Note:  some methods in IAM* interfaces may not be 
           used and will return not implemented.           

Created:

    September 23, 1998    

    Yee J. Wu


Revision:

   0.6

--*/


// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union _timecode
// {
//   struct
//   {
//     ushort wFrameRate;
//     ushort wFrameFract;
//     uint dwFrames;
//     };
//   ulong qw;
//   };




public class tagTIMECODE_SAMPLE
{
    public long qwTick;
    public TIMECODE timecode = new TIMECODE();
    public uint dwUser;
    public uint dwFlags;
}



// Device Capabilities
public class tagDEVCAPS
{
    public int CanRecord;
    public int CanRecordStrobe;
    public int HasAudio;
    public int HasVideo;
    public int UsesFiles;
    public int CanSave;
    public int DeviceType;
    public int TCRead;
    public int TCWrite;
    public int CTLRead;
    public int IndexRead;
    public int Preroll;
    public int Postroll;
    public int SyncAcc;
    public int NormRate;
    public int CanPreview;
    public int CanMonitorSrc;
    public int CanTest;
    public int VideoIn;
    public int AudioIn;
    public int Calibrate;
    public int SeekType;
    public int SimulatedHardware; // private
}

// transport status
public class tagTRANSPORTSTATUS
{
    public int Mode;
    public int LastError;
    public int RecordInhibit;
    public int ServoLock;
    public int MediaPresent;
    public int MediaLength;
    public int MediaSize;
    public int MediaTrackCount;
    public int MediaTrackLength;
    public int MediaTrackSide;
    public int MediaType;
    public int LinkMode;
    public int NotifyOn;
}

// transport basic parameters
public class tagTRANSPORTBASICPARMS
{
    public int TimeFormat;
    public int TimeReference;
    public int Superimpose;
    public int EndStopAction;
    public int RecordFormat;
    public int StepFrames;
    public int SetpField;
    public int Preroll;
    public int RecPreroll;
    public int Postroll;
    public int EditDelay;
    public int PlayTCDelay;
    public int RecTCDelay;
    public int EditField;
    public int FrameServo;
    public int ColorFrameServo;
    public int ServoRef;
    public int WarnGenlock;
    public int SetTracking;
    public string VolumeName = new string(new char[40]);
    public int[] Ballistic = new int[20];
    public int Speed;
    public int CounterFormat;
    public int TunerChannel;
    public int TunerNumber;
    public int TimerEvent;
    public int TimerStartDay;
    public int TimerStartTime;
    public int TimerStopDay;
    public int TimerStopTime;
}

// transport video parameters
public class tagTRANSPORTVIDEOPARMS
{
    public int OutputMode;
    public int Input;
}

// transport audio parameters
public class tagTRANSPORTAUDIOPARMS
{
    public int EnableOutput;
    public int EnableRecord;
    public int EnableSelsync;
    public int Input;
    public int MonitorSource;
}


// low level machine status structure filled in after
// REQUEST_STATUS command from above.  This structure would
// grow in a full implementation
public class tagVCRSTATUS
{
    public bool bCassetteOut; // OATRUE means no cassette
    public bool bLocal; // OATRUE means front panel switch in local
}




// ---------------------------------------------------------
// STATIC_PROPSETID_VIDCAP_EXT_DEVICE
// ---------------------------------------------------------
// This guid and interface is defined in strmif.h 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_EXT_DEVICE 0xB5730A90L, 0x1A2C, 0x11cf, 0x8c, 0x23, 0x00, 0xAA, 0x00, 0x6B, 0x68, 0x14
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("B5730A90-1A2C-11cf-8C23-00AA006B6814", PROPSETID_EXT_DEVICE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_EXT_DEVICE DEFINE_GUIDNAMED(PROPSETID_EXT_DEVICE)


// KS properties and structure for this interface
public enum KSPROPERTY_EXTDEVICE
{
    KSPROPERTY_EXTDEVICE_ID, // ID (such as Symbolic Lin) that can uniquely idenfy this device
    KSPROPERTY_EXTDEVICE_VERSION, // Device model number and version (such AV/C VCR Subunit Spec. 2.01)
    KSPROPERTY_EXTDEVICE_POWER_STATE, // Return current device power state.
    KSPROPERTY_EXTDEVICE_PORT, // Can use this to return DEV_PORT_1394
    KSPROPERTY_EXTDEVICE_CAPABILITIES // Device specific capabilities

}


public class KSPROPERTY_EXTDEVICE_S
{
    public KSPROPERTY Property = new KSPROPERTY();

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        // Client is responsible for allocating this.
//        tagDEVCAPS Capabilities; // May need to expand on the existing structure
//        uint DevPort;
//        uint PowerState; // On, off standby
//        char pawchString[MAX_PATH]; // ID and version
//        uint NodeUniqueID[2]; // Unique NodeID
//    }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    u;

}


// ---------------------------------------------------------
// STATIC_PROPSETID_VIDCAP_EXT_TRANSPORT
// ---------------------------------------------------------
// This guid and interface is defined in strmif.h 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_EXT_TRANSPORT 0xA03CD5F0L, 0x3045, 0x11cf, 0x8c, 0x44, 0x00, 0xAA, 0x00, 0x6B, 0x68, 0x14
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A03CD5F0-3045-11cf-8C44-00AA006B6814", PROPSETID_EXT_TRANSPORT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_EXT_TRANSPORT DEFINE_GUIDNAMED(PROPSETID_EXT_TRANSPORT)



// KS properties and structure for this interface
public enum KSPROPERTY_EXTXPORT
{
    KSPROPERTY_EXTXPORT_CAPABILITIES, // Transport specific capability
    KSPROPERTY_EXTXPORT_INPUT_SIGNAL_MODE, // MPEG, D-VHS, Analog VHS etc.
    KSPROPERTY_EXTXPORT_OUTPUT_SIGNAL_MODE, // MPEG, D-VHS, Analog VHS etc.
    KSPROPERTY_EXTXPORT_LOAD_MEDIUM, // Eject, open tray, close tray
    KSPROPERTY_EXTXPORT_MEDIUM_INFO, // cassettte_type and tape_grade_and_write_protect
    KSPROPERTY_EXTXPORT_STATE, // Get/Set transport mode and state
    KSPROPERTY_EXTXPORT_STATE_NOTIFY, // NOTIFY: Mode + State (Table 4-8)
    KSPROPERTY_EXTXPORT_TIMECODE_SEARCH, // Request VCR subunit to search for a specific timecode on the medium
    KSPROPERTY_EXTXPORT_ATN_SEARCH, // Request VCR subunit to search for a specific ATN on the medium
    KSPROPERTY_EXTXPORT_RTC_SEARCH, // Request VCR subunit to search for a specific RelativeTimeCounter on the medium

    // 
    // Implemented for testing purpose
    // Will remove this later...
    // 
    KSPROPERTY_RAW_AVC_CMD // Send/Rcv raw AVC commnad with a FCP packet.

}

public class MEDIUM_INFO
{
    public bool MediaPresent; // TRUE/FALSE
    public uint MediaType; // DVCR standard, small, medium; VHS; VHS-C; unknown
    public bool RecordInhibit; // TRUE/FALSE
}


public class TRANSPORT_STATE
{
    public uint Mode; // LOAD MEDIUM, RECORD, PLAY or WIND
    public uint State; // Vary depend on mode (Table 4-8)
}

public class KSPROPERTY_EXTXPORT_S
{
    public KSPROPERTY Property = new KSPROPERTY();

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint Capabilities; // May need to expand on the existing structure
//        uint SignalMode; // MPEG, D-VHS, Analog VHS etc.
//        uint LoadMedium; // Eject, open tray, close tray
//        MEDIUM_INFO MediumInfo;
//        TRANSPORT_STATE XPrtState;
// 
//        struct
//        {
//          byte frame;
//          byte second;
//          byte minute;
//          byte hour;
//        }
//        Timecode;
//        uint dwTimecode; // hour:minute:second:frame
//        uint dwAbsTrackNumber; // absolute track number
// 
// 
//       //
//       // Implemented for testing purpose
//       // Will remove this later or will keep this for 
//       // packet specific command.
//       //
//       struct
//       {
//           uint PayloadSize;
//           byte Payload[512]; // This is only for testing sending AVC command from User mode.
//       }
//       RawAVC;
// 
//     }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//     u;

}



// ---------------------------------------------------------
// PROPSETID_TIMECODE
// ---------------------------------------------------------
// This guid and interface is defined in strmif.h 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_TIMECODE_READER 0x9B496CE1L, 0x811B, 0x11cf, 0x8C, 0x77, 0x00, 0xAA, 0x00, 0x6B, 0x68, 0x14
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9B496CE1-811B-11cf-8C77-00AA006B6814", PROPSETID_TIMECODE_READER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_TIMECODE_READER DEFINE_GUIDNAMED(PROPSETID_TIMECODE_READER)


// KS properties and structure for this interface
public enum KSPROPERTY_TIMECODE
{
    KSPROPERTY_TIMECODE_READER, // Timecode for the current medium position
    KSPROPERTY_ATN_READER, // Absolute track number the current medium position
    KSPROPERTY_RTC_READER // Relative time counter for the current medium position

}


public class KSPROPERTY_TIMECODE_S
{
    public KSPROPERTY Property = new KSPROPERTY();

    public tagTIMECODE_SAMPLE TimecodeSamp = new tagTIMECODE_SAMPLE();

}



// ---------------------------------------------------------
//  External Device Command event notification
// ---------------------------------------------------------

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_EXTDEV_Command 0x109c7988L, 0xb3cb, 0x11d2, 0xb4, 0x8e, 0x00, 0x60, 0x97, 0xb3, 0x39, 0x1b
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("109c7988-b3cb-11d2-b48e-006097b3391b", KSEVENTSETID_EXTDEV_Command);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_EXTDEV_Command DEFINE_GUIDNAMED(KSEVENTSETID_EXTDEV_Command)

public enum KSEVENT_DEVCMD
{
    KSEVENT_EXTDEV_COMMAND_NOTIFY_INTERIM_READY,
    KSEVENT_EXTDEV_COMMAND_CONTROL_INTERIM_READY,
    KSEVENT_EXTDEV_COMMAND_BUSRESET,
    KSEVENT_EXTDEV_TIMECODE_UPDATE,
    KSEVENT_EXTDEV_OPERATION_MODE_UPDATE, // Notify mode of operation change (VCR,OFF,Camera)
    KSEVENT_EXTDEV_TRANSPORT_STATE_UPDATE, // XPrt state change
    KSEVENT_EXTDEV_NOTIFY_REMOVAL, // Notify device removal
    KSEVENT_EXTDEV_NOTIFY_MEDIUM_CHANGE // Notify medium (tape) is removed or added

}


