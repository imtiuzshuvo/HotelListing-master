using HotelListing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Configurations.Entities
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasData(
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
        }
    }
}
