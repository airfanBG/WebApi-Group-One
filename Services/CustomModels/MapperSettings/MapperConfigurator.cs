﻿namespace Services.CustomModels.MapperSettings
{
    using AutoMapper;
    using Models;
    using Services.CustomModels.Interfaces;
    using System;

    public class MapperConfigurator
    {
        private static readonly Lazy<IMapper> Lazy = new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(cfg =>
            {

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
            CreateMap<RegisterModel, User>();
            CreateMap<Role, RoleModel>();
            CreateMap<ProductModel, Product>().ForMember(d => d.ProductName, opt => opt.MapFrom(x => x.Name));
            CreateMap<Product, ProductModel>().ForMember(d => d.Name, opt => opt.MapFrom(x => x.ProductName)); ;
            //CreateMap<ICustomModel, RoleModel>();
            CreateMap<UserRoles, UserRolesModel>();
            CreateMap<Employee, EmployeeModel>();
            CreateMap<Customer, CustomerModel>();
        }
    }
}
