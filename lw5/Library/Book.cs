using System;

namespace lw5
{
    /// <summary>
    /// Книга - наследник класса <c>LibraryItem</c>. Реализует вывод информации для книги и добавляет поле автора
    /// </summary>
    public class Book : ILibraryItem
    {
        public delegate string Logger();

        Logger log;

        public void RegisterHandler(Logger handler)
        {
            log = handler;
        }

        public Book(string name, string author)
        {
            log += Program.DateTimeNow;
            log += Program.NameOfMethod;

            Name = name;
            Author = author;
            
            log += () => $"Создана новая книга: {ToString()}";

            log?.Invoke();
        }

        public string Name { get; set; }

        public string Author { get; set; }

        public void PrintItem()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Name} - {Author}";
        }
    }
}