using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Repository
{
    public class LaptopRepository
    {
        private List<Laptop> laptops = new List<Laptop>();
        private int nextIncrementalId = 0;
        public List<Laptop> Laptops { get => laptops; }
        public int NextIncrementalId { get => ++nextIncrementalId; }
    }
}
