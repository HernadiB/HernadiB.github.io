using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElektronikaiSzakuzletWebAppTest.Entity;
using ElektronikaiSzakuzletWebAppTest.Repository;

namespace ElektronikaiSzakuzletWebAppTest.Service.Impl
{
    public class TabletServiceImpl : ITabletService
    {
        private readonly Repository.TabletRepository tabletRepository;

        public TabletServiceImpl(Repository.TabletRepository tabletRepository)
        {
            this.tabletRepository = tabletRepository;
        }

        public void Delete(int id)
        {
            tabletRepository.Tablets.Remove(GetById(id));
        }

        public List<Tablet> GetAll()
        {
            return tabletRepository.Tablets;
        }

        public Tablet GetById(int id)
        {
            return tabletRepository.Tablets.Find(x => x.Id == id);
        }

        public Tablet Save(Tablet inputData)
        {
            inputData.Id = tabletRepository.NextIncrementalId;
            tabletRepository.Tablets.Add(inputData);
            return inputData;
        }

        public Tablet Update(int id, Tablet updateData)
        {
            var dbTablet = GetById(id);
            dbTablet.Name = updateData.Name;
            dbTablet.Price = updateData.Price;
            dbTablet.ScreenSize = updateData.ScreenSize;
            dbTablet.BatteryCapacity = updateData.BatteryCapacity;
            dbTablet.Description = updateData.Description;
            return dbTablet;
        }
    }
}
