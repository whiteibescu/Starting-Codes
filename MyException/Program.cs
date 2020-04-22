using System;

namespace MyException
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException()
        {
        }

        public InvalidArgumentException(string message)
            : base(message)
        {
        }

        public object Argument
        {
            get;
            set;
        }

        public string Range
        {
            get;
            set;
        }
    }

    class MainApp
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
    {
        uint[] args = new uint[] { alphha}
    }
}
