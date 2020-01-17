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
            if(!ModelState.IsValid)
            {
                return BadRequest("Error occured");
            }
            var product = mapper.Map<ProductResource, Product>(prod);
            product.CreatedDate = DateTime.Now;
            product.ModifiedDate = DateTime.Now;
            var insertedProduct=await productRepository.AddProduct(product);
            var result = mapper.Map<Product, ProductResource>(insertedProduct);
            return Ok(result);
        }

    }
}
