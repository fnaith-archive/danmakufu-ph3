using System;
using System.Collections.Generic;

namespace Gstd
{
    namespace GstdUtility
    {
        class Scanner
        {
            private int textStartPointer;
            private string buffer;
            int pointer;//���̈ʒu
            Token token;//���݂̃g�[�N��
            bool bPermitSignNumber;
            List<Token> listDebugToken;

            /*wchar_t _CurrentChar;
            wchar_t _NextChar();//�|�C���^��i�߂Ď��̕����𒲂ׂ�
            
            virtual void _SkipComment();//�R�����g���Ƃ΂�
            virtual void _SkipSpace();//�󔒂��Ƃ΂�
            virtual void _RaiseError(std::wstring str);//��O�𓊂��܂�
        public:
            Scanner(char* str, int size);*/
            public Scanner(string str)
            {
                /*bPermitSignNumber_ = true;
                buffer_ = buf;
                pointer_ = 0;
                textStartPointer_ = 0;
                listDebugToken = new List<Token>();

                typeEncoding_ = Encoding::SHIFT_JIS;
                if(Encoding::IsUtf16Le(&buf[0], buf.size()))
                {
                    typeEncoding_ = Encoding::UTF16LE;
                    textStartPointer_ = Encoding::GetBomSize(&buf[0], buf.size());
                }

                buffer_.push_back(0);
                if(typeEncoding_ == Encoding::UTF16LE)
                {
                    buffer_.push_back(0);
                }

                SetPointerBegin();*/
            }
            /*Scanner(std::wstring wstr);
            Scanner(std::vector<char>& buf);
            virtual ~Scanner();

            void SetPermitSignNumber(bool bEnable){bPermitSignNumber_ = bEnable;}
            int GetEncoding(){return typeEncoding_;}

            Token& GetToken();//���݂̃g�[�N�����擾
            Token& Next();*/
            public bool HasNext()
            {
                return false;//pointer_ < buffer_.size() && _CurrentChar() != L'\0' && token_.GetType() != Token::TK_EOF;
            }
            /*void CheckType(Token& tok, Token::Type type);
            void CheckIdentifer(Token& tok, std::wstring id);
            int GetCurrentLine();

            int GetCurrentPointer();
            void SetCurrentPointer(int pos);
            void SetPointerBegin();
            std::wstring GetString(int start, int end);

            bool CompareMemory(int start, int end, const char* data);*/
        }
    }
}
