// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IDatabaseManager.cs" company="">
//   
// </copyright>
// <summary>
//   The DatabaseManager interface.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.Core.Base
{
    /// <summary>
    /// The DatabaseManager interface.
    /// </summary>
    public interface IDatabaseManager
    {
        #region Public Methods And Operators

        /// <summary>
        /// The begin unit of work.
        /// </summary>
        /// <returns>
        /// The <see cref="IUnitOfWork"/>.
        /// </returns>
        IUnitOfWork BeginUnitOfWork();

        #endregion
    }
}