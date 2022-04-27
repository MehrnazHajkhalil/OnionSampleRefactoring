using Microsoft.EntityFrameworkCore;
using OnionSample.Infra.data.Ef.Sql.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<CourseStoreDbContext>(c => c.UseSqlServer("Data Source=.;Initial Catalog=CourseDb;Persist Security Info=True;Integrated Security=true;"));
//builder.Services.AddScoped<CourseServices>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
