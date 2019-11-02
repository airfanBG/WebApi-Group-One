using AutoMapper;
using Models;
using Models.BaseModels;
using Services.CustomModels.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services.CustomModels.MapperSettings
{
    public class MapperConfigurator
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg => {
                
                cfg.ShouldMapProperty = p => p.GetMethod.IsPublic || p.GetMethod.IsAssembly;
                cfg.AddProfile<MappingProfile>();
            });
            var mapper = config.CreateMapper();
            return mapper;
        });

        public static IMapper Mapper => Lazy.Value;
    }
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ICustomModel, User>();
            CreateMap<TokenRequestModel, User>();
            CreateMap<Role, RoleModel>();
            CreateMap<ProductModel, Product>().ForMember(d=>d.ProductName, opt=>opt.MapFrom(x=>x.Name));
            CreateMap<Product, ProductModel>().ForMember(d => d.Name, opt => opt.MapFrom(x => x.ProductName)); ;
            //CreateMap<ICustomModel, RoleModel>();
            CreateMap<UserRoles, UserRolesModel>().ForMember(x => x.Roles, o => o.Ignore());
        }
    }
}
