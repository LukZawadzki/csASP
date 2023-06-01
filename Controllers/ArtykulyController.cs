using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcPracownik.Models;
using csASP.Data;

namespace csASP.Controllers
{
    public class ArtykulyController : Controller
    {
        private readonly BazaContext _context;

        public ArtykulyController(BazaContext context)
        {
            _context = context;
        }

        // GET: Artykuly
        public async Task<IActionResult> Index()
        {
              return _context.Artykul != null ? 
                          View(await _context.Artykul.ToListAsync()) :
                          Problem("Entity set 'BazaContext.Artykul'  is null.");
        }

        // GET: Artykuly/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Artykul == null)
            {
                return NotFound();
            }

            var artykul = await _context.Artykul
                .FirstOrDefaultAsync(m => m.idpudelka == id);
            if (artykul == null)
            {
                return NotFound();
            }

            return View(artykul);
        }

        // GET: Artykuly/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Artykuly/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sztuk,idzamowienia,idpudelka")] Artykul artykul)
        {
            if (ModelState.IsValid)
            {
                _context.Add(artykul);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(artykul);
        }

        // GET: Artykuly/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Artykul == null)
            {
                return NotFound();
            }

            var artykul = await _context.Artykul.FindAsync(id);
            if (artykul == null)
            {
                return NotFound();
            }
            return View(artykul);
        }

        // POST: Artykuly/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("sztuk,idzamowienia,idpudelka")] Artykul artykul)
        {
            if (id != artykul.idpudelka)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(artykul);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArtykulExists(artykul.idpudelka))
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
            return View(artykul);
        }

        // GET: Artykuly/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Artykul == null)
            {
                return NotFound();
            }

            var artykul = await _context.Artykul
                .FirstOrDefaultAsync(m => m.idpudelka == id);
            if (artykul == null)
            {
                return NotFound();
            }

            return View(artykul);
        }

        // POST: Artykuly/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Artykul == null)
            {
                return Problem("Entity set 'BazaContext.Artykul'  is null.");
            }
            var artykul = await _context.Artykul.FindAsync(id);
            if (artykul != null)
            {
                _context.Artykul.Remove(artykul);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArtykulExists(string id)
        {
          return (_context.Artykul?.Any(e => e.idpudelka == id)).GetValueOrDefault();
        }
    }
}
