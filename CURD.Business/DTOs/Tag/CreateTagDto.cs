using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Tag;
public record CreateTagDto
{
    public string TagName { get; set; }

}

public class CreateTagValidator : AbstractValidator<CreateTagDto>
{
    public CreateTagValidator()
    {
        RuleFor(x => x.TagName)
            .NotNull().WithMessage("null ola bilmez")
            .NotEmpty().WithMessage("bos ola bilmez")
            .MinimumLength(3).WithMessage("min uzunluq 3 olmali")
            .MaximumLength(20).WithMessage("max uzunluq 20 olmali");
    }
}