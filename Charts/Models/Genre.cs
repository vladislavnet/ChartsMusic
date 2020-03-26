using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [NotMapped]
        public virtual ICollection<Track> Tracks { get; set; } = new List<Track>();
    }
}
