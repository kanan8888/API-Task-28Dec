using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Category;
public record GetAllCategoriesDto
{
    ICollection<GetCategoryDto> Categories { get; set; }

}

public class GetAllCategoriesValidator : AbstractValidator<GetAllCategoriesDto>
{
    public GetAllCategoriesValidator()
    {
    }
}
