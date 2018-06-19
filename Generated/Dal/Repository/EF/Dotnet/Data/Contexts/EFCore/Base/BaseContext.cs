// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseContextCore.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace RepositoryEFDotnet.Contexts.EFCore
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Storage;

    using RepositoryEFDotnet.Core.Base;
    using RepositoryEFDotnet.Core.Utils;

    #endregion

    /// <summary>
    ///     The base context.
    /// </summary>
    /// <typeparam name="TContext">
    ///     The Context Type
    /// </typeparam>
    public abstract class BaseContext : DbContext, IUnitOfWork
    {
        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseContext"/> class.
        /// </summary>
        protected BaseContext()
        {
            this.SetupContext();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseContext"/> class.
        /// </summary>
        /// <param name="connectionName">
        /// The connection name.
        /// </param>
        protected BaseContext(string connectionString)
        {
            this.ConnectionString = connectionString;
            this.SetupContext();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseContext"/> class. 
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        protected BaseContext(DbContextOptions options)
            : base(options)
        {
            this.SetupContext();
        }

        #endregion

        #region Other Properties

        /// <summary>
        /// Gets or sets the connection name.
        /// </summary>
        protected string ConnectionString { get; }

        #endregion

        #region Public Methods And Operators

        /// <summary>
        /// The add.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// Entity Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Add<TEntity>(TEntity item)
            where TEntity : class
        {
            this.SetEntryState(item, EntityState.Added);
            this.GetDbSet<TEntity>().Add(item);
            return true;
        }

        /// <summary>
        /// The add async.
        /// </summary>
        /// <typeparam name="TEntity">
        /// The Entity Type
        /// </typeparam>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            return Task.Run(() => this.Add(item));
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
            this.SetEntryState(items, EntityState.Added);
            this.GetDbSet<TEntity>().AddRange(items);
            return true;
        }

        /// <summary>
        /// The add range async.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            return Task.Run(() => this.AddRange(items));
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
        /// Entity Type
        /// </typeparam>
        /// <returns>
        /// The
        ///     <see>
        ///         <cref>IEnumerable</cref>
        ///     </see>
        ///     .
        /// </returns>
        public IEnumerable<TEntity> AllMatching<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class
        {
            return this.GetQueryable(includes, filter);
        }

        /// <summary>
        /// The all matching async.
        /// </summary>
        /// <typeparam name="TEntity">
        /// The Entity Type
        /// </typeparam>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <param name="hint">
        /// The hint.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null,
            string hint = "")
            where TEntity : class
        {
            return Task.Run(() => this.AllMatching(filter, includes, hint));
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
            return this.GetQueryable(includes, filter, startPage, pageSize, orderBy, orderByAsc);
        }

        /// <summary>
        /// Returns a boolean value indicating whether an expression returns a result.
        /// </summary>
        /// <typeparam name="TEntity">
        /// The type of the entity.
        /// </typeparam>
        /// <param name="filter">
        /// The filter.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
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
        public Task<bool> AnyAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).AnyAsync();
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
        /// The Entity Type
        /// </typeparam>
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            this.Entry(original).CurrentValues.SetValues(current);
        }

        /// <summary>
        ///     The commit.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Commit()
        {
            this.ChangeTracker.DetectChanges();
            var result = this.SaveChanges();
            this.Database.CurrentTransaction?.Commit();
            return result;
        }

        public async Task<bool> SaveAsync()
        {
            var result = await Task.Run(() => base.SaveChanges());
            return result > 0;
        }

        public bool Save()
        {
            return this.SaveChanges() > 0;
        }

        /// <summary>
        ///     The commit async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<int> CommitAsync()
        {
            this.ChangeTracker.DetectChanges();
            var result = await base.SaveChangesAsync();
            this.Database.CurrentTransaction?.Commit();
            return result;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public override void Dispose()
        {
            this.Database.CurrentTransaction?.Rollback();
            this.Database.CurrentTransaction?.Dispose();
            base.Dispose();
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
        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            // return this.Database.ExecuteSqlCommand(sqlCommand, parameters);
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
        public Task<int> ExecuteCommandAsync(string sqlCommand, params object[] parameters)
        {
            // return this.Database.ExecuteSqlCommandAsync(sqlCommand, parameters);
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
        /// The Entity Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="IQueryable"/>.
        /// </returns>
        public IQueryable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            throw new NotImplementedException("Execute Query");
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
            return filter != null
                       ? this.GetDbSet<TEntity>().FirstOrDefault(filter)
                       : this.GetDbSet<TEntity>().FirstOrDefault();
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
        public Task<TEntity> FirstOrDefaultAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter = null,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return filter != null
                       ? this.GetDbSet<TEntity>().FirstOrDefaultAsync(filter)
                       : this.GetDbSet<TEntity>().FirstOrDefaultAsync();
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
            return this.GetQueryable<TEntity>(includes);
        }

        /// <summary>
        /// The get all async.
        /// </summary>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// The Entity Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class
        {
            return Task.Run(() => this.GetAll<TEntity>(includes));
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
        /// <param name="orderByAsc">
        /// The order by asc.
        /// </param>
        /// <param name="includes">
        /// The includes.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<TEntity> GetAllPaged<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool orderByAsc = true,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable<TEntity>(includes, null, startPage, pageSize, orderBy, orderByAsc);
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
        public Task<TEntity> GetAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).FirstOrDefaultAsync();
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
        /// The Entity Type
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
            IQueryable<TEntity> items = this.Set<TEntity>();

            if (includes != null && includes.Any())
                foreach (var i in includes.Where(o => o != null))
                    items = items.Include(i);

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
            return this.GetDbSet<TEntity>().Max(filter);
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
        public Task<TResult> MaxAsync<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return this.GetDbSet<TEntity>().MaxAsync(filter);
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
            this.SetEntryState(item, EntityState.Modified);
            this.GetDbSet<TEntity>().Update(item);
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
        public Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            return Task.Run(() => this.Modify(item));
        }

        /// <summary>
        /// The remove.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// The Entity Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public bool Remove<TEntity>(TEntity item)
            where TEntity : class
        {
            this.SetEntryState(item, EntityState.Deleted);
            this.GetDbSet<TEntity>().Remove(item);
            return true;
        }

        /// <summary>
        /// The remove async.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// The Entity Type
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<bool> RemoveAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            return Task.Run(() => this.Remove(item));
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
            this.SetEntryState(items, EntityState.Deleted);
            this.GetDbSet<TEntity>().RemoveRange(items);
            return true;
        }

        /// <summary>
        /// The remove range async.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            return Task.Run(() => this.RemoveRange(items));
        }

        /// <summary>
        ///     The roll back changes.
        /// </summary>
        public void Rollback()
        {
            this.Database.RollbackTransaction();

            // foreach (var entry in this.ChangeTracker.Entries()) entry.State = EntityState.Unchanged;
        }

        /// <summary>
        /// The rollback async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public async Task RollbackAsync()
        {
            await Task.Run(() => this.Rollback());
        }

        /// <summary>
        /// The start transaction.
        /// </summary>
        public virtual void StartTransaction()
        {
            if (this.Database.CurrentTransaction == null)
            {
                this.Database.BeginTransaction();
            }
        }

        public virtual async Task StartTransactionAsync()
        {
            if (this.Database.CurrentTransaction == null)
            {
                await this.Database.BeginTransactionAsync();
            }
        }

        #endregion

        #region Other Methods

        /// <summary>
        /// The log
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        protected virtual void Log(string message)
        {
            // #if DEBUG
            Console.WriteLine(message);

            // #endif
        }

        /// <summary>
        /// The setup context.
        /// </summary>
        protected abstract void SetupContext();

        /// <summary>
        ///     The get db set.
        /// </summary>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="DbSet" />.
        /// </returns>
        private DbSet<TEntity> GetDbSet<TEntity>()
            where TEntity : class
        {
            return this.Set<TEntity>();
        }

        /// <summary>
        /// The set entry state.
        /// </summary>
        /// <param name="item">
        /// The item.
        /// </param>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <typeparam name="TEntity">
        /// The Entity Type
        /// </typeparam>
        private void SetEntryState<TEntity>(TEntity item, EntityState state)
            where TEntity : class
        {
            var entry = this.Entry(item);

            if (state == EntityState.Deleted || state == EntityState.Modified)
            {
                if (entry.State == EntityState.Detached)
                {
                    this.GetDbSet<TEntity>().Attach(item);
                }
            }

            if (entry.State != state)
            {
                entry.State = state;
            }
        }

        /// <summary>
        /// The set entry state.
        /// </summary>
        /// <param name="items">
        /// The items.
        /// </param>
        /// <param name="state">
        /// The state.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        private void SetEntryState<TEntity>(IEnumerable<TEntity> items, EntityState state)
            where TEntity : class
        {
            foreach (var item in items) this.SetEntryState(item, state);
        }

        #endregion

        ///// <summary>
        /////     Initializes a new instance of the <see cref="BaseContext" /> class.
        ///// </summary>
        ///// <param name="existingConnection">
        /////     The connection string name.
        ///// </param>
        ///// <param name="contextOwnsConnection">
        /////     The context owns connection.
        ///// </param>
        // protected BaseContext(DbConnection existingConnection, bool contextOwnsConnection)
        // : base(existingConnection, contextOwnsConnection)
        // {
        // SetupContext();
        // }

        ///// <summary>
        /////     Initializes a new instance of the <see cref="BaseContext" /> class.
        ///// </summary>
        ///// <param name="existingConnection">
        /////     The existing connection.
        ///// </param>
        ///// <param name="model">
        /////     The model.
        ///// </param>
        ///// <param name="contextOwnsConnection">
        /////     The context owns connection.
        ///// </param>
        // protected BaseContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
        // : base(existingConnection, model, contextOwnsConnection)
        // {
        // SetupContext();
        // }

        // protected BaseContext(DbTransaction transaction)
        // {
        // SetupContext();
        // Database.UseTransaction(transaction);
        // }
    }
}