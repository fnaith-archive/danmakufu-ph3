/************************************************************************
*                                                                       *
*   dmusicc.h -- This module defines the DirectMusic core API's         *
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
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include "dsound.h"
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define QWORD_ALIGN(x) (((x) + 7) & ~7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_EVENT_SIZE(cb) QWORD_ALIGN(sizeof(DMUS_EVENTHEADER) + cb)

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack8.h>

#if __cplusplus
#endif



public class _DMUS_BUFFERDESC
{
    public uint dwSize;
    public uint dwFlags;
    public GUID guidBufferFormat = new GUID();
    public uint cbBuffer;
}

/* DMUS_EFFECT_ flags are used in the dwEffectFlags fields of both DMUS_PORTCAPS 
 * and DMUS_PORTPARAMS.
 */

/* For DMUS_PORTCAPS dwClass
 */ 

/* For DMUS_PORTCAPS dwFlags
 */
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


public class _DMUS_PORTCAPS
{
    public uint dwSize;
    public uint dwFlags;
    public GUID guidPort = new GUID();
    public uint dwClass;
    public uint dwType;
    public uint dwMemorySize;
    public uint dwMaxChannelGroups;
    public uint dwMaxVoices;
    public uint dwMaxAudioChannels;
    public uint dwEffectFlags;
    public string wszDescription = new string(new char[DefineConstants.DMUS_MAX_DESCRIPTION]);
}


/* Values for DMUS_PORTCAPS dwType. This field indicates the underlying 
 * driver type of the port.
 */

/* These flags (set in dwValidParams) indicate which other members of the */
/* DMUS_PORTPARAMS are valid. */
/* */

public class _DMUS_PORTPARAMS
{
    public uint dwSize;
    public uint dwValidParams;
    public uint dwVoices;
    public uint dwChannelGroups;
    public uint dwAudioChannels;
    public uint dwSampleRate;
    public uint dwEffectFlags;
    public bool fShare;
}

public class _DMUS_PORTPARAMS8
{
    public uint dwSize;
    public uint dwValidParams;
    public uint dwVoices;
    public uint dwChannelGroups;
    public uint dwAudioChannels;
    public uint dwSampleRate;
    public uint dwEffectFlags;
    public bool fShare;
    public uint dwFeatures;
}




public class _DMUS_SYNTHSTATS
{
    public uint dwSize; // Size in bytes of the structure
    public uint dwValidStats; // Flags indicating which fields below are valid.
    public uint dwVoices; // Average number of voices playing.
    public uint dwTotalCPU; // Total CPU usage as percent * 100.
    public uint dwCPUPerVoice; // CPU per voice as percent * 100.
    public uint dwLostNotes; // Number of notes lost in 1 second.
    public uint dwFreeMemory; // Free memory in bytes
    public int lPeakVolume; // Decibel level * 100.
}

public class _DMUS_SYNTHSTATS8
{
    public uint dwSize; // Size in bytes of the structure
    public uint dwValidStats; // Flags indicating which fields below are valid.
    public uint dwVoices; // Average number of voices playing.
    public uint dwTotalCPU; // Total CPU usage as percent * 100.
    public uint dwCPUPerVoice; // CPU per voice as percent * 100.
    public uint dwLostNotes; // Number of notes lost in 1 second.
    public uint dwFreeMemory; // Free memory in bytes
    public int lPeakVolume; // Decibel level * 100.
    public uint dwSynthMemUse; // Memory used by synth wave data
}

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

public class _DMUS_WAVES_REVERB_PARAMS
{
    public float fInGain; // Input gain in dB (to avoid output overflows)
    public float fReverbMix; /* Reverb mix in dB. 0dB means 100% wet reverb (no direct signal)
                            Negative values gives less wet signal.
                            The coeficients are calculated so that the overall output level stays 
                            (approximately) constant regardless of the ammount of reverb mix. */
    public float fReverbTime; // The reverb decay time, in milliseconds.
    public float fHighFreqRTRatio; /* The ratio of the high frequencies to the global reverb time.
                            Unless very 'splashy-bright' reverbs are wanted, this should be set to 
                            a value < 1.0.
                            For example if dRevTime==1000ms and dHighFreqRTRatio=0.1 than the 
                            decay time for high frequencies will be 100ms.*/

}

/*  Note: Default values for Reverb are:
    fInGain             = 0.0dB   (no change in level)
    fReverbMix          = -10.0dB   (a reasonable reverb mix)
    fReverbTime         = 1000.0ms (one second global reverb time)
    fHighFreqRTRatio    = 0.001    (the ratio of the high frequencies to the global reverb time) 
*/

public enum DMUS_CLOCKTYPE
{
    DMUS_CLOCK_SYSTEM = 0,
    DMUS_CLOCK_WAVE = 1
}


public class _DMUS_CLOCKINFO7
{
    public uint dwSize;
    public DMUS_CLOCKTYPE ctType;
    public GUID guidClock = new GUID(); // Identifies this time source
    public string wszDescription = new string(new char[DefineConstants.DMUS_MAX_DESCRIPTION]);
}

public class _DMUS_CLOCKINFO8
{
    public uint dwSize;
    public DMUS_CLOCKTYPE ctType;
    public GUID guidClock = new GUID(); // Identifies this time source
    public string wszDescription = new string(new char[DefineConstants.DMUS_MAX_DESCRIPTION]);
    public uint dwFlags;
}