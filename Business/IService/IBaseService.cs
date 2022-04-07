using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IService
{
    public interface IBaseService
    {

    }
    public interface IBaseService<TModel> : IBaseService
    {
        
        public IEnumerable<TModel> Get();

        public TModel GetOne(int id);

        public void Post(TModel menuwka);

        public void Put(int id, TModel request);

        public void Delete(int id);
    }
}
