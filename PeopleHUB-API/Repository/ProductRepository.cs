using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;
        public ProductRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }
        public void AddProduct(Product product)
        {
            this.context.Add(product);
            this.context.SaveChanges();
        }

        public async Task<Product> GetProduct(int productId)
        {
            Product product = await context.Products.SingleOrDefaultAsync(e => e.ProductId == productId);
            return product;
        }
    }
}
