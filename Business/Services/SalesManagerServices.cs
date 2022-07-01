using Electricity_Supplier.DataAccess;
using Electricity_Supplier.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.Business.Services
{
    public class SalesManagerServices
    {
        public void CreateManager(int pointOfSaleId, string firstName, string lastName, string qualification, string phoneNumber, string email)
        {
            var context = new ElectricitySupplierDbContext();
            SalesManager manager = new SalesManager(pointOfSaleId, firstName, lastName, qualification, phoneNumber, email);
            context.Add(manager);
            context.SaveChanges();
        }
        public void AddManagerToPOS(int posId, Guid managerId)
        {
            var context = new ElectricitySupplierDbContext();
            var pos = context.PointOfSales.Where(x => x.Id == posId).SingleOrDefault();
            var manager = context.SalesManagers.Where(x => x.Id == managerId).SingleOrDefault();
            pos.SalesManagers.Add(manager);
            context.SaveChanges();
        }
        public List<SalesManager> GetPOSManagerList(int posId)
        {
            var context = new ElectricitySupplierDbContext();
            var posManagerList = context.SalesManagers.Where(x => x.PointOfSaleId == posId).ToList();
            return posManagerList;
        }
        public List<SalesManager> GetManagerContacts(Guid managerId)
        {
            var context = new ElectricitySupplierDbContext();
            var managerContacts = context.SalesManagers.Where(x => x.Id == managerId).ToList();

            return (List<SalesManager>)managerContacts;
        }
    }
}
