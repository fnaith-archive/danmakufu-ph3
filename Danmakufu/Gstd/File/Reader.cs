// https://stackoverflow.com/questions/21691677/how-to-retrieve-integer-value-from-binary-file-in-c-sharp

namespace Gstd
{
    namespace File
    {
        abstract class Reader // TODO
        {
            //public virtual ~Reader(){};
            //public virtual DWORD Read(LPVOID buf,DWORD size) = 0;
            /*public template <typename T> DWORD Read(T& data)
            {
                return Read(&data, sizeof(T));
            }*/
            //public bool ReadBoolean(){bool res; Read(res);return res;}
            //public char ReadCharacter(){char res; Read(res);return res;}
            //public short ReadShort(){short res; Read(res);return res;}
            //public int ReadInteger(){int num; Read(num);return num;}
            //public _int64 ReadInteger64(){_int64 num; Read(num);return num;}
            //public float ReadFloat(){float num; Read(num);return num;}
            //public double ReadDouble(){double num; Read(num);return num;}

            public string ReadString(int size)
            {
                string res = "";
                //res.resize(size);
                //Read(&res[0], size);
                return res;
            }
        }
    }
}