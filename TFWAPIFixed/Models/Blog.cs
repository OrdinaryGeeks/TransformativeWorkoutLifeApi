using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class Blog
    {
        [Key] //Title
        public string? ID { get; set; }

        public string? TitleHeader { get; set; }
        public virtual ICollection<Blurb>? Blurbs { get; set; }

        public string? GuestID { get; set; }
    }
}
