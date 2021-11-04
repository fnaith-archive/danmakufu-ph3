/************************************************************************
*                                                                       *
*   dmusicf.h -- This module defines the DirectMusic file formats       *
*                                                                       *
*   Copyright (c) Microsoft Corporation.  All rights reserved.          *
*                                                                       *
************************************************************************/




// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <mmsystem.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack8.h>

#if __cplusplus
#endif

/* Common chunks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_GUID_CHUNK mmioFOURCC('g','u','i','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_INFO_LIST mmioFOURCC('I','N','F','O')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_UNFO_LIST mmioFOURCC('U','N','F','O')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_UNAM_CHUNK mmioFOURCC('U','N','A','M')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_UART_CHUNK mmioFOURCC('U','A','R','T')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_UCOP_CHUNK mmioFOURCC('U','C','O','P')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_USBJ_CHUNK mmioFOURCC('U','S','B','J')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_UCMT_CHUNK mmioFOURCC('U','C','M','T')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CATEGORY_CHUNK mmioFOURCC('c','a','t','g')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_VERSION_CHUNK mmioFOURCC('v','e','r','s')

/* The following structures are used by the Tracks, and are the packed structures */
/* that are passed to the Tracks inside the IStream. */


public class _DMUS_IO_SEQ_ITEM
{
    public MUSIC_TIME mtTime = new MUSIC_TIME();
    public MUSIC_TIME mtDuration = new MUSIC_TIME();
    public uint dwPChannel;
    public short nOffset;
    public byte bStatus;
    public byte bByte1;
    public byte bByte2;
}


public class _DMUS_IO_CURVE_ITEM
{
    public MUSIC_TIME mtStart = new MUSIC_TIME();
    public MUSIC_TIME mtDuration = new MUSIC_TIME();
    public MUSIC_TIME mtResetDuration = new MUSIC_TIME();
    public uint dwPChannel;
    public short nOffset;
    public short nStartValue;
    public short nEndValue;
    public short nResetValue;
    public byte bType;
    public byte bCurveShape;
    public byte bCCData;
    public byte bFlags;
    /* Following was added for DX8. */
    public ushort wParamType; // RPN or NRPN parameter number.
    public ushort wMergeIndex; // Allows multiple parameters to be merged (pitchbend, volume, and expression.)
}


public class _DMUS_IO_TEMPO_ITEM
{
    public MUSIC_TIME lTime = new MUSIC_TIME();
    public double dblTempo;
}


public class _DMUS_IO_SYSEX_ITEM
{
    public MUSIC_TIME mtTime = new MUSIC_TIME();
    public uint dwPChannel;
    public uint dwSysExLength;
}


public class _DMUS_RHYTHM_PARAM
{
    public DMUS_TIMESIGNATURE TimeSig = new DMUS_TIMESIGNATURE();
    public uint dwRhythmPattern;
}

public class _DMUS_TEMPO_PARAM
{
    public MUSIC_TIME mtTime = new MUSIC_TIME();
    public double dblTempo;
}


public class _DMUS_MUTE_PARAM
{
    public uint dwPChannel;
    public uint dwPChannelMap;
    public bool fMute;
}

/* Style chunks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_STYLE_FORM mmioFOURCC('D','M','S','T')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_STYLE_CHUNK mmioFOURCC('s','t','y','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PART_LIST mmioFOURCC('p','a','r','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PART_CHUNK mmioFOURCC('p','r','t','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_NOTE_CHUNK mmioFOURCC('n','o','t','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CURVE_CHUNK mmioFOURCC('c','r','v','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_MARKER_CHUNK mmioFOURCC('m','r','k','r')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_RESOLUTION_CHUNK mmioFOURCC('r','s','l','n')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_ANTICIPATION_CHUNK mmioFOURCC('a','n','p','n')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PATTERN_LIST mmioFOURCC('p','t','t','n')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PATTERN_CHUNK mmioFOURCC('p','t','n','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_RHYTHM_CHUNK mmioFOURCC('r','h','t','m')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARTREF_LIST mmioFOURCC('p','r','e','f')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARTREF_CHUNK mmioFOURCC('p','r','f','c')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_STYLE_PERS_REF_LIST mmioFOURCC('p','r','r','f')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_MOTIFSETTINGS_CHUNK mmioFOURCC('m','t','f','s')

/* Flags used by variations: these make up the DWORDs in dwVariationChoices.               */

/* These flags determine the types of chords supported by a given variation in DirectMusic */
/* mode.  The first seven flags (bits 1-7) are set if the variation supports major chords  */
/* rooted in scale positions, so, e.g., if bits 1, 2, and 4 are set, the variation         */
/* supports major chords rooted in the tonic, second, and fourth scale positions.  The     */
/* next seven flags serve the same purpose, but for minor chords, and the following seven  */
/* flags serve the same purpose for chords that are not major or minor (e.g., SUS 4        */
/* chords).  Bits 22, 23, and 24 are set if the variation supports chords rooted in the    */
/* scale, chords rooted sharp of scale tones, and chords rooted flat of scale tones,       */
/* respectively.  For example, to support a C# minor chord in the scale of C Major,        */
/* bits 8 (for tonic minor) and 24 (for sharp) need to be set.  Bits 25, 26, an 27 handle  */
/* chords that are triads, 6th or 7th chords, and chords with extensions, respectively.    */
/* bits 28 and 29 handle chords that are followed by tonic and dominant chords,            */
/* respectively.                                                                           */

/* legacy mask for variation modes */
/* Bits 29 and 31 of the variation flags are the Mode bits.  If both are 0, it's IMA. */  
/* If bit 29 is 1, it's Direct Music. */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_VARIATIONF_MODES_EX (0x20000000 | 0x80000000)

/* Set this if the part uses marker events */
/* Set this if the part is allowed to switch only on chord-aligned markers */

/* These specify if the marker event signals whether to stop a variation or start a 
pattern/variation (or both), and whether new variations must align with a chord */

/* if this flag is set, variation settings in a playing pattern-based track's state data will 
persist in the track after it stops playing */

/* These specify possible values for DMUS_IO_PARTREF.bRandomVariation
   all but DMUS_VARIATIONT_SEQUENTIAL and DMUS_VARIATIONT_RANDOM are dx8. */
public enum enumDMUS_VARIATIONT_TYPES
{
    DMUS_VARIATIONT_SEQUENTIAL = 0, // Play sequential starting with variation 1.
    DMUS_VARIATIONT_RANDOM = 1, // Play randomly.
    DMUS_VARIATIONT_RANDOM_START = 2, // Play sequential starting with a random variation.
    DMUS_VARIATIONT_NO_REPEAT = 3, // Play randomly, but don't play the same variation twice.
    DMUS_VARIATIONT_RANDOM_ROW = 4 // Play randomly as a row: don't repeat any variation until all have played.
}

/* These specify possible values for DMUS_IO_PATTERN.wEmbellishment (dx8) */
public enum enumDMUS_EMBELLISHT_TYPES
{
    DMUS_EMBELLISHT_NORMAL = 0,
    DMUS_EMBELLISHT_FILL = 1,
    DMUS_EMBELLISHT_BREAK = 2,
    DMUS_EMBELLISHT_INTRO = 4,
    DMUS_EMBELLISHT_END = 8,
    DMUS_EMBELLISHT_MOTIF = 16,
    DMUS_EMBELLISHT_ALL = 0xFFFF
}

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack(2)

public class _DMUS_IO_TIMESIG
{
    /* Time signatures define how many beats per measure, which note receives */
    /* the beat, and the grid resolution. */
    public byte bBeatsPerMeasure; // beats per measure (top of time sig)
    public byte bBeat; // what note receives the beat (bottom of time sig.)
                                /* we can assume that 0 means 256th note */
    public ushort wGridsPerBeat; // grids per beat
}

public class _DMUS_IO_STYLE
{
    public _DMUS_IO_TIMESIG timeSig = new _DMUS_IO_TIMESIG(); // Styles have a default Time Signature
    public double dblTempo;
}

public class _DMUS_IO_VERSION
{
    public uint dwVersionMS; // Version # high-order 32 bits
    public uint dwVersionLS; // Version # low-order 32 bits
}

public class _DMUS_IO_PATTERN
{
    public _DMUS_IO_TIMESIG timeSig = new _DMUS_IO_TIMESIG(); // Patterns can override the Style's Time sig.
    public byte bGrooveBottom; // bottom of groove range
    public byte bGrooveTop; // top of groove range
    public ushort wEmbellishment; // Fill, Break, Intro, End, Normal, Motif
    public ushort wNbrMeasures; // length in measures
    public byte bDestGrooveBottom; // bottom of groove range for next pattern
    public byte bDestGrooveTop; // top of groove range for next pattern
    public uint dwFlags; // various flags
}

