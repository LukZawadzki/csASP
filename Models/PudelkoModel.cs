using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MvcPracownik.Models
{
    [Table("pudelka")]
    public class Pudelko
    {
        [Key]
        [Display(Name = "idpudelka")]
        public String idpudelka { get; set; }
        [Display(Name = "nazwa")]
        public String nazwa { get; set; }
        [Display(Name = "opis")]
        public String? opis { get; set; }
        [Display(Name = "cena")]
        public float cena { get; set; }
        [Display(Name = "stan")]
        public int stan { get; set; }

        public ICollection<Zawartosc> ?zawartosci {get; set;}
        public ICollection<Artykul> ?artykuly {get; set;}
    }
}
