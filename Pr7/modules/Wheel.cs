using Pr7.modules;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr7
{
    public class Wheel : Entity
    {
        public int Diameter { get; set; }
        public double Price { get; set; }
        public string WheelManufacturer { get; set; }


        public Wheel(int Diameter, double Price, string WheelManufacturer)
        {
            this.Diameter = Diameter; this.Price = Price; this.WheelManufacturer = WheelManufacturer;
        }
        //вторичный ключ
        [Key]
        [ForeignKey("auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}