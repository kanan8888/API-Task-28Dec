using AutoMapper;
using CURD.Business.DTOs.User;
using CURD.Business.Helper.Exceptions.UserExceptions;
using CURD.Business.Services.Interfaces;
using CURD.Core.Entityes;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Services.Implementarions;
public class UserService : IUserService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly IMapper _mapper;
    private readonly IConfiguration _config;
    public UserService(UserManager<AppUser> userManager, IMapper mapper, IConfiguration config)
    {
        _userManager = userManager;
        _mapper = mapper;
        _config = config;
    }

    public async Task Register(RegisterDTO dto)
    {
        if (await _userManager.FindByEmailAsync(dto.Email) != null)
        {
            throw new UserRegisterException("bu email istifade olunub");
        }

        var appUser = _mapper.Map<AppUser>(dto);

        var result = await _userManager.CreateAsync(appUser , dto.Password);

        if (!result.Succeeded)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var error in result.Errors)
            {
                sb.Append(error.Description + " ");
            }
            throw new UserRegisterException(sb.ToString());
        }
    }
    public async Task<string> Login(LoginDTO dto)
    {
        var user = await _userManager.FindByEmailAsync(dto.UserNameOrEmail)
            ?? await _userManager.FindByNameAsync(dto.UserNameOrEmail);
        if (user == null)
        {
            throw new UserLoginException("ya bele bir istifadeci yoxdur yada melumatlarinizi duzgun daxil etmemisiniz");
        }

        var result = await _userManager.CheckPasswordAsync(user, dto.Password);
        if (!result)
        {
            throw new UserLoginException("ya bele bir istifadeci yoxdur yada melumatlarinizi duzgun daxil etmemisiniz");
        }

        var _claims = new[]
        {
            new Claim(ClaimTypes.NameIdentifier, user.Id),
            new Claim(ClaimTypes.Name, user.UserName)
        };
        SecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:SecurityKey"]));
        SigningCredentials _signingCredentials = new SigningCredentials(key,SecurityAlgorithms.HmacSha256);

        JwtSecurityToken jwtToken = new JwtSecurityToken(
            audience: _config["Jwt:Audience"],
            issuer: _config["Jwt:Issuer"],
            claims: _claims,
            signingCredentials: _signingCredentials,
            expires:DateTime.UtcNow.AddMinutes(60)
        );
        var token = new JwtSecurityTokenHandler().WriteToken(jwtToken);

        return token;
    }

}
