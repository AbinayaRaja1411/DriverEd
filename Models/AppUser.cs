using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverEd.Models
{
    public class AppUser : IdentityUser
    {
        public Address Address { get; set; }
    }
}
