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
    public class MersenneTwisterTest : TestSuite
    {
        public MersenneTwisterTest() : base()
        {
        }
        public override void Run()
        {
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[MersenneTwisterTest] MersenneTwister long seed 0", [this]()
            RunTest("[MersenneTwisterTest] MersenneTwister long seed 0", () =>
            {
                int[] numbers = { 1178568022, 1273124119, 1535857466, 1813046880, 1294424481, 1842424189, 1170127713, 1819459251, 909791748, 1339092841, 1387047050, 825453433, 939711378, 638950699, 1915067939, 121790188, 2069450028, 585524934, 823434397, 1025778016 };
                MersenneTwister mt = new MersenneTwister(0);
                foreach (int number in numbers)
                {
                    AssertEquals(number, mt.GetInt());
                }
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[MersenneTwisterTest] MersenneTwister long seed 42", [this]()
            RunTest("[MersenneTwisterTest] MersenneTwister long seed 42", () =>
            {
                int[] numbers = { 804318771, 1710563033, 2041643438, 393923207, 1571945013, 1674373667, 1285609310, 1281725962, 335047475, 957418556, 334995689, 214694507, 124733605, 986229477, 1860099115, 716633786, 1290884657, 306804147, 1520574283, 1397772353 };
                MersenneTwister mt = new MersenneTwister(42);
                foreach (int number in numbers)
                {
                    AssertEquals(number, mt.GetInt());
                }
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[MersenneTwisterTest] MersenneTwister real", [this]()
            RunTest("[MersenneTwisterTest] MersenneTwister real", () =>
            {
                double[] numbers = { 0.548814, 0.592845, 0.715189, 0.844266, 0.602763, 0.857946, 0.544883, 0.847252, 0.423655, 0.623564, 0.645894, 0.384382, 0.437587, 0.297535, 0.891773, 0.056713, 0.963663, 0.272656, 0.383442, 0.477665 };
                MersenneTwister mt = new MersenneTwister(0);
                foreach (double number in numbers)
                {
                    AssertEquals(number, mt.GetReal());
                }
            });
// C++ TO C# CONVERTER TODO TASK: Only lambda expressions having all locals passed by reference can be converted to C#:
// ORIGINAL LINE: RunTest("[MersenneTwisterTest] MersenneTwister real min max", [this]()
            RunTest("[MersenneTwisterTest] MersenneTwister real min max", () =>
            {
                MersenneTwister mt = new MersenneTwister(0);
                AssertEquals(3.64644, mt.GetReal(2, 5));
            });
        }
    }
}
