using System.Collections.Generic;

namespace Gstd
{
    namespace GstdUtility
    {
        sealed class StringUtility
        {
            public static int CountCharacter(string str, char c)
            {
                int count = 0;
                int length = str.Length;
                for (int n = length - 1; n >= 0; n--)
                {
                    if (str[n] == c)
                    {
                        count++;
                    }
                }
                return count;
            }
            public static int CountCharacter(List<char> str, char c)
            {
                int count = 0;
                int length = str.Count;
                for (int n = length - 1; n >= 0; n--)
                {
                    if (str[n] == c)
                    {
                        count++;
                    }
                }
                return count;
            }
            public static int CountCharacter(char[] str, char c)
            {
                int count = 0;
                int length = str.Length;
                for (int n = length - 1; n >= 0; n--)
                {
                    if (str[n] == c)
                    {
                        count++;
                    }
                }
                return count;
            }
            public static int ToInteger(string s)
            {
                int num;
                if (!int.TryParse(s, out num))
                {
                    num = 0;
                }
                return num;
            }
            public static double ToDouble(string s)
            {
                double num;
                if (!double.TryParse(s, out num))
                {
                    num = 0;
                }
                return num;
            }
            public static string Trim(string str)
            {
                return str.TrimStart(' ', '\t').TrimEnd(' ', '\t', '\0', '\r', '\n');
            }
            public static List<string> Split(string str, string delim)
            {
                List<string> res = new List<string>();
                Split(str, delim, res);
                return res;
            }
            public static void Split(string str, string delim, List<string> res)
            {
                foreach (string sub in str.Split(delim.ToCharArray()))
                {
                    res.Add(sub);
                }
            }
        }
    }
}
