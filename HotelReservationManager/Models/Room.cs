using HotelReservationManager.Enums;
using System.ComponentModel.DataAnnotations;

namespace HotelReservationManager.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }
        public int Size { get; set; }
        public RoomType Type { get; set; }
        public bool IsTaken { get; set; }
        public double AdultPrice { get; set; }
        public double ChildPrice { get; set; }

        public int RoomNumber { get; set; }

        public virtual IEnumerable<Reservation> Reservations { get; set; }
    }
}
