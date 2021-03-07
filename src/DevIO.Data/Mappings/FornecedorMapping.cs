using DevIO.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevIO.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.ToTable("Fornecedores");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(a => a.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            /*EF One to One. Usually EF make this automatically, but it's recomended to map this manually*/
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Fornecedor);

            /*EF One to Many*/
            builder.HasMany(f => f.Produtos)
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(p => p.FornecedorId);
        }
    }
}
