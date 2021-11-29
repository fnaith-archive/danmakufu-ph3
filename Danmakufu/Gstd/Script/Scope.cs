using System.Collections.Generic;

namespace Gstd.Script
{
    sealed class Scope : Dictionary<string, Symbol>
    {
        public BlockKind Kind { get; }
        public Scope(BlockKind kind)
        {
            Kind = kind;
        }
    }
}
