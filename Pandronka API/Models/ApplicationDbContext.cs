using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pandronka.Models;

namespace Pandronka.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<JednostkaMiary> JednostkaMiary { get; set; }
        public DbSet<Kategoria> Kategoria { get; set; }
        public DbSet<Kosz_Prod> Kosz_Prod { get; set; }
        public DbSet<Koszyk> Koszyk { get; set; }
        public DbSet<Producent> Producent { get; set; }
        public DbSet<Produkt> Produkt { get; set; }
        public DbSet<Status> Statusy { get; set; }
        public DbSet<Zamowienia> Zamowienia { get; set; }
        public DbSet<Platnosc> Platnosci { get; set; }

        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasMany(c => c.Wykonane)
                .WithOne(e => e.Wykonujacy);

            this.SeedData(builder);
        }

        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<Status>().HasData(new Status[]
            {
                new Status()
                {
                    Id = 1,
                    Nazwa = "Nowe"
                },
                new Status()
                {
                    Id = 2,
                    Nazwa = "W kompletowaniu"
                },
                new Status()
                {
                    Id = 3,
                    Nazwa = "W drodze do klienta"
                },
                new Status()
                {
                    Id = 4,
                    Nazwa = "Zakoñczone"
                }
            });

            builder.Entity<Platnosc>().HasData(new Platnosc[]
            {
                new Platnosc()
                {
                    Id = 1,
                    Nazwa = "Online"
                },
                new Platnosc()
                {
                    Id = 2,
                    Nazwa = "Za pobraniem"
                },
                new Platnosc()
                {
                    Id = 3,
                    Nazwa = "Przelewem tradycyjnym"
                }
            });

            builder.Entity<Producent>().HasData(new Producent[]
            {
                new Producent()//nabia³
                {
                    Id = 1,
                    Nazwa = "Pi¹tnica"
                },
                new Producent()//Soki
                {
                    Id = 2,
                    Nazwa = "Hortex"
                },
                new Producent() //piekarnia
                {
                    Id = 3,
                    Nazwa = "Grella"
                },
                new Producent()//napoje
                {
                    Id = 4,
                    Nazwa = "CocaCola"
                },
                new Producent()//alko
                {
                    Id = 5,
                    Nazwa = "Polmos"
                }
                ,
                new Producent() //Wêdliny
                {
                    Id = 7,
                    Nazwa = "Soko³ów"
                }
            });

            builder.Entity<JednostkaMiary>().HasData(new JednostkaMiary[]
            {
                new JednostkaMiary()
                {
                    Id = 1, Nazwa = "ml" // mililitry
                },
                new JednostkaMiary()
                {
                    Id = 2, Nazwa = "gr" // gramy
                },
                new JednostkaMiary()
                {
                    Id = 3, Nazwa = "szt" // sztuki
                },
            });

            builder.Entity<Kategoria>().HasData(new Kategoria[]
            {
                new Kategoria()
                {
                    Id = 1,
                    Nazwa = "Nabia³",
                },
                new Kategoria()
                {
                    Id = 2,
                    Nazwa = "Miêso",
                },
                new Kategoria()
                {
                    Id = 3,
                    Nazwa = "Pieczywo",
                },
                new Kategoria()
                {
                    Id = 4,
                    Nazwa = "Napoje",
                },
                new Kategoria()
                {
                    Id = 5,
                    Nazwa = "Alkohol",
                }
            });

            builder.Entity<Produkt>().HasData(new Produkt[]
            {
                new Produkt()
                {
                    Id = 1,
                    Cena = 3.50,
                    Dostepnosc = true,
                    Ilosc = 11,
                    ProducentId = 1,
                    JednostkaMiaryId = 1,
                    KategoriaId = 1,
                    Nazwa = "Jogurt naturalny"
                },
                new Produkt()
                {
                    Id = 2,
                    Cena = 4.99,
                    Dostepnosc = true,
                    Ilosc = 9,
                    ProducentId = 1,
                    JednostkaMiaryId = 1,
                    KategoriaId = 1,
                    Nazwa = "Jogurt owocowy"
                },
                new Produkt()
                {
                    Id = 3,
                    Cena = 5.99,
                    Dostepnosc = true,
                    Ilosc = 500,
                    ProducentId = 1,
                    JednostkaMiaryId = 1,
                    KategoriaId = 1,
                    Nazwa = "Mleko"
                },
                new Produkt()
                {
                    Id = 4,
                    Cena = 10.90,
                    Dostepnosc = true,
                    Ilosc = 9,
                    ProducentId = 2,
                    JednostkaMiaryId = 2,
                    KategoriaId = 2,
                    Nazwa = "Pierœ z kurczaka"
                },
                new Produkt()
                {
                    Id = 5,
                    Cena = 7.90,
                    Dostepnosc = true,
                    Ilosc = 122,
                    ProducentId = 7,
                    JednostkaMiaryId = 2,
                    KategoriaId = 2,
                    Nazwa = "Podwawelska"
                },
                new Produkt()
                {
                    Id = 6,
                    Cena = 1.20,
                    Dostepnosc = true,
                    Ilosc = 200,
                    ProducentId = 3,
                    JednostkaMiaryId = 3,
                    KategoriaId = 3,
                    Nazwa = "Kajzerka"
                },
                new Produkt()
                {
                    Id = 7,
                    Cena = 2.00,
                    Dostepnosc = true,
                    Ilosc = 100,
                    ProducentId = 3,
                    JednostkaMiaryId = 3,
                    KategoriaId = 3,
                    Nazwa = "Chleb"
                },
                new Produkt()
                {
                    Id = 8,
                    Cena = 4.90,
                    Dostepnosc = true,
                    Ilosc = 50,
                    ProducentId = 2,
                    JednostkaMiaryId = 1,
                    KategoriaId = 4,
                    Nazwa = "Sok pomarañczowy"
                },
                new Produkt()
                {
                    Id = 9,
                    Cena = 4.90,
                    Dostepnosc = true,
                    Ilosc = 50,
                    ProducentId = 2,
                    JednostkaMiaryId = 1,
                    KategoriaId = 4,
                    Nazwa = "Sok po¿eczkowy"
                },
                new Produkt()
                {
                    Id = 10,
                    Cena = 19.90,
                    Dostepnosc = true,
                    Ilosc = 500,
                    ProducentId = 5,
                    JednostkaMiaryId = 1,
                    KategoriaId = 5,
                    Nazwa = "Pan Tadeusz"
                },
            });
        }
        
    }
}