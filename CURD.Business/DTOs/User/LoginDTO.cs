using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.User;
public record LoginDTO
{
    public string UserNameOrEmail { get; set; } 
    public string Password { get; set; }
}
public class LofinDTOValidation : AbstractValidator<LoginDTO>
{
    public LofinDTOValidation()
    {
        RuleFor(x => x.UserNameOrEmail)
            .NotEmpty()
            .NotNull();
        RuleFor(x => x.Password)
            .NotEmpty()
            .NotNull()
            .MinimumLength(6)
            .WithMessage("Password uzunlugu 6 dan az olmamalidir");
    }
}
