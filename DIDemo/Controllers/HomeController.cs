using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DIDemo.Models;

namespace DIDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWheel iWheel;

        public HomeController(IWheel iWheel)
        {
            this.iWheel = iWheel;
        }

        public IActionResult Index()
        {
            return View(this.iWheel);
        }

    }
}
