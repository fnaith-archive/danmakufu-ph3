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

/**********************************************************
//ReplayInformation
**********************************************************/
public class ReplayInformation : System.IDisposable
{
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
        public enum AnonymousEnum
        {
            INDEX_ACTIVE = 0,
            INDEX_DIGIT_MIN = 1,
            INDEX_DIGIT_MAX = 99,
            INDEX_USER = 100
        }

        public class StageData
        {
                // �X�e�[�W���
                private string mainScriptID_ = "";
                private string mainScriptName_ = "";
                private string mainScriptRelativePath_ = "";

                private _int64 scoreStart_ = new _int64();
                private _int64 scoreLast_ = new _int64();
                private _int64 graze_ = new _int64();
                private _int64 point_ = new _int64();
                private int frameEnd_;
                private int randSeed_;
                private List<float> listFramePerSecond_ = new List<float>();
                private ref_count_ptr<gstd.RecordBuffer> recordKey_ = new ref_count_ptr<gstd.RecordBuffer>();
                private SortedDictionary<string, ref_count_ptr<gstd.RecordBuffer>> mapCommonData_ = new SortedDictionary<string, ref_count_ptr<gstd.RecordBuffer>>();

                // ���@���
                private string playerScriptID_ = "";
                private string playerScriptFileName_ = "";
                private string playerScriptReplayName_ = "";

                private double playerLife_;
                private double playerBombCount_;
                private double playerPower_;
                private int playerRebirthFrame_; // ���炢�{���L���t���[��

                public StageData()
                {
                    recordKey_ = new gstd.RecordBuffer();
                    scoreStart_ = 0;
                    scoreLast_ = 0;
                }
                public virtual void Dispose()
                {
                }

                public string GetMainScriptID()
                {
                    return mainScriptID_;
                }
                public void SetMainScriptID(string id)
                {
                    mainScriptID_ = id;
                }
                public string GetMainScriptName()
                {
                    return mainScriptName_;
                }
                public void SetMainScriptName(string name)
                {
                    mainScriptName_ = name;
                }
                public string GetMainScriptRelativePath()
                {
                    return mainScriptRelativePath_;
                }
                public void SetMainScriptRelativePath(string path)
                {
                    mainScriptRelativePath_ = path;
                }
                public _int64 GetStartScore()
                {
                    return scoreStart_;
                }
                public void SetStartScore(_int64 score)
                {
                    scoreStart_ = score;
                }
                public _int64 GetLastScore()
                {
                    return scoreLast_;
                }
                public void SetLastScore(_int64 score)
                {
                    scoreLast_ = score;
                }
                public _int64 GetGraze()
                {
                    return graze_;
                }
                public void SetGraze(_int64 graze)
                {
                    graze_ = graze;
                }
                public _int64 GetPoint()
                {
                    return point_;
                }
                public void SetPoint(_int64 point)
                {
                    point_ = point;
                }
                public int GetEndFrame()
                {
                    return frameEnd_;
                }
                public void SetEndFrame(int frame)
                {
                    frameEnd_ = frame;
                }
                public int GetRandSeed()
                {
                    return randSeed_;
                }
                public void SetRandSeed(int seed)
                {
                    randSeed_ = seed;
                }
                public float GetFramePerSecond(int frame)
                {
                    int index = frame / 60;
                    int res = index < listFramePerSecond_.size() ? listFramePerSecond_[index] : 0;
                    return res;
                }
                public void AddFramePerSecond(float frame)
                {
                    listFramePerSecond_.push_back(frame);
                }

                // ReplayInformation::StageData
                public double GetFramePerSecondAvarage()
                {
                    double res = 0;
                    for (int iFrame = 0 ; iFrame < listFramePerSecond_.size(); iFrame++)
                    {
                        res += listFramePerSecond_[iFrame];
                    }

                    if (listFramePerSecond_.size() > 0)
                    {
                        res /= listFramePerSecond_.size();
                    }
                    return res;
                }

                public ref_count_ptr<gstd.RecordBuffer> GetReplayKeyRecord()
                {
                    return recordKey_;
                }
                public void SetReplayKeyRecord(ref_count_ptr<gstd.RecordBuffer> rec)
                {
                    recordKey_ = rec;
                }
                public SortedSet<string> GetCommonDataAreaList()
                {
                    SortedSet<string> res = new SortedSet<string>();
                    SortedDictionary<string, ref_count_ptr<RecordBuffer>>.Enumerator itrCommonData;
                    for (itrCommonData = mapCommonData_.begin(); itrCommonData.MoveNext();)
                    {
                        string key = itrCommonData.Current.Key;
                        res.Add(key);
                    }
                    return new SortedSet<string>(res);
                }

