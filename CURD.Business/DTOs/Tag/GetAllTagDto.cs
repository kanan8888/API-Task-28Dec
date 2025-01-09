using CURD.Business.DTOs.Category;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Tag;
public record GetAllTagDto
{
    ICollection<GetTagDto> Tags { get; set; }   

}

public class GetAllTagValidator : AbstractValidator<GetAllTagDto>
{
    public GetAllTagValidator()
    {
    }
}