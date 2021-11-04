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
    public class ScriptMachineTest : TestSuite
    {
        public ScriptMachineTest() : base()
        {
        }
        public override void Run()
        {
            TestOkScript();
            TestFailScript();
        }
        private class TestResult
        {
            public bool engineError;
            public bool machineError;
            public TestResult(bool engine_error_, bool machine_error_)
            {
                engineError = engine_error_;
                machineError = machine_error_;
            }
        }
        private void TestOkScript()
        {
            string[] scriptFilePaths = { "script/ok/Lesson-1-Init.txt", "script/ok/Lesson-4-Array.txt", "script/ok/Lesson-4-Comment.txt", "script/ok/Lesson-4-LocalAndGlobalVariable.txt", "script/ok/Lesson-4-MathematicalOperation.txt", "script/ok/Lesson-4-String.txt", "script/ok/Lesson-4-Variable.txt", "script/ok/Lesson-5-Boolean.txt", "script/ok/Lesson-5-Function.txt", "script/ok/Lesson-5-IfElse.txt", "script/ok/Lesson-5-Loop.txt", "script/ok/Task.txt" };
            LogInfo("[ScriptMachineTest] ok script");
            foreach (string scriptFilePath in scriptFilePaths)
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
        private void TestFailScript()
        {
            string[] scriptFilePaths = { "script/fail/Lesson-4-ChangeType.txt", "script/fail/Lesson-4-Array-1.txt", "script/fail/Lesson-4-Array-2.txt", "script/fail/Lesson-4-Array-3.txt", "script/fail/Lesson-5-Subroutine.txt" };
            LogInfo("[ScriptMachineTest] fail script");
            foreach (string scriptFilePath in scriptFilePaths)
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
        private TestResult RunScript(string filePath)
        {
            gstd.script_type_manager typeManager = new gstd.script_type_manager();
            string source = ReadData(filePath);
            gstd.function[] funcv = { null };
            gstd.script_engine engine = new gstd.script_engine(typeManager, source, 0, funcv);
            gstd.script_machine machine = new gstd.script_machine(engine);
            machine.run();
            // LogOk(machine->get_error_line() + " : " + machine->get_error_message));
            TestResult result = new TestResult(engine.error, machine.get_error());
            if (machine != null)
            {
                machine.Dispose();
            }
            if (engine != null)
            {
                engine.Dispose();
            }
            typeManager = null;
// C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
// ORIGINAL LINE: return result;
            return new test.ScriptMachineTest.TestResult(result);
        }
    }
}
