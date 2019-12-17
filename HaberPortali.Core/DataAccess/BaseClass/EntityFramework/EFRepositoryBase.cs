using HaberPortali.Core.DataAccess.IBaseRepository;
using HaberPortali.Core.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace HaberPortali.Core.DataAccess.BaseClass.EntityFramework
{
    public class EFRepositoryBase<TEntity, TKey, TContext> : IRepository<TEntity, TKey>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TContext _context;
        public DbSet<TEntity> _dbset;

        public EFRepositoryBase(DbContext context)
        {
            _context = (TContext)context;
            _dbset = _context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbset.Add(entity);
            Save();
        }

        public int Delete(TEntity entity)
        {
            _dbset.Remove(entity);
            return Save();
        }

        public int DeleteById(TKey id)
        {
            TEntity entity = GetById(id);
            return Delete(entity);
        }

        public int DeleteExp(Expression<Func<TEntity, bool>> exp)
        {
            List<TEntity> silinecekler = _dbset.Where(exp).ToList();
            _dbset.RemoveRange(silinecekler);
            return Save();
        }

        public List<TEntity> Get(Expression<Func<TEntity, bool>> exp = null)
        {
            if (exp == null)
                return _dbset.ToList();
            else
                return _dbset.Where(exp).ToList();
        }

        public TEntity GetById(TKey id)
        {
            return _dbset.Find(id);
        }

        public int Save()
        {
            try
            {
                return _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return Save();
        }
    }
}
