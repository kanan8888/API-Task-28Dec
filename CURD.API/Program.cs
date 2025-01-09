
using CURD.Business;
using CURD.Business.DTOs.Category;
using CURD.Core.Entityes;
using CURD.DAL;
using CURD.DAL.Context;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Reflection;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace CURD.API;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers()
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<CreateCategoryValidator>());    //onemli


        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();






        builder.Services.AddDbContext<CURD_DbContext>(opt =>
        {
            opt.UseSqlServer(builder.Configuration.GetConnectionString("BBB"));
        });

        builder.Services.AddIdentity<AppUser, IdentityRole>(opt => 
        {
            opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789_";
            opt.Password.RequireNonAlphanumeric= false;
            opt.Password.RequiredLength = 6;
        }).AddEntityFrameworkStores<CURD_DbContext>().AddDefaultTokenProviders();

        builder.Services.AddAuthentication(opt => 
        {
            opt.DefaultAuthenticateScheme=JwtBearerDefaults.AuthenticationScheme;
            opt.DefaultChallengeScheme=JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(opt =>
        {
            opt.TokenValidationParameters = new TokenValidationParameters()
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateIssuerSigningKey = true,

                ValidIssuer = builder.Configuration["Jwt:Issuer"],
                ValidAudience = builder.Configuration["Jwt:Audience"],

                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecurityKey"]))
            };
        });


        //builder.Services.AddAutoMapper(typeof(Business.Helper.Mapper.AutoMapper));
        builder.Services.AddBusinessService();
        builder.Services.AddDALService();                                                 //onemli


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseExceptionHandler(exceptionHandlerApp =>
        {
            exceptionHandlerApp.Run(async context =>
            {
                context.Response.StatusCode = 500;

                context.Response.ContentType = Text.Plain;

                await context.Response.WriteAsync("An exception was thrown");

                var feature =
                    context.Features.Get<IExceptionHandlerPathFeature>();

                if (feature?.Error is FileNotFoundException)
                {
                    await context.Response.WriteAsync(" The file was not found");
                }

                if (feature?.Path == "/")
                {
                    await context.Response.WriteAsync(" Page: Home.");
                }

            });

        });



        app.UseHttpsRedirection();
        app.UseAuthentication();
        app.UseAuthorization();
        app.MapControllers();

        app.Run();
    }
}
