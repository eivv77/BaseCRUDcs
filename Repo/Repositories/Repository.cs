using DataAccess;
using Microsoft.EntityFrameworkCore;
using Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Repositories
{
    public abstract class Repository : IRepository
    {
        protected readonly AppDbContext dbContext;

        protected Repository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
    }

    public class Repository<TEntity> : Repository, IRepository<TEntity> where TEntity : class
    {
        protected readonly DbSet<TEntity> dbSet;

        public Repository(AppDbContext dbContext) : base(dbContext)
        {
            dbSet = dbContext.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return dbSet;
        }
        public virtual TEntity GetOne(int id)
        {
            return dbSet.Find(id);
        }
        public virtual void Create(TEntity entity)
        {
            dbSet.Add(entity);
            dbContext.SaveChanges();
        }
        public virtual void Update(TEntity entity)
        {
            dbSet.Update(entity);
            dbContext.SaveChanges();
        }
        public virtual void Delete(int id)
        {
            var entity = GetOne(id);
            dbSet.Remove(entity);
            dbContext.SaveChanges();
        }
    }
}
