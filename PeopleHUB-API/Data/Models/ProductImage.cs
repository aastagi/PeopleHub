using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Data.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ImageOriginalName { get; set; }
        public string GeneratedFileName { get; set; }
        [Required]
        public Boolean IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        [Required]
        public Boolean isThumbnailImage { get; set; }
        

       
    }
}
