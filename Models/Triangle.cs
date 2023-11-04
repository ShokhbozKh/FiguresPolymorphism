using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Triangle : Figure
    {
        public decimal SideA;
        public decimal SideB;
        public decimal Hipotenuse;
        public Triangle(decimal sideA, decimal sideB, decimal hipotenuse)
        {
            SideA = sideA;
            SideB = sideB;
            Hipotenuse = hipotenuse;
        }
        public override void Area()
        {
            decimal result = (SideA * SideB) / 2;
            Console.WriteLine($"Uchburchak yuzi:{result}");
        }
        public override void Perimetr()
        {
            decimal result = SideA + SideB + Hipotenuse;
            Console.WriteLine($"Uchburchak perimetri:{result}");

        }

    }
}
