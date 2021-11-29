using System.IO;

namespace Gstd.GstdUtility
{
    sealed class PathProperty
    {
        public static string GetFileDirectory(string path)
        {
            if ("" == path)
            {
                return "";
            }
#if _WINDOWS
            string fileDirectory = Path.GetDirectoryName(path);
            if (null == fileDirectory)
            {
                fileDirectory = Path.GetPathRoot(path);
            }
            else if ("\\" != fileDirectory && !fileDirectory.EndsWith("\\"))
            {
                fileDirectory += '\\';
            }
            return fileDirectory;
#else
            if ("/" == path)
            {
                return "/";
            }
            string fileDirectory = Path.GetDirectoryName(path);
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
            if ("" == dir)
            {
                return "";
            }
#if _WINDOWS
            dir = dir.Replace(@"\", @"/");
#else
            if ("/" == dir)
            {
                return "";
            }
#endif
            string[] strs = dir.Split('/');
            if (strs.Length < 2)
            {
#if _WINDOWS
                return Path.GetPathRoot(path);
#else
                return "";
#endif
            }
            return strs[strs.Length - 2];
        }
        public static string GetFileName(string path)
        {
            return Path.GetFileName(path);
        }
        public static string GetDriveName(string path)
        {
            string driveName = Path.GetPathRoot(path);
            if (null == driveName)
            {
                return "";
            }
#if _WINDOWS
            if (driveName.EndsWith("\\"))
            {
                driveName = driveName.Remove(driveName.Length - 1);
            }
#endif
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
        public static string GetModuleName()
        {
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
            return GetFileNameWithoutExtension(path);
        }
        public static string GetModuleDirectory()
        {
            string path = System.Reflection.Assembly.GetEntryAssembly().Location;
#if _WINDOWS
            return "D:\\Repository\\danmakufu-ph3\\Danmakufu\\test"; // TODO GetFileDirectory(path);
#else
            return "/Users/wilson/Desktop/ph3/danmakufu-ph3/Danmakufu"; // TODO GetFileDirectory(path);
#endif
        }
        public static string GetDirectoryWithoutModuleDirectory(string path)
        {
            string res = GetFileDirectory(path);
            string dirModule = GetModuleDirectory();
            if (res.StartsWith(dirModule))
            {
                res = res.Substring(dirModule.Length);
            }
            return res;
        }
        public static string GetPathWithoutModuleDirectory(string path)
        {
            string dirModule = GetModuleDirectory();
            dirModule = Canonicalize(dirModule);
#if _WINDOWS
#else
            dirModule = ReplaceYenToSlash(dirModule);
#endif
            path = Canonicalize(path);
#if _WINDOWS
#else
            path = ReplaceYenToSlash(path);
#endif
            string res = path;
            if (res.StartsWith(dirModule))
            {
                res = res.Substring(dirModule.Length);
            }
            return res;
        }
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
        public static string Canonicalize(string srcPath)
        {
            return Path.GetFullPath(srcPath);
        }
        public static string GetUnique(string srcPath)
        {
            string res = srcPath.Replace(@"\", @"/");
            res = Canonicalize(res);
            res = ReplaceYenToSlash(res);
            return res;
        }
    }
}
