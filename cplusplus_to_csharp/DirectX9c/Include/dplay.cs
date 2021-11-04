/*==========================================================================;
 *
 *  Copyright (C) 1994-1997 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dplay.h
 *  Content:    DirectPlay include file
 *
 ***************************************************************************/


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h> // for DECLARE_INTERFACE and HRESULT

/* avoid warnings in MSVC at Level4 */
// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if _MSC_VER >= 1200
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(push)
#endif
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4201)


/*
 * Some types
 */

#if ! _WIN64
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DWORD_PTR DWORD
#define DWORD_PTR
#endif


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define VOL volatile


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DPHRESULT( code ) MAKE_HRESULT( 1, _FACDP, code )

#if __cplusplus
#endif

/*
 * GUIDS used by DirectPlay objects
 */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay2, 0x2b74f7c0, 0x9154, 0x11cf, 0xa9, 0xcd, 0x0, 0xaa, 0x0, 0x68, 0x86, 0xe3);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay2A,0x9d460580, 0xa822, 0x11cf, 0x96, 0xc, 0x0, 0x80, 0xc7, 0x53, 0x4e, 0x82);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay3, 0x133efe40, 0x32dc, 0x11d0, 0x9c, 0xfb, 0x0, 0xa0, 0xc9, 0xa, 0x43, 0xcb);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay3A,0x133efe41, 0x32dc, 0x11d0, 0x9c, 0xfb, 0x0, 0xa0, 0xc9, 0xa, 0x43, 0xcb);

// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay4, 0xab1c530, 0x4745, 0x11d1, 0xa7, 0xa1, 0x0, 0x0, 0xf8, 0x3, 0xab, 0xfc);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlay4A,0xab1c531, 0x4745, 0x11d1, 0xa7, 0xa1, 0x0, 0x0, 0xf8, 0x3, 0xab, 0xfc);

// {D1EB6D20-8923-11d0-9D97-00A0C90A43CB}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlay,0xd1eb6d20, 0x8923, 0x11d0, 0x9d, 0x97, 0x0, 0xa0, 0xc9, 0xa, 0x43, 0xcb);

/*
 * GUIDS used by Service Providers shipped with DirectPlay
 * Use these to identify Service Provider returned by EnumConnections
 */

// GUID for IPX service provider
// {685BC400-9D2C-11cf-A9CD-00AA006886E3}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPSPGUID_IPX, 0x685bc400, 0x9d2c, 0x11cf, 0xa9, 0xcd, 0x0, 0xaa, 0x0, 0x68, 0x86, 0xe3);

// GUID for TCP/IP service provider
// 36E95EE0-8577-11cf-960C-0080C7534E82
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPSPGUID_TCPIP, 0x36E95EE0, 0x8577, 0x11cf, 0x96, 0xc, 0x0, 0x80, 0xc7, 0x53, 0x4e, 0x82);

// GUID for Serial service provider
// {0F1D6860-88D9-11cf-9C4E-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPSPGUID_SERIAL, 0xf1d6860, 0x88d9, 0x11cf, 0x9c, 0x4e, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

// GUID for Modem service provider
// {44EAA760-CB68-11cf-9C4E-00A0C905425E}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(DPSPGUID_MODEM, 0x44eaa760, 0xcb68, 0x11cf, 0x9c, 0x4e, 0x0, 0xa0, 0xc9, 0x5, 0x42, 0x5e);

/****************************************************************************
 *
 * DirectPlay Structures
 *
 * Various structures used to invoke DirectPlay.
 *
 ****************************************************************************/

#if ! IDIRECTPLAY2_OR_GREATER
#else
#endif




/*
 * DPID
 * DirectPlay player and group ID
 */

/*
 * DPID that system messages come from
 */

/*
 * DPID representing all players in the session
 */

/*
 * DPID representing the server player
 */


/*
 * DPID representing the maxiumum ID in the range of DPID's reserved for
 * use by DirectPlay.
 */

/*
 * The player ID is unknown (used with e.g. DPSESSION_NOMESSAGEID)
 */

/*
 * DPCAPS
 * Used to obtain the capabilities of a DirectPlay object
 */
public class DPCAPS
{
    public uint dwSize; // Size of structure, in bytes
    public uint dwFlags; // DPCAPS_xxx flags
    public uint dwMaxBufferSize; // Maximum message size, in bytes,  for this service provider
    public uint dwMaxQueueSize; // Obsolete.
    public uint dwMaxPlayers; // Maximum players/groups (local + remote)
    public uint dwHundredBaud; // Bandwidth in 100 bits per second units;
                                // i.e. 24 is 2400, 96 is 9600, etc.
    public uint dwLatency; // Estimated latency; 0 = unknown
    public uint dwMaxLocalPlayers; // Maximum # of locally created players allowed
    public uint dwHeaderLength; // Maximum header length, in bytes, on messages
                                // added by the service provider
    public uint dwTimeout; // Service provider's suggested timeout value
                                // This is how long DirectPlay will wait for 
                                // responses to system messages
}

