using AutoMapper;
using CURD.Business.Services.Interfaces;
using CURD.DAL.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
public class CategoryController : ControllerBase
{
    ICategoryService _service;
    IMapper _mapper;
    public CategoryController(ICategoryService service, IMapper mapper)
    {
        _service = service;
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
