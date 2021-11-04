// ===========================================================================
// 
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
// 
// Copyright (c) Microsoft Corporation. All rights reserved.
// 
// ===========================================================================
// 
// filename XPrtDefs.h (Derived from edevdefs.h)
// 
// External Device (like a VCR) control interface parameter and value definitions
// 
// Note:new constants added: ED_BASE+800L -> ED_BASE+811L
// 
// 1-30-98:
//   New constant added for DVCR: ED_BASE+900L -> ED_BASE+1000L
// 7-15-03:
//   Add new constants for device transports and device types: 
//       ED_BASE+1001L..ED_BASE+1037L
// 




// this is used to tell the device communications object which
// physical communications port to use.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEV_PORT_MIN DEV_PORT_SIM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DEV_PORT_MAX DEV_PORT_USB


// IAMExtDevice Capability Items:  unless otherwise specified, these items return 
//    OATRUE or OAFALSE.  All return values are in pdwValue unless otherwise specified:

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CAN_RECORD ED_BASE+1L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CAN_RECORD_STROBE ED_BASE+2L
                                                     // switches currently recording tracks off 
                                                     // and selected non-recording tracks into record
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_HAS_AUDIO ED_BASE+3L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_HAS_VIDEO ED_BASE+4L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_USES_FILES ED_BASE+5L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CAN_SAVE ED_BASE+6L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_DEVICE_TYPE ED_BASE+7L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_VCR ED_BASE+8L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_LASERDISK ED_BASE+9L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_ATR ED_BASE+10L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_DDR ED_BASE+11L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_ROUTER ED_BASE+12L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_KEYER ED_BASE+13L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_MIXER_VIDEO ED_BASE+14L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_DVE ED_BASE+15L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_WIPEGEN ED_BASE+16L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_MIXER_AUDIO ED_BASE+17L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_CG ED_BASE+18L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_TBC ED_BASE+19L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_TCG ED_BASE+20L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_GPI ED_BASE+21L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_JOYSTICK ED_BASE+22L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_KEYBOARD ED_BASE+23L

// returns mfr-specific ID from external device.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_EXTERNAL_DEVICE_ID ED_BASE+24L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_TIMECODE_READ ED_BASE+25L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_TIMECODE_WRITE ED_BASE+26L
//    used for seekable non-timecode enabled devices
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CTLTRK_READ ED_BASE+27L
//    used for seekable non-timecode enabled devices
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_INDEX_READ ED_BASE+28L

// returns device preroll time in current time format
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_PREROLL ED_BASE+29L
// returns device postroll time in current time format
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_POSTROLL ED_BASE+30L

// returns indication of device�s synchronization accuracy.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_SYNC_ACCURACY ED_BASE+31L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SYNCACC_PRECISE ED_BASE+32L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SYNCACC_FRAME ED_BASE+33L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SYNCACC_ROUGH ED_BASE+34L

// returns device�s normal framerate.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_NORMAL_RATE ED_BASE+35L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RATE_24 ED_BASE+36L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RATE_25 ED_BASE+37L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RATE_2997 ED_BASE+38L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RATE_30 ED_BASE+39L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CAN_PREVIEW ED_BASE+40L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CAN_MONITOR_SOURCES ED_BASE+41L

// indicates implementation allows testing of methods/parameters by
// setting the hi bit of a parm that makes sense - see individual methods
// for details.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_CAN_TEST ED_BASE+42L

// indicates device accepts video as an input.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_VIDEO_INPUTS ED_BASE+43L

// indicates device accepts audio as an input.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_AUDIO_INPUTS ED_BASE+44L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_NEEDS_CALIBRATING ED_BASE+45L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_SEEK_TYPE ED_BASE+46L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SEEK_PERFECT ED_BASE+47L
                                                      // within 1 video frames without signal 
                                                      //    break (like a DDR)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SEEK_FAST ED_BASE+48L
                                                //  with short break in signal
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SEEK_SLOW ED_BASE+49L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_POWER_ON ED_BASE+50L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_POWER_OFF ED_BASE+51L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_POWER_STANDBY ED_BASE+52L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_POWER_DEVICE_DEPENDENT ED_BASE+1033L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_ACTIVE ED_BASE+53L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_INACTIVE ED_BASE+54L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_ALL ED_BASE+55L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TEST ED_BASE+56L

