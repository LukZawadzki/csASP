using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MvcPracownik.Models
{
    [Table("artykuly")]
    public class Artykul
    {
        [Display(Name = "Sztuk")]
        public int sztuk { get; set; }
        [ForeignKey("zamowienia")]
        public virtual int idzamowienia {get; set;}
        [ForeignKey("pudelka")]
        public virtual String idpudelka{get; set;}

    }
}
