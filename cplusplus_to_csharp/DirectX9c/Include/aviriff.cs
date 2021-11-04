// ------------------------------------------------------------------------------
// File: AVIRIFF.h
// 
// Desc: Structures and defines for the RIFF AVI file format extended to
//       handle very large/long files.
// 
// Copyright (c) 1996-2001, Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------------------------

// Disable some compiler warnings
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable: 4097 4511 4512 4514 4705)


#if ! AVIRIFF_H
#define AVIRIFF_H

#if ! NUMELMS
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define NUMELMS(aa) (sizeof(aa)/sizeof((aa)[0]))
  #define NUMELMS
#endif

// all structures in this file are packed on word boundaries
// 
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack2.h>

/*
 * heres the general layout of an AVI riff file (new format)
 *
 * RIFF (3F??????) AVI       <- not more than 1 GB in size
 *     LIST (size) hdrl
 *         avih (0038)
 *         LIST (size) strl
 *             strh (0038)
 *             strf (????)
 *             indx (3ff8)   <- size may vary, should be sector sized
 *         LIST (size) strl
 *             strh (0038)
 *             strf (????)
 *             indx (3ff8)   <- size may vary, should be sector sized
 *         LIST (size) odml
 *             dmlh (????)
 *         JUNK (size)       <- fill to align to sector - 12
 *     LIST (7f??????) movi  <- aligned on sector - 12
 *         00dc (size)       <- sector aligned
 *         01wb (size)       <- sector aligned
 *         ix00 (size)       <- sector aligned
 *     idx1 (00??????)       <- sector aligned
 * RIFF (7F??????) AVIX
 *     JUNK (size)           <- fill to align to sector -12
 *     LIST (size) movi
 *         00dc (size)       <- sector aligned
 * RIFF (7F??????) AVIX      <- not more than 2GB in size
 *     JUNK (size)           <- fill to align to sector - 12
 *     LIST (size) movi
 *         00dc (size)       <- sector aligned
 *
 *-===================================================================*/

// 
// structures for manipulating RIFF headers
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define FCC(ch4) ((((DWORD)(ch4) & 0xFF) << 24) | (((DWORD)(ch4) & 0xFF00) << 8) | (((DWORD)(ch4) & 0xFF0000) >> 8) | (((DWORD)(ch4) & 0xFF000000) >> 24))
#define FCC

public class _riffchunk
{
   public FOURCC fcc = new FOURCC();
   public uint cb;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _riffchunk RIFFCHUNK;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _riffchunk * LPRIFFCHUNK;
public class _rifflist
{
   public FOURCC fcc = new FOURCC();
   public uint cb;
   public FOURCC fccListType = new FOURCC();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _rifflist RIFFLIST;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _rifflist * LPRIFFLIST;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RIFFROUND(cb) ((cb) + ((cb)&1))
#define RIFFROUND
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define RIFFNEXT(pChunk) (LPRIFFCHUNK)((LPBYTE)(pChunk) + sizeof(RIFFCHUNK) + RIFFROUND(((LPRIFFCHUNK)pChunk)->cb))
#define RIFFNEXT


// 
// ==================== avi header structures ===========================
// 

// main header for the avi file (compatibility header)
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidMAINAVIHEADER FCC('avih')
#define ckidMAINAVIHEADER
public class _avimainheader
{
    public FOURCC fcc = new FOURCC(); // 'avih'
    public uint cb; // size of this structure -8
    public uint dwMicroSecPerFrame; // frame display rate (or 0L)
    public uint dwMaxBytesPerSec; // max. transfer rate
    public uint dwPaddingGranularity; // pad to multiples of this size; normally 2K.
    public uint dwFlags; // the ever-present flags
    public const int AVIF_HASINDEX = 0x00000010; // Index at end of file?
    public const int AVIF_MUSTUSEINDEX = 0x00000020;
    public const int AVIF_ISINTERLEAVED = 0x00000100;
    public const int AVIF_TRUSTCKTYPE = 0x00000800; // Use CKType to find key frames
    public const int AVIF_WASCAPTUREFILE = 0x00010000;
    public const int AVIF_COPYRIGHTED = 0x00020000;
    public uint dwTotalFrames; // # frames in first movi list
    public uint dwInitialFrames;
    public uint dwStreams;
    public uint dwSuggestedBufferSize;
    public uint dwWidth;
    public uint dwHeight;
    public uint[] dwReserved = new uint[4];
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avimainheader AVIMAINHEADER;

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidODML FCC('odml')
#define ckidODML
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidAVIEXTHEADER FCC('dmlh')
#define ckidAVIEXTHEADER
public class _aviextheader
{
   public FOURCC fcc = new FOURCC(); // 'dmlh'
   public uint cb; // size of this structure -8
   public uint dwGrandFrames; // total number of frames in the file
   public uint[] dwFuture = new uint[61]; // to be defined later
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _aviextheader AVIEXTHEADER;

// 
// structure of an AVI stream header riff chunk
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidSTREAMLIST FCC('strl')
#define ckidSTREAMLIST

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidSTREAMHEADER FCC('strh')
#define ckidSTREAMHEADER
public class _avistreamheader
{
   public FOURCC fcc = new FOURCC(); // 'strh'
   public uint cb; // size of this structure - 8