//    IAMExtTransport Capability Items:  unless otherwise specified, these items return 
//       OATRUE or OAFALSE.  All return values are in pdwValue unless otherwise specified:

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_EJECT ED_BASE+100L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_BUMP_PLAY ED_BASE+101L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_PLAY_BACKWARDS ED_BASE+102L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_SET_EE ED_BASE+103L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_SET_PB ED_BASE+104L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_DELAY_VIDEO_IN ED_BASE+105L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_DELAY_VIDEO_OUT ED_BASE+106L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_DELAY_AUDIO_IN ED_BASE+107L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_DELAY_AUDIO_OUT ED_BASE+108L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_FWD_VARIABLE_MAX ED_BASE+109L
                                                       //  in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_FWD_VARIABLE_MIN ED_BASE+800L
                                                       //  in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_REV_VARIABLE_MAX ED_BASE+110L
                                                       //  pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_REV_VARIABLE_MIN ED_BASE+801L
                                                       //  in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_FWD_SHUTTLE_MAX ED_BASE+802L
                                                       //  of play speed) in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_FWD_SHUTTLE_MIN ED_BASE+803L
                                                       //  of play speed) in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_REV_SHUTTLE_MAX ED_BASE+804L
                                                       //  of play speed) in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_REV_SHUTTLE_MIN ED_BASE+805L
                                                       //  of play speed) in pdblValue
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_NUM_AUDIO_TRACKS ED_BASE+111L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_LTC_TRACK ED_BASE+112L
                                                       //  ED_ALL means no dedicated timecode track
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_NEEDS_TBC ED_BASE+113L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_NEEDS_CUEING ED_BASE+114L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_INSERT ED_BASE+115L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_ASSEMBLE ED_BASE+116L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_FIELD_STEP ED_BASE+117L
                                                       //  advancing one field
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CLOCK_INC_RATE ED_BASE+118L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_DETECT_LENGTH ED_BASE+119L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_CAN_FREEZE ED_BASE+120L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_HAS_TUNER ED_BASE+121L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_HAS_TIMER ED_BASE+122L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_HAS_CLOCK ED_BASE+123L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_MULTIPLE_EDITS ED_BASE+806L
                                                       //  multiple edit events
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_IS_MASTER ED_BASE+807L
                                                       //  for synchronizing (this sets timecode-to-
                                                       //  reference clock offset for editing)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSCAP_HAS_DT ED_BASE+814L

//    IAMExtTransport Media States
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_SPIN_UP ED_BASE+130L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_SPIN_DOWN ED_BASE+131L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_UNLOAD ED_BASE+132L

//    IAMExtTransport Modes
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY ED_BASE+200L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STOP ED_BASE+201L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_FREEZE ED_BASE+202L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_THAW ED_BASE+203L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_FF ED_BASE+204L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_REW ED_BASE+205L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_RECORD ED_BASE+206L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_RECORD_STROBE ED_BASE+207L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_RECORD_FREEZE ED_BASE+808L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STEP ED_BASE+208L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STEP_FWD ED_BASE+208L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STEP_REV ED_BASE+809L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_SHUTTLE ED_BASE+209L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_EDIT_CUE ED_BASE+210L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_VAR_SPEED ED_BASE+211L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PERFORM ED_BASE+212L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_LINK_ON ED_BASE+280L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_LINK_OFF ED_BASE+281L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_NOTIFY_ENABLE ED_BASE+810L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_NOTIFY_DISABLE ED_BASE+811L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_SHOT_SEARCH ED_BASE+812L


