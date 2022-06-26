using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.DataAccess.Entities
{
    public class PointOfSale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public List<SalesManager> SalesManagers { get; set; }

        public List<Contract> Contracts { get; set; }

        public PointOfSale(int id, string name, string address)
        {
            Id = id;
            Name = name;
            Address = address;
        }
        public PointOfSale(int id, string name, string address, List<SalesManager> salesManagers, List<Contract> contracts)
        {
            Id = id;
            Name = name;
            Address = address;
            SalesManagers = salesManagers;
            Contracts = contracts;  
        }
    }
}
