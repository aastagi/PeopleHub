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
            CreateMap<EmployeeResource, Employee>().ReverseMap();
            CreateMap<ProductResource, Product>().ReverseMap();
            CreateMap<ProductImageResource, ProductImage>().ReverseMap();
            CreateMap<FavouriteResource, Favourite>().ReverseMap();

            CreateMap<Location, LocationResource>();  
            CreateMap<Category, CategoryResource>();
        }
    }
}
