using System;
using System.Globalization;
using static System.Console;

namespace StringFormatDateTime
{
    class MainApp
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2018, 11, 3, 23, 18, 22);

            WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mmss (ddd)}", dt);
            WriteLine("12시간 형식: {0:yyyy-MM-dd HH:mm:ss (ddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (dddd)", ciKo));


        }
    }
}
