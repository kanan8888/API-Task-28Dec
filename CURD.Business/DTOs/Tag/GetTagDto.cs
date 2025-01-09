using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Tag;
public record GetTagDto
{
    public int Id { get; set; }
    public string TagName { get; set; }

}

public class GetTagValidator : AbstractValidator<GetTagDto>
{
    public GetTagValidator()
    {
    }
}