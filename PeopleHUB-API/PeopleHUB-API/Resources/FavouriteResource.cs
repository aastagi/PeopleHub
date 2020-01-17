using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleHUB_API.Resources
{
    public class FavouriteResource
    {
        public int FavouriteId { get; set; }

        public int EmployeeId { get; set; }

        public int? ProductId { get; set; }

        public Employee Employee { get; set; }

        public Product Product { get; set; }

    }
}
