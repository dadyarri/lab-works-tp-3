using System;
using System.Collections.Generic;

namespace lw8
{
    /// <summary>
    /// Читательский билет
    /// <param name="Books">Список из <c>LibraryCardItem</c>, в котором хранится история взятых и возвращенных книг/журналов</param>
    /// </summary>
    public class LibraryCard
    {
        Logger log;

        public void RegisterHandler(Logger handler)
        {
            log += handler;
        }

        public void UnregisterHandler(Logger handler)
        {
            log -= handler;
        }

        public LibraryCard()
        {
            Books = new List<LibraryCardItem>();
        }

        public List<LibraryCardItem> Books { get; set; }

        public override string ToString()
        {
            return $"<{string.Join(", ", Books)}>";
        }
    }
}