   public FOURCC fccType = new FOURCC(); // stream type codes

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define streamtypeVIDEO FCC('vids')
   #define streamtypeVIDEO
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define streamtypeAUDIO FCC('auds')
   #define streamtypeAUDIO
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define streamtypeMIDI FCC('mids')
   #define streamtypeMIDI
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define streamtypeTEXT FCC('txts')
   #define streamtypeTEXT

   public FOURCC fccHandler = new FOURCC();
   public uint dwFlags;
   public const int AVISF_DISABLED = 0x00000001;
   public const int AVISF_VIDEO_PALCHANGES = 0x00010000;

   public ushort wPriority;
   public ushort wLanguage;
   public uint dwInitialFrames;
   public uint dwScale;
   public uint dwRate; // dwRate/dwScale is stream tick rate in ticks/sec
   public uint dwStart;
   public uint dwLength;
   public uint dwSuggestedBufferSize;
   public uint dwQuality;
   public uint dwSampleSize;
// C++ TO C# CONVERTER NOTE: Classes must be named in C#, so the following class has been named by the converter:
   public class AnonymousClass
   {
      public short left;
      public short top;
      public short right;
      public short bottom;
   }
      public AnonymousClass rcFrame = new AnonymousClass();
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avistreamheader AVISTREAMHEADER;


// 
// structure of an AVI stream format chunk
// 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidSTREAMFORMAT FCC('strf')
#define ckidSTREAMFORMAT
// 
// avi stream formats are different for each stream type
// 
// BITMAPINFOHEADER for video streams
// WAVEFORMATEX or PCMWAVEFORMAT for audio streams
// nothing for text streams
// nothing for midi streams


// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning(disable:4200)
// 
// structure of old style AVI index
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidAVIOLDINDEX FCC('idx1')
#define ckidAVIOLDINDEX
public class _avioldindex
{
   public FOURCC fcc = new FOURCC(); // 'idx1'
   public uint cb; // size of this structure -8
   public class _avioldindex_entry
   {
      public uint dwChunkId;
      public uint dwFlags;

      public const int AVIIF_LIST = 0x00000001;
      public const int AVIIF_KEYFRAME = 0x00000010;

