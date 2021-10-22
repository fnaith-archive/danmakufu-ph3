using System;
using Gstd.GstdUtility;

namespace test
{
    // TODO test windows
    class PathPropertyTest : TestSuite
    {
        public PathPropertyTest(Func<string, string> readData, Action<string> logInfo, Action<string> logOk, Action<string> logFail) : base(readData, logInfo, logOk, logFail)
        {
        }
        public override void Run()
        {
            // https://docs.microsoft.com/zh-tw/dotnet/api/system.io.path.getrelativepath?view=net-5.0
            Run("[PathPropertyTest] GetFileDirectory", () => {
                AssertEquals("/MyDir/MySubDir/", PathProperty.GetFileDirectory("/MyDir/MySubDir/myfile.ext"));
                AssertEquals("/MyDir/", PathProperty.GetFileDirectory("/MyDir/MySubDir"));
                AssertEquals("/MyDir/", PathProperty.GetFileDirectory("/MyDir/"));
                AssertEquals("/", PathProperty.GetFileDirectory("/MyDir"));
                AssertEquals("/", PathProperty.GetFileDirectory("/"));
                AssertEquals("", PathProperty.GetFileDirectory(""));
                //AssertEquals("C:\\MyDir\\MySubDir\\", PathProperty.GetFileDirectory("C:\\MyDir\\MySubDir\\myfile.ext"));
                //AssertEquals("C:\\MyDir\\", PathProperty.GetFileDirectory("C:\\MyDir\\MySubDir"));
                //AssertEquals("C:\\MyDir\\", PathProperty.GetFileDirectory("C:\\MyDir\\"));
                //AssertEquals("C:\\", PathProperty.GetFileDirectory("C:\\MyDir"));
                //AssertEquals("C:\\", PathProperty.GetFileDirectory("C:\\"));
                //AssertEquals("C:", PathProperty.GetFileDirectory("C:"));
                //AssertEquals("", PathProperty.GetFileDirectory(""));
            });
            Run("[PathPropertyTest] GetDirectoryName", () => {
                AssertEquals("MySubDir", PathProperty.GetDirectoryName("/MyDir/MySubDir/myfile.ext"));
                AssertEquals("MyDir", PathProperty.GetDirectoryName("/MyDir/MySubDir"));
                AssertEquals("MyDir", PathProperty.GetDirectoryName("/MyDir/"));
                AssertEquals("", PathProperty.GetDirectoryName("/MyDir"));
                AssertEquals("", PathProperty.GetDirectoryName("/"));
                AssertEquals("", PathProperty.GetDirectoryName(""));
                //AssertEquals("MySubDir", PathProperty.GetDirectoryName("C:\\MyDir\\MySubDir\\myfile.ext"));
                //AssertEquals("MyDir", PathProperty.GetDirectoryName("C:\\MyDir\\MySubDir"));
                //AssertEquals("MyDir", PathProperty.GetDirectoryName("C:\\MyDir\\"));
                //AssertEquals("C:", PathProperty.GetDirectoryName("C:\\MyDir"));
                //AssertEquals("C:", PathProperty.GetDirectoryName("C:\\"));
                //AssertEquals("C:", PathProperty.GetDirectoryName("C:"));
                ////AssertEquals("", PathProperty.GetDirectoryName(""));
            });
            Run("[PathPropertyTest] GetFileName", () => {
                AssertEquals("myfile.ext", PathProperty.GetFileName("/MyDir/myfile.ext"));
                AssertEquals("", PathProperty.GetFileName("/MyDir/"));
                AssertEquals("MyDir", PathProperty.GetFileName("/MyDir"));
                AssertEquals("", PathProperty.GetFileName("/"));
                AssertEquals("", PathProperty.GetFileName(""));
                //AssertEquals("myfile.ext", PathProperty.GetFileName("C:\\MyDir\\myfile.ext"));
                //AssertEquals("", PathProperty.GetFileName("C:\\MyDir\\"));
                //AssertEquals("MyDir", PathProperty.GetFileName("C:\\MyDir"));
                //AssertEquals("", PathProperty.GetFileName("C:\\"));
                //AssertEquals("", PathProperty.GetFileName("C:"));
                //AssertEquals("", PathProperty.GetFileName(""));
            });
            Run("[PathPropertyTest] GetDriveName", () => {
                AssertEquals("/", PathProperty.GetDriveName("/MyDir/myfile.ext"));
                AssertEquals("/", PathProperty.GetDriveName("/MyDir/"));
                AssertEquals("/", PathProperty.GetDriveName("/MyDir"));
                AssertEquals("/", PathProperty.GetDriveName("/"));
                AssertEquals("", PathProperty.GetDriveName(""));
                //AssertEquals("C:", PathProperty.GetDriveName("C:\\MyDir\\myfile.ext"));
                //AssertEquals("C:", PathProperty.GetDriveName("C:\\MyDir\\"));
                //AssertEquals("C:", PathProperty.GetDriveName("C:\\MyDir"));
                //AssertEquals("C:", PathProperty.GetDriveName("C:\\"));
                //AssertEquals("C:", PathProperty.GetDriveName("C:"));
                //AssertEquals("", PathProperty.GetDriveName(""));
            });
            Run("[PathPropertyTest] GetFileNameWithoutExtension", () => {
                AssertEquals("myfile", PathProperty.GetFileNameWithoutExtension("/MyDir/myfile.ext"));
                AssertEquals("", PathProperty.GetFileNameWithoutExtension("/MyDir/"));
                AssertEquals("MyDir", PathProperty.GetFileNameWithoutExtension("/MyDir"));
                AssertEquals("", PathProperty.GetFileNameWithoutExtension("/"));
                AssertEquals("", PathProperty.GetFileNameWithoutExtension(""));
                //AssertEquals("myfile", PathProperty.GetFileNameWithoutExtension("C:\\MyDir\\myfile.ext"));
                //AssertEquals("", PathProperty.GetFileNameWithoutExtension("C:\\MyDir\\"));
                //AssertEquals("MyDir", PathProperty.GetFileNameWithoutExtension("C:\\MyDir"));
                //AssertEquals("", PathProperty.GetFileNameWithoutExtension("C:\\"));
                //AssertEquals("", PathProperty.GetFileNameWithoutExtension("C:"));
                //AssertEquals("", PathProperty.GetFileNameWithoutExtension(""));
            });
            Run("[PathPropertyTest] GetFileExtension", () => {
                AssertEquals(".ext", PathProperty.GetFileExtension("/MyDir/myfile.ext"));
                AssertEquals("", PathProperty.GetFileExtension("/MyDir/"));
                AssertEquals("", PathProperty.GetFileExtension("/MyDir"));
                AssertEquals("", PathProperty.GetFileExtension("/"));
                AssertEquals("", PathProperty.GetFileExtension(""));
                //AssertEquals(".ext", PathProperty.GetFileExtension("C:\\MyDir\\myfile.ext"));
                //AssertEquals("", PathProperty.GetFileExtension("C:\\MyDir\\"));
                //AssertEquals("", PathProperty.GetFileExtension("C:\\MyDir"));
                //AssertEquals("", PathProperty.GetFileExtension("C:\\"));
                //AssertEquals("", PathProperty.GetFileExtension("C:"));
                //AssertEquals("", PathProperty.GetFileExtension(""));
            });
            Run("[PathPropertyTest] GetRelativeDirectory", () => { // TODO
                AssertEquals("../../x/y/file/", PathProperty.GetRelativeDirectory("/a/b/path/", "/a/x/y/file/"));
                AssertEquals("../../x/y/file/", PathProperty.GetRelativeDirectory("/a/b/path", "/a/x/y/file/"));
                AssertEquals("../../x/y/", PathProperty.GetRelativeDirectory("/a/b/path/", "/a/x/y/file"));
                AssertEquals("../../x/y/", PathProperty.GetRelativeDirectory("/a/b/path", "/a/x/y/file"));
                AssertEquals("../../../x/y/file/", PathProperty.GetRelativeDirectory("/a/b/path/myfile.ext", "/a/x/y/file/"));
                AssertEquals("", PathProperty.GetRelativeDirectory("/a/b/path", ""));
                //AssertEquals("..\\..\\x\\y\\file\\", PathProperty.GetRelativeDirectory("C:\\a\\b\\path\\"), "C:\\a\\x\\y\\file\\"));
                //AssertEquals("..\\..\\x\\y\\file\\", PathProperty.GetRelativeDirectory("C:\\a\\b\\path"), "C:\\a\\x\\y\\file\\"));
                //AssertEquals("..\\..\\x\\y\\", PathProperty.GetRelativeDirectory("C:\\a\\b\\path\\"), "C:\\a\\x\\y\\file"));
                //AssertEquals("..\\..\\x\\y\\", PathProperty.GetRelativeDirectory("C:\\a\\b\\path"), "C:\\a\\x\\y\\file"));
                //AssertEquals("..\\..\\..\\x\\y\\file\\", PathProperty.GetRelativeDirectory("C:\\a\\b\\path\\myfile.ext"), "C:\\a\\x\\y\\file\\"));
                //AssertEquals("", PathProperty.GetRelativeDirectory("C:\\a\\b\\path"), "D:\\a\\x\\y\\file"));
                //AssertEquals("", PathProperty.GetRelativeDirectory("C:\\a\\b\\path"), ""));
            });
            Run("[PathPropertyTest] ReplaceYenToSlash", () => {
                AssertEquals("/MyDir/myfile.ext", PathProperty.ReplaceYenToSlash("\\MyDir\\myfile.ext"));
                AssertEquals("/MyDir/", PathProperty.ReplaceYenToSlash("\\MyDir\\"));
                AssertEquals("/MyDir", PathProperty.ReplaceYenToSlash("\\MyDir"));
                AssertEquals("/", PathProperty.ReplaceYenToSlash("\\"));
                AssertEquals("", PathProperty.ReplaceYenToSlash(""));
                //AssertEquals("C:/MyDir/myfile.ext", PathProperty.ReplaceYenToSlash("C:\\MyDir\\myfile.ext"));
                //AssertEquals("C:/MyDir/", PathProperty.ReplaceYenToSlash("C:\\MyDir\\"));
                //AssertEquals("C:/MyDir", PathProperty.ReplaceYenToSlash("C:\\MyDir"));
                //AssertEquals("C:/", PathProperty.ReplaceYenToSlash("C:\\"));
                //AssertEquals("C:", PathProperty.ReplaceYenToSlash("C:"));
                //AssertEquals("", PathProperty.ReplaceYenToSlash(""));
            });
        }
    }
}