//    IAMTimecodeReader/Generator/Display defines
// 
// Timecode Generator Mode params and values:
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_TIMECODE_TYPE ED_BASE+400L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_SMPTE_LTC ED_BASE+401L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_SMPTE_VITC ED_BASE+402L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_MIDI_QF ED_BASE+403L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_MIDI_FULL ED_BASE+404L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_FRAMERATE ED_BASE+405L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_SMPTE_30 ED_BASE+406L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_SMPTE_30DROP ED_BASE+407L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_SMPTE_25 ED_BASE+408L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_SMPTE_24 ED_BASE+409L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_SYNC_SOURCE ED_BASE+410L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_VIDEO ED_BASE+411L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_READER ED_BASE+412L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_FREE ED_BASE+413L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG_REFERENCE_SOURCE ED_BASE+414L
                                                       //    ED_TCG_FREE || ED_TCG_READER 
                                                       //    (for regen/jamsync)

// TimeCodeReader Mode params and values:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR_SOURCE ED_BASE+416L
// ED_TCG (already defined)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR_LTC ED_BASE+417L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR_VITC ED_BASE+418L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR_CT ED_BASE+419L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR_FTC ED_BASE+420L
                                                //  that wish they were transports
// ED_MODE_NOTIFY_ENABLE can be OATRUE or OAFALSE (defined in transport mode
//  section of this file).  
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR_LAST_VALUE ED_BASE+421L
                                                //  successive calls to GetTimecode
                                                //  return the last read value
// TimeCode Display Mode params and values:
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCD_SOURCE ED_BASE+422L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCR ED_BASE+423L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCG ED_BASE+424L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCD_SIZE ED_BASE+425L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SMALL ED_BASE+426L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MED ED_BASE+427L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_LARGE ED_BASE+428L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCD_POSITION ED_BASE+429L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCD_INTENSITY ED_BASE+436L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_HIGH ED_BASE+437L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_LOW ED_BASE+438L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCD_TRANSPARENCY ED_BASE+439L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TCD_INVERT ED_BASE+440L
                                                       // OAFALSE=white on black
//    IAMExtTransport defines
// 
// Transport status, params and values
// 

// IAMExtTransport Status items and and values:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE ED_BASE+500L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_ERROR ED_BASE+501L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_LOCAL ED_BASE+502L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RECORD_INHIBIT ED_BASE+503L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_SERVO_LOCK ED_BASE+504L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_PRESENT ED_BASE+505L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_LENGTH ED_BASE+506L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_SIZE ED_BASE+507L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_TRACK_COUNT ED_BASE+508L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_TRACK_LENGTH ED_BASE+509L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_SIDE ED_BASE+510L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_TYPE ED_BASE+511L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_VHS ED_BASE+512L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_SVHS ED_BASE+513L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_HI8 ED_BASE+514L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_UMATIC ED_BASE+515L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_DVC ED_BASE+516L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_1_INCH ED_BASE+517L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_D1 ED_BASE+518L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_D2 ED_BASE+519L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_D3 ED_BASE+520L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_D5 ED_BASE+521L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_DBETA ED_BASE+522L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_BETA ED_BASE+523L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_8MM ED_BASE+524L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_DDR ED_BASE+525L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_SX ED_BASE+813L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_OTHER ED_BASE+526L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_CLV ED_BASE+527L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_CAV ED_BASE+528L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_POSITION ED_BASE+529L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_NEO ED_BASE+531L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_MICROMV ED_MEDIA_NEO

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_LINK_MODE ED_BASE+530L
                                                       // are linked to graph's RUN, 
                                                       // STOP, and PAUSE methods

