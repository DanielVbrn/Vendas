using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class Marca
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string? Nome { get; set; }
        [Display(Name = "Descrição")]
        public string? Descricao { get; set; }

    }
}