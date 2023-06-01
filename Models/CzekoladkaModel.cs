using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MvcPracownik.Models
{
    [Table("czekoladki")]
    public class Czekoladka
    {
        [Key]
        [Display(Name = "idczekoladki")]
        public String idczekoladki { get; set; }
        [Display(Name = "nazwa")]
        public String nazwa { get; set; }

        [Display(Name = "czekolada")]
        public String? czekolada { get; set; }

        [Display(Name = "orzechy")]
        public String? orzechy { get; set; }

        [Display(Name = "nadzienie")]
        public String? nadzienie { get; set; }

        [Display(Name = "opis")]
        public String opis { get; set; }
        [Display(Name = "koszt")]
        public float koszt { get; set; }

        [Display(Name = "masa")]
        public float masa { get; set; }

        public ICollection<Zawartosc> ?zawartosci {get; set;}
    }
}