      public const int AVIIF_NO_TIME = 0x00000100;
      public const int AVIIF_COMPRESSOR = 0x0FFF0000; // unused?
      public uint dwOffset; // offset of riff chunk header for the data
      public uint dwSize; // size of the data (excluding riff header size)
   }
      public _avioldindex_entry[] aIndex; // size of this array
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avioldindex AVIOLDINDEX;


// 
// ============ structures for timecode in an AVI file =================
// 


// defined
// timecode time structure
// 
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
// union _timecode
// {
//   struct
//   {
//      ushort wFrameRate;
//      ushort wFrameFract;
//      int cFrames;
//      };
//   ulong qw;
//   };


#define TIMECODE_RATE_30DROP

// struct for all the SMPTE timecode info
// 
public class _timecodedata
{
   public TIMECODE time = new TIMECODE();
   public uint dwSMPTEflags;
   public uint dwUser;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _timecodedata TIMECODEDATA;

// dwSMPTEflags masks/values
// 
#define TIMECODE_SMPTE_BINARY_GROUP
#define TIMECODE_SMPTE_COLOR_FRAME

// 
// ============ structures for new style AVI indexes =================
// 

// index type codes
// 
#define AVI_INDEX_OF_INDEXES
#define AVI_INDEX_OF_CHUNKS
#define AVI_INDEX_OF_TIMED_CHUNKS
#define AVI_INDEX_OF_SUB_2FIELD
#define AVI_INDEX_IS_DATA

// index subtype codes
// 
#define AVI_INDEX_SUB_DEFAULT

// INDEX_OF_CHUNKS subtype codes
// 
#define AVI_INDEX_SUB_2FIELD

// meta structure of all avi indexes
// 
public class _avimetaindex
{
   public FOURCC fcc = new FOURCC();
   public uint cb;
   public ushort wLongsPerEntry;
   public byte bIndexSubType;
   public byte bIndexType;
   public uint nEntriesInUse;
   public uint dwChunkId;
   public uint[] dwReserved = new uint[3];
   public uint[] adwIndex;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avimetaindex AVIMETAINDEX;

#define STDINDEXSIZE
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define NUMINDEX(wLongsPerEntry) ((STDINDEXSIZE-32)/4/(wLongsPerEntry))
#define NUMINDEX
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define NUMINDEXFILL(wLongsPerEntry) ((STDINDEXSIZE/4) - NUMINDEX(wLongsPerEntry))
#define NUMINDEXFILL

// structure of a super index (INDEX_OF_INDEXES)
// 
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define ckidAVISUPERINDEX FCC('indx')
#define ckidAVISUPERINDEX
public class _avisuperindex
{
   public FOURCC fcc = new FOURCC(); // 'indx'
   public uint cb; // size of this structure
   public ushort wLongsPerEntry; // ==4
   public byte bIndexSubType; // ==0 (frame index) or AVI_INDEX_SUB_2FIELD
   public byte bIndexType; // ==AVI_INDEX_OF_INDEXES
   public uint nEntriesInUse; // offset of next unused entry in aIndex
   public uint dwChunkId; // chunk ID of chunks being indexed, (i.e. RGB8)
   public uint[] dwReserved = new uint[3]; // must be 0
   public class _avisuperindex_entry
   {
      public ulong qwOffset; // 64 bit offset to sub index chunk
      public uint dwSize; // 32 bit size of sub index chunk
      public uint dwDuration; // time span of subindex chunk (in stream ticks)
   }
// C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
      aIndex[((DefineConstants.STDINDEXSIZE-32) / 4 / (4))];
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avisuperindex AVISUPERINDEX;
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define Valid_SUPERINDEX(pi) (*(DWORD *)(&((pi)->wLongsPerEntry)) == (4 | (AVI_INDEX_OF_INDEXES << 24)))
#define Valid_SUPERINDEX

// struct of a standard index (AVI_INDEX_OF_CHUNKS)
// 
public class _avistdindex_entry
{
   public uint dwOffset; // 32 bit offset to data (points to data, not riff header)
   public uint dwSize; // 31 bit size of data (does not include size of riff header), bit 31 is deltaframe bit
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avistdindex_entry AVISTDINDEX_ENTRY;
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define AVISTDINDEX_DELTAFRAME ( 0x80000000)
#define AVISTDINDEX_DELTAFRAME // Delta frames have the high bit set
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define AVISTDINDEX_SIZEMASK (~0x80000000)
#define AVISTDINDEX_SIZEMASK

public class _avistdindex
{
   public FOURCC fcc = new FOURCC(); // 'indx' or '##ix'
   public uint cb; // size of this structure
   public ushort wLongsPerEntry; // ==2
   public byte bIndexSubType; // ==0
   public byte bIndexType; // ==AVI_INDEX_OF_CHUNKS
   public uint nEntriesInUse; // offset of next unused entry in aIndex
   public uint dwChunkId; // chunk ID of chunks being indexed, (i.e. RGB8)
   public ulong qwBaseOffset; // base offset that all index intries are relative to
   public uint dwReserved_3; // must be 0
   _avistdindex_entry aIndex[((DefineConstants.STDINDEXSIZE-32) / 4 / (2))];
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avistdindex AVISTDINDEX;

// struct of a time variant standard index (AVI_INDEX_OF_TIMED_CHUNKS)
// 
public class _avitimedindex_entry
{
   public uint dwOffset; // 32 bit offset to data (points to data, not riff header)
   public uint dwSize; // 31 bit size of data (does not include size of riff header) (high bit is deltaframe bit)
   public uint dwDuration; // how much time the chunk should be played (in stream ticks)
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avitimedindex_entry AVITIMEDINDEX_ENTRY;

public class _avitimedindex
{
   public FOURCC fcc = new FOURCC(); // 'indx' or '##ix'
   public uint cb; // size of this structure
   public ushort wLongsPerEntry; // ==3
   public byte bIndexSubType; // ==0
   public byte bIndexType; // ==AVI_INDEX_OF_TIMED_CHUNKS
   public uint nEntriesInUse; // offset of next unused entry in aIndex
   public uint dwChunkId; // chunk ID of chunks being indexed, (i.e. RGB8)
   public ulong qwBaseOffset; // base offset that all index intries are relative to
   public uint dwReserved_3; // must be 0
   _avitimedindex_entry aIndex[((DefineConstants.STDINDEXSIZE-32) / 4 / (3))];
   uint adwTrailingFill[((DefineConstants.STDINDEXSIZE / 4) - ((DefineConstants.STDINDEXSIZE-32) / 4 / (3)))]; // to align struct to correct size
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avitimedindex AVITIMEDINDEX;

// structure of a timecode stream
// 
public class _avitimecodeindex
{
   public FOURCC fcc = new FOURCC(); // 'indx' or '##ix'
   public uint cb; // size of this structure
   public ushort wLongsPerEntry; // ==4
   public byte bIndexSubType; // ==0
   public byte bIndexType; // ==AVI_INDEX_IS_DATA
   public uint nEntriesInUse; // offset of next unused entry in aIndex
   public uint dwChunkId; // 'time'
   public uint[] dwReserved = new uint[3]; // must be 0
   _timecodedata aIndex[((DefineConstants.STDINDEXSIZE-32) / 4 / (sizeof(_timecodedata) / sizeof(int)))];
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avitimecodeindex AVITIMECODEINDEX;

// structure of a timecode discontinuity list (when wLongsPerEntry == 7)
// 
public class _avitcdlindex_entry
{
    public uint dwTick; // stream tick time that maps to this timecode value
    public TIMECODE time = new TIMECODE();
    public uint dwSMPTEflags;
    public uint dwUser;
    public string szReelId = new string(new char[12]);
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avitcdlindex_entry AVITCDLINDEX_ENTRY;

public class _avitcdlindex
{
   public FOURCC fcc = new FOURCC(); // 'indx' or '##ix'
   public uint cb; // size of this structure
   public ushort wLongsPerEntry; // ==7 (must be 4 or more all 'tcdl' indexes
   public byte bIndexSubType; // ==0
   public byte bIndexType; // ==AVI_INDEX_IS_DATA
   public uint nEntriesInUse; // offset of next unused entry in aIndex
   public uint dwChunkId; // 'tcdl'
   public uint[] dwReserved = new uint[3]; // must be 0
   _avitcdlindex_entry aIndex[((DefineConstants.STDINDEXSIZE-32) / 4 / (7))];
   uint adwTrailingFill[((DefineConstants.STDINDEXSIZE / 4) - ((DefineConstants.STDINDEXSIZE-32) / 4 / (7)))]; // to align struct to correct size
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avitcdlindex AVITCDLINDEX;

public class _avifieldindex_chunk
{
   public FOURCC fcc = new FOURCC(); // 'ix##'
   public uint cb; // size of this structure
   public ushort wLongsPerEntry; // must be 3 (size of each entry in
                               // aIndex array)
   public byte bIndexSubType; // AVI_INDEX_2FIELD
   public byte bIndexType; // AVI_INDEX_OF_CHUNKS
   public uint nEntriesInUse;
   public uint dwChunkId; // '##dc' or '##db'
   public ulong qwBaseOffset; // offsets in aIndex array are relative to this
   public uint dwReserved3; // must be 0
   public class _avifieldindex_entry
   {
      public uint dwOffset;
      public uint dwSize; // size of all fields
                               // (bit 31 set for NON-keyframes)
      public uint dwOffsetField2; // offset to second field
   }
   public _avifieldindex_entry[] aIndex;
}
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avifieldindex_chunk AVIFIELDINDEX;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// typedef _avifieldindex_chunk * PAVIFIELDINDEX;


// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>

#endif