/*
 * This DirectPlay object is the session host.  If the host exits the
 * session, another application will become the host and receive a
 * DPSYS_HOST system message.
 */

/*
 * The service provider bound to this DirectPlay object can optimize
 * group messaging.
 */

/*
 * The service provider bound to this DirectPlay object can optimize
 * keep alives (see DPSESSION_KEEPALIVE)
 */

/*
 * The service provider bound to this DirectPlay object can optimize
 * guaranteed message delivery.
 */

/*
 * This DirectPlay object supports guaranteed message delivery.
 */

/*
 * This DirectPlay object supports digital signing of messages.
 */

/*
 * This DirectPlay object supports encryption of messages.
 */

/*
 * This DirectPlay player was created on this machine
 */

/*
 * Current Open settings supports all forms of Cancel
 */

/*
 * Current Open settings supports CancelAll, but not Cancel
 */

/*
 *  Current Open settings supports Send Timeouts for sends
 */

/*
 *  Current Open settings supports send priority
 */

/*
 *  Current Open settings supports DPSEND_ASYNC flag
 */


/*
 * DPSESSIONDESC2
 * Used to describe the properties of a DirectPlay
 * session instance
 */
public class DPSESSIONDESC2
{
    public uint dwSize; // Size of structure
    public uint dwFlags; // DPSESSION_xxx flags
    public GUID guidInstance = new GUID(); // ID for the session instance
    public GUID guidApplication = new GUID(); // GUID of the DirectPlay application.
                                // GUID_NULL for all applications.
    public uint dwMaxPlayers; // Maximum # players allowed in session
    public uint dwCurrentPlayers; // Current # players in session (read only)
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // Name of the session
//        char* lpszSessionName; // Unicode
//        char* lpszSessionNameA; // ANSI
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // Password of the session (optional)
//        char* lpszPassword; // Unicode
//        char* lpszPasswordA; // ANSI
//    };
    public uint dwReserved1; // Reserved for future MS use.
    public uint dwReserved2;
    public uint dwUser1; // For use by the application
    public uint dwUser2;
    public uint dwUser3;
    public uint dwUser4;
}


/*
 * LPCDPSESSIONDESC2
 * A constant pointer to DPSESSIONDESC2
 */

/*
 * Applications cannot create new players in this session.
 */

/*
 * If the DirectPlay object that created the session, the host,
 * quits, then the host will attempt to migrate to another
 * DirectPlay object so that new players can continue to be created
 * and new applications can join the session.
 */

/*
 * This flag tells DirectPlay not to set the idPlayerTo and idPlayerFrom 
 * fields in player messages.  This cuts two DWORD's off the message 
 * overhead.
 */


/*
 * This flag tells DirectPlay to not allow any new applications to
 * join the session.  Applications already in the session can still
 * create new players.
 */

/*
 * This flag tells DirectPlay to detect when remote players 
 * exit abnormally (e.g. their computer or modem gets unplugged)
 */

/*
 * This flag tells DirectPlay not to send a message to all players
 * when a players remote data changes
 */

/*
 * This flag indicates that the session belongs to a secure server
 * and needs user authentication
 */

/*
 * This flag indicates that the session is private and requirs a password
 * for EnumSessions as well as Open.
 */

/*
 * This flag indicates that the session requires a password for joining.
 */

/*
 * This flag tells DirectPlay to route all messages through the server
 */

/*
 * This flag tells DirectPlay to only download information about the
 * DPPLAYER_SERVERPLAYER.  
 */

/*
 * This flag tells DirectPlay to use the protocol built into dplay
 * for reliability and statistics all the time.  When this bit is
 * set, only other sessions with this bit set can join or be joined.
 */

/*
 * This flag tells DirectPlay that preserving order of received
 * packets is not important, when using reliable delivery.  This
 * will allow messages to be indicated out of order if preceding
 * messages have not yet arrived.  Otherwise DPLAY will wait for
 * earlier messages before delivering later reliable messages.
 */


/*
 * This flag tells DirectPlay to optimize communication for latency
 */

/*
 * This flag allows lobby launched games that aren't voice enabled
 * to get voice capabilities.
 */

/*
 * This flag supresses transmission of session desc changes.
 * DPSESSION_NODATAMESSAGES was supposed to do that, but SetSessionDesc
 * was ignoring the flag and some apps depended on the broken behavior, this
 * flag allows applications to get the right behaviour without breaking apps depending
 * on old broken behavior.
 */

/*
 * DPNAME
 * Used to hold the name of a DirectPlay entity
 * like a player or a group
 */
public class DPNAME
{
    public uint dwSize; // Size of structure
    public uint dwFlags; // Not used. Must be zero.
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // The short or friendly name
//        char* lpszShortName; // Unicode
//        char* lpszShortNameA; // ANSI
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // The long or formal name
//        char* lpszLongName; // Unicode
//        char* lpszLongNameA; // ANSI
//    };

}

