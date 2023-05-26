using System.ComponentModel.DataAnnotations;

namespace MvcPracownik.Models
{
    public class Artykul
    {
        [Display(Name = "Sztuk")]
        public int sztuk { get; set; }
        public Zamowienie? zamowienie { get; set; }
        public Pudelko? pudelko { get; set; }
    }
}
