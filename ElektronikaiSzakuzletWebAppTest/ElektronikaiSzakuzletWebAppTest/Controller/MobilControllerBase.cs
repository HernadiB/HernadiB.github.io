using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Controller
{
    [Route("mobilok")]
    public abstract class MobilControllerBase : ControllerBase
    {
        [HttpGet]
        public abstract List<Mobil> GetAll();
        [HttpGet("{id}")]
        public abstract Mobil GetById(int id);
        [HttpPost]
        public abstract Mobil Save([FromBody] Mobil inputData);
        [HttpPut("{id}")]
        public abstract Mobil Update(int id, [FromBody] Mobil updateData);
        [HttpDelete("{id}")]
        public abstract void Delete(int id);
    }
}
