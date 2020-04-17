﻿using System;

namespace AnonymousType
{
    class MainApp
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name:{a.Name}, AGe:{a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };

            Console.WriteLine($"Subject:{b.Subject}, Scores: ");
            foreach (var score in b.Scores)
                Console.WriteLine($"{score}");

            Console.WriteLine();
        }
    }
}
//무명형식