/***************************************************************************
 *
 *  Copyright (C) 2001-2002 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:		dpnathlp.h
 *
 *  Content:	Header for using DirectPlayNATHelp interface.
 *
 *
 *  NOTE: This interface is deprecated and should no longer be used.
 *
 *
 ***************************************************************************/






// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ole2.h> // for DECLARE_INTERFACE and HRESULT



#if ! DPNATHLP_EXPORTS
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DPNATHLPAPI DECLSPEC_IMPORT
#define DPNATHLPAPI
#else
#define DPNATHLPAPI
#endif



#if __cplusplus
#endif





/****************************************************************************
 *
 * DirectPlay NAT Helper object class IDs
 *
 ****************************************************************************/

// {B9C2E9C4-68C1-4d42-A7A1-E76A26982AD6}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlayNATHelpUPnP, 0xb9c2e9c4, 0x68c1, 0x4d42, 0xa7, 0xa1, 0xe7, 0x6a, 0x26, 0x98, 0x2a, 0xd6);

// {963AB779-16A1-477c-A36D-CB5E711938F7}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(CLSID_DirectPlayNATHelpPAST, 0x963ab779, 0x16a1, 0x477c, 0xa3, 0x6d, 0xcb, 0x5e, 0x71, 0x19, 0x38, 0xf7);


/****************************************************************************
 *
 * DirectPlay NAT Helper interface ID
 *
 ****************************************************************************/

// {154940B6-2278-4a2f-9101-9BA9F431F603}
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectPlayNATHelp, 0x154940b6, 0x2278, 0x4a2f, 0x91, 0x1, 0x9b, 0xa9, 0xf4, 0x31, 0xf6, 0x3);

/****************************************************************************
 *
 * DirectPlay NAT Helper interface pointer definitions
 *
 ****************************************************************************/





/****************************************************************************
 *
 * DirectPlay NAT Helper data types
 *
 ****************************************************************************/

// 
// Handles used to identify specific port binding groups.  If multiple ports
// are registered at the same time, the DPNHHANDLE refers to all ports.
// 




/****************************************************************************
 *
 * DirectPlay NAT Helper constants
 *
 ****************************************************************************/





/****************************************************************************
 *
 * DirectPlay NAT Helper API flags
 *
 ****************************************************************************/

// 
// Flags that can be passed to Initialize
// 

// 
// Flags that can be passed to GetCaps.
// 

// 
// Flags that can be passed to RegisterPorts.
// 

// 
// Flags that can be passed to GetRegisteredAddresses.
// 

// 
// Flags that can be passed to QueryAddress.
// 

/****************************************************************************
 *
 * DirectPlay NAT Helper structure flags
 *
 ****************************************************************************/

// 
// DPNHCAPS flags
// 



/****************************************************************************
 *
 * DirectPlay NAT Helper structures
 *
 ****************************************************************************/

public class _DPNHCAPS
{
    public uint dwSize; // size of this structure, must be filled in prior to calling GetCaps
    public uint dwFlags; // flags indicating capabilities of Internet gateway server(s)
    public uint dwNumRegisteredPorts; // number of ports currently registered, including multiple ports registered at the same time (so this may not be equal to the number of DPNHHANDLEs given out)
    public uint dwMinLeaseTimeRemaining; // approximate time remaining, in milliseconds, for the lease that will expire soonest
    public uint dwRecommendedGetCapsInterval; // recommended time, in milliseconds, after which GetCaps should be called again (with DPNHGETCAPS_UPDATESERVERSTATUS flag)
}



/****************************************************************************
 *
 * Address type flags (returned by GetRegisteredAddresses)
 *
 ****************************************************************************/





/****************************************************************************
 *
 * DirectPlay NAT Helper DLL exported functions
 *
 ****************************************************************************/

// C++ TO C# CONVERTER TODO TASK: The original C++ function pointer contained an unconverted modifier:
// ORIGINAL LINE: typedef int(WINAPI * PFN_DIRECTPLAYNATHELPCREATE)(const GUID * pIID, object** ppvInterface);
public delegate int PFN_DIRECTPLAYNATHELPCREATE(GUID pIID, object[] ppvInterface);