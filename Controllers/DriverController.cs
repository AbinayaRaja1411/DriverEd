using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DriverEd.Controllers
{
    public class DriverController : Controller
    {
        public IActionResult ListDrivers()
        {
            return View();
        }
    }
}