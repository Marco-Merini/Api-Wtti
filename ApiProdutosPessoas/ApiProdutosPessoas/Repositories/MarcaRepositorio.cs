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
    public class MarcaRepositorio : InterfaceMarca
    {
        private readonly ProdutosPessoasdbContext _dbContext;

        public MarcaRepositorio(ProdutosPessoasdbContext produtosPessoasDBContext)
        {
            _dbContext = produtosPessoasDBContext;
        }

        public async Task<bool> DeletarMarca(int id)
        {
            var marca = await _dbContext.Marcas.FirstOrDefaultAsync(x => x.Codigo == id);

            if (marca == null)
            {
                throw new Exception($"Marca com ID {id} não encontrada.");
            }

            _dbContext.Marcas.Remove(marca);
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
