using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace Persistance
{
    public class ProductImageRepository : IProductImageRepository
    {
        private readonly DataContext dataContext;
        public ProductImageRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public void AddProductImage(ProductImage productImage)
        {
            dataContext.ProductImages.Add(productImage);
            dataContext.SaveChanges();
        }

        public async Task<IEnumerable<ProductImage>> GetProductImages(int productId)
        {
            var result = await dataContext.ProductImages.Where(p => p.ProductId == productId).ToListAsync();
            return result;
        }
    }
}
