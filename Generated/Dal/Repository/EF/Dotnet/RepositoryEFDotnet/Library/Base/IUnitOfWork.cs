using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryEFDotnet.Library
{
    public interface IUnitOfWork
    {
        IList<TEntity> LoadAll<TEntity>() where TEntity : class;
        IList<TEntity> AllMatching<TEntity>(Expression<Func<TEntity, bool>> exp) where TEntity : class;
        TEntity FirstOrDefault<TEntity>(Expression<Func<TEntity, bool>> exp) where TEntity : class;
        bool Add<TEntity>(TEntity newEntity);
        bool Modify<TEntity>(TEntity newEntity);
        bool Remove<TEntity>(TEntity newEntity);
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
