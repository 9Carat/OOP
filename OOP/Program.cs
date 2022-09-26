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
        }

        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5);
            Circle circle2 = new Circle(6);

            Console.WriteLine("Den första cirkelns radie är: " + circle1.GetArea());
            Console.WriteLine("Den andra cirkelns radie är: " + circle2.GetArea());
        }
    }
}