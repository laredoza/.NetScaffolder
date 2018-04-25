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
        public virtual IList<TEntity> AllMatching<TEntity, TType>(Expression<Func<TEntity, TType>> exp) where TEntity : class
        {
            return null;
        }

        public virtual TEntity FirstOrDefault<TEntity, TType>(Expression<Func<TEntity, TType>> exp) where TEntity : class
        {
            return null;
        }

        public virtual IList<TEntity> LoadAll<TEntity>() where TEntity : class
        {
            return null;
        }
    }
}
