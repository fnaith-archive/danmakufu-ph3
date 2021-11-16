namespace Gstd
{
    namespace File
    {
        class FileManager
        {
        /*public:
            class LoadObject;
            class LoadThread;
            class LoadThreadListener;
            class LoadThreadEvent;
            friend ManagedFileReader;
        private:*/
            private static FileManager thisBase;
        /*protected:
            gstd::CriticalSection lock_;
            gstd::ref_count_ptr<LoadThread> threadLoad_;
            std::map<std::wstring, ref_count_ptr<ArchiveFile> > mapArchiveFile_;
            std::map<std::wstring, ref_count_ptr<ByteBuffer> > mapByteBuffer_;

            ref_count_ptr<ByteBuffer> _GetByteBuffer(ref_count_ptr<ArchiveFileEntry> entry);
            void _ReleaseByteBuffer(ref_count_ptr<ArchiveFileEntry> entry);
        public:*/
            public static FileManager GetBase()
            {
                return thisBase;
            }
            public FileManager()
            {
            }
            /*virtual ~FileManager();*/
            public bool Initialize()
            {
				if (thisBase != null)
				{
					return false;
				}
				thisBase = this;
				//threadLoad_ = new LoadThread();
				//threadLoad_->Start();
				return true;
            }
            /*void EndLoadThread();
            bool AddArchiveFile(std::wstring path);
            bool RemoveArchiveFile(std::wstring path);*/
            public FileReader GetFileReader(string path)
            {
				File fileRaw = new File(path);
				if (fileRaw.IsExists())
				{
					return new ManagedFileReader(fileRaw, null);
				}
                return null;
            }

            /*void AddLoadThreadEvent(ref_count_ptr<LoadThreadEvent> event);
            void AddLoadThreadListener(FileManager::LoadThreadListener* listener);
            void RemoveLoadThreadListener(FileManager::LoadThreadListener* listener);
            void WaitForThreadLoadComplete();*/
        }
    }
}