                public ref_count_ptr<ScriptCommonData> GetCommonData(string area)
                {
                    ref_count_ptr<ScriptCommonData> res = new ScriptCommonData();
                    if (mapCommonData_.find(area) != mapCommonData_.end())
                    {
                        ref_count_ptr<RecordBuffer> record = mapCommonData_[area];
                        res.ReadRecord(*record);
                    }
                    return new ref_count_ptr<ScriptCommonData>(res);
                }

                public void SetCommonData(string area, ref_count_ptr<ScriptCommonData> commonData)
                {
                    ref_count_ptr<RecordBuffer> record = new RecordBuffer();
                    if (commonData != null)
                    {
                        commonData.WriteRecord(*record);
                    }
                    mapCommonData_[area] = record;
                }

                public string GetPlayerScriptID()
                {
                    return playerScriptID_;
                }
                public void SetPlayerScriptID(string id)
                {
                    playerScriptID_ = id;
                }
                public string GetPlayerScriptFileName()
                {
                    return playerScriptFileName_;
                }
                public void SetPlayerScriptFileName(string name)
                {
                    playerScriptFileName_ = name;
                }
                public string GetPlayerScriptReplayName()
                {
                    return playerScriptReplayName_;
                }
                public void SetPlayerScriptReplayName(string name)
                {
                    playerScriptReplayName_ = name;
                }
                public double GetPlayerLife()
                {
                    return playerLife_;
                }
                public void SetPlayerLife(double life)
                {
                    playerLife_ = life;
                }
                public double GetPlayerBombCount()
                {
                    return playerBombCount_;
                }
                public void SetPlayerBombCount(double bomb)
                {
                    playerBombCount_ = bomb;
                }
                public double GetPlayerPower()
                {
                    return playerPower_;
                }
                public void SetPlayerPower(double power)
                {
                    playerPower_ = power;
                }
                public int GetPlayerRebirthFrame()
                {
                    return playerRebirthFrame_;
                }
                public void SetPlayerRebirthFrame(int frame)
                {
                    playerRebirthFrame_ = frame;
                }

                public void ReadRecord(gstd.RecordBuffer record)
                {
                    mainScriptID_ = record.GetRecordAsStringW("mainScriptID");
                    mainScriptName_ = record.GetRecordAsStringW("mainScriptName");
                    mainScriptRelativePath_ = record.GetRecordAsStringW("mainScriptRelativePath");
                    if (record.IsExists("scoreStart"))
                    {
                        record.GetRecord("scoreStart", scoreStart_, sizeof(_int64));
                    }
                    if (record.IsExists("scoreLast"))
                    {
                        record.GetRecord("scoreLast", scoreLast_, sizeof(_int64));
                    }
                    record.GetRecord("graze", graze_, sizeof(_int64));
                    record.GetRecord("point", point_, sizeof(_int64));
                    frameEnd_ = record.GetRecordAsInteger("frameEnd");
                    randSeed_ = record.GetRecordAsInteger("randSeed");
                    record.GetRecordAsRecordBuffer("recordKey", *recordKey_);

                    int countFramePerSecond = record.GetRecordAsInteger("countFramePerSecond");
                    listFramePerSecond_.resize(countFramePerSecond);
                    record.GetRecord("listFramePerSecond", listFramePerSecond_[0], sizeof(float) * listFramePerSecond_.size());

                    // ���ʃf�[�^
                    gstd.RecordBuffer recComMap = new gstd.RecordBuffer();
                    record.GetRecordAsRecordBuffer("mapCommonData", recComMap);
                    List<string> listKeyCommonData = recComMap.GetKeyList();
                    for (int iCommonData = 0 ; iCommonData < listKeyCommonData.Count ; iCommonData++)
                    {
                        string key = listKeyCommonData[iCommonData];
                        ref_count_ptr<RecordBuffer> recComData = new RecordBuffer();
                        recComMap.GetRecordAsRecordBuffer(key, *recComData);
                        mapCommonData_[key] = recComData;
                    }

                    // ���@���
                    playerScriptID_ = record.GetRecordAsStringW("playerScriptID");
                    playerScriptFileName_ = record.GetRecordAsStringW("playerScriptFileName");
                    playerScriptReplayName_ = record.GetRecordAsStringW("playerScriptReplayName");
                    playerLife_ = record.GetRecordAsDouble("playerLife");
                    playerBombCount_ = record.GetRecordAsDouble("playerBombCount");
                    playerPower_ = record.GetRecordAsDouble("playerPower");
                    playerRebirthFrame_ = record.GetRecordAsInteger("playerRebirthFrame");
                }

