#region

using System;
using System.Linq.Expressions;
using DotNetScaffolder.Domain.Core.Interfaces;
using NHibernate;

#endregion

namespace RepositoryEFDotnet.Contexts.NHib.Base
{
    #region

    #endregion

    /// <summary>
    ///     This interface defines a unit of work
    /// </summary>
    /// <summary>
    ///     The UnitOfWork contract for EF implementation
    /// </summary>
    public interface INHibUnitOfWork : IUnitOfWork
    {
        #region Public Methods And Operators

        ICriteria CreateCriteria<TEntity>() where TEntity : class;

        ICriteria CreateCriteria(string entityName);

        TEntity Get<TEntity, IDType>(IDType id);

        TEntity Get<TEntity>(object id);

        IQueryOver<TEntity, TEntity> QueryOver<TEntity>()
            where TEntity : class;

        IQueryOver<TEntity> QueryOver<TEntity>(string entityName, Expression<Func<TEntity>> expr)
            where TEntity : class;

        #endregion
    }
}