using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Controller
{
    [Route("laptopok")]
    public abstract class LaptopControllerBase : ControllerBase
    {
        [HttpGet]
        public abstract List<Laptop> GetAll();
        [HttpGet("{id}")]
        public abstract Laptop GetById(int id);
        [HttpPost]
        public abstract Laptop Save([FromBody] Laptop inputData);
        [HttpPut("{id}")]
        public abstract Laptop Update(int id, [FromBody] Laptop updateData);
        [HttpDelete("{id}")]
        public abstract void Delete(int id);
    }
}
