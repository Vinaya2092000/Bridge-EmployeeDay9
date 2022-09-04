using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem9
{
    public class Employee
    {
        public void Wage()
        {
            int FULL_TIME = 1;
            int PART_TIME = 2;
            int empHrs = 0;
            int wagePerHr = 20;
            int empWage = 0;
            //new operator creates an object from the class
            Random random = new Random();
            int aCheck = random.Next(0, 3);
            if (aCheck == FULL_TIME)
            {
                empHrs = 8;
                Console.WriteLine("The Employee is present Full Time");
            }
            else if (aCheck == PART_TIME)
            {
                empHrs = 4;
                Console.WriteLine("The Employee is present Part Time");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("The Employee is absent");
            }
            empWage = empHrs * wagePerHr;
            Console.WriteLine("The Employee wage is "+empWage);
        }
    }
}
