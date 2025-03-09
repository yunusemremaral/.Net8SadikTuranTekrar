namespace EfCoreApp.Data
{
    public class Kurs
    {
        public int KursId { get; set; }
        public string? Baslik { get; set; }
        public int OgretmenId { get; set; }   // �L��K� 
        public Ogretmen Ogretmen { get; set; } = null!;
        public ICollection<KursKayit> KursKayitlari { get; set; } = new List<KursKayit>(); // KURS KAYITLARINA G�D�YORUZ 
    }
}