/*
 * LPCDPNAME
 * A constant pointer to DPNAME
 */

/*
 * DPCREDENTIALS
 * Used to hold the user name and password of a DirectPlay user
 */
public class DPCREDENTIALS
{
    public uint dwSize; // Size of structure
    public uint dwFlags; // Not used. Must be zero.
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // User name of the account
//        char* lpszUsername; // Unicode
//        char* lpszUsernameA; // ANSI
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // Password of the account
//        char* lpszPassword; // Unicode
//        char* lpszPasswordA; // ANSI
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // Domain name of the account
//        char* lpszDomain; // Unicode
//        char* lpszDomainA; // ANSI
//    };
}


/*
 * DPSECURITYDESC
 * Used to describe the security properties of a DirectPlay
 * session instance
 */
public class DPSECURITYDESC
{
    public uint dwSize; // Size of structure
    public uint dwFlags; // Not used. Must be zero.
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // SSPI provider name
//        char* lpszSSPIProvider; // Unicode
//        char* lpszSSPIProviderA; // ANSI
//    };
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // CAPI provider name
//        char* lpszCAPIProvider; // Unicode
//        char* lpszCAPIProviderA; // ANSI
//    };
    public uint dwCAPIProviderType; // Crypto Service Provider type
    public uint dwEncryptionAlgorithm; // Encryption Algorithm type
}


/*
 * DPACCOUNTDESC
 * Used to describe a user membership account
 */
public class DPACCOUNTDESC
{
    public uint dwSize; // Size of structure
    public uint dwFlags; // Not used. Must be zero.
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // Account identifier
//        char* lpszAccountID; // Unicode
//        char* lpszAccountIDA; // ANSI
//    };
}


/*
 * LPCGUID
 * A constant pointer to a guid
 */

/*
 * DPLCONNECTION
 * Used to hold all in the informaion needed to connect
 * an application to a session or create a session
 */
public class DPLCONNECTION
{
    public uint dwSize; // Size of this structure
    public uint dwFlags; // Flags specific to this structure
    public DPSESSIONDESC2 lpSessionDesc; // Pointer to session desc to use on connect
    public DPNAME lpPlayerName; // Pointer to Player name structure
    public GUID guidSP = new GUID(); // GUID of the DPlay SP to use
    public object lpAddress; // Address for service provider
    public uint dwAddressSize; // Size of address data
}

/*
 * LPCDPLCONNECTION
 * A constant pointer to DPLCONNECTION
 */

/*
 * DPCHAT
 * Used to hold the a DirectPlay chat message
 */
public class DPCHAT
{
    public uint dwSize;
    public uint dwFlags;
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//    union
//    { // Message string
//        char* lpszMessage; // Unicode
//        char* lpszMessageA; // ANSI
//    };
}

/*
 * SGBUFFER
 * Scatter Gather Buffer used for SendEx
 */
public class SGBUFFER
{
    public uint len; // length of buffer data
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * pData;
    public byte pData; // pointer to buffer data
}


/****************************************************************************
 *
 * Prototypes for DirectPlay callback functions
 *
 ****************************************************************************/

/*
 * Callback for IDirectPlay2::EnumSessions
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDPENUMSESSIONSCALLBACK2)(const DPSESSIONDESC2 FAR * lpThisSD, uint * lpdwTimeOut, uint dwFlags, object* lpContext);
public delegate bool LPDPENUMSESSIONSCALLBACK2(DPSESSIONDESC2 lpThisSD, ref uint lpdwTimeOut, uint dwFlags, object lpContext);

/*
 * This flag is set on the EnumSessions callback dwFlags parameter when
 * the time out has occurred. There will be no session data for this 
 * callback. If *lpdwTimeOut is set to a non-zero value and the 
 * EnumSessionsCallback function returns TRUE then EnumSessions will 
 * continue waiting until the next timeout occurs. Timeouts are in 
 * milliseconds.
 */


/*
 * Callback for IDirectPlay2::EnumPlayers
 *              IDirectPlay2::EnumGroups
 *              IDirectPlay2::EnumGroupPlayers
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL *LPDPENUMPLAYERSCALLBACK2)(uint dpId, uint dwPlayerType, const DPNAME FAR * lpName, uint dwFlags, object* lpContext);
public delegate bool LPDPENUMPLAYERSCALLBACK2(uint dpId, uint dwPlayerType, DPNAME lpName, uint dwFlags, object lpContext);


/*
 * Unicode callback for DirectPlayEnumerate
 * This callback prototype will be used if compiling
 * for Unicode strings
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDPENUMDPCALLBACK)(LPGUID lpguidSP, char* lpSPName, uint dwMajorVersion, uint dwMinorVersion, object* lpContext);
public delegate bool LPDPENUMDPCALLBACK(LPGUID lpguidSP, ref string lpSPName, uint dwMajorVersion, uint dwMinorVersion, object lpContext);

/*
 * ANSI callback for DirectPlayEnumerate
 * This callback prototype will be used if compiling
 * for ANSI strings
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDPENUMDPCALLBACKA)(LPGUID lpguidSP, char* lpSPName, uint dwMajorVersion, uint dwMinorVersion, object* lpContext);
public delegate bool LPDPENUMDPCALLBACKA(LPGUID lpguidSP, ref string lpSPName, uint dwMajorVersion, uint dwMinorVersion, object lpContext);

/*
 * Callback for IDirectPlay3(A)::EnumConnections
 */
// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(FAR PASCAL * LPDPENUMCONNECTIONSCALLBACK)(const GUID FAR * lpguidSP, object* lpConnection, uint dwConnectionSize, const DPNAME FAR * lpName, uint dwFlags, object* lpContext);
public delegate bool LPDPENUMCONNECTIONSCALLBACK(GUID lpguidSP, object lpConnection, uint dwConnectionSize, DPNAME lpName, uint dwFlags, object lpContext);


/*
 * API's
 */

#if UNICODE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectPlayEnumerate DirectPlayEnumerateW
#define DirectPlayEnumerate
#else
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DirectPlayEnumerate DirectPlayEnumerateA
#define DirectPlayEnumerate
#endif // UNICODE

/****************************************************************************
 *
 * EnumConnections API flags
 *
 ****************************************************************************/

/*
 * Enumerate Service Providers
 */

/*
 * Enumerate Lobby Providers
 */


/****************************************************************************
 *
 * EnumPlayers API flags
 *
 ****************************************************************************/

/*
 * Enumerate all players in the current session
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_ALL DPENUMPLAYERS_ALL


/*
 * Enumerate only local (created by this application) players
 * or groups
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_LOCAL DPENUMPLAYERS_LOCAL

/*
 * Enumerate only remote (non-local) players
 * or groups
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_REMOTE DPENUMPLAYERS_REMOTE

/*
 * Enumerate groups along with the players
 */

/*
 * Enumerate players or groups in another session 
 * (must supply lpguidInstance)
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPENUMGROUPS_SESSION DPENUMPLAYERS_SESSION

/*
 * Enumerate server players
 */

/*
 * Enumerate spectator players
 */

/*
 * Enumerate shortcut groups
 */

/*
 * Enumerate staging area groups
 */

/*
 * Enumerate hidden groups
 */

/*
 * Enumerate the group's owner
 */


/****************************************************************************
 *
 * CreatePlayer API flags
 *
 ****************************************************************************/

/*
 * This flag indicates that this player should be designated
 * the server player. The app should specify this at CreatePlayer.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_SERVERPLAYER DPENUMPLAYERS_SERVERPLAYER

/*
 * This flag indicates that this player should be designated
 * a spectator. The app should specify this at CreatePlayer.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_SPECTATOR DPENUMPLAYERS_SPECTATOR

/*
 * This flag indicates that this player was created locally.
 * (returned from GetPlayerFlags)
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_LOCAL DPENUMPLAYERS_LOCAL

/*
 * This flag indicates that this player is the group's owner
 * (Only returned in EnumGroupPlayers)
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPPLAYER_OWNER DPENUMPLAYERS_OWNER

/****************************************************************************
 *
 * CreateGroup API flags
 *
 ****************************************************************************/


/*
 * This flag indicates that the StartSession can be called on the group.
 * The app should specify this at CreateGroup, or CreateGroupInGroup.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPGROUP_STAGINGAREA DPENUMGROUPS_STAGINGAREA

/*
 * This flag indicates that this group was created locally.
 * (returned from GetGroupFlags)
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPGROUP_LOCAL DPENUMGROUPS_LOCAL

/*
 * This flag indicates that this group was created hidden.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPGROUP_HIDDEN DPENUMGROUPS_HIDDEN


/****************************************************************************
 *
 * EnumSessions API flags
 *
 ****************************************************************************/

/*
 * Enumerate sessions which can be joined
 */

/*
 * Enumerate all sessions even if they can't be joined.
 */


/*
 * Start an asynchronous enum sessions
 */

/*
 * Stop an asynchronous enum sessions
 */

/*
 * Enumerate sessions even if they require a password
 */

/*
 * Return status about progress of enumeration instead of
 * showing any status dialogs.
 */

/****************************************************************************
 *
 * GetCaps and GetPlayerCaps API flags
 *
 ****************************************************************************/

/*
 * The latency returned should be for guaranteed message sending.
 * Default is non-guaranteed messaging.
 */


/****************************************************************************
 *
 * GetGroupData, GetPlayerData API flags
 * Remote and local Group/Player data is maintained separately. 
 * Default is DPGET_REMOTE.
 *
 ****************************************************************************/

