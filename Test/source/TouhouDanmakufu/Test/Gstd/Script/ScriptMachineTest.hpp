#pragma once

#include"../../TestSuite.hpp"
#include"../../../DnhViewer/GcLibImpl.hpp"

namespace test
{
	class ScriptMachineTest : TestSuite
	{
	public:
		ScriptMachineTest() : TestSuite()
		{
		}
		void Run() override
		{
			TestOkScript();
			TestFailScript();
		}
	private:
		class TestResult {
		public:
			bool engineError;
			bool machineError;
			TestResult(bool engine_error_, bool machine_error_) {
				engineError = engine_error_;
				machineError = machine_error_;
			}
		};
		void TestOkScript()
		{
			std::string scriptFilePaths[] = {
				"script/ok/Lesson-1-Init.txt",
				"script/ok/Lesson-4-Array.txt",
				"script/ok/Lesson-4-Comment.txt",
				"script/ok/Lesson-4-LocalAndGlobalVariable.txt",
				"script/ok/Lesson-4-MathematicalOperation.txt",
				"script/ok/Lesson-4-String.txt",
				"script/ok/Lesson-4-Variable.txt",
				"script/ok/Lesson-5-Boolean.txt",
				"script/ok/Lesson-5-Function.txt",
				"script/ok/Lesson-5-IfElse.txt",
				"script/ok/Lesson-5-Loop.txt",
				"script/ok/Task.txt"
			};
			LogInfo("[ScriptMachineTest] ok script");
			for (const std::string &scriptFilePath : scriptFilePaths)
			{
				TestResult result = RunScript(scriptFilePath);
				if (result.engineError)
				{
					LogFail("\tengine error : " + scriptFilePath);
					continue;
				}
				if (result.machineError)
				{
					LogFail("\tmachine error : " + scriptFilePath);
					continue;
				}
				LogOk("\tok : " + scriptFilePath);
			}
		}
		void TestFailScript()
		{
			std::string scriptFilePaths[] = {
				"script/fail/Lesson-4-ChangeType.txt",
				"script/fail/Lesson-4-Array-1.txt",
				"script/fail/Lesson-4-Array-2.txt",
				"script/fail/Lesson-4-Array-3.txt",
				"script/fail/Lesson-5-Subroutine.txt"
			};
			LogInfo("[ScriptMachineTest] fail script");
			for (const std::string &scriptFilePath : scriptFilePaths)
			{
				TestResult result = RunScript(scriptFilePath);
				if (result.engineError)
				{
					LogFail("\tengine error : " + scriptFilePath);
					continue;
				}
				if (!result.machineError)
				{
					LogFail("\tmachine error : " + scriptFilePath);
					continue;
				}
				LogOk("\tok : " + scriptFilePath);
			}
		}
		TestResult RunScript(std::string filePath)
		{
			gstd::script_type_manager* typeManager = new gstd::script_type_manager();
			std::string source = ReadData(filePath);
			gstd::function funcv[] = { NULL };
			gstd::script_engine* engine = new gstd::script_engine(typeManager, source, 0, funcv);
			gstd::script_machine* machine = new gstd::script_machine(engine);
			machine->run();
			//LogOk(machine->get_error_line() + " : " + machine->get_error_message));
			TestResult result(engine->error, machine->get_error());
			delete machine;
			delete engine;
			delete typeManager;
			return result;
		}
	};
}
