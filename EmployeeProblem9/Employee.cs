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
            const int FULL_TIME = 1;
            const int PART_TIME = 2;
            int empHrs = 0;
            int wagePerHr = 20;
            int empWage = 0;
            int totalWorkingdays = 20;
            int totalWage = 0;
            for (int i = 0; i < totalWorkingdays; i++)
            {
                //new operator creates an object from the class
                Random random = new Random();
                int aCheck = random.Next(0, 3);
                switch (aCheck)
                {
                    case FULL_TIME:
                        empHrs = 8;
                        Console.WriteLine("The Employee is present Full Time");
                        break;
                    case PART_TIME:
                        empHrs = 4;
                        Console.WriteLine("The Employee is present Part Time");
                        break;
                    default:
                        empHrs = 0;
                        Console.WriteLine("The Employee is absent");
                        break;
                }
                empWage = empHrs * wagePerHr;
                Console.WriteLine("The Employee wage is " + empWage);
                totalWage = totalWage + empWage;
            }
            Console.WriteLine("Total EmpWage for 20 working days is  "+totalWage);
        }
    }
}
