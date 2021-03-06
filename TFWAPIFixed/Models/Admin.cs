using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class Admin
    {
        [Key]  //Name for Admin associated with the GuestID
        public string? ID { get; set; }

        public string? Name { get; set; }

        public bool IsValidated { get; set; }
        public bool IsSuperAdmin { get; set; }

        public string? FBLInk { get; set; }
        public string? IGLink { get; set; }
        public string? SCLink { get; set; }
        public string? YTLink { get; set; }


        public Boolean MediaTop { get; set; }
        public Boolean MediaBottom { get; set; }
        public Boolean MediaLeft { get; set; }
        public Boolean MediaRight { get; set; }
        public string? MediaLink { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public Boolean Image { get; set; }
        public Boolean Video { get; set; }
        public string? Text { get; set; }



        public DateTimeOffset PostedDate { get; set; }






    }
}
