using CURD.Business.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Services.Interfaces;
public interface IUserService
{
    Task Register(RegisterDTO dto);
    Task<string> Login (LoginDTO dto);
}
