using System;
using System.Diagnostics;
using System.Globalization;

namespace lw7
{
    public delegate void Logger(string message);
    class Program
    {
        static void Main(string[] args)
        {   
            Book book1 = new Book("Война и мир", "Л. Н. Толстой");

            Book book2 = new Book("Мастер и Маргарита", "М. А. Булгаков");

            Magazine mag1 = new Magazine("Ellie");

            Reader reader1 = new Reader("Голубев Д. О.");
            reader1.RegisterHandler(SendMessageToLog);

            reader1.TakeBook(book1);
            reader1.PrintReaderInfo();

            reader1.TakeBook(book2);
            reader1.PrintReaderInfo();

            reader1.LoseBook(book2);

            reader1.PrintReaderInfo();

            reader1.ReturnBook(book1);
            reader1.PrintReaderInfo();

            reader1.TakeBook(mag1);
            reader1.PrintReaderInfo();
        }

        public static void SendMessageToLog(string message)
        {
            Console.WriteLine($"{DateTimeNow()} [{NameOfMethod()}]: {message}");
        }

        public static string DateTimeNow()
        {
            return DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        public static string NameOfMethod()
        {
            StackTrace stackTrace = new();
            return stackTrace.GetFrame(2)?.GetMethod()?.Name;
        }
    }
}