/*
 * Get the remote data (set by any DirectPlay object in
 * the session using DPSET_REMOTE)
 */

/*
 * Get the local data (set by this DirectPlay object 
 * using DPSET_LOCAL)
 */


/****************************************************************************
 *
 * Open API flags
 *
 ****************************************************************************/

/*
 * Join the session that is described by the DPSESSIONDESC2 structure
 */

/*
 * Create a new session as described by the DPSESSIONDESC2 structure
 */

/*
 * Return status about progress of open instead of showing
 * any status dialogs.
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPOPEN_RETURNSTATUS DPENUMSESSIONS_RETURNSTATUS


/****************************************************************************
 *
 * DPLCONNECTION flags
 *
 ****************************************************************************/

/*
 * This application should create a new session as
 * described by the DPSESIONDESC structure
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPLCONNECTION_CREATESESSION DPOPEN_CREATE

/*
 * This application should join the session described by 
 * the DPSESIONDESC structure with the lpAddress data
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPLCONNECTION_JOINSESSION DPOPEN_JOIN

/****************************************************************************
 *
 * Receive API flags
 * Default is DPRECEIVE_ALL
 *
 ****************************************************************************/

/*
 * Get the first message in the queue
 */

/*
 * Get the first message in the queue directed to a specific player 
 */

/*
 * Get the first message in the queue from a specific player
 */

/*
 * Get the message but don't remove it from the queue
 */


/****************************************************************************
 *
 * Send API flags
 *
 ****************************************************************************/

/*
 * Send the message using a guaranteed send method.
 * Default is non-guaranteed.
 */


/*
 * This flag is obsolete. It is ignored by DirectPlay
 */

/*
 * This flag is obsolete. It is ignored by DirectPlay
 */

/*
 * This flag is obsolete. It is ignored by DirectPlay
 */

/*
 * Send the message digitally signed to ensure authenticity.
 */

/*
 * Send the message with encryption to ensure privacy.
 */

/*
 * The message is a lobby system message
 */


/*
 * Send message asynchronously, must check caps
 * before using this flag.  It is always provided
 * if the protocol flag is set.
 */

/*
 * When an message is completed, don't tell me. 
 * by default the application is notified with a system message.
 */


/*
 * Maximum priority for sends available to applications
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPSEND_MAX_PRIORITY DPSEND_MAX_PRI


/****************************************************************************
 *
 * SetGroupData, SetGroupName, SetPlayerData, SetPlayerName,
 * SetSessionDesc API flags.
 * Default is DPSET_REMOTE.
 *
 ****************************************************************************/

/* 
 * Propagate the data to all players in the session
 */

/*
 * Do not propagate the data to other players
 */

/*
 * Used with DPSET_REMOTE, use guaranteed message send to
 * propagate the data
 */

/****************************************************************************
 *
 * GetMessageQueue API flags.
 * Default is DPMESSAGEQUEUE_SEND
 *
 ****************************************************************************/

/* 
 * Get Send Queue - requires Service Provider Support
 */

/*
 * Get Receive Queue
 */


/****************************************************************************
 *
 * Connect API flags
 *
 ****************************************************************************/


/*
 * Start an asynchronous connect which returns status codes
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPCONNECT_RETURNSTATUS (DPENUMSESSIONS_RETURNSTATUS)


/****************************************************************************
 *
 * DirectPlay system messages and message data structures
 *
 * All system message come 'From' player DPID_SYSMSG.  To determine what type 
 * of message it is, cast the lpData from Receive to DPMSG_GENERIC and check
 * the dwType member against one of the following DPSYS_xxx constants. Once
 * a match is found, cast the lpData to the corresponding of the DPMSG_xxx
 * structures to access the data of the message.
 *
 ****************************************************************************/

/*
 * A new player or group has been created in the session
 * Use DPMSG_CREATEPLAYERORGROUP.  Check dwPlayerType to see if it
 * is a player or a group.
 */

/*
 * A player has been deleted from the session
 * Use DPMSG_DESTROYPLAYERORGROUP
 */

/*
 * A player has been added to a group
 * Use DPMSG_ADDPLAYERTOGROUP
 */

/*
 * A player has been removed from a group
 * Use DPMSG_DELETEPLAYERFROMGROUP
 */

/*
 * This DirectPlay object lost its connection with all the
 * other players in the session.
 * Use DPMSG_SESSIONLOST.
 */

/*
 * The current host has left the session.
 * This DirectPlay object is now the host.
 * Use DPMSG_HOST.
 */

/*
 * The remote data associated with a player or
 * group has changed. Check dwPlayerType to see
 * if it is a player or a group
 * Use DPMSG_SETPLAYERORGROUPDATA
 */

/*
 * The name of a player or group has changed.
 * Check dwPlayerType to see if it is a player
 * or a group.
 * Use DPMSG_SETPLAYERORGROUPNAME
 */

