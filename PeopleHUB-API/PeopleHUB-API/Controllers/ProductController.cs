using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleHUB_API.Resources;
using Repository;

namespace PeopleHUB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProductRepository productRepository;
        public ProductController(IProductRepository productRepository, IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        // GET: api/Product
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //GET: api/Product/5
        [HttpGet, Route("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await productRepository.GetProduct(id);
            
            var result = mapper.Map<Product, ProductResource>(product);
            return Ok(result);
        }

        
        [HttpGet, Route("{locationId}")]
        public async Task<IActionResult> GetProducts(int locationId)
        {
            var product = await productRepository.GetProductByLocationId(locationId);

            var result = mapper.Map<Product, ProductResource>(product);
            return Ok(result);
        }
        [HttpGet, Route("getFavourites")]
        public async Task<IEnumerable<FavouriteResource>> GetFavourites(int empId)
        {
            var product = await productRepository.GetFavourites(empId);
            var result = mapper.Map<IEnumerable<Favourite>, IEnumerable<FavouriteResource>>(product);
            return result;
        }
        [HttpGet, Route("getRecentlyProducts")]
        public async Task<IEnumerable<ProductResource>> GetRecentlyAddedProducts(int LocationId)
        {
            var product = await productRepository.GetRecentlyAddedProducts(LocationId);
            var result = mapper.Map<IEnumerable<Product>, IEnumerable<ProductResource>>(product);
            return result;
        }
        [HttpGet, Route("getProductBasedOnLocation")]
        public async Task<IActionResult> GetProductBasedOnLocation(int locationId)
        {
            var product = await productRepository.GetProductBasedOnLocation(locationId);
            var result = mapper.Map<Product, ProductResource>(product);
            return Ok(result);
        }
        [HttpGet, Route("getProductBasedOnKeyword")]
        public async Task<IActionResult> GetProductBasedOnKeyword(string keyword)
        {
            var product = await productRepository.GetProductBasedOnKeyword(keyword);
            var result = mapper.Map<Product, ProductResource>(product);
            return Ok(result);
        }

        [HttpPost, Route("updateProduct")]
        public async Task<IActionResult> UpdateProduct([FromBody]ProductResource prod)
        {
            var product = mapper.Map<ProductResource, Product>(prod);
            product.Category.CategoryId = prod.CategoryId;
            product.Title = prod.Title;
            product.Specification = prod.Specification;
            product.Description = prod.Description;
            product.Price = prod.Price;
            product.LocationId = prod.LocationId;
            product.Address = prod.Address;
            product.PriceNegotiable = prod.PriceNegotiable;
            product.IsActive = prod.IsActive;
            product.ModifiedDate = DateTime.Now;
            productRepository.AddProduct(product);
            return Ok();
        }

        // POST: api/Product
        [HttpPost, Route("addproduct")]
        public async Task<IActionResult> AddProduct([FromBody]ProductResource prod)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Error occured");
            }
            var product = mapper.Map<ProductResource, Product>(prod);
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            productRepository.AddProduct(product);
            return Ok();
        }
        [HttpPost, Route("deleteproduct")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            var product = await productRepository.GetProduct(id);

            var result = mapper.Map<Product, ProductResource>(product);
            result.IsActive = false;
            return Ok(result);
        }

        [HttpPost, Route("deleteFavourite")]
        public async Task<bool> DeleteFavourite(int productId)
        {
            var product = productRepository.DeleteFavourite(productId);
            return true;
        }
        
    }
}
