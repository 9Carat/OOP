using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Circle
    {
        float pi;
        int Radius;

        public Circle(int radius)
        {
            this.Radius = radius;
            this.pi = 3.14f;
        }

        public float GetArea()
        {
            float area = Radius * Radius * pi;
            return area;
        }

        public float GetVolume()
        {
            double volumeDouble = 4.187 * Math.Pow(Radius, 3);
            float volumeFloat = (float)volumeDouble;
            return volumeFloat;
        }
    }
}
