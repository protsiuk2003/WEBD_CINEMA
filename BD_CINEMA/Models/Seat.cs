using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD_CINEMA.Models
{
    public class Seat
    {
        public long ID { get; set; }
        public int Number { get; set; }
        public string Occupancy { get; set; }
        public DbSet<Staff> StaffID { get; set; }
    }
}
