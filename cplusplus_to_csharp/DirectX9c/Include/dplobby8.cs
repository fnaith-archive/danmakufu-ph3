/*==========================================================================
 *
 *  Copyright (C) 2000 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       DPLobby.h
 *  Content:    DirectPlay8 Lobby Include File
 *
 ***************************************************************************/


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h>

#if __cplusplus
#endif

/****************************************************************************
 *
 * DirectPlay8Lobby CLSIDs
 *
 ****************************************************************************/

// {667955AD-6B3B-43ca-B949-BC69B5BAFF7F}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8LobbiedApplication, 0x667955ad, 0x6b3b, 0x43ca, 0xb9, 0x49, 0xbc, 0x69, 0xb5, 0xba, 0xff, 0x7f);

// {3B2B6775-70B6-45af-8DEA-A209C69559F3}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay8LobbyClient, 0x3b2b6775, 0x70b6, 0x45af, 0x8d, 0xea, 0xa2, 0x9, 0xc6, 0x95, 0x59, 0xf3);

/****************************************************************************
 *
 * DirectPlay8Lobby Interface IIDs
 *
 ****************************************************************************/

// {819074A3-016C-11d3-AE14-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8LobbiedApplication, 0x819074a3, 0x16c, 0x11d3, 0xae, 0x14, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);

// {819074A2-016C-11d3-AE14-006097B01411}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay8LobbyClient, 0x819074a2, 0x16c, 0x11d3, 0xae, 0x14, 0x0, 0x60, 0x97, 0xb0, 0x14, 0x11);

/****************************************************************************
 *
 * DirectPlay8Lobby Interface Pointer 
 *
 ****************************************************************************/


/****************************************************************************
 *
 * DirectPlay8 Lobby Message IDs
 *
 ****************************************************************************/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPL_MSGID_RECEIVE (0x0001 | DPL_MSGID_LOBBY)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPL_MSGID_CONNECT (0x0002 | DPL_MSGID_LOBBY)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPL_MSGID_DISCONNECT (0x0003 | DPL_MSGID_LOBBY)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPL_MSGID_SESSION_STATUS (0x0004 | DPL_MSGID_LOBBY)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPL_MSGID_CONNECTION_SETTINGS (0x0005 | DPL_MSGID_LOBBY)

/****************************************************************************
 *
 * DirectPlay8Lobby Constants
 *
 ****************************************************************************/

// 
// Specifies that operation should be performed on all open connections
// 

// 
// The associated game session has suceeded in connecting / hosting
// 

// The associated game session failed connecting / hosting
// 

// 
// The associated game session has disconnected
// 

// 
// The associated game session has terminated 
// 

// 
// The associated game session's host has migrated 
// 

// 
// The associated game session's host has migrated to the local client
// 


/****************************************************************************
 *
 * DirectPlay8 Lobby Flags
 *
 ****************************************************************************/

// 
// Do not automatically make the lobby app unavailable when a connection is established
// 

// 
// Launch a new instance of the application to connect to
// 

// 
// Launch a new instance of the application if one is not waiting
// 

// 
// When starting the associated game session, start it as a host
// 

// 
// Disable parameter validation
// 

/****************************************************************************
 *
 * DirectPlay8Lobby Structures (Non-Message)
 *
 ****************************************************************************/

// 
// Information on a registered game
// 
public class _DPL_APPLICATION_INFO
{
    public GUID guidApplication = new GUID(); // GUID of the application
    public string pwszApplicationName; // Name of the application
    public uint dwNumRunning; // # of instances of this application running
    public uint dwNumWaiting; // # of instances of this application waiting
    public uint dwFlags; // Flags
}

// 
// Settings to be used for connecting / hosting a game session
// 
public class _DPL_CONNECTION_SETTINGS
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Connection settings flags (DPLCONNECTSETTINGS_...)
    public DPN_APPLICATION_DESC dpnAppDesc = new DPN_APPLICATION_DESC(); // Application desc for the associated DirectPlay session
    public IDirectPlay8Address pdp8HostAddress; // Address of host to connect to
    public IDirectPlay8Address[] ppdp8DeviceAddresses; // Address of device to connect from / host on
    public uint cNumDeviceAddresses; // # of addresses specified in ppdp8DeviceAddresses
    public string pwszPlayerName; // Name to give the player
}

