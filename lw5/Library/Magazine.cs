using System;

namespace lw5
{
    /// <summary>
    /// Журнал - наследник класса <c>LibraryItem</c>. Реализует вывод информации для журнала
    /// </summary>
    public class Magazine: ILibraryItem
    {
        private delegate string Logger();
        Logger log;
        public string Name { get; set; }
        public Magazine(string name) {
            log += Program.DateTimeNow;
            log += Program.NameOfMethod;

            Name = name;
            log += () => $"Создан новый журнал: {ToString()}";

            log?.Invoke();
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