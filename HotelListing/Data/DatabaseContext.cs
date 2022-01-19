using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class DatabaseContext : IdentityDbContext<APIUser>
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {}

        public DbSet<Country> Countries { get; set; }
        public DbSet<Hotel> Hotels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>().HasData(
                new Country()
                {
                    ID = 1,
                    Name = "Bangladesh",
                    Shortname = "BD"
                },
                new Country()
                {
                    ID = 2,
                    Name = "United States of America",
                    Shortname = "US"
                },
                new Country()
                {
                    ID = 3,
                    Name = "India",
                    Shortname = "IN"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel()
                {
                    ID = 1,
                    Name = "Hotel Intercontinental",
                    Address = "Dhaka",
                    CountryID = 1,
                    Rating = 4.5
                },
                new Hotel ()
                {
                    ID = 2,
                    Name = "Hotel California",
                    Address = "California",
                    CountryID = 2,
                    Rating = 5
                },
                new Hotel()
                {
                    ID = 3,
                    Name = "Hotel Taj",
                    Address = "New Delhi",
                    CountryID = 3,
                    Rating = 4.3
                }
            );
        }
    }
}
