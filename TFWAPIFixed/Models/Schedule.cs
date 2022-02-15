using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class Schedule
    {
        public string? ID { get; set; }
        public DateTimeOffset StartTime { get; set; }
        public DateTimeOffset EndTime { get; set; }

        public string? OwnerID { get; set; }
    }
}
