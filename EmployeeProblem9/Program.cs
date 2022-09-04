namespace EmployeeProblem9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee wage computation");
            Employee employee = new Employee();
            employee.Wage("Zoro",20);
            employee.Wage("Airo", 15);
            employee.Wage("Gojo", 30);

        }
    }
}