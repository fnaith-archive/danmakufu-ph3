/************************************************************************
*                                                                       *
*   dmusici.h -- This module contains the API for the                   *
*                DirectMusic performance layer                          *
*                                                                       *
*   Copyright (c) Microsoft Corporation.  All rights reserved.          *
*                                                                       *
************************************************************************/



// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <mmsystem.h>
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DLS mmioFOURCC('D','L','S',' ')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_DLID mmioFOURCC('d','l','i','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_COLH mmioFOURCC('c','o','l','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_WVPL mmioFOURCC('w','v','p','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_PTBL mmioFOURCC('p','t','b','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_PATH mmioFOURCC('p','a','t','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_wave mmioFOURCC('w','a','v','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_LINS mmioFOURCC('l','i','n','s')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_INS mmioFOURCC('i','n','s',' ')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_INSH mmioFOURCC('i','n','s','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_LRGN mmioFOURCC('l','r','g','n')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_RGN mmioFOURCC('r','g','n',' ')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_RGNH mmioFOURCC('r','g','n','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_LART mmioFOURCC('l','a','r','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_ART1 mmioFOURCC('a','r','t','1')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_WLNK mmioFOURCC('w','l','n','k')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_WSMP mmioFOURCC('w','s','m','p')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FOURCC_VERS mmioFOURCC('v','e','r','s')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_HRESULT(sev,fac,code) ((HRESULT) (((unsigned long)(sev)<<31) | ((unsigned long)(fac)<<16) | ((unsigned long)(code))) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DMHRESULTSUCCESS(code) MAKE_HRESULT(0, FACILITY_DIRECTMUSIC, (DMUS_ERRBASE + (code)))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKE_DMHRESULTERROR(code) MAKE_HRESULT(1, FACILITY_DIRECTMUSIC, (DMUS_ERRBASE + (code)))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_PARTIALLOAD MAKE_DMHRESULTSUCCESS(0x091)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_PARTIALDOWNLOAD MAKE_DMHRESULTSUCCESS(0x092)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_REQUEUE MAKE_DMHRESULTSUCCESS(0x200)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_FREE MAKE_DMHRESULTSUCCESS(0x201)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_END MAKE_DMHRESULTSUCCESS(0x202)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_STRING_TRUNCATED MAKE_DMHRESULTSUCCESS(0x210)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_LAST_TOOL MAKE_DMHRESULTSUCCESS(0x211)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_OVER_CHORD MAKE_DMHRESULTSUCCESS(0x212)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_UP_OCTAVE MAKE_DMHRESULTSUCCESS(0x213)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_DOWN_OCTAVE MAKE_DMHRESULTSUCCESS(0x214)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_NOBUFFERCONTROL MAKE_DMHRESULTSUCCESS(0x215)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_S_GARBAGE_COLLECTED MAKE_DMHRESULTSUCCESS(0x216)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_DRIVER_FAILED MAKE_DMHRESULTERROR(0x0101)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_PORTS_OPEN MAKE_DMHRESULTERROR(0x0102)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_DEVICE_IN_USE MAKE_DMHRESULTERROR(0x0103)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INSUFFICIENTBUFFER MAKE_DMHRESULTERROR(0x0104)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BUFFERNOTSET MAKE_DMHRESULTERROR(0x0105)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BUFFERNOTAVAILABLE MAKE_DMHRESULTERROR(0x0106)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOTADLSCOL MAKE_DMHRESULTERROR(0x0108)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALIDOFFSET MAKE_DMHRESULTERROR(0x0109)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADY_LOADED MAKE_DMHRESULTERROR(0x0111)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALIDPOS MAKE_DMHRESULTERROR(0x0113)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALIDPATCH MAKE_DMHRESULTERROR(0x0114)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CANNOTSEEK MAKE_DMHRESULTERROR(0x0115)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CANNOTWRITE MAKE_DMHRESULTERROR(0x0116)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CHUNKNOTFOUND MAKE_DMHRESULTERROR(0x0117)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_DOWNLOADID MAKE_DMHRESULTERROR(0x0119)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOT_DOWNLOADED_TO_PORT MAKE_DMHRESULTERROR(0x0120)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADY_DOWNLOADED MAKE_DMHRESULTERROR(0x0121)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_UNKNOWN_PROPERTY MAKE_DMHRESULTERROR(0x0122)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SET_UNSUPPORTED MAKE_DMHRESULTERROR(0x0123)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_GET_UNSUPPORTED MAKE_DMHRESULTERROR(0x0124)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOTMONO MAKE_DMHRESULTERROR(0x0125)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BADARTICULATION MAKE_DMHRESULTERROR(0x0126)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BADINSTRUMENT MAKE_DMHRESULTERROR(0x0127)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BADWAVELINK MAKE_DMHRESULTERROR(0x0128)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOARTICULATION MAKE_DMHRESULTERROR(0x0129)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOTPCM MAKE_DMHRESULTERROR(0x012A)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BADWAVE MAKE_DMHRESULTERROR(0x012B)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BADOFFSETTABLE MAKE_DMHRESULTERROR(0x012C)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_UNKNOWNDOWNLOAD MAKE_DMHRESULTERROR(0x012D)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOSYNTHSINK MAKE_DMHRESULTERROR(0x012E)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADYOPEN MAKE_DMHRESULTERROR(0x012F)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADYCLOSED MAKE_DMHRESULTERROR(0x0130)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SYNTHNOTCONFIGURED MAKE_DMHRESULTERROR(0x0131)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SYNTHACTIVE MAKE_DMHRESULTERROR(0x0132)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CANNOTREAD MAKE_DMHRESULTERROR(0x0133)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_DMUSIC_RELEASED MAKE_DMHRESULTERROR(0x0134)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BUFFER_EMPTY MAKE_DMHRESULTERROR(0x0135)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_BUFFER_FULL MAKE_DMHRESULTERROR(0x0136)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_PORT_NOT_CAPTURE MAKE_DMHRESULTERROR(0x0137)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_PORT_NOT_RENDER MAKE_DMHRESULTERROR(0x0138)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_DSOUND_NOT_SET MAKE_DMHRESULTERROR(0x0139)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADY_ACTIVATED MAKE_DMHRESULTERROR(0x013A)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALIDBUFFER MAKE_DMHRESULTERROR(0x013B)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_WAVEFORMATNOTSUPPORTED MAKE_DMHRESULTERROR(0x013C)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SYNTHINACTIVE MAKE_DMHRESULTERROR(0x013D)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_DSOUND_ALREADY_SET MAKE_DMHRESULTERROR(0x013E)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_EVENT MAKE_DMHRESULTERROR(0x013F)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_UNSUPPORTED_STREAM MAKE_DMHRESULTERROR(0x0150)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADY_INITED MAKE_DMHRESULTERROR(0x0151)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_BAND MAKE_DMHRESULTERROR(0x0152)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TRACK_HDR_NOT_FIRST_CK MAKE_DMHRESULTERROR(0x0155)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TOOL_HDR_NOT_FIRST_CK MAKE_DMHRESULTERROR(0x0156)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_TRACK_HDR MAKE_DMHRESULTERROR(0x0157)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_TOOL_HDR MAKE_DMHRESULTERROR(0x0158)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALL_TOOLS_FAILED MAKE_DMHRESULTERROR(0x0159)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALL_TRACKS_FAILED MAKE_DMHRESULTERROR(0x0160)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOT_FOUND MAKE_DMHRESULTERROR(0x0161)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOT_INIT MAKE_DMHRESULTERROR(0x0162)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TYPE_DISABLED MAKE_DMHRESULTERROR(0x0163)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TYPE_UNSUPPORTED MAKE_DMHRESULTERROR(0x0164)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TIME_PAST MAKE_DMHRESULTERROR(0x0165)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TRACK_NOT_FOUND MAKE_DMHRESULTERROR(0x0166)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_TRACK_NO_CLOCKTIME_SUPPORT MAKE_DMHRESULTERROR(0x0167)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NO_MASTER_CLOCK MAKE_DMHRESULTERROR(0x0170)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_NOCLASSID MAKE_DMHRESULTERROR(0x0180)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_BADPATH MAKE_DMHRESULTERROR(0x0181)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_FAILEDOPEN MAKE_DMHRESULTERROR(0x0182)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_FORMATNOTSUPPORTED MAKE_DMHRESULTERROR(0x0183)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_FAILEDCREATE MAKE_DMHRESULTERROR(0x0184)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_OBJECTNOTFOUND MAKE_DMHRESULTERROR(0x0185)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_LOADER_NOFILENAME MAKE_DMHRESULTERROR(0x0186)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALIDFILE MAKE_DMHRESULTERROR(0x0200)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADY_EXISTS MAKE_DMHRESULTERROR(0x0201)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_OUT_OF_RANGE MAKE_DMHRESULTERROR(0x0202)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SEGMENT_INIT_FAILED MAKE_DMHRESULTERROR(0x0203)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_ALREADY_SENT MAKE_DMHRESULTERROR(0x0204)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CANNOT_FREE MAKE_DMHRESULTERROR(0x0205)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CANNOT_OPEN_PORT MAKE_DMHRESULTERROR(0x0206)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CANNOT_CONVERT MAKE_DMHRESULTERROR(0x0207)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_CONNOT_CONVERT DMUS_E_CANNOT_CONVERT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_DESCEND_CHUNK_FAIL MAKE_DMHRESULTERROR(0x0210)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NOT_LOADED MAKE_DMHRESULTERROR(0x0211)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_LANGUAGE_INCOMPATIBLE MAKE_DMHRESULTERROR(0x0213)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_UNSUPPORTED_VARTYPE MAKE_DMHRESULTERROR(0x0214)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_ERROR_IN_SCRIPT MAKE_DMHRESULTERROR(0x0215)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_CANTLOAD_OLEAUT32 MAKE_DMHRESULTERROR(0x0216)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_LOADSCRIPT_ERROR MAKE_DMHRESULTERROR(0x0217)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_INVALID_FILE MAKE_DMHRESULTERROR(0x0218)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_SCRIPTTRACK MAKE_DMHRESULTERROR(0x0219)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_VARIABLE_NOT_FOUND MAKE_DMHRESULTERROR(0x021A)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_ROUTINE_NOT_FOUND MAKE_DMHRESULTERROR(0x021B)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_CONTENT_READONLY MAKE_DMHRESULTERROR(0x021C)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_NOT_A_REFERENCE MAKE_DMHRESULTERROR(0x021D)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_SCRIPT_VALUE_NOT_SUPPORTED MAKE_DMHRESULTERROR(0x021E)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_SEGMENTTRIGGERTRACK MAKE_DMHRESULTERROR(0x0220)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_LYRICSTRACK MAKE_DMHRESULTERROR(0x0221)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_PARAMCONTROLTRACK MAKE_DMHRESULTERROR(0x0222)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOVBSCRIPT_SYNTAXERROR MAKE_DMHRESULTERROR(0x0223)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOVBSCRIPT_RUNTIMEERROR MAKE_DMHRESULTERROR(0x0224)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOVBSCRIPT_OPERATIONFAILURE MAKE_DMHRESULTERROR(0x0225)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOPATHS_NOT_VALID MAKE_DMHRESULTERROR(0x0226)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOPATHS_IN_USE MAKE_DMHRESULTERROR(0x0227)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NO_AUDIOPATH_CONFIG MAKE_DMHRESULTERROR(0x0228)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOPATH_INACTIVE MAKE_DMHRESULTERROR(0x0229)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOPATH_NOBUFFER MAKE_DMHRESULTERROR(0x022A)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOPATH_NOPORT MAKE_DMHRESULTERROR(0x022B)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_NO_AUDIOPATH MAKE_DMHRESULTERROR(0x022C)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALIDCHUNK MAKE_DMHRESULTERROR(0x022D)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_AUDIOPATH_NOGLOBALFXBUFFER MAKE_DMHRESULTERROR(0x022E)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_E_INVALID_CONTAINER_OBJECT MAKE_DMHRESULTERROR(0x022F)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_INSTRUMENT_GM_INSTRUMENT (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define QWORD_ALIGN(x) (((x) + 7) & ~7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_EVENT_SIZE(cb) QWORD_ALIGN(sizeof(DMUS_EVENTHEADER) + cb)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_DLS (0x00000001)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_EXTERNAL (0x00000002)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_SOFTWARESYNTH (0x00000004)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_MEMORYSIZEFIXED (0x00000008)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_GMINHARDWARE (0x00000010)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_GSINHARDWARE (0x00000020)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_XGINHARDWARE (0x00000040)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_DIRECTSOUND (0x00000080)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_SHAREABLE (0x00000100)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_DLS2 (0x00000200)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_AUDIOPATH (0x00000400)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_WAVE (0x00000800)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PC_SYSTEMMEMORY (0x7FFFFFFF)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_VOICES (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_TOTAL_CPU (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_CPU_PER_VOICE (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_LOST_NOTES (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_PEAK_VOLUME (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_FREE_MEMORY (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SYNTHSTATS_SYSTEMMEMORY DMUS_PC_SYSTEMMEMORY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DSBUSID_IS_SPKR_LOC(id) ( ((id) >= DSBUSID_FIRST_SPKR_LOC) && ((id) <= DSBUSID_LAST_SPKR_LOC) )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusic
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusic8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicBuffer
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicInstrument
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicDownloadedInstrument
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicCollection
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicDownload
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicPortDownload
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CRITICAL_VOICE_PRIORITY (0xF0000000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_HIGH_VOICE_PRIORITY (0xC0000000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_STANDARD_VOICE_PRIORITY (0x80000000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_LOW_VOICE_PRIORITY (0x40000000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_PERSIST_VOICE_PRIORITY (0x10000000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN1_VOICE_PRIORITY_OFFSET (0x0000000E)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN2_VOICE_PRIORITY_OFFSET (0x0000000D)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN3_VOICE_PRIORITY_OFFSET (0x0000000C)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN4_VOICE_PRIORITY_OFFSET (0x0000000B)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN5_VOICE_PRIORITY_OFFSET (0x0000000A)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN6_VOICE_PRIORITY_OFFSET (0x00000009)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN7_VOICE_PRIORITY_OFFSET (0x00000008)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN8_VOICE_PRIORITY_OFFSET (0x00000007)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN9_VOICE_PRIORITY_OFFSET (0x00000006)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN10_VOICE_PRIORITY_OFFSET (0x0000000F)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN11_VOICE_PRIORITY_OFFSET (0x00000005)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN12_VOICE_PRIORITY_OFFSET (0x00000004)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN13_VOICE_PRIORITY_OFFSET (0x00000003)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN14_VOICE_PRIORITY_OFFSET (0x00000002)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN15_VOICE_PRIORITY_OFFSET (0x00000001)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN16_VOICE_PRIORITY_OFFSET (0x00000000)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN1_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN1_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN2_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN2_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN3_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN3_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN4_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN4_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN5_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN5_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN6_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN6_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN7_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN7_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN8_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN8_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN9_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN9_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN10_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN10_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN11_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN11_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN12_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN12_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN13_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN13_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN14_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN14_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN15_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN15_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DAUD_CHAN16_DEF_VOICE_PRIORITY (DAUD_STANDARD_VOICE_PRIORITY | DAUD_CHAN16_VOICE_PRIORITY_OFFSET)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicPort
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicThru
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IReferenceClock
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicThru8 IID_IDirectMusicThru
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicPortDownload8 IID_IDirectMusicPortDownload
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicDownload8 IID_IDirectMusicDownload
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicCollection8 IID_IDirectMusicCollection
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicInstrument8 IID_IDirectMusicInstrument
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicDownloadedInstrument8 IID_IDirectMusicDownloadedInstrument
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicPort8 IID_IDirectMusicPort
/* plugin (track and tool) interfaces.  This #include will eventually go away. */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicTool
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicTool8
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicTrack
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define INTERFACE IDirectMusicTrack8

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack8.h>

#if __cplusplus
#endif

public enum enumDMUS_STYLET_TYPES
{
    DMUS_STYLET_PATTERN = 0,
    DMUS_STYLET_MOTIF = 1
}


public enum enumDMUS_COMMANDT_TYPES
{
    DMUS_COMMANDT_GROOVE = 0,
    DMUS_COMMANDT_FILL = 1,
    DMUS_COMMANDT_INTRO = 2,
    DMUS_COMMANDT_BREAK = 3,
    DMUS_COMMANDT_END = 4,
    DMUS_COMMANDT_ENDANDINTRO = 5
}

public enum enumDMUS_SHAPET_TYPES
{
    DMUS_SHAPET_FALLING = 0,
    DMUS_SHAPET_LEVEL = 1,
    DMUS_SHAPET_LOOPABLE = 2,
    DMUS_SHAPET_LOUD = 3,
    DMUS_SHAPET_QUIET = 4,
    DMUS_SHAPET_PEAKING = 5,
    DMUS_SHAPET_RANDOM = 6,
    DMUS_SHAPET_RISING = 7,
    DMUS_SHAPET_SONG = 8
}

public enum enumDMUS_COMPOSEF_FLAGS
{
    DMUS_COMPOSEF_NONE = 0,
    DMUS_COMPOSEF_ALIGN = 0x1,
    DMUS_COMPOSEF_OVERLAP = 0x2,
    DMUS_COMPOSEF_IMMEDIATE = 0x4,
    DMUS_COMPOSEF_GRID = 0x8,
    DMUS_COMPOSEF_BEAT = 0x10,
    DMUS_COMPOSEF_MEASURE = 0x20,
    DMUS_COMPOSEF_AFTERPREPARETIME = 0x40,
    DMUS_COMPOSEF_VALID_START_BEAT = 0x80, // In conjunction with DMUS_COMPOSEF_ALIGN, allows the switch to occur on any beat.
    DMUS_COMPOSEF_VALID_START_GRID = 0x100, // In conjunction with DMUS_COMPOSEF_ALIGN, allows the switch to occur on any grid.
    DMUS_COMPOSEF_VALID_START_TICK = 0x200, // In conjunction with DMUS_COMPOSEF_ALIGN, allows the switch to occur any time.
    DMUS_COMPOSEF_SEGMENTEND = 0x400, // Play the transition at the end of the current segment.
    DMUS_COMPOSEF_MARKER = 0x800, // Play the transition at the next marker in the current segment.
    DMUS_COMPOSEF_MODULATE = 0x1000,
    DMUS_COMPOSEF_LONG = 0x2000,
    DMUS_COMPOSEF_ENTIRE_TRANSITION = 0x4000, // play the entire transition pattern
    DMUS_COMPOSEF_1BAR_TRANSITION = 0x8000, // play one bar of the transition pattern
    DMUS_COMPOSEF_ENTIRE_ADDITION = 0x10000, // play the additional pattern in its entirety
    DMUS_COMPOSEF_1BAR_ADDITION = 0x20000, // play one bar of the additional pattern
    DMUS_COMPOSEF_VALID_START_MEASURE = 0x40000, // In conjunction with DMUS_COMPOSEF_ALIGN, allows the switch to occur on any bar.
    DMUS_COMPOSEF_DEFAULT = 0x80000, // Use segment's default boundary
    DMUS_COMPOSEF_NOINVALIDATE = 0x100000, // Play without invalidating the currently playing segment(s)
    DMUS_COMPOSEF_USE_AUDIOPATH = 0x200000, // Uses the audio paths that are embedded in the segments
    DMUS_COMPOSEF_INVALIDATE_PRI = 0x400000 // Invalidate only the current primary seg state
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PMSG_PART DWORD dwSize; REFERENCE_TIME rtTime; MUSIC_TIME mtTime; DWORD dwFlags; DWORD dwPChannel; DWORD dwVirtualTrackID; IDirectMusicTool* pTool; IDirectMusicGraph* pGraph; DWORD dwType; DWORD dwVoiceID; DWORD dwGroupID; IUnknown* punkUser;

/* every DMUS_PMSG is based off of this structure. The Performance needs 
   to access these members consistently in every PMSG that goes through it. */
public class _DMUS_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

}


/*  The DMUS_PATH constants are used in conjunction with GetObjectInPath to find a requested
    interface at a particular stage in the audio path. 
*/

/*  To ignore PChannels when calling GetObjectInPath(), use the DMUS_PCHANNEL_ALL constant. */

/*  The DMUS_APATH types are used in conjunction with CreateStandardAudioPath to
    build default path types. _SHARED_ means the same buffer is shared across multiple
    instantiations of the audiopath type. _DYNAMIC_ means a unique buffer is created
    every time. 
*/


public class _DMUS_AUDIOPARAMS
{
    public uint dwSize; // Size of this structure.
    public bool fInitNow; // If true, the sink and synth are created immediately and results returned in this structure.
    public uint dwValidData; // Flags indicating which fields below are valid.
    public uint dwFeatures; // Required DMUS_AUDIOF features.
    public uint dwVoices; // Required number of voices.
    public uint dwSampleRate; // Sample rate of synths and sink.
    public CLSID clsidDefaultSynth = new CLSID(); // Class ID of default synthesizer.
}

/* dwFeatures flags. These indicate which features are required for the audio environment. */

/* dwValidData flags. These indicate which fields in DMUS_AUDIOPARAMS have been filled in. If fInitNow is set, these also return what was allocated. */

/* DMUS_PMSGF_FLAGS fill the DMUS_PMSG's dwFlags member */
public enum enumDMUS_PMSGF_FLAGS
{
    DMUS_PMSGF_REFTIME = 1, // if rtTime is valid
    DMUS_PMSGF_MUSICTIME = 2, // if mtTime is valid
    DMUS_PMSGF_TOOL_IMMEDIATE = 4, // if PMSG should be processed immediately
    DMUS_PMSGF_TOOL_QUEUE = 8, // if PMSG should be processed a little early, at Queue time
    DMUS_PMSGF_TOOL_ATTIME = 0x10, // if PMSG should be processed at the time stamp
    DMUS_PMSGF_TOOL_FLUSH = 0x20, // if PMSG is being flushed
    DMUS_PMSGF_LOCKTOREFTIME = 0x40, // if rtTime can not be overriden by a tempo change.
    DMUS_PMSGF_DX8 = 0x80 // if the message has DX8 or later extensions.
    /* The values of DMUS_TIME_RESOLVE_FLAGS may also be used inside the */
    /* DMUS_PMSG's dwFlags member. */
}

/* DMUS_PMSGT_TYPES fill the DMUS_PMSG's dwType member */
public enum enumDMUS_PMSGT_TYPES
{
    DMUS_PMSGT_MIDI = 0, // MIDI short message
    DMUS_PMSGT_NOTE = 1, // Interactive Music Note
    DMUS_PMSGT_SYSEX = 2, // MIDI long message (system exclusive message)
    DMUS_PMSGT_NOTIFICATION = 3, // Notification message
    DMUS_PMSGT_TEMPO = 4, // Tempo message
    DMUS_PMSGT_CURVE = 5, // Control change / pitch bend, etc. curve
    DMUS_PMSGT_TIMESIG = 6, // Time signature
    DMUS_PMSGT_PATCH = 7, // Patch changes
    DMUS_PMSGT_TRANSPOSE = 8, // Transposition messages
    DMUS_PMSGT_CHANNEL_PRIORITY = 9, // Channel priority
    DMUS_PMSGT_STOP = 10, // Stop message
    DMUS_PMSGT_DIRTY = 11, // Tells Tools that cache GetParam() info to refresh
    DMUS_PMSGT_WAVE = 12, // Carries control information for playing a wave.
    DMUS_PMSGT_LYRIC = 13, // Lyric message from lyric track.
    DMUS_PMSGT_SCRIPTLYRIC = 14, // Lyric message sent by a script with the Trace function.
    DMUS_PMSGT_USER = 255 // User message
}

/* DMUS_SEGF_FLAGS correspond to IDirectMusicPerformance::PlaySegment, and other API */
public enum enumDMUS_SEGF_FLAGS
{
    DMUS_SEGF_REFTIME = 1 << 6, // 0x40 Time parameter is in reference time
    DMUS_SEGF_SECONDARY = 1 << 7, // 0x80 Secondary segment
    DMUS_SEGF_QUEUE = 1 << 8, // 0x100 Queue at the end of the primary segment queue (primary only)
    DMUS_SEGF_CONTROL = 1 << 9, // 0x200 Play as a control track (secondary segments only)
    DMUS_SEGF_AFTERPREPARETIME = 1 << 10, // 0x400 Play after the prepare time (See IDirectMusicPerformance::GetPrepareTime)
    DMUS_SEGF_GRID = 1 << 11, // 0x800 Play on grid boundary
    DMUS_SEGF_BEAT = 1 << 12, // 0x1000 Play on beat boundary
    DMUS_SEGF_MEASURE = 1 << 13, // 0x2000 Play on measure boundary
    DMUS_SEGF_DEFAULT = 1 << 14, // 0x4000 Use segment's default boundary
    DMUS_SEGF_NOINVALIDATE = 1 << 15, // 0x8000 Play without invalidating the currently playing segment(s)
    DMUS_SEGF_ALIGN = 1 << 16, // 0x10000 Align segment with requested boundary, but switch at first valid point
    DMUS_SEGF_VALID_START_BEAT = 1 << 17, // 0x20000 In conjunction with DMUS_SEGF_ALIGN, allows the switch to occur on any beat.
    DMUS_SEGF_VALID_START_GRID = 1 << 18, // 0x40000 In conjunction with DMUS_SEGF_ALIGN, allows the switch to occur on any grid.
    DMUS_SEGF_VALID_START_TICK = 1 << 19, // 0x80000 In conjunction with DMUS_SEGF_ALIGN, allows the switch to occur any time.
    DMUS_SEGF_AUTOTRANSITION = 1 << 20, // 0x100000 Compose and play a transition segment, using the transition template.
    DMUS_SEGF_AFTERQUEUETIME = 1 << 21, // 0x200000 Make sure to play after the queue time. This is default for primary segments
    DMUS_SEGF_AFTERLATENCYTIME = 1 << 22, // 0x400000 Make sure to play after the latency time. This is true for all segments, so this is a nop
    DMUS_SEGF_SEGMENTEND = 1 << 23, // 0x800000 Play at the next end of segment.
    DMUS_SEGF_MARKER = 1 << 24, // 0x1000000 Play at next marker in the primary segment. If there are no markers, default to any other resolution requests.
    DMUS_SEGF_TIMESIG_ALWAYS = 1 << 25, // 0x2000000 Even if there is no primary segment, align start time with current time signature.
    DMUS_SEGF_USE_AUDIOPATH = 1 << 26, // 0x4000000 Uses the audio path that is embedded in the segment.
    DMUS_SEGF_VALID_START_MEASURE = 1 << 27, // 0x8000000 In conjunction with DMUS_SEGF_ALIGN, allows the switch to occur on any bar.
    DMUS_SEGF_INVALIDATE_PRI = 1 << 28 // 0x10000000 invalidate only the current primary seg state
}



/* DMUS_TIME_RESOLVE_FLAGS correspond to IDirectMusicPerformance::GetResolvedTime, and can */
/* also be used interchangeably with the corresponding DMUS_SEGF_FLAGS, since their values */
/* are intentionally the same */
public enum enumDMUS_TIME_RESOLVE_FLAGS
{
    DMUS_TIME_RESOLVE_AFTERPREPARETIME = enumDMUS_SEGF_FLAGS.DMUS_SEGF_AFTERPREPARETIME,
    DMUS_TIME_RESOLVE_AFTERQUEUETIME = enumDMUS_SEGF_FLAGS.DMUS_SEGF_AFTERQUEUETIME,
    DMUS_TIME_RESOLVE_AFTERLATENCYTIME = enumDMUS_SEGF_FLAGS.DMUS_SEGF_AFTERLATENCYTIME,
    DMUS_TIME_RESOLVE_GRID = enumDMUS_SEGF_FLAGS.DMUS_SEGF_GRID,
    DMUS_TIME_RESOLVE_BEAT = enumDMUS_SEGF_FLAGS.DMUS_SEGF_BEAT,
    DMUS_TIME_RESOLVE_MEASURE = enumDMUS_SEGF_FLAGS.DMUS_SEGF_MEASURE,
    DMUS_TIME_RESOLVE_MARKER = enumDMUS_SEGF_FLAGS.DMUS_SEGF_MARKER,
    DMUS_TIME_RESOLVE_SEGMENTEND = enumDMUS_SEGF_FLAGS.DMUS_SEGF_SEGMENTEND
}

/* The following flags are sent inside the DMUS_CHORD_KEY.dwFlags parameter */
public enum enumDMUS_CHORDKEYF_FLAGS
{
    DMUS_CHORDKEYF_SILENT = 1 // is the chord silent?
}


public class _DMUS_SUBCHORD
{
    public uint dwChordPattern; // Notes in the subchord
    public uint dwScalePattern; // Notes in the scale
    public uint dwInversionPoints; // Where inversions can occur
    public uint dwLevels; // Which levels are supported by this subchord
    public byte bChordRoot; // Root of the subchord
    public byte bScaleRoot; // Root of the scale
}

public class _DMUS_CHORD_KEY
{
    public string wszName = new string(new char[16]); // Name of the chord
    public ushort wMeasure; // Measure this falls on
    public byte bBeat; // Beat this falls on
    public byte bSubChordCount; // Number of chords in the list of subchords
    public _DMUS_SUBCHORD[] SubChordList = Arrays.InitializeWithDefaultInstances<_DMUS_SUBCHORD>(DefineConstants.DMUS_MAXSUBCHORD); // List of sub chords
    public uint dwScale; // Scale underlying the entire chord
    public byte bKey; // Key underlying the entire chord
    public byte bFlags; // Miscelaneous flags
}

/* DMUS_NOTE_PMSG */
public class _DMUS_NOTE_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public int mtDuration; // duration
    public ushort wMusicValue; // Description of note in chord and key.
    public ushort wMeasure; // Measure in which this note occurs
    public short nOffset; // Offset from grid at which this note occurs
    public byte bBeat; // Beat (in measure) at which this note occurs
    public byte bGrid; // Grid offset from beat at which this note occurs
    public byte bVelocity; // Note velocity
    public byte bFlags; // see DMUS_NOTEF_FLAGS
    public byte bTimeRange; // Range to randomize time.
    public byte bDurRange; // Range to randomize duration.
    public byte bVelRange; // Range to randomize velocity.
    public byte bPlayModeFlags; // Play mode
    public byte bSubChordLevel; // Which subchord level this note uses.
    public byte bMidiValue; // The MIDI note value, converted from wMusicValue
    public char cTranspose; // Transposition to add to midi note value after converted from wMusicValue.
}

public enum enumDMUS_NOTEF_FLAGS
{
    DMUS_NOTEF_NOTEON = 1, // Set if this is a MIDI Note On. Otherwise, it is MIDI Note Off
    /* DX8 flags: */
    DMUS_NOTEF_NOINVALIDATE = 2, // Don't invalidate this note off.
    DMUS_NOTEF_NOINVALIDATE_INSCALE = 4, // Don't invalidate if still within the scale.
    DMUS_NOTEF_NOINVALIDATE_INCHORD = 8, // Don't invalidate if still within the chord.
    DMUS_NOTEF_REGENERATE = 0x10 // Regenerate the note on an invalidate.
}

/* The DMUS_PLAYMODE_FLAGS are used to determine how to convert wMusicValue
   into the appropriate bMidiValue.
*/

public enum enumDMUS_PLAYMODE_FLAGS
{
    DMUS_PLAYMODE_KEY_ROOT = 1, // Transpose on top of the key root.
    DMUS_PLAYMODE_CHORD_ROOT = 2, // Transpose on top of the chord root.
    DMUS_PLAYMODE_SCALE_INTERVALS = 4, // Use scale intervals from scale pattern.
    DMUS_PLAYMODE_CHORD_INTERVALS = 8, // Use chord intervals from chord pattern.
    DMUS_PLAYMODE_NONE = 16 // No mode. Indicates the parent part's mode should be used.
}

/* The following are playback modes that can be created by combining the DMUS_PLAYMODE_FLAGS
   in various ways:
*/

/* Fixed. wMusicValue holds final MIDI note value. This is used for drums, sound effects, and sequenced
   notes that should not be transposed by the chord or scale.
*/
/* In fixed to key, the musicvalue is again a fixed MIDI value, but it
   is transposed on top of the key root. 
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_FIXEDTOKEY DMUS_PLAYMODE_KEY_ROOT
/* In fixed to chord, the musicvalue is also a fixed MIDI value, but it
   is transposed on top of the chord root. 
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_FIXEDTOCHORD DMUS_PLAYMODE_CHORD_ROOT
/* In Pedalpoint, the key root is used and the notes only track the intervals in
   the scale. The chord root and intervals are completely ignored. This is useful
   for melodic lines that play relative to the key root.
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_PEDALPOINT (DMUS_PLAYMODE_KEY_ROOT | DMUS_PLAYMODE_SCALE_INTERVALS)
/* In the Melodic mode, the chord root is used but the notes only track the intervals in
   the scale. The key root and chord intervals are completely ignored. This is useful
   for melodic lines that play relative to the chord root. 
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_MELODIC (DMUS_PLAYMODE_CHORD_ROOT | DMUS_PLAYMODE_SCALE_INTERVALS)
/* Normal chord mode is the prevalent playback mode. 
   The notes track the intervals in the chord, which is based on the chord root. 
   If there is a scale component to the MusicValue, the additional intervals 
   are pulled from the scale and added.
   If the chord does not have an interval to match the chord component of
   the MusicValue, the note is silent.
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_NORMALCHORD (DMUS_PLAYMODE_CHORD_ROOT | DMUS_PLAYMODE_CHORD_INTERVALS)
/* If it is desirable to play a note that is above the top of the chord, the
   always play mode (known as "purpleized" in a former life) finds a position
   for the note by using intervals from the scale. Essentially, this mode is
   a combination of the Normal and Melodic playback modes, where a failure
   in Normal causes a second try in Melodic mode.
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_ALWAYSPLAY (DMUS_PLAYMODE_MELODIC | DMUS_PLAYMODE_NORMALCHORD)

/* These playmodes are new for dx8. */
/* In PedalpointChord, the key root is used and the notes only track the intervals in
   the chord. The chord root and scale intervals are completely ignored. This is useful
   for chordal lines that play relative to the key root.
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_PEDALPOINTCHORD (DMUS_PLAYMODE_KEY_ROOT | DMUS_PLAYMODE_CHORD_INTERVALS)

/* For completeness, here's a mode that tries for pedalpointchord, but if it fails
   uses scale intervals
*/
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_PEDALPOINTALWAYS (DMUS_PLAYMODE_PEDALPOINT | DMUS_PLAYMODE_PEDALPOINTCHORD)


/*  Legacy names for modes... */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_PURPLEIZED DMUS_PLAYMODE_ALWAYSPLAY
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_SCALE_ROOT DMUS_PLAYMODE_KEY_ROOT
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_PLAYMODE_FIXEDTOSCALE DMUS_PLAYMODE_FIXEDTOKEY


/* DMUS_MIDI_PMSG */
public class _DMUS_MIDI_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public byte bStatus;
    public byte bByte1;
    public byte bByte2;
    public byte[] bPad = new byte[1];
}

/* DMUS_PATCH_PMSG */
public class _DMUS_PATCH_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public byte byInstrument;
    public byte byMSB;
    public byte byLSB;
    public byte[] byPad = new byte[1];
}

/* DMUS_TRANSPOSE_PMSG */
public class _DMUS_TRANSPOSE_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public short nTranspose;
    /* Following exists only under DX8 and on (check dwFlags for DMUS_PMSGF_DX8) */
    public ushort wMergeIndex; // Allows multiple parameters to be merged (pitchbend, volume, and expression.)
}

/* DMUS_CHANNEL_PRIORITY_PMSG */
public class _DMUS_CHANNEL_PRIORITY_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public uint dwChannelPriority;
}

/* DMUS_TEMPO_PMSG */
public class _DMUS_TEMPO_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public double dblTempo; // the tempo
}



/* DMUS_SYSEX_PMSG */
public class _DMUS_SYSEX_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public uint dwLen; // length of the data
    public byte[] abData = new byte[1]; // array of data, length equal to dwLen
}

/* DMUS_CURVE_PMSG */
public class _DMUS_CURVE_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public int mtDuration; // how long this curve lasts
    public int mtOriginalStart; // must be set to either zero when this PMSG is created or to the original mtTime of the curve
    public int mtResetDuration; /* how long after the curve is finished to allow a flush or
                                        invalidation to reset to the reset value, nResetValue */
    public short nStartValue; // curve's start value
    public short nEndValue; // curve's end value
    public short nResetValue; /* curve's reset value, set when a flush or invalidation
                                        occurs within mtDuration + mtResetDuration */
    public ushort wMeasure; // Measure in which this curve occurs
    public short nOffset; // Offset from grid at which this curve occurs
    public byte bBeat; // Beat (in measure) at which this curve occurs
    public byte bGrid; // Grid offset from beat at which this curve occurs
    public byte bType; // type of curve
    public byte bCurveShape; // shape of curve
    public byte bCCData; // CC# if this is a control change type
    public byte bFlags; // Curve reset and start from current value flags.
    /* Following exists only under DX8 and on (check dwFlags for DMUS_PMSGF_DX8) */
    public ushort wParamType; // RPN or NRPN parameter number.
    public ushort wMergeIndex; // Allows multiple parameters to be merged (pitchbend, volume, and expression.)
}

public enum enumDMUS_CURVE_FLAGS
{
    DMUS_CURVE_RESET = 1, /* When set, the nResetValue must be sent when the
                                        time is reached or an invalidate occurs because
                                        of a transition. If not set, the curve stays
                                        permanently stuck at the new value. */
    DMUS_CURVE_START_FROM_CURRENT = 2 /* Ignore Start, start the curve at the current value.
                                        This only works for volume, expression, and pitchbend. */
}



/* Curve shapes */
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
public enum AnonymousEnum
{
    DMUS_CURVES_LINEAR = 0,
    DMUS_CURVES_INSTANT = 1,
    DMUS_CURVES_EXP = 2,
    DMUS_CURVES_LOG = 3,
    DMUS_CURVES_SINE = 4
}
/* curve types */

/* DMUS_TIMESIG_PMSG */
public class _DMUS_TIMESIG_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    /* Time signatures define how many beats per measure, which note receives */
    /* the beat, and the grid resolution. */
    public byte bBeatsPerMeasure; // beats per measure (top of time sig)
    public byte bBeat; // what note receives the beat (bottom of time sig.)
                                    /* we can assume that 0 means 256th note */
    public ushort wGridsPerBeat; // grids per beat
}



/* notification type values */
/* The following correspond to GUID_NOTIFICATION_SEGMENT */
/* The following correspond to GUID_NOTIFICATION_PERFORMANCE */
/* The following corresponds to GUID_NOTIFICATION_MEASUREANDBEAT */
/* The following corresponds to GUID_NOTIFICATION_CHORD */
/* The following correspond to GUID_NOTIFICATION_COMMAND */
/* The following corresponds to GUID_NOTIFICATION_RECOMPOSE */

/* DMUS_NOTIFICATION_PMSG */
public class _DMUS_NOTIFICATION_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public GUID guidNotificationType = new GUID();
    public uint dwNotificationOption;
    public uint dwField1;
    public uint dwField2;
}

