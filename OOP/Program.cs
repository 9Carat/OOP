namespace OOP
{
    internal class Program
    {
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

        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);
            Circle sphere1 = new Circle(8);

            Console.WriteLine("Den första cirkelns radie är: " + circle1.GetArea());
            Console.WriteLine("Den andra cirkelns radie är: " + circle2.GetArea());
            Console.WriteLine("Sfärens volym är: " + sphere1.GetVolume());
        }
    }
}