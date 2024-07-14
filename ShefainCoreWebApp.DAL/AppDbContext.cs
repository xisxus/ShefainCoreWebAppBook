using Microsoft.EntityFrameworkCore;
using ShefainCoreWebApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ShefainCoreWebApp.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base()
        { }

        public AppDbContext(DbContextOptions options) : base(options)
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<LookUp> LookUps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(new List<Person>
            {
                new Person { Id = 1, FirstName = "Md", LastName = "Shefain", EmailAddress = "shefain@gmail.com"},
                new Person { Id = 2, FirstName = "shohana", LastName = "howlader", EmailAddress = "shohana@gmail.com"}
            });

            modelBuilder.Entity<Address>().HasData(new List<Address>
            {
                new Address() { Id = 1 , AddressLine1 = "mirpur", AddressLine2 = "25", City = "Dhaka", State = "DK", ZipCode = "1210", PersonId = 1, Country = "RajakarDesh"},
                new Address() { Id = 2 , AddressLine1 = "mmpur", AddressLine2 = "25", City = "Dhaka", State = "DK", ZipCode = "1210", PersonId = 2, Country = "RajakarDesh"},
                new Address() { Id = 3 , AddressLine1 = "Azimpur", AddressLine2 = "25", City = "Dhaka", State = "DK", ZipCode = "1210", PersonId = 2, Country = "RajakarDesh"}
                
            });

            modelBuilder.Entity<LookUp>().HasData(new List<LookUp>
            {
                new LookUp() {Code = "BD", Description = "Dhaka", LookUpType = LookUpType.State},
                new LookUp() {Code = "JK", Description = "Saidpur", LookUpType = LookUpType.State},
                new LookUp() {Code = "RK", Description = "Gazipur", LookUpType = LookUpType.State},
                new LookUp() {Code = "PI", Description = "Banani", LookUpType = LookUpType.State},
                
            });
        }

        protected Person CreateClarkKent()
        {
            return new Person
            {
                FirstName = "Ashik",
                LastName = "Mia",
                EmailAddress = "ashik@gmail.com",
                Addresses = new List<Address>
                {
                    new Address
                    {
                        AddressLine1 = "7/6 Mirpur",
                        AddressLine2 = "Suite 1",
                        City = "Dhaka",
                        State = "DK",
                        ZipCode = "1205",
                        Country = "RajakarDesh"
                    }
                }
            };
        }
    }
}
