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
        public DbSet<Zamowienie> Zamowienia { get; set; }
        public DbSet<Platnosc> Platnosci { get; set; }
        public DbSet<Miasto> Miasta { get; set; }

        
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


            builder.Entity<Miasto>().HasData(new Miasto[]
            {
                new Miasto(){Id = 1,ViewName = "Warszawa",PostalCode = "01-376",SubName = "Bemowo"},
                new Miasto(){Id = 2,ViewName = "Warszawa",PostalCode = "01-475",SubName = "Bemowo"},
                new Miasto(){Id = 3,ViewName = "Warszawa",PostalCode = "01-934",SubName = "Bielany"},
                new Miasto(){Id = 4,ViewName = "Warszawa",PostalCode = "00-791",SubName = "Mokotów"},
                new Miasto(){Id = 5,ViewName = "Warszawa",PostalCode = "01-493",SubName = "Bemowo"},
                new Miasto(){Id = 6,ViewName = "Warszawa",PostalCode = "01-358",SubName = "Bemowo"},
                new Miasto(){Id = 7,ViewName = "Warszawa",PostalCode = "03-085",SubName = "Bia³o³êka"},
                new Miasto(){Id = 8,ViewName = "Warszawa",PostalCode = "03-144",SubName = "Bia³o³êka"},
                new Miasto(){Id = 9,ViewName = "Warszawa",PostalCode = "01-870",SubName = "Bielany"},
                new Miasto(){Id = 10, ViewName = "Warszawa", PostalCode = "04-413", SubName = "Rembertów"},
                new Miasto(){ Id = 11, PostalCode = "00-117", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 12, PostalCode = "00-575", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 13, PostalCode = "00-654", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 14, PostalCode = "03-784", ViewName = "Warszawa", SubName="Targówek"},
                new Miasto(){ Id = 15, PostalCode = "03-622", ViewName = "Warszawa", SubName="Targówek"},
                new Miasto(){ Id = 16, PostalCode = "04-424", ViewName = "Warszawa", SubName="Rembertów"},
                new Miasto(){ Id = 17, PostalCode = "00-275", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 18, PostalCode = "00-229", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 19, PostalCode = "00-127", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 20, PostalCode = "05-075", ViewName = "Warszawa", SubName="Weso³a"},
                new Miasto(){ Id = 21, PostalCode = "05-075", ViewName = "Warszawa", SubName="Weso³a"},
                new Miasto(){ Id = 22, PostalCode = "02-490", ViewName = "Warszawa", SubName="W³ochy"},
                new Miasto(){ Id = 23, PostalCode = "02-168", ViewName = "Warszawa", SubName="W³ochy"},
                new Miasto(){ Id = 24, PostalCode = "04-854", ViewName = "Warszawa", SubName="Wawer"},
                new Miasto(){ Id = 25, PostalCode = "04-880", ViewName = "Warszawa", SubName="Wawer"},
                new Miasto(){ Id = 26, PostalCode = "04-682", ViewName = "Warszawa", SubName="Wawer"},
                new Miasto(){ Id = 27, PostalCode = "02-441", ViewName = "Warszawa", SubName="W³ochy"},
                new Miasto(){ Id = 28, PostalCode = "01-480", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 29, PostalCode = "01-317", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 30, PostalCode = "01-696", ViewName = "Warszawa", SubName="Bielany"},
                new Miasto(){ Id = 31, PostalCode = "02-716", ViewName = "Warszawa", SubName="Mokotów"},
                new Miasto(){ Id = 32, PostalCode = "01-493", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 33, PostalCode = "01-318", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 34, PostalCode = "03-063", ViewName = "Warszawa", SubName="Bia³o³êka"},
                new Miasto(){ Id = 35, PostalCode = "03-128", ViewName = "Warszawa", SubName="Bia³o³êka"},
                new Miasto(){ Id = 36, PostalCode = "01-727", ViewName = "Warszawa", SubName="Bielany"},
                new Miasto(){ Id = 37, PostalCode = "04-474", ViewName = "Warszawa", SubName="Rembertów"},
                new Miasto(){ Id = 38, PostalCode = "00-454", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 39, PostalCode = "00-497", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 40, PostalCode = "00-656", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 41, PostalCode = "03-338", ViewName = "Warszawa", SubName="Targówek"},
                new Miasto(){ Id = 42, PostalCode = "03-528", ViewName = "Warszawa", SubName="Targówek"},
                new Miasto(){ Id = 43, PostalCode = "04-277", ViewName = "Warszawa", SubName="Rembertów"},
                new Miasto(){ Id = 44, PostalCode = "00-249", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 45, PostalCode = "00-513", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 46, PostalCode = "00-430", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 47, PostalCode = "05-075", ViewName = "Warszawa", SubName="Weso³a"},
                new Miasto(){ Id = 48, PostalCode = "05-075", ViewName = "Warszawa", SubName="Weso³a"},
                new Miasto(){ Id = 49, PostalCode = "02-484", ViewName = "Warszawa", SubName="W³ochy"},
                new Miasto(){ Id = 50, PostalCode = "02-468", ViewName = "Warszawa", SubName="W³ochy"},
                new Miasto(){ Id = 51, PostalCode = "04-682", ViewName = "Warszawa", SubName="Wawer"},
                new Miasto(){ Id = 52, PostalCode = "04-825", ViewName = "Warszawa", SubName="Wawer"},
                new Miasto(){ Id = 53, PostalCode = "04-622", ViewName = "Warszawa", SubName="Wawer"},
                new Miasto(){ Id = 54, PostalCode = "02-243", ViewName = "Warszawa", SubName="W³ochy"},
                new Miasto(){ Id = 55, PostalCode = "01-497", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 56, PostalCode = "01-386", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 57, PostalCode = "01-940", ViewName = "Warszawa", SubName="Bielany"},
                new Miasto(){ Id = 58, PostalCode = "02-708", ViewName = "Warszawa", SubName="Mokotów"},
                new Miasto(){ Id = 59, PostalCode = "01-497", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 60, PostalCode = "01-492", ViewName = "Warszawa", SubName="Bemowo"},
                new Miasto(){ Id = 61, PostalCode = "03-089", ViewName = "Warszawa", SubName="Bia³o³êka"},
                new Miasto(){ Id = 62, PostalCode = "03-054", ViewName = "Warszawa", SubName="Bia³o³êka"},
                new Miasto(){ Id = 63, PostalCode = "01-995", ViewName = "Warszawa", SubName="Bielany"},
                new Miasto(){ Id = 64, PostalCode = "04-498", ViewName = "Warszawa", SubName="Rembertów"},
                new Miasto(){ Id = 65, PostalCode = "00-453", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 66, PostalCode = "00-405", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 67, PostalCode = "00-686", ViewName = "Warszawa", SubName="Œródmieœcie"},
                new Miasto(){ Id = 68, PostalCode = "03-678", ViewName = "Warszawa", SubName="Targówek"},
                new Miasto(){ Id = 69, PostalCode = "03-610", ViewName = "Warszawa", SubName="Targówek"},
                new Miasto(){ Id = 70, PostalCode = "04-428", ViewName = "Warszawa", SubName="Rembertównew"}
            });
        }
        
    }
}