﻿namespace RepositoryEFDotnet.Library
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    ///     This interface defines a unit of work
    /// </summary>
    /// <summary>
    ///     The UnitOfWork contract for EF implementation
    /// </summary>
    public interface IUnitOfWork : IDisposable
    {
        #region Public methods and operators

        /// <summary>
        ///     The add.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        bool Add<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        ///     The add async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class;

        bool AddRange<TEntity>(IEnumerable<TEntity> item) where TEntity : class;

        Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> item) where TEntity : class;

        List<TEntity> AllMatching<TEntity>(Expression<Func<TEntity, bool>> filter, List<string> includes = null, string hint = "") where TEntity : class;

        /// <summary>
        ///     The all matching async.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<List<TEntity>> AllMatchingAsync<TEntity>(Expression<Func<TEntity, bool>> filter, List<string> includes = null, string hint = "") where TEntity : class;

        /// <summary>
        ///     Returns a boolean value indicating whether an expression returns a result.
        /// </summary>
        /// <typeparam name="TEntity">
        ///     The type of the entity.
        /// </typeparam>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool Any<TEntity>(List<string> includes = null, Expression<Func<TEntity, bool>> filter = null)
            where TEntity : class;

        Task<bool> AnyAsync<TEntity>(List<string> includes = null, Expression<Func<TEntity, bool>> filter = null)
            where TEntity : class;

        TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> filter = null, List<string> includes = null)
            where TEntity : class;

        Task<TEntity> FirstOrDefaultAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null, List<string> includes = null)
            where TEntity : class;

        /// <summary>
        ///     The apply current values.
        /// </summary>
        /// <param name="original">
        ///     The original.
        /// </param>
        /// <param name="current">
        ///     The current.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current) where TEntity : class;

        /// <summary>
        ///     The commit.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        int Commit();

        /// <summary>
        ///     The commit async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<int> CommitAsync();

        /// <summary>
        ///     The execute command.
        /// </summary>
        /// <param name="sqlCommand">
        ///     The sql command.
        /// </param>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        int ExecuteCommand(string sqlCommand, params object[] parameters);

        /// <summary>
        ///     The execute command async.
        /// </summary>
        /// <param name="sqlCommand">
        ///     The sql command.
        /// </param>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<int> ExecuteCommandAsync(string sqlCommand, params object[] parameters);

        /// <summary>
        ///     The execute query.
        /// </summary>
        /// <param name="sqlQuery">
        ///     The sql query.
        /// </param>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
        /// </returns>
        IQueryable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters);

        List<TEntity> GetAll<TEntity>(List<string> includes = null)
            where TEntity : class;

        /// <summary>
        ///     The get all async.
        /// </summary>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<List<TEntity>> GetAllAsync<TEntity>(List<string> includes = null)
            where TEntity : class;

        Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> filter, List<string> includes = null)
            where TEntity : class;

        TEntity Get<TEntity>(Expression<Func<TEntity, bool>> filter, List<string> includes = null)
            where TEntity : class;

        TResult Max<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter, List<string> includes = null)
            where TEntity : class;

        Task<TResult> MaxAsync<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter, List<string> includes = null)
            where TEntity : class;

        /// <summary>
        ///     The get queryable.
        /// </summary>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="pageGo">
        ///     The page go.
        /// </param>
        /// <param name="pageSize">
        ///     The page size.
        /// </param>
        /// <param name="orderBy">
        ///     The order by.
        /// </param>
        /// <param name="orderAscendent">
        ///     The order ascendent.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
        /// </returns>
        IQueryable<TEntity> GetQueryable<TEntity>(
            List<string> includes = null,
            Expression<Func<TEntity, bool>> filter = null,
            int pageGo = 0,
            int pageSize = 0,
            List<string> orderBy = null,
            bool orderAscendent = false) where TEntity : class;

        bool Modify<TEntity>(TEntity item) where TEntity : class;

        Task<bool> ModifyAsync<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        ///     The remove.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        bool Remove<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        ///     The remove async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> RemoveAsync<TEntity>(TEntity item) where TEntity : class;

        bool RemoveRange<TEntity>(IEnumerable<TEntity> item) where TEntity : class;

        Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> item) where TEntity : class;

        /// <summary>
        ///     The roll back changes.
        /// </summary>
        void Rollback();

        void StartTransaction();

        #endregion
    }
}