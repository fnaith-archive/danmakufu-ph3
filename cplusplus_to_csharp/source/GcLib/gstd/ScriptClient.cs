using gstd;
using System;
using System.Collections.Generic;

namespace gstd
{

    /**********************************************************
    //ScriptBase
    **********************************************************/
    public class ScriptClientBase : System.IDisposable
    {
            private static script_type_manager typeManagerDefault_ = new script_type_manager();
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            public enum AnonymousEnum
            {
                ID_SCRIPT_FREE = -1
            }
            public static script_type_manager GetDefaultScriptTypeManager()
            {
                return new gstd.script_type_manager(typeManagerDefault_);
            }

            protected bool bError_;
            protected gstd.ref_count_ptr<ScriptEngineCache> cache_ = new gstd.ref_count_ptr<ScriptEngineCache>();
            protected gstd.ref_count_ptr<ScriptEngineData> engine_ = new gstd.ref_count_ptr<ScriptEngineData>();
            protected script_machine machine_;

            protected List<function> func_ = new List<function>();
            protected ref_count_ptr<MersenneTwister> mt_ = new ref_count_ptr<MersenneTwister>();
            protected gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager_ = new gstd.ref_count_ptr<ScriptCommonDataManager>();
            protected int mainThreadID_;
            protected _int64 idScript_ = new _int64();

            protected gstd.CriticalSection criticalSection_ = new gstd.CriticalSection();

            protected List<gstd.value> listValueArg_ = new List<gstd.value>();
            protected gstd.value valueRes_ = new gstd.value();

            protected string _ExtendPath(string path)
            {
                int line = machine_.get_current_line();
                string pathScript = GetEngine().GetScriptFileLineMap().GetPath(line);

                path = StringUtility.ReplaceAll(path, "\\", "/");
                path = StringUtility.ReplaceAll(path, "./", pathScript);

                return path;
            }

            public ScriptClientBase()
            {
                bError_ = false;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                engine_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptEngineData();
                machine_ = null;
                mainThreadID_ = -1;
                idScript_ = AnonymousEnum.ID_SCRIPT_FREE;
                valueRes_ = new value();

            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                commonDataManager_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonDataManager();
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mt_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new MersenneTwister();
                mt_.Initialize(timeGetTime());
// C++ TO C# CONVERTER WARNING: This 'sizeof' ratio was replaced with a direct reference to the array length:
// ORIGINAL LINE: _AddFunction(commonFunction, sizeof(commonFunction)/sizeof(function));
                _AddFunction(GlobalMembers.commonFunction, GlobalMembers.commonFunction.Length);
            }

            public void SetScriptEngineCache(gstd.ref_count_ptr<ScriptEngineCache> cache)
            {
                cache_.CopyFrom(cache);
            }

            public virtual void SetSource(List<char> source)
            {
                engine_.SetSource(source);
                gstd.ref_count_ptr<ScriptFileLineMap> mapLine = engine_.GetScriptFileLineMap();
                mapLine.AddEntry(engine_.GetPath(), 1, StringUtility.CountCharacter(source, '\n') + 1);
            }

            public virtual void SetSource(string source)
            {
                List<char> vect = new List<char>();
                vect.Resize(source.Length);
// C++ TO C# CONVERTER TODO TASK: The memory management function 'memcpy' has no equivalent in C#:
                memcpy(vect[0], source[0], source.Length);
                this.SetSource(vect);
            }

            public void CheckRunInMainThread()
            {
                if (mainThreadID_ < 0)
                {
                    return;
                }
                if (mainThreadID_ != GetCurrentThreadId())
                {
                    string error;
                    error += "This function can call in main thread only.\r\n";
                    error += "(���C���X���b�h�ȊO�ł͎��s�ł��܂���B)";
                    machine_.raise_error(error);
                }
            }

            public ScriptCommonDataManager GetCommonDataManager()
            {
                return commonDataManager_.GetPointer();
            }

            // ���ʊ֐��F�X�N���v�g��������

