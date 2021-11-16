using System;

namespace lw4
{
    /// <summary>
    /// Журнал - наследник класса <c>LibraryItem</c>. Реализует вывод информации для журнала
    /// </summary>
    public class Magazine: LibraryItem
    {
        public Magazine(string name) : base(name) {}
        public override void PrintItem()
        {
            Console.WriteLine(Name);
        }
    }
}