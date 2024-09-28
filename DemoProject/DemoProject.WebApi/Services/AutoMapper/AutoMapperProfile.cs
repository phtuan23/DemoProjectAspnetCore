using AutoMapper;
using DemoProject.WebApi.Dtos.ProductDto;
using DemoProject.WebApi.Dtos.UserDto;
using DemoProject.WebApi.Models;

namespace DemoProject.WebApi.Services.AutoMapper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile() {
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();


            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();
        }
    }
}
