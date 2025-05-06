using System.ComponentModel;

namespace DegisiklikBildirimFormu.Models
{
    public class EskiYeniKod
    {
        public int KodID { get; set; }
        public int FormID { get; set; }
        [DisplayName("Eski Kod")]
        public string  EskiKod { get; set; }
        [DisplayName("Yeni Kod")]
        public string YeniKod { get; set; }
        public int Adet { get; set; }
        public Form Form { get; set; }

    }
}
