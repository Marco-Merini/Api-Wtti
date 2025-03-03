using ApiProdutosPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Repositories.Interfaces
{
    public interface InterfaceProduto
    {
        Task<List<ProdutoModel>> BuscarTodosProdutos();
        Task<ProdutoModel> BuscarIDProduto(int id);
        Task<ProdutoModel> AdicionarProduto(ProdutoModel usuario);
        Task<ProdutoModel> AtualizarProduto(ProdutoModel usuario, int id);
        Task<bool> DeletarProduto(int id);
    }
}
