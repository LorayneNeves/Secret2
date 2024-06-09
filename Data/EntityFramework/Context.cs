using Data.EntityFramework.Configurations;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;


namespace Data.EntityFramework
{
	public class Context : Microsoft.EntityFrameworkCore.DbContext
	{
		private readonly IConfiguration _configuration;
		public Microsoft.EntityFrameworkCore.DbSet<Usuario> Usuario { get; set; }
		public Microsoft.EntityFrameworkCore.DbSet<Grupo> Grupo { get; set; }
		public Microsoft.EntityFrameworkCore.DbSet<Login> Login { get; set; }
		public Microsoft.EntityFrameworkCore.DbSet<GrupoUsuario> GrupoUsuario { get; set; }
		public Microsoft.EntityFrameworkCore.DbSet<RecuperarSenha> RecuperarSenha { get; set; }
		public Context(DbContextOptions<Context> options, IConfiguration configuration) : base(options)
		{
			_configuration = configuration;
		}
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer(@"Data source = 201.62.57.93, 1434; 
                                    Database = BD044860; 
                                    User ID = RA044860; 
                                    Password = 044860;
                                    TrustServerCertificate=True"
			);

		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
			modelBuilder.ApplyConfiguration(new GrupoConfiguration());
			modelBuilder.ApplyConfiguration(new LoginConfiguration());
			modelBuilder.ApplyConfiguration(new GrupoUsuarioConfiguration());
			modelBuilder.ApplyConfiguration(new RecuperarSenhaConfiguration());
			base.OnModelCreating(modelBuilder);
		}
		
	}
}

