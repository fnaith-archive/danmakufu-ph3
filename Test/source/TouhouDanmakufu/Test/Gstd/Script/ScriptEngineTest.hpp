#pragma once

#include"../../TestSuite.hpp"
#include"../../../DnhViewer/GcLibImpl.hpp"

namespace test
{
	class ScriptEngineTest : TestSuite
	{
	public:
		ScriptEngineTest() : TestSuite()
		{
		}
		void Run() override
		{
			TestOkSyntax();
			TestFailSyntax();
		}
	private:
		void TestOkSyntax()
		{
			std::string scriptFilePaths[] = {
				"syntax/ok/Array.txt",
				"syntax/ok/Branch.txt",
				"syntax/ok/Comment.txt",
				"syntax/ok/EmptyFile.txt",
				"syntax/ok/Escape.txt",
				"syntax/ok/ExpressionsAndOperators.txt",
				"syntax/ok/Include.txt",
				"syntax/ok/LocalScope.txt",
				"syntax/ok/Loop.txt",
				"syntax/ok/MicroThread.txt",
				"syntax/ok/SampleA01.txt",
				"syntax/ok/SemicolonOnly.txt",
				"syntax/ok/Statement.txt",
				"syntax/ok/Subroutine.txt",
				"syntax/ok/UserDefineFunction.txt",
				"syntax/ok/Variable.txt"
			};
			LogInfo("[ScriptEngineTest] ok syntax");
			for (const std::string &scriptFilePath : scriptFilePaths)
			{
				bool result = ParseScript(scriptFilePath);
				if (result)
				{
					LogFail("\terror : " + scriptFilePath);
					continue;
				}
				LogOk("\tok : " + scriptFilePath);
			}
		}
		void TestFailSyntax()
		{
			std::string scriptFilePaths[] = {
				"syntax/fail/Lesson-4-Array-1.txt",
				"syntax/fail/Lesson-4-Array-2.txt",
				"syntax/fail/Lesson-4-LocalAndGlobalVariable-1.txt",
				"syntax/fail/Lesson-4-LocalAndGlobalVariable-2.txt",
				"syntax/fail/Lesson-4-LocalAndGlobalVariable-3.txt",
				"syntax/fail/Lesson-4-LocalAndGlobalVariable-4.txt",
				"syntax/fail/Lesson-4-LocalAndGlobalVariable-5.txt",
				"syntax/fail/Lesson-4-MathematicalOperation-1.txt",
				"syntax/fail/Lesson-4-MathematicalOperation-2.txt",
				"syntax/fail/Lesson-4-MathematicalOperation-3.txt",
				"syntax/fail/Lesson-4-Variable-1.txt",
				"syntax/fail/Lesson-4-Variable-2.txt",
			};
			LogInfo("[ScriptEngineTest] fail syntax");
			for (const std::string &scriptFilePath : scriptFilePaths)
			{
				bool result = ParseScript(scriptFilePath);
				if (!result)
				{
					LogFail("\terror : " + scriptFilePath);
					continue;
				}
				LogOk("\tok : {0}" + scriptFilePath);
			}
		}
		bool ParseScript(std::string filePath)
		{
			gstd::script_type_manager* typeManager = new gstd::script_type_manager();
			std::string source = ReadData(filePath);
			gstd::function funcv[] = { NULL };
			gstd::script_engine engine(typeManager, source, 0, funcv);
			delete typeManager;
			return engine.error;
		}
	};
}
