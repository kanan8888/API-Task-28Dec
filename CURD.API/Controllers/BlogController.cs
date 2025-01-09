using CURD.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BlogController : ControllerBase
{
    readonly IBlogService _blogService;
    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public IActionResult GetAll()
    { 
        return OK(_blogService.GetAll());
    }

}
