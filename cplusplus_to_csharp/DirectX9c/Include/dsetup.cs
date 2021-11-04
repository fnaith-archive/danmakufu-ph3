/*==========================================================================
 *
 *  Copyright (C) 1995-1997 Microsoft Corporation.  All Rights Reserved.
 *
 *  File:       dsetup.h
 *  Content:    DirectXSetup, error codes and flags
 ***************************************************************************/



#if _WIN32
#define COM_NO_WINDOWS_H
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>
#else
#endif


#if __cplusplus
#endif

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_VERS mmioFOURCC('v','e','r','s')

// DSETUP Error Codes, must remain compatible with previous setup.

// DSETUP flags. DirectX 5.0 apps should use these flags only.
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSETUP_DIRECTX (DSETUP_DXCORE|DSETUP_DDRAWDRV|DSETUP_DSOUNDDRV)

// These OBSOLETE flags are here for compatibility with pre-DX5 apps only.
// They are present to allow DX3 apps to be recompiled with DX5 and still work.
// DO NOT USE THEM for DX5. They will go away in future DX releases.



// ******************************************************************
// DirectX Setup Callback mechanism
// ******************************************************************

// DSETUP Message Info Codes, passed to callback as Reason parameter.





public class _DSETUP_CB_PROGRESS
{
    public uint dwPhase;
    public uint dwInPhaseMaximum;
    public uint dwInPhaseProgress;
    public uint dwOverallMaximum;
    public uint dwOverallProgress;
}


public enum _DSETUP_CB_PROGRESS_PHASE
{
    DSETUP_INITIALIZING,
    DSETUP_EXTRACTING,
    DSETUP_COPYING,
    DSETUP_FINALIZING
}


#if _WIN32
// 
// Data Structures
// 
#if ! UNICODE_ONLY

public class _DIRECTXREGISTERAPPA
{
    public uint dwSize;
    public uint dwFlags;
    public string lpszApplicationName;
    public LPGUID lpGUID = new LPGUID();
    public string lpszFilename;
    public string lpszCommandLine;
    public string lpszPath;
    public string lpszCurrentDirectory;
}

public class _DIRECTXREGISTERAPP2A
{
    public uint dwSize;
    public uint dwFlags;
    public string lpszApplicationName;
    public LPGUID lpGUID = new LPGUID();
    public string lpszFilename;
    public string lpszCommandLine;
    public string lpszPath;
    public string lpszCurrentDirectory;
    public string lpszLauncherName;
}

#endif //!UNICODE_ONLY
#if ! ANSI_ONLY

public class _DIRECTXREGISTERAPPW
{
    public uint dwSize;
    public uint dwFlags;
    public string lpszApplicationName;
    public LPGUID lpGUID = new LPGUID();
    public string lpszFilename;
    public string lpszCommandLine;
    public string lpszPath;
    public string lpszCurrentDirectory;
}

public class _DIRECTXREGISTERAPP2W
{
    public uint dwSize;
    public uint dwFlags;
    public string lpszApplicationName;
    public LPGUID lpGUID = new LPGUID();
    public string lpszFilename;
    public string lpszCommandLine;
    public string lpszPath;
    public string lpszCurrentDirectory;
    public string lpszLauncherName;
}
#endif //!ANSI_ONLY
#if UNICODE
#else
#endif // UNICODE