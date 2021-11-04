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
    public class ScriptEngineTest : TestSuite
    {
        public ScriptEngineTest() : base()
        {
        }
        public override void Run()
        {
            TestOkSyntax();
            TestFailSyntax();
        }
        private void TestOkSyntax()
        {
            string[] scriptFilePaths = { "syntax/ok/Array.txt", "syntax/ok/Branch.txt", "syntax/ok/Comment.txt", "syntax/ok/EmptyFile.txt", "syntax/ok/Escape.txt", "syntax/ok/ExpressionsAndOperators.txt", "syntax/ok/Include.txt", "syntax/ok/LocalScope.txt", "syntax/ok/Loop.txt", "syntax/ok/MicroThread.txt", "syntax/ok/SampleA01.txt", "syntax/ok/SemicolonOnly.txt", "syntax/ok/Statement.txt", "syntax/ok/Subroutine.txt", "syntax/ok/UserDefineFunction.txt", "syntax/ok/Variable.txt" };
            LogInfo("[ScriptEngineTest] ok syntax");
            foreach (string scriptFilePath in scriptFilePaths)
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
        private void TestFailSyntax()
        {
            string[] scriptFilePaths = { "syntax/fail/Lesson-4-Array-1.txt", "syntax/fail/Lesson-4-Array-2.txt", "syntax/fail/Lesson-4-LocalAndGlobalVariable-1.txt", "syntax/fail/Lesson-4-LocalAndGlobalVariable-2.txt", "syntax/fail/Lesson-4-LocalAndGlobalVariable-3.txt", "syntax/fail/Lesson-4-LocalAndGlobalVariable-4.txt", "syntax/fail/Lesson-4-LocalAndGlobalVariable-5.txt", "syntax/fail/Lesson-4-MathematicalOperation-1.txt", "syntax/fail/Lesson-4-MathematicalOperation-2.txt", "syntax/fail/Lesson-4-MathematicalOperation-3.txt", "syntax/fail/Lesson-4-Variable-1.txt", "syntax/fail/Lesson-4-Variable-2.txt" };
            LogInfo("[ScriptEngineTest] fail syntax");
            foreach (string scriptFilePath in scriptFilePaths)
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
        private bool ParseScript(string filePath)
        {
            gstd.script_type_manager typeManager = new gstd.script_type_manager();
            string source = ReadData(filePath);
            gstd.function[] funcv = { null };
            gstd.script_engine engine = new gstd.script_engine(typeManager, source, 0, funcv);
            typeManager = null;
            return engine.error;
        }
    }
}
