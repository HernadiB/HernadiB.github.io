using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;
using ElektronikaiSzakuzletWebAppTest.Service;
using Microsoft.AspNetCore.Mvc;

namespace ElektronikaiSzakuzletWebAppTest.Controller.Impl
{
    public class TabletControllerImpl : TabletControllerBase
    {
        private readonly ITabletService tabletService;

        public TabletControllerImpl(ITabletService tabletService)
        {
            this.tabletService = tabletService;
        }

        public override void Delete(int id)
        {
            tabletService.Delete(id);
        }

        public override List<Tablet> GetAll()
        {
            return tabletService.GetAll();
        }

        public override Tablet GetById(int id)
        {
            return tabletService.GetById(id);
        }

        public override Tablet Save(Tablet inputData)
        {
            return tabletService.Save(inputData);
        }

        public override Tablet Update(int id, Tablet updateData)
        {
            return tabletService.Update(id, updateData);
        }
    }
}
