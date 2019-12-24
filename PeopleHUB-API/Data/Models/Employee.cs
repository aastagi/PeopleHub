using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public int MobileNumber { get; set; }
        [Required]
        public DateTime ModifiedDate { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }

    }
}
