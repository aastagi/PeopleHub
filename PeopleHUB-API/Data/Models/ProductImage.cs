using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Models
{
    public class ProductImage
    {
        public int ProductImageId { get; set; }
        public int ProductId { get; set; }
        public string ImageOriginalName { get; set; }
        public string GeneratedFileName { get; set; }
        public int IsActive { get; set; }
        public DateTime CreateDate { get; set; }
        public Product Product { get; set; }
    }
}
