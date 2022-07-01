using Electricity_Supplier.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.Business.Services
{
    public class ContractServices
    {
        public void AddContractToManager(Guid managerId, Guid contractId)
        {
            var context = new ElectricitySupplierDbContext();
            var manager = context.SalesManagers.Where(x => x.Id == managerId).FirstOrDefault();
            var contract = context.Contracts.Where(x => x.Id == contractId).FirstOrDefault();
            manager.Contracts.Add(contract);

            //contract.SalesManager.Clear();

            context.SaveChanges();
        }
    }
}
