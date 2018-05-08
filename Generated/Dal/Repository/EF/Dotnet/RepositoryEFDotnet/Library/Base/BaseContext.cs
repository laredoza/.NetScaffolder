namespace RepositoryEFDotnet.Library
{
    #region Using

    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    #endregion

    /// <summary>
    ///     The base context.
    /// </summary>
    /// <typeparam name="TContext">
    ///     The Context Type
    /// </typeparam>
    public abstract class BaseContext : DbContext, IUnitOfWork
    {
        private DbContextTransaction transaction = null;

        #region Constructors and Destructors

        protected BaseContext()
        {
            SetupContext();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="nameOrConnectionstring">
        ///     The connection string name
        /// </param>
        protected BaseContext(string nameOrConnectionstring)
            : base(nameOrConnectionstring)
        {
            SetupContext();
        }

        protected BaseContext(DbConnection connection, bool contextOwnsConnection)
            : base(connection, contextOwnsConnection)
        {
            SetupContext();
        }

        ///// <summary>
        /////     Initializes a new instance of the <see cref="BaseContext" /> class.
        ///// </summary>
        ///// <param name="existingConnection">
        /////     The connection string name.
        ///// </param>
        ///// <param name="contextOwnsConnection">
        /////     The context owns connection.
        ///// </param>
        //protected BaseContext(DbConnection existingConnection, bool contextOwnsConnection)
        //    : base(existingConnection, contextOwnsConnection)
        //{
        //    SetupContext();
        //}

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
        //protected BaseContext(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection)
        //    : base(existingConnection, model, contextOwnsConnection)
        //{
        //    SetupContext();
        //}

        //protected BaseContext(DbTransaction transaction)
        //{
        //    SetupContext();
        //    Database.UseTransaction(transaction);
        //}

        #endregion

        #region Public methods and operators

        /// <summary>
        ///     The add.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        ///     Entity Type
        /// </typeparam>
        public bool Add<TEntity>(TEntity item)
            where TEntity : class
        {
            SetEntryState(item, EntityState.Added);
            GetDbSet<TEntity>().Add(item);
            return true;
        }

        /// <summary>
        ///     The add async.
        /// </summary>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            return Task.Run(() => Add(item));
        }

        public bool AddRange<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            SetEntryState(items, EntityState.Added);
            GetDbSet<TEntity>().AddRange(items);
            return true;
        }

        public Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            return Task.Run(()=> AddRange(items));
        }

        /// <summary>
        ///     The all matching.
        /// </summary>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <param name="hint">
        ///     The hint.
        /// </param>
        /// <typeparam name="TEntity">
        ///     Entity Type
        /// </typeparam>
        /// <returns>
        ///     The
        ///     <see>
        ///         <cref>IEnumerable</cref>
        ///     </see>
        ///     .
        /// </returns>
        public IEnumerable<TEntity> AllMatching<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null, string hint = "")
            where TEntity : class
        {
            return GetQueryable(includes, filter);
        }

        /// <summary>
        ///     The all matching async.
        /// </summary>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <param name="hint">
        ///     The hint.
        /// </param>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null, string hint = "")
            where TEntity : class
        {
            return Task.Run(() => AllMatching(filter, includes, hint));
        }

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
        public bool Any<TEntity>(IEnumerable<string> includes = null, Expression<Func<TEntity, bool>> filter = null)
            where TEntity : class
        {
            IQueryable<TEntity> items = Set<TEntity>();
            if (includes != null && includes.Any())
            {
                foreach(var i in includes.Where(o=> o != null))
                {
                    items = items.Include(i);
                }
            }

            if (filter != null)
            {
                return items.Any(filter);
            }

            throw new Exception("No filter provided for any query");
        }

        public Task<bool> AnyAsync<TEntity>(IEnumerable<string> includes = null, Expression<Func<TEntity, bool>> filter = null)
            where TEntity : class
        {
            return Task.Run(() => Any(includes, filter));
        }

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
        ///     The Entity Type
        /// </typeparam>
        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            Entry(original).CurrentValues.SetValues(current);
        }

        /// <summary>
        ///     The commit.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public int Commit()
        {
            ChangeTracker.DetectChanges();
            var result = SaveChanges();
            transaction?.Commit();
            return result;
        }

        /// <summary>
        ///     The commit async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public Task<int> CommitAsync()
        {
            return Task.Run(() => Commit());
        }

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
        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            return Database.ExecuteSqlCommand(sqlCommand, parameters);
        }

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
        public Task<int> ExecuteCommandAsync(string sqlCommand, params object[] parameters)
        {
            return Database.ExecuteSqlCommandAsync(sqlCommand, parameters);
        }

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
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
        /// </returns>
        public IQueryable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            return Database.SqlQuery<TEntity>(sqlQuery, parameters).AsQueryable();
        }

        public TEntity Get<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null) where TEntity : class
        {
            return this.GetQueryable(includes, filter).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll<TEntity>(IEnumerable<string> includes = null) where TEntity : class
        {
            return GetQueryable<TEntity>(includes);
        }

        /// <summary>
        ///     The get all async.
        /// </summary>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class
        {
            return Task.Run(() => GetAll<TEntity>(includes));
        }

        public Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null) where TEntity : class
        {
            return Task.Run(() => Get(filter, includes));
        }

        public TResult Max<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter, IEnumerable<string> includes = null) where TEntity : class
        {
            return this.GetDbSet<TEntity>().Max(filter);
        }

        public Task<TResult> MaxAsync<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter, IEnumerable<string> includes = null) where TEntity : class
        {
            return Task.Run(() => Max(filter, includes));
        }

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
            return Set<TEntity>();
        }

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
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
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
            IQueryable<TEntity> items = Set<TEntity>();

            if (includes != null && includes.Any())
            {
                foreach (var i in includes.Where(o => o != null))
                {
                    items = items.Include(i);
                }
            }

            if (filter != null)
            {
                items = items.Where(filter);
            }

            if (pageSize > 0)
            {
                if (orderBy != null && orderBy.Any())
                {
                    foreach (var i in orderBy.Where(o => !string.IsNullOrEmpty(o)))
                    {
                        items = QueryableUtils.CallOrderBy(items, i, orderAscendent);
                    }

                    items = items.Skip(pageSize * (pageGo - 1));
                }

                items = items.Take(pageSize);
            }

            return items;
        }

        public bool Modify<TEntity>(TEntity item) where TEntity : class
        {
            SetEntryState(item, EntityState.Modified);
            GetDbSet<TEntity>().AddOrUpdate(item);
            return true;
        }

        public Task<bool> ModifyAsync<TEntity>(TEntity item) where TEntity : class
        {
            return Task.Run(() => Modify(item));
        }

        /// <summary>
        ///     The remove.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        public bool Remove<TEntity>(TEntity item)
            where TEntity : class
        {
            SetEntryState(item, EntityState.Deleted);
            GetDbSet<TEntity>().Remove(item);
            return true;
        }

        /// <summary>
        ///     The remove async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public Task<bool> RemoveAsync<TEntity>(TEntity item) where TEntity : class
        {
            return Task.Run(() => Remove(item));
        }

        public bool RemoveRange<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            SetEntryState(items, EntityState.Deleted);
            GetDbSet<TEntity>().RemoveRange(items);
            return true;
        }

        public Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            return Task.Run(() => RemoveRange(items));
        }

        /// <summary>
        ///     The roll back changes.
        /// </summary>
        public void Rollback()
        {
            transaction?.Rollback();

            foreach(var entry in ChangeTracker.Entries())
            {
                entry.State = EntityState.Unchanged;
            }
        }

        /// <summary>
        ///     The set entry state.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <param name="state">
        ///     The state.
        /// </param>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        private void SetEntryState<TEntity>(TEntity item, EntityState state)
            where TEntity : class
        {
            var entry = Entry(item);

            if (state == EntityState.Deleted || state == EntityState.Modified)
            {
                if (entry.State == EntityState.Detached)
                {
                    GetDbSet<TEntity>().Attach(item);
                }
            }

            entry.State = state;
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The log
        /// </summary>
        /// <param name="message">
        ///     The message.
        /// </param>
        protected virtual void Log(string message)
        {
//#if DEBUG
            Console.WriteLine(message);
//#endif
        }

        protected abstract void SetupContext();

        public void StartTransaction()
        {
            if (transaction == null)
            {
                transaction = this.Database.BeginTransaction(IsolationLevel.ReadCommitted);
            }
        }

        protected override void Dispose(bool disposing)
        {
            transaction?.Dispose();
            transaction = null;
            this.Database.UseTransaction(null);
            base.Dispose(disposing);
        }

        public TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null) where TEntity : class
        {
            return this.GetDbSet<TEntity>().FirstOrDefault(filter);
        }

        public Task<TEntity> FirstOrDefaultAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null) where TEntity : class
        {
            return Task.Run(() => this.FirstOrDefault(filter, includes));
        }

        #endregion
    }
}