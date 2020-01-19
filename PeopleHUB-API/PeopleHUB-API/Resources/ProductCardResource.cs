using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PeopleHUB_API.Resources
{
    public class ProductCardResource
    {
        public ProductResource ProductResource { get; set; }
        public ProductImageResource productImageResource { get; set; }
    }
}
