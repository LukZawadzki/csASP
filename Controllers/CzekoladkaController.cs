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
    public class CzekoladkaController : Controller
    {
        private readonly BazaContext _context;

        public CzekoladkaController(BazaContext context)
        {
            _context = context;
        }

        // GET: Czekoladka
        public async Task<IActionResult> Index()
        {
              return _context.Czekoladka != null ? 
                          View(await _context.Czekoladka.ToListAsync()) :
                          Problem("Entity set 'BazaContext.Czekoladka'  is null.");
        }

        // GET: Czekoladka/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Czekoladka == null)
            {
                return NotFound();
            }

            var czekoladka = await _context.Czekoladka
                .FirstOrDefaultAsync(m => m.idczekoladki == id);
            if (czekoladka == null)
            {
                return NotFound();
            }

            return View(czekoladka);
        }

        // GET: Czekoladka/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Czekoladka/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idczekoladki,nazwa,czekolada,orzechy,nadzienie,opis,koszt,masa")] Czekoladka czekoladka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(czekoladka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(czekoladka);
        }

        // GET: Czekoladka/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Czekoladka == null)
            {
                return NotFound();
            }

            var czekoladka = await _context.Czekoladka.FindAsync(id);
            if (czekoladka == null)
            {
                return NotFound();
            }
            return View(czekoladka);
        }

        // POST: Czekoladka/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("idczekoladki,nazwa,czekolada,orzechy,nadzienie,opis,koszt,masa")] Czekoladka czekoladka)
        {
            if (id != czekoladka.idczekoladki)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(czekoladka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CzekoladkaExists(czekoladka.idczekoladki))
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
            return View(czekoladka);
        }

        // GET: Czekoladka/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Czekoladka == null)
            {
                return NotFound();
            }

            var czekoladka = await _context.Czekoladka
                .FirstOrDefaultAsync(m => m.idczekoladki == id);
            if (czekoladka == null)
            {
                return NotFound();
            }
            
            var zawartosc = _context.Artykul.Any(z => z.idczekoladki.Equals(czekoladka.idczekoladki));
            if(zawartosc){
                ModelState.AddModelError(string.Empty, "Nie można usunąć czekoladki, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            return View(czekoladka);
        }

        // POST: Czekoladka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Czekoladka == null)
            {
                return Problem("Entity set 'BazaContext.Czekoladka'  is null.");
            }
            var czekoladka = await _context.Czekoladka.FindAsync(id);
            if (czekoladka != null)
            {
                _context.Czekoladka.Remove(czekoladka);
            }
            
            var zawartosc = _context.Artykul.Any(z => z.idczekoladki.Equals(czekoladka.idczekoladki));
            if(zawartosc){
                ModelState.AddModelError(string.Empty, "Nie można usunąć czekoladki, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CzekoladkaExists(string id)
        {
          return (_context.Czekoladka?.Any(e => e.idczekoladki == id)).GetValueOrDefault();
        }
    }
}
