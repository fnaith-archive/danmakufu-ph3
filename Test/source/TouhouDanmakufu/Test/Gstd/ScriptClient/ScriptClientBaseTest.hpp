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
			TestBaseScript();
		}
	private:
		void TestBaseScript()
		{
			std::string scriptFilePaths[] = {
				//"..\\data\\base\\TestA.txt"
				"..\\data\\base\\TestB.txt"
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
