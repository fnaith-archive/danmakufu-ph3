using System;

namespace Gstd
{
    namespace File
    {
        sealed class ManagedFileReader : FileReader, System.IDisposable
        {
            private FileType type;
            private File file;
            //private ArchiveFileEntry entry;
            //private ByteBuffer buffer;
            private int offset;

            public ManagedFileReader(File file, object/* TODO ArchiveFileEntry*/ entry)
            {
                offset = 0;
                this.file = file;
                /*entry_ = entry;

                if(entry_ == NULL)
                {
                    type_ = FileType.TYPE_NORMAL;
                }
                else if(entry_->GetCompressType() == ArchiveFileEntry::CT_NON && entry_ != NULL)
                {
                    type_ = TYPE_ARCHIVED;
                }
                else if(entry_->GetCompressType() != ArchiveFileEntry::CT_NON && entry_ != NULL)
                {
                    type_ = TYPE_ARCHIVED_COMPRESSED;
                }*/
            }
            public void Dispose()
            {
                Close();
            }
            public override bool Open()
            {
                bool res = false;
                offset = 0;
                if (type == FileType.TYPE_NORMAL)
                {
                    res = file.Open();
                }
                /*else if(type_ == TYPE_ARCHIVED)
                {
                    res = file_->Open();
                    if(res)
                    {
                        file_->Seek(entry_->GetOffset());
                    }
                }
                else if(type_ == TYPE_ARCHIVED_COMPRESSED)
                {
                    buffer_ = FileManager::GetBase()->_GetByteBuffer(entry_);
                    res = buffer_ != NULL;
                }*/
                return res;
            }
            public override void Close()
            {
                if (file != null)file.Close();
                /*if(buffer_ != NULL)
                {
                    buffer_ = NULL;
                    FileManager::GetBase()->_ReleaseByteBuffer(entry_);
                }*/
            }
            public override int GetFileSize()
            {
                int res = 0;
                if (type == FileType.TYPE_NORMAL)res = file.GetSize();
                //else if(type_ == TYPE_ARCHIVED )res = entry_->GetDataSize();
                //else if(type_ == TYPE_ARCHIVED_COMPRESSED && buffer_ != NULL)res = buffer_->GetSize();
                return res;
            }
            public override int Read(char[] buf, int size)
            {
                int res = 0;
                if (type == FileType.TYPE_NORMAL)
                {
                    res = file.Read(buf, size);
                }
                /*else if(type_ == TYPE_ARCHIVED)
                {
                    int read = size;
                    if(entry_->GetDataSize() < offset_ + size)
                    {
                        read = entry_->GetDataSize() - offset_;
                    }
                    res = file_->Read(buf, read);
                }
                else if(type_ == TYPE_ARCHIVED_COMPRESSED)
                {
                    int read = size;
                    if(buffer_->GetSize() < offset_ + size)
                    {
                        read = buffer_->GetSize() - offset_;
                    }
                    memcpy(buf, &buffer_->GetPointer()[offset_], read);
                    res = read;
                }*/
                offset += res;
                return res;
            }
            public override bool SetFilePointerBegin()
            {
                bool res = false;
                offset = 0;
                if (type == FileType.TYPE_NORMAL)
                {
                    res = file.SetFilePointerBegin();
                }
                /*else if(type_ == TYPE_ARCHIVED)
                {
                    res = file_->Seek(entry_->GetOffset());
                }
                else if(type_ == TYPE_ARCHIVED_COMPRESSED)
                {

                }*/
                return res;
            }
            public override bool SetFilePointerEnd()
            {
                bool res = false;
                if (type == FileType.TYPE_NORMAL)
                {
                    res = file.SetFilePointerEnd();
                    offset = file.GetSize();
                }
                /*else if(type_ == TYPE_ARCHIVED)
                {
                    res = file_->Seek(entry_->GetOffset() + entry_->GetDataSize());
                    offset_ = entry_->GetDataSize();
                }
                else if(type_ == TYPE_ARCHIVED_COMPRESSED)
                {
                    if(buffer_ != NULL)
                    {
                        offset_ = buffer_->GetSize();
                        res = TRUE;
                    }
                }*/
                return res;
            }
            public override bool Seek(long offset)
            {
                bool res = false;
                if (type == FileType.TYPE_NORMAL)
                {
                    res = file.Seek(offset);
                }
                /*else if(type_ == TYPE_ARCHIVED)
                {
                    res = file_->Seek(entry_->GetOffset() + offset);
                }
                else if(type_ == TYPE_ARCHIVED_COMPRESSED)
                {
                    if(buffer_ != NULL)
                    {
                        res = TRUE;
                    }
                }
                if(res == TRUE)
                    offset_ = offset;*/
                return res;
            }
            public override long GetFilePointer()
            {
                long res = 0;
                if (type == FileType.TYPE_NORMAL)
                {
                    res = file.GetFilePointer();
                }
                /*else if(type_ == TYPE_ARCHIVED)
                {
                    res = file_->GetFilePointer() - entry_->GetOffset();
                }
                else if(type_ == TYPE_ARCHIVED_COMPRESSED)
                {
                    if(buffer_ != NULL)
                    {
                        res = offset_;
                    }
                }*/
                return res;
            }

            //public abstract bool IsArchived();
            //public abstract bool IsCompressed();
        }
    }
}