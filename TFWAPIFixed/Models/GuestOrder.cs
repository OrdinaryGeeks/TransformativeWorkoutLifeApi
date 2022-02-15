using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class GuestOrder
    {
        [Key] //Name of Merchant DateTimeStamp
        public string? ID { get; set; }
        public string? GuestID { get; set; }
        public virtual ICollection<GuestItemOrdered>? ItemsOrdered { get; set; }
        public bool isPaid { get; set; }
    }
}
