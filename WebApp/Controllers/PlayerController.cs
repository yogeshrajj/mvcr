using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class PlayerController : Controller
    {
        public IActionResult Index()
        {
            List<Player> lstPlayers = new List<Player>
            {
                new Player{ PId=1, PName="MSd", PAvg=60, PTeam="CSK"},
                new Player{ PId=3, PName="MSd", PAvg=60, PTeam="CSK"},
                new Player{ PId=5, PName="MSd", PAvg=60, PTeam="CSK"},
                new Player{ PId=4, PName="MSd", PAvg=60, PTeam="CSK"},
                new Player{ PId=2, PName="MSd", PAvg=60, PTeam="CSK"},

            };
            return View(lstPlayers);
        }
    }
}
