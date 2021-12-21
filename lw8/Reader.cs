using System;

namespace lw8
{
    public class Reader
    {
        public event Logger Activate;

        public void RegisterHandler(Logger handler)
        {
            Activate += handler;
        }

        public void UnregisterHandler(Logger handler)
        {
            Activate -= handler;
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
        public string TakeBook(LibraryItem book)
        {
            Activate?.Invoke($"delegate: Взята книга {book}");

            LibraryCardItem item = new LibraryCardItem(book, BookStatus.Taken);
            Card.Books.Add(item);

            return $"{item}";
        }
        
        /// <summary>
        /// Возвращает книгу в библиотеку
        /// </summary>
        /// <param name="book">Книга, которую вернул читатель</param>
        public void ReturnBook(LibraryItem book)
        {
            Activate?.Invoke($"delegate: Возвращена книга {book}");

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
            Activate?.Invoke($"delegate: Возвращена книга {item}");
        }

        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(LibraryItem book)
        {
            var item = _findTakenBookInLibraryCard(book);
            item.Status = BookStatus.Lost;
            Activate?.Invoke($"delegate: Утеряна книга {book}");
        }


        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(LibraryCardItem item)
        {
            item.Status = BookStatus.Lost;
            Activate?.Invoke($"delegate: Утеряна книга {item}");
        }

        /// <summary>
        /// Ищет запись в читательском билете с указанной книгой, если она на руках
        /// </summary>
        /// <param name="book">Книга, которую нужно найти</param>
        private LibraryCardItem _findTakenBookInLibraryCard(LibraryItem book)
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