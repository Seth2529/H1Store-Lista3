using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Store.Catalogo.Application.ViewModels
{
    public class NovaCategoriaViewModel
    {
        [Required]
        public int Codigo { get; set; }
        [Required]
        public string Descricao { get; set; }
    }
}
