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
            Random random = new Random();
            int aCheck = random.Next(0, 2);
            if (aCheck == FULL_TIME)
            {
                Console.WriteLine("The Employee is present");
            }
            else
            {
                Console.WriteLine("The Employee is absent");
            }
        }
    }
}