/*
 * The session description has changed.
 * Use DPMSG_SETSESSIONDESC
 */

/*
 * A group has been added to a group
 * Use DPMSG_ADDGROUPTOGROUP
 */

/*
 * A group has been removed from a group
 * Use DPMSG_DELETEGROUPFROMGROUP
 */

/*
 * A secure player-player message has arrived.
 * Use DPMSG_SECUREMESSAGE
 */

/*
 * Start a new session.
 * Use DPMSG_STARTSESSION
 */

/*
 * A chat message has arrived
 * Use DPMSG_CHAT
 */

/*
 * The owner of a group has changed
 * Use DPMSG_SETGROUPOWNER
 */

/*
 * An async send has finished, failed or been cancelled
 * Use DPMSG_SENDCOMPLETE
 */


/*
 * Used in the dwPlayerType field to indicate if it applies to a group
 * or a player
 */


/*
 * DPMSG_GENERIC
 * Generic message structure used to identify the message type.
 */
public class DPMSG_GENERIC
{
    public uint dwType; // Message type
}

/*
 * DPMSG_CREATEPLAYERORGROUP
 * System message generated when a new player or group
 * created in the session with information about it.
 */
public class DPMSG_CREATEPLAYERORGROUP
{
    public uint dwType; // Message type
    public uint dwPlayerType; // Is it a player or group
    public uint dpId; // ID of the player or group
    public uint dwCurrentPlayers; // current # players & groups in session
    public object lpData; // pointer to remote data
    public uint dwDataSize; // size of remote data
    public DPNAME dpnName = new DPNAME(); // structure with name info
    // the following fields are only available when using
    // the IDirectPlay3 interface or greater
    public uint dpIdParent; // id of parent group
    public uint dwFlags; // player or group flags
}

/*
 * DPMSG_DESTROYPLAYERORGROUP
 * System message generated when a player or group is being
 * destroyed in the session with information about it.
 */
public class DPMSG_DESTROYPLAYERORGROUP
{
    public uint dwType; // Message type
    public uint dwPlayerType; // Is it a player or group
    public uint dpId; // player ID being deleted
    public object lpLocalData; // copy of players local data
    public uint dwLocalDataSize; // sizeof local data
    public object lpRemoteData; // copy of players remote data
    public uint dwRemoteDataSize; // sizeof remote data
    // the following fields are only available when using
    // the IDirectPlay3 interface or greater
    public DPNAME dpnName = new DPNAME(); // structure with name info
    public uint dpIdParent; // id of parent group
    public uint dwFlags; // player or group flags
}

/*
 * DPMSG_ADDPLAYERTOGROUP
 * System message generated when a player is being added
 * to a group.
 */
public class DPMSG_ADDPLAYERTOGROUP
{
    public uint dwType; // Message type
    public uint dpIdGroup; // group ID being added to
    public uint dpIdPlayer; // player ID being added
}

/*
 * DPMSG_DELETEPLAYERFROMGROUP
 * System message generated when a player is being
 * removed from a group
 */

/*
 * DPMSG_ADDGROUPTOGROUP
 * System message generated when a group is being added
 * to a group.
 */
public class DPMSG_ADDGROUPTOGROUP
{
    public uint dwType; // Message type
    public uint dpIdParentGroup; // group ID being added to
    public uint dpIdGroup; // group ID being added
}

/*
 * DPMSG_DELETEGROUPFROMGROUP
 * System message generated when a GROUP is being
 * removed from a group
 */

/*
 * DPMSG_SETPLAYERORGROUPDATA
 * System message generated when remote data for a player or
 * group has changed.
 */
public class DPMSG_SETPLAYERORGROUPDATA
{
    public uint dwType; // Message type
    public uint dwPlayerType; // Is it a player or group
    public uint dpId; // ID of player or group
    public object lpData; // pointer to remote data
    public uint dwDataSize; // size of remote data
}

/*
 * DPMSG_SETPLAYERORGROUPNAME
 * System message generated when the name of a player or
 * group has changed.
 */
public class DPMSG_SETPLAYERORGROUPNAME
{
    public uint dwType; // Message type
    public uint dwPlayerType; // Is it a player or group
    public uint dpId; // ID of player or group
    public DPNAME dpnName = new DPNAME(); // structure with new name info
}

/*
 * DPMSG_SETSESSIONDESC
 * System message generated when session desc has changed
 */
public class DPMSG_SETSESSIONDESC
{
    public uint dwType; // Message type
    public DPSESSIONDESC2 dpDesc = new DPSESSIONDESC2(); // Session desc
}

/*
 * DPMSG_HOST
 * System message generated when the host has migrated to this
 * DirectPlay object.
 *
 */

/*
 * DPMSG_SESSIONLOST
 * System message generated when the connection to the session is lost.
 *
 */

/*
 * DPMSG_SECUREMESSAGE
 * System message generated when a player requests a secure send
 */
