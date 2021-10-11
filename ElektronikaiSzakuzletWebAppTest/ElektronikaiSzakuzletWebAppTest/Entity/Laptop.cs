using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElektronikaiSzakuzletWebAppTest.Entity
{
    public class Laptop : AbstractPrortableItem
    {
        public string Cpu { get; set; }
        public string Gpu { get; set; }
    }
}
