﻿using Pr7;
using Pr7.models;
using System;
using System.Collections.Generic;

namespace Pr7
{ 
    public class Auto : Entity
    {
        public int Id { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; } 
    }

    class GFG : IComparer<Auto>
    {
        public int Compare(Auto x, Auto y)
        {
            if (x.Price == 0 || y.Price == 0)
            {
                return 0;
            }

            return x.Price.CompareTo(y.Price);
        }
    }
}