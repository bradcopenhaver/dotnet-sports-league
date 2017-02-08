using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsLeagueOrganizer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsLeagueOrganizer.Controllers
{
    public class PlayersController : Controller
    {
        private SportsLeagueOrganizerContext db = new SportsLeagueOrganizerContext();
        public IActionResult Index()
        {
            return View(db.Players.ToList());
        }

        public IActionResult Details(int id)
        {
            var thisPlayer = db.Players.FirstOrDefault(players => players.PlayerId == id);

            try
            {
                var teams = db.Affiliations
                    .Where(affiliations => affiliations.PlayerId == id)
                    .ToList();

                ViewBag.playerTeams = new SelectList(teams, "TeamId", "TeamId");
                ViewBag.welcomemessage = "Hello!";
                return View(thisPlayer);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return View(thisPlayer);
            }
        }
    }
}
