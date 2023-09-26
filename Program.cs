using Microsoft.EntityFrameworkCore;
using Produtos_API_ASP.NET.Data;
using Produtos_API_ASP.NET.Repository;
using Produtos_API_ASP.NET.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer("Data source=OLOGA_PROGRAMS\\SQLEXPRESS;initial catalog=Sale_System; integrated security=false; User ID=OLOGA_Programs\\EDWIN-OLOGA;Password=;Trusted_Connection=True;TrustServerCertificate=True;"));

builder.Services.AddScoped<IUserRepository, UserRepository>();
var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
