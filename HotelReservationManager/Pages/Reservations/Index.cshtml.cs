using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HotelReservationManager.Data;
using HotelReservationManager.Models;

namespace HotelReservationManager.Pages.Reservations
{
    public class IndexModel : PageModel
    {
        private readonly HotelReservationManager.Data.HotelManagerDbContext _context;

        public IndexModel(HotelReservationManager.Data.HotelManagerDbContext context)
        {
            _context = context;
        }

        public IList<Reservation> Reservation { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Reservations != null)
            {
                Reservation = await _context.Reservations.ToListAsync();
            }
        }
    }
}
