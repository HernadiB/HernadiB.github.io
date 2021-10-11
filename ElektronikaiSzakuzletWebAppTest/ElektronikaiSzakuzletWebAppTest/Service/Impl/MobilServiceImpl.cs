using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;
using ElektronikaiSzakuzletWebAppTest.Repository;

namespace ElektronikaiSzakuzletWebAppTest.Service.Impl
{
    public class MobilServiceImpl : IMobilService
    {
        private readonly Repository.MobilRepository mobilRepository;

        public MobilServiceImpl(Repository.MobilRepository mobilRepository)
        {
            this.mobilRepository = mobilRepository;
        }

        public void Delete(int id)
        {
            mobilRepository.Mobils.Remove(GetById(id));
        }

        public List<Mobil> GetAll()
        {
            return mobilRepository.Mobils;
        }

        public Mobil GetById(int id)
        {
            return mobilRepository.Mobils.Find(x => x.Id == id);
        }

        public Mobil Save(Mobil inputData)
        {
            inputData.Id = mobilRepository.NextIncrementalId;
            mobilRepository.Mobils.Add(inputData);
            return inputData;
        }

        public Mobil Update(int id, Mobil updateData)
        {
            var dbMobil = GetById(id);
            dbMobil.Name = updateData.Name;
            dbMobil.Price = updateData.Price;
            dbMobil.ScreenSize = updateData.ScreenSize;
            dbMobil.BatteryCapacity = updateData.BatteryCapacity;
            dbMobil.Description = updateData.Description;
            dbMobil.has5G = updateData.has5G;
            return dbMobil;
        }
    }
}
