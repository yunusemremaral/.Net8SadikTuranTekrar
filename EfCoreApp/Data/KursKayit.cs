using System.ComponentModel.DataAnnotations;

namespace EfCoreApp.Data
{
    public class KursKayit
    {
        [Key]
        public int KayitId { get; set; }

        public int OgrenciId { get; set; }
        public Ogrenci Ogrenci { get; set; }  = null!;  // iliþkiler  ULASIYORUZ ARDINDAN ! 
        
        public int KursId { get; set; }
        public Kurs Kurs { get; set; } = null!; // iliþkiler 

        public DateTime KayitTarihi { get; set; }
        
    }
}