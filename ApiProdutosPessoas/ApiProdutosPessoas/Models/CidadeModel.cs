using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Models
{
    public class CidadeModel
    {
        public int codigoIBGE { get; set; }
        public string Nome { get; set; }
        public string UF { get; set; }
        public int CodigoPais { get; set; }
    }
}
