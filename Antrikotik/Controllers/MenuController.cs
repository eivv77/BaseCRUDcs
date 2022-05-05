using Business.Services;
using DataAccess.Entities;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Antrikotik.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService service;

        public MenuController(IMenuService service)
        {
            this.service = service;
        }

        [HttpGet]
        [Route("get")]
        public IEnumerable<MenuDTO> GetAll()
        {
            return service.GetAll();
        }

        [HttpGet]
        [Route("get/{id}")]
        public MenuDTO GetOne(int id)
        {
            return service.GetOne(id);
        }

        [HttpPost]
        [Route("post")] 
        public void Post([FromBody] MenuDTO MenuDTOwka)
        {
            service.Post(MenuDTOwka);
        }

        [HttpPut]
        [Route("put/{id}")]
        public void Put([FromBody] MenuDTO request)
        {
            service.Put(request);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }

    }
}
