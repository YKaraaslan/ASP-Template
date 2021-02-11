using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UWA.Entities
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(20)]
        public string Surname { get; set; }

        [StringLength(50)]
        public string Department { get; set; }

        [StringLength(50)]
        public string Position { get; set; }
    }
}