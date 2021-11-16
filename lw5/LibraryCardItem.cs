namespace lw5
{
    /// <summary>
    /// Элемент читательского билета.
    /// <param name="Book">Книга</param>
    /// <param name="BookStatus">Статус книги <seealso cref="BookStatus"/></param>
    /// </summary>
    public class LibraryCardItem
    {
        public delegate string Logger();

        Logger log;

        public void RegisterHandler(Logger handler)
        {
            log = handler;
        }
        public LibraryCardItem(ILibraryItem book, BookStatus bookStatus)
        {
            log += Program.DateTimeNow;
            log += Program.NameOfMethod;

            Book = book;
            Status = bookStatus;

            log += () => $"Создан новый читательский элемент читательского билета: {ToString()}";
            log?.Invoke();
        }

        public ILibraryItem Book { get; set; }

        public BookStatus Status { get; set; }

        public override string ToString() {
            return $"{Book} - {Status.GetString()}"; 
       }
    }
}