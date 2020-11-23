using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _003.ViewModel.Models;
using _003.ViewModel.ViewModels;

namespace _003.ViewModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            PCGame fallout = new PCGame()
            {
                Name = "Fallout 4",
                Language = "C++"
            };

            PCGame stalker = new PCGame()
            {
                Name = "S.T.A.L.K.E.R.",
                Language = "C++ & Lua Script"
            };

            PCGame masseffect = new PCGame()
            {
                Name = "Mass Effect",
                Language = "C++"
            };

            List<PCGame> PCGamesCollection = new List<PCGame>();
            PCGamesCollection.Add(fallout);
            PCGamesCollection.Add(stalker);
            PCGamesCollection.Add(masseffect);

            XBoxGame minecraft = new XBoxGame()
            {
                Name = "Minecraft",
                Language = "Java"
            };

            XBoxGame obsolete = new XBoxGame()
            {
                Name = "Obsolete",
                Language = "C#"
            };

            XBoxGame crysis = new XBoxGame()
            {
                Name = "Crysis",
                Language = "C++"
            };

            List<XBoxGame> XBoxGamesCollection = new List<XBoxGame>();
            XBoxGamesCollection.Add(minecraft);
            XBoxGamesCollection.Add(obsolete);
            XBoxGamesCollection.Add(crysis);

            GamesViewModel viewModel = new GamesViewModel()
            {
                PCGames = PCGamesCollection,
                XBoxGames = XBoxGamesCollection
            };

            return View(viewModel);
        }
    }
}
