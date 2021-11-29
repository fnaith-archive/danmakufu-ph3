using System;
using System.Text;
using System.Collections.Generic;
using Gstd.GstdUtility;
using Gstd.Script;
using Gstd.Logger;

namespace Gstd.ScriptClient
{
    sealed class BuildInFunction
    {
        public static Function[] commonFunction = {
            //���ʊ֐��F�X�N���v�g��������
            new Function("GetScriptArgument", new Callback(Func_GetScriptArgument), 1),
            new Function("GetScriptArgumentCount", new Callback(Func_GetScriptArgumentCount), 0),
            new Function("SetScriptResult", new Callback(Func_SetScriptResult), 1),

            //���ʊ֐��F���w�n
            new Function("min", new Callback(Func_Min), 2),
            new Function("max", new Callback(Func_Max), 2),
            new Function("log", new Callback(Func_Log), 1),
            new Function("log10", new Callback(Func_Log10), 1),
            new Function("cos", new Callback(Func_Cos), 1),
            new Function("sin", new Callback(Func_Sin), 1),
            new Function("tan", new Callback(Func_Tan), 1),
            new Function("acos", new Callback(Func_Acos), 1),
            new Function("asin", new Callback(Func_Asin), 1),
            new Function("atan", new Callback(Func_Atan), 1),
            new Function("atan2", new Callback(Func_Atan2), 2),
            new Function("rand", new Callback(Func_Rand), 2),

            //���ʊ֐��F�����񑀍�
            new Function("ToString", new Callback(Func_ToString), 1),
            new Function("IntToString", new Callback(Func_IntToString), 1),
            new Function("itoa", new Callback(Func_ItoA), 1),
            new Function("rtoa", new Callback(Func_RtoA), 1),
            new Function("rtos", new Callback(Func_RtoS), 2),
            new Function("vtos", new Callback(Func_VtoS), 2),
            new Function("atoi", new Callback(Func_AtoI), 1),
            new Function("ator", new Callback(Func_AtoR), 1),
            new Function("TrimString", new Callback(Func_TrimString), 1),
            new Function("SplitString", new Callback(Func_SplitString), 2),

            //���ʊ֐��F�p�X�֘A
            new Function("GetModuleDirectory", new Callback(Func_GetModuleDirectory), 0),
            new Function("GetMainScriptDirectory", new Callback(Func_GetMainScriptDirectory), 0),
            new Function("GetCurrentScriptDirectory", new Callback(Func_GetCurrentScriptDirectory), 0),
            new Function("GetFileDirectory", new Callback(Func_GetFileDirectory), 1),
            //new Function("GetFilePathList", new Callback(Func_GetFilePathList), 1), TODO
            //new Function("GetDirectoryList", new Callback(Func_GetDirectoryList), 1), TODO

            //���ʊ֐��F�����֘A
            new Function("GetCurrentDateTimeS", new Callback(Func_GetCurrentDateTimeS), 0),

            //���ʊ֐��F�f�o�b�O�֘A
            new Function("WriteLog", new Callback(Func_WriteLog), 1),
            new Function("RaiseError", new Callback(Func_RaiseError), 1),

            //���ʊ֐��F���ʃf�[�^
            new Function("SetDefaultCommonDataArea", new Callback(Func_SetDefaultCommonDataArea), 1),
            new Function("SetCommonData", new Callback(Func_SetCommonData), 2),
            new Function("GetCommonData", new Callback(Func_GetCommonData), 2),
            new Function("ClearCommonData", new Callback(Func_ClearCommonData), 0),
            new Function("DeleteCommonData", new Callback(Func_DeleteCommonData), 1),
            new Function("SetAreaCommonData", new Callback(Func_SetAreaCommonData), 3),
            new Function("GetAreaCommonData", new Callback(Func_GetAreaCommonData), 3),
            new Function("ClearAreaCommonData", new Callback(Func_ClearAreaCommonData), 1),
            new Function("DeleteAreaCommonData", new Callback(Func_DeleteAreaCommonData), 2),
            new Function("CreateCommonDataArea", new Callback(Func_CreateCommonDataArea), 1),
            new Function("CopyCommonDataArea", new Callback(Func_CopyCommonDataArea), 2),
            new Function("IsCommonDataAreaExists", new Callback(Func_IsCommonDataAreaExists), 1),
            new Function("GetCommonDataAreaKeyList", new Callback(Func_GetCommonDataAreaKeyList), 0),
            new Function("GetCommonDataValueKeyList", new Callback(Func_GetCommonDataValueKeyList), 1)
        };

