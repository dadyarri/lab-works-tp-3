using System;
using System.Collections.Generic;

namespace lw5
{
    /// <summary>
    /// Читательский билет
    /// <param name="Books">Список из <c>LibraryCardItem</c>, в котором хранится история взятых и возвращенных книг/журналов</param>
    /// </summary>
    public class LibraryCard
    {
        public delegate string Logger();

        Logger log;

        public void RegisterHandler(Logger handler)
        {
            log = handler;
        }

        public LibraryCard()
        {
            log += Program.DateTimeNow;
            log += Program.NameOfMethod;

            Books = new List<LibraryCardItem> { };

            log += () => $"Создан новый читательский билет: {ToString()}";
            log?.Invoke();
        }

        public List<LibraryCardItem> Books { get; set; }

        public override string ToString()
        {
            return $"<{String.Join(", ", Books)}>";
        }
    }
}