using Castle.Core.Resource;
using HotelReservationManager.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HotelReservationManager.Data
{
    public class HotelManagerDbContext : IdentityDbContext<IdentityUser>
    {
        public HotelManagerDbContext(DbContextOptions<HotelManagerDbContext> options)
        : base(options)
        {
        }

        public DbSet<AppUser> User { get; set; }
        public DbSet<Client> ClientData { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
    }
}
