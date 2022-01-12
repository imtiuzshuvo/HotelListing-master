﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateHotelDTO
    {
        
        [Required]
        [StringLength(maximumLength: 150, ErrorMessage = "Hotel name is too long!")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 255, ErrorMessage = "Address is too long!")]
        public string Address { get; set; }

        [Required]
        [Range(1,5)]
        public double Rating { get; set; }

        [Required]
        public int CountryID { get; set; }
    }

    public class HotelDTO : CreateHotelDTO
    {
        public int ID { get; set; }
        public CountryDTO Country { get; set; }
    }
}
