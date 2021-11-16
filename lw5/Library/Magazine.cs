using System;

namespace lw5
{
    /// <summary>
    /// Журнал - наследник класса <c>LibraryItem</c>. Реализует вывод информации для журнала
    /// </summary>
    public class Magazine: ILibraryItem
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
        public string Name { get; set; }
        public Magazine(string name) {

            Name = name;
        }
        public void PrintItem()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}