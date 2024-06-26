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
	public class RecuperarSenhaConfiguration : IEntityTypeConfiguration<RecuperarSenha>
	{
		public void Configure(EntityTypeBuilder<RecuperarSenha> builder)
		{
			builder.ToTable("RecuperarSenha", "AmigoSecreto");
			builder.HasKey(p => p.RecuperarSenhaId);

			builder
				.Property(p => p.RecuperarSenhaId)
				.UseIdentityColumn()
				.HasColumnName("RecuperarSenhaId")
				.HasColumnType("int");

			builder
				.Property(p => p.UsuarioId)
				.HasColumnName("UsuarioId")
				.HasColumnType("int");

			builder
				.HasOne(f => f.Usuario)
				.WithMany()
				.HasForeignKey(f => f.UsuarioId);

			builder
				.Property(p => p.Data)
				.HasColumnName("Data")
				.HasColumnType("datetime");

			builder.HasData(
			new
			{
				RecuperarSenhaId = 1,
				UsuarioId = 1,
				Data = DateTime.Now
			});
		}
	}
}
