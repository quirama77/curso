using Microsoft.EntityFrameworkCore;
using UniversityApiBackend.DataAccess;
var builder = WebApplication.CreateBuilder(args);

// conexion con la base de datos

const string Conectionname = "UniversityDB";
var connectionString = builder.Configuration.GetConnectionString(Conectionname);

//add  context

builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connectionString));


// Add services to the container.

builder.Services.AddControllers();
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
