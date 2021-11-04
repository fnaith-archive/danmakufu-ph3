// ------------------------------------------------------------------------------
// File: BDATypes.h
// 
// Desc: Typedefs and enums needed by both the WDM drivers and the user mode
//       COM interfaces.
// 
// Copyright (c) 1999 - 2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------




/* Utility Macros */



#if __midl
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define V1_ENUM [v1_enum]
#define V1_ENUM
#else
#define V1_ENUM
#endif

// ===========================================================================
// 
//  BDA Topology Structures
// 
// ===========================================================================

public class _BDA_TEMPLATE_CONNECTION
{
    public uint FromNodeType;
    public uint FromNodePinType;
    public uint ToNodeType;
    public uint ToNodePinType;
}


public class _BDA_TEMPLATE_PIN_JOINT
{
    public uint uliTemplateConnection;
    public uint ulcInstancesMax;
}



// ===========================================================================
// 
//  BDA Events
// 
// ===========================================================================

//  In-band Event IDs
// 
public enum BDA_EVENT_ID
{
    BDA_EVENT_SIGNAL_LOSS = 0,
    BDA_EVENT_SIGNAL_LOCK,
    BDA_EVENT_DATA_START,
    BDA_EVENT_DATA_STOP,
    BDA_EVENT_CHANNEL_ACQUIRED,
    BDA_EVENT_CHANNEL_LOST,
    BDA_EVENT_CHANNEL_SOURCE_CHANGED,
    BDA_EVENT_CHANNEL_ACTIVATED,
    BDA_EVENT_CHANNEL_DEACTIVATED,
    BDA_EVENT_SUBCHANNEL_ACQUIRED,
    BDA_EVENT_SUBCHANNEL_LOST,
    BDA_EVENT_SUBCHANNEL_SOURCE_CHANGED,
    BDA_EVENT_SUBCHANNEL_ACTIVATED,
    BDA_EVENT_SUBCHANNEL_DEACTIVATED,
    BDA_EVENT_ACCESS_GRANTED,
    BDA_EVENT_ACCESS_DENIED,
    BDA_EVENT_OFFER_EXTENDED,
    BDA_EVENT_PURCHASE_COMPLETED,
    BDA_EVENT_SMART_CARD_INSERTED,
    BDA_EVENT_SMART_CARD_REMOVED
}



// ===========================================================================
// 
//  KSSTREAM_HEADER extensions for BDA
// 
// ===========================================================================

public class tagKS_BDA_FRAME_INFO
{
    public uint ExtendedHeaderSize; // Size of this extended header
    public uint dwFrameFlags;
    public uint ulEvent;
    public uint ulChannelNumber;
    public uint ulSubchannelNumber;
    public uint ulReason;
}


// ------------------------------------------------------------
// 
//  BDA Network Ethernet Filter Property Set
// 
// {71985F43-1CA1-11d3-9CC8-00C04F7971E0}
// 
public class _BDA_ETHERNET_ADDRESS
{
    public byte[] rgbAddress = new byte[6];
}

public class _BDA_ETHERNET_ADDRESS_LIST
{
    public uint ulcAddresses;
    public _BDA_ETHERNET_ADDRESS[] rgAddressl = Arrays.InitializeWithDefaultInstances<_BDA_ETHERNET_ADDRESS>(DefineConstants.MIN_DIMENSION);
}

public enum BDA_MULTICAST_MODE
{
    BDA_PROMISCUOUS_MULTICAST = 0,
    BDA_FILTERED_MULTICAST,
    BDA_NO_MULTICAST
}


// ------------------------------------------------------------
// 
//  BDA Network IPv4 Filter Property Set
// 
// {71985F44-1CA1-11d3-9CC8-00C04F7971E0}
// 
public class _BDA_IPv4_ADDRESS
{
    public byte[] rgbAddress = new byte[4];
}

public class _BDA_IPv4_ADDRESS_LIST
{
    public uint ulcAddresses;
    public _BDA_IPv4_ADDRESS[] rgAddressl = Arrays.InitializeWithDefaultInstances<_BDA_IPv4_ADDRESS>(DefineConstants.MIN_DIMENSION);
}


// ------------------------------------------------------------
// 
//  BDA Network IPv4 Filter Property Set
// 
// {E1785A74-2A23-4fb3-9245-A8F88017EF33}
// 
public class _BDA_IPv6_ADDRESS
{
    public byte[] rgbAddress = new byte[6];
}

