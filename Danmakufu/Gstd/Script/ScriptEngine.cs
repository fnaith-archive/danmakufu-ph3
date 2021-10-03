using System.Collections.Generic;

namespace Gstd
{
    namespace Script
    {
        class ScriptEngine
        {
            private bool error;
            private string errorMessage;
            private int errorLine;
            public bool Error
            {
                get => error;
            }
            public string ErrorMessage
            {
                get => errorMessage;
            }
            public int ErrorLine
            {
                get => errorLine;
            }
            public ScriptEngine(ScriptTypeManager typeManager, string source, Function[] funcv)
            {
            }
        }
    }
}
