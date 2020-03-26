using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Charts.Models
{
    public class Track
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? DateCreated { get; set; }
        public TimeSpan? Time { get; set; }
        public IEnumerable<Singer>? Singers { get; } = new List<Singer>();
        [NotMapped]
        public virtual ICollection<Genre>? Genre { get; set; } = new List<Genre>();
    }
}
