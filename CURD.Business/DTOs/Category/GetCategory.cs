using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.DTOs.Category;
public class GetCategory
{
    public int Id { get; set; }
    public string CategoryName { get; set; }

}

public class GetCategoryValidator : AbstractValidator<GetCategory>
{

}
