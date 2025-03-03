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
    public class ProdutoController : ControllerBase
    {
        private readonly InterfaceProduto _produtoRepositorio;

        public ProdutoController(InterfaceProduto usuarioRepositorio)
        {
            _produtoRepositorio = usuarioRepositorio;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutoModel>>> BuscarTodosProdutos()
        {
            List<ProdutoModel> usuarios = await _produtoRepositorio.BuscarTodosProdutos();
            return Ok(usuarios);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> BuscarIDProduto(int id)
        {
            ProdutoModel usuario = await _produtoRepositorio.BuscarIDProduto(id);
            return Ok(usuario);
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> Registrar([FromBody] ProdutoModel usuarioModel)
        {
            ProdutoModel usuario = await _produtoRepositorio.AdicionarProduto(usuarioModel);
            return Ok(usuario);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PessoaModel>> Atualizar([FromBody] ProdutoModel usuarioModel, int id)
        {
            usuarioModel.Codigo = id;
            ProdutoModel usuario = await _produtoRepositorio.AtualizarProduto(usuarioModel, id);
            return Ok(usuario);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<PessoaModel>> Deletar(int id)
        {
            bool deleted = await _produtoRepositorio.DeletarProduto(id);
            return Ok(deleted);
        }
    }
}
