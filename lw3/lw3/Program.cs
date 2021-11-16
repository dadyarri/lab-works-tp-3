using System;

namespace lw3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("Война и мир", "Л. Н. Толстой");
            Book book2 = new Book("Мастер и Маргарита", "М. А. Булгаков");
            Magazine mag1 = new Magazine("Ellie");

            Reader reader1 = new Reader("Голубев Д. О.");
            reader1.TakeBook(book1);
            reader1.PrintReaderInfo();

            var book2Item = reader1.TakeBook(book2);
            reader1.PrintReaderInfo();

            reader1.LoseBook(book2Item);

            reader1.PrintReaderInfo();

            reader1.ReturnBook(book1);
            reader1.PrintReaderInfo();

            reader1.TakeBook(mag1);
            reader1.PrintReaderInfo();
        }
    }
}