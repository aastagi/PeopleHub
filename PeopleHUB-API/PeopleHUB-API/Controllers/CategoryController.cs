using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PeopleHUB_API.Resources;
using Repository;
using Data.Models;

namespace PeopleHUB_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ICategoryRepository categoryRepository;
        public CategoryController(IMapper mapper, ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CategoryResource>> Get()
        {
            var categories = await categoryRepository.Get();
            var result = mapper.Map<IEnumerable<Category>, IEnumerable<CategoryResource>>(categories);
            return result;
        }
    }
}