#pragma once

#include"../../TestSuite.hpp"
#include"../../../DnhViewer/GcLibImpl.hpp"

namespace test
{
	class BuildInOperationTest : TestSuite
	{
	public:
		BuildInOperationTest() : TestSuite()
		{
		}
		void Run() override
		{
			RunTest("[BuildInOperationTest] remainder", [this]() {
				AssertEquals(1, fmodl2(5, 2));
				AssertEquals(1, fmodl2(-5, 2));
				AssertEquals(-1, fmodl2(5, -2));
				AssertEquals(-1, fmodl2(-5, -2));
			});
			RunTest("[BuildInOperationTest] modc", [this]() {
				AssertEquals(1, fmodl(5, 2));
				AssertEquals(-1, fmodl(-5, 2));
				AssertEquals(1, fmodl(5, -2));
				AssertEquals(-1, fmodl(-5, -2));
			});
		}
	};
}
