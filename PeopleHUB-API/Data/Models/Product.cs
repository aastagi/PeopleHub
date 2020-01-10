using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Product
    {    
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public Boolean IsActive { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        public int LocationId { get; set; }
        [Required]
        public string Specification { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Title { get; set; }

        public Boolean PriceNegotiable { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Employee Employee { get; set; }
        public Category Category { get; set; }
        public Location Location { get; set; }

    }
}
