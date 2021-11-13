using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{

    // ================================================================
    // DebugUtility
    public class DebugUtility
    {

            // ================================================================
            // DebugUtility
            public static void DumpMemoryLeaksOnExit()
            {
#if DEBUG
                _CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF);
                // _CrtSetDbgFlag(_CRTDBG_ALLOC_MEM_DF | _CRTDBG_LEAK_CHECK_DF | _CRTDBG_CHECK_ALWAYS_DF);
                // if(!_CrtCheckMemory())
#endif
            }
    }

    // ================================================================
    // SystemUtility
    public class SystemUtility
    {

    }

    // ================================================================
    // Encoding
    public class Encoding
    {
        // http://msdn.microsoft.com/ja-jp/library/system.text.encoding(v=vs.110).aspx
        // babel
        // http://d.hatena.ne.jp/A7M/20100801/1280629387
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                UNKNOWN = -1,
                SHIFT_JIS = 1,
                UTF16LE
            }

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum2
            {
                CP_SHIFT_JIS = 932
            }
            public static int Detect(object data, int dataSize)
            {
                return (int)AnonymousEnum.UNKNOWN;
            }

            public static bool IsUtf16Le(object data, int dataSize)
            {
                if (dataSize < 2)
                {
                    return false;
                }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                if (memcmp(data, "\0", 1) == 0)
                {
                    return false;
                }

// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                bool res = memcmp(data, BOM_UTF16LE, 2) == 0;
                if (!res && false)
                {
                    int test = IS_TEXT_UNICODE_UNICODE_MASK;
                    int resIsTextUnicode = IsTextUnicode((object)data, dataSize, test);
                    res = resIsTextUnicode > 0;
                }
                return res;
            }

            public static int GetBomSize(object data, int dataSize)
            {
                if (dataSize < 2)
                {
                    return 0;
                }

                int res = 0;
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                if (memcmp(data, BOM_UTF16LE, 2) == 0)
                {
                    res = 2;
                }
                return res;
            }

            public const byte[] BOM_UTF16LE = { 0xFF, 0xFE };
    }


    // ================================================================
    // StringUtility
    public class StringUtility
    {

            // ================================================================
            // Encoding


            // ================================================================
            // StringUtility
            public static string ConvertWideToMulti(string wstr, int codeMulti = 932)
            {
                if (wstr == "")
                {
                    return "";
                }

                // ?
                // WideCharToMultiByte6?0
                int sizeMulti = global::WideCharToMultiByte(codeMulti, 0, wstr, -1, null, 0, null, null);
                if (sizeMulti == 0)
                {
                    return ""; // (??)
                }

                // \0
                sizeMulti = sizeMulti - 1;

                // ?
                string str;
                str.resize(sizeMulti);
                global::WideCharToMultiByte(codeMulti, 0, wstr, -1, str[0], sizeMulti, null, null);
                return str;
            }

            public static string ConvertMultiToWide(string str, int codeMulti = 932)
            {
                if (str == "")
                {
                    return "";
                }

                // UNICODE
                // MultiByteToWideChar6?0
                int sizeWide = global::MultiByteToWideChar(codeMulti, 0, str, -1, null, 0);
                if (sizeWide == 0)
                {
                    return ""; // (??)
                }

                // \0
                sizeWide = sizeWide - 1;

                // UNICODE
                string wstr;
                wstr.resize(sizeWide);
                global::MultiByteToWideChar(codeMulti, 0, str, -1, wstr[0], sizeWide);
                return wstr;
            }

            public static string ConvertUtf8ToMulti(List<char> text)
            {
                string wstr = ConvertUtf8ToWide(text); // UTF16
                string strShiftJIS = ConvertWideToMulti(wstr); // ShiftJIS

                return strShiftJIS;
            }

            public static string ConvertUtf8ToWide(List<char> text)
            {
                int posText = 0;
                if ((byte) text[0] == 0xef && (byte) text[1] == 0xbb && (byte) text[2] == 0xbf)
                {
                    posText += 3;
                }

                string str = text[posText];
                string wstr = ConvertMultiToWide(str, CP_UTF8); // UTF16
                return wstr;
            }

            // ----------------------------------------------------------------

            // ----------------------------------------------------------------
            public static List<string> Split(string str, string delim)
            {
                List<string> res = new List<string>();
                Split(str, delim, res);
                return new List<string>(res);
            }

            public static void Split(string str, string delim, List<string> res)
            {
                // wcstok
                string wstr = StringUtility.ConvertMultiToWide(str);
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                string wsource = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) char[wstr.Length + sizeof(char)];
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(wsource, wstr, wstr.Length * sizeof(char));
                wsource = wsource.Substring(0, wstr.Length);
                string wdelim = StringUtility.ConvertMultiToWide(delim);

                string pStr = null;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* cDelim = const_cast<char*>(wdelim.c_str());
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'const_cast' in C#:
                char cDelim = const_cast<char>(wdelim);
                while ((pStr = wcstok(pStr == null ? wsource : null, cDelim)) != null)
                {
                    // ?
                    string s = StringUtility.ConvertWideToMulti(new string(pStr));
                    s = s.Substring(0, s.Length - 1); // \0?
                    res.Add(s);
                }
                wsource = null;

                /*
                	char* source = new char[str.size()+1];
                	memcpy(source, str.c_str(), str.size());
                	source[str.size()]='\0';
            
                	char* pStr = NULL;
                	char* cDelim = const_cast<char*>(delim.c_str());
                	while( (pStr = strtok(pStr==NULL ? source : NULL, cDelim)) != NULL )
                	{
                		//?
                		res.push_back(std::string(pStr));
                	}
                	delete[] source;
                */
            }

            public static string Format(ref string str, params object[] LegacyParamArray)
            {
                string res;
                string buf = new string(new char[256]);
//                va_list vl;
                int ParamCount = -1;
//                va_start(vl, str);
                if (_vsnprintf(buf, sizeof(char), str, vl) < 0)
                { // ?
                    int size = sizeof(char);
                    while (true)
                    {
                        size *= 2;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        string nBuf = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) char[size];
                        if (_vsnprintf(nBuf, size, str, vl) >= 0)
                        {
                            res = nBuf;
                            nBuf = null;
                            break;
                        }
                        nBuf = null;
                    }
                }
                else
                {
                    res = buf;
                }
