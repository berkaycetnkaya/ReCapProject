using Autofac;
using Autofac.Core;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolvers.Autofac;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Core.Utilities.Security.Encryption;
using Microsoft.IdentityModel.Tokens;
using Core.Utilities.IoC;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// icinde data tutmuyorsaniz yapabilirsinzi sepetleri farkli yolla yaparsin herkesin sepeti ayni guzukur
// javadaki being configurasyonu
//bunu isterse bunu newle onu ver  kac tane istek gelirse ona ayni referansi veriyor
//********************
//builder.Services.AddSingleton<ICarService,CarManager>();
//builder.Services.AddSingleton<ICarDal, EfCarDal>();
//************************
// autofac, ninject,castlewindsor,structuremap, lightinject, dryinject ==> IoC container
// sadece injection yapiyor olsaydik ama AOP yapacak, butun methodlari loglarsan yapamzsin
// AOP sunuyor autofac 
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutoBusinessModule());
});

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>(); 
var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });
//ServiceTool.Create(services);
builder.Services.AddDependencyResolvers();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();   

app.UseAuthentication();
app.UseAuthorization();
   

app.MapControllers();

app.Run();
