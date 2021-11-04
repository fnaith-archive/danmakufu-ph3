/*==========================================================================
 *
 *	Copyright (C) 1998-2002 Microsoft Corporation.  All Rights Reserved.
 *
 *	File:		DPlay8.h
 *	Content:	DirectPlay8 include file
 *
 ***************************************************************************/


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h> // for DECLARE_INTERFACE_ and HRESULT

/*==========================================================================
 *
 *	Copyright (C) 1998-2002 Microsoft Corporation.  All Rights Reserved.
 *
 *	File:		DPlay8.h
 *	Content:	DirectPlay8 include file
 *
 ***************************************************************************/


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h> // for DECLARE_INTERFACE_ and HRESULT



#if __cplusplus
#endif



/****************************************************************************
 *
 * DirectPlay8 CLSIDs
 *
 ****************************************************************************/

// {743F1DC6-5ABA-429f-8BDF-C54D03253DC2}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8Client, 0x743f1dc6, 0x5aba, 0x429f, 0x8b, 0xdf, 0xc5, 0x4d, 0x3, 0x25, 0x3d, 0xc2);

// {DA825E1B-6830-43d7-835D-0B5AD82956A2}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8Server, 0xda825e1b, 0x6830, 0x43d7, 0x83, 0x5d, 0xb, 0x5a, 0xd8, 0x29, 0x56, 0xa2);

// {286F484D-375E-4458-A272-B138E2F80A6A}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8Peer, 0x286f484d, 0x375e, 0x4458, 0xa2, 0x72, 0xb1, 0x38, 0xe2, 0xf8, 0xa, 0x6a);


// CLSIDs added for DirectX 9

// {FC47060E-6153-4b34-B975-8E4121EB7F3C}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8ThreadPool, 0xfc47060e, 0x6153, 0x4b34, 0xb9, 0x75, 0x8e, 0x41, 0x21, 0xeb, 0x7f, 0x3c);

// {E4C1D9A2-CBF7-48bd-9A69-34A55E0D8941}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8NATResolver, 0xe4c1d9a2, 0xcbf7, 0x48bd, 0x9a, 0x69, 0x34, 0xa5, 0x5e, 0xd, 0x89, 0x41);

/****************************************************************************
 *
 * DirectPlay8 Interface IIDs
 *
 ****************************************************************************/



// {5102DACD-241B-11d3-AEA7-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8Client, 0x5102dacd, 0x241b, 0x11d3, 0xae, 0xa7, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);

// {5102DACE-241B-11d3-AEA7-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8Server, 0x5102dace, 0x241b, 0x11d3, 0xae, 0xa7, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);

// {5102DACF-241B-11d3-AEA7-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8Peer, 0x5102dacf, 0x241b, 0x11d3, 0xae, 0xa7, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);


// IIDs added for DirectX 9

// {0D22EE73-4A46-4a0d-89B2-045B4D666425}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8ThreadPool, 0xd22ee73, 0x4a46, 0x4a0d, 0x89, 0xb2, 0x4, 0x5b, 0x4d, 0x66, 0x64, 0x25);

// {A9E213F2-9A60-486f-BF3B-53408B6D1CBB}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8NATResolver, 0xa9e213f2, 0x9a60, 0x486f, 0xbf, 0x3b, 0x53, 0x40, 0x8b, 0x6d, 0x1c, 0xbb);

/****************************************************************************
 *
 * DirectPlay8 Service Provider GUIDs
 *
 ****************************************************************************/


// {53934290-628D-11D2-AE0F-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DP8SP_IPX, 0x53934290, 0x628d, 0x11d2, 0xae, 0xf, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);


// {6D4A3650-628D-11D2-AE0F-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DP8SP_MODEM, 0x6d4a3650, 0x628d, 0x11d2, 0xae, 0xf, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);


// {743B5D60-628D-11D2-AE0F-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DP8SP_SERIAL, 0x743b5d60, 0x628d, 0x11d2, 0xae, 0xf, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);


// {EBFE7BA0-628D-11D2-AE0F-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DP8SP_TCPIP, 0xebfe7ba0, 0x628d, 0x11d2, 0xae, 0xf, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);


// Service providers added for DirectX 9


// {995513AF-3027-4b9a-956E-C772B3F78006}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DP8SP_BLUETOOTH, 0x995513af, 0x3027, 0x4b9a, 0x95, 0x6e, 0xc7, 0x72, 0xb3, 0xf7, 0x80, 0x6);


/****************************************************************************
 *
 * DirectPlay8 Interface Pointer definitions
 *
 ****************************************************************************/





// Interface pointers added for DirectX 9



/****************************************************************************
 *
 * DirectPlay8 Forward Declarations For External Types
 *
 ****************************************************************************/


/****************************************************************************
 *
 * DirectPlay8 Callback Functions
 *
 ****************************************************************************/

// 
// Callback Function Type Definition
// 
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(WINAPI *PFNDPNMESSAGEHANDLER)(object*,uint,object*);
public delegate int PFNDPNMESSAGEHANDLER(object UnnamedParameter, uint UnnamedParameter2, object UnnamedParameter3);

/****************************************************************************
 *
 * DirectPlay8 Datatypes (Non-Structure / Non-Message)
 *
 ****************************************************************************/

// 
// Player IDs.  Used to uniquely identify a player in a session
// 

// 
// Used as identifiers for operations
// 




