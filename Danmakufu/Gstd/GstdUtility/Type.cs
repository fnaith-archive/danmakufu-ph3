using System;

namespace Gstd
{
    namespace GstdUtility
    {
        enum Type
        {
        /*public:
            enum Type
            {
                TK_UNKNOWN,TK_EOF,TK_NEWLINE,
                TK_ID,
                TK_INT,TK_REAL,TK_STRING,

                TK_OPENP,TK_CLOSEP,TK_OPENB,TK_CLOSEB,TK_OPENC,TK_CLOSEC,
                TK_SHARP,
                TK_PIPE,TK_AMPERSAND,

                TK_COMMA,TK_PERIOD,TK_EQUAL,
                TK_ASTERISK,TK_SLASH,TK_COLON,TK_SEMICOLON,TK_TILDE,TK_EXCLAMATION,
                TK_PLUS,TK_MINUS,
                TK_LESS,TK_GREATER,
            };
        protected:
            Type type_;
            std::wstring element_;
            int posStart_;
            int posEnd_;
        public:
            Token(){type_ = TK_UNKNOWN;posStart_=0;posEnd_=0;}
            Token(Type type, std::wstring& element, int start, int end){type_ = type; element_ = element;posStart_=start;posEnd_=end;}
            virtual ~Token(){};

            Type GetType(){return type_;}
            std::wstring& GetElement(){return element_;}
            std::string GetElementA();

            int GetStartPointer(){return posStart_;}
            int GetEndPointer(){return posEnd_;}

            int GetInteger();
            double GetReal();
            bool GetBoolean();
            std::wstring GetString();
            std::wstring& GetIdentifier();

            std::string GetStringA();
            std::string GetIdentifierA();*/
        }
    }
}