/* DMUS_WAVE_PMSG */
public class _DMUS_WAVE_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

// C++ TO C# CONVERTER TODO TASK: The typedef 'REFERENCE_TIME' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
    public REFERENCE_TIME rtStartOffset = new REFERENCE_TIME(); // How far into the wave to start, in reference time units only.
// C++ TO C# CONVERTER TODO TASK: The typedef 'REFERENCE_TIME' was defined in multiple preprocessor conditionals and cannot be replaced in-line:
    public REFERENCE_TIME rtDuration = new REFERENCE_TIME(); // Duration of the wave, in either reference time or music time.
    public int lOffset; // Offset from actual time to logical time, in music or ref time.
    public int lVolume; // Initial volume, in 100ths of a dB.
    public int lPitch; // Initial pitch, in 100ths of a semitone.
    public byte bFlags; // Flags, including DMUS_WAVEF_OFF...
}


/* DMUS_LYRIC_PMSG */
public class _DMUS_LYRIC_PMSG
{
    /* begin DMUS_PMSG_PART */
    public uint dwSize;
    public long rtTime;
    public int mtTime;
    public uint dwFlags;
    public uint dwPChannel;
    public uint dwVirtualTrackID;
    public @interface IDirectMusicTool * pTool = new @interface();
    public @interface IDirectMusicGraph * pGraph = new @interface();
    public uint dwType;
    public uint dwVoiceID;
    public uint dwGroupID;
    public IUnknown punkUser;
    /* end DMUS_PMSG_PART */

