using ApiProdutosPessoas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiProdutosPessoas.Data.Map
{
    public class DependentesMap : IEntityTypeConfiguration<DependentesModel>
    {
        public void Configure(EntityTypeBuilder<DependentesModel> builder)
        {
            builder.ToTable("Dependentes");

            builder.HasKey(d => d.Id);


            builder.HasOne(d => d.PessoaPrincipal)
                .WithMany(p => p.Dependentes)
                .HasForeignKey(d => d.codPessoaPrincipal)
                .OnDelete(DeleteBehavior.Restrict);


            builder.HasOne(d => d.PessoaDependente)
                .WithMany()
                .HasForeignKey(d => d.codPessoaDependente)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
