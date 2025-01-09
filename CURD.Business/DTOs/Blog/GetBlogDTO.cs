using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Blog;  
public record GetBlogDTO
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string AuthorId { get; set; }
    public GetAuthorDTO AuthorDTO { get; set; }
    public ICollection<Core.Entityes.Category> BlogCategories { get; set; }   

}
