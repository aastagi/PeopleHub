using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Product
    {
        //not created yet
      public int ProductID { get; set; }
      public int CategoryId { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public Employee EmpId { get; set; } 

    }
}
