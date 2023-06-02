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
    public class KlientController : Controller
    {
        private readonly BazaContext _context;

        public KlientController(BazaContext context)
        {
            _context = context;
        }

        // GET: Klient
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            return _context.Klient != null ? 
                        View(await _context.Klient.ToListAsync()) :
                        Problem("Entity set 'BazaContext.Klient'  is null.");
        }

        // GET: Klient/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var klient = await _context.Klient
                .FirstOrDefaultAsync(m => m.idklienta == id);
            if (klient == null)
            {
                return NotFound();
            }

            return View(klient);
        }

        // GET: Klient/OrderedChocolates/5
        public async Task<IActionResult> OrderedChocolates(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var query = from c in _context.Czekoladka
                        join za in _context.Zawartosc on c.idczekoladki equals za.idczekoladki
                        join p in _context.Pudelko on za.idpudelka equals p.idpudelka
                        join a in _context.Artykul on p.idpudelka equals a.idpudelka
                        join z in _context.Zamowienie on a.idzamowienia equals z.idzamowienia
                        where z.idklienta == id
                        group new {c, za, a} by c.nazwa into g
                        select new NameCountObject
                        {
                            Name = g.Key,
                            Count = g.Sum(x => x.za.sztuk * x.a.sztuk)
                        };

            var result = await query.OrderBy(x => -x.Count).ToListAsync();

            ViewData["data"] = result;
            return View();
        }

        // GET: Klient/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            return View();
        }

        // POST: Klient/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idklienta,nazwa,ulica,miejscowosc,kod,telefon")] Klient klient)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (ModelState.IsValid)
            {
                _context.Add(klient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(klient);
        }

        // GET: Klient/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var klient = await _context.Klient.FindAsync(id);
            if (klient == null)
            {
                return NotFound();
            }
            return View(klient);
        }

        // POST: Klient/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idklienta,nazwa,ulica,miejscowosc,kod,telefon")] Klient klient)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id != klient.idklienta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(klient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KlientExists(klient.idklienta))
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
            return View(klient);
        }

        // GET: Klient/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (id == null || _context.Klient == null)
            {
                return NotFound();
            }

            var klient = await _context.Klient
                .FirstOrDefaultAsync(m => m.idklienta == id);
            if (klient == null)
            {
                return NotFound();
            }

            var zamowienia = _context.Zamowienie.Any(z => z.idklienta == klient.idklienta);
            if(zamowienia){
                ModelState.AddModelError(string.Empty, "Nie można usunąć klienta, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            return View(klient);
        }

        // POST: Klient/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
                return RedirectToAction(actionName: "Index", controllerName: "Login");

            if (_context.Klient == null)
            {
                return Problem("Entity set 'BazaContext.Klient'  is null.");
            }
            var klient = await _context.Klient.FindAsync(id);
            if (klient != null)
            {
                _context.Klient.Remove(klient);
            }
            
            var zamowienia = _context.Zamowienie.Any(z => z.idklienta == klient.idklienta);
            if(zamowienia){
                ModelState.AddModelError(string.Empty, "Nie można usunąć klienta, ponieważ istnieją powiązane dane.");
                return RedirectToAction("Index");
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KlientExists(int id)
        {
          return (_context.Klient?.Any(e => e.idklienta == id)).GetValueOrDefault();
        }
    }
}