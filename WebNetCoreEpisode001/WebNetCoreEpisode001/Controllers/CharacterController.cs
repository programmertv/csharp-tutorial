using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNetCoreEpisode001.Models;

namespace WebNetCoreEpisode001.Controllers
{
    public class CharacterController : Controller
    {
        public IActionResult Index()
        {
            var characters = new List<CharacterModel>()
            {
                new CharacterModel()
                {
                    Id = "luffy",
                    Name = "Monkey D. Luffy",
                    Description = @"Monkey D. Luffy, also known as ""Straw Hat"" Luffy, is a fictional character and the main protagonist of the One Piece manga series, created by Eiichiro Oda."
                },
                new CharacterModel()
                {
                    Id = "zoro",
                    Name = "Roronoa Zoro",
                    Description = @"Roronoa Zoro, nicknamed ""Pirate Hunter"" Zoro, is a fictional character in the One Piece franchise created by Eiichiro Oda. In the story, Pirate Hunter Zoro is the first to join Monkey D. Luffy after he is saved from being executed at the Marine Base.",
                },
                new CharacterModel()
                {
                    Id = "sanji",
                    Name = "Vinsmoke Sanji",
                    Description = @"""Black Leg"" Sanji, born as Vinsmoke Sanji, is the cook of the Straw Hat Pirates. He is the fifth member of the crew and the fourth to join, doing so at the end of the Baratie Arc."
                }
            };

            return View(characters);
        }
    }
}
