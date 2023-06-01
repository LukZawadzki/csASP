﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using csASP.Data;

#nullable disable

namespace csASP.Migrations
{
    [DbContext(typeof(BazaContext))]
    partial class BazaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("MvcPracownik.Models.Artykul", b =>
                {
                    b.Property<int>("idzamowienia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("idpudelka")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pudelkoidpudelka")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Zamowienieidzamowienia")
                        .HasColumnType("INTEGER");

                    b.Property<int>("sztuk")
                        .HasColumnType("INTEGER");

                    b.HasKey("idzamowienia", "idpudelka");

                    b.HasIndex("Pudelkoidpudelka");

                    b.HasIndex("Zamowienieidzamowienia");

                    b.ToTable("artykuly");
                });

            modelBuilder.Entity("MvcPracownik.Models.Czekoladka", b =>
                {
                    b.Property<string>("idczekoladki")
                        .HasColumnType("TEXT");

                    b.Property<string>("czekolada")
                        .HasColumnType("TEXT");

                    b.Property<float>("koszt")
                        .HasColumnType("REAL");

                    b.Property<float>("masa")
                        .HasColumnType("REAL");

                    b.Property<string>("nadzienie")
                        .HasColumnType("TEXT");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("opis")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("orzechy")
                        .HasColumnType("TEXT");

                    b.HasKey("idczekoladki");

                    b.ToTable("czekoladki");
                });

            modelBuilder.Entity("MvcPracownik.Models.Klient", b =>
                {
                    b.Property<int>("idklienta")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("kod")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("miejscowosc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("telefon")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ulica")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("idklienta");

                    b.ToTable("klienci");
                });

            modelBuilder.Entity("MvcPracownik.Models.Pudelko", b =>
                {
                    b.Property<string>("idpudelka")
                        .HasColumnType("TEXT");

                    b.Property<float>("cena")
                        .HasColumnType("REAL");

                    b.Property<string>("nazwa")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("opis")
                        .HasColumnType("TEXT");

                    b.Property<int>("stan")
                        .HasColumnType("INTEGER");

                    b.HasKey("idpudelka");

                    b.ToTable("pudelka");
                });

            modelBuilder.Entity("MvcPracownik.Models.Zamowienie", b =>
                {
                    b.Property<int>("idzamowienia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Klientidklienta")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("datarealizacji")
                        .HasColumnType("TEXT");

                    b.Property<int>("idklienta")
                        .HasColumnType("INTEGER");

                    b.HasKey("idzamowienia");

                    b.HasIndex("Klientidklienta");

                    b.ToTable("zamowienia");
                });

            modelBuilder.Entity("MvcPracownik.Models.Zawartosc", b =>
                {
                    b.Property<string>("idpudelka")
                        .HasColumnType("TEXT");

                    b.Property<string>("idczekoladki")
                        .HasColumnType("TEXT");

                    b.Property<string>("Czekoladkaidczekoladki")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pudelkoidpudelka")
                        .HasColumnType("TEXT");

                    b.Property<int>("sztuk")
                        .HasColumnType("INTEGER");

                    b.HasKey("idpudelka", "idczekoladki");

                    b.HasIndex("Czekoladkaidczekoladki");

                    b.HasIndex("Pudelkoidpudelka");

                    b.ToTable("zawartosc");
                });

            modelBuilder.Entity("MvcPracownik.Models.Artykul", b =>
                {
                    b.HasOne("MvcPracownik.Models.Pudelko", null)
                        .WithMany("artykuly")
                        .HasForeignKey("Pudelkoidpudelka");

                    b.HasOne("MvcPracownik.Models.Zamowienie", null)
                        .WithMany("artykuly")
                        .HasForeignKey("Zamowienieidzamowienia");
                });

            modelBuilder.Entity("MvcPracownik.Models.Zamowienie", b =>
                {
                    b.HasOne("MvcPracownik.Models.Klient", null)
                        .WithMany("zamowienia")
                        .HasForeignKey("Klientidklienta");
                });

            modelBuilder.Entity("MvcPracownik.Models.Zawartosc", b =>
                {
                    b.HasOne("MvcPracownik.Models.Czekoladka", null)
                        .WithMany("zawartosci")
                        .HasForeignKey("Czekoladkaidczekoladki");

                    b.HasOne("MvcPracownik.Models.Pudelko", null)
                        .WithMany("zawartosci")
                        .HasForeignKey("Pudelkoidpudelka");
                });

            modelBuilder.Entity("MvcPracownik.Models.Czekoladka", b =>
                {
                    b.Navigation("zawartosci");
                });

            modelBuilder.Entity("MvcPracownik.Models.Klient", b =>
                {
                    b.Navigation("zamowienia");
                });

            modelBuilder.Entity("MvcPracownik.Models.Pudelko", b =>
                {
                    b.Navigation("artykuly");

                    b.Navigation("zawartosci");
                });

            modelBuilder.Entity("MvcPracownik.Models.Zamowienie", b =>
                {
                    b.Navigation("artykuly");
                });
#pragma warning restore 612, 618
        }
    }
}
