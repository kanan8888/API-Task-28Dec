using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Product;
public record GetProductDto
{
    public int Id { get; set; }
    public string ProductName { get; set; }

}

public class GetProductValidator : AbstractValidator<GetProductDto>
{
    public GetProductValidator()
    {
    }
}