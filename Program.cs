using ConsoleApp5.Models;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Rasmda berilgan struktura asosida klasslarni yarating. area() va
            //perimeter() methodlarini overriding usulida amalga oshiring.
            Circle circle = new(12);
            circle.Area();
            circle.Perimetr();

            Triangle triangle = new(2, 3, 4);
            triangle.Area();
            triangle.Perimetr();

            Rectangle rectangle = new(12,20);
            triangle.Area();
            triangle.Perimetr();
        }
    }
}