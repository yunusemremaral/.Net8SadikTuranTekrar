using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class Ogretmen
    {
        [Key]
        public int OgretmenId { get; set; }
        [Display(Name = "Adý")]
        public string? Ad { get; set; }
        [Display(Name = "Soyadý")]
        public string? Soyad { get; set; }
        public string AdSoyad { 
            get 
            {
                return this.Ad + " " + this.Soyad;
            } 
        }
        public string? Eposta { get; set; }
        public string? Telefon { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = false)]
        public DateTime BaslamaTarihi { get; set; }
        public ICollection<Kurs> Kurslar { get; set; } = new List<Kurs>();  //KURS 
    }
}