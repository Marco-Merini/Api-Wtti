using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Models
{
    public class DependentesModel
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("PessoaPrincipal")]
        public int codPessoaPrincipal { get; set; }
        public PessoaModel PessoaPrincipal { get; set; }

        [ForeignKey("PessoaDependente")]
        public int codPessoaDependente { get; set; }
        public PessoaModel PessoaDependente { get; set; }
    }
}
