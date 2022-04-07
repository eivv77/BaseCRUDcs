using Business.Services;
using DataAccess.Models;
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
        public IEnumerable<Menu> Get()
        {
            return service.Get();
        }

        [HttpGet]
        [Route("get/{id}")]
        public Menu GetOne(int id)
        {
            return service.GetOne(id);
        }

        [HttpPost]
        [Route("post")] 
        public void Post([FromBody] Menu menuwka)
        {
            service.Post(menuwka);
        }

        [HttpPut]
        [Route("put/{id}")]
        public void Put(int id, [FromBody] Menu request)
        {
            service.Put(id,request);
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }

    }
}
