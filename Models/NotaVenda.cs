using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Vendas.Models
{
    public class NotaVenda
    {
        [Display(Name = "Código"), Key()]
        public int Id { get; set; }

        [Display(Name = "Data")]
        public DateOnly Data { get; set; }

        [Display(Name = "Tipo")]
        public bool Tipo { get; set; }

        public Cliente? Cliente { get; set; }
        [Display(Name = "Cliente"),Required(), ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        public Vendedor? Vendedor { get; set; }
        [Display(Name = "Vendedor"),Required(), ForeignKey("Vendedor")]
        public int VendedorId { get; set; }
        public Transportadora? Transportadora { get; set; }
        [Display(Name = "Transportadora"),Required(), ForeignKey("Transportadora")]
        public int TransportadoraId { get; set; }

        public ICollection<Item>? Itens { get; set; } = new List<Item>();
        public Pagamento? Pagamento { get; set; }
        [Display(Name = "Pagamento"),Required(), ForeignKey("Pagamento")]
        public int PagamentoId { get; set; }

        public TipoDePagamento? TipoDePagamento { get; set; }
        [Display(Name = "TipoDePagamento"),Required(), ForeignKey("TipoDePagamento")]
        public int TipoDePagamentoId { get; set; }


        public bool Cancelar()
        {
            return true;
        }

        public bool Devolver()
        {
            return true;
        }
    }
}
