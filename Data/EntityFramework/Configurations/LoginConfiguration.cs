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
	public class LoginConfiguration : IEntityTypeConfiguration<Login>
	{
		public void Configure(EntityTypeBuilder<Login> builder)
		{
			builder.ToTable("Login", "AmigoSecreto");
			builder.HasKey(p => p.LoginId);

			builder
				.Property(p => p.LoginId)
				.UseIdentityColumn()
				.HasColumnName("LoginId")
				.HasColumnType("int");

			builder
				.Property(p => p.Email)
				.HasColumnName("Email")
				.HasColumnType("varchar(100)");

			builder
				.Property(p => p.Senha)
				.HasColumnName("Senha")
				.HasColumnType("varchar(200)");
		}
	}
}
