using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            int sum = 0;


            for (int i = 0; i<num.Length; i++)
            {
                Console.Write("Enter value: ");
                num[i] = int.Parse(Console.ReadLine ());
            }


            for(int i = 0; i < num.Length; i++)
            {
                sum = sum + num[i];
            }

            Console.ReadKey();
        }
    }
}
