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
            Console.WriteLine("Enter Employee ID: ");
            String ID = Console.ReadLine();

            Console.WriteLine("Enter Employee Name: ");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Employee Destination: ");
            String designation = Console.ReadLine();

            Employee empObj = new Employee();

            empObj.setEmpID(ID);
            empObj.setEmpName(name);
            empObj.setEmpDesignation(designation);

            Console.WriteLine("Hello " +empObj.getEmpName() + "Your EmployeeID is " + empObj.getEmpID() + "and you are a " + empObj.getEmpDesignation());
        }
    }
}
