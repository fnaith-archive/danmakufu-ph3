using System.Collections.Generic;
using System.Diagnostics;

namespace Gstd
{ 
    namespace Script
    {
        class ScriptMachine
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
            public ScriptMachine(ScriptEngine engine)
            {
            }
            public void Run()
            {
            }
        }
    }
}