    public string wszString = new string(new char[1]); // null-terminated Unicode lyric string (structure is actually larger than size 1)
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_MAX_FILENAME MAX_PATH

public class _DMUS_VERSION
{
  public uint dwVersionMS;
  public uint dwVersionLS;
}

/* Time Signature structure, used by IDirectMusicStyle */
/* Also used as a parameter for GetParam() and SetParam */
public class _DMUS_TIMESIGNATURE
{
    public int mtTime;
    public byte bBeatsPerMeasure; // beats per measure (top of time sig)
    public byte bBeat; // what note receives the beat (bottom of time sig.)
                                    /* we can assume that 0 means 256th note */
    public ushort wGridsPerBeat; // grids per beat
}

public class _DMUS_VALID_START_PARAM
{
    public int mtTime; /* Time of the first legal start
                                               point after (or including) the requested time. 
                                               This is a returned value.
                                               Time format is the relative offset from requested time. */
}

public class _DMUS_PLAY_MARKER_PARAM
{
    public int mtTime; /* Time of the first legal segment play
                                               marker before (or including) the requested time. 
                                               This is a returned value.
                                               Time format is the relative offset from requested time. */
}

/*      The DMUSOBJECTDESC structure is used to communicate everything you could */
/*      possibly use to describe a DirectMusic object.  */

public class _DMUS_OBJECTDESC
{
    public uint dwSize; // Size of this structure.
    public uint dwValidData; // Flags indicating which fields below are valid.
    public GUID guidObject = new GUID(); // Unique ID for this object.
    public GUID guidClass = new GUID(); // GUID for the class of object.
    public FILETIME ftDate = new FILETIME(); // Last edited date of object.
    public _DMUS_VERSION vVersion = new _DMUS_VERSION(); // Version.
    public string wszName = new string(new char[DefineConstants.DMUS_MAX_NAME]); // Name of object.
    public string wszCategory = new string(new char[DefineConstants.DMUS_MAX_CATEGORY]); // Category for object (optional).
    public string wszFileName = new string(new char[MAX_PATH]); // File path.
    public long llMemLength; // Size of Memory data.
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte * pbMemData;
    public byte pbMemData; // Memory pointer for data.
    public IStream pStream; // Stream with data.
}


/*      Flags for dwValidData. When set, a flag indicates that the  */
/*      corresponding field in DMUSOBJECTDESC holds valid data. */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_OBJECT (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_CLASS (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_NAME (1 << 2)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_CATEGORY (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_FILENAME (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_FULLPATH (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_URL (1 << 6)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_VERSION (1 << 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_DATE (1 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_LOADED (1 << 9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_MEMORY (1 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_OBJ_STREAM (1 << 11)

/*      The DMUS_SCRIPT_ERRORINFO structure describes an error that occurred in a script.
        It is returned by methods in IDirectMusicScript. */
public class _DMUS_SCRIPT_ERRORINFO
{
    public uint dwSize; // Size of this structure.
    public int hr;
    public uint ulLineNumber;
    public int ichCharPosition;
    public string wszSourceFile = new string(new char[MAX_PATH]);
    public string wszSourceComponent = new string(new char[MAX_PATH]);
    public string wszDescription = new string(new char[MAX_PATH]);
    public string wszSourceLineText = new string(new char[MAX_PATH]);
}

/*  Track configuration flags, used with IDirectMusicSegment8::SetTrackConfig() */

/* Additional track config flags for composing transitions */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_TRACKCONFIG_DEFAULT (DMUS_TRACKCONFIG_CONTROL_ENABLED | DMUS_TRACKCONFIG_PLAY_ENABLED | DMUS_TRACKCONFIG_NOTIFICATION_ENABLED)

/* Get/SetParam structs for commands */
/* PARAM structures, used by GetParam() and SetParam() */
public class _DMUS_COMMAND_PARAM
{
    public byte bCommand;
    public byte bGrooveLevel;
    public byte bGrooveRange;
    public byte bRepeatMode;
}

public class _DMUS_COMMAND_PARAM_2
{
    public int mtTime;
    public byte bCommand;
    public byte bGrooveLevel;
    public byte bGrooveRange;
    public byte bRepeatMode;
}
public class _DMUS_BAND_PARAM
{
    public int mtTimePhysical; // Note: If this is a clock-time track, then this field is interpreted in the track's internal time format, which is the number of milliseconds after the beginning of playback.
    public @interface IDirectMusicBand * pBand = new @interface();
}

/* Obsolete -- doesn't distinguish physical and logical time.  Use GUID_BandParam instead. */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_IDirectMusicBand,0xd2ac28ac, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Use to get/set an IDirectMusicChordMap param in the ChordMap track */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_IDirectMusicChordMap,0xd2ac28ad, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Use to get/set a DMUS_MUTE_PARAM param in the Mute track */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_MuteParam,0xd2ac28af, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* These guids are used in IDirectMusicSegment::SetParam to tell the band track to perform various actions.
   Some of these guids (where noted) also apply to wave tracks.
 */
/* Download bands/waves for the IDirectMusicSegment */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Download,0xd2ac28a7, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Unload bands/waves for the IDirectMusicSegment */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Unload,0xd2ac28a8, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Connect segment's bands to an IDirectMusicCollection */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_ConnectToDLSCollection, 0x1db1ae6b, 0xe92e, 0x11d1, 0xa8, 0xc5, 0x0, 0xc0, 0x4f, 0xa3, 0x72, 0x6e);

/* Enable/disable autodownloading of bands/waves */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Enable_Auto_Download,0xd2ac28a9, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Disable_Auto_Download,0xd2ac28aa, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Clear all bands */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Clear_All_Bands,0xd2ac28ab, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Set segment to manage all program changes, bank selects, etc. for simple playback of a standard MIDI file */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_StandardMIDIFile, 0x6621075, 0xe92e, 0x11d1, 0xa8, 0xc5, 0x0, 0xc0, 0x4f, 0xa3, 0x72, 0x6e);
/* For compatibility with beta releases... */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define GUID_IgnoreBankSelectForGM GUID_StandardMIDIFile

/* Disable/enable param guids. Use these in SetParam calls to disable or enable sending
 * specific PMsg types.
 */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DisableTimeSig, 0x45fc707b, 0x1db4, 0x11d2, 0xbc, 0xac, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_EnableTimeSig, 0x45fc707c, 0x1db4, 0x11d2, 0xbc, 0xac, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DisableTempo, 0x45fc707d, 0x1db4, 0x11d2, 0xbc, 0xac, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_EnableTempo, 0x45fc707e, 0x1db4, 0x11d2, 0xbc, 0xac, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);

/* Used in SetParam calls for pattern-based tracks.  A nonzero value seeds the random number 
generator for variation selection; a value of zero reverts to the default behavior of 
getting the seed from the system clock.
*/
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_SeedVariations, 0x65b76fa5, 0xff37, 0x11d2, 0x81, 0x4e, 0x0, 0xc0, 0x4f, 0xa3, 0x6e, 0x58);

/* Used to get the variations currently in effect across PChannels */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Variations, 0x11f72cce, 0x26e6, 0x4ecd, 0xaf, 0x2e, 0xd6, 0x68, 0xe6, 0x67, 0x7, 0xd8);
public class _DMUS_VARIATIONS_PARAM
{
    public uint dwPChannelsUsed; // number of PChannels in use
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint* padwPChannels;
    public uint padwPChannels; // array of PChannels in use
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: uint* padwVariations;
    public uint padwVariations; // array of variations in effect for each PChannel
}

/* Download bands/waves for the IDirectMusicSegment, passed an IDirectMusicAudioPath instead of an IDirectMusicPerformance */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DownloadToAudioPath,0x9f2c0341, 0xc5c4, 0x11d3, 0x9b, 0xd1, 0x44, 0x45, 0x53, 0x54, 0x0, 0x0);

/* Unload bands/waves for the IDirectMusicSegment, passed an IDirectMusicAudioPath instead of an IDirectMusicPerformance */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_UnloadFromAudioPath,0x9f2c0342, 0xc5c4, 0x11d3, 0x9b, 0xd1, 0x44, 0x45, 0x53, 0x54, 0x0, 0x0);


/* Global data guids */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_PerfMasterTempo,0xd2ac28b0, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_PerfMasterVolume,0xd2ac28b1, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_PerfMasterGrooveLevel,0xd2ac28b2, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_PerfAutoDownload, 0xfb09565b, 0x3631, 0x11d2, 0xbc, 0xb8, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);

/* GUID for default GM/GS dls collection. */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_DefaultGMCollection, 0xf17e8673, 0xc3b4, 0x11d1, 0x87, 0xb, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* GUID to define default synth, placed in AudioPath configuration file. */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Synth_Default,0x26bb9432, 0x45fe, 0x48d3, 0xa3, 0x75, 0x24, 0x72, 0xc5, 0xe3, 0xe7, 0x86);

/* GUIDs to define default buffer configurations to place in AudioPath configuration file. */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Buffer_Reverb,0x186cc541, 0xdb29, 0x11d3, 0x9b, 0xd1, 0x0, 0x80, 0xc7, 0x15, 0xa, 0x74);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Buffer_EnvReverb,0x186cc542, 0xdb29, 0x11d3, 0x9b, 0xd1, 0x0, 0x80, 0xc7, 0x15, 0xa, 0x74);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Buffer_Stereo,0x186cc545, 0xdb29, 0x11d3, 0x9b, 0xd1, 0x0, 0x80, 0xc7, 0x15, 0xa, 0x74);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Buffer_3D_Dry,0x186cc546, 0xdb29, 0x11d3, 0x9b, 0xd1, 0x0, 0x80, 0xc7, 0x15, 0xa, 0x74);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(GUID_Buffer_Mono,0x186cc547, 0xdb29, 0x11d3, 0x9b, 0xd1, 0x0, 0x80, 0xc7, 0x15, 0xa, 0x74);

