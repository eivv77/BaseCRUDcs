using Business.IService;
using DataAccess.Entities;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IMenuService : IBaseService<MenuDTO, Menu, MenuDTO>
    {
       
    }
}
