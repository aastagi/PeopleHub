using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    [Table("MostVisited")]
    public class MostVisited
    {
        public int MostVisitedId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int ViewNumber { get; set; }
        public int ContactedNumber { get; set; }
        public Product Product { get; set; }
    }
}
