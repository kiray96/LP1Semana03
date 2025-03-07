using System;

namespace TrapAnalyzer
{
    [Flags]
    public enum PlayerGear
    {
        None = 1 << 0,
        Helmet = 1 << 1,
        Shield = 1 << 2,
        Boots = 1 << 3,
    }
}