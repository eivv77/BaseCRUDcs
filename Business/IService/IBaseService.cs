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
    public interface IBaseService<TRqDTO, TEntity,TRsDTO> : IBaseService
    {
        
        public IEnumerable<TRsDTO> GetAll();

        public TRsDTO GetOne(int id);

        public void Post(TRqDTO menuwka);

        public void Put(TRqDTO request);

        public void Delete(int id);
    }
}
