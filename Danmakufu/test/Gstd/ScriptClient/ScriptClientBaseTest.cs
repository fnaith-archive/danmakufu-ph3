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
            TestBaseScript();
        }
        private void TestBaseScript()
        {
            string[] scriptFilePaths = {
                "./test/data/base/FuncA.txt",
                "./test/data/base/FuncB.txt"
            };
            LogInfo("[ScriptClientBaseTest] base script");
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
                LogFail(String.Format("{0}", e.ToString()));
                return true;
            }
        }
    }
}
