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
            int totalWorkingHrs = 100;
            int totalEmpHr = 0;
            int totalDay = 0;
            do
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
                totalEmpHr = totalEmpHr + empHrs;
                empWage = empHrs * wagePerHr;
                Console.WriteLine("Employee wage is "+empWage);
                totalDay++;
            } while (totalEmpHr <= totalWorkingHrs && totalDay < totalWorkingdays);
            Console.WriteLine("The total working days per month is " +totalWorkingdays+ " and total working hours is "+totalEmpHr);
            empWage = totalEmpHr * wagePerHr;
            Console.WriteLine("Employee wage is "+empWage);
        }
    }
}
