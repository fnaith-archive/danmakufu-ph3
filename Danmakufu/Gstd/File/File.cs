using System;
using System.IO;

namespace Gstd.File
{
    sealed class File : IReader, IWriter, System.IDisposable
    {
        private FileType type;
        private StreamReader hFile;
        private string path;
        public File()
        {
            hFile = null;
            path = "";
        }
        public File(string path)
        {
            hFile = new StreamReader(path);
            this.path = path;
        }
        public int Write(char[] buf, int size)
        {
            return -1; // TODO
        }
        public int Read(char[] buf, int size)
        {
            return hFile.Read(buf, 0, size);
        }
        public void Dispose()
        {
            Close();
        }
        /*public bool CreateDirectory();
        public void Delete();*/
        public bool IsExists()
        {
            if (hFile != null)
            {
                return true;
            }

            bool res = IsExists(path);
            return res;
        }
        public static bool IsExists(string path)
        {
            return System.IO.File.Exists(path);
        }
        /*public bool IsDirectory();*/

        public int GetSize()
        {
            return (int)(new FileInfo(path).Length);
        }
        /*public std::wstring& GetPath(){return path_;}
        public HANDLE GetHandle(){return hFile_;}*/

        public bool Open()
        {
            return Open(AccessType.READ);
        }
        public bool Open(AccessType typeAccess)
        {
            return true; // TODO
        }
        /*public bool Create();*/
        public void Close()
        {
            // TODO
        }

        public bool SetFilePointerBegin()
        {
            return true; // TODO (::SetFilePointer(hFile_,0,NULL,FILE_BEGIN)!=0xFFFFFFFF);
        }
        public bool SetFilePointerEnd()
        {
            return true; // TODO (::SetFilePointer(hFile_,0,NULL,FILE_END)!=0xFFFFFFFF);
        }
        public bool Seek(long offset/* TODO , DWORD seek=FILE_BEGIN*/)
        {
            return true; // TODO (::SetFilePointer(hFile_,offset,NULL,seek) != 0xFFFFFFFF);
        }
        public int GetFilePointer()
        {
            return -1; // TODO ::SetFilePointer(hFile_, 0, NULL, FILE_CURRENT);
        }

        /*public static bool IsEqualsPath(std::wstring path1, std::wstring path2);
        public static std::vector<std::wstring> GetFilePathList(std::wstring dir);
        public static std::vector<std::wstring> GetDirectoryPathList(std::wstring dir);*/
    }
}
