namespace lw3
{
    /// <summary>
    /// Базовый объект библиотеки (пример дочерних - книга или журнал)
    /// </summary>
    public abstract class LibraryItem
    {
        private string _name;

        public LibraryItem(string name)
        {
            Name = name;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public abstract void PrintItem();
    }
}