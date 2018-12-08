#region

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EFSecondLevelCache.Core;
using EFSecondLevelCache.Core.Contracts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RepositoryEFDotnet.Core.Base;
using RepositoryEFDotnet.Core.Utils;

#endregion

namespace RepositoryEFDotnet.Contexts.EFCore.Base.Context
{
    #region Using

    #endregion

    /// <summary>
    ///     The base context.
    /// </summary>
    ///     The Context Type
    /// </typeparam>
    public abstract class BaseContext : DbContext, IUnitOfWork
    {
        #region Fields

        protected IEFCacheServiceProvider cacheProvider;

        private readonly IServiceProvider serviceProvider;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        protected BaseContext(IServiceProvider provider = null)
        {
            serviceProvider = provider;
            SetupContext();
            InitCacheProvider();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="connectionName">
        ///     The connection name.
        /// </param>
        protected BaseContext(string connectionString, IServiceProvider provider = null)
        {
            serviceProvider = provider;
            ConnectionString = connectionString;
            SetupContext();
            InitCacheProvider();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        protected BaseContext(DbContextOptions options, IServiceProvider provider = null)
            : base(options)
        {
            serviceProvider = provider;
            SetupContext();
            InitCacheProvider();
        }

        #endregion

        #region Other Properties

        /// <summary>
        ///     Gets or sets the connection name.
        /// </summary>
        protected string ConnectionString { get; }

        #endregion

        #region Public Methods And Operators

        public static string GetPath(Expression exp)
        {
            switch (exp.NodeType)
            {
                case ExpressionType.MemberAccess:
                    var name = GetPath(((MemberExpression) exp).Expression) ?? "";

                    if (name.Length > 0)
                        name += ".";

                    return name + ((MemberExpression) exp).Member.Name;

                case ExpressionType.Convert:
                case ExpressionType.Quote:
                    return GetPath(((UnaryExpression) exp).Operand);

                case ExpressionType.Lambda:
                    return GetPath(((LambdaExpression) exp).Body);
                case ExpressionType.Call:

                    var result = string.Empty;

                    var a = exp as MethodCallExpression;

                    foreach (var argument in a.Arguments) result += $".{GetPath(argument)}";

                    return result.Trim('.');
                default:
                    return null;
            }
        }

        /// <inheritdoc />
        /// <summary>
        ///     The add.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        ///     Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="T:System.Boolean" />.
        /// </returns>
        public new bool Add<TEntity>(TEntity item)
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
        public async Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            SetEntryState(item, EntityState.Added);
            await GetDbSet<TEntity>().AddAsync(item);
            return true;
        }

        /// <summary>
        ///     The add range.
        /// </summary>
        /// <param name="items">
        ///     The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public bool AddRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            var itemList = items.ToList();
            SetEntryState(itemList, EntityState.Added);
            GetDbSet<TEntity>().AddRange(itemList);
            return true;
        }

        /// <summary>
        ///     The add range async.
        /// </summary>
        /// <param name="items">
        ///     The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            var itemList = items.ToList();
            SetEntryState(itemList, EntityState.Added);
            await GetDbSet<TEntity>().AddRangeAsync(itemList);
            return true;
        }

