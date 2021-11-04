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

namespace test
{
    public class PathPropertyTest : TestSuite
    {
        public PathPropertyTest() : base()
        {
        }
        public override void Run()
        {
            // https://docs.microsoft.com/zh-tw/dotnet/api/system.io.path.getrelativepath?view=net-5.0
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetFileDirectory", [this]()
            RunTest("[PathPropertyTest] GetFileDirectory", () =>
            {
                AssertEquals("C:\\MyDir\\MySubDir\\", gstd.to_mbcs(PathProperty.GetFileDirectory("C:\\MyDir\\MySubDir\\myfile.ext")));
                AssertEquals("C:\\MyDir\\", gstd.to_mbcs(PathProperty.GetFileDirectory("C:\\MyDir\\MySubDir")));
                AssertEquals("C:\\MyDir\\", gstd.to_mbcs(PathProperty.GetFileDirectory("C:\\MyDir\\")));
                AssertEquals("C:\\", gstd.to_mbcs(PathProperty.GetFileDirectory("C:\\MyDir")));
                AssertEquals("C:\\", gstd.to_mbcs(PathProperty.GetFileDirectory("C:\\")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetFileDirectory("C:")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileDirectory("")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetDirectoryName", [this]()
            RunTest("[PathPropertyTest] GetDirectoryName", () =>
            {
                AssertEquals("MySubDir", gstd.to_mbcs(PathProperty.GetDirectoryName("C:\\MyDir\\MySubDir\\myfile.ext")));
                AssertEquals("MyDir", gstd.to_mbcs(PathProperty.GetDirectoryName("C:\\MyDir\\MySubDir")));
                AssertEquals("MyDir", gstd.to_mbcs(PathProperty.GetDirectoryName("C:\\MyDir\\")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDirectoryName("C:\\MyDir")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDirectoryName("C:\\")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDirectoryName("C:")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetFileName", [this]()
            RunTest("[PathPropertyTest] GetFileName", () =>
            {
                AssertEquals("myfile.ext", gstd.to_mbcs(PathProperty.GetFileName("C:\\MyDir\\myfile.ext")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileName("C:\\MyDir\\")));
                AssertEquals("MyDir", gstd.to_mbcs(PathProperty.GetFileName("C:\\MyDir")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileName("C:\\")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileName("C:")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileName("")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetDriveName", [this]()
            RunTest("[PathPropertyTest] GetDriveName", () =>
            {
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDriveName("C:\\MyDir\\myfile.ext")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDriveName("C:\\MyDir\\")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDriveName("C:\\MyDir")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDriveName("C:\\")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.GetDriveName("C:")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetDriveName("")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetFileNameWithoutExtension", [this]()
            RunTest("[PathPropertyTest] GetFileNameWithoutExtension", () =>
            {
                AssertEquals("myfile", gstd.to_mbcs(PathProperty.GetFileNameWithoutExtension("C:\\MyDir\\myfile.ext")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileNameWithoutExtension("C:\\MyDir\\")));
                AssertEquals("MyDir", gstd.to_mbcs(PathProperty.GetFileNameWithoutExtension("C:\\MyDir")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileNameWithoutExtension("C:\\")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileNameWithoutExtension("C:")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileNameWithoutExtension("")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetFileExtension", [this]()
            RunTest("[PathPropertyTest] GetFileExtension", () =>
            {
                AssertEquals(".ext", gstd.to_mbcs(PathProperty.GetFileExtension("C:\\MyDir\\myfile.ext")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileExtension("C:\\MyDir\\")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileExtension("C:\\MyDir")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileExtension("C:\\")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileExtension("C:")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetFileExtension("")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetModuleName", [this]()
            RunTest("[PathPropertyTest] GetModuleName", () =>
            {
                AssertEquals("DnhViewer", gstd.to_mbcs(PathProperty.GetModuleName()));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetModuleDirectory", [this]()
            RunTest("[PathPropertyTest] GetModuleDirectory", () =>
            {
                AssertEquals("D:\\Repository\\danmakufu-ph3\\Test\\.\\bin_th_dnh\\", gstd.to_mbcs(PathProperty.GetModuleDirectory()));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetDirectoryWithoutModuleDirectory", [this]()
            RunTest("[PathPropertyTest] GetDirectoryWithoutModuleDirectory", () =>
            {
                AssertEquals("MyDir\\MySubDir\\", gstd.to_mbcs(PathProperty.GetDirectoryWithoutModuleDirectory("D:\\Repository\\danmakufu-ph3\\Test\\.\\bin_th_dnh\\MyDir\\MySubDir\\myfile.ext")));
                AssertEquals("MyDir\\", gstd.to_mbcs(PathProperty.GetDirectoryWithoutModuleDirectory("D:\\Repository\\danmakufu-ph3\\Test\\.\\bin_th_dnh\\MyDir\\MySubDir")));
                AssertEquals("MyDir\\", gstd.to_mbcs(PathProperty.GetDirectoryWithoutModuleDirectory("D:\\Repository\\danmakufu-ph3\\Test\\.\\bin_th_dnh\\MyDir\\")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetDirectoryWithoutModuleDirectory("D:\\Repository\\danmakufu-ph3\\Test\\.\\bin_th_dnh\\MyDir")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetDirectoryWithoutModuleDirectory("D:\\Repository\\danmakufu-ph3\\Test\\.\\bin_th_dnh\\")));
                AssertEquals("C:\\MyDir\\MySubDir\\", gstd.to_mbcs(PathProperty.GetDirectoryWithoutModuleDirectory("C:\\MyDir\\MySubDir\\myfile.ext")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetPathWithoutModuleDirectory", [this]()
            RunTest("[PathPropertyTest] GetPathWithoutModuleDirectory", () =>
            {
                AssertEquals("D:/Repository/danmakufu-ph3/Test/bin_th_dnh/MyDir/MySubDir/myfile.ext", gstd.to_mbcs(PathProperty.GetPathWithoutModuleDirectory("D:\\Repository\\danmakufu-ph3\\Test\\bin_th_dnh\\MyDir\\MySubDir\\myfile.ext")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetRelativeDirectory", [this]()
            RunTest("[PathPropertyTest] GetRelativeDirectory", () =>
            {
                AssertEquals("..\\..\\x\\y\\file\\", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path\\", "C:\\a\\x\\y\\file\\")));
                AssertEquals("..\\..\\x\\y\\file\\", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path", "C:\\a\\x\\y\\file\\")));
                AssertEquals("..\\..\\x\\y\\", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path\\", "C:\\a\\x\\y\\file")));
                AssertEquals("..\\..\\x\\y\\", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path", "C:\\a\\x\\y\\file")));
                AssertEquals("..\\..\\..\\x\\y\\file\\", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path\\myfile.ext", "C:\\a\\x\\y\\file\\")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path", "D:\\a\\x\\y\\file")));
                AssertEquals("", gstd.to_mbcs(PathProperty.GetRelativeDirectory("C:\\a\\b\\path", "")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] ReplaceYenToSlash", [this]()
            RunTest("[PathPropertyTest] ReplaceYenToSlash", () =>
            {
                AssertEquals("C:/MyDir/myfile.ext", gstd.to_mbcs(PathProperty.ReplaceYenToSlash("C:\\MyDir\\myfile.ext")));
                AssertEquals("C:/MyDir/", gstd.to_mbcs(PathProperty.ReplaceYenToSlash("C:\\MyDir\\")));
                AssertEquals("C:/MyDir", gstd.to_mbcs(PathProperty.ReplaceYenToSlash("C:\\MyDir")));
                AssertEquals("C:/", gstd.to_mbcs(PathProperty.ReplaceYenToSlash("C:\\")));
                AssertEquals("C:", gstd.to_mbcs(PathProperty.ReplaceYenToSlash("C:")));
                AssertEquals("", gstd.to_mbcs(PathProperty.ReplaceYenToSlash("")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] Canonicalize", [this]()
            RunTest("[PathPropertyTest] Canonicalize", () =>
            {
                AssertEquals("C:\\name_1\\name_3", gstd.to_mbcs(PathProperty.Canonicalize("C:\\name_1\\.\\name_2\\..\\name_3")));
                AssertEquals("C:\\name_2\\name_3", gstd.to_mbcs(PathProperty.Canonicalize("C:\\name_1\\..\\name_2\\.\\name_3")));
                AssertEquals("C:\\name_1\\name_2\\name_4", gstd.to_mbcs(PathProperty.Canonicalize("C:\\name_1\\name_2\\.\\name_3\\..\\name_4")));
                AssertEquals("C:\\name_1\\name_2", gstd.to_mbcs(PathProperty.Canonicalize("C:\\name_1\\.\\name_2\\.\\name_3\\..\\name_4\\..")));
                AssertEquals("C:\\", gstd.to_mbcs(PathProperty.Canonicalize("C:\\..")));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[PathPropertyTest] GetUnique", [this]()
            RunTest("[PathPropertyTest] GetUnique", () =>
            {
                AssertEquals("C:/name_1/name_3", gstd.to_mbcs(PathProperty.GetUnique("C:\\name_1\\.\\name_2\\..\\name_3")));
                AssertEquals("C:/name_2/name_3", gstd.to_mbcs(PathProperty.GetUnique("C:\\name_1\\..\\name_2\\.\\name_3")));
                AssertEquals("C:/name_1/name_2/name_4", gstd.to_mbcs(PathProperty.GetUnique("C:\\name_1\\name_2\\.\\name_3\\..\\name_4")));
                AssertEquals("C:/name_1/name_2", gstd.to_mbcs(PathProperty.GetUnique("C:\\name_1\\.\\name_2\\.\\name_3\\..\\name_4\\..")));
                AssertEquals("C:/", gstd.to_mbcs(PathProperty.GetUnique("C:\\..")));
            });
        }
    }
}
