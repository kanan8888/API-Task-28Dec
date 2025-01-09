using AutoMapper;
using CURD.Business.Services.Interfaces;
using CURD.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Services.Implementarions;
public class CategoryService : ICategoryService
{
    readonly ICategoryRepository _repository;
    readonly IMapper _mapper;

    public CategoryService(ICategoryRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    

}
