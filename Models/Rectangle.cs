using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Rectangle : Figure
    {
        public decimal SideA;
        public decimal SideB;
        public Rectangle(decimal sideA, decimal sideB)
        {
            SideA = sideA;
            SideB = sideB;
        }
        public override void Area()
        {
            decimal result = SideA * SideB;
            Console.WriteLine($"Turtburchak yuzi:{result}");
        }
        public override void Perimetr()
        {
            decimal result = 2*(SideA + SideB);
            Console.WriteLine($"Turtburchak peremetri:{result}");
        }
    }
}
