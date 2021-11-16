namespace lw3
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
}
