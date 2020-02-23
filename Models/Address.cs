using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverEd.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
