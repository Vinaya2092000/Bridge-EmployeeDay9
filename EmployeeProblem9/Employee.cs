using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem9
{
    // Already using class 
    public class Employee  
    {
        public int FULL_TIME = 1;
        int empHr = 0;
        int empWage = 0;
        public void Wage(string company, int wagePerHr)
        {
            Random random = new Random();
            int aCheck = random.Next(0, 2);
            if (aCheck == FULL_TIME)
            {
                empHr = 8;
                Console.WriteLine("The Employee is present");
            }
            else
            {
                empHr = 0;
                Console.WriteLine("The Employee is absent");
            }
            empWage = empHr * wagePerHr;
            Console.WriteLine("The Employee wage of " +company+ " is "+empWage);
        }
    }
}
