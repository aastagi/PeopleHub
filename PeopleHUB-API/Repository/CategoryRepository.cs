using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly DataContext dataContext;
        public CategoryRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<IEnumerable<Category>> Get()
        {
            return await this.dataContext.Categories.ToListAsync();
        }
    }
}
