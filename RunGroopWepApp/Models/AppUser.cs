using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RunGroopWepApp.Models
{
    public class AppUser : IdentityUser
    {
        [Key]
        public string Id { get; set; }
        public int? Pace { get; set; }
        public int? Mileage { get; set; }
        public Address? Address { get; set; }

        public ICollection<Race> Races { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public string UserName { get; internal set; }
    }
}
