using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.Models
{
    public class AppUser : IdentityUser
    {
        [Key]
        public int Id { get; set; }
        public string RegisterName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UCN { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfAppointment { get; set; }
        public bool IsActive { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
