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
        }
    }
}