using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFramework.Configurations
{
	public class GrupoConfiguration : IEntityTypeConfiguration<Grupo>
	{
		public void Configure(EntityTypeBuilder<Grupo> builder)
		{
			builder.ToTable("Grupos", "AmigoSecreto");
			builder.HasKey(g => g.GrupoId);

			builder
				.Property(g => g.GrupoId)
				.UseIdentityColumn()
				.HasColumnName("GrupoId")
				.HasColumnType("int");

			builder
				.Property(g => g.Foto)
				.HasColumnName("Foto")
				.HasColumnType("nvarchar(max)");

			builder
				.Property(g => g.Nome)
				.HasColumnName("Nome")
				.HasColumnType("varchar(100)");

			builder
				.Property(g => g.Quantidade)
				.HasColumnName("Quantidade")
				.HasColumnType("int");

			builder
				.Property(g => g.Valor)
				.HasColumnName("Valor")
				.HasColumnType("money");

			builder
				.Property(g => g.DataRevelacao)
				.HasColumnName("Data")
				.HasColumnType("datetime");

			builder
				.Property(g => g.Descricao)
				.HasColumnName("Descricao")
				.HasColumnType("varchar(150)");


		}
	}
}
