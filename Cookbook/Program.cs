using Cookbook;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<DbCookBookContext>(builder => {
//	builder.UseSqlServer(@"Data Source=DAREKDESKTOP\MSSQLSERVER01; Initial Catalog=DBCookBook; Integrated Security-True");
//	});

builder.Services.AddDbContext<DbCookBookContext>(
	dbContextOptions => dbContextOptions.UseSqlite(
		builder.Configuration["ConnectionStrings:CookBookDBConnectionString"]));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.Run();