            // ���ʊ֐��F�X�N���v�g��������
            public static value Func_GetScriptArgument(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                int index = (int)argv[0].as_real();
                if (index < 0 || index >= script.listValueArg_.Count)
                {
                    string error;
                    error += "Invalid script argument index.\r\n";
                    error += "(�X�N���v�g�����̃C���f�b�N�X���s���ł��B)";
                    throw new gstd.wexception(error);
                }
                return new gstd.value(script.listValueArg_[index]);
            }

            public static value Func_GetScriptArgumentCount(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                int res = script.listValueArg_.Count;
                return new value(machine.get_engine().get_real_type(), (double)res);
            }

            public static value Func_SetScriptResult(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                script.valueRes_.CopyFrom(argv[0]);
                return new value();
            }

            // ���ʊ֐��F���w�n

            // �g�ݍ��݊֐��F���w�n
            public static value Func_Min(script_machine machine, int argc, value[] argv)
            {
                double v1 = argv[0].as_real();
                double v2 = argv[1].as_real();
                double res = v1 <= v2 ? v1 : v2;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_Max(script_machine machine, int argc, value[] argv)
            {
                double v1 = argv[0].as_real();
                double v2 = argv[1].as_real();
                double res = v1 >= v2 ? v1 : v2;
                return new value(machine.get_engine().get_real_type(), res);
            }

            public static value Func_Log(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Log(argv[0].as_real()));
            }

            public static value Func_Log10(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Log10(argv[0].as_real()));
            }

