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
    public class BuildInOperationTest : TestSuite
    {
        public BuildInOperationTest() : base()
        {
        }
        public override void Run()
        {
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[BuildInOperationTest] remainder", [this]()
            RunTest("[BuildInOperationTest] remainder", () =>
            {
                AssertEquals(1, fmodl2(5, 2));
                AssertEquals(1, fmodl2(-5, 2));
                AssertEquals(-1, fmodl2(5, -2));
                AssertEquals(-1, fmodl2(-5, -2));
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[BuildInOperationTest] modc", [this]()
            RunTest("[BuildInOperationTest] modc", () =>
            {
                AssertEquals(1, fmodl(5, 2));
                AssertEquals(-1, fmodl(-5, 2));
                AssertEquals(1, fmodl(5, -2));
                AssertEquals(-1, fmodl(-5, -2));
            });
        }
    }
}
