using ApiProdutosPessoas.Data.Map;
using ApiProdutosPessoas.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Data
{
    public class ProdutosPessoasdbContext : DbContext
    {
        public ProdutosPessoasdbContext(DbContextOptions<ProdutosPessoasdbContext> options)
            : base(options)
        {
        }

        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<DependentesModel> Dependentes { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
        public DbSet<MarcaModel> Marcas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaModel>()
                .HasOne(p => p.Cidade)
                .WithMany()
                .HasForeignKey(p => p.CodigoCidade)
                .HasPrincipalKey(c => c.codigoIBGE)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new MarcaMap());
            modelBuilder.ApplyConfiguration(new CidadeMap());
            modelBuilder.ApplyConfiguration(new DependenteMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
