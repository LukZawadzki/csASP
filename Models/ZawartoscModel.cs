using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MvcPracownik.Models
{
    [Table("zawartosc")]
    public class Zawartosc
    {
        [Display(Name = "sztuk")]
        public int sztuk {get; set;}
        [ForeignKey("pudelka")]
        public virtual String idpudelka {get; set;}
        [ForeignKey("czekoladki")]
        public virtual String idczekoladki {get; set;}
    }
}
