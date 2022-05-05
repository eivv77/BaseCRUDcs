using AutoMapper;
using Business.IService;
using DataAccess.Entities;
using Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Service
{
    public class BaseService : IBaseService
    {

    }
    public class BaseService<TRqDTO, TEntity, TRsDTO> : BaseService, IBaseService<TRqDTO, TEntity, TRsDTO>
    {
        protected readonly IRepository<TEntity> repository;
        protected readonly IMapper mapper; 

        public BaseService(IRepository<TEntity> repository, IMapper mapper)
        {
            this.repository = repository;
            this.mapper = mapper;
        }

        public virtual IEnumerable<TRsDTO> GetAll()
        {
            var entity = repository.GetAll();
            var result = mapper.Map<IEnumerable<TRsDTO>>(entity);

            return result;
        }
        public virtual TRsDTO GetOne(int id)
        {
            var entity = repository.GetOne(id);
            var result = mapper.Map<TRsDTO>(entity);  

            return result;
        }
        public virtual void Post(TRqDTO menuwka)
        {
            var entity = mapper.Map<TEntity>(menuwka);
            repository.Create(entity);
        }
        public virtual void Put(TRqDTO menuwka)
        {
            var entity = mapper.Map<TEntity>(menuwka);
            repository.Update(entity);
        }
        public virtual void Delete(int id)
        {
            repository.Delete(id);
        }
    }
}
