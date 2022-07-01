using Electricity_Supplier.Business.Services;
using Electricity_Supplier.DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Electricity_Supplier.API.Controllers
{
    public class ElectricitySupplierController : Controller
    {
        [Route("[Controller]")]

        [HttpPost("Create new POS")]
        public void CreatePOS(int id, string name, string address)
        {
            var pos = new POSServices();
            pos.CreatePOS(id, name, address);
        }
        [HttpPost("Create new POS with managers and contracts")]
        public void CreatPOS(int id, string name, string address, int managers, int contracts)
        {
            var pos = new POSServices();
            pos.CreatePOS(id, name, address, managers, contracts);
        }

        [HttpPost("Add manager to POS")]
        public void AddManagerToPOS(int posId, Guid managerId)
        {
            var manager = new SalesManagerServices();
            manager.AddManagerToPOS(posId, managerId);
        }

        [HttpGet("Get POS List")]
        public List<PointOfSale> GetPOSList()
        {
            POSServices pos = new POSServices();
            var posList = pos.GetPOSList();
            return posList;
        }

        [HttpPost("Create manager and add to POS")]
        public void CreateManager(int pointOfSaleId, string firstName, string lastName, string qualification, string phoneNumber, string email)
        {
            var manager = new SalesManagerServices();
            manager.CreateManager(pointOfSaleId, firstName, lastName, qualification, phoneNumber, email);
        }

        [HttpGet("Managers list in POS")]
        public List<SalesManager> GetManagersList(int posId)
        {
            SalesManagerServices manager = new SalesManagerServices();
            var managersList = manager.GetPOSManagerList(posId);
            return managersList;
        }

        [HttpPost("Add contract to manager")]
        public void AddContractToManager(Guid managerId, Guid contractId)
        {
            var result = new ContractServices();
            result.AddContractToManager(managerId, contractId);
        }
    }
}
