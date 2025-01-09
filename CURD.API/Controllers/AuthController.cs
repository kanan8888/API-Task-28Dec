using CURD.Business.DTOs.User;
using CURD.Business.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CURD.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Register([FromForm] RegisterDTO dto)
    {
        try 
        {
            await _userService.Register(dto);  
            return Ok();
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("[action]")]
    public async Task<IActionResult> Login([FromForm] LoginDTO dto)
    {
        try
        {            
            return Ok(await _userService.Login(dto));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
