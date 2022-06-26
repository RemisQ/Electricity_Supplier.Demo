using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.DataAccess.Entities
{
    public class Customer
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("SalesManager")]
        public Guid SalesManagerId { get; set; }
        public SalesManager SalesManager { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Contract> Contracts { get; set; }

        public Customer(string name, string lastName, string phoneNumber, string email)
        {
            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Contracts = new List<Contract>();
        }
    }
}
