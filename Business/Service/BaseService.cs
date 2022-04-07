using Business.IService;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Service
{
    public class BaseService
    {

    }
    public class BaseService<TModel> : BaseService
    {
        protected List<TModel> menu;

        public BaseService()
        {
            menu = new List<TModel>();
        }

        public virtual IEnumerable<TModel> Get()
        {
            return menu;
        }
        public virtual TModel GetOne(int id)
        {
            return menu[id];
        }
        public virtual void Post(TModel menuwka)
        {
            menu.Add(menuwka);
        }
        public virtual void Put(int id, TModel request)
        {
            //menu[id];
        }
        public virtual void Delete(int id)
        {
           //menu[id];
        }
    }
}
