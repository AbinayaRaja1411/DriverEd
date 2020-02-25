using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DriverEd.CustomAttributes
{
    public class ValidateRoleAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            RoleManager<IdentityRole> roleManager = (RoleManager<IdentityRole>) validationContext.GetService(typeof(RoleManager<IdentityRole>));
            string roleName = (string)value;
            if(roleManager.Roles.Any(role => role.Name == roleName))
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Invalid role");
            }
        }
    }
}
