using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using csASP.Models;
using csASP.Data;

namespace csASP.Controllers;

public class MostBoughtBoxesController : Controller
{
    private readonly BazaContext _context;

    public MostBoughtBoxesController(BazaContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        if (HttpContext.Session.GetString("USER_STATUS") != "LOGGED_IN")
            return RedirectToAction(actionName: "Index", controllerName: "Login");

        var query = from a in _context.Artykul
                    join p in _context.Pudelko on a.idpudelka equals p.idpudelka
                    group a by p.nazwa into g
                    orderby g.Sum(x => x.sztuk) descending
                    select new NameCountObject
                    {
                        Name = g.Key,
                        Count = g.Sum(x => x.sztuk)
                    };

        var result = query.ToList();

        ViewData["data"] = result;
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
