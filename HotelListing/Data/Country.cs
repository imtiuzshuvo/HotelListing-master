using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Shortname { get; set; }

        public virtual IList<Hotel> Hotels { get; set; }
    }
}
