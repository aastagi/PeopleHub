using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;
using Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class LocationRepository : ILocationRepository
    {
        private readonly DataContext dataContext;
        public LocationRepository(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public async Task<IEnumerable<Location>> Get()
        {
            return await this.dataContext.Locations.ToListAsync();
        }
    }
}
