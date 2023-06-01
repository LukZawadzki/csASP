using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace MvcPracownik.Models
{
    [Table("zamowienia")]
    public class Zamowienie
    {
        [Key]
        public int idzamowienia { get; set; }
        [Display(Name = "Data realizacji")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime datarealizacji { get; set; }
        [ForeignKey("klienci")]
        public virtual int idklienta {get; set;}
        public ICollection<Artykul>? artykuly { get; set; }
    }
}
