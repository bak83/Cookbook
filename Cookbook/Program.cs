using Cookbook;
using Cookbook.Mapper;
using Cookbook.Services;
using Microsoft.EntityFrameworkCore;
using Cookbook.Entities;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(typeof(DishMapper));

builder.Services.AddTransient<IDishRepositiry, DishRepositiry>();
builder.Services.AddControllers();

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
app.UseHttpsRedirection();
app.UseRouting();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});


app.Run();