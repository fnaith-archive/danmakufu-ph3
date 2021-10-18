#pragma once

#include"../../TestSuite.hpp"
#include"../../../DnhViewer/GcLibImpl.hpp"

namespace test
{
    class PathPropertyTest : TestSuite
    {
	public:
		PathPropertyTest() : TestSuite()
        {
        }
        void Run() override
        {
            // https://docs.microsoft.com/zh-tw/dotnet/api/system.io.path.getrelativepath?view=net-5.0
			RunTest("[PathPropertyTest] GetFileDirectory", [this]() {
				AssertEquals("C:\\MyDir\\MySubDir\\", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L"C:\\MyDir\\MySubDir\\myfile.ext"))));
				AssertEquals("C:\\MyDir\\", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L"C:\\MyDir\\MySubDir"))));
				AssertEquals("C:\\MyDir\\", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("C:\\", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L"C:\\MyDir"))));
				AssertEquals("C:\\", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L"C:\\"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L"C:"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileDirectory(std::wstring(L""))));
            });
			RunTest("[PathPropertyTest] GetDirectoryName", [this]() {
				AssertEquals("MySubDir", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L"C:\\MyDir\\MySubDir\\myfile.ext"))));
				AssertEquals("MyDir", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L"C:\\MyDir\\MySubDir"))));
				AssertEquals("MyDir", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L"C:\\MyDir"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L"C:\\"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L"C:"))));
				//AssertEquals("", gstd::to_mbcs(PathProperty::GetDirectoryName(std::wstring(L""))));
            });
			RunTest("[PathPropertyTest] GetFileName", [this]() {
				AssertEquals("myfile.ext", gstd::to_mbcs(PathProperty::GetFileName(std::wstring(L"C:\\MyDir\\myfile.ext"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileName(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("MyDir", gstd::to_mbcs(PathProperty::GetFileName(std::wstring(L"C:\\MyDir"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileName(std::wstring(L"C:\\"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileName(std::wstring(L"C:"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileName(std::wstring(L""))));
            });
            RunTest("[PathPropertyTest] GetDriveName", [this]() {
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDriveName(std::wstring(L"C:\\MyDir\\myfile.ext"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDriveName(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDriveName(std::wstring(L"C:\\MyDir"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDriveName(std::wstring(L"C:\\"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::GetDriveName(std::wstring(L"C:"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetDriveName(std::wstring(L""))));
            });
			RunTest("[PathPropertyTest] GetFileNameWithoutExtension", [this]() {
				AssertEquals("myfile", gstd::to_mbcs(PathProperty::GetFileNameWithoutExtension(std::wstring(L"C:\\MyDir\\myfile.ext"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileNameWithoutExtension(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("MyDir", gstd::to_mbcs(PathProperty::GetFileNameWithoutExtension(std::wstring(L"C:\\MyDir"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileNameWithoutExtension(std::wstring(L"C:\\"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileNameWithoutExtension(std::wstring(L"C:"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileNameWithoutExtension(std::wstring(L""))));
            });
            RunTest("[PathPropertyTest] GetFileExtension", [this]() {
				AssertEquals(".ext", gstd::to_mbcs(PathProperty::GetFileExtension(std::wstring(L"C:\\MyDir\\myfile.ext"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileExtension(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileExtension(std::wstring(L"C:\\MyDir"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileExtension(std::wstring(L"C:\\"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileExtension(std::wstring(L"C:"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetFileExtension(std::wstring(L""))));
            });
			RunTest("[PathPropertyTest] GetRelativeDirectory", [this]() {
				AssertEquals("..\\..\\x\\y\\file\\", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path\\"), std::wstring(L"C:\\a\\x\\y\\file\\"))));
				AssertEquals("..\\..\\x\\y\\file\\", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path"), std::wstring(L"C:\\a\\x\\y\\file\\"))));
				AssertEquals("..\\..\\x\\y\\", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path\\"), std::wstring(L"C:\\a\\x\\y\\file"))));
				AssertEquals("..\\..\\x\\y\\", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path"), std::wstring(L"C:\\a\\x\\y\\file"))));
				AssertEquals("..\\..\\..\\x\\y\\file\\", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path\\myfile.ext"), std::wstring(L"C:\\a\\x\\y\\file\\"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path"), std::wstring(L"D:\\a\\x\\y\\file"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::GetRelativeDirectory(std::wstring(L"C:\\a\\b\\path"), std::wstring(L""))));
            });
            RunTest("[PathPropertyTest] ReplaceYenToSlash", [this]() {
				AssertEquals("C:/MyDir/myfile.ext", gstd::to_mbcs(PathProperty::ReplaceYenToSlash(std::wstring(L"C:\\MyDir\\myfile.ext"))));
				AssertEquals("C:/MyDir/", gstd::to_mbcs(PathProperty::ReplaceYenToSlash(std::wstring(L"C:\\MyDir\\"))));
				AssertEquals("C:/MyDir", gstd::to_mbcs(PathProperty::ReplaceYenToSlash(std::wstring(L"C:\\MyDir"))));
				AssertEquals("C:/", gstd::to_mbcs(PathProperty::ReplaceYenToSlash(std::wstring(L"C:\\"))));
				AssertEquals("C:", gstd::to_mbcs(PathProperty::ReplaceYenToSlash(std::wstring(L"C:"))));
				AssertEquals("", gstd::to_mbcs(PathProperty::ReplaceYenToSlash(std::wstring(L""))));
            });
        }
	};
}
