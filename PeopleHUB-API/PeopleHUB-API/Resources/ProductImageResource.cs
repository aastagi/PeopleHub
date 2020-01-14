using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleHUB_API.Resources
{
    public class ProductImageResource
    {
        public int ProductImageId { get; set; }   
        public int ProductId { get; set; }  
        public string ImageOriginalName { get; set; }
        public string GeneratedFileName { get; set; }      
        public Boolean IsActive { get; set; } 
        public Boolean isThumbnailImage { get; set; }
    }
}
