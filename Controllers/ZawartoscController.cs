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
    public class ZawartoscController : Controller
    {
        private readonly BazaContext _context;

        public ZawartoscController(BazaContext context)
        {
            _context = context;
        }

        // GET: Zawartosc
        public async Task<IActionResult> Index()
        {
              return _context.Zawartosc != null ? 
                          View(await _context.Zawartosc.ToListAsync()) :
                          Problem("Entity set 'BazaContext.Zawartosc'  is null.");
        }

        // GET: Zawartosc/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Zawartosc == null)
            {
                return NotFound();
            }

            var zawartosc = await _context.Zawartosc
                .FirstOrDefaultAsync(m => m.idczekoladki == id);
            if (zawartosc == null)
            {
                return NotFound();
            }

            return View(zawartosc);
        }

        // GET: Zawartosc/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zawartosc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("sztuk,idpudelka,idczekoladki")] Zawartosc zawartosc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zawartosc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zawartosc);
        }

        // GET: Zawartosc/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Zawartosc == null)
            {
                return NotFound();
            }

            var zawartosc = await _context.Zawartosc.FindAsync(id);
            if (zawartosc == null)
            {
                return NotFound();
            }
            return View(zawartosc);
        }

        // POST: Zawartosc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("sztuk,idpudelka,idczekoladki")] Zawartosc zawartosc)
        {
            if (id != zawartosc.idczekoladki)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zawartosc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZawartoscExists(zawartosc.idczekoladki))
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
            return View(zawartosc);
        }

        // GET: Zawartosc/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Zawartosc == null)
            {
                return NotFound();
            }

            var zawartosc = await _context.Zawartosc
                .FirstOrDefaultAsync(m => m.idczekoladki == id);
            if (zawartosc == null)
            {
                return NotFound();
            }

            return View(zawartosc);
        }

        // POST: Zawartosc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Zawartosc == null)
            {
                return Problem("Entity set 'BazaContext.Zawartosc'  is null.");
            }
            var zawartosc = await _context.Zawartosc.FindAsync(id);
            if (zawartosc != null)
            {
                _context.Zawartosc.Remove(zawartosc);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZawartoscExists(string id)
        {
          return (_context.Zawartosc?.Any(e => e.idczekoladki == id)).GetValueOrDefault();
        }
    }
}