                public void WriteRecord(gstd.RecordBuffer record)
                {
                    record.SetRecordAsStringW("mainScriptID", mainScriptID_);
                    record.SetRecordAsStringW("mainScriptName", mainScriptName_);
                    record.SetRecordAsStringW("mainScriptRelativePath", mainScriptRelativePath_);
                    record.SetRecord("scoreStart", scoreStart_, sizeof(_int64));
                    record.SetRecord("scoreLast", scoreLast_, sizeof(_int64));
                    record.SetRecord("graze", graze_, sizeof(_int64));
                    record.SetRecord("point", point_, sizeof(_int64));
                    record.SetRecordAsInteger("frameEnd", frameEnd_);
                    record.SetRecordAsInteger("randSeed", randSeed_);
                    record.SetRecordAsRecordBuffer("recordKey", *recordKey_);

                    int countFramePerSecond = listFramePerSecond_.size();
                    record.SetRecordAsInteger("countFramePerSecond", countFramePerSecond);
                    record.SetRecord("listFramePerSecond", listFramePerSecond_[0], sizeof(float) * listFramePerSecond_.size());

                    // ���ʃf�[�^
                    gstd.RecordBuffer recComMap = new gstd.RecordBuffer();
                    SortedDictionary<string, ref_count_ptr<RecordBuffer>>.Enumerator itrCommonData;
                    for (itrCommonData = mapCommonData_.begin(); itrCommonData.MoveNext();)
                    {
                        string key = itrCommonData.Current.Key;
                        ref_count_ptr<RecordBuffer> recComData = itrCommonData.Current.Value;
                        recComMap.SetRecordAsRecordBuffer(key, *recComData);
                    }
                    record.SetRecordAsRecordBuffer("mapCommonData", recComMap);

                    // ���@���
                    record.SetRecordAsStringW("playerScriptID", playerScriptID_);
                    record.SetRecordAsStringW("playerScriptFileName", playerScriptFileName_);
                    record.SetRecordAsStringW("playerScriptReplayName", playerScriptReplayName_);
                    record.SetRecordAsDouble("playerLife", playerLife_);
                    record.SetRecordAsDouble("playerBombCount", playerBombCount_);
                    record.SetRecordAsDouble("playerPower", playerPower_);
                    record.SetRecordAsInteger("playerRebirthFrame", playerRebirthFrame_);
                }
        }
        private string path_ = "";
        private string playerScriptID_ = "";
        private string playerScriptFileName_ = "";
        private string playerScriptReplayName_ = "";

        private string comment_ = "";
        private string userName_ = "";
        private _int64 totalScore_ = new _int64();
        private double fpsAvarage_;
        private SYSTEMTIME date_ = new SYSTEMTIME();
        private ref_count_ptr<ScriptCommonData> userData_ = new ref_count_ptr<ScriptCommonData>();
        private SortedDictionary<int, ref_count_ptr<StageData>> mapStageData_ = new SortedDictionary<int, ref_count_ptr<StageData>>();


        /**********************************************************
        //ReplayInformation
        **********************************************************/
        public ReplayInformation()
        {
            userData_ = new ScriptCommonData();
        }

        public virtual void Dispose()
        {
        }

        public string GetPath()
        {
            return path_;
        }
        public string GetPlayerScriptID()
        {
            return playerScriptID_;
        }
        public void SetPlayerScriptID(string id)
        {
            playerScriptID_ = id;
        }
        public string GetPlayerScriptFileName()
        {
            return playerScriptFileName_;
        }
        public void SetPlayerScriptFileName(string name)
        {
            playerScriptFileName_ = name;
        }
        public string GetPlayerScriptReplayName()
        {
            return playerScriptReplayName_;
        }
        public void SetPlayerScriptReplayName(string name)
        {
            playerScriptReplayName_ = name;
        }

