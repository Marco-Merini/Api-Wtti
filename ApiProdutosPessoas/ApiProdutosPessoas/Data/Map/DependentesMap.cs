using ApiProdutosPessoas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Data.Map
{
    public class DependentesMap : IEntityTypeConfiguration<DependentesModel>
    {
        public void Configure(EntityTypeBuilder<DependentesModel> builder)
        {
            builder.HasKey(x => x.codPessoaPrincipal);
            builder.Property(x => x.codPessoaDependente);
        }
    }
}
