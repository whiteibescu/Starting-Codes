using System;
using System.Runtime.CompilerServices;

namespace CallerInfo
{
    public class static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",])
    }
}
