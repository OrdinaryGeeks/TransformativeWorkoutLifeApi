using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class Bio
    {
        [Key]//Title
        public string? ID { get; set; }
        //Hold social media links for bio and footer
        public string? FBLink { get; set; }
        public string? IGLink { get; set; }
        public string? SnapLink { get; set; }
        public string? YoutubeLink { get; set; }

        //A blurb consists of an orientation, and optional media and text
        public virtual ICollection<Blurb>? blurbs { get; set; }

        public string? GuestID { get; set; }
    }
}
