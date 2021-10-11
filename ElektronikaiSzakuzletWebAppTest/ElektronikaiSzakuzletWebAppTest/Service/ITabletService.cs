using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Service
{
    public interface ITabletService
    {
        Tablet GetById(int id);
        List<Tablet> GetAll();
        Tablet Save(Tablet inputData);
        Tablet Update(int id, Tablet updateData);
        void Delete(int id);
    }
}
