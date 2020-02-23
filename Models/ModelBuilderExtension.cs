using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DriverEd.Models
{
    public static class ModelBuilderExtension
    {
        public static void SeedRoles(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole("Admin"),
                new IdentityRole("Instructor"),
                new IdentityRole("Student")
            );
        }
    }
}
