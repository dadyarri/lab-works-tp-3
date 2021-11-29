using System;

namespace lw3
{
    /// <summary>
    /// Читатель
    /// <param name="Name">Имя читателя</param>
    /// <param name="Card">Объект читательского билета (см. <see cref="LibraryCard"/>)</param>
    /// </summary>
    public class Reader
    {
        private string _name;
        private LibraryCard _card;

        public Reader(string name)
        {
            Name = name;
            Card = new LibraryCard();
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public LibraryCard Card
        {
            get => _card;
            set => _card = value;
        }
        /// <summary>
        /// Добавляет новую книгу в читательский билет читателя и помечает её взятой
        /// </summary>
        /// <param name="book">Книга для добавления в читательский билет</param>
        /// <returns>Новый элемент читательского билета</returns>
        public LibraryCardItem TakeBook(LibraryItem book)
        {
            LibraryCardItem item = new LibraryCardItem(book, BookStatus.Taken);
            Card.Books.Add(item);
            
            return item;
        }
        
        /// <summary>
        /// Возвращает книгу в библиотеку
        /// </summary>
        /// <param name="book">Книга, которую вернул читатель</param>
        public void ReturnBook(LibraryItem book)
        {
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
        }

        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(LibraryItem book)
        {
            var item = _findTakenBookInLibraryCard(book);
            item.Status = BookStatus.Lost;
        }


        /// <summary>
        /// Утеря книги читателем
        /// </summary>
        /// <param name="book">Книга, которую потерял читатель</param>
        public void LoseBook(LibraryCardItem item)
        {
            item.Status = BookStatus.Lost;
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