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
	internal class GrupoUsuarioConfiguration : IEntityTypeConfiguration<GrupoUsuario>
	{
		public void Configure(EntityTypeBuilder<GrupoUsuario> builder)
		{
			builder.ToTable("MembrosGrupo", "AmigoSecreto");
			builder.HasKey(f => new{f.UsuarioId, f.GrupoId});


			builder
				.Property(f => f.GrupoId)
				.HasColumnName("GrupoId")
				.HasColumnType("int");

			builder
				.HasOne(f => f.Grupo)
				.WithMany()
				.HasForeignKey(f => f.GrupoId);

			builder
				.Property(f => f.UsuarioId)
				.HasColumnName("UsuarioId")
				.HasColumnType("int");

            builder.HasOne(gu => gu.Usuario)
               .WithMany(u => u.GrupoUsuarios)
               .HasForeignKey(gu => gu.UsuarioId);

            builder.HasOne(gu => gu.Grupo)
               .WithMany(g => g.GrupoUsuarios)
               .HasForeignKey(gu => gu.GrupoId);

        }
	}
	
}
