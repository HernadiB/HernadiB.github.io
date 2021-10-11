using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;

namespace ElektronikaiSzakuzletWebAppTest.Service
{
    public interface IMobilService
    {
        Mobil GetById(int id);
        List<Mobil> GetAll();
        Mobil Save(Mobil inputData);
        Mobil Update(int id, Mobil updateData);
        void Delete(int id);
    }
}
