using Business.IService;
using Business.Models;
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
        public virtual IEnumerable<TModel> Post(TModel menuwka)
        {
            menu.Add(menuwka);
            return menu;
        }
        public virtual TModel Put(int id, TModel request)
        {
            return menu[id];
        }
        public virtual TModel Delete(int id)
        {
            return menu[id];
        }
    }
}
