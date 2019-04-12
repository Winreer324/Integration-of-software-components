using Pr7.modules;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr7
{
    public class Engine : Entity
    {
        public double Power { get; set; }
        public double Volume { get; set; }

        public Engine(double Power, double Volume)
        {
            this.Power = Power;
            this.Volume = Volume;
        }
        //вторичный ключ
        [Key]
        [ForeignKey("auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}
