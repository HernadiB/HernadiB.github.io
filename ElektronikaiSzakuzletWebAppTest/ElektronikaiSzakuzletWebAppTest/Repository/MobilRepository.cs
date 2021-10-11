using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Repository
{
    public class MobilRepository
    {
        private List<Mobil> mobils = new List<Mobil>();
        private int nextIncrementalId = 0;
        public List<Mobil> Mobils { get => mobils; }
        public int NextIncrementalId { get => ++nextIncrementalId; }
    }
}
