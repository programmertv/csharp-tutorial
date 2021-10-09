using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNetCoreEpisode001.Models;

namespace WebNetCoreEpisode001.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var featuredPosts = new List<FeaturedViewModel>
            {
                new FeaturedViewModel() {
                    Id = "luffy",
                    Header = "Characters",
                    Title = "Monkey D Luffy",
                    PostedDate = DateTime.Now,
                    Description = @"Monkey D. Luffy, also known as ""Straw Hat"" Luffy, is a fictional character and the main protagonist of the One Piece manga series, created by Eiichiro Oda.",
                    ImageUrl = "luffy.jpeg"
                },
                new FeaturedViewModel() {
                    Id = "zoro",
                    Header = "Videos",
                    Title = "Roronoa Zoro",
                    PostedDate = DateTime.Now,
                    Description = @"Roronoa Zoro, nicknamed ""Pirate Hunter"" Zoro, is a fictional character in the One Piece franchise created by Eiichiro Oda. In the story, Pirate Hunter Zoro is the first to join Monkey D. Luffy after he is saved from being executed at the Marine Base.",
                    ImageUrl = "zoro.jpeg"
                }
            };

            return View(featuredPosts);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Pribado");
        }
    }

    public class FraceController: Controller
    {
        public IActionResult Marteja() {

            return View();
        }
    }

}
