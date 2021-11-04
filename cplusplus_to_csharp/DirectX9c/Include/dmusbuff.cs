/***************************************************************************
*                                                                          *
*   DMusBuff.h -- This module defines the buffer format for DirectMusic    *
*                 Shared file between user mode and kernel mode components *
*                                                                          *
*   Copyright (c) 1998, Microsoft Corp. All rights reserved.               *
*                                                                          *
***************************************************************************/


/* Format of DirectMusic events in a buffer
 *
 * A buffer contains 1 or more events, each with the following header.
 * Immediately following the header is the event data. The header+data
 * size is rounded to the nearest quadword (8 bytes).
 */

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <pshpack4.h> // Do not pad at end - that's where the data is
public class _DMUS_EVENTHEADER
{
    public uint cbEvent; // Unrounded bytes in event
    public uint dwChannelGroup; // Channel group of event
    public REFERENCE_TIME rtDelta = new REFERENCE_TIME(); // Delta from start time of entire buffer
    public uint dwFlags; // Flags DMUS_EVENT_xxx
}
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <poppack.h>


/* The number of bytes to allocate for an event with 'cb' data bytes.
 */ 
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define QWORD_ALIGN(x) (((x) + 7) & ~7)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DMUS_EVENT_SIZE(cb) QWORD_ALIGN(sizeof(DMUS_EVENTHEADER) + cb)




