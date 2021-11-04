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

 function: #ifdef jail to whip a few platforms into the UNIX ideal.
 last mod: $Id: os_types.h,v 1.14 2003/09/02 05:09:14 xiphmont Exp $

 ********************************************************************/

/* make it easy on the folks that want to compile the libs with a
   different malloc than stdlib */
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free

#if _WIN32

#if ! __GNUC__
   /* MSVC/Borland */
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef long ogg_int64_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef uint ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef short ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef ushort ogg_uint16_t;
#else
   /* Cygwin */
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//   #include <_G_config.h>
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef _G_int64_t ogg_int64_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef _G_int32_t ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef _G_uint32_t ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef _G_int16_t ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef _G_uint16_t ogg_uint16_t;
#endif

#elif __MACOS__

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <sys/types.h>
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef SInt16 ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef UInt16 ogg_uint16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef SInt32 ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef UInt32 ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef SInt64 ogg_int64_t;

#elif __MACOSX__ // MacOS X Framework build

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <sys/types.h>
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int16_t ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef u_int16_t ogg_uint16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int32_t ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef u_int32_t ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int64_t ogg_int64_t;

#elif __BEOS__

   /* Be */
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int16_t ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef u_int16_t ogg_uint16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int32_t ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef u_int32_t ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int64_t ogg_int64_t;

#elif __EMX__

   /* OS/2 GCC */
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef short ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef ushort ogg_uint16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef uint ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef long ogg_int64_t;

#elif DJGPP

   /* DJGPP */
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef short ogg_int16_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef uint ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef long ogg_int64_t;

#elif R5900

   /* PS2 EE */
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int ogg_int64_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef int ogg_int32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef uint ogg_uint32_t;
// C++ TO C# CONVERTER TODO TASK: Typedefs defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
//   typedef short ogg_int16_t;

#else

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <sys/types.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <ogg/config_types.h>

#endif

