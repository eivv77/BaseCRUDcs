using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.IRepositories
{
    public interface IRepository
    {

    }

    public interface IRepository<TEntity> : IRepository
    {
        public IEnumerable<TEntity> GetAll();
        public TEntity GetOne(int id);
        public void Create(TEntity entity);
        public void Update(TEntity entity);
        public void Delete(int id);
    }
}
