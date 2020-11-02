using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_CINEMA.Data;
using BD_CINEMA.Models;

namespace BD_CINEMA.Pages.Generes
{
    public class DetailsModel : PageModel
    {
        private readonly BD_CINEMA.Data.BD_CINEMAContext _context;

        public DetailsModel(BD_CINEMA.Data.BD_CINEMAContext context)
        {
            _context = context;
        }

        public Genre Genre { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Genre = await _context.Genre.FirstOrDefaultAsync(m => m.ID == id);

            if (Genre == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
