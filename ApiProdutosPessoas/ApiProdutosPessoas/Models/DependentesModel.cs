using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutosPessoas.Models
{
    public class DependentesModel
    {
        [Key]
        public int Id { get; set; }
        public int IdDependente { get; set; }
        public int? PessoaResponsavelId { get; set; }
    }
}