/* IID's */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicLoader, 0x2ffaaca2, 0x5dca, 0x11d2, 0xaf, 0xa6, 0x0, 0xaa, 0x0, 0x24, 0xd8, 0xb6);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicGetLoader,0x68a04844, 0xd13d, 0x11d1, 0xaf, 0xa6, 0x0, 0xaa, 0x0, 0x24, 0xd8, 0xb6);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicObject,0xd2ac28b5, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicSegment, 0xf96029a2, 0x4282, 0x11d2, 0x87, 0x17, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicSegmentState, 0xa3afdcc7, 0xd3ee, 0x11d1, 0xbc, 0x8d, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicPerformance,0x7d43d03, 0x6523, 0x11d2, 0x87, 0x1d, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicGraph,0x2befc277, 0x5497, 0x11d2, 0xbc, 0xcb, 0x0, 0xa0, 0xc9, 0x22, 0xe6, 0xeb);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicStyle,0xd2ac28bd, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicChordMap,0xd2ac28be, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicComposer,0xd2ac28bf, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicBand,0xd2ac28c0, 0xb39b, 0x11d1, 0x87, 0x4, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Alternate interface IDs, available in DX7 release and after. */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicPerformance2,0x6fc2cae0, 0xbc78, 0x11d2, 0xaf, 0xa6, 0x0, 0xaa, 0x0, 0x24, 0xd8, 0xb6);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicSegment2, 0xd38894d1, 0xc052, 0x11d2, 0x87, 0x2f, 0x0, 0x60, 0x8, 0x93, 0xb1, 0xbd);