        public string GetComment()
        {
            return comment_;
        }
        public void SetComment(string comment)
        {
            comment_ = comment;
        }
        public string GetUserName()
        {
            return userName_;
        }
        public void SetUserName(string name)
        {
            userName_ = name;
        }
        public _int64 GetTotalScore()
        {
            return new _int64(totalScore_);
        }
        public void SetTotalScore(_int64 score)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: totalScore_ = score;
            totalScore_.CopyFrom(score);
        }
        public double GetAvarageFps()
        {
            return fpsAvarage_;
        }
        public void SetAvarageFps(double fps)
        {
            fpsAvarage_ = fps;
        }
        public SYSTEMTIME GetDate()
        {
            return new SYSTEMTIME(date_);
        }
        public void SetDate(SYSTEMTIME date)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: date_ = date;
            date_.CopyFrom(date);
        }
        public string GetDateAsString()
        {
            string res = StringUtility.Format("%04d/%02d/%02d %02d:%02d", date_.wYear, date_.wMonth, date_.wDay, date_.wHour, date_.wMinute);

            return res;
        }

        public void SetUserData(string key, gstd.value val)
        {
            userData_.SetValue(key, val);
        }

        public gstd.value GetUserData(string key)
        {
            gstd.value res = userData_.GetValue(key);
            return new gstd.value(res);
        }

        public bool IsUserDataExists(string key)
        {
            bool res = userData_.IsExists(key);
            return res;
        }

        public ref_count_ptr<StageData> GetStageData(int stage)
        {
            return new ref_count_ptr<StageData>(mapStageData_[stage]);
        }
        public void SetStageData(int stage, ref_count_ptr<StageData> data)
        {
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mapStageData_[stage] = data;
            mapStageData_[stage].CopyFrom(data);
        }
        public List<int> GetStageIndexList()
        {
            List<int> res = new List<int>();

            SortedDictionary<int, ref_count_ptr<StageData>>.Enumerator itr = mapStageData_.GetEnumerator();
            while (itr.MoveNext())
            {
                int stage = itr.Current.Key;
                res.Add(stage);
            }

            res.Sort();
            return new List<int>(res);
        }

        public bool SaveToFile(string scriptPath, int index)
        {
            string dir = EPathProperty.GetReplaySaveDirectory(scriptPath);
            string scriptName = PathProperty.GetFileNameWithoutExtension(scriptPath);
            string path = dir + scriptName + StringUtility.Format("_replay%02d.dat", index);

            // �t�H���_�쐬
            File fDir = new File(dir);
            fDir.CreateDirectory();

            RecordBuffer rec = new RecordBuffer();
            rec.SetRecordAsInteger("version", 1);
            rec.SetRecordAsStringW("playerScriptID", playerScriptID_);
            rec.SetRecordAsStringW("playerScriptFileName", playerScriptFileName_);
            rec.SetRecordAsStringW("playerScriptReplayName", playerScriptReplayName_);

            rec.SetRecordAsStringW("comment", comment_);
            rec.SetRecordAsStringW("userName", userName_);
            rec.SetRecord("totalScore", totalScore_);
            rec.SetRecordAsDouble("fpsAvarage", fpsAvarage_);
            rec.SetRecord("date", date_);

            RecordBuffer recUserData = new RecordBuffer();
            userData_.WriteRecord(recUserData);
            rec.SetRecordAsRecordBuffer("userData", recUserData);

            List<int> listStage = GetStageIndexList();
            rec.SetRecordAsInteger("stageCount", listStage.Count);
            rec.SetRecord("stageIndexList", listStage[0], sizeof(int) * listStage.Count);
            for (int iStage = 0 ; iStage < listStage.Count; iStage++)
            {
                int stage = listStage[iStage];
                string key = StringUtility.Format("stage%d", stage);

                ref_count_ptr<StageData> data = mapStageData_[stage];
                gstd.RecordBuffer recStage = new gstd.RecordBuffer();
                data.WriteRecord(recStage);
                rec.SetRecordAsRecordBuffer(key, recStage);
            }

            rec.WriteToFile(path, "REPLAY");
            return true;
        }

        public static ref_count_ptr<ReplayInformation> CreateFromFile(string scriptPath, string fileName)
        {
            string dir = EPathProperty.GetReplaySaveDirectory(scriptPath);
        // 	std::string scriptName = PathProperty::GetFileNameWithoutExtension(scriptPath);
        // 	std::string path = dir + scriptName + StringUtility::Format("_replay%02d.dat", index);
            string path = dir + fileName;

            ref_count_ptr<ReplayInformation> res = CreateFromFile(path);
            return new ref_count_ptr<ReplayInformation>(res);
        }

        public static ref_count_ptr<ReplayInformation> CreateFromFile(string path)
        {
            RecordBuffer rec = new RecordBuffer();
            if (!rec.ReadFromFile(path, "REPLAY"))
            {
                return null;
            }

            int version = rec.GetRecordAsInteger("version");
            if (version != 1)
            {
                return null;
            }

            ref_count_ptr<ReplayInformation> res = new ReplayInformation();
            res.path_ = path;
            res.playerScriptID_ = rec.GetRecordAsStringW("playerScriptID");
            res.playerScriptFileName_ = rec.GetRecordAsStringW("playerScriptFileName");
            res.playerScriptReplayName_ = rec.GetRecordAsStringW("playerScriptReplayName");

            res.comment_ = rec.GetRecordAsStringW("comment");
            res.userName_ = rec.GetRecordAsStringW("userName");
            rec.GetRecord("totalScore", res.totalScore_);
            res.fpsAvarage_ = rec.GetRecordAsDouble("fpsAvarage");
            rec.GetRecord("date", res.date_);

            res.userData_.Clear();
            if (rec.IsExists("userData"))
            {
                RecordBuffer recUserData = new RecordBuffer();
                rec.GetRecordAsRecordBuffer("userData", recUserData);
                res.userData_.ReadRecord(recUserData);
            }

            int stageCount = rec.GetRecordAsInteger("stageCount");
            List<int> listStage = new List<int>();
            listStage.Resize(stageCount);
            rec.GetRecord("stageIndexList", listStage[0], sizeof(int) * stageCount);
            for (int iStage = 0 ; iStage < listStage.Count; iStage++)
            {
                int stage = listStage[iStage];
                string key = StringUtility.Format("stage%d", stage);
                ref_count_ptr<StageData> data = new StageData();
                gstd.RecordBuffer recStage = new gstd.RecordBuffer();
                rec.GetRecordAsRecordBuffer(key, recStage);
                data.ReadRecord(recStage);
                res.mapStageData_[stage] = data;
            }

            return new ref_count_ptr<ReplayInformation>(res);
        }
}


