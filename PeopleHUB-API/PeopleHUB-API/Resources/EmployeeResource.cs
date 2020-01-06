using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleHUB_API.Resources
{
    public class EmployeeResource
    {

        public int EmployeeId { get; set; }
       
        public string FirstName { get; set; }
       
        public string LastName { get; set; }
       
        public string Email { get; set; }
        
        public string Password { get; set; }
        
        public string Location { get; set; }

        public string CountryCode { get; set; }

        public string MobileNumber { get; set; }
        
        public DateTime ModifiedDate { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}
