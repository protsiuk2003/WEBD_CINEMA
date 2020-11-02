using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BD_CINEMA.Data;
using BD_CINEMA.Models;

namespace BD_CINEMA.Pages.Repertioires
{
    public class EditModel : PageModel
    {
        private readonly BD_CINEMA.Data.BD_CINEMAContext _context;

        public EditModel(BD_CINEMA.Data.BD_CINEMAContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Repertoire Repertoire { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Repertoire = await _context.Repertoire.FirstOrDefaultAsync(m => m.ID == id);

            if (Repertoire == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Repertoire).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!RepertoireExists(Repertoire.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool RepertoireExists(long id)
        {
            return _context.Repertoire.Any(e => e.ID == id);
        }
    }
}