// IAMExtTransport Basic Parms
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_TIME_FORMAT ED_BASE+540L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_MILLISECONDS ED_BASE+541L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_FRAMES ED_BASE+542L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_REFERENCE_TIME ED_BASE+543L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_HMSF ED_BASE+547L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_FORMAT_TMSF ED_BASE+548L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_TIME_REFERENCE ED_BASE+549L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TIMEREF_TIMECODE ED_BASE+550L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TIMEREF_CONTROL_TRACK ED_BASE+551L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TIMEREF_INDEX ED_BASE+552L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SUPERIMPOSE ED_BASE+553L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_END_STOP_ACTION ED_BASE+554L
                                                        //    ED_MODE_REWIND | ED_MODE_FREEZE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_RECORD_FORMAT ED_BASE+555L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RECORD_FORMAT_SP ED_BASE+556L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RECORD_FORMAT_LP ED_BASE+557L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RECORD_FORMAT_EP ED_BASE+558L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_STEP_COUNT ED_BASE+559L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_STEP_UNIT ED_BASE+560L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_STEP_FIELD ED_BASE+561L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_STEP_FRAME ED_BASE+562L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_STEP_3_2 ED_BASE+563L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_PREROLL ED_BASE+564L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_RECPREROLL ED_BASE+565L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_POSTROLL ED_BASE+566L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_EDIT_DELAY ED_BASE+567L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_PLAYTC_DELAY ED_BASE+568L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_RECTC_DELAY ED_BASE+569L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_EDIT_FIELD ED_BASE+570L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_FRAME_SERVO ED_BASE+571L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_CF_SERVO ED_BASE+572L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SERVO_REF ED_BASE+573L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_REF_EXTERNAL ED_BASE+574L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_REF_INPUT ED_BASE+575L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_REF_INTERNAL ED_BASE+576L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_REF_AUTO ED_BASE+577L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_WARN_GL ED_BASE+578L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SET_TRACKING ED_BASE+579L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRACKING_PLUS ED_BASE+580L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRACKING_MINUS ED_BASE+581L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRACKING_RESET ED_BASE+582L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SET_FREEZE_TIMEOUT ED_BASE+583L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_VOLUME_NAME ED_BASE+584L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_1 ED_BASE+585L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_2 ED_BASE+586L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_3 ED_BASE+587L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_4 ED_BASE+588L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_5 ED_BASE+589L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_6 ED_BASE+590L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_7 ED_BASE+591L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_8 ED_BASE+592L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_9 ED_BASE+593L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_10 ED_BASE+594L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_11 ED_BASE+595L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_12 ED_BASE+596L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_13 ED_BASE+597L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_14 ED_BASE+598L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_15 ED_BASE+599L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_16 ED_BASE+600L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_17 ED_BASE+601L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_18 ED_BASE+602L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_19 ED_BASE+603L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_BALLISTIC_20 ED_BASE+604L

// consumer VCR items
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETCLOCK ED_BASE+605L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SET_COUNTER_FORMAT ED_BASE+606L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SET_COUNTER_VALUE ED_BASE+607L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTUNER_CH_UP ED_BASE+608L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTUNER_CH_DN ED_BASE+609L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTUNER_SK_UP ED_BASE+610L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTUNER_SK_DN ED_BASE+611L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTUNER_CH ED_BASE+612L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTUNER_NUM ED_BASE+613L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTIMER_EVENT ED_BASE+614L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTIMER_STARTDAY ED_BASE+615L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTIMER_STARTTIME ED_BASE+616L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTIMER_STOPDAY ED_BASE+617L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SETTIMER_STOPTIME ED_BASE+618L

// IAMExtTransport video parameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSVIDEO_SET_OUTPUT ED_BASE+630L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_E2E ED_BASE+631L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_PLAYBACK ED_BASE+632L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_OFF ED_BASE+633L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSVIDEO_SET_SOURCE ED_BASE+634L

// IAMExtTransport audio parameters
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSAUDIO_ENABLE_OUTPUT ED_BASE+640L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSAUDIO_ENABLE_RECORD ED_BASE+642L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSAUDIO_ENABLE_SELSYNC ED_BASE+643L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSAUDIO_SET_SOURCE ED_BASE+644L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSAUDIO_SET_MONITOR ED_BASE+645L


// Edit Property Set-related defs

// The following values reflect (and control) the state of an 
// edit property set
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_INVALID ED_BASE+652L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EXECUTING ED_BASE+653L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_REGISTER ED_BASE+654L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DELETE ED_BASE+655L

// Edit property set parameters and values
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_HEVENT ED_BASE+656L
                                                       // completion
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_TEST ED_BASE+657L
                                                       //  edit can be done, OATRUE if not
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_IMMEDIATE ED_BASE+658L
                                                       // device into edit mode (editing
                                                       // "on the fly") immediately upon
                                                       //  execution of Mode(ED_MODE_EDIT_CUE)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MODE ED_BASE+659L
