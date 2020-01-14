using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository
{
    public interface IProductImageRepository 
    {
        Task<IEnumerable<ProductImage>> GetProductImages(int productId);

        void AddProductImage(ProductImage productImage);
    }
}
