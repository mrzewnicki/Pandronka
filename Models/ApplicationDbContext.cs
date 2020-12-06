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
        public DbSet<Status> Status { get; set; }
        public DbSet<Zamowienia> Zamowienia { get; set; }
    }
}