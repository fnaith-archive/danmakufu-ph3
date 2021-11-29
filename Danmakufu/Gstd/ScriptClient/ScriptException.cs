using System;

namespace Gstd.Script
{
    sealed class ScriptException : Exception
    {
        public ScriptException(string message) : base(message)
        {
        }
    }
}
