using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Employee_13
{
     class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("John Doe", 10000);
            Manager manager = new Manager("John Doe", 10000,2000);

            Console.WriteLine(employee.GetNetSalary());
            Console.WriteLine(manager.GetNetSalary());

            //employee.Name = "Ahmad";
            //employee.Salary = 2000;


            //double annualSalary = employee.CalculateAnnualSalary();
            //string salaryLevel = employee.GetAnnualSalaryLevel();

            //Console.WriteLine($"Employee Name :  {employee.Name}");
            //Console.WriteLine($"Monthly Salary: {employee.Salary}");
            //Console.WriteLine($"Annual Salary :  {annualSalary}");
            //Console.WriteLine($"Salary Level  :   {salaryLevel}");
            //Console.WriteLine("---------------------------------------------------");
            ////Console.WriteLine($"Employee Name : {employee._name}");
            //Console.WriteLine($"Monthly Salary: {employee._salary}");
            //Console.WriteLine($"Annual Salary : {employee.CalculateAnnualSalary(2000)}");
            //Console.WriteLine($"Salary Level  : {employee.GetAnnualSalaryLevel(24000)}");

        }

    }
}
