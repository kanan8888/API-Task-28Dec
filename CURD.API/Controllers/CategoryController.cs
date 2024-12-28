using AutoMapper;
using CURD.DAL.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{

    CURD_DbContext _db;
    IMapper _mapper;
    public CategoryController(CURD_DbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    //[HttpPost]
    //public IActionResult CreateCategory()
    //{

    //}

    //[HttpGet]
    //public IActionResult GetAllCategory()
    //{

    //}


    //[HttpGet("{id}")]
    //public IActionResult GetCategoryById(int id)
    //{

    //}

    //[HttpPut("{id}")]
    //public IActionResult UpdateCategory(int id)
    //{

    //}

    //[HttpDelete("{id}")]
    //public IActionResult DeleteCategory(int id)
    //{

    //}


}
