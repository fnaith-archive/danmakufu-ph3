using gstd;
using System;
using System.Collections.Generic;

// C++ TO C# CONVERTER NOTE: The following #define macro was replaced in-line:
// ORIGINAL LINE: #define new ::new(_NORMAL_BLOCK, __FILE__, __LINE__)

namespace gstd
{
    /**********************************************************
    //Writer
    **********************************************************/
    public abstract class Writer : System.IDisposable
    {
            public virtual void Dispose()
            {
            }
            public abstract uint Write(object buf, uint size);
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public uint Write<T>(T data)
            {
                return Write(data, sizeof(T));
            }
            public void WriteBoolean(bool b)
            {
                Write(b);
            }
            public void WriteCharacter(char ch)
            {
                Write(ch);
            }
            public void WriteShort(short num)
            {
                Write(num);
            }
            public void WriteInteger(int num)
            {
                Write(num);
            }
            public void WriteInteger64(_int64 num)
            {
                Write(num);
            }
            public void WriteFloat(float num)
            {
                Write(num);
            }
            public void WriteDouble(double num)
            {
                Write(num);
            }
    }

    /**********************************************************
    //Reader
    **********************************************************/
    public abstract class Reader : System.IDisposable
    {
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public uint Read<T>(T data)
            {
                return Read(data, sizeof(T));
            }
            public bool ReadBoolean()
            {
                bool res;
                Read(res);
                return res;
            }
            public char ReadCharacter()
            {
                char res;
                Read(res);
                return res;
            }
            public short ReadShort()
            {
                short res;
                Read(res);
                return res;
            }
            public int ReadInteger()
            {
                int num;
                Read(num);
                return num;
            }
            public _int64 ReadInteger64()
            {
                _int64 num = new _int64();
                Read(num);
                return new _int64(num);
            }
            public float ReadFloat()
            {
                float num;
                Read(num);
                return num;
            }
            public double ReadDouble()
            {
                double num;
                Read(num);
                return num;
            }
    }

    /**********************************************************
    //File
    //�t�@�C���́Ax:\fffff.xxx
    //�f�B���N�g����x:\ddddd
//  **********************************************************/
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
    public class File : Writer, Reader
    {
            protected IntPtr hFile_;
            protected string path_ = "";


            /**********************************************************
            //File
            **********************************************************/
            public File()
            {
                hFile_ = null;
                path_ = "";
            }

            public File(string path)
            {
                hFile_ = null;
                path_ = path;
            }

            public override void Dispose()
            {
                Close();
                base.Dispose();
            }

            public bool CreateDirectory()
            {
                string dir = PathProperty.GetFileDirectory(path_);
                if (File.IsExists(dir))
                {
                    return true;
                }

                List<string> str = StringUtility.Split(dir, "\\/");
                string tPath = "";
                for (int iDir = 0; iDir < str.Count; iDir++)
                {
                    tPath += str[iDir] + "\\";
                    WIN32_FIND_DATA fData = new WIN32_FIND_DATA();
                    IntPtr hFile = global::FindFirstFile(tPath, fData);
                    if (hFile == INVALID_HANDLE_VALUE)
                    {
                        SECURITY_ATTRIBUTES attr = new SECURITY_ATTRIBUTES();
                        attr.nLength = sizeof(SECURITY_ATTRIBUTES);
                        attr.lpSecurityDescriptor = null;
                        attr.bInheritHandle = false;
                        global::CreateDirectory(tPath, attr);
                    }
                    global::FindClose(hFile);
                }
                return true;
            }

            public void Delete()
            {
                Close();
                global::DeleteFile(path_);
            }

            public bool IsExists()
            {
                if (hFile_ != null)
                {
                    return true;
                }

                bool res = IsExists(path_);
                return res;
            }

            public static bool IsExists(string path)
            {
                bool res = PathFileExists(path) == true;
                return res;
            }

            public bool IsDirectory()
            {
                WIN32_FIND_DATA fData = new WIN32_FIND_DATA();
                IntPtr hFile = global::FindFirstFile(path_, fData);
                bool res = hFile != INVALID_HANDLE_VALUE ? true : false;
                if (res)
                {
                    res = (FILE_ATTRIBUTE_DIRECTORY & fData.dwFileAttributes) > 0;
                }

                global::FindClose(hFile);
                return res;
            }

            public int GetSize()
            {
                if (hFile_ != null)
                {
                    return global::GetFileSize(hFile_,null);
                }

                int res = 0;
                WIN32_FIND_DATA fData = new WIN32_FIND_DATA();
                IntPtr hFile = global::FindFirstFile(path_, fData);
                res = hFile != INVALID_HANDLE_VALUE ? global::GetFileSize(hFile, null) : 0;
                global::FindClose(hFile);
                return res;
            }

            public string GetPath()
            {
                return path_;
            }
            public IntPtr GetHandle()
            {
                return hFile_;
            }

            public virtual bool Open()
            {
                return this.Open(AccessType.READ);
            }

            public bool Open(AccessType typeAccess)
            {
                if (hFile_ != null)
                {
                    this.Close();
                }

                uint access = typeAccess == AccessType.READ ? GENERIC_READ : (uint)(GENERIC_READ | GENERIC_WRITE);
                hFile_ = global::CreateFile(path_,access, FILE_SHARE_READ,null,OPEN_EXISTING, FILE_ATTRIBUTE_NORMAL,null);
                if (hFile_ == INVALID_HANDLE_VALUE)
                {
                    hFile_ = null;
                    return false;
                }
                return true;
            }

            public bool Create()
            {
                if (hFile_ != null)
                {
                    this.Close();
                }
                hFile_ = CreateFile(path_,GENERIC_READ | GENERIC_WRITE, FILE_SHARE_READ,null,CREATE_ALWAYS, FILE_ATTRIBUTE_NORMAL,null);
                if (hFile_ == INVALID_HANDLE_VALUE)
                {
                    hFile_ = null;
                    return false;
                }
                return true;
            }

            public void Close()
            {
                if (hFile_ != null)
                {
                    CloseHandle(hFile_);
                }
                hFile_ = null;
            }

            public override uint Write(object buf, uint size)
            {
                uint res = 0;
                global::WriteFile(hFile_, buf, size, res, null);
                return res;
            }

            public override uint Read(object buf, uint size)
            {
                uint res = 0;
                global::ReadFile(hFile_, buf, size, res, null);
                return res;
            }

            public bool SetFilePointerBegin()
            {
                return (global::SetFilePointer(hFile_,0,null,FILE_BEGIN) != 0xFFFFFFFF);
            }
            public bool SetFilePointerEnd()
            {
                return (global::SetFilePointer(hFile_,0,null,FILE_END) != 0xFFFFFFFF);
            }
            public bool Seek(int offset, uint seek = FILE_BEGIN)
            {
                return (global::SetFilePointer(hFile_,offset,null,seek) != 0xFFFFFFFF);
            }
            public int GetFilePointer()
            {
                return global::SetFilePointer(hFile_, 0, null, FILE_CURRENT);
            }

            public static bool IsEqualsPath(string path1, string path2)
            {
                path1 = PathProperty.GetUnique(path1);
                path2 = PathProperty.GetUnique(path2);
                bool res = (wcscmp(path1, path2) == 0);
                return res;
            }

            public static List<string> GetFilePathList(string dir)
            {
                List<string> res = new List<string>();

                WIN32_FIND_DATA data = new WIN32_FIND_DATA();
                IntPtr hFind;
                string findDir = dir + "*.*";
                hFind = FindFirstFile(findDir, data);
                do
                {
                    string name = data.cFileName;
                    if ((data.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) != 0 && (name != ".." && name != "."))
                    {
                        // �f�B���N�g��
                        string tDir = dir + name;
                        tDir += "\\";

                        continue;
                    }
                    if (wcscmp(data.cFileName, "..") == 0 || wcscmp(data.cFileName, ".") == 0)
                    {
                        continue;
                    }

                    // �t�@�C��
                    string path = dir + name;

                    res.Add(path);

                }while (FindNextFile(hFind, data));
                FindClose(hFind);

                return new List<string>(res);
            }

