// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IUnitOfWork.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// <summary>
//   This interface defines a unit of work
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.Core.Base
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
        #region Public Methods And Operators

        /// <summary>
        ///     The add.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        bool Add<TEntity>(TEntity item)
            where TEntity : class;

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

        /// <summary>
        /// The add range.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool AddRange<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        /// The add range async.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        /// The all matching.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <param name="hint">
        /// The hint.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<TEntity> AllMatching<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class;

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
        Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class;

        IEnumerable<TEntity> AllMatchingPaged<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool orderByAsc = false,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class;

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
        bool Any<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
            where TEntity : class;

        /// <summary>
        /// The any async.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
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
        void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class;

        /// <summary>
        ///     The commit.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        int Commit();

        /// <summary>
        /// Save changes to the database
        /// </summary>
        /// <returns></returns>
        bool Save();

        Task<bool> SaveAsync();

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

        /// <summary>
        /// The first or default.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        TEntity FirstOrDefault<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class;

        /// <summary>
        /// The first or default async.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TEntity> FirstOrDefaultAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class;

        /// <summary>
        /// The get.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TEntity"/>.
        /// </returns>
        TEntity Get<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null)
            where TEntity : class;

        IEnumerable<TEntity> GetAll<TEntity>(IEnumerable<string> includes = null)
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
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class;

        /// <summary>
        /// The get all paged.
        /// </summary>
        /// <param name="startPage">
        /// The start page.
        /// </param>
        /// <param name="pageSize">
        /// The page size.
        /// </param>
        /// <param name="orderBy">
        /// The order by.
        /// </param>
        /// <param name="orderByAscending">
        /// The order by ascending.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        IEnumerable<TEntity> GetAllPaged<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool orderByAscending = true,
            IEnumerable<string> includes = null)
            where TEntity : class;

        /// <summary>
        /// The get async.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null)
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
            IEnumerable<string> includes = null,
            Expression<Func<TEntity, bool>> filter = null,
            int pageGo = 0,
            int pageSize = 0,
            IEnumerable<string> orderBy = null,
            bool orderAscendent = false)
            where TEntity : class;

        /// <summary>
        /// The max.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="TResult"/>.
        /// </returns>
        TResult Max<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class;

        /// <summary>
        /// The max async.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<TResult> MaxAsync<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class;

        /// <summary>
        /// The modify.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool Modify<TEntity>(TEntity item)
            where TEntity : class;

        /// <summary>
        /// The modify async.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class;

        /// <summary>
        ///     The remove.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        bool Remove<TEntity>(TEntity item)
            where TEntity : class;

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
        Task<bool> RemoveAsync<TEntity>(TEntity item)
            where TEntity : class;

        /// <summary>
        /// The remove range.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        bool RemoveRange<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        /// The remove range async.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        ///     The roll back changes.
        /// </summary>
        void Rollback();

        /// <summary>
        /// The rollback async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        Task RollbackAsync();

        /// <summary>
        /// The start transaction.
        /// </summary>
        void StartTransaction();

        Task StartTransactionAsync();

        #endregion
    }
}