using System;

namespace test
{
    public abstract class TestSuite
    {
        public abstract void Run();
        protected TestSuite()
        {
        }
        protected string ReadData(string filePath)
        {
            std::ifstream t = new std::ifstream("D:/Repository/danmakufu-ph3/Test/data/" + filePath);
            string str = new string((std::istreambuf_iterator<char>(t)), std::istreambuf_iterator<char>());
            return str;
        }
        protected void LogInfo(string message)
        {
#if _REPORT_INFO
            Console.Write(message);
            Console.Write("\n");
#endif
        }
        protected void LogOk(string message)
        {
#if _REPORT_OK
            Console.Write(message);
            Console.Write("\n");
#endif
        }
        protected void LogFail(string message)
        {
#if _REPORT_FAIL
            Console.Write(message);
            Console.Write("\n");
#endif
        }
        protected void Assert(bool condition)
        {
            if (!condition)
            {
                throw new System.Exception("Assert Failed");
            }
        }
        protected void AssertEquals(int expected, int actual)
        {
            if (expected != actual)
            {
                throw new System.Exception(Convert.ToString(actual).c_str());
            }
        }
        protected void AssertEquals(double expected, double actual)
        {
            if (1.0e-06 < std::fabsl(expected - actual))
            {
                throw new System.Exception(Convert.ToString(actual).c_str());
            }
        }
        protected void AssertEquals(string expected, string actual)
        {
            if (string.CompareOrdinal(expected, actual) != 0)
            {
                throw new System.Exception(actual);
            }
        }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<typename Action>
        protected void AssertThrow<Action>(Action action)
        {
            bool hasError = false;
            try
            {
                action();
            }
            catch
            {
                hasError = true;
            }
            if (!hasError)
            {
                throw new System.Exception("No Throw");
            }
        }
// C++ TO C# CONVERTER WARNING: The original C++ template specifier was replaced with a C# generic specifier, which may not produce the same behavior:
// ORIGINAL LINE: template<typename Action>
        protected void RunTest<Action>(string name, Action testCase)
        {
            try
            {
                LogInfo(name);
                testCase();
                LogOk("ok");
            }
            catch (System.Exception e)
            {
                LogFail("fail : " + new string(e.Message));
            }
        }
    }
}
