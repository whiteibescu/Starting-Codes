﻿using System;

namespace enum3
{
    class MainApp
    {
        enum DialogResult { YES = 10, NO, CANCEL, CONFIRM = 50, OK }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;
            
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
            Console.ReadLine();
        }
    }
}