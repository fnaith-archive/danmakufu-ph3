#pragma once

#include <fstream>
#include <iostream>
#include <streambuf>

namespace test
{
    class TestSuite
    {
	public:
		virtual void Run() = 0;
	protected:
		TestSuite()
        {
        }
        std::string ReadData(std::string filePath)
        {
			std::ifstream t("D:/Repository/danmakufu-ph3/Test/data/" + filePath);
			std::string str((std::istreambuf_iterator<char>(t)), std::istreambuf_iterator<char>());
			return str;
        }
        void LogInfo(std::string message)
        {
#ifdef _REPORT_INFO
			std::cout << message << std::endl;
#endif
        }
        void LogOk(std::string message)
        {
#ifdef _REPORT_OK
			std::cout << message << std::endl;
#endif
        }
        void LogFail(std::string message)
        {
#ifdef _REPORT_FAIL
			std::cout << message << std::endl;
#endif
        }
        void Assert(bool condition)
        {
            if (!condition)
            {
                throw new std::exception("Assert Failed");
            }
        }
        void AssertEquals(std::string expected, std::string actual)
        {
            if (expected.compare(actual) != 0)
            {
				throw std::exception(actual.c_str());
            }
        }
		template<typename Action>
        void AssertThrow(Action action)
        {
            bool hasError = false;
            try
            {
                action();
            }
            catch (...)
            {
                hasError = true;
            }
            if (!hasError)
            {
                throw std::exception("No Throw");
            }
        }
		template<typename Action>
		void RunTest(std::string name, Action testCase)
        {
            try
            {
                LogInfo(name);
                testCase();
                LogOk("ok");
            }
            catch (std::exception e)
            {
                LogFail("fail : " + std::string(e.what()));
            }
        }
    };
}
