using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr7
{
    public class Door
    { 
        public double Price { get; set; }
        public string ColorDoor { get; set; }

        public Door(double Price, string ColorDoor)
	    {
            this.Price = Price; this.ColorDoor = ColorDoor;
        } 

        //вторичный ключ
        [Key]
        [ForeignKey("auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}
