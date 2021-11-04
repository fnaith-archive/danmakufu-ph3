using gstd;
using directx;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define DWORD_PTR DWORD*
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_malloc malloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_calloc calloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_realloc realloc
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define _ogg_free free
// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace directx
{
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventScriptSource;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventScriptCompiler;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventScriptCode;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventScriptBlock;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventScriptBlock_Main;

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventValueParser;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventEngine;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventImage;

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class DxScriptForEvent;

    /**********************************************************
    //EventScriptSource
    //�R���p�C�����ꂽ�C�x���g�X�N���v�g�R�[�h
    **********************************************************/
    public class EventScriptSource : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend EventScriptCompiler;

            protected List<gstd.ref_count_ptr<EventScriptCode>> code_ = new List<gstd.ref_count_ptr<EventScriptCode>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<EventScriptBlock_Main>> event_ = new SortedDictionary<string, gstd.ref_count_ptr<EventScriptBlock_Main>>();

            /**********************************************************
            //EventScriptSource
            //�R���p�C�����ꂽ�C�x���g�X�N���v�g�R�[�h
            **********************************************************/
            public EventScriptSource()
            {
            }

            public virtual void Dispose()
            {
                code_.Clear();
                event_.Clear();
            }

            public int GetCodeCount()
            {
                return code_.Count;
            }
            public void AddCode(gstd.ref_count_ptr<EventScriptCode> code)
            {
                code_.Add(code);
            }

            public gstd.ref_count_ptr<EventScriptCode> GetCode(int index)
            {
                return new gstd.ref_count_ptr<EventScriptCode>(code_[index]);
            }
            public gstd.ref_count_ptr<EventScriptBlock_Main> GetEventBlock(string name)
            {
                if (!event_.ContainsKey(name))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<EventScriptBlock_Main>(event_[name]);
            }
    }

    /**********************************************************
    //EventScriptScanner
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventScriptScanner;
    public class EventScriptToken : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend EventScriptScanner;
            public enum Type
            {
                TK_UNKNOWN,
                TK_EOF,
                TK_NEWLINE,
                TK_ID,
                TK_INT,
                TK_REAL,
                TK_STRING,

                TK_OPENP,
                TK_CLOSEP,
                TK_OPENB,
                TK_CLOSEB,
                TK_OPENC,
                TK_CLOSEC,
                TK_SHARP,

                TK_COMMA,
                TK_EQUAL,
                TK_ASTERISK,
                TK_SLASH,
                TK_COLON,
                TK_SEMICOLON,
                TK_TILDE,
                TK_EXCLAMATION,
                TK_PLUS,
                TK_MINUS,
                TK_LESS,
                TK_GREATER,

                TK_TEXT
            }
            protected Type type_;
            protected string element_ = "";
            public EventScriptToken()
            {
                type_ = Type.TK_UNKNOWN;
            }
            public EventScriptToken(Type type, string element)
            {
                type_ = type;
                element_ = element;
            }

            public virtual void Dispose()
            {
            }
            public Type GetType()
            {
                return type_;
            }
            public string GetElement()
            {
                return element_;
            }

            public int GetInteger()
            {
                if (type_ != Type.TK_INT)
                {
                    throw new gstd.wexception("EventScriptToken::GetInterger:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                return atoi(element_);
            }

            public double GetReal()
            {
                if (type_ != Type.TK_REAL && type_ != Type.TK_INT)
                {
                    throw new gstd.wexception("EventScriptToken::GetReal:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                return atof(element_);
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

            public string GetString()
            {
                if (type_ != Type.TK_STRING)
                {
                    throw new gstd.wexception("EventScriptToken::GetString:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                return element_.Substring(1,element_.Length - 2);
            }


            // EventScriptToken
            public string GetIdentifier()
            {
                if (type_ != Type.TK_ID)
                {
                    throw new gstd.wexception("EventScriptToken::GetIdentifier:�f�[�^�̃^�C�v���Ⴂ�܂�");
                }
                return element_;
            }
    }

    public class EventScriptScanner : System.IDisposable
    {
            public const int TOKEN_TAG_START = EventScriptToken.TK_OPENB;
            public const int TOKEN_TAG_END = EventScriptToken.TK_CLOSEB;
            public const string TAG_START = "[";
            public const string TAG_END = "]";
            public const string TAG_NEW_LINE = "r";
            public const string TAG_RUBY = "ruby";
            public const string TAG_FONT = "font";
            protected int line_;
            protected List<char> buffer_ = new List<char>();
            protected List<char>.Enumerator pointer_; // ���̈ʒu
            protected EventScriptToken token_ = new EventScriptToken(); // ���݂̃g�[�N��
            protected boolean bTagScan_ = new boolean();

            protected char _NextChar()
            {
                if (HasNext() == false)
                {
                    _RaiseError("_NextChar:���łɕ�����I�[�ł�");
                }

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                if (IsDBCSLeadByte(pointer_))
                {
                    pointer_ += 2;
                }
                else
                {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    pointer_++;
                }

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                if (IsDBCSLeadByte(pointer_) == 0 && pointer_ == '\n')
                {
                    line_++;
                }
                return new List<char>.Enumerator(pointer_);
            }

            protected virtual void _SkipComment()
            {
                while (true)
                {
                    List<char>.Enumerator posStart = pointer_;
                    _SkipSpace();

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    char ch = pointer_;

                    if (ch == '/')
                    { // �R�����g�A�E�g����
                        List<char>.Enumerator tPos = pointer_;
                        ch = _NextChar();
                        if (ch == '/')
                        { // "//"
                            while (true)
                            {
                                ch = _NextChar();
                                if (IsDBCSLeadByte(ch))
                                {
                                    continue;
                                }
                                if (ch == '\r' || ch == '\n')
                                {
                                    break;
                                }
                            }
                        }
                        else if (ch == '*')
                        { // "/*"-"*/"
                            while (true)
                            {
                                ch = _NextChar();
                                if (ch == '*')
                                {
                                    ch = _NextChar();
                                    if (ch == '/')
                                    {
                                        break;
                                    }
                                }
                            }
                            ch = _NextChar();
                        }
                        else
                        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pointer_ = tPos;
                            pointer_.CopyFrom(tPos);
                            ch = '/';
                        }
                    }

                    // �X�L�b�v��󔒔�΂�������ꍇ�A�I��
                    if (posStart == pointer_)
                    {
                        break;
                    }
                }
            }

            protected virtual void _SkipSpace()
            {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ch = pointer_;
                while (true)
                {
                    if (ch != ' ' && ch != '\t')
                    {
                        break;
                    }
                    ch = _NextChar();
                }
            }

            protected virtual void _RaiseError(string str)
            {
                throw new gstd.wexception(str);
            }

            protected bool _IsTextStartSign()
            {
                if (bTagScan_ != null)
                {
                    return false;
                }

                bool res = false;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ch = pointer_;

                if (false && ch == '\\')
                {
                    List<char>.Enumerator pos = pointer_;
                    ch = _NextChar(); // ���̃^�O�܂Ői�߂�
                    bool bDBSSLeadByte = IsDBCSLeadByte(ch) != 0;
                    bool bLess = (!bDBSSLeadByte && ch == GlobalMembers.CHAR_TAG_START);
                    if (!bLess)
                    {
                        res = false;
                        SetCurrentPointer(new List<char>.Enumerator(pos));
                    }
                    else
                    {
                        res = bDBSSLeadByte || !bLess;
                    }
                }
                else
                {
                    bool bDBSSLeadByte = IsDBCSLeadByte(ch) != 0;
                    bool bLess = (!bDBSSLeadByte && ch == GlobalMembers.CHAR_TAG_START);
                    res = bDBSSLeadByte || !bLess;
                }

                return res;
            }

            protected bool _IsTextScan()
            {
                bool res = false;
                char ch = _NextChar();
                if (!HasNext())
                {
                    return false;
                }
                else if (ch == '/')
                {
                    ch = *(pointer_ + 1);
                    if (ch == '/' || ch == '*')
                    {
                        res = false;
                    }
                }
                else if (false && ch == '\\')
                {
                    ch = _NextChar(); // ���̃^�O�܂Ői�߂�
                    res = true;
                }
                else
                {
                    bool bGreater = (IsDBCSLeadByte(ch) == 0 && ch == GlobalMembers.CHAR_TAG_END);
                    if (bGreater)
                    {
                        _RaiseError("�e�L�X�g���Ƀ^�O�I�����������݂��܂���");
                    }
                    bool bNotLess = !(IsDBCSLeadByte(ch) == 0 && ch == GlobalMembers.CHAR_TAG_START);
                    res = bNotLess;
                }
                return res;
            }

            public EventScriptScanner(ref string str, int size)
            {
                List<char> buf = new List<char>();
                buf.Resize(size);
                if (buf.Count != 0)
                {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(buf[0], str, size);
                }

                buf.Add('\0');
                this.EventScriptScanner(buf);
            }

            public EventScriptScanner(string str)
            {
                List<char> buf = new List<char>();
                buf.Resize(str.Length + 1);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(buf[0], str, str.Length + 1);
                this.EventScriptScanner(buf);
            }

            public EventScriptScanner(List<char> buf)
            {
                buffer_ = new List<char>(buf);
                pointer_ = buffer_.GetEnumerator();

                line_ = 1;
                bTagScan_ = false;
            }

            public virtual void Dispose()
            {

            }

            public EventScriptToken GetToken()
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return token_;
                return new directx.EventScriptToken(token_);
            }

            public EventScriptToken Next()
            {
                if (!HasNext())
                {
                    _RaiseError("Next:���łɏI�[�ł�");
                }

                _SkipComment(); // �R�����g��Ƃ΂��܂�

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ch = pointer_;
                if (ch == '\0')
                {
                    token_ = new EventScriptToken(EventScriptToken.TK_EOF, "\0");
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return token_;
                    return new directx.EventScriptToken(token_);
                }

                EventScriptToken.Type type = EventScriptToken.TK_UNKNOWN;
                List<char>.Enumerator posStart = pointer_; // �擪��ۑ�

                if (_IsTextStartSign())
                {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    ch = pointer_;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: posStart = pointer_;
                    posStart.CopyFrom(pointer_);
                    while (_IsTextScan())
                    {

                    }

// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    ch = pointer_;
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    if (IsDBCSLeadByte(pointer_) == 0 && ch == GlobalMembers.CHAR_TAG_START)
                    {
                    }
                    else if (!HasNext())
                    {
                    }
            // 		else _RaiseError("Next:���łɕ�����I�[�ł�");

                    type = EventScriptToken.TK_TEXT;
                    string text = new string(posStart, pointer_);
                    text = StringUtility.ReplaceAll(text, "\\", "");
                    token_ = new EventScriptToken(type, text);
                }
                else
                {
                    switch (ch)
                    {
                        case '\0':
                            type = EventScriptToken.TK_EOF;
                            break; // �I�[
                        case ',':
                            _NextChar();
                            type = EventScriptToken.TK_COMMA;
                            break;
                        case '=':
                            _NextChar();
                            type = EventScriptToken.TK_EQUAL;
                            break;
                        case '(':
                            _NextChar();
                            type = EventScriptToken.TK_OPENP;
                            break;
                        case ')':
                            _NextChar();
                            type = EventScriptToken.TK_CLOSEP;
                            break;
                        case '[':
                            _NextChar();
                            type = EventScriptToken.TK_OPENB;
                            break;
                        case ']':
                            _NextChar();
                            type = EventScriptToken.TK_CLOSEB;
                            break;
                        case '{':
                            _NextChar();
                            type = EventScriptToken.TK_OPENC;
                            break;
                        case '}':
                            _NextChar();
                            type = EventScriptToken.TK_CLOSEC;
                            break;
                        case '*':
                            _NextChar();
                            type = EventScriptToken.TK_ASTERISK;
                            break;
                        case '/':
                            _NextChar();
                            type = EventScriptToken.TK_SLASH;
                            break;
                        case ':':
                            _NextChar();
                            type = EventScriptToken.TK_COLON;
                            break;
                        case ';':
                            _NextChar();
                            type = EventScriptToken.TK_SEMICOLON;
                            break;
                        case '~':
                            _NextChar();
                            type = EventScriptToken.TK_TILDE;
                            break;
                        case '!':
                            _NextChar();
                            type = EventScriptToken.TK_EXCLAMATION;
                            break;
                        case '#':
                            _NextChar();
                            type = EventScriptToken.TK_SHARP;
                            break;
                        case '<':
                            _NextChar();
                            type = EventScriptToken.TK_LESS;
                            break;
                        case '>':
                            _NextChar();
                            type = EventScriptToken.TK_GREATER;
                            break;

                        case '"':
                        {
                            ch = _NextChar(); // 1�i�߂�
                            char pre = ch;
                            while (true)
                            {
                                if (ch == '"' && pre != '\\')
                                {
                                    break;
                                }
                                pre = ch;
                                ch = _NextChar(); // ���̃_�u���N�I�[�e�[�V�����܂Ői�߂�
                            }

                            if (ch == '"')
                            {
                                _NextChar(); // �_�u���N�I�[�e�[�V������������1�i�߂�
                            }
                            else
                            {
                                _RaiseError("Next:���łɕ�����I�[�ł�");
                            }
                            type = EventScriptToken.TK_STRING;
                            break;
                        }

                        case '\r':
                    case '\n': // ���s
                            // ���s�����܂ł�����悤�Ȃ̂�1�̉��s�Ƃ��Ĉ���
                            while (ch == '\r' || ch == '\n')
                            {
                                ch = _NextChar();
                            }
                            type = EventScriptToken.TK_NEWLINE;
                            break;

                        case '+':
                    case '-':
                    {
                            if (ch == '+')
                            {
                                ch = _NextChar();
                                type = EventScriptToken.TK_PLUS;

                            }
                            else if (ch == '-')
                            {
                                ch = _NextChar();
                                type = EventScriptToken.TK_MINUS;
                            }

                            if (!isdigit(ch))
                            {
                                break; // ���������łȂ��Ȃ甲����
                            }
                    }


// C++ TO C# CONVERTER TODO TASK: C# does not allow fall-through from a non-empty 'case':
                        default:
                        {
                            if (isdigit(ch))
                            {
                                // ����������
                                while (isdigit(ch))
                                {
                                    ch = _NextChar(); // ���������̊ԃ|�C���^��i�߂�
                                }
                                type = EventScriptToken.TK_INT;
                                if (ch == '.')
                                {
                                    // �������������𒲂ׂ�B�����_�������������
                                    ch = _NextChar();
                                    while (isdigit(ch))
                                    {
                                        ch = _NextChar(); // ���������̊ԃ|�C���^��i�߂�
                                    }
                                    type = EventScriptToken.TK_REAL;
                                }

                                if (ch == 'E' || ch == 'e')
                                {
                                    // 1E-5�݂����ȃP�[�X
                                    List<char>.Enumerator pos = pointer_;
                                    ch = _NextChar();
                                    while (isdigit(ch) || ch == '-')
                                    {
                                        ch = _NextChar(); // ���������̊ԃ|�C���^��i�߂�
                                    }
                                    type = EventScriptToken.TK_REAL;
                                }

                            }
                            else if (isalpha(ch) || ch == '_')
                            {
                                // ���Ԃ񎯕ʎq
                                while (isalpha(ch) || isdigit(ch) || ch == '_')
                                {
                                    ch = _NextChar(); // ���Ԃ񎯕ʎq�Ȋԃ|�C���^��i�߂�
                                }
                                type = EventScriptToken.TK_ID;
                            }
                            else
                            {
                                _NextChar();
                                type = EventScriptToken.TK_UNKNOWN;
                            }
                            break;
                        }
                    }
                    if (type == EventScriptScanner.TOKEN_TAG_START)
                    {
                        bTagScan_ = true;
                    }
                    else if (type == EventScriptScanner.TOKEN_TAG_END)
                    {
                        bTagScan_ = false;
                    }

                    if (type == EventScriptToken.TK_STRING)
                    {
                        // \�����
                        string str = StringUtility.ReplaceAll(new string(posStart, pointer_), "\\\"", "\"");
                        token_ = new EventScriptToken(type, str);
                    }
                    else
                    {
                        token_ = new EventScriptToken(type, new string(posStart, pointer_));
                    }

                }

// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return token_;
                return new directx.EventScriptToken(token_);
            }

            public bool HasNext()
            {
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                return pointer_ != buffer_.end() && pointer_ != '\0' && token_.GetType() != EventScriptToken.TK_EOF;
            }

            public void CheckType(EventScriptToken tok, int type)
            {
                if ((int)tok.type_ != type)
                {
                    string str = StringUtility.Format("CheckType error[%s]:",tok.element_.c_str());
                    _RaiseError(str);
                }
            }

            public void CheckIdentifer(EventScriptToken tok, string id)
            {
                if (tok.type_ != EventScriptToken.TK_ID || tok.GetIdentifier() != id)
                {
                    string str = StringUtility.Format("CheckID error[%s]:",tok.element_.c_str());
                    _RaiseError(str);
                }
            }

            public int GetCurrentLine()
            {
                return line_;
            }

            public int SearchCurrentLine()
            {
                int line = 1;
// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on this variable, so pointers on this variable are left unchanged:
                char * pbuf = &(*buffer_.GetEnumerator());
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* ebuf=&(*pointer_);
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                char ebuf = &(pointer_);
                while (true)
                {
                    if (pbuf >= ebuf)
                    {
                        break;
                    }
                    else if (*pbuf == '\n')
                    {
                        line++;
                    }
                    if (IsDBCSLeadByte(*pbuf))
                    {
                        pbuf += 2;
                    }
                    else
                    {
                        pbuf++;
                    }
                }
                return line;
            }

            public List<char>.Enumerator GetCurrentPointer()
            {
                return new List<char>.Enumerator(pointer_);
            }

            public void SetCurrentPointer(List<char>.Enumerator pos)
            {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: pointer_ = pos;
                pointer_.CopyFrom(pos);
            }

            public void SetPointerBegin()
            {
                pointer_ = buffer_.GetEnumerator();
            }
            public int GetCurrentPosition()
            {
                if (buffer_.Count == 0)
                {
                    return 0;
                }
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                string pos = (string)pointer_;
                return pos - buffer_[0];
            }

            public void SetTagScanEnable(bool bEnable)
            {
                bTagScan_ = bEnable;
            }
    }

    /**********************************************************
    //EventScriptCompiler
    **********************************************************/
    public class EventScriptCompiler : System.IDisposable
    {
            private string path_ = "";
            private gstd.ref_count_ptr<EventScriptScanner> scan_ = new gstd.ref_count_ptr<EventScriptScanner>();
            private gstd.ref_count_ptr<EventScriptSource> source_ = new gstd.ref_count_ptr<EventScriptSource>();
            private LinkedList<List<gstd.ref_count_ptr<EventScriptBlock>> > block_ = new LinkedList<List<gstd.ref_count_ptr<EventScriptBlock>> >();

            private void _ParseBlock(ref_count_ptr<EventScriptCode> blockStartCode)
            {
                while (scan_.HasNext())
                {
                    EventScriptToken tok = scan_.Next();
                    int typeToken = (int)tok.GetType();
                    if (typeToken == EventScriptToken.TK_TEXT)
                    {
                        string element = tok.GetElement();
                        element = StringUtility.ReplaceAll(element, "\r", "");
                        element = StringUtility.ReplaceAll(element, "\n", "");
                        element = StringUtility.ReplaceAll(element, "\t", "");
                        if (element.Length == 0 || element == "")
                        {
                            continue;
                        }
                        ref_count_ptr<EventScriptCode_Text> code = new EventScriptCode_Text();
                        code.SetLine(scan_.GetCurrentLine());
                        code.SetText(element);
                        source_.AddCode(code);
                    }
                    else if (typeToken == EventScriptScanner.TOKEN_TAG_START)
                    {
                        scan_.Next();
                        ref_count_ptr<EventScriptCode> res = _ParseTag(new ref_count_ptr<EventScriptCode>(blockStartCode));
                        if (res != null)
                        {
                            source_.AddCode(res);
                        }
                    }

            /*
            		for(int iCode = 0 ; iCode < source_->code_.size() ; iCode++)
            		{
            			gstd::ref_count_ptr<EventScriptCode> code = source_->code_[iCode];
            			std::string log = StringUtility::Format("code:type[%d] line[%d]", code->GetType(), code->GetLine());
            			Logger::WriteTop(log);
            		}
            		Logger::WriteTop("");
            */
                }


            }

            private ref_count_ptr<EventScriptCode> _ParseTag(ref_count_ptr<EventScriptCode> blockStartCode)
            {
                ref_count_ptr<EventScriptCode> res = null;
                EventScriptToken tok = scan_.GetToken();
                string element = tok.GetElement();
                if (element == "event_block_start")
                {
                    int pos = source_.GetCodeCount();
                    ref_count_ptr<EventScriptBlock_Main> block = new EventScriptBlock_Main();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "name")
                        {
                            string name = value.GetString();
                            block.SetName(name);
                        }
                    }
                    block.SetStartPosition(pos);
                    List<ref_count_ptr<EventScriptBlock>> blocks = new List<new ref_count_ptr<EventScriptBlock>>();
                    blocks.Add(block);
                    block_.AddLast(blocks);
                }
                else if (element == "event_block_end")
                {
                    int pos = source_.GetCodeCount();
                    List<ref_count_ptr<EventScriptBlock>> blocks = *block_.rbegin();
                    block_.RemoveLast();
                    ref_count_ptr<EventScriptBlock_Main> block = new ref_count_ptr<EventScriptBlock_Main>(blocks[0]);

                    block.SetEndPosition(pos - 1);
                    block.SetReturnPosition(EventScriptBlock.POS_NULL);

                    string name = block.GetName();
                    source_.event_[name] = block;
                }
                else if (element == EventScriptScanner.TAG_NEW_LINE)
                {
                    res = new EventScriptCode_NextLine();
                }
                else if (element == EventScriptCode.TAG_WAIT_CLICK)
                {
                    res = new EventScriptCode_WaitClick();
                }
                else if (element == EventScriptCode.TAG_WAIT_NEXT_PAGE)
                {
                    res = new EventScriptCode_WaitNextPage();
                }
                else if (element == EventScriptCode.TAG_WAIT_TIME)
                {
                    EventScriptCode_WaitTime code = new EventScriptCode_WaitTime();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "frame")
                        {
                            code.SetTime(value.GetElement());
                        }
                        else if (key == "skip")
                        {
                            code.SetSkipEnable(value.GetBoolean());
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_CLEAR_MESSAGE)
                {
                    res = new EventScriptCode_ClearMessage();
                }
                else if (element == EventScriptCode.TAG_NAME)
                {
                    EventScriptCode_Name code = new EventScriptCode_Name();
                    List<char>.Enumerator pos = scan_.GetCurrentPointer();
                    EventScriptToken tok = scan_.Next();
                    int type = (int)tok.GetType();
                    if (type == EventScriptScanner.TOKEN_TAG_END)
                    {
                        // scan_->SetCurrentPointer(pos);
                    }
                    else if (type == EventScriptToken.TK_STRING || type == EventScriptToken.TK_ID)
                    {
                        string name = tok.GetElement();
                        code.SetName(name);
                    }
                    else
                    {
                        SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                        SortedDictionary<string, EventScriptToken>.Enumerator itr;
                        for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                        {
                            string key = itr.Current.Key;
                            EventScriptToken value = itr.Current.Value;
                            if (key == "name")
                            {
                                code.SetName(value.GetElement());
                            }
                        }
                    }

                    res = code;
                }
                else if (element == EventScriptCode.TAG_TRANSITION)
                {
                    EventScriptCode_Transition code = new EventScriptCode_Transition();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "type")
                        {
                            int type = EventScriptCode_Transition.TRANS_NONE;
                            string strTrans = value.GetElement();
                            if (strTrans == "fade")
                            {
                                type = EventScriptCode_Transition.TRANS_FADE;
                            }
                            code.SetTransType(type);
                        }
                        else if (key == "frame")
                        {
                            code.SetFrame(value.GetElement());
                        }
                        else if (key == "path")
                        {
                            code.SetPath(value.GetElement());
                            code.SetTransType(EventScriptCode_Transition.TRANS_SCRIPT);
                        }
                        else if (key == "method")
                        {
                            code.SetMethod(value.GetElement());
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_VISIBLE_TEXT)
                {
                    EventScriptCode_VisibleText code = new EventScriptCode_VisibleText();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "visible")
                        {
                            code.SetVisible(value.GetBoolean());
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_VAR)
                {
                    EventScriptCode_Var code = new EventScriptCode_Var();
                    string name = scan_.Next().GetElement();
                    scan_.CheckType(scan_.Next(), EventScriptToken.TK_EQUAL);
                    string value = _GetNextTagElement();

                    if (value[0] == '"' && value[value.Length - 1] == '"')
                    {
                        value = StringUtility.ReplaceAll(value, "\"", "\\\"", 1, value.Length - 1);
                    }
                    scan_.CheckType(scan_.Next(), EventScriptScanner.TOKEN_TAG_END);
                    code.SetName(name);
                    code.SetValue(value);
                    res = code;
                }
                else if (element == EventScriptCode.TAG_EVAL)
                {
                    EventScriptCode_Eval code = new EventScriptCode_Eval();
                    string name = scan_.Next().GetElement();
                    scan_.CheckType(scan_.Next(), EventScriptToken.TK_EQUAL);
                    string value = _GetNextTagElement();
                    scan_.CheckType(scan_.Next(), EventScriptScanner.TOKEN_TAG_END);
                    code.SetName(name);
                    code.SetValue(value);
                    res = code;
                }
                else if (element == EventScriptCode.TAG_SYSVAL)
                {
                    EventScriptCode_SysVal code = new EventScriptCode_SysVal();
                    string name = scan_.Next().GetElement();
                    scan_.CheckType(scan_.Next(), EventScriptToken.TK_EQUAL);
                    string value = _GetNextTagElement();
                    scan_.CheckType(scan_.Next(), EventScriptScanner.TOKEN_TAG_END);
                    code.SetName(name);
                    code.SetValue(value);
                    res = code;
                }
                else if (element == EventScriptCode.TAG_OUTPUT)
                {
                    EventScriptCode_Output code = new EventScriptCode_Output();
                    scan_.CheckIdentifer(scan_.Next(), "msg");
                    scan_.CheckType(scan_.Next(), EventScriptToken.TK_EQUAL);
                    string value = _GetNextTagElement();
                    scan_.CheckType(scan_.Next(), EventScriptScanner.TOKEN_TAG_END);
                    code.SetValue(value);
                    res = code;
                }
                else if (element == EventScriptCode.TAG_IMAGE)
                {
                    EventScriptCode_Image code = new EventScriptCode_Image();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "id")
                        {
                            code.SetObjectIdentifier(value.GetElement());
                        }
                        else if (key == "path")
                        {
                            if (value.GetType() == EventScriptToken.TK_STRING)
                            {
                                code.SetPath(value.GetString());
                            }
                            else
                            {
                                code.SetPath(value.GetElement());
                            }
                        }
                        else if (key == "layer")
                        {
                            int layer = 0;
                            string strLayer = value.GetElement();
                            if (strLayer == "fore")
                            {
                                layer = EventImage.LAYER_FOREGROUND;
                            }
                            else if (strLayer == "back")
                            {
                                layer = EventImage.LAYER_BACKGROUND;
                            }
                            else
                            {
                                layer = value.GetInteger();
                            }
                            code.SetLayer(layer);
                        }
                        else if (key == "pri")
                        {
                            code.SetPriority(value.GetElement());
                        }
                        else if (key == "visible")
                        {
                            code.SetVisible(value.GetElement());
                        }
                        else if (key == "trans")
                        {
                            code.SetTransition(value.GetElement());
                        }
                        else if (key == "left_dest")
                        {
                            code.SetLeftDestPoint(value.GetElement());
                        }
                        else if (key == "top_dest")
                        {
                            code.SetTopDestPoint(value.GetElement());
                        }
                        else if (key == "wait")
                        {
                            code.SetWaitEnd(value.GetElement());
                        }
                        else if (key == "delete")
                        {

                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_BGM || element == EventScriptCode.TAG_SE)
                {
                    EventScriptCode_Sound code = new EventScriptCode_Sound();
                    if (element == EventScriptCode.TAG_BGM)
                    {
                        code.SetSoundType(EventSound.TYPE_BGM);
                    }
                    else
                    {
                        code.SetSoundType(EventSound.TYPE_SE);
                    }

                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "path")
                        {
                            if (value.GetType() == EventScriptToken.TK_STRING)
                            {
                                code.SetPath(value.GetString());
                            }
                            else
                            {
                                code.SetPath(value.GetElement());
                            }
                        }
                        else if (key == "delete")
                        {

                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_IF || element == EventScriptCode.TAG_ELSEIF)
                {
                    ref_count_ptr<EventScriptCode_If> code = new EventScriptCode_If();
                    int pos = source_.GetCodeCount();
                    code.SetStartPosition(pos + 1);
                    string param = _GetNextTagElement();
                    if (param.Length != 0)
                    {
                        code.SetParameter(param);
                    }

                    if (element == EventScriptCode.TAG_IF)
                    {
                        List<ref_count_ptr<EventScriptBlock>> blocks = new List<new ref_count_ptr<EventScriptBlock>>();
                        blocks.Add(code);
                        block_.AddLast(blocks);
                    }
                    else if (element == EventScriptCode.TAG_ELSEIF)
                    {
                        List<ref_count_ptr<EventScriptBlock>> blocks = *block_.rbegin();
                        ref_count_ptr<EventScriptCode_If> preIf = new ref_count_ptr<EventScriptCode_If>(*blocks.rbegin());
                        preIf.SetNextElsePosition(pos);

                        blocks.Add(code);
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = code;
                    res.CopyFrom(code);
                }
                else if (element == EventScriptCode.TAG_ENDIF)
                {
                    int pos = source_.GetCodeCount();
                    List<ref_count_ptr<EventScriptBlock>> blocks = *block_.rbegin();
                    for (int iIf = 0 ; iIf < blocks.Count ; iIf++)
                    {
                        ref_count_ptr<EventScriptCode_If> block = new ref_count_ptr<EventScriptCode_If>(blocks[iIf]);
                        int posEnd = pos;
                        if (iIf < blocks.Count - 1)
                        {
                            ref_count_ptr<EventScriptCode_If> next = new ref_count_ptr<EventScriptCode_If>(blocks[iIf + 1]);
                            posEnd = next.GetStartPosition() - 2;
                        }
                        else
                        {
                            posEnd = pos - 1;
                        }
                        block.SetEndPosition(posEnd);
                        block.SetReturnPosition(pos);
                    }
                    block_.RemoveLast();
                }
                else if (element == EventScriptCode.TAG_GOSUB || element == EventScriptCode.TAG_GOTO)
                {
                    EventScriptCode_Jump code = new EventScriptCode_Jump();
                    code.SetGosub(element == EventScriptCode.TAG_GOSUB);

                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "path")
                        {
                            code.SetPath(value.GetElement());
                        }
                        else if (key == "name")
                        {
                            code.SetName(value.GetElement());
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_SCRIPT)
                {
                    EventScriptCode_Script code = new EventScriptCode_Script();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "path")
                        {
                            code.SetPath(value.GetElement());
                        }
                        else if (key == "method")
                        {
                            code.SetMethod(value.GetElement());
                        }
                        else if (key == "wait")
                        {
                            if (value.GetType() == EventScriptToken.TK_STRING)
                            {
                                code.SetWaitEnd(value.GetString());
                            }
                            else
                            {
                                code.SetWaitEnd(value.GetElement());
                            }
                        }
                        else if (key == "target")
                        {
                            if (value.GetType() == EventScriptToken.TK_STRING)
                            {
                                code.SetTargetId(value.GetString());
                            }
                            else
                            {
                                code.SetTargetId(value.GetElement());
                            }
                        }
                        else if (key == "code")
                        {
                            code.SetCode(value.GetElement());
                        }
                        else if (key == "id")
                        {
                            code.SetId(value.GetString());
                        }
                        else if (key == "delete")
                        {
                            code.SetEndScript(true);
                        }
                        else if (key.IndexOf("arg") != -1)
                        {
                            if (key == "arg")
                            {
                                code.SetArgument(0, value.GetElement());
                            }
                            else
                            {
                                string str = StringUtility.ReplaceAll(key, "arg", "");
                                int index = StringUtility.ToInteger(str);
                                code.SetArgument(index, value.GetElement());
                            }
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_SCRIPT_END)
                {
                    EventScriptCode_Script code = new EventScriptCode_Script();
                    code.SetEndScript(true);
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "path")
                        {
                            code.SetPath(value.GetElement());
                        }
                        else if (key == "method")
                        {
                            code.SetMethod(value.GetElement());
                        }
                        else if (key == "id")
                        {
                            code.SetId(value.GetString());
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_END)
                {
                    EventScriptCode_End code = new EventScriptCode_End();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "arg")
                        {
                            code.SetArgument(value.GetString());
                        }
                    }
                    res = code;
                }
                else if (element == EventScriptCode.TAG_BATTLE)
                {
                    EventScriptCode_Battle code = new EventScriptCode_Battle();
                    SortedDictionary<string, EventScriptToken> mapElement = _GetAllTagElement();
                    SortedDictionary<string, EventScriptToken>.Enumerator itr;
                    for (itr = mapElement.GetEnumerator(); itr.MoveNext();)
                    {
                        string key = itr.Current.Key;
                        EventScriptToken value = itr.Current.Value;
                        if (key == "path")
                        {
                            if (value.GetType() == EventScriptToken.TK_STRING)
                            {
                                code.SetPath(value.GetString());
                            }
                            else
                            {
                                code.SetPath(value.GetElement());
                            }
                        }
                    }
                    res = code;
                }
                else
                {
                    string text = EventScriptScanner.TAG_START + element + " ";
                    ref_count_ptr<EventScriptCode_Text> code = new EventScriptCode_Text();
                    text += _GetNextTagElement();
                    scan_.CheckType(scan_.Next(), EventScriptScanner.TOKEN_TAG_END);
                    text += EventScriptScanner.TAG_END;
                    code.SetText(text);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res = code;
                    res.CopyFrom(code);
                }

                if (res != null)
                {
                    int line = scan_.GetCurrentLine();
                    res.SetLine(line);
                }

                return new ref_count_ptr<EventScriptCode>(res);
            }

            private SortedDictionary<string, EventScriptToken> _GetAllTagElement()
            {
                SortedDictionary<string, EventScriptToken> res = new SortedDictionary<string, EventScriptToken>();
                List<char>.Enumerator pos = scan_.GetCurrentPointer();
                while (true)
                {
                    pos = scan_.GetCurrentPointer();
                    EventScriptToken tok = scan_.Next();
                    if (tok.GetType() == EventScriptScanner.TOKEN_TAG_END)
                    {
                        break;
                    }
                    string key = tok.GetElement();
                    tok = scan_.Next();
                    if (tok.GetType() != EventScriptToken.TK_EQUAL)
                    {
                        res[key] = new EventScriptToken();
                        if (tok.GetType() == EventScriptScanner.TOKEN_TAG_END)
                        {
                            break;
                        }
                        continue;
                    }

                    tok = scan_.Next();
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: res[key] = tok;
                    res[key].CopyFrom(tok);
                }
                scan_.SetCurrentPointer(pos);
                scan_.SetTagScanEnable(true);
                return new SortedDictionary<string, EventScriptToken>(res);
            }

            private string _GetNextTagElement()
            {
                return _GetNextTagElement(EventScriptScanner.TOKEN_TAG_END);
            }

            private string _GetNextTagElement(int type)
            {
                string res = "";
                List<char>.Enumerator pos = scan_.GetCurrentPointer();
                while (true)
                {
                    pos = scan_.GetCurrentPointer();
                    EventScriptToken tok = scan_.Next();
                    if ((int)tok.GetType() == type)
                    {
                        break;
                    }
                    if (tok.GetType() == EventScriptToken.TK_NEWLINE)
                    {
                        continue;
                    }
                    if (tok.GetType() == EventScriptScanner.TOKEN_TAG_END)
                    {
                        break;
                    }
                    res += tok.GetElement();
                }
                scan_.SetCurrentPointer(pos);
                scan_.SetTagScanEnable(true);
                return res;
            }


            /**********************************************************
            //EventScriptCompiler
            **********************************************************/
            public EventScriptCompiler()
            {

            }

            public virtual void Dispose()
            {
            }

            public void SetPath(string path)
            {
                path_ = path;
            }
            public gstd.ref_count_ptr<EventScriptSource> Compile()
            {
                FileManager fileManager = FileManager.GetBase();
                ref_count_ptr<FileReader> reader = fileManager.GetFileReader(path_);
                if (reader == null || !reader.Open())
                {
                    Logger.WriteTop(ErrorUtility.GetFileNotFoundErrorMessage(path_));
                    return false;
                }

                int size = reader.GetFileSize();
                List<char> text = new List<char>();
                text.Resize(size+1);
                reader.Read(text[0], size);
                text[size] = '\0';

                scan_ = new EventScriptScanner(text);
                source_ = new EventScriptSource();

                try
                {
                    _ParseBlock(null);
                }
                catch (gstd.wexception e)
                {
                    int line = scan_.GetCurrentLine();
                    throw new gstd.wexception(StringUtility.Format("%s line[%d]", e.what(), line).c_str());
                }

                return new gstd.ref_count_ptr<EventScriptSource>(source_);
            }
    }


    /**********************************************************
    //EventScriptBlock
    **********************************************************/
    public class EventScriptBlock : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend EventScriptSource;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                POS_NULL = -1
            }
            public const string BLOCK_GLOBAL = "global";
            protected bool bInner_;
            protected int posStart_;
            protected int posEnd_;
            protected int posReturn_;
            public EventScriptBlock()
            {
                bInner_ = false;
                posStart_ = (int)AnonymousEnum.POS_NULL;
                posEnd_ = (int)AnonymousEnum.POS_NULL;
                posReturn_ = (int)AnonymousEnum.POS_NULL;
            }
            public virtual void Dispose()
            {
            }
            public int GetStartPosition()
            {
                return posStart_;
            }
            public void SetStartPosition(int pos)
            {
                posStart_ = pos;
            }
            public int GetEndPosition()
            {
                return posEnd_;
            }
            public void SetEndPosition(int pos)
            {
                posEnd_ = pos;
            }
            public int GetReturnPosition()
            {
                return posReturn_;
            }
            public void SetReturnPosition(int pos)
            {
                posReturn_ = pos;
            }
            public bool IsInner()
            {
                return bInner_;
            }
            public virtual bool IsGlobal()
            {
                return false;
            }
    }

    public class EventScriptBlock_Main : EventScriptBlock
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend EventScriptSource;
            private string name_ = "";
            public EventScriptBlock_Main()
            {
                bInner_ = false;
            }
            public override void Dispose()
            {
                base.Dispose();
            }
            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public new bool IsGlobal()
            {
                return name_ == BLOCK_GLOBAL;
            }
    }

    /**********************************************************
    //EventScriptCode
    **********************************************************/
    public class EventScriptCode : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum2
            {
                TYPE_UNKNOWN,
                TYPE_TEXT,
                TYPE_NEXT_LINE,
                TYPE_WAIT_CLICK,
                TYPE_WAIT_NEXT_PAGE,
                TYPE_WAIT_TIME,
                TYPE_CLEAR_MESSAGE,
                TYPE_NAME,
                TYPE_TRANSITION,
                TYPE_VISIBLE_TEXT,

                TYPE_VAR,
                TYPE_EVAL,
                TYPE_SYSVAL,
                TYPE_OUTPUT,

                TYPE_IMAGE,
                TYPE_SOUND,

                TYPE_IF,
                TYPE_ELSEIF,
                TYPE_ENDIF,
                TYPE_LOOP,
                TYPE_JUMP,

                TYPE_SCRIPT,
                TYPE_END,
                TYPE_BATTLE
            }
            public const string TAG_WAIT_CLICK = "l";
            public const string TAG_WAIT_NEXT_PAGE = "p";
            public const string TAG_WAIT_TIME = "wait";
            public const string TAG_CLEAR_MESSAGE = "cm";
            public const string TAG_NAME = "nm";
            public const string TAG_TRANSITION = "trans";
            public const string TAG_VISIBLE_TEXT = "vw";
            public const string TAG_VAR = "var";
            public const string TAG_EVAL = "eval";
            public const string TAG_SYSVAL = "sysval";
            public const string TAG_OUTPUT = "output";
            public const string TAG_IMAGE = "image";
            public const string TAG_BGM = "bgm";
            public const string TAG_SE = "se";
            public const string TAG_IF = "if";
            public const string TAG_ELSEIF = "elseif";
            public const string TAG_ENDIF = "endif";
            public const string TAG_GOSUB = "gosub";
            public const string TAG_GOTO = "goto";
            public const string TAG_SCRIPT = "script";
            public const string TAG_SCRIPT_END = "script_end";
            public const string TAG_END = "end";
            public const string TAG_BATTLE = "battle";

            public const string STRING_INVALID = "__VALUE_INVALID__";
            protected int type_;
            protected int line_;

            /**********************************************************
            //EventScriptBlock
            **********************************************************/

            /**********************************************************
            //EventScriptCode
            **********************************************************/


            public EventScriptCode()
            {
                line_ = -1;
                type_ = (int)AnonymousEnum2.TYPE_UNKNOWN;
            }

            public virtual void Dispose()
            {
            }

            public int GetType()
            {
                return type_;
            }
            public int GetLine()
            {
                return line_;
            }
            public void SetLine(int line)
            {
                line_ = line;
            }
            public virtual string GetCodeText()
            {
                return "";
            }
    }

    public class EventScriptCode_Text : EventScriptCode
    {
            protected string text_ = "";

            // EventScriptCode_Text
            public EventScriptCode_Text()
            {
                type_ = TYPE_TEXT;
            }

            public string GetText()
            {
                return text_;
            }
            public new string GetCodeText()
            {
                return GetText();
            }
            public void SetText(string text)
            {
                text_ = text;
            }
    }
    public class EventScriptCode_NextLine : EventScriptCode
    {

            // EventScriptCode_NextLine
            public EventScriptCode_NextLine()
            {
                type_ = TYPE_NEXT_LINE;
            }

            public new string GetCodeText()
            {
                return EventScriptScanner.TAG_START + EventScriptScanner.TAG_NEW_LINE + EventScriptScanner.TAG_END;
            }
    }
    public class EventScriptCode_WaitClick : EventScriptCode
    {

            // EventScriptCode_WaitClick
            public EventScriptCode_WaitClick()
            {
                type_ = TYPE_WAIT_CLICK;
            }
    }
    public class EventScriptCode_WaitNextPage : EventScriptCode
    {

            // EventScriptCode_WaitNextPage
            public EventScriptCode_WaitNextPage()
            {
                type_ = TYPE_WAIT_NEXT_PAGE;
            }
    }
    public class EventScriptCode_WaitTime : EventScriptCode
    {
            private string time_ = "";
            private bool bSkipEnable_;

            // EventScriptCode_WaitTime
            public EventScriptCode_WaitTime()
            {
                type_ = TYPE_WAIT_TIME;
                time_ = "0";
                bSkipEnable_ = true;
            }

            public string GetTime()
            {
                return time_;
            }
            public void SetTime(string time)
            {
                time_ = time;
            }
            public bool IsSkipEnable()
            {
                return bSkipEnable_;
            }
            public void SetSkipEnable(bool bEnable)
            {
                bSkipEnable_ = bEnable;
            }
    }
    public class EventScriptCode_ClearMessage : EventScriptCode
    {

            // EventScriptCode_ClearMessage
            public EventScriptCode_ClearMessage()
            {
                type_ = TYPE_CLEAR_MESSAGE;
            }
    }
    public class EventScriptCode_Name : EventScriptCode
    {
            private string name_ = "";

            // EventScriptCode_Name
            public EventScriptCode_Name()
            {
                type_ = TYPE_NAME;
            }

            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
    }
    public class EventScriptCode_Transition : EventScriptCode
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum3
            {
                TRANS_NONE,
                TRANS_FADE,
                TRANS_SCRIPT
            }
            protected int typeTrans_;
            protected string frame_ = "";
            protected string path_ = "";
            protected string method_ = "";

            // EventScriptCode_Transition
            public EventScriptCode_Transition()
            {
                type_ = TYPE_TRANSITION;
                typeTrans_ = (int)AnonymousEnum3.TRANS_NONE;
                frame_ = "30";
            }

            public int GetTransType()
            {
                return typeTrans_;
            }
            public void SetTransType(int type)
            {
                typeTrans_ = type;
            }
            public string GetFrame()
            {
                return frame_;
            }
            public void SetFrame(string frame)
            {
                frame_ = frame;
            }
            public string GetPath()
            {
                return path_;
            }
            public void SetPath(string path)
            {
                path_ = path;
            }
            public string GetMethod()
            {
                return method_;
            }
            public void SetMethod(string method)
            {
                method_ = method;
            }

    }
    public class EventScriptCode_VisibleText : EventScriptCode
    {
            private bool bVisible_;

            // EventScriptCode_VisibleText
            public EventScriptCode_VisibleText()
            {
                type_ = TYPE_VISIBLE_TEXT;
                bVisible_ = true;
            }

            public bool IsVisible()
            {
                return bVisible_;
            }
            public void SetVisible(bool bVisible)
            {
                bVisible_ = bVisible;
            }
    }
    public class EventScriptCode_Var : EventScriptCode
    {
            private string name_ = "";
            private string value_ = "";

            // EventScriptCode_Var
            public EventScriptCode_Var()
            {
                type_ = TYPE_VAR;
            }

            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public string GetValue()
            {
                return value_;
            }
            public void SetValue(string value)
            {
                value_ = value;
            }
    }
    public class EventScriptCode_Eval : EventScriptCode
    {
            private string name_ = "";
            private string value_ = "";

            // EventScriptCode_Eval
            public EventScriptCode_Eval()
            {
                type_ = TYPE_EVAL;
            }

            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public string GetValue()
            {
                return value_;
            }
            public void SetValue(string value)
            {
                value_ = value;
            }
    }
    public class EventScriptCode_SysVal : EventScriptCode
    {
            private bool bGlobal_;
            private string name_ = "";
            private string value_ = "";

            // EventScriptCode_SysVal
            public EventScriptCode_SysVal()
            {
                type_ = TYPE_SYSVAL;
                bGlobal_ = false;
            }

            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public string GetValue()
            {
                return value_;
            }
            public void SetValue(string value)
            {
                value_ = value;
            }
            public bool IsGlobal()
            {
                return bGlobal_;
            }
            public void SetGlobal(bool b)
            {
                bGlobal_ = b;
            }
    }
    public class EventScriptCode_Output : EventScriptCode
    {
            private string value_ = "";

            // EventScriptCode_Output
            public EventScriptCode_Output()
            {
                type_ = TYPE_OUTPUT;
            }

            public string GetValue()
            {
                return value_;
            }
            public void SetValue(string value)
            {
                value_ = value;
            }
    }
    public class EventScriptCode_Image : EventScriptCode
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum4
            {
                VALUE_INVALID = INT_MIN
            }
            protected string idObject_ = "";
            protected string path_ = "";
            protected int layer_;
            protected string pri_ = "";
            protected string bVisible_ = "";
            protected string posDestLeft_ = "";
            protected string posDestTop_ = "";
            protected string bTransition_ = "";
            protected string bWaitEnd_ = "";

            // EventScriptCode_Image
            public EventScriptCode_Image()
            {
                type_ = TYPE_IMAGE;
                idObject_ = STRING_INVALID;
                layer_ = EventImage.LAYER_FOREGROUND;
                pri_ = STRING_INVALID;
                bVisible_ = "true";
                posDestLeft_ = STRING_INVALID;
                posDestTop_ = STRING_INVALID;
                bTransition_ = "true";
                bWaitEnd_ = "true";
            }

            public string GetObjectIdentifier()
            {
                return idObject_;
            }
            public void SetObjectIdentifier(string id)
            {
                idObject_ = id;
            }
            public string GetPath()
            {
                return path_;
            }
            public void SetPath(string path)
            {
                path_ = path;
            }
            public int GetLayer()
            {
                return layer_;
            }
            public void SetLayer(int layer)
            {
                layer_ = layer;
            }
            public string GetPriority()
            {
                return pri_;
            }
            public void SetPriority(string pri)
            {
                pri_ = pri;
            }
            public string GetVisible()
            {
                return bVisible_;
            }
            public void SetVisible(string bVisible)
            {
                bVisible_ = bVisible_;
            }
            public string GetLeftDestPoint()
            {
                return posDestLeft_;
            }
            public void SetLeftDestPoint(string left)
            {
                posDestLeft_ = left;
            }
            public string GetTopDestPoint()
            {
                return posDestTop_;
            }
            public void SetTopDestPoint(string top)
            {
                posDestTop_ = top;
            }
            public string GetTransition()
            {
                return bTransition_;
            }
            public void SetTransition(string bTrans)
            {
                bTransition_ = bTrans;
            }
            public string GetWaitEnd()
            {
                return bWaitEnd_;
            }
            public void SetWaitEnd(string bWaitEnd)
            {
                bWaitEnd_ = bWaitEnd;
            }
    }
    public class EventScriptCode_Sound : EventScriptCode
    {
            private int typeSound_;
            private string path_ = "";

            // EventScriptCode_Sound
            public EventScriptCode_Sound()
            {
                type_ = TYPE_SOUND;
            }

            public int GetSoundType()
            {
                return typeSound_;
            }
            public void SetSoundType(int type)
            {
                typeSound_ = type;
            }
            public string GetPath()
            {
                return path_;
            }
            public void SetPath(string path)
            {
                path_ = path;
            }
    }
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class EventScriptCode_If : EventScriptCode, EventScriptBlock
    {
            protected string param_ = "";
            protected int posNextElse_;

            // EventScriptCode_If
            public EventScriptCode_If()
            {
                type_ = TYPE_IF;
                bInner_ = true;
                param_ = "true";
                posNextElse_ = -1;
            }

            public string GetParameter()
            {
                return param_;
            }
            public void SetParameter(string param)
            {
                param_ = param;
            }
            public int GetNextElsePosition()
            {
                return posNextElse_;
            }
            public void SetNextElsePosition(int pos)
            {
                posNextElse_ = pos;
            }
    }

    public class EventScriptCode_Jump : EventScriptCode
    {
            protected bool bGoSub_;
            protected string path_ = "";
            protected string name_ = "";

            // EventScriptCode_Jump
            public EventScriptCode_Jump()
            {
                type_ = TYPE_JUMP;
                bGoSub_ = false;
            }

            public bool IsGoSub()
            {
                return bGoSub_;
            }
            public void SetGosub(bool b)
            {
                bGoSub_ = b;
            }

            public string GetPath()
            {
                return path_;
            }
            public void SetPath(string path)
            {
                path_ = path;
            }
            public string GetName()
            {
                return name_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
    }

    public class EventScriptCode_Script : EventScriptCode
    {
            private string path_ = "";
            private string method_ = "";
            private string bWaitEnd_ = "";
            private string targetId_ = "";
            private string code_ = "";
            private string id_ = "";
            private List<string> arg_ = new List<string>();
            private bool bEndScript_;

            // EventScriptCode_Script
            public EventScriptCode_Script()
            {
                type_ = TYPE_SCRIPT;
                bWaitEnd_ = "true";
                bEndScript_ = false;
                targetId_ = StringUtility.Format("%d", DxScript.ID_INVALID);
            }

            public string GetPath()
            {
                return path_;
            }
            public void SetPath(string path)
            {
                path_ = path;
            }
            public string GetMethod()
            {
                return method_;
            }
            public void SetMethod(string method)
            {
                method_ = method;
            }
            public string GetWaitEnd()
            {
                return bWaitEnd_;
            }
            public void SetWaitEnd(string bWait)
            {
                bWaitEnd_ = bWait;
            }
            public string GetTargetId()
            {
                return targetId_;
            }
            public void SetTargetId(string target)
            {
                targetId_ = target;
            }
            public string GetCode()
            {
                return code_;
            }
            public void SetCode(string code)
            {
                code_ = code;
            }
            public string GetId()
            {
                return id_;
            }
            public void SetId(string id)
            {
                id_ = id;
            }
            public List<string> GetArgumentList()
            {
                return new List<string>(arg_);
            }
            public void SetArgument(int index, string arg)
            {
                if (index >= arg_.Count)
                {
                    arg_.Resize(index + 1);
                }
                arg_[index] = arg;
            }

            public bool IsEndScript()
            {
                return bEndScript_;
            }
            public void SetEndScript(bool bEnd)
            {
                bEndScript_ = bEnd;
            }
    }

    public class EventScriptCode_End : EventScriptCode
    {
            protected string arg_ = "";

            // EventScriptCode_End
            public EventScriptCode_End()
            {
                type_ = TYPE_END;
            }

            public string GetArgument()
            {
                return arg_;
            }
            public void SetArgument(string arg)
            {
                arg_ = arg;
            }
    }

    public class EventScriptCode_Battle : EventScriptCode
    {
            protected string path_ = "";

            // EventScriptCode_Battle
            public EventScriptCode_Battle()
            {
                type_ = TYPE_BATTLE;
            }

            public string GetPath()
            {
                return path_;
            }
            public void SetPath(string path)
            {
                path_ = path;
            }
    }


    /**********************************************************
    //EventScriptCodeExecuter
    **********************************************************/
    public abstract class EventScriptCodeExecuter : System.IDisposable
    {
            protected EventEngine engine_;
            protected bool bEnd_;

            protected int _GetElementInteger(string value)
            {
                EventValueParser parser = new EventValueParser(engine_);
                ref_count_ptr<EventValue> res = parser.GetEventValue(value);
                return floorl(res.GetReal() + 0.5);
            }

            protected double _GetElementReal(string value)
            {
                EventValueParser parser = new EventValueParser(engine_);
                ref_count_ptr<EventValue> res = parser.GetEventValue(value);
                return res.GetReal();
            }

            protected bool _GetElementBoolean(string value)
            {
                EventValueParser parser = new EventValueParser(engine_);
                ref_count_ptr<EventValue> res = parser.GetEventValue(value);
                return res.GetBoolean();
            }

            protected string _GetElementString(string value)
            {
                EventValueParser parser = new EventValueParser(engine_);
                ref_count_ptr<EventValue> res = parser.GetEventValue(value);
                return res.GetString();
            }

            protected bool _IsValieElement(string value)
            {
                return value != EventScriptCode.STRING_INVALID;
            }

            /**********************************************************
            //EventScriptCodeExecuter
            **********************************************************/
            public EventScriptCodeExecuter(EventEngine engine)
            {
                engine_ = engine;
                bEnd_ = false;
            }

            public virtual void Dispose()
            {

            }

            public abstract void Execute();
            public bool IsEnd()
            {
                return bEnd_;
            }
    }

    public class EventScriptCodeExecuter_WaitClick : EventScriptCodeExecuter
    {
            public EventScriptCodeExecuter_WaitClick(EventEngine engine) : base(engine)
            {
            }
            // EventScriptCodeExecuter_WaitClick
            public override void Execute()
            {
                gstd.ref_count_ptr<EventKeyState> keyState = engine_.GetEventKeyState();
                bool bkeyNext = keyState.IsNext();
                bool bKeySkip = keyState.IsSkip();

                if (bkeyNext || bKeySkip)
                {
                    bEnd_ = true;
                }
            }
    }

    public class EventScriptCodeExecuter_WaitNextPage : EventScriptCodeExecuter
    {
            public EventScriptCodeExecuter_WaitNextPage(EventEngine engine) : base(engine)
            {
            }

            // EventScriptCodeExecuter_WaitNextPage
            public override void Execute()
            {
                gstd.ref_count_ptr<EventKeyState> keyState = engine_.GetEventKeyState();
                bool bkeyNext = keyState.IsNext();
                bool bKeySkip = keyState.IsSkip();

                if (bkeyNext || bKeySkip)
                {
                    bEnd_ = true;
                }
            }
    }

    public class EventScriptCodeExecuter_WaitTime : EventScriptCodeExecuter
    {
            private int count_;
            private int time_;
            private bool bSkipEnable_;

            // EventScriptCodeExecuter_WaitTime
            public EventScriptCodeExecuter_WaitTime(EventEngine engine, EventScriptCode_WaitTime code) : base(engine)
            {
                count_ = 0;
                time_ = _GetElementInteger(code.GetTime());
                bSkipEnable_ = code.IsSkipEnable();
            }

            public override void Execute()
            {
                if (count_ >= time_)
                {
                    bEnd_ = true;
                }
                if (bSkipEnable_)
                {
                    gstd.ref_count_ptr<EventKeyState> keyState = engine_.GetEventKeyState();
                    bool bKeySkip = keyState.IsSkip();
                    if (bKeySkip)
                    {
                        bEnd_ = true;
                    }
                }
                count_++;
            }
    }

    public class EventScriptCodeExecuter_Transition : EventScriptCodeExecuter
    {
            private class DxScriptRenderObject_Transition : DxScriptObjectBase
            {
                    private TransitionEffect effect_;
                    public DxScriptRenderObject_Transition(TransitionEffect effect)
                    {
                        effect_ = effect;
                        priRender_ = 1.0;
                    }
                    public override void Render()
                    {
                        effect_.Render();
                    }
                    public override void SetRenderState()
                    {
                    }
            }
            private EventScriptCode_Transition[] code_;
            private gstd.ref_count_ptr<DxScriptForEvent> script_ = new gstd.ref_count_ptr<DxScriptForEvent>();
            private gstd.ref_count_ptr<TransitionEffect> effect_ = new gstd.ref_count_ptr<TransitionEffect>();
            private int frame_;

            // EventScriptCodeExecuter_Transition
            public EventScriptCodeExecuter_Transition(EventEngine engine, EventScriptCode_Transition code) : base(engine)
            {
                code_ = code;
                frame_ = 0;
            }

            public override void Execute()
            {
                if (frame_ == 0)
                {
                    DirectGraphics graphics = DirectGraphics.GetBase();
                    TextureManager manager = TextureManager.GetBase();
                    gstd.ref_count_ptr<EventImage> image = engine_.GetEventImage();

                    ref_count_ptr<Texture> texture = manager.GetTexture(TextureManager.TARGET_TRANSITION);
                    graphics.SetRenderTarget(new ref_count_ptr<Texture>(texture));
                    graphics.ClearRenderTarget();
                    graphics.BeginScene();

                    {
                    // �w�i�͍��œh��Ԃ�
                        Sprite2D back = new Sprite2D();
                        RECT_D rcDest = new RECT_D() { left = 0.0, top = 0.0, right = (double)graphics.GetScreenWidth(), bottom = (double)graphics.GetScreenHeight() };
                        back.SetColorRGB(D3DCOLOR_ARGB(255, 0, 0, 0));
                        back.SetDestinationRect(rcDest);
                        back.Render();
                    }

                    image.Render(image.GetForegroundLayerIndex());

                    graphics.EndScene();
                    graphics.SetRenderTarget(null);
                    image.SwapForeBackLayerIndex();

                    int layer = image.GetForegroundLayerIndex();
                    gstd.ref_count_ptr<DxScriptObjectManager> objManager = image.GetObjectManager(layer);
                    DxScriptObjectBase obj = null;
                    int type = code_.GetTransType();
                    switch (type)
                    {
                        case EventScriptCode_Transition.TRANS_NONE:
                            break;
                        case EventScriptCode_Transition.TRANS_FADE:
                        {
                            int frame = _GetElementInteger(code_.GetFrame());
                            TransitionEffect_FadeOut effect = new TransitionEffect_FadeOut();
                            effect.Initialize(frame, new ref_count_ptr<Texture>(texture));
                            effect_ = effect;
                            obj = new DxScriptRenderObject_Transition(effect_.GetPointer());

                            objManager.AddObject(EventImage.ID_TRANSITION, obj);
                            break;
                        }
                        case EventScriptCode_Transition.TRANS_SCRIPT:
                        {
                            RECT_D rect = new RECT_D() { left = 0.0, top = 0.0, right = (double)graphics.GetScreenWidth(), bottom = (double)graphics.GetScreenHeight() };
                            DxScriptSpriteObject2D sprite = new DxScriptSpriteObject2D();
                            sprite.SetTexture(texture);
                            sprite.SetRenderPriority(1.0);
                            sprite.GetSpritePointer().SetDestinationRect(rect);
                            sprite.GetSpritePointer().SetSourceRect(rect);
                            obj = sprite;
                            objManager.AddObject(EventImage.ID_TRANSITION, obj);

                            string path = _GetElementString(code_.GetPath());
                            string method = _GetElementString(code_.GetMethod());
                            string wPath = StringUtility.ConvertMultiToWide(path);
                            script_ = new DxScriptForEvent(engine_);
                            script_.SetTargetId(EventImage.ID_TRANSITION);
                            script_.SetMethod(method);
                            script_.SetSourceFromFile(wPath);
                            script_.Compile();
                            script_.Run(method);

                            break;
                        }
                    }
                }

                if (effect_ == null && script_ == null)
                {
                    bEnd_ = true;
                    return;
                }

                if (effect_ != null)
                {
                    effect_.Work();
                }
                else if (script_ != null)
                {
                    script_.Run("MainLoop");
                }

                gstd.ref_count_ptr<EventKeyState> keyState = engine_.GetEventKeyState();
                bool bkeyNext = keyState.IsNext();
                bool bKeySkip = keyState.IsSkip();

                if (effect_ != null)
                {
                    bEnd_ = effect_.IsEnd();
                }
                else if (script_ != null)
                {
                    bEnd_ = script_.IsScriptEnd();
                }

                if (bEnd_ || bkeyNext || bKeySkip)
                {
                    gstd.ref_count_ptr<EventImage> image = engine_.GetEventImage();
                    int layer = image.GetForegroundLayerIndex();
                    gstd.ref_count_ptr<DxScriptObjectManager> objManager = image.GetObjectManager(layer);
                    objManager.DeleteObject(EventImage.ID_TRANSITION);
                }
                frame_++;
            }
    }

    public class EventScriptCodeExecuter_Image : EventScriptCodeExecuter
    {
            private EventScriptCode_Image[] code_;
            private string pathImage_ = "";
            private gstd.ref_count_ptr<DxScriptObjectManager> objManager_ = new gstd.ref_count_ptr<DxScriptObjectManager>();
            private gstd.ref_count_ptr<DxScriptSpriteObject2D>.unsync nowSprite_ = new gstd.ref_count_ptr<DxScriptSpriteObject2D>.unsync();
            private gstd.ref_count_ptr<DxScriptSpriteObject2D>.unsync oldSprite_ = new gstd.ref_count_ptr<DxScriptSpriteObject2D>.unsync();
            private int frame_;
            private bool bTrans_;
            private double priority_;

            private void _Initialize()
            {
                ref_count_ptr<EventImage> imageManager = engine_.GetEventImage();
                int layer = code_.GetLayer();
                if (layer == EventImage.LAYER_FOREGROUND)
                {
                    layer = imageManager.GetForegroundLayerIndex();
                }
                else if (layer == EventImage.LAYER_BACKGROUND)
                {
                    layer = imageManager.GetBackgroundLayerIndex();
                }
                objManager_ = imageManager.GetObjectManager(layer);

                string path = _GetElementString(code_.GetPath());
                string wPath = StringUtility.ConvertMultiToWide(path);
                int idObj = _GetElementInteger(code_.GetObjectIdentifier());
                nowSprite_ = ref_count_ptr<DxScriptSpriteObject2D>.unsync.DownCast(objManager_.GetObject(idObj));
                if (nowSprite_ == null && path.Length > 0)
                {
                    nowSprite_ = new DxScriptSpriteObject2D();
                    nowSprite_.SetRenderPriority(priority_);
                    objManager_.AddObject(idObj, nowSprite_);
                    bTrans_ = true;
                }

                // �p�X�m�F
                if (nowSprite_ != null)
                {
                    ref_count_ptr<Texture> texture = nowSprite_.GetObjectPointer().GetTexture();
                    if (texture == null)
                    {
                        texture = new Texture();
                        // texture->CreateFromFile(path);
                        texture.CreateFromFileInLoadThread(wPath, true);
                        nowSprite_.SetTexture(texture);
                        Sprite2D sprite = nowSprite_.GetSpritePointer();

                        RECT_D rect = new RECT_D() { left = 0.0, top = 0.0, right = (double)texture.GetWidth(), bottom = (double)texture.GetHeight() };
                        sprite.SetDestinationRect(rect);
                        sprite.SetVertex(rect, rect, D3DCOLOR_ARGB(255,255,255,255));
                        bTrans_ = true;
                    }

                    if (path.Length != 0)
                    {
                        if (texture.GetName() != wPath)
                        {
                            // �摜�ύX
                            int idObjOld = EventImage.INDEX_OLD_START + idObj;
                            oldSprite_ = new DxScriptSpriteObject2D();
                            oldSprite_.Copy(nowSprite_.GetPointer());
                            objManager_.AddObject(idObjOld, oldSprite_);

                            Sprite2D sprite = nowSprite_.GetSpritePointer();
                            texture = new Texture();
                            // texture->CreateFromFile(path);
                            texture.CreateFromFileInLoadThread(wPath, true);
                            nowSprite_.SetTexture(texture);
                            RECT_D rect = new RECT_D() { left = 0.0, top = 0.0, right = (double)texture.GetWidth(), bottom = (double)texture.GetHeight() };
                            sprite.SetDestinationRect(rect);
                            sprite.SetVertex(rect, rect, D3DCOLOR_ARGB(255,255,255,255));
                            bTrans_ = true;
                        }
                    }
                    else
                    {
                        int idObjOld = EventImage.INDEX_OLD_START + idObj;
                        oldSprite_ = new DxScriptSpriteObject2D();
                        oldSprite_.Copy(nowSprite_.GetPointer());
                        objManager_.AddObject(idObjOld, oldSprite_);

                        objManager_.DeleteObject(idObj);
                        nowSprite_ = null;
                        bTrans_ = true;
                    }

                }

                if (nowSprite_ != null)
                {
                    if (_IsValieElement(code_.GetLeftDestPoint()))
                    {
                        nowSprite_.SetX(_GetElementInteger(code_.GetLeftDestPoint()));
                    }
                    if (_IsValieElement(code_.GetTopDestPoint()))
                    {
                        nowSprite_.SetY(_GetElementInteger(code_.GetTopDestPoint()));
                    }
                    if (_IsValieElement(code_.GetPriority()))
                    {
                        nowSprite_.SetRenderPriority(_GetElementReal(code_.GetPriority()));
                    }
                }

                if (_IsValieElement(code_.GetTransition()))
                {
                    bTrans_ &= _GetElementBoolean(code_.GetTransition());
                }
            }


            // EventScriptCodeExecuter_Image
            public EventScriptCodeExecuter_Image(EventEngine engine, EventScriptCode_Image code) : base(engine)
            {
                code_ = code;
                frame_ = 0;
                bTrans_ = false;

                EventValueParser parser = new EventValueParser(engine);
                string strPri = code_.GetPriority();
                ref_count_ptr<EventValue> val = parser.GetEventValue(strPri);
                priority_ = val.GetReal();
            }

            public new void Dispose()
            {
                objManager_ = null;
                nowSprite_ = null;
                oldSprite_ = null;
                base.Dispose();
            }

            public override void Execute()
            {
                const int frameTrans = 10;
                if (frame_ == 0)
                {
                    _Initialize();
                }

                gstd.ref_count_ptr<EventKeyState> keyState = engine_.GetEventKeyState();
                bool bkeyNext = keyState.IsNext();
                bool bKeySkip = keyState.IsSkip();

                if (frame_ >= frameTrans || !bTrans_ || bkeyNext || bKeySkip)
                {
                    if (oldSprite_ != null)
                    {
                        objManager_.DeleteObject(oldSprite_.GetObjectID());
                    }
                    if (nowSprite_ != null)
                    {
                        nowSprite_.SetAlpha(255);
                    }
                    bEnd_ = true;
                    return;
                }

                double dAlpha = (double)255 / (double)frameTrans;

                if (nowSprite_ != null)
                {
                    nowSprite_.SetAlpha(dAlpha * frame_);
                }
                if (oldSprite_ != null)
                {
                    oldSprite_.SetAlpha(255 - dAlpha * frame_);
                }

                frame_++;
            }
    }

    public class EventScriptCodeExecuter_Script : EventScriptCodeExecuter
    {
            private DxScriptForEvent script_;

            // EventScriptCodeExecuter_Script
            public EventScriptCodeExecuter_Script(EventEngine engine, DxScriptForEvent script) : base(engine)
            {
                script_ = script;
            }

            public override void Execute()
            {
                if (script_.IsScriptEnd())
                {
                    bEnd_ = true;
                }
            }
    }

    /**********************************************************
    //EventWindowManager
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventMouseCaptureLayer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventTextWindow;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventNameWindow;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class EventLogWindow;
    public class EventWindowManager : DxWindowManager
    {
            protected EventEngine engine_;
            protected gstd.ref_count_ptr<EventMouseCaptureLayer> layerCapture_ = new gstd.ref_count_ptr<EventMouseCaptureLayer>();
            protected gstd.ref_count_ptr<EventTextWindow> wndText_ = new gstd.ref_count_ptr<EventTextWindow>();
            protected gstd.ref_count_ptr<EventLogWindow> wndLog_ = new gstd.ref_count_ptr<EventLogWindow>();
            protected gstd.ref_count_ptr<EventNameWindow> wndName_ = new gstd.ref_count_ptr<EventNameWindow>();

            protected gstd.ref_count_ptr<DxButton> btnSave_ = new gstd.ref_count_ptr<DxButton>();
            protected gstd.ref_count_ptr<DxButton> btnLoad_ = new gstd.ref_count_ptr<DxButton>();

            protected bool bVisibleText_;

            /**********************************************************
            //EventWindowManager
            **********************************************************/
            public EventWindowManager(EventEngine engine)
            {
                engine_ = engine;
                bVisibleText_ = true;
            }

            public EventEngine GetEngine()
            {
                return engine_;
            }
            public virtual bool Initialize()
            {
                // �Z�[�u�{�^��

                // ���[�h�{�^��

                // �L���v�`�����C��
                layerCapture_ = new EventMouseCaptureLayer();
                AddWindow(layerCapture_);

                // �e�L�X�g�E�B���h�E
                wndText_ = new EventTextWindow();
                AddWindow(wndText_);

                // ���O�E�B���h�E
                wndLog_ = new EventLogWindow();
                AddWindow(wndLog_);
                wndLog_.SetWindowEnable(false);
                wndLog_.SetWindowVisible(false);

                // ���O�E�B���h�E
                wndName_ = new EventNameWindow();

                return true;
            }

            public override void Work()
            {
                layerCapture_.ClearEvent();
                base.Work();
            }

            public override void Render()
            {
                base.Render();
            }

            public gstd.ref_count_ptr<EventMouseCaptureLayer> GetMouseCaptureLayer()
            {
                return new gstd.ref_count_ptr<EventMouseCaptureLayer>(layerCapture_);
            }
            public gstd.ref_count_ptr<EventTextWindow> GetTextWindow()
            {
                return new gstd.ref_count_ptr<EventTextWindow>(wndText_);
            }
            public gstd.ref_count_ptr<EventLogWindow> GetLogWindow()
            {
                return new gstd.ref_count_ptr<EventLogWindow>(wndLog_);
            }
            public gstd.ref_count_ptr<EventNameWindow> GetNameWindow()
            {
                return new gstd.ref_count_ptr<EventNameWindow>(wndName_);
            }

            public gstd.ref_count_ptr<DxButton> GetSaveButton()
            {
                return new gstd.ref_count_ptr<DxButton>(btnSave_);
            }
            public gstd.ref_count_ptr<DxButton> GetLoadButton()
            {
                return new gstd.ref_count_ptr<DxButton>(btnLoad_);
            }

            public bool IsTextVisible()
            {
                return bVisibleText_;
            }
            public void SetTextVisible(bool bVisible)
            {
                bVisibleText_ = bVisible;
            }

            public void Read(gstd.RecordBuffer record)
            {
                // ���O��
                string name = record.GetRecordAsStringW("name");
                wndName_.SetText(name);
            }

            public void Write(gstd.RecordBuffer record)
            {
                // ���O��
                string name = wndName_.GetText();
                record.SetRecordAsStringW("name", name);
            }
    }

    public class EventWindow : DxWindow
    {
            protected bool bApplyVisibleText_;
            protected EventWindowManager _GetManager()
            {
                return (EventWindowManager)manager_;
            }
            public EventWindow()
            {
                bApplyVisibleText_ = true;
            }

            // EventWindow
            public override bool IsWindowVisible()
            {
                bool res = base.IsWindowVisible();
                if (bApplyVisibleText_)
                {
                    res &= _GetManager().IsTextVisible();
                }
                return res;
            }
    }
    public class EventButton : DxButton
    {
            protected bool bApplyVisibleText_;
            protected EventWindowManager _GetManager()
            {
                return (EventWindowManager)manager_;
            }
            public EventButton()
            {
                bApplyVisibleText_ = true;
            }

            // EventWindow
            public override bool IsWindowVisible()
            {
                bool res = base.IsWindowVisible();
                if (bApplyVisibleText_)
                {
                    res &= _GetManager().IsTextVisible();
                }
                return res;
            }
    }
    public class EventMouseCaptureLayer : EventWindow
    {
            protected gstd.ref_count_ptr<DxWindowEvent> event_ = new gstd.ref_count_ptr<DxWindowEvent>();

            // EventMouseCaptureLayer
            public override void AddedManager()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                RECT rect = new RECT(0, 0, graphics.GetScreenWidth(), graphics.GetScreenHeight());
                SetWindowRect(new RECT(rect));
            }

            public override void DispatchedEvent(gstd.ref_count_ptr<DxWindowEvent> @event)
            {
                gstd.ref_count_ptr<DxWindow> window = @event.GetSourceWindow();
                if (window != null && window.GetID() == GetID())
                {
                    if (@event.HasEventType(DxWindowEvent.TYPE_MOUSE_LEFT_CLICK))
                    {
                        event_.CopyFrom(@event);
                    }
                }
            }

            public void ClearEvent()
            {
                event_ = null;
            }

            public gstd.ref_count_ptr<DxWindowEvent> GetEvent()
            {
                return new gstd.ref_count_ptr<DxWindowEvent>(event_);
            }
    }
    public class EventTextWindow : EventWindow
    {
            protected RECT rcMargin_ = new RECT();
            protected gstd.ref_count_ptr<DxText> dxText_ = new gstd.ref_count_ptr<DxText>();

            // EventTextWindow
            public EventTextWindow()
            {
                dxText_ = new DxText();
                dxText_.SetFontType(Font.MINCHOH);
                dxText_.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                dxText_.SetFontColorBottom(D3DCOLOR_ARGB(255,255,255,255));
                dxText_.SetFontBorderType(directx.DxFont.BORDER_SHADOW);
                dxText_.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,32));
                dxText_.SetFontBorderWidth(2);
                dxText_.SetLinePitch(20);
                dxText_.SetFontSize(24);
                dxText_.SetFontBold(true);

                ZeroMemory(rcMargin_, sizeof(RECT));
                rcMargin_.left = 16;
                rcMargin_.top = 16;
                rcMargin_.right = 16;
            }

            public override void AddedManager()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                RECT rect = new RECT(0, 440, graphics.GetScreenWidth(), 600);
                SetWindowRect(new RECT(rect));

                ref_count_ptr<Sprite2D> sprite = new Sprite2D();
                sprite.SetColorRGB(D3DCOLOR_ARGB(255, 64, 64, 64));
                sprite.SetAlpha(192);
                SetFrameSprite(new ref_count_ptr<Sprite2D>(sprite));
            }

            public override void Render()
            {
                _RenderFrame();

                EventEngine engine = _GetManager().GetEngine();
                gstd.ref_count_ptr<EventText> textEvent = engine.GetEventText();
                RECT rect = GetWindowRect();
                dxText_.SetPosition(rect.left + rcMargin_.left, rect.top + rcMargin_.top);
                dxText_.SetMaxWidth(rect.right - rect.left - rcMargin_.left - rcMargin_.right);
                dxText_.SetMaxHeight(int.MaxValue);
                dxText_.SetText(textEvent.GetText());
                gstd.ref_count_ptr<DxTextInfo> textInfo = dxText_.GetTextInfo();

                bool bVoice = textEvent.IsVoiceText();
                textInfo.SetAutoIndent(bVoice);

                int maxHeight = rect.bottom - rect.top - rcMargin_.top - rcMargin_.bottom;
                dxText_.SetMaxHeight(maxHeight);
                int countLine = textInfo.GetLineCount();
                int heightTotal = 0;
                int lineEnd = countLine;
                int lineStart = lineEnd;
                for (int iLine = countLine-1; iLine >= 0 ; iLine--)
                {
                    gstd.ref_count_ptr<DxTextLine> lineText = textInfo.GetTextLine(iLine);
                    heightTotal += lineText.GetHeight() + dxText_.GetLinePitch();
                    if (heightTotal > maxHeight - 8)
                    {
                        break;
                    }
                    lineStart--;
                }
                textInfo.SetValidStartLine(System.Math.Max(lineStart, 1));
                textInfo.SetValidEndLine(lineEnd);
                dxText_.Render(textInfo);
            }

            public bool IsWait()
            {
                EventEngine engine = _GetManager().GetEngine();
                gstd.ref_count_ptr<EventScriptCodeExecuter> executer = engine.GetActiveCodeExecuter();
                return executer.GetPointer() as EventScriptCodeExecuter_WaitClick != null != null;
            }
    }
    public class EventNameWindow : EventWindow
    {
        private gstd.ref_count_ptr<DxText> text_ = new gstd.ref_count_ptr<DxText>();
            // EventNameWindow
            public EventNameWindow()
            {
                text_ = new DxText();
                text_.SetFontType(Font.MINCHOH);
                text_.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                text_.SetFontColorBottom(D3DCOLOR_ARGB(255,255,255,255));
                text_.SetFontBorderType(directx.DxFont.BORDER_SHADOW);
                text_.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,32));
                text_.SetFontBorderWidth(2);
                text_.SetLinePitch(20);
                text_.SetFontSize(28);
                text_.SetFontBold(true);
                SetAlpha(0);
            }

            public new void Work()
            {
                base.Work();
                int alpha = GetAlpha();
                if (text_.GetText().size() == 0)
                {
                    alpha = System.Math.Max(0, alpha - 8);
                }
                else
                {
                    alpha = 255;
                }
                SetAlpha(alpha);
            }

            public new void Render()
            {
                base.Render();
                if (text_.GetText().size() > 0)
                {
                    RenderText();
                }
            }

            public virtual void RenderText()
            {
                int sizeFont = text_.GetFontSize();
                RECT rect = GetAbsoluteWindowRect();
                int width = rect.right - rect.left;
                int height = rect.bottom - rect.top;
                text_.SetMaxWidth(width);
                text_.SetHorizontalAlignment(DxText.ALIGNMENT_CENTER);
                text_.SetPosition(rect.left, rect.top + (height - sizeFont) / 2 - 2);
                text_.Render();
            }

            public string GetText()
            {
                return text_.GetText();
            }
            public void SetText(string text)
            {
                text_.SetText(text);
            }
    }
    public class EventLogWindow : EventWindow
    {
            private int posMin_; // �Œ�\���ʒu
            private int pos_;
            private gstd.ref_count_ptr<DxText> dxText_ = new gstd.ref_count_ptr<DxText>();

            // EventLogWindow
            public EventLogWindow()
            {
                pos_ = 0;
                dxText_ = new DxText();
                dxText_.SetFontType(Font.MINCHOH);
                dxText_.SetFontColorTop(D3DCOLOR_ARGB(255,255,255,255));
                dxText_.SetFontColorBottom(D3DCOLOR_ARGB(255,255,255,255));
                dxText_.SetFontBorderType(directx.DxFont.BORDER_SHADOW);
                dxText_.SetFontBorderColor(D3DCOLOR_ARGB(255,32,32,32));
                dxText_.SetFontBorderWidth(2);
                dxText_.SetLinePitch(20);
                dxText_.SetFontSize(24);
                dxText_.SetFontBold(true);
            }

            public override void AddedManager()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                RECT rect = new RECT(20, 20, graphics.GetScreenWidth() - 20, 580);
                SetWindowRect(new RECT(rect));

                ref_count_ptr<Sprite2D> sprite = new Sprite2D();
                sprite.SetColorRGB(D3DCOLOR_ARGB(255, 64, 64, 64));
                sprite.SetAlpha(192);
                SetFrameSprite(new ref_count_ptr<Sprite2D>(sprite));
            }

            public override void Work()
            {
                if (!IsWindowEnable())
                {
                    return;
                }

                EventEngine engine = _GetManager().GetEngine();
                DirectInput input = DirectInput.GetBase();
                gstd.ref_count_ptr<EventLogText> log = engine.GetEventLogText();
                int count = log.GetInfoCount();

                bool bChange = false;
                int mouseZ = input.GetMouseMoveZ();
                if (mouseZ > 0)
                {
                    pos_ = System.Math.Min(count - 1, pos_ + 1);
                }
                else if (mouseZ < 0)
                {
                    if (pos_ == posMin_ || count == 0)
                    {
                        bChange = true;
                    }
                    else
                    {
                        pos_ = System.Math.Max(posMin_, pos_ - 1);
                    }
                }

                if (input.GetMouseState(DI_MOUSE_RIGHT) == KEY_PULL)
                {
                    bChange = true;
                }

                if (bChange)
                {
                    engine.SetState(EventEngine.STATE_RUN);
                }
            }

            public override void Render()
            {
                _RenderFrame();

                EventEngine engine = _GetManager().GetEngine();
                gstd.ref_count_ptr<EventLogText> log = engine.GetEventLogText();
                if (log.GetInfoCount() == 0)
                {
                    return;
                }

                int countInfo = log.GetInfoCount();
                RECT rect = GetWindowRect();
                int left = rect.left + 16;
                int top = rect.top + 16;
                int maxHeight = rect.bottom - rect.top - 32;

                LinkedList<int> listHeight = new LinkedList<int>();
                LinkedList<gstd.ref_count_ptr<DxTextInfo>> listInfo = new LinkedList<new gstd.ref_count_ptr<DxTextInfo>>();
                int heightTotal = 0;
                for (int iInfo = pos_ ; iInfo >= 0 ; iInfo--)
                {
                    gstd.ref_count_ptr<DxTextInfo> textInfo = log.GetTextInfo(iInfo);

                    int height = 0;
                    int countLine = textInfo.GetLineCount();
                    for (int iLine = 0; iLine < countLine ; iLine++)
                    {
                        gstd.ref_count_ptr<DxTextLine> lineText = textInfo.GetTextLine(iLine);
                        height += lineText.GetHeight() + dxText_.GetLinePitch();
                    }

                    listHeight.AddLast(height);
                    listInfo.AddLast(textInfo);

                    heightTotal += height;
                    if (heightTotal > dxText_.GetMaxHeight())
                    {
                        break;
                    }
                }

                DirectGraphics graphics = DirectGraphics.GetBase();
                graphics.SetViewPort(left, top, rect.right - rect.left, maxHeight);
                LinkedList<int>.Enumerator itrHeight = listHeight.GetEnumerator();
                LinkedList<gstd.ref_count_ptr<DxTextInfo>>.Enumerator itrInfo = listInfo.GetEnumerator();
                for (; itrInfo.MoveNext(); itrInfo++, itrHeight++)
                {
                    gstd.ref_count_ptr<DxTextInfo> textInfo = itrInfo.Current;
                    dxText_.SetPosition(left, top);
                    dxText_.SetMaxHeight(maxHeight);
                    dxText_.Render(textInfo);
// C++ TO C# CONVERTER TODO TASK: Iterators are only converted within the context of 'while' and 'for' loops:
                    top += itrHeight;
                }
                graphics.ResetViewPort();
            }

            public gstd.ref_count_ptr<DxText> GetRenderer()
            {
                return new gstd.ref_count_ptr<DxText>(dxText_);
            }
            public void ResetPosition()
            {
                // 1�y�[�W�ȉ��̂Ƃ��̈ʒu�𒲂ׂ�
                EventEngine engine = _GetManager().GetEngine();
                gstd.ref_count_ptr<EventLogText> log = engine.GetEventLogText();

                RECT rect = GetWindowRect();
                int left = rect.left + 16;
                int top = rect.top + 16;
                dxText_.SetMaxWidth(rect.right - rect.left - 32);

                int countInfo = log.GetInfoCount();
                posMin_ = 0;
                int heightTotal = 0;
                for (int iInfo = 0 ; iInfo < countInfo ; iInfo++)
                {
                    gstd.ref_count_ptr<DxTextInfo> textInfo = log.GetTextInfo(iInfo);

                    int height = 0;
                    int countLine = textInfo.GetLineCount();
                    for (int iLine = 0; iLine < countLine ; iLine++)
                    {
                        gstd.ref_count_ptr<DxTextLine> lineText = textInfo.GetTextLine(iLine);
                        height += lineText.GetHeight() + dxText_.GetLinePitch();
                    }

                    heightTotal += height;
                    if (heightTotal > dxText_.GetMaxHeight())
                    {
                        break;
                    }
                    posMin_++;
                }

                posMin_ = System.Math.Min(posMin_ - 1, countInfo - 1);
                pos_ = posMin_;
            }
    }

    /**********************************************************
    //EventEngine
    **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class EventScriptObjectManager : DxScriptObjectManager, gstd.Recordable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            private enum AnonymousEnum5
            {
                INDEX_FREE_START = 256
            }
            /**********************************************************
            //EventEngine
            **********************************************************/
            // EventScriptObjectManager
            public virtual int AddObject(gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj)
            {
                int res = DxScript.ID_INVALID;
                if (listUnusedIndex_.Count != 0)
                {
                    LinkedList<int>.Enumerator itr = listUnusedIndex_.GetEnumerator();
                    while (itr.MoveNext())
                    {
                        int index = itr.Current;
                        if (index >= (int)AnonymousEnum5.INDEX_FREE_START)
                        {
                            res = index;
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                            listUnusedIndex_.erase(itr);
                            break;
                        }
                    }

                    obj_[res].CopyFrom(obj);
                    obj.SetActive(true);
                    listActiveObject_.AddLast(obj);
                    _SetObjectID(obj.GetPointer(), res);
                }
                return res;
            }

            public override void Read(gstd.RecordBuffer record)
            {
                if (!record.IsExists("count"))
                {
                    return;
                }

                // �L����ID��
                int countObj = record.GetRecordAsInteger("count");
                List<int> listValidId = new List<int>();
                listValidId.Resize(countObj);
                record.GetRecord("ids", listValidId[0], listValidId.Count * sizeof(int));

                // �I�u�W�F�N�g
                for (int iObj = 0 ; iObj < listValidId.Count ; iObj++)
                {
                    DxScriptSpriteObject2D obj = new DxScriptSpriteObject2D();
                    Sprite2D sprite = obj.GetSpritePointer();

                    RecordBuffer recObj = new RecordBuffer();
                    record.GetRecordAsRecordBuffer(StringUtility.Format("vertex%d", iObj), recObj);

                    int pri = recObj.GetRecordAsDouble("pri");
                    string pathTexture = recObj.GetRecordAsStringW("texture");
                    pathTexture = PathProperty.GetModuleDirectory() + pathTexture;
                    ref_count_ptr<Texture> texture = new Texture();
                    texture.CreateFromFile(pathTexture);
                    sprite.SetTexture(texture);

                    int countVertex = recObj.GetRecordAsInteger("countVertex");
                    D3DXVECTOR3 pos = new D3DXVECTOR3();
                    D3DXVECTOR3 angle = new D3DXVECTOR3();
                    D3DXVECTOR3 scale = new D3DXVECTOR3();
                    sprite.SetVertexCount(countVertex);
                    VERTEX_TLX pVertex = sprite.GetVertex(0);
                    recObj.GetRecord("vertex", pVertex, countVertex * sizeof(VERTEX_TLX));
                    recObj.GetRecord("pos", pos, sizeof(D3DXVECTOR3));
                    recObj.GetRecord("angle", angle, sizeof(D3DXVECTOR3));
                    recObj.GetRecord("scale", scale, sizeof(D3DXVECTOR3));
                    obj.SetPosition(new D3DXVECTOR3(pos));
                    obj.SetAngle(new D3DXVECTOR3(angle));
                    obj.SetScale(new D3DXVECTOR3(scale));
                    int index = listValidId[iObj];
                    obj_[index] = obj;
                }
            }

            public override void Write(gstd.RecordBuffer record)
            {
                int iObj = 0;
                List<int> listValidId = new List<int>();
                for (iObj = 0 ; iObj < EventImage.INDEX_OLD_START ; iObj++)
                {
                    gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj = obj_[iObj];
                    if (obj == null)
                    {
                        continue;
                    }

                    listValidId.Add(iObj);
                }
                if (listValidId.Count == 0)
                {
                    return;
                }

                // �L����ID��
                record.SetRecordAsInteger("count", listValidId.Count);
                record.SetRecord("ids", listValidId[0], listValidId.Count * sizeof(int));

                // �I�u�W�F�N�g
                for (iObj = 0 ; iObj < listValidId.Count ; iObj++)
                {
                    int index = listValidId[iObj];
                    gstd.ref_count_ptr<DxScriptSpriteObject2D>.unsync obj = new gstd.ref_count_ptr<DxScriptSpriteObject2D>.unsync(obj_[index]);
                    Sprite2D sprite = obj.GetSpritePointer();

                    RecordBuffer recObj = new RecordBuffer();
                    recObj.SetRecordAsDouble("pri", obj.GetRenderPriority());
                    gstd.ref_count_ptr<Texture> texture = sprite.GetTexture();
                    string pathTexture = texture.GetName();
                    pathTexture = PathProperty.GetPathWithoutModuleDirectory(pathTexture);
                    recObj.SetRecordAsStringW("texture", pathTexture);

                    int countVertex = sprite.GetVertexCount();
                    D3DXVECTOR3 pos = obj.GetPosition();
                    D3DXVECTOR3 angle = obj.GetAngle();
                    D3DXVECTOR3 scale = obj.GetScale();
                    recObj.SetRecordAsInteger("countVertex", countVertex);
                    VERTEX_TLX pVertex = sprite.GetVertex(0);
                    recObj.SetRecord("vertex", pVertex, countVertex * sizeof(VERTEX_TLX));
                    recObj.SetRecord("pos", pos, sizeof(D3DXVECTOR3));
                    recObj.SetRecord("angle", angle, sizeof(D3DXVECTOR3));
                    recObj.SetRecord("scale", scale, sizeof(D3DXVECTOR3));
                    record.SetRecordAsRecordBuffer(StringUtility.Format("vertex%d", iObj), recObj);
                }

            }
    }
    public class EventText : DxTextStepper
    {

            // EventText
            public bool IsVoiceText()
            {
                bool res = false;
                if (text_.Length >= 2)
                {
                    string str = text_.Substring(0, 2);
                    res = str.IndexOf("�u") != -1;
                }
                return res;
            }
    }
    public class EventLogText : System.IDisposable
    {
            private EventEngine engine_;
            private int max_;
            private List<gstd.ref_count_ptr<DxTextInfo>> listInfo_ = new List<gstd.ref_count_ptr<DxTextInfo>>();

            // EventLogText
            public EventLogText(EventEngine engine)
            {
                max_ = 100;
                engine_ = engine;
            }

            public virtual void Dispose()
            {
            }

            public void Add(string text, string name)
            {
                text += EventScriptScanner.TAG_START + EventScriptScanner.TAG_NEW_LINE + EventScriptScanner.TAG_END + "--------------------------------";
                EventLogWindow wnd = engine_.GetWindowManager().GetLogWindow().GetPointer();
            // 	RECT rect = wnd->GetWindowRect();
                ref_count_ptr<DxText> renderer = wnd.GetRenderer();

                DxText dxText = new DxText();
                dxText.Copy(renderer.GetPointer());
            /*
            	dxText.SetFont(renderer->GetFont());
            //	dxText.SetFontBorderType(directx::DxFont::BORDER_FULL);
            //	dxText.SetFontBorderWidth(2);
            	dxText.SetLinePitch(renderer->GetLinePitch());
            	dxText.SetFontSize(renderer->GetFontSize());
            	dxText.SetFontBold(false);
            	dxText.SetPosition(renderer->GetPosition());
            	dxText.SetMaxWidth(renderer->GetMaxWidth());
            */
                dxText.SetMaxHeight(int.MaxValue);

                string wText = StringUtility.ConvertMultiToWide(text);
                dxText.SetText(wText);

                gstd.ref_count_ptr<DxTextInfo> info = dxText.GetTextInfo();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL vector 'insert' method in C#:
                listInfo_.insert(listInfo_.GetEnumerator(), info);

                if (listInfo_.Count >= max_)
                {
                    listInfo_.RemoveAt(listInfo_.Count - 1);
                }
            }

            public int GetInfoCount()
            {
                return listInfo_.Count;
            }
            public gstd.ref_count_ptr<DxTextInfo> GetTextInfo(int pos)
            {
                return new gstd.ref_count_ptr<DxTextInfo>(listInfo_[pos]);
            }
    }
    public class EventValue : gstd.Recordable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend EventValueParser;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum6
            {
                TYPE_UNKNOWN,
                TYPE_REAL,
                TYPE_BOOLEAN,
                TYPE_STRING
            }

            protected int type_;
            protected string valueString_ = "";
