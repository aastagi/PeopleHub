using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.Models;

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
    }
}
