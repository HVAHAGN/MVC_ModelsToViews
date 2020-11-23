using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _003.ViewModel.Models;

namespace _003.ViewModel.ViewModels
{
    public class GamesViewModel
    {
        public IEnumerable<PCGame> PCGames { get; set; }
        public IEnumerable<XBoxGame> XBoxGames { get; set; }
    }
}
