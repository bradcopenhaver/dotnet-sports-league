﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsLeagueOrganizer.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace SportsLeagueOrganizer.Controllers
{
    public class DivisionsController : Controller
    {
        private SportsLeagueOrganizerContext db = new SportsLeagueOrganizerContext();
        public IActionResult Index()
        {
            return View(db.Divisions.ToList());
        }
    }
}
