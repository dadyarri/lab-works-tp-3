using System;
using System.Diagnostics;

namespace lw5
{
    class Program
    {
        static void Main(string[] args)
        {   
            Book book1 = new Book("Война и мир", "Л. Н. Толстой");
            book1.RegisterHandler(new Book.Logger(Console.WriteLine));

            Book book2 = new Book("Мастер и Маргарита", "М. А. Булгаков");
            book2.RegisterHandler(new Book.Logger(Console.WriteLine));

            Magazine mag1 = new Magazine("Ellie");
            mag1.RegisterHandler(new Magazine.Logger(Console.WriteLine));

            Reader reader1 = new Reader("Голубев Д. О.");
            reader1.RegisterHandler(new Reader.Logger(Console.WriteLine));

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
            return DateTime.Now.ToString();
        }

        public static string NameOfMethod()
        {
            StackTrace stackTrace = new();
            return stackTrace.GetFrame(1).GetMethod().Name;
        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
