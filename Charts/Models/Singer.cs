using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Models
{
    public class Singer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateEnd { get; set; }

        public IEnumerable<Track> Tracks { get; } = new List<Track>();
    }
}
