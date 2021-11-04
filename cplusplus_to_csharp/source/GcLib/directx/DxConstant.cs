// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

// lib
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"msacm32.lib") //for acm
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"d3d9.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"d3dx9.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"dxguid.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"dinput8.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"dsound.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"d3dxof.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"dxerr9.lib")

// define

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DWORD_PTR DWORD*

#if DEBUG
#undef new
#endif

// include

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<mmreg.h> //for acm
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<msacm.h> //for acm

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<basetsd.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<d3d9.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<d3dx9.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<dinput.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<dsound.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<dmusici.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<dxerr9.h>

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free

#if UNICODE || _UNICODE
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(linker, "/entry:\"wWinMainCRTStartup\"")
#endif


#if DEBUG
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <crtdbg.h>
#define _CRTDBG_MAP_ALLOC
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)
#define new
#endif



