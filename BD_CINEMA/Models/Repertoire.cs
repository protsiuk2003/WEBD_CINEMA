using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BD_CINEMA.Models
{
    public class Repertoire
    {
        public long ID { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Price{ get; set; }

    }
}
