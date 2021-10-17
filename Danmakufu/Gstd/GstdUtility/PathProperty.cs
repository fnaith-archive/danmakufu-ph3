using System.IO;

namespace Gstd
{
    namespace GstdUtility
    {
        sealed class PathProperty
        {
            public static string GetFileDirectory(string path)
            {
                return Path.GetDirectoryName(path);
            }
            public static string GetDirectoryName(string path)
            {
                string dir = GetFileDirectory(path);
                if (null == dir)
                {
                    return null;
                }
                dir = dir.Replace(@"\", @"/");
                string[] strs = dir.Split('/');
                return strs[strs.Length - 1];
            }
            public static string GetFileName(string path)
            {
                return Path.GetFileName(path);
            }
            public static string GetDriveName(string path)
            {
                return Path.GetPathRoot(path);
            }
            public static string GetFileNameWithoutExtension(string path)
            {
                return Path.GetFileNameWithoutExtension(path);
            }
            public static string GetFileExtension(string path)
            {
                return Path.GetExtension(path);
            }
            //public static string GetModuleName()
            //public static string GetModuleDirectory()
            //public static string GetDirectoryWithoutModuleDirectory(string path)
            //public static string GetPathWithoutModuleDirectory(string path)
            public static string GetRelativeDirectory(string from, string to)
            {
                string path = Path.GetRelativePath(from, to);
                if (path != from && path != to)
                {
                    return GetFileDirectory(path);
                }
                return "";
            }
            public static string ReplaceYenToSlash(string path)
            {
                string res = path.Replace(@"\", @"/");
                return res;
            }
            //public static string Canonicalize(string srcPath)
            //public static string GetUnique(string srcPath)
        }
    }
}
