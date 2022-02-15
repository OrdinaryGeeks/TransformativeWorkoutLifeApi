using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class Guest
    {
        [Key] //Email Address
        public string? ID { get; set; }

       
        public virtual ICollection<GuestOrder>? Orders { get; set; }

        public virtual ICollection<GuestTrainingOrdered>? Trainings { get; set; }



        
    }
}
