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
        public DbSet<ProdutoModel> Marcas { get; set; }
        //public DbSet<PessoaModel> Produto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<PessoaModel>().HasOne(v => v.Cidade).WithMany().HasForeignKey(v => v.CodigoCidade);
            modelBuilder.Entity<PessoaModel>()
                .HasOne(p => p.Cidade) // Pessoa tem UMA cidade
                .WithMany() // Cidade pode estar associada a várias pessoas
                .HasForeignKey(p => p.CodigoCidade) // Define a chave estrangeira
                .HasPrincipalKey(c => c.codigoIBGE) // Referência a chave primária da CidadeModel
                .OnDelete(DeleteBehavior.Restrict); // Impede deleção em cascata

            modelBuilder.Entity<DependentesModel>()
                .HasOne(d => d.PessoaPrincipal)
                .WithMany()
                .HasForeignKey(d => d.codPessoaPrincipal)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DependentesModel>()
                .HasOne(d => d.PessoaDependente)
                .WithMany()
                .HasForeignKey(d => d.codPessoaDependente)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.ApplyConfiguration(new PessoaMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            //modelBuilder.ApplyConfiguration(new ProdutoMap());
            //modelBuilder.ApplyConfiguration(new ProdutoMap());
            //modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
