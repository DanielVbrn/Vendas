using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class PagamentoComCheque:TipoDePagamento
    {
        [Display(Name = "Número da Conta")]
        public int Banco { get; set; }
        [Display(Name = "Nome do Banco")]
        public string? NomeDoBanco { get; set; }
    }
}