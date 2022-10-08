using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Triangle
    {
        float Base;
        float Height;
        float Side1;
        float Side2;
        float Side3;

        public Triangle(float Side1, float Side2, float Side3) // Constructor for calculation of circumference
        {
            this.Side1 = Side1;
            this.Side2 = Side2;
            this.Side3 = Side3;
        }

        public Triangle(float Base, float Height) // Constructor for calculation of area
        {
            this.Base = Base;
            this.Height = Height;
        }

        public float GetArea() // Methods for area and circumference
        {
            float area = Base * Height / 2;
            return area;
        }

        public float GetCircumference()
        {
            float circ = Side1 + Side2 + Side3;
            return circ;
        }
    }
}
