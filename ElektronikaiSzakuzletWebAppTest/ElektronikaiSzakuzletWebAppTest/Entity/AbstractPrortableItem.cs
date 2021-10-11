using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElektronikaiSzakuzletWebAppTest.Entity
{
    public class AbstractPrortableItem : AbstractItem
    {
        public int BatteryCapacity { get; set; }
        public double ScreenSize { get; set; }
    }
}
