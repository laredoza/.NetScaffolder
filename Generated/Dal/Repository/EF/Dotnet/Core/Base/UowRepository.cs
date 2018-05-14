namespace RepositoryEFDotnet.Library
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using Core.Base;

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

        protected UowRepository(IUnitOfWork unitOfWork)
        {
            this.UnitOfWork = unitOfWork ?? throw new ArgumentNullException($"unitOfWork");
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Get the unit of work in this repository
        /// </summary>
        protected IUnitOfWork UnitOfWork { get; private set; }

        #endregion
    }
}