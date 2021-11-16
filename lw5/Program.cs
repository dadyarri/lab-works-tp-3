using System;
using System.Diagnostics;

namespace lw5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string DateTimeNow()
        {
            return DateTime.Now.ToString();
        }

        public static string NameOfMethod()
        {
            StackTrace stackTrace = new();
            return stackTrace.GetFrame(1).GetMethod().Name;
        }
    }
}
