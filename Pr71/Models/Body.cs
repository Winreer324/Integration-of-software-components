using Pr7.models;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pr7
{
    public class Body : Entity
    { 
        public string BodyColor { get; set; }
        public double BodyWeight { get; set; }

        //вторичный ключ
        [Key]
        [ForeignKey("Auto")]
        public int AutoId { get; set; }
        public Auto Auto { get; set; }
    }
}