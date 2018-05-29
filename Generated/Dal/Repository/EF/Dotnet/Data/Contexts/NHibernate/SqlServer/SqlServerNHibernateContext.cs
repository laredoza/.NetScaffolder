using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Context.NHibernate
{
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;

    using global::NHibernate;
    using global::NHibernate.Context;
    using global::NHibernate.Linq;

    using RepositoryEFDotnet.Core.Base;
    using RepositoryEFDotnet.Core.Utils;

    public class SqlServerNHibernateContext : IUnitOfWork
    {
        private readonly ISessionFactory _sessionFactory;
        private ITransaction _transaction;

        private ISession CurrentSession;

        public SqlServerNHibernateContext(ISessionFactory sessionFactory)
        {
            _sessionFactory = sessionFactory;
            CurrentSession = _sessionFactory.OpenSession();
            //CurrentSessionContext.Bind(CurrentSession);
            _transaction = CurrentSession.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }
        public SqlServerNHibernateContext(ISessionFactory sessionFactory, ISession session)
        {
            _sessionFactory = sessionFactory;
            if (session == null)
            {
                CurrentSession = _sessionFactory.OpenSession();
                //CurrentSessionContext.Bind(CurrentSession);
                _transaction = CurrentSession.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
            }
            else //more for Unit Testing
            {
                CurrentSession = session;
                //CurrentSessionContext.Bind(CurrentSession);
                _transaction = CurrentSession.Transaction;
            }
        }

        public SqlServerNHibernateContext(ISession session)
        {
            _sessionFactory = null;

            CurrentSession = session;
            //CurrentSessionContext.Bind(CurrentSession);

            this._transaction = !this.CurrentSession.Transaction.IsActive ? this.CurrentSession.BeginTransaction(System.Data.IsolationLevel.ReadCommitted) : 
                                    this.CurrentSession.Transaction;
        }

        private void closeTransaction()
        {
            if (_transaction != null)
            {
                _transaction.Dispose();
                _transaction = null;
            }
        }

        private void closeSession()
        {
            if (CurrentSession != null && CurrentSession.IsOpen)
                CurrentSession.Close();
            CurrentSession.Dispose();
            CurrentSession = null;
        }

        public void Dispose()
        {
            if (CurrentSession != null)
            {
                if (_transaction.IsActive) // wasn't committed, so must rollback
                    _transaction.Rollback();
                //CurrentSessionContext.Unbind(_sessionFactory);
                closeTransaction();
                closeSession();
            }
        }

        public bool Add<TEntity>(TEntity item)
            where TEntity : class
        {
            this.CurrentSession.Persist(item);
            return true;
        }

        public Task<bool> AddAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            throw new NotImplementedException();
            
        }

        public bool AddRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            foreach (var ent in items)
            {
                this.Add(ent);
            }

            return true;
        }

        public Task<bool> AddRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> AllMatching<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null, string hint = "")
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).ToList();
        }

        public async Task<IEnumerable<TEntity>> AllMatchingAsync<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null, string hint = "")
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).ToListAsync();
        }

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

        public bool Any<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).Any();
        }

        public async Task<bool> AnyAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).AnyAsync();
        }

        public void ApplyCurrentValues<TEntity>(TEntity original, TEntity current)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            if (_transaction.IsActive)
                _transaction.Commit();
            return 1;
        }

        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }

        public int ExecuteCommand(string sqlCommand, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public Task<int> ExecuteCommandAsync(string sqlCommand, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> ExecuteQuery<TEntity>(string sqlQuery, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).FirstOrDefault();
        }

        public async Task<TEntity> FirstOrDefaultAsync<TEntity>(Expression<Func<TEntity, bool>> filter = null, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).FirstOrDefaultAsync();
        }

        public TEntity Get<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable(includes, filter).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class
        {
            return this.GetQueryable<TEntity>(includes).ToList();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync<TEntity>(IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable<TEntity>(includes).ToListAsync();
        }

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

        public async Task<TEntity> GetAsync<TEntity>(Expression<Func<TEntity, bool>> filter, IEnumerable<string> includes = null)
            where TEntity : class
        {
            return await this.GetQueryable(includes, filter).FirstOrDefaultAsync();
        }

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

            //if (includes != null && includes.Any())
            //    foreach (var i in includes.Where(o => o != null))
            //        items = items.Include(i);

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

        public TResult Max<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            return this.GetQueryable<TEntity>(null, null).Max(filter);
        }

        public Task<TResult> MaxAsync<TEntity, TResult>(Expression<Func<TEntity, TResult>> filter)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        public bool Modify<TEntity>(TEntity item)
            where TEntity : class
        {
            this.CurrentSession.Update(item);
            return true;
        }

        public async Task<bool> ModifyAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await this.CurrentSession.UpdateAsync(item);
            return true;
        }

        public bool Remove<TEntity>(TEntity item)
            where TEntity : class
        {
            this.CurrentSession.Delete(item);
            return true;
        }

        public async Task<bool> RemoveAsync<TEntity>(TEntity item)
            where TEntity : class
        {
            await this.CurrentSession.DeleteAsync(item);
            return true;
        }

        public bool RemoveRange<TEntity>(IEnumerable<TEntity> items)
            where TEntity : class
        {
            foreach (var item in items)
            {
                Remove(item);
            }

            return true;
        }

        public Task<bool> RemoveRangeAsync<TEntity>(IEnumerable<TEntity> item)
            where TEntity : class
        {
            throw new NotImplementedException();
        }

        public void Rollback()
        {
            if (this._transaction != null && _transaction.IsActive)
                _transaction?.Rollback();
        }

        public Task RollbackAsync()
        {
            throw new NotImplementedException();
        }

        public void StartTransaction()
        {
            if (this.CurrentSession == null || (this._transaction != null && this._transaction.IsActive)) return;
            _transaction = CurrentSession.BeginTransaction(System.Data.IsolationLevel.ReadCommitted);
        }
    }
}
