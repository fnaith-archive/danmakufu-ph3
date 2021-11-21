using System;
using Gstd.ScriptClient;

namespace test
{
    class ScriptClientBaseTest : TestSuite
    {
        public ScriptClientBaseTest(Func<string, string> readData, Action<string> logInfo, Action<string> logOk, Action<string> logFail) : base(readData, logInfo, logOk, logFail)
        {
        }
        public override void Run()
        {
            TestOkBase();
            TestFailBase();
        }
        private void TestOkBase()
        {
            string[] scriptFilePaths = {
                "./test/data/base/ok/FuncA.txt",
                "./test/data/base/ok/FuncB.txt",
                "./test/data/base/ok/rtos.txt",
                "./test/data/base/ok/vtos.txt"
            };
            LogInfo("[ScriptClientBaseTest] ok base");
            foreach (string scriptFilePath in scriptFilePaths)
            {
                bool result = RunScript(scriptFilePath);
                if (result)
                {
                    LogFail(String.Format("\tclient base error : {0}", scriptFilePath));
                    continue;
                }
                LogOk(String.Format("\tok : {0}", scriptFilePath));
            }
        }
        private void TestFailBase()
        {
            string[] scriptFilePaths = {
                "./test/data/base/fail/FuncA.txt",
                "./test/data/base/fail/FuncB.txt"
            };
            LogInfo("[ScriptClientBaseTest] fail base");
            foreach (string scriptFilePath in scriptFilePaths)
            {
                bool result = RunScript(scriptFilePath);
                if (!result)
                {
                    LogFail(String.Format("\tclient base error : {0}", scriptFilePath));
                    continue;
                }
                LogOk(String.Format("\tok : {0}", scriptFilePath));
            }
        }
        private bool RunScript(string filePath)
        {
            try
            {
                ScriptClientBase scriptClientBase = new ScriptClientBase();
                scriptClientBase.SetSourceFromFile(filePath);
                scriptClientBase.Compile();
                //LogFail(">>>");
                //LogFail(scriptClientBase.GetEngine().GetSource());
                //LogFail("<<<");
                scriptClientBase.Run();
                //LogOk(String.Format("{0} : {1}", machine.ErrorLine, machine.ErrorMessage));
                return false;
            }
            catch (Exception e)
            {
                //LogFail(String.Format("{0}", e.ToString()));
                return true;
            }
        }
    }
}
