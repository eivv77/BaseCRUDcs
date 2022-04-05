using Business.Models;
using Business.Services;
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
        //[Route("get")]
        public IEnumerable<Menu> Get()
        {
            return service.Get();
        }

        [HttpGet("{id}")]
        //[Route("get/{id}")]
        public Menu GetOne(int id)
        {
            return service.GetOne(id);
        }

        [HttpPost]
        //[Route("post")] 
        public IEnumerable<Menu> Post([FromBody] Menu menuwka)
        {
            return service.Post(menuwka);
        }

        [HttpPut("{id}")]
        //[Route("put/{id}")]
        public Menu Put(int id, [FromBody] Menu request)
        {
            return service.Put(id,request);
        }

        [HttpDelete("{id}")]
        //[Route("delete/{id}")]
        public Menu Delete(int id)
        {
            return service.Delete(id);
        }

    }
}
