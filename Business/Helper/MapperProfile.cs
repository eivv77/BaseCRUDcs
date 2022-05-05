using AutoMapper;
using DataAccess.Entities;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Helper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<MenuDTO, Menu>();
            CreateMap<Menu, MenuDTO>();
        }
    }
}
