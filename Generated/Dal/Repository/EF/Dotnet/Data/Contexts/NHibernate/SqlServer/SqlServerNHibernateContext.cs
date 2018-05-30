// --------------------------------------------------------------------------------------------------------------------
// <copyright file="SqlServerNHibernateContext.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Banking.Models.Context.NHibernate
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using global::NHibernate;
    using global::NHibernate.Linq;

    using RepositoryEFDotnet.Core.Base;
    using RepositoryEFDotnet.Core.Utils;

    /// <summary>
    /// The sql server n hibernate context.
    /// </summary>
    public class SqlServerNHibernateContext : IUnitOfWork
    {
        #region Fields

        /// <summary>
        /// The current session.
        /// </summary>
        private ISession CurrentSession;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlServerNHibernateContext"/> class.
        /// </summary>
        /// <param name="session">
        /// The session.
        /// </param>
        public SqlServerNHibernateContext(ISession session)
        {
            this.CurrentSession = session;
        }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Add<TEntity>(TEntity item)
            where TEntity : class
        {
            this.CurrentSession.Persist(item);
            return true;
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The add range.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool AddRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            foreach (var ent in items)
            {
                this.Add(ent);
            }

            return true;
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

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
        public IEnumerable<TEntity> AllMatching<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).ToList();
        }

        /// <summary>
        /// The all matching async.
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
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).ToListAsync();
        }

        /// <summary>
        /// The all matching paged.
        /// </summary>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="startPage">
        /// The start page.
        /// </param>
        /// <param name="pageSize">
        /// The page size.
        /// </param>
        /// <param name="orderBy">
        /// The order by.
        /// </param>
        /// <param name="orderByAsc">
        /// The order by asc.
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IEnumerable<TEntity> AllMatchingPaged<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool orderByAsc = false,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The any.
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
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Any<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).Any();
        }

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
        public async Task<bool> AnyAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).AnyAsync();
        }

        /// <summary>
        /// The apply current values.
        /// </summary>
        /// <param name="original">
        /// The original.
        /// </param>
        /// <param name="current">
        /// The current.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The commit.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public int Commit()
        {
            if (this.CurrentSession?.Transaction != null && this.CurrentSession.Transaction.IsActive)
            {
                this.CurrentSession.Transaction.Commit();
            }

            return 1;
        }

        /// <summary>
        /// The commit async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<int> CommitAsync()
        {
            if (this.CurrentSession?.Transaction != null && this.CurrentSession.Transaction.IsActive)
            {
                await this.CurrentSession.Transaction.CommitAsync();
            }

            return 1;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
            if (this.CurrentSession != null)
            {
                if (this.CurrentSession.Transaction != null && this.CurrentSession.Transaction.IsActive)
                {
                    // wasn't committed, so must rollback
                    this.CurrentSession.Transaction.Rollback();
                }

                // CurrentSessionContext.Unbind(_sessionFactory);
                this.closeTransaction();
                this.closeSession();
            }
        }

        /// <summary>
        /// The execute command.
        /// </summary>
        /// <param name="sqlCommand">
        /// The sql command.
        /// </param>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The execute command async.
        /// </summary>
        /// <param name="sqlCommand">
        /// The sql command.
        /// </param>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public Task<int> ExecuteCommandAsync(string sqlCommand, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The execute query.
        /// </summary>
        /// <param name="sqlQuery">
        /// The sql query.
        /// </param>
        /// <param name="parameters">
        /// The parameters.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IQueryable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            throw new NotImplementedException();
        }

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
        public TEntity FirstOrDefault<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).FirstOrDefault();
        }

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
        public async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).FirstOrDefaultAsync();
        }

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
        public TEntity Get<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).FirstOrDefault();
        }

        /// <summary>
        /// The get all.
        /// </summary>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<TEntity> GetAll<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable<TEntity>(includes).ToList();
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable<TEntity>(includes).ToListAsync();
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public IEnumerable<TEntity> GetAllPaged<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool orderByAscending = true,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

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
        public async Task<TEntity> GetAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).FirstOrDefaultAsync();
        }

        /// <summary>
        /// The get queryable.
        /// </summary>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="pageGo">
        /// The page go.
        /// </param>
        /// <param name="pageSize">
        /// The page size.
        /// </param>
        /// <param name="orderBy">
        /// The order by.
        /// </param>
        /// <param name="orderAscendent">
        /// The order ascendent.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public IQueryable<TEntity> GetQueryable<TEntity>(
            IEnumerable<string> includes = null,
            Expression<Func<TEntity, bool>> filter = null,
            int pageGo = 0,
            int pageSize = 0,
            IEnumerable<string> orderBy = null,
            bool orderAscendent = false)
            where TEntity : class
        {
            var items = this.CurrentSession.Query<TEntity>();

            // if (includes != null && includes.Any())
            // foreach (var i in includes.Where(o => o != null))
            // items = items.Include(i);
            if (filter != null) items = items.Where(filter);

            if (pageSize > 0)
            {
                if (orderBy != null && orderBy.Any())
                {
                    foreach (var i in orderBy.Where(o => !string.IsNullOrEmpty(o)))
                        items = QueryableUtils.CallOrderBy(items, i, orderAscendent);

                    items = items.Skip(pageSize * (pageGo - 1));
                }

                items = items.Take(pageSize);
            }

            return items;
        }

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
        public TResult Max<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return this.GetQueryable<TEntity>(null, null).Max(filter);
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public Task<TResult> MaxAsync<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

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
        public bool Modify<TEntity>(TEntity item)
            where TEntity : class
        {
            this.CurrentSession.Update(item);
            return true;
        }

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
        public async Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await this.CurrentSession.UpdateAsync(item);
            return true;
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Remove<TEntity>(TEntity item)
            where TEntity : class
        {
            this.CurrentSession.Delete(item);
            return true;
        }

        /// <summary>
        /// The remove async.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task<bool> RemoveAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await this.CurrentSession.DeleteAsync(item);
            return true;
        }

        /// <summary>
        /// The remove range.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool RemoveRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            foreach (var item in items)
            {
                this.Remove(item);
            }

            return true;
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The rollback.
        /// </summary>
        public void Rollback()
        {
            if (this.CurrentSession?.Transaction != null && this.CurrentSession.Transaction.IsActive)
            {
                this.CurrentSession.Transaction.Rollback();
            }
        }

        /// <summary>
        /// The rollback async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task RollbackAsync()
        {
            if (this.CurrentSession?.Transaction != null && this.CurrentSession.Transaction.IsActive)
            {
                await this.CurrentSession.Transaction.RollbackAsync();
            }
        }

        /// <summary>
        /// The start transaction.
        /// </summary>
        public void StartTransaction()
        {
            if (this.CurrentSession == null
                || (this.CurrentSession.Transaction != null && this.CurrentSession.Transaction.IsActive))
            {
                return;
            }

            this.CurrentSession.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }

        /// <summary>
        /// The start transaction async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task StartTransactionAsync()
        {
            if (this.CurrentSession == null
                || (this.CurrentSession.Transaction != null && this.CurrentSession.Transaction.IsActive))
            {
                return;
            }

            await Task.Run(() => this.CurrentSession.BeginTransaction(System.Data.IsolationLevel.ReadCommitted));
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The close session.
        /// </summary>
        private void closeSession()
        {
            if (this.CurrentSession != null && this.CurrentSession.IsOpen) this.CurrentSession.Close();
            this.CurrentSession.Dispose();
            this.CurrentSession = null;
        }

        /// <summary>
        /// The close transaction.
        /// </summary>
        private void closeTransaction()
        {
            this.CurrentSession?.Transaction?.Dispose();
        }

        #endregion
    }
}