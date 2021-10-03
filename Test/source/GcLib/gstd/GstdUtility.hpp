#ifndef __GSTD_UTILITIY__
#define __GSTD_UTILITIY__

#include"GstdConstant.hpp"

namespace gstd
{
	//================================================================
	//wexception
	class wexception
	{
		protected:
			std::wstring message_;
		public:
			wexception(){}
			wexception(std::wstring msg){message_ = msg;}
			std::wstring GetMessage(){return message_;}
			const wchar_t* what(){return message_.c_str();}
	};

	//================================================================
	//DebugUtility
	class DebugUtility
	{
		public:
			static void DumpMemoryLeaksOnExit();
	};

	//================================================================
	//SystemUtility
	class SystemUtility
	{
		public:

	};

	//================================================================
	//Encoding
	class Encoding
	{
		//http://msdn.microsoft.com/ja-jp/library/system.text.encoding(v=vs.110).aspx
		//babel
		//http://d.hatena.ne.jp/A7M/20100801/1280629387
		public:
			enum
			{
				UNKNOWN = -1,
				SHIFT_JIS = 1,
				UTF16LE,
			};

			enum
			{
				CP_SHIFT_JIS = 932,
			};
		public:
			static int Detect(const void* data, int dataSize);
			static bool IsUtf16Le(const void* data, int dataSize);
			static int GetBomSize(const void* data, int dataSize);

			static const unsigned char BOM_UTF16LE[];
	};
	

	//================================================================
	//StringUtility
	class StringUtility
	{
		public:
			static std::string ConvertWideToMulti(std::wstring const &wstr, int codeMulti = 932);
			static std::wstring ConvertMultiToWide(std::string const &str, int codeMulti = 932);
			static std::string ConvertUtf8ToMulti(std::vector<char>& text);
			static std::wstring ConvertUtf8ToWide(std::vector<char>& text);

			//----------------------------------------------------------------
			static std::vector<std::string> Split(std::string str, std::string delim);
			static void Split(std::string str, std::string delim, std::vector<std::string>& res);
			static std::string Format(char* str, ...);

			static int CountCharacter(std::string& str, char c);
			static int CountCharacter(std::vector<char>& str, char c);
			static int ToInteger(std::string const & s);
			static double ToDouble(std::string const & s);
			static std::string Replace(std::string& source, std::string pattern, std::string placement);
			static std::string ReplaceAll(std::string& source, std::string pattern, std::string placement, int replaceCount = INT_MAX, int start = 0 , int end = 0);
			static std::string Slice(std::string const & s, int length);
			static std::string Trim(const std::string& str);

			//----------------------------------------------------------------
			//std::wstring.sizeは文??を返す。バイト?ではない。
			static std::vector<std::wstring> Split(std::wstring str, std::wstring delim);
			static void Split(std::wstring str, std::wstring delim, std::vector<std::wstring>& res);
			static std::wstring Format(wchar_t* str, ...);
			static std::wstring FormatToWide(char* str, ...);

			static int CountCharacter(std::wstring& str, wchar_t c);
			static int ToInteger(std::wstring const & s);
			static double ToDouble(std::wstring const & s);
			static std::wstring Replace(std::wstring& source, std::wstring pattern, std::wstring placement);
			static std::wstring ReplaceAll(std::wstring& source, std::wstring pattern, std::wstring placement, int replaceCount = INT_MAX, int start = 0 , int end = 0);
			static std::wstring Slice(std::wstring const & s, int length);
			static std::wstring Trim(const std::wstring& str);
			static int CountAsciiSizeCharacter(std::wstring& str);
			static int GetByteSize(std::wstring& str);
	};

}

#endif
