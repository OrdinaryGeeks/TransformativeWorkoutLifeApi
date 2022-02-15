using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class GuestItemOrdered
    {
        [Key]
        public string? ID { get; set; }
        public string? ItemID { get; set; }
        public int Quantity { get; set; }
    }
}
