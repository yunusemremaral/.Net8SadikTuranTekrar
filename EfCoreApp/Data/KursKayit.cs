using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }  = null!;  // ili�kiler  ULASIYORUZ ARDINDAN ! 
        
        public int KursId { get; set; }
        public Kurs Kurs { get; set; } = null!; // ili�kiler 

        public DateTime KayitTarihi { get; set; }
        
    }
}