// can be one of the following values:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MODE_ASSEMBLE ED_BASE+660L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MODE_INSERT ED_BASE+661L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MODE_CRASH_RECORD ED_BASE+662L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MODE_BOOKMARK_TIME ED_BASE+663L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MODE_BOOKMARK_CHAPTER ED_BASE+664L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_MASTER ED_BASE+666L
                                                       //  not to synchronize

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_TRACK ED_BASE+667L
// can be one of the following possible OR'd values:
//    ED_VIDEO, ED_AUDIO_1 thru ED_AUDIO_24 (or ED_AUDIO_ALL)

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SRC_INPOINT ED_BASE+668L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SRC_OUTPOINT ED_BASE+669L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_REC_INPOINT ED_BASE+670L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_REC_OUTPOINT ED_BASE+671L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_REHEARSE_MODE ED_BASE+672L
// can be one of the following possible values:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_BVB ED_BASE+673L
                                                       //  "black-video-black"
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_VBV ED_BASE+674L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_VVV ED_BASE+675L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_PERFORM ED_BASE+676L
                                                       //  rehearsal.

// Set this property to OATRUE to kill the edit if in progress
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_ABORT ED_BASE+677L
// how long to wait for edit to complete
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_TIMEOUT ED_BASE+678L

// This property causes the device to seek to a point specified by
// ED_EDIT_SEEK_MODE (see below).  NOTE: Only one event at a time can seek.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK ED_BASE+679L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK_MODE ED_BASE+680L
// possible values:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK_EDIT_IN ED_BASE+681L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK_EDIT_OUT ED_BASE+682L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK_PREROLL ED_BASE+683L
                                                       //  inpoint-preroll
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK_PREROLL_CT ED_BASE+684L
                                                       // using control track (used for tapes with 
                                                       // discontinuoustimecode before edit point: seek
                                                       // to inpoint using timecode, then backup to 
                                                       // preroll point using control track)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_SEEK_BOOKMARK ED_BASE+685L
                                                       //  timecode search)
// This property is used for multiple-VCR systems where each machine must
// cue to a different location relative to the graph's reference clock.  The
// basic idea is that an edit event is setup with an ED_EDIT_OFFSET property
// that tells the VCR what offset to maintain between it's timecode (converted
// to reference clock units) and the reference clock.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_OFFSET ED_BASE+686L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_EDIT_PREREAD ED_BASE+815L
                                                       //  pre-read (recorder can also be
                                                       //  player

// 
// Some error codes:
// 
// device could be in local mode
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_ERR_DEVICE_NOT_READY ED_BASE+700L






// **************************************************
// 
// New constants 
// 
// **************************************************


// 
// Additional Device type
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_CAMERA ED_BASE+900L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_TUNER ED_BASE+901L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_DVHS ED_BASE+902L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_UNKNOWN ED_BASE+903L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_CAMERA_STORAGE ED_BASE+1034L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_DTV ED_BASE+1035L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVTYPE_PC_VIRTUAL ED_BASE+1036L



// 
// Unknownn capability 
//     Instead of return E_NOTIMPL, or S_OK with OAFALSE, it may return S_OK with _UNKNOWN
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_CAPABILITY_UNKNOWN ED_BASE+910L


// 
// Send raw 1394/AVC extenal device command via GetTransportBasicParameters()
// This is specifically for a 1394 AVC device connected with DEV_PORT_1394.
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_RAW_EXT_DEV_CMD ED_BASE+920L


// 
// MEDIUM INFO
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_VHSC ED_BASE+925L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_UNKNOWN ED_BASE+926L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MEDIA_NOT_PRESENT ED_BASE+927L


// 
// Device Control command that can result in pending state.
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_CONTROL_HEVENT_GET ED_BASE+928L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_CONTROL_HEVENT_RELEASE ED_BASE+929L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEV_REMOVED_HEVENT_GET ED_BASE+960L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEV_REMOVED_HEVENT_RELEASE ED_BASE+961L