public class _DMUS_IO_STYLEPART
{
    public _DMUS_IO_TIMESIG timeSig = new _DMUS_IO_TIMESIG(); // can override pattern's
    public uint[] dwVariationChoices = new uint[32]; // MOAW choice bitfield
    public GUID guidPartID = new GUID(); // identifies the part
    public ushort wNbrMeasures; // length of the Part
    public byte bPlayModeFlags; // see PLAYMODE flags
    public byte bInvertUpper; // inversion upper limit
    public byte bInvertLower; // inversion lower limit
    public byte[] bPad = new byte[3]; // for DWORD alignment
    public uint dwFlags; // various flags
}

public class _DMUS_IO_PARTREF
{
    public GUID guidPartID = new GUID(); // unique ID for matching up with parts
    public ushort wLogicalPartID; // corresponds to port/device/midi channel OBSOLETE
    public byte bVariationLockID; // parts with the same ID lock variations.
                                /* high bit is used to identify master Part */
    public byte bSubChordLevel; // tells which sub chord level this part wants
    public byte bPriority; // 256 priority levels. Parts with lower priority
                                /* aren't played first when a device runs out of */
                                /* notes */
    public byte bRandomVariation; // when set, matching variations play in random order
                                /* when clear, matching variations play sequentially */
    public ushort wPad; // not used
    public uint dwPChannel; // replaces wLogicalPartID
}

public class _DMUS_IO_STYLENOTE
{
    public MUSIC_TIME mtGridStart = new MUSIC_TIME(); // when this note occurs
    public uint dwVariation; // variation bits
    public MUSIC_TIME mtDuration = new MUSIC_TIME(); // how long this note lasts
    public short nTimeOffset; // offset from mtGridStart
    public ushort wMusicValue; // Position in scale.
    public byte bVelocity; // Note velocity.
    public byte bTimeRange; // Range to randomize start time.
    public byte bDurRange; // Range to randomize duration.
    public byte bVelRange; // Range to randomize velocity.
    public byte bInversionID; // Identifies inversion group to which this note belongs
    public byte bPlayModeFlags; // Can override part
    /* Following exists only under DX8 and on */
    public byte bNoteFlags; // values from DMUS_NOTEF_FLAGS
}

public class _DMUS_IO_STYLECURVE
{
    public MUSIC_TIME mtGridStart = new MUSIC_TIME(); // when this curve occurs
    public uint dwVariation; // variation bits
    public MUSIC_TIME mtDuration = new MUSIC_TIME(); // how long this curve lasts
    public MUSIC_TIME mtResetDuration = new MUSIC_TIME(); // how long after the end of the curve to reset the curve
    public short nTimeOffset; // offset from mtGridStart
    public short nStartValue; // curve's start value
    public short nEndValue; // curve's end value
    public short nResetValue; // the value to which to reset the curve
    public byte bEventType; // type of curve
    public byte bCurveShape; // shape of curve
    public byte bCCData; // CC#
    public byte bFlags; /* Bit 1=TRUE means to send nResetValue. Otherwise, don't.
                                   Other bits are reserved. */
    /*  Following was added for DX8. */
    public ushort wParamType; // RPN or NRPN parameter number.
    public ushort wMergeIndex; // Allows multiple parameters to be merged (pitchbend, volume, and expression.)
}

public class _DMUS_IO_STYLEMARKER
{
    public MUSIC_TIME mtGridStart = new MUSIC_TIME(); // when this marker occurs
    public uint dwVariation; // variation bits
    public ushort wMarkerFlags; // how the marker is used
}

public class _DMUS_IO_STYLERESOLUTION
{
    public uint dwVariation; // variation bits
    public ushort wMusicValue; // Position in scale.
    public byte bInversionID; // Identifies inversion group to which this note belongs
    public byte bPlayModeFlags; // Can override part
}

public class _DMUS_IO_STYLE_ANTICIPATION
{
    public MUSIC_TIME mtGridStart = new MUSIC_TIME(); // when this anticipation occurs
    public uint dwVariation; // variation bits
    public short nTimeOffset; // offset from mtGridStart
    public byte bTimeRange; // Range to randomize start time.
}

public class _DMUS_IO_MOTIFSETTINGS
{
    public uint dwRepeats; // Number of repeats. By default, 0.
    public MUSIC_TIME mtPlayStart = new MUSIC_TIME(); // Start of playback. By default, 0.
    public MUSIC_TIME mtLoopStart = new MUSIC_TIME(); // Start of looping portion. By default, 0.
    public MUSIC_TIME mtLoopEnd = new MUSIC_TIME(); // End of loop. Must be greater than mtLoopStart. Or, 0, indicating loop full motif.
    public uint dwResolution; // Default resolution.
}

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma pack()


/*
RIFF
(
    'DMST'          // Style
    <styh-ck>       // Style header chunk
    <guid-ck>       // Every Style has a GUID
    [<UNFO-list>]   // Name, author, copyright info., comments
    [<vers-ck>]     // version chunk
    <part-list>...  // Array of parts in the Style, used by patterns
    <pttn-list>...  // Array of patterns in the Style
    <DMBD-form>...  // Array of bands in the Style
    [<prrf-list>]...// Optional array of chord map references in the Style
)

    // <styh-ck>
    styh
    (
        <DMUS_IO_STYLE>
    )

    // <guid-ck>
    guid
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    // <part-list>
    LIST
    (
        'part'
        <prth-ck>       // Part header chunk
        [<UNFO-list>]   // Name, author, copyright info., comments
        [<note-ck>]     // Optional chunk containing an array of notes in Part
        [<crve-ck>]     // Optional chunk containing an array of curves in Part
        [<mrkr-ck>]     // Optional chunk containing an array of markers in Part
        [<rsln-ck>]     // Optional chunk containing an array of variation resolutions in Part
        [<anpn-ck>]     // Optional chunk containing an array of resolution anticipations in Part
    )

        // <orth-ck>
        prth
        (
            <DMUS_IO_STYLEPART>
        )

        // <note-ck>
        'note'
        (
            // sizeof DMUS_IO_STYLENOTE:DWORD
            <DMUS_IO_STYLENOTE>...
        )

        // <crve-ck>
        'crve'
        (
            // sizeof DMUS_IO_STYLECURVE:DWORD
            <DMUS_IO_STYLECURVE>...
        )

        // <mrkr-ck>
        'mrkr'
        (
            // sizeof DMUS_IO_STYLEMARKER:DWORD
            <DMUS_IO_STYLEMARKER>...
        )

        // <rsln-ck>
        'rsln'
        (
            // sizeof DMUS_IO_STYLERESOLUTION:DWORD
            <DMUS_IO_STYLERESOLUTION>...
        )

        // <anpn-ck>
        'anpn'
        (
            // sizeof DMUS_IO_STYLE_ANTICIPATION:DWORD
            <DMUS_IO_STYLE_ANTICIPATION>...
        )

    // <pttn-list>
    LIST
    (
        'pttn'
        <ptnh-ck>       // Pattern header chunk
        <rhtm-ck>       // Chunk containing an array of rhythms for chord matching
        [<UNFO-list>]   // Name, author, copyright info., comments
        [<mtfs-ck>]     // Motif settings chunk
        [<DMBD-form>]   // Optional band to be associated with the pattern (for motifs)
        <pref-list>...  // Array of part reference id's
    )

        // <ptnh-ck>
        ptnh
        (
            <DMUS_IO_PATTERN>
        )

        // <rhtm-ck>
        'rhtm'
        (
            // DWORD's representing rhythms for chord matching based on number
            // of measures in the pattern
        )


        // pref-list
        LIST
        (
            'pref'
            <prfc-ck>   // part ref chunk
        )

        // <prfc-ck>
        prfc
        (
            <DMUS_IO_PARTREF>
        )

        // <mtfs-ck>
        mtfs
        (
            <DMUS_IO_MOTIFSETTINGS>
        )

    // <prrf-list>
    LIST
    (
        'prrf'
        <DMRF-list>... // Array of Chordmap references
    )
*/

/* Pattern chunk, for use in Pattern tracks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PATTERN_FORM mmioFOURCC('D','M','P','T')

/*
RIFF
(
    'DMPT'          // Pattern
    <styh-ck>       // Style header chunk
    <pttn-list>     // The pattern, in single pattern format (includes DMUS_FOURCC_PART_LIST chunks)
)
*/


/* Chord and command file formats */

/* These specify possible values for DMUS_IO_COMMAND.bRepeatMode (dx8) */
public enum enumDMUS_PATTERNT_TYPES
{
    DMUS_PATTERNT_RANDOM = 0, // Play randomly. (dx7 behavior)
    DMUS_PATTERNT_REPEAT = 1, // Repeat last pattern.
    DMUS_PATTERNT_SEQUENTIAL = 2, // Play sequential starting with first matching pattern.
    DMUS_PATTERNT_RANDOM_START = 3, // Play sequential starting with a random pattern.
    DMUS_PATTERNT_NO_REPEAT = 4, // Play randomly, but don't play the same pattern twice.
    DMUS_PATTERNT_RANDOM_ROW = 5 // Play randomly as a row: don't repeat any pattern until all have played.
}


// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDTRACK_LIST mmioFOURCC('c','o','r','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDTRACKHEADER_CHUNK mmioFOURCC('c','r','d','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDTRACKBODY_CHUNK mmioFOURCC('c','r','d','b')

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_COMMANDTRACK_CHUNK mmioFOURCC('c','m','n','d')

public class _DMUS_IO_CHORD
{
    public string wszName = new string(new char[16]); // Name of the chord
    public MUSIC_TIME mtTime = new MUSIC_TIME(); // Time of this chord
    public ushort wMeasure; // Measure this falls on
    public byte bBeat; // Beat this falls on
    public byte bFlags; // Various flags
}

public class _DMUS_IO_SUBCHORD
{
    public uint dwChordPattern; // Notes in the subchord
    public uint dwScalePattern; // Notes in the scale
    public uint dwInversionPoints; // Where inversions can occur
    public uint dwLevels; // Which levels are supported by this subchord
    public byte bChordRoot; // Root of the subchord
    public byte bScaleRoot; // Root of the scale
}

public class _DMUS_IO_COMMAND
{
    public MUSIC_TIME mtTime = new MUSIC_TIME(); // Time of this command
    public ushort wMeasure; // Measure this falls on
    public byte bBeat; // Beat this falls on
    public byte bCommand; // Command type (see #defines below)
    public byte bGrooveLevel; // Groove level (0 if command is not a groove)
    public byte bGrooveRange; // Groove range
    public byte bRepeatMode; // Used to control selection of patterns with same groove level
}


/*

    // <cord-list>
    LIST
    (
        'cord'
        <crdh-ck>
        <crdb-ck>...    // Chord body chunks
    )

        // <crdh-ck>
        crdh
        (
            // Scale: dword (upper 8 bits for root, lower 24 for scale)
        )

        // <crdb-ck>
        crdb
        (
            // sizeof DMUS_IO_CHORD:dword
            <DMUS_IO_CHORD>
            // # of DMUS_IO_SUBCHORDS:dword
            // sizeof DMUS_IO_SUBCHORDS:dword
            // a number of <DMUS_IO_SUBCHORD>
        )


    // <cmnd-list>
    'cmnd'
    (
        //sizeof DMUS_IO_COMMAND: DWORD
        <DMUS_IO_COMMAND>...
    )

*/

/*  File io for DirectMusic Tool and ToolGraph objects
*/

