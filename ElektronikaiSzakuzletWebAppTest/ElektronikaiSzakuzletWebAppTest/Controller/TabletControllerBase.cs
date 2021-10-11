using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Controller
{
    [Route("tabletek")]
    public abstract class TabletControllerBase : ControllerBase
    {
        [HttpGet]
        public abstract List<Tablet> GetAll();
        [HttpGet("{id}")]
        public abstract Tablet GetById(int id);
        [HttpPost]
        public abstract Tablet Save([FromBody] Tablet inputData);
        [HttpPut("{id}")]
        public abstract Tablet Update(int id, [FromBody] Tablet updateData);
        [HttpDelete("{id}")]
        public abstract void Delete(int id);
    }
}
