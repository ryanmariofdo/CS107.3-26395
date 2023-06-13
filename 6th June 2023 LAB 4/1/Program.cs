using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a kilometer value: ");
        double kilometers = double.Parse(Console.ReadLine());

        ConvertValues obj = new ConvertValues();
        double meters = obj.KilometerToMeter(kilometers);

        Console.Write(meters.ToString());
        Console.ReadKey();
    }
}