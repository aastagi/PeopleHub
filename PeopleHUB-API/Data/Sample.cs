using System;
using System.ComponentModel.DataAnnotations;

namespace Data
{
    public class Sample
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
    }
}
