using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleHUB_API.Resources
{
    public class ProductResource
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public Boolean IsActive { get; set; }

        public int EmployeeId { get; set; }

        public string Description { get; set; }

        public string Location { get; set; }

        public string Specification { get; set; }

        public decimal Price { get; set; }

        public string Address { get; set; }

        public string Title { get; set; }

        public int PriceNegotiable { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
