using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNetCoreEpisode001.Models;

namespace WebNetCoreEpisode001.Controllers
{    
    public class DetailController : Controller
    {
        public IActionResult Index(string id, string pageType)
        {
            var characters = new List<CharacterModel>()
            {
                new CharacterModel()
                {
                    Id = "luffy",
                    Name = "Monkey D. Luffy",
                    Description = @"Monkey D. Luffy (/ˈluːfi/ LOO-fee) (Japanese: モンキー・D・ルフィ, Hepburn: Monkī Dī Rufi, [ɾɯɸiː]), also known as ""Straw Hat"" Luffy[n 1], is a fictional character and the main protagonist of the One Piece manga series, created by Eiichiro Oda. Luffy made his debut in One Piece Chapter #1 as a young boy who acquires the properties of rubber after accidentally eating the supernatural Gum-Gum Fruit, one of the so-called Devil Fruits."
                },
                new CharacterModel()
                {
                    Id = "zoro",
                    Name = "Roronoa Zoro",
                    Description = @"Roronoa Zoro (ロロノア・ゾロ, spelled as ""Roronoa Zoro"" in some English adaptations), nicknamed ""Pirate Hunter"" Zoro (海賊狩りのゾロ, Kaizoku-Gari no Zoro), is a fictional character in the One Piece franchise created by Eiichiro Oda.",
                },
                new CharacterModel()
                {
                    Id = "sanji",
                    Name = "Vinsmoke Sanji",
                    Description = @"""Black Leg"" Sanji,[6] born as Vinsmoke Sanji,[23][24][25] is the cook of the Straw Hat Pirates. He is the fifth member of the crew and the fourth to join, doing so at the end of the Baratie Arc. Born as the third son and fourth child of the Vinsmoke Family[26] (thus making him a prince of the Germa Kingdom), he disowned his family twice, once in his youth and again after reuniting with them as an adult.[27] After fleeing the Vinsmokes as a child, he eventually entered the care of Zeff as the sous chef of the Baratie, where he would remain until he met Luffy, who convinced him to join his crew."
                }
            };

            var detail = characters.FirstOrDefault(c => c.Id == id);
            ViewBag.PageType = pageType;

            return View(detail);
        }
    }
}