// C++ TO C# CONVERTER TODO TASK: Unions are not supported in C#:
//            union
//            {
//                double valueReal_;
//                bool valueBoolean_;
//            };
            public EventValue()
            {
                type_ = (int)AnonymousEnum6.TYPE_UNKNOWN;
            }
            public override void Dispose()
            {
                base.Dispose();
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
                    res = atof(valueString_);
                }
                return res;
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
            public bool IsReal()
            {
                return type_ == (int)AnonymousEnum6.TYPE_REAL;
            }
            public bool IsBoolean()
            {
                return type_ == (int)AnonymousEnum6.TYPE_BOOLEAN;
            }
            public bool IsString()
            {
                return type_ == (int)AnonymousEnum6.TYPE_STRING;
            }

            public void SetReal(double v)
            {
                type_ = (int)AnonymousEnum6.TYPE_REAL;
                valueReal_ = v;
            }
            public void SetBoolean(bool v)
            {
                type_ = (int)AnonymousEnum6.TYPE_BOOLEAN;
                valueBoolean_ = v;
            }
            public void SetString(string str)
            {
                type_ = (int)AnonymousEnum6.TYPE_STRING;
                valueString_ = str;
            }


            // EventValue
            public gstd.TextParser.Result ConvertToTextParserResult()
            {
                TextParser.Result res = new TextParser.Result();
                if (IsReal())
                {
                    res.SetReal(GetReal());
                }
                else if (IsBoolean())
                {
                    res.SetBoolean(GetBoolean());
                }
                else if (IsString())
                {
                    string wstr = StringUtility.ConvertMultiToWide(GetString());
                    res.SetString(wstr);
                }
                return new TextParser.Result(res);
            }

            public void Copy(gstd.TextParser.Result val)
            {
                if (val.IsReal())
                {
                    type_ = EventValue.TYPE_REAL;
                    valueReal_ = val.GetReal();
                }
                else if (val.IsBoolean())
                {
                    type_ = EventValue.TYPE_BOOLEAN;
                    valueBoolean_ = val.GetBoolean();
                }
                else if (val.IsString())
                {
                    type_ = EventValue.TYPE_STRING;
                    string str = StringUtility.ConvertWideToMulti(val.GetString());
                    valueString_ = str;
                }
            }

            public void Copy(EventValue val)
            {
                this = val;
            }

            public override void Read(gstd.RecordBuffer record)
            {
                type_ = record.GetRecordAsInteger("type");
                if (type_ == (int)AnonymousEnum6.TYPE_STRING)
                {
                    string str = record.GetRecordAsStringA("strValue");
                    string home = PathProperty.GetModuleDirectory();
                    string sHome = StringUtility.ConvertWideToMulti(home);
                    str = StringUtility.ReplaceAll(str, ".\\", sHome);
                    valueString_ = str;
                }
                else
                {
                    valueReal_ = record.GetRecordAsDouble("value");
                }
            }

            public override void Write(gstd.RecordBuffer record)
            {
                record.SetRecordAsInteger("type", type_);
                if (type_ == (int)AnonymousEnum6.TYPE_STRING)
                {
                    string str = valueString_;
                    string home = PathProperty.GetModuleDirectory();
                    string sHome = StringUtility.ConvertWideToMulti(home);
                    str = StringUtility.ReplaceAll(str, sHome, ".\\");

                    record.SetRecordAsStringA("strValue", str);
                }
                else
                {
                    record.SetRecordAsDouble("value", valueReal_);
                }
            }
    }
    public class EventFrame : System.IDisposable
    {
            protected bool bEnd_;
            protected int posCode_;
            protected int posReturn_;
            protected bool bAutoGlobal_;
            protected gstd.ref_count_ptr<EventScriptSource> sourceActive_ = new gstd.ref_count_ptr<EventScriptSource>();
            protected gstd.ref_count_ptr<EventScriptBlock> block_ = new gstd.ref_count_ptr<EventScriptBlock>();
            protected SortedDictionary<string, gstd.ref_count_ptr<EventValue>> mapValue_ = new SortedDictionary<string, gstd.ref_count_ptr<EventValue>>();

            // EventFrame
            public EventFrame()
            {
                posCode_ = 0;
                bEnd_ = false;
                bAutoGlobal_ = false;
            }

            public virtual void Dispose()
            {
            }

            public void SetActiveSource(gstd.ref_count_ptr<EventScriptSource> source)
            {
                sourceActive_.CopyFrom(source);
            }
            public gstd.ref_count_ptr<EventScriptBlock> GetBlock()
            {
                return new gstd.ref_count_ptr<EventScriptBlock>(block_);
            }
            public void SetBlock(gstd.ref_count_ptr<EventScriptBlock> block)
            {
                block_.CopyFrom(block);
                posCode_ = block.GetStartPosition();
                if (block.GetReturnPosition() > 0)
                {
                    posReturn_ = block.GetReturnPosition();
                }
            }

            public gstd.ref_count_ptr<EventScriptSource> GetActiveSource()
            {
                return new gstd.ref_count_ptr<EventScriptSource>(sourceActive_);
            }

            public int GetCurrentPosition()
            {
                return posCode_;
            }
            public void SetCurrentPosition(int pos)
            {
                posCode_ = pos;
            }
            public gstd.ref_count_ptr<EventScriptCode> NextCode()
            {
                posCode_++;
                return new gstd.ref_count_ptr<EventScriptCode>(GetCurrentCode());
            }

            public gstd.ref_count_ptr<EventScriptCode> GetCurrentCode()
            {
                return sourceActive_.GetCode(posCode_);
            }

            public bool HasNextCode()
            {
                bool res = false;
                if (block_ != null)
                {
                    res = posCode_ < block_.GetEndPosition();
                }
                else
                {
                    int count = sourceActive_.GetCodeCount();
                    res = posCode_ < count - 1;
                }
                return res;
            }

            public void SetEnd()
            {
                bEnd_ = true;
            }
            public bool IsEnd()
            {
                return bEnd_;
            }
            public gstd.ref_count_ptr<EventValue> GetValue(string key)
            {
                if (!mapValue_.ContainsKey(key))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<EventValue>(mapValue_[key]);
            }

            public void AddValue(string key, gstd.ref_count_ptr<EventValue> val)
            {
            // 	if(mapValue_.find(key) != mapValue_.end())return NULL;
                mapValue_[key].CopyFrom(val);
            }

            public void SetValue(string key, gstd.ref_count_ptr<EventValue> val)
            {
                mapValue_[key].CopyFrom(val);
            }

            public int GetReturnPosition()
            {
                return posReturn_;
            }
            public void SetReturnPosition(int pos)
            {
                posReturn_ = pos;
            }
            public bool IsInnerBlock()
            {
                bool res = false;
                if (block_ != null)
                {
                    res = block_.IsInner();
                }
                return res;
            }

            public bool IsAutoGlobal()
            {
                return bAutoGlobal_;
            }
            public void SetAutoGlobal(bool bAuto)
            {
                bAutoGlobal_ = bAuto;
            }

            // �ۑ�
            public void ReadRecord(gstd.RecordBuffer record, EventEngine engine)
            {
                // �ʒu
                posCode_ = record.GetRecordAsInteger("posCode_");
                posReturn_ = record.GetRecordAsInteger("posReturn_");

                // �\�[�X
                string pathSource = record.GetRecordAsStringW("pathSource");
                pathSource = PathProperty.GetModuleDirectory() + pathSource;
                sourceActive_.CopyFrom(engine.GetSource(pathSource));

                // �u���b�N�̈ʒu
                if (record.IsExists("BlockIndex"))
                {
                    // if
                    int pos = record.GetRecordAsInteger("BlockIndex");
                    block_ = ref_count_ptr<EventScriptBlock>.DownCast(sourceActive_.GetCode(pos));
                }
                else if (record.IsExists("BlockName"))
                {
                    string name = record.GetRecordAsStringA("BlockName");
                    block_ = sourceActive_.GetEventBlock(name);
                }
                else
                {
                    throw new gstd.wexception("�u���b�N���Ȃ�?");
                }

                // �ϐ�
                int countValue = record.GetRecordAsInteger("countValue");
                for (int iValue = 0 ; iValue < countValue ; iValue++)
                {
                    string keyName = StringUtility.Format("valueName%d", iValue);
                    string keyValue = StringUtility.Format("value%d", iValue);

                    string name = record.GetRecordAsStringA(keyName);
                    RecordBuffer rcValue = new RecordBuffer();
                    record.GetRecordAsRecordBuffer(keyValue, rcValue);
                    EventValue value = new EventValue();
                    value.Read(rcValue);
                    mapValue_[name] = value;
                }

            }

            public void WriteRecord(gstd.RecordBuffer record, EventEngine engine)
            {
                // �ʒu
                record.SetRecordAsInteger("posCode_", posCode_);
                record.SetRecordAsInteger("posReturn_", posReturn_);

                // �\�[�X
                string wPathSource = engine.GetSourcePath(new gstd.ref_count_ptr<EventScriptSource>(sourceActive_));
                wPathSource = PathProperty.GetPathWithoutModuleDirectory(wPathSource);

                record.SetRecordAsStringW("pathSource", wPathSource);

                // �u���b�N�̈ʒu��L�^
                if (gstd.ref_count_ptr<EventScriptCode_If>.DownCast(block_) != null)
                {
                    // if�̏ꍇ�̓R�[�h�̈ʒu
                    int index = -1;
                    int codeCount = sourceActive_.GetCodeCount();
                    for (int iCode = 0 ; iCode < codeCount ; iCode++)
                    {
                        object pCode = sourceActive_.GetCode(iCode).GetPointer();
                        object pBlock = block_.GetPointer();
                        if (pCode == pBlock)
                        {
                            index = iCode;
                            break;
                        }
                    }

                    if (index < 0)
                    {
                        throw new gstd.wexception("if�u���b�N���s���ŕۑ��ł��܂���");
                    }

                    record.SetRecordAsInteger("BlockIndex", index);
                }
                else if (gstd.ref_count_ptr<EventScriptBlock_Main>.DownCast(block_) != null)
                {
                    // ���̑��̓u���b�N����
                    gstd.ref_count_ptr<EventScriptBlock_Main> mainBlock = new gstd.ref_count_ptr<EventScriptBlock_Main>(block_);
                    string name = mainBlock.GetName();
                    record.SetRecordAsStringA("BlockName", name);
                }
                else
                {
                    throw new gstd.wexception("�ۑ��ł��Ȃ��u���b�N?");
                }

                // �ϐ�
                int iCountValue = 0;
                int countValue = mapValue_.Count;
                record.SetRecordAsInteger("countValue", countValue);
                SortedDictionary<string, gstd.ref_count_ptr<EventValue>>.Enumerator itrValue;
                for (itrValue = mapValue_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string name = itrValue.Current.Key;
                    gstd.ref_count_ptr<EventValue> value = itrValue.Current.Value;
                    record.SetRecordAsStringA(StringUtility.Format("valueName%d", iCountValue), name);

                    RecordBuffer rcValue = new RecordBuffer();
                    value.Write(rcValue);
                    record.SetRecordAsRecordBuffer(StringUtility.Format("value%d", iCountValue), rcValue);

                    iCountValue++;
                }
            }
    }

    public class EventValueParser : gstd.TextParser
    {
            protected EventEngine engine_;
            protected virtual gstd.TextParser.Result _ParseIdentifer(List<char>.Enumerator pos)
            {
                Result res = new Result();
                Token tok = scan_.GetToken();
                string id = tok.GetElement();
                if (id == "true")
                {
                    res.SetBoolean(true);
                }
                else if (id == "false")
                {
                    res.SetBoolean(false);
                }
                else if (id == "FormatReal")
                {
                    try
                    {
                        List<string> args = _GetFuctionArgument();
                        EventValueParser parser = new EventValueParser(engine_);
                        ref_count_ptr<EventValue> val1 = parser.GetEventValue(new List<string>(args[0]));
                        ref_count_ptr<EventValue> val2 = parser.GetEventValue(new List<string>(args[1]));
                        string str = StringUtility.Format((string)val1.GetString().c_str(), val2.GetReal());

                        string wstr = StringUtility.ConvertMultiToWide(str);
                        res.SetString(wstr);
                    }
                    catch
                    {
                        _RaiseError("FormatReal");
                    }
                }
                else if (id == "GetHomeDirectory")
                {
                    List<string> args = _GetFuctionArgument();
                    string dirModule = PathProperty.GetModuleDirectory();
                    res.SetString(dirModule);
                }
                else
                {
                    string sId = StringUtility.ConvertWideToMulti(id);
                    ref_count_ptr<EventValue> val = engine_.GetEventValue(sId);
                    if (val != null)
                    {
                        res = val.ConvertToTextParserResult();
                    }
                }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return res;
                return new gstd.TextParser.Result(res);
            }

            protected List<string> _GetFuctionArgument()
            {
                List<string> res = new List<string>();
                string arg = "";
                scan_.CheckType(scan_.Next(), Token.TK_OPENP);
                while (true)
                {
                    Token tok = scan_.Next();
                    if (tok.GetType() == Token.TK_CLOSEP)
                    {
                        if (arg.Length != 0)
                        {
                            res.Add(arg);
                        }
                        break;
                    }
                    if (tok.GetType() == Token.TK_COMMA)
                    {
                        res.Add(arg);
                        arg = "";
                    }
                    else
                    {
                        string wstr = tok.GetElement();
                        string str = StringUtility.ConvertWideToMulti(wstr);
                        arg += str;
                    }
                }
                return new List<string>(res);
            }


            // EventValueParser
            public EventValueParser(EventEngine engine)
            {
                engine_ = engine;
            }

            public gstd.ref_count_ptr<EventValue> GetEventValue(string text)
            {
                SetSource(text);
                gstd.ref_count_ptr<EventValue> res = new EventValue();
                if (text.Length == 0)
                {
                    return new gstd.ref_count_ptr<EventValue>(res);
                }

                TextParser.Result value = GetResult();
                res.Copy(value);
                return new gstd.ref_count_ptr<EventValue>(res);
            }
    }

    public class EventImage : gstd.Recordable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum7
            {
                LAYER_FOREGROUND,
                LAYER_BACKGROUND,
                MAX_OBJECT = 256 * 4,
                INDEX_OLD_START = 100,
                ID_TRANSITION = 255
            }
            protected List<gstd.ref_count_ptr<EventScriptObjectManager>> objManager_ = new List<gstd.ref_count_ptr<EventScriptObjectManager>>();
            protected int indexForeground_;

            // EventImage
            public EventImage()
            {
                objManager_.Resize(2);
                for (int iManager = 0 ; iManager < objManager_.Count ; iManager++)
                {
                    EventScriptObjectManager manager = new EventScriptObjectManager();
                    manager.SetMaxObject(AnonymousEnum7.MAX_OBJECT);
                    objManager_[iManager] = manager;
                }
                indexForeground_ = 0;
            }

            public override void Dispose()
            {
                base.Dispose();
            }

            public void Render(int layer)
            {
                objManager_[layer].RenderObject();
            }

            public int GetForegroundLayerIndex()
            {
                return indexForeground_;
            }

            public int GetBackgroundLayerIndex()
            {
                return 1 - indexForeground_;
            }

            public void SwapForeBackLayerIndex()
            {
                indexForeground_ = 1 - indexForeground_;
            }

            public gstd.ref_count_ptr<DxScriptObjectManager> GetObjectManager(int layer)
            {
                return new gstd.ref_count_ptr<EventScriptObjectManager>(objManager_[layer]);
            }

            public override void Read(gstd.RecordBuffer record)
            {
                // �O�i�C���f�b�N�X
                indexForeground_ = record.GetRecordAsInteger("fore");

                // �I�u�W�F�N�g�Ǘ�
                for (int iManager = 0 ; iManager < objManager_.Count ; iManager++)
                {
                    RecordBuffer recManager = new RecordBuffer();
                    record.GetRecordAsRecordBuffer(StringUtility.Format("manager%d", iManager), recManager);
                    objManager_[iManager].Read(recManager);
                }
            }

            public override void Write(gstd.RecordBuffer record)
            {
                // �O�i�C���f�b�N�X
                record.SetRecordAsInteger("fore", indexForeground_);

                // �I�u�W�F�N�g�Ǘ�
                for (int iManager = 0 ; iManager < objManager_.Count ; iManager++)
                {
                    RecordBuffer recManager = new RecordBuffer();
                    objManager_[iManager].Write(recManager);

                    record.SetRecordAsRecordBuffer(StringUtility.Format("manager%d", iManager), recManager);
                }
            }
    }

    public class EventKeyState : System.IDisposable
    {
            protected EventEngine engine_;
            protected bool bNextEnable_;

            // EventKeyState
            public EventKeyState(EventEngine engine)
            {
                engine_ = engine;
                bNextEnable_ = true;
            }

            public virtual void Dispose()
            {
            }

            public void Work()
            {
                bNextEnable_ = true;
            }

            public void SetNextEnable(bool bEnable)
            {
                bNextEnable_ = bEnable;
            }
            public bool IsNext()
            {
                if (!bNextEnable_)
                {
                    return false;
                }

                bool res = false;
                DirectInput input = DirectInput.GetBase();

                gstd.ref_count_ptr<EventWindowManager> mngWindow = engine_.GetWindowManager();
                gstd.ref_count_ptr<DxWindowEvent> wndEvent = mngWindow.GetMouseCaptureLayer().GetEvent();

                res |= (wndEvent != null && wndEvent.HasEventType(DxWindowEvent.TYPE_MOUSE_LEFT_CLICK));
                res |= (input.GetKeyState(DIK_Z) == KEY_PUSH);
                res |= (input.GetKeyState(DIK_RETURN) == KEY_PUSH);
                res |= (input.GetMouseMoveZ() < 0);

                return res;
            }

            public bool IsSkip()
            {
                bool res = false;
                DirectInput input = DirectInput.GetBase();
                res |= (input.GetKeyState(DIK_LCONTROL) == KEY_HOLD);
                return res;
            }
    }

    public class EventSound : gstd.Recordable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum8
            {
                TYPE_BGM,
                TYPE_SE
            }
            private gstd.ref_count_ptr<SoundPlayer> playerBgm_ = new gstd.ref_count_ptr<SoundPlayer>();
            private gstd.ref_count_ptr<SoundPlayer> playerSe_ = new gstd.ref_count_ptr<SoundPlayer>();

            // EventSound
            public EventSound()
            {
            }

            public override void Dispose()
            {
                if (playerBgm_ != null)
                {
                    playerBgm_.Delete();
                }
                if (playerSe_ != null)
                {
                    playerSe_.Delete();
                }
                base.Dispose();
            }

            public void Play(int type, string path)
            {
                DirectSoundManager manager = DirectSoundManager.GetBase();
                gstd.ref_count_ptr<SoundPlayer> player = type == (int)AnonymousEnum8.TYPE_BGM ? playerBgm_ : playerSe_;
                if (player != null)
                {
                    if (type == (int)AnonymousEnum8.TYPE_BGM)
                    {
                        player.SetFadeDelete(-10);
                        playerBgm_ = null;
                    }
                    else
                    {
                        player.Stop();
                        player.Delete();
                        playerSe_ = null;
                    }
                }

                string wPath = StringUtility.ConvertMultiToWide(path);
                player.CopyFrom(manager.GetPlayer(wPath));
                if (player != null)
                {
                    bool bLoop = type == (int)AnonymousEnum8.TYPE_BGM;
                    SoundPlayer.PlayStyle style = new SoundPlayer.PlayStyle();
                    style.SetLoopEnable(bLoop);
                    player.Play(style);
                    if (type == (int)AnonymousEnum8.TYPE_BGM)
                    {
                        playerBgm_.CopyFrom(player);
                    }
                    else
                    {
                        playerSe_.CopyFrom(player);
                    }
                }
            }

            public void Delete(int type)
            {
                gstd.ref_count_ptr<SoundPlayer> player = type == (int)AnonymousEnum8.TYPE_BGM ? playerBgm_ : playerSe_;
                if (player != null)
                {
                    if (type == (int)AnonymousEnum8.TYPE_BGM)
                    {
                        player.SetFadeDelete(-20);
                        playerBgm_ = null;
                    }
                    else
                    {
                        player.Stop();
                        player.Delete();
                        playerSe_ = null;
                    }
                }
            }

            public override void Read(gstd.RecordBuffer record)
            {
                if (!record.IsExists("path"))
                {
                    return;
                }
                string path = record.GetRecordAsStringA("path");
                string dirModule = StringUtility.ConvertWideToMulti(PathProperty.GetModuleDirectory());
                path = dirModule + path;
                Play((int)AnonymousEnum8.TYPE_BGM, path);
            }

            public override void Write(gstd.RecordBuffer record)
            {
                if (playerBgm_ == null)
                {
                    return;
                }
                string path = playerBgm_.GetPath();
                path = PathProperty.GetPathWithoutModuleDirectory(path);

                string sPath = StringUtility.ConvertWideToMulti(path);
                record.SetRecordAsStringA("path", sPath);
            }
    }

// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class EventEngine : gstd.TaskBase, gstd.Recordable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum9
            {
                STATE_RUN,
                STATE_LOG,
                STATE_HIDE_TEXT,
                STATE_STOP
            }

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum10
            {
                RUN_RETURN_NONE,
                RUN_RETURN_DO
            }

            protected int state_;
            protected gstd.ref_count_ptr<EventWindowManager> windowManager_ = new gstd.ref_count_ptr<EventWindowManager>();
            protected gstd.ref_count_ptr<EventText> textEvent_ = new gstd.ref_count_ptr<EventText>();
            protected gstd.ref_count_ptr<EventLogText> logEvent_ = new gstd.ref_count_ptr<EventLogText>();
            protected SortedDictionary<string, gstd.ref_count_ptr<EventScriptSource>> mapSource_ = new SortedDictionary<string, gstd.ref_count_ptr<EventScriptSource>>();
            protected List<gstd.ref_count_ptr<EventFrame>> frame_ = new List<gstd.ref_count_ptr<EventFrame>>();
            protected gstd.ref_count_ptr<EventImage> image_ = new gstd.ref_count_ptr<EventImage>();
            protected gstd.ref_count_ptr<EventKeyState> keyState_ = new gstd.ref_count_ptr<EventKeyState>();
            protected gstd.ref_count_ptr<EventSound> sound_ = new gstd.ref_count_ptr<EventSound>();
            protected bool bCriticalFrame_;
            protected gstd.ref_count_ptr<EventFrame> frameGlobal_ = new gstd.ref_count_ptr<EventFrame>(); // �O���[�o���ϐ��p

            protected gstd.ref_count_ptr<EventScriptCodeExecuter> activeCodeExecuter_ = new gstd.ref_count_ptr<EventScriptCodeExecuter>();
            protected LinkedList<gstd.ref_count_ptr<EventScriptCodeExecuter>> parallelCodeExecuter_ = new LinkedList<gstd.ref_count_ptr<EventScriptCodeExecuter>>();
            protected LinkedList<gstd.ref_count_ptr<DxScriptForEvent>> listScript_ = new LinkedList<gstd.ref_count_ptr<DxScriptForEvent>>();
            protected gstd.ref_count_ptr<gstd.ScriptEngineCache> cacheScriptEngine_ = new gstd.ref_count_ptr<gstd.ScriptEngineCache>();

            protected void _RaiseError(string msg)
            {
                ref_count_ptr<EventFrame> frame = *frame_.rbegin();
                if (frame != null)
                {
                    gstd.ref_count_ptr<EventScriptCode> code = frame.GetCurrentCode();
                    string path = GetSourcePath(frame.GetActiveSource());
                    if (code != null)
                    {
                        msg += StringUtility.Format("line[%d] path[%s]", code.GetLine(), path);
                    }
                }
                throw new gstd.wexception(msg);
            }

            protected virtual void _RunCode()
            {
                if (frame_.Count == 0)
                {
                    return;
                }

                bCriticalFrame_ = false;
                _WorkWindow();
                keyState_.Work();

                while (true)
                {
                    if (activeCodeExecuter_ != null)
                    {
                        activeCodeExecuter_.Execute();
                        LinkedList<gstd.ref_count_ptr<EventScriptCodeExecuter>>.Enumerator itr;
                        for (itr = parallelCodeExecuter_.GetEnumerator(); itr.MoveNext();)
                        {
                            itr.Current.Execute();
                            if (itr.Current.IsEnd())
                            {
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                                itr = parallelCodeExecuter_.erase(itr);
                            }
                            else
                            {
                            }
                        }

                        bool bEndCode = activeCodeExecuter_.IsEnd() && parallelCodeExecuter_.Count == 0;
                        if (bEndCode)
                        {
                            activeCodeExecuter_ = null;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (textEvent_.HasNext())
                    {
                        // �\�����e�L�X�g���c���Ă���ꍇ
                        bool bNext = keyState_.IsNext();
                        bool bSkip = keyState_.IsSkip();
                        if (!bNext && !bSkip)
                        {
                            textEvent_.Next();
                        }
                        else if (bNext || bSkip)
                        {
                            textEvent_.NextSkip();
                        }
                        break;
                    }
                    else
                    {
                        keyState_.SetNextEnable(false);
                        windowManager_.GetMouseCaptureLayer().ClearEvent();

                        // �e�L�X�g���c���Ă��Ȃ��ꍇ�A���̃R�[�h��ǂݍ���
                        ref_count_ptr<EventFrame> frameActive = *frame_.rbegin();
                        while (frameActive.IsEnd())
                        {
                            // �t���[���I��
                            int next = frameActive.GetReturnPosition();
                            frame_.RemoveAt(frame_.Count - 1);
                            if (frame_.Count == 0)
                            {
                                return;
                            }
                            // if(frameActive->GetBlock()->IsGlobal())return;
                            if (frameActive.IsAutoGlobal())
                            {
                                return; // �����O���[�o�������̏ꍇ�͔�����
                            }
                            frameActive = *frame_.rbegin();
                            if (next == EventScriptBlock.POS_NULL)
                            {
                                // �Ԃ�ʒu���w�肳��Ė����ꍇ�A
                                // ���̎��̃R�[�h����p������
                                next = frameActive.GetCurrentPosition() + 1;
                            }
                            frameActive.SetCurrentPosition(next);
                            if (!frameActive.HasNextCode())
                            {
                                frameActive.SetEnd();
                            }
                        }

                        gstd.ref_count_ptr<EventScriptCode> code = frameActive.GetCurrentCode();
                        int typeCode = code.GetType();
                        if (typeCode == EventScriptCode.TYPE_TEXT)
                        {
                            EventScriptCode_Text codeText = (EventScriptCode_Text)code.GetPointer();

                            string wText = StringUtility.ConvertMultiToWide(codeText.GetText());
                            textEvent_.SetSource(wText);
                        }
                        else if (typeCode == EventScriptCode.TYPE_WAIT_CLICK)
                        {
                            activeCodeExecuter_ = new EventScriptCodeExecuter_WaitClick(this);
                        }
                        else if (typeCode == EventScriptCode.TYPE_WAIT_NEXT_PAGE)
                        {
                            activeCodeExecuter_ = new EventScriptCodeExecuter_WaitNextPage(this);
                        }
                        else if (typeCode == EventScriptCode.TYPE_WAIT_TIME)
                        {
                            EventScriptCode_WaitTime codeWaitTime = (EventScriptCode_WaitTime)code.GetPointer();
                            activeCodeExecuter_ = new EventScriptCodeExecuter_WaitTime(this, codeWaitTime);
                        }
                        else if (typeCode == EventScriptCode.TYPE_CLEAR_MESSAGE)
                        {
                            string text = StringUtility.ConvertWideToMulti(textEvent_.GetText());
                            logEvent_.Add(text, "");
                            textEvent_.Clear();
                        }
                        else if (typeCode == EventScriptCode.TYPE_NAME)
                        {
                            EventScriptCode_Name codeName = (EventScriptCode_Name)code.GetPointer();
                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeName.GetName());
                            string name = val.GetString();
                            string wName = StringUtility.ConvertMultiToWide(name);

                            gstd.ref_count_ptr<EventNameWindow> wndName = windowManager_.GetNameWindow();
                            if (wndName != null)
                            {
                                wndName.SetText(wName);
                            }
                        }
                        else if (typeCode == EventScriptCode.TYPE_TRANSITION)
                        {
                            EventScriptCode_Transition codeTrans = (EventScriptCode_Transition)code.GetPointer();
                            EventScriptCodeExecuter_Transition executer = new EventScriptCodeExecuter_Transition(this, codeTrans);
                            activeCodeExecuter_ = executer;
                        }
                        else if (typeCode == EventScriptCode.TYPE_VISIBLE_TEXT)
                        {
                            EventScriptCode_VisibleText codeVisibleText = (EventScriptCode_VisibleText)code.GetPointer();
                            bool bVisible = codeVisibleText.IsVisible();
                            windowManager_.SetTextVisible(bVisible);
                        }
                        else if (typeCode == EventScriptCode.TYPE_VAR)
                        {
                            EventScriptCode_Var codeVar = (EventScriptCode_Var)code.GetPointer();
                            string name = codeVar.GetName();
                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeVar.GetValue());
                            if (frameActive.GetBlock().IsGlobal())
                            {
                                frameGlobal_.AddValue(name, val);
                            }
                            else
                            {
                                frameActive.AddValue(name, val);
                            }
                        }
                        else if (typeCode == EventScriptCode.TYPE_EVAL)
                        {
                            EventScriptCode_Eval codeEval = (EventScriptCode_Eval)code.GetPointer();
                            string name = codeEval.GetName();
                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeEval.GetValue());
                            ref_count_ptr<EventValue> dest = frameActive.GetValue(name);
                            dest.Copy(*val.GetPointer());
                            if ((*frame_.GetEnumerator()).GetBlock().IsGlobal())
                            {
                                frameGlobal_.SetValue(name, val);
                            }
                            else
                            {
                                frameActive.SetValue(name, dest);
                            }
                        }
                        else if (typeCode == EventScriptCode.TYPE_SYSVAL)
                        {
                            EventScriptCode_SysVal codeSysVal = (EventScriptCode_SysVal)code.GetPointer();
                            string name = codeSysVal.GetName();
                            bool bGlobal = codeSysVal.IsGlobal();
                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeSysVal.GetValue());

                            string syskey = bGlobal ? SystemValueManager.RECORD_SYSTEM_GLOBAL : SystemValueManager.RECORD_SYSTEM;
                            SystemValueManager svm = SystemValueManager.GetBase();
                            ref_count_ptr<RecordBuffer> record = svm.GetRecordBuffer(syskey);

                            int typeVal = val.GetType();
                            switch (typeVal)
                            {
                                case EventValue.TYPE_BOOLEAN:
                                    record.SetRecordAsBoolean(name, val.GetBoolean());
                                    break;
                                case EventValue.TYPE_REAL:
                                    record.SetRecordAsDouble(name, val.GetReal());
                                    break;
                                case EventValue.TYPE_STRING:
                                    record.SetRecordAsStringA(name, val.GetString());
                                    break;
                            }

                        }
                        else if (typeCode == EventScriptCode.TYPE_OUTPUT)
                        {
                            EventScriptCode_Output codeOut = (EventScriptCode_Output)code.GetPointer();
                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeOut.GetValue());

                            string wText = StringUtility.ConvertMultiToWide(val.GetString());
                            textEvent_.SetSource(wText);
                        }
                        else if (typeCode == EventScriptCode.TYPE_IMAGE)
                        {
                            EventScriptCode_Image codeImage = (EventScriptCode_Image)code.GetPointer();
                            EventScriptCodeExecuter_Image executer = new EventScriptCodeExecuter_Image(this, codeImage);

                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeImage.GetWaitEnd());
                            bool bWaitEnd = val.GetBoolean();
                            if (bWaitEnd)
                            {
                                activeCodeExecuter_ = executer;
                            }
                            else
                            {
                                parallelCodeExecuter_.AddLast(executer);
                            }
                        }
                        else if (typeCode == EventScriptCode.TYPE_SOUND)
                        {
                            EventScriptCode_Sound codeSound = (EventScriptCode_Sound)code.GetPointer();
                            EventValueParser parser = new EventValueParser(this);
                            ref_count_ptr<EventValue> val = parser.GetEventValue(codeSound.GetPath());
                            string path = val.GetString();
                            if (path.Length > 0)
                            {
                                sound_.Play(codeSound.GetSoundType(), path);
                            }
                            else
                            {
                                sound_.Delete(codeSound.GetSoundType());
                            }
                        }
                        else if (typeCode == EventScriptCode.TYPE_IF)
                        {
                            while (true)
                            {
                                ref_count_ptr<EventScriptCode_If> codeIf = new ref_count_ptr<EventScriptCode_If>(code);
                                string param = codeIf.GetParameter();
                                EventValueParser parser = new EventValueParser(this);
                                ref_count_ptr<EventValue> val = parser.GetEventValue(param);
                                if (val.GetBoolean())
                                {
                                    ref_count_ptr<EventFrame> pFrame = new EventFrame();
                                    pFrame.SetActiveSource(frameActive.GetActiveSource());

                                    ref_count_ptr<EventScriptBlock> block = new ref_count_ptr<EventScriptBlock>(codeIf);
                                    pFrame.SetBlock(block);

                                    frame_.Add(pFrame);
                                    break;
                                }

                                int posNext = codeIf.GetNextElsePosition();
                                if (posNext > 0)
                                {
                                    frameActive.SetCurrentPosition(posNext);
                                    code = frameActive.GetCurrentCode();
                                }
                                else
                                {
                                    // if�Y���Ȃ�
                                    frameActive.SetCurrentPosition(codeIf.GetEndPosition());
                                    break;
                                }
                            }
                            continue;
                        }
                        else if (typeCode == EventScriptCode.TYPE_JUMP)
                        {
                            ref_count_ptr<EventScriptCode_Jump> codeJump = new ref_count_ptr<EventScriptCode_Jump>(code);
                            EventValueParser parser = new EventValueParser(this);
                            string path = parser.GetEventValue(codeJump.GetPath()).GetString();
                            string name = parser.GetEventValue(codeJump.GetName()).GetString();

                            ref_count_ptr<EventScriptBlock> block = new ref_count_ptr<EventScriptBlock>();
                            ref_count_ptr<EventFrame> frameJump = new EventFrame();
                            if (path.Length == 0)
                            {
                                // ���X�N���v�g
                                block = frameActive.GetActiveSource().GetEventBlock(name);
                                frameJump.SetActiveSource(frameActive.GetActiveSource());
                            }
                            else
                            {
                                // �ʃt�@�C���X�N���v�g
                                string wPath = StringUtility.ConvertMultiToWide(path);
                                gstd.ref_count_ptr<EventScriptSource> source = _GetSource(wPath);
                                frameJump.SetActiveSource(source);
                                block = source.GetEventBlock(name);
                            }

                            if (block != null)
                            {
                                if (codeJump.IsGoSub())
                                {
                                    int current = frameActive.GetCurrentPosition() + 1;
                                    frameJump.SetBlock(block);
                                    frame_.Add(frameJump);
                                    frameJump.SetReturnPosition(current);
                                }
                                else
                                {
                                    int current = frameActive.GetCurrentPosition() + 1;
                                    frameJump.SetBlock(block);
                                    frame_.Clear();
                                    frame_.Add(frameJump);
                                    frameJump.SetReturnPosition(current);
                                }
                            }
                            else
                            {
                                _RaiseError("���݂��Ȃ��u���b�N���w�肳��܂���");
                            }

                            continue;
                        }
                        else if (typeCode == EventScriptCode.TYPE_SCRIPT)
                        {
                            ref_count_ptr<EventScriptCode_Script> codeScript = new ref_count_ptr<EventScriptCode_Script>(code);
                            EventValueParser parser = new EventValueParser(this);
                            string path = parser.GetEventValue(codeScript.GetPath()).GetString();
                            string method = parser.GetEventValue(codeScript.GetMethod()).GetString();
                            string code = parser.GetEventValue(codeScript.GetCode()).GetString();
                            code = StringUtility.ReplaceAll(code, "\\\"", "\"");
                            string scriptId = parser.GetEventValue(codeScript.GetId()).GetString();
                            bool bWait = parser.GetEventValue(codeScript.GetWaitEnd()).GetBoolean();
                            int target = parser.GetEventValue(codeScript.GetTargetId()).GetReal();
                            List<string> listArg = codeScript.GetArgumentList();

                            if (method.Length == 0)
                            {
                                _RaiseError("method�̂Ȃ��X�N���v�g����s���悤�Ƃ��܂���");
                            }

                            string wPath = StringUtility.ConvertMultiToWide(path);
                            DxScriptForEvent script = new DxScriptForEvent(this);
                            script.SetTargetId(target);
                            script.SetMethod(method);
                            if (path.Length > 0)
                            {
                                script.SetSourceFromFile(wPath);
                            }
                            else if (code.Length > 0)
                            {
                                script.SetSource(code);

                                string path = GetSourcePath(frameActive.GetActiveSource());
                                script.SetPath(wPath);
                            }

                            script.SetScriptId(scriptId);
                            script.Compile();
                            if (listArg.Count > 0)
                            {
                                int countArg = listArg.Count;
                                for (int iArg = 0 ; iArg < countArg ; iArg++)
                                {
                                    ref_count_ptr<EventValue> eArg = parser.GetEventValue(new List<string>(listArg[iArg]));
                                    script.AddArgumentValue(new ref_count_ptr<EventValue>(eArg));
                                }
                            }
                            script.Run(method);

                            if (codeScript.IsEndScript())
                            {
                                LinkedList<gstd.ref_count_ptr<DxScriptForEvent>>.Enumerator itr;
                                for (itr = listScript_.GetEnumerator(); itr.MoveNext();)
                                {
                                    gstd.ref_count_ptr<DxScriptForEvent> script = itr.Current;
                                    if (scriptId == script.GetScriptId() || (wPath == script.GetPath() && method == script.GetMethod()))
                                    {
                                        script.EndScript();
                                    }
                                }
                            }
                            else
                            {
                                if (bWait)
                                {
                                    EventScriptCodeExecuter_Script executer = new EventScriptCodeExecuter_Script(this, script);
                                    activeCodeExecuter_ = executer;
                                }
                                listScript_.AddLast(script);
                            }
                        }
                        else
                        {
                            // �s���ȃ^�O��A�e�L�X�g�����_���ɂ��̂܂܂킽���^�O
                            int res = _RunCode(new ref_count_ptr<EventFrame>(frameActive), code);
                            if (res == (int)AnonymousEnum10.RUN_RETURN_NONE)
                            {
                                string wText = StringUtility.ConvertMultiToWide(code.GetCodeText());
                                textEvent_.SetSource(wText);
                            }
                        }

                        if (frameActive.HasNextCode())
                        {
                            frameActive.NextCode();
                        }
                        else
                        {
                            frameActive.SetEnd();
                        }
                        bCriticalFrame_ = true;
                    }
                }

                // �X�L�b�v���̏ꍇ�́A�����X�V�s�v
                if (keyState_.IsSkip())
                {
                    bCriticalFrame_ = false;
                }
            }

            protected virtual int _RunCode(gstd.ref_count_ptr<EventFrame> frameActive, gstd.ref_count_ptr<EventScriptCode> code)
            {
                return (int)AnonymousEnum10.RUN_RETURN_NONE;
            }
            protected virtual void _RunScript()
            {
                // �X�N���v�g���s
                LinkedList<gstd.ref_count_ptr<DxScriptForEvent>>.Enumerator itrScript;
                for (itrScript = listScript_.GetEnumerator(); itrScript.MoveNext();)
                {
                    gstd.ref_count_ptr<DxScriptForEvent> script = itrScript.Current;
                    if (script.IsScriptEnd())
                    {
                        script.Clear();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                        itrScript = listScript_.erase(itrScript);
                    }
                    else
                    {
                        script.Run("MainLoop");
                    }
                }
            }

            protected virtual void _WorkWindow()
            {
                windowManager_.Work();
            }

            protected gstd.ref_count_ptr<EventScriptSource> _GetSource(string path)
            {
                gstd.ref_count_ptr<EventScriptSource> res = null;
                if (mapSource_.ContainsKey(path))
                {
                    res.CopyFrom(mapSource_[path]);
                }
                else
                {
                    EventScriptCompiler compiler = new EventScriptCompiler();
                    compiler.SetPath(path);
                    res.CopyFrom(compiler.Compile());

                    if (res == null)
                    {
                        throw new gstd.wexception("�R���p�C�����s");
                    }

                    ref_count_ptr<EventScriptBlock> block = res.GetEventBlock(EventScriptBlock.BLOCK_GLOBAL);
                    if (block != null)
                    {
                        frameGlobal_.SetActiveSource(res);
                        frameGlobal_.SetBlock(block);

                        ref_count_ptr<EventFrame> frame = new EventFrame();
                        frame.SetAutoGlobal(true);
                        frame.SetActiveSource(res);
                        frame.SetBlock(block);
                        frame_.Add(frame);
                        _RunCode();
                    }

                    mapSource_[path].CopyFrom(res);
                }
                return new gstd.ref_count_ptr<EventScriptSource>(res);
            }


            // EventEngine
            public EventEngine()
            {
                state_ = (int)AnonymousEnum9.STATE_RUN;
            }

            public override void Dispose()
            {
                FileManager.GetBase().WaitForThreadLoadComplete();

                listScript_.Clear();
                windowManager_ = null;
                textEvent_ = null;
                image_ = null;
                keyState_ = null;
                frameGlobal_ = null;
                base.Dispose();
            }

            public virtual bool Initialize()
            {
                windowManager_ = new EventWindowManager(this);
                windowManager_.Initialize();
                textEvent_ = new EventText();
                logEvent_ = new EventLogText(this);
                image_ = new EventImage();
                keyState_ = new EventKeyState(this);
                sound_ = new EventSound();
                bCriticalFrame_ = false;
                frameGlobal_ = new EventFrame();
                cacheScriptEngine_ = new ScriptEngineCache();
                return true;
            }

            public virtual void Work()
            {
                try
                {
                    // ��ԕύX
                    CheckStateChenge();

                    // ���s
                    if (state_ == (int)AnonymousEnum9.STATE_RUN)
                    {
                        _RunCode();
                        _RunScript();
                    }
                    else if (state_ == (int)AnonymousEnum9.STATE_LOG)
                    {
                        _WorkWindow();
                    }
                    else if (state_ == (int)AnonymousEnum9.STATE_HIDE_TEXT)
                    {
                        _WorkWindow();
                        _RunScript();
                    }
                }
                catch (gstd.wexception e)
                {
                    _RaiseError(e.what());
                }
            }

            public virtual void Render()
            {
                DirectGraphics graphics = DirectGraphics.GetBase();
                ref_count_ptr<DxCamera2D> camera = graphics.GetCamera2D();

                camera.SetEnable(true);
                image_.Render(image_.GetForegroundLayerIndex());
                camera.SetEnable(false);

                windowManager_.Render();
            }

            public void SetSource(string path)
            {
                ref_count_ptr<EventScriptSource> source = _GetSource(path);
                ref_count_ptr<EventFrame> frame = new EventFrame();
                frame.SetActiveSource(source);

                ref_count_ptr<EventScriptBlock> block = source.GetEventBlock("main");
                frame.SetBlock(block);

                frame_.Add(frame);
            }

            public gstd.ref_count_ptr<EventScriptSource> GetSource(string path)
            {
                if (!mapSource_.ContainsKey(path))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<EventScriptSource>(mapSource_[path]);
            }

            public string GetSourcePath(gstd.ref_count_ptr<EventScriptSource> source)
            {
                string res = "";
                SortedDictionary<string, gstd.ref_count_ptr<EventScriptSource>>.Enumerator itrSource;
                for (itrSource = mapSource_.GetEnumerator(); itrSource.MoveNext();)
                {
                    gstd.ref_count_ptr<EventScriptSource> tSource = itrSource.Current.Value;
                    if (source == tSource)
                    {
                        res = itrSource.Current.Key;
                        break;
                    }
                }
                return res;
            }

            public virtual bool IsEnd()
            {
                return frame_.Count == 0;
            }

            public gstd.ref_count_ptr<EventText> GetEventText()
            {
                return new gstd.ref_count_ptr<EventText>(textEvent_);
            }
            public gstd.ref_count_ptr<EventLogText> GetEventLogText()
            {
                return new gstd.ref_count_ptr<EventLogText>(logEvent_);
            }
            public gstd.ref_count_ptr<EventWindowManager> GetWindowManager()
            {
                return new gstd.ref_count_ptr<EventWindowManager>(windowManager_);
            }

            public gstd.ref_count_ptr<EventValue> GetEventValue(string key)
            {
                gstd.ref_count_ptr<EventValue> res = null;
                bool bInner = true;
                int count = frame_.Count;
                for (int iFrame = count - 1 ; iFrame >= 0 && res == null && bInner; iFrame--)
                {
                    ref_count_ptr<EventFrame> frame = frame_[iFrame];
                    res = frame.GetValue(key);
                    bInner = frame.IsInnerBlock();
                }

                if (res == null)
                {
                    res = frameGlobal_.GetValue(key);
                }

                if (res == null)
                {
                    SystemValueManager svm = SystemValueManager.GetBase();
                    ref_count_ptr<RecordBuffer> record = svm.GetRecordBuffer(SystemValueManager.RECORD_SYSTEM);
                    if (record == null)
                    {
                        record = svm.GetRecordBuffer(SystemValueManager.RECORD_SYSTEM_GLOBAL);
                    }
                    if (record != null)
                    {
                        if (record.IsExists(key))
                        {
                            res = new EventValue();
                            int type = record.GetEntryType(key);
                            switch (type)
                            {
                                case RecordEntry.TYPE_BOOLEAN:
                                    res.SetBoolean(record.GetRecordAsBoolean(key));
                                    break;
                                case RecordEntry.TYPE_DOUBLE:
                                    res.SetReal(record.GetRecordAsDouble(key));
                                    break;
                                case RecordEntry.TYPE_STRING_A:
                                    res.SetString(record.GetRecordAsStringA(key));
                                    break;
                            }
                        }
                    }
                }

                return new gstd.ref_count_ptr<EventValue>(res);
            }

            public gstd.ref_count_ptr<EventImage> GetEventImage()
            {
                return new gstd.ref_count_ptr<EventImage>(image_);
            }
            public gstd.ref_count_ptr<EventKeyState> GetEventKeyState()
            {
                return new gstd.ref_count_ptr<EventKeyState>(keyState_);
            }

            public gstd.ref_count_ptr<EventScriptCodeExecuter> GetActiveCodeExecuter()
            {
                return new gstd.ref_count_ptr<EventScriptCodeExecuter>(activeCodeExecuter_);
            }
            public gstd.ref_count_ptr<EventFrame> GetGlobalFrame()
            {
                return new gstd.ref_count_ptr<EventFrame>(frameGlobal_);
            }

            public gstd.ref_count_ptr<gstd.ScriptEngineCache> GetScriptEngineCache()
            {
                return new gstd.ref_count_ptr<gstd.ScriptEngineCache>(cacheScriptEngine_);
            }

            public bool IsCriticalFrame()
            {
                return bCriticalFrame_;
            }

            public void SetState(int state)
            {
                if (state_ == state)
                {
                    return;
                }

                EventWindowManager windowManager = GetWindowManager().GetPointer();
                EventTextWindow wndText = windowManager.GetTextWindow().GetPointer();
                EventNameWindow wndName = windowManager.GetNameWindow().GetPointer();
                EventLogWindow wndLog = windowManager.GetLogWindow().GetPointer();
                bool bTextVisible = windowManager.IsTextVisible();
                if (!bTextVisible)
                {
                    state = (int)AnonymousEnum9.STATE_RUN;
                }

                state_ = state;
                if (state == (int)AnonymousEnum9.STATE_LOG)
                {
                    wndText.SetWindowVisible(false);
                    wndName.SetWindowVisible(false);
                    wndLog.ResetPosition();
                    wndLog.SetWindowEnable(true);
                    wndLog.SetWindowVisible(true);
                }
                else if (state == (int)AnonymousEnum9.STATE_RUN)
                {
                    wndText.SetWindowVisible(true);
                    wndName.SetWindowVisible(true);
                    wndLog.SetWindowEnable(false);
                    wndLog.SetWindowVisible(false);
                }
                else if (state == (int)AnonymousEnum9.STATE_HIDE_TEXT)
                {
                    wndText.SetWindowVisible(false);
                    wndName.SetWindowVisible(false);
                    wndLog.SetWindowEnable(false);
                    wndLog.SetWindowVisible(false);
                }

                DxButton btnSave = windowManager.GetSaveButton().GetPointer();
                DxButton btnLoad = windowManager.GetLoadButton().GetPointer();
                if (btnSave != null)
                {
                    btnSave.SetWindowVisible(state == (int)AnonymousEnum9.STATE_RUN);
                    btnSave.SetWindowEnable(state == (int)AnonymousEnum9.STATE_RUN);
                }
                if (btnLoad != null)
                {
                    btnLoad.SetWindowVisible(state == (int)AnonymousEnum9.STATE_RUN);
                    btnLoad.SetWindowEnable(state == (int)AnonymousEnum9.STATE_RUN);
                }

                DirectInput input = DirectInput.GetBase();
                input.ResetMouseState();
            }

            public int GetState()
            {
                return state_;
            }
            public virtual void CheckStateChenge()
            {
                DirectInput input = DirectInput.GetBase();
                if (state_ == (int)AnonymousEnum9.STATE_RUN)
                {
                    bool bChangeLOG = input.GetMouseMoveZ() > 0;
                    bool bChangeHideText = input.GetMouseState(DI_MOUSE_RIGHT) == KEY_PULL;

                    if (bChangeLOG)
                    {
                        SetState((int)AnonymousEnum9.STATE_LOG);
                    }
                    else if (bChangeHideText)
                    {
                        SetState((int)AnonymousEnum9.STATE_HIDE_TEXT);
                    }
                }
                else if (state_ == (int)AnonymousEnum9.STATE_HIDE_TEXT)
                {
                    bool bChangeRun = false;
                    bChangeRun |= keyState_.IsSkip();
                    bChangeRun |= (input.GetMouseState(DI_MOUSE_LEFT) == KEY_PULL);
                    bChangeRun |= (input.GetMouseState(DI_MOUSE_RIGHT) == KEY_PULL);
                    if (bChangeRun)
                    {
                        SetState((int)AnonymousEnum9.STATE_RUN);
                    }
                }
            }


            public bool IsSaveEnable()
            {
                if (activeCodeExecuter_ == null)
                {
                    return false;
                }
                bool bEnable = ref_count_ptr<EventScriptCodeExecuter_WaitClick>.DownCast(activeCodeExecuter_) != null;
                return bEnable;
            }

            public bool Load(string path)
            {
                RecordBuffer record = new RecordBuffer();
                record.ReadFromFile(path);

                return Load(record);
            }

            public bool Load(gstd.RecordBuffer record)
            {
                Read(record);

                // �Ƃ肠�����N���b�N�҂�
                textEvent_.NextSkip();
                activeCodeExecuter_ = new EventScriptCodeExecuter_WaitClick(this);

                SetState((int)AnonymousEnum9.STATE_RUN);

                return true;
            }

            public bool Save(string path)
            {
                RecordBuffer record = new RecordBuffer();
                Write(record);
                record.WriteToFile(path);
                return true;
            }

            public override void Read(gstd.RecordBuffer record)
            {
                // �e�L�X�g�E�B���h�E
                string textDisp = record.GetRecordAsStringW("DispText");
                textEvent_.SetSource(textDisp);

                // �X�N���v�g�p�X
                int countSource = record.GetRecordAsInteger("SourceCount");
                for (int iSource = 0 ; iSource < countSource ; iSource++)
                {
                    string path = record.GetRecordAsStringW(StringUtility.Format("SourcePath%d", iSource));
                    path = PathProperty.GetModuleDirectory() + path;

                    EventScriptCompiler compiler = new EventScriptCompiler();
                    compiler.SetPath(path);
                    gstd.ref_count_ptr<EventScriptSource> source = compiler.Compile();

                    mapSource_[path].CopyFrom(source);
                }

                // �O���[�o���ϐ��t���[��
                gstd.RecordBuffer recGlobalFrame = new gstd.RecordBuffer();
                record.GetRecordAsRecordBuffer("GlobalFrame", recGlobalFrame);
                frameGlobal_.ReadRecord(recGlobalFrame, this);

                // �t���[��
                int countFrame = record.GetRecordAsInteger("FrameCount");
                frame_.Resize(countFrame);
                for (int iFrame = 0 ; iFrame < countFrame ; iFrame++)
                {
                    gstd.RecordBuffer recFrame = new gstd.RecordBuffer();
                    record.GetRecordAsRecordBuffer(StringUtility.Format("Frame%d", iFrame), recFrame);
                    EventFrame frame = new EventFrame();
                    frame.ReadRecord(recFrame, this);

                    frame_[iFrame] = frame;
                }

                // �\�����摜
                RecordBuffer recImage = new RecordBuffer();
                record.GetRecordAsRecordBuffer("image", recImage);
                image_.Read(recImage);

                // �E�B���h�E
                RecordBuffer recWindow = new RecordBuffer();
                record.GetRecordAsRecordBuffer("window", recWindow);
                windowManager_.Read(recWindow);

                // ����
                RecordBuffer recSound = new RecordBuffer();
                record.GetRecordAsRecordBuffer("sound", recSound);
                sound_.Read(recSound);

                // ���s���X�N���v�g
                int countScript = record.GetRecordAsInteger("ScriptCount");
                for (int iScript = 0 ; iScript < countScript ; iScript++)
                {
                    RecordBuffer recScript = new RecordBuffer();
                    record.GetRecordAsRecordBuffer(StringUtility.Format("Script%d", iScript), recScript);

                    DxScriptForEvent script = new DxScriptForEvent(this);
                    script.Read(recScript);
                    script.Compile();
                    script.Run(script.GetMethod());

                    listScript_.AddLast(script);
                }
            }

            public override void Write(gstd.RecordBuffer record)
            {
                // �e�L�X�g�E�B���h�E
                string wTextDisp = textEvent_.GetText();
                record.SetRecordAsStringW("DispText", wTextDisp);

                // �X�N���v�g�p�X
                int iSource = 0;
                record.SetRecordAsInteger("SourceCount", mapSource_.Count);
                SortedDictionary<string, gstd.ref_count_ptr<EventScriptSource>>.Enumerator itrSource;
                for (itrSource = mapSource_.GetEnumerator(); itrSource.MoveNext();)
                {
                    string path = itrSource.Current.Key;
                    path = PathProperty.GetPathWithoutModuleDirectory(path);

                    record.SetRecordAsStringW(StringUtility.Format("SourcePath%d", iSource), path);
                    iSource++;
                }

                // �O���[�o���ϐ��t���[��
                gstd.RecordBuffer recGlobalFrame = new gstd.RecordBuffer();
                frameGlobal_.WriteRecord(recGlobalFrame, this);
                record.SetRecordAsRecordBuffer("GlobalFrame", recGlobalFrame);

                // �t���[��
                int countFrame = frame_.Count;
                record.SetRecordAsInteger("FrameCount", countFrame);
                for (int iFrame = 0 ; iFrame < countFrame ; iFrame++)
                {
                    gstd.RecordBuffer recFrame = new gstd.RecordBuffer();
                    frame_[iFrame].WriteRecord(recFrame, this);
                    record.SetRecordAsRecordBuffer(StringUtility.Format("Frame%d", iFrame), recFrame);
                }

                // �\�����摜
                RecordBuffer recImage = new RecordBuffer();
                image_.Write(recImage);
                record.SetRecordAsRecordBuffer("image", recImage);

                // �E�B���h�E
                RecordBuffer recWindow = new RecordBuffer();
                windowManager_.Write(recWindow);
                record.SetRecordAsRecordBuffer("window", recWindow);

                // ����
                RecordBuffer recSound = new RecordBuffer();
                sound_.Write(recSound);
                record.SetRecordAsRecordBuffer("sound", recSound);

                // ���s���X�N���v�g
                int countScript = 0;
                LinkedList<gstd.ref_count_ptr<DxScriptForEvent>>.Enumerator itrScript;
                for (itrScript = listScript_.GetEnumerator(); itrScript.MoveNext();)
                {
                    gstd.ref_count_ptr<DxScriptForEvent> script = itrScript.Current;
                    if (script == null)
                    {
                        continue;
                    }
                    if (script.IsScriptEnd())
                    {
                        continue;
                    }

                    RecordBuffer recScript = new RecordBuffer();
                    script.Write(recScript);
                    record.SetRecordAsRecordBuffer(StringUtility.Format("Script%d", countScript), recScript);

                    countScript++;
                }
                record.SetRecordAsInteger("ScriptCount", countScript);
            }
    }

    /**********************************************************
    //DxScriptForEvent
    **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class DxScriptForEvent : DxScript, gstd.Recordable
    {
            private EventEngine engine_;
            private bool bScriptEnd_;
            private string method_ = "";
            private int targetId_;
            private string scriptId_ = "";
            private SortedSet<int> listObj_ = new SortedSet<int>();
            private string code_ = "";

            private override List<char> _Include(List<char> source)
            {
                List<char> res = ScriptClientBase._Include(source);
                string strMain = "@MainLoop{yield;}";

                int posResEnd = res.Count;
                res.Resize(res.Count + strMain.Length);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(res[posResEnd], strMain[0], strMain.Length);

                return new List<char>(res);
            }

            public DxScriptForEvent(EventEngine engine)
            {
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(eventFunction, sizeof(eventFunction) / sizeof(function));
                _AddFunction(GlobalMembers.eventFunction, GlobalMembers.eventFunction.Length);
                bScriptEnd_ = false;
                targetId_ = ID_INVALID;
                engine_ = engine;

                gstd.ref_count_ptr<EventImage> image = engine.GetEventImage();
                int layer = image.GetForegroundLayerIndex();
                SetObjectManager(image.GetObjectManager(layer));
            }

            public new void Dispose()
            {
                Clear();
                base.Dispose();
            }

            public void Clear()
            {
                SortedSet<int>.Enumerator itr = listObj_.GetEnumerator();
                while (itr.MoveNext())
                {
                    objManager_.DeleteObjectitr.Current;
                }
            }

            public override bool SetSourceFromFile(string path)
            {
                SetScriptEngineCache(engine_.GetScriptEngineCache());
                return ScriptClientBase.SetSourceFromFile(path);
            }

            public override void SetSource(string source)
            {
                code_ = source;
                ScriptClientBase.SetSource(source);
            }

            public virtual int AddObject(gstd.ref_count_ptr<DxScriptObjectBase>.unsync obj)
            {
                int res = base.AddObject(obj);
                if (res != ID_INVALID)
                {
                    listObj_.Add(res);
                }
                return res;
            }

            public override void DeleteObject(int id)
            {
                if (id == ID_INVALID)
                {
                    return;
                }
                base.DeleteObject(id);
                SortedSet<int>.Enumerator itr = listObj_.find(id);
                if (itr == listObj_.end())
                {
                    return;
                }
                listObj_.erase(itr);
            }

            public string GetMethod()
            {
                return method_;
            }
            public void SetMethod(string method)
            {
                method_ = method;
            }

            public void EndScript()
            {
                bScriptEnd_ = true;
            }
            public bool IsScriptEnd()
            {
                return bScriptEnd_;
            }

            public void SetTargetId(int target)
            {
                targetId_ = target;
            }
            public string GetScriptId()
            {
                return scriptId_;
            }
            public void SetScriptId(string id)
            {
                scriptId_ = id;
            }
            public string GetCode()
            {
                return code_;
            }

            public void AddArgumentValue(gstd.ref_count_ptr<EventValue> arg)
            {
                int type = arg.GetType();
                gstd.value vArg = new gstd.value();
                if (type == EventValue.TYPE_REAL)
                {
                    vArg = new value(machine_.get_engine().get_real_type(), (double)arg.GetReal());
                }
                else if (type == EventValue.TYPE_BOOLEAN)
                {
                    vArg = new value(machine_.get_engine().get_boolean_type(), arg.GetBoolean());
                }
                else if (type == EventValue.TYPE_STRING)
                {
                    vArg = new value(machine_.get_engine().get_string_type(), to_wide(arg.GetString()));
                }
                ScriptClientBase.AddArgumentValue(vArg);
            }

            public override void Read(gstd.RecordBuffer record)
            {
                // �t�@�C���p�X
                string path = record.GetRecordAsStringW("path");
                path = PathProperty.GetModuleDirectory() + path;

                // ���s���\�b�h
                method_ = record.GetRecordAsStringA("method");

                // �^�[�Q�b�g
                targetId_ = record.GetRecordAsInteger("target");

                // �R�[�h
                code_ = record.GetRecordAsStringA("code");

                if (code_.Length > 0)
                {
                    SetSource(code_);
                    SetPath(path);
                }
                else
                {
                    SetSourceFromFile(path);
                }
            }

            public override void Write(gstd.RecordBuffer record)
            {
                // �t�@�C���p�X
                string path = GetPath();
                path = PathProperty.GetPathWithoutModuleDirectory(path);
                record.SetRecordAsStringW("path", path);

                // ���s���\�b�h
                record.SetRecordAsStringA("method", method_);

                // �^�[�Q�b�g
                record.SetRecordAsInteger("target", targetId_);

                // �R�[�h
                record.SetRecordAsStringA("code", code_);
            }

            // �֐��F�X�N���v�g����

            // �֐��F�X�N���v�g����
            public static gstd.value Func_EndScript(script_machine machine, int argc, value argv)
            {
                DxScriptForEvent script = (DxScriptForEvent)machine.data;
                script.bScriptEnd_ = true;
                return new gstd.value();
            }

            public static gstd.value Func_GetTarget(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DxScriptForEvent script = (DxScriptForEvent)machine.data;
                return new value(machine.get_engine().get_real_type(), (double)script.targetId_);
            }

            public static gstd.value Func_GetEventValue(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScriptForEvent script = (DxScriptForEvent)machine.data;
                string wName = argv[0].as_string();
                string name = to_mbcs(wName);
                gstd.ref_count_ptr<EventValue> eValue = script.engine_.GetEventValue(name);
                if (eValue == null)
                {
                    throw new gstd.wexception(StringUtility.Format("���݂��Ȃ��ϐ�:%s", name).c_str());
                }

                int type = eValue.GetType();
                if (type == EventValue.TYPE_REAL)
                {
                    return new value(machine.get_engine().get_real_type(), (double)eValue.GetReal());
                }
                else if (type == EventValue.TYPE_BOOLEAN)
                {
                    return new value(machine.get_engine().get_boolean_type(),eValue.GetBoolean());
                }
                else if (type == EventValue.TYPE_STRING)
                {
                    return new value(machine.get_engine().get_string_type(),to_wide(eValue.GetString()));
                }
                return new gstd.value();
            }

            public static gstd.value Func_SetEventValue(gstd.script_machine machine, int argc, gstd.value[] argv)
            {
                DxScriptForEvent script = (DxScriptForEvent)machine.data;
                string wName = argv[0].as_string();
                string name = to_mbcs(wName);
                gstd.ref_count_ptr<EventValue> eValue = script.engine_.GetEventValue(name);
                if (eValue == null)
                {
                    throw new gstd.wexception(StringUtility.Format("���݂��Ȃ��ϐ�:%s", name).c_str());
                }

                if (argv[1].get_type() == machine.get_engine().get_real_type())
                {
                    eValue.SetReal(argv[1].as_real());
                }
                else if (argv[1].get_type() == machine.get_engine().get_boolean_type())
                {
                    eValue.SetBoolean(argv[1].as_boolean());
                }
                else if (argv[1].get_type() == machine.get_engine().get_string_type())
                {
                    eValue.SetString(to_mbcs(argv[1].as_string()));
                }
                return new gstd.value();
            }

            // �֐��F�L�[����

            // �֐��F�L�[����
            public static gstd.value Func_IsSkip(gstd.script_machine machine, int argc, gstd.value argv)
            {
                DxScriptForEvent script = (DxScriptForEvent)machine.data;
                EventEngine engine = script.engine_;
                gstd.ref_count_ptr<EventKeyState> key = engine.GetEventKeyState();

                return new gstd.value(machine.get_engine().get_boolean_type(), key.IsSkip() || key.IsNext());
            }

    }
}