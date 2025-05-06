using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DegisiklikBildirimFormu.Models
{
    public class Form
    {
        public int FormID { get; set; }
        [Required]
        public string Uygulama { get; set; }
        [DisplayName("Açıklama")]
        public string Aciklama { get; set; }
        public string Not { get; set; }
        [DisplayName("Yayın Tarihi")]
        public DateOnly YayinTarihi { get; set; }
        public string? Onaylayan { get; set; }
        [DisplayName("Kontrol Eden")]
        public string?  KontrolEden { get; set; }
        [DisplayName("Değişiklik Numarası")]
        public string DegisiklikNumarasi { get; set; }
        public string? Yayınlayan { get; set; }
        public string? Durum { get; set; }
        [DisplayName("Bölüm")]
        public string? Bolum { get; set; }
        public ICollection<EskiYeniKod> EskiYeniKodlar { get; set; } 

    }
}
