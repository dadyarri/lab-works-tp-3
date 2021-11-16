namespace lw5
{
    /// <summary>
    /// Элемент читательского билета.
    /// <param name="Book">Книга</param>
    /// <param name="BookStatus">Статус книги <seealso cref="BookStatus"/></param>
    /// </summary>
    public class LibraryCardItem
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

        public LibraryCardItem(ILibraryItem book, BookStatus bookStatus)
        {
           Book = book;
           Status = bookStatus;
        }

        public ILibraryItem Book { get; set; }

        public BookStatus Status { get; set; }

        public override string ToString() {
            return $"{Book} - {Status.GetString()}"; 
       }
    }
}