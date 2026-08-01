using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_2.Day_5.Employee_13
{
     class Employee
    {
        /*
         * 2. **Employee**
            - Properties: `Name`, `Salary`
             - Functions:
             - `CalculateAnnualSalary()` → returns yearly salary
             - `GetAnnualSalaryLevel(double annualSalary)` → same but receives salary as a parameter
             - `GetAnnualSalaryLevel()` → returns salary level based on computed annual salary
         */

        //Fields
        public string _name;
        public double _salary;

        //Constructor
        public Employee(string name , double salary)
        {
            _name   = name;
            _salary = salary;
        }

        //Functions
        // ✅ الطريقة الثانية: تعتمد على الخصائص الداخلية للكائن
        public double CalculateAnnualSalary()
        {
            return _salary * 12;
        }
        public string GetAnnualSalaryLevel()
        {
            double annualSalary = CalculateAnnualSalary();
            if (annualSalary < 30000)
            {
                return "Low";
            }
            else if (annualSalary >= 30000 && annualSalary < 60000)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }

        // ✅ الطريقة الاولي: تعتمد على قيمة تمرر لها (parameter)
        public string GetAnnualSalaryLevel(double annualSalary)
        {
            if (annualSalary < 30000)
            {
                return "Low";
            }
            else if (annualSalary >= 30000 && annualSalary < 60000)
            {
                return "Medium";
            }
            else
            {
                return "High";
            }
        }
        public double CalculateAnnualSalary(double salary)
        {
            return salary * 12;
        }
    }
}
