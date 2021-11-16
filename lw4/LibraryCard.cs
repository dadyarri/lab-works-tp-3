using System;
using System.Collections.Generic;

namespace lw4
{
    /// <summary>
    /// Читательский билет
    /// <param name="Books">Список из <c>LibraryCardItem</c>, в котором хранится история взятых и возвращенных книг/журналов</param>
    /// </summary>
    public class LibraryCard
    {
        private List<LibraryCardItem> _books;

        public LibraryCard()
        {
            Books = new List<LibraryCardItem> { };
        }

        public List<LibraryCardItem> Books
        {
            get => _books;
            set => _books = value;
        }

        public override string ToString()
        {
            return $"<{String.Join(", ", Books)}>";
        }
    }
}