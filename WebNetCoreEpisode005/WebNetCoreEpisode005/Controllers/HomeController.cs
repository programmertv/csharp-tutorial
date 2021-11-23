using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNetCoreEpisode005.Models;

namespace WebNetCoreEpisode005.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var person = new PersonViewModel()
            {
                FirstName = "Pro Grammer",
                LastName = "TV",
                Gender = Gender.Male,
                Age = 32,
                FavoriteMovies = new List<string> { "Avatar", "Titanic" }
            };

            return View(person);
        }

        public IActionResult Create()
        {
            return View(new PersonViewModel() {
                FirstName = "Frace",
                IsVoter = true,
                Profession = "Programmer"
            });
        }

        public IActionResult Createv2()
        {
            return View(new PersonViewModel()
            {
                FirstName = "Frace",
                IsVoter = true,
                Profession = "Programmer"
            });
        }

        public IActionResult Save(PersonViewModel submittedMode)
        {
            //Do something here...


            return View("Result", submittedMode);
        }

        public IActionResult TestFullName()
        {
            return PartialView("_FullName", new PersonViewModel {
                FirstName = "Test",
                LastName = "Only"
            });
        }
    }
}
