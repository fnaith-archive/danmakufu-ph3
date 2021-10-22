using System.IO;

namespace Gstd
{
    namespace GstdUtility
    {
        sealed class PathProperty
        {
            public static string GetFileDirectory(string path)
            {
                if ("" == path)
                {
                    return "";
                }
                if ("/" == path)
                {
                    return "/";
                }
                string fileDirectory = Path.GetDirectoryName(path);
#if _WINDOWS
                return fileDirectory
#else
                if (null == fileDirectory)
                {
                    fileDirectory = "";
                }
                else if ("/" != fileDirectory)
                {
                    fileDirectory += '/';
                }
                return fileDirectory;
#endif
            }
            public static string GetDirectoryName(string path)
            {
                string dir = GetFileDirectory(path);
                if ("" == dir || "/" == dir)
                {
                    return "";
                }
#if _WINDOWS
                dir = dir.Replace(@"\", @"/");
#endif
                string[] strs = dir.Split('/');
                if (strs.Length < 2)
                {
                    return "";
                }
                return strs[strs.Length - 2];
            }
            public static string GetFileName(string path)
            {
                return Path.GetFileName(path);
            }
            public static string GetDriveName(string path) // TODO remove
            {
                string driveName = Path.GetPathRoot(path);
                if (null == driveName)
                {
                    return "";
                }
                return driveName;
            }
            public static string GetFileNameWithoutExtension(string path)
            {
                return Path.GetFileNameWithoutExtension(path);
            }
            public static string GetFileExtension(string path)
            {
                return Path.GetExtension(path);
            }
            //public static string GetModuleName() // TODO remove
            //public static string GetModuleDirectory() // TODO remove
            //public static string GetDirectoryWithoutModuleDirectory(string path) // TODO remove
            //public static string GetPathWithoutModuleDirectory(string path) // TODO remove
            public static string GetRelativeDirectory(string from, string to)
            {
                try
                {
                    string path = Path.GetRelativePath(from, to);
                    if (path != from && path != to)
                    {
                        return GetFileDirectory(path);
                    }
                    return "";
                }
                catch (System.ArgumentException)
                {
                    return "";
                }
            }
            public static string ReplaceYenToSlash(string path)
            {
                string res = path.Replace(@"\", @"/");
                return res;
            }
            //public static string Canonicalize(string srcPath) // TODO remove
            //public static string GetUnique(string srcPath) // TODO remove
        }
    }
}
