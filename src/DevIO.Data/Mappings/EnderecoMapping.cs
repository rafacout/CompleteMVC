using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Enderecos");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.Numero)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(a => a.Cep)
                .IsRequired()
                .HasColumnType("varchar(8)");

            builder.Property(a => a.Complemento)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(a => a.Bairro)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(a => a.Estado)
                .IsRequired()
                .HasColumnType("varchar(50)");
        }
    }
}
