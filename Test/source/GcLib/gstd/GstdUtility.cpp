#include"GstdUtility.hpp"
using namespace gstd;

//================================================================
//DebugUtility
void DebugUtility::DumpMemoryLeaksOnExit()
{
	#ifdef _DEBUG
	_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
	//_CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF | _CRTDBG_CHECK_ALWAYS_DF);
	//if(!_CrtCheckMemory())
	#endif
}

//================================================================
//Encoding
const unsigned char Encoding::BOM_UTF16LE[] = {0xFF, 0xFE};
int Encoding::Detect(const void* data, int dataSize)
{
	return UNKNOWN;
}
bool Encoding::IsUtf16Le(const void* data, int dataSize)
{
	if(dataSize < 2)return false;
	if(memcmp(data, "\0", 1) == 0)return false;

	bool res = memcmp(data, BOM_UTF16LE, 2) == 0;
	if(!res && false)
	{
		int test = IS_TEXT_UNICODE_UNICODE_MASK;
		int resIsTextUnicode = IsTextUnicode((void*)data, dataSize, &test);
		res = resIsTextUnicode > 0;
	}
	return res;
}
int Encoding::GetBomSize(const void* data, int dataSize)
{
	if(dataSize < 2)return 0;

	int res = 0;
	if(memcmp(data, BOM_UTF16LE, 2) == 0)
		res = 2;
	return res;
}


//================================================================
//StringUtility
std::string StringUtility::ConvertWideToMulti(std::wstring const &wstr, int codeMulti)
{
	if(wstr == L"")return "";

	//マ?チバイト変換後のサイズを調べます
	//WideCharToMultiByteの第6引?に0を渡すと変換後のサイズが返ります
	int sizeMulti = ::WideCharToMultiByte(codeMulti, 0, wstr.c_str(), -1, NULL, 0, NULL, NULL);
	if(sizeMulti == 0)return "";//失敗(とり?えず空文?とします)

	//最後の\0が含まれるため
	sizeMulti = sizeMulti - 1;

	//マ?チバイトに変換します
	std::string str;
	str.resize(sizeMulti);
	::WideCharToMultiByte(codeMulti, 0, wstr.c_str(), -1, &str[0], 
	            sizeMulti, NULL, NULL);
	return str;
}

std::wstring StringUtility::ConvertMultiToWide(std::string const &str, int codeMulti)
{
	if(str == "")return L"";

	//UNICODE変換後のサイズを調べます
	//MultiByteToWideCharの第6引?に0を渡すと変換後のサイズが返ります
	int sizeWide = ::MultiByteToWideChar(codeMulti, 0, str.c_str(), -1, NULL, 0 );
	if(sizeWide == 0)return L"";//失敗(とり?えず空文?とします)

	//最後の\0が含まれるため
	sizeWide = sizeWide - 1;

	//UNICODEに変換します
	std::wstring wstr;
	wstr.resize(sizeWide);
	::MultiByteToWideChar(codeMulti, 0, str.c_str(), -1, &wstr[0], sizeWide );
	return wstr;
}

std::string StringUtility::ConvertUtf8ToMulti(std::vector<char>& text)
{
	std::wstring wstr = ConvertUtf8ToWide(text); //UTF16に変換
	std::string strShiftJIS = ConvertWideToMulti(wstr); //ShiftJISに変換

	return strShiftJIS;
}
std::wstring StringUtility::ConvertUtf8ToWide(std::vector<char>& text)
{
	int posText = 0;
	if( (unsigned char)&text[0] == 0xef && 
		(unsigned char)&text[1] == 0xbb && 
		(unsigned char)&text[2] == 0xbf )
	{
		posText += 3;
	}

	std::string str = &text[posText];
	std::wstring wstr = ConvertMultiToWide(str, CP_UTF8); //UTF16に変換
	return wstr;
}

//----------------------------------------------------------------
std::vector<std::string> StringUtility::Split(std::string str, std::string delim)
{
	std::vector<std::string> res;
	Split(str, delim, res);
	return res;
}
void StringUtility::Split(std::string str, std::string delim, std::vector<std::string>& res)
{
//wcstok
	std::wstring wstr = StringUtility::ConvertMultiToWide(str);
	wchar_t* wsource = new wchar_t[wstr.size() + sizeof(wchar_t)];
	memcpy(wsource, wstr.c_str(), wstr.size() * sizeof(wchar_t));
	wsource[wstr.size()] = 0;
	std::wstring wdelim = StringUtility::ConvertMultiToWide(delim);

	wchar_t* pStr = NULL;
	wchar_t* cDelim = const_cast<wchar_t*>(wdelim.c_str());
	while( (pStr = wcstok(pStr==NULL ? wsource : NULL, cDelim)) != NULL ) 
	{
		//切り出した文?列を追加
		std::string s = StringUtility::ConvertWideToMulti(std::wstring(pStr));
		s = s.substr(0, s.size() - 1);//最後の\0を削?
		res.push_back(s);
	}
	delete[] wsource;

/*
	char* source = new char[str.size()+1];
	memcpy(source, str.c_str(), str.size());
	source[str.size()]='\0';

	char* pStr = NULL;
	char* cDelim = const_cast<char*>(delim.c_str());
	while( (pStr = strtok(pStr==NULL ? source : NULL, cDelim)) != NULL ) 
	{
		//切り出した文?列を追加
		res.push_back(std::string(pStr));
	}
	delete[] source;
*/
}

