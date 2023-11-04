using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Models
{
    internal class Figure
    {
        public virtual void Area()
        {
            Console.WriteLine("figure..");
        }
        public virtual void Perimetr()
        {
            Console.WriteLine("Perimetr");
        }
    }
}
