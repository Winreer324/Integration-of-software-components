using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr7
{
    public class Body
    {
        public string BodyColor { get; set; }
        public double BodyWeight { get; set; }

        public Body(string BodyColor, double BodyWeight)
        {
            this.BodyColor = BodyColor;
            this.BodyWeight = BodyWeight;
        } 
        //вторичный ключ
        [Key]
        [ForeignKey("auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }  
}