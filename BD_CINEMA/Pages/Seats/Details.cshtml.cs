using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_CINEMA.Data;
using BD_CINEMA.Models;

namespace BD_CINEMA.Pages.Seats
{
    public class DetailsModel : PageModel
    {
        private readonly BD_CINEMA.Data.BD_CINEMAContext _context;

        public DetailsModel(BD_CINEMA.Data.BD_CINEMAContext context)
        {
            _context = context;
        }

        public Seat Seat { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Seat = await _context.Seat.FirstOrDefaultAsync(m => m.ID == id);

            if (Seat == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