//                va_end(vl);
                return res;
            }

            public static int ToInteger(string s)
            {
                return atoi(s);
            }

            public static double ToDouble(string s)
            {
                return atof(s);
            }

            public static string Replace(string source, string pattern, string placement)
            {
                string res = ReplaceAll(source, pattern, placement, 1);
                return res;
            }

            public static string ReplaceAll(string source, string pattern, string placement, int replaceCount = INT_MAX, int start = 0, int end = 0)
            {
                bool bDBCSLeadByteCheck = (pattern.Length == 1);
                string result;
                if (end == 0)
                {
                    end = source.Length;
                }
                int pos_before = 0;
                int pos = start;
                int len = pattern.Length;

                int count = 0;
                while ((pos = source.IndexOf(pattern, pos)) != -1)
                {
                    if (pos > 0)
                    {
                        char ch = source[pos - 1];
                        if (bDBCSLeadByteCheck && IsDBCSLeadByteEx(Encoding.CP_SHIFT_JIS, ch))
                        {
                            pos++;
                            if (pos >= end)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (pos >= end)
                        {
                            break;
                        }
                    }

                    result.append(source, pos_before, pos - pos_before);
                    result.append(placement);
                    pos += len;
                    pos_before = pos;

                    count++;
                    if (count >= replaceCount)
                    {
                        break;
                    }
                }
                result.append(source, pos_before, source.Length - pos_before);
                return result;
            }

            public static string Slice(string s, int length)
            {
                length = System.Math.Min(s.Length - 1, length);
                return s.Substring(0, length);
            }

            public static string Trim(string str)
            {
                if (str.Length == 0)
                {
                    return str;
                }

                string wstr = StringUtility.ConvertMultiToWide(str);
                int left = 0;
                for (; left < wstr.Length; left++)
                {
                    char wch = wstr[left];
                    if (wch != 0x20 && wch != 0x09)
                    {
                        break;
                    }
                }

                int right = wstr.Length - 1;
                for (; right >= 0; right--)
                {
                    char wch = wstr[right];
                    if (wch != 0x20 && wch != 0x09 && wch != 0x0 && wch != '\r' && wch != '\n')
                    {
                        right++;
                        break;
                    }
                }

                string wres = wstr;
                if (left <= right)
                {
                    wres = wstr.Substring(left, right - left);
                }

                string res = StringUtility.ConvertWideToMulti(wres);
                return res;
            }

            // ----------------------------------------------------------------
            // std::wstring.size�͕�������Ԃ��B�o�C�g���ł͂Ȃ��B
            // ----------------------------------------------------------------
            public static List<string> Split(string str, string delim)
            {
                List<string> res = new List<string>();
                Split(str, delim, res);
                return new List<string>(res);
            }

            public static void Split(string str, string delim, List<string> res)
            {
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* wsource = (char*)str.c_str();
                char wsource = (string)str;
                string pStr = null;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* cDelim = const_cast<char*>(delim.c_str());
// C++ TO C# CONVERTER TODO TASK: There is no equivalent to 'const_cast' in C#:
                char cDelim = const_cast<char>(delim);
                while ((pStr = wcstok(pStr == null ? wsource : null, cDelim)) != null)
                {
                    // ?
                    string s = pStr;
                    // s = s.substr(0, s.size() - 1);//\0?
                    res.Add(s);
                }
            }

            public static string Format(ref string str, params object[] LegacyParamArray)
            {
                string res;
                string buf = new string(new char[256]);
//                va_list vl;
                int ParamCount = -1;
//                va_start(vl, str);
                if (_vsnwprintf(buf, sizeof(buf) / 2, str, vl) < 0)
                { // ?
                    int size = sizeof(char);
                    while (true)
                    {
                        size *= 2;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        string nBuf = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) char[size];
                        if (_vsnwprintf(nBuf, size / 2, str, vl) >= 0)
                        {
                            res = nBuf;
                            nBuf = null;
                            break;
                        }
                        nBuf = null;
                    }
                }
                else
                {
                    res = buf;
                }
//                va_end(vl);
                return res;
            }

            public static string FormatToWide(ref string str, params object[] LegacyParamArray)
            {
                string res;
                string buf = new string(new char[256]);
//                va_list vl;
                int ParamCount = -1;
//                va_start(vl, str);
                if (_vsnprintf(buf, sizeof(char), str, vl) < 0)
                { // ?
                    int size = sizeof(char);
                    while (true)
                    {
                        size *= 2;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        string nBuf = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) char[size];
                        if (_vsnprintf(nBuf, size, str, vl) >= 0)
                        {
                            res = nBuf;
                            nBuf = null;
                            break;
                        }
                        nBuf = null;
                    }
                }
                else
                {
                    res = buf;
                }
