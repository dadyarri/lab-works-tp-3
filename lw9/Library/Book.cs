using System;

namespace lw9
{
    /// <summary>
    /// Книга - наследник класса <c>LibraryItem</c>. Реализует вывод информации для книги и добавляет поле автора
    /// </summary>
    public class Book : LibraryItem
    {
        public delegate void Logger(string message);

        Logger log;

        public void RegisterHandler(Logger handler)
        {
            log += handler;
        }

        public void UnregisterHandler(Logger handler)
        {
            log -= handler;
        }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;  
        }

        public string Name { get; set; }

        public string Author { get; set; }

        public override void PrintItem()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
}