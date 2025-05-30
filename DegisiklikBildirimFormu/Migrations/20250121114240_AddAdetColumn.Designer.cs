﻿// <auto-generated />
using System;
using DegisiklikBildirimFormu.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DegisiklikBildirimFormu.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250121114240_AddAdetColumn")]
    partial class AddAdetColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DegisiklikBildirimFormu.Models.EskiYeniKod", b =>
                {
                    b.Property<int>("KodID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("KodID"));

                    b.Property<int>("Adet")
                        .HasColumnType("integer");

                    b.Property<string>("EskiKod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("FormID")
                        .HasColumnType("integer");

                    b.Property<string>("YeniKod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("KodID");

                    b.HasIndex("FormID");

                    b.ToTable("EskiYeniKodlar");

                    b.HasData(
                        new
                        {
                            KodID = 1,
                            Adet = 0,
                            EskiKod = "90051866",
                            FormID = 1,
                            YeniKod = "90079123"
                        },
                        new
                        {
                            KodID = 2,
                            Adet = 0,
                            EskiKod = "10012001-003",
                            FormID = 1,
                            YeniKod = "10012001-004"
                        },
                        new
                        {
                            KodID = 3,
                            Adet = 0,
                            EskiKod = "12345678",
                            FormID = 1,
                            YeniKod = "12345678"
                        },
                        new
                        {
                            KodID = 4,
                            Adet = 0,
                            EskiKod = "891011112",
                            FormID = 1,
                            YeniKod = "95460213"
                        },
                        new
                        {
                            KodID = 5,
                            Adet = 0,
                            EskiKod = "20011001-001",
                            FormID = 2,
                            YeniKod = "20011001-002"
                        },
                        new
                        {
                            KodID = 6,
                            Adet = 0,
                            EskiKod = "30012003-005",
                            FormID = 2,
                            YeniKod = "30012003-006"
                        },
                        new
                        {
                            KodID = 7,
                            Adet = 0,
                            EskiKod = "40011100-003",
                            FormID = 3,
                            YeniKod = "40011100-004"
                        },
                        new
                        {
                            KodID = 8,
                            Adet = 0,
                            EskiKod = "50022001-007",
                            FormID = 3,
                            YeniKod = "50022001-008"
                        },
                        new
                        {
                            KodID = 9,
                            Adet = 0,
                            EskiKod = "60033004-009",
                            FormID = 3,
                            YeniKod = "60033004-010"
                        });
                });

            modelBuilder.Entity("DegisiklikBildirimFormu.Models.Form", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("FormID"));

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DegisiklikNumarasi")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("KontrolEden")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Not")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Onaylayan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Uygulama")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("YayinTarihi")
                        .HasColumnType("date");

                    b.Property<string>("Yayınlayan")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("FormID");

                    b.ToTable("Formlar");

                    b.HasData(
                        new
                        {
                            FormID = 1,
                            Aciklama = "250 LT ÇABUK BOŞALTMADA YAY CE MİL KIRILMASININ ÖNÜNE GEÇİLEBİLMESİ İÇİN DEĞİŞİKLİK YAPILMIŞTIR. 250LT ve 400 LT boşaltmalarda artık 'KATRİÇ TİP 250 VE 400 LT BOŞALTMA' ya geçilecektir.",
                            DegisiklikNumarasi = "2025_1",
                            KontrolEden = "",
                            Not = "Acil olarak geçilecektir.Stokta olanlar hurdyaa ayrılacaktır.",
                            Onaylayan = "",
                            Uygulama = "Acil",
                            YayinTarihi = new DateOnly(2025, 1, 7),
                            Yayınlayan = ""
                        },
                        new
                        {
                            FormID = 2,
                            Aciklama = "Makine bakım prosedürü güncellenmiştir. Bakımda kullanılan malzemeler değişmiştir.",
                            DegisiklikNumarasi = "2025_2",
                            KontrolEden = "",
                            Not = "Bakım sırasında makine duruşları olacaktır.",
                            Onaylayan = "",
                            Uygulama = "Bakım",
                            YayinTarihi = new DateOnly(2025, 2, 1),
                            Yayınlayan = ""
                        },
                        new
                        {
                            FormID = 3,
                            Aciklama = "Yeni üretim hattı devreye alınmıştır. Üretim kapasitesi artırılmıştır.",
                            DegisiklikNumarasi = "2025_3",
                            KontrolEden = "",
                            Not = "Yeni üretim hattı kullanılmaya başlanacaktır.",
                            Onaylayan = "",
                            Uygulama = "Yeni Ürün",
                            YayinTarihi = new DateOnly(2025, 3, 10),
                            Yayınlayan = ""
                        });
                });

            modelBuilder.Entity("DegisiklikBildirimFormu.Models.EskiYeniKod", b =>
                {
                    b.HasOne("DegisiklikBildirimFormu.Models.Form", "Form")
                        .WithMany("EskiYeniKodlar")
                        .HasForeignKey("FormID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");
                });

            modelBuilder.Entity("DegisiklikBildirimFormu.Models.Form", b =>
                {
                    b.Navigation("EskiYeniKodlar");
                });
#pragma warning restore 612, 618
        }
    }
}
