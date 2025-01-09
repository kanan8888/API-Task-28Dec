using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.User;
public record ForgetPasswordDTO
{
    public string Email { get; set; }   

}
