﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pandronka.Models;

namespace Pandronka.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Pandronka.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Imie")
                        .HasColumnType("text");

                    b.Property<string>("KodPocztowy")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Miejscowosc")
                        .HasColumnType("text");

                    b.Property<string>("Nazwisko")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NumerDomu")
                        .HasColumnType("text");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Ulica")
                        .HasColumnType("text");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Pandronka.Models.JednostkaMiary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Nazwa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("JednostkaMiary");
                });

            modelBuilder.Entity("Pandronka.Models.Kategoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Nazwa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Kategoria");
                });

            modelBuilder.Entity("Pandronka.Models.Kosz_Prod", b =>
                {
                    b.Property<int?>("KoszykId")
                        .HasColumnType("integer");

                    b.Property<int?>("ProduktId")
                        .HasColumnType("integer");

                    b.HasIndex("KoszykId");

                    b.HasIndex("ProduktId");

                    b.ToTable("Kosz_Prod");
                });

            modelBuilder.Entity("Pandronka.Models.Koszyk", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("UzytkownikId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UzytkownikId")
                        .IsUnique();

                    b.ToTable("Koszyk");
                });

            modelBuilder.Entity("Pandronka.Models.Producent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Nazwa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Producent");
                });

            modelBuilder.Entity("Pandronka.Models.Produkt", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<float>("Cena")
                        .HasColumnType("real");

                    b.Property<bool>("Dostepnosc")
                        .HasColumnType("boolean");

                    b.Property<int>("Ilosc")
                        .HasColumnType("integer");

                    b.Property<int?>("JednostkaMiaryId")
                        .HasColumnType("integer");

                    b.Property<int?>("KategoriaId")
                        .HasColumnType("integer");

                    b.Property<string>("Nazwa")
                        .HasColumnType("text");

                    b.Property<int?>("ProducentId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("JednostkaMiaryId");

                    b.HasIndex("KategoriaId");

                    b.HasIndex("ProducentId");

                    b.ToTable("Produkt");
                });

            modelBuilder.Entity("Pandronka.Models.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Nazwa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Status");
                });

            modelBuilder.Entity("Pandronka.Models.Zamowienia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<int?>("KoszykId")
                        .HasColumnType("integer");

                    b.Property<float>("Kwota")
                        .HasColumnType("real");

                    b.Property<int?>("StatusId")
                        .HasColumnType("integer");

                    b.Property<string>("UzytkownikId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("KoszykId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UzytkownikId");

                    b.ToTable("Zamowienia");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Pandronka.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Pandronka.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pandronka.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Pandronka.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Pandronka.Models.Kosz_Prod", b =>
                {
                    b.HasOne("Pandronka.Models.Koszyk", "Koszyk")
                        .WithMany()
                        .HasForeignKey("KoszykId");

                    b.HasOne("Pandronka.Models.Produkt", "Produkt")
                        .WithMany()
                        .HasForeignKey("ProduktId");

                    b.Navigation("Koszyk");

                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("Pandronka.Models.Koszyk", b =>
                {
                    b.HasOne("Pandronka.Models.ApplicationUser", "Uzytkownik")
                        .WithOne("Koszyk")
                        .HasForeignKey("Pandronka.Models.Koszyk", "UzytkownikId");

                    b.Navigation("Uzytkownik");
                });

            modelBuilder.Entity("Pandronka.Models.Produkt", b =>
                {
                    b.HasOne("Pandronka.Models.JednostkaMiary", "JednostkaMiary")
                        .WithMany("Produkt")
                        .HasForeignKey("JednostkaMiaryId");

                    b.HasOne("Pandronka.Models.Kategoria", "Kategoria")
                        .WithMany("Produkt")
                        .HasForeignKey("KategoriaId");

                    b.HasOne("Pandronka.Models.Producent", "Producent")
                        .WithMany("Produkt")
                        .HasForeignKey("ProducentId");

                    b.Navigation("JednostkaMiary");

                    b.Navigation("Kategoria");

                    b.Navigation("Producent");
                });

            modelBuilder.Entity("Pandronka.Models.Zamowienia", b =>
                {
                    b.HasOne("Pandronka.Models.Koszyk", "Koszyk")
                        .WithMany()
                        .HasForeignKey("KoszykId");

                    b.HasOne("Pandronka.Models.Status", "Status")
                        .WithMany("Zamowienia")
                        .HasForeignKey("StatusId");

                    b.HasOne("Pandronka.Models.ApplicationUser", "Uzytkownik")
                        .WithMany("Zamowienia")
                        .HasForeignKey("UzytkownikId");

                    b.Navigation("Koszyk");

                    b.Navigation("Status");

                    b.Navigation("Uzytkownik");
                });

            modelBuilder.Entity("Pandronka.Models.ApplicationUser", b =>
                {
                    b.Navigation("Koszyk");

                    b.Navigation("Zamowienia");
                });

            modelBuilder.Entity("Pandronka.Models.JednostkaMiary", b =>
                {
                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("Pandronka.Models.Kategoria", b =>
                {
                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("Pandronka.Models.Producent", b =>
                {
                    b.Navigation("Produkt");
                });

            modelBuilder.Entity("Pandronka.Models.Status", b =>
                {
                    b.Navigation("Zamowienia");
                });
#pragma warning restore 612, 618
        }
    }
}
