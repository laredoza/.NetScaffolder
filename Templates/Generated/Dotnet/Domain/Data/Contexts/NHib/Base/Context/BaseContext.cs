// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BaseContext.cs" company="DotnetScaffolder">
//   MIT
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DotNetScaffolder.Domain.Core.Interfaces;
using DotNetScaffolder.Domain.Core.Utils;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using FluentNHibernate.Conventions.Helpers;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Linq;
using NHibernate.Tool.hbm2ddl;
using RepositoryEFDotnet.Contexts.NHib.Base;

namespace DotNetScaffolder.Domain.Data.Contexts.NHib.Base.Context
{
    public abstract class BaseContext : INHibUnitOfWork
    {
        #region Fields

        /// <summary>
        ///     The close factory.
        /// </summary>
        private bool closeFactory = true;

        /// <summary>
        ///     The current session.
        /// </summary>
        private ISession currentSession;

        /// <summary>
        ///     The session factory.
        /// </summary>
        private ISessionFactory sessionFactory;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        protected BaseContext()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="config">
        ///     The config.
        /// </param>
        protected BaseContext(FluentConfiguration config)
        {
            closeFactory = true;

            Configuration = config.Mappings(SetupConventions).Mappings(ConfigureMappings)
                .BuildConfiguration();

            SetConfig();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="config">
        ///     The config.
        /// </param>
        protected BaseContext(Configuration config)
        {
            closeFactory = true;
            Configuration = config;
            SetConfig();
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="factory">
        ///     The factory.
        /// </param>
        protected BaseContext(ISessionFactory factory)
        {
            closeFactory = false;
            sessionFactory = factory;
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="BaseContext" /> class.
        /// </summary>
        /// <param name="config">
        ///     The config.
        /// </param>
        protected BaseContext(IPersistenceConfigurer config)
        {
            Configuration = Fluently.Configure().Database(config).Mappings(SetupConventions)
                .Mappings(ConfigureMappings).BuildConfiguration();

            SetConfig();
        }

        #endregion

        #region Public Properties

        /// <summary>
        ///     Gets the configuration.
        /// </summary>
        public Configuration Configuration { get; }

        #endregion

        #region Other Properties

        /// <summary>
        ///     The current session.
        /// </summary>
        private ISession CurrentSession
        {
            get
            {
                CreateSession();
                return currentSession;
            }
        }

        /// <summary>
        ///     Gets the session factory.
        /// </summary>
        private ISessionFactory SessionFactory
        {
            get
            {
                CreateSessionFactory();
                return sessionFactory;
            }
        }

        #endregion

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
        public virtual bool Add<TEntity>(TEntity item)
            where TEntity : class
        {
            CurrentSession.Persist(item);
            return true;
        }

        /// <summary>
        ///     The add async.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public async Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await CurrentSession.PersistAsync(item);
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
        public virtual bool AddRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            foreach (var ent in items) Add(ent);

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual async Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            return await Task.Run(() => AddRange(items));
        }

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
        public virtual IEnumerable<TEntity> AllMatching<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).ToList();
        }

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
        public virtual async Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).ToListAsync();
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual IEnumerable<TEntity> AllMatchingPaged<TEntity>(
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
        ///     The any.
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
        ///     The <see cref="bool" />.
        /// </returns>
        public virtual bool Any<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).Any();
        }

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
        public virtual bool Any<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, null, 0, 0, null, false, includes).Any();
        }

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
        public virtual async Task<bool> AnyAsync<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).AnyAsync();
        }

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
        public virtual async Task<bool> AnyAsync<TEntity>(
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
        /// </typeparam>
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            throw new NotImplementedException("NHibernate.BaseContext.ApplyCurrentValues()");
        }

        public void BulkDelete<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            foreach (var entity in items)
            {
                this.Remove(entity);
            }
        }

        public async Task BulkDeleteAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            foreach (var entity in items)
            {
                await this.RemoveAsync(entity);
            }
        }

        public void BulkInsert<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            foreach (var entity in items)
            {
                 this.Add(entity);
            }
        }

        public async Task BulkInsertAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            foreach (var entity in items)
            {
                await this.AddAsync(entity);
            }
        }

        public void BulkUpdate<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            foreach (var entity in items)
            {
                this.Modify(entity);
            }
        }

        public async Task BulkUpdateAsync<TEntity>(IEnumerable<TEntity> items) where TEntity : class
        {
            foreach (var entity in items)
            {
                await this.ModifyAsync(entity);
            }
        }

        /// <summary>
        ///     The commit.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public virtual int Commit()
        {
            if (currentSession?.Transaction != null && currentSession.Transaction.IsActive)
            {
                CurrentSession?.Transaction.Commit();
                CloseTransaction();
            }
            else
            {
                CurrentSession.Flush();
            }

            return 1;
        }

        /// <summary>
        ///     The commit async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public virtual async Task<int> CommitAsync()
        {
            if (CurrentSession?.Transaction != null && CurrentSession.Transaction.IsActive)
            {
                await CurrentSession?.Transaction.CommitAsync();
                CloseTransaction();
            }
            else
            {
                await CurrentSession?.FlushAsync();
            }

            return 1;
        }

        public virtual ICriteria CreateCriteria<TEntity>()
            where TEntity : class
        {
            return CurrentSession.CreateCriteria(typeof(TEntity));
        }

        public virtual ICriteria CreateCriteria(string entityName)
        {
            return CurrentSession.CreateCriteria(entityName);
        }

        /// <summary>
        ///     The create database.
        /// </summary>
        public void CreateSchema()
        {
            if (Configuration == null) return;

            var export = new SchemaExport(Configuration);

#if DEBUG
            CreateLogDir();

            using (var file = new FileStream(
                @"C:\TestOutput\NHibernate\CreateSchema.sql",
                FileMode.Create,
                FileAccess.Write))
            {
                using (var sw = new StreamWriter(file))
                {
                    export.Execute(true, true, false, CurrentSession?.Connection, sw);
                }
            }

#else
            export.Execute(true, true, false, this.CurrentSession?.Connection, null);
#endif
        }

        /// <summary>
        ///     The dispose.
        /// </summary>
        public virtual void Dispose()
        {
            if (CurrentSession != null)
            {
                if (CurrentSession.Transaction != null && CurrentSession.Transaction.IsActive)
                    CurrentSession.Transaction.Rollback();

                // CurrentSessionContext.Unbind(_sessionFactory);
                CloseTransaction();
                CloseSession();
            }

            CloseSessionFactory();
        }

        /// <summary>
        ///     The drop database.
        /// </summary>
        public void DropSchema()
        {
            if (Configuration == null) return;

            var export = new SchemaExport(Configuration);
            export.Execute(true, true, true, CurrentSession?.Connection, null);
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
        public virtual int ExecuteCommand(string sqlCommand, IEnumerable<IDataParameter> parameters = null)
        {
            return CreateQuery(sqlCommand, parameters).UniqueResult<int>();
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
        public virtual async Task<int> ExecuteCommandAsync(
            string sqlCommand,
            IEnumerable<IDataParameter> parameters = null)
        {
            return await CreateQuery(sqlCommand, parameters).UniqueResultAsync<int>();
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
        /// </typeparam>
        /// <returns>
        ///     The <see cref="IQueryable" />.
        /// </returns>
        public virtual IQueryable<TEntity> ExecuteQuery<TEntity>(
            string sqlQuery,
            IEnumerable<IDataParameter> parameters = null)
            where TEntity : class
        {
            var query = CreateQuery(sqlQuery, parameters);
            query.AddEntity(typeof(TEntity));
            return query.Enumerable<TEntity>().AsQueryable();
        }

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
        public virtual async Task<IQueryable<TEntity>> ExecuteQueryAsync<TEntity>(
            string sqlQuery,
            IEnumerable<IDataParameter> parameters = null)
            where TEntity : class
        {
            var query = CreateQuery(sqlQuery, parameters).AddEntity(typeof(TEntity));
            var result = await query.EnumerableAsync<TEntity>();
            return result.AsQueryable();
        }

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
        public virtual TEntity FirstOrDefault<TEntity>(
            Expression<Func<TEntity, bool>> filter,
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefault();
        }

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
        public virtual TEntity FirstOrDefault<TEntity>(
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
        public virtual async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefaultAsync();
        }

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
        public virtual async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await FirstOrDefaultAsync(cache, null, includes);
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
        public virtual TEntity Get<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefault();
        }

        public virtual TEntity Get<TEntity, IDType>(IDType id)
        {
            //Todo: Caching
            return CurrentSession.Get<TEntity>(id);
        }

        public TEntity Get<TEntity>(object id)
        {
            return CurrentSession.Get<TEntity>(id);
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
        public virtual IEnumerable<TEntity> GetAll<TEntity>(
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
        /// </typeparam>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public virtual async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(
            bool cache,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, null, 0, 0, null, false, includes).ToListAsync();
        }

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual IEnumerable<TEntity> GetAllPaged<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAscending = true,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return GetQueryable(cache, null, startPage, pageSize, orderBy, orderByAscending, includes).ToList();
        }

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
        public virtual async Task<IEnumerable<TEntity>> GetAllPagedAsync<TEntity>(
            int startPage,
            int pageSize,
            IEnumerable<string> orderBy,
            bool cache,
            bool orderByAscending = true,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, null, startPage, pageSize, orderBy, orderByAscending, includes)
                .ToListAsync();
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
        public virtual async Task<TEntity> GetAsync<TEntity>(
            bool cache,
            Expression<Func<TEntity, bool>> filter,
            params Expression<Func<TEntity, object>>[] includes)
            where TEntity : class
        {
            return await GetQueryable(cache, filter, 0, 0, null, false, includes).FirstOrDefaultAsync();
        }

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
            var query = CurrentSession.Query<TEntity>();

            if (includes != null && includes.Any())
                foreach (var includeExpr in includes)
                    query = query.Fetch(includeExpr);

            if (filter != null) query = query.Where(filter);

            if (pageSize > 0)
            {
                if (orderBy != null)
                {
                    var orderBylist = orderBy.ToList();

                    foreach (var i in orderBylist.Where(o => !string.IsNullOrEmpty(o)))
                        query = QueryableUtils.CallOrderBy(query, i, orderAscendent);

                    query = query.Skip(pageSize * (pageGo - 1));
                }

                query = query.Take(pageSize);
            }

            if (cache)
            {
                return query.WithOptions(o => o.SetCacheable(true));
            }
            else
            {
                return query;
            }
            
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
        public virtual TResult Max<TEntity, TResult>(
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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual async Task<TResult> MaxAsync<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return await GetQueryable<TEntity>(cache).MaxAsync(filter);
        }

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
        public virtual TResult Min<TEntity, TResult>(
            bool cache,
            Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return GetQueryable<TEntity>(cache).Min(filter);
        }

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
        public virtual async Task<TResult> MinAsync<TEntity, TResult>(
            bool cache,
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
        public virtual bool Modify<TEntity>(TEntity item)
            where TEntity : class
        {
            CurrentSession.Update(item);
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
        public virtual async Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await CurrentSession.UpdateAsync(item);
            return true;
        }

        public void NoTracking<TEntity>(TEntity item) where TEntity : class
        {
            throw new NotImplementedException();
        }

        public virtual IQueryOver<TEntity, TEntity> QueryOver<TEntity>()
            where TEntity : class
        {
            return CurrentSession.QueryOver<TEntity>();
        }

        public virtual IQueryOver<TEntity> QueryOver<TEntity>(string entityName, Expression<Func<TEntity>> expr)
            where TEntity : class
        {
            return CurrentSession.QueryOver(entityName, expr);
        }

        /// <summary>
        ///     The remove.
        /// </summary>
        /// <param name="item">
        ///     The item.
        /// </param>
        /// <typeparam name="TEntity">
        /// </typeparam>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public virtual bool Remove<TEntity>(TEntity item)
            where TEntity : class
        {
            CurrentSession.Delete(item);
            return true;
        }

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
        public virtual async Task<bool> RemoveAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await CurrentSession.DeleteAsync(item);
            return true;
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
        public virtual bool RemoveRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            foreach (var item in items) Remove(item);

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
        /// <exception cref="NotImplementedException">
        /// </exception>
        public virtual async Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            return await Task.Run(() => RemoveRange(items));
        }

        /// <summary>
        ///     The rollback.
        /// </summary>
        public virtual void Rollback()
        {
            if (CurrentSession?.Transaction != null && CurrentSession.Transaction.IsActive)
                CurrentSession?.Transaction.Rollback();

            CloseTransaction();
            CloseSession();
            CloseSessionFactory();
        }

        /// <summary>
        ///     The rollback async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public virtual async Task RollbackAsync()
        {
            if (CurrentSession?.Transaction != null && CurrentSession.Transaction.IsActive)
                await CurrentSession?.Transaction.RollbackAsync();

            CloseTransaction();
            CloseSession();
            CloseSessionFactory();
        }

        /// <summary>
        ///     The save.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public bool Save()
        {
            return false;
        }

        /// <summary>
        ///     The save async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public async Task<bool> SaveAsync()
        {
            return false;
        }

        /// <summary>
        ///     The start transaction.
        /// </summary>
        public virtual void StartTransaction()
        {
            if (CurrentSession?.Transaction != null && CurrentSession.Transaction.IsActive) return;

            CurrentSession?.Transaction?.Begin(IsolationLevel.ReadCommitted);
        }

        /// <summary>
        ///     The start transaction async.
        /// </summary>
        /// <returns>
        ///     The <see cref="Task" />.
        /// </returns>
        public virtual async Task StartTransactionAsync()
        {
            if (CurrentSession.Transaction != null && CurrentSession.Transaction.IsActive) return;

            await Task.Run(() => CurrentSession.BeginTransaction(IsolationLevel.ReadCommitted));
        }

        #endregion

        #region Other Methods

        /// <summary>
        ///     The configure mappings.
        /// </summary>
        /// <param name="config">
        ///     The config.
        /// </param>
        protected abstract void ConfigureMappings(MappingConfiguration config);

        /// <summary>
        ///     The set config.
        /// </summary>
        /// <param name="config">
        ///     The config.
        /// </param>
        protected void SetConfig()
        {
            if (Configuration == null) throw new Exception("Configuration cannot be null");

            Configuration.SetInterceptor(new AuditInterceptor());

            SchemaMetadataUpdater.QuoteTableAndColumns(
                Configuration,
                Dialect.GetDialect(Configuration.Properties));
        }

        /// <summary>
        ///     The setup conventions.
        /// </summary>
        /// <param name="config">
        ///     The config.
        /// </param>
        /// <exception cref="Exception">
        /// </exception>
        protected virtual void SetupConventions(MappingConfiguration config)
        {
            config.FluentMappings.Conventions.Add(
                ConventionBuilder.Class.Always(
                    z =>
                    {
                        z.BatchSize(512);
                        z.Cache.ReadWrite();
                    }),
                ConventionBuilder.HasMany.Always(
                    z =>
                    {
                        try
                        {
                            // IColumnInspector othercol = z.OtherSide?.Columns.FirstOrDefault();

                            // if (othercol != null)
                            // {
                            // z.Key.Column(othercol.Name);
                            // }
                            z.Inverse();
                            z.LazyLoad();
                            z.Cascade.AllDeleteOrphan();
                            z.BatchSize(512);
                        }
                        catch (Exception ex)
                        {
                            throw new Exception("Error mapping " + z, ex);
                        }
                    }),
                ConventionBuilder.Property.When(
                    z => z.Expect(p => p.Property.PropertyType.IsEnum),
                    z => z.CustomType(z.Property.PropertyType))).AddFromAssemblyOf<IAuditable>();
        }

        /// <summary>
        ///     The close session.
        /// </summary>
        private void CloseSession()
        {
            if (currentSession != null && currentSession.IsOpen) currentSession.Close();

            currentSession?.Dispose();
            currentSession = null;
        }

        /// <summary>
        ///     The close session factory.
        /// </summary>
        private void CloseSessionFactory()
        {
            if (!closeFactory) return;

            if (sessionFactory != null)
            {
                if (!sessionFactory.IsClosed) sessionFactory.Close();

                sessionFactory.Dispose();
            }

            sessionFactory = null;
            closeFactory = true;
        }

        /// <summary>
        ///     The close transaction.
        /// </summary>
        private void CloseTransaction()
        {
            currentSession?.Transaction?.Dispose();

            if (currentSession != null && currentSession.IsConnected) currentSession?.Disconnect();
        }

#if DEBUG

        // <summary>
        /// The create log dir.
        /// </summary>
        private void CreateLogDir()
        {
            if (!Directory.Exists(@"C:\TestOutput\NHibernate\"))
                Directory.CreateDirectory(@"C:\TestOutput\NHibernate\");
        }

#endif

        /// <summary>
        ///     The create query.
        /// </summary>
        /// <param name="sqlCommand">
        ///     The sql command.
        /// </param>
        /// <param name="parameters">
        ///     The parameters.
        /// </param>
        /// <returns>
        ///     The <see cref="ISQLQuery" />.
        /// </returns>
        private ISQLQuery CreateQuery(string sqlCommand, IEnumerable<IDataParameter> parameters = null)
        {
            var query = CurrentSession.CreateSQLQuery(sqlCommand);

            if (parameters != null)
                foreach (var param in parameters)
                    query.SetParameter(param.ParameterName, param.Value);

            return query;
        }

        /// <summary>
        ///     The create session.
        /// </summary>
        /// <exception cref="Exception">
        /// </exception>
        private void CreateSession()
        {
            CreateSessionFactory();

            if (currentSession == null || !currentSession.IsOpen) currentSession = SessionFactory?.OpenSession();

            if (currentSession != null && !currentSession.IsConnected) currentSession.Reconnect();
        }

        /// <summary>
        ///     The create session factory.
        /// </summary>
        /// <exception cref="Exception">
        /// </exception>
        private void CreateSessionFactory()
        {
            if (sessionFactory == null || sessionFactory.IsClosed)
            {
                if (Configuration == null) throw new Exception("Configuration cannot be null");

                sessionFactory = Configuration.BuildSessionFactory();
            }
        }

        #endregion
    }
}