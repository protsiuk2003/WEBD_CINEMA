using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BD_CINEMA.Models;

namespace BD_CINEMA.Data
{
    public class BD_CINEMAContext : DbContext
    {
        public BD_CINEMAContext (DbContextOptions<BD_CINEMAContext> options)
            : base(options)
        {
        }

        public DbSet<BD_CINEMA.Models.Staff> Staff { get; set; }

        public DbSet<BD_CINEMA.Models.Seat> Seat { get; set; }

        public DbSet<BD_CINEMA.Models.Repertoire> Repertoire { get; set; }

        public DbSet<BD_CINEMA.Models.Position> Position { get; set; }

        public DbSet<BD_CINEMA.Models.Genre> Genre { get; set; }

        public DbSet<BD_CINEMA.Models.Film> Film { get; set; }
    }
}