        //���ʊ֐��F�X�N���v�g��������
        private static Value Func_GetScriptArgument(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            int index = (int)argv[0].AsReal();
            if (index < 0 || index >= script.listValueArg.Count)
            {
                string error = "Invalid script argument index.\r\n";
                //error += L"(�X�N���v�g�����̃C���f�b�N�X���s���ł��B)";
                throw new Exception(error);
            }
            return script.listValueArg[index];
        }
        private static Value Func_GetScriptArgumentCount(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            int res = script.listValueArg.Count;
            return new Value(machine.Engine.GetRealType(), (double)res);
        }
        private static Value Func_SetScriptResult(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            script.valueRes = argv[0];
            return new Value();
        }

        //���ʊ֐��F���w�n
        private static Value Func_Min(ScriptMachine machine, int argc, Value[] argv)
        {
            double v1 = argv[0].AsReal();
            double v2 = argv[1].AsReal();
            double res = v1 <= v2 ? v1 : v2;
            return new Value(machine.Engine.GetRealType(), res);
        }
        private static Value Func_Max(ScriptMachine machine, int argc, Value[] argv)
        {
            double v1 = argv[0].AsReal();
            double v2 = argv[1].AsReal();
            double res = v1 >= v2 ? v1 : v2;
            return new Value(machine.Engine.GetRealType(), res);
        }
        private static Value Func_Log(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)System.Math.Log(argv[0].AsReal()));
        }
        private static Value Func_Log10(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)System.Math.Log10(argv[0].AsReal()));
        }
        private static Value Func_Cos(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)System.Math.Cos(MathUtility.DegreeToRadian(argv[0].AsReal())));
        }
        private static Value Func_Sin(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)System.Math.Sin(MathUtility.DegreeToRadian(argv[0].AsReal())));
        }
        private static Value Func_Tan(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)System.Math.Tan(MathUtility.DegreeToRadian(argv[0].AsReal())));
        }
        private static Value Func_Acos(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)MathUtility.RadianToDegree(System.Math.Acos(argv[0].AsReal())));
        }
        private static Value Func_Asin(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)MathUtility.RadianToDegree(System.Math.Asin(argv[0].AsReal())));
        }
        private static Value Func_Atan(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)MathUtility.RadianToDegree(System.Math.Atan(argv[0].AsReal())));
        }
        private static Value Func_Atan2(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetRealType(), (double)MathUtility.RadianToDegree(System.Math.Atan2(argv[0].AsReal(),argv[1].AsReal())));
        }
        private static Value Func_Rand(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            //script.CheckRunInMainThread(); TODO check logic

            double min = argv[0].AsReal();
            double max = argv[1].AsReal();
            double res = script.mt.GetReal(min, max);
            return new Value(machine.Engine.GetRealType(), res);
        }

        //���ʊ֐��F�����񑀍�
        private static Value Func_ToString(ScriptMachine machine, int argc, Value[] argv)
        {
            return new Value(machine.Engine.GetStringType(), argv[0].AsString());
        }
        private static Value Func_IntToString(ScriptMachine machine, int argc, Value[] argv)
        {
            string res = ((int)argv[0].AsReal()).ToString();
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_ItoA(ScriptMachine machine, int argc, Value[] argv)
        {
            string res = ((int)argv[0].AsReal()).ToString();
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_RtoA(ScriptMachine machine, int argc, Value[] argv)
        {
            string res = argv[0].AsReal().ToString();
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_RtoS(ScriptMachine machine, int argc, Value[] argv)
        {
            string res = "";
            string fmtV = argv[0].AsString();
            double num = argv[1].AsReal();

            try
            {
                bool bF = false;
                int countIS = 0;
                int countI0 = 0;
                int countF = 0;

                for (int iCh = 0 ; iCh < fmtV.Length ; iCh++)
                {
                    char ch = fmtV[iCh];

                    if (ch == '#')
                    {
                        if (countI0 > 0 || bF || countF > 0)
                        {
                            throw new Exception("not leading #");
                        }
                        countIS++;
                    }
                    else if (ch == '.' && bF)
                    {
                        throw new Exception(". after bF");
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

                if (num < 0)
                {
                    --countIS;
                }
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < countIS; ++i)
                {
                    sb.Append(' ');
                }
                sb.Append("{0:");
                sb.Append(fmtV.Replace("#", ""));
                sb.Append('}');
                string fmt = sb.ToString();
                res = String.Format(fmt, num);
            }
            catch
            {
                res = "error format";
            }

            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_VtoS(ScriptMachine machine, int argc, Value[] argv)
        {
            string res = "";
            string fmtV = argv[0].AsString();

            try
            {
                char formatType = fmtV[fmtV.Length - 1];
                switch (formatType)
                {
                    case 'd':
                    {
                        fmtV = fmtV.Remove(fmtV.Length - 1);
                        bool rightPadding = '-' == fmtV[0];
                        if (rightPadding)
                        {
                            fmtV = fmtV.Substring(1);
                        }
                        bool padZero = '0' == fmtV[0];
                        if (padZero)
                        {
                            fmtV = fmtV.Substring(1);
                        }
                        int width;
                        if (!int.TryParse(fmtV, out width))
                        {
                            throw new Exception("error d format");
                        }
                        int num = (int)argv[1].AsReal();
                        StringBuilder sb = new StringBuilder();
                        sb.Append("{0,");
                        if (rightPadding)
                        {
                            sb.Append('-');
                        }
                        sb.Append(width);
                        sb.Append('}');
                        string fmt = sb.ToString();
                        res = String.Format(fmt, num);
                        if (padZero)
                        {
                            res = res.Replace(" ", "0");
                        }
                        break;
                    }
                    case 'f':
                    {
                        fmtV = fmtV.Remove(fmtV.Length - 1);
                        bool rightPadding = '-' == fmtV[0];
                        if (rightPadding)
                        {
                            fmtV = fmtV.Substring(1);
                        }
                        bool padZero = '0' == fmtV[0];
                        if (padZero)
                        {
                            fmtV = fmtV.Substring(1);
                        }
                        string[] widths = fmtV.Split('.');
                        if (widths.Length > 2)
                        {
                            throw new Exception("error f format");
                        }
                        int width1;
                        if (!int.TryParse(widths[0], out width1))
                        {
                            throw new Exception("error f format");
                        }
                        int width2 = 0;
                        if (widths.Length == 2 && !int.TryParse(widths[1], out width2))
                        {
                            throw new Exception("error f format");
                        }
                        int width = width1 + width2;
                        if (widths.Length == 2)
                        {
                            ++width;
                        }
                        double num = argv[1].AsReal();
                        if (num < 0)
                        {
                            --width1;
                        }
                        StringBuilder sb = new StringBuilder();
                        sb.Append("{0,");
                        if (rightPadding)
                        {
                            sb.Append('-');
                        }
                        sb.Append(width);
                        sb.Append(':');
                        if (padZero)
                        {
                            for (int i = 0; i < width1; ++i)
                            {
                                sb.Append('0');
                            }
                            if (widths.Length == 2)
                            {
                                sb.Append('.');
                                for (int i = 0; i < width2; ++i)
                                {
                                    sb.Append('0');
                                }
                            }
                        }
                        else
                        {
                            sb.Append('F');
                            sb.Append(width2);
                        }
                        sb.Append('}');
                        string fmt = sb.ToString();
                        res = String.Format(fmt, num);
                        break;
                    }
                    case 's':
                    {
                        if ("s" != fmtV)
                        {
                            throw new Exception("error s format");
                        }
                        res = argv[1].AsString();
                        break;
                    }
                    default:
                        throw new Exception("error format");
                }
            }
            catch
            {
                res = "error format";
            }

            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_AtoI(ScriptMachine machine, int argc, Value[] argv)
        {
            string str = argv[0].AsString();
            int num = StringUtility.ToInteger(str);
            return new Value(machine.Engine.GetRealType(), (double)num);
        }
        private static Value Func_AtoR(ScriptMachine machine, int argc, Value[] argv)
        {
            string str = argv[0].AsString();
            double num = StringUtility.ToDouble(str);
            return new Value(machine.Engine.GetRealType(), (double)num);
        }
        private static Value Func_TrimString(ScriptMachine machine, int argc, Value[] argv)
        {
            string str = argv[0].AsString();
            string res = StringUtility.Trim(str);
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_SplitString(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            string str = argv[0].AsString();
            string delim = argv[1].AsString();
            List<string> list = StringUtility.Split(str, delim);

            Value res = script.CreateStringArrayValue(list);
            return res;
        }

        //���ʊ֐��F�p�X�֘A
        private static Value Func_GetModuleDirectory(ScriptMachine machine, int argc, Value[] argv)
        {
            string res = PathProperty.GetModuleDirectory();
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_GetMainScriptDirectory(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            string path = script.GetEngine().GetPath();
            string res = PathProperty.GetFileDirectory(path);
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_GetCurrentScriptDirectory(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            int line = machine.GetCurrentLine();
            string path = script.GetEngine().GetScriptFileLineMap().GetPath(line);
            string res = PathProperty.GetFileDirectory(path);
            return new Value(machine.Engine.GetStringType(), res);
        }
        private static Value Func_GetFileDirectory(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            string path = argv[0].AsString();
            // path = StringUtility::ReplaceAll(path, "/", "\\");
            string res = PathProperty.GetFileDirectory(path);

            return new Value(machine.Engine.GetStringType(), res);
        }
        /*static value Func_GetFilePathList(ScriptMachine machine, int argc, Value[] argv) TODO
        static value Func_GetDirectoryList(ScriptMachine machine, int argc, Value[] argv) TODO */

        //���ʊ֐��F�����֘A
        private static Value Func_GetCurrentDateTimeS(ScriptMachine machine, int argc, Value[] argv)
        {
            string strDateTime = DateTime.Now.ToString("yyyyMMddHHmmss");
            string res = strDateTime;
            return new Value(machine.Engine.GetStringType(), res);
        }

        //���ʊ֐��F�f�o�b�O�֘A
        private static Value Func_WriteLog(ScriptMachine machine, int argc, Value[] argv)
        {
            string msg = argv[0].AsString();
            Logger.Logger.WriteTop(msg);
            //Console.WriteLine(msg);
            return new Value();
        }
        private static Value Func_RaiseError(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            string msg = argv[0].AsString();
            script.RaiseError(msg);

            return new Value();
        }

        //���ʊ֐��F���ʃf�[�^
        private static Value Func_SetDefaultCommonDataArea(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string name = argv[0].AsString();
            commonDataManager.SetDefaultAreaName(name);

            return new Value();
        }
        private static Value Func_SetCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
            string area = commonDataManager.GetDefaultAreaName();

            string key = argv[0].AsString();
            Value val = argv[1];
            if (!commonDataManager.IsExists(area))
            {
                return new Value();
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            data.SetValue(key, val);
            return new Value();
        }
        private static Value Func_GetCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
            string area = commonDataManager.GetDefaultAreaName();

            string key = argv[0].AsString();
            Value dv = argv[1];
            if (!commonDataManager.IsExists(area))
            {
                return new Value(dv);
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            if (!data.IsExists(key))
            {
                return new Value(dv);
            }
            return data.GetValue(key);
        }
        private static Value Func_ClearCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
            string area = commonDataManager.GetDefaultAreaName();

            if (!commonDataManager.IsExists(area))
            {
                return new Value();
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            data.Clear();
            return new Value();
        }
        private static Value Func_DeleteCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();
            string area = commonDataManager.GetDefaultAreaName();

            string key = argv[0].AsString();
            if (!commonDataManager.IsExists(area))
            {
                return new Value();
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            data.DeleteValue(key);
            return new Value();
        }
        private static Value Func_SetAreaCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string area = argv[0].AsString();
            string key = argv[1].AsString();
            Value val = argv[2];

            if (!commonDataManager.IsExists(area))
            {
                return new Value();
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            data.SetValue(key, val);

            return new Value();
        }
        private static Value Func_GetAreaCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string area = argv[0].AsString();
            string key = argv[1].AsString();
            Value dv = argv[2];
            if (!commonDataManager.IsExists(area))
            {
                return new Value(dv);
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            if (!data.IsExists(key))
            {
                return new Value(dv);
            }
            return data.GetValue(key);
        }
        private static Value Func_ClearAreaCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string area = argv[0].AsString();
            if (!commonDataManager.IsExists(area))
            {
                return new Value();
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            data.Clear();
            return new Value();
        }
        private static Value Func_DeleteAreaCommonData(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string area = argv[0].AsString();
            string key = argv[1].AsString();
            if (!commonDataManager.IsExists(area))
            {
                return new Value();
            }
            ScriptCommonData data = commonDataManager.GetData(area);
            data.DeleteValue(key);
            return new Value();
        }
        private static Value Func_CreateCommonDataArea(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string area = argv[0].AsString();
            commonDataManager.CreateArea(area);

            return new Value();
        }
        private static Value Func_CopyCommonDataArea(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string areaDest = argv[0].AsString();
            string areaSrc = argv[1].AsString();
            if (commonDataManager.IsExists(areaSrc))
            {
                commonDataManager.CopyArea(areaDest, areaSrc);
            }

            return new Value();
        }
        private static Value Func_IsCommonDataAreaExists(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            string area = argv[0].AsString();
            bool res = commonDataManager.IsExists(area);
            return new Value(machine.Engine.GetBooleanType(), res);
        }
        private static Value Func_GetCommonDataAreaKeyList(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            List<string> listKey = commonDataManager.GetKeyList();
            Value res = script.CreateStringArrayValue(listKey);
            return new Value(res);
        }
        private static Value Func_GetCommonDataValueKeyList(ScriptMachine machine, int argc, Value[] argv)
        {
            ScriptClientBase script = (ScriptClientBase)machine.data;
            ScriptCommonDataManager commonDataManager = script.GetCommonDataManager();

            List<string> listKey = new List<string>();
            string area = argv[0].AsString();
            if (commonDataManager.IsExists(area))
            {
                ScriptCommonData data = commonDataManager.GetData(area);
                listKey = data.GetKeyList();
            }
            Value res = script.CreateStringArrayValue(listKey);
            return new Value(res);
        }
    }
}
