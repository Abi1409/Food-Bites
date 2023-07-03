using AutoMapper;
using Fooddeliveryapp1.DTO;
using Fooddeliveryapp1.Models;

namespace Fooddeliveryapp1
{
    public class MappingConfig : Profile
    {
        public MappingConfig() 
        { 
            CreateMap<Cart, CartDto>().ReverseMap();
            CreateMap<Item, ItemDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<UpdateUserRequestDTO, User>().ReverseMap();
            CreateMap<AddUserRequestDTO, User>().ReverseMap();
            CreateMap<AddAuthUserLoginDTO, User>().ReverseMap();

        }
    }
    
}
