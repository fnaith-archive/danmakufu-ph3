using System;
using Gstd.Script;

namespace cs
{
    class TestResult {
        public bool engineError;
        public bool machineError;
        public TestResult(bool engine_error_, bool machine_error_) {
            engineError = engine_error_;
            machineError = machine_error_;
        }
    };

    public class TestRunner
    {
        private Func<string, string> readFunc;
        private Action<string> logFunc;
        private Action<string> logErrorFunc;

        public TestRunner(Func<string, string> readFunc, Action<string> logFunc, Action<string> logErrorFunc)
        {
            this.readFunc = readFunc;
            this.logFunc = logFunc;
            this.logErrorFunc = logErrorFunc;
        }
        private TestResult ParseScript(string filePath)
        {
            ScriptTypeManager typeManager = new ScriptTypeManager();
            string source = readFunc(filePath);
            Function[] funcv = {};
            ScriptEngine engine = new ScriptEngine(typeManager, source, funcv);
            return new TestResult(engine.Error, false);
        }
        private TestResult RunScript(string filePath)
        {
            ScriptTypeManager typeManager = new ScriptTypeManager();
            string source = readFunc(filePath);
            Function[] funcv = {};
            ScriptEngine engine = new ScriptEngine(typeManager, source, funcv);
            ScriptMachine machine = new ScriptMachine(engine);
            machine.Run();
            return new TestResult(engine.Error, machine.Error);
        }
        private void TestOkSyntax(string testDirPath)
        {
            string[] scriptFilePaths = {
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
            logFunc("ok syntax :");
            foreach (string scriptFilePath in scriptFilePaths)
            {
                TestResult result = ParseScript(testDirPath + scriptFilePath);
                if (result.engineError)
                {
                    logErrorFunc(String.Format("\terror : {0}", scriptFilePath));
                    continue;
                }
                logFunc(String.Format("\tok : {0}", scriptFilePath));
            }
        }
        private void TestFailSyntax(string testDirPath)
        {
            string[] scriptFilePaths = {
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
            logFunc("fail syntax :");
            foreach (string scriptFilePath in scriptFilePaths)
            {
                TestResult result = ParseScript(testDirPath + scriptFilePath);
                if (!result.engineError)
                {
                    logErrorFunc(String.Format("\terror : {0}", scriptFilePath));
                    continue;
                }
                logFunc(String.Format("\tok : {0}", scriptFilePath));
            }
        }
        private void TestOkScript(string testDirPath)
        {
            string[] scriptFilePaths = {
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
            logFunc("ok script :");
            foreach (string scriptFilePath in scriptFilePaths)
            {
                TestResult result = ParseScript(testDirPath + scriptFilePath);
                if (result.engineError)
                {
                    logErrorFunc(String.Format("\tengine error : {0}", scriptFilePath));
                    continue;
                }
                if (result.machineError)
                {
                    logErrorFunc(String.Format("\tmachine error : {0}", scriptFilePath));
                    continue;
                }
                logFunc(String.Format("\tok : {0}", scriptFilePath));
            }
        }
        private void TestFailScript(string testDirPath)
        {
            string[] scriptFilePaths = {
                "syntax/fail/Lesson-4-ChangeType.txt",
                "script/fail/Lesson-4-Array-1.txt",
                "script/fail/Lesson-4-Array-2.txt",
                "script/fail/Lesson-4-Array-3.txt",
                "script/fail/Lesson-5-Subroutine.txt"
            };
            logFunc("fail script :");
            foreach (string scriptFilePath in scriptFilePaths)
            {
                TestResult result = ParseScript(testDirPath + scriptFilePath);
                if (result.engineError)
                {
                    logErrorFunc(String.Format("\tengine error : {0}", scriptFilePath));
                    continue;
                }
                if (!result.machineError)
                {
                    logErrorFunc(String.Format("\tmachine error : {0}", scriptFilePath));
                    continue;
                }
                logFunc(String.Format("\tok : {0}", scriptFilePath));
            }
        }
        public void RunAllTests(string testDirPath)
        {
            TestOkSyntax(testDirPath);
            TestFailSyntax(testDirPath);
            TestOkScript(testDirPath);
            TestFailScript(testDirPath);
        }
    }
}
