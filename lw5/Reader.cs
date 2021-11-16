using System;

namespace lw5
{
    /// <summary>
    /// Читатель
    /// <param name="Name">Имя читателя</param>
    /// <param name="Card">Объект читательского билета (см. <see cref="LibraryCard"/>)</param>
    /// </summary>
    public class Reader
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

        public Reader(string name)
        {
            Name = name;
            Card = new LibraryCard();
        }

        public string Name { get; set; }

        public LibraryCard Card { get; set; }

        /// <summary>
        /// Добавляет новую книгу в читательский билет читателя и помечает её взятой
        /// </summary>
        /// <param name="book">Книга для добавления в читательский билет</param>
        /// <returns>Новый элемент читательского билета</returns>
        public LibraryCardItem TakeBook(ILibraryItem book)
        {
            log($"delegate: Взята книга {book}");

            LibraryCardItem item = new LibraryCardItem(book, BookStatus.Taken);
            Card.Books.Add(item);

            return item;
        }
        
        /// <summary>
        /// Возвращает книгу в библиотеку
        /// </summary>
        /// <param name="book">Книга, которую вернул читатель</param>
        public void ReturnBook(ILibraryItem book)
        {
            log($"delegate: Возвращена книга {book}");

            var item = _findTakenBookInLibraryCard(book);
            item.Status = BookStatus.Returned;
        }

        /// <summary>
        /// Возвращает книгу в библиотеку
        /// </summary>
        /// <param name="book">Книга, которую вернул читатель</param>
        public void ReturnBook(LibraryCardItem item)
        {
            item.Status = BookStatus.Returned;
            log($"delegate: Возвращена книга {item}");
        }

        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(ILibraryItem book)
        {
            var item = _findTakenBookInLibraryCard(book);
            item.Status = BookStatus.Lost;
            log($"delegate: Утеряна книга {book}");
        }


        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(LibraryCardItem item)
        {
            item.Status = BookStatus.Lost;
            log($"delegate: Утеряна книга {item}");
        }

        /// <summary>
        /// Ищет запись в читательском билете с указанной книгой, если она на руках
        /// </summary>
        /// <param name="book">Книга, которую нужно найти</param>
        private LibraryCardItem _findTakenBookInLibraryCard(ILibraryItem book)
        {
            LibraryCardItem foundItem = null;
            foreach (var item in Card.Books)
            {
                if (item.Book == book && item.Status == BookStatus.Taken)
                {
                    foundItem = item;
                    break;
                }
            }

            return foundItem;
        }

        /// <summary>
        /// Печатает информацию о читателе
        /// </summary>
        public void PrintReaderInfo()
        {
            Console.WriteLine($"{Name} taken these books {Card}");
        }
    }
}