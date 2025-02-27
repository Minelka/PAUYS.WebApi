using Microsoft.EntityFrameworkCore;
using PAUYS.Common.Exceptions;
using PAUYS.DAL.Context;
using PAUYS.Entity.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PAUYS.DAL.Repositories.Abstract
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private protected PAUYSDbContext _dbContext;
        private protected DbSet<TEntity> _entities;

        protected Repository(PAUYSDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _entities.Add(entity);
        }

        public int Update(TEntity entity)
        {
            if (!entity.IsDeleted)
                entity.Updated = DateTime.Now;

            _entities.Update(entity);

            return entity.Id;
        }

        public int Delete(TEntity entity)
        {
            entity.IsDeleted = true;
            entity.Deleted = DateTime.Now;
            return Update(entity);
        }

        public int Delete(int id)
        {
            TEntity? entity = _entities.Where(s => s.Id == id).ToList().SingleOrDefault();

            if (entity is not null)
            {
                entity.IsDeleted = true;
                entity.Deleted = DateTime.Now;
                return Update(entity);
            }

            throw new EntityNotFound($"No record with Id:{id} found in the {_entities.GetType().Name} table.");
        }

        public void Remove(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public void Remove(int id)
        {
            TEntity? entity = _entities.Where(s => s.Id == id).ToList().SingleOrDefault();

            if (entity is not null)
                _entities.Remove(entity);

            throw new EntityNotFound($"No record with Id:{id} found in the {_entities.GetType().Name} table.");
        }

        public TEntity? Get(int id)
        {
            //TEntity entity = _entities.Find(id);
            //if(entity is not null)
            //{
            //    _dbContext.Entry(entity).State = EntityState.Detached;
            //    return entity;
            //}

            TEntity? entity = _entities.AsNoTracking().Where(e => e.Id == id && e.IsDeleted == false).FirstOrDefault();

            if (entity is not null)
                return entity;


            return null;
        }

        public ICollection<TEntity> GetAll()
        {
            return _entities.AsNoTracking().ToList();
        }

        //public ICollection<TEntity> GetAll<TProperty>(Expression<Func<TEntity, bool>> predicate = null, params Expression<Func<TEntity, object>>[] includes)
        //{
        //    IQueryable<TEntity> query = _entities.AsNoTracking();
        //    if (includes is not null)
        //        foreach (var include in includes)
        //            query = query.Include(include);
        //    if(predicate is not null)
        //        query = query.Where(predicate);
        //    return query.ToList();
        //}

        public ICollection<TEntity> GetAll(Expression<Func<TEntity, bool>> predicate = null, params string[] includeStringPath)
        {
            //IQueryable<TEntity> query = _entities.AsNoTracking();
            IQueryable<TEntity> query = _entities;


            if (includeStringPath is not null)
                foreach (var include in includeStringPath)
                    query = query.Include(include);

            if (predicate is not null)
                query = query.Where(predicate);

            return query.ToList();
        }
    }
}
