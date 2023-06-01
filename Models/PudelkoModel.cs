using System.ComponentModel.DataAnnotations;

namespace MvcPracownik.Models
{
    public class Pudelko
    {
        [Key]
        [Display(Name = "idpudelka")]
        public int idpudelka { get; set; }
        [Display(Name = "nazwa")]
        public String nazwa { get; set; }
        [Display(Name = "opis")]
        public String? opis { get; set; }
        [Display(Name = "cena")]
        public decimal cena { get; set; }
        [Display(Name = "stan")]
        public int stan { get; set; }

        public ICollection<Zawartosc> ?zawartosci {get; set;}
        public ICollection<Artykul> ?artykuly {get; set;}
    }
}
