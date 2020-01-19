using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using AutoMapper;
using Repository;
using Data.Models;
using PeopleHUB_API.Resources;

namespace PeopleHUB_API.Controllers
{
    [Route("api/product/{productId}/productImage")]
    [ApiController]
    public class ProductImageController : ControllerBase
    {

        private readonly IMapper mapper;
        private readonly IProductImageRepository productImageRepository;

        public ProductImageController(IMapper mapper ,IProductImageRepository productImageRepository )
        {
            this.mapper = mapper;
            this.productImageRepository = productImageRepository;
        }
        public string uploadFolderPath = @"C:\Practise\PeopleHub\UploadImages";
        private readonly string[] ACCEPTED_FILE_TYPES = new[] { ".jpg", ".jpeg", ".png" };
        private readonly int MAX_FILE_SIZE = 10 * 1024 * 1024;

        [HttpPost]
        public async Task<IActionResult> Upload(int productId, IFormFile file)
        {
            
            if (!Directory.Exists(uploadFolderPath))
            {
                Directory.CreateDirectory(uploadFolderPath);
            }
            if (file == null) return BadRequest("Null File");
            if (file.Length == 0) return BadRequest("Empty File");
            if (file.Length > MAX_FILE_SIZE) return BadRequest("Max file size exceeded");
            var fileName = Guid.NewGuid().ToString("N") + Path.GetExtension(file.FileName);
            //var fileName = file.FileName;
            if (!ACCEPTED_FILE_TYPES.Any(s => s == Path.GetExtension(file.FileName).ToLower())) return BadRequest("Invalid Fie type");
            var filePath = Path.Combine(uploadFolderPath, fileName);

            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            var productImageResource = new ProductImageResource();
            productImageResource.GeneratedFileName = fileName;
            productImageResource.ImageOriginalName = file.FileName;
            productImageResource.IsActive = true;
            productImageResource.ProductId = productId;
            
            AddProductImageRecordToDatabase(productImageResource);
          
            return Ok(productImageResource);
            
        }

        [HttpGet]
        public async Task<IEnumerable<ProductImageResource>> GetProductImages(int ProductId)
        {
            var productImages = await productImageRepository.GetProductImages(ProductId);
            var result = mapper.Map<IEnumerable<ProductImage>, IEnumerable<ProductImageResource>>(productImages);
            return result;

        }

        public void AddProductImageRecordToDatabase(ProductImageResource productImageResource)
        {
            var result = mapper.Map<ProductImageResource, ProductImage>(productImageResource);
            productImageRepository.AddProductImage(result);

        }
    }
}