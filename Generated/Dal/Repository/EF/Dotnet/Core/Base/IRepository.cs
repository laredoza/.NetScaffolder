namespace Core.Base
{
    #region Using

    #endregion

    /// <summary>
    ///     This interface defines a unit of work
    /// </summary>
    /// <summary>
    ///     The UnitOfWork contract for EF implementation
    /// </summary>
    public interface IRepository
    {
        void Commit();
        void Rollback();
    }
}