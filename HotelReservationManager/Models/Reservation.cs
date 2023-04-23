using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.Models
{
    public class Reservation
    {
        [Key]
        public int ReservationId { get; set; }
        public int RoomId { get; set; }
        public int UserId { get; set; }

        public IEnumerable<Client> Clients { get; set; }

        public DateTime DateOfAccommodation { get; set; }

        public DateTime ReleaseDate { get; set; }

        public bool BreakfastIncluded { get; set; } 

        public bool AllInclusiveIncluded { get; set; }

        public double OwedAmount { get; set; }
    }
}
