/********************************************************************
 *                                                                  *
 * THIS FILE IS PART OF THE OggVorbis SOFTWARE CODEC SOURCE CODE.   *
 * USE, DISTRIBUTION AND REPRODUCTION OF THIS LIBRARY SOURCE IS     *
 * GOVERNED BY A BSD-STYLE SOURCE LICENSE INCLUDED WITH THIS SOURCE *
 * IN 'COPYING'. PLEASE READ THESE TERMS BEFORE DISTRIBUTING.       *
 *                                                                  *
 * THE OggVorbis SOURCE CODE IS (C) COPYRIGHT 1994-2001             *
 * by the XIPHOPHORUS Company http://www.xiph.org/                  *

 ********************************************************************

 function: libvorbis codec headers
 last mod: $Id: codec.h,v 1.45 2003/09/05 22:34:46 giles Exp $

 ********************************************************************/


#if __cplusplus
#endif // __cplusplus

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free

public class vorbis_info
{
  public int version;
  public int channels;
  public int rate;

  /* The below bitrate declarations are *hints*.
     Combinations of the three values carry the following implications:
     
     all three set to the same value: 
       implies a fixed rate bitstream
     only nominal set: 
       implies a VBR stream that averages the nominal bitrate.  No hard 
       upper/lower limit
     upper and or lower set: 
       implies a VBR bitstream that obeys the bitrate limits. nominal 
       may also be set to give a nominal rate.
     none set:
       the coder does not care to speculate.
  */

  public int bitrate_upper;
  public int bitrate_nominal;
  public int bitrate_lower;
  public int bitrate_window;

  public object codec_setup;
}

/* vorbis_dsp_state buffers the current vorbis audio
   analysis/synthesis state.  The DSP state belongs to a specific
   logical bitstream ****************************************************/
public class vorbis_dsp_state
{
  public int analysisp;
  public vorbis_info vi;

// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: float **pcm;
  public float[] pcm;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: float **pcmret;
  public float[] pcmret;
  public int pcm_storage;
  public int pcm_current;
  public int pcm_returned;

  public int preextrapolate;
  public int eofflag;

  public int lW;
  public int W;
  public int nW;
  public int centerW;

  public ogg_int64_t granulepos = new ogg_int64_t();
  public ogg_int64_t sequence = new ogg_int64_t();

  public ogg_int64_t glue_bits = new ogg_int64_t();
  public ogg_int64_t time_bits = new ogg_int64_t();
  public ogg_int64_t floor_bits = new ogg_int64_t();
  public ogg_int64_t res_bits = new ogg_int64_t();

  public object backend_state;
}

public class vorbis_block
{
  /* necessary stream state for linking to the framing abstraction */
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: float **pcm;
  public float[] pcm; // this is a pointer into local storage
  public oggpack_buffer opb = new oggpack_buffer();

  public int lW;
  public int W;
  public int nW;
  public int pcmend;
  public int mode;

  public int eofflag;
  public ogg_int64_t granulepos = new ogg_int64_t();
  public ogg_int64_t sequence = new ogg_int64_t();
  public vorbis_dsp_state vd; // For read-only access of configuration

  /* local storage to avoid remallocing; it's up to the mapping to
     structure it */
  public object localstore;
  public int localtop;
  public int localalloc;
  public int totaluse;
  public alloc_chain reap;

  /* bitmetrics for the frame */
  public int glue_bits;
  public int time_bits;
  public int floor_bits;
  public int res_bits;

  public object @internal;

}

/* vorbis_block is a single block of data to be processed as part of
the analysis/synthesis stream; it belongs to a specific logical
bitstream, but is independant from other vorbis_blocks belonging to
that logical bitstream. *************************************************/

public class alloc_chain
{
  public object[] ptr;
  public alloc_chain next;
}

/* vorbis_info contains all the setup information specific to the
   specific compression/decompression mode in progress (eg,
   psychoacoustic settings, channel setup, options, codebook
   etc). vorbis_info and substructures are in backends.h.
*********************************************************************/

/* the comments are not part of vorbis_info so that vorbis_info can be
   static storage */
public class vorbis_comment
{
  /* unlimited user comment fields.  libvorbis writes 'libvorbis'
     whatever vendor is set to in encode */
  public string[] user_comments;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int *comment_lengths;
  public int comment_lengths;
  public int comments;
  public string vendor;

}