/**********************************************************
//ReplayInformationManager
**********************************************************/
public class ReplayInformationManager : System.IDisposable
{

        protected SortedDictionary<int, ref_count_ptr<ReplayInformation>> mapInfo_ = new SortedDictionary<int, ref_count_ptr<ReplayInformation>>();

        /**********************************************************
        //ReplayInformationManager
        **********************************************************/
        public ReplayInformationManager()
        {

        }

        public virtual void Dispose()
        {
        }

        public void UpdateInformationList(string pathScript)
        {
            mapInfo_.Clear();

            string scriptName = PathProperty.GetFileNameWithoutExtension(pathScript);
            string fileNameHead = scriptName + "_replay";
            string dir = EPathProperty.GetReplaySaveDirectory(pathScript);
            List<string> listPath = File.GetFilePathList(dir);

            int indexFree = (int)ReplayInformation.AnonymousEnum.INDEX_USER;
            List<string>.Enumerator itr;
            for (itr = listPath.GetEnumerator(); itr.MoveNext();)
            {
                string path = itr.Current;
                string fileName = PathProperty.GetFileName(path);

                if (fileName.IndexOf(fileNameHead) == -1)
                {
                    continue;
                }

                ref_count_ptr<ReplayInformation> info = ReplayInformation.CreateFromFile(pathScript, fileName);
                if (info == null)
                {
                    continue;
                }

                string strKey = fileName.Substring(fileNameHead.Length);
                strKey = PathProperty.GetFileNameWithoutExtension(strKey);
                int index = StringUtility.ToInteger(strKey);
                if (index > 0)
                {
                    strKey = StringUtility.Format("%d", index);
                }
                else
                {
                    index = indexFree;
                    indexFree++;
                    strKey = StringUtility.Format("%d", index);
                }

                int key = StringUtility.ToInteger(strKey);
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: mapInfo_[key] = info;
                mapInfo_[key].CopyFrom(info);
            }

        }

        public List<int> GetIndexList()
        {
            List<int> res = new List<int>();
            SortedDictionary<int, ref_count_ptr<ReplayInformation>>.Enumerator itr;
            for (itr = mapInfo_.GetEnumerator(); itr.MoveNext();)
            {
                int key = itr.Current.Key;
                res.Add(key);
            }
            return new List<int>(res);
        }

        public ref_count_ptr<ReplayInformation> GetInformation(int index)
        {
            if (!mapInfo_.ContainsKey(index))
            {
                return null;
            }
            return new ref_count_ptr<ReplayInformation>(mapInfo_[index]);
        }
}
