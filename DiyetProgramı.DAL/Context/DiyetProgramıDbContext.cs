using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using DiyetProgramı.Entities.Concrete;
using DiyetProgramı.Entities.Enum;

namespace DiyetProgramı.DAL.Context
{
    internal class DiyetProgramıDbContext : DbContext
    {
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["connectionString"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Kullanici>()
                .Property(x=>x.KullaniciMail)
                .HasMaxLength(50); 
            modelBuilder
                .Entity<Kullanici>()
                .Property(x => x.KullaniciAdi)
                .HasMaxLength(30);
            modelBuilder
                .Entity<Kullanici>()
                .Property(x => x.KullaniciSoyadi)
                .HasMaxLength(30);
            modelBuilder
                .Entity<Kullanici>()
                .Property(x => x.KullaniciKilo)
                .HasPrecision(6, 2);


            modelBuilder
                .Entity<Yemek>()
                .Property(x => x.Kalori)
                .HasPrecision(7, 2);
            modelBuilder
                .Entity<Yemek>()
                .Property(x => x.YemekAdi)
                .HasMaxLength(25);
            modelBuilder
                .Entity<Ogun>()
                .Property(x => x.YemekPorsiyon)
                .HasPrecision(4, 2);

        }
    }
}
