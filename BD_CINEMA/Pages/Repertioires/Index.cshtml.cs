using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BD_CINEMA.Data;
using BD_CINEMA.Models;

namespace BD_CINEMA.Pages.Repertioires
{
    public class IndexModel : PageModel
    {
        private readonly BD_CINEMA.Data.BD_CINEMAContext _context;

        public IndexModel(BD_CINEMA.Data.BD_CINEMAContext context)
        {
            _context = context;
        }

        public IList<Repertoire> Repertoire { get;set; }

        public async Task OnGetAsync()
        {
            Repertoire = await _context.Repertoire.ToListAsync();
        }
    }
}
