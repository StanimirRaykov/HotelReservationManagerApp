using HotelReservationManager.Models.Entity_Models;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public virtual Room Room { get; set; }
        public virtual AppUser AppUser { get; set; }

        public virtual List<ClientReservation> ClientReservations { get; set; }

        public DateTime DateOfAccommodation { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool BreakfastIncluded { get; set; } 

        public bool AllInclusiveIncluded { get; set; }

        public double OwedAmount { get; set; }

    }
}
