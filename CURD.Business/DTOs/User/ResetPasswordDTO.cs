using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.User;
public record ResetPasswordDTO
{
    public string OldPassword { get; set; }
    public string NewPassword { get; set; }
    public string ConfirmNewPassword { get; set; }

}
