using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius value: ");
            double radius = double.Parse(Console.ReadLine());

            FindValues obj = new FindValues();

            double area = obj.findarea(radius);
            Console.WriteLine("Area: " + area);

            double cirumference = obj.findCircumference(radius);
            Console.WriteLine("Circumference: " + cirumference);

            Console.ReadKey();
        }
    }

    internal class FindValues
    {
        public FindValues()
        {
        }
    }
}
