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
    public class LocationController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly ILocationRepository locationRepository;
        public LocationController(IMapper mapper,ILocationRepository locationRepository)
        {
            this.locationRepository = locationRepository;
            this.mapper = mapper;
        }
        [HttpGet]
        public async  Task<IEnumerable<LocationResource>> Get()
        {
            var locations = await locationRepository.Get();
            var result= mapper.Map<IEnumerable<Location>, IEnumerable<LocationResource>>(locations);
            return result;
        }
    }
}