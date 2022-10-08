// Christoffer Ottestig
// NET22

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // Instantiation of the different objects
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