// 
// Information for performing a lobby connect
// (ConnectApplication)
// 
public class _DPL_CONNECT_INFO
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags (DPLCONNECT_...)
    public GUID guidApplication = new GUID(); // GUID of application to launch
    public _DPL_CONNECTION_SETTINGS pdplConnectionSettings;
                                                    // Settings application should use
    public object pvLobbyConnectData; // User defined data block
    public uint dwLobbyConnectDataSize;
                                                    // Size of user defined data block
}

// 
// Information for registering an application
// (RegisterApplication)
// 
public class _DPL_PROGRAM_DESC
{
    public uint dwSize;
    public uint dwFlags;
    public GUID guidApplication = new GUID(); // Application GUID
    public string pwszApplicationName; // Unicode application name
    public string pwszCommandLine; // Unicode command line arguments
    public string pwszCurrentDirectory; // Unicode current directory
    public string pwszDescription; // Unicode application description
    public string pwszExecutableFilename; // Unicode filename of application executable
    public string pwszExecutablePath; // Unicode path of application executable
    public string pwszLauncherFilename; // Unicode filename of launcher executable
    public string pwszLauncherPath; // Unicode path of launcher executable
}

/****************************************************************************
 *
 * DirectPlay8 Lobby Message Structures
 *
 ****************************************************************************/

// 
// A connection was established 
// (DPL_MSGID_CONNECT)
// 
public class _DPL_MESSAGE_CONNECT
{
    public uint dwSize; // Size of this structure
    public DPNHANDLE hConnectId = new DPNHANDLE(); // Handle of new connection
    public _DPL_CONNECTION_SETTINGS pdplConnectionSettings; // Connection settings for this connection
    public object pvLobbyConnectData; // User defined lobby data block
    public uint dwLobbyConnectDataSize; // Size of user defined lobby data block
    public object pvConnectionContext; // Context value for this connection (user set)
}

// 
// Connection settings have been updated
// (DPL_MSGID_CONNECTION_SETTINGS)
// 
public class _DPL_MESSAGE_CONNECTION_SETTINGS
{
    public uint dwSize; // Size of this structure
    public DPNHANDLE hSender = new DPNHANDLE(); // Handle of the connection for these settings
    public _DPL_CONNECTION_SETTINGS pdplConnectionSettings; // Connection settings
    public object pvConnectionContext; // Context value for this connection
}

// 
// A connection has been disconnected
// (DPL_MSGID_DISCONNECT)
// 
public class _DPL_MESSAGE_DISCONNECT
{
    public uint dwSize; // Size of this structure
    public DPNHANDLE hDisconnectId = new DPNHANDLE(); // Handle of the connection that was terminated
    public int hrReason; // Reason the connection was broken
    public object pvConnectionContext; // Context value for this connection
}

// 
// Data was received through a connection
// (DPL_MSGID_RECEIVE)
// 
public class _DPL_MESSAGE_RECEIVE
{
    public uint dwSize; // Size of this structure
    public DPNHANDLE hSender = new DPNHANDLE(); // Handle of the connection that is from
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *pBuffer;
    public byte pBuffer; // Contents of the message
    public uint dwBufferSize; // Size of the message context
    public object pvConnectionContext; // Context value for this connection
}

// 
// Current status of the associated connection
// (DPL_MSGID_SESSION_STATUS)
// 
public class _DPL_MESSAGE_SESSION_STATUS
{
    public uint dwSize; // Size of this structure
    public DPNHANDLE hSender = new DPNHANDLE(); // Handle of the connection that this is from
    public uint dwStatus; // Status (DPLSESSION_...)
    public object pvConnectionContext; // Context value for this connection
}