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

        public IEnumerable<TModel> Post(TModel menuwka);

        public TModel Put(int id, TModel request);

        public TModel Delete(int id);
    }
}