        public IEnumerable<TEntity> AllMatching<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes);
        }

        public async Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).ToListAsync();
        }

        public IEnumerable<TEntity> AllMatchingPaged<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAsc = false,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, startPage, pageSize, orderBy, orderByAsc, includes).ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> AllMatchingPagedAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAsc = false,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, startPage, pageSize, orderBy, orderByAsc, includes).ToListAsync();
        }

        /// <summary>
        ///     Returns a boolean value indicating whether an expression returns a result.
        /// </summary>
        /// <typeparam name="TEntity">
        ///     The type of the entity.
        /// </typeparam>
        /// <param name="cache"></param>
        /// <param name="filter">
        ///     The filter.
        /// </param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public bool Any<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).Any();
        }

        public bool Any<TEntity>(
            bool cache,
            params Expression<Func<TEntity,
                object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, null, 0, 0, null, false, includes).Any();
        }

        /// <summary>
        ///     The any async.
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
        public async Task<bool> AnyAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).AnyAsync();
        }

        public async Task<bool> AnyAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, null, 0, 0, null, false, includes).AnyAsync();
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
        ///     Bulk delete
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public virtual void BulkDelete<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            // Todo: Should be replaced with actual bulk deletes
            RemoveRange(items);
        }

        /// <summary>
        ///     Bulk delete async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual async Task BulkDeleteAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            // Todo: Should be replaced with actual bulk deletes async
            await RemoveRangeAsync(items);
        }

        /// <summary>
        ///     Bulk insert
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public virtual void BulkInsert<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            // Todo: Should be replaced with actual bulk add
            AddRange(items);
        }

        /// <summary>
        ///     Bulk insert async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual async Task BulkInsertAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            // Todo: Should be replaced with actual bulk add async 
            await AddRangeAsync(items);
        }

        /// <summary>
        ///     Bulk update
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        public virtual void BulkUpdate<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            // Todo: Should be replaced with actual bulk update range 
            UpdateRange(items);
        }

        /// <summary>
        ///     Bulk update async
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="items"></param>
        /// <returns></returns>
        public virtual async Task BulkUpdateAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            // Todo: Should be replaced with actual bulk update async 
            foreach (var item in items) Update(item);
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
            Database.CurrentTransaction?.Commit();
            return result;
        }

        /// <summary>
        ///     The commit async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<int> CommitAsync()
        {
            ChangeTracker.DetectChanges();
            var result = await SaveChangesAsync();
            Database.CurrentTransaction?.Commit();
            return result;
        }

        /// <summary>
        ///     The dispose.
        /// </summary>
        public override void Dispose()
        {
            if (Database.CurrentTransaction != null)
            {
                Database.CurrentTransaction?.Rollback();
                Database.CurrentTransaction?.Dispose();
            }
            else
            {
                Database.CloseConnection();
            }

            base.Dispose();
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
        public int ExecuteCommand(string sqlCommand, IEnumerable<IDataParameter> parameters = null)
        {
            if (parameters != null) return Database.ExecuteSqlCommand(sqlCommand, parameters);

            return Database.ExecuteSqlCommand(sqlCommand);
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
        public async Task<int> ExecuteCommandAsync(string sqlCommand, IEnumerable<IDataParameter> parameters = null)
        {
            if (parameters != null) return await Database.ExecuteSqlCommandAsync(sqlCommand, parameters);

            return await Database.ExecuteSqlCommandAsync(sqlCommand);
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
        public IQueryable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, IEnumerable<IDataParameter> parameters = null)
            where TEntity : class
        {
            return GetDbSet<TEntity>().FromSql(sqlQuery, parameters);
        }

        public async Task<IQueryable<TEntity>> ExecuteQueryAsync<TEntity>(
            string sqlQuery,
            IEnumerable<IDataParameter> parameters = null)
            where TEntity : class
        {
            return await Task.Run(() => GetDbSet<TEntity>().FromSql(sqlQuery, parameters));
        }

        /// <summary>
        ///     The first or default.
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
        public TEntity FirstOrDefault<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefault();
        }

        public TEntity FirstOrDefault<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, null, 0, 0, null, false, includes).FirstOrDefault();
        }

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
        public async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefaultAsync();
        }

        public async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, null, 0, 0, null, false, includes).FirstOrDefaultAsync();
        }

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
        public TEntity Get<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefault();
        }

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
        public IEnumerable<TEntity> GetAll<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, null, 0, 0, null, false, includes).ToList();
        }

        /// <summary>
        ///     The get all async.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="includes">
        ///     The includes.
        /// </param>
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, null, 0, 0, null, false, includes).ToListAsync();
        }

        /// <summary>
        ///     The get all paged.
        /// </summary>
        /// <param name="cache"></param>
        /// <param name="startPage">
        ///     The start page.
        /// </param>
        /// <param name="pageSize">
        ///     The page size.
        /// </param>
        /// <param name="orderBy">
        ///     The order by.
        /// </param>
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
        public IEnumerable<TEntity> GetAllPaged<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAsc = true,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, null, startPage, pageSize, orderBy, orderByAsc, includes).ToList();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAllPagedAsync<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAsc = true,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, null, startPage, pageSize, orderBy, orderByAsc, includes).ToListAsync();
        }

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
        public Task<TEntity> GetAsync<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefaultAsync();
        }


        //public abstract IQueryable<TEntity> GetQueryable<TEntity>(
        //    Expression<Func<TEntity, bool>> filter = null,
        //    int pageGo = 0,
        //    int pageSize = 0,
        //    IEnumerable<string> orderBy = null,
        //    bool orderAscendent = false,
        //    params Expression<Func<TEntity, object>>[] includes)
        //    where TEntity : class;


        /// <summary>
        ///     The get queryable.
        /// </summary>
        /// <param name="includes">
        ///     The includes.
        /// </param>
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
        /// <typeparam name="TEntity">
        ///     The Entity Type
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
        /// </returns>
        public virtual IQueryable<TEntity> GetQueryable<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter = null,
            int pageGo = 0,
            int pageSize = 0,
            IEnumerable<string> orderBy = null,
            bool orderAscendent = false,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            IQueryable<TEntity> items = null;

            if (includes != null && includes.Any())
            {
                var include = string.Empty;
                var first = true;

                foreach (var includeExpression in includes)
                {
                    //items.Include(includeExpression);
                    include = GetPath(includeExpression);
                    if (first)
                    {
                        items = Set<TEntity>().Include(include);
                        first = false;
                    }
                    else
                    {
                        items = items.Include(include);
                    }
                }
            }
            else
            {
                items = Set<TEntity>();
            }

            if (filter != null) items = items.Where(filter);

            if (pageSize > 0)
            {
                var orderByList = orderBy == null ? new List<string>() : orderBy.ToList();

                if (orderByList.Any())
                {
                    foreach (var i in orderByList.Where(o => !string.IsNullOrEmpty(o)))
                        items = QueryableUtils.CallOrderBy(items, i, orderAscendent);

                    items = items.Skip(pageSize * (pageGo - 1));
                }

                items = items.Take(pageSize);
            }

            if (cacheProvider != null && cache)
                return items.Cacheable();
            return items;
            //return this.cacheProvider != null ? items.Cacheable() : items;
        }

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
        public TResult Max<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return GetQueryable<TEntity>(cache).Max(filter);
        }

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
        public Task<TResult> MaxAsync<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return GetQueryable<TEntity>(cache).MaxAsync(filter);
        }

        public virtual TResult Min<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return GetQueryable<TEntity>(cache).Min(filter);
        }

        public virtual async Task<TResult> MinAsync<TEntity, TResult>(bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return await GetQueryable<TEntity>(cache).MinAsync(filter);
        }

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
        public bool Modify<TEntity>(TEntity item)
            where TEntity : class
        {
            SetEntryState(item, EntityState.Modified);
            GetDbSet<TEntity>().Update(item);
            return true;
        }

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
        public Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            return Task.Run(() => Modify(item));
        }

        public void NoTracking<TEntity>(TEntity item) where TEntity : class
        {
            SetEntryState(item, EntityState.Detached);
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
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
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
        public Task<bool> RemoveAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            return Task.Run(() => Remove(item));
        }

        /// <summary>
        ///     The remove range.
        /// </summary>
        /// <param name="items">
        ///     The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public bool RemoveRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            SetEntryState(items, EntityState.Deleted);
            GetDbSet<TEntity>().RemoveRange(items);
            return true;
        }

        /// <summary>
        ///     The remove range async.
        /// </summary>
        /// <param name="items">
        ///     The items.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            return Task.Run(() => RemoveRange(items));
        }

        /// <summary>
        ///     The roll back changes.
        /// </summary>
        public void Rollback()
        {
            Database.RollbackTransaction();

            // foreach (var entry in this.ChangeTracker.Entries()) entry.State = EntityState.Unchanged;
        }

        /// <summary>
        ///     The rollback async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task RollbackAsync()
        {
            await Task.Run(() => Rollback());
        }

        public bool Save()
        {
            return SaveChanges() > 0;
        }

        public async Task<bool> SaveAsync()
        {
            var result = await Task.Run(() => Save());
            return result;
        }

        public override int SaveChanges()
        {
            ChangeTracker.DetectChanges();
            var changedEntityNames = cacheProvider != null ? this.GetChangedEntityNames() : new string[0];

            var result = base.SaveChanges();

            cacheProvider?.InvalidateCacheDependencies(changedEntityNames);

            return result;
        }

        /// <summary>
        ///     The start transaction.
        /// </summary>
        public virtual void StartTransaction()
        {
            if (Database.CurrentTransaction == null) Database.BeginTransaction();
        }

        public virtual async Task StartTransactionAsync()
        {
            if (Database.CurrentTransaction == null) await Database.BeginTransactionAsync();
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
            // #if DEBUG
            Console.WriteLine(message);

            // #endif
        }

        /// <summary>
        ///     The setup context.
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
            return Set<TEntity>();
        }

        private void InitCacheProvider()
        {
            try
            {
                if (serviceProvider != null) cacheProvider = serviceProvider.GetService<IEFCacheServiceProvider>();
            }
            catch (Exception ex)
            {
                // Don't fall over when caching not set up
                Log("EFCore Caching not setup");
                Log(ex.GetBaseException().Message);
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
                if (entry.State == EntityState.Detached)
                    GetDbSet<TEntity>().Attach(item);

            if (entry.State != state) entry.State = state;
        }

        /// <summary>
        ///     The set entry state.
        /// </summary>
        /// <param name="items">
        ///     The items.
        /// </param>
        /// <param name="state">
        ///     The state.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        private void SetEntryState<TEntity>(IEnumerable<TEntity> items, EntityState state)
            where TEntity : class
        {
            foreach (var item in items) SetEntryState(item, state);
        }

        #endregion
    }
}