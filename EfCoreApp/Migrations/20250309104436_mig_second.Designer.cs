﻿// <auto-generated />
using System;
using EfCoreApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250309104436_mig_second")]
    partial class mig_second
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.13");

            modelBuilder.Entity("EfCoreApp.Data.Kurs", b =>
                {
                    b.Property<int>("KursId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Baslik")
                        .HasColumnType("TEXT");

                    b.Property<int>("OgretmenId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KursId");

                    b.HasIndex("OgretmenId");

                    b.ToTable("Kurslar");
                });

            modelBuilder.Entity("EfCoreApp.Data.KursKayit", b =>
                {
                    b.Property<int>("KayitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("TEXT");

                    b.Property<int>("KursId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("INTEGER");

                    b.HasKey("KayitId");

                    b.HasIndex("KursId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("KursKayitlari");
                });

            modelBuilder.Entity("EfCoreApp.Data.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("TEXT");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("OgrenciId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EfCoreApp.Data.Ogretmen", b =>
                {
                    b.Property<int>("OgretmenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("OgretmenId");

                    b.ToTable("Ogretmenler");
                });

            modelBuilder.Entity("EfCoreApp.Data.Kurs", b =>
                {
                    b.HasOne("EfCoreApp.Data.Ogretmen", "Ogretmen")
                        .WithMany("Kurslar")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EfCoreApp.Data.KursKayit", b =>
                {
                    b.HasOne("EfCoreApp.Data.Kurs", "Kurs")
                        .WithMany("KursKayitlari")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreApp.Data.Ogrenci", "Ogrenci")
                        .WithMany("KursKayitlari")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("EfCoreApp.Data.Kurs", b =>
                {
                    b.Navigation("KursKayitlari");
                });

            modelBuilder.Entity("EfCoreApp.Data.Ogrenci", b =>
                {
                    b.Navigation("KursKayitlari");
                });

            modelBuilder.Entity("EfCoreApp.Data.Ogretmen", b =>
                {
                    b.Navigation("Kurslar");
                });
#pragma warning restore 612, 618
        }
    }
}
