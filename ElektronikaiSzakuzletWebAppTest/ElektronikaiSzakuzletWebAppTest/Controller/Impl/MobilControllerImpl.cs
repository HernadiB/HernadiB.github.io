using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElektronikaiSzakuzletWebAppTest.Service;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Controller.Impl
{
    public class MobilControllerImpl : MobilControllerBase
    {
        private readonly IMobilService mobilService;

        public MobilControllerImpl(IMobilService mobilService)
        {
            this.mobilService = mobilService;
        }
        public override void Delete(int id)
        {
            mobilService.Delete(id);
        }

        public override List<Mobil> GetAll()
        {
            return mobilService.GetAll();
        }

        public override Mobil GetById(int id)
        {
            return mobilService.GetById(id);
        }

        public override Mobil Save(Mobil inputData)
        {
            return mobilService.Save(inputData);
        }

        public override Mobil Update(int id, Mobil updateData)
        {
            return mobilService.Update(id, updateData);
        }
    }
}
