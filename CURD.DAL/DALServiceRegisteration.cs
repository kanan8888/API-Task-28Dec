using CURD.DAL.Repositories.Implementations;
using CURD.DAL.Repositories.Implementations.Generic;
using CURD.DAL.Repositories.Interfaces;
using CURD.DAL.Repositories.Interfaces.Generic;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.DAL;
public static class DALServiceRegisteration
{
    public static void AddDALService(this IServiceCollection service)
    {
        service.AddScoped<ICategoryRepository , CategoryRepository>();
        service.AddScoped<ITagRepository , TagRepository>();
        service.AddScoped<IProductRepository , ProductRepository>();
        service.AddScoped<IBlogRepository , BlogRepository>();
    }
}   


