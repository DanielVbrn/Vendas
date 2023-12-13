using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class TipoDePagamento
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Nome")]
        public string? NomeDoCobrador { get; set; }
        [Display(Name = "Informações")]
        public string? InformacoesAdicionais { get; set; }

    }
}