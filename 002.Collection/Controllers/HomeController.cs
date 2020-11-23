using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _002.Collection.Models;

namespace _002.Collection.Controllers
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

            Game stalker = new Game()
            {
                Name = "S.T.A.L.K.E.R.",
                Platform = "Windows",
                Engine = "X-Ray Engine"
            };

            Game masseffect = new Game()
            {
                Name = "Mass Effect",
                Platform = "Windows",
                Engine = "Unreal Engine"
            };

            List<Game> collection = new List<Game>();
            collection.Add(fallout);
            collection.Add(stalker);
            collection.Add(masseffect);

            return View(collection);
        }
    }
}