            public static List<string> GetDirectoryPathList(string dir)
            {
                List<string> res = new List<string>();

                WIN32_FIND_DATA data = new WIN32_FIND_DATA();
                IntPtr hFind;
                string findDir = dir + "*.*";
                hFind = FindFirstFile(findDir, data);
                do
                {
                    string name = data.cFileName;
                    if ((data.dwFileAttributes & FILE_ATTRIBUTE_DIRECTORY) != 0 && (name != ".." && name != "."))
                    {
                        // �f�B���N�g��
                        string tDir = dir + name;
                        tDir += "\\";
                        res.Add(tDir);
                        continue;
                    }
                    if (wcscmp(data.cFileName, "..") == 0 || wcscmp(data.cFileName, ".") == 0)
                    {
                        continue;
                    }

                    // �t�@�C��

                }while (FindNextFile(hFind, data));
                FindClose(hFind);

                return new List<string>(res);
            }
    }

    /**********************************************************
    //ArchiveFileEntry
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class FileArchiver;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ArchiveFile;

    public class ArchiveFileEntry : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend FileArchiver;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend ArchiveFile;
            public enum CompressType
            {
                CT_NON,
                CT_COMPRESS
            }

            private string dir_ = "";
            private string name_ = "";
            private CompressType typeCompress_;
            private int sizeData_;
            private int sizeCompressed_;
            private int offset_;
            private string pathArchive_ = "";

            private int _GetEntryRecordSize()
            {
                int res = 0;

                res += sizeof(int);
                res += StringUtility.GetByteSize(dir_);
                res += sizeof(int);
                res += StringUtility.GetByteSize(name_);
                res += sizeof(CompressType);
                res += sizeof(int);
                res += sizeof(int);
                res += sizeof(int);

                return res;
            }

            private void _WriteEntryRecord(ByteBuffer buf)
            {
                buf.WriteInteger(dir_.Length);
                buf.Write(dir_[0], (uint)StringUtility.GetByteSize(dir_));
                buf.WriteInteger(name_.Length);
                buf.Write(name_[0], (uint)StringUtility.GetByteSize(name_));
                buf.Write(typeCompress_, sizeof(CompressType));
                buf.WriteInteger(sizeData_);
                buf.WriteInteger(sizeCompressed_);
                buf.WriteInteger(offset_);
            }

            private void _ReadEntryRecord(ByteBuffer buf)
            {
                dir_.resize(buf.ReadInteger());
                buf.Read(dir_[0], (uint)StringUtility.GetByteSize(dir_));
                name_.resize(buf.ReadInteger());
                buf.Read(name_[0], (uint)StringUtility.GetByteSize(name_));
                buf.Read(typeCompress_, sizeof(CompressType));
                sizeData_ = buf.ReadInteger();
                sizeCompressed_ = buf.ReadInteger();
                offset_ = buf.ReadInteger();
            }

            private void _SetOffset(int offset)
            {
                offset_ = offset;
            }
            private void _SetDataSize(int size)
            {
                sizeData_ = size;
            }
            private void _SetCompressedDataSize(int size)
            {
                sizeCompressed_ = size;
            }
            private void _SetArchivePath(string path)
            {
                pathArchive_ = path;
            }


            /**********************************************************
            //ArchiveFileEntry
            **********************************************************/
            public ArchiveFileEntry()
            {
                typeCompress_ = CompressType.CT_NON;
                sizeData_ = 0;
                sizeCompressed_ = 0;
                offset_ = 0;
            }

            public virtual void Dispose()
            {

            }

            public void SetDirectory(string dir)
            {
                dir_ = dir;
            }
            public string GetDirectory()
            {
                return dir_;
            }
            public void SetName(string name)
            {
                name_ = name;
            }
            public string GetName()
            {
                return name_;
            }
            public void SetCompressType(CompressType type)
            {
                typeCompress_ = type;
            }
            public CompressType GetCompressType()
            {
                return typeCompress_;
            }

            public int GetOffset()
            {
                return offset_;
            }
            public int GetDataSize()
            {
                return sizeData_;
            }
            public int GetCompressedDataSize()
            {
                return sizeCompressed_;
            }

