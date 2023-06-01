using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcPracownik.Models;

namespace csASP.Data
{
    public class BazaContext : DbContext
    {
        public BazaContext (DbContextOptions<BazaContext> options)
            : base(options)
        {
        }

        public DbSet<MvcPracownik.Models.Klient> Klient { get; set; } = default!;

        public DbSet<MvcPracownik.Models.Pudelko> Pudelko { get; set; } = default!;

        public DbSet<MvcPracownik.Models.Czekoladka> Czekoladka { get; set; } = default!;

        public DbSet<MvcPracownik.Models.Zawartosc> Zawartosc { get; set; } = default!;

        public DbSet<MvcPracownik.Models.Artykul> Artykul { get; set; } = default!;

        public DbSet<MvcPracownik.Models.Zamowienie> Zamowienie { get; set; } = default!;
    }
}
