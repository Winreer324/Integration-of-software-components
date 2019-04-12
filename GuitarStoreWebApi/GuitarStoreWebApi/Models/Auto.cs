using System;
using System.Collections.Generic;

namespace GuitarsProject.DAL
{
    //public class Auto : IComparable<Auto>
    public class Auto
    {
        public int Id { get; set; }
        public string Firma { get; set; }
        public string Model { get; set; }
        public string Number { get; set; }
        public double Price { get; set; }
        public double Speed { get; set; }
        public Body Body { get; set; }
        public Door Door { get; set; }
        public Wheel Wheel { get; set; }
        public Engine Engine { get; set; }

        public int CompareTo(Auto auto)
        {
            return this.Firma.CompareTo(auto.Firma);
        }

        public class BodyColorComparer : IComparer<Auto>
        {
            public int Compare(Auto autoFirst, Auto autoSecond)
            {
                //if (autoFirst.Body.BodyColor.ToLower()[0] > autoSecond.Body.BodyColor.ToLower()[0])
                //    return 1;
                //else if (autoFirst.Body.BodyColor.ToLower()[0] < autoSecond.Body.BodyColor.ToLower()[0])
                //    return -1;
                //else
                    return 0;
            }
        }
    }
}