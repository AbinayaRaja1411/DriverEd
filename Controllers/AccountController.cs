using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DriverEd.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DriverEd.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(BasicRegistrationViewModel basicRegistration)
        {
            return View(basicRegistration);
        }
    }
}