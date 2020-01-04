using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data.Models;
using PeopleHUB_API.Resources;


namespace PeopleHUB_API.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EmployeeResource, Employee>();
            CreateMap<Employee, EmployeeResource>();
        }
    }
}
