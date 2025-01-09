using AutoMapper;
using CURD.Business.DTOs.Category;
using CURD.Business.DTOs.Product;
using CURD.Business.DTOs.Tag;
using CURD.Business.DTOs.User;
using CURD.Core.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Helper.Mapper;
public class AutoMapper : Profile
{
    protected AutoMapper()
    {
        CreateMap<Category , GetCategoryDto>().ReverseMap();
        CreateMap<Category , GetAllCategoriesDto>().ReverseMap();     
        CreateMap<Category , CreateCategoryDto>().ReverseMap();
        CreateMap<Category , UpdateCategoryDto>().ReverseMap();

        CreateMap<Product , GetProductDto>().ReverseMap();
        CreateMap<Product , GetAllProductDto>().ReverseMap();
        CreateMap<Product , CreateProductDto>().ReverseMap();
        CreateMap<Product , UpdateCategoryDto>().ReverseMap();

        CreateMap<Tag , GetTagDto>().ReverseMap();
        CreateMap<Tag , GetAllTagDto>().ReverseMap();
        CreateMap<Tag , CreateTagDto>().ReverseMap();
        CreateMap<Tag , UpdateTagDto>().ReverseMap();

        CreateMap<AppUser , RegisterDTO>().ReverseMap();
    }

}
