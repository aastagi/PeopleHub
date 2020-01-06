using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Task<Product> GetProducts();
    }
}
