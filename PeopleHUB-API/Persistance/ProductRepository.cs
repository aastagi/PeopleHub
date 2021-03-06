﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace Persistance
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext context;
        public ProductRepository(DataContext dataContext)
        {
            this.context = dataContext;
        }
        public async Task<Product> AddProduct(Product product)
        {
            this.context.Add(product);
            this.context.SaveChanges();
            var productId = product.ProductId;
            return await this.context.Products.SingleOrDefaultAsync(item => item.ProductId == productId);
        }

        public void UpdateProduct(Product product)
        {
            this.context.Update(product);
            this.context.SaveChanges();
        }
        public async Task<Product> GetProduct(int productId)
        {
            Product product = await context.Products.SingleOrDefaultAsync(e => e.ProductId == productId);
            return product;
        }
        public async Task<Product> GetProductByLocationId(int locationId)
        {
            Product product = await context.Products.SingleOrDefaultAsync(e => e.LocationId == locationId);
            return product;
        }
        public async Task<List<Product>> GetRecentlyAddedProducts(int? locationId,int? numberOfProduct=5)
        {
            List<Product> product = await context.Products
                                    .Include("ProductImages")
                                    .OrderByDescending(a => a.ModifiedDate)
                                    .Where(ap => ap.LocationId == locationId)
                                    .Take(5)
                                    .ToListAsync();
                                    
            return product;
        }
        public async Task<List<Favourite>> GetFavourites(int empId)
        {
            List<Favourite> empFavourites = await context.Favourites.Include("Product").Where(e => e.EmployeeId == empId).ToListAsync();
            return empFavourites;
        }
        public async Task<Product> GetProductBasedOnLocation(int locationId)
        {
            Product product = await context.Products.SingleOrDefaultAsync(e => e.LocationId == locationId);
            return product;
        }
        public async Task<Product> GetProductBasedOnKeyword(string keyword)
        {
            var product = await context.Products.SingleOrDefaultAsync(e => e.Location.LocationName.Contains(keyword) 
                                                                        || e.Description.Contains(keyword)
                                                                        || e.Specification.Contains(keyword)
                                                                        || e.Address.Contains(keyword)
                                                                        || e.Title.Contains(keyword)
                                                                        || Convert.ToString(e.Price).Contains(keyword)
                                                                        || Convert.ToString(e.PriceNegotiable).Contains(keyword)
                                                                        || Convert.ToString(e.CreatedDate).Contains(keyword));
            return product;
        }
        public async Task<bool> DeleteFavourite(int productId)
        {
            var favProduct = context.Favourites.Where(e => e.ProductId == productId);
            foreach (var pro in favProduct)
            {
                context.Favourites.Remove(pro);
            }
            context.SaveChanges();
            return true;
        }
    }
}
