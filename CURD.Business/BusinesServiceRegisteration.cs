using CURD.Business.Services.Implementarions;
using CURD.Business.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD.Business;
public static class BusinesServiceRegisteration
{
    public static void AddBusinessService(this IServiceCollection service)
    {
        service.AddAutoMapper(typeof(BusinesServiceRegisteration));

        service.AddScoped<ICategoryService , CategoryService>();
        service.AddScoped<IProductService , ProductService>();
        service.AddScoped<ITagService , TagService>();
        service.AddScoped<IUserService , UserService>();
    }
}
