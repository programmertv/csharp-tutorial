using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebNetCoreEpisode005.Models
{
    public class PersonViewModel
    {        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<string> FavoriteMovies { get; set; }
        public bool IsVoter { get; set; }
        public string Profession { get; set; }
        public AddressViewModel Address { get; set; }
    }

    public class AddressViewModel
    {
        public string Brgy { get; set; }
        public string City { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}
