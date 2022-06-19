using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.DataAccess.Entities
{
    public class SalesManager
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("PointOfSale")]
        public int PointOfSaleId { get; set; }
        public PointOfSale PointOfSale { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Qualification { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public List<Customer> Customers { get; set; }

        public List<Contract> Contracts { get; set; }

        public SalesManager(string firstName, string lastName, string qualification, string phoneNumber, string email)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Qualification = qualification;
            PhoneNumber = phoneNumber;
            Email = email;
            Customers = new List<Customer>();
            Contracts = new List<Contract>();
        }
    }
}
