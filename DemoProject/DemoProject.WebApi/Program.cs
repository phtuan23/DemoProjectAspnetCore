using AutoMapper;
using DemoProject.WebApi.Dtos.ProductDto;
using DemoProject.WebApi.Dtos.UserDto;
using DemoProject.WebApi.Models;
using DemoProject.WebApi.Repositories.ProductRepository;
using DemoProject.WebApi.Services.AutoMapper;
using DemoProject.WebApi.Services.PasswordHasher;
using DemoProject.WebApi.Services.ProductService;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseMySql(ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection")));
    option.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"), ServerVersion.Parse("8.0.2"));
});

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AllowNullCollections = true;
    mc.AddGlobalIgnore("Item");
    mc.AddProfile(new AutoMapperProfile());
});

var mapper = mappingConfig.CreateMapper();

builder.Services.AddSingleton(mapper);

builder.Services.AddTransient<DbContext, AppDbContext>();
builder.Services.AddTransient<IProductRepository, ProductRepository>();
builder.Services.AddTransient<IProductService, ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
