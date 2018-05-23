// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowRepository.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// <summary>
//   Repository base class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.Core.Base
{
    using System;

    #region Using

    #endregion

    /// <summary>
    ///     Repository base class
    /// </summary>
    /// <typeparam name="TEntity">
    ///     The type of underlying entity in this repository
    /// </typeparam>
    public abstract class UowRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="UowRepository{TEntity}"/> class.
        /// </summary>
        /// <param name="unitOfWork">
        /// The unit of work.
        /// </param>
        protected UowRepository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork ?? throw new ArgumentNullException($"unitOfWork");
        }

        #endregion

        #region Other Properties

        /// <summary>
        ///     Get the unit of work in this repository
        /// </summary>
        protected IUnitOfWork UnitOfWork { get; }

        #endregion
    }
}