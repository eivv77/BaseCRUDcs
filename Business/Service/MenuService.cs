using Business.IService;
using Business.Services;
using DataAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class MenuService : BaseService<Menu>, IMenuService
    {

        private readonly AppDbContext appDb;

        public MenuService(AppDbContext appDb)
        {
            this.appDb = appDb;
        }

        public override IEnumerable<Menu> Get()
        {
            return appDb.MENU;
        }

        public override void Post(Menu menuwka)
        {
            /*if (!menu.Exists(f => f.Id == menuwka.Id))
            {
                menu.Add(menuwka);
                return menu;
            }

            return null;*/

            appDb.MENU.Add(menuwka);
            appDb.SaveChanges();


        }
        public override Menu GetOne(int id)
        {
            /*var menuwka = menu.Find(f => f.Id == id);
            if (menuwka == null)
            {
                return null;
            }

            return menuwka;*/

            return appDb.MENU.Find(id);
            appDb.SaveChanges();
        }
        public override void Put(int id, Menu request)
        {
            /*var menuwka = menu.Find(f => f.Id == id);
            if (menuwka == null)
            {
                return null;
            }

            request.Name = menuwka.Name;
            request.Price = menuwka.Price;
                
            return menuwka;*/

            
            appDb.Update(request);
            appDb.SaveChanges();


        }
        public override void Delete(int id)
        {
            /*var menuwka = menu.Find(f => f.Id == id);
            if (menuwka == null)
            {
                return null;
            }

            menu.Remove(menuwka);

            return menuwka;*/

            var x = appDb.MENU.Find(id);

            appDb.MENU.Find(id);
            appDb.MENU.Remove(x);

            appDb.SaveChanges();

        }
    }
}
