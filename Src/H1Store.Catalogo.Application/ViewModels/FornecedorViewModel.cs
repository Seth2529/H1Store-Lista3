using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
    public class FornecedorViewModel
    {
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string RazaoSocial { get; set; }
        [Required]
        public string CNPJ { get; set; }
        [Required]
        public bool Ativo { get; set; }
        [Required]
        public DateTime DataCadastro { get; set; }
        [Required]
        public string EmailContato { get; set; }
    }
}
