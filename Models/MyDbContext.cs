using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Vendas.Models;

namespace Vendas.Models
{
    public class MyDbContext:DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options){}
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<NotaVenda> NotaVendas { get; set; }
        public DbSet<Vendedor> Vendedors { get; set; }
        public DbSet<Transportadora> Transportadoras { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Vendas.Models.TipoDePagamento> TipoDePagamento { get; set; }
        public DbSet<Vendas.Models.Item> Item { get; set; }
        public DbSet<Vendas.Models.Marca> Marca { get; set; }



    }
}