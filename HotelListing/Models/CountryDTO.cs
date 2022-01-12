using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Models
{
    public class CreateCountryDTO
    {
        [Required]
        [StringLength(maximumLength: 90, ErrorMessage = "Country name is too long!")]
        public string Name { get; set; }
        
        [Required]
        [StringLength(maximumLength: 3, ErrorMessage = "Maximum three characters are allowed.")]
        public string Shortname { get; set; }
    }
    public class CountryDTO : CreateCountryDTO
    {
        public int ID { get; set; }
        public IList<HotelDTO> Hotels { get; set; }
    }
}
