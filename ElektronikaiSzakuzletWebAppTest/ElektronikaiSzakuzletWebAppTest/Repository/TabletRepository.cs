using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Repository
{
    public class TabletRepository
    {
        private List<Tablet> tablets = new List<Tablet>();
        private int nextIncrementalId = 0;
        public List<Tablet> Tablets { get => tablets; }
        public int NextIncrementalId { get => ++nextIncrementalId; }
    }
}
