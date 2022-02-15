using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class GuestSchedule
    {
        [Key]
        public string? ID { get; set; }
        public virtual ICollection<GuestTrainingOrdered>? Schedule { get; set; }
        public string? GuestID { get; set; }
    }
}
