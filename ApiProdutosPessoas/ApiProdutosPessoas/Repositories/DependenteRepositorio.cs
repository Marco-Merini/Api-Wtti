using ApiProdutosPessoas.Data;
using ApiProdutosPessoas.Models;
using ApiProdutosPessoas.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Repositories
{
    public class DependenteRepositorio : InterfaceDependente
    {
        private readonly ProdutosPessoasdbContext _dbContext;

        public DependenteRepositorio(ProdutosPessoasdbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
