using AplicacionesMoviles.WebApi.Entidades;
using AplicacionesMoviles.WebApi.Implementaciones.Repositorios;
using AplicacionesMoviles.WebApi.Implementaciones.Servicios;
using AplicacionesMoviles.WebApi.Interfaces.Repositorios;
using AplicacionesMoviles.WebApi.Interfaces.Servicios;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<BaseDatosContext>(options =>options.UseSqlServer(builder.Configuration.GetConnectionString("conexion")));
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(IRepositorioBase<>), typeof(RepositorioBase<>));
builder.Services.AddScoped<IServicioTecnico, ServicioTecnico>();
builder.Services.AddScoped<IServicioReporte, ServicioReporte>();

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
