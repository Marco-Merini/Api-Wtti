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
    public class CidadeRepositorio : InterfaceCidade
    {
        private readonly ProdutosPessoasdbContext _dbContext;

        public CidadeRepositorio(ProdutosPessoasdbContext produtosPessoasDBContext)
        {
            _dbContext = produtosPessoasDBContext;
        }

        public async Task<CidadeModel> AdicionarCidade(CidadeModel cidade)
        {
            await _dbContext.Cidades.AddAsync(cidade);
            await _dbContext.SaveChangesAsync();

            return cidade;
        }

        public async Task<CidadeModel> AtualizarCidade(CidadeModel cidade, int id)
        {
            CidadeModel cidadeId = await _dbContext.Cidades.FirstOrDefaultAsync(x => x.codigoIBGE == id);

            if (cidadeId == null)
            {
                throw new Exception($"Cidade para o ID: {id} não foi encontrada no banco de dados.");
            }

            cidadeId.codigoIBGE = cidade.codigoIBGE;
            cidadeId.Nome = cidade.Nome;
            cidadeId.UF = cidade.UF;
            cidadeId.CodigoPais = cidade.CodigoPais;

            _dbContext.Cidades.Update(cidadeId);
            await _dbContext.SaveChangesAsync();

            return cidadeId;
        }


        public async Task<bool> DeletarCidade(int id)
        {
            var cidade = await _dbContext.Cidades.FirstOrDefaultAsync(x => x.codigoIBGE == id);

            if (cidade == null)
            {
                throw new Exception($"Cidade com ID {id} não encontrada.");
            }

            _dbContext.Cidades.Remove(cidade);
            await _dbContext.SaveChangesAsync();

            return true;
        }

    }
}
