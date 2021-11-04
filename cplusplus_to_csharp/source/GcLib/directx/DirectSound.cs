using gstd;
using directx;
using System;
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
//    class DirectSoundManager;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundInfoPanel;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundInfo;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundDivision;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundPlayer;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundStreamingPlayer;

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundPlayerWave;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundStreamingPlayerWave;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundStreamingPlayerMp3;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class SoundStreamingPlayerOgg;

// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class AcmBase;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class AcmMp3;
// C++ TO C# CONVERTER NOTE: C# has no need of forward class declarations:
//    class AcmMp3Wave;


    public class WAVEFILEHEADER
    { // WAVE�\���t�H�[�}�b�g���A"fmt "�`�����N�f�[�^
        public string cRIFF = new string(new char[4]);
        public int iSizeRIFF;
        public string cType = new string(new char[4]);
        public string cFmt = new string(new char[4]);
        public int iSizeFmt;
        public WAVEFORMATEX WaveFmt = new WAVEFORMATEX();
        public string cData = new string(new char[4]);
        public int iSizeData;
    }

    /**********************************************************
    //DirectSoundManager
    **********************************************************/
    public class DirectSoundManager : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
            public class SoundManageThread : gstd.Thread, gstd.InnerClass<DirectSoundManager>
            {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//                friend DirectSoundManager;
                    protected int timeCurrent_;
                    protected int timePrevious_;


                    // DirectSoundManager::SoundManageThread
                    protected SoundManageThread(DirectSoundManager manager)
                    {
                        _SetOuter(manager);
                        timeCurrent_ = 0;
                        timePrevious_ = 0;
                    }

                    protected void _Run()
                    {
                        DirectSoundManager manager = _GetOuter();
                        while (this.GetStatus() == RUN)
                        {
                            timeCurrent_ = global::timeGetTime();

                            {
                                Lock @lock = new Lock(manager.GetLock());
                                _Fade();
                                _Arrange();
                            }

                            if (manager.panelInfo_ != null && this.GetStatus() == RUN)
                            {
                                // �N���e�B�J���Z�N�V�����̒��ōX�V�����
                                // ���C���X���b�h�ƃ��b�N����\��������܂�
                                manager.panelInfo_.Update(manager);
                            }
                            timePrevious_ = timeCurrent_;
                            global::Sleep(100);
                        }
                    }

                    protected void _Arrange()
                    {
                        DirectSoundManager manager = _GetOuter();
                        SortedSet<string> setRemoveKey = new SortedSet<string>();
                        SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> > mapPlayer = manager.mapPlayer_;
                        SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >.Enumerator itrNameMap;
                        for (itrNameMap = mapPlayer.GetEnumerator(); itrNameMap.MoveNext();)
                        {
                            LinkedList<gstd.ref_count_ptr<SoundPlayer>> listPlayer = itrNameMap.Current.Value;
                            LinkedList<gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrPlayer;
                            for (itrPlayer = listPlayer.GetEnumerator(); itrPlayer.MoveNext();)
                            {
                                SoundPlayer player = itrPlayer.Current.GetPointer();
                                bool bDelete = false;
                                if (player != null)
                                {
                                    bDelete |= player.bDelete_;
                                    bDelete |= player.bAutoDelete_ && !player.IsPlaying();
                                }

                                if (bDelete)
                                {
                                    Logger.WriteTop(StringUtility.Format("DirectSound�F�����f�[�^���[%s]", player.GetPath()));
                                    player.Stop();
// C++ TO C# CONVERTER TODO TASK: There is no direct equivalent to the STL list 'erase' method in C#:
                                    itrPlayer = listPlayer.erase(itrPlayer);
                                }
                                else
                                {
                                }
                            }

                            if (listPlayer.Count == 0)
                            {
                                setRemoveKey.Add(itrNameMap.Current.Key);
                            }
                        }

                        SortedSet<string>.Enumerator itrRemove;
                        for (itrRemove = setRemoveKey.GetEnumerator(); itrRemove.MoveNext();)
                        {
                            string key = itrRemove.Current;
                            mapPlayer.Remove(key);
                        }
                    }

                    protected void _Fade()
                    {
                        DirectSoundManager manager = _GetOuter();
                        int timeGap = timeCurrent_ - timePrevious_;
                        SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> > mapPlayer = manager.mapPlayer_;

                        SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >.Enumerator itrNameMap;
                        for (itrNameMap = mapPlayer.GetEnumerator(); itrNameMap.MoveNext();)
                        {
                            LinkedList<gstd.ref_count_ptr<SoundPlayer>> listPlayer = itrNameMap.Current.Value;
                            LinkedList<gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrPlayer;
                            for (itrPlayer = listPlayer.GetEnumerator(); itrPlayer.MoveNext();)
                            {
                                SoundPlayer player = itrPlayer.Current.GetPointer();
                                if (player == null)
                                {
                                    continue;
                                }
                                double rateFade = player.GetFadeVolumeRate();
                                if (rateFade == 0)
                                {
                                    continue;
                                }

                                double rateVolume = player.GetVolumeRate();
                                rateFade *= (double)timeGap / (double)1000.0;
                                rateVolume += rateFade;
                                player.SetVolumeRate(rateVolume);

                                if (rateVolume <= 0 && player.bFadeDelete_)
                                {
                                    player.Stop();
                                    player.Delete();
                                }
                            }
                        }
                    }
            }
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend SoundManageThread;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//            friend SoundInfoPanel;

// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                SD_VOLUME_MIN = DSBVOLUME_MIN,
                SD_VOLUME_MAX = DSBVOLUME_MAX
            }
            public enum FileFormat
            {
                SD_MIDI,
                SD_WAVE,
                SD_MP3,
                SD_OGG,
                SD_AWAVE, // ���kwave wave�w�b�_mp3
                SD_UNKNOWN
            }

            private static DirectSoundManager thisBase_ = null;

            protected IDirectSound8 pDirectSound_;
            protected IDirectSoundBuffer8 pDirectSoundBuffer_;
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected SoundManageThread threadManage_;
            protected SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> > mapPlayer_ = new SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >();
            protected SortedDictionary<int, gstd.ref_count_ptr<SoundDivision>> mapDivision_ = new SortedDictionary<int, gstd.ref_count_ptr<SoundDivision>>();
            protected SortedDictionary<string, gstd.ref_count_ptr<SoundInfo>> mapInfo_ = new SortedDictionary<string, gstd.ref_count_ptr<SoundInfo>>();
            protected gstd.ref_count_ptr<SoundInfoPanel> panelInfo_ = new gstd.ref_count_ptr<SoundInfoPanel>();

            protected gstd.ref_count_ptr<SoundPlayer> _GetPlayer(string path)
            {
                if (!mapPlayer_.ContainsKey(path))
                {
                    return null;
                }

                gstd.ref_count_ptr<SoundPlayer> res = null;

                SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >.Enumerator itrNameMap;
                for (itrNameMap = mapPlayer_.GetEnumerator(); itrNameMap.MoveNext();)
                {
                    LinkedList<gstd.ref_count_ptr<SoundPlayer>> listPlayer = itrNameMap.Current.Value;
                    LinkedList<gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrPlayer;
                    for (itrPlayer = listPlayer.GetEnumerator(); itrPlayer.MoveNext();)
                    {
                        SoundPlayer player = itrPlayer.Current.GetPointer();
                        if (player == null)
                        {
                            continue;
                        }
                        if (player.bDelete_)
                        {
                            continue;
                        }
                        if (player.GetPath() != path)
                        {
                            continue;
                        }
                        res = itrPlayer.Current;
                        break;
                    }
                }
                return new gstd.ref_count_ptr<SoundPlayer>(res);
            }

            protected gstd.ref_count_ptr<SoundPlayer> _CreatePlayer(string path)
            {
                gstd.ref_count_ptr<SoundPlayer> res = new gstd.ref_count_ptr<SoundPlayer>();
                FileManager fileManager = FileManager.GetBase();
                try
                {
                    path = PathProperty.GetUnique(path);
                    ref_count_ptr<FileReader> reader = fileManager.GetFileReader(path);
                    if (reader == null)
                    {
                        throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path).c_str());
                    }
                    if (!reader.Open())
                    {
                        throw new gstd.wexception(ErrorUtility.GetFileNotFoundErrorMessage(path).c_str());
                    }

                    // �t�H�[�}�b�g�m�F
                    int sizeFile = reader.GetFileSize();
                    FileFormat format = FileFormat.SD_UNKNOWN;
                    if (sizeFile <= 64)
                    {
                        throw new gstd.wexception();
                    }

                    ByteBuffer header = new ByteBuffer();
                    header.SetSize(64);
                    reader.Read(header.GetPointer(), header.GetSize());

// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (!memcmp(header.GetPointer(), "RIFF", 4))
                    { // WAVE
                        format = FileFormat.SD_WAVE;
                        WAVEFORMATEX pcmwf = new WAVEFORMATEX();
                        ZeroMemory(pcmwf, sizeof(PCMWAVEFORMAT));
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                        memcpy(pcmwf, header.GetPointer(20), sizeof(WAVEFORMATEX));
                        if (pcmwf.wFormatTag == 85)
                        {
                            format = FileFormat.SD_AWAVE; // wave�w�b�_mp3
                        }
                        else
                        {
                            format = FileFormat.SD_WAVE;
                        }
                    }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    else if (!memcmp(header.GetPointer(),"OggS",4))
                    { // OggVorbis
                        format = FileFormat.SD_OGG;
                    }
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    else if (!memcmp(header.GetPointer(),"MThd",4))
                    { // midi
                        format = FileFormat.SD_MIDI;
                    }
                    else
                    { // ����mp3
                        format = FileFormat.SD_MP3;
                    }

                    // �v���C���쐬
                    if (format == FileFormat.SD_WAVE)
                    { // WAVE
                        if (sizeFile < 1024 * 1024)
                        {
                            // �������ێ��Đ�
                            res = new SoundPlayerWave();
                        }
                        else
                        {
                            // �X�g���[�~���O
                            res = new SoundStreamingPlayerWave();
                        }
                    }
                    else if (format == FileFormat.SD_OGG)
                    { // OggVorbis
                        res = new SoundStreamingPlayerOgg();
                    }
                    else if (format == FileFormat.SD_MIDI)
                    { // midi
                    }
                    else if (format == FileFormat.SD_MP3 || format == FileFormat.SD_AWAVE)
                    { // mp3
                        res = new SoundStreamingPlayerMp3();
                    }

                    bool bSuccess = true;
                    bSuccess &= res != null;

                    if (res != null)
                    {
                        // �t�@�C����ǂݍ��݃T�E���h�o�b�t�@��쐬
                        bSuccess &= res._CreateBuffer(reader);
                        res.Seek(0);
                    }

                    if (bSuccess)
                    {
                        res.manager_ = this;
                        res.path_ = path;
                        mapPlayer_[path].AddLast(res);
                        string str = StringUtility.Format("DirectSound�F�����f�[�^��ǂݍ��݂܂���[%s]", path);
                        Logger.WriteTop(str);
                    }
                    else
                    {
                        string str = StringUtility.Format("DirectSound�F�����f�[�^�ǂݍ��ݎ��s[%s]", path);
                        Logger.WriteTop(str);
                    }
                }
                catch (gstd.wexception e)
                {
                    string str = StringUtility.Format("DirectSound�F�����f�[�^�ǂݍ��ݎ��s[%s]\n\t%s", path, e.what());
                    Logger.WriteTop(str);
                }
                return new gstd.ref_count_ptr<SoundPlayer>(res);
            }


            /**********************************************************
            //DirectSoundManager
            **********************************************************/

            public DirectSoundManager()
            {
                pDirectSound_ = null;
                pDirectSoundBuffer_ = null;
                CreateSoundDivision(SoundDivision.DIVISION_BGM);
                CreateSoundDivision(SoundDivision.DIVISION_SE);
                CreateSoundDivision(SoundDivision.DIVISION_VOICE);
            }

            public virtual void Dispose()
            {
                Logger.WriteTop("DirectSound�F�I���J�n");
                this.Clear();
                threadManage_.Stop();
                threadManage_.Join();
                if (threadManage_ != null)
                {
                    threadManage_.Dispose();
                }
                if (pDirectSoundBuffer_ != null)
                {
                    pDirectSoundBuffer_.Release();
                }
                if (pDirectSound_ != null)
                {
                    pDirectSound_.Release();
                }
                panelInfo_ = null;
                thisBase_ = null;
                Logger.WriteTop("DirectSound�F�I������");
            }

            public static DirectSoundManager GetBase()
            {
                return thisBase_;
            }
            public virtual bool Initialize(IntPtr hWnd)
            {
                if (thisBase_ != null)
                {
                    return false;
                }

                Logger.WriteTop("DirectSound�F������");

                int hrSound = DirectSoundCreate8(null, pDirectSound_, null);
                if (FAILED(hrSound))
                {
                    Logger.WriteTop("DirectSoundCreate8���s");
                    return false; // DirectSound8�̍쐬�Ɏ��s
                }

                int hrCoop = pDirectSound_.SetCooperativeLevel(hWnd,DSSCL_PRIORITY);
                if (FAILED(hrCoop))
                {
                    Logger.WriteTop("SetCooperativeLevel���s");
                    return false;
                }

                // PrimaryBuffer������
                DSBUFFERDESC desc = new DSBUFFERDESC();
                ZeroMemory(desc, sizeof(DSBUFFERDESC));
                desc.dwSize = sizeof(DSBUFFERDESC);
                desc.dwFlags = DSBCAPS_CTRLVOLUME | DSBCAPS_PRIMARYBUFFER;
                desc.dwBufferBytes = 0;
                desc.lpwfxFormat = null;
                int hrBuf = pDirectSound_.CreateSoundBuffer(desc, (LPDIRECTSOUNDBUFFER) pDirectSoundBuffer_, null);
                if (FAILED(hrBuf))
                {
                    Logger.WriteTop("CreateSoundBuffer���s");
                    return false;
                }

                WAVEFORMATEX pcmwf = new WAVEFORMATEX();
                ZeroMemory(pcmwf, sizeof(PCMWAVEFORMAT));
                pcmwf.wFormatTag = WAVE_FORMAT_PCM;
                pcmwf.nChannels = 2;
                pcmwf.nSamplesPerSec = 44100;
                pcmwf.nBlockAlign = 4;
                pcmwf.nAvgBytesPerSec = pcmwf.nSamplesPerSec * pcmwf.nBlockAlign;
                pcmwf.wBitsPerSample = 16;
                int hrFormat = pDirectSoundBuffer_.SetFormat(pcmwf);
                if (FAILED(hrFormat))
                {
                    Logger.WriteTop("SetFormat���s");
                    return false;
                }

                // �Ǘ��X���b�h�J�n
                threadManage_ = new SoundManageThread(this);
                threadManage_.Start();

                Logger.WriteTop("DirectSound�F����������");

                thisBase_ = this;
                return true;
            }

            public void Clear()
            {
                try
                {
                    Lock @lock = new Lock(lock_);
                    SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >.Enumerator itrNameMap;
                    for (itrNameMap = mapPlayer_.GetEnumerator(); itrNameMap.MoveNext();)
                    {
                        LinkedList<gstd.ref_count_ptr<SoundPlayer>> listPlayer = itrNameMap.Current.Value;
                        LinkedList<gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrPlayer;
                        for (itrPlayer = listPlayer.GetEnumerator(); itrPlayer.MoveNext();)
                        {
                            SoundPlayer player = itrPlayer.Current.GetPointer();
                            if (player == null)
                            {
                                continue;
                            }
                            player.Stop();
                        }
                    }
                    mapPlayer_.Clear();
                }
                catch
                {
                }
            }

            public IDirectSound8 GetDirectSound()
            {
                return pDirectSound_;
            }
            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }

            public gstd.ref_count_ptr<SoundPlayer> GetPlayer(string path, bool bCreateAlways = false)
            {
                gstd.ref_count_ptr<SoundPlayer> res = new gstd.ref_count_ptr<SoundPlayer>();
                try
                {
                    Lock @lock = new Lock(lock_);
                    if (bCreateAlways)
                    {
                        res.CopyFrom(_CreatePlayer(path));
                    }
                    else
                    {
                        res.CopyFrom(_GetPlayer(path));
                        if (res == null)
                        {
                            res.CopyFrom(_CreatePlayer(path));
                        }
                    }
                }
                catch
                {
                }

                return new gstd.ref_count_ptr<SoundPlayer>(res);
            }

            public gstd.ref_count_ptr<SoundDivision> CreateSoundDivision(int index)
            {
                if (mapDivision_.ContainsKey(index))
                {
                    return new gstd.ref_count_ptr<SoundDivision>(mapDivision_[index]);
                }

                ref_count_ptr<SoundDivision> division = new SoundDivision();
                mapDivision_[index] = division;
                return new ref_count_ptr<SoundDivision>(division);
            }

            public gstd.ref_count_ptr<SoundDivision> GetSoundDivision(int index)
            {
                if (!mapDivision_.ContainsKey(index))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<SoundDivision>(mapDivision_[index]);
            }

            public gstd.ref_count_ptr<SoundInfo> GetSoundInfo(string path)
            {
                string name = PathProperty.GetFileName(path);
                if (!mapInfo_.ContainsKey(name))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<SoundInfo>(mapInfo_[name]);
            }

            public void SetInfoPanel(gstd.ref_count_ptr<SoundInfoPanel> panel)
            {
                gstd.Lock @lock = new gstd.Lock(lock_);
                panelInfo_.CopyFrom(panel);
            }

            public bool AddSoundInfoFromFile(string path)
            {
                bool res = false;
                FileManager fileManager = FileManager.GetBase();
                ref_count_ptr<FileReader> reader = fileManager.GetFileReader(path);
                if (reader == null || !reader.Open())
                {
                    Logger.WriteTop(ErrorUtility.GetFileNotFoundErrorMessage(path));
                    return false;
                }

                int sizeFile = reader.GetFileSize();
                List<char> text = new List<char>();
                text.Resize(sizeFile + 1);
                reader.Read(text[0], sizeFile);
                text[sizeFile] = '\0';

                Scanner scanner = new Scanner(text);
                try
                {
                    while (scanner.HasNext())
                    {
                        Token tok = scanner.Next();
                        if (tok.GetType() == Token.TK_EOF) // Eof�̎��ʎq��������t�@�C���̒����I��
                        {
                            break;
                        }
                        else if (tok.GetType() == Token.TK_ID)
                        {
                            string element = tok.GetElement();
                            if (element == "SoundInfo")
                            {
                                tok = scanner.Next();
                                if (tok.GetType() == Token.TK_NEWLINE)
                                {
                                    tok = scanner.Next();
                                }
                                scanner.CheckType(tok, Token.TK_OPENC);

                                string name;
                                ref_count_ptr<SoundInfo> info = new SoundInfo();
                                while (scanner.HasNext())
                                {
                                    tok = scanner.Next();
                                    if (tok.GetType() == Token.TK_CLOSEC)
                                    {
                                        break;
                                    }
                                    if (tok.GetType() != Token.TK_ID)
                                    {
                                        continue;
                                    }

                                    element = tok.GetElement();
                                    if (element == "name")
                                    {
                                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                        tok = scanner.Next();
                                        info.name_ = tok.GetString();
                                    }
                                    if (element == "title")
                                    {
                                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                        tok = scanner.Next();
                                        info.title_ = tok.GetString();
                                    }
                                    if (element == "loop_start_time")
                                    {
                                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                        tok = scanner.Next();
                                        info.timeLoopStart_ = tok.GetReal();
                                    }
                                    if (element == "loop_end_time")
                                    {
                                        scanner.CheckType(scanner.Next(), Token.TK_EQUAL);
                                        tok = scanner.Next();
                                        info.timeLoopEnd_ = tok.GetReal();
                                    }
                                }

                                if (name.Length > 0)
                                {
                                    mapInfo_[name] = info;
                                    string log = StringUtility.Format("�������ݒ�:path[%s] title[%s] start[%.3f] end[%.3f]", name, info.GetTitle().c_str(), info.GetLoopStartTime(), info.GetLoopEndTime());
                                    Logger.WriteTop(log);
                                }

                            }
                        }
                    }

                    res = true;
                }
                catch (gstd.wexception e)
                {
                    int line = scanner.GetCurrentLine();
                    string log = StringUtility.Format("�������ǂݍ��ݎ��s:path[%s] line[%d] msg[%s]", path, line, e.what());
                    Logger.WriteTop(log);
                }

                return res;
            }

            public List<gstd.ref_count_ptr<SoundInfo>> GetSoundInfoList()
            {
                List<gstd.ref_count_ptr<SoundInfo>> res = new List<new gstd.ref_count_ptr<SoundInfo>>();
                SortedDictionary<string, ref_count_ptr<SoundInfo>>.Enumerator itrNameMap;
                for (itrNameMap = mapInfo_.GetEnumerator(); itrNameMap.MoveNext();)
                {
                    gstd.ref_count_ptr<SoundInfo> info = itrNameMap.Current.Value;
                    res.Add(info);
                }
                return new List<gstd.ref_count_ptr<SoundInfo>>(res);
            }

            public void SetFadeDeleteAll()
            {
                try
                {
                    Lock @lock = new Lock(lock_);
                    SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >.Enumerator itrNameMap;
                    for (itrNameMap = mapPlayer_.GetEnumerator(); itrNameMap.MoveNext();)
                    {
                        LinkedList<gstd.ref_count_ptr<SoundPlayer>> listPlayer = itrNameMap.Current.Value;
                        LinkedList<gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrPlayer;
                        for (itrPlayer = listPlayer.GetEnumerator(); itrPlayer.MoveNext();)
                        {
                            SoundPlayer player = itrPlayer.Current.GetPointer();
                            if (player == null)
                            {
                                continue;
                            }
                            player.SetFadeDelete(SoundPlayer.FADE_DEFAULT);
                        }
                    }
                }
                catch
                {
                }
            }
    }

    // �t�F�[�h�C���^�t�F�[�h�A�E�g����
    // �K�v�Ȃ��Ȃ����o�b�t�@�̊J���Ȃ�

    /**********************************************************
    //SoundInfoPanel
    **********************************************************/
    public class SoundInfoPanel : gstd.WindowLogger.Panel
    {
            protected class Info
            {
                public int address;
                public string path = "";
                public int countRef;
            }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum2
            {
                    ROW_ADDRESS,
                    ROW_FILENAME,
                    ROW_FULLPATH,
                    ROW_COUNT_REFFRENCE
            }
            protected gstd.WListView wndListView_ = new gstd.WListView();
            protected int timeLastUpdate_;
            protected int timeUpdateInterval_;

            protected virtual bool _AddedLogger(IntPtr hTab)
            {
                Create(hTab);

                gstd.WListView.Style styleListView = new gstd.WListView.Style();
                styleListView.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOSORTHEADER);
                styleListView.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListView.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListView_.Create(hWnd_, styleListView);

                wndListView_.AddColumn(64, (int)AnonymousEnum2.ROW_ADDRESS, "Address");
                wndListView_.AddColumn(96, (int)AnonymousEnum2.ROW_FILENAME, "Name");
                wndListView_.AddColumn(48, (int)AnonymousEnum2.ROW_FULLPATH, "Path");
                wndListView_.AddColumn(32, (int)AnonymousEnum2.ROW_COUNT_REFFRENCE, "Ref");

                return true;
            }


            /**********************************************************
            //SoundInfoPanel
            **********************************************************/
            public SoundInfoPanel()
            {
                timeLastUpdate_ = 0;
                timeUpdateInterval_ = 500;
            }

            public void SetUpdateInterval(int time)
            {
                timeUpdateInterval_ = time;
            }
            public virtual void LocateParts()
            {
                int wx = GetClientX();
                int wy = GetClientY();
                int wWidth = GetClientWidth();
                int wHeight = GetClientHeight();

                wndListView_.SetBounds(wx, wy, wWidth, wHeight);
            }

            public virtual void Update(DirectSoundManager soundManager)
            {
                if (!IsWindowVisible())
                {
                    return;
                }
                int time = timeGetTime();
                if (System.Math.Abs(time - timeLastUpdate_) < timeUpdateInterval_)
                {
                    return;
                }
                timeLastUpdate_ = time;

                // �N���e�B�J���Z�N�V������ŁA�E�B���h�E�Ƀ��b�Z�[�W�𑗂��
                // ���b�N����\��������̂ŁA�\��������݂̂�R�s�[����
                LinkedList<Info> listInfo = new LinkedList<Info>();
                {
                    Lock @lock = new Lock(soundManager.GetLock());
                    SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> > mapPlayer = soundManager.mapPlayer_;
                    SortedDictionary<string, LinkedList<gstd.ref_count_ptr<SoundPlayer>> >.Enumerator itrNameMap;
                    for (itrNameMap = mapPlayer.GetEnumerator(); itrNameMap.MoveNext();)
                    {
                        string path = itrNameMap.Current.Key;
                        LinkedList<gstd.ref_count_ptr<SoundPlayer>> listPlayer = itrNameMap.Current.Value;
                        LinkedList<gstd.ref_count_ptr<SoundPlayer>>.Enumerator itrPlayer;
                        for (itrPlayer = listPlayer.GetEnumerator(); itrPlayer.MoveNext();)
                        {
                            SoundPlayer player = itrPlayer.Current.GetPointer();
                            if (player == null)
                            {
                                continue;
                            }

                            int address = (int)player;
                            Info info = new Info();
                            info.address = address;
                            info.path = path;
                            info.countRef = itrPlayer.Current.GetReferenceCount();
                            listInfo.AddLast(info);
                        }
                    }
                }

                SortedSet<string> setKey = new SortedSet<string>();
                LinkedList<Info>.Enumerator itrInfo;
                for (itrInfo = listInfo.GetEnumerator(); itrInfo.MoveNext();)
                {
                    Info info = itrInfo.Current;
                    int address = info.address;
                    string path = info.path;
                    int countRef = info.countRef;
                    string key = StringUtility.Format("%08x", address);
                    int index = wndListView_.GetIndexInColumn(key, (int)AnonymousEnum2.ROW_ADDRESS);
                    if (index == -1)
                    {
                        index = wndListView_.GetRowCount();
                        wndListView_.SetText(index, (int)AnonymousEnum2.ROW_ADDRESS, key);
                    }

                    wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FILENAME, PathProperty.GetFileName(path));
                    wndListView_.SetText(index, (int)AnonymousEnum2.ROW_FULLPATH, path);
                    wndListView_.SetText(index, (int)AnonymousEnum2.ROW_COUNT_REFFRENCE, StringUtility.Format("%d", countRef));

                    setKey.Add(key);
                }

                for (int iRow = 0; iRow < wndListView_.GetRowCount();)
                {
                    string key = wndListView_.GetText(iRow, (int)AnonymousEnum2.ROW_ADDRESS);
                    if (setKey.find(key) != setKey.end())
                    {
                        iRow++;
                    }
                    else
                    {
                        wndListView_.DeleteRow(iRow);
                    }
                }
            }
    }

    /**********************************************************
    //SoundDivision
    //���ʂȂǂ���L���邽�߂̃N���X
    **********************************************************/
    public class SoundDivision : System.IDisposable
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum3
            {
                DIVISION_BGM = 0,
                DIVISION_SE,
                DIVISION_VOICE
            }
            protected double rateVolume_; // ���ʊ���(0-100)
            /**********************************************************
            //SoundDivision
            **********************************************************/
            public SoundDivision()
            {
                rateVolume_ = 100;
            }

            public virtual void Dispose()
            {

            }

            public void SetVolumeRate(double rate)
            {
                rateVolume_ = rate;
            }
            public double GetVolumeRate()
            {
                return rateVolume_;
            }
    }

    /**********************************************************
    //SoundInfo
    **********************************************************/
    public class SoundInfo : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DirectSoundManager;
            private string name_ = "";
            private string title_ = "";
            private double timeLoopStart_;
            private double timeLoopEnd_;
            public SoundInfo()
            {
                timeLoopStart_ = 0;
                timeLoopEnd_ = 0;
            }
            public virtual void Dispose()
            {
            }
            public string GetName()
            {
                return name_;
            }
            public string GetTitle()
            {
                return title_;
            }
            public double GetLoopStartTime()
            {
                return timeLoopStart_;
            }
            public double GetLoopEndTime()
            {
                return timeLoopEnd_;
            }
    }

    /**********************************************************
    //SoundPlayer
    **********************************************************/
    public abstract class SoundPlayer : System.IDisposable
    {
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DirectSoundManager;
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend DirectSoundManager::SoundManageThread;
            public class PlayStyle
            {
                    private bool bLoop_;
                    private double timeLoopStart_;
                    private double timeLoopEnd_;
                    private double timeStart_;
                    private bool bRestart_;

                    // PlayStyle
                    public PlayStyle()
                    {
                        bLoop_ = false;
                        timeLoopStart_ = 0;
                        timeLoopEnd_ = 0;
                        timeStart_ = 0;
                        bRestart_ = false;
                    }

                    public virtual void Dispose()
                    {

                    }

                    public void SetLoopEnable(bool bLoop)
                    {
                        bLoop_ = bLoop;
                    }
                    public bool IsLoopEnable()
                    {
                        return bLoop_;
                    }
                    public void SetLoopStartTime(double time)
                    {
                        timeLoopStart_ = time;
                    }
                    public double GetLoopStartTime()
                    {
                        return timeLoopStart_;
                    }
                    public void SetLoopEndTime(double time)
                    {
                        timeLoopEnd_ = time;
                    }
                    public double GetLoopEndTime()
                    {
                        return timeLoopEnd_;
                    }
                    public void SetStartTime(double time)
                    {
                        timeStart_ = time;
                    }
                    public double GetStartTime()
                    {
                        return timeStart_;
                    }
                    public bool IsRestart()
                    {
                        return bRestart_;
                    }
                    public void SetRestart(bool b)
                    {
                        bRestart_ = b;
                    }
            }
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum4
            {
                FADE_DEFAULT = 20
            }
            protected DirectSoundManager manager_;
            protected string path_ = "";
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected IDirectSoundBuffer8 pDirectSoundBuffer_;
            protected gstd.ref_count_ptr<gstd.FileReader> reader_ = new gstd.ref_count_ptr<gstd.FileReader>();
            protected gstd.ref_count_ptr<SoundDivision> division_ = new gstd.ref_count_ptr<SoundDivision>();

            protected WAVEFORMATEX formatWave_ = new WAVEFORMATEX();
            protected bool bLoop_; // ���[�v�L��
            protected double timeLoopStart_; // ���[�v�J�n����
            protected double timeLoopEnd_; // ���[�v�I������
            protected bool bPause_;

            protected bool bDelete_; // �폜�t���O
            protected bool bFadeDelete_; // �t�F�[�h�A�E�g��ɍ폜
            protected bool bAutoDelete_; // �����폜
            protected double rateVolume_; // ���ʊ���(0-100)
            protected double rateVolumeFadePerSec_; // �t�F�[�h���̉��ʒቺ����

            protected abstract bool _CreateBuffer(gstd.ref_count_ptr<gstd.FileReader> reader);
            protected virtual void _SetSoundInfo()
            {
                gstd.ref_count_ptr<SoundInfo> info = manager_.GetSoundInfo(path_);
                if (info == null)
                {
                    return;
                }
                timeLoopStart_ = info.GetLoopStartTime();
                timeLoopEnd_ = info.GetLoopEndTime();
            }

            protected static int _GetValumeAsDirectSoundDecibel(float rate)
            {
                int result = 0;
                if (rate >= 1.0f)
                {
                    result = DSBVOLUME_MAX;
                }
                else if (rate <= 0.0f)
                {
                    result = DSBVOLUME_MIN;
                }
                else
                {
                    // 10dB�ŉ���2�{�B
                    // ��(���߂�dB)
                    // 	 = 10 * log2(����)
                    // 	 = 10 * ( log10(����) / log10(2) )
                    // 	 = 33.2... * log10(����)
                    result = (int)(33.2f * System.Math.Log10(rate) * 100);
                }
                return result;
            }


            /**********************************************************
            //SoundPlayer
            **********************************************************/
            public SoundPlayer()
            {
                pDirectSoundBuffer_ = null;
                reader_ = null;

                ZeroMemory(formatWave_, sizeof(WAVEFORMATEX));
                bLoop_ = false;
                timeLoopStart_ = 0;
                timeLoopEnd_ = 0;

                bDelete_ = false;
                bFadeDelete_ = false;
                bAutoDelete_ = false;
                rateVolume_ = 100.0;
                rateVolumeFadePerSec_ = 0;
                bPause_ = false;
            }

            public virtual void Dispose()
            {
                Stop();
                if (pDirectSoundBuffer_ != null)
                {
                    pDirectSoundBuffer_.Release();
                }
            }

            public string GetPath()
            {
                return path_;
            }
            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }
            public virtual void Restore()
            {
                pDirectSoundBuffer_.Restore();
            }
            public void SetSoundDivision(gstd.ref_count_ptr<SoundDivision> div)
            {
                division_.CopyFrom(div);
            }

            public void SetSoundDivision(int index)
            {
                {
                    Lock @lock = new Lock(lock_);
                    DirectSoundManager manager = DirectSoundManager.GetBase();
                    gstd.ref_count_ptr<SoundDivision> div = manager.GetSoundDivision(index);
                    if (div != null)
                    {
                        SetSoundDivision(new gstd.ref_count_ptr<SoundDivision>(div));
                    }
                }
            }

            public virtual bool Play()
            {
                PlayStyle style = new PlayStyle();
                return Play(style);
            }

            public virtual bool Play(PlayStyle style)
            {
                return false;
            }

            public virtual bool Stop()
            {
                return false;
            }

            public virtual bool IsPlaying()
            {
                return false;
            }

            public abstract bool Seek(double time);
            public virtual bool SetVolumeRate(double rateVolume)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (rateVolume < 0)
                    {
                        rateVolume = 0.0;
                    }
                    if (rateVolume > 100)
                    {
                        rateVolume = 100.0;
                    }
                    rateVolume_ = rateVolume;

                    double rateDiv = 100.0;
                    if (division_ != null)
                    {
                        rateDiv = division_.GetVolumeRate();
                    }
                    double rate = rateVolume_ / 100.0 * rateDiv / 100.0;

                    // int volume = (int)((double)(DirectSoundManager::SD_VOLUME_MAX - DirectSoundManager::SD_VOLUME_MIN) * rate);
                    // pDirectSoundBuffer_->SetVolume(DirectSoundManager::SD_VOLUME_MIN+volume);
                    int volume = _GetValumeAsDirectSoundDecibel(rate);
                    pDirectSoundBuffer_.SetVolume(volume);
                }

                return true;
            }

            public bool SetPanRate(double ratePan)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (ratePan < -100)
                    {
                        ratePan = -100.0;
                    }
                    if (ratePan > 100)
                    {
                        ratePan = 100.0;
                    }

                    double rateDiv = 100.0;
                    if (division_ != null)
                    {
                        rateDiv = division_.GetVolumeRate();
                    }
                    double rate = rateVolume_ / 100.0 * rateDiv / 100.0;
                    int volume = (int)((double)(DirectSoundManager.SD_VOLUME_MAX - DirectSoundManager.SD_VOLUME_MIN) * rate);
                    // int volume = _GetValumeAsDirectSoundDecibel(rate);

                    double span = (DSBPAN_RIGHT - DSBPAN_LEFT) / 2;
                    span = volume / 2;
                    double pan = span * ratePan / 100;
                    int hr = pDirectSoundBuffer_.SetPan((int)pan);
                }

                return true;
            }

            public double GetVolumeRate()
            {
                double res = 0;
                {
                    Lock @lock = new Lock(lock_);
                    res = rateVolume_;
                }
                return res;
            }

            public void SetFade(double rateVolumeFadePerSec)
            {
                {
                    Lock @lock = new Lock(lock_);
                    rateVolumeFadePerSec_ = rateVolumeFadePerSec;
                }
            }

            public void SetFadeDelete(double rateVolumeFadePerSec)
            {
                {
                    Lock @lock = new Lock(lock_);
                    bFadeDelete_ = true;
                    SetFade(rateVolumeFadePerSec);
                }
            }

            public void SetAutoDelete(bool bAuto = true)
            {
                bAutoDelete_ = bAuto;
            }
            public double GetFadeVolumeRate()
            {
                double res = 0;
                {
                    Lock @lock = new Lock(lock_);
                    res = rateVolumeFadePerSec_;
                }
                return res;
            }

            public void Delete()
            {
                bDelete_ = true;
            }
            public WAVEFORMATEX GetWaveFormat()
            {
                return new WAVEFORMATEX(formatWave_);
            }
    }

    /**********************************************************
    //SoundStreamPlayer
    **********************************************************/
    public abstract class SoundStreamingPlayer : SoundPlayer
    {
// C++ TO C# CONVERTER TODO TASK: Multiple inheritance is not available in C#:
        private class StreamingThread : gstd.Thread, gstd.InnerClass<SoundStreamingPlayer>
        {
                // StreamingThread
                protected virtual void _Run()
                {
                    SoundStreamingPlayer player = _GetOuter();

                    uint point = 0;
                    player.pDirectSoundBuffer_.GetCurrentPosition(point, 0);
                    if (point == 0)
                    {
                        player._CopyStream(0);
                    }

                    while (this.GetStatus() == RUN)
                    {
                        uint num = WaitForMultipleObjects(3, player.hEvent_, false, INFINITE);
                        if (num == WAIT_OBJECT_0)
                        {
                            player._CopyStream(1);
                        }
                        else if (num == WAIT_OBJECT_0 + 1)
                        {
                            player._CopyStream(0);
                        }
                        else if (num == WAIT_OBJECT_0 + 2)
                        {
                            break;
                        }
                    }
                }

                public StreamingThread(SoundStreamingPlayer player)
                {
                    _SetOuter(player);
                }
        }
// C++ TO C# CONVERTER TODO TASK: C# has no concept of a 'friend' class:
//        friend StreamingThread;
            protected IntPtr[] hEvent_ = new IntPtr[3];
            protected IDirectSoundNotify pDirectSoundNotify_; // �C�x���g
            protected int sizeCopy_;
            protected StreamingThread thread_;
            protected bool bStreaming_;
            protected bool bRequestStop_; // ���[�v�������̃t���O�B������~����ƍŌ�̃o�b�t�@���Đ�����Ȃ����߁B

            protected void _CreateSoundEvent(WAVEFORMATEX formatWave)
            {
                sizeCopy_ = formatWave.nAvgBytesPerSec;
                int hrNotify = pDirectSoundBuffer_.QueryInterface(IID_IDirectSoundNotify, (object) pDirectSoundNotify_);
                DSBPOSITIONNOTIFY[] pn = Arrays.InitializeWithDefaultInstances<DSBPOSITIONNOTIFY>(3);
                for (int iEvent = 0; iEvent < 3; iEvent++)
                {
                    hEvent_[iEvent] = CreateEvent(null,false,false,null);
                    pn[iEvent].hEventNotify = hEvent_[iEvent];
                }

                pn[0].dwOffset = 0;
                pn[1].dwOffset = formatWave.nAvgBytesPerSec;
                pn[2].dwOffset = DSBPN_OFFSETSTOP;
                pDirectSoundNotify_.SetNotificationPositions(3, pn);

                if (hrNotify == DSERR_BUFFERLOST)
                {
                    this.Restore();
                }
            }

            protected virtual void _CopyStream(int indexCopy)
            {
                {
                    Lock @lock = new Lock(lock_);
                    object pMem1;
                    object pMem2 = new object();
                    uint dwSize1;
                    uint dwSize2;

                    int hr = pDirectSoundBuffer_.Lock(sizeCopy_ * indexCopy, sizeCopy_, pMem1, dwSize1, pMem2, dwSize2, 0);
                    if (hr == DSERR_BUFFERLOST)
                    {
                        hr = pDirectSoundBuffer_.Restore();
                        hr = pDirectSoundBuffer_.Lock(sizeCopy_ * indexCopy, sizeCopy_, pMem1, dwSize1, pMem2, dwSize2, 0);
                    }
                    if (FAILED(hr))
                    {
                        _RequestStop();
                    }

                    if (bRequestStop_)
                    {
                        Stop();
                    }

                    if (!bStreaming_ || (IsPlaying() && !bRequestStop_))
                    {
                        if (dwSize1 > 0)
                        {
                            _CopyBuffer(pMem1, dwSize1); // �o�b�t�@�O��
                        }
                        if (dwSize2 > 0)
                        {
                            _CopyBuffer(pMem2, dwSize2); // �o�b�t�@�㔼
                        }
                    }
                    else
                    {
                        // ���t���łȂ���Ζ������������
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memset' has no equivalent in C#:
                        memset(pMem1, 0, dwSize1);
                        if (dwSize2 != 0)
                        {
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                            memcpy(pMem2,0,dwSize2);
                        }
                    }
                    pDirectSoundBuffer_.Unlock(pMem1, dwSize1, pMem2, dwSize2);
                }
            }

            protected abstract void _CopyBuffer(object pMem, uint dwSize);
            protected void _RequestStop()
            {
                bRequestStop_ = true;
            }


            /**********************************************************
            //SoundStreamingPlayer
            **********************************************************/
            public SoundStreamingPlayer()
            {
                pDirectSoundNotify_ = null;
                ZeroMemory(hEvent_, sizeof(IntPtr) * 3);
                thread_ = new StreamingThread(this);
                bStreaming_ = true;
                bRequestStop_ = false;
            }

            public override void Dispose()
            {
                this.Stop();
                for (int iEvent = 0; iEvent < 3;iEvent++)
                {
                    global::CloseHandle(hEvent_[iEvent]);
                }
                if (pDirectSoundNotify_ != null)
                {
                    pDirectSoundNotify_.Release();
                }
                if (thread_ != null)
                {
                    thread_.Dispose();
                }
                base.Dispose();
            }

            public override bool Play(PlayStyle style)
            {
                if (IsPlaying())
                {
                    return true;
                }

                {
                    Lock @lock = new Lock(lock_);
                    if (bFadeDelete_)
                    {
                        SetVolumeRate(100);
                    }
                    bFadeDelete_ = false;

                    SetFade(0);

                    bLoop_ = style.IsLoopEnable();
                    timeLoopStart_ = style.GetLoopStartTime();
                    timeLoopEnd_ = style.GetLoopEndTime();
            // 		if(timeLoopEnd_ == 0)timeLoopEnd_ = (double)sizeWave_ / (double)formatWave_.nAvgBytesPerSec;
            // 		fadeValuePerMillSec_ = 0;

                    _SetSoundInfo();

                    bRequestStop_ = false;
                    if (!(bPause_ && style.IsRestart()))
                    {
                        this.Seek(style.GetStartTime());
                        pDirectSoundBuffer_.SetCurrentPosition(0);
                    }

                    if (bStreaming_)
                    {
                        thread_.Start();
                        pDirectSoundBuffer_.Play(0, 0, DSBPLAY_LOOPING); // �Đ��J�n
                    }
                    else
                    {
                        uint dwFlags = 0;
                        if (style.IsLoopEnable())
                        {
                            dwFlags = DSBPLAY_LOOPING;
                        }
                        pDirectSoundBuffer_.Play(0, 0, dwFlags);
                    }
                    bPause_ = false;
                }
                return true;
            }

            public override bool Stop()
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (IsPlaying())
                    {
                        bPause_ = true;
                    }

                    if (pDirectSoundBuffer_ != null)
                    {
                        pDirectSoundBuffer_.Stop();
                    }

                    thread_.Stop();
                }
                return true;
            }

            public override bool IsPlaying()
            {
                return thread_.GetStatus() == Thread.RUN;
            }
    }

    /**********************************************************
    //SoundPlayerWave
    **********************************************************/
    public class SoundPlayerWave : SoundPlayer
    {
            protected override bool _CreateBuffer(gstd.ref_count_ptr<gstd.FileReader> reader)
            {
                FileManager fileManager = FileManager.GetBase();
                DirectSoundManager soundManager = DirectSoundManager.GetBase();

                reader_.CopyFrom(reader);
                reader_.SetFilePointerBegin();

                try
                {
                    // wave���
                    const string chunk = "";
                    int sizeRiff = 0;
                    int sizeFormat = 0;
                    int sizeWave = 0;

                    reader_.Read(chunk, 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(chunk, "RIFF", 4) != 0)
                    {
                        throw (false);
                    }
                    reader_.Read(sizeRiff, sizeof(int));
                    reader_.Read(chunk, 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(chunk, "WAVE", 4) != 0)
                    {
                        throw (false);
                    }
                    reader_.Read(chunk, 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(chunk, "fmt ", 4) != 0)
                    {
                        throw (false);
                    }
                    reader_.Read(sizeFormat, sizeof(int));
                    sizeFormat = sizeof(WAVEFORMATEX) - sizeof(ushort);
                    reader_.Read(formatWave_, sizeFormat);
                    while (true)
                    {
                        char ex = 0;
                        if (reader_.Read(ex, sizeof(char)) == 0)
                        {
                            throw (false);
                        }
                        for (int iChar = 0 ; iChar < 3 ; iChar++)
                        {
                            chunk = StringFunctions.ChangeCharacter(chunk, iChar, chunk[iChar + 1]);
                        }
                        chunk = StringFunctions.ChangeCharacter(chunk, 3, ex);

                        // if(reader_->Read(&chunk, 4)==0)throw(false);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                        if (memcmp(chunk, "data", 4) == 0)
                        {
                            break;
                        }
                    }
                    reader_.Read(sizeWave, sizeof(int));

                    int posWaveStart = reader_.GetFilePointer();
                    int posWaveEnd = posWaveStart + sizeWave;

                    // Buffer�̍쐻
                    DSBUFFERDESC desc = new DSBUFFERDESC();
                    ZeroMemory(desc, sizeof(DSBUFFERDESC));
                    desc.dwSize = sizeof(DSBUFFERDESC);
                    desc.dwFlags = DSBCAPS_CTRLVOLUME | DSBCAPS_CTRLPAN | DSBCAPS_GETCURRENTPOSITION2 | DSBCAPS_GLOBALFOCUS | DSBCAPS_LOCDEFER;
                    desc.dwBufferBytes = sizeWave;
                    desc.lpwfxFormat = formatWave_;
                    int hrBuffer = soundManager.GetDirectSound().CreateSoundBuffer(desc, (LPDIRECTSOUNDBUFFER) pDirectSoundBuffer_, null);
                    if (FAILED(hrBuffer))
                    {
                        throw (false);
                    }

                    // Buffer�֏�������
                    object pMem1;
                    object pMem2 = new object();
                    uint dwSize1;
                    uint dwSize2;
                    int hrLock = pDirectSoundBuffer_.Lock(0, sizeWave, pMem1, dwSize1, pMem2, dwSize2, 0);
                    if (hrLock == DSERR_BUFFERLOST)
                    {
                        hrLock = pDirectSoundBuffer_.Restore();
                        hrLock = pDirectSoundBuffer_.Lock(0, sizeWave, pMem1, dwSize1, pMem2, dwSize2, 0);
                    }
                    if (FAILED(hrLock))
                    {
                        throw (false);
                    }

                    reader_.Seek(posWaveStart);
                    reader_.Read(pMem1, dwSize1);
                    if (dwSize2 != 0)
                    {
                        reader_.Read(pMem2, dwSize2);
                    }
                    hrLock = pDirectSoundBuffer_.Unlock(pMem1, dwSize1, pMem2, dwSize2);
                }
                catch
                {
                    return false;
                }

                return true;
            }


            /**********************************************************
            //SoundPlayerWave
            **********************************************************/
            public SoundPlayerWave()
            {

            }

            public override void Dispose()
            {
                base.Dispose();
            }

            public override bool Play(PlayStyle style)
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (bFadeDelete_)
                    {
                        SetVolumeRate(100);
                    }
                    bFadeDelete_ = false;

                    SetFade(0);

                    uint dwFlags = 0;
                    if (style.IsLoopEnable())
                    {
                        dwFlags = DSBPLAY_LOOPING;
                    }

                    if (!(bPause_ && style.IsRestart()))
                    {
                        this.Seek(style.GetStartTime());
                    }

                    int hr = pDirectSoundBuffer_.Play(0, 0, dwFlags);
                    if (hr == DSERR_BUFFERLOST)
                    {
                        this.Restore();
                    }

                    bPause_ = false;
                }
                return true;
            }

            public override bool Stop()
            {
                {
                    Lock @lock = new Lock(lock_);
                    if (IsPlaying())
                    {
                        bPause_ = true;
                    }

                    if (pDirectSoundBuffer_ != null)
                    {
                        pDirectSoundBuffer_.Stop();
                    }
                }
                return true;
            }

            public override bool IsPlaying()
            {
                uint status = 0;
                pDirectSoundBuffer_.GetStatus(status);
                bool res = (status & DSBSTATUS_PLAYING) > 0;
                return res;
            }

            public override bool Seek(double time)
            {
                {
                    Lock @lock = new Lock(lock_);
                    int pos = (int)time * formatWave_.nAvgBytesPerSec;
                    pDirectSoundBuffer_.SetCurrentPosition(pos);
                }
                return true;
            }
    }

    /**********************************************************
    //SoundStreamingPlayerWave
    **********************************************************/
    public class SoundStreamingPlayerWave : SoundStreamingPlayer
    {
            protected int posWaveStart_;
            protected int posWaveEnd_;
            protected override bool _CreateBuffer(gstd.ref_count_ptr<gstd.FileReader> reader)
            {
                FileManager fileManager = FileManager.GetBase();
                DirectSoundManager soundManager = DirectSoundManager.GetBase();

                reader_.CopyFrom(reader);
                reader_.SetFilePointerBegin();

                try
                {
                    // wave���
                    const string chunk = "";
                    int sizeRiff = 0;
                    int sizeFormat = 0;
                    int sizeWave = 0;

                    reader_.Read(chunk, 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(chunk, "RIFF", 4) != 0)
                    {
                        throw (false);
                    }
                    reader_.Read(sizeRiff, sizeof(int));
                    reader_.Read(chunk, 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(chunk, "WAVE", 4) != 0)
                    {
                        throw (false);
                    }
                    reader_.Read(chunk, 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(chunk, "fmt ", 4) != 0)
                    {
                        throw (false);
                    }
                    reader_.Read(sizeFormat, sizeof(int));
                    sizeFormat = sizeof(WAVEFORMATEX) - sizeof(ushort);
                    reader_.Read(formatWave_, sizeFormat);
                    while (true)
                    {
                        char ex = 0;
                        if (reader_.Read(ex, sizeof(char)) == 0)
                        {
                            throw (false);
                        }
                        for (int iChar = 0 ; iChar < 3 ; iChar++)
                        {
                            chunk = StringFunctions.ChangeCharacter(chunk, iChar, chunk[iChar + 1]);
                        }
                        chunk = StringFunctions.ChangeCharacter(chunk, 3, ex);

                        // if(reader_->Read(&chunk, 4)==0)throw(false);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                        if (memcmp(chunk, "data", 4) == 0)
                        {
                            break;
                        }
                    }
                    reader_.Read(sizeWave, sizeof(int));

                    posWaveStart_ = reader_.GetFilePointer();
                    posWaveEnd_ = posWaveStart_ + sizeWave;
                    reader_.Seek(posWaveStart_);
                }
                catch
                {
                    return false;
                }

                // Buffer�̍쐻
                DSBUFFERDESC desc = new DSBUFFERDESC();
                ZeroMemory(desc, sizeof(DSBUFFERDESC));
                desc.dwSize = sizeof(DSBUFFERDESC);
                desc.dwFlags = DSBCAPS_CTRLVOLUME | DSBCAPS_CTRLPAN | DSBCAPS_GETCURRENTPOSITION2 | DSBCAPS_GLOBALFOCUS | DSBCAPS_CTRLPOSITIONNOTIFY | DSBCAPS_LOCSOFTWARE;
                desc.dwBufferBytes = 2 * formatWave_.nAvgBytesPerSec;
                desc.lpwfxFormat = formatWave_;
                int hrBuffer = soundManager.GetDirectSound().CreateSoundBuffer(desc, (LPDIRECTSOUNDBUFFER) pDirectSoundBuffer_, null);
                if (FAILED(hrBuffer))
                {
                    return false;
                }

                // �C�x���g�쐬
                _CreateSoundEvent(formatWave_);

                return true;
            }

            protected override void _CopyBuffer(object pMem, uint dwSize)
            {
                int cSize = (int)dwSize;
                int posLoopStart = (int)posWaveStart_ + timeLoopStart_ * formatWave_.nAvgBytesPerSec;
                int posLoopEnd = (int)posWaveStart_ + timeLoopEnd_ * formatWave_.nAvgBytesPerSec;
                int blockSize = formatWave_.nBlockAlign;

                int cPos = reader_.GetFilePointer();
                if (cPos + cSize > posWaveEnd_)
                { // �t�@�C���I�_
                    int size1 = cSize + cPos - posWaveEnd_;
                    int size2 = (int)((dwSize - cSize) / blockSize * blockSize);
                    size1 = (int)(dwSize - size2);

                    reader_.Read(pMem, size2);
                    Seek(timeLoopStart_);
                    if (bLoop_)
                    {
                        reader_.Read((string)pMem + size2, size1);
                    }
                    else
                    {
                        _RequestStop();
                    }
                }
                else if (cPos + cSize > posLoopEnd && timeLoopEnd_ > 0)
                { // ���[�v�̏I�[
                    int sizeOver = cPos + cSize - posLoopEnd; // ���[�v�𒴂����f�[�^�̃T�C�Y
                    int cSize1 = (cSize - sizeOver) / blockSize * blockSize;
                    int cSize2 = sizeOver / blockSize * blockSize;

                    reader_.Read(pMem, cSize1);
                    Seek(timeLoopStart_);
                    if (bLoop_)
                    {
                        reader_.Read((string)pMem + cSize1, cSize2);
                    }
                    else
                    {
                        _RequestStop();
                    }
                }
                else
                {
                    reader_.Read(pMem, cSize);
                }
            }

            /**********************************************************
            //SoundStreamingPlayerWave
            **********************************************************/
            public SoundStreamingPlayerWave()
            {
                posWaveStart_ = 0;
                posWaveEnd_ = 0;
            }

            public override bool Seek(double time)
            {
                {
                    Lock @lock = new Lock(lock_);
                    int blockSize = formatWave_.nBlockAlign;
                    int pos = (int)time * formatWave_.nAvgBytesPerSec;
                    pos = pos / blockSize * blockSize;
                    reader_.Seek(posWaveStart_ + pos);
                }
                return true;
            }
    }

    /**********************************************************
    //SoundStreamingPlayerOgg
    **********************************************************/
    public class SoundStreamingPlayerOgg : SoundStreamingPlayer
    {
            protected OggVorbis_File fileOgg_ = new OggVorbis_File();
            protected ov_callbacks oggCallBacks_ = new ov_callbacks();

            protected override bool _CreateBuffer(gstd.ref_count_ptr<gstd.FileReader> reader)
            {
                FileManager fileManager = FileManager.GetBase();
                DirectSoundManager soundManager = DirectSoundManager.GetBase();

                reader_.CopyFrom(reader);
                reader_.SetFilePointerBegin();

                // oggVorbis�g�p����
                oggCallBacks_.read_func = SoundStreamingPlayerOgg._ReadOgg;
                oggCallBacks_.seek_func = SoundStreamingPlayerOgg._SeekOgg;
                oggCallBacks_.close_func = SoundStreamingPlayerOgg._CloseOgg;
                oggCallBacks_.tell_func = SoundStreamingPlayerOgg._TellOgg;
                ov_open_callbacks((object)this, fileOgg_, null, 0, oggCallBacks_);
                vorbis_info vi = ov_info(fileOgg_, -1);
                if (vi == null)
                {
                    ov_clear(fileOgg_);
                    return false;
                }

                // WAVEHEADER�̑傫����擾
                // ������sizeof���Z�q���Ɛ��m�ȑ傫��������܂���B
                WAVEFILEHEADER wfh = new WAVEFILEHEADER();
                int sizeWaveHeader = sizeof(char) + sizeof(int) + sizeof(char) + sizeof(char) + sizeof(int) + sizeof(WAVEFORMATEX) + sizeof(char) + sizeof(int);
                int sizeData = (int)System.Math.Ceiling(vi.channels * vi.rate * ov_time_total(fileOgg_, -1) * 2);

                // WAVEHEADER�̒��g���`
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(wfh.cRIFF, "RIFF", 4);
                wfh.iSizeRIFF = sizeWaveHeader + sizeData - 8;
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(wfh.cType, "WAVE", 4);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(wfh.cFmt, "fmt ", 4);
                wfh.iSizeFmt = sizeof(WAVEFORMATEX);
                wfh.WaveFmt.cbSize = sizeof(WAVEFORMATEX);
                wfh.WaveFmt.wFormatTag = WAVE_FORMAT_PCM;
                wfh.WaveFmt.nChannels = vi.channels;
                wfh.WaveFmt.nSamplesPerSec = vi.rate;
                wfh.WaveFmt.nAvgBytesPerSec = vi.rate * vi.channels * 2;
                wfh.WaveFmt.nBlockAlign = vi.channels * 2;
                wfh.WaveFmt.wBitsPerSample = 2 * 8;
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(wfh.cData, "data", 4);
                wfh.iSizeData = sizeData;

// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: this->formatWave_ = wfh.WaveFmt;
                this.formatWave_.CopyFrom(wfh.WaveFmt);

                // Buffer�̍쐻
                uint sizeBuffer = System.Math.Min(2 * formatWave_.nAvgBytesPerSec, sizeData);

                DSBUFFERDESC desc = new DSBUFFERDESC();
                ZeroMemory(desc, sizeof(DSBUFFERDESC));
                desc.dwSize = sizeof(DSBUFFERDESC);
                desc.dwFlags = DSBCAPS_CTRLVOLUME | DSBCAPS_CTRLPAN | DSBCAPS_GETCURRENTPOSITION2 | DSBCAPS_GLOBALFOCUS | DSBCAPS_CTRLPOSITIONNOTIFY | DSBCAPS_LOCSOFTWARE;
                desc.dwBufferBytes = sizeBuffer;
                desc.lpwfxFormat = formatWave_;
                int hrBuffer = soundManager.GetDirectSound().CreateSoundBuffer(desc, (LPDIRECTSOUNDBUFFER) pDirectSoundBuffer_, null);
                if (FAILED(hrBuffer))
                {
                    return false;
                }

                // �C�x���g�쐬
                _CreateSoundEvent(formatWave_);

                bStreaming_ = sizeBuffer != sizeData;
                if (!bStreaming_)
                {
                    sizeCopy_ = sizeData;
                    _CopyStream(0);
                }

                return true;
            }

            protected override void _CopyBuffer(object pMem, uint dwSize)
            {
                int blockSize = formatWave_.nBlockAlign;

                int sizeWriteTotal = 0;
                while (sizeWriteTotal < dwSize)
                {
                    double timeCurrent = ov_time_tell(fileOgg_);
                    int cSize = (int)(dwSize - sizeWriteTotal);
                    double cTime = (double)cSize / (double)formatWave_.nAvgBytesPerSec;

                    if (timeCurrent + cTime > timeLoopEnd_ && timeLoopEnd_ > 0)
                    {
                        // ���[�v�I�[
                        double timeOver = timeCurrent + cTime - timeLoopEnd_;
                        double cTime1 = cTime - timeOver;
                        int cSize1 = (int)cTime1 * formatWave_.nAvgBytesPerSec;
                        cSize1 = cSize1 / blockSize * blockSize;

                        bool bFileEnd = false;
                        int size1Write = 0;
                        while (size1Write < cSize1)
                        {
                            int tSize = cSize1 - size1Write;
                            int sw = ov_read(fileOgg_, (string)pMem + sizeWriteTotal + size1Write, tSize, 0, 2, 1, null);
                            if (sw == 0)
                            {
                                bFileEnd = true;
                                break;
                            }
                            size1Write += sw;
                        }

                        if (!bFileEnd)
                        {
                            sizeWriteTotal += size1Write;
                            timeCurrent += (double)size1Write / (double)formatWave_.nAvgBytesPerSec;
                        }

                        if (bLoop_)
                        {
                            Seek(timeLoopStart_);
                        }
                        else
                        {
                            _RequestStop();
                            break;
                        }
                    }
                    else
                    {
                        int sizeWrite = ov_read(fileOgg_, (string)pMem + sizeWriteTotal, cSize, 0, 2, 1, null);
                        sizeWriteTotal += sizeWrite;
                        timeCurrent += (double)sizeWrite / (double)formatWave_.nAvgBytesPerSec;

                        if (sizeWrite == 0)
                        { // �t�@�C���I�_
                            if (bLoop_)
                            {
                                Seek(timeLoopStart_);
                            }
                            else
                            {
                                _RequestStop();
                                break;
                            }
                        }
                    }
                }

            }

            protected static size_t _ReadOgg(object ptr, size_t size, size_t nmemb, object source)
            {
                SoundStreamingPlayerOgg player = (SoundStreamingPlayerOgg)source;

                int sizeCopy = size * nmemb;
                sizeCopy = player.reader_.Read(ptr, sizeCopy);
                return sizeCopy / size;
            }

            protected static int _SeekOgg(object source, ogg_int64_t offset, int whence)
            {
                // ���݂̈ʒu���Ȃǂ�Z�b�g����R�[���o�b�N�֐��ł��B
                SoundStreamingPlayerOgg player = (SoundStreamingPlayerOgg)source;
                int high = (int)((offset & 0xFFFFFFFF00000000) >> 32);
                int low = (int)((offset & 0x00000000FFFFFFFF) >> 0);

                switch (whence)
                {
                    case SEEK_CUR:
                    {
                        int current = player.reader_.GetFilePointer() + low;
                        player.reader_.Seek(current);
                        break;
                    }
                    case SEEK_END:
                    {
                        player.reader_.SetFilePointerEnd();
                        break;
                    }
                    case SEEK_SET:
                    {
                        player.reader_.Seek(low);
                        break;
                    }
                }
                return 0;
            }

            protected static int _CloseOgg(object source)
            {
                // �t�@�C������鏈�������֐��ł��B
                // �����ł͉�����Ă��܂���B
                return 0;
            }

            protected static int _TellOgg(object source)
            {
                // �t�@�C���̌��݂̈ʒu��Ԃ��֐��ł��B
                SoundStreamingPlayerOgg player = (SoundStreamingPlayerOgg)source;
                return player.reader_.GetFilePointer();
            }

            /**********************************************************
            //SoundStreamingPlayerOgg
            **********************************************************/
            public SoundStreamingPlayerOgg()
            {
            }

            public new void Dispose()
            {
                this.Stop();
                thread_.Join();
                ov_clear(fileOgg_);
                base.Dispose();
            }

            public override bool Seek(double time)
            {
                {
                    Lock @lock = new Lock(lock_);
                    ov_time_seek(fileOgg_, time);
                }
                return true;
            }
    }

    /**********************************************************
    //SoundStreamingPlayerMp3
    **********************************************************/
    public class SoundStreamingPlayerMp3 : SoundStreamingPlayer
    {
            protected MPEGLAYER3WAVEFORMAT formatMp3_ = new MPEGLAYER3WAVEFORMAT();
            protected WAVEFORMATEX formatWave_ = new WAVEFORMATEX();
            protected HACMSTREAM hAcmStream_ = new HACMSTREAM();
            protected ACMSTREAMHEADER acmStreamHeader_ = new ACMSTREAMHEADER();
            protected int posMp3DataStart_;
            protected int posMp3DataEnd_;
            protected uint waveDataSize_;
            protected double timeCurrent_;
            protected gstd.ref_count_ptr<gstd.ByteBuffer> bufDecode_ = new gstd.ref_count_ptr<gstd.ByteBuffer>();

            protected override bool _CreateBuffer(gstd.ref_count_ptr<gstd.FileReader> reader)
            {
                reader_.CopyFrom(reader);
                reader_.SetFilePointerBegin();

                int fileSize = reader.GetFileSize();
                if (fileSize < 64)
                {
                    return false;
                }

                int offsetDataStart = 0;
                int dataSize = 0;
                string headerFile = new string(new char[10]);
                reader.Read(headerFile, sizeof(char));
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                if (memcmp(headerFile, "ID3", 3) == 0)
                {
                    // �^�O�T�C�Y��擾
                    uint tagSize = (uint)(((headerFile[6] << 21) | (headerFile[7] << 14) | (headerFile[8] << 7) | (headerFile[9])) + 10);

                    // �f�[�^�̈ʒu�A�T�C�Y��v�Z
                    offsetDataStart = (int)tagSize;
                    dataSize = fileSize - offsetDataStart;
                }
                else
                {
                    offsetDataStart = 0;

                    // �����̃^�O�Ɉړ�
                    string tag = new string(new char[3]);
                    reader.Seek(fileSize - 128);
                    reader.Read(tag, sizeof(char));

                    // �f�[�^�̈ʒu�A�T�C�Y��v�Z
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcmp' has no equivalent in C#:
                    if (memcmp(tag, "TAG", 3) == 0)
                    {
                        dataSize = fileSize - 128; // �����̃^�O��Ȃ�
                    }
                    else
                    {
                        dataSize = fileSize; // �t�@�C���S�̂�MP3�f�[�^
                    }
                }

                dataSize -= 4; // mp3�w�b�_
                posMp3DataStart_ = offsetDataStart + 4;
                posMp3DataEnd_ = posMp3DataStart_ + dataSize;

                reader.Seek(offsetDataStart);
                byte[] headerData = new byte[4];
                reader.Read(headerData, sizeof(byte));

                if (!(headerData[0] == 0xFF && (headerData[1] & 0xF0) == 0xF0))
                {
                    return false;
                }

                byte version = (byte)((headerData[1] >> 3) & 0x03);
                byte layer = (byte)((headerData[1] >> 1) & 0x03);

                // �r�b�g���[�g
                short[][] bitRateTable =
                {
                    new short[] { 0, 32, 64, 96, 128, 160, 192, 224, 256, 288, 320, 352, 384, 416, 448, -1 },
                    new short[] { 0, 32, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320, 384, -1 },
                    new short[] { 0, 32, 40, 48, 56, 64, 80, 96, 112, 128, 160, 192, 224, 256, 320, -1 },
                    new short[] { 0, 32, 48, 56, 64, 80, 96, 112, 128, 144, 160, 176, 192, 224, 256, -1 },
                    new short[] { 0, 8, 16, 24, 32, 40, 48, 56, 64, 80, 96, 112, 128, 144, 160, -1 }
                };

                int indexBitrate = 0;
                if (version == 3)
                {
                    indexBitrate = 3 - layer;
                }
                else
                {
                    if (layer == 3)
                    {
                        indexBitrate = 3;
                    }
                    else
                    {
                        indexBitrate = 4;
                    }
                }
                short bitRate = bitRateTable[indexBitrate][headerData[2] >> 4];

                // �T���v�����O���[�g
                int[][] sampleRateTable =
                {
                    new int[] { 44100, 48000, 32000, -1 },
                    new int[] { 22050, 24000, 16000, -1 },
                    new int[] { 11025, 12000, 8000, -1 }
                };
                int indexSampleRate = 0;
                switch (version)
                {
                    case 0:
                        indexSampleRate = 2;
                        break;
                    case 2:
                        indexSampleRate = 1;
                        break;
                    case 3:
                        indexSampleRate = 0;
                        break;
                }
                int sampleRate = sampleRateTable[indexSampleRate][(headerData[2] >> 2) & 0x03];

                byte padding = (byte)(headerData[2] >> 1 & 0x01);
                byte channel = (byte)(headerData[3] >> 6);

                // �T�C�Y�擾
                int mp3BlockSize = ((144 * bitRate * 1000) / sampleRate) + padding;

                formatMp3_.wfx.wFormatTag = WAVE_FORMAT_MPEGLAYER3;
                formatMp3_.wfx.nChannels = channel == 3 ? 1 : 2;
                formatMp3_.wfx.nSamplesPerSec = sampleRate;
                formatMp3_.wfx.nAvgBytesPerSec = (bitRate * 1000) / 8;
                formatMp3_.wfx.nBlockAlign = 1;
                formatMp3_.wfx.wBitsPerSample = 0;
                formatMp3_.wfx.cbSize = MPEGLAYER3_WFX_EXTRA_BYTES;

                formatMp3_.wID = MPEGLAYER3_ID_MPEG;
                formatMp3_.fdwFlags = padding != 0 ? MPEGLAYER3_FLAG_PADDING_ON : MPEGLAYER3_FLAG_PADDING_OFF;
                formatMp3_.nBlockSize = mp3BlockSize;
                formatMp3_.nFramesPerBlock = 1;
                formatMp3_.nCodecDelay = 1393;

                formatWave_.wFormatTag = WAVE_FORMAT_PCM;
                MMRESULT mmResSuggest = acmFormatSuggest(null, formatMp3_.wfx, formatWave_, sizeof(WAVEFORMATEX), ACM_FORMATSUGGESTF_WFORMATTAG);
                if (mmResSuggest != 0)
                {
                    return false;
                }

                MMRESULT mmResStreamOpen = acmStreamOpen(hAcmStream_, null, formatMp3_.wfx, formatWave_, null, 0, 0, 0);
                if (mmResStreamOpen != 0)
                {
                    return false;
                }

                uint waveBlockSize = 0;
                acmStreamSize(hAcmStream_, mp3BlockSize, waveBlockSize, ACM_STREAMSIZEF_SOURCE);

                acmStreamSize(hAcmStream_, dataSize, waveDataSize_, ACM_STREAMSIZEF_SOURCE);

                ZeroMemory(acmStreamHeader_, sizeof(ACMSTREAMHEADER));
                acmStreamHeader_.cbStruct = sizeof(ACMSTREAMHEADER);
                acmStreamHeader_.pbSrc = new byte[mp3BlockSize];
                acmStreamHeader_.cbSrcLength = mp3BlockSize;
                acmStreamHeader_.pbDst = new byte[waveBlockSize];
                acmStreamHeader_.cbDstLength = waveBlockSize;

                MMRESULT mmResPrepareHeader = acmStreamPrepareHeader(hAcmStream_, acmStreamHeader_, 0);
                if (mmResPrepareHeader != 0)
                {
                    return false;
                }

                // Buffer�̍쐻
                DirectSoundManager soundManager = DirectSoundManager.GetBase();
                uint sizeBuffer = System.Math.Min(2 * formatWave_.nAvgBytesPerSec, waveDataSize_);

                DSBUFFERDESC desc = new DSBUFFERDESC();
                ZeroMemory(desc, sizeof(DSBUFFERDESC));
                desc.dwSize = sizeof(DSBUFFERDESC);
                desc.dwFlags = DSBCAPS_CTRLVOLUME | DSBCAPS_CTRLPAN | DSBCAPS_GETCURRENTPOSITION2 | DSBCAPS_GLOBALFOCUS | DSBCAPS_CTRLPOSITIONNOTIFY | DSBCAPS_LOCSOFTWARE;
                desc.dwBufferBytes = sizeBuffer;
                desc.lpwfxFormat = formatWave_;
                int hrBuffer = soundManager.GetDirectSound().CreateSoundBuffer(desc, (LPDIRECTSOUNDBUFFER) pDirectSoundBuffer_, null);
                if (FAILED(hrBuffer))
                {
                    return false;
                }

                // �C�x���g�쐬
                _CreateSoundEvent(formatWave_);

                bStreaming_ = sizeBuffer != waveDataSize_;
                if (!bStreaming_)
                {
                    sizeCopy_ = (int)waveDataSize_;
                    _CopyStream(0);
                }

                reader.Seek(posMp3DataStart_);
                return true;
            }

            protected override void _CopyBuffer(object pMem, uint dwSize)
            {
                int blockSize = formatWave_.nBlockAlign;

                int sizeWriteTotal = 0;
                while (sizeWriteTotal < dwSize)
                {
                    int cSize = (int)(dwSize - sizeWriteTotal);
                    double cTime = (double)cSize / (double)formatWave_.nAvgBytesPerSec;

                    if (timeCurrent_ + cTime > timeLoopEnd_ && timeLoopEnd_ > 0)
                    {
                        // ���[�v�I�[
                        double timeOver = timeCurrent_ + cTime - timeLoopEnd_;
                        double cTime1 = cTime - timeOver;
                        int cSize1 = (int)cTime1 * formatWave_.nAvgBytesPerSec;
                        cSize1 = cSize1 / blockSize * blockSize;

                        bool bFileEnd = false;
                        int size1Write = 0;
                        while (size1Write < cSize1)
                        {
                            int tSize = cSize1 - size1Write;
                            int sw = _ReadAcmStream((string)pMem + sizeWriteTotal + size1Write, tSize);
                            if (sw == 0)
                            {
                                bFileEnd = true;
                                break;
                            }
                            size1Write += sw;
                        }

                        if (!bFileEnd)
                        {
                            sizeWriteTotal += size1Write;
                            timeCurrent_ += (double)size1Write / (double)formatWave_.nAvgBytesPerSec;
                        }

                        if (bLoop_)
                        {
                            Seek(timeLoopStart_);
                        }
                        else
                        {
                            _RequestStop();
                            break;
                        }
                    }
                    else
                    {
                        int sizeWrite = _ReadAcmStream((string)pMem + sizeWriteTotal, cSize);
                        sizeWriteTotal += sizeWrite;
                        timeCurrent_ += (double)sizeWrite / (double)formatWave_.nAvgBytesPerSec;

                        if (sizeWrite == 0)
                        { // �t�@�C���I�_
                            if (bLoop_)
                            {
                                Seek(timeLoopStart_);
                            }
                            else
                            {
                                _RequestStop();
                                break;
                            }
                        }
                    }
                }

            }

// C++ TO C# CONVERTER TODO TASK: Pointer arithmetic is detected on the parameter 'pBuffer', so pointers on this parameter are left unchanged:
            protected int _ReadAcmStream(char * pBuffer, int size)
            {
                int sizeWrite = 0;
                if (bufDecode_ != null)
                {
                    // �O��f�R�[�h�����������
                    int bufSize = bufDecode_.GetSize();
                    int copySize = System.Math.Min(size, bufSize);

// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(pBuffer, bufDecode_.GetPointer(), copySize);
                    sizeWrite += copySize;
                    if (bufSize > copySize)
                    {
                        int newSize = bufSize - copySize;
                        gstd.ref_count_ptr<gstd.ByteBuffer> buffer = new gstd.ByteBuffer();
                        buffer.SetSize(newSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                        memcpy(buffer.GetPointer(), bufDecode_.GetPointer() + copySize, newSize);

                        bufDecode_.CopyFrom(buffer);
                        return sizeWrite;
                    }

                    bufDecode_ = null;
                    pBuffer += sizeWrite;
                }

                // �f�R�[�h
                while (true)
                {
                    int readSize = reader_.Read(acmStreamHeader_.pbSrc, acmStreamHeader_.cbSrcLength);
                    if (readSize == 0)
                    {
                        return 0;
                    }
                    MMRESULT mmRes = acmStreamConvert(hAcmStream_, acmStreamHeader_, ACM_STREAMCONVERTF_BLOCKALIGN);
                    if (mmRes != 0)
                    {
                        return 0;
                    }
                    if (acmStreamHeader_.cbDstLengthUsed > 0)
                    {
                        break;
                    }
                }

                int sizeDecode = acmStreamHeader_.cbDstLengthUsed;
                int copySize = System.Math.Min(size, sizeDecode);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(pBuffer, acmStreamHeader_.pbDst, copySize);
                if (sizeDecode > copySize)
                {
                    // ����]��������A����p�Ƀo�b�t�@�����O
                    int newSize = sizeDecode - copySize;
                    bufDecode_ = new gstd.ByteBuffer();
                    bufDecode_.SetSize(newSize);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                    memcpy(bufDecode_.GetPointer(), acmStreamHeader_.pbDst + copySize, newSize);
                }
                sizeWrite += copySize;

                return sizeWrite;
            }


            /**********************************************************
            //SoundStreamingPlayerMp3
            **********************************************************/
            public SoundStreamingPlayerMp3()
            {
                hAcmStream_ = null;
                posMp3DataStart_ = 0;
                posMp3DataEnd_ = 0;
            }

            public new void Dispose()
            {
                if (hAcmStream_ != null)
                {
                    acmStreamUnprepareHeader(hAcmStream_, acmStreamHeader_, 0);
                    acmStreamClose(hAcmStream_, 0);

                    Arrays.DeleteArray(acmStreamHeader_.pbSrc);
                    Arrays.DeleteArray(acmStreamHeader_.pbDst);
                }
                base.Dispose();
            }

            public override bool Seek(double time)
            {
                double waveBlockSize = acmStreamHeader_.cbDstLength;
                double mp3BlockSize = acmStreamHeader_.cbSrcLength;
                double posSeekWave = time * formatWave_.nAvgBytesPerSec;

                double waveBlockIndex = posSeekWave / waveBlockSize;
                int mp3BlockIndex = (int)System.Math.Floor(waveBlockIndex + 0.5); // (waveBlockIndex * mp3BlockSize / waveBlockSize);
                {
                    Lock @lock = new Lock(lock_);
                    double posSeekMp3 = mp3BlockSize * mp3BlockIndex;
                    reader_.Seek(posMp3DataStart_ + posSeekMp3);

                    bufDecode_ = null;
                    timeCurrent_ = mp3BlockIndex * mp3BlockSize / formatMp3_.wfx.nAvgBytesPerSec;
                }

                return true;
            }
    }
}
