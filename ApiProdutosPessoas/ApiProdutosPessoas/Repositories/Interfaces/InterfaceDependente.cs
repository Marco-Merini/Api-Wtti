using ApiProdutosPessoas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Repositories.Interfaces
{
    public interface InterfaceDependente
    {
        Task<DependentesModel> AdicionarDependente(DependentesModel dependente);
        Task<bool> DeletarDependente(int id);
    }
}