/****************************************************************************
 *
 * DirectPlay8 Message Identifiers
 *
 ****************************************************************************/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ADD_PLAYER_TO_GROUP ( DPN_MSGID_OFFSET | 0x0001 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_APPLICATION_DESC ( DPN_MSGID_OFFSET | 0x0002 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ASYNC_OP_COMPLETE ( DPN_MSGID_OFFSET | 0x0003 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CLIENT_INFO ( DPN_MSGID_OFFSET | 0x0004 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CONNECT_COMPLETE ( DPN_MSGID_OFFSET | 0x0005 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CREATE_GROUP ( DPN_MSGID_OFFSET | 0x0006 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CREATE_PLAYER ( DPN_MSGID_OFFSET | 0x0007 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_DESTROY_GROUP ( DPN_MSGID_OFFSET | 0x0008 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_DESTROY_PLAYER ( DPN_MSGID_OFFSET | 0x0009 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ENUM_HOSTS_QUERY ( DPN_MSGID_OFFSET | 0x000a )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ENUM_HOSTS_RESPONSE ( DPN_MSGID_OFFSET | 0x000b )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_GROUP_INFO ( DPN_MSGID_OFFSET | 0x000c )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_HOST_MIGRATE ( DPN_MSGID_OFFSET | 0x000d )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_INDICATE_CONNECT ( DPN_MSGID_OFFSET | 0x000e )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_INDICATED_CONNECT_ABORTED ( DPN_MSGID_OFFSET | 0x000f )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_PEER_INFO ( DPN_MSGID_OFFSET | 0x0010 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_RECEIVE ( DPN_MSGID_OFFSET | 0x0011 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_REMOVE_PLAYER_FROM_GROUP ( DPN_MSGID_OFFSET | 0x0012 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_RETURN_BUFFER ( DPN_MSGID_OFFSET | 0x0013 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_SEND_COMPLETE ( DPN_MSGID_OFFSET | 0x0014 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_SERVER_INFO ( DPN_MSGID_OFFSET | 0x0015 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_TERMINATE_SESSION ( DPN_MSGID_OFFSET | 0x0016 )

// Messages added for DirectX 9
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CREATE_THREAD ( DPN_MSGID_OFFSET | 0x0017 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_DESTROY_THREAD ( DPN_MSGID_OFFSET | 0x0018 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_NAT_RESOLVER_QUERY ( DPN_MSGID_OFFSET | 0x0101 )

/****************************************************************************
 *
 * DirectPlay8 Constants
 *
 ****************************************************************************/


// 
// DESTROY_GROUP reasons
// 

// 
// DESTROY_PLAYER reasons
// 




/****************************************************************************
 *
 * DirectPlay8 Flags
 *
 ****************************************************************************/

// 
// Asynchronous operation flags (for Async Ops)
// 

// 
// Add player to group flags (for AddPlayerToGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNADDPLAYERTOGROUP_SYNC DPNOP_SYNC

// 
// Cancel flags
// 
// Flags added for DirectX 9
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCANCEL_PLAYER_SENDS_PRIORITY_HIGH (DPNCANCEL_PLAYER_SENDS | 0x00010000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCANCEL_PLAYER_SENDS_PRIORITY_NORMAL (DPNCANCEL_PLAYER_SENDS | 0x00020000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCANCEL_PLAYER_SENDS_PRIORITY_LOW (DPNCANCEL_PLAYER_SENDS | 0x00040000)

// 
// Close flags (for Close, added for DirectX 9)
// 

// 
// Connect flags (for Connect)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCONNECT_SYNC DPNOP_SYNC

// 
// Create group flags (for CreateGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCREATEGROUP_SYNC DPNOP_SYNC

// 
// Destroy group flags (for DestroyGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNDESTROYGROUP_SYNC DPNOP_SYNC

// 
// Enumerate clients and groups flags (for EnumPlayersAndGroups)
// 

// 
// Enum hosts flags (for EnumHosts)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNENUMHOSTS_SYNC DPNOP_SYNC

// 
// Enum service provider flags (for EnumSP)
// 

// 
// GetLocalHostAddresses flags (added for DirectX 9)
// 

// 
// Get send queue info flags (for GetSendQueueInfo)
// 

// 
// Group information flags (for Group Info)
// 

// 
// Host flags (for Host)
// 

// 
// Set info
// 

// 
// Initialize flags (for Initialize)
// 
// Flags added for DirectX 9


// 
// Register Lobby flags
// 

// 
// Player information flags (for Player Info / Player Messages)
// 

// 
// Receive indication flags (added for DirectX 9)
// 

// 
// Remove player from group flags (for RemovePlayerFromGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNREMOVEPLAYERFROMGROUP_SYNC DPNOP_SYNC

// 
// Send flags (for Send/SendTo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSEND_SYNC DPNOP_SYNC
// Flag added for DirectX 9

// 
// Send complete indication flags (added for DirectX 9)
// 

// 
// Session Flags (for DPN_APPLICATION_DESC)
// 
// Flag added for DirectX 9

// 
// Set client info flags (for SetClientInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETCLIENTINFO_SYNC DPNOP_SYNC

// 
// Set group info flags (for SetGroupInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETGROUPINFO_SYNC DPNOP_SYNC

// 
// Set peer info flags (for SetPeerInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETPEERINFO_SYNC DPNOP_SYNC

// 
// Set server info flags (for SetServerInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETSERVERINFO_SYNC DPNOP_SYNC

// 
// SP capabilities flags
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSPCAPS_SUPPORTSDPNSRV DPNSPCAPS_SUPPORTSDPNSVR
// Flags added for DirectX 9

// 
// SP information flags (added for DirectX 9)
// 

/****************************************************************************
 *
 * DirectPlay8 Structures (Non-Message)
 *
 ****************************************************************************/

// 
// Application description
// 
public partial class _DPN_APPLICATION_DESC
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags (DPNSESSION_...)
    public GUID guidInstance = new GUID(); // Instance GUID
    public GUID guidApplication = new GUID(); // Application GUID
    public uint dwMaxPlayers; // Maximum # of players allowed (0=no limit)
    public uint dwCurrentPlayers; // Current # of players allowed
    public string pwszSessionName; // Name of the session
    public string pwszPassword; // Password for the session
    public object pvReservedData;
    public uint dwReservedDataSize;
    public object pvApplicationReservedData;
    public uint dwApplicationReservedDataSize;
}

// 
// Generic Buffer Description
// 
public partial class _BUFFERDESC
{
    public uint dwBufferSize;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * pBufferData;
    public byte pBufferData;
}


// 
// DirectPlay8 capabilities
// 
public partial class _DPN_CAPS
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags
    public uint dwConnectTimeout; // ms before a connect request times out
    public uint dwConnectRetries; // # of times to attempt the connection
    public uint dwTimeoutUntilKeepAlive; // ms of inactivity before a keep alive is sent
}

// 
// Extended capabilities structures (added for DirectX 9)
// 
public partial class _DPN_CAPS_EX
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags
    public uint dwConnectTimeout; // ms before a connect request times out
    public uint dwConnectRetries; // # of times to attempt the connection
    public uint dwTimeoutUntilKeepAlive; // ms of inactivity before a keep alive is sent
    public uint dwMaxRecvMsgSize; // maximum size in bytes of message that can be received
    public uint dwNumSendRetries; // maximum number of send retries before link is considered dead
    public uint dwMaxSendRetryInterval; // maximum period in msec between send retries
    public uint dwDropThresholdRate; // percentage of dropped packets before throttling
    public uint dwThrottleRate; // percentage amount to reduce send window when throttling
    public uint dwNumHardDisconnectSends; // number of hard disconnect frames to send when close immediate flag is specified
    public uint dwMaxHardDisconnectPeriod; // maximum period between hard disconnect sends
}

// 
// Connection Statistics information
// 
public partial class _DPN_CONNECTION_INFO
{
    public uint dwSize;
    public uint dwRoundTripLatencyMS;
    public uint dwThroughputBPS;
    public uint dwPeakThroughputBPS;

    public uint dwBytesSentGuaranteed;
    public uint dwPacketsSentGuaranteed;
    public uint dwBytesSentNonGuaranteed;
    public uint dwPacketsSentNonGuaranteed;

    public uint dwBytesRetried; // Guaranteed only
    public uint dwPacketsRetried; // Guaranteed only
    public uint dwBytesDropped; // Non Guaranteed only
    public uint dwPacketsDropped; // Non Guaranteed only

    public uint dwMessagesTransmittedHighPriority;
    public uint dwMessagesTimedOutHighPriority;
    public uint dwMessagesTransmittedNormalPriority;
    public uint dwMessagesTimedOutNormalPriority;
    public uint dwMessagesTransmittedLowPriority;
    public uint dwMessagesTimedOutLowPriority;

    public uint dwBytesReceivedGuaranteed;
    public uint dwPacketsReceivedGuaranteed;
    public uint dwBytesReceivedNonGuaranteed;
    public uint dwPacketsReceivedNonGuaranteed;
    public uint dwMessagesReceived;

}


// 
// Group information structure
// 
public partial class _DPN_GROUP_INFO
{
    public uint dwSize; // size of this structure
    public uint dwInfoFlags; // information contained
    public string pwszName; // Unicode Name
    public object pvData; // data block
    public uint dwDataSize; // size in BYTES of data block
    public uint dwGroupFlags; // group flags (DPNGROUP_...)
}

// 
// Player information structure
// 
public partial class _DPN_PLAYER_INFO
{
    public uint dwSize; // size of this structure
    public uint dwInfoFlags; // information contained
    public string pwszName; // Unicode Name
    public object pvData; // data block
    public uint dwDataSize; // size in BYTES of data block
    public uint dwPlayerFlags; // player flags (DPNPLAYER_...)
}


// 
// Service provider & adapter enumeration structure
// 
public partial class _DPN_SERVICE_PROVIDER_INFO
{
    public uint dwFlags;
    public GUID guid = new GUID(); // SP Guid
    public string pwszName; // Friendly Name
    public object pvReserved;
    public uint dwReserved;
}

// 
// Service provider caps structure
// 
public partial class _DPN_SP_CAPS
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags (DPNSPCAPS_...)
    public uint dwNumThreads; // # of worker threads to use
    public uint dwDefaultEnumCount; // default # of enum requests
    public uint dwDefaultEnumRetryInterval; // default ms between enum requests
    public uint dwDefaultEnumTimeout; // default enum timeout
    public uint dwMaxEnumPayloadSize; // maximum size in bytes for enum payload data
    public uint dwBuffersPerThread; // number of receive buffers per thread
    public uint dwSystemBufferSize; // amount of buffering to do in addition to posted receive buffers
}


/****************************************************************************
 *
 * IDirectPlay8 message handler call back structures
 *
 ****************************************************************************/

// 
// Add player to group structure for message handler
// (DPN_MSGID_ADD_PLAYER_TO_GROUP)
// 
public partial class _DPNMSG_ADD_PLAYER_TO_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of group
    public object pvGroupContext; // Group context value
    public uint dpnidPlayer; // DPNID of added player
    public object pvPlayerContext; // Player context value
}

// 
// Async operation completion structure for message handler
// (DPN_MSGID_ASYNC_OP_COMPLETE)
// 
public partial class _DPNMSG_ASYNC_OP_COMPLETE
{
    public uint dwSize; // Size of this structure
    public uint hAsyncOp; // DirectPlay8 async operation handle
    public object pvUserContext; // User context supplied
    public int hResultCode; // HRESULT of operation
}

// 
// Client info structure for message handler
// (DPN_MSGID_CLIENT_INFO)
// 
public partial class _DPNMSG_CLIENT_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidClient; // DPNID of client
    public object pvPlayerContext; // Player context value
}

// 
// Connect complete structure for message handler
// (DPN_MSGID_CONNECT_COMPLETE)
// 
public partial class _DPNMSG_CONNECT_COMPLETE
{
    public uint dwSize; // Size of this structure
    public uint hAsyncOp; // DirectPlay8 Async operation handle
    public object pvUserContext; // User context supplied at Connect
    public int hResultCode; // HRESULT of connection attempt
    public object pvApplicationReplyData; // Connection reply data from Host/Server
    public uint dwApplicationReplyDataSize; // Size (in bytes) of pvApplicationReplyData

    // Fields added for DirectX 9
    public uint dpnidLocal; // DPNID of local player
}

// 
// Create group structure for message handler
// (DPN_MSGID_CREATE_GROUP)
// 
public partial class _DPNMSG_CREATE_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of new group
    public uint dpnidOwner; // Owner of newgroup
    public object pvGroupContext; // Group context value

    // Fields added for DirectX 9
    public object pvOwnerContext; // Owner context value
}

// 
// Create player structure for message handler
// (DPN_MSGID_CREATE_PLAYER)
// 
public partial class _DPNMSG_CREATE_PLAYER
{
    public uint dwSize; // Size of this structure
    public uint dpnidPlayer; // DPNID of new player
    public object pvPlayerContext; // Player context value
}

// 
// Destroy group structure for message handler
// (DPN_MSGID_DESTROY_GROUP)
// 
public partial class _DPNMSG_DESTROY_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of destroyed group
    public object pvGroupContext; // Group context value
    public uint dwReason; // Information only
}

// 
// Destroy player structure for message handler
// (DPN_MSGID_DESTROY_PLAYER)
// 
public partial class _DPNMSG_DESTROY_PLAYER
{
    public uint dwSize; // Size of this structure
    public uint dpnidPlayer; // DPNID of leaving player
    public object pvPlayerContext; // Player context value
    public uint dwReason; // Information only
}

// 
// Enumeration request received structure for message handler
// (DPN_MSGID_ENUM_HOSTS_QUERY)
// 
public partial class _DPNMSG_ENUM_HOSTS_QUERY
{
    public uint dwSize; // Size of this structure.
    public IDirectPlay8Address pAddressSender; // Address of client who sent the request
    public IDirectPlay8Address pAddressDevice; // Address of device request was received on
    public object pvReceivedData; // Request data (set on client)
    public uint dwReceivedDataSize; // Request data size (set on client)
    public uint dwMaxResponseDataSize; // Max allowable size of enum response
    public object pvResponseData; // Optional query repsonse (user set)
    public uint dwResponseDataSize; // Optional query response size (user set)
    public object pvResponseContext; // Optional query response context (user set)
}

// 
// Enumeration response received structure for message handler
// (DPN_MSGID_ENUM_HOSTS_RESPONSE)
// 
public partial class _DPNMSG_ENUM_HOSTS_RESPONSE
{
    public uint dwSize; // Size of this structure
    public IDirectPlay8Address pAddressSender; // Address of host who responded
    public IDirectPlay8Address pAddressDevice; // Device response was received on
    public readonly _DPN_APPLICATION_DESC pApplicationDescription; // Application description for the session
    public object pvResponseData; // Optional response data (set on host)
    public uint dwResponseDataSize; // Optional response data size (set on host)
    public object pvUserContext; // Context value supplied for enumeration
    public uint dwRoundTripLatencyMS; // Round trip latency in MS
}

// 
// Group info structure for message handler
// (DPN_MSGID_GROUP_INFO)
// 
public partial class _DPNMSG_GROUP_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of group
    public object pvGroupContext; // Group context value
}

// 
// Migrate host structure for message handler
// (DPN_MSGID_HOST_MIGRATE)
// 
public partial class _DPNMSG_HOST_MIGRATE
{
    public uint dwSize; // Size of this structure
    public uint dpnidNewHost; // DPNID of new Host player
    public object pvPlayerContext; // Player context value
}

// 
// Indicate connect structure for message handler
// (DPN_MSGID_INDICATE_CONNECT)
// 
public partial class _DPNMSG_INDICATE_CONNECT
{
    public uint dwSize; // Size of this structure
    public object pvUserConnectData; // Connecting player data
    public uint dwUserConnectDataSize; // Size (in bytes) of pvUserConnectData
    public object pvReplyData; // Connection reply data
    public uint dwReplyDataSize; // Size (in bytes) of pvReplyData
    public object pvReplyContext; // Buffer context for pvReplyData
    public object pvPlayerContext; // Player context preset
    public IDirectPlay8Address pAddressPlayer; // Address of connecting player
    public IDirectPlay8Address pAddressDevice; // Address of device receiving connect attempt
}

// 
// Indicated connect aborted structure for message handler
// (DPN_MSGID_INDICATED_CONNECT_ABORTED)
// 
public partial class _DPNMSG_INDICATED_CONNECT_ABORTED
{
    public uint dwSize; // Size of this structure
    public object pvPlayerContext; // Player context preset from DPNMSG_INDICATE_CONNECT
}

// 
// Peer info structure for message handler
// (DPN_MSGID_PEER_INFO)
// 
public partial class _DPNMSG_PEER_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidPeer; // DPNID of peer
    public object pvPlayerContext; // Player context value
}

// 
// Receive structure for message handler
// (DPN_MSGID_RECEIVE)
// 
public partial class _DPNMSG_RECEIVE
{
    public uint dwSize; // Size of this structure
    public uint dpnidSender; // DPNID of sending player
    public object pvPlayerContext; // Player context value of sending player
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * pReceiveData;
    public byte pReceiveData; // Received data
    public uint dwReceiveDataSize; // Size (in bytes) of pReceiveData
    public uint hBufferHandle; // Buffer handle for pReceiveData

    // Fields added for DirectX 9
    public uint dwReceiveFlags; // Flags describing how message was received
}

// 
// Remove player from group structure for message handler
// (DPN_MSGID_REMOVE_PLAYER_FROM_GROUP)
// 
public partial class _DPNMSG_REMOVE_PLAYER_FROM_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of group
    public object pvGroupContext; // Group context value
    public uint dpnidPlayer; // DPNID of deleted player
    public object pvPlayerContext; // Player context value
}

// 
// Returned buffer structure for message handler
// (DPN_MSGID_RETURN_BUFFER)
// 
public partial class _DPNMSG_RETURN_BUFFER
{
    public uint dwSize; // Size of this structure
    public int hResultCode; // Return value of operation
    public object pvBuffer; // Buffer being returned
    public object pvUserContext; // Context associated with buffer
}

// 
// Send complete structure for message handler
// (DPN_MSGID_SEND_COMPLETE)
// 
public partial class _DPNMSG_SEND_COMPLETE
{
    public uint dwSize; // Size of this structure
    public uint hAsyncOp; // DirectPlay8 Async operation handle
    public object pvUserContext; // User context supplied at Send/SendTo
    public int hResultCode; // HRESULT of send
    public uint dwSendTime; // Send time in ms

    // Fields added for DirectX 9
    public uint dwFirstFrameRTT; // RTT of the first frame in the message
    public uint dwFirstFrameRetryCount; // Retry count of the first frame
    public uint dwSendCompleteFlags; // Flags describing how message was sent
    public _BUFFERDESC pBuffers; // Pointer to array of buffers sent, if DirectPlay did not make a copy
    public uint dwNumBuffers; // Number of buffers in previous array
}

// 
// Server info structure for message handler
// (DPN_MSGID_SERVER_INFO)
// 
public partial class _DPNMSG_SERVER_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidServer; // DPNID of server
    public object pvPlayerContext; // Player context value
}

// 
// Terminated session structure for message handler
// (DPN_MSGID_TERMINATE_SESSION)
// 
public partial class _DPNMSG_TERMINATE_SESSION
{
    public uint dwSize; // Size of this structure
    public int hResultCode; // Reason
    public object pvTerminateData; // Data passed from Host/Server
    public uint dwTerminateDataSize; // Size (in bytes) of pvTerminateData
}


// 
// Message structures added for DirectX 9
// 

// 
// Create thread info structure for message handler
// (DPN_MSGID_CREATE_THREAD)
// 
public partial class _DPNMSG_CREATE_THREAD
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags describing this thread
    public uint dwProcessorNum; // Index of processor to which thread is bound
    public object pvUserContext; // Thread context value
}

// 
// Destroy thread info structure for message handler
// (DPN_MSGID_DESTROY_THREAD)
// 
public partial class _DPNMSG_DESTROY_THREAD
{
    public uint dwSize; // Size of this structure
    public uint dwProcessorNum; // Index of processor to which thread was bound
    public object pvUserContext; // Thread context value
}


// 
// Query-to-resolve-NAT-address structure for message handler
// (DPN_MSGID_NAT_RESOLVER_QUERY)
// 
public partial class _DPNMSG_NAT_RESOLVER_QUERY
{
    public uint dwSize; // Size of this structure.
    public IDirectPlay8Address pAddressSender; // Address of client that sent the query
    public IDirectPlay8Address pAddressDevice; // Address of device on which query was received
    public string pwszUserString; // User specified string, or NULL if none
}

/****************************************************************************
 *
 * DirectPlay8 Datatypes (Non-Structure / Non-Message)
 *
 ****************************************************************************/

// 
// Player IDs.  Used to uniquely identify a player in a session
// 

// 
// Used as identifiers for operations
// 




/****************************************************************************
 *
 * DirectPlay8 Message Identifiers
 *
 ****************************************************************************/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ADD_PLAYER_TO_GROUP ( DPN_MSGID_OFFSET | 0x0001 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_APPLICATION_DESC ( DPN_MSGID_OFFSET | 0x0002 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ASYNC_OP_COMPLETE ( DPN_MSGID_OFFSET | 0x0003 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CLIENT_INFO ( DPN_MSGID_OFFSET | 0x0004 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CONNECT_COMPLETE ( DPN_MSGID_OFFSET | 0x0005 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CREATE_GROUP ( DPN_MSGID_OFFSET | 0x0006 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CREATE_PLAYER ( DPN_MSGID_OFFSET | 0x0007 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_DESTROY_GROUP ( DPN_MSGID_OFFSET | 0x0008 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_DESTROY_PLAYER ( DPN_MSGID_OFFSET | 0x0009 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ENUM_HOSTS_QUERY ( DPN_MSGID_OFFSET | 0x000a )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_ENUM_HOSTS_RESPONSE ( DPN_MSGID_OFFSET | 0x000b )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_GROUP_INFO ( DPN_MSGID_OFFSET | 0x000c )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_HOST_MIGRATE ( DPN_MSGID_OFFSET | 0x000d )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_INDICATE_CONNECT ( DPN_MSGID_OFFSET | 0x000e )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_INDICATED_CONNECT_ABORTED ( DPN_MSGID_OFFSET | 0x000f )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_PEER_INFO ( DPN_MSGID_OFFSET | 0x0010 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_RECEIVE ( DPN_MSGID_OFFSET | 0x0011 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_REMOVE_PLAYER_FROM_GROUP ( DPN_MSGID_OFFSET | 0x0012 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_RETURN_BUFFER ( DPN_MSGID_OFFSET | 0x0013 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_SEND_COMPLETE ( DPN_MSGID_OFFSET | 0x0014 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_SERVER_INFO ( DPN_MSGID_OFFSET | 0x0015 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_TERMINATE_SESSION ( DPN_MSGID_OFFSET | 0x0016 )

// Messages added for DirectX 9
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_CREATE_THREAD ( DPN_MSGID_OFFSET | 0x0017 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_DESTROY_THREAD ( DPN_MSGID_OFFSET | 0x0018 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPN_MSGID_NAT_RESOLVER_QUERY ( DPN_MSGID_OFFSET | 0x0101 )

/****************************************************************************
 *
 * DirectPlay8 Constants
 *
 ****************************************************************************/


// 
// DESTROY_GROUP reasons
// 

// 
// DESTROY_PLAYER reasons
// 




/****************************************************************************
 *
 * DirectPlay8 Flags
 *
 ****************************************************************************/

// 
// Asynchronous operation flags (for Async Ops)
// 

// 
// Add player to group flags (for AddPlayerToGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNADDPLAYERTOGROUP_SYNC DPNOP_SYNC

// 
// Cancel flags
// 
// Flags added for DirectX 9
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCANCEL_PLAYER_SENDS_PRIORITY_HIGH (DPNCANCEL_PLAYER_SENDS | 0x00010000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCANCEL_PLAYER_SENDS_PRIORITY_NORMAL (DPNCANCEL_PLAYER_SENDS | 0x00020000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCANCEL_PLAYER_SENDS_PRIORITY_LOW (DPNCANCEL_PLAYER_SENDS | 0x00040000)

// 
// Close flags (for Close, added for DirectX 9)
// 

// 
// Connect flags (for Connect)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCONNECT_SYNC DPNOP_SYNC

// 
// Create group flags (for CreateGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNCREATEGROUP_SYNC DPNOP_SYNC

// 
// Destroy group flags (for DestroyGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNDESTROYGROUP_SYNC DPNOP_SYNC

// 
// Enumerate clients and groups flags (for EnumPlayersAndGroups)
// 

// 
// Enum hosts flags (for EnumHosts)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNENUMHOSTS_SYNC DPNOP_SYNC

// 
// Enum service provider flags (for EnumSP)
// 

// 
// GetLocalHostAddresses flags (added for DirectX 9)
// 

// 
// Get send queue info flags (for GetSendQueueInfo)
// 

// 
// Group information flags (for Group Info)
// 

// 
// Host flags (for Host)
// 

// 
// Set info
// 

// 
// Initialize flags (for Initialize)
// 
// Flags added for DirectX 9


// 
// Register Lobby flags
// 

// 
// Player information flags (for Player Info / Player Messages)
// 

// 
// Receive indication flags (added for DirectX 9)
// 

// 
// Remove player from group flags (for RemovePlayerFromGroup)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNREMOVEPLAYERFROMGROUP_SYNC DPNOP_SYNC

// 
// Send flags (for Send/SendTo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSEND_SYNC DPNOP_SYNC
// Flag added for DirectX 9

// 
// Send complete indication flags (added for DirectX 9)
// 

// 
// Session Flags (for DPN_APPLICATION_DESC)
// 
// Flag added for DirectX 9

// 
// Set client info flags (for SetClientInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETCLIENTINFO_SYNC DPNOP_SYNC

// 
// Set group info flags (for SetGroupInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETGROUPINFO_SYNC DPNOP_SYNC

// 
// Set peer info flags (for SetPeerInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETPEERINFO_SYNC DPNOP_SYNC

// 
// Set server info flags (for SetServerInfo)
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSETSERVERINFO_SYNC DPNOP_SYNC

// 
// SP capabilities flags
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNSPCAPS_SUPPORTSDPNSRV DPNSPCAPS_SUPPORTSDPNSVR
// Flags added for DirectX 9

// 
// SP information flags (added for DirectX 9)
// 

/****************************************************************************
 *
 * DirectPlay8 Structures (Non-Message)
 *
 ****************************************************************************/

// 
// Application description
// 
public partial class _DPN_APPLICATION_DESC
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags (DPNSESSION_...)
    public GUID guidInstance = new GUID(); // Instance GUID
    public GUID guidApplication = new GUID(); // Application GUID
    public uint dwMaxPlayers; // Maximum # of players allowed (0=no limit)
    public uint dwCurrentPlayers; // Current # of players allowed
    public string pwszSessionName; // Name of the session
    public string pwszPassword; // Password for the session
    public object pvReservedData;
    public uint dwReservedDataSize;
    public object pvApplicationReservedData;
    public uint dwApplicationReservedDataSize;
}

// 
// Generic Buffer Description
// 
public partial class _BUFFERDESC
{
    public uint dwBufferSize;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * pBufferData;
    public byte pBufferData;
}


// 
// DirectPlay8 capabilities
// 
public partial class _DPN_CAPS
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags
    public uint dwConnectTimeout; // ms before a connect request times out
    public uint dwConnectRetries; // # of times to attempt the connection
    public uint dwTimeoutUntilKeepAlive; // ms of inactivity before a keep alive is sent
}

// 
// Extended capabilities structures (added for DirectX 9)
// 
public partial class _DPN_CAPS_EX
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags
    public uint dwConnectTimeout; // ms before a connect request times out
    public uint dwConnectRetries; // # of times to attempt the connection
    public uint dwTimeoutUntilKeepAlive; // ms of inactivity before a keep alive is sent
    public uint dwMaxRecvMsgSize; // maximum size in bytes of message that can be received
    public uint dwNumSendRetries; // maximum number of send retries before link is considered dead
    public uint dwMaxSendRetryInterval; // maximum period in msec between send retries
    public uint dwDropThresholdRate; // percentage of dropped packets before throttling
    public uint dwThrottleRate; // percentage amount to reduce send window when throttling
    public uint dwNumHardDisconnectSends; // number of hard disconnect frames to send when close immediate flag is specified
    public uint dwMaxHardDisconnectPeriod; // maximum period between hard disconnect sends
}

// 
// Connection Statistics information
// 
public partial class _DPN_CONNECTION_INFO
{
    public uint dwSize;
    public uint dwRoundTripLatencyMS;
    public uint dwThroughputBPS;
    public uint dwPeakThroughputBPS;

    public uint dwBytesSentGuaranteed;
    public uint dwPacketsSentGuaranteed;
    public uint dwBytesSentNonGuaranteed;
    public uint dwPacketsSentNonGuaranteed;

    public uint dwBytesRetried; // Guaranteed only
    public uint dwPacketsRetried; // Guaranteed only
    public uint dwBytesDropped; // Non Guaranteed only
    public uint dwPacketsDropped; // Non Guaranteed only

    public uint dwMessagesTransmittedHighPriority;
    public uint dwMessagesTimedOutHighPriority;
    public uint dwMessagesTransmittedNormalPriority;
    public uint dwMessagesTimedOutNormalPriority;
    public uint dwMessagesTransmittedLowPriority;
    public uint dwMessagesTimedOutLowPriority;

    public uint dwBytesReceivedGuaranteed;
    public uint dwPacketsReceivedGuaranteed;
    public uint dwBytesReceivedNonGuaranteed;
    public uint dwPacketsReceivedNonGuaranteed;
    public uint dwMessagesReceived;

}


// 
// Group information structure
// 
public partial class _DPN_GROUP_INFO
{
    public uint dwSize; // size of this structure
    public uint dwInfoFlags; // information contained
    public string pwszName; // Unicode Name
    public object pvData; // data block
    public uint dwDataSize; // size in BYTES of data block
    public uint dwGroupFlags; // group flags (DPNGROUP_...)
}

// 
// Player information structure
// 
public partial class _DPN_PLAYER_INFO
{
    public uint dwSize; // size of this structure
    public uint dwInfoFlags; // information contained
    public string pwszName; // Unicode Name
    public object pvData; // data block
    public uint dwDataSize; // size in BYTES of data block
    public uint dwPlayerFlags; // player flags (DPNPLAYER_...)
}


// 
// Service provider & adapter enumeration structure
// 
public partial class _DPN_SERVICE_PROVIDER_INFO
{
    public uint dwFlags;
    public GUID guid = new GUID(); // SP Guid
    public string pwszName; // Friendly Name
    public object pvReserved;
    public uint dwReserved;
}

// 
// Service provider caps structure
// 
public partial class _DPN_SP_CAPS
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags (DPNSPCAPS_...)
    public uint dwNumThreads; // # of worker threads to use
    public uint dwDefaultEnumCount; // default # of enum requests
    public uint dwDefaultEnumRetryInterval; // default ms between enum requests
    public uint dwDefaultEnumTimeout; // default enum timeout
    public uint dwMaxEnumPayloadSize; // maximum size in bytes for enum payload data
    public uint dwBuffersPerThread; // number of receive buffers per thread
    public uint dwSystemBufferSize; // amount of buffering to do in addition to posted receive buffers
}


/****************************************************************************
 *
 * IDirectPlay8 message handler call back structures
 *
 ****************************************************************************/

// 
// Add player to group structure for message handler
// (DPN_MSGID_ADD_PLAYER_TO_GROUP)
// 
public partial class _DPNMSG_ADD_PLAYER_TO_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of group
    public object pvGroupContext; // Group context value
    public uint dpnidPlayer; // DPNID of added player
    public object pvPlayerContext; // Player context value
}

// 
// Async operation completion structure for message handler
// (DPN_MSGID_ASYNC_OP_COMPLETE)
// 
public partial class _DPNMSG_ASYNC_OP_COMPLETE
{
    public uint dwSize; // Size of this structure
    public uint hAsyncOp; // DirectPlay8 async operation handle
    public object pvUserContext; // User context supplied
    public int hResultCode; // HRESULT of operation
}

// 
// Client info structure for message handler
// (DPN_MSGID_CLIENT_INFO)
// 
public partial class _DPNMSG_CLIENT_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidClient; // DPNID of client
    public object pvPlayerContext; // Player context value
}

// 
// Connect complete structure for message handler
// (DPN_MSGID_CONNECT_COMPLETE)
// 
public partial class _DPNMSG_CONNECT_COMPLETE
{
    public uint dwSize; // Size of this structure
    public uint hAsyncOp; // DirectPlay8 Async operation handle
    public object pvUserContext; // User context supplied at Connect
    public int hResultCode; // HRESULT of connection attempt
    public object pvApplicationReplyData; // Connection reply data from Host/Server
    public uint dwApplicationReplyDataSize; // Size (in bytes) of pvApplicationReplyData

    // Fields added for DirectX 9
    public uint dpnidLocal; // DPNID of local player
}

// 
// Create group structure for message handler
// (DPN_MSGID_CREATE_GROUP)
// 
public partial class _DPNMSG_CREATE_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of new group
    public uint dpnidOwner; // Owner of newgroup
    public object pvGroupContext; // Group context value

    // Fields added for DirectX 9
    public object pvOwnerContext; // Owner context value
}

// 
// Create player structure for message handler
// (DPN_MSGID_CREATE_PLAYER)
// 
public partial class _DPNMSG_CREATE_PLAYER
{
    public uint dwSize; // Size of this structure
    public uint dpnidPlayer; // DPNID of new player
    public object pvPlayerContext; // Player context value
}

// 
// Destroy group structure for message handler
// (DPN_MSGID_DESTROY_GROUP)
// 
public partial class _DPNMSG_DESTROY_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of destroyed group
    public object pvGroupContext; // Group context value
    public uint dwReason; // Information only
}

// 
// Destroy player structure for message handler
// (DPN_MSGID_DESTROY_PLAYER)
// 
public partial class _DPNMSG_DESTROY_PLAYER
{
    public uint dwSize; // Size of this structure
    public uint dpnidPlayer; // DPNID of leaving player
    public object pvPlayerContext; // Player context value
    public uint dwReason; // Information only
}

// 
// Enumeration request received structure for message handler
// (DPN_MSGID_ENUM_HOSTS_QUERY)
// 
public partial class _DPNMSG_ENUM_HOSTS_QUERY
{
    public uint dwSize; // Size of this structure.
    public IDirectPlay8Address pAddressSender; // Address of client who sent the request
    public IDirectPlay8Address pAddressDevice; // Address of device request was received on
    public object pvReceivedData; // Request data (set on client)
    public uint dwReceivedDataSize; // Request data size (set on client)
    public uint dwMaxResponseDataSize; // Max allowable size of enum response
    public object pvResponseData; // Optional query repsonse (user set)
    public uint dwResponseDataSize; // Optional query response size (user set)
    public object pvResponseContext; // Optional query response context (user set)
}

// 
// Enumeration response received structure for message handler
// (DPN_MSGID_ENUM_HOSTS_RESPONSE)
// 
public partial class _DPNMSG_ENUM_HOSTS_RESPONSE
{
    public uint dwSize; // Size of this structure
    public IDirectPlay8Address pAddressSender; // Address of host who responded
    public IDirectPlay8Address pAddressDevice; // Device response was received on
    public readonly _DPN_APPLICATION_DESC pApplicationDescription; // Application description for the session
    public object pvResponseData; // Optional response data (set on host)
    public uint dwResponseDataSize; // Optional response data size (set on host)
    public object pvUserContext; // Context value supplied for enumeration
    public uint dwRoundTripLatencyMS; // Round trip latency in MS
}

// 
// Group info structure for message handler
// (DPN_MSGID_GROUP_INFO)
// 
public partial class _DPNMSG_GROUP_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of group
    public object pvGroupContext; // Group context value
}

// 
// Migrate host structure for message handler
// (DPN_MSGID_HOST_MIGRATE)
// 
public partial class _DPNMSG_HOST_MIGRATE
{
    public uint dwSize; // Size of this structure
    public uint dpnidNewHost; // DPNID of new Host player
    public object pvPlayerContext; // Player context value
}

// 
// Indicate connect structure for message handler
// (DPN_MSGID_INDICATE_CONNECT)
// 
public partial class _DPNMSG_INDICATE_CONNECT
{
    public uint dwSize; // Size of this structure
    public object pvUserConnectData; // Connecting player data
    public uint dwUserConnectDataSize; // Size (in bytes) of pvUserConnectData
    public object pvReplyData; // Connection reply data
    public uint dwReplyDataSize; // Size (in bytes) of pvReplyData
    public object pvReplyContext; // Buffer context for pvReplyData
    public object pvPlayerContext; // Player context preset
    public IDirectPlay8Address pAddressPlayer; // Address of connecting player
    public IDirectPlay8Address pAddressDevice; // Address of device receiving connect attempt
}

// 
// Indicated connect aborted structure for message handler
// (DPN_MSGID_INDICATED_CONNECT_ABORTED)
// 
public partial class _DPNMSG_INDICATED_CONNECT_ABORTED
{
    public uint dwSize; // Size of this structure
    public object pvPlayerContext; // Player context preset from DPNMSG_INDICATE_CONNECT
}

// 
// Peer info structure for message handler
// (DPN_MSGID_PEER_INFO)
// 
public partial class _DPNMSG_PEER_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidPeer; // DPNID of peer
    public object pvPlayerContext; // Player context value
}

// 
// Receive structure for message handler
// (DPN_MSGID_RECEIVE)
// 
public partial class _DPNMSG_RECEIVE
{
    public uint dwSize; // Size of this structure
    public uint dpnidSender; // DPNID of sending player
    public object pvPlayerContext; // Player context value of sending player
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * pReceiveData;
    public byte pReceiveData; // Received data
    public uint dwReceiveDataSize; // Size (in bytes) of pReceiveData
    public uint hBufferHandle; // Buffer handle for pReceiveData

    // Fields added for DirectX 9
    public uint dwReceiveFlags; // Flags describing how message was received
}

// 
// Remove player from group structure for message handler
// (DPN_MSGID_REMOVE_PLAYER_FROM_GROUP)
// 
public partial class _DPNMSG_REMOVE_PLAYER_FROM_GROUP
{
    public uint dwSize; // Size of this structure
    public uint dpnidGroup; // DPNID of group
    public object pvGroupContext; // Group context value
    public uint dpnidPlayer; // DPNID of deleted player
    public object pvPlayerContext; // Player context value
}

// 
// Returned buffer structure for message handler
// (DPN_MSGID_RETURN_BUFFER)
// 
public partial class _DPNMSG_RETURN_BUFFER
{
    public uint dwSize; // Size of this structure
    public int hResultCode; // Return value of operation
    public object pvBuffer; // Buffer being returned
    public object pvUserContext; // Context associated with buffer
}

// 
// Send complete structure for message handler
// (DPN_MSGID_SEND_COMPLETE)
// 
public partial class _DPNMSG_SEND_COMPLETE
{
    public uint dwSize; // Size of this structure
    public uint hAsyncOp; // DirectPlay8 Async operation handle
    public object pvUserContext; // User context supplied at Send/SendTo
    public int hResultCode; // HRESULT of send
    public uint dwSendTime; // Send time in ms

    // Fields added for DirectX 9
    public uint dwFirstFrameRTT; // RTT of the first frame in the message
    public uint dwFirstFrameRetryCount; // Retry count of the first frame
    public uint dwSendCompleteFlags; // Flags describing how message was sent
    public _BUFFERDESC pBuffers; // Pointer to array of buffers sent, if DirectPlay did not make a copy
    public uint dwNumBuffers; // Number of buffers in previous array
}

// 
// Server info structure for message handler
// (DPN_MSGID_SERVER_INFO)
// 
public partial class _DPNMSG_SERVER_INFO
{
    public uint dwSize; // Size of this structure
    public uint dpnidServer; // DPNID of server
    public object pvPlayerContext; // Player context value
}

// 
// Terminated session structure for message handler
// (DPN_MSGID_TERMINATE_SESSION)
// 
public partial class _DPNMSG_TERMINATE_SESSION
{
    public uint dwSize; // Size of this structure
    public int hResultCode; // Reason
    public object pvTerminateData; // Data passed from Host/Server
    public uint dwTerminateDataSize; // Size (in bytes) of pvTerminateData
}


// 
// Message structures added for DirectX 9
// 

// 
// Create thread info structure for message handler
// (DPN_MSGID_CREATE_THREAD)
// 
public partial class _DPNMSG_CREATE_THREAD
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags describing this thread
    public uint dwProcessorNum; // Index of processor to which thread is bound
    public object pvUserContext; // Thread context value
}

// 
// Destroy thread info structure for message handler
// (DPN_MSGID_DESTROY_THREAD)
// 
public partial class _DPNMSG_DESTROY_THREAD
{
    public uint dwSize; // Size of this structure
    public uint dwProcessorNum; // Index of processor to which thread was bound
    public object pvUserContext; // Thread context value
}


// 
// Query-to-resolve-NAT-address structure for message handler
// (DPN_MSGID_NAT_RESOLVER_QUERY)
// 
public partial class _DPNMSG_NAT_RESOLVER_QUERY
{
    public uint dwSize; // Size of this structure.
    public IDirectPlay8Address pAddressSender; // Address of client that sent the query
    public IDirectPlay8Address pAddressDevice; // Address of device on which query was received
    public string pwszUserString; // User specified string, or NULL if none
}