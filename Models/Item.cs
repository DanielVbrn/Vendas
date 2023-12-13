using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vendas.Models
{
    public class Item
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }
        [Display(Name = "Preco")]
        public double Preco { get; set; }
        [Display(Name = "Percentual")]
        public int Percentual { get; set; }
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }
        public Produto? Produto { get; set; }

    }
}