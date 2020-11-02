using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD_CINEMA.Models
{
    public class Staff
    {
        public long ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string PassportData { get; set; }
        public DbSet<Position> PositionID { get; set; }
    }
}
