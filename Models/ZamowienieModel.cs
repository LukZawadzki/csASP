using System.ComponentModel.DataAnnotations;

namespace MvcPracownik.Models
{
    public class Zamowienie
    {
        [Key]
        public int idzamowienia { get; set; }
        [Display(Name = "Data realizacji")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime datarealizacji { get; set; }
        public Klient? klient { get; set; }
    }
}
