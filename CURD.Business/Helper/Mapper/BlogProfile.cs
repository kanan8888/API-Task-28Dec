using AutoMapper;
using CURD.Business.DTOs.Blog;
using CURD.Core.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Helper.Mapper;
public class BlogProfile : Profile
{
    public BlogProfile()
    {
        CreateMap<GetBlogDTO,Blog>().ReverseMap();
        CreateMap<GetAuthorDTO,AppUser>().ReverseMap();
    }

}
