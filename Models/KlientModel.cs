using System.ComponentModel.DataAnnotations;

namespace MvcPracownik.Models
{
    public class Klient
    {
        [Key]
        public int idklienta { get; set; }
        [Display(Name = "Nazwa")]
        public String nazwa { get; set; }
        [Display(Name = "Ulica")]
        public String ulica { get; set; }
        [Display(Name = "Miejscowosc")]
        public String miejscowosc { get; set; }
        [Display(Name = "Kod")]
        public String kod { get; set; }
        [Display(Name = "Telefon")]
        public String telefon { get; set; }
        public ICollection<Zamowienie>? zamowienia { get; set; }
    }
}
