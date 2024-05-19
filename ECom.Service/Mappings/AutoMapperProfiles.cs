using AutoMapper;
using ECom.Persistence.Domain;
using ECom.Persistence.Repositories;
using ECom.Service.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ECom.Persistence.Repositories.ProductRepository;

namespace ECom.Service.Mappings
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AddProductRequestDto, Product>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Product, ProductDetails>();
            CreateMap<Variant, ProductDetails>();
            CreateMap<Stock, ProductDetails>();
            CreateMap<Warehouse, ProductDetails>();
            
        }
    }
}