// 
// TRANSPORT STATE
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_NOTIFY_HEVENT_GET ED_BASE+930L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_NOTIFY_HEVENT_RELEASE ED_BASE+931L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_CHANGE_NOTIFY ED_BASE+932L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FASTEST_FWD ED_BASE+933L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOWEST_FWD ED_BASE+934L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FASTEST_REV ED_BASE+935L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOWEST_REV ED_BASE+936L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_WIND ED_BASE+937L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_REW_FASTEST ED_BASE+938L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_REV_PLAY ED_BASE+939L

// 
// Additional play modes (added post Windows XP)
// 

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_6 ED_BASE+1001L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_5 ED_BASE+1002L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_4 ED_BASE+1003L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_3 ED_BASE+1004L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_2 ED_BASE+1005L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_1 ED_BASE+1006L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_1 ED_BASE+1007L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_2 ED_BASE+1008L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_3 ED_BASE+1009L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_4 ED_BASE+1010L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_5 ED_BASE+1011L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_6 ED_BASE+1012L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_6 ED_BASE+1013L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_5 ED_BASE+1014L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_4 ED_BASE+1015L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_3 ED_BASE+1016L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_2 ED_BASE+1017L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_1 ED_BASE+1018L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_1 ED_BASE+1019L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_2 ED_BASE+1020L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_3 ED_BASE+1021L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_4 ED_BASE+1022L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_5 ED_BASE+1023L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_6 ED_BASE+1024L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_REVERSE ED_MODE_REV_PLAY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_REVERSE_FREEZE ED_BASE+1025L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_FWD_X ED_BASE+1026L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_FWD_X ED_BASE+1027L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_SLOW_REV_X ED_BASE+1028L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_PLAY_FAST_REV_X ED_BASE+1029L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STOP_START ED_BASE+1030L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STOP_END ED_BASE+1031L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_MODE_STOP_EMERGENCY ED_BASE+1032L

// 
// TRANSPOSRTBASIC: input and output signal
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_INPUT_SIGNAL ED_BASE+940L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_OUTPUT_SIGNAL ED_BASE+941L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_525_60_SD ED_BASE+942L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_525_60_SDL ED_BASE+943L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_625_50_SD ED_BASE+944L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_625_50_SDL ED_BASE+945L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_625_60_HD ED_BASE+947L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_625_50_HD ED_BASE+948L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_MPEG2TS ED_BASE+946L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_2500_60_MPEG ED_BASE+980L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_1250_60_MPEG ED_BASE+981L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_0625_60_MPEG ED_BASE+982L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_2500_50_MPEG ED_BASE+985L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_1250_50_MPEG ED_BASE+986L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_0625_50_MPEG ED_BASE+987L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_UNKNOWN ED_BASE+990L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_525_60_DV25 ED_BASE+991L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_625_50_DV25 ED_BASE+992L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_525_60_DV50 ED_BASE+993L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_625_50_DV50 ED_BASE+994L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_HD_60_DVH1 ED_BASE+995L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TRANSBASIC_SIGNAL_HD_50_DVH1 ED_BASE+996L



// 
// TIMECODE/AbsoluteTrackNumber/RealTimeCounter read/seek/write
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_TIMECODE_SEEK ED_BASE+950L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_ATN_READ ED_BASE+951L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_ATN_SEEK ED_BASE+952L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_ATN_WRITE ED_BASE+953L

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_RTC_READ ED_BASE+954L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_RTC_SEEK ED_BASE+955L
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_DEVCAP_RTC_WRITE ED_BASE+956L

// 
// Basic parameter
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ED_TIMEREF_ATN ED_BASE+958L


// 
// GUID used to identify a class driver
// 

#if ! OUR_GUID_ENTRY
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define OUR_GUID_ENTRY(name, l, w1, w2, b1, b2, b3, b4, b5, b6, b7, b8) DEFINE_GUID(name, l, w1, w2, b1, b2, b3, b4, b5, b6, b7, b8);
    #define OUR_GUID_ENTRY
#endif

// 8C0F6AF2-0EDB-44c1-8AEB-59040BD830ED  MSTapeDeviceGUID
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(MSTapeDeviceGUID, 0x8C0F6AF2, 0x0EDB, 0x44c1, 0x8A, 0xEB, 0x59, 0x04, 0x0B, 0xD8, 0x30, 0xED);


// eof XPrtDefs.h