            public string GetArchivePath()
            {
                return pathArchive_;
            }
    }

    /**********************************************************
    //FileArchiver
    **********************************************************/
    public class FileArchiver : System.IDisposable
    {
            private LinkedList<ref_count_ptr<ArchiveFileEntry>> listEntry_ = new LinkedList<ref_count_ptr<ArchiveFileEntry>>();

            /**********************************************************
            //FileArchiver
            **********************************************************/
            public FileArchiver()
            {

            }

            public virtual void Dispose()
            {

            }

            public void AddEntry(ref_count_ptr<ArchiveFileEntry> entry)
            {
                listEntry_.AddLast(entry);
            }
            public bool CreateArchiveFile(string path)
            {
                bool res = true;
                File fileArchive = new File(path);
                if (!fileArchive.Create())
                {
                    throw new gstd.wexception(StringUtility.Format("�t�@�C���쐬���s[%s]", path));
                }

                fileArchive.Write((string)GlobalMembers.HEADER_ARCHIVEFILE[0], (uint)GlobalMembers.HEADER_ARCHIVEFILE.Length);
                fileArchive.WriteInteger(listEntry_.Count);

                int posArchiveEntryHeaderStart = fileArchive.GetFilePointer();
                fileArchive.WriteBoolean(false);
                fileArchive.WriteInteger(0);

                int posEntryStart = fileArchive.GetFilePointer();

                LinkedList<ref_count_ptr<ArchiveFileEntry>>.Enumerator itr;
                for (itr = listEntry_.GetEnumerator(); itr.MoveNext();)
                {
                    ref_count_ptr<ArchiveFileEntry> entry = itr.Current;

                    string name = entry.GetName();
                    entry.SetName(PathProperty.GetFileName(name));

                    fileArchive.WriteInteger(entry._GetEntryRecordSize());

                    ByteBuffer buf = new ByteBuffer();
                    entry._WriteEntryRecord(buf);
                    fileArchive.Write(buf.GetPointer(), (uint)buf.GetSize());

                    entry.SetName(name);
                }
                int posEntryEnd = fileArchive.GetFilePointer();

                for (itr = listEntry_.GetEnumerator(); itr.MoveNext();)
                {
                    ref_count_ptr<ArchiveFileEntry> entry = itr.Current;
                    string path = entry.GetName();
                    File file = new File(path);
                    if (!file.Open())
                    {
                        throw new gstd.wexception(StringUtility.Format("�t�@�C���I�[�v�����s[%s]", path));
                    }

                    entry._SetDataSize(file.GetSize());
                    entry._SetOffset(fileArchive.GetFilePointer());
                    ByteBuffer buf = new ByteBuffer();
                    buf.SetSize(file.GetSize());
                    file.Read(buf.GetPointer(), (uint)buf.GetSize());

                    ArchiveFileEntry.CompressType typeCompress = entry.GetCompressType();
                    if (typeCompress == ArchiveFileEntry.CT_NON)
                    {
                        fileArchive.Write(buf.GetPointer(), (uint)buf.GetSize());
                    }
                    else if (typeCompress == ArchiveFileEntry.CT_COMPRESS)
                    {
                        ByteBuffer bufComp = new ByteBuffer();
                        Compressor inflater = new Compressor();
                        inflater.Compress(buf, bufComp);

                        entry._SetCompressedDataSize(bufComp.GetSize());
                        fileArchive.Write(bufComp.GetPointer(), (uint)bufComp.GetSize());
                    }
                }

                // �Ƃ肠�����񈳏k�ŏ�������
                fileArchive.Seek(posArchiveEntryHeaderStart);
                fileArchive.WriteBoolean(false);
                fileArchive.WriteInteger(0);
                for (itr = listEntry_.GetEnumerator(); itr.MoveNext();)
                {
                    ref_count_ptr<ArchiveFileEntry> entry = itr.Current;

                    string name = entry.GetName();
                    entry.SetName(PathProperty.GetFileName(name));

                    fileArchive.WriteInteger(entry._GetEntryRecordSize());

                    ByteBuffer buf = new ByteBuffer();
                    entry._WriteEntryRecord(buf);
                    fileArchive.Write(buf.GetPointer(), (uint)buf.GetSize());

                    entry.SetName(name);
                }

                // ���k�\�����ׂ�
                fileArchive.Seek(posEntryStart);
                int sizeEntry = posEntryEnd - posEntryStart;
                ByteBuffer bufEntryIn = new ByteBuffer();
                ByteBuffer bufEntryOut = new ByteBuffer();
                bufEntryIn.SetSize(sizeEntry);
                fileArchive.Read(bufEntryIn.GetPointer(), (uint)sizeEntry);

                Compressor compEntry = new Compressor();
                compEntry.Compress(bufEntryIn, bufEntryOut);
                if (bufEntryOut.GetSize() < sizeEntry)
                {
                    // �G���g�����k
                    fileArchive.Seek(posArchiveEntryHeaderStart);
                    fileArchive.WriteBoolean(true);
                    fileArchive.WriteInteger(bufEntryOut.GetSize());
                    fileArchive.Write(bufEntryOut.GetPointer(), (uint)bufEntryOut.GetSize());

                    int sizeGap = sizeEntry - bufEntryOut.GetSize();
                    ByteBuffer bufGap = new ByteBuffer();
                    bufGap.SetSize(sizeGap);
                    fileArchive.Write(bufGap.GetPointer(), (uint)sizeGap);
                }

                return res;
            }
    }

    /**********************************************************
    //ArchiveFile
    **********************************************************/
    public class ArchiveFile : System.IDisposable
    {
            private ref_count_ptr<File> file_ = new ref_count_ptr<File>();
            private std::multimap<string, ref_count_ptr<ArchiveFileEntry>> mapEntry_ = new std::multimap<string, ref_count_ptr<ArchiveFileEntry>>();


            /**********************************************************
            //ArchiveFile
            **********************************************************/
            public ArchiveFile(string path)
            {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                file_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new File(path);
            }

            public virtual void Dispose()
            {
                Close();
            }

            public bool Open()
            {
                if (!file_.Open())
                {
                    return false;
                }
                if (mapEntry_.size() != 0)
                {
                    return true;
                }

                bool res = true;
                try
                {
                    string header;
                    header.resize(GlobalMembers.HEADER_ARCHIVEFILE.Length);
                    file_.Read(header[0], header.Length);
                    if (header != GlobalMembers.HEADER_ARCHIVEFILE)
                    {
                        throw new gstd.wexception();
                    }

                    int countEntry = file_.ReadInteger();
                    bool bCompress = file_.ReadBoolean();
                    int sizeArchiveHeader = file_.ReadInteger();

                    ref_count_ptr<Reader> reader = null;
                    if (!bCompress)
                    {
                        reader.CopyFrom(file_);
                    }
                    else
                    {
                        ByteBuffer bufIn = new ByteBuffer();
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        ByteBuffer bufOut = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ByteBuffer();
                        bufIn.SetSize(sizeArchiveHeader);
                        file_.Read(bufIn.GetPointer(), sizeArchiveHeader);
                        DeCompressor decomp = new DeCompressor();
                        decomp.DeCompress(bufIn, bufOut);

                        reader = bufOut;
                    }

                    for (int iEntry = 0 ; iEntry < countEntry ; iEntry++)
                    {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        ref_count_ptr<ArchiveFileEntry> entry = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ArchiveFileEntry();
                        int sizeEntry = reader.ReadInteger();
                        ByteBuffer buf = new ByteBuffer();
                        buf.SetSize(sizeEntry);
                        reader.Read(buf.GetPointer(), sizeEntry);
                        entry._ReadEntryRecord(buf);
                        entry._SetArchivePath(file_.GetPath());

                        // std::string key = entry->GetDirectory() + entry->GetName();
                        // mapEntry_[key] = entry;
                        string key = entry.GetName();
                        mapEntry_.insert(new Tuple<string, new ref_count_ptr<ArchiveFileEntry>>(key, entry));

                    }

                    res = true;
                }
                catch
                {
                    res = false;
                }
                file_.Close();
                return res;
            }

            public void Close()
            {
                file_.Close();
            }

            public SortedSet<string> GetKeyList()
            {
                SortedSet<string> res = new SortedSet<string>();
                std::multimap<string, ref_count_ptr<ArchiveFileEntry>>.iterator itr = mapEntry_.begin();
                for (; itr != mapEntry_.end() ; itr++)
                {
                    ref_count_ptr<ArchiveFileEntry> entry = itr.second;
                    // std::wstring key = entry->GetDirectory() + entry->GetName();
                    string key = entry.GetName();
                    res.Add(key);
                }
                return new SortedSet<string>(res);
            }

            public std::multimap<string, ref_count_ptr<ArchiveFileEntry>> GetEntryMap()
            {
                return new std::multimap<string, ref_count_ptr<ArchiveFileEntry>>(mapEntry_);
            }
            public List<ref_count_ptr<ArchiveFileEntry>> GetEntryList(string name)
            {
                List<ref_count_ptr<ArchiveFileEntry>> res = new List<new ref_count_ptr<ArchiveFileEntry>>();
                if (!IsExists(name))
                {
                    return new List<ref_count_ptr<ArchiveFileEntry>>(res);
                }

                Tuple<std::multimap<string, ref_count_ptr<ArchiveFileEntry>>.iterator, std::multimap<string, ref_count_ptr<ArchiveFileEntry>>.iterator> itrPair = mapEntry_.equal_range(name);
                for (; itrPair.Item1 != itrPair.Item2 ; itrPair.Item1++)
                {
                    ref_count_ptr<ArchiveFileEntry> entry = (itrPair.Item1).second;
                    res.Add(entry);
                }

                return new List<ref_count_ptr<ArchiveFileEntry>>(res);
            }

            public bool IsExists(string name)
            {
                return mapEntry_.find(name) != mapEntry_.end();
            }

            public static ref_count_ptr<ByteBuffer> CreateEntryBuffer(ref_count_ptr<ArchiveFileEntry> entry)
            {
                ref_count_ptr<ByteBuffer> res = new ref_count_ptr<ByteBuffer>();
                File file = new File(entry.GetArchivePath());
                if (file.Open())
                {
                    if (entry.GetCompressType() == ArchiveFileEntry.CT_NON)
                    {
                        file.Seek(entry.GetOffset());
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        res = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ByteBuffer();
                        int size = entry.GetDataSize();
                        res.SetSize(size);
                        file.Read(res.GetPointer(), (uint)size);
                    }
                    else if (entry.GetCompressType() == ArchiveFileEntry.CT_COMPRESS)
                    {
                        file.Seek(entry.GetOffset());
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        res = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ByteBuffer();

                        ByteBuffer bufComp = new ByteBuffer();
                        bufComp.SetSize(entry.GetCompressedDataSize());
                        file.Read(bufComp.GetPointer(), (uint)bufComp.GetSize());

                        gstd.DeCompressor deflater = new gstd.DeCompressor();
                        deflater.DeCompress(bufComp, res.GetPointer());
                    }
                }
                return new ref_count_ptr<ByteBuffer>(res);
            }

            // ref_count_ptr<ByteBuffer> GetBuffer(std::string name);
    }

    /**********************************************************
    //FileManager
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class ManagedFileReader;
    public class FileManager : System.IDisposable
    {
            public class LoadObject
            {
                    public virtual void Dispose()
                    {
                    }
            }
            public class LoadThread : Thread
            {
                private gstd.CriticalSection lockEvent_ = new gstd.CriticalSection();
                private gstd.CriticalSection lockListener_ = new gstd.CriticalSection();
                private gstd.ThreadSignal signal_ = new gstd.ThreadSignal();
                    protected virtual void _Run()
                    {
                        while (this.GetStatus() == RUN)
                        {
                            signal_.Wait(10);

                            while (this.GetStatus() == RUN)
                            {
                                // Logger::WriteTop(StringUtility::Format("���[�h�C�x���g���o���J�n"));
                                ref_count_ptr<FileManager.LoadThreadEvent> @event = null;
                                {
                                    Lock @lock = new Lock(lockEvent_);
                                    if (listEvent_.size() == 0)
                                    {
                                        break;
                                    }
                                    @event = listEvent_.front();
                                    // listPath_.erase(event->GetPath());
                                    listEvent_.pop_front();
                                }
                                // Logger::WriteTop(StringUtility::Format("���[�h�C�x���g���o�������F%s", event->GetPath().c_str()));

                                {
                                // Logger::WriteTop(StringUtility::Format("���[�h�J�n�F%s", event->GetPath().c_str()));
                                    Lock @lock = new Lock(lockListener_);
                                    LinkedList<FileManager.LoadThreadListener>.Enumerator itr;
                                    for (itr = listListener_.begin(); itr.MoveNext();)
                                    {
                                        FileManager.LoadThreadListener listener = itr.Current;
                                        if (@event.GetListener() == listener)
                                        {
                                            listener.CallFromLoadThread(@event);
                                        }
                                    }
                                }
                                // Logger::WriteTop(StringUtility::Format("���[�h�����F%s", event->GetPath().c_str()));

                            }
                            Sleep(1); // TODO �Ȃ����ҋ@�����Ɨ����Â炢�H
                        }

                        {
                            Lock @lock = new Lock(lockListener_);
                            listListener_.clear();
                        }
                    }

                    // std::set<std::string> listPath_;
                    protected LinkedList<ref_count_ptr<FileManager.LoadThreadEvent>> listEvent_ = new LinkedList<ref_count_ptr<FileManager.LoadThreadEvent>>();
                    protected LinkedList<FileManager.LoadThreadListener> listListener_ = new LinkedList<FileManager.LoadThreadListener>();

                    // FileManager::LoadThread
                    public LoadThread()
                    {
                    }

                    public virtual void Dispose()
                    {
                    }

                    public virtual void Stop()
                    {
                        Thread.Stop();
                        signal_.SetSignal();
                    }

                    public bool IsThreadLoadComplete()
                    {
                        bool res = false;
                        {
                            Lock @lock = new Lock(lockEvent_);
                            res = listEvent_.size() == 0;
                        }
                        return res;
                    }

                    public bool IsThreadLoadExists(string path)
                    {
                        bool res = false;
                        {
                            Lock @lock = new Lock(lockEvent_);
                            // res = listPath_.find(path) != listPath_.end();
                        }
                        return res;
                    }

                    public void AddEvent(ref_count_ptr<FileManager.LoadThreadEvent> @event)
                    {
                        {
                            Lock @lock = new Lock(lockEvent_);
                            string path = @event.GetPath();
                            if (IsThreadLoadExists(path))
                            {
                                return;
                            }
                            listEvent_.push_back(@event);
                            // listPath_.insert(path);
                            signal_.SetSignal();
                            signal_.SetSignal(false);
                        }
                    }

                    public void AddListener(FileManager.LoadThreadListener listener)
                    {
                        {
                            Lock @lock = new Lock(lockListener_);
                            LinkedList<FileManager.LoadThreadListener>.Enumerator itr;
                            for (itr = listListener_.begin(); itr.MoveNext();)
                            {
                                if (itr.Current == listener)
                                {
                                    return;
                                }
                            }

                            listListener_.push_back(listener);
                        }
                    }

                    public void RemoveListener(FileManager.LoadThreadListener listener)
                    {
                        {
                            Lock @lock = new Lock(lockListener_);
                            LinkedList<FileManager.LoadThreadListener>.Enumerator itr;
                            for (itr = listListener_.begin(); itr.MoveNext();)
                            {
                                if (itr.Current != listener)
                                {
                                    continue;
                                }
                                listListener_.erase(itr);
                                break;
                            }
                        }
                    }
            }
            public class LoadThreadListener
            {
                    public virtual void Dispose()
                    {
                    }
                    public abstract void CallFromLoadThread(ref_count_ptr<FileManager.LoadThreadEvent> @event);
            }
            public class LoadThreadEvent
            {
                    protected FileManager.LoadThreadListener listener_;
                    protected string path_ = "";
                    protected ref_count_ptr<FileManager.LoadObject> source_ = new ref_count_ptr<FileManager.LoadObject>();
                    public LoadThreadEvent(FileManager.LoadThreadListener listener, string path, ref_count_ptr<FileManager.LoadObject> source)
                    {
                        listener_ = listener;
                        path_ = path;
                        source_ = source;
                    }
                    public virtual void Dispose()
                    {
                    }

                    public FileManager.LoadThreadListener GetListener()
                    {
                        return listener_;
                    }
                    public string GetPath()
                    {
                        return path_;
                    }
                    public ref_count_ptr<FileManager.LoadObject> GetSource()
                    {
                        return source_;
                    }
            }
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend ManagedFileReader;
            private static FileManager thisBase_ = null;
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected gstd.ref_count_ptr<LoadThread> threadLoad_ = new gstd.ref_count_ptr<LoadThread>();
            protected SortedDictionary<string, ref_count_ptr<ArchiveFile>> mapArchiveFile_ = new SortedDictionary<string, ref_count_ptr<ArchiveFile>>();
            protected SortedDictionary<string, ref_count_ptr<ByteBuffer>> mapByteBuffer_ = new SortedDictionary<string, ref_count_ptr<ByteBuffer>>();

            protected ref_count_ptr<ByteBuffer> _GetByteBuffer(ref_count_ptr<ArchiveFileEntry> entry)
            {
                ref_count_ptr<ByteBuffer> res = null;
                try
                {
                    Lock @lock = new Lock(lock_);
                    string key = entry.GetDirectory() + entry.GetName();
                    if (mapByteBuffer_.ContainsKey(key))
                    {
                        res.CopyFrom(mapByteBuffer_[key]);
                    }
                    else
                    {
                        res.CopyFrom(ArchiveFile.CreateEntryBuffer(new ref_count_ptr<ArchiveFileEntry>(entry)));
                        if (res != null)
                        {
                            mapByteBuffer_[key].CopyFrom(res);
                        }
                    }
                }
                catch
                {
                }

                return new ref_count_ptr<ByteBuffer>(res);
            }

            protected void _ReleaseByteBuffer(ref_count_ptr<ArchiveFileEntry> entry)
            {
                {
                    Lock @lock = new Lock(lock_);
                    string key = entry.GetDirectory() + entry.GetName();
                    if (!mapByteBuffer_.ContainsKey(key))
                    {
                        return;
                    }
                    ref_count_ptr<ByteBuffer> buffer = mapByteBuffer_[key];
                    if (buffer.GetReferenceCount() == 2)
                    {
                        mapByteBuffer_.Remove(key);
                    }
                }
            }

            public static FileManager GetBase()
            {
                return thisBase_;
            }
            /*
            ref_count_ptr<ByteBuffer> ArchiveFile::GetBuffer(std::string name)
            {
            	if(!IsExists(name))return NULL;
            
            	if(!file_->Open())return NULL;
            
            	ref_count_ptr<ByteBuffer> res = new ByteBuffer();
            	ref_count_ptr<ArchiveFileEntry> entry = mapEntry_[name];
            	int offset = entry->GetOffset();
            	int size = entry->GetDataSize();
            
            	res->SetSize(size);
            	file_->Seek(offset);
            	file_->Read(res->GetPointer(), size);
            
            	file_->Close();
            	return res;
            }
            */

            /**********************************************************
            //FileManager
            **********************************************************/
            public FileManager()
            {
            }

            public virtual void Dispose()
            {
                EndLoadThread();
            }

            public virtual bool Initialize()
            {
                if (thisBase_ != null)
                {
                    return false;
                }
                thisBase_ = this;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                threadLoad_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new LoadThread();
                threadLoad_.Start();
                return true;
            }

            public void EndLoadThread()
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (threadLoad_ == null)
                    {
                        return;
                    }
                    threadLoad_.Stop();
                    threadLoad_.Join();
                    threadLoad_ = null;
                }
            }

            public bool AddArchiveFile(string path)
            {
                if (mapArchiveFile_.ContainsKey(path))
                {
                    return true;
                }

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<ArchiveFile> file = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ArchiveFile(path);
                if (!file.Open())
                {
                    return false;
                }

                SortedSet<string> listKeyIn = file.GetKeyList();
                SortedSet<string> listKeyCurrent = new SortedSet<string>();
                SortedDictionary<string, ref_count_ptr<ArchiveFile>>.Enumerator itrFile;
                for (itrFile = mapArchiveFile_.GetEnumerator(); itrFile.MoveNext();)
                {
                    ref_count_ptr<ArchiveFile> tFile = itrFile.Current.Value;
                    SortedSet<string> tList = tFile.GetKeyList();
                    SortedSet<string>.Enumerator itrList = tList.GetEnumerator();
                    while (itrList.MoveNext())
                    {
                        listKeyCurrent.insertitrList.Current;
                    }
                }

                SortedSet<string>.Enumerator itrKey = listKeyIn.GetEnumerator();
                while (itrKey.MoveNext())
                {
                    string key = itrKey.Current;
                    if (listKeyCurrent.find(key) == listKeyCurrent.end())
                    {
                        continue;
                    }

                    string log = StringUtility.Format("archive file entry already exists[%s]", key);
                    Logger.WriteTop(log);
                    throw new wexception(log);
                }

                mapArchiveFile_[path].CopyFrom(file);
                return true;
            }

            public bool RemoveArchiveFile(string path)
            {
                mapArchiveFile_.Remove(path);
                return true;
            }

            public ref_count_ptr<FileReader> GetFileReader(string path)
            {
                string orgPath = path;
                path = PathProperty.GetUnique(path);

                ref_count_ptr<FileReader> res = null;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<File> fileRaw = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new File(path);
                if (fileRaw.IsExists())
                {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                    res = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ManagedFileReader(fileRaw, null);
                }
                else
                {
                    List<ref_count_ptr<ArchiveFileEntry>> listEntry = new List<new ref_count_ptr<ArchiveFileEntry>>();

                    SortedDictionary<int, string> mapArchivePath = new SortedDictionary<int, string>();
                    string key = PathProperty.GetFileName(path);
                    SortedDictionary<string, ref_count_ptr<ArchiveFile>>.Enumerator itr;
                    for (itr = mapArchiveFile_.GetEnumerator(); itr.MoveNext();)
                    {
                        string pathArchive = itr.Current.Key;
                        ref_count_ptr<ArchiveFile> fileArchive = itr.Current.Value;
                        if (!fileArchive.IsExists(key))
                        {
                            continue;
                        }

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        ref_count_ptr<File> file = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new File(pathArchive);
                        List<ref_count_ptr<ArchiveFileEntry>> list = fileArchive.GetEntryList(key);
                        listEntry.AddRange(list);
                        for (int iEntry = 0 ; iEntry < list.Count ; iEntry++)
                        {
                            ref_count_ptr<ArchiveFileEntry> entry = list[iEntry];
                            int addr = (int)entry.GetPointer();
                            mapArchivePath[addr] = pathArchive;
                        }
                    }

                    if (listEntry.Count == 1)
                    {
                        ref_count_ptr<ArchiveFileEntry> entry = listEntry[0];
                        int addr = (int)entry.GetPointer();
                        string pathArchive = mapArchivePath[addr];
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        ref_count_ptr<File> file = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new File(pathArchive);
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                        res = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ManagedFileReader(file, entry);
                    }
                    else
                    {
                        string module = PathProperty.GetModuleDirectory();
                        module = PathProperty.GetUnique(module);

                        string target = StringUtility.ReplaceAll(path, module, "");
                        for (int iEntry = 0 ; iEntry < listEntry.Count ; iEntry++)
                        {
                            ref_count_ptr<ArchiveFileEntry> entry = listEntry[iEntry];
                            string dir = entry.GetDirectory();
                            if (target.IndexOf(dir) == -1)
                            {
                                continue;
                            }

                            int addr = (int)entry.GetPointer();
                            string pathArchive = mapArchivePath[addr];
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                            ref_count_ptr<File> file = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new File(pathArchive);
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                            res = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ManagedFileReader(file, entry);
                            break;
                        }
                    }

                }
                if (res != null)
                {
                    res._SetOriginalPath(orgPath);
                }
                return new ref_count_ptr<FileReader>(res);
            }

            public void AddLoadThreadEvent(ref_count_ptr<FileManager.LoadThreadEvent> @event)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (threadLoad_ == null)
                    {
                        return;
                    }
                    threadLoad_.AddEvent(@event);
                }
            }

            public void AddLoadThreadListener(FileManager.LoadThreadListener listener)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (threadLoad_ == null)
                    {
                        return;
                    }
                    threadLoad_.AddListener(listener);
                }
            }

            public void RemoveLoadThreadListener(FileManager.LoadThreadListener listener)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (threadLoad_ == null)
                    {
                        return;
                    }
                    threadLoad_.RemoveListener(listener);
                }
            }

            public void WaitForThreadLoadComplete()
            {
                while (!threadLoad_.IsThreadLoadComplete())
                {
                    Sleep(1);
                }
            }
    }





    /**********************************************************
    //ManagedFileReader
    **********************************************************/
    public class ManagedFileReader : FileReader
    {
            private FILETYPE type_;
            private ref_count_ptr<File> file_ = new ref_count_ptr<File>();
            private ref_count_ptr<ArchiveFileEntry> entry_ = new ref_count_ptr<ArchiveFileEntry>();
            private ref_count_ptr<ByteBuffer> buffer_ = new ref_count_ptr<ByteBuffer>();
            private int offset_;


            /**********************************************************
            //ManagedFileReader
            **********************************************************/
            public ManagedFileReader(ref_count_ptr<File> file, ref_count_ptr<ArchiveFileEntry> entry)
            {
                offset_ = 0;
                file_.CopyFrom(file);
                entry_.CopyFrom(entry);

                if (entry_ == null)
                {
                    type_ = FILETYPE.TYPE_NORMAL;
                }
                else if (entry_.GetCompressType() == ArchiveFileEntry.CT_NON && entry_ != null)
                {
                    type_ = FILETYPE.TYPE_ARCHIVED;
                }
                else if (entry_.GetCompressType() != ArchiveFileEntry.CT_NON && entry_ != null)
                {
                    type_ = FILETYPE.TYPE_ARCHIVED_COMPRESSED;
                }
            }

            public new void Dispose()
            {
                Close();
                base.Dispose();
            }

            public override bool Open()
            {
                bool res = false;
                offset_ = 0;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.Open();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    res = file_.Open();
                    if (res)
                    {
                        file_.Seek(entry_.GetOffset());
                    }
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED)
                {
                    buffer_.CopyFrom(FileManager.GetBase()._GetByteBuffer(entry_));
                    res = buffer_ != null;
                }
                return res;
            }

            public override void Close()
            {
                if (file_ != null)
                {
                    file_.Close();
                }
                if (buffer_ != null)
                {
                    buffer_ = null;
                    FileManager.GetBase()._ReleaseByteBuffer(entry_);
                }
            }

            public override int GetFileSize()
            {
                int res = 0;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.GetSize();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    res = entry_.GetDataSize();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED && buffer_ != null)
                {
                    res = buffer_.GetSize();
                }
                return res;
            }

            public override uint Read(object buf, uint size)
            {
                uint res = 0;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.Read(buf, size);
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    int read = (int)size;
                    if (entry_.GetDataSize() < offset_ + size)
                    {
                        read = entry_.GetDataSize() - offset_;
                    }
                    res = file_.Read(buf, read);
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED)
                {
                    int read = (int)size;
                    if (buffer_.GetSize() < offset_ + size)
                    {
                        read = buffer_.GetSize() - offset_;
                    }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(buf, buffer_.GetPointer()[offset_], read);
                    res = (uint)read;
                }
                offset_ += res;
                return res;
            }

            public override bool SetFilePointerBegin()
            {
                bool res = false;
                offset_ = 0;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.SetFilePointerBegin();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    res = file_.Seek(entry_.GetOffset());
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED)
                {

                }
                return res;
            }

            public override bool SetFilePointerEnd()
            {
                bool res = false;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.SetFilePointerEnd();
                    offset_ = file_.GetSize();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    res = file_.Seek(entry_.GetOffset() + entry_.GetDataSize());
                    offset_ = entry_.GetDataSize();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED)
                {
                    if (buffer_ != null)
                    {
                        offset_ = buffer_.GetSize();
                        res = true;
                    }
                }
                return res;
            }

            public override bool Seek(int offset)
            {
                bool res = false;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.Seek(offset);
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    res = file_.Seek(entry_.GetOffset() + offset);
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED)
                {
                    if (buffer_ != null)
                    {
                        res = true;
                    }
                }
                if (res == true)
                {
                    offset_ = offset;
                }
                return res;
            }

            public override int GetFilePointer()
            {
                int res = 0;
                if (type_ == FILETYPE.TYPE_NORMAL)
                {
                    res = file_.GetFilePointer();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED)
                {
                    res = file_.GetFilePointer() - entry_.GetOffset();
                }
                else if (type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED)
                {
                    if (buffer_ != null)
                    {
                        res = offset_;
                    }
                }
                return res;
            }

            public override bool IsArchived()
            {
                return type_ != FILETYPE.TYPE_NORMAL;
            }

            public override bool IsCompressed()
            {
                return type_ == FILETYPE.TYPE_ARCHIVED_COMPRESSED;
            }
    }


    /**********************************************************
    //Recordable
    **********************************************************/
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class Recordable;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class RecordEntry;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class RecordBuffer;
    public abstract class Recordable : System.IDisposable
    {
            public virtual void Dispose()
            {
            }
            public abstract void Read(RecordBuffer record);
            public abstract void Write(RecordBuffer record);
    }

    /**********************************************************
    //RecordEntry
    **********************************************************/
    public class RecordEntry : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend RecordBuffer;
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                TYPE_NOENTRY = -2,
                TYPE_UNKNOWN = -1,
                TYPE_BOOLEAN = 1,
                TYPE_INTEGER = 2,
                TYPE_FLOAT = 3,
                TYPE_DOUBLE = 4,
                TYPE_STRING_A = 5,
                TYPE_RECORD = 6,
                TYPE_STRING_W = 7
            }

            private char type_;
            private string key_ = "";
            private ByteBuffer buffer_ = new ByteBuffer();

            private int _GetEntryRecordSize()
            {
                int res = 0;
                res += sizeof(char);
                res += sizeof(int);
                res += key_.Length;
                res += sizeof(int);
                res += buffer_.GetSize();
                return res;
            }

            private void _WriteEntryRecord(Writer writer)
            {
                writer.WriteCharacter(type_);
                writer.WriteInteger(key_.Length);
                writer.Write(key_[0], (uint)key_.Length);

                writer.WriteInteger(buffer_.GetSize());
                writer.Write(buffer_.GetPointer(), (uint)buffer_.GetSize());
            }

            private void _ReadEntryRecord(Reader reader)
            {
                type_ = reader.ReadCharacter();
                key_.resize(reader.ReadInteger());
                reader.Read(key_[0], (uint)key_.Length);

                buffer_.Clear();
                buffer_.SetSize(reader.ReadInteger());
                reader.Read(buffer_.GetPointer(), (uint)buffer_.GetSize());
            }


            /**********************************************************
            //RecordEntry
            **********************************************************/
            public RecordEntry()
            {
                type_ = AnonymousEnum.TYPE_UNKNOWN;
            }

            public virtual void Dispose()
            {

            }

            public char GetType()
            {
                return type_;
            }

            public void SetKey(string key)
            {
                key_ = key;
            }
            public void SetType(char type)
            {
                type_ = type;
            }
            public string GetKey()
            {
                return key_;
            }
            public ByteBuffer GetBufferRef()
            {
                return new gstd.ByteBuffer(buffer_);
            }
    }

    /**********************************************************
    //RecordBuffer
    **********************************************************/
    public class RecordBuffer : Recordable
    {
            private SortedDictionary<string, ref_count_ptr<RecordEntry>> mapEntry_ = new SortedDictionary<string, ref_count_ptr<RecordEntry>>();


            /**********************************************************
            //RecordBuffer
            **********************************************************/
            public RecordBuffer()
            {

            }

            public override void Dispose()
            {
                this.Clear();
                base.Dispose();
            }

            public void Clear()
            {
                mapEntry_.Clear();
            }

            public int GetEntryCount()
            {
                return mapEntry_.Count;
            }
            public bool IsExists(string key)
            {
                return mapEntry_.ContainsKey(key);
            }

            public List<string> GetKeyList()
            {
                List<string> res = new List<string>();
                SortedDictionary<string, ref_count_ptr<RecordEntry>>.Enumerator itr;
                for (itr = mapEntry_.GetEnumerator(); itr.MoveNext();)
                {
                    string key = itr.Current.Key;
                    res.Add(key);
                }
                return new List<string>(res);
            }

            public ref_count_ptr<RecordEntry> GetEntry(string key)
            {
                return IsExists(key) ? mapEntry_[key] : null;
            }

            public void Write(Writer writer)
            {
                int countEntry = mapEntry_.Count;
                writer.WriteInteger(countEntry);

                SortedDictionary<string, ref_count_ptr<RecordEntry>>.Enumerator itr;
                for (itr = mapEntry_.GetEnumerator(); itr.MoveNext();)
                {
                    ref_count_ptr<RecordEntry> entry = itr.Current.Value;
                    entry._WriteEntryRecord(writer);
                }
            }

            public void Read(Reader reader)
            {
                this.Clear();
                int countEntry = reader.ReadInteger();
                for (int iEntry = 0 ; iEntry < countEntry; iEntry++)
                {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                    ref_count_ptr<RecordEntry> entry = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new RecordEntry();
                    entry._ReadEntryRecord(reader);

                    string key = entry.GetKey();
                    mapEntry_[key].CopyFrom(entry);
                }
            }

            public bool WriteToFile(string path, string header = HEADER_RECORDFILE)
            {
                File file = new File(path);
                if (!file.Create())
                {
                    return false;
                }

                file.Write((string) header[0], (uint)header.Length);
                Write(file);
                file.Close();

                return true;
            }

            public bool ReadFromFile(string path, string header = HEADER_RECORDFILE)
            {
                File file = new File(path);
                if (!file.Open())
                {
                    return false;
                }

                string fHead;
                fHead.resize(header.Length);
                file.Read(fHead[0], (uint)fHead.Length);
                if (fHead != header)
                {
                    return false;
                }

                Read(file);
                file.Close();

                return true;
            }

            // �G���g��
            public int GetEntryType(string key)
            {
                if (!IsExists(key))
                {
                    return RecordEntry.TYPE_NOENTRY;
                }
                return mapEntry_[key].GetType();
            }

            public int GetEntrySize(string key)
            {
                if (!IsExists(key))
                {
                    return 0;
                }
                ByteBuffer buffer = mapEntry_[key].GetBufferRef();
                return buffer.GetSize();
            }

            // �G���g���擾(������L�[)
            public bool GetRecord(string key, object buf, uint size)
            {
                if (!IsExists(key))
                {
                    return false;
                }
                ByteBuffer buffer = mapEntry_[key].GetBufferRef();
                buffer.Seek(0);
                buffer.Read(buf, size);
                return true;
            }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public bool GetRecord<T>(string key, T data)
            {
                return GetRecord(key, data, sizeof(T));
            }
            public bool GetRecordAsBoolean(string key)
            {
                bool res = false;
                GetRecord(key, res);
                return res;
            }

            public int GetRecordAsInteger(string key)
            {
                int res = 0;
                GetRecord(key, res);
                return res;
            }

            public float GetRecordAsFloat(string key)
            {
                float res = 0F;
                GetRecord(key, res);
                return res;
            }

            public double GetRecordAsDouble(string key)
            {
                double res = 0;
                GetRecord(key, res);
                return res;
            }

            public string GetRecordAsStringA(string key)
            {
                if (!IsExists(key))
                {
                    return "";
                }

                string res;
                ref_count_ptr<RecordEntry> entry = mapEntry_[key];
                int type = entry.GetType();
                ByteBuffer buffer = entry.GetBufferRef();
                buffer.Seek(0);
                if (type == RecordEntry.TYPE_STRING_A)
                {
                    res.resize(buffer.GetSize());
                    buffer.Read(res[0], (uint)buffer.GetSize());
                }
                else if (type == RecordEntry.TYPE_STRING_W)
                {
                    string wstr;
                    wstr.resize(buffer.GetSize() / sizeof(char));
                    buffer.Read(wstr[0], (uint)buffer.GetSize());
                    res = StringUtility.ConvertWideToMulti(wstr);
                }

                return res;
            }

            public string GetRecordAsStringW(string key)
            {
                if (!IsExists(key))
                {
                    return "";
                }

                string res;
                ref_count_ptr<RecordEntry> entry = mapEntry_[key];
                int type = entry.GetType();
                ByteBuffer buffer = entry.GetBufferRef();
                buffer.Seek(0);
                if (type == RecordEntry.TYPE_STRING_A)
                {
                    string str;
                    str.resize(buffer.GetSize());
                    buffer.Read(str[0], (uint)buffer.GetSize());

                    res = StringUtility.ConvertMultiToWide(str);
                }
                else if (type == RecordEntry.TYPE_STRING_W)
                {
                    res.resize(buffer.GetSize() / sizeof(char));
                    buffer.Read(res[0], (uint)buffer.GetSize());
                }

                return res;
            }

            public bool GetRecordAsRecordBuffer(string key, RecordBuffer record)
            {
                if (!IsExists(key))
                {
                    return false;
                }
                ByteBuffer buffer = mapEntry_[key].GetBufferRef();
                buffer.Seek(0);
                record.Read(buffer);
                return true;
            }

            // �G���g���擾(���l�L�[)
            public bool GetRecord(int key, object buf, uint size)
            {
                return GetRecord(StringUtility.Format("%d", key), buf, size);
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public bool GetRecord<T>(int key, T data)
            {
                return GetRecord(StringUtility.Format("%d", key), data);
            }
            public bool GetRecordAsBoolean(int key)
            {
                return GetRecordAsBoolean(StringUtility.Format("%d", key));
            }
            public int GetRecordAsInteger(int key)
            {
                return GetRecordAsInteger(StringUtility.Format("%d", key));
            }
            public float GetRecordAsFloat(int key)
            {
                return GetRecordAsFloat(StringUtility.Format("%d", key));
            }
            public double GetRecordAsDouble(int key)
            {
                return GetRecordAsDouble(StringUtility.Format("%d", key));
            }
            public string GetRecordAsStringA(int key)
            {
                return GetRecordAsStringA(StringUtility.Format("%d", key));
            }
            public string GetRecordAsStringW(int key)
            {
                return GetRecordAsStringW(StringUtility.Format("%d", key));
            }
            public bool GetRecordAsRecordBuffer(int key, RecordBuffer record)
            {
                return GetRecordAsRecordBuffer(StringUtility.Format("%d", key), record);
            }


            // �G���g���ݒ�(������L�[)
            public void SetRecord(string key, object buf, uint size)
            {
                SetRecord(RecordEntry.TYPE_UNKNOWN, key, buf, size);
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public void SetRecord<T>(string key, T data)
            {
                SetRecord(RecordEntry.TYPE_UNKNOWN, key, data, sizeof(T));
            }
            public void SetRecord(int type, string key, object buf, uint size)
            {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<RecordEntry> entry = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new RecordEntry();
                entry.SetType((char)type);
                entry.SetKey(key);
                ByteBuffer buffer = entry.GetBufferRef();
                buffer.SetSize((int)size);
                buffer.Write(buf, size);
                mapEntry_[key].CopyFrom(entry);
            }

// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public void SetRecord<T>(int type, string key, T data)
            {
                SetRecord(type, key, data, sizeof(T));
            }
            public void SetRecordAsBoolean(string key, bool data)
            {
                SetRecord(RecordEntry.TYPE_BOOLEAN, key, data);
            }
            public void SetRecordAsInteger(string key, int data)
            {
                SetRecord(RecordEntry.TYPE_INTEGER, key, data);
            }
            public void SetRecordAsFloat(string key, float data)
            {
                SetRecord(RecordEntry.TYPE_FLOAT, key, data);
            }
            public void SetRecordAsDouble(string key, double data)
            {
                SetRecord(RecordEntry.TYPE_DOUBLE, key, data);
            }
            public void SetRecordAsStringA(string key, string data)
            {
                SetRecord(RecordEntry.TYPE_STRING_A, key, data[0], (uint)data.Length);
            }
            public void SetRecordAsStringW(string key, string data)
            {
                SetRecord(RecordEntry.TYPE_STRING_W, key, data[0], data.Length * sizeof(char));
            }
            public void SetRecordAsRecordBuffer(string key, RecordBuffer record)
            {
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                ref_count_ptr<RecordEntry> entry = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new RecordEntry();
                entry.SetType((char)RecordEntry.TYPE_RECORD);
                entry.SetKey(key);
                ByteBuffer buffer = entry.GetBufferRef();
                record.Write(buffer);
                mapEntry_[key].CopyFrom(entry);
            }

            // �G���g���ݒ�(���l�L�[)
            public void SetRecord(int key, object buf, uint size)
            {
                SetRecord(StringUtility.Format("%d", key), buf, size);
            }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template <typename T>
            public void SetRecord<T>(int key, T data)
            {
                SetRecord(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsBoolean(int key, bool data)
            {
                SetRecordAsInteger(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsInteger(int key, int data)
            {
                SetRecordAsInteger(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsFloat(int key, float data)
            {
                SetRecordAsFloat(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsDouble(int key, double data)
            {
                SetRecordAsDouble(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsStringA(int key, string data)
            {
                SetRecordAsStringA(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsStringW(int key, string data)
            {
                SetRecordAsStringW(StringUtility.Format("%d", key), data);
            }
            public void SetRecordAsRecordBuffer(int key, RecordBuffer record)
            {
                SetRecordAsRecordBuffer(StringUtility.Format("%d", key), record);
            }

            // Recoedable
            public override void Read(RecordBuffer record)
            {
            }

            public override void Write(RecordBuffer record)
            {
            }
    }

    /**********************************************************
    //PropertyFile
    **********************************************************/
    public class PropertyFile : System.IDisposable
    {
            protected SortedDictionary<string, string> mapEntry_ = new SortedDictionary<string, string>();

            /**********************************************************
            //PropertyFile
            **********************************************************/
            public PropertyFile()
            {
            }

            public virtual void Dispose()
            {
            }

            public bool Load(string path)
            {
                mapEntry_.Clear();

                List<char> text = new List<char>();
                FileManager fileManager = FileManager.GetBase();
                if (fileManager != null)
                {
                    ref_count_ptr<FileReader> reader = fileManager.GetFileReader(path);

                    if (reader == null || !reader.Open())
                    {
                        Logger.WriteTop(ErrorUtility.GetFileNotFoundErrorMessage(path));
                        return false;
                    }

                    int size = reader.GetFileSize();
                    text.Resize(size+1);
                    reader.Read(text[0], size);
                    text[size] = '\0';
                }
                else
                {
                    File file = new File(path);
                    if (!file.Open())
                    {
                        return false;
                    }

                    int size = file.GetSize();
                    text.Resize(size+1);
                    file.Read(text[0], (uint)size);
                    text[size] = '\0';
                }

                bool res = false;
                gstd.Scanner scanner = new gstd.Scanner(text);
                try
                {
                    while (scanner.HasNext())
                    {
                        gstd.Token tok = scanner.Next();
                        if (tok.GetType() != Token.TK_ID)
                        {
                            continue;
                        }
                        string key = tok.GetElement();
                        while (true)
                        {
                            tok = scanner.Next();
                            if (tok.GetType() == Token.TK_EQUAL)
                            {
                                break;
                            }
                            key += tok.GetElement();
                        }

                        string value;
                        try
                        {
                            int posS = scanner.GetCurrentPointer();
                            int posE = posS;
                            while (true)
                            {
                                bool bEndLine = false;
                                if (!scanner.HasNext())
                                {
                                    bEndLine = true;
                                }
                                else
                                {
                                    tok = scanner.Next();
                                    bEndLine = tok.GetType() == Token.TK_NEWLINE;
                                }

                                if (bEndLine)
                                {
                                    posE = scanner.GetCurrentPointer();
                                    value = scanner.GetString(posS, posE);
                                    value = StringUtility.Trim(value);
                                    break;
                                }
                            }
                        }
                        catch
                        {
                        }

                        mapEntry_[key] = value;
                    }

                    res = true;
                }
                catch (gstd.wexception e)
                {
                    mapEntry_.Clear();
                    Logger.WriteTop(ErrorUtility.GetParseErrorMessage(path, scanner.GetCurrentLine(), e.what()));
                    res = false;
                }

                return res;
            }

            public bool HasProperty(string key)
            {
                return mapEntry_.ContainsKey(key);
            }

            public string GetString(string key)
            {
                return GetString(key, "");
            }
            public string GetString(string key, string def)
            {
                if (!HasProperty(key))
                {
                    return def;
                }
                return mapEntry_[key];
            }

            public int GetInteger(string key)
            {
                return GetInteger(key, 0);
            }
            public int GetInteger(string key, int def)
            {
                if (!HasProperty(key))
                {
                    return def;
                }
                string strValue = mapEntry_[key];
                return StringUtility.ToInteger(strValue);
            }

            public double GetReal(string key)
            {
                return GetReal(key, 0.0);
            }
            public double GetReal(string key, double def)
            {
                if (!HasProperty(key))
                {
                    return def;
                }
                string strValue = mapEntry_[key];
                return StringUtility.ToDouble(strValue);
            }
    }

    /**********************************************************
    //Compressor
    **********************************************************/
    public class Compressor : System.IDisposable
    {


            /**********************************************************
            //Compressor
            **********************************************************/
            public Compressor()
            {

            }

            public virtual void Dispose()
            {


            }

            public bool Compress(ByteBuffer bufIn, ByteBuffer bufOut)
            {
                // TODO �v�Ǝ��̈��k�����
                // ���J�\�[�X�ł́A�󂯓n���ꂽ�f�[�^����̂܂ܕԂ�
                bool res = true;

                int inputSize = bufIn.GetSize();
                bufOut.SetSize(inputSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(bufOut.GetPointer(0), bufIn.GetPointer(0), inputSize);

                return res;
            }
    }

    /**********************************************************
    //DeCompressor
    **********************************************************/
    public class DeCompressor : System.IDisposable
    {


            /**********************************************************
            //DeCompressor
            **********************************************************/
            public DeCompressor()
            {

            }

            public virtual void Dispose()
            {

            }

            public bool DeCompress(ByteBuffer bufIn, ByteBuffer bufOut)
            {
                // TODO �v�Ǝ��̈��k�����
                // ���J�\�[�X�ł́A�󂯓n���ꂽ�f�[�^����̂܂ܕԂ�
                bool res = true;

                int inputSize = bufIn.GetSize();
                bufOut.SetSize(inputSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(bufOut.GetPointer(0), bufIn.GetPointer(0), inputSize);
                return res;
            }
    }

    /**********************************************************
    //SystemValueManager
    **********************************************************/
    public class SystemValueManager : System.IDisposable
    {
            public const string RECORD_SYSTEM = "__RECORD_SYSTEM__";
            public const string RECORD_SYSTEM_GLOBAL = "__RECORD_SYSTEM_GLOBAL__";
            private static SystemValueManager thisBase_ = null;

            protected SortedDictionary<string, gstd.ref_count_ptr<RecordBuffer>> mapRecord_ = new SortedDictionary<string, gstd.ref_count_ptr<RecordBuffer>>();


            /**********************************************************
            //SystemValueManager
            **********************************************************/
            public SystemValueManager()
            {
            }

            public virtual void Dispose()
            {
            }

            public static SystemValueManager GetBase()
            {
                return thisBase_;
            }
            public virtual bool Initialize()
            {
                if (thisBase_ != null)
                {
                    return false;
                }

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mapRecord_[RECORD_SYSTEM] = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new RecordBuffer();
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mapRecord_[RECORD_SYSTEM_GLOBAL] = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new RecordBuffer();

                thisBase_ = this;
                return true;
            }

            public virtual void ClearRecordBuffer(string key)
            {
                if (!IsExists(key))
                {
                    return;
                }
                mapRecord_[key].Clear();
            }

            public bool IsExists(string key)
            {
                return mapRecord_.ContainsKey(key);
            }

            public bool IsExists(string keyRecord, string keyValue)
            {
                if (!IsExists(keyRecord))
                {
                    return false;
                }
                gstd.ref_count_ptr<RecordBuffer> record = GetRecordBuffer(keyRecord);
                return record.IsExists(keyValue);
            }

            public gstd.ref_count_ptr<RecordBuffer> GetRecordBuffer(string key)
            {
                return IsExists(key) ? mapRecord_[key] : null;
            }

    }
}
