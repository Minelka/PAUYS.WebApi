using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Repositories.Abstract
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        void Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        int Delete(int id);
        void Remove(TEntity entity);
        void Remove(int id);

        TEntity? Get(int id);
        ICollection<TEntity> GetAll();
        //ICollection<TEntity> GetAll<TProperty>(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includes);
        ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, params string[] includeStringPath);
    }
}
