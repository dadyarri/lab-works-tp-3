namespace lw5
{
    /// <summary>
    /// Статусы книг в читательском билете
    /// <c>Taken</c> - книга взята и находится у читателя
    /// <c>Returned</c> - книга возвращена в библиотеку
    /// <c>Lost</c>- книга потеряна
    /// </summary>
    public enum BookStatus
    {
        Taken,
        Returned,
        Lost,
    }

    public static class BookStatusExtensions
    {
        public static string GetString(this BookStatus me)
        {
            switch (me)
            {
                case BookStatus.Taken:
                    return "У читателя";
                case BookStatus.Returned:
                    return "Возвращена";
                case BookStatus.Lost:
                    return "Потеряна";
                default:
                    throw new NoSuchBookStatusException("Нет строкового эквивалента для этого статуса");
            }
        }
    }
}
