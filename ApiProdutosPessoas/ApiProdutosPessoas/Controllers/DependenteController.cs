using ApiProdutosPessoas.Models;
using ApiProdutosPessoas.Repositories.Interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ApiProdutosPessoas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DependenteController : ControllerBase
    {
        private readonly InterfaceDependente _dependenteRepositorio;

        public DependenteController(InterfaceDependente dependenteRepositorio)
        {
            _dependenteRepositorio = dependenteRepositorio;
        }

        [HttpPost]
        public async Task<ActionResult<DependentesModel>> AdicionarDependente([FromBody] DependentesModel dependenteModel)
        {
            DependentesModel dependente = await _dependenteRepositorio.AdicionarDependente(dependenteModel);
            return Ok(dependente);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<DependentesModel>> DeletarDependente(int id)
        {
            bool deletar = await _dependenteRepositorio.DeletarDependente(id);
            return Ok(deletar);
        }
    }
}
