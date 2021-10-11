using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ElektronikaiSzakuzletWebAppTest.Entity
{
    public abstract class AbstractItem : AbstractBaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
