using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.DataAccess.Entities
{
    public class Contract
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        [ForeignKey("SalesManager")]
        public Guid SalesManagerId { get; set; }
        public SalesManager SalesManager { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        [ForeignKey("Product")]
        public Guid ProductId { get; set; }
        public Product Product { get; set; }

        [Required]
        public DateTime Created { get; set; }

        [Required]
        public int ObjectNumber { get; set; }

        [Required]
        public string ObjectAddress { get; set; }

        public Contract(int objectNumber, string objectAddress)
        {
            Id = Guid.NewGuid();
            Created = DateTime.Now;
            ObjectNumber = objectNumber;
            ObjectAddress = objectAddress;
        }
    }
}
