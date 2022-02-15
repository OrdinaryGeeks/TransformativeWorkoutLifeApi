using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class GuestTrainingOrdered
    {
        [Key]
        public string? ID { get; set; }
        public int TrainingID { get; set; }

        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }




    }
}
