using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.User;
public record RegisterDTO
{
    public string Name { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string ConfirmPassword { get; set; }

}

public class RegisterDTOValidator : AbstractValidator<RegisterDTO>
{
    public RegisterDTOValidator()
    {
        RuleFor(x => x.Name)
            .NotNull()
            .NotEmpty()
            .MinimumLength(3)
            .MaximumLength(50);
        RuleFor(x => x.UserName)
            .NotNull()
            .NotEmpty()
            .MinimumLength(4)
            .MaximumLength(50);
        RuleFor(x => x.Email)
            .NotNull()
            .NotEmpty()
            .Must(x => 
            {
                Regex regex = new Regex("/^([a-z0-9_\\.-]+)@([\\da-z\\.-]+)\\.([a-z\\.]{2,6})$/g");
                var math = regex.Match(x);
                return math.Success;
            });
        RuleFor(x => x.Password)
            .NotNull()
            .NotEmpty()
            .MinimumLength(6)
            .MaximumLength(50);
        RuleFor(x => x)
            .Must(x => x.Password == x.ConfirmPassword);
    }
}
