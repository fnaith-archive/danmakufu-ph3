#pragma once

#include"../../TestSuite.hpp"
#include"../../../DnhViewer/GcLibImpl.hpp"

namespace test
{
	class ScriptClientBaseTest : TestSuite
	{
	public:
		ScriptClientBaseTest() : TestSuite()
		{
		}
		void Run() override
		{
			TestOkBase();
			TestFailBase();
		}
	private:
		void TestOkBase()
		{
			std::string scriptFilePaths[] = {
				"..\\data\\base\\ok\\FuncA.txt",
				"..\\data\\base\\ok\\FuncB.txt",
				"..\\data\\base\\ok\\rtos.txt",
				"..\\data\\base\\ok\\vtos.txt"
			};
			LogInfo("[ScriptClientBaseTest] ok base");
			for (const std::string &scriptFilePath : scriptFilePaths)
			{
				bool result = RunScript(scriptFilePath);
				if (result)
				{
					LogFail("\tclient base error : " + scriptFilePath);
					continue;
				}
				LogOk("\tok : " + scriptFilePath);
			}
		}
		void TestFailBase()
		{
			std::string scriptFilePaths[] = {
				"..\\data\\base\\fail\\FuncA.txt",
				"..\\data\\base\\fail\\FuncB.txt"
			};
			LogInfo("[ScriptClientBaseTest] fail base");
			for (const std::string &scriptFilePath : scriptFilePaths)
			{
				bool result = RunScript(scriptFilePath);
				if (!result)
				{
					LogFail("\tclient base error : " + scriptFilePath);
					continue;
				}
				LogOk("\tok : " + scriptFilePath);
			}
		}
		bool RunScript(std::string filePath)
		{
			try
			{
				gstd::ScriptClientBase* scriptClientBase = new gstd::ScriptClientBase();
				scriptClientBase->SetSourceFromFile(gstd::to_wide(filePath));
				scriptClientBase->Compile();
				scriptClientBase->Run();
				//std::string source(scriptClientBase->GetEngine()->GetSource().begin(), scriptClientBase->GetEngine()->GetSource().end());
				//LogFail(source);
				return false;
			}
			catch (ScriptException e)
			{
				return true;
			}
		}
	};
}
