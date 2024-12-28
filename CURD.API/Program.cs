
using CURD.DAL.Context;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace CURD.API;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers()
            /*.AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<>())*/;




        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();


        builder.Services.AddDbContext<CURD_DbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("BBB"));
        });


        builder.Services.AddAutoMapper(typeof(Business.Helper.Mapper.AutoMapper));



        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
