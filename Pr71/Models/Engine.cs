using Pr7.models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr7
{
    public class Engine : Entity
    { 
        public double Power { get; set; }
        public double Volume { get; set; }

        //вторичный ключ
        [Key]
        [ForeignKey("Auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}
