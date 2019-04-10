using Pr6.models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr6
{
    public class Wheel : Entity
    { 
        public int Diameter { get; set; }
        public double Price { get; set; }
        public string WheelManufacturer { get; set; }

        //вторичный ключ
        [Key]
        [ForeignKey("Auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}