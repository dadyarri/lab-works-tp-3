using System;
using System.Diagnostics;
using System.Globalization;

namespace lw6
{
    class Program
    {
        static void Main(string[] args)
        {   
            Book book1 = new Book("Война и мир", "Л. Н. Толстой");
            book1.RegisterHandler(Console.WriteLine);

            Book book2 = new Book("Мастер и Маргарита", "М. А. Булгаков");
            book2.RegisterHandler(Console.WriteLine);

            Magazine mag1 = new Magazine("Ellie");
            mag1.RegisterHandler(Console.WriteLine);

            Reader reader1 = new Reader("Голубев Д. О.");
            reader1.RegisterHandler(Console.WriteLine);

            reader1.TakeBook(book1);
            reader1.PrintReaderInfo();

            var book2Item = reader1.TakeBook(book2);
            reader1.PrintReaderInfo();

            reader1.LoseBook(book2Item);

            reader1.PrintReaderInfo();

            reader1.ReturnBook(book1);
            reader1.PrintReaderInfo();

            reader1.TakeBook(mag1);
            reader1.PrintReaderInfo();
        }

        public static string DateTimeNow()
        {
            return DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        public static string NameOfMethod()
        {
            StackTrace stackTrace = new();
            return stackTrace.GetFrame(1)?.GetMethod()?.Name;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