//                va_end(vl);

                string wres = StringUtility.ConvertMultiToWide(res);
                return wres;
            }

            public static int CountCharacter(string str, char c)
            {
                int count = 0;
                string pbuf = str[0];
                string ebuf = str[str.Length - 1];
                while (pbuf <= ebuf)
                {
                    if (pbuf == c)
                    {
                        count++;
                    }
                }
                return count;
            }

            public static int ToInteger(string s)
            {
                return _wtoi(s);
            }

            public static double ToDouble(string s)
            {
                string stopscan;
                return wcstod(s, stopscan);
                // return _wtof(s.c_str());
            }

            public static string Replace(string source, string pattern, string placement)
            {
                string res = ReplaceAll(source, pattern, placement, 1);
                return res;
            }

            public static string ReplaceAll(string source, string pattern, string placement, int replaceCount = INT_MAX, int start = 0, int end = 0)
            {
                string result;
                if (end == 0)
                {
                    end = source.Length;
                }
                string.size_type pos_before = 0;
                string.size_type pos = start;
                string.size_type len = pattern.Length;

                int count = 0;
                while ((pos = source.IndexOf(pattern, pos)) != -1)
                {
                    result.append(source, pos_before, pos - pos_before);
                    result.append(placement);
                    pos += len;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pos_before = pos;
                    pos_before.CopyFrom(pos);

                    count++;
                    if (count >= replaceCount)
                    {
                        break;
                    }
                }
                result.append(source, pos_before, source.Length - pos_before);
                return result;
            }

            public static string Slice(string s, int length)
            {
                length = System.Math.Min(s.Length - 1, length);
                return s.Substring(0, length);
            }

            public static string Trim(string str)
            {
                if (str.Length == 0)
                {
                    return str;
                }

                int left = 0;
                for (; left < str.Length; left++)
                {
                    char wch = str[left];
                    if (wch != 0x20 && wch != 0x09)
                    {
                        break;
                    }
                }

                int right = str.Length - 1;
                for (; right >= 0; right--)
                {
                    char wch = str[right];
                    if (wch != 0x20 && wch != 0x09 && wch != 0x0 && wch != '\r' && wch != '\n')
                    {
                        right++;
                        break;
                    }
                }

                string res = str;
                if (left <= right)
                {
                    res = str.Substring(left, right - left);
                }
                return res;
            }

            public static int CountAsciiSizeCharacter(string str)
            {
                if (str.Length == 0)
                {
                    return 0;
                }

                int wcount = str.Length;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ushort[] listType = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) ushort[wcount];
                GetStringTypeEx(0, CT_CTYPE3, str, wcount, listType);

                int res = 0;
                for (int iType = 0; iType < wcount; iType++)
                {
                    ushort type = listType[iType];
                    if ((type & C3_HALFWIDTH) == C3_HALFWIDTH)
                    {
                        res++;
                    }
                    else
                    {
                        res += 2;
                    }
                }

                listType = null;
                return res;
            }

            public static int GetByteSize(string str)
            {
                int res = str.Length * sizeof(char);
                return res;
            }
    }

    // ================================================================
    // ErrorUtility
    public class ErrorUtility
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum3
            {
                ERROR_FILE_NOTFOUND,
                ERROR_PARSE,
                ERROR_END_OF_FILE,
                ERROR_OUTOFRANGE_INDEX
            }

            // ================================================================
            // ErrorUtility
            public static string GetLastErrorMessage(uint error)
            {
                object lpMsgBuf;
                global::FormatMessage(FORMAT_MESSAGE_ALLOCATE_BUFFER | FORMAT_MESSAGE_FROM_SYSTEM | FORMAT_MESSAGE_IGNORE_INSERTS, null, error, MAKELANGID(LANG_NEUTRAL, SUBLANG_DEFAULT), (string) & lpMsgBuf, 0, null);
                string res = (string)lpMsgBuf;
                global::LocalFree(lpMsgBuf);
                return res;
            }

            public static string GetLastErrorMessage()
            {
                return GetLastErrorMessage(GetLastError());
            }

            public static string GetErrorMessage(int type)
            {
                string res = "unknown error";
                if (type == (int)AnonymousEnum3.ERROR_FILE_NOTFOUND)
                {
                    res = "cannot file open";
                }
                else if (type == (int)AnonymousEnum3.ERROR_PARSE)
                {
                    res = "parse failed";
                }
                else if (type == (int)AnonymousEnum3.ERROR_END_OF_FILE)
                {
                    res = "end of file error";
                }
                else if (type == (int)AnonymousEnum3.ERROR_OUTOFRANGE_INDEX)
                {
                    res = "invalid index";
                }
                return res;
            }

            public static string GetFileNotFoundErrorMessage(string path)
            {
                string res = GetErrorMessage((int)AnonymousEnum3.ERROR_FILE_NOTFOUND);
                res += StringUtility.Format(" path[%s]", path);
                return res;
            }

            public static string GetParseErrorMessage(int line, string what)
            {
                return GetParseErrorMessage("", line, what);
            }

            public static string GetParseErrorMessage(string path, int line, string what)
            {
                string res = GetErrorMessage((int)AnonymousEnum3.ERROR_PARSE);
                res += StringUtility.Format(" path[%s] line[%d] msg[%s]", path, line, what);
                return res;
            }
    }
    public class Math
    {
            public static double DegreeToRadian(double angle)
            {
                return angle * GlobalMembers.PAI / 180;
            }
            public static double RadianToDegree(double angle)
            {
                return angle * 180 / GlobalMembers.PAI;
            }


            // ================================================================
            // Math
            public static void InitializeFPU()
            {
                __asm
                {
                    finit
                };
            }

            public static double Round(double val)
            {
                return floorl(val + 0.5);
            }
    }

    // ================================================================
    // ByteOrder
    public class ByteOrder
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum4
            {
                ENDIAN_LITTLE,
                ENDIAN_BIG
            }


            // ================================================================
            // ByteOrder
            public static void Reverse(object buf, uint size)
            {
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
                byte * pStart = (byte)buf;
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
                byte * pEnd = (byte)((byte)buf + size - 1);

                for (; pStart < pEnd;)
                {
                    byte temp = *pStart;
                    *pStart = *pEnd;
                    *pEnd = temp;

                    pStart++;
                    pEnd--;
                }
            }

    }

    // ================================================================
    // Sort
    public class SortUtility
    {
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <class BidirectionalIterator, class Predicate>
            public static void CombSort<BidirectionalIterator, Predicate>(BidirectionalIterator first, BidirectionalIterator last, Predicate pr)
            {
                int gap = (int)std::distance(first, last);
                if (gap < 1)
                {
                    return;
                }

                BidirectionalIterator first2 = last;
                bool swapped = false;
                do
                {
                    int newgap = (gap * 10 + 3) / 13;
                    if (newgap < 1)
                    {
                        newgap = 1;
                    }
                    if (newgap == 9 || newgap == 10)
                    {
                        newgap = 11;
                    }
                    std::advance(first2, newgap - gap);
                    gap = newgap;
                    swapped = false;
                    for (BidirectionalIterator target1 = first, target2 = first2; target2 != last; ++target1, ++target2)
                    {
                        if (pr(*target2, *target1))
                        {
                            std::iter_swap(target1, target2);
                            swapped = true;
                        }
                    }
                } while ((gap > 1) || swapped);
            }
    }

    // ================================================================
    // BitAccess
    public class BitAccess
    {
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public static bool GetBit<T>(T value, int bit)
            {
                T mask = (T)1 << bit;
                return (value & mask) != 0;
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public static T SetBit<T>(T value, int bit, bool b)
            {
                T mask = (T)1 << bit;
                T write = (T)b << bit;
                value &= ~mask;
                value |= write;
                return value;
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public static byte GetByte<T>(T value, int bit)
            {
                return (byte)(value >> bit);
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public static T SetByte<T>(T value, int bit, byte c)
            {
                T mask = (T)0xff << bit;
                T write = (T)c << bit;
                value &= ~mask;
                value |= write;
                return value;
            }
    }

    // ================================================================
    // IStringInfo
    public class IStringInfo : System.IDisposable
    {
            public virtual void Dispose()
            {
            }
            public virtual string GetInfoAsString()
            {
                int address = (int)this;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* name = (char*)typeid(*this).name();
// C++ TO C# CONVERTER TODO TASK: There is no C# equivalent to the C++ 'typeid' operator:
                char name = (string)typeid(this).name();
                string str = StringUtility.Format("%s[%08x]", name, address);
                string res = StringUtility.ConvertMultiToWide(str);
                return res;
            }
    }

    // ================================================================
    // InnerClass
    // C++�ɂ͓����N���X���Ȃ��̂ŁA�O���N���X�A�N�Z�X�p
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <class T>
    public class InnerClass <T>
    {
        private T outer_;
            protected T _GetOuter()
            {
                return outer_;
            }
            protected void _SetOuter(T outer)
            {
                outer_ = outer;
            }
            public InnerClass(T outer = null)
            {
                outer_ = outer;
            }
    }

    // ================================================================
    // Singleton
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<class T>
    public class Singleton <T> : System.IDisposable
    {
            protected Singleton()
            {
            }
// C++ TO C# CONVERTER NOTE: This was formerly a static local variable declaration (not allowed in C#):
            private static T _This_s = null;

            protected static T * _This()
            {
// C++ TO C# CONVERTER NOTE: This static local variable declaration (not allowed in C#) has been moved just prior to the method:
//                static T* s = NULL;
                return _This_s;
            }
            public virtual void Dispose()
            {
            }
            public static T CreateInstance()
            {
                if (_This() == null)
                {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                    _This() = global::TangibleGlobalScope.new(_NORMAL_BLOCK, __FILE__, __LINE__)(_NORMAL_BLOCK, __FILE__, __LINE__) default(T);
                }
                return _This();
            }
            public static T GetInstance()
            {
                if (_This() == null)
                {
                    throw new System.Exception("Singleton::GetInstance ��������");
                }
                return _This();
            }
            public static void DeleteInstance()
            {
                if (_This() != null)
                {
                    _This() = null;
                }
                _This() = null;
            }
    }

    // ================================================================
    // Scanner
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class Scanner;
    public class Token : System.IDisposable
    {
            public string GetElementA()
            {
                string wstr = GetElement();
                string res = StringUtility.ConvertWideToMulti(wstr);
                return res;
            }

            public int GetStartPointer()
            {
                return posStart_;
            }
            public int GetEndPointer()
            {
                return posEnd_;
            }

            public int GetInteger()
            {
                if (type_ != Type.TK_INT)
                {
                    throw new gstd.wexception("Token::GetInterger:");
                }
                return StringUtility.ToInteger(element_);
            }

            public double GetReal()
            {
                if (type_ != Type.TK_REAL && type_ != Type.TK_INT)
                {
                    throw new gstd.wexception("Token::GetReal:");
                }
                return StringUtility.ToDouble(element_);
            }

            public bool GetBoolean()
            {
                bool res = false;
                if (type_ == Type.TK_REAL && type_ == Type.TK_INT)
                {
                    res = GetReal() == 1;
                }
                else
                {
                    res = element_ == "true";
                }
                return res;
            }

            public string GetStringA()
            {
                string wstr = GetString();
                string res = StringUtility.ConvertWideToMulti(wstr);
                return res;
            }

            public string GetIdentifierA()
            {
                string wstr = GetIdentifier();
                string res = StringUtility.ConvertWideToMulti(wstr);
                return res;
            }
    }

    public class Scanner : System.IDisposable
    {
            public bool CompareMemory(int start, int end, string data)
            {
                if (end >= buffer_.Count)
                {
                    return false;
                }

                int bufSize = end - start;
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                bool res = memcmp(buffer_[start], data, bufSize) == 0;
                return res;
            }
    }

    // ================================================================
    // TextParser
    public class TextParser : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum6
            {
                TYPE_REAL,
                TYPE_BOOLEAN,
                TYPE_STRING
            }

            public class Result : System.IDisposable
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend TextParser;
                    protected int type_;
                    protected int pos_;
                    protected string valueString_ = "";
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//                    union
//                    {
//                        double valueReal_;
//                        bool valueBoolean_;
//                    };
                    public virtual void Dispose()
                    {
                    }
                    public int GetType()
                    {
                        return type_;
                    }
                    public double GetReal()
                    {
                        double res = valueReal_;
                        if (IsBoolean())
                        {
                            res = valueBoolean_ ? 1.0 : 0.0;
                        }
                        if (IsString())
                        {
                            res = StringUtility.ToDouble(valueString_);
                        }
                        return res;
                    }
                    public void SetReal(double value)
                    {
                        type_ = TYPE_REAL;
                        valueReal_ = value;
                    }
                    public bool GetBoolean()
                    {
                        bool res = valueBoolean_;
                        if (IsReal())
                        {
                            res = (valueReal_ != 0.0 ? true : false);
                        }
                        if (IsString())
                        {
                            res = (valueString_ == "true" ? true : false);
                        }
                        return res;
                    }
                    public void SetBoolean(bool value)
                    {
                        type_ = TYPE_BOOLEAN;
                        valueBoolean_ = value;
                    }
                    public string GetString()
                    {
                        string res = valueString_;
                        if (IsReal())
                        {
                            res = gstd.StringUtility.Format("%f", valueReal_);
                        }
                        if (IsBoolean())
                        {
                            res = (valueBoolean_ ? "true" : "false");
                        }
                        return res;
                    }
                    public void SetString(string value)
                    {
                        type_ = TYPE_STRING;
                        valueString_ = value;
                    }
                    public bool IsReal()
                    {
                        return type_ == TYPE_REAL;
                    }
                    public bool IsBoolean()
                    {
                        return type_ == TYPE_BOOLEAN;
                    }
                    public bool IsString()
                    {
                        return type_ == TYPE_STRING;
                    }
            }

            protected gstd.ref_count_ptr<Scanner> scan_ = new gstd.ref_count_ptr<Scanner>();

            protected void _RaiseError(string message)
            {
                throw new gstd.wexception(message);
            }

            protected TextParser.Result _ParseComparison(int pos)
            {
                Result res = _ParseSum(pos);
                while (scan_.HasNext())
                {
                    scan_.SetCurrentPointer(res.pos_);

                    Token tok = scan_.Next();
                    int type = (int)tok.GetType();
                    if (type == Token.TK_EXCLAMATION || type == Token.TK_EQUAL)
                    {
                        // ==!=
                        bool bNot = type == Token.TK_EXCLAMATION;
                        tok = scan_.Next();
                        type = (int)tok.GetType();
                        if (type != Token.TK_EQUAL)
                        {
                            break;
                        }

                        Result tRes = _ParseSum(scan_.GetCurrentPointer());
                        res.pos_ = tRes.pos_;
                        if (res.type_ == AnonymousEnum6.TYPE_BOOLEAN && tRes.type_ == AnonymousEnum6.TYPE_BOOLEAN)
                        {
                            res.valueBoolean_ = bNot ? res.valueBoolean_ != tRes.valueBoolean_ : res.valueBoolean_ == tRes.valueBoolean_;
                        }
                        else if (res.type_ == AnonymousEnum6.TYPE_REAL && tRes.type_ == AnonymousEnum6.TYPE_REAL)
                        {
                            res.valueBoolean_ = bNot ? res.valueReal_ != tRes.valueReal_ : res.valueReal_ == tRes.valueReal_;
                        }
                        else
                        {
                            _RaiseError("1153");
                        }
                        res.type_ = AnonymousEnum6.TYPE_BOOLEAN;
                    }
                    else if (type == Token.TK_PIPE)
                    {
                        tok = scan_.Next();
                        type = (int)tok.GetType();
                        if (type != Token.TK_PIPE)
                        {
                            break;
                        }
                        Result tRes = _ParseSum(scan_.GetCurrentPointer());
                        res.pos_ = tRes.pos_;
                        if (res.type_ == AnonymousEnum6.TYPE_BOOLEAN && tRes.type_ == AnonymousEnum6.TYPE_BOOLEAN)
                        {
                            res.valueBoolean_ = res.valueBoolean_ || tRes.valueBoolean_;
                        }
                        else
                        {
                            _RaiseError("||");
                        }
                    }
                    else if (type == Token.TK_AMPERSAND)
                    {
                        tok = scan_.Next();
                        type = (int)tok.GetType();
                        if (type != Token.TK_AMPERSAND)
                        {
                            break;
                        }
                        Result tRes = _ParseSum(scan_.GetCurrentPointer());
                        res.pos_ = tRes.pos_;
                        if (res.type_ == AnonymousEnum6.TYPE_BOOLEAN && tRes.type_ == AnonymousEnum6.TYPE_BOOLEAN)
                        {
                            res.valueBoolean_ = res.valueBoolean_ && tRes.valueBoolean_;
                        }
                        else
                        {
                            _RaiseError("&&");
                        }
                    }
                    else
                    {
                        break;
                    }
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }

            protected TextParser.Result _ParseSum(int pos)
            {
                Result res = _ParseProduct(pos);
                while (scan_.HasNext())
                {
                    scan_.SetCurrentPointer(res.pos_);

                    Token tok = scan_.Next();
                    int type = (int)tok.GetType();
                    if (type != Token.TK_PLUS && type != Token.TK_MINUS)
                    {
                        break;
                    }

                    Result tRes = _ParseProduct(scan_.GetCurrentPointer());
                    if (res.IsString() || tRes.IsString())
                    {
                        res.type_ = AnonymousEnum6.TYPE_STRING;
                        res.valueString_ = res.GetString() + tRes.GetString();
                    }
                    else
                    {
                        if (tRes.type_ == AnonymousEnum6.TYPE_BOOLEAN)
                        {
                            _RaiseError("");
                        }
                        res.pos_ = tRes.pos_;
                        if (type == Token.TK_PLUS)
                        {
                            res.valueReal_ += tRes.valueReal_;
                        }
                        else if (type == Token.TK_MINUS)
                        {
                            res.valueReal_ -= tRes.valueReal_;
                        }
                    }

                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }

            protected TextParser.Result _ParseProduct(int pos)
            {
                Result res = _ParseTerm(pos);
                while (scan_.HasNext())
                {
                    scan_.SetCurrentPointer(res.pos_);
                    Token tok = scan_.Next();
                    int type = (int)tok.GetType();
                    if (type != Token.TK_ASTERISK && type != Token.TK_SLASH)
                    {
                        break;
                    }

                    Result tRes = _ParseTerm(scan_.GetCurrentPointer());
                    if (tRes.type_ == AnonymousEnum6.TYPE_BOOLEAN)
                    {
                        _RaiseError("1241");
                    }

                    res.type_ = tRes.type_;
                    res.pos_ = tRes.pos_;
                    if (type == Token.TK_ASTERISK)
                    {
                        res.valueReal_ *= tRes.valueReal_;
                    }
                    else if (type == Token.TK_SLASH)
                    {
                        res.valueReal_ /= tRes.valueReal_;
                    }
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }

            protected TextParser.Result _ParseTerm(int pos)
            {
                scan_.SetCurrentPointer(pos);
                Result res = new Result();
                Token tok = scan_.Next();

                bool bMinus = false;
                bool bNot = false;
                int type = (int)tok.GetType();
                if (type == Token.TK_PLUS || type == Token.TK_MINUS || type == Token.TK_EXCLAMATION)
                {
                    if (type == Token.TK_MINUS)
                    {
                        bMinus = true;
                    }
                    if (type == Token.TK_EXCLAMATION)
                    {
                        bNot = true;
                    }
                    tok = scan_.Next();
                }

                if (tok.GetType() == Token.TK_OPENP)
                {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = _ParseComparison(scan_->GetCurrentPointer());
                    res.CopyFrom(_ParseComparison(scan_.GetCurrentPointer()));
                    scan_.SetCurrentPointer(res.pos_);
                    tok = scan_.Next();
                    if (tok.GetType() != Token.TK_CLOSEP)
                    {
                        _RaiseError(")?");
                    }
                }
                else
                {
                    int type = (int)tok.GetType();
                    if (type == Token.TK_INT || type == Token.TK_REAL)
                    {
                        res.valueReal_ = tok.GetReal();
                        res.type_ = AnonymousEnum6.TYPE_REAL;
                    }
                    else if (type == Token.TK_ID)
                    {
                        Result tRes = _ParseIdentifer(scan_.GetCurrentPointer());
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = tRes;
                        res.CopyFrom(tRes);
                    }
                    else if (type == Token.TK_STRING)
                    {
                        res.valueString_ = tok.GetString();
                        res.type_ = AnonymousEnum6.TYPE_STRING;
                    }
                    else
                    {
                        _RaiseError(StringUtility.Format("?:%s", tok.GetElement()));
                    }
                }

                if (bMinus)
                {
                    if (res.type_ != AnonymousEnum6.TYPE_REAL)
                    {
                        _RaiseError("???");
                    }
                    res.valueReal_ = -res.valueReal_;
                }
                if (bNot)
                {
                    if (res.type_ != AnonymousEnum6.TYPE_BOOLEAN)
                    {
                        _RaiseError("1311");
                    }
                    res.valueBoolean_ = !res.valueBoolean_;
                }

                res.pos_ = scan_.GetCurrentPointer();

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }

            protected virtual TextParser.Result _ParseIdentifer(int pos)
            {
                Result res = new Result();
                res.pos_ = scan_.GetCurrentPointer();

                Token tok = scan_.GetToken();
                string id = tok.GetElement();
                if (id == "true")
                {
                    res.type_ = AnonymousEnum6.TYPE_BOOLEAN;
                    res.valueBoolean_ = true;
                }
                else if (id == "false")
                {
                    res.type_ = AnonymousEnum6.TYPE_BOOLEAN;
                    res.valueBoolean_ = false;
                }
                else
                {
                    _RaiseError(StringUtility.Format(":%s", id));
                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }


            // ================================================================
            // TextParser
            public TextParser()
            {

            }

            public TextParser(string source)
            {
                SetSource(source);
            }

            public virtual void Dispose()
            {
            }

            public void SetSource(string source)
            {
                List<char> buf = new List<char>();
                buf.Resize(source.Length + 1);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(buf[0], source, source.Length + 1);
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                scan_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new Scanner(buf);
                scan_.SetPermitSignNumber(false);
            }

            public TextParser.Result GetResult()
            {
                if (scan_ == null)
                {
                    _RaiseError("1354");
                }
                scan_.SetPointerBegin();
                Result res = _ParseComparison(scan_.GetCurrentPointer());
                if (scan_.HasNext())
                {
                    _RaiseError(StringUtility.Format("?:%s", scan_.GetToken().GetElement().c_str()));
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }

            public double GetReal()
            {
                if (scan_ == null)
                {
                    _RaiseError("1362");
                }
                scan_.SetPointerBegin();
                Result res = _ParseSum(scan_.GetCurrentPointer());
                if (scan_.HasNext())
                {
                    _RaiseError(StringUtility.Format("?:%s", scan_.GetToken().GetElement().c_str()));
                }
                return res.GetReal();
            }
    }

    // ================================================================
    // Font
    public class Font : System.IDisposable
    {
            public const string GOTHIC = "MS Gothic";
            public const string MINCHOH = "MS Mincho";
            protected IntPtr hFont_;
            protected LOGFONT info_ = new LOGFONT();

            // ================================================================
            // Font
            // const wchar_t* Font::GOTHIC  = L"?";
            // const wchar_t* Font::MINCHOH = L"?";

            public Font()
            {
                hFont_ = null;
            }

            public virtual void Dispose()
            {
                this.Clear();
            }

            public void CreateFont(string type, int size, bool bBold = false, bool bItalic = false, bool bLine = false)
            {
                LOGFONT fontInfo = new LOGFONT();

                lstrcpy(fontInfo.lfFaceName, type);
                fontInfo.lfWeight = (bBold == false) * FW_NORMAL + (bBold == true) * FW_BOLD;
                fontInfo.lfEscapement = 0;
                fontInfo.lfWidth = 0;
                fontInfo.lfHeight = size;
                fontInfo.lfItalic = bItalic;
                fontInfo.lfUnderline = bLine;
                fontInfo.lfCharSet = ANSI_CHARSET;
                for (int i = 0; i < (int)wcslen(type); i++)
                {
                    if (!(IsCharAlphaNumeric(type[i]) || type[i] == ' ' || type[i] == '-'))
                    {
                        fontInfo.lfCharSet = SHIFTJIS_CHARSET;
                        break;
                    }
                }

                this.CreateFontIndirect(fontInfo);
            }

            public void CreateFontIndirect(LOGFONT fontInfo)
            {
                if (hFont_ != null)
                {
                    this.Clear();
                }
                hFont_ = global::CreateFontIndirect(fontInfo);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: info_ = fontInfo;
                info_.CopyFrom(fontInfo);
            }

            public void Clear()
            {
                if (hFont_ != null)
                {
                    global::DeleteObject(hFont_);
                    hFont_ = null;
                    ZeroMemory(info_, sizeof(LOGFONT));
                }
            }

            public IntPtr GetHandle()
            {
                return hFont_;
            }
            public LOGFONT GetInfo()
            {
                return new LOGFONT(info_);
            }
    }

    // ================================================================
    // ObjectPool
// C++ TO C# CONVERTER TODO TASK: C++ template specifiers with non-type parameters cannot be converted to C#:
// ORIGINAL LINE: template <class T, bool SYNC>
    public abstract class ObjectPool <T, bool SYNC> : System.IDisposable
    {
            protected List<LinkedList<gstd.ref_count_ptr<T, SYNC>> > listUsedPool_ = new List<LinkedList<gstd.ref_count_ptr<T, SYNC>> >();
            protected List<List<gstd.ref_count_ptr<T, SYNC>> > listCachePool_ = new List<List<gstd.ref_count_ptr<T, SYNC>> >();

            protected virtual void _CreatePool(int countType)
            {
                listUsedPool_.Resize(countType);
                listCachePool_.Resize(countType);
            }
            protected abstract gstd.ref_count_ptr<T, SYNC> _CreatePoolObject(int type);
            protected virtual void _ResetPoolObject(gstd.ref_count_ptr<T, SYNC> obj)
            {
            }
            protected virtual void _ArrangePool()
            {
                int countType = listUsedPool_.Count;
                for (int iType = 0 ; iType < countType ; iType++)
                {
                    LinkedList<gstd.ref_count_ptr<T, SYNC>> listUsed = listUsedPool_[iType];
                    List<gstd.ref_count_ptr<T, SYNC>> listCache = listCachePool_[iType];

                    LinkedList<gstd.ref_count_ptr<T, SYNC>>.Enumerator itr = listUsed.GetEnumerator();
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    for (; itr != listUsed.end() ;)
                    {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                        gstd.ref_count_ptr<T, SYNC> obj = (itr);
                        if (obj.GetReferenceCount() == 2)
                        {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                            itr = listUsed.erase(itr);
                            _ResetPoolObject(obj);
                            listCache.Add(obj);
                        }
                        else
                        {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                            itr++;
                        }
                    }
                }
            }
            public ObjectPool()
            {
            }
            public virtual void Dispose()
            {
            }
            public virtual gstd.ref_count_ptr<T, SYNC> GetPoolObject(int type)
            {
                gstd.ref_count_ptr<T, SYNC> res = null;
                if (listCachePool_[type].Count > 0)
                {
                    res.CopyFrom(listCachePool_[type][listCachePool_[type].Count - 1]);
                    listCachePool_[type].RemoveAt(listCachePool_[type].Count - 1);
                }
                else
                {
                    res.CopyFrom(_CreatePoolObject(type));
                }
                listUsedPool_[type].AddLast(res);
                return new gstd.ref_count_ptr<T, SYNC>(res);
            }

            public int GetUsedPoolObjectCount()
            {
                int res = 0;
                for (int i = 0 ; i < listUsedPool_.Count ; i++)
                {
                    res += listUsedPool_[i].Count;
                }
                return res;
            }

            public int GetCachePoolObjectCount()
            {
                int res = 0;
                for (int i = 0 ; i < listCachePool_.Count ; i++)
                {
                    res += listCachePool_[i].Count;
                }
                return res;
            }
    }

}

