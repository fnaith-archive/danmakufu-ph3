using System;

/*++

Copyright (c) Microsoft Corporation. All rights reserved.

Module Name:

    ksmedia.h

Abstract:

    WDM-CSA Multimedia Definitions.

--*/

#if !_KS_
#error KS.H must be included before KSMEDIA.H
#endif // !defined(_KS_)


public class KSMULTIPLE_DATA_PROP
{
    public KSPROPERTY Property = new KSPROPERTY();
    public KSMULTIPLE_ITEM MultipleItem = new KSMULTIPLE_ITEM();
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEDIUMSETID_MidiBus 0x05908040L, 0x3246, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("05908040-3246-11D0-A5D6-28DB04C10000", KSMEDIUMSETID_MidiBus);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEDIUMSETID_MidiBus DEFINE_GUIDNAMED(KSMEDIUMSETID_MidiBus)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMEDIUMSETID_VPBus 0xA18C15ECL, 0xCE43, 0x11D0, 0xAB, 0xE7, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A18C15EC-CE43-11D0-ABE7-00A0C9223196", KSMEDIUMSETID_VPBus);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMEDIUMSETID_VPBus DEFINE_GUIDNAMED(KSMEDIUMSETID_VPBus)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSINTERFACESETID_Media 0x3A13EB40L, 0x30A7, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("3A13EB40-30A7-11D0-A5D6-28DB04C10000", KSINTERFACESETID_Media);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSINTERFACESETID_Media DEFINE_GUIDNAMED(KSINTERFACESETID_Media)

public enum KSINTERFACE_MEDIA
{
    KSINTERFACE_MEDIA_MUSIC,
    KSINTERFACE_MEDIA_WAVE_BUFFERED,
    KSINTERFACE_MEDIA_WAVE_QUEUED
}


#if !INIT_USBAUDIO_MID
// {4e1cecd2-1679-463b-a72f-a5bf64c86eba}
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_USBAUDIO_MID(guid, id){ (guid)->Data1 = 0x4e1cecd2 + (USHORT)(id); (guid)->Data2 = 0x1679; (guid)->Data3 = 0x463b; (guid)->Data4[0] = 0xa7; (guid)->Data4[1] = 0x2f; (guid)->Data4[2] = 0xa5; (guid)->Data4[3] = 0xbf; (guid)->Data4[4] = 0x64; (guid)->Data4[5] = 0xc8; (guid)->Data4[6] = 0x6e; (guid)->Data4[7] = 0xba;}
#define INIT_USBAUDIO_MID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EXTRACT_USBAUDIO_MID(guid) (USHORT)((guid)->Data1 - 0x4e1cecd2)
#define EXTRACT_USBAUDIO_MID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_USBAUDIO_MID_GUID(id) 0x4e1cecd2+(USHORT)(id), 0x1679, 0x463b, 0xa7, 0x2f, 0xa5, 0xbf, 0x64, 0xc8, 0x6e, 0xba
#define DEFINE_USBAUDIO_MID_GUID

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IS_COMPATIBLE_USBAUDIO_MID(guid) (((guid)->Data1 >= 0x4e1cecd2) && ((guid)->Data1 < 0x4e1cecd2 + 0xffff) && ((guid)->Data2 == 0x1679) && ((guid)->Data3 == 0x463b) && ((guid)->Data4[0] == 0xa7) && ((guid)->Data4[1] == 0x2f) && ((guid)->Data4[2] == 0xa5) && ((guid)->Data4[3] == 0xbf) && ((guid)->Data4[4] == 0x64) && ((guid)->Data4[5] == 0xc8) && ((guid)->Data4[6] == 0x6e) && ((guid)->Data4[7] == 0xba))
#define IS_COMPATIBLE_USBAUDIO_MID
#endif // !defined(INIT_USBAUDIO_MID)

#if !INIT_USBAUDIO_PID
// {abcc5a5e-c263-463b-a72f-a5bf64c86eba}
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_USBAUDIO_PID(guid, id){ (guid)->Data1 = 0xabcc5a5e + (USHORT)(id); (guid)->Data2 = 0xc263; (guid)->Data3 = 0x463b; (guid)->Data4[0] = 0xa7; (guid)->Data4[1] = 0x2f; (guid)->Data4[2] = 0xa5; (guid)->Data4[3] = 0xbf; (guid)->Data4[4] = 0x64; (guid)->Data4[5] = 0xc8; (guid)->Data4[6] = 0x6e; (guid)->Data4[7] = 0xba;}
#define INIT_USBAUDIO_PID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EXTRACT_USBAUDIO_PID(guid) (USHORT)((guid)->Data1 - 0xabcc5a5e)
#define EXTRACT_USBAUDIO_PID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_USBAUDIO_PID_GUID(id) 0xabcc5a5e+(USHORT)(id), 0xc263, 0x463b, 0xa7, 0x2f, 0xa5, 0xbf, 0x64, 0xc8, 0x6e, 0xba
#define DEFINE_USBAUDIO_PID_GUID

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IS_COMPATIBLE_USBAUDIO_PID(guid) (((guid)->Data1 >= 0xabcc5a5e) && ((guid)->Data1 < 0xabcc5a5e + 0xffff) && ((guid)->Data2 == 0xc263) && ((guid)->Data3 == 0x463b) && ((guid)->Data4[0] == 0xa7) && ((guid)->Data4[1] == 0x2f) && ((guid)->Data4[2] == 0xa5) && ((guid)->Data4[3] == 0xbf) && ((guid)->Data4[4] == 0x64) && ((guid)->Data4[5] == 0xc8) && ((guid)->Data4[6] == 0x6e) && ((guid)->Data4[7] == 0xba))
#define IS_COMPATIBLE_USBAUDIO_PID
#endif // !defined(INIT_USBAUDIO_PID)

#if !INIT_USBAUDIO_PRODUCT_NAME
// {FC575048-2E08-463B-A72F-A5BF64C86EBA}
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_USBAUDIO_PRODUCT_NAME(guid, vid, pid, strIndex){ (guid)->Data1 = 0XFC575048 + (USHORT)(vid); (guid)->Data2 = 0x2E08 + (USHORT)(pid); (guid)->Data3 = 0x463B + (USHORT)(strIndex); (guid)->Data4[0] = 0xA7; (guid)->Data4[1] = 0x2F; (guid)->Data4[2] = 0xA5; (guid)->Data4[3] = 0xBF; (guid)->Data4[4] = 0x64; (guid)->Data4[5] = 0xC8; (guid)->Data4[6] = 0x6E; (guid)->Data4[7] = 0xBA;}
#define INIT_USBAUDIO_PRODUCT_NAME
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_USBAUDIO_PRODUCT_NAME(vid, pid, strIndex) 0xFC575048+(USHORT)(vid), 0x2E08+(USHORT)(pid), 0x463B+(USHORT)(strIndex), 0xA7, 0x2F, 0xA5, 0xBF, 0x64, 0xC8, 0x6E, 0xBA
#define DEFINE_USBAUDIO_PRODUCT_NAME
#endif // !defined(INIT_USBAUDIO_PRODUCT_NAME)


// USB Component ID
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCOMPONENTID_USBAUDIO 0x8F1275F0, 0x26E9, 0x4264, 0xBA, 0x4D, 0x39, 0xFF, 0xF0, 0x1D, 0x94, 0xAA
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("8F1275F0-26E9-4264-BA4D-39FFF01D94AA", KSCOMPONENTID_USBAUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCOMPONENTID_USBAUDIO DEFINE_GUIDNAMED(KSCOMPONENTID_USBAUDIO)

// USB Terminals
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_USB_TERMINAL(guid, id){ (guid)->Data1 = 0xDFF219E0 + (USHORT)(id); (guid)->Data2 = 0xF70F; (guid)->Data3 = 0x11D0; (guid)->Data4[0] = 0xb9; (guid)->Data4[1] = 0x17; (guid)->Data4[2] = 0x00; (guid)->Data4[3] = 0xa0; (guid)->Data4[4] = 0xc9; (guid)->Data4[5] = 0x22; (guid)->Data4[6] = 0x31; (guid)->Data4[7] = 0x96;}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EXTRACT_USB_TERMINAL(guid) (USHORT)((guid)->Data1 - 0xDFF219E0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_USB_TERMINAL_GUID(id) 0xDFF219E0+(USHORT)(id), 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MICROPHONE DEFINE_USB_TERMINAL_GUID(0x0201)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21BE1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_MICROPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MICROPHONE DEFINE_GUIDNAMED(KSNODETYPE_MICROPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DESKTOP_MICROPHONE DEFINE_USB_TERMINAL_GUID(0x0202)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21BE2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DESKTOP_MICROPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DESKTOP_MICROPHONE DEFINE_GUIDNAMED(KSNODETYPE_DESKTOP_MICROPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PERSONAL_MICROPHONE DEFINE_USB_TERMINAL_GUID(0x0203)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21BE3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_PERSONAL_MICROPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PERSONAL_MICROPHONE DEFINE_GUIDNAMED(KSNODETYPE_PERSONAL_MICROPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_OMNI_DIRECTIONAL_MICROPHONE DEFINE_USB_TERMINAL_GUID(0x0204)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21BE4-F70F-11D0-B917-00A0C9223196", KSNODETYPE_OMNI_DIRECTIONAL_MICROPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_OMNI_DIRECTIONAL_MICROPHONE DEFINE_GUIDNAMED(KSNODETYPE_OMNI_DIRECTIONAL_MICROPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MICROPHONE_ARRAY DEFINE_USB_TERMINAL_GUID(0x0205)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21BE5-F70F-11D0-B917-00A0C9223196", KSNODETYPE_MICROPHONE_ARRAY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MICROPHONE_ARRAY DEFINE_GUIDNAMED(KSNODETYPE_MICROPHONE_ARRAY)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PROCESSING_MICROPHONE_ARRAY DEFINE_USB_TERMINAL_GUID(0x0206)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21BE6-F70F-11D0-B917-00A0C9223196", KSNODETYPE_PROCESSING_MICROPHONE_ARRAY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PROCESSING_MICROPHONE_ARRAY DEFINE_GUIDNAMED(KSNODETYPE_PROCESSING_MICROPHONE_ARRAY)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR 0x830a44f2, 0xa32d, 0x476b, 0xbe, 0x97, 0x42, 0x84, 0x56, 0x73, 0xb3, 0x5a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("830a44f2-a32d-476b-be97-42845673b35a", KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR DEFINE_GUIDNAMED(KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SPEAKER DEFINE_USB_TERMINAL_GUID(0x0301)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_SPEAKER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SPEAKER DEFINE_GUIDNAMED(KSNODETYPE_SPEAKER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_HEADPHONES DEFINE_USB_TERMINAL_GUID(0x0302)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_HEADPHONES);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_HEADPHONES DEFINE_GUIDNAMED(KSNODETYPE_HEADPHONES)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_HEAD_MOUNTED_DISPLAY_AUDIO DEFINE_USB_TERMINAL_GUID(0x0303)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_HEAD_MOUNTED_DISPLAY_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_HEAD_MOUNTED_DISPLAY_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_HEAD_MOUNTED_DISPLAY_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DESKTOP_SPEAKER DEFINE_USB_TERMINAL_GUID(0x0304)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE4-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DESKTOP_SPEAKER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DESKTOP_SPEAKER DEFINE_GUIDNAMED(KSNODETYPE_DESKTOP_SPEAKER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ROOM_SPEAKER DEFINE_USB_TERMINAL_GUID(0x0305)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE5-F70F-11D0-B917-00A0C9223196", KSNODETYPE_ROOM_SPEAKER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ROOM_SPEAKER DEFINE_GUIDNAMED(KSNODETYPE_ROOM_SPEAKER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_COMMUNICATION_SPEAKER DEFINE_USB_TERMINAL_GUID(0x0306)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE6-F70F-11D0-B917-00A0C9223196", KSNODETYPE_COMMUNICATION_SPEAKER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_COMMUNICATION_SPEAKER DEFINE_GUIDNAMED(KSNODETYPE_COMMUNICATION_SPEAKER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_LOW_FREQUENCY_EFFECTS_SPEAKER DEFINE_USB_TERMINAL_GUID(0x0307)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21CE7-F70F-11D0-B917-00A0C9223196", KSNODETYPE_LOW_FREQUENCY_EFFECTS_SPEAKER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_LOW_FREQUENCY_EFFECTS_SPEAKER DEFINE_GUIDNAMED(KSNODETYPE_LOW_FREQUENCY_EFFECTS_SPEAKER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_HANDSET DEFINE_USB_TERMINAL_GUID(0x0401)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21DE1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_HANDSET);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_HANDSET DEFINE_GUIDNAMED(KSNODETYPE_HANDSET)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_HEADSET DEFINE_USB_TERMINAL_GUID(0x0402)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21DE2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_HEADSET);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_HEADSET DEFINE_GUIDNAMED(KSNODETYPE_HEADSET)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SPEAKERPHONE_NO_ECHO_REDUCTION DEFINE_USB_TERMINAL_GUID(0x0403)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21DE3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_SPEAKERPHONE_NO_ECHO_REDUCTION);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SPEAKERPHONE_NO_ECHO_REDUCTION DEFINE_GUIDNAMED(KSNODETYPE_SPEAKERPHONE_NO_ECHO_REDUCTION)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ECHO_SUPPRESSING_SPEAKERPHONE DEFINE_USB_TERMINAL_GUID(0x0404)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21DE4-F70F-11D0-B917-00A0C9223196", KSNODETYPE_ECHO_SUPPRESSING_SPEAKERPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ECHO_SUPPRESSING_SPEAKERPHONE DEFINE_GUIDNAMED(KSNODETYPE_ECHO_SUPPRESSING_SPEAKERPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ECHO_CANCELING_SPEAKERPHONE DEFINE_USB_TERMINAL_GUID(0x0405)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21DE5-F70F-11D0-B917-00A0C9223196", KSNODETYPE_ECHO_CANCELING_SPEAKERPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ECHO_CANCELING_SPEAKERPHONE DEFINE_GUIDNAMED(KSNODETYPE_ECHO_CANCELING_SPEAKERPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PHONE_LINE DEFINE_USB_TERMINAL_GUID(0x0501)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21EE1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_PHONE_LINE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PHONE_LINE DEFINE_GUIDNAMED(KSNODETYPE_PHONE_LINE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_TELEPHONE DEFINE_USB_TERMINAL_GUID(0x0502)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21EE2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_TELEPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_TELEPHONE DEFINE_GUIDNAMED(KSNODETYPE_TELEPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DOWN_LINE_PHONE DEFINE_USB_TERMINAL_GUID(0x0503)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21EE3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DOWN_LINE_PHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DOWN_LINE_PHONE DEFINE_GUIDNAMED(KSNODETYPE_DOWN_LINE_PHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ANALOG_CONNECTOR DEFINE_USB_TERMINAL_GUID(0x601)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_ANALOG_CONNECTOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ANALOG_CONNECTOR DEFINE_GUIDNAMED(KSNODETYPE_ANALOG_CONNECTOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DIGITAL_AUDIO_INTERFACE DEFINE_USB_TERMINAL_GUID(0x0602)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DIGITAL_AUDIO_INTERFACE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DIGITAL_AUDIO_INTERFACE DEFINE_GUIDNAMED(KSNODETYPE_DIGITAL_AUDIO_INTERFACE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_LINE_CONNECTOR DEFINE_USB_TERMINAL_GUID(0x0603)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_LINE_CONNECTOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_LINE_CONNECTOR DEFINE_GUIDNAMED(KSNODETYPE_LINE_CONNECTOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_LEGACY_AUDIO_CONNECTOR DEFINE_USB_TERMINAL_GUID(0x0604)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE4-F70F-11D0-B917-00A0C9223196", KSNODETYPE_LEGACY_AUDIO_CONNECTOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_LEGACY_AUDIO_CONNECTOR DEFINE_GUIDNAMED(KSNODETYPE_LEGACY_AUDIO_CONNECTOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SPDIF_INTERFACE DEFINE_USB_TERMINAL_GUID(0x0605)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE5-F70F-11D0-B917-00A0C9223196", KSNODETYPE_SPDIF_INTERFACE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SPDIF_INTERFACE DEFINE_GUIDNAMED(KSNODETYPE_SPDIF_INTERFACE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_1394_DA_STREAM DEFINE_USB_TERMINAL_GUID(0x0606)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE6-F70F-11D0-B917-00A0C9223196", KSNODETYPE_1394_DA_STREAM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_1394_DA_STREAM DEFINE_GUIDNAMED(KSNODETYPE_1394_DA_STREAM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_1394_DV_STREAM_SOUNDTRACK DEFINE_USB_TERMINAL_GUID(0x0607)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF21FE7-F70F-11D0-B917-00A0C9223196", KSNODETYPE_1394_DV_STREAM_SOUNDTRACK);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_1394_DV_STREAM_SOUNDTRACK DEFINE_GUIDNAMED(KSNODETYPE_1394_DV_STREAM_SOUNDTRACK)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_LEVEL_CALIBRATION_NOISE_SOURCE DEFINE_USB_TERMINAL_GUID(0x0701)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_LEVEL_CALIBRATION_NOISE_SOURCE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_LEVEL_CALIBRATION_NOISE_SOURCE DEFINE_GUIDNAMED(KSNODETYPE_LEVEL_CALIBRATION_NOISE_SOURCE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_EQUALIZATION_NOISE DEFINE_USB_TERMINAL_GUID(0x0702)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_EQUALIZATION_NOISE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_EQUALIZATION_NOISE DEFINE_GUIDNAMED(KSNODETYPE_EQUALIZATION_NOISE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_CD_PLAYER DEFINE_USB_TERMINAL_GUID(0x0703)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_CD_PLAYER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_CD_PLAYER DEFINE_GUIDNAMED(KSNODETYPE_CD_PLAYER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DAT_IO_DIGITAL_AUDIO_TAPE DEFINE_USB_TERMINAL_GUID(0x0704)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E4-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DAT_IO_DIGITAL_AUDIO_TAPE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DAT_IO_DIGITAL_AUDIO_TAPE DEFINE_GUIDNAMED(KSNODETYPE_DAT_IO_DIGITAL_AUDIO_TAPE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DCC_IO_DIGITAL_COMPACT_CASSETTE DEFINE_USB_TERMINAL_GUID(0x0705)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E5-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DCC_IO_DIGITAL_COMPACT_CASSETTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DCC_IO_DIGITAL_COMPACT_CASSETTE DEFINE_GUIDNAMED(KSNODETYPE_DCC_IO_DIGITAL_COMPACT_CASSETTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MINIDISK DEFINE_USB_TERMINAL_GUID(0x0706)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E6-F70F-11D0-B917-00A0C9223196", KSNODETYPE_MINIDISK);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MINIDISK DEFINE_GUIDNAMED(KSNODETYPE_MINIDISK)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ANALOG_TAPE DEFINE_USB_TERMINAL_GUID(0x0707)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E7-F70F-11D0-B917-00A0C9223196", KSNODETYPE_ANALOG_TAPE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ANALOG_TAPE DEFINE_GUIDNAMED(KSNODETYPE_ANALOG_TAPE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PHONOGRAPH DEFINE_USB_TERMINAL_GUID(0x0708)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E8-F70F-11D0-B917-00A0C9223196", KSNODETYPE_PHONOGRAPH);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PHONOGRAPH DEFINE_GUIDNAMED(KSNODETYPE_PHONOGRAPH)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VCR_AUDIO DEFINE_USB_TERMINAL_GUID(0x0708)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220E9-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VCR_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VCR_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_VCR_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_DISC_AUDIO DEFINE_USB_TERMINAL_GUID(0x070A)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220EA-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_DISC_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_DISC_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_DISC_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DVD_AUDIO DEFINE_USB_TERMINAL_GUID(0x070B)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220EB-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DVD_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DVD_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_DVD_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_TV_TUNER_AUDIO DEFINE_USB_TERMINAL_GUID(0x070C)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220EC-F70F-11D0-B917-00A0C9223196", KSNODETYPE_TV_TUNER_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_TV_TUNER_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_TV_TUNER_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SATELLITE_RECEIVER_AUDIO DEFINE_USB_TERMINAL_GUID(0x070D)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220ED-F70F-11D0-B917-00A0C9223196", KSNODETYPE_SATELLITE_RECEIVER_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SATELLITE_RECEIVER_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_SATELLITE_RECEIVER_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_CABLE_TUNER_AUDIO DEFINE_USB_TERMINAL_GUID(0x070E)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220EE-F70F-11D0-B917-00A0C9223196", KSNODETYPE_CABLE_TUNER_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_CABLE_TUNER_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_CABLE_TUNER_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DSS_AUDIO DEFINE_USB_TERMINAL_GUID(0x070F)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220EF-F70F-11D0-B917-00A0C9223196", KSNODETYPE_DSS_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DSS_AUDIO DEFINE_GUIDNAMED(KSNODETYPE_DSS_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_RADIO_RECEIVER DEFINE_USB_TERMINAL_GUID(0x0710)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220F0-F70F-11D0-B917-00A0C9223196", KSNODETYPE_RADIO_RECEIVER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_RADIO_RECEIVER DEFINE_GUIDNAMED(KSNODETYPE_RADIO_RECEIVER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_RADIO_TRANSMITTER DEFINE_USB_TERMINAL_GUID(0x0711)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220F1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_RADIO_TRANSMITTER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_RADIO_TRANSMITTER DEFINE_GUIDNAMED(KSNODETYPE_RADIO_TRANSMITTER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MULTITRACK_RECORDER DEFINE_USB_TERMINAL_GUID(0x0712)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220F2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_MULTITRACK_RECORDER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MULTITRACK_RECORDER DEFINE_GUIDNAMED(KSNODETYPE_MULTITRACK_RECORDER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SYNTHESIZER DEFINE_USB_TERMINAL_GUID(0x0713)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF220F3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_SYNTHESIZER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SYNTHESIZER DEFINE_GUIDNAMED(KSNODETYPE_SYNTHESIZER)

// Microsoft's WDMAUD virtual swsynth pin name guid

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SWSYNTH 0x423274A0L, 0x8B81, 0x11D1, 0xA0, 0x50, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("423274A0-8B81-11D1-A050-0000F8004788", KSNODETYPE_SWSYNTH);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SWSYNTH DEFINE_GUIDNAMED(KSNODETYPE_SWSYNTH)

// Microsoft's SWMIDI midi pin and node name guid

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SWMIDI 0xCB9BEFA0L, 0xA251, 0x11D1, 0xA0, 0x50, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("CB9BEFA0-A251-11D1-A050-0000F8004788", KSNODETYPE_SWMIDI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SWMIDI DEFINE_GUIDNAMED(KSNODETYPE_SWMIDI)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DRM_DESCRAMBLE 0xFFBB6E3FL, 0xCCFE, 0x4D84, 0x90, 0xD9, 0x42, 0x14, 0x18, 0xB0, 0x3A, 0x8E
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FFBB6E3F-CCFE-4D84-90D9-421418B03A8E", KSNODETYPE_DRM_DESCRAMBLE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DRM_DESCRAMBLE DEFINE_GUIDNAMED(KSNODETYPE_DRM_DESCRAMBLE)

// General categories
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_AUDIO 0x6994AD04L, 0x93EF, 0x11D0, 0xA3, 0xCC, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6994AD04-93EF-11D0-A3CC-00A0C9223196", KSCATEGORY_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_AUDIO DEFINE_GUIDNAMED(KSCATEGORY_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_VIDEO 0x6994AD05L, 0x93EF, 0x11D0, 0xA3, 0xCC, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6994AD05-93EF-11D0-A3CC-00A0C9223196", KSCATEGORY_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_VIDEO DEFINE_GUIDNAMED(KSCATEGORY_VIDEO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_TEXT 0x6994AD06L, 0x93EF, 0x11D0, 0xA3, 0xCC, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6994AD06-93EF-11D0-A3CC-00A0C9223196", KSCATEGORY_TEXT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_TEXT DEFINE_GUIDNAMED(KSCATEGORY_TEXT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_NETWORK 0x67C9CC3CL, 0x69C4, 0x11D2, 0x87, 0x59, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("67C9CC3C-69C4-11D2-8759-00A0C9223196", KSCATEGORY_NETWORK);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_NETWORK DEFINE_GUIDNAMED(KSCATEGORY_NETWORK)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_TOPOLOGY 0xDDA54A40L, 0x1E4C, 0x11D1, 0xA0, 0x50, 0x40, 0x57, 0x05, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DDA54A40-1E4C-11D1-A050-405705C10000", KSCATEGORY_TOPOLOGY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_TOPOLOGY DEFINE_GUIDNAMED(KSCATEGORY_TOPOLOGY)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_VIRTUAL 0x3503EAC4L, 0x1F26, 0x11D1, 0x8A, 0xB0, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("3503EAC4-1F26-11D1-8AB0-00A0C9223196", KSCATEGORY_VIRTUAL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_VIRTUAL DEFINE_GUIDNAMED(KSCATEGORY_VIRTUAL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_ACOUSTIC_ECHO_CANCEL 0xBF963D80L, 0xC559, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("BF963D80-C559-11D0-8A2B-00A0C9255AC1", KSCATEGORY_ACOUSTIC_ECHO_CANCEL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_ACOUSTIC_ECHO_CANCEL DEFINE_GUIDNAMED(KSCATEGORY_ACOUSTIC_ECHO_CANCEL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_SYSAUDIO 0xA7C7A5B1L, 0x5AF3, 0x11D1, 0x9C, 0xED, 0x00, 0xA0, 0x24, 0xBF, 0x04, 0x07
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A7C7A5B1-5AF3-11D1-9CED-00A024BF0407", KSCATEGORY_SYSAUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_SYSAUDIO DEFINE_GUIDNAMED(KSCATEGORY_SYSAUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_WDMAUD 0x3E227E76L, 0x690D, 0x11D2, 0x81, 0x61, 0x00, 0x00, 0xF8, 0x77, 0x5B, 0xF1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("3E227E76-690D-11D2-8161-0000F8775BF1", KSCATEGORY_WDMAUD);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_WDMAUD DEFINE_GUIDNAMED(KSCATEGORY_WDMAUD)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_AUDIO_GFX 0x9BAF9572L, 0x340C, 0x11D3, 0xAB, 0xDC, 0x00, 0xA0, 0xC9, 0x0A, 0xB1, 0x6F
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9BAF9572-340C-11D3-ABDC-00A0C90AB16F", KSCATEGORY_AUDIO_GFX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_AUDIO_GFX DEFINE_GUIDNAMED(KSCATEGORY_AUDIO_GFX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_AUDIO_SPLITTER 0x9EA331FAL, 0xB91B, 0x45F8, 0x92, 0x85, 0xBD, 0x2B, 0xC7, 0x7A, 0xFC, 0xDE
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9EA331FA-B91B-45F8-9285-BD2BC77AFCDE", KSCATEGORY_AUDIO_SPLITTER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_AUDIO_SPLITTER DEFINE_GUIDNAMED(KSCATEGORY_AUDIO_SPLITTER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_SYNTHESIZER STATIC_KSNODETYPE_SYNTHESIZER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_SYNTHESIZER KSNODETYPE_SYNTHESIZER

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_DRM_DESCRAMBLE STATIC_KSNODETYPE_DRM_DESCRAMBLE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_DRM_DESCRAMBLE KSNODETYPE_DRM_DESCRAMBLE

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_AUDIO_DEVICE 0xFBF6F530L, 0x07B9, 0x11D2, 0xA7, 0x1E, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FBF6F530-07B9-11D2-A71E-0000F8004788", KSCATEGORY_AUDIO_DEVICE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_AUDIO_DEVICE DEFINE_GUIDNAMED(KSCATEGORY_AUDIO_DEVICE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_PREFERRED_WAVEOUT_DEVICE 0xD6C5066EL, 0x72C1, 0x11D2, 0x97, 0x55, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("D6C5066E-72C1-11D2-9755-0000F8004788", KSCATEGORY_PREFERRED_WAVEOUT_DEVICE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_PREFERRED_WAVEOUT_DEVICE DEFINE_GUIDNAMED(KSCATEGORY_PREFERRED_WAVEOUT_DEVICE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_PREFERRED_WAVEIN_DEVICE 0xD6C50671L, 0x72C1, 0x11D2, 0x97, 0x55, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("D6C50671-72C1-11D2-9755-0000F8004788", KSCATEGORY_PREFERRED_WAVEIN_DEVICE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_PREFERRED_WAVEIN_DEVICE DEFINE_GUIDNAMED(KSCATEGORY_PREFERRED_WAVEIN_DEVICE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_PREFERRED_MIDIOUT_DEVICE 0xD6C50674L, 0x72C1, 0x11D2, 0x97, 0x55, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("D6C50674-72C1-11D2-9755-0000F8004788", KSCATEGORY_PREFERRED_MIDIOUT_DEVICE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_PREFERRED_MIDIOUT_DEVICE DEFINE_GUIDNAMED(KSCATEGORY_PREFERRED_MIDIOUT_DEVICE)

// Special pin category for wdmaud

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_WDMAUD_USE_PIN_NAME 0x47A4FA20L, 0xA251, 0x11D1, 0xA0, 0x50, 0x00, 0x00, 0xF8, 0x00, 0x47, 0x88
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("47A4FA20-A251-11D1-A050-0000F8004788", KSCATEGORY_WDMAUD_USE_PIN_NAME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_WDMAUD_USE_PIN_NAME DEFINE_GUIDNAMED(KSCATEGORY_WDMAUD_USE_PIN_NAME)

// Escalante Platform Interface

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_ESCALANTE_PLATFORM_DRIVER 0x74f3aea8L, 0x9768, 0x11d1, 0x8e, 0x07, 0x00, 0xa0, 0xc9, 0x5e, 0xc2, 0x2e
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("74f3aea8-9768-11d1-8e07-00a0c95ec22e", KSCATEGORY_ESCALANTE_PLATFORM_DRIVER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_ESCALANTE_PLATFORM_DRIVER DEFINE_GUIDNAMED(KSCATEGORY_ESCALANTE_PLATFORM_DRIVER)

// -- major types ---

// 'vids' == MEDIATYPE_Video,
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_VIDEO 0x73646976L, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("73646976-0000-0010-8000-00aa00389b71", KSDATAFORMAT_TYPE_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_VIDEO)

// 'auds' == MEDIATYPE_Audio
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_AUDIO 0x73647561L, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("73647561-0000-0010-8000-00aa00389b71", KSDATAFORMAT_TYPE_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_AUDIO)

// 'txts' == MEDIATYPE_Text
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_TEXT 0x73747874L, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("73747874-0000-0010-8000-00aa00389b71", KSDATAFORMAT_TYPE_TEXT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_TEXT DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_TEXT)

#if ! DEFINE_WAVEFORMATEX_GUID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_WAVEFORMATEX_GUID(x) (USHORT)(x), 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
#define DEFINE_WAVEFORMATEX_GUID
#endif

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_WAVEFORMATEX 0x00000000L, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000000-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_WAVEFORMATEX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_WAVEFORMATEX DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_WAVEFORMATEX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_WAVEFORMATEX_GUID(Guid, x){ *(Guid) = KSDATAFORMAT_SUBTYPE_WAVEFORMATEX; (Guid)->Data1 = (USHORT)(x);}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EXTRACT_WAVEFORMATEX_ID(Guid) (USHORT)((Guid)->Data1)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IS_VALID_WAVEFORMATEX_GUID(Guid) (!memcmp(((PUSHORT)&KSDATAFORMAT_SUBTYPE_WAVEFORMATEX) + 1, ((PUSHORT)(Guid)) + 1, sizeof(GUID) - sizeof(USHORT)))

#if !INIT_MMREG_MID
// {d5a47fa7-6d98-11d1-a21a-00a0c9223196}
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_MMREG_MID(guid, id){ (guid)->Data1 = 0xd5a47fa7 + (USHORT)(id); (guid)->Data2 = 0x6d98; (guid)->Data3 = 0x11d1; (guid)->Data4[0] = 0xa2; (guid)->Data4[1] = 0x1a; (guid)->Data4[2] = 0x00; (guid)->Data4[3] = 0xa0; (guid)->Data4[4] = 0xc9; (guid)->Data4[5] = 0x22; (guid)->Data4[6] = 0x31; (guid)->Data4[7] = 0x96;}
#define INIT_MMREG_MID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EXTRACT_MMREG_MID(guid) (USHORT)((guid)->Data1 - 0xd5a47fa7)
#define EXTRACT_MMREG_MID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_MMREG_MID_GUID(id) 0xd5a47fa7+(USHORT)(id), 0x6d98, 0x11d1, 0xa2, 0x1a, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96
#define DEFINE_MMREG_MID_GUID

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IS_COMPATIBLE_MMREG_MID(guid) (((guid)->Data1 >= 0xd5a47fa7) && ((guid)->Data1 < 0xd5a47fa7 + 0xffff) && ((guid)->Data2 == 0x6d98) && ((guid)->Data3 == 0x11d1) && ((guid)->Data4[0] == 0xa2) && ((guid)->Data4[1] == 0x1a) && ((guid)->Data4[2] == 0x00) && ((guid)->Data4[3] == 0xa0) && ((guid)->Data4[4] == 0xc9) && ((guid)->Data4[5] == 0x22) && ((guid)->Data4[6] == 0x31) && ((guid)->Data4[7] == 0x96))
#define IS_COMPATIBLE_MMREG_MID
#endif // !defined(INIT_MMREG_MID)

#if !INIT_MMREG_PID
// {e36dc2ac-6d9a-11d1-a21a-00a0c9223196}
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INIT_MMREG_PID(guid, id){ (guid)->Data1 = 0xe36dc2ac + (USHORT)(id); (guid)->Data2 = 0x6d9a; (guid)->Data3 = 0x11d1; (guid)->Data4[0] = 0xa2; (guid)->Data4[1] = 0x1a; (guid)->Data4[2] = 0x00; (guid)->Data4[3] = 0xa0; (guid)->Data4[4] = 0xc9; (guid)->Data4[5] = 0x22; (guid)->Data4[6] = 0x31; (guid)->Data4[7] = 0x96;}
#define INIT_MMREG_PID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EXTRACT_MMREG_PID(guid) (USHORT)((guid)->Data1 - 0xe36dc2ac)
#define EXTRACT_MMREG_PID
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_MMREG_PID_GUID(id) 0xe36dc2ac+(USHORT)(id), 0x6d9a, 0x11d1, 0xa2, 0x1a, 0x00, 0xa0, 0xc9, 0x22, 0x31, 0x96
#define DEFINE_MMREG_PID_GUID

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IS_COMPATIBLE_MMREG_PID(guid) (((guid)->Data1 >= 0xe36dc2ac) && ((guid)->Data1 < 0xe36dc2ac + 0xffff) && ((guid)->Data2 == 0x6d9a) && ((guid)->Data3 == 0x11d1) && ((guid)->Data4[0] == 0xa2) && ((guid)->Data4[1] == 0x1a) && ((guid)->Data4[2] == 0x00) && ((guid)->Data4[3] == 0xa0) && ((guid)->Data4[4] == 0xc9) && ((guid)->Data4[5] == 0x22) && ((guid)->Data4[6] == 0x31) && ((guid)->Data4[7] == 0x96))
#define IS_COMPATIBLE_MMREG_PID
#endif // !defined(INIT_MMREG_PID)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_ANALOG 0x6dba3190L, 0x67bd, 0x11cf, 0xa0, 0xf7, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6dba3190-67bd-11cf-a0f7-0020afd156e4", KSDATAFORMAT_SUBTYPE_ANALOG);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_ANALOG DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_ANALOG)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_PCM DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_PCM)
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000001-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_PCM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_PCM DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_PCM)

#if _INC_MMREG
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_IEEE_FLOAT DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_IEEE_FLOAT)
#define STATIC_KSDATAFORMAT_SUBTYPE_IEEE_FLOAT
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000003-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_IEEE_FLOAT);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_IEEE_FLOAT DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_IEEE_FLOAT)
#define KSDATAFORMAT_SUBTYPE_IEEE_FLOAT

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_DRM DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_DRM)
#define STATIC_KSDATAFORMAT_SUBTYPE_DRM
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000009-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_DRM);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_DRM DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_DRM)
#define KSDATAFORMAT_SUBTYPE_DRM

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_ALAW DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_ALAW)
#define STATIC_KSDATAFORMAT_SUBTYPE_ALAW
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000006-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_ALAW);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_ALAW DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_ALAW)
#define KSDATAFORMAT_SUBTYPE_ALAW

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MULAW DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_MULAW)
#define STATIC_KSDATAFORMAT_SUBTYPE_MULAW
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000007-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_MULAW);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MULAW DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MULAW)
#define KSDATAFORMAT_SUBTYPE_MULAW

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_ADPCM DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_ADPCM)
#define STATIC_KSDATAFORMAT_SUBTYPE_ADPCM
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000002-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_ADPCM);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_ADPCM DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_ADPCM)
#define KSDATAFORMAT_SUBTYPE_ADPCM

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MPEG DEFINE_WAVEFORMATEX_GUID(WAVE_FORMAT_MPEG)
#define STATIC_KSDATAFORMAT_SUBTYPE_MPEG
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00000050-0000-0010-8000-00aa00389b71", KSDATAFORMAT_SUBTYPE_MPEG);
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MPEG DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MPEG)
#define KSDATAFORMAT_SUBTYPE_MPEG
#endif // defined(_INC_MMREG)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_VC_ID 0xAD98D184L, 0xAAC3, 0x11D0, 0xA4, 0x1C, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("AD98D184-AAC3-11D0-A41C-00A0C9223196", KSDATAFORMAT_SPECIFIER_VC_ID);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_VC_ID DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_VC_ID)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_WAVEFORMATEX 0x05589f81L, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("05589f81-c356-11ce-bf01-00aa0055595a", KSDATAFORMAT_SPECIFIER_WAVEFORMATEX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_WAVEFORMATEX DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_WAVEFORMATEX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_DSOUND 0x518590a2L, 0xa184, 0x11d0, 0x85, 0x22, 0x00, 0xc0, 0x4f, 0xd9, 0xba, 0xf3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("518590a2-a184-11d0-8522-00c04fd9baf3", KSDATAFORMAT_SPECIFIER_DSOUND);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_DSOUND DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_DSOUND)

#if _INC_MMSYSTEM || _INC_MMREG
#if ! PACK_PRAGMAS_NOT_SUPPORTED
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack1.h>
#endif
public class KSDATAFORMAT_WAVEFORMATEX
{
    public KSDATAFORMAT DataFormat = new KSDATAFORMAT();
    public WAVEFORMATEX WaveFormatEx = new WAVEFORMATEX();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDATAFORMAT_WAVEFORMATEX *PKSDATAFORMAT_WAVEFORMATEX;

public class WAVEFORMATEXTENSIBLE
{
    public WAVEFORMATEX Format = new WAVEFORMATEX();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        ushort wValidBitsPerSample; // bits of precision
//        ushort wSamplesPerBlock; // valid if wBitsPerSample==0
//        ushort wReserved; // If neither applies, set to zero.
//    }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    Samples;
    public uint dwChannelMask; // which channels are
                                        /* present in stream  */
    public GUID SubFormat = new GUID();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef WAVEFORMATEXTENSIBLE *PWAVEFORMATEXTENSIBLE;

#define WAVE_FORMAT_EXTENSIBLE

// DirectSound buffer description
public class KSDSOUND_BUFFERDESC
{
    public uint Flags;
    public uint Control;
    public WAVEFORMATEX WaveFormatEx = new WAVEFORMATEX();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDSOUND_BUFFERDESC *PKSDSOUND_BUFFERDESC;

// DirectSound format
public class KSDATAFORMAT_DSOUND
{
    public KSDATAFORMAT DataFormat = new KSDATAFORMAT();
    public KSDSOUND_BUFFERDESC BufferDesc = new KSDSOUND_BUFFERDESC();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSDATAFORMAT_DSOUND *PKSDATAFORMAT_DSOUND;

#if ! PACK_PRAGMAS_NOT_SUPPORTED
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>
#endif
#endif // defined(_INC_MMSYSTEM) || defined(_INC_MMREG)



// DirectSound buffer flags

// DirectSound buffer control flags

public class KSAUDIO_POSITION
{
#if _NTDDK_
    public ulong PlayOffset;
    public ulong WriteOffset;
#else // !_NTDDK_
    public ulong PlayOffset;
    public ulong WriteOffset;
#endif // !_NTDDK_
}

// ===========================================================================
// DirectSound3D HAL


public class _DS3DVECTOR
{
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        float x;
//        float dvX;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        float y;
//        float dvY;
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        float z;
//        float dvZ;
//    };
}


// ===========================================================================
// ===========================================================================

// KSPROPSETID_DirectSound3DListener : {437B3414-D060-11d0-8583-00C04FD9BAF3}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_DirectSound3DListener 0x437b3414L, 0xd060, 0x11d0, 0x85, 0x83, 0x00, 0xc0, 0x4f, 0xd9, 0xba, 0xf3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("437b3414-d060-11d0-8583-00c04fd9baf3",KSPROPSETID_DirectSound3DListener);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_DirectSound3DListener DEFINE_GUIDNAMED(KSPROPSETID_DirectSound3DListener)

public enum KSPROPERTY_DIRECTSOUND3DLISTENER
{
    KSPROPERTY_DIRECTSOUND3DLISTENER_ALL,
    KSPROPERTY_DIRECTSOUND3DLISTENER_POSITION,
    KSPROPERTY_DIRECTSOUND3DLISTENER_VELOCITY,
    KSPROPERTY_DIRECTSOUND3DLISTENER_ORIENTATION,
    KSPROPERTY_DIRECTSOUND3DLISTENER_DISTANCEFACTOR,
    KSPROPERTY_DIRECTSOUND3DLISTENER_ROLLOFFFACTOR,
    KSPROPERTY_DIRECTSOUND3DLISTENER_DOPPLERFACTOR,
    KSPROPERTY_DIRECTSOUND3DLISTENER_BATCH,
    KSPROPERTY_DIRECTSOUND3DLISTENER_ALLOCATION
}

public class KSDS3D_LISTENER_ALL
{
    public _DS3DVECTOR Position = new _DS3DVECTOR();
    public _DS3DVECTOR Velocity = new _DS3DVECTOR();
    public _DS3DVECTOR OrientFront = new _DS3DVECTOR();
    public _DS3DVECTOR OrientTop = new _DS3DVECTOR();
    public float DistanceFactor;
    public float RolloffFactor;
    public float DopplerFactor;
}

public class KSDS3D_LISTENER_ORIENTATION
{
    public _DS3DVECTOR Front = new _DS3DVECTOR();
    public _DS3DVECTOR Top = new _DS3DVECTOR();
}


// ===========================================================================
// ===========================================================================
// KSPROPSETID_DirectSound3DBuffer : {437B3411-D060-11d0-8583-00C04FD9BAF3}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_DirectSound3DBuffer 0x437b3411L, 0xd060, 0x11d0, 0x85, 0x83, 0x00, 0xc0, 0x4f, 0xd9, 0xba, 0xf3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("437b3411-d060-11d0-8583-00c04fd9baf3", KSPROPSETID_DirectSound3DBuffer);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_DirectSound3DBuffer DEFINE_GUIDNAMED(KSPROPSETID_DirectSound3DBuffer)


public enum KSPROPERTY_DIRECTSOUND3DBUFFER
{
    KSPROPERTY_DIRECTSOUND3DBUFFER_ALL,
    KSPROPERTY_DIRECTSOUND3DBUFFER_POSITION,
    KSPROPERTY_DIRECTSOUND3DBUFFER_VELOCITY,
    KSPROPERTY_DIRECTSOUND3DBUFFER_CONEANGLES,
    KSPROPERTY_DIRECTSOUND3DBUFFER_CONEORIENTATION,
    KSPROPERTY_DIRECTSOUND3DBUFFER_CONEOUTSIDEVOLUME,
    KSPROPERTY_DIRECTSOUND3DBUFFER_MINDISTANCE,
    KSPROPERTY_DIRECTSOUND3DBUFFER_MAXDISTANCE,
    KSPROPERTY_DIRECTSOUND3DBUFFER_MODE
}


public class KSDS3D_BUFFER_ALL
{
    public _DS3DVECTOR Position = new _DS3DVECTOR();
    public _DS3DVECTOR Velocity = new _DS3DVECTOR();
    public uint InsideConeAngle;
    public uint OutsideConeAngle;
    public _DS3DVECTOR ConeOrientation = new _DS3DVECTOR();
    public int ConeOutsideVolume;
    public float MinDistance;
    public float MaxDistance;
    public uint Mode;
}

public class KSDS3D_BUFFER_CONE_ANGLES
{
    public uint InsideConeAngle;
    public uint OutsideConeAngle;
}



public class KSDATARANGE_AUDIO
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public uint MaximumChannels;
   public uint MinimumBitsPerSample;
   public uint MaximumBitsPerSample;
   public uint MinimumSampleFrequency;
   public uint MaximumSampleFrequency;
}

// ---------------------------------------------------------------------------

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_RIFF 0x4995DAEEL, 0x9EE6, 0x11D0, 0xA4, 0x0E, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("4995DAEE-9EE6-11D0-A40E-00A0C9223196", KSDATAFORMAT_SUBTYPE_RIFF);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_RIFF DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_RIFF)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_RIFFWAVE 0xe436eb8bL, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e436eb8b-524f-11ce-9f53-0020af0ba770", KSDATAFORMAT_SUBTYPE_RIFFWAVE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_RIFFWAVE DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_RIFFWAVE)

// ===========================================================================
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Bibliographic 0x07BA150EL, 0xE2B1, 0x11D0, 0xAC, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("07BA150E-E2B1-11D0-AC17-00A0C9223196", KSPROPSETID_Bibliographic);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Bibliographic DEFINE_GUIDNAMED(KSPROPSETID_Bibliographic)

// Repeatable tags contain all entries within the property, each preceeded by length
public enum KSPROPERTY_BIBLIOGRAPHIC
{
    KSPROPERTY_BIBLIOGRAPHIC_LEADER = 'RDL ',
    KSPROPERTY_BIBLIOGRAPHIC_LCCN = '010 ',
    KSPROPERTY_BIBLIOGRAPHIC_ISBN = '020 ',
    KSPROPERTY_BIBLIOGRAPHIC_ISSN = '220 ',
    KSPROPERTY_BIBLIOGRAPHIC_CATALOGINGSOURCE = '040 ',
    KSPROPERTY_BIBLIOGRAPHIC_MAINPERSONALNAME = '001 ',
    KSPROPERTY_BIBLIOGRAPHIC_MAINCORPORATEBODY = '011 ',
    KSPROPERTY_BIBLIOGRAPHIC_MAINMEETINGNAME = '111 ',
    KSPROPERTY_BIBLIOGRAPHIC_MAINUNIFORMTITLE = '031 ',
    KSPROPERTY_BIBLIOGRAPHIC_UNIFORMTITLE = '042 ',
    KSPROPERTY_BIBLIOGRAPHIC_TITLESTATEMENT = '542 ',
    KSPROPERTY_BIBLIOGRAPHIC_VARYINGFORMTITLE = '642 ',
    KSPROPERTY_BIBLIOGRAPHIC_PUBLICATION = '062 ',
    KSPROPERTY_BIBLIOGRAPHIC_PHYSICALDESCRIPTION = '003 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDENTRYTITLE = '044 ',
    KSPROPERTY_BIBLIOGRAPHIC_SERIESSTATEMENT = '094 ',
    KSPROPERTY_BIBLIOGRAPHIC_GENERALNOTE = '005 ',
    KSPROPERTY_BIBLIOGRAPHIC_BIBLIOGRAPHYNOTE = '405 ',
    KSPROPERTY_BIBLIOGRAPHIC_CONTENTSNOTE = '505 ',
    KSPROPERTY_BIBLIOGRAPHIC_CREATIONCREDIT = '805 ',
    KSPROPERTY_BIBLIOGRAPHIC_CITATION = '015 ',
    KSPROPERTY_BIBLIOGRAPHIC_PARTICIPANT = '115 ',
    KSPROPERTY_BIBLIOGRAPHIC_SUMMARY = '025 ',
    KSPROPERTY_BIBLIOGRAPHIC_TARGETAUDIENCE = '125 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDFORMAVAILABLE = '035 ',
    KSPROPERTY_BIBLIOGRAPHIC_SYSTEMDETAILS = '835 ',
    KSPROPERTY_BIBLIOGRAPHIC_AWARDS = '685 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDENTRYPERSONALNAME = '006 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDENTRYTOPICALTERM = '056 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDENTRYGEOGRAPHIC = '156 ',
    KSPROPERTY_BIBLIOGRAPHIC_INDEXTERMGENRE = '556 ',
    KSPROPERTY_BIBLIOGRAPHIC_INDEXTERMCURRICULUM = '856 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDENTRYUNIFORMTITLE = '037 ',
    KSPROPERTY_BIBLIOGRAPHIC_ADDEDENTRYRELATED = '047 ',
    KSPROPERTY_BIBLIOGRAPHIC_SERIESSTATEMENTPERSONALNAME = '008 ',
    KSPROPERTY_BIBLIOGRAPHIC_SERIESSTATEMENTUNIFORMTITLE = '038 '
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_TopologyNode 0x45FFAAA1L, 0x6E1B, 0x11D0, 0xBC, 0xF2, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("45FFAAA1-6E1B-11D0-BCF2-444553540000", KSPROPSETID_TopologyNode);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_TopologyNode DEFINE_GUIDNAMED(KSPROPSETID_TopologyNode)

public enum KSPROPERTY_TOPOLOGYNODE
{
    KSPROPERTY_TOPOLOGYNODE_ENABLE = 1,
    KSPROPERTY_TOPOLOGYNODE_RESET
}

// ===========================================================================

#if _NTDDK_
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef NTSTATUS(CALLBACK *PRTAUDIOGETPOSITION)(IN PFILE_OBJECT PinFileObject, OUT byte **ppPlayPosition, OUT int * plOffset);
public delegate NTSTATUS PRTAUDIOGETPOSITION(IN PFILE_OBJECT PinFileObject, OUT byte[] ppPlayPosition, OUT int plOffset);
#endif // defined(_NTDDK_)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_RtAudio 0xa855a48c, 0x2f78, 0x4729, 0x90, 0x51, 0x19, 0x68, 0x74, 0x6b, 0x9e, 0xef
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A855A48C-2F78-4729-9051-1968746B9EEF", KSPROPSETID_RtAudio);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_RtAudio DEFINE_GUIDNAMED(KSPROPSETID_RtAudio)

public enum KSPROPERTY_RTAUDIO
{
    KSPROPERTY_RTAUDIO_GETPOSITIONFUNCTION
}

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_DrmAudioStream 0x2f2c8ddd, 0x4198, 0x4fac, 0xba, 0x29, 0x61, 0xbb, 0x5, 0xb7, 0xde, 0x6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2F2C8DDD-4198-4fac-BA29-61BB05B7DE06", KSPROPSETID_DrmAudioStream);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_DrmAudioStream DEFINE_GUIDNAMED(KSPROPSETID_DrmAudioStream)

public enum KSPROPERTY_DRMAUDIOSTREAM
{
    KSPROPERTY_DRMAUDIOSTREAM_CONTENTID
}

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Audio 0x45FFAAA0L, 0x6E1B, 0x11D0, 0xBC, 0xF2, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("45FFAAA0-6E1B-11D0-BCF2-444553540000", KSPROPSETID_Audio);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Audio DEFINE_GUIDNAMED(KSPROPSETID_Audio)

public enum KSPROPERTY_AUDIO
{
    KSPROPERTY_AUDIO_LATENCY = 1,
    KSPROPERTY_AUDIO_COPY_PROTECTION,
    KSPROPERTY_AUDIO_CHANNEL_CONFIG,
    KSPROPERTY_AUDIO_VOLUMELEVEL,
    KSPROPERTY_AUDIO_POSITION,
    KSPROPERTY_AUDIO_DYNAMIC_RANGE,
    KSPROPERTY_AUDIO_QUALITY,
    KSPROPERTY_AUDIO_SAMPLING_RATE,
    KSPROPERTY_AUDIO_DYNAMIC_SAMPLING_RATE,
    KSPROPERTY_AUDIO_MIX_LEVEL_TABLE,
    KSPROPERTY_AUDIO_MIX_LEVEL_CAPS,
    KSPROPERTY_AUDIO_MUX_SOURCE,
    KSPROPERTY_AUDIO_MUTE,
    KSPROPERTY_AUDIO_BASS,
    KSPROPERTY_AUDIO_MID,
    KSPROPERTY_AUDIO_TREBLE,
    KSPROPERTY_AUDIO_BASS_BOOST,
    KSPROPERTY_AUDIO_EQ_LEVEL,
    KSPROPERTY_AUDIO_NUM_EQ_BANDS,
    KSPROPERTY_AUDIO_EQ_BANDS,
    KSPROPERTY_AUDIO_AGC,
    KSPROPERTY_AUDIO_DELAY,
    KSPROPERTY_AUDIO_LOUDNESS,
    KSPROPERTY_AUDIO_WIDE_MODE,
    KSPROPERTY_AUDIO_WIDENESS,
    KSPROPERTY_AUDIO_REVERB_LEVEL,
    KSPROPERTY_AUDIO_CHORUS_LEVEL,
    KSPROPERTY_AUDIO_DEV_SPECIFIC,
    KSPROPERTY_AUDIO_DEMUX_DEST,
    KSPROPERTY_AUDIO_STEREO_ENHANCE,
    KSPROPERTY_AUDIO_MANUFACTURE_GUID,
    KSPROPERTY_AUDIO_PRODUCT_GUID,
    KSPROPERTY_AUDIO_CPU_RESOURCES,
    KSPROPERTY_AUDIO_STEREO_SPEAKER_GEOMETRY,
    KSPROPERTY_AUDIO_SURROUND_ENCODE,
    KSPROPERTY_AUDIO_3D_INTERFACE,
    KSPROPERTY_AUDIO_PEAKMETER,
    KSPROPERTY_AUDIO_ALGORITHM_INSTANCE,
    KSPROPERTY_AUDIO_FILTER_STATE,
    KSPROPERTY_AUDIO_PREFERRED_STATUS
}

// Audio quality constants

// Audio CPU resource constants

public class KSAUDIO_COPY_PROTECTION
{
    public bool fCopyrighted;
    public bool fOriginal;
}

public class KSAUDIO_CHANNEL_CONFIG
{
    public int ActiveSpeakerPositions;
}

// Speaker Positions:

// Bit mask locations reserved for future use

// Used to specify that any possible permutation of speaker configurations

// DirectSound Speaker Config
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_MONO (SPEAKER_FRONT_CENTER)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_STEREO (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_QUAD (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_BACK_CENTER)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_5POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_7POINT1 (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_FRONT_LEFT_OF_CENTER | SPEAKER_FRONT_RIGHT_OF_CENTER)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_5POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_7POINT1_SURROUND (SPEAKER_FRONT_LEFT | SPEAKER_FRONT_RIGHT | SPEAKER_FRONT_CENTER | SPEAKER_LOW_FREQUENCY | SPEAKER_BACK_LEFT | SPEAKER_BACK_RIGHT | SPEAKER_SIDE_LEFT | SPEAKER_SIDE_RIGHT)
// The following are obsolete 5.1 and 7.1 settings (they lack side speakers).  Note this means
// that the default 5.1 and 7.1 settings (KSAUDIO_SPEAKER_5POINT1 and KSAUDIO_SPEAKER_7POINT1 are
// similarly obsolete but are unchanged for compatibility reasons).
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_5POINT1_BACK KSAUDIO_SPEAKER_5POINT1
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_7POINT1_WIDE KSAUDIO_SPEAKER_7POINT1

// DVD Speaker Positions
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_GROUND_FRONT_LEFT SPEAKER_FRONT_LEFT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_GROUND_FRONT_CENTER SPEAKER_FRONT_CENTER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_GROUND_FRONT_RIGHT SPEAKER_FRONT_RIGHT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_GROUND_REAR_LEFT SPEAKER_BACK_LEFT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_GROUND_REAR_RIGHT SPEAKER_BACK_RIGHT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_TOP_MIDDLE SPEAKER_TOP_CENTER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDIO_SPEAKER_SUPER_WOOFER SPEAKER_LOW_FREQUENCY

public class KSAUDIO_DYNAMIC_RANGE
{
    public uint QuietCompression;
    public uint LoudCompression;
}

public class KSAUDIO_MIXLEVEL
{
    public bool Mute;
    public int Level;
}

public class KSAUDIO_MIX_CAPS
{
    public bool Mute;
    public int Minimum;
    public int Maximum;
    public int Reset;
}

public class KSAUDIO_MIXCAP_TABLE
{
    public uint InputChannels;
    public uint OutputChannels;
    public KSAUDIO_MIX_CAPS[] Capabilities = Arrays.InitializeWithDefaultInstances<KSAUDIO_MIX_CAPS>(1);
}

public enum SE_TECHNIQUE
{
    SE_TECH_NONE,
    SE_TECH_ANALOG_DEVICES_PHAT,
    SE_TECH_CREATIVE,
    SE_TECH_NATIONAL_SEMI,
    SE_TECH_YAMAHA_YMERSION,
    SE_TECH_BBE,
    SE_TECH_CRYSTAL_SEMI,
    SE_TECH_QSOUND_QXPANDER,
    SE_TECH_SPATIALIZER,
    SE_TECH_SRS,
    SE_TECH_PLATFORM_TECH,
    SE_TECH_AKM,
    SE_TECH_AUREAL,
    SE_TECH_AZTECH,
    SE_TECH_BINAURA,
    SE_TECH_ESS_TECH,
    SE_TECH_HARMAN_VMAX,
    SE_TECH_NVIDEA,
    SE_TECH_PHILIPS_INCREDIBLE,
    SE_TECH_TEXAS_INST,
    SE_TECH_VLSI_TECH
}

public class KSAUDIO_STEREO_ENHANCE
{
    public SE_TECHNIQUE Technique;
    public uint Center;
    public uint Depth;
    public uint Reserved;
}

public enum KSPROPERTY_SYSAUDIO_DEFAULT_TYPE
{ // preferred device index
    KSPROPERTY_SYSAUDIO_NORMAL_DEFAULT = 0,
    KSPROPERTY_SYSAUDIO_PLAYBACK_DEFAULT,
    KSPROPERTY_SYSAUDIO_RECORD_DEFAULT,
    KSPROPERTY_SYSAUDIO_MIDI_DEFAULT,
    KSPROPERTY_SYSAUDIO_MIXER_DEFAULT
}

public class KSAUDIO_PREFERRED_STATUS
{
    public bool Enable;
    public KSPROPERTY_SYSAUDIO_DEFAULT_TYPE DeviceType;
    public uint Flags;
    public uint Reserved;
}
// ===========================================================================
// Topology Node Type GUIDs

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DAC 0x507AE360L, 0xC554, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("507AE360-C554-11D0-8A2B-00A0C9255AC1", KSNODETYPE_DAC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DAC DEFINE_GUIDNAMED(KSNODETYPE_DAC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ADC 0x4D837FE0L, 0xC555, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("4D837FE0-C555-11D0-8A2B-00A0C9255AC1", KSNODETYPE_ADC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ADC DEFINE_GUIDNAMED(KSNODETYPE_ADC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SRC 0x9DB7B9E0L, 0xC555, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9DB7B9E0-C555-11D0-8A2B-00A0C9255AC1", KSNODETYPE_SRC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SRC DEFINE_GUIDNAMED(KSNODETYPE_SRC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SUPERMIX 0xE573ADC0L, 0xC555, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E573ADC0-C555-11D0-8A2B-00A0C9255AC1", KSNODETYPE_SUPERMIX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SUPERMIX DEFINE_GUIDNAMED(KSNODETYPE_SUPERMIX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MUX 0x2CEAF780L, 0xC556, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2CEAF780-C556-11D0-8A2B-00A0C9255AC1", KSNODETYPE_MUX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MUX DEFINE_GUIDNAMED(KSNODETYPE_MUX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DEMUX 0xC0EB67D4L, 0xE807, 0x11D0, 0x95, 0x8A, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C0EB67D4-E807-11D0-958A-00C04FB925D3", KSNODETYPE_DEMUX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DEMUX DEFINE_GUIDNAMED(KSNODETYPE_DEMUX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_SUM 0xDA441A60L, 0xC556, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DA441A60-C556-11D0-8A2B-00A0C9255AC1", KSNODETYPE_SUM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SUM DEFINE_GUIDNAMED(KSNODETYPE_SUM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MUTE 0x02B223C0L, 0xC557, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("02B223C0-C557-11D0-8A2B-00A0C9255AC1", KSNODETYPE_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MUTE DEFINE_GUIDNAMED(KSNODETYPE_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VOLUME 0x3A5ACC00L, 0xC557, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("3A5ACC00-C557-11D0-8A2B-00A0C9255AC1", KSNODETYPE_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VOLUME DEFINE_GUIDNAMED(KSNODETYPE_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_TONE 0x7607E580L, 0xC557, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7607E580-C557-11D0-8A2B-00A0C9255AC1", KSNODETYPE_TONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_TONE DEFINE_GUIDNAMED(KSNODETYPE_TONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_EQUALIZER 0x9D41B4A0L, 0xC557, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9D41B4A0-C557-11D0-8A2B-00A0C9255AC1", KSNODETYPE_EQUALIZER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_EQUALIZER DEFINE_GUIDNAMED(KSNODETYPE_EQUALIZER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_AGC 0xE88C9BA0L, 0xC557, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E88C9BA0-C557-11D0-8A2B-00A0C9255AC1", KSNODETYPE_AGC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_AGC DEFINE_GUIDNAMED(KSNODETYPE_AGC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_NOISE_SUPPRESS 0xe07f903f, 0x62fd, 0x4e60, 0x8c, 0xdd, 0xde, 0xa7, 0x23, 0x66, 0x65, 0xb5
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E07F903F-62FD-4e60-8CDD-DEA7236665B5", KSNODETYPE_NOISE_SUPPRESS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_NOISE_SUPPRESS DEFINE_GUIDNAMED(KSNODETYPE_NOISE_SUPPRESS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DELAY 0x144981E0L, 0xC558, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("144981E0-C558-11D0-8A2B-00A0C9255AC1", KSNODETYPE_DELAY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DELAY DEFINE_GUIDNAMED(KSNODETYPE_DELAY)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_LOUDNESS 0x41887440L, 0xC558, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("41887440-C558-11D0-8A2B-00A0C9255AC1", KSNODETYPE_LOUDNESS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_LOUDNESS DEFINE_GUIDNAMED(KSNODETYPE_LOUDNESS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PROLOGIC_DECODER 0x831C2C80L, 0xC558, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("831C2C80-C558-11D0-8A2B-00A0C9255AC1", KSNODETYPE_PROLOGIC_DECODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PROLOGIC_DECODER DEFINE_GUIDNAMED(KSNODETYPE_PROLOGIC_DECODER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_STEREO_WIDE 0xA9E69800L, 0xC558, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A9E69800-C558-11D0-8A2B-00A0C9255AC1", KSNODETYPE_STEREO_WIDE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_STEREO_WIDE DEFINE_GUIDNAMED(KSNODETYPE_STEREO_WIDE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_STEREO_ENHANCE 0xAF6878ACL, 0xE83F, 0x11D0, 0x95, 0x8A, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("AF6878AC-E83F-11D0-958A-00C04FB925D3", KSNODETYPE_STEREO_ENHANCE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_STEREO_ENHANCE DEFINE_GUIDNAMED(KSNODETYPE_STEREO_ENHANCE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_REVERB 0xEF0328E0L, 0xC558, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("EF0328E0-C558-11D0-8A2B-00A0C9255AC1", KSNODETYPE_REVERB);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_REVERB DEFINE_GUIDNAMED(KSNODETYPE_REVERB)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_CHORUS 0x20173F20L, 0xC559, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("20173F20-C559-11D0-8A2B-00A0C9255AC1", KSNODETYPE_CHORUS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_CHORUS DEFINE_GUIDNAMED(KSNODETYPE_CHORUS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_3D_EFFECTS 0x55515860L, 0xC559, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("55515860-C559-11D0-8A2B-00A0C9255AC1", KSNODETYPE_3D_EFFECTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_3D_EFFECTS DEFINE_GUIDNAMED(KSNODETYPE_3D_EFFECTS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_ACOUSTIC_ECHO_CANCEL STATIC_KSCATEGORY_ACOUSTIC_ECHO_CANCEL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_ACOUSTIC_ECHO_CANCEL KSCATEGORY_ACOUSTIC_ECHO_CANCEL

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSALGORITHMINSTANCE_SYSTEM_ACOUSTIC_ECHO_CANCEL 0x1c22c56dL, 0x9879, 0x4f5b, 0xa3, 0x89, 0x27, 0x99, 0x6d, 0xdc, 0x28, 0x10
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1C22C56D-9879-4f5b-A389-27996DDC2810", KSALGORITHMINSTANCE_SYSTEM_ACOUSTIC_ECHO_CANCEL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSALGORITHMINSTANCE_SYSTEM_ACOUSTIC_ECHO_CANCEL DEFINE_GUIDNAMED(KSALGORITHMINSTANCE_SYSTEM_ACOUSTIC_ECHO_CANCEL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSALGORITHMINSTANCE_SYSTEM_NOISE_SUPPRESS 0x5ab0882eL, 0x7274, 0x4516, 0x87, 0x7d, 0x4e, 0xee, 0x99, 0xba, 0x4f, 0xd0
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("5AB0882E-7274-4516-877D-4EEE99BA4FD0", KSALGORITHMINSTANCE_SYSTEM_NOISE_SUPPRESS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSALGORITHMINSTANCE_SYSTEM_NOISE_SUPPRESS DEFINE_GUIDNAMED(KSALGORITHMINSTANCE_SYSTEM_NOISE_SUPPRESS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSALGORITHMINSTANCE_SYSTEM_AGC 0x950e55b9L, 0x877c, 0x4c67, 0xbe, 0x8, 0xe4, 0x7b, 0x56, 0x11, 0x13, 0xa
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("950E55B9-877C-4c67-BE08-E47B5611130A", KSALGORITHMINSTANCE_SYSTEM_AGC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSALGORITHMINSTANCE_SYSTEM_AGC DEFINE_GUIDNAMED(KSALGORITHMINSTANCE_SYSTEM_AGC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSALGORITHMINSTANCE_SYSTEM_MICROPHONE_ARRAY_PROCESSOR 0xB6F5A0A0L, 0x9E61, 0x4F8C, 0x91, 0xE3, 0x76, 0xCF, 0xF, 0x3C, 0x47, 0x1F
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("B6F5A0A0-9E61-4f8c-91E3-76CF0F3C471F", KSALGORITHMINSTANCE_SYSTEM_MICROPHONE_ARRAY_PROCESSOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSALGORITHMINSTANCE_SYSTEM_MICROPHONE_ARRAY_PROCESSOR DEFINE_GUIDNAMED(KSALGORITHMINSTANCE_SYSTEM_MICROPHONE_ARRAY_PROCESSOR)


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_MICROPHONE_ARRAY_PROCESSOR STATIC_KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_MICROPHONE_ARRAY_PROCESSOR KSCATEGORY_MICROPHONE_ARRAY_PROCESSOR

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_DEV_SPECIFIC 0x941C7AC0L, 0xC559, 0x11D0, 0x8A, 0x2B, 0x00, 0xA0, 0xC9, 0x25, 0x5A, 0xC1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("941C7AC0-C559-11D0-8A2B-00A0C9255AC1", KSNODETYPE_DEV_SPECIFIC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_DEV_SPECIFIC DEFINE_GUIDNAMED(KSNODETYPE_DEV_SPECIFIC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PROLOGIC_ENCODER 0x8074C5B2L, 0x3C66, 0x11D2, 0xB4, 0x5A, 0x30, 0x78, 0x30, 0x2C, 0x20, 0x30
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("8074C5B2-3C66-11D2-B45A-3078302C2030", KSNODETYPE_PROLOGIC_ENCODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PROLOGIC_ENCODER DEFINE_GUIDNAMED(KSNODETYPE_PROLOGIC_ENCODER)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_SURROUND_ENCODER KSNODETYPE_PROLOGIC_ENCODER

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_PEAKMETER 0xa085651eL, 0x5f0d, 0x4b36, 0xa8, 0x69, 0xd1, 0x95, 0xd6, 0xab, 0x4b, 0x9e
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A085651E-5F0D-4b36-A869-D195D6AB4B9E", KSNODETYPE_PEAKMETER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_PEAKMETER DEFINE_GUIDNAMED(KSNODETYPE_PEAKMETER)

// ===========================================================================
// Topology Node Name GUIDs for common audio nodes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_BASS 0x185FEDE0L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE0-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_BASS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_BASS DEFINE_GUIDNAMED(KSAUDFNAME_BASS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_TREBLE 0x185FEDE1L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE1-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_TREBLE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_TREBLE DEFINE_GUIDNAMED(KSAUDFNAME_TREBLE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_3D_STEREO 0x185FEDE2L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE2-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_3D_STEREO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_3D_STEREO DEFINE_GUIDNAMED(KSAUDFNAME_3D_STEREO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MASTER_VOLUME 0x185FEDE3L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE3-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MASTER_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MASTER_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MASTER_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MASTER_MUTE 0x185FEDE4L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE4-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MASTER_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MASTER_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_MASTER_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_WAVE_VOLUME 0x185FEDE5L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE5-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_WAVE_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_WAVE_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_WAVE_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_WAVE_MUTE 0x185FEDE6L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE6-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_WAVE_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_WAVE_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_WAVE_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIDI_VOLUME 0x185FEDE7L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE7-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIDI_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIDI_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MIDI_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIDI_MUTE 0x185FEDE8L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE8-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIDI_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIDI_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_MIDI_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_CD_VOLUME 0x185FEDE9L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDE9-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_CD_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_CD_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_CD_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_CD_MUTE 0x185FEDEAL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDEA-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_CD_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_CD_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_CD_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_LINE_VOLUME 0x185FEDEBL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDEB-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_LINE_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_LINE_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_LINE_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_LINE_MUTE 0x185FEDECL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDEC-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_LINE_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_LINE_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_LINE_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIC_VOLUME 0x185FEDEDL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDED-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIC_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIC_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MIC_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIC_MUTE 0x185FEDEEL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDEE-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIC_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIC_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_MIC_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_RECORDING_SOURCE 0x185FEDEFL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDEF-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_RECORDING_SOURCE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_RECORDING_SOURCE DEFINE_GUIDNAMED(KSAUDFNAME_RECORDING_SOURCE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_PC_SPEAKER_VOLUME 0x185FEDF0L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF0-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_PC_SPEAKER_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_PC_SPEAKER_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_PC_SPEAKER_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_PC_SPEAKER_MUTE 0x185FEDF1L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF1-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_PC_SPEAKER_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_PC_SPEAKER_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_PC_SPEAKER_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIDI_IN_VOLUME 0x185FEDF2L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF2-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIDI_IN_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIDI_IN_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MIDI_IN_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_CD_IN_VOLUME 0x185FEDF3L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF3-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_CD_IN_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_CD_IN_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_CD_IN_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_LINE_IN_VOLUME 0x185FEDF4L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF4-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_LINE_IN_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_LINE_IN_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_LINE_IN_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIC_IN_VOLUME 0x185FEDF5L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF5-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIC_IN_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIC_IN_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MIC_IN_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_WAVE_IN_VOLUME 0x185FEDF6L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF6-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_WAVE_IN_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_WAVE_IN_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_WAVE_IN_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_VOLUME_CONTROL 0x185FEDF7L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF7-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_VOLUME_CONTROL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_VOLUME_CONTROL DEFINE_GUIDNAMED(KSAUDFNAME_VOLUME_CONTROL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MIDI 0x185FEDF8L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF8-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_MIDI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MIDI DEFINE_GUIDNAMED(KSAUDFNAME_MIDI)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_LINE_IN 0x185FEDF9L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDF9-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_LINE_IN);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_LINE_IN DEFINE_GUIDNAMED(KSAUDFNAME_LINE_IN)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_RECORDING_CONTROL 0x185FEDFAL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDFA-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_RECORDING_CONTROL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_RECORDING_CONTROL DEFINE_GUIDNAMED(KSAUDFNAME_RECORDING_CONTROL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_CD_AUDIO 0x185FEDFBL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDFB-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_CD_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_CD_AUDIO DEFINE_GUIDNAMED(KSAUDFNAME_CD_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_AUX_VOLUME 0x185FEDFCL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDFC-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_AUX_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_AUX_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_AUX_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_AUX_MUTE 0x185FEDFDL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDFD-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_AUX_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_AUX_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_AUX_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_AUX 0x185FEDFEL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDFE-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_AUX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_AUX DEFINE_GUIDNAMED(KSAUDFNAME_AUX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_PC_SPEAKER 0x185FEDFFL, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEDFF-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_PC_SPEAKER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_PC_SPEAKER DEFINE_GUIDNAMED(KSAUDFNAME_PC_SPEAKER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_WAVE_OUT_MIX 0x185FEE00L, 0x9905, 0x11D1, 0x95, 0xA9, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("185FEE00-9905-11D1-95A9-00C04FB925D3", KSAUDFNAME_WAVE_OUT_MIX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_WAVE_OUT_MIX DEFINE_GUIDNAMED(KSAUDFNAME_WAVE_OUT_MIX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MONO_OUT 0xf9b41dc3L, 0x96e2, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("F9B41DC3-96E2-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MONO_OUT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MONO_OUT DEFINE_GUIDNAMED(KSAUDFNAME_MONO_OUT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_STEREO_MIX 0xdff077L, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00DFF077-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_STEREO_MIX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_STEREO_MIX DEFINE_GUIDNAMED(KSAUDFNAME_STEREO_MIX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MONO_MIX 0xdff078L, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("00DFF078-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MONO_MIX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MONO_MIX DEFINE_GUIDNAMED(KSAUDFNAME_MONO_MIX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MONO_OUT_VOLUME 0x1ad247ebL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1AD247EB-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MONO_OUT_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MONO_OUT_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MONO_OUT_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MONO_OUT_MUTE 0x1ad247ecL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1AD247EC-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MONO_OUT_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MONO_OUT_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_MONO_OUT_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_STEREO_MIX_VOLUME 0x1ad247edL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1AD247ED-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_STEREO_MIX_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_STEREO_MIX_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_STEREO_MIX_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_STEREO_MIX_MUTE 0x22b0eafdL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("22B0EAFD-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_STEREO_MIX_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_STEREO_MIX_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_STEREO_MIX_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MONO_MIX_VOLUME 0x22b0eafeL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("22B0EAFE-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MONO_MIX_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MONO_MIX_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_MONO_MIX_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MONO_MIX_MUTE 0x2bc31d69L, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2BC31D69-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MONO_MIX_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MONO_MIX_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_MONO_MIX_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_MICROPHONE_BOOST 0x2bc31d6aL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2BC31D6A-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_MICROPHONE_BOOST);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_MICROPHONE_BOOST DEFINE_GUIDNAMED(KSAUDFNAME_MICROPHONE_BOOST)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_ALTERNATE_MICROPHONE 0x2bc31d6bL, 0x96e3, 0x11d2, 0xac, 0x4c, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2BC31D6B-96E3-11d2-AC4C-00C04F8EFB68", KSAUDFNAME_ALTERNATE_MICROPHONE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_ALTERNATE_MICROPHONE DEFINE_GUIDNAMED(KSAUDFNAME_ALTERNATE_MICROPHONE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_3D_DEPTH 0x63ff5747L, 0x991f, 0x11d2, 0xac, 0x4d, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("63FF5747-991F-11d2-AC4D-00C04F8EFB68", KSAUDFNAME_3D_DEPTH);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_3D_DEPTH DEFINE_GUIDNAMED(KSAUDFNAME_3D_DEPTH)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_3D_CENTER 0x9f0670b4L, 0x991f, 0x11d2, 0xac, 0x4d, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9F0670B4-991F-11d2-AC4D-00C04F8EFB68", KSAUDFNAME_3D_CENTER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_3D_CENTER DEFINE_GUIDNAMED(KSAUDFNAME_3D_CENTER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_VIDEO_VOLUME 0x9b46e708L, 0x992a, 0x11d2, 0xac, 0x4d, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9B46E708-992A-11d2-AC4D-00C04F8EFB68", KSAUDFNAME_VIDEO_VOLUME);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_VIDEO_VOLUME DEFINE_GUIDNAMED(KSAUDFNAME_VIDEO_VOLUME)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_VIDEO_MUTE 0x9b46e709L, 0x992a, 0x11d2, 0xac, 0x4d, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9B46E709-992A-11d2-AC4D-00C04F8EFB68", KSAUDFNAME_VIDEO_MUTE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_VIDEO_MUTE DEFINE_GUIDNAMED(KSAUDFNAME_VIDEO_MUTE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_VIDEO 0x915daec4L, 0xa434, 0x11d2, 0xac, 0x52, 0x0, 0xc0, 0x4f, 0x8e, 0xfb, 0x68
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("915DAEC4-A434-11d2-AC52-00C04F8EFB68", KSAUDFNAME_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_VIDEO DEFINE_GUIDNAMED(KSAUDFNAME_VIDEO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSAUDFNAME_PEAKMETER 0x57e24340L, 0xfc5b, 0x4612, 0xa5, 0x62, 0x72, 0xb1, 0x1a, 0x29, 0xdf, 0xae
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("57E24340-FC5B-4612-A562-72B11A29DFAE", KSAUDFNAME_PEAKMETER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSAUDFNAME_PEAKMETER DEFINE_GUIDNAMED(KSAUDFNAME_PEAKMETER)

// Internal topology node pin definitions





// ===========================================================================
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMETHODSETID_Wavetable 0xDCEF31EBL, 0xD907, 0x11D0, 0x95, 0x83, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DCEF31EB-D907-11D0-9583-00C04FB925D3", KSMETHODSETID_Wavetable);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHODSETID_Wavetable DEFINE_GUIDNAMED(KSMETHODSETID_Wavetable)

public enum KSMETHOD_WAVETABLE
{
    KSMETHOD_WAVETABLE_WAVE_ALLOC,
    KSMETHOD_WAVETABLE_WAVE_FREE,
    KSMETHOD_WAVETABLE_WAVE_FIND,
    KSMETHOD_WAVETABLE_WAVE_WRITE
}

public class KSWAVETABLE_WAVE_DESC
{
    public KSIDENTIFIER Identifier = new KSIDENTIFIER(); // wave identifier
    public uint Size; // wave size
    public bool Looped; // wave looped flag
    public uint LoopPoint; // wave loop point
    public bool InROM; // wave InROM flag
    public KSDATAFORMAT Format = new KSDATAFORMAT(); // wave format
}


// ===========================================================================
// ===========================================================================

/*
    Property sets and items
*/

// ===========================================================================
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Acoustic_Echo_Cancel 0xd7a4af8bL, 0x3dc1, 0x4902, 0x91, 0xea, 0x8a, 0x15, 0xc9, 0x0e, 0x05, 0xb2
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("D7A4AF8B-3DC1-4902-91EA-8A15C90E05B2", KSPROPSETID_Acoustic_Echo_Cancel);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Acoustic_Echo_Cancel DEFINE_GUIDNAMED(KSPROPSETID_Acoustic_Echo_Cancel)

public enum KSPROPERTY_AEC
{
    KSPROPERTY_AEC_NOISE_FILL_ENABLE = 0,
    KSPROPERTY_AEC_STATUS,
    KSPROPERTY_AEC_MODE
}



// ===========================================================================
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Wave_Queued 0x16a15b10L, 0x16f0, 0x11d0, 0xa1, 0x95, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("16a15b10-16f0-11d0-a195-0020afd156e4", KSPROPSETID_Wave_Queued);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Wave_Queued DEFINE_GUIDNAMED(KSPROPSETID_Wave_Queued)


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMETHODSETID_Wave_Queued 0x7432c160L, 0x8827, 0x11cf, 0xa1, 0x02, 0x00, 0x20, 0xaf, 0xd1, 0x56, 0xe4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7432c160-8827-11cf-a102-0020afd156e4", KSMETHODSETID_Wave_Queued);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMETHODSETID_Wave_Queued DEFINE_GUIDNAMED(KSMETHODSETID_Wave_Queued)


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Wave 0x924e54b0L, 0x630f, 0x11cf, 0xad, 0xa7, 0x08, 0x00, 0x3e, 0x30, 0x49, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("924e54b0-630f-11cf-ada7-08003e30494a", KSPROPSETID_Wave);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Wave DEFINE_GUIDNAMED(KSPROPSETID_Wave)

public enum KSPROPERTY_WAVE
{
    KSPROPERTY_WAVE_COMPATIBLE_CAPABILITIES,
    KSPROPERTY_WAVE_INPUT_CAPABILITIES,
    KSPROPERTY_WAVE_OUTPUT_CAPABILITIES,
    KSPROPERTY_WAVE_BUFFER,
    KSPROPERTY_WAVE_FREQUENCY,
    KSPROPERTY_WAVE_VOLUME,
    KSPROPERTY_WAVE_PAN
}

public class KSWAVE_COMPATCAPS
{
    public uint ulDeviceType;
}


public class KSWAVE_INPUT_CAPABILITIES
{
    public uint MaximumChannelsPerConnection;
    public uint MinimumBitsPerSample;
    public uint MaximumBitsPerSample;
    public uint MinimumSampleFrequency;
    public uint MaximumSampleFrequency;
    public uint TotalConnections;
    public uint ActiveConnections;
}

public class KSWAVE_OUTPUT_CAPABILITIES
{
    public uint MaximumChannelsPerConnection;
    public uint MinimumBitsPerSample;
    public uint MaximumBitsPerSample;
    public uint MinimumSampleFrequency;
    public uint MaximumSampleFrequency;
    public uint TotalConnections;
    public uint StaticConnections;
    public uint StreamingConnections;
    public uint ActiveConnections;
    public uint ActiveStaticConnections;
    public uint ActiveStreamingConnections;
    public uint Total3DConnections;
    public uint Static3DConnections;
    public uint Streaming3DConnections;
    public uint Active3DConnections;
    public uint ActiveStatic3DConnections;
    public uint ActiveStreaming3DConnections;
    public uint TotalSampleMemory;
    public uint FreeSampleMemory;
    public uint LargestFreeContiguousSampleMemory;
}

public class KSWAVE_VOLUME
{
    public int LeftAttenuation;
    public int RightAttenuation;
}


public class KSWAVE_BUFFER
{
    public uint Attributes;
    public uint BufferSize;
    public object BufferAddress;
}

// ===========================================================================
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMUSIC_TECHNOLOGY_PORT 0x86C92E60L, 0x62E8, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("86C92E60-62E8-11CF-A5D6-28DB04C10000", KSMUSIC_TECHNOLOGY_PORT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMUSIC_TECHNOLOGY_PORT DEFINE_GUIDNAMED(KSMUSIC_TECHNOLOGY_PORT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMUSIC_TECHNOLOGY_SQSYNTH 0x0ECF4380L, 0x62E9, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0ECF4380-62E9-11CF-A5D6-28DB04C10000", KSMUSIC_TECHNOLOGY_SQSYNTH);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMUSIC_TECHNOLOGY_SQSYNTH DEFINE_GUIDNAMED(KSMUSIC_TECHNOLOGY_SQSYNTH)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMUSIC_TECHNOLOGY_FMSYNTH 0x252C5C80L, 0x62E9, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("252C5C80-62E9-11CF-A5D6-28DB04C10000", KSMUSIC_TECHNOLOGY_FMSYNTH);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMUSIC_TECHNOLOGY_FMSYNTH DEFINE_GUIDNAMED(KSMUSIC_TECHNOLOGY_FMSYNTH)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMUSIC_TECHNOLOGY_WAVETABLE 0x394EC7C0L, 0x62E9, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("394EC7C0-62E9-11CF-A5D6-28DB04C10000", KSMUSIC_TECHNOLOGY_WAVETABLE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMUSIC_TECHNOLOGY_WAVETABLE DEFINE_GUIDNAMED(KSMUSIC_TECHNOLOGY_WAVETABLE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSMUSIC_TECHNOLOGY_SWSYNTH 0x37407736L, 0x3620, 0x11D1, 0x85, 0xD3, 0x00, 0x00, 0xF8, 0x75, 0x43, 0x80
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("37407736-3620-11D1-85D3-0000F8754380", KSMUSIC_TECHNOLOGY_SWSYNTH);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSMUSIC_TECHNOLOGY_SWSYNTH DEFINE_GUIDNAMED(KSMUSIC_TECHNOLOGY_SWSYNTH)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_WaveTable 0x8539E660L, 0x62E9, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("8539E660-62E9-11CF-A5D6-28DB04C10000", KSPROPSETID_WaveTable);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_WaveTable DEFINE_GUIDNAMED(KSPROPSETID_WaveTable)

public enum KSPROPERTY_WAVETABLE
{
    KSPROPERTY_WAVETABLE_LOAD_SAMPLE,
    KSPROPERTY_WAVETABLE_UNLOAD_SAMPLE,
    KSPROPERTY_WAVETABLE_MEMORY,
    KSPROPERTY_WAVETABLE_VERSION
}

public class KSDATARANGE_MUSIC
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public GUID Technology = new GUID();
   public uint Channels;
   public uint Notes;
   public uint ChannelMask;
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_Cyclic 0x142C1AC0L, 0x072A, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("142C1AC0-072A-11D0-A5D6-28DB04C10000", KSEVENTSETID_Cyclic);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_Cyclic DEFINE_GUIDNAMED(KSEVENTSETID_Cyclic)

public enum KSEVENT_CYCLIC_TIME
{
    KSEVENT_CYCLIC_TIME_INTERVAL
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Cyclic 0x3FFEAEA0L, 0x2BEE, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("3FFEAEA0-2BEE-11CF-A5D6-28DB04C10000", KSPROPSETID_Cyclic);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Cyclic DEFINE_GUIDNAMED(KSPROPSETID_Cyclic)

public enum KSPROPERTY_CYCLIC
{
    KSPROPERTY_CYCLIC_POSITION
}

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_AudioControlChange 0xE85E9698L, 0xFA2F, 0x11D1, 0x95, 0xBD, 0x00, 0xC0, 0x4F, 0xB9, 0x25, 0xD3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E85E9698-FA2F-11D1-95BD-00C04FB925D3", KSEVENTSETID_AudioControlChange);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_AudioControlChange DEFINE_GUIDNAMED(KSEVENTSETID_AudioControlChange)

public enum KSEVENT_AUDIO_CONTROL_CHANGE
{
    KSEVENT_CONTROL_CHANGE
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_LoopedStreaming 0x4682B940L, 0xC6EF, 0x11D0, 0x96, 0xD8, 0x00, 0xAA, 0x00, 0x51, 0xE5, 0x1D
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("4682B940-C6EF-11D0-96D8-00AA0051E51D", KSEVENTSETID_LoopedStreaming);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_LoopedStreaming DEFINE_GUIDNAMED(KSEVENTSETID_LoopedStreaming)

public enum KSEVENT_LOOPEDSTREAMING
{
    KSEVENT_LOOPEDSTREAMING_POSITION
}

public class LOOPEDSTREAMING_POSITION_EVENT_DATA
{
    public KSEVENTDATA KsEventData = new KSEVENTDATA();
#if _NTDDK_
    public ulong Position;
#else // !_NTDDK_
    public ulong Position;
#endif // !_NTDDK_
}

// @@BEGIN_DDKSPLIT
// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_Sysaudio 0x04800320L, 0x4491, 0x11D1, 0xA0, 0x50, 0x40, 0x57, 0x05, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("04800320-4491-11D1-A050-405705C10000", KSEVENTSETID_Sysaudio);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_Sysaudio DEFINE_GUIDNAMED(KSEVENTSETID_Sysaudio)

public enum KSEVENT_SYSAUDIO
{
    KSEVENT_SYSAUDIO_ADDREMOVE_DEVICE,
    KSEVENT_SYSAUDIO_CHANGE_DEVICE
}
// @@END_DDKSPLIT

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Sysaudio 0xCBE3FAA0L, 0xCC75, 0x11D0, 0xB4, 0x65, 0x00, 0x00, 0x1A, 0x18, 0x18, 0xE6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("CBE3FAA0-CC75-11D0-B465-00001A1818E6", KSPROPSETID_Sysaudio);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Sysaudio DEFINE_GUIDNAMED(KSPROPSETID_Sysaudio)

public enum KSPROPERTY_SYSAUDIO
{
    KSPROPERTY_SYSAUDIO_DEVICE_COUNT = 1,
    KSPROPERTY_SYSAUDIO_DEVICE_FRIENDLY_NAME = 2,
    KSPROPERTY_SYSAUDIO_DEVICE_INSTANCE = 3,
    KSPROPERTY_SYSAUDIO_DEVICE_INTERFACE_NAME = 4,
    KSPROPERTY_SYSAUDIO_SELECT_GRAPH = 5,
    KSPROPERTY_SYSAUDIO_CREATE_VIRTUAL_SOURCE = 6,
    KSPROPERTY_SYSAUDIO_DEVICE_DEFAULT = 7,
// @@BEGIN_DDKSPLIT
    KSPROPERTY_SYSAUDIO_ALWAYS_CREATE_VIRTUAL_SOURCE = 8,
    KSPROPERTY_SYSAUDIO_ADDREMOVE_LOCK = 9,
    KSPROPERTY_SYSAUDIO_ADDREMOVE_UNLOCK = 10,
    KSPROPERTY_SYSAUDIO_RENDER_PIN_INSTANCES = 11,
    KSPROPERTY_SYSAUDIO_RENDER_CONNECTION_INDEX = 12,
    KSPROPERTY_SYSAUDIO_CREATE_VIRTUAL_SOURCE_ONLY = 13,
// @@END_DDKSPLIT
    KSPROPERTY_SYSAUDIO_INSTANCE_INFO = 14,
// @@BEGIN_DDKSPLIT
    KSPROPERTY_SYSAUDIO_PREFERRED_DEVICE = 15,
// @@END_DDKSPLIT
    KSPROPERTY_SYSAUDIO_COMPONENT_ID = 16,
// @@BEGIN_DDKSPLIT
    KSPROPERTY_SYSAUDIO_ADDREMOVE_GFX = 17
// @@END_DDKSPLIT
}

public class SYSAUDIO_CREATE_VIRTUAL_SOURCE
{
    public KSPROPERTY Property = new KSPROPERTY();
    public GUID PinCategory = new GUID();
    public GUID PinName = new GUID();
}

// @@BEGIN_DDKSPLIT
public class SYSAUDIO_GFX
{
    public bool Enable;
    public IntPtr hGfx;
    public uint ulOrder; // Order of the GFX
    public uint ulType; // Type of the GFX
    public uint ulFlags;
    public uint ulDeviceNameOffset; // DeviceInterface on which this GFX needs to be attached
    public uint ulFriendlyNameOffset; // Friendly name of the GFX
}

// @@END_DDKSPLIT

public class SYSAUDIO_SELECT_GRAPH
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint PinId;
    public uint NodeId;
    public uint Flags;
    public uint Reserved;
}

public class SYSAUDIO_INSTANCE_INFO
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Flags;
    public uint DeviceNumber;
}


// @@BEGIN_DDKSPLIT
public class SYSAUDIO_PREFERRED_DEVICE
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Flags;
    public uint Index; // KSPROPERTY_SYSAUDIO_DEFAULT_TYPE
}

// @@END_DDKSPLIT

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Sysaudio_Pin 0xA3A53220L, 0xC6E4, 0x11D0, 0xB4, 0x65, 0x00, 0x00, 0x1A, 0x18, 0x18, 0xE6
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A3A53220-C6E4-11D0-B465-00001A1818E6", KSPROPSETID_Sysaudio_Pin);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Sysaudio_Pin DEFINE_GUIDNAMED(KSPROPSETID_Sysaudio_Pin)

public enum KSPROPERTY_SYSAUDIO_PIN
{
// @@BEGIN_DDKSPLIT
    KSPROPERTY_SYSAUDIO_TOPOLOGY_CONNECTION_INDEX = 0,
// @@END_DDKSPLIT
    KSPROPERTY_SYSAUDIO_ATTACH_VIRTUAL_SOURCE = 1,
// @@BEGIN_DDKSPLIT
    KSPROPERTY_SYSAUDIO_PIN_VOLUME_NODE = 2
// @@END_DDKSPLIT
}

public class SYSAUDIO_ATTACH_VIRTUAL_SOURCE
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint MixerPinId;
    public uint Reserved;
}

// ===========================================================================
public class KSNODEPROPERTY
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint NodeId;
    public uint Reserved;
}

public class KSNODEPROPERTY_AUDIO_CHANNEL
{
    public KSNODEPROPERTY NodeProperty = new KSNODEPROPERTY();
    public int Channel; // value to get or set
    public uint Reserved;
}

public class KSNODEPROPERTY_AUDIO_DEV_SPECIFIC
{
    public KSNODEPROPERTY NodeProperty = new KSNODEPROPERTY();
    public uint DevSpecificId;
    public uint DeviceInfo;
    public uint Length;
}

public class KSNODEPROPERTY_AUDIO_3D_LISTENER
{
    public KSNODEPROPERTY NodeProperty = new KSNODEPROPERTY();
    public object ListenerId;
#if ! _WIN64
    public uint Reserved;
#endif // _WIN64
}

public class KSNODEPROPERTY_AUDIO_PROPERTY
{
    public KSNODEPROPERTY NodeProperty = new KSNODEPROPERTY();
    public object AppContext;
    public uint Length;
#if ! _WIN64
    public uint Reserved;
#endif // _WIN64
}

// ===========================================================================
// {79A9312E-59AE-43b0-A350-8B05284CAB24}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_AudioGfx 0x79a9312eL, 0x59ae, 0x43b0, 0xa3, 0x50, 0x8b, 0x5, 0x28, 0x4c, 0xab, 0x24
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("79A9312E-59AE-43b0-A350-8B05284CAB24", KSPROPSETID_AudioGfx);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_AudioGfx DEFINE_GUIDNAMED(KSPROPSETID_AudioGfx)

public enum KSPROPERTY_AUDIOGFX
{
    KSPROPERTY_AUDIOGFX_RENDERTARGETDEVICEID,
    KSPROPERTY_AUDIOGFX_CAPTURETARGETDEVICEID
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Linear 0x5A2FFE80L, 0x16B9, 0x11D0, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("5A2FFE80-16B9-11D0-A5D6-28DB04C10000", KSPROPSETID_Linear);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Linear DEFINE_GUIDNAMED(KSPROPSETID_Linear)

public enum KSPROPERTY_LINEAR
{
    KSPROPERTY_LINEAR_POSITION
}

// ===========================================================================

// 
// Midi definitions
// 

/*
    Formats
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_MUSIC 0xE725D360L, 0x62CC, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E725D360-62CC-11CF-A5D6-28DB04C10000", KSDATAFORMAT_TYPE_MUSIC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_MUSIC DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_MUSIC)

// 'mids' == MEDIATYPE_Midi
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_MIDI 0x7364696DL, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7364696D-0000-0010-8000-00aa00389b71", KSDATAFORMAT_TYPE_MIDI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_MIDI DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_MIDI)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MIDI 0x1D262760L, 0xE957, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1D262760-E957-11CF-A5D6-28DB04C10000", KSDATAFORMAT_SUBTYPE_MIDI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MIDI DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MIDI)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MIDI_BUS 0x2CA15FA0L, 0x6CFE, 0x11CF, 0xA5, 0xD6, 0x28, 0xDB, 0x04, 0xC1, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("2CA15FA0-6CFE-11CF-A5D6-28DB04C10000", KSDATAFORMAT_SUBTYPE_MIDI_BUS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MIDI_BUS DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MIDI_BUS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_RIFFMIDI 0x4995DAF0L, 0x9EE6, 0x11D0, 0xA4, 0x0E, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("4995DAF0-9EE6-11D0-A40E-00A0C9223196", KSDATAFORMAT_SUBTYPE_RIFFMIDI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_RIFFMIDI DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_RIFFMIDI)

/*
    KSDATAFORMAT_SUBTYPE_DIRECTMUSIC
    see DMusicKS.h
*/

// WARNING! This structure MUST be dword aligned
// regardless of the number of data bytes.

public class KSMUSICFORMAT
{
    public uint TimeDeltaMs; // Delta Milliseconds from the previous midiformat
                                // in the packet. The first midiformat in the packet
                                // is a delta from the PTS in the KSSTREAM_HEADER.
    public uint ByteCount; // Number of bytes of data that follow this struct.
}

// 
// This entire set of MPEG Standard/Dialect Guids are obsolete. Do not use them.
// 
// ====================================================================================================
// ====================================================================================================
// The following official MPEG Formats, Subtypes and Specifiers are listed as required or optional
// These official MPEG GUIDs are the preferred method of supporting MPEG/AC-3 media types in new code.
// Older MPEG GUIDs should also be supported for compatibilty, but these new modes are still required.
// ====================================================================================================
// ====================================================================================================

/*
This is a summary of what media types/specifiers will be required for all DVD+DSS+DVB+DTV MPEG decoders.
These media types are what the decoder driver must accept, hardware support for all of these media types
may or may not actually be provided by the decoder natively.  These media types are intended to define
the "officially" supported MPEG/AC-3 media types that all WHQL certified decoders must implement.  This
specifically includes driver and/or hardware support for all the required standards and dialects.

All MPEG video decoders must support all of the MPEG video modes shown as [required] below.
All MPEG audio decoders must support all of the MPEG audio modes shown as [required] below.
All AC-3 audio decoders must support all of the AC-3 audio modes shown as [required] below.
The line items shown as [optional] need not be implemented, but are possible formats that might be implemented.

Note that the input/output pin formats are defined by 2 or 3 GUIDs: TYPE, SUBTYPE, and maybe SPECIFIER.
The specifiers are included if the data format is a "dialect" that needs to be differentiated during decoding.
The decoder MUST be prepared to deal with ALL requests for _required_ "Standard" formats OR _required_ "Dialects".

STATIC_KSDATAFORMAT_TYPE_STANDARD_ELEMENTARY_STREAM         [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO           [optional]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO           [optional]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO           [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO           [optional]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO              [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO             [optional]
STATIC_KSDATAFORMAT_TYPE_STANDARD_PES_PACKET                [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO            [optional]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO           [optional]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO            [optional]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO           [optional]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO           [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO           [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO              [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO             [optional]
STATIC_KSDATAFORMAT_TYPE_STANDARD_PACK_HEADER               [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO           [required]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO            [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO           [optional]
    STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO              [required]
        STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO             [optional]

Note that the SPECIFIER GUIDs normally identify particular versions of MPEG such as DSS and DVD.
This approach was taken to minimize the number of DSS/DVB/DVD/DTV etc. media SUBTYPES.
These specifiers are currently required to disambiguate MPEG syntax _parsing_ by the decoder
using alternate parsing routines or downloadable firmware or hardware decode settings.

In the future these specifiers will be extended to cover new KS MPEG flavors such as DVB and DTV.
Thus, the optional specifiers will be subject to clarification and/or definition as they are needed.

Important note: Per the ITU MPEG specs, MPEG 2 media may contain pure MPEG 1 syntax and
any "MPEG 2" PES packets may actually contain MPEG 1 payloads and MPEG 1 syntax.  Some MPEG
broadcasts can revert from MPEG2 to MPEG1 format data at their discretion, without warning.

CAUTION: Decoders MUST attempt to process MPEG data AS SOON AS POSSIBLE after reception.
In particular, elementary MPEG or MPEG PES packet streams should not be aggregated into DVD
"pack headers" internally before submission to the codec hardware if AT ALL POSSIBLE.  The
reason is that mpeg data may need to be processed immediately but there may be no additional
MPEG data forthcoming to fill up the PES packet OR DVD "pack" in a timely fashion.  This is
particularly true of MPEG dialects that utilize "repeat field signally" to reuse the last
decoded MPEG video field.

*/

/// //////////////////////////////////////////////////////////////////////
// The major data type GUIDs that define the data packet encapsulation //
/// //////////////////////////////////////////////////////////////////////

// STATIC_KSDATAFORMAT_TYPE_STANDARD_ELEMENTARY_STREAM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_STANDARD_ELEMENTARY_STREAM 0x36523b11L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B11-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_TYPE_STANDARD_ELEMENTARY_STREAM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_STANDARD_ELEMENTARY_STREAM DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_STANDARD_ELEMENTARY_STREAM)

// STATIC_KSDATAFORMAT_TYPE_STANDARD_PES_PACKET
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_STANDARD_PES_PACKET 0x36523b12L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B12-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_TYPE_STANDARD_PES_PACKET);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_STANDARD_PES_PACKET DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_STANDARD_PES_PACKET)

// STATIC_KSDATAFORMAT_TYPE_STANDARD_PACK_HEADER
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_STANDARD_PACK_HEADER 0x36523b13L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B13-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_TYPE_STANDARD_PACK_HEADER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_STANDARD_PACK_HEADER DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_STANDARD_PACK_HEADER)

/// ////////////////////////////////////////////////////////////////////////////
// The minor data subtype GUIDs that define the exact class of the data type.//
/// ////////////////////////////////////////////////////////////////////////////

// STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO 0x36523b21L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B21-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_VIDEO)

// STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO 0x36523b22L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B22-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_STANDARD_MPEG1_AUDIO)

// STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO 0x36523b23L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B23-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_VIDEO)

// STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO 0x36523b24L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B24-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_STANDARD_MPEG2_AUDIO)

// STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO 0x36523b25L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B25-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_STANDARD_AC3_AUDIO)

/// ////////////////////////////////////////////////////////////////////////////
// The low-level specifier GUIDs that define the flavor of the data subtype. //
// Some SUBTYPES, notably MPEG2_VIDEO, MPEG2_AUDIO have different dialects.  //
// These specifiers are intended to be accompanied by a specifier structure. //
/// ////////////////////////////////////////////////////////////////////////////

// STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO 0x36523b31L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B31-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_VIDEO)

// STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO 0x36523b32L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B32-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_DIALECT_MPEG1_AUDIO)

// STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO    Associated with KS_MPEGVIDEOINFO2 defined later
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO 0x36523b33L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B33-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_VIDEO)

// STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO    Associated with KS_MPEGAUDIOINFO defined later
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO 0x36523b34L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B34-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_DIALECT_MPEG2_AUDIO)

// STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO 0x36523b35L, 0x8ee5, 0x11d1, 0x8c, 0xa3, 0x00, 0x60, 0xb0, 0x57, 0x66, 0x4a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("36523B35-8EE5-11d1-8CA3-0060B057664A", KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_DIALECT_AC3_AUDIO)

// ====================================================================================================
// ====================================================================================================
//                              *** COMPATIBILITY WARNING ***
// The *following* older DSS, MPEG, DVD & AC-3 GUID definitions are retained for backward compability.
// These MPEG GUIDs should also be supported for compatibilty, but the above newer modes are still required.
// ====================================================================================================
// ====================================================================================================

// 
// DSS definitions
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_DSS_VIDEO 0xa0af4f81L, 0xe163, 0x11d0, 0xba, 0xd9, 0x00, 0x60, 0x97, 0x44, 0x11, 0x1a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("a0af4f81-e163-11d0-bad9-00609744111a", KSDATAFORMAT_SUBTYPE_DSS_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_DSS_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_DSS_VIDEO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_DSS_AUDIO 0xa0af4f82L, 0xe163, 0x11d0, 0xba, 0xd9, 0x00, 0x60, 0x97, 0x44, 0x11, 0x1a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("a0af4f82-e163-11d0-bad9-00609744111a", KSDATAFORMAT_SUBTYPE_DSS_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_DSS_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_DSS_AUDIO)

// 
// End of obsolete MPEG definitions.
// 

// 
// mpeg 1 definitions
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MPEG1Packet 0xe436eb80, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e436eb80-524f-11ce-9F53-0020af0ba770", KSDATAFORMAT_SUBTYPE_MPEG1Packet);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MPEG1Packet DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MPEG1Packet)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MPEG1Payload 0xe436eb81, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e436eb81-524f-11ce-9F53-0020af0ba770", KSDATAFORMAT_SUBTYPE_MPEG1Payload);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MPEG1Payload DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MPEG1Payload)

// MEDIASUBTYPE_MPEG1Video
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MPEG1Video 0xe436eb86, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e436eb86-524f-11ce-9f53-0020af0ba770", KSDATAFORMAT_SUBTYPE_MPEG1Video);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MPEG1Video DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MPEG1Video)

// FORMAT_MPEGVideo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_MPEG1_VIDEO 0x05589f82L, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("05589f82-c356-11ce-bf01-00aa0055595a", KSDATAFORMAT_SPECIFIER_MPEG1_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_MPEG1_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_MPEG1_VIDEO)

// 
// mpeg 2 definitions
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_MPEG2_PES 0xe06d8020L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8020-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_TYPE_MPEG2_PES);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_MPEG2_PES DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_MPEG2_PES)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_MPEG2_PROGRAM 0xe06d8022L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8022-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_TYPE_MPEG2_PROGRAM);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_MPEG2_PROGRAM DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_MPEG2_PROGRAM)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_MPEG2_TRANSPORT 0xe06d8023L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8023-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_TYPE_MPEG2_TRANSPORT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_MPEG2_TRANSPORT DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_MPEG2_TRANSPORT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MPEG2_VIDEO 0xe06d8026L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8026-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_MPEG2_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MPEG2_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MPEG2_VIDEO)

// use MPEGVIDEOINFO2 (defined below) with KSDATAFORMAT_SPECIFIER_MPEG2_VIDEO
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_MPEG2_VIDEO 0xe06d80e3L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d80e3-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SPECIFIER_MPEG2_VIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_MPEG2_VIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_MPEG2_VIDEO)


// 
// Mpeg2 video properties
// 


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_Mpeg2Vid 0xC8E11B60L, 0x0CC9, 0x11D0, 0xBD, 0x69, 0x00, 0x35, 0x05, 0xC1, 0x03, 0xA9
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C8E11B60-0CC9-11D0-BD69-003505C103A9", KSPROPSETID_Mpeg2Vid);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_Mpeg2Vid DEFINE_GUIDNAMED( KSPROPSETID_Mpeg2Vid )


public enum KSPROPERTY_MPEG2VID
{
    KSPROPERTY_MPEG2VID_MODES, // available output modes of decoder
    KSPROPERTY_MPEG2VID_CUR_MODE, // current mode of the decoder
    KSPROPERTY_MPEG2VID_4_3_RECT, // output coordinates for 4:3 source
    KSPROPERTY_MPEG2VID_16_9_RECT, // output coordinates for 16:9 source
    KSPROPERTY_MPEG2VID_16_9_PANSCAN // pan and scan vectors
}

// 
// bit field definitions for MPEG2 VIDEO mode
// 


// 
// rectangle definitions for the 4/3 and 16/9 cropping properties of
// the MPEG2Video decoder
// 

public class _KSMPEGVID_RECT
{
    public uint StartX;
    public uint StartY;
    public uint EndX;
    public uint EndY;
}

// 
// Params for pan / scan
// 


// 
// MPEG2 Audio definition
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_MPEG2_AUDIO 0xe06d802bL, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d802b-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_MPEG2_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_MPEG2_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_MPEG2_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_MPEG2_AUDIO 0xe06d80e5L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d80e5-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SPECIFIER_MPEG2_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_MPEG2_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_MPEG2_AUDIO)

// 
// DVD LPCM Audio definition
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_LPCM_AUDIO 0xe06d8032L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8032-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_LPCM_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_LPCM_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_LPCM_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_LPCM_AUDIO 0xe06d80e6L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d80e6-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SPECIFIER_LPCM_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_LPCM_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_LPCM_AUDIO)

// 
// AC-3 definition
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_AC3_AUDIO 0xe06d802cL, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d802c-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_AC3_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_AC3_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_AC3_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_AC3_AUDIO 0xe06d80e4L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d80e4-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SPECIFIER_AC3_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_AC3_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_AC3_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_AC3 0xBFABE720L, 0x6E1F, 0x11D0, 0xBC, 0xF2, 0x44, 0x45, 0x53, 0x54, 0x00, 0x00
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("BFABE720-6E1F-11D0-BCF2-444553540000", KSPROPSETID_AC3);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_AC3 DEFINE_GUIDNAMED(KSPROPSETID_AC3)

public enum KSPROPERTY_AC3
{
    KSPROPERTY_AC3_ERROR_CONCEALMENT = 1,
    KSPROPERTY_AC3_ALTERNATE_AUDIO,
    KSPROPERTY_AC3_DOWNMIX,
    KSPROPERTY_AC3_BIT_STREAM_MODE,
    KSPROPERTY_AC3_DIALOGUE_LEVEL,
    KSPROPERTY_AC3_LANGUAGE_CODE,
    KSPROPERTY_AC3_ROOM_TYPE
}

public class KSAC3_ERROR_CONCEALMENT
{
    public bool fRepeatPreviousBlock;
    public bool fErrorInCurrentBlock;
}

public class KSAC3_ALTERNATE_AUDIO
{
    public bool fStereo;
    public uint DualMode;
}


public class KSAC3_DOWNMIX
{
    public bool fDownMix;
    public bool fDolbySurround;
}

public class KSAC3_BIT_STREAM_MODE
{
    public int BitStreamMode;
}


public class KSAC3_DIALOGUE_LEVEL
{
    public uint DialogueLevel;
}

public class KSAC3_ROOM_TYPE
{
    public bool fLargeRoom;
}


// 
// DTS and SDDS definitions (media subtype GUIDs)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_DTS_AUDIO 0xe06d8033L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8033-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_DTS_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_DTS_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_DTS_AUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_SDDS_AUDIO 0xe06d8034L, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d8034-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_SDDS_AUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_SDDS_AUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_SDDS_AUDIO)


// 
// audio decoder output properties
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_AudioDecoderOut 0x6ca6e020L, 0x43bd, 0x11d0, 0xbd, 0x6a, 0x00, 0x35, 0x05, 0xc1, 0x03, 0xa9
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6ca6e020-43bd-11d0-bd6a-003505c103a9", KSPROPSETID_AudioDecoderOut);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_AudioDecoderOut DEFINE_GUIDNAMED(KSPROPSETID_AudioDecoderOut)

public enum KSPROPERTY_AUDDECOUT
{
    KSPROPERTY_AUDDECOUT_MODES, // available output modes of decoder
    KSPROPERTY_AUDDECOUT_CUR_MODE // current mode of the decoder
}




// 
// subpicture definition
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_SUBPICTURE 0xe06d802dL, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e06d802d-db46-11cf-b4d1-00805f6cbbea", KSDATAFORMAT_SUBTYPE_SUBPICTURE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_SUBPICTURE DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_SUBPICTURE)


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_DvdSubPic 0xac390460L, 0x43af, 0x11d0, 0xbd, 0x6a, 0x00, 0x35, 0x05, 0xc1, 0x03, 0xa9
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("ac390460-43af-11d0-bd6a-003505c103a9", KSPROPSETID_DvdSubPic);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_DvdSubPic DEFINE_GUIDNAMED(KSPROPSETID_DvdSubPic)

public enum KSPROPERTY_DVDSUBPIC
{
    KSPROPERTY_DVDSUBPIC_PALETTE,
    KSPROPERTY_DVDSUBPIC_HLI,
    KSPROPERTY_DVDSUBPIC_COMPOSIT_ON // TRUE for subpicture is displayed
}

public class _KS_DVD_YCrCb
{
    public byte Reserved;
    public byte Y;
    public byte Cr;
    public byte Cb;
}

/* The KS_DVD_YUV structure is now superseded by KS_DVD_YCrCb above and is
   here for backward compatibility only */

public class _KS_DVD_YUV
{
    public byte Reserved;
    public byte Y;
    public byte V;
    public byte U;
}

public class _KSPROPERTY_SPPAL
{
    public _KS_DVD_YUV[] sppal = Arrays.InitializeWithDefaultInstances<_KS_DVD_YUV>(16);
}

public class _KS_COLCON
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

public class _KSPROPERTY_SPHLI
{
    public ushort HLISS;
    public ushort Reserved;
    public uint StartPTM; // start presentation time in x/90000
    public uint EndPTM; // end PTM in x/90000
    public ushort StartX;
    public ushort StartY;
    public ushort StopX;
    public ushort StopY;
    public _KS_COLCON ColCon = new _KS_COLCON(); // color contrast description (4 bytes as given in HLI)
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_CopyProt 0x0E8A0A40L, 0x6AEF, 0x11D0, 0x9E, 0xD0, 0x00, 0xA0, 0x24, 0xCA, 0x19, 0xB3
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0E8A0A40-6AEF-11D0-9ED0-00A024CA19B3", KSPROPSETID_CopyProt);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_CopyProt DEFINE_GUIDNAMED(KSPROPSETID_CopyProt)

public enum KSPROPERTY_COPYPROT
{

    KSPROPERTY_DVDCOPY_CHLG_KEY = 0x01,
    KSPROPERTY_DVDCOPY_DVD_KEY1,
    KSPROPERTY_DVDCOPY_DEC_KEY2,
    KSPROPERTY_DVDCOPY_TITLE_KEY,
    KSPROPERTY_COPY_MACROVISION,
    KSPROPERTY_DVDCOPY_REGION,
    KSPROPERTY_DVDCOPY_SET_COPY_STATE,
    KSPROPERTY_DVDCOPY_DISC_KEY = 0x80

}

public class _KS_DVDCOPY_CHLGKEY
{
    public byte[] ChlgKey = new byte[10];
    public byte[] Reserved = new byte[2];
}

public class _KS_DVDCOPY_BUSKEY
{
    public byte[] BusKey = new byte[5];
    public byte[] Reserved = new byte[1];
}


public class _KS_DVDCOPY_DISCKEY
{
    public byte[] DiscKey = new byte[2048];
}

public class _KS_DVDCOPY_REGION
{
    public byte Reserved;
    public byte RegionData;
    public byte[] Reserved2 = new byte[2];
}

public class _KS_DVDCOPY_TITLEKEY
{
    public uint KeyFlags;
    public uint[] ReservedNT = new uint[2];
    public byte[] TitleKey = new byte[6];
    public byte[] Reserved = new byte[2];
}

public class _KS_COPY_MACROVISION
{
    public uint MACROVISIONLevel;
}

public class _KS_DVDCOPY_SET_COPY_STATE
{
    public uint DVDCopyState;
}

public enum KS_DVDCOPYSTATE
{
    KS_DVDCOPYSTATE_INITIALIZE, // indicates we are starting a full
                                        // copy protection sequence.
    KS_DVDCOPYSTATE_INITIALIZE_TITLE, // indicates we are starting a title
                                        // key copy protection sequence
    KS_DVDCOPYSTATE_AUTHENTICATION_NOT_REQUIRED,
    KS_DVDCOPYSTATE_AUTHENTICATION_REQUIRED,
    KS_DVDCOPYSTATE_DONE
}

public enum KS_COPY_MACROVISION_LEVEL
{
    KS_MACROVISION_DISABLED,
    KS_MACROVISION_LEVEL1,
    KS_MACROVISION_LEVEL2,
    KS_MACROVISION_LEVEL3
}

// 
// CGMS Copy Protection Flags
// 






// ===========================================================================
// The following MUST match the structures in WinGDI.h and AMVideo.h
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_TVTUNER 0xa799a800L, 0xa46d, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0x24, 0x01, 0xdc, 0xd4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("a799a800-a46d-11d0-a18c-00a02401dcd4", KSCATEGORY_TVTUNER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_TVTUNER DEFINE_GUIDNAMED(KSCATEGORY_TVTUNER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_CROSSBAR 0xa799a801L, 0xa46d, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0x24, 0x01, 0xdc, 0xd4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("a799a801-a46d-11d0-a18c-00a02401dcd4", KSCATEGORY_CROSSBAR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_CROSSBAR DEFINE_GUIDNAMED(KSCATEGORY_CROSSBAR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_TVAUDIO 0xa799a802L, 0xa46d, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0x24, 0x01, 0xdc, 0xd4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("a799a802-a46d-11d0-a18c-00a02401dcd4", KSCATEGORY_TVAUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_TVAUDIO DEFINE_GUIDNAMED(KSCATEGORY_TVAUDIO)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_VPMUX 0xa799a803L, 0xa46d, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0x24, 0x01, 0xdc, 0xd4
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("a799a803-a46d-11d0-a18c-00a02401dcd4", KSCATEGORY_VPMUX);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_VPMUX DEFINE_GUIDNAMED(KSCATEGORY_VPMUX)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_VBICODEC 0x07dad660L, 0x22f1, 0x11d1, 0xa9, 0xf4, 0x00, 0xc0, 0x4f, 0xbb, 0xde, 0x8f
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("07dad660-22f1-11d1-a9f4-00c04fbbde8f", KSCATEGORY_VBICODEC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_VBICODEC DEFINE_GUIDNAMED(KSCATEGORY_VBICODEC)

// SUBTYPE_VPVideo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_VPVideo 0x5a9b6a40L, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("5a9b6a40-1a22-11d1-bad9-00609744111a", KSDATAFORMAT_SUBTYPE_VPVideo);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_VPVideo DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_VPVideo)

// SUBTYPE_VPVBI
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_VPVBI 0x5a9b6a41L, 0x1a22, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("5a9b6a41-1a22-11d1-bad9-00609744111a", KSDATAFORMAT_SUBTYPE_VPVBI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_VPVBI DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_VPVBI)


// FORMAT_VideoInfo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_VIDEOINFO 0x05589f80L, 0xc356, 0x11ce, 0xbf, 0x01, 0x00, 0xaa, 0x00, 0x55, 0x59, 0x5a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("05589f80-c356-11ce-bf01-00aa0055595a", KSDATAFORMAT_SPECIFIER_VIDEOINFO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_VIDEOINFO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_VIDEOINFO)

// FORMAT_VideoInfo2
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_VIDEOINFO2 0xf72a76A0L, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("f72a76A0-eb0a-11d0-ace4-0000c0cc16ba", KSDATAFORMAT_SPECIFIER_VIDEOINFO2);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_VIDEOINFO2 DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_VIDEOINFO2)

// MEDIATYPE_AnalogVideo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_ANALOGVIDEO 0x0482dde1L, 0x7817, 0x11cf, 0x8a, 0x03, 0x00, 0xaa, 0x00, 0x6e, 0xcb, 0x65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0482dde1-7817-11cf-8a03-00aa006ecb65", KSDATAFORMAT_TYPE_ANALOGVIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_ANALOGVIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_ANALOGVIDEO)

// FORMAT_AnalogVideo
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_ANALOGVIDEO 0x0482dde0L, 0x7817, 0x11cf, 0x8a, 0x03, 0x00, 0xaa, 0x00, 0x6e, 0xcb, 0x65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0482dde0-7817-11cf-8a03-00aa006ecb65", KSDATAFORMAT_SPECIFIER_ANALOGVIDEO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_ANALOGVIDEO DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_ANALOGVIDEO)

// MEDIATYPE_AnalogAudio
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_ANALOGAUDIO 0x0482dee1L, 0x7817, 0x11cf, 0x8a, 0x03, 0x00, 0xaa, 0x00, 0x6e, 0xcb, 0x65
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0482DEE1-7817-11cf-8a03-00aa006ecb65", KSDATAFORMAT_TYPE_ANALOGAUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_ANALOGAUDIO DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_ANALOGAUDIO)

// FORMAT_VBI
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SPECIFIER_VBI 0xf72a76e0L, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("f72a76e0-eb0a-11d0-ace4-0000c0cc16ba", KSDATAFORMAT_SPECIFIER_VBI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SPECIFIER_VBI DEFINE_GUIDNAMED(KSDATAFORMAT_SPECIFIER_VBI)

// MEDIATYPE_VBI
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_VBI 0xf72a76e1L, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("f72a76e1-eb0a-11d0-ace4-0000c0cc16ba", KSDATAFORMAT_TYPE_VBI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_VBI DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_VBI)

// SUBTYPE_RAW8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_RAW8 0xca20d9a0, 0x3e3e, 0x11d1, 0x9b, 0xf9, 0x0, 0xc0, 0x4f, 0xbb, 0xde, 0xbf
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("ca20d9a0-3e3e-11d1-9bf9-00c04fbbdebf", KSDATAFORMAT_SUBTYPE_RAW8);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_RAW8 DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_RAW8)

// MEDIASUBTYPE_CC
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_CC 0x33214cc1, 0x11f, 0x11d2, 0xb4, 0xb1, 0x0, 0xa0, 0xd1, 0x2, 0xcf, 0xbe
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("33214CC1-011F-11D2-B4B1-00A0D102CFBE", KSDATAFORMAT_SUBTYPE_CC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_CC DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_CC)

// MEDIASUBTYPE_NABTS
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_NABTS 0xf72a76e2L, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("f72a76e2-eb0a-11d0-ace4-0000c0cc16ba", KSDATAFORMAT_SUBTYPE_NABTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_NABTS DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_NABTS)

// MEDIASUBTYPE_TELETEXT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_TELETEXT 0xf72a76e3L, 0xeb0a, 0x11d0, 0xac, 0xe4, 0x00, 0x00, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("f72a76e3-eb0a-11d0-ace4-0000c0cc16ba", KSDATAFORMAT_SUBTYPE_TELETEXT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_TELETEXT DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_TELETEXT)



/* constants for the biCompression field */

public class tagKS_RGBQUAD
{ // rgbq
    public byte rgbBlue;
    public byte rgbGreen;
    public byte rgbRed;
    public byte rgbReserved;
}

/* constants for palettes */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_EGA_PALETTE (KS_iEGA_COLORS * sizeof(KS_RGBQUAD))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_PALETTE (KS_iPALETTE_COLORS * sizeof(KS_RGBQUAD))

public class tagKS_BITMAPINFOHEADER
{
        public uint biSize;
        public int biWidth;
        public int biHeight;
        public ushort biPlanes;
        public ushort biBitCount;
        public uint biCompression;
        public uint biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public uint biClrUsed;
        public uint biClrImportant;
}

// Used for true colour images that also have a palette

public class tag_KS_TRUECOLORINFO
{
    public uint[] dwBitMasks = new uint[DefineConstants.KS_iMASK_COLORS];
    public tagKS_RGBQUAD[] bmiColors = Arrays.InitializeWithDefaultInstances<tagKS_RGBQUAD>(DefineConstants.KS_iPALETTE_COLORS);
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_WIDTHBYTES(bits) ((DWORD)(((bits)+31) & (~31)) / 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_DIBWIDTHBYTES(bi) (DWORD)KS_WIDTHBYTES((DWORD)(bi).biWidth * (DWORD)(bi).biBitCount)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS__DIBSIZE(bi) (KS_DIBWIDTHBYTES(bi) * (DWORD)(bi).biHeight)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_DIBSIZE(bi) ((bi).biHeight < 0 ? (-1)*(KS__DIBSIZE(bi)) : KS__DIBSIZE(bi))


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

public class tagKS_VIDEOINFOHEADER
{

    public RECT rcSource = new RECT(); // The bit we really want to use
    public RECT rcTarget = new RECT(); // Where the video should go
    public uint dwBitRate; // Approximate bit data rate
    public uint dwBitErrorRate; // Bit error rate for this stream
    public long AvgTimePerFrame; // Average time per frame (100ns units)

    public tagKS_BITMAPINFOHEADER bmiHeader = new tagKS_BITMAPINFOHEADER();

}

// !!! WARNING !!!
// DO NOT use the following structure unless you are sure that the BITMAPINFOHEADER
// has a normal biSize == sizeof(BITMAPINFOHEADER) !
// !!! WARNING !!!

public class tagKS_VIDEOINFO
{

    public RECT rcSource = new RECT(); // The bit we really want to use
    public RECT rcTarget = new RECT(); // Where the video should go
    public uint dwBitRate; // Approximate bit data rate
    public uint dwBitErrorRate; // Bit error rate for this stream
    public long AvgTimePerFrame; // Average time per frame (100ns units)

    public tagKS_BITMAPINFOHEADER bmiHeader = new tagKS_BITMAPINFOHEADER();

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        tagKS_RGBQUAD bmiColors[DefineConstants.KS_iPALETTE_COLORS]; // Colour palette
//        uint dwBitMasks[DefineConstants.KS_iMASK_COLORS]; // True colour masks
//        tag_KS_TRUECOLORINFO TrueColorInfo; // Both of the above
//    };

}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_MASKS (KS_iMASK_COLORS * sizeof(DWORD))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_PREHEADER (FIELD_OFFSET(KS_VIDEOINFOHEADER,bmiHeader))

// For normal size
// #define KS_SIZE_VIDEOHEADER (sizeof(KS_BITMAPINFOHEADER) + KS_SIZE_PREHEADER)
// !!! for abnormal biSizes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_VIDEOHEADER(pbmi) ((pbmi)->bmiHeader.biSize + KS_SIZE_PREHEADER)

// VBI
// Used for NABTS, CC, Intercast, WST
public class tagKS_VBIINFOHEADER
{
    public uint StartLine; // inclusive
    public uint EndLine; // inclusive
    public uint SamplingFrequency; // Hz.
    public uint MinLineStartTime; // microSec * 100 from HSync LE
    public uint MaxLineStartTime; // microSec * 100 from HSync LE
    public uint ActualLineStartTime; // microSec * 100 from HSync LE
    public uint ActualLineEndTime; // microSec * 100 from HSync LE
    public uint VideoStandard; // KS_AnalogVideoStandard*
    public uint SamplesPerLine;
    public uint StrideInBytes; // May be > SamplesPerLine
    public uint BufferSize; // Bytes
}

// VBI Sampling Rates
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_VBIDATARATE_NABTS (5727272L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_VBIDATARATE_CC ( 503493L)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_VBISAMPLINGRATE_4X_NABTS ((long)(4*KS_VBIDATARATE_NABTS))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_VBISAMPLINGRATE_47X_NABTS ((long)(27000000))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_VBISAMPLINGRATE_5X_NABTS ((long)(5*KS_VBIDATARATE_NABTS))

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_47NABTS_SCALER (KS_VBISAMPLINGRATE_47X_NABTS/(double)KS_VBIDATARATE_NABTS)

// Analog video variant - Use this when the format is FORMAT_AnalogVideo
// 
// rcSource defines the portion of the active video signal to use
// rcTarget defines the destination rectangle
//    both of the above are relative to the dwActiveWidth and dwActiveHeight fields
// dwActiveWidth is currently set to 720 for all formats (but could change for HDTV)
// dwActiveHeight is 483 for NTSC and 575 for PAL/SECAM  (but could change for HDTV)

public class tagKS_AnalogVideoInfo
{
    public RECT rcSource = new RECT(); // Width max is 720, height varies w/ TransmissionStd
    public RECT rcTarget = new RECT(); // Where the video should go
    public uint dwActiveWidth; // Always 720 (CCIR-601 active samples per line)
    public uint dwActiveHeight; // 483 for NTSC, 575 for PAL/SECAM
    public long AvgTimePerFrame; // Normal ActiveMovie units (100 nS)
}

// ===========================================================================
// Data packet passed on Analog video stream channel change
// ===========================================================================


public class tagKS_TVTUNER_CHANGE_INFO
{
   public uint dwFlags; // KS_TVTUNER_CHANGE_*
   public uint dwCountryCode;
   public uint dwAnalogVideoStandard; // KS_AnalogVideoStandard
   public uint dwChannel;
}

// ===========================================================================
// Video format blocks
// ===========================================================================

public enum KS_MPEG2Level
{
    KS_MPEG2Level_Low,
    KS_MPEG2Level_Main,
    KS_MPEG2Level_High1440,
    KS_MPEG2Level_High
}

public enum KS_MPEG2Profile
{
    KS_MPEG2Profile_Simple,
    KS_MPEG2Profile_Main,
    KS_MPEG2Profile_SNRScalable,
    KS_MPEG2Profile_SpatiallyScalable,
    KS_MPEG2Profile_High
}




                                                //  based on pan-scan vectors in picture_display_extension
                                                //  and change the picture aspect ratio accordingly.
                                                //  pin for DVD style closed caption data found in GOP layer of field 1
                                                //  pin for DVD style closed caption data found in GOP layer of field 2
                                                //  and bottom of the video.
                                                //  indicates that "camera mode" was used.
                        //  be letterboxed.  Streams sent to VGA should be letterboxed only by renderers.

public class tagKS_VIDEOINFOHEADER2
{
    public RECT rcSource = new RECT();
    public RECT rcTarget = new RECT();
    public uint dwBitRate;
    public uint dwBitErrorRate;
    public long AvgTimePerFrame;
    public uint dwInterlaceFlags; // use AMINTERLACE_* defines. Reject connection if undefined bits are not 0
    public uint dwCopyProtectFlags; // use AMCOPYPROTECT_* defines. Reject connection if undefined bits are not 0
    public uint dwPictAspectRatioX; // X dimension of picture aspect ratio, e.g. 16 for 16x9 display
    public uint dwPictAspectRatioY; // Y dimension of picture aspect ratio, e.g.  9 for 16x9 display
    public uint dwReserved1; // must be 0; reject connection otherwise
    public uint dwReserved2; // must be 0; reject connection otherwise
    public tagKS_BITMAPINFOHEADER bmiHeader = new tagKS_BITMAPINFOHEADER();
}

public class tagKS_MPEG1VIDEOINFO
{
    public tagKS_VIDEOINFOHEADER hdr = new tagKS_VIDEOINFOHEADER(); // Compatible with VIDEOINFO
    public uint dwStartTimeCode; // 25-bit Group of pictures time code at start of data
    public uint cbSequenceHeader; // Length in bytes of bSequenceHeader
    public byte[] bSequenceHeader = new byte[1]; // Sequence header including quantization matrices if any
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_MPEG1VIDEOINFO(pv) (FIELD_OFFSET(KS_MPEG1VIDEOINFO, bSequenceHeader[0]) + (pv)->cbSequenceHeader)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_MPEG1_SEQUENCE_INFO(pv) ((const BYTE *)(pv)->bSequenceHeader)

public class tagKS_MPEGVIDEOINFO2
{
    public tagKS_VIDEOINFOHEADER2 hdr = new tagKS_VIDEOINFOHEADER2();
    public uint dwStartTimeCode; //  ?? not used for DVD ??
    public uint cbSequenceHeader; // is 0 for DVD (no sequence header)
    public uint dwProfile; // use enum MPEG2Profile
    public uint dwLevel; // use enum MPEG2Level
    public uint dwFlags; // use AMMPEG2_* defines.  Reject connection if undefined bits are not 0
    public uint[] bSequenceHeader = new uint[1]; // DWORD instead of Byte for alignment purposes
                                                //   For MPEG-2, if a sequence_header is included, the sequence_extension
                                                //   should also be included
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_SIZE_MPEGVIDEOINFO2(pv) (FIELD_OFFSET(KS_MPEGVIDEOINFO2, bSequenceHeader[0]) + (pv)->cbSequenceHeader)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KS_MPEG1_SEQUENCE_INFO(pv) ((const BYTE *)(pv)->bSequenceHeader)

// ===========================================================================
// Audio format blocks
// ===========================================================================

// if set, the PTS,DTS timestamps advance at 27MHz rather than 90KHz

public class tagKS_MPEAUDIOINFO
{
    public uint dwFlags; // use KS_MPEGAUDIOINFO_* defines.  Reject connection if undefined bits are not 0
    public uint dwReserved1; // must be 0; reject connection otherwise
    public uint dwReserved2; // must be 0; reject connection otherwise
    public uint dwReserved3; // must be 0; reject connection otherwise
}

// ===========================================================================
// Video DATAFORMATs
// ===========================================================================

public class tagKS_DATAFORMAT_VIDEOINFOHEADER
{
    public KSDATAFORMAT DataFormat = new KSDATAFORMAT();
    public tagKS_VIDEOINFOHEADER VideoInfoHeader = new tagKS_VIDEOINFOHEADER();
}

public class tagKS_DATAFORMAT_VIDEOINFOHEADER2
{
    public KSDATAFORMAT DataFormat = new KSDATAFORMAT();
    public tagKS_VIDEOINFOHEADER2 VideoInfoHeader2 = new tagKS_VIDEOINFOHEADER2();
}

public class tagKS_DATAFORMAT_VIDEOINFO_PALETTE
{
    public KSDATAFORMAT DataFormat = new KSDATAFORMAT();
    public tagKS_VIDEOINFO VideoInfo = new tagKS_VIDEOINFO();
}

public class tagKS_DATAFORMAT_VBIINFOHEADER
{
    public KSDATAFORMAT DataFormat = new KSDATAFORMAT();
    public tagKS_VBIINFOHEADER VBIInfoHeader = new tagKS_VBIINFOHEADER();
}

public class _KS_VIDEO_STREAM_CONFIG_CAPS
{
    public GUID guid = new GUID(); // will be MEDIATYPE_Video
    public uint VideoStandard; // logical OR of all AnalogVideoStandards
                                // supported
    public SIZE InputSize = new SIZE(); // the inherent size of the incoming signal
                                // (every pixel unique)
    public SIZE MinCroppingSize = new SIZE(); // smallest rcSrc cropping rect allowed
    public SIZE MaxCroppingSize = new SIZE(); // largest rcSrc cropping rect allowed
    public int CropGranularityX; // granularity of cropping size
    public int CropGranularityY;
    public int CropAlignX; // alignment of cropping rect
    public int CropAlignY;
    public SIZE MinOutputSize = new SIZE(); // smallest bitmap stream can produce
    public SIZE MaxOutputSize = new SIZE(); // largest  bitmap stream can produce
    public int OutputGranularityX; // granularity of output bitmap size
    public int OutputGranularityY;
    public int StretchTapsX; // 0, no stretch, 1 pix dup, 2 interp, ...
    public int StretchTapsY; //    Describes quality of hardware scaler
    public int ShrinkTapsX;
    public int ShrinkTapsY;
    public long MinFrameInterval; // 100 nS units
    public long MaxFrameInterval;
    public int MinBitsPerSecond;
    public int MaxBitsPerSecond;
}

// ===========================================================================
// Video DATARANGEs
// ===========================================================================

public class tagKS_DATARANGE_VIDEO
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public bool bFixedSizeSamples; // all samples same size?
   public bool bTemporalCompression; // all I frames?
   public uint StreamDescriptionFlags; // KS_VIDEO_DESC_*
   public uint MemoryAllocationFlags; // KS_VIDEO_ALLOC_*
   public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps = new _KS_VIDEO_STREAM_CONFIG_CAPS();
   public tagKS_VIDEOINFOHEADER VideoInfoHeader = new tagKS_VIDEOINFOHEADER(); // default format
}

public class tagKS_DATARANGE_VIDEO2
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public bool bFixedSizeSamples; // all samples same size?
   public bool bTemporalCompression; // all I frames?
   public uint StreamDescriptionFlags; // KS_VIDEO_DESC_*
   public uint MemoryAllocationFlags; // KS_VIDEO_ALLOC_*
   public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps = new _KS_VIDEO_STREAM_CONFIG_CAPS();
   public tagKS_VIDEOINFOHEADER2 VideoInfoHeader = new tagKS_VIDEOINFOHEADER2(); // default format
}

public class tagKS_DATARANGE_MPEG1_VIDEO
{
    public KSDATARANGE DataRange = new KSDATARANGE();
    public bool bFixedSizeSamples; // all samples same size?
    public bool bTemporalCompression; // all I frames?
    public uint StreamDescriptionFlags; // KS_VIDEO_DESC_*
    public uint MemoryAllocationFlags; // KS_VIDEO_ALLOC_*
    public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps = new _KS_VIDEO_STREAM_CONFIG_CAPS();
    public tagKS_MPEG1VIDEOINFO VideoInfoHeader = new tagKS_MPEG1VIDEOINFO(); // default format
}

public class tagKS_DATARANGE_MPEG2_VIDEO
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public bool bFixedSizeSamples; // all samples same size?
   public bool bTemporalCompression; // all I frames?
   public uint StreamDescriptionFlags; // KS_VIDEO_DESC_*
   public uint MemoryAllocationFlags; // KS_VIDEO_ALLOC_*
   public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps = new _KS_VIDEO_STREAM_CONFIG_CAPS();
   public tagKS_MPEGVIDEOINFO2 VideoInfoHeader = new tagKS_MPEGVIDEOINFO2(); // default format
}

public class tagKS_DATARANGE_VIDEO_PALETTE
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public bool bFixedSizeSamples; // all samples same size?
   public bool bTemporalCompression; // all I frames?
   public uint StreamDescriptionFlags; // KS_VIDEO_DESC_*
   public uint MemoryAllocationFlags; // KS_VIDEO_ALLOC_*
   public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps = new _KS_VIDEO_STREAM_CONFIG_CAPS();
   public tagKS_VIDEOINFO VideoInfo = new tagKS_VIDEOINFO(); // default format
}

public class tagKS_DATARANGE_VIDEO_VBI
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public bool bFixedSizeSamples; // all samples same size?
   public bool bTemporalCompression; // all I frames?
   public uint StreamDescriptionFlags; // KS_VIDEO_DESC_*
   public uint MemoryAllocationFlags; // KS_VIDEO_ALLOC_*
   public _KS_VIDEO_STREAM_CONFIG_CAPS ConfigCaps = new _KS_VIDEO_STREAM_CONFIG_CAPS();
   public tagKS_VBIINFOHEADER VBIInfoHeader = new tagKS_VBIINFOHEADER(); // default format
}

public class tagKS_DATARANGE_ANALOGVIDEO
{
   public KSDATARANGE DataRange = new KSDATARANGE();
   public tagKS_AnalogVideoInfo AnalogVideoInfo = new tagKS_AnalogVideoInfo();
}

// ===========================================================================
// StreamDescriptionFlags
// 
// These define the "purpose" of each video stream
// ===========================================================================


// MemoryAllocationFlags

/// ///////////////////////////////////////////////////////////
// Capture driver VBI property sets
/// ///////////////////////////////////////////////////////////

// {F162C607-7B35-496f-AD7F-2DCA3B46B718}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_VBICAP_PROPERTIES 0xf162c607, 0x7b35, 0x496f, 0xad, 0x7f, 0x2d, 0xca, 0x3b, 0x46, 0xb7, 0x18
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("F162C607-7B35-496f-AD7F-2DCA3B46B718", KSPROPSETID_VBICAP_PROPERTIES);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_VBICAP_PROPERTIES DEFINE_GUIDNAMED(KSPROPSETID_VBICAP_PROPERTIES)

public enum KSPROPERTY_VBICAP
{
    KSPROPERTY_VBICAP_PROPERTIES_PROTECTION = 0x01
}

public class _VBICAP_PROPERTIES_PROTECTION_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StreamIndex; // Index of stream
    public uint Status;
}


/***************************************************************************/
/* VBI Related GUIDs, structs and properties for codecs(generic, cc, nabts)*/
/***************************************************************************/

/// ////////////////////////////////////////////////////////////////////////////////////
// IP/NABTS Protocol Reserved Group IDs - Overall Range 0x800-0x8FF [Decimal 2048-2079]
// Intervening values(0-F) are used if there are multiple providers at a particular tier
/// ////////////////////////////////////////////////////////////////////////////////////

// Used by individual content creators in show footage/data

// Used by production company in finished show data

// Used by broadcast syndicates in syndicated show data

// Used by tv networks in network television data

// Used by telvision stations in local programming data

// Used by cable system in cable head-end originated data

// The values between 0x8C0 - 0x8EF are reserved for future expansion

// Used by Microsoft for Testing purposes (0x8F0 - 0x8FF)

/// ///////////////////////////////////////////////////////////
// Stream Format FEC-corrected NABTS bundles
/// ///////////////////////////////////////////////////////////

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_NABTS 0xe757bca0, 0x39ac, 0x11d1, 0xa9, 0xf5, 0x0, 0xc0, 0x4f, 0xbb, 0xde, 0x8f
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E757BCA0-39AC-11d1-A9F5-00C04FBBDE8F", KSDATAFORMAT_TYPE_NABTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_NABTS DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_NABTS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_NABTS_FEC 0xe757bca1, 0x39ac, 0x11d1, 0xa9, 0xf5, 0x0, 0xc0, 0x4f, 0xbb, 0xde, 0x8f
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("E757BCA1-39AC-11d1-A9F5-00C04FBBDE8F", KSDATAFORMAT_SUBTYPE_NABTS_FEC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_NABTS_FEC DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_NABTS_FEC)


/// ///////////////////////////////////////////////////////////
// NABTS Bundle data structure definition
/// ///////////////////////////////////////////////////////////


public class _NABTSFEC_BUFFER
{
    public uint dataSize;
    public ushort groupID;
    public ushort Reserved;
    public byte[] data = new byte[DefineConstants.NABTS_LINES_PER_BUNDLE * DefineConstants.NABTS_PAYLOAD_PER_LINE];
}

/// ///////////////////////////////////////////////////////////
// vbi codec filtering pin properties
/// ///////////////////////////////////////////////////////////

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_VBICodecFiltering 0xcafeb0caL, 0x8715, 0x11d0, 0xbd, 0x6a, 0x00, 0x35, 0xc0, 0xed, 0xba, 0xbe
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("cafeb0ca-8715-11d0-bd6a-0035c0edbabe", KSPROPSETID_VBICodecFiltering);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_VBICodecFiltering DEFINE_GUIDNAMED(KSPROPSETID_VBICodecFiltering)

public enum KSPROPERTY_VBICODECFILTERING
{
    KSPROPERTY_VBICODECFILTERING_SCANLINES_REQUESTED_BIT_ARRAY = 0x01,
    KSPROPERTY_VBICODECFILTERING_SCANLINES_DISCOVERED_BIT_ARRAY,
    KSPROPERTY_VBICODECFILTERING_SUBSTREAMS_REQUESTED_BIT_ARRAY,
    KSPROPERTY_VBICODECFILTERING_SUBSTREAMS_DISCOVERED_BIT_ARRAY,
    KSPROPERTY_VBICODECFILTERING_STATISTICS
}

public class _VBICODECFILTERING_SCANLINES
{
    public uint[] DwordBitArray = new uint[32]; // An array of scanline bits 0..1024(32*32)
}

public class _VBICODECFILTERING_NABTS_SUBSTREAMS
{
    public uint[] SubstreamMask = new uint[128]; // An array of 4096 bits (one for each NABTS GroupID)
}

public class _VBICODECFILTERING_CC_SUBSTREAMS
{
    public uint SubstreamMask; // An array of 32 bits (see KS_CC_SUBSTREAM *)
}

// These KS_CC_SUBSTREAM_* bitmasks are used with VBICODECFILTERING_CC_SUBSTREAMS

// The following flags describe CC field 1 substreams: CC1,CC2,TT1,TT2

// The following flags describe CC field 2 substreams: CC3,CC4,TT3,TT4,XDS

// Special Note: field 1 or 2 substreams are usually on found on field 1 and 2 respectively
// If the VBI odd/even polarity is reversed, the correct filtered data will still be found.

/// ////////////////////////////////////////////////////////////////
// Hardware decoded CC stream format
/// ////////////////////////////////////////////////////////////////

public class _CC_BYTE_PAIR
{
    public byte[] Decoded = new byte[2];
    public ushort Reserved;
}

public class _CC_HW_FIELD
{
    public _VBICODECFILTERING_SCANLINES ScanlinesRequested = new _VBICODECFILTERING_SCANLINES();
    public uint fieldFlags; // KS_VBI_FLAG_FIELD1,2
    public long PictureNumber;
    public _CC_BYTE_PAIR[] Lines = Arrays.InitializeWithDefaultInstances<_CC_BYTE_PAIR>(DefineConstants.CC_MAX_HW_DECODE_LINES);
}

/// ////////////////////////////////////////////////////////////////
// Raw NABTS stream format (TYPE_NABTS, SUBTYPE_NABTS)
/// ////////////////////////////////////////////////////////////////

// These low-level structures are byte packed( -Zp1 )
#if ! PACK_PRAGMAS_NOT_SUPPORTED
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack1.h>
#endif
public class _NABTS_BUFFER_LINE
{
    public byte Confidence;
    public byte[] Bytes = new byte[DefineConstants.NABTS_BYTES_PER_LINE];
}

public class _NABTS_BUFFER
{
    public _VBICODECFILTERING_SCANLINES ScanlinesRequested = new _VBICODECFILTERING_SCANLINES();
    public long PictureNumber;
    public _NABTS_BUFFER_LINE[] NabtsLines = Arrays.InitializeWithDefaultInstances<_NABTS_BUFFER_LINE>(DefineConstants.MAX_NABTS_VBI_LINES_PER_FIELD);
}
#if ! PACK_PRAGMAS_NOT_SUPPORTED
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>
#endif

/// ///////////////////////////////////////////////////////////
// WST Codec Teletext Media Sample Format
/// ///////////////////////////////////////////////////////////



public class _WST_BUFFER_LINE
{
    public byte Confidence;
    public byte[] Bytes = new byte[DefineConstants.WST_BYTES_PER_LINE];
}

public class _WST_BUFFER
{
    public _VBICODECFILTERING_SCANLINES ScanlinesRequested = new _VBICODECFILTERING_SCANLINES();
    public _WST_BUFFER_LINE[] WstLines = Arrays.InitializeWithDefaultInstances<_WST_BUFFER_LINE>(DefineConstants.MAX_WST_VBI_LINES_PER_FIELD);
}

// 
// Common codec statistics
// 

public class _VBICODECFILTERING_STATISTICS_COMMON
{
    public uint InputSRBsProcessed; // upstream SRBs received
    public uint OutputSRBsProcessed; // downstream SRBs sent
    public uint SRBsIgnored; // SRBs ignored due to no requests
    public uint InputSRBsMissing; // SRBs dropped upstream
    public uint OutputSRBsMissing; // Output dropped because no SRB pending
    public uint OutputFailures; // dropped because of other failure
    public uint InternalErrors; // could not process due to int. failure
    public uint ExternalErrors; // could not process due to ext. failure
    public uint InputDiscontinuities; // discontinuities received
    public uint DSPFailures; // DSP confidence failure
    public uint TvTunerChanges; // number of received KS_TVTUNER_CHANGE_BEGIN_TUNE and KS_TVTUNER_CHANGE_END_TUNE pairs.
    public uint VBIHeaderChanges; // number of received KS_VBI_FLAG_VBIINFOHEADER_CHANGE
    public uint LineConfidenceAvg; // Average of all DSP confidence results
    public uint BytesOutput; // Bytes sent downstream
}

public class _VBICODECFILTERING_STATISTICS_COMMON_PIN
{
    public uint SRBsProcessed; // SRBs sent/received
    public uint SRBsIgnored; // SRBs ignored due to filtering
    public uint SRBsMissing; // SRBs not sent/received
    public uint InternalErrors; // could not send/receive due to int. failure
    public uint ExternalErrors; // could not send/receive due to ext. failure
    public uint Discontinuities; // discontinuities received/sent
    public uint LineConfidenceAvg; // Average of all DSP confidence results for this pin
    public uint BytesOutput; // Bytes sent downstream
}

// 
// Codec-specific statistics - NABTS
// 

public class _VBICODECFILTERING_STATISTICS_NABTS
{
    public _VBICODECFILTERING_STATISTICS_COMMON Common = new _VBICODECFILTERING_STATISTICS_COMMON(); // Generic VBI statistics
    public uint FECBundleBadLines; // Un-FEC-correctable lines
    public uint FECQueueOverflows; // Number of times FEC queue overflowed
    public uint FECCorrectedLines; // Lines CSUM corrected by FEC
    public uint FECUncorrectableLines; // FEC input lines not CSUM correctable
    public uint BundlesProcessed; // Bundles received from FEC
    public uint BundlesSent2IP; // Bundles sent to IP driver
    public uint FilteredLines; // Lines processed and then dropped
                                        // because no one was interested
}

public class _VBICODECFILTERING_STATISTICS_NABTS_PIN
{
    public _VBICODECFILTERING_STATISTICS_COMMON_PIN Common = new _VBICODECFILTERING_STATISTICS_COMMON_PIN(); // Generic VBI pin statistics
}

// 
// Codec-specific statistics - Closed Caption
// 

public class _VBICODECFILTERING_STATISTICS_CC
{
    public _VBICODECFILTERING_STATISTICS_COMMON Common = new _VBICODECFILTERING_STATISTICS_COMMON(); // Generic VBI statistics
}


public class _VBICODECFILTERING_STATISTICS_CC_PIN
{
    public _VBICODECFILTERING_STATISTICS_COMMON_PIN Common = new _VBICODECFILTERING_STATISTICS_COMMON_PIN(); // Generic VBI pin statistics
}

// 
// Codec-specific statistics - Closed Caption
// 

public class _VBICODECFILTERING_STATISTICS_TELETEXT
{
    public _VBICODECFILTERING_STATISTICS_COMMON Common = new _VBICODECFILTERING_STATISTICS_COMMON(); // Generic VBI statistics
}

public class _VBICODECFILTERING_STATISTICS_TELETEXT_PIN
{
    public _VBICODECFILTERING_STATISTICS_COMMON_PIN Common = new _VBICODECFILTERING_STATISTICS_COMMON_PIN(); // Generic VBI pin statistics
}

/// /////////////////////////////////////////////////////////////////////////
// VBI codec property structures(based on KSPROPERTY_VBICODECFILTERING enum)
/// /////////////////////////////////////////////////////////////////////////

// *** Most codecs support this property
//    KSPROPERTY_VBICODECFILTERING_SCANLINES_REQUESTED_BIT_ARRAY
//    KSPROPERTY_VBICODECFILTERING_SCANLINES_DISCOVERED_BIT_ARRAY,
public class KSPROPERTY_VBICODECFILTERING_SCANLINES_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_SCANLINES Scanlines = new _VBICODECFILTERING_SCANLINES();
}

// *** NABTS codecs support this property
//    KSPROPERTY_VBICODECFILTERING_SUBSTREAMS_REQUESTED_BIT_ARRAY,
//    KSPROPERTY_VBICODECFILTERING_SUBSTREAMS_DISCOVERED_BIT_ARRAY,
public class KSPROPERTY_VBICODECFILTERING_NABTS_SUBSTREAMS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_NABTS_SUBSTREAMS Substreams = new _VBICODECFILTERING_NABTS_SUBSTREAMS();
}

// *** Closed captioning codecs support this property
//    KSPROPERTY_VBICODECFILTERING_SUBSTREAMS_REQUESTED_BIT_ARRAY,
//    KSPROPERTY_VBICODECFILTERING_SUBSTREAMS_DISCOVERED_BIT_ARRAY,
public class KSPROPERTY_VBICODECFILTERING_CC_SUBSTREAMS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_CC_SUBSTREAMS Substreams = new _VBICODECFILTERING_CC_SUBSTREAMS();
}

// *** Most codecs support these versions of the global and pin properties
//    KSPROPERTY_VBICODECFILTERING_STATISTICS
public class KSPROPERTY_VBICODECFILTERING_STATISTICS_COMMON_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_STATISTICS_COMMON Statistics = new _VBICODECFILTERING_STATISTICS_COMMON();
}

public class KSPROPERTY_VBICODECFILTERING_STATISTICS_COMMON_PIN_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_STATISTICS_COMMON_PIN Statistics = new _VBICODECFILTERING_STATISTICS_COMMON_PIN();
}

// *** NABTS codecs support this version of the global and pin properties
//    KSPROPERTY_VBICODECFILTERING_STATISTICS
public class KSPROPERTY_VBICODECFILTERING_STATISTICS_NABTS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_STATISTICS_NABTS Statistics = new _VBICODECFILTERING_STATISTICS_NABTS();
}

public class KSPROPERTY_VBICODECFILTERING_STATISTICS_NABTS_PIN_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_STATISTICS_NABTS_PIN Statistics = new _VBICODECFILTERING_STATISTICS_NABTS_PIN();
}

// *** Closed captioning codecs support this version of the global and pin properties
//    KSPROPERTY_VBICODECFILTERING_STATISTICS

public class KSPROPERTY_VBICODECFILTERING_STATISTICS_CC_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_STATISTICS_CC Statistics = new _VBICODECFILTERING_STATISTICS_CC();
}

public class KSPROPERTY_VBICODECFILTERING_STATISTICS_CC_PIN_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public _VBICODECFILTERING_STATISTICS_CC_PIN Statistics = new _VBICODECFILTERING_STATISTICS_CC_PIN();
}

// Standard Pin Names for the video capture filter
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_CAPTURE 0xfb6c4281, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_CAPTURE STATIC_PINNAME_VIDEO_CAPTURE
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4281-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_CAPTURE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_CAPTURE DEFINE_GUIDNAMED(PINNAME_VIDEO_CAPTURE)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_CAPTURE PINNAME_VIDEO_CAPTURE

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_CC_CAPTURE 0x1aad8061, 0x12d, 0x11d2, 0xb4, 0xb1, 0x0, 0xa0, 0xd1, 0x2, 0xcf, 0xbe
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_CC_CAPTURE STATIC_PINNAME_VIDEO_CC_CAPTURE
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1AAD8061-012D-11d2-B4B1-00A0D102CFBE", PINNAME_VIDEO_CC_CAPTURE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_CC_CAPTURE DEFINE_GUIDNAMED(PINNAME_VIDEO_CC_CAPTURE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_NABTS_CAPTURE 0x29703660, 0x498a, 0x11d2, 0xb4, 0xb1, 0x0, 0xa0, 0xd1, 0x2, 0xcf, 0xbe
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_NABTS_CAPTURE STATIC_PINNAME_VIDEO_NABTS_CAPTURE
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("29703660-498A-11d2-B4B1-00A0D102CFBE", PINNAME_VIDEO_NABTS_CAPTURE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_NABTS_CAPTURE DEFINE_GUIDNAMED(PINNAME_VIDEO_NABTS_CAPTURE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_PREVIEW 0xfb6c4282, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_PREVIEW STATIC_PINNAME_VIDEO_PREVIEW
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4282-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_PREVIEW);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_PREVIEW DEFINE_GUIDNAMED(PINNAME_VIDEO_PREVIEW)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_PREVIEW PINNAME_VIDEO_PREVIEW

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_ANALOGVIDEOIN 0xfb6c4283, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4283-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_ANALOGVIDEOIN);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_ANALOGVIDEOIN DEFINE_GUIDNAMED(PINNAME_VIDEO_ANALOGVIDEOIN)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_VBI 0xfb6c4284, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4284-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_VBI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_VBI DEFINE_GUIDNAMED(PINNAME_VIDEO_VBI)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_VIDEOPORT 0xfb6c4285, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4285-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_VIDEOPORT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_VIDEOPORT DEFINE_GUIDNAMED(PINNAME_VIDEO_VIDEOPORT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_NABTS 0xfb6c4286, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4286-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_NABTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_NABTS DEFINE_GUIDNAMED(PINNAME_VIDEO_NABTS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_EDS 0xfb6c4287, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4287-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_EDS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_EDS DEFINE_GUIDNAMED(PINNAME_VIDEO_EDS)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_TELETEXT 0xfb6c4288, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4288-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_TELETEXT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_TELETEXT DEFINE_GUIDNAMED(PINNAME_VIDEO_TELETEXT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_CC 0xfb6c4289, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C4289-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_CC);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_CC DEFINE_GUIDNAMED(PINNAME_VIDEO_CC)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_STILL 0xfb6c428A, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C428A-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_STILL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_STILL DEFINE_GUIDNAMED(PINNAME_VIDEO_STILL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_TIMECODE 0xfb6c428B, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C428B-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_TIMECODE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_TIMECODE DEFINE_GUIDNAMED(PINNAME_VIDEO_TIMECODE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PINNAME_VIDEO_VIDEOPORT_VBI 0xfb6c428C, 0x353, 0x11d1, 0x90, 0x5f, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("FB6C428C-0353-11d1-905F-0000C0CC16BA", PINNAME_VIDEO_VIDEOPORT_VBI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PINNAME_VIDEO_VIDEOPORT_VBI DEFINE_GUIDNAMED(PINNAME_VIDEO_VIDEOPORT_VBI)

// ===========================================================================
// KSSTREAM_HEADER extensions for digital video
// ===========================================================================



public class tagKS_FRAME_INFO
{
    public uint ExtendedHeaderSize; // Size of this extended header
    public uint dwFrameFlags; // Field1, Field2, or Frame
    public long PictureNumber;
    public long DropCount;

    // The following are only set when using OverlayMixer
    public IntPtr hDirectDraw; // user mode DDraw handle
    public IntPtr hSurfaceHandle; // user mode surface handle
    public RECT DirectDrawRect = new RECT(); // portion of surface locked
    // Reserved fields, never reference these
    public uint Reserved1;
    public uint Reserved2;
    public uint Reserved3;
    public uint Reserved4;
}

// ===========================================================================
// KSSTREAM_HEADER extensions for VBI
// ===========================================================================




public class tagKS_VBI_FRAME_INFO
{
    public uint ExtendedHeaderSize; // Size of this extended header
    public uint dwFrameFlags; // Field1, Field2, or Frame; & etc
    public long PictureNumber; // Test only?
    public long DropCount; // Test only?
    public uint dwSamplingFrequency;
    public tagKS_TVTUNER_CHANGE_INFO TvTunerChangeInfo = new tagKS_TVTUNER_CHANGE_INFO();
    public tagKS_VBIINFOHEADER VBIInfoHeader = new tagKS_VBIINFOHEADER();
}


// ===========================================================================
// Analog video formats, used with:
//      Analog Video Decoders
//      TVTuners
//      Analog Video Encoders
// 
// XXX_STANDARDS_SUPPORTED returns a bitmask
// ===========================================================================

public enum KS_AnalogVideoStandard
{
    KS_AnalogVideo_None = 0x00000000, // This is a digital sensor
    KS_AnalogVideo_NTSC_M = 0x00000001, //        75 IRE Setup
    KS_AnalogVideo_NTSC_M_J = 0x00000002, // Japan,  0 IRE Setup
    KS_AnalogVideo_NTSC_433 = 0x00000004,

    KS_AnalogVideo_PAL_B = 0x00000010,
    KS_AnalogVideo_PAL_D = 0x00000020,
    KS_AnalogVideo_PAL_G = 0x00000040,
    KS_AnalogVideo_PAL_H = 0x00000080,
    KS_AnalogVideo_PAL_I = 0x00000100,
    KS_AnalogVideo_PAL_M = 0x00000200,
    KS_AnalogVideo_PAL_N = 0x00000400,

    KS_AnalogVideo_PAL_60 = 0x00000800,

    KS_AnalogVideo_SECAM_B = 0x00001000,
    KS_AnalogVideo_SECAM_D = 0x00002000,
    KS_AnalogVideo_SECAM_G = 0x00004000,
    KS_AnalogVideo_SECAM_H = 0x00008000,
    KS_AnalogVideo_SECAM_K = 0x00010000,
    KS_AnalogVideo_SECAM_K1 = 0x00020000,
    KS_AnalogVideo_SECAM_L = 0x00040000,
    KS_AnalogVideo_SECAM_L1 = 0x00080000,

    KS_AnalogVideo_PAL_N_COMBO = 0x00100000
}


// ===========================================================================
// Property set definitions
// The comments show whether a given property is:
//      R  : READ only
//      w  : WRITE only
//      RW : READ / WRITE
//      O  : Optional (return E_UNSUPPORTED if you don't handle this)
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_ALLOCATOR_CONTROL 0x53171960, 0x148e, 0x11d2, 0x99, 0x79, 0x0, 0x0, 0xc0, 0xcc, 0x16, 0xba
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("53171960-148E-11d2-9979-0000C0CC16BA", PROPSETID_ALLOCATOR_CONTROL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_ALLOCATOR_CONTROL DEFINE_GUIDNAMED(PROPSETID_ALLOCATOR_CONTROL)
public enum KSPROPERTY_ALLOCATOR_CONTROL
{
    KSPROPERTY_ALLOCATOR_CONTROL_HONOR_COUNT, // R O (will allocate exactly this number of buffers)
    KSPROPERTY_ALLOCATOR_CONTROL_SURFACE_SIZE, // R O (return 2 DWORDs specifying surface size)
    // W I (informn a capture driver whether interleave capture is possible or
    //      not - a value of 1 means that interleaved capture is supported)
    KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS,

    // R O (if value == 1, then the ovmixer will turn on the DDVP_INTERLEAVE
    //      flag thus allowing interleaved capture of the video)
    KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE
}

public class KSPROPERTY_ALLOCATOR_CONTROL_SURFACE_SIZE_S
{
    // KSPROPERTY Property;
    public uint CX;
    public uint CY;
}

public class KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_CAPS_S
{
    // KSPROPERTY Property;
    public uint InterleavedCapSupported;
}


public class KSPROPERTY_ALLOCATOR_CONTROL_CAPTURE_INTERLEAVE_S
{
    // KSPROPERTY Property;
    public uint InterleavedCapPossible;
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_VIDEOPROCAMP 0xC6E13360L, 0x30AC, 0x11d0, 0xa1, 0x8c, 0x00, 0xA0, 0xC9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C6E13360-30AC-11d0-A18C-00A0C9118956", PROPSETID_VIDCAP_VIDEOPROCAMP);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_VIDEOPROCAMP DEFINE_GUIDNAMED(PROPSETID_VIDCAP_VIDEOPROCAMP)

public enum KSPROPERTY_VIDCAP_VIDEOPROCAMP
{
    KSPROPERTY_VIDEOPROCAMP_BRIGHTNESS, // RW O
    KSPROPERTY_VIDEOPROCAMP_CONTRAST, // RW O
    KSPROPERTY_VIDEOPROCAMP_HUE, // RW O
    KSPROPERTY_VIDEOPROCAMP_SATURATION, // RW O
    KSPROPERTY_VIDEOPROCAMP_SHARPNESS, // RW O
    KSPROPERTY_VIDEOPROCAMP_GAMMA, // RW O
    KSPROPERTY_VIDEOPROCAMP_COLORENABLE, // RW O
    KSPROPERTY_VIDEOPROCAMP_WHITEBALANCE, // RW O
    KSPROPERTY_VIDEOPROCAMP_BACKLIGHT_COMPENSATION, // RW O
    KSPROPERTY_VIDEOPROCAMP_GAIN, // RW O
    KSPROPERTY_VIDEOPROCAMP_DIGITAL_MULTIPLIER, // RW O
    KSPROPERTY_VIDEOPROCAMP_DIGITAL_MULTIPLIER_LIMIT, // RW O
    KSPROPERTY_VIDEOPROCAMP_WHITEBALANCE_COMPONENT, // RW O
    KSPROPERTY_VIDEOPROCAMP_POWERLINE_FREQUENCY // RW O
}

public class KSPROPERTY_VIDEOPROCAMP_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int Value; // Value to set or get
    public uint Flags; // KSPROPERTY_VIDEOPROCAMP_FLAGS_*
    public uint Capabilities; // KSPROPERTY_VIDEOPROCAMP_FLAGS_*
}

public class KSPROPERTY_VIDEOPROCAMP_NODE_S
{
    public KSP_NODE NodeProperty = new KSP_NODE();
    public int Value; // Value to set or get
    public uint Flags; // KSPROPERTY_VIDEOPROCAMP_FLAGS_*
    public uint Capabilities; // KSPROPERTY_VIDEOPROCAMP_FLAGS_*
}

public class KSPROPERTY_VIDEOPROCAMP_S2
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int Value1;
    public uint Flags;
    public uint Capabilities;
    public int Value2;
}

public class KSPROPERTY_VIDEOPROCAMP_NODE_S2
{
    public KSP_NODE NodeProperty = new KSP_NODE();
    public int Value1;
    public uint Flags;
    public uint Capabilities;
    public int Value2;
}


// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_SELECTOR 0x1ABDAECA, 0x68B6, 0x4F83, 0x93, 0x71, 0xB4, 0x13, 0x90, 0x7C, 0x7B, 0x9F
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1ABDAECA-68B6-4F83-9371-B413907C7B9F", PROPSETID_VIDCAP_SELECTOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_SELECTOR DEFINE_GUIDNAMED(PROPSETID_VIDCAP_SELECTOR)

public enum KSPROPERTY_VIDCAP_SELECTOR
{
    KSPROPERTY_SELECTOR_SOURCE_NODE_ID, // RW
    KSPROPERTY_SELECTOR_NUM_SOURCES // R
}

public class KSPROPERTY_SELECTOR_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int Value; // Value to set or get
    public uint Flags;
    public uint Capabilities;
}

public class KSPROPERTY_SELECTOR_NODE_S
{
    public KSP_NODE NodeProperty = new KSP_NODE();
    public int Value; // Value to set or get
    public uint Flags;
    public uint Capabilities;
}


// ===========================================================================


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_TUNER 0x6a2e0605L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0605-28e4-11d0-a18c-00a0c9118956", PROPSETID_TUNER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_TUNER DEFINE_GUIDNAMED(PROPSETID_TUNER)

public enum KSPROPERTY_TUNER
{
    KSPROPERTY_TUNER_CAPS, // R  -overall device capabilities
    KSPROPERTY_TUNER_MODE_CAPS, // R  -capabilities in this mode
    KSPROPERTY_TUNER_MODE, // RW -set a mode (TV, FM, AM, DSS)
    KSPROPERTY_TUNER_STANDARD, // R  -get TV standard (only if TV mode)
    KSPROPERTY_TUNER_FREQUENCY, // RW -set/get frequency
    KSPROPERTY_TUNER_INPUT, // RW -select an input
    KSPROPERTY_TUNER_STATUS, // R  -tuning status
    KSPROPERTY_TUNER_IF_MEDIUM // R O-Medium for IF or Transport Pin
}

public enum KSPROPERTY_TUNER_MODES
{
    KSPROPERTY_TUNER_MODE_TV = 0X0001,
    KSPROPERTY_TUNER_MODE_FM_RADIO = 0X0002,
    KSPROPERTY_TUNER_MODE_AM_RADIO = 0X0004,
    KSPROPERTY_TUNER_MODE_DSS = 0X0008,
    KSPROPERTY_TUNER_MODE_ATSC = 0X0010 // also used for DVB-T, DVB-C
}

// Describes how the device tunes.  Only one of these flags may be set
// in KSPROPERTY_TUNER_MODE_CAPS_S.Strategy

// Describe how the driver should attempt to tune:
// EXACT:   just go to the frequency specified (no fine tuning)
// FINE:    (slow) do an exhaustive search for the best signal
// COARSE:  (fast) use larger frequency jumps to just determine if any signal

public enum KS_TUNER_TUNING_FLAGS
{
    KS_TUNER_TUNING_EXACT = 1, // No fine tuning
    KS_TUNER_TUNING_FINE, // Fine grained search
    KS_TUNER_TUNING_COARSE // Coarse search
}

public enum KS_TUNER_STRATEGY
{
    KS_TUNER_STRATEGY_PLL = 0X01, // Tune by PLL offset
    KS_TUNER_STRATEGY_SIGNAL_STRENGTH = 0X02, // Tune by signal strength
    KS_TUNER_STRATEGY_DRIVER_TUNES = 0X04 // Driver does fine tuning
}

public class KSPROPERTY_TUNER_CAPS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint ModesSupported; // KS_PROPERTY_TUNER_MODES_*
    public KSPIN_MEDIUM VideoMedium = new KSPIN_MEDIUM(); // GUID_NULL (no pin), or GUID
    public KSPIN_MEDIUM TVAudioMedium = new KSPIN_MEDIUM(); // GUID_NULL (no pin), or GUID
    public KSPIN_MEDIUM RadioAudioMedium = new KSPIN_MEDIUM(); // GUID_NULL (no pin), or GUID
}

public class KSPROPERTY_TUNER_IF_MEDIUM_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public KSPIN_MEDIUM IFMedium = new KSPIN_MEDIUM(); // GUID_NULL (no pin), or GUID
}

public class KSPROPERTY_TUNER_MODE_CAPS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Mode; // IN: KSPROPERTY_TUNER_MODE
    public uint StandardsSupported; // KS_AnalogVideo_* (if TV or DSS)
    public uint MinFrequency; // Hz
    public uint MaxFrequency; // Hz
    public uint TuningGranularity; // Hz
    public uint NumberOfInputs; // count of inputs
    public uint SettlingTime; // milliSeconds
    public uint Strategy; // KS_TUNER_STRATEGY
}

public class KSPROPERTY_TUNER_MODE_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Mode; // IN: KSPROPERTY_TUNER_MODE
}

public class KSPROPERTY_TUNER_FREQUENCY_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Frequency; // Hz
    public uint LastFrequency; // Hz (last known good)
    public uint TuningFlags; // KS_TUNER_TUNING_FLAGS
    public uint VideoSubChannel; // DSS
    public uint AudioSubChannel; // DSS
    public uint Channel; // VBI decoders
    public uint Country; // VBI decoders
}

public class KSPROPERTY_TUNER_STANDARD_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Standard; // KS_AnalogVideo_*
}

public class KSPROPERTY_TUNER_INPUT_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint InputIndex; // 0 to (n-1) inputs
}

public class KSPROPERTY_TUNER_STATUS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint CurrentFrequency; // Hz
    public uint PLLOffset; // if Strategy.KS_TUNER_STRATEGY_PLL
    public uint SignalStrength; // if Stretegy.KS_TUNER_STRATEGY_SIGNAL_STRENGTH
    public uint Busy; // TRUE if in the process of tuning
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_EVENTSETID_TUNER 0x6a2e0606L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0606-28e4-11d0-a18c-00a0c9118956", EVENTSETID_TUNER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EVENTSETID_TUNER DEFINE_GUIDNAMED(EVENTSETID_TUNER)

public enum KSEVENT_TUNER
{
    KSEVENT_TUNER_CHANGED
}


// ===========================================================================

// USB Video Class Definitions

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_STREAMING 0xDFF229E1L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E1-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_STREAMING);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_STREAMING DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_STREAMING)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_INPUT_TERMINAL 0xDFF229E2L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E2-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_INPUT_TERMINAL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_INPUT_TERMINAL DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_INPUT_TERMINAL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_OUTPUT_TERMINAL 0xDFF229E3L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E3-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_OUTPUT_TERMINAL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_OUTPUT_TERMINAL DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_OUTPUT_TERMINAL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_SELECTOR 0xDFF229E4L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E4-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_SELECTOR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_SELECTOR DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_SELECTOR)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_PROCESSING 0xDFF229E5L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E5-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_PROCESSING);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_PROCESSING DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_PROCESSING)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_CAMERA_TERMINAL 0xDFF229E6L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E6-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_CAMERA_TERMINAL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_CAMERA_TERMINAL DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_CAMERA_TERMINAL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_INPUT_MTT 0xDFF229E7L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E7-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_INPUT_MTT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_INPUT_MTT DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_INPUT_MTT)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSNODETYPE_VIDEO_OUTPUT_MTT 0xDFF229E8L, 0xF70F, 0x11D0, 0xB9, 0x17, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DFF229E8-F70F-11D0-B917-00A0C9223196", KSNODETYPE_VIDEO_OUTPUT_MTT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSNODETYPE_VIDEO_OUTPUT_MTT DEFINE_GUIDNAMED(KSNODETYPE_VIDEO_OUTPUT_MTT)

// ===========================================================================


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_VIDEOENCODER 0x6a2e0610L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0610-28e4-11d0-a18c-00a0c9118956", PROPSETID_VIDCAP_VIDEOENCODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_VIDEOENCODER DEFINE_GUIDNAMED(PROPSETID_VIDCAP_VIDEOENCODER)

public enum KSPROPERTY_VIDCAP_VIDEOENCODER
{
    KSPROPERTY_VIDEOENCODER_CAPS, // R
    KSPROPERTY_VIDEOENCODER_STANDARD, // RW
    KSPROPERTY_VIDEOENCODER_COPYPROTECTION, // RW O
    KSPROPERTY_VIDEOENCODER_CC_ENABLE // RW O
}

public class KSPROPERTY_VIDEOENCODER_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int Value; // value to get or set
    public uint Flags;
    public uint Capabilities;
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_VIDEODECODER 0xC6E13350L, 0x30AC, 0x11d0, 0xA1, 0x8C, 0x00, 0xA0, 0xC9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C6E13350-30AC-11d0-A18C-00A0C9118956", PROPSETID_VIDCAP_VIDEODECODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_VIDEODECODER DEFINE_GUIDNAMED(PROPSETID_VIDCAP_VIDEODECODER)

public enum KSPROPERTY_VIDCAP_VIDEODECODER
{
    KSPROPERTY_VIDEODECODER_CAPS, // R
    KSPROPERTY_VIDEODECODER_STANDARD, // RW
    KSPROPERTY_VIDEODECODER_STATUS, // R
    KSPROPERTY_VIDEODECODER_OUTPUT_ENABLE, // Rw O
    KSPROPERTY_VIDEODECODER_VCR_TIMING // RW O
}

public enum KS_VIDEODECODER_FLAGS
{
    KS_VIDEODECODER_FLAGS_CAN_DISABLE_OUTPUT = 0X0001, // VP Output can tri-stae
    KS_VIDEODECODER_FLAGS_CAN_USE_VCR_LOCKING = 0X0002, // VCR PLL timings
    KS_VIDEODECODER_FLAGS_CAN_INDICATE_LOCKED = 0X0004 // Can indicate valid signal
}

public class KSPROPERTY_VIDEODECODER_CAPS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StandardsSupported; // KS_AnalogVideo_*
    public uint Capabilities; // KS_VIDEODECODER_FLAGS_*
    public uint SettlingTime; // milliseconds
    public uint HSyncPerVSync; // Number of HSync Pulses per VSync
}

public class KSPROPERTY_VIDEODECODER_STATUS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint NumberOfLines; // 525 or 625 lines detected
    public uint SignalLocked; // TRUE if signal is locked
}

public class KSPROPERTY_VIDEODECODER_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Value; // Get or set a value
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_EVENTSETID_VIDEODECODER 0x6a2e0621L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0621-28e4-11d0-a18c-00a0c9118956", EVENTSETID_VIDEODECODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EVENTSETID_VIDEODECODER DEFINE_GUIDNAMED(EVENTSETID_VIDEODECODER)

public enum KSEVENT_VIDEODECODER
{
    KSEVENT_VIDEODECODER_CHANGED
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_CAMERACONTROL 0xC6E13370L, 0x30AC, 0x11d0, 0xa1, 0x8C, 0x00, 0xA0, 0xC9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C6E13370-30AC-11d0-A18C-00A0C9118956", PROPSETID_VIDCAP_CAMERACONTROL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_CAMERACONTROL DEFINE_GUIDNAMED(PROPSETID_VIDCAP_CAMERACONTROL)

public enum KSPROPERTY_VIDCAP_CAMERACONTROL
{
    KSPROPERTY_CAMERACONTROL_PAN, // RW O
    KSPROPERTY_CAMERACONTROL_TILT, // RW O
    KSPROPERTY_CAMERACONTROL_ROLL, // RW O
    KSPROPERTY_CAMERACONTROL_ZOOM, // RW O
    KSPROPERTY_CAMERACONTROL_EXPOSURE, // RW O
    KSPROPERTY_CAMERACONTROL_IRIS, // RW O
    KSPROPERTY_CAMERACONTROL_FOCUS, // RW O
    KSPROPERTY_CAMERACONTROL_SCANMODE, // RW O
    KSPROPERTY_CAMERACONTROL_PRIVACY, // RW O
    KSPROPERTY_CAMERACONTROL_PANTILT, // RW O
    KSPROPERTY_CAMERACONTROL_PAN_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_TILT_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_ROLL_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_ZOOM_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_EXPOSURE_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_IRIS_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_FOCUS_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_PANTILT_RELATIVE, // RW O
    KSPROPERTY_CAMERACONTROL_FOCAL_LENGTH // R O
}

public class KSPROPERTY_CAMERACONTROL_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int Value; // value to get or set
    public uint Flags; // KSPROPERTY_CAMERACONTROL_FLAGS_*
    public uint Capabilities; // KSPROPERTY_CAMERACONTROL_FLAGS_*
}

public class KSPROPERTY_CAMERACONTROL_NODE_S
{
    public KSP_NODE NodeProperty = new KSP_NODE();
    public int Value; // value to get or set
    public uint Flags; // KSPROPERTY_CAMERACONTROL_FLAGS_*
    public uint Capabilities; // KSPROPERTY_CAMERACONTROL_FLAGS_*
}

public class KSPROPERTY_CAMERACONTROL_S2
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int Value1;
    public uint Flags;
    public uint Capabilities;
    public int Value2;
}

public class KSPROPERTY_CAMERACONTROL_NODE_S2
{
    public KSP_NODE NodeProperty = new KSP_NODE();
    public int Value1;
    public uint Flags;
    public uint Capabilities;
    public int Value2;
}

public class KSPROPERTY_CAMERACONTROL_FOCAL_LENGTH_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public int lOcularFocalLength;
    public int lObjectiveFocalLengthMin;
    public int lObjectiveFocalLengthMax;
}

public class KSPROPERTY_CAMERACONTROL_NODE_FOCAL_LENGTH_S
{
    public KSNODEPROPERTY NodeProperty = new KSNODEPROPERTY();
    public int lOcularFocalLength;
    public int lObjectiveFocalLengthMin;
    public int lObjectiveFocalLengthMax;
}



// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_EXT_DEVICE 0xB5730A90L, 0x1A2C, 0x11cf, 0x8c, 0x23, 0x00, 0xAA, 0x00, 0x6B, 0x68, 0x14
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("B5730A90-1A2C-11cf-8C23-00AA006B6814", PROPSETID_EXT_DEVICE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_EXT_DEVICE DEFINE_GUIDNAMED(PROPSETID_EXT_DEVICE)

public enum KSPROPERTY_EXTDEVICE
{
    KSPROPERTY_EXTDEVICE_ID, // R
    KSPROPERTY_EXTDEVICE_VERSION, // R
    KSPROPERTY_EXTDEVICE_POWER_STATE, // RW
    KSPROPERTY_EXTDEVICE_PORT, // R
    KSPROPERTY_EXTDEVICE_CAPABILITIES // R
}

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
    public int SimulatedHardware;
}

public class KSPROPERTY_EXTDEVICE_S
{
    public KSPROPERTY Property = new KSPROPERTY();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        tagDEVCAPS Capabilities; // Device capabilities
//        uint DevPort; // 1394, USB, etc.
//        uint PowerState; // On, standby or off
//        char pawchString[MAX_PATH]; // Version
//        uint NodeUniqueID[2]; // Unique NodeID
//    }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    u;
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_EXT_TRANSPORT 0xA03CD5F0L, 0x3045, 0x11cf, 0x8c, 0x44, 0x00, 0xAA, 0x00, 0x6B, 0x68, 0x14
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A03CD5F0-3045-11cf-8C44-00AA006B6814", PROPSETID_EXT_TRANSPORT);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_EXT_TRANSPORT DEFINE_GUIDNAMED(PROPSETID_EXT_TRANSPORT)

public enum KSPROPERTY_EXTXPORT
{
    KSPROPERTY_EXTXPORT_CAPABILITIES, // (R)  Transport specific capability
    KSPROPERTY_EXTXPORT_INPUT_SIGNAL_MODE, // (RW) Input signal: e.g. dvsd/NTSC/PAL, dvsl/NTSC/PAL, MPEG2-TS etc
    KSPROPERTY_EXTXPORT_OUTPUT_SIGNAL_MODE, // (RW) Output signal: e.g. dvsd/NTSC/PAL, dvsl/NTSC/PAL, MPEG2-TS etc
    KSPROPERTY_EXTXPORT_LOAD_MEDIUM, // (RW) Eject, open tray, close tray
    KSPROPERTY_EXTXPORT_MEDIUM_INFO, // (R)  Cassettte type, tape grade and write protection
    KSPROPERTY_EXTXPORT_STATE, // (RW) Current transport mode and state
    KSPROPERTY_EXTXPORT_STATE_NOTIFY, // (RW) Notify of transport mode and state change
    KSPROPERTY_EXTXPORT_TIMECODE_SEARCH, // (W)  Search to a specific timecode on a tape
    KSPROPERTY_EXTXPORT_ATN_SEARCH, // (W)  Search to a specific absolute track number (ATN) on a tape
    KSPROPERTY_EXTXPORT_RTC_SEARCH, // (W)  Search to a specific relative time counter (RTC) on a tape
    KSPROPERTY_RAW_AVC_CMD // (RW) Issue a raw AVC commnad
}

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

public class tagTRANSPORTVIDEOPARMS
{
    public int OutputMode;
    public int Input;
}

public class tagTRANSPORTAUDIOPARMS
{
    public int EnableOutput;
    public int EnableRecord;
    public int EnableSelsync;
    public int Input;
    public int MonitorSource;
}

public class MEDIUM_INFO
{
    public bool MediaPresent;
    public uint MediaType;
    public bool RecordInhibit;
}

public class TRANSPORT_STATE
{
    public uint Mode;
    public uint State;
}

public class KSPROPERTY_EXTXPORT_S
{
    public KSPROPERTY Property = new KSPROPERTY();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint Capabilities;
//        uint SignalMode;
//        uint LoadMedium;
//        MEDIUM_INFO MediumInfo;
//        TRANSPORT_STATE XPrtState;
//        struct
//        {
//          byte frame;
//          byte second;
//          byte minute;
//          byte hour;
//        }
//        Timecode;
//        uint dwTimecode;
//        uint dwAbsTrackNumber;
//        struct
//        {
//            uint PayloadSize;
//            byte Payload[512];
//        }
//        RawAVC;
//    }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    u;

}

public class KSPROPERTY_EXTXPORT_NODE_S
{
    public KSP_NODE NodeProperty = new KSP_NODE();
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//        uint Capabilities;
//        uint SignalMode;
//        uint LoadMedium;
//        MEDIUM_INFO MediumInfo;
//        TRANSPORT_STATE XPrtState;
//        struct
//        {
//          byte frame;
//          byte second;
//          byte minute;
//          byte hour;
//        }
//        Timecode;
//        uint dwTimecode;
//        uint dwAbsTrackNumber;
//        struct
//        {
//            uint PayloadSize;
//            byte Payload[512];
//        }
//        RawAVC;
//    }
// C++ TO C# CONVERTER NOTE: Access declarations are not available in C#:
//    u;

}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_TIMECODE_READER 0x9B496CE1L, 0x811B, 0x11cf, 0x8C, 0x77, 0x00, 0xAA, 0x00, 0x6B, 0x68, 0x14
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("9B496CE1-811B-11cf-8C77-00AA006B6814", PROPSETID_TIMECODE_READER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_TIMECODE_READER DEFINE_GUIDNAMED(PROPSETID_TIMECODE_READER)

public enum KSPROPERTY_TIMECODE
{
    KSPROPERTY_TIMECODE_READER, // (R) Timecode for the current tape position
    KSPROPERTY_ATN_READER, // (R) Absolute track number for the current tape position
    KSPROPERTY_RTC_READER // (R) Relative time counter for the current tape position
}

// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union _timecode
// {
//    struct
//    {
//        ushort wFrameRate;
//        ushort wFrameFract;
//        uint dwFrames;
//        };
//    ulong qw;
// };

public class tagTIMECODE_SAMPLE
{
    public long qwTick;
    public TIMECODE timecode = new TIMECODE();
    public uint dwUser;
    public uint dwFlags;
}



public class KSPROPERTY_TIMECODE_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public tagTIMECODE_SAMPLE TimecodeSamp = new tagTIMECODE_SAMPLE();
}

public class KSPROPERTY_TIMECODE_NODE_S
{
    public KSP_NODE NodeProperty = new KSP_NODE();
    public tagTIMECODE_SAMPLE TimecodeSamp = new tagTIMECODE_SAMPLE();
}

// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_EXTDEV_Command 0x109c7988L, 0xb3cb, 0x11d2, 0xb4, 0x8e, 0x00, 0x60, 0x97, 0xb3, 0x39, 0x1b
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("109c7988-b3cb-11d2-b48e-006097b3391b", KSEVENTSETID_EXTDEV_Command);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_EXTDEV_Command DEFINE_GUIDNAMED(KSEVENTSETID_EXTDEV_Command)

public enum KSEVENT_DEVCMD
{
    KSEVENT_EXTDEV_COMMAND_NOTIFY_INTERIM_READY, // Final response is ready for notify command
    KSEVENT_EXTDEV_COMMAND_CONTROL_INTERIM_READY, // Final response is ready for control command.
    KSEVENT_EXTDEV_COMMAND_BUSRESET, // A bus reset has occured.
    KSEVENT_EXTDEV_TIMECODE_UPDATE, // Timecode has changed.
    KSEVENT_EXTDEV_OPERATION_MODE_UPDATE, // Operting mode (VCR,Camera, etc.) has changed.
    KSEVENT_EXTDEV_TRANSPORT_STATE_UPDATE, // Transport state has changed.
    KSEVENT_EXTDEV_NOTIFY_REMOVAL, // Device was surprise removal.
    KSEVENT_EXTDEV_NOTIFY_MEDIUM_CHANGE // Tape medium is removed or added.
}



// ===========================================================================


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_CROSSBAR 0x6a2e0640L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0640-28e4-11d0-a18c-00a0c9118956", PROPSETID_VIDCAP_CROSSBAR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_CROSSBAR DEFINE_GUIDNAMED(PROPSETID_VIDCAP_CROSSBAR)

public enum KSPROPERTY_VIDCAP_CROSSBAR
{
    KSPROPERTY_CROSSBAR_CAPS, // R
    KSPROPERTY_CROSSBAR_PININFO, // R
    KSPROPERTY_CROSSBAR_CAN_ROUTE, // R
    KSPROPERTY_CROSSBAR_ROUTE // RW
}

public class KSPROPERTY_CROSSBAR_CAPS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint NumberOfInputs; // the number of audio and video input pins
    public uint NumberOfOutputs; // the number of audio and video output pins
}

public class KSPROPERTY_CROSSBAR_PININFO_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public KSPIN_DATAFLOW Direction = new KSPIN_DATAFLOW(); // KSPIN_DATAFLOW_IN or KSPIN_DATAFLOW_OUT?
    public uint Index; // Which pin to return data for?
    public uint PinType; // KS_PhysConn_Video_* or KS_PhysConn_Audio_*
    public uint RelatedPinIndex; // For video pins, this is the related audio pin
    public KSPIN_MEDIUM Medium = new KSPIN_MEDIUM(); // Identifies the hardware connection
}

public class KSPROPERTY_CROSSBAR_ROUTE_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint IndexInputPin; // Zero based index of the input pin
    public uint IndexOutputPin; // Zero based index of the output pin
    public uint CanRoute; // returns non-zero on CAN_ROUTE if routing is possible
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_EVENTSETID_CROSSBAR 0x6a2e0641L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0641-28e4-11d0-a18c-00a0c9118956", EVENTSETID_CROSSBAR);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define EVENTSETID_CROSSBAR DEFINE_GUIDNAMED(EVENTSETID_CROSSBAR)

public enum KSEVENT_CROSSBAR
{
    KSEVENT_CROSSBAR_CHANGED
}

// The following IDs should match the AM equivalents
public enum KS_PhysicalConnectorType
{
    KS_PhysConn_Video_Tuner = 1,
    KS_PhysConn_Video_Composite,
    KS_PhysConn_Video_SVideo,
    KS_PhysConn_Video_RGB,
    KS_PhysConn_Video_YRYBY,
    KS_PhysConn_Video_SerialDigital,
    KS_PhysConn_Video_ParallelDigital,
    KS_PhysConn_Video_SCSI,
    KS_PhysConn_Video_AUX,
    KS_PhysConn_Video_1394,
    KS_PhysConn_Video_USB,
    KS_PhysConn_Video_VideoDecoder,
    KS_PhysConn_Video_VideoEncoder,
    KS_PhysConn_Video_SCART,

    KS_PhysConn_Audio_Tuner = 4096,
    KS_PhysConn_Audio_Line,
    KS_PhysConn_Audio_Mic,
    KS_PhysConn_Audio_AESDigital,
    KS_PhysConn_Audio_SPDIFDigital,
    KS_PhysConn_Audio_SCSI,
    KS_PhysConn_Audio_AUX,
    KS_PhysConn_Audio_1394,
    KS_PhysConn_Audio_USB,
    KS_PhysConn_Audio_AudioDecoder
}


// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_TVAUDIO 0x6a2e0650L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0650-28e4-11d0-a18c-00a0c9118956", PROPSETID_VIDCAP_TVAUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_TVAUDIO DEFINE_GUIDNAMED(PROPSETID_VIDCAP_TVAUDIO)

public enum KSPROPERTY_VIDCAP_TVAUDIO
{
    KSPROPERTY_TVAUDIO_CAPS, // R
    KSPROPERTY_TVAUDIO_MODE, // RW
    KSPROPERTY_TVAUDIO_CURRENTLY_AVAILABLE_MODES // R
}


public class KSPROPERTY_TVAUDIO_CAPS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Capabilities; // Bitmask of KS_TVAUDIO_MODE_*
    public KSPIN_MEDIUM InputMedium = new KSPIN_MEDIUM();
    public KSPIN_MEDIUM OutputMedium = new KSPIN_MEDIUM();
}

public class KSPROPERTY_TVAUDIO_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint Mode; // KS_TVAUDIO_MODE_*
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_VIDCAP_TVAUDIO 0x6a2e0651L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0651-28e4-11d0-a18c-00a0c9118956", KSEVENTSETID_VIDCAP_TVAUDIO);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_VIDCAP_TVAUDIO DEFINE_GUIDNAMED(KSEVENTSETID_VIDCAP_TVAUDIO)

public enum KSEVENT_TVAUDIO
{
    KSEVENT_TVAUDIO_CHANGED
}

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_VIDEOCOMPRESSION 0xC6E13343L, 0x30AC, 0x11d0, 0xA1, 0x8C, 0x00, 0xA0, 0xC9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C6E13343-30AC-11d0-A18C-00A0C9118956", PROPSETID_VIDCAP_VIDEOCOMPRESSION);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_VIDEOCOMPRESSION DEFINE_GUIDNAMED(PROPSETID_VIDCAP_VIDEOCOMPRESSION)

public enum KSPROPERTY_VIDCAP_VIDEOCOMPRESSION
{
    KSPROPERTY_VIDEOCOMPRESSION_GETINFO, // R
    KSPROPERTY_VIDEOCOMPRESSION_KEYFRAME_RATE, // RW
    KSPROPERTY_VIDEOCOMPRESSION_PFRAMES_PER_KEYFRAME, // RW
    KSPROPERTY_VIDEOCOMPRESSION_QUALITY, // RW
    KSPROPERTY_VIDEOCOMPRESSION_OVERRIDE_KEYFRAME, // W
    KSPROPERTY_VIDEOCOMPRESSION_OVERRIDE_FRAME_SIZE, // W
    KSPROPERTY_VIDEOCOMPRESSION_WINDOWSIZE // RW
}

public enum KS_CompressionCaps
{
    KS_CompressionCaps_CanQuality = 1,
    KS_CompressionCaps_CanCrunch = 2,
    KS_CompressionCaps_CanKeyFrame = 4,
    KS_CompressionCaps_CanBFrame = 8,
    KS_CompressionCaps_CanWindow = 0x10
}

public class KSPROPERTY_VIDEOCOMPRESSION_GETINFO_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    // Note, no VersionString!
    // Note, no DescriptionString!
    public uint StreamIndex; // zero based index of stream
    public int DefaultKeyFrameRate; // Key frame rate
    public int DefaultPFrameRate; // Predeicted frames per Key frame
    public int DefaultQuality; // 0 to 10000
    public int NumberOfQualitySettings; // How many discreet quality settings?
    public int Capabilities; // KS_CompressionCaps_*
}

public class KSPROPERTY_VIDEOCOMPRESSION_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StreamIndex; // zero based index of stream
    public int Value; // value to get or set
}

// ===========================================================================
// MEDIASUBTYPE_Overlay
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_OVERLAY 0xe436eb7fL, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("e436eb7f-524f-11ce-9f53-0020af0ba770", KSDATAFORMAT_SUBTYPE_OVERLAY);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_OVERLAY DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_OVERLAY)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_OverlayUpdate 0x490EA5CFL, 0x7681, 0x11D1, 0xA2, 0x1C, 0x00, 0xA0, 0xC9, 0x22, 0x31, 0x96
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("490EA5CF-7681-11D1-A21C-00A0C9223196", KSPROPSETID_OverlayUpdate);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_OverlayUpdate DEFINE_GUIDNAMED(KSPROPSETID_OverlayUpdate)

public enum KSPROPERTY_OVERLAYUPDATE
{
    KSPROPERTY_OVERLAYUPDATE_INTERESTS,
    KSPROPERTY_OVERLAYUPDATE_CLIPLIST = 0x1,
    KSPROPERTY_OVERLAYUPDATE_PALETTE = 0x2,
    KSPROPERTY_OVERLAYUPDATE_COLORKEY = 0x4,
    KSPROPERTY_OVERLAYUPDATE_VIDEOPOSITION = 0x8,
    KSPROPERTY_OVERLAYUPDATE_DISPLAYCHANGE = 0x10,
    KSPROPERTY_OVERLAYUPDATE_COLORREF = 0x10000000
}

public class KSDISPLAYCHANGE
{
    public uint PelsWidth;
    public uint PelsHeight;
    public uint BitsPerPel;
    public string DeviceID = new string(new char[1]);
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_INTERESTS(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_INTERESTS, (Handler), sizeof(KSPROPERTY), sizeof(ULONG), NULL, NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_PALETTE(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_PALETTE, NULL, sizeof(KSPROPERTY), 0, (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_COLORKEY(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_COLORKEY, NULL, sizeof(KSPROPERTY), sizeof(COLORKEY), (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_CLIPLIST(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_CLIPLIST, NULL, sizeof(KSPROPERTY), 2 * sizeof(RECT) + sizeof(RGNDATAHEADER), (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_VIDEOPOSITION(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_VIDEOPOSITION, NULL, sizeof(KSPROPERTY), 2 * sizeof(RECT), (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_DISPLAYCHANGE(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_DISPLAYCHANGE, NULL, sizeof(KSPROPERTY), sizeof(KSDISPLAYCHANGE), (Handler), NULL, 0, NULL, NULL, 0)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEFINE_KSPROPERTY_ITEM_OVERLAYUPDATE_COLORREF(Handler) DEFINE_KSPROPERTY_ITEM( KSPROPERTY_OVERLAYUPDATE_COLORREF, (Handler), sizeof(KSPROPERTY), sizeof(COLORREF), NULL, NULL, 0, NULL, NULL, 0)

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_VIDEOCONTROL 0x6a2e0670L, 0x28e4, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6a2e0670-28e4-11d0-a18c-00a0c9118956", PROPSETID_VIDCAP_VIDEOCONTROL);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_VIDEOCONTROL DEFINE_GUIDNAMED(PROPSETID_VIDCAP_VIDEOCONTROL)

public enum KSPROPERTY_VIDCAP_VIDEOCONTROL
{
    KSPROPERTY_VIDEOCONTROL_CAPS, // R
    KSPROPERTY_VIDEOCONTROL_ACTUAL_FRAME_RATE, // R O
    KSPROPERTY_VIDEOCONTROL_FRAME_RATES, // R O
    KSPROPERTY_VIDEOCONTROL_MODE // RWO
}

public enum KS_VideoControlFlags
{
    KS_VideoControlFlag_FlipHorizontal = 0x0001,
    KS_VideoControlFlag_FlipVertical = 0x0002,
    KS_Obsolete_VideoControlFlag_ExternalTriggerEnable = 0x0010, // ***WARNING *** Flag msimatch with DSHOW.
    KS_Obsolete_VideoControlFlag_Trigger = 0x0020, // ***WARNING *** Flag msimatch with DSHOW.
    KS_VideoControlFlag_ExternalTriggerEnable = 0x0004,
    KS_VideoControlFlag_Trigger = 0x0008
}

public class KSPROPERTY_VIDEOCONTROL_CAPS_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StreamIndex;
    public uint VideoControlCaps; // KS_VideoControlFlags_*
}

public class KSPROPERTY_VIDEOCONTROL_MODE_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StreamIndex;
    public int Mode; // KS_VideoControlFlags_*
}

public class KSPROPERTY_VIDEOCONTROL_ACTUAL_FRAME_RATE_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StreamIndex; // Index of stream
    public uint RangeIndex; // Index of range
    public SIZE Dimensions = new SIZE(); // Size of image
    public long CurrentActualFrameRate; // Only correct if pin is open
    public long CurrentMaxAvailableFrameRate; // Max Rate temporarily limited on USB or 1394?
}

// KSPROPERTY_VIDEOCONTROL_FRAME_RATES returns a list of available frame rates in 100 nS units
public class KSPROPERTY_VIDEOCONTROL_FRAME_RATES_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public uint StreamIndex; // Index of stream
    public uint RangeIndex; // Index of range
    public SIZE Dimensions = new SIZE(); // Size of image
}

// ===========================================================================
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_PROPSETID_VIDCAP_DROPPEDFRAMES 0xC6E13344L, 0x30AC, 0x11d0, 0xa1, 0x8c, 0x00, 0xa0, 0xc9, 0x11, 0x89, 0x56
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("C6E13344-30AC-11d0-A18C-00A0C9118956", PROPSETID_VIDCAP_DROPPEDFRAMES);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define PROPSETID_VIDCAP_DROPPEDFRAMES DEFINE_GUIDNAMED(PROPSETID_VIDCAP_DROPPEDFRAMES)

public enum KSPROPERTY_VIDCAP_DROPPEDFRAMES
{
    KSPROPERTY_DROPPEDFRAMES_CURRENT // R
}

public class KSPROPERTY_DROPPEDFRAMES_CURRENT_S
{
    public KSPROPERTY Property = new KSPROPERTY();
    public long PictureNumber; // Current Picture Number
    public long DropCount; // Count of frames dropped
    public uint AverageFrameSize; // Average size of frames captured
}

// ===========================================================================
// VPE

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_VPConfig 0xbc29a660L, 0x30e3, 0x11d0, 0x9e, 0x69, 0x00, 0xc0, 0x4f, 0xd7, 0xc1, 0x5b
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("bc29a660-30e3-11d0-9e69-00c04fd7c15b", KSPROPSETID_VPConfig);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_VPConfig DEFINE_GUIDNAMED(KSPROPSETID_VPConfig)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_VPVBIConfig 0xec529b00L, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("ec529b00-1a1f-11d1-bad9-00609744111a", KSPROPSETID_VPVBIConfig);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_VPVBIConfig DEFINE_GUIDNAMED(KSPROPSETID_VPVBIConfig)

// Both of the above property sets use the same list of properties below

public enum KSPROPERTY_VPCONFIG
{
    KSPROPERTY_VPCONFIG_NUMCONNECTINFO,
    KSPROPERTY_VPCONFIG_GETCONNECTINFO,
    KSPROPERTY_VPCONFIG_SETCONNECTINFO,
    KSPROPERTY_VPCONFIG_VPDATAINFO,
    KSPROPERTY_VPCONFIG_MAXPIXELRATE,
    KSPROPERTY_VPCONFIG_INFORMVPINPUT,
    KSPROPERTY_VPCONFIG_NUMVIDEOFORMAT,
    KSPROPERTY_VPCONFIG_GETVIDEOFORMAT,
    KSPROPERTY_VPCONFIG_SETVIDEOFORMAT,
    KSPROPERTY_VPCONFIG_INVERTPOLARITY,
    KSPROPERTY_VPCONFIG_DECIMATIONCAPABILITY, // E_NOTIMPL for VBI
    KSPROPERTY_VPCONFIG_SCALEFACTOR, // E_NOTIMPL for VBI
    KSPROPERTY_VPCONFIG_DDRAWHANDLE,
    KSPROPERTY_VPCONFIG_VIDEOPORTID,
    KSPROPERTY_VPCONFIG_DDRAWSURFACEHANDLE,
    KSPROPERTY_VPCONFIG_SURFACEPARAMS
}

// =========================
// IBasicAudio
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CLSID_KsIBasicAudioInterfaceHandler 0xb9f8ac3e, 0x0f71, 0x11d2, 0xb7, 0x2c, 0x00, 0xc0, 0x4f, 0xb6, 0xbd, 0x3d
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("b9f8ac3e-0f71-11d2-b72c-00c04fb6bd3d", CLSID_KsIBasicAudioInterfaceHandler);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CLSID_KsIBasicAudioInterfaceHandler DEFINE_GUIDNAMED(CLSID_KsIBasicAudioInterfaceHandler)


#if __IVPType__

public partial class KSVPMAXPIXELRATE
{
    public AMVPSIZE Size = new AMVPSIZE();
    public uint MaxPixelsPerSecond;
    public uint Reserved;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSVPMAXPIXELRATE *PKSVPMAXPIXELRATE;

public partial class KSVPSIZE_PROP
{
    public KSPROPERTY Property = new KSPROPERTY();
    public AMVPSIZE Size = new AMVPSIZE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSVPSIZE_PROP *PKSVPSIZE_PROP;

public partial class KSVPSURFACEPARAMS
{
    public uint dwPitch;
    public uint dwXOrigin;
    public uint dwYOrigin;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSVPSURFACEPARAMS *PKSVPSURFACEPARAMS;

#else // !defined(__IVPType__)

#if !__DDRAW_INCLUDED__

// ==========================================================================
// The following definitions must be in sync with DDraw.h in DirectX SDK
// ==========================================================================

/*
 * The FourCC code is valid.
 */
#define DDPF_FOURCC


public class _DDPIXELFORMAT
{
    public uint dwSize; // size of structure
    public uint dwFlags; // pixel format flags
    public uint dwFourCC; // (FOURCC code)
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//    uint dwRGBBitCount; // how many bits per pixel (BD_1,2,4,8,16,24,32)
//    uint dwYUVBitCount; // how many bits per pixel (BD_4,8,16,24,32)
//    uint dwZBufferBitDepth; // how many bits for z buffers (BD_8,16,24,32)
//    uint dwAlphaBitDepth; // how many bits for alpha channels (BD_1,2,4,8)
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//    uint dwRBitMask; // mask for red bit
//    uint dwYBitMask; // mask for Y bits
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//    uint dwGBitMask; // mask for green bits
//    uint dwUBitMask; // mask for U bits
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//    uint dwBBitMask; // mask for blue bits
//    uint dwVBitMask; // mask for V bits
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    {
//    uint dwRGBAlphaBitMask; // mask for alpha channel
//    uint dwYUVAlphaBitMask; // mask for alpha channel
//    uint dwRGBZBitMask; // mask for Z channel
//    uint dwYUVZBitMask; // mask for Z channel
//    };
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _DDPIXELFORMAT DDPIXELFORMAT;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _DDPIXELFORMAT * LPDDPIXELFORMAT;

#endif // !defined(__DDRAW_INCLUDED__)

// ==========================================================================
// End of DDraw.h header info
// ==========================================================================

// ==========================================================================
// The following definitions must be in sync with DVP.h in DirectX SDK
// ==========================================================================

#if !__DVP_INCLUDED__

public class _DDVIDEOPORTCONNECT
{
    public uint dwSize; // size of the DDVIDEOPORTCONNECT structure
    public uint dwPortWidth; // Width of the video port
    public GUID guidTypeID = new GUID(); // Description of video port connection
    public uint dwFlags; // Connection flags
    public uint dwReserved1; // Reserved, set to zero.
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _DDVIDEOPORTCONNECT DDVIDEOPORTCONNECT;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _DDVIDEOPORTCONNECT * LPDDVIDEOPORTCONNECT;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDVPTYPE_E_HREFH_VREFH 0x54F39980L,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8
#define DDVPTYPE_E_HREFH_VREFH

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DDVPTYPE_E_HREFL_VREFL 0xE09C77E0L,0xDA60,0x11CF,0x9B,0x06,0x00,0xA0,0xC9,0x03,0xA3,0xB8
#define DDVPTYPE_E_HREFL_VREFL

#endif // !defined(__DVP_INCLUDED__)

// ==========================================================================
// End of DVP.h header info
// ==========================================================================


// ==========================================================================
// The following definitions must be in sync with VPType.h in AM 2.0 SDK
// ==========================================================================

// pixel aspect ratios corresponding to a 720x480 NTSC image or a 720x576 image
public enum KS_AMPixAspectRatio // AMPixAspectRatio
{
    KS_PixAspectRatio_NTSC4x3,
    KS_PixAspectRatio_NTSC16x9,
    KS_PixAspectRatio_PAL4x3,
    KS_PixAspectRatio_PAL16x9
}

public enum KS_AMVP_SELECTFORMATBY // AMVP_SELECTFORMATBY
{
    KS_AMVP_DO_NOT_CARE,
    KS_AMVP_BEST_BANDWIDTH,
    KS_AMVP_INPUT_SAME_AS_OUTPUT
}

public enum KS_AMVP_MODE // AMVP_MODE
{
    KS_AMVP_MODE_WEAVE,
    KS_AMVP_MODE_BOBINTERLEAVED,
    KS_AMVP_MODE_BOBNONINTERLEAVED,
    KS_AMVP_MODE_SKIPEVEN,
    KS_AMVP_MODE_SKIPODD
}

public class tagKS_AMVPDIMINFO // AMVPDIMINFO
{
    public uint dwFieldWidth; // [out] field width
    public uint dwFieldHeight; // [out] field height
    public uint dwVBIWidth; // [out] VBI data width
    public uint dwVBIHeight; // [out] VBI data height
    public RECT rcValidRegion = new RECT(); // [out] valid rect for data cropping
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef tagKS_AMVPDIMINFO KS_AMVPDIMINFO;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef tagKS_AMVPDIMINFO *PKS_AMVPDIMINFO;

public class tagKS_AMVPDATAINFO // AMVPDATAINFO
{
    public uint dwSize; // Size of the struct
    public uint dwMicrosecondsPerField; // Time taken by each field
    public tagKS_AMVPDIMINFO amvpDimInfo = new tagKS_AMVPDIMINFO(); // Dimensional Information
    public uint dwPictAspectRatioX; // Pict aspect ratio in X dimn
    public uint dwPictAspectRatioY; // Pict aspect ratio in Y dimn
    public bool bEnableDoubleClock; // Videoport should enable double clocking
    public bool bEnableVACT; // Videoport should use an external VACT signal
    public bool bDataIsInterlaced; // Indicates that the signal is interlaced
    public int lHalfLinesOdd; // number of halflines in the odd field
    public bool bFieldPolarityInverted; // Device inverts the polarity by default
    public uint dwNumLinesInVREF; // Number of lines of data in VREF
    public int lHalfLinesEven; // number of halflines in the even field
    public uint dwReserved1; // Reserved for future use
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef tagKS_AMVPDATAINFO KS_AMVPDATAINFO;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef tagKS_AMVPDATAINFO *PKS_AMVPDATAINFO;

public class tagKS_AMVPSIZE // AMVPSIZE
{
    public uint dwWidth; // [in] width in pixels
    public uint dwHeight; // [in] height in pixels
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef tagKS_AMVPSIZE KS_AMVPSIZE;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef tagKS_AMVPSIZE *PKS_AMVPSIZE;

// ==========================================================================
// End of VPType.h header info
// ==========================================================================

public partial class KSVPMAXPIXELRATE
{
    public tagKS_AMVPSIZE Size = new tagKS_AMVPSIZE();
    public uint MaxPixelsPerSecond;
    public uint Reserved;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSVPMAXPIXELRATE *PKSVPMAXPIXELRATE;

public partial class KSVPSIZE_PROP
{
    public KSPROPERTY Property = new KSPROPERTY();
    public tagKS_AMVPSIZE Size = new tagKS_AMVPSIZE();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSVPSIZE_PROP *PKSVPSIZE_PROP;

public partial class KSVPSURFACEPARAMS
{
    public uint dwPitch;
    public uint dwXOrigin;
    public uint dwYOrigin;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef KSVPSURFACEPARAMS *PKSVPSURFACEPARAMS;

#endif // !defined(__IVPType__)

// 
//  IVPNotify event notification
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_VPNotify 0x20c5598eL, 0xd3c8, 0x11d0, 0x8d, 0xfc, 0x00, 0xc0, 0x4f, 0xd7, 0xc0, 0x8b
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("20c5598e-d3c8-11d0-8dfc-00c04fd7c08b", KSEVENTSETID_VPNotify);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_VPNotify DEFINE_GUIDNAMED(KSEVENTSETID_VPNotify)

public enum KSEVENT_VPNOTIFY
{
    KSEVENT_VPNOTIFY_FORMATCHANGE
}

// 
//  VIDCAPTOSTI event notification
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_VIDCAPTOSTI 0xdb47de20, 0xf628, 0x11d1, 0xba, 0x41, 0x0, 0xa0, 0xc9, 0xd, 0x2b, 0x5
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("DB47DE20-F628-11d1-BA41-00A0C90D2B05", KSEVENTSETID_VIDCAPTOSTI);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_VIDCAPNotify DEFINE_GUIDNAMED(KSEVENTSETID_VIDCAPTOSTI)

public enum KSEVENT_VIDCAPTOSTI
{
    KSEVENT_VIDCAPTOSTI_EXT_TRIGGER,
    KSEVENT_VIDCAP_AUTO_UPDATE,
    KSEVENT_VIDCAP_SEARCH
}

// 
// Extension Unit Properties
// 
public enum KSPROPERTY_EXTENSION_UNIT
{
    KSPROPERTY_EXTENSION_UNIT_INFO, // (R)
    KSPROPERTY_EXTENSION_UNIT_CONTROL, // (RW)
    KSPROPERTY_EXTENSION_UNIT_PASS_THROUGH = 0xffff // (RW)
}

// 
//  IVPVBINotify event notification
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSEVENTSETID_VPVBINotify 0xec529b01L, 0x1a1f, 0x11d1, 0xba, 0xd9, 0x0, 0x60, 0x97, 0x44, 0x11, 0x1a
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("ec529b01-1a1f-11d1-bad9-00609744111a", KSEVENTSETID_VPVBINotify);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSEVENTSETID_VPVBINotify DEFINE_GUIDNAMED(KSEVENTSETID_VPVBINotify)

public enum KSEVENT_VPVBINOTIFY
{
    KSEVENT_VPVBINOTIFY_FORMATCHANGE
}


// 
// closed caption information
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_AUXLine21Data 0x670aea80L, 0x3a82, 0x11d0, 0xb7, 0x9b, 0x00, 0xaa, 0x00, 0x37, 0x67, 0xa7
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("670aea80-3a82-11d0-b79b-00aa003767a7", KSDATAFORMAT_TYPE_AUXLine21Data);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_AUXLine21Data DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_AUXLine21Data)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_Line21_BytePair 0x6e8d4a22L, 0x310c, 0x11d0, 0xb7, 0x9a, 0x00, 0xaa, 0x00, 0x37, 0x67, 0xa7
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6e8d4a22-310c-11d0-b79a-00aa003767a7", KSDATAFORMAT_SUBTYPE_Line21_BytePair);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_Line21_BytePair DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_Line21_BytePair)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_SUBTYPE_Line21_GOPPacket 0x6e8d4a23L, 0x310c, 0x11d0, 0xb7, 0x9a, 0x00, 0xaa, 0x00, 0x37, 0x67, 0xa7
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6e8d4a23-310c-11d0-b79a-00aa003767a7", KSDATAFORMAT_SUBTYPE_Line21_GOPPacket);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_SUBTYPE_Line21_GOPPacket DEFINE_GUIDNAMED(KSDATAFORMAT_SUBTYPE_Line21_GOPPacket)

public class _KSGOP_USERDATA
{
    public uint sc;
    public uint reserved1;
    public byte cFields;
    public string l21Data = new string(new char[3]);
}

// 
// DVD encrypted PACK format type definition
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSDATAFORMAT_TYPE_DVD_ENCRYPTED_PACK 0xed0b916a, 0x044d, 0x11d1, 0xaa, 0x78, 0x00, 0xc0, 0x4f, 0xc3, 0x1d, 0x60
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("ed0b916a-044d-11d1-aa78-00c04fc31d60", KSDATAFORMAT_TYPE_DVD_ENCRYPTED_PACK);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSDATAFORMAT_TYPE_DVD_ENCRYPTED_PACK DEFINE_GUIDNAMED(KSDATAFORMAT_TYPE_DVD_ENCRYPTED_PACK)



// -----------------------------------------------------------------------
// KS_AM_KSPROPSETID_TSRateChange property set definitions for time stamp
// rate changes.
// -----------------------------------------------------------------------


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSPROPSETID_TSRateChange 0xa503c5c0, 0x1d1d, 0x11d1, 0xad, 0x80, 0x44, 0x45, 0x53, 0x54, 0x0, 0x0

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("A503C5C0-1D1D-11D1-AD80-444553540000", KSPROPSETID_TSRateChange);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSPROPSETID_TSRateChange DEFINE_GUIDNAMED(KSPROPSETID_TSRateChange)
public enum KS_AM_PROPERTY_TS_RATE_CHANGE
{
    KS_AM_RATE_SimpleRateChange = 1, // rw, use KS_AM_SimpleRateChange
    KS_AM_RATE_ExactRateChange = 2, // rw, use KS_AM_ExactRateChange
    KS_AM_RATE_MaxFullDataRate = 3, // r, use KS_AM_MaxFullDataRate
    KS_AM_RATE_Step = 4 // w, use KS_AM_Step
}

public class KS_AM_SimpleRateChange
{
    // this is the simplest mechanism to set a time stamp rate change on
    // a filter (simplest for the person setting the rate change, harder
    // for the filter doing the rate change).
    public long StartTime; // stream time at which to start this rate
    public int Rate; // new rate * 10000 (decimal)
}

public class KS_AM_ExactRateChange
{
    public long OutputZeroTime; // input TS that maps to zero output TS
    public int Rate; // new rate * 10000 (decimal)
}



// ===========================================================================
// ENCODER API DEFINITIONS
// ===========================================================================

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_ENCODER 0x19689bf6, 0xc384, 0x48fd, 0xad, 0x51, 0x90, 0xe5, 0x8c, 0x79, 0xf7, 0xb
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("19689BF6-C384-48fd-AD51-90E58C79F70B", KSCATEGORY_ENCODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_ENCODER DEFINE_GUIDNAMED(KSCATEGORY_ENCODER)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_KSCATEGORY_MULTIPLEXER 0x7a5de1d3, 0x1a1, 0x452c, 0xb4, 0x81, 0x4f, 0xa2, 0xb9, 0x62, 0x71, 0xe8
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7A5DE1D3-01A1-452c-B481-4FA2B96271E8", KSCATEGORY_MULTIPLEXER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define KSCATEGORY_MULTIPLEXER DEFINE_GUIDNAMED(KSCATEGORY_MULTIPLEXER)


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_ENCAPIPARAM_BITRATE 0x49cc4c43, 0xca83, 0x4ad4, 0xa9, 0xaf, 0xf3, 0x69, 0x6a, 0xf6, 0x66, 0xdf
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("49CC4C43-CA83-4ad4-A9AF-F3696AF666DF", ENCAPIPARAM_BITRATE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ENCAPIPARAM_BITRATE DEFINE_GUIDNAMED(ENCAPIPARAM_BITRATE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_ENCAPIPARAM_PEAK_BITRATE 0x703f16a9, 0x3d48, 0x44a1, 0xb0, 0x77, 0x1, 0x8d, 0xff, 0x91, 0x5d, 0x19
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("703F16A9-3D48-44a1-B077-018DFF915D19", ENCAPIPARAM_PEAK_BITRATE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ENCAPIPARAM_PEAK_BITRATE DEFINE_GUIDNAMED(ENCAPIPARAM_PEAK_BITRATE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_ENCAPIPARAM_BITRATE_MODE 0xee5fb25c, 0xc713, 0x40d1, 0x9d, 0x58, 0xc0, 0xd7, 0x24, 0x1e, 0x25, 0xf
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("EE5FB25C-C713-40d1-9D58-C0D7241E250F", ENCAPIPARAM_BITRATE_MODE);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ENCAPIPARAM_BITRATE_MODE DEFINE_GUIDNAMED(ENCAPIPARAM_BITRATE_MODE)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_CHANGELISTS 0x62b12acf, 0xf6b0, 0x47d9, 0x94, 0x56, 0x96, 0xf2, 0x2c, 0x4e, 0x0b, 0x9d
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("62B12ACF-F6B0-47D9-9456-96F22C4E0B9D", CODECAPI_CHANGELISTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_CHANGELISTS DEFINE_GUIDNAMED(CODECAPI_CHANGELISTS )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_VIDEO_ENCODER 0x7112e8e1, 0x3d03, 0x47ef, 0x8e, 0x60, 0x03, 0xf1, 0xcf, 0x53, 0x73, 0x01
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("7112E8E1-3D03-47EF-8E60-03F1CF537301", CODECAPI_VIDEO_ENCODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_VIDEO_ENCODER DEFINE_GUIDNAMED(CODECAPI_VIDEO_ENCODER )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_AUDIO_ENCODER 0xb9d19a3e, 0xf897, 0x429c, 0xbc, 0x46, 0x81, 0x38, 0xb7, 0x27, 0x2b, 0x2d
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("B9D19A3E-F897-429C-BC46-8138B7272B2D", CODECAPI_AUDIO_ENCODER);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_AUDIO_ENCODER DEFINE_GUIDNAMED(CODECAPI_AUDIO_ENCODER )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_SETALLDEFAULTS 0x6c5e6a7c, 0xacf8, 0x4f55, 0xa9, 0x99, 0x1a, 0x62, 0x81, 0x09, 0x05, 0x1b
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6C5E6A7C-ACF8-4F55-A999-1A628109051B", CODECAPI_SETALLDEFAULTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_SETALLDEFAULTS DEFINE_GUIDNAMED(CODECAPI_SETALLDEFAULTS )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_ALLSETTINGS 0x6a577e92, 0x83e1, 0x4113, 0xad, 0xc2, 0x4f, 0xce, 0xc3, 0x2f, 0x83, 0xa1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("6A577E92-83E1-4113-ADC2-4FCEC32F83A1", CODECAPI_ALLSETTINGS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_ALLSETTINGS DEFINE_GUIDNAMED(CODECAPI_ALLSETTINGS )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_SUPPORTSEVENTS 0x0581af97, 0x7693, 0x4dbd, 0x9d, 0xca, 0x3f, 0x9e, 0xbd, 0x65, 0x85, 0xa1
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("0581AF97-7693-4DBD-9DCA-3F9EBD6585A1", CODECAPI_SUPPORTSEVENTS);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_SUPPORTSEVENTS DEFINE_GUIDNAMED(CODECAPI_SUPPORTSEVENTS )

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define STATIC_CODECAPI_CURRENTCHANGELIST 0x1cb14e83, 0x7d72, 0x4657, 0x83, 0xfd, 0x47, 0xa2, 0xc5, 0xb9, 0xd1, 0x3d
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUIDSTRUCT("1CB14E83-7D72-4657-83FD-47A2C5B9D13D", CODECAPI_CURRENTCHANGELIST);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define CODECAPI_CURRENTCHANGELIST DEFINE_GUIDNAMED(CODECAPI_CURRENTCHANGELIST )



public enum VIDEOENCODER_BITRATE_MODE
{

    // 
    // Bit rate used for encoding is constant
    // 
    ConstantBitRate = 0,

    // 
    // Bit rate used for encoding is variable with the specified bitrate used
    // as a guaranteed average over a specified window.  The default window 
    // size is considered to be 5 minutes.
    // 
    VariableBitRateAverage,

    // 
    // Bit rate used for encoding is variable with the specified bitrate used
    // as an average with a peak not to exceed the specified peak bitrate over 
    // a specified window.  The default window size is considered to be 500ms 
    // (classically one GOP).
    // 
    VariableBitRatePeak

}


