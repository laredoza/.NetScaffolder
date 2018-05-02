using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.Library
{
    public abstract class BaseContext : DbContext, IUnitOfWork
    {
        protected BaseContext(string connectionName) : base(connectionName) { }
        protected BaseContext() : base() { }

        public bool Add<TEntity>(TEntity newEntity)
        {
            return false;
        }

        public IList<TEntity> AllMatching<TEntity>(Expression<Func<TEntity, bool>> exp) where TEntity : class
        {
            return null;
        }

        public void BeginTransaction()
        {
            
        }

        public void Commit()
        {
            
        }

        public TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> exp) where TEntity : class
        {
            return null;
        }

        public IList<TEntity> LoadAll<TEntity>() where TEntity : class
        {
            return null;
        }

        public bool Modify<TEntity>(TEntity newEntity)
        {
            return false;
        }

        public bool Remove<TEntity>(TEntity newEntity)
        {
            return false;
        }

        public void Rollback()
        {
            
        }

        #region Logging

        protected virtual void Log(string log)
        {

        }

        #endregion
    }
}
