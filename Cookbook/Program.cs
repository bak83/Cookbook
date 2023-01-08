using Cookbook;
using Cookbook.Mapper;
using Cookbook.Services;
using Microsoft.EntityFrameworkCore;
using Cookbook.Entities;
using Cookbook.Middleware;
using FluentValidation.AspNetCore;
using FluentValidation;
using Cookbook.Models;
using Cookbook.Models.Validators;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();
builder.Logging.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);
builder.Host.UseNLog();
builder.Services.AddAutoMapper(typeof(DishMapper));

builder.Services.AddTransient<IDishRepositiry, DishRepositiry>();
builder.Services.AddControllers().AddFluentValidation();
builder.Services.AddScoped<ErrorHandlingMiddleware>();
builder.Services.AddScoped<IValidator<DishAddDto>, DishAddDtoValidator>();

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<CookBookDbContext>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}
app.UseMiddleware<ErrorHandlingMiddleware>();
app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});


app.Run();