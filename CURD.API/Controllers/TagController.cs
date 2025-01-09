using AutoMapper;
using CURD.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
public class TagController : ControllerBase
{
    ITagService _service;
    IMapper _mapper;
    public TagController(ITagService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    //[HttpPost]
    //public IActionResult CreateTag()
    //{

    //}

    //[HttpGet]
    //public IActionResult GetAllTag() 
    //{

    //}


    //[HttpGet("{id}")]
    //public IActionResult GetTagById(int id)
    //{

    //}

    //[HttpPut("{id}")]
    //public IActionResult UpdateTag(int id)
    //{

    //}

    //[HttpDelete("{id}")]
    //public IActionResult DeleteTag(int id)
    //{

    //}


}