            public static value Func_Cos(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Cos(Math.DegreeToRadian(argv[0].as_real())));
            }

            public static value Func_Sin(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Sin(Math.DegreeToRadian(argv[0].as_real())));
            }

            public static value Func_Tan(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)System.Math.Tan(Math.DegreeToRadian(argv[0].as_real())));
            }

            public static value Func_Acos(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Acos(argv[0].as_real())));
            }

            public static value Func_Asin(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Asin(argv[0].as_real())));
            }

            public static value Func_Atan(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Atan(argv[0].as_real())));
            }

            public static value Func_Atan2(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_real_type(), (double)Math.RadianToDegree(System.Math.Atan2(argv[0].as_real(),argv[1].as_real())));
            }

            public static value Func_Rand(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                script.CheckRunInMainThread();

                double min = argv[0].as_real();
                double max = argv[1].as_real();
                double res = script.mt_.GetReal(min, max);
                return new value(machine.get_engine().get_real_type(), res);
            }

            // ���ʊ֐��F�����񑀍�

            // �g�ݍ��݊֐��F�����񑀍�
            public static value Func_ToString(script_machine machine, int argc, value[] argv)
            {
                return new value(machine.get_engine().get_string_type(), argv[0].as_string());
            }

            public static value Func_IntToString(script_machine machine, int argc, value[] argv)
            {
                string res = StringUtility.Format("%d", (int)argv[0].as_real());
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_ItoA(script_machine machine, int argc, value[] argv)
            {
                string res = StringUtility.Format("%d", (int)argv[0].as_real());
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_RtoA(script_machine machine, int argc, value[] argv)
            {
                string res = StringUtility.Format("%f", argv[0].as_real());
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_RtoS(script_machine machine, int argc, value[] argv)
            {
                string res = "";
                string fmtV = to_mbcs(argv[0].as_string());
                double num = argv[1].as_real();

                try
                {
                    bool bF = false;
                    int countIS = 0;
                    int countI0 = 0;
                    int countF = 0;

                    for (int iCh = 0 ; iCh < fmtV.Length ; iCh++)
                    {
                        char ch = fmtV[iCh];
                        if (IsDBCSLeadByte(ch))
                        {
                            throw false;
                        }

                        if (ch == '#')
                        {
                            countIS++;
                        }
                        else if (ch == '.' && bF)
                        {
                            throw false;
                        }
                        else if (ch == '.')
                        {
                            bF = true;
                        }
                        else if (ch == '0')
                        {
                            if (bF)
                            {
                                countF++;
                            }
                            else
                            {
                                countI0++;
                            }
                        }
                    }

                    string fmt = "";
                    if (countI0 > 0 && countF >= 0)
                    {
                        fmt += "%0";
                        fmt += StringUtility.Format("%d", countI0);
                        fmt += ".";
                        fmt += StringUtility.Format("%d", countF);
                        fmt += "f";
                    }
                    else if (countIS > 0 && countF >= 0)
                    {
                        fmt += "%";
                        fmt += StringUtility.Format("%d", countIS);
                        fmt += ".";
                        fmt += StringUtility.Format("%d", countF);
                        fmt += "f";
                    }

                    if (fmt.Length > 0)
                    {
                        res = StringUtility.Format(ref (string)fmt, num);
                    }
                }
                catch
                {
                    res = "error format";
                }

                return new value(machine.get_engine().get_string_type(), to_wide(res));
            }

            public static value Func_VtoS(script_machine machine, int argc, value[] argv)
            {
                string res = "";
                string fmtV = to_mbcs(argv[0].as_string());

                try
                {
                    int countIS = 0;
                    int countI0 = 0;
                    int countF = 0;

                    int advance = 0; // 0:-, 1:0, 2:num, 3:[d,s,f], 4:., 5:num
                    for (int iCh = 0 ; iCh < fmtV.Length ; iCh++)
                    {
                        char ch = fmtV[iCh];
                        if (IsDBCSLeadByte(ch))
                        {
                            throw false;
                        }
                        if (advance == 0 && ch == '-')
                        {
                            advance = 1;
                        }
                        else if ((advance == 0 || advance == 1 || advance == 2) && (ch >= '0' && ch <= '9'))
                        {
                            advance = 2;
                        }
                        else if (advance == 2 && (ch == 'd' || ch == 's' || ch == 'f'))
                        {
                            advance = 4;
                        }
                        else if (advance == 2 && ('.'))
                        {
                            advance = 5;
                        }
                        else if (advance == 4 && ('.'))
                        {
                            advance = 5;
                        }
                        else if (advance == 5 && (ch >= '0' && ch <= '9'))
                        {
                            advance = 5;
                        }
                        else if (advance == 5 && (ch == 'd' || ch == 's' || ch == 'f'))
                        {
                            advance = 6;
                        }
                        else
                        {
                            throw false;
                        }
                    }

                    fmtV = "%" + fmtV;
// C++ TO C# CONVERTER TODO TASK: C# does not have an equivalent to pointers to value types:
// ORIGINAL LINE: char* fmt = (char*)fmtV.c_str();
                    char fmt = (string)fmtV;
                    if (strstr(fmt, "d") != null)
                    {
                        res = StringUtility.Format(ref fmt, (int)argv[1].as_real());
                    }
                    else if (strstr(fmt, "f") != null)
                    {
                        res = StringUtility.Format(ref fmt, argv[1].as_real());
                    }
                    else if (strstr(fmt, "s") != null)
                    {
                        res = StringUtility.Format(ref fmt, to_mbcs(argv[1].as_string()).c_str());
                    }
                }
                catch
                {
                    res = "error format";
                }

                return new value(machine.get_engine().get_string_type(), to_wide(res));
            }

            public static value Func_AtoI(script_machine machine, int argc, value[] argv)
            {
                string str = argv[0].as_string();
                int num = StringUtility.ToInteger(str);
                return new value(machine.get_engine().get_real_type(), (double)num);
            }

            public static value Func_AtoR(script_machine machine, int argc, value[] argv)
            {
                string str = argv[0].as_string();
                double num = StringUtility.ToDouble(str);
                return new value(machine.get_engine().get_real_type(), (double)num);
            }

            public static value Func_TrimString(script_machine machine, int argc, value[] argv)
            {
                string str = argv[0].as_string();
                string res = StringUtility.Trim(str);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_SplitString(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string str = argv[0].as_string();
                string delim = argv[1].as_string();
                List<string> list = StringUtility.Split(str, delim);

                gstd.value res = script.CreateStringArrayValue(list);
                return new gstd.value(res);
            }

            // ���ʊ֐��F�p�X�֘A

            // ���ʊ֐��F�p�X�֘A
            public static value Func_GetModuleDirectory(script_machine machine, int argc, value argv)
            {
                string res = PathProperty.GetModuleDirectory();
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetMainScriptDirectory(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = script.GetEngine().GetPath();
                string res = PathProperty.GetFileDirectory(path);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetCurrentScriptDirectory(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                int line = machine.get_current_line();
                string path = script.GetEngine().GetScriptFileLineMap().GetPath(line);
                string res = PathProperty.GetFileDirectory(path);
                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetFileDirectory(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = argv[0].as_string();
                // path = StringUtility::ReplaceAll(path, "/", "\\");
                string res = PathProperty.GetFileDirectory(path);

                return new value(machine.get_engine().get_string_type(), res);
            }

            public static value Func_GetFilePathList(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = argv[0].as_string();
                string dir = PathProperty.GetFileDirectory(path);
                List<string> listDir = File.GetFilePathList(dir);
                gstd.value res = script.CreateStringArrayValue(listDir);
                return new gstd.value(res);
            }

            public static value Func_GetDirectoryList(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string path = argv[0].as_string();
                string dir = PathProperty.GetFileDirectory(path);
                List<string> listDir = File.GetDirectoryPathList(dir);
                gstd.value res = script.CreateStringArrayValue(listDir);
                return new gstd.value(res);
            }

            // ���ʊ֐��F�����֘A

            // ���ʊ֐��F�����֘A
            public static value Func_GetCurrentDateTimeS(script_machine machine, int argc, value argv)
            {
                SYSTEMTIME date = new SYSTEMTIME();
                GetLocalTime(date);

                string strDateTime = StringUtility.Format("%04d%02d%02d%02d%02d%02d", date.wYear, date.wMonth, date.wDay, date.wHour, date.wMinute, date.wSecond);
                string res = strDateTime;
                return new value(machine.get_engine().get_string_type(), res);
            }

            // ���ʊ֐��F�f�o�b�O�֘A

            // ���ʊ֐��F�f�o�b�O�֘A
            public static value Func_WriteLog(script_machine machine, int argc, value[] argv)
            {
                string msg = argv[0].as_string();
                Logger.WriteTop(msg);
                return new value();
            }

            public static value Func_RaiseError(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                string msg = argv[0].as_string();
                script.RaiseError(msg);

                return new value();
            }

            // ���ʊ֐��F���ʃf�[�^

            // ���ʊ֐��F���ʃf�[�^
            public static value Func_SetDefaultCommonDataArea(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string name = to_mbcs(argv[0].as_string());
                commonDataManager.SetDefaultAreaName(name);

                return new value();
            }

            public static value Func_SetCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                string key = to_mbcs(argv[0].as_string());
                value val = argv[1];
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.SetValue(key, val);
                return new value();
            }

            public static value Func_GetCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                string key = to_mbcs(argv[0].as_string());
                value dv = argv[1];
                if (!commonDataManager.IsExists(area))
                {
                    return new gstd.value(dv);
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                if (!data.IsExists(key))
                {
                    return new gstd.value(dv);
                }
                return data.GetValue(key);
            }

            public static value Func_ClearCommonData(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.Clear();
                return new value();
            }

            public static value Func_DeleteCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
                string area = commonDataManager.GetDefaultAreaName();

                string key = to_mbcs(argv[0].as_string());
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.DeleteValue(key);
                return new value();
            }

            public static value Func_SetAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                string key = to_mbcs(argv[1].as_string());
                value val = argv[2];

                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.SetValue(key, val);

                return new value();
            }

            public static value Func_GetAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                string key = to_mbcs(argv[1].as_string());
                value dv = argv[2];
                if (!commonDataManager.IsExists(area))
                {
                    return new gstd.value(dv);
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                if (!data.IsExists(key))
                {
                    return new gstd.value(dv);
                }
                return data.GetValue(key);
            }

            public static value Func_ClearAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.Clear();
                return new value();
            }

            public static value Func_DeleteAreaCommonData(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                string key = to_mbcs(argv[1].as_string());
                if (!commonDataManager.IsExists(area))
                {
                    return new value();
                }
                gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                data.DeleteValue(key);
                return new value();
            }

            public static value Func_CreateCommonDataArea(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                commonDataManager.CreateArea(area);

                return new value();
            }

            public static value Func_CopyCommonDataArea(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string areaDest = to_mbcs(argv[0].as_string());
                string areaSrc = to_mbcs(argv[1].as_string());
                if (commonDataManager.IsExists(areaSrc))
                {
                    commonDataManager.CopyArea(areaDest, areaSrc);
                }

                return new value();
            }

            public static value Func_IsCommonDataAreaExists(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                string area = to_mbcs(argv[0].as_string());
                bool res = commonDataManager.IsExists(area);
                return new value(machine.get_engine().get_boolean_type(), res);
            }

            public static value Func_GetCommonDataAreaKeyList(script_machine machine, int argc, value argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                List<string> listKey = commonDataManager.GetKeyList();
                gstd.value res = script.CreateStringArrayValue(listKey);
                return new gstd.value(res);
            }

            public static value Func_GetCommonDataValueKeyList(script_machine machine, int argc, value[] argv)
            {
                ScriptClientBase script = (ScriptClientBase)machine.data;
                ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

                List<string> listKey = new List<string>();
                string area = to_mbcs(argv[0].as_string());
                if (commonDataManager.IsExists(area))
                {
                    gstd.ref_count_ptr<ScriptCommonData> data = commonDataManager.GetData(area);
                    listKey = data.GetKeyList();
                }
                gstd.value res = script.CreateStringArrayValue(listKey);
                return new gstd.value(res);
            }

    }

    /**********************************************************
    //ScriptCommonDataManager
    **********************************************************/
    public class ScriptCommonDataManager : System.IDisposable
    {
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();
            protected string nameAreaDefailt_ = "";
            protected SortedDictionary<string, gstd.ref_count_ptr<ScriptCommonData>> mapData_ = new SortedDictionary<string, gstd.ref_count_ptr<ScriptCommonData>>();

            /**********************************************************
            //ScriptCommonDataManager
            **********************************************************/
            public ScriptCommonDataManager()
            {
                nameAreaDefailt_ = "";
                CreateArea("");
            }

            public virtual void Dispose()
            {
            }

            public void Clear()
            {
                mapData_.Clear();
            }

            public string GetDefaultAreaName()
            {
                return nameAreaDefailt_;
            }
            public void SetDefaultAreaName(string name)
            {
                nameAreaDefailt_ = name;
            }
            public bool IsExists(string name)
            {
                return mapData_.ContainsKey(name);
            }

            public void CreateArea(string name)
            {
                if (IsExists(name))
                {
                    return;
                }
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                mapData_[name] = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonData();
            }

            public void CopyArea(string nameDest, string nameSrc)
            {
                gstd.ref_count_ptr<ScriptCommonData> dataSrc = mapData_[nameSrc];
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                gstd.ref_count_ptr<ScriptCommonData> dataDest = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonData();
                dataDest.Copy(dataSrc);
                mapData_[nameDest].CopyFrom(dataDest);
            }

            public gstd.ref_count_ptr<ScriptCommonData> GetData(string name)
            {
                if (!IsExists(name))
                {
                    return null;
                }
                return new gstd.ref_count_ptr<ScriptCommonData>(mapData_[name]);
            }

            public void SetData(string name, gstd.ref_count_ptr<ScriptCommonData> commonData)
            {
                mapData_[name].CopyFrom(commonData);
            }

            public List<string> GetKeyList()
            {
                List<string> res = new List<string>();
                SortedDictionary<string, gstd.ref_count_ptr<ScriptCommonData>>.Enumerator itrValue;
                for (itrValue = mapData_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string key = itrValue.Current.Key;
                    res.Add(key);
                }
                return new List<string>(res);
            }

            public gstd.CriticalSection GetLock()
            {
                return new gstd.CriticalSection(lock_);
            }
    }

    /**********************************************************
    //ScriptCommonData
    **********************************************************/
    public class ScriptCommonData : System.IDisposable
    {
            protected SortedDictionary<string, gstd.value> mapValue_ = new SortedDictionary<string, gstd.value>();

            protected gstd.value _ReadRecord(gstd.ByteBuffer buffer)
            {
                script_type_manager scriptTypeManager = ScriptClientBase.GetDefaultScriptTypeManager();
                gstd.value res = new gstd.value();
                type_data.type_kind kind = (type_data.type_kind)buffer.ReadInteger();

                if (kind == type_data.tk_real)
                {
                    double data = buffer.ReadDouble();
                    res = new gstd.value(scriptTypeManager.get_real_type(), data);
                }
                else if (kind == type_data.tk_char)
                {
                    char data;
                    buffer.Read(data, sizeof(char));
                    res = new gstd.value(scriptTypeManager.get_char_type(), data);
                }
                else if (kind == type_data.tk_boolean)
                {
                    bool data = buffer.ReadBoolean();
                    res = new gstd.value(scriptTypeManager.get_boolean_type(), data);
                }
                else if (kind == type_data.tk_array)
                {
                    int arrayLength = buffer.ReadInteger();
                    value v = new value();
                    for (int iArray = 0 ; iArray < arrayLength ; iArray++)
                    {
                        value arrayValue = _ReadRecord(buffer);
                        v.append(scriptTypeManager.get_array_type(arrayValue.get_type()), arrayValue);
                    }
                    res.CopyFrom(v);
                }

                return new gstd.value(res);
            }

            protected void _WriteRecord(gstd.ByteBuffer buffer, gstd.value comValue)
            {
                type_data.type_kind kind = comValue.get_type().get_kind();
                buffer.WriteInteger((int)kind);
                if (kind == type_data.tk_real)
                {
                    buffer.WriteDouble(comValue.as_real());
                }
                else if (kind == type_data.tk_char)
                {
                    char wch = comValue.as_char();
                    buffer.Write(wch, sizeof(char));
                }
                else if (kind == type_data.tk_boolean)
                {
                    buffer.WriteBoolean(comValue.as_boolean());
                }
                else if (kind == type_data.tk_array)
                {
                    int arrayLength = (int)comValue.length_as_array();
                    buffer.WriteInteger(arrayLength);

                    for (int iArray = 0 ; iArray < arrayLength ; iArray++)
                    {
                        value arrayValue = comValue.index_as_array((uint)iArray);
                        _WriteRecord(buffer, arrayValue);
                    }
                }
            }

            /**********************************************************
            //ScriptCommonData
            **********************************************************/
            public ScriptCommonData()
            {
            }

            public virtual void Dispose()
            {
            }

            public void Clear()
            {
                mapValue_.Clear();
            }

            public bool IsExists(string name)
            {
                return mapValue_.ContainsKey(name);
            }

            public gstd.value GetValue(string name)
            {
                if (!IsExists(name))
                {
                    return new value();
                }
                return new gstd.value(mapValue_[name]);
            }

            public void SetValue(string name, gstd.value v)
            {
                mapValue_[name].CopyFrom(v);
            }

            public void DeleteValue(string name)
            {
                mapValue_.Remove(name);
            }

            public void Copy(gstd.ref_count_ptr<ScriptCommonData> dataSrc)
            {
                mapValue_.Clear();
                List<string> listSrcKey = dataSrc.GetKeyList();
                for (int iKey = 0 ; iKey < listSrcKey.Count ; iKey++)
                {
                    string key = listSrcKey[iKey];
                    gstd.value vSrc = dataSrc.GetValue(key);
                    gstd.value vDest = vSrc;
                    vDest.unique();
                    mapValue_[key].CopyFrom(vDest);
                }
            }

            public List<string> GetKeyList()
            {
                List<string> res = new List<string>();
                SortedDictionary<string, gstd.value>.Enumerator itrValue;
                for (itrValue = mapValue_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string key = itrValue.Current.Key;
                    res.Add(key);
                }
                return new List<string>(res);
            }

            public void ReadRecord(gstd.RecordBuffer record)
            {
                mapValue_.Clear();

                List<string> listKey = record.GetKeyList();
                for (int iKey = 0 ; iKey < listKey.Count ; iKey++)
                {
                    string key = listKey[iKey];
                    string keyValSize = StringUtility.Format("%s_size", key);
                    if (!record.IsExists(keyValSize))
                    {
                        continue; // �T�C�Y���g���L�[�o�^����Ă���
                    }
                    int valSize = record.GetRecordAsInteger(keyValSize);

                    gstd.ByteBuffer buffer = new gstd.ByteBuffer();
                    buffer.SetSize(valSize);
                    record.GetRecord(key, buffer.GetPointer(), valSize);
                    gstd.value comVal = _ReadRecord(buffer);
                    mapValue_[key].CopyFrom(comVal);
                }
            }

            public void WriteRecord(gstd.RecordBuffer record)
            {
                SortedDictionary<string, gstd.value>.Enumerator itrValue;
                for (itrValue = mapValue_.GetEnumerator(); itrValue.MoveNext();)
                {
                    string key = itrValue.Current.Key;
                    gstd.value comVal = itrValue.Current.Value;

                    gstd.ByteBuffer buffer = new gstd.ByteBuffer();
                    _WriteRecord(buffer, comVal);
                    string keyValSize = StringUtility.Format("%s_size", key);
                    int valSize = buffer.GetSize();
                    record.SetRecordAsInteger(keyValSize, valSize);
                    record.SetRecord(key, buffer.GetPointer(), valSize);
                }
            }
    }

    /**********************************************************
    //ScriptCommonDataInfoPanel
    **********************************************************/
    public class ScriptCommonDataInfoPanel : WindowLogger.Panel
    {
// C++ TO C# CONVERTER NOTE: Enums must be named in C#, so the following enum has been named by the converter:
            protected enum AnonymousEnum2
            {
                COL_AREA = 0,
                COL_KEY = 0,
                COL_VALUE
            }

            protected gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager_ = new gstd.ref_count_ptr<ScriptCommonDataManager>();
            protected gstd.CriticalSection lock_ = new gstd.CriticalSection();

            protected WSplitter wndSplitter_ = new WSplitter();
            protected WListView wndListViewArea_ = new WListView();
            protected WListView wndListViewValue_ = new WListView();
            protected int timeLastUpdate_;
            protected int timeUpdateInterval_;

            protected virtual bool _AddedLogger(IntPtr hTab)
            {
                Create(hTab);

                gstd.WListView.Style styleListViewArea = new gstd.WListView.Style();
                styleListViewArea.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOCOLUMNHEADER);
                styleListViewArea.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListViewArea.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListViewArea_.Create(hWnd_, styleListViewArea);
                wndListViewArea_.AddColumn(256, 0, "area");

                gstd.WListView.Style styleListViewValue = new gstd.WListView.Style();
                styleListViewValue.SetStyle(WS_CHILD | WS_VISIBLE | LVS_REPORT | LVS_SHOWSELALWAYS | LVS_SINGLESEL | LVS_NOSORTHEADER);
                styleListViewValue.SetStyleEx(WS_EX_CLIENTEDGE);
                styleListViewValue.SetListViewStyleEx(LVS_EX_FULLROWSELECT | LVS_EX_GRIDLINES);
                wndListViewValue_.Create(hWnd_, styleListViewValue);
                wndListViewValue_.AddColumn(96, (int)AnonymousEnum2.COL_KEY, "Key");
                wndListViewValue_.AddColumn(256, (int)AnonymousEnum2.COL_VALUE, "Value");

                wndSplitter_.Create(hWnd_, WSplitter.TYPE_HORIZONTAL);
                wndSplitter_.SetRatioY(0.25f);

                return true;
            }

            protected void _UpdateListViewKey(WListView listView, List<string> listKey)
            {
                SortedSet<string> listManageData = new SortedSet<string>();
                SortedSet<string> listAdd = new SortedSet<string>();

                int iKey = 0;
                for (iKey = 0 ; iKey < listKey.Count ; iKey++)
                {
                    string area = listKey[iKey];
                    listManageData.Add(area);
                    listAdd.Add(area);
                }

                int countView = listView.GetRowCount();
                int iRow = 0;
                for (iRow = 0 ; iRow < countView ; iRow++)
                {
                    string wArea = listView.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                    string area = StringUtility.ConvertWideToMulti(wArea);
                    listAdd.erase(area);
                }

                // �폜
                for (iRow = 0; iRow < listView.GetRowCount();)
                {
                    string wKey = listView.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                    string key = StringUtility.ConvertWideToMulti(wKey);
                    if (listManageData.find(key) != listManageData.end())
                    {
                        iRow++;
                    }
                    else
                    {
                        listView.DeleteRow(iRow);
                    }
                }

                // �ǉ�
                iRow = 0;
                countView = listView.GetRowCount();
                SortedSet<string>.Enumerator itr = listAdd.GetEnumerator();
                while (itr.MoveNext())
                {
                    string str1 = itr.Current;
                    for (;iRow < listView.GetRowCount() ; iRow++)
                    {
                        string wstr2 = listView.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                        string str2 = StringUtility.ConvertWideToMulti(wstr2);
                        int index = strcmp(str1, str2);
                        if (index < 0)
                        {
                            string wstr1 = StringUtility.ConvertMultiToWide(str1);
                            listView.SetText(iRow, (int)AnonymousEnum2.COL_KEY, wstr1);
                            break;
                        }
                    }
                    if (iRow >= listView.GetRowCount())
                    {
                        break;
                    }
// C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
// ORIGINAL LINE: itr = listAdd.erase(itr);
                    itr.CopyFrom(listAdd.erase(itr));
                }

                itr = listAdd.GetEnumerator();
                while (itr.MoveNext())
                {
                    string str1 = itr.Current;
                    string wstr1 = StringUtility.ConvertMultiToWide(str1);
                    listView.SetText(listView.GetRowCount(), (int)AnonymousEnum2.COL_KEY, wstr1);
                }
            }

            protected void _UpdateAreaView()
            {
                List<string> listKey = commonDataManager_.GetKeyList();
                _UpdateListViewKey(wndListViewArea_, new List<string>(listKey));
            }

            protected void _UpdateValueView()
            {
                int indexArea = wndListViewArea_.GetSelectedRow();
                if (indexArea < 0)
                {
                    if (wndListViewValue_.GetRowCount() > 0)
                    {
                        wndListViewValue_.Clear();
                    }
                    return;
                }

                string wArea = wndListViewArea_.GetText(indexArea, (int)AnonymousEnum2.COL_AREA);
                string area = StringUtility.ConvertWideToMulti(wArea);
                gstd.ref_count_ptr<ScriptCommonData> commonData = commonDataManager_.GetData(area);
                List<string> listKey = commonData.GetKeyList();
                _UpdateListViewKey(wndListViewValue_, new List<string>(listKey));

                int countView = wndListViewValue_.GetRowCount();
                for (int iRow = 0 ; iRow < countView ; iRow++)
                {
                    string wKey = wndListViewValue_.GetText(iRow, (int)AnonymousEnum2.COL_KEY);
                    string key = StringUtility.ConvertWideToMulti(wKey);
                    gstd.value val = commonData.GetValue(key);
                    wndListViewValue_.SetText(iRow, (int)AnonymousEnum2.COL_VALUE, val.as_string());
                }
            }


            /**********************************************************
            //ScriptCommonDataPanel
            **********************************************************/
            public ScriptCommonDataInfoPanel()
            {
                timeLastUpdate_ = 0;
                timeUpdateInterval_ = 500;
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                commonDataManager_ = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonDataManager();
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

                int ySplitter = (int)((float)wHeight * wndSplitter_.GetRatioY());
                int heightSplitter = 6;

                wndSplitter_.SetBounds(wx, ySplitter, wWidth, heightSplitter);
                wndListViewArea_.SetBounds(wx, wy, wWidth, ySplitter);
                wndListViewValue_.SetBounds(wx, ySplitter + heightSplitter, wWidth, wHeight - ySplitter - heightSplitter);
            }

            public virtual void Update(gstd.ref_count_ptr<ScriptCommonDataManager> commonDataManager)
            {
                if (!IsWindowVisible())
                {
                    return;
                }
                {
                    Lock @lock = new Lock(lock_);
                    commonDataManager_.Clear();

                    if (commonDataManager != null)
                    {
                        List<string> listKey = commonDataManager.GetKeyList();
                        for (int iKey = 0 ; iKey < listKey.Count ; iKey++)
                        {
                            string area = listKey[iKey];
                            gstd.ref_count_ptr<ScriptCommonData> dataSrc = commonDataManager.GetData(area);
            // C++ TO C# CONVERTER TODO TASK: There is no direct equivalent in C# to the following C++ macro:
                            gstd.ref_count_ptr<ScriptCommonData> dataDest = global::new(_NORMAL_BLOCK, __FILE__, __LINE__) new ScriptCommonData();
                            dataDest.Copy(dataSrc);
                            commonDataManager_.SetData(area, dataDest);
                        }
                    }

                    _UpdateAreaView();
                    _UpdateValueView();
                }
            }
    }

}