public class DPMSG_SECUREMESSAGE
{
    public uint dwType; // Message Type
    public uint dwFlags; // Signed/Encrypted
    public uint dpIdFrom; // ID of Sending Player
    public object lpData; // Player message
    public uint dwDataSize; // Size of player message
}

/*
 * DPMSG_STARTSESSION
 * System message containing all information required to 
 * start a new session
 */
public class DPMSG_STARTSESSION
{
    public uint dwType; // Message type
    public DPLCONNECTION lpConn; // DPLCONNECTION structure
}

/*
 * DPMSG_CHAT
 * System message containing a chat message
 */
public class DPMSG_CHAT
{
    public uint dwType; // Message type
    public uint dwFlags; // Message flags
    public uint idFromPlayer; // ID of the Sending Player
    public uint idToPlayer; // ID of the To Player
    public uint idToGroup; // ID of the To Group
    public DPCHAT lpChat; // Pointer to a structure containing the chat message
}

/*
 * DPMSG_SETGROUPOWNER
 * System message generated when the owner of a group has changed
 */
public class DPMSG_SETGROUPOWNER
{
    public uint dwType; // Message type
    public uint idGroup; // ID of the group
    public uint idNewOwner; // ID of the player that is the new owner
    public uint idOldOwner; // ID of the player that used to be the owner
}

/*
 * DPMSG_SENDCOMPLETE
 * System message generated when finished with an Async Send message
 *
 * NOTE SENDPARMS has an overlay for DPMSG_SENDCOMPLETE, don't
 *                change this message w/o changing SENDPARMS.
 */
public class DPMSG_SENDCOMPLETE
{
    public uint dwType;
    public uint idFrom;
    public uint idTo;
    public uint dwFlags;
    public uint dwPriority;
    public uint dwTimeout;
    public object lpvContext;
    public uint dwMsgID;
    public int hr;
    public uint dwSendTime;
}

