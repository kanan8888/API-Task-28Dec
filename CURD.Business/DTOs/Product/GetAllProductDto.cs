using CURD.Business.DTOs.Category;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Product;
public record GetAllProductDto
{
    ICollection<GetProductDto> Products { get; set; }   

}

public class GetAllProductValidator : AbstractValidator<GetAllProductDto>
{
    public GetAllProductValidator()
    {
    }
}