using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Data.Models;

namespace Repository
{
    public interface ILocationRepository
    {
        Task<IEnumerable<Location>> Get();
    }
}
