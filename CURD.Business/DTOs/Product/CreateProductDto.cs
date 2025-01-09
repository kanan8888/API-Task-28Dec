using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Product;
public record CreateProductDto
{
    public string ProductName { get; set; }
}

public class CreateProductValidator : AbstractValidator<CreateProductDto>
{
    public CreateProductValidator()
    {
        RuleFor(x => x.ProductName)
            .NotNull().WithMessage("null ola bilmez")
            .NotEmpty().WithMessage("bos ola bilmez")
            .MinimumLength(3).WithMessage("min uzunluq 3 olmali")
            .MaximumLength(20).WithMessage("max uzunluq 20 olmali");
    }
}
