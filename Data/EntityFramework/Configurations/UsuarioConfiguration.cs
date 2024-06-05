using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFramework.Configurations
{
	public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
	{
		public void Configure(EntityTypeBuilder<Usuario> builder)
		{
			builder.ToTable("Usuario", "AmigoSecreto");
			builder.HasKey(f => f.UsuarioId);

			builder
				.Property(f => f.UsuarioId)
				.UseIdentityColumn()
				.HasColumnName("UsuarioId")
				.HasColumnType("int");

			builder
			   .Property(f => f.Nome)
			   .HasColumnName("Nome")
			   .HasColumnType("varchar(200)");


			builder
				.Property(f => f.Email)
				.HasColumnName("Email")
				.HasColumnType("varchar(100)");

			builder
				.Property(f => f.Senha)
				.HasColumnName("Senha")
				.HasColumnType("varchar(200)");

			builder
				.Property(f => f.Foto)
				.HasColumnName("Foto")
				.HasColumnType("nvarchar(max)");


		}
	}
}
