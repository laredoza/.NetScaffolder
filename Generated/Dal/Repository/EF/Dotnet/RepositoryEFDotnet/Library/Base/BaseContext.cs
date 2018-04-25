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
        public bool Add<TEntity>(TEntity newEntity)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> AllMatching<TEntity>(Expression<Func<TEntity, bool>> exp) where TEntity : class
        {
            return null;
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
            throw new NotImplementedException();
        }

        public bool Remove<TEntity>(TEntity newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
