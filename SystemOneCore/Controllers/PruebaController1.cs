using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SystemOneCore.Controllers
{
    public class PruebaController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
