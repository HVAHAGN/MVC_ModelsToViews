using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _001.SingleModel.Models;

namespace _001.SingleModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Game fallout = new Game()
            {
                Name = "Fallout 4",
                Platform = "Windows",
                Engine = "Creation Engine"
            };

            return View(fallout);
        }
    }
}
