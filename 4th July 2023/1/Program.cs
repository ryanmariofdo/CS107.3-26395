using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the size of the array:");
            int size = int.Parse(Console.ReadLine());

            ArrayClass obj = new ArrayClass();
            int[] array = obj.arrayMethod(size);

            Console.WriteLine("Enter values for the array:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[1] + " ");
            }

            Console.ReadLine();
        }
    }
}
