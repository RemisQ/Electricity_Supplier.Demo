using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_Supplier.DataAccess.Entities
{
    public class Product
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; } = "electricity";

        public string StartDate { get; set; } = "1/7/2022";

        [Required]
        public int DurationByMonths { get; set; }

        [Required]
        public int TimeZone { get; set; }

        [Required]
        public decimal KWhPrice { get; set; }

        public Product(string name, string type, string startDate, int durationByMonths, int timeZone, decimal kWhPrice)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
            StartDate = startDate;
            DurationByMonths = durationByMonths;
            TimeZone = timeZone;
            KWhPrice = kWhPrice;
        }

    }
}
