using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// icinde data tutmuyorsaniz yapabilirsinzi sepetleri farkli yolla yaparsin herkesin sepeti ayni guzukur
// javadaki being configurasyonu
//bunu isterse bunu newle onu ver  kac tane istek gelirse ona ayni referansi veriyor
builder.Services.AddSingleton<ICarService,CarManager>();
builder.Services.AddSingleton<ICarDal, EfCarDal>();
// autofac, ninject,castlewindsor,structuremap, lightinject, dryinject ==> IoC container
// sadece injection yapiyor olsaydik ama AOP yapacak, butun methodlari loglarsan yapamzsin
// AOP sunuyor autofac 

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
