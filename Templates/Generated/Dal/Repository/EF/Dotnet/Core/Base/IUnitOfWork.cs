#region

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

#endregion

namespace RepositoryEFDotnet.Core.Base
{
    #region Using

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
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
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
        ///     The add range.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool AddRange<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        ///     The add range async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        ///     The all matching.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        IEnumerable<TEntity> AllMatching<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The all matching async.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The all matching paged.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="startPage">
        ///     The start page.
        /// </param>
        /// <param name="pageSize">
        ///     The page size.
        /// </param>
        /// <param name="orderBy">
        ///     The order by.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="orderByAsc">
        ///     The order by asc.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        IEnumerable<TEntity> AllMatchingPaged<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAsc = false,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The all matching paged async.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="startPage">
        ///     The start page.
        /// </param>
        /// <param name="pageSize">
        ///     The page size.
        /// </param>
        /// <param name="orderBy">
        ///     The order by.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="orderByAsc">
        ///     The order by asc.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<TEntity>> AllMatchingPagedAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAsc = false,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     Returns a boolean value indicating whether an expression returns a result.
        /// </summary>
        /// <typeparam name="TEntity">
        ///     The type of the entity.
        /// </typeparam>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool Any<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The any.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool Any<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The any async.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> AnyAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The any async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> AnyAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
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
        ///     Bulk delete entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkDelete<TEntity>(IEnumerable<TEntity> items) where TEntity : class;

        /// <summary>
        ///     Bulk delete entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkDeleteAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class;

        /// <summary>
        ///     Bulk insert entities
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkInsert<TEntity>(IEnumerable<TEntity> items) where TEntity : class;
        
        /// <summary>
        /// Bulk insert entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkInsertAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class;

        /// <summary>
        /// Bulk update entities 
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        void BulkUpdate<TEntity>(IEnumerable<TEntity> items) where TEntity : class;

        /// <summary>
        /// Bulk update entities async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        Task BulkUpdateAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class;

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
        int ExecuteCommand(
            string sqlCommand,
            IEnumerable<IDataParameter> parameters = null);

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
        Task<int> ExecuteCommandAsync(
            string sqlCommand,
            IEnumerable<IDataParameter> parameters = null);

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
        IQueryable<TEntity> ExecuteQuery<TEntity>(
            string sqlQuery,
            IEnumerable<IDataParameter> parameters = null)
            where TEntity : class;

        /// <summary>
        ///     The execute query async.
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
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IQueryable<TEntity>> ExecuteQueryAsync<TEntity>(
            string sqlQuery,
            IEnumerable<IDataParameter> parameters = null)
            where TEntity : class;

        /// <summary>
        ///     The first or default.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="TEntity" />.
        /// </returns>
        TEntity FirstOrDefault<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The first or default.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="TEntity" />.
        /// </returns>
        TEntity FirstOrDefault<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The first or default async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<TEntity> FirstOrDefaultAsync<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The first or default async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<TEntity> FirstOrDefaultAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="TEntity" />.
        /// </returns>
        TEntity Get<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get all.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        IEnumerable<TEntity> GetAll<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get all async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get all paged.
        /// </summary>
        /// <param name="startPage">
        ///     The start page.
        /// </param>
        /// <param name="pageSize">
        ///     The page size.
        /// </param>
        /// <param name="orderBy">
        ///     The order by.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="orderByAscending">
        ///     The order by ascending.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IEnumerable" />.
        /// </returns>
        IEnumerable<TEntity> GetAllPaged<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAscending = true,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get all paged async.
        /// </summary>
        /// <param name="startPage">
        ///     The start page.
        /// </param>
        /// <param name="pageSize">
        ///     The page size.
        /// </param>
        /// <param name="orderBy">
        ///     The order by.
        /// </param>
        /// <param name="cache"></param>
        /// <param name="orderByAscending">
        ///     The order by ascending.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<IEnumerable<TEntity>> GetAllPagedAsync<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAscending = true,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<TEntity> GetAsync<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The get queryable.
        /// </summary>
        /// <param name="cache"></param>
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
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
        /// </returns>
        IQueryable<TEntity> GetQueryable<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter = null,
            int pageGo = 0,
            int pageSize = 0,
            IEnumerable<string> orderBy = null,
            bool orderAscendent = false,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class;

        /// <summary>
        ///     The max.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="TResult" />.
        /// </returns>
        TResult Max<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class;

        /// <summary>
        ///     The max async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<TResult> MaxAsync<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class;

        /// <summary>
        ///     The min.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="TResult" />.
        /// </returns>
        TResult Min<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class;

        /// <summary>
        ///     The min async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <typeparam name="TResult">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<TResult> MinAsync<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class;

        /// <summary>
        ///     The modify.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool Modify<TEntity>(TEntity item)
            where TEntity : class;

        /// <summary>
        ///     The modify async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class;

        void NoTracking<TEntity>(TEntity item) where TEntity : class;

        /// <summary>
        ///     The remove.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
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
        ///     The remove range.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool RemoveRange<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        ///     The remove range async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class;

        /// <summary>
        ///     The roll back changes.
        /// </summary>
        void Rollback();

        /// <summary>
        ///     The rollback async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task RollbackAsync();

        /// <summary>
        ///     Save changes to the database
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        bool Save();

        /// <summary>
        ///     The save async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task<bool> SaveAsync();

        /// <summary>
        ///     The start transaction.
        /// </summary>
        void StartTransaction();

        /// <summary>
        ///     The start transaction async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        Task StartTransactionAsync();

        #endregion
    }
}