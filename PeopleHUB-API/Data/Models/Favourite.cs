using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class Favourite
    {
        public int FavouriteId { get; set; }
        public int EmployeeId { get; set; }
        public int? ProductId { get; set; }
        public Employee Employee { get; set; }
        public Product Product { get; set; }
    }
}
