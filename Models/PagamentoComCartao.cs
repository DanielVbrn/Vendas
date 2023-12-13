using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class PagamentoComCartao:TipoDePagamento
    {
        [Display(Name = "Numero do Cartão")]
        public string? NumeroDoCartao { get; set; }
        [Display(Name = "Bandeira do Cartão")]
        public string? Bandeira { get; set; }
    }
}