using AutoMapper;
using CURD.Business.DTOs.Blog;
using CURD.Business.Services.Interfaces;
using CURD.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Services.Implementarions;
public class BlogService : IBlogService
{
    readonly IBlogRepository _repo;
    readonly IMapper _mapper;
    public BlogService(IBlogRepository repo, IMapper mapper)
    {
        _repo = repo;
        _mapper = mapper;
    }

    public List<GetBlogDTO> GetAll()
    {
        var Blogs= _repo.GetAll("Author","BlogCAtegory","BlogCategory.Category");
        var returnBlogs= _mapper.Map<List<GetBlogDTO>>(Blogs);   //appuserde blog u ignore etmek evezine author dto su ile hell etmek gererk
        return returnBlogs;
    }
}
