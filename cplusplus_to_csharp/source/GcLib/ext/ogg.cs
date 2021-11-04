/********************************************************************
 *                                                                  *
 * THIS FILE IS PART OF THE OggVorbis SOFTWARE CODEC SOURCE CODE.   *
 * USE, DISTRIBUTION AND REPRODUCTION OF THIS LIBRARY SOURCE IS     *
 * GOVERNED BY A BSD-STYLE SOURCE LICENSE INCLUDED WITH THIS SOURCE *
 * IN 'COPYING'. PLEASE READ THESE TERMS BEFORE DISTRIBUTING.       *
 *                                                                  *
 * THE OggVorbis SOURCE CODE IS (C) COPYRIGHT 1994-2002             *
 * by the Xiph.Org Foundation http://www.xiph.org/                  *
 *                                                                  *
 ********************************************************************

 function: toplevel libogg include
 last mod: $Id: ogg.h,v 1.19 2002/09/15 23:48:02 xiphmont Exp $

 ********************************************************************/

#if __cplusplus
#endif

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free

public class oggpack_buffer
{
  public int endbyte;
  public int endbit;

  public byte[] buffer;
  public byte[] ptr;
  public int storage;
}

/* ogg_page is used to encapsulate the data in one Ogg bitstream page *****/

public class ogg_page
{
  public byte[] header;
  public int header_len;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *body;
  public byte body;
  public int body_len;
}

/* ogg_stream_state contains the current encode/decode state of a logical
   Ogg bitstream **********************************************************/

public class ogg_stream_state
{
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *body_data;
  public byte body_data; // bytes from packet bodies
  public int body_storage; // storage elements allocated
  public int body_fill; // elements stored; fill mark
  public int body_returned; // elements of fill returned


// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: int *lacing_vals;
  public int lacing_vals; // The values that will go to the segment table
  public ogg_int64_t granule_vals; /* granulepos values for headers. Not compact
				this way, but it is simple coupled to the
				lacing fifo */
  public int lacing_storage;
  public int lacing_fill;
  public int lacing_packet;
  public int lacing_returned;

  public byte[] header = new byte[282]; // working space for header encode
  public int header_fill;

  public int e_o_s; /* set when we have buffered the last packet in the
                             logical bitstream */
  public int b_o_s; /* set after we've written the initial page
                             of a logical bitstream */
  public int serialno;
  public int pageno;
  public ogg_int64_t packetno = new ogg_int64_t(); /* sequence number for decode; the framing
                             knows where there's a hole in the data,
                             but we need coupling so that the codec
                             (which is in a seperate abstraction
                             layer) also knows about the gap */
  public ogg_int64_t granulepos = new ogg_int64_t();

}

/* ogg_packet is used to encapsulate the data and metadata belonging
   to a single raw Ogg/Vorbis packet *************************************/

public class ogg_packet
{
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: byte *packet;
  public byte packet;
  public int bytes;
  public int b_o_s;
  public int e_o_s;

  public ogg_int64_t granulepos = new ogg_int64_t();

  public ogg_int64_t packetno = new ogg_int64_t(); /* sequence number for decode; the framing
				knows where there's a hole in the data,
				but we need coupling so that the codec
				(which is in a seperate abstraction
				layer) also knows about the gap */
}

public class ogg_sync_state
{
  public byte[] data;
  public int storage;
  public int fill;
  public int returned;

  public int unsynced;
  public int headerbytes;
  public int bodybytes;
}