std::string StringUtility::Format(char* str, ...)
{
	std::string res;
	char buf[256];
	va_list	vl;
	va_start(vl,str);
	if(_vsnprintf(buf, sizeof(buf), str, vl) < 0)
	{	//バッファを超えていた場?、動的に確保する
		int size = sizeof(buf);
		while(true)
		{
			size *= 2;
			char* nBuf = new char[size];
			if(_vsnprintf(nBuf, size, str, vl) >= 0)
			{
				res = nBuf;
				delete[] nBuf;
				break;
			}
			delete[] nBuf;
		}
	}
	else
	{
		res = buf;
	}
	va_end(vl);
	return res;
}

int StringUtility::CountCharacter(std::string& str, char c)
{
	int count = 0;
	char* pbuf = &str[0];
	char* ebuf = &str[str.size()-1];
	while(pbuf <= ebuf)
	{
		if(*pbuf==c)
			count++;

		if(IsDBCSLeadByteEx(Encoding::CP_SHIFT_JIS, *pbuf))pbuf+=2;
		else pbuf++;		
	}
	return count;
}
int StringUtility::CountCharacter(std::vector<char>& str, char c)
{
	if(str.size() == 0)return 0;

	int encoding = Encoding::SHIFT_JIS;
	if(Encoding::IsUtf16Le(&str[0], str.size()))
		encoding = Encoding::UTF16LE;

	int count = 0;
	char* pbuf = &str[0];
	char* ebuf = &str[str.size()-1];
	while(pbuf <= ebuf)
	{
		if(encoding == Encoding::UTF16LE)
		{
			wchar_t ch = (wchar_t&)*pbuf;
			if(ch == (wchar_t)c)
				count++;
			pbuf+=2;
		}
		else
		{
			if(*pbuf == c)
				count++;
			if(IsDBCSLeadByteEx(Encoding::CP_SHIFT_JIS, *pbuf))pbuf+=2;
			else pbuf++;	
		}
	
	}
	return count;

}
int StringUtility::ToInteger(std::string const & s)
{
	return atoi(s.c_str());
}
double StringUtility::ToDouble(std::string const & s)
{
	return atof(s.c_str());
}
std::string StringUtility::Replace(std::string& source, std::string pattern, std::string placement)
{
	std::string res = ReplaceAll(source, pattern, placement, 1);
	return res;
}
std::string StringUtility::ReplaceAll(std::string& source, std::string pattern, std::string placement, int replaceCount, int start, int end)
{
	bool bDBCSLeadByteCheck = (pattern.size() == 1);
	std::string result;
	if(end == 0) end = source.size();
	std::string::size_type pos_before = 0;
	std::string::size_type pos = start;
	std::string::size_type len = pattern.size();

	int count = 0;
	while( ( pos = source.find( pattern, pos ) ) != std::string::npos ) 
	{
		if(pos > 0)
		{
			char ch = source[pos - 1];
			if(bDBCSLeadByteCheck && IsDBCSLeadByteEx(Encoding::CP_SHIFT_JIS, ch))
			{
				pos++;
				if(pos >= end) break;
				else continue;
			}
			if(pos >= end) break;
		}

		result.append(source, pos_before, pos - pos_before);
		result.append(placement);
		pos += len ;
		pos_before = pos ;

		count++;
		if(count >= replaceCount)break;
	}
	result.append(source, pos_before, source.size() - pos_before) ;
	return result;
}
std::string StringUtility::Slice(std::string const & s, int length)
{
	length = min(s.size()-1, length);
	return s.substr(0, length);
}
std::string StringUtility::Trim(const std::string& str) 
{
	if(str.size() == 0)return str;

	std::wstring wstr = StringUtility::ConvertMultiToWide(str);
	int left = 0;
	for(; left < wstr.size() ; left++)
	{
		wchar_t wch = wstr[left];
		if(wch != 0x20 && wch != 0x09)
			break;
	}

	int right = wstr.size() - 1;
	for(; right >= 0 ; right--)
	{
		wchar_t wch = wstr[right];
		if(wch != 0x20 && wch != 0x09 && wch != 0x0 && wch != '\r' && wch != '\n')
		{
			right++;
			break;
		}
	}

	std::wstring wres = wstr;
	if(left <= right)
	{
		wres = wstr.substr(left, right - left);
	}

	std::string res = StringUtility::ConvertWideToMulti(wres);
	return res;
}
//----------------------------------------------------------------
std::vector<std::wstring> StringUtility::Split(std::wstring str, std::wstring delim)
{
	std::vector<std::wstring> res;
	Split(str, delim, res);
	return res;
}
void StringUtility::Split(std::wstring str, std::wstring delim, std::vector<std::wstring>& res)
{
	wchar_t* wsource = (wchar_t*)str.c_str();
	wchar_t* pStr = NULL;
	wchar_t* cDelim = const_cast<wchar_t*>(delim.c_str());
	while( (pStr = wcstok(pStr==NULL ? wsource : NULL, cDelim)) != NULL ) 
	{
		//切り出した文?列を追加
		std::wstring s = std::wstring(pStr);
		//s = s.substr(0, s.size() - 1);//最後の\0を削?
		res.push_back(s);
	}
}
std::wstring StringUtility::Format(wchar_t* str, ...)
{
	std::wstring res;
	wchar_t buf[256];
	va_list	vl;
	va_start(vl, str);
	if(_vsnwprintf(buf, sizeof(buf) / 2, str, vl) < 0)
	{	//バッファを超えていた場?、動的に確保する
		int size = sizeof(buf);
		while(true)
		{
			size *= 2;
			wchar_t* nBuf = new wchar_t[size];
			if(_vsnwprintf(nBuf, size / 2, str, vl) >= 0)
			{
				res = nBuf;
				delete[] nBuf;
				break;
			}
			delete[] nBuf;
		}
	}
	else
	{
		res = buf;
	}
	va_end(vl);
	return res;
}
std::wstring StringUtility::FormatToWide(char* str, ...)
{
	std::string res;
	char buf[256];
	va_list	vl;
	va_start(vl,str);
	if(_vsnprintf(buf, sizeof(buf), str, vl) < 0)
	{	//バッファを超えていた場?、動的に確保する
		int size = sizeof(buf);
		while(true)
		{
			size *= 2;
			char* nBuf = new char[size];
			if(_vsnprintf(nBuf, size, str, vl) >= 0)
			{
				res = nBuf;
				delete[] nBuf;
				break;
			}
			delete[] nBuf;
		}
	}
	else
	{
		res = buf;
	}
	va_end(vl);

	std::wstring wres = StringUtility::ConvertMultiToWide(res);
	return wres;
}

