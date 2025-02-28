using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Models
{
    public class PessoaModel
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
        public object Cidade { get; set; }
        public string Logradouro { get; set; }
        public int NumeroEstabelecimento { get; set; }
        public string Bairro { get; set; }
        public string CEP { get; set; }
        public List<PessoaModel> Dependentes { get; set; } = new List<PessoaModel>();
    }
}
