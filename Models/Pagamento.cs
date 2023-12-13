using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class Pagamento
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Data")]
        public DateOnly DataLimite { get; set; }
        [Display(Name = "Valor")]
        public double Valor { get; set; }
        [Display(Name = "Pago")]
        public bool Pago { get; set; }
    }
}