using CURD.Business.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Services.Interfaces;
public interface IBlogService
{
    public List<GetBlogDTO> GetAll();

}
