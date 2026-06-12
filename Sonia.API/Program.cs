using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Application.Services;
using Sonia.Domain.Interfaces.Repositories;
using Sonia.DataAccess.Repositories;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SoniaDbContext>(options =>
{
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IBibliotecaRepository, BibliotecaRepository>();
builder.Services.AddScoped<IAutorRepository, AutorRepository>();
builder.Services.AddScoped<ILibroRepository, LibroRepository>();
builder.Services.AddScoped<IEjemplarRepository, EjemplarRepository>();
builder.Services.AddScoped<IPrestamoRepository, PrestamoRepository>();
builder.Services.AddScoped<IMultaRepository, MultaRepository>();



var app = builder.Build();