using AutoMapper;
using CURD.Business.Services.Interfaces;
using CURD.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business.Services.Implementarions;
public class TagService : ITagService
{
    readonly ITagRepository _repository;
    readonly IMapper _mapper;

    public TagService(IMapper mapper, ITagRepository repository)
    {
        _mapper = mapper;
        _repository = repository;
    }

}
