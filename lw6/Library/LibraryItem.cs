namespace lw6
{
    /// <summary>
    /// Базовый объект библиотеки (пример дочерних - книга или журнал)
    /// </summary>
    public abstract class LibraryItem
    {
        public string Name
        {
            get; set;
        }

        public abstract void PrintItem();
    }
}