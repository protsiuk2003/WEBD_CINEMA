using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_CINEMA.Data;
using BD_CINEMA.Models;

namespace BD_CINEMA.Pages.Films
{
    public class DeleteModel : PageModel
    {
        private readonly BD_CINEMA.Data.BD_CINEMAContext _context;

        public DeleteModel(BD_CINEMA.Data.BD_CINEMAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Film.FirstOrDefaultAsync(m => m.ID == id);

            if (Film == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Film.FindAsync(id);

            if (Film != null)
            {
                _context.Film.Remove(Film);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
