using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<Product> GetProduct(int productId);
    }
}
