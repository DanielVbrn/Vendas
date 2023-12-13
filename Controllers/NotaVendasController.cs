#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Vendas.Models;

namespace Vendas.Controllers
{
    public class NotaVendasController : Controller
    {
        private readonly MyDbContext _context;

        public NotaVendasController(MyDbContext context)
        {
            _context = context;
        }

        // GET: NotaVendas
        public async Task<IActionResult> Index()
        {
            var myDbContext = _context.NotaVendas.Include(n => n.Cliente).Include(n => n.Pagamento).Include(n => n.TipoDePagamento).Include(n => n.Transportadora).Include(n => n.Vendedor);
            return View(await myDbContext.ToListAsync());
        }

        // GET: NotaVendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaVenda = await _context.NotaVendas
                .Include(n => n.Cliente)
                .Include(n => n.Pagamento)
                .Include(n => n.TipoDePagamento)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaVenda == null)
            {
                return NotFound();
            }

            return View(notaVenda);
        }

        // GET: NotaVendas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id");
            ViewData["PagamentoId"] = new SelectList(_context.Set<Pagamento>(), "Id", "Id");
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TipoDePagamento, "Id", "Id");
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id");
            ViewData["VendedorId"] = new SelectList(_context.Vendedors, "Id", "Id");
            return View();
        }

        // POST: NotaVendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Data,Tipo,ClienteId,VendedorId,TransportadoraId,PagamentoId,TipoDePagamentoId")] NotaVenda notaVenda)
        {
            if (ModelState.IsValid)
            {
                _context.Add(notaVenda);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", notaVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Set<Pagamento>(), "Id", "Id", notaVenda.PagamentoId);
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TipoDePagamento, "Id", "Id", notaVenda.TipoDePagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id", notaVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedors, "Id", "Id", notaVenda.VendedorId);
            return View(notaVenda);
        }

        // GET: NotaVendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaVenda = await _context.NotaVendas.FindAsync(id);
            if (notaVenda == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", notaVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Set<Pagamento>(), "Id", "Id", notaVenda.PagamentoId);
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TipoDePagamento, "Id", "Id", notaVenda.TipoDePagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id", notaVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedors, "Id", "Id", notaVenda.VendedorId);
            return View(notaVenda);
        }

        // POST: NotaVendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Data,Tipo,ClienteId,VendedorId,TransportadoraId,PagamentoId,TipoDePagamentoId")] NotaVenda notaVenda)
        {
            if (id != notaVenda.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(notaVenda);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NotaVendaExists(notaVenda.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Clientes, "Id", "Id", notaVenda.ClienteId);
            ViewData["PagamentoId"] = new SelectList(_context.Set<Pagamento>(), "Id", "Id", notaVenda.PagamentoId);
            ViewData["TipoDePagamentoId"] = new SelectList(_context.TipoDePagamento, "Id", "Id", notaVenda.TipoDePagamentoId);
            ViewData["TransportadoraId"] = new SelectList(_context.Transportadoras, "Id", "Id", notaVenda.TransportadoraId);
            ViewData["VendedorId"] = new SelectList(_context.Vendedors, "Id", "Id", notaVenda.VendedorId);
            return View(notaVenda);
        }

        // GET: NotaVendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var notaVenda = await _context.NotaVendas
                .Include(n => n.Cliente)
                .Include(n => n.Pagamento)
                .Include(n => n.TipoDePagamento)
                .Include(n => n.Transportadora)
                .Include(n => n.Vendedor)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (notaVenda == null)
            {
                return NotFound();
            }

            return View(notaVenda);
        }

        // POST: NotaVendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var notaVenda = await _context.NotaVendas.FindAsync(id);
            _context.NotaVendas.Remove(notaVenda);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NotaVendaExists(int id)
        {
            return _context.NotaVendas.Any(e => e.Id == id);
        }
    }
}
