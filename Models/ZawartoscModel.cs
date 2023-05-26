using System.ComponentModel.DataAnnotations;

namespace MvcPracownik.Models
{
    public class Zawartosc
    {
        [Display(Name = "sztuk")]
        public int sztuk {get; set;}
        public Pudelko? pudelko {get; set;}
        public Czekoladka? czekoladka {get; set;}
    }
}
