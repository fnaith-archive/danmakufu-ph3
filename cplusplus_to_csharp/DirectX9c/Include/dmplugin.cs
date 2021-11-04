/************************************************************************
*                                                                       *
*   dmplugin.h -- This module contains the API for plugins for the      *
*                 DirectMusic performance layer                         *
*                                                                       *
*   Copyright (c) Microsoft Corporation.  All rights reserved.          *
*                                                                       *
************************************************************************/



// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <objbase.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <mmsystem.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <dmusici.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack8.h>

#if __cplusplus
#endif


/* The following flags are sent in the IDirectMusicTrack::Play() method */
/* inside the dwFlags parameter */
public enum enumDMUS_TRACKF_FLAGS
{
    DMUS_TRACKF_SEEK = 1, // set on a seek
    DMUS_TRACKF_LOOP = 2, // set on a loop (repeat)
    DMUS_TRACKF_START = 4, // set on first call to Play
    DMUS_TRACKF_FLUSH = 8, // set when this call is in response to a flush on the perfomance
    DMUS_TRACKF_DIRTY = 0x10, // set when the track should consider any cached values from a previous call to GetParam to be invalidated
    /* The following flags are DX8 only. */
    DMUS_TRACKF_NOTIFY_OFF = 0x20, // tells track not to send notifications.
    DMUS_TRACKF_PLAY_OFF = 0x40, // tells track not to play anything (but can still send notifications.)
    DMUS_TRACKF_LOOPEND = 0x80, // set when the end of range is also a loop end.
    DMUS_TRACKF_STOP = 0x100, // set when the end of range is also end of playing this segment.
    DMUS_TRACKF_RECOMPOSE = 0x200, // set to indicate the track should compose.
    DMUS_TRACKF_CLOCK = 0x400 // set when time parameters are in reference (clock) time. Only valid for PlayEx().
}