/*==========================================================================;
//
//  dls1.h
//
//
//  Description:
//
//  Interface defines and structures for the Instrument Collection Form
//  RIFF DLS.
//
//
//  Written by Sonic Foundry 1996.  Released for public use.
//
//=========================================================================*/


/*//////////////////////////////////////////////////////////////////////////
//
//
// Layout of an instrument collection:
//
//
// RIFF [] 'DLS ' [dlid,colh,INSTLIST,WAVEPOOL,INFOLIST]
//
// INSTLIST
// LIST [] 'lins'
//               LIST [] 'ins ' [dlid,insh,RGNLIST,ARTLIST,INFOLIST]
//               LIST [] 'ins ' [dlid,insh,RGNLIST,ARTLIST,INFOLIST]
//               LIST [] 'ins ' [dlid,insh,RGNLIST,ARTLIST,INFOLIST]
//
// RGNLIST
// LIST [] 'lrgn' 
//               LIST [] 'rgn '  [rgnh,wsmp,wlnk,ARTLIST]
//               LIST [] 'rgn '  [rgnh,wsmp,wlnk,ARTLIST]
//               LIST [] 'rgn '  [rgnh,wsmp,wlnk,ARTLIST]
//
// ARTLIST
// LIST [] 'lart'
//         'art1' level 1 Articulation connection graph
//         'art2' level 2 Articulation connection graph
//         '3rd1' Possible 3rd party articulation structure 1
//         '3rd2' Possible 3rd party articulation structure 2 .... and so on
//
// WAVEPOOL 
// ptbl [] [pool table]
// LIST [] 'wvpl'
//               [path],
//               [path],
//               LIST [] 'wave' [dlid,RIFFWAVE]
//               LIST [] 'wave' [dlid,RIFFWAVE]
//               LIST [] 'wave' [dlid,RIFFWAVE]
//               LIST [] 'wave' [dlid,RIFFWAVE]
//               LIST [] 'wave' [dlid,RIFFWAVE]
//
// INFOLIST
// LIST [] 'INFO' 
//               'icmt' 'One of those crazy comments.'
//               'icop' 'Copyright (C) 1996 Sonic Foundry'
//
/////////////////////////////////////////////////////////////////////////*/


/*/////////////////////////////////////////////////////////////////////////
// FOURCC's used in the DLS file
/////////////////////////////////////////////////////////////////////////*/

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

/*/////////////////////////////////////////////////////////////////////////
// Articulation connection graph definitions 
/////////////////////////////////////////////////////////////////////////*/

/* Generic Sources */

/* Midi Controllers 0-127 */

/* Generic Destinations */

/* LFO Destinations */

/* EG1 Destinations */

/* EG2 Destinations */


public class _DLSID
{
  public uint ulData1;
  public ushort usData2;
  public ushort usData3;
  public byte[] abData4 = new byte[8];
}

public class _DLSVERSION
{
  public uint dwVersionMS;
  public uint dwVersionLS;
}


public class _CONNECTION
{
  public ushort usSource;
  public ushort usControl;
  public ushort usDestination;
  public ushort usTransform;
  public int lScale;
}


/* Level 1 Articulation Data */

public class _CONNECTIONLIST
{
  public uint cbSize; // size of the connection list structure
  public uint cConnections; // count of connections in the list
}



/*/////////////////////////////////////////////////////////////////////////
// Generic type defines for regions and instruments
/////////////////////////////////////////////////////////////////////////*/

public class _RGNRANGE
{
  public ushort usLow;
  public ushort usHigh;
}


public class _MIDILOCALE
{
  public uint ulBank;
  public uint ulInstrument;
}

/*/////////////////////////////////////////////////////////////////////////
// Header structures found in an DLS file for collection, instruments, and
// regions.
/////////////////////////////////////////////////////////////////////////*/


public class _RGNHEADER
{
  public _RGNRANGE RangeKey = new _RGNRANGE(); // Key range
  public _RGNRANGE RangeVelocity = new _RGNRANGE(); // Velocity Range
  public ushort fusOptions; // Synthesis options for this range
  public ushort usKeyGroup; // Key grouping for non simultaneous play
                                /* 0 = no group, 1 up is group */
                                /* for Level 1 only groups 1-15 are allowed */
}

public class _INSTHEADER
{
  public uint cRegions; // Count of regions in this instrument
  public _MIDILOCALE Locale = new _MIDILOCALE(); // Intended MIDI locale of this instrument
}

public class _DLSHEADER
{
  public uint cInstruments; // Count of instruments in the collection
}

/*////////////////////////////////////////////////////////////////////////////
// definitions for the Wave link structure
////////////////////////////////////////////////////////////////////////////*/

/* ****  For level 1 only WAVELINK_CHANNEL_MONO is valid  **** */
/* ulChannel allows for up to 32 channels of audio with each bit position */
/* specifiying a channel of playback */



public class _WAVELINK
{ // any paths or links are stored right after struct
  public ushort fusOptions; // options flags for this wave
  public ushort usPhaseGroup; // Phase grouping for locking channels
  public uint ulChannel; // channel placement
  public uint ulTableIndex; // index into the wave pool table, 0 based
}


public class _POOLCUE
{
  public uint ulOffset; // Offset to the entry in the list
}

public class _POOLTABLE
{
  public uint cbSize; // size of the pool table structure
  public uint cCues; // count of cues in the list
}

/*////////////////////////////////////////////////////////////////////////////
// Structures for the "wsmp" chunk
////////////////////////////////////////////////////////////////////////////*/



public class _rwsmp
{
  public uint cbSize;
  public ushort usUnityNote; // MIDI Unity Playback Note
  public short sFineTune; // Fine Tune in log tuning
  public int lAttenuation; // Overall Attenuation to be applied to data
  public uint fulOptions; // Flag options
  public uint cSampleLoops; // Count of Sample loops, 0 loops is one shot
}


/* This loop type is a normal forward playing loop which is continually */
/* played until the envelope reaches an off threshold in the release */
/* portion of the volume envelope */


public class _rloop
{
  public uint cbSize;
  public uint ulType; // Loop Type
  public uint ulStart; // Start of loop in samples
  public uint ulLength; // Length of loop in samples
}


