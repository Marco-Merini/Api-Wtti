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
    public class MarcaController : ControllerBase
    {
        private readonly InterfaceMarca _marcaRepositorio;

        public MarcaController(InterfaceMarca marcaRepositorio)
        {
            _marcaRepositorio = marcaRepositorio;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<MarcaModel>> DeletarMarca(int id)
        {
            bool deletar = await _marcaRepositorio.DeletarMarca(id);
            return Ok(deletar);
        }
    }
}
