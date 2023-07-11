using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;
        
        public void setEmpID(int input)
        {
            empID = input;
        }

        public void setEmpName(String input)
        {
            empName = input;
        }

        public void setEmpDesignation(String input)
        {
            empDesignation = input;
        }

        public int getEmpID()
        {
            return empID;
        }

        public String getEmpName()
        {
            return empName;
        }

        public String getEmpDesignation()
        {
            return empDesignation;
        }
    }
}
