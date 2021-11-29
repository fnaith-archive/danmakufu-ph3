using System;

namespace Gstd.Script
{
    sealed class ParserError : Exception
    {
        public ParserError(string message) : base(message)
        {
        }
    }
}
