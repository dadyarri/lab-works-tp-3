namespace lw5
{
    /// <summary>
    /// Базовый объект библиотеки (пример дочерних - книга или журнал)
    /// </summary>
    public interface ILibraryItem
    {
        public string Name
        {
            get; set;
        }

        public abstract void PrintItem();
    }
}