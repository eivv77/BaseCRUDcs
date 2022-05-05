using AutoMapper;
using Business.IService;
using Business.Services;
using DataAccess;
using DataAccess.Entities;
using DTO;
using Repo.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Service
{
    public class MenuService : BaseService<MenuDTO, Menu, MenuDTO>, IMenuService
    {
        public MenuService(IRepository<Menu> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
