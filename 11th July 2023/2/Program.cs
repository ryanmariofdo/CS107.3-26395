using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter number 1: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter number 2 ");
            double num2 = double.Parse(Console.ReadLine());

            Calculation calObj = new Calculation();

            calObj.setValues(num1, num2);

            Console.WriteLine("Sum: " + calObj.getSumation());
            Console.WriteLine("Sub: " + calObj.getSubtraction());
            Console.WriteLine("Mul: " + calObj.getMultiplication());
            Console.WriteLine("Div: " + calObj.getDivision());
        }
    }
}
