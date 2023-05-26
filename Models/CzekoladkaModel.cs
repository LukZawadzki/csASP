using System.ComponentModel.DataAnnotations;

namespace MvcPracownik.Models
{
    public class Czekoladka
    {
        [Key]
        [Display(Name = "idczekoladki")]
        public int idczekoladki { get; set; }
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
        public decimal koszt { get; set; }

        [Display(Name = "masa")]
        public decimal masa { get; set; }
    }
}
