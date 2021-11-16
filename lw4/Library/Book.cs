using System;

namespace lw4
{
    /// <summary>
    /// Книга - наследник класса <c>LibraryItem</c>. Реализует вывод информации для книги и добавляет поле автора
    /// </summary>
    public class Book: LibraryItem
    {
        private string _author;

        public Book(string name, string author) : base(name)
        {
            Name = name;
            Author = author;
        }

        public string Author
        {
            get => _author;
            set => _author = value;
        }

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