public class _BDA_IPv6_ADDRESS_LIST
{
    public uint ulcAddresses;
    public _BDA_IPv6_ADDRESS[] rgAddressl = Arrays.InitializeWithDefaultInstances<_BDA_IPv6_ADDRESS>(DefineConstants.MIN_DIMENSION);
}


// ------------------------------------------------------------
// 
// 
//  BDA Signal Property Set
// 
//  {D2F1644B-B409-11d2-BC69-00A0C9EE9E16}
// 
public enum BDA_SIGNAL_STATE
{
    BDA_SIGNAL_UNAVAILABLE = 0,
    BDA_SIGNAL_INACTIVE,
    BDA_SIGNAL_ACTIVE
}


// ------------------------------------------------------------
// 
// 
//  BDA Change Sync Method Set
// 
// {FD0A5AF3-B41D-11d2-9C95-00C04F7971E0}
// 
public enum BDA_CHANGE_STATE
{
    BDA_CHANGES_COMPLETE = 0,
    BDA_CHANGES_PENDING

}


// ------------------------------------------------------------
// 
// 
//  BDA Device Configuration Method Set
// 
// {71985F45-1CA1-11d3-9CC8-00C04F7971E0}
// 


// ------------------------------------------------------------
// 
// 
//  BDA Topology Property Set
// 
// {A14EE835-0A23-11d3-9CC7-00C04F7971E0}
// 

public class _BDANODE_DESCRIPTOR
{
    public uint ulBdaNodeType; // The node type as it is used
                                        // in the BDA template topology

    public GUID guidFunction = new GUID(); // GUID from BdaMedia.h describing
                                        // the node's function (e.g.
                                        // KSNODE_BDA_RF_TUNER)

    public GUID guidName = new GUID(); // GUID that can be use to look up
                                        // a displayable name for the node.
}


// ------------------------------------------------------------
// 
// 
//  BDA Void Transform Property Set
// 
// {71985F46-1CA1-11d3-9CC8-00C04F7971E0}
// 


// ------------------------------------------------------------
// 
// 
//  BDA Null Transform Property Set
// 
// {DDF15B0D-BD25-11d2-9CA0-00C04F7971E0}
// 


// ------------------------------------------------------------
// 
// 
//  BDA Frequency Filter Property Set
// 
// {71985F47-1CA1-11d3-9CC8-00C04F7971E0}
// 


// ------------------------------------------------------------
// 
// 
//  BDA Autodemodulate Property Set
// 
// {DDF15B12-BD25-11d2-9CA0-00C04F7971E0}
// 


// ------------------------------------------------------------
// 
// 
//  BDA Table Section Property Set
// 
// {516B99C5-971C-4aaf-B3F3-D9FDA8A15E16}
// 

public class _BDA_TABLE_SECTION
{
    public uint ulPrimarySectionId;
    public uint ulSecondarySectionId;
    public uint ulcbSectionLength;
    public uint[] argbSectionData = new uint[DefineConstants.MIN_DIMENSION];
}


// ------------------------------------------------------------
// 
// 
//  BDA PID Filter Property Set
// 
// {D0A67D65-08DF-4fec-8533-E5B550410B85}
// 

// ---------------------------------------------------------------------
// From IEnumPIDMap interface
// ---------------------------------------------------------------------

public enum MEDIA_SAMPLE_CONTENT
{
    MEDIA_TRANSPORT_PACKET, //  complete TS packet e.g. pass-through mode
    MEDIA_ELEMENTARY_STREAM, //  PES payloads; audio/video only
    MEDIA_MPEG2_PSI, //  PAT, PMT, CAT, Private
    MEDIA_TRANSPORT_PAYLOAD //  gathered TS packet payloads (PES packets, etc...)
}

public class PID_MAP
{
    public uint ulPID;
    public MEDIA_SAMPLE_CONTENT MediaSampleContent;
}

public class _BDA_PID_MAP
{
    public MEDIA_SAMPLE_CONTENT MediaSampleContent;
    public uint ulcPIDs;
    public uint[] aulPIDs = new uint[DefineConstants.MIN_DIMENSION];
}

public class _BDA_PID_UNMAP
{
    public uint ulcPIDs;
    public uint[] aulPIDs = new uint[DefineConstants.MIN_DIMENSION];
}


// ------------------------------------------------------------
// 
// 
//  BDA CA Property Set
// 
// {B0693766-5278-4ec6-B9E1-3CE40560EF5A}
// 
public class _BDA_CA_MODULE_UI
{
    public uint ulFormat;
    public uint ulbcDesc;
    public uint[] ulDesc = new uint[DefineConstants.MIN_DIMENSION];
}

