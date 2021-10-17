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
                AssertEquals("/MyDir/MySubDir", PathProperty.GetFileDirectory("/MyDir/MySubDir/myfile.ext"));
                AssertEquals("/MyDir", PathProperty.GetFileDirectory("/MyDir/MySubDir"));
                AssertEquals("/MyDir", PathProperty.GetFileDirectory("/MyDir/"));
                AssertEquals("/", PathProperty.GetFileDirectory("/MyDir"));
                AssertEquals(null, PathProperty.GetFileDirectory("/"));
                //AssertEquals("C:\\MyDir\\MySubDir", PathProperty.GetFileDirectory("C:\\MyDir\\MySubDir\\myfile.ext"));
                //AssertEquals("C:\\MyDir", PathProperty.GetFileDirectory("C:\\MyDir\\MySubDir"));
                //AssertEquals("C:\\MyDir", PathProperty.GetFileDirectory("C:\\MyDir\\"));
                //AssertEquals("", PathProperty.GetFileDirectory("C:\\"));
            });
            Run("[PathPropertyTest] GetDirectoryName", () => {
                AssertEquals("MySubDir", PathProperty.GetDirectoryName("/MyDir/MySubDir/myfile.ext"));
                AssertEquals("MyDir", PathProperty.GetDirectoryName("/MyDir/MySubDir"));
                AssertEquals("MyDir", PathProperty.GetDirectoryName("/MyDir/"));
                AssertEquals("", PathProperty.GetDirectoryName("/MyDir"));
                AssertEquals(null, PathProperty.GetDirectoryName("/"));
            });
            Run("[PathPropertyTest] GetFileName", () => {
                AssertEquals("myfile.ext", PathProperty.GetFileName("/MyDir/myfile.ext"));
                AssertEquals("", PathProperty.GetFileName("/MyDir/"));
            });
            Run("[PathPropertyTest] GetDriveName", () => {
                AssertEquals("/", PathProperty.GetDriveName("/MyDir/myfile.ext"));
            });
            Run("[PathPropertyTest] GetFileNameWithoutExtension", () => {
                AssertEquals("myfile", PathProperty.GetFileNameWithoutExtension("/MyDir/myfile.ext"));
                AssertEquals("", PathProperty.GetFileNameWithoutExtension("/MyDir/"));
            });
            Run("[PathPropertyTest] GetFileExtension", () => {
                AssertEquals(".ext", PathProperty.GetFileExtension("/MyDir/myfile.ext"));
                AssertEquals("", PathProperty.GetFileExtension("/MyDir/"));
            });
            Run("[PathPropertyTest] GetRelativeDirectory", () => {
                AssertEquals("../../x/y/file", PathProperty.GetRelativeDirectory("/a/b/path/", "/a/x/y/file/"));
                AssertEquals("../../x/y/file", PathProperty.GetRelativeDirectory("/a/b/path", "/a/x/y/file/"));
                AssertEquals("../../x/y", PathProperty.GetRelativeDirectory("/a/b/path", "/a/x/y/file"));
            });
            Run("[PathPropertyTest] ReplaceYenToSlash", () => {
                AssertEquals("/MyDir/myfile.ext", PathProperty.ReplaceYenToSlash("\\MyDir\\myfile.ext"));
            });
        }
    }
}
