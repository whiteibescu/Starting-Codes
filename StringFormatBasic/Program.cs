﻿using System;
using static System.Console;

namespace StringFormatBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0, -20}{1,-15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}