int StringUtility::CountCharacter(std::wstring& str, wchar_t c)
{
	int count = 0;
	wchar_t* pbuf = &str[0];
	wchar_t* ebuf = &str[str.size()-1];
	while(pbuf <= ebuf)
	{
		if(*pbuf==c)
			count++;		
	}
	return count;
}
int StringUtility::ToInteger(std::wstring const & s)
{
	return _wtoi(s.c_str());
}
double StringUtility::ToDouble(std::wstring const & s)
{
	wchar_t *stopscan; 
    return wcstod(s.c_str(), &stopscan);
	//return _wtof(s.c_str());
}
std::wstring StringUtility::Replace(std::wstring& source, std::wstring pattern, std::wstring placement)
{
	std::wstring res = ReplaceAll(source, pattern, placement, 1);
	return res;
}
std::wstring StringUtility::ReplaceAll(std::wstring& source, std::wstring pattern, std::wstring placement, int replaceCount, int start , int end)
{
	std::wstring result;
	if(end == 0) end = source.size();
	std::wstring::size_type pos_before = 0;
	std::wstring::size_type pos = start;
	std::wstring::size_type len = pattern.size();

	int count = 0;
	while( ( pos = source.find( pattern, pos ) ) != std::wstring::npos ) 
	{
		result.append(source, pos_before, pos - pos_before);
		result.append(placement);
		pos += len ;
		pos_before = pos ;

		count++;
		if(count >= replaceCount)break;
	}
	result.append(source, pos_before, source.size() - pos_before) ;
	return result;
}
std::wstring StringUtility::Slice(std::wstring const & s, int length)
{
	length = min(s.size()-1, length);
	return s.substr(0, length);
}
std::wstring StringUtility::Trim(const std::wstring& str)
{
	if(str.size() == 0)return str;

	int left = 0;
	for(; left < str.size() ; left++)
	{
		wchar_t wch = str[left];
		if(wch != 0x20 && wch != 0x09)
			break;
	}

	int right = str.size() - 1;
	for(; right >= 0 ; right--)
	{
		wchar_t wch = str[right];
		if(wch != 0x20 && wch != 0x09 && wch != 0x0 && wch != '\r' && wch != '\n')
		{
			right++;
			break;
		}
	}

	std::wstring res = str;
	if(left <= right)
	{
		res = str.substr(left, right - left);
	}
	return res;
}
int StringUtility::CountAsciiSizeCharacter(std::wstring& str)
{
	if(str.size() == 0)return 0;

	int wcount = str.size();
	WORD *listType = new WORD[wcount];
	GetStringTypeEx(0, CT_CTYPE3, str.c_str(), wcount, listType);

	int res = 0;
	for(int iType = 0 ; iType < wcount ; iType++)
	{
		WORD type = listType[iType];
		if ((type& C3_HALFWIDTH) == C3_HALFWIDTH)
		{
			res++;
		}
		else
		{
			res += 2;
		}
	}

	delete[] listType;
	return res;
}
int StringUtility::GetByteSize(std::wstring& str)
{
	int res = str.size() * sizeof(wchar_t);
	return res;
}
