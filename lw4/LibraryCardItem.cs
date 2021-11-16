namespace lw4
{
    /// <summary>
    /// Элемент читательского билета.
    /// <param name="Book">Книга</param>
    /// <param name="BookStatus">Статус книги <seealso cref="BookStatus"/></param>
    /// </summary>
    public class LibraryCardItem
    {
        private LibraryItem _book;
        private BookStatus _status;

        public LibraryCardItem(LibraryItem book, BookStatus bookStatus)
        {
            Book = book;
            Status = bookStatus;
        }

        public LibraryItem Book
        {
            get => _book;
            set => _book = value;
        }

        public BookStatus Status
        {
            get => _status;
            set => _status = value;
        }

       public override string ToString() {
            return $"{Book} - {Status}"; 
       }
    }
}