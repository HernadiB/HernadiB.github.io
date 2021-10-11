using ElektronikaiSzakuzletWebAppTest.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Service;

namespace ElektronikaiSzakuzletWebAppTest.Controller.Impl
{
    public class LaptopControllerImpl : LaptopControllerBase
    {
        private readonly ILaptopService laptopService;
        public LaptopControllerImpl(ILaptopService laptopService)
        {
            this.laptopService = laptopService;
        }
        public override void Delete(int id)
        {
            laptopService.Delete(id);
        }

        public override List<Laptop> GetAll()
        {
            return laptopService.GetAll();
        }

        public override Laptop GetById(int id)
        {
            return laptopService.GetById(id);
        }

        public override Laptop Save(Laptop inputData)
        {
            return laptopService.Save(inputData);
        }

        public override Laptop Update(int id, Laptop updateData)
        {
            return laptopService.Update(id, updateData);
        }
    }
}
