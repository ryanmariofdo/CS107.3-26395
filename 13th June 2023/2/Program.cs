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
            Console.WriteLine("Enter 1 for Addition");
            Console.WriteLine("Enter 2 for Substraction");
            Console.WriteLine("Enter 3 for Multiplication");
            Console.WriteLine("Enter 4 for Division");

            Console.WriteLine("\nEnter your choice: ");

            string input = Console.ReadLine();

            Console.WriteLine("\n Enter number 1: ");
            double number1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\n Enter number 2: ");
            double number2 = double.Parse(Console.ReadLine());

            CalculateValues obj = new CalculateValues();

            double answer = 0;

            if (input =="1")
            {
                answer = obj.sum(number1, number2);
            }
            else if (input =="2")
            {
                answer = obj.sub(number1, number2);
            }
            else if (input =="3")
            {
                answer = obj.multi(number1, number2);
            }
            else if (input =="4")
            {
                answer = obj.divi(number1, number2);
            }

            Console.WriteLine("Answer is: " + answer);
            Console.ReadKey();
        }
    }
}
