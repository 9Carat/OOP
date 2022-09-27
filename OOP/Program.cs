namespace OOP
{
    class Triangle
    {
        float _Base;
        float _Height;

        public Triangle(float Base, float Height )
        {
            _Base = Base;
            _Height = Height;
        }

        public float GetArea()
        {
            float area = _Base * _Height / 2;
            return area;
        }
    }


    class Circle
    {
        float _pi;
        int _Radius;

        public Circle(int radius)
        {
            _Radius = radius;
            _pi = 3.14f;
        }

        public float GetArea()
        {
            float area = _Radius * _Radius * _pi;
            return area;
        }

        public float GetVolume()
        {
            double volumeDouble = 4.187 * Math.Pow(_Radius, 3);
            float volumeFloat = (float)volumeDouble;
            return volumeFloat;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            Circle sphere1 = new Circle(8);
            Triangle triangle1 = new Triangle(4, 9);

            Console.WriteLine("Den första cirkelns area är: " + circle1.GetArea());
            Console.WriteLine("Den andra cirkelns area är: " + circle2.GetArea());
            Console.WriteLine("Sfärens volym är: " + sphere1.GetVolume());
            Console.WriteLine("Triangelns area är: " + triangle1.GetArea());
        }
    }
}