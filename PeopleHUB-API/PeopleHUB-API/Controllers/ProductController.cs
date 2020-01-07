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

        // POST: api/Product
        [HttpPost, Route("addproduct")]
        public async Task<IActionResult> AddProduct([FromBody]ProductResource prod)
        {
            var product = mapper.Map<ProductResource, Product>(prod);
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            productRepository.AddProduct(product);
            return Ok();
        }

        // PUT: api/Product/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        // DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