/* RIFF ids: */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TOOLGRAPH_FORM mmioFOURCC('D','M','T','G')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TOOL_LIST mmioFOURCC('t','o','l','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TOOL_FORM mmioFOURCC('D','M','T','L')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TOOL_CHUNK mmioFOURCC('t','o','l','h')

/* io structures: */

public class _DMUS_IO_TOOL_HEADER
{
    public GUID guidClassID = new GUID(); // Class id of tool.
    public int lIndex; // Position in graph.
    public uint cPChannels; // Number of items in channels array.
    public FOURCC ckid = new FOURCC(); // chunk ID of tool's data chunk if 0 fccType valid.
    public FOURCC fccType = new FOURCC(); // list type if NULL ckid valid.
    public uint[] dwPChannels = new uint[1]; // Array of PChannels, size determined by cPChannels.
}

/*
RIFF
(
    'DMTG'          // DirectMusic ToolGraph chunk
    [<guid-ck>]     // GUID for ToolGraph
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    <toll-list>     // List of Tools
)

    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    // <toll-list>
    LIST
    (
        'toll'          // Array of tools
        <DMTL-form>...  // Each tool is encapsulated in a RIFF chunk
    )

// <DMTL-form>      Tools are embedded in a graph. Theoretically, they can be saved as individual files too.
RIFF
(
    'DMTL'
    <tolh-ck>
    [<data>]        // Tool data. Must be a RIFF readable chunk.
)

    // <tolh-ck>            // Tool header chunk
    (
        'tolh'
        <DMUS_IO_TOOL_HEADER>   // Tool header
    )
*/

/*  The AudioPath file carries everything for describing a specific audio path,
    including Tool Graph and Buffer Descriptor.
    This can even be used for configuring a complete performance.
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_AUDIOPATH_FORM mmioFOURCC('D','M','A','P')

/*
RIFF
(
    'DMAP'          // DirectMusic AudioPath chunk
    [<guid-ck>]     // GUID for this Audio Path configuration
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    [<DMTG-form>]   // Optional ToolGraph
    [<pcsl-list>]   // Optional list of port configurations
    [<dbfl-list>]...// Optional array of Dsound buffer descriptors
)
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PORTCONFIGS_LIST mmioFOURCC('p','c','s','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PORTCONFIG_LIST mmioFOURCC('p','c','f','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PORTCONFIG_ITEM mmioFOURCC('p','c','f','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PORTPARAMS_ITEM mmioFOURCC('p','p','r','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSBUFFER_LIST mmioFOURCC('d','b','f','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSBUFFATTR_ITEM mmioFOURCC('d','d','a','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PCHANNELS_LIST mmioFOURCC('p','c','h','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PCHANNELS_ITEM mmioFOURCC('p','c','h','h')

public class _DMUS_IO_PORTCONFIG_HEADER
{
    public GUID guidPort = new GUID(); // GUID of requested port.
    public uint dwPChannelBase; // PChannel that this should start on.
    public uint dwPChannelCount; // How many channels.
    public uint dwFlags; // Various flags.
}


/* Each portconfig has one or more pchannel to buffer mappings. Each buffer
   is identified by a guid. Each pchannel can map to one or more buffers.
   This is defined with one or more DMUS_IO_PCHANNELTOBUFFER_HEADER
   structures. Each defines a range of PChannels and the set of buffers
   that they connect to. 
*/

public class _DMUS_IO_PCHANNELTOBUFFER_HEADER
{
    public uint dwPChannelBase; // PChannel that this should start on.
    public uint dwPChannelCount; // How many PChannels.
    public uint dwBufferCount; // How many buffers do these connect to.
    public uint dwFlags; // Various flags. Currently reserved for future use. Must be 0.
}

/* Each buffer is represented by an DSBC form. This is wrapped by the 
   DMUS_IO_BUFFER_ATTRIBUTES_HEADER which identifies how to use the
   buffer. In particular, it indicates whether this gets dynamically duplicated
   or all references to this should share the same instance. 
   To resolve references, the unique GUID of the buffer is also stored
   in this structure. 
*/

public class _DMUS_IO_BUFFER_ATTRIBUTES_HEADER
{
    public GUID guidBufferID = new GUID(); // Each buffer config has a unique ID.
    public uint dwFlags; // Various flags.
}

/* DMUS_IO_BUFFER_ATTRIBUTES_HEADER.dwFlags: */

/*

LIST
(
    'pcsl'          // Array of port configurations
    <pcfl-list>...  // One or more port configurations, each in a list chunk
)

LIST
(
    'pcfl'          // List container for one port configuration.
    <pcfh-ck>       // Portconfig header chunk.
    <pprh-ck>       // Port params, to be used to create the port.
    [<dbfl-list>]...// Optional array of Dsound buffer descriptors
    [<pchl-list>]   // Optional list of pchannel to buffer assignments

)

    // <pcfh-ck>            // Port config header chunk
    (
        'pcfh'
        <DMUS_IO_PORTCONFIG_HEADER>   // Port config header
    )

    // <pprh-ck>            // Port params header chunk
    (
        'pprh'
        <DMUS_PORTPARAMS8>   // Port params header
    )

LIST
(
    'pchl'          // List container for one or more pchannel to buffer assignments.
    <pchh-ck>...    // One or more pchannel to buffer assignment headers and data.

    // <pchh-ck>
    (
        'pchh'
        <DMUS_IO_PCHANNELTOBUFFER_HEADER>   // Description of PChannels
        <GUID>...                           // Array of GUIDs defining the buffers they all connect to.
    )
)

LIST
(
    'dbfl'          // List container for one buffer and buffer attributes header.
    <ddah-ck>       // Buffer attributes header. 
    [<DSBC-form>]   // Buffer configuration. Not required when header uses a predefined buffer type.

    // <ddah-ck>
    (
        'ddah'
        <DMUS_IO_BUFFER_ATTRIBUTES_HEADER>   // Buffer attributes.
    )
)
*/

/*  File io for DirectMusic Band Track object */


/* RIFF ids: */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BANDTRACK_FORM mmioFOURCC('D','M','B','T')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BANDTRACK_CHUNK mmioFOURCC('b','d','t','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BANDS_LIST mmioFOURCC('l','b','d','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BAND_LIST mmioFOURCC('l','b','n','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BANDITEM_CHUNK mmioFOURCC('b','d','i','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BANDITEM_CHUNK2 mmioFOURCC('b','d','2','h')

/* io structures */
public class _DMUS_IO_BAND_TRACK_HEADER
{
    public bool bAutoDownload; // Determines if Auto-Download is enabled.
}

public class _DMUS_IO_BAND_ITEM_HEADER
{
    public MUSIC_TIME lBandTime = new MUSIC_TIME(); // Position in track list.
}

public class _DMUS_IO_BAND_ITEM_HEADER2
{
    public MUSIC_TIME lBandTimeLogical = new MUSIC_TIME(); // Position in track list. Time in the music with which band change is associated.
    public MUSIC_TIME lBandTimePhysical = new MUSIC_TIME(); // Precise time band change will take effect. Should be close to logical time.
}

/*
RIFF
(
    'DMBT'          // DirectMusic Band Track form-type
    [<bdth-ck>]     // Band track header
    [<guid-ck>]     // GUID for band track
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    <lbdl-list>     // List of Band items
)

    // <bnth-ck>
    'bdth'
    (
        <DMUS_IO_BAND_TRACK_HEADER>
    )

    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    // <lbdl-list>
    LIST
    (
        'lbdl'
        <lbnd-list>...  // Array of bands, each encapsulated in a list chunk
    )

        // <lbnd-list>
        LIST
        (
            'lbnd'
            <bdih-ck> or <bd2h-ck>  // bdih is a legacy format.  bd2h is preferred for new content.
            <DMBD-form> // Band
        )

            // <bdih-ck> or <bd2h-ck>       // band item header
            (
                <DMUS_IO_BAND_ITEM_HEADER> or <DMUS_IO_BAND_ITEM_HEADER2> // Band item header
            )
*/      


/*  File io for DirectMusic Band object
*/

/* RIFF ids: */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BAND_FORM mmioFOURCC('D','M','B','D')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_INSTRUMENTS_LIST mmioFOURCC('l','b','i','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_INSTRUMENT_LIST mmioFOURCC('l','b','i','n')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_INSTRUMENT_CHUNK mmioFOURCC('b','i','n','s')

/* Flags for DMUS_IO_INSTRUMENT
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_PATCH (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_BANKSELECT (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_ASSIGN_PATCH (1 << 3)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_NOTERANGES (1 << 4)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_PAN (1 << 5)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_VOLUME (1 << 6 )
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_TRANSPOSE (1 << 7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_GM (1 << 8)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_GS (1 << 9)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_XG (1 << 10)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_CHANNEL_PRIORITY (1 << 11)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_USE_DEFAULT_GM_SET (1 << 12)
                                                    /* don't rely on the synth caps stating GM or GS in hardware. */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_INST_PITCHBENDRANGE (1 << 13)

/* io structures */
public class _DMUS_IO_INSTRUMENT
{
    public uint dwPatch; // MSB, LSB and Program change to define instrument
    public uint dwAssignPatch; // MSB, LSB and Program change to assign to instrument when downloading
    public uint[] dwNoteRanges = new uint[4]; // 128 bits; one for each MIDI note instrument needs to able to play
    public uint dwPChannel; // PChannel instrument plays on
    public uint dwFlags; // DMUS_IO_INST_ flags
    public byte bPan; // Pan for instrument
    public byte bVolume; // Volume for instrument
    public short nTranspose; // Number of semitones to transpose notes
    public uint dwChannelPriority; // Channel priority
    public short nPitchBendRange; // Number of semitones shifted by pitch bend
}

/*
// <DMBD-form> bands can be embedded in other forms
RIFF
(
    'DMBD'          // DirectMusic Band chunk
    [<guid-ck>]     // GUID for band
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    <lbil-list>     // List of Instruments
)

    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    // <lbil-list>
    LIST
    (
        'lbil'          // Array of instruments
        <lbin-list>...  // Each instrument is encapsulated in a list
    )

        // <lbin-list>
        LIST
        (
            'lbin'
            <bins-ck>
            [<DMRF-list>]       // Optional reference to DLS Collection file.
        )

            // <bins-ck>            // Instrument chunk
            (
                'bins'
                <DMUS_IO_INSTRUMENT>    // Instrument header
            )
*/      

/* This RIFF id and io struct have been added to allow wave files (and the wave object) to 
   differentiate between streaming and one-shot waves, and to give a prefetch for streaming
   waves  */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVEHEADER_CHUNK mmioFOURCC('w','a','v','h')

public class _DMUS_IO_WAVE_HEADER
{
    public REFERENCE_TIME rtReadAhead = new REFERENCE_TIME(); // How far ahead in the stream wave data will be read (in REFERENCE_TIME).  Ignored for one-shot waves.
    public uint dwFlags; // Various flags, including whether this is a streaming wave and whether it can be invalidated.
}


/*  File io for Wave track */

/* RIFF ids: */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVETRACK_LIST mmioFOURCC('w','a','v','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVETRACK_CHUNK mmioFOURCC('w','a','t','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVEPART_LIST mmioFOURCC('w','a','v','p')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVEPART_CHUNK mmioFOURCC('w','a','p','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVEITEM_LIST mmioFOURCC('w','a','v','i')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVE_LIST mmioFOURCC('w','a','v','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_WAVEITEM_CHUNK mmioFOURCC('w','a','i','h')

/* This flag is included in DMUS_IO_WAVE_TRACK_HEADER.dwFlags.  If set, the track will get its 
   variations from a pattern track, via GetParam(GUID_Variations). */
/* This is also included in DMUS_IO_WAVE_TRACK_HEADER.dwFlags.  If set, variation control 
   information will persist from one playback instance to the next.*/

public class _DMUS_IO_WAVE_TRACK_HEADER
{
    public int lVolume; // Gain, in 1/100th of dB, to be applied to all waves.  Note:  All gain values should be negative.
    public uint dwFlags; // Flags, including whether this track syncs to a pattern track for its variations.
}

public class _DMUS_IO_WAVE_PART_HEADER
{
    public int lVolume; // Gain, in 1/100th of dB, to be applied to all waves in wave part.  Note:  All gain values should be negative.
    public uint dwVariations; // Variation mask for which of 32 variations
    public uint dwPChannel; // PChannel
    public uint dwLockToPart; // Part ID to lock to.
    public uint dwFlags; // Flags, including stuff for managing how variations are chosen (in low-order nibble)
    public uint dwIndex; // Index for distinguishing multiple parts on the same PChannel
}

public class _DMUS_IO_WAVE_ITEM_HEADER
{
    public int lVolume; // Gain, in 1/100th of dB.  Note:  All gain values should be negative.
    public int lPitch; // Pitch offset in 1/100th of a semitone.
    public uint dwVariations; // Variation flags for which of 32 variations this wave belongs to.
    public REFERENCE_TIME rtTime = new REFERENCE_TIME(); // Start time, in REFERENCE_TIME, if clock time track, or MUSIC_TIME for music time track.
    public REFERENCE_TIME rtStartOffset = new REFERENCE_TIME(); // Distance into wave to start playback, in reference time units.
    public REFERENCE_TIME rtReserved = new REFERENCE_TIME(); // Reserved field.
    public REFERENCE_TIME rtDuration = new REFERENCE_TIME(); // Duration, in REFERENCE_TIME or MUSIC_TIME, depending on track timing format.
    public MUSIC_TIME mtLogicalTime = new MUSIC_TIME(); // If in music track format, this indicates the musical boundary where this belongs. Otherwise, ignored.
    public uint dwLoopStart; // Start point for a looping wave.
    public uint dwLoopEnd; // End point for a looping wave.
    public uint dwFlags; // Various flags, including whether this is a streaming wave and whether it can be invalidated.
    public ushort wVolumeRange; // Random range for volume.
    public ushort wPitchRange; // Random range for pitch.
}

/*
LIST
{
    'wavt'          // Wave track chunk
    <wath-ck>       // Wave track header
    <wavp-list>...  // Array of Wave Parts
}
    // <wath-ck>
    'wath'
    {
        <DMUS_IO_WAVE_TRACK_HEADER>
    }

    //  <wavp-list>
    LIST
    {
        'wavp'
        <waph-ck>       //  Wave Part Header
        <wavi-list>     //  List of wave items
    }

        //  <waph-ck>
        'waph'
        {
            <DMUS_IO_WAVE_PART_HEADER>
        }

        //  <wavi-list>
        LIST
        {
            'wavi'
            <wave-list>...  //  Array of waves; each wave is encapsulated in a list
        }

            //  <wave-list>
            LIST
            {
                'wave'
                <waih-ck>       //  Wave item header
                <DMRF-list>     //  Reference to wave object
            }

                //  <waih-ck>
                'waih'
                {
                    <DMUS_IO_WAVE_ITEM_HEADER>
                }

*/

/*  File io for DirectMusic Container file. This embeds a set of related files. And,
    in turn, it can be embedded within a segment or script file.
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CONTAINER_FORM mmioFOURCC('D','M','C','N')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CONTAINER_CHUNK mmioFOURCC('c','o','n','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CONTAINED_ALIAS_CHUNK mmioFOURCC('c','o','b','a')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CONTAINED_OBJECT_CHUNK mmioFOURCC('c','o','b','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CONTAINED_OBJECTS_LIST mmioFOURCC('c','o','s','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CONTAINED_OBJECT_LIST mmioFOURCC('c','o','b','l')

public class _DMUS_IO_CONTAINER_HEADER
{
    public uint dwFlags; // Flags.
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_CONTAINER_NOLOADS (1 << 1)

public class _DMUS_IO_CONTAINED_OBJECT_HEADER
{
    public GUID guidClassID = new GUID(); // Class id of object.
    public uint dwFlags; // Flags, for example DMUS_CONTAINED_OBJF_KEEP.
    public FOURCC ckid = new FOURCC(); // chunk ID of track's data chunk if 0 fccType valid.
    public FOURCC fccType = new FOURCC(); // list type if NULL ckid valid
        /* Note that LIST:DMRF may be used for ckid and fccType in order to reference an
           object instead of embedding it within the container. */
}


/*
RIFF
(
    'DMCN'          // DirectMusic Container chunk
    <conh-ck>       // Container header chunk
    [<guid-ck>]     // GUID for container
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    <cosl-list>     // List of objects.
)

    // <conh-ck>        
    'conh'
    (
        <DMUS_IO_CONTAINER_HEADER>
    )
    
    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    LIST
    (
        'cosl'          // Array of embedded objects.
        <cobl-list>...  // Each object is encapsulated in a LIST chunk
    )

    // <cobl-list>      // Encapsulates one object
    LIST
    (
        'cobl'
        [<coba-ck>]         // Alias.  An alternative name by which this object is known
                            // within the container.
        <cobh-ck>           // Required header, includes CLASS ID for object.
        [<data>] or <DMRF>  // Object data of the type specified in <cobh-ck>.
                            // If DMRF, it is a reference of where to find the object.
                            // Otherwise, it could be any RIFF readable chunk in the
                            //    exact same format as a file.  The object will load
                            //    itself from this data.
    )

    // <coba-ck>
    'coba'
    (
        // Alias, stored as NULL terminated string of WCHARs
    )

    // <cobh-ck>
    'cobh'
    (
        <DMUS_IO_CONTAINED_OBJECT_HEADER>
    )
*/

/*  File io for DirectMusic Segment object */

/* RIFF ids: */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGMENT_FORM mmioFOURCC('D','M','S','G')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGMENT_CHUNK mmioFOURCC('s','e','g','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TRACK_LIST mmioFOURCC('t','r','k','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TRACK_FORM mmioFOURCC('D','M','T','K')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TRACK_CHUNK mmioFOURCC('t','r','k','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TRACK_EXTRAS_CHUNK mmioFOURCC('t','r','k','x')

/* io structures:*/

public class _DMUS_IO_SEGMENT_HEADER
{
    public uint dwRepeats; // Number of repeats. By default, 0.
    public MUSIC_TIME mtLength = new MUSIC_TIME(); // Length, in music time.
    public MUSIC_TIME mtPlayStart = new MUSIC_TIME(); // Start of playback. By default, 0.
    public MUSIC_TIME mtLoopStart = new MUSIC_TIME(); // Start of looping portion. By default, 0.
    public MUSIC_TIME mtLoopEnd = new MUSIC_TIME(); // End of loop. Must be greater than dwPlayStart. Or, 0, indicating loop full segment.
    public uint dwResolution; // Default resolution.
    /* Following added for DX8: */
    public REFERENCE_TIME rtLength = new REFERENCE_TIME(); // Length, in reference time (overrides music time length.)
    public uint dwFlags;
    public uint dwReserved; // Reserved.
    /* Added for DX9. */
    public REFERENCE_TIME rtLoopStart = new REFERENCE_TIME(); // Clock time loop start.
    public REFERENCE_TIME rtLoopEnd = new REFERENCE_TIME(); // Clock time loop end.
    public REFERENCE_TIME rtPlayStart = new REFERENCE_TIME(); // Start of playback in clock time.
}


public class _DMUS_IO_TRACK_HEADER
{
    public GUID guidClassID = new GUID(); // Class id of track.
    public uint dwPosition; // Position in track list.
    public uint dwGroup; // Group bits for track.
    public FOURCC ckid = new FOURCC(); // chunk ID of track's data chunk.
    public FOURCC fccType = new FOURCC(); // list type if ckid is RIFF or LIST
}

/*  Additional parameters for the track header chunk, introduced in DX8 and
    on, are stored in a separate chunk. */

public class _DMUS_IO_TRACK_EXTRAS_HEADER
{
    public uint dwFlags; // DX8 Added flags for control tracks.
    public uint dwPriority; // Priority for composition.
}

/*
RIFF
(
    'DMSG'          // DirectMusic Segment chunk
    <segh-ck>       // Segment header chunk
    [<guid-ck>]     // GUID for segment
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    [<DMCN-form>]   // Optional container of objects embedded in file. Must precede tracklist.
    <trkl-list>     // List of Tracks
    [<DMTG-form>]   // Optional ToolGraph
    [<DMAP-form>]   // Optional Audio Path
)

    // <segh-ck>        
    'segh'
    (
        <DMUS_IO_SEGMENT_HEADER>
    )
    
    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    // <trkl-list>
    LIST
    (
        'trkl'          // Array of tracks
        <DMTK-form>...  // Each track is encapsulated in a RIFF chunk
    )

    // <DMTK-form>      // Tracks can be embedded in a segment or stored as separate files.
    RIFF
    (
        'DMTK'
        <trkh-ck>
        [<trkx-ck>]     // Optional track flags. 
        [<guid-ck>]     // Optional GUID for track object instance (not to be confused with Class id in track header)
        [<vers-ck>]     // Optional version info
        [<UNFO-list>]   // Optional name, author, copyright info., comments
        [<data>]        // Track data. Must be a RIFF readable chunk.
    )

    // <trkh-ck>            // Track header chunk
    (
        'trkh'
        <DMUS_IO_TRACK_HEADER>  // Track header
    )

    // <trkx-ck>            // Track flags chunk
    (
        'trkx'
        <DMUS_IO_TRACK_EXTRAS_HEADER>  // DX8 Track flags header
    )
*/

/*  File io for DirectMusic reference chunk. 
    This is used to embed a reference to an object.
*/

/*  RIFF ids: */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_REF_LIST mmioFOURCC('D','M','R','F')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_REF_CHUNK mmioFOURCC('r','e','f','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DATE_CHUNK mmioFOURCC('d','a','t','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_NAME_CHUNK mmioFOURCC('n','a','m','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_FILE_CHUNK mmioFOURCC('f','i','l','e')

public class _DMUS_IO_REFERENCE
{
    public GUID guidClassID = new GUID(); // Class id is always required.
    public uint dwValidData; // Flags.
}

/*
LIST
(
    'DMRF'          // DirectMusic Reference chunk
    <refh-ck>       // Reference header chunk
    [<guid-ck>]     // Optional object GUID.
    [<date-ck>]     // Optional file date.
    [<name-ck>]     // Optional name.
    [<file-ck>]     // Optional file name.
    [<catg-ck>]     // Optional category name.
    [<vers-ck>]     // Optional version info.
)

    // <refh-ck>
    'refh'
    (
        <DMUS_IO_REFERENCE>
    )

    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <date-ck>
    date
    (
        <FILETIME>
    )

    // <name-ck>
    name
    (
        // Name, stored as NULL terminated string of WCHARs
    )

    // <file-ck>
    file
    (
        // File name, stored as NULL terminated string of WCHARs
    )

    // <catg-ck>
    catg
    (
        // Category name, stored as NULL terminated string of WCHARs
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )
*/

/* Chord Maps */

/* runtime chunks */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDMAP_FORM mmioFOURCC('D','M','P','R')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_IOCHORDMAP_CHUNK mmioFOURCC('p','e','r','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SUBCHORD_CHUNK mmioFOURCC('c','h','d','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDENTRY_CHUNK mmioFOURCC('c','h','e','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SUBCHORDID_CHUNK mmioFOURCC('s','b','c','n')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_IONEXTCHORD_CHUNK mmioFOURCC('n','c','r','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_NEXTCHORDSEQ_CHUNK mmioFOURCC('n','c','s','q')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_IOSIGNPOST_CHUNK mmioFOURCC('s','p','s','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDNAME_CHUNK mmioFOURCC('I','N','A','M')

/* runtime list chunks */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDENTRY_LIST mmioFOURCC('c','h','o','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDMAP_LIST mmioFOURCC('c','m','a','p')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORD_LIST mmioFOURCC('c','h','r','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CHORDPALETTE_LIST mmioFOURCC('c','h','p','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CADENCE_LIST mmioFOURCC('c','a','d','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SIGNPOSTITEM_LIST mmioFOURCC('s','p','s','t')

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SIGNPOST_LIST mmioFOURCC('s','p','s','q')

/* values for dwChord field of DMUS_IO_PERS_SIGNPOST */
/* DMUS_SIGNPOSTF_ flags are also used in templates (DMUS_IO_SIGNPOST) */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SIGNPOSTF_LETTER (DMUS_SIGNPOSTF_A | DMUS_SIGNPOSTF_B | DMUS_SIGNPOSTF_C | DMUS_SIGNPOSTF_D | DMUS_SIGNPOSTF_E | DMUS_SIGNPOSTF_F)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SIGNPOSTF_ROOT (DMUS_SIGNPOSTF_1 | DMUS_SIGNPOSTF_2 | DMUS_SIGNPOSTF_3 | DMUS_SIGNPOSTF_4 | DMUS_SIGNPOSTF_5 | DMUS_SIGNPOSTF_6 | DMUS_SIGNPOSTF_7)

/* values for dwFlags field of DMUS_IO_CHORDMAP */

/* values for dwChord field of DMUS_IO_PERS_SIGNPOST */

/* run time data structs */
public class _DMUS_IO_CHORDMAP
{
    public string wszLoadName = new string(new char[20]);
    public uint dwScalePattern;
    public uint dwFlags; // Various flags. Only lower 16 bits are significant.
}

public class _DMUS_IO_CHORDMAP_SUBCHORD
{
    public uint dwChordPattern;
    public uint dwScalePattern;
    public uint dwInvertPattern;
    public byte bChordRoot;
    public byte bScaleRoot;
    public ushort wCFlags;
    public uint dwLevels; // parts or which subchord levels this chord supports
}

/* Legacy name... */

public class _DMUS_IO_CHORDENTRY
{
    public uint dwFlags;
    public ushort wConnectionID; // replaces runtime "pointer to this"
}

public class _DMUS_IO_NEXTCHORD
{
    public uint dwFlags;
    public ushort nWeight;
    public ushort wMinBeats;
    public ushort wMaxBeats;
    public ushort wConnectionID; // points to an ioChordEntry
}

public class _DMUS_IO_CHORDMAP_SIGNPOST
{
    public uint dwChords; // 1bit per group
    public uint dwFlags;
}

/* Legacy name... */

/*
RIFF
(
    'DMPR'
    <perh-ck>           // Chord map header chunk
    [<guid-ck>]         // guid chunk
    [<vers-ck>]         // version chunk (two DWORDS)
    [<UNFO-list>]       // Unfo chunk
    <chdt-ck>           // subchord database
    <chpl-list>         // chord palette
    <cmap-list>         // chord map
    <spsq-list>         // signpost list
 )

<cmap-list> ::= LIST('cmap' <choe-list> )

<choe-list> ::= LIST('choe'
                                <cheh-ck>   // chord entry data
                                <chrd-list> // chord definition
                                <ncsq-ck>   // connecting(next) chords
                     )

<chrd-list> ::= LIST('chrd' 
                                <INAM-ck>   // name of chord in wide char format
                                <sbcn-ck>   // list of subchords composing chord
                    )

<chpl-list> ::= LIST('chpl' 
                                <chrd-list> ... // chord definition
                    )

<spsq-list> ::== LIST('spsq' <spst-list> ... )

<spst-list> ::= LIST('spst'
                             <spsh-ck>
                             <chrd-list>
                             [<cade-list>]
                    )

<cade-list> ::= LIST('cade' <chrd-list> ...)

<perh-ck> ::= perh(<DMUS_IO_CHORDMAP>)

<chdt-ck> ::= chdt(<cbChordSize::WORD>
                   <DMUS_IO_PERS_SUBCHORD> ... )

<cheh-ck> ::= cheh(<DMUS_IO_CHORDENTRY>)

<sbcn-ck> ::= sbcn(<cSubChordID:WORD> ...)

<ncsq-ck> ::= ncsq(<wNextChordSize:WORD> 
                   <DMUS_IO_NEXTCHORD>...)

<spsh-ck> ::= spsh(<DMUS_IO_PERS_SIGNPOST>)

*/

/*  File io for DirectMusic Script object */

/* RIFF ids: */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPT_FORM mmioFOURCC('D','M','S','C')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPT_CHUNK mmioFOURCC('s','c','h','d')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTVERSION_CHUNK mmioFOURCC('s','c','v','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTLANGUAGE_CHUNK mmioFOURCC('s','c','l','a')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTSOURCE_CHUNK mmioFOURCC('s','c','s','r')

/* io structures:*/

public class _DMUS_IO_SCRIPT_HEADER
{
    public uint dwFlags; // DMUS_SCRIPTIOF_ flags
}

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SCRIPTIOF_LOAD_ALL_CONTENT (1 << 0)
    /* If set, when the script loads it will also load all the content in its container. */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_SCRIPTIOF_DOWNLOAD_ALL_SEGMENTS (1 << 1)
    /* If set and LOAD_ALL_CONTENT is also set, when the script initializes it will also download all the segments in its container.
       If set and LOAD_ALL_CONTENT is not set, when the script calls segment.Load on a segment then the segment will also be downloaded.
       If not set, the script must manually download and unload by calling segment.DownloadSoundData and segment.UnloadSoundData. */

/*
RIFF
(
    'DMSC'              // DirectMusic Script chunk
    <schd-ck>           // Script header chunk
    [<guid-ck>]         // GUID for script
    [<vers-ck>]         // Optional version info
    [<UNFO-list>]       // Name, author, copyright info., comments
    <scve-ck>           // Version of DirectMusic this script was authored to run against
    <DMCN-form>         // Container of content referenced by the script.
    <scla-ck>           // ActiveX scripting language in which the script is written
    <scsr-ck> or <DMRF> // The script's source code.
                        // If scsr-ck, the source is embedding in the chunk.
                        // If DMRF, it is a reference of where to find a text file with the source.
                        //    Class id (guidClassID in DMUS_IO_REFERENCE) must be GUID_NULL because
                        //    this text file is not a DirectMusic object in its own right.
)

    // <schd-ck>
    'schd'
    (
        <DMUS_FOURCC_SCRIPT_CHUNK>
    )
    
    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    vers
    (
        <DMUS_IO_VERSION>
    )

    // <scve-ck>
    scve
    (
        <DMUS_IO_VERSION>
    )

    'scla'
    (
        // Language name, stored as NULL terminated string of WCHARs
    )

    'scsr'
    (
        // Source code, stored as NULL terminated string of WCHARs
    )
*/

/* Signpost tracks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SIGNPOST_TRACK_CHUNK mmioFOURCC( 's', 'g', 'n', 'p' )


public class _DMUS_IO_SIGNPOST
{
    public MUSIC_TIME mtTime = new MUSIC_TIME();
    public uint dwChords;
    public ushort wMeasure;
}

/*

    // <sgnp-list>
    'sgnp'
    (
        //sizeof DMUS_IO_SIGNPOST: DWORD
        <DMUS_IO_SIGNPOST>...
    )

*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_MUTE_CHUNK mmioFOURCC('m','u','t','e')

public class _DMUS_IO_MUTE
{
    public MUSIC_TIME mtTime = new MUSIC_TIME();
    public uint dwPChannel;
    public uint dwPChannelMap;
}

/*

    // <mute-list>
    'mute'
    (
        //sizeof DMUS_IO_MUTE:DWORD
        <DMUS_IO_MUTE>...
    )


*/

/* Used for both style and chord map tracks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TIME_STAMP_CHUNK mmioFOURCC('s', 't', 'm', 'p')

/* Style tracks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_STYLE_TRACK_LIST mmioFOURCC('s', 't', 't', 'r')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_STYLE_REF_LIST mmioFOURCC('s', 't', 'r', 'f')

/*

    // <sttr-list>
    LIST('sttr'
    (
        <strf-list>...  // Array of Style references
    )

    // <strf-list>
    LIST('strf'
    (
        <stmp-ck>
        <DMRF>
    )

  // <stmp-ck>
  'stmp'
  (
    // time:DWORD
  )

*/

/* Chord map tracks */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PERS_TRACK_LIST mmioFOURCC('p', 'f', 't', 'r')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PERS_REF_LIST mmioFOURCC('p', 'f', 'r', 'f')

/*

    // <pftr-list>
    LIST('pftr'
    (
        <pfrf-list>...  // Array of Chord map references
    )

    // <pfrf-list>
    LIST('pfrf'
    (
        <stmp-ck>
        <DMRF>
    )

  // <stmp-ck>
  'stmp'
  (
    // time:DWORD
  )

*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TEMPO_TRACK mmioFOURCC('t','e','t','r')

/*
    // tempo array
    'tetr'
    (
        // sizeof DMUS_IO_TEMPO_ITEM: DWORD
        <DMUS_IO_TEMPO_ITEM>...
    )
 */

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEQ_TRACK mmioFOURCC('s','e','q','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEQ_LIST mmioFOURCC('e','v','t','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_CURVE_LIST mmioFOURCC('c','u','r','l')

/*
    // sequence track
    'seqt'
    (
        // sequence array
        'evtl'
        (
            // sizeof DMUS_IO_SEQ_ITEM: DWORD
            <DMUS_IO_SEQ_ITEM>...
        )
        // curve array
        'curl'
        (
            // sizeof DMUS_IO_CURVE_ITEM: DWORD
            <DMUS_IO_CURVE_ITEM>...
        )
    )
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SYSEX_TRACK mmioFOURCC('s','y','e','x')

/*
    // sysex track
    'syex'
    (
        {
            <DMUS_IO_SYSEX_ITEM>
            <BYTE>...    // Array of bytes, length defined in the DMUS_IO_SYSEXITEM structure
        }...
    )
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TIMESIGNATURE_TRACK mmioFOURCC('t','i','m','s')

public class _DMUS_IO_TIMESIGNATURE_ITEM
{
    public MUSIC_TIME lTime = new MUSIC_TIME();
    public byte bBeatsPerMeasure; // beats per measure (top of time sig)
    public byte bBeat; // what note receives the beat (bottom of time sig.)
                                      /* we can assume that 0 means 256th note */
    public ushort wGridsPerBeat; // grids per beat
}

/*  DX6 time signature track
    
    'tims'
    (
        // size of DMUS_IO_TIMESIGNATURE_ITEM : DWORD
        <DMUS_IO_TIMESIGNATURE_ITEM>...
    )
*/

/*  DX8 Time signature track. The track has been updated from DX7 to support a list of
    RIFF chunks. This will allow the time signature track to expand in the future.
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TIMESIGTRACK_LIST mmioFOURCC('T','I','M','S')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_TIMESIG_CHUNK DMUS_FOURCC_TIMESIGNATURE_TRACK

/*
LIST
(
    'TIMS'          // Time Signature Track list-type
    <tims-ck>       // Chunk containing an array of time signatures
)

    'tims'
    (
        // size of DMUS_IO_TIMESIGNATURE_ITEM : DWORD
        <DMUS_IO_TIMESIGNATURE_ITEM>...
    )
 
*/

/*  DX8 Marker track. This is used to store valid start points and other
    flow control parameters that may come later. For example, if we want
    to implement more sophisticated looping and branching constructs, they
    would live in this track.
*/

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_MARKERTRACK_LIST mmioFOURCC('M','A','R','K')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_VALIDSTART_CHUNK mmioFOURCC('v','a','l','s')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PLAYMARKER_CHUNK mmioFOURCC('p','l','a','y')

/* io structures */
public class _DMUS_IO_VALID_START
{
    public MUSIC_TIME mtTime = new MUSIC_TIME(); // Time of a legal start.
}

public class _DMUS_IO_PLAY_MARKER
{
    public MUSIC_TIME mtTime = new MUSIC_TIME(); // Time of a next legal play point marker.
}

/*
LIST
(
    'MARK'          // Marker Track list-type
    [<vals-ck>]     // Chunk containing an array of start points
    [<play-ck>]     // Chunk containing an array of play start markers
)

    'vals'
    (
        // size of DMUS_IO_VALID_START : DWORD
        <DMUS_IO_VALID_START>...
    )

    'play'
    (
        // size of DMUS_IO_PLAY_MARKER : DWORD
        <DMUS_IO_PLAY_MARKER>...
    )
  
*/

/* segment trigger tracks */

/* RIFF ids: */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGTRACK_LIST mmioFOURCC('s','e','g','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGTRACK_CHUNK mmioFOURCC('s','g','t','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGMENTS_LIST mmioFOURCC('l','s','g','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGMENT_LIST mmioFOURCC('l','s','e','g')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGMENTITEM_CHUNK mmioFOURCC('s','g','i','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SEGMENTITEMNAME_CHUNK mmioFOURCC('s','n','a','m')

/* io structures */
public class _DMUS_IO_SEGMENT_TRACK_HEADER
{
    public uint dwFlags; // Reserved leave as 0.
}

public class _DMUS_IO_SEGMENT_ITEM_HEADER
{
    public MUSIC_TIME lTimeLogical = new MUSIC_TIME(); // Position in track list. Time in the music with which the event is associated.
    public MUSIC_TIME lTimePhysical = new MUSIC_TIME(); // Precise time event will be triggered. Should be close to logical time.
    public uint dwPlayFlags; // Flags for PlaySegment().
    public uint dwFlags; // Flags.
}

/* values for dwflags field of DMUS_IO_SEGMENT_ITEM_HEADER */

/*
LIST
(
    'segt'          // DirectMusic Segment Trigger Track form-type
    [<sgth-ck>]     // Segment track header
    <lsgl-list>     // List of Segment Lists
)

    // <sgth-ck>
    'sgth'
    (
        <DMUS_IO_SEGMENT_TRACK_HEADER>
    )

    // <lsgl-list>
    LIST
    (
        'lsgl'          // Array of segments
        <lseg-list>...  // Each segment is encapsulated in a list (that way it can still be riff parsed.)
    )

        // <lseg-list>
        LIST
        (
            'lseg'
            <sgih-ck>
            <DMRF-list>    // Link to a segment or style file.
            [<snam-ck>]    // Name field.  Used with DMUS_SEGMENTTRACKF_MOTIF flag.
        )

            // <sgih-ck>            // segment item header
            (
                <DMUS_IO_SEGMENT_ITEM_HEADER>  // Segment item header
            )

            // <snam-ck>
            (
                // Name, stored as NULL terminated string of WCHARs
            )
*/      

/* Script track. */

/* RIFF ids: */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTTRACK_LIST mmioFOURCC('s','c','r','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTTRACKEVENTS_LIST mmioFOURCC('s','c','r','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTTRACKEVENT_LIST mmioFOURCC('s','c','r','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTTRACKEVENTHEADER_CHUNK mmioFOURCC('s','c','r','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_SCRIPTTRACKEVENTNAME_CHUNK mmioFOURCC('s','c','r','n')

/* Flags for DMUS_IO_SCRIPTTRACK_TIMING
 */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_SCRIPTTRACKF_PREPARE (1 << 0)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_SCRIPTTRACKF_QUEUE (1 << 1)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_IO_SCRIPTTRACKF_ATTIME (1 << 2)

public class _DMUS_IO_SCRIPTTRACK_EVENTHEADER
{
    public uint dwFlags; // various bits (see DMUS_IO_SCRIPTTRACKF_*)
    public MUSIC_TIME lTimeLogical = new MUSIC_TIME(); // Position in track list. Time in the music with which the event is associated.
    public MUSIC_TIME lTimePhysical = new MUSIC_TIME(); // Precise time event will be triggered. Should be close to logical time.
}

/*
    // Script Track

    // <scrt-list>
    LIST
    (
        <scrl-list>       // List of script events
    )

        // <scrl-list>
        LIST
        (
            <scre-list>...    // Array of event descriptions
        )

            // <scre-list>
            LIST
            (
                <scrh-ck>         // Event header chunk
                <DMRF>
                <scrn-ck>         // Routine name
            )

                'scrh'
                (
                    <DMUS_IO_SCRIPTTRACK_EVENTHEADER>
                )

                'scrn'
                (
                    // Name, stored as NULL terminated string of WCHARs
                )
*/

/* Lyrics/Notification track. */

/* RIFF ids: */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_LYRICSTRACK_LIST mmioFOURCC('l','y','r','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_LYRICSTRACKEVENTS_LIST mmioFOURCC('l','y','r','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_LYRICSTRACKEVENT_LIST mmioFOURCC('l','y','r','e')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_LYRICSTRACKEVENTHEADER_CHUNK mmioFOURCC('l','y','r','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_LYRICSTRACKEVENTTEXT_CHUNK mmioFOURCC('l','y','r','n')

public class _DMUS_IO_LYRICSTRACK_EVENTHEADER
{
    public uint dwFlags; // Reserved leave as 0.
    public uint dwTimingFlags; // Combination DMUS_PMSGF_TOOL_* flags.  Determines the precise timing of when the notification happens. Invalid with the flag DMUS_PMSGF_REFTIME, DMUS_PMSGF_MUSICTIME, DMUS_PMSGF_TOOL_FLUSH, or DMUS_PMSGF_LOCKTOREFTIME.
    public MUSIC_TIME lTimeLogical = new MUSIC_TIME(); // Position in track list. Time in the music with which the event is associated.
    public MUSIC_TIME lTimePhysical = new MUSIC_TIME(); // Precise time event will be triggered. Should be close to logical time.
}

/*
    // Lyrics/Notification Track

    // <lyrt-list>
    LIST
    (
        <lyrl-list>       // List of notification events
    )

        // <lyrl-list>
        LIST
        (
            <lyre-list>...    // Array of event descriptions
        )

            // <lyre-list>
            LIST
            (
                <lyrh-ck>         // Event header chunk
                <lyrn-ck>         // Notification text
            )

                'lyrh'
                (
                    <DMUS_IO_LYRICSTRACK_EVENTHEADER>
                )

                'lyrn'
                (
                    // Name, stored as NULL terminated string of WCHARs
                )
*/

/* Parameter control track */

/* RIFF ids: */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARAMCONTROLTRACK_TRACK_LIST mmioFOURCC('p','r','m','t')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARAMCONTROLTRACK_OBJECT_LIST mmioFOURCC('p','r','o','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARAMCONTROLTRACK_OBJECT_CHUNK mmioFOURCC('p','r','o','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARAMCONTROLTRACK_PARAM_LIST mmioFOURCC('p','r','p','l')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARAMCONTROLTRACK_PARAM_CHUNK mmioFOURCC('p','r','p','h')
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_PARAMCONTROLTRACK_CURVES_CHUNK mmioFOURCC('p','r','c','c')

public class _DMUS_IO_PARAMCONTROLTRACK_OBJECTHEADER
{
    public uint dwFlags; // Reserved.  Must be zero.
    public GUID guidTimeFormat = new GUID(); // Time format to set the object to.  Must be GUID_TIME_REFERNCE or GUID_TIME_MUSIC from medparam.h.
    /* Path for finding the object. These fields correspond to the first five parameters of IDirectMusicSegmentState::GetObjectInPath. */
    public uint dwPChannel;
    public uint dwStage;
    public uint dwBuffer;
    public GUID guidObject = new GUID();
    public uint dwIndex;
}

public class _DMUS_IO_PARAMCONTROLTRACK_PARAMHEADER
{
    public uint dwFlags; // Reserved.  Must be zero.
    public uint dwIndex; // Index number of the parameter on the object
}

public class _DMUS_IO_PARAMCONTROLTRACK_CURVEINFO
{
    public MUSIC_TIME mtStartTime = new MUSIC_TIME();
    public MUSIC_TIME mtEndTime = new MUSIC_TIME();
    public float fltStartValue;
    public float fltEndValue;
    public uint dwCurveType; // One of the items from the MP_CURVE_TYPE enum in medparam.h
    public uint dwFlags; // A combination of the MPF_ENVLP_* constants in medparam.h
}

/*
    // <prmt-list>
    LIST
    (
        <prol-list>...   // one for each object
    )

        // <prol-list>
        LIST
        (
            <proh-ck>       // object header chunk
            <prpl-list>...  // one for each parameter
        )

            // <proh-ck>
            proh
            (
                <DMUS_IO_PARAMCONTROLTRACK_OBJECTHEADER>
            )

            // <prpl-list>
            LIST
            (
                <prph-ck>       // parameter header chunk
                <prcc-ck>       // chunk containing an array of curves
            )

                // <prph-ck>
                prph
                (
                    <DMUS_IO_PARAMCONTROLTRACK_PARAMHEADER>
                )

                // <prcc-ck>
                prcc
                (
                    // sizeof DMUS_IO_PARAMCONTROLTRACK_CURVEINFO:DWORD
                    <DMUS_IO_PARAMCONTROLTRACK_CURVEINFO>... // curves, sorted in order of mtTime
                )
*/

// C++ TO C# CONVERTER TODO TASK: C# does not allow setting or comparing #define constants:
#if (DIRECTSOUND_VERSION >= 0x0800)

/* DirectSoundBufferConfig FX Map */

/* RIFF ids: */

// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSBC_FORM mmioFOURCC('D','S','B','C')
#define DMUS_FOURCC_DSBC_FORM
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSBD_CHUNK mmioFOURCC('d','s','b','d')
#define DMUS_FOURCC_DSBD_CHUNK
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_BSID_CHUNK mmioFOURCC('b','s','i','d')
#define DMUS_FOURCC_BSID_CHUNK
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DS3D_CHUNK mmioFOURCC('d','s','3','d')
#define DMUS_FOURCC_DS3D_CHUNK
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSBC_LIST mmioFOURCC('f','x','l','s')
#define DMUS_FOURCC_DSBC_LIST
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSFX_FORM mmioFOURCC('D','S','F','X')
#define DMUS_FOURCC_DSFX_FORM
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSFX_CHUNK mmioFOURCC('f','x','h','r')
#define DMUS_FOURCC_DSFX_CHUNK
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_FOURCC_DSFX_DATA mmioFOURCC('d','a','t','a')
#define DMUS_FOURCC_DSFX_DATA

/* io structures */

public class _DSOUND_IO_DSBUFFERDESC
{
    public uint dwFlags; // DirectSound buffer creation flags
    public ushort nChannels; // No. of channels (rest of buffer format is determined by owning sink)
    public int lVolume; // Initial pan; only used if CTRLVOLUME is specified
    public int lPan; // Initial pan; only used if CTRLPAN is specified
    public uint dwReserved; // Reserved - must be 0
}

public class _DSOUND_IO_DSBUSID
{
    public uint[] busid = new uint[1]; // Array size determined from chunk size
}

public class _DSOUND_IO_3D
{
    public GUID guid3DAlgorithm = new GUID(); // GUID identifying the 3D algorithm to use (defined in dsound.h)
    public DS3DBUFFER ds3d = new DS3DBUFFER(); // Initial 3D parameters
}

public class _DSOUND_IO_DXDMO_HEADER
{
    public uint dwEffectFlags; // Effect creation flags - equivalent to DSEFFECTDESC::dwFlags
    public GUID guidDSFXClass = new GUID(); // GUID identifying the effect to use - corresponds to a COM CLSID
    public GUID guidReserved = new GUID(); // Reserved - must be the null GUID
    public GUID guidSendBuffer = new GUID(); // GUID identifying the buffer to send to if this is a send effect
    public uint dwReserved; // Reserved - must be 0
}

public class _DSOUND_IO_DXDMO_DATA
{
    public uint[] data = new uint[1]; // Array size determined by the DMO involved
}

/*
RIFF
(
    'DSBC'          // DirectSoundBufferConfig chunk
    [<guid-ck>]     // GUID identifier for this DirectSoundBufferConfig
    [<vers-ck>]     // Optional version info
    [<UNFO-list>]   // Name, author, copyright info., comments
    <dsbd-ck>       // DirectSound Buffer descriptor chunk
    [<bsid-ck>]     // Optional bus id array
    [<ds3d-ck>]     // Optional 3d Parameters
    [<fxls-list>]   // Optional list of FX descriptors
)

    // <guid-ck>
    'guid'
    (
        <GUID>
    )

    // <vers-ck>
    'vers'
    (
        <DMUS_IO_VERSION>
    )

    // <dsbd-ck>
    'dsbd'
    (
        <DSOUND_IO_DSBUFFERDESC>  // Creation parameters and initial settings for the buffer
    )

    // <bsid-ck>
    'bsid'
    (
        <DSOUND_IO_DSBUSID>  // The size of DSOUND_IO_DSBUSID is determined by the chunk size 
    )

    // <ds3d-ck>
    'ds3d'
    (
        <DSOUND_IO_3D>  // Initial 3D buffer parameters: position, etc.
    )

    // <fx-list>
    LIST
    (
        'fxls'          // Array of DMO creation parameter blocks
        <DSFX-form>...  // Each DMO is encapsulated in a RIFF chunk
    )

// <DSFX-form>          // DMOs can be embedded in a buffer configuration or stored as separate files
RIFF
(
    'DSFX'
    <fxhr-ck>           // FX header chunk
    [<data-ck>]         // FX initial settings chunk
)

    // <fxhr-ck>
    'fxhr'
    (
        <DSOUND_IO_DXDMO_HEADER>
    )

    // <data-ck>
    'data'
    (
        <DSOUND_IO_DXDMO_DATA>  // Opaque data block used by the DMO to load itself.
        // For our standard included DMOs, this is simply the structure accepted by
        // the DMO's SetAllParameters() method - e.g. struct DSFXChorus for Chorus.
    )
*/

#endif

#if __cplusplus
#endif

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>

