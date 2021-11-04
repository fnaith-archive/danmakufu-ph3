/************************************************************************
*                                                                       *
*   dmdls.h -- DLS download definitions for DirectMusic API's           *
*                                                                       *
*   Copyright (c) Microsoft Corporation.  All rights reserved.          *
*                                                                       *
************************************************************************/


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



#if ! MAKE_FOURCC
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define MAKEFOURCC(ch0, ch1, ch2, ch3) ((DWORD)(BYTE)(ch0) | ((DWORD)(BYTE)(ch1) << 8) | ((DWORD)(BYTE)(ch2) << 16) | ((DWORD)(BYTE)(ch3) << 24 ))
#define MAKEFOURCC


// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef uint FOURCC;
#endif

public class _DMUS_DOWNLOADINFO
{
    public uint dwDLType; // Instrument or Wave
    public uint dwDLId; // Unique identifier to tag this download.
    public uint dwNumOffsetTableEntries; // Number of index in the offset address table.
    public uint cbSize; // Total size of this memory chunk.
}


/* Support for oneshot and streaming wave data 
 */


/* Flags for DMUS_INSTRUMENT's ulFlags member */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_INSTRUMENT_GM_INSTRUMENT (1 << 0)

public class _DMUS_OFFSETTABLE
{
    public uint[] ulOffsetTable = new uint[DefineConstants.DMUS_DEFAULT_SIZE_OFFSETTABLE];
}

public class _DMUS_INSTRUMENT
{
    public uint ulPatch;
    public uint ulFirstRegionIdx;
    public uint ulGlobalArtIdx; // If zero the instrument does not have an articulation
    public uint ulFirstExtCkIdx; // If zero no 3rd party entenstion chunks associated with the instrument
    public uint ulCopyrightIdx; // If zero no Copyright information associated with the instrument
    public uint ulFlags;
}

public class _DMUS_REGION
{
    public _RGNRANGE RangeKey = new _RGNRANGE();
    public _RGNRANGE RangeVelocity = new _RGNRANGE();
    public ushort fusOptions;
    public ushort usKeyGroup;
    public uint ulRegionArtIdx; // If zero the region does not have an articulation
    public uint ulNextRegionIdx; // If zero no more regions
    public uint ulFirstExtCkIdx; // If zero no 3rd party entenstion chunks associated with the region
    public _WAVELINK WaveLink = new _WAVELINK();
    public _rwsmp WSMP = new _rwsmp(); //  If WSMP.cSampleLoops > 1 then a WLOOP is included
    public _rloop[] _rloop = Arrays.InitializeWithDefaultInstances<_rloop>(1);
}

public class _DMUS_LFOPARAMS
{
    public int pcFrequency;
    public int tcDelay;
    public int gcVolumeScale;
    public int pcPitchScale;
    public int gcMWToVolume;
    public int pcMWToPitch;
}

public class _DMUS_VEGPARAMS
{
    public int tcAttack;
    public int tcDecay;
    public int ptSustain;
    public int tcRelease;
    public int tcVel2Attack;
    public int tcKey2Decay;
}

public class _DMUS_PEGPARAMS
{
    public int tcAttack;
    public int tcDecay;
    public int ptSustain;
    public int tcRelease;
    public int tcVel2Attack;
    public int tcKey2Decay;
    public int pcRange;
}

public class _DMUS_MSCPARAMS
{
    public int ptDefaultPan;
}

public class _DMUS_ARTICPARAMS
{
    public _DMUS_LFOPARAMS LFO = new _DMUS_LFOPARAMS();
    public _DMUS_VEGPARAMS VolEG = new _DMUS_VEGPARAMS();
    public _DMUS_PEGPARAMS PitchEG = new _DMUS_PEGPARAMS();
    public _DMUS_MSCPARAMS Misc = new _DMUS_MSCPARAMS();
}

public class _DMUS_ARTICULATION // Articulation chunk for DMUS_DOWNLOADINFO_INSTRUMENT format.
{
    public uint ulArt1Idx; // DLS Level 1 articulation chunk
    public uint ulFirstExtCkIdx; // 3rd party extenstion chunks associated with the articulation
}

public class _DMUS_ARTICULATION2 // Articulation chunk for DMUS_DOWNLOADINFO_INSTRUMENT2 format.
{
    public uint ulArtIdx; // DLS Level 1/2 articulation chunk
    public uint ulFirstExtCkIdx; // 3rd party extenstion chunks associated with the articulation
    public uint ulNextArtIdx; // Additional articulation chunks
}

/*  The actual number is determined by cbSize of struct _DMUS_EXTENSIONCHUNK */

public class _DMUS_EXTENSIONCHUNK
{
    public uint cbSize; //  Size of extension chunk
    public uint ulNextExtCkIdx; //  If zero no more 3rd party entenstion chunks
    public uint ExtCkID;
    public byte[] byExtCk = new byte[DefineConstants.DMUS_MIN_DATA_SIZE]; //  The actual number that follows is determined by cbSize
}

/*  The actual number is determined by cbSize of struct _DMUS_COPYRIGHT */

public class _DMUS_COPYRIGHT
{
    public uint cbSize; //  Size of copyright information
    public byte[] byCopyright = new byte[DefineConstants.DMUS_MIN_DATA_SIZE]; //  The actual number that follows is determined by cbSize
}

public class _DMUS_WAVEDATA
{
    public uint cbSize;
    public byte[] byData = new byte[DefineConstants.DMUS_MIN_DATA_SIZE];
}

public class _DMUS_WAVE
{
    public uint ulFirstExtCkIdx; // If zero no 3rd party entenstion chunks associated with the wave
    public uint ulCopyrightIdx; // If zero no Copyright information associated with the wave
    public uint ulWaveDataIdx; // Location of actual wave data.
    public WAVEFORMATEX WaveformatEx = new WAVEFORMATEX();
}

public class _DMUS_NOTERANGE
{
    public uint dwLowNote; // Sets the low note for the range of MIDI note events to which the instrument responds.
    public uint dwHighNote; // Sets the high note for the range of MIDI note events to which the instrument responds.
}

public class _DMUS_WAVEARTDL
{
    public uint ulDownloadIdIdx; // Download ID's of each buffer
    public uint ulBus; // Playback bus
    public uint ulBuffers; // Buffers
    public uint ulMasterDLId; // Download ID of master voice of slave group
    public ushort usOptions; // Same as DLS2 region options
}

public class _DMUS_WAVEDL
{
    public uint cbWaveData; // Bytes of wave data
}



