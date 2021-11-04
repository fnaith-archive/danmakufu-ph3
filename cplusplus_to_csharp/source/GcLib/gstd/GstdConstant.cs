// Unicode
#if _MBCS
#undef _MBCS
#endif


// �W?��?��?�
// http://www1.kokusaika.jp/advisory/org/ja/win32_unicode.html

// Win2000�ȍ~

// lib
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"winmm.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"comctl32.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"pdh.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"gdi32.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"shlwapi.lib")
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma comment(lib,"psapi.lib")

// pragma
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4786) //STL Warning�}�~
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4018) //signed �� unsigned ��?�l���r
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4244) //double' ���� 'float' �ɕϊ�
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4503)

// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4302) // �؂�l�߂܂��B
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4305) // 'double' ���� 'FLOAT' �֐؂�l�߂܂��B
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4819) //�t�@�C?�́A���݂̃R�[�h �y�[�W (932) �ŕ\���ł��Ȃ���?��܂�ł��܂��B�f�[�^�̑�����h�����߂ɁA�t�@�C?�� Unicode �`���ŕۑ����Ă��������B
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
// #pragma warning (disable:4996) //This function or variable may be unsafe.


// define

// std


// Windows
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<windowsx.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<mmsystem.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<commctrl.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<pdh.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<process.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<wingdi.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<shlwapi.h>

// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<mlang.h>
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include<psapi.h>



#if DEBUG
// C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
// #include <crtdbg.h>
#define _CRTDBG_MAP_ALLOC
// C++ TO C# CONVERTER TODO TASK: #define macros defined in multiple preprocessor conditionals can only be replaced within the scope of the preprocessor conditional:
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)
#define new
#endif