public class _BDA_PROGRAM_PID_LIST
{
    public uint ulProgramNumber;
    public uint ulcPIDs;
    public uint[] ulPID = new uint[DefineConstants.MIN_DIMENSION];
}


// ------------------------------------------------------------
// 
// 
//  BDA CA Event Set
// 
// {488C4CCC-B768-4129-8EB1-B00A071F9068}
// 



// =============================================================
// 
// 
//  BDA Tuning Model enumerations
// 
// 
// =============================================================

// system type for particular DVB Tuning Space instance
public enum DVBSystemType
{
    DVB_Cable,
    DVB_Terrestrial,
    DVB_Satellite
}

// ------------------------------------------------------------
// 
//  BDA Channel Tune Request

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
public V1_ENUM enum AnonymousEnum
{
    BDA_UNDEFINED_CHANNEL = -1
}


// ------------------------------------------------------------
// 
//  BDA Component(substream)
// 

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum ComponentCategory
{
    CategoryNotSet = -1,
    CategoryOther = 0,
    CategoryVideo,
    CategoryAudio,
    CategoryText,
    CategoryData
}

// Component Status
public enum ComponentStatus
{
    StatusActive,
    StatusInactive,
    StatusUnavailable
}


// ------------------------------------------------------------
// 
//  BDA MPEG2 Component Type
// 
// from the MPEG2 specification
// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum MPEG2StreamType
{
    BDA_UNITIALIZED_MPEG2STREAMTYPE = -1,
    Reserved1 = 0x0,
    ISO_IEC_11172_2_VIDEO = Reserved1 + 1,
    ISO_IEC_13818_2_VIDEO = ISO_IEC_11172_2_VIDEO + 1,
    ISO_IEC_11172_3_AUDIO = ISO_IEC_13818_2_VIDEO + 1,
    ISO_IEC_13818_3_AUDIO = ISO_IEC_11172_3_AUDIO + 1,
    ISO_IEC_13818_1_PRIVATE_SECTION = ISO_IEC_13818_3_AUDIO + 1,
    ISO_IEC_13818_1_PES = ISO_IEC_13818_1_PRIVATE_SECTION + 1,
    ISO_IEC_13522_MHEG = ISO_IEC_13818_1_PES + 1,
    ANNEX_A_DSM_CC = ISO_IEC_13522_MHEG + 1,
    ITU_T_REC_H_222_1 = ANNEX_A_DSM_CC + 1,
    ISO_IEC_13818_6_TYPE_A = ITU_T_REC_H_222_1 + 1,
    ISO_IEC_13818_6_TYPE_B = ISO_IEC_13818_6_TYPE_A + 1,
    ISO_IEC_13818_6_TYPE_C = ISO_IEC_13818_6_TYPE_B + 1,
    ISO_IEC_13818_6_TYPE_D = ISO_IEC_13818_6_TYPE_C + 1,
    ISO_IEC_13818_1_AUXILIARY = ISO_IEC_13818_6_TYPE_D + 1,
    ISO_IEC_13818_1_RESERVED = ISO_IEC_13818_1_AUXILIARY + 1,
    USER_PRIVATE = ISO_IEC_13818_1_RESERVED + 1
}

// ------------------------------------------------------------
// 
//  mpeg-2 transport stride format block; associated with media
//   types MEDIATYPE_Stream/MEDIASUBTYPE_MPEG2_TRANSPORT_STRIDE;
//   *all* format blocks associated with above media type *must*
//   start with the MPEG2_TRANSPORT_STRIDE structure
// 

public class _MPEG2_TRANSPORT_STRIDE
{
    public uint dwOffset;
    public uint dwPacketLength;
    public uint dwStride;
}

// ------------------------------------------------------------
// 
//  BDA ATSC Component Type
// 
// 
// ATSC made AC3 Audio a descriptor instead of
// defining a user private stream type.
public enum ATSCComponentTypeFlags
{
    // bit flags for various component type properties
    ATSCCT_AC3 = 0x00000001
}


// ------------------------------------------------------------
// 
//  BDA Locators
// 


// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum BinaryConvolutionCodeRate
{
    BDA_BCC_RATE_NOT_SET = -1,
    BDA_BCC_RATE_NOT_DEFINED = 0,
    BDA_BCC_RATE_1_2 = 1, // 1/2
    BDA_BCC_RATE_2_3, // 2/3
    BDA_BCC_RATE_3_4, // 3/4
    BDA_BCC_RATE_3_5,
    BDA_BCC_RATE_4_5,
    BDA_BCC_RATE_5_6, // 5/6
    BDA_BCC_RATE_5_11,
    BDA_BCC_RATE_7_8, // 7/8
    BDA_BCC_RATE_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum FECMethod
{
    BDA_FEC_METHOD_NOT_SET = -1,
    BDA_FEC_METHOD_NOT_DEFINED = 0,
    BDA_FEC_VITERBI = 1, // FEC is a Viterbi Binary Convolution.
    BDA_FEC_RS_204_188, // The FEC is Reed-Solomon 204/188 (outer FEC)
    BDA_FEC_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum ModulationType
{
    BDA_MOD_NOT_SET = -1,
    BDA_MOD_NOT_DEFINED = 0,
    BDA_MOD_16QAM = 1,
    BDA_MOD_32QAM,
    BDA_MOD_64QAM,
    BDA_MOD_80QAM,
    BDA_MOD_96QAM,
    BDA_MOD_112QAM,
    BDA_MOD_128QAM,
    BDA_MOD_160QAM,
    BDA_MOD_192QAM,
    BDA_MOD_224QAM,
    BDA_MOD_256QAM,
    BDA_MOD_320QAM,
    BDA_MOD_384QAM,
    BDA_MOD_448QAM,
    BDA_MOD_512QAM,
    BDA_MOD_640QAM,
    BDA_MOD_768QAM,
    BDA_MOD_896QAM,
    BDA_MOD_1024QAM,
    BDA_MOD_QPSK,
    BDA_MOD_BPSK,
    BDA_MOD_OQPSK,
    BDA_MOD_8VSB,
    BDA_MOD_16VSB,
    BDA_MOD_ANALOG_AMPLITUDE, // std am
    BDA_MOD_ANALOG_FREQUENCY, // std fm
    BDA_MOD_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum SpectralInversion
{
    BDA_SPECTRAL_INVERSION_NOT_SET = -1,
    BDA_SPECTRAL_INVERSION_NOT_DEFINED = 0,
    BDA_SPECTRAL_INVERSION_AUTOMATIC = 1,
    BDA_SPECTRAL_INVERSION_NORMAL,
    BDA_SPECTRAL_INVERSION_INVERTED,
    BDA_SPECTRAL_INVERSION_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum Polarisation
{
    BDA_POLARISATION_NOT_SET = -1,
    BDA_POLARISATION_NOT_DEFINED = 0,
    BDA_POLARISATION_LINEAR_H = 1, // Linear horizontal polarisation
    BDA_POLARISATION_LINEAR_V, // Linear vertical polarisation
    BDA_POLARISATION_CIRCULAR_L, // Circular left polarisation
    BDA_POLARISATION_CIRCULAR_R, // Circular right polarisation
    BDA_POLARISATION_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum GuardInterval
{
    BDA_GUARD_NOT_SET = -1,
    BDA_GUARD_NOT_DEFINED = 0,
    BDA_GUARD_1_32 = 1, // Guard interval is 1/32
    BDA_GUARD_1_16, // Guard interval is 1/16
    BDA_GUARD_1_8, // Guard interval is 1/8
    BDA_GUARD_1_4, // Guard interval is 1/4
    BDA_GUARD_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum HierarchyAlpha
{
    BDA_HALPHA_NOT_SET = -1,
    BDA_HALPHA_NOT_DEFINED = 0,
    BDA_HALPHA_1 = 1, // Hierarchy alpha is 1.
    BDA_HALPHA_2, // Hierarchy alpha is 2.
    BDA_HALPHA_4, // Hierarchy alpha is 4.
    BDA_HALPHA_MAX
}

// C++ TO C# CONVERTER TODO TASK: The #define macro 'V1_ENUM' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
public V1_ENUM enum TransmissionMode
{
    BDA_XMIT_MODE_NOT_SET = -1,
    BDA_XMIT_MODE_NOT_DEFINED = 0,
    BDA_XMIT_MODE_2K = 1, // Transmission uses 1705 carriers (use a 2K FFT)
    BDA_XMIT_MODE_8K, // Transmission uses 6817 carriers (use an 8K FFT)
    BDA_XMIT_MODE_MAX
}

//  Settings for Tuner Frequency
// 

//  Settings for Tuner Range
// 
//  Tuner range refers to the setting of LNB High/Low as well as the
//  selection of a satellite on a multiple satellite switch.
// 

//  Settings for Tuner Channel Bandwidth
// 

//  Settings for Tuner Frequency Multiplier
// 


// end of file -- bdatypes.h
