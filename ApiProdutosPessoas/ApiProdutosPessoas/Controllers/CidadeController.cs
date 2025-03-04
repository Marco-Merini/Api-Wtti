using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiProdutosPessoas.Repositories.Interfaces;
using ApiProdutosPessoas.Models;

namespace ApiProdutosPessoas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CidadeController : ControllerBase
    {
        private readonly InterfaceCidade _cidadeRepositorio;

        public CidadeController(InterfaceCidade cidadeRepositorio)
        {
            _cidadeRepositorio = cidadeRepositorio;
        }

        [HttpPost]
        public async Task<ActionResult<CidadeModel>> DeletarCidade([FromBody] CidadeModel cidadeModel)
        {
            CidadeModel cidade = await _cidadeRepositorio.AdicionarCidade(cidadeModel);
            return Ok(cidade);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<CidadeModel>> DeletarCidade([FromBody] CidadeModel cidadeModel, int id)
        {
            cidadeModel.codigoIBGE = id;
            CidadeModel cidade = await _cidadeRepositorio.AtualizarCidade(cidadeModel, id);
            return Ok(cidade);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CidadeModel>> DeletarCidade(int id)
        {
            bool deletar = await _cidadeRepositorio.DeletarCidade(id);
            return Ok(deletar);
        }
    }
}

