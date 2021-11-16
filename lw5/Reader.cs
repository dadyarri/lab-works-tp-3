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
        private delegate string Logger();
        Logger log;

        public Reader(string name)
        {
            log += Program.DateTimeNow;
            log += Program.NameOfMethod;

            Name = name;
            Card = new LibraryCard();

            Logger createdLog = () => $"Создан новый читательский элемент читательского билета: {ToString()}";
            log += createdLog;

            log?.Invoke();

            log -= createdLog;
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
            Logger takenBookLog = () => $"Взята книга {book}";
            log += takenBookLog;

            LibraryCardItem item = new LibraryCardItem(book, BookStatus.Taken);
            Card.Books.Add(item);

            log?.Invoke();
            log -= takenBookLog;

            return item;
        }
        
        /// <summary>
        /// Возвращает книгу в библиотеку
        /// </summary>
        /// <param name="book">Книга, которую вернул читатель</param>
        public void ReturnBook(ILibraryItem book)
        {
            Logger returnedBookLog = () => $"Возвращена книга {book}";
            log += returnedBookLog;

            var item = _findTakenBookInLibraryCard(book);
            item.Status = BookStatus.Returned;

            log?.Invoke();
            log -= returnedBookLog;
        }

        /// <summary>
        /// Возвращает книгу в библиотеку
        /// </summary>
        /// <param name="book">Книга, которую вернул читатель</param>
        public void ReturnBook(LibraryCardItem item)
        {
            Logger returnedBookLog = () => $"Возвращена книга {item}";
            log += returnedBookLog;

            item.Status = BookStatus.Returned;

            log?.Invoke();
            log -= returnedBookLog;
        }

        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(ILibraryItem book)
        {
            Logger loseBookLog = () => $"Утеряна книга {book}";
            log += loseBookLog;

            var item = _findTakenBookInLibraryCard(book);
            item.Status = BookStatus.Lost;

            log?.Invoke();
            log -= loseBookLog;
        }


        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(LibraryCardItem item)
        {
            Logger loseBookLog = () => $"Утеряна книга {item}";
            log += loseBookLog;

            item.Status = BookStatus.Lost;

            log?.Invoke();
            log -= loseBookLog;
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