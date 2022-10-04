namespace OOP
{
    internal class Program
    {
        class Triangle
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

        class Circle
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

        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            Circle sphere1 = new Circle(8);
            Triangle triangle1 = new Triangle(4, 9);
            Triangle triangle2 = new Triangle(5, 12, 5);

            Console.WriteLine("Den första cirkelns area är: " + circle1.GetArea());
            Console.WriteLine("Den andra cirkelns area är: " + circle2.GetArea());
            Console.WriteLine("Sfärens volym är: " + sphere1.GetVolume());
            Console.WriteLine("Den första triangelns area är: " + triangle1.GetArea());
            Console.WriteLine("Den andra triangelns omkrets är: " + triangle2.GetCircumference());
        }
    }
}