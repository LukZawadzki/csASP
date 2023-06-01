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
    public class ZamowieniaController : Controller
    {
        private readonly BazaContext _context;

        public ZamowieniaController(BazaContext context)
        {
            _context = context;
        }

        // GET: Zamowienia
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            return _context.Zamowienie != null ? 
                        View(await _context.Zamowienie.ToListAsync()) :
                        Problem("Entity set 'BazaContext.Zamowienie'  is null.");
        }

        // GET: Zamowienia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Zamowienie == null)
            {
                return NotFound();
            }

            var zamowienie = await _context.Zamowienie
                .FirstOrDefaultAsync(m => m.idzamowienia == id);
            if (zamowienie == null)
            {
                return NotFound();
            }

            return View(zamowienie);
        }

        // GET: Zamowienia/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            return View();
        }

        // POST: Zamowienia/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idzamowienia,datarealizacji,idklienta")] Zamowienie zamowienie)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (ModelState.IsValid)
            {
                _context.Add(zamowienie);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zamowienie);
        }

        // GET: Zamowienia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Zamowienie == null)
            {
                return NotFound();
            }

            var zamowienie = await _context.Zamowienie.FindAsync(id);
            if (zamowienie == null)
            {
                return NotFound();
            }
            return View(zamowienie);
        }

        // POST: Zamowienia/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idzamowienia,datarealizacji,idklienta")] Zamowienie zamowienie)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id != zamowienie.idzamowienia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zamowienie);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZamowienieExists(zamowienie.idzamowienia))
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
            return View(zamowienie);
        }

        // GET: Zamowienia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Zamowienie == null)
            {
                return NotFound();
            }

            var zamowienie = await _context.Zamowienie
                .FirstOrDefaultAsync(m => m.idzamowienia == id);
            if (zamowienie == null)
            {
                return NotFound();
            }

            var artykuly = _context.Artykul.Any(a => a.idzamowienia == zamowienie.idzamowienia);
            if(artykuly){
                ModelState.AddModelError(string.Empty, "Nie można usunąć zamówienia, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            return View(zamowienie);
        }

        // POST: Zamowienia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (_context.Zamowienie == null)
            {
                return Problem("Entity set 'BazaContext.Zamowienie'  is null.");
            }
            var zamowienie = await _context.Zamowienie.FindAsync(id);
            if (zamowienie != null)
            {
                _context.Zamowienie.Remove(zamowienie);
            }
            
            var artykuly = _context.Artykul.Any(a => a.idzamowienia == zamowienie.idzamowienia);
            if(artykuly){
                ModelState.AddModelError(string.Empty, "Nie można usunąć zamówienia, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZamowienieExists(int id)
        {
          return (_context.Zamowienie?.Any(e => e.idzamowienia == id)).GetValueOrDefault();
        }
    }
}
