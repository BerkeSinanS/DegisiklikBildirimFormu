using DegisiklikBildirimFormu.Models;
using Microsoft.EntityFrameworkCore;

namespace DegisiklikBildirimFormu.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {
            
        }
        public DbSet<Form> Formlar { get; set; }
        public DbSet<EskiYeniKod> EskiYeniKodlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=Degisiklik_Formu;Username=Berke;Password=BS1603");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EskiYeniKod>() 
                .HasKey(e => e.KodID);

            modelBuilder.Entity<Form>()
                  .HasMany(f => f.EskiYeniKodlar)
                  .WithOne(k => k.Form)
                  .HasForeignKey(k => k.FormID);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Form>().HasData(
                new Form { FormID = 1, 
                    Uygulama ="Acil",
                    DegisiklikNumarasi="2025_1",
                    Aciklama="250 LT ÇABUK BOŞALTMADA YAY CE MİL KIRILMASININ ÖNÜNE GEÇİLEBİLMESİ İÇİN DEĞİŞİKLİK YAPILMIŞTIR." +
                    " 250LT ve 400 LT boşaltmalarda artık 'KATRİÇ TİP 250 VE 400 LT BOŞALTMA' ya geçilecektir.",
                    Not="Acil olarak geçilecektir.Stokta olanlar hurdyaa ayrılacaktır.",
                    KontrolEden="",
                    Onaylayan="",
                    YayinTarihi=new DateOnly(2025,01,07),
                    Yayınlayan="",
                    Bolum = "Tasarım Bölümü"
                    },
                new Form
                {
                    FormID = 2,
                    Uygulama = "Normal öncelikli",
                    DegisiklikNumarasi = "2025_2",
                    Aciklama = "Makine bakım prosedürü güncellenmiştir. Bakımda kullanılan malzemeler değişmiştir.",
                    Not = "Bakım sırasında makine duruşları olacaktır.",
                    KontrolEden = "",
                    Onaylayan = "",
                    YayinTarihi = new DateOnly(2025, 02, 01),
                    Yayınlayan = "",
                    Bolum = "Arge Bölümü"
                    
                },
                 new Form
                {
                    FormID = 3,
                    Uygulama = "Düşük öncelikli",
                    DegisiklikNumarasi = "2025_3",
                    Aciklama = "Yeni üretim hattı devreye alınmıştır. Üretim kapasitesi artırılmıştır.",
                    Not = "Yeni üretim hattı kullanılmaya başlanacaktır.",
                    KontrolEden = "",
                    Onaylayan = "",
                    YayinTarihi = new DateOnly(2025, 03, 10),
                    Yayınlayan = "",
                    Bolum = "Arge Bölümü"
                 }
                );

            modelBuilder.Entity<EskiYeniKod>().HasData(
                new EskiYeniKod{
                    KodID = 1,
                    FormID = 1,
                    EskiKod = "90051866",
                    YeniKod = "90079123"
                },
                new EskiYeniKod
                {
                    KodID = 2,
                    FormID = 1,
                    EskiKod = "10012001-003",
                    YeniKod = "10012001-004"
                }
                ,
                new EskiYeniKod
                {
                    KodID = 3,
                    FormID = 1,
                    EskiKod = "12345678",
                    YeniKod = "12345678"
                }
                ,
                new EskiYeniKod
                {
                    KodID = 4,
                    FormID = 1,
                    EskiKod = "891011112",
                    YeniKod = "95460213"
                },
                new EskiYeniKod
                {
                    KodID = 5,
                    FormID = 2,
                    EskiKod = "20011001-001",
                    YeniKod = "20011001-002"
                },
                new EskiYeniKod
                {
                    KodID = 6,
                    FormID = 2,
                    EskiKod = "30012003-005",
                    YeniKod = "30012003-006"
                },
                new EskiYeniKod
                {
                    KodID = 7,
                    FormID = 3,
                    EskiKod = "40011100-003",
                    YeniKod = "40011100-004"
                },
                new EskiYeniKod
                {
                    KodID = 8,
                    FormID = 3,
                    EskiKod = "50022001-007",
                    YeniKod = "50022001-008"
                },
                new EskiYeniKod
                {
                    KodID = 9,
                    FormID = 3,
                    EskiKod = "60033004-009",
                    YeniKod = "60033004-010"
                }
                );
        }

    }
}
