﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<Product> GetProduct(int productId);    
        Task<Product> GetProductByLocationId(int locationId);
        Task<List<Favourite>> GetFavourites(int empId);
        Task<List<Product>> GetRecentlyAddedProducts(int? locationId, int? numberOfProduct = 5);
        Task<bool> DeleteFavourite(int productId);
        Task<Product> GetProductBasedOnLocation(int locationId);
        Task<Product> GetProductBasedOnKeyword(string keyword);
    }
}