using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebNetCoreEpisode001.Models;
namespace WebNetCoreEpisode001.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            var videos = new List<VideoModel>()
            {
                new VideoModel()
                {
                    Id = "luffy",
                    Name = "Monkey D. Luffy",
                    Description = @"Monkey D. Luffy, also known as ""Straw Hat"" Luffy, is a fictional character and the main protagonist of the One Piece manga series, created by Eiichiro Oda.",
                    VideoURL = "https://www.youtube.com/embed/_U_0uowl174"
                },
                new VideoModel()
                {
                    Id = "zoro",
                    Name = "Roronoa Zoro",
                    Description = @"Roronoa Zoro, nicknamed ""Pirate Hunter"" Zoro, is a fictional character in the One Piece franchise created by Eiichiro Oda. In the story, Pirate Hunter Zoro is the first to join Monkey D. Luffy after he is saved from being executed at the Marine Base.",
                    VideoURL = "https://www.youtube.com/embed/ZCIpJKE_WLg"
                },
                new VideoModel()
                {
                    Id = "sanji",
                    Name = "Vinsmoke Sanji",
                    Description = @"""Black Leg"" Sanji, born as Vinsmoke Sanji, is the cook of the Straw Hat Pirates. He is the fifth member of the crew and the fourth to join, doing so at the end of the Baratie Arc.",
                    VideoURL = "https://www.youtube.com/embed/tJtd-Bmsfmc"
                }
            };

            return View(videos);
        }
    }
}
