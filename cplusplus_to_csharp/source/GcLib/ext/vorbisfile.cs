/********************************************************************
 *                                                                  *
 * THIS FILE IS PART OF THE OggVorbis SOFTWARE CODEC SOURCE CODE.   *
 * USE, DISTRIBUTION AND REPRODUCTION OF THIS LIBRARY SOURCE IS     *
 * GOVERNED BY A BSD-STYLE SOURCE LICENSE INCLUDED WITH THIS SOURCE *
 * IN 'COPYING'. PLEASE READ THESE TERMS BEFORE DISTRIBUTING.       *
 *                                                                  *
 * THE OggVorbis SOURCE CODE IS (C) COPYRIGHT 1994-2001             *
 * by the XIPHOPHORUS Company http://www.xiph.org/                  *
 *                                                                  *
 ********************************************************************

 function: stdio-based convenience library for opening/seeking/decoding
 last mod: $Id: vorbisfile.h,v 1.20 2003/08/18 05:34:01 xiphmont Exp $

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

/* The function prototypes for the callbacks are basically the same as for
 * the stdio functions fread, fseek, fclose, ftell. 
 * The one difference is that the FILE * arguments have been replaced with
 * a void * - this is to be used as a pointer to whatever internal data these
 * functions might need. In the stdio case, it's just a FILE * cast to a void *
 * 
 * If you use other functions, check the docs for these functions and return
 * the right values. For seek_func(), you *MUST* return -1 if the stream is
 * unseekable
 */
public class ov_callbacks
{
  public delegate size_t read_funcDelegate(object ptr, size_t size, size_t nmemb, object datasource);
  public read_funcDelegate read_func;
  public delegate int seek_funcDelegate(object datasource, ogg_int64_t offset, int whence);
  public seek_funcDelegate seek_func;
  public delegate int close_funcDelegate(object datasource);
  public close_funcDelegate close_func;
  public delegate int tell_funcDelegate(object datasource);
  public tell_funcDelegate tell_func;
}


public class OggVorbis_File
{
  public object datasource; // Pointer to a FILE *, etc.
  public int seekable;
  public ogg_int64_t offset = new ogg_int64_t();
  public ogg_int64_t end = new ogg_int64_t();
  public ogg_sync_state oy = new ogg_sync_state();

  /* If the FILE handle isn't seekable (eg, a pipe), only the current
     stream appears */
  public int links;
  public ogg_int64_t offsets;
  public ogg_int64_t dataoffsets;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int *serialnos;
  public int serialnos;
  public ogg_int64_t pcmlengths; /* overloaded to maintain binary
				  compatability; x2 size, stores both
				  beginning and end values */
  public vorbis_info vi;
  public vorbis_comment vc;

  /* Decoding working state local storage */
  public ogg_int64_t pcm_offset = new ogg_int64_t();
  public int ready_state;
  public int current_serialno;
  public int current_link;

  public double bittrack;
  public double samptrack;

  public ogg_stream_state os = new ogg_stream_state(); /* take physical pages, weld into a logical
                          stream of packets */
  public vorbis_dsp_state vd = new vorbis_dsp_state(); // central working state for the packet->PCM decoder
  public vorbis_block vb = new vorbis_block(); // local working space for packet->PCM decode

  public ov_callbacks callbacks = new ov_callbacks();

}