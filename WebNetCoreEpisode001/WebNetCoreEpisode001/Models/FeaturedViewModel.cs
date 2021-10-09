using System;
namespace WebNetCoreEpisode001.Models
{
    public class FeaturedViewModel
    {
        public string Id { get; set; }
        public string Header { get; set; }
        public string Title { get; set; }
        public DateTime PostedDate { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
