using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Product;
public record UpdateProductDto
{
    public int Id { get; set; }
    public string ProductName { get; set; }

}

public class UpdateProductValidator : AbstractValidator<UpdateProductDto>
{
    public UpdateProductValidator()
    {
        RuleFor(x => x.Id)
            .NotNull().WithMessage("id null ola bilmez")
            .NotEmpty().WithMessage("id bos ola bilmez")
            .GreaterThan(0).WithMessage("0 dan boyuk olmali");
        RuleFor(x => x.ProductName)
            .NotNull().WithMessage("name null ola bilmez")
            .NotEmpty().WithMessage("name bos ola bilmez")
            .MinimumLength(3).WithMessage("min uzunluq 3 olmali")
            .MaximumLength(20).WithMessage("max uzunluq 20 olmali");
    }
}