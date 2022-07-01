using Electricity_Supplier.DataAccess;
using Electricity_Supplier.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.Business.Services
{
    public class POSServices
    {
        public void CreatePOS(int id, string name, string address)
        {
            var context = new ElectricitySupplierDbContext();
            PointOfSale pos = new PointOfSale(id, name, address);
            context.PointOfSales.Add(pos);
            context.SaveChanges();
        }
        public List<PointOfSale> GetPOSList()
        {
            var context = new ElectricitySupplierDbContext();
            var posList = context.PointOfSales.ToList();
            return posList;
        }
        public void CreatePOS(int id, string name, string address, int managers, int contracts)
        {
            var context = new ElectricitySupplierDbContext();

            List<SalesManager> manager = new List<SalesManager>();
            for (int i = 0; i < managers; i++)
            {
                manager.Add(new SalesManager($"Vardenis{i}", $"Pavardenis{i}", "Manager", $"+3706011111{i}", $"mail{1}@tiekejas.lt"));
            }

            List<Contract> contract = new List<Contract>();
            for (int i = 0; i < contracts; i++)
            {
                contract.Add(new Contract(320010+i, $"Gatve{i} Namas{i}"));
            }

            //for (int i = 0; i < contract.Count; i++)
            //{
           //     contract[i].SalesManagers.AddRange(manager);
            //}

            context.PointOfSales.Add(new PointOfSale(id, name, address, manager, contract));
            context.SaveChanges();
        }
        public void DeletePOS(int id)
        {
            var context = new ElectricitySupplierDbContext();
            var posId = context.PointOfSales.Where(x => x.Id == id).FirstOrDefault();
            context.PointOfSales.Remove(posId);
            context.SaveChanges();
        }
    }
}
