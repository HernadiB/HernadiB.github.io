using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Service
{
    public interface ILaptopService
    {
        Laptop GetById(int id);
        List<Laptop> GetAll();
        Laptop Save(Laptop inputData);
        Laptop Update(int id, Laptop updateData);
        void Delete(int id);
    }
}
