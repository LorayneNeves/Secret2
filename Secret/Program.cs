using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Application.AutoMapper;
using Application.Interfaces;
using Application.Services;
using Data.EntityFramework;
using Data.Repositories;
using Domain.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddRouting(options => options.LowercaseUrls = true);
builder.Services.AddDbContext<Context>((serviceProvider, options) =>
{
	var configuration = serviceProvider.GetRequiredService<IConfiguration>();
	var connectionString = configuration.GetConnectionString("ConnectionString");
	options.UseSqlServer(connectionString);
});
builder.Services.AddAutoMapper(typeof(DomainToApplication), typeof(ApplicationToDomain));
builder.Services.AddScoped<IGrupoRepository, GrupoRepository>();
builder.Services.AddScoped<IGrupoService, GrupoService>();
builder.Services.AddScoped<IGrupoUsuarioRepository, GrupoUsuarioRepository>();
builder.Services.AddScoped<IGrupoUsuarioService, GrupoUsuarioService>();
builder.Services.AddScoped<ILoginRepository, LoginRepository>();
builder.Services.AddScoped<ILoginService, LoginService>();
builder.Services.AddScoped<IUsuarioRepository, UsuarioRepository>();
builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<IRecuperarSenhaRepository, RecuperarSenhaRepository>();
builder.Services.AddScoped<IRecuperarSenhaService, RecuperarSenhaService>();

var app = builder.Build();

app.UseRouting();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseEndpoints(endpoints =>
{
	endpoints.MapControllers();
});

app.Run();
