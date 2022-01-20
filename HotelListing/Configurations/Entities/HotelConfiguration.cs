using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel()
                {
                    ID = 1,
                    Name = "Hotel Intercontinental",
                    Address = "Dhaka",
                    CountryID = 1,
                    Rating = 4.5
                },
                new Hotel()
                {
                    ID = 2,
                    Name = "Hotel California",
                    Address = "California",
                    CountryID = 2,
                    Rating = 4.8
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
