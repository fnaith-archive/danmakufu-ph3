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
            protected gstd.CriticalSection criticalSection_ = new gstd.CriticalSection();

            protected string _ExtendPath(string path)
            {
                int line = machine_.get_current_line();
                string pathScript = GetEngine().GetScriptFileLineMap().GetPath(line);

                path = StringUtility.ReplaceAll(path, "\\", "/");
                path = StringUtility.ReplaceAll(path, "./", pathScript);

                return path;
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

            // �g�ݍ��݊֐��F�����񑀍�

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

            // ���ʊ֐��F�p�X�֘A

            // ���ʊ֐��F�p�X�֘A
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
    }

    /**********************************************************
    //ScriptCommonData
    **********************************************************/
    public class ScriptCommonData
    {
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