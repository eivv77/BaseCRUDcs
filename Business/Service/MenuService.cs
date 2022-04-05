using Business.IService;
using Business.Models;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class MenuService : BaseService<Menu>, IMenuService
    {
        public MenuService() : base()
        {

        }

        public override IEnumerable<Menu> Post(Menu menuwka)
        {
            if (!menu.Exists(f => f.Id == menuwka.Id))
            {
                menu.Add(menuwka);
                return menu;
            }

            return null;
        }
        public override Menu GetOne(int id)
        {
            var menuwka = menu.Find(f => f.Id == id);
            if (menuwka == null)
            {
                return null;
            }

            return menuwka;
        }
        public override Menu Put(int id, Menu request)
        {
            var menuwka = menu.Find(f => f.Id == id);
            if (menuwka == null)
            {
                return null;
            }

            request.Name = menuwka.Name;
            request.Price = menuwka.Price;
                
            return menuwka;
        }
        public override Menu Delete(int id)
        {
            var menuwka = menu.Find(f => f.Id == id);
            if (menuwka == null)
            {
                return null;
            }

            menu.Remove(menuwka);

            return menuwka;
        }
    }
}
