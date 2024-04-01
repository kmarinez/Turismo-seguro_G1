using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using capaDatos.Database;

namespace TurismoSeguro.Controllers
{
    public class PaisController : Controller
    {
        private readonly TurismoSeguroContext _context;

        public PaisController(TurismoSeguroContext context)
        {
            _context = context;
        }

        // GET: Pais
        public async Task<IActionResult> Index()
        {
              return _context.TmPais != null ? 
                          View(await _context.TmPais.ToListAsync()) :
                          Problem("Entity set 'TurismoSeguroContext.TmPais'  is null.");
        }

        // GET: Pais/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TmPais == null)
            {
                return NotFound();
            }

            var tmPai = await _context.TmPais
                .FirstOrDefaultAsync(m => m.PaisId == id);
            if (tmPai == null)
            {
                return NotFound();
            }

            return View(tmPai);
        }

        // GET: Pais/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PaisId,Nombre")] TmPai tmPai)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tmPai);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tmPai);
        }

        // GET: Pais/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TmPais == null)
            {
                return NotFound();
            }

            var tmPai = await _context.TmPais.FindAsync(id);
            if (tmPai == null)
            {
                return NotFound();
            }
            return View(tmPai);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PaisId,Nombre")] TmPai tmPai)
        {
            if (id != tmPai.PaisId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tmPai);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TmPaiExists(tmPai.PaisId))
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
            return View(tmPai);
        }

        // GET: Pais/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TmPais == null)
            {
                return NotFound();
            }

            var tmPai = await _context.TmPais
                .FirstOrDefaultAsync(m => m.PaisId == id);
            if (tmPai == null)
            {
                return NotFound();
            }

            return View(tmPai);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TmPais == null)
            {
                return Problem("Entity set 'TurismoSeguroContext.TmPais'  is null.");
            }
            var tmPai = await _context.TmPais.FindAsync(id);
            if (tmPai != null)
            {
                _context.TmPais.Remove(tmPai);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TmPaiExists(int id)
        {
          return (_context.TmPais?.Any(e => e.PaisId == id)).GetValueOrDefault();
        }
    }
}
