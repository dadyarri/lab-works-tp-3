using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;

namespace lw9
{
    public delegate void Logger(string message);
    class Program
    {
        private readonly List<Book> _books = new();
        
        static void Main()
        {   
            new Program().ShowMenu();
        }

        private void ShowMenu()
        {
            Console.WriteLine("1 - Создать книгу");
            Console.WriteLine("2 - Показать книги");
            switch (Convert.ToInt16(Console.ReadLine()))
            {
                case 1:
                {
                    CreateBook();
                    break;
                }
                case 2:
                {
                    ShowBooks();
                    break;
                }
            }
        }

        private void ShowBooks()
        {
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
            ShowMenu();
        }

        private void CreateBook()
        {
            Console.Write("Введите название книги: ");
            string bookName = Console.ReadLine();
            Console.Write("Введите автора книги: ");
            string authorName = Console.ReadLine();
            
            Book book = new(bookName, authorName);
            _books.Add(book);
            
            Thread writeToFile = new(() => WriteBookCreatingToFile(book));
            writeToFile.Start();
            
            ShowMenu();
        }

        private void WriteBookCreatingToFile(Book book)
        {
            string pathToFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log.txt"); 
            SendMessageToLog("Новая книга создана, запись в файл...");
            if (!File.Exists(pathToFile))
            {
                using StreamWriter sw = File.CreateText(pathToFile);
            }
            using StreamWriter asw = File.AppendText(pathToFile);
            asw.WriteLine(GenerateLogMessage($"Создана книга: {book}"));
        }

        private static string GenerateLogMessage(string message)
        {
            return $"{DateTimeNow()} [{NameOfMethod()}]: {message}";
        }

        private void SendMessageToLog(string message)
        {
            Console.WriteLine(GenerateLogMessage(message));
        }


        private static string DateTimeNow()
        {
            return DateTime.Now.ToString(CultureInfo.CurrentCulture);
        }

        private static string NameOfMethod()
        {
            StackTrace stackTrace = new();
            return stackTrace.GetFrame(2)?.GetMethod()?.Name;
        }
    }
}