/****************************************************************************
 *
 * DIRECTPLAY ERRORS
 *
 * Errors are represented by negative values and cannot be combined.
 *
 ****************************************************************************/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DP_OK S_OK
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ALREADYINITIALIZED MAKE_DPHRESULT( 5 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ACCESSDENIED MAKE_DPHRESULT( 10 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ACTIVEPLAYERS MAKE_DPHRESULT( 20 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_BUFFERTOOSMALL MAKE_DPHRESULT( 30 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTADDPLAYER MAKE_DPHRESULT( 40 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATEGROUP MAKE_DPHRESULT( 50 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATEPLAYER MAKE_DPHRESULT( 60 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATESESSION MAKE_DPHRESULT( 70 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CAPSNOTAVAILABLEYET MAKE_DPHRESULT( 80 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_EXCEPTION MAKE_DPHRESULT( 90 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_GENERIC E_FAIL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDFLAGS MAKE_DPHRESULT( 120 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDOBJECT MAKE_DPHRESULT( 130 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPARAM E_INVALIDARG
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPARAMS DPERR_INVALIDPARAM
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPLAYER MAKE_DPHRESULT( 150 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDGROUP MAKE_DPHRESULT( 155 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOCAPS MAKE_DPHRESULT( 160 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOCONNECTION MAKE_DPHRESULT( 170 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOMEMORY E_OUTOFMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_OUTOFMEMORY DPERR_NOMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOMESSAGES MAKE_DPHRESULT( 190 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NONAMESERVERFOUND MAKE_DPHRESULT( 200 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOPLAYERS MAKE_DPHRESULT( 210 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOSESSIONS MAKE_DPHRESULT( 220 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_PENDING E_PENDING
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SENDTOOBIG MAKE_DPHRESULT( 230 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_TIMEOUT MAKE_DPHRESULT( 240 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNAVAILABLE MAKE_DPHRESULT( 250 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNSUPPORTED E_NOTIMPL
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_BUSY MAKE_DPHRESULT( 270 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_USERCANCEL MAKE_DPHRESULT( 280 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOINTERFACE E_NOINTERFACE
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANNOTCREATESERVER MAKE_DPHRESULT( 290 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_PLAYERLOST MAKE_DPHRESULT( 300 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SESSIONLOST MAKE_DPHRESULT( 310 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNINITIALIZED MAKE_DPHRESULT( 320 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NONEWPLAYERS MAKE_DPHRESULT( 330 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPASSWORD MAKE_DPHRESULT( 340 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CONNECTING MAKE_DPHRESULT( 350 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CONNECTIONLOST MAKE_DPHRESULT( 360 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNKNOWNMESSAGE MAKE_DPHRESULT( 370 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANCELFAILED MAKE_DPHRESULT( 380 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDPRIORITY MAKE_DPHRESULT( 390 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTHANDLED MAKE_DPHRESULT( 400 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANCELLED MAKE_DPHRESULT( 410 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ABORTED MAKE_DPHRESULT( 420 )


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_BUFFERTOOLARGE MAKE_DPHRESULT( 1000 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTCREATEPROCESS MAKE_DPHRESULT( 1010 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_APPNOTSTARTED MAKE_DPHRESULT( 1020 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_INVALIDINTERFACE MAKE_DPHRESULT( 1030 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOSERVICEPROVIDER MAKE_DPHRESULT( 1040 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_UNKNOWNAPPLICATION MAKE_DPHRESULT( 1050 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTLOBBIED MAKE_DPHRESULT( 1070 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SERVICEPROVIDERLOADED MAKE_DPHRESULT( 1080 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ALREADYREGISTERED MAKE_DPHRESULT( 1090 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTREGISTERED MAKE_DPHRESULT( 1100 )

// 
// Security related errors
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_AUTHENTICATIONFAILED MAKE_DPHRESULT( 2000 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTLOADSSPI MAKE_DPHRESULT( 2010 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ENCRYPTIONFAILED MAKE_DPHRESULT( 2020 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_SIGNFAILED MAKE_DPHRESULT( 2030 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTLOADSECURITYPACKAGE MAKE_DPHRESULT( 2040 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_ENCRYPTIONNOTSUPPORTED MAKE_DPHRESULT( 2050 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_CANTLOADCAPI MAKE_DPHRESULT( 2060 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_NOTLOGGEDIN MAKE_DPHRESULT( 2070 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPERR_LOGONDENIED MAKE_DPHRESULT( 2080 )


/****************************************************************************
 *
 * 	dplay 1.0 obsolete structures + interfaces
 *	Included for compatibility only. New apps should
 *	use IDirectPlay2
 *
 ****************************************************************************/

// define this to ignore obsolete interfaces and constants
#if ! IDIRECTPLAY2_OR_GREATER

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPOPEN_OPENSESSION DPOPEN_JOIN
#define DPOPEN_OPENSESSION
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPOPEN_CREATESESSION DPOPEN_CREATE
#define DPOPEN_CREATESESSION

#define DPENUMSESSIONS_PREVIOUS

#define DPENUMPLAYERS_PREVIOUS

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPSEND_GUARANTEE DPSEND_GUARANTEED
#define DPSEND_GUARANTEE
#define DPSEND_TRYONCE

#define DPCAPS_NAMESERVICE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPCAPS_NAMESERVER DPCAPS_ISHOST
#define DPCAPS_NAMESERVER
#define DPCAPS_GUARANTEED

#define DPLONGNAMELEN
#define DPSHORTNAMELEN
#define DPSESSIONNAMELEN
#define DPPASSWORDLEN
#define DPUSERRESERVED

#define DPSYS_ADDPLAYER
#define DPSYS_DELETEPLAYER

#define DPSYS_DELETEGROUP
#define DPSYS_DELETEPLAYERFROMGRP
#define DPSYS_CONNECT

public class DPMSG_ADDPLAYER
{
    public uint dwType;
    public uint dwPlayerType;
    public uint dpId;
    public string szLongName = new string(new char[DefineConstants.DPLONGNAMELEN]);
    public string szShortName = new string(new char[DefineConstants.DPSHORTNAMELEN]);
    public uint dwCurrentPlayers;
}


public class DPMSG_GROUPADD
{
    public uint dwType;
    public uint dpIdGroup;
    public uint dpIdPlayer;
}

public class DPMSG_DELETEPLAYER
{
    public uint dwType;
    public uint dpId;
}

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(PASCAL *LPDPENUMPLAYERSCALLBACK)(uint dpId, char* lpFriendlyName, char* lpFormalName, uint dwFlags, object* lpContext);
public delegate bool LPDPENUMPLAYERSCALLBACK(uint dpId, ref string lpFriendlyName, ref string lpFormalName, uint dwFlags, object lpContext);

public class DPSESSIONDESC
{
    public uint dwSize;
    public GUID guidSession = new GUID();
    public uint dwSession;
    public uint dwMaxPlayers;
    public uint dwCurrentPlayers;
    public uint dwFlags;
    public string szSessionName = new string(new char[DefineConstants.DPSESSIONNAMELEN]);
    public string szUserField = new string(new char[DefineConstants.DPUSERRESERVED]);
    public uint dwReserved1;
    public string szPassword = new string(new char[DefineConstants.DPPASSWORDLEN]);
    public uint dwReserved2;
    public uint dwUser1;
    public uint dwUser2;
    public uint dwUser3;
    public uint dwUser4;
}

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef bool(PASCAL * LPDPENUMSESSIONSCALLBACK)(DPSESSIONDESC * lpDPSessionDesc, object* lpContext, uint * lpdwTimeOut, uint dwFlags);
public delegate bool LPDPENUMSESSIONSCALLBACK(DPSESSIONDESC lpDPSessionDesc, object lpContext, ref uint lpdwTimeOut, uint dwFlags);