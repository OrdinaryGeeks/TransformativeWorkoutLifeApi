using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TFWAPIFixed.Models
{
    public class Item
    {
        [Key]//Name
        public string? ID { get; set; }


        //Name of Product Page it is ap art of
        public string? ProductID { get; set; }
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



        
        /*
        //orientation = side by side, on top of , below,
        public Boolean MediaTop { get; set; }
        public Boolean MediaBottom { get; set; }
        public Boolean MediaLeft { get; set; }
        public Boolean MediaRight { get; set; }
        public string MediaLink { get; set; }
       public int Height { get; set; }
        public int Width { get; set; }
        
        public Boolean Image { get; set; }
        public Boolean Video { get; set; }
        public string Text { get; set; }
        
        public int Cost { get; set; }
        
        public string Description { get; set; }
        */
        public int Quantity { get; set; }
      
    }
}
