// --------------------------------------------------------------------------------------------------------------------
// <copyright file="UowRepository.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// <summary>
//   Repository base class
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using DotNetScaffolder.Domain.Core.Interfaces;

namespace DotNetScaffolder.Domain.Core
{
    #region Using

    #endregion

    /// <summary>
    /// Repository base class
    /// </summary>
    /// <typeparam name="TEntity">
    /// The type of underlying entity in this repository
    /// </typeparam>
    public abstract class UowRepository<TEntity>
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
            // this.UnitOfWork = unitOfWork ?? throw new ArgumentNullException($"unitOfWork");
            this.UnitOfWork = unitOfWork;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UowRepository{TEntity}"/> class.
        /// </summary>
        protected UowRepository()
        {
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Get the unit of work in this repository
        /// </summary>
        public virtual IUnitOfWork UnitOfWork { get; set; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The update unit of work.
        /// </summary>
        /// <param name="unitOfWork">
        /// The unit of work.
        /// </param>
        public virtual void UpdateUnitOfWork(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork;
        }

        #endregion
    }
}