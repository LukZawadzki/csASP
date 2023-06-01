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
    public class PudelkaController : Controller
    {
        private readonly BazaContext _context;

        public PudelkaController(BazaContext context)
        {
            _context = context;
        }

        // GET: Pudelka
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            return _context.Pudelko != null ? 
                        View(await _context.Pudelko.ToListAsync()) :
                        Problem("Entity set 'BazaContext.Pudelko'  is null.");
        }

        // GET: Pudelka/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Pudelko == null)
            {
                return NotFound();
            }

            var pudelko = await _context.Pudelko
                .FirstOrDefaultAsync(m => m.idpudelka == id);
            if (pudelko == null)
            {
                return NotFound();
            }

            return View(pudelko);
        }

        // GET: Pudelka/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");
            
            return View();
        }

        // POST: Pudelka/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idpudelka,nazwa,opis,cena,stan")] Pudelko pudelko)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (ModelState.IsValid)
            {
                _context.Add(pudelko);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pudelko);
        }

        // GET: Pudelka/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Pudelko == null)
            {
                return NotFound();
            }

            var pudelko = await _context.Pudelko.FindAsync(id);
            if (pudelko == null)
            {
                return NotFound();
            }
            return View(pudelko);
        }

        // POST: Pudelka/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("idpudelka,nazwa,opis,cena,stan")] Pudelko pudelko)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id != pudelko.idpudelka)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pudelko);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PudelkoExists(pudelko.idpudelka))
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
            return View(pudelko);
        }

        // GET: Pudelka/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Pudelko == null)
            {
                return NotFound();
            }

            var pudelko = await _context.Pudelko
                .FirstOrDefaultAsync(m => m.idpudelka == id);
            if (pudelko == null)
            {
                return NotFound();
            }

            var artykuly = _context.Artykul.Any(a => a.idpudelka.Equals(pudelko.idpudelka));
            var zawartosci = _context.Zawartosc.Any(z => z.idpudelka.Equals(pudelko.idpudelka));
            if(artykuly || zawartosci){
                ModelState.AddModelError(string.Empty, "Nie można usunąć pudełka, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            return View(pudelko);
        }

        // POST: Pudelka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (_context.Pudelko == null)
            {
                return Problem("Entity set 'BazaContext.Pudelko'  is null.");
            }
            var pudelko = await _context.Pudelko.FindAsync(id);
            if (pudelko != null)
            {
                _context.Pudelko.Remove(pudelko);
            }
            
            var artykuly = _context.Artykul.Any(a => a.idpudelka.Equals(pudelko.idpudelka));
            var zawartosci = _context.Zawartosc.Any(z => z.idpudelka.Equals(pudelko.idpudelka));
            if(artykuly || zawartosci){
                ModelState.AddModelError(string.Empty, "Nie można usunąć pudełka, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PudelkoExists(string id)
        {
          return (_context.Pudelko?.Any(e => e.idpudelka == id)).GetValueOrDefault();
        }
    }
}
