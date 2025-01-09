using AutoMapper;
using CURD.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers;

[Route("api/[controller]")]
[ApiController]
//[Authorize]
public class ProductController : ControllerBase
{
    IProductService _service;
    IMapper _mapper;
    public ProductController(IProductService service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    //[HttpPost]
    //public IActionResult CreateProduct()
    //{

    //}

    //[HttpGet]
    //public IActionResult GetAllProduct() 
    //{

    //}


    //[HttpGet("{id}")]
    //public IActionResult GetProductById(int id)
    //{

    //}

    //[HttpPut("{id}")]
    //public IActionResult UpdateProduct(int id)
    //{

    //}

    //[HttpDelete("{id}")]
    //public IActionResult DeleteProduct(int id)
    //{

    //}


}