/* Interface IDs for DX8 */
/* changed interfaces (GUID only) */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicLoader8, 0x19e7c08c, 0xa44, 0x4e6a, 0xa1, 0x16, 0x59, 0x5a, 0x7c, 0xd5, 0xde, 0x8c);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicPerformance8, 0x679c4137, 0xc62e, 0x4147, 0xb2, 0xb4, 0x9d, 0x56, 0x9a, 0xcb, 0x25, 0x4c);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicSegment8,0xc6784488, 0x41a3, 0x418f, 0xaa, 0x15, 0xb3, 0x50, 0x93, 0xba, 0x42, 0xd4);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicSegmentState8, 0xa50e4730, 0xae4, 0x48a7, 0x98, 0x39, 0xbc, 0x4, 0xbf, 0xe0, 0x77, 0x72);
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicStyle8, 0xfd24ad8a, 0xa260, 0x453d, 0xbf, 0x50, 0x6f, 0x93, 0x84, 0xf7, 0x9, 0x85);
/* new interfaces (GUID + alias) */
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicPatternTrack, 0x51c22e10, 0xb49f, 0x46fc, 0xbe, 0xc2, 0xe6, 0x28, 0x8f, 0xb9, 0xed, 0xe6);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicPatternTrack8 IID_IDirectMusicPatternTrack
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicScript, 0x2252373a, 0x5814, 0x489b, 0x82, 0x9, 0x31, 0xfe, 0xde, 0xba, 0xf1, 0x37); // {2252373A-5814-489b-8209-31FEDEBAF137}
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicScript8 IID_IDirectMusicScript
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicContainer, 0x9301e386, 0x1f22, 0x11d3, 0x82, 0x26, 0xd2, 0xfa, 0x76, 0x25, 0x5d, 0x47);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicContainer8 IID_IDirectMusicContainer
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
DEFINE_GUID(IID_IDirectMusicAudioPath,0xc87631f5, 0x23be, 0x4986, 0x88, 0x36, 0x5, 0x83, 0x2f, 0xcc, 0x48, 0xf9);
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicAudioPath8 IID_IDirectMusicAudioPath
/* unchanged interfaces (alias only) */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicGetLoader8 IID_IDirectMusicGetLoader
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicChordMap8 IID_IDirectMusicChordMap
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicGraph8 IID_IDirectMusicGraph
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicBand8 IID_IDirectMusicBand
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicObject8 IID_IDirectMusicObject
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define IID_IDirectMusicComposer8 IID_IDirectMusicComposer


#if __cplusplus
#endif

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>

