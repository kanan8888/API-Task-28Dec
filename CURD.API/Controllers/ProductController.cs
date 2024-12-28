using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public IActionResult CreateProduct()
        {

        }

        [HttpGet]
        public IActionResult GetAllProduct() 
        {
        
        }


        [HttpGet]
        public IActionResult GetProductById()
        {

        }


    }
}
