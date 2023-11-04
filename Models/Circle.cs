using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Circle : Figure
    {
        public decimal Raduis;
        public Circle(decimal raduis)
        {
            Raduis = raduis;
        }
        public override void Area()
        {
            decimal result = (decimal)Math.PI * (Raduis * Raduis);
            Console.WriteLine($"Aylana yuzi:{result}");
        }
        public override void Perimetr()
        {
            decimal result = 2 * (decimal)Math.PI * Raduis;
            Console.WriteLine($"Aylana uzunligi:{result}